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
public class IBMDLIPNHOH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority OFLIMEMMGBN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x57C4CF0", Offset = "0x57C3AF0", VA = "0x1857C4CF0")]
	public IBMDLIPNHOH(ThreadPriority DAFEPCFPBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x57C4CE0", Offset = "0x57C3AE0", VA = "0x1857C4CE0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> CHALIIACFNI(List<PlayerLoopSystem> GNCNHHEOEMG, int GBPLIGINDDJ);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct KABKNFEJDEN
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct JKGEAKPJAOE
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static FMJNLFCNDHK JDFCMGKJAPH;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x57C7230", Offset = "0x57C6030", VA = "0x1857C7230")]
				public static PlayerLoopSystem FGHAHFBMPKG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct FFLMDEABJEP
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static FMJNLFCNDHK EMENAODBBON;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x57BEF50", Offset = "0x57BDD50", VA = "0x1857BEF50")]
				public static PlayerLoopSystem FGHAHFBMPKG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct HBOCEADOPOO
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static FMJNLFCNDHK JCKGBGGCPHA;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x57C3810", Offset = "0x57C2610", VA = "0x1857C3810")]
				public static PlayerLoopSystem FGHAHFBMPKG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct BCELBLMIMEG
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static FMJNLFCNDHK ONGDAIMIEMH;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static FMJNLFCNDHK CCLMELDMLGP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static FMJNLFCNDHK BFHLMMNKGJA;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static FMJNLFCNDHK NDLIAJEMJMP;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x57B8DE0", Offset = "0x57B7BE0", VA = "0x1857B8DE0")]
				public static PlayerLoopSystem FGHAHFBMPKG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct DCOLGDKNMLL
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static FMJNLFCNDHK HJPPMPBGDLE;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x57BDC80", Offset = "0x57BCA80", VA = "0x1857BDC80")]
				public static PlayerLoopSystem FGHAHFBMPKG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct DHDCGJALGPK
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static FMJNLFCNDHK ONGDAIMIEMH;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static FMJNLFCNDHK CCLMELDMLGP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static FMJNLFCNDHK BFHLMMNKGJA;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static FMJNLFCNDHK NDLIAJEMJMP;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x57BE040", Offset = "0x57BCE40", VA = "0x1857BE040")]
				public static PlayerLoopSystem FGHAHFBMPKG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct CBCLLPGIPBF
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static FMJNLFCNDHK PPLFKEAGNJN;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x57BA5E0", Offset = "0x57B93E0", VA = "0x1857BA5E0")]
				public static PlayerLoopSystem FGHAHFBMPKG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct IPHHJMCHFNK
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static FMJNLFCNDHK IKNFHCFNBPI;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x57C61B0", Offset = "0x57C4FB0", VA = "0x1857C61B0")]
				public static PlayerLoopSystem FGHAHFBMPKG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct DGMOPPLCBBN
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static FMJNLFCNDHK NDDKOCGCKCG;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x57BDE60", Offset = "0x57BCC60", VA = "0x1857BDE60")]
				public static PlayerLoopSystem FGHAHFBMPKG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct AAKJOPBCILP
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static FMJNLFCNDHK MABGNBBAKFB;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x57B75C0", Offset = "0x57B63C0", VA = "0x1857B75C0")]
				public static PlayerLoopSystem FGHAHFBMPKG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct HABJPFFFKII
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static FMJNLFCNDHK OOHEEPMJINB;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x57C3630", Offset = "0x57C2430", VA = "0x1857C3630")]
				public static PlayerLoopSystem FGHAHFBMPKG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct BILEEFFBHBN
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class OPNIGMOJJMG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public BHAAFIIBCHE.JEKEIMFPFGP key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
					public OPNIGMOJJMG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x57CCEB0", Offset = "0x57CBCB0", VA = "0x1857CCEB0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable CKMOILBIOKO;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x57B9CD0", Offset = "0x57B8AD0", VA = "0x1857B9CD0")]
				public static PlayerLoopSystem GAMCMDMECKK(BHAAFIIBCHE.JEKEIMFPFGP PIIJMEAKDGO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct ONGICLMLHFM
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class PDFEHGNDPPG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002E")]
					public BHAAFIIBCHE.JEKEIMFPFGP key;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
					public PDFEHGNDPPG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x57CD120", Offset = "0x57CBF20", VA = "0x1857CD120")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x57CCD80", Offset = "0x57CBB80", VA = "0x1857CCD80")]
				public static PlayerLoopSystem GAMCMDMECKK(BHAAFIIBCHE.JEKEIMFPFGP PIIJMEAKDGO)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class GFJEHHPCFEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public GFJEHHPCFEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x57C0A30", Offset = "0x57BF830", VA = "0x1857C0A30")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool DEFKLJMMPMN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool PIOJOEJNGEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x57BAAC0", Offset = "0x57B98C0", VA = "0x1857BAAC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x57BAA80", Offset = "0x57B9880", VA = "0x1857BAA80")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x57BBC20", Offset = "0x57BAA20", VA = "0x1857BBC20")]
		private static void NMCCBJHOMMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x57BAB00", Offset = "0x57B9900", VA = "0x1857BAB00")]
		private static void DGDEOECEFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x57BB3D0", Offset = "0x57BA1D0", VA = "0x1857BB3D0")]
		private static void DHJIBMAOBBN(string GPKNKKDCIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x57BA850", Offset = "0x57B9650", VA = "0x1857BA850")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x57BDAC0", Offset = "0x57BC8C0", VA = "0x1857BDAC0")]
		private static void PBGPNEHHABP(BHAAFIIBCHE.JEKEIMFPFGP PIIJMEAKDGO, ref PlayerLoopSystem MJNBLEMBJGE, Type JPCOJPMJCOC, Type JKGGHMOIJPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x57BB830", Offset = "0x57BA630", VA = "0x1857BB830")]
		private static void KDGOFGJEBJE(ref PlayerLoopSystem MJNBLEMBJGE, Type JPCOJPMJCOC, Type JKGGHMOIJPN, CHALIIACFNI MDJEKLFDDMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x57BB700", Offset = "0x57BA500", VA = "0x1857BB700")]
		private static void GAIODJCFAJJ(ref PlayerLoopSystem MJNBLEMBJGE, Type JPCOJPMJCOC, Type JKGGHMOIJPN, PlayerLoopSystem? FLOIIMPOKGB, PlayerLoopSystem? PFMHBGLAJBO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class BHAAFIIBCHE
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum JEKEIMFPFGP
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class EDBFKFFPANC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly JEKEIMFPFGP FLJFHFEBFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly KGNDPGNAGCC POOMEGMBBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long JKHPMALILOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long OBCLDHBFDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long KOHDMAPDLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int OABIGOFBDJC;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x57BE680", Offset = "0x57BD480", VA = "0x1857BE680")]
		public EDBFKFFPANC(JEKEIMFPFGP GLLAKFDDJPB, int LHEKHCEOMGD = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x57BE5B0", Offset = "0x57BD3B0", VA = "0x1857BE5B0")]
		public void ELDHBHEBOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x57BE620", Offset = "0x57BD420", VA = "0x1857BE620")]
		public void JFPIMDKCPAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x57BE3B0", Offset = "0x57BD1B0", VA = "0x1857BE3B0")]
		public void EIBFCCONBNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static JEKEIMFPFGP[] PEOBAMELPIJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static EDBFKFFPANC[] BNNAEBIMNLK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x57B94E0", Offset = "0x57B82E0", VA = "0x1857B94E0")]
	public static EDBFKFFPANC FMIOJKOOGNJ(JEKEIMFPFGP PIIJMEAKDGO, int LHEKHCEOMGD = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x57B96B0", Offset = "0x57B84B0", VA = "0x1857B96B0")]
	public static EDBFKFFPANC LCGBOJGIKLM(JEKEIMFPFGP PIIJMEAKDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x57B9740", Offset = "0x57B8540", VA = "0x1857B9740")]
	public static void OHNFJMJNDHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KGNDPGNAGCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int BLKPPPMOFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Queue<double> LJCNOJLBCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double AJMPIJJCLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double JFFGPOOCEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double AECMIFEOMEA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double HLDEAKOKMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x57C7720", Offset = "0x57C6520", VA = "0x1857C7720", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x57C7780", Offset = "0x57C6580", VA = "0x1857C7780")]
	public KGNDPGNAGCC(int ANGDCBNEGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x57C75F0", Offset = "0x57C63F0", VA = "0x1857C75F0", Slot = "4")]
	public void JGCHAOPNBAE(double EKFKNNJJKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x57C7580", Offset = "0x57C6380", VA = "0x1857C7580", Slot = "5")]
	public void IOEAEKKNKLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LLKAPGPIBBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private long MIOCJKOOLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double BNHPPLFPNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double KBOIBOKIJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private double BOCBGHDNGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private double DFBHDEHEHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private double AJMPIJJCLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private double JFFGPOOCEHG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double KBDMJMHFGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xCA3180", Offset = "0xCA1F80", VA = "0x180CA3180", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double PMIIPLLOJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xCA3200", Offset = "0xCA2000", VA = "0x180CA3200", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double BCMEJIEPNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA9E630", Offset = "0xA9D430", VA = "0x180A9E630")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double HLDEAKOKMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xCA30B0", Offset = "0xCA1EB0", VA = "0x180CA30B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x57CA440", Offset = "0x57C9240", VA = "0x1857CA440", Slot = "7")]
	public void JGCHAOPNBAE(double EKFKNNJJKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x57CA400", Offset = "0x57C9200", VA = "0x1857CA400", Slot = "8")]
	public void IOEAEKKNKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x57CA570", Offset = "0x57C9370", VA = "0x1857CA570")]
	public LLKAPGPIBBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class EOFNOJHMPOI
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private interface JIBLKAEDHLL
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool MEJDOMKCJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NNHOADFEBDJ();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private abstract class JKODFMELOCC<TPromise, TMainThreadPromise> : JIBLKAEDHLL where TPromise : CCBLCAIHLNA where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly TPromise PIELCANPHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected readonly TMainThreadPromise MHAJKCJHOBL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise CNLMEEMNGCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4599780", Offset = "0x4598580", VA = "0x184599780")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MEJDOMKCJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4599700", Offset = "0x4598500", VA = "0x184599700", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3611DE0", Offset = "0x3610BE0", VA = "0x183611DE0")]
		protected JKODFMELOCC(TPromise PIELCANPHEJ, TMainThreadPromise BOENEFLCDGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4599750", Offset = "0x4598550", VA = "0x184599750", Slot = "5")]
		public void NNHOADFEBDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void CGKOPAIOBPM(TPromise PIELCANPHEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private class OFCIGLCHLPA<T> : JKODFMELOCC<global::MMBCCHGMCHN<T>, global::OHLHHHNAFPB<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1100", Offset = "0x3BCFF00", VA = "0x183BD1100")]
		public OFCIGLCHLPA(global::MMBCCHGMCHN<T> PIELCANPHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0F70", Offset = "0x3BCFD70", VA = "0x183BD0F70", Slot = "6")]
		protected override void CGKOPAIOBPM(global::MMBCCHGMCHN<T> PIELCANPHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3BD10D0", Offset = "0x3BCFED0", VA = "0x183BD10D0")]
		[CompilerGenerated]
		private void NOBHFIAKAOP(T MMPEAFKIOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE480", Offset = "0x2CDD280", VA = "0x182CDE480")]
		[CompilerGenerated]
		private void KGHFNCFCHDK(string HMOPFJALLDF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class HLMDLEBDGDO : JIBLKAEDHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly Action KNOLDLABLMF;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MEJDOMKCJJC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6B17F0", Offset = "0x6B05F0", VA = "0x1806B17F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85B5D0", Offset = "0x85A3D0", VA = "0x18085B5D0")]
		public HLMDLEBDGDO(Action KNOLDLABLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x21A7920", Offset = "0x21A6720", VA = "0x1821A7920", Slot = "5")]
		public void NNHOADFEBDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<JIBLKAEDHLL> LCEBIIDOIIB;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4078D10", Offset = "0x4077B10", VA = "0x184078D10")]
	public static global::MMBCCHGMCHN<T> ICGIINCIBNG<T>(this global::MMBCCHGMCHN<T> PIELCANPHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x57BEB40", Offset = "0x57BD940", VA = "0x1857BEB40")]
	public static void ICGIINCIBNG(Action KNOLDLABLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4078C50", Offset = "0x4077A50", VA = "0x184078C50")]
	private static global::MMBCCHGMCHN<T> BINAPFNHEFL<T>(global::MMBCCHGMCHN<T> PIELCANPHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x57BECD0", Offset = "0x57BDAD0", VA = "0x1857BECD0")]
	private static void ODNMIADCDOL(JIBLKAEDHLL MHFFJMBPGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x57BE850", Offset = "0x57BD650", VA = "0x1857BE850")]
	private static void DGHJFANIJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x57BEBD0", Offset = "0x57BD9D0", VA = "0x1857BEBD0")]
	private static void JINNLDNMACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x57BE780", Offset = "0x57BD580", VA = "0x1857BE780")]
	private static void CBIOCMCCOOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FJAJMDLPLAB
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct KOBDCPMPICC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TaskCompletionSource<Scene> HOKNLCMPABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly string PPPHPNPKCLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly LoadSceneMode HFIEOJLLEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool DCPIBGCPNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly NILMFDECOMH OIJDGGDGOKN;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x57C7F80", Offset = "0x57C6D80", VA = "0x1857C7F80")]
		public KOBDCPMPICC(TaskCompletionSource<Scene> PGKECCGGAAP, string PPPHPNPKCLP, LoadSceneMode HFIEOJLLEBE, bool DCPIBGCPNCJ, NILMFDECOMH OIJDGGDGOKN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct OLMPDIDNNCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NILMFDECOMH stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::FCHNJJOGFOB<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x57CC6C0", Offset = "0x57CB4C0", VA = "0x1857CC6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x57CCD30", Offset = "0x57CBB30", VA = "0x1857CCD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct KOOBOEOFCHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x57C7FE0", Offset = "0x57C6DE0", VA = "0x1857C7FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B0", Offset = "0x7796B0", VA = "0x18077A8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct GAMAFHNOCBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private KOBDCPMPICC <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x57C04C0", Offset = "0x57BF2C0", VA = "0x1857C04C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B0", Offset = "0x7796B0", VA = "0x18077A8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class GBBPBMIJPDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public global::OHLHHHNAFPB<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public GBBPBMIJPDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x57C0850", Offset = "0x57BF650", VA = "0x1857C0850")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct IEEMGDFGAFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private GBBPBMIJPDK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private NILMFDECOMH <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private NILMFDECOMH <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x57C4D30", Offset = "0x57C3B30", VA = "0x1857C4D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x57C56B0", Offset = "0x57C44B0", VA = "0x1857C56B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct LKAEAHLNJKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private NILMFDECOMH <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private NILMFDECOMH <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x57C9B70", Offset = "0x57C8970", VA = "0x1857C9B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x57CA3B0", Offset = "0x57C91B0", VA = "0x1857CA3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class MAAPPKKCMOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public MAAPPKKCMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x57CA5A0", Offset = "0x57C93A0", VA = "0x1857CA5A0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class AHKKFPADIBM : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private ELOHAHHPMGF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public HGIFEALIPIB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public AHKKFPADIBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x57B83F0", Offset = "0x57B71F0", VA = "0x1857B83F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x57B8090", Offset = "0x57B6E90", VA = "0x1857B8090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x57B8480", Offset = "0x57B7280", VA = "0x1857B8480")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x57B83B0", Offset = "0x57B71B0", VA = "0x1857B83B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class MBICBEMLIEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public global::OHLHHHNAFPB<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public MBICBEMLIEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class JEDJFNOENJN : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private ELOHAHHPMGF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public global::OHLHHHNAFPB<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private MBICBEMLIEK <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public JEDJFNOENJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x57C6690", Offset = "0x57C5490", VA = "0x1857C6690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x57C6AE0", Offset = "0x57C58E0", VA = "0x1857C6AE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static CCBLCAIHLNA EGDLGILPGAG;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AsyncOperation MNGMBKOCCAO;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static CCBLCAIHLNA GAGDOJKAIOG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static string DNHJOJLPKND;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ThreadPriority NEJCEMBOEMO;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Task DKDPNKCHLPD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Queue<KOBDCPMPICC> LLFCAOFHDLL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Task FBJJMDJBIPP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool MABHKBFMEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x57BF2D0", Offset = "0x57BE0D0", VA = "0x1857BF2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool EADMPAIPFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x57BF6E0", Offset = "0x57BE4E0", VA = "0x1857BF6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool BOCNKGEALAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x57BFA30", Offset = "0x57BE830", VA = "0x1857BFA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> FPIAJENBLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x57BFE20", Offset = "0x57BEC20", VA = "0x1857BFE20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x57BFC50", Offset = "0x57BEA50", VA = "0x1857BFC50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x57BFD50", Offset = "0x57BEB50", VA = "0x1857BFD50")]
	[CIBCLNKDGPH(MOOMEKEKHGD.EnteredEditModeNextFrame, 0)]
	private static void NPCBLBDIJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x57BF790", Offset = "0x57BE590", VA = "0x1857BF790")]
	[AsyncStateMachine(typeof(OLMPDIDNNCK))]
	public static Task<Scene> JHKGJNAGGID(string PPPHPNPKCLP, LoadSceneMode HFIEOJLLEBE = LoadSceneMode.Single, bool DCPIBGCPNCJ = false, [Optional] NILMFDECOMH NFOHHMOFHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x57BF610", Offset = "0x57BE410", VA = "0x1857BF610")]
	[AsyncStateMachine(typeof(KOOBOEOFCHJ))]
	private static Task HDIAMHLGKOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x57BF490", Offset = "0x57BE290", VA = "0x1857BF490")]
	[AsyncStateMachine(typeof(GAMAFHNOCBC))]
	private static Task DCCNCPCBOGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x57BFAF0", Offset = "0x57BE8F0", VA = "0x1857BFAF0")]
	[AsyncStateMachine(typeof(IEEMGDFGAFI))]
	private static Task<Scene> LOKANFKPBHC(string PPPHPNPKCLP, LoadSceneMode HFIEOJLLEBE, bool DCPIBGCPNCJ, NILMFDECOMH OIJDGGDGOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x57BF8F0", Offset = "0x57BE6F0", VA = "0x1857BF8F0")]
	[AsyncStateMachine(typeof(LKAEAHLNJKM))]
	private static Task<Scene> KBHEAKBGDCE(NILMFDECOMH OIJDGGDGOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x57BF130", Offset = "0x57BDF30", VA = "0x1857BF130")]
	public static global::MMBCCHGMCHN<Scene> BFNJAJEPIBN(string PPPHPNPKCLP, LoadSceneMode HFIEOJLLEBE = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x57C0120", Offset = "0x57BEF20", VA = "0x1857C0120")]
	public static CCBLCAIHLNA POBDFLGHLJJ(string PPPHPNPKCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x57BF580", Offset = "0x57BE380", VA = "0x1857BF580")]
	[IteratorStateMachine(typeof(AHKKFPADIBM))]
	private static IEnumerator<ELOHAHHPMGF> EPNLCIKLGEC(string PPPHPNPKCLP, HGIFEALIPIB LIPNENLMLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x57BFF20", Offset = "0x57BED20", VA = "0x1857BFF20")]
	[IteratorStateMachine(typeof(JEDJFNOENJN))]
	private static IEnumerator<ELOHAHHPMGF> PHIHODIHDHE(string PPPHPNPKCLP, LoadSceneMode HFIEOJLLEBE, global::OHLHHHNAFPB<Scene> LIPNENLMLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x57BFFC0", Offset = "0x57BEDC0", VA = "0x1857BFFC0")]
	public static bool PKPEGDJFJOB(out string PLGGKHOFLFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GFLGIPFHDOB
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x57C0B50", Offset = "0x57BF950", VA = "0x1857C0B50")]
	public static IDisposable AMLACCKCDAN(this NLFKOLIGGGC KPJEGNGKPOH, float CAGAEJAPLKP, Action<float> COEFDEGAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x57C0BD0", Offset = "0x57BF9D0", VA = "0x1857C0BD0")]
	public static IDisposable DIAFCAJOJGH(this NLFKOLIGGGC KPJEGNGKPOH, Action<float> COEFDEGAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x57C0C50", Offset = "0x57BFA50", VA = "0x1857C0C50")]
	public static IDisposable PEBKBJANCED(this NLFKOLIGGGC KPJEGNGKPOH, Action<float> COEFDEGAPFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class MGDEOGCLODP
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x57CBC10", Offset = "0x57CAA10", VA = "0x1857CBC10")]
	public static IDisposable PKMLPIAFPDL(this MonoBehaviour BACHLBJINBI, Action COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x57CBC90", Offset = "0x57CAA90", VA = "0x1857CBC90")]
	public static IDisposable PKMLPIAFPDL(this MonoBehaviour BACHLBJINBI, Action<float> COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x57CBBA0", Offset = "0x57CA9A0", VA = "0x1857CBBA0")]
	public static IDisposable PGLCEDHDGGL(this MonoBehaviour BACHLBJINBI, Action COEFDEGAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x57CBA80", Offset = "0x57CA880", VA = "0x1857CBA80")]
	public static IDisposable OIJDAGOPMIO(this MonoBehaviour BACHLBJINBI, Action COEFDEGAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x57CBD10", Offset = "0x57CAB10", VA = "0x1857CBD10")]
	public static IDisposable PLOOKOMEMDE(this MonoBehaviour BACHLBJINBI, Action COEFDEGAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x57CB980", Offset = "0x57CA780", VA = "0x1857CB980")]
	public static IDisposable NFKELBLDIDK(this MonoBehaviour BACHLBJINBI, Action COEFDEGAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x57CBA00", Offset = "0x57CA800", VA = "0x1857CBA00")]
	public static IDisposable OGEFIPAEEKN(this MonoBehaviour BACHLBJINBI, Action COEFDEGAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x57CB7C0", Offset = "0x57CA5C0", VA = "0x1857CB7C0")]
	public static IDisposable IABMGKIIMJN(this MonoBehaviour BACHLBJINBI, float CAGAEJAPLKP, Action<float> COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM, bool DPOJEFOJKNL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x57CBB00", Offset = "0x57CA900", VA = "0x1857CBB00")]
	public static IDisposable PAJOGGKDECE(this MonoBehaviour BACHLBJINBI, float CAGAEJAPLKP, Action<float> COEFDEGAPFE, bool DPOJEFOJKNL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x57CB570", Offset = "0x57CA370", VA = "0x1857CB570")]
	public static IDisposable ECBKHMBOJHN(this MonoBehaviour BACHLBJINBI, Action<float> COEFDEGAPFE, bool DPOJEFOJKNL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x57CB3C0", Offset = "0x57CA1C0", VA = "0x1857CB3C0")]
	public static IDisposable AMACMBAPNKD(this MonoBehaviour BACHLBJINBI, Action<float> COEFDEGAPFE, bool DPOJEFOJKNL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x57CB450", Offset = "0x57CA250", VA = "0x1857CB450")]
	public static IDisposable CMBFBEHMFFK(this MonoBehaviour BACHLBJINBI, Action<float> COEFDEGAPFE, bool DPOJEFOJKNL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x57CB6A0", Offset = "0x57CA4A0", VA = "0x1857CB6A0")]
	public static IDisposable FPMJKIDMIFN(this MonoBehaviour BACHLBJINBI, Action<float> COEFDEGAPFE, bool DPOJEFOJKNL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x57CB730", Offset = "0x57CA530", VA = "0x1857CB730")]
	public static IDisposable HHDGBHCOLNJ(this MonoBehaviour BACHLBJINBI, Action<float> COEFDEGAPFE, bool DPOJEFOJKNL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x57CB8F0", Offset = "0x57CA6F0", VA = "0x1857CB8F0")]
	public static IDisposable KDAINFBDOCD(this MonoBehaviour BACHLBJINBI, Action<float> COEFDEGAPFE, bool DPOJEFOJKNL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x57CB4E0", Offset = "0x57CA2E0", VA = "0x1857CB4E0")]
	public static IDisposable DBGMKOAEDOC(this MonoBehaviour BACHLBJINBI, Action<float> COEFDEGAPFE, bool DPOJEFOJKNL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x57CB600", Offset = "0x57CA400", VA = "0x1857CB600")]
	public static IDisposable EEMJIAGPACM(this MonoBehaviour BACHLBJINBI, float CAGAEJAPLKP, Action<float> COEFDEGAPFE, bool DPOJEFOJKNL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x57CB860", Offset = "0x57CA660", VA = "0x1857CB860")]
	public static IDisposable KAOEOHHGCGL(this MonoBehaviour BACHLBJINBI, Action<float> COEFDEGAPFE, bool DPOJEFOJKNL = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BHLKFBKBBEG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class MIKKHGNIFMF : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private ELOHAHHPMGF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public DAAICDPBDKL.EJJBPOJLCLK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private EODGDJBLHIK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public MIKKHGNIFMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x57CBD90", Offset = "0x57CAB90", VA = "0x1857CBD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x57CBE50", Offset = "0x57CAC50", VA = "0x1857CBE50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class JOBOOLGFFKE : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private ELOHAHHPMGF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public DAAICDPBDKL.EJJBPOJLCLK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private EODGDJBLHIK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public JOBOOLGFFKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x57C7450", Offset = "0x57C6250", VA = "0x1857C7450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x57C7540", Offset = "0x57C6340", VA = "0x1857C7540", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x57B9C20", Offset = "0x57B8A20", VA = "0x1857B9C20")]
	public static MANCEBNIGPM PKMLPIAFPDL(Action COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x57B9A50", Offset = "0x57B8850", VA = "0x1857B9A50")]
	public static MANCEBNIGPM PKMLPIAFPDL(Behaviour KPJEGNGKPOH, Action COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x57B9B10", Offset = "0x57B8910", VA = "0x1857B9B10")]
	public static MANCEBNIGPM PKMLPIAFPDL(Behaviour KPJEGNGKPOH, Action<float> COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x57B9950", Offset = "0x57B8750", VA = "0x1857B9950")]
	[IteratorStateMachine(typeof(MIKKHGNIFMF))]
	private static IEnumerator<ELOHAHHPMGF> LDEIADEHHLF(DAAICDPBDKL.EJJBPOJLCLK HEDKEAMNACE, Action COEFDEGAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x57B99D0", Offset = "0x57B87D0", VA = "0x1857B99D0")]
	[IteratorStateMachine(typeof(JOBOOLGFFKE))]
	private static IEnumerator<ELOHAHHPMGF> LDEIADEHHLF(DAAICDPBDKL.EJJBPOJLCLK HEDKEAMNACE, Action<float> COEFDEGAPFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class AMMACNOPLEL
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class GELKHIGNJIA : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private ELOHAHHPMGF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public DDBNFLLNFIM schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public DAAICDPBDKL.EJJBPOJLCLK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private CDACINJFEGH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public GELKHIGNJIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x57C08B0", Offset = "0x57BF6B0", VA = "0x1857C08B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x57C09F0", Offset = "0x57BF7F0", VA = "0x1857C09F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x57B8BD0", Offset = "0x57B79D0", VA = "0x1857B8BD0")]
	public static MANCEBNIGPM PKMLPIAFPDL(float CAGAEJAPLKP, Action<float> COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM, bool DPOJEFOJKNL = true, [Optional] HFNDABHEJNE LMJBEMHEKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x57B8CD0", Offset = "0x57B7AD0", VA = "0x1857B8CD0")]
	public static MANCEBNIGPM PKMLPIAFPDL(MonoBehaviour BACHLBJINBI, float CAGAEJAPLKP, Action<float> COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM, bool DPOJEFOJKNL = true, [Optional] HFNDABHEJNE LMJBEMHEKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x57B8A10", Offset = "0x57B7810", VA = "0x1857B8A10")]
	public static MANCEBNIGPM AOMOPCLOJFB(NLFKOLIGGGC KPJEGNGKPOH, float CAGAEJAPLKP, Action<float> COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM, bool DPOJEFOJKNL = true, [Optional] HFNDABHEJNE LMJBEMHEKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x57B8B20", Offset = "0x57B7920", VA = "0x1857B8B20")]
	[IteratorStateMachine(typeof(GELKHIGNJIA))]
	private static IEnumerator<ELOHAHHPMGF> LDEIADEHHLF(DDBNFLLNFIM OLIEAHOGPGO, float CAGAEJAPLKP, DAAICDPBDKL.EJJBPOJLCLK HEDKEAMNACE, Action<float> COEFDEGAPFE, bool DPOJEFOJKNL = true, [Optional] HFNDABHEJNE LMJBEMHEKFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class IMAGPEDKOPI
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class ILPLOPBHAGO : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private ELOHAHHPMGF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public DAAICDPBDKL.EJJBPOJLCLK queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public ILPLOPBHAGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x57C5F30", Offset = "0x57C4D30", VA = "0x1857C5F30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x57C5FE0", Offset = "0x57C4DE0", VA = "0x1857C5FE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x57C6020", Offset = "0x57C4E20", VA = "0x1857C6020")]
	[IteratorStateMachine(typeof(ILPLOPBHAGO))]
	private static IEnumerator<ELOHAHHPMGF> BOIGMNFIBCH(DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM, Func<bool> IECCFOAPPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x57C60A0", Offset = "0x57C4EA0", VA = "0x1857C60A0")]
	public static MANCEBNIGPM CKDKLLEELAI(this MonoBehaviour BACHLBJINBI, Func<bool> IECCFOAPPOM, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM = DAAICDPBDKL.EJJBPOJLCLK.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class IHONICFINGI
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class KLCMHMDDMFD : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private ELOHAHHPMGF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public DAAICDPBDKL.EJJBPOJLCLK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public KLCMHMDDMFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x57C7E80", Offset = "0x57C6C80", VA = "0x1857C7E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x57C7F40", Offset = "0x57C6D40", VA = "0x1857C7F40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x57C58C0", Offset = "0x57C46C0", VA = "0x1857C58C0")]
	[IteratorStateMachine(typeof(KLCMHMDDMFD))]
	private static IEnumerator<ELOHAHHPMGF> FHEEHPPEFMO(float MDHNFEOEMPO, DAAICDPBDKL.EJJBPOJLCLK HEDKEAMNACE, Action PNCAEBHDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x57C5800", Offset = "0x57C4600", VA = "0x1857C5800")]
	public static MANCEBNIGPM DGKNDCAHKEF(this MonoBehaviour BACHLBJINBI, float MDHNFEOEMPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x57C5D30", Offset = "0x57C4B30", VA = "0x1857C5D30")]
	public static MANCEBNIGPM NAHIEDEFHEN(this MonoBehaviour BACHLBJINBI, Action PNCAEBHDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x57C5B00", Offset = "0x57C4900", VA = "0x1857C5B00")]
	public static MANCEBNIGPM IEJGJEKPBMM(this MonoBehaviour BACHLBJINBI, Action PNCAEBHDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x57C5950", Offset = "0x57C4750", VA = "0x1857C5950")]
	public static MANCEBNIGPM GNLPAFDKPIP(this MonoBehaviour BACHLBJINBI, Action PNCAEBHDNMM, [Optional] HFNDABHEJNE LMJBEMHEKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x57C5C00", Offset = "0x57C4A00", VA = "0x1857C5C00")]
	public static MANCEBNIGPM KKJIAHNNAPO(this MonoBehaviour BACHLBJINBI, Action PNCAEBHDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x57C57D0", Offset = "0x57C45D0", VA = "0x1857C57D0")]
	public static MANCEBNIGPM AMFNOMAHNLA(this MonoBehaviour BACHLBJINBI, Action PNCAEBHDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x57C5D00", Offset = "0x57C4B00", VA = "0x1857C5D00")]
	public static MANCEBNIGPM LONGHDGIFLK(this MonoBehaviour BACHLBJINBI, Action PNCAEBHDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x57C5C30", Offset = "0x57C4A30", VA = "0x1857C5C30")]
	private static MANCEBNIGPM KMMJBLPAKBA(MonoBehaviour BACHLBJINBI, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM, Action PNCAEBHDNMM, [Optional] HFNDABHEJNE LMJBEMHEKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x57C5B30", Offset = "0x57C4930", VA = "0x1857C5B30")]
	public static MANCEBNIGPM IGCALIJDLGJ(this MonoBehaviour BACHLBJINBI, float GIFGHIDBHEM, Action PNCAEBHDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x57C5700", Offset = "0x57C4500", VA = "0x1857C5700")]
	public static MANCEBNIGPM AHHKNMAKEPN(this MonoBehaviour BACHLBJINBI, float GIFGHIDBHEM, Action PNCAEBHDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x57C5D50", Offset = "0x57C4B50", VA = "0x1857C5D50")]
	public static MANCEBNIGPM PCKFMMAOKFF(this MonoBehaviour BACHLBJINBI, float GIFGHIDBHEM, Action PNCAEBHDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x57C5A30", Offset = "0x57C4830", VA = "0x1857C5A30")]
	public static MANCEBNIGPM GPMEAPFNFBA(this MonoBehaviour BACHLBJINBI, float GIFGHIDBHEM, Action PNCAEBHDNMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class PJKOGNLICJB : KNIIKCBCOEP, IEnumerable<KNIIKCBCOEP>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly List<KNIIKCBCOEP> JCKAKIPJOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool DBICCFMJPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Action BHIMJAHDKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool OJGPOMCNMDN;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool IPLGBMMMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x57CE4D0", Offset = "0x57CD2D0", VA = "0x1857CE4D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DJPOIGJJDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x57CE610", Offset = "0x57CD410", VA = "0x1857CE610", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x57CEB10", Offset = "0x57CD910", VA = "0x1857CEB10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x57CEBB0", Offset = "0x57CD9B0", VA = "0x1857CEBB0")]
	public PJKOGNLICJB([Optional] Action BHIMJAHDKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x57CE3A0", Offset = "0x57CD1A0", VA = "0x1857CE3A0")]
	public void HMNAIPBHJIK(KNIIKCBCOEP HACLHFAFEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x57CE6B0", Offset = "0x57CD4B0", VA = "0x1857CE6B0")]
	private void LEDILIIOIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x57CE820", Offset = "0x57CD620", VA = "0x1857CE820", Slot = "7")]
	public bool LIIKGGGPDHM(bool PAKHNBOHLFK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x57CE830", Offset = "0x57CD630", VA = "0x1857CE830", Slot = "8")]
	public bool LIIKGGGPDHM(Action KNOLDLABLMF, bool PAKHNBOHLFK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x57CE320", Offset = "0x57CD120", VA = "0x1857CE320", Slot = "9")]
	public IEnumerator<KNIIKCBCOEP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x57CE320", Offset = "0x57CD120", VA = "0x1857CE320", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JDNBLLOGOKI : KKHAGABPODN
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class POKPKPFBPPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public JDNBLLOGOKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public POKPKPFBPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x57C4BA0", Offset = "0x57C39A0", VA = "0x1857C4BA0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class HGOJJDDFFGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public JDNBLLOGOKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public HGOJJDDFFGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x57C4BA0", Offset = "0x57C39A0", VA = "0x1857C4BA0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly float CHPNKDOGNGB;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x57C6590", Offset = "0x57C5390", VA = "0x1857C6590")]
	public JDNBLLOGOKI(Behaviour KPJEGNGKPOH, float CHPNKDOGNGB, [Optional] Action BHIMJAHDKAC, [Optional] HFNDABHEJNE LMJBEMHEKFO, [Optional] DDBNFLLNFIM OLIEAHOGPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x57C6390", Offset = "0x57C5190", VA = "0x1857C6390", Slot = "9")]
	protected override bool AALKOJNKANM(Action KNOLDLABLMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x57C6490", Offset = "0x57C5290", VA = "0x1857C6490", Slot = "10")]
	protected override bool APGFDDMAPAM(Action KNOLDLABLMF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface KNIIKCBCOEP
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool IPLGBMMMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DJPOIGJJDJF;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LIIKGGGPDHM(bool PAKHNBOHLFK = false);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LIIKGGGPDHM(Action KNOLDLABLMF, bool PAKHNBOHLFK = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class KKHAGABPODN : KNIIKCBCOEP
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class OAMACCPFIKO : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private ELOHAHHPMGF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public KKHAGABPODN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public OAMACCPFIKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x57CC5B0", Offset = "0x57CB3B0", VA = "0x1857CC5B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x57CC680", Offset = "0x57CB480", VA = "0x1857CC680", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Behaviour KPJEGNGKPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Action BHIMJAHDKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private JEMCAFGLPLG FGADEHPHFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly HFNDABHEJNE LMJBEMHEKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	protected readonly DDBNFLLNFIM OLIEAHOGPGO;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IPLGBMMMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xBFA0F0", Offset = "0xBF8EF0", VA = "0x180BFA0F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DJPOIGJJDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x57C7B10", Offset = "0x57C6910", VA = "0x1857C7B10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x57C7CE0", Offset = "0x57C6AE0", VA = "0x1857C7CE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x57C7D80", Offset = "0x57C6B80", VA = "0x1857C7D80")]
	protected KKHAGABPODN(Behaviour KPJEGNGKPOH, [Optional] Action BHIMJAHDKAC, [Optional] HFNDABHEJNE LMJBEMHEKFO, [Optional] DDBNFLLNFIM OLIEAHOGPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x57C7BB0", Offset = "0x57C69B0", VA = "0x1857C7BB0", Slot = "7")]
	public bool LIIKGGGPDHM(bool PAKHNBOHLFK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x57C7C10", Offset = "0x57C6A10", VA = "0x1857C7C10", Slot = "8")]
	public bool LIIKGGGPDHM(Action KNOLDLABLMF, bool PAKHNBOHLFK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool AALKOJNKANM(Action KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool APGFDDMAPAM(Action KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x57C7A70", Offset = "0x57C6870", VA = "0x1857C7A70")]
	protected void EEMJEFHEEFP(Action KNOLDLABLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x57C7870", Offset = "0x57C6670", VA = "0x1857C7870")]
	protected CCBLCAIHLNA CPMLHPMAHDG(float PKBACDJFJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x57C7C60", Offset = "0x57C6A60", VA = "0x1857C7C60")]
	private void MJJBBGMEDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x57C7A90", Offset = "0x57C6890", VA = "0x1857C7A90")]
	[IteratorStateMachine(typeof(OAMACCPFIKO))]
	private IEnumerator<ELOHAHHPMGF> GFGDDJKIMOE(float PKBACDJFJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x57C7830", Offset = "0x57C6630", VA = "0x1857C7830")]
	[CompilerGenerated]
	private void AFAFKHKLGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class BGHEJMIPCHF : KKHAGABPODN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly float OEAFPIOEDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly int KACEIIFDKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly float OEALBLLNNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float[] LIKKBFFGCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int DDFIEJPPJJG;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x57B9330", Offset = "0x57B8130", VA = "0x1857B9330")]
	public BGHEJMIPCHF(Behaviour KPJEGNGKPOH, float HFPIMIDHCAA, int KACEIIFDKHO, [Optional] Action BHIMJAHDKAC, float OEALBLLNNFG = 0f, [Optional] HFNDABHEJNE LMJBEMHEKFO, [Optional] DDBNFLLNFIM OLIEAHOGPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00", Slot = "9")]
	protected override bool AALKOJNKANM(Action KNOLDLABLMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x57B9070", Offset = "0x57B7E70", VA = "0x1857B9070", Slot = "10")]
	protected override bool APGFDDMAPAM(Action KNOLDLABLMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x57B92A0", Offset = "0x57B80A0", VA = "0x1857B92A0")]
	private void CCGOACDDJCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class NBPKFOJNGGD : KKHAGABPODN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly float CHPNKDOGNGB;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x57C6590", Offset = "0x57C5390", VA = "0x1857C6590")]
	public NBPKFOJNGGD(Behaviour KPJEGNGKPOH, float CHPNKDOGNGB, [Optional] Action BHIMJAHDKAC, [Optional] HFNDABHEJNE LMJBEMHEKFO, [Optional] DDBNFLLNFIM OLIEAHOGPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00", Slot = "9")]
	protected override bool AALKOJNKANM(Action KNOLDLABLMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x57CBE90", Offset = "0x57CAC90", VA = "0x1857CBE90", Slot = "10")]
	protected override bool APGFDDMAPAM(Action KNOLDLABLMF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class AFDFJFHJPJI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class DOCPNECGEND : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private ELOHAHHPMGF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public DOCPNECGEND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x57BE2D0", Offset = "0x57BD0D0", VA = "0x1857BE2D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x57BE370", Offset = "0x57BD170", VA = "0x1857BE370", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private MANCEBNIGPM JFNDIOICBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NLFKOLIGGGC KPJEGNGKPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action<float> KEECIBNLMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private float GKJANHIJMNE;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x57B7DC0", Offset = "0x57B6BC0", VA = "0x1857B7DC0")]
	public AFDFJFHJPJI(NLFKOLIGGGC KPJEGNGKPOH, float CAGAEJAPLKP, Action<float> COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x57B7900", Offset = "0x57B6700", VA = "0x1857B7900")]
	private void HDPMHLFEBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x57B7C60", Offset = "0x57B6A60", VA = "0x1857B7C60")]
	private void JEEEJGCJCJP(string HMOPFJALLDF, Action DFJEAJHACAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x57B7890", Offset = "0x57B6690", VA = "0x1857B7890")]
	[IteratorStateMachine(typeof(DOCPNECGEND))]
	private IEnumerator<ELOHAHHPMGF> FCKMPNNIOKE(Action DFJEAJHACAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x57B7830", Offset = "0x57B6630", VA = "0x1857B7830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x57B7AB0", Offset = "0x57B68B0", VA = "0x1857B7AB0")]
	[CompilerGenerated]
	private void ILBJPLAMFIB(string PBDFKDHMIEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class PGHKLONPLKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class AGEAANLMNKF : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private ELOHAHHPMGF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public AGEAANLMNKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x57B7FB0", Offset = "0x57B6DB0", VA = "0x1857B7FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x57B8050", Offset = "0x57B6E50", VA = "0x1857B8050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private MANCEBNIGPM JFNDIOICBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private MonoBehaviour BACHLBJINBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Action COEFDEGAPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Action<float> KEECIBNLMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private float GKJANHIJMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool DPOJEFOJKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly HFNDABHEJNE LMJBEMHEKFO;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x57CE0E0", Offset = "0x57CCEE0", VA = "0x1857CE0E0")]
	public PGHKLONPLKE(MonoBehaviour BACHLBJINBI, Action COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM, [Optional] HFNDABHEJNE LMJBEMHEKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x57CDEA0", Offset = "0x57CCCA0", VA = "0x1857CDEA0")]
	public PGHKLONPLKE(MonoBehaviour BACHLBJINBI, Action<float> COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM, [Optional] HFNDABHEJNE LMJBEMHEKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x57CDC40", Offset = "0x57CCA40", VA = "0x1857CDC40")]
	public PGHKLONPLKE(MonoBehaviour BACHLBJINBI, float CAGAEJAPLKP, Action<float> COEFDEGAPFE, DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM, bool DPOJEFOJKNL = true, [Optional] HFNDABHEJNE LMJBEMHEKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x57CDAD0", Offset = "0x57CC8D0", VA = "0x1857CDAD0")]
	private void PKMLPIAFPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x57CD630", Offset = "0x57CC430", VA = "0x1857CD630")]
	private void FOFPJALGOJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x57CD7E0", Offset = "0x57CC5E0", VA = "0x1857CD7E0")]
	private void HDPMHLFEBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x57CD9A0", Offset = "0x57CC7A0", VA = "0x1857CD9A0")]
	private void JEEEJGCJCJP(string HMOPFJALLDF, Action DFJEAJHACAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x57CD5C0", Offset = "0x57CC3C0", VA = "0x1857CD5C0")]
	[IteratorStateMachine(typeof(AGEAANLMNKF))]
	private IEnumerator<ELOHAHHPMGF> FCKMPNNIOKE(Action DFJEAJHACAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x57CD4D0", Offset = "0x57CC2D0", VA = "0x1857CD4D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x57CD3B0", Offset = "0x57CC1B0", VA = "0x1857CD3B0")]
	[CompilerGenerated]
	private void AHNHHFGAOHI(string PBDFKDHMIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x57CD440", Offset = "0x57CC240", VA = "0x1857CD440")]
	[CompilerGenerated]
	private void CCOEFCJMAKI(string PBDFKDHMIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x57CD530", Offset = "0x57CC330", VA = "0x1857CD530")]
	[CompilerGenerated]
	private void EKOLPHMKAFG(string PBDFKDHMIEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum NNIKANPLIAM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class NCOOOJGAGFA : DDBNFLLNFIM
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float FPINDHLABHF
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x57CBED0", Offset = "0x57CACD0", VA = "0x1857CBED0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float LNLBONMLEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x57CBF00", Offset = "0x57CAD00", VA = "0x1857CBF00", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public double HMPMJHLCGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x57CBEE0", Offset = "0x57CACE0", VA = "0x1857CBEE0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x57CBF10", Offset = "0x57CAD10", VA = "0x1857CBF10")]
	[EJICMPGFCBP(CIKEJIGJNLD.None)]
	private static void PMFNJDEOCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	[Preserve]
	internal NCOOOJGAGFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface JAOOPCIFPAF
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAFPCJLJAKL(string IADPDEAGFAB);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOCDCGLCDKC();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface NECNEGGKBCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string ADMEEJPABPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool NJGPOAGJMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool ADOHMGAGHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class AKJMMCEOMAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public GLOFNPFPAIM PFLNPBFBJII;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int EBAKNIMBLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7332F0", Offset = "0x7320F0", VA = "0x1807332F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x733300", Offset = "0x732100", VA = "0x180733300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x57B86F0", Offset = "0x57B74F0", VA = "0x1857B86F0")]
	public static ELOHAHHPMGF HMADLOMDEML(IEnumerator<ELOHAHHPMGF> PLJNLNLCNGA, ACJHPGLJCBN HNFKIAKOCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x57B8610", Offset = "0x57B7410", VA = "0x1857B8610")]
	public ELOHAHHPMGF HMADLOMDEML(ACJHPGLJCBN[] BFNCANDEFEL, IEnumerator<ELOHAHHPMGF>[] NHHOMNDPAKB, ELOHAHHPMGF[] FDNJLGGEMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x57B88A0", Offset = "0x57B76A0", VA = "0x1857B88A0")]
	public void NIFIGOMGFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x57B84D0", Offset = "0x57B72D0", VA = "0x1857B84D0")]
	public void BDHENCMNMIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x57B88D0", Offset = "0x57B76D0", VA = "0x1857B88D0")]
	public void LGPPILALLBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x57B88A0", Offset = "0x57B76A0", VA = "0x1857B88A0")]
	public void KJMCNJCBCGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public AKJMMCEOMAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class GLOFNPFPAIM
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct BFAGKBJHKLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public AKJMMCEOMAD GFJEKABBFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public NLFKOLIGGGC FNGABLEBEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public ACJHPGLJCBN NOFEKBFPLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public IEnumerator<ELOHAHHPMGF> FKPKIGDOAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ELOHAHHPMGF JNOBHIBOEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public NNIKANPLIAM PFCFCIIPEMO;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct DHMDOHPEOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public DAAICDPBDKL.EJJBPOJLCLK GLLLPIKBOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<BFAGKBJHKLA> IMIPOJEPPEA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class BKINCNADFNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public ACJHPGLJCBN promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GLOFNPFPAIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public NLFKOLIGGGC context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public AKJMMCEOMAD routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public NNIKANPLIAM coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public ELOHAHHPMGF currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public IEnumerator<ELOHAHHPMGF> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public BKINCNADFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x57B9E00", Offset = "0x57B8C00", VA = "0x1857B9E00")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GIPJLOIMGJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AKJMMCEOMAD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public GLOFNPFPAIM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public GIPJLOIMGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x57C0CD0", Offset = "0x57BFAD0", VA = "0x1857C0CD0")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JNHBNHIOIHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AKJMMCEOMAD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public GLOFNPFPAIM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public JNHBNHIOIHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x57C7410", Offset = "0x57C6210", VA = "0x1857C7410")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class PHHJNDOMMNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public AKJMMCEOMAD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public GLOFNPFPAIM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public PHHJNDOMMNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x57CE2E0", Offset = "0x57CD0E0", VA = "0x1857CE2E0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const NNIKANPLIAM AFLOBEKFFPN = NNIKANPLIAM.Cancelled | NNIKANPLIAM.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool[] IEDNGBALFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<NNIKANPLIAM> AFJNHMMHOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<float> LCMCHDOMDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<int> ADPMGMMJODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<int> AGCBIABNLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<int> OFFFHAKLBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<int> KNDHFHOKENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<int> PNKLBNLBHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private AKJMMCEOMAD[] CIFEIEPANJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private ACJHPGLJCBN[] BFNCANDEFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NLFKOLIGGGC[] HJOFEJKDNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private IEnumerator<ELOHAHHPMGF>[] MLKELJILIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private ELOHAHHPMGF[] COCHJPEKDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int HEOANBKKBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int CIMAPKKBLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly int EILLENDCLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float OBNGDBDBKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NGDMBIENEPK ADHFGKFGACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private JobHandle FLOPGNIBGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private List<AKJMMCEOMAD> HJMHEPLKFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool IGIOEKGFILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private List<Action> EJLPJDINJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private List<Action> AOOLIBJAFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private bool IFAIHPJAIJG;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DHMDOHPEOGJ[] FNEDHHJMANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8362B0", Offset = "0x8350B0", VA = "0x1808362B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x57C2890", Offset = "0x57C1690", VA = "0x1857C2890")]
	private static int KLJNOBELJLD(DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x57C3030", Offset = "0x57C1E30", VA = "0x1857C3030")]
	public GLOFNPFPAIM(DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x57C2470", Offset = "0x57C1270", VA = "0x1857C2470")]
	private void KEGJNIEJKBM(ref int OCABHEKCEEE, int GHBPBCOCGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x57C19D0", Offset = "0x57C07D0", VA = "0x1857C19D0")]
	public void BFIGHKOBFEK(NLFKOLIGGGC KPJEGNGKPOH, ELOHAHHPMGF MPBDHBFNLOJ, IEnumerator<ELOHAHHPMGF> PLJNLNLCNGA, ACJHPGLJCBN HNFKIAKOCJI, [Optional] AKJMMCEOMAD LNNHBHHABHN, NNIKANPLIAM IHEMCEGMLAI = NNIKANPLIAM.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x57C20A0", Offset = "0x57C0EA0", VA = "0x1857C20A0")]
	public void HAMDIHHFDGH(IEnumerable<BFAGKBJHKLA> HKEMOJKIKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x57C14C0", Offset = "0x57C02C0", VA = "0x1857C14C0")]
	private BFAGKBJHKLA BBIJLDJCIIO(int PADOIKGMOKG)
	{
		return default(BFAGKBJHKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x57C1D00", Offset = "0x57C0B00", VA = "0x1857C1D00")]
	private void GMPIEICCPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3A26B40", Offset = "0x3A25940", VA = "0x183A26B40")]
	private static void OGOPCIDPODH<T>(int PADOIKGMOKG, T[] GCNMGLIJHGM, int BDHBBDMMOKG, [Optional] T DDDAMIICLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3A26B20", Offset = "0x3A25920", VA = "0x183A26B20")]
	private static void OGOPCIDPODH<T>(int PADOIKGMOKG, NativeArray<T> GCNMGLIJHGM, int BDHBBDMMOKG, [Optional] T DDDAMIICLIC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x57C28C0", Offset = "0x57C16C0", VA = "0x1857C28C0")]
	private void LGCHFODHPFM(IEnumerable<BFAGKBJHKLA> HKEMOJKIKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x57C2F60", Offset = "0x57C1D60", VA = "0x1857C2F60")]
	private void OPOJFMEEOHA(BFAGKBJHKLA KPILIOKMJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x57C2CA0", Offset = "0x57C1AA0", VA = "0x1857C2CA0")]
	private BAHDFONDOCF OOAHGFEAJIM(int BBLMOCLGJPK)
	{
		return default(BAHDFONDOCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x57C2290", Offset = "0x57C1090", VA = "0x1857C2290")]
	public void IDCFBADICMM(float FDGMDMPEONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x57C1B50", Offset = "0x57C0950", VA = "0x1857C1B50")]
	private void BGKLAMNHJFA(Action NCNGLFNLPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x57C0D10", Offset = "0x57BFB10", VA = "0x1857C0D10")]
	private void ACAHBIMAPPK(Action NCNGLFNLPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x57C0D90", Offset = "0x57BFB90", VA = "0x1857C0D90")]
	public void BAAMBJJENMG(float FDGMDMPEONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x57C2790", Offset = "0x57C1590", VA = "0x1857C2790")]
	public void KKDFCIPLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x57C2660", Offset = "0x57C1460", VA = "0x1857C2660")]
	public void KJMCNJCBCGH(AKJMMCEOMAD PCDCJHEAPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x57C1BD0", Offset = "0x57C09D0", VA = "0x1857C1BD0")]
	public void CCLKNNLCIIN(AKJMMCEOMAD PCDCJHEAPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x57C2B70", Offset = "0x57C1970", VA = "0x1857C2B70")]
	public void NHBKCOLFHGG(AKJMMCEOMAD PCDCJHEAPKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NOEBAFMFEMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static readonly NOEBAFMFEMD BCIDCKMIEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly Action NLELACPHBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool JKEEGJNIPNF;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x85B5D0", Offset = "0x85A3D0", VA = "0x18085B5D0")]
	public NOEBAFMFEMD(Action NLELACPHBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x57CC490", Offset = "0x57CB290", VA = "0x1857CC490", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface BABFBHAPEFH<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NMHKNHJHCOE(UnityEngine.Object KPJEGNGKPOH, Action<T> BICOPEEKAAL);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface LEEFELCPMJP<T> : global::BABFBHAPEFH<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class JALOPNGANKK<T> : global::LEEFELCPMJP<T>, global::BABFBHAPEFH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class IPJMFEIAONK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public global::JALOPNGANKK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public global::NLMEDIENKFM<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public IPJMFEIAONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4152330", Offset = "0x4151130", VA = "0x184152330")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static GameObject EIJNAFAHOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly List<global::NLMEDIENKFM<UnityEngine.Object, Action<T>>> APGOICGHNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private T NOGOPIJADJF;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x736830", Offset = "0x735630", VA = "0x180736830", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x40EAB70", Offset = "0x40E9970", VA = "0x1840EAB70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x40EA780", Offset = "0x40E9580", VA = "0x1840EA780")]
	private static bool FJKLBDOEMME(T NCNGLFNLPAG, T OPGAGDBKIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x40EABD0", Offset = "0x40E99D0", VA = "0x1840EABD0")]
	public JALOPNGANKK(T FNFBPPDOMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x40EA980", Offset = "0x40E9780", VA = "0x1840EA980", Slot = "6")]
	public IDisposable NMHKNHJHCOE(UnityEngine.Object KPJEGNGKPOH, Action<T> BICOPEEKAAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x40EA0C0", Offset = "0x40E8EC0", VA = "0x1840EA0C0")]
	private void BEJMPONGCMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class ILBJJKGOPDC : ILBGDCKAGCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly HFNDABHEJNE LMJBEMHEKFO;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x57C5EC0", Offset = "0x57C4CC0", VA = "0x1857C5EC0")]
	[EJICMPGFCBP(CIKEJIGJNLD.None)]
	private static void PMFNJDEOCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x85B5D0", Offset = "0x85A3D0", VA = "0x18085B5D0")]
	[Preserve]
	internal ILBJJKGOPDC([ELDNEOCBGIN(null)] HFNDABHEJNE LMJBEMHEKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x57C5E20", Offset = "0x57C4C20", VA = "0x1857C5E20", Slot = "4")]
	public IDisposable PAJOGGKDECE(float CAGAEJAPLKP, Action<float> KDDLOKAHKOL, bool DPOJEFOJKNL = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct NGDMBIENEPK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[ReadOnly]
	public float AAIHEFNLGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[ReadOnly]
	public int PPBKKLBAAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private NativeArray<int> NJKFPPCEMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NativeArray<int> MAFBHNIOHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NativeArray<int> CMGFACJIIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[ReadOnly]
	public NativeArray<NNIKANPLIAM> EBGLGGGCILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[ReadOnly]
	public NativeArray<float> CLHBEPMLNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[WriteOnly]
	public NativeArray<int> OFFFHAKLBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[WriteOnly]
	public NativeArray<int> ADPMGMMJODB;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x57CC2F0", Offset = "0x57CB0F0", VA = "0x1857CC2F0")]
	public static NGDMBIENEPK HJNGNBALKKN(int CONHBPEGFBE, float FDGMDMPEONM, NativeArray<NNIKANPLIAM> APKLOODAJII, NativeArray<float> JKJCBMFFGIB, NativeArray<int> GPJENNGEKFD, NativeArray<int> LGCMDDLEGKG, NativeArray<int> NBODGFOAIIO, NativeArray<int> MAFBHNIOHIF, NativeArray<int> CMGFACJIIFJ)
	{
		return default(NGDMBIENEPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x57CBFE0", Offset = "0x57CADE0", VA = "0x1857CBFE0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x57CC380", Offset = "0x57CB180", VA = "0x1857CC380")]
	private bool MICDOMKGKJL(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x57CC350", Offset = "0x57CB150", VA = "0x1857CC350")]
	private void JFOJCLFFJIN(NativeArray<int> DPBHMOJFGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x57CBF80", Offset = "0x57CAD80", VA = "0x1857CBF80")]
	private int CHLONKBDHLL(int FOOFDPKIIBH, int KGCEPFKEKBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x57CC3C0", Offset = "0x57CB1C0", VA = "0x1857CC3C0")]
	private void NJNKHMJABPL(NativeArray<int> DPBHMOJFGGO, int MKOHADONNBB, int KHDHJBHPPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x57CC0C0", Offset = "0x57CAEC0", VA = "0x1857CC0C0")]
	private void FLJJHHBMIEA(NativeArray<int> DPBHMOJFGGO, int EBOOHPFMHEN, int OLLAMIFBLNB, int NFFJJMNGBNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class MFCNKDCECLK : HGLAONPHICA, HFNDABHEJNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private GLOFNPFPAIM[] DAMEEGOFPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private JAOOPCIFPAF LIPCFHBJOJP;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x57CB280", Offset = "0x57CA080", VA = "0x1857CB280")]
	[EJICMPGFCBP(CIKEJIGJNLD.None)]
	private static void PMFNJDEOCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2F0", Offset = "0x57CA0F0", VA = "0x1857CB2F0")]
	[Preserve]
	public MFCNKDCECLK([ELDNEOCBGIN(null)] MHILEEBOPPK DJAHPLFLIAL, [ELDNEOCBGIN(null)] DDBNFLLNFIM OLIEAHOGPGO, [ELDNEOCBGIN(null)] NJKPEMJOBCE EJKFHOLLCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x57CA9C0", Offset = "0x57C97C0", VA = "0x1857CA9C0", Slot = "12")]
	public override MANCEBNIGPM GCDPLKKPHLI(NLFKOLIGGGC KPJEGNGKPOH, IEnumerator<ELOHAHHPMGF> FHAKEFLCOHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x57CAC30", Offset = "0x57C9A30", VA = "0x1857CAC30", Slot = "13")]
	public override void IOEAEKKNKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x57CAF10", Offset = "0x57C9D10", VA = "0x1857CAF10", Slot = "15")]
	public override void JADBILLKIBH(DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x57CB1A0", Offset = "0x57C9FA0", VA = "0x1857CB1A0", Slot = "14")]
	protected override void PGLCEDHDGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x57CB160", Offset = "0x57C9F60", VA = "0x1857CB160")]
	private GLOFNPFPAIM MJNCBKCACBN(DAAICDPBDKL.EJJBPOJLCLK IGEIBCJNCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x57CA8A0", Offset = "0x57C96A0", VA = "0x1857CA8A0", Slot = "16")]
	internal override JGDBDEGHKIO BIMDOPNILPB(IEnumerator<ELOHAHHPMGF> FHAKEFLCOHB, Behaviour KPJEGNGKPOH, ACJHPGLJCBN HNFKIAKOCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x57CB0F0", Offset = "0x57C9EF0", VA = "0x1857CB0F0", Slot = "17")]
	internal override LGCMJEEKANO JKGHCLLIEJK(DAAICDPBDKL.EJJBPOJLCLK HEDKEAMNACE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x57CAB00", Offset = "0x57C9900", VA = "0x1857CAB00")]
	private void GLEOKJPCCAE(GLOFNPFPAIM FAPNNIDOKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x57CA950", Offset = "0x57C9750", VA = "0x1857CA950", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class HGLAONPHICA : HFNDABHEJNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly MHILEEBOPPK DJAHPLFLIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	protected readonly DDBNFLLNFIM OLIEAHOGPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly NJKPEMJOBCE EJKFHOLLCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private LGCMJEEKANO[] KHMNFMFBIPP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static HFNDABHEJNE JKCIDAEDHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x57C39F0", Offset = "0x57C27F0", VA = "0x1857C39F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static bool ANGKCDCBMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6B17F0", Offset = "0x6B05F0", VA = "0x1806B17F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public DAAICDPBDKL.EJJBPOJLCLK GILIKHKPLNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7332F0", Offset = "0x7320F0", VA = "0x1807332F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(DAAICDPBDKL.EJJBPOJLCLK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x733300", Offset = "0x732100", VA = "0x180733300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DDBNFLLNFIM GOHKAGCGDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x57C4020", Offset = "0x57C2E20", VA = "0x1857C4020")]
	public static MANCEBNIGPM FAOEGBLGOHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x57C47F0", Offset = "0x57C35F0", VA = "0x1857C47F0")]
	[Preserve]
	protected HGLAONPHICA([ELDNEOCBGIN(null)] MHILEEBOPPK DJAHPLFLIAL, [ELDNEOCBGIN(null)] DDBNFLLNFIM OLIEAHOGPGO, [ELDNEOCBGIN(null)] NJKPEMJOBCE EJKFHOLLCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x57C3A40", Offset = "0x57C2840", VA = "0x1857C3A40", Slot = "6")]
	public MANCEBNIGPM CAIEIEJFFKG(IEnumerator<ELOHAHHPMGF> FHAKEFLCOHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x57C3A50", Offset = "0x57C2850", VA = "0x1857C3A50", Slot = "7")]
	public MANCEBNIGPM CAIEIEJFFKG(Behaviour KPJEGNGKPOH, IEnumerator<ELOHAHHPMGF> FHAKEFLCOHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract MANCEBNIGPM GCDPLKKPHLI(NLFKOLIGGGC KPJEGNGKPOH, IEnumerator<ELOHAHHPMGF> FHAKEFLCOHB);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x57C40E0", Offset = "0x57C2EE0", VA = "0x1857C40E0", Slot = "13")]
	public virtual void IOEAEKKNKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x57C4750", Offset = "0x57C3550", VA = "0x1857C4750", Slot = "9")]
	public void PIJOMEGCGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x57C4730", Offset = "0x57C3530", VA = "0x1857C4730", Slot = "14")]
	protected virtual void PGLCEDHDGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x57C4000", Offset = "0x57C2E00", VA = "0x1857C4000")]
	private void EMENAODBBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x57C4500", Offset = "0x57C3300", VA = "0x1857C4500")]
	private void JCKGBGGCPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x57C4710", Offset = "0x57C3510", VA = "0x1857C4710")]
	private void OIJDAGOPMIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x57C47B0", Offset = "0x57C35B0", VA = "0x1857C47B0")]
	private void PLOOKOMEMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x57C47D0", Offset = "0x57C35D0", VA = "0x1857C47D0")]
	private void PPLFKEAGNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x57C40C0", Offset = "0x57C2EC0", VA = "0x1857C40C0")]
	private void IKNFHCFNBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x57C46F0", Offset = "0x57C34F0", VA = "0x1857C46F0")]
	private void NLCMNDGFANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x57C42C0", Offset = "0x57C30C0", VA = "0x1857C42C0", Slot = "15")]
	public virtual void JADBILLKIBH(DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x57C4520", Offset = "0x57C3320", VA = "0x1857C4520")]
	private void LGDELGLIBBH(LGCMJEEKANO FAPNNIDOKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1B39A90", Offset = "0x1B38890", VA = "0x181B39A90")]
	private LGCMJEEKANO LGGAPKAOCMP(DAAICDPBDKL.EJJBPOJLCLK IGEIBCJNCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract JGDBDEGHKIO BIMDOPNILPB(IEnumerator<ELOHAHHPMGF> FHAKEFLCOHB, Behaviour BACHLBJINBI, ACJHPGLJCBN IMAAMJLOBAG);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract LGCMJEEKANO JKGHCLLIEJK(DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x57C3C80", Offset = "0x57C2A80", VA = "0x1857C3C80", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class JGDBDEGHKIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly ACJHPGLJCBN HNFKIAKOCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly NECNEGGKBCJ KPJEGNGKPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly bool NOJLEKLOOJG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<ELOHAHHPMGF> FKPKIGDOAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6B2150", Offset = "0x6B0F50", VA = "0x1806B2150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public ELOHAHHPMGF JNOBHIBOEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7337A0", Offset = "0x7325A0", VA = "0x1807337A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool KAHMPJDPNJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x57C6B20", Offset = "0x57C5920", VA = "0x1857C6B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool DNJHMJMLKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x869880", Offset = "0x868680", VA = "0x180869880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x869890", Offset = "0x868690", VA = "0x180869890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string ADMEEJPABPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6C07D0", Offset = "0x6BF5D0", VA = "0x1806C07D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x737900", Offset = "0x736700", VA = "0x180737900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float GOBICPPHDFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x783C80", Offset = "0x782A80", VA = "0x180783C80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x77D790", Offset = "0x77C590", VA = "0x18077D790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x57C7010", Offset = "0x57C5E10", VA = "0x1857C7010")]
	public JGDBDEGHKIO(IEnumerator<ELOHAHHPMGF> PLJNLNLCNGA, NECNEGGKBCJ KPJEGNGKPOH, ACJHPGLJCBN HNFKIAKOCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x57C6BA0", Offset = "0x57C59A0", VA = "0x1857C6BA0")]
	public ELOHAHHPMGF HMADLOMDEML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x57C6EE0", Offset = "0x57C5CE0", VA = "0x1857C6EE0")]
	public bool LIMJNDNEANL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x57C6E60", Offset = "0x57C5C60", VA = "0x1857C6E60")]
	public void KJMCNJCBCGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x57C6F50", Offset = "0x57C5D50", VA = "0x1857C6F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F14950", Offset = "0x2F13750", VA = "0x182F14950")]
	[CompilerGenerated]
	private void DFJAMJFGNAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class ACJHPGLJCBN : CHGNKCLFEML, MANCEBNIGPM, JEMCAFGLPLG, CCBLCAIHLNA, IEnumerator, ELOHAHHPMGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private DAAICDPBDKL.EJJBPOJLCLK FBNMBINMNBL;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private DAAICDPBDKL.EJJBPOJLCLK PBANAOCEKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x83DEF0", Offset = "0x83CCF0", VA = "0x18083DEF0", Slot = "23")]
		get
		{
			return default(DAAICDPBDKL.EJJBPOJLCLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DAAICDPBDKL.EJJBPOJLCLK PFLNPBFBJII
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x83DFE0", Offset = "0x83CDE0", VA = "0x18083DFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float DBDPOPLDBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xBD5930", Offset = "0xBD4730", VA = "0x180BD5930", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x57B77A0", Offset = "0x57B65A0", VA = "0x1857B77A0", Slot = "24")]
	private bool CGOGGNMEDAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x57B77C0", Offset = "0x57B65C0", VA = "0x1857B77C0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x57B77D0", Offset = "0x57B65D0", VA = "0x1857B77D0")]
	public ACJHPGLJCBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal enum BAHDFONDOCF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class LGCMJEEKANO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum JBDHFFCBFKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct JFABPOJJPOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public DAAICDPBDKL.EJJBPOJLCLK GLLLPIKBOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public JBDHFFCBFKO DIDLLKNNHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public List<JGDBDEGHKIO> MBMEGFMGLNH;
	}

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly JBDHFFCBFKO[] KPBOFGFKJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly DAAICDPBDKL.EJJBPOJLCLK OGEBAKOKIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool PEGKNGEDPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly JGDBDEGHKIO[] LFMHGEOHMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<JGDBDEGHKIO> MHEBMKHPHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Stack<int> KMMDHPCIGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly List<JGDBDEGHKIO> PNANBOMFFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Stack<int> LNJBOGLPFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly JAOOPCIFPAF KBNBNDIADCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private bool IFAIHPJAIJG;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public JFABPOJJPOJ[,] LPPOAOFJGOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6BE4D0", Offset = "0x6BD2D0", VA = "0x1806BE4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x57C96A0", Offset = "0x57C84A0", VA = "0x1857C96A0")]
	public LGCMJEEKANO(DAAICDPBDKL.EJJBPOJLCLK HEDKEAMNACE, JAOOPCIFPAF KBNBNDIADCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x57C9120", Offset = "0x57C7F20", VA = "0x1857C9120")]
	public void MMMFAINFHKC(JGDBDEGHKIO PLJNLNLCNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x57C82E0", Offset = "0x57C70E0", VA = "0x1857C82E0")]
	public void AABPHPAPLLF(IList<JGDBDEGHKIO> NHHOMNDPAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x57C8D30", Offset = "0x57C7B30", VA = "0x1857C8D30")]
	public void IAJIHELPGHO(IList<JGDBDEGHKIO> NHHOMNDPAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x57C8730", Offset = "0x57C7530", VA = "0x1857C8730")]
	private void BKMACHNJMJN(JGDBDEGHKIO PLJNLNLCNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x57C85B0", Offset = "0x57C73B0", VA = "0x1857C85B0")]
	private void AGBDKCLDNHF(IList<JGDBDEGHKIO> NHHOMNDPAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x57C8B90", Offset = "0x57C7990", VA = "0x1857C8B90")]
	private BAHDFONDOCF HODAJKMNPDH(JGDBDEGHKIO PLJNLNLCNGA)
	{
		return default(BAHDFONDOCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x57C9240", Offset = "0x57C8040", VA = "0x1857C9240")]
	public void PGLCEDHDGGL(float FDGMDMPEONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x57C9380", Offset = "0x57C8180", VA = "0x1857C9380")]
	public void PIJOMEGCGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x57C8970", Offset = "0x57C7770", VA = "0x1857C8970")]
	private void FHGNDDDKNAH(List<JGDBDEGHKIO> NHHOMNDPAKB, Stack<int> HHGAMLHJKIH, bool JLCOKFDGJFD, float JNPJCCABLCI = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x57C8830", Offset = "0x57C7630", VA = "0x1857C8830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x57C9000", Offset = "0x57C7E00", VA = "0x1857C9000")]
	private void INLKAHIOIIG(List<JGDBDEGHKIO> NHHOMNDPAKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class CCGEIIBCIAL : JAOOPCIFPAF
{
	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "4")]
	public void GAFPCJLJAKL(string IADPDEAGFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
	public void AOCDCGLCDKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public CCGEIIBCIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class HKFFFEONBMB : NECNEGGKBCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Behaviour BACHLBJINBI;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string ADMEEJPABPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x57C4C30", Offset = "0x57C3A30", VA = "0x1857C4C30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NJGPOAGJMBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x57C4BD0", Offset = "0x57C39D0", VA = "0x1857C4BD0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ADOHMGAGHHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x57C4CC0", Offset = "0x57C3AC0", VA = "0x1857C4CC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x85B5D0", Offset = "0x85A3D0", VA = "0x18085B5D0")]
	public HKFFFEONBMB(Behaviour BACHLBJINBI)
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

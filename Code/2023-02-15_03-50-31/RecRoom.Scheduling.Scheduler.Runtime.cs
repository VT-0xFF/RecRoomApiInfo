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
public class EGLLLPPLLKF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority PFMHBGIMAAF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5704FA0", Offset = "0x57043A0", VA = "0x185704FA0")]
	public EGLLLPPLLKF(ThreadPriority AOADJHKABPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5704F90", Offset = "0x5704390", VA = "0x185704F90", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> NJABKIGBBED(List<PlayerLoopSystem> HOCPKHHLENG, int NCLJAFDNEKL);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct GKIKDECNBNN
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct EMCFFEBEFHE
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static CBKLEJNNKJH HPENCBHKMKH;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x5705270", Offset = "0x5704670", VA = "0x185705270")]
				public static PlayerLoopSystem KNOFJDDCNDN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct MAJKABMKDNC
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static CBKLEJNNKJH IBIJDHACHFL;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x570E170", Offset = "0x570D570", VA = "0x18570E170")]
				public static PlayerLoopSystem KNOFJDDCNDN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct LKELJPKDIGB
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static CBKLEJNNKJH MPBOPMGIMBA;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x570D8D0", Offset = "0x570CCD0", VA = "0x18570D8D0")]
				public static PlayerLoopSystem KNOFJDDCNDN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct LCPDDNGOEHO
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static CBKLEJNNKJH FJBPJHLMCKI;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static CBKLEJNNKJH KOAOLLFFOCN;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static CBKLEJNNKJH JKNEDPLNKKH;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static CBKLEJNNKJH FCHFADKLMJC;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x570C010", Offset = "0x570B410", VA = "0x18570C010")]
				public static PlayerLoopSystem KNOFJDDCNDN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct CLOIOBCKOHH
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static CBKLEJNNKJH JBLCGJOFEKI;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x56FF2C0", Offset = "0x56FE6C0", VA = "0x1856FF2C0")]
				public static PlayerLoopSystem KNOFJDDCNDN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct EINGLDCKGKI
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static CBKLEJNNKJH FJBPJHLMCKI;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static CBKLEJNNKJH KOAOLLFFOCN;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static CBKLEJNNKJH JKNEDPLNKKH;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static CBKLEJNNKJH FCHFADKLMJC;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x5704FE0", Offset = "0x57043E0", VA = "0x185704FE0")]
				public static PlayerLoopSystem KNOFJDDCNDN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct LBLHPNEKNGK
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static CBKLEJNNKJH IFMGJFNHGCF;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x570BE30", Offset = "0x570B230", VA = "0x18570BE30")]
				public static PlayerLoopSystem KNOFJDDCNDN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct BBCJDPBKHPN
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static CBKLEJNNKJH ONMHFLBACMB;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x56FD460", Offset = "0x56FC860", VA = "0x1856FD460")]
				public static PlayerLoopSystem KNOFJDDCNDN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct DNEMICHKNBP
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static CBKLEJNNKJH CMOAFPHBONG;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x5704DB0", Offset = "0x57041B0", VA = "0x185704DB0")]
				public static PlayerLoopSystem KNOFJDDCNDN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct BMJAGLOMHLN
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static CBKLEJNNKJH IENOEKKACNO;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x56FE900", Offset = "0x56FDD00", VA = "0x1856FE900")]
				public static PlayerLoopSystem KNOFJDDCNDN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct BHGJHGEAALK
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static CBKLEJNNKJH NPOCGKGMEKH;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x56FE010", Offset = "0x56FD410", VA = "0x1856FE010")]
				public static PlayerLoopSystem KNOFJDDCNDN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct LJNNMADLOIP
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class MNBHPPECLFE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public IFICCBLMBBO.IMOPJGNGELO key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
					public MNBHPPECLFE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x570EB30", Offset = "0x570DF30", VA = "0x18570EB30")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable JLOEMGMEBNG;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x570D7A0", Offset = "0x570CBA0", VA = "0x18570D7A0")]
				public static PlayerLoopSystem AJOMOPIGJHL(IFICCBLMBBO.IMOPJGNGELO EBOEHIFNNLM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct IBELGPHPJMK
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class OFOPHDMOAPJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002E")]
					public IFICCBLMBBO.IMOPJGNGELO key;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
					public OFOPHDMOAPJ()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x57119D0", Offset = "0x5710DD0", VA = "0x1857119D0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x5708AB0", Offset = "0x5707EB0", VA = "0x185708AB0")]
				public static PlayerLoopSystem AJOMOPIGJHL(IFICCBLMBBO.IMOPJGNGELO EBOEHIFNNLM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class HEFIDMDKJNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public HEFIDMDKJNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x57071B0", Offset = "0x57065B0", VA = "0x1857071B0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool PLOLPIJCJAO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool JKIDEBICLBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5700AE0", Offset = "0x56FFEE0", VA = "0x185700AE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5700F10", Offset = "0x5700310", VA = "0x185700F10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5701110", Offset = "0x5700510", VA = "0x185701110")]
		private static void MNLNAIHDKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5700210", Offset = "0x56FF610", VA = "0x185700210")]
		private static void HCOFJOPKIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5702FB0", Offset = "0x57023B0", VA = "0x185702FB0")]
		private static void PCGKEFDMHDE(string JNJCPKJBOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x56FFFE0", Offset = "0x56FF3E0", VA = "0x1856FFFE0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5700F50", Offset = "0x5700350", VA = "0x185700F50")]
		private static void KKFODOBJAJN(IFICCBLMBBO.IMOPJGNGELO EBOEHIFNNLM, ref PlayerLoopSystem NLLKBLOEDIL, Type AGDFNICKCLA, Type GNCFGDHFPBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5700B20", Offset = "0x56FFF20", VA = "0x185700B20")]
		private static void IMEEKCNJAHI(ref PlayerLoopSystem NLLKBLOEDIL, Type AGDFNICKCLA, Type GNCFGDHFPBO, NJABKIGBBED DIGFKALMGJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x56FFEB0", Offset = "0x56FF2B0", VA = "0x1856FFEB0")]
		private static void ANPCIPDCLMA(ref PlayerLoopSystem NLLKBLOEDIL, Type AGDFNICKCLA, Type GNCFGDHFPBO, PlayerLoopSystem? JLDJNDKCCCG, PlayerLoopSystem? HCKHHPONBNE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class IFICCBLMBBO
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum IMOPJGNGELO
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
	public class HPHNHFJIOBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly IMOPJGNGELO IMCHMFGNBEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly MNENFPFHBEF OKBIEEDGNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long AGIKNLKPKBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long CIFLBMEEAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long BHIJAHFAHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int PBCDMBIAGJO;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x57089B0", Offset = "0x5707DB0", VA = "0x1857089B0")]
		public HPHNHFJIOBL(IMOPJGNGELO FHICMGFKLGN, int KFLALIICGEP = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5708740", Offset = "0x5707B40", VA = "0x185708740")]
		public void FEOFGLCBJGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x57086E0", Offset = "0x5707AE0", VA = "0x1857086E0")]
		public void EDHIOIGAGKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x57087B0", Offset = "0x5707BB0", VA = "0x1857087B0")]
		public void LOCGLEJDMID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static IMOPJGNGELO[] CMHEPPJGLEP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static HPHNHFJIOBL[] PACNGKBLNGL;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5708C90", Offset = "0x5708090", VA = "0x185708C90")]
	public static HPHNHFJIOBL LCJHJFBMLIF(IMOPJGNGELO EBOEHIFNNLM, int KFLALIICGEP = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5708E60", Offset = "0x5708260", VA = "0x185708E60")]
	public static HPHNHFJIOBL PLLMBLBGNEE(IMOPJGNGELO EBOEHIFNNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5708BE0", Offset = "0x5707FE0", VA = "0x185708BE0")]
	public static void FDMIHLPPMBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MNENFPFHBEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int AHADJGIDLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Queue<double> JKJKHHJJDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double LOOCNKEBNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double KLDHGDMNHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double PELDCNFBMHH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double ENPOBDFPMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x570EF40", Offset = "0x570E340", VA = "0x18570EF40", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x570EFA0", Offset = "0x570E3A0", VA = "0x18570EFA0")]
	public MNENFPFHBEF(int NEKAHCOPMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x570EDA0", Offset = "0x570E1A0", VA = "0x18570EDA0", Slot = "4")]
	public void BBJIMIBODFI(double GBADNLAFNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x570EED0", Offset = "0x570E2D0", VA = "0x18570EED0", Slot = "5")]
	public void FNNEKAKKIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class FACHCLBLCFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private long OCCKKIPCFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double LNKGGHLGAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double DMOGEAGELPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private double MNKNODENCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private double OHIEPHPELEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private double LOOCNKEBNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private double KLDHGDMNHDJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double HELEHNBKDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8A8050", Offset = "0x8A7450", VA = "0x1808A8050", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double MHBJHNKBGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8A80D0", Offset = "0x8A74D0", VA = "0x1808A80D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double LKLFNGCNJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x795E60", Offset = "0x795260", VA = "0x180795E60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double ENPOBDFPMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8A7F60", Offset = "0x8A7360", VA = "0x1808A7F60", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5705AA0", Offset = "0x5704EA0", VA = "0x185705AA0", Slot = "7")]
	public void BBJIMIBODFI(double GBADNLAFNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5705BD0", Offset = "0x5704FD0", VA = "0x185705BD0", Slot = "8")]
	public void FNNEKAKKIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5705C10", Offset = "0x5705010", VA = "0x185705C10")]
	public FACHCLBLCFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class AICFAMJMEIE
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private interface OKGAFOAFCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool AJOCNICADDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HPPHODAOIFC();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private abstract class MNMNGHHNBOK<TPromise, TMainThreadPromise> : OKGAFOAFCCJ where TPromise : PMOAFBNPLHC where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly TPromise KPHHBHACDLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected readonly TMainThreadPromise FBDDLBEDBJP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise BEOPCBFENFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3FC1B90", Offset = "0x3FC0F90", VA = "0x183FC1B90")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AJOCNICADDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3FC1B40", Offset = "0x3FC0F40", VA = "0x183FC1B40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x31EE110", Offset = "0x31ED510", VA = "0x1831EE110")]
		protected MNMNGHHNBOK(TPromise KPHHBHACDLG, TMainThreadPromise NAAIGDCGKCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3FC1BF0", Offset = "0x3FC0FF0", VA = "0x183FC1BF0", Slot = "5")]
		public void HPPHODAOIFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void PHMEOJLNHLJ(TPromise KPHHBHACDLG);
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private class LBNFBOFGOEF<T> : MNMNGHHNBOK<global::HCPIAAEIKCB<T>, global::ACKLAEJEFDC<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2D94A30", Offset = "0x2D93E30", VA = "0x182D94A30")]
		public LBNFBOFGOEF(global::HCPIAAEIKCB<T> KPHHBHACDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2D94820", Offset = "0x2D93C20", VA = "0x182D94820", Slot = "6")]
		protected override void PHMEOJLNHLJ(global::HCPIAAEIKCB<T> KPHHBHACDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2D947F0", Offset = "0x2D93BF0", VA = "0x182D947F0")]
		[CompilerGenerated]
		private void CLFJPPGHKFM(T APCBFLNDMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1B73B70", Offset = "0x1B72F70", VA = "0x181B73B70")]
		[CompilerGenerated]
		private void LIHJGAMDFOC(string GNLLAOFLEDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class OACCLHOKHHF : OKGAFOAFCCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly Action GPNJNMLGIEN;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AJOCNICADDI
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
		public OACCLHOKHHF(Action GPNJNMLGIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x188D2E0", Offset = "0x188C6E0", VA = "0x18188D2E0", Slot = "5")]
		public void HPPHODAOIFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<OKGAFOAFCCJ> COLPEMGAAIN;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2141AF0", Offset = "0x2140EF0", VA = "0x182141AF0")]
	public static global::HCPIAAEIKCB<T> DGAKMGDIDJJ<T>(this global::HCPIAAEIKCB<T> KPHHBHACDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x56FBA00", Offset = "0x56FAE00", VA = "0x1856FBA00")]
	public static void DGAKMGDIDJJ(Action GPNJNMLGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2141B60", Offset = "0x2140F60", VA = "0x182141B60")]
	private static global::HCPIAAEIKCB<T> NJDGOKCMOJE<T>(global::HCPIAAEIKCB<T> KPHHBHACDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x56FBE80", Offset = "0x56FB280", VA = "0x1856FBE80")]
	private static void MOIANEDIILE(OKGAFOAFCCJ LIHMHDAJNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x56FBA90", Offset = "0x56FAE90", VA = "0x1856FBA90")]
	private static void DPPPEMPBEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x56FBD80", Offset = "0x56FB180", VA = "0x1856FBD80")]
	private static void KLIBIBOPEKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x56FC080", Offset = "0x56FB480", VA = "0x1856FC080")]
	private static void OFAHGIPOLPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class LEPKBOCMJEI
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct JHMOGIGGLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TaskCompletionSource<Scene> NDHPLDFENCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly string NOGFKIMFHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly LoadSceneMode MPEFHBEEGDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool OPLGAMIEKAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly IBIDBCAPHMG KIBJDNPFMAF;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5709170", Offset = "0x5708570", VA = "0x185709170")]
		public JHMOGIGGLPM(TaskCompletionSource<Scene> IDBDDCGJDGM, string NOGFKIMFHJP, LoadSceneMode MPEFHBEEGDI, bool OPLGAMIEKAA, IBIDBCAPHMG KIBJDNPFMAF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct LLLICMEJOMB : IAsyncStateMachine
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
		public IBIDBCAPHMG stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::NEKDBCPDAGF<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x570DAB0", Offset = "0x570CEB0", VA = "0x18570DAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x570E120", Offset = "0x570D520", VA = "0x18570E120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct HGLHNOLEEJG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x57072D0", Offset = "0x57066D0", VA = "0x1857072D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct DDFGNOBEDJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private JHMOGIGGLPM <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x57046A0", Offset = "0x5703AA0", VA = "0x1857046A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class JNAJLDHDJLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public global::ACKLAEJEFDC<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public JNAJLDHDJLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x570BBA0", Offset = "0x570AFA0", VA = "0x18570BBA0")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct PCALPNPEOPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public IBIDBCAPHMG stackTimer;

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
		private JNAJLDHDJLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IBIDBCAPHMG <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private IBIDBCAPHMG <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5711DF0", Offset = "0x57111F0", VA = "0x185711DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5712770", Offset = "0x5711B70", VA = "0x185712770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct PFOIOGFJKMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private IBIDBCAPHMG <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private IBIDBCAPHMG <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x57127C0", Offset = "0x5711BC0", VA = "0x1857127C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5713000", Offset = "0x5712400", VA = "0x185713000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class NJBCJBPBFDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public NJBCJBPBFDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x570F3B0", Offset = "0x570E7B0", VA = "0x18570F3B0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class OEEJPNCLLCA : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AEOJOFIFGIK onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public OEEJPNCLLCA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x57118F0", Offset = "0x5710CF0", VA = "0x1857118F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5711590", Offset = "0x5710990", VA = "0x185711590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5711980", Offset = "0x5710D80", VA = "0x185711980")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x57118B0", Offset = "0x5710CB0", VA = "0x1857118B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class MOMCEHIPJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public global::ACKLAEJEFDC<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MOMCEHIPJNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class DBFEJMJBFGI : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public global::ACKLAEJEFDC<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private MOMCEHIPJNA <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public DBFEJMJBFGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x57032E0", Offset = "0x57026E0", VA = "0x1857032E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5703730", Offset = "0x5702B30", VA = "0x185703730", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static PMOAFBNPLHC OBIPIGKAGLN;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AsyncOperation BDEHJAPCDCN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static PMOAFBNPLHC GHLCEPBLHAD;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static string IFHKGAAIFIN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ThreadPriority JGKILMEPCIE;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Task IFLKLCDNBGG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Queue<JHMOGIGGLPM> OOKGHJOPEHE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Task FAAKOFKPFNP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool NPADMOINFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x570C920", Offset = "0x570BD20", VA = "0x18570C920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool LJGKLOOEDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x570CCD0", Offset = "0x570C0D0", VA = "0x18570CCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool CIJBNBHLLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x570D410", Offset = "0x570C810", VA = "0x18570D410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> JNJCFBKCOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x570C4D0", Offset = "0x570B8D0", VA = "0x18570C4D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x570CAE0", Offset = "0x570BEE0", VA = "0x18570CAE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x570D340", Offset = "0x570C740", VA = "0x18570D340")]
	[ODBBCFLHGDG(BHNMFCNEJDF.EnteredEditModeNextFrame, 0)]
	private static void MCPPIHLAKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x570C370", Offset = "0x570B770", VA = "0x18570C370")]
	[AsyncStateMachine(typeof(LLLICMEJOMB))]
	public static Task<Scene> CPODMHBNPCN(string NOGFKIMFHJP, LoadSceneMode MPEFHBEEGDI = LoadSceneMode.Single, bool OPLGAMIEKAA = false, [Optional] IBIDBCAPHMG OCELIMGBJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x570C2A0", Offset = "0x570B6A0", VA = "0x18570C2A0")]
	[AsyncStateMachine(typeof(HGLHNOLEEJG))]
	private static Task CJAOPCEJPJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x570CBE0", Offset = "0x570BFE0", VA = "0x18570CBE0")]
	[AsyncStateMachine(typeof(DDFGNOBEDJO))]
	private static Task HEPMOLLENJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x570C5D0", Offset = "0x570B9D0", VA = "0x18570C5D0")]
	[AsyncStateMachine(typeof(PCALPNPEOPB))]
	private static Task<Scene> DPJNEGNPOCE(string NOGFKIMFHJP, LoadSceneMode MPEFHBEEGDI, bool OPLGAMIEKAA, IBIDBCAPHMG KIBJDNPFMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x570D200", Offset = "0x570C600", VA = "0x18570D200")]
	[AsyncStateMachine(typeof(PFOIOGFJKMN))]
	private static Task<Scene> KOKILLNBBID(IBIDBCAPHMG KIBJDNPFMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x570D060", Offset = "0x570C460", VA = "0x18570D060")]
	public static global::HCPIAAEIKCB<Scene> JAFPBFCJADM(string NOGFKIMFHJP, LoadSceneMode MPEFHBEEGDI = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x570CD80", Offset = "0x570C180", VA = "0x18570CD80")]
	public static PMOAFBNPLHC HNKOKLEINIJ(string NOGFKIMFHJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x570C730", Offset = "0x570BB30", VA = "0x18570C730")]
	[IteratorStateMachine(typeof(OEEJPNCLLCA))]
	private static IEnumerator<MOELIBACAGH> FEHPDIGHABC(string NOGFKIMFHJP, AEOJOFIFGIK FGGLOJBNILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x570D4D0", Offset = "0x570C8D0", VA = "0x18570D4D0")]
	[IteratorStateMachine(typeof(DBFEJMJBFGI))]
	private static IEnumerator<MOELIBACAGH> PBCLNBFAACJ(string NOGFKIMFHJP, LoadSceneMode MPEFHBEEGDI, global::ACKLAEJEFDC<Scene> FGGLOJBNILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x570C7C0", Offset = "0x570BBC0", VA = "0x18570C7C0")]
	public static bool FKALNAIIDEN(out string BFIAABEPHNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class HPHGMCIPPNI
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5708560", Offset = "0x5707960", VA = "0x185708560")]
	public static IDisposable AANDKBLLOHI(this CJEOAEENBFH MAFDHEKFLMG, float FNLBOIFLFCF, Action<float> GIENCMBCINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x57085E0", Offset = "0x57079E0", VA = "0x1857085E0")]
	public static IDisposable COHOJPPEEHB(this CJEOAEENBFH MAFDHEKFLMG, Action<float> GIENCMBCINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5708660", Offset = "0x5707A60", VA = "0x185708660")]
	public static IDisposable OEBEJNHBLIG(this CJEOAEENBFH MAFDHEKFLMG, Action<float> GIENCMBCINK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class BCFPILEMGIE
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x56FDDE0", Offset = "0x56FD1E0", VA = "0x1856FDDE0")]
	public static IDisposable NLCCELCCHEM(this MonoBehaviour ONEIEJKCJBB, Action GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x56FDD60", Offset = "0x56FD160", VA = "0x1856FDD60")]
	public static IDisposable NLCCELCCHEM(this MonoBehaviour ONEIEJKCJBB, Action<float> GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x56FDC60", Offset = "0x56FD060", VA = "0x1856FDC60")]
	public static IDisposable KJAIMLDDOOF(this MonoBehaviour ONEIEJKCJBB, Action GIENCMBCINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x56FD9B0", Offset = "0x56FCDB0", VA = "0x1856FD9B0")]
	public static IDisposable FODBIMBAOBD(this MonoBehaviour ONEIEJKCJBB, Action GIENCMBCINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x56FDF00", Offset = "0x56FD300", VA = "0x1856FDF00")]
	public static IDisposable ODHCCFDAOKM(this MonoBehaviour ONEIEJKCJBB, Action GIENCMBCINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x56FD6E0", Offset = "0x56FCAE0", VA = "0x1856FD6E0")]
	public static IDisposable BAGGGHPEPCH(this MonoBehaviour ONEIEJKCJBB, Action GIENCMBCINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x56FDB50", Offset = "0x56FCF50", VA = "0x1856FDB50")]
	public static IDisposable JFOGKNPOCCN(this MonoBehaviour ONEIEJKCJBB, Action GIENCMBCINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x56FD640", Offset = "0x56FCA40", VA = "0x1856FD640")]
	public static IDisposable AOEEIBJMFJF(this MonoBehaviour ONEIEJKCJBB, float FNLBOIFLFCF, Action<float> GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI, bool OIEKPCFGPOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x56FD880", Offset = "0x56FCC80", VA = "0x1856FD880")]
	public static IDisposable CLALGHNNOIB(this MonoBehaviour ONEIEJKCJBB, float FNLBOIFLFCF, Action<float> GIENCMBCINK, bool OIEKPCFGPOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x56FDAC0", Offset = "0x56FCEC0", VA = "0x1856FDAC0")]
	public static IDisposable IDDCFCHEIDM(this MonoBehaviour ONEIEJKCJBB, Action<float> GIENCMBCINK, bool OIEKPCFGPOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x56FDCD0", Offset = "0x56FD0D0", VA = "0x1856FDCD0")]
	public static IDisposable LHGBMOEEIBO(this MonoBehaviour ONEIEJKCJBB, Action<float> GIENCMBCINK, bool OIEKPCFGPOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x56FDA30", Offset = "0x56FCE30", VA = "0x1856FDA30")]
	public static IDisposable GNLDKLBHIGC(this MonoBehaviour ONEIEJKCJBB, Action<float> GIENCMBCINK, bool OIEKPCFGPOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x56FD760", Offset = "0x56FCB60", VA = "0x1856FD760")]
	public static IDisposable BGEOHGOCHBE(this MonoBehaviour ONEIEJKCJBB, Action<float> GIENCMBCINK, bool OIEKPCFGPOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x56FDBD0", Offset = "0x56FCFD0", VA = "0x1856FDBD0")]
	public static IDisposable JKIMHICEKOP(this MonoBehaviour ONEIEJKCJBB, Action<float> GIENCMBCINK, bool OIEKPCFGPOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x56FD920", Offset = "0x56FCD20", VA = "0x1856FD920")]
	public static IDisposable EAFAEMBOACG(this MonoBehaviour ONEIEJKCJBB, Action<float> GIENCMBCINK, bool OIEKPCFGPOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x56FD7F0", Offset = "0x56FCBF0", VA = "0x1856FD7F0")]
	public static IDisposable CHHNMMPEGID(this MonoBehaviour ONEIEJKCJBB, Action<float> GIENCMBCINK, bool OIEKPCFGPOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x56FDE60", Offset = "0x56FD260", VA = "0x1856FDE60")]
	public static IDisposable NMJHKCPLBJM(this MonoBehaviour ONEIEJKCJBB, float FNLBOIFLFCF, Action<float> GIENCMBCINK, bool OIEKPCFGPOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x56FDF80", Offset = "0x56FD380", VA = "0x1856FDF80")]
	public static IDisposable PGNPKNNEPII(this MonoBehaviour ONEIEJKCJBB, Action<float> GIENCMBCINK, bool OIEKPCFGPOA = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class DKLELOIACEP
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class MFGMNACPILG : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public LIBKFAKJMIH.DBLADPAIJMN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private NHCIKOILNPK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public MFGMNACPILG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x570E9A0", Offset = "0x570DDA0", VA = "0x18570E9A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x570EA60", Offset = "0x570DE60", VA = "0x18570EA60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class LGHPJHPCCPF : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LIBKFAKJMIH.DBLADPAIJMN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private NHCIKOILNPK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public LGHPJHPCCPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x570D670", Offset = "0x570CA70", VA = "0x18570D670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x570D760", Offset = "0x570CB60", VA = "0x18570D760", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5704AF0", Offset = "0x5703EF0", VA = "0x185704AF0")]
	public static EJCEALCEAGN NLCCELCCHEM(Action GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5704A30", Offset = "0x5703E30", VA = "0x185704A30")]
	public static EJCEALCEAGN NLCCELCCHEM(Behaviour MAFDHEKFLMG, Action GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5704BA0", Offset = "0x5703FA0", VA = "0x185704BA0")]
	public static EJCEALCEAGN NLCCELCCHEM(Behaviour MAFDHEKFLMG, Action<float> GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5704D30", Offset = "0x5704130", VA = "0x185704D30")]
	[IteratorStateMachine(typeof(MFGMNACPILG))]
	private static IEnumerator<MOELIBACAGH> PCCJCGDIGEL(LIBKFAKJMIH.DBLADPAIJMN DCDKCDLJBLH, Action GIENCMBCINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5704CB0", Offset = "0x57040B0", VA = "0x185704CB0")]
	[IteratorStateMachine(typeof(LGHPJHPCCPF))]
	private static IEnumerator<MOELIBACAGH> PCCJCGDIGEL(LIBKFAKJMIH.DBLADPAIJMN DCDKCDLJBLH, Action<float> GIENCMBCINK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class GOOFEDDMIOF
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FDFAIEGNOJM : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LODDJNBEJNB schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public LIBKFAKJMIH.DBLADPAIJMN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LHINOKAAIFB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public FDFAIEGNOJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5705C40", Offset = "0x5705040", VA = "0x185705C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5705D80", Offset = "0x5705180", VA = "0x185705D80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x57068D0", Offset = "0x5705CD0", VA = "0x1857068D0")]
	public static EJCEALCEAGN NLCCELCCHEM(float FNLBOIFLFCF, Action<float> GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI, bool OIEKPCFGPOA = true, [Optional] FONOILNGPKO MKMPHGOOCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x57069D0", Offset = "0x5705DD0", VA = "0x1857069D0")]
	public static EJCEALCEAGN NLCCELCCHEM(MonoBehaviour ONEIEJKCJBB, float FNLBOIFLFCF, Action<float> GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI, bool OIEKPCFGPOA = true, [Optional] FONOILNGPKO MKMPHGOOCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x57067C0", Offset = "0x5705BC0", VA = "0x1857067C0")]
	public static EJCEALCEAGN FBPAJKLHJBM(CJEOAEENBFH MAFDHEKFLMG, float FNLBOIFLFCF, Action<float> GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI, bool OIEKPCFGPOA = true, [Optional] FONOILNGPKO MKMPHGOOCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5706AE0", Offset = "0x5705EE0", VA = "0x185706AE0")]
	[IteratorStateMachine(typeof(FDFAIEGNOJM))]
	private static IEnumerator<MOELIBACAGH> PCCJCGDIGEL(LODDJNBEJNB EALMMLGDIOO, float FNLBOIFLFCF, LIBKFAKJMIH.DBLADPAIJMN DCDKCDLJBLH, Action<float> GIENCMBCINK, bool OIEKPCFGPOA = true, [Optional] FONOILNGPKO MKMPHGOOCNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class PBLBHJOEFNA
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class LAILEAEIJJC : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public LIBKFAKJMIH.DBLADPAIJMN queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public LAILEAEIJJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x570BD40", Offset = "0x570B140", VA = "0x18570BD40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x570BDF0", Offset = "0x570B1F0", VA = "0x18570BDF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5711C60", Offset = "0x5711060", VA = "0x185711C60")]
	[IteratorStateMachine(typeof(LAILEAEIJJC))]
	private static IEnumerator<MOELIBACAGH> CKOBJHFPHJH(LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI, Func<bool> GFBBPILPDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5711CE0", Offset = "0x57110E0", VA = "0x185711CE0")]
	public static EJCEALCEAGN GGCLBMFEMOK(this MonoBehaviour ONEIEJKCJBB, Func<bool> GFBBPILPDGN, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI = LIBKFAKJMIH.DBLADPAIJMN.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NMMDDMAOFFO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class GKOPFOEGIGL : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public LIBKFAKJMIH.DBLADPAIJMN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public GKOPFOEGIGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5706570", Offset = "0x5705970", VA = "0x185706570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5706630", Offset = "0x5705A30", VA = "0x185706630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x570F3E0", Offset = "0x570E7E0", VA = "0x18570F3E0")]
	[IteratorStateMachine(typeof(GKOPFOEGIGL))]
	private static IEnumerator<MOELIBACAGH> ADGMBAHCCGC(float EONMILEOIME, LIBKFAKJMIH.DBLADPAIJMN DCDKCDLJBLH, Action NLNOCEEAFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x570F4D0", Offset = "0x570E8D0", VA = "0x18570F4D0")]
	public static EJCEALCEAGN CPKFONNMKLH(this MonoBehaviour ONEIEJKCJBB, float EONMILEOIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x570F660", Offset = "0x570EA60", VA = "0x18570F660")]
	public static EJCEALCEAGN ENEAGFGHFKD(this MonoBehaviour ONEIEJKCJBB, Action NLNOCEEAFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x570F470", Offset = "0x570E870", VA = "0x18570F470")]
	public static EJCEALCEAGN CGBHFCHNMAF(this MonoBehaviour ONEIEJKCJBB, Action NLNOCEEAFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x570F750", Offset = "0x570EB50", VA = "0x18570F750")]
	public static EJCEALCEAGN IAKKBCPBPAO(this MonoBehaviour ONEIEJKCJBB, Action NLNOCEEAFDB, [Optional] FONOILNGPKO MKMPHGOOCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x570F860", Offset = "0x570EC60", VA = "0x18570F860")]
	public static EJCEALCEAGN LLDOECJBHKH(this MonoBehaviour ONEIEJKCJBB, Action NLNOCEEAFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x570F4A0", Offset = "0x570E8A0", VA = "0x18570F4A0")]
	public static EJCEALCEAGN CMBOPDBHEHI(this MonoBehaviour ONEIEJKCJBB, Action NLNOCEEAFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x570F830", Offset = "0x570EC30", VA = "0x18570F830")]
	public static EJCEALCEAGN LAECNPDJOJL(this MonoBehaviour ONEIEJKCJBB, Action NLNOCEEAFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x570F590", Offset = "0x570E990", VA = "0x18570F590")]
	private static EJCEALCEAGN EMIDBNMDENH(MonoBehaviour ONEIEJKCJBB, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI, Action NLNOCEEAFDB, [Optional] FONOILNGPKO MKMPHGOOCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x570F680", Offset = "0x570EA80", VA = "0x18570F680")]
	public static EJCEALCEAGN GIGDIKIJKLA(this MonoBehaviour ONEIEJKCJBB, float DLIEJFDPODE, Action NLNOCEEAFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x570F890", Offset = "0x570EC90", VA = "0x18570F890")]
	public static EJCEALCEAGN OLADBCAFHLK(this MonoBehaviour ONEIEJKCJBB, float DLIEJFDPODE, Action NLNOCEEAFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x570FA30", Offset = "0x570EE30", VA = "0x18570FA30")]
	public static EJCEALCEAGN PIONNDGKMPB(this MonoBehaviour ONEIEJKCJBB, float DLIEJFDPODE, Action NLNOCEEAFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x570F960", Offset = "0x570ED60", VA = "0x18570F960")]
	public static EJCEALCEAGN PGIGLNNCJGG(this MonoBehaviour ONEIEJKCJBB, float DLIEJFDPODE, Action NLNOCEEAFDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class CPEKJNAHHNK : EMPOHKALMOP, IEnumerable<EMPOHKALMOP>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly List<EMPOHKALMOP> KMBJKBHMAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool JLBILPBMGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Action MDLONCCDOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool LDLAMNFPPAE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool MDILHIIGLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x56FF6B0", Offset = "0x56FEAB0", VA = "0x1856FF6B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KABNKLJLHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x56FFD70", Offset = "0x56FF170", VA = "0x1856FFD70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x56FF7F0", Offset = "0x56FEBF0", VA = "0x1856FF7F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x56FFE10", Offset = "0x56FF210", VA = "0x1856FFE10")]
	public CPEKJNAHHNK([Optional] Action MDLONCCDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x56FF580", Offset = "0x56FE980", VA = "0x1856FF580")]
	public void AOHLLDNPMGN(EMPOHKALMOP EDKAHJKADNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x56FFC00", Offset = "0x56FF000", VA = "0x1856FFC00")]
	private void IGCLMPGMJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x56FFBF0", Offset = "0x56FEFF0", VA = "0x1856FFBF0", Slot = "7")]
	public bool HLHOJKNECMD(bool BIOMHNNIJHG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x56FF910", Offset = "0x56FED10", VA = "0x1856FF910", Slot = "8")]
	public bool HLHOJKNECMD(Action GPNJNMLGIEN, bool BIOMHNNIJHG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x56FF890", Offset = "0x56FEC90", VA = "0x1856FF890", Slot = "9")]
	public IEnumerator<EMPOHKALMOP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x56FF890", Offset = "0x56FEC90", VA = "0x1856FF890", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NOHAEEFIALM : EPCIIACEOEG
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class FPNPOLIEKEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public NOHAEEFIALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public FPNPOLIEKEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5706540", Offset = "0x5705940", VA = "0x185706540")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class LJFMLLHCLBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public NOHAEEFIALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public LJFMLLHCLBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5706540", Offset = "0x5705940", VA = "0x185706540")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly float CJFGOEOCOBA;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x570BC40", Offset = "0x570B040", VA = "0x18570BC40")]
	public NOHAEEFIALM(Behaviour MAFDHEKFLMG, float CJFGOEOCOBA, [Optional] Action MDLONCCDOBF, [Optional] FONOILNGPKO MKMPHGOOCNK, [Optional] LODDJNBEJNB EALMMLGDIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x570FB00", Offset = "0x570EF00", VA = "0x18570FB00", Slot = "9")]
	protected override bool BCADJAKCHCM(Action GPNJNMLGIEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x570FC00", Offset = "0x570F000", VA = "0x18570FC00", Slot = "10")]
	protected override bool KFOOKNINLCJ(Action GPNJNMLGIEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface EMPOHKALMOP
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool MDILHIIGLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action KABNKLJLHEI;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HLHOJKNECMD(bool BIOMHNNIJHG = false);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HLHOJKNECMD(Action GPNJNMLGIEN, bool BIOMHNNIJHG = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class EPCIIACEOEG : EMPOHKALMOP
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class MEGBAPGEONN : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public EPCIIACEOEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public MEGBAPGEONN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x570E890", Offset = "0x570DC90", VA = "0x18570E890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x570E960", Offset = "0x570DD60", VA = "0x18570E960", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Behaviour MAFDHEKFLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Action MDLONCCDOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private MONKECHCONN FIGBBALJJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly FONOILNGPKO MKMPHGOOCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	protected readonly LODDJNBEJNB EALMMLGDIOO;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MDILHIIGLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x82D990", Offset = "0x82CD90", VA = "0x18082D990", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action KABNKLJLHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5705880", Offset = "0x5704C80", VA = "0x185705880", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5705450", Offset = "0x5704850", VA = "0x185705450", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x57059A0", Offset = "0x5704DA0", VA = "0x1857059A0")]
	protected EPCIIACEOEG(Behaviour MAFDHEKFLMG, [Optional] Action MDLONCCDOBF, [Optional] FONOILNGPKO MKMPHGOOCNK, [Optional] LODDJNBEJNB EALMMLGDIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5705770", Offset = "0x5704B70", VA = "0x185705770", Slot = "7")]
	public bool HLHOJKNECMD(bool BIOMHNNIJHG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x57057D0", Offset = "0x5704BD0", VA = "0x1857057D0", Slot = "8")]
	public bool HLHOJKNECMD(Action GPNJNMLGIEN, bool BIOMHNNIJHG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool BCADJAKCHCM(Action GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool KFOOKNINLCJ(Action GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5705860", Offset = "0x5704C60", VA = "0x185705860")]
	protected void JFJKACNHNEO(Action GPNJNMLGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x57054F0", Offset = "0x57048F0", VA = "0x1857054F0")]
	protected PMOAFBNPLHC BEELLDLNBFP(float OECGMCHKEJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x57056F0", Offset = "0x5704AF0", VA = "0x1857056F0")]
	private void DALOFMCCMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5705920", Offset = "0x5704D20", VA = "0x185705920")]
	[IteratorStateMachine(typeof(MEGBAPGEONN))]
	private IEnumerator<MOELIBACAGH> LAJCGBMCFLM(float OECGMCHKEJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5705820", Offset = "0x5704C20", VA = "0x185705820")]
	[CompilerGenerated]
	private void HMICBFIGOKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class HLLMOGLKNIL : EPCIIACEOEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly float BGGEKENOBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly int DJIGEPHPPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly float AAGJBPBMAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float[] IFPFFKEIOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int MJNPHNFNPFD;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x57083B0", Offset = "0x57077B0", VA = "0x1857083B0")]
	public HLLMOGLKNIL(Behaviour MAFDHEKFLMG, float AKKOKKGAFOI, int DJIGEPHPPPE, [Optional] Action MDLONCCDOBF, float AAGJBPBMAEE = 0f, [Optional] FONOILNGPKO MKMPHGOOCNK, [Optional] LODDJNBEJNB EALMMLGDIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "9")]
	protected override bool BCADJAKCHCM(Action GPNJNMLGIEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x57080F0", Offset = "0x57074F0", VA = "0x1857080F0", Slot = "10")]
	protected override bool KFOOKNINLCJ(Action GPNJNMLGIEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5708320", Offset = "0x5707720", VA = "0x185708320")]
	private void NBIDGOAPEOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class KOGBNJDNKFP : EPCIIACEOEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly float CJFGOEOCOBA;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x570BC40", Offset = "0x570B040", VA = "0x18570BC40")]
	public KOGBNJDNKFP(Behaviour MAFDHEKFLMG, float CJFGOEOCOBA, [Optional] Action MDLONCCDOBF, [Optional] FONOILNGPKO MKMPHGOOCNK, [Optional] LODDJNBEJNB EALMMLGDIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "9")]
	protected override bool BCADJAKCHCM(Action GPNJNMLGIEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x570BC00", Offset = "0x570B000", VA = "0x18570BC00", Slot = "10")]
	protected override bool KFOOKNINLCJ(Action GPNJNMLGIEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class FEDDCHIAKII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class ANHPJMGICMK : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public ANHPJMGICMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x56FD380", Offset = "0x56FC780", VA = "0x1856FD380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x56FD420", Offset = "0x56FC820", VA = "0x1856FD420", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private EJCEALCEAGN PLMNIGIDBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private CJEOAEENBFH MAFDHEKFLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action<float> CPJEMJCFKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private float GPMAHPLPDOM;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5706350", Offset = "0x5705750", VA = "0x185706350")]
	public FEDDCHIAKII(CJEOAEENBFH MAFDHEKFLMG, float FNLBOIFLFCF, Action<float> GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5706040", Offset = "0x5705440", VA = "0x185706040")]
	private void KCOOOEEFKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x57061F0", Offset = "0x57055F0", VA = "0x1857061F0")]
	private void NKAJOBBCINF(string GNLLAOFLEDB, Action CDPFNFNGMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5705FD0", Offset = "0x57053D0", VA = "0x185705FD0")]
	[IteratorStateMachine(typeof(ANHPJMGICMK))]
	private IEnumerator<MOELIBACAGH> HLCEDPBKMIC(Action CDPFNFNGMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5705DC0", Offset = "0x57051C0", VA = "0x185705DC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5705E20", Offset = "0x5705220", VA = "0x185705E20")]
	[CompilerGenerated]
	private void FHPBCJKCCCK(string LBPJAILMLKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class DBPKJCFDFCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class CPEAFOFHDEF : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public CPEAFOFHDEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x56FF4A0", Offset = "0x56FE8A0", VA = "0x1856FF4A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x56FF540", Offset = "0x56FE940", VA = "0x1856FF540", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private EJCEALCEAGN PLMNIGIDBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private MonoBehaviour ONEIEJKCJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Action GIENCMBCINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Action<float> CPJEMJCFKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private float GPMAHPLPDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool OIEKPCFGPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly FONOILNGPKO MKMPHGOOCNK;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x57044A0", Offset = "0x57038A0", VA = "0x1857044A0")]
	public DBPKJCFDFCD(MonoBehaviour ONEIEJKCJBB, Action GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI, [Optional] FONOILNGPKO MKMPHGOOCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5704000", Offset = "0x5703400", VA = "0x185704000")]
	public DBPKJCFDFCD(MonoBehaviour ONEIEJKCJBB, Action<float> GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI, [Optional] FONOILNGPKO MKMPHGOOCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5704240", Offset = "0x5703640", VA = "0x185704240")]
	public DBPKJCFDFCD(MonoBehaviour ONEIEJKCJBB, float FNLBOIFLFCF, Action<float> GIENCMBCINK, LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI, bool OIEKPCFGPOA = true, [Optional] FONOILNGPKO MKMPHGOOCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5703E90", Offset = "0x5703290", VA = "0x185703E90")]
	private void NLCCELCCHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x57039F0", Offset = "0x5702DF0", VA = "0x1857039F0")]
	private void JJEPKOENMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5703BA0", Offset = "0x5702FA0", VA = "0x185703BA0")]
	private void KCOOOEEFKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5703D60", Offset = "0x5703160", VA = "0x185703D60")]
	private void NKAJOBBCINF(string GNLLAOFLEDB, Action CDPFNFNGMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5703980", Offset = "0x5702D80", VA = "0x185703980")]
	[IteratorStateMachine(typeof(CPEAFOFHDEF))]
	private IEnumerator<MOELIBACAGH> HLCEDPBKMIC(Action CDPFNFNGMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5703890", Offset = "0x5702C90", VA = "0x185703890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5703770", Offset = "0x5702B70", VA = "0x185703770")]
	[CompilerGenerated]
	private void AHOEEAMDABL(string LBPJAILMLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x57038F0", Offset = "0x5702CF0", VA = "0x1857038F0")]
	[CompilerGenerated]
	private void HKCCBLPFCPM(string LBPJAILMLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5703800", Offset = "0x5702C00", VA = "0x185703800")]
	[CompilerGenerated]
	private void AOPKFAFBOGB(string LBPJAILMLKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum MNPLHHCCJGG : byte
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
internal sealed class JKNABLBNLII : LODDJNBEJNB
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float EDLKJAOEHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x570BB90", Offset = "0x570AF90", VA = "0x18570BB90", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float FDAKMGJJJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x570BAF0", Offset = "0x570AEF0", VA = "0x18570BAF0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public double FMIIHKKAPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x570BB00", Offset = "0x570AF00", VA = "0x18570BB00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x570BB20", Offset = "0x570AF20", VA = "0x18570BB20")]
	[ELNMOMKNGKB(LBAHANGFDMJ.None)]
	private static void DPKBCOEJEKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	[Preserve]
	internal JKNABLBNLII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface CKLDCPHHFDB
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFDGHKBIDMP(string IGHJIHNAPBA);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NODANGGMCOG();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface BNLGMLBPPAM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string COEOOBLBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool ALLLILMAHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool ILPPLEOINLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class MEDFMHDIPAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public JKJFEHEPODF OPMKMCLOLHP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int ICGLEEKOOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7532B0", Offset = "0x7526B0", VA = "0x1807532B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x570E570", Offset = "0x570D970", VA = "0x18570E570")]
	public static MOELIBACAGH CMHKMEMKBBB(IEnumerator<MOELIBACAGH> OOKECDLOLBJ, MHGNLCPNMOB MNPLPCBLMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x570E490", Offset = "0x570D890", VA = "0x18570E490")]
	public MOELIBACAGH CMHKMEMKBBB(MHGNLCPNMOB[] NEKECDIHMDN, IEnumerator<MOELIBACAGH>[] PAOFPLNNOFN, MOELIBACAGH[] OBNEKEJIICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x570E860", Offset = "0x570DC60", VA = "0x18570E860")]
	public void DJFIBDAJLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x570E720", Offset = "0x570DB20", VA = "0x18570E720")]
	public void DFEEMOKMFBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x570E350", Offset = "0x570D750", VA = "0x18570E350")]
	public void CGFLDGNIAMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x570E860", Offset = "0x570DC60", VA = "0x18570E860")]
	public void OBGDMCGDCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public MEDFMHDIPAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class JKJFEHEPODF
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct FDCCCNEENBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public MEDFMHDIPAN HLACOJHMJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public CJEOAEENBFH PPMGBDEINDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public MHGNLCPNMOB EBODDHNLHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public IEnumerator<MOELIBACAGH> BMDOIFELMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public MOELIBACAGH JPCKOLMDOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public MNPLHHCCJGG DHIKOJIHLNB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct BIHAOMCMDFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public LIBKFAKJMIH.DBLADPAIJMN AHGLDHOPEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<FDCCCNEENBB> ALLIEBGLDCN;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class CCHPCPAEKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public MHGNLCPNMOB promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public JKJFEHEPODF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public CJEOAEENBFH context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public MEDFMHDIPAN routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public MNPLHHCCJGG coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public MOELIBACAGH currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public IEnumerator<MOELIBACAGH> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public CCHPCPAEKDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x56FEAE0", Offset = "0x56FDEE0", VA = "0x1856FEAE0")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class LGFCDPFOHOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public MEDFMHDIPAN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JKJFEHEPODF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public LGFCDPFOHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x570D630", Offset = "0x570CA30", VA = "0x18570D630")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class PHKIALAEGDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public MEDFMHDIPAN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public JKJFEHEPODF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PHKIALAEGDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5713050", Offset = "0x5712450", VA = "0x185713050")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GLFBOCPNBOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public MEDFMHDIPAN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public JKJFEHEPODF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public GLFBOCPNBOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5706780", Offset = "0x5705B80", VA = "0x185706780")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const MNPLHHCCJGG ICCDOGMDAIC = MNPLHHCCJGG.Cancelled | MNPLHHCCJGG.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool[] JLJPJFPAAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<MNPLHHCCJGG> MOOLOJNKFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<float> OJKALJKGJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<int> IJLKEHEMFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<int> CJLMLCPLOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<int> BPNJEMFLAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<int> AECBBELAIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<int> PJMLIPKAHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private MEDFMHDIPAN[] FLGAAFFLLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private MHGNLCPNMOB[] NEKECDIHMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private CJEOAEENBFH[] KGGNJIBDNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private IEnumerator<MOELIBACAGH>[] OKBIHDBOHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MOELIBACAGH[] LCGMNOKHNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int BOMEOJLHNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int DOMGBHGFPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly int LKPMBDDHJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float PNHHFOGFMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private HDKNKICFDLK NFIGPLPHCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private JobHandle KILGCIIMGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private List<MEDFMHDIPAN> ECPCLMADLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool AIJLIGKDHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private List<Action> CGBANAAFPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private List<Action> JNFOINKIFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private bool HFCPHGAMMFJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public BIHAOMCMDFG[] PDNDNNDAFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7292D0", Offset = "0x7286D0", VA = "0x1807292D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x570B2D0", Offset = "0x570A6D0", VA = "0x18570B2D0")]
	private static int PKCJAEHLGEL(LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x570B4F0", Offset = "0x570A8F0", VA = "0x18570B4F0")]
	public JKJFEHEPODF(LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x570AE30", Offset = "0x570A230", VA = "0x18570AE30")]
	private void OFLABAEAKDG(ref int FAAMPINDAPM, int FAJBAJDKMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5709E40", Offset = "0x5709240", VA = "0x185709E40")]
	public void KBOEKLEIECI(CJEOAEENBFH MAFDHEKFLMG, MOELIBACAGH NEEBBLDDPAI, IEnumerator<MOELIBACAGH> OOKECDLOLBJ, MHGNLCPNMOB MNPLPCBLMHP, [Optional] MEDFMHDIPAN KPBDBHNMDGA, MNPLHHCCJGG KEKKAKCFOFA = MNPLHHCCJGG.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x570B300", Offset = "0x570A700", VA = "0x18570B300")]
	public void PPINHDFDPLB(IEnumerable<FDCCCNEENBB> IHLLOEBFEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5709FC0", Offset = "0x57093C0", VA = "0x185709FC0")]
	private FDCCCNEENBB LDJODAJOMLO(int ICIDPKLABKB)
	{
		return default(FDCCCNEENBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5709580", Offset = "0x5708980", VA = "0x185709580")]
	private void IALLMAPMCNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2864AA0", Offset = "0x2863EA0", VA = "0x182864AA0")]
	private static void LKOENHODEMI<T>(int ICIDPKLABKB, T[] CIINFLDPNNM, int PCAHMJECHKC, [Optional] T DIKGBGANJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2864A80", Offset = "0x2863E80", VA = "0x182864A80")]
	private static void LKOENHODEMI<T>(int ICIDPKLABKB, NativeArray<T> CIINFLDPNNM, int PCAHMJECHKC, [Optional] T DIKGBGANJAA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x570B020", Offset = "0x570A420", VA = "0x18570B020")]
	private void PBGAGHNAPNL(IEnumerable<FDCCCNEENBB> IHLLOEBFEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5709300", Offset = "0x5708700", VA = "0x185709300")]
	private void CPODNKBBBJG(FDCCCNEENBB BNOGHCDOHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5709920", Offset = "0x5708D20", VA = "0x185709920")]
	private KKNIOBOEFJN IDBDDAOECFG(int EEKMDPHEIDM)
	{
		return default(KKNIOBOEFJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5709C60", Offset = "0x5709060", VA = "0x185709C60")]
	public void JNICEPAEALG(float BMDHDCNJLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5709BE0", Offset = "0x5708FE0", VA = "0x185709BE0")]
	private void IHELJEBDKBP(Action FAMKPEGNHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x57093D0", Offset = "0x57087D0", VA = "0x1857093D0")]
	private void EBEAFMEPLOE(Action FAMKPEGNHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x570A4D0", Offset = "0x57098D0", VA = "0x18570A4D0")]
	public void MCDIHNKBOGI(float BMDHDCNJLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x570AC00", Offset = "0x570A000", VA = "0x18570AC00")]
	public void MEDMFBCNDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x570AD00", Offset = "0x570A100", VA = "0x18570AD00")]
	public void OBGDMCGDCAI(MEDFMHDIPAN NOACKCKBCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x57091D0", Offset = "0x57085D0", VA = "0x1857091D0")]
	public void AFODNHEHIIA(MEDFMHDIPAN NOACKCKBCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5709450", Offset = "0x5708850", VA = "0x185709450")]
	public void EKNCGHOGJGH(MEDFMHDIPAN NOACKCKBCDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class JEDAHJMJLLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static readonly JEDAHJMJLLM FLDDEHNHNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly Action LIIAGGCIAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool NPIEAKJHFPJ;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
	public JEDAHJMJLLM(Action LIIAGGCIAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5709050", Offset = "0x5708450", VA = "0x185709050", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface OFMHIKNEBFO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HFMBLHBCHFB(UnityEngine.Object MAFDHEKFLMG, Action<T> MKMHCIBJPFH);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface DBOOCMDBJLG<T> : global::OFMHIKNEBFO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NGCFODPBFPJ<T> : global::DBOOCMDBJLG<T>, global::OFMHIKNEBFO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class INEFLFALGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public global::NGCFODPBFPJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public global::CGNKCLLPIIA<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public INEFLFALGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2B93EF0", Offset = "0x2B932F0", VA = "0x182B93EF0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static GameObject OMGOHGKEIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly List<global::CGNKCLLPIIA<UnityEngine.Object, Action<T>>> FBMKLLOLMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private T FMGFMENCHHJ;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7B85D0", Offset = "0x7B79D0", VA = "0x1807B85D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3562C00", Offset = "0x3562000", VA = "0x183562C00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3562CE0", Offset = "0x35620E0", VA = "0x183562CE0")]
	private static bool GPHDNLGDABB(T FAMKPEGNHFC, T GPHMIGDKMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x35637B0", Offset = "0x3562BB0", VA = "0x1835637B0")]
	public NGCFODPBFPJ(T NLPLOHACKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3562D70", Offset = "0x3562170", VA = "0x183562D70", Slot = "6")]
	public IDisposable HFMBLHBCHFB(UnityEngine.Object MAFDHEKFLMG, Action<T> MKMHCIBJPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x35633B0", Offset = "0x35627B0", VA = "0x1835633B0")]
	private void LOKECLINNCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class HDJGGANOKAK : OOCLJFKKLDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly FONOILNGPKO MKMPHGOOCNK;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5706C30", Offset = "0x5706030", VA = "0x185706C30")]
	[ELNMOMKNGKB(LBAHANGFDMJ.None)]
	private static void DPKBCOEJEKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
	[Preserve]
	internal HDJGGANOKAK([CNHALHMHHIC(null)] FONOILNGPKO MKMPHGOOCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5706B90", Offset = "0x5705F90", VA = "0x185706B90", Slot = "4")]
	public IDisposable CLALGHNNOIB(float FNLBOIFLFCF, Action<float> IGAMPECHIKO, bool OIEKPCFGPOA = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct HDKNKICFDLK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[ReadOnly]
	public float FFIGBGBIJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[ReadOnly]
	public int EGGOCEMACKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private NativeArray<int> PAEBCDJCFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NativeArray<int> DCODGMPEPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NativeArray<int> LFBAIHGMNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[ReadOnly]
	public NativeArray<MNPLHHCCJGG> HNOBIBFCBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[ReadOnly]
	public NativeArray<float> HEIOEBJCDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[WriteOnly]
	public NativeArray<int> BPNJEMFLAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[WriteOnly]
	public NativeArray<int> IJLKEHEMFBD;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5706CA0", Offset = "0x57060A0", VA = "0x185706CA0")]
	public static HDKNKICFDLK BFPHDDBHNEE(int JJOBFIMABDP, float BMDHDCNJLJF, NativeArray<MNPLHHCCJGG> KJMHLEOIAFO, NativeArray<float> JPFNAPEHEFL, NativeArray<int> CGFHGNFCBNF, NativeArray<int> BAMEMGILNFP, NativeArray<int> HMBGCJBEHGB, NativeArray<int> DCODGMPEPGK, NativeArray<int> LFBAIHGMNFG)
	{
		return default(HDKNKICFDLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5706F60", Offset = "0x5706360", VA = "0x185706F60", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5707170", Offset = "0x5706570", VA = "0x185707170")]
	private bool PKMLHGJPFLL(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5706F30", Offset = "0x5706330", VA = "0x185706F30")]
	private void EAMAJAOHNKE(NativeArray<int> CJDECFAMNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5707040", Offset = "0x5706440", VA = "0x185707040")]
	private int KFOFCNNGBLE(int LNHDDHPFJBE, int HNAFOBKPCNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x57070A0", Offset = "0x57064A0", VA = "0x1857070A0")]
	private void LIJKPPFIOBA(NativeArray<int> CJDECFAMNLN, int FLPONIKCHLP, int IAJFKOKFPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5706D00", Offset = "0x5706100", VA = "0x185706D00")]
	private void DDEMALKOMHJ(NativeArray<int> CJDECFAMNLN, int DENDAMNPBNG, int IIJNPMONJEK, int JJJDPCBNAKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class HGMFFLEGBKI : ALPBEMILOFJ, FONOILNGPKO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private JKJFEHEPODF[] IJLKPMMFAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private CKLDCPHHFDB DJGJGMJDBOO;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5707610", Offset = "0x5706A10", VA = "0x185707610")]
	[ELNMOMKNGKB(LBAHANGFDMJ.None)]
	private static void DPKBCOEJEKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5708020", Offset = "0x5707420", VA = "0x185708020")]
	[Preserve]
	public HGMFFLEGBKI([CNHALHMHHIC(null)] AMKGEGDGJJD GKCKAPCPIFI, [CNHALHMHHIC(null)] LODDJNBEJNB EALMMLGDIOO, [CNHALHMHHIC(null)] LHPIEMJDPMN KBOLDBELEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5707EE0", Offset = "0x57072E0", VA = "0x185707EE0", Slot = "12")]
	public override EJCEALCEAGN PCHFKBKBKCB(CJEOAEENBFH MAFDHEKFLMG, IEnumerator<MOELIBACAGH> BIMIOGLABFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5707890", Offset = "0x5706C90", VA = "0x185707890", Slot = "13")]
	public override void FNNEKAKKIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5707B70", Offset = "0x5706F70", VA = "0x185707B70", Slot = "15")]
	public override void IFELNFPDNDN(LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5707D50", Offset = "0x5707150", VA = "0x185707D50", Slot = "14")]
	protected override void KJAIMLDDOOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x57075D0", Offset = "0x57069D0", VA = "0x1857075D0")]
	private JKJFEHEPODF DAGKCDLJIIB(LIBKFAKJMIH.DBLADPAIJMN DDJDPMGLPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5707E30", Offset = "0x5707230", VA = "0x185707E30", Slot = "16")]
	internal override BIOENEJOAPM OMCNLHACEGH(IEnumerator<MOELIBACAGH> BIMIOGLABFA, Behaviour MAFDHEKFLMG, MHGNLCPNMOB MNPLPCBLMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x57076F0", Offset = "0x5706AF0", VA = "0x1857076F0", Slot = "17")]
	internal override NPLOPBLGHFA EPOLPNAEDMO(LIBKFAKJMIH.DBLADPAIJMN DCDKCDLJBLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5707760", Offset = "0x5706B60", VA = "0x185707760")]
	private void FBMEDNPCACH(JKJFEHEPODF JPABLFHLFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5707680", Offset = "0x5706A80", VA = "0x185707680", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class ALPBEMILOFJ : FONOILNGPKO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly AMKGEGDGJJD GKCKAPCPIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	protected readonly LODDJNBEJNB EALMMLGDIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly LHPIEMJDPMN KBOLDBELEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private NPLOPBLGHFA[] KNKJOFMCNAP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static FONOILNGPKO HNEIEBONIJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x56FCF00", Offset = "0x56FC300", VA = "0x1856FCF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static bool EIOIMMEOHBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LIBKFAKJMIH.DBLADPAIJMN AAHNCCIPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LIBKFAKJMIH.DBLADPAIJMN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7532B0", Offset = "0x7526B0", VA = "0x1807532B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LODDJNBEJNB OBPHKIACCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x56FCC90", Offset = "0x56FC090", VA = "0x1856FCC90")]
	public static EJCEALCEAGN JKIPOBECIKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x56FCFD0", Offset = "0x56FC3D0", VA = "0x1856FCFD0")]
	[Preserve]
	protected ALPBEMILOFJ([CNHALHMHHIC(null)] AMKGEGDGJJD GKCKAPCPIFI, [CNHALHMHHIC(null)] LODDJNBEJNB EALMMLGDIOO, [CNHALHMHHIC(null)] LHPIEMJDPMN KBOLDBELEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x56FC230", Offset = "0x56FB630", VA = "0x1856FC230", Slot = "6")]
	public EJCEALCEAGN BMPOKKCKKNK(IEnumerator<MOELIBACAGH> BIMIOGLABFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x56FC240", Offset = "0x56FB640", VA = "0x1856FC240", Slot = "7")]
	public EJCEALCEAGN BMPOKKCKKNK(Behaviour MAFDHEKFLMG, IEnumerator<MOELIBACAGH> BIMIOGLABFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract EJCEALCEAGN PCHFKBKBKCB(CJEOAEENBFH MAFDHEKFLMG, IEnumerator<MOELIBACAGH> BIMIOGLABFA);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x56FC7F0", Offset = "0x56FBBF0", VA = "0x1856FC7F0", Slot = "13")]
	public virtual void FNNEKAKKIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x56FC1D0", Offset = "0x56FB5D0", VA = "0x1856FC1D0", Slot = "9")]
	public void BHKIIJOCAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x56FCF50", Offset = "0x56FC350", VA = "0x1856FCF50", Slot = "14")]
	protected virtual void KJAIMLDDOOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x56FCA10", Offset = "0x56FBE10", VA = "0x1856FCA10")]
	private void IBIJDHACHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x56FCF70", Offset = "0x56FC370", VA = "0x1856FCF70")]
	private void MPBOPMGIMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x56FC9D0", Offset = "0x56FBDD0", VA = "0x1856FC9D0")]
	private void FODBIMBAOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x56FCF90", Offset = "0x56FC390", VA = "0x1856FCF90")]
	private void ODHCCFDAOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x56FCC70", Offset = "0x56FC070", VA = "0x1856FCC70")]
	private void IFMGJFNHGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x56FCFB0", Offset = "0x56FC3B0", VA = "0x1856FCFB0")]
	private void ONMHFLBACMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x56FC9F0", Offset = "0x56FBDF0", VA = "0x1856FC9F0")]
	private void HBNKGJFGBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x56FCA30", Offset = "0x56FBE30", VA = "0x1856FCA30", Slot = "15")]
	public virtual void IFELNFPDNDN(LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x56FCD30", Offset = "0x56FC130", VA = "0x1856FCD30")]
	private void JODOBCGFGMK(NPLOPBLGHFA JPABLFHLFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x13B11B0", Offset = "0x13B05B0", VA = "0x1813B11B0")]
	private NPLOPBLGHFA OCFDPJIMMAB(LIBKFAKJMIH.DBLADPAIJMN DDJDPMGLPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract BIOENEJOAPM OMCNLHACEGH(IEnumerator<MOELIBACAGH> BIMIOGLABFA, Behaviour ONEIEJKCJBB, MHGNLCPNMOB AGAODHEDDEB);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract NPLOPBLGHFA EPOLPNAEDMO(LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x56FC470", Offset = "0x56FB870", VA = "0x1856FC470", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class BIOENEJOAPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly MHGNLCPNMOB MNPLPCBLMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly BNLGMLBPPAM MAFDHEKFLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly bool NDMPLLMDBPA;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<MOELIBACAGH> BMDOIFELMII
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F10", Offset = "0x6E1310", VA = "0x1806E1F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MOELIBACAGH JPCKOLMDOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6EBA00", Offset = "0x6EAE00", VA = "0x1806EBA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool FIAMLNCJELM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x56FE4B0", Offset = "0x56FD8B0", VA = "0x1856FE4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool IGLBMDMENMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9DFA70", Offset = "0x9DEE70", VA = "0x1809DFA70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x9DFAD0", Offset = "0x9DEED0", VA = "0x1809DFAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string COEOOBLBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E1830", Offset = "0x6E0C30", VA = "0x1806E1830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float HINFLBDMIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x797650", Offset = "0x796A50", VA = "0x180797650")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xD45CE0", Offset = "0xD450E0", VA = "0x180D45CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x56FE6E0", Offset = "0x56FDAE0", VA = "0x1856FE6E0")]
	public BIOENEJOAPM(IEnumerator<MOELIBACAGH> OOKECDLOLBJ, BNLGMLBPPAM MAFDHEKFLMG, MHGNLCPNMOB MNPLPCBLMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x56FE1F0", Offset = "0x56FD5F0", VA = "0x1856FE1F0")]
	public MOELIBACAGH CMHKMEMKBBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x56FE5B0", Offset = "0x56FD9B0", VA = "0x1856FE5B0")]
	public bool OFMAKBBFFEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x56FE530", Offset = "0x56FD930", VA = "0x1856FE530")]
	public void OBGDMCGDCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x56FE620", Offset = "0x56FDA20", VA = "0x1856FE620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x20F4AF0", Offset = "0x20F3EF0", VA = "0x1820F4AF0")]
	[CompilerGenerated]
	private void ABDJHMIILJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class MHGNLCPNMOB : GOMIEHPBIBI, EJCEALCEAGN, MONKECHCONN, PMOAFBNPLHC, IEnumerator, MOELIBACAGH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private LIBKFAKJMIH.DBLADPAIJMN KHDNJPHNMAO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private LIBKFAKJMIH.DBLADPAIJMN LMKLKKDMDBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x77D680", Offset = "0x77CA80", VA = "0x18077D680", Slot = "23")]
		get
		{
			return default(LIBKFAKJMIH.DBLADPAIJMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public LIBKFAKJMIH.DBLADPAIJMN OPMKMCLOLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CBBA0", Offset = "0x7CAFA0", VA = "0x1807CBBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float FCOKHKLMPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A7F90", Offset = "0x8A7390", VA = "0x1808A7F90", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x570EAB0", Offset = "0x570DEB0", VA = "0x18570EAB0", Slot = "24")]
	private bool OCBPPNBBIIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x570EAA0", Offset = "0x570DEA0", VA = "0x18570EAA0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x570EAD0", Offset = "0x570DED0", VA = "0x18570EAD0")]
	public MHGNLCPNMOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal enum KKNIOBOEFJN : byte
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
internal sealed class NPLOPBLGHFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum IMMLBGCLILK
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct IKIIDGFIPMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public LIBKFAKJMIH.DBLADPAIJMN AHGLDHOPEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public IMMLBGCLILK GDGOPKINMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public List<BIOENEJOAPM> LLIHKHJNHEM;
	}

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly IMMLBGCLILK[] BJNJGCILPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool AMDEPJLBINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly BIOENEJOAPM[] DFDPNKEEBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<BIOENEJOAPM> OJBDHMJIDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Stack<int> CPHJKJKBEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly List<BIOENEJOAPM> BPJLEHLMHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Stack<int> BJNOFCHKGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly CKLDCPHHFDB EHLFAKHPKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private bool HFCPHGAMMFJ;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IKIIDGFIPMO[,] DJGHHENPGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6E79C0", Offset = "0x6E6DC0", VA = "0x1806E79C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x57110C0", Offset = "0x57104C0", VA = "0x1857110C0")]
	public NPLOPBLGHFA(LIBKFAKJMIH.DBLADPAIJMN DCDKCDLJBLH, CKLDCPHHFDB EHLFAKHPKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5710BD0", Offset = "0x570FFD0", VA = "0x185710BD0")]
	public void JLOLMFNFBPK(BIOENEJOAPM OOKECDLOLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x570FF10", Offset = "0x570F310", VA = "0x18570FF10")]
	public void BKDIELPDFAI(IList<BIOENEJOAPM> PAOFPLNNOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5710800", Offset = "0x570FC00", VA = "0x185710800")]
	public void HOPEEBNPEGM(IList<BIOENEJOAPM> PAOFPLNNOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5710AD0", Offset = "0x570FED0", VA = "0x185710AD0")]
	private void HPMEEKEONKJ(BIOENEJOAPM OOKECDLOLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5710E30", Offset = "0x5710230", VA = "0x185710E30")]
	private void LMEMCDODGEO(IList<BIOENEJOAPM> PAOFPLNNOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5710660", Offset = "0x570FA60", VA = "0x185710660")]
	private KKNIOBOEFJN EDPCHOBBIOJ(BIOENEJOAPM OOKECDLOLBJ)
	{
		return default(KKNIOBOEFJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5710CF0", Offset = "0x57100F0", VA = "0x185710CF0")]
	public void KJAIMLDDOOF(float BMDHDCNJLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x570FD00", Offset = "0x570F100", VA = "0x18570FD00")]
	public void BHKIIJOCAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5710300", Offset = "0x570F700", VA = "0x185710300")]
	private void CAAGLKJHAFF(List<BIOENEJOAPM> PAOFPLNNOFN, Stack<int> GMBJFOKOOHE, bool EJEADMFEPNL, float LPBMBECPBMP = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5710520", Offset = "0x570F920", VA = "0x185710520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x57101E0", Offset = "0x570F5E0", VA = "0x1857101E0")]
	private void BMHHDNNMJIL(List<BIOENEJOAPM> PAOFPLNNOFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class INLPCACGKMM : CKLDCPHHFDB
{
	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "4")]
	public void OFDGHKBIDMP(string IGHJIHNAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
	public void NODANGGMCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public INLPCACGKMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class GLCIEEFNFGN : BNLGMLBPPAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Behaviour ONEIEJKCJBB;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string COEOOBLBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x57066F0", Offset = "0x5705AF0", VA = "0x1857066F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ALLLILMAHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5706690", Offset = "0x5705A90", VA = "0x185706690", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ILPPLEOINLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5706670", Offset = "0x5705A70", VA = "0x185706670", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
	public GLCIEEFNFGN(Behaviour ONEIEJKCJBB)
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

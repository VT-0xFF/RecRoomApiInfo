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
public class LIFOJJIAADC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority JHPLIMNKKKG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x47AF030", Offset = "0x47AE230", VA = "0x1847AF030")]
	public LIFOJJIAADC(ThreadPriority KJJHGDDBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x47AF020", Offset = "0x47AE220", VA = "0x1847AF020", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> BNMNEKKPPND(List<PlayerLoopSystem> PGGBEFCCFJF, int DKDGNEPCAGM);

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct NOLFNNALCMP
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct LJNLDNJNCHL
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static COKNLFJLEMD JKIFHEHCDKP;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x47AF070", Offset = "0x47AE270", VA = "0x1847AF070")]
				public static PlayerLoopSystem HEINKPAPLPF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct HIGNNAPGALM
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static COKNLFJLEMD OIFCEFDOCCL;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x47AB9E0", Offset = "0x47AABE0", VA = "0x1847AB9E0")]
				public static PlayerLoopSystem HEINKPAPLPF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct PMDEEABEAGA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static COKNLFJLEMD KMMILJLOLFD;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x47B2440", Offset = "0x47B1640", VA = "0x1847B2440")]
				public static PlayerLoopSystem HEINKPAPLPF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct JJCPHNJGCLC
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static COKNLFJLEMD NDHDDMNEJPK;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x47AC7A0", Offset = "0x47AB9A0", VA = "0x1847AC7A0")]
				public static PlayerLoopSystem HEINKPAPLPF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct CJGPNCNMEEO
			{
				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static COKNLFJLEMD PJMLLBKLKDG;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x47A3150", Offset = "0x47A2350", VA = "0x1847A3150")]
				public static PlayerLoopSystem HEINKPAPLPF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			internal struct JFCMHCEOIAF
			{
				[Cpp2IlInjected.Token(Token = "0x2000011")]
				[CompilerGenerated]
				private sealed class MMBJFOBBGKK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000013")]
					public GKCPJPBDDLE.PNBONCIKNMC key;

					[Cpp2IlInjected.Token(Token = "0x6000027")]
					[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
					public MMBJFOBBGKK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000028")]
					[Cpp2IlInjected.Address(RVA = "0x47AF4B0", Offset = "0x47AE6B0", VA = "0x1847AF4B0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static IDisposable BFLEBECDNNJ;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x47AC680", Offset = "0x47AB880", VA = "0x1847AC680")]
				public static PlayerLoopSystem OODCMPCCAFO(GKCPJPBDDLE.PNBONCIKNMC ICIBGJCBOAM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000012")]
			internal struct PKHHKILPBMB
			{
				[Cpp2IlInjected.Token(Token = "0x2000013")]
				[CompilerGenerated]
				private sealed class FALAJFADAMF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000014")]
					public GKCPJPBDDLE.PNBONCIKNMC key;

					[Cpp2IlInjected.Token(Token = "0x600002A")]
					[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
					public FALAJFADAMF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600002B")]
					[Cpp2IlInjected.Address(RVA = "0x47AAAA0", Offset = "0x47A9CA0", VA = "0x1847AAAA0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x47B22C0", Offset = "0x47B14C0", VA = "0x1847B22C0")]
				public static PlayerLoopSystem OODCMPCCAFO(GKCPJPBDDLE.PNBONCIKNMC ICIBGJCBOAM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class EJHDLAPPNJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
			public EJHDLAPPNJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x47A9140", Offset = "0x47A8340", VA = "0x1847A9140")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool BPOPOOLCLNK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool GEABAJDNDHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x47A4880", Offset = "0x47A3A80", VA = "0x1847A4880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x47A4F30", Offset = "0x47A4130", VA = "0x1847A4F30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x47A3430", Offset = "0x47A2630", VA = "0x1847A3430")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x47A48C0", Offset = "0x47A3AC0", VA = "0x1847A48C0")]
		private static void JAAOFNOHFHK(GKCPJPBDDLE.PNBONCIKNMC ICIBGJCBOAM, ref PlayerLoopSystem JLNIDIFOIKG, Type HPECOKDAHOP, Type FPOPAABKOHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x47A4A90", Offset = "0x47A3C90", VA = "0x1847A4A90")]
		private static void JFNJEKILEDO(ref PlayerLoopSystem JLNIDIFOIKG, Type HPECOKDAHOP, Type FPOPAABKOHN, BNMNEKKPPND DBDJFPLOIIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x47A4E10", Offset = "0x47A4010", VA = "0x1847A4E10")]
		private static void OGACALGMAOA(ref PlayerLoopSystem JLNIDIFOIKG, Type HPECOKDAHOP, Type FPOPAABKOHN, PlayerLoopSystem? OJDCMMINDIB, PlayerLoopSystem? CILPPCEHFKA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GKCPJPBDDLE
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum PNBONCIKNMC
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
	public class JJJEPCFAGCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly PNBONCIKNMC BADFPFJOKJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly AEJLOLJIFAF MHOPFMPJGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long EMDPMIEKKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long LNANGJEFFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public long FEGALICBOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int JLKPPAPEAAH;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x47ACC10", Offset = "0x47ABE10", VA = "0x1847ACC10")]
		public JJJEPCFAGCC(PNBONCIKNMC MDKJMLOCOCC, int FCHAKGMIDBP = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x47AC970", Offset = "0x47ABB70", VA = "0x1847AC970")]
		public void CMOALBMPPEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x47ACBB0", Offset = "0x47ABDB0", VA = "0x1847ACBB0")]
		public void MHAAMCDACNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x47AC9E0", Offset = "0x47ABBE0", VA = "0x1847AC9E0")]
		public void JBLAABMBOEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static PNBONCIKNMC[] NDKBBGHALAD;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static JJJEPCFAGCC[] NGFGBMKNBKP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x47AB660", Offset = "0x47AA860", VA = "0x1847AB660")]
	public static JJJEPCFAGCC NEKCLDFJFLK(PNBONCIKNMC ICIBGJCBOAM, int FCHAKGMIDBP = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x47AB5D0", Offset = "0x47AA7D0", VA = "0x1847AB5D0")]
	public static JJJEPCFAGCC DAJODCBJBHC(PNBONCIKNMC ICIBGJCBOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x47AB810", Offset = "0x47AAA10", VA = "0x1847AB810")]
	public static void OPMHOLEKLOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AEJLOLJIFAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int GNKLGLNHMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Queue<double> KKFHFMDNGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double JMDBKFOJFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double ODILKOEGMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double NGLDKICHKGE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double GEFIJDPEBFC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x47A19C0", Offset = "0x47A0BC0", VA = "0x1847A19C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x47A1A20", Offset = "0x47A0C20", VA = "0x1847A1A20")]
	public AEJLOLJIFAF(int MLBAPJGHAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x47A1850", Offset = "0x47A0A50", VA = "0x1847A1850", Slot = "4")]
	public void GDANBBBHBGA(double KGBAJDIJIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x47A1950", Offset = "0x47A0B50", VA = "0x1847A1950", Slot = "5")]
	public void JNOECIFKPLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NCHDIBCPAKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private long NAOLJMJHENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double FMGNEMPIMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double DMEKOBPJKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double BKHHJBAKBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private double LHKAOJJHCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private double JMDBKFOJFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private double ODILKOEGMCM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double KILFLJAFHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB770", Offset = "0x3AEA970", VA = "0x183AEB770", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double IBGFBLPKOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9D0380", Offset = "0x9CF580", VA = "0x1809D0380", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double JFFLEFBOKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x35C6CE0", Offset = "0x35C5EE0", VA = "0x1835C6CE0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double GEFIJDPEBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3687AE0", Offset = "0x3686CE0", VA = "0x183687AE0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x47AF560", Offset = "0x47AE760", VA = "0x1847AF560", Slot = "7")]
	public void GDANBBBHBGA(double KGBAJDIJIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x47AF680", Offset = "0x47AE880", VA = "0x1847AF680", Slot = "8")]
	public void JNOECIFKPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x47AF6C0", Offset = "0x47AE8C0", VA = "0x1847AF6C0")]
	public NCHDIBCPAKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class DEGAKACBIGL
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private interface HLKBCHGLJEO
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool JLEFFLGJAOA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NEIHCBLCFCI();
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private abstract class FJHBLEEMBFJ<TPromise, TMainThreadPromise> : HLKBCHGLJEO where TPromise : KJNBDKOEMOC where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly TPromise ACODLJEIIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected readonly TMainThreadPromise JIMPOAKKNBI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise CIGKBMMAIMM
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x389E530", Offset = "0x389D730", VA = "0x18389E530")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JLEFFLGJAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x389E4E0", Offset = "0x389D6E0", VA = "0x18389E4E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x322C890", Offset = "0x322BA90", VA = "0x18322C890")]
		protected FJHBLEEMBFJ(TPromise ACODLJEIIGI, TMainThreadPromise OJIKBAMDNCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x389E590", Offset = "0x389D790", VA = "0x18389E590", Slot = "5")]
		public void NEIHCBLCFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void JBMGHCEILLP(TPromise ACODLJEIIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class JLLCJHGCAMN<T> : FJHBLEEMBFJ<global::FJLAHCBCPIJ<T>, global::EJFMGPECAAO<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x38A3370", Offset = "0x38A2570", VA = "0x1838A3370")]
		public JLLCJHGCAMN(global::FJLAHCBCPIJ<T> ACODLJEIIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x38A31F0", Offset = "0x38A23F0", VA = "0x1838A31F0", Slot = "6")]
		protected override void JBMGHCEILLP(global::FJLAHCBCPIJ<T> ACODLJEIIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x38A3340", Offset = "0x38A2540", VA = "0x1838A3340")]
		[CompilerGenerated]
		private void NMPDDACOAHA(T KCKMKGJDDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x273F000", Offset = "0x273E200", VA = "0x18273F000")]
		[CompilerGenerated]
		private void ALOACGAGCGG(string GKOBJIGADIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class CEJPDLCHMIE : HLKBCHGLJEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Action GIFFKCDDBCP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JLEFFLGJAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x58AFE0", Offset = "0x58A1E0", VA = "0x18058AFE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6BF360", Offset = "0x6BE560", VA = "0x1806BF360")]
		public CEJPDLCHMIE(Action GIFFKCDDBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1402840", Offset = "0x1401A40", VA = "0x181402840", Slot = "5")]
		public void NEIHCBLCFCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly List<HLKBCHGLJEO> ILNPFEOEBBF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1C97240", Offset = "0x1C96440", VA = "0x181C97240")]
	public static global::FJLAHCBCPIJ<T> EAAFMCEDEDJ<T>(this global::FJLAHCBCPIJ<T> ACODLJEIIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x47A78F0", Offset = "0x47A6AF0", VA = "0x1847A78F0")]
	public static void EAAFMCEDEDJ(Action GIFFKCDDBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1C97180", Offset = "0x1C96380", VA = "0x181C97180")]
	private static global::FJLAHCBCPIJ<T> BPIJAKPJGAG<T>(global::FJLAHCBCPIJ<T> ACODLJEIIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x47A7700", Offset = "0x47A6900", VA = "0x1847A7700")]
	private static void CGDBGOEKDOC(HLKBCHGLJEO NHOKEKGANEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x47A7A50", Offset = "0x47A6C50", VA = "0x1847A7A50")]
	private static void HNEBDEOOMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x47A7980", Offset = "0x47A6B80", VA = "0x1847A7980")]
	private static void EAMBMLJOKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x47A7650", Offset = "0x47A6850", VA = "0x1847A7650")]
	private static void AABKJECKGBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class PCKBEMKCAAD
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private struct PMDDGKGFMLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<Scene> NJMBGONFGMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly string HMAAGGCBEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly LoadSceneMode PHMMPOGHANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly bool KBOGLDENNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly JEOAIEOFIKM PHCHBBAGNOP;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x47B23E0", Offset = "0x47B15E0", VA = "0x1847B23E0")]
		public PMDDGKGFMLL(TaskCompletionSource<Scene> LJKDPAOIJGC, string HMAAGGCBEBN, LoadSceneMode PHMMPOGHANC, bool KBOGLDENNNE, JEOAIEOFIKM PHCHBBAGNOP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct LEGLCNCKHJL : IAsyncStateMachine
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
		public JEOAIEOFIKM stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private global::DCKHMOOINHA<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x47AE860", Offset = "0x47ADA60", VA = "0x1847AE860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x47AEDC0", Offset = "0x47ADFC0", VA = "0x1847AEDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct LBDOJHPEHGB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x47AE570", Offset = "0x47AD770", VA = "0x1847AE570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFE0", Offset = "0x7EB1E0", VA = "0x1807EBFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct IHIHGCODIFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private PMDDGKGFMLL <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x47ABF30", Offset = "0x47AB130", VA = "0x1847ABF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFE0", Offset = "0x7EB1E0", VA = "0x1807EBFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ADPKGDLBFMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public global::EJFMGPECAAO<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public ADPKGDLBFMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x47A1800", Offset = "0x47A0A00", VA = "0x1847A1800")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct KDKEGHOALIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public JEOAIEOFIKM stackTimer;

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
		private ADPKGDLBFMF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private JEOAIEOFIKM <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private JEOAIEOFIKM <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x47AD920", Offset = "0x47ACB20", VA = "0x1847AD920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x47AE0E0", Offset = "0x47AD2E0", VA = "0x1847AE0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct BMCEDPCAGNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public JEOAIEOFIKM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private JEOAIEOFIKM <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private JEOAIEOFIKM <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x47A1CD0", Offset = "0x47A0ED0", VA = "0x1847A1CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x47A23D0", Offset = "0x47A15D0", VA = "0x1847A23D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class HNDGINPLFOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public HNDGINPLFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x47ABF00", Offset = "0x47AB100", VA = "0x1847ABF00")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class INODNCEPHHB : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private KIKOFGNMMEC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public JLGLDFIOJOP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
		[DebuggerHidden]
		public INODNCEPHHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x47AC580", Offset = "0x47AB780", VA = "0x1847AC580", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x47AC240", Offset = "0x47AB440", VA = "0x1847AC240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x47AC630", Offset = "0x47AB830", VA = "0x1847AC630")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x47AC530", Offset = "0x47AB730", VA = "0x1847AC530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DBEEMDMNKPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public global::EJFMGPECAAO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public DBEEMDMNKPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JLBCGAJBDAG : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private KIKOFGNMMEC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public global::EJFMGPECAAO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private DBEEMDMNKPG <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
		[DebuggerHidden]
		public JLBCGAJBDAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x47ACD00", Offset = "0x47ABF00", VA = "0x1847ACD00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x47AD110", Offset = "0x47AC310", VA = "0x1847AD110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static KJNBDKOEMOC DFKMGDFLLEK;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static AsyncOperation BCBDKKHPAEA;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static KJNBDKOEMOC EIIDPPMEBJD;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static string NHDEPPMDJPL;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static ThreadPriority CAPOBINKKNN;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static Task KJFNFDCGOIG;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Queue<PMDDGKGFMLL> CMGFLAPKIKI;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static Task AICBEGNBIPD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool KOCJOPFDFJG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x47B18A0", Offset = "0x47B0AA0", VA = "0x1847B18A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool NPCPCEODPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x47B0ED0", Offset = "0x47B00D0", VA = "0x1847B0ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool LNCKDLPOOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x47B1A50", Offset = "0x47B0C50", VA = "0x1847B1A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> MIKDLGPIMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x47B1060", Offset = "0x47B0260", VA = "0x1847B1060")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x47B1F00", Offset = "0x47B1100", VA = "0x1847B1F00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x47B2140", Offset = "0x47B1340", VA = "0x1847B2140")]
	[NOEEOAFKPPH(PDHPLIPHFDE.EnteredEditModeNextFrame, 0)]
	private static void PBINKMMAMNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x47B2000", Offset = "0x47B1200", VA = "0x1847B2000")]
	[AsyncStateMachine(typeof(LEGLCNCKHJL))]
	public static Task<Scene> ONBOLLIFBBO(string HMAAGGCBEBN, LoadSceneMode PHMMPOGHANC = LoadSceneMode.Single, bool KBOGLDENNNE = false, [Optional] JEOAIEOFIKM DGDCPHKCIDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x47B1E20", Offset = "0x47B1020", VA = "0x1847B1E20")]
	[AsyncStateMachine(typeof(LBDOJHPEHGB))]
	private static Task NNPONPLBNOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x47B0F80", Offset = "0x47B0180", VA = "0x1847B0F80")]
	[AsyncStateMachine(typeof(IHIHGCODIFD))]
	private static Task BDCJNCDHMBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x47B1160", Offset = "0x47B0360", VA = "0x1847B1160")]
	[AsyncStateMachine(typeof(KDKEGHOALIL))]
	private static Task<Scene> FFNKLHDHDIL(string HMAAGGCBEBN, LoadSceneMode PHMMPOGHANC, bool KBOGLDENNNE, JEOAIEOFIKM PHCHBBAGNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x47B1D00", Offset = "0x47B0F00", VA = "0x1847B1D00")]
	[AsyncStateMachine(typeof(BMCEDPCAGNM))]
	private static Task<Scene> NNPEJIAOIDM(JEOAIEOFIKM PHCHBBAGNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x47B1B00", Offset = "0x47B0D00", VA = "0x1847B1B00")]
	public static global::FJLAHCBCPIJ<Scene> LMKLHMNGIAC(string HMAAGGCBEBN, LoadSceneMode PHMMPOGHANC = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x47B12A0", Offset = "0x47B04A0", VA = "0x1847B12A0")]
	public static KJNBDKOEMOC FGPMHMNLCNE(string HMAAGGCBEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x47B16C0", Offset = "0x47B08C0", VA = "0x1847B16C0")]
	[IteratorStateMachine(typeof(INODNCEPHHB))]
	private static IEnumerator<KIKOFGNMMEC> GLABEMHIDIM(string HMAAGGCBEBN, JLGLDFIOJOP CMPBMDPAIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x47B1C70", Offset = "0x47B0E70", VA = "0x1847B1C70")]
	[IteratorStateMachine(typeof(JLBCGAJBDAG))]
	private static IEnumerator<KIKOFGNMMEC> NFNNICONKAI(string HMAAGGCBEBN, LoadSceneMode PHMMPOGHANC, global::EJFMGPECAAO<Scene> CMPBMDPAIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x47B1750", Offset = "0x47B0950", VA = "0x1847B1750")]
	public static bool JGBPGFAPKIG(out string IAJLKJMPDAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BPNFHMPFIOL
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x47A24B0", Offset = "0x47A16B0", VA = "0x1847A24B0")]
	public static IDisposable BBLBHEEBDDP(this OECBFFHHMBC FFACCLDEOCL, float DMPDIIEOOAL, Action<float> OELODJPDBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x47A2530", Offset = "0x47A1730", VA = "0x1847A2530")]
	public static IDisposable EJINDOFGPJD(this OECBFFHHMBC FFACCLDEOCL, Action<float> OELODJPDBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x47A25B0", Offset = "0x47A17B0", VA = "0x1847A25B0")]
	public static IDisposable OIMADHHBILC(this OECBFFHHMBC FFACCLDEOCL, Action<float> OELODJPDBPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class CBMNFIAFPFG
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x47A2920", Offset = "0x47A1B20", VA = "0x1847A2920")]
	public static IDisposable BLHOGPAHPFI(this MonoBehaviour FBECIMFMPPP, Action OELODJPDBPB, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x47A2750", Offset = "0x47A1950", VA = "0x1847A2750")]
	public static IDisposable BLHOGPAHPFI(this MonoBehaviour FBECIMFMPPP, Action<float> OELODJPDBPB, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x47A29A0", Offset = "0x47A1BA0", VA = "0x1847A29A0")]
	public static IDisposable BLLHJLKIHHA(this MonoBehaviour FBECIMFMPPP, Action OELODJPDBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x47A2B30", Offset = "0x47A1D30", VA = "0x1847A2B30")]
	public static IDisposable DMGJJDONCMM(this MonoBehaviour FBECIMFMPPP, Action OELODJPDBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x47A3030", Offset = "0x47A2230", VA = "0x1847A3030")]
	public static IDisposable OGDIHOCCFFJ(this MonoBehaviour FBECIMFMPPP, Action OELODJPDBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x47A30A0", Offset = "0x47A22A0", VA = "0x1847A30A0")]
	public static IDisposable PPCFGGFHHOD(this MonoBehaviour FBECIMFMPPP, Action OELODJPDBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x47A2F30", Offset = "0x47A2130", VA = "0x1847A2F30")]
	public static IDisposable MLNJELCGJJB(this MonoBehaviour FBECIMFMPPP, Action OELODJPDBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x47A2D60", Offset = "0x47A1F60", VA = "0x1847A2D60")]
	public static IDisposable KEGGBBNDGBE(this MonoBehaviour FBECIMFMPPP, float DMPDIIEOOAL, Action<float> OELODJPDBPB, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD, bool MJFDOACBKMH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x47A2BA0", Offset = "0x47A1DA0", VA = "0x1847A2BA0")]
	public static IDisposable GNFCAFAPBHI(this MonoBehaviour FBECIMFMPPP, float DMPDIIEOOAL, Action<float> OELODJPDBPB, bool MJFDOACBKMH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x47A2C40", Offset = "0x47A1E40", VA = "0x1847A2C40")]
	public static IDisposable IJIGKECPOKG(this MonoBehaviour FBECIMFMPPP, Action<float> OELODJPDBPB, bool MJFDOACBKMH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x47A2630", Offset = "0x47A1830", VA = "0x1847A2630")]
	public static IDisposable AHJPCIJBCDA(this MonoBehaviour FBECIMFMPPP, Action<float> OELODJPDBPB, bool MJFDOACBKMH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x47A2CD0", Offset = "0x47A1ED0", VA = "0x1847A2CD0")]
	public static IDisposable JPAONJEOIDF(this MonoBehaviour FBECIMFMPPP, Action<float> OELODJPDBPB, bool MJFDOACBKMH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x47A2A10", Offset = "0x47A1C10", VA = "0x1847A2A10")]
	public static IDisposable CFLIHAJNIHE(this MonoBehaviour FBECIMFMPPP, Action<float> OELODJPDBPB, bool MJFDOACBKMH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x47A2AA0", Offset = "0x47A1CA0", VA = "0x1847A2AA0")]
	public static IDisposable CKMBMOJIECK(this MonoBehaviour FBECIMFMPPP, Action<float> OELODJPDBPB, bool MJFDOACBKMH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x47A2FA0", Offset = "0x47A21A0", VA = "0x1847A2FA0")]
	public static IDisposable MNMPOFKGEPP(this MonoBehaviour FBECIMFMPPP, Action<float> OELODJPDBPB, bool MJFDOACBKMH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x47A2EA0", Offset = "0x47A20A0", VA = "0x1847A2EA0")]
	public static IDisposable LHEIMMAGDLN(this MonoBehaviour FBECIMFMPPP, Action<float> OELODJPDBPB, bool MJFDOACBKMH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x47A2E00", Offset = "0x47A2000", VA = "0x1847A2E00")]
	public static IDisposable KPAECPPEEIK(this MonoBehaviour FBECIMFMPPP, float DMPDIIEOOAL, Action<float> OELODJPDBPB, bool MJFDOACBKMH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x47A26C0", Offset = "0x47A18C0", VA = "0x1847A26C0")]
	public static IDisposable AMFFLEOAJJB(this MonoBehaviour FBECIMFMPPP, Action<float> OELODJPDBPB, bool MJFDOACBKMH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class HKAGMIONEPG
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class ANLNEOLKJJB : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private KIKOFGNMMEC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public DIFIILPGEFA.OPLOIIAFJDL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private JFDLKELLBCO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
		[DebuggerHidden]
		public ANLNEOLKJJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x47A1AC0", Offset = "0x47A0CC0", VA = "0x1847A1AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x47A1B80", Offset = "0x47A0D80", VA = "0x1847A1B80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FMKMIJDFNAJ : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private KIKOFGNMMEC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public DIFIILPGEFA.OPLOIIAFJDL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private JFDLKELLBCO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
		[DebuggerHidden]
		public FMKMIJDFNAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x47AB300", Offset = "0x47AA500", VA = "0x1847AB300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x47AB3E0", Offset = "0x47AA5E0", VA = "0x1847AB3E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x47ABC90", Offset = "0x47AAE90", VA = "0x1847ABC90")]
	public static NOIGHMHHCPP BLHOGPAHPFI(Action OELODJPDBPB, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x47ABD70", Offset = "0x47AAF70", VA = "0x1847ABD70")]
	public static NOIGHMHHCPP BLHOGPAHPFI(Behaviour FFACCLDEOCL, Action OELODJPDBPB, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x47ABBB0", Offset = "0x47AADB0", VA = "0x1847ABBB0")]
	public static NOIGHMHHCPP BLHOGPAHPFI(Behaviour FFACCLDEOCL, Action<float> OELODJPDBPB, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x47ABE80", Offset = "0x47AB080", VA = "0x1847ABE80")]
	[IteratorStateMachine(typeof(ANLNEOLKJJB))]
	private static IEnumerator<KIKOFGNMMEC> IIHLAIBDIJJ(DIFIILPGEFA.OPLOIIAFJDL BFLGIKFBFBM, Action OELODJPDBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x47ABE00", Offset = "0x47AB000", VA = "0x1847ABE00")]
	[IteratorStateMachine(typeof(FMKMIJDFNAJ))]
	private static IEnumerator<KIKOFGNMMEC> IIHLAIBDIJJ(DIFIILPGEFA.OPLOIIAFJDL BFLGIKFBFBM, Action<float> OELODJPDBPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MGOEGMEKJAB
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class EMEFELHIJEG : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private KIKOFGNMMEC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public DGKBLMGNEEC schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public DIFIILPGEFA.OPLOIIAFJDL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private PDKIAEHGJOC <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
		[DebuggerHidden]
		public EMEFELHIJEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x47AA920", Offset = "0x47A9B20", VA = "0x1847AA920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x47AAA50", Offset = "0x47A9C50", VA = "0x1847AAA50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x47AF240", Offset = "0x47AE440", VA = "0x1847AF240")]
	public static NOIGHMHHCPP BLHOGPAHPFI(MonoBehaviour FBECIMFMPPP, float DMPDIIEOOAL, Action<float> OELODJPDBPB, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD, bool MJFDOACBKMH = true, [Optional] OEIKKDFMJIK JALGIFFCINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x47AF320", Offset = "0x47AE520", VA = "0x1847AF320")]
	public static NOIGHMHHCPP FABCEJCHLMJ(OECBFFHHMBC FFACCLDEOCL, float DMPDIIEOOAL, Action<float> OELODJPDBPB, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD, bool MJFDOACBKMH = true, [Optional] OEIKKDFMJIK JALGIFFCINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x47AF400", Offset = "0x47AE600", VA = "0x1847AF400")]
	[IteratorStateMachine(typeof(EMEFELHIJEG))]
	private static IEnumerator<KIKOFGNMMEC> IIHLAIBDIJJ(DGKBLMGNEEC DCELCMAEBMA, float DMPDIIEOOAL, DIFIILPGEFA.OPLOIIAFJDL BFLGIKFBFBM, Action<float> OELODJPDBPB, bool MJFDOACBKMH = true, [Optional] OEIKKDFMJIK JALGIFFCINM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EGBBFNFPBME
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class BBEDBGOKNCE : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private KIKOFGNMMEC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public DIFIILPGEFA.OPLOIIAFJDL queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
		[DebuggerHidden]
		public BBEDBGOKNCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x47A1BD0", Offset = "0x47A0DD0", VA = "0x1847A1BD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x47A1C80", Offset = "0x47A0E80", VA = "0x1847A1C80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x47A90C0", Offset = "0x47A82C0", VA = "0x1847A90C0")]
	[IteratorStateMachine(typeof(BBEDBGOKNCE))]
	private static IEnumerator<KIKOFGNMMEC> NPHKGHALBEL(DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD, Func<bool> PCFGDKHGJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x47A8FE0", Offset = "0x47A81E0", VA = "0x1847A8FE0")]
	public static NOIGHMHHCPP MOINPAOCECK(this MonoBehaviour FBECIMFMPPP, Func<bool> PCFGDKHGJEE, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD = DIFIILPGEFA.OPLOIIAFJDL.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class ACMHACDHCDP
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class LFBFHPGBLEA : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private KIKOFGNMMEC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public DIFIILPGEFA.OPLOIIAFJDL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
		[DebuggerHidden]
		public LFBFHPGBLEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x47AEE10", Offset = "0x47AE010", VA = "0x1847AEE10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x47AEED0", Offset = "0x47AE0D0", VA = "0x1847AEED0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x47A13D0", Offset = "0x47A05D0", VA = "0x1847A13D0")]
	[IteratorStateMachine(typeof(LFBFHPGBLEA))]
	private static IEnumerator<KIKOFGNMMEC> FILHPCEIMOE(float CBENACINCFG, DIFIILPGEFA.OPLOIIAFJDL BFLGIKFBFBM, Action LIGNCFOLDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x47A1590", Offset = "0x47A0790", VA = "0x1847A1590")]
	public static NOIGHMHHCPP GIEEPPOBHEG(this MonoBehaviour FBECIMFMPPP, float CBENACINCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x47A1460", Offset = "0x47A0660", VA = "0x1847A1460")]
	public static NOIGHMHHCPP FJDLFNCCKAF(this MonoBehaviour FBECIMFMPPP, Action LIGNCFOLDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x47A16C0", Offset = "0x47A08C0", VA = "0x1847A16C0")]
	public static NOIGHMHHCPP KGKLOJMICHD(this MonoBehaviour FBECIMFMPPP, Action LIGNCFOLDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x47A1310", Offset = "0x47A0510", VA = "0x1847A1310")]
	public static NOIGHMHHCPP FBBOIAECJMA(this MonoBehaviour FBECIMFMPPP, Action LIGNCFOLDGO, [Optional] OEIKKDFMJIK JALGIFFCINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x47A1760", Offset = "0x47A0960", VA = "0x1847A1760")]
	public static NOIGHMHHCPP MCGDOMOLJLI(this MonoBehaviour FBECIMFMPPP, Action LIGNCFOLDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x47A1620", Offset = "0x47A0820", VA = "0x1847A1620")]
	public static NOIGHMHHCPP JBGGBFHGHJD(this MonoBehaviour FBECIMFMPPP, Action LIGNCFOLDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x47A11E0", Offset = "0x47A03E0", VA = "0x1847A11E0")]
	private static NOIGHMHHCPP BEDEBGBBCBP(MonoBehaviour FBECIMFMPPP, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD, Action LIGNCFOLDGO, [Optional] OEIKKDFMJIK JALGIFFCINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x47A1500", Offset = "0x47A0700", VA = "0x1847A1500")]
	public static NOIGHMHHCPP FLEIMIBMDOK(this MonoBehaviour FBECIMFMPPP, float AEBDGCDDLMA, Action LIGNCFOLDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x47A1280", Offset = "0x47A0480", VA = "0x1847A1280")]
	public static NOIGHMHHCPP CGOAHPPAHAC(this MonoBehaviour FBECIMFMPPP, float AEBDGCDDLMA, Action LIGNCFOLDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x47A1150", Offset = "0x47A0350", VA = "0x1847A1150")]
	public static NOIGHMHHCPP AJAHAEEBKEM(this MonoBehaviour FBECIMFMPPP, float AEBDGCDDLMA, Action LIGNCFOLDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x47A1340", Offset = "0x47A0540", VA = "0x1847A1340")]
	public static NOIGHMHHCPP FDBBHABMKBC(this MonoBehaviour FBECIMFMPPP, float AEBDGCDDLMA, Action LIGNCFOLDGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class FMACLLIPLEA : OOHPHGOJDAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class GAJFEEGJCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public FMACLLIPLEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public GAJFEEGJCFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x47AB430", Offset = "0x47AA630", VA = "0x1847AB430")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class NGECGAKIGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public FMACLLIPLEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public NGECGAKIGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x47AB430", Offset = "0x47AA630", VA = "0x1847AB430")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly float CDGOFEMPAMD;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x47AB2B0", Offset = "0x47AA4B0", VA = "0x1847AB2B0")]
	public FMACLLIPLEA(Behaviour FFACCLDEOCL, float CDGOFEMPAMD, [Optional] Action NGAJICDJIDN, [Optional] OEIKKDFMJIK JALGIFFCINM, [Optional] DGKBLMGNEEC DCELCMAEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x47AB1D0", Offset = "0x47AA3D0", VA = "0x1847AB1D0", Slot = "9")]
	protected override bool LLDNOGDMJCP(Action GIFFKCDDBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x47AB0F0", Offset = "0x47AA2F0", VA = "0x1847AB0F0", Slot = "10")]
	protected override bool FBJKNKLODMD(Action GIFFKCDDBCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KDKPCBFKPAM
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MLBHBGLPOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CJNKADGHGPA;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MKENCFDGMNG(bool HBFPIFLJBKH = false);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MKENCFDGMNG(Action GIFFKCDDBCP, bool HBFPIFLJBKH = false);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class OOHPHGOJDAJ : KDKPCBFKPAM
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class DDDGJPNIMFE : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private KIKOFGNMMEC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public OOHPHGOJDAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
		[DebuggerHidden]
		public DDDGJPNIMFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x47A5200", Offset = "0x47A4400", VA = "0x1847A5200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x47A52D0", Offset = "0x47A44D0", VA = "0x1847A52D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Behaviour FFACCLDEOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly Action NGAJICDJIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private EIPPDOBKMFD IFBIBCCJLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly OEIKKDFMJIK JALGIFFCINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	protected readonly DGKBLMGNEEC DCELCMAEBMA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MLBHBGLPOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x756DF0", Offset = "0x755FF0", VA = "0x180756DF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action CJNKADGHGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x47B0890", Offset = "0x47AFA90", VA = "0x1847B0890", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x47B07F0", Offset = "0x47AF9F0", VA = "0x1847B07F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x47B0D00", Offset = "0x47AFF00", VA = "0x1847B0D00")]
	protected OOHPHGOJDAJ(Behaviour FFACCLDEOCL, [Optional] Action NGAJICDJIDN, [Optional] OEIKKDFMJIK JALGIFFCINM, [Optional] DGKBLMGNEEC DCELCMAEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x47B0A20", Offset = "0x47AFC20", VA = "0x1847B0A20", Slot = "7")]
	public bool MKENCFDGMNG(bool HBFPIFLJBKH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x47B0A80", Offset = "0x47AFC80", VA = "0x1847B0A80", Slot = "8")]
	public bool MKENCFDGMNG(Action GIFFKCDDBCP, bool HBFPIFLJBKH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool LLDNOGDMJCP(Action GIFFKCDDBCP);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool FBJKNKLODMD(Action GIFFKCDDBCP);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x47B0B10", Offset = "0x47AFD10", VA = "0x1847B0B10")]
	protected void NHPEGDPDOIK(Action GIFFKCDDBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x47B0B30", Offset = "0x47AFD30", VA = "0x1847B0B30")]
	protected KJNBDKOEMOC OFDJDGNAAJL(float PHHEPBHPBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x47B09B0", Offset = "0x47AFBB0", VA = "0x1847B09B0")]
	private void LPBCIHBGHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x47B0930", Offset = "0x47AFB30", VA = "0x1847B0930")]
	[IteratorStateMachine(typeof(DDDGJPNIMFE))]
	private IEnumerator<KIKOFGNMMEC> JIALCKHACAE(float PHHEPBHPBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x47B0AD0", Offset = "0x47AFCD0", VA = "0x1847B0AD0")]
	[CompilerGenerated]
	private void NEDDKOFCAHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class KOLOIIAMFHJ : OOHPHGOJDAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly float ALNIBIAFHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly int GEHPPCDMJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly float CNJCNNHPKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly float[] LAFEKGCDEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int MFNFKPNDKLG;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x47AE420", Offset = "0x47AD620", VA = "0x1847AE420")]
	public KOLOIIAMFHJ(Behaviour FFACCLDEOCL, float BAFOCNJHADN, int GEHPPCDMJEJ, [Optional] Action NGAJICDJIDN, float CNJCNNHPKCP = 0f, [Optional] OEIKKDFMJIK JALGIFFCINM, [Optional] DGKBLMGNEEC DCELCMAEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x58AEC0", Offset = "0x58A0C0", VA = "0x18058AEC0", Slot = "9")]
	protected override bool LLDNOGDMJCP(Action GIFFKCDDBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x47AE200", Offset = "0x47AD400", VA = "0x1847AE200", Slot = "10")]
	protected override bool FBJKNKLODMD(Action GIFFKCDDBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x47AE170", Offset = "0x47AD370", VA = "0x1847AE170")]
	private void BADEDBNDPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class KJPPJPBNBMG : OOHPHGOJDAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly float CDGOFEMPAMD;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x47AB2B0", Offset = "0x47AA4B0", VA = "0x1847AB2B0")]
	public KJPPJPBNBMG(Behaviour FFACCLDEOCL, float CDGOFEMPAMD, [Optional] Action NGAJICDJIDN, [Optional] OEIKKDFMJIK JALGIFFCINM, [Optional] DGKBLMGNEEC DCELCMAEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x58AEC0", Offset = "0x58A0C0", VA = "0x18058AEC0", Slot = "9")]
	protected override bool LLDNOGDMJCP(Action GIFFKCDDBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x47AE130", Offset = "0x47AD330", VA = "0x1847AE130", Slot = "10")]
	protected override bool FBJKNKLODMD(Action GIFFKCDDBCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class DKAFJKIONCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class EBGBADDAHBM : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private KIKOFGNMMEC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
		[DebuggerHidden]
		public EBGBADDAHBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x47A8880", Offset = "0x47A7A80", VA = "0x1847A8880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x47A8920", Offset = "0x47A7B20", VA = "0x1847A8920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private NOIGHMHHCPP ODABAKGKBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private OECBFFHHMBC FFACCLDEOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Action<float> AOJOCHAFIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private float EEBOGMDHGOI;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x47A82E0", Offset = "0x47A74E0", VA = "0x1847A82E0")]
	public DKAFJKIONCH(OECBFFHHMBC FFACCLDEOCL, float DMPDIIEOOAL, Action<float> OELODJPDBPB, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x47A7F70", Offset = "0x47A7170", VA = "0x1847A7F70")]
	private void BHGCANOBFOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x47A7E60", Offset = "0x47A7060", VA = "0x1847A7E60")]
	private void BENJMDKCHKH(string GKOBJIGADIL, Action CJHOLJFKKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x47A8270", Offset = "0x47A7470", VA = "0x1847A8270")]
	[IteratorStateMachine(typeof(EBGBADDAHBM))]
	private IEnumerator<KIKOFGNMMEC> OIJOLOLCMGC(Action CJHOLJFKKGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x47A8210", Offset = "0x47A7410", VA = "0x1847A8210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x47A80C0", Offset = "0x47A72C0", VA = "0x1847A80C0")]
	[CompilerGenerated]
	private void CLGIGFJOLPK(string NBMFBMPPBLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class PMFKNMFINIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class OFKKMBKDEKB : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private KIKOFGNMMEC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
		[DebuggerHidden]
		public OFKKMBKDEKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x47AF730", Offset = "0x47AE930", VA = "0x1847AF730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x47AF7D0", Offset = "0x47AE9D0", VA = "0x1847AF7D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private NOIGHMHHCPP ODABAKGKBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private MonoBehaviour FBECIMFMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Action OELODJPDBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action<float> AOJOCHAFIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private float EEBOGMDHGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool MJFDOACBKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly OEIKKDFMJIK JALGIFFCINM;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x47B30C0", Offset = "0x47B22C0", VA = "0x1847B30C0")]
	public PMFKNMFINIM(MonoBehaviour FBECIMFMPPP, Action OELODJPDBPB, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD, [Optional] OEIKKDFMJIK JALGIFFCINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x47B2D40", Offset = "0x47B1F40", VA = "0x1847B2D40")]
	public PMFKNMFINIM(MonoBehaviour FBECIMFMPPP, Action<float> OELODJPDBPB, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD, [Optional] OEIKKDFMJIK JALGIFFCINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x47B2EF0", Offset = "0x47B20F0", VA = "0x1847B2EF0")]
	public PMFKNMFINIM(MonoBehaviour FBECIMFMPPP, float DMPDIIEOOAL, Action<float> OELODJPDBPB, DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD, bool MJFDOACBKMH = true, [Optional] OEIKKDFMJIK JALGIFFCINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x47B2880", Offset = "0x47B1A80", VA = "0x1847B2880")]
	private void BLHOGPAHPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x47B2B00", Offset = "0x47B1D00", VA = "0x1847B2B00")]
	private void MOFHEPCDKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x47B2720", Offset = "0x47B1920", VA = "0x1847B2720")]
	private void BHGCANOBFOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x47B2610", Offset = "0x47B1810", VA = "0x1847B2610")]
	private void BENJMDKCHKH(string GKOBJIGADIL, Action CJHOLJFKKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x47B2CD0", Offset = "0x47B1ED0", VA = "0x1847B2CD0")]
	[IteratorStateMachine(typeof(OFKKMBKDEKB))]
	private IEnumerator<KIKOFGNMMEC> OIJOLOLCMGC(Action CJHOLJFKKGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x47B2A20", Offset = "0x47B1C20", VA = "0x1847B2A20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x47B29A0", Offset = "0x47B1BA0", VA = "0x1847B29A0")]
	[CompilerGenerated]
	private void DMLCJAGILMI(string NBMFBMPPBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x47B2A80", Offset = "0x47B1C80", VA = "0x1847B2A80")]
	[CompilerGenerated]
	private void MFNFEPHKGBE(string NBMFBMPPBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x47B2C50", Offset = "0x47B1E50", VA = "0x1847B2C50")]
	[CompilerGenerated]
	private void NANAOLNKBOG(string NBMFBMPPBLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Flags]
internal enum AHPGOBAHDEO : byte
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
internal sealed class KBJAFLLBGKG : DGKBLMGNEEC
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public float ILHBIFMCGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x47AD830", Offset = "0x47ACA30", VA = "0x1847AD830", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float NMMNIAIIPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x47AD840", Offset = "0x47ACA40", VA = "0x1847AD840", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public double HAGHEGIEMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x47AD810", Offset = "0x47ACA10", VA = "0x1847AD810", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x47AD850", Offset = "0x47ACA50", VA = "0x1847AD850")]
	[CFCNMFNLFMK]
	private static void PBHFFOPLLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	[Preserve]
	internal KBJAFLLBGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal interface PBHBDGOKANB
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOLEKLBFKEC(string KFCJDHCECCC);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCNNBKHIANJ();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal interface FEAKAOCOFKF
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	string NKAGADDFNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool JPAIKEIPKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool KIAJKGJMBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class DNEBEGCKDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public DDPBHOCINKP CONEGDLNICA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int AJKNHICCIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x58AED0", Offset = "0x58A0D0", VA = "0x18058AED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x58AEE0", Offset = "0x58A0E0", VA = "0x18058AEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x47A8550", Offset = "0x47A7750", VA = "0x1847A8550")]
	public static KIKOFGNMMEC DJGLFGIPOFL(IEnumerator<KIKOFGNMMEC> BIIJFNDJGOF, DFKFAODNLIK DBBNLJKOLFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x47A8470", Offset = "0x47A7670", VA = "0x1847A8470")]
	public KIKOFGNMMEC DJGLFGIPOFL(DFKFAODNLIK[] DGPHCMCBCPL, IEnumerator<KIKOFGNMMEC>[] BOMNAKAGNOK, KIKOFGNMMEC[] PCBGJENMJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x47A8780", Offset = "0x47A7980", VA = "0x1847A8780")]
	public void JOGGNEAJHIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x47A86B0", Offset = "0x47A78B0", VA = "0x1847A86B0")]
	public void IENEBMBMFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x47A87B0", Offset = "0x47A79B0", VA = "0x1847A87B0")]
	public void OMKPAKOKAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x47A8780", Offset = "0x47A7980", VA = "0x1847A8780")]
	public void PEDGBALGNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public DNEBEGCKDCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class DDPBHOCINKP
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct BLNELCGHNPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public DNEBEGCKDCJ HJKOECDFIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public OECBFFHHMBC HGPFOOGDCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public DFKFAODNLIK EBOLFNGJDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public IEnumerator<KIKOFGNMMEC> PGHKEMBKNCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public KIKOFGNMMEC PPHEGKALOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AHPGOBAHDEO ENEKHHPCGJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct MDCGFFGIJHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public DIFIILPGEFA.OPLOIIAFJDL CKCDJDFJNFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public List<BLNELCGHNPP> JKHBCGONJAF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class JLLCHCAICPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public DDPBHOCINKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public OECBFFHHMBC context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public DNEBEGCKDCJ routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AHPGOBAHDEO coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public DFKFAODNLIK promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public KIKOFGNMMEC currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public IEnumerator<KIKOFGNMMEC> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public JLLCHCAICPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x47AD160", Offset = "0x47AC360", VA = "0x1847AD160")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class KPCABBBJLPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public DNEBEGCKDCJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public DDPBHOCINKP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public KPCABBBJLPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x47AE530", Offset = "0x47AD730", VA = "0x1847AE530")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class NMCMDFEBHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public DNEBEGCKDCJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public DDPBHOCINKP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public NMCMDFEBHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x47AF6F0", Offset = "0x47AE8F0", VA = "0x1847AF6F0")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class CDPDAPLGHMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public DNEBEGCKDCJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public DDPBHOCINKP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public CDPDAPLGHMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x47A3110", Offset = "0x47A2310", VA = "0x1847A3110")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const AHPGOBAHDEO NEPAEPHFFPF = AHPGOBAHDEO.Cancelled | AHPGOBAHDEO.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool[] KDMAMNAAEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NativeArray<AHPGOBAHDEO> GDMHFDLACND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private NativeArray<float> HMLLJMEBDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private NativeArray<int> JICHCOBKIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private NativeArray<int> FCGLMNKKOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NativeArray<int> DPIPOHEENBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private NativeArray<int> MPPMBIOMGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private NativeArray<int> MGJGCFOGEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private DNEBEGCKDCJ[] LDJIDNJOPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private DFKFAODNLIK[] DGPHCMCBCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private OECBFFHHMBC[] FAEIHIPNDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private IEnumerator<KIKOFGNMMEC>[] JANKIOLMGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private KIKOFGNMMEC[] PMJKIPNPHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int POJABNLGNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int FDMAMJMNCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly int HBHOFKMBJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private float OIEAFCCDLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private FCJJHKLHCOF KPMGEAMMKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private JobHandle BAGADMHPEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private List<DNEBEGCKDCJ> AMLICCEBENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool GOBJKFCJEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> CIOKJHDMDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<Action> PNDKFIICBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool IABCGHGNHKB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public MDCGFFGIJHA[] GCBLDFBILNO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xEC0230", Offset = "0xEBF430", VA = "0x180EC0230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x47A6A20", Offset = "0x47A5C20", VA = "0x1847A6A20")]
	private static int OHLADLFEPMO(DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x47A70F0", Offset = "0x47A62F0", VA = "0x1847A70F0")]
	public DDPBHOCINKP(DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x47A5E10", Offset = "0x47A5010", VA = "0x1847A5E10")]
	private void INJHHNMBNIL(ref int MLBLGCNFLCK, int JPGDKABDDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x47A6B10", Offset = "0x47A5D10", VA = "0x1847A6B10")]
	public void PEFLGMAENNF(OECBFFHHMBC FFACCLDEOCL, KIKOFGNMMEC MOCMLMGPIBK, IEnumerator<KIKOFGNMMEC> BIIJFNDJGOF, DFKFAODNLIK DBBNLJKOLFO, [Optional] DNEBEGCKDCJ LFPMOHPEHOM, AHPGOBAHDEO BCLHLJKMNPK = AHPGOBAHDEO.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x47A5C20", Offset = "0x47A4E20", VA = "0x1847A5C20")]
	public void IKIKGKBAOFP(IEnumerable<BLNELCGHNPP> OBIEMMEJFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x47A6C70", Offset = "0x47A5E70", VA = "0x1847A6C70")]
	private BLNELCGHNPP PGNGHKPLHNA(int KPFBLFGBCHL)
	{
		return default(BLNELCGHNPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x47A6190", Offset = "0x47A5390", VA = "0x1847A6190")]
	private void KLLOHIBLMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2F89AF0", Offset = "0x2F88CF0", VA = "0x182F89AF0")]
	private static void IBJOGEDPIBA<T>(int KPFBLFGBCHL, T[] HLKIMICBFKD, int FECFCKEKGOF, [Optional] T FCFHIPGMLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2F89AD0", Offset = "0x2F88CD0", VA = "0x182F89AD0")]
	private static void IBJOGEDPIBA<T>(int KPFBLFGBCHL, NativeArray<T> HLKIMICBFKD, int FECFCKEKGOF, [Optional] T FCFHIPGMLAN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x47A5320", Offset = "0x47A4520", VA = "0x1847A5320")]
	private void AEDBKMCCKLM(IEnumerable<BLNELCGHNPP> OBIEMMEJFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x47A5640", Offset = "0x47A4840", VA = "0x1847A5640")]
	private void EBGBOJKNAAP(BLNELCGHNPP LOGPJFHFJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x47A58A0", Offset = "0x47A4AA0", VA = "0x1847A58A0")]
	private KHOCMOBHBLN HKAAKPPEFPP(int NJCHCFEMDDJ)
	{
		return default(KHOCMOBHBLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x47A5FA0", Offset = "0x47A51A0", VA = "0x1847A5FA0")]
	public void JDJAEHHLFLL(float GHFDDCFNPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x47A69A0", Offset = "0x47A5BA0", VA = "0x1847A69A0")]
	private void MDAKDJAPLNK(Action KICBFMPMNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x47A55C0", Offset = "0x47A47C0", VA = "0x1847A55C0")]
	private void BKMMMBMCIAO(Action KICBFMPMNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x47A6500", Offset = "0x47A5700", VA = "0x1847A6500")]
	public void MBDEHGPNPPL(float GHFDDCFNPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x47A57C0", Offset = "0x47A49C0", VA = "0x1847A57C0")]
	public void HDNJGCNGFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x47A6A50", Offset = "0x47A5C50", VA = "0x1847A6A50")]
	public void PEDGBALGNDN(DNEBEGCKDCJ HOBKEEJLLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x47A5700", Offset = "0x47A4900", VA = "0x1847A5700")]
	public void EPFGIGMLGND(DNEBEGCKDCJ HOBKEEJLLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x47A5B60", Offset = "0x47A4D60", VA = "0x1847A5B60")]
	public void IJFLDLKPBCB(DNEBEGCKDCJ HOBKEEJLLHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class LFFFOPFHIGB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static readonly LFFFOPFHIGB AGHBDCJKPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly Action NEPFENJAKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private bool HNFBEGJGFGC;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6BF360", Offset = "0x6BE560", VA = "0x1806BF360")]
	public LFFFOPFHIGB(Action NEPFENJAKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x47AEF20", Offset = "0x47AE120", VA = "0x1847AEF20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface NGGOIMEONMK<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	T JDIGBEFEDMD
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable DIEINHPDMIM(UnityEngine.Object FFACCLDEOCL, Action<T> OCCNMCIBNCK);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface ENFEHGOMEAF<T> : global::NGGOIMEONMK<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	new T JDIGBEFEDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class ELJJLKKDMAP<T> : global::ENFEHGOMEAF<T>, global::NGGOIMEONMK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class DDBOJGJKNKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public global::ELJJLKKDMAP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public global::PGCPBEHKNOP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public DDBOJGJKNKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2963520", Offset = "0x2962720", VA = "0x182963520")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static GameObject HNAMIPGIKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly List<global::PGCPBEHKNOP<UnityEngine.Object, Action<T>>> DHIPMMIKFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T FFNCFIKLNHB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T JDIGBEFEDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C80", Offset = "0x6B7E80", VA = "0x1806B8C80", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2965AA0", Offset = "0x2964CA0", VA = "0x182965AA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2965A40", Offset = "0x2964C40", VA = "0x182965A40")]
	private static bool HKAEEOLPJLF(T KICBFMPMNBH, T DLFOEJDCAKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2966260", Offset = "0x2965460", VA = "0x182966260")]
	public ELJJLKKDMAP(T DPMGEKIINIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x29658B0", Offset = "0x2964AB0", VA = "0x1829658B0", Slot = "6")]
	public IDisposable DIEINHPDMIM(UnityEngine.Object FFACCLDEOCL, Action<T> OCCNMCIBNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2965EA0", Offset = "0x29650A0", VA = "0x182965EA0")]
	private void PLJCPFDLJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class GGDKFGLBPHP : PNJLKLLEKAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly OEIKKDFMJIK JALGIFFCINM;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x47AB500", Offset = "0x47AA700", VA = "0x1847AB500")]
	[CFCNMFNLFMK]
	private static void PBHFFOPLLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF360", Offset = "0x6BE560", VA = "0x1806BF360")]
	[Preserve]
	internal GGDKFGLBPHP([CHFCOGGIEGO(null)] OEIKKDFMJIK JALGIFFCINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x47AB460", Offset = "0x47AA660", VA = "0x1847AB460", Slot = "4")]
	public IDisposable GNFCAFAPBHI(float DMPDIIEOOAL, Action<float> JNJKIKIBHIN, bool MJFDOACBKMH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct FCJJHKLHCOF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[ReadOnly]
	public float MLALNCGNKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[ReadOnly]
	public int KPCGNPKJLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private NativeArray<int> FJGNJOKMCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private NativeArray<int> LEMFKDPLKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private NativeArray<int> LFHDFOBFJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[ReadOnly]
	public NativeArray<AHPGOBAHDEO> JBGACNPGKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[ReadOnly]
	public NativeArray<float> GFKLDMBONAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[WriteOnly]
	public NativeArray<int> DPIPOHEENBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[WriteOnly]
	public NativeArray<int> JICHCOBKIHG;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x47AAFB0", Offset = "0x47AA1B0", VA = "0x1847AAFB0")]
	public static FCJJHKLHCOF MFDAKPCHIOJ(int JDDNPAGCGHN, float GHFDDCFNPPA, NativeArray<AHPGOBAHDEO> CBNJAADOOBD, NativeArray<float> LMJPBMONCJB, NativeArray<int> NFHILMGNGOP, NativeArray<int> MLLBCNJHAGM, NativeArray<int> GHDCHEJLBMM, NativeArray<int> LEMFKDPLKED, NativeArray<int> LFHDFOBFJEJ)
	{
		return default(FCJJHKLHCOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x47AAD90", Offset = "0x47A9F90", VA = "0x1847AAD90", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x47AAE70", Offset = "0x47AA070", VA = "0x1847AAE70")]
	private bool KACDOAHCCJM(int OHJLAHMBLMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x47AAEB0", Offset = "0x47AA0B0", VA = "0x1847AAEB0")]
	private void KCNKPNDAEJN(NativeArray<int> JNDCLEOKHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x47AB080", Offset = "0x47AA280", VA = "0x1847AB080")]
	private int NLMOIKGNAOO(int JPGIDPGFJOK, int MKIBMPJMEOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x47AAEE0", Offset = "0x47AA0E0", VA = "0x1847AAEE0")]
	private void LBNKJKABAMD(NativeArray<int> JNDCLEOKHOE, int BEHGKOKBGBK, int LNEIHONFENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x47AAB60", Offset = "0x47A9D60", VA = "0x1847AAB60")]
	private void BHDAINNDOEH(NativeArray<int> JNDCLEOKHOE, int LHFHPBBJKBB, int CMDBPLPCPAO, int KIJEHFIJKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class PPLPFJEACPA : OGDKEADGBOC, OEIKKDFMJIK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private DDPBHOCINKP[] BGKIAHFJFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private PBHBDGOKANB HACJEDMAGPG;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x47B3BC0", Offset = "0x47B2DC0", VA = "0x1847B3BC0")]
	[CFCNMFNLFMK]
	private static void PBHFFOPLLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x47B3C90", Offset = "0x47B2E90", VA = "0x1847B3C90")]
	[Preserve]
	public PPLPFJEACPA([CHFCOGGIEGO(null)] GKBOCCBICLN BKJEIMGJJLN, [CHFCOGGIEGO(null)] DGKBLMGNEEC DCELCMAEBMA, [CHFCOGGIEGO(null)] IGKBINABABO INBLONLCJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x47B35C0", Offset = "0x47B27C0", VA = "0x1847B35C0", Slot = "12")]
	public override NOIGHMHHCPP IMLMOGBMNLG(OECBFFHHMBC FFACCLDEOCL, IEnumerator<KIKOFGNMMEC> OBNELLPOHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x47B3730", Offset = "0x47B2930", VA = "0x1847B3730", Slot = "13")]
	public override void JNOECIFKPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x47B39F0", Offset = "0x47B2BF0", VA = "0x1847B39F0", Slot = "15")]
	public override void LBHKFIDCPBC(DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x47B3230", Offset = "0x47B2430", VA = "0x1847B3230", Slot = "14")]
	protected override void BLLHJLKIHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x47B36F0", Offset = "0x47B28F0", VA = "0x1847B36F0")]
	private DDPBHOCINKP IOPMCHKDLCI(DIFIILPGEFA.OPLOIIAFJDL ALJEFDPBPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x47B3310", Offset = "0x47B2510", VA = "0x1847B3310", Slot = "16")]
	internal override EFLLNFJGIIP CADHGGNFGDJ(IEnumerator<KIKOFGNMMEC> OBNELLPOHDJ, Behaviour FFACCLDEOCL, DFKFAODNLIK DBBNLJKOLFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x47B3430", Offset = "0x47B2630", VA = "0x1847B3430", Slot = "17")]
	internal override EKKHIGFOFOM FFGEMFKNCPP(DIFIILPGEFA.OPLOIIAFJDL BFLGIKFBFBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x47B34A0", Offset = "0x47B26A0", VA = "0x1847B34A0")]
	private void HPAABLDJEKG(DDPBHOCINKP HIBLKOOLDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x47B33C0", Offset = "0x47B25C0", VA = "0x1847B33C0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class OGDKEADGBOC : OEIKKDFMJIK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly GKBOCCBICLN BKJEIMGJJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	protected readonly DGKBLMGNEEC DCELCMAEBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly IGKBINABABO INBLONLCJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private EKKHIGFOFOM[] EDMANBAMLJH;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static OEIKKDFMJIK LHIDCGAAEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x47B01F0", Offset = "0x47AF3F0", VA = "0x1847B01F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool KHBMOEAFHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x58AFE0", Offset = "0x58A1E0", VA = "0x18058AFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public DIFIILPGEFA.OPLOIIAFJDL BGFEHFJMDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x58AED0", Offset = "0x58A0D0", VA = "0x18058AED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(DIFIILPGEFA.OPLOIIAFJDL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x58AEE0", Offset = "0x58A0E0", VA = "0x18058AEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public DGKBLMGNEEC LHAKOFJKEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x58CDF0", Offset = "0x58BFF0", VA = "0x18058CDF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x47AFA60", Offset = "0x47AEC60", VA = "0x1847AFA60")]
	public static NOIGHMHHCPP DLKFNMIOGNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x47B0540", Offset = "0x47AF740", VA = "0x1847B0540")]
	[Preserve]
	protected OGDKEADGBOC([CHFCOGGIEGO(null)] GKBOCCBICLN BKJEIMGJJLN, [CHFCOGGIEGO(null)] DGKBLMGNEEC DCELCMAEBMA, [CHFCOGGIEGO(null)] IGKBINABABO INBLONLCJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x47B0310", Offset = "0x47AF510", VA = "0x1847B0310", Slot = "6")]
	public NOIGHMHHCPP PMGIHLKHDII(IEnumerator<KIKOFGNMMEC> OBNELLPOHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x47B0320", Offset = "0x47AF520", VA = "0x1847B0320", Slot = "7")]
	public NOIGHMHHCPP PMGIHLKHDII(Behaviour FFACCLDEOCL, IEnumerator<KIKOFGNMMEC> OBNELLPOHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract NOIGHMHHCPP IMLMOGBMNLG(OECBFFHHMBC FFACCLDEOCL, IEnumerator<KIKOFGNMMEC> OBNELLPOHDJ);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x47AFDC0", Offset = "0x47AEFC0", VA = "0x1847AFDC0", Slot = "13")]
	public virtual void JNOECIFKPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x47AF820", Offset = "0x47AEA20", VA = "0x1847AF820", Slot = "9")]
	public void AANKFDHLMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x47AFA40", Offset = "0x47AEC40", VA = "0x1847AFA40", Slot = "14")]
	protected virtual void BLLHJLKIHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x47AFDA0", Offset = "0x47AEFA0", VA = "0x1847AFDA0")]
	private void JKIFHEHCDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x47B02F0", Offset = "0x47AF4F0", VA = "0x1847B02F0")]
	private void OIFCEFDOCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x47AFB00", Offset = "0x47AED00", VA = "0x1847AFB00")]
	private void DMGJJDONCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x47B02D0", Offset = "0x47AF4D0", VA = "0x1847B02D0")]
	private void OGDIHOCCFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x47AFFA0", Offset = "0x47AF1A0", VA = "0x1847AFFA0")]
	private void KMMILJLOLFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x47B02B0", Offset = "0x47AF4B0", VA = "0x1847B02B0")]
	private void MBKLIGLDHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x47AFFC0", Offset = "0x47AF1C0", VA = "0x1847AFFC0", Slot = "15")]
	public virtual void LBHKFIDCPBC(DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x47AF880", Offset = "0x47AEA80", VA = "0x1847AF880")]
	private void AKBEMCHDNCD(EKKHIGFOFOM HIBLKOOLDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E00", Offset = "0x7D6000", VA = "0x1807D6E00")]
	private EKKHIGFOFOM GDDAEELHKEL(DIFIILPGEFA.OPLOIIAFJDL ALJEFDPBPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract EFLLNFJGIIP CADHGGNFGDJ(IEnumerator<KIKOFGNMMEC> OBNELLPOHDJ, Behaviour FBECIMFMPPP, DFKFAODNLIK IIGAFFOAIDM);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract EKKHIGFOFOM FFGEMFKNCPP(DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x47AFB20", Offset = "0x47AED20", VA = "0x1847AFB20", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class EFLLNFJGIIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly DFKFAODNLIK DBBNLJKOLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly FEAKAOCOFKF FFACCLDEOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly bool MOHDGILDAJC;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEnumerator<KIKOFGNMMEC> PGHKEMBKNCP
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x58A490", Offset = "0x589690", VA = "0x18058A490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public KIKOFGNMMEC PPHEGKALOJP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x58A4A0", Offset = "0x5896A0", VA = "0x18058A4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool FOJIIIGICAA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x47A8C50", Offset = "0x47A7E50", VA = "0x1847A8C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool NDJKKNDOOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x840AD0", Offset = "0x83FCD0", VA = "0x180840AD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x26C0350", Offset = "0x26BF550", VA = "0x1826C0350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string NKAGADDFNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x58B010", Offset = "0x58A210", VA = "0x18058B010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x58B020", Offset = "0x58A220", VA = "0x18058B020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float GGGMJKPMFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x10CA970", Offset = "0x10C9B70", VA = "0x1810CA970")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x10CAC90", Offset = "0x10C9E90", VA = "0x1810CAC90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x47A8DF0", Offset = "0x47A7FF0", VA = "0x1847A8DF0")]
	public EFLLNFJGIIP(IEnumerator<KIKOFGNMMEC> BIIJFNDJGOF, FEAKAOCOFKF FFACCLDEOCL, DFKFAODNLIK DBBNLJKOLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x47A8970", Offset = "0x47A7B70", VA = "0x1847A8970")]
	public KIKOFGNMMEC DJGLFGIPOFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x47A8BE0", Offset = "0x47A7DE0", VA = "0x1847A8BE0")]
	public bool MJOJNEHMCOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x47A8CD0", Offset = "0x47A7ED0", VA = "0x1847A8CD0")]
	public void PEDGBALGNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x47A8D60", Offset = "0x47A7F60", VA = "0x1847A8D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x13B4B70", Offset = "0x13B3D70", VA = "0x1813B4B70")]
	[CompilerGenerated]
	private void MAMBGIMGKBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class DFKFAODNLIK : LCFEKFPCEDL, NOIGHMHHCPP, EIPPDOBKMFD, KJNBDKOEMOC, IEnumerator, KIKOFGNMMEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private DIFIILPGEFA.OPLOIIAFJDL ILKANPKMFDF;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private DIFIILPGEFA.OPLOIIAFJDL JOLJDLLCPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5AF180", Offset = "0x5AE380", VA = "0x1805AF180", Slot = "23")]
		get
		{
			return default(DIFIILPGEFA.OPLOIIAFJDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DIFIILPGEFA.OPLOIIAFJDL CONEGDLNICA
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x77A5C0", Offset = "0x7797C0", VA = "0x18077A5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private float GMFIDPDEICL
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1138A10", Offset = "0x1137C10", VA = "0x181138A10", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x47A7DE0", Offset = "0x47A6FE0", VA = "0x1847A7DE0", Slot = "24")]
	private bool FPEHBNNBCMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x47A7DD0", Offset = "0x47A6FD0", VA = "0x1847A7DD0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x47A7E00", Offset = "0x47A7000", VA = "0x1847A7E00")]
	public DFKFAODNLIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal enum KHOCMOBHBLN : byte
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
internal sealed class EKKHIGFOFOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum MHDGIBEOJNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct BNPKAOEIKGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public DIFIILPGEFA.OPLOIIAFJDL CKCDJDFJNFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public MHDGIBEOJNC PFLLMIFNCMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<EFLLNFJGIIP> EHENCBLJONB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly MHDGIBEOJNC[] CEFJBGIJPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly DIFIILPGEFA.OPLOIIAFJDL EDFOIGNIMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool CJPNDJIKHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EFLLNFJGIIP[] OALBCHEFNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly List<EFLLNFJGIIP> DCFOKFGMILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly Stack<int> IMHHDAAKLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly List<EFLLNFJGIIP> AJDBMKCMLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly Stack<int> ICOLKKAMCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly PBHBDGOKANB JMBPPIMMODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private bool IABCGHGNHKB;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public BNPKAOEIKGG[,] KBLOHINJKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5DD130", Offset = "0x5DC330", VA = "0x1805DD130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x47AA4B0", Offset = "0x47A96B0", VA = "0x1847AA4B0")]
	public EKKHIGFOFOM(DIFIILPGEFA.OPLOIIAFJDL BFLGIKFBFBM, PBHBDGOKANB JMBPPIMMODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x47A9B60", Offset = "0x47A8D60", VA = "0x1847A9B60")]
	public void FJEMBKCAAMA(EFLLNFJGIIP BIIJFNDJGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x47AA150", Offset = "0x47A9350", VA = "0x1847AA150")]
	public void MODBCMJLGPA(IList<EFLLNFJGIIP> BOMNAKAGNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x47A98E0", Offset = "0x47A8AE0", VA = "0x1847A98E0")]
	public void EDKPHMCILIG(IList<EFLLNFJGIIP> BOMNAKAGNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x47A96B0", Offset = "0x47A88B0", VA = "0x1847A96B0")]
	private void DAAFEJPDLPK(EFLLNFJGIIP BIIJFNDJGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x47A9C80", Offset = "0x47A8E80", VA = "0x1847A9C80")]
	private void HCKABABACMD(IList<EFLLNFJGIIP> BOMNAKAGNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x47A9FD0", Offset = "0x47A91D0", VA = "0x1847A9FD0")]
	private KHOCMOBHBLN MFLDKHLFPIE(EFLLNFJGIIP BIIJFNDJGOF)
	{
		return default(KHOCMOBHBLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x47A9560", Offset = "0x47A8760", VA = "0x1847A9560")]
	public void BLLHJLKIHHA(float GHFDDCFNPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x47A9240", Offset = "0x47A8440", VA = "0x1847A9240")]
	public void AANKFDHLMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x47A9DF0", Offset = "0x47A8FF0", VA = "0x1847A9DF0")]
	private void KNFDJGOECDA(List<EFLLNFJGIIP> BOMNAKAGNOK, Stack<int> BOKLNKPHHLO, bool IHBADIALNEG, float FHPCKBBHIGM = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x47A97A0", Offset = "0x47A89A0", VA = "0x1847A97A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x47A9440", Offset = "0x47A8640", VA = "0x1847A9440")]
	private void BLHLANFIOCH(List<EFLLNFJGIIP> BOMNAKAGNOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class ABFGMDBCOJF : PBHBDGOKANB
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "4")]
	public void DOLEKLBFKEC(string KFCJDHCECCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
	public void OCNNBKHIANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public ABFGMDBCOJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class CKLKHLKAPFI : FEAKAOCOFKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly Behaviour FBECIMFMPPP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string NKAGADDFNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x47A33A0", Offset = "0x47A25A0", VA = "0x1847A33A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JPAIKEIPKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x47A3320", Offset = "0x47A2520", VA = "0x1847A3320", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KIAJKGJMBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x47A3380", Offset = "0x47A2580", VA = "0x1847A3380", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6BF360", Offset = "0x6BE560", VA = "0x1806BF360")]
	public CKLKHLKAPFI(Behaviour FBECIMFMPPP)
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

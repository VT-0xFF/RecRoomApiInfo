using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.Core;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EFAGFFHCEBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BMLBBOJCOFN HJCNPLEINOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	BMLBBOJCOFN PHFDIHIMBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BMLBBOJCOFN LGHMPDCLCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KAOLNFLEDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MKEJLDAEDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private delegate List<PlayerLoopSystem> JBPELOIFNNO(List<PlayerLoopSystem> EJPHNMBEEKI, int FGDECJJKPEB);

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct GBLAFJMBBMC
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct PBMKHLIMBIE
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static BMLBBOJCOFN KADOLDCAOID;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x3962480", Offset = "0x3961480", VA = "0x183962480")]
				public static PlayerLoopSystem HBEEGDPGCIC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct KJINOMCFCON
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static BMLBBOJCOFN JHILBHNHPMM;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x39600E0", Offset = "0x395F0E0", VA = "0x1839600E0")]
				public static PlayerLoopSystem HBEEGDPGCIC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct GMALHBFHILM
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static BMLBBOJCOFN DFBJDIHLOBI;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x395DDE0", Offset = "0x395CDE0", VA = "0x18395DDE0")]
				public static PlayerLoopSystem HBEEGDPGCIC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			internal struct JCBNKBAMFLI
			{
				[Cpp2IlInjected.Token(Token = "0x200000D")]
				[CompilerGenerated]
				private sealed class FLLGFCOOJDK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public OBCMAKPILAJ.JKKINHCMAPP key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
					public FLLGFCOOJDK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x395D8A0", Offset = "0x395C8A0", VA = "0x18395D8A0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable NDIIDNKGFNE;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x395EC00", Offset = "0x395DC00", VA = "0x18395EC00")]
				public static PlayerLoopSystem KFPDGKCJNOB(OBCMAKPILAJ.JKKINHCMAPP PFPLGCLHCBM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			internal struct HDHGCINLAMD
			{
				[Cpp2IlInjected.Token(Token = "0x200000F")]
				[CompilerGenerated]
				private sealed class KGKGPDCNCFF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000D")]
					public OBCMAKPILAJ.JKKINHCMAPP key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
					public KGKGPDCNCFF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x3960020", Offset = "0x395F020", VA = "0x183960020")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x395E3C0", Offset = "0x395D3C0", VA = "0x18395E3C0")]
				public static PlayerLoopSystem KFPDGKCJNOB(OBCMAKPILAJ.JKKINHCMAPP PFPLGCLHCBM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class DFHDBMBKIIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
			public DFHDBMBKIIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3959620", Offset = "0x3958620", VA = "0x183959620")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool NCMBLNEJOAM;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool HLOLOHJIHCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3958BE0", Offset = "0x3957BE0", VA = "0x183958BE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3958BA0", Offset = "0x3957BA0", VA = "0x183958BA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3957C50", Offset = "0x3956C50", VA = "0x183957C50")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3958F90", Offset = "0x3957F90", VA = "0x183958F90")]
		private static void NJLBIEMJOLK(OBCMAKPILAJ.JKKINHCMAPP PFPLGCLHCBM, ref PlayerLoopSystem GBCBADFKFAG, Type HELBIFCGONB, Type AKDINHBFODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3958C20", Offset = "0x3957C20", VA = "0x183958C20")]
		private static void LGCMGJDMFNA(ref PlayerLoopSystem GBCBADFKFAG, Type HELBIFCGONB, Type AKDINHBFODB, JBPELOIFNNO CMPJELPOLFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3958AA0", Offset = "0x3957AA0", VA = "0x183958AA0")]
		private static void IKHAJNIOLDB(ref PlayerLoopSystem GBCBADFKFAG, Type HELBIFCGONB, Type AKDINHBFODB, PlayerLoopSystem? BMMBHLMMHOJ, PlayerLoopSystem? OKAKIKHFEKA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OBCMAKPILAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum JKKINHCMAPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class CENJLPKJIKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly JKKINHCMAPP JEDHJCKPHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly HIGBBJAGAOF DGEBPGKAMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long ACOGDEOJPJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long JMIPPNNHHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public long HCOEEOCMGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int JNOKONMFBJK;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3956720", Offset = "0x3955720", VA = "0x183956720")]
		public CENJLPKJIKJ(JKKINHCMAPP KHEABCHLLDL, int HFBLNBDNCIH = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3956460", Offset = "0x3955460", VA = "0x183956460")]
		public void BKGCJOOELMA(int GHKFJAICOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x39564E0", Offset = "0x39554E0", VA = "0x1839564E0")]
		public void JBLCIFKALIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3956480", Offset = "0x3955480", VA = "0x183956480")]
		public void FOBOJKEPLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3956550", Offset = "0x3955550", VA = "0x183956550")]
		public void OKEPENPPOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x39563C0", Offset = "0x39553C0", VA = "0x1839563C0")]
		public double AIGHFKOHJMO(int KBHOOHKGOEM)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int LCMJEACOAHB = 90;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static JKKINHCMAPP[] NAHCJHEPLFJ;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static CENJLPKJIKJ[] JJCMAPEFOJF;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3961B40", Offset = "0x3960B40", VA = "0x183961B40")]
	public static CENJLPKJIKJ BNNIBIFGNLF(JKKINHCMAPP PFPLGCLHCBM, int HFBLNBDNCIH = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3961CD0", Offset = "0x3960CD0", VA = "0x183961CD0")]
	public static CENJLPKJIKJ COJECFCKBKI(JKKINHCMAPP PFPLGCLHCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3961A90", Offset = "0x3960A90", VA = "0x183961A90")]
	public static void AMLOFLOJCOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LNBLKJFNAFK : OMCINIMOFJN
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class PAIIGILAPFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public LNBLKJFNAFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
		public PAIIGILAPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3955AC0", Offset = "0x3954AC0", VA = "0x183955AC0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BEPFOBKFNNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public LNBLKJFNAFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
		public BEPFOBKFNNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3955AC0", Offset = "0x3954AC0", VA = "0x183955AC0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float PFMFNOFCCEJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x395BA90", Offset = "0x395AA90", VA = "0x18395BA90")]
	public LNBLKJFNAFK(Behaviour IJPNDHOBKKG, float PFMFNOFCCEJ, [Optional] Action OPIHOJCIKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3960E80", Offset = "0x395FE80", VA = "0x183960E80", Slot = "9")]
	protected override bool ODMLMFJBEOL(Action MMBIEGLGGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3960DB0", Offset = "0x395FDB0", VA = "0x183960DB0", Slot = "10")]
	protected override bool CFGBFPNEOHD(Action MMBIEGLGGJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GINEJPIBEFE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool HBAJAOJEEON
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action JNAHIPKMOKD;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JNNCPDHLIAC(bool HGCIFBMOBMJ = false);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JNNCPDHLIAC(Action MMBIEGLGGJN, bool HGCIFBMOBMJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class OMCINIMOFJN : GINEJPIBEFE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MIGHDFEFNLG : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public MIGHDFEFNLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3961110", Offset = "0x3960110", VA = "0x183961110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x39611B0", Offset = "0x39601B0", VA = "0x1839611B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Behaviour IJPNDHOBKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Action OPIHOJCIKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private JAEINMCBLPH DDEPGCBBJCJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HBAJAOJEEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82F120", Offset = "0x82E120", VA = "0x18082F120", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JNAHIPKMOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3962200", Offset = "0x3961200", VA = "0x183962200", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x39622A0", Offset = "0x39612A0", VA = "0x1839622A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x24642D0", Offset = "0x24632D0", VA = "0x1824642D0")]
	protected OMCINIMOFJN(Behaviour IJPNDHOBKKG, [Optional] Action OPIHOJCIKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3962150", Offset = "0x3961150", VA = "0x183962150", Slot = "7")]
	public bool JNNCPDHLIAC(bool HGCIFBMOBMJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x39621B0", Offset = "0x39611B0", VA = "0x1839621B0", Slot = "8")]
	public bool JNNCPDHLIAC(Action MMBIEGLGGJN, bool HGCIFBMOBMJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool ODMLMFJBEOL(Action MMBIEGLGGJN);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool CFGBFPNEOHD(Action MMBIEGLGGJN);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x39620C0", Offset = "0x39610C0", VA = "0x1839620C0")]
	protected void GHBGPOKAKOO(Action MMBIEGLGGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3961EF0", Offset = "0x3960EF0", VA = "0x183961EF0")]
	protected BNIMEGFNNGI FCGMBFFJCJF(float FAFDDGDDBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x39620E0", Offset = "0x39610E0", VA = "0x1839620E0")]
	private void JJKPDHDALGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3961E90", Offset = "0x3960E90", VA = "0x183961E90")]
	[IteratorStateMachine(typeof(MIGHDFEFNLG))]
	private static IEnumerator<DNKAKMFKLPM> DKNBMBIPDBI(float FAFDDGDDBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3961E70", Offset = "0x3960E70", VA = "0x183961E70")]
	[CompilerGenerated]
	private void CADOLJNMDLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CHFGFAKEOHC : OMCINIMOFJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly float FCNEIPDCLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly int NOAMEIPKKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly float EFGGHDMCEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly float[] HBDHCBGFJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int FDANBFGOBPK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OHLDPKEDMND NKDDDPKLFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4227E0", Offset = "0x4217E0", VA = "0x1804227E0")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4DF530", Offset = "0x4DE530", VA = "0x1804DF530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3956AB0", Offset = "0x3955AB0", VA = "0x183956AB0")]
	public CHFGFAKEOHC(Behaviour IJPNDHOBKKG, float DMJLEIBBLMF, int NOAMEIPKKBL, [Optional] Action OPIHOJCIKFJ, float EFGGHDMCEOK = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x446F50", Offset = "0x445F50", VA = "0x180446F50", Slot = "9")]
	protected override bool ODMLMFJBEOL(Action MMBIEGLGGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3956800", Offset = "0x3955800", VA = "0x183956800", Slot = "10")]
	protected override bool CFGBFPNEOHD(Action MMBIEGLGGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3956A20", Offset = "0x3955A20", VA = "0x183956A20")]
	private void GONLGGOBMKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EGJFNLCIFCC : OMCINIMOFJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly float PFMFNOFCCEJ;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x395BA90", Offset = "0x395AA90", VA = "0x18395BA90")]
	public EGJFNLCIFCC(Behaviour IJPNDHOBKKG, float PFMFNOFCCEJ, [Optional] Action OPIHOJCIKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x446F50", Offset = "0x445F50", VA = "0x180446F50", Slot = "9")]
	protected override bool ODMLMFJBEOL(Action MMBIEGLGGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x395BA50", Offset = "0x395AA50", VA = "0x18395BA50", Slot = "10")]
	protected override bool CFGBFPNEOHD(Action MMBIEGLGGJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface DGIFJJJPAAJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int JLLAHJNKFLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DNHDNMLNECC : JAEINMCBLPH, BNIMEGFNNGI, IEnumerator, DNKAKMFKLPM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IDLMGMHIFKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly IDLMGMHIFKM DIDGHMMNCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Action NJCOPAMOEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private bool PCONJOHGKBL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x52A960", Offset = "0x529960", VA = "0x18052A960")]
	public IDLMGMHIFKM(Action NJCOPAMOEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x395E8F0", Offset = "0x395D8F0", VA = "0x18395E8F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HEFNFHFHMOP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	T BFJAJBGCPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable BOLDEGLEFKK(Action<T> NJMEOJODAJI);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable BOLDEGLEFKK(UnityEngine.Object IJPNDHOBKKG, Action<T> NJMEOJODAJI);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NKEBGPNBOHA<T> : global::HEFNFHFHMOP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	new T BFJAJBGCPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ANHCCFIFNOB<T> : global::NKEBGPNBOHA<T>, global::HEFNFHFHMOP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HNMAJCJHKNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public global::ANHCCFIFNOB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public global::CIDFHFDHJHI<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
		public HNMAJCJHKNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2792A50", Offset = "0x2791A50", VA = "0x182792A50")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static GameObject KKIMNFLDKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<global::CIDFHFDHJHI<UnityEngine.Object, Action<T>>> KAADJMKNECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T GFIBKOHEDND;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private static UnityEngine.Object EKGOOKHHCPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x278AFF0", Offset = "0x2789FF0", VA = "0x18278AFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T BFJAJBGCPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x52A930", Offset = "0x529930", VA = "0x18052A930", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x278B300", Offset = "0x278A300", VA = "0x18278B300", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x278B230", Offset = "0x278A230", VA = "0x18278B230")]
	private static bool IIKNBEOPEJL(T AIGELDPBMKD, T FLPHBPIKJBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x278B430", Offset = "0x278A430", VA = "0x18278B430")]
	public ANHCCFIFNOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x278B460", Offset = "0x278A460", VA = "0x18278B460")]
	public ANHCCFIFNOB(T BIECACGJPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x278B380", Offset = "0x278A380", VA = "0x18278B380")]
	public void NFMFDGFOJLN(T DMAHAENCAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x278A4B0", Offset = "0x27894B0", VA = "0x18278A4B0", Slot = "7")]
	public IDisposable BOLDEGLEFKK(Action<T> NJMEOJODAJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x278A660", Offset = "0x2789660", VA = "0x18278A660", Slot = "8")]
	public IDisposable BOLDEGLEFKK(UnityEngine.Object IJPNDHOBKKG, Action<T> NJMEOJODAJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x278AAC0", Offset = "0x2789AC0", VA = "0x18278AAC0")]
	private void FBPJFCIGNCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class DAOBCCPCIBA
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class GBFCBKEJPPN : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Scheduler.IIHAJDBNDMM queue;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public GBFCBKEJPPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x395DB00", Offset = "0x395CB00", VA = "0x18395DB00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x395DBA0", Offset = "0x395CBA0", VA = "0x18395DBA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class FOPDPCBHCMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public BNIMEGFNNGI promise;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
		public FOPDPCBHCMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x395DA70", Offset = "0x395CA70", VA = "0x18395DA70")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class ONHECLHKNIE : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public ONHECLHKNIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3962340", Offset = "0x3961340", VA = "0x183962340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3962430", Offset = "0x3961430", VA = "0x183962430", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly DNKAKMFKLPM DEBBEEFADOE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly DNKAKMFKLPM MDGHCFEIKBI;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly DNKAKMFKLPM PHKALGLACCB;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly DNKAKMFKLPM HHGPOLEBJAL;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly DNKAKMFKLPM COFBIJNNIAK;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3959420", Offset = "0x3958420", VA = "0x183959420")]
	public static DNKAKMFKLPM NGHKHJLIJEG(float AJBGKIGGCBF, Scheduler.IIHAJDBNDMM MDOJIHKCBBH = Scheduler.IIHAJDBNDMM.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x39591F0", Offset = "0x39581F0", VA = "0x1839591F0")]
	public static DNKAKMFKLPM BIJMNNPKEAI(float AJBGKIGGCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x39592B0", Offset = "0x39582B0", VA = "0x1839592B0")]
	[IteratorStateMachine(typeof(GBFCBKEJPPN))]
	public static IEnumerator<DNKAKMFKLPM> CODBDNDBCHL(float AJBGKIGGCBF, Scheduler.IIHAJDBNDMM MDOJIHKCBBH = Scheduler.IIHAJDBNDMM.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3959250", Offset = "0x3958250", VA = "0x183959250")]
	public static DNKAKMFKLPM BOLPHHEFFHL(Func<bool> MCOGEAFCIDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3959320", Offset = "0x3958320", VA = "0x183959320")]
	public static DNKAKMFKLPM EEFOBNKNLLN(BNIMEGFNNGI EPPKDKKODGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x39593D0", Offset = "0x39583D0", VA = "0x1839593D0")]
	[IteratorStateMachine(typeof(ONHECLHKNIE))]
	public static IEnumerator<DNKAKMFKLPM> LICAMGFDFDM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface DNKAKMFKLPM
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Scheduler.IIHAJDBNDMM BIDGOELDNIC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float IFEMBBBMOGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ILHPJGFMEPN();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class JCDKJLFNKGC : DNKAKMFKLPM
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class FMBPCBMFGPG : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Scheduler.IIHAJDBNDMM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private JCDKJLFNKGC <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public FMBPCBMFGPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x395D950", Offset = "0x395C950", VA = "0x18395D950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x395DA20", Offset = "0x395CA20", VA = "0x18395DA20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class CCMCFNPOKBL : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Scheduler.IIHAJDBNDMM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private JCDKJLFNKGC <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public CCMCFNPOKBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x39561B0", Offset = "0x39551B0", VA = "0x1839561B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x39562A0", Offset = "0x39552A0", VA = "0x1839562A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Scheduler.IIHAJDBNDMM BIDGOELDNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x41F010", Offset = "0x41E010", VA = "0x18041F010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.IIHAJDBNDMM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x446F60", Offset = "0x445F60", VA = "0x180446F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float IFEMBBBMOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5624C0", Offset = "0x5614C0", VA = "0x1805624C0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
	public JCDKJLFNKGC(Scheduler.IIHAJDBNDMM MDOJIHKCBBH = Scheduler.IIHAJDBNDMM.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x447060", Offset = "0x446060", VA = "0x180447060", Slot = "5")]
	public bool ILHPJGFMEPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x395F230", Offset = "0x395E230", VA = "0x18395F230")]
	public static DNHDNMLNECC EBBFAFKJLOI(Action BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x395F030", Offset = "0x395E030", VA = "0x18395F030")]
	public static DNHDNMLNECC EBBFAFKJLOI(Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x395F120", Offset = "0x395E120", VA = "0x18395F120")]
	public static DNHDNMLNECC EBBFAFKJLOI(Behaviour IJPNDHOBKKG, Action BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x395EF20", Offset = "0x395DF20", VA = "0x18395EF20")]
	public static DNHDNMLNECC EBBFAFKJLOI(Behaviour IJPNDHOBKKG, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x395EE10", Offset = "0x395DE10", VA = "0x18395EE10")]
	public static DNHDNMLNECC DAODBOIGFLG(EFAGFFHCEBJ IJPNDHOBKKG, Action BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x395ED00", Offset = "0x395DD00", VA = "0x18395ED00")]
	public static DNHDNMLNECC DAODBOIGFLG(EFAGFFHCEBJ IJPNDHOBKKG, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x395F320", Offset = "0x395E320", VA = "0x18395F320")]
	[IteratorStateMachine(typeof(FMBPCBMFGPG))]
	private static IEnumerator<DNKAKMFKLPM> KOAIMMOILJP(Scheduler.IIHAJDBNDMM MDOJIHKCBBH, Action BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x395F390", Offset = "0x395E390", VA = "0x18395F390")]
	[IteratorStateMachine(typeof(CCMCFNPOKBL))]
	private static IEnumerator<DNKAKMFKLPM> KOAIMMOILJP(Scheduler.IIHAJDBNDMM MDOJIHKCBBH, Action<float> BADELGGDOHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HCLJAHHKAAG : DNKAKMFKLPM
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GDGMEHEEDGH : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Scheduler.IIHAJDBNDMM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private HCLJAHHKAAG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public GDGMEHEEDGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x395DBF0", Offset = "0x395CBF0", VA = "0x18395DBF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x395DD90", Offset = "0x395CD90", VA = "0x18395DD90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly float BJHGFBCCELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private int MFEHGKGLLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly float NIGJNHIDLNC;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float PIGOOKEHPEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6920A0", Offset = "0x6910A0", VA = "0x1806920A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6920D0", Offset = "0x6910D0", VA = "0x1806920D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Scheduler.IIHAJDBNDMM BIDGOELDNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x446D80", Offset = "0x445D80", VA = "0x180446D80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.IIHAJDBNDMM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BE80", VA = "0x18051CE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float IFEMBBBMOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A2E30", Offset = "0x7A1E30", VA = "0x1807A2E30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x80B8A0", Offset = "0x80A8A0", VA = "0x18080B8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float EPIHFOJNMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4E5F10", Offset = "0x4E4F10", VA = "0x1804E5F10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4E63F0", Offset = "0x4E53F0", VA = "0x1804E63F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x395E2E0", Offset = "0x395D2E0", VA = "0x18395E2E0")]
	public HCLJAHHKAAG(float LCLIOMJDPNM, Scheduler.IIHAJDBNDMM MDOJIHKCBBH = Scheduler.IIHAJDBNDMM.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x395E0F0", Offset = "0x395D0F0", VA = "0x18395E0F0", Slot = "5")]
	public bool ILHPJGFMEPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x395E250", Offset = "0x395D250", VA = "0x18395E250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x395E040", Offset = "0x395D040", VA = "0x18395E040")]
	public static DNHDNMLNECC EBBFAFKJLOI(float GBOHKAHJCCP, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x395DF80", Offset = "0x395CF80", VA = "0x18395DF80")]
	public static DNHDNMLNECC EBBFAFKJLOI(MonoBehaviour PLBJHMBJMLJ, float GBOHKAHJCCP, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x395E190", Offset = "0x395D190", VA = "0x18395E190")]
	public static DNHDNMLNECC LAOINKKBFLJ(EFAGFFHCEBJ IJPNDHOBKKG, float GBOHKAHJCCP, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x395E110", Offset = "0x395D110", VA = "0x18395E110")]
	[IteratorStateMachine(typeof(GDGMEHEEDGH))]
	private static IEnumerator<DNKAKMFKLPM> KOAIMMOILJP(float GBOHKAHJCCP, Scheduler.IIHAJDBNDMM MDOJIHKCBBH, Action<float> BADELGGDOHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MOMAMELJPFI : DNKAKMFKLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Func<bool> MCOGEAFCIDE;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Scheduler.IIHAJDBNDMM BIDGOELDNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4231F0", Offset = "0x4221F0", VA = "0x1804231F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.IIHAJDBNDMM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E89A0", Offset = "0x5E79A0", VA = "0x1805E89A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public float IFEMBBBMOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6920A0", Offset = "0x6910A0", VA = "0x1806920A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6920D0", Offset = "0x6910D0", VA = "0x1806920D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3961250", Offset = "0x3960250", VA = "0x183961250")]
	public MOMAMELJPFI(Func<bool> MCOGEAFCIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3961280", Offset = "0x3960280", VA = "0x183961280")]
	public MOMAMELJPFI(Scheduler.IIHAJDBNDMM PPMHEPOAILC, Func<bool> MCOGEAFCIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3961200", Offset = "0x3960200", VA = "0x183961200", Slot = "5")]
	public bool ILHPJGFMEPN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class KOEOCGIOINP
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class IBFMFKIFEHP : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Scheduler.IIHAJDBNDMM queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public IBFMFKIFEHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x395E800", Offset = "0x395D800", VA = "0x18395E800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x395E8A0", Offset = "0x395D8A0", VA = "0x18395E8A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3960280", Offset = "0x395F280", VA = "0x183960280")]
	[IteratorStateMachine(typeof(IBFMFKIFEHP))]
	private static IEnumerator<DNKAKMFKLPM> LBPBNKBLECM(Scheduler.IIHAJDBNDMM PPMHEPOAILC, Func<bool> MCOGEAFCIDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x39602F0", Offset = "0x395F2F0", VA = "0x1839602F0")]
	public static DNHDNMLNECC MNCDBMICEGE(this MonoBehaviour PLBJHMBJMLJ, Func<bool> MCOGEAFCIDE, Scheduler.IIHAJDBNDMM PPMHEPOAILC = Scheduler.IIHAJDBNDMM.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class ECDOKHKKAEB : DNKAKMFKLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly float CFEMGEGANON;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Scheduler.IIHAJDBNDMM BIDGOELDNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x469A00", Offset = "0x468A00", VA = "0x180469A00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.IIHAJDBNDMM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x53D240", Offset = "0x53C240", VA = "0x18053D240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float IFEMBBBMOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x692090", Offset = "0x691090", VA = "0x180692090", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6920C0", Offset = "0x6910C0", VA = "0x1806920C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3959810", Offset = "0x3958810", VA = "0x183959810")]
	public ECDOKHKKAEB(float AJBGKIGGCBF, Scheduler.IIHAJDBNDMM MDOJIHKCBBH = Scheduler.IIHAJDBNDMM.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3959780", Offset = "0x3958780", VA = "0x183959780", Slot = "5")]
	public bool ILHPJGFMEPN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class HOHPKCGHNIG : DNKAKMFKLPM
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private const float DHJMPPCPENO = 0.1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly float BAAANHIIGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private float GAOBNDDOOCO;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Scheduler.IIHAJDBNDMM BIDGOELDNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x42F1F0", Offset = "0x42E1F0", VA = "0x18042F1F0", Slot = "4")]
		get
		{
			return default(Scheduler.IIHAJDBNDMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float IFEMBBBMOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5624C0", Offset = "0x5614C0", VA = "0x1805624C0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x10B2590", Offset = "0x10B1590", VA = "0x1810B2590")]
	public HOHPKCGHNIG(float AJBGKIGGCBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x395E760", Offset = "0x395D760", VA = "0x18395E760", Slot = "5")]
	public bool ILHPJGFMEPN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class CPCNIFNBMMN
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class COMFJAJFLGO : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Scheduler.IIHAJDBNDMM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public COMFJAJFLGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3956FD0", Offset = "0x3955FD0", VA = "0x183956FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3957080", Offset = "0x3956080", VA = "0x183957080", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class BCFCAEOJJKG : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Scheduler.IIHAJDBNDMM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private DNKAKMFKLPM <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public BCFCAEOJJKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3954DC0", Offset = "0x3953DC0", VA = "0x183954DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3954E80", Offset = "0x3953E80", VA = "0x183954E80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x39570D0", Offset = "0x39560D0", VA = "0x1839570D0")]
	[IteratorStateMachine(typeof(COMFJAJFLGO))]
	private static IEnumerator<DNKAKMFKLPM> AODDOBBCOMJ(float AJBGKIGGCBF, Scheduler.IIHAJDBNDMM MDOJIHKCBBH, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3957280", Offset = "0x3956280", VA = "0x183957280")]
	[IteratorStateMachine(typeof(BCFCAEOJJKG))]
	private static IEnumerator<DNKAKMFKLPM> EDKBKBECBKB(float AJBGKIGGCBF, Scheduler.IIHAJDBNDMM MDOJIHKCBBH, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x39577A0", Offset = "0x39567A0", VA = "0x1839577A0")]
	public static IDisposable PGAOBGAGGNC(this MonoBehaviour PLBJHMBJMLJ, float AJBGKIGGCBF, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3957530", Offset = "0x3956530", VA = "0x183957530")]
	public static DNHDNMLNECC HKMFMPBAFOM(this MonoBehaviour PLBJHMBJMLJ, float AJBGKIGGCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x39578E0", Offset = "0x39568E0", VA = "0x1839578E0")]
	public static DNHDNMLNECC PGAOBGAGGNC(this MonoBehaviour PLBJHMBJMLJ, float AJBGKIGGCBF, Scheduler.IIHAJDBNDMM MDOJIHKCBBH, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3957410", Offset = "0x3956410", VA = "0x183957410")]
	public static DNHDNMLNECC GCDEGNIBIIB(this MonoBehaviour PLBJHMBJMLJ, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3957160", Offset = "0x3956160", VA = "0x183957160")]
	public static DNHDNMLNECC BPBHNNCOEPA(this MonoBehaviour PLBJHMBJMLJ, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3957150", Offset = "0x3956150", VA = "0x183957150")]
	public static DNHDNMLNECC BKIHDJOAMNC(this MonoBehaviour PLBJHMBJMLJ, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3957790", Offset = "0x3956790", VA = "0x183957790")]
	public static DNHDNMLNECC KHPIKEBNMBD(this MonoBehaviour PLBJHMBJMLJ, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3957780", Offset = "0x3956780", VA = "0x183957780")]
	public static DNHDNMLNECC KGLCECCIEOA(this MonoBehaviour PLBJHMBJMLJ, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3957170", Offset = "0x3956170", VA = "0x183957170")]
	private static DNHDNMLNECC CPCOBCGNEIF(MonoBehaviour PLBJHMBJMLJ, Scheduler.IIHAJDBNDMM PPMHEPOAILC, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3957300", Offset = "0x3956300", VA = "0x183957300")]
	public static DNHDNMLNECC FFFLHDAMPLJ(this MonoBehaviour PLBJHMBJMLJ, float NIDOOLMPAIM, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3957B40", Offset = "0x3956B40", VA = "0x183957B40")]
	public static DNHDNMLNECC PLDACFGDEBJ(this MonoBehaviour PLBJHMBJMLJ, float NIDOOLMPAIM, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3957670", Offset = "0x3956670", VA = "0x183957670")]
	public static DNHDNMLNECC IKBPEDJMJBC(this MonoBehaviour PLBJHMBJMLJ, float NIDOOLMPAIM, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3957420", Offset = "0x3956420", VA = "0x183957420")]
	public static DNHDNMLNECC HGHMCAEHAPM(this MonoBehaviour PLBJHMBJMLJ, float NIDOOLMPAIM, Action PJCBMMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3957A30", Offset = "0x3956A30", VA = "0x183957A30")]
	public static DNHDNMLNECC PKDMKLGHHFB(this MonoBehaviour PLBJHMBJMLJ, float NIDOOLMPAIM, Action PJCBMMIBOAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class BDKBIECNDGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class KBEGMEPJIFK : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public KBEGMEPJIFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x395F400", Offset = "0x395E400", VA = "0x18395F400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x395F4B0", Offset = "0x395E4B0", VA = "0x18395F4B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private DNHDNMLNECC LKHLAOCEEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private MonoBehaviour PLBJHMBJMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private Action BADELGGDOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Action<float> AEDFKHIHIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Scheduler.IIHAJDBNDMM PPMHEPOAILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private float MBNNNEFFMHD;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3955650", Offset = "0x3954650", VA = "0x183955650")]
	public BDKBIECNDGH(MonoBehaviour PLBJHMBJMLJ, Action BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3955930", Offset = "0x3954930", VA = "0x183955930")]
	public BDKBIECNDGH(MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x39557E0", Offset = "0x39547E0", VA = "0x1839557E0")]
	public BDKBIECNDGH(MonoBehaviour PLBJHMBJMLJ, float GBOHKAHJCCP, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x39550A0", Offset = "0x39540A0", VA = "0x1839550A0")]
	private void EBBFAFKJLOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3954ED0", Offset = "0x3953ED0", VA = "0x183954ED0")]
	private void CNJIJEMOJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3955320", Offset = "0x3954320", VA = "0x183955320")]
	private void IDOOLFMCHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3955450", Offset = "0x3954450", VA = "0x183955450")]
	private void JNFOOGDFKJM(string FODJEJOHFJM, Action CIIMJEMDEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x39555F0", Offset = "0x39545F0", VA = "0x1839555F0")]
	[IteratorStateMachine(typeof(KBEGMEPJIFK))]
	private IEnumerator<DNKAKMFKLPM> MOADECGAAIM(Action CIIMJEMDEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3955050", Offset = "0x3954050", VA = "0x183955050", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x39552A0", Offset = "0x39542A0", VA = "0x1839552A0")]
	[CompilerGenerated]
	private void ICKHPKAGFGK(string OGNEAGPEDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3955570", Offset = "0x3954570", VA = "0x183955570")]
	[CompilerGenerated]
	private void KIEDPAHPCJB(string OGNEAGPEDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3955220", Offset = "0x3954220", VA = "0x183955220")]
	[CompilerGenerated]
	private void FABFDONLGIO(string OGNEAGPEDCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class FCELPHMFALE
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x395BEC0", Offset = "0x395AEC0", VA = "0x18395BEC0")]
	public static IDisposable EBBFAFKJLOI(this MonoBehaviour PLBJHMBJMLJ, Action BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x395BD00", Offset = "0x395AD00", VA = "0x18395BD00")]
	public static IDisposable EBBFAFKJLOI(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x395BFD0", Offset = "0x395AFD0", VA = "0x18395BFD0")]
	public static IDisposable EOOIKNLNPHC(this MonoBehaviour PLBJHMBJMLJ, Action BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x395C440", Offset = "0x395B440", VA = "0x18395C440")]
	public static IDisposable JPOEOIPAPEF(this MonoBehaviour PLBJHMBJMLJ, Action BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x395BC90", Offset = "0x395AC90", VA = "0x18395BC90")]
	public static IDisposable CNKEAAEGPMJ(this MonoBehaviour PLBJHMBJMLJ, Action BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x395C140", Offset = "0x395B140", VA = "0x18395C140")]
	public static IDisposable GJPNFIICLOF(this MonoBehaviour PLBJHMBJMLJ, Action BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x395BBA0", Offset = "0x395ABA0", VA = "0x18395BBA0")]
	public static IDisposable CIHFBOMLMNN(this MonoBehaviour PLBJHMBJMLJ, Action BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x395C330", Offset = "0x395B330", VA = "0x18395C330")]
	public static IDisposable IIJBKNPBOGN(this MonoBehaviour PLBJHMBJMLJ, float GBOHKAHJCCP, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x395C5B0", Offset = "0x395B5B0", VA = "0x18395C5B0")]
	public static IDisposable NAKCOPJCFAA(this MonoBehaviour PLBJHMBJMLJ, float GBOHKAHJCCP, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x395BC10", Offset = "0x395AC10", VA = "0x18395BC10")]
	public static IDisposable CKKJDDNNKOP(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x395C530", Offset = "0x395B530", VA = "0x18395C530")]
	public static IDisposable MDJEFECGFDL(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x395C6B0", Offset = "0x395B6B0", VA = "0x18395C6B0")]
	public static IDisposable OBMEPKENBJJ(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x395BB20", Offset = "0x395AB20", VA = "0x18395BB20")]
	public static IDisposable ABKNKGKMPPA(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x395C230", Offset = "0x395B230", VA = "0x18395C230")]
	public static IDisposable IBECINPEDIC(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x395C4B0", Offset = "0x395B4B0", VA = "0x18395C4B0")]
	public static IDisposable KJCADHJMFEB(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x395C730", Offset = "0x395B730", VA = "0x18395C730")]
	public static IDisposable PAHPIIMKNKE(this MonoBehaviour PLBJHMBJMLJ, float GBOHKAHJCCP, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x395C3C0", Offset = "0x395B3C0", VA = "0x18395C3C0")]
	public static IDisposable INJPPGFBOIF(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x395C1B0", Offset = "0x395B1B0", VA = "0x18395C1B0")]
	public static IDisposable HDBPPDOAKIP(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x395C630", Offset = "0x395B630", VA = "0x18395C630")]
	public static IDisposable NLIFEMMFOAI(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x395BF40", Offset = "0x395AF40", VA = "0x18395BF40")]
	public static IDisposable EIPKKJOPHGM(this MonoBehaviour PLBJHMBJMLJ, float GBOHKAHJCCP, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x395C0C0", Offset = "0x395B0C0", VA = "0x18395C0C0")]
	public static IDisposable GDMFBBLMNCL(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x395C2B0", Offset = "0x395B2B0", VA = "0x18395C2B0")]
	public static IDisposable IGPOFLILDHD(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x395C040", Offset = "0x395B040", VA = "0x18395C040")]
	public static IDisposable FBCGFBFEDHK(this MonoBehaviour PLBJHMBJMLJ, Action<float> BADELGGDOHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class FKKGNEDEMMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class AFPDHNFGOIO : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public AFPDHNFGOIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x39545C0", Offset = "0x39535C0", VA = "0x1839545C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3954670", Offset = "0x3953670", VA = "0x183954670", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private DNHDNMLNECC LKHLAOCEEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private EFAGFFHCEBJ IJPNDHOBKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Action BADELGGDOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action<float> AEDFKHIHIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Scheduler.IIHAJDBNDMM PPMHEPOAILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float MBNNNEFFMHD;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x395D5C0", Offset = "0x395C5C0", VA = "0x18395D5C0")]
	public FKKGNEDEMMI(EFAGFFHCEBJ IJPNDHOBKKG, Action BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x395D430", Offset = "0x395C430", VA = "0x18395D430")]
	public FKKGNEDEMMI(EFAGFFHCEBJ IJPNDHOBKKG, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x395D750", Offset = "0x395C750", VA = "0x18395D750")]
	public FKKGNEDEMMI(EFAGFFHCEBJ IJPNDHOBKKG, float GBOHKAHJCCP, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x395CE80", Offset = "0x395BE80", VA = "0x18395CE80")]
	private void EBBFAFKJLOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x395CCB0", Offset = "0x395BCB0", VA = "0x18395CCB0")]
	private void CNJIJEMOJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x395D100", Offset = "0x395C100", VA = "0x18395D100")]
	private void IDOOLFMCHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x395D230", Offset = "0x395C230", VA = "0x18395D230")]
	private void JNFOOGDFKJM(string FODJEJOHFJM, Action CIIMJEMDEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x395D3D0", Offset = "0x395C3D0", VA = "0x18395D3D0")]
	[IteratorStateMachine(typeof(AFPDHNFGOIO))]
	private IEnumerator<DNKAKMFKLPM> MOADECGAAIM(Action CIIMJEMDEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x395CE30", Offset = "0x395BE30", VA = "0x18395CE30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x395D080", Offset = "0x395C080", VA = "0x18395D080")]
	[CompilerGenerated]
	private void ICKHPKAGFGK(string OGNEAGPEDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x395D350", Offset = "0x395C350", VA = "0x18395D350")]
	[CompilerGenerated]
	private void KIEDPAHPCJB(string OGNEAGPEDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x395D000", Offset = "0x395C000", VA = "0x18395D000")]
	[CompilerGenerated]
	private void FABFDONLGIO(string OGNEAGPEDCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KCGJJHBKCKA
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x395F8C0", Offset = "0x395E8C0", VA = "0x18395F8C0")]
	public static IDisposable DAODBOIGFLG(this EFAGFFHCEBJ IJPNDHOBKKG, Action BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x395F700", Offset = "0x395E700", VA = "0x18395F700")]
	public static IDisposable DAODBOIGFLG(this EFAGFFHCEBJ IJPNDHOBKKG, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x395F940", Offset = "0x395E940", VA = "0x18395F940")]
	public static IDisposable DIAHCAHAIME(this EFAGFFHCEBJ IJPNDHOBKKG, Action BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x395FE20", Offset = "0x395EE20", VA = "0x18395FE20")]
	public static IDisposable OGMPBMIIEAJ(this EFAGFFHCEBJ IJPNDHOBKKG, Action BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x395FD40", Offset = "0x395ED40", VA = "0x18395FD40")]
	public static IDisposable NCIEKNGMPOO(this EFAGFFHCEBJ IJPNDHOBKKG, Action BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x395FA30", Offset = "0x395EA30", VA = "0x18395FA30")]
	public static IDisposable FCGFDMCNBPP(this EFAGFFHCEBJ IJPNDHOBKKG, Action BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x395FDB0", Offset = "0x395EDB0", VA = "0x18395FDB0")]
	public static IDisposable NEOBBAPMHOA(this EFAGFFHCEBJ IJPNDHOBKKG, Action BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x395FF90", Offset = "0x395EF90", VA = "0x18395FF90")]
	public static IDisposable PMGDGKEGOEG(this EFAGFFHCEBJ IJPNDHOBKKG, float GBOHKAHJCCP, Action<float> BADELGGDOHI, Scheduler.IIHAJDBNDMM PPMHEPOAILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x395FF10", Offset = "0x395EF10", VA = "0x18395FF10")]
	public static IDisposable PHAIGAPDKJL(this EFAGFFHCEBJ IJPNDHOBKKG, float GBOHKAHJCCP, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x395F580", Offset = "0x395E580", VA = "0x18395F580")]
	public static IDisposable BJOLHFGKDHH(this EFAGFFHCEBJ IJPNDHOBKKG, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x395FBC0", Offset = "0x395EBC0", VA = "0x18395FBC0")]
	public static IDisposable HNHCKJDFMGF(this EFAGFFHCEBJ IJPNDHOBKKG, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x395F500", Offset = "0x395E500", VA = "0x18395F500")]
	public static IDisposable AKADHBELOKD(this EFAGFFHCEBJ IJPNDHOBKKG, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x395FAA0", Offset = "0x395EAA0", VA = "0x18395FAA0")]
	public static IDisposable GLAICLNKFGP(this EFAGFFHCEBJ IJPNDHOBKKG, float GBOHKAHJCCP, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x395FCC0", Offset = "0x395ECC0", VA = "0x18395FCC0")]
	public static IDisposable MAPAGBOEHOF(this EFAGFFHCEBJ IJPNDHOBKKG, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x395FC40", Offset = "0x395EC40", VA = "0x18395FC40")]
	public static IDisposable JINFCBHJAFI(this EFAGFFHCEBJ IJPNDHOBKKG, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x395F680", Offset = "0x395E680", VA = "0x18395F680")]
	public static IDisposable CGODBIJJGFJ(this EFAGFFHCEBJ IJPNDHOBKKG, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x395FB30", Offset = "0x395EB30", VA = "0x18395FB30")]
	public static IDisposable GMGCCDFPIJH(this EFAGFFHCEBJ IJPNDHOBKKG, float GBOHKAHJCCP, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x395F600", Offset = "0x395E600", VA = "0x18395F600")]
	public static IDisposable CDLJCNKHPME(this EFAGFFHCEBJ IJPNDHOBKKG, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x395F9B0", Offset = "0x395E9B0", VA = "0x18395F9B0")]
	public static IDisposable EFFCIFJJJMN(this EFAGFFHCEBJ IJPNDHOBKKG, Action<float> BADELGGDOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x395FE90", Offset = "0x395EE90", VA = "0x18395FE90")]
	public static IDisposable ONHGOHMBAEK(this EFAGFFHCEBJ IJPNDHOBKKG, Action<float> BADELGGDOHI)
	{
		return null;
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class Scheduler : SingletonMonoBehaviour<Scheduler>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private class LCGHNKFBBMK : DGIFJJJPAAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public ECELPKOOPID BIDGOELDNIC;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public int JLLAHJNKFLL
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x41F010", Offset = "0x41E010", VA = "0x18041F010", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x446F60", Offset = "0x445F60", VA = "0x180446F60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3960B60", Offset = "0x395FB60", VA = "0x183960B60")]
			public static DNKAKMFKLPM COPGMPPMKBB(IEnumerator<DNKAKMFKLPM> AHHPLMFMNKD, MEBPOAFBMEK EPPKDKKODGE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3960A90", Offset = "0x395FA90", VA = "0x183960A90")]
			public DNKAKMFKLPM COPGMPPMKBB(MEBPOAFBMEK[] FOJIBOGKGGO, IEnumerator<DNKAKMFKLPM>[] MKDNEFAMPIN, DNKAKMFKLPM[] JGJGGPDFJCO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3960D80", Offset = "0x395FD80", VA = "0x183960D80")]
			public void GOIMLAOAIEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x39609D0", Offset = "0x395F9D0", VA = "0x1839609D0")]
			public void BAEPCJEJGGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3960CC0", Offset = "0x395FCC0", VA = "0x183960CC0")]
			public void FAEAPCMOCJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3960D80", Offset = "0x395FD80", VA = "0x183960D80")]
			public void NLKAJMMLDBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
			public LCGHNKFBBMK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class ECELPKOOPID
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			public struct PHEOBDOAEJB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public LCGHNKFBBMK IDPOOKJAODL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public EFAGFFHCEBJ LMCGLJMBICM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public MEBPOAFBMEK JMHICGAIOLM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public IEnumerator<DNKAKMFKLPM> BPIMKMMPOCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public DNKAKMFKLPM LEFNDGCAAOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public ILLJIBLCHBF GJJPBPMLALI;
			}

			[Cpp2IlInjected.Token(Token = "0x2000042")]
			public struct AMAAOFMJKJP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public IIHAJDBNDMM HJONAEGNBAI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public List<PHEOBDOAEJB> KGDFEPNGDJM;
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class BOELFGLOBFD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public ECELPKOOPID <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public EFAGFFHCEBJ context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public LCGHNKFBBMK routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public ILLJIBLCHBF coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public MEBPOAFBMEK promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public DNKAKMFKLPM currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public IEnumerator<DNKAKMFKLPM> coroutine;

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
				public BOELFGLOBFD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017D")]
				[Cpp2IlInjected.Address(RVA = "0x3955B60", Offset = "0x3954B60", VA = "0x183955B60")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000044")]
			[CompilerGenerated]
			private sealed class FPPNPFDOJKF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public LCGHNKFBBMK schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public ECELPKOOPID <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
				public FPPNPFDOJKF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x395DAC0", Offset = "0x395CAC0", VA = "0x18395DAC0")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class ENKDCKLLKIN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public LCGHNKFBBMK schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public ECELPKOOPID <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
				public ENKDCKLLKIN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x395BAE0", Offset = "0x395AAE0", VA = "0x18395BAE0")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000046")]
			[CompilerGenerated]
			private sealed class BMHONAGFKAF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public LCGHNKFBBMK schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public ECELPKOOPID <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000182")]
				[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
				public BMHONAGFKAF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x3955B20", Offset = "0x3954B20", VA = "0x183955B20")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private readonly IIHAJDBNDMM PPMHEPOAILC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private bool[] CNKOMFMLFDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private NativeArray<ILLJIBLCHBF> FGNADGAJPNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private NativeArray<float> CPAGJBJGHHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private NativeArray<int> FGGOGCNOKKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private NativeArray<int> MGPBPDFILKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private NativeArray<int> ABIKKBHMKIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private NativeArray<int> DIIKOLHNKJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private NativeArray<int> IGBCGGCLPOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private LCGHNKFBBMK[] JGPKOEDLEGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private MEBPOAFBMEK[] FOJIBOGKGGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private EFAGFFHCEBJ[] INFPDOGCOCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private IEnumerator<DNKAKMFKLPM>[] NAIDOKNPBFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private DNKAKMFKLPM[] JINHEPOHDOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private int FOMMPBFGIBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int JGJJNCMMGMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private readonly int NKBPJJEDMBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private float PGLHPAPBGCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private LAOINFHHIIB KJBIKJGHJIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private JobHandle OJJHNAELOAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private List<LCGHNKFBBMK> CJGANDLJJBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool DHHBPHEJCEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private List<Action> MPLEHMKOGEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private List<Action> AMHJEPPJDJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private bool GLEEMCKEIEB;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public AMAAOFMJKJP[] CDCGIKMMPOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0xB0D300", Offset = "0xB0C300", VA = "0x180B0D300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public int ONMLFAPCEFM
			{
				[Cpp2IlInjected.Token(Token = "0x6000168")]
				[Cpp2IlInjected.Address(RVA = "0x7A2E70", Offset = "0x7A1E70", VA = "0x1807A2E70")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x395A9B0", Offset = "0x39599B0", VA = "0x18395A9B0")]
			private static int INMDCCFFNHO(IIHAJDBNDMM PPMHEPOAILC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x395B580", Offset = "0x395A580", VA = "0x18395B580")]
			public ECELPKOOPID(IIHAJDBNDMM PPMHEPOAILC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3959940", Offset = "0x3958940", VA = "0x183959940")]
			private void BAELIHBDNKL(ref int FMKEAHGAPON, int DBDOOIFKICH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x395A5E0", Offset = "0x39595E0", VA = "0x18395A5E0")]
			public void HNICALGGIAO(EFAGFFHCEBJ IJPNDHOBKKG, DNKAKMFKLPM DFACLDMIADG, IEnumerator<DNKAKMFKLPM> AHHPLMFMNKD, MEBPOAFBMEK EPPKDKKODGE, [Optional] LCGHNKFBBMK PDOIGIHPHNL, ILLJIBLCHBF FEOCFGEHBIK = ILLJIBLCHBF.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x395AEB0", Offset = "0x3959EB0", VA = "0x18395AEB0")]
			public void MHFEIJOGOFK(IEnumerable<PHEOBDOAEJB> PHAKMPCFCIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x395B150", Offset = "0x395A150", VA = "0x18395B150")]
			private PHEOBDOAEJB ODDJPLBCMBJ(int BOJLNMCAGFC)
			{
				return default(PHEOBDOAEJB);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x395A9E0", Offset = "0x39599E0", VA = "0x18395A9E0")]
			private void JHELKDPNKEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x263A4A0", Offset = "0x26394A0", VA = "0x18263A4A0")]
			private static void AJDMFMGDBNM<T>(int BOJLNMCAGFC, T[] HDCKLGNPHAO, int DFDGHCFEOOK, [Optional] T CAHCBEJOJNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x263A480", Offset = "0x2639480", VA = "0x18263A480")]
			private static void AJDMFMGDBNM<T>(int BOJLNMCAGFC, NativeArray<T> HDCKLGNPHAO, int DFDGHCFEOOK, [Optional] T CAHCBEJOJNG) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x395A710", Offset = "0x3959710", VA = "0x18395A710")]
			private void HOFGKDFENHK(IEnumerable<PHEOBDOAEJB> PHAKMPCFCIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x395AD10", Offset = "0x3959D10", VA = "0x18395AD10")]
			private void JJCFLAFIKLL(PHEOBDOAEJB BPGDAPKFBNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x3959C00", Offset = "0x3958C00", VA = "0x183959C00")]
			private JPPEHHDCAHP FJAFJLIDENL(int HDFIAMCJLOJ)
			{
				return default(JPPEHHDCAHP);
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x3959F50", Offset = "0x3958F50", VA = "0x183959F50")]
			public void GOGECPHFIHH(float PNOMJBINNCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x39598C0", Offset = "0x39588C0", VA = "0x1839598C0")]
			private void ALPKCDJOMJD(Action AIGELDPBMKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3959AD0", Offset = "0x3958AD0", VA = "0x183959AD0")]
			private void BOEPALOAMDJ(Action AIGELDPBMKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x395A140", Offset = "0x3959140", VA = "0x18395A140")]
			public void HIMMEINONIM(float PNOMJBINNCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x395ADD0", Offset = "0x3959DD0", VA = "0x18395ADD0")]
			public void JPMIADIJNBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x395B0A0", Offset = "0x395A0A0", VA = "0x18395B0A0")]
			public void NLKAJMMLDBJ(LCGHNKFBBMK EPKDOAFBOJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3959EA0", Offset = "0x3958EA0", VA = "0x183959EA0")]
			public void GDBJBMNDEPJ(LCGHNKFBBMK EPKDOAFBOJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3959B50", Offset = "0x3958B50", VA = "0x183959B50")]
			public void DPJNGOANPJH(LCGHNKFBBMK EPKDOAFBOJP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[BurstCompile]
		public struct LAOINFHHIIB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			[ReadOnly]
			public float KAODBIGBIIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			[ReadOnly]
			public int NEKJHDKFBGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private NativeArray<int> EOECFHBBFME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private NativeArray<int> CNAELNMPCDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private NativeArray<int> ABLNAGNFIGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			[ReadOnly]
			public NativeArray<ILLJIBLCHBF> DDPBCHEHOPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			[ReadOnly]
			public NativeArray<float> BEECHLFLFFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			[WriteOnly]
			public NativeArray<int> ABIKKBHMKIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			[WriteOnly]
			public NativeArray<int> FGGOGCNOKKB;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3960590", Offset = "0x395F590", VA = "0x183960590")]
			public static LAOINFHHIIB KCCOLOKOAMM(int IAPHIGHEING, float PNOMJBINNCM, NativeArray<ILLJIBLCHBF> FHEADFIMBBK, NativeArray<float> JAFPFDOGPMB, NativeArray<int> GKBKPNAODLN, NativeArray<int> DDGCMEINEGN, NativeArray<int> CBGALOABEFM, NativeArray<int> CNAELNMPCDJ, NativeArray<int> ABLNAGNFIGB)
			{
				return default(LAOINFHHIIB);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3960440", Offset = "0x395F440", VA = "0x183960440", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x3960890", Offset = "0x395F890", VA = "0x183960890")]
			private bool OOMHLFJHEMF(int DKJKEBPJDEF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x39609A0", Offset = "0x395F9A0", VA = "0x1839609A0")]
			private void PMAMDIAONEB(NativeArray<int> OPFJPMBOBCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3960520", Offset = "0x395F520", VA = "0x183960520")]
			private int JCDNMHGPALD(int BHKDPAEKJAB, int DLOJEAFNGAP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x39608D0", Offset = "0x395F8D0", VA = "0x1839608D0")]
			private void PHGNIDMGLGC(NativeArray<int> OPFJPMBOBCM, int FKCEBIPMLGK, int LMCCNILJAPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3960660", Offset = "0x395F660", VA = "0x183960660")]
			private void NCHKFNKMIDJ(NativeArray<int> OPFJPMBOBCM, int KOMBKBAHMFP, int IFBFECGELGD, int PCMPFJABLPG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class AEDCOGCBCMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly MEBPOAFBMEK EPPKDKKODGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Behaviour IJPNDHOBKKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly bool IOMBGMDOJMD;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public IEnumerator<DNKAKMFKLPM> BPIMKMMPOCL
			{
				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(RVA = "0x423200", Offset = "0x422200", VA = "0x180423200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x446570", Offset = "0x445570", VA = "0x180446570")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public DNKAKMFKLPM LEFNDGCAAOF
			{
				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x426030", Offset = "0x425030", VA = "0x180426030")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool AFCKLHINBCI
			{
				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x3952A60", Offset = "0x3951A60", VA = "0x183952A60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool MBCCKAJIDPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x72CEC0", Offset = "0x72BEC0", VA = "0x18072CEC0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0x7F2880", Offset = "0x7F1880", VA = "0x1807F2880")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public string GCPJLMHALKO
			{
				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x423220", Offset = "0x422220", VA = "0x180423220")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x447090", Offset = "0x446090", VA = "0x180447090")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public float FFCJPJAABAM
			{
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x6A4BB0", Offset = "0x6A3BB0", VA = "0x1806A4BB0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x6A4C60", Offset = "0x6A3C60", VA = "0x1806A4C60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3952C10", Offset = "0x3951C10", VA = "0x183952C10")]
			public AEDCOGCBCMH(IEnumerator<DNKAKMFKLPM> AHHPLMFMNKD, Behaviour IJPNDHOBKKG, MEBPOAFBMEK EPPKDKKODGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x39527C0", Offset = "0x39517C0", VA = "0x1839527C0")]
			public DNKAKMFKLPM COPGMPPMKBB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x39529D0", Offset = "0x39519D0", VA = "0x1839529D0")]
			public bool EIPMCPPMMNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3952AF0", Offset = "0x3951AF0", VA = "0x183952AF0")]
			public void NLKAJMMLDBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3952B80", Offset = "0x3951B80", VA = "0x183952B80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1E630F0", Offset = "0x1E620F0", VA = "0x181E630F0")]
			[CompilerGenerated]
			private void MOEDIKMHOEJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private sealed class MEBPOAFBMEK : HEMMDMNNDND, DNHDNMLNECC, JAEINMCBLPH, BNIMEGFNNGI, IEnumerator, DNKAKMFKLPM, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private IIHAJDBNDMM GIGECAJLMIA;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			private IIHAJDBNDMM FKPHFEDAKKA
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x46A330", Offset = "0x469330", VA = "0x18046A330", Slot = "23")]
				get
				{
					return default(IIHAJDBNDMM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public IIHAJDBNDMM BIDGOELDNIC
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x46A330", Offset = "0x469330", VA = "0x18046A330")]
				get
				{
					return default(IIHAJDBNDMM);
				}
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x57FA60", Offset = "0x57EA60", VA = "0x18057FA60")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			private float HECOLIPNKAH
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x5624C0", Offset = "0x5614C0", VA = "0x1805624C0", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3960F60", Offset = "0x395FF60", VA = "0x183960F60", Slot = "24")]
			private bool FBHNHBEMBAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3960F50", Offset = "0x395FF50", VA = "0x183960F50", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3960F80", Offset = "0x395FF80", VA = "0x183960F80")]
			public MEBPOAFBMEK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private enum JPPEHHDCAHP : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private sealed class AFOFMHIGOAJ : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200004C")]
			public enum BAOFBMBKIHH
			{
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			public struct GPGBDFLACOK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public IIHAJDBNDMM HJONAEGNBAI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public BAOFBMBKIHH GLLCKCIDFOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public List<AEDCOGCBCMH> DFGNMONFAIG;
			}

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private static readonly BAOFBMBKIHH[] FIPBJLNONEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private readonly IIHAJDBNDMM PPMHEPOAILC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private bool MIJFOBJNKJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private readonly AEDCOGCBCMH[] KAIGFAJBBPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private readonly List<AEDCOGCBCMH> EKMFGGJMAJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly Stack<int> MDJMFGAEAJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly List<AEDCOGCBCMH> IOADEKMIFGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly Stack<int> PKGJOHJLCCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private bool GLEEMCKEIEB;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public GPGBDFLACOK[,] LFNCPDEGOLH
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x422600", Offset = "0x421600", VA = "0x180422600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public int ONMLFAPCEFM
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x39534B0", Offset = "0x39524B0", VA = "0x1839534B0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x39541E0", Offset = "0x39531E0", VA = "0x1839541E0")]
			public AFOFMHIGOAJ(IIHAJDBNDMM MDOJIHKCBBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3953370", Offset = "0x3952370", VA = "0x183953370")]
			public void FLNPMCLAIAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3953380", Offset = "0x3952380", VA = "0x183953380")]
			public void JCFDAAPIPFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3953B90", Offset = "0x3952B90", VA = "0x183953B90")]
			private void PHLJGOEFIOL(IReadOnlyList<AEDCOGCBCMH> KHDJHPHELJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3952F90", Offset = "0x3951F90", VA = "0x183952F90")]
			public void CBEIKFDCIBD(AEDCOGCBCMH AHHPLMFMNKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x39537A0", Offset = "0x39527A0", VA = "0x1839537A0")]
			public void NMIMIBPJABC(IList<AEDCOGCBCMH> MKDNEFAMPIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3953E90", Offset = "0x3952E90", VA = "0x183953E90")]
			public void PKHALGGIEFK(IList<AEDCOGCBCMH> MKDNEFAMPIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3953090", Offset = "0x3952090", VA = "0x183953090")]
			private void CMCFACOBFAP(AEDCOGCBCMH AHHPLMFMNKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3953A20", Offset = "0x3952A20", VA = "0x183953A20")]
			private void PAKPBHPHKEO(IList<AEDCOGCBCMH> MKDNEFAMPIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3953620", Offset = "0x3952620", VA = "0x183953620")]
			private JPPEHHDCAHP MBMEGKHEPCN(AEDCOGCBCMH AHHPLMFMNKD)
			{
				return default(JPPEHHDCAHP);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x39532C0", Offset = "0x39522C0", VA = "0x1839532C0")]
			public void EOOIKNLNPHC(float PNOMJBINNCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3952D90", Offset = "0x3951D90", VA = "0x183952D90")]
			public void BLDIKHCHDNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3953CB0", Offset = "0x3952CB0", VA = "0x183953CB0")]
			private void PIIBLNBPAON(List<AEDCOGCBCMH> MKDNEFAMPIN, Stack<int> HKCENMFMJPG, bool IDBEPNHBJFD, float NJKNFIJAFAP = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3953180", Offset = "0x3952180", VA = "0x183953180", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x3953390", Offset = "0x3952390", VA = "0x183953390")]
			private void JGHGKCMECFK(List<AEDCOGCBCMH> MKDNEFAMPIN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[DDHCFNJCJBI]
		public enum IIHAJDBNDMM
		{
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			PreRender,
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			EndOfFrame
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[Flags]
		public enum ILLJIBLCHBF : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class CEAGLCHBDIA : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
			[DebuggerHidden]
			public CEAGLCHBDIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x39562F0", Offset = "0x39552F0", VA = "0x1839562F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3956370", Offset = "0x3955370", VA = "0x183956370", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private const ILLJIBLCHBF MBDKAOCINFI = ILLJIBLCHBF.Cancelled | ILLJIBLCHBF.Paused;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly IIHAJDBNDMM[] PAOBCLNJKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private AFOFMHIGOAJ[] KJNBNHAPPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private ECELPKOOPID[] EGFDPEHENCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Coroutine KJAODBAKMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private WaitForEndOfFrame OAFDFFCLNIE;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public OHLDPKEDMND NKDDDPKLFGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x426030", Offset = "0x425030", VA = "0x180426030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public IIHAJDBNDMM MLGEKGLLFGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x446D80", Offset = "0x445D80", VA = "0x180446D80")]
			[CompilerGenerated]
			get
			{
				return default(IIHAJDBNDMM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BE80", VA = "0x18051CE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int ONMLFAPCEFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x39647E0", Offset = "0x39637E0", VA = "0x1839647E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3963480", Offset = "0x3962480", VA = "0x183963480")]
		public static DNHDNMLNECC GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3962F70", Offset = "0x3961F70", VA = "0x183962F70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3963890", Offset = "0x3962890", VA = "0x183963890", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0B0", Offset = "0x8AB0B0", VA = "0x1808AC0B0")]
		private AFOFMHIGOAJ LLCMONIHGPE(IIHAJDBNDMM PBECNPPNGID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x984E90", Offset = "0x983E90", VA = "0x180984E90")]
		private ECELPKOOPID GCEGAMPAKKI(IIHAJDBNDMM PBECNPPNGID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3963D20", Offset = "0x3962D20", VA = "0x183963D20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3963CF0", Offset = "0x3962CF0", VA = "0x183963CF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x39645B0", Offset = "0x39635B0", VA = "0x1839645B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3963750", Offset = "0x3962750", VA = "0x183963750")]
		private void KADOLDCAOID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3963520", Offset = "0x3962520", VA = "0x183963520")]
		private void JHILBHNHPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3963470", Offset = "0x3962470", VA = "0x183963470")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3963880", Offset = "0x3962880", VA = "0x183963880")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3963460", Offset = "0x3962460", VA = "0x183963460")]
		private void DFBJDIHLOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3963530", Offset = "0x3962530", VA = "0x183963530")]
		[IteratorStateMachine(typeof(CEAGLCHBDIA))]
		private IEnumerator JLIFDADNCLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x39641E0", Offset = "0x39631E0", VA = "0x1839641E0")]
		public DNHDNMLNECC Run(IEnumerator<DNKAKMFKLPM> DPPCGOIIHDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3963EC0", Offset = "0x3962EC0", VA = "0x183963EC0")]
		public DNHDNMLNECC Run(Behaviour IJPNDHOBKKG, IEnumerator<DNKAKMFKLPM> DPPCGOIIHDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3963D90", Offset = "0x3962D90", VA = "0x183963D90")]
		public DNHDNMLNECC RunJobbed(EFAGFFHCEBJ IJPNDHOBKKG, IEnumerator<DNKAKMFKLPM> DPPCGOIIHDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3963400", Offset = "0x3962400", VA = "0x183963400")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x39641F0", Offset = "0x39631F0", VA = "0x1839641F0")]
		public void UpdateQueue(IIHAJDBNDMM AJMLEDPKJNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3963590", Offset = "0x3962590", VA = "0x183963590")]
		private void JOEGHODKFCF(AFOFMHIGOAJ FPEKAPEDJLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3963760", Offset = "0x3962760", VA = "0x183963760")]
		private void LEBPCJFJHJP(ECELPKOOPID FPEKAPEDJLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3964760", Offset = "0x3963760", VA = "0x183964760")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface OHLDPKEDMND
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	float IBPLGDCICCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	float EPIHFOJNMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	float FAMAPEKJMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	int AKPBPGNLGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	double KNHHEBBFOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class DNJFBCFKEJE : OHLDPKEDMND
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float IBPLGDCICCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3959730", Offset = "0x3958730", VA = "0x183959730", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float EPIHFOJNMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3959720", Offset = "0x3958720", VA = "0x183959720", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float FAMAPEKJMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3959740", Offset = "0x3958740", VA = "0x183959740", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int AKPBPGNLGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3959770", Offset = "0x3958770", VA = "0x183959770", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public double KNHHEBBFOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3959750", Offset = "0x3958750", VA = "0x183959750", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
	public DNJFBCFKEJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class HIGBBJAGAOF : HNHKJFOAPDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public int KOLIFADDDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Queue<double> KJMNCLFGOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private double LKLLLNENFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double OBCNAEACKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private double FJNBDHCMECL;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int EMOIAHLLNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x395E590", Offset = "0x395D590", VA = "0x18395E590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public double PBLHGCIPHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x395E4C0", Offset = "0x395D4C0", VA = "0x18395E4C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public double FOHPBENMLHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xDFD530", Offset = "0xDFC530", VA = "0x180DFD530", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public double CPHJFALMHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xDFD520", Offset = "0xDFC520", VA = "0x180DFD520", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x395E6D0", Offset = "0x395D6D0", VA = "0x18395E6D0")]
	public HIGBBJAGAOF(int IPKILAHGOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x395E5D0", Offset = "0x395D5D0", VA = "0x18395E5D0", Slot = "4")]
	public void FFNPOJDHGCL(double FNLDCACDFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x395E520", Offset = "0x395D520", VA = "0x18395E520", Slot = "5")]
	public void CLMHOEKMFPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class FEDCPMMEAEL : HNHKJFOAPDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private long EFBKKCLPALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private double ALMCNKLILGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private double BJHONAFAEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private double LJKFDHGMJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private double IGGHJCJLADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private double LKLLLNENFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private double OBCNAEACKFG;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long MFJPBNLJGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x423200", Offset = "0x422200", VA = "0x180423200")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public double FOHPBENMLHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7FF6C0", Offset = "0x7FE6C0", VA = "0x1807FF6C0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public double CPHJFALMHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA3D490", Offset = "0xA3C490", VA = "0x180A3D490", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public double CHFFGPECEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xDFD520", Offset = "0xDFC520", VA = "0x180DFD520")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public double NPKHICODPEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x367C510", Offset = "0x367B510", VA = "0x18367C510")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public double PBLHGCIPHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xDFD440", Offset = "0xDFC440", VA = "0x180DFD440", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x395C800", Offset = "0x395B800", VA = "0x18395C800", Slot = "4")]
	public void FFNPOJDHGCL(double FNLDCACDFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x395C7C0", Offset = "0x395B7C0", VA = "0x18395C7C0", Slot = "5")]
	public void CLMHOEKMFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x395C920", Offset = "0x395B920", VA = "0x18395C920")]
	public FEDCPMMEAEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface HNHKJFOAPDD
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	double PBLHGCIPHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	double FOHPBENMLHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	double CPHJFALMHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFNPOJDHGCL(double FNLDCACDFHE);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLMHOEKMFPH();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class PIIDKHENOCO
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private interface GPAOBFMHCBE
	{
		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool DOLGJBPLGPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HDLMKOOOCOJ();

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NLKAJMMLDBJ();
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class PCICOLKJLLK<TPromise, TMainThreadPromise> : GPAOBFMHCBE where TPromise : BNIMEGFNNGI where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly TPromise EHECIBLNLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		protected readonly TMainThreadPromise ADBMADPHDBB;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public TPromise KKFJPNJKOAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x29FFCF0", Offset = "0x29FECF0", VA = "0x1829FFCF0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool DOLGJBPLGPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x29FFD80", Offset = "0x29FED80", VA = "0x1829FFD80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x29ED130", Offset = "0x29EC130", VA = "0x1829ED130")]
		protected PCICOLKJLLK(TPromise EHECIBLNLJL, TMainThreadPromise JBPICOMMIIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x29FFD50", Offset = "0x29FED50", VA = "0x1829FFD50", Slot = "5")]
		public void HDLMKOOOCOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x254B290", Offset = "0x254A290", VA = "0x18254B290", Slot = "6")]
		public void NLKAJMMLDBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void EOELIDOBCBD(TPromise EHECIBLNLJL);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void LOKDPGMFAKC();
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class FGOHACMFOOG<T> : PCICOLKJLLK<global::GBEKKLLKIMD<T>, global::GLKLOOCIFIF<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x29F0880", Offset = "0x29EF880", VA = "0x1829F0880")]
		public FGOHACMFOOG(global::GBEKKLLKIMD<T> EHECIBLNLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x29F05F0", Offset = "0x29EF5F0", VA = "0x1829F05F0", Slot = "7")]
		protected override void EOELIDOBCBD(global::GBEKKLLKIMD<T> EHECIBLNLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x29F07C0", Offset = "0x29EF7C0", VA = "0x1829F07C0", Slot = "8")]
		protected override void LOKDPGMFAKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x29F0450", Offset = "0x29EF450", VA = "0x1829F0450")]
		[CompilerGenerated]
		private void ABBIAAHHJHB(T EKJFGINBNKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x29F0790", Offset = "0x29EF790", VA = "0x1829F0790")]
		[CompilerGenerated]
		private void JEOKIEAEEIP(string FODJEJOHFJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class ILEJALDOHHA : PCICOLKJLLK<BNIMEGFNNGI, PNALDAGDAPL>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x395EB00", Offset = "0x395DB00", VA = "0x18395EB00")]
		public ILEJALDOHHA(BNIMEGFNNGI EHECIBLNLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x395E9E0", Offset = "0x395D9E0", VA = "0x18395E9E0", Slot = "7")]
		protected override void EOELIDOBCBD(BNIMEGFNNGI EHECIBLNLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x395EAB0", Offset = "0x395DAB0", VA = "0x18395EAB0", Slot = "8")]
		protected override void LOKDPGMFAKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1623B50", Offset = "0x1622B50", VA = "0x181623B50")]
		[CompilerGenerated]
		private void ABBIAAHHJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1B66940", Offset = "0x1B65940", VA = "0x181B66940")]
		[CompilerGenerated]
		private void JEOKIEAEEIP(string FODJEJOHFJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private class EIPIOPLEPHA : GPAOBFMHCBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly Action MMBIEGLGGJN;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool DOLGJBPLGPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x447060", Offset = "0x446060", VA = "0x180447060", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x52A960", Offset = "0x529960", VA = "0x18052A960")]
		public EIPIOPLEPHA(Action MMBIEGLGGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xE0CA80", Offset = "0xE0BA80", VA = "0x180E0CA80", Slot = "5")]
		public void HDLMKOOOCOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "6")]
		public void NLKAJMMLDBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly List<GPAOBFMHCBE> PHPDDBFBJJJ;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C106C0", Offset = "0x2C0F6C0", VA = "0x182C106C0")]
	public static global::GBEKKLLKIMD<T> DCOEJCLCDLN<T>(this global::GBEKKLLKIMD<T> EHECIBLNLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3962880", Offset = "0x3961880", VA = "0x183962880")]
	public static BNIMEGFNNGI DCOEJCLCDLN(this BNIMEGFNNGI EHECIBLNLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3962800", Offset = "0x3961800", VA = "0x183962800")]
	public static void DCOEJCLCDLN(Action MMBIEGLGGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C107A0", Offset = "0x2C0F7A0", VA = "0x182C107A0")]
	private static global::GBEKKLLKIMD<T> DDJNNBOHAFG<T>(global::GBEKKLLKIMD<T> EHECIBLNLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3962990", Offset = "0x3961990", VA = "0x183962990")]
	private static BNIMEGFNNGI DDJNNBOHAFG(BNIMEGFNNGI EHECIBLNLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3962620", Offset = "0x3961620", VA = "0x183962620")]
	private static void CADJLDIHIPC(GPAOBFMHCBE JJLDAGHCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3962B20", Offset = "0x3961B20", VA = "0x183962B20")]
	private static void HJFNKDJNIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x3962E40", Offset = "0x3961E40", VA = "0x183962E40")]
	private static void PKOHEHGNGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3962A70", Offset = "0x3961A70", VA = "0x183962A70")]
	private static void EBIKEHKLGBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class AMBDADJIIOE
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class NGJPIANNLLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public PNALDAGDAPL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
		public NGJPIANNLLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x39618B0", Offset = "0x39608B0", VA = "0x1839618B0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x39618A0", Offset = "0x39608A0", VA = "0x1839618A0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class BKPGLADCCEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
		public BKPGLADCCEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3955AF0", Offset = "0x3954AF0", VA = "0x183955AF0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class CKMIPAGEMBI : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public PNALDAGDAPL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public CKMIPAGEMBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3956ED0", Offset = "0x3955ED0", VA = "0x183956ED0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3956BC0", Offset = "0x3955BC0", VA = "0x183956BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3956F80", Offset = "0x3955F80", VA = "0x183956F80")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3956E80", Offset = "0x3955E80", VA = "0x183956E80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MGMHEOKMBCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public PNALDAGDAPL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
		public MGMHEOKMBCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class FGAPPMEEPLA : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private DNKAKMFKLPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public PNALDAGDAPL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private MGMHEOKMBCI <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public FGAPPMEEPLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x395C950", Offset = "0x395B950", VA = "0x18395C950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x395CC60", Offset = "0x395BC60", VA = "0x18395CC60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public const string IGBGBPJHIPL = "empty";

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public const string FJJEMILJOJP = "moderator";

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public const string JFBIDACNFKJ = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public const string ICOOAPAHLCM = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public const string AOOFLDKLKFC = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const float EAHHEBHLCHG = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static BNIMEGFNNGI NCDLGHNFLNN;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static AsyncOperation MBIKONPCCHG;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static BNIMEGFNNGI OKLJFAPDICH;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static string BMINMCIIDBD;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static ThreadPriority CDAGENGMDBE;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public static bool PKIPDHHPCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3954910", Offset = "0x3953910", VA = "0x183954910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private static bool BEMKOPKLDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x39546C0", Offset = "0x39536C0", VA = "0x1839546C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private static bool BDGJMKPHINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3954D60", Offset = "0x3953D60", VA = "0x183954D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<string, LoadSceneMode> NPEBDKDEEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3954720", Offset = "0x3953720", VA = "0x183954720")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3954CB0", Offset = "0x3953CB0", VA = "0x183954CB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x39547D0", Offset = "0x39537D0", VA = "0x1839547D0")]
	public static BNIMEGFNNGI EBGIMGLKNJH(string IFBDCKCGFAN, LoadSceneMode PDONBOMAGAO = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3954A30", Offset = "0x3953A30", VA = "0x183954A30")]
	public static BNIMEGFNNGI HGAOHIIHBNF(string IFBDCKCGFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3954C40", Offset = "0x3953C40", VA = "0x183954C40")]
	[IteratorStateMachine(typeof(CKMIPAGEMBI))]
	private static IEnumerator<DNKAKMFKLPM> MHHJDPLKFLP(string IFBDCKCGFAN, PNALDAGDAPL GJCDGIJPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x39549B0", Offset = "0x39539B0", VA = "0x1839549B0")]
	[IteratorStateMachine(typeof(FGAPPMEEPLA))]
	private static IEnumerator<DNKAKMFKLPM> GOCEKAAHGIC(string IFBDCKCGFAN, LoadSceneMode PDONBOMAGAO, PNALDAGDAPL GJCDGIJPDOC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MPHOBGJJMAN
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static byte[] MDECFDIPDIM;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static int KDCNKENIGEG;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static int ONHHOGLLEIJ;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static BigInteger FFNLGEIGHMD;

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
	public MPHOBGJJMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x39615F0", Offset = "0x39605F0", VA = "0x1839615F0")]
	private static string MGHDHGHNMMA(byte[] FLPHBPIKJBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x39612C0", Offset = "0x39602C0", VA = "0x1839612C0")]
	public static string EPCEKCOHIKG(byte[] FGABAFACHHN, bool IKFHCLDOPDI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
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

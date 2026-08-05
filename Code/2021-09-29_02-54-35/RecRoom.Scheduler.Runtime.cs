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
public interface MKDOFACOCGD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NBFJNPGBICP PNKOGIOMKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	NBFJNPGBICP OEDEDCNCIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NBFJNPGBICP NCDFLPHFHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HLKEKKJJAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KNKCNHMCMJK
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
		private delegate List<PlayerLoopSystem> POBGEFEPBLL(List<PlayerLoopSystem> CJNANNCCHIJ, int NJLBGDBIAHE);

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct MDHBADKBBLE
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct NJICHBODDBN
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static NBFJNPGBICP GIFAGOJICIE;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x3816930", Offset = "0x3815730", VA = "0x183816930")]
				public static PlayerLoopSystem MOEMKLFHINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct JECPDCFOPJO
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static NBFJNPGBICP GBIOAMEPIJI;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x3814290", Offset = "0x3813090", VA = "0x183814290")]
				public static PlayerLoopSystem MOEMKLFHINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct LIHMHAOEAME
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static NBFJNPGBICP JBDKOIPKFDD;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x3815010", Offset = "0x3813E10", VA = "0x183815010")]
				public static PlayerLoopSystem MOEMKLFHINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			internal struct HNIKOMIEJCE
			{
				[Cpp2IlInjected.Token(Token = "0x200000D")]
				[CompilerGenerated]
				private sealed class FOHAPMDFKNG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public PMKOIFPFIOO.OMNBJKOOLJF key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
					public FOHAPMDFKNG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x3811E20", Offset = "0x3810C20", VA = "0x183811E20")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable EFPHDEICFLH;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x3812380", Offset = "0x3811180", VA = "0x183812380")]
				public static PlayerLoopSystem GOICAPEILHD(PMKOIFPFIOO.OMNBJKOOLJF JEAOBHPGMKJ)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			internal struct DAFILHICHMA
			{
				[Cpp2IlInjected.Token(Token = "0x200000F")]
				[CompilerGenerated]
				private sealed class KGNPMPGEFBN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000D")]
					public PMKOIFPFIOO.OMNBJKOOLJF key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
					public KGNPMPGEFBN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x3814B10", Offset = "0x3813910", VA = "0x183814B10")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x380F980", Offset = "0x380E780", VA = "0x18380F980")]
				public static PlayerLoopSystem GOICAPEILHD(PMKOIFPFIOO.OMNBJKOOLJF JEAOBHPGMKJ)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class NNBIINCIBBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
			public NNBIINCIBBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3816B20", Offset = "0x3815920", VA = "0x183816B20")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool DIJEELDIHLC;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool GCLDAHCNIHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x380ECE0", Offset = "0x380DAE0", VA = "0x18380ECE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x380ECA0", Offset = "0x380DAA0", VA = "0x18380ECA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x380DE50", Offset = "0x380CC50", VA = "0x18380DE50")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x380F190", Offset = "0x380DF90", VA = "0x18380F190")]
		private static void NHFNAOMCHBO(PMKOIFPFIOO.OMNBJKOOLJF JEAOBHPGMKJ, ref PlayerLoopSystem PFIDENIAGEI, Type OBJLONLFFFM, Type KLGMKAHPIBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x380EE20", Offset = "0x380DC20", VA = "0x18380EE20")]
		private static void NEOEKACBEHI(ref PlayerLoopSystem PFIDENIAGEI, Type OBJLONLFFFM, Type KLGMKAHPIBB, POBGEFEPBLL PCMDLBGADPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x380ED20", Offset = "0x380DB20", VA = "0x18380ED20")]
		private static void LPMEOKMMAPA(ref PlayerLoopSystem PFIDENIAGEI, Type OBJLONLFFFM, Type KLGMKAHPIBB, PlayerLoopSystem? JBGGJODIDFC, PlayerLoopSystem? IMMHBFKJJFF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PMKOIFPFIOO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum OMNBJKOOLJF
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
	public class KEJNMEEHFGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly OMNBJKOOLJF LNDCLIHFFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly JOKNBGJDMJE IFGMPMBAHIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long PCIGMPOPFPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long AILJALAEKLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public long CONJIOPACEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int AKMGGLICCOK;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3814A30", Offset = "0x3813830", VA = "0x183814A30")]
		public KEJNMEEHFGJ(OMNBJKOOLJF ENBPGHLEHFE, int KNKADNGIEPI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x38148A0", Offset = "0x38136A0", VA = "0x1838148A0")]
		public void KGDNPHOAMFM(int CCHKONOAJBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x38148C0", Offset = "0x38136C0", VA = "0x1838148C0")]
		public void KIGPPLBCJKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3814930", Offset = "0x3813730", VA = "0x183814930")]
		public void KKHBKCFIGHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x38146D0", Offset = "0x38134D0", VA = "0x1838146D0")]
		public void DJCJMDANOFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3814990", Offset = "0x3813790", VA = "0x183814990")]
		public double PDEEHOHMPFO(int IAEAJNIKKCC)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int OGNOOJAADFO = 90;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static OMNBJKOOLJF[] GLPCAADENLE;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static KEJNMEEHFGJ[] EIHKIIOKILI;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x381A920", Offset = "0x3819720", VA = "0x18381A920")]
	public static KEJNMEEHFGJ FMKHMMAKCMB(OMNBJKOOLJF JEAOBHPGMKJ, int KNKADNGIEPI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x381AAB0", Offset = "0x38198B0", VA = "0x18381AAB0")]
	public static KEJNMEEHFGJ NPDOMDOFEGH(OMNBJKOOLJF JEAOBHPGMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x381AB40", Offset = "0x3819940", VA = "0x18381AB40")]
	public static void OIHEAHHKDAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IDKBBENHEDG : OIFMKHPHHLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class EFNAJMFOLCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public IDKBBENHEDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
		public EFNAJMFOLCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x38112E0", Offset = "0x38100E0", VA = "0x1838112E0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NPKEODEPBLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public IDKBBENHEDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
		public NPKEODEPBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x38112E0", Offset = "0x38100E0", VA = "0x1838112E0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float KOHHFCOGMOM;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x380D600", Offset = "0x380C400", VA = "0x18380D600")]
	public IDKBBENHEDG(Behaviour BPEHFBCHPMI, float KOHHFCOGMOM, [Optional] Action MABPAHOGPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3812480", Offset = "0x3811280", VA = "0x183812480", Slot = "9")]
	protected override bool EKGKHFAGLAA(Action PBMHOLJNIIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3812550", Offset = "0x3811350", VA = "0x183812550", Slot = "10")]
	protected override bool FOCCNNJOJKC(Action PBMHOLJNIIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KGEFLHAPLCB
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool BJDNKDKHMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IMONMMFEIFO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DOJALCOEBNB(bool HAHACPFIKHP = false);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DOJALCOEBNB(Action PBMHOLJNIIA, bool HAHACPFIKHP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class OIFMKHPHHLJ : KGEFLHAPLCB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OJHCPOONDNF : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public OJHCPOONDNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3818390", Offset = "0x3817190", VA = "0x183818390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3818430", Offset = "0x3817230", VA = "0x183818430", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Behaviour BPEHFBCHPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Action MABPAHOGPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HHOFMHBHMIL AEADPIDFLLK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BJDNKDKHMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7AE820", Offset = "0x7AD620", VA = "0x1807AE820", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IMONMMFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x38182F0", Offset = "0x38170F0", VA = "0x1838182F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3818060", Offset = "0x3816E60", VA = "0x183818060", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1BF98E0", Offset = "0x1BF86E0", VA = "0x181BF98E0")]
	protected OIFMKHPHHLJ(Behaviour BPEHFBCHPMI, [Optional] Action MABPAHOGPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3817F90", Offset = "0x3816D90", VA = "0x183817F90", Slot = "7")]
	public bool DOJALCOEBNB(bool HAHACPFIKHP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3817FF0", Offset = "0x3816DF0", VA = "0x183817FF0", Slot = "8")]
	public bool DOJALCOEBNB(Action PBMHOLJNIIA, bool HAHACPFIKHP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool EKGKHFAGLAA(Action PBMHOLJNIIA);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool FOCCNNJOJKC(Action PBMHOLJNIIA);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3818040", Offset = "0x3816E40", VA = "0x183818040")]
	protected void FIIEGMFOFPE(Action PBMHOLJNIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3818100", Offset = "0x3816F00", VA = "0x183818100")]
	protected DCLDNCDAGBP IGINOMDFFHN(float KHAJDANPOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3817F20", Offset = "0x3816D20", VA = "0x183817F20")]
	private void CJMMMMPOIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3817EC0", Offset = "0x3816CC0", VA = "0x183817EC0")]
	[IteratorStateMachine(typeof(OJHCPOONDNF))]
	private static IEnumerator<CMKOPAPLFOC> BFCJDMLIKHB(float KHAJDANPOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x38182D0", Offset = "0x38170D0", VA = "0x1838182D0")]
	[CompilerGenerated]
	private void PCHIFKIEJBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FHGOMAOAAHK : OIFMKHPHHLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly float JJEJNIMCEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly int DHDGPOFCNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly float NKGDLIHMGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly float[] OAPJENLKLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int LMBABEOAJMF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GACEJIHLFCE KJDLNAABGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x446670", Offset = "0x445470", VA = "0x180446670")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4BA620", Offset = "0x4B9420", VA = "0x1804BA620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3811920", Offset = "0x3810720", VA = "0x183811920")]
	public FHGOMAOAAHK(Behaviour BPEHFBCHPMI, float ONLKLOLEEHM, int DHDGPOFCNDL, [Optional] Action MABPAHOGPLP, float NKGDLIHMGHI = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x41FE40", Offset = "0x41EC40", VA = "0x18041FE40", Slot = "9")]
	protected override bool EKGKHFAGLAA(Action PBMHOLJNIIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3811670", Offset = "0x3810470", VA = "0x183811670", Slot = "10")]
	protected override bool FOCCNNJOJKC(Action PBMHOLJNIIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3811890", Offset = "0x3810690", VA = "0x183811890")]
	private void NPMPKMKCDEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BEOLNKODKMA : OIFMKHPHHLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly float KOHHFCOGMOM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x380D600", Offset = "0x380C400", VA = "0x18380D600")]
	public BEOLNKODKMA(Behaviour BPEHFBCHPMI, float KOHHFCOGMOM, [Optional] Action MABPAHOGPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x41FE40", Offset = "0x41EC40", VA = "0x18041FE40", Slot = "9")]
	protected override bool EKGKHFAGLAA(Action PBMHOLJNIIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x380D5C0", Offset = "0x380C3C0", VA = "0x18380D5C0", Slot = "10")]
	protected override bool FOCCNNJOJKC(Action PBMHOLJNIIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OEIPGINGIOG
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int HGIKFHAELHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BGKPBFIKFML : HHOFMHBHMIL, DCLDNCDAGBP, IEnumerator, CMKOPAPLFOC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HKLBFLIMHMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly HKLBFLIMHMK PFLPIOPFBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Action FGADCHJHDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private bool LKKCEJKELCO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4B7560", Offset = "0x4B6360", VA = "0x1804B7560")]
	public HKLBFLIMHMK(Action FGADCHJHDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3812190", Offset = "0x3810F90", VA = "0x183812190", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LOMCOFKCPJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	T FJILFHOHJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable EHNHMNGNCLP(Action<T> EDDPIKJFBHG);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable EHNHMNGNCLP(UnityEngine.Object BPEHFBCHPMI, Action<T> EDDPIKJFBHG);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CKPOBIKFBCN<T> : global::LOMCOFKCPJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	new T FJILFHOHJHF
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
public class EONCKHEAPMC<T> : global::CKPOBIKFBCN<T>, global::LOMCOFKCPJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OHHHKIOHMHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public global::EONCKHEAPMC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public global::NBDABCHLADD<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
		public OHHHKIOHMHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE330", Offset = "0x2BAD130", VA = "0x182BAE330")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static GameObject BFOFHMLKJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<global::NBDABCHLADD<UnityEngine.Object, Action<T>>> ODHGECDOADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T NMLIEEJLNCC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private static UnityEngine.Object FMMLHBKJMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5B10", Offset = "0x2BA4910", VA = "0x182BA5B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T FJILFHOHJHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5861D0", Offset = "0x584FD0", VA = "0x1805861D0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5180", Offset = "0x2BA3F80", VA = "0x182BA5180", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5F30", Offset = "0x2BA4D30", VA = "0x182BA5F30")]
	private static bool HCHBGMGPIEI(T IHHOGCKDEJK, T DIHLDHDCJIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6130", Offset = "0x2BA4F30", VA = "0x182BA6130")]
	public EONCKHEAPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA60A0", Offset = "0x2BA4EA0", VA = "0x182BA60A0")]
	public EONCKHEAPMC(T LCIHLDBDPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5FD0", Offset = "0x2BA4DD0", VA = "0x182BA5FD0")]
	public void MFMHGEJOKAJ(T OFHDGBDDOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA51E0", Offset = "0x2BA3FE0", VA = "0x182BA51E0", Slot = "7")]
	public IDisposable EHNHMNGNCLP(Action<T> EDDPIKJFBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5390", Offset = "0x2BA4190", VA = "0x182BA5390", Slot = "8")]
	public IDisposable EHNHMNGNCLP(UnityEngine.Object BPEHFBCHPMI, Action<T> EDDPIKJFBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2BA54D0", Offset = "0x2BA42D0", VA = "0x182BA54D0")]
	private void FJMNOIEPNHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class CAAONPJODIL
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ABGKOPOKIOL : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Scheduler.BHEMGDKDFOO queue;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public ABGKOPOKIOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x380A660", Offset = "0x3809460", VA = "0x18380A660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x380A700", Offset = "0x3809500", VA = "0x18380A700", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class NJKJKPJAPBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public DCLDNCDAGBP promise;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
		public NJKJKPJAPBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3816AD0", Offset = "0x38158D0", VA = "0x183816AD0")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class MBFPACJNPPN : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public MBFPACJNPPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3815B00", Offset = "0x3814900", VA = "0x183815B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3815BF0", Offset = "0x38149F0", VA = "0x183815BF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly CMKOPAPLFOC IANAKOCPBKB;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly CMKOPAPLFOC BPDMPCIFNIG;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly CMKOPAPLFOC NOHHNNMHOEL;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly CMKOPAPLFOC JIFKDIMCCKN;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly CMKOPAPLFOC HPMJPKHIHNC;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x380DB00", Offset = "0x380C900", VA = "0x18380DB00")]
	public static CMKOPAPLFOC EKPLCCNHMJP(float LMICLKKFALJ, Scheduler.BHEMGDKDFOO DHOBMDHCNFN = Scheduler.BHEMGDKDFOO.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x380D980", Offset = "0x380C780", VA = "0x18380D980")]
	public static CMKOPAPLFOC BPEONGPGILI(float LMICLKKFALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x380DA90", Offset = "0x380C890", VA = "0x18380DA90")]
	[IteratorStateMachine(typeof(ABGKOPOKIOL))]
	public static IEnumerator<CMKOPAPLFOC> DJMNHFIAGPP(float LMICLKKFALJ, Scheduler.BHEMGDKDFOO DHOBMDHCNFN = Scheduler.BHEMGDKDFOO.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x380DBE0", Offset = "0x380C9E0", VA = "0x18380DBE0")]
	public static CMKOPAPLFOC LIKDPJHFBBH(Func<bool> BJDJKFEAMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x380D9E0", Offset = "0x380C7E0", VA = "0x18380D9E0")]
	public static CMKOPAPLFOC DHHOKNHEJFG(DCLDNCDAGBP CDPKOIOFGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x380D930", Offset = "0x380C730", VA = "0x18380D930")]
	[IteratorStateMachine(typeof(MBFPACJNPPN))]
	public static IEnumerator<CMKOPAPLFOC> AAFBJAFDNOC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CMKOPAPLFOC
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Scheduler.BHEMGDKDFOO OCKHOFHPLLM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float JOIKKMLNCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPFCDDHMKBH();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class BBIKEIHMGMG : CMKOPAPLFOC
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class EFMGKAOEKAM : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Scheduler.BHEMGDKDFOO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private BBIKEIHMGMG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public EFMGKAOEKAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x38111C0", Offset = "0x380FFC0", VA = "0x1838111C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3811290", Offset = "0x3810090", VA = "0x183811290", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class AHIINFODLGO : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Scheduler.BHEMGDKDFOO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private BBIKEIHMGMG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public AHIINFODLGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x380C8E0", Offset = "0x380B6E0", VA = "0x18380C8E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x380C9D0", Offset = "0x380B7D0", VA = "0x18380C9D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Scheduler.BHEMGDKDFOO OCKHOFHPLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x41FE50", Offset = "0x41EC50", VA = "0x18041FE50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.BHEMGDKDFOO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x41FE60", Offset = "0x41EC60", VA = "0x18041FE60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float JOIKKMLNCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xADD8F0", Offset = "0xADC6F0", VA = "0x180ADD8F0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
	public BBIKEIHMGMG(Scheduler.BHEMGDKDFOO DHOBMDHCNFN = Scheduler.BHEMGDKDFOO.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x41FF60", Offset = "0x41ED60", VA = "0x18041FF60", Slot = "5")]
	public bool MPFCDDHMKBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x380CBF0", Offset = "0x380B9F0", VA = "0x18380CBF0")]
	public static BGKPBFIKFML GHKMOMCCHNL(Action MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x380CDF0", Offset = "0x380BBF0", VA = "0x18380CDF0")]
	public static BGKPBFIKFML GHKMOMCCHNL(Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x380CCE0", Offset = "0x380BAE0", VA = "0x18380CCE0")]
	public static BGKPBFIKFML GHKMOMCCHNL(Behaviour BPEHFBCHPMI, Action MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x380CAE0", Offset = "0x380B8E0", VA = "0x18380CAE0")]
	public static BGKPBFIKFML GHKMOMCCHNL(Behaviour BPEHFBCHPMI, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x380CFF0", Offset = "0x380BDF0", VA = "0x18380CFF0")]
	public static BGKPBFIKFML IICGLAOMCPK(MKDOFACOCGD BPEHFBCHPMI, Action MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x380CEE0", Offset = "0x380BCE0", VA = "0x18380CEE0")]
	public static BGKPBFIKFML IICGLAOMCPK(MKDOFACOCGD BPEHFBCHPMI, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x380D100", Offset = "0x380BF00", VA = "0x18380D100")]
	[IteratorStateMachine(typeof(EFMGKAOEKAM))]
	private static IEnumerator<CMKOPAPLFOC> LKFFOKCLOMB(Scheduler.BHEMGDKDFOO DHOBMDHCNFN, Action MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x380D170", Offset = "0x380BF70", VA = "0x18380D170")]
	[IteratorStateMachine(typeof(AHIINFODLGO))]
	private static IEnumerator<CMKOPAPLFOC> LKFFOKCLOMB(Scheduler.BHEMGDKDFOO DHOBMDHCNFN, Action<float> MBLHIPOKDPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IHNNFJOIJHK : CMKOPAPLFOC
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class LAPJOEDJAGH : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Scheduler.BHEMGDKDFOO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private IHNNFJOIJHK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public LAPJOEDJAGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3814C30", Offset = "0x3813A30", VA = "0x183814C30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3814DD0", Offset = "0x3813BD0", VA = "0x183814DD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly float HFEJGOFHBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private int DJKJLBPLIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly float NGJFHGGIKOK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float HEDMFOLEAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA77C40", Offset = "0xA76A40", VA = "0x180A77C40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA33070", Offset = "0xA31E70", VA = "0x180A33070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Scheduler.BHEMGDKDFOO OCKHOFHPLLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x41FC60", Offset = "0x41EA60", VA = "0x18041FC60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.BHEMGDKDFOO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4D1EB0", Offset = "0x4D0CB0", VA = "0x1804D1EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float JOIKKMLNCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAF20E0", Offset = "0xAF0EE0", VA = "0x180AF20E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAF8000", Offset = "0xAF6E00", VA = "0x180AF8000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float EPFDNACGDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xBE9220", Offset = "0xBE8020", VA = "0x180BE9220")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xBE9600", Offset = "0xBE8400", VA = "0x180BE9600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3812980", Offset = "0x3811780", VA = "0x183812980")]
	public IHNNFJOIJHK(float EBBDFEIAGMM, Scheduler.BHEMGDKDFOO DHOBMDHCNFN = Scheduler.BHEMGDKDFOO.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x38128D0", Offset = "0x38116D0", VA = "0x1838128D0", Slot = "5")]
	public bool MPFCDDHMKBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x38128F0", Offset = "0x38116F0", VA = "0x1838128F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3812620", Offset = "0x3811420", VA = "0x183812620")]
	public static BGKPBFIKFML GHKMOMCCHNL(float GJMEDEKHGOC, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x38126D0", Offset = "0x38114D0", VA = "0x1838126D0")]
	public static BGKPBFIKFML GHKMOMCCHNL(MonoBehaviour AMABGBOELAH, float GJMEDEKHGOC, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3812790", Offset = "0x3811590", VA = "0x183812790")]
	public static BGKPBFIKFML LFAIDHGBGPJ(MKDOFACOCGD BPEHFBCHPMI, float GJMEDEKHGOC, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3812850", Offset = "0x3811650", VA = "0x183812850")]
	[IteratorStateMachine(typeof(LAPJOEDJAGH))]
	private static IEnumerator<CMKOPAPLFOC> LKFFOKCLOMB(float GJMEDEKHGOC, Scheduler.BHEMGDKDFOO DHOBMDHCNFN, Action<float> MBLHIPOKDPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class BBEAIJGHJMF : CMKOPAPLFOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Func<bool> BJDJKFEAMAO;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Scheduler.BHEMGDKDFOO OCKHOFHPLLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4A0BC0", Offset = "0x49F9C0", VA = "0x1804A0BC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.BHEMGDKDFOO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4D3EC0", Offset = "0x4D2CC0", VA = "0x1804D3EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public float JOIKKMLNCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA77C40", Offset = "0xA76A40", VA = "0x180A77C40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA33070", Offset = "0xA31E70", VA = "0x180A33070")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x380CAB0", Offset = "0x380B8B0", VA = "0x18380CAB0")]
	public BBEAIJGHJMF(Func<bool> BJDJKFEAMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x380CA70", Offset = "0x380B870", VA = "0x18380CA70")]
	public BBEAIJGHJMF(Scheduler.BHEMGDKDFOO BMCKHHGOGBO, Func<bool> BJDJKFEAMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x380CA20", Offset = "0x380B820", VA = "0x18380CA20", Slot = "5")]
	public bool MPFCDDHMKBH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class GJNIBNFNJIF
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CDFNDGHICFK : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Scheduler.BHEMGDKDFOO queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public CDFNDGHICFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x380DD60", Offset = "0x380CB60", VA = "0x18380DD60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x380DE00", Offset = "0x380CC00", VA = "0x18380DE00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3811FD0", Offset = "0x3810DD0", VA = "0x183811FD0")]
	[IteratorStateMachine(typeof(CDFNDGHICFK))]
	private static IEnumerator<CMKOPAPLFOC> ALPCHMBEOIA(Scheduler.BHEMGDKDFOO BMCKHHGOGBO, Func<bool> BJDJKFEAMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3812040", Offset = "0x3810E40", VA = "0x183812040")]
	public static BGKPBFIKFML LOGFLBBECFN(this MonoBehaviour AMABGBOELAH, Func<bool> BJDJKFEAMAO, Scheduler.BHEMGDKDFOO BMCKHHGOGBO = Scheduler.BHEMGDKDFOO.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class OPIEDGECDJN : CMKOPAPLFOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly float LEGFIDPCCPL;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Scheduler.BHEMGDKDFOO OCKHOFHPLLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x442960", Offset = "0x441760", VA = "0x180442960", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.BHEMGDKDFOO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x552270", Offset = "0x551070", VA = "0x180552270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float JOIKKMLNCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA77C30", Offset = "0xA76A30", VA = "0x180A77C30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA52F30", Offset = "0xA51D30", VA = "0x180A52F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3818510", Offset = "0x3817310", VA = "0x183818510")]
	public OPIEDGECDJN(float LMICLKKFALJ, Scheduler.BHEMGDKDFOO DHOBMDHCNFN = Scheduler.BHEMGDKDFOO.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3818480", Offset = "0x3817280", VA = "0x183818480", Slot = "5")]
	public bool MPFCDDHMKBH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class EPBHGFDEBFH : CMKOPAPLFOC
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private const float MIFPEHDMGFJ = 0.1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly float OHCAOEOLOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private float BBHKCFFICNF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Scheduler.BHEMGDKDFOO OCKHOFHPLLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x44B960", Offset = "0x44A760", VA = "0x18044B960", Slot = "4")]
		get
		{
			return default(Scheduler.BHEMGDKDFOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float JOIKKMLNCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xADD8F0", Offset = "0xADC6F0", VA = "0x180ADD8F0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3454C90", Offset = "0x3453A90", VA = "0x183454C90")]
	public EPBHGFDEBFH(float LMICLKKFALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3811310", Offset = "0x3810110", VA = "0x183811310", Slot = "5")]
	public bool MPFCDDHMKBH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class PDHFMJLADPL
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class NHKLHEMLFBJ : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Scheduler.BHEMGDKDFOO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public NHKLHEMLFBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3816760", Offset = "0x3815560", VA = "0x183816760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3816810", Offset = "0x3815610", VA = "0x183816810", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class BHBONOKGHJH : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Scheduler.BHEMGDKDFOO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private CMKOPAPLFOC <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public BHBONOKGHJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x380D7E0", Offset = "0x380C5E0", VA = "0x18380D7E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x380D8A0", Offset = "0x380C6A0", VA = "0x18380D8A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3818DE0", Offset = "0x3817BE0", VA = "0x183818DE0")]
	[IteratorStateMachine(typeof(NHKLHEMLFBJ))]
	private static IEnumerator<CMKOPAPLFOC> MBIMFJBNJNM(float LMICLKKFALJ, Scheduler.BHEMGDKDFOO DHOBMDHCNFN, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3818FA0", Offset = "0x3817DA0", VA = "0x183818FA0")]
	[IteratorStateMachine(typeof(BHBONOKGHJH))]
	private static IEnumerator<CMKOPAPLFOC> NMLJFHMCCBM(float LMICLKKFALJ, Scheduler.BHEMGDKDFOO DHOBMDHCNFN, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x38185C0", Offset = "0x38173C0", VA = "0x1838185C0")]
	public static IDisposable BANGPBEGPKD(this MonoBehaviour AMABGBOELAH, float LMICLKKFALJ, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3818E60", Offset = "0x3817C60", VA = "0x183818E60")]
	public static BGKPBFIKFML MJLMDJPBMAJ(this MonoBehaviour AMABGBOELAH, float LMICLKKFALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3818700", Offset = "0x3817500", VA = "0x183818700")]
	public static BGKPBFIKFML BANGPBEGPKD(this MonoBehaviour AMABGBOELAH, float LMICLKKFALJ, Scheduler.BHEMGDKDFOO DHOBMDHCNFN, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3818850", Offset = "0x3817650", VA = "0x183818850")]
	public static BGKPBFIKFML CEEFBBJFOPK(this MonoBehaviour AMABGBOELAH, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3818DD0", Offset = "0x3817BD0", VA = "0x183818DD0")]
	public static BGKPBFIKFML LOEIDOFNFBI(this MonoBehaviour AMABGBOELAH, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3818CA0", Offset = "0x3817AA0", VA = "0x183818CA0")]
	public static BGKPBFIKFML JCMPBJCKJIO(this MonoBehaviour AMABGBOELAH, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3818CB0", Offset = "0x3817AB0", VA = "0x183818CB0")]
	public static BGKPBFIKFML KMCMOLBKANP(this MonoBehaviour AMABGBOELAH, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3819130", Offset = "0x3817F30", VA = "0x183819130")]
	public static BGKPBFIKFML PHEPGPAHKGJ(this MonoBehaviour AMABGBOELAH, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3818CC0", Offset = "0x3817AC0", VA = "0x183818CC0")]
	private static BGKPBFIKFML KMNCPBECHMG(MonoBehaviour AMABGBOELAH, Scheduler.BHEMGDKDFOO BMCKHHGOGBO, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3819020", Offset = "0x3817E20", VA = "0x183819020")]
	public static BGKPBFIKFML ODAPNCIMOIP(this MonoBehaviour AMABGBOELAH, float PINHDLKDHJC, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3818860", Offset = "0x3817660", VA = "0x183818860")]
	public static BGKPBFIKFML CJCKJIJNAIL(this MonoBehaviour AMABGBOELAH, float PINHDLKDHJC, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3818970", Offset = "0x3817770", VA = "0x183818970")]
	public static BGKPBFIKFML CKNJEICJOFC(this MonoBehaviour AMABGBOELAH, float PINHDLKDHJC, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3818B90", Offset = "0x3817990", VA = "0x183818B90")]
	public static BGKPBFIKFML IJJMPOPNDBO(this MonoBehaviour AMABGBOELAH, float PINHDLKDHJC, Action KHPICDEOPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3818A80", Offset = "0x3817880", VA = "0x183818A80")]
	public static BGKPBFIKFML GDBDFJHCAKB(this MonoBehaviour AMABGBOELAH, float PINHDLKDHJC, Action KHPICDEOPDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class PJCIMKMKEGG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class HNGIOKBKFDN : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public HNGIOKBKFDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3812280", Offset = "0x3811080", VA = "0x183812280", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3812330", Offset = "0x3811130", VA = "0x183812330", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private BGKPBFIKFML NDCEBNNMLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private MonoBehaviour AMABGBOELAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private Action MBLHIPOKDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Action<float> LECJDLDFIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Scheduler.BHEMGDKDFOO BMCKHHGOGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private float NAIPLAFNLGJ;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x381A790", Offset = "0x3819590", VA = "0x18381A790")]
	public PJCIMKMKEGG(MonoBehaviour AMABGBOELAH, Action MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x381A600", Offset = "0x3819400", VA = "0x18381A600")]
	public PJCIMKMKEGG(MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x381A4B0", Offset = "0x38192B0", VA = "0x18381A4B0")]
	public PJCIMKMKEGG(MonoBehaviour AMABGBOELAH, float GJMEDEKHGOC, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x381A150", Offset = "0x3818F50", VA = "0x18381A150")]
	private void GHKMOMCCHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3819E60", Offset = "0x3818C60", VA = "0x183819E60")]
	private void CJMDJMICBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3819D30", Offset = "0x3818B30", VA = "0x183819D30")]
	private void CCPGDMPIGFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3819FE0", Offset = "0x3818DE0", VA = "0x183819FE0")]
	private void DPFBHJMIHNG(string NBCCKCOEGPB, Action BMDKDMOKLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x381A450", Offset = "0x3819250", VA = "0x18381A450")]
	[IteratorStateMachine(typeof(HNGIOKBKFDN))]
	private IEnumerator<CMKOPAPLFOC> PNLDNJFMKOF(Action BMDKDMOKLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x381A100", Offset = "0x3818F00", VA = "0x18381A100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x381A350", Offset = "0x3819150", VA = "0x18381A350")]
	[CompilerGenerated]
	private void IDJFMKCLCPD(string ACIOKHEIABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x381A2D0", Offset = "0x38190D0", VA = "0x18381A2D0")]
	[CompilerGenerated]
	private void HCGKOIPHLHC(string ACIOKHEIABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x381A3D0", Offset = "0x38191D0", VA = "0x18381A3D0")]
	[CompilerGenerated]
	private void MECJPGPPENI(string ACIOKHEIABP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class NPPGLGJODMD
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3817330", Offset = "0x3816130", VA = "0x183817330")]
	public static IDisposable GHKMOMCCHNL(this MonoBehaviour AMABGBOELAH, Action MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3817170", Offset = "0x3815F70", VA = "0x183817170")]
	public static IDisposable GHKMOMCCHNL(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3816E20", Offset = "0x3815C20", VA = "0x183816E20")]
	public static IDisposable CCDFEFHINID(this MonoBehaviour AMABGBOELAH, Action MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3816E90", Offset = "0x3815C90", VA = "0x183816E90")]
	public static IDisposable CLFIKAECMFM(this MonoBehaviour AMABGBOELAH, Action MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x38175C0", Offset = "0x38163C0", VA = "0x1838175C0")]
	public static IDisposable KCAANEKAEEC(this MonoBehaviour AMABGBOELAH, Action MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3816DB0", Offset = "0x3815BB0", VA = "0x183816DB0")]
	public static IDisposable APFNNLOFLCH(this MonoBehaviour AMABGBOELAH, Action MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3816F80", Offset = "0x3815D80", VA = "0x183816F80")]
	public static IDisposable DILKNMHIMFF(this MonoBehaviour AMABGBOELAH, Action MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3817530", Offset = "0x3816330", VA = "0x183817530")]
	public static IDisposable IIPACMOFIPB(this MonoBehaviour AMABGBOELAH, float GJMEDEKHGOC, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x38176C0", Offset = "0x38164C0", VA = "0x1838176C0")]
	public static IDisposable KPGMOJCDDNF(this MonoBehaviour AMABGBOELAH, float GJMEDEKHGOC, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3817070", Offset = "0x3815E70", VA = "0x183817070")]
	public static IDisposable FFLDDBEMNOB(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x38177C0", Offset = "0x38165C0", VA = "0x1838177C0")]
	public static IDisposable NKNMICOJNHO(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3816FF0", Offset = "0x3815DF0", VA = "0x183816FF0")]
	public static IDisposable EIPCNNFDIPC(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3816CB0", Offset = "0x3815AB0", VA = "0x183816CB0")]
	public static IDisposable AJAEEFACKDN(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3816D30", Offset = "0x3815B30", VA = "0x183816D30")]
	public static IDisposable AOJIPFPCJFL(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x38174B0", Offset = "0x38162B0", VA = "0x1838174B0")]
	public static IDisposable HJFIDIGNPNK(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3816C20", Offset = "0x3815A20", VA = "0x183816C20")]
	public static IDisposable AEGDDJFFBMC(this MonoBehaviour AMABGBOELAH, float GJMEDEKHGOC, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x38173B0", Offset = "0x38161B0", VA = "0x1838173B0")]
	public static IDisposable HGDLJBNALNH(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3817430", Offset = "0x3816230", VA = "0x183817430")]
	public static IDisposable HJCHHFDHHKH(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3817840", Offset = "0x3816640", VA = "0x183817840")]
	public static IDisposable NNNHGJDIEMF(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3817630", Offset = "0x3816430", VA = "0x183817630")]
	public static IDisposable KHJLGPGEKLM(this MonoBehaviour AMABGBOELAH, float GJMEDEKHGOC, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x38170F0", Offset = "0x3815EF0", VA = "0x1838170F0")]
	public static IDisposable GDLAJPONLBG(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3817740", Offset = "0x3816540", VA = "0x183817740")]
	public static IDisposable MGIAPCBEKNJ(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3816F00", Offset = "0x3815D00", VA = "0x183816F00")]
	public static IDisposable CPDCJKCEDIE(this MonoBehaviour AMABGBOELAH, Action<float> MBLHIPOKDPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class PEGABKJJOMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class GEPPENGBNEO : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public GEPPENGBNEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3811ED0", Offset = "0x3810CD0", VA = "0x183811ED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3811F80", Offset = "0x3810D80", VA = "0x183811F80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private BGKPBFIKFML NDCEBNNMLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private MKDOFACOCGD BPEHFBCHPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Action MBLHIPOKDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action<float> LECJDLDFIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Scheduler.BHEMGDKDFOO BMCKHHGOGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float NAIPLAFNLGJ;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x38198C0", Offset = "0x38186C0", VA = "0x1838198C0")]
	public PEGABKJJOMP(MKDOFACOCGD BPEHFBCHPMI, Action MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3819BA0", Offset = "0x38189A0", VA = "0x183819BA0")]
	public PEGABKJJOMP(MKDOFACOCGD BPEHFBCHPMI, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3819A50", Offset = "0x3818850", VA = "0x183819A50")]
	public PEGABKJJOMP(MKDOFACOCGD BPEHFBCHPMI, float GJMEDEKHGOC, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3819560", Offset = "0x3818360", VA = "0x183819560")]
	private void GHKMOMCCHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3819270", Offset = "0x3818070", VA = "0x183819270")]
	private void CJMDJMICBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3819140", Offset = "0x3817F40", VA = "0x183819140")]
	private void CCPGDMPIGFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x38193F0", Offset = "0x38181F0", VA = "0x1838193F0")]
	private void DPFBHJMIHNG(string NBCCKCOEGPB, Action BMDKDMOKLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3819860", Offset = "0x3818660", VA = "0x183819860")]
	[IteratorStateMachine(typeof(GEPPENGBNEO))]
	private IEnumerator<CMKOPAPLFOC> PNLDNJFMKOF(Action BMDKDMOKLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3819510", Offset = "0x3818310", VA = "0x183819510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3819760", Offset = "0x3818560", VA = "0x183819760")]
	[CompilerGenerated]
	private void IDJFMKCLCPD(string ACIOKHEIABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x38196E0", Offset = "0x38184E0", VA = "0x1838196E0")]
	[CompilerGenerated]
	private void HCGKOIPHLHC(string ACIOKHEIABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x38197E0", Offset = "0x38185E0", VA = "0x1838197E0")]
	[CompilerGenerated]
	private void MECJPGPPENI(string ACIOKHEIABP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NHDCKBJJMFG
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3816290", Offset = "0x3815090", VA = "0x183816290")]
	public static IDisposable IICGLAOMCPK(this MKDOFACOCGD BPEHFBCHPMI, Action MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x38160D0", Offset = "0x3814ED0", VA = "0x1838160D0")]
	public static IDisposable IICGLAOMCPK(this MKDOFACOCGD BPEHFBCHPMI, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3816600", Offset = "0x3815400", VA = "0x183816600")]
	public static IDisposable OJCEIMBFAAC(this MKDOFACOCGD BPEHFBCHPMI, Action MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x38166F0", Offset = "0x38154F0", VA = "0x1838166F0")]
	public static IDisposable PIJIDEGKPJB(this MKDOFACOCGD BPEHFBCHPMI, Action MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3816480", Offset = "0x3815280", VA = "0x183816480")]
	public static IDisposable MCIGMJAPIBJ(this MKDOFACOCGD BPEHFBCHPMI, Action MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3816310", Offset = "0x3815110", VA = "0x183816310")]
	public static IDisposable INLLFPGEOBI(this MKDOFACOCGD BPEHFBCHPMI, Action MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3815F60", Offset = "0x3814D60", VA = "0x183815F60")]
	public static IDisposable GDNNCMBPGDD(this MKDOFACOCGD BPEHFBCHPMI, Action MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3816570", Offset = "0x3815370", VA = "0x183816570")]
	public static IDisposable OEGPADENBJI(this MKDOFACOCGD BPEHFBCHPMI, float GJMEDEKHGOC, Action<float> MBLHIPOKDPE, Scheduler.BHEMGDKDFOO BMCKHHGOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3816400", Offset = "0x3815200", VA = "0x183816400")]
	public static IDisposable LOLJINPLJGG(this MKDOFACOCGD BPEHFBCHPMI, float GJMEDEKHGOC, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3815E60", Offset = "0x3814C60", VA = "0x183815E60")]
	public static IDisposable DMDOCOHFPPA(this MKDOFACOCGD BPEHFBCHPMI, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3815FD0", Offset = "0x3814DD0", VA = "0x183815FD0")]
	public static IDisposable HFGALGNFAGP(this MKDOFACOCGD BPEHFBCHPMI, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3815D50", Offset = "0x3814B50", VA = "0x183815D50")]
	public static IDisposable DFEDFMMEPFM(this MKDOFACOCGD BPEHFBCHPMI, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3815CC0", Offset = "0x3814AC0", VA = "0x183815CC0")]
	public static IDisposable CIFIOGHCONK(this MKDOFACOCGD BPEHFBCHPMI, float GJMEDEKHGOC, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x38164F0", Offset = "0x38152F0", VA = "0x1838164F0")]
	public static IDisposable NEFOIDHJDEJ(this MKDOFACOCGD BPEHFBCHPMI, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3815C40", Offset = "0x3814A40", VA = "0x183815C40")]
	public static IDisposable BGDGGLHGFLG(this MKDOFACOCGD BPEHFBCHPMI, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3816670", Offset = "0x3815470", VA = "0x183816670")]
	public static IDisposable PALCAGLMHGM(this MKDOFACOCGD BPEHFBCHPMI, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3815DD0", Offset = "0x3814BD0", VA = "0x183815DD0")]
	public static IDisposable DIIKMKKBACA(this MKDOFACOCGD BPEHFBCHPMI, float GJMEDEKHGOC, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3816380", Offset = "0x3815180", VA = "0x183816380")]
	public static IDisposable LKFDIPLPHIL(this MKDOFACOCGD BPEHFBCHPMI, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3815EE0", Offset = "0x3814CE0", VA = "0x183815EE0")]
	public static IDisposable DPBINLIBKBJ(this MKDOFACOCGD BPEHFBCHPMI, Action<float> MBLHIPOKDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3816050", Offset = "0x3814E50", VA = "0x183816050")]
	public static IDisposable IEEEBPACKOE(this MKDOFACOCGD BPEHFBCHPMI, Action<float> MBLHIPOKDPE)
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
		private class BDLHJHOIMGH : OEIPGINGIOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public ADKGEKOBAFI OCKHOFHPLLM;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public int HGIKFHAELHK
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x41FE50", Offset = "0x41EC50", VA = "0x18041FE50", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x41FE60", Offset = "0x41EC60", VA = "0x18041FE60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x380D1E0", Offset = "0x380BFE0", VA = "0x18380D1E0")]
			public static CMKOPAPLFOC ADEMOMJLLHJ(IEnumerator<CMKOPAPLFOC> GJCACMGIICC, FJLLIDBEOGA CDPKOIOFGNI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x380D340", Offset = "0x380C140", VA = "0x18380D340")]
			public CMKOPAPLFOC ADEMOMJLLHJ(FJLLIDBEOGA[] NDIOMCALOMO, IEnumerator<CMKOPAPLFOC>[] LPKCEEKCPIJ, CMKOPAPLFOC[] PLLLBELMMIG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x380D410", Offset = "0x380C210", VA = "0x18380D410")]
			public void JJCLOIJHFNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x380D500", Offset = "0x380C300", VA = "0x18380D500")]
			public void OGHLKNLCLBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x380D440", Offset = "0x380C240", VA = "0x18380D440")]
			public void HFOGLIDDEDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x380D410", Offset = "0x380C210", VA = "0x18380D410")]
			public void BNAJALGAKOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
			public BDLHJHOIMGH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class ADKGEKOBAFI
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			public struct KKEKDFHIPOG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public BDLHJHOIMGH OPFECLADNBL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public MKDOFACOCGD CFBGHJHAKFG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public FJLLIDBEOGA HOIJJAMDKBK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public IEnumerator<CMKOPAPLFOC> NKDEJELDIDO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public CMKOPAPLFOC NEPMBKCNNKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public IBFEHJHALFM BBMNBMIHCCK;
			}

			[Cpp2IlInjected.Token(Token = "0x2000042")]
			public struct ECANNBHAPMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public BHEMGDKDFOO JGPGOCFBEPJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public List<KKEKDFHIPOG> BJEMJEOFEFP;
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class EALIODAFPGB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public ADKGEKOBAFI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public MKDOFACOCGD context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public BDLHJHOIMGH routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public IBFEHJHALFM coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public FJLLIDBEOGA promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public CMKOPAPLFOC currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public IEnumerator<CMKOPAPLFOC> coroutine;

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
				public EALIODAFPGB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017D")]
				[Cpp2IlInjected.Address(RVA = "0x3810060", Offset = "0x380EE60", VA = "0x183810060")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000044")]
			[CompilerGenerated]
			private sealed class PPOBJPBDNBA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public BDLHJHOIMGH schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public ADKGEKOBAFI <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
				public PPOBJPBDNBA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x381AD90", Offset = "0x3819B90", VA = "0x18381AD90")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class ABCPONKODLA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public BDLHJHOIMGH schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public ADKGEKOBAFI <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
				public ABCPONKODLA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x380A620", Offset = "0x3809420", VA = "0x18380A620")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000046")]
			[CompilerGenerated]
			private sealed class BKBKGPEKEEG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public BDLHJHOIMGH schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public ADKGEKOBAFI <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000182")]
				[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
				public BKBKGPEKEEG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x380D8F0", Offset = "0x380C6F0", VA = "0x18380D8F0")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private readonly BHEMGDKDFOO BMCKHHGOGBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private bool[] BGBGHNNCOHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private NativeArray<IBFEHJHALFM> ANINEPCOAMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private NativeArray<float> AMHOBIPLKEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private NativeArray<int> PKMONJDJAGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private NativeArray<int> GMALDHJDHAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private NativeArray<int> IPMMNBNDEBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private NativeArray<int> APPILADAKIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private NativeArray<int> KKKNLIBHGBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private BDLHJHOIMGH[] MIIAPGKJBBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private FJLLIDBEOGA[] NDIOMCALOMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private MKDOFACOCGD[] DPOMIFPBEJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private IEnumerator<CMKOPAPLFOC>[] FPMCMNLOFJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private CMKOPAPLFOC[] INFHBEGMFPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private int KOCAKPGOABO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int CPENFPNBDAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private readonly int EBJKLEBLOEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private float MNPJIEMKAFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private DAAJECFOKOO HJACBJJAEMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private JobHandle IMKDOGFLBBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private List<BDLHJHOIMGH> JOCLLDGLJKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool KDBGNEAJOEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private List<Action> GLJEGFJJKEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private List<Action> IEPMLHHAEJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private bool APNMAIFLCDF;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ECANNBHAPMB[] ALALJKGPNFH
			{
				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0xB88BC0", Offset = "0xB879C0", VA = "0x180B88BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public int GODNKEODPHK
			{
				[Cpp2IlInjected.Token(Token = "0x6000168")]
				[Cpp2IlInjected.Address(RVA = "0x866F60", Offset = "0x865D60", VA = "0x180866F60")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x380ABD0", Offset = "0x38099D0", VA = "0x18380ABD0")]
			private static int EIBAGINBPKL(BHEMGDKDFOO BMCKHHGOGBO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x380C410", Offset = "0x380B210", VA = "0x18380C410")]
			public ADKGEKOBAFI(BHEMGDKDFOO BMCKHHGOGBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x380B680", Offset = "0x380A480", VA = "0x18380B680")]
			private void IFCNJIINGLJ(ref int JDCJJGAEJMK, int DGJDIKHKDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x380AAA0", Offset = "0x38098A0", VA = "0x18380AAA0")]
			public void DHAPJJDADDK(MKDOFACOCGD BPEHFBCHPMI, CMKOPAPLFOC IBOCAGBECAI, IEnumerator<CMKOPAPLFOC> GJCACMGIICC, FJLLIDBEOGA CDPKOIOFGNI, [Optional] BDLHJHOIMGH BLGPPDOBGPJ, IBFEHJHALFM GPKMNCJJBNH = IBFEHJHALFM.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x380B350", Offset = "0x380A150", VA = "0x18380B350")]
			public void HAIJDCPCPDD(IEnumerable<KKEKDFHIPOG> OAFAHLJDGJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x380AF20", Offset = "0x3809D20", VA = "0x18380AF20")]
			private KKEKDFHIPOG GHBMOMKPMGE(int KIMHEFOADEI)
			{
				return default(KKEKDFHIPOG);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x380B810", Offset = "0x380A610", VA = "0x18380B810")]
			private void JGDNHKDIJIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x196FBC0", Offset = "0x196E9C0", VA = "0x18196FBC0")]
			private static void IADANLEHAOG<T>(int KIMHEFOADEI, T[] DPGKCAMCCJN, int PGNDNMPLNGG, [Optional] T NGNFDEOFHLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x196FBA0", Offset = "0x196E9A0", VA = "0x18196FBA0")]
			private static void IADANLEHAOG<T>(int KIMHEFOADEI, NativeArray<T> DPGKCAMCCJN, int PGNDNMPLNGG, [Optional] T NGNFDEOFHLG) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x380A750", Offset = "0x3809550", VA = "0x18380A750")]
			private void BHIGDJPGKJJ(IEnumerable<KKEKDFHIPOG> OAFAHLJDGJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x380B5C0", Offset = "0x380A3C0", VA = "0x18380B5C0")]
			private void IEMNMFJPKJP(KKEKDFHIPOG IEAJNPKEICM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x380AC00", Offset = "0x3809A00", VA = "0x18380AC00")]
			private IPMDEKJFADD EMMPPGHCFOH(int LIHGENKDGHL)
			{
				return default(IPMDEKJFADD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x380BBF0", Offset = "0x380A9F0", VA = "0x18380BBF0")]
			public void LJDNHIFNGKG(float BDIODCKBCOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x380B540", Offset = "0x380A340", VA = "0x18380B540")]
			private void IABFPCKOILM(Action IHHOGCKDEJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x380AEA0", Offset = "0x3809CA0", VA = "0x18380AEA0")]
			private void FGJONDEHDCF(Action IHHOGCKDEJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x380BF70", Offset = "0x380AD70", VA = "0x18380BF70")]
			public void NOPCHLNADOD(float BDIODCKBCOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x380BE90", Offset = "0x380AC90", VA = "0x18380BE90")]
			public void MLLPMCGLDML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x380A9F0", Offset = "0x38097F0", VA = "0x18380A9F0")]
			public void BNAJALGAKOB(BDLHJHOIMGH GGGGEJIMIFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x380BDE0", Offset = "0x380ABE0", VA = "0x18380BDE0")]
			public void LNAOOGANDLA(BDLHJHOIMGH GGGGEJIMIFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x380BB40", Offset = "0x380A940", VA = "0x18380BB40")]
			public void LELDCMODOGG(BDLHJHOIMGH GGGGEJIMIFL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[BurstCompile]
		public struct DAAJECFOKOO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			[ReadOnly]
			public float GOELAKENJBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			[ReadOnly]
			public int JCHDKNGELNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private NativeArray<int> NDAOLLAHGGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private NativeArray<int> CADCPOLAINH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private NativeArray<int> ACNKOLECHJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			[ReadOnly]
			public NativeArray<IBFEHJHALFM> CANFOHIOHEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			[ReadOnly]
			public NativeArray<float> CFCAIEEFDGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			[WriteOnly]
			public NativeArray<int> IPMMNBNDEBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			[WriteOnly]
			public NativeArray<int> PKMONJDJAGA;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x380F7D0", Offset = "0x380E5D0", VA = "0x18380F7D0")]
			public static DAAJECFOKOO IHJCHFBBHFH(int GJEDBPLDJMI, float BDIODCKBCOC, NativeArray<IBFEHJHALFM> CFLICJCAIBI, NativeArray<float> FABOOIBMLIK, NativeArray<int> FAFBDEEGBPG, NativeArray<int> FGDACBIIOKJ, NativeArray<int> FFDAKIPJLJI, NativeArray<int> CADCPOLAINH, NativeArray<int> ACNKOLECHJP)
			{
				return default(DAAJECFOKOO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x380F620", Offset = "0x380E420", VA = "0x18380F620", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x380F910", Offset = "0x380E710", VA = "0x18380F910")]
			private bool MFKOFBNKEFD(int LEPJFDHOFMF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x380F950", Offset = "0x380E750", VA = "0x18380F950")]
			private void NLNNDKLCEDN(NativeArray<int> PFPJBGLPKMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x380F8A0", Offset = "0x380E6A0", VA = "0x18380F8A0")]
			private int JIAEMKKPPOM(int ECOJJBFEMJG, int JNIJABGAJFO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x380F700", Offset = "0x380E500", VA = "0x18380F700")]
			private void GMABDOFICCM(NativeArray<int> PFPJBGLPKMN, int KPDBCAKADJE, int POFLHLHDNEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x380F3F0", Offset = "0x380E1F0", VA = "0x18380F3F0")]
			private void AJJIJEPBFNN(NativeArray<int> PFPJBGLPKMN, int OOPIKKICPLG, int DIAPCJDIEJG, int MFLODEPKNIE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class OAEECCJEJAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly FJLLIDBEOGA CDPKOIOFGNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Behaviour BPEHFBCHPMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly bool IMMAJEHDJOA;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public IEnumerator<CMKOPAPLFOC> NKDEJELDIDO
			{
				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(RVA = "0x41F1A0", Offset = "0x41DFA0", VA = "0x18041F1A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x41F440", Offset = "0x41E240", VA = "0x18041F440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public CMKOPAPLFOC NEPMBKCNNKA
			{
				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x41F450", Offset = "0x41E250", VA = "0x18041F450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool EJDMALAMOKP
			{
				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x3817B60", Offset = "0x3816960", VA = "0x183817B60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool MONHJGGENPD
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x590EC0", Offset = "0x58FCC0", VA = "0x180590EC0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0x143D740", Offset = "0x143C540", VA = "0x18143D740")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public string AJBFJEGGMOH
			{
				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x41FF90", Offset = "0x41ED90", VA = "0x18041FF90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x41FFA0", Offset = "0x41EDA0", VA = "0x18041FFA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public float MKHJECONGIO
			{
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0xC0A470", Offset = "0xC09270", VA = "0x180C0A470")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0xC09F60", Offset = "0xC08D60", VA = "0x180C09F60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3817D10", Offset = "0x3816B10", VA = "0x183817D10")]
			public OAEECCJEJAJ(IEnumerator<CMKOPAPLFOC> GJCACMGIICC, Behaviour BPEHFBCHPMI, FJLLIDBEOGA CDPKOIOFGNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x38178C0", Offset = "0x38166C0", VA = "0x1838178C0")]
			public CMKOPAPLFOC ADEMOMJLLHJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3817BF0", Offset = "0x38169F0", VA = "0x183817BF0")]
			public bool JABDDILHOGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3817AD0", Offset = "0x38168D0", VA = "0x183817AD0")]
			public void BNAJALGAKOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3817C80", Offset = "0x3816A80", VA = "0x183817C80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1617B50", Offset = "0x1616950", VA = "0x181617B50")]
			[CompilerGenerated]
			private void EBELEEAAPDP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private sealed class FJLLIDBEOGA : OLPBGGJOGIJ, BGKPBFIKFML, HHOFMHBHMIL, DCLDNCDAGBP, IEnumerator, CMKOPAPLFOC, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private BHEMGDKDFOO AELNMCHDNIJ;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			private BHEMGDKDFOO JNAKOMMIAAO
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x443290", Offset = "0x442090", VA = "0x180443290", Slot = "23")]
				get
				{
					return default(BHEMGDKDFOO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public BHEMGDKDFOO OCKHOFHPLLM
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x443290", Offset = "0x442090", VA = "0x180443290")]
				get
				{
					return default(BHEMGDKDFOO);
				}
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x537020", Offset = "0x535E20", VA = "0x180537020")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			private float LDAOBLCAEJP
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xADD8F0", Offset = "0xADC6F0", VA = "0x180ADD8F0", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3811DA0", Offset = "0x3810BA0", VA = "0x183811DA0", Slot = "24")]
			private bool MGICKLKJJLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3811D90", Offset = "0x3810B90", VA = "0x183811D90", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3811DC0", Offset = "0x3810BC0", VA = "0x183811DC0")]
			public FJLLIDBEOGA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private enum IPMDEKJFADD : byte
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
		private sealed class IMEHDNDJBMO : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200004C")]
			public enum JCNIBPKILGL
			{
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			public struct FODDLOAFKBK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public BHEMGDKDFOO JGPGOCFBEPJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public JCNIBPKILGL HNHIADHHEOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public List<OAEECCJEJAJ> IKGLMBJHHPL;
			}

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private static readonly JCNIBPKILGL[] BKKHMBEJCMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private readonly BHEMGDKDFOO BMCKHHGOGBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private bool MGMCJBADGGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private readonly OAEECCJEJAJ[] DECLECEEOGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private readonly List<OAEECCJEJAJ> BMKNEIGHOFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly Stack<int> MBACFCJCKKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly List<OAEECCJEJAJ> GININBFCCHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly Stack<int> CNFAMJODOOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private bool APNMAIFLCDF;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public FODDLOAFKBK[,] OJHEHOJDAKJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x432470", Offset = "0x431270", VA = "0x180432470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public int GODNKEODPHK
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x38132C0", Offset = "0x38120C0", VA = "0x1838132C0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3813EB0", Offset = "0x3812CB0", VA = "0x183813EB0")]
			public IMEHDNDJBMO(BHEMGDKDFOO DHOBMDHCNFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3813140", Offset = "0x3811F40", VA = "0x183813140")]
			public void EHJFOLAMNFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3813CD0", Offset = "0x3812AD0", VA = "0x183813CD0")]
			public void LBPINFBGPHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3813430", Offset = "0x3812230", VA = "0x183813430")]
			private void FIJCHPPBLLN(IReadOnlyList<OAEECCJEJAJ> CGHAMBCAJHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3813CE0", Offset = "0x3812AE0", VA = "0x183813CE0")]
			public void PMEHJCNNJPF(OAEECCJEJAJ GJCACMGIICC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3813550", Offset = "0x3812350", VA = "0x183813550")]
			public void GBEHINPKEKK(IList<OAEECCJEJAJ> LPKCEEKCPIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3812D80", Offset = "0x3811B80", VA = "0x183812D80")]
			public void CPOGPGHKEEE(IList<OAEECCJEJAJ> LPKCEEKCPIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3812BE0", Offset = "0x38119E0", VA = "0x183812BE0")]
			private void AOBIMCCPLDF(OAEECCJEJAJ GJCACMGIICC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3813150", Offset = "0x3811F50", VA = "0x183813150")]
			private void FEOJHLPJFAP(IList<OAEECCJEJAJ> LPKCEEKCPIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3812A60", Offset = "0x3811860", VA = "0x183812A60")]
			private IPMDEKJFADD AICDFCGPFEL(OAEECCJEJAJ GJCACMGIICC)
			{
				return default(IPMDEKJFADD);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3812CD0", Offset = "0x3811AD0", VA = "0x183812CD0")]
			public void CCDFEFHINID(float BDIODCKBCOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3813AD0", Offset = "0x38128D0", VA = "0x183813AD0")]
			public void GPALFFEDJPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x38138F0", Offset = "0x38126F0", VA = "0x1838138F0")]
			private void GEANGENIOGO(List<OAEECCJEJAJ> LPKCEEKCPIJ, Stack<int> IKBGJIFKNNA, bool ELLCCONMICJ, float BDHEMFNOAGO = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3813000", Offset = "0x3811E00", VA = "0x183813000", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x38137D0", Offset = "0x38125D0", VA = "0x1838137D0")]
			private void GDAHNKECGBC(List<OAEECCJEJAJ> LPKCEEKCPIJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[KJIEIKPEMCG]
		public enum BHEMGDKDFOO
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
		public enum IBFEHJHALFM : byte
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
		private sealed class NIPOKKDFIPP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
			[DebuggerHidden]
			public NIPOKKDFIPP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x3816860", Offset = "0x3815660", VA = "0x183816860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x38168E0", Offset = "0x38156E0", VA = "0x1838168E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private const IBFEHJHALFM HBKDAFFJKPD = IBFEHJHALFM.Cancelled | IBFEHJHALFM.Paused;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly BHEMGDKDFOO[] KGHPDKHFCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IMEHDNDJBMO[] GLPHLEBLDMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private ADKGEKOBAFI[] HBPGAJBEOJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Coroutine GMFAFJFPIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private WaitForEndOfFrame ECFMOKJMGPJ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public GACEJIHLFCE KJDLNAABGIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x41F450", Offset = "0x41E250", VA = "0x18041F450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public BHEMGDKDFOO PKDNPPPIJPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x41FC60", Offset = "0x41EA60", VA = "0x18041FC60")]
			[CompilerGenerated]
			get
			{
				return default(BHEMGDKDFOO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x4D1EB0", Offset = "0x4D0CB0", VA = "0x1804D1EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int GODNKEODPHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x381C640", Offset = "0x381B440", VA = "0x18381C640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x381B410", Offset = "0x381A210", VA = "0x18381B410")]
		public static BGKPBFIKFML GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x381ADD0", Offset = "0x3819BD0", VA = "0x18381ADD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x381B6F0", Offset = "0x381A4F0", VA = "0x18381B6F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2829A30", Offset = "0x2828830", VA = "0x182829A30")]
		private IMEHDNDJBMO HINFCDOFBBP(BHEMGDKDFOO HOBGMLIPHLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5DF380", Offset = "0x5DE180", VA = "0x1805DF380")]
		private ADKGEKOBAFI FHODIFBICLJ(BHEMGDKDFOO HOBGMLIPHLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x381BB80", Offset = "0x381A980", VA = "0x18381BB80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x381BB50", Offset = "0x381A950", VA = "0x18381BB50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x381C410", Offset = "0x381B210", VA = "0x18381C410")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x381B400", Offset = "0x381A200", VA = "0x18381B400")]
		private void GIFAGOJICIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x381B3F0", Offset = "0x381A1F0", VA = "0x18381B3F0")]
		private void GBIOAMEPIJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x381B3E0", Offset = "0x381A1E0", VA = "0x18381B3E0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x381B520", Offset = "0x381A320", VA = "0x18381B520")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x381B4B0", Offset = "0x381A2B0", VA = "0x18381B4B0")]
		private void JBDKOIPKFDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x381B4C0", Offset = "0x381A2C0", VA = "0x18381B4C0")]
		[IteratorStateMachine(typeof(NIPOKKDFIPP))]
		private IEnumerator LKLMLLFEALF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x381BD20", Offset = "0x381AB20", VA = "0x18381BD20")]
		public BGKPBFIKFML Run(IEnumerator<CMKOPAPLFOC> MNFPBGBIDHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x381BD30", Offset = "0x381AB30", VA = "0x18381BD30")]
		public BGKPBFIKFML Run(Behaviour BPEHFBCHPMI, IEnumerator<CMKOPAPLFOC> MNFPBGBIDHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x381BBF0", Offset = "0x381A9F0", VA = "0x18381BBF0")]
		public BGKPBFIKFML RunJobbed(MKDOFACOCGD BPEHFBCHPMI, IEnumerator<CMKOPAPLFOC> MNFPBGBIDHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x381B260", Offset = "0x381A060", VA = "0x18381B260")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x381C050", Offset = "0x381AE50", VA = "0x18381C050")]
		public void UpdateQueue(BHEMGDKDFOO CMEGBBIDLKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x381B530", Offset = "0x381A330", VA = "0x18381B530")]
		private void NKPDPGFNFFN(IMEHDNDJBMO MEJCFNGJKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x381B2C0", Offset = "0x381A0C0", VA = "0x18381B2C0")]
		private void EEHEIEELHGH(ADKGEKOBAFI MEJCFNGJKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x381C5C0", Offset = "0x381B3C0", VA = "0x18381C5C0")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface GACEJIHLFCE
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	float OADDNJKNBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	float EPFDNACGDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	float NEOFPIHCDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	int BHKDNMPMBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	double HFJDGNIDKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class KHDEMIKOJCB : GACEJIHLFCE
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float OADDNJKNBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3814C20", Offset = "0x3813A20", VA = "0x183814C20", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float EPFDNACGDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3814C00", Offset = "0x3813A00", VA = "0x183814C00", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float NEOFPIHCDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3814C10", Offset = "0x3813A10", VA = "0x183814C10", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int BHKDNMPMBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3814BF0", Offset = "0x38139F0", VA = "0x183814BF0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public double HFJDGNIDKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3814BD0", Offset = "0x38139D0", VA = "0x183814BD0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
	public KHDEMIKOJCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JOKNBGJDMJE : LDNMIKBEBEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public int OPFNPIPBBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Queue<double> PGECHKBKDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private double IIMBMHNGPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double MLPDICKJFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private double MDOPCFLFEMO;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int GDJECBCHHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x38144A0", Offset = "0x38132A0", VA = "0x1838144A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public double PJADHGGJEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x38145E0", Offset = "0x38133E0", VA = "0x1838145E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public double DIMENOAKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xADF370", Offset = "0xADE170", VA = "0x180ADF370", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public double JBOBKHNJJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEFF0", Offset = "0x2DFDDF0", VA = "0x182DFEFF0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3814640", Offset = "0x3813440", VA = "0x183814640")]
	public JOKNBGJDMJE(int OPGKNOMBKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x38144E0", Offset = "0x38132E0", VA = "0x1838144E0", Slot = "4")]
	public void JNHMKGEJDEG(double CLPKDFPMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3814430", Offset = "0x3813230", VA = "0x183814430", Slot = "5")]
	public void DDDPLFBPMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class BGIHANEKBHC : LDNMIKBEBEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private long NCDECDGGKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private double BIHJACCJPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private double OGKBADOJOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private double PEGLJLCJHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private double DBENBMEBJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private double IIMBMHNGPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private double MLPDICKJFFN;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long HMLDEJFKCEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x41F1A0", Offset = "0x41DFA0", VA = "0x18041F1A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public double DIMENOAKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x27849B0", Offset = "0x27837B0", VA = "0x1827849B0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public double JBOBKHNJJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x637740", Offset = "0x636540", VA = "0x180637740", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public double ALNBBMKFCID
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEFF0", Offset = "0x2DFDDF0", VA = "0x182DFEFF0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public double JLCHIJFGEDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x34FF910", Offset = "0x34FE710", VA = "0x1834FF910")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public double PJADHGGJEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEF20", Offset = "0x2DFDD20", VA = "0x182DFEF20", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x380D690", Offset = "0x380C490", VA = "0x18380D690", Slot = "4")]
	public void JNHMKGEJDEG(double CLPKDFPMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x380D650", Offset = "0x380C450", VA = "0x18380D650", Slot = "5")]
	public void DDDPLFBPMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x380D7B0", Offset = "0x380C5B0", VA = "0x18380D7B0")]
	public BGIHANEKBHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface LDNMIKBEBEP
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	double PJADHGGJEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	double DIMENOAKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	double JBOBKHNJJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNHMKGEJDEG(double CLPKDFPMGGP);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDDPLFBPMCC();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class LMOAJFMMMKE
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private interface CCHGIAIBBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool KDGGNHFGBFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OBMCLIMJLIL();

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BNAJALGAKOB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class DAHDEJLJMAG<TPromise, TMainThreadPromise> : CCHGIAIBBMJ where TPromise : DCLDNCDAGBP where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly TPromise AFEMANPKPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		protected readonly TMainThreadPromise FAGLPFLJPEE;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public TPromise LMADKMJMFDH
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2030510", Offset = "0x202F310", VA = "0x182030510")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool KDGGNHFGBFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x2030570", Offset = "0x202F370", VA = "0x182030570", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x20305F0", Offset = "0x202F3F0", VA = "0x1820305F0")]
		protected DAHDEJLJMAG(TPromise AFEMANPKPML, TMainThreadPromise EGNDKLFBDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x20305C0", Offset = "0x202F3C0", VA = "0x1820305C0", Slot = "5")]
		public void OBMCLIMJLIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1CC5760", Offset = "0x1CC4560", VA = "0x181CC5760", Slot = "6")]
		public void BNAJALGAKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void BCCCOBHIOBD(TPromise AFEMANPKPML);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void NBNKAGOHNGM();
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class EJJHKICHIMN<T> : DAHDEJLJMAG<global::BGNOPMFAGGO<T>, global::CPKBDGHLMFF<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2030D00", Offset = "0x202FB00", VA = "0x182030D00")]
		public EJJHKICHIMN(global::BGNOPMFAGGO<T> AFEMANPKPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x20309F0", Offset = "0x202F7F0", VA = "0x1820309F0", Slot = "7")]
		protected override void BCCCOBHIOBD(global::BGNOPMFAGGO<T> AFEMANPKPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2030CA0", Offset = "0x202FAA0", VA = "0x182030CA0", Slot = "8")]
		protected override void NBNKAGOHNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2030B90", Offset = "0x202F990", VA = "0x182030B90")]
		[CompilerGenerated]
		private void DPCGKHFDKIH(T IKMNANMINNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2030C10", Offset = "0x202FA10", VA = "0x182030C10")]
		[CompilerGenerated]
		private void FFHINHMJIFL(string NBCCKCOEGPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class FHBGKBGFCAE : DAHDEJLJMAG<DCLDNCDAGBP, KGMMIHKBHKP>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3811600", Offset = "0x3810400", VA = "0x183811600")]
		public FHBGKBGFCAE(DCLDNCDAGBP AFEMANPKPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x38114E0", Offset = "0x38102E0", VA = "0x1838114E0", Slot = "7")]
		protected override void BCCCOBHIOBD(DCLDNCDAGBP AFEMANPKPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x38115B0", Offset = "0x38103B0", VA = "0x1838115B0", Slot = "8")]
		protected override void NBNKAGOHNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xD430C0", Offset = "0xD41EC0", VA = "0x180D430C0")]
		[CompilerGenerated]
		private void DPCGKHFDKIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x12A4F00", Offset = "0x12A3D00", VA = "0x1812A4F00")]
		[CompilerGenerated]
		private void FFHINHMJIFL(string NBCCKCOEGPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private class NBBAKFEOPEI : CCHGIAIBBMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly Action PBMHOLJNIIA;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool KDGGNHFGBFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x41FF60", Offset = "0x41ED60", VA = "0x18041FF60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x4B7560", Offset = "0x4B6360", VA = "0x1804B7560")]
		public NBBAKFEOPEI(Action PBMHOLJNIIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x14F2570", Offset = "0x14F1370", VA = "0x1814F2570", Slot = "5")]
		public void OBMCLIMJLIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "6")]
		public void BNAJALGAKOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly List<CCHGIAIBBMJ> GPFGJEBFDPD;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x21538E0", Offset = "0x21526E0", VA = "0x1821538E0")]
	public static global::BGNOPMFAGGO<T> PNDLMHNLAJG<T>(this global::BGNOPMFAGGO<T> AFEMANPKPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3815910", Offset = "0x3814710", VA = "0x183815910")]
	public static DCLDNCDAGBP PNDLMHNLAJG(this DCLDNCDAGBP AFEMANPKPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3815A20", Offset = "0x3814820", VA = "0x183815A20")]
	public static void PNDLMHNLAJG(Action PBMHOLJNIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2153760", Offset = "0x2152560", VA = "0x182153760")]
	private static global::BGNOPMFAGGO<T> LGDPOIPPGEN<T>(global::BGNOPMFAGGO<T> AFEMANPKPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3815830", Offset = "0x3814630", VA = "0x183815830")]
	private static DCLDNCDAGBP LGDPOIPPGEN(DCLDNCDAGBP AFEMANPKPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3815650", Offset = "0x3814450", VA = "0x183815650")]
	private static void JOJCIDANINC(CCHGIAIBBMJ LHKJPIMPMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x38151B0", Offset = "0x3813FB0", VA = "0x1838151B0")]
	private static void GAPFCNHNMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x3815580", Offset = "0x3814380", VA = "0x183815580")]
	private static void JMDKBNOOGED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x38154D0", Offset = "0x38142D0", VA = "0x1838154D0")]
	private static void IHBHFFJLBLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class EFJLOEAEHLP
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class LFPBPFKFCBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public KGMMIHKBHKP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
		public LFPBPFKFCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3814E30", Offset = "0x3813C30", VA = "0x183814E30")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3814E20", Offset = "0x3813C20", VA = "0x183814E20")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class OFCLHMKENLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
		public OFCLHMKENLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3817E90", Offset = "0x3816C90", VA = "0x183817E90")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class ECIAKPJDFAO : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public KGMMIHKBHKP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public ECIAKPJDFAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x38109C0", Offset = "0x380F7C0", VA = "0x1838109C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x38106B0", Offset = "0x380F4B0", VA = "0x1838106B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3810A70", Offset = "0x380F870", VA = "0x183810A70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3810970", Offset = "0x380F770", VA = "0x183810970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class FCCFKENFMGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public KGMMIHKBHKP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
		public FCCFKENFMGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class FJAEOMJIMEK : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private CMKOPAPLFOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public KGMMIHKBHKP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private FCCFKENFMGO <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public FJAEOMJIMEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3811A30", Offset = "0x3810830", VA = "0x183811A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3811D40", Offset = "0x3810B40", VA = "0x183811D40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public const string CJPFEFMJAAG = "empty";

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public const string DKJGOBMGGPJ = "moderator";

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public const string LCKGFLIMGFE = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public const string NNDPOOGCJEK = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public const string ILFEPCALALF = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const float DJCNDGFLLLL = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static DCLDNCDAGBP HOHGBPPICKP;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static AsyncOperation JIGGAGJAPEL;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static DCLDNCDAGBP KACFMOIFCFD;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static string IKDAKHGHAHD;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static ThreadPriority EKADKCOGDFH;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public static bool DMMABFFCJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x38110C0", Offset = "0x380FEC0", VA = "0x1838110C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private static bool BJJEABFLMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3810FE0", Offset = "0x380FDE0", VA = "0x183810FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private static bool LLLOELBAGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3811160", Offset = "0x380FF60", VA = "0x183811160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<string, LoadSceneMode> FDDBGOCAJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3810B30", Offset = "0x380F930", VA = "0x183810B30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3810F30", Offset = "0x380FD30", VA = "0x183810F30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3810DF0", Offset = "0x380FBF0", VA = "0x183810DF0")]
	public static DCLDNCDAGBP JICELEBGPIE(string ENIIHFKBOGK, LoadSceneMode LNEKICBMGDD = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3810BE0", Offset = "0x380F9E0", VA = "0x183810BE0")]
	public static DCLDNCDAGBP GOBDOPJAEML(string ENIIHFKBOGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3810AC0", Offset = "0x380F8C0", VA = "0x183810AC0")]
	[IteratorStateMachine(typeof(ECIAKPJDFAO))]
	private static IEnumerator<CMKOPAPLFOC> ADMNLJLMOLK(string ENIIHFKBOGK, KGMMIHKBHKP ACDLCNDBOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3811040", Offset = "0x380FE40", VA = "0x183811040")]
	[IteratorStateMachine(typeof(FJAEOMJIMEK))]
	private static IEnumerator<CMKOPAPLFOC> MBLGPKJAIEM(string ENIIHFKBOGK, LoadSceneMode LNEKICBMGDD, KGMMIHKBHKP ACDLCNDBOKD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DLELAMAGEBO
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static byte[] GJIBIPFNGFK;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static int DIHKALOCDCB;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static int LFHDFLOBKAF;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static BigInteger FNIOAIDKCMO;

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
	public DLELAMAGEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x380FDB0", Offset = "0x380EBB0", VA = "0x18380FDB0")]
	private static string KGDDMKENHCD(byte[] DIHLDHDCJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x380FA80", Offset = "0x380E880", VA = "0x18380FA80")]
	public static string GAOFMFFNDED(byte[] PAJKEDJCHEF, bool GDFPKOHPJFN)
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
		[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
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

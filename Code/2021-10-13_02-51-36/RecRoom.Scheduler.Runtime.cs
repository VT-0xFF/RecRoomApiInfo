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
public interface EEFLKOAJPLP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MLLONMNEMBP FKCHOOLNNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MLLONMNEMBP OCAPNMABHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MLLONMNEMBP HNHGGFFIFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CFKOONJFPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KOMKNJFDNOD
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
		private delegate List<PlayerLoopSystem> PBMCLNAHFKK(List<PlayerLoopSystem> EDFGBHFEAON, int DHILFBPMLEM);

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct AKNIFIJCBKO
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct IFLEJODADIG
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static MLLONMNEMBP HMAADLGJNMD;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x3B1ABE0", Offset = "0x3B19FE0", VA = "0x183B1ABE0")]
				public static PlayerLoopSystem KJINKECMOMO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct OABINEOKKKM
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static MLLONMNEMBP CKIOBENFLNK;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x3B234A0", Offset = "0x3B228A0", VA = "0x183B234A0")]
				public static PlayerLoopSystem KJINKECMOMO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct IBFKAMJFNLD
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static MLLONMNEMBP DGNBPKGNOLK;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x3B1A3F0", Offset = "0x3B197F0", VA = "0x183B1A3F0")]
				public static PlayerLoopSystem KJINKECMOMO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			internal struct IIICDBAAEFK
			{
				[Cpp2IlInjected.Token(Token = "0x200000D")]
				[CompilerGenerated]
				private sealed class MBNFOHOIFFI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public HCDOMNFOIAM.MIKJAIHMFFC key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
					public MBNFOHOIFFI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x3B20320", Offset = "0x3B1F720", VA = "0x183B20320")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable KGKNPKNHPLA;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x3B1B610", Offset = "0x3B1AA10", VA = "0x183B1B610")]
				public static PlayerLoopSystem BICMIFFKNOA(HCDOMNFOIAM.MIKJAIHMFFC IDFIPMLKMCO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			internal struct IKCNBPCAJFM
			{
				[Cpp2IlInjected.Token(Token = "0x200000F")]
				[CompilerGenerated]
				private sealed class BCBDLHMNMIG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000D")]
					public HCDOMNFOIAM.MIKJAIHMFFC key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
					public BCBDLHMNMIG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x3B13DC0", Offset = "0x3B131C0", VA = "0x183B13DC0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x3B1B710", Offset = "0x3B1AB10", VA = "0x183B1B710")]
				public static PlayerLoopSystem BICMIFFKNOA(HCDOMNFOIAM.MIKJAIHMFFC IDFIPMLKMCO)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class BKNNOHDBFAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
			public BKNNOHDBFAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3B14160", Offset = "0x3B13560", VA = "0x183B14160")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool PEMGLDPBMCK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool FMLGAOBIBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3B15A50", Offset = "0x3B14E50", VA = "0x183B15A50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3B15F00", Offset = "0x3B15300", VA = "0x183B15F00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3B149A0", Offset = "0x3B13DA0", VA = "0x183B149A0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3B157F0", Offset = "0x3B14BF0", VA = "0x183B157F0")]
		private static void BJCLBJDFKPO(HCDOMNFOIAM.MIKJAIHMFFC IDFIPMLKMCO, ref PlayerLoopSystem AKPCEGAFBOM, Type KKMNKKDDCIC, Type FNGLEJGJCFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3B15A90", Offset = "0x3B14E90", VA = "0x183B15A90")]
		private static void KCHIDMLOMEG(ref PlayerLoopSystem AKPCEGAFBOM, Type KKMNKKDDCIC, Type FNGLEJGJCFH, PBMCLNAHFKK LHMFEAPHIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3B15E00", Offset = "0x3B15200", VA = "0x183B15E00")]
		private static void LNAIBGFBFBK(ref PlayerLoopSystem AKPCEGAFBOM, Type KKMNKKDDCIC, Type FNGLEJGJCFH, PlayerLoopSystem? POAFKDDJBON, PlayerLoopSystem? BOLDJLCFACA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HCDOMNFOIAM
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum MIKJAIHMFFC
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
	public class EADDLBFOJDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly MIKJAIHMFFC PDLGFGLJLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly EHDNBKBLIOJ PNFNCOBACEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long DAKIPLCDGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long LBCACAGOOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public long JHHDAOHHIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int HCOKDBGIEAE;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3B16510", Offset = "0x3B15910", VA = "0x183B16510")]
		public EADDLBFOJDO(MIKJAIHMFFC BBKGIFCJMMO, int GBILDEPCFGE = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3B164F0", Offset = "0x3B158F0", VA = "0x183B164F0")]
		public void JFEHIBOEEKH(int LCEJONFFAHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3B161B0", Offset = "0x3B155B0", VA = "0x183B161B0")]
		public void AAJPNJDHNOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3B16220", Offset = "0x3B15620", VA = "0x183B16220")]
		public void CJEPPAEMEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3B16280", Offset = "0x3B15680", VA = "0x183B16280")]
		public void DFBIGDKOIOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3B16450", Offset = "0x3B15850", VA = "0x183B16450")]
		public double GFPKPDEMDFH(int BPMHDCMDEDI)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int DLPNHMAOLJJ = 90;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static MIKJAIHMFFC[] BNAKNHFFHEM;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static EADDLBFOJDO[] NDBLBMPIJFB;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3B19460", Offset = "0x3B18860", VA = "0x183B19460")]
	public static EADDLBFOJDO DLCAFAKJMMB(MIKJAIHMFFC IDFIPMLKMCO, int GBILDEPCFGE = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B196A0", Offset = "0x3B18AA0", VA = "0x183B196A0")]
	public static EADDLBFOJDO HPHLNCODDFH(MIKJAIHMFFC IDFIPMLKMCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B195F0", Offset = "0x3B189F0", VA = "0x183B195F0")]
	public static void HDAPKFGLJPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GNJJFPNBNHL : PCMAMKCBOEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class JNFAEGNGDNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public GNJJFPNBNHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
		public JNFAEGNGDNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3B19840", Offset = "0x3B18C40", VA = "0x183B19840")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HFDLBDBAGLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public GNJJFPNBNHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
		public HFDLBDBAGLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3B19840", Offset = "0x3B18C40", VA = "0x183B19840")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float DODMCDCHPNE;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3B19410", Offset = "0x3B18810", VA = "0x183B19410")]
	public GNJJFPNBNHL(Behaviour AJHMKALBGLM, float DODMCDCHPNE, [Optional] Action PFLFCDMPDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3B19270", Offset = "0x3B18670", VA = "0x183B19270", Slot = "9")]
	protected override bool EBJJLEPLMMA(Action MLDCBHAMEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3B19340", Offset = "0x3B18740", VA = "0x183B19340", Slot = "10")]
	protected override bool LHCLOLODCAB(Action MLDCBHAMEIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IKECDPKCBCH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool PKFOCDDLCJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action CEEPPJACMAH;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool POKPKKEAHGH(bool IDGMBDLNCBA = false);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool POKPKKEAHGH(Action MLDCBHAMEIH, bool IDGMBDLNCBA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class PCMAMKCBOEJ : IKECDPKCBCH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class ONHALAGKAEB : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public ONHALAGKAEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3B238F0", Offset = "0x3B22CF0", VA = "0x183B238F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3B23990", Offset = "0x3B22D90", VA = "0x183B23990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Behaviour AJHMKALBGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Action PFLFCDMPDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private FKKDCBNLBGG BMGMNHNIKFB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PKFOCDDLCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x59D9E0", Offset = "0x59CDE0", VA = "0x18059D9E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CEEPPJACMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3B243B0", Offset = "0x3B237B0", VA = "0x183B243B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3B24120", Offset = "0x3B23520", VA = "0x183B24120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1666770", Offset = "0x1665B70", VA = "0x181666770")]
	protected PCMAMKCBOEJ(Behaviour AJHMKALBGLM, [Optional] Action PFLFCDMPDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B244E0", Offset = "0x3B238E0", VA = "0x183B244E0", Slot = "7")]
	public bool POKPKKEAHGH(bool IDGMBDLNCBA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B24540", Offset = "0x3B23940", VA = "0x183B24540", Slot = "8")]
	public bool POKPKKEAHGH(Action MLDCBHAMEIH, bool IDGMBDLNCBA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool EBJJLEPLMMA(Action MLDCBHAMEIH);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LHCLOLODCAB(Action MLDCBHAMEIH);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B24450", Offset = "0x3B23850", VA = "0x183B24450")]
	protected void HLLPPCBHEND(Action MLDCBHAMEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B241C0", Offset = "0x3B235C0", VA = "0x183B241C0")]
	protected GMANCKGDIIA CCLGLOGDNLC(float CAEOLOMKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B24470", Offset = "0x3B23870", VA = "0x183B24470")]
	private void INLMOOCEKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B240C0", Offset = "0x3B234C0", VA = "0x183B240C0")]
	[IteratorStateMachine(typeof(ONHALAGKAEB))]
	private static IEnumerator<JKJIBOEKIAI> BAAMCJOADHK(float CAEOLOMKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B24390", Offset = "0x3B23790", VA = "0x183B24390")]
	[CompilerGenerated]
	private void CLJLOAKOIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FHHNJOOEHLG : PCMAMKCBOEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly float JLKAAFENLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly int KFFPNDIONJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly float JMCOAPLNEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly float[] AOAGPEGEADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int OLJJJAKCFGM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LFLPEGCBCFD JCEJHCHANHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x45E610", Offset = "0x45DA10", VA = "0x18045E610")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x45B860", Offset = "0x45AC60", VA = "0x18045B860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3B17830", Offset = "0x3B16C30", VA = "0x183B17830")]
	public FHHNJOOEHLG(Behaviour AJHMKALBGLM, float OKHELJBNHBB, int KFFPNDIONJP, [Optional] Action PFLFCDMPDHP, float JMCOAPLNEJB = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x456CA0", Offset = "0x4560A0", VA = "0x180456CA0", Slot = "9")]
	protected override bool EBJJLEPLMMA(Action MLDCBHAMEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3B17580", Offset = "0x3B16980", VA = "0x183B17580", Slot = "10")]
	protected override bool LHCLOLODCAB(Action MLDCBHAMEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3B177A0", Offset = "0x3B16BA0", VA = "0x183B177A0")]
	private void LMPOLPKCAOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JCLDAEMGNFI : PCMAMKCBOEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly float DODMCDCHPNE;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B19410", Offset = "0x3B18810", VA = "0x183B19410")]
	public JCLDAEMGNFI(Behaviour AJHMKALBGLM, float DODMCDCHPNE, [Optional] Action PFLFCDMPDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x456CA0", Offset = "0x4560A0", VA = "0x180456CA0", Slot = "9")]
	protected override bool EBJJLEPLMMA(Action MLDCBHAMEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C080", Offset = "0x3B1B480", VA = "0x183B1C080", Slot = "10")]
	protected override bool LHCLOLODCAB(Action MLDCBHAMEIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FIPKPAGFPGO
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int MPBMEBCBBPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CAHNHIMGLJM : FKKDCBNLBGG, GMANCKGDIIA, IEnumerator, JKJIBOEKIAI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PHBBJMGMFGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly PHBBJMGMFGN KBMJAPGCAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Action MLCIOBOIIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private bool DNMIJNLAGMM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4B5760", Offset = "0x4B4B60", VA = "0x1804B5760")]
	public PHBBJMGMFGN(Action MLCIOBOIIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3B24750", Offset = "0x3B23B50", VA = "0x183B24750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JKMCIINMJKF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	T IGCHKCCOFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PNJEOGKFEOI(Action<T> IKMFNKCCOAI);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable PNJEOGKFEOI(UnityEngine.Object AJHMKALBGLM, Action<T> IKMFNKCCOAI);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EDGANOJLBCJ<T> : global::JKMCIINMJKF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	new T IGCHKCCOFHI
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
public class CLFJNLDPNDC<T> : global::EDGANOJLBCJ<T>, global::JKMCIINMJKF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FDJFFIPPAMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public global::CLFJNLDPNDC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public global::MCFNINDADBC<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
		public FDJFFIPPAMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2B90", Offset = "0x2FA1F90", VA = "0x182FA2B90")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static GameObject DJOJAFKFPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<global::MCFNINDADBC<UnityEngine.Object, Action<T>>> LOMHPMEJEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T OMKPBLLJFCH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private static UnityEngine.Object GIONICJNMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0520", Offset = "0x2F9F920", VA = "0x182FA0520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T IGCHKCCOFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4F8240", Offset = "0x4F7640", VA = "0x1804F8240", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2FA10C0", Offset = "0x2FA04C0", VA = "0x182FA10C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2FA0970", Offset = "0x2F9FD70", VA = "0x182FA0970")]
	private static bool HAKHELILFMB(T BJLNIHECKCH, T LPAMLJLFLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1410", Offset = "0x2FA0810", VA = "0x182FA1410")]
	public CLFJNLDPNDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2FA14D0", Offset = "0x2FA08D0", VA = "0x182FA14D0")]
	public CLFJNLDPNDC(T GJDCOJNHLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1020", Offset = "0x2FA0420", VA = "0x182FA1020")]
	public void NHOLHOLLAKI(T FFDPLJGPGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1120", Offset = "0x2FA0520", VA = "0x182FA1120", Slot = "7")]
	public IDisposable PNJEOGKFEOI(Action<T> IKMFNKCCOAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1190", Offset = "0x2FA0590", VA = "0x182FA1190", Slot = "8")]
	public IDisposable PNJEOGKFEOI(UnityEngine.Object AJHMKALBGLM, Action<T> IKMFNKCCOAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2FA0D00", Offset = "0x2FA0100", VA = "0x182FA0D00")]
	private void KDLNALAKAMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class ILLCDGGKEIK
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class OMHOIENLEKK : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Scheduler.LAEAGHBOCFG queue;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public OMHOIENLEKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3B23800", Offset = "0x3B22C00", VA = "0x183B23800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3B238A0", Offset = "0x3B22CA0", VA = "0x183B238A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class AIEBPJEAKEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public GMANCKGDIIA promise;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
		public AIEBPJEAKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3B13CE0", Offset = "0x3B130E0", VA = "0x183B13CE0")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class GNGIHPCLDPE : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public GNGIHPCLDPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3B19130", Offset = "0x3B18530", VA = "0x183B19130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3B19220", Offset = "0x3B18620", VA = "0x183B19220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly JKJIBOEKIAI IMIHHODJHAO;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly JKJIBOEKIAI MHJKLDCHBAH;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JKJIBOEKIAI KNBIMFFACOE;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly JKJIBOEKIAI OBCEMCEHGFB;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly JKJIBOEKIAI IFJJKANNEPH;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3B1B930", Offset = "0x3B1AD30", VA = "0x183B1B930")]
	public static JKJIBOEKIAI KBCDDFDDEAM(float COFIEAPBBOI, Scheduler.LAEAGHBOCFG NNPMNDMNDBB = Scheduler.LAEAGHBOCFG.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3B1BA10", Offset = "0x3B1AE10", VA = "0x183B1BA10")]
	public static JKJIBOEKIAI MLBKLHBLKBO(float COFIEAPBBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3B1B810", Offset = "0x3B1AC10", VA = "0x183B1B810")]
	[IteratorStateMachine(typeof(OMHOIENLEKK))]
	public static IEnumerator<JKJIBOEKIAI> BOOFAKHLNBE(float COFIEAPBBOI, Scheduler.LAEAGHBOCFG NNPMNDMNDBB = Scheduler.LAEAGHBOCFG.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3B1BA70", Offset = "0x3B1AE70", VA = "0x183B1BA70")]
	public static JKJIBOEKIAI OBFAEIIGAHF(Func<bool> GLAHMLAHDJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B1B880", Offset = "0x3B1AC80", VA = "0x183B1B880")]
	public static JKJIBOEKIAI DIOJGIDKLDN(GMANCKGDIIA ENNBMFPKHDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3B1BAD0", Offset = "0x3B1AED0", VA = "0x183B1BAD0")]
	[IteratorStateMachine(typeof(GNGIHPCLDPE))]
	public static IEnumerator<JKJIBOEKIAI> OOONLPBFDED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface JKJIBOEKIAI
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Scheduler.LAEAGHBOCFG FJOMCJMNPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float JJMCOAFNLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EKCEPINFOKO();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class BMGFCMNAHLE : JKJIBOEKIAI
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class GBNHODKKDFL : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Scheduler.LAEAGHBOCFG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private BMGFCMNAHLE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public GBNHODKKDFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3B19010", Offset = "0x3B18410", VA = "0x183B19010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B190E0", Offset = "0x3B184E0", VA = "0x183B190E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class PAOLHDGKNNE : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Scheduler.LAEAGHBOCFG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private BMGFCMNAHLE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public PAOLHDGKNNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3B239E0", Offset = "0x3B22DE0", VA = "0x183B239E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3B23AD0", Offset = "0x3B22ED0", VA = "0x183B23AD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Scheduler.LAEAGHBOCFG FJOMCJMNPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x48CAA0", Offset = "0x48BEA0", VA = "0x18048CAA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.LAEAGHBOCFG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4BAF70", Offset = "0x4BA370", VA = "0x1804BAF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float JJMCOAFNLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x63C070", Offset = "0x63B470", VA = "0x18063C070", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
	public BMGFCMNAHLE(Scheduler.LAEAGHBOCFG NNPMNDMNDBB = Scheduler.LAEAGHBOCFG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x44EB90", Offset = "0x44DF90", VA = "0x18044EB90", Slot = "5")]
	public bool EKCEPINFOKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3B14460", Offset = "0x3B13860", VA = "0x183B14460")]
	public static CAHNHIMGLJM BOHDHDNAOAO(Action IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3B14370", Offset = "0x3B13770", VA = "0x183B14370")]
	public static CAHNHIMGLJM BOHDHDNAOAO(Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B14260", Offset = "0x3B13660", VA = "0x183B14260")]
	public static CAHNHIMGLJM BOHDHDNAOAO(Behaviour AJHMKALBGLM, Action IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3B14550", Offset = "0x3B13950", VA = "0x183B14550")]
	public static CAHNHIMGLJM BOHDHDNAOAO(Behaviour AJHMKALBGLM, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3B14850", Offset = "0x3B13C50", VA = "0x183B14850")]
	public static CAHNHIMGLJM FJNAFOJIEAC(EEFLKOAJPLP AJHMKALBGLM, Action IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3B14740", Offset = "0x3B13B40", VA = "0x183B14740")]
	public static CAHNHIMGLJM FJNAFOJIEAC(EEFLKOAJPLP AJHMKALBGLM, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3B14660", Offset = "0x3B13A60", VA = "0x183B14660")]
	[IteratorStateMachine(typeof(GBNHODKKDFL))]
	private static IEnumerator<JKJIBOEKIAI> FBOCANJMMDF(Scheduler.LAEAGHBOCFG NNPMNDMNDBB, Action IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3B146D0", Offset = "0x3B13AD0", VA = "0x183B146D0")]
	[IteratorStateMachine(typeof(PAOLHDGKNNE))]
	private static IEnumerator<JKJIBOEKIAI> FBOCANJMMDF(Scheduler.LAEAGHBOCFG NNPMNDMNDBB, Action<float> IMLEIDACPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IOLCJPEGIHN : JKJIBOEKIAI
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BDIOALANJAO : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Scheduler.LAEAGHBOCFG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private IOLCJPEGIHN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public BDIOALANJAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3B13E80", Offset = "0x3B13280", VA = "0x183B13E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3B14020", Offset = "0x3B13420", VA = "0x183B14020", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly float NAFFBBMCNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private int LFGLCLBHHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly float BGNEDNGNOKP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float PJDGJJIAHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0F0", Offset = "0x4BA4F0", VA = "0x1804BB0F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4BB440", Offset = "0x4BA840", VA = "0x1804BB440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Scheduler.LAEAGHBOCFG FJOMCJMNPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4FCA50", Offset = "0x4FBE50", VA = "0x1804FCA50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.LAEAGHBOCFG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4FCA90", Offset = "0x4FBE90", VA = "0x1804FCA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float JJMCOAFNLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5C4020", Offset = "0x5C3420", VA = "0x1805C4020", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9B83D0", Offset = "0x9B77D0", VA = "0x1809B83D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float EAEFIGPFILB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x562280", Offset = "0x561680", VA = "0x180562280")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x561C40", Offset = "0x561040", VA = "0x180561C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3B1BFA0", Offset = "0x3B1B3A0", VA = "0x183B1BFA0")]
	public IOLCJPEGIHN(float LKLBJJFMEIB, Scheduler.LAEAGHBOCFG NNPMNDMNDBB = Scheduler.LAEAGHBOCFG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3B1BE70", Offset = "0x3B1B270", VA = "0x183B1BE70", Slot = "5")]
	public bool EKCEPINFOKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3B1BF10", Offset = "0x3B1B310", VA = "0x183B1BF10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3B1BD00", Offset = "0x3B1B100", VA = "0x183B1BD00")]
	public static CAHNHIMGLJM BOHDHDNAOAO(float AAKHKFCLNBO, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3B1BC40", Offset = "0x3B1B040", VA = "0x183B1BC40")]
	public static CAHNHIMGLJM BOHDHDNAOAO(MonoBehaviour INEDAAOOJJP, float AAKHKFCLNBO, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3B1BDB0", Offset = "0x3B1B1B0", VA = "0x183B1BDB0")]
	public static CAHNHIMGLJM CMONMNNOIIH(EEFLKOAJPLP AJHMKALBGLM, float AAKHKFCLNBO, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3B1BE90", Offset = "0x3B1B290", VA = "0x183B1BE90")]
	[IteratorStateMachine(typeof(BDIOALANJAO))]
	private static IEnumerator<JKJIBOEKIAI> FBOCANJMMDF(float AAKHKFCLNBO, Scheduler.LAEAGHBOCFG NNPMNDMNDBB, Action<float> IMLEIDACPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LKDIEFCOGAA : JKJIBOEKIAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Func<bool> GLAHMLAHDJP;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Scheduler.LAEAGHBOCFG FJOMCJMNPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4BB430", Offset = "0x4BA830", VA = "0x1804BB430", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.LAEAGHBOCFG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2F0", Offset = "0x4BA6F0", VA = "0x1804BB2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public float JJMCOAFNLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0F0", Offset = "0x4BA4F0", VA = "0x1804BB0F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4BB440", Offset = "0x4BA840", VA = "0x1804BB440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3B1EAC0", Offset = "0x3B1DEC0", VA = "0x183B1EAC0")]
	public LKDIEFCOGAA(Func<bool> GLAHMLAHDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3B1EA80", Offset = "0x3B1DE80", VA = "0x183B1EA80")]
	public LKDIEFCOGAA(Scheduler.LAEAGHBOCFG KHDBOOAPDOC, Func<bool> GLAHMLAHDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3B1EA30", Offset = "0x3B1DE30", VA = "0x183B1EA30", Slot = "5")]
	public bool EKCEPINFOKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class PFOIDPDHELG
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class BJNOLBJDJED : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Scheduler.LAEAGHBOCFG queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public BJNOLBJDJED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3B14070", Offset = "0x3B13470", VA = "0x183B14070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3B14110", Offset = "0x3B13510", VA = "0x183B14110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3B246E0", Offset = "0x3B23AE0", VA = "0x183B246E0")]
	[IteratorStateMachine(typeof(BJNOLBJDJED))]
	private static IEnumerator<JKJIBOEKIAI> LEJHAIFGBNP(Scheduler.LAEAGHBOCFG KHDBOOAPDOC, Func<bool> GLAHMLAHDJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3B24590", Offset = "0x3B23990", VA = "0x183B24590")]
	public static CAHNHIMGLJM BJMOAHCHOFK(this MonoBehaviour INEDAAOOJJP, Func<bool> GLAHMLAHDJP, Scheduler.LAEAGHBOCFG KHDBOOAPDOC = Scheduler.LAEAGHBOCFG.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class EJNEIDJJMBB : JKJIBOEKIAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly float NNNNJGBMLLK;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Scheduler.LAEAGHBOCFG FJOMCJMNPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4BB100", Offset = "0x4BA500", VA = "0x1804BB100", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.LAEAGHBOCFG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4BB450", Offset = "0x4BA850", VA = "0x1804BB450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float JJMCOAFNLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BA0", Offset = "0x6A2FA0", VA = "0x1806A3BA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7627B0", Offset = "0x761BB0", VA = "0x1807627B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3B16F00", Offset = "0x3B16300", VA = "0x183B16F00")]
	public EJNEIDJJMBB(float COFIEAPBBOI, Scheduler.LAEAGHBOCFG NNPMNDMNDBB = Scheduler.LAEAGHBOCFG.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3B16E70", Offset = "0x3B16270", VA = "0x183B16E70", Slot = "5")]
	public bool EKCEPINFOKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class KIAHADOGCGF : JKJIBOEKIAI
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private const float AIOJHDEIMLL = 0.1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly float FFAEFOBBJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private float ABIHKMKGBFF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Scheduler.LAEAGHBOCFG FJOMCJMNPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x45BC80", Offset = "0x45B080", VA = "0x18045BC80", Slot = "4")]
		get
		{
			return default(Scheduler.LAEAGHBOCFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float JJMCOAFNLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x63C070", Offset = "0x63B470", VA = "0x18063C070", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3652B40", Offset = "0x3651F40", VA = "0x183652B40")]
	public KIAHADOGCGF(float COFIEAPBBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D520", Offset = "0x3B1C920", VA = "0x183B1D520", Slot = "5")]
	public bool EKCEPINFOKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class HNFLKHMBJDN
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class ABGHGCEDKLE : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Scheduler.LAEAGHBOCFG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public ABGHGCEDKLE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3B13B80", Offset = "0x3B12F80", VA = "0x183B13B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3B13C30", Offset = "0x3B13030", VA = "0x183B13C30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class IHPDGFKCLOJ : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Scheduler.LAEAGHBOCFG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private JKJIBOEKIAI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public IHPDGFKCLOJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B500", Offset = "0x3B1A900", VA = "0x183B1B500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B5C0", Offset = "0x3B1A9C0", VA = "0x183B1B5C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A360", Offset = "0x3B19760", VA = "0x183B1A360")]
	[IteratorStateMachine(typeof(ABGHGCEDKLE))]
	private static IEnumerator<JKJIBOEKIAI> OGDPOAIKOKF(float COFIEAPBBOI, Scheduler.LAEAGHBOCFG NNPMNDMNDBB, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3B19A90", Offset = "0x3B18E90", VA = "0x183B19A90")]
	[IteratorStateMachine(typeof(IHPDGFKCLOJ))]
	private static IEnumerator<JKJIBOEKIAI> ALMCBIHONJE(float COFIEAPBBOI, Scheduler.LAEAGHBOCFG NNPMNDMNDBB, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A000", Offset = "0x3B19400", VA = "0x183B1A000")]
	public static IDisposable KDBJNKIAKNM(this MonoBehaviour INEDAAOOJJP, float COFIEAPBBOI, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3B19C40", Offset = "0x3B19040", VA = "0x183B19C40")]
	public static CAHNHIMGLJM EPLJPKAKBMC(this MonoBehaviour INEDAAOOJJP, float COFIEAPBBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3B19EB0", Offset = "0x3B192B0", VA = "0x183B19EB0")]
	public static CAHNHIMGLJM KDBJNKIAKNM(this MonoBehaviour INEDAAOOJJP, float COFIEAPBBOI, Scheduler.LAEAGHBOCFG NNPMNDMNDBB, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3B19B20", Offset = "0x3B18F20", VA = "0x183B19B20")]
	public static CAHNHIMGLJM BGAIDCPLNIO(this MonoBehaviour INEDAAOOJJP, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3B19E90", Offset = "0x3B19290", VA = "0x183B19E90")]
	public static CAHNHIMGLJM GJEGDNIJOPB(this MonoBehaviour INEDAAOOJJP, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3B19EA0", Offset = "0x3B192A0", VA = "0x183B19EA0")]
	public static CAHNHIMGLJM JBEENAHHMAG(this MonoBehaviour INEDAAOOJJP, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B19B10", Offset = "0x3B18F10", VA = "0x183B19B10")]
	public static CAHNHIMGLJM AMJOFOJMIOK(this MonoBehaviour INEDAAOOJJP, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A3E0", Offset = "0x3B197E0", VA = "0x183B1A3E0")]
	public static CAHNHIMGLJM PAJCLJCDBNA(this MonoBehaviour INEDAAOOJJP, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3B19B30", Offset = "0x3B18F30", VA = "0x183B19B30")]
	private static CAHNHIMGLJM CPJFMOPDLKH(MonoBehaviour INEDAAOOJJP, Scheduler.LAEAGHBOCFG KHDBOOAPDOC, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3B19D80", Offset = "0x3B19180", VA = "0x183B19D80")]
	public static CAHNHIMGLJM FJCABLFPJJH(this MonoBehaviour INEDAAOOJJP, float KHLGDLOOBDG, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A140", Offset = "0x3B19540", VA = "0x183B1A140")]
	public static CAHNHIMGLJM LBEFDHAKOIO(this MonoBehaviour INEDAAOOJJP, float KHLGDLOOBDG, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3B19870", Offset = "0x3B18C70", VA = "0x183B19870")]
	public static CAHNHIMGLJM ADLCEGFGEIA(this MonoBehaviour INEDAAOOJJP, float KHLGDLOOBDG, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3B19980", Offset = "0x3B18D80", VA = "0x183B19980")]
	public static CAHNHIMGLJM AJBOKOCJELB(this MonoBehaviour INEDAAOOJJP, float KHLGDLOOBDG, Action FPMIEFGBPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A250", Offset = "0x3B19650", VA = "0x183B1A250")]
	public static CAHNHIMGLJM MEDDCIPFBGL(this MonoBehaviour INEDAAOOJJP, float KHLGDLOOBDG, Action FPMIEFGBPAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class JPCOGNCKJFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class KCHKANGAIAF : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public KCHKANGAIAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D0C0", Offset = "0x3B1C4C0", VA = "0x183B1D0C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D170", Offset = "0x3B1C570", VA = "0x183B1D170", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private CAHNHIMGLJM LHMHDMBHKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private MonoBehaviour INEDAAOOJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private Action IMLEIDACPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Action<float> JPPABMANIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Scheduler.LAEAGHBOCFG KHDBOOAPDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private float DKDIHFHJBOI;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CDE0", Offset = "0x3B1C1E0", VA = "0x183B1CDE0")]
	public JPCOGNCKJFE(MonoBehaviour INEDAAOOJJP, Action IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CC50", Offset = "0x3B1C050", VA = "0x183B1CC50")]
	public JPCOGNCKJFE(MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CF70", Offset = "0x3B1C370", VA = "0x183B1CF70")]
	public JPCOGNCKJFE(MonoBehaviour INEDAAOOJJP, float AAKHKFCLNBO, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C4D0", Offset = "0x3B1B8D0", VA = "0x183B1C4D0")]
	private void BOHDHDNAOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C8F0", Offset = "0x3B1BCF0", VA = "0x183B1C8F0")]
	private void EBFIBFODJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C650", Offset = "0x3B1BA50", VA = "0x183B1C650")]
	private void CPDNJPKNMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C780", Offset = "0x3B1BB80", VA = "0x183B1C780")]
	private void DJBPPNGDLLL(string KBFLGMGIPFN, Action JPIBFPGGMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CB70", Offset = "0x3B1BF70", VA = "0x183B1CB70")]
	[IteratorStateMachine(typeof(KCHKANGAIAF))]
	private IEnumerator<JKJIBOEKIAI> LBJPHHFIJJH(Action JPIBFPGGMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C8A0", Offset = "0x3B1BCA0", VA = "0x183B1C8A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CBD0", Offset = "0x3B1BFD0", VA = "0x183B1CBD0")]
	[CompilerGenerated]
	private void LDOEMFFLMMO(string BNNOFOEFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CAF0", Offset = "0x3B1BEF0", VA = "0x183B1CAF0")]
	[CompilerGenerated]
	private void KONDMCLMNJI(string BNNOFOEFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CA70", Offset = "0x3B1BE70", VA = "0x183B1CA70")]
	[CompilerGenerated]
	private void KHPGINLAECJ(string BNNOFOEFBBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class MKFPDPLLBCG
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3B22920", Offset = "0x3B21D20", VA = "0x183B22920")]
	public static IDisposable BOHDHDNAOAO(this MonoBehaviour INEDAAOOJJP, Action IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3B22760", Offset = "0x3B21B60", VA = "0x183B22760")]
	public static IDisposable BOHDHDNAOAO(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3B22560", Offset = "0x3B21960", VA = "0x183B22560")]
	public static IDisposable APMCLKIJNBM(this MonoBehaviour INEDAAOOJJP, Action IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3B22DB0", Offset = "0x3B221B0", VA = "0x183B22DB0")]
	public static IDisposable KBEFIFJBBEG(this MonoBehaviour INEDAAOOJJP, Action IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3B22F90", Offset = "0x3B22390", VA = "0x183B22F90")]
	public static IDisposable MCJIKKDHDGI(this MonoBehaviour INEDAAOOJJP, Action IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3B22E20", Offset = "0x3B22220", VA = "0x183B22E20")]
	public static IDisposable KHMILBOEINA(this MonoBehaviour INEDAAOOJJP, Action IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3B22A20", Offset = "0x3B21E20", VA = "0x183B22A20")]
	public static IDisposable ECFEPKJDBLM(this MonoBehaviour INEDAAOOJJP, Action IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3B22CA0", Offset = "0x3B220A0", VA = "0x183B22CA0")]
	public static IDisposable IDNJBDABABK(this MonoBehaviour INEDAAOOJJP, float AAKHKFCLNBO, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3B23100", Offset = "0x3B22500", VA = "0x183B23100")]
	public static IDisposable PMKFMJDHPNJ(this MonoBehaviour INEDAAOOJJP, float AAKHKFCLNBO, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3B229A0", Offset = "0x3B21DA0", VA = "0x183B229A0")]
	public static IDisposable CEKCDJNKHLK(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3B23000", Offset = "0x3B22400", VA = "0x183B23000")]
	public static IDisposable NNEPGFLKONL(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3B226E0", Offset = "0x3B21AE0", VA = "0x183B226E0")]
	public static IDisposable BJMBDMBAICA(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3B23180", Offset = "0x3B22580", VA = "0x183B23180")]
	public static IDisposable PPICPPGJPKF(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3B22B20", Offset = "0x3B21F20", VA = "0x183B22B20")]
	public static IDisposable EIFEEPEDNML(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3B22D30", Offset = "0x3B22130", VA = "0x183B22D30")]
	public static IDisposable IKKDOAPKBNO(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3B22650", Offset = "0x3B21A50", VA = "0x183B22650")]
	public static IDisposable BIINAHMJDNF(this MonoBehaviour INEDAAOOJJP, float AAKHKFCLNBO, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3B22F10", Offset = "0x3B22310", VA = "0x183B22F10")]
	public static IDisposable LLNDOJFMNKE(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B225D0", Offset = "0x3B219D0", VA = "0x183B225D0")]
	public static IDisposable BHPHGDLJECG(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3B22C20", Offset = "0x3B22020", VA = "0x183B22C20")]
	public static IDisposable GFAHJGKODCM(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3B22A90", Offset = "0x3B21E90", VA = "0x183B22A90")]
	public static IDisposable EHHGLJPFNLH(this MonoBehaviour INEDAAOOJJP, float AAKHKFCLNBO, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3B22E90", Offset = "0x3B22290", VA = "0x183B22E90")]
	public static IDisposable LHFCEGGLOEF(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3B22BA0", Offset = "0x3B21FA0", VA = "0x183B22BA0")]
	public static IDisposable FNOFGBMNIKM(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3B23080", Offset = "0x3B22480", VA = "0x183B23080")]
	public static IDisposable OMADPHPHDJK(this MonoBehaviour INEDAAOOJJP, Action<float> IMLEIDACPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class FOIMCENEEKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class DLDPKOFLOEF : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public DLDPKOFLOEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3B15F40", Offset = "0x3B15340", VA = "0x183B15F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3B15FF0", Offset = "0x3B153F0", VA = "0x183B15FF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private CAHNHIMGLJM LHMHDMBHKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private EEFLKOAJPLP AJHMKALBGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Action IMLEIDACPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action<float> JPPABMANIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Scheduler.LAEAGHBOCFG KHDBOOAPDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float DKDIHFHJBOI;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3B183A0", Offset = "0x3B177A0", VA = "0x183B183A0")]
	public FOIMCENEEKA(EEFLKOAJPLP AJHMKALBGLM, Action IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B18210", Offset = "0x3B17610", VA = "0x183B18210")]
	public FOIMCENEEKA(EEFLKOAJPLP AJHMKALBGLM, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3B180C0", Offset = "0x3B174C0", VA = "0x183B180C0")]
	public FOIMCENEEKA(EEFLKOAJPLP AJHMKALBGLM, float AAKHKFCLNBO, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3B17940", Offset = "0x3B16D40", VA = "0x183B17940")]
	private void BOHDHDNAOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3B17D60", Offset = "0x3B17160", VA = "0x183B17D60")]
	private void EBFIBFODJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3B17AC0", Offset = "0x3B16EC0", VA = "0x183B17AC0")]
	private void CPDNJPKNMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3B17BF0", Offset = "0x3B16FF0", VA = "0x183B17BF0")]
	private void DJBPPNGDLLL(string KBFLGMGIPFN, Action JPIBFPGGMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3B17FE0", Offset = "0x3B173E0", VA = "0x183B17FE0")]
	[IteratorStateMachine(typeof(DLDPKOFLOEF))]
	private IEnumerator<JKJIBOEKIAI> LBJPHHFIJJH(Action JPIBFPGGMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3B17D10", Offset = "0x3B17110", VA = "0x183B17D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3B18040", Offset = "0x3B17440", VA = "0x183B18040")]
	[CompilerGenerated]
	private void LDOEMFFLMMO(string BNNOFOEFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3B17F60", Offset = "0x3B17360", VA = "0x183B17F60")]
	[CompilerGenerated]
	private void KONDMCLMNJI(string BNNOFOEFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3B17EE0", Offset = "0x3B172E0", VA = "0x183B17EE0")]
	[CompilerGenerated]
	private void KHPGINLAECJ(string BNNOFOEFBBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KPNAMBEJEEC
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E4D0", Offset = "0x3B1D8D0", VA = "0x183B1E4D0")]
	public static IDisposable FJNAFOJIEAC(this EEFLKOAJPLP AJHMKALBGLM, Action IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E310", Offset = "0x3B1D710", VA = "0x183B1E310")]
	public static IDisposable FJNAFOJIEAC(this EEFLKOAJPLP AJHMKALBGLM, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E8D0", Offset = "0x3B1DCD0", VA = "0x183B1E8D0")]
	public static IDisposable PADJKCHFFKO(this EEFLKOAJPLP AJHMKALBGLM, Action IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DFA0", Offset = "0x3B1D3A0", VA = "0x183B1DFA0")]
	public static IDisposable CNDHFLEOGKN(this EEFLKOAJPLP AJHMKALBGLM, Action IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E220", Offset = "0x3B1D620", VA = "0x183B1E220")]
	public static IDisposable EGDAEPJFCOF(this EEFLKOAJPLP AJHMKALBGLM, Action IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E5D0", Offset = "0x3B1D9D0", VA = "0x183B1E5D0")]
	public static IDisposable IAHJGPAAAEA(this EEFLKOAJPLP AJHMKALBGLM, Action IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E9C0", Offset = "0x3B1DDC0", VA = "0x183B1E9C0")]
	public static IDisposable PNCCGKPOELB(this EEFLKOAJPLP AJHMKALBGLM, Action IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E640", Offset = "0x3B1DA40", VA = "0x183B1E640")]
	public static IDisposable IHFMKOIJDLB(this EEFLKOAJPLP AJHMKALBGLM, float AAKHKFCLNBO, Action<float> IMLEIDACPMB, Scheduler.LAEAGHBOCFG KHDBOOAPDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E750", Offset = "0x3B1DB50", VA = "0x183B1E750")]
	public static IDisposable KCDAOHFNFMO(this EEFLKOAJPLP AJHMKALBGLM, float AAKHKFCLNBO, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E850", Offset = "0x3B1DC50", VA = "0x183B1E850")]
	public static IDisposable OBCOBOLAFJF(this EEFLKOAJPLP AJHMKALBGLM, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E120", Offset = "0x3B1D520", VA = "0x183B1E120")]
	public static IDisposable DOFPCEIGGHH(this EEFLKOAJPLP AJHMKALBGLM, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E1A0", Offset = "0x3B1D5A0", VA = "0x183B1E1A0")]
	public static IDisposable EAOGNAEKEKM(this EEFLKOAJPLP AJHMKALBGLM, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DF10", Offset = "0x3B1D310", VA = "0x183B1DF10")]
	public static IDisposable AFNFFIDOEEH(this EEFLKOAJPLP AJHMKALBGLM, float AAKHKFCLNBO, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E290", Offset = "0x3B1D690", VA = "0x183B1E290")]
	public static IDisposable FGGBBDMKGPN(this EEFLKOAJPLP AJHMKALBGLM, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E7D0", Offset = "0x3B1DBD0", VA = "0x183B1E7D0")]
	public static IDisposable NHCIJLGDOGL(this EEFLKOAJPLP AJHMKALBGLM, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E550", Offset = "0x3B1D950", VA = "0x183B1E550")]
	public static IDisposable GIOOBEHFIDB(this EEFLKOAJPLP AJHMKALBGLM, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E010", Offset = "0x3B1D410", VA = "0x183B1E010")]
	public static IDisposable DEOLCOPGDEG(this EEFLKOAJPLP AJHMKALBGLM, float AAKHKFCLNBO, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E940", Offset = "0x3B1DD40", VA = "0x183B1E940")]
	public static IDisposable PFHJIMBKCAE(this EEFLKOAJPLP AJHMKALBGLM, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E6D0", Offset = "0x3B1DAD0", VA = "0x183B1E6D0")]
	public static IDisposable JFPAKLBPANI(this EEFLKOAJPLP AJHMKALBGLM, Action<float> IMLEIDACPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E0A0", Offset = "0x3B1D4A0", VA = "0x183B1E0A0")]
	public static IDisposable DMIIGBFCPKL(this EEFLKOAJPLP AJHMKALBGLM, Action<float> IMLEIDACPMB)
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
		private class FPIABAILGJK : FIPKPAGFPGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public MHGHGLPFLNM FJOMCJMNPCJ;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public int MPBMEBCBBPA
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x48CAA0", Offset = "0x48BEA0", VA = "0x18048CAA0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x4BAF70", Offset = "0x4BA370", VA = "0x1804BAF70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3B187B0", Offset = "0x3B17BB0", VA = "0x183B187B0")]
			public static JKJIBOEKIAI LNLECIDOLLA(IEnumerator<JKJIBOEKIAI> DFAODKMMINK, AKGIEIAGFPO ENNBMFPKHDM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3B186E0", Offset = "0x3B17AE0", VA = "0x183B186E0")]
			public JKJIBOEKIAI LNLECIDOLLA(AKGIEIAGFPO[] JJPHNCFBGDB, IEnumerator<JKJIBOEKIAI>[] NEAEKEICODA, JKJIBOEKIAI[] OKMBNOPHJGO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3B185F0", Offset = "0x3B179F0", VA = "0x183B185F0")]
			public void EAIKLFOGLON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3B18620", Offset = "0x3B17A20", VA = "0x183B18620")]
			public void DPLHLNPGHFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3B18530", Offset = "0x3B17930", VA = "0x183B18530")]
			public void DFKIEOIENFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3B185F0", Offset = "0x3B179F0", VA = "0x183B185F0")]
			public void DLONFMLMKBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
			public FPIABAILGJK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class MHGHGLPFLNM
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			public struct MNDFMBNDKBG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public FPIABAILGJK AFBFCBFJOGH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public EEFLKOAJPLP KDILKFFFNLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public AKGIEIAGFPO DGFJNOMLNMO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public IEnumerator<JKJIBOEKIAI> NIOFCLEEDCC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public JKJIBOEKIAI CGPLPGAPDEO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public NFLPGIOKBGO CGJDIBBEMKH;
			}

			[Cpp2IlInjected.Token(Token = "0x2000042")]
			public struct HGHIPIPGFMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public LAEAGHBOCFG PHLJOGEPJPI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public List<MNDFMBNDKBG> JJJOJIFIBGH;
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class IDLBAHKEDHB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public MHGHGLPFLNM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public EEFLKOAJPLP context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public FPIABAILGJK routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public NFLPGIOKBGO coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public AKGIEIAGFPO promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public JKJIBOEKIAI currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public IEnumerator<JKJIBOEKIAI> coroutine;

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
				public IDLBAHKEDHB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017D")]
				[Cpp2IlInjected.Address(RVA = "0x3B1A590", Offset = "0x3B19990", VA = "0x183B1A590")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000044")]
			[CompilerGenerated]
			private sealed class CHFJCHDOIGE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public FPIABAILGJK schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public MHGHGLPFLNM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
				public CHFJCHDOIGE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x3B14960", Offset = "0x3B13D60", VA = "0x183B14960")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class EACAKHDOKBC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public FPIABAILGJK schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public MHGHGLPFLNM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
				public EACAKHDOKBC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x3B16170", Offset = "0x3B15570", VA = "0x183B16170")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000046")]
			[CompilerGenerated]
			private sealed class NPPEDGHLFFJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public FPIABAILGJK schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public MHGHGLPFLNM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000182")]
				[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
				public NPPEDGHLFFJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x3B23460", Offset = "0x3B22860", VA = "0x183B23460")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private readonly LAEAGHBOCFG KHDBOOAPDOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private bool[] MLOCHLLKPDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private NativeArray<NFLPGIOKBGO> OCDKHJHEJKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private NativeArray<float> BPAHMMPIIGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private NativeArray<int> OIJKOJPFIEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private NativeArray<int> MJJPHBOEJMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private NativeArray<int> JCPFGFLKACO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private NativeArray<int> MMLNKDKCCIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private NativeArray<int> IHFEJHIMEOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private FPIABAILGJK[] JGBPOJPFAEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private AKGIEIAGFPO[] JJPHNCFBGDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private EEFLKOAJPLP[] ELLGGHLEPOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private IEnumerator<JKJIBOEKIAI>[] HMDGHFICHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private JKJIBOEKIAI[] JNAPNFKMGIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private int AOAGHEABCLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int MFPOMLBLLBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private readonly int DBEACEFAEBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private float KCGKBADNHKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private IGIDJCFKLOG MOJAGIIGAOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private JobHandle PBPDMADGGGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private List<FPIABAILGJK> PGIJHEJKBFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool MKJDCLBGEJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private List<Action> PIFDDFINNLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private List<Action> IFMMPOJFJIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private bool MLBFNLKKCHI;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public HGHIPIPGFMB[] LHKLOINEJAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0x46EBF0", Offset = "0x46DFF0", VA = "0x18046EBF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public int PEKLAPJLGAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000168")]
				[Cpp2IlInjected.Address(RVA = "0x5C8310", Offset = "0x5C7710", VA = "0x1805C8310")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3B20670", Offset = "0x3B1FA70", VA = "0x183B20670")]
			private static int CNINFLAJIND(LAEAGHBOCFG KHDBOOAPDOC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3B22090", Offset = "0x3B21490", VA = "0x183B22090")]
			public MHGHGLPFLNM(LAEAGHBOCFG KHDBOOAPDOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3B21A80", Offset = "0x3B20E80", VA = "0x183B21A80")]
			private void MCPAFFBIONK(ref int MHIDDPLDAIM, int OCGGJNPCFGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x3B21E00", Offset = "0x3B21200", VA = "0x183B21E00")]
			public void MMINEOPODDB(EEFLKOAJPLP AJHMKALBGLM, JKJIBOEKIAI CMCIBKDGNKH, IEnumerator<JKJIBOEKIAI> DFAODKMMINK, AKGIEIAGFPO ENNBMFPKHDM, [Optional] FPIABAILGJK DODPCBIBMAM, NFLPGIOKBGO CDNABLEKAPI = NFLPGIOKBGO.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x3B217E0", Offset = "0x3B20BE0", VA = "0x183B217E0")]
			public void JJMMDOHJGNM(IEnumerable<MNDFMBNDKBG> MJCBKFAOIIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3B213B0", Offset = "0x3B207B0", VA = "0x183B213B0")]
			private MNDFMBNDKBG JBHKMEBHKAC(int MHALAEPNECG)
			{
				return default(MNDFMBNDKBG);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x3B20F40", Offset = "0x3B20340", VA = "0x183B20F40")]
			private void HLDHLKALDKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1355A00", Offset = "0x1354E00", VA = "0x181355A00")]
			private static void ODKBKIPNBBP<T>(int MHALAEPNECG, T[] LDMLBMHHEID, int JKPCFCCBIBE, [Optional] T LMBONPGPAAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x13559E0", Offset = "0x1354DE0", VA = "0x1813559E0")]
			private static void ODKBKIPNBBP<T>(int MHALAEPNECG, NativeArray<T> LDMLBMHHEID, int JKPCFCCBIBE, [Optional] T LMBONPGPAAF) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x3B20BF0", Offset = "0x3B1FFF0", VA = "0x183B20BF0")]
			private void DIILHILNBDB(IEnumerable<MNDFMBNDKBG> MJCBKFAOIIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3B21270", Offset = "0x3B20670", VA = "0x183B21270")]
			private void HPFOLPMJNLN(MNDFMBNDKBG KIFAAHBLCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x3B203D0", Offset = "0x3B1F7D0", VA = "0x183B203D0")]
			private FDAOOCPMPLP BNDCGMHNFAL(int KIHGFBKEEDI)
			{
				return default(FDAOOCPMPLP);
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x3B21C10", Offset = "0x3B21010", VA = "0x183B21C10")]
			public void MDALCCELCPC(float HDEBOEFKIAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3B22010", Offset = "0x3B21410", VA = "0x183B22010")]
			private void PPEHCIKIOOM(Action BJLNIHECKCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3B21330", Offset = "0x3B20730", VA = "0x183B21330")]
			private void IFDNMJGEPGH(Action BJLNIHECKCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x3B20750", Offset = "0x3B1FB50", VA = "0x183B20750")]
			public void DHKLHGEFGEK(float HDEBOEFKIAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x3B21F30", Offset = "0x3B21330", VA = "0x183B21F30")]
			public void OCOMLAAOFCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3B20E90", Offset = "0x3B20290", VA = "0x183B20E90")]
			public void DLONFMLMKBD(FPIABAILGJK KGNKKBKCBKB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3B206A0", Offset = "0x3B1FAA0", VA = "0x183B206A0")]
			public void DDKCFFFPNJB(FPIABAILGJK KGNKKBKCBKB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3B219D0", Offset = "0x3B20DD0", VA = "0x183B219D0")]
			public void LDBDCMLCCPK(FPIABAILGJK KGNKKBKCBKB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[BurstCompile]
		public struct IGIDJCFKLOG : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			[ReadOnly]
			public float KOCFADLJFOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			[ReadOnly]
			public int GCJNGMJFPCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private NativeArray<int> EFIKJOMJGLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private NativeArray<int> GHJJDMKNEIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private NativeArray<int> FHNLGLPDJGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			[ReadOnly]
			public NativeArray<NFLPGIOKBGO> HIICEKNOLEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			[ReadOnly]
			public NativeArray<float> CNFLEMAPHJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			[WriteOnly]
			public NativeArray<int> JCPFGFLKACO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			[WriteOnly]
			public NativeArray<int> OIJKOJPFIEP;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3B1B190", Offset = "0x3B1A590", VA = "0x183B1B190")]
			public static IGIDJCFKLOG LFIKOCHGCKP(int MNGJIACCNFH, float HDEBOEFKIAA, NativeArray<NFLPGIOKBGO> JMNMKFPPGPB, NativeArray<float> DGAAMAIEGJM, NativeArray<int> PELDPJOFPJA, NativeArray<int> BKCNLJKIPCP, NativeArray<int> LHPEEKFANKG, NativeArray<int> GHJJDMKNEIP, NativeArray<int> FHNLGLPDJGH)
			{
				return default(IGIDJCFKLOG);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3B1AD80", Offset = "0x3B1A180", VA = "0x183B1AD80", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x3B1B2D0", Offset = "0x3B1A6D0", VA = "0x183B1B2D0")]
			private bool OMDMCNIHIGO(int NBHNFEGDDAF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x3B1AE60", Offset = "0x3B1A260", VA = "0x183B1AE60")]
			private void HIMLKAPJBHM(NativeArray<int> MKPICHIONJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3B1B260", Offset = "0x3B1A660", VA = "0x183B1B260")]
			private int MOLCJDFOGEI(int OOIMNBMBIID, int DNIAAACEEKN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3B1B0C0", Offset = "0x3B1A4C0", VA = "0x183B1B0C0")]
			private void LDPNNBHEEEP(NativeArray<int> MKPICHIONJN, int BFIHEOFNMBN, int MDIMKDGJGJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3B1AE90", Offset = "0x3B1A290", VA = "0x183B1AE90")]
			private void KFLKJHBDMCG(NativeArray<int> MKPICHIONJN, int DHNCPOADCAA, int KGBBOBKCMDK, int IJHALAMHAGP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class FDNJFGALAKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly AKGIEIAGFPO ENNBMFPKHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Behaviour AJHMKALBGLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly bool MBILCKKNAOO;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public IEnumerator<JKJIBOEKIAI> NIOFCLEEDCC
			{
				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x472460", Offset = "0x471860", VA = "0x180472460")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public JKJIBOEKIAI CGPLPGAPDEO
			{
				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x4F88B0", Offset = "0x4F7CB0", VA = "0x1804F88B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool BLHEPDJFAKG
			{
				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x3B17040", Offset = "0x3B16440", VA = "0x183B17040")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool NHLOJLLFKCC
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x769F50", Offset = "0x769350", VA = "0x180769F50")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0xB205F0", Offset = "0xB1F9F0", VA = "0x180B205F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public string MNDPCPBJDAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x48E130", Offset = "0x48D530", VA = "0x18048E130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x48DA90", Offset = "0x48CE90", VA = "0x18048DA90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public float PMOJPFKMENP
			{
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x5B6160", Offset = "0x5B5560", VA = "0x1805B6160")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x5B6190", Offset = "0x5B5590", VA = "0x1805B6190")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3B17400", Offset = "0x3B16800", VA = "0x183B17400")]
			public FDNJFGALAKC(IEnumerator<JKJIBOEKIAI> DFAODKMMINK, Behaviour AJHMKALBGLM, AKGIEIAGFPO ENNBMFPKHDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x3B17160", Offset = "0x3B16560", VA = "0x183B17160")]
			public JKJIBOEKIAI LNLECIDOLLA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3B170D0", Offset = "0x3B164D0", VA = "0x183B170D0")]
			public bool KEELGINAAAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3B16FB0", Offset = "0x3B163B0", VA = "0x183B16FB0")]
			public void DLONFMLMKBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3B17370", Offset = "0x3B16770", VA = "0x183B17370", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x104EF40", Offset = "0x104E340", VA = "0x18104EF40")]
			[CompilerGenerated]
			private void GPHNAHABKML()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private sealed class AKGIEIAGFPO : OBPKIBFDMCK, CAHNHIMGLJM, FKKDCBNLBGG, GMANCKGDIIA, IEnumerator, JKJIBOEKIAI, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private LAEAGHBOCFG JNNFOOLKCBF;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			private LAEAGHBOCFG LFFGOHCGLMF
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x4E21C0", Offset = "0x4E15C0", VA = "0x1804E21C0", Slot = "23")]
				get
				{
					return default(LAEAGHBOCFG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public LAEAGHBOCFG FJOMCJMNPCJ
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x4E21C0", Offset = "0x4E15C0", VA = "0x1804E21C0")]
				get
				{
					return default(LAEAGHBOCFG);
				}
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x6908F0", Offset = "0x68FCF0", VA = "0x1806908F0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			private float NDCEADEFMMK
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x63C070", Offset = "0x63B470", VA = "0x18063C070", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3B13D40", Offset = "0x3B13140", VA = "0x183B13D40", Slot = "24")]
			private bool PBOEJEBHGJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3B13D30", Offset = "0x3B13130", VA = "0x183B13D30", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3B13D60", Offset = "0x3B13160", VA = "0x183B13D60")]
			public AKGIEIAGFPO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private enum FDAOOCPMPLP : byte
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
		private sealed class LNFKNAPGNMJ : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200004C")]
			public enum ENALLCMNEFG
			{
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			public struct ICFPOPPNHCJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public LAEAGHBOCFG PHLJOGEPJPI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public ENALLCMNEFG IBPMOLBDBDG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public List<FDNJFGALAKC> ILMHINHJNLP;
			}

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private static readonly ENALLCMNEFG[] ECACFLMKMGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private readonly LAEAGHBOCFG KHDBOOAPDOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private bool CDEIAHOLNMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private readonly FDNJFGALAKC[] PNADEFJCHIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private readonly List<FDNJFGALAKC> OINMIHDJMGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly Stack<int> CPFEJFEIPEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly List<FDNJFGALAKC> LAJKPFAAOCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly Stack<int> OOKCJHEBAIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private bool MLBFNLKKCHI;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public ICFPOPPNHCJ[,] AEFPEGPDHIO
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x49A870", Offset = "0x499C70", VA = "0x18049A870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public int PEKLAPJLGAH
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x3B1FD00", Offset = "0x3B1F100", VA = "0x183B1FD00")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3B1FF40", Offset = "0x3B1F340", VA = "0x183B1FF40")]
			public LNFKNAPGNMJ(LAEAGHBOCFG NNPMNDMNDBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3B1F5F0", Offset = "0x3B1E9F0", VA = "0x183B1F5F0")]
			public void HNFDFLMJDGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3B1FCF0", Offset = "0x3B1F0F0", VA = "0x183B1FCF0")]
			public void NDHMBIOBMLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3B1F1F0", Offset = "0x3B1E5F0", VA = "0x183B1F1F0")]
			private void GNGBBCPDHAL(IReadOnlyList<FDNJFGALAKC> OCIHGOMOBPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3B1F4F0", Offset = "0x3B1E8F0", VA = "0x183B1F4F0")]
			public void HHDONAGGBJF(FDNJFGALAKC DFAODKMMINK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3B1EF70", Offset = "0x3B1E370", VA = "0x183B1EF70")]
			public void FIJGKPLMJDC(IList<FDNJFGALAKC> NEAEKEICODA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3B1FA70", Offset = "0x3B1EE70", VA = "0x183B1FA70")]
			public void MJJOIMEDCDH(IList<FDNJFGALAKC> NEAEKEICODA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3B1F600", Offset = "0x3B1EA00", VA = "0x183B1F600")]
			private void ILBPFGKGLGA(FDNJFGALAKC DFAODKMMINK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3B1ECC0", Offset = "0x3B1E0C0", VA = "0x183B1ECC0")]
			private void DJPGIAONMHA(IList<FDNJFGALAKC> NEAEKEICODA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3B1F6F0", Offset = "0x3B1EAF0", VA = "0x183B1F6F0")]
			private FDAOOCPMPLP JIBEEKAGCCO(FDNJFGALAKC DFAODKMMINK)
			{
				return default(FDAOOCPMPLP);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3B1EAF0", Offset = "0x3B1DEF0", VA = "0x183B1EAF0")]
			public void APMCLKIJNBM(float HDEBOEFKIAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3B1F870", Offset = "0x3B1EC70", VA = "0x183B1F870")]
			public void MBEGPPDIFEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3B1F310", Offset = "0x3B1E710", VA = "0x183B1F310")]
			private void GNJNOMNNNGF(List<FDNJFGALAKC> NEAEKEICODA, Stack<int> HJKKHKCIDBO, bool CPCOOBEJAJN, float MCAIAAGJIKA = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3B1EE30", Offset = "0x3B1E230", VA = "0x183B1EE30", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x3B1EBA0", Offset = "0x3B1DFA0", VA = "0x183B1EBA0")]
			private void CACAENELKAL(List<FDNJFGALAKC> NEAEKEICODA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[GLNMIDMOKFP]
		public enum LAEAGHBOCFG
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
		public enum NFLPGIOKBGO : byte
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
		private sealed class MOCKKPHEAFF : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
			[DebuggerHidden]
			public MOCKKPHEAFF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x3B23200", Offset = "0x3B22600", VA = "0x183B23200", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3B23280", Offset = "0x3B22680", VA = "0x183B23280", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private const NFLPGIOKBGO MBIINHAGHCD = NFLPGIOKBGO.Cancelled | NFLPGIOKBGO.Paused;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly LAEAGHBOCFG[] INKJLOIHBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private LNFKNAPGNMJ[] JGLLLLAFGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private MHGHGLPFLNM[] LACEECHJAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Coroutine EJINOGPKEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private WaitForEndOfFrame ONOLLODIKCA;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public LFLPEGCBCFD JCEJHCHANHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x4F88B0", Offset = "0x4F7CB0", VA = "0x1804F88B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public LAEAGHBOCFG LMBNCKGKHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4FCA50", Offset = "0x4FBE50", VA = "0x1804FCA50")]
			[CompilerGenerated]
			get
			{
				return default(LAEAGHBOCFG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x4FCA90", Offset = "0x4FBE90", VA = "0x1804FCA90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int PEKLAPJLGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x3B260B0", Offset = "0x3B254B0", VA = "0x183B260B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3B24E80", Offset = "0x3B24280", VA = "0x183B24E80")]
		public static CAHNHIMGLJM GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3B24840", Offset = "0x3B23C40", VA = "0x183B24840", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3B25160", Offset = "0x3B24560", VA = "0x183B25160", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x26113E0", Offset = "0x26107E0", VA = "0x1826113E0")]
		private LNFKNAPGNMJ BIIEKMGJGJL(LAEAGHBOCFG ENGLKMHLBKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x26DD8F0", Offset = "0x26DCCF0", VA = "0x1826DD8F0")]
		private MHGHGLPFLNM GKHICABGOML(LAEAGHBOCFG ENGLKMHLBKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3B255F0", Offset = "0x3B249F0", VA = "0x183B255F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3B255C0", Offset = "0x3B249C0", VA = "0x183B255C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3B25E80", Offset = "0x3B25280", VA = "0x183B25E80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3B24F20", Offset = "0x3B24320", VA = "0x183B24F20")]
		private void HMAADLGJNMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3B24DF0", Offset = "0x3B241F0", VA = "0x183B24DF0")]
		private void CKIOBENFLNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3B24E70", Offset = "0x3B24270", VA = "0x183B24E70")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3B25150", Offset = "0x3B24550", VA = "0x183B25150")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3B24E60", Offset = "0x3B24260", VA = "0x183B24E60")]
		private void DGNBPKGNOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3B250F0", Offset = "0x3B244F0", VA = "0x183B250F0")]
		[IteratorStateMachine(typeof(MOCKKPHEAFF))]
		private IEnumerator JCJJFPMDLDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3B25790", Offset = "0x3B24B90", VA = "0x183B25790")]
		public CAHNHIMGLJM Run(IEnumerator<JKJIBOEKIAI> AMGFIIBAGID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3B257A0", Offset = "0x3B24BA0", VA = "0x183B257A0")]
		public CAHNHIMGLJM Run(Behaviour AJHMKALBGLM, IEnumerator<JKJIBOEKIAI> AMGFIIBAGID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3B25660", Offset = "0x3B24A60", VA = "0x183B25660")]
		public CAHNHIMGLJM RunJobbed(EEFLKOAJPLP AJHMKALBGLM, IEnumerator<JKJIBOEKIAI> AMGFIIBAGID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3B24E00", Offset = "0x3B24200", VA = "0x183B24E00")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3B25AC0", Offset = "0x3B24EC0", VA = "0x183B25AC0")]
		public void UpdateQueue(LAEAGHBOCFG HDBNFOJELMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3B24F30", Offset = "0x3B24330", VA = "0x183B24F30")]
		private void IIGPICNFJCG(LNFKNAPGNMJ PHCBBGNAHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3B24CD0", Offset = "0x3B240D0", VA = "0x183B24CD0")]
		private void BKGKEEBCNGC(MHGHGLPFLNM PHCBBGNAHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3B26030", Offset = "0x3B25430", VA = "0x183B26030")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface LFLPEGCBCFD
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	float PCFHDENNJPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	float EAEFIGPFILB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	float DLKLNOPLAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	int NAHPMPKBEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	double PLPOLAMAPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class ACLGEPDJMPP : LFLPEGCBCFD
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float PCFHDENNJPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3B13CD0", Offset = "0x3B130D0", VA = "0x183B13CD0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float EAEFIGPFILB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3B13C80", Offset = "0x3B13080", VA = "0x183B13C80", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float DLKLNOPLAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3B13C90", Offset = "0x3B13090", VA = "0x183B13C90", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int NAHPMPKBEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3B13CA0", Offset = "0x3B130A0", VA = "0x183B13CA0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public double PLPOLAMAPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3B13CB0", Offset = "0x3B130B0", VA = "0x183B13CB0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
	public ACLGEPDJMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class EHDNBKBLIOJ : HFAGCMAOAMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public int CHPPKLICNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Queue<double> NBBHHDGNMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private double KLLGNKIHOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double NMCPEPAMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private double CGLAPCAGMGH;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int NCIBOPEGJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3B16BD0", Offset = "0x3B15FD0", VA = "0x183B16BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public double MJCIMGLOLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3B16D80", Offset = "0x3B16180", VA = "0x183B16D80", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public double ADKAPEBCCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C50", Offset = "0x7D6050", VA = "0x1807D6C50", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public double BOONALDPKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2E5B3B0", Offset = "0x2E5A7B0", VA = "0x182E5B3B0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3B16DE0", Offset = "0x3B161E0", VA = "0x183B16DE0")]
	public EHDNBKBLIOJ(int NKDGLDFGEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3B16C80", Offset = "0x3B16080", VA = "0x183B16C80", Slot = "4")]
	public void MPHDIOFCAJP(double BDAHFCMEKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3B16C10", Offset = "0x3B16010", VA = "0x183B16C10", Slot = "5")]
	public void KPKFLEKCHKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class NLFFLMKIJHE : HFAGCMAOAMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private long FHFJLIAMIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private double MJBALCDNMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private double LPHFIOJHJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private double CHPCMEIEMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private double PCFAGNENBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private double KLLGNKIHOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private double NMCPEPAMBEG;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long AMPKIFMGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public double ADKAPEBCCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x23ECEC0", Offset = "0x23EC2C0", VA = "0x1823ECEC0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public double BOONALDPKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x27F8940", Offset = "0x27F7D40", VA = "0x1827F8940", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public double DGGKCBEKBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2E5B3B0", Offset = "0x2E5A7B0", VA = "0x182E5B3B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public double KPLHBEAGNDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x374D590", Offset = "0x374C990", VA = "0x18374D590")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public double MJCIMGLOLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2E5B2E0", Offset = "0x2E5A6E0", VA = "0x182E5B2E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3B23310", Offset = "0x3B22710", VA = "0x183B23310", Slot = "4")]
	public void MPHDIOFCAJP(double BDAHFCMEKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3B232D0", Offset = "0x3B226D0", VA = "0x183B232D0", Slot = "5")]
	public void KPKFLEKCHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B23430", Offset = "0x3B22830", VA = "0x183B23430")]
	public NLFFLMKIJHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface HFAGCMAOAMG
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	double MJCIMGLOLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	double ADKAPEBCCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	double BOONALDPKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPHDIOFCAJP(double BDAHFCMEKMK);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPKFLEKCHKC();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class KNKGAEBHOBC
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private interface FMCJAHJEPNB
	{
		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool GCDHIPMLANK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KBAIFMDABGC();

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DLONFMLMKBD();
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class HGGFGJKGHOI<TPromise, TMainThreadPromise> : FMCJAHJEPNB where TPromise : GMANCKGDIIA where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly TPromise JEPKDPAKEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		protected readonly TMainThreadPromise IGOOKHHDGEK;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public TPromise EPFGMNKPEBL
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2103BD0", Offset = "0x2102FD0", VA = "0x182103BD0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool GCDHIPMLANK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x2103B80", Offset = "0x2102F80", VA = "0x182103B80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FEF7D0", Offset = "0x1FEEBD0", VA = "0x181FEF7D0")]
		protected HGGFGJKGHOI(TPromise JEPKDPAKEPM, TMainThreadPromise ACNDOHMCENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2103C30", Offset = "0x2103030", VA = "0x182103C30", Slot = "5")]
		public void KBAIFMDABGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1741240", Offset = "0x1740640", VA = "0x181741240", Slot = "6")]
		public void DLONFMLMKBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void JLHMNBPALMN(TPromise JEPKDPAKEPM);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void DBHGBBJKEOM();
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class JPFJNLPKPAN<T> : HGGFGJKGHOI<global::KCBHFPPLLKO<T>, global::DMMMIOPAMGD<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x21042A0", Offset = "0x21036A0", VA = "0x1821042A0")]
		public JPFJNLPKPAN(global::KCBHFPPLLKO<T> JEPKDPAKEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2104100", Offset = "0x2103500", VA = "0x182104100", Slot = "7")]
		protected override void JLHMNBPALMN(global::KCBHFPPLLKO<T> JEPKDPAKEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2103E80", Offset = "0x2103280", VA = "0x182103E80", Slot = "8")]
		protected override void DBHGBBJKEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2103F10", Offset = "0x2103310", VA = "0x182103F10")]
		[CompilerGenerated]
		private void GDABKHHEBDG(T JBNMPONKACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2103EE0", Offset = "0x21032E0", VA = "0x182103EE0")]
		[CompilerGenerated]
		private void FKEMPCBOPJH(string KBFLGMGIPFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class OCNBNAFIJDM : HGGFGJKGHOI<GMANCKGDIIA, INJMAONFMNO>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3B23760", Offset = "0x3B22B60", VA = "0x183B23760")]
		public OCNBNAFIJDM(GMANCKGDIIA JEPKDPAKEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3B23690", Offset = "0x3B22A90", VA = "0x183B23690", Slot = "7")]
		protected override void JLHMNBPALMN(GMANCKGDIIA JEPKDPAKEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3B23640", Offset = "0x3B22A40", VA = "0x183B23640", Slot = "8")]
		protected override void DBHGBBJKEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xCCB910", Offset = "0xCCAD10", VA = "0x180CCB910")]
		[CompilerGenerated]
		private void GDABKHHEBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xBFB130", Offset = "0xBFA530", VA = "0x180BFB130")]
		[CompilerGenerated]
		private void FKEMPCBOPJH(string KBFLGMGIPFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private class PABGJJNDIPA : FMCJAHJEPNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly Action MLDCBHAMEIH;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool GCDHIPMLANK
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x44EB90", Offset = "0x44DF90", VA = "0x18044EB90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x4B5760", Offset = "0x4B4B60", VA = "0x1804B5760")]
		public PABGJJNDIPA(Action MLDCBHAMEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xE3CBE0", Offset = "0xE3BFE0", VA = "0x180E3CBE0", Slot = "5")]
		public void KBAIFMDABGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "6")]
		public void DLONFMLMKBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly List<FMCJAHJEPNB> HPHIFILLPKN;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1CAD230", Offset = "0x1CAC630", VA = "0x181CAD230")]
	public static global::KCBHFPPLLKO<T> NJGFBCLCMDE<T>(this global::KCBHFPPLLKO<T> JEPKDPAKEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DC50", Offset = "0x3B1D050", VA = "0x183B1DC50")]
	public static GMANCKGDIIA NJGFBCLCMDE(this GMANCKGDIIA JEPKDPAKEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DD60", Offset = "0x3B1D160", VA = "0x183B1DD60")]
	public static void NJGFBCLCMDE(Action MLDCBHAMEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1CAD0B0", Offset = "0x1CAC4B0", VA = "0x181CAD0B0")]
	private static global::KCBHFPPLLKO<T> GDLLDILBOKN<T>(global::KCBHFPPLLKO<T> JEPKDPAKEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D990", Offset = "0x3B1CD90", VA = "0x183B1D990")]
	private static GMANCKGDIIA GDLLDILBOKN(GMANCKGDIIA JEPKDPAKEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DA70", Offset = "0x3B1CE70", VA = "0x183B1DA70")]
	private static void IMJLKDGJIJI(FMCJAHJEPNB IBIMEICKOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D5C0", Offset = "0x3B1C9C0", VA = "0x183B1D5C0")]
	private static void DFMHNCAENBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DDE0", Offset = "0x3B1D1E0", VA = "0x183B1DDE0")]
	private static void OCGPOKCLDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D8E0", Offset = "0x3B1CCE0", VA = "0x183B1D8E0")]
	private static void FJJEIAIKLFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class FPJFIGKCIAO
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class IHBJNJKLMFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public INJMAONFMNO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
		public IHBJNJKLMFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B320", Offset = "0x3B1A720", VA = "0x183B1B320")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B310", Offset = "0x3B1A710", VA = "0x183B1B310")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class OEDNCDLICJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
		public OEDNCDLICJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3B237D0", Offset = "0x3B22BD0", VA = "0x183B237D0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class JNJKGOKCJPD : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public INJMAONFMNO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public JNJKGOKCJPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C3D0", Offset = "0x3B1B7D0", VA = "0x183B1C3D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C0C0", Offset = "0x3B1B4C0", VA = "0x183B1C0C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C480", Offset = "0x3B1B880", VA = "0x183B1C480")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C380", Offset = "0x3B1B780", VA = "0x183B1C380", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class DPDILPDLJIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public INJMAONFMNO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
		public DPDILPDLJIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class KDNMJCAJLIN : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private JKJIBOEKIAI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public INJMAONFMNO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private DPDILPDLJIP <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public KDNMJCAJLIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D1C0", Offset = "0x3B1C5C0", VA = "0x183B1D1C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D4D0", Offset = "0x3B1C8D0", VA = "0x183B1D4D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public const string HKENDDFCLEC = "empty";

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public const string LJCJOLMHCPJ = "moderator";

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public const string KOHONJLIJKL = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public const string DBHADHMLEDN = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public const string BJCHHOOOFBM = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const float OGNFOIIEABO = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static GMANCKGDIIA ELGDJNHBGME;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static AsyncOperation LIHLKJLJCEP;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static GMANCKGDIIA DHIGGMPHENO;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static string PBJJOGBIFDB;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static ThreadPriority MALOFFKPJKC;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public static bool OFEPGHLAKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3B18F70", Offset = "0x3B18370", VA = "0x183B18F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private static bool CDHBOPMFBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3B18C00", Offset = "0x3B18000", VA = "0x183B18C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private static bool EPIGEDAEHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3B18B20", Offset = "0x3B17F20", VA = "0x183B18B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<string, LoadSceneMode> DKIILCPDPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3B18EC0", Offset = "0x3B182C0", VA = "0x183B18EC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3B18E10", Offset = "0x3B18210", VA = "0x183B18E10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3B18CD0", Offset = "0x3B180D0", VA = "0x183B18CD0")]
	public static GMANCKGDIIA LCMLPIMMIKH(string MIGFCNJCPDJ, LoadSceneMode HILCMIBIDKF = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3B18910", Offset = "0x3B17D10", VA = "0x183B18910")]
	public static GMANCKGDIIA ADKMJNIAHBB(string MIGFCNJCPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3B18C60", Offset = "0x3B18060", VA = "0x183B18C60")]
	[IteratorStateMachine(typeof(JNJKGOKCJPD))]
	private static IEnumerator<JKJIBOEKIAI> ENMALJBHIPF(string MIGFCNJCPDJ, INJMAONFMNO AGGOPFDDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3B18B80", Offset = "0x3B17F80", VA = "0x183B18B80")]
	[IteratorStateMachine(typeof(KDNMJCAJLIN))]
	private static IEnumerator<JKJIBOEKIAI> CDLNDHNDALD(string MIGFCNJCPDJ, LoadSceneMode HILCMIBIDKF, INJMAONFMNO AGGOPFDDLNB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EEINDPOJDJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static byte[] OCLOOGINPMJ;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static int CFJLDOHEGKM;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static int PFIGBFOAIKM;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static BigInteger HJNCOPCDJHG;

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
	public EEINDPOJDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3B16920", Offset = "0x3B15D20", VA = "0x183B16920")]
	private static string KPINMDKLMNN(byte[] LPAMLJLFLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x3B165F0", Offset = "0x3B159F0", VA = "0x183B165F0")]
	public static string FEMGPJIFPGG(byte[] OOOKMGPDPAC, bool KLBFBHHGCEE)
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
		[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
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

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
public interface GAKAEFKCHND
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OCNAHFDBONF JINHDLPBOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OCNAHFDBONF KANGNNMNOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	OCNAHFDBONF ICNIKMKKJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CEKBOHKIEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PMPGMCGMKHF
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
		private delegate List<PlayerLoopSystem> HHALGHDIJOF(List<PlayerLoopSystem> FEJKHHCDLCP, int JMGLDKPIBEP);

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct LGGLKBPJJPC
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct EJIHPDKDJID
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static OCNAHFDBONF MOGKPHLIMCP;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x3C69520", Offset = "0x3C68720", VA = "0x183C69520")]
				public static PlayerLoopSystem LAAHKJNDPMF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct EMKHAFJJKIG
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static OCNAHFDBONF JCILOKAKALJ;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x3C696C0", Offset = "0x3C688C0", VA = "0x183C696C0")]
				public static PlayerLoopSystem LAAHKJNDPMF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct HKBLLGKOBJB
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static OCNAHFDBONF BELIGDOCEOH;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x3C6E030", Offset = "0x3C6D230", VA = "0x183C6E030")]
				public static PlayerLoopSystem LAAHKJNDPMF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			internal struct EDOPADIEDIK
			{
				[Cpp2IlInjected.Token(Token = "0x200000D")]
				[CompilerGenerated]
				private sealed class OJAMLPGPPPG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public IPNDGFGNGMF.PPKIEBBKLPJ key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
					public OJAMLPGPPPG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x3C727A0", Offset = "0x3C719A0", VA = "0x183C727A0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable KNJFCMLLALP;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x3C68D20", Offset = "0x3C67F20", VA = "0x183C68D20")]
				public static PlayerLoopSystem HKOLGNHHBMI(IPNDGFGNGMF.PPKIEBBKLPJ KPLFFOGJEBN)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			internal struct CDKJIMHFMIB
			{
				[Cpp2IlInjected.Token(Token = "0x200000F")]
				[CompilerGenerated]
				private sealed class LEAGFCCDGKG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000D")]
					public IPNDGFGNGMF.PPKIEBBKLPJ key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
					public LEAGFCCDGKG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x3C715D0", Offset = "0x3C707D0", VA = "0x183C715D0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x3C66410", Offset = "0x3C65610", VA = "0x183C66410")]
				public static PlayerLoopSystem HKOLGNHHBMI(IPNDGFGNGMF.PPKIEBBKLPJ KPLFFOGJEBN)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class FFKOIFBIGLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
			public FFKOIFBIGLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3C6B490", Offset = "0x3C6A690", VA = "0x183C6B490")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool JBHOBAMIMJK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool FNCOGHHMMNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3C68370", Offset = "0x3C67570", VA = "0x183C68370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3C684B0", Offset = "0x3C676B0", VA = "0x183C684B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3C671B0", Offset = "0x3C663B0", VA = "0x183C671B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3C684F0", Offset = "0x3C676F0", VA = "0x183C684F0")]
		private static void PEKNCBLJHIH(IPNDGFGNGMF.PPKIEBBKLPJ KPLFFOGJEBN, ref PlayerLoopSystem NABGMLKHEAJ, Type JOCBENFOHFM, Type HMIFEEKEGOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3C68000", Offset = "0x3C67200", VA = "0x183C68000")]
		private static void DBHBNJEKABA(ref PlayerLoopSystem NABGMLKHEAJ, Type JOCBENFOHFM, Type HMIFEEKEGOC, HHALGHDIJOF IOBANLJOFOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3C683B0", Offset = "0x3C675B0", VA = "0x183C683B0")]
		private static void JMLCGIGGJPJ(ref PlayerLoopSystem NABGMLKHEAJ, Type JOCBENFOHFM, Type HMIFEEKEGOC, PlayerLoopSystem? BIJBOHGLPAN, PlayerLoopSystem? BHDGMFODDFK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IPNDGFGNGMF
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum PPKIEBBKLPJ
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
	public class GIMLEKGCGFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly PPKIEBBKLPJ DLEJPHOGEEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly OBLNNCFOJBK OKNGHDLLPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long OPPGEDGADBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long MLMOOOIHBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public long IFGOJJKIDMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int EPMGMMLEDIM;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C260", Offset = "0x3C6B460", VA = "0x183C6C260")]
		public GIMLEKGCGFB(PPKIEBBKLPJ MHNDNNAAMOG, int MMDIHGFLIFL = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C1D0", Offset = "0x3C6B3D0", VA = "0x183C6C1D0")]
		public void JLAIIFEKHEG(int ODJDKHBDAGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C1F0", Offset = "0x3C6B3F0", VA = "0x183C6C1F0")]
		public void NIAHBMIGNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C0D0", Offset = "0x3C6B2D0", VA = "0x183C6C0D0")]
		public void EAEOKJFLBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C6BF00", Offset = "0x3C6B100", VA = "0x183C6BF00")]
		public void BHEDNIIAIJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C130", Offset = "0x3C6B330", VA = "0x183C6C130")]
		public double ECPDNIANJGM(int IJJFOLNIPAP)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int HNIMFINCODM = 90;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static PPKIEBBKLPJ[] HJPFLMODBOE;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static GIMLEKGCGFB[] GMADOIJKDFI;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E680", Offset = "0x3C6D880", VA = "0x183C6E680")]
	public static GIMLEKGCGFB DEIJALIHLNB(PPKIEBBKLPJ KPLFFOGJEBN, int MMDIHGFLIFL = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E8C0", Offset = "0x3C6DAC0", VA = "0x183C6E8C0")]
	public static GIMLEKGCGFB MOLELLHGMKB(PPKIEBBKLPJ KPLFFOGJEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E810", Offset = "0x3C6DA10", VA = "0x183C6E810")]
	public static void MFALEKHNCON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DHEFBKCNKPE : BEOAILMBIMK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BFCNDHEFIMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public DHEFBKCNKPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
		public BFCNDHEFIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3C62D80", Offset = "0x3C61F80", VA = "0x183C62D80")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HEHDKMJIJJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public DHEFBKCNKPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
		public HEHDKMJIJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C62D80", Offset = "0x3C61F80", VA = "0x183C62D80")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float IMNDJDAEFMC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3C68A20", Offset = "0x3C67C20", VA = "0x183C68A20")]
	public DHEFBKCNKPE(Behaviour NJJLHKPDHIC, float IMNDJDAEFMC, [Optional] Action CECCANJHFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3C68880", Offset = "0x3C67A80", VA = "0x183C68880", Slot = "9")]
	protected override bool OGBIFPPIOJP(Action HIOFDPALGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3C68950", Offset = "0x3C67B50", VA = "0x183C68950", Slot = "10")]
	protected override bool PMLKDEDCMPD(Action HIOFDPALGPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IPICNEDDDFH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool DEMFHLKKMIL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action INJNBOOEFLL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OCKGJFDLDOA(bool EODOFAPEKHA = false);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OCKGJFDLDOA(Action HIOFDPALGPA, bool EODOFAPEKHA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class BEOAILMBIMK : IPICNEDDDFH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FIKLBAGKODP : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public FIKLBAGKODP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B590", Offset = "0x3C6A790", VA = "0x183C6B590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B630", Offset = "0x3C6A830", VA = "0x183C6B630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Behaviour NJJLHKPDHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Action CECCANJHFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private BNIBEFNPMPN HLDHGFPKLGO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DEMFHLKKMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9E64D0", Offset = "0x9E56D0", VA = "0x1809E64D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action INJNBOOEFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3C62C30", Offset = "0x3C61E30", VA = "0x183C62C30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C628F0", Offset = "0x3C61AF0", VA = "0x183C628F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1F4B160", Offset = "0x1F4A360", VA = "0x181F4B160")]
	protected BEOAILMBIMK(Behaviour NJJLHKPDHIC, [Optional] Action CECCANJHFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3C62D20", Offset = "0x3C61F20", VA = "0x183C62D20", Slot = "7")]
	public bool OCKGJFDLDOA(bool EODOFAPEKHA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3C62CD0", Offset = "0x3C61ED0", VA = "0x183C62CD0", Slot = "8")]
	public bool OCKGJFDLDOA(Action HIOFDPALGPA, bool EODOFAPEKHA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OGBIFPPIOJP(Action HIOFDPALGPA);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool PMLKDEDCMPD(Action HIOFDPALGPA);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C628B0", Offset = "0x3C61AB0", VA = "0x183C628B0")]
	protected void AJHKPAEDEFE(Action HIOFDPALGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C62A60", Offset = "0x3C61C60", VA = "0x183C62A60")]
	protected NIIPAOBAIGP KGNMOABLJAD(float EOLDNHCPEIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3C629F0", Offset = "0x3C61BF0", VA = "0x183C629F0")]
	private void JBEOAABOAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3C62990", Offset = "0x3C61B90", VA = "0x183C62990")]
	[IteratorStateMachine(typeof(FIKLBAGKODP))]
	private static IEnumerator<GGOLJFPNLLB> GJIEKCJEEAM(float EOLDNHCPEIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3C628D0", Offset = "0x3C61AD0", VA = "0x183C628D0")]
	[CompilerGenerated]
	private void CKJIHMJHJJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HNLMMMHLAMC : BEOAILMBIMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly float GBLMIHHMLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly int OPKDHCNICFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly float IIAPHHNFEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly float[] CPBGJGEMPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int BMBKAMMDMND;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MEEAHKAEEHB CHDACCNIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x470670", Offset = "0x46F870", VA = "0x180470670")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4E71A0", Offset = "0x4E63A0", VA = "0x1804E71A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E480", Offset = "0x3C6D680", VA = "0x183C6E480")]
	public HNLMMMHLAMC(Behaviour NJJLHKPDHIC, float DOMCFBANEDB, int OPKDHCNICFD, [Optional] Action CECCANJHFOB, float IIAPHHNFEBF = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x449E40", Offset = "0x449040", VA = "0x180449E40", Slot = "9")]
	protected override bool OGBIFPPIOJP(Action HIOFDPALGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E260", Offset = "0x3C6D460", VA = "0x183C6E260", Slot = "10")]
	protected override bool PMLKDEDCMPD(Action HIOFDPALGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E1D0", Offset = "0x3C6D3D0", VA = "0x183C6E1D0")]
	private void KCDAABKFEGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EAKLLBEGLIE : BEOAILMBIMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly float IMNDJDAEFMC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3C68A20", Offset = "0x3C67C20", VA = "0x183C68A20")]
	public EAKLLBEGLIE(Behaviour NJJLHKPDHIC, float IMNDJDAEFMC, [Optional] Action CECCANJHFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x449E40", Offset = "0x449040", VA = "0x180449E40", Slot = "9")]
	protected override bool OGBIFPPIOJP(Action HIOFDPALGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3C68CE0", Offset = "0x3C67EE0", VA = "0x183C68CE0", Slot = "10")]
	protected override bool PMLKDEDCMPD(Action HIOFDPALGPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface EPHMHHIGEBO
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int OMEJMDCOBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface INJGDFDPILJ : BNIBEFNPMPN, NIIPAOBAIGP, IEnumerator, GGOLJFPNLLB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DMAILHAJGLH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly DMAILHAJGLH CJODMMCMGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Action KJNNEFPKNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private bool BOJHCNOPAPB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x54EC10", Offset = "0x54DE10", VA = "0x18054EC10")]
	public DMAILHAJGLH(Action KJNNEFPKNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3C68BF0", Offset = "0x3C67DF0", VA = "0x183C68BF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IAKLOMAJMON<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	T NMGCHANKNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable FNNDKMHBPDP(Action<T> LMEKCNOJCOA);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable FNNDKMHBPDP(UnityEngine.Object NJJLHKPDHIC, Action<T> LMEKCNOJCOA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HHAOPEJDMFI<T> : global::IAKLOMAJMON<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	new T NMGCHANKNIG
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
public class BDAJBBDDLCF<T> : global::HHAOPEJDMFI<T>, global::IAKLOMAJMON<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PAAOCKEPNBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public global::BDAJBBDDLCF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public global::AOFBLJDNDEO<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
		public PAAOCKEPNBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x363D030", Offset = "0x363C230", VA = "0x18363D030")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static GameObject PFPBLENEGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<global::AOFBLJDNDEO<UnityEngine.Object, Action<T>>> BHKCEOHBHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T BPGHLEOMNHA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private static UnityEngine.Object NAKOLGGMOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x36377B0", Offset = "0x36369B0", VA = "0x1836377B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T NMGCHANKNIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x538780", Offset = "0x537980", VA = "0x180538780", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3637210", Offset = "0x3636410", VA = "0x183637210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x36379F0", Offset = "0x3636BF0", VA = "0x1836379F0")]
	private static bool NIMKBKDPLDP(T CKOFPIFLMON, T PADLHGFNBLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x33ADFD0", Offset = "0x33AD1D0", VA = "0x1833ADFD0")]
	public BDAJBBDDLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3638130", Offset = "0x3637330", VA = "0x183638130")]
	public BDAJBBDDLCF(T EIMNCGLBBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3637560", Offset = "0x3636760", VA = "0x183637560")]
	public void HOKJOMHMENN(T CFMONMCILIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x36373B0", Offset = "0x36365B0", VA = "0x1836373B0", Slot = "7")]
	public IDisposable FNNDKMHBPDP(Action<T> LMEKCNOJCOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3637420", Offset = "0x3636620", VA = "0x183637420", Slot = "8")]
	public IDisposable FNNDKMHBPDP(UnityEngine.Object NJJLHKPDHIC, Action<T> LMEKCNOJCOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3637D80", Offset = "0x3636F80", VA = "0x183637D80")]
	private void OCDBLMODEHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class KLLLBLFJJOF
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class IICFOBKEBOP : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Scheduler.LKJNHONALLJ queue;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public IICFOBKEBOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E590", Offset = "0x3C6D790", VA = "0x183C6E590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E630", Offset = "0x3C6D830", VA = "0x183C6E630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class MEBPADKEMEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NIIPAOBAIGP promise;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
		public MEBPADKEMEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3C71790", Offset = "0x3C70990", VA = "0x183C71790")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class AKBGLGDIBIP : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public AKBGLGDIBIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3C625B0", Offset = "0x3C617B0", VA = "0x183C625B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3C626A0", Offset = "0x3C618A0", VA = "0x183C626A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly GGOLJFPNLLB AGHHHILOGBM;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly GGOLJFPNLLB DOKIEAFNBBB;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GGOLJFPNLLB JMDDJGBCIAK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly GGOLJFPNLLB HADDMJANLKF;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly GGOLJFPNLLB MAPPKCACGEK;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3C704F0", Offset = "0x3C6F6F0", VA = "0x183C704F0")]
	public static GGOLJFPNLLB NLJAPPHHPEK(float NFANCAJAMHK, Scheduler.LKJNHONALLJ MMNFKEFABCC = Scheduler.LKJNHONALLJ.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3C703E0", Offset = "0x3C6F5E0", VA = "0x183C703E0")]
	public static GGOLJFPNLLB JBEAIIAPNIH(float NFANCAJAMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3C705D0", Offset = "0x3C6F7D0", VA = "0x183C705D0")]
	[IteratorStateMachine(typeof(IICFOBKEBOP))]
	public static IEnumerator<GGOLJFPNLLB> PDEMHIOOAMK(float NFANCAJAMHK, Scheduler.LKJNHONALLJ MMNFKEFABCC = Scheduler.LKJNHONALLJ.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3C70330", Offset = "0x3C6F530", VA = "0x183C70330")]
	public static GGOLJFPNLLB AEDBFJDPPOG(Func<bool> BOCBJHIKCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3C70440", Offset = "0x3C6F640", VA = "0x183C70440")]
	public static GGOLJFPNLLB NDOGBHINALO(NIIPAOBAIGP DPPCDABONBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3C70390", Offset = "0x3C6F590", VA = "0x183C70390")]
	[IteratorStateMachine(typeof(AKBGLGDIBIP))]
	public static IEnumerator<GGOLJFPNLLB> DADBCONDPLB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GGOLJFPNLLB
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Scheduler.LKJNHONALLJ NMBNHMIHPEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float ECBIEEGMNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BBNJEALAHBL();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class EJDLHKCKLMH : GGOLJFPNLLB
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class NNKABDHCELE : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Scheduler.LKJNHONALLJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private EJDLHKCKLMH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public NNKABDHCELE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3C723E0", Offset = "0x3C715E0", VA = "0x183C723E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C724B0", Offset = "0x3C716B0", VA = "0x183C724B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class NCAGDGOHLIP : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Scheduler.LKJNHONALLJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private EJDLHKCKLMH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public NCAGDGOHLIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C71A80", Offset = "0x3C70C80", VA = "0x183C71A80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C71B70", Offset = "0x3C70D70", VA = "0x183C71B70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Scheduler.LKJNHONALLJ NMBNHMIHPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x449E50", Offset = "0x449050", VA = "0x180449E50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.LKJNHONALLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x449E60", Offset = "0x449060", VA = "0x180449E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float ECBIEEGMNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x585320", Offset = "0x584520", VA = "0x180585320", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
	public EJDLHKCKLMH(Scheduler.LKJNHONALLJ MMNFKEFABCC = Scheduler.LKJNHONALLJ.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x449F60", Offset = "0x449160", VA = "0x180449F60", Slot = "5")]
	public bool BBNJEALAHBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3C68F10", Offset = "0x3C68110", VA = "0x183C68F10")]
	public static INJGDFDPILJ DNNDJHLFLON(Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3C68E20", Offset = "0x3C68020", VA = "0x183C68E20")]
	public static INJGDFDPILJ DNNDJHLFLON(Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3C69000", Offset = "0x3C68200", VA = "0x183C69000")]
	public static INJGDFDPILJ DNNDJHLFLON(Behaviour NJJLHKPDHIC, Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3C69110", Offset = "0x3C68310", VA = "0x183C69110")]
	public static INJGDFDPILJ DNNDJHLFLON(Behaviour NJJLHKPDHIC, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C69220", Offset = "0x3C68420", VA = "0x183C69220")]
	public static INJGDFDPILJ FJCHNBKHPMM(GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3C69330", Offset = "0x3C68530", VA = "0x183C69330")]
	public static INJGDFDPILJ FJCHNBKHPMM(GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3C694B0", Offset = "0x3C686B0", VA = "0x183C694B0")]
	[IteratorStateMachine(typeof(NNKABDHCELE))]
	private static IEnumerator<GGOLJFPNLLB> JBEEPOJEJJB(Scheduler.LKJNHONALLJ MMNFKEFABCC, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3C69440", Offset = "0x3C68640", VA = "0x183C69440")]
	[IteratorStateMachine(typeof(NCAGDGOHLIP))]
	private static IEnumerator<GGOLJFPNLLB> JBEEPOJEJJB(Scheduler.LKJNHONALLJ MMNFKEFABCC, Action<float> HGLLNMEHECP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class LDMLJCGGKBM : GGOLJFPNLLB
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class ENABGEEGCPK : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Scheduler.LKJNHONALLJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private LDMLJCGGKBM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public ENABGEEGCPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C69860", Offset = "0x3C68A60", VA = "0x183C69860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C69A00", Offset = "0x3C68C00", VA = "0x183C69A00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly float CNLHBGMIBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private int EKGNGLBCJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly float IEBDDACLJJP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float CIAJECDHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x57D920", Offset = "0x57CB20", VA = "0x18057D920")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x57D930", Offset = "0x57CB30", VA = "0x18057D930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Scheduler.LKJNHONALLJ NMBNHMIHPEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x449C60", Offset = "0x448E60", VA = "0x180449C60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.LKJNHONALLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5694F0", Offset = "0x5686F0", VA = "0x1805694F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float ECBIEEGMNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7B0", Offset = "0x6AA9B0", VA = "0x1806AB7B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C9EA0", Offset = "0x6C90A0", VA = "0x1806C9EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float LJOBEGPECDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4EDB80", Offset = "0x4ECD80", VA = "0x1804EDB80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4EE060", Offset = "0x4ED260", VA = "0x1804EE060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3C714F0", Offset = "0x3C706F0", VA = "0x183C714F0")]
	public LDMLJCGGKBM(float HNBFDCHIJCB, Scheduler.LKJNHONALLJ MMNFKEFABCC = Scheduler.LKJNHONALLJ.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3C71190", Offset = "0x3C70390", VA = "0x183C71190", Slot = "5")]
	public bool BBNJEALAHBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C71460", Offset = "0x3C70660", VA = "0x183C71460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C711B0", Offset = "0x3C703B0", VA = "0x183C711B0")]
	public static INJGDFDPILJ DNNDJHLFLON(float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C71260", Offset = "0x3C70460", VA = "0x183C71260")]
	public static INJGDFDPILJ DNNDJHLFLON(MonoBehaviour BOGCAKPFCPM, float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C713A0", Offset = "0x3C705A0", VA = "0x183C713A0")]
	public static INJGDFDPILJ LOAEHKNHKAH(GAKAEFKCHND NJJLHKPDHIC, float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C71320", Offset = "0x3C70520", VA = "0x183C71320")]
	[IteratorStateMachine(typeof(ENABGEEGCPK))]
	private static IEnumerator<GGOLJFPNLLB> JBEEPOJEJJB(float BIAFGNMJLIB, Scheduler.LKJNHONALLJ MMNFKEFABCC, Action<float> HGLLNMEHECP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class AANFBDLGPAJ : GGOLJFPNLLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Func<bool> BOCBJHIKCPM;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Scheduler.LKJNHONALLJ NMBNHMIHPEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A70", Offset = "0x4B5C70", VA = "0x1804B6A70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.LKJNHONALLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x56B500", Offset = "0x56A700", VA = "0x18056B500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public float ECBIEEGMNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x57D920", Offset = "0x57CB20", VA = "0x18057D920", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x57D930", Offset = "0x57CB30", VA = "0x18057D930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3C62130", Offset = "0x3C61330", VA = "0x183C62130")]
	public AANFBDLGPAJ(Func<bool> BOCBJHIKCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3C620F0", Offset = "0x3C612F0", VA = "0x183C620F0")]
	public AANFBDLGPAJ(Scheduler.LKJNHONALLJ CONNADNIKEF, Func<bool> BOCBJHIKCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3C620A0", Offset = "0x3C612A0", VA = "0x183C620A0", Slot = "5")]
	public bool BBNJEALAHBL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class AKLOHEAOBKF
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DIJHNHPKAPK : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Scheduler.LKJNHONALLJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public DIJHNHPKAPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3C68A70", Offset = "0x3C67C70", VA = "0x183C68A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3C68B10", Offset = "0x3C67D10", VA = "0x183C68B10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3C626F0", Offset = "0x3C618F0", VA = "0x183C626F0")]
	[IteratorStateMachine(typeof(DIJHNHPKAPK))]
	private static IEnumerator<GGOLJFPNLLB> HFHIJOHAMIM(Scheduler.LKJNHONALLJ CONNADNIKEF, Func<bool> BOCBJHIKCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3C62760", Offset = "0x3C61960", VA = "0x183C62760")]
	public static INJGDFDPILJ PIFBCOIBDGC(this MonoBehaviour BOGCAKPFCPM, Func<bool> BOCBJHIKCPM, Scheduler.LKJNHONALLJ CONNADNIKEF = Scheduler.LKJNHONALLJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class GBNLJNPCDLA : GGOLJFPNLLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly float HMGMEKDHFAH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Scheduler.LKJNHONALLJ NMBNHMIHPEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x46C960", Offset = "0x46BB60", VA = "0x18046C960", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.LKJNHONALLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x52D540", Offset = "0x52C740", VA = "0x18052D540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float ECBIEEGMNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA21DD0", Offset = "0xA20FD0", VA = "0x180A21DD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA21DE0", Offset = "0xA20FE0", VA = "0x180A21DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3C6BE50", Offset = "0x3C6B050", VA = "0x183C6BE50")]
	public GBNLJNPCDLA(float NFANCAJAMHK, Scheduler.LKJNHONALLJ MMNFKEFABCC = Scheduler.LKJNHONALLJ.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3C6BDC0", Offset = "0x3C6AFC0", VA = "0x183C6BDC0", Slot = "5")]
	public bool BBNJEALAHBL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class LMGFBPONJAC : GGOLJFPNLLB
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private const float FNLAHGIBNCH = 0.1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly float JJFCJPJKFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private float ICAEJKGNPGM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Scheduler.LKJNHONALLJ NMBNHMIHPEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x475960", Offset = "0x474B60", VA = "0x180475960", Slot = "4")]
		get
		{
			return default(Scheduler.LKJNHONALLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float ECBIEEGMNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x585320", Offset = "0x584520", VA = "0x180585320", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x37D72E0", Offset = "0x37D64E0", VA = "0x1837D72E0")]
	public LMGFBPONJAC(float NFANCAJAMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3C71690", Offset = "0x3C70890", VA = "0x183C71690", Slot = "5")]
	public bool BBNJEALAHBL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class BOFGEILJNIO
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class NHBNGMFDPNF : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Scheduler.LKJNHONALLJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public NHBNGMFDPNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C72150", Offset = "0x3C71350", VA = "0x183C72150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C72200", Offset = "0x3C71400", VA = "0x183C72200", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class FCDGPCJFKIO : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Scheduler.LKJNHONALLJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private GGOLJFPNLLB <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public FCDGPCJFKIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C69B50", Offset = "0x3C68D50", VA = "0x183C69B50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C69C10", Offset = "0x3C68E10", VA = "0x183C69C10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3C64200", Offset = "0x3C63400", VA = "0x183C64200")]
	[IteratorStateMachine(typeof(NHBNGMFDPNF))]
	private static IEnumerator<GGOLJFPNLLB> OFLBOEBJEFE(float NFANCAJAMHK, Scheduler.LKJNHONALLJ MMNFKEFABCC, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3C64040", Offset = "0x3C63240", VA = "0x183C64040")]
	[IteratorStateMachine(typeof(FCDGPCJFKIO))]
	private static IEnumerator<GGOLJFPNLLB> JOCIANPPGAD(float NFANCAJAMHK, Scheduler.LKJNHONALLJ MMNFKEFABCC, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3C63820", Offset = "0x3C62A20", VA = "0x183C63820")]
	public static IDisposable EJGHIDOMKFH(this MonoBehaviour BOGCAKPFCPM, float NFANCAJAMHK, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3C63DF0", Offset = "0x3C62FF0", VA = "0x183C63DF0")]
	public static INJGDFDPILJ JNAFLIAIHMM(this MonoBehaviour BOGCAKPFCPM, float NFANCAJAMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3C63960", Offset = "0x3C62B60", VA = "0x183C63960")]
	public static INJGDFDPILJ EJGHIDOMKFH(this MonoBehaviour BOGCAKPFCPM, float NFANCAJAMHK, Scheduler.LKJNHONALLJ MMNFKEFABCC, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3C640C0", Offset = "0x3C632C0", VA = "0x183C640C0")]
	public static INJGDFDPILJ JOJHKFNPMBA(this MonoBehaviour BOGCAKPFCPM, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3C63DE0", Offset = "0x3C62FE0", VA = "0x183C63DE0")]
	public static INJGDFDPILJ IGAAHHLIAJK(this MonoBehaviour BOGCAKPFCPM, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3C641E0", Offset = "0x3C633E0", VA = "0x183C641E0")]
	public static INJGDFDPILJ MPGIHPHHGBI(this MonoBehaviour BOGCAKPFCPM, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3C63810", Offset = "0x3C62A10", VA = "0x183C63810")]
	public static INJGDFDPILJ CCANPLLMIDG(this MonoBehaviour BOGCAKPFCPM, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3C641F0", Offset = "0x3C633F0", VA = "0x183C641F0")]
	public static INJGDFDPILJ NEOHIEMEHPL(this MonoBehaviour BOGCAKPFCPM, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3C63F30", Offset = "0x3C63130", VA = "0x183C63F30")]
	private static INJGDFDPILJ JOACPAOCCOP(MonoBehaviour BOGCAKPFCPM, Scheduler.LKJNHONALLJ CONNADNIKEF, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3C63700", Offset = "0x3C62900", VA = "0x183C63700")]
	public static INJGDFDPILJ BAEHILAHGHI(this MonoBehaviour BOGCAKPFCPM, float DFBNPJMCJJG, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3C63AB0", Offset = "0x3C62CB0", VA = "0x183C63AB0")]
	public static INJGDFDPILJ FDNINMNCJJI(this MonoBehaviour BOGCAKPFCPM, float DFBNPJMCJJG, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3C63CD0", Offset = "0x3C62ED0", VA = "0x183C63CD0")]
	public static INJGDFDPILJ GGOLDJLMCFD(this MonoBehaviour BOGCAKPFCPM, float DFBNPJMCJJG, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3C63BC0", Offset = "0x3C62DC0", VA = "0x183C63BC0")]
	public static INJGDFDPILJ FPONAEILDEN(this MonoBehaviour BOGCAKPFCPM, float DFBNPJMCJJG, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3C640D0", Offset = "0x3C632D0", VA = "0x183C640D0")]
	public static INJGDFDPILJ KHDONOACGLF(this MonoBehaviour BOGCAKPFCPM, float DFBNPJMCJJG, Action BHMHKBCBJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class KANDFMDMBPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class EPFJPMMODMK : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public EPFJPMMODMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3C69A50", Offset = "0x3C68C50", VA = "0x183C69A50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3C69B00", Offset = "0x3C68D00", VA = "0x183C69B00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private INJGDFDPILJ NGKLFHODKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private MonoBehaviour BOGCAKPFCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private Action HGLLNMEHECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Action<float> CFHMDFEOIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Scheduler.LKJNHONALLJ CONNADNIKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private float BFBJHKKILOJ;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F7B0", Offset = "0x3C6E9B0", VA = "0x183C6F7B0")]
	public KANDFMDMBPI(MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F940", Offset = "0x3C6EB40", VA = "0x183C6F940")]
	public KANDFMDMBPI(MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C6FAD0", Offset = "0x3C6ECD0", VA = "0x183C6FAD0")]
	public KANDFMDMBPI(MonoBehaviour BOGCAKPFCPM, float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F1D0", Offset = "0x3C6E3D0", VA = "0x183C6F1D0")]
	private void DNNDJHLFLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F630", Offset = "0x3C6E830", VA = "0x183C6F630")]
	private void NCEPDNJHLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F500", Offset = "0x3C6E700", VA = "0x183C6F500")]
	private void KMBKEOKDDCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F0B0", Offset = "0x3C6E2B0", VA = "0x183C6F0B0")]
	private void DHKMICHIAHM(string HEEKCGODMHP, Action CNHLOEGEHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F3A0", Offset = "0x3C6E5A0", VA = "0x183C6F3A0")]
	[IteratorStateMachine(typeof(EPFJPMMODMK))]
	private IEnumerator<GGOLJFPNLLB> FPJJANOINFD(Action CNHLOEGEHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F350", Offset = "0x3C6E550", VA = "0x183C6F350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F400", Offset = "0x3C6E600", VA = "0x183C6F400")]
	[CompilerGenerated]
	private void GDGEPJHFDOE(string BIDEGMIFHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F480", Offset = "0x3C6E680", VA = "0x183C6F480")]
	[CompilerGenerated]
	private void JAPDFPBJIOF(string BIDEGMIFHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F030", Offset = "0x3C6E230", VA = "0x183C6F030")]
	[CompilerGenerated]
	private void CCGPAKIMGNM(string BIDEGMIFHOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CMOCKNILJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3C66700", Offset = "0x3C65900", VA = "0x183C66700")]
	public static IDisposable DNNDJHLFLON(this MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3C66780", Offset = "0x3C65980", VA = "0x183C66780")]
	public static IDisposable DNNDJHLFLON(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3C66D50", Offset = "0x3C65F50", VA = "0x183C66D50")]
	public static IDisposable KAKDGOFLCEK(this MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3C66590", Offset = "0x3C65790", VA = "0x183C66590")]
	public static IDisposable BNGDKHPHFBM(this MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3C66AD0", Offset = "0x3C65CD0", VA = "0x183C66AD0")]
	public static IDisposable IGPOEJCMDBK(this MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3C66ED0", Offset = "0x3C660D0", VA = "0x183C66ED0")]
	public static IDisposable MALLCOMOHDK(this MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3C67140", Offset = "0x3C66340", VA = "0x183C67140")]
	public static IDisposable PHJGAIMGFEC(this MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3C66DC0", Offset = "0x3C65FC0", VA = "0x183C66DC0")]
	public static IDisposable KKCCDEAKMAI(this MonoBehaviour BOGCAKPFCPM, float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3C66E50", Offset = "0x3C66050", VA = "0x183C66E50")]
	public static IDisposable KNMELKKKIDB(this MonoBehaviour BOGCAKPFCPM, float BIAFGNMJLIB, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3C66680", Offset = "0x3C65880", VA = "0x183C66680")]
	public static IDisposable DEBFANDBIJM(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3C669D0", Offset = "0x3C65BD0", VA = "0x183C669D0")]
	public static IDisposable EICLMCAONCM(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3C66FC0", Offset = "0x3C661C0", VA = "0x183C66FC0")]
	public static IDisposable OGIJDGBNLAF(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3C66BD0", Offset = "0x3C65DD0", VA = "0x183C66BD0")]
	public static IDisposable JAIANFAJIJA(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3C66C50", Offset = "0x3C65E50", VA = "0x183C66C50")]
	public static IDisposable JBIEJEAONIA(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3C66600", Offset = "0x3C65800", VA = "0x183C66600")]
	public static IDisposable CKIGAIGOAGJ(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3C66940", Offset = "0x3C65B40", VA = "0x183C66940")]
	public static IDisposable DPPKBCFDGHM(this MonoBehaviour BOGCAKPFCPM, float BIAFGNMJLIB, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3C67040", Offset = "0x3C66240", VA = "0x183C67040")]
	public static IDisposable OHHAHNDBALE(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3C66A50", Offset = "0x3C65C50", VA = "0x183C66A50")]
	public static IDisposable HAGLLEAPEGL(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3C670C0", Offset = "0x3C662C0", VA = "0x183C670C0")]
	public static IDisposable PFIENKMEOID(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3C66B40", Offset = "0x3C65D40", VA = "0x183C66B40")]
	public static IDisposable IJFOIEFMNOM(this MonoBehaviour BOGCAKPFCPM, float BIAFGNMJLIB, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3C66510", Offset = "0x3C65710", VA = "0x183C66510")]
	public static IDisposable BJPGPAKMOAN(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3C66CD0", Offset = "0x3C65ED0", VA = "0x183C66CD0")]
	public static IDisposable JCIDEKGBNCB(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3C66F40", Offset = "0x3C66140", VA = "0x183C66F40")]
	public static IDisposable OAJNADPLCKJ(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class HJOMFAGAHGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class DDKKNLKEBJL : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public DDKKNLKEBJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3C68750", Offset = "0x3C67950", VA = "0x183C68750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3C68800", Offset = "0x3C67A00", VA = "0x183C68800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private INJGDFDPILJ NGKLFHODKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private GAKAEFKCHND NJJLHKPDHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Action HGLLNMEHECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action<float> CFHMDFEOIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Scheduler.LKJNHONALLJ CONNADNIKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float BFBJHKKILOJ;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DD50", Offset = "0x3C6CF50", VA = "0x183C6DD50")]
	public HJOMFAGAHGA(GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DBC0", Offset = "0x3C6CDC0", VA = "0x183C6DBC0")]
	public HJOMFAGAHGA(GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DEE0", Offset = "0x3C6D0E0", VA = "0x183C6DEE0")]
	public HJOMFAGAHGA(GAKAEFKCHND NJJLHKPDHIC, float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D5E0", Offset = "0x3C6C7E0", VA = "0x183C6D5E0")]
	private void DNNDJHLFLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DA40", Offset = "0x3C6CC40", VA = "0x183C6DA40")]
	private void NCEPDNJHLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D910", Offset = "0x3C6CB10", VA = "0x183C6D910")]
	private void KMBKEOKDDCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D4C0", Offset = "0x3C6C6C0", VA = "0x183C6D4C0")]
	private void DHKMICHIAHM(string HEEKCGODMHP, Action CNHLOEGEHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D7B0", Offset = "0x3C6C9B0", VA = "0x183C6D7B0")]
	[IteratorStateMachine(typeof(DDKKNLKEBJL))]
	private IEnumerator<GGOLJFPNLLB> FPJJANOINFD(Action CNHLOEGEHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D760", Offset = "0x3C6C960", VA = "0x183C6D760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D810", Offset = "0x3C6CA10", VA = "0x183C6D810")]
	[CompilerGenerated]
	private void GDGEPJHFDOE(string BIDEGMIFHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D890", Offset = "0x3C6CA90", VA = "0x183C6D890")]
	[CompilerGenerated]
	private void JAPDFPBJIOF(string BIDEGMIFHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D440", Offset = "0x3C6C640", VA = "0x183C6D440")]
	[CompilerGenerated]
	private void CCGPAKIMGNM(string BIDEGMIFHOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HAGBOLOAIJH
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3C6CA60", Offset = "0x3C6BC60", VA = "0x183C6CA60")]
	public static IDisposable FJCHNBKHPMM(this GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C8A0", Offset = "0x3C6BAA0", VA = "0x183C6C8A0")]
	public static IDisposable FJCHNBKHPMM(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C4C0", Offset = "0x3C6B6C0", VA = "0x183C6C4C0")]
	public static IDisposable ANIJHBKEIEI(this GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3C6CC70", Offset = "0x3C6BE70", VA = "0x183C6CC70")]
	public static IDisposable JFEDDPJFGON(this GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C740", Offset = "0x3C6B940", VA = "0x183C6C740")]
	public static IDisposable BOPAMHMIBHE(this GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C7B0", Offset = "0x3C6B9B0", VA = "0x183C6C7B0")]
	public static IDisposable DGKJMHPNFEI(this GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3C6CCE0", Offset = "0x3C6BEE0", VA = "0x183C6CCE0")]
	public static IDisposable KFLFPDMECBK(this GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C630", Offset = "0x3C6B830", VA = "0x183C6C630")]
	public static IDisposable BLHCCFNPPLD(this GAKAEFKCHND NJJLHKPDHIC, float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3C6CD50", Offset = "0x3C6BF50", VA = "0x183C6CD50")]
	public static IDisposable LBHBMJDPLHB(this GAKAEFKCHND NJJLHKPDHIC, float BIAFGNMJLIB, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C820", Offset = "0x3C6BA20", VA = "0x183C6C820")]
	public static IDisposable DICFJIKPKJF(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C6C0", Offset = "0x3C6B8C0", VA = "0x183C6C6C0")]
	public static IDisposable BMKPKFGEEIK(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3C6CAE0", Offset = "0x3C6BCE0", VA = "0x183C6CAE0")]
	public static IDisposable GPDALONKPFK(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3C6CDD0", Offset = "0x3C6BFD0", VA = "0x183C6CDD0")]
	public static IDisposable NKGDBKFDCEJ(this GAKAEFKCHND NJJLHKPDHIC, float BIAFGNMJLIB, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C440", Offset = "0x3C6B640", VA = "0x183C6C440")]
	public static IDisposable AKMAJDJDNIA(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C340", Offset = "0x3C6B540", VA = "0x183C6C340")]
	public static IDisposable ABKNPIIHEHE(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C530", Offset = "0x3C6B730", VA = "0x183C6C530")]
	public static IDisposable BCKAOMCBDHJ(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3C6CBE0", Offset = "0x3C6BDE0", VA = "0x183C6CBE0")]
	public static IDisposable JAKFHCJOHNA(this GAKAEFKCHND NJJLHKPDHIC, float BIAFGNMJLIB, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C5B0", Offset = "0x3C6B7B0", VA = "0x183C6C5B0")]
	public static IDisposable BHBGPFINBMN(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3C6CB60", Offset = "0x3C6BD60", VA = "0x183C6CB60")]
	public static IDisposable HCOEBJDEFED(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C3C0", Offset = "0x3C6B5C0", VA = "0x183C6C3C0")]
	public static IDisposable ADCFJENDAAI(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
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
		private class KPANKBDMJBF : EPHMHHIGEBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public CBDIEFCKONB NMBNHMIHPEB;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public int OMEJMDCOBMI
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x449E50", Offset = "0x449050", VA = "0x180449E50", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0x449E60", Offset = "0x449060", VA = "0x180449E60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3C70EA0", Offset = "0x3C700A0", VA = "0x183C70EA0")]
			public static GGOLJFPNLLB BPDNAEGJJMM(IEnumerator<GGOLJFPNLLB> MIMKAKANKAI, DLKJPHLPLHM DPPCDABONBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3C71000", Offset = "0x3C70200", VA = "0x183C71000")]
			public GGOLJFPNLLB BPDNAEGJJMM(DLKJPHLPLHM[] HDKMBLDBANI, IEnumerator<GGOLJFPNLLB>[] CJHMJKENPJA, GGOLJFPNLLB[] PBHGJBHCBMH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3C70E70", Offset = "0x3C70070", VA = "0x183C70E70")]
			public void MJACBABLGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3C710D0", Offset = "0x3C702D0", VA = "0x183C710D0")]
			public void CMNNFNJIAOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3C70DB0", Offset = "0x3C6FFB0", VA = "0x183C70DB0")]
			public void ANFPGMLIMAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3C70E70", Offset = "0x3C70070", VA = "0x183C70E70")]
			public void BDFMNIAJMLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
			public KPANKBDMJBF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class CBDIEFCKONB
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			public struct NCKOMNKNPBG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public KPANKBDMJBF LOBGPLFEMKD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public GAKAEFKCHND HNCNGOLNOIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public DLKJPHLPLHM BCCDCGIEGFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public IEnumerator<GGOLJFPNLLB> JEENMPHBAOE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public GGOLJFPNLLB HBBFPOOADLP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public BGCCKIIPFOA CEBCFFJIMEI;
			}

			[Cpp2IlInjected.Token(Token = "0x2000042")]
			public struct LBDPHHDMLDH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public LKJNHONALLJ EFBFNEAMLDD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public List<NCKOMNKNPBG> KEGENBCMCCC;
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class KNBBFIMDFMG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public CBDIEFCKONB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public GAKAEFKCHND context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public KPANKBDMJBF routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public BGCCKIIPFOA coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public DLKJPHLPLHM promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public GGOLJFPNLLB currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public IEnumerator<GGOLJFPNLLB> coroutine;

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
				public KNBBFIMDFMG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017D")]
				[Cpp2IlInjected.Address(RVA = "0x3C70760", Offset = "0x3C6F960", VA = "0x183C70760")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000044")]
			[CompilerGenerated]
			private sealed class MMCCBNPGIPM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public KPANKBDMJBF schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public CBDIEFCKONB <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
				public MMCCBNPGIPM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x3C71970", Offset = "0x3C70B70", VA = "0x183C71970")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000045")]
			[CompilerGenerated]
			private sealed class FKGCNGJFHNI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public KPANKBDMJBF schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public CBDIEFCKONB <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
				public FKGCNGJFHNI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x3C6B680", Offset = "0x3C6A880", VA = "0x183C6B680")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000046")]
			[CompilerGenerated]
			private sealed class AJAEOKKBLDI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public KPANKBDMJBF schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public CBDIEFCKONB <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000182")]
				[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
				public AJAEOKKBLDI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x3C62570", Offset = "0x3C61770", VA = "0x183C62570")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private readonly LKJNHONALLJ CONNADNIKEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private bool[] APKLJFJKNOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private NativeArray<BGCCKIIPFOA> MBIGFDLIJJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private NativeArray<float> ILEKABNCCKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private NativeArray<int> GLEIHNLGDAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private NativeArray<int> AEHPNBDLCGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private NativeArray<int> IKMLIIBCIDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private NativeArray<int> GNOFLEKEOGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private NativeArray<int> NCOEBBGIBMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private KPANKBDMJBF[] MBEODJLNLOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private DLKJPHLPLHM[] HDKMBLDBANI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private GAKAEFKCHND[] LONDKBPPOHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private IEnumerator<GGOLJFPNLLB>[] EKIDBLDMHDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private GGOLJFPNLLB[] IBEFFBOLGEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private int NGDBNCPKEPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int PLJFHAMCAMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private readonly int EALJGKLLBFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private float CCNBFBHGKLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private NCFLFPKLAIM NEHFOIAMECG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private JobHandle PEFKPHPJCCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private List<KPANKBDMJBF> NEDAEEPGOEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool OAGFPLPGKDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private List<Action> NKBPMMDJGLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private List<Action> GIIECCEAJND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private bool NENJLEAGHBN;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public LBDPHHDMLDH[] LEDMGPJDLHI
			{
				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0x831F40", Offset = "0x831140", VA = "0x180831F40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public int JLNLHJPGLFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000168")]
				[Cpp2IlInjected.Address(RVA = "0x6AB7D0", Offset = "0x6AA9D0", VA = "0x1806AB7D0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3C65F10", Offset = "0x3C65110", VA = "0x183C65F10")]
			private static int OHBDHHHNPOE(LKJNHONALLJ CONNADNIKEF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3C65F40", Offset = "0x3C65140", VA = "0x183C65F40")]
			public CBDIEFCKONB(LKJNHONALLJ CONNADNIKEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3C652B0", Offset = "0x3C644B0", VA = "0x183C652B0")]
			private void JCFCBOCKMLP(ref int KFMDBOIJGBM, int LOAKBGOMLFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x3C65B40", Offset = "0x3C64D40", VA = "0x183C65B40")]
			public void NNPDNJBHCDF(GAKAEFKCHND NJJLHKPDHIC, GGOLJFPNLLB KOAOPHNLPDA, IEnumerator<GGOLJFPNLLB> MIMKAKANKAI, DLKJPHLPLHM DPPCDABONBF, [Optional] KPANKBDMJBF LNNCAOLKAHD, BGCCKIIPFOA OBJHHEEEFNM = BGCCKIIPFOA.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x3C64B40", Offset = "0x3C63D40", VA = "0x183C64B40")]
			public void GGNCNPKENKO(IEnumerable<NCKOMNKNPBG> JKBFHMHOHOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3C64280", Offset = "0x3C63480", VA = "0x183C64280")]
			private NCKOMNKNPBG AEKOOFFANIG(int FAJJGGFMDIO)
			{
				return default(NCKOMNKNPBG);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x3C65810", Offset = "0x3C64A10", VA = "0x183C65810")]
			private void NADJMEGDHOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x21A7C50", Offset = "0x21A6E50", VA = "0x1821A7C50")]
			private static void FCFIGDKCAML<T>(int FAJJGGFMDIO, T[] HCMDOPBJOFO, int LMCPNDFGEGE, [Optional] T ENMPHCODCFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x21A7C30", Offset = "0x21A6E30", VA = "0x1821A7C30")]
			private static void FCFIGDKCAML<T>(int FAJJGGFMDIO, NativeArray<T> HCMDOPBJOFO, int LMCPNDFGEGE, [Optional] T ENMPHCODCFP) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x3C647E0", Offset = "0x3C639E0", VA = "0x183C647E0")]
			private void CHGBCLNAJGH(IEnumerable<NCKOMNKNPBG> JKBFHMHOHOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3C64A80", Offset = "0x3C63C80", VA = "0x183C64A80")]
			private void FEADKAKEJGI(NCKOMNKNPBG JIILFMGIIDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x3C65C70", Offset = "0x3C64E70", VA = "0x183C65C70")]
			private MAEBBBIKINA OEHOPOJOFPG(int JGCFEAOKOKF)
			{
				return default(MAEBBBIKINA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x3C65570", Offset = "0x3C64770", VA = "0x183C65570")]
			public void KPMPFAADEPI(float KJPPOBJONKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3C654F0", Offset = "0x3C646F0", VA = "0x183C654F0")]
			private void KFLAIKNBMGH(Action CKOFPIFLMON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3C64760", Offset = "0x3C63960", VA = "0x183C64760")]
			private void BOJAKNICHOM(Action CKOFPIFLMON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x3C64E10", Offset = "0x3C64010", VA = "0x183C64E10")]
			public void IHNNMFPOOND(float KJPPOBJONKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x3C64D30", Offset = "0x3C63F30", VA = "0x183C64D30")]
			public void HHNMAMPPGJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3C646B0", Offset = "0x3C638B0", VA = "0x183C646B0")]
			public void BDFMNIAJMLF(KPANKBDMJBF FLOIHGLCPLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3C65440", Offset = "0x3C64640", VA = "0x183C65440")]
			public void KEFJPJLNNHL(KPANKBDMJBF FLOIHGLCPLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3C65760", Offset = "0x3C64960", VA = "0x183C65760")]
			public void MLCCNALIHNO(KPANKBDMJBF FLOIHGLCPLL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[BurstCompile]
		public struct NCFLFPKLAIM : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			[ReadOnly]
			public float NJNBDFEAKMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			[ReadOnly]
			public int JNFGDLNECJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private NativeArray<int> NEILEEMEHPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private NativeArray<int> ABCBHKKCDFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private NativeArray<int> EDLGPOBPOJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			[ReadOnly]
			public NativeArray<BGCCKIIPFOA> IABELANCIPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			[ReadOnly]
			public NativeArray<float> IONOPKNGNHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			[WriteOnly]
			public NativeArray<int> IKMLIIBCIDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			[WriteOnly]
			public NativeArray<int> GLEIHNLGDAE;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3C71BC0", Offset = "0x3C70DC0", VA = "0x183C71BC0")]
			public static NCFLFPKLAIM BAHAJJMALOP(int NDOOGKCKGEC, float KJPPOBJONKO, NativeArray<BGCCKIIPFOA> KLKGPFBGLHE, NativeArray<float> IMFBIGIAGJI, NativeArray<int> BFJMGNDNFOD, NativeArray<int> PFDOIHNIDJG, NativeArray<int> EMKFFNOHJHN, NativeArray<int> ABCBHKKCDFG, NativeArray<int> EDLGPOBPOJM)
			{
				return default(NCFLFPKLAIM);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3C71D90", Offset = "0x3C70F90", VA = "0x183C71D90", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x3C71EE0", Offset = "0x3C710E0", VA = "0x183C71EE0")]
			private bool IMOEGNPGCKD(int DLGFKHPJLDA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x3C71D60", Offset = "0x3C70F60", VA = "0x183C71D60")]
			private void EPNEJJLJFIJ(NativeArray<int> BDMABCJIEJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3C71E70", Offset = "0x3C71070", VA = "0x183C71E70")]
			private int HNFBELBHHDG(int BAIJDKLFNFE, int LDJNOFADOFO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3C71C90", Offset = "0x3C70E90", VA = "0x183C71C90")]
			private void DKBAGDEKABN(NativeArray<int> BDMABCJIEJA, int HIMBPNHJGGF, int LKOIFDDMOFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3C71F20", Offset = "0x3C71120", VA = "0x183C71F20")]
			private void JLFHOKFOCKC(NativeArray<int> BDMABCJIEJA, int NJNJPDNMFFF, int OECLMHPJFOJ, int PEBNIGEAEFC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class JJCONKLKJIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private readonly DLKJPHLPLHM DPPCDABONBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private readonly Behaviour NJJLHKPDHIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private readonly bool JPFGABPGCDM;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public IEnumerator<GGOLJFPNLLB> JEENMPHBAOE
			{
				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x449440", Offset = "0x448640", VA = "0x180449440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public GGOLJFPNLLB HBBFPOOADLP
			{
				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x449450", Offset = "0x448650", VA = "0x180449450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool FBPCCOLKJDK
			{
				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x3C6ED00", Offset = "0x3C6DF00", VA = "0x183C6ED00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool CDKMKDOIGID
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x667BE0", Offset = "0x666DE0", VA = "0x180667BE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0xF10A10", Offset = "0xF0FC10", VA = "0x180F10A10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public string DGNFNNLAFAF
			{
				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x449F90", Offset = "0x449190", VA = "0x180449F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x449FA0", Offset = "0x4491A0", VA = "0x180449FA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public float HBDDFIGJLJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x612180", Offset = "0x611380", VA = "0x180612180")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x612240", Offset = "0x611440", VA = "0x180612240")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3C6EEB0", Offset = "0x3C6E0B0", VA = "0x183C6EEB0")]
			public JJCONKLKJIN(IEnumerator<GGOLJFPNLLB> MIMKAKANKAI, Behaviour NJJLHKPDHIC, DLKJPHLPLHM DPPCDABONBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x3C6EAF0", Offset = "0x3C6DCF0", VA = "0x183C6EAF0")]
			public GGOLJFPNLLB BPDNAEGJJMM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3C6ED90", Offset = "0x3C6DF90", VA = "0x183C6ED90")]
			public bool HELHHPOICIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3C6EA60", Offset = "0x3C6DC60", VA = "0x183C6EA60")]
			public void BDFMNIAJMLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3C6EE20", Offset = "0x3C6E020", VA = "0x183C6EE20", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1256420", Offset = "0x1255620", VA = "0x181256420")]
			[CompilerGenerated]
			private void NLMIEHAKGBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private sealed class DLKJPHLPLHM : OJDAAEIMBMK, INJGDFDPILJ, BNIBEFNPMPN, NIIPAOBAIGP, IEnumerator, GGOLJFPNLLB, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private LKJNHONALLJ KMIDMAPAMNL;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			private LKJNHONALLJ EBBCLCBOOAF
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x46D290", Offset = "0x46C490", VA = "0x18046D290", Slot = "23")]
				get
				{
					return default(LKJNHONALLJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public LKJNHONALLJ NMBNHMIHPEB
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x46D290", Offset = "0x46C490", VA = "0x18046D290")]
				get
				{
					return default(LKJNHONALLJ);
				}
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x606550", Offset = "0x605750", VA = "0x180606550")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			private float OLEBGJKFGED
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x585320", Offset = "0x584520", VA = "0x180585320", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3C68B70", Offset = "0x3C67D70", VA = "0x183C68B70", Slot = "24")]
			private bool EJJCCCMHNOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3C68B60", Offset = "0x3C67D60", VA = "0x183C68B60", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3C68B90", Offset = "0x3C67D90", VA = "0x183C68B90")]
			public DLKJPHLPLHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private enum MAEBBBIKINA : byte
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
		private sealed class FFHBKIIMBKN : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200004C")]
			public enum KPKNINNPMDA
			{
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			public struct FMDCFHCNKCO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public LKJNHONALLJ EFBFNEAMLDD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public KPKNINNPMDA ENKNGHADNNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public List<JJCONKLKJIN> PBHCMOBNIGD;
			}

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private static readonly KPKNINNPMDA[] HABMDMMMBFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private readonly LKJNHONALLJ CONNADNIKEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private bool KPNDJJJMJNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private readonly JJCONKLKJIN[] KELMKLFDKNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private readonly List<JJCONKLKJIN> JEDMOLKKKKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly Stack<int> JCNOLFMJHBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly List<JJCONKLKJIN> GIANKECGLMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly Stack<int> FJHKIGNBLPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private bool NENJLEAGHBN;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public FMDCFHCNKCO[,] JGIGBPEJPAO
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x45C470", Offset = "0x45B670", VA = "0x18045C470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public int JLNLHJPGLFD
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x3C6A660", Offset = "0x3C69860", VA = "0x183C6A660")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3C6B0B0", Offset = "0x3C6A2B0", VA = "0x183C6B0B0")]
			public FFHBKIIMBKN(LKJNHONALLJ MMNFKEFABCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3C69DD0", Offset = "0x3C68FD0", VA = "0x183C69DD0")]
			public void ALGEOPANKFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AA50", Offset = "0x3C69C50", VA = "0x183C6AA50")]
			public void HDFJLMLFOJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3C6A080", Offset = "0x3C69280", VA = "0x183C6A080")]
			private void DFEELJGNDEH(IReadOnlyList<JJCONKLKJIN> IFBKPGJLMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3C6A2E0", Offset = "0x3C694E0", VA = "0x183C6A2E0")]
			public void EHHHHFOOEOM(JJCONKLKJIN MIMKAKANKAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3C6A7D0", Offset = "0x3C699D0", VA = "0x183C6A7D0")]
			public void GGKLDMDLGAN(IList<JJCONKLKJIN> CJHMJKENPJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3C6A3E0", Offset = "0x3C695E0", VA = "0x183C6A3E0")]
			public void EJBMILODCHC(IList<JJCONKLKJIN> CJHMJKENPJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AA60", Offset = "0x3C69C60", VA = "0x183C6AA60")]
			private void JDDLJGFGGBN(JJCONKLKJIN MIMKAKANKAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3C69C60", Offset = "0x3C68E60", VA = "0x183C69C60")]
			private void AIBFLGMOFFM(IList<JJCONKLKJIN> CJHMJKENPJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3C69F00", Offset = "0x3C69100", VA = "0x183C69F00")]
			private MAEBBBIKINA CFMPMIEDELE(JJCONKLKJIN MIMKAKANKAI)
			{
				return default(MAEBBBIKINA);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AB50", Offset = "0x3C69D50", VA = "0x183C6AB50")]
			public void KAKDGOFLCEK(float KJPPOBJONKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AC00", Offset = "0x3C69E00", VA = "0x183C6AC00")]
			public void LGHDFNBLKMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AE00", Offset = "0x3C6A000", VA = "0x183C6AE00")]
			private void NPNNKICFENC(List<JJCONKLKJIN> CJHMJKENPJA, Stack<int> DHPJGKMCDIC, bool AEIPIEBKGOP, float DHDBLHIEKJG = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3C6A1A0", Offset = "0x3C693A0", VA = "0x183C6A1A0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x3C69DE0", Offset = "0x3C68FE0", VA = "0x183C69DE0")]
			private void BFNFPCKOEKP(List<JJCONKLKJIN> CJHMJKENPJA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[ACIMFKLAEAN]
		public enum LKJNHONALLJ
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
		public enum BGCCKIIPFOA : byte
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
		private sealed class NBPMKDCJJCJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
			[DebuggerHidden]
			public NBPMKDCJJCJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x3C719B0", Offset = "0x3C70BB0", VA = "0x183C719B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3C71A30", Offset = "0x3C70C30", VA = "0x183C71A30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private const BGCCKIIPFOA PEOPOGGOIKO = BGCCKIIPFOA.Cancelled | BGCCKIIPFOA.Paused;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly LKJNHONALLJ[] NHMBGHDFJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private FFHBKIIMBKN[] DIDOMMHAPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private CBDIEFCKONB[] NCBKELJDMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Coroutine PFLCPLJBIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private WaitForEndOfFrame NHFJLBHOGGF;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MEEAHKAEEHB CHDACCNIJAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x449450", Offset = "0x448650", VA = "0x180449450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public LKJNHONALLJ PGGAFBGBJJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x449C60", Offset = "0x448E60", VA = "0x180449C60")]
			[CompilerGenerated]
			get
			{
				return default(LKJNHONALLJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x5694F0", Offset = "0x5686F0", VA = "0x1805694F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int JLNLHJPGLFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x3C740C0", Offset = "0x3C732C0", VA = "0x183C740C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3C72F80", Offset = "0x3C72180", VA = "0x183C72F80")]
		public static INJGDFDPILJ GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3C728B0", Offset = "0x3C71AB0", VA = "0x183C728B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3C73170", Offset = "0x3C72370", VA = "0x183C73170", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5020", Offset = "0x2CA4220", VA = "0x182CA5020")]
		private FFHBKIIMBKN PKCDHIFIPKG(LKJNHONALLJ NAFKNBEJLOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7730F0", Offset = "0x7722F0", VA = "0x1807730F0")]
		private CBDIEFCKONB JLGDBDOJOIH(LKJNHONALLJ NAFKNBEJLOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3C73600", Offset = "0x3C72800", VA = "0x183C73600")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3C735D0", Offset = "0x3C727D0", VA = "0x183C735D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3C73E90", Offset = "0x3C73090", VA = "0x183C73E90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3C73040", Offset = "0x3C72240", VA = "0x183C73040")]
		private void MOGKPHLIMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3C73020", Offset = "0x3C72220", VA = "0x183C73020")]
		private void JCILOKAKALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3C72F70", Offset = "0x3C72170", VA = "0x183C72F70")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3C73030", Offset = "0x3C72230", VA = "0x183C73030")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3C72D40", Offset = "0x3C71F40", VA = "0x183C72D40")]
		private void BELIGDOCEOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3C72850", Offset = "0x3C71A50", VA = "0x183C72850")]
		[IteratorStateMachine(typeof(NBPMKDCJJCJ))]
		private IEnumerator ADJNPCJALBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3C737A0", Offset = "0x3C729A0", VA = "0x183C737A0")]
		public INJGDFDPILJ Run(IEnumerator<GGOLJFPNLLB> ANEBFOKKCBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3C737B0", Offset = "0x3C729B0", VA = "0x183C737B0")]
		public INJGDFDPILJ Run(Behaviour NJJLHKPDHIC, IEnumerator<GGOLJFPNLLB> ANEBFOKKCBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3C73670", Offset = "0x3C72870", VA = "0x183C73670")]
		public INJGDFDPILJ RunJobbed(GAKAEFKCHND NJJLHKPDHIC, IEnumerator<GGOLJFPNLLB> ANEBFOKKCBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3C72D50", Offset = "0x3C71F50", VA = "0x183C72D50")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3C73AD0", Offset = "0x3C72CD0", VA = "0x183C73AD0")]
		public void UpdateQueue(LKJNHONALLJ EMGIAHFMKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3C72DB0", Offset = "0x3C71FB0", VA = "0x183C72DB0")]
		private void EIAPGBMGDOM(FFHBKIIMBKN GPKALGNIOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3C73050", Offset = "0x3C72250", VA = "0x183C73050")]
		private void NCNDCHMIPMJ(CBDIEFCKONB GPKALGNIOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3C74040", Offset = "0x3C73240", VA = "0x183C74040")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface MEEAHKAEEHB
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	float AHFBONBMEHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	float LJOBEGPECDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	float IFMCANBMDBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	int CBIGNFIBJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	double LIDNNGFDOLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class MEBADDDCCIE : MEEAHKAEEHB
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float AHFBONBMEHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3C71730", Offset = "0x3C70930", VA = "0x183C71730", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float LJOBEGPECDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C71760", Offset = "0x3C70960", VA = "0x183C71760", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float IFMCANBMDBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3C71780", Offset = "0x3C70980", VA = "0x183C71780", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int CBIGNFIBJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3C71770", Offset = "0x3C70970", VA = "0x183C71770", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public double LIDNNGFDOLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3C71740", Offset = "0x3C70940", VA = "0x183C71740", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
	public MEBADDDCCIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OBLNNCFOJBK : KPJMAACMKMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public int DNNAHAHOHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Queue<double> DGMJJPNLMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private double JBECICLHIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double IAKGHEEOJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private double HANAIHPJDFG;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int FPONOLKGFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C72500", Offset = "0x3C71700", VA = "0x183C72500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public double CINNHAMBAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3C72540", Offset = "0x3C71740", VA = "0x183C72540", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public double MMLEJOODGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA24390", Offset = "0xA23590", VA = "0x180A24390", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public double PKGAOFIMBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA24370", Offset = "0xA23570", VA = "0x180A24370", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3C72710", Offset = "0x3C71910", VA = "0x183C72710")]
	public OBLNNCFOJBK(int FBBGACCANLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C72610", Offset = "0x3C71810", VA = "0x183C72610", Slot = "4")]
	public void MLEJIOLFBHB(double HKPKIJKKGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3C725A0", Offset = "0x3C717A0", VA = "0x183C725A0", Slot = "5")]
	public void DBBNEPGCPGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MFMCDCIANNF : KPJMAACMKMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private long CLGAFDJGDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private double JFFMHFAABLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private double BHCFHKCAKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private double ELHFEAMPCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private double FAAGDAIBONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private double JBECICLHIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private double IAKGHEEOJCJ;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long JHLGEIGBNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public double MMLEJOODGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA24380", Offset = "0xA23580", VA = "0x180A24380", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public double PKGAOFIMBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4A0", Offset = "0x7CA6A0", VA = "0x1807CB4A0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public double FPLCAOLDGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA24370", Offset = "0xA23570", VA = "0x180A24370")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public double PBDAKODEAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x38C2ED0", Offset = "0x38C20D0", VA = "0x1838C2ED0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public double CINNHAMBAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA242A0", Offset = "0xA234A0", VA = "0x180A242A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3C71820", Offset = "0x3C70A20", VA = "0x183C71820", Slot = "4")]
	public void MLEJIOLFBHB(double HKPKIJKKGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3C717E0", Offset = "0x3C709E0", VA = "0x183C717E0", Slot = "5")]
	public void DBBNEPGCPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3C71940", Offset = "0x3C70B40", VA = "0x183C71940")]
	public MFMCDCIANNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface KPJMAACMKMI
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	double CINNHAMBAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	double MMLEJOODGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	double PKGAOFIMBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLEJIOLFBHB(double HKPKIJKKGDA);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBBNEPGCPGP();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class BKPPGMCBMHH
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private interface BJOOKPMBPCD
	{
		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool LKJPFIFLDHF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JFAIONIJMNI();

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BDFMNIAJMLF();
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class DECOHBHCCGE<TPromise, TMainThreadPromise> : BJOOKPMBPCD where TPromise : NIIPAOBAIGP where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly TPromise JHGIJFDNLHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		protected readonly TMainThreadPromise EIMAFOBLAMH;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public TPromise GANJFGDMPAK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2E4D1D0", Offset = "0x2E4C3D0", VA = "0x182E4D1D0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool LKJPFIFLDHF
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x2E4D150", Offset = "0x2E4C350", VA = "0x182E4D150", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2709800", Offset = "0x2708A00", VA = "0x182709800")]
		protected DECOHBHCCGE(TPromise JHGIJFDNLHD, TMainThreadPromise MHMLEKDMGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2E4D1A0", Offset = "0x2E4C3A0", VA = "0x182E4D1A0", Slot = "5")]
		public void JFAIONIJMNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x20416E0", Offset = "0x20408E0", VA = "0x1820416E0", Slot = "6")]
		public void BDFMNIAJMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void BKOLKMMKOJA(TPromise JHGIJFDNLHD);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void KNJFJHDIOIK();
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class CGOBELBIGID<T> : DECOHBHCCGE<global::IJNOJIGJDDE<T>, global::MIIAPOFCBNK<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2E4CB10", Offset = "0x2E4BD10", VA = "0x182E4CB10")]
		public CGOBELBIGID(global::IJNOJIGJDDE<T> JHGIJFDNLHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2E4C830", Offset = "0x2E4BA30", VA = "0x182E4C830", Slot = "7")]
		protected override void BKOLKMMKOJA(global::IJNOJIGJDDE<T> JHGIJFDNLHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2E4CA60", Offset = "0x2E4BC60", VA = "0x182E4CA60", Slot = "8")]
		protected override void KNJFJHDIOIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2E4CAC0", Offset = "0x2E4BCC0", VA = "0x182E4CAC0")]
		[CompilerGenerated]
		private void OGFIFBOJBBC(T LEFCDNPGKCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2E4C9D0", Offset = "0x2E4BBD0", VA = "0x182E4C9D0")]
		[CompilerGenerated]
		private void GIELDNFKGNC(string HEEKCGODMHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class NJDIEDCOKNL : DECOHBHCCGE<NIIPAOBAIGP, DKPBLMEPKBG>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3C72370", Offset = "0x3C71570", VA = "0x183C72370")]
		public NJDIEDCOKNL(NIIPAOBAIGP JHGIJFDNLHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3C72250", Offset = "0x3C71450", VA = "0x183C72250", Slot = "7")]
		protected override void BKOLKMMKOJA(NIIPAOBAIGP JHGIJFDNLHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C72320", Offset = "0x3C71520", VA = "0x183C72320", Slot = "8")]
		protected override void KNJFJHDIOIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x153E490", Offset = "0x153D690", VA = "0x18153E490")]
		[CompilerGenerated]
		private void OGFIFBOJBBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1A7AFA0", Offset = "0x1A7A1A0", VA = "0x181A7AFA0")]
		[CompilerGenerated]
		private void GIELDNFKGNC(string HEEKCGODMHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private class APMDHLBNCFJ : BJOOKPMBPCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly Action HIOFDPALGPA;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool LKJPFIFLDHF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x449F60", Offset = "0x449160", VA = "0x180449F60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x54EC10", Offset = "0x54DE10", VA = "0x18054EC10")]
		public APMDHLBNCFJ(Action HIOFDPALGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA33930", Offset = "0xA32B30", VA = "0x180A33930", Slot = "5")]
		public void JFAIONIJMNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "6")]
		public void BDFMNIAJMLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly List<BJOOKPMBPCD> JCKOLGDBNME;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x23D8950", Offset = "0x23D7B50", VA = "0x1823D8950")]
	public static global::IJNOJIGJDDE<T> NBAELGEHJPH<T>(this global::IJNOJIGJDDE<T> JHGIJFDNLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3C631F0", Offset = "0x3C623F0", VA = "0x183C631F0")]
	public static NIIPAOBAIGP NBAELGEHJPH(this NIIPAOBAIGP JHGIJFDNLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3C63300", Offset = "0x3C62500", VA = "0x183C63300")]
	public static void NBAELGEHJPH(Action HIOFDPALGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x23D87D0", Offset = "0x23D79D0", VA = "0x1823D87D0")]
	private static global::IJNOJIGJDDE<T> GAPAKMJLLKN<T>(global::IJNOJIGJDDE<T> JHGIJFDNLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3C63060", Offset = "0x3C62260", VA = "0x183C63060")]
	private static NIIPAOBAIGP GAPAKMJLLKN(NIIPAOBAIGP JHGIJFDNLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3C62E80", Offset = "0x3C62080", VA = "0x183C62E80")]
	private static void DEDPAPKBHNM(BJOOKPMBPCD PMMLFIEDKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3C63380", Offset = "0x3C62580", VA = "0x183C63380")]
	private static void NPJJFFEIFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x3C62DB0", Offset = "0x3C61FB0", VA = "0x183C62DB0")]
	private static void AFJFILGJMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3C63140", Offset = "0x3C62340", VA = "0x183C63140")]
	private static void JKEMMLOIHEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class FPDKIBDKAKK
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class HBOPACGFEDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public DKPBLMEPKBG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
		public HBOPACGFEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CE70", Offset = "0x3C6C070", VA = "0x183C6CE70")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CE60", Offset = "0x3C6C060", VA = "0x183C6CE60")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class DFHGCHEBDKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
		public DFHGCHEBDKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3C68850", Offset = "0x3C67A50", VA = "0x183C68850")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class AGPGDNMHLCH : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public DKPBLMEPKBG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public AGPGDNMHLCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3C62470", Offset = "0x3C61670", VA = "0x183C62470", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3C62160", Offset = "0x3C61360", VA = "0x183C62160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3C62520", Offset = "0x3C61720", VA = "0x183C62520")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3C62420", Offset = "0x3C61620", VA = "0x183C62420", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class KLLJCPJOCKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public DKPBLMEPKBG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
		public KLLJCPJOCKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class HIGIAGAKNLC : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private GGOLJFPNLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public DKPBLMEPKBG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private KLLJCPJOCKO <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public HIGIAGAKNLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D0E0", Offset = "0x3C6C2E0", VA = "0x183C6D0E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D3F0", Offset = "0x3C6C5F0", VA = "0x183C6D3F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public const string EJMDGCKPCII = "empty";

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public const string PNJBOFCNCIJ = "moderator";

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public const string GPIIMLGDHPP = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public const string OBECDDLPKPK = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public const string DANINBGHNGL = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const float OKAJHILJGFE = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static NIIPAOBAIGP HNJOCIHLALN;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static AsyncOperation ELJOLHEKPAO;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static NIIPAOBAIGP MCODHOEFPJA;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static string PHOEACFAOOG;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static ThreadPriority IMDOFODFPKF;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public static bool OEIINGOBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3C6BAB0", Offset = "0x3C6ACB0", VA = "0x183C6BAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private static bool KBKPJAFMIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3C6BD60", Offset = "0x3C6AF60", VA = "0x183C6BD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private static bool FJJOFBIGDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B6C0", Offset = "0x3C6A8C0", VA = "0x183C6B6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<string, LoadSceneMode> IBEDBOKLGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B720", Offset = "0x3C6A920", VA = "0x183C6B720")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3C6BA00", Offset = "0x3C6AC00", VA = "0x183C6BA00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3C6B8C0", Offset = "0x3C6AAC0", VA = "0x183C6B8C0")]
	public static NIIPAOBAIGP CMGAPDHDHCP(string HDKLMHMNODL, LoadSceneMode HKHOMCOIEFC = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3C6BB50", Offset = "0x3C6AD50", VA = "0x183C6BB50")]
	public static NIIPAOBAIGP IKPBPELIHIA(string HDKLMHMNODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3C6B7D0", Offset = "0x3C6A9D0", VA = "0x183C6B7D0")]
	[IteratorStateMachine(typeof(AGPGDNMHLCH))]
	private static IEnumerator<GGOLJFPNLLB> BMFHEGAICAC(string HDKLMHMNODL, DKPBLMEPKBG IOKNOCEPKAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3C6B840", Offset = "0x3C6AA40", VA = "0x183C6B840")]
	[IteratorStateMachine(typeof(HIGIAGAKNLC))]
	private static IEnumerator<GGOLJFPNLLB> CENFBBFPAMN(string HDKLMHMNODL, LoadSceneMode HKHOMCOIEFC, DKPBLMEPKBG IOKNOCEPKAI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KIIENADHBAP
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static byte[] JHNDOHIGIOO;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static int MADEGOKLHIN;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static int MONIHPJNDGC;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static BigInteger PDPNCLAKIEF;

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
	public KIIENADHBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3C6FC20", Offset = "0x3C6EE20", VA = "0x183C6FC20")]
	private static string BNMKEPLLJLH(byte[] PADLHGFNBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x3C6FD20", Offset = "0x3C6EF20", VA = "0x183C6FD20")]
	public static string GOGNAPBDLJC(byte[] POCBBJNICOK, bool NLKNEOPMNBJ)
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
		[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
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

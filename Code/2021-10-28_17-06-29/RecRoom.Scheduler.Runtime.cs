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
				[Cpp2IlInjected.Address(RVA = "0x3C00970", Offset = "0x3BFFB70", VA = "0x183C00970")]
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
				[Cpp2IlInjected.Address(RVA = "0x3C00B10", Offset = "0x3BFFD10", VA = "0x183C00B10")]
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
				[Cpp2IlInjected.Address(RVA = "0x3C05480", Offset = "0x3C04680", VA = "0x183C05480")]
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
					[Cpp2IlInjected.Address(RVA = "0x3C09BF0", Offset = "0x3C08DF0", VA = "0x183C09BF0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable KNJFCMLLALP;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x3C00170", Offset = "0x3BFF370", VA = "0x183C00170")]
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
					[Cpp2IlInjected.Address(RVA = "0x3C08A20", Offset = "0x3C07C20", VA = "0x183C08A20")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x3BFD860", Offset = "0x3BFCA60", VA = "0x183BFD860")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C028E0", Offset = "0x3C01AE0", VA = "0x183C028E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BFF7C0", Offset = "0x3BFE9C0", VA = "0x183BFF7C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3BFF900", Offset = "0x3BFEB00", VA = "0x183BFF900")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE600", Offset = "0x3BFD800", VA = "0x183BFE600")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF940", Offset = "0x3BFEB40", VA = "0x183BFF940")]
		private static void PEKNCBLJHIH(IPNDGFGNGMF.PPKIEBBKLPJ KPLFFOGJEBN, ref PlayerLoopSystem NABGMLKHEAJ, Type JOCBENFOHFM, Type HMIFEEKEGOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF450", Offset = "0x3BFE650", VA = "0x183BFF450")]
		private static void DBHBNJEKABA(ref PlayerLoopSystem NABGMLKHEAJ, Type JOCBENFOHFM, Type HMIFEEKEGOC, HHALGHDIJOF IOBANLJOFOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF800", Offset = "0x3BFEA00", VA = "0x183BFF800")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C036B0", Offset = "0x3C028B0", VA = "0x183C036B0")]
		public GIMLEKGCGFB(PPKIEBBKLPJ MHNDNNAAMOG, int MMDIHGFLIFL = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3C03620", Offset = "0x3C02820", VA = "0x183C03620")]
		public void JLAIIFEKHEG(int ODJDKHBDAGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C03640", Offset = "0x3C02840", VA = "0x183C03640")]
		public void NIAHBMIGNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3C03520", Offset = "0x3C02720", VA = "0x183C03520")]
		public void EAEOKJFLBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C03350", Offset = "0x3C02550", VA = "0x183C03350")]
		public void BHEDNIIAIJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3C03580", Offset = "0x3C02780", VA = "0x183C03580")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C05AD0", Offset = "0x3C04CD0", VA = "0x183C05AD0")]
	public static GIMLEKGCGFB DEIJALIHLNB(PPKIEBBKLPJ KPLFFOGJEBN, int MMDIHGFLIFL = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3C05D10", Offset = "0x3C04F10", VA = "0x183C05D10")]
	public static GIMLEKGCGFB MOLELLHGMKB(PPKIEBBKLPJ KPLFFOGJEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3C05C60", Offset = "0x3C04E60", VA = "0x183C05C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BFA1D0", Offset = "0x3BF93D0", VA = "0x183BFA1D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BFA1D0", Offset = "0x3BF93D0", VA = "0x183BFA1D0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float IMNDJDAEFMC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3BFFE70", Offset = "0x3BFF070", VA = "0x183BFFE70")]
	public DHEFBKCNKPE(Behaviour NJJLHKPDHIC, float IMNDJDAEFMC, [Optional] Action CECCANJHFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3BFFCD0", Offset = "0x3BFEED0", VA = "0x183BFFCD0", Slot = "9")]
	protected override bool OGBIFPPIOJP(Action HIOFDPALGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3BFFDA0", Offset = "0x3BFEFA0", VA = "0x183BFFDA0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C029E0", Offset = "0x3C01BE0", VA = "0x183C029E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C02A80", Offset = "0x3C01C80", VA = "0x183C02A80", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F0BE0", Offset = "0x7EFDE0", VA = "0x1807F0BE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action INJNBOOEFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA080", Offset = "0x3BF9280", VA = "0x183BFA080", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9D40", Offset = "0x3BF8F40", VA = "0x183BF9D40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C4A240", Offset = "0x1C49440", VA = "0x181C4A240")]
	protected BEOAILMBIMK(Behaviour NJJLHKPDHIC, [Optional] Action CECCANJHFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA170", Offset = "0x3BF9370", VA = "0x183BFA170", Slot = "7")]
	public bool OCKGJFDLDOA(bool EODOFAPEKHA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA120", Offset = "0x3BF9320", VA = "0x183BFA120", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3BF9D00", Offset = "0x3BF8F00", VA = "0x183BF9D00")]
	protected void AJHKPAEDEFE(Action HIOFDPALGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9EB0", Offset = "0x3BF90B0", VA = "0x183BF9EB0")]
	protected NIIPAOBAIGP KGNMOABLJAD(float EOLDNHCPEIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9E40", Offset = "0x3BF9040", VA = "0x183BF9E40")]
	private void JBEOAABOAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9DE0", Offset = "0x3BF8FE0", VA = "0x183BF9DE0")]
	[IteratorStateMachine(typeof(FIKLBAGKODP))]
	private static IEnumerator<GGOLJFPNLLB> GJIEKCJEEAM(float EOLDNHCPEIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9D20", Offset = "0x3BF8F20", VA = "0x183BF9D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E4620", Offset = "0x4E3820", VA = "0x1804E4620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3C058D0", Offset = "0x3C04AD0", VA = "0x183C058D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C056B0", Offset = "0x3C048B0", VA = "0x183C056B0", Slot = "10")]
	protected override bool PMLKDEDCMPD(Action HIOFDPALGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3C05620", Offset = "0x3C04820", VA = "0x183C05620")]
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
	[Cpp2IlInjected.Address(RVA = "0x3BFFE70", Offset = "0x3BFF070", VA = "0x183BFFE70")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C00130", Offset = "0x3BFF330", VA = "0x183C00130", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E1560", Offset = "0x4E0760", VA = "0x1804E1560")]
	public DMAILHAJGLH(Action KJNNEFPKNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3C00040", Offset = "0x3BFF240", VA = "0x183C00040", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x16F2AE0", Offset = "0x16F1CE0", VA = "0x1816F2AE0")]
		public PAAOCKEPNBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3545B10", Offset = "0x3544D10", VA = "0x183545B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3540290", Offset = "0x353F490", VA = "0x183540290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T NMGCHANKNIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5B0730", Offset = "0x5AF930", VA = "0x1805B0730", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x353FCF0", Offset = "0x353EEF0", VA = "0x18353FCF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x35404D0", Offset = "0x353F6D0", VA = "0x1835404D0")]
	private static bool NIMKBKDPLDP(T CKOFPIFLMON, T PADLHGFNBLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3279610", Offset = "0x3278810", VA = "0x183279610")]
	public BDAJBBDDLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3540C10", Offset = "0x353FE10", VA = "0x183540C10")]
	public BDAJBBDDLCF(T EIMNCGLBBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3540040", Offset = "0x353F240", VA = "0x183540040")]
	public void HOKJOMHMENN(T CFMONMCILIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x353FE90", Offset = "0x353F090", VA = "0x18353FE90", Slot = "7")]
	public IDisposable FNNDKMHBPDP(Action<T> LMEKCNOJCOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x353FF00", Offset = "0x353F100", VA = "0x18353FF00", Slot = "8")]
	public IDisposable FNNDKMHBPDP(UnityEngine.Object NJJLHKPDHIC, Action<T> LMEKCNOJCOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3540860", Offset = "0x353FA60", VA = "0x183540860")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C059E0", Offset = "0x3C04BE0", VA = "0x183C059E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3C05A80", Offset = "0x3C04C80", VA = "0x183C05A80", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C08BE0", Offset = "0x3C07DE0", VA = "0x183C08BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BF9A00", Offset = "0x3BF8C00", VA = "0x183BF9A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9AF0", Offset = "0x3BF8CF0", VA = "0x183BF9AF0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C07940", Offset = "0x3C06B40", VA = "0x183C07940")]
	public static GGOLJFPNLLB NLJAPPHHPEK(float NFANCAJAMHK, Scheduler.LKJNHONALLJ MMNFKEFABCC = Scheduler.LKJNHONALLJ.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3C07830", Offset = "0x3C06A30", VA = "0x183C07830")]
	public static GGOLJFPNLLB JBEAIIAPNIH(float NFANCAJAMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3C07A20", Offset = "0x3C06C20", VA = "0x183C07A20")]
	[IteratorStateMachine(typeof(IICFOBKEBOP))]
	public static IEnumerator<GGOLJFPNLLB> PDEMHIOOAMK(float NFANCAJAMHK, Scheduler.LKJNHONALLJ MMNFKEFABCC = Scheduler.LKJNHONALLJ.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3C07780", Offset = "0x3C06980", VA = "0x183C07780")]
	public static GGOLJFPNLLB AEDBFJDPPOG(Func<bool> BOCBJHIKCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3C07890", Offset = "0x3C06A90", VA = "0x183C07890")]
	public static GGOLJFPNLLB NDOGBHINALO(NIIPAOBAIGP DPPCDABONBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3C077E0", Offset = "0x3C069E0", VA = "0x183C077E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C09830", Offset = "0x3C08A30", VA = "0x183C09830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C09900", Offset = "0x3C08B00", VA = "0x183C09900", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C08ED0", Offset = "0x3C080D0", VA = "0x183C08ED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C08FC0", Offset = "0x3C081C0", VA = "0x183C08FC0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE9CA0", Offset = "0xCE8EA0", VA = "0x180CE9CA0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C00360", Offset = "0x3BFF560", VA = "0x183C00360")]
	public static INJGDFDPILJ DNNDJHLFLON(Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3C00270", Offset = "0x3BFF470", VA = "0x183C00270")]
	public static INJGDFDPILJ DNNDJHLFLON(Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3C00450", Offset = "0x3BFF650", VA = "0x183C00450")]
	public static INJGDFDPILJ DNNDJHLFLON(Behaviour NJJLHKPDHIC, Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3C00560", Offset = "0x3BFF760", VA = "0x183C00560")]
	public static INJGDFDPILJ DNNDJHLFLON(Behaviour NJJLHKPDHIC, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C00670", Offset = "0x3BFF870", VA = "0x183C00670")]
	public static INJGDFDPILJ FJCHNBKHPMM(GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3C00780", Offset = "0x3BFF980", VA = "0x183C00780")]
	public static INJGDFDPILJ FJCHNBKHPMM(GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3C00900", Offset = "0x3BFFB00", VA = "0x183C00900")]
	[IteratorStateMachine(typeof(NNKABDHCELE))]
	private static IEnumerator<GGOLJFPNLLB> JBEEPOJEJJB(Scheduler.LKJNHONALLJ MMNFKEFABCC, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3C00890", Offset = "0x3BFFA90", VA = "0x183C00890")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C00CB0", Offset = "0x3BFFEB0", VA = "0x183C00CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C00E50", Offset = "0x3C00050", VA = "0x183C00E50", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xB98120", Offset = "0xB97320", VA = "0x180B98120")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA8D480", Offset = "0xA8C680", VA = "0x180A8D480")]
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
		[Cpp2IlInjected.Address(RVA = "0x4FBEB0", Offset = "0x4FB0B0", VA = "0x1804FBEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float ECBIEEGMNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xCC65F0", Offset = "0xCC57F0", VA = "0x180CC65F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xF21360", Offset = "0xF20560", VA = "0x180F21360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float LJOBEGPECDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xCC6600", Offset = "0xCC5800", VA = "0x180CC6600")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xF74560", Offset = "0xF73760", VA = "0x180F74560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3C08940", Offset = "0x3C07B40", VA = "0x183C08940")]
	public LDMLJCGGKBM(float HNBFDCHIJCB, Scheduler.LKJNHONALLJ MMNFKEFABCC = Scheduler.LKJNHONALLJ.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3C085E0", Offset = "0x3C077E0", VA = "0x183C085E0", Slot = "5")]
	public bool BBNJEALAHBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C088B0", Offset = "0x3C07AB0", VA = "0x183C088B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C08600", Offset = "0x3C07800", VA = "0x183C08600")]
	public static INJGDFDPILJ DNNDJHLFLON(float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C086B0", Offset = "0x3C078B0", VA = "0x183C086B0")]
	public static INJGDFDPILJ DNNDJHLFLON(MonoBehaviour BOGCAKPFCPM, float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C087F0", Offset = "0x3C079F0", VA = "0x183C087F0")]
	public static INJGDFDPILJ LOAEHKNHKAH(GAKAEFKCHND NJJLHKPDHIC, float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C08770", Offset = "0x3C07970", VA = "0x183C08770")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CABC0", Offset = "0x4C9DC0", VA = "0x1804CABC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Scheduler.LKJNHONALLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4FDEC0", Offset = "0x4FD0C0", VA = "0x1804FDEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public float ECBIEEGMNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xB98120", Offset = "0xB97320", VA = "0x180B98120", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA8D480", Offset = "0xA8C680", VA = "0x180A8D480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9580", Offset = "0x3BF8780", VA = "0x183BF9580")]
	public AANFBDLGPAJ(Func<bool> BOCBJHIKCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9540", Offset = "0x3BF8740", VA = "0x183BF9540")]
	public AANFBDLGPAJ(Scheduler.LKJNHONALLJ CONNADNIKEF, Func<bool> BOCBJHIKCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BF94F0", Offset = "0x3BF86F0", VA = "0x183BF94F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BFFEC0", Offset = "0x3BFF0C0", VA = "0x183BFFEC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3BFFF60", Offset = "0x3BFF160", VA = "0x183BFFF60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9B40", Offset = "0x3BF8D40", VA = "0x183BF9B40")]
	[IteratorStateMachine(typeof(DIJHNHPKAPK))]
	private static IEnumerator<GGOLJFPNLLB> HFHIJOHAMIM(Scheduler.LKJNHONALLJ CONNADNIKEF, Func<bool> BOCBJHIKCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9BB0", Offset = "0x3BF8DB0", VA = "0x183BF9BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x57C270", Offset = "0x57B470", VA = "0x18057C270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float ECBIEEGMNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xB4D720", Offset = "0xB4C920", VA = "0x180B4D720", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xAAD320", Offset = "0xAAC520", VA = "0x180AAD320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3C032A0", Offset = "0x3C024A0", VA = "0x183C032A0")]
	public GBNLJNPCDLA(float NFANCAJAMHK, Scheduler.LKJNHONALLJ MMNFKEFABCC = Scheduler.LKJNHONALLJ.Update)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3C03210", Offset = "0x3C02410", VA = "0x183C03210", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE9CA0", Offset = "0xCE8EA0", VA = "0x180CE9CA0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3769BF0", Offset = "0x3768DF0", VA = "0x183769BF0")]
	public LMGFBPONJAC(float NFANCAJAMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3C08AE0", Offset = "0x3C07CE0", VA = "0x183C08AE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C095A0", Offset = "0x3C087A0", VA = "0x183C095A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C09650", Offset = "0x3C08850", VA = "0x183C09650", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C00FA0", Offset = "0x3C001A0", VA = "0x183C00FA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C01060", Offset = "0x3C00260", VA = "0x183C01060", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB650", Offset = "0x3BFA850", VA = "0x183BFB650")]
	[IteratorStateMachine(typeof(NHBNGMFDPNF))]
	private static IEnumerator<GGOLJFPNLLB> OFLBOEBJEFE(float NFANCAJAMHK, Scheduler.LKJNHONALLJ MMNFKEFABCC, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB490", Offset = "0x3BFA690", VA = "0x183BFB490")]
	[IteratorStateMachine(typeof(FCDGPCJFKIO))]
	private static IEnumerator<GGOLJFPNLLB> JOCIANPPGAD(float NFANCAJAMHK, Scheduler.LKJNHONALLJ MMNFKEFABCC, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAC70", Offset = "0x3BF9E70", VA = "0x183BFAC70")]
	public static IDisposable EJGHIDOMKFH(this MonoBehaviour BOGCAKPFCPM, float NFANCAJAMHK, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB240", Offset = "0x3BFA440", VA = "0x183BFB240")]
	public static INJGDFDPILJ JNAFLIAIHMM(this MonoBehaviour BOGCAKPFCPM, float NFANCAJAMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3BFADB0", Offset = "0x3BF9FB0", VA = "0x183BFADB0")]
	public static INJGDFDPILJ EJGHIDOMKFH(this MonoBehaviour BOGCAKPFCPM, float NFANCAJAMHK, Scheduler.LKJNHONALLJ MMNFKEFABCC, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB510", Offset = "0x3BFA710", VA = "0x183BFB510")]
	public static INJGDFDPILJ JOJHKFNPMBA(this MonoBehaviour BOGCAKPFCPM, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB230", Offset = "0x3BFA430", VA = "0x183BFB230")]
	public static INJGDFDPILJ IGAAHHLIAJK(this MonoBehaviour BOGCAKPFCPM, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB630", Offset = "0x3BFA830", VA = "0x183BFB630")]
	public static INJGDFDPILJ MPGIHPHHGBI(this MonoBehaviour BOGCAKPFCPM, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAC60", Offset = "0x3BF9E60", VA = "0x183BFAC60")]
	public static INJGDFDPILJ CCANPLLMIDG(this MonoBehaviour BOGCAKPFCPM, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB640", Offset = "0x3BFA840", VA = "0x183BFB640")]
	public static INJGDFDPILJ NEOHIEMEHPL(this MonoBehaviour BOGCAKPFCPM, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB380", Offset = "0x3BFA580", VA = "0x183BFB380")]
	private static INJGDFDPILJ JOACPAOCCOP(MonoBehaviour BOGCAKPFCPM, Scheduler.LKJNHONALLJ CONNADNIKEF, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAB50", Offset = "0x3BF9D50", VA = "0x183BFAB50")]
	public static INJGDFDPILJ BAEHILAHGHI(this MonoBehaviour BOGCAKPFCPM, float DFBNPJMCJJG, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAF00", Offset = "0x3BFA100", VA = "0x183BFAF00")]
	public static INJGDFDPILJ FDNINMNCJJI(this MonoBehaviour BOGCAKPFCPM, float DFBNPJMCJJG, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB120", Offset = "0x3BFA320", VA = "0x183BFB120")]
	public static INJGDFDPILJ GGOLDJLMCFD(this MonoBehaviour BOGCAKPFCPM, float DFBNPJMCJJG, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB010", Offset = "0x3BFA210", VA = "0x183BFB010")]
	public static INJGDFDPILJ FPONAEILDEN(this MonoBehaviour BOGCAKPFCPM, float DFBNPJMCJJG, Action BHMHKBCBJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB520", Offset = "0x3BFA720", VA = "0x183BFB520")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C00EA0", Offset = "0x3C000A0", VA = "0x183C00EA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3C00F50", Offset = "0x3C00150", VA = "0x183C00F50", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C06C00", Offset = "0x3C05E00", VA = "0x183C06C00")]
	public KANDFMDMBPI(MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3C06D90", Offset = "0x3C05F90", VA = "0x183C06D90")]
	public KANDFMDMBPI(MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C06F20", Offset = "0x3C06120", VA = "0x183C06F20")]
	public KANDFMDMBPI(MonoBehaviour BOGCAKPFCPM, float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C06620", Offset = "0x3C05820", VA = "0x183C06620")]
	private void DNNDJHLFLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3C06A80", Offset = "0x3C05C80", VA = "0x183C06A80")]
	private void NCEPDNJHLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3C06950", Offset = "0x3C05B50", VA = "0x183C06950")]
	private void KMBKEOKDDCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3C06500", Offset = "0x3C05700", VA = "0x183C06500")]
	private void DHKMICHIAHM(string HEEKCGODMHP, Action CNHLOEGEHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3C067F0", Offset = "0x3C059F0", VA = "0x183C067F0")]
	[IteratorStateMachine(typeof(EPFJPMMODMK))]
	private IEnumerator<GGOLJFPNLLB> FPJJANOINFD(Action CNHLOEGEHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3C067A0", Offset = "0x3C059A0", VA = "0x183C067A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3C06850", Offset = "0x3C05A50", VA = "0x183C06850")]
	[CompilerGenerated]
	private void GDGEPJHFDOE(string BIDEGMIFHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3C068D0", Offset = "0x3C05AD0", VA = "0x183C068D0")]
	[CompilerGenerated]
	private void JAPDFPBJIOF(string BIDEGMIFHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3C06480", Offset = "0x3C05680", VA = "0x183C06480")]
	[CompilerGenerated]
	private void CCGPAKIMGNM(string BIDEGMIFHOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CMOCKNILJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3BFDB50", Offset = "0x3BFCD50", VA = "0x183BFDB50")]
	public static IDisposable DNNDJHLFLON(this MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3BFDBD0", Offset = "0x3BFCDD0", VA = "0x183BFDBD0")]
	public static IDisposable DNNDJHLFLON(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE1A0", Offset = "0x3BFD3A0", VA = "0x183BFE1A0")]
	public static IDisposable KAKDGOFLCEK(this MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3BFD9E0", Offset = "0x3BFCBE0", VA = "0x183BFD9E0")]
	public static IDisposable BNGDKHPHFBM(this MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3BFDF20", Offset = "0x3BFD120", VA = "0x183BFDF20")]
	public static IDisposable IGPOEJCMDBK(this MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE320", Offset = "0x3BFD520", VA = "0x183BFE320")]
	public static IDisposable MALLCOMOHDK(this MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE590", Offset = "0x3BFD790", VA = "0x183BFE590")]
	public static IDisposable PHJGAIMGFEC(this MonoBehaviour BOGCAKPFCPM, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE210", Offset = "0x3BFD410", VA = "0x183BFE210")]
	public static IDisposable KKCCDEAKMAI(this MonoBehaviour BOGCAKPFCPM, float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE2A0", Offset = "0x3BFD4A0", VA = "0x183BFE2A0")]
	public static IDisposable KNMELKKKIDB(this MonoBehaviour BOGCAKPFCPM, float BIAFGNMJLIB, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3BFDAD0", Offset = "0x3BFCCD0", VA = "0x183BFDAD0")]
	public static IDisposable DEBFANDBIJM(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3BFDE20", Offset = "0x3BFD020", VA = "0x183BFDE20")]
	public static IDisposable EICLMCAONCM(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE410", Offset = "0x3BFD610", VA = "0x183BFE410")]
	public static IDisposable OGIJDGBNLAF(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE020", Offset = "0x3BFD220", VA = "0x183BFE020")]
	public static IDisposable JAIANFAJIJA(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE0A0", Offset = "0x3BFD2A0", VA = "0x183BFE0A0")]
	public static IDisposable JBIEJEAONIA(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3BFDA50", Offset = "0x3BFCC50", VA = "0x183BFDA50")]
	public static IDisposable CKIGAIGOAGJ(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3BFDD90", Offset = "0x3BFCF90", VA = "0x183BFDD90")]
	public static IDisposable DPPKBCFDGHM(this MonoBehaviour BOGCAKPFCPM, float BIAFGNMJLIB, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE490", Offset = "0x3BFD690", VA = "0x183BFE490")]
	public static IDisposable OHHAHNDBALE(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3BFDEA0", Offset = "0x3BFD0A0", VA = "0x183BFDEA0")]
	public static IDisposable HAGLLEAPEGL(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE510", Offset = "0x3BFD710", VA = "0x183BFE510")]
	public static IDisposable PFIENKMEOID(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3BFDF90", Offset = "0x3BFD190", VA = "0x183BFDF90")]
	public static IDisposable IJFOIEFMNOM(this MonoBehaviour BOGCAKPFCPM, float BIAFGNMJLIB, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3BFD960", Offset = "0x3BFCB60", VA = "0x183BFD960")]
	public static IDisposable BJPGPAKMOAN(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE120", Offset = "0x3BFD320", VA = "0x183BFE120")]
	public static IDisposable JCIDEKGBNCB(this MonoBehaviour BOGCAKPFCPM, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE390", Offset = "0x3BFD590", VA = "0x183BFE390")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BFFBA0", Offset = "0x3BFEDA0", VA = "0x183BFFBA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3BFFC50", Offset = "0x3BFEE50", VA = "0x183BFFC50", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C051A0", Offset = "0x3C043A0", VA = "0x183C051A0")]
	public HJOMFAGAHGA(GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3C05010", Offset = "0x3C04210", VA = "0x183C05010")]
	public HJOMFAGAHGA(GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3C05330", Offset = "0x3C04530", VA = "0x183C05330")]
	public HJOMFAGAHGA(GAKAEFKCHND NJJLHKPDHIC, float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3C04A30", Offset = "0x3C03C30", VA = "0x183C04A30")]
	private void DNNDJHLFLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3C04E90", Offset = "0x3C04090", VA = "0x183C04E90")]
	private void NCEPDNJHLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3C04D60", Offset = "0x3C03F60", VA = "0x183C04D60")]
	private void KMBKEOKDDCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3C04910", Offset = "0x3C03B10", VA = "0x183C04910")]
	private void DHKMICHIAHM(string HEEKCGODMHP, Action CNHLOEGEHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3C04C00", Offset = "0x3C03E00", VA = "0x183C04C00")]
	[IteratorStateMachine(typeof(DDKKNLKEBJL))]
	private IEnumerator<GGOLJFPNLLB> FPJJANOINFD(Action CNHLOEGEHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3C04BB0", Offset = "0x3C03DB0", VA = "0x183C04BB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3C04C60", Offset = "0x3C03E60", VA = "0x183C04C60")]
	[CompilerGenerated]
	private void GDGEPJHFDOE(string BIDEGMIFHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3C04CE0", Offset = "0x3C03EE0", VA = "0x183C04CE0")]
	[CompilerGenerated]
	private void JAPDFPBJIOF(string BIDEGMIFHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3C04890", Offset = "0x3C03A90", VA = "0x183C04890")]
	[CompilerGenerated]
	private void CCGPAKIMGNM(string BIDEGMIFHOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HAGBOLOAIJH
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3C03EB0", Offset = "0x3C030B0", VA = "0x183C03EB0")]
	public static IDisposable FJCHNBKHPMM(this GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3C03CF0", Offset = "0x3C02EF0", VA = "0x183C03CF0")]
	public static IDisposable FJCHNBKHPMM(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3C03910", Offset = "0x3C02B10", VA = "0x183C03910")]
	public static IDisposable ANIJHBKEIEI(this GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3C040C0", Offset = "0x3C032C0", VA = "0x183C040C0")]
	public static IDisposable JFEDDPJFGON(this GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3C03B90", Offset = "0x3C02D90", VA = "0x183C03B90")]
	public static IDisposable BOPAMHMIBHE(this GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3C03C00", Offset = "0x3C02E00", VA = "0x183C03C00")]
	public static IDisposable DGKJMHPNFEI(this GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3C04130", Offset = "0x3C03330", VA = "0x183C04130")]
	public static IDisposable KFLFPDMECBK(this GAKAEFKCHND NJJLHKPDHIC, Action HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3C03A80", Offset = "0x3C02C80", VA = "0x183C03A80")]
	public static IDisposable BLHCCFNPPLD(this GAKAEFKCHND NJJLHKPDHIC, float BIAFGNMJLIB, Action<float> HGLLNMEHECP, Scheduler.LKJNHONALLJ CONNADNIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3C041A0", Offset = "0x3C033A0", VA = "0x183C041A0")]
	public static IDisposable LBHBMJDPLHB(this GAKAEFKCHND NJJLHKPDHIC, float BIAFGNMJLIB, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3C03C70", Offset = "0x3C02E70", VA = "0x183C03C70")]
	public static IDisposable DICFJIKPKJF(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3C03B10", Offset = "0x3C02D10", VA = "0x183C03B10")]
	public static IDisposable BMKPKFGEEIK(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3C03F30", Offset = "0x3C03130", VA = "0x183C03F30")]
	public static IDisposable GPDALONKPFK(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3C04220", Offset = "0x3C03420", VA = "0x183C04220")]
	public static IDisposable NKGDBKFDCEJ(this GAKAEFKCHND NJJLHKPDHIC, float BIAFGNMJLIB, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3C03890", Offset = "0x3C02A90", VA = "0x183C03890")]
	public static IDisposable AKMAJDJDNIA(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3C03790", Offset = "0x3C02990", VA = "0x183C03790")]
	public static IDisposable ABKNPIIHEHE(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3C03980", Offset = "0x3C02B80", VA = "0x183C03980")]
	public static IDisposable BCKAOMCBDHJ(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3C04030", Offset = "0x3C03230", VA = "0x183C04030")]
	public static IDisposable JAKFHCJOHNA(this GAKAEFKCHND NJJLHKPDHIC, float BIAFGNMJLIB, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3C03A00", Offset = "0x3C02C00", VA = "0x183C03A00")]
	public static IDisposable BHBGPFINBMN(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3C03FB0", Offset = "0x3C031B0", VA = "0x183C03FB0")]
	public static IDisposable HCOEBJDEFED(this GAKAEFKCHND NJJLHKPDHIC, Action<float> HGLLNMEHECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3C03810", Offset = "0x3C02A10", VA = "0x183C03810")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C082F0", Offset = "0x3C074F0", VA = "0x183C082F0")]
			public static GGOLJFPNLLB BPDNAEGJJMM(IEnumerator<GGOLJFPNLLB> MIMKAKANKAI, DLKJPHLPLHM DPPCDABONBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3C08450", Offset = "0x3C07650", VA = "0x183C08450")]
			public GGOLJFPNLLB BPDNAEGJJMM(DLKJPHLPLHM[] HDKMBLDBANI, IEnumerator<GGOLJFPNLLB>[] CJHMJKENPJA, GGOLJFPNLLB[] PBHGJBHCBMH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3C082C0", Offset = "0x3C074C0", VA = "0x183C082C0")]
			public void MJACBABLGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3C08520", Offset = "0x3C07720", VA = "0x183C08520")]
			public void CMNNFNJIAOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3C08200", Offset = "0x3C07400", VA = "0x183C08200")]
			public void ANFPGMLIMAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3C082C0", Offset = "0x3C074C0", VA = "0x183C082C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3C07BB0", Offset = "0x3C06DB0", VA = "0x183C07BB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3C08DC0", Offset = "0x3C07FC0", VA = "0x183C08DC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3C02AD0", Offset = "0x3C01CD0", VA = "0x183C02AD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3BF99C0", Offset = "0x3BF8BC0", VA = "0x183BF99C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xB24370", Offset = "0xB23570", VA = "0x180B24370")]
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
				[Cpp2IlInjected.Address(RVA = "0x8A9610", Offset = "0x8A8810", VA = "0x1808A9610")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3BFD360", Offset = "0x3BFC560", VA = "0x183BFD360")]
			private static int OHBDHHHNPOE(LKJNHONALLJ CONNADNIKEF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3BFD390", Offset = "0x3BFC590", VA = "0x183BFD390")]
			public CBDIEFCKONB(LKJNHONALLJ CONNADNIKEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3BFC700", Offset = "0x3BFB900", VA = "0x183BFC700")]
			private void JCFCBOCKMLP(ref int KFMDBOIJGBM, int LOAKBGOMLFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x3BFCF90", Offset = "0x3BFC190", VA = "0x183BFCF90")]
			public void NNPDNJBHCDF(GAKAEFKCHND NJJLHKPDHIC, GGOLJFPNLLB KOAOPHNLPDA, IEnumerator<GGOLJFPNLLB> MIMKAKANKAI, DLKJPHLPLHM DPPCDABONBF, [Optional] KPANKBDMJBF LNNCAOLKAHD, BGCCKIIPFOA OBJHHEEEFNM = BGCCKIIPFOA.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x3BFBF90", Offset = "0x3BFB190", VA = "0x183BFBF90")]
			public void GGNCNPKENKO(IEnumerable<NCKOMNKNPBG> JKBFHMHOHOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3BFB6D0", Offset = "0x3BFA8D0", VA = "0x183BFB6D0")]
			private NCKOMNKNPBG AEKOOFFANIG(int FAJJGGFMDIO)
			{
				return default(NCKOMNKNPBG);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x3BFCC60", Offset = "0x3BFBE60", VA = "0x183BFCC60")]
			private void NADJMEGDHOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1EC50A0", Offset = "0x1EC42A0", VA = "0x181EC50A0")]
			private static void FCFIGDKCAML<T>(int FAJJGGFMDIO, T[] HCMDOPBJOFO, int LMCPNDFGEGE, [Optional] T ENMPHCODCFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1EC5080", Offset = "0x1EC4280", VA = "0x181EC5080")]
			private static void FCFIGDKCAML<T>(int FAJJGGFMDIO, NativeArray<T> HCMDOPBJOFO, int LMCPNDFGEGE, [Optional] T ENMPHCODCFP) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x3BFBC30", Offset = "0x3BFAE30", VA = "0x183BFBC30")]
			private void CHGBCLNAJGH(IEnumerable<NCKOMNKNPBG> JKBFHMHOHOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3BFBED0", Offset = "0x3BFB0D0", VA = "0x183BFBED0")]
			private void FEADKAKEJGI(NCKOMNKNPBG JIILFMGIIDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x3BFD0C0", Offset = "0x3BFC2C0", VA = "0x183BFD0C0")]
			private MAEBBBIKINA OEHOPOJOFPG(int JGCFEAOKOKF)
			{
				return default(MAEBBBIKINA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x3BFC9C0", Offset = "0x3BFBBC0", VA = "0x183BFC9C0")]
			public void KPMPFAADEPI(float KJPPOBJONKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3BFC940", Offset = "0x3BFBB40", VA = "0x183BFC940")]
			private void KFLAIKNBMGH(Action CKOFPIFLMON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3BFBBB0", Offset = "0x3BFADB0", VA = "0x183BFBBB0")]
			private void BOJAKNICHOM(Action CKOFPIFLMON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x3BFC260", Offset = "0x3BFB460", VA = "0x183BFC260")]
			public void IHNNMFPOOND(float KJPPOBJONKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x3BFC180", Offset = "0x3BFB380", VA = "0x183BFC180")]
			public void HHNMAMPPGJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3BFBB00", Offset = "0x3BFAD00", VA = "0x183BFBB00")]
			public void BDFMNIAJMLF(KPANKBDMJBF FLOIHGLCPLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3BFC890", Offset = "0x3BFBA90", VA = "0x183BFC890")]
			public void KEFJPJLNNHL(KPANKBDMJBF FLOIHGLCPLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3BFCBB0", Offset = "0x3BFBDB0", VA = "0x183BFCBB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C09010", Offset = "0x3C08210", VA = "0x183C09010")]
			public static NCFLFPKLAIM BAHAJJMALOP(int NDOOGKCKGEC, float KJPPOBJONKO, NativeArray<BGCCKIIPFOA> KLKGPFBGLHE, NativeArray<float> IMFBIGIAGJI, NativeArray<int> BFJMGNDNFOD, NativeArray<int> PFDOIHNIDJG, NativeArray<int> EMKFFNOHJHN, NativeArray<int> ABCBHKKCDFG, NativeArray<int> EDLGPOBPOJM)
			{
				return default(NCFLFPKLAIM);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3C091E0", Offset = "0x3C083E0", VA = "0x183C091E0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x3C09330", Offset = "0x3C08530", VA = "0x183C09330")]
			private bool IMOEGNPGCKD(int DLGFKHPJLDA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x3C091B0", Offset = "0x3C083B0", VA = "0x183C091B0")]
			private void EPNEJJLJFIJ(NativeArray<int> BDMABCJIEJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3C092C0", Offset = "0x3C084C0", VA = "0x183C092C0")]
			private int HNFBELBHHDG(int BAIJDKLFNFE, int LDJNOFADOFO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3C090E0", Offset = "0x3C082E0", VA = "0x183C090E0")]
			private void DKBAGDEKABN(NativeArray<int> BDMABCJIEJA, int HIMBPNHJGGF, int LKOIFDDMOFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3C09370", Offset = "0x3C08570", VA = "0x183C09370")]
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
				[Cpp2IlInjected.Address(RVA = "0x3C06150", Offset = "0x3C05350", VA = "0x183C06150")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool CDKMKDOIGID
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x5BB420", Offset = "0x5BA620", VA = "0x1805BB420")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0xC0AA80", Offset = "0xC09C80", VA = "0x180C0AA80")]
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
				[Cpp2IlInjected.Address(RVA = "0xCB4640", Offset = "0xCB3840", VA = "0x180CB4640")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0xBBF960", Offset = "0xBBEB60", VA = "0x180BBF960")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3C06300", Offset = "0x3C05500", VA = "0x183C06300")]
			public JJCONKLKJIN(IEnumerator<GGOLJFPNLLB> MIMKAKANKAI, Behaviour NJJLHKPDHIC, DLKJPHLPLHM DPPCDABONBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x3C05F40", Offset = "0x3C05140", VA = "0x183C05F40")]
			public GGOLJFPNLLB BPDNAEGJJMM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3C061E0", Offset = "0x3C053E0", VA = "0x183C061E0")]
			public bool HELHHPOICIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3C05EB0", Offset = "0x3C050B0", VA = "0x183C05EB0")]
			public void BDFMNIAJMLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3C06270", Offset = "0x3C05470", VA = "0x183C06270", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xF51780", Offset = "0xF50980", VA = "0x180F51780")]
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
				[Cpp2IlInjected.Address(RVA = "0x561020", Offset = "0x560220", VA = "0x180561020")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			private float OLEBGJKFGED
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xCE9CA0", Offset = "0xCE8EA0", VA = "0x180CE9CA0", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3BFFFC0", Offset = "0x3BFF1C0", VA = "0x183BFFFC0", Slot = "24")]
			private bool EJJCCCMHNOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3BFFFB0", Offset = "0x3BFF1B0", VA = "0x183BFFFB0", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3BFFFE0", Offset = "0x3BFF1E0", VA = "0x183BFFFE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3C01AB0", Offset = "0x3C00CB0", VA = "0x183C01AB0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3C02500", Offset = "0x3C01700", VA = "0x183C02500")]
			public FFHBKIIMBKN(LKJNHONALLJ MMNFKEFABCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3C01220", Offset = "0x3C00420", VA = "0x183C01220")]
			public void ALGEOPANKFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3C01EA0", Offset = "0x3C010A0", VA = "0x183C01EA0")]
			public void HDFJLMLFOJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3C014D0", Offset = "0x3C006D0", VA = "0x183C014D0")]
			private void DFEELJGNDEH(IReadOnlyList<JJCONKLKJIN> IFBKPGJLMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3C01730", Offset = "0x3C00930", VA = "0x183C01730")]
			public void EHHHHFOOEOM(JJCONKLKJIN MIMKAKANKAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3C01C20", Offset = "0x3C00E20", VA = "0x183C01C20")]
			public void GGKLDMDLGAN(IList<JJCONKLKJIN> CJHMJKENPJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3C01830", Offset = "0x3C00A30", VA = "0x183C01830")]
			public void EJBMILODCHC(IList<JJCONKLKJIN> CJHMJKENPJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3C01EB0", Offset = "0x3C010B0", VA = "0x183C01EB0")]
			private void JDDLJGFGGBN(JJCONKLKJIN MIMKAKANKAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3C010B0", Offset = "0x3C002B0", VA = "0x183C010B0")]
			private void AIBFLGMOFFM(IList<JJCONKLKJIN> CJHMJKENPJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3C01350", Offset = "0x3C00550", VA = "0x183C01350")]
			private MAEBBBIKINA CFMPMIEDELE(JJCONKLKJIN MIMKAKANKAI)
			{
				return default(MAEBBBIKINA);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3C01FA0", Offset = "0x3C011A0", VA = "0x183C01FA0")]
			public void KAKDGOFLCEK(float KJPPOBJONKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3C02050", Offset = "0x3C01250", VA = "0x183C02050")]
			public void LGHDFNBLKMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3C02250", Offset = "0x3C01450", VA = "0x183C02250")]
			private void NPNNKICFENC(List<JJCONKLKJIN> CJHMJKENPJA, Stack<int> DHPJGKMCDIC, bool AEIPIEBKGOP, float DHDBLHIEKJG = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3C015F0", Offset = "0x3C007F0", VA = "0x183C015F0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x3C01230", Offset = "0x3C00430", VA = "0x183C01230")]
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
			[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C08E00", Offset = "0x3C08000", VA = "0x183C08E00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3C08E80", Offset = "0x3C08080", VA = "0x183C08E80", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FBEB0", Offset = "0x4FB0B0", VA = "0x1804FBEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int JLNLHJPGLFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x3C0B510", Offset = "0x3C0A710", VA = "0x183C0B510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A3D0", Offset = "0x3C095D0", VA = "0x183C0A3D0")]
		public static INJGDFDPILJ GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3C09D00", Offset = "0x3C08F00", VA = "0x183C09D00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A5C0", Offset = "0x3C097C0", VA = "0x183C0A5C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6099B0", Offset = "0x608BB0", VA = "0x1806099B0")]
		private FFHBKIIMBKN PKCDHIFIPKG(LKJNHONALLJ NAFKNBEJLOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x63FD80", Offset = "0x63EF80", VA = "0x18063FD80")]
		private CBDIEFCKONB JLGDBDOJOIH(LKJNHONALLJ NAFKNBEJLOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AA50", Offset = "0x3C09C50", VA = "0x183C0AA50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AA20", Offset = "0x3C09C20", VA = "0x183C0AA20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B2E0", Offset = "0x3C0A4E0", VA = "0x183C0B2E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A490", Offset = "0x3C09690", VA = "0x183C0A490")]
		private void MOGKPHLIMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A470", Offset = "0x3C09670", VA = "0x183C0A470")]
		private void JCILOKAKALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A3C0", Offset = "0x3C095C0", VA = "0x183C0A3C0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A480", Offset = "0x3C09680", VA = "0x183C0A480")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A190", Offset = "0x3C09390", VA = "0x183C0A190")]
		private void BELIGDOCEOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3C09CA0", Offset = "0x3C08EA0", VA = "0x183C09CA0")]
		[IteratorStateMachine(typeof(NBPMKDCJJCJ))]
		private IEnumerator ADJNPCJALBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3C0ABF0", Offset = "0x3C09DF0", VA = "0x183C0ABF0")]
		public INJGDFDPILJ Run(IEnumerator<GGOLJFPNLLB> ANEBFOKKCBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AC00", Offset = "0x3C09E00", VA = "0x183C0AC00")]
		public INJGDFDPILJ Run(Behaviour NJJLHKPDHIC, IEnumerator<GGOLJFPNLLB> ANEBFOKKCBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AAC0", Offset = "0x3C09CC0", VA = "0x183C0AAC0")]
		public INJGDFDPILJ RunJobbed(GAKAEFKCHND NJJLHKPDHIC, IEnumerator<GGOLJFPNLLB> ANEBFOKKCBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A1A0", Offset = "0x3C093A0", VA = "0x183C0A1A0")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AF20", Offset = "0x3C0A120", VA = "0x183C0AF20")]
		public void UpdateQueue(LKJNHONALLJ EMGIAHFMKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A200", Offset = "0x3C09400", VA = "0x183C0A200")]
		private void EIAPGBMGDOM(FFHBKIIMBKN GPKALGNIOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A4A0", Offset = "0x3C096A0", VA = "0x183C0A4A0")]
		private void NCNDCHMIPMJ(CBDIEFCKONB GPKALGNIOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B490", Offset = "0x3C0A690", VA = "0x183C0B490")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C08B80", Offset = "0x3C07D80", VA = "0x183C08B80", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float LJOBEGPECDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C08BB0", Offset = "0x3C07DB0", VA = "0x183C08BB0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float IFMCANBMDBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3C08BD0", Offset = "0x3C07DD0", VA = "0x183C08BD0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int CBIGNFIBJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3C08BC0", Offset = "0x3C07DC0", VA = "0x183C08BC0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public double LIDNNGFDOLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3C08B90", Offset = "0x3C07D90", VA = "0x183C08B90", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C09950", Offset = "0x3C08B50", VA = "0x183C09950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public double CINNHAMBAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3C09990", Offset = "0x3C08B90", VA = "0x183C09990", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public double MMLEJOODGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x14FD110", Offset = "0x14FC310", VA = "0x1814FD110", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public double PKGAOFIMBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x31015E0", Offset = "0x31007E0", VA = "0x1831015E0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3C09B60", Offset = "0x3C08D60", VA = "0x183C09B60")]
	public OBLNNCFOJBK(int FBBGACCANLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C09A60", Offset = "0x3C08C60", VA = "0x183C09A60", Slot = "4")]
	public void MLEJIOLFBHB(double HKPKIJKKGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3C099F0", Offset = "0x3C08BF0", VA = "0x183C099F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2904F00", Offset = "0x2904100", VA = "0x182904F00", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public double PKGAOFIMBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x697330", VA = "0x180698130", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public double FPLCAOLDGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x31015E0", Offset = "0x31007E0", VA = "0x1831015E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public double PBDAKODEAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3855720", Offset = "0x3854920", VA = "0x183855720")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public double CINNHAMBAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3101510", Offset = "0x3100710", VA = "0x183101510", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3C08C70", Offset = "0x3C07E70", VA = "0x183C08C70", Slot = "4")]
	public void MLEJIOLFBHB(double HKPKIJKKGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3C08C30", Offset = "0x3C07E30", VA = "0x183C08C30", Slot = "5")]
	public void DBBNEPGCPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3C08D90", Offset = "0x3C07F90", VA = "0x183C08D90")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C9E030", Offset = "0x2C9D230", VA = "0x182C9E030")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool LKJPFIFLDHF
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x2C9DFB0", Offset = "0x2C9D1B0", VA = "0x182C9DFB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x248CDC0", Offset = "0x248BFC0", VA = "0x18248CDC0")]
		protected DECOHBHCCGE(TPromise JHGIJFDNLHD, TMainThreadPromise MHMLEKDMGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E000", Offset = "0x2C9D200", VA = "0x182C9E000", Slot = "5")]
		public void JFAIONIJMNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1D40800", Offset = "0x1D3FA00", VA = "0x181D40800", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C9D970", Offset = "0x2C9CB70", VA = "0x182C9D970")]
		public CGOBELBIGID(global::IJNOJIGJDDE<T> JHGIJFDNLHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D690", Offset = "0x2C9C890", VA = "0x182C9D690", Slot = "7")]
		protected override void BKOLKMMKOJA(global::IJNOJIGJDDE<T> JHGIJFDNLHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D8C0", Offset = "0x2C9CAC0", VA = "0x182C9D8C0", Slot = "8")]
		protected override void KNJFJHDIOIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D920", Offset = "0x2C9CB20", VA = "0x182C9D920")]
		[CompilerGenerated]
		private void OGFIFBOJBBC(T LEFCDNPGKCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D830", Offset = "0x2C9CA30", VA = "0x182C9D830")]
		[CompilerGenerated]
		private void GIELDNFKGNC(string HEEKCGODMHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class NJDIEDCOKNL : DECOHBHCCGE<NIIPAOBAIGP, DKPBLMEPKBG>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3C097C0", Offset = "0x3C089C0", VA = "0x183C097C0")]
		public NJDIEDCOKNL(NIIPAOBAIGP JHGIJFDNLHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3C096A0", Offset = "0x3C088A0", VA = "0x183C096A0", Slot = "7")]
		protected override void BKOLKMMKOJA(NIIPAOBAIGP JHGIJFDNLHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C09770", Offset = "0x3C08970", VA = "0x183C09770", Slot = "8")]
		protected override void KNJFJHDIOIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x123B550", Offset = "0x123A750", VA = "0x18123B550")]
		[CompilerGenerated]
		private void OGFIFBOJBBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1778EF0", Offset = "0x17780F0", VA = "0x181778EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E1560", Offset = "0x4E0760", VA = "0x1804E1560")]
		public APMDHLBNCFJ(Action HIOFDPALGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x14E40A0", Offset = "0x14E32A0", VA = "0x1814E40A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2121980", Offset = "0x2120B80", VA = "0x182121980")]
	public static global::IJNOJIGJDDE<T> NBAELGEHJPH<T>(this global::IJNOJIGJDDE<T> JHGIJFDNLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA640", Offset = "0x3BF9840", VA = "0x183BFA640")]
	public static NIIPAOBAIGP NBAELGEHJPH(this NIIPAOBAIGP JHGIJFDNLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA750", Offset = "0x3BF9950", VA = "0x183BFA750")]
	public static void NBAELGEHJPH(Action HIOFDPALGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2121800", Offset = "0x2120A00", VA = "0x182121800")]
	private static global::IJNOJIGJDDE<T> GAPAKMJLLKN<T>(global::IJNOJIGJDDE<T> JHGIJFDNLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA4B0", Offset = "0x3BF96B0", VA = "0x183BFA4B0")]
	private static NIIPAOBAIGP GAPAKMJLLKN(NIIPAOBAIGP JHGIJFDNLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA2D0", Offset = "0x3BF94D0", VA = "0x183BFA2D0")]
	private static void DEDPAPKBHNM(BJOOKPMBPCD PMMLFIEDKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA7D0", Offset = "0x3BF99D0", VA = "0x183BFA7D0")]
	private static void NPJJFFEIFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA200", Offset = "0x3BF9400", VA = "0x183BFA200")]
	private static void AFJFILGJMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA590", Offset = "0x3BF9790", VA = "0x183BFA590")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C042C0", Offset = "0x3C034C0", VA = "0x183C042C0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3C042B0", Offset = "0x3C034B0", VA = "0x183C042B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BFFCA0", Offset = "0x3BFEEA0", VA = "0x183BFFCA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
		[DebuggerHidden]
		public AGPGDNMHLCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3BF98C0", Offset = "0x3BF8AC0", VA = "0x183BF98C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3BF95B0", Offset = "0x3BF87B0", VA = "0x183BF95B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9970", Offset = "0x3BF8B70", VA = "0x183BF9970")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9870", Offset = "0x3BF8A70", VA = "0x183BF9870", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C04530", Offset = "0x3C03730", VA = "0x183C04530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3C04840", Offset = "0x3C03A40", VA = "0x183C04840", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C02F00", Offset = "0x3C02100", VA = "0x183C02F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private static bool KBKPJAFMIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3C031B0", Offset = "0x3C023B0", VA = "0x183C031B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private static bool FJJOFBIGDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3C02B10", Offset = "0x3C01D10", VA = "0x183C02B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<string, LoadSceneMode> IBEDBOKLGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3C02B70", Offset = "0x3C01D70", VA = "0x183C02B70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3C02E50", Offset = "0x3C02050", VA = "0x183C02E50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3C02D10", Offset = "0x3C01F10", VA = "0x183C02D10")]
	public static NIIPAOBAIGP CMGAPDHDHCP(string HDKLMHMNODL, LoadSceneMode HKHOMCOIEFC = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3C02FA0", Offset = "0x3C021A0", VA = "0x183C02FA0")]
	public static NIIPAOBAIGP IKPBPELIHIA(string HDKLMHMNODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3C02C20", Offset = "0x3C01E20", VA = "0x183C02C20")]
	[IteratorStateMachine(typeof(AGPGDNMHLCH))]
	private static IEnumerator<GGOLJFPNLLB> BMFHEGAICAC(string HDKLMHMNODL, DKPBLMEPKBG IOKNOCEPKAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3C02C90", Offset = "0x3C01E90", VA = "0x183C02C90")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C07070", Offset = "0x3C06270", VA = "0x183C07070")]
	private static string BNMKEPLLJLH(byte[] PADLHGFNBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x3C07170", Offset = "0x3C06370", VA = "0x183C07170")]
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

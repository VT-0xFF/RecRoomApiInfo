using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private delegate List<PlayerLoopSystem> KGIDAOBIGJB(List<PlayerLoopSystem> PIIMMFBJMMC, int INOPHJHLMML);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct CPCJBAAAALG
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct AFENJPHNKBO
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static EBEHMDGBKDH ANMGIGGBHHO;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x4B9F760", Offset = "0x4B9E760", VA = "0x184B9F760")]
				public static PlayerLoopSystem EBKJJCCPGIA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct GJOPHOHBLEH
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static EBEHMDGBKDH FAIAIEOMILM;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x4BAA350", Offset = "0x4BA9350", VA = "0x184BAA350")]
				public static PlayerLoopSystem EBKJJCCPGIA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct MIKEJHJGNPD
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static EBEHMDGBKDH EBAPBNALNHF;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x4BAE0C0", Offset = "0x4BAD0C0", VA = "0x184BAE0C0")]
				public static PlayerLoopSystem EBKJJCCPGIA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct PPMEHPGGAPO
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static EBEHMDGBKDH HIBGCCEKDNP;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4BAFAB0", Offset = "0x4BAEAB0", VA = "0x184BAFAB0")]
				public static PlayerLoopSystem EBKJJCCPGIA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct PGBIAILGHAM
			{
				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static EBEHMDGBKDH KHLODGBONPM;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x4BAF5A0", Offset = "0x4BAE5A0", VA = "0x184BAF5A0")]
				public static PlayerLoopSystem EBKJJCCPGIA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct LKMBLKLHEKN
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class OMBPOMINLEF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000012")]
					public ALAHLDLJMMI.ADEPDCDKCGF key;

					[Cpp2IlInjected.Token(Token = "0x6000025")]
					[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
					public OMBPOMINLEF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000026")]
					[Cpp2IlInjected.Address(RVA = "0x4BAEBE0", Offset = "0x4BADBE0", VA = "0x184BAEBE0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static IDisposable MLILPMPFBPE;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x4BAD9C0", Offset = "0x4BAC9C0", VA = "0x184BAD9C0")]
				public static PlayerLoopSystem HNLCMHOBCKG(ALAHLDLJMMI.ADEPDCDKCGF BJKKIOODGOA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			internal struct FNHMKJBILHJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000012")]
				[CompilerGenerated]
				private sealed class JKPJMEIPBIC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000013")]
					public ALAHLDLJMMI.ADEPDCDKCGF key;

					[Cpp2IlInjected.Token(Token = "0x6000028")]
					[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
					public JKPJMEIPBIC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000029")]
					[Cpp2IlInjected.Address(RVA = "0x4BABD30", Offset = "0x4BAAD30", VA = "0x184BABD30")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x4BA89C0", Offset = "0x4BA79C0", VA = "0x184BA89C0")]
				public static PlayerLoopSystem HNLCMHOBCKG(ALAHLDLJMMI.ADEPDCDKCGF BJKKIOODGOA)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class EJNCGLCHDJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
			public EJNCGLCHDJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4BA7CE0", Offset = "0x4BA6CE0", VA = "0x184BA7CE0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool JCPIAKJEILI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool HDHEIAJAJGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4BA4360", Offset = "0x4BA3360", VA = "0x184BA4360")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4BA44C0", Offset = "0x4BA34C0", VA = "0x184BA44C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4BA2F10", Offset = "0x4BA1F10", VA = "0x184BA2F10")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4BA2D40", Offset = "0x4BA1D40", VA = "0x184BA2D40")]
		private static void AIPJEDJNAPA(ALAHLDLJMMI.ADEPDCDKCGF BJKKIOODGOA, ref PlayerLoopSystem EPHHBDJMJEP, Type JCIAAJPANLJ, Type FKGIIKKCPEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4500", Offset = "0x4BA3500", VA = "0x184BA4500")]
		private static void MEFJHPPKNHF(ref PlayerLoopSystem EPHHBDJMJEP, Type JCIAAJPANLJ, Type FKGIIKKCPEM, KGIDAOBIGJB DFOKGJONNKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4BA43A0", Offset = "0x4BA33A0", VA = "0x184BA43A0")]
		private static void DMCCGBEOBOP(ref PlayerLoopSystem EPHHBDJMJEP, Type JCIAAJPANLJ, Type FKGIIKKCPEM, PlayerLoopSystem? IBGGHMDPPAL, PlayerLoopSystem? PJINPOBCPOD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ALAHLDLJMMI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum ADEPDCDKCGF
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class IPNOFJFOPBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly ADEPDCDKCGF GAKJDMCKKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly LLCOPIPAMBB PBLBMOGDEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private long DMIPOAIDPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long APEHAGKPBCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public long MFFMCIFLCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int FLEGBBOKFOO;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4BAAD90", Offset = "0x4BA9D90", VA = "0x184BAAD90")]
		public IPNOFJFOPBF(ADEPDCDKCGF MIMLPPIBFNG, int MELGFCAPLDK = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4BAAAF0", Offset = "0x4BA9AF0", VA = "0x184BAAAF0")]
		public void ACEPINFNDJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4BAAB60", Offset = "0x4BA9B60", VA = "0x184BAAB60")]
		public void BEKEJEKGHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4BAABC0", Offset = "0x4BA9BC0", VA = "0x184BAABC0")]
		public void FFNOHJBFGFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static ADEPDCDKCGF[] FKFHJHOKAAN;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static IPNOFJFOPBF[] CNIGMICJIPE;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4B9F930", Offset = "0x4B9E930", VA = "0x184B9F930")]
	public static IPNOFJFOPBF ALHILEOIBBJ(ADEPDCDKCGF BJKKIOODGOA, int MELGFCAPLDK = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4B9FAE0", Offset = "0x4B9EAE0", VA = "0x184B9FAE0")]
	public static IPNOFJFOPBF APIBMKEKGBM(ADEPDCDKCGF BJKKIOODGOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4B9FB70", Offset = "0x4B9EB70", VA = "0x184B9FB70")]
	public static void PCBLKBBKOOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LLCOPIPAMBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int LPMBDFIPHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Queue<double> AOFFHFHEKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double OBJPCHOBPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double JDMPDBLFGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double CACMAEDAEHI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double NGHLGJPNLMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4BADC50", Offset = "0x4BACC50", VA = "0x184BADC50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4BADCB0", Offset = "0x4BACCB0", VA = "0x184BADCB0")]
	public LLCOPIPAMBB(int CNOIBHJCJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4BADB50", Offset = "0x4BACB50", VA = "0x184BADB50", Slot = "4")]
	public void JLEANJPJOPH(double BPAFLPOFGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4BADAE0", Offset = "0x4BACAE0", VA = "0x184BADAE0", Slot = "5")]
	public void IDHIAHKAEGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BHFMNHMCBLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private long KLPGLGDELCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double MLLLMHKKANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double CGJFMOCIKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double BHMJJNLCEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double PMCIOIKAJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private double OBJPCHOBPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private double JDMPDBLFGGN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double NCPFFIAJHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x352EED0", Offset = "0x352DED0", VA = "0x18352EED0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double GHLLJPCNAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2E4CED0", Offset = "0x2E4BED0", VA = "0x182E4CED0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double HCDJCCJOMEH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2FBE380", Offset = "0x2FBD380", VA = "0x182FBE380")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double NGHLGJPNLMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x34D8770", Offset = "0x34D7770", VA = "0x1834D8770", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1740", Offset = "0x4BA0740", VA = "0x184BA1740", Slot = "7")]
	public void JLEANJPJOPH(double BPAFLPOFGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1700", Offset = "0x4BA0700", VA = "0x184BA1700", Slot = "8")]
	public void IDHIAHKAEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1860", Offset = "0x4BA0860", VA = "0x184BA1860")]
	public BHFMNHMCBLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class DKAOOLAMBFG
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private interface JGEHNEKPHPE
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool FMCJBFEAHFI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GLIJLNLELKF();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class BKCNKJHKEFM<TPromise, TMainThreadPromise> : JGEHNEKPHPE where TPromise : HFADLOCOGOG where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly TPromise INOKKAOIBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		protected readonly TMainThreadPromise DBDHPIIDJLO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise MIDJMECLMDH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x2B95BF0", Offset = "0x2B94BF0", VA = "0x182B95BF0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FMCJBFEAHFI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2B95C80", Offset = "0x2B94C80", VA = "0x182B95C80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x18F63F0", Offset = "0x18F53F0", VA = "0x1818F63F0")]
		protected BKCNKJHKEFM(TPromise INOKKAOIBPF, TMainThreadPromise JNFPEPJOHMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B95C50", Offset = "0x2B94C50", VA = "0x182B95C50", Slot = "5")]
		public void GLIJLNLELKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void JEJFHGGBBFG(TPromise INOKKAOIBPF);
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class HJBMPONKDHP<T> : BKCNKJHKEFM<global::PKODKNLJGEP<T>, global::FCENHLGFPDA<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3F20", Offset = "0x2BA2F20", VA = "0x182BA3F20")]
		public HJBMPONKDHP(global::PKODKNLJGEP<T> INOKKAOIBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3CF0", Offset = "0x2BA2CF0", VA = "0x182BA3CF0", Slot = "6")]
		protected override void JEJFHGGBBFG(global::PKODKNLJGEP<T> INOKKAOIBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3EF0", Offset = "0x2BA2EF0", VA = "0x182BA3EF0")]
		[CompilerGenerated]
		private void KEOHGDOPGCF(T AFGNBGMNGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3CC0", Offset = "0x2BA2CC0", VA = "0x182BA3CC0")]
		[CompilerGenerated]
		private void CBGIOJAAJLL(string FHJBPHCDOKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class AMJLCLDELCL : JGEHNEKPHPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly Action DJBODGKMGGL;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FMCJBFEAHFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x555B00", Offset = "0x554B00", VA = "0x180555B00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5B9040", Offset = "0x5B8040", VA = "0x1805B9040")]
		public AMJLCLDELCL(Action DJBODGKMGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xB05780", Offset = "0xB04780", VA = "0x180B05780", Slot = "5")]
		public void GLIJLNLELKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly List<JGEHNEKPHPE> ADJEAJAOMMM;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x164CC60", Offset = "0x164BC60", VA = "0x18164CC60")]
	public static global::PKODKNLJGEP<T> ALPEIIHPPFA<T>(this global::PKODKNLJGEP<T> INOKKAOIBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4BA6F40", Offset = "0x4BA5F40", VA = "0x184BA6F40")]
	public static void ALPEIIHPPFA(Action DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x164CCD0", Offset = "0x164BCD0", VA = "0x18164CCD0")]
	private static global::PKODKNLJGEP<T> LCOAGEINNFC<T>(global::PKODKNLJGEP<T> INOKKAOIBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7080", Offset = "0x4BA6080", VA = "0x184BA7080")]
	private static void EMFKDFIGEBC(JGEHNEKPHPE COPJLGFPFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7270", Offset = "0x4BA6270", VA = "0x184BA7270")]
	private static void GCNONCFHMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7590", Offset = "0x4BA6590", VA = "0x184BA7590")]
	private static void NGPFKCAAIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4BA6FD0", Offset = "0x4BA5FD0", VA = "0x184BA6FD0")]
	private static void CEOBHMCNHLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class JFOMLFLOBHK
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PJIAMAJBIAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public JLIHNEGNJFG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public PJIAMAJBIAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4BAF8C0", Offset = "0x4BAE8C0", VA = "0x184BAF8C0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4BAF8B0", Offset = "0x4BAE8B0", VA = "0x184BAF8B0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OBIPGLGGNOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public OBIPGLGGNOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE9B0", Offset = "0x4BAD9B0", VA = "0x184BAE9B0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IBNDDMENHMD : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public JLIHNEGNJFG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public IBNDDMENHMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA840", Offset = "0x4BA9840", VA = "0x184BAA840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA520", Offset = "0x4BA9520", VA = "0x184BAA520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA8F0", Offset = "0x4BA98F0", VA = "0x184BAA8F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA7F0", Offset = "0x4BA97F0", VA = "0x184BAA7F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class MFCGEICMNLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public JLIHNEGNJFG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public MFCGEICMNLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DEGKOHNPEPF : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public JLIHNEGNJFG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MFCGEICMNLA <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public DEGKOHNPEPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6BB0", Offset = "0x4BA5BB0", VA = "0x184BA6BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6EF0", Offset = "0x4BA5EF0", VA = "0x184BA6EF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static HFADLOCOGOG HMLMGOCFMGC;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static AsyncOperation JBKCFGOHJJI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static HFADLOCOGOG HIOBDCOCNHP;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static string GGLLBGBDAEH;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static ThreadPriority JFOMPLPDGGM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool HOMJICABAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4BAB1C0", Offset = "0x4BAA1C0", VA = "0x184BAB1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool PNIDEFPBLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4BAAFA0", Offset = "0x4BA9FA0", VA = "0x184BAAFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool PLNFGGGNOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4BAB160", Offset = "0x4BAA160", VA = "0x184BAB160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> IABLGKIOMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4BAB5D0", Offset = "0x4BAA5D0", VA = "0x184BAB5D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4BAB520", Offset = "0x4BAA520", VA = "0x184BAB520")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4BAB260", Offset = "0x4BAA260", VA = "0x184BAB260")]
	[OMDJHDHMGFL(MFFCDMKLBEG.EnteredEditModeNextFrame, 0)]
	private static void LOFOKBICCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4BAB000", Offset = "0x4BAA000", VA = "0x184BAB000")]
	public static HFADLOCOGOG IIJEKLDNPND(string JDNDIJAMGLG, LoadSceneMode CNIMOAHCDNG = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4BAB310", Offset = "0x4BAA310", VA = "0x184BAB310")]
	public static HFADLOCOGOG OCDIDCLCJCE(string JDNDIJAMGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4BAAF10", Offset = "0x4BA9F10", VA = "0x184BAAF10")]
	[IteratorStateMachine(typeof(IBNDDMENHMD))]
	private static IEnumerator<FBNJPIMJMDI> EEEGMENCKJF(string JDNDIJAMGLG, JLIHNEGNJFG LPKGKAKJGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4BAAE80", Offset = "0x4BA9E80", VA = "0x184BAAE80")]
	[IteratorStateMachine(typeof(DEGKOHNPEPF))]
	private static IEnumerator<FBNJPIMJMDI> DEOCKIIPIJN(string JDNDIJAMGLG, LoadSceneMode CNIMOAHCDNG, JLIHNEGNJFG LPKGKAKJGEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BBAMMNOLJNL
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1520", Offset = "0x4BA0520", VA = "0x184BA1520")]
	public static IDisposable KGCIHLMKCEN(this OBOJOLAHPAP OLNEIJPLPKF, float ELDDCCCDECH, Action<float> PHKOLMBKBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4BA14A0", Offset = "0x4BA04A0", VA = "0x184BA14A0")]
	public static IDisposable JIPCGHBANAC(this OBOJOLAHPAP OLNEIJPLPKF, Action<float> PHKOLMBKBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1420", Offset = "0x4BA0420", VA = "0x184BA1420")]
	public static IDisposable EDMEIALCNFK(this OBOJOLAHPAP OLNEIJPLPKF, Action<float> PHKOLMBKBBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class GIGGGGOJMOJ
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4BAA0B0", Offset = "0x4BA90B0", VA = "0x184BAA0B0")]
	public static IDisposable NPEEFODFKED(this MonoBehaviour EIEKANJPDLG, Action PHKOLMBKBBK, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4BAA130", Offset = "0x4BA9130", VA = "0x184BAA130")]
	public static IDisposable NPEEFODFKED(this MonoBehaviour EIEKANJPDLG, Action<float> PHKOLMBKBBK, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9930", Offset = "0x4BA8930", VA = "0x184BA9930")]
	public static IDisposable ADBHOPCDBIC(this MonoBehaviour EIEKANJPDLG, Action PHKOLMBKBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9A80", Offset = "0x4BA8A80", VA = "0x184BA9A80")]
	public static IDisposable CLBMHHNKOMA(this MonoBehaviour EIEKANJPDLG, Action PHKOLMBKBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9A10", Offset = "0x4BA8A10", VA = "0x184BA9A10")]
	public static IDisposable CDEIPGNFLGB(this MonoBehaviour EIEKANJPDLG, Action PHKOLMBKBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4BAA2E0", Offset = "0x4BA92E0", VA = "0x184BAA2E0")]
	public static IDisposable OEELLJOIJCB(this MonoBehaviour EIEKANJPDLG, Action PHKOLMBKBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4BA99A0", Offset = "0x4BA89A0", VA = "0x184BA99A0")]
	public static IDisposable AMGAJMKKFJD(this MonoBehaviour EIEKANJPDLG, Action PHKOLMBKBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9EE0", Offset = "0x4BA8EE0", VA = "0x184BA9EE0")]
	public static IDisposable IPFPBOJLKPC(this MonoBehaviour EIEKANJPDLG, float ELDDCCCDECH, Action<float> PHKOLMBKBBK, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC, bool MDBDBJOKADM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9E50", Offset = "0x4BA8E50", VA = "0x184BA9E50")]
	public static IDisposable IFMNBCBDCMD(this MonoBehaviour EIEKANJPDLG, float ELDDCCCDECH, Action<float> PHKOLMBKBBK, bool MDBDBJOKADM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9B80", Offset = "0x4BA8B80", VA = "0x184BA9B80")]
	public static IDisposable EFHMJJBEGHB(this MonoBehaviour EIEKANJPDLG, Action<float> PHKOLMBKBBK, bool MDBDBJOKADM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4BA98A0", Offset = "0x4BA88A0", VA = "0x184BA98A0")]
	public static IDisposable ABBPNHAPEIO(this MonoBehaviour EIEKANJPDLG, Action<float> PHKOLMBKBBK, bool MDBDBJOKADM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9AF0", Offset = "0x4BA8AF0", VA = "0x184BA9AF0")]
	public static IDisposable DONJPMJCJGM(this MonoBehaviour EIEKANJPDLG, Action<float> PHKOLMBKBBK, bool MDBDBJOKADM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9C10", Offset = "0x4BA8C10", VA = "0x184BA9C10")]
	public static IDisposable FMOGFAPACMB(this MonoBehaviour EIEKANJPDLG, Action<float> PHKOLMBKBBK, bool MDBDBJOKADM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9CA0", Offset = "0x4BA8CA0", VA = "0x184BA9CA0")]
	public static IDisposable FOKCGOOCONP(this MonoBehaviour EIEKANJPDLG, Action<float> PHKOLMBKBBK, bool MDBDBJOKADM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4BAA020", Offset = "0x4BA9020", VA = "0x184BAA020")]
	public static IDisposable NODBDJNNEAI(this MonoBehaviour EIEKANJPDLG, Action<float> PHKOLMBKBBK, bool MDBDBJOKADM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9D30", Offset = "0x4BA8D30", VA = "0x184BA9D30")]
	public static IDisposable GOEFKMEHKCO(this MonoBehaviour EIEKANJPDLG, Action<float> PHKOLMBKBBK, bool MDBDBJOKADM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9F80", Offset = "0x4BA8F80", VA = "0x184BA9F80")]
	public static IDisposable JHHFLLFGJOG(this MonoBehaviour EIEKANJPDLG, float ELDDCCCDECH, Action<float> PHKOLMBKBBK, bool MDBDBJOKADM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9DC0", Offset = "0x4BA8DC0", VA = "0x184BA9DC0")]
	public static IDisposable HFCDONFBLJM(this MonoBehaviour EIEKANJPDLG, Action<float> PHKOLMBKBBK, bool MDBDBJOKADM = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class JNAMJOFLIIB
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BMIGGDDFNGN : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public EPABBDPLHHK.DLNBAPGFDPI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private NKFBNBKAPHM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public BMIGGDDFNGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4BA1FB0", Offset = "0x4BA0FB0", VA = "0x184BA1FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4BA2070", Offset = "0x4BA1070", VA = "0x184BA2070", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class MCPDLPFMHLN : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public EPABBDPLHHK.DLNBAPGFDPI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private NKFBNBKAPHM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public MCPDLPFMHLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4BADD50", Offset = "0x4BACD50", VA = "0x184BADD50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4BADE30", Offset = "0x4BACE30", VA = "0x184BADE30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4BABED0", Offset = "0x4BAAED0", VA = "0x184BABED0")]
	public static NGEEMJOOCBL NPEEFODFKED(Action PHKOLMBKBBK, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4BABFB0", Offset = "0x4BAAFB0", VA = "0x184BABFB0")]
	public static NGEEMJOOCBL NPEEFODFKED(Behaviour OLNEIJPLPKF, Action PHKOLMBKBBK, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4BABDF0", Offset = "0x4BAADF0", VA = "0x184BABDF0")]
	public static NGEEMJOOCBL NPEEFODFKED(Behaviour OLNEIJPLPKF, Action<float> PHKOLMBKBBK, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC040", Offset = "0x4BAB040", VA = "0x184BAC040")]
	[IteratorStateMachine(typeof(BMIGGDDFNGN))]
	private static IEnumerator<FBNJPIMJMDI> PEJNGKFHHHN(EPABBDPLHHK.DLNBAPGFDPI NGJOKEMPLOC, Action PHKOLMBKBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC0C0", Offset = "0x4BAB0C0", VA = "0x184BAC0C0")]
	[IteratorStateMachine(typeof(MCPDLPFMHLN))]
	private static IEnumerator<FBNJPIMJMDI> PEJNGKFHHHN(EPABBDPLHHK.DLNBAPGFDPI NGJOKEMPLOC, Action<float> PHKOLMBKBBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class KCJJLNKJLCJ
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class IPDIJEEKEFL : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public PNDIKCBNMCH schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public EPABBDPLHHK.DLNBAPGFDPI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private ILHFNFJIFGI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public IPDIJEEKEFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA970", Offset = "0x4BA9970", VA = "0x184BAA970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4BAAAA0", Offset = "0x4BA9AA0", VA = "0x184BAAAA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC5D0", Offset = "0x4BAB5D0", VA = "0x184BAC5D0")]
	public static NGEEMJOOCBL NPEEFODFKED(MonoBehaviour EIEKANJPDLG, float ELDDCCCDECH, Action<float> PHKOLMBKBBK, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC, bool MDBDBJOKADM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC500", Offset = "0x4BAB500", VA = "0x184BAC500")]
	public static NGEEMJOOCBL IKLOMKOBBHL(OBOJOLAHPAP OLNEIJPLPKF, float ELDDCCCDECH, Action<float> PHKOLMBKBBK, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC, bool MDBDBJOKADM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC6A0", Offset = "0x4BAB6A0", VA = "0x184BAC6A0")]
	[IteratorStateMachine(typeof(IPDIJEEKEFL))]
	private static IEnumerator<FBNJPIMJMDI> PEJNGKFHHHN(PNDIKCBNMCH NAFDNAFFBPI, float ELDDCCCDECH, EPABBDPLHHK.DLNBAPGFDPI NGJOKEMPLOC, Action<float> PHKOLMBKBBK, bool MDBDBJOKADM = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BEIKOENNDFE
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class PJCBFIIEFFB : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EPABBDPLHHK.DLNBAPGFDPI queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public PJCBFIIEFFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4BAF770", Offset = "0x4BAE770", VA = "0x184BAF770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4BAF820", Offset = "0x4BAE820", VA = "0x184BAF820", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1680", Offset = "0x4BA0680", VA = "0x184BA1680")]
	[IteratorStateMachine(typeof(PJCBFIIEFFB))]
	private static IEnumerator<FBNJPIMJMDI> OPJMHIGPAJD(EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC, Func<bool> DAEMEOMJDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4BA15A0", Offset = "0x4BA05A0", VA = "0x184BA15A0")]
	public static NGEEMJOOCBL OIGCLKHIHND(this MonoBehaviour EIEKANJPDLG, Func<bool> DAEMEOMJDKL, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC = EPABBDPLHHK.DLNBAPGFDPI.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class OOACPHABNJA
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BJFDBGJGLMH : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public EPABBDPLHHK.DLNBAPGFDPI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public BJFDBGJGLMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4BA1890", Offset = "0x4BA0890", VA = "0x184BA1890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4BA1950", Offset = "0x4BA0950", VA = "0x184BA1950", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FEFJODHPAGM : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public EPABBDPLHHK.DLNBAPGFDPI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private FBNJPIMJMDI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public FEFJODHPAGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8860", Offset = "0x4BA7860", VA = "0x184BA8860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8930", Offset = "0x4BA7930", VA = "0x184BA8930", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4BAEE80", Offset = "0x4BADE80", VA = "0x184BAEE80")]
	[IteratorStateMachine(typeof(BJFDBGJGLMH))]
	private static IEnumerator<FBNJPIMJMDI> FHBPOMKICDB(float OHFAOPPPCDN, EPABBDPLHHK.DLNBAPGFDPI NGJOKEMPLOC, Action OFMJDNNNBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4BAEFA0", Offset = "0x4BADFA0", VA = "0x184BAEFA0")]
	[IteratorStateMachine(typeof(FEFJODHPAGM))]
	private static IEnumerator<FBNJPIMJMDI> LNGAOJIDEKE(float OHFAOPPPCDN, EPABBDPLHHK.DLNBAPGFDPI NGJOKEMPLOC, Action OFMJDNNNBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4BAF0D0", Offset = "0x4BAE0D0", VA = "0x184BAF0D0")]
	public static IDisposable MHLMOBMAKDE(this MonoBehaviour EIEKANJPDLG, float OHFAOPPPCDN, Action OFMJDNNNBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4BAF2A0", Offset = "0x4BAE2A0", VA = "0x184BAF2A0")]
	public static NGEEMJOOCBL MNKCEMJHLBM(this MonoBehaviour EIEKANJPDLG, float OHFAOPPPCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4BAF1B0", Offset = "0x4BAE1B0", VA = "0x184BAF1B0")]
	public static NGEEMJOOCBL MHLMOBMAKDE(this MonoBehaviour EIEKANJPDLG, float OHFAOPPPCDN, EPABBDPLHHK.DLNBAPGFDPI NGJOKEMPLOC, Action OFMJDNNNBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4BAEDE0", Offset = "0x4BADDE0", VA = "0x184BAEDE0")]
	public static NGEEMJOOCBL CPNAALMIKGD(this MonoBehaviour EIEKANJPDLG, Action OFMJDNNNBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4BAF330", Offset = "0x4BAE330", VA = "0x184BAF330")]
	public static NGEEMJOOCBL NGKDENCHNHF(this MonoBehaviour EIEKANJPDLG, Action OFMJDNNNBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4BAEC90", Offset = "0x4BADC90", VA = "0x184BAEC90")]
	public static NGEEMJOOCBL AFDDNHAGOID(this MonoBehaviour EIEKANJPDLG, Action OFMJDNNNBPA, [Optional] KNGKOKPFDNL NBBNEDHNODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4BAF3D0", Offset = "0x4BAE3D0", VA = "0x184BAF3D0")]
	public static NGEEMJOOCBL NKHPJEGLBOD(this MonoBehaviour EIEKANJPDLG, Action OFMJDNNNBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4BAF470", Offset = "0x4BAE470", VA = "0x184BAF470")]
	public static NGEEMJOOCBL OCLCBKGCFHH(this MonoBehaviour EIEKANJPDLG, Action OFMJDNNNBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4BAF030", Offset = "0x4BAE030", VA = "0x184BAF030")]
	private static NGEEMJOOCBL MDJDCJDMPHG(MonoBehaviour EIEKANJPDLG, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC, Action OFMJDNNNBPA, [Optional] KNGKOKPFDNL NBBNEDHNODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4BAF510", Offset = "0x4BAE510", VA = "0x184BAF510")]
	public static NGEEMJOOCBL PBBGIBGCCAL(this MonoBehaviour EIEKANJPDLG, float EPPOJKJJEAK, Action OFMJDNNNBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4BAED50", Offset = "0x4BADD50", VA = "0x184BAED50")]
	public static NGEEMJOOCBL CPJBHFMKPLG(this MonoBehaviour EIEKANJPDLG, float EPPOJKJJEAK, Action OFMJDNNNBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4BAECC0", Offset = "0x4BADCC0", VA = "0x184BAECC0")]
	public static NGEEMJOOCBL BLKEHLODLGJ(this MonoBehaviour EIEKANJPDLG, float EPPOJKJJEAK, Action OFMJDNNNBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4BAEF10", Offset = "0x4BADF10", VA = "0x184BAEF10")]
	public static NGEEMJOOCBL HKMBEEAIHCD(this MonoBehaviour EIEKANJPDLG, float EPPOJKJJEAK, Action OFMJDNNNBPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class GEHNHDIDGNE : MPIBNMHJCKK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class ICLIIGPLKMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public GEHNHDIDGNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public ICLIIGPLKMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA940", Offset = "0x4BA9940", VA = "0x184BAA940")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class IGAIIBBINKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public GEHNHDIDGNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public IGAIIBBINKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA940", Offset = "0x4BA9940", VA = "0x184BAA940")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly float IJEGAJIFEPK;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8CA0", Offset = "0x4BA7CA0", VA = "0x184BA8CA0")]
	public GEHNHDIDGNE(Behaviour OLNEIJPLPKF, float IJEGAJIFEPK, [Optional] Action OPDFGJFKBMM, [Optional] KNGKOKPFDNL NBBNEDHNODL, [Optional] PNDIKCBNMCH NAFDNAFFBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8BC0", Offset = "0x4BA7BC0", VA = "0x184BA8BC0", Slot = "9")]
	protected override bool MKOJACMDHFH(Action DJBODGKMGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8AE0", Offset = "0x4BA7AE0", VA = "0x184BA8AE0", Slot = "10")]
	protected override bool LBMCGBBBGCP(Action DJBODGKMGGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface NHLNJCDOEOK
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DGJAHIAKFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LJKKLJHJMHG;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BPOIMFCIBPD(bool GFIOFEMPBAH = false);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BPOIMFCIBPD(Action DJBODGKMGGL, bool GFIOFEMPBAH = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class MPIBNMHJCKK : NHLNJCDOEOK
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class CBDBMJPNHHH : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public MPIBNMHJCKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public CBDBMJPNHHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4BA20C0", Offset = "0x4BA10C0", VA = "0x184BA20C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4BA2190", Offset = "0x4BA1190", VA = "0x184BA2190", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly Behaviour OLNEIJPLPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Action OPDFGJFKBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private AOAMAFOCGAO AKOCHEHDLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly KNGKOKPFDNL NBBNEDHNODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	protected readonly PNDIKCBNMCH NAFDNAFFBPI;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool DGJAHIAKFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x738E20", Offset = "0x737E20", VA = "0x180738E20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LJKKLJHJMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE740", Offset = "0x4BAD740", VA = "0x184BAE740", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE3E0", Offset = "0x4BAD3E0", VA = "0x184BAE3E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4BAE7E0", Offset = "0x4BAD7E0", VA = "0x184BAE7E0")]
	protected MPIBNMHJCKK(Behaviour OLNEIJPLPKF, [Optional] Action OPDFGJFKBMM, [Optional] KNGKOKPFDNL NBBNEDHNODL, [Optional] PNDIKCBNMCH NAFDNAFFBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4BAE320", Offset = "0x4BAD320", VA = "0x184BAE320", Slot = "7")]
	public bool BPOIMFCIBPD(bool GFIOFEMPBAH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4BAE2D0", Offset = "0x4BAD2D0", VA = "0x184BAE2D0", Slot = "8")]
	public bool BPOIMFCIBPD(Action DJBODGKMGGL, bool GFIOFEMPBAH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool MKOJACMDHFH(Action DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LBMCGBBBGCP(Action DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4BAE3C0", Offset = "0x4BAD3C0", VA = "0x184BAE3C0")]
	protected void GKPDHCNDJGC(Action DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4BAE480", Offset = "0x4BAD480", VA = "0x184BAE480")]
	protected HFADLOCOGOG IALMBALKEGI(float AIFLGJBDHLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4BAE6D0", Offset = "0x4BAD6D0", VA = "0x184BAE6D0")]
	private void LJDPPKCLHDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4BAE650", Offset = "0x4BAD650", VA = "0x184BAE650")]
	[IteratorStateMachine(typeof(CBDBMJPNHHH))]
	private IEnumerator<FBNJPIMJMDI> JOPPIEANLJM(float AIFLGJBDHLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4BAE380", Offset = "0x4BAD380", VA = "0x184BAE380")]
	[CompilerGenerated]
	private void COJLELCHJOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JOOFEMABAPK : MPIBNMHJCKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float CODBGEHGLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int GECNOJCEAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float AOPMPKBPNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float[] ANEOFLIMIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private int BDIHKPCMBHJ;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC3F0", Offset = "0x4BAB3F0", VA = "0x184BAC3F0")]
	public JOOFEMABAPK(Behaviour OLNEIJPLPKF, float PEECGOMFKDL, int GECNOJCEAIL, [Optional] Action OPDFGJFKBMM, float AOPMPKBPNNL = 0f, [Optional] KNGKOKPFDNL NBBNEDHNODL, [Optional] PNDIKCBNMCH NAFDNAFFBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x555AF0", Offset = "0x554AF0", VA = "0x180555AF0", Slot = "9")]
	protected override bool MKOJACMDHFH(Action DJBODGKMGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC1D0", Offset = "0x4BAB1D0", VA = "0x184BAC1D0", Slot = "10")]
	protected override bool LBMCGBBBGCP(Action DJBODGKMGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC140", Offset = "0x4BAB140", VA = "0x184BAC140")]
	private void KHFBEEHKJFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MLPKIFMNANN : MPIBNMHJCKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly float IJEGAJIFEPK;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8CA0", Offset = "0x4BA7CA0", VA = "0x184BA8CA0")]
	public MLPKIFMNANN(Behaviour OLNEIJPLPKF, float IJEGAJIFEPK, [Optional] Action OPDFGJFKBMM, [Optional] KNGKOKPFDNL NBBNEDHNODL, [Optional] PNDIKCBNMCH NAFDNAFFBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x555AF0", Offset = "0x554AF0", VA = "0x180555AF0", Slot = "9")]
	protected override bool MKOJACMDHFH(Action DJBODGKMGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4BAE290", Offset = "0x4BAD290", VA = "0x184BAE290", Slot = "10")]
	protected override bool LBMCGBBBGCP(Action DJBODGKMGGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class BKHANNKNHNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MFKEENIIABF : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public MFKEENIIABF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4BADFD0", Offset = "0x4BACFD0", VA = "0x184BADFD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE070", Offset = "0x4BAD070", VA = "0x184BAE070", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private NGEEMJOOCBL GEGIAIOJAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private OBOJOLAHPAP OLNEIJPLPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Action<float> AOFGINHJICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private float BFCKMDLNIFN;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1E20", Offset = "0x4BA0E20", VA = "0x184BA1E20")]
	public BKHANNKNHNG(OBOJOLAHPAP OLNEIJPLPKF, float ELDDCCCDECH, Action<float> PHKOLMBKBBK, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4BA19A0", Offset = "0x4BA09A0", VA = "0x184BA19A0")]
	private void BFPJNCBFHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1BC0", Offset = "0x4BA0BC0", VA = "0x184BA1BC0")]
	private void KFCOANOCPIK(string FHJBPHCDOKC, Action CNNACNGHLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1B50", Offset = "0x4BA0B50", VA = "0x184BA1B50")]
	[IteratorStateMachine(typeof(MFKEENIIABF))]
	private IEnumerator<FBNJPIMJMDI> JIMCMNENGOH(Action CNNACNGHLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1AF0", Offset = "0x4BA0AF0", VA = "0x184BA1AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1CD0", Offset = "0x4BA0CD0", VA = "0x184BA1CD0")]
	[CompilerGenerated]
	private void OKDLMOILNNF(string OADAOAPKMCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class GGOLBFJFNPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class OIHFPIPOIPE : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public OIHFPIPOIPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE9E0", Offset = "0x4BAD9E0", VA = "0x184BAE9E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4BAEA80", Offset = "0x4BADA80", VA = "0x184BAEA80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NGEEMJOOCBL GEGIAIOJAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private MonoBehaviour EIEKANJPDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Action PHKOLMBKBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Action<float> AOFGINHJICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private float BFCKMDLNIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool MDBDBJOKADM;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9750", Offset = "0x4BA8750", VA = "0x184BA9750")]
	public GGOLBFJFNPM(MonoBehaviour EIEKANJPDLG, Action PHKOLMBKBBK, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4BA95C0", Offset = "0x4BA85C0", VA = "0x184BA95C0")]
	public GGOLBFJFNPM(MonoBehaviour EIEKANJPDLG, Action<float> PHKOLMBKBBK, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9420", Offset = "0x4BA8420", VA = "0x184BA9420")]
	public GGOLBFJFNPM(MonoBehaviour EIEKANJPDLG, float ELDDCCCDECH, Action<float> PHKOLMBKBBK, EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC, bool MDBDBJOKADM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9300", Offset = "0x4BA8300", VA = "0x184BA9300")]
	private void NPEEFODFKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8E40", Offset = "0x4BA7E40", VA = "0x184BA8E40")]
	private void DCNFPDFKOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8CF0", Offset = "0x4BA7CF0", VA = "0x184BA8CF0")]
	private void BFPJNCBFHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4BA91E0", Offset = "0x4BA81E0", VA = "0x184BA91E0")]
	private void KFCOANOCPIK(string FHJBPHCDOKC, Action CNNACNGHLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9170", Offset = "0x4BA8170", VA = "0x184BA9170")]
	[IteratorStateMachine(typeof(OIHFPIPOIPE))]
	private IEnumerator<FBNJPIMJMDI> JIMCMNENGOH(Action CNNACNGHLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8F90", Offset = "0x4BA7F90", VA = "0x184BA8F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4BA90F0", Offset = "0x4BA80F0", VA = "0x184BA90F0")]
	[CompilerGenerated]
	private void ILKBCLODEIL(string OADAOAPKMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8FF0", Offset = "0x4BA7FF0", VA = "0x184BA8FF0")]
	[CompilerGenerated]
	private void GCFGCBKIGME(string OADAOAPKMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9070", Offset = "0x4BA8070", VA = "0x184BA9070")]
	[CompilerGenerated]
	private void HPBBOJAILPE(string OADAOAPKMCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Flags]
internal enum ABHOAANNPDB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class KNDOHPHEBDO : PNDIKCBNMCH
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float MKKFPFEEDJH
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD8E0", Offset = "0x4BAC8E0", VA = "0x184BAD8E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float PAFGIBGADMH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD8B0", Offset = "0x4BAC8B0", VA = "0x184BAD8B0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double JNOBMJFOFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD8C0", Offset = "0x4BAC8C0", VA = "0x184BAD8C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4BAD8F0", Offset = "0x4BAC8F0", VA = "0x184BAD8F0")]
	[BFAJCGBKNMF]
	private static void LFMPNIAMMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	[Preserve]
	internal KNDOHPHEBDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal interface LOOOJBPLKLF
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKOOEKIJDAH(string JIEIIEKPPIJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNBBBEGLFOE();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal interface NIFJJFFBMML
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	string DEIIFAKABEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool EJBIELGFJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool KCNHIODICAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal class FCGBHBNEGJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public DEDFEIMHJDJ DFBGPKCIIJP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int MPBCIHFGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x594770", Offset = "0x593770", VA = "0x180594770", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5B3430", Offset = "0x5B2430", VA = "0x1805B3430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8560", Offset = "0x4BA7560", VA = "0x184BA8560")]
	public static FBNJPIMJMDI EFJLFPHNNCE(IEnumerator<FBNJPIMJMDI> KIOFEDFKJDH, EHFJKBBAHEG IGPEFPAFKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8480", Offset = "0x4BA7480", VA = "0x184BA8480")]
	public FBNJPIMJMDI EFJLFPHNNCE(EHFJKBBAHEG[] GFPNMHKPGIP, IEnumerator<FBNJPIMJMDI>[] NADLHCPOMEF, FBNJPIMJMDI[] ELBFNBPPJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8450", Offset = "0x4BA7450", VA = "0x184BA8450")]
	public void KPIGJFNFCMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA86C0", Offset = "0x4BA76C0", VA = "0x184BA86C0")]
	public void GLBIBGLMNNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8790", Offset = "0x4BA7790", VA = "0x184BA8790")]
	public void HHFDEBABMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8450", Offset = "0x4BA7450", VA = "0x184BA8450")]
	public void CKKOAMFAFFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public FCGBHBNEGJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class DEDFEIMHJDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct LMLIEABIHLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public FCGBHBNEGJA FGIEDPHAKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public OBOJOLAHPAP EPCNAHPFCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public EHFJKBBAHEG FGAFOOLPPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public IEnumerator<FBNJPIMJMDI> IAGIFGBIEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public FBNJPIMJMDI IPDFFMKIJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public ABHOAANNPDB IHCDCNALKJL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct PHJMBGKFOJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public EPABBDPLHHK.DLNBAPGFDPI BMLJAKLMOLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public List<LMLIEABIHLG> EFBCCPJKPOA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class JJFFAHMDCFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public DEDFEIMHJDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public OBOJOLAHPAP context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public FCGBHBNEGJA routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public ABHOAANNPDB coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public EHFJKBBAHEG promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public FBNJPIMJMDI currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public IEnumerator<FBNJPIMJMDI> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public JJFFAHMDCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4BAB680", Offset = "0x4BAA680", VA = "0x184BAB680")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class FLOBPCGHMPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public FCGBHBNEGJA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public DEDFEIMHJDJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public FLOBPCGHMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8980", Offset = "0x4BA7980", VA = "0x184BA8980")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class CKBHINLIAPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public FCGBHBNEGJA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public DEDFEIMHJDJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public CKBHINLIAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4BA2D00", Offset = "0x4BA1D00", VA = "0x184BA2D00")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class PJHDPGHNHLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public FCGBHBNEGJA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public DEDFEIMHJDJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public PJHDPGHNHLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4BAF870", Offset = "0x4BAE870", VA = "0x184BAF870")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private const ABHOAANNPDB OPOPBIDDAKP = ABHOAANNPDB.Cancelled | ABHOAANNPDB.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool[] GFFNCKHPAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private NativeArray<ABHOAANNPDB> HOCHMHBBEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private NativeArray<float> NNKNFAKENBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private NativeArray<int> DKCLIAGOCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private NativeArray<int> OKBDICKOCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private NativeArray<int> CCDDNFKIDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private NativeArray<int> HKLOOLGDJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private NativeArray<int> HDLHBGKGLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private FCGBHBNEGJA[] PJJNEKMMBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private EHFJKBBAHEG[] GFPNMHKPGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private OBOJOLAHPAP[] MOBGECILIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private IEnumerator<FBNJPIMJMDI>[] NPOGKIPLEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private FBNJPIMJMDI[] OADDPGEPCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int PJKIGCKAECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int FFHMMNBBJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly int CMCFLBCDONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float NENODNGAGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private EEDFLKNHNNA EPCGNNINEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private JobHandle IKLEDIAMKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private List<FCGBHBNEGJA> IIGJELKDCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool BAFBHMGGKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private List<Action> LDABHJKLKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private List<Action> CBCBNBKMLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool KKLBHAPGAND;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public PHJMBGKFOJF[] BKLIGJDEEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8E7C00", Offset = "0x8E6C00", VA = "0x1808E7C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4BA59D0", Offset = "0x4BA49D0", VA = "0x184BA59D0")]
	private static int ICFPNFCFOCB(EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4BA6650", Offset = "0x4BA5650", VA = "0x184BA6650")]
	public DEDFEIMHJDJ(EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5130", Offset = "0x4BA4130", VA = "0x184BA5130")]
	private void DCIPOGBKCBE(ref int NBPJIFECJLD, int PCJPMGGFCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5A80", Offset = "0x4BA4A80", VA = "0x184BA5A80")]
	public void JIEGFHHHLDG(OBOJOLAHPAP OLNEIJPLPKF, FBNJPIMJMDI DNLLCPNABDD, IEnumerator<FBNJPIMJMDI> KIOFEDFKJDH, EHFJKBBAHEG IGPEFPAFKHD, [Optional] FCGBHBNEGJA JPKKDEPACHC, ABHOAANNPDB BCHCJGMHFIH = ABHOAANNPDB.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5640", Offset = "0x4BA4640", VA = "0x184BA5640")]
	public void EOODHIFACKB(IEnumerable<LMLIEABIHLG> CGEBPLPOKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4880", Offset = "0x4BA3880", VA = "0x184BA4880")]
	private LMLIEABIHLG ANKOJEACAIO(int GJDJCAKNLKK)
	{
		return default(LMLIEABIHLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4D00", Offset = "0x4BA3D00", VA = "0x184BA4D00")]
	private void BFOFPCLJBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2713F10", Offset = "0x2712F10", VA = "0x182713F10")]
	private static void EHJGLIAEKPK<T>(int GJDJCAKNLKK, T[] JDOJOODIFBI, int DDMFGCPNLGN, [Optional] T FHOLIOOOGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2713EF0", Offset = "0x2712EF0", VA = "0x182713EF0")]
	private static void EHJGLIAEKPK<T>(int GJDJCAKNLKK, NativeArray<T> JDOJOODIFBI, int DDMFGCPNLGN, [Optional] T FHOLIOOOGID) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5DD0", Offset = "0x4BA4DD0", VA = "0x184BA5DD0")]
	private void LOJPFHOBAPG(IEnumerable<LMLIEABIHLG> CGEBPLPOKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA6070", Offset = "0x4BA5070", VA = "0x184BA6070")]
	private void NAJILMKGOBH(LMLIEABIHLG LEAKFFNDOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA52C0", Offset = "0x4BA42C0", VA = "0x184BA52C0")]
	private IMJILKMLMBK EFCDCMPIOMG(int OIFMNNJNCEN)
	{
		return default(IMJILKMLMBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5BE0", Offset = "0x4BA4BE0", VA = "0x184BA5BE0")]
	public void LHMFDONCLND(float PPPEADOGGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5A00", Offset = "0x4BA4A00", VA = "0x184BA5A00")]
	private void JEFHNNFBOJF(Action OOKPIHBNHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4BA65D0", Offset = "0x4BA55D0", VA = "0x184BA65D0")]
	private void PGBHGGACAKC(Action OOKPIHBNHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4BA6130", Offset = "0x4BA5130", VA = "0x184BA6130")]
	public void OCPINNPHHLO(float PPPEADOGGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4BA58F0", Offset = "0x4BA48F0", VA = "0x184BA58F0")]
	public void GPGHDCEFFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5070", Offset = "0x4BA4070", VA = "0x184BA5070")]
	public void CKKOAMFAFFD(FCGBHBNEGJA GKDIMGEECJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5830", Offset = "0x4BA4830", VA = "0x184BA5830")]
	public void EPFLFCKJPAO(FCGBHBNEGJA GKDIMGEECJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5580", Offset = "0x4BA4580", VA = "0x184BA5580")]
	public void EJFIMALANFF(FCGBHBNEGJA GKDIMGEECJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KGBMOIBABLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static readonly KGBMOIBABLN HAOGDNGPDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly Action JJFBMDFLKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool MGKCHJEDODG;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5B9040", Offset = "0x5B8040", VA = "0x1805B9040")]
	public KGBMOIBABLN(Action JJFBMDFLKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC750", Offset = "0x4BAB750", VA = "0x184BAC750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface HJEGHKAIMIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	T CIFMBHMEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable FNCBMONPDIB(UnityEngine.Object OLNEIJPLPKF, Action<T> EIIMCDFIKKK);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface AGHGIINPMBO<T> : global::HJEGHKAIMIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	new T CIFMBHMEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class NIACCEEFFBH<T> : global::AGHGIINPMBO<T>, global::HJEGHKAIMIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class LCOJCOMCACL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public global::NIACCEEFFBH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public global::JEIJHHJGJEP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public LCOJCOMCACL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x369D660", Offset = "0x369C660", VA = "0x18369D660")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static GameObject CHGINNEFNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<global::JEIJHHJGJEP<UnityEngine.Object, Action<T>>> DLMMKAFFHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private T DCCLEGBMOHN;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public T CIFMBHMEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5B0", Offset = "0x5BC5B0", VA = "0x1805BD5B0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x36A8730", Offset = "0x36A7730", VA = "0x1836A8730", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x36A87C0", Offset = "0x36A77C0", VA = "0x1836A87C0")]
	private static bool MOONENJENGF(T OOKPIHBNHGF, T FMMAACMCILJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x36A8820", Offset = "0x36A7820", VA = "0x1836A8820")]
	public NIACCEEFFBH(T CHDEKLHOFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x36A83F0", Offset = "0x36A73F0", VA = "0x1836A83F0", Slot = "6")]
	public IDisposable FNCBMONPDIB(UnityEngine.Object OLNEIJPLPKF, Action<T> EIIMCDFIKKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x36A80D0", Offset = "0x36A70D0", VA = "0x1836A80D0")]
	private void CIGPBPPHDCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[BurstCompile]
internal struct EEDFLKNHNNA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ReadOnly]
	public float EBACJIILNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[ReadOnly]
	public int ONCLMIIGIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private NativeArray<int> DEFKHCNMDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private NativeArray<int> MJOJCHPNMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private NativeArray<int> NCPAPIIOJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[ReadOnly]
	public NativeArray<ABHOAANNPDB> PGBNNMPDGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[ReadOnly]
	public NativeArray<float> ELCECKNNNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[WriteOnly]
	public NativeArray<int> CCDDNFKIDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[WriteOnly]
	public NativeArray<int> DKCLIAGOCDJ;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7AB0", Offset = "0x4BA6AB0", VA = "0x184BA7AB0")]
	public static EEDFLKNHNNA JHOEBDGEJAE(int ONMFLGKGEAK, float PPPEADOGGOM, NativeArray<ABHOAANNPDB> ACDMHPLJGNC, NativeArray<float> GHOKNCFNDFO, NativeArray<int> EOGKIEEOGEI, NativeArray<int> CKAAOHDOOBE, NativeArray<int> PHINLAOPIHM, NativeArray<int> MJOJCHPNMDE, NativeArray<int> NCPAPIIOJEE)
	{
		return default(EEDFLKNHNNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7920", Offset = "0x4BA6920", VA = "0x184BA7920", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7A00", Offset = "0x4BA6A00", VA = "0x184BA7A00")]
	private bool HCIMOIAIBGE(int CFANIPEBCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4BA76C0", Offset = "0x4BA66C0", VA = "0x184BA76C0")]
	private void BABKMLDOABE(NativeArray<int> POLLOLJIIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7A40", Offset = "0x4BA6A40", VA = "0x184BA7A40")]
	private int IEELCFLDEIJ(int EMAJDPFLFBM, int HAOMDFOCFHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7B80", Offset = "0x4BA6B80", VA = "0x184BA7B80")]
	private void KNCGJOAMCHD(NativeArray<int> POLLOLJIIDJ, int LACLNGNLGPC, int GJPGJAACOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4BA76F0", Offset = "0x4BA66F0", VA = "0x184BA76F0")]
	private void COAOIFKJAEG(NativeArray<int> POLLOLJIIDJ, int DHKJMOGNCMI, int BGDKGBAIKAP, int HGGKPDKBLIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class CHJKBOBFOHJ : KJHGIDHBKBH, KNGKOKPFDNL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private DEDFEIMHJDJ[] IBEPKJLHEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private LOOOJBPLKLF MPPHKAOEHKD;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2AC0", Offset = "0x4BA1AC0", VA = "0x184BA2AC0")]
	[BFAJCGBKNMF]
	private static void LFMPNIAMMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2C40", Offset = "0x4BA1C40", VA = "0x184BA2C40")]
	[Preserve]
	public CHJKBOBFOHJ([FPOHDCDDHBH(null)] MJEPMDIMFPC DGLJDMMJBFE, [FPOHDCDDHBH(null)] PNDIKCBNMCH NAFDNAFFBPI, [FPOHDCDDHBH(null)] DGLABNHEMAI NKIMPKENEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA24C0", Offset = "0x4BA14C0", VA = "0x184BA24C0", Slot = "12")]
	public override NGEEMJOOCBL HHNOAOGODIE(OBOJOLAHPAP OLNEIJPLPKF, IEnumerator<FBNJPIMJMDI> HDCIHNAPHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2630", Offset = "0x4BA1630", VA = "0x184BA2630", Slot = "13")]
	public override void IDHIAHKAEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA28F0", Offset = "0x4BA18F0", VA = "0x184BA28F0", Slot = "15")]
	public override void JIBEHGGNMOC(EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA21E0", Offset = "0x4BA11E0", VA = "0x184BA21E0", Slot = "14")]
	protected override void ADBHOPCDBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA25F0", Offset = "0x4BA15F0", VA = "0x184BA25F0")]
	private DEDFEIMHJDJ HPDEOHKCFFH(EPABBDPLHHK.DLNBAPGFDPI DMBEFJIHONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2B90", Offset = "0x4BA1B90", VA = "0x184BA2B90", Slot = "16")]
	internal override EPNEDFMEEGE PJHJIPLJODD(IEnumerator<FBNJPIMJMDI> HDCIHNAPHKN, Behaviour OLNEIJPLPKF, EHFJKBBAHEG IGPEFPAFKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2330", Offset = "0x4BA1330", VA = "0x184BA2330", Slot = "17")]
	internal override APOCPBPMALJ ENOOFDNIBCD(EPABBDPLHHK.DLNBAPGFDPI NGJOKEMPLOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4BA23A0", Offset = "0x4BA13A0", VA = "0x184BA23A0")]
	private void GBGMPNDACHM(DEDFEIMHJDJ JBBBBCDCHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4BA22C0", Offset = "0x4BA12C0", VA = "0x184BA22C0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class KJHGIDHBKBH : KNGKOKPFDNL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly MJEPMDIMFPC DGLJDMMJBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly PNDIKCBNMCH NAFDNAFFBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly DGLABNHEMAI NKIMPKENEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private APOCPBPMALJ[] PFOEHABPKDM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static KNGKOKPFDNL GBAAOFDIJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4BAC920", Offset = "0x4BAB920", VA = "0x184BAC920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static bool BAKJAENLFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x555B00", Offset = "0x554B00", VA = "0x180555B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EPABBDPLHHK.DLNBAPGFDPI CJJAPFAKPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x594770", Offset = "0x593770", VA = "0x180594770", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(EPABBDPLHHK.DLNBAPGFDPI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5B3430", Offset = "0x5B2430", VA = "0x1805B3430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public PNDIKCBNMCH ELNDPHAOHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x584B30", Offset = "0x583B30", VA = "0x180584B30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC9E0", Offset = "0x4BAB9E0", VA = "0x184BAC9E0")]
	public static NGEEMJOOCBL BOLALJDMPJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4BAD600", Offset = "0x4BAC600", VA = "0x184BAD600")]
	[Preserve]
	protected KJHGIDHBKBH([FPOHDCDDHBH(null)] MJEPMDIMFPC DGLJDMMJBFE, [FPOHDCDDHBH(null)] PNDIKCBNMCH NAFDNAFFBPI, [FPOHDCDDHBH(null)] DGLABNHEMAI NKIMPKENEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4BAD1A0", Offset = "0x4BAC1A0", VA = "0x184BAD1A0", Slot = "6")]
	public NGEEMJOOCBL IOHEKBDABGH(IEnumerator<FBNJPIMJMDI> HDCIHNAPHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4BACF80", Offset = "0x4BABF80", VA = "0x184BACF80", Slot = "7")]
	public NGEEMJOOCBL IOHEKBDABGH(Behaviour OLNEIJPLPKF, IEnumerator<FBNJPIMJMDI> HDCIHNAPHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract NGEEMJOOCBL HHNOAOGODIE(OBOJOLAHPAP OLNEIJPLPKF, IEnumerator<FBNJPIMJMDI> HDCIHNAPHKN);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4BACDA0", Offset = "0x4BABDA0", VA = "0x184BACDA0", Slot = "13")]
	public virtual void IDHIAHKAEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4BAD5A0", Offset = "0x4BAC5A0", VA = "0x184BAD5A0", Slot = "9")]
	public void PFCKFLOBLFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC8E0", Offset = "0x4BAB8E0", VA = "0x184BAC8E0", Slot = "14")]
	protected virtual void ADBHOPCDBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC900", Offset = "0x4BAB900", VA = "0x184BAC900")]
	private void ANMGIGGBHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4BACD80", Offset = "0x4BABD80", VA = "0x184BACD80")]
	private void FAIAIEOMILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4BACAC0", Offset = "0x4BABAC0", VA = "0x184BACAC0")]
	private void CLBMHHNKOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4BACAA0", Offset = "0x4BABAA0", VA = "0x184BACAA0")]
	private void CDEIPGNFLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4BACD60", Offset = "0x4BABD60", VA = "0x184BACD60")]
	private void EBAPBNALNHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4BACA80", Offset = "0x4BABA80", VA = "0x184BACA80")]
	private void CCANLJNFDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4BAD1B0", Offset = "0x4BAC1B0", VA = "0x184BAD1B0", Slot = "15")]
	public virtual void JIBEHGGNMOC(EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4BAD3E0", Offset = "0x4BAC3E0", VA = "0x184BAD3E0")]
	private void NDKJOEJABDD(APOCPBPMALJ JBBBBCDCHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2601CE0", Offset = "0x2600CE0", VA = "0x182601CE0")]
	private APOCPBPMALJ HIOJLNBCHAN(EPABBDPLHHK.DLNBAPGFDPI DMBEFJIHONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract EPNEDFMEEGE PJHJIPLJODD(IEnumerator<FBNJPIMJMDI> HDCIHNAPHKN, Behaviour EIEKANJPDLG, EHFJKBBAHEG CADEJBLOLME);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract APOCPBPMALJ ENOOFDNIBCD(EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4BACAE0", Offset = "0x4BABAE0", VA = "0x184BACAE0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class EPNEDFMEEGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly EHFJKBBAHEG IGPEFPAFKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly NIFJJFFBMML OLNEIJPLPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly bool PNONKAHAKIN;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IEnumerator<FBNJPIMJMDI> IAGIFGBIEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551490", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public FBNJPIMJMDI IPDFFMKIJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x595030", Offset = "0x594030", VA = "0x180595030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool OECBFNJILKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8150", Offset = "0x4BA7150", VA = "0x184BA8150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GAGLEHCAIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xAF4080", Offset = "0xAF3080", VA = "0x180AF4080")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x24321C0", Offset = "0x24311C0", VA = "0x1824321C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string DEIIFAKABEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5D8550", Offset = "0x5D7550", VA = "0x1805D8550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5D84D0", Offset = "0x5D74D0", VA = "0x1805D84D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float OIMFAPLCJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x799990", Offset = "0x798990", VA = "0x180799990")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x799980", Offset = "0x798980", VA = "0x180799980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8260", Offset = "0x4BA7260", VA = "0x184BA8260")]
	public EPNEDFMEEGE(IEnumerator<FBNJPIMJMDI> KIOFEDFKJDH, NIFJJFFBMML OLNEIJPLPKF, EHFJKBBAHEG IGPEFPAFKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7EE0", Offset = "0x4BA6EE0", VA = "0x184BA7EE0")]
	public FBNJPIMJMDI EFJLFPHNNCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7E70", Offset = "0x4BA6E70", VA = "0x184BA7E70")]
	public bool EBLAEFJPKOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7DE0", Offset = "0x4BA6DE0", VA = "0x184BA7DE0")]
	public void CKKOAMFAFFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA81D0", Offset = "0x4BA71D0", VA = "0x184BA81D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xBE3900", Offset = "0xBE2900", VA = "0x180BE3900")]
	[CompilerGenerated]
	private void NGGPOBKKBGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class EHFJKBBAHEG : IBCCNHBHOKC, NGEEMJOOCBL, AOAMAFOCGAO, HFADLOCOGOG, IEnumerator, FBNJPIMJMDI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private EPABBDPLHHK.DLNBAPGFDPI GMJCFMLEOEG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private EPABBDPLHHK.DLNBAPGFDPI CJKFOFMOFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5D8560", Offset = "0x5D7560", VA = "0x1805D8560", Slot = "23")]
		get
		{
			return default(EPABBDPLHHK.DLNBAPGFDPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public EPABBDPLHHK.DLNBAPGFDPI DFBGPKCIIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5D8540", Offset = "0x5D7540", VA = "0x1805D8540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private float KMOGECLBADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x596CC0", Offset = "0x595CC0", VA = "0x180596CC0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7C50", Offset = "0x4BA6C50", VA = "0x184BA7C50", Slot = "24")]
	private bool CFPPAADPFHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7C70", Offset = "0x4BA6C70", VA = "0x184BA7C70", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7C80", Offset = "0x4BA6C80", VA = "0x184BA7C80")]
	public EHFJKBBAHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal enum IMJILKMLMBK : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class APOCPBPMALJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public enum IFMHBEIMIGP
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct EGFKCEAKPNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public EPABBDPLHHK.DLNBAPGFDPI BMLJAKLMOLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public IFMHBEIMIGP LFANOICCCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public List<EPNEDFMEEGE> LKGLHGIPEBA;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly IFMHBEIMIGP[] FHICLEIOIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly EPABBDPLHHK.DLNBAPGFDPI AMNHEMIGNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private bool CIGNBBIFFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly EPNEDFMEEGE[] KKDMGIDFEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly List<EPNEDFMEEGE> IEGJHBOPJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly Stack<int> MAHKLLBHOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly List<EPNEDFMEEGE> JKKFJIIDFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly Stack<int> FOPJFKOECJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly LOOOJBPLKLF NEKHGGBACMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private bool KKLBHAPGAND;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public EGFKCEAKPNG[,] GLKGIDGNKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x594D30", Offset = "0x593D30", VA = "0x180594D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0FB0", Offset = "0x4B9FFB0", VA = "0x184BA0FB0")]
	public APOCPBPMALJ(EPABBDPLHHK.DLNBAPGFDPI NGJOKEMPLOC, LOOOJBPLKLF NEKHGGBACMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4BA03C0", Offset = "0x4B9F3C0", VA = "0x184BA03C0")]
	public void EGMGBIBCAHL(EPNEDFMEEGE KIOFEDFKJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0A50", Offset = "0x4B9FA50", VA = "0x184BA0A50")]
	public void OPJJHNMKKAJ(IList<EPNEDFMEEGE> NADLHCPOMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0000", Offset = "0x4B9F000", VA = "0x184BA0000")]
	public void DIEGHJDPKOH(IList<EPNEDFMEEGE> NADLHCPOMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0840", Offset = "0x4B9F840", VA = "0x184BA0840")]
	private void JOPLCIDBBOI(EPNEDFMEEGE KIOFEDFKJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4B9FE90", Offset = "0x4B9EE90", VA = "0x184B9FE90")]
	private void CPEMBKBIPKO(IList<EPNEDFMEEGE> NADLHCPOMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA04E0", Offset = "0x4B9F4E0", VA = "0x184BA04E0")]
	private IMJILKMLMBK FDIINCPKBJM(EPNEDFMEEGE KIOFEDFKJDH)
	{
		return default(IMJILKMLMBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4B9FD40", Offset = "0x4B9ED40", VA = "0x184B9FD40")]
	public void ADBHOPCDBIC(float PPPEADOGGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0CD0", Offset = "0x4B9FCD0", VA = "0x184BA0CD0")]
	public void PFCKFLOBLFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0660", Offset = "0x4B9F660", VA = "0x184BA0660")]
	private void GJNDIEFJJIK(List<EPNEDFMEEGE> NADLHCPOMEF, Stack<int> PAFHDCBAFOM, bool ODIKPKMPHGA, float CIPPAGDGMBK = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0280", Offset = "0x4B9F280", VA = "0x184BA0280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0930", Offset = "0x4B9F930", VA = "0x184BA0930")]
	private void MNONFEBJIII(List<EPNEDFMEEGE> NADLHCPOMEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class DEJOPLFNGFK : LOOOJBPLKLF
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "4")]
	public void CKOOEKIJDAH(string JIEIIEKPPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
	public void CNBBBEGLFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public DEJOPLFNGFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class OJJPODPEHFB : NIFJJFFBMML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Behaviour EIEKANJPDLG;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string DEIIFAKABEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4BAEB50", Offset = "0x4BADB50", VA = "0x184BAEB50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool EJBIELGFJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4BAEAF0", Offset = "0x4BADAF0", VA = "0x184BAEAF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool KCNHIODICAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4BAEAD0", Offset = "0x4BADAD0", VA = "0x184BAEAD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5B9040", Offset = "0x5B8040", VA = "0x1805B9040")]
	public OJJPODPEHFB(Behaviour EIEKANJPDLG)
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

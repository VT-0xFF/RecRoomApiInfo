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
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OBEECGBCBNL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority EDOOOBCMAAM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A0BF80", Offset = "0x6A0AF80", VA = "0x186A0BF80")]
	public OBEECGBCBNL(ThreadPriority FCKAHNPLPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A0BF70", Offset = "0x6A0AF70", VA = "0x186A0BF70", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> DPEDHGIKGGC(List<PlayerLoopSystem> BCGOFJIJJGH, int CCMKOBBBOPO);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct LENEIEDEJAA
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct PMLOACJEKKI
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static LHMMLLGDOFK CAGCKDEKBFG;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x6A11FA0", Offset = "0x6A10FA0", VA = "0x186A11FA0")]
				public static PlayerLoopSystem PFOIEANNDLF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct INJJIIEFJGK
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static LHMMLLGDOFK FIHPIFPKNGP;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x6A03A30", Offset = "0x6A02A30", VA = "0x186A03A30")]
				public static PlayerLoopSystem PFOIEANNDLF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct ILCHADIFDGA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static LHMMLLGDOFK NFLDEKEIDAK;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6A03830", Offset = "0x6A02830", VA = "0x186A03830")]
				public static PlayerLoopSystem PFOIEANNDLF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct MAMNALJKAEL
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static LHMMLLGDOFK GFKMMJPPIPC;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static LHMMLLGDOFK GAHGACALICA;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static LHMMLLGDOFK GHAEJLGHNHO;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static LHMMLLGDOFK IBGOGNLLLGP;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x6A08A90", Offset = "0x6A07A90", VA = "0x186A08A90")]
				public static PlayerLoopSystem PFOIEANNDLF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct EJAGGKGOIOM
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static LHMMLLGDOFK PBFKJKCAGNC;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x69FF420", Offset = "0x69FE420", VA = "0x1869FF420")]
				public static PlayerLoopSystem PFOIEANNDLF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct CCGIFBAEAIL
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static LHMMLLGDOFK GFKMMJPPIPC;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static LHMMLLGDOFK GAHGACALICA;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static LHMMLLGDOFK GHAEJLGHNHO;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static LHMMLLGDOFK IBGOGNLLLGP;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x69F8AA0", Offset = "0x69F7AA0", VA = "0x1869F8AA0")]
				public static PlayerLoopSystem PFOIEANNDLF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct EFMLHIEJFBI
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static LHMMLLGDOFK IPNOPEMBDJP;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x69FE7E0", Offset = "0x69FD7E0", VA = "0x1869FE7E0")]
				public static PlayerLoopSystem PFOIEANNDLF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct GFCOOLIDKBP
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static LHMMLLGDOFK ABCFIOAEBFL;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6A006F0", Offset = "0x69FF6F0", VA = "0x186A006F0")]
				public static PlayerLoopSystem PFOIEANNDLF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct BGLNEOCBIEL
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static LHMMLLGDOFK JJIMONEHJNN;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x69F8620", Offset = "0x69F7620", VA = "0x1869F8620")]
				public static PlayerLoopSystem PFOIEANNDLF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct OAPAMJJFJMI
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static LHMMLLGDOFK NBJHLDKJLEM;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6A0BD70", Offset = "0x6A0AD70", VA = "0x186A0BD70")]
				public static PlayerLoopSystem PFOIEANNDLF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct IGAGLFBPGNB
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static LHMMLLGDOFK INAFFNMDDKA;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6A03630", Offset = "0x6A02630", VA = "0x186A03630")]
				public static PlayerLoopSystem PFOIEANNDLF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct GNHKEAFJOCJ
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static LHMMLLGDOFK KMNFGJAMOMI;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x6A01DA0", Offset = "0x6A00DA0", VA = "0x186A01DA0")]
				public static PlayerLoopSystem PFOIEANNDLF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum DCHBJFMANFI : byte
			{
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct GLACHEBBFHE
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class LDHIBLCBAOE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public DCHBJFMANFI updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
					public LDHIBLCBAOE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x6A08580", Offset = "0x6A07580", VA = "0x186A08580")]
					internal void MLPCILBBCLF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static MDKLHFICKPP<DCHBJFMANFI> KFNPEFNJECK;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6A01470", Offset = "0x6A00470", VA = "0x186A01470")]
				public static PlayerLoopSystem PFOIEANNDLF(DCHBJFMANFI DAGLCJLDODL)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct EGBMNOMJLBB
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class OADPAKIBJKD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public LLDOALPACOJ.JLAJMBIHIJC key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
					public OADPAKIBJKD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6A0BB30", Offset = "0x6A0AB30", VA = "0x186A0BB30")]
					internal void FDEDLNABLNG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable MDPEAPKAPNL;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x69FE9E0", Offset = "0x69FD9E0", VA = "0x1869FE9E0")]
				public static PlayerLoopSystem NBCCGMFNMNF(LLDOALPACOJ.JLAJMBIHIJC IPAJBJLLPIJ)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct AFHCEIBKJOI
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class AACOHCKFIBD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public LLDOALPACOJ.JLAJMBIHIJC key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
					public AACOHCKFIBD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x69F7220", Offset = "0x69F6220", VA = "0x1869F7220")]
					internal void FDEDLNABLNG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x69F7490", Offset = "0x69F6490", VA = "0x1869F7490")]
				public static PlayerLoopSystem NBCCGMFNMNF(LLDOALPACOJ.JLAJMBIHIJC IPAJBJLLPIJ)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class DFBIGGHKDIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public DFBIGGHKDIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x69FCD40", Offset = "0x69FBD40", VA = "0x1869FCD40")]
			internal List<PlayerLoopSystem> JEFHANOCCFB(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool ADLKJDFJPJB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool ILLNCLDFJCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x69F9200", Offset = "0x69F8200", VA = "0x1869F9200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69FA410", Offset = "0x69F9410", VA = "0x1869FA410")]
		private static void PFCKHKEFPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69F9630", Offset = "0x69F8630", VA = "0x1869F9630")]
		private static void COAEMLLBNOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69F9400", Offset = "0x69F8400", VA = "0x1869F9400")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69F9240", Offset = "0x69F8240", VA = "0x1869F9240")]
		private static void AOKFIKBFMGL(LLDOALPACOJ.JLAJMBIHIJC IPAJBJLLPIJ, PlayerLoopSystem NLMOMOBEALD, Type LHOIPPNOAPD, Type ONFOANENBDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69FA030", Offset = "0x69F9030", VA = "0x1869FA030")]
		private static void PEMALPDMDNJ(PlayerLoopSystem NLMOMOBEALD, Type LHOIPPNOAPD, Type ONFOANENBDJ, DPEDHGIKGGC OOKIDHGPHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69F9F00", Offset = "0x69F8F00", VA = "0x1869F9F00")]
		private static void MNIGNHHCGAJ(PlayerLoopSystem NLMOMOBEALD, Type LHOIPPNOAPD, Type ONFOANENBDJ, PlayerLoopSystem? DGNELMPCJOH, PlayerLoopSystem? LFNCPJOPLBJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class LLDOALPACOJ
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum JLAJMBIHIJC
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class BEEPPNBLOOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly JLAJMBIHIJC PNCICHFELGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly OFCDIHFFKKJ NBNIEFOBJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long JLNKLEGNGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long HLJADLKBCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long DNOOFGKCFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int PHODBGEKGOK;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69F8360", Offset = "0x69F7360", VA = "0x1869F8360")]
		public BEEPPNBLOOE(JLAJMBIHIJC GIADKBKICBI, int LNCMNOJJHEC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x69F80C0", Offset = "0x69F70C0", VA = "0x1869F80C0")]
		public void NHECEPIGDPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x69F8130", Offset = "0x69F7130", VA = "0x1869F8130")]
		public void PJAPBLMEENE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69F8180", Offset = "0x69F7180", VA = "0x1869F8180")]
		public void PPENOLCJALP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static JLAJMBIHIJC[] HFACKMMONGD;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static BEEPPNBLOOE[] OPAOLMFHMLG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A08710", Offset = "0x6A07710", VA = "0x186A08710")]
	public static BEEPPNBLOOE JJIFNBOFDBG(JLAJMBIHIJC IPAJBJLLPIJ, int LNCMNOJJHEC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A086A0", Offset = "0x6A076A0", VA = "0x186A086A0")]
	public static BEEPPNBLOOE JBJLDHLCLFG(JLAJMBIHIJC IPAJBJLLPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A08600", Offset = "0x6A07600", VA = "0x186A08600")]
	public static void IJNHMOFGAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OFCDIHFFKKJ : HMMJJAEDOMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int EINEKOCEGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> GJICHNDKNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double HLCLGLDIPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double LHMDJADHHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double IMDANKPELCB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double MHEJGMKIPOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A0BFC0", Offset = "0x6A0AFC0", VA = "0x186A0BFC0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double JIFMHPHELAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1852140", Offset = "0x1851140", VA = "0x181852140", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double GHEEIILMHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D92D30", Offset = "0x1D91D30", VA = "0x181D92D30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C1B0", Offset = "0x6A0B1B0", VA = "0x186A0C1B0")]
	public OFCDIHFFKKJ(int AHIGLGELNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C020", Offset = "0x6A0B020", VA = "0x186A0C020", Slot = "7")]
	public void ECBMHGFFAAH(double GKDIIMKFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C140", Offset = "0x6A0B140", VA = "0x186A0C140", Slot = "8")]
	public void FPNJJPKFGNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class ANEEPEDOFPB : HMMJJAEDOMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long FBDNKGNOEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double KOKFHIKIIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double AJFKFLFIJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double FPNIOJAGMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double BIFNJCKIEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double HLCLGLDIPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double LHMDJADHHAO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double JIFMHPHELAD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5788370", Offset = "0x5787370", VA = "0x185788370", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double GHEEIILMHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5788820", Offset = "0x5787820", VA = "0x185788820", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double POINJCBAKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5788850", Offset = "0x5787850", VA = "0x185788850")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MHEJGMKIPOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2287230", Offset = "0x2286230", VA = "0x182287230", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69F7690", Offset = "0x69F6690", VA = "0x1869F7690", Slot = "7")]
	public virtual void ECBMHGFFAAH(double GKDIIMKFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69F77B0", Offset = "0x69F67B0", VA = "0x1869F77B0", Slot = "8")]
	public virtual void FPNJJPKFGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69F77F0", Offset = "0x69F67F0", VA = "0x1869F77F0")]
	public ANEEPEDOFPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HDOBDAELAMM : ANEEPEDOFPB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double JKMCKPLCONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x57883A0", Offset = "0x57873A0", VA = "0x1857883A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5788830", Offset = "0x5787830", VA = "0x185788830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A02E40", Offset = "0x6A01E40", VA = "0x186A02E40", Slot = "7")]
	public override void ECBMHGFFAAH(double GKDIIMKFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A02F70", Offset = "0x6A01F70", VA = "0x186A02F70", Slot = "8")]
	public override void FPNJJPKFGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69F77F0", Offset = "0x69F67F0", VA = "0x1869F77F0")]
	public HDOBDAELAMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface HMMJJAEDOMH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double MHEJGMKIPOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double JIFMHPHELAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double GHEEIILMHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class DJJINFFNCIE
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface GNOBCEDGPNF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool GKCAFJFMLNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NCCDMBKHFGE();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class PEGHOBGKFDG<TPromise, TMainThreadPromise> : GNOBCEDGPNF where TPromise : NCJNDIGDIHF where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise HMFCNDGHJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise PBKHJDGDIOA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise HOPFPOKEJGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x413E930", Offset = "0x413D930", VA = "0x18413E930")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GKCAFJFMLNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x413E9B0", Offset = "0x413D9B0", VA = "0x18413E9B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C8740", Offset = "0x7C7740", VA = "0x1807C8740")]
		protected PEGHOBGKFDG(TPromise HMFCNDGHJPG, TMainThreadPromise HCPPJHJPMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x413E990", Offset = "0x413D990", VA = "0x18413E990", Slot = "5")]
		public void NCCDMBKHFGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void KEMHPCFPKFG(TPromise HMFCNDGHJPG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class DNEEMNIMLNH<T> : PEGHOBGKFDG<BJNFJNCLHKJ<T>, JAPBMNCECFE<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x50DE570", Offset = "0x50DD570", VA = "0x1850DE570")]
		public DNEEMNIMLNH(BJNFJNCLHKJ<T> HMFCNDGHJPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x50DE3C0", Offset = "0x50DD3C0", VA = "0x1850DE3C0", Slot = "6")]
		protected override void KEMHPCFPKFG(BJNFJNCLHKJ<T> HMFCNDGHJPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3898870", Offset = "0x3897870", VA = "0x183898870")]
		[CompilerGenerated]
		private void FECHKIHFJMI(T HEOGODCLBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x50DE390", Offset = "0x50DD390", VA = "0x1850DE390")]
		[CompilerGenerated]
		private void JOHNPMHNJHH(string AIKAPCCDDEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class JJJGGJCGFEF : GNOBCEDGPNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action DFHNKDINOMO;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GKCAFJFMLNH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
		public JJJGGJCGFEF(Action DFHNKDINOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xC36670", Offset = "0xC35670", VA = "0x180C36670", Slot = "5")]
		public void NCCDMBKHFGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<GNOBCEDGPNF> OIAFEJMMJFI;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x263D800", Offset = "0x263C800", VA = "0x18263D800")]
	public static BJNFJNCLHKJ<T> HJEJOMFNEHF<T>(this BJNFJNCLHKJ<T> HMFCNDGHJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x69FD2E0", Offset = "0x69FC2E0", VA = "0x1869FD2E0")]
	public static void HJEJOMFNEHF(Action DFHNKDINOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x263D740", Offset = "0x263C740", VA = "0x18263D740")]
	private static BJNFJNCLHKJ<T> HADIECOAOHI<T>(BJNFJNCLHKJ<T> HMFCNDGHJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x69FD740", Offset = "0x69FC740", VA = "0x1869FD740")]
	private static void OEADGGHNKGN(GNOBCEDGPNF LFKGMODHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x69FD380", Offset = "0x69FC380", VA = "0x1869FD380")]
	private static void IAAHIAKEJIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x69FD1E0", Offset = "0x69FC1E0", VA = "0x1869FD1E0")]
	private static void ADOCMNPNDOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x69FD660", Offset = "0x69FC660", VA = "0x1869FD660")]
	private static void KLHHBFJNNDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class PCKEOAEGHDH
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct JNNMOFBIGHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> GHDKPEMLGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string KIPEOJGAHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode NIKCCMLOHIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool HJDKBBNGFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6A04E10", Offset = "0x6A03E10", VA = "0x186A04E10")]
		public JNNMOFBIGHO(TaskCompletionSource<Scene> IFEIDNJIJAO, string KIPEOJGAHCM, LoadSceneMode NIKCCMLOHIM, bool HJDKBBNGFEG, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct EIDDDHDIKOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private MFEMJMGOOCM<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69FEB10", Offset = "0x69FDB10", VA = "0x1869FEB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69FF3B0", Offset = "0x69FE3B0", VA = "0x1869FF3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct DGANMLBIBAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69FCE60", Offset = "0x69FBE60", VA = "0x1869FCE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69FD180", Offset = "0x69FC180", VA = "0x1869FD180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct DKBIHEMBNKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private JNNMOFBIGHO <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x69FD9E0", Offset = "0x69FC9E0", VA = "0x1869FD9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x69FDD90", Offset = "0x69FCD90", VA = "0x1869FDD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class LAENICAHCAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JAPBMNCECFE<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LAENICAHCAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6A07D70", Offset = "0x6A06D70", VA = "0x186A07D70")]
		internal void OCKNPDPDPEN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct PLINHFFBJJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private LAENICAHCAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A11390", Offset = "0x6A10390", VA = "0x186A11390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A11F30", Offset = "0x6A10F30", VA = "0x186A11F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct APCMPJOKNNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x69F7820", Offset = "0x69F6820", VA = "0x1869F7820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x69F7D30", Offset = "0x69F6D30", VA = "0x1869F7D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct JFOIBHDKBAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6A04110", Offset = "0x6A03110", VA = "0x186A04110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6A04C60", Offset = "0x6A03C60", VA = "0x186A04C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class BPNFDOHKNCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public BPNFDOHKNCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x69F8A70", Offset = "0x69F7A70", VA = "0x1869F8A70")]
		internal bool CGPGFPMOLMB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CLFFPHGJIGE : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public KEPNMKDFAKI onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public CLFFPHGJIGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x69F9170", Offset = "0x69F8170", VA = "0x1869F9170", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x69F8DE0", Offset = "0x69F7DE0", VA = "0x1869F8DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69F8D90", Offset = "0x69F7D90", VA = "0x1869F8D90")]
		private void GFMFCNEFFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x69F9120", Offset = "0x69F8120", VA = "0x1869F9120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class HBLDIAHPIAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public JAPBMNCECFE<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HBLDIAHPIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A01FA0", Offset = "0x6A00FA0", VA = "0x186A01FA0")]
		internal bool JLIKMFFIIGJ(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A02020", Offset = "0x6A01020", VA = "0x186A02020")]
		internal void PJKHLJDHHAP(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class GLBBFPBJNDE : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public JAPBMNCECFE<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private HBLDIAHPIAF <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public GLBBFPBJNDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A01640", Offset = "0x6A00640", VA = "0x186A01640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A01D50", Offset = "0x6A00D50", VA = "0x186A01D50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> BHKIOPENPML;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static NCJNDIGDIHF POABAGEKBEO;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation BOFCOJAFEPP;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static NCJNDIGDIHF HOCEPHAOFPP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string JCOICDGOMHB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority HCDHMMKIEND;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task NOAPIKLMKNG;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> DPAPHKMDAEO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<JNNMOFBIGHO> NFOCEIMGKOO;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task KFBPDMHABGB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool EHDBKFHABPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A10180", Offset = "0x6A0F180", VA = "0x186A10180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool DAJABKIJAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A10CF0", Offset = "0x6A0FCF0", VA = "0x186A10CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool EBFLBBPFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A0FA80", Offset = "0x6A0EA80", VA = "0x186A0FA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool JIJADHFFOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A0FD30", Offset = "0x6A0ED30", VA = "0x186A0FD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> CKPDNADGMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6A103A0", Offset = "0x6A0F3A0", VA = "0x186A103A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A104B0", Offset = "0x6A0F4B0", VA = "0x186A104B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A109E0", Offset = "0x6A0F9E0", VA = "0x186A109E0")]
	[CLABBHPJDBB(GLDCPGEPGFO.EnteredEditModeNextFrame, 0)]
	private static void HMFEPPCINNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6A10890", Offset = "0x6A0F890", VA = "0x186A10890")]
	[AsyncStateMachine(typeof(EIDDDHDIKOA))]
	public static Task<Scene> HFOAPFLHDEO(string KIPEOJGAHCM, LoadSceneMode NIKCCMLOHIM = LoadSceneMode.Single, bool HJDKBBNGFEG = false, [Optional] MFEMJMGOOCM<string>.ENJHCLDNEDD HGLEDHEBKED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6A10C40", Offset = "0x6A0FC40", VA = "0x186A10C40")]
	[AsyncStateMachine(typeof(DGANMLBIBAA))]
	private static Task KJLIAPFJEDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A10D90", Offset = "0x6A0FD90", VA = "0x186A10D90")]
	[AsyncStateMachine(typeof(DKBIHEMBNKO))]
	private static Task OFGEIAPHIIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FED0", Offset = "0x6A0EED0", VA = "0x186A0FED0")]
	[AsyncStateMachine(typeof(PLINHFFBJJL))]
	private static Task<Scene> FHMOILDGJEM(string KIPEOJGAHCM, LoadSceneMode NIKCCMLOHIM, bool HJDKBBNGFEG, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A10020", Offset = "0x6A0F020", VA = "0x186A10020")]
	private static void FLHIBGGPJGA(SceneInstance LMOHAHGFEGM, LoadSceneMode NIKCCMLOHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A10B80", Offset = "0x6A0FB80", VA = "0x186A10B80")]
	private static void IJHGAAEOFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A11080", Offset = "0x6A10080", VA = "0x186A11080")]
	[AsyncStateMachine(typeof(APCMPJOKNNL))]
	private static Task<Scene> PBBCKEAGAIG(string KIPEOJGAHCM, LoadSceneMode NIKCCMLOHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A10F90", Offset = "0x6A0FF90", VA = "0x186A10F90")]
	private static bool OMMPNKBOAHD(string KIPEOJGAHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FDC0", Offset = "0x6A0EDC0", VA = "0x186A0FDC0")]
	[AsyncStateMachine(typeof(JFOIBHDKBAM))]
	private static Task<Scene> ELAELKBLJAI(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FB20", Offset = "0x6A0EB20", VA = "0x186A0FB20")]
	public static BJNFJNCLHKJ<Scene> BKPNFPOLCBI(string KIPEOJGAHCM, LoadSceneMode NIKCCMLOHIM = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A105C0", Offset = "0x6A0F5C0", VA = "0x186A105C0")]
	public static NCJNDIGDIHF HDHJGCAINGE(string KIPEOJGAHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FCA0", Offset = "0x6A0ECA0", VA = "0x186A0FCA0")]
	[IteratorStateMachine(typeof(CLFFPHGJIGE))]
	private static IEnumerator<LLCDBDMNGNA> CBFAEDPMLGD(string KIPEOJGAHCM, KEPNMKDFAKI BBGKHJJBGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A10AE0", Offset = "0x6A0FAE0", VA = "0x186A10AE0")]
	[IteratorStateMachine(typeof(GLBBFPBJNDE))]
	private static IEnumerator<LLCDBDMNGNA> IEBMFKNPLNL(string KIPEOJGAHCM, LoadSceneMode NIKCCMLOHIM, JAPBMNCECFE<Scene> BBGKHJJBGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A10E60", Offset = "0x6A0FE60", VA = "0x186A10E60")]
	public static bool OFPOHGEJLPI([Out] string OJEKHBPMNGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BKKKDPEODLB
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x69F8820", Offset = "0x69F7820", VA = "0x1869F8820")]
	public static IDisposable AGHNBLBALJI(this JGBKCLEEHBD LNLKAOCIPJI, float JFIIHOFGBPG, Action<float> JBFMHMOENBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x69F88B0", Offset = "0x69F78B0", VA = "0x1869F88B0")]
	public static IDisposable FIHJFHKEBEO(this JGBKCLEEHBD LNLKAOCIPJI, Action<float> JBFMHMOENBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x69F8930", Offset = "0x69F7930", VA = "0x1869F8930")]
	public static IDisposable FNEFHHOLFCB(this JGBKCLEEHBD LNLKAOCIPJI, Action<float> JBFMHMOENBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HCKCAOLELJO
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A02C60", Offset = "0x6A01C60", VA = "0x186A02C60")]
	public static IDisposable OEHBMFAPENE(this MonoBehaviour KPAJOCMGNFG, Action JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A02BD0", Offset = "0x6A01BD0", VA = "0x186A02BD0")]
	public static IDisposable OEHBMFAPENE(this MonoBehaviour KPAJOCMGNFG, Action<float> JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A024C0", Offset = "0x6A014C0", VA = "0x186A024C0")]
	public static IDisposable EKOOOFBJPAE(this MonoBehaviour KPAJOCMGNFG, Action JBFMHMOENBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A02AD0", Offset = "0x6A01AD0", VA = "0x186A02AD0")]
	public static IDisposable NKNAKIMNIHM(this MonoBehaviour KPAJOCMGNFG, Action JBFMHMOENBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A02B50", Offset = "0x6A01B50", VA = "0x186A02B50")]
	public static IDisposable NKNAKIMNIHM(this MonoBehaviour KPAJOCMGNFG, Action<float> JBFMHMOENBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A022A0", Offset = "0x6A012A0", VA = "0x186A022A0")]
	public static IDisposable CDGBILPFIDL(this MonoBehaviour KPAJOCMGNFG, Action JBFMHMOENBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A023C0", Offset = "0x6A013C0", VA = "0x186A023C0")]
	public static IDisposable CJFNILAJDNM(this MonoBehaviour KPAJOCMGNFG, Action JBFMHMOENBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A02440", Offset = "0x6A01440", VA = "0x186A02440")]
	public static IDisposable EHAODBFOAJE(this MonoBehaviour KPAJOCMGNFG, Action JBFMHMOENBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A02980", Offset = "0x6A01980", VA = "0x186A02980")]
	public static IDisposable MANJNFOJPLO(this MonoBehaviour KPAJOCMGNFG, float JFIIHOFGBPG, Action<float> JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP, bool FGBHINHMGBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A02540", Offset = "0x6A01540", VA = "0x186A02540")]
	public static IDisposable FPKIHKOHHMI(this MonoBehaviour KPAJOCMGNFG, float JFIIHOFGBPG, Action<float> JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP, bool FGBHINHMGBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A02840", Offset = "0x6A01840", VA = "0x186A02840")]
	public static IDisposable LAFAOPHMJHD(this MonoBehaviour KPAJOCMGNFG, float JFIIHOFGBPG, Action<float> JBFMHMOENBN, bool FGBHINHMGBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A02660", Offset = "0x6A01660", VA = "0x186A02660")]
	public static IDisposable IMJLKFHLGDB(this MonoBehaviour KPAJOCMGNFG, Action<float> JBFMHMOENBN, bool FGBHINHMGBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A028E0", Offset = "0x6A018E0", VA = "0x186A028E0")]
	public static IDisposable LIHGHLMDAPC(this MonoBehaviour KPAJOCMGNFG, Action<float> JBFMHMOENBN, bool FGBHINHMGBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A02CF0", Offset = "0x6A01CF0", VA = "0x186A02CF0")]
	public static IDisposable OHCHELOILEM(this MonoBehaviour KPAJOCMGNFG, Action<float> JBFMHMOENBN, bool FGBHINHMGBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A02A30", Offset = "0x6A01A30", VA = "0x186A02A30")]
	public static IDisposable MEBGLDEJOEE(this MonoBehaviour KPAJOCMGNFG, Action<float> JBFMHMOENBN, bool FGBHINHMGBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A02700", Offset = "0x6A01700", VA = "0x186A02700")]
	public static IDisposable JBLNNLDDEBF(this MonoBehaviour KPAJOCMGNFG, Action<float> JBFMHMOENBN, bool FGBHINHMGBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A02320", Offset = "0x6A01320", VA = "0x186A02320")]
	public static IDisposable CIOMDCJNMFL(this MonoBehaviour KPAJOCMGNFG, Action<float> JBFMHMOENBN, bool FGBHINHMGBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A027A0", Offset = "0x6A017A0", VA = "0x186A027A0")]
	public static IDisposable KAKGGNKAHPG(this MonoBehaviour KPAJOCMGNFG, Action<float> JBFMHMOENBN, bool FGBHINHMGBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A02D90", Offset = "0x6A01D90", VA = "0x186A02D90")]
	public static IDisposable OPJFMOHPPKC(this MonoBehaviour KPAJOCMGNFG, float JFIIHOFGBPG, Action<float> JBFMHMOENBN, bool FGBHINHMGBN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class JFMGHJCOEGK
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class JCAHJELDNIO : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public GJHALJDEOIN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private GGNBAGEBEPB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public JCAHJELDNIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6A03C30", Offset = "0x6A02C30", VA = "0x186A03C30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6A03D10", Offset = "0x6A02D10", VA = "0x186A03D10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JLKJHDMBHIJ : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public GJHALJDEOIN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private GGNBAGEBEPB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public JLKJHDMBHIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6A04CD0", Offset = "0x6A03CD0", VA = "0x186A04CD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6A04DC0", Offset = "0x6A03DC0", VA = "0x186A04DC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A04060", Offset = "0x6A03060", VA = "0x186A04060")]
	public static NEPNIBLDPPD OEHBMFAPENE(Action JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A03E80", Offset = "0x6A02E80", VA = "0x186A03E80")]
	public static NEPNIBLDPPD OEHBMFAPENE(Behaviour LNLKAOCIPJI, Action JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A03F40", Offset = "0x6A02F40", VA = "0x186A03F40")]
	public static NEPNIBLDPPD OEHBMFAPENE(Behaviour LNLKAOCIPJI, Action<float> JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A03D60", Offset = "0x6A02D60", VA = "0x186A03D60")]
	[IteratorStateMachine(typeof(JCAHJELDNIO))]
	private static IEnumerator<LLCDBDMNGNA> IEGBKFIDCND(GJHALJDEOIN IHNCPPBNACB, Action JBFMHMOENBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A03DF0", Offset = "0x6A02DF0", VA = "0x186A03DF0")]
	[IteratorStateMachine(typeof(JLKJHDMBHIJ))]
	private static IEnumerator<LLCDBDMNGNA> IEGBKFIDCND(GJHALJDEOIN IHNCPPBNACB, Action<float> JBFMHMOENBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class GKONICNOGDN : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class POMONMNENPM : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GKONICNOGDN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public POMONMNENPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A12280", Offset = "0x6A11280", VA = "0x186A12280", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A12310", Offset = "0x6A11310", VA = "0x186A12310", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly GJHALJDEOIN OJDDAKICHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action JDCDAEAFOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool FFNKGJNGHAO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GFGNILMDJGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC460", Offset = "0x7BB460", VA = "0x1807BC460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A01360", Offset = "0x6A00360", VA = "0x186A01360")]
	public GKONICNOGDN(GJHALJDEOIN OJDDAKICHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A01240", Offset = "0x6A00240", VA = "0x186A01240")]
	[IteratorStateMachine(typeof(POMONMNENPM))]
	private IEnumerator<LLCDBDMNGNA> JDKDJMIOPOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6A012C0", Offset = "0x6A002C0", VA = "0x186A012C0", Slot = "4")]
	public void OnCompleted(Action HNDABBDLJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
	public void ENMLFHFCKHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class MEKGAPNODDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A08D80", Offset = "0x6A07D80", VA = "0x186A08D80")]
	public static GKONICNOGDN FLAMAHAJCAD(this GJHALJDEOIN OJDDAKICHAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class NJBBEMKJHME
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class AGIDGPCIPOG : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public BGJEIJLHAMP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public AGIDGPCIPOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x69F75C0", Offset = "0x69F65C0", VA = "0x1869F75C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x69F7640", Offset = "0x69F6640", VA = "0x1869F7640", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A0AC90", Offset = "0x6A09C90", VA = "0x186A0AC90")]
	public static NEPNIBLDPPD OEHBMFAPENE(float JFIIHOFGBPG, Action<float> JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP, bool FGBHINHMGBN = true, [Optional] DCJBLDBBBEG BMHKGLLFHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A0AB80", Offset = "0x6A09B80", VA = "0x186A0AB80")]
	public static NEPNIBLDPPD OEHBMFAPENE(MonoBehaviour KPAJOCMGNFG, float JFIIHOFGBPG, Action<float> JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP, bool FGBHINHMGBN = true, [Optional] DCJBLDBBBEG BMHKGLLFHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A0AA60", Offset = "0x6A09A60", VA = "0x186A0AA60")]
	public static NEPNIBLDPPD OCFGAOJJPGJ(MonoBehaviour KPAJOCMGNFG, float JFIIHOFGBPG, Action<float> JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP, bool FGBHINHMGBN = true, [Optional] DCJBLDBBBEG BMHKGLLFHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A0A7A0", Offset = "0x6A097A0", VA = "0x186A0A7A0")]
	public static NEPNIBLDPPD BLCNIPBAMIE(JGBKCLEEHBD LNLKAOCIPJI, float JFIIHOFGBPG, Action<float> JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP, bool FGBHINHMGBN = true, [Optional] DCJBLDBBBEG BMHKGLLFHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A0A910", Offset = "0x6A09910", VA = "0x186A0A910")]
	private static IEnumerator<LLCDBDMNGNA> IEGBKFIDCND(IOEMAFOJPNF BOCHBLLGPAE, float JFIIHOFGBPG, GJHALJDEOIN IHNCPPBNACB, Action<float> JBFMHMOENBN, bool FGBHINHMGBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6A0A8B0", Offset = "0x6A098B0", VA = "0x186A0A8B0")]
	private static IEnumerator<LLCDBDMNGNA> HGJAGFJMFLO(IOEMAFOJPNF BOCHBLLGPAE, float JFIIHOFGBPG, GJHALJDEOIN IHNCPPBNACB, Action<float> JBFMHMOENBN, bool FGBHINHMGBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A0A9D0", Offset = "0x6A099D0", VA = "0x186A0A9D0")]
	[IteratorStateMachine(typeof(AGIDGPCIPOG))]
	private static IEnumerator<LLCDBDMNGNA> NHPCHIANIBL(BGJEIJLHAMP HLMNHCPPPHJ, float JFIIHOFGBPG, GJHALJDEOIN IHNCPPBNACB, Action<float> JBFMHMOENBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class BEFAMHEAEBM
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class ENDJGNLFBLG : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public GJHALJDEOIN queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public ENDJGNLFBLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x69FF620", Offset = "0x69FE620", VA = "0x1869FF620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x69FF6E0", Offset = "0x69FE6E0", VA = "0x1869FF6E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x69F8470", Offset = "0x69F7470", VA = "0x1869F8470")]
	[IteratorStateMachine(typeof(ENDJGNLFBLG))]
	private static IEnumerator<LLCDBDMNGNA> AFDPDCNICNM(GJHALJDEOIN OJDDAKICHAP, Func<bool> FPEAEOGHFOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x69F8500", Offset = "0x69F7500", VA = "0x1869F8500")]
	public static NEPNIBLDPPD GDNELFNIBKK(this MonoBehaviour KPAJOCMGNFG, Func<bool> FPEAEOGHFOG, GJHALJDEOIN OJDDAKICHAP = GJHALJDEOIN.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class OIPKJOJPOJE
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class KKPCPLCMDPE : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public GJHALJDEOIN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public KKPCPLCMDPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6A07860", Offset = "0x6A06860", VA = "0x186A07860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6A078D0", Offset = "0x6A068D0", VA = "0x186A078D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class PNPKFLAGKBI : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public GJHALJDEOIN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private LLCDBDMNGNA <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public PNPKFLAGKBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6A121A0", Offset = "0x6A111A0", VA = "0x186A121A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6A12230", Offset = "0x6A11230", VA = "0x186A12230", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DA50", Offset = "0x6A0CA50", VA = "0x186A0DA50")]
	[IteratorStateMachine(typeof(KKPCPLCMDPE))]
	private static IEnumerator<LLCDBDMNGNA> JDKDJMIOPOJ(float KMADAIPOJJD, GJHALJDEOIN IHNCPPBNACB, Action MNLLJIAJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DE40", Offset = "0x6A0CE40", VA = "0x186A0DE40")]
	[IteratorStateMachine(typeof(PNPKFLAGKBI))]
	private static IEnumerator<LLCDBDMNGNA> OCCKGMFDILD(float KMADAIPOJJD, GJHALJDEOIN IHNCPPBNACB, Action MNLLJIAJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DBF0", Offset = "0x6A0CBF0", VA = "0x186A0DBF0")]
	public static IDisposable LMBHDJFCMEB(this MonoBehaviour KPAJOCMGNFG, float KMADAIPOJJD, Action MNLLJIAJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D790", Offset = "0x6A0C790", VA = "0x186A0D790")]
	public static NEPNIBLDPPD CFIABBKMBLA(this MonoBehaviour KPAJOCMGNFG, float KMADAIPOJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DD10", Offset = "0x6A0CD10", VA = "0x186A0DD10")]
	public static NEPNIBLDPPD LMBHDJFCMEB(this MonoBehaviour KPAJOCMGNFG, float KMADAIPOJJD, GJHALJDEOIN IHNCPPBNACB, Action MNLLJIAJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DAF0", Offset = "0x6A0CAF0", VA = "0x186A0DAF0")]
	public static NEPNIBLDPPD JEBAILOMDLF(this MonoBehaviour KPAJOCMGNFG, Action MNLLJIAJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D950", Offset = "0x6A0C950", VA = "0x186A0D950")]
	public static NEPNIBLDPPD FODGLEOLJJF(this MonoBehaviour KPAJOCMGNFG, Action MNLLJIAJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DB10", Offset = "0x6A0CB10", VA = "0x186A0DB10")]
	public static NEPNIBLDPPD LFHOIDBDJEJ(this MonoBehaviour KPAJOCMGNFG, Action MNLLJIAJFCN, [Optional] DCJBLDBBBEG BMHKGLLFHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D920", Offset = "0x6A0C920", VA = "0x186A0D920")]
	public static NEPNIBLDPPD DIPMOBFGGBI(this MonoBehaviour KPAJOCMGNFG, Action MNLLJIAJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D690", Offset = "0x6A0C690", VA = "0x186A0D690")]
	public static NEPNIBLDPPD BDPAKABJDLN(this MonoBehaviour KPAJOCMGNFG, Action MNLLJIAJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DEE0", Offset = "0x6A0CEE0", VA = "0x186A0DEE0")]
	private static NEPNIBLDPPD OLPFFGDBGMF(MonoBehaviour KPAJOCMGNFG, GJHALJDEOIN OJDDAKICHAP, Action MNLLJIAJFCN, [Optional] DCJBLDBBBEG BMHKGLLFHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D850", Offset = "0x6A0C850", VA = "0x186A0D850")]
	public static NEPNIBLDPPD CHKFIOBFOKB(this MonoBehaviour KPAJOCMGNFG, float BKKDCMMLJJD, Action MNLLJIAJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D980", Offset = "0x6A0C980", VA = "0x186A0D980")]
	public static NEPNIBLDPPD GACKOFHEOAH(this MonoBehaviour KPAJOCMGNFG, float BKKDCMMLJJD, Action MNLLJIAJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D6C0", Offset = "0x6A0C6C0", VA = "0x186A0D6C0")]
	public static NEPNIBLDPPD BIKMNJKJLNN(this MonoBehaviour KPAJOCMGNFG, float BKKDCMMLJJD, Action MNLLJIAJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DFB0", Offset = "0x6A0CFB0", VA = "0x186A0DFB0")]
	public static NEPNIBLDPPD PEONCNMDAMI(this MonoBehaviour KPAJOCMGNFG, float BKKDCMMLJJD, Action MNLLJIAJFCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GKAKBEFLPPG : JOIHIAALOJC, IEnumerable<JOIHIAALOJC>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<JOIHIAALOJC> BLNFMIAFCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool DKFFLBCEPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action HFJJCFLLNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool PNLKPPIDDPM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NMOBEJMDFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6A008F0", Offset = "0x69FF8F0", VA = "0x186A008F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JKMIKEHAMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6A00DE0", Offset = "0x69FFDE0", VA = "0x186A00DE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6A00A30", Offset = "0x69FFA30", VA = "0x186A00A30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6A011A0", Offset = "0x6A001A0", VA = "0x186A011A0")]
	public GKAKBEFLPPG([Optional] Action HFJJCFLLNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6A00AD0", Offset = "0x69FFAD0", VA = "0x186A00AD0")]
	public void EMJMPPLJJNE(JOIHIAALOJC LKBELOKNFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6A00C80", Offset = "0x69FFC80", VA = "0x186A00C80")]
	private void IMPKIHDLNPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6A01190", Offset = "0x6A00190", VA = "0x186A01190", Slot = "7")]
	public bool OLEAEFGMJAJ(bool GCPGMMGNKLP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6A00E80", Offset = "0x69FFE80", VA = "0x186A00E80", Slot = "8")]
	public bool OLEAEFGMJAJ(Action DFHNKDINOMO, bool GCPGMMGNKLP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6A00C00", Offset = "0x69FFC00", VA = "0x186A00C00", Slot = "9")]
	public IEnumerator<JOIHIAALOJC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6A00C00", Offset = "0x69FFC00", VA = "0x186A00C00", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BAPOBBPACLE : GBPLMOCEAPP
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class KNMACFMLFCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public BAPOBBPACLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public KNMACFMLFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6A07D40", Offset = "0x6A06D40", VA = "0x186A07D40")]
		internal void HAIFENAOBEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class NLDAIIJKIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public BAPOBBPACLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public NLDAIIJKIJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6A07D40", Offset = "0x6A06D40", VA = "0x186A07D40")]
		internal void NGFFBBFHEOI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float BDADAJIAKCP;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x69F7FC0", Offset = "0x69F6FC0", VA = "0x1869F7FC0")]
	public BAPOBBPACLE(Behaviour LNLKAOCIPJI, float BDADAJIAKCP, [Optional] Action HFJJCFLLNAM, [Optional] DCJBLDBBBEG BMHKGLLFHAI, [Optional] IOEMAFOJPNF BOCHBLLGPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x69F7DA0", Offset = "0x69F6DA0", VA = "0x1869F7DA0", Slot = "9")]
	protected override bool GFKMEHHHHBI(Action DFHNKDINOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x69F7EB0", Offset = "0x69F6EB0", VA = "0x1869F7EB0", Slot = "10")]
	protected override bool MCFBFBMALCJ(Action DFHNKDINOMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface JOIHIAALOJC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool NMOBEJMDFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action JKMIKEHAMNC;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OLEAEFGMJAJ(bool GCPGMMGNKLP = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OLEAEFGMJAJ(Action DFHNKDINOMO, bool GCPGMMGNKLP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class GBPLMOCEAPP : JOIHIAALOJC
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class FCPNMBCKNBH : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public GBPLMOCEAPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public FCPNMBCKNBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x69FF730", Offset = "0x69FE730", VA = "0x1869FF730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x69FF800", Offset = "0x69FE800", VA = "0x1869FF800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour LNLKAOCIPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action HFJJCFLLNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private CKENCMBGPDL MFFFOFFKFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly DCJBLDBBBEG BMHKGLLFHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly IOEMAFOJPNF BOCHBLLGPAE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool NMOBEJMDFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xF9B2A0", Offset = "0xF9A2A0", VA = "0x180F9B2A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action JKMIKEHAMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x69FFA30", Offset = "0x69FEA30", VA = "0x1869FFA30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x69FF8D0", Offset = "0x69FE8D0", VA = "0x1869FF8D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x69FFE80", Offset = "0x69FEE80", VA = "0x1869FFE80")]
	protected GBPLMOCEAPP(Behaviour LNLKAOCIPJI, [Optional] Action HFJJCFLLNAM, [Optional] DCJBLDBBBEG BMHKGLLFHAI, [Optional] IOEMAFOJPNF BOCHBLLGPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x69FFBE0", Offset = "0x69FEBE0", VA = "0x1869FFBE0", Slot = "7")]
	public bool OLEAEFGMJAJ(bool GCPGMMGNKLP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x69FFB80", Offset = "0x69FEB80", VA = "0x1869FFB80", Slot = "8")]
	public bool OLEAEFGMJAJ(Action DFHNKDINOMO, bool GCPGMMGNKLP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GFKMEHHHHBI(Action DFHNKDINOMO);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool MCFBFBMALCJ(Action DFHNKDINOMO);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x69FFB60", Offset = "0x69FEB60", VA = "0x1869FFB60")]
	protected void NOAPEDMANNE(Action DFHNKDINOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x69FFC40", Offset = "0x69FEC40", VA = "0x1869FFC40")]
	protected NCJNDIGDIHF PIGKDNFFGDJ(float HNCJAFFEGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x69FF9B0", Offset = "0x69FE9B0", VA = "0x1869FF9B0")]
	private void GFKMJBJLGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x69FFAD0", Offset = "0x69FEAD0", VA = "0x1869FFAD0")]
	[IteratorStateMachine(typeof(FCPNMBCKNBH))]
	private IEnumerator<LLCDBDMNGNA> JFOFIFPCNDJ(float HNCJAFFEGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x69FF970", Offset = "0x69FE970", VA = "0x1869FF970")]
	[CompilerGenerated]
	private void EOIGIIKBIIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class KLBDOPEKCFO : GBPLMOCEAPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float JCCDBPABGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int MJNMNEFBHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float MALCAHMGBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] PMIEKINMOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int LCFCCGNFDHL;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6A07BA0", Offset = "0x6A06BA0", VA = "0x186A07BA0")]
	public KLBDOPEKCFO(Behaviour LNLKAOCIPJI, float HKMPODFMJPM, int MJNMNEFBHBI, [Optional] Action HFJJCFLLNAM, float MALCAHMGBKN = 0f, [Optional] DCJBLDBBBEG BMHKGLLFHAI, [Optional] IOEMAFOJPNF BOCHBLLGPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "9")]
	protected override bool GFKMEHHHHBI(Action DFHNKDINOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6A079A0", Offset = "0x6A069A0", VA = "0x186A079A0", Slot = "10")]
	protected override bool MCFBFBMALCJ(Action DFHNKDINOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6A07920", Offset = "0x6A06920", VA = "0x186A07920")]
	private void IGHCLNLGBKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HIOGPCHHOKL : GBPLMOCEAPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float BDADAJIAKCP;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x69F7FC0", Offset = "0x69F6FC0", VA = "0x1869F7FC0")]
	public HIOGPCHHOKL(Behaviour LNLKAOCIPJI, float BDADAJIAKCP, [Optional] Action HFJJCFLLNAM, [Optional] DCJBLDBBBEG BMHKGLLFHAI, [Optional] IOEMAFOJPNF BOCHBLLGPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "9")]
	protected override bool GFKMEHHHHBI(Action DFHNKDINOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6A02FB0", Offset = "0x6A01FB0", VA = "0x186A02FB0", Slot = "10")]
	protected override bool MCFBFBMALCJ(Action DFHNKDINOMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class GDBLJMINPLO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class ICJJLJCCLCC : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public ICJJLJCCLCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x69F89B0", Offset = "0x69F79B0", VA = "0x1869F89B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6A035E0", Offset = "0x6A025E0", VA = "0x186A035E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NEPNIBLDPPD NPIIEFFKNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private JGBKCLEEHBD LNLKAOCIPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> ANOICCCBMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private GJHALJDEOIN OJDDAKICHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float JMKBADNHDIP;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6A00510", Offset = "0x69FF510", VA = "0x186A00510")]
	public GDBLJMINPLO(JGBKCLEEHBD LNLKAOCIPJI, float JFIIHOFGBPG, Action<float> JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6A00060", Offset = "0x69FF060", VA = "0x186A00060")]
	private void HGNAOIMCEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6A00200", Offset = "0x69FF200", VA = "0x186A00200")]
	private void KEPHHCPEBDB(string AIKAPCCDDEJ, Action HHCHFHDHFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x69FFFE0", Offset = "0x69FEFE0", VA = "0x1869FFFE0")]
	[IteratorStateMachine(typeof(ICJJLJCCLCC))]
	private IEnumerator<LLCDBDMNGNA> FDBOBOOFAHO(Action HHCHFHDHFCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x69FFF80", Offset = "0x69FEF80", VA = "0x1869FFF80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6A00360", Offset = "0x69FF360", VA = "0x186A00360")]
	[CompilerGenerated]
	private void NNAPGMILPDD(string LPBJFENAMEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class NEGBGDMNEHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BPLODGDIGFA : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public BPLODGDIGFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x69F89B0", Offset = "0x69F79B0", VA = "0x1869F89B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x69F8A20", Offset = "0x69F7A20", VA = "0x1869F8A20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private NEPNIBLDPPD NPIIEFFKNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour KPAJOCMGNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action JBFMHMOENBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> ANOICCCBMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private GJHALJDEOIN OJDDAKICHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float JMKBADNHDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool FGBHINHMGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly DCJBLDBBBEG BMHKGLLFHAI;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0A120", Offset = "0x6A09120", VA = "0x186A0A120")]
	public NEGBGDMNEHB(MonoBehaviour KPAJOCMGNFG, Action JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP, [Optional] DCJBLDBBBEG BMHKGLLFHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0A560", Offset = "0x6A09560", VA = "0x186A0A560")]
	public NEGBGDMNEHB(MonoBehaviour KPAJOCMGNFG, Action<float> JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP, [Optional] DCJBLDBBBEG BMHKGLLFHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6A0A310", Offset = "0x6A09310", VA = "0x186A0A310")]
	public NEGBGDMNEHB(MonoBehaviour KPAJOCMGNFG, float JFIIHOFGBPG, Action<float> JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP, bool FGBHINHMGBN = true, [Optional] DCJBLDBBBEG BMHKGLLFHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x19DC0B0", Offset = "0x19DB0B0", VA = "0x1819DC0B0")]
	private NEGBGDMNEHB(DCJBLDBBBEG BMHKGLLFHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6A09510", Offset = "0x6A08510", VA = "0x186A09510")]
	internal static NEGBGDMNEHB CDPFNGMPOIN(MonoBehaviour KPAJOCMGNFG, float JFIIHOFGBPG, Action<float> JBFMHMOENBN, GJHALJDEOIN OJDDAKICHAP, bool FGBHINHMGBN = true, [Optional] DCJBLDBBBEG BMHKGLLFHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6A09FB0", Offset = "0x6A08FB0", VA = "0x186A09FB0")]
	private void OEHBMFAPENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6A09960", Offset = "0x6A08960", VA = "0x186A09960")]
	private void IKFOGPDHOEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6A097B0", Offset = "0x6A087B0", VA = "0x186A097B0")]
	private void HGNAOIMCEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6A09D60", Offset = "0x6A08D60", VA = "0x186A09D60")]
	private void LLGBCEMGICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6A09B10", Offset = "0x6A08B10", VA = "0x186A09B10")]
	private void KEPHHCPEBDB(string AIKAPCCDDEJ, Action HHCHFHDHFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6A09730", Offset = "0x6A08730", VA = "0x186A09730")]
	[IteratorStateMachine(typeof(BPLODGDIGFA))]
	private IEnumerator<LLCDBDMNGNA> FDBOBOOFAHO(Action HHCHFHDHFCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6A096D0", Offset = "0x6A086D0", VA = "0x186A096D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6A09F20", Offset = "0x6A08F20", VA = "0x186A09F20")]
	[CompilerGenerated]
	private void NEGEEMJEJNH(string LPBJFENAMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6A09C40", Offset = "0x6A08C40", VA = "0x186A09C40")]
	[CompilerGenerated]
	private void KPFHJGNDDBE(string LPBJFENAMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6A09640", Offset = "0x6A08640", VA = "0x186A09640")]
	[CompilerGenerated]
	private void CIFKLDGMDJH(string LPBJFENAMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6A09CD0", Offset = "0x6A08CD0", VA = "0x186A09CD0")]
	[CompilerGenerated]
	private void LGPLLBIAPDJ(string LPBJFENAMEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum MHCCCGEPKLN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal sealed class NJLLKPHIMIM : IOEMAFOJPNF
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float EKBJLCMBDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6A0AD90", Offset = "0x6A09D90", VA = "0x186A0AD90", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float KJEOGMMIHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6A0AE30", Offset = "0x6A09E30", VA = "0x186A0AE30", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double KJAPLOODLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6A0AE10", Offset = "0x6A09E10", VA = "0x186A0AE10", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6A0ADA0", Offset = "0x6A09DA0", VA = "0x186A0ADA0")]
	[KEBGMDILACL(JMIJNHPDBML.None)]
	private static void FKKENIGIKEJ(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	[Preserve]
	internal NJLLKPHIMIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface MBCJMJAJCCI
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEEIDAAKICG(string GCMHJLFFDHO);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLCLCGMEBHM();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface CEJCCGNBJLO
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool EJJDCENODGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool OADHFKJAHMB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class HJOFDKOGPDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public KFGBHKKAMLO HCBENIHNAPG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int EDPEAEGJAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9180", VA = "0x1807BA180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7C8790", Offset = "0x7C7790", VA = "0x1807C8790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6A03160", Offset = "0x6A02160", VA = "0x186A03160")]
	public static LLCDBDMNGNA NKLFLBEENCA(IEnumerator<LLCDBDMNGNA> NCDCMCJPNOM, FLONNNCFDEA PJKMKNHHNFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6A032C0", Offset = "0x6A022C0", VA = "0x186A032C0")]
	public LLCDBDMNGNA NKLFLBEENCA(FLONNNCFDEA[] PEMPNLBPKPP, IEnumerator<LLCDBDMNGNA>[] ALHJDIHCCLB, LLCDBDMNGNA[] OOEIFPENJCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6A02FF0", Offset = "0x6A01FF0", VA = "0x186A02FF0")]
	public void JNBDBBGCBNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6A03380", Offset = "0x6A02380", VA = "0x186A03380")]
	public void NMDMFHBNPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6A03020", Offset = "0x6A02020", VA = "0x186A03020")]
	public void LMIKFLDKBAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6A02FF0", Offset = "0x6A01FF0", VA = "0x186A02FF0")]
	public void CGDBPHNIEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HJOFDKOGPDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class KFGBHKKAMLO
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct EEOPEDKGIID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public HJOFDKOGPDP PCEMBPDLHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public JGBKCLEEHBD GGJOOCNCDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public FLONNNCFDEA FMINFOIDFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<LLCDBDMNGNA> OPDALPNNCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public LLCDBDMNGNA GPFADHIGAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public MHCCCGEPKLN KCJFMIBMONO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct KJCAPAPHIHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public GJHALJDEOIN OFCPNKOOOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<EEOPEDKGIID> KPJMOHKNADE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class LBPJPDGAPJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public FLONNNCFDEA promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public KFGBHKKAMLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public JGBKCLEEHBD context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public HJOFDKOGPDP routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public MHCCCGEPKLN coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public LLCDBDMNGNA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<LLCDBDMNGNA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LBPJPDGAPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A07DD0", Offset = "0x6A06DD0", VA = "0x186A07DD0")]
		internal void EDGCNINOENF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class KGLPDKOALAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public HJOFDKOGPDP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public KFGBHKKAMLO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public KGLPDKOALAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A07820", Offset = "0x6A06820", VA = "0x186A07820")]
		internal void FEHHNMPFOHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class OKMFCABOJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public HJOFDKOGPDP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public KFGBHKKAMLO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public OKMFCABOJIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A0E080", Offset = "0x6A0D080", VA = "0x186A0E080")]
		internal void PKIALHCOCHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DNINDFJEJOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public HJOFDKOGPDP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public KFGBHKKAMLO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DNINDFJEJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x69FDF00", Offset = "0x69FCF00", VA = "0x1869FDF00")]
		internal void CDBJCBGKNIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const MHCCCGEPKLN GOILPHGAFBL = MHCCCGEPKLN.Cancelled | MHCCCGEPKLN.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly GJHALJDEOIN OJDDAKICHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] AFNEAKGJPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<MHCCCGEPKLN> OMNFEHGEFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> JBKAKJOJJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> IAFOENNCHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> ODCJHJKFONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> ADAHEHELOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> NONJMOHDBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> MEMFPNCMIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private HJOFDKOGPDP[] AEEEJBMGDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private FLONNNCFDEA[] PEMPNLBPKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private JGBKCLEEHBD[] NMIPJLBKINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<LLCDBDMNGNA>[] OPHEJNLOEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private LLCDBDMNGNA[] PBLFCIMBBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int OIHHKHFAMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int CCPFDJOINBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int JMKLOAGBDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float GEGBCANCDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private MNIHPFJJPHN EALHNJAMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle GEDPECOMJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<HJOFDKOGPDP> PEDDLPKPMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool EINNEOMNMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> ILPJEAIIJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> FDIMDLPFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool MMGADIFCBMJ;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public KJCAPAPHIHG[] NFNPAIBCJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFF0", Offset = "0x9ADFF0", VA = "0x1809AEFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6A069D0", Offset = "0x6A059D0", VA = "0x186A069D0")]
	private static int HGJMJOOENPI(GJHALJDEOIN OJDDAKICHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6A071D0", Offset = "0x6A061D0", VA = "0x186A071D0")]
	public KFGBHKKAMLO(GJHALJDEOIN OJDDAKICHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6A06FF0", Offset = "0x6A05FF0", VA = "0x186A06FF0")]
	private void PPPMJNEHOJK(int PGLKLFEOEKJ, int OBFNHINFCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6A06040", Offset = "0x6A05040", VA = "0x186A06040")]
	public void DBKHMKBOGCI(JGBKCLEEHBD LNLKAOCIPJI, LLCDBDMNGNA GEGBANNCJEJ, IEnumerator<LLCDBDMNGNA> NCDCMCJPNOM, FLONNNCFDEA PJKMKNHHNFK, [Optional] HJOFDKOGPDP OAJNBPGNJLD, MHCCCGEPKLN DOHKHEGLDCJ = MHCCCGEPKLN.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6A06530", Offset = "0x6A05530", VA = "0x186A06530")]
	public void FLELHNOEKDF(IEnumerable<EEOPEDKGIID> MHNHINNEDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6A05A40", Offset = "0x6A04A40", VA = "0x186A05A40")]
	private EEOPEDKGIID BBAJEHPHPIE(int FKGEJDBINHB)
	{
		return default(EEOPEDKGIID);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6A061C0", Offset = "0x6A051C0", VA = "0x186A061C0")]
	private void DDNMNJILHLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2826AA0", Offset = "0x2825AA0", VA = "0x182826AA0")]
	private static void NDKOIEOIIBD<T>(int FKGEJDBINHB, T[] PLEMAHKFNNL, int BEELDCKKFJL, [Optional] T NLBCJDLPLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2826AF0", Offset = "0x2825AF0", VA = "0x182826AF0")]
	private static void NDKOIEOIIBD<T>(int FKGEJDBINHB, NativeArray<T> PLEMAHKFNNL, int BEELDCKKFJL, [Optional] T NLBCJDLPLMN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6A04E70", Offset = "0x6A03E70", VA = "0x186A04E70")]
	private void ABHEGNJOGME(IEnumerable<EEOPEDKGIID> MHNHINNEDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6A06F30", Offset = "0x6A05F30", VA = "0x186A06F30")]
	private void PMPIIJJKLGO(EEOPEDKGIID IBMIIFONEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A06770", Offset = "0x6A05770", VA = "0x186A06770")]
	private CKBNDDPMLAP GJCAPKOGJMO(int JEPMFCCCPJC)
	{
		return default(CKBNDDPMLAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A06D30", Offset = "0x6A05D30", VA = "0x186A06D30")]
	public void PAIAMKPAKIP(float FKCEECKJIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A06B30", Offset = "0x6A05B30", VA = "0x186A06B30")]
	private void HJEDPHGPGAO(Action ABLMDKMDGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A06BB0", Offset = "0x6A05BB0", VA = "0x186A06BB0")]
	private void JEKDOONGIJH(Action ABLMDKMDGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A05340", Offset = "0x6A04340", VA = "0x186A05340")]
	public void AMKBCJBKHBI(float FKCEECKJIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A06C30", Offset = "0x6A05C30", VA = "0x186A06C30")]
	public void LKNIIEHHNJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A05F10", Offset = "0x6A04F10", VA = "0x186A05F10")]
	public void CGDBPHNIEPC(HJOFDKOGPDP HLMNHCPPPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A05210", Offset = "0x6A04210", VA = "0x186A05210")]
	public void AEFLMCBMAHB(HJOFDKOGPDP HLMNHCPPPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A06A00", Offset = "0x6A05A00", VA = "0x186A06A00")]
	public void HILEPJMKGKG(HJOFDKOGPDP HLMNHCPPPHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DKEKLIAGKEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly DKEKLIAGKEM ECAIHANDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action FMANKJNMHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool HBKBODDFLFH;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public DKEKLIAGKEM(Action FMANKJNMHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6236CB0", Offset = "0x6235CB0", VA = "0x186236CB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface OCCJPPFNKPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T ADACBBLDADO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable IIKJAEENKFI(UnityEngine.Object LNLKAOCIPJI, Action<T> HCALEAACKNA);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface IOGOIPBPLOA<T> : OCCJPPFNKPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T ADACBBLDADO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class AAAPGGECBKE<T> : IOGOIPBPLOA<T>, OCCJPPFNKPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class CBDJDJAPGCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AAAPGGECBKE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public IDIOLBIBBGB<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CBDJDJAPGCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4B8F6F0", Offset = "0x4B8E6F0", VA = "0x184B8F6F0")]
		internal void HHGLHPDPDGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject GGFJKCKNIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<IDIOLBIBBGB<UnityEngine.Object, Action<T>>> NGIKFOMPGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T CHIOOIDFHHP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T ADACBBLDADO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x835210", Offset = "0x834210", VA = "0x180835210", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3706AF0", Offset = "0x3705AF0", VA = "0x183706AF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3707280", Offset = "0x3706280", VA = "0x183707280")]
	private static bool GPECKHICGDL(T ABLMDKMDGNE, T AMHEHNHOGFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3707670", Offset = "0x3706670", VA = "0x183707670")]
	public AAAPGGECBKE(T MNOFIKNJICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3707350", Offset = "0x3706350", VA = "0x183707350", Slot = "6")]
	public IDisposable IIKJAEENKFI(UnityEngine.Object LNLKAOCIPJI, Action<T> HCALEAACKNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3706F20", Offset = "0x3705F20", VA = "0x183706F20")]
	private void COPJCHCDMNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class IACBOJLEEMM : DLIFCOFKFFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly DCJBLDBBBEG BMHKGLLFHAI;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A034C0", Offset = "0x6A024C0", VA = "0x186A034C0")]
	[KEBGMDILACL(JMIJNHPDBML.None)]
	private static void FKKENIGIKEJ(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	[Preserve]
	internal IACBOJLEEMM([CJCLEPGLAOP(null)] DCJBLDBBBEG BMHKGLLFHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A03530", Offset = "0x6A02530", VA = "0x186A03530", Slot = "4")]
	public IDisposable LAFAOPHMJHD(float JFIIHOFGBPG, Action<float> ADABDJONAPD, bool FGBHINHMGBN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class NPAIBKBADLK : OIPKGLJBHNG, DCJBLDBBBEG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private KFGBHKKAMLO[] JDOHMGGIPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private MBCJMJAJCCI LFOHFCBNKJD;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B2C0", Offset = "0x6A0A2C0", VA = "0x186A0B2C0")]
	[KEBGMDILACL(JMIJNHPDBML.None)]
	private static void FKKENIGIKEJ(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A0BA70", Offset = "0x6A0AA70", VA = "0x186A0BA70")]
	[Preserve]
	public NPAIBKBADLK([CJCLEPGLAOP(null)] PPHCMAEKOIM INNLLCFFJDJ, [CJCLEPGLAOP(null)] IOEMAFOJPNF BOCHBLLGPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B940", Offset = "0x6A0A940", VA = "0x186A0B940", Slot = "16")]
	public override NEPNIBLDPPD PKMFKCGAOHL(JGBKCLEEHBD LNLKAOCIPJI, IEnumerator<LLCDBDMNGNA> JKIMBANHILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B330", Offset = "0x6A0A330", VA = "0x186A0B330", Slot = "17")]
	public override void FPNJJPKFGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B010", Offset = "0x6A0A010", VA = "0x186A0B010", Slot = "19")]
	public override void EPMMEDCMCHM(GJHALJDEOIN OJDDAKICHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A0AEA0", Offset = "0x6A09EA0", VA = "0x186A0AEA0", Slot = "18")]
	protected override void EKOOOFBJPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B6E0", Offset = "0x6A0A6E0", VA = "0x186A0B6E0")]
	private KFGBHKKAMLO KFDLJNOLHBP(GJHALJDEOIN IKHOLAJCJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B710", Offset = "0x6A0A710", VA = "0x186A0B710", Slot = "20")]
	internal override EBNPMDLONKM LJDDKKHONKH(IEnumerator<LLCDBDMNGNA> JKIMBANHILA, Behaviour LNLKAOCIPJI, FLONNNCFDEA PJKMKNHHNFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B240", Offset = "0x6A0A240", VA = "0x186A0B240", Slot = "21")]
	internal override OPGEECAFKGN FGHPDPCHALC(GJHALJDEOIN IHNCPPBNACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B5C0", Offset = "0x6A0A5C0", VA = "0x186A0B5C0")]
	private void HGAAHKDFPCA(KFGBHKKAMLO AIHABBCPCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A0AE40", Offset = "0x6A09E40", VA = "0x186A0AE40", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct MNIHPFJJPHN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float LPDOEHKDOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int NNBGCKBCKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> MNDCADAHKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> AAPNBEECBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> KMEPICCAKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<MHCCCGEPKLN> AKKNJCCEPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> AJCKHAHAHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> ADAHEHELOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> IAFOENNCHMK;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A09390", Offset = "0x6A08390", VA = "0x186A09390")]
	public static MNIHPFJJPHN OOGKEDOOOJC(int OHNHOKMLNCD, float FKCEECKJIEI, NativeArray<MHCCCGEPKLN> GJDBJFIIOGO, NativeArray<float> INGFBGNGIFP, NativeArray<int> DKNHIGEKPLJ, NativeArray<int> OFDBJFJBIFJ, NativeArray<int> BLODPNBEGHO, NativeArray<int> AAPNBEECBNG, NativeArray<int> KMEPICCAKOO)
	{
		return default(MNIHPFJJPHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A09070", Offset = "0x6A08070", VA = "0x186A09070", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A09030", Offset = "0x6A08030", VA = "0x186A09030")]
	private bool EJFCEPALAOI(int GCDIELAOHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A093F0", Offset = "0x6A083F0", VA = "0x186A093F0")]
	private void PKLLKLCLPMI(NativeArray<int> AMCKAAAGJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A08EC0", Offset = "0x6A07EC0", VA = "0x186A08EC0")]
	private int BINCNKEAMLG(int GGAOGEHPIOE, int MFLHHKFIJJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A08F60", Offset = "0x6A07F60", VA = "0x186A08F60")]
	private void CNBJJNNBEJH(NativeArray<int> AMCKAAAGJDG, int LGBHNPHKDGI, int HKCCAHKOPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A09150", Offset = "0x6A08150", VA = "0x186A09150")]
	private void JKHLIMJBHCI(NativeArray<int> AMCKAAAGJDG, int PHBEMAHMIGI, int OKBABFJDDGD, int OFNJKLOMCKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class OIPKGLJBHNG : DCJBLDBBBEG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly PPHCMAEKOIM INNLLCFFJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly IOEMAFOJPNF BOCHBLLGPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private OPGEECAFKGN[] MNPIHHHCIGB;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static DCJBLDBBBEG GDAKEGIGEFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A0D150", Offset = "0x6A0C150", VA = "0x186A0D150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool BKDIPLKNCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GJHALJDEOIN KLOGINIAOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9180", VA = "0x1807BA180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GJHALJDEOIN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C8790", Offset = "0x7C7790", VA = "0x1807C8790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IOEMAFOJPNF JEMEOHHJLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public LLCDBDMNGNA EPDHLCHOPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CBB0", Offset = "0x6A0BBB0", VA = "0x186A0CBB0")]
	public static NEPNIBLDPPD JBMHCKGPDFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D1A0", Offset = "0x6A0C1A0", VA = "0x186A0D1A0")]
	[Preserve]
	protected OIPKGLJBHNG([CJCLEPGLAOP(null)] PPHCMAEKOIM INNLLCFFJDJ, [CJCLEPGLAOP(null)] IOEMAFOJPNF BOCHBLLGPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CCE0", Offset = "0x6A0BCE0", VA = "0x186A0CCE0", Slot = "6")]
	public NEPNIBLDPPD OIOCKJJDGEP(IEnumerator<LLCDBDMNGNA> JKIMBANHILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CCF0", Offset = "0x6A0BCF0", VA = "0x186A0CCF0", Slot = "7")]
	public NEPNIBLDPPD OIOCKJJDGEP(Behaviour LNLKAOCIPJI, IEnumerator<LLCDBDMNGNA> JKIMBANHILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract NEPNIBLDPPD PKMFKCGAOHL(JGBKCLEEHBD LNLKAOCIPJI, IEnumerator<LLCDBDMNGNA> JKIMBANHILA);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C7B0", Offset = "0x6A0B7B0", VA = "0x186A0C7B0", Slot = "17")]
	public virtual void FPNJJPKFGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C950", Offset = "0x6A0B950", VA = "0x186A0C950", Slot = "9")]
	public void IOMHHDPBDBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C6C0", Offset = "0x6A0B6C0", VA = "0x186A0C6C0", Slot = "18")]
	protected virtual void EKOOOFBJPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C790", Offset = "0x6A0B790", VA = "0x186A0C790")]
	private void FIHPIFPKNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CCA0", Offset = "0x6A0BCA0", VA = "0x186A0CCA0")]
	private void NFLDEKEIDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CCC0", Offset = "0x6A0BCC0", VA = "0x186A0CCC0")]
	private void NKNAKIMNIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C280", Offset = "0x6A0B280", VA = "0x186A0C280")]
	private void CDGBILPFIDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CB90", Offset = "0x6A0BB90", VA = "0x186A0CB90")]
	private void IPNOPEMBDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C260", Offset = "0x6A0B260", VA = "0x186A0C260")]
	private void ABCFIOAEBFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C770", Offset = "0x6A0B770", VA = "0x186A0C770")]
	private void FHNOMPCBOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C6E0", Offset = "0x6A0B6E0", VA = "0x186A0C6E0", Slot = "19")]
	public virtual void EPMMEDCMCHM(GJHALJDEOIN OJDDAKICHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CF80", Offset = "0x6A0BF80", VA = "0x186A0CF80")]
	private void OOHFECGDEBB(OPGEECAFKGN AIHABBCPCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2030", Offset = "0x1CF1030", VA = "0x181CF2030")]
	private OPGEECAFKGN DFJBBGHEAGO(GJHALJDEOIN IKHOLAJCJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract EBNPMDLONKM LJDDKKHONKH(IEnumerator<LLCDBDMNGNA> JKIMBANHILA, Behaviour KPAJOCMGNFG, FLONNNCFDEA JPNOIGNKPOF);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract OPGEECAFKGN FGHPDPCHALC(GJHALJDEOIN OJDDAKICHAP);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C2A0", Offset = "0x6A0B2A0", VA = "0x186A0C2A0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CC40", Offset = "0x6A0BC40", VA = "0x186A0CC40", Slot = "12")]
	public LLCDBDMNGNA LEIHBIICBNH(GJHALJDEOIN IHNCPPBNACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CEF0", Offset = "0x6A0BEF0", VA = "0x186A0CEF0", Slot = "13")]
	public LLCDBDMNGNA OJHCKIGPBMA(float KMADAIPOJJD, GJHALJDEOIN IHNCPPBNACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C660", Offset = "0x6A0B660", VA = "0x186A0C660", Slot = "14")]
	public LLCDBDMNGNA EAPKLMCCBIO(Func<bool> FPEAEOGHFOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class EBNPMDLONKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly FLONNNCFDEA PJKMKNHHNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly CEJCCGNBJLO LNLKAOCIPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool JJDOPJIOIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string GCMHJLFFDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace APNBGBBNCNA;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<LLCDBDMNGNA> OPDALPNNCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public LLCDBDMNGNA GPFADHIGAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7BC240", Offset = "0x7BB240", VA = "0x1807BC240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool MJOKKAKLNBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x69FE140", Offset = "0x69FD140", VA = "0x1869FE140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool EDDFILCHJII
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8828E0", Offset = "0x8818E0", VA = "0x1808828E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x882A00", Offset = "0x881A00", VA = "0x180882A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x69FDF40", Offset = "0x69FCF40", VA = "0x1869FDF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float GJFEEBOJPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x11135D0", Offset = "0x11125D0", VA = "0x1811135D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5788350", Offset = "0x5787350", VA = "0x185788350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x69FE620", Offset = "0x69FD620", VA = "0x1869FE620")]
	public EBNPMDLONKM(IEnumerator<LLCDBDMNGNA> NCDCMCJPNOM, CEJCCGNBJLO LNLKAOCIPJI, FLONNNCFDEA PJKMKNHHNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x69FE230", Offset = "0x69FD230", VA = "0x1869FE230")]
	public LLCDBDMNGNA NKLFLBEENCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x69FE1C0", Offset = "0x69FD1C0", VA = "0x1869FE1C0")]
	public bool DCHGHCDFLCP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x69FE0F0", Offset = "0x69FD0F0", VA = "0x1869FE0F0")]
	public void CGDBPHNIEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x69FE540", Offset = "0x69FD540", VA = "0x1869FE540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x919D00", Offset = "0x918D00", VA = "0x180919D00")]
	[CompilerGenerated]
	private void MIKGCDAFAAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class FLONNNCFDEA : LDNIGKFDNHI, NEPNIBLDPPD, CKENCMBGPDL, NCJNDIGDIHF, IEnumerator, LLCDBDMNGNA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private GJHALJDEOIN NIPGCPDMCJH;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private GJHALJDEOIN ODEDHMPKHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xEAC0E0", Offset = "0xEAB0E0", VA = "0x180EAC0E0", Slot = "23")]
		get
		{
			return default(GJHALJDEOIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public GJHALJDEOIN HCBENIHNAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x139B4D0", Offset = "0x139A4D0", VA = "0x18139B4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float DKJKNPJOFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8CCD00", Offset = "0x8CBD00", VA = "0x1808CCD00", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool CMAFJCFKHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x69FF860", Offset = "0x69FE860", VA = "0x1869FF860", Slot = "24")]
	private bool PNCKJOCCBED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x69FF850", Offset = "0x69FE850", VA = "0x1869FF850", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x69FF880", Offset = "0x69FE880", VA = "0x1869FF880")]
	public FLONNNCFDEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum CKBNDDPMLAP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class OPGEECAFKGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum DHLPLFOCBJB
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct EFKEGGPFEKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public GJHALJDEOIN OFCPNKOOOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public DHLPLFOCBJB MLNBHFAKHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<EBNPMDLONKM> IGMIFPAFIHP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly DHLPLFOCBJB[] JAOGIFNIPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly GJHALJDEOIN OJDDAKICHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool CGJEAHPAFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly EBNPMDLONKM[] PBEONLHJDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<EBNPMDLONKM> GKBKNEJLGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> PLEAHLJBFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<EBNPMDLONKM> FJPGLJMDGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> HPIGCMADEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly MBCJMJAJCCI BDKOBIHPNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool MMGADIFCBMJ;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public EFKEGGPFEKP[,] CPCNFNDGAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC230", Offset = "0x7BB230", VA = "0x1807BC230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F5E0", Offset = "0x6A0E5E0", VA = "0x186A0F5E0")]
	public OPGEECAFKGN(GJHALJDEOIN IHNCPPBNACB, MBCJMJAJCCI BDKOBIHPNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E8E0", Offset = "0x6A0D8E0", VA = "0x186A0E8E0")]
	public void HBGOPNGGFIC(EBNPMDLONKM NCDCMCJPNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E340", Offset = "0x6A0D340", VA = "0x186A0E340")]
	public void BILGJNJKECP(IList<EBNPMDLONKM> ALHJDIHCCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E9E0", Offset = "0x6A0D9E0", VA = "0x186A0E9E0")]
	public void HCDFEFKFFPE(IList<EBNPMDLONKM> ALHJDIHCCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E250", Offset = "0x6A0D250", VA = "0x186A0E250")]
	private void AIOKFHAEJLF(EBNPMDLONKM NCDCMCJPNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E0C0", Offset = "0x6A0D0C0", VA = "0x186A0E0C0")]
	private void ADMHJPLHFOO(IList<EBNPMDLONKM> ALHJDIHCCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6A0ECF0", Offset = "0x6A0DCF0", VA = "0x186A0ECF0")]
	private CKBNDDPMLAP IBFKMHMAKNC(EBNPMDLONKM NCDCMCJPNOM)
	{
		return default(CKBNDDPMLAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E770", Offset = "0x6A0D770", VA = "0x186A0E770")]
	public void EKOOOFBJPAE(float FKCEECKJIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6A0EE70", Offset = "0x6A0DE70", VA = "0x186A0EE70")]
	public void IOMHHDPBDBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F1A0", Offset = "0x6A0E1A0", VA = "0x186A0F1A0")]
	private void LPCLCOHMJCM(List<EBNPMDLONKM> ALHJDIHCCLB, Stack<int> INOHBCHDBCD, bool BFJOLNCPJKH, float DECDIENLHNJ = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E650", Offset = "0x6A0D650", VA = "0x186A0E650", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F060", Offset = "0x6A0E060", VA = "0x186A0F060")]
	private void LBOLMLNNCJD(List<EBNPMDLONKM> ALHJDIHCCLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class IBBKHKLEBKE : MBCJMJAJCCI
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "4")]
	public void IEEIDAAKICG(string GCMHJLFFDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
	public void KLCLCGMEBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public IBBKHKLEBKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class NECBIEJCBHM : CEJCCGNBJLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour KPAJOCMGNFG;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6A09420", Offset = "0x6A08420", VA = "0x186A09420", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool EJJDCENODGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6A094A0", Offset = "0x6A084A0", VA = "0x186A094A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool OADHFKJAHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6A094F0", Offset = "0x6A084F0", VA = "0x186A094F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public NECBIEJCBHM(Behaviour KPAJOCMGNFG)
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

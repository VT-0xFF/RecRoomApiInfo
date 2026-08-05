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
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private delegate List<PlayerLoopSystem> GKCKIOBBGPM(List<PlayerLoopSystem> AJEPKEODAPG, int LCNIKFOFDEN);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct DDPBMOILEGP
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct OGOJPDDOOCP
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static BGECMLEGDCD OJKMJBPFKJA;

				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x72A0CF0", Offset = "0x729FCF0", VA = "0x1872A0CF0")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct PJNIEKJKKML
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static BGECMLEGDCD BBPPNPAHDEE;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x72A1850", Offset = "0x72A0850", VA = "0x1872A1850")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct JJOHMKJJIMA
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static BGECMLEGDCD CCEJMMCIFLB;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x729A0C0", Offset = "0x72990C0", VA = "0x18729A0C0")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct KDAEEBKHNLC
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static BGECMLEGDCD FDLHJGAGJDK;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static BGECMLEGDCD LDOBDLMJFBG;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static BGECMLEGDCD IFPIAADOAMP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static BGECMLEGDCD EAGKAGJKOAF;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x729B500", Offset = "0x729A500", VA = "0x18729B500")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct GIILLKOMDPF
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static BGECMLEGDCD KAJBBIFFLMJ;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x7298370", Offset = "0x7297370", VA = "0x187298370")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct HEOLDOJOLBA
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static BGECMLEGDCD FDLHJGAGJDK;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static BGECMLEGDCD LDOBDLMJFBG;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static BGECMLEGDCD IFPIAADOAMP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static BGECMLEGDCD EAGKAGJKOAF;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x7298C70", Offset = "0x7297C70", VA = "0x187298C70")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct BMABLIKBGPP
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static BGECMLEGDCD JHLAKLOLGOD;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x72896C0", Offset = "0x72886C0", VA = "0x1872896C0")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct PHMHCLHMJOD
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static BGECMLEGDCD FGGPIOMEFAP;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x72A1450", Offset = "0x72A0450", VA = "0x1872A1450")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct DLHLOHLGDDK
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static BGECMLEGDCD PEJHJECCMLE;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7290160", Offset = "0x728F160", VA = "0x187290160")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct PJGDAJJGFDI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static BGECMLEGDCD BMBCHDLICON;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x72A1650", Offset = "0x72A0650", VA = "0x1872A1650")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct GNHPODOOLGO
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static BGECMLEGDCD PHLGNJJPAMO;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x7298570", Offset = "0x7297570", VA = "0x187298570")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct EPAAOFEELDH
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static BGECMLEGDCD IFMFGMEEGKO;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x7292620", Offset = "0x7291620", VA = "0x187292620")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct JDOPJNFAHLO
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static BGECMLEGDCD NMPLBBNGNOC;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x7299EC0", Offset = "0x7298EC0", VA = "0x187299EC0")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public enum DAOJPEJDGMC : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct EAKMIPFLMOG
			{
				[Cpp2IlInjected.Token(Token = "0x2000021")]
				[CompilerGenerated]
				private sealed class IFEHEADILBM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public DAOJPEJDGMC updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
					public IFEHEADILBM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x7299CE0", Offset = "0x7298CE0", VA = "0x187299CE0")]
					internal void LPNOHAFKBMN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static GFLPBNMBKPD<DAOJPEJDGMC> HELCOKLDHHI;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x72918A0", Offset = "0x72908A0", VA = "0x1872918A0")]
				public static PlayerLoopSystem PBCFKMENFBF(DAOJPEJDGMC CECAGKJACAO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			internal struct KPAJLAKEIPJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				[CompilerGenerated]
				private sealed class BNLDDJGPHGG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public EHAAMOIOJCG.OELPDPJINPB key;

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
					public BNLDDJGPHGG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x72898C0", Offset = "0x72888C0", VA = "0x1872898C0")]
					internal void GKCCJKLFCEA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable MBPLEHGKLIH;

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x729C130", Offset = "0x729B130", VA = "0x18729C130")]
				public static PlayerLoopSystem KMFGIKCBAOP(EHAAMOIOJCG.OELPDPJINPB BHEIPBKEDLG)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000025")]
			internal struct IEJNFPICEHH
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class KKNNCNLKOMI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public EHAAMOIOJCG.OELPDPJINPB key;

					[Cpp2IlInjected.Token(Token = "0x6000056")]
					[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
					public KKNNCNLKOMI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x729BEC0", Offset = "0x729AEC0", VA = "0x18729BEC0")]
					internal void GKCCJKLFCEA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x7299BB0", Offset = "0x7298BB0", VA = "0x187299BB0")]
				public static PlayerLoopSystem KMFGIKCBAOP(EHAAMOIOJCG.OELPDPJINPB BHEIPBKEDLG)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class JAOMALFPOEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public JAOMALFPOEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7299DA0", Offset = "0x7298DA0", VA = "0x187299DA0")]
			internal List<PlayerLoopSystem> OKLKLFLEAHA(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool EMBKLINEMHP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool IOPOGHHEHMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x728FFD0", Offset = "0x728EFD0", VA = "0x18728FFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x728C1C0", Offset = "0x728B1C0", VA = "0x18728C1C0")]
		private static void AAPKOIDOFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x728EFF0", Offset = "0x728DFF0", VA = "0x18728EFF0")]
		private static void CDABOOPJHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x728EDC0", Offset = "0x728DDC0", VA = "0x18728EDC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x728FCE0", Offset = "0x728ECE0", VA = "0x18728FCE0")]
		private static void KMNCKDNEMIE(EHAAMOIOJCG.OELPDPJINPB BHEIPBKEDLG, PlayerLoopSystem FPDJPPIDOHM, Type FCBNHLCFMJE, Type OFAOEFAPCOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x728F900", Offset = "0x728E900", VA = "0x18728F900")]
		private static void JKHOACJELIM(PlayerLoopSystem FPDJPPIDOHM, Type FCBNHLCFMJE, Type OFAOEFAPCOI, GKCKIOBBGPM IBDNCPKJHKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x728FEA0", Offset = "0x728EEA0", VA = "0x18728FEA0")]
		private static void LEOGHBDKFEF(PlayerLoopSystem FPDJPPIDOHM, Type FCBNHLCFMJE, Type OFAOEFAPCOI, PlayerLoopSystem? AGMECHPEEAJ, PlayerLoopSystem? AOOLHMGMNBK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class EHAAMOIOJCG
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum OELPDPJINPB
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		OMPrePhysicsFixedUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JLPCKHLIEGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly OELPDPJINPB HBOIPLNJOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly OPFMEOCPLFB HHNMCOCMJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long DHJLMLEJJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long KFLGCIFBBNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long EBPMLDMIKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int IJAJMEOIGFG;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x729A620", Offset = "0x7299620", VA = "0x18729A620")]
		public JLPCKHLIEGJ(OELPDPJINPB JOCENAKHPEH, int IGGCOPJAIPG = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x729A5B0", Offset = "0x72995B0", VA = "0x18729A5B0")]
		public void OMKKIOKDOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x729A560", Offset = "0x7299560", VA = "0x18729A560")]
		public void CJEOPOGCEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x729A380", Offset = "0x7299380", VA = "0x18729A380")]
		public void AEIDCMEFHGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static OELPDPJINPB[] HJCMFJAMNDD;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static JLPCKHLIEGJ[] AEALFGHBJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7292140", Offset = "0x7291140", VA = "0x187292140")]
	public static JLPCKHLIEGJ HKDKCIEFEPA(OELPDPJINPB BHEIPBKEDLG, int IGGCOPJAIPG = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x72920D0", Offset = "0x72910D0", VA = "0x1872920D0")]
	public static JLPCKHLIEGJ EKADMPBLHMP(OELPDPJINPB BHEIPBKEDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7292320", Offset = "0x7291320", VA = "0x187292320")]
	public static void MHBLFEIPIHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class OPFMEOCPLFB : FIMLCKAOGMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int HJHGJDNLODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> GOCMPDDIEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double MDCIOHOLJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double HGPGLPENOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double LCKHLHABDMM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double JPFGDMBHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72A1040", Offset = "0x72A0040", VA = "0x1872A1040", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double BPNDDICFGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1A69240", Offset = "0x1A68240", VA = "0x181A69240", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double NBAENKBBCBE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1F64090", Offset = "0x1F63090", VA = "0x181F64090", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x72A1230", Offset = "0x72A0230", VA = "0x1872A1230")]
	public OPFMEOCPLFB(int NDPHDLIIMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72A10A0", Offset = "0x72A00A0", VA = "0x1872A10A0", Slot = "7")]
	public void EPIFHDNPJLD(double LECBAKCNNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72A11C0", Offset = "0x72A01C0", VA = "0x1872A11C0", Slot = "8")]
	public void FDHFDDAAOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class ECOHFJBDGKG : FIMLCKAOGMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long JPBPNOCHNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double PHCOIBMANEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double CELKNJABGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double LCFOPHGDDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double GPFCPJGHHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double MDCIOHOLJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double HGPGLPENOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double BPNDDICFGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5F0B5D0", Offset = "0x5F0A5D0", VA = "0x185F0B5D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double NBAENKBBCBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5F0B110", Offset = "0x5F0A110", VA = "0x185F0B110", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double NHMHGGMEBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5F0B610", Offset = "0x5F0A610", VA = "0x185F0B610")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JPFGDMBHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x255E6F0", Offset = "0x255D6F0", VA = "0x18255E6F0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7291F40", Offset = "0x7290F40", VA = "0x187291F40", Slot = "7")]
	public virtual void EPIFHDNPJLD(double LECBAKCNNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7292060", Offset = "0x7291060", VA = "0x187292060", Slot = "8")]
	public virtual void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x72920A0", Offset = "0x72910A0", VA = "0x1872920A0")]
	public ECOHFJBDGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PGDJCELOHGO : ECOHFJBDGKG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double GGJCCCNDEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5F0B120", Offset = "0x5F0A120", VA = "0x185F0B120")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5F0B5E0", Offset = "0x5F0A5E0", VA = "0x185F0B5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72A12E0", Offset = "0x72A02E0", VA = "0x1872A12E0", Slot = "7")]
	public override void EPIFHDNPJLD(double LECBAKCNNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72A1410", Offset = "0x72A0410", VA = "0x1872A1410", Slot = "8")]
	public override void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72920A0", Offset = "0x72910A0", VA = "0x1872920A0")]
	public PGDJCELOHGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface FIMLCKAOGMB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double JPFGDMBHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double BPNDDICFGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double NBAENKBBCBE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class OFOHGDBHOGI
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private interface DJGIJFPMMEH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool KJMGCLPOCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FGFPBCBMJNA();
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private abstract class JNLJNICAFNF<TPromise, TMainThreadPromise> : DJGIJFPMMEH where TPromise : PGILFKJEHOF where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly TPromise OJCCMKIGHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected readonly TMainThreadPromise OPPGAMLBJKK;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise NINOHKJJGAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x412DA90", Offset = "0x412CA90", VA = "0x18412DA90")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KJMGCLPOCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x412DA40", Offset = "0x412CA40", VA = "0x18412DA40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x86A7E0", Offset = "0x8697E0", VA = "0x18086A7E0")]
		protected JNLJNICAFNF(TPromise OJCCMKIGHOA, TMainThreadPromise GPLMCOKJCHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x412DA20", Offset = "0x412CA20", VA = "0x18412DA20", Slot = "5")]
		public void FGFPBCBMJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void PHKDFIGOOJK(TPromise OJCCMKIGHOA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class BDMKMEHHKKN<T> : JNLJNICAFNF<HCGNNEJAOHI<T>, EJMFGCNAEMH<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4E79B90", Offset = "0x4E78B90", VA = "0x184E79B90")]
		public BDMKMEHHKKN(HCGNNEJAOHI<T> OJCCMKIGHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4E799C0", Offset = "0x4E789C0", VA = "0x184E799C0", Slot = "6")]
		protected override void PHKDFIGOOJK(HCGNNEJAOHI<T> OJCCMKIGHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x40A7FA0", Offset = "0x40A6FA0", VA = "0x1840A7FA0")]
		[CompilerGenerated]
		private void ANMCAAMDKBH(T HJBJAPKPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4E79960", Offset = "0x4E78960", VA = "0x184E79960")]
		[CompilerGenerated]
		private void AJBMLHCFOMM(string JCBCIJOKIDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class HCMNJOALLBB : DJGIJFPMMEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Action OGLJLDNLGIJ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool KJMGCLPOCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
		public HCMNJOALLBB(Action OGLJLDNLGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x939DB0", Offset = "0x938DB0", VA = "0x180939DB0", Slot = "5")]
		public void FGFPBCBMJNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<DJGIJFPMMEH> OCLCPLCKKFH;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2CB04C0", Offset = "0x2CAF4C0", VA = "0x182CB04C0")]
	public static HCGNNEJAOHI<T> IAAMLBPALPE<T>(this HCGNNEJAOHI<T> OJCCMKIGHOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x72A02A0", Offset = "0x729F2A0", VA = "0x1872A02A0")]
	public static void IAAMLBPALPE(Action OGLJLDNLGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2CB0540", Offset = "0x2CAF540", VA = "0x182CB0540")]
	private static HCGNNEJAOHI<T> MGOKFJPLNCO<T>(HCGNNEJAOHI<T> OJCCMKIGHOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x729FF90", Offset = "0x729EF90", VA = "0x18729FF90")]
	private static void CBECBACMNMH(DJGIJFPMMEH NGODOBJLIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72A0340", Offset = "0x729F340", VA = "0x1872A0340")]
	private static void JLLMAFKFFHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72A01A0", Offset = "0x729F1A0", VA = "0x1872A01A0")]
	private static void HJPJIEGINIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72A0620", Offset = "0x729F620", VA = "0x1872A0620")]
	private static void PHPELJICGMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class APBAPHEAKLD
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct DONDPCHAJOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public TaskCompletionSource<Scene> BICEGINCAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly string OFICCEEBFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly LoadSceneMode FGBPEJFMNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly bool CANNKNKNGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x72903E0", Offset = "0x728F3E0", VA = "0x1872903E0")]
		public DONDPCHAJOL(TaskCompletionSource<Scene> DOBFIJDMMAG, string OFICCEEBFIG, LoadSceneMode FGBPEJFMNKP, bool CANNKNKNGIL, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct CJCOCACBJPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private DJJFGNEEIPJ<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x728B790", Offset = "0x728A790", VA = "0x18728B790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x728C030", Offset = "0x728B030", VA = "0x18728C030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct BCLEICLKLPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7289200", Offset = "0x7288200", VA = "0x187289200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7289520", Offset = "0x7288520", VA = "0x187289520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct LMOKDKDBBDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private DONDPCHAJOL <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x729C430", Offset = "0x729B430", VA = "0x18729C430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x729C7E0", Offset = "0x729B7E0", VA = "0x18729C7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class OBBEINIICGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public EJMFGCNAEMH<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public OBBEINIICGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x729E570", Offset = "0x729D570", VA = "0x18729E570")]
		internal void DOPCHJABEEB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct NFPPJMNOEAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private OBBEINIICGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x729D120", Offset = "0x729C120", VA = "0x18729D120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x729DCC0", Offset = "0x729CCC0", VA = "0x18729DCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct HILHDHNCMJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7299110", Offset = "0x7298110", VA = "0x187299110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x72995F0", Offset = "0x72985F0", VA = "0x1872995F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct GHEPKJNBJKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72977B0", Offset = "0x72967B0", VA = "0x1872977B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7298300", Offset = "0x7297300", VA = "0x187298300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class ONDKKOCBJHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public ONDKKOCBJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72A1010", Offset = "0x72A0010", VA = "0x1872A1010")]
		internal bool KMEOGMGPCIK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ABPDMCKIGHE : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public NIIIJMDBGHD onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public ABPDMCKIGHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7286890", Offset = "0x7285890", VA = "0x187286890", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72864B0", Offset = "0x72854B0", VA = "0x1872864B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x72867F0", Offset = "0x72857F0", VA = "0x1872867F0")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7286840", Offset = "0x7285840", VA = "0x187286840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class FHLBJOLHAKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public EJMFGCNAEMH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public FHLBJOLHAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7294BE0", Offset = "0x7293BE0", VA = "0x187294BE0")]
		internal bool PPFCDABNEJH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7294960", Offset = "0x7293960", VA = "0x187294960")]
		internal void OOGDEOOEJEA(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class KJFIOCDLMNL : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public EJMFGCNAEMH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private FHLBJOLHAKN <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public KJFIOCDLMNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x729B7F0", Offset = "0x729A7F0", VA = "0x18729B7F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x729BE70", Offset = "0x729AE70", VA = "0x18729BE70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly ICollection<string> LIAMDOGDGLJ;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static PGILFKJEHOF OCLBFKPBJAE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static AsyncOperation CFINLPDJBPD;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static PGILFKJEHOF HCCGGBBNMBN;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static string DEOOBMPKCHL;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static ThreadPriority AILFNBPFAAA;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task PADCFCIBEEA;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static List<SceneInstance> EABBONPHNJC;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Queue<DONDPCHAJOL> EPIEDBDAJJN;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Task MHPCODELGJC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool JFGJOLECIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72887D0", Offset = "0x72877D0", VA = "0x1872887D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool LLNOMEPHHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x72885B0", Offset = "0x72875B0", VA = "0x1872885B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool MDGGNNOILOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7288510", Offset = "0x7287510", VA = "0x187288510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool IGMNCFBOPLM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x72878B0", Offset = "0x72868B0", VA = "0x1872878B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> OKDAKMFEPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x72889F0", Offset = "0x72879F0", VA = "0x1872889F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7288130", Offset = "0x7287130", VA = "0x187288130")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7287C90", Offset = "0x7286C90", VA = "0x187287C90")]
	[OCMIHKDDJOP(HMGNKNOCFNI.EnteredEditModeNextFrame, 0)]
	private static void FJEMOICBOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7287940", Offset = "0x7286940", VA = "0x187287940")]
	[AsyncStateMachine(typeof(CJCOCACBJPE))]
	public static Task<Scene> DEIFCEDCPMN(string OFICCEEBFIG, LoadSceneMode FGBPEJFMNKP = LoadSceneMode.Single, bool CANNKNKNGIL = false, [Optional] DJJFGNEEIPJ<string>.DIJMCCGECOP PHECCPKFBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7287800", Offset = "0x7286800", VA = "0x187287800")]
	[AsyncStateMachine(typeof(BCLEICLKLPB))]
	private static Task AAKOOMJDNKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7287F30", Offset = "0x7286F30", VA = "0x187287F30")]
	[AsyncStateMachine(typeof(LMOKDKDBBDK))]
	private static Task GKNBPFJHPIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7288EC0", Offset = "0x7287EC0", VA = "0x187288EC0")]
	[AsyncStateMachine(typeof(NFPPJMNOEAI))]
	private static Task<Scene> PCLPEOLLJJM(string OFICCEEBFIG, LoadSceneMode FGBPEJFMNKP, bool CANNKNKNGIL, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7287A90", Offset = "0x7286A90", VA = "0x187287A90")]
	private static void EHILOCIDDGP(SceneInstance MGNNEDNHDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7288CC0", Offset = "0x7287CC0", VA = "0x187288CC0")]
	private static void OMBIJFPJIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7288BA0", Offset = "0x7287BA0", VA = "0x187288BA0")]
	[AsyncStateMachine(typeof(HILHDHNCMJI))]
	private static Task<Scene> OILAPFDOPCN(string OFICCEEBFIG, LoadSceneMode FGBPEJFMNKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7287BA0", Offset = "0x7286BA0", VA = "0x187287BA0")]
	private static bool EPIAHKKCBCJ(string OFICCEEBFIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7287D90", Offset = "0x7286D90", VA = "0x187287D90")]
	[AsyncStateMachine(typeof(GHEPKJNBJKJ))]
	private static Task<Scene> GHHKAGLPIKM(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7288650", Offset = "0x7287650", VA = "0x187288650")]
	public static HCGNNEJAOHI<Scene> KGBCBMIMDBA(string OFICCEEBFIG, LoadSceneMode FGBPEJFMNKP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7288240", Offset = "0x7287240", VA = "0x187288240")]
	public static PGILFKJEHOF IMLDODKPCMC(string OFICCEEBFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7287EA0", Offset = "0x7286EA0", VA = "0x187287EA0")]
	[IteratorStateMachine(typeof(ABPDMCKIGHE))]
	private static IEnumerator<MBMMHILCGCA> GKKCFOLMKME(string OFICCEEBFIG, NIIIJMDBGHD LNBLKGGADAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7288B00", Offset = "0x7287B00", VA = "0x187288B00")]
	[IteratorStateMachine(typeof(KJFIOCDLMNL))]
	private static IEnumerator<MBMMHILCGCA> NKHMIGMDKEG(string OFICCEEBFIG, LoadSceneMode FGBPEJFMNKP, EJMFGCNAEMH<Scene> LNBLKGGADAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7288000", Offset = "0x7287000", VA = "0x187288000")]
	public static bool HDGIDNDBLMI([Out] string MJIEMBGJMAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DPNJOIPJMEB
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x72904C0", Offset = "0x728F4C0", VA = "0x1872904C0")]
	public static IDisposable IKNBPIALMPH(this NOMFKNGBIGI FFHIJMOJNAI, float LMENHCIHLHF, Action<float> EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7290440", Offset = "0x728F440", VA = "0x187290440")]
	public static IDisposable IIPHGICCLED(this NOMFKNGBIGI FFHIJMOJNAI, Action<float> EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7290550", Offset = "0x728F550", VA = "0x187290550")]
	public static IDisposable MMHCFCMEIBM(this NOMFKNGBIGI FFHIJMOJNAI, Action<float> EPPBBINIJEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class FEKABHGDNFF
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x72946D0", Offset = "0x72936D0", VA = "0x1872946D0")]
	public static IDisposable OPKCDKIHHBH(this MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7294640", Offset = "0x7293640", VA = "0x187294640")]
	public static IDisposable OPKCDKIHHBH(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x72945C0", Offset = "0x72935C0", VA = "0x1872945C0")]
	public static IDisposable OMKLHJHPBJI(this MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x72944C0", Offset = "0x72934C0", VA = "0x1872944C0")]
	public static IDisposable LKGMHCOOGEP(this MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7294440", Offset = "0x7293440", VA = "0x187294440")]
	public static IDisposable LKGMHCOOGEP(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7293F00", Offset = "0x7292F00", VA = "0x187293F00")]
	public static IDisposable ELGCNFKCKBL(this MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7294540", Offset = "0x7293540", VA = "0x187294540")]
	public static IDisposable MDCDIFHCGNL(this MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7294320", Offset = "0x7293320", VA = "0x187294320")]
	public static IDisposable LBNGEFNPFLH(this MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7294810", Offset = "0x7293810", VA = "0x187294810")]
	public static IDisposable PGODHGIJKLA(this MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x72940C0", Offset = "0x72930C0", VA = "0x1872940C0")]
	public static IDisposable HCLJKCELDLL(this MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7293DC0", Offset = "0x7292DC0", VA = "0x187293DC0")]
	public static IDisposable BFPAACIFPAN(this MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x72943A0", Offset = "0x72933A0", VA = "0x1872943A0")]
	public static IDisposable LFKKINCDHPI(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7294020", Offset = "0x7293020", VA = "0x187294020")]
	public static IDisposable GEADFDNCNJL(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7293E60", Offset = "0x7292E60", VA = "0x187293E60")]
	public static IDisposable EIIJGJFENGC(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7294280", Offset = "0x7293280", VA = "0x187294280")]
	public static IDisposable KDOGPAMIOHK(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7293F80", Offset = "0x7292F80", VA = "0x187293F80")]
	public static IDisposable FJBLBJDLOGG(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72941E0", Offset = "0x72931E0", VA = "0x1872941E0")]
	public static IDisposable IBGDBJEJKGF(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72948C0", Offset = "0x72938C0", VA = "0x1872948C0")]
	public static IDisposable PMINPCAOFIL(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7294760", Offset = "0x7293760", VA = "0x187294760")]
	public static IDisposable PDFCFFBEFGN(this MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class AJGJNAAGGGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JMIFAKBGIML : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public POIAJKHHOFJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private BPGLMBAJKED <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public JMIFAKBGIML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x729A730", Offset = "0x7299730", VA = "0x18729A730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x729A810", Offset = "0x7299810", VA = "0x18729A810", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class AIHDBHABAOC : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public POIAJKHHOFJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private BPGLMBAJKED <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public AIHDBHABAOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7287310", Offset = "0x7286310", VA = "0x187287310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7287400", Offset = "0x7286400", VA = "0x187287400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7287690", Offset = "0x7286690", VA = "0x187287690")]
	public static JMPIHICOHFM OPKCDKIHHBH(Action EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7287740", Offset = "0x7286740", VA = "0x187287740")]
	public static JMPIHICOHFM OPKCDKIHHBH(Behaviour FFHIJMOJNAI, Action EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7287570", Offset = "0x7286570", VA = "0x187287570")]
	public static JMPIHICOHFM OPKCDKIHHBH(Behaviour FFHIJMOJNAI, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7287450", Offset = "0x7286450", VA = "0x187287450")]
	[IteratorStateMachine(typeof(JMIFAKBGIML))]
	private static IEnumerator<MBMMHILCGCA> FEIGFPHKPHJ(POIAJKHHOFJ EOICDCMLDHF, Action EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x72874E0", Offset = "0x72864E0", VA = "0x1872874E0")]
	[IteratorStateMachine(typeof(AIHDBHABAOC))]
	private static IEnumerator<MBMMHILCGCA> FEIGFPHKPHJ(POIAJKHHOFJ EOICDCMLDHF, Action<float> EPPBBINIJEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class HMDBLBJKOJC : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class LCDMNFBDOII : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public HMDBLBJKOJC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public LCDMNFBDOII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x729C260", Offset = "0x729B260", VA = "0x18729C260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x729C2F0", Offset = "0x729B2F0", VA = "0x18729C2F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly POIAJKHHOFJ ABGODCJAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Action MDECHCNAONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool GCGPNMHEIJB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EJHJFDECFOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86FCF0", Offset = "0x86ECF0", VA = "0x18086FCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7299780", Offset = "0x7298780", VA = "0x187299780")]
	public HMDBLBJKOJC(POIAJKHHOFJ ABGODCJAPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7299660", Offset = "0x7298660", VA = "0x187299660")]
	[IteratorStateMachine(typeof(LCDMNFBDOII))]
	private IEnumerator<MBMMHILCGCA> APAEACBLEAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x72996E0", Offset = "0x72986E0", VA = "0x1872996E0", Slot = "4")]
	public void OnCompleted(Action HGHEBPNBGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	public void JNNMANEJCPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class FNMJONPAPPO
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7294C60", Offset = "0x7293C60", VA = "0x187294C60")]
	public static HMDBLBJKOJC GCIDINGPBLA(this POIAJKHHOFJ ABGODCJAPHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class JONHGJIAFFP
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class NOJHEMDOGIC : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public FBGBCEGFILK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public NOJHEMDOGIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x729E4A0", Offset = "0x729D4A0", VA = "0x18729E4A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x729E520", Offset = "0x729D520", VA = "0x18729E520", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x729AB30", Offset = "0x7299B30", VA = "0x18729AB30")]
	public static JMPIHICOHFM OPKCDKIHHBH(float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x729AC30", Offset = "0x7299C30", VA = "0x18729AC30")]
	public static JMPIHICOHFM OPKCDKIHHBH(MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x729AA10", Offset = "0x7299A10", VA = "0x18729AA10")]
	public static JMPIHICOHFM LBPKOKDPNDO(MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x729AD40", Offset = "0x7299D40", VA = "0x18729AD40")]
	public static JMPIHICOHFM PFGNLLKKBAI(NOMFKNGBIGI FFHIJMOJNAI, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x729A860", Offset = "0x7299860", VA = "0x18729A860")]
	private static IEnumerator<MBMMHILCGCA> FEIGFPHKPHJ(BMLOLHIMKME BCCABDLFKFN, float LMENHCIHLHF, POIAJKHHOFJ EOICDCMLDHF, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x729A920", Offset = "0x7299920", VA = "0x18729A920")]
	private static IEnumerator<MBMMHILCGCA> GGDDIMOHAKJ(BMLOLHIMKME BCCABDLFKFN, float LMENHCIHLHF, POIAJKHHOFJ EOICDCMLDHF, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x729A980", Offset = "0x7299980", VA = "0x18729A980")]
	[IteratorStateMachine(typeof(NOJHEMDOGIC))]
	private static IEnumerator<MBMMHILCGCA> INJEKMOLIPL(FBGBCEGFILK ACIDDFJMNKI, float LMENHCIHLHF, POIAJKHHOFJ EOICDCMLDHF, Action<float> EPPBBINIJEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class HGPPGFDFDNM
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class BGLLPDCDCGO : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public POIAJKHHOFJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public BGLLPDCDCGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7289580", Offset = "0x7288580", VA = "0x187289580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7289640", Offset = "0x7288640", VA = "0x187289640", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7298F60", Offset = "0x7297F60", VA = "0x187298F60")]
	[IteratorStateMachine(typeof(BGLLPDCDCGO))]
	private static IEnumerator<MBMMHILCGCA> KHDLINCOGOK(POIAJKHHOFJ ABGODCJAPHA, Func<bool> HENBCPJDKPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7298FF0", Offset = "0x7297FF0", VA = "0x187298FF0")]
	public static JMPIHICOHFM OGNEFJEKNHN(this MonoBehaviour ALFBHFDIDMA, Func<bool> HENBCPJDKPD, POIAJKHHOFJ ABGODCJAPHA = POIAJKHHOFJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class AHFCKBLLFGO
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class JKKOJBKODCG : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public POIAJKHHOFJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public JKKOJBKODCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x729A2C0", Offset = "0x72992C0", VA = "0x18729A2C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x729A330", Offset = "0x7299330", VA = "0x18729A330", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class HAHCBPFFGCB : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public POIAJKHHOFJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private MBMMHILCGCA <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public HAHCBPFFGCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7298770", Offset = "0x7297770", VA = "0x187298770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7298800", Offset = "0x7297800", VA = "0x187298800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7286920", Offset = "0x7285920", VA = "0x187286920")]
	[IteratorStateMachine(typeof(JKKOJBKODCG))]
	private static IEnumerator<MBMMHILCGCA> APAEACBLEAP(float PJKHGIHPBDF, POIAJKHHOFJ EOICDCMLDHF, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7286C70", Offset = "0x7285C70", VA = "0x187286C70")]
	[IteratorStateMachine(typeof(HAHCBPFFGCB))]
	private static IEnumerator<MBMMHILCGCA> IPDAILKCDGD(float PJKHGIHPBDF, POIAJKHHOFJ EOICDCMLDHF, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7286FE0", Offset = "0x7285FE0", VA = "0x187286FE0")]
	public static IDisposable MACFKKMADCC(this MonoBehaviour ALFBHFDIDMA, float PJKHGIHPBDF, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7287100", Offset = "0x7286100", VA = "0x187287100")]
	public static JMPIHICOHFM NAPEOPPINMK(this MonoBehaviour ALFBHFDIDMA, float PJKHGIHPBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7286EB0", Offset = "0x7285EB0", VA = "0x187286EB0")]
	public static JMPIHICOHFM MACFKKMADCC(this MonoBehaviour ALFBHFDIDMA, float PJKHGIHPBDF, POIAJKHHOFJ EOICDCMLDHF, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x72871F0", Offset = "0x72861F0", VA = "0x1872871F0")]
	public static JMPIHICOHFM OOJHIBALHKL(this MonoBehaviour ALFBHFDIDMA, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x72871C0", Offset = "0x72861C0", VA = "0x1872871C0")]
	public static JMPIHICOHFM OLKMEFOKLNH(this MonoBehaviour ALFBHFDIDMA, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7286A90", Offset = "0x7285A90", VA = "0x187286A90")]
	public static JMPIHICOHFM BEFOLGKBAFJ(this MonoBehaviour ALFBHFDIDMA, Action LHGGEBICOGB, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7286C40", Offset = "0x7285C40", VA = "0x187286C40")]
	public static JMPIHICOHFM FCLCLGKCNIM(this MonoBehaviour ALFBHFDIDMA, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72872E0", Offset = "0x72862E0", VA = "0x1872872E0")]
	public static JMPIHICOHFM PCOANGIPMLB(this MonoBehaviour ALFBHFDIDMA, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x72869C0", Offset = "0x72859C0", VA = "0x1872869C0")]
	private static JMPIHICOHFM BBCKCKEEHJG(MonoBehaviour ALFBHFDIDMA, POIAJKHHOFJ ABGODCJAPHA, Action LHGGEBICOGB, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7286DE0", Offset = "0x7285DE0", VA = "0x187286DE0")]
	public static JMPIHICOHFM KOAGCPNCBCA(this MonoBehaviour ALFBHFDIDMA, float NCHEHAPAHDM, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7286D10", Offset = "0x7285D10", VA = "0x187286D10")]
	public static JMPIHICOHFM JOAIFNGNBMH(this MonoBehaviour ALFBHFDIDMA, float NCHEHAPAHDM, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7286B70", Offset = "0x7285B70", VA = "0x187286B70")]
	public static JMPIHICOHFM EIBHPKFMKKE(this MonoBehaviour ALFBHFDIDMA, float NCHEHAPAHDM, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7287210", Offset = "0x7286210", VA = "0x187287210")]
	public static JMPIHICOHFM OPEIACFCBKE(this MonoBehaviour ALFBHFDIDMA, float NCHEHAPAHDM, Action LHGGEBICOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class EPIMMOONMHF : MLJHNPOFEEC, IEnumerable<MLJHNPOFEEC>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly List<MLJHNPOFEEC> NCHBKHPFNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool FKABMAGFMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Action FIBNOLMIECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool PEIPGBGOAME;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IFHNLDJJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7292820", Offset = "0x7291820", VA = "0x187292820", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OIPHHAKLFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7292B60", Offset = "0x7291B60", VA = "0x187292B60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7292AC0", Offset = "0x7291AC0", VA = "0x187292AC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x72930D0", Offset = "0x72920D0", VA = "0x1872930D0")]
	public EPIMMOONMHF([Optional] Action FIBNOLMIECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7292FA0", Offset = "0x7291FA0", VA = "0x187292FA0")]
	public void MJFEDCBJOBF(MLJHNPOFEEC MCONODJLCLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7292960", Offset = "0x7291960", VA = "0x187292960")]
	private void CJOJDMKEEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7292C00", Offset = "0x7291C00", VA = "0x187292C00", Slot = "7")]
	public bool FAFNFBEBOHM(bool BAKDLGCFEEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7292C10", Offset = "0x7291C10", VA = "0x187292C10", Slot = "8")]
	public bool FAFNFBEBOHM(Action OGLJLDNLGIJ, bool BAKDLGCFEEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7292F20", Offset = "0x7291F20", VA = "0x187292F20", Slot = "9")]
	public IEnumerator<MLJHNPOFEEC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7292F20", Offset = "0x7291F20", VA = "0x187292F20", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class HNJCMFDMOIM : KCGEKOMMBKF
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class BLALDKFENKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public HNJCMFDMOIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public BLALDKFENKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7289690", Offset = "0x7288690", VA = "0x187289690")]
		internal void OMLLOHLPHCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class OBHALJNLMJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public HNJCMFDMOIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public OBHALJNLMJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7289690", Offset = "0x7288690", VA = "0x187289690")]
		internal void HKEHKCJMLCC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float PDLIJJIPHFN;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7299AB0", Offset = "0x7298AB0", VA = "0x187299AB0")]
	public HNJCMFDMOIM(Behaviour FFHIJMOJNAI, float PDLIJJIPHFN, [Optional] Action FIBNOLMIECG, [Optional] PHAHKEIGJGJ GMONHBOKFFJ, [Optional] BMLOLHIMKME BCCABDLFKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7299890", Offset = "0x7298890", VA = "0x187299890", Slot = "9")]
	protected override bool AIFEKFHFLAO(Action OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x72999A0", Offset = "0x72989A0", VA = "0x1872999A0", Slot = "10")]
	protected override bool NCDLLACMBAA(Action OGLJLDNLGIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface MLJHNPOFEEC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IFHNLDJJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OIPHHAKLFKI;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FAFNFBEBOHM(bool BAKDLGCFEEB = false);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FAFNFBEBOHM(Action OGLJLDNLGIJ, bool BAKDLGCFEEB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public abstract class KCGEKOMMBKF : MLJHNPOFEEC
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class OLCPDCDFINF : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public KCGEKOMMBKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public OLCPDCDFINF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x72A0EF0", Offset = "0x729FEF0", VA = "0x1872A0EF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x72A0FC0", Offset = "0x729FFC0", VA = "0x1872A0FC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Behaviour FFHIJMOJNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action FIBNOLMIECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private PGGFJFHOMCP NIDNOGMFDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly PHAHKEIGJGJ GMONHBOKFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly BMLOLHIMKME BCCABDLFKFN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool IFHNLDJJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xE9CDD0", Offset = "0xE9BDD0", VA = "0x180E9CDD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OIPHHAKLFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x729B150", Offset = "0x729A150", VA = "0x18729B150", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x729AE70", Offset = "0x7299E70", VA = "0x18729AE70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x729B400", Offset = "0x729A400", VA = "0x18729B400")]
	protected KCGEKOMMBKF(Behaviour FFHIJMOJNAI, [Optional] Action FIBNOLMIECG, [Optional] PHAHKEIGJGJ GMONHBOKFFJ, [Optional] BMLOLHIMKME BCCABDLFKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x729B1F0", Offset = "0x729A1F0", VA = "0x18729B1F0", Slot = "7")]
	public bool FAFNFBEBOHM(bool BAKDLGCFEEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x729B250", Offset = "0x729A250", VA = "0x18729B250", Slot = "8")]
	public bool FAFNFBEBOHM(Action OGLJLDNLGIJ, bool BAKDLGCFEEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool AIFEKFHFLAO(Action OGLJLDNLGIJ);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NCDLLACMBAA(Action OGLJLDNLGIJ);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x729AE50", Offset = "0x7299E50", VA = "0x18729AE50")]
	protected void DBBBALFMDIE(Action OGLJLDNLGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x729AF10", Offset = "0x7299F10", VA = "0x18729AF10")]
	protected PGILFKJEHOF EAMFGLLALFO(float DACHNPNJPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x729B2B0", Offset = "0x729A2B0", VA = "0x18729B2B0")]
	private void FDPMCOJADKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x729B330", Offset = "0x729A330", VA = "0x18729B330")]
	[IteratorStateMachine(typeof(OLCPDCDFINF))]
	private IEnumerator<MBMMHILCGCA> JOCCILCCONM(float DACHNPNJPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x729B3C0", Offset = "0x729A3C0", VA = "0x18729B3C0")]
	[CompilerGenerated]
	private void OIAJOCNNHJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HBIPIDOMMCO : KCGEKOMMBKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float APGGJODKGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly int BNALDMCHBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float DNKCMGGCPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float[] JNPLIGPMEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private int BCIBHALJBGC;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7298AD0", Offset = "0x7297AD0", VA = "0x187298AD0")]
	public HBIPIDOMMCO(Behaviour FFHIJMOJNAI, float DNHPDLIPPEC, int BNALDMCHBDE, [Optional] Action FIBNOLMIECG, float DNKCMGGCPBO = 0f, [Optional] PHAHKEIGJGJ GMONHBOKFFJ, [Optional] BMLOLHIMKME BCCABDLFKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "9")]
	protected override bool AIFEKFHFLAO(Action OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x72988D0", Offset = "0x72978D0", VA = "0x1872988D0", Slot = "10")]
	protected override bool NCDLLACMBAA(Action OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7298850", Offset = "0x7297850", VA = "0x187298850")]
	private void LMEKNPFAAJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class IPOFMJHMIFJ : KCGEKOMMBKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly float PDLIJJIPHFN;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7299AB0", Offset = "0x7298AB0", VA = "0x187299AB0")]
	public IPOFMJHMIFJ(Behaviour FFHIJMOJNAI, float PDLIJJIPHFN, [Optional] Action FIBNOLMIECG, [Optional] PHAHKEIGJGJ GMONHBOKFFJ, [Optional] BMLOLHIMKME BCCABDLFKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "9")]
	protected override bool AIFEKFHFLAO(Action OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7299D60", Offset = "0x7298D60", VA = "0x187299D60", Slot = "10")]
	protected override bool NCDLLACMBAA(Action OGLJLDNLGIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public sealed class NMLFBICECBA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class EIEEGGECHFI : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public EIEEGGECHFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7292560", Offset = "0x7291560", VA = "0x187292560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x72925D0", Offset = "0x72915D0", VA = "0x1872925D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private JMPIHICOHFM EOPOOMBHLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NOMFKNGBIGI FFHIJMOJNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Action<float> GDIIEFHNABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private POIAJKHHOFJ ABGODCJAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private float EMFKOFNBIIO;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x729E2C0", Offset = "0x729D2C0", VA = "0x18729E2C0")]
	public NMLFBICECBA(NOMFKNGBIGI FFHIJMOJNAI, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x729DEF0", Offset = "0x729CEF0", VA = "0x18729DEF0")]
	private void GLFHFFIFDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x729DD30", Offset = "0x729CD30", VA = "0x18729DD30")]
	private void CIIEOFHEDPK(string JCBCIJOKIDD, Action EKKBEDNDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x729E090", Offset = "0x729D090", VA = "0x18729E090")]
	[IteratorStateMachine(typeof(EIEEGGECHFI))]
	private IEnumerator<MBMMHILCGCA> JLJJBLPOBPN(Action EKKBEDNDPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x729DE90", Offset = "0x729CE90", VA = "0x18729DE90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x729E110", Offset = "0x729D110", VA = "0x18729E110")]
	[CompilerGenerated]
	private void ONOKOJILGLP(string PHPBNDIBHHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class EABEBENHMGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class GBBOHEMMGNC : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public GBBOHEMMGNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7292560", Offset = "0x7291560", VA = "0x187292560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7294DA0", Offset = "0x7293DA0", VA = "0x187294DA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private JMPIHICOHFM EOPOOMBHLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private MonoBehaviour ALFBHFDIDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Action EPPBBINIJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action<float> GDIIEFHNABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private POIAJKHHOFJ ABGODCJAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private float EMFKOFNBIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool OOAPIHAOEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly PHAHKEIGJGJ GMONHBOKFFJ;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7291670", Offset = "0x7290670", VA = "0x187291670")]
	public EABEBENHMGE(MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x72911E0", Offset = "0x72901E0", VA = "0x1872911E0")]
	public EABEBENHMGE(MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7291420", Offset = "0x7290420", VA = "0x187291420")]
	public EABEBENHMGE(MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1BF56B0", Offset = "0x1BF46B0", VA = "0x181BF56B0")]
	private EABEBENHMGE(PHAHKEIGJGJ GMONHBOKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x72910B0", Offset = "0x72900B0", VA = "0x1872910B0")]
	internal static EABEBENHMGE PJLANIPMFMC(MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7290F40", Offset = "0x728FF40", VA = "0x187290F40")]
	private void OPKCDKIHHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7290D10", Offset = "0x728FD10", VA = "0x187290D10")]
	private void JDJCAFDPFBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7290AD0", Offset = "0x728FAD0", VA = "0x187290AD0")]
	private void GLFHFFIFDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x72905D0", Offset = "0x728F5D0", VA = "0x1872905D0")]
	private void ABFHLHBLKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x72908B0", Offset = "0x728F8B0", VA = "0x1872908B0")]
	private void CIIEOFHEDPK(string JCBCIJOKIDD, Action EKKBEDNDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7290EC0", Offset = "0x728FEC0", VA = "0x187290EC0")]
	[IteratorStateMachine(typeof(GBBOHEMMGNC))]
	private IEnumerator<MBMMHILCGCA> JLJJBLPOBPN(Action EKKBEDNDPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7290A70", Offset = "0x728FA70", VA = "0x187290A70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7290820", Offset = "0x728F820", VA = "0x187290820")]
	[CompilerGenerated]
	private void BNOELEILCJE(string PHPBNDIBHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x72909E0", Offset = "0x728F9E0", VA = "0x1872909E0")]
	[CompilerGenerated]
	private void DOCNLADKLCL(string PHPBNDIBHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7290C80", Offset = "0x728FC80", VA = "0x187290C80")]
	[CompilerGenerated]
	private void GMGJGJFEPKK(string PHPBNDIBHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7290790", Offset = "0x728F790", VA = "0x187290790")]
	[CompilerGenerated]
	private void AMDGMOIPKGD(string PHPBNDIBHHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[Flags]
internal enum HEOMPEGLDNI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class CBMBAFFKFGH : BMLOLHIMKME
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float HBOJBHGLLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7289B30", Offset = "0x7288B30", VA = "0x187289B30", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float AIFANPKCABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7289B00", Offset = "0x7288B00", VA = "0x187289B00", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double HMNOFLLLMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7289B10", Offset = "0x7288B10", VA = "0x187289B10", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7289B40", Offset = "0x7288B40", VA = "0x187289B40")]
	[PECFDJPHGEK(BOIKMOKIOJG.None)]
	private static void JEEKJHILOBP(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	[Preserve]
	internal CBMBAFFKFGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface LJDCLHBNMPG
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAHFFFCPNDL(string LCLKDNPLMED);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBHDLPEFIDE();
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface JMBNHIKJBKN
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool CJMHCJFHMME
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool IBEKAMBLKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal class EALAONFAEDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public GDNBBGNPPJN GICCHOIEBIG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int FPNFNABMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x8641A0", VA = "0x1808651A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x86A850", Offset = "0x869850", VA = "0x18086A850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7291D20", Offset = "0x7290D20", VA = "0x187291D20")]
	public static MBMMHILCGCA HDKCHGBCFEN(IEnumerator<MBMMHILCGCA> CBONFMNDCJK, DLOFNHFJPBN JKOLNABNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7291E80", Offset = "0x7290E80", VA = "0x187291E80")]
	public MBMMHILCGCA HDKCHGBCFEN(DLOFNHFJPBN[] PMDJJOCJMFO, IEnumerator<MBMMHILCGCA>[] BMDFPKKOCFC, MBMMHILCGCA[] ACFMNBKNJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7291CF0", Offset = "0x7290CF0", VA = "0x187291CF0")]
	public void POBGAHCJDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7291A70", Offset = "0x7290A70", VA = "0x187291A70")]
	public void BEDCDAPBNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7291BB0", Offset = "0x7290BB0", VA = "0x187291BB0")]
	public void EEFFIKIAGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7291CF0", Offset = "0x7290CF0", VA = "0x187291CF0")]
	public void GLLCMOEOPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public EALAONFAEDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class GDNBBGNPPJN
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct NJEBAGGJBCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public EALAONFAEDG MAICJLFLLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public NOMFKNGBIGI NMINIDOGFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public DLOFNHFJPBN MNJFGJFFNIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IEnumerator<MBMMHILCGCA> BIIHFPKCPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public MBMMHILCGCA OONPBJJAJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public HEOMPEGLDNI NFELHMENFLH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct OCBEPLDHOGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public POIAJKHHOFJ OEHEBEJLCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public List<NJEBAGGJBCG> AMNGNILMJPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class CIMGJJJEOEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public DLOFNHFJPBN promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public GDNBBGNPPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public NOMFKNGBIGI context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public EALAONFAEDG routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public HEOMPEGLDNI coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public MBMMHILCGCA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IEnumerator<MBMMHILCGCA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public CIMGJJJEOEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x728AFE0", Offset = "0x7289FE0", VA = "0x18728AFE0")]
		internal void LEIBNGAPOPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class MALGOCJMJMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public EALAONFAEDG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public GDNBBGNPPJN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public MALGOCJMJMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x729C840", Offset = "0x729B840", VA = "0x18729C840")]
		internal void ELJBHEDEHHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DAMEGPJJAFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public EALAONFAEDG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public GDNBBGNPPJN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public DAMEGPJJAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7290010", Offset = "0x728F010", VA = "0x187290010")]
		internal void OHALHOKGKKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class EABLHJODMCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public EALAONFAEDG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public GDNBBGNPPJN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public EABLHJODMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7291860", Offset = "0x7290860", VA = "0x187291860")]
		internal void DKHDHODBDLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const HEOMPEGLDNI LKKFNAEIBLL = HEOMPEGLDNI.Cancelled | HEOMPEGLDNI.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly POIAJKHHOFJ ABGODCJAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool[] KJJMONGHDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<HEOMPEGLDNI> ODHGLBEAFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<float> CHCFNOGJPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> BPAHBOAIFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> NCMGHMNFDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> PHKHMNDINJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> GDGNHAHBFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> HGHCIFLIBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private EALAONFAEDG[] GFACDPAFDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private DLOFNHFJPBN[] PMDJJOCJMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private NOMFKNGBIGI[] MFGNPKJMJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IEnumerator<MBMMHILCGCA>[] HEALNBJDCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private MBMMHILCGCA[] NDJMEOIJHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int MIHMAFODPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int NAFKLJDAKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly int MFMBBAGJHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float IDFGDOGEPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private OGELMGGMAKD FOLAANIGOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private JobHandle CCDBIPPMFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<EALAONFAEDG> BLNPPCJCAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool GJMDPPENLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private List<Action> AOIPHFIEKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> GOOOIKAMHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private bool MEAEDBMMGIE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public OCBEPLDHOGC[] EFNAJMNNAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8D1030", Offset = "0x8D0030", VA = "0x1808D1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7297130", Offset = "0x7296130", VA = "0x187297130")]
	private static int PPOHFPFFKPG(POIAJKHHOFJ ABGODCJAPHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7297160", Offset = "0x7296160", VA = "0x187297160")]
	public GDNBBGNPPJN(POIAJKHHOFJ ABGODCJAPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7295BA0", Offset = "0x7294BA0", VA = "0x187295BA0")]
	private void LIBIPBMOOFN(int FIFGOHECGBE, int KGFHFFLKOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7295FE0", Offset = "0x7294FE0", VA = "0x187295FE0")]
	public void MJLPBGGONDI(NOMFKNGBIGI FFHIJMOJNAI, MBMMHILCGCA CILENLNLFKO, IEnumerator<MBMMHILCGCA> CBONFMNDCJK, DLOFNHFJPBN JKOLNABNIDN, [Optional] EALAONFAEDG OPOFFHABDLG, HEOMPEGLDNI OMDNJIBGMHH = HEOMPEGLDNI.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7296EF0", Offset = "0x7295EF0", VA = "0x187296EF0")]
	public void PHEGOHBAODL(IEnumerable<NJEBAGGJBCG> LAOHKBDNJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7296A20", Offset = "0x7295A20", VA = "0x187296A20")]
	private NJEBAGGJBCG OLBNHMDNNDP(int GOFFGLCJLID)
	{
		return default(NJEBAGGJBCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7295050", Offset = "0x7294050", VA = "0x187295050")]
	private void HAAJPEBDKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2B16E70", Offset = "0x2B15E70", VA = "0x182B16E70")]
	private static void CDFIMMDKABK<T>(int GOFFGLCJLID, T[] JNFJFDAHKFH, int ENCFHCJIMBE, [Optional] T JMLMBGDCFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B16EC0", Offset = "0x2B15EC0", VA = "0x182B16EC0")]
	private static void CDFIMMDKABK<T>(int GOFFGLCJLID, NativeArray<T> JNFJFDAHKFH, int ENCFHCJIMBE, [Optional] T JMLMBGDCFJK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x72954F0", Offset = "0x72944F0", VA = "0x1872954F0")]
	private void JANEFIIBGBP(IEnumerable<NJEBAGGJBCG> LAOHKBDNJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7296960", Offset = "0x7295960", VA = "0x187296960")]
	private void OHNGOKOIPMA(NJEBAGGJBCG HFDOHCDJOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7295D80", Offset = "0x7294D80", VA = "0x187295D80")]
	private AILGIIDBLKP LOJBDDBBGMB(int OIFKFFCKOBP)
	{
		return default(AILGIIDBLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7295920", Offset = "0x7294920", VA = "0x187295920")]
	public void KBHFBFJEGDF(float AAEDJKLCPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x72958A0", Offset = "0x72948A0", VA = "0x1872958A0")]
	private void KBHCKDMOBNJ(Action FAGKOOGCGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7295B20", Offset = "0x7294B20", VA = "0x187295B20")]
	private void KLIEEFOJKGD(Action FAGKOOGCGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7296160", Offset = "0x7295160", VA = "0x187296160")]
	public void MKPLCEADAAI(float AAEDJKLCPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7296860", Offset = "0x7295860", VA = "0x187296860")]
	public void NNOPBDMPMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7294F20", Offset = "0x7293F20", VA = "0x187294F20")]
	public void GLLCMOEOPNM(EALAONFAEDG ACIDDFJMNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7294DF0", Offset = "0x7293DF0", VA = "0x187294DF0")]
	public void CKKMJBCNBFC(EALAONFAEDG ACIDDFJMNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x72953C0", Offset = "0x72943C0", VA = "0x1872953C0")]
	public void HCGMNNKLNBG(EALAONFAEDG ACIDDFJMNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class DGGAGGBIDOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static readonly DGGAGGBIDOK BHJAMJDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Action DPHFDCIPJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool KIHONPKCMEM;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	public DGGAGGBIDOK(Action DPHFDCIPJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A430E0", Offset = "0x6A420E0", VA = "0x186A430E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface GGPKCLFLNGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T BLBBIKKJHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PJPIMECKACI(UnityEngine.Object FFHIJMOJNAI, Action<T> NIJPIJMMBPJ);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface IHDIJKOCAHH<T> : GGPKCLFLNGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T BLBBIKKJHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class CABANDNIAMG<T> : IHDIJKOCAHH<T>, GGPKCLFLNGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class CGHKDOKGNNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public CABANDNIAMG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public KKCDLHKOFNI<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public CGHKDOKGNNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5166960", Offset = "0x5165960", VA = "0x185166960")]
		internal void BJHININKKHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static GameObject HIAGKILEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<KKCDLHKOFNI<UnityEngine.Object, Action<T>>> JGAIBPNFHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private T OMFCIIMEOKA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T BLBBIKKJHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x932C30", Offset = "0x931C30", VA = "0x180932C30", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C9D0", Offset = "0x4F6B9D0", VA = "0x184F6C9D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4F6C900", Offset = "0x4F6B900", VA = "0x184F6C900")]
	private static bool AHJCIFFFBKD(T FAGKOOGCGBH, T HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D630", Offset = "0x4F6C630", VA = "0x184F6D630")]
	public CABANDNIAMG(T NLGAOHMJLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D3A0", Offset = "0x4F6C3A0", VA = "0x184F6D3A0", Slot = "6")]
	public IDisposable PJPIMECKACI(UnityEngine.Object FFHIJMOJNAI, Action<T> NIJPIJMMBPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4F6CB40", Offset = "0x4F6BB40", VA = "0x184F6CB40")]
	private void JPKFMOGMOPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class CKDPLKKLPNM : LHLNMHMMNBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly PHAHKEIGJGJ GMONHBOKFFJ;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x728C150", Offset = "0x728B150", VA = "0x18728C150")]
	[PECFDJPHGEK(BOIKMOKIOJG.None)]
	private static void JEEKJHILOBP(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	[Preserve]
	internal CKDPLKKLPNM([JFHFHOOOEKP(null)] PHAHKEIGJGJ GMONHBOKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x728C0A0", Offset = "0x728B0A0", VA = "0x18728C0A0", Slot = "4")]
	public IDisposable BFPAACIFPAN(float LMENHCIHLHF, Action<float> AHJILKLLLDE, bool OOAPIHAOEOP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class FEFPHGHDKNH : CGLJOODMFEB, PHAHKEIGJGJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private GDNBBGNPPJN[] MIJEKBIENCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private LJDCLHBNMPG GLJCGMFECFP;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7293510", Offset = "0x7292510", VA = "0x187293510")]
	[PECFDJPHGEK(BOIKMOKIOJG.None)]
	private static void JEEKJHILOBP(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7293D00", Offset = "0x7292D00", VA = "0x187293D00")]
	[Preserve]
	public FEFPHGHDKNH([JFHFHOOOEKP(null)] NILKNAMLKCJ EJLDPBDMOIB, [JFHFHOOOEKP(null)] BMLOLHIMKME BCCABDLFKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x72938D0", Offset = "0x72928D0", VA = "0x1872938D0", Slot = "16")]
	public override JMPIHICOHFM OGMIMPFANOG(NOMFKNGBIGI FFHIJMOJNAI, IEnumerator<MBMMHILCGCA> HIHCMGCDADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x72931D0", Offset = "0x72921D0", VA = "0x1872931D0", Slot = "17")]
	public override void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x72936A0", Offset = "0x72926A0", VA = "0x1872936A0", Slot = "19")]
	public override void NPHKMFMBBAB(POIAJKHHOFJ ABGODCJAPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7293A00", Offset = "0x7292A00", VA = "0x187293A00", Slot = "18")]
	protected override void OMKLHJHPBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x72934E0", Offset = "0x72924E0", VA = "0x1872934E0")]
	private GDNBBGNPPJN JANMNIOAMDK(POIAJKHHOFJ PBLNJHEPKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7293AD0", Offset = "0x7292AD0", VA = "0x187293AD0", Slot = "20")]
	internal override MNDHMAOELEJ ONGGHBFLGLK(IEnumerator<MBMMHILCGCA> HIHCMGCDADP, Behaviour FFHIJMOJNAI, DLOFNHFJPBN JKOLNABNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7293460", Offset = "0x7292460", VA = "0x187293460", Slot = "21")]
	internal override OBBFNJOINKO FDLCFKEBGIH(POIAJKHHOFJ EOICDCMLDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7293580", Offset = "0x7292580", VA = "0x187293580")]
	private void MJJINEOBLAN(GDNBBGNPPJN DPLJPFDFONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7293170", Offset = "0x7292170", VA = "0x187293170", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[BurstCompile]
internal struct OGELMGGMAKD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	public float LCKAANELJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public int NPPNBDBMMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> PHCKJPMBIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> APIACBADCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> FICLDMPGLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	public NativeArray<HEOMPEGLDNI> IKDOOMJJLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<float> PALLOCMLIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[WriteOnly]
	public NativeArray<int> PHKHMNDINJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> BPAHBOAIFOE;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x72A0AB0", Offset = "0x729FAB0", VA = "0x1872A0AB0")]
	public static OGELMGGMAKD GIGNPOIHFIA(int CDJGPLLGAEP, float AAEDJKLCPHK, NativeArray<HEOMPEGLDNI> COCFMHLECBF, NativeArray<float> OIGDCCPFNMD, NativeArray<int> MGDKIDAIKBG, NativeArray<int> BDGCJABMNEH, NativeArray<int> NIDGFHHBGHA, NativeArray<int> APIACBADCBP, NativeArray<int> FICLDMPGLKF)
	{
		return default(OGELMGGMAKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x72A0790", Offset = "0x729F790", VA = "0x1872A0790", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x72A0CB0", Offset = "0x729FCB0", VA = "0x1872A0CB0")]
	private bool PPDIIKNJCFP(int LLPJHIPCNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x72A0C80", Offset = "0x729FC80", VA = "0x1872A0C80")]
	private void ONOIHHNOPCL(NativeArray<int> HGHEGKPMBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x72A0BE0", Offset = "0x729FBE0", VA = "0x1872A0BE0")]
	private int MEIEABEILCG(int JAFBPHKHNOE, int DMCPHEILHHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x72A0B10", Offset = "0x729FB10", VA = "0x1872A0B10")]
	private void MCAOLAIBMCI(NativeArray<int> HGHEGKPMBJK, int MNLHINLGMCM, int LJNBPEFJOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x72A0870", Offset = "0x729F870", VA = "0x1872A0870")]
	private void GBHJMJHDOJO(NativeArray<int> HGHEGKPMBJK, int LFMHBNAJLAF, int FMMLEBDABGO, int PAMLKHMHDMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class CGLJOODMFEB : PHAHKEIGJGJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly NILKNAMLKCJ EJLDPBDMOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected readonly BMLOLHIMKME BCCABDLFKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private OBBFNJOINKO[] PCHLOPAPNFG;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static PHAHKEIGJGJ IBMHAACFGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x728A2E0", Offset = "0x72892E0", VA = "0x18728A2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool LMMCDOJHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public POIAJKHHOFJ DGCDKIOHFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x8641A0", VA = "0x1808651A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(POIAJKHHOFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x86A850", Offset = "0x869850", VA = "0x18086A850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public BMLOLHIMKME PGHKMMEIFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MBMMHILCGCA ICDDKLGLANM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x728A1F0", Offset = "0x72891F0", VA = "0x18728A1F0")]
	public static JMPIHICOHFM FLCLENEBNDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x728AAF0", Offset = "0x7289AF0", VA = "0x18728AAF0")]
	[Preserve]
	protected CGLJOODMFEB([JFHFHOOOEKP(null)] NILKNAMLKCJ EJLDPBDMOIB, [JFHFHOOOEKP(null)] BMLOLHIMKME BCCABDLFKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x728A3C0", Offset = "0x72893C0", VA = "0x18728A3C0", Slot = "6")]
	public JMPIHICOHFM JGBGEMHOKIJ(IEnumerator<MBMMHILCGCA> HIHCMGCDADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x728A3D0", Offset = "0x72893D0", VA = "0x18728A3D0", Slot = "7")]
	public JMPIHICOHFM JGBGEMHOKIJ(Behaviour FFHIJMOJNAI, IEnumerator<MBMMHILCGCA> HIHCMGCDADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract JMPIHICOHFM OGMIMPFANOG(NOMFKNGBIGI FFHIJMOJNAI, IEnumerator<MBMMHILCGCA> HIHCMGCDADP);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x728A030", Offset = "0x7289030", VA = "0x18728A030", Slot = "17")]
	public virtual void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x728A890", Offset = "0x7289890", VA = "0x18728A890", Slot = "9")]
	public void OFCJLMJLKKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x728AAD0", Offset = "0x7289AD0", VA = "0x18728AAD0", Slot = "18")]
	protected virtual void OMKLHJHPBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7289BB0", Offset = "0x7288BB0", VA = "0x187289BB0")]
	private void BBPPNPAHDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7289C30", Offset = "0x7288C30", VA = "0x187289C30")]
	private void CCEJMMCIFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x728A7C0", Offset = "0x72897C0", VA = "0x18728A7C0")]
	private void LKGMHCOOGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x728A010", Offset = "0x7289010", VA = "0x18728A010")]
	private void ELGCNFKCKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x728A5D0", Offset = "0x72895D0", VA = "0x18728A5D0")]
	private void JHLAKLOLGOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x728A1D0", Offset = "0x72891D0", VA = "0x18728A1D0")]
	private void FGGPIOMEFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x728A7E0", Offset = "0x72897E0", VA = "0x18728A7E0")]
	private void NPHFIEBPGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x728A800", Offset = "0x7289800", VA = "0x18728A800", Slot = "19")]
	public virtual void NPHKMFMBBAB(POIAJKHHOFJ ABGODCJAPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x728A5F0", Offset = "0x72895F0", VA = "0x18728A5F0")]
	private void KOMOCBFLMPP(OBBFNJOINKO DPLJPFDFONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1EC3040", Offset = "0x1EC2040", VA = "0x181EC3040")]
	private OBBFNJOINKO GDAGLJGCFMB(POIAJKHHOFJ PBLNJHEPKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract MNDHMAOELEJ ONGGHBFLGLK(IEnumerator<MBMMHILCGCA> HIHCMGCDADP, Behaviour ALFBHFDIDMA, DLOFNHFJPBN BEPJFCOKLOO);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract OBBFNJOINKO FDLCFKEBGIH(POIAJKHHOFJ ABGODCJAPHA);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7289C50", Offset = "0x7288C50", VA = "0x187289C50", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x728A280", Offset = "0x7289280", VA = "0x18728A280", Slot = "12")]
	public MBMMHILCGCA IHDPHIPONEE(POIAJKHHOFJ EOICDCMLDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x728A330", Offset = "0x7289330", VA = "0x18728A330", Slot = "13")]
	public MBMMHILCGCA JEMCCEEABGA(float PJKHGIHPBDF, POIAJKHHOFJ EOICDCMLDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7289BD0", Offset = "0x7288BD0", VA = "0x187289BD0", Slot = "14")]
	public MBMMHILCGCA BPBIPPOBJMA(Func<bool> HENBCPJDKPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class MNDHMAOELEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly DLOFNHFJPBN JKOLNABNIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly JMBNHIKJBKN FFHIJMOJNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly bool KNINPEMGJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private string LCLKDNPLMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private StackTrace INABEHJJLFH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<MBMMHILCGCA> BIIHFPKCPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public MBMMHILCGCA OONPBJJAJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x867DF0", Offset = "0x866DF0", VA = "0x180867DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool EKPFPHOBPDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x729CE00", Offset = "0x729BE00", VA = "0x18729CE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool MIIALFKIIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9F5AB0", Offset = "0x9F4AB0", VA = "0x1809F5AB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9F5BD0", Offset = "0x9F4BD0", VA = "0x1809F5BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x729C880", Offset = "0x729B880", VA = "0x18729C880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float AGPEHOBKAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8D12E0", Offset = "0x8D02E0", VA = "0x1808D12E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5F05B20", Offset = "0x5F04B20", VA = "0x185F05B20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x729CF60", Offset = "0x729BF60", VA = "0x18729CF60")]
	public MNDHMAOELEJ(IEnumerator<MBMMHILCGCA> CBONFMNDCJK, JMBNHIKJBKN FFHIJMOJNAI, DLOFNHFJPBN JKOLNABNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x729CA80", Offset = "0x729BA80", VA = "0x18729CA80")]
	public MBMMHILCGCA HDKCHGBCFEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x729CD90", Offset = "0x729BD90", VA = "0x18729CD90")]
	public bool LAJPOJHMJAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x729CA30", Offset = "0x729BA30", VA = "0x18729CA30")]
	public void GLLCMOEOPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x729CE80", Offset = "0x729BE80", VA = "0x18729CE80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA86160", Offset = "0xA85160", VA = "0x180A86160")]
	[CompilerGenerated]
	private void JCJNJIMPLOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class DLOFNHFJPBN : MBKHDHMPHNH, JMPIHICOHFM, PGGFJFHOMCP, PGILFKJEHOF, IEnumerator, MBMMHILCGCA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private POIAJKHHOFJ PDGIGHODODH;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private POIAJKHHOFJ BEDEADMGFNP
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x102BFA0", Offset = "0x102AFA0", VA = "0x18102BFA0", Slot = "23")]
		get
		{
			return default(POIAJKHHOFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public POIAJKHHOFJ GICCHOIEBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x155E0A0", Offset = "0x155D0A0", VA = "0x18155E0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float LGKALOFDMME
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA206B0", Offset = "0xA1F6B0", VA = "0x180A206B0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool NGFHJNEHADO
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7290370", Offset = "0x728F370", VA = "0x187290370", Slot = "24")]
	private bool KLFFJIDHLPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7290360", Offset = "0x728F360", VA = "0x187290360", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7290390", Offset = "0x728F390", VA = "0x187290390")]
	public DLOFNHFJPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal enum AILGIIDBLKP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal sealed class OBBFNJOINKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum BCBBIEPKOGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct DKAHGMIBGKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public POIAJKHHOFJ OEHEBEJLCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public BCBBIEPKOGL MGOFFIFCHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<MNDHMAOELEJ> FDFENEOCPIE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly BCBBIEPKOGL[] FFGJPOKBCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly POIAJKHHOFJ ABGODCJAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private bool EBJLIKKIJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly MNDHMAOELEJ[] COMHPCAGFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<MNDHMAOELEJ> FIPAFMIECOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> JKNFJEKCAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly List<MNDHMAOELEJ> OEEOMGBNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Stack<int> CDGNPEKNGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly LJDCLHBNMPG BJJAODOELPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private bool MEAEDBMMGIE;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public DKAHGMIBGKO[,] PECNMHGKBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x86B9A0", Offset = "0x86A9A0", VA = "0x18086B9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x729FAF0", Offset = "0x729EAF0", VA = "0x18729FAF0")]
	public OBBFNJOINKO(POIAJKHHOFJ EOICDCMLDHF, LJDCLHBNMPG BJJAODOELPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x729EE80", Offset = "0x729DE80", VA = "0x18729EE80")]
	public void HCOHKMJBKAE(MNDHMAOELEJ CBONFMNDCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x729F340", Offset = "0x729E340", VA = "0x18729F340")]
	public void NMOFACEONPB(IList<MNDHMAOELEJ> BMDFPKKOCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x729E750", Offset = "0x729D750", VA = "0x18729E750")]
	public void DNEJMMELHAL(IList<MNDHMAOELEJ> BMDFPKKOCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x729EF80", Offset = "0x729DF80", VA = "0x18729EF80")]
	private void IMDBBBHDJAI(MNDHMAOELEJ CBONFMNDCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x729F070", Offset = "0x729E070", VA = "0x18729F070")]
	private void IPOBJHMEKGO(IList<MNDHMAOELEJ> BMDFPKKOCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x729E5D0", Offset = "0x729D5D0", VA = "0x18729E5D0")]
	private AILGIIDBLKP DBPGNEIFEEJ(MNDHMAOELEJ CBONFMNDCJK)
	{
		return default(AILGIIDBLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x729F840", Offset = "0x729E840", VA = "0x18729F840")]
	public void OMKLHJHPBJI(float AAEDJKLCPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x729F650", Offset = "0x729E650", VA = "0x18729F650")]
	public void OFCJLMJLKKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x729EB80", Offset = "0x729DB80", VA = "0x18729EB80")]
	private void GAACDACDKIG(List<MNDHMAOELEJ> BMDFPKKOCFC, Stack<int> FHFAHOBOHLD, bool APKADCODIAG, float DGDDKPPFMLD = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x729EA60", Offset = "0x729DA60", VA = "0x18729EA60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x729F200", Offset = "0x729E200", VA = "0x18729F200")]
	private void KELBNGNKEBA(List<MNDHMAOELEJ> BMDFPKKOCFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class CKMPJAMEGEF : LJDCLHBNMPG
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "4")]
	public void OAHFFFCPNDL(string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
	public void DBHDLPEFIDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public CKMPJAMEGEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class LEPDOMBOFML : JMBNHIKJBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly Behaviour ALFBHFDIDMA;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x729C340", Offset = "0x729B340", VA = "0x18729C340", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool CJMHCJFHMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x729C3E0", Offset = "0x729B3E0", VA = "0x18729C3E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool IBEKAMBLKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x729C3C0", Offset = "0x729B3C0", VA = "0x18729C3C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	public LEPDOMBOFML(Behaviour ALFBHFDIDMA)
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

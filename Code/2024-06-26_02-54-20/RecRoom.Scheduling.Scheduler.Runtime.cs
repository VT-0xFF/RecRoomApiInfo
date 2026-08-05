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
public class DPJBCACNOOL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority HOFDIEGBKIG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7258FB0", Offset = "0x72575B0", VA = "0x187258FB0")]
	public DPJBCACNOOL(ThreadPriority BDCDKPNCMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7258FA0", Offset = "0x72575A0", VA = "0x187258FA0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> GKCKIOBBGPM(List<PlayerLoopSystem> AJEPKEODAPG, int LCNIKFOFDEN);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct DDPBMOILEGP
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct OGOJPDDOOCP
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static BGECMLEGDCD OJKMJBPFKJA;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x72698A0", Offset = "0x7267EA0", VA = "0x1872698A0")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct PJNIEKJKKML
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static BGECMLEGDCD BBPPNPAHDEE;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x726A400", Offset = "0x7268A00", VA = "0x18726A400")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct JJOHMKJJIMA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static BGECMLEGDCD CCEJMMCIFLB;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x7262C70", Offset = "0x7261270", VA = "0x187262C70")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct KDAEEBKHNLC
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static BGECMLEGDCD FDLHJGAGJDK;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static BGECMLEGDCD LDOBDLMJFBG;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static BGECMLEGDCD IFPIAADOAMP;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static BGECMLEGDCD EAGKAGJKOAF;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x72640B0", Offset = "0x72626B0", VA = "0x1872640B0")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct GIILLKOMDPF
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static BGECMLEGDCD KAJBBIFFLMJ;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x7260F20", Offset = "0x725F520", VA = "0x187260F20")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct HEOLDOJOLBA
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static BGECMLEGDCD FDLHJGAGJDK;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static BGECMLEGDCD LDOBDLMJFBG;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static BGECMLEGDCD IFPIAADOAMP;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static BGECMLEGDCD EAGKAGJKOAF;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x7261820", Offset = "0x725FE20", VA = "0x187261820")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct BMABLIKBGPP
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static BGECMLEGDCD JHLAKLOLGOD;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x7252220", Offset = "0x7250820", VA = "0x187252220")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct PHMHCLHMJOD
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static BGECMLEGDCD FGGPIOMEFAP;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x726A000", Offset = "0x7268600", VA = "0x18726A000")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct DLHLOHLGDDK
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static BGECMLEGDCD PEJHJECCMLE;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x7258CC0", Offset = "0x72572C0", VA = "0x187258CC0")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct PJGDAJJGFDI
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static BGECMLEGDCD BMBCHDLICON;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x726A200", Offset = "0x7268800", VA = "0x18726A200")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct GNHPODOOLGO
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static BGECMLEGDCD PHLGNJJPAMO;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x7261120", Offset = "0x725F720", VA = "0x187261120")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct EPAAOFEELDH
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static BGECMLEGDCD IFMFGMEEGKO;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x725B1D0", Offset = "0x72597D0", VA = "0x18725B1D0")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct JDOPJNFAHLO
			{
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public static BGECMLEGDCD NMPLBBNGNOC;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x7262A70", Offset = "0x7261070", VA = "0x187262A70")]
				public static PlayerLoopSystem PBCFKMENFBF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum DAOJPEJDGMC : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct EAKMIPFLMOG
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class IFEHEADILBM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public DAOJPEJDGMC updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
					public IFEHEADILBM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x7262890", Offset = "0x7260E90", VA = "0x187262890")]
					internal void LPNOHAFKBMN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public static GFLPBNMBKPD<DAOJPEJDGMC> HELCOKLDHHI;

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x725A450", Offset = "0x7258A50", VA = "0x18725A450")]
				public static PlayerLoopSystem PBCFKMENFBF(DAOJPEJDGMC CECAGKJACAO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct KPAJLAKEIPJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class BNLDDJGPHGG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public EHAAMOIOJCG.OELPDPJINPB key;

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
					public BNLDDJGPHGG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x7252420", Offset = "0x7250A20", VA = "0x187252420")]
					internal void GKCCJKLFCEA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public static IDisposable MBPLEHGKLIH;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x7264CE0", Offset = "0x72632E0", VA = "0x187264CE0")]
				public static PlayerLoopSystem KMFGIKCBAOP(EHAAMOIOJCG.OELPDPJINPB BHEIPBKEDLG)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct IEJNFPICEHH
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class KKNNCNLKOMI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public EHAAMOIOJCG.OELPDPJINPB key;

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
					public KKNNCNLKOMI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x7264A70", Offset = "0x7263070", VA = "0x187264A70")]
					internal void GKCCJKLFCEA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x7262760", Offset = "0x7260D60", VA = "0x187262760")]
				public static PlayerLoopSystem KMFGIKCBAOP(EHAAMOIOJCG.OELPDPJINPB BHEIPBKEDLG)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class JAOMALFPOEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public JAOMALFPOEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7262950", Offset = "0x7260F50", VA = "0x187262950")]
			internal List<PlayerLoopSystem> OKLKLFLEAHA(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool EMBKLINEMHP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool IOPOGHHEHMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7258B30", Offset = "0x7257130", VA = "0x187258B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7254D20", Offset = "0x7253320", VA = "0x187254D20")]
		private static void AAPKOIDOFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7257B50", Offset = "0x7256150", VA = "0x187257B50")]
		private static void CDABOOPJHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7257920", Offset = "0x7255F20", VA = "0x187257920")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7258840", Offset = "0x7256E40", VA = "0x187258840")]
		private static void KMNCKDNEMIE(EHAAMOIOJCG.OELPDPJINPB BHEIPBKEDLG, PlayerLoopSystem FPDJPPIDOHM, Type FCBNHLCFMJE, Type OFAOEFAPCOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7258460", Offset = "0x7256A60", VA = "0x187258460")]
		private static void JKHOACJELIM(PlayerLoopSystem FPDJPPIDOHM, Type FCBNHLCFMJE, Type OFAOEFAPCOI, GKCKIOBBGPM IBDNCPKJHKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7258A00", Offset = "0x7257000", VA = "0x187258A00")]
		private static void LEOGHBDKFEF(PlayerLoopSystem FPDJPPIDOHM, Type FCBNHLCFMJE, Type OFAOEFAPCOI, PlayerLoopSystem? AGMECHPEEAJ, PlayerLoopSystem? AOOLHMGMNBK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class EHAAMOIOJCG
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum OELPDPJINPB
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		OMPrePhysicsFixedUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class JLPCKHLIEGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly OELPDPJINPB HBOIPLNJOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly OPFMEOCPLFB HHNMCOCMJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long DHJLMLEJJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private long KFLGCIFBBNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long EBPMLDMIKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int IJAJMEOIGFG;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x72631D0", Offset = "0x72617D0", VA = "0x1872631D0")]
		public JLPCKHLIEGJ(OELPDPJINPB JOCENAKHPEH, int IGGCOPJAIPG = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7263160", Offset = "0x7261760", VA = "0x187263160")]
		public void OMKKIOKDOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7263110", Offset = "0x7261710", VA = "0x187263110")]
		public void CJEOPOGCEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7262F30", Offset = "0x7261530", VA = "0x187262F30")]
		public void AEIDCMEFHGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static OELPDPJINPB[] HJCMFJAMNDD;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static JLPCKHLIEGJ[] AEALFGHBJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x725ACF0", Offset = "0x72592F0", VA = "0x18725ACF0")]
	public static JLPCKHLIEGJ HKDKCIEFEPA(OELPDPJINPB BHEIPBKEDLG, int IGGCOPJAIPG = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x725AC80", Offset = "0x7259280", VA = "0x18725AC80")]
	public static JLPCKHLIEGJ EKADMPBLHMP(OELPDPJINPB BHEIPBKEDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x725AED0", Offset = "0x72594D0", VA = "0x18725AED0")]
	public static void MHBLFEIPIHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class OPFMEOCPLFB : FIMLCKAOGMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public int HJHGJDNLODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Queue<double> GOCMPDDIEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double MDCIOHOLJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double HGPGLPENOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double LCKHLHABDMM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double JPFGDMBHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7269BF0", Offset = "0x72681F0", VA = "0x187269BF0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double BPNDDICFGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1A5CE70", Offset = "0x1A5B470", VA = "0x181A5CE70", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double NBAENKBBCBE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1F566B0", Offset = "0x1F54CB0", VA = "0x181F566B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7269DE0", Offset = "0x72683E0", VA = "0x187269DE0")]
	public OPFMEOCPLFB(int NDPHDLIIMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7269C50", Offset = "0x7268250", VA = "0x187269C50", Slot = "7")]
	public void EPIFHDNPJLD(double LECBAKCNNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7269D70", Offset = "0x7268370", VA = "0x187269D70", Slot = "8")]
	public void FDHFDDAAOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ECOHFJBDGKG : FIMLCKAOGMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private long JPBPNOCHNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double PHCOIBMANEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double CELKNJABGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double LCFOPHGDDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double GPFCPJGHHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double MDCIOHOLJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private double HGPGLPENOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double BPNDDICFGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5EE29C0", Offset = "0x5EE0FC0", VA = "0x185EE29C0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double NBAENKBBCBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2500", Offset = "0x5EE0B00", VA = "0x185EE2500", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double NHMHGGMEBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2A00", Offset = "0x5EE1000", VA = "0x185EE2A00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JPFGDMBHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x254FAE0", Offset = "0x254E0E0", VA = "0x18254FAE0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x725AAF0", Offset = "0x72590F0", VA = "0x18725AAF0", Slot = "7")]
	public virtual void EPIFHDNPJLD(double LECBAKCNNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x725AC10", Offset = "0x7259210", VA = "0x18725AC10", Slot = "8")]
	public virtual void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x725AC50", Offset = "0x7259250", VA = "0x18725AC50")]
	public ECOHFJBDGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PGDJCELOHGO : ECOHFJBDGKG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double GGJCCCNDEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2510", Offset = "0x5EE0B10", VA = "0x185EE2510")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5EE29D0", Offset = "0x5EE0FD0", VA = "0x185EE29D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7269E90", Offset = "0x7268490", VA = "0x187269E90", Slot = "7")]
	public override void EPIFHDNPJLD(double LECBAKCNNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7269FC0", Offset = "0x72685C0", VA = "0x187269FC0", Slot = "8")]
	public override void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x725AC50", Offset = "0x7259250", VA = "0x18725AC50")]
	public PGDJCELOHGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface FIMLCKAOGMB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double JPFGDMBHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double BPNDDICFGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double NBAENKBBCBE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class OFOHGDBHOGI
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface DJGIJFPMMEH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool KJMGCLPOCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FGFPBCBMJNA();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private abstract class JNLJNICAFNF<TPromise, TMainThreadPromise> : DJGIJFPMMEH where TPromise : PGILFKJEHOF where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly TPromise OJCCMKIGHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly TMainThreadPromise OPPGAMLBJKK;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise NINOHKJJGAG
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x4110920", Offset = "0x410EF20", VA = "0x184110920")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KJMGCLPOCMC
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x41108D0", Offset = "0x410EED0", VA = "0x1841108D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8677E0", Offset = "0x865DE0", VA = "0x1808677E0")]
		protected JNLJNICAFNF(TPromise OJCCMKIGHOA, TMainThreadPromise GPLMCOKJCHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x41108B0", Offset = "0x410EEB0", VA = "0x1841108B0", Slot = "5")]
		public void FGFPBCBMJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void PHKDFIGOOJK(TPromise OJCCMKIGHOA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class BDMKMEHHKKN<T> : JNLJNICAFNF<HCGNNEJAOHI<T>, EJMFGCNAEMH<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4E50470", Offset = "0x4E4EA70", VA = "0x184E50470")]
		public BDMKMEHHKKN(HCGNNEJAOHI<T> OJCCMKIGHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4E502A0", Offset = "0x4E4E8A0", VA = "0x184E502A0", Slot = "6")]
		protected override void PHKDFIGOOJK(HCGNNEJAOHI<T> OJCCMKIGHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x408A700", Offset = "0x4088D00", VA = "0x18408A700")]
		[CompilerGenerated]
		private void ANMCAAMDKBH(T HJBJAPKPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4E50240", Offset = "0x4E4E840", VA = "0x184E50240")]
		[CompilerGenerated]
		private void AJBMLHCFOMM(string JCBCIJOKIDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class HCMNJOALLBB : DJGIJFPMMEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Action OGLJLDNLGIJ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool KJMGCLPOCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
		public HCMNJOALLBB(Action OGLJLDNLGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9363C0", Offset = "0x9349C0", VA = "0x1809363C0", Slot = "5")]
		public void FGFPBCBMJNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly List<DJGIJFPMMEH> OCLCPLCKKFH;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2C96E90", Offset = "0x2C95490", VA = "0x182C96E90")]
	public static HCGNNEJAOHI<T> IAAMLBPALPE<T>(this HCGNNEJAOHI<T> OJCCMKIGHOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7268E50", Offset = "0x7267450", VA = "0x187268E50")]
	public static void IAAMLBPALPE(Action OGLJLDNLGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2C96F10", Offset = "0x2C95510", VA = "0x182C96F10")]
	private static HCGNNEJAOHI<T> MGOKFJPLNCO<T>(HCGNNEJAOHI<T> OJCCMKIGHOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7268B40", Offset = "0x7267140", VA = "0x187268B40")]
	private static void CBECBACMNMH(DJGIJFPMMEH NGODOBJLIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7268EF0", Offset = "0x72674F0", VA = "0x187268EF0")]
	private static void JLLMAFKFFHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7268D50", Offset = "0x7267350", VA = "0x187268D50")]
	private static void HJPJIEGINIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x72691D0", Offset = "0x72677D0", VA = "0x1872691D0")]
	private static void PHPELJICGMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class APBAPHEAKLD
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct DONDPCHAJOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TaskCompletionSource<Scene> BICEGINCAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly string OFICCEEBFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly LoadSceneMode FGBPEJFMNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool CANNKNKNGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7258F40", Offset = "0x7257540", VA = "0x187258F40")]
		public DONDPCHAJOL(TaskCompletionSource<Scene> DOBFIJDMMAG, string OFICCEEBFIG, LoadSceneMode FGBPEJFMNKP, bool CANNKNKNGIL, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct CJCOCACBJPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private DJJFGNEEIPJ<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x72542F0", Offset = "0x72528F0", VA = "0x1872542F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7254B90", Offset = "0x7253190", VA = "0x187254B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct BCLEICLKLPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7251D60", Offset = "0x7250360", VA = "0x187251D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7252080", Offset = "0x7250680", VA = "0x187252080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct LMOKDKDBBDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private DONDPCHAJOL <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7264FE0", Offset = "0x72635E0", VA = "0x187264FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7265390", Offset = "0x7263990", VA = "0x187265390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class OBBEINIICGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public EJMFGCNAEMH<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public OBBEINIICGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7267120", Offset = "0x7265720", VA = "0x187267120")]
		internal void DOPCHJABEEB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct NFPPJMNOEAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private OBBEINIICGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7265CD0", Offset = "0x72642D0", VA = "0x187265CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7266870", Offset = "0x7264E70", VA = "0x187266870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct HILHDHNCMJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7261CC0", Offset = "0x72602C0", VA = "0x187261CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72621A0", Offset = "0x72607A0", VA = "0x1872621A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct GHEPKJNBJKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7260360", Offset = "0x725E960", VA = "0x187260360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7260EB0", Offset = "0x725F4B0", VA = "0x187260EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ONDKKOCBJHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public ONDKKOCBJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7269BC0", Offset = "0x72681C0", VA = "0x187269BC0")]
		internal bool KMEOGMGPCIK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class ABPDMCKIGHE : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public NIIIJMDBGHD onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public ABPDMCKIGHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x724F3F0", Offset = "0x724D9F0", VA = "0x18724F3F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x724F010", Offset = "0x724D610", VA = "0x18724F010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x724F350", Offset = "0x724D950", VA = "0x18724F350")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x724F3A0", Offset = "0x724D9A0", VA = "0x18724F3A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class FHLBJOLHAKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public EJMFGCNAEMH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public FHLBJOLHAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x725D790", Offset = "0x725BD90", VA = "0x18725D790")]
		internal bool PPFCDABNEJH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x725D510", Offset = "0x725BB10", VA = "0x18725D510")]
		internal void OOGDEOOEJEA(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class KJFIOCDLMNL : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public EJMFGCNAEMH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private FHLBJOLHAKN <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public KJFIOCDLMNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x72643A0", Offset = "0x72629A0", VA = "0x1872643A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7264A20", Offset = "0x7263020", VA = "0x187264A20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly ICollection<string> LIAMDOGDGLJ;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static PGILFKJEHOF OCLBFKPBJAE;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static AsyncOperation CFINLPDJBPD;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static PGILFKJEHOF HCCGGBBNMBN;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static string DEOOBMPKCHL;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static ThreadPriority AILFNBPFAAA;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task PADCFCIBEEA;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static List<SceneInstance> EABBONPHNJC;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly Queue<DONDPCHAJOL> EPIEDBDAJJN;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static Task MHPCODELGJC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool JFGJOLECIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7251330", Offset = "0x724F930", VA = "0x187251330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool LLNOMEPHHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7251110", Offset = "0x724F710", VA = "0x187251110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool MDGGNNOILOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7251070", Offset = "0x724F670", VA = "0x187251070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool IGMNCFBOPLM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7250410", Offset = "0x724EA10", VA = "0x187250410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> OKDAKMFEPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7251550", Offset = "0x724FB50", VA = "0x187251550")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7250C90", Offset = "0x724F290", VA = "0x187250C90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x72507F0", Offset = "0x724EDF0", VA = "0x1872507F0")]
	[OCMIHKDDJOP(HMGNKNOCFNI.EnteredEditModeNextFrame, 0)]
	private static void FJEMOICBOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x72504A0", Offset = "0x724EAA0", VA = "0x1872504A0")]
	[AsyncStateMachine(typeof(CJCOCACBJPE))]
	public static Task<Scene> DEIFCEDCPMN(string OFICCEEBFIG, LoadSceneMode FGBPEJFMNKP = LoadSceneMode.Single, bool CANNKNKNGIL = false, [Optional] DJJFGNEEIPJ<string>.DIJMCCGECOP PHECCPKFBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7250360", Offset = "0x724E960", VA = "0x187250360")]
	[AsyncStateMachine(typeof(BCLEICLKLPB))]
	private static Task AAKOOMJDNKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7250A90", Offset = "0x724F090", VA = "0x187250A90")]
	[AsyncStateMachine(typeof(LMOKDKDBBDK))]
	private static Task GKNBPFJHPIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7251A20", Offset = "0x7250020", VA = "0x187251A20")]
	[AsyncStateMachine(typeof(NFPPJMNOEAI))]
	private static Task<Scene> PCLPEOLLJJM(string OFICCEEBFIG, LoadSceneMode FGBPEJFMNKP, bool CANNKNKNGIL, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x72505F0", Offset = "0x724EBF0", VA = "0x1872505F0")]
	private static void EHILOCIDDGP(SceneInstance MGNNEDNHDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7251820", Offset = "0x724FE20", VA = "0x187251820")]
	private static void OMBIJFPJIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7251700", Offset = "0x724FD00", VA = "0x187251700")]
	[AsyncStateMachine(typeof(HILHDHNCMJI))]
	private static Task<Scene> OILAPFDOPCN(string OFICCEEBFIG, LoadSceneMode FGBPEJFMNKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7250700", Offset = "0x724ED00", VA = "0x187250700")]
	private static bool EPIAHKKCBCJ(string OFICCEEBFIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x72508F0", Offset = "0x724EEF0", VA = "0x1872508F0")]
	[AsyncStateMachine(typeof(GHEPKJNBJKJ))]
	private static Task<Scene> GHHKAGLPIKM(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x72511B0", Offset = "0x724F7B0", VA = "0x1872511B0")]
	public static HCGNNEJAOHI<Scene> KGBCBMIMDBA(string OFICCEEBFIG, LoadSceneMode FGBPEJFMNKP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7250DA0", Offset = "0x724F3A0", VA = "0x187250DA0")]
	public static PGILFKJEHOF IMLDODKPCMC(string OFICCEEBFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7250A00", Offset = "0x724F000", VA = "0x187250A00")]
	[IteratorStateMachine(typeof(ABPDMCKIGHE))]
	private static IEnumerator<MBMMHILCGCA> GKKCFOLMKME(string OFICCEEBFIG, NIIIJMDBGHD LNBLKGGADAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7251660", Offset = "0x724FC60", VA = "0x187251660")]
	[IteratorStateMachine(typeof(KJFIOCDLMNL))]
	private static IEnumerator<MBMMHILCGCA> NKHMIGMDKEG(string OFICCEEBFIG, LoadSceneMode FGBPEJFMNKP, EJMFGCNAEMH<Scene> LNBLKGGADAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7250B60", Offset = "0x724F160", VA = "0x187250B60")]
	public static bool HDGIDNDBLMI([Out] string MJIEMBGJMAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DPNJOIPJMEB
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7259070", Offset = "0x7257670", VA = "0x187259070")]
	public static IDisposable IKNBPIALMPH(this NOMFKNGBIGI FFHIJMOJNAI, float LMENHCIHLHF, Action<float> EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7258FF0", Offset = "0x72575F0", VA = "0x187258FF0")]
	public static IDisposable IIPHGICCLED(this NOMFKNGBIGI FFHIJMOJNAI, Action<float> EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7259100", Offset = "0x7257700", VA = "0x187259100")]
	public static IDisposable MMHCFCMEIBM(this NOMFKNGBIGI FFHIJMOJNAI, Action<float> EPPBBINIJEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class FEKABHGDNFF
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x725D280", Offset = "0x725B880", VA = "0x18725D280")]
	public static IDisposable OPKCDKIHHBH(this MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x725D1F0", Offset = "0x725B7F0", VA = "0x18725D1F0")]
	public static IDisposable OPKCDKIHHBH(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x725D170", Offset = "0x725B770", VA = "0x18725D170")]
	public static IDisposable OMKLHJHPBJI(this MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x725D070", Offset = "0x725B670", VA = "0x18725D070")]
	public static IDisposable LKGMHCOOGEP(this MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x725CFF0", Offset = "0x725B5F0", VA = "0x18725CFF0")]
	public static IDisposable LKGMHCOOGEP(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x725CAB0", Offset = "0x725B0B0", VA = "0x18725CAB0")]
	public static IDisposable ELGCNFKCKBL(this MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x725D0F0", Offset = "0x725B6F0", VA = "0x18725D0F0")]
	public static IDisposable MDCDIFHCGNL(this MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x725CED0", Offset = "0x725B4D0", VA = "0x18725CED0")]
	public static IDisposable LBNGEFNPFLH(this MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x725D3C0", Offset = "0x725B9C0", VA = "0x18725D3C0")]
	public static IDisposable PGODHGIJKLA(this MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x725CC70", Offset = "0x725B270", VA = "0x18725CC70")]
	public static IDisposable HCLJKCELDLL(this MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x725C970", Offset = "0x725AF70", VA = "0x18725C970")]
	public static IDisposable BFPAACIFPAN(this MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x725CF50", Offset = "0x725B550", VA = "0x18725CF50")]
	public static IDisposable LFKKINCDHPI(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x725CBD0", Offset = "0x725B1D0", VA = "0x18725CBD0")]
	public static IDisposable GEADFDNCNJL(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x725CA10", Offset = "0x725B010", VA = "0x18725CA10")]
	public static IDisposable EIIJGJFENGC(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x725CE30", Offset = "0x725B430", VA = "0x18725CE30")]
	public static IDisposable KDOGPAMIOHK(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x725CB30", Offset = "0x725B130", VA = "0x18725CB30")]
	public static IDisposable FJBLBJDLOGG(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x725CD90", Offset = "0x725B390", VA = "0x18725CD90")]
	public static IDisposable IBGDBJEJKGF(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x725D470", Offset = "0x725BA70", VA = "0x18725D470")]
	public static IDisposable PMINPCAOFIL(this MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x725D310", Offset = "0x725B910", VA = "0x18725D310")]
	public static IDisposable PDFCFFBEFGN(this MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class AJGJNAAGGGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class JMIFAKBGIML : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public POIAJKHHOFJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private BPGLMBAJKED <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public JMIFAKBGIML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x72632E0", Offset = "0x72618E0", VA = "0x1872632E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x72633C0", Offset = "0x72619C0", VA = "0x1872633C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class AIHDBHABAOC : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public POIAJKHHOFJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private BPGLMBAJKED <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public AIHDBHABAOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x724FE70", Offset = "0x724E470", VA = "0x18724FE70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x724FF60", Offset = "0x724E560", VA = "0x18724FF60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x72501F0", Offset = "0x724E7F0", VA = "0x1872501F0")]
	public static JMPIHICOHFM OPKCDKIHHBH(Action EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x72502A0", Offset = "0x724E8A0", VA = "0x1872502A0")]
	public static JMPIHICOHFM OPKCDKIHHBH(Behaviour FFHIJMOJNAI, Action EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x72500D0", Offset = "0x724E6D0", VA = "0x1872500D0")]
	public static JMPIHICOHFM OPKCDKIHHBH(Behaviour FFHIJMOJNAI, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x724FFB0", Offset = "0x724E5B0", VA = "0x18724FFB0")]
	[IteratorStateMachine(typeof(JMIFAKBGIML))]
	private static IEnumerator<MBMMHILCGCA> FEIGFPHKPHJ(POIAJKHHOFJ EOICDCMLDHF, Action EPPBBINIJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7250040", Offset = "0x724E640", VA = "0x187250040")]
	[IteratorStateMachine(typeof(AIHDBHABAOC))]
	private static IEnumerator<MBMMHILCGCA> FEIGFPHKPHJ(POIAJKHHOFJ EOICDCMLDHF, Action<float> EPPBBINIJEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class HMDBLBJKOJC : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class LCDMNFBDOII : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public HMDBLBJKOJC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public LCDMNFBDOII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7264E10", Offset = "0x7263410", VA = "0x187264E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7264EA0", Offset = "0x72634A0", VA = "0x187264EA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly POIAJKHHOFJ ABGODCJAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Action MDECHCNAONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool GCGPNMHEIJB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EJHJFDECFOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x86CCF0", Offset = "0x86B2F0", VA = "0x18086CCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7262330", Offset = "0x7260930", VA = "0x187262330")]
	public HMDBLBJKOJC(POIAJKHHOFJ ABGODCJAPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7262210", Offset = "0x7260810", VA = "0x187262210")]
	[IteratorStateMachine(typeof(LCDMNFBDOII))]
	private IEnumerator<MBMMHILCGCA> APAEACBLEAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7262290", Offset = "0x7260890", VA = "0x187262290", Slot = "4")]
	public void OnCompleted(Action HGHEBPNBGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	public void JNNMANEJCPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class FNMJONPAPPO
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x725D810", Offset = "0x725BE10", VA = "0x18725D810")]
	public static HMDBLBJKOJC GCIDINGPBLA(this POIAJKHHOFJ ABGODCJAPHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class JONHGJIAFFP
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class NOJHEMDOGIC : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FBGBCEGFILK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public NOJHEMDOGIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7267050", Offset = "0x7265650", VA = "0x187267050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x72670D0", Offset = "0x72656D0", VA = "0x1872670D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x72636E0", Offset = "0x7261CE0", VA = "0x1872636E0")]
	public static JMPIHICOHFM OPKCDKIHHBH(float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x72637E0", Offset = "0x7261DE0", VA = "0x1872637E0")]
	public static JMPIHICOHFM OPKCDKIHHBH(MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x72635C0", Offset = "0x7261BC0", VA = "0x1872635C0")]
	public static JMPIHICOHFM LBPKOKDPNDO(MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x72638F0", Offset = "0x7261EF0", VA = "0x1872638F0")]
	public static JMPIHICOHFM PFGNLLKKBAI(NOMFKNGBIGI FFHIJMOJNAI, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7263410", Offset = "0x7261A10", VA = "0x187263410")]
	private static IEnumerator<MBMMHILCGCA> FEIGFPHKPHJ(BMLOLHIMKME BCCABDLFKFN, float LMENHCIHLHF, POIAJKHHOFJ EOICDCMLDHF, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x72634D0", Offset = "0x7261AD0", VA = "0x1872634D0")]
	private static IEnumerator<MBMMHILCGCA> GGDDIMOHAKJ(BMLOLHIMKME BCCABDLFKFN, float LMENHCIHLHF, POIAJKHHOFJ EOICDCMLDHF, Action<float> EPPBBINIJEA, bool OOAPIHAOEOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7263530", Offset = "0x7261B30", VA = "0x187263530")]
	[IteratorStateMachine(typeof(NOJHEMDOGIC))]
	private static IEnumerator<MBMMHILCGCA> INJEKMOLIPL(FBGBCEGFILK ACIDDFJMNKI, float LMENHCIHLHF, POIAJKHHOFJ EOICDCMLDHF, Action<float> EPPBBINIJEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class HGPPGFDFDNM
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class BGLLPDCDCGO : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public POIAJKHHOFJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public BGLLPDCDCGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x72520E0", Offset = "0x72506E0", VA = "0x1872520E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x72521A0", Offset = "0x72507A0", VA = "0x1872521A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7261B10", Offset = "0x7260110", VA = "0x187261B10")]
	[IteratorStateMachine(typeof(BGLLPDCDCGO))]
	private static IEnumerator<MBMMHILCGCA> KHDLINCOGOK(POIAJKHHOFJ ABGODCJAPHA, Func<bool> HENBCPJDKPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7261BA0", Offset = "0x72601A0", VA = "0x187261BA0")]
	public static JMPIHICOHFM OGNEFJEKNHN(this MonoBehaviour ALFBHFDIDMA, Func<bool> HENBCPJDKPD, POIAJKHHOFJ ABGODCJAPHA = POIAJKHHOFJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class AHFCKBLLFGO
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class JKKOJBKODCG : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public POIAJKHHOFJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public JKKOJBKODCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7262E70", Offset = "0x7261470", VA = "0x187262E70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7262EE0", Offset = "0x72614E0", VA = "0x187262EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class HAHCBPFFGCB : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public POIAJKHHOFJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private MBMMHILCGCA <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public HAHCBPFFGCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7261320", Offset = "0x725F920", VA = "0x187261320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x72613B0", Offset = "0x725F9B0", VA = "0x1872613B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x724F480", Offset = "0x724DA80", VA = "0x18724F480")]
	[IteratorStateMachine(typeof(JKKOJBKODCG))]
	private static IEnumerator<MBMMHILCGCA> APAEACBLEAP(float PJKHGIHPBDF, POIAJKHHOFJ EOICDCMLDHF, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x724F7D0", Offset = "0x724DDD0", VA = "0x18724F7D0")]
	[IteratorStateMachine(typeof(HAHCBPFFGCB))]
	private static IEnumerator<MBMMHILCGCA> IPDAILKCDGD(float PJKHGIHPBDF, POIAJKHHOFJ EOICDCMLDHF, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x724FB40", Offset = "0x724E140", VA = "0x18724FB40")]
	public static IDisposable MACFKKMADCC(this MonoBehaviour ALFBHFDIDMA, float PJKHGIHPBDF, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x724FC60", Offset = "0x724E260", VA = "0x18724FC60")]
	public static JMPIHICOHFM NAPEOPPINMK(this MonoBehaviour ALFBHFDIDMA, float PJKHGIHPBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x724FA10", Offset = "0x724E010", VA = "0x18724FA10")]
	public static JMPIHICOHFM MACFKKMADCC(this MonoBehaviour ALFBHFDIDMA, float PJKHGIHPBDF, POIAJKHHOFJ EOICDCMLDHF, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x724FD50", Offset = "0x724E350", VA = "0x18724FD50")]
	public static JMPIHICOHFM OOJHIBALHKL(this MonoBehaviour ALFBHFDIDMA, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x724FD20", Offset = "0x724E320", VA = "0x18724FD20")]
	public static JMPIHICOHFM OLKMEFOKLNH(this MonoBehaviour ALFBHFDIDMA, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x724F5F0", Offset = "0x724DBF0", VA = "0x18724F5F0")]
	public static JMPIHICOHFM BEFOLGKBAFJ(this MonoBehaviour ALFBHFDIDMA, Action LHGGEBICOGB, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x724F7A0", Offset = "0x724DDA0", VA = "0x18724F7A0")]
	public static JMPIHICOHFM FCLCLGKCNIM(this MonoBehaviour ALFBHFDIDMA, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x724FE40", Offset = "0x724E440", VA = "0x18724FE40")]
	public static JMPIHICOHFM PCOANGIPMLB(this MonoBehaviour ALFBHFDIDMA, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x724F520", Offset = "0x724DB20", VA = "0x18724F520")]
	private static JMPIHICOHFM BBCKCKEEHJG(MonoBehaviour ALFBHFDIDMA, POIAJKHHOFJ ABGODCJAPHA, Action LHGGEBICOGB, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x724F940", Offset = "0x724DF40", VA = "0x18724F940")]
	public static JMPIHICOHFM KOAGCPNCBCA(this MonoBehaviour ALFBHFDIDMA, float NCHEHAPAHDM, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x724F870", Offset = "0x724DE70", VA = "0x18724F870")]
	public static JMPIHICOHFM JOAIFNGNBMH(this MonoBehaviour ALFBHFDIDMA, float NCHEHAPAHDM, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x724F6D0", Offset = "0x724DCD0", VA = "0x18724F6D0")]
	public static JMPIHICOHFM EIBHPKFMKKE(this MonoBehaviour ALFBHFDIDMA, float NCHEHAPAHDM, Action LHGGEBICOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x724FD70", Offset = "0x724E370", VA = "0x18724FD70")]
	public static JMPIHICOHFM OPEIACFCBKE(this MonoBehaviour ALFBHFDIDMA, float NCHEHAPAHDM, Action LHGGEBICOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class EPIMMOONMHF : MLJHNPOFEEC, IEnumerable<MLJHNPOFEEC>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly List<MLJHNPOFEEC> NCHBKHPFNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool FKABMAGFMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Action FIBNOLMIECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool PEIPGBGOAME;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IFHNLDJJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x725B3D0", Offset = "0x72599D0", VA = "0x18725B3D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OIPHHAKLFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x725B710", Offset = "0x7259D10", VA = "0x18725B710", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x725B670", Offset = "0x7259C70", VA = "0x18725B670", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x725BC80", Offset = "0x725A280", VA = "0x18725BC80")]
	public EPIMMOONMHF([Optional] Action FIBNOLMIECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x725BB50", Offset = "0x725A150", VA = "0x18725BB50")]
	public void MJFEDCBJOBF(MLJHNPOFEEC MCONODJLCLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x725B510", Offset = "0x7259B10", VA = "0x18725B510")]
	private void CJOJDMKEEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x725B7B0", Offset = "0x7259DB0", VA = "0x18725B7B0", Slot = "7")]
	public bool FAFNFBEBOHM(bool BAKDLGCFEEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x725B7C0", Offset = "0x7259DC0", VA = "0x18725B7C0", Slot = "8")]
	public bool FAFNFBEBOHM(Action OGLJLDNLGIJ, bool BAKDLGCFEEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x725BAD0", Offset = "0x725A0D0", VA = "0x18725BAD0", Slot = "9")]
	public IEnumerator<MLJHNPOFEEC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x725BAD0", Offset = "0x725A0D0", VA = "0x18725BAD0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HNJCMFDMOIM : KCGEKOMMBKF
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class BLALDKFENKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public HNJCMFDMOIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public BLALDKFENKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x72521F0", Offset = "0x72507F0", VA = "0x1872521F0")]
		internal void OMLLOHLPHCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class OBHALJNLMJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public HNJCMFDMOIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public OBHALJNLMJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x72521F0", Offset = "0x72507F0", VA = "0x1872521F0")]
		internal void HKEHKCJMLCC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly float PDLIJJIPHFN;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7262660", Offset = "0x7260C60", VA = "0x187262660")]
	public HNJCMFDMOIM(Behaviour FFHIJMOJNAI, float PDLIJJIPHFN, [Optional] Action FIBNOLMIECG, [Optional] PHAHKEIGJGJ GMONHBOKFFJ, [Optional] BMLOLHIMKME BCCABDLFKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7262440", Offset = "0x7260A40", VA = "0x187262440", Slot = "9")]
	protected override bool AIFEKFHFLAO(Action OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7262550", Offset = "0x7260B50", VA = "0x187262550", Slot = "10")]
	protected override bool NCDLLACMBAA(Action OGLJLDNLGIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface MLJHNPOFEEC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IFHNLDJJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OIPHHAKLFKI;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FAFNFBEBOHM(bool BAKDLGCFEEB = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FAFNFBEBOHM(Action OGLJLDNLGIJ, bool BAKDLGCFEEB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class KCGEKOMMBKF : MLJHNPOFEEC
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class OLCPDCDFINF : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public KCGEKOMMBKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public OLCPDCDFINF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7269AA0", Offset = "0x72680A0", VA = "0x187269AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7269B70", Offset = "0x7268170", VA = "0x187269B70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Behaviour FFHIJMOJNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action FIBNOLMIECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private PGGFJFHOMCP NIDNOGMFDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly PHAHKEIGJGJ GMONHBOKFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	protected readonly BMLOLHIMKME BCCABDLFKFN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool IFHNLDJJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xE956A0", Offset = "0xE93CA0", VA = "0x180E956A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OIPHHAKLFKI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7263D00", Offset = "0x7262300", VA = "0x187263D00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7263A20", Offset = "0x7262020", VA = "0x187263A20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7263FB0", Offset = "0x72625B0", VA = "0x187263FB0")]
	protected KCGEKOMMBKF(Behaviour FFHIJMOJNAI, [Optional] Action FIBNOLMIECG, [Optional] PHAHKEIGJGJ GMONHBOKFFJ, [Optional] BMLOLHIMKME BCCABDLFKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7263DA0", Offset = "0x72623A0", VA = "0x187263DA0", Slot = "7")]
	public bool FAFNFBEBOHM(bool BAKDLGCFEEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7263E00", Offset = "0x7262400", VA = "0x187263E00", Slot = "8")]
	public bool FAFNFBEBOHM(Action OGLJLDNLGIJ, bool BAKDLGCFEEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool AIFEKFHFLAO(Action OGLJLDNLGIJ);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NCDLLACMBAA(Action OGLJLDNLGIJ);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7263A00", Offset = "0x7262000", VA = "0x187263A00")]
	protected void DBBBALFMDIE(Action OGLJLDNLGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7263AC0", Offset = "0x72620C0", VA = "0x187263AC0")]
	protected PGILFKJEHOF EAMFGLLALFO(float DACHNPNJPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7263E60", Offset = "0x7262460", VA = "0x187263E60")]
	private void FDPMCOJADKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7263EE0", Offset = "0x72624E0", VA = "0x187263EE0")]
	[IteratorStateMachine(typeof(OLCPDCDFINF))]
	private IEnumerator<MBMMHILCGCA> JOCCILCCONM(float DACHNPNJPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7263F70", Offset = "0x7262570", VA = "0x187263F70")]
	[CompilerGenerated]
	private void OIAJOCNNHJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class HBIPIDOMMCO : KCGEKOMMBKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float APGGJODKGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly int BNALDMCHBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float DNKCMGGCPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly float[] JNPLIGPMEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int BCIBHALJBGC;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7261680", Offset = "0x725FC80", VA = "0x187261680")]
	public HBIPIDOMMCO(Behaviour FFHIJMOJNAI, float DNHPDLIPPEC, int BNALDMCHBDE, [Optional] Action FIBNOLMIECG, float DNKCMGGCPBO = 0f, [Optional] PHAHKEIGJGJ GMONHBOKFFJ, [Optional] BMLOLHIMKME BCCABDLFKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "9")]
	protected override bool AIFEKFHFLAO(Action OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7261480", Offset = "0x725FA80", VA = "0x187261480", Slot = "10")]
	protected override bool NCDLLACMBAA(Action OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7261400", Offset = "0x725FA00", VA = "0x187261400")]
	private void LMEKNPFAAJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class IPOFMJHMIFJ : KCGEKOMMBKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly float PDLIJJIPHFN;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7262660", Offset = "0x7260C60", VA = "0x187262660")]
	public IPOFMJHMIFJ(Behaviour FFHIJMOJNAI, float PDLIJJIPHFN, [Optional] Action FIBNOLMIECG, [Optional] PHAHKEIGJGJ GMONHBOKFFJ, [Optional] BMLOLHIMKME BCCABDLFKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "9")]
	protected override bool AIFEKFHFLAO(Action OGLJLDNLGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7262910", Offset = "0x7260F10", VA = "0x187262910", Slot = "10")]
	protected override bool NCDLLACMBAA(Action OGLJLDNLGIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class NMLFBICECBA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class EIEEGGECHFI : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public EIEEGGECHFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x725B110", Offset = "0x7259710", VA = "0x18725B110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x725B180", Offset = "0x7259780", VA = "0x18725B180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private JMPIHICOHFM EOPOOMBHLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private NOMFKNGBIGI FFHIJMOJNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Action<float> GDIIEFHNABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private POIAJKHHOFJ ABGODCJAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float EMFKOFNBIIO;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7266E70", Offset = "0x7265470", VA = "0x187266E70")]
	public NMLFBICECBA(NOMFKNGBIGI FFHIJMOJNAI, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7266AA0", Offset = "0x72650A0", VA = "0x187266AA0")]
	private void GLFHFFIFDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72668E0", Offset = "0x7264EE0", VA = "0x1872668E0")]
	private void CIIEOFHEDPK(string JCBCIJOKIDD, Action EKKBEDNDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7266C40", Offset = "0x7265240", VA = "0x187266C40")]
	[IteratorStateMachine(typeof(EIEEGGECHFI))]
	private IEnumerator<MBMMHILCGCA> JLJJBLPOBPN(Action EKKBEDNDPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7266A40", Offset = "0x7265040", VA = "0x187266A40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7266CC0", Offset = "0x72652C0", VA = "0x187266CC0")]
	[CompilerGenerated]
	private void ONOKOJILGLP(string PHPBNDIBHHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class EABEBENHMGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class GBBOHEMMGNC : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public GBBOHEMMGNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x725B110", Offset = "0x7259710", VA = "0x18725B110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x725D950", Offset = "0x725BF50", VA = "0x18725D950", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private JMPIHICOHFM EOPOOMBHLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private MonoBehaviour ALFBHFDIDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action EPPBBINIJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Action<float> GDIIEFHNABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private POIAJKHHOFJ ABGODCJAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float EMFKOFNBIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool OOAPIHAOEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly PHAHKEIGJGJ GMONHBOKFFJ;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x725A220", Offset = "0x7258820", VA = "0x18725A220")]
	public EABEBENHMGE(MonoBehaviour ALFBHFDIDMA, Action EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7259D90", Offset = "0x7258390", VA = "0x187259D90")]
	public EABEBENHMGE(MonoBehaviour ALFBHFDIDMA, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7259FD0", Offset = "0x72585D0", VA = "0x187259FD0")]
	public EABEBENHMGE(MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1BE86F0", Offset = "0x1BE6CF0", VA = "0x181BE86F0")]
	private EABEBENHMGE(PHAHKEIGJGJ GMONHBOKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7259C60", Offset = "0x7258260", VA = "0x187259C60")]
	internal static EABEBENHMGE PJLANIPMFMC(MonoBehaviour ALFBHFDIDMA, float LMENHCIHLHF, Action<float> EPPBBINIJEA, POIAJKHHOFJ ABGODCJAPHA, bool OOAPIHAOEOP = true, [Optional] PHAHKEIGJGJ GMONHBOKFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7259AF0", Offset = "0x72580F0", VA = "0x187259AF0")]
	private void OPKCDKIHHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x72598C0", Offset = "0x7257EC0", VA = "0x1872598C0")]
	private void JDJCAFDPFBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7259680", Offset = "0x7257C80", VA = "0x187259680")]
	private void GLFHFFIFDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7259180", Offset = "0x7257780", VA = "0x187259180")]
	private void ABFHLHBLKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7259460", Offset = "0x7257A60", VA = "0x187259460")]
	private void CIIEOFHEDPK(string JCBCIJOKIDD, Action EKKBEDNDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7259A70", Offset = "0x7258070", VA = "0x187259A70")]
	[IteratorStateMachine(typeof(GBBOHEMMGNC))]
	private IEnumerator<MBMMHILCGCA> JLJJBLPOBPN(Action EKKBEDNDPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7259620", Offset = "0x7257C20", VA = "0x187259620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x72593D0", Offset = "0x72579D0", VA = "0x1872593D0")]
	[CompilerGenerated]
	private void BNOELEILCJE(string PHPBNDIBHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7259590", Offset = "0x7257B90", VA = "0x187259590")]
	[CompilerGenerated]
	private void DOCNLADKLCL(string PHPBNDIBHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7259830", Offset = "0x7257E30", VA = "0x187259830")]
	[CompilerGenerated]
	private void GMGJGJFEPKK(string PHPBNDIBHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7259340", Offset = "0x7257940", VA = "0x187259340")]
	[CompilerGenerated]
	private void AMDGMOIPKGD(string PHPBNDIBHHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Flags]
internal enum HEOMPEGLDNI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal sealed class CBMBAFFKFGH : BMLOLHIMKME
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float HBOJBHGLLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7252690", Offset = "0x7250C90", VA = "0x187252690", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float AIFANPKCABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7252660", Offset = "0x7250C60", VA = "0x187252660", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double HMNOFLLLMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7252670", Offset = "0x7250C70", VA = "0x187252670", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x72526A0", Offset = "0x7250CA0", VA = "0x1872526A0")]
	[PECFDJPHGEK(BOIKMOKIOJG.None)]
	private static void JEEKJHILOBP(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	[Preserve]
	internal CBMBAFFKFGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface LJDCLHBNMPG
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAHFFFCPNDL(string LCLKDNPLMED);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBHDLPEFIDE();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal interface JMBNHIKJBKN
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool CJMHCJFHMME
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool IBEKAMBLKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class EALAONFAEDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public GDNBBGNPPJN GICCHOIEBIG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int FPNFNABMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8621A0", Offset = "0x8607A0", VA = "0x1808621A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x867850", Offset = "0x865E50", VA = "0x180867850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x725A8D0", Offset = "0x7258ED0", VA = "0x18725A8D0")]
	public static MBMMHILCGCA HDKCHGBCFEN(IEnumerator<MBMMHILCGCA> CBONFMNDCJK, DLOFNHFJPBN JKOLNABNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x725AA30", Offset = "0x7259030", VA = "0x18725AA30")]
	public MBMMHILCGCA HDKCHGBCFEN(DLOFNHFJPBN[] PMDJJOCJMFO, IEnumerator<MBMMHILCGCA>[] BMDFPKKOCFC, MBMMHILCGCA[] ACFMNBKNJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x725A8A0", Offset = "0x7258EA0", VA = "0x18725A8A0")]
	public void POBGAHCJDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x725A620", Offset = "0x7258C20", VA = "0x18725A620")]
	public void BEDCDAPBNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x725A760", Offset = "0x7258D60", VA = "0x18725A760")]
	public void EEFFIKIAGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x725A8A0", Offset = "0x7258EA0", VA = "0x18725A8A0")]
	public void GLLCMOEOPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public EALAONFAEDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class GDNBBGNPPJN
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct NJEBAGGJBCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public EALAONFAEDG MAICJLFLLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public NOMFKNGBIGI NMINIDOGFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public DLOFNHFJPBN MNJFGJFFNIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<MBMMHILCGCA> BIIHFPKCPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public MBMMHILCGCA OONPBJJAJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public HEOMPEGLDNI NFELHMENFLH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct OCBEPLDHOGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public POIAJKHHOFJ OEHEBEJLCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<NJEBAGGJBCG> AMNGNILMJPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class CIMGJJJEOEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public DLOFNHFJPBN promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public GDNBBGNPPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public NOMFKNGBIGI context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public EALAONFAEDG routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public HEOMPEGLDNI coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public MBMMHILCGCA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<MBMMHILCGCA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public CIMGJJJEOEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7253B40", Offset = "0x7252140", VA = "0x187253B40")]
		internal void LEIBNGAPOPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class MALGOCJMJMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public EALAONFAEDG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public GDNBBGNPPJN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public MALGOCJMJMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x72653F0", Offset = "0x72639F0", VA = "0x1872653F0")]
		internal void ELJBHEDEHHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class DAMEGPJJAFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public EALAONFAEDG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public GDNBBGNPPJN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DAMEGPJJAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7258B70", Offset = "0x7257170", VA = "0x187258B70")]
		internal void OHALHOKGKKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class EABLHJODMCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public EALAONFAEDG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public GDNBBGNPPJN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public EABLHJODMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x725A410", Offset = "0x7258A10", VA = "0x18725A410")]
		internal void DKHDHODBDLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const HEOMPEGLDNI LKKFNAEIBLL = HEOMPEGLDNI.Cancelled | HEOMPEGLDNI.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly POIAJKHHOFJ ABGODCJAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] KJJMONGHDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<HEOMPEGLDNI> ODHGLBEAFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> CHCFNOGJPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> BPAHBOAIFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> NCMGHMNFDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> PHKHMNDINJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> GDGNHAHBFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> HGHCIFLIBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private EALAONFAEDG[] GFACDPAFDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private DLOFNHFJPBN[] PMDJJOCJMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NOMFKNGBIGI[] MFGNPKJMJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<MBMMHILCGCA>[] HEALNBJDCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private MBMMHILCGCA[] NDJMEOIJHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int MIHMAFODPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int NAFKLJDAKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int MFMBBAGJHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float IDFGDOGEPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private OGELMGGMAKD FOLAANIGOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle CCDBIPPMFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<EALAONFAEDG> BLNPPCJCAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool GJMDPPENLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> AOIPHFIEKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> GOOOIKAMHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool MEAEDBMMGIE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public OCBEPLDHOGC[] EFNAJMNNAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8CE2E0", Offset = "0x8CC8E0", VA = "0x1808CE2E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x725FCE0", Offset = "0x725E2E0", VA = "0x18725FCE0")]
	private static int PPOHFPFFKPG(POIAJKHHOFJ ABGODCJAPHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x725FD10", Offset = "0x725E310", VA = "0x18725FD10")]
	public GDNBBGNPPJN(POIAJKHHOFJ ABGODCJAPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x725E750", Offset = "0x725CD50", VA = "0x18725E750")]
	private void LIBIPBMOOFN(int FIFGOHECGBE, int KGFHFFLKOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x725EB90", Offset = "0x725D190", VA = "0x18725EB90")]
	public void MJLPBGGONDI(NOMFKNGBIGI FFHIJMOJNAI, MBMMHILCGCA CILENLNLFKO, IEnumerator<MBMMHILCGCA> CBONFMNDCJK, DLOFNHFJPBN JKOLNABNIDN, [Optional] EALAONFAEDG OPOFFHABDLG, HEOMPEGLDNI OMDNJIBGMHH = HEOMPEGLDNI.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x725FAA0", Offset = "0x725E0A0", VA = "0x18725FAA0")]
	public void PHEGOHBAODL(IEnumerable<NJEBAGGJBCG> LAOHKBDNJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x725F5D0", Offset = "0x725DBD0", VA = "0x18725F5D0")]
	private NJEBAGGJBCG OLBNHMDNNDP(int GOFFGLCJLID)
	{
		return default(NJEBAGGJBCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x725DC00", Offset = "0x725C200", VA = "0x18725DC00")]
	private void HAAJPEBDKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2AFE520", Offset = "0x2AFCB20", VA = "0x182AFE520")]
	private static void CDFIMMDKABK<T>(int GOFFGLCJLID, T[] JNFJFDAHKFH, int ENCFHCJIMBE, [Optional] T JMLMBGDCFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2AFE570", Offset = "0x2AFCB70", VA = "0x182AFE570")]
	private static void CDFIMMDKABK<T>(int GOFFGLCJLID, NativeArray<T> JNFJFDAHKFH, int ENCFHCJIMBE, [Optional] T JMLMBGDCFJK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x725E0A0", Offset = "0x725C6A0", VA = "0x18725E0A0")]
	private void JANEFIIBGBP(IEnumerable<NJEBAGGJBCG> LAOHKBDNJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x725F510", Offset = "0x725DB10", VA = "0x18725F510")]
	private void OHNGOKOIPMA(NJEBAGGJBCG HFDOHCDJOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x725E930", Offset = "0x725CF30", VA = "0x18725E930")]
	private AILGIIDBLKP LOJBDDBBGMB(int OIFKFFCKOBP)
	{
		return default(AILGIIDBLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x725E4D0", Offset = "0x725CAD0", VA = "0x18725E4D0")]
	public void KBHFBFJEGDF(float AAEDJKLCPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x725E450", Offset = "0x725CA50", VA = "0x18725E450")]
	private void KBHCKDMOBNJ(Action FAGKOOGCGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x725E6D0", Offset = "0x725CCD0", VA = "0x18725E6D0")]
	private void KLIEEFOJKGD(Action FAGKOOGCGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x725ED10", Offset = "0x725D310", VA = "0x18725ED10")]
	public void MKPLCEADAAI(float AAEDJKLCPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x725F410", Offset = "0x725DA10", VA = "0x18725F410")]
	public void NNOPBDMPMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x725DAD0", Offset = "0x725C0D0", VA = "0x18725DAD0")]
	public void GLLCMOEOPNM(EALAONFAEDG ACIDDFJMNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x725D9A0", Offset = "0x725BFA0", VA = "0x18725D9A0")]
	public void CKKMJBCNBFC(EALAONFAEDG ACIDDFJMNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x725DF70", Offset = "0x725C570", VA = "0x18725DF70")]
	public void HCGMNNKLNBG(EALAONFAEDG ACIDDFJMNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class DGGAGGBIDOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly DGGAGGBIDOK BHJAMJDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Action DPHFDCIPJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private bool KIHONPKCMEM;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	public DGGAGGBIDOK(Action DPHFDCIPJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F040", Offset = "0x6A0D640", VA = "0x186A0F040", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface GGPKCLFLNGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T BLBBIKKJHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PJPIMECKACI(UnityEngine.Object FFHIJMOJNAI, Action<T> NIJPIJMMBPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface IHDIJKOCAHH<T> : GGPKCLFLNGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T BLBBIKKJHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class CABANDNIAMG<T> : IHDIJKOCAHH<T>, GGPKCLFLNGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class CGHKDOKGNNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public CABANDNIAMG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public KKCDLHKOFNI<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public CGHKDOKGNNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5152890", Offset = "0x5150E90", VA = "0x185152890")]
		internal void BJHININKKHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static GameObject HIAGKILEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<KKCDLHKOFNI<UnityEngine.Object, Action<T>>> JGAIBPNFHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T OMFCIIMEOKA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T BLBBIKKJHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x92FCA0", Offset = "0x92E2A0", VA = "0x18092FCA0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4F5ACF0", Offset = "0x4F592F0", VA = "0x184F5ACF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4F5AC20", Offset = "0x4F59220", VA = "0x184F5AC20")]
	private static bool AHJCIFFFBKD(T FAGKOOGCGBH, T HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4F5B950", Offset = "0x4F59F50", VA = "0x184F5B950")]
	public CABANDNIAMG(T NLGAOHMJLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4F5B6C0", Offset = "0x4F59CC0", VA = "0x184F5B6C0", Slot = "6")]
	public IDisposable PJPIMECKACI(UnityEngine.Object FFHIJMOJNAI, Action<T> NIJPIJMMBPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F5AE60", Offset = "0x4F59460", VA = "0x184F5AE60")]
	private void JPKFMOGMOPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal class CKDPLKKLPNM : LHLNMHMMNBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly PHAHKEIGJGJ GMONHBOKFFJ;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7254CB0", Offset = "0x72532B0", VA = "0x187254CB0")]
	[PECFDJPHGEK(BOIKMOKIOJG.None)]
	private static void JEEKJHILOBP(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	[Preserve]
	internal CKDPLKKLPNM([JFHFHOOOEKP(null)] PHAHKEIGJGJ GMONHBOKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7254C00", Offset = "0x7253200", VA = "0x187254C00", Slot = "4")]
	public IDisposable BFPAACIFPAN(float LMENHCIHLHF, Action<float> AHJILKLLLDE, bool OOAPIHAOEOP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class FEFPHGHDKNH : CGLJOODMFEB, PHAHKEIGJGJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private GDNBBGNPPJN[] MIJEKBIENCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private LJDCLHBNMPG GLJCGMFECFP;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x725C0C0", Offset = "0x725A6C0", VA = "0x18725C0C0")]
	[PECFDJPHGEK(BOIKMOKIOJG.None)]
	private static void JEEKJHILOBP(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x725C8B0", Offset = "0x725AEB0", VA = "0x18725C8B0")]
	[Preserve]
	public FEFPHGHDKNH([JFHFHOOOEKP(null)] NILKNAMLKCJ EJLDPBDMOIB, [JFHFHOOOEKP(null)] BMLOLHIMKME BCCABDLFKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x725C480", Offset = "0x725AA80", VA = "0x18725C480", Slot = "16")]
	public override JMPIHICOHFM OGMIMPFANOG(NOMFKNGBIGI FFHIJMOJNAI, IEnumerator<MBMMHILCGCA> HIHCMGCDADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x725BD80", Offset = "0x725A380", VA = "0x18725BD80", Slot = "17")]
	public override void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x725C250", Offset = "0x725A850", VA = "0x18725C250", Slot = "19")]
	public override void NPHKMFMBBAB(POIAJKHHOFJ ABGODCJAPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x725C5B0", Offset = "0x725ABB0", VA = "0x18725C5B0", Slot = "18")]
	protected override void OMKLHJHPBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x725C090", Offset = "0x725A690", VA = "0x18725C090")]
	private GDNBBGNPPJN JANMNIOAMDK(POIAJKHHOFJ PBLNJHEPKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x725C680", Offset = "0x725AC80", VA = "0x18725C680", Slot = "20")]
	internal override MNDHMAOELEJ ONGGHBFLGLK(IEnumerator<MBMMHILCGCA> HIHCMGCDADP, Behaviour FFHIJMOJNAI, DLOFNHFJPBN JKOLNABNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x725C010", Offset = "0x725A610", VA = "0x18725C010", Slot = "21")]
	internal override OBBFNJOINKO FDLCFKEBGIH(POIAJKHHOFJ EOICDCMLDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x725C130", Offset = "0x725A730", VA = "0x18725C130")]
	private void MJJINEOBLAN(GDNBBGNPPJN DPLJPFDFONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x725BD20", Offset = "0x725A320", VA = "0x18725BD20", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[BurstCompile]
internal struct OGELMGGMAKD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public float LCKAANELJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public int NPPNBDBMMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> PHCKJPMBIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> APIACBADCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NativeArray<int> FICLDMPGLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<HEOMPEGLDNI> IKDOOMJJLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[ReadOnly]
	public NativeArray<float> PALLOCMLIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> PHKHMNDINJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[WriteOnly]
	public NativeArray<int> BPAHBOAIFOE;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7269660", Offset = "0x7267C60", VA = "0x187269660")]
	public static OGELMGGMAKD GIGNPOIHFIA(int CDJGPLLGAEP, float AAEDJKLCPHK, NativeArray<HEOMPEGLDNI> COCFMHLECBF, NativeArray<float> OIGDCCPFNMD, NativeArray<int> MGDKIDAIKBG, NativeArray<int> BDGCJABMNEH, NativeArray<int> NIDGFHHBGHA, NativeArray<int> APIACBADCBP, NativeArray<int> FICLDMPGLKF)
	{
		return default(OGELMGGMAKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7269340", Offset = "0x7267940", VA = "0x187269340", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7269860", Offset = "0x7267E60", VA = "0x187269860")]
	private bool PPDIIKNJCFP(int LLPJHIPCNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7269830", Offset = "0x7267E30", VA = "0x187269830")]
	private void ONOIHHNOPCL(NativeArray<int> HGHEGKPMBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7269790", Offset = "0x7267D90", VA = "0x187269790")]
	private int MEIEABEILCG(int JAFBPHKHNOE, int DMCPHEILHHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x72696C0", Offset = "0x7267CC0", VA = "0x1872696C0")]
	private void MCAOLAIBMCI(NativeArray<int> HGHEGKPMBJK, int MNLHINLGMCM, int LJNBPEFJOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7269420", Offset = "0x7267A20", VA = "0x187269420")]
	private void GBHJMJHDOJO(NativeArray<int> HGHEGKPMBJK, int LFMHBNAJLAF, int FMMLEBDABGO, int PAMLKHMHDMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public abstract class CGLJOODMFEB : PHAHKEIGJGJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly NILKNAMLKCJ EJLDPBDMOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected readonly BMLOLHIMKME BCCABDLFKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private OBBFNJOINKO[] PCHLOPAPNFG;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static PHAHKEIGJGJ IBMHAACFGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7252E40", Offset = "0x7251440", VA = "0x187252E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool LMMCDOJHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public POIAJKHHOFJ DGCDKIOHFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8621A0", Offset = "0x8607A0", VA = "0x1808621A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(POIAJKHHOFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x867850", Offset = "0x865E50", VA = "0x180867850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public BMLOLHIMKME PGHKMMEIFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MBMMHILCGCA ICDDKLGLANM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7252D50", Offset = "0x7251350", VA = "0x187252D50")]
	public static JMPIHICOHFM FLCLENEBNDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7253650", Offset = "0x7251C50", VA = "0x187253650")]
	[Preserve]
	protected CGLJOODMFEB([JFHFHOOOEKP(null)] NILKNAMLKCJ EJLDPBDMOIB, [JFHFHOOOEKP(null)] BMLOLHIMKME BCCABDLFKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7252F20", Offset = "0x7251520", VA = "0x187252F20", Slot = "6")]
	public JMPIHICOHFM JGBGEMHOKIJ(IEnumerator<MBMMHILCGCA> HIHCMGCDADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7252F30", Offset = "0x7251530", VA = "0x187252F30", Slot = "7")]
	public JMPIHICOHFM JGBGEMHOKIJ(Behaviour FFHIJMOJNAI, IEnumerator<MBMMHILCGCA> HIHCMGCDADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract JMPIHICOHFM OGMIMPFANOG(NOMFKNGBIGI FFHIJMOJNAI, IEnumerator<MBMMHILCGCA> HIHCMGCDADP);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7252B90", Offset = "0x7251190", VA = "0x187252B90", Slot = "17")]
	public virtual void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x72533F0", Offset = "0x72519F0", VA = "0x1872533F0", Slot = "9")]
	public void OFCJLMJLKKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7253630", Offset = "0x7251C30", VA = "0x187253630", Slot = "18")]
	protected virtual void OMKLHJHPBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7252710", Offset = "0x7250D10", VA = "0x187252710")]
	private void BBPPNPAHDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7252790", Offset = "0x7250D90", VA = "0x187252790")]
	private void CCEJMMCIFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7253320", Offset = "0x7251920", VA = "0x187253320")]
	private void LKGMHCOOGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7252B70", Offset = "0x7251170", VA = "0x187252B70")]
	private void ELGCNFKCKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7253130", Offset = "0x7251730", VA = "0x187253130")]
	private void JHLAKLOLGOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7252D30", Offset = "0x7251330", VA = "0x187252D30")]
	private void FGGPIOMEFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7253340", Offset = "0x7251940", VA = "0x187253340")]
	private void NPHFIEBPGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7253360", Offset = "0x7251960", VA = "0x187253360", Slot = "19")]
	public virtual void NPHKMFMBBAB(POIAJKHHOFJ ABGODCJAPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7253150", Offset = "0x7251750", VA = "0x187253150")]
	private void KOMOCBFLMPP(OBBFNJOINKO DPLJPFDFONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5660", Offset = "0x1EB3C60", VA = "0x181EB5660")]
	private OBBFNJOINKO GDAGLJGCFMB(POIAJKHHOFJ PBLNJHEPKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract MNDHMAOELEJ ONGGHBFLGLK(IEnumerator<MBMMHILCGCA> HIHCMGCDADP, Behaviour ALFBHFDIDMA, DLOFNHFJPBN BEPJFCOKLOO);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract OBBFNJOINKO FDLCFKEBGIH(POIAJKHHOFJ ABGODCJAPHA);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x72527B0", Offset = "0x7250DB0", VA = "0x1872527B0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7252DE0", Offset = "0x72513E0", VA = "0x187252DE0", Slot = "12")]
	public MBMMHILCGCA IHDPHIPONEE(POIAJKHHOFJ EOICDCMLDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7252E90", Offset = "0x7251490", VA = "0x187252E90", Slot = "13")]
	public MBMMHILCGCA JEMCCEEABGA(float PJKHGIHPBDF, POIAJKHHOFJ EOICDCMLDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7252730", Offset = "0x7250D30", VA = "0x187252730", Slot = "14")]
	public MBMMHILCGCA BPBIPPOBJMA(Func<bool> HENBCPJDKPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class MNDHMAOELEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly DLOFNHFJPBN JKOLNABNIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly JMBNHIKJBKN FFHIJMOJNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly bool KNINPEMGJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private string LCLKDNPLMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private StackTrace INABEHJJLFH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<MBMMHILCGCA> BIIHFPKCPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8657E0", Offset = "0x863DE0", VA = "0x1808657E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public MBMMHILCGCA OONPBJJAJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x864DF0", Offset = "0x8633F0", VA = "0x180864DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool EKPFPHOBPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x72659B0", Offset = "0x7263FB0", VA = "0x1872659B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool MIIALFKIIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9F18B0", Offset = "0x9EFEB0", VA = "0x1809F18B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9F19D0", Offset = "0x9EFFD0", VA = "0x1809F19D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7265430", Offset = "0x7263A30", VA = "0x187265430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float AGPEHOBKAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8CE590", Offset = "0x8CCB90", VA = "0x1808CE590")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCF10", Offset = "0x5EDB510", VA = "0x185EDCF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7265B10", Offset = "0x7264110", VA = "0x187265B10")]
	public MNDHMAOELEJ(IEnumerator<MBMMHILCGCA> CBONFMNDCJK, JMBNHIKJBKN FFHIJMOJNAI, DLOFNHFJPBN JKOLNABNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7265630", Offset = "0x7263C30", VA = "0x187265630")]
	public MBMMHILCGCA HDKCHGBCFEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7265940", Offset = "0x7263F40", VA = "0x187265940")]
	public bool LAJPOJHMJAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x72655E0", Offset = "0x7263BE0", VA = "0x1872655E0")]
	public void GLLCMOEOPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7265A30", Offset = "0x7264030", VA = "0x187265A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA81080", Offset = "0xA7F680", VA = "0x180A81080")]
	[CompilerGenerated]
	private void JCJNJIMPLOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class DLOFNHFJPBN : MBKHDHMPHNH, JMPIHICOHFM, PGGFJFHOMCP, PGILFKJEHOF, IEnumerator, MBMMHILCGCA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private POIAJKHHOFJ PDGIGHODODH;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private POIAJKHHOFJ BEDEADMGFNP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1023980", Offset = "0x1021F80", VA = "0x181023980", Slot = "23")]
		get
		{
			return default(POIAJKHHOFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public POIAJKHHOFJ GICCHOIEBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1556200", Offset = "0x1554800", VA = "0x181556200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float LGKALOFDMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA1C210", Offset = "0xA1A810", VA = "0x180A1C210", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool NGFHJNEHADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7258ED0", Offset = "0x72574D0", VA = "0x187258ED0", Slot = "24")]
	private bool KLFFJIDHLPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7258EC0", Offset = "0x72574C0", VA = "0x187258EC0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7258EF0", Offset = "0x72574F0", VA = "0x187258EF0")]
	public DLOFNHFJPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal enum AILGIIDBLKP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class OBBFNJOINKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum BCBBIEPKOGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public struct DKAHGMIBGKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public POIAJKHHOFJ OEHEBEJLCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public BCBBIEPKOGL MGOFFIFCHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public List<MNDHMAOELEJ> FDFENEOCPIE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly BCBBIEPKOGL[] FFGJPOKBCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly POIAJKHHOFJ ABGODCJAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool EBJLIKKIJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly MNDHMAOELEJ[] COMHPCAGFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<MNDHMAOELEJ> FIPAFMIECOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Stack<int> JKNFJEKCAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly List<MNDHMAOELEJ> OEEOMGBNKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Stack<int> CDGNPEKNGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly LJDCLHBNMPG BJJAODOELPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private bool MEAEDBMMGIE;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public DKAHGMIBGKO[,] PECNMHGKBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8689A0", Offset = "0x866FA0", VA = "0x1808689A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x72686A0", Offset = "0x7266CA0", VA = "0x1872686A0")]
	public OBBFNJOINKO(POIAJKHHOFJ EOICDCMLDHF, LJDCLHBNMPG BJJAODOELPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7267A30", Offset = "0x7266030", VA = "0x187267A30")]
	public void HCOHKMJBKAE(MNDHMAOELEJ CBONFMNDCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7267EF0", Offset = "0x72664F0", VA = "0x187267EF0")]
	public void NMOFACEONPB(IList<MNDHMAOELEJ> BMDFPKKOCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7267300", Offset = "0x7265900", VA = "0x187267300")]
	public void DNEJMMELHAL(IList<MNDHMAOELEJ> BMDFPKKOCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7267B30", Offset = "0x7266130", VA = "0x187267B30")]
	private void IMDBBBHDJAI(MNDHMAOELEJ CBONFMNDCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7267C20", Offset = "0x7266220", VA = "0x187267C20")]
	private void IPOBJHMEKGO(IList<MNDHMAOELEJ> BMDFPKKOCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7267180", Offset = "0x7265780", VA = "0x187267180")]
	private AILGIIDBLKP DBPGNEIFEEJ(MNDHMAOELEJ CBONFMNDCJK)
	{
		return default(AILGIIDBLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x72683F0", Offset = "0x72669F0", VA = "0x1872683F0")]
	public void OMKLHJHPBJI(float AAEDJKLCPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7268200", Offset = "0x7266800", VA = "0x187268200")]
	public void OFCJLMJLKKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7267730", Offset = "0x7265D30", VA = "0x187267730")]
	private void GAACDACDKIG(List<MNDHMAOELEJ> BMDFPKKOCFC, Stack<int> FHFAHOBOHLD, bool APKADCODIAG, float DGDDKPPFMLD = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7267610", Offset = "0x7265C10", VA = "0x187267610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7267DB0", Offset = "0x72663B0", VA = "0x187267DB0")]
	private void KELBNGNKEBA(List<MNDHMAOELEJ> BMDFPKKOCFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class CKMPJAMEGEF : LJDCLHBNMPG
{
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "4")]
	public void OAHFFFCPNDL(string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
	public void DBHDLPEFIDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public CKMPJAMEGEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal class LEPDOMBOFML : JMBNHIKJBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly Behaviour ALFBHFDIDMA;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7264EF0", Offset = "0x72634F0", VA = "0x187264EF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool CJMHCJFHMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7264F90", Offset = "0x7263590", VA = "0x187264F90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool IBEKAMBLKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7264F70", Offset = "0x7263570", VA = "0x187264F70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
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
namespace _LogRegistration.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F380", Offset = "0x7C6E180", VA = "0x187C6F380", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C77610", Offset = "0x7C76410", VA = "0x187C77610", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private delegate List<PlayerLoopSystem> DKPBNGMDOFC(List<PlayerLoopSystem> PAPFANMIOEL, int EEMCFEBKEKH);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct AMPNECJADJJ
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct GNOPMEAMGNH
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static GAMKKEJCIBM HPHDBMOLMEE;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x7C673D0", Offset = "0x7C661D0", VA = "0x187C673D0")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct FDPENJPIFEL
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static GAMKKEJCIBM FPDNMDOEOMJ;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x7C649D0", Offset = "0x7C637D0", VA = "0x187C649D0")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct PBPLLCOFBCO
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static GAMKKEJCIBM KCAKOMKIHPO;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x7C75120", Offset = "0x7C73F20", VA = "0x187C75120")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct CHMKCMJFKIC
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static GAMKKEJCIBM IBMJDIIMBKE;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static GAMKKEJCIBM GPJCEDAHMFI;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static GAMKKEJCIBM EFJMHGKPACN;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static GAMKKEJCIBM CADEFMJKDPH;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x7C5C780", Offset = "0x7C5B580", VA = "0x187C5C780")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct EHFDLIJPIEN
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static GAMKKEJCIBM GOJLMJPNJAM;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x7C63690", Offset = "0x7C62490", VA = "0x187C63690")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct GBMHOJOPGNN
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static GAMKKEJCIBM IBMJDIIMBKE;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static GAMKKEJCIBM GPJCEDAHMFI;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static GAMKKEJCIBM EFJMHGKPACN;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static GAMKKEJCIBM CADEFMJKDPH;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x7C64D10", Offset = "0x7C63B10", VA = "0x187C64D10")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct GEMCOKAEMEG
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static GAMKKEJCIBM LNAMFIBMOJI;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x7C661B0", Offset = "0x7C64FB0", VA = "0x187C661B0")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct GJPOIEMONCK
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static GAMKKEJCIBM ECEJBHEBBDN;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7C665F0", Offset = "0x7C653F0", VA = "0x187C665F0")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct HGCBGKEMOGE
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static GAMKKEJCIBM IIEEHMFGOOC;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x7C67E10", Offset = "0x7C66C10", VA = "0x187C67E10")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct PPCAHPLPBMD
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static GAMKKEJCIBM FPCLCKKBOFB;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x7C75FE0", Offset = "0x7C74DE0", VA = "0x187C75FE0")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct CMAHNCIBBMC
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static GAMKKEJCIBM GEKBHFJPDII;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x7C5D580", Offset = "0x7C5C380", VA = "0x187C5D580")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct HBDBPOCANLP
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static GAMKKEJCIBM LHIDHNGMPPB;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x7C675D0", Offset = "0x7C663D0", VA = "0x187C675D0")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct EJAHHBINAPL
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static GAMKKEJCIBM MGKFHDCMCAD;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x7C63B80", Offset = "0x7C62980", VA = "0x187C63B80")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct MMPHBDKDLBE
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static GAMKKEJCIBM HMMBBADGKFP;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x7C6F6D0", Offset = "0x7C6E4D0", VA = "0x187C6F6D0")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct OAAOBDGJEFO
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static GAMKKEJCIBM BHILKFBBPBM;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x7C70B10", Offset = "0x7C6F910", VA = "0x187C70B10")]
				public static PlayerLoopSystem NLEBBJEOGBO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum KLNJHJGDPGM : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public struct KJBLELIPMDL
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class JLDNJOACFLJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public KLNJHJGDPGM updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
					public JLDNJOACFLJ()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x7C6C6A0", Offset = "0x7C6B4A0", VA = "0x187C6C6A0")]
					internal void EIBMKDGKCCF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static OJCBODLGMBO<KLNJHJGDPGM> JEGFHNEAFOJ;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x7C6CB70", Offset = "0x7C6B970", VA = "0x187C6CB70")]
				public static PlayerLoopSystem NLEBBJEOGBO(KLNJHJGDPGM DNNFPDFEOKE)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct GGFOPDFCHAD
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class MOFDBOBGFAD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public CCCEPBBDKED.IHBMFNNBPEA key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
					public MOFDBOBGFAD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x7C6F8D0", Offset = "0x7C6E6D0", VA = "0x187C6F8D0")]
					internal void OBNIAIKHIJO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable JMLHNIBLHFI;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7C663B0", Offset = "0x7C651B0", VA = "0x187C663B0")]
				public static PlayerLoopSystem NADNNFHLKMB(CCCEPBBDKED.IHBMFNNBPEA FFOHLCGHDKA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct CFDDAEEACCH
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class HJHAMHCGJAH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public CCCEPBBDKED.IHBMFNNBPEA key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
					public HJHAMHCGJAH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x7C68010", Offset = "0x7C66E10", VA = "0x187C68010")]
					internal void OBNIAIKHIJO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7C5C650", Offset = "0x7C5B450", VA = "0x187C5C650")]
				public static PlayerLoopSystem NADNNFHLKMB(CCCEPBBDKED.IHBMFNNBPEA FFOHLCGHDKA)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class HFJKDBAJKDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public HFJKDBAJKDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7C67CF0", Offset = "0x7C66AF0", VA = "0x187C67CF0")]
			internal List<PlayerLoopSystem> LNADCKKKLFJ(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool BMBFCOBMJMF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool JIABALNIBPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7C5DFE0", Offset = "0x7C5CDE0", VA = "0x187C5DFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F000", Offset = "0x7C5DE00", VA = "0x187C5F000")]
		private static void OMDLIOMMDIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C5E150", Offset = "0x7C5CF50", VA = "0x187C5E150")]
		private static void HIBENIGHLMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C5DFA0", Offset = "0x7C5CDA0", VA = "0x187C5DFA0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C620C0", Offset = "0x7C60EC0", VA = "0x187C620C0")]
		private static void PPJMBKKCMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EA60", Offset = "0x7C5D860", VA = "0x187C5EA60")]
		private static void ILAOMACHGAO(CCCEPBBDKED.IHBMFNNBPEA FFOHLCGHDKA, PlayerLoopSystem DHCBBCAABHE, Type KPADOGGIKAK, Type DKCLHBOIIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EC20", Offset = "0x7C5DA20", VA = "0x187C5EC20")]
		private static void JLCCLCGMJOA(PlayerLoopSystem DHCBBCAABHE, Type KPADOGGIKAK, Type DKCLHBOIIHP, DKPBNGMDOFC PDJHALNPKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5E020", Offset = "0x7C5CE20", VA = "0x187C5E020")]
		private static void HDKEBHENGOD(PlayerLoopSystem DHCBBCAABHE, Type KPADOGGIKAK, Type DKCLHBOIIHP, PlayerLoopSystem? PPJMKFEIKJB, PlayerLoopSystem? FOECHPFEKOG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class CCCEPBBDKED
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum IHBMFNNBPEA
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		OMPrePhysicsFixedUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class HBIPPGHCIHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly IHBMFNNBPEA NFIDJFLKAFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly POFEPICAAOA NGMMNFNPECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long PLOKNGGEFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long JJEMKGNGLEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long GONNAKGGCHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int LDGBHKNPEON;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C67920", Offset = "0x7C66720", VA = "0x187C67920")]
		public HBIPPGHCIHL(IHBMFNNBPEA MFJNLDFIIGO, int OMOFOPKILLH = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C67900", Offset = "0x7C66700", VA = "0x187C67900")]
		public void JOHIGEDIKPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7C677D0", Offset = "0x7C665D0", VA = "0x187C677D0")]
		public void CHIFCJAKDLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C67820", Offset = "0x7C66620", VA = "0x187C67820")]
		public void IEJBEJEEFDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static IHBMFNNBPEA[] NAOIPMOEBIB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static HBIPPGHCIHL[] EPOLDJNGPDL;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C2A0", Offset = "0x7C5B0A0", VA = "0x187C5C2A0")]
	public static HBIPPGHCIHL HLEILIBBBNE(IHBMFNNBPEA FFOHLCGHDKA, int OMOFOPKILLH = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C230", Offset = "0x7C5B030", VA = "0x187C5C230")]
	public static HBIPPGHCIHL ABCPEGJOIEP(IHBMFNNBPEA FFOHLCGHDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C400", Offset = "0x7C5B200", VA = "0x187C5C400")]
	public static void KDIMGHPKHDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OMIMIOCLLJE
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface MCEJLKLFAPM
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool JIONCFPPMKM
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EHCAOMMFNME();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class DNGHIOHBOHK : MCEJLKLFAPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action OOCJAOHFGJK;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool JIONCFPPMKM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
		public DNGHIOHBOHK(Action OOCJAOHFGJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xF909B0", Offset = "0xF8F7B0", VA = "0x180F909B0", Slot = "5")]
		public void EHCAOMMFNME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<MCEJLKLFAPM> AIBDMPEMKMN;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C74340", Offset = "0x7C73140", VA = "0x187C74340")]
	public static void MPJLHGKBHFC(Action OOCJAOHFGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C74020", Offset = "0x7C72E20", VA = "0x187C74020")]
	private static void EKGMPPLNDDC(MCEJLKLFAPM ODMFPINJKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C73D20", Offset = "0x7C72B20", VA = "0x187C73D20")]
	private static void COPNJPAIBPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C74240", Offset = "0x7C73040", VA = "0x187C74240")]
	private static void GGLGKDFPJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C73C40", Offset = "0x7C72A40", VA = "0x187C73C40")]
	private static void CNGGELBJPIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class IFADAINJFAC
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct OIFJMIGDKJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> DONNLBPMIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string GJJPEGOGGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode PJHBMOHMKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool AHMINMKHLLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C70D10", Offset = "0x7C6FB10", VA = "0x187C70D10")]
		public OIFJMIGDKJF(TaskCompletionSource<Scene> LHILFOPNIIF, string GJJPEGOGGEA, LoadSceneMode PJHBMOHMKFH, bool AHMINMKHLLM, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct CLJGBDNFMHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IGPFJOOPHMK<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CC70", Offset = "0x7C5BA70", VA = "0x187C5CC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D510", Offset = "0x7C5C310", VA = "0x187C5D510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct EEFOIDDOCDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C63310", Offset = "0x7C62110", VA = "0x187C63310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C63630", Offset = "0x7C62430", VA = "0x187C63630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct DBLJBCLCGIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private OIFJMIGDKJF <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C62310", Offset = "0x7C61110", VA = "0x187C62310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C626D0", Offset = "0x7C614D0", VA = "0x187C626D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class GEBHJCEONPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public EFBNHMMLLCH<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GEBHJCEONPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C650C0", Offset = "0x7C63EC0", VA = "0x187C650C0")]
		internal void CEGGEEKBEEN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct ENOPGBNKABI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private GEBHJCEONPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C63D80", Offset = "0x7C62B80", VA = "0x187C63D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C64930", Offset = "0x7C63730", VA = "0x187C64930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct KPPABDGGKIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private DOOPFMCKBOH <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EC20", Offset = "0x7C6DA20", VA = "0x187C6EC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F2E0", Offset = "0x7C6E0E0", VA = "0x187C6F2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct NALPFJJAKON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C6FB10", Offset = "0x7C6E910", VA = "0x187C6FB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C70630", Offset = "0x7C6F430", VA = "0x187C70630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DIKIEOBEFKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DIKIEOBEFKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C627B0", Offset = "0x7C615B0", VA = "0x187C627B0")]
		internal bool OCABFOHJCFK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NJOGOKJIKBO : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public IFLNFKMEDGB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public NJOGOKJIKBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C70A80", Offset = "0x7C6F880", VA = "0x187C70A80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C706F0", Offset = "0x7C6F4F0", VA = "0x187C706F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C706A0", Offset = "0x7C6F4A0", VA = "0x187C706A0")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C70A30", Offset = "0x7C6F830", VA = "0x187C70A30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class HEIGEKJEDML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public EFBNHMMLLCH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HEIGEKJEDML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C679F0", Offset = "0x7C667F0", VA = "0x187C679F0")]
		internal bool GEGPGFDCLBH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C67A70", Offset = "0x7C66870", VA = "0x187C67A70")]
		internal void KBNKCIPFOKN(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class GEMAEHEJBMC : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public EFBNHMMLLCH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private HEIGEKJEDML <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private DOOPFMCKBOH <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public GEMAEHEJBMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C66150", Offset = "0x7C64F50", VA = "0x187C66150", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C657F0", Offset = "0x7C645F0", VA = "0x187C657F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C657D0", Offset = "0x7C645D0", VA = "0x187C657D0")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C66100", Offset = "0x7C64F00", VA = "0x187C66100", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> MDIEMBLPGJL;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static LDHIGNIGDAL OJCFMNJBMIF;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation CHPFBBHBALN;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static LDHIGNIGDAL PKNOLINNBHJ;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string GNKABDDEBCE;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string BPNMGEBINOJ;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority JIJIEMKBGJH;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task EHAFCFPCBGE;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> BHLGHPPDOKG;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<OIFJMIGDKJF> PIPLOGBJJLK;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task CILAJNGFBLA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool KKCFHIEHJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C6B320", Offset = "0x7C6A120", VA = "0x187C6B320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private static bool FPKGLBKPHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A960", Offset = "0x7C69760", VA = "0x187C6A960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private static bool HIDCLLBCINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A210", Offset = "0x7C69010", VA = "0x187C6A210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool NAMMDBBPKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A3C0", Offset = "0x7C691C0", VA = "0x187C6A3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> KAGEDJHAMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7C6B160", Offset = "0x7C69F60", VA = "0x187C6B160")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7C69EA0", Offset = "0x7C68CA0", VA = "0x187C69EA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AFD0", Offset = "0x7C69DD0", VA = "0x187C6AFD0")]
	[IDLAPLKHLAA(ECMLOFDPNGP.EnteredEditModeNextFrame, 0)]
	private static void IIOLDKMJLJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7C69C60", Offset = "0x7C68A60", VA = "0x187C69C60")]
	[AsyncStateMachine(typeof(CLJGBDNFMHM))]
	public static Task<Scene> ACIGDHHHCJH(string GJJPEGOGGEA, LoadSceneMode PJHBMOHMKFH = LoadSceneMode.Single, bool AHMINMKHLLM = false, [Optional] IGPFJOOPHMK<string>.PDLCJKJEJBF EKIPJDCNDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B270", Offset = "0x7C6A070", VA = "0x187C6B270")]
	[AsyncStateMachine(typeof(EEFOIDDOCDE))]
	private static Task NDFMMKAKHAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A5D0", Offset = "0x7C693D0", VA = "0x187C6A5D0")]
	[AsyncStateMachine(typeof(DBLJBCLCGIH))]
	private static Task DOPHGKCBPAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AE80", Offset = "0x7C69C80", VA = "0x187C6AE80")]
	[AsyncStateMachine(typeof(ENOPGBNKABI))]
	private static Task<Scene> HPIEKDNCCLK(string GJJPEGOGGEA, LoadSceneMode PJHBMOHMKFH, bool AHMINMKHLLM, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AAA0", Offset = "0x7C698A0", VA = "0x187C6AAA0")]
	private static void HBNNLDHCKJH(SceneInstance PMGDCKPCODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A6A0", Offset = "0x7C694A0", VA = "0x187C6A6A0")]
	private static void FCJDECNMBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A0E0", Offset = "0x7C68EE0", VA = "0x187C6A0E0")]
	[AsyncStateMachine(typeof(KPPABDGGKIJ))]
	private static Task<Scene> ALMFKCKMOIJ(string GJJPEGOGGEA, LoadSceneMode PJHBMOHMKFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7C69DB0", Offset = "0x7C68BB0", VA = "0x187C69DB0")]
	private static bool ADMHPLBFDOM(string GJJPEGOGGEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A2B0", Offset = "0x7C690B0", VA = "0x187C6A2B0")]
	[AsyncStateMachine(typeof(NALPFJJAKON))]
	private static Task<Scene> CNIHGFIAMLK(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A450", Offset = "0x7C69250", VA = "0x187C6A450")]
	public static MNHDJBCOCND<Scene> DNABGAMMODB(string GJJPEGOGGEA, LoadSceneMode PJHBMOHMKFH = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7C6ABB0", Offset = "0x7C699B0", VA = "0x187C6ABB0")]
	public static LDHIGNIGDAL HMAEBPONPNK(string GJJPEGOGGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B0D0", Offset = "0x7C69ED0", VA = "0x187C6B0D0")]
	[IteratorStateMachine(typeof(NJOGOKJIKBO))]
	private static IEnumerator<HLGDLHCLDFE> JEJOAECHNFD(string GJJPEGOGGEA, IFLNFKMEDGB FLFHBDAOALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AA00", Offset = "0x7C69800", VA = "0x187C6AA00")]
	[IteratorStateMachine(typeof(GEMAEHEJBMC))]
	private static IEnumerator<HLGDLHCLDFE> GFCOMAJOPLL(string GJJPEGOGGEA, LoadSceneMode PJHBMOHMKFH, EFBNHMMLLCH<Scene> FLFHBDAOALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7C69FB0", Offset = "0x7C68DB0", VA = "0x187C69FB0")]
	public static bool AHALHOJLMMN([Out] string GAILOICFNAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MGOPLNJLILM
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F540", Offset = "0x7C6E340", VA = "0x187C6F540")]
	public static IDisposable EJDEFPCAKBI(this IHFJNNFFJFE MOBMLKIIAJP, float DJJLJOOJOMC, Action<float> DMALMKGJLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F650", Offset = "0x7C6E450", VA = "0x187C6F650")]
	public static IDisposable MCEPBABKNGK(this IHFJNNFFJFE MOBMLKIIAJP, Action<float> DMALMKGJLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F5D0", Offset = "0x7C6E3D0", VA = "0x187C6F5D0")]
	public static IDisposable KIJBHIGNGIH(this IHFJNNFFJFE MOBMLKIIAJP, Action<float> DMALMKGJLDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PPFCCJLDLHK
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x34A9A90", Offset = "0x34A8890", VA = "0x1834A9A90")]
	[GIHIPDJNFPG]
	public static IDisposable FKFPDGDAKGP<T>(this T BJIPLNEIFBB, Action DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x34A9C30", Offset = "0x34A8A30", VA = "0x1834A9C30")]
	[GIHIPDJNFPG]
	public static IDisposable FKFPDGDAKGP<T>(this T BJIPLNEIFBB, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x34A9F90", Offset = "0x34A8D90", VA = "0x1834A9F90")]
	[GIHIPDJNFPG]
	public static IDisposable IGIPDIBMNHA<T>(this T BJIPLNEIFBB, Action DMALMKGJLDE, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x34A99A0", Offset = "0x34A87A0", VA = "0x1834A99A0")]
	[GIHIPDJNFPG]
	public static IDisposable ECENMMIAFIA<T>(this T BJIPLNEIFBB, Action DMALMKGJLDE, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x34A99A0", Offset = "0x34A87A0", VA = "0x1834A99A0")]
	[GIHIPDJNFPG]
	public static IDisposable ECENMMIAFIA<T>(this T BJIPLNEIFBB, Action<float> DMALMKGJLDE, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x34A9950", Offset = "0x34A8750", VA = "0x1834A9950")]
	[GIHIPDJNFPG]
	public static IDisposable DGCKJAGEBGH<T>(this T BJIPLNEIFBB, Action DMALMKGJLDE, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x34AA190", Offset = "0x34A8F90", VA = "0x1834AA190")]
	[GIHIPDJNFPG]
	public static IDisposable OBOFBCPCHNE<T>(this T BJIPLNEIFBB, Action DMALMKGJLDE, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x34A99F0", Offset = "0x34A87F0", VA = "0x1834A99F0")]
	[GIHIPDJNFPG]
	public static IDisposable EDMNLCLIJPO<T>(this T BJIPLNEIFBB, Action DMALMKGJLDE, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x34AA090", Offset = "0x34A8E90", VA = "0x1834AA090")]
	[GIHIPDJNFPG]
	public static IDisposable JLCGIAFBDPI<T>(this T BJIPLNEIFBB, float DJJLJOOJOMC, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C761E0", Offset = "0x7C74FE0", VA = "0x187C761E0")]
	[GIHIPDJNFPG]
	public static IDisposable JLCGIAFBDPI(this MonoBehaviour BJIPLNEIFBB, HECGOLGDACB MOBMLKIIAJP, float DJJLJOOJOMC, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x34A9DE0", Offset = "0x34A8BE0", VA = "0x1834A9DE0")]
	[GIHIPDJNFPG]
	public static IDisposable GBEFNIIHODO<T>(this T BJIPLNEIFBB, float DJJLJOOJOMC, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x34A9A40", Offset = "0x34A8840", VA = "0x1834A9A40")]
	[GIHIPDJNFPG]
	public static IDisposable ENOMOIFFLNP<T>(this T BJIPLNEIFBB, float DJJLJOOJOMC, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x34AA0D0", Offset = "0x34A8ED0", VA = "0x1834AA0D0")]
	[GIHIPDJNFPG]
	public static IDisposable LLOFDBHHLFF<T>(this T BJIPLNEIFBB, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x34A9FD0", Offset = "0x34A8DD0", VA = "0x1834A9FD0")]
	[GIHIPDJNFPG]
	public static IDisposable IIOKCKBOCAM<T>(this T BJIPLNEIFBB, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x34A98F0", Offset = "0x34A86F0", VA = "0x1834A98F0")]
	[GIHIPDJNFPG]
	public static IDisposable COFCIJEEJIO<T>(this T BJIPLNEIFBB, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x34AA130", Offset = "0x34A8F30", VA = "0x1834AA130")]
	[GIHIPDJNFPG]
	public static IDisposable MMCLHCJKGBG<T>(this T BJIPLNEIFBB, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x34AA240", Offset = "0x34A9040", VA = "0x1834AA240")]
	[GIHIPDJNFPG]
	public static IDisposable OPKCOBKCEIP<T>(this T BJIPLNEIFBB, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x34A9890", Offset = "0x34A8690", VA = "0x1834A9890")]
	[GIHIPDJNFPG]
	public static IDisposable CKPAHGIFFPG<T>(this T BJIPLNEIFBB, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x34AA030", Offset = "0x34A8E30", VA = "0x1834AA030")]
	[GIHIPDJNFPG]
	public static IDisposable IOMOLKALPLL<T>(this T BJIPLNEIFBB, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x34A9840", Offset = "0x34A8640", VA = "0x1834A9840")]
	[GIHIPDJNFPG]
	public static IDisposable BGPDMNLDIAF<T>(this T BJIPLNEIFBB, float DJJLJOOJOMC, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x34AA1E0", Offset = "0x34A8FE0", VA = "0x1834AA1E0")]
	[GIHIPDJNFPG]
	public static IDisposable ODAPCDOICEP<T>(this T BJIPLNEIFBB, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x34AA2A0", Offset = "0x34A90A0", VA = "0x1834AA2A0")]
	[GIHIPDJNFPG]
	public static IDisposable PKINNFPBAOG<T>(this T BJIPLNEIFBB, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true) where T : MonoBehaviour, HECGOLGDACB
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class AEAOPKEKHJD
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class MGNFONAFOGP : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NMAEDBICFMP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private LMDIONDODDJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public MGNFONAFOGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F410", Offset = "0x7C6E210", VA = "0x187C6F410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F4F0", Offset = "0x7C6E2F0", VA = "0x187C6F4F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class FPFKJIGGKEK : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public NMAEDBICFMP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private LMDIONDODDJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public FPFKJIGGKEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C64BD0", Offset = "0x7C639D0", VA = "0x187C64BD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C64CC0", Offset = "0x7C63AC0", VA = "0x187C64CC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7C599A0", Offset = "0x7C587A0", VA = "0x187C599A0")]
	public static CPMKHKOAIIG FKFPDGDAKGP(Action DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7C59830", Offset = "0x7C58630", VA = "0x187C59830")]
	public static CPMKHKOAIIG FKFPDGDAKGP(Behaviour MOBMLKIIAJP, Action DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C598C0", Offset = "0x7C586C0", VA = "0x187C598C0")]
	public static CPMKHKOAIIG FKFPDGDAKGP(Behaviour MOBMLKIIAJP, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C59AB0", Offset = "0x7C588B0", VA = "0x187C59AB0")]
	[IteratorStateMachine(typeof(MGNFONAFOGP))]
	private static IEnumerator<HLGDLHCLDFE> FMIPLBLDOOB(NMAEDBICFMP HCOHDNBOGPL, Action DMALMKGJLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C59A20", Offset = "0x7C58820", VA = "0x187C59A20")]
	[IteratorStateMachine(typeof(FPFKJIGGKEK))]
	private static IEnumerator<HLGDLHCLDFE> FMIPLBLDOOB(NMAEDBICFMP HCOHDNBOGPL, Action<float> DMALMKGJLDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class OPMHKEPEHKI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class KNIHKELDIEI : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public OPMHKEPEHKI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public KNIHKELDIEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EB40", Offset = "0x7C6D940", VA = "0x187C6EB40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EBD0", Offset = "0x7C6D9D0", VA = "0x187C6EBD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly NMAEDBICFMP BNHHGIBHCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Action OGMFIBOGPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool JDGPCCFHNBP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool BKAEPKEPKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8F4420", Offset = "0x8F3220", VA = "0x1808F4420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C75050", Offset = "0x7C73E50", VA = "0x187C75050")]
	public OPMHKEPEHKI(NMAEDBICFMP BNHHGIBHCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C74F30", Offset = "0x7C73D30", VA = "0x187C74F30")]
	[IteratorStateMachine(typeof(KNIHKELDIEI))]
	private IEnumerator<HLGDLHCLDFE> LEAOMMJOAKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C74FB0", Offset = "0x7C73DB0", VA = "0x187C74FB0", Slot = "4")]
	public void OnCompleted(Action EONANGMMIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	public void KJBMOHFPJDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class PGDIHPHANMB
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7C75700", Offset = "0x7C74500", VA = "0x187C75700")]
	public static OPMHKEPEHKI JOPFHFCGHMH(this NMAEDBICFMP BNHHGIBHCCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class ILBAJECMGID
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class EHIDINNKGAE : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public IIFACAMMKMD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public EHIDINNKGAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C63890", Offset = "0x7C62690", VA = "0x187C63890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C63910", Offset = "0x7C62710", VA = "0x187C63910", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B8D0", Offset = "0x7C6A6D0", VA = "0x187C6B8D0")]
	public static CPMKHKOAIIG FKFPDGDAKGP(float DJJLJOOJOMC, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, bool AAPFFKNIEHD = true, [Optional] JACPPMCDBFA DDHBLBIAMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B9A0", Offset = "0x7C6A7A0", VA = "0x187C6B9A0")]
	public static CPMKHKOAIIG FKFPDGDAKGP(MonoBehaviour BJIPLNEIFBB, float DJJLJOOJOMC, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, bool AAPFFKNIEHD = true, [Optional] JACPPMCDBFA DDHBLBIAMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BB90", Offset = "0x7C6A990", VA = "0x187C6BB90")]
	public static CPMKHKOAIIG JAJBFPANCBL(MonoBehaviour BJIPLNEIFBB, float DJJLJOOJOMC, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, bool AAPFFKNIEHD = true, [Optional] JACPPMCDBFA DDHBLBIAMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B770", Offset = "0x7C6A570", VA = "0x187C6B770")]
	public static CPMKHKOAIIG EMAGDDGMLGM(IHFJNNFFJFE MOBMLKIIAJP, float DJJLJOOJOMC, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, bool AAPFFKNIEHD = true, [Optional] JACPPMCDBFA DDHBLBIAMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BA70", Offset = "0x7C6A870", VA = "0x187C6BA70")]
	private static IEnumerator<HLGDLHCLDFE> FMIPLBLDOOB(LFEHEKJCJIF CHMCEGCJIIK, float DJJLJOOJOMC, NMAEDBICFMP HCOHDNBOGPL, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BB30", Offset = "0x7C6A930", VA = "0x187C6BB30")]
	private static IEnumerator<HLGDLHCLDFE> GNFOCHAEPCJ(LFEHEKJCJIF CHMCEGCJIIK, float DJJLJOOJOMC, NMAEDBICFMP HCOHDNBOGPL, Action<float> DMALMKGJLDE, bool AAPFFKNIEHD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B840", Offset = "0x7C6A640", VA = "0x187C6B840")]
	[IteratorStateMachine(typeof(EHIDINNKGAE))]
	private static IEnumerator<HLGDLHCLDFE> FEDGOIFGKOJ(IIFACAMMKMD NAIBHGEKFNG, float DJJLJOOJOMC, NMAEDBICFMP HCOHDNBOGPL, Action<float> DMALMKGJLDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class OPDLLNNDELJ
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class GJNFLNKHGIP : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public NMAEDBICFMP queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public GJNFLNKHGIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7C664E0", Offset = "0x7C652E0", VA = "0x187C664E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7C665A0", Offset = "0x7C653A0", VA = "0x187C665A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C74EA0", Offset = "0x7C73CA0", VA = "0x187C74EA0")]
	[IteratorStateMachine(typeof(GJNFLNKHGIP))]
	private static IEnumerator<HLGDLHCLDFE> OCKEGKEFOBE(NMAEDBICFMP BNHHGIBHCCL, Func<bool> PKDNIKFJMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C74DC0", Offset = "0x7C73BC0", VA = "0x187C74DC0")]
	public static CPMKHKOAIIG BALPIHGBNCO(this MonoBehaviour BJIPLNEIFBB, Func<bool> PKDNIKFJMDJ, NMAEDBICFMP BNHHGIBHCCL = NMAEDBICFMP.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class BILLLEJECAD
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class EBPPKLJJJMK : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public NMAEDBICFMP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public EBPPKLJJJMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7C63250", Offset = "0x7C62050", VA = "0x187C63250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7C632C0", Offset = "0x7C620C0", VA = "0x187C632C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class JGCHIKPADAE<T> : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public NMAEDBICFMP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public JGCHIKPADAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x48BE2C0", Offset = "0x48BD0C0", VA = "0x1848BE2C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x48BE360", Offset = "0x48BD160", VA = "0x1848BE360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class PLBHOJMOEAB : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public NMAEDBICFMP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private HLGDLHCLDFE <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public PLBHOJMOEAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7C75810", Offset = "0x7C74610", VA = "0x187C75810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7C758A0", Offset = "0x7C746A0", VA = "0x187C758A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BE40", Offset = "0x7C5AC40", VA = "0x187C5BE40")]
	[IteratorStateMachine(typeof(EBPPKLJJJMK))]
	private static IEnumerator<HLGDLHCLDFE> LEAOMMJOAKO(float CIOLBCCFHKE, NMAEDBICFMP HCOHDNBOGPL, Action LLGCEMPPLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3092210", Offset = "0x3091010", VA = "0x183092210")]
	[IteratorStateMachine(typeof(JGCHIKPADAE<>))]
	private static IEnumerator<HLGDLHCLDFE> LEAOMMJOAKO<T>(float CIOLBCCFHKE, NMAEDBICFMP HCOHDNBOGPL, Action<T> LLGCEMPPLIJ, T BFLKHJBBCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BB30", Offset = "0x7C5A930", VA = "0x187C5BB30")]
	[IteratorStateMachine(typeof(PLBHOJMOEAB))]
	private static IEnumerator<HLGDLHCLDFE> HEEDLFIDGFL(float CIOLBCCFHKE, NMAEDBICFMP HCOHDNBOGPL, Action LLGCEMPPLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BCC0", Offset = "0x7C5AAC0", VA = "0x187C5BCC0")]
	public static IDisposable IJJFBBJAGBA(this MonoBehaviour BJIPLNEIFBB, float CIOLBCCFHKE, Action LLGCEMPPLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BA00", Offset = "0x7C5A800", VA = "0x187C5BA00")]
	public static CPMKHKOAIIG ECAELNACHON(this MonoBehaviour BJIPLNEIFBB, float CIOLBCCFHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BBD0", Offset = "0x7C5A9D0", VA = "0x187C5BBD0")]
	public static CPMKHKOAIIG IJJFBBJAGBA(this MonoBehaviour BJIPLNEIFBB, float CIOLBCCFHKE, NMAEDBICFMP HCOHDNBOGPL, Action LLGCEMPPLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B6E0", Offset = "0x7C5A4E0", VA = "0x187C5B6E0")]
	public static CPMKHKOAIIG AKBOGIOMMFO(this MonoBehaviour BJIPLNEIFBB, Action LLGCEMPPLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3092080", Offset = "0x3090E80", VA = "0x183092080")]
	public static CPMKHKOAIIG AKBOGIOMMFO<T>(this MonoBehaviour BJIPLNEIFBB, Action<T> LLGCEMPPLIJ, T BFLKHJBBCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BEE0", Offset = "0x7C5ACE0", VA = "0x187C5BEE0")]
	public static CPMKHKOAIIG NELGKLHHIFH(this MonoBehaviour BJIPLNEIFBB, Action LLGCEMPPLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BA90", Offset = "0x7C5A890", VA = "0x187C5BA90")]
	public static CPMKHKOAIIG HBIKJKOLMNF(this MonoBehaviour BJIPLNEIFBB, Action LLGCEMPPLIJ, [Optional] JACPPMCDBFA DDHBLBIAMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C010", Offset = "0x7C5AE10", VA = "0x187C5C010")]
	public static CPMKHKOAIIG PKBKFMKHDEF(this MonoBehaviour BJIPLNEIFBB, Action LLGCEMPPLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BDA0", Offset = "0x7C5ABA0", VA = "0x187C5BDA0")]
	public static CPMKHKOAIIG JPDCNIPOODF(this MonoBehaviour BJIPLNEIFBB, Action LLGCEMPPLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B820", Offset = "0x7C5A620", VA = "0x187C5B820")]
	public static CPMKHKOAIIG BLMPJHCGPCL(MonoBehaviour BJIPLNEIFBB, NMAEDBICFMP BNHHGIBHCCL, Action LLGCEMPPLIJ, [Optional] JACPPMCDBFA DDHBLBIAMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x30920D0", Offset = "0x3090ED0", VA = "0x1830920D0")]
	public static CPMKHKOAIIG BLMPJHCGPCL<T>(MonoBehaviour BJIPLNEIFBB, NMAEDBICFMP BNHHGIBHCCL, Action<T> LLGCEMPPLIJ, T BFLKHJBBCJI, [Optional] JACPPMCDBFA DDHBLBIAMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BF80", Offset = "0x7C5AD80", VA = "0x187C5BF80")]
	public static CPMKHKOAIIG OGENCEOKCBL(this MonoBehaviour BJIPLNEIFBB, float LNDENKNKKEE, Action LLGCEMPPLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B8C0", Offset = "0x7C5A6C0", VA = "0x187C5B8C0")]
	public static CPMKHKOAIIG CGOFNJNKNEA(this MonoBehaviour BJIPLNEIFBB, float LNDENKNKKEE, Action LLGCEMPPLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B780", Offset = "0x7C5A580", VA = "0x187C5B780")]
	public static CPMKHKOAIIG BDPFFNCDANE(this MonoBehaviour BJIPLNEIFBB, float LNDENKNKKEE, Action LLGCEMPPLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B960", Offset = "0x7C5A760", VA = "0x187C5B960")]
	public static CPMKHKOAIIG CMHHCNCMFCO(this MonoBehaviour BJIPLNEIFBB, float LNDENKNKKEE, Action LLGCEMPPLIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OOKHJKJMBPH : OAPMCPIPKPI, IEnumerable<OAPMCPIPKPI>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly List<OAPMCPIPKPI> FPNEGIHNDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool LLLJELFEDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Action PEAMNEHPBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool FNNAKDALEBF;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool BILJJHNABHH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7C74470", Offset = "0x7C73270", VA = "0x187C74470", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OPFOCFKDDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7C745B0", Offset = "0x7C733B0", VA = "0x187C745B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7C74650", Offset = "0x7C73450", VA = "0x187C74650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7C74D20", Offset = "0x7C73B20", VA = "0x187C74D20")]
	public OOKHJKJMBPH([Optional] Action PEAMNEHPBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7C748D0", Offset = "0x7C736D0", VA = "0x187C748D0")]
	public void MDGAONDGEMG(OAPMCPIPKPI JPLJBDKPPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7C74770", Offset = "0x7C73570", VA = "0x187C74770")]
	private void IEGIDNIAKDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7C74A00", Offset = "0x7C73800", VA = "0x187C74A00", Slot = "7")]
	public bool PNCNLEBEOAO(bool MKKNPGPEIPF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7C74A10", Offset = "0x7C73810", VA = "0x187C74A10", Slot = "8")]
	public bool PNCNLEBEOAO(Action OOCJAOHFGJK, bool MKKNPGPEIPF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7C746F0", Offset = "0x7C734F0", VA = "0x187C746F0", Slot = "9")]
	public IEnumerator<OAPMCPIPKPI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7C746F0", Offset = "0x7C734F0", VA = "0x187C746F0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EIOAOJKDHDF : POIBLIDOLBF
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class NAOECGBHNPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public EIOAOJKDHDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NAOECGBHNPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F350", Offset = "0x7C6E150", VA = "0x187C6F350")]
		internal void OKCAGHBNGII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class LGGLFLFCPHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public EIOAOJKDHDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LGGLFLFCPHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F350", Offset = "0x7C6E150", VA = "0x187C6F350")]
		internal void ODIDMPMHKIB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly float HPHOJBCFLIJ;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C0F0", Offset = "0x7C5AEF0", VA = "0x187C5C0F0")]
	public EIOAOJKDHDF(Behaviour MOBMLKIIAJP, float HPHOJBCFLIJ, [Optional] Action PEAMNEHPBJC, [Optional] JACPPMCDBFA DDHBLBIAMDM, [Optional] LFEHEKJCJIF CHMCEGCJIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7C63960", Offset = "0x7C62760", VA = "0x187C63960", Slot = "9")]
	protected override bool ABBHEILPGDA(Action OOCJAOHFGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7C63A70", Offset = "0x7C62870", VA = "0x187C63A70", Slot = "10")]
	protected override bool FOJACKNCFCD(Action OOCJAOHFGJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface OAPMCPIPKPI
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BILJJHNABHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OPFOCFKDDMK;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PNCNLEBEOAO(bool MKKNPGPEIPF = false);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PNCNLEBEOAO(Action OOCJAOHFGJK, bool MKKNPGPEIPF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class POIBLIDOLBF : OAPMCPIPKPI
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class JGBELJALPFH : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public POIBLIDOLBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public JGBELJALPFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C580", Offset = "0x7C6B380", VA = "0x187C6C580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C650", Offset = "0x7C6B450", VA = "0x187C6C650", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Behaviour MOBMLKIIAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action PEAMNEHPBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NAEGINDHOLH ABCLLGNBFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly JACPPMCDBFA DDHBLBIAMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	protected readonly LFEHEKJCJIF CHMCEGCJIIK;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool BILJJHNABHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x152A540", Offset = "0x1529340", VA = "0x18152A540", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OPFOCFKDDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7C75BC0", Offset = "0x7C749C0", VA = "0x187C75BC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C75C60", Offset = "0x7C74A60", VA = "0x187C75C60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7C75EB0", Offset = "0x7C74CB0", VA = "0x187C75EB0")]
	protected POIBLIDOLBF(Behaviour MOBMLKIIAJP, [Optional] Action PEAMNEHPBJC, [Optional] JACPPMCDBFA DDHBLBIAMDM, [Optional] LFEHEKJCJIF CHMCEGCJIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7C75DF0", Offset = "0x7C74BF0", VA = "0x187C75DF0", Slot = "7")]
	public bool PNCNLEBEOAO(bool MKKNPGPEIPF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7C75E50", Offset = "0x7C74C50", VA = "0x187C75E50", Slot = "8")]
	public bool PNCNLEBEOAO(Action OOCJAOHFGJK, bool MKKNPGPEIPF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool ABBHEILPGDA(Action OOCJAOHFGJK);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool FOJACKNCFCD(Action OOCJAOHFGJK);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7C75D00", Offset = "0x7C74B00", VA = "0x187C75D00")]
	protected void GNNPGHFCJHK(Action OOCJAOHFGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7C758F0", Offset = "0x7C746F0", VA = "0x187C758F0")]
	protected LDHIGNIGDAL BFAGBBFOPFG(float ENFBFHBOFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7C75B40", Offset = "0x7C74940", VA = "0x187C75B40")]
	private void CHPJGINDNBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7C75D60", Offset = "0x7C74B60", VA = "0x187C75D60")]
	[IteratorStateMachine(typeof(JGBELJALPFH))]
	private IEnumerator<HLGDLHCLDFE> MOGFJNNDCEP(float ENFBFHBOFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7C75D20", Offset = "0x7C74B20", VA = "0x187C75D20")]
	[CompilerGenerated]
	private void KDGKOBMEDGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class KEDFGHHLNJD : POIBLIDOLBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float BKPNAPCAFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly int EAMJNJFLCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float NAAKGKOIPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly float[] JCNMNIFPCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int IIAFHFACNJO;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C9A0", Offset = "0x7C6B7A0", VA = "0x187C6C9A0")]
	public KEDFGHHLNJD(Behaviour MOBMLKIIAJP, float NEJAAFJIDPP, int EAMJNJFLCNJ, [Optional] Action PEAMNEHPBJC, float NAAKGKOIPKO = 0f, [Optional] JACPPMCDBFA DDHBLBIAMDM, [Optional] LFEHEKJCJIF CHMCEGCJIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "9")]
	protected override bool ABBHEILPGDA(Action OOCJAOHFGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C720", Offset = "0x7C6B520", VA = "0x187C6C720", Slot = "10")]
	protected override bool FOJACKNCFCD(Action OOCJAOHFGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C920", Offset = "0x7C6B720", VA = "0x187C6C920")]
	private void IDMNBMDFCAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BIPJAPNEBOP : POIBLIDOLBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly float HPHOJBCFLIJ;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C0F0", Offset = "0x7C5AEF0", VA = "0x187C5C0F0")]
	public BIPJAPNEBOP(Behaviour MOBMLKIIAJP, float HPHOJBCFLIJ, [Optional] Action PEAMNEHPBJC, [Optional] JACPPMCDBFA DDHBLBIAMDM, [Optional] LFEHEKJCJIF CHMCEGCJIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "9")]
	protected override bool ABBHEILPGDA(Action OOCJAOHFGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C0B0", Offset = "0x7C5AEB0", VA = "0x187C5C0B0", Slot = "10")]
	protected override bool FOJACKNCFCD(Action OOCJAOHFGJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class BAJIKFFALBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JCHLCBCHNIB : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public JCHLCBCHNIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7C65000", Offset = "0x7C63E00", VA = "0x187C65000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C530", Offset = "0x7C6B330", VA = "0x187C6C530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private CPMKHKOAIIG LLONLELPPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private IHFJNNFFJFE MOBMLKIIAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Action<float> ODBJAFGPOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NMAEDBICFMP BNHHGIBHCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float GDGINLBOCFM;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B540", Offset = "0x7C5A340", VA = "0x187C5B540")]
	public BAJIKFFALBJ(IHFJNNFFJFE MOBMLKIIAJP, float DJJLJOOJOMC, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B120", Offset = "0x7C59F20", VA = "0x187C5B120")]
	private void EHMKMNKAPKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B290", Offset = "0x7C5A090", VA = "0x187C5B290")]
	private void FIOBOHDECEN(string LKNDCPLLKMB, Action HJENHIAJLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B040", Offset = "0x7C59E40", VA = "0x187C5B040")]
	[IteratorStateMachine(typeof(JCHLCBCHNIB))]
	private IEnumerator<HLGDLHCLDFE> CHOGIDPPGHF(Action HJENHIAJLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B0C0", Offset = "0x7C59EC0", VA = "0x187C5B0C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B3C0", Offset = "0x7C5A1C0", VA = "0x187C5B3C0")]
	[CompilerGenerated]
	private void OJBCPFPEFKO(string OMIBAPCKLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class KKIDDADOPAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class GBNDCBJDFAN : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public GBNDCBJDFAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7C65000", Offset = "0x7C63E00", VA = "0x187C65000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7C65070", Offset = "0x7C63E70", VA = "0x187C65070", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private CPMKHKOAIIG LLONLELPPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private MonoBehaviour BJIPLNEIFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action DMALMKGJLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Action<float> ODBJAFGPOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private NMAEDBICFMP BNHHGIBHCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float GDGINLBOCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool AAPFFKNIEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly JACPPMCDBFA DDHBLBIAMDM;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D970", Offset = "0x7C6C770", VA = "0x187C6D970")]
	public KKIDDADOPAP(MonoBehaviour BJIPLNEIFBB, Action DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, [Optional] JACPPMCDBFA DDHBLBIAMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DB00", Offset = "0x7C6C900", VA = "0x187C6DB00")]
	public KKIDDADOPAP(MonoBehaviour BJIPLNEIFBB, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, [Optional] JACPPMCDBFA DDHBLBIAMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DCD0", Offset = "0x7C6CAD0", VA = "0x187C6DCD0")]
	public KKIDDADOPAP(MonoBehaviour BJIPLNEIFBB, float DJJLJOOJOMC, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, bool AAPFFKNIEHD = true, [Optional] JACPPMCDBFA DDHBLBIAMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4658530", Offset = "0x4657330", VA = "0x184658530")]
	private KKIDDADOPAP(JACPPMCDBFA DDHBLBIAMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D740", Offset = "0x7C6C540", VA = "0x187C6D740")]
	internal static KKIDDADOPAP PAIDFBIMLHI(MonoBehaviour BJIPLNEIFBB, float DJJLJOOJOMC, Action<float> DMALMKGJLDE, NMAEDBICFMP BNHHGIBHCCL, bool AAPFFKNIEHD = true, [Optional] JACPPMCDBFA DDHBLBIAMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D1E0", Offset = "0x7C6BFE0", VA = "0x187C6D1E0")]
	private void FKFPDGDAKGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D530", Offset = "0x7C6C330", VA = "0x187C6D530")]
	private void KLJMINMKBGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7C6CEB0", Offset = "0x7C6BCB0", VA = "0x187C6CEB0")]
	private void EHMKMNKAPKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D3A0", Offset = "0x7C6C1A0", VA = "0x187C6D3A0")]
	private void JCGDLPLABMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D0B0", Offset = "0x7C6BEB0", VA = "0x187C6D0B0")]
	private void FIOBOHDECEN(string LKNDCPLLKMB, Action HJENHIAJLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7C6CD40", Offset = "0x7C6BB40", VA = "0x187C6CD40")]
	[IteratorStateMachine(typeof(GBNDCBJDFAN))]
	private IEnumerator<HLGDLHCLDFE> CHOGIDPPGHF(Action HJENHIAJLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7C6CE50", Offset = "0x7C6BC50", VA = "0x187C6CE50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D6B0", Offset = "0x7C6C4B0", VA = "0x187C6D6B0")]
	[CompilerGenerated]
	private void KNGEBADHHPA(string OMIBAPCKLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7C6CDC0", Offset = "0x7C6BBC0", VA = "0x187C6CDC0")]
	[CompilerGenerated]
	private void DMKENPBDJKG(string OMIBAPCKLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D310", Offset = "0x7C6C110", VA = "0x187C6D310")]
	[CompilerGenerated]
	private void IGAEMDEPJKL(string OMIBAPCKLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D020", Offset = "0x7C6BE20", VA = "0x187C6D020")]
	[CompilerGenerated]
	private void FADMOGGICLN(string OMIBAPCKLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Flags]
internal enum GDKHHGCIJOH : byte
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
internal sealed class AJBCNPFDCMA : LFEHEKJCJIF
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float NAJEBBOFAOM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7C59B50", Offset = "0x7C58950", VA = "0x187C59B50", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float LMKAIDMOPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7C59B40", Offset = "0x7C58940", VA = "0x187C59B40", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public double ABFHMOALCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7C59BD0", Offset = "0x7C589D0", VA = "0x187C59BD0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7C59B60", Offset = "0x7C58960", VA = "0x187C59B60")]
	[FOLINPJCBJN.HMBDLNHFFEJ]
	internal static void GGGLAIJELEP(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	[UnityEngine.Scripting.Preserve]
	internal AJBCNPFDCMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface PLJKNKBEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNDLHKGFBLF(string PPKJBGAOBJL);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAKEOPHKCPP();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal interface MPPBODCEOHL
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool KPNNPKOKIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool HOAOKGDMEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class DPNMFDEBIOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public OLHPGDILEMO LMKDKJFEAMN;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int OFCLDJHOLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8F41A0", Offset = "0x8F2FA0", VA = "0x1808F41A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F80", Offset = "0x8F7D80", VA = "0x1808F8F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7C63030", Offset = "0x7C61E30", VA = "0x187C63030")]
	public static HLGDLHCLDFE MLHCADCLJBI(IEnumerator<HLGDLHCLDFE> GOHMHPHHENG, DEOFEDGEDBJ BODJEGHPNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7C63190", Offset = "0x7C61F90", VA = "0x187C63190")]
	public HLGDLHCLDFE MLHCADCLJBI(DEOFEDGEDBJ[] HMPKLMILNCE, IEnumerator<HLGDLHCLDFE>[] ANMCNOIIPPI, HLGDLHCLDFE[] HCMPFOPPLNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7C63000", Offset = "0x7C61E00", VA = "0x187C63000")]
	public void KPALIHDFPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7C62EC0", Offset = "0x7C61CC0", VA = "0x187C62EC0")]
	public void IJPDCEKPMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7C62D80", Offset = "0x7C61B80", VA = "0x187C62D80")]
	public void GEHIECEACIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7C63000", Offset = "0x7C61E00", VA = "0x187C63000")]
	public void LFIAFFGOMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public DPNMFDEBIOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class OLHPGDILEMO
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct JKFEMOIOOMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public DPNMFDEBIOF JBFJBCOBDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public IHFJNNFFJFE BJDNAHCIBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public DEOFEDGEDBJ CIFLMIIGODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<HLGDLHCLDFE> PIAOOODMCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public HLGDLHCLDFE PKLFHMOCCON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public GDKHHGCIJOH MKAPDAPJBJB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct PACNCLGJLFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public NMAEDBICFMP LJNNJGMCOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<JKFEMOIOOMF> CNCGFABIMFK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class CPIILDIGONI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public DEOFEDGEDBJ promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public OLHPGDILEMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IHFJNNFFJFE context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public DPNMFDEBIOF routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public GDKHHGCIJOH coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public HLGDLHCLDFE currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<HLGDLHCLDFE> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CPIILDIGONI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D7C0", Offset = "0x7C5C5C0", VA = "0x187C5D7C0")]
		internal void EJGCGDJHHPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class HCPEOAACGPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public DPNMFDEBIOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public OLHPGDILEMO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HCPEOAACGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C679B0", Offset = "0x7C667B0", VA = "0x187C679B0")]
		internal void GEKLFMOPBMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class DMMOHNFGCLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public DPNMFDEBIOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public OLHPGDILEMO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DMMOHNFGCLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C627E0", Offset = "0x7C615E0", VA = "0x187C627E0")]
		internal void LIGCFNBDOKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class COPAMJCCNOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public DPNMFDEBIOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public OLHPGDILEMO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public COPAMJCCNOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D780", Offset = "0x7C5C580", VA = "0x187C5D780")]
		internal void GJEMCBHLOGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const GDKHHGCIJOH AIOOKMNLBPC = GDKHHGCIJOH.Cancelled | GDKHHGCIJOH.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly NMAEDBICFMP BNHHGIBHCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] FOKFMFHDGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<GDKHHGCIJOH> GNNFDKPDAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> IDLJJOODLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> GMNLBPJPOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> EFAJJAOPNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> PFHHJCJAMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> EJENBNKDELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> KAPKMNMPHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private DPNMFDEBIOF[] DBDJMEJLFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private DEOFEDGEDBJ[] HMPKLMILNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IHFJNNFFJFE[] MDLPOLDCBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<HLGDLHCLDFE>[] JHIGHEEFFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private HLGDLHCLDFE[] HKFENHBABFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int ILIMALDKHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int MLAKJOPIGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int JODNHNBMFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float BEBMECBLJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private DOALGANGMNL LJJHPNJFNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle DAAEFOPCMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<DPNMFDEBIOF> ANFHAPPEEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool EKDNJEKPIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> HICFPEDFBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> FFJBONFBJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool LIIBBFKLOJC;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public PACNCLGJLFB[] HAHEIOAEMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9844C0", Offset = "0x9832C0", VA = "0x1809844C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7C73380", Offset = "0x7C72180", VA = "0x187C73380")]
	private static int MBPOPBGNNDB(NMAEDBICFMP BNHHGIBHCCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7C735E0", Offset = "0x7C723E0", VA = "0x187C735E0")]
	public OLHPGDILEMO(NMAEDBICFMP BNHHGIBHCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7C72FF0", Offset = "0x7C71DF0", VA = "0x187C72FF0")]
	private void LDJJBKMIABA(int OCNDDAEHGPP, int KGMNAGKDPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7C71250", Offset = "0x7C70050", VA = "0x187C71250")]
	public void AANKMNAEMPO(IHFJNNFFJFE MOBMLKIIAJP, HLGDLHCLDFE HAPJJLOGEAE, IEnumerator<HLGDLHCLDFE> GOHMHPHHENG, DEOFEDGEDBJ BODJEGHPNME, [Optional] DPNMFDEBIOF HKMJKGHHGGA, GDKHHGCIJOH NKLIGLABIBF = GDKHHGCIJOH.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7C71E10", Offset = "0x7C70C10", VA = "0x187C71E10")]
	public void DCGPLIBNGEG(IEnumerable<JKFEMOIOOMF> GJKKIMIHMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7C729F0", Offset = "0x7C717F0", VA = "0x187C729F0")]
	private JKFEMOIOOMF JNNHGNNMCIN(int JPPAOAPAKMN)
	{
		return default(JKFEMOIOOMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7C71770", Offset = "0x7C70570", VA = "0x187C71770")]
	private void BLDJCJDJPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3495940", Offset = "0x3494740", VA = "0x183495940")]
	private static void BIKIKPKHMNO<T>(int JPPAOAPAKMN, T[] MJHJAJMKHGO, int IECADCKMGOP, [Optional] T CCAPNGFLHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3495990", Offset = "0x3494790", VA = "0x183495990")]
	private static void BIKIKPKHMNO<T>(int JPPAOAPAKMN, NativeArray<T> MJHJAJMKHGO, int IECADCKMGOP, [Optional] T CCAPNGFLHNM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7C713D0", Offset = "0x7C701D0", VA = "0x187C713D0")]
	private void AHPJPGMKJDF(IEnumerable<JKFEMOIOOMF> GJKKIMIHMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7C71AE0", Offset = "0x7C708E0", VA = "0x187C71AE0")]
	private void BPHEOCKIELN(JKFEMOIOOMF BDONDHCLCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7C71BB0", Offset = "0x7C709B0", VA = "0x187C71BB0")]
	private GHALEEEJLNE DABLJALAJLJ(int PGMKBNJEAGO)
	{
		return default(GHALEEEJLNE);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7C727F0", Offset = "0x7C715F0", VA = "0x187C727F0")]
	public void GJIMCNIDJNK(float NCBOLHCLIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C73300", Offset = "0x7C72100", VA = "0x187C73300")]
	private void LIHEFOCKEEL(Action HJGGLHBFMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C72770", Offset = "0x7C71570", VA = "0x187C72770")]
	private void GCPIEPJHJFD(Action HJGGLHBFMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C72050", Offset = "0x7C70E50", VA = "0x187C72050")]
	public void DNLMFLHLBPH(float NCBOLHCLIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C733B0", Offset = "0x7C721B0", VA = "0x187C733B0")]
	public void MOHLAAINEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C731D0", Offset = "0x7C71FD0", VA = "0x187C731D0")]
	public void LFIAFFGOMGJ(DPNMFDEBIOF NAIBHGEKFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C72EC0", Offset = "0x7C71CC0", VA = "0x187C72EC0")]
	public void LBEFFDAPPBC(DPNMFDEBIOF NAIBHGEKFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C734B0", Offset = "0x7C722B0", VA = "0x187C734B0")]
	public void PLCEMOEOPKH(DPNMFDEBIOF NAIBHGEKFNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class CKKFIMFBLCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly CKKFIMFBLCJ JBBIPKIKKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Action PKAFAHJDEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private bool EICHBLDJPCE;

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public CKKFIMFBLCJ(Action PKAFAHJDEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x738B980", Offset = "0x738A780", VA = "0x18738B980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface JDGKLLFOHDJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T HKHKCHJEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable FHLKMFEOICO(UnityEngine.Object MOBMLKIIAJP, Action<T> MAOPKHGNAJF);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface IDJNCDKAJPP<T> : JDGKLLFOHDJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T HKHKCHJEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class DFOEBCFJFPA<T> : IDJNCDKAJPP<T>, JDGKLLFOHDJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class DJBPIGABDOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public DFOEBCFJFPA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public OFKFKMAPIHD<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DJBPIGABDOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x610D780", Offset = "0x610C580", VA = "0x18610D780")]
		internal void EGGEBBCBIIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static GameObject JKNMJCGAPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<OFKFKMAPIHD<UnityEngine.Object, Action<T>>> FCAGNCHPPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T PABPLDHKJJD;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T HKHKCHJEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xBE0400", Offset = "0xBDF200", VA = "0x180BE0400", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x60FBD10", Offset = "0x60FAB10", VA = "0x1860FBD10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x60FC790", Offset = "0x60FB590", VA = "0x1860FC790")]
	private static bool LGLICOANMAG(T HJGGLHBFMKO, T AGAPPIBJJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x60FC940", Offset = "0x60FB740", VA = "0x1860FC940")]
	public DFOEBCFJFPA(T EMPLIONOJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x60FBF60", Offset = "0x60FAD60", VA = "0x1860FBF60", Slot = "6")]
	public IDisposable FHLKMFEOICO(UnityEngine.Object MOBMLKIIAJP, Action<T> MAOPKHGNAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x60FC450", Offset = "0x60FB250", VA = "0x1860FC450")]
	private void GMCDKFIGOHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal class GNOEHKEOIME : AAHGDAHDHEN
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private class OKLJEJHALOA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private class FAMMALMFDNE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int MIFPCBFGGLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private OKLJEJHALOA HCOHDNBOGPL;

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xD6F350", Offset = "0xD6E150", VA = "0x180D6F350")]
			public FAMMALMFDNE(int MIFPCBFGGLI, OKLJEJHALOA HCOHDNBOGPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x7C649A0", Offset = "0x7C637A0", VA = "0x187C649A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class JACNPICIMAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public JACNPICIMAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xCE2620", Offset = "0xCE1420", VA = "0x180CE2620")]
			internal bool PEJDIBFJKBF(GEGKPNFCBLI e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class PCNJDHNPPNP : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private HLGDLHCLDFE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public OKLJEJHALOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public LFEHEKJCJIF timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			private LMDIONDODDJ <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			private List<GEGKPNFCBLI> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public PCNJDHNPPNP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x7C75320", Offset = "0x7C74120", VA = "0x187C75320", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x7C756B0", Offset = "0x7C744B0", VA = "0x187C756B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly NMAEDBICFMP BNHHGIBHCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private CPMKHKOAIIG BODJEGHPNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private bool ICDJAJEIHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly List<GEGKPNFCBLI> OFEPONFGFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly HashSet<int> LNPLPPJEJPL;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C71170", Offset = "0x7C6FF70", VA = "0x187C71170")]
		public OKLJEJHALOA(NMAEDBICFMP BNHHGIBHCCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C70FE0", Offset = "0x7C6FDE0", VA = "0x187C70FE0")]
		public IDisposable PJGHINABLFL(GEGKPNFCBLI KCAPPJJOPLF, JACPPMCDBFA DDHBLBIAMDM, LFEHEKJCJIF HPEGCCHCIAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C70E50", Offset = "0x7C6FC50", VA = "0x187C70E50")]
		private void KCGKIMCJIDF(int MIFPCBFGGLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C70DC0", Offset = "0x7C6FBC0", VA = "0x187C70DC0")]
		[IteratorStateMachine(typeof(PCNJDHNPPNP))]
		private IEnumerator<HLGDLHCLDFE> FMIPLBLDOOB(LFEHEKJCJIF HPEGCCHCIAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C70D70", Offset = "0x7C6FB70", VA = "0x187C70D70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private class GEGKPNFCBLI
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		public enum DNIOJNGIEFP : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static int HBEBHFIJEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly int OFAGBBGFDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly HECGOLGDACB BJDNAHCIBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private readonly MonoBehaviour OJJNHGPDLCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public readonly Action IGIPDIBMNHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public readonly Action<float> IMEPGKELAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public readonly float JGGPGIGNHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public float IDLJJOODLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public readonly string HIGBIGGFHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public readonly bool DOBIPALDGKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public readonly DNIOJNGIEFP GGBEMIOAIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public bool NKDKKADCCEK;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C652F0", Offset = "0x7C640F0", VA = "0x187C652F0")]
		public GEGKPNFCBLI(HECGOLGDACB MOBMLKIIAJP, Action DMALMKGJLDE, bool MIDJALFGDGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C65650", Offset = "0x7C64450", VA = "0x187C65650")]
		public GEGKPNFCBLI(HECGOLGDACB MOBMLKIIAJP, Action<float> DMALMKGJLDE, bool MIDJALFGDGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C65470", Offset = "0x7C64270", VA = "0x187C65470")]
		public GEGKPNFCBLI(HECGOLGDACB MOBMLKIIAJP, float DJJLJOOJOMC, Action<float> DMALMKGJLDE, LFEHEKJCJIF HPEGCCHCIAG, DNIOJNGIEFP AMDMCGKIPKI, bool AAPFFKNIEHD, bool MIDJALFGDGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C65120", Offset = "0x7C63F20", VA = "0x187C65120")]
		public bool IAMFCINPGBG(float LEAPIIAHEEF, float KAHALBDEBIN)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly JACPPMCDBFA DDHBLBIAMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly LFEHEKJCJIF CHMCEGCJIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly Dictionary<NMAEDBICFMP, OKLJEJHALOA> EIGMCMGLMGG;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C671A0", Offset = "0x7C65FA0", VA = "0x187C671A0")]
	[FOLINPJCBJN.HMBDLNHFFEJ]
	internal static void KDEFPENCKFJ(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C67310", Offset = "0x7C66110", VA = "0x187C67310")]
	[UnityEngine.Scripting.Preserve]
	internal GNOEHKEOIME([MHFJPMCEEAM(null)] JACPPMCDBFA DDHBLBIAMDM, [MHFJPMCEEAM(null)] LFEHEKJCJIF CHMCEGCJIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C66FB0", Offset = "0x7C65DB0", VA = "0x187C66FB0", Slot = "4")]
	public IDisposable IGIPDIBMNHA(HECGOLGDACB MOBMLKIIAJP, Action JMGOMJNPFIN, NMAEDBICFMP BNHHGIBHCCL, bool MIDJALFGDGH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C66DC0", Offset = "0x7C65BC0", VA = "0x187C66DC0", Slot = "5")]
	public IDisposable IGIPDIBMNHA(HECGOLGDACB MOBMLKIIAJP, Action<float> JMGOMJNPFIN, NMAEDBICFMP BNHHGIBHCCL, bool MIDJALFGDGH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C66980", Offset = "0x7C65780", VA = "0x187C66980", Slot = "7")]
	public IDisposable ENOMOIFFLNP(HECGOLGDACB MOBMLKIIAJP, float DJJLJOOJOMC, Action<float> JMGOMJNPFIN, NMAEDBICFMP BNHHGIBHCCL, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C67210", Offset = "0x7C66010", VA = "0x187C67210", Slot = "8")]
	public IDisposable NMDIPMACEHG(HECGOLGDACB MOBMLKIIAJP, float DJJLJOOJOMC, Action<float> JMGOMJNPFIN, NMAEDBICFMP BNHHGIBHCCL, bool AAPFFKNIEHD = true, bool MIDJALFGDGH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7C66A80", Offset = "0x7C65880", VA = "0x187C66A80", Slot = "6")]
	public IDisposable ENOMOIFFLNP(float DJJLJOOJOMC, Action<float> JMGOMJNPFIN, bool AAPFFKNIEHD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C66C00", Offset = "0x7C65A00", VA = "0x187C66C00", Slot = "9")]
	public void GCNCDDFOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C667F0", Offset = "0x7C655F0", VA = "0x187C667F0")]
	private OKLJEJHALOA DDKLFOBCKHA(NMAEDBICFMP BNHHGIBHCCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class KLAGPDJDPJI : APPMFKHANOA, JACPPMCDBFA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private OLHPGDILEMO[] DCIKJFJMNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private PLJKNKBEAAM OGIECKIHNCD;

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E260", Offset = "0x7C6D060", VA = "0x187C6E260")]
	[FOLINPJCBJN.HMBDLNHFFEJ]
	internal static void GGGLAIJELEP(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EA80", Offset = "0x7C6D880", VA = "0x187C6EA80")]
	[UnityEngine.Scripting.Preserve]
	public KLAGPDJDPJI([MHFJPMCEEAM(null)] HIGADNGFPAD NHFCBGAPAOH, [MHFJPMCEEAM(null)] LFEHEKJCJIF CHMCEGCJIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E920", Offset = "0x7C6D720", VA = "0x187C6E920", Slot = "19")]
	public override CPMKHKOAIIG NELHOCEIBCO(IHFJNNFFJFE MOBMLKIIAJP, IEnumerator<HLGDLHCLDFE> LDEFNCGJMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DFD0", Offset = "0x7C6CDD0", VA = "0x187C6DFD0", Slot = "20")]
	public override void GCNCDDFOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E2D0", Offset = "0x7C6D0D0", VA = "0x187C6E2D0", Slot = "22")]
	public override void GLKLCAGLDFA(NMAEDBICFMP BNHHGIBHCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E730", Offset = "0x7C6D530", VA = "0x187C6E730", Slot = "21")]
	protected override void IGIPDIBMNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EA50", Offset = "0x7C6D850", VA = "0x187C6EA50")]
	private OLHPGDILEMO PCMIGPJDIBI(NMAEDBICFMP OBDHBADPJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E500", Offset = "0x7C6D300", VA = "0x187C6E500", Slot = "23")]
	internal override JAKIDIGMCDE HJBOINPJCLB(IEnumerator<HLGDLHCLDFE> LDEFNCGJMPG, Behaviour MOBMLKIIAJP, DEOFEDGEDBJ BODJEGHPNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DEB0", Offset = "0x7C6CCB0", VA = "0x187C6DEB0", Slot = "24")]
	internal override IAGEKNPOIDI CEILBHMNCDH(NMAEDBICFMP HCOHDNBOGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E800", Offset = "0x7C6D600", VA = "0x187C6E800")]
	private void LKJCMGLLGDP(OLHPGDILEMO NHNAMAEIGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DF70", Offset = "0x7C6CD70", VA = "0x187C6DF70", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[BurstCompile]
internal struct DOALGANGMNL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	public float PGKNEHFNHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	public int FGDEHOMBHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<int> IDLAFCCJMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private NativeArray<int> JHNPIFFOCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private NativeArray<int> DBGBKBPHIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ReadOnly]
	public NativeArray<GDKHHGCIJOH> NNLIAOKDMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ReadOnly]
	public NativeArray<float> FMDPNLKICDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[WriteOnly]
	public NativeArray<int> PFHHJCJAMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[WriteOnly]
	public NativeArray<int> GMNLBPJPOGK;

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C628C0", Offset = "0x7C616C0", VA = "0x187C628C0")]
	public static DOALGANGMNL DCMOGLEGFAE(int KHFFNAHIMBJ, float NCBOLHCLIAA, NativeArray<GDKHHGCIJOH> MODGDCCGPHD, NativeArray<float> FMKGDBHOJCI, NativeArray<int> KKAOEIEFAFH, NativeArray<int> DNJCCNCFACM, NativeArray<int> GBOAOLJBCFJ, NativeArray<int> JHNPIFFOCHN, NativeArray<int> DBGBKBPHIDJ)
	{
		return default(DOALGANGMNL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C62920", Offset = "0x7C61720", VA = "0x187C62920", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C62A00", Offset = "0x7C61800", VA = "0x187C62A00")]
	private bool GIDLFKDKGDP(int KNCPCNBMDNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C62C80", Offset = "0x7C61A80", VA = "0x187C62C80")]
	private void IJEKKMAILCA(NativeArray<int> BAINIFMGFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C62820", Offset = "0x7C61620", VA = "0x187C62820")]
	private int CAILPBHHHOJ(int DAKHHMBDBJN, int GNCBOIHDKGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7C62CB0", Offset = "0x7C61AB0", VA = "0x187C62CB0")]
	private void INEILPBLOEG(NativeArray<int> BAINIFMGFOO, int AKHGLHHEKNN, int MLFMLAODHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7C62A40", Offset = "0x7C61840", VA = "0x187C62A40")]
	private void IGOLHEJNIIF(NativeArray<int> BAINIFMGFOO, int BFHBBJCDGJO, int GCBFNMDNOPA, int EBJOPAGPGEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class APPMFKHANOA : JACPPMCDBFA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly HIGADNGFPAD NHFCBGAPAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	protected readonly LFEHEKJCJIF CHMCEGCJIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private IAGEKNPOIDI[] ECPOJIMOMBG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static JACPPMCDBFA GGJCMHODIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A740", Offset = "0x7C59540", VA = "0x187C5A740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NMAEDBICFMP PDFBDFDPNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8F41A0", Offset = "0x8F2FA0", VA = "0x1808F41A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NMAEDBICFMP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F80", Offset = "0x8F7D80", VA = "0x1808F8F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LFEHEKJCJIF NNGIICMJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public HLGDLHCLDFE MHLBALJNJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public HLGDLHCLDFE BGJGKGPGNPN
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public HLGDLHCLDFE NFDLHDFANFK
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public HLGDLHCLDFE HDCBOOFODKL
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8F4230", Offset = "0x8F3030", VA = "0x1808F4230", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A6B0", Offset = "0x7C594B0", VA = "0x187C5A6B0")]
	public static CPMKHKOAIIG JFCBHNFOICD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7C5AB50", Offset = "0x7C59950", VA = "0x187C5AB50")]
	[UnityEngine.Scripting.Preserve]
	protected APPMFKHANOA([MHFJPMCEEAM(null)] HIGADNGFPAD NHFCBGAPAOH, [MHFJPMCEEAM(null)] LFEHEKJCJIF CHMCEGCJIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A850", Offset = "0x7C59650", VA = "0x187C5A850", Slot = "6")]
	public CPMKHKOAIIG NJAAPHNJHEI(IEnumerator<HLGDLHCLDFE> LDEFNCGJMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A860", Offset = "0x7C59660", VA = "0x187C5A860", Slot = "7")]
	public CPMKHKOAIIG NJAAPHNJHEI(Behaviour MOBMLKIIAJP, IEnumerator<HLGDLHCLDFE> LDEFNCGJMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract CPMKHKOAIIG NELHOCEIBCO(IHFJNNFFJFE MOBMLKIIAJP, IEnumerator<HLGDLHCLDFE> LDEFNCGJMPG);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A220", Offset = "0x7C59020", VA = "0x187C5A220", Slot = "20")]
	public virtual void GCNCDDFOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A3C0", Offset = "0x7C591C0", VA = "0x187C5A3C0", Slot = "9")]
	public void GIOFAJHPJLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A690", Offset = "0x7C59490", VA = "0x187C5A690", Slot = "21")]
	protected virtual void IGIPDIBMNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A030", Offset = "0x7C58E30", VA = "0x187C5A030")]
	private void FPDNMDOEOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A7B0", Offset = "0x7C595B0", VA = "0x187C5A7B0")]
	private void KCAKOMKIHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A010", Offset = "0x7C58E10", VA = "0x187C5A010")]
	private void ECENMMIAFIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7C59C10", Offset = "0x7C58A10", VA = "0x187C59C10")]
	private void DGCKJAGEBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A7D0", Offset = "0x7C595D0", VA = "0x187C5A7D0")]
	private void LNAMFIBMOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7C59FF0", Offset = "0x7C58DF0", VA = "0x187C59FF0")]
	private void ECEJBHEBBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7C59BF0", Offset = "0x7C589F0", VA = "0x187C59BF0")]
	private void BNJELPHLOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A600", Offset = "0x7C59400", VA = "0x187C5A600", Slot = "22")]
	public virtual void GLKLCAGLDFA(NMAEDBICFMP BNHHGIBHCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A050", Offset = "0x7C58E50", VA = "0x187C5A050")]
	private void GCHMHPMBPBG(IAGEKNPOIDI NHNAMAEIGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2430930", Offset = "0x242F730", VA = "0x182430930")]
	private IAGEKNPOIDI BBIGOMECHDM(NMAEDBICFMP OBDHBADPJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract JAKIDIGMCDE HJBOINPJCLB(IEnumerator<HLGDLHCLDFE> LDEFNCGJMPG, Behaviour BJIPLNEIFBB, DEOFEDGEDBJ OGMPPHFOKBL);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract IAGEKNPOIDI CEILBHMNCDH(NMAEDBICFMP BNHHGIBHCCL);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7C59C30", Offset = "0x7C58A30", VA = "0x187C59C30", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A7F0", Offset = "0x7C595F0", VA = "0x187C5A7F0", Slot = "15")]
	public HLGDLHCLDFE NIKOPKMJOAN(NMAEDBICFMP HCOHDNBOGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7C5AA60", Offset = "0x7C59860", VA = "0x187C5AA60", Slot = "16")]
	public HLGDLHCLDFE ODALBPOMAKM(float CIOLBCCFHKE, NMAEDBICFMP HCOHDNBOGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7C5AAF0", Offset = "0x7C598F0", VA = "0x187C5AAF0", Slot = "17")]
	public HLGDLHCLDFE PLMEBHPFMEP(Func<bool> PKDNIKFJMDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal sealed class JAKIDIGMCDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly DEOFEDGEDBJ BODJEGHPNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly MPPBODCEOHL MOBMLKIIAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly bool ALLMLJIMJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private string PPKJBGAOBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private StackTrace EKEDDCCAJLF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public IEnumerator<HLGDLHCLDFE> PIAOOODMCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public HLGDLHCLDFE PKLFHMOCCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool DKJGFGOMHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C060", Offset = "0x7C6AE60", VA = "0x187C6C060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FPOOIHCBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xADD5A0", Offset = "0xADC3A0", VA = "0x180ADD5A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAFFF00", Offset = "0xAFED00", VA = "0x180AFFF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C0E0", Offset = "0x7C6AEE0", VA = "0x187C6C0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public float CELBKGEDHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xEB2BC0", Offset = "0xEB19C0", VA = "0x180EB2BC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x110DFA0", Offset = "0x110CDA0", VA = "0x18110DFA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C370", Offset = "0x7C6B170", VA = "0x187C6C370")]
	public JAKIDIGMCDE(IEnumerator<HLGDLHCLDFE> GOHMHPHHENG, MPPBODCEOHL MOBMLKIIAJP, DEOFEDGEDBJ BODJEGHPNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BD40", Offset = "0x7C6AB40", VA = "0x187C6BD40")]
	public HLGDLHCLDFE MLHCADCLJBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BC80", Offset = "0x7C6AA80", VA = "0x187C6BC80")]
	public bool FFOJKFFICHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BCF0", Offset = "0x7C6AAF0", VA = "0x187C6BCF0")]
	public void LFIAFFGOMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C290", Offset = "0x7C6B090", VA = "0x187C6C290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xC65200", Offset = "0xC64000", VA = "0x180C65200")]
	[CompilerGenerated]
	private void LNHFKPAJOBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class DEOFEDGEDBJ : MLDKEGIOPPG, CPMKHKOAIIG, NAEGINDHOLH, LDHIGNIGDAL, IEnumerator, HLGDLHCLDFE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private NMAEDBICFMP AKANHEAGNBE;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private NMAEDBICFMP HGCIIFFGDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xC19410", Offset = "0xC18210", VA = "0x180C19410", Slot = "23")]
		get
		{
			return default(NMAEDBICFMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NMAEDBICFMP LMKDKJFEAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xDAADC0", Offset = "0xDA9BC0", VA = "0x180DAADC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private float ONDICPFCHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA873D0", Offset = "0xA861D0", VA = "0x180A873D0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool IJLJEFFLMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7C62740", Offset = "0x7C61540", VA = "0x187C62740", Slot = "24")]
	private bool OCOPPDMOEBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7C62730", Offset = "0x7C61530", VA = "0x187C62730", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7C62760", Offset = "0x7C61560", VA = "0x187C62760")]
	public DEOFEDGEDBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal enum GHALEEEJLNE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class IAGEKNPOIDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public enum KIBHPDEPIPC
	{
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public struct AJDNPPAJKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public NMAEDBICFMP LJNNJGMCOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public KIBHPDEPIPC DFJBGCGDNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public List<JAKIDIGMCDE> HKPFODHNFCL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly KIBHPDEPIPC[] HHDFILHFKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly NMAEDBICFMP BNHHGIBHCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private bool MCOLHMKEJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly JAKIDIGMCDE[] DGFBOFNHBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly List<JAKIDIGMCDE> CDBDJFJIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Stack<int> JADNJGAAJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly List<JAKIDIGMCDE> JOMKPHIAHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly Stack<int> JGKBNELELOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly PLJKNKBEAAM NJDBKLIONID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private bool LIIBBFKLOJC;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public AJDNPPAJKMN[,] IPICKOOGPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7C697B0", Offset = "0x7C685B0", VA = "0x187C697B0")]
	public IAGEKNPOIDI(NMAEDBICFMP HCOHDNBOGPL, PLJKNKBEAAM NJDBKLIONID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7C68F90", Offset = "0x7C67D90", VA = "0x187C68F90")]
	public void HDFPOIHAJFJ(JAKIDIGMCDE GOHMHPHHENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7C69390", Offset = "0x7C68190", VA = "0x187C69390")]
	public void PLPNAHPPPOD(IList<JAKIDIGMCDE> ANMCNOIIPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7C68290", Offset = "0x7C67090", VA = "0x187C68290")]
	public void BLLBMFGHKIC(IList<JAKIDIGMCDE> ANMCNOIIPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7C68810", Offset = "0x7C67610", VA = "0x187C68810")]
	private void EMKJKGFAMBF(JAKIDIGMCDE GOHMHPHHENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7C68690", Offset = "0x7C67490", VA = "0x187C68690")]
	private void EBPGAPHCABK(IList<JAKIDIGMCDE> ANMCNOIIPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7C690A0", Offset = "0x7C67EA0", VA = "0x187C690A0")]
	private GHALEEEJLNE HKNIBGCFONH(JAKIDIGMCDE GOHMHPHHENG)
	{
		return default(GHALEEEJLNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7C69220", Offset = "0x7C68020", VA = "0x187C69220")]
	public void IGIPDIBMNHA(float NCBOLHCLIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7C68DA0", Offset = "0x7C67BA0", VA = "0x187C68DA0")]
	public void GIOFAJHPJLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7C68900", Offset = "0x7C67700", VA = "0x187C68900")]
	private void FHEFNAIEOMJ(List<JAKIDIGMCDE> ANMCNOIIPPI, Stack<int> BHFGCCOJBAK, bool DJMDHNPDHIE, float PDKCKEMPOJM = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7C68570", Offset = "0x7C67370", VA = "0x187C68570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7C68C60", Offset = "0x7C67A60", VA = "0x187C68C60")]
	private void FLKCMICNNDD(List<JAKIDIGMCDE> ANMCNOIIPPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal class BGDNOHOCDFO : PLJKNKBEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
	public void JNDLHKGFBLF(string PPKJBGAOBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
	public void KAKEOPHKCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public BGDNOHOCDFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal class CKEAGAAIACO : MPPBODCEOHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly Behaviour BJIPLNEIFBB;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CAE0", Offset = "0x7C5B8E0", VA = "0x187C5CAE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool KPNNPKOKIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CA70", Offset = "0x7C5B870", VA = "0x187C5CA70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool HOAOKGDMEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CAC0", Offset = "0x7C5B8C0", VA = "0x187C5CAC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public CKEAGAAIACO(Behaviour BJIPLNEIFBB)
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

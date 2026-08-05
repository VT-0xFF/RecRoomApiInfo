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
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x803E750", Offset = "0x803DB50", VA = "0x18803E750", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8048100", Offset = "0x8047500", VA = "0x188048100", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
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
		private delegate List<PlayerLoopSystem> ACOLJFKIFOC(List<PlayerLoopSystem> IHMFGFCDNNM, int IPNIEDHMIMN);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct EEGEDHOMEBI
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct JGGMCKDLPLG
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static EBGLFEEDNOA PJLEGCPCGLG;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x803A930", Offset = "0x8039D30", VA = "0x18803A930")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct IMBHOBOPGEO
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static EBGLFEEDNOA BMPCKDHAPBF;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x803A1E0", Offset = "0x80395E0", VA = "0x18803A1E0")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct BFCGCALDFDI
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static EBGLFEEDNOA KPACIPEGDEK;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x802BE40", Offset = "0x802B240", VA = "0x18802BE40")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct AIJDCLJFLAF
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static EBGLFEEDNOA CONHGCJJKNK;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static EBGLFEEDNOA AFNJDOHFMCC;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static EBGLFEEDNOA PMMMDIEBKLA;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static EBGLFEEDNOA CKMEDCOMDIO;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x802B5D0", Offset = "0x802A9D0", VA = "0x18802B5D0")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct OILFAFMIKFM
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static EBGLFEEDNOA JFDENHFPECJ;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x8041730", Offset = "0x8040B30", VA = "0x188041730")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct HONPIBHIIKA
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static EBGLFEEDNOA CONHGCJJKNK;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static EBGLFEEDNOA AFNJDOHFMCC;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static EBGLFEEDNOA PMMMDIEBKLA;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static EBGLFEEDNOA CKMEDCOMDIO;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x8039B60", Offset = "0x8038F60", VA = "0x188039B60")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct DCDIDJOFAOE
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static EBGLFEEDNOA MEOIJAPEJPO;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x80322D0", Offset = "0x80316D0", VA = "0x1880322D0")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct JGJJKCOJLHG
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static EBGLFEEDNOA FBFNJAGBEBI;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x803AB10", Offset = "0x8039F10", VA = "0x18803AB10")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct EPIEPACDHNC
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static EBGLFEEDNOA LJGKDLFNEBI;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x8033C90", Offset = "0x8033090", VA = "0x188033C90")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct ALNNPBAHPHF
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static EBGLFEEDNOA OLLCDEFFFDF;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x802BA80", Offset = "0x802AE80", VA = "0x18802BA80")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct IGJLPFNFAPF
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static EBGLFEEDNOA JGBMFIFOKLC;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x8039E30", Offset = "0x8039230", VA = "0x188039E30")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct ACMPPEGLJMI
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static EBGLFEEDNOA JJKGMFHNFJI;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x802B3F0", Offset = "0x802A7F0", VA = "0x18802B3F0")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct AIPBEMMNCKO
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static EBGLFEEDNOA MNJCAOBCLIG;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x802B8A0", Offset = "0x802ACA0", VA = "0x18802B8A0")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct LFLOLHAAOIF
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static EBGLFEEDNOA CCMLPNJGOAC;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x803D960", Offset = "0x803CD60", VA = "0x18803D960")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct GAACNJFNMEN
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static EBGLFEEDNOA MGJGHGIDAPK;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x8034CC0", Offset = "0x80340C0", VA = "0x188034CC0")]
				public static PlayerLoopSystem BIMJEOMACPL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum JCJIGHIAJAH : byte
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
			public struct BGGABBJHBPH
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class LCFDAFFBDOF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public JCJIGHIAJAH updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
					public LCFDAFFBDOF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x803D8E0", Offset = "0x803CCE0", VA = "0x18803D8E0")]
					internal void PPPGGPOJCPO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static CLNABAPAGFB<JCJIGHIAJAH> NGDKFMPOGJD;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x802C020", Offset = "0x802B420", VA = "0x18802C020")]
				public static PlayerLoopSystem BIMJEOMACPL(JCJIGHIAJAH PACHBPNLIHJ)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct JIEFAMMPDBB
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class PEJBPEEEOBH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public HOFONIIAPMI.NMEIGJIMCFL key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
					public PEJBPEEEOBH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x80454A0", Offset = "0x80448A0", VA = "0x1880454A0")]
					internal void JHABKICKJCK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable CKLPPABIDPA;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x803ACF0", Offset = "0x803A0F0", VA = "0x18803ACF0")]
				public static PlayerLoopSystem HFJKGJPMAJF(HOFONIIAPMI.NMEIGJIMCFL MCNLCGLNHHO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct CEMGAGFEENJ
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class KNNKFAABDFC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public HOFONIIAPMI.NMEIGJIMCFL key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
					public KNNKFAABDFC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x803D050", Offset = "0x803C450", VA = "0x18803D050")]
					internal void JHABKICKJCK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x802D3D0", Offset = "0x802C7D0", VA = "0x18802D3D0")]
				public static PlayerLoopSystem HFJKGJPMAJF(HOFONIIAPMI.NMEIGJIMCFL MCNLCGLNHHO)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class EHIHIGBNAPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public EHIHIGBNAPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x80334C0", Offset = "0x80328C0", VA = "0x1880334C0")]
			internal List<PlayerLoopSystem> HGDMCFFPEHC(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool NNIBHEKMPGD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool FCCMHHPGAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8032290", Offset = "0x8031690", VA = "0x188032290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x802E020", Offset = "0x802D420", VA = "0x18802E020")]
		private static void ABMBKENGLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8031980", Offset = "0x8030D80", VA = "0x188031980")]
		private static void KNIAGBKHNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8031030", Offset = "0x8030430", VA = "0x188031030")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8031580", Offset = "0x8030980", VA = "0x188031580")]
		private static void FFBNNBLIDFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80317C0", Offset = "0x8030BC0", VA = "0x1880317C0")]
		private static void HJLGAFEKNCM(HOFONIIAPMI.NMEIGJIMCFL MCNLCGLNHHO, PlayerLoopSystem PJLFFFKJNFC, Type GLEDNOLKCOE, Type LBMOBJINIMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8031070", Offset = "0x8030470", VA = "0x188031070")]
		private static void BALANPALEDA(PlayerLoopSystem PJLFFFKJNFC, Type GLEDNOLKCOE, Type LBMOBJINIMC, ACOLJFKIFOC OFCPNONBFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8031450", Offset = "0x8030850", VA = "0x188031450")]
		private static void FDOCMHGBMCH(PlayerLoopSystem PJLFFFKJNFC, Type GLEDNOLKCOE, Type LBMOBJINIMC, PlayerLoopSystem? EBPMCHNKIDE, PlayerLoopSystem? BFBCBBIIJHN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HOFONIIAPMI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum NMEIGJIMCFL
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
	public class CFLJDHMAPDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly NMEIGJIMCFL JKMHFGKFABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly MGJPIIMMKAP ALDOMNJEKFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long GJLNNKKHIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long OAPPAGGONCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long PINBEDGPJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int NEHNODOJEHN;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x802D650", Offset = "0x802CA50", VA = "0x18802D650")]
		public CFLJDHMAPDP(NMEIGJIMCFL HGJNFJANOOI, int FBHHCGNMNGJ = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x802D630", Offset = "0x802CA30", VA = "0x18802D630")]
		public void NKGPMLFPKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x802D5E0", Offset = "0x802C9E0", VA = "0x18802D5E0")]
		public void DPMEHNAHKLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x802D500", Offset = "0x802C900", VA = "0x18802D500")]
		public void BNIHEIMJPGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static NMEIGJIMCFL[] AAPNNAGGOKE;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static CFLJDHMAPDP[] OIHCCPEPKPH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8039280", Offset = "0x8038680", VA = "0x188039280")]
	public static CFLJDHMAPDP FNEJDLNJIDA(NMEIGJIMCFL MCNLCGLNHHO, int FBHHCGNMNGJ = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8039210", Offset = "0x8038610", VA = "0x188039210")]
	public static CFLJDHMAPDP CHCDIGAIMFC(NMEIGJIMCFL MCNLCGLNHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x80393D0", Offset = "0x80387D0", VA = "0x1880393D0")]
	public static void OAGPLMAJNFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CACMNCABDOC
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface IMBDEDMMKFM
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool ICCBPGNFIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JGMHMMHEKDA();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class CJPJGKDGBJL : IMBDEDMMKFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action NJNJGNMEACN;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool ICCBPGNFIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
		public CJPJGKDGBJL(Action NJNJGNMEACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xFD7510", Offset = "0xFD6910", VA = "0x180FD7510", Slot = "5")]
		public void JGMHMMHEKDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<IMBDEDMMKFM> GJHPPKOCEED;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x802CDF0", Offset = "0x802C1F0", VA = "0x18802CDF0")]
	public static void ENCAFNAKBEM(Action NJNJGNMEACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x802CBE0", Offset = "0x802BFE0", VA = "0x18802CBE0")]
	private static void DEEDEFJNHGA(IMBDEDMMKFM AIOEJHICLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x802CF90", Offset = "0x802C390", VA = "0x18802CF90")]
	private static void KMKONAFILFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x802CE90", Offset = "0x802C290", VA = "0x18802CE90")]
	private static void KLCEAACFDOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x802D270", Offset = "0x802C670", VA = "0x18802D270")]
	private static void OANCMAIHPKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class NMBEFLANIHA
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct ECPJCAEAGOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> IBGJKBMKFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string ENFELFHDLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode BHAPGMOMFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool NENHJLNAGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8033420", Offset = "0x8032820", VA = "0x188033420")]
		public ECPJCAEAGOL(TaskCompletionSource<Scene> MCKEDAHELGN, string ENFELFHDLFE, LoadSceneMode BHAPGMOMFKE, bool NENHJLNAGOD, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct COAGLPFKBDJ : IAsyncStateMachine
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
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private PGLLJHOKMII<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x802D6E0", Offset = "0x802CAE0", VA = "0x18802D6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x802DF80", Offset = "0x802D380", VA = "0x18802DF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct OPKAJFIKFNJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8041910", Offset = "0x8040D10", VA = "0x188041910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8041C20", Offset = "0x8041020", VA = "0x188041C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct MOLJHOKDPBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ECPJCAEAGOL <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x803ECA0", Offset = "0x803E0A0", VA = "0x18803ECA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x803F060", Offset = "0x803E460", VA = "0x18803F060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class FNPBAJKBGGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CNGGNFIPEFD<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public FNPBAJKBGGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8034C60", Offset = "0x8034060", VA = "0x188034C60")]
		internal void PBHDAHMEFNC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct PFGBAKAEGLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

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
		private FNPBAJKBGGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private PGLLJHOKMII<string>.GLACLJPMODI <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private PGLLJHOKMII<string>.GLACLJPMODI <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8045850", Offset = "0x8044C50", VA = "0x188045850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x80463F0", Offset = "0x80457F0", VA = "0x1880463F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct KIMNEBAOKBA : IAsyncStateMachine
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
		private CPNFFAJCLON <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x803C8E0", Offset = "0x803BCE0", VA = "0x18803C8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x803CFA0", Offset = "0x803C3A0", VA = "0x18803CFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct LKLLAFCLNII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public PGLLJHOKMII<string>.GLACLJPMODI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private PGLLJHOKMII<string>.GLACLJPMODI <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private PGLLJHOKMII<string>.GLACLJPMODI <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x803DB40", Offset = "0x803CF40", VA = "0x18803DB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x803E660", Offset = "0x803DA60", VA = "0x18803E660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class MKJACEIKBFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CNGGNFIPEFD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MKJACEIKBFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x803E7E0", Offset = "0x803DBE0", VA = "0x18803E7E0")]
		internal bool IDEHLAOMGPK(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x803E860", Offset = "0x803DC60", VA = "0x18803E860")]
		internal void JFLAKIHHMJG(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class HDOFKNEMGAI : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CNGGNFIPEFD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private MKJACEIKBFF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private CPNFFAJCLON <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public HDOFKNEMGAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8036190", Offset = "0x8035590", VA = "0x188036190", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x80358C0", Offset = "0x8034CC0", VA = "0x1880358C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x80358A0", Offset = "0x8034CA0", VA = "0x1880358A0")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8036140", Offset = "0x8035540", VA = "0x188036140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> DODHOBACPEP;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static OCLDKMPDLBK FLMPGLFGJPK;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation HDABBIFOHAG;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static OCLDKMPDLBK GDIEIIBDCCO;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string JHPDJNKKHFO;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string NKPBBMEDOMI;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority FDNECKGHLGO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task FLDACKAOAPI;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> OODJAIFPHMM;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<ECPJCAEAGOL> CPIMNGAIABE;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task CGOJHJGMEOG;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> OEDELIHCOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x803F890", Offset = "0x803EC90", VA = "0x18803F890")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8040A00", Offset = "0x803FE00", VA = "0x188040A00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x80405B0", Offset = "0x803F9B0", VA = "0x1880405B0")]
	[HKOIOMMKCJI(PPIOLDHAHGF.EnteredEditModeNextFrame, 0)]
	private static void KCKLJNCPNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x80408B0", Offset = "0x803FCB0", VA = "0x1880408B0")]
	[AsyncStateMachine(typeof(COAGLPFKBDJ))]
	public static Task<Scene> NHILJLCBNDJ(string ENFELFHDLFE, LoadSceneMode BHAPGMOMFKE = LoadSceneMode.Single, bool NENHJLNAGOD = false, [Optional] PGLLJHOKMII<string>.GLACLJPMODI IAHFHOCJBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8040800", Offset = "0x803FC00", VA = "0x188040800")]
	[AsyncStateMachine(typeof(OPKAJFIKFNJ))]
	private static Task LDHMJDDJJMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x803FD40", Offset = "0x803F140", VA = "0x18803FD40")]
	[AsyncStateMachine(typeof(MOLJHOKDPBG))]
	private static Task FNEDGGOBHMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x80402E0", Offset = "0x803F6E0", VA = "0x1880402E0")]
	[AsyncStateMachine(typeof(PFGBAKAEGLJ))]
	private static Task<Scene> IOHBPNNLPPN(string ENFELFHDLFE, LoadSceneMode BHAPGMOMFKE, bool NENHJLNAGOD, PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x80406A0", Offset = "0x803FAA0", VA = "0x1880406A0")]
	private static void KKMHMGPMLCC(SceneInstance HCADPGAHONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x803FF00", Offset = "0x803F300", VA = "0x18803FF00")]
	private static void GNMBNJOPFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x803FB00", Offset = "0x803EF00", VA = "0x18803FB00")]
	[AsyncStateMachine(typeof(KIMNEBAOKBA))]
	private static Task<Scene> ENFHFACHPLI(string ENFELFHDLFE, LoadSceneMode BHAPGMOMFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x803FE10", Offset = "0x803F210", VA = "0x18803FE10")]
	private static bool GIPIAGDPCOM(string ENFELFHDLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x803FC30", Offset = "0x803F030", VA = "0x18803FC30")]
	[AsyncStateMachine(typeof(LKLLAFCLNII))]
	private static Task<Scene> FLBODLKHCFB(PGLLJHOKMII<string>.GLACLJPMODI NGFKIKEJOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8040430", Offset = "0x803F830", VA = "0x188040430")]
	public static HHPFDJMLPAL<Scene> JDMJMAOGKEA(string ENFELFHDLFE, LoadSceneMode BHAPGMOMFKE = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x803F9A0", Offset = "0x803EDA0", VA = "0x18803F9A0")]
	[IteratorStateMachine(typeof(HDOFKNEMGAI))]
	private static IEnumerator<MOLDBMJPKNN> AKGHAECKKHK(string ENFELFHDLFE, LoadSceneMode BHAPGMOMFKE, CNGGNFIPEFD<Scene> KHGKLFCCEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x80407A0", Offset = "0x803FBA0", VA = "0x1880407A0")]
	public static void KOEIPBAOFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x803FA40", Offset = "0x803EE40", VA = "0x18803FA40")]
	private static void DCJGEJCHOFC(string ENFELFHDLFE, LoadSceneMode BHAPGMOMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x80401B0", Offset = "0x803F5B0", VA = "0x1880401B0")]
	public static bool IDPFEDNNOGE([Out] string BMNGNHKFLJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class MMMBCKLKHCC
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x803EAC0", Offset = "0x803DEC0", VA = "0x18803EAC0")]
	public static IDisposable AJOBGHAJICD(this MDLJCBDCMCN MEBLJIBNLCL, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x803EB50", Offset = "0x803DF50", VA = "0x18803EB50")]
	public static IDisposable LBGCBPNPHNO(this MDLJCBDCMCN MEBLJIBNLCL, Action<float> ONOFIEDKHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x803EBD0", Offset = "0x803DFD0", VA = "0x18803EBD0")]
	public static IDisposable LGJKCOIIFCB(this MDLJCBDCMCN MEBLJIBNLCL, Action<float> ONOFIEDKHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class APMLMDGINLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1BE0", Offset = "0x3BD0FE0", VA = "0x183BD1BE0")]
	[HGAKIEJIDNO]
	public static IDisposable BMOMJPAAMCO<T>(this T BLJNEKMFAAG, Action ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1A30", Offset = "0x3BD0E30", VA = "0x183BD1A30")]
	[HGAKIEJIDNO]
	public static IDisposable BMOMJPAAMCO<T>(this T BLJNEKMFAAG, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2450", Offset = "0x3BD1850", VA = "0x183BD2450")]
	[HGAKIEJIDNO]
	public static IDisposable PCKKFECIKBA<T>(this T BLJNEKMFAAG, Action ONOFIEDKHLI, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2350", Offset = "0x3BD1750", VA = "0x183BD2350")]
	[HGAKIEJIDNO]
	public static IDisposable LOJMBDEDAFE<T>(this T BLJNEKMFAAG, Action ONOFIEDKHLI, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2350", Offset = "0x3BD1750", VA = "0x183BD2350")]
	[HGAKIEJIDNO]
	public static IDisposable LOJMBDEDAFE<T>(this T BLJNEKMFAAG, Action<float> ONOFIEDKHLI, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2020", Offset = "0x3BD1420", VA = "0x183BD2020")]
	[HGAKIEJIDNO]
	public static IDisposable ILCFJOBMLAN<T>(this T BLJNEKMFAAG, Action ONOFIEDKHLI, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2210", Offset = "0x3BD1610", VA = "0x183BD2210")]
	[HGAKIEJIDNO]
	public static IDisposable LJLICCEPMNP<T>(this T BLJNEKMFAAG, Action ONOFIEDKHLI, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3BD22C0", Offset = "0x3BD16C0", VA = "0x183BD22C0")]
	[HGAKIEJIDNO]
	public static IDisposable LLCDGPDPHMF<T>(this T BLJNEKMFAAG, Action ONOFIEDKHLI, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2310", Offset = "0x3BD1710", VA = "0x183BD2310")]
	[HGAKIEJIDNO]
	public static IDisposable LMPJJOOEPFF<T>(this T BLJNEKMFAAG, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x802BC60", Offset = "0x802B060", VA = "0x18802BC60")]
	[HGAKIEJIDNO]
	public static IDisposable LMPJJOOEPFF(this MonoBehaviour BLJNEKMFAAG, PCDEJAOCFEP MEBLJIBNLCL, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2070", Offset = "0x3BD1470", VA = "0x183BD2070")]
	[HGAKIEJIDNO]
	public static IDisposable KPKFKGNFFGO<T>(this T BLJNEKMFAAG, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3BD23A0", Offset = "0x3BD17A0", VA = "0x183BD23A0")]
	[HGAKIEJIDNO]
	public static IDisposable MFNMFDIODJM<T>(this T BLJNEKMFAAG, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2260", Offset = "0x3BD1660", VA = "0x183BD2260")]
	[HGAKIEJIDNO]
	public static IDisposable LKHOBCMGDGL<T>(this T BLJNEKMFAAG, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1F00", Offset = "0x3BD1300", VA = "0x183BD1F00")]
	[HGAKIEJIDNO]
	public static IDisposable GNBHAFDFPDN<T>(this T BLJNEKMFAAG, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1E50", Offset = "0x3BD1250", VA = "0x183BD1E50")]
	[HGAKIEJIDNO]
	public static IDisposable FLDJJHDBOJC<T>(this T BLJNEKMFAAG, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1D90", Offset = "0x3BD1190", VA = "0x183BD1D90")]
	[HGAKIEJIDNO]
	public static IDisposable EGOAMBIGCHG<T>(this T BLJNEKMFAAG, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3BD19D0", Offset = "0x3BD0DD0", VA = "0x183BD19D0")]
	[HGAKIEJIDNO]
	public static IDisposable AAEEGNCKPID<T>(this T BLJNEKMFAAG, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1DF0", Offset = "0x3BD11F0", VA = "0x183BD1DF0")]
	[HGAKIEJIDNO]
	public static IDisposable FFBBIHEHNKP<T>(this T BLJNEKMFAAG, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1F60", Offset = "0x3BD1360", VA = "0x183BD1F60")]
	[HGAKIEJIDNO]
	public static IDisposable HIJLNHIJPKK<T>(this T BLJNEKMFAAG, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1EB0", Offset = "0x3BD12B0", VA = "0x183BD1EB0")]
	[HGAKIEJIDNO]
	public static IDisposable GLCLEDIMCHJ<T>(this T BLJNEKMFAAG, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1FC0", Offset = "0x3BD13C0", VA = "0x183BD1FC0")]
	[HGAKIEJIDNO]
	public static IDisposable IDEJMCBDIJB<T>(this T BLJNEKMFAAG, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3BD23F0", Offset = "0x3BD17F0", VA = "0x183BD23F0")]
	[HGAKIEJIDNO]
	public static IDisposable PCABCKEBGKC<T>(this T BLJNEKMFAAG, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true) where T : MonoBehaviour, PCDEJAOCFEP
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FAPDGHHGOGD
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class PEKFNGNFACO : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public JEDLKJBGEAA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private BDHLNNMPNAK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public PEKFNGNFACO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8045720", Offset = "0x8044B20", VA = "0x188045720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8045800", Offset = "0x8044C00", VA = "0x188045800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class GLFLAMFMAFP : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public JEDLKJBGEAA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private BDHLNNMPNAK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public GLFLAMFMAFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8034EE0", Offset = "0x80342E0", VA = "0x188034EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8034FD0", Offset = "0x80343D0", VA = "0x188034FD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8033FC0", Offset = "0x80333C0", VA = "0x188033FC0")]
	public static DCOKPPOHOJG BMOMJPAAMCO(Action ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8033F30", Offset = "0x8033330", VA = "0x188033F30")]
	public static DCOKPPOHOJG BMOMJPAAMCO(Behaviour MEBLJIBNLCL, Action ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8034040", Offset = "0x8033440", VA = "0x188034040")]
	public static DCOKPPOHOJG BMOMJPAAMCO(Behaviour MEBLJIBNLCL, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x80341B0", Offset = "0x80335B0", VA = "0x1880341B0")]
	[IteratorStateMachine(typeof(PEKFNGNFACO))]
	private static IEnumerator<MOLDBMJPKNN> PHJLFDEJJKE(JEDLKJBGEAA MFIIEKHBDEG, Action ONOFIEDKHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8034120", Offset = "0x8033520", VA = "0x188034120")]
	[IteratorStateMachine(typeof(GLFLAMFMAFP))]
	private static IEnumerator<MOLDBMJPKNN> PHJLFDEJJKE(JEDLKJBGEAA MFIIEKHBDEG, Action<float> ONOFIEDKHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class KBHCKAANAMG : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class IKJPAHAGGJB : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public KBHCKAANAMG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public IKJPAHAGGJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x803A010", Offset = "0x8039410", VA = "0x18803A010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x803A0A0", Offset = "0x80394A0", VA = "0x18803A0A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly JEDLKJBGEAA LPAKMFJLCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action ELGDNEFGKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool HGKBFIKJKMC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool JJCLLNLCAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x96A750", Offset = "0x969B50", VA = "0x18096A750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x803AF40", Offset = "0x803A340", VA = "0x18803AF40")]
	public KBHCKAANAMG(JEDLKJBGEAA LPAKMFJLCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x803AE20", Offset = "0x803A220", VA = "0x18803AE20")]
	[IteratorStateMachine(typeof(IKJPAHAGGJB))]
	private IEnumerator<MOLDBMJPKNN> NDCMLCAAKBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x803AEA0", Offset = "0x803A2A0", VA = "0x18803AEA0", Slot = "4")]
	public void OnCompleted(Action BOAELGLJEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	public void PEJAMAAHHOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class JFNGGKPGEAP
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x803A820", Offset = "0x8039C20", VA = "0x18803A820")]
	public static KBHCKAANAMG ADJMMNLCDBA(this JEDLKJBGEAA LPAKMFJLCDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class HHFCDAJLNPH
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class HAHELPNMPCI : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public NONLFKFMFGC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public HAHELPNMPCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8035710", Offset = "0x8034B10", VA = "0x188035710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8035790", Offset = "0x8034B90", VA = "0x188035790", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8038D00", Offset = "0x8038100", VA = "0x188038D00")]
	public static DCOKPPOHOJG BMOMJPAAMCO(float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, bool LCHDJOCLCAF = true, [Optional] GEPPHJCPMGA OGLJHBGIMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8038DD0", Offset = "0x80381D0", VA = "0x188038DD0")]
	public static DCOKPPOHOJG BMOMJPAAMCO(MonoBehaviour BLJNEKMFAAG, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, bool LCHDJOCLCAF = true, [Optional] GEPPHJCPMGA OGLJHBGIMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8039060", Offset = "0x8038460", VA = "0x188039060")]
	public static DCOKPPOHOJG IJAHMFFDPCK(MonoBehaviour BLJNEKMFAAG, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, bool LCHDJOCLCAF = true, [Optional] GEPPHJCPMGA OGLJHBGIMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8038F00", Offset = "0x8038300", VA = "0x188038F00")]
	public static DCOKPPOHOJG DBMEANCHEKM(MDLJCBDCMCN MEBLJIBNLCL, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, bool LCHDJOCLCAF = true, [Optional] GEPPHJCPMGA OGLJHBGIMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8039150", Offset = "0x8038550", VA = "0x188039150")]
	private static IEnumerator<MOLDBMJPKNN> PHJLFDEJJKE(INDCLFFBDOG GNKAAOBIGCN, float PCMIMDIOGCI, JEDLKJBGEAA MFIIEKHBDEG, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8038EA0", Offset = "0x80382A0", VA = "0x188038EA0")]
	private static IEnumerator<MOLDBMJPKNN> CEADCABLOMN(INDCLFFBDOG GNKAAOBIGCN, float PCMIMDIOGCI, JEDLKJBGEAA MFIIEKHBDEG, Action<float> ONOFIEDKHLI, bool LCHDJOCLCAF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8038FD0", Offset = "0x80383D0", VA = "0x188038FD0")]
	[IteratorStateMachine(typeof(HAHELPNMPCI))]
	private static IEnumerator<MOLDBMJPKNN> HIACMBCHOBK(NONLFKFMFGC MECKLPPHIOA, float PCMIMDIOGCI, JEDLKJBGEAA MFIIEKHBDEG, Action<float> ONOFIEDKHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class DCHLCPONOEN
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class KOIJNDIDJIB : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public JEDLKJBGEAA queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public KOIJNDIDJIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x803D300", Offset = "0x803C700", VA = "0x18803D300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x803D3C0", Offset = "0x803C7C0", VA = "0x18803D3C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x80324B0", Offset = "0x80318B0", VA = "0x1880324B0")]
	[IteratorStateMachine(typeof(KOIJNDIDJIB))]
	private static IEnumerator<MOLDBMJPKNN> FBOFEMGNGFC(JEDLKJBGEAA LPAKMFJLCDO, Func<bool> FMLBJPAMJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8032540", Offset = "0x8031940", VA = "0x188032540")]
	public static DCOKPPOHOJG NEAMKDMKNBL(this MonoBehaviour BLJNEKMFAAG, Func<bool> FMLBJPAMJAA, JEDLKJBGEAA LPAKMFJLCDO = JEDLKJBGEAA.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class OAGKNHKBONH
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class FAMMIEJOCBI : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public JEDLKJBGEAA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public FAMMIEJOCBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8033E70", Offset = "0x8033270", VA = "0x188033E70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8033EE0", Offset = "0x80332E0", VA = "0x188033EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class PCPOBCCAOKE<T> : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public JEDLKJBGEAA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public PCPOBCCAOKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x508DF40", Offset = "0x508D340", VA = "0x18508DF40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x508DFE0", Offset = "0x508D3E0", VA = "0x18508DFE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class JDBEPNBPPCJ : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public JEDLKJBGEAA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private MOLDBMJPKNN <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public JDBEPNBPPCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x803A740", Offset = "0x8039B40", VA = "0x18803A740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x803A7D0", Offset = "0x8039BD0", VA = "0x18803A7D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8041470", Offset = "0x8040870", VA = "0x188041470")]
	[IteratorStateMachine(typeof(FAMMIEJOCBI))]
	private static IEnumerator<MOLDBMJPKNN> NDCMLCAAKBE(float JJPFHPNOEHC, JEDLKJBGEAA MFIIEKHBDEG, Action JPHIIBFAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x364DF20", Offset = "0x364D320", VA = "0x18364DF20")]
	[IteratorStateMachine(typeof(PCPOBCCAOKE<>))]
	private static IEnumerator<MOLDBMJPKNN> NDCMLCAAKBE<T>(float JJPFHPNOEHC, JEDLKJBGEAA MFIIEKHBDEG, Action<T> JPHIIBFAEAA, T EEHMKJMNANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8040EE0", Offset = "0x80402E0", VA = "0x188040EE0")]
	[IteratorStateMachine(typeof(JDBEPNBPPCJ))]
	private static IEnumerator<MOLDBMJPKNN> CKJIDKOMEHE(float JJPFHPNOEHC, JEDLKJBGEAA MFIIEKHBDEG, Action JPHIIBFAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x80411B0", Offset = "0x80405B0", VA = "0x1880411B0")]
	public static IDisposable LBBGKBIIHHK(this MonoBehaviour BLJNEKMFAAG, float JJPFHPNOEHC, Action JPHIIBFAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8040DB0", Offset = "0x80401B0", VA = "0x188040DB0")]
	public static DCOKPPOHOJG BOLMOEHJAJI(this MonoBehaviour BLJNEKMFAAG, float JJPFHPNOEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x80410C0", Offset = "0x80404C0", VA = "0x1880410C0")]
	public static DCOKPPOHOJG LBBGKBIIHHK(this MonoBehaviour BLJNEKMFAAG, float JJPFHPNOEHC, JEDLKJBGEAA MFIIEKHBDEG, Action JPHIIBFAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8041020", Offset = "0x8040420", VA = "0x188041020")]
	public static DCOKPPOHOJG JCCEEINMOAA(this MonoBehaviour BLJNEKMFAAG, Action JPHIIBFAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x364DD90", Offset = "0x364D190", VA = "0x18364DD90")]
	public static DCOKPPOHOJG JCCEEINMOAA<T>(this MonoBehaviour BLJNEKMFAAG, Action<T> JPHIIBFAEAA, T EEHMKJMNANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8041330", Offset = "0x8040730", VA = "0x188041330")]
	public static DCOKPPOHOJG LICAOONLBEL(this MonoBehaviour BLJNEKMFAAG, Action JPHIIBFAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8041510", Offset = "0x8040910", VA = "0x188041510")]
	public static DCOKPPOHOJG OCKGMEBOGNH(this MonoBehaviour BLJNEKMFAAG, Action JPHIIBFAEAA, [Optional] GEPPHJCPMGA OGLJHBGIMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x80415B0", Offset = "0x80409B0", VA = "0x1880415B0")]
	public static DCOKPPOHOJG OHNKHAJILOF(this MonoBehaviour BLJNEKMFAAG, Action JPHIIBFAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8040E40", Offset = "0x8040240", VA = "0x188040E40")]
	public static DCOKPPOHOJG CEHDCJPOEKF(this MonoBehaviour BLJNEKMFAAG, Action JPHIIBFAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8041290", Offset = "0x8040690", VA = "0x188041290")]
	public static DCOKPPOHOJG LHEMPFNHBFG(MonoBehaviour BLJNEKMFAAG, JEDLKJBGEAA LPAKMFJLCDO, Action JPHIIBFAEAA, [Optional] GEPPHJCPMGA OGLJHBGIMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x364DDE0", Offset = "0x364D1E0", VA = "0x18364DDE0")]
	public static DCOKPPOHOJG LHEMPFNHBFG<T>(MonoBehaviour BLJNEKMFAAG, JEDLKJBGEAA LPAKMFJLCDO, Action<T> JPHIIBFAEAA, T EEHMKJMNANF, [Optional] GEPPHJCPMGA OGLJHBGIMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8040D20", Offset = "0x8040120", VA = "0x188040D20")]
	public static DCOKPPOHOJG AIMHAOFIEGC(this MonoBehaviour BLJNEKMFAAG, float MDLMPNNGAOD, Action JPHIIBFAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x80413D0", Offset = "0x80407D0", VA = "0x1880413D0")]
	public static DCOKPPOHOJG MCDGFPHHNNN(this MonoBehaviour BLJNEKMFAAG, float MDLMPNNGAOD, Action JPHIIBFAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8040F80", Offset = "0x8040380", VA = "0x188040F80")]
	public static DCOKPPOHOJG IDHGDNKIBLI(this MonoBehaviour BLJNEKMFAAG, float MDLMPNNGAOD, Action JPHIIBFAEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8041650", Offset = "0x8040A50", VA = "0x188041650")]
	public static DCOKPPOHOJG PLJOHKMBICK(this MonoBehaviour BLJNEKMFAAG, float MDLMPNNGAOD, Action JPHIIBFAEAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class FBNJIKLLJCO : JKIKAGKJNDP, IEnumerable<JKIKAGKJNDP>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<JKIKAGKJNDP> EHMHBFPBLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool PFBOBFEHDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action LIJIBOEJDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool HHHIAOICDHK;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DIBMDCNHDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8034990", Offset = "0x8033D90", VA = "0x188034990", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KGNAAGBHNPN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8034550", Offset = "0x8033950", VA = "0x188034550", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x80347A0", Offset = "0x8033BA0", VA = "0x1880347A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8034AC0", Offset = "0x8033EC0", VA = "0x188034AC0")]
	public FBNJIKLLJCO([Optional] Action LIJIBOEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8034670", Offset = "0x8033A70", VA = "0x188034670")]
	public void KAAHFJDOOLK(JKIKAGKJNDP JLGOFCBBIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8034840", Offset = "0x8033C40", VA = "0x188034840")]
	private void MELNBLPFMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8034540", Offset = "0x8033940", VA = "0x188034540", Slot = "7")]
	public bool CHKCJMLKCIJ(bool JLJMBNIAGMB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8034240", Offset = "0x8033640", VA = "0x188034240", Slot = "8")]
	public bool CHKCJMLKCIJ(Action NJNJGNMEACN, bool JLJMBNIAGMB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x80345F0", Offset = "0x80339F0", VA = "0x1880345F0", Slot = "9")]
	public IEnumerator<JKIKAGKJNDP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x80345F0", Offset = "0x80339F0", VA = "0x1880345F0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BJKFHMFMPBD : GOGLMINNFDG
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class OCLHJHHHICP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public BJKFHMFMPBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OCLHJHHHICP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x802DFF0", Offset = "0x802D3F0", VA = "0x18802DFF0")]
		internal void IMGOKDNOFKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CPCMLKGNHOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public BJKFHMFMPBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public CPCMLKGNHOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x802DFF0", Offset = "0x802D3F0", VA = "0x18802DFF0")]
		internal void OJJIKIOHFHH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float GGJFPKFBMOE;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x802C400", Offset = "0x802B800", VA = "0x18802C400")]
	public BJKFHMFMPBD(Behaviour MEBLJIBNLCL, float GGJFPKFBMOE, [Optional] Action LIJIBOEJDAJ, [Optional] GEPPHJCPMGA OGLJHBGIMHL, [Optional] INDCLFFBDOG GNKAAOBIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x802C2F0", Offset = "0x802B6F0", VA = "0x18802C2F0", Slot = "9")]
	protected override bool GNEALAMMOOL(Action NJNJGNMEACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x802C1E0", Offset = "0x802B5E0", VA = "0x18802C1E0", Slot = "10")]
	protected override bool DNHPIMOKCED(Action NJNJGNMEACN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface JKIKAGKJNDP
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DIBMDCNHDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action KGNAAGBHNPN;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CHKCJMLKCIJ(bool JLJMBNIAGMB = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CHKCJMLKCIJ(Action NJNJGNMEACN, bool JLJMBNIAGMB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class GOGLMINNFDG : JKIKAGKJNDP
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class PBPECPNBNLG : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public GOGLMINNFDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public PBPECPNBNLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8041C80", Offset = "0x8041080", VA = "0x188041C80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8041D50", Offset = "0x8041150", VA = "0x188041D50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour MEBLJIBNLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action LIJIBOEJDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NFJKMPPPDKA NINNHKAFPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly GEPPHJCPMGA OGLJHBGIMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly INDCLFFBDOG GNKAAOBIGCN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DIBMDCNHDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1872090", Offset = "0x1871490", VA = "0x181872090", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action KGNAAGBHNPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x80350E0", Offset = "0x80344E0", VA = "0x1880350E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8035520", Offset = "0x8034920", VA = "0x188035520", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x80355E0", Offset = "0x80349E0", VA = "0x1880355E0")]
	protected GOGLMINNFDG(Behaviour MEBLJIBNLCL, [Optional] Action LIJIBOEJDAJ, [Optional] GEPPHJCPMGA OGLJHBGIMHL, [Optional] INDCLFFBDOG GNKAAOBIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8035080", Offset = "0x8034480", VA = "0x188035080", Slot = "7")]
	public bool CHKCJMLKCIJ(bool JLJMBNIAGMB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8035020", Offset = "0x8034420", VA = "0x188035020", Slot = "8")]
	public bool CHKCJMLKCIJ(Action NJNJGNMEACN, bool JLJMBNIAGMB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GNEALAMMOOL(Action NJNJGNMEACN);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool DNHPIMOKCED(Action NJNJGNMEACN);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x80355C0", Offset = "0x80349C0", VA = "0x1880355C0")]
	protected void NLPNJCFILPG(Action NJNJGNMEACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8035210", Offset = "0x8034610", VA = "0x188035210")]
	protected OCLDKMPDLBK HFFLDEIDGBG(float NGAJLIGHCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x80354A0", Offset = "0x80348A0", VA = "0x1880354A0")]
	private void JICBHHEENGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8035180", Offset = "0x8034580", VA = "0x188035180")]
	[IteratorStateMachine(typeof(PBPECPNBNLG))]
	private IEnumerator<MOLDBMJPKNN> FANOBNPMDCA(float NGAJLIGHCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8035460", Offset = "0x8034860", VA = "0x188035460")]
	[CompilerGenerated]
	private void JHMOIMLKFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class KILHAOGNMFO : GOGLMINNFDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float EFEDJFGNNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int FMJDEJIKKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float JKGIIMDIHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] KKJDMIMLMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int HLBJIBEMNJL;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x803C710", Offset = "0x803BB10", VA = "0x18803C710")]
	public KILHAOGNMFO(Behaviour MEBLJIBNLCL, float FGLOCIANKII, int FMJDEJIKKDJ, [Optional] Action LIJIBOEJDAJ, float JKGIIMDIHNF = 0f, [Optional] GEPPHJCPMGA OGLJHBGIMHL, [Optional] INDCLFFBDOG GNKAAOBIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "9")]
	protected override bool GNEALAMMOOL(Action NJNJGNMEACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x803C490", Offset = "0x803B890", VA = "0x18803C490", Slot = "10")]
	protected override bool DNHPIMOKCED(Action NJNJGNMEACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x803C690", Offset = "0x803BA90", VA = "0x18803C690")]
	private void FKALJLOKPKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GHBGBOFLAFE : GOGLMINNFDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float GGJFPKFBMOE;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x802C400", Offset = "0x802B800", VA = "0x18802C400")]
	public GHBGBOFLAFE(Behaviour MEBLJIBNLCL, float GGJFPKFBMOE, [Optional] Action LIJIBOEJDAJ, [Optional] GEPPHJCPMGA OGLJHBGIMHL, [Optional] INDCLFFBDOG GNKAAOBIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "9")]
	protected override bool GNEALAMMOOL(Action NJNJGNMEACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8034EA0", Offset = "0x80342A0", VA = "0x188034EA0", Slot = "10")]
	protected override bool DNHPIMOKCED(Action NJNJGNMEACN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class BOAEIEDCFHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class HCPJGCFOEJJ : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public HCPJGCFOEJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x80357E0", Offset = "0x8034BE0", VA = "0x1880357E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8035850", Offset = "0x8034C50", VA = "0x188035850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private DCOKPPOHOJG AJKBIFJBEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private MDLJCBDCMCN MEBLJIBNLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> BDFOCIABDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private JEDLKJBGEAA LPAKMFJLCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float NEOPHAJBKJJ;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x802CA40", Offset = "0x802BE40", VA = "0x18802CA40")]
	public BOAEIEDCFHP(MDLJCBDCMCN MEBLJIBNLCL, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x802C750", Offset = "0x802BB50", VA = "0x18802C750")]
	private void IJPNDNAEBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x802C540", Offset = "0x802B940", VA = "0x18802C540")]
	private void AMEABELEDMB(string JPAKKPAOGDF, Action BMCCPDBJCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x802C670", Offset = "0x802BA70", VA = "0x18802C670")]
	[IteratorStateMachine(typeof(HCPJGCFOEJJ))]
	private IEnumerator<MOLDBMJPKNN> COODFPKEDJL(Action BMCCPDBJCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x802C6F0", Offset = "0x802BAF0", VA = "0x18802C6F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x802C8C0", Offset = "0x802BCC0", VA = "0x18802C8C0")]
	[CompilerGenerated]
	private void JKFOIHGGPJP(string HOGBKOGNANI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class HFGIABHPMDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class MOKKLOLELIJ : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public MOKKLOLELIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x80357E0", Offset = "0x8034BE0", VA = "0x1880357E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x803EC50", Offset = "0x803E050", VA = "0x18803EC50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private DCOKPPOHOJG AJKBIFJBEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour BLJNEKMFAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action ONOFIEDKHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> BDFOCIABDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private JEDLKJBGEAA LPAKMFJLCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float NEOPHAJBKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool LCHDJOCLCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly GEPPHJCPMGA OGLJHBGIMHL;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x80387C0", Offset = "0x8037BC0", VA = "0x1880387C0")]
	public HFGIABHPMDL(MonoBehaviour BLJNEKMFAAG, Action ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, [Optional] GEPPHJCPMGA OGLJHBGIMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8038950", Offset = "0x8037D50", VA = "0x188038950")]
	public HFGIABHPMDL(MonoBehaviour BLJNEKMFAAG, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, [Optional] GEPPHJCPMGA OGLJHBGIMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8038B20", Offset = "0x8037F20", VA = "0x188038B20")]
	public HFGIABHPMDL(MonoBehaviour BLJNEKMFAAG, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, bool LCHDJOCLCAF = true, [Optional] GEPPHJCPMGA OGLJHBGIMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4781860", Offset = "0x4780C60", VA = "0x184781860")]
	private HFGIABHPMDL(GEPPHJCPMGA OGLJHBGIMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8037CC0", Offset = "0x80370C0", VA = "0x188037CC0")]
	internal static HFGIABHPMDL BJKPIINECKO(MonoBehaviour BLJNEKMFAAG, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, JEDLKJBGEAA LPAKMFJLCDO, bool LCHDJOCLCAF = true, [Optional] GEPPHJCPMGA OGLJHBGIMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8037EF0", Offset = "0x80372F0", VA = "0x188037EF0")]
	private void BMOMJPAAMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8038190", Offset = "0x8037590", VA = "0x188038190")]
	private void GKFBKOMAMHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x80383A0", Offset = "0x80377A0", VA = "0x1880383A0")]
	private void IJPNDNAEBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x80385A0", Offset = "0x80379A0", VA = "0x1880385A0")]
	private void MHNOCNAMACI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8037B90", Offset = "0x8036F90", VA = "0x188037B90")]
	private void AMEABELEDMB(string JPAKKPAOGDF, Action BMCCPDBJCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8038020", Offset = "0x8037420", VA = "0x188038020")]
	[IteratorStateMachine(typeof(MOKKLOLELIJ))]
	private IEnumerator<MOLDBMJPKNN> COODFPKEDJL(Action BMCCPDBJCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8038130", Offset = "0x8037530", VA = "0x188038130", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8038730", Offset = "0x8037B30", VA = "0x188038730")]
	[CompilerGenerated]
	private void OGONECKACBA(string HOGBKOGNANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8038310", Offset = "0x8037710", VA = "0x188038310")]
	[CompilerGenerated]
	private void IIPCBEIFGLJ(string HOGBKOGNANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8038510", Offset = "0x8037910", VA = "0x188038510")]
	[CompilerGenerated]
	private void KDPJKDKMEFK(string HOGBKOGNANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x80380A0", Offset = "0x80374A0", VA = "0x1880380A0")]
	[CompilerGenerated]
	private void DMPLEABKKDB(string HOGBKOGNANI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum ECOJDKFDLMP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal sealed class DHAIDCMOILB : INDCLFFBDOG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float BPMMCGJICOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8032B30", Offset = "0x8031F30", VA = "0x188032B30", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float BGJKBJAMCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8032B40", Offset = "0x8031F40", VA = "0x188032B40", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double FGBCJNNKDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8032B50", Offset = "0x8031F50", VA = "0x188032B50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8032AC0", Offset = "0x8031EC0", VA = "0x188032AC0")]
	[AEDFFNEEAKJ.AMNMLEGDOCC]
	internal static void GFLBPMFPPHA(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	[UnityEngine.Scripting.Preserve]
	internal DHAIDCMOILB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface CMCMIEEBEFF
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHPKFAHFNLG(string OGOCCCFKJPG);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKADHGGHGIG();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface DJBOMAECMFO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool IAOPLPEJDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool EOHEKOPBPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class LBPCICDEPEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public PEFIFMMKOCM GDIICAMBMMC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int NGGCGOFGPAK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x968380", Offset = "0x967780", VA = "0x180968380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x803D410", Offset = "0x803C810", VA = "0x18803D410")]
	public static MOLDBMJPKNN BIKBFHAJKAJ(IEnumerator<MOLDBMJPKNN> NCBIABCOGPI, LNEDBNNCLOJ OLLJCEKAIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x803D570", Offset = "0x803C970", VA = "0x18803D570")]
	public MOLDBMJPKNN BIKBFHAJKAJ(LNEDBNNCLOJ[] KPGPGLNBAPB, IEnumerator<MOLDBMJPKNN>[] HCFIHBKOANP, MOLDBMJPKNN[] DJHJFBOBMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x803D630", Offset = "0x803CA30", VA = "0x18803D630")]
	public void BOPHAJLLEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x803D660", Offset = "0x803CA60", VA = "0x18803D660")]
	public void CAJGNENJECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x803D7A0", Offset = "0x803CBA0", VA = "0x18803D7A0")]
	public void CJCCFPFCCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x803D630", Offset = "0x803CA30", VA = "0x18803D630")]
	public void FGPIGKDDHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public LBPCICDEPEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class PEFIFMMKOCM
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct BBPHABIGDGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public LBPCICDEPEB AONKIBMIKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public MDLJCBDCMCN LMHKBJEFPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public LNEDBNNCLOJ KKJIGAHEJLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<MOLDBMJPKNN> OGBBCMLFEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public MOLDBMJPKNN PLKEDNCHGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public ECOJDKFDLMP BNKEGGCIOFK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct BHJADJHJFBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public JEDLKJBGEAA JIFACPALDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<BBPHABIGDGC> PACLJDNHANL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class NGHENBOBNFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public LNEDBNNCLOJ promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public PEFIFMMKOCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public MDLJCBDCMCN context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public LBPCICDEPEB routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public ECOJDKFDLMP coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public MOLDBMJPKNN currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<MOLDBMJPKNN> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public NGHENBOBNFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x803F0C0", Offset = "0x803E4C0", VA = "0x18803F0C0")]
		internal void PIAIEKGEPAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class EEBDMCHPJEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public LBPCICDEPEB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public PEFIFMMKOCM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public EEBDMCHPJEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8033480", Offset = "0x8032880", VA = "0x188033480")]
		internal void HLCPLLFAIBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class OBHMGHDIKPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public LBPCICDEPEB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public PEFIFMMKOCM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OBHMGHDIKPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x80416F0", Offset = "0x8040AF0", VA = "0x1880416F0")]
		internal void KBINBDOKNOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class KLIICIGGJIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public LBPCICDEPEB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public PEFIFMMKOCM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KLIICIGGJIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x803D010", Offset = "0x803C410", VA = "0x18803D010")]
		internal void PNEMBPFGHKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const ECOJDKFDLMP NPOIELJBMCP = ECOJDKFDLMP.Cancelled | ECOJDKFDLMP.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly JEDLKJBGEAA LPAKMFJLCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] BMCHCJNIDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<ECOJDKFDLMP> NNCDIEKHEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> HGJJJBNCJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> KGKJEIJJEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> NANLOJDMGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> PGHKHIJGFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> DMJDIDEONIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> MEMFJMECBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private LBPCICDEPEB[] NFMFIJEOHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private LNEDBNNCLOJ[] KPGPGLNBAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private MDLJCBDCMCN[] PONGNAMBFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<MOLDBMJPKNN>[] DKPJOEENNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private MOLDBMJPKNN[] HPAEEEELKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int KOAOIKIBLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int JJLMBBEIKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int HFNDDLFCAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float LCBBCNHKKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private HOMDEEOAGAO MOBBIFLCBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle KBNHLLBDIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<LBPCICDEPEB> JNIDGJGPHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool CIOOCGAPBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> LJBNJJJEOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> JFHDNFGHFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool LNCJLLPLCHP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public BHJADJHJFBB[] AECHICNODEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9E3AA0", Offset = "0x9E2EA0", VA = "0x1809E3AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x80444C0", Offset = "0x80438C0", VA = "0x1880444C0")]
	private static int KDKOJMAFNMN(JEDLKJBGEAA LPAKMFJLCDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8044E50", Offset = "0x8044250", VA = "0x188044E50")]
	public PEFIFMMKOCM(JEDLKJBGEAA LPAKMFJLCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8044160", Offset = "0x8043560", VA = "0x188044160")]
	private void HCHNKECDOGK(int PPFLKLILFMC, int LANNFHODPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8044340", Offset = "0x8043740", VA = "0x188044340")]
	public void KCPAECDCGMO(MDLJCBDCMCN MEBLJIBNLCL, MOLDBMJPKNN KBKGEJDBHGF, IEnumerator<MOLDBMJPKNN> NCBIABCOGPI, LNEDBNNCLOJ OLLJCEKAIOF, [Optional] LBPCICDEPEB BKKGPFMLAMC, ECOJDKFDLMP FCEHKDPKIHO = ECOJDKFDLMP.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8043F20", Offset = "0x8043320", VA = "0x188043F20")]
	public void GFLDGANELBD(IEnumerable<BBPHABIGDGC> GGKHHDEAMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x80444F0", Offset = "0x80438F0", VA = "0x1880444F0")]
	private BBPHABIGDGC LPMAIPFKFCK(int KIOEMLGCPOE)
	{
		return default(BBPHABIGDGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8043BB0", Offset = "0x8042FB0", VA = "0x188043BB0")]
	private void GEKDMMMMOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x366E020", Offset = "0x366D420", VA = "0x18366E020")]
	private static void HPGGLMAHJJM<T>(int KIOEMLGCPOE, T[] HACIENCHBNM, int NBPEDBIONNC, [Optional] T LIFBADBDBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x366E070", Offset = "0x366D470", VA = "0x18366E070")]
	private static void HPGGLMAHJJM<T>(int KIOEMLGCPOE, NativeArray<T> HACIENCHBNM, int NBPEDBIONNC, [Optional] T LIFBADBDBCN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x80436E0", Offset = "0x8042AE0", VA = "0x1880436E0")]
	private void FGAMAGOFFNH(IEnumerable<BBPHABIGDGC> GGKHHDEAMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8042BC0", Offset = "0x8041FC0", VA = "0x188042BC0")]
	private void BBDIEOLLMPJ(BBPHABIGDGC AAELEMJDKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8044BF0", Offset = "0x8043FF0", VA = "0x188044BF0")]
	private KLAAONOHLME OLDOLKBOGIJ(int LNLLEMLHGJL)
	{
		return default(KLAAONOHLME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x80433B0", Offset = "0x80427B0", VA = "0x1880433B0")]
	public void DIPABJEGNLF(float EOIMAGDAGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8044AF0", Offset = "0x8043EF0", VA = "0x188044AF0")]
	private void MPCNKHOLPIA(Action FJLJDCJDABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8044B70", Offset = "0x8043F70", VA = "0x188044B70")]
	private void NDFIEICAOFF(Action FJLJDCJDABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8042C90", Offset = "0x8042090", VA = "0x188042C90")]
	public void CMGEPKJKHDC(float EOIMAGDAGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8042AC0", Offset = "0x8041EC0", VA = "0x188042AC0")]
	public void AICKIPOBPIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8043A80", Offset = "0x8042E80", VA = "0x188043A80")]
	public void FGPIGKDDHPD(LBPCICDEPEB MECKLPPHIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x80449C0", Offset = "0x8043DC0", VA = "0x1880449C0")]
	public void MAGPCGGIEDK(LBPCICDEPEB MECKLPPHIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x80435B0", Offset = "0x80429B0", VA = "0x1880435B0")]
	public void EICLEDLKAKJ(LBPCICDEPEB MECKLPPHIOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FEMCCFGEHNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly FEMCCFGEHNN MAEOIBKNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action FKBCDFMCNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool JBOKBJOADDP;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public FEMCCFGEHNN(Action FKBCDFMCNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7701850", Offset = "0x7700C50", VA = "0x187701850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface JLGPGIDDGPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable AELKMMBEBLN(UnityEngine.Object MEBLJIBNLCL, Action<T> DDNKODICIEN);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface ALBOLFCFAPC<T> : JLGPGIDDGPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class NOADOFMOFMH<T> : ALBOLFCFAPC<T>, JLGPGIDDGPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class GHLMPGFMOEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public NOADOFMOFMH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public HEBLJOLGLMI<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GHLMPGFMOEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x466CE10", Offset = "0x466C210", VA = "0x18466CE10")]
		internal void LAAFELDLJAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject JLCGFAMKJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<HEBLJOLGLMI<UnityEngine.Object, Action<T>>> GLKPIFOKCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T NGHMONBEEEN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xC02DE0", Offset = "0xC021E0", VA = "0x180C02DE0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4E97D80", Offset = "0x4E97180", VA = "0x184E97D80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4E98560", Offset = "0x4E97960", VA = "0x184E98560")]
	private static bool NGGIHHOKPGP(T FJLJDCJDABK, T DOGHGFGEHNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4E98620", Offset = "0x4E97A20", VA = "0x184E98620")]
	public NOADOFMOFMH(T LBMHFFAFJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4E97A20", Offset = "0x4E96E20", VA = "0x184E97A20", Slot = "6")]
	public IDisposable AELKMMBEBLN(UnityEngine.Object MEBLJIBNLCL, Action<T> DDNKODICIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4E97ED0", Offset = "0x4E972D0", VA = "0x184E97ED0")]
	private void KKCDDEKIFAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class PKGLPEJAPKI : NHOGLAIMMNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class DGPMAODKKCB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class KEADECMCENA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int NNKBGKICBEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private DGPMAODKKCB MFIIEKHBDEG;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xD95200", Offset = "0xD94600", VA = "0x180D95200")]
			public KEADECMCENA(int NNKBGKICBEC, DGPMAODKKCB MFIIEKHBDEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x803C460", Offset = "0x803B860", VA = "0x18803C460", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class IILHIBOMJCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public IILHIBOMJCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xCBB6E0", Offset = "0xCBAAE0", VA = "0x180CBB6E0")]
			internal bool HNCCOBEFLCD(ENGMGMGLPDA e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class JCDLKAGGABH : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private MOLDBMJPKNN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public DGPMAODKKCB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public INDCLFFBDOG timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private BDHLNNMPNAK <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<ENGMGMGLPDA> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
			[DebuggerHidden]
			public JCDLKAGGABH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x803A3C0", Offset = "0x80397C0", VA = "0x18803A3C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x803A6F0", Offset = "0x8039AF0", VA = "0x18803A6F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly JEDLKJBGEAA LPAKMFJLCDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private DCOKPPOHOJG OLLJCEKAIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<ENGMGMGLPDA> MPMKDLIMCKD;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8032A20", Offset = "0x8031E20", VA = "0x188032A20")]
		public DGPMAODKKCB(JEDLKJBGEAA LPAKMFJLCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8032890", Offset = "0x8031C90", VA = "0x188032890")]
		public IDisposable PNJLKGCEFOG(ENGMGMGLPDA CCOOKEFMAEJ, GEPPHJCPMGA OGLJHBGIMHL, INDCLFFBDOG LMBGFJBPMAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8032670", Offset = "0x8031A70", VA = "0x188032670")]
		private void LAEDHEOLKJN(int NNKBGKICBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8032800", Offset = "0x8031C00", VA = "0x188032800")]
		[IteratorStateMachine(typeof(JCDLKAGGABH))]
		private IEnumerator<MOLDBMJPKNN> PHJLFDEJJKE(INDCLFFBDOG LMBGFJBPMAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8032620", Offset = "0x8031A20", VA = "0x188032620", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class ENGMGMGLPDA
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum NKLDGNFOIJG : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int MELDFHOIDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int MHHGANKHAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly PCDEJAOCFEP LMHKBJEFPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour PDEBFILIOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action PCKKFECIKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> HNMPCGJKLNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float OMJAGCHJKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float HGJJJBNCJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string NAMECGEJFMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool ADLDPFNMDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly NKLDGNFOIJG MKIKKODMKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool NIDABPGKBEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool LHIEINAINDJ;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8033B10", Offset = "0x8032F10", VA = "0x188033B10")]
		public ENGMGMGLPDA(PCDEJAOCFEP MEBLJIBNLCL, Action ONOFIEDKHLI, bool AEOKCLFHJGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8033990", Offset = "0x8032D90", VA = "0x188033990")]
		public ENGMGMGLPDA(PCDEJAOCFEP MEBLJIBNLCL, Action<float> ONOFIEDKHLI, bool AEOKCLFHJGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x80337B0", Offset = "0x8032BB0", VA = "0x1880337B0")]
		public ENGMGMGLPDA(PCDEJAOCFEP MEBLJIBNLCL, float PCMIMDIOGCI, Action<float> ONOFIEDKHLI, INDCLFFBDOG LMBGFJBPMAJ, NKLDGNFOIJG NBEJGDPKJBB, bool LCHDJOCLCAF, bool AEOKCLFHJGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x80335E0", Offset = "0x80329E0", VA = "0x1880335E0")]
		public bool CBPAMOGBIOE(float LLHIMIEALOC, float HEDKILDIFAG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly GEPPHJCPMGA OGLJHBGIMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly INDCLFFBDOG GNKAAOBIGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<JEDLKJBGEAA, DGPMAODKKCB> JBAAMNLPDHG;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x80465A0", Offset = "0x80459A0", VA = "0x1880465A0")]
	[AEDFFNEEAKJ.AMNMLEGDOCC]
	internal static void HAJOLJFEPJH(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8046F30", Offset = "0x8046330", VA = "0x188046F30")]
	[UnityEngine.Scripting.Preserve]
	internal PKGLPEJAPKI([PNFCCJKFMBH(null)] GEPPHJCPMGA OGLJHBGIMHL, [PNFCCJKFMBH(null)] INDCLFFBDOG GNKAAOBIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8046B50", Offset = "0x8045F50", VA = "0x188046B50", Slot = "4")]
	public IDisposable PCKKFECIKBA(PCDEJAOCFEP MEBLJIBNLCL, Action LOGLEICCEGM, JEDLKJBGEAA LPAKMFJLCDO, bool AEOKCLFHJGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8046D40", Offset = "0x8046140", VA = "0x188046D40", Slot = "5")]
	public IDisposable PCKKFECIKBA(PCDEJAOCFEP MEBLJIBNLCL, Action<float> LOGLEICCEGM, JEDLKJBGEAA LPAKMFJLCDO, bool AEOKCLFHJGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x8046A50", Offset = "0x8045E50", VA = "0x188046A50", Slot = "7")]
	public IDisposable MFNMFDIODJM(PCDEJAOCFEP MEBLJIBNLCL, float PCMIMDIOGCI, Action<float> LOGLEICCEGM, JEDLKJBGEAA LPAKMFJLCDO, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x80467D0", Offset = "0x8045BD0", VA = "0x1880467D0", Slot = "8")]
	public IDisposable KDMALOHHLOH(PCDEJAOCFEP MEBLJIBNLCL, float PCMIMDIOGCI, Action<float> LOGLEICCEGM, JEDLKJBGEAA LPAKMFJLCDO, bool LCHDJOCLCAF = true, bool AEOKCLFHJGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x80468D0", Offset = "0x8045CD0", VA = "0x1880468D0", Slot = "6")]
	public IDisposable MFNMFDIODJM(float PCMIMDIOGCI, Action<float> LOGLEICCEGM, bool LCHDJOCLCAF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8046610", Offset = "0x8045A10", VA = "0x188046610", Slot = "9")]
	public void HKGADJFONBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8046460", Offset = "0x8045860", VA = "0x188046460")]
	private DGPMAODKKCB EPEHMPAPJLB(JEDLKJBGEAA LPAKMFJLCDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class PDJPBNCMGAC : KDIDKFLOFPL, GEPPHJCPMGA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private PEFIFMMKOCM[] IBDGDHAHIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private CMCMIEEBEFF LKAPNDDGJJB;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8042240", Offset = "0x8041640", VA = "0x188042240")]
	[AEDFFNEEAKJ.AMNMLEGDOCC]
	internal static void GFLBPMFPPHA(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x8042A00", Offset = "0x8041E00", VA = "0x188042A00")]
	[UnityEngine.Scripting.Preserve]
	public PDJPBNCMGAC([PNFCCJKFMBH(null)] HOPGMNGNJAD BNFIGPLLBFA, [PNFCCJKFMBH(null)] INDCLFFBDOG GNKAAOBIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x8041DA0", Offset = "0x80411A0", VA = "0x188041DA0", Slot = "19")]
	public override DCOKPPOHOJG AEDAPJELENK(MDLJCBDCMCN MEBLJIBNLCL, IEnumerator<MOLDBMJPKNN> LCFKCJLHPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x80424E0", Offset = "0x80418E0", VA = "0x1880424E0", Slot = "20")]
	public override void HKGADJFONBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x80422B0", Offset = "0x80416B0", VA = "0x1880422B0", Slot = "22")]
	public override void HAKKDIIFOJM(JEDLKJBGEAA LPAKMFJLCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x8042770", Offset = "0x8041B70", VA = "0x188042770", Slot = "21")]
	protected override void PCKKFECIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x8041ED0", Offset = "0x80412D0", VA = "0x188041ED0")]
	private PEFIFMMKOCM BIEAMPMGCLP(JEDLKJBGEAA ANONBNLNHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x8041FC0", Offset = "0x80413C0", VA = "0x188041FC0", Slot = "23")]
	internal override EBMHOEAINPE DKPPHIAHGHJ(IEnumerator<MOLDBMJPKNN> LCFKCJLHPMB, Behaviour MEBLJIBNLCL, LNEDBNNCLOJ OLLJCEKAIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8041F00", Offset = "0x8041300", VA = "0x188041F00", Slot = "24")]
	internal override HEOKEPODJLD BMBEJAHPLFL(JEDLKJBGEAA MFIIEKHBDEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x80428E0", Offset = "0x8041CE0", VA = "0x1880428E0")]
	private void PLCKFEFBCOH(PEFIFMMKOCM JCCJPMEMHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x80421E0", Offset = "0x80415E0", VA = "0x1880421E0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct HOMDEEOAGAO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float HJIGPOKPDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int GPHIFCCJNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> JLFGHDEPBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> GCMLPOLLGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> MNIEIMKGBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<ECOJDKFDLMP> EHOEJAJNEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> BLBJMGOENLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> PGHKHIJGFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> KGKJEIJJEKC;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x80397B0", Offset = "0x8038BB0", VA = "0x1880397B0")]
	public static HOMDEEOAGAO GEEFBNOOFMP(int IAHEKJGENCH, float EOIMAGDAGAD, NativeArray<ECOJDKFDLMP> FKHNEDHEPNH, NativeArray<float> IHEAADNNFFF, NativeArray<int> OKGAKFJNDDN, NativeArray<int> PCABHAGALFA, NativeArray<int> MNHFOKJDPLB, NativeArray<int> GCMLPOLLGNI, NativeArray<int> MNIEIMKGBLL)
	{
		return default(HOMDEEOAGAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8039600", Offset = "0x8038A00", VA = "0x188039600", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8039810", Offset = "0x8038C10", VA = "0x188039810")]
	private bool LGCNHOCKEGH(int FFCBHHABFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8039B30", Offset = "0x8038F30", VA = "0x188039B30")]
	private void PLICLNAMGGE(NativeArray<int> AHLFLADDOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8039850", Offset = "0x8038C50", VA = "0x188039850")]
	private int NCPOMMHHDPH(int HOBGDMLPOBC, int PHKFJEDIAJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x80396E0", Offset = "0x8038AE0", VA = "0x1880396E0")]
	private void GBAEIKEGOAE(NativeArray<int> AHLFLADDOCG, int CAEHDJIJJJI, int NPJNBFDHKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x80398F0", Offset = "0x8038CF0", VA = "0x1880398F0")]
	private void OGEMJHMEODD(NativeArray<int> AHLFLADDOCG, int ECOAFECIPOP, int MJOFELPKHCG, int INBLGBDPEIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class KDIDKFLOFPL : GEPPHJCPMGA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly HOPGMNGNJAD BNFIGPLLBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly INDCLFFBDOG GNKAAOBIGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private HEOKEPODJLD[] MJDABPGALAE;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static GEPPHJCPMGA AJPLFLPAHGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x803BEE0", Offset = "0x803B2E0", VA = "0x18803BEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool GJIAKANDJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public JEDLKJBGEAA ACGGJKLINAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JEDLKJBGEAA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x968380", Offset = "0x967780", VA = "0x180968380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public INDCLFFBDOG MPIAABAADOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public MOLDBMJPKNN FLHNMCIOGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public MOLDBMJPKNN NFKBODKHMPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x96E0E0", Offset = "0x96D4E0", VA = "0x18096E0E0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MOLDBMJPKNN PPFOGBOPJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x96A720", Offset = "0x969B20", VA = "0x18096A720", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MOLDBMJPKNN PDENHJIPCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9636B0", VA = "0x1809642B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x803BC20", Offset = "0x803B020", VA = "0x18803BC20")]
	public static DCOKPPOHOJG KJLJPKHBKLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x803BF70", Offset = "0x803B370", VA = "0x18803BF70")]
	[UnityEngine.Scripting.Preserve]
	protected KDIDKFLOFPL([PNFCCJKFMBH(null)] HOPGMNGNJAD BNFIGPLLBFA, [PNFCCJKFMBH(null)] INDCLFFBDOG GNKAAOBIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x803B940", Offset = "0x803AD40", VA = "0x18803B940", Slot = "6")]
	public DCOKPPOHOJG GNAFMGAEBCA(IEnumerator<MOLDBMJPKNN> LCFKCJLHPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x803B740", Offset = "0x803AB40", VA = "0x18803B740", Slot = "7")]
	public DCOKPPOHOJG GNAFMGAEBCA(Behaviour MEBLJIBNLCL, IEnumerator<MOLDBMJPKNN> LCFKCJLHPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract DCOKPPOHOJG AEDAPJELENK(MDLJCBDCMCN MEBLJIBNLCL, IEnumerator<MOLDBMJPKNN> LCFKCJLHPMB);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x803B9E0", Offset = "0x803ADE0", VA = "0x18803B9E0", Slot = "20")]
	public virtual void HKGADJFONBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x803B0C0", Offset = "0x803A4C0", VA = "0x18803B0C0", Slot = "9")]
	public void BNPBCAMHCIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x803BF50", Offset = "0x803B350", VA = "0x18803BF50", Slot = "21")]
	protected virtual void PCKKFECIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x803B0A0", Offset = "0x803A4A0", VA = "0x18803B0A0")]
	private void BMPCKDHAPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x803BCB0", Offset = "0x803B0B0", VA = "0x18803BCB0")]
	private void KPACIPEGDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x803BCD0", Offset = "0x803B0D0", VA = "0x18803BCD0")]
	private void LOJMBDEDAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x803BB80", Offset = "0x803AF80", VA = "0x18803BB80")]
	private void ILCFJOBMLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x803BCF0", Offset = "0x803B0F0", VA = "0x18803BCF0")]
	private void MEOIJAPEJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x803B6C0", Offset = "0x803AAC0", VA = "0x18803B6C0")]
	private void FBFNJAGBEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x803BC00", Offset = "0x803B000", VA = "0x18803BC00")]
	private void KHGIFIHGKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x803B950", Offset = "0x803AD50", VA = "0x18803B950", Slot = "22")]
	public virtual void HAKKDIIFOJM(JEDLKJBGEAA LPAKMFJLCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x803BD10", Offset = "0x803B110", VA = "0x18803BD10")]
	private void MONDEMENDJP(HEOKEPODJLD JCCJPMEMHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x24B9250", Offset = "0x24B8650", VA = "0x1824B9250")]
	private HEOKEPODJLD JKGNKECCILB(JEDLKJBGEAA ANONBNLNHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract EBMHOEAINPE DKPPHIAHGHJ(IEnumerator<MOLDBMJPKNN> LCFKCJLHPMB, Behaviour BLJNEKMFAAG, LNEDBNNCLOJ JCPEBAHEOOO);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract HEOKEPODJLD BMBEJAHPLFL(JEDLKJBGEAA LPAKMFJLCDO);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x803B300", Offset = "0x803A700", VA = "0x18803B300", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x803B6E0", Offset = "0x803AAE0", VA = "0x18803B6E0", Slot = "15")]
	public MOLDBMJPKNN GLEIPBINAAH(JEDLKJBGEAA MFIIEKHBDEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x803B010", Offset = "0x803A410", VA = "0x18803B010", Slot = "16")]
	public MOLDBMJPKNN AGHCDNNJBNK(float JJPFHPNOEHC, JEDLKJBGEAA MFIIEKHBDEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x803BBA0", Offset = "0x803AFA0", VA = "0x18803BBA0", Slot = "17")]
	public MOLDBMJPKNN KBEJPIFIKLC(Func<bool> FMLBJPAMJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class EBMHOEAINPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly LNEDBNNCLOJ OLLJCEKAIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly DJBOMAECMFO MEBLJIBNLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool LOFCNOKGOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string OGOCCCFKJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace HPOPCOHBACF;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<MOLDBMJPKNN> OGBBCMLFEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MOLDBMJPKNN PLKEDNCHGOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool BPHCMCLEHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8032B70", Offset = "0x8031F70", VA = "0x188032B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool FNNJOACPBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xB07F00", Offset = "0xB07300", VA = "0x180B07F00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xB54B50", Offset = "0xB53F50", VA = "0x180B54B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8032F10", Offset = "0x8032310", VA = "0x188032F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float CFDJCJCGIDL
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xEFF370", Offset = "0xEFE770", VA = "0x180EFF370")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6A61BC0", Offset = "0x6A60FC0", VA = "0x186A61BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x8033260", Offset = "0x8032660", VA = "0x188033260")]
	public EBMHOEAINPE(IEnumerator<MOLDBMJPKNN> NCBIABCOGPI, DJBOMAECMFO MEBLJIBNLCL, LNEDBNNCLOJ OLLJCEKAIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8032BF0", Offset = "0x8031FF0", VA = "0x188032BF0")]
	public MOLDBMJPKNN BIKBFHAJKAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x80330C0", Offset = "0x80324C0", VA = "0x1880330C0")]
	public bool FFDLMMINJBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8033130", Offset = "0x8032530", VA = "0x188033130")]
	public void FGPIGKDDHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x8033180", Offset = "0x8032580", VA = "0x188033180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xB9B6B0", Offset = "0xB9AAB0", VA = "0x180B9B6B0")]
	[CompilerGenerated]
	private void HEGLDKIIFFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class LNEDBNNCLOJ : BPPCKMAONFJ, DCOKPPOHOJG, NFJKMPPPDKA, OCLDKMPDLBK, IEnumerator, MOLDBMJPKNN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private JEDLKJBGEAA OJGDGEODFOO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private JEDLKJBGEAA DDPHFDDPDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xC57A80", Offset = "0xC56E80", VA = "0x180C57A80", Slot = "23")]
		get
		{
			return default(JEDLKJBGEAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public JEDLKJBGEAA GDIICAMBMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xDF8560", Offset = "0xDF7960", VA = "0x180DF8560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float EDMLFPBHJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xADB030", Offset = "0xADA430", VA = "0x180ADB030", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool HCGLPDFAEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x803E6D0", Offset = "0x803DAD0", VA = "0x18803E6D0", Slot = "24")]
	private bool CCAADPKDMOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x803E6F0", Offset = "0x803DAF0", VA = "0x18803E6F0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x803E700", Offset = "0x803DB00", VA = "0x18803E700")]
	public LNEDBNNCLOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum KLAAONOHLME : byte
{
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class HEOKEPODJLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum AOKKGHFNJDA
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct MCACNKCLLBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public JEDLKJBGEAA JIFACPALDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AOKKGHFNJDA CMMEONFCKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<EBMHOEAINPE> FPNIIEOLNCF;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly AOKKGHFNJDA[] LMKBOHGHLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly JEDLKJBGEAA LPAKMFJLCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool JCMMKNGBMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly EBMHOEAINPE[] ACNHBFBDPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<EBMHOEAINPE> EJABPIGMMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> DBIGCBOMLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<EBMHOEAINPE> PAHPDDEPINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> ABLPLINJKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly CMCMIEEBEFF EMEJPMCONGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool LNCJLLPLCHP;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MCACNKCLLBJ[,] JACDDLLFHMP
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x96A720", Offset = "0x969B20", VA = "0x18096A720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8037710", Offset = "0x8036B10", VA = "0x188037710")]
	public HEOKEPODJLD(JEDLKJBGEAA MFIIEKHBDEG, CMCMIEEBEFF EMEJPMCONGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8036DA0", Offset = "0x80361A0", VA = "0x188036DA0")]
	public void KGKNLJJNPNB(EBMHOEAINPE NCBIABCOGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x80367F0", Offset = "0x8035BF0", VA = "0x1880367F0")]
	public void FDJJOIMEOIA(IList<EBMHOEAINPE> HCFIHBKOANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x80361F0", Offset = "0x80355F0", VA = "0x1880361F0")]
	public void ANONBKCOIEM(IList<EBMHOEAINPE> HCFIHBKOANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8037200", Offset = "0x8036600", VA = "0x188037200")]
	private void MMIGGKOBOAN(EBMHOEAINPE NCBIABCOGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x80372F0", Offset = "0x80366F0", VA = "0x1880372F0")]
	private void NAPNIMGJFOL(IList<EBMHOEAINPE> HCFIHBKOANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8036AE0", Offset = "0x8035EE0", VA = "0x188036AE0")]
	private KLAAONOHLME IENIJEPNPCG(EBMHOEAINPE NCBIABCOGPI)
	{
		return default(KLAAONOHLME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8037470", Offset = "0x8036870", VA = "0x188037470")]
	public void PCKKFECIKBA(float EOIMAGDAGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x80364E0", Offset = "0x80358E0", VA = "0x1880364E0")]
	public void BNPBCAMHCIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8036EA0", Offset = "0x80362A0", VA = "0x188036EA0")]
	private void LBJPONGMGFD(List<EBMHOEAINPE> HCFIHBKOANP, Stack<int> DBJMDENJIFE, bool OIJEMMMPGAJ, float CJDEKLHHGBO = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x80366D0", Offset = "0x8035AD0", VA = "0x1880366D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8036C60", Offset = "0x8036060", VA = "0x188036C60")]
	private void INANJDMEDGE(List<EBMHOEAINPE> HCFIHBKOANP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class AGBCDGALENO : CMCMIEEBEFF
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
	public void IHPKFAHFNLG(string OGOCCCFKJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
	public void FKADHGGHGIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public AGBCDGALENO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class ILFNNKPNHBD : DJBOMAECMFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour BLJNEKMFAAG;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x803A110", Offset = "0x8039510", VA = "0x18803A110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool IAOPLPEJDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x803A190", Offset = "0x8039590", VA = "0x18803A190", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool EOHEKOPBPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x803A0F0", Offset = "0x80394F0", VA = "0x18803A0F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public ILFNNKPNHBD(Behaviour BLJNEKMFAAG)
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

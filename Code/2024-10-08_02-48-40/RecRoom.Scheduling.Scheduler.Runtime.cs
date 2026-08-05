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
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75DF340", Offset = "0x75DE540", VA = "0x1875DF340", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private delegate List<PlayerLoopSystem> AHDNJGLNDMP(List<PlayerLoopSystem> NELNDIHIGEJ, int LOFILCPGDCG);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct GKHHPHPPELD
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct DHCAFDPNNGJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static OAACCCGABIO MJOFFFMAEPL;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x75CBFD0", Offset = "0x75CB1D0", VA = "0x1875CBFD0")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct LFMIMECKCEN
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static OAACCCGABIO GGECMGGMELL;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x75D82A0", Offset = "0x75D74A0", VA = "0x1875D82A0")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct BOGGKIPLDKN
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static OAACCCGABIO DNPEBFIKJAI;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x75C4170", Offset = "0x75C3370", VA = "0x1875C4170")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct COEDHNJLNAI
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static OAACCCGABIO LHPOFHGEGOH;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static OAACCCGABIO JPHNFJDDFNO;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static OAACCCGABIO BHGDAHPCGAO;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static OAACCCGABIO COPMCFFECAB;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x75C5CE0", Offset = "0x75C4EE0", VA = "0x1875C5CE0")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct EHIJCNKAJHM
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static OAACCCGABIO IODEGLAHNHE;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x75CC1E0", Offset = "0x75CB3E0", VA = "0x1875CC1E0")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct AOCEOGLILNB
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static OAACCCGABIO LHPOFHGEGOH;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static OAACCCGABIO JPHNFJDDFNO;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static OAACCCGABIO BHGDAHPCGAO;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static OAACCCGABIO COPMCFFECAB;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x75C3580", Offset = "0x75C2780", VA = "0x1875C3580")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct KLFDOFOELFL
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static OAACCCGABIO ALBFNDHAINE;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x75D5390", Offset = "0x75D4590", VA = "0x1875D5390")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct MLKAIKLANFI
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static OAACCCGABIO BLJBCODPHNM;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x75DA130", Offset = "0x75D9330", VA = "0x1875DA130")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct GJOENPHMDDL
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static OAACCCGABIO CHPELABPOGP;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x75D0330", Offset = "0x75CF530", VA = "0x1875D0330")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct NCEIBKOAFAP
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static OAACCCGABIO LFHCJFFCMAK;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x75DA310", Offset = "0x75D9510", VA = "0x1875DA310")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct ENHLBAKGFMH
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static OAACCCGABIO LHOKDGEAAEP;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x75CCDA0", Offset = "0x75CBFA0", VA = "0x1875CCDA0")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct BJEMNHFCHPD
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static OAACCCGABIO OJJOIMEPANF;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x75C3E80", Offset = "0x75C3080", VA = "0x1875C3E80")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct DCOAIHHLIMF
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static OAACCCGABIO JIGJKFDJLIJ;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x75CB700", Offset = "0x75CA900", VA = "0x1875CB700")]
				public static PlayerLoopSystem FOPBDBBGOAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum HHNEJJBMBNA : byte
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
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct NGOPLPCDBCK
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class LFFGPOFAOPM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public HHNEJJBMBNA updateStage;

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
					public LFFGPOFAOPM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x75D8220", Offset = "0x75D7420", VA = "0x1875D8220")]
					internal void HOMMKANMMIO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static MNNONBMLAOA<HHNEJJBMBNA> KCMEDPCPPFC;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x75DB0A0", Offset = "0x75DA2A0", VA = "0x1875DB0A0")]
				public static PlayerLoopSystem FOPBDBBGOAK(HHNEJJBMBNA EKAELKBOCOC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct GAJNALIONNE
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class PHBGAGHEAJF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public MBLBHOJCBII.CGJIOADLBNJ key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
					public PHBGAGHEAJF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x75DDC10", Offset = "0x75DCE10", VA = "0x1875DDC10")]
					internal void AEFLDMNCOBN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable EPJJNNNECKC;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x75CE4B0", Offset = "0x75CD6B0", VA = "0x1875CE4B0")]
				public static PlayerLoopSystem OLLCBGCIMGM(MBLBHOJCBII.CGJIOADLBNJ CPBLLDDDHEE)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct GAIFHBMEGBF
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class KLGEGCLALND
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public MBLBHOJCBII.CGJIOADLBNJ key;

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
					public KLGEGCLALND()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x75D5570", Offset = "0x75D4770", VA = "0x1875D5570")]
					internal void AEFLDMNCOBN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x75CE380", Offset = "0x75CD580", VA = "0x1875CE380")]
				public static PlayerLoopSystem OLLCBGCIMGM(MBLBHOJCBII.CGJIOADLBNJ CPBLLDDDHEE)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class GGDGCJNGDKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public GGDGCJNGDKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x75CE5E0", Offset = "0x75CD7E0", VA = "0x1875CE5E0")]
			internal List<PlayerLoopSystem> EPBEOAHGPLE(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool ADJGKLHPJKA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool OIPMIDFPNLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x75C63B0", Offset = "0x75C55B0", VA = "0x1875C63B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75C63F0", Offset = "0x75C55F0", VA = "0x1875C63F0")]
		private static void HFCFKEEEMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x75C9610", Offset = "0x75C8810", VA = "0x1875C9610")]
		private static void OAKMEAPMJCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75C6370", Offset = "0x75C5570", VA = "0x1875C6370")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75C6130", Offset = "0x75C5330", VA = "0x1875C6130")]
		private static void AEIODBDOBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75C9450", Offset = "0x75C8650", VA = "0x1875C9450")]
		private static void MJBOCKGCPFE(MBLBHOJCBII.CGJIOADLBNJ CPBLLDDDHEE, PlayerLoopSystem NAIOAJMNKGP, Type FEJODAACHNO, Type DFIMKBKPCCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75C9070", Offset = "0x75C8270", VA = "0x1875C9070")]
		private static void LFEHLOPNFLM(PlayerLoopSystem NAIOAJMNKGP, Type FEJODAACHNO, Type DFIMKBKPCCG, AHDNJGLNDMP DPLDEMFPMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x75C8F40", Offset = "0x75C8140", VA = "0x1875C8F40")]
		private static void IJLCGAOKNFG(PlayerLoopSystem NAIOAJMNKGP, Type FEJODAACHNO, Type DFIMKBKPCCG, PlayerLoopSystem? KPFPACKDDHN, PlayerLoopSystem? OINBMADIIIA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class MBLBHOJCBII
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum CGJIOADLBNJ
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

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class FEBLINJFBEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly CGJIOADLBNJ IFBMGFHADKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly MFOHAMEPPME ELMGPIMDNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long NMHJOPCBDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long BBLAPDHJBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long ACFGDLENAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int EGDBHLOHMGM;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x75CD6A0", Offset = "0x75CC8A0", VA = "0x1875CD6A0")]
		public FEBLINJFBEG(CGJIOADLBNJ KBJJMJJHCHL, int LKFHKBCCFMC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x75CD450", Offset = "0x75CC650", VA = "0x1875CD450")]
		public void LMEAFJEOIFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x75CD400", Offset = "0x75CC600", VA = "0x1875CD400")]
		public void CFFCGCPFPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x75CD4C0", Offset = "0x75CC6C0", VA = "0x1875CD4C0")]
		public void MOEIFCLMAOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static CGJIOADLBNJ[] DHOPFMAGPPN;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static FEBLINJFBEG[] ANFPHHJINHH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x75D9130", Offset = "0x75D8330", VA = "0x1875D9130")]
	public static FEBLINJFBEG CDJAKOECJIP(CGJIOADLBNJ CPBLLDDDHEE, int LKFHKBCCFMC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x75D93B0", Offset = "0x75D85B0", VA = "0x1875D93B0")]
	public static FEBLINJFBEG MHNEHAGLCBG(CGJIOADLBNJ CPBLLDDDHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x75D9310", Offset = "0x75D8510", VA = "0x1875D9310")]
	public static void JLIIIBHMBEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class MFOHAMEPPME : DONPJEOIHOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int GEAAENJHJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> KMNMNOGHHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double LGOHHHLPLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double KBKIMKNFKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double BEGJAJMPDJA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double KLOGGDIOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x75D9620", Offset = "0x75D8820", VA = "0x1875D9620", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double FNGCBAABGOI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4493F00", Offset = "0x4493100", VA = "0x184493F00", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double AEBGEKGHPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x219B480", Offset = "0x219A680", VA = "0x18219B480", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x75D97A0", Offset = "0x75D89A0", VA = "0x1875D97A0")]
	public MFOHAMEPPME(int IJBIHKLBCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x75D9680", Offset = "0x75D8880", VA = "0x1875D9680", Slot = "7")]
	public void IFAGOENFCKB(double MIOIFIAKEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x75D95B0", Offset = "0x75D87B0", VA = "0x1875D95B0", Slot = "8")]
	public void AKMCCPCKADJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PDLGPGDKMMN : DONPJEOIHOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long NDEFEFEFLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double IGKDJHFEMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double LFPCFDNBNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double NGPAKBCJJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double DHEHOLFGHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double LGOHHHLPLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double KBKIMKNFKDL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double FNGCBAABGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x61D4A50", Offset = "0x61D3C50", VA = "0x1861D4A50", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double AEBGEKGHPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x20926C0", Offset = "0x20918C0", VA = "0x1820926C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double NNLEDPKBBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x61D4A80", Offset = "0x61D3C80", VA = "0x1861D4A80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double KLOGGDIOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x27BF240", Offset = "0x27BE440", VA = "0x1827BF240", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x75DD1B0", Offset = "0x75DC3B0", VA = "0x1875DD1B0", Slot = "7")]
	public virtual void IFAGOENFCKB(double MIOIFIAKEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x75DD170", Offset = "0x75DC370", VA = "0x1875DD170", Slot = "8")]
	public virtual void AKMCCPCKADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x75D0730", Offset = "0x75CF930", VA = "0x1875D0730")]
	public PDLGPGDKMMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class GOADOHJMELE : PDLGPGDKMMN
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double DNGGKHPOEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x61D4A60", Offset = "0x61D3C60", VA = "0x1861D4A60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61D4AE0", Offset = "0x61D3CE0", VA = "0x1861D4AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x75D0600", Offset = "0x75CF800", VA = "0x1875D0600", Slot = "7")]
	public override void IFAGOENFCKB(double MIOIFIAKEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x75D05C0", Offset = "0x75CF7C0", VA = "0x1875D05C0", Slot = "8")]
	public override void AKMCCPCKADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x75D0730", Offset = "0x75CF930", VA = "0x1875D0730")]
	public GOADOHJMELE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface DONPJEOIHOP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double KLOGGDIOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double FNGCBAABGOI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double AEBGEKGHPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PEPBFOFHGDN
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface DBCMBOPDDOI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool ONLBGDJPLBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LAKIPCLHGKG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class MGJCOMGBPDN : DBCMBOPDDOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Action ECFGAICLGCA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ONLBGDJPLBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
		public MGJCOMGBPDN(Action ECFGAICLGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xBD4A20", Offset = "0xBD3C20", VA = "0x180BD4A20", Slot = "5")]
		public void LAKIPCLHGKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<DBCMBOPDDOI> FPKADDNIBFN;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x75DDA80", Offset = "0x75DCC80", VA = "0x1875DDA80")]
	public static void MFMAFLPKDGO(Action ECFGAICLGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x75DD3C0", Offset = "0x75DC5C0", VA = "0x1875DD3C0")]
	private static void AGKPLHDFOHA(DBCMBOPDDOI OBIGILEDNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x75DD6D0", Offset = "0x75DC8D0", VA = "0x1875DD6D0")]
	private static void EMPIMMIMOJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x75DD5D0", Offset = "0x75DC7D0", VA = "0x1875DD5D0")]
	private static void BBKKGCDIDPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x75DD9B0", Offset = "0x75DCBB0", VA = "0x1875DD9B0")]
	private static void KONFNOIOFJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class GJHEFJHJPFL
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct PGIAJLHCLOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TaskCompletionSource<Scene> PDFBHLKBOBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly string GDMJHAGCCMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly LoadSceneMode NCANBFAJBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly bool PEBJBBJMAED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly EMBFDJMFMNN<string>.MHBPMONHJAC LGOOIANLLCH;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x75DDBB0", Offset = "0x75DCDB0", VA = "0x1875DDBB0")]
		public PGIAJLHCLOJ(TaskCompletionSource<Scene> AMHGEHKPELL, string GDMJHAGCCMA, LoadSceneMode NCANBFAJBBM, bool PEBJBBJMAED, EMBFDJMFMNN<string>.MHBPMONHJAC LGOOIANLLCH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct KEBEBKCJKBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public EMBFDJMFMNN<string>.MHBPMONHJAC stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private EMBFDJMFMNN<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x75D4370", Offset = "0x75D3570", VA = "0x1875D4370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x75D4C10", Offset = "0x75D3E10", VA = "0x1875D4C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct FAAAHMAFDMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x75CD090", Offset = "0x75CC290", VA = "0x1875CD090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x75CD3A0", Offset = "0x75CC5A0", VA = "0x1875CD3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct JFMEBKILDNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private PGIAJLHCLOJ <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x75D0D70", Offset = "0x75CFF70", VA = "0x1875D0D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x75D1130", Offset = "0x75D0330", VA = "0x1875D1130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class KECHHPDODBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public GJPMFEFCDNC<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public KECHHPDODBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x75D4C80", Offset = "0x75D3E80", VA = "0x1875D4C80")]
		internal void ENDGBMKHJHM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct LPGMCAPOANF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public EMBFDJMFMNN<string>.MHBPMONHJAC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private KECHHPDODBG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EMBFDJMFMNN<string>.MHBPMONHJAC <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private EMBFDJMFMNN<string>.MHBPMONHJAC <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x75D8480", Offset = "0x75D7680", VA = "0x1875D8480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x75D8FE0", Offset = "0x75D81E0", VA = "0x1875D8FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct PKGILOFLDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x75DDE90", Offset = "0x75DD090", VA = "0x1875DDE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x75DE360", Offset = "0x75DD560", VA = "0x1875DE360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct ONDBJOPFPIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public EMBFDJMFMNN<string>.MHBPMONHJAC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EMBFDJMFMNN<string>.MHBPMONHJAC <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private EMBFDJMFMNN<string>.MHBPMONHJAC <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x75DC2C0", Offset = "0x75DB4C0", VA = "0x1875DC2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x75DCDE0", Offset = "0x75DBFE0", VA = "0x1875DCDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class DLBCHLNMJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DLBCHLNMJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x75CC1B0", Offset = "0x75CB3B0", VA = "0x1875CC1B0")]
		internal bool LAINPENILPJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class IIGJAEMIMLC : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public KOKEAEPGGEH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public IIGJAEMIMLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x75D0C60", Offset = "0x75CFE60", VA = "0x1875D0C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x75D0880", Offset = "0x75CFA80", VA = "0x1875D0880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x75D0BC0", Offset = "0x75CFDC0", VA = "0x1875D0BC0")]
		private void ODPIAJHKBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x75D0C10", Offset = "0x75CFE10", VA = "0x1875D0C10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class DBJIEHKEJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public GJPMFEFCDNC<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DBJIEHKEJIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x75CA5D0", Offset = "0x75C97D0", VA = "0x1875CA5D0")]
		internal bool BEEIMGFBANH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x75CA650", Offset = "0x75C9850", VA = "0x1875CA650")]
		internal void HHOAJLFFDLP(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class DAIBGCBCFAN : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public GJPMFEFCDNC<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private DBJIEHKEJIF <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public DAIBGCBCFAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x75C9F20", Offset = "0x75C9120", VA = "0x1875C9F20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x75CA580", Offset = "0x75C9780", VA = "0x1875CA580", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly ICollection<string> AHHJIFHDJBE;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static KAHDNIHNJDF IGGLPFKFDOK;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static AsyncOperation KBMLICCOIJH;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static KAHDNIHNJDF PFFONJPHPMI;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static string OIMKCOOGCHD;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static ThreadPriority ILMMJEEAKGG;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static Task KHPJIEECCBH;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static List<SceneInstance> DEJFHFDFEGN;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly Queue<PGIAJLHCLOJ> GANNIDCNJKG;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task CDKKJKLCJEF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool FMBOMPNJIKP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x75CEAC0", Offset = "0x75CDCC0", VA = "0x1875CEAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private static bool PDNLLCDDACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x75CF470", Offset = "0x75CE670", VA = "0x1875CF470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private static bool MFBEHEPCBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x75CE990", Offset = "0x75CDB90", VA = "0x1875CE990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool BJFNPJBKIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x75CFED0", Offset = "0x75CF0D0", VA = "0x1875CFED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> ICNHMNNOMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x75CEF90", Offset = "0x75CE190", VA = "0x1875CEF90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x75CF0A0", Offset = "0x75CE2A0", VA = "0x1875CF0A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x75CECD0", Offset = "0x75CDED0", VA = "0x1875CECD0")]
	[BMMFAGLDLEH(GOCDKGDGIFE.EnteredEditModeNextFrame, 0)]
	private static void BOEDEKADBNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x75CF510", Offset = "0x75CE710", VA = "0x1875CF510")]
	[AsyncStateMachine(typeof(KEBEBKCJKBO))]
	public static Task<Scene> JAPOGIOJAOM(string GDMJHAGCCMA, LoadSceneMode NCANBFAJBBM = LoadSceneMode.Single, bool PEBJBBJMAED = false, [Optional] EMBFDJMFMNN<string>.MHBPMONHJAC FKAHECEBFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x75CF7E0", Offset = "0x75CE9E0", VA = "0x1875CF7E0")]
	[AsyncStateMachine(typeof(FAAAHMAFDMH))]
	private static Task KKFGLDDOCLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x75CF9E0", Offset = "0x75CEBE0", VA = "0x1875CF9E0")]
	[AsyncStateMachine(typeof(JFMEBKILDNP))]
	private static Task LBOOMNMPPFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x75CF890", Offset = "0x75CEA90", VA = "0x1875CF890")]
	[AsyncStateMachine(typeof(LPGMCAPOANF))]
	private static Task<Scene> KMKMLCHLIJL(string GDMJHAGCCMA, LoadSceneMode NCANBFAJBBM, bool PEBJBBJMAED, EMBFDJMFMNN<string>.MHBPMONHJAC LGOOIANLLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x75CFAB0", Offset = "0x75CECB0", VA = "0x1875CFAB0")]
	private static void LDPPOHJKOLK(SceneInstance PPKIGCGEAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x75CFF60", Offset = "0x75CF160", VA = "0x1875CFF60")]
	private static void PFCKAANOGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x75CFCA0", Offset = "0x75CEEA0", VA = "0x1875CFCA0")]
	[AsyncStateMachine(typeof(PKGILOFLDBE))]
	private static Task<Scene> MHDPKFCDKBD(string GDMJHAGCCMA, LoadSceneMode NCANBFAJBBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x75CFBB0", Offset = "0x75CEDB0", VA = "0x1875CFBB0")]
	private static bool MDHBLGOLLFJ(string GDMJHAGCCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x75CFDC0", Offset = "0x75CEFC0", VA = "0x1875CFDC0")]
	[AsyncStateMachine(typeof(ONDBJOPFPIL))]
	private static Task<Scene> NMKPGOLBECE(EMBFDJMFMNN<string>.MHBPMONHJAC LGOOIANLLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x75CF660", Offset = "0x75CE860", VA = "0x1875CF660")]
	public static PIHPPMDHIHB<Scene> JJDOLPEKDMK(string GDMJHAGCCMA, LoadSceneMode NCANBFAJBBM = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x75CF1B0", Offset = "0x75CE3B0", VA = "0x1875CF1B0")]
	public static KAHDNIHNJDF IDLBDKECFLB(string GDMJHAGCCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x75CEA30", Offset = "0x75CDC30", VA = "0x1875CEA30")]
	[IteratorStateMachine(typeof(IIGJAEMIMLC))]
	private static IEnumerator<CKLDDHMAHNL> AKFLFLLKEGP(string GDMJHAGCCMA, KOKEAEPGGEH JOIOMJAGOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x75CEEF0", Offset = "0x75CE0F0", VA = "0x1875CEEF0")]
	[IteratorStateMachine(typeof(DAIBGCBCFAN))]
	private static IEnumerator<CKLDDHMAHNL> CJENPNFDCEJ(string GDMJHAGCCMA, LoadSceneMode NCANBFAJBBM, GJPMFEFCDNC<Scene> JOIOMJAGOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x75CEDC0", Offset = "0x75CDFC0", VA = "0x1875CEDC0")]
	public static bool CFKODIBKGNM([Out] string DIGMIMJIHIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KGCHNCAFNKO
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x75D5300", Offset = "0x75D4500", VA = "0x1875D5300")]
	public static IDisposable GIHOEGLFJLI(this FDAOEAPNMNA GFIAFOEJCDD, float PAFDFHFLFOJ, Action<float> LDLGCGPDDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x75D5200", Offset = "0x75D4400", VA = "0x1875D5200")]
	public static IDisposable CDLHGOODNOJ(this FDAOEAPNMNA GFIAFOEJCDD, Action<float> LDLGCGPDDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x75D5280", Offset = "0x75D4480", VA = "0x1875D5280")]
	public static IDisposable FFBCLCELGOA(this FDAOEAPNMNA GFIAFOEJCDD, Action<float> LDLGCGPDDBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NFPFKGEIFEL
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x75DA840", Offset = "0x75D9A40", VA = "0x1875DA840")]
	public static IDisposable CINDCOCFMMG(this MonoBehaviour DANPBMMGEMC, Action LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x75DA7B0", Offset = "0x75D99B0", VA = "0x1875DA7B0")]
	public static IDisposable CINDCOCFMMG(this MonoBehaviour DANPBMMGEMC, Action<float> LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x75DAB20", Offset = "0x75D9D20", VA = "0x1875DAB20")]
	public static IDisposable GEGAIMNPNFH(this MonoBehaviour DANPBMMGEMC, Action LDLGCGPDDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x75DA970", Offset = "0x75D9B70", VA = "0x1875DA970")]
	public static IDisposable EEOMNLBNFKC(this MonoBehaviour DANPBMMGEMC, Action LDLGCGPDDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x75DA9F0", Offset = "0x75D9BF0", VA = "0x1875DA9F0")]
	public static IDisposable EEOMNLBNFKC(this MonoBehaviour DANPBMMGEMC, Action<float> LDLGCGPDDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x75DB020", Offset = "0x75DA220", VA = "0x1875DB020")]
	public static IDisposable PJMIEHIDMEH(this MonoBehaviour DANPBMMGEMC, Action LDLGCGPDDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x75DA5F0", Offset = "0x75D97F0", VA = "0x1875DA5F0")]
	public static IDisposable BKJABHAECJM(this MonoBehaviour DANPBMMGEMC, Action LDLGCGPDDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x75DABD0", Offset = "0x75D9DD0", VA = "0x1875DABD0")]
	public static IDisposable KBLGFMBKAFE(this MonoBehaviour DANPBMMGEMC, Action LDLGCGPDDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x75DAED0", Offset = "0x75DA0D0", VA = "0x1875DAED0")]
	public static IDisposable MOFNFPOEOIH(this MonoBehaviour DANPBMMGEMC, float PAFDFHFLFOJ, Action<float> LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL, bool ADEAPBHLPGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x75DABA0", Offset = "0x75D9DA0", VA = "0x1875DABA0")]
	public static IDisposable HFFFDJIFODF(this MonoBehaviour DANPBMMGEMC, float PAFDFHFLFOJ, Action<float> LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL, bool ADEAPBHLPGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x75DA710", Offset = "0x75D9910", VA = "0x1875DA710")]
	public static IDisposable CCLPJEEJKNL(this MonoBehaviour DANPBMMGEMC, float PAFDFHFLFOJ, Action<float> LDLGCGPDDBB, bool ADEAPBHLPGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75DAD90", Offset = "0x75D9F90", VA = "0x1875DAD90")]
	public static IDisposable MJMAFLOAGNL(this MonoBehaviour DANPBMMGEMC, Action<float> LDLGCGPDDBB, bool ADEAPBHLPGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x75DA8D0", Offset = "0x75D9AD0", VA = "0x1875DA8D0")]
	public static IDisposable CLCGKMOHIHH(this MonoBehaviour DANPBMMGEMC, Action<float> LDLGCGPDDBB, bool ADEAPBHLPGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x75DAC50", Offset = "0x75D9E50", VA = "0x1875DAC50")]
	public static IDisposable KFAIMJFIBJA(this MonoBehaviour DANPBMMGEMC, Action<float> LDLGCGPDDBB, bool ADEAPBHLPGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x75DAE30", Offset = "0x75DA030", VA = "0x1875DAE30")]
	public static IDisposable MMGKNEHDOLC(this MonoBehaviour DANPBMMGEMC, Action<float> LDLGCGPDDBB, bool ADEAPBHLPGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x75DACF0", Offset = "0x75D9EF0", VA = "0x1875DACF0")]
	public static IDisposable LLLKBFODMFM(this MonoBehaviour DANPBMMGEMC, Action<float> LDLGCGPDDBB, bool ADEAPBHLPGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x75DAF80", Offset = "0x75DA180", VA = "0x1875DAF80")]
	public static IDisposable OADDMCKLKLL(this MonoBehaviour DANPBMMGEMC, Action<float> LDLGCGPDDBB, bool ADEAPBHLPGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x75DA670", Offset = "0x75D9870", VA = "0x1875DA670")]
	public static IDisposable CAGCIGDOADN(this MonoBehaviour DANPBMMGEMC, Action<float> LDLGCGPDDBB, bool ADEAPBHLPGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x75DAA70", Offset = "0x75D9C70", VA = "0x1875DAA70")]
	public static IDisposable EJPPFJJPOMC(this MonoBehaviour DANPBMMGEMC, float PAFDFHFLFOJ, Action<float> LDLGCGPDDBB, bool ADEAPBHLPGE = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CDNPOMDPALE
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class ONFKCPKFLFO : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public BHKJBMCGABE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private FCJLKHMCNBP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public ONFKCPKFLFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x75DCE50", Offset = "0x75DC050", VA = "0x1875DCE50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x75DCF30", Offset = "0x75DC130", VA = "0x1875DCF30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class FNMOFJPJPKC : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public BHKJBMCGABE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private FCJLKHMCNBP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public FNMOFJPJPKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x75CE240", Offset = "0x75CD440", VA = "0x1875CE240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x75CE330", Offset = "0x75CD530", VA = "0x1875CE330", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x75C44C0", Offset = "0x75C36C0", VA = "0x1875C44C0")]
	public static GMLIOGMHHKE CINDCOCFMMG(Action LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x75C4350", Offset = "0x75C3550", VA = "0x1875C4350")]
	public static GMLIOGMHHKE CINDCOCFMMG(Behaviour GFIAFOEJCDD, Action LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x75C43E0", Offset = "0x75C35E0", VA = "0x1875C43E0")]
	public static GMLIOGMHHKE CINDCOCFMMG(Behaviour GFIAFOEJCDD, Action<float> LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x75C45D0", Offset = "0x75C37D0", VA = "0x1875C45D0")]
	[IteratorStateMachine(typeof(ONFKCPKFLFO))]
	private static IEnumerator<CKLDDHMAHNL> LGGCDLOCONH(BHKJBMCGABE AFOHGMJOEPH, Action LDLGCGPDDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x75C4540", Offset = "0x75C3740", VA = "0x1875C4540")]
	[IteratorStateMachine(typeof(FNMOFJPJPKC))]
	private static IEnumerator<CKLDDHMAHNL> LGGCDLOCONH(BHKJBMCGABE AFOHGMJOEPH, Action<float> LDLGCGPDDBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PCBOOCNBKLP : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class HFKHDAHNEBE : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public PCBOOCNBKLP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public HFKHDAHNEBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x75D0760", Offset = "0x75CF960", VA = "0x1875D0760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x75D07F0", Offset = "0x75CF9F0", VA = "0x1875D07F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly BHKJBMCGABE MABOMBCPBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Action BCIEDOILIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private bool EJHLCMNPJFB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool CMCDJGBNDPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8944D0", Offset = "0x8936D0", VA = "0x1808944D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x75DD0A0", Offset = "0x75DC2A0", VA = "0x1875DD0A0")]
	public PCBOOCNBKLP(BHKJBMCGABE MABOMBCPBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x75DCF80", Offset = "0x75DC180", VA = "0x1875DCF80")]
	[IteratorStateMachine(typeof(HFKHDAHNEBE))]
	private IEnumerator<CKLDDHMAHNL> HGCNLPKLOJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x75DD000", Offset = "0x75DC200", VA = "0x1875DD000", Slot = "4")]
	public void OnCompleted(Action CAKKFAJNANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	public void LNBNKFJNAAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class EPAKJCGNHDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x75CCF80", Offset = "0x75CC180", VA = "0x1875CCF80")]
	public static PCBOOCNBKLP KHBMABMNGIM(this BHKJBMCGABE MABOMBCPBNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class CHCGFBIPPLE
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class BFECMPDIDEA : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public HFAKMKPEPOA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public BFECMPDIDEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x75C3DB0", Offset = "0x75C2FB0", VA = "0x1875C3DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x75C3E30", Offset = "0x75C3030", VA = "0x1875C3E30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x75C4790", Offset = "0x75C3990", VA = "0x1875C4790")]
	public static GMLIOGMHHKE CINDCOCFMMG(float PAFDFHFLFOJ, Action<float> LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL, bool ADEAPBHLPGE = true, [Optional] LMNFIMBPJDA MKEHNCBDCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x75C46C0", Offset = "0x75C38C0", VA = "0x1875C46C0")]
	public static GMLIOGMHHKE CINDCOCFMMG(MonoBehaviour DANPBMMGEMC, float PAFDFHFLFOJ, Action<float> LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL, bool ADEAPBHLPGE = true, [Optional] LMNFIMBPJDA MKEHNCBDCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x75C4860", Offset = "0x75C3A60", VA = "0x1875C4860")]
	public static GMLIOGMHHKE DHKCJNFPABL(MonoBehaviour DANPBMMGEMC, float PAFDFHFLFOJ, Action<float> LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL, bool ADEAPBHLPGE = true, [Optional] LMNFIMBPJDA MKEHNCBDCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x75C4AA0", Offset = "0x75C3CA0", VA = "0x1875C4AA0")]
	public static GMLIOGMHHKE OIPCBBKHLGF(FDAOEAPNMNA GFIAFOEJCDD, float PAFDFHFLFOJ, Action<float> LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL, bool ADEAPBHLPGE = true, [Optional] LMNFIMBPJDA MKEHNCBDCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x75C49E0", Offset = "0x75C3BE0", VA = "0x1875C49E0")]
	private static IEnumerator<CKLDDHMAHNL> LGGCDLOCONH(DEMOGDMKMNA BFMLPDJIFKN, float PAFDFHFLFOJ, BHKJBMCGABE AFOHGMJOEPH, Action<float> LDLGCGPDDBB, bool ADEAPBHLPGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x75C4660", Offset = "0x75C3860", VA = "0x1875C4660")]
	private static IEnumerator<CKLDDHMAHNL> BGHGFADCNLD(DEMOGDMKMNA BFMLPDJIFKN, float PAFDFHFLFOJ, BHKJBMCGABE AFOHGMJOEPH, Action<float> LDLGCGPDDBB, bool ADEAPBHLPGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x75C4950", Offset = "0x75C3B50", VA = "0x1875C4950")]
	[IteratorStateMachine(typeof(BFECMPDIDEA))]
	private static IEnumerator<CKLDDHMAHNL> HBAIIELBKAF(HFAKMKPEPOA CGGDJIPNBAJ, float PAFDFHFLFOJ, BHKJBMCGABE AFOHGMJOEPH, Action<float> LDLGCGPDDBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class GHDHPCDHIPI
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class BJFCIAKFGFP : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public BHKJBMCGABE queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public BJFCIAKFGFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x75C4060", Offset = "0x75C3260", VA = "0x1875C4060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x75C4120", Offset = "0x75C3320", VA = "0x1875C4120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x75CE7E0", Offset = "0x75CD9E0", VA = "0x1875CE7E0")]
	[IteratorStateMachine(typeof(BJFCIAKFGFP))]
	private static IEnumerator<CKLDDHMAHNL> POECJFJELKF(BHKJBMCGABE MABOMBCPBNL, Func<bool> MLDFEJJHIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x75CE700", Offset = "0x75CD900", VA = "0x1875CE700")]
	public static GMLIOGMHHKE BCFPJMPCHKN(this MonoBehaviour DANPBMMGEMC, Func<bool> MLDFEJJHIJL, BHKJBMCGABE MABOMBCPBNL = BHKJBMCGABE.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class FHIKHDJPMOE
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class FEOJMNPMEBN : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public BHKJBMCGABE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public FEOJMNPMEBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x75CD7B0", Offset = "0x75CC9B0", VA = "0x1875CD7B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x75CD820", Offset = "0x75CCA20", VA = "0x1875CD820", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class MABCFDEEIDF : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public BHKJBMCGABE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private CKLDDHMAHNL <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public MABCFDEEIDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x75D9050", Offset = "0x75D8250", VA = "0x1875D9050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x75D90E0", Offset = "0x75D82E0", VA = "0x1875D90E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x75CDDF0", Offset = "0x75CCFF0", VA = "0x1875CDDF0")]
	[IteratorStateMachine(typeof(FEOJMNPMEBN))]
	private static IEnumerator<CKLDDHMAHNL> HGCNLPKLOJN(float NPIKCMPEMNK, BHKJBMCGABE AFOHGMJOEPH, Action OMCFGJPALAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x75CDF20", Offset = "0x75CD120", VA = "0x1875CDF20")]
	[IteratorStateMachine(typeof(MABCFDEEIDF))]
	private static IEnumerator<CKLDDHMAHNL> JLCJJHLBDCJ(float NPIKCMPEMNK, BHKJBMCGABE AFOHGMJOEPH, Action OMCFGJPALAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x75CDB30", Offset = "0x75CCD30", VA = "0x1875CDB30")]
	public static IDisposable CNNEJJIDNNB(this MonoBehaviour DANPBMMGEMC, float NPIKCMPEMNK, Action OMCFGJPALAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x75CD910", Offset = "0x75CCB10", VA = "0x1875CD910")]
	public static GMLIOGMHHKE BMBBOKAFCBB(this MonoBehaviour DANPBMMGEMC, float NPIKCMPEMNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x75CDA40", Offset = "0x75CCC40", VA = "0x1875CDA40")]
	public static GMLIOGMHHKE CNNEJJIDNNB(this MonoBehaviour DANPBMMGEMC, float NPIKCMPEMNK, BHKJBMCGABE AFOHGMJOEPH, Action OMCFGJPALAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x75CDFC0", Offset = "0x75CD1C0", VA = "0x1875CDFC0")]
	public static GMLIOGMHHKE LOOOPDABOKO(this MonoBehaviour DANPBMMGEMC, Action OMCFGJPALAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x75CE1A0", Offset = "0x75CD3A0", VA = "0x1875CE1A0")]
	public static GMLIOGMHHKE POPIGGKCLGJ(this MonoBehaviour DANPBMMGEMC, Action OMCFGJPALAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x75CE060", Offset = "0x75CD260", VA = "0x1875CE060")]
	public static GMLIOGMHHKE NOPHDOBEKAA(this MonoBehaviour DANPBMMGEMC, Action OMCFGJPALAE, [Optional] LMNFIMBPJDA MKEHNCBDCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x75CDCB0", Offset = "0x75CCEB0", VA = "0x1875CDCB0")]
	public static GMLIOGMHHKE DLOMKHKCJME(this MonoBehaviour DANPBMMGEMC, Action OMCFGJPALAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x75CD9A0", Offset = "0x75CCBA0", VA = "0x1875CD9A0")]
	public static GMLIOGMHHKE CDMEDLEEBLI(this MonoBehaviour DANPBMMGEMC, Action OMCFGJPALAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x75CD870", Offset = "0x75CCA70", VA = "0x1875CD870")]
	private static GMLIOGMHHKE BLNOFLHLDGM(MonoBehaviour DANPBMMGEMC, BHKJBMCGABE MABOMBCPBNL, Action OMCFGJPALAE, [Optional] LMNFIMBPJDA MKEHNCBDCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x75CDE90", Offset = "0x75CD090", VA = "0x1875CDE90")]
	public static GMLIOGMHHKE IDOILLCHHNK(this MonoBehaviour DANPBMMGEMC, float HHGDAAACMNA, Action OMCFGJPALAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x75CE100", Offset = "0x75CD300", VA = "0x1875CE100")]
	public static GMLIOGMHHKE PNNMOOPNJML(this MonoBehaviour DANPBMMGEMC, float HHGDAAACMNA, Action OMCFGJPALAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x75CDD50", Offset = "0x75CCF50", VA = "0x1875CDD50")]
	public static GMLIOGMHHKE ENCMMEBKDPD(this MonoBehaviour DANPBMMGEMC, float HHGDAAACMNA, Action OMCFGJPALAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x75CDC10", Offset = "0x75CCE10", VA = "0x1875CDC10")]
	public static GMLIOGMHHKE DKOGNHDKFOE(this MonoBehaviour DANPBMMGEMC, float HHGDAAACMNA, Action OMCFGJPALAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class ELGNAFJFLLF : HEFMPGEOOHA, IEnumerable<HEFMPGEOOHA>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<HEFMPGEOOHA> IJJKOODPEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool ALJAJCDJJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Action GPBMIODMNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool NEOPHJJMDBH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool NLLNKBLCFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x75CC8B0", Offset = "0x75CBAB0", VA = "0x1875CC8B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EPLEJBFEGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x75CC480", Offset = "0x75CB680", VA = "0x1875CC480", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x75CCB10", Offset = "0x75CBD10", VA = "0x1875CCB10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x75CCD00", Offset = "0x75CBF00", VA = "0x1875CCD00")]
	public ELGNAFJFLLF([Optional] Action GPBMIODMNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x75CC9E0", Offset = "0x75CBBE0", VA = "0x1875CC9E0")]
	public void JIJNOIKPNBF(HEFMPGEOOHA HHLICAKGHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x75CCBB0", Offset = "0x75CBDB0", VA = "0x1875CCBB0")]
	private void KIAFEDEDMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x75CC820", Offset = "0x75CBA20", VA = "0x1875CC820", Slot = "7")]
	public bool EBNLECNEAMN(bool PLHFEDHICDP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x75CC520", Offset = "0x75CB720", VA = "0x1875CC520", Slot = "8")]
	public bool EBNLECNEAMN(Action ECFGAICLGCA, bool PLHFEDHICDP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x75CC830", Offset = "0x75CBA30", VA = "0x1875CC830", Slot = "9")]
	public IEnumerator<HEFMPGEOOHA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x75CC830", Offset = "0x75CBA30", VA = "0x1875CC830", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OMEAPHKDECN : DFBFDMNHLLF
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class PFKJCJFKPGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public OMEAPHKDECN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public PFKJCJFKPGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x75DA100", Offset = "0x75D9300", VA = "0x1875DA100")]
		internal void LNNMAGMCOCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class MLFNBEIINHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public OMEAPHKDECN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public MLFNBEIINHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x75DA100", Offset = "0x75D9300", VA = "0x1875DA100")]
		internal void ECFBNDMACNC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly float JNNMDHNKFCL;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x75C5FF0", Offset = "0x75C51F0", VA = "0x1875C5FF0")]
	public OMEAPHKDECN(Behaviour GFIAFOEJCDD, float JNNMDHNKFCL, [Optional] Action GPBMIODMNBC, [Optional] LMNFIMBPJDA MKEHNCBDCJJ, [Optional] DEMOGDMKMNA BFMLPDJIFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x75DC1B0", Offset = "0x75DB3B0", VA = "0x1875DC1B0", Slot = "9")]
	protected override bool MIDPIINFLEF(Action ECFGAICLGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x75DC0A0", Offset = "0x75DB2A0", VA = "0x1875DC0A0", Slot = "10")]
	protected override bool HGIPJGNKCCO(Action ECFGAICLGCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface HEFMPGEOOHA
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool NLLNKBLCFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action EPLEJBFEGNL;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EBNLECNEAMN(bool PLHFEDHICDP = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EBNLECNEAMN(Action ECFGAICLGCA, bool PLHFEDHICDP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class DFBFDMNHLLF : HEFMPGEOOHA
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class GIBEFNOBIJM : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public DFBFDMNHLLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public GIBEFNOBIJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x75CE870", Offset = "0x75CDA70", VA = "0x1875CE870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x75CE940", Offset = "0x75CDB40", VA = "0x1875CE940", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Behaviour GFIAFOEJCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action GPBMIODMNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private FKNJNNPDPCK ICFABFEJAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly LMNFIMBPJDA MKEHNCBDCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly DEMOGDMKMNA BFMLPDJIFKN;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NLLNKBLCFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1159F00", Offset = "0x1159100", VA = "0x181159F00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action EPLEJBFEGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x75CB8E0", Offset = "0x75CAAE0", VA = "0x1875CB8E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x75CBB30", Offset = "0x75CAD30", VA = "0x1875CBB30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x75CBEA0", Offset = "0x75CB0A0", VA = "0x1875CBEA0")]
	protected DFBFDMNHLLF(Behaviour GFIAFOEJCDD, [Optional] Action GPBMIODMNBC, [Optional] LMNFIMBPJDA MKEHNCBDCJJ, [Optional] DEMOGDMKMNA BFMLPDJIFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x75CBA20", Offset = "0x75CAC20", VA = "0x1875CBA20", Slot = "7")]
	public bool EBNLECNEAMN(bool PLHFEDHICDP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x75CB9C0", Offset = "0x75CABC0", VA = "0x1875CB9C0", Slot = "8")]
	public bool EBNLECNEAMN(Action ECFGAICLGCA, bool PLHFEDHICDP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool MIDPIINFLEF(Action ECFGAICLGCA);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool HGIPJGNKCCO(Action ECFGAICLGCA);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x75CBA80", Offset = "0x75CAC80", VA = "0x1875CBA80")]
	protected void FAKMHFBBAFP(Action ECFGAICLGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x75CBC50", Offset = "0x75CAE50", VA = "0x1875CBC50")]
	protected KAHDNIHNJDF NPCMMLEEPLO(float OIHNKNJFMCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x75CBBD0", Offset = "0x75CADD0", VA = "0x1875CBBD0")]
	private void KJGIPCGAGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x75CBAA0", Offset = "0x75CACA0", VA = "0x1875CBAA0")]
	[IteratorStateMachine(typeof(GIBEFNOBIJM))]
	private IEnumerator<CKLDDHMAHNL> FCBLPBMALLN(float OIHNKNJFMCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x75CB980", Offset = "0x75CAB80", VA = "0x1875CB980")]
	[CompilerGenerated]
	private void DFPFIEKBEAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class KDCCBAPMHBE : DFBFDMNHLLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float CAOMLPBDHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int OKNOFLKFBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float NDICJMPAAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float[] MAMFPKOPJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int GDECAANMPEE;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x75D41A0", Offset = "0x75D33A0", VA = "0x1875D41A0")]
	public KDCCBAPMHBE(Behaviour GFIAFOEJCDD, float IGILALDNLGN, int OKNOFLKFBLM, [Optional] Action GPBMIODMNBC, float NDICJMPAAHD = 0f, [Optional] LMNFIMBPJDA MKEHNCBDCJJ, [Optional] DEMOGDMKMNA BFMLPDJIFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "9")]
	protected override bool MIDPIINFLEF(Action ECFGAICLGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x75D3FA0", Offset = "0x75D31A0", VA = "0x1875D3FA0", Slot = "10")]
	protected override bool HGIPJGNKCCO(Action ECFGAICLGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x75D3F20", Offset = "0x75D3120", VA = "0x1875D3F20")]
	private void GEADPOOJLIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class COLFPLCAAAD : DFBFDMNHLLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float JNNMDHNKFCL;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x75C5FF0", Offset = "0x75C51F0", VA = "0x1875C5FF0")]
	public COLFPLCAAAD(Behaviour GFIAFOEJCDD, float JNNMDHNKFCL, [Optional] Action GPBMIODMNBC, [Optional] LMNFIMBPJDA MKEHNCBDCJJ, [Optional] DEMOGDMKMNA BFMLPDJIFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "9")]
	protected override bool MIDPIINFLEF(Action ECFGAICLGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x75C5FB0", Offset = "0x75C51B0", VA = "0x1875C5FB0", Slot = "10")]
	protected override bool HGIPJGNKCCO(Action ECFGAICLGCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class DCCLKADGBMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class EJBHNHIMOCF : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public EJBHNHIMOCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x75CC3C0", Offset = "0x75CB5C0", VA = "0x1875CC3C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x75CC430", Offset = "0x75CB630", VA = "0x1875CC430", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private GMLIOGMHHKE ECMKNMDHJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private FDAOEAPNMNA GFIAFOEJCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Action<float> CFPMABHDGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private BHKJBMCGABE MABOMBCPBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float EJBDDFKDNON;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x75CADB0", Offset = "0x75C9FB0", VA = "0x1875CADB0")]
	public DCCLKADGBMO(FDAOEAPNMNA GFIAFOEJCDD, float PAFDFHFLFOJ, Action<float> LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x75CA990", Offset = "0x75C9B90", VA = "0x1875CA990")]
	private void EEKDPIGLFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x75CAB00", Offset = "0x75C9D00", VA = "0x1875CAB00")]
	private void NCNKDBNPGEA(string BAHJDCJDFHC, Action AOGIHJBMBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x75CA8B0", Offset = "0x75C9AB0", VA = "0x1875CA8B0")]
	[IteratorStateMachine(typeof(EJBHNHIMOCF))]
	private IEnumerator<CKLDDHMAHNL> DPGKHFCBHME(Action AOGIHJBMBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x75CA930", Offset = "0x75C9B30", VA = "0x1875CA930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x75CAC30", Offset = "0x75C9E30", VA = "0x1875CAC30")]
	[CompilerGenerated]
	private void OBABJBCKGMJ(string DJGHECPCKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class CJAGJEPGKDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class KEPCJGFLDJC : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public KEPCJGFLDJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x75CC3C0", Offset = "0x75CB5C0", VA = "0x1875CC3C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x75D4CE0", Offset = "0x75D3EE0", VA = "0x1875D4CE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GMLIOGMHHKE ECMKNMDHJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private MonoBehaviour DANPBMMGEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action LDLGCGPDDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Action<float> CFPMABHDGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private BHKJBMCGABE MABOMBCPBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float EJBDDFKDNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private bool ADEAPBHLPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly LMNFIMBPJDA MKEHNCBDCJJ;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x75C5B50", Offset = "0x75C4D50", VA = "0x1875C5B50")]
	public CJAGJEPGKDI(MonoBehaviour DANPBMMGEMC, Action LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL, [Optional] LMNFIMBPJDA MKEHNCBDCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x75C5980", Offset = "0x75C4B80", VA = "0x1875C5980")]
	public CJAGJEPGKDI(MonoBehaviour DANPBMMGEMC, Action<float> LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL, [Optional] LMNFIMBPJDA MKEHNCBDCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x75C57A0", Offset = "0x75C49A0", VA = "0x1875C57A0")]
	public CJAGJEPGKDI(MonoBehaviour DANPBMMGEMC, float PAFDFHFLFOJ, Action<float> LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL, bool ADEAPBHLPGE = true, [Optional] LMNFIMBPJDA MKEHNCBDCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x208F290", Offset = "0x208E490", VA = "0x18208F290")]
	private CJAGJEPGKDI(LMNFIMBPJDA MKEHNCBDCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x75C5100", Offset = "0x75C4300", VA = "0x1875C5100")]
	internal static CJAGJEPGKDI ENNOPFFGLCO(MonoBehaviour DANPBMMGEMC, float PAFDFHFLFOJ, Action<float> LDLGCGPDDBB, BHKJBMCGABE MABOMBCPBNL, bool ADEAPBHLPGE = true, [Optional] LMNFIMBPJDA MKEHNCBDCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x75C4D80", Offset = "0x75C3F80", VA = "0x1875C4D80")]
	private void CINDCOCFMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x75C4C00", Offset = "0x75C3E00", VA = "0x1875C4C00")]
	private void CGDGHALMHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x75C4F90", Offset = "0x75C4190", VA = "0x1875C4F90")]
	private void EEKDPIGLFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x75C53C0", Offset = "0x75C45C0", VA = "0x1875C53C0")]
	private void JFEPOJDDOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x75C55E0", Offset = "0x75C47E0", VA = "0x1875C55E0")]
	private void NCNKDBNPGEA(string BAHJDCJDFHC, Action AOGIHJBMBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x75C4EB0", Offset = "0x75C40B0", VA = "0x1875C4EB0")]
	[IteratorStateMachine(typeof(KEPCJGFLDJC))]
	private IEnumerator<CKLDDHMAHNL> DPGKHFCBHME(Action AOGIHJBMBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x75C4F30", Offset = "0x75C4130", VA = "0x1875C4F30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x75C5710", Offset = "0x75C4910", VA = "0x1875C5710")]
	[CompilerGenerated]
	private void PKPFHAPEIHI(string DJGHECPCKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x75C5550", Offset = "0x75C4750", VA = "0x1875C5550")]
	[CompilerGenerated]
	private void KDMMBOEIPMA(string DJGHECPCKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x75C4B70", Offset = "0x75C3D70", VA = "0x1875C4B70")]
	[CompilerGenerated]
	private void ADIKNLPPECF(string DJGHECPCKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x75C5330", Offset = "0x75C4530", VA = "0x1875C5330")]
	[CompilerGenerated]
	private void IPFOFNNOBPE(string DJGHECPCKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum LFIKGPHDDLC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal sealed class GKFFPBNGEFL : DEMOGDMKMNA
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float PBOFNKMPNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x75D05B0", Offset = "0x75CF7B0", VA = "0x1875D05B0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float LGDKAGOJMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x75D0530", Offset = "0x75CF730", VA = "0x1875D0530", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public double DLAJGJMLIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x75D0510", Offset = "0x75CF710", VA = "0x1875D0510", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x75D0540", Offset = "0x75CF740", VA = "0x1875D0540")]
	[NPIOOMADHDK.JLDADBHPDAA]
	internal static void NLJAFONFJGA(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	[UnityEngine.Scripting.Preserve]
	internal GKFFPBNGEFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface CKOHBDOJPFO
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MADIFKCGCAA(string EPPPGDEIJCI);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INAPKLLOCKM();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface AJFKBFJKLIN
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string HPIOEFIINLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool GAJGBHCNAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool GAOLDGFKNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class KFNPAGMABGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public LAOCFEAMEMG CICELMINIJA;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int NLHHONDOFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x75D4F60", Offset = "0x75D4160", VA = "0x1875D4F60")]
	public static CKLDDHMAHNL KJJKECMPDDD(IEnumerator<CKLDDHMAHNL> JBDKBKBLOGB, ILEKALKKIAJ HCIFBHNBDMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x75D4EA0", Offset = "0x75D40A0", VA = "0x1875D4EA0")]
	public CKLDDHMAHNL KJJKECMPDDD(ILEKALKKIAJ[] CNNNBLJAMMC, IEnumerator<CKLDDHMAHNL>[] BFPLPFJFEIL, CKLDDHMAHNL[] LJKJHMOEDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x75D4E70", Offset = "0x75D4070", VA = "0x1875D4E70")]
	public void GKKJAICDALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x75D50C0", Offset = "0x75D42C0", VA = "0x1875D50C0")]
	public void KNDJLOJGJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x75D4D30", Offset = "0x75D3F30", VA = "0x1875D4D30")]
	public void ECMMHHFDNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x75D4E70", Offset = "0x75D4070", VA = "0x1875D4E70")]
	public void HKNKENJBLKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public KFNPAGMABGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class LAOCFEAMEMG
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct EJDBKGJNICO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public KFNPAGMABGO FEAEKHIFJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public FDAOEAPNMNA HNIDMBLCBJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public ILEKALKKIAJ MILHBMNJNLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public IEnumerator<CKLDDHMAHNL> PHNPOOJBCGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public CKLDDHMAHNL BLALMDFDKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public LFIKGPHDDLC BGMNLGBEPFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct DEKNMCIDMDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public BHKJBMCGABE HIPCAFJNGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public List<EJDBKGJNICO> GMGPGGMIKHA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class DCFGGLCBPHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public ILEKALKKIAJ promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public LAOCFEAMEMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public FDAOEAPNMNA context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public KFNPAGMABGO routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public LFIKGPHDDLC coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public CKLDDHMAHNL currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IEnumerator<CKLDDHMAHNL> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DCFGGLCBPHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x75CAF50", Offset = "0x75CA150", VA = "0x1875CAF50")]
		internal void LGPPCHDLGDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class AMPABGMCGHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public KFNPAGMABGO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public LAOCFEAMEMG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public AMPABGMCGHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x75C3540", Offset = "0x75C2740", VA = "0x1875C3540")]
		internal void KHHCACKLMNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class KODBMPNJFFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public KFNPAGMABGO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public LAOCFEAMEMG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public KODBMPNJFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x75D5820", Offset = "0x75D4A20", VA = "0x1875D5820")]
		internal void MCGAJFHLLKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class IGJOEKPNLLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public KFNPAGMABGO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public LAOCFEAMEMG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public IGJOEKPNLLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x75D0840", Offset = "0x75CFA40", VA = "0x1875D0840")]
		internal void BMGBBPKMOEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private const LFIKGPHDDLC NLIBHLCADAB = LFIKGPHDDLC.Cancelled | LFIKGPHDDLC.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly BHKJBMCGABE MABOMBCPBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool[] HDKGPNJKFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<LFIKGPHDDLC> OAEDPEDIOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<float> LPBDBIFFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> MFIEIMNODBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> MCGOCFEEJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> OHPCMFLAJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> GPOFBAGGFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> BDFABCOMOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private KFNPAGMABGO[] MPOHLKNCIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private ILEKALKKIAJ[] CNNNBLJAMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private FDAOEAPNMNA[] NMOJFKCOJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IEnumerator<CKLDDHMAHNL>[] IONEIKKOMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private CKLDDHMAHNL[] ECLHAKAGJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int HFNAECBKHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int LCNCMFGPICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly int OAEHNBCMBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float HEFLCJBMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private BCGIIGFMGGL BCHJPBNEABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private JobHandle OAONHMGGBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<KFNPAGMABGO> CKCKBGGFEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool OKIDEBPMDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> KKBCLEHPMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<Action> NOFDKOMNKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool LAIPMKBCIGG;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DEKNMCIDMDM[] EFCLNOCFJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8E4EB0", Offset = "0x8E40B0", VA = "0x1808E4EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x75D64B0", Offset = "0x75D56B0", VA = "0x1875D64B0")]
	private static int CDGEAGPADAO(BHKJBMCGABE MABOMBCPBNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x75D7BD0", Offset = "0x75D6DD0", VA = "0x1875D7BD0")]
	public LAOCFEAMEMG(BHKJBMCGABE MABOMBCPBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x75D7510", Offset = "0x75D6710", VA = "0x1875D7510")]
	private void NPNNAHAPLID(int GGKGIHEACLO, int GEIGPOLKKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x75D77F0", Offset = "0x75D69F0", VA = "0x1875D77F0")]
	public void OFDLGIEMKIM(FDAOEAPNMNA GFIAFOEJCDD, CKLDDHMAHNL ANELILHAJBG, IEnumerator<CKLDDHMAHNL> JBDKBKBLOGB, ILEKALKKIAJ HCIFBHNBDMC, [Optional] KFNPAGMABGO OPHNMABKHJD, LFIKGPHDDLC DNOKELAAGMC = LFIKGPHDDLC.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x75D6D60", Offset = "0x75D5F60", VA = "0x1875D6D60")]
	public void HMLGAMMKNLN(IEnumerable<EJDBKGJNICO> GKINDPHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x75D5FE0", Offset = "0x75D51E0", VA = "0x1875D5FE0")]
	private EJDBKGJNICO ALKLHOELOED(int ANCLPLNKFCK)
	{
		return default(EJDBKGJNICO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x75D7070", Offset = "0x75D6270", VA = "0x1875D7070")]
	private void KEHFIJJCLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2EE9B20", Offset = "0x2EE8D20", VA = "0x182EE9B20")]
	private static void GCKHLAMGEIG<T>(int ANCLPLNKFCK, T[] OOKFCGMGHJE, int JAICOMOJIGD, [Optional] T DDOFLDDKIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2EE9B70", Offset = "0x2EE8D70", VA = "0x182EE9B70")]
	private static void GCKHLAMGEIG<T>(int ANCLPLNKFCK, NativeArray<T> OOKFCGMGHJE, int JAICOMOJIGD, [Optional] T DDOFLDDKIEL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x75D6610", Offset = "0x75D5810", VA = "0x1875D6610")]
	private void EPJACPOEBIH(IEnumerable<EJDBKGJNICO> GKINDPHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x75D6FA0", Offset = "0x75D61A0", VA = "0x1875D6FA0")]
	private void HOPPLONNBAF(EJDBKGJNICO KMCAAPBDOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x75D7970", Offset = "0x75D6B70", VA = "0x1875D7970")]
	private LCNJEMCAAPG OFKPGPLJGNI(int DOPLHBCCLAH)
	{
		return default(LCNJEMCAAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x75D6A30", Offset = "0x75D5C30", VA = "0x1875D6A30")]
	public void GHABIIBGHIL(float APBIDGEPJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x75D5860", Offset = "0x75D4A60", VA = "0x1875D5860")]
	private void AHFDEAIIKHH(Action APIBENHOAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x75D69B0", Offset = "0x75D5BB0", VA = "0x1875D69B0")]
	private void FFMEOEOPHFN(Action APIBENHOAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x75D58E0", Offset = "0x75D4AE0", VA = "0x1875D58E0")]
	public void ALIGLOOBLJI(float APBIDGEPJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x75D76F0", Offset = "0x75D68F0", VA = "0x1875D76F0")]
	public void OAFCGGBDEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x75D6C30", Offset = "0x75D5E30", VA = "0x1875D6C30")]
	public void HKNKENJBLKF(KFNPAGMABGO CGGDJIPNBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x75D64E0", Offset = "0x75D56E0", VA = "0x1875D64E0")]
	public void ELBCOKCOMBF(KFNPAGMABGO CGGDJIPNBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x75D73E0", Offset = "0x75D65E0", VA = "0x1875D73E0")]
	public void MLGBCHOLJAL(KFNPAGMABGO CGGDJIPNBAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class NDIGNGPBJEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly NDIGNGPBJEH NPJAAMJGCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly Action NBNNJMECLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool JBMLAGGIALE;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public NDIGNGPBJEH(Action NBNNJMECLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D45C50", Offset = "0x6D44E50", VA = "0x186D45C50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface OJOIKKNABJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T GOGBANOMEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable CBNIKEKMGCF(UnityEngine.Object GFIAFOEJCDD, Action<T> DIPKGDCLCNO);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface EIODJBPDIFN<T> : OJOIKKNABJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	new T GOGBANOMEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class PEJLGCJMLPP<T> : EIODJBPDIFN<T>, OJOIKKNABJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class HKECCPEHCGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public PEJLGCJMLPP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public OPFNFBLNGLF<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public HKECCPEHCGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x403DC00", Offset = "0x403CE00", VA = "0x18403DC00")]
		internal void MIPDNFBHHEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static GameObject OOHHLGFILPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly List<OPFNFBLNGLF<UnityEngine.Object, Action<T>>> JOEDADKBANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private T JGPNGCOEGCJ;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public T GOGBANOMEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4A88260", Offset = "0x4A87460", VA = "0x184A88260", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4A881A0", Offset = "0x4A873A0", VA = "0x184A881A0")]
	private static bool HEKLPOFKFDE(T APIBENHOAOO, T EGCFJOLCAMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4A883B0", Offset = "0x4A875B0", VA = "0x184A883B0")]
	public PEJLGCJMLPP(T GOBJOPBLPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4A877B0", Offset = "0x4A869B0", VA = "0x184A877B0", Slot = "6")]
	public IDisposable CBNIKEKMGCF(UnityEngine.Object GFIAFOEJCDD, Action<T> DIPKGDCLCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4A87E40", Offset = "0x4A87040", VA = "0x184A87E40")]
	private void FDMNBEIKECF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class NHADBHDPEGM : MCGBNBBMNBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly LMNFIMBPJDA MKEHNCBDCJJ;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x75DB310", Offset = "0x75DA510", VA = "0x1875DB310")]
	[NPIOOMADHDK.JLDADBHPDAA]
	internal static void MFJHJFOIIDC(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	[UnityEngine.Scripting.Preserve]
	internal NHADBHDPEGM([GEFLINBOFNF(null)] LMNFIMBPJDA MKEHNCBDCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x75DB260", Offset = "0x75DA460", VA = "0x1875DB260", Slot = "4")]
	public IDisposable CCLPJEEJKNL(float PAFDFHFLFOJ, Action<float> FKNFKAHALGJ, bool ADEAPBHLPGE = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class OLAMHJKHCCP : JGCIAALNHAB, LMNFIMBPJDA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private LAOCFEAMEMG[] LODJNBDBHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private CKOHBDOJPFO BEMBMIABCGL;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x75DBC90", Offset = "0x75DAE90", VA = "0x1875DBC90")]
	[NPIOOMADHDK.JLDADBHPDAA]
	internal static void NLJAFONFJGA(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x75DBFE0", Offset = "0x75DB1E0", VA = "0x1875DBFE0")]
	[UnityEngine.Scripting.Preserve]
	public OLAMHJKHCCP([GEFLINBOFNF(null)] OFFFFKCLOAC PHNPKPKIIFO, [GEFLINBOFNF(null)] DEMOGDMKMNA BFMLPDJIFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x75DB670", Offset = "0x75DA870", VA = "0x1875DB670", Slot = "18")]
	public override GMLIOGMHHKE EDEAJDEILGD(FDAOEAPNMNA GFIAFOEJCDD, IEnumerator<CKLDDHMAHNL> LPKEOMBJJPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x75DB380", Offset = "0x75DA580", VA = "0x1875DB380", Slot = "19")]
	public override void AKMCCPCKADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x75DBA60", Offset = "0x75DAC60", VA = "0x1875DBA60", Slot = "21")]
	public override void NDLJAFGHMBP(BHKJBMCGABE MABOMBCPBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x75DB7D0", Offset = "0x75DA9D0", VA = "0x1875DB7D0", Slot = "20")]
	protected override void GEGAIMNPNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x75DB7A0", Offset = "0x75DA9A0", VA = "0x1875DB7A0")]
	private LAOCFEAMEMG FJNLPGOJOPJ(BHKJBMCGABE EIHDAHDDDEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x75DBD00", Offset = "0x75DAF00", VA = "0x1875DBD00", Slot = "22")]
	internal override MJFCDHOCKKL NPCFHGPFDPC(IEnumerator<CKLDDHMAHNL> LPKEOMBJJPJ, Behaviour GFIAFOEJCDD, ILEKALKKIAJ HCIFBHNBDMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x75DBF20", Offset = "0x75DB120", VA = "0x1875DBF20", Slot = "23")]
	internal override JJPGEPEDHFI PJOLBJCECHC(BHKJBMCGABE AFOHGMJOEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x75DB940", Offset = "0x75DAB40", VA = "0x1875DB940")]
	private void JLAAFCHKHGK(LAOCFEAMEMG CJAPEONCKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x75DB610", Offset = "0x75DA810", VA = "0x1875DB610", Slot = "24")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct BCGIIGFMGGL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public float LPIGFJPEPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	public int PKAIMACILMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> BHJOIFFLEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> HHDGMKBJHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> PKLEAOCIDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<LFIKGPHDDLC> DGACDEIDHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	public NativeArray<float> KCIMOHCAGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> OHPCMFLAJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[WriteOnly]
	public NativeArray<int> MFIEIMNODBK;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x75C3AD0", Offset = "0x75C2CD0", VA = "0x1875C3AD0")]
	public static BCGIIGFMGGL LGJIMIKIEOH(int PGOGDFCLJGE, float APBIDGEPJOJ, NativeArray<LFIKGPHDDLC> EIPOAEAJALC, NativeArray<float> FMJBGDJPGIO, NativeArray<int> NDHPOBMEKFJ, NativeArray<int> BPPNOAFANME, NativeArray<int> PDHODPEEPAN, NativeArray<int> HHDGMKBJHGA, NativeArray<int> PKLEAOCIDMB)
	{
		return default(BCGIIGFMGGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x75C3880", Offset = "0x75C2A80", VA = "0x1875C3880", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x75C3D70", Offset = "0x75C2F70", VA = "0x1875C3D70")]
	private bool MPBFMPOFGEA(int KINMHNEMPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x75C3850", Offset = "0x75C2A50", VA = "0x1875C3850")]
	private void DPPLPDCODLH(NativeArray<int> GBOPNMLEACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x75C3A30", Offset = "0x75C2C30", VA = "0x1875C3A30")]
	private int GOECCEKCPGH(int KMGGGAONNDP, int EHFBDHIMMFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x75C3960", Offset = "0x75C2B60", VA = "0x1875C3960")]
	private void FCMHBHMMCMP(NativeArray<int> GBOPNMLEACH, int LIKDEIBCDMA, int KHFLFLECNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x75C3B30", Offset = "0x75C2D30", VA = "0x1875C3B30")]
	private void LPHJLNLJBFF(NativeArray<int> GBOPNMLEACH, int ALLKELPALCE, int NCDFOILDLMH, int KNAOKFFAJLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class JGCIAALNHAB : LMNFIMBPJDA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly OFFFFKCLOAC PHNPKPKIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected readonly DEMOGDMKMNA BFMLPDJIFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private JJPGEPEDHFI[] LIGJGPNAALE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static LMNFIMBPJDA FAKOKDPOOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x75D13D0", Offset = "0x75D05D0", VA = "0x1875D13D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static bool LDONACDLNEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public BHKJBMCGABE MDFLHCEDMMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BHKJBMCGABE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DEMOGDMKMNA MGOBKFHDJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public CKLDDHMAHNL IMENKKMNEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CKLDDHMAHNL AFFLALIOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8942E0", Offset = "0x8934E0", VA = "0x1808942E0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public CKLDDHMAHNL BKBBHBFMOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x894340", Offset = "0x893540", VA = "0x180894340", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x75D1FE0", Offset = "0x75D11E0", VA = "0x1875D1FE0")]
	public static GMLIOGMHHKE NLJIANNIACA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x75D20F0", Offset = "0x75D12F0", VA = "0x1875D20F0")]
	[UnityEngine.Scripting.Preserve]
	protected JGCIAALNHAB([GEFLINBOFNF(null)] OFFFFKCLOAC PHNPKPKIIFO, [GEFLINBOFNF(null)] DEMOGDMKMNA BFMLPDJIFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x75D1C90", Offset = "0x75D0E90", VA = "0x1875D1C90", Slot = "6")]
	public GMLIOGMHHKE JJJKKJJOEON(IEnumerator<CKLDDHMAHNL> LPKEOMBJJPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x75D1CA0", Offset = "0x75D0EA0", VA = "0x1875D1CA0", Slot = "7")]
	public GMLIOGMHHKE JJJKKJJOEON(Behaviour GFIAFOEJCDD, IEnumerator<CKLDDHMAHNL> LPKEOMBJJPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract GMLIOGMHHKE EDEAJDEILGD(FDAOEAPNMNA GFIAFOEJCDD, IEnumerator<CKLDDHMAHNL> LPKEOMBJJPJ);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x75D1190", Offset = "0x75D0390", VA = "0x1875D1190", Slot = "19")]
	public virtual void AKMCCPCKADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x75D1840", Offset = "0x75D0A40", VA = "0x1875D1840", Slot = "9")]
	public void EGGEFKAMFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x75D1A80", Offset = "0x75D0C80", VA = "0x1875D1A80", Slot = "20")]
	protected virtual void GEGAIMNPNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x75D1AA0", Offset = "0x75D0CA0", VA = "0x1875D1AA0")]
	private void GGECMGGMELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x75D1440", Offset = "0x75D0640", VA = "0x1875D1440")]
	private void DNPEBFIKJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x75D1820", Offset = "0x75D0A20", VA = "0x1875D1820")]
	private void EEOMNLBNFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x75D20D0", Offset = "0x75D12D0", VA = "0x1875D20D0")]
	private void PJMIEHIDMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x75D1330", Offset = "0x75D0530", VA = "0x1875D1330")]
	private void ALBFNDHAINE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x75D13B0", Offset = "0x75D05B0", VA = "0x1875D13B0")]
	private void BLJBCODPHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x75D1F30", Offset = "0x75D1130", VA = "0x1875D1F30")]
	private void MLAKFDGPIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x75D1F50", Offset = "0x75D1150", VA = "0x1875D1F50", Slot = "21")]
	public virtual void NDLJAFGHMBP(BHKJBMCGABE MABOMBCPBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x75D1AC0", Offset = "0x75D0CC0", VA = "0x1875D1AC0")]
	private void GJOOHGIOJBH(JJPGEPEDHFI CJAPEONCKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x20FB4E0", Offset = "0x20FA6E0", VA = "0x1820FB4E0")]
	private JJPGEPEDHFI LDFFODHHEIF(BHKJBMCGABE EIHDAHDDDEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract MJFCDHOCKKL NPCFHGPFDPC(IEnumerator<CKLDDHMAHNL> LPKEOMBJJPJ, Behaviour DANPBMMGEMC, ILEKALKKIAJ BECDKCGCMKM);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract JJPGEPEDHFI PJOLBJCECHC(BHKJBMCGABE MABOMBCPBNL);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x75D1460", Offset = "0x75D0660", VA = "0x1875D1460", Slot = "24")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x75D1350", Offset = "0x75D0550", VA = "0x1875D1350", Slot = "14")]
	public CKLDDHMAHNL BCPMNEGPPHA(BHKJBMCGABE AFOHGMJOEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x75D1EA0", Offset = "0x75D10A0", VA = "0x1875D1EA0", Slot = "15")]
	public CKLDDHMAHNL JKKCAPDIAED(float NPIKCMPEMNK, BHKJBMCGABE AFOHGMJOEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x75D2070", Offset = "0x75D1270", VA = "0x1875D2070", Slot = "16")]
	public CKLDDHMAHNL OLHMKIDCIGH(Func<bool> MLDFEJJHIJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class MJFCDHOCKKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly ILEKALKKIAJ HCIFBHNBDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly AJFKBFJKLIN GFIAFOEJCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool FNGJHFCNGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private string EPPPGDEIJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private StackTrace MJCMIAEKGAK;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<CKLDDHMAHNL> PHNPOOJBCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public CKLDDHMAHNL BLALMDFDKDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool FBJHNHKGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x75D9DE0", Offset = "0x75D8FE0", VA = "0x1875D9DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool PBFOAFBGBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xB32560", Offset = "0xB31760", VA = "0x180B32560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xCC3AB0", Offset = "0xCC2CB0", VA = "0x180CC3AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string HPIOEFIINLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x75D9850", Offset = "0x75D8A50", VA = "0x1875D9850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float JLBOGGMNIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xB32520", Offset = "0xB31720", VA = "0x180B32520")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x61CEA00", Offset = "0x61CDC00", VA = "0x1861CEA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x75D9F40", Offset = "0x75D9140", VA = "0x1875D9F40")]
	public MJFCDHOCKKL(IEnumerator<CKLDDHMAHNL> JBDKBKBLOGB, AJFKBFJKLIN GFIAFOEJCDD, ILEKALKKIAJ HCIFBHNBDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x75D9AC0", Offset = "0x75D8CC0", VA = "0x1875D9AC0")]
	public CKLDDHMAHNL KJJKECMPDDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x75D9A00", Offset = "0x75D8C00", VA = "0x1875D9A00")]
	public bool GOHDJCAOOBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x75D9A70", Offset = "0x75D8C70", VA = "0x1875D9A70")]
	public void HKNKENJBLKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x75D9E60", Offset = "0x75D9060", VA = "0x1875D9E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xD2A120", Offset = "0xD29320", VA = "0x180D2A120")]
	[CompilerGenerated]
	private void JNICEPPOCDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class ILEKALKKIAJ : KIHNKMONKNK, GMLIOGMHHKE, FKNJNNPDPCK, KAHDNIHNJDF, IEnumerator, CKLDDHMAHNL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private BHKJBMCGABE BKEDPADABMA;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private BHKJBMCGABE KLLPDDFEMHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA213E0", Offset = "0xA205E0", VA = "0x180A213E0", Slot = "23")]
		get
		{
			return default(BHKJBMCGABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BHKJBMCGABE CICELMINIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA21B40", Offset = "0xA20D40", VA = "0x180A21B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float EGDCGOOEJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9C3040", Offset = "0x9C2240", VA = "0x1809C3040", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool BDEHHEKAJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x75D0D00", Offset = "0x75CFF00", VA = "0x1875D0D00", Slot = "24")]
	private bool PJEDNONCHKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x75D0CF0", Offset = "0x75CFEF0", VA = "0x1875D0CF0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x75D0D20", Offset = "0x75CFF20", VA = "0x1875D0D20")]
	public ILEKALKKIAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum LCNJEMCAAPG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class JJPGEPEDHFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum FNKFOELOMIF
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct MFBGJGCHHIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public BHKJBMCGABE HIPCAFJNGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public FNKFOELOMIF FIDCNMALAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public List<MJFCDHOCKKL> LABOKFKJGMF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly FNKFOELOMIF[] FJLMBKFMLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly BHKJBMCGABE MABOMBCPBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool FKEPKGLGIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly MJFCDHOCKKL[] KFHJFGHIBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<MJFCDHOCKKL> DHIIPOFHLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<int> PAFKJKBLPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<MJFCDHOCKKL> FKPLCPCJIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> PMAHPEDAENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly CKOHBDOJPFO CEAFHMLBBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private bool LAIPMKBCIGG;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public MFBGJGCHHIN[,] MLDIADNBHAO
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x894340", Offset = "0x893540", VA = "0x180894340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x75D3AA0", Offset = "0x75D2CA0", VA = "0x1875D3AA0")]
	public JJPGEPEDHFI(BHKJBMCGABE AFOHGMJOEPH, CKOHBDOJPFO CEAFHMLBBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x75D3100", Offset = "0x75D2300", VA = "0x1875D3100")]
	public void NBJCCFKEMCL(MJFCDHOCKKL JBDKBKBLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x75D2E10", Offset = "0x75D2010", VA = "0x1875D2E10")]
	public void LBMGNOLJALL(IList<MJFCDHOCKKL> BFPLPFJFEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x75D3200", Offset = "0x75D2400", VA = "0x1875D3200")]
	public void NIOEHHDJJJJ(IList<MJFCDHOCKKL> BFPLPFJFEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x75D2700", Offset = "0x75D1900", VA = "0x1875D2700")]
	private void ECKHMELLHBO(MJFCDHOCKKL JBDKBKBLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x75D2B50", Offset = "0x75D1D50", VA = "0x1875D2B50")]
	private void HDLPOMEDBID(IList<MJFCDHOCKKL> BFPLPFJFEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x75D37F0", Offset = "0x75D29F0", VA = "0x1875D37F0")]
	private LCNJEMCAAPG POCNDALBDNP(MJFCDHOCKKL JBDKBKBLOGB)
	{
		return default(LCNJEMCAAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x75D29E0", Offset = "0x75D1BE0", VA = "0x1875D29E0")]
	public void GEGAIMNPNFH(float APBIDGEPJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x75D27F0", Offset = "0x75D19F0", VA = "0x1875D27F0")]
	public void EGGEFKAMFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x75D34F0", Offset = "0x75D26F0", VA = "0x1875D34F0")]
	private void OEJBIOIFGHI(List<MJFCDHOCKKL> BFPLPFJFEIL, Stack<int> DOAEICDMHHG, bool ADAJIBHOKNO, float HAOJCKJPAAN = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x75D25E0", Offset = "0x75D17E0", VA = "0x1875D25E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x75D2CD0", Offset = "0x75D1ED0", VA = "0x1875D2CD0")]
	private void IPDNEMHOLFC(List<MJFCDHOCKKL> BFPLPFJFEIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class NIHJAFOIJOC : CKOHBDOJPFO
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "4")]
	public void MADIFKCGCAA(string EPPPGDEIJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
	public void INAPKLLOCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public NIHJAFOIJOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class PELDKADGGAJ : AJFKBFJKLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly Behaviour DANPBMMGEMC;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string HPIOEFIINLC
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x75DD2D0", Offset = "0x75DC4D0", VA = "0x1875DD2D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GAJGBHCNAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x75DD370", Offset = "0x75DC570", VA = "0x1875DD370", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GAOLDGFKNMO
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x75DD350", Offset = "0x75DC550", VA = "0x1875DD350", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public PELDKADGGAJ(Behaviour DANPBMMGEMC)
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

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
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7923400", Offset = "0x7921C00", VA = "0x187923400", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x792BEC0", Offset = "0x792A6C0", VA = "0x18792BEC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
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
		private delegate List<PlayerLoopSystem> APNKGAKPGND(List<PlayerLoopSystem> PPPJPEANGHO, int BIBFHOKCOHN);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct NDFOJBIPHFG
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct DNMPKPOAELD
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static GCOJJNPJFGN GJMKHLCBFGC;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x7917310", Offset = "0x7915B10", VA = "0x187917310")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct CEACMCADHHA
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static GCOJJNPJFGN GOCHILFDFAN;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x7910290", Offset = "0x790EA90", VA = "0x187910290")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct HFEKKBEOKNJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static GCOJJNPJFGN GHGNAMNFJKG;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x791B3A0", Offset = "0x7919BA0", VA = "0x18791B3A0")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct FPBOHFMKDHO
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static GCOJJNPJFGN CHKIFCMPOEO;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static GCOJJNPJFGN IAEPALKAJBC;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static GCOJJNPJFGN DBGKKFEKMHL;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static GCOJJNPJFGN EKPHFEAHEPC;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x7919D00", Offset = "0x7918500", VA = "0x187919D00")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct OGODOBIGMEM
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static GCOJJNPJFGN OAJICAKGDPJ;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x7927B00", Offset = "0x7926300", VA = "0x187927B00")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct NEPHJHKFLIB
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static GCOJJNPJFGN CHKIFCMPOEO;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static GCOJJNPJFGN IAEPALKAJBC;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static GCOJJNPJFGN DBGKKFEKMHL;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static GCOJJNPJFGN EKPHFEAHEPC;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x79268C0", Offset = "0x79250C0", VA = "0x1879268C0")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct DDLHNGDPNMC
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static GCOJJNPJFGN PMGLKJHINAG;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x7915140", Offset = "0x7913940", VA = "0x187915140")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct JDPBPBLAMKK
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static GCOJJNPJFGN JBLGHNILGEG;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7920270", Offset = "0x791EA70", VA = "0x187920270")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct CBPKEPINKBO
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static GCOJJNPJFGN JKKFALFMCLL;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x790FD20", Offset = "0x790E520", VA = "0x18790FD20")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct KIJCNHBLCPO
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static GCOJJNPJFGN JLBCMCHNFBB;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x7921320", Offset = "0x791FB20", VA = "0x187921320")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct KFIIILMLIOE
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static GCOJJNPJFGN JDFOPADIFCL;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x7920690", Offset = "0x791EE90", VA = "0x187920690")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct IBPCOIDJGEB
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static GCOJJNPJFGN ONHBPAPMHIK;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x791B800", Offset = "0x791A000", VA = "0x18791B800")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct PNFPAHNKKJC
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static GCOJJNPJFGN HLIFCBDPKLP;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x792AA70", Offset = "0x7929270", VA = "0x18792AA70")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct INCNLDNCJPE
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static GCOJJNPJFGN BOKMDOGMMLO;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x791F060", Offset = "0x791D860", VA = "0x18791F060")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct HFCLIDJEIIP
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static GCOJJNPJFGN NDOFCHKCHHH;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x791B1A0", Offset = "0x79199A0", VA = "0x18791B1A0")]
				public static PlayerLoopSystem BOIMAFDKAND()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum MNALOHKPNPL : byte
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
			public struct NJPPJDNEALM
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class CALJMPPMANN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public MNALOHKPNPL updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
					public CALJMPPMANN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x790FC60", Offset = "0x790E460", VA = "0x18790FC60")]
					internal void IPEJCOGDCAI()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static ANHAMBLCGDC<MNALOHKPNPL> GLBJCNMAKIP;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x79277D0", Offset = "0x7925FD0", VA = "0x1879277D0")]
				public static PlayerLoopSystem BOIMAFDKAND(MNALOHKPNPL PGKMIDDCKPG)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct BHDJCKFMCFK
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class JACFMILHNJO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public FCOAMJPBNHI.EEGBOJEPEGD key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
					public JACFMILHNJO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x791F6A0", Offset = "0x791DEA0", VA = "0x18791F6A0")]
					internal void PCICKJIBOPO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable LCLNMJGFMBN;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x790F750", Offset = "0x790DF50", VA = "0x18790F750")]
				public static PlayerLoopSystem ENCOBAPNBMD(FCOAMJPBNHI.EEGBOJEPEGD KCGKBDGKIOP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct IAKFFKHDFOP
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class CDNAMNIAPGF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public FCOAMJPBNHI.EEGBOJEPEGD key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
					public CDNAMNIAPGF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x7910010", Offset = "0x790E810", VA = "0x187910010")]
					internal void PCICKJIBOPO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x791B6D0", Offset = "0x7919ED0", VA = "0x18791B6D0")]
				public static PlayerLoopSystem ENCOBAPNBMD(FCOAMJPBNHI.EEGBOJEPEGD KCGKBDGKIOP)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class OOGJGPCGEHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public OOGJGPCGEHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7928770", Offset = "0x7926F70", VA = "0x187928770")]
			internal List<PlayerLoopSystem> GFNEKPIBFFI(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool GAMBJHBFELP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool BAEBHPGKPAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x79147E0", Offset = "0x7912FE0", VA = "0x1879147E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7911720", Offset = "0x790FF20", VA = "0x187911720")]
		private static void DHBLJCMPHGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7910E10", Offset = "0x790F610", VA = "0x187910E10")]
		private static void BPCIBHNPFEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7910DD0", Offset = "0x790F5D0", VA = "0x187910DD0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7914950", Offset = "0x7913150", VA = "0x187914950")]
		private static void IMEMIDBFKAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7914BA0", Offset = "0x79133A0", VA = "0x187914BA0")]
		private static void MJEPBLHANOK(FCOAMJPBNHI.EEGBOJEPEGD KCGKBDGKIOP, PlayerLoopSystem JDCJNCHMMME, Type EHIJAOFLNKO, Type LNHGJMHLCNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7914D60", Offset = "0x7913560", VA = "0x187914D60")]
		private static void OKFLJBJCGNC(PlayerLoopSystem JDCJNCHMMME, Type EHIJAOFLNKO, Type LNHGJMHLCNF, APNKGAKPGND ENKBHNMKPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7914820", Offset = "0x7913020", VA = "0x187914820")]
		private static void FJGHGPMPDBA(PlayerLoopSystem JDCJNCHMMME, Type EHIJAOFLNKO, Type LNHGJMHLCNF, PlayerLoopSystem? EHPMINNJMCH, PlayerLoopSystem? HMFEBEJPFKG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FCOAMJPBNHI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum EEGBOJEPEGD
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
	public class IPDEHHBDNPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly EEGBOJEPEGD HCEGBFHOPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly PAKPELCGCAK FICNHGFNNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long FLGLNLOCOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long MNNDKNFIKON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long GHEMNHGCDDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int BGAMJDOJCHJ;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x791F530", Offset = "0x791DD30", VA = "0x18791F530")]
		public IPDEHHBDNPD(EEGBOJEPEGD IMEJDHBJPLO, int PJBHPMJKKDP = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x791F260", Offset = "0x791DA60", VA = "0x18791F260")]
		public void EOPAMDBIJHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x791F2E0", Offset = "0x791DAE0", VA = "0x18791F2E0")]
		public void GLKOGHHDMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x791F330", Offset = "0x791DB30", VA = "0x18791F330")]
		public void OPBGNJFDOFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static EEGBOJEPEGD[] EBJHOCBCBGI;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static IPDEHHBDNPD[] BMLACBKOEFH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x79183C0", Offset = "0x7916BC0", VA = "0x1879183C0")]
	public static IPDEHHBDNPD INAINGMCMJC(EEGBOJEPEGD KCGKBDGKIOP, int PJBHPMJKKDP = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7918350", Offset = "0x7916B50", VA = "0x187918350")]
	public static IPDEHHBDNPD AAGLEEIGJPB(EEGBOJEPEGD KCGKBDGKIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x79185A0", Offset = "0x7916DA0", VA = "0x1879185A0")]
	public static void KMODLHNAIJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class PAKPELCGCAK : NDDPKFPCCGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int IDCEEKNGJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Queue<double> CJEJJGCDDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double GMIGPGIEBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double KMLOFEFLFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double KGDHDJDPLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int PKJAJNBNFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private double EJILCHCMEMB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NNHPPPEBCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8D4630", Offset = "0x8D2E30", VA = "0x1808D4630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double GHCHOJFKMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7928890", Offset = "0x7927090", VA = "0x187928890", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double EFILKKHGDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x59411D0", Offset = "0x593F9D0", VA = "0x1859411D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double KBIBPAPBOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x22BC8A0", Offset = "0x22BB0A0", VA = "0x1822BC8A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7928A90", Offset = "0x7927290", VA = "0x187928A90")]
	public PAKPELCGCAK(int LBMLCEOBHJF, double EJILCHCMEMB = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7928960", Offset = "0x7927160", VA = "0x187928960", Slot = "7")]
	public void OKFEDNGNCFI(double DBIIPNGMHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x79288F0", Offset = "0x79270F0", VA = "0x1879288F0", Slot = "8")]
	public void FGGFCKBCIEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class OFFFKIKKFPC : NDDPKFPCCGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private long NELOIEKKMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private double AGILPDJDCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private double OKJPDHILIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private double NHGIIELEOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private double LPCBHAIOJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private double GMIGPGIEBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private double KMLOFEFLFLC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double EFILKKHGDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6446640", Offset = "0x6444E40", VA = "0x186446640", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double KBIBPAPBOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9A4980", Offset = "0x9A3180", VA = "0x1809A4980", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double NDCJHJIELPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6446AE0", Offset = "0x64452E0", VA = "0x186446AE0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double GHCHOJFKMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2935300", Offset = "0x2933B00", VA = "0x182935300", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x79279E0", Offset = "0x79261E0", VA = "0x1879279E0", Slot = "7")]
	public virtual void OKFEDNGNCFI(double DBIIPNGMHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x79279A0", Offset = "0x79261A0", VA = "0x1879279A0", Slot = "8")]
	public virtual void FGGFCKBCIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x791A230", Offset = "0x7918A30", VA = "0x18791A230")]
	public OFFFKIKKFPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class GMOGGECDKLF : OFFFKIKKFPC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double BHIPIGKKJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6446AD0", Offset = "0x64452D0", VA = "0x186446AD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6446B00", Offset = "0x6445300", VA = "0x186446B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x791A100", Offset = "0x7918900", VA = "0x18791A100", Slot = "7")]
	public override void OKFEDNGNCFI(double DBIIPNGMHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x791A0C0", Offset = "0x79188C0", VA = "0x18791A0C0", Slot = "8")]
	public override void FGGFCKBCIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x791A230", Offset = "0x7918A30", VA = "0x18791A230")]
	public GMOGGECDKLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface NDDPKFPCCGB
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double GHCHOJFKMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double EFILKKHGDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double KBIBPAPBOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LDEIBKLMBMM
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private interface EHBJAFOBBCP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool COOECDNOJDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DCGPOMMMBND();
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class MDCABNFDLEC : EHBJAFOBBCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly Action ILIPDNLABEN;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool COOECDNOJDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
		public MDCABNFDLEC(Action ILIPDNLABEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCE24A0", Offset = "0xCE0CA0", VA = "0x180CE24A0", Slot = "5")]
		public void DCGPOMMMBND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly List<EHBJAFOBBCP> LONJOPPMOEN;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x79226F0", Offset = "0x7920EF0", VA = "0x1879226F0")]
	public static void DAHLGJKHKNP(Action ILIPDNLABEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7922790", Offset = "0x7920F90", VA = "0x187922790")]
	private static void GGHDNBFJNEK(EHBJAFOBBCP NBOEOGBHOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x79229B0", Offset = "0x79211B0", VA = "0x1879229B0")]
	private static void GIBBILKBGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7922D90", Offset = "0x7921590", VA = "0x187922D90")]
	private static void NJOCCKNJJKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7922CB0", Offset = "0x79214B0", VA = "0x187922CB0")]
	private static void HFOGIJLGMAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class MBIKOHMNGNO
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private struct BEMIIPJBOPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public TaskCompletionSource<Scene> OBLKLADHHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly string AINIGHKDABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly LoadSceneMode BJLOLDNPIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly bool DLOFGKJHJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x790E960", Offset = "0x790D160", VA = "0x18790E960")]
		public BEMIIPJBOPG(TaskCompletionSource<Scene> PIEKLBNIMOE, string AINIGHKDABB, LoadSceneMode BJLOLDNPIEC, bool DLOFGKJHJCJ, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct KLLDECLKIOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NGPFCPLNCNC<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7921520", Offset = "0x791FD20", VA = "0x187921520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7921DC0", Offset = "0x79205C0", VA = "0x187921DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct GOCPLHADFDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x791A260", Offset = "0x7918A60", VA = "0x18791A260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x791A580", Offset = "0x7918D80", VA = "0x18791A580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct EGIBHFCDFIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private BEMIIPJBOPG <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7917590", Offset = "0x7915D90", VA = "0x187917590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7917950", Offset = "0x7916150", VA = "0x187917950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class OMLBCGDBCDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public DGNOFHEJJPD<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OMLBCGDBCDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7927D00", Offset = "0x7926500", VA = "0x187927D00")]
		internal void KAOPCGOHPNH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct NFJFLDNPDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private OMLBCGDBCDN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7926BB0", Offset = "0x79253B0", VA = "0x187926BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7927760", Offset = "0x7925F60", VA = "0x187927760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct KOCBANCDFKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private DGPGECBENMI <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7921FC0", Offset = "0x79207C0", VA = "0x187921FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7922680", Offset = "0x7920E80", VA = "0x187922680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct ICIOBEJBNKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x791BA00", Offset = "0x791A200", VA = "0x18791BA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x791C520", Offset = "0x791AD20", VA = "0x18791C520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class OOFNECEEHAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OOFNECEEHAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7928740", Offset = "0x7926F40", VA = "0x187928740")]
		internal bool IKOJGPJOLCH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class ACMEHJCDGNC : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CGKMABONNJI onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public ACMEHJCDGNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x790DCD0", Offset = "0x790C4D0", VA = "0x18790DCD0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x790D8F0", Offset = "0x790C0F0", VA = "0x18790D8F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x790DC30", Offset = "0x790C430", VA = "0x18790DC30")]
		private void PPNAIGJNIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x790DC80", Offset = "0x790C480", VA = "0x18790DC80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class LIPODMIKPCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public DGNOFHEJJPD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public LIPODMIKPCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7922F20", Offset = "0x7921720", VA = "0x187922F20")]
		internal bool LGOBNGFHGLK(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7922FA0", Offset = "0x79217A0", VA = "0x187922FA0")]
		internal void ODEJLDLLDKB(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class ONPNBJDOENK : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public DGNOFHEJJPD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private LIPODMIKPCB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private DGPGECBENMI <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public ONPNBJDOENK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x79286E0", Offset = "0x7926EE0", VA = "0x1879286E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7927D60", Offset = "0x7926560", VA = "0x187927D60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7928670", Offset = "0x7926E70", VA = "0x187928670")]
		private void PPNAIGJNIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7928690", Offset = "0x7926E90", VA = "0x187928690", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly ICollection<string> NKCPDLHMPHJ;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static MOPOHKAGKCI LMALLEBBHBI;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static AsyncOperation AKMGLLCIHDK;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static MOPOHKAGKCI PHCCKOCCCHA;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static string DCGOGNAEBOC;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static string EHJPJADHMDC;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static ThreadPriority DGJFPAELBFF;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static Task DCPPONIHIKN;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static List<SceneInstance> CFHGLDHECDN;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly Queue<BEMIIPJBOPG> DCMDEGLBFEE;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static Task BHIHDKCAHPP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static bool FKMLNAHBJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7923C80", Offset = "0x7922480", VA = "0x187923C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private static bool CIMPCPCBPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7923AC0", Offset = "0x79222C0", VA = "0x187923AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool PMAAFCPLMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7923830", Offset = "0x7922030", VA = "0x187923830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool LAGICAGICCI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7923BF0", Offset = "0x79223F0", VA = "0x187923BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> IEHEOFDDHPN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7923610", Offset = "0x7921E10", VA = "0x187923610")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7924C60", Offset = "0x7923460", VA = "0x187924C60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7924060", Offset = "0x7922860", VA = "0x187924060")]
	[BCJBDLGJJJB(PPAGEKNPNBG.EnteredEditModeNextFrame, 0)]
	private static void JCPCNALBINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7924290", Offset = "0x7922A90", VA = "0x187924290")]
	[AsyncStateMachine(typeof(KLLDECLKIOF))]
	public static Task<Scene> JKEMCAICLEO(string AINIGHKDABB, LoadSceneMode BJLOLDNPIEC = LoadSceneMode.Single, bool DLOFGKJHJCJ = false, [Optional] NGPFCPLNCNC<string>.PPCAKDHDCLK ALHIHJIONGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7923FB0", Offset = "0x79227B0", VA = "0x187923FB0")]
	[AsyncStateMachine(typeof(GOCPLHADFDD))]
	private static Task GJPPDBNIPNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7924B90", Offset = "0x7923390", VA = "0x187924B90")]
	[AsyncStateMachine(typeof(EGIBHFCDFIK))]
	private static Task PDKNLGHHNAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7923970", Offset = "0x7922170", VA = "0x187923970")]
	[AsyncStateMachine(typeof(NFJFLDNPDAA))]
	private static Task<Scene> DOMDCHBDPNB(string AINIGHKDABB, LoadSceneMode BJLOLDNPIEC, bool DLOFGKJHJCJ, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7923EA0", Offset = "0x79226A0", VA = "0x187923EA0")]
	private static void GGHIMFCJEEE(SceneInstance BJNFKEAALFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x79248D0", Offset = "0x79230D0", VA = "0x1879248D0")]
	private static void LIAOKBKCEBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x79243E0", Offset = "0x7922BE0", VA = "0x1879243E0")]
	[AsyncStateMachine(typeof(KOCBANCDFKG))]
	private static Task<Scene> JOBDHJDPBHD(string AINIGHKDABB, LoadSceneMode BJLOLDNPIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7924510", Offset = "0x7922D10", VA = "0x187924510")]
	private static bool LDGDJNFFNCE(string AINIGHKDABB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7923720", Offset = "0x7921F20", VA = "0x187923720")]
	[AsyncStateMachine(typeof(ICIOBEJBNKL))]
	private static Task<Scene> BOJGPEOKOCA(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7923490", Offset = "0x7921C90", VA = "0x187923490")]
	public static AKLEHMINLPM<Scene> AJBFFIMFOPF(string AINIGHKDABB, LoadSceneMode BJLOLDNPIEC = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7924600", Offset = "0x7922E00", VA = "0x187924600")]
	public static MOPOHKAGKCI LFFANBHHNGL(string AINIGHKDABB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7923B60", Offset = "0x7922360", VA = "0x187923B60")]
	[IteratorStateMachine(typeof(ACMEHJCDGNC))]
	private static IEnumerator<IJKEOMMDACC> EDPPOMJGLHI(string AINIGHKDABB, CGKMABONNJI INANMLFLKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x79238D0", Offset = "0x79220D0", VA = "0x1879238D0")]
	[IteratorStateMachine(typeof(ONPNBJDOENK))]
	private static IEnumerator<IJKEOMMDACC> DKFDBNCDCAB(string AINIGHKDABB, LoadSceneMode BJLOLDNPIEC, DGNOFHEJJPD<Scene> INANMLFLKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7924160", Offset = "0x7922960", VA = "0x187924160")]
	public static bool JFBAGFMJIFD([Out] string HNEPOJGCFLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class KMFDOMBCDMO
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7921F30", Offset = "0x7920730", VA = "0x187921F30")]
	public static IDisposable IGKFIKDLIKJ(this OOOILGHOBHM IKGPEBFFMPK, float GGMPEOGACCK, Action<float> ABCBLJADALH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7921EB0", Offset = "0x79206B0", VA = "0x187921EB0")]
	public static IDisposable HIBDFBFIFNN(this OOOILGHOBHM IKGPEBFFMPK, Action<float> ABCBLJADALH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7921E30", Offset = "0x7920630", VA = "0x187921E30")]
	public static IDisposable CFJFCDLOAKH(this OOOILGHOBHM IKGPEBFFMPK, Action<float> ABCBLJADALH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class LLJCMKOGFBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3113AE0", Offset = "0x31122E0", VA = "0x183113AE0")]
	[MDOKGGJPDLI]
	public static IDisposable DJKDLEICJKD<T>(this T EJOMIDEGKIL, Action ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3113C80", Offset = "0x3112480", VA = "0x183113C80")]
	[MDOKGGJPDLI]
	public static IDisposable DJKDLEICJKD<T>(this T EJOMIDEGKIL, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3114200", Offset = "0x3112A00", VA = "0x183114200")]
	[MDOKGGJPDLI]
	public static IDisposable LHNLPLKLOMD<T>(this T EJOMIDEGKIL, Action ABCBLJADALH, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3113A30", Offset = "0x3112230", VA = "0x183113A30")]
	[MDOKGGJPDLI]
	public static IDisposable CNGLJABOBLM<T>(this T EJOMIDEGKIL, Action ABCBLJADALH, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3113A30", Offset = "0x3112230", VA = "0x183113A30")]
	[MDOKGGJPDLI]
	public static IDisposable CNGLJABOBLM<T>(this T EJOMIDEGKIL, Action<float> ABCBLJADALH, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3113F50", Offset = "0x3112750", VA = "0x183113F50")]
	[MDOKGGJPDLI]
	public static IDisposable GOBLJNCJIBN<T>(this T EJOMIDEGKIL, Action ABCBLJADALH, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3113870", Offset = "0x3112070", VA = "0x183113870")]
	[MDOKGGJPDLI]
	public static IDisposable ACHHHGNEMFP<T>(this T EJOMIDEGKIL, Action ABCBLJADALH, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x31142E0", Offset = "0x3112AE0", VA = "0x1831142E0")]
	[MDOKGGJPDLI]
	public static IDisposable POFJGAOLEOA<T>(this T EJOMIDEGKIL, Action ABCBLJADALH, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3114240", Offset = "0x3112A40", VA = "0x183114240")]
	[MDOKGGJPDLI]
	public static IDisposable LKENMNPPMKL<T>(this T EJOMIDEGKIL, float GGMPEOGACCK, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7923220", Offset = "0x7921A20", VA = "0x187923220")]
	[MDOKGGJPDLI]
	public static IDisposable LKENMNPPMKL(this MonoBehaviour EJOMIDEGKIL, DLKJMFLDODE IKGPEBFFMPK, float GGMPEOGACCK, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3114000", Offset = "0x3112800", VA = "0x183114000")]
	[MDOKGGJPDLI]
	public static IDisposable INJAGMHIMED<T>(this T EJOMIDEGKIL, float GGMPEOGACCK, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x31138C0", Offset = "0x31120C0", VA = "0x1831138C0")]
	[MDOKGGJPDLI]
	public static IDisposable AMOHBFHFLKP<T>(this T EJOMIDEGKIL, float GGMPEOGACCK, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3113E90", Offset = "0x3112690", VA = "0x183113E90")]
	[MDOKGGJPDLI]
	public static IDisposable FOFBEFODDKN<T>(this T EJOMIDEGKIL, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3113E30", Offset = "0x3112630", VA = "0x183113E30")]
	[MDOKGGJPDLI]
	public static IDisposable FABKLDGLLEO<T>(this T EJOMIDEGKIL, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x31139D0", Offset = "0x31121D0", VA = "0x1831139D0")]
	[MDOKGGJPDLI]
	public static IDisposable BIJNHPJNIKA<T>(this T EJOMIDEGKIL, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3113910", Offset = "0x3112110", VA = "0x183113910")]
	[MDOKGGJPDLI]
	public static IDisposable BAMFNFBAMCB<T>(this T EJOMIDEGKIL, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3113970", Offset = "0x3112170", VA = "0x183113970")]
	[MDOKGGJPDLI]
	public static IDisposable BCMHDCPCIHK<T>(this T EJOMIDEGKIL, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3113EF0", Offset = "0x31126F0", VA = "0x183113EF0")]
	[MDOKGGJPDLI]
	public static IDisposable GHNLLOGHGFN<T>(this T EJOMIDEGKIL, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3113A80", Offset = "0x3112280", VA = "0x183113A80")]
	[MDOKGGJPDLI]
	public static IDisposable DCCMJMGDFED<T>(this T EJOMIDEGKIL, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x31141B0", Offset = "0x31129B0", VA = "0x1831141B0")]
	[MDOKGGJPDLI]
	public static IDisposable KODFFHBPAHD<T>(this T EJOMIDEGKIL, float GGMPEOGACCK, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3114280", Offset = "0x3112A80", VA = "0x183114280")]
	[MDOKGGJPDLI]
	public static IDisposable MKFPDIJMLBF<T>(this T EJOMIDEGKIL, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3113FA0", Offset = "0x31127A0", VA = "0x183113FA0")]
	[MDOKGGJPDLI]
	public static IDisposable HHKFKOGDBLG<T>(this T EJOMIDEGKIL, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true) where T : MonoBehaviour, DLKJMFLDODE
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class APMLFHGBKMG
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class HNPDNEIMEPH : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public FCPBOECGDIL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private BOABIFMEPAL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public HNPDNEIMEPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x791B5A0", Offset = "0x7919DA0", VA = "0x18791B5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x791B680", Offset = "0x7919E80", VA = "0x18791B680", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class EMIAOFBDKEE : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public FCPBOECGDIL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private BOABIFMEPAL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public EMIAOFBDKEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7917B70", Offset = "0x7916370", VA = "0x187917B70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7917C60", Offset = "0x7916460", VA = "0x187917C60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x790E6E0", Offset = "0x790CEE0", VA = "0x18790E6E0")]
	public static EBBFPAKHIHA DJKDLEICJKD(Action ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x790E650", Offset = "0x790CE50", VA = "0x18790E650")]
	public static EBBFPAKHIHA DJKDLEICJKD(Behaviour IKGPEBFFMPK, Action ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x790E760", Offset = "0x790CF60", VA = "0x18790E760")]
	public static EBBFPAKHIHA DJKDLEICJKD(Behaviour IKGPEBFFMPK, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x790E8D0", Offset = "0x790D0D0", VA = "0x18790E8D0")]
	[IteratorStateMachine(typeof(HNPDNEIMEPH))]
	private static IEnumerator<IJKEOMMDACC> PNMMLFCAFJI(FCPBOECGDIL LKAJNMAHFJE, Action ABCBLJADALH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x790E840", Offset = "0x790D040", VA = "0x18790E840")]
	[IteratorStateMachine(typeof(EMIAOFBDKEE))]
	private static IEnumerator<IJKEOMMDACC> PNMMLFCAFJI(FCPBOECGDIL LKAJNMAHFJE, Action<float> ABCBLJADALH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class BJGIKFFKMEA : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class INAJNEAEOKD : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public BJGIKFFKMEA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public INAJNEAEOKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x791EF80", Offset = "0x791D780", VA = "0x18791EF80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x791F010", Offset = "0x791D810", VA = "0x18791F010", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly FCPBOECGDIL EFJGAMLEOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Action OOOGDODLAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool PEIMHGCEKEK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool BPMEEIFADIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8B9830", VA = "0x1808BB030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x790FB90", Offset = "0x790E390", VA = "0x18790FB90")]
	public BJGIKFFKMEA(FCPBOECGDIL EFJGAMLEOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x790FA70", Offset = "0x790E270", VA = "0x18790FA70")]
	[IteratorStateMachine(typeof(INAJNEAEOKD))]
	private IEnumerator<IJKEOMMDACC> MPPICPKIBHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x790FAF0", Offset = "0x790E2F0", VA = "0x18790FAF0", Slot = "4")]
	public void OnCompleted(Action OGJDIMIHDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	public void MDDGKHNHAAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class BJABICIOBGI
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x790F960", Offset = "0x790E160", VA = "0x18790F960")]
	public static BJGIKFFKMEA FJJFOJEIFLM(this FCPBOECGDIL EFJGAMLEOMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HEHHBBGOKMB
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class GCFBBMNKLBH : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public NPDMOPPKFAG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public GCFBBMNKLBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7919FF0", Offset = "0x79187F0", VA = "0x187919FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x791A070", Offset = "0x7918870", VA = "0x18791A070", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x791AD60", Offset = "0x7919560", VA = "0x18791AD60")]
	public static EBBFPAKHIHA DJKDLEICJKD(float GGMPEOGACCK, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, bool FEBIADHLPIH = true, [Optional] IFJNPEGGGGL DIDBPBFLOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x791AC90", Offset = "0x7919490", VA = "0x18791AC90")]
	public static EBBFPAKHIHA DJKDLEICJKD(MonoBehaviour EJOMIDEGKIL, float GGMPEOGACCK, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, bool FEBIADHLPIH = true, [Optional] IFJNPEGGGGL DIDBPBFLOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x791AF20", Offset = "0x7919720", VA = "0x18791AF20")]
	public static EBBFPAKHIHA LKEFBABJCLH(MonoBehaviour EJOMIDEGKIL, float GGMPEOGACCK, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, bool FEBIADHLPIH = true, [Optional] IFJNPEGGGGL DIDBPBFLOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x791B0D0", Offset = "0x79198D0", VA = "0x18791B0D0")]
	public static EBBFPAKHIHA PNOIBLEOLBK(OOOILGHOBHM IKGPEBFFMPK, float GGMPEOGACCK, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, bool FEBIADHLPIH = true, [Optional] IFJNPEGGGGL DIDBPBFLOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x791B010", Offset = "0x7919810", VA = "0x18791B010")]
	private static IEnumerator<IJKEOMMDACC> PNMMLFCAFJI(DNFJCKJDFHL EKKCFOIAMPJ, float GGMPEOGACCK, FCPBOECGDIL LKAJNMAHFJE, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x791AE30", Offset = "0x7919630", VA = "0x18791AE30")]
	private static IEnumerator<IJKEOMMDACC> DPNBNGFLLKG(DNFJCKJDFHL EKKCFOIAMPJ, float GGMPEOGACCK, FCPBOECGDIL LKAJNMAHFJE, Action<float> ABCBLJADALH, bool FEBIADHLPIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x791AE90", Offset = "0x7919690", VA = "0x18791AE90")]
	[IteratorStateMachine(typeof(GCFBBMNKLBH))]
	private static IEnumerator<IJKEOMMDACC> JAMPMKKKPDE(NPDMOPPKFAG HBEOBKGNPLE, float GGMPEOGACCK, FCPBOECGDIL LKAJNMAHFJE, Action<float> ABCBLJADALH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class CFOOHLBOJEB
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class DGPAMMLAFDK : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public FCPBOECGDIL queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public DGPAMMLAFDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7915850", Offset = "0x7914050", VA = "0x187915850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7915910", Offset = "0x7914110", VA = "0x187915910", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7910490", Offset = "0x790EC90", VA = "0x187910490")]
	[IteratorStateMachine(typeof(DGPAMMLAFDK))]
	private static IEnumerator<IJKEOMMDACC> DBMKGOBDPBE(FCPBOECGDIL EFJGAMLEOMN, Func<bool> JDBPPNFCIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7910520", Offset = "0x790ED20", VA = "0x187910520")]
	public static EBBFPAKHIHA HIJGGJOLHCN(this MonoBehaviour EJOMIDEGKIL, Func<bool> JDBPPNFCIBD, FCPBOECGDIL EFJGAMLEOMN = FCPBOECGDIL.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class KGFDIDAEFGI
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class KIEFFBPHIDH : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public FCPBOECGDIL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public KIEFFBPHIDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7921260", Offset = "0x791FA60", VA = "0x187921260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x79212D0", Offset = "0x791FAD0", VA = "0x1879212D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CDIJCPECIBM<T> : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public FCPBOECGDIL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public CDIJCPECIBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x583E0A0", Offset = "0x583C8A0", VA = "0x18583E0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x583E140", Offset = "0x583C940", VA = "0x18583E140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class BIPGGDECOEJ : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public FCPBOECGDIL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private IJKEOMMDACC <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public BIPGGDECOEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x790F880", Offset = "0x790E080", VA = "0x18790F880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x790F910", Offset = "0x790E110", VA = "0x18790F910", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7920FE0", Offset = "0x791F7E0", VA = "0x187920FE0")]
	[IteratorStateMachine(typeof(KIEFFBPHIDH))]
	private static IEnumerator<IJKEOMMDACC> MPPICPKIBHE(float CKHMGDGNNBB, FCPBOECGDIL LKAJNMAHFJE, Action GOODBCHHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x30E7010", Offset = "0x30E5810", VA = "0x1830E7010")]
	[IteratorStateMachine(typeof(CDIJCPECIBM<>))]
	private static IEnumerator<IJKEOMMDACC> MPPICPKIBHE<T>(float CKHMGDGNNBB, FCPBOECGDIL LKAJNMAHFJE, Action<T> GOODBCHHJFH, T HBIPIPALDEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7920A70", Offset = "0x791F270", VA = "0x187920A70")]
	[IteratorStateMachine(typeof(BIPGGDECOEJ))]
	private static IEnumerator<IJKEOMMDACC> EKMCHBDGPHI(float CKHMGDGNNBB, FCPBOECGDIL LKAJNMAHFJE, Action GOODBCHHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7920E10", Offset = "0x791F610", VA = "0x187920E10")]
	public static IDisposable MDLFDDOBJHE(this MonoBehaviour EJOMIDEGKIL, float CKHMGDGNNBB, Action GOODBCHHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7920C40", Offset = "0x791F440", VA = "0x187920C40")]
	public static EBBFPAKHIHA IFAMBMOBGGK(this MonoBehaviour EJOMIDEGKIL, float CKHMGDGNNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7920EF0", Offset = "0x791F6F0", VA = "0x187920EF0")]
	public static EBBFPAKHIHA MDLFDDOBJHE(this MonoBehaviour EJOMIDEGKIL, float CKHMGDGNNBB, FCPBOECGDIL LKAJNMAHFJE, Action GOODBCHHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7920930", Offset = "0x791F130", VA = "0x187920930")]
	public static EBBFPAKHIHA CICINGMIAAH(this MonoBehaviour EJOMIDEGKIL, Action GOODBCHHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x30E6E80", Offset = "0x30E5680", VA = "0x1830E6E80")]
	public static EBBFPAKHIHA CICINGMIAAH<T>(this MonoBehaviour EJOMIDEGKIL, Action<T> GOODBCHHJFH, T HBIPIPALDEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7921120", Offset = "0x791F920", VA = "0x187921120")]
	public static EBBFPAKHIHA OKODAIFHMDI(this MonoBehaviour EJOMIDEGKIL, Action GOODBCHHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7920BA0", Offset = "0x791F3A0", VA = "0x187920BA0")]
	public static EBBFPAKHIHA HJCLEELLPHK(this MonoBehaviour EJOMIDEGKIL, Action GOODBCHHJFH, [Optional] IFJNPEGGGGL DIDBPBFLOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7920CD0", Offset = "0x791F4D0", VA = "0x187920CD0")]
	public static EBBFPAKHIHA JBDNANINPBI(this MonoBehaviour EJOMIDEGKIL, Action GOODBCHHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7920D70", Offset = "0x791F570", VA = "0x187920D70")]
	public static EBBFPAKHIHA JIMIKLFMBNK(this MonoBehaviour EJOMIDEGKIL, Action GOODBCHHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x79209D0", Offset = "0x791F1D0", VA = "0x1879209D0")]
	public static EBBFPAKHIHA EGAFCMPAIGC(MonoBehaviour EJOMIDEGKIL, FCPBOECGDIL EFJGAMLEOMN, Action GOODBCHHJFH, [Optional] IFJNPEGGGGL DIDBPBFLOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x30E6ED0", Offset = "0x30E56D0", VA = "0x1830E6ED0")]
	public static EBBFPAKHIHA EGAFCMPAIGC<T>(MonoBehaviour EJOMIDEGKIL, FCPBOECGDIL EFJGAMLEOMN, Action<T> GOODBCHHJFH, T HBIPIPALDEO, [Optional] IFJNPEGGGGL DIDBPBFLOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7920B10", Offset = "0x791F310", VA = "0x187920B10")]
	public static EBBFPAKHIHA GJPEBIAAFOL(this MonoBehaviour EJOMIDEGKIL, float PJEMJEPJJPI, Action GOODBCHHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7920890", Offset = "0x791F090", VA = "0x187920890")]
	public static EBBFPAKHIHA AABCOOHPFAI(this MonoBehaviour EJOMIDEGKIL, float PJEMJEPJJPI, Action GOODBCHHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7921080", Offset = "0x791F880", VA = "0x187921080")]
	public static EBBFPAKHIHA OAGDGLEJCJB(this MonoBehaviour EJOMIDEGKIL, float PJEMJEPJJPI, Action GOODBCHHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x79211C0", Offset = "0x791F9C0", VA = "0x1879211C0")]
	public static EBBFPAKHIHA PICLPNONKIA(this MonoBehaviour EJOMIDEGKIL, float PJEMJEPJJPI, Action GOODBCHHJFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class JCAOBLJNKEA : CGNKJLNMKHO, IEnumerable<CGNKJLNMKHO>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly List<CGNKJLNMKHO> OGIBAMLBFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private bool PLFMFCFCLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Action OHCBJHLLAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool KNONPIIBIDP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GOIJACHJKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7920050", Offset = "0x791E850", VA = "0x187920050", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AACNDCOJHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x791FFB0", Offset = "0x791E7B0", VA = "0x18791FFB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x791F8E0", Offset = "0x791E0E0", VA = "0x18791F8E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7920190", Offset = "0x791E990", VA = "0x187920190")]
	public JCAOBLJNKEA([Optional] Action OHCBJHLLAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x791FD20", Offset = "0x791E520", VA = "0x18791FD20")]
	public void JGCMIIMCCFC(CGNKJLNMKHO OGEHHIIIHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x791FE50", Offset = "0x791E650", VA = "0x18791FE50")]
	private void MDHPFMGKECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x791FC90", Offset = "0x791E490", VA = "0x18791FC90", Slot = "7")]
	public bool EFPGAGBIGBD(bool KHDIFEIJFDB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x791F980", Offset = "0x791E180", VA = "0x18791F980", Slot = "8")]
	public bool EFPGAGBIGBD(Action ILIPDNLABEN, bool KHDIFEIJFDB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x791FCA0", Offset = "0x791E4A0", VA = "0x18791FCA0", Slot = "9")]
	public IEnumerator<CGNKJLNMKHO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x791FCA0", Offset = "0x791E4A0", VA = "0x18791FCA0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class KFIIALBOCJA : AEGJIJHJJEH
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class ACKCLPLCJNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public KFIIALBOCJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public ACKCLPLCJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x790D8C0", Offset = "0x790C0C0", VA = "0x18790D8C0")]
		internal void MOAMECJJLDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class BOKNDGGJNGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public KFIIALBOCJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public BOKNDGGJNGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x790D8C0", Offset = "0x790C0C0", VA = "0x18790D8C0")]
		internal void IHHGLJFAMIC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float HGFDBOLAFPH;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7917A30", Offset = "0x7916230", VA = "0x187917A30")]
	public KFIIALBOCJA(Behaviour IKGPEBFFMPK, float HGFDBOLAFPH, [Optional] Action OHCBJHLLAMD, [Optional] IFJNPEGGGGL DIDBPBFLOGP, [Optional] DNFJCKJDFHL EKKCFOIAMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7920580", Offset = "0x791ED80", VA = "0x187920580", Slot = "9")]
	protected override bool LOGEMEBPKDC(Action ILIPDNLABEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7920470", Offset = "0x791EC70", VA = "0x187920470", Slot = "10")]
	protected override bool KOHBLFKPACL(Action ILIPDNLABEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface CGNKJLNMKHO
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool GOIJACHJKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action AACNDCOJHDK;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EFPGAGBIGBD(bool KHDIFEIJFDB = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EFPGAGBIGBD(Action ILIPDNLABEN, bool KHDIFEIJFDB = false);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class AEGJIJHJJEH : CGNKJLNMKHO
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class ADFEFLCPNLD : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public AEGJIJHJJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public ADFEFLCPNLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x790DD60", Offset = "0x790C560", VA = "0x18790DD60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x790DE30", Offset = "0x790C630", VA = "0x18790DE30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly Behaviour IKGPEBFFMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly Action OHCBJHLLAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private DGGJLAPANLP FMEAJGFKHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly IFJNPEGGGGL DIDBPBFLOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	protected readonly DNFJCKJDFHL EKKCFOIAMPJ;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool GOIJACHJKOI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x126FA60", Offset = "0x126E260", VA = "0x18126FA60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AACNDCOJHDK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x790E3A0", Offset = "0x790CBA0", VA = "0x18790E3A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x790DE80", Offset = "0x790C680", VA = "0x18790DE80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x790E440", Offset = "0x790CC40", VA = "0x18790E440")]
	protected AEGJIJHJJEH(Behaviour IKGPEBFFMPK, [Optional] Action OHCBJHLLAMD, [Optional] IFJNPEGGGGL DIDBPBFLOGP, [Optional] DNFJCKJDFHL EKKCFOIAMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x790E170", Offset = "0x790C970", VA = "0x18790E170", Slot = "7")]
	public bool EFPGAGBIGBD(bool KHDIFEIJFDB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x790E1D0", Offset = "0x790C9D0", VA = "0x18790E1D0", Slot = "8")]
	public bool EFPGAGBIGBD(Action ILIPDNLABEN, bool KHDIFEIJFDB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool LOGEMEBPKDC(Action ILIPDNLABEN);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool KOHBLFKPACL(Action ILIPDNLABEN);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x790E2C0", Offset = "0x790CAC0", VA = "0x18790E2C0")]
	protected void FMCFALEAJBI(Action ILIPDNLABEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x790DF20", Offset = "0x790C720", VA = "0x18790DF20")]
	protected MOPOHKAGKCI DIFAFDAENDM(float IGEHIFGNOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x790E2E0", Offset = "0x790CAE0", VA = "0x18790E2E0")]
	private void GPDLOCNGJOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x790E230", Offset = "0x790CA30", VA = "0x18790E230")]
	[IteratorStateMachine(typeof(ADFEFLCPNLD))]
	private IEnumerator<IJKEOMMDACC> FHPIELALEAF(float IGEHIFGNOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x790E360", Offset = "0x790CB60", VA = "0x18790E360")]
	[CompilerGenerated]
	private void IFANGLMBIHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class DDPJMFOCAEI : AEGJIJHJJEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly float AMMBNDNFBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly int HPOEAOOHDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly float BGCDCIFDPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly float[] KLGHHKCFIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int ONGIBMNKDJG;

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x79155C0", Offset = "0x7913DC0", VA = "0x1879155C0")]
	public DDPJMFOCAEI(Behaviour IKGPEBFFMPK, float NFGDHEKMLFN, int HPOEAOOHDOP, [Optional] Action OHCBJHLLAMD, float BGCDCIFDPDG = 0f, [Optional] IFJNPEGGGGL DIDBPBFLOGP, [Optional] DNFJCKJDFHL EKKCFOIAMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "9")]
	protected override bool LOGEMEBPKDC(Action ILIPDNLABEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x79153C0", Offset = "0x7913BC0", VA = "0x1879153C0", Slot = "10")]
	protected override bool KOHBLFKPACL(Action ILIPDNLABEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7915340", Offset = "0x7913B40", VA = "0x187915340")]
	private void GAKELKJKEDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class EJAPGJCMAMN : AEGJIJHJJEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly float HGFDBOLAFPH;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7917A30", Offset = "0x7916230", VA = "0x187917A30")]
	public EJAPGJCMAMN(Behaviour IKGPEBFFMPK, float HGFDBOLAFPH, [Optional] Action OHCBJHLLAMD, [Optional] IFJNPEGGGGL DIDBPBFLOGP, [Optional] DNFJCKJDFHL EKKCFOIAMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "9")]
	protected override bool LOGEMEBPKDC(Action ILIPDNLABEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x79179F0", Offset = "0x79161F0", VA = "0x1879179F0", Slot = "10")]
	protected override bool KOHBLFKPACL(Action ILIPDNLABEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class EMPIJIIJPKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class IPLNMDEOHPC : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public IPLNMDEOHPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7915790", Offset = "0x7913F90", VA = "0x187915790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x791F650", Offset = "0x791DE50", VA = "0x18791F650", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private EBBFPAKHIHA NBHHOIPPOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private OOOILGHOBHM IKGPEBFFMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Action<float> LLAPMPCOKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private FCPBOECGDIL EFJGAMLEOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float OKLMGJKCDNH;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x79181B0", Offset = "0x79169B0", VA = "0x1879181B0")]
	public EMPIJIIJPKJ(OOOILGHOBHM IKGPEBFFMPK, float GGMPEOGACCK, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7917E40", Offset = "0x7916640", VA = "0x187917E40")]
	private void HHIOKEPLOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7917D10", Offset = "0x7916510", VA = "0x187917D10")]
	private void EEMNEKIIAFO(string JBBHONJKFOI, Action NGJAIGGBBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7917FB0", Offset = "0x79167B0", VA = "0x187917FB0")]
	[IteratorStateMachine(typeof(IPLNMDEOHPC))]
	private IEnumerator<IJKEOMMDACC> HHNCBDHCNNF(Action NGJAIGGBBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7917CB0", Offset = "0x79164B0", VA = "0x187917CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7918030", Offset = "0x7916830", VA = "0x187918030")]
	[CompilerGenerated]
	private void PDBEKBPJOKB(string MDGFDHAJGLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class PIMPBMMGLDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class DGNJPLKDIIJ : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public DGNJPLKDIIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7915790", Offset = "0x7913F90", VA = "0x187915790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7915800", Offset = "0x7914000", VA = "0x187915800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private EBBFPAKHIHA NBHHOIPPOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private MonoBehaviour EJOMIDEGKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Action ABCBLJADALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Action<float> LLAPMPCOKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private FCPBOECGDIL EFJGAMLEOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private float OKLMGJKCDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool FEBIADHLPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly IFJNPEGGGGL DIDBPBFLOGP;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x792A600", Offset = "0x7928E00", VA = "0x18792A600")]
	public PIMPBMMGLDO(MonoBehaviour EJOMIDEGKIL, Action ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, [Optional] IFJNPEGGGGL DIDBPBFLOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x792A790", Offset = "0x7928F90", VA = "0x18792A790")]
	public PIMPBMMGLDO(MonoBehaviour EJOMIDEGKIL, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, [Optional] IFJNPEGGGGL DIDBPBFLOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x792A420", Offset = "0x7928C20", VA = "0x18792A420")]
	public PIMPBMMGLDO(MonoBehaviour EJOMIDEGKIL, float GGMPEOGACCK, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, bool FEBIADHLPIH = true, [Optional] IFJNPEGGGGL DIDBPBFLOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x99D780", Offset = "0x99BF80", VA = "0x18099D780")]
	private PIMPBMMGLDO(IFJNPEGGGGL DIDBPBFLOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x792A160", Offset = "0x7928960", VA = "0x18792A160")]
	internal static PIMPBMMGLDO PDJIGBCNKEK(MonoBehaviour EJOMIDEGKIL, float GGMPEOGACCK, Action<float> ABCBLJADALH, FCPBOECGDIL EFJGAMLEOMN, bool FEBIADHLPIH = true, [Optional] IFJNPEGGGGL DIDBPBFLOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x79297F0", Offset = "0x7927FF0", VA = "0x1879297F0")]
	private void DJKDLEICJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7929B40", Offset = "0x7928340", VA = "0x187929B40")]
	private void FODJLJFAKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7929E50", Offset = "0x7928650", VA = "0x187929E50")]
	private void HHIOKEPLOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7929CC0", Offset = "0x79284C0", VA = "0x187929CC0")]
	private void FPJHKADGMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7929980", Offset = "0x7928180", VA = "0x187929980")]
	private void EEMNEKIIAFO(string JBBHONJKFOI, Action NGJAIGGBBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7929FC0", Offset = "0x79287C0", VA = "0x187929FC0")]
	[IteratorStateMachine(typeof(DGNJPLKDIIJ))]
	private IEnumerator<IJKEOMMDACC> HHNCBDHCNNF(Action NGJAIGGBBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7929920", Offset = "0x7928120", VA = "0x187929920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x792A040", Offset = "0x7928840", VA = "0x18792A040")]
	[CompilerGenerated]
	private void IKIGEJJCBOI(string MDGFDHAJGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x792A0D0", Offset = "0x79288D0", VA = "0x18792A0D0")]
	[CompilerGenerated]
	private void MNAHAANECOB(string MDGFDHAJGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x792A390", Offset = "0x7928B90", VA = "0x18792A390")]
	[CompilerGenerated]
	private void PNOIFIMMGKD(string MDGFDHAJGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7929AB0", Offset = "0x79282B0", VA = "0x187929AB0")]
	[CompilerGenerated]
	private void EHEOMJECBBL(string MDGFDHAJGLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[Flags]
internal enum OOHIMPBNGHL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class AHIPJIBKIBH : DNFJCKJDFHL
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float BEHPFFOOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x790E570", Offset = "0x790CD70", VA = "0x18790E570", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float MPDMGOMMHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x790E5F0", Offset = "0x790CDF0", VA = "0x18790E5F0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public double GGNNPHNHDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x790E600", Offset = "0x790CE00", VA = "0x18790E600", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x790E580", Offset = "0x790CD80", VA = "0x18790E580")]
	[PDAMAKFHAHC.GNFCFDNPMLH]
	internal static void EDDDBNCFOFG(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	[UnityEngine.Scripting.Preserve]
	internal AHIPJIBKIBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal interface AECOAGGFDNI
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDNJOKJINAD(string IKMKCMDHFDC);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEBKIGDFNNG();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal interface HDFONCJJABA
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JFFJPJACBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool FNKNGAPOJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class NDIFKNBPLMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public IILGCGPKDPN CLGEKLDIAGG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int MBLPHBBBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B5210", Offset = "0x8B3A10", VA = "0x1808B5210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7926760", Offset = "0x7924F60", VA = "0x187926760")]
	public static IJKEOMMDACC JPDKPOGLJKD(IEnumerator<IJKEOMMDACC> OICHJCDFLGO, DPJOHDNEBDA GPMIEMJMELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x79266A0", Offset = "0x7924EA0", VA = "0x1879266A0")]
	public IJKEOMMDACC JPDKPOGLJKD(DPJOHDNEBDA[] LMJLCCLKNBJ, IEnumerator<IJKEOMMDACC>[] AILHOCKBBOG, IJKEOMMDACC[] NALCGABJBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x79263F0", Offset = "0x7924BF0", VA = "0x1879263F0")]
	public void CEDBBFGEPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7926420", Offset = "0x7924C20", VA = "0x187926420")]
	public void DNGEGLEEHEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7926560", Offset = "0x7924D60", VA = "0x187926560")]
	public void EFMPCKKLANO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x79263F0", Offset = "0x7924BF0", VA = "0x1879263F0")]
	public void PEICGLEFBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public NDIFKNBPLMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class IILGCGPKDPN
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct DFOEAFHJLML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public NDIFKNBPLMM HGBAKNBAKKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public OOOILGHOBHM MCHNDACHJAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public DPJOHDNEBDA DIAAJKPMBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public IEnumerator<IJKEOMMDACC> GIDPBFNPPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public IJKEOMMDACC ILCFOOEFICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public OOHIMPBNGHL LALICHBDINO;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct PKNPJBDFKMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public FCPBOECGDIL AIPFPMCOCFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public List<DFOEAFHJLML> GIECBKACAAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class CNLLGNPAOHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public DPJOHDNEBDA promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public IILGCGPKDPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public OOOILGHOBHM context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public NDIFKNBPLMM routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public OOHIMPBNGHL coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public IJKEOMMDACC currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public IEnumerator<IJKEOMMDACC> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public CNLLGNPAOHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7910600", Offset = "0x790EE00", VA = "0x187910600")]
		internal void BAOAKGILPJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class JCDICHGNOEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NDIFKNBPLMM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public IILGCGPKDPN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public JCDICHGNOEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7920230", Offset = "0x791EA30", VA = "0x187920230")]
		internal void KGOOHHLJBMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class EIOFKHLEPPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public NDIFKNBPLMM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public IILGCGPKDPN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EIOFKHLEPPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x79179B0", Offset = "0x79161B0", VA = "0x1879179B0")]
		internal void INKGHHGCBGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class CBOJBMNAPEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public NDIFKNBPLMM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public IILGCGPKDPN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public CBOJBMNAPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x790FCE0", Offset = "0x790E4E0", VA = "0x18790FCE0")]
		internal void ILBPPCJJIDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const OOHIMPBNGHL EMANMAIFMEC = OOHIMPBNGHL.Cancelled | OOHIMPBNGHL.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly FCPBOECGDIL EFJGAMLEOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private bool[] GIPFCOGKJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private NativeArray<OOHIMPBNGHL> KJKKBADFGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private NativeArray<float> AOEAHABHFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private NativeArray<int> MGOHOJFBLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private NativeArray<int> COHHACGAAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private NativeArray<int> FGMNECADHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private NativeArray<int> MPPLOIFEKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private NativeArray<int> BCJGFAICOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private NDIFKNBPLMM[] IANIPGIEOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private DPJOHDNEBDA[] LMJLCCLKNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private OOOILGHOBHM[] FFHJIKGHNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private IEnumerator<IJKEOMMDACC>[] KFPMBNJFCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private IJKEOMMDACC[] IDFLECIOABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private int CODLGMJNOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private int DEOEMPAJCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly int MIEHFACIEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private float JLJJBFNKLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private FGCJGJALHBM PGPOALHFEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private JobHandle AGPOAJIHOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private List<NDIFKNBPLMM> DNNCBMBBAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private bool ODNEIOPMMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private List<Action> LDAGBHHLIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private List<Action> OJDHPGIKBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private bool ICKDNMFPFOF;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public PKNPJBDFKMA[] LNKKLOEOAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xAD1670", Offset = "0xACFE70", VA = "0x180AD1670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x791CAB0", Offset = "0x791B2B0", VA = "0x18791CAB0")]
	private static int DHNFKMFOPMH(FCPBOECGDIL EFJGAMLEOMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x791E920", Offset = "0x791D120", VA = "0x18791E920")]
	public IILGCGPKDPN(FCPBOECGDIL EFJGAMLEOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x791D780", Offset = "0x791BF80", VA = "0x18791D780")]
	private void JHNJKFGMOIN(int GLDJMEJGEAD, int GLDGPOMBNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x791E1D0", Offset = "0x791C9D0", VA = "0x18791E1D0")]
	public void MIDOHNMGAAD(OOOILGHOBHM IKGPEBFFMPK, IJKEOMMDACC DAPFHCDMJAG, IEnumerator<IJKEOMMDACC> OICHJCDFLGO, DPJOHDNEBDA GPMIEMJMELH, [Optional] NDIFKNBPLMM KJGJKMCJBIH, OOHIMPBNGHL KLALMDNJCMC = OOHIMPBNGHL.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x791E5B0", Offset = "0x791CDB0", VA = "0x18791E5B0")]
	public void PEGGGLMFMFF(IEnumerable<DFOEAFHJLML> GCOPMKMDNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x791CCE0", Offset = "0x791B4E0", VA = "0x18791CCE0")]
	private DFOEAFHJLML FPCKNIMMBAN(int COGNFPKJAOM)
	{
		return default(DFOEAFHJLML);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x791D2E0", Offset = "0x791BAE0", VA = "0x18791D2E0")]
	private void ILIDGJEDEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x309FA20", Offset = "0x309E220", VA = "0x18309FA20")]
	private static void EFNOLANHCEM<T>(int COGNFPKJAOM, T[] ONIJKKEHKDF, int BOOADEANLJB, [Optional] T GJMHDPAAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x309FA70", Offset = "0x309E270", VA = "0x18309FA70")]
	private static void EFNOLANHCEM<T>(int COGNFPKJAOM, NativeArray<T> ONIJKKEHKDF, int BOOADEANLJB, [Optional] T GJMHDPAAALP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x791C710", Offset = "0x791AF10", VA = "0x18791C710")]
	private void BNBJDIODAHD(IEnumerable<DFOEAFHJLML> GCOPMKMDNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x791E080", Offset = "0x791C880", VA = "0x18791E080")]
	private void KEEGIDIAMHJ(DFOEAFHJLML CPPIMGPHGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x791E350", Offset = "0x791CB50", VA = "0x18791E350")]
	private JNANKBFJELM MNHJCODCKFK(int ILPIAEOHFFB)
	{
		return default(JNANKBFJELM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x791CAE0", Offset = "0x791B2E0", VA = "0x18791CAE0")]
	public void DLOGPEJLNAK(float NFIGBCOCIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x791E150", Offset = "0x791C950", VA = "0x18791E150")]
	private void KGDCGHGBCPL(Action DAOGAHJCGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x791C590", Offset = "0x791AD90", VA = "0x18791C590")]
	private void AEKBBMCNBOG(Action DAOGAHJCGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x791D960", Offset = "0x791C160", VA = "0x18791D960")]
	public void JMNHINLDPCJ(float NFIGBCOCIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x791C610", Offset = "0x791AE10", VA = "0x18791C610")]
	public void BJHAOCCHMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x791E7F0", Offset = "0x791CFF0", VA = "0x18791E7F0")]
	public void PEICGLEFBEK(NDIFKNBPLMM HBEOBKGNPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x791D650", Offset = "0x791BE50", VA = "0x18791D650")]
	public void JAHAMEGGJPK(NDIFKNBPLMM HBEOBKGNPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x791D1B0", Offset = "0x791B9B0", VA = "0x18791D1B0")]
	public void HKPCIHMHPPC(NDIFKNBPLMM HBEOBKGNPLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class PLGFKABACDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static readonly PLGFKABACDB PNJBLIJBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly Action KCPLAHHONOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private bool LOEKDIGJGDI;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public PLGFKABACDB(Action KCPLAHHONOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x704EAD0", Offset = "0x704D2D0", VA = "0x18704EAD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface ACMOPJECABL<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	T MHFLHGKPHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable KOMHGAAPHEB(UnityEngine.Object IKGPEBFFMPK, Action<T> OPACGFKPKFL);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface PNAJNJMCPJF<T> : ACMOPJECABL<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	new T MHFLHGKPHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class OAOABHBMCMM<T> : PNAJNJMCPJF<T>, ACMOPJECABL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class FDNGECEANNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public OAOABHBMCMM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public JHEBLGILBBA<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FDNGECEANNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x40645B0", Offset = "0x4062DB0", VA = "0x1840645B0")]
		internal void LKCGBAIAIGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static GameObject KHKPCEJKGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly List<JHEBLGILBBA<UnityEngine.Object, Action<T>>> DFBHJDMGKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private T NOHKGMPJFCD;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public T MHFLHGKPHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x9575D0", Offset = "0x955DD0", VA = "0x1809575D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4B3B240", Offset = "0x4B39A40", VA = "0x184B3B240", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4B3B150", Offset = "0x4B39950", VA = "0x184B3B150")]
	private static bool CKHKGNCHKCA(T DAOGAHJCGEC, T NBDADAEEFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4B3BD70", Offset = "0x4B3A570", VA = "0x184B3BD70")]
	public OAOABHBMCMM(T BMMFEAPHOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4B3B390", Offset = "0x4B39B90", VA = "0x184B3B390", Slot = "6")]
	public IDisposable KOMHGAAPHEB(UnityEngine.Object IKGPEBFFMPK, Action<T> OPACGFKPKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4B3B6F0", Offset = "0x4B39EF0", VA = "0x184B3B6F0")]
	private void KPKEOAJIGIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal class FOKPFCGJJIL : CEGHFAIAMHL
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private class BFNPFEKIHPB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private class AIDMLJGFMCP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			private int DOBPKLNCBDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			private BFNPFEKIHPB LKAJNMAHFJE;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xAE1A00", Offset = "0xAE0200", VA = "0x180AE1A00")]
			public AIDMLJGFMCP(int DOBPKLNCBDO, BFNPFEKIHPB LKAJNMAHFJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x790E620", Offset = "0x790CE20", VA = "0x18790E620", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class JAEHDLIAPPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public JAEHDLIAPPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xA457B0", Offset = "0xA43FB0", VA = "0x180A457B0")]
			internal bool OHFJLFJMLPG(HDANOFEKBHH e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class FLPDAKOIENF : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			private IJKEOMMDACC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public BFNPFEKIHPB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public DNFJCKJDFHL timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			private BOABIFMEPAL <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			private List<HDANOFEKBHH> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EF")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F1")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
			[DebuggerHidden]
			public FLPDAKOIENF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x7918D40", Offset = "0x7917540", VA = "0x187918D40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x79190D0", Offset = "0x79178D0", VA = "0x1879190D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private readonly FCPBOECGDIL EFJGAMLEOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private EBBFPAKHIHA GPMIEMJMELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool OEBKFOGLABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private readonly List<HDANOFEKBHH> OHIFBECKFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private readonly HashSet<int> KAKNFADCDKI;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x790F670", Offset = "0x790DE70", VA = "0x18790F670")]
		public BFNPFEKIHPB(FCPBOECGDIL EFJGAMLEOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x790F2C0", Offset = "0x790DAC0", VA = "0x18790F2C0")]
		public IDisposable KFIIGAOPKAE(HDANOFEKBHH GJHLEBBHDKN, IFJNPEGGGGL DIDBPBFLOGP, DNFJCKJDFHL IEGOAOCEEPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x790F450", Offset = "0x790DC50", VA = "0x18790F450")]
		private void NKEIALMMGPF(int DOBPKLNCBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x790F5E0", Offset = "0x790DDE0", VA = "0x18790F5E0")]
		[IteratorStateMachine(typeof(FLPDAKOIENF))]
		private IEnumerator<IJKEOMMDACC> PNMMLFCAFJI(DNFJCKJDFHL IEGOAOCEEPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x790F270", Offset = "0x790DA70", VA = "0x18790F270", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private class HDANOFEKBHH
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public enum KJHNOOMHJIN : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static int FDHOBJHFGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public readonly int JPPMHDHPBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public readonly DLKJMFLDODE MCHNDACHJAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly MonoBehaviour BLPJJBEKMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public readonly Action LHNLPLKLOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public readonly Action<float> ENLIHOJKANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public readonly float MBKNGKLPGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public float AOEAHABHFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public readonly string AEHPFKGBHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public readonly bool HFAACBBIIPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public readonly KJHNOOMHJIN JOHGIAEGNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public bool CFNJNOJJKPG;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x791A7B0", Offset = "0x7918FB0", VA = "0x18791A7B0")]
		public HDANOFEKBHH(DLKJMFLDODE IKGPEBFFMPK, Action ABCBLJADALH, bool LGOMCFBENAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x791AB10", Offset = "0x7919310", VA = "0x18791AB10")]
		public HDANOFEKBHH(DLKJMFLDODE IKGPEBFFMPK, Action<float> ABCBLJADALH, bool LGOMCFBENAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x791A930", Offset = "0x7919130", VA = "0x18791A930")]
		public HDANOFEKBHH(DLKJMFLDODE IKGPEBFFMPK, float GGMPEOGACCK, Action<float> ABCBLJADALH, DNFJCKJDFHL IEGOAOCEEPG, KJHNOOMHJIN LEDJFEFFJEN, bool FEBIADHLPIH, bool LGOMCFBENAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x791A5E0", Offset = "0x7918DE0", VA = "0x18791A5E0")]
		public bool MPEFMKKNBFH(float MHAEBFLONHE, float KJOMHGBFMLK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly IFJNPEGGGGL DIDBPBFLOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly DNFJCKJDFHL EKKCFOIAMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Dictionary<FCPBOECGDIL, BFNPFEKIHPB> NDDLADPMKBC;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x79193A0", Offset = "0x7917BA0", VA = "0x1879193A0")]
	[PDAMAKFHAHC.GNFCFDNPMLH]
	internal static void CKNJMGHAEGM(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7919C40", Offset = "0x7918440", VA = "0x187919C40")]
	[UnityEngine.Scripting.Preserve]
	internal FOKPFCGJJIL([NDCFMLCHJCI(null)] IFJNPEGGGGL DIDBPBFLOGP, [NDCFMLCHJCI(null)] DNFJCKJDFHL EKKCFOIAMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x79198C0", Offset = "0x79180C0", VA = "0x1879198C0", Slot = "4")]
	public IDisposable LHNLPLKLOMD(DLKJMFLDODE IKGPEBFFMPK, Action KNMHMBJIFMM, FCPBOECGDIL EFJGAMLEOMN, bool LGOMCFBENAP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x79196D0", Offset = "0x7917ED0", VA = "0x1879196D0", Slot = "5")]
	public IDisposable LHNLPLKLOMD(DLKJMFLDODE IKGPEBFFMPK, Action<float> KNMHMBJIFMM, FCPBOECGDIL EFJGAMLEOMN, bool LGOMCFBENAP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7919120", Offset = "0x7917920", VA = "0x187919120", Slot = "7")]
	public IDisposable AMOHBFHFLKP(DLKJMFLDODE IKGPEBFFMPK, float GGMPEOGACCK, Action<float> KNMHMBJIFMM, FCPBOECGDIL EFJGAMLEOMN, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x79195D0", Offset = "0x7917DD0", VA = "0x1879195D0", Slot = "8")]
	public IDisposable HKMCBPOBHJG(DLKJMFLDODE IKGPEBFFMPK, float GGMPEOGACCK, Action<float> KNMHMBJIFMM, FCPBOECGDIL EFJGAMLEOMN, bool FEBIADHLPIH = true, bool LGOMCFBENAP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7919220", Offset = "0x7917A20", VA = "0x187919220", Slot = "6")]
	public IDisposable AMOHBFHFLKP(float GGMPEOGACCK, Action<float> KNMHMBJIFMM, bool FEBIADHLPIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7919410", Offset = "0x7917C10", VA = "0x187919410", Slot = "9")]
	public void FGGFCKBCIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7919AB0", Offset = "0x79182B0", VA = "0x187919AB0")]
	private BFNPFEKIHPB MKAHNKDILBG(FCPBOECGDIL EFJGAMLEOMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class PDALKKKEFNF : MNCDKOCHEDP, IFJNPEGGGGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private IILGCGPKDPN[] HIIHNPOBONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private AECOAGGFDNI PGFBLCEDOMP;

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7928BC0", Offset = "0x79273C0", VA = "0x187928BC0")]
	[PDAMAKFHAHC.GNFCFDNPMLH]
	internal static void EDDDBNCFOFG(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7929730", Offset = "0x7927F30", VA = "0x187929730")]
	[UnityEngine.Scripting.Preserve]
	public PDALKKKEFNF([NDCFMLCHJCI(null)] EIHLFGMMHPP LDBAAAAADBJ, [NDCFMLCHJCI(null)] DNFJCKJDFHL EKKCFOIAMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7929440", Offset = "0x7927C40", VA = "0x187929440", Slot = "19")]
	public override EBBFPAKHIHA KCCCCGAFLEM(OOOILGHOBHM IKGPEBFFMPK, IEnumerator<IJKEOMMDACC> LCDOHBAOKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7928D50", Offset = "0x7927550", VA = "0x187928D50", Slot = "20")]
	public override void FGGFCKBCIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7929210", Offset = "0x7927A10", VA = "0x187929210", Slot = "22")]
	public override void GIJIDBCHBEK(FCPBOECGDIL EFJGAMLEOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7929570", Offset = "0x7927D70", VA = "0x187929570", Slot = "21")]
	protected override void LHNLPLKLOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7929700", Offset = "0x7927F00", VA = "0x187929700")]
	private IILGCGPKDPN MNIABNACIPJ(FCPBOECGDIL OCLAPBNMMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7928FE0", Offset = "0x79277E0", VA = "0x187928FE0", Slot = "23")]
	internal override BEPCEBBHGKH FNPAFEHEONF(IEnumerator<IJKEOMMDACC> LCDOHBAOKAL, Behaviour IKGPEBFFMPK, DPJOHDNEBDA GPMIEMJMELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7929640", Offset = "0x7927E40", VA = "0x187929640", Slot = "24")]
	internal override DINNBFHMHHL LKACLFGEKGC(FCPBOECGDIL LKAJNMAHFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7928C30", Offset = "0x7927430", VA = "0x187928C30")]
	private void FDGJNALHINP(IILGCGPKDPN EEBIGFBHEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7928B60", Offset = "0x7927360", VA = "0x187928B60", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[BurstCompile]
internal struct FGCJGJALHBM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[ReadOnly]
	public float MOCILJMPCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[ReadOnly]
	public int KJICMJFOHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeArray<int> AIGIJMJIFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private NativeArray<int> PEOFCIDHNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeArray<int> HILMOEFPJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[ReadOnly]
	public NativeArray<OOHIMPBNGHL> LPAENMNFHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[ReadOnly]
	public NativeArray<float> IKIBKGNOENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	[WriteOnly]
	public NativeArray<int> FGMNECADHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	[WriteOnly]
	public NativeArray<int> MGOHOJFBLDC;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7918CE0", Offset = "0x79174E0", VA = "0x187918CE0")]
	public static FGCJGJALHBM JHEOKMMJDLF(int GCMFOFAHBAL, float NFIGBCOCIDK, NativeArray<OOHIMPBNGHL> OIAJAGLOIIJ, NativeArray<float> MLPJBDBMLIN, NativeArray<int> PFFAMKEELML, NativeArray<int> NBJIONHHGLN, NativeArray<int> DMINKPPBFEC, NativeArray<int> PEOFCIDHNEC, NativeArray<int> HILMOEFPJHO)
	{
		return default(FGCJGJALHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x79188C0", Offset = "0x79170C0", VA = "0x1879188C0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7918880", Offset = "0x7917080", VA = "0x187918880")]
	private bool BMIBOOEBBNO(int ECDOOAABOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x79189A0", Offset = "0x79171A0", VA = "0x1879189A0")]
	private void FKOOMNFOBJE(NativeArray<int> KPIKEGJFCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x79187E0", Offset = "0x7916FE0", VA = "0x1879187E0")]
	private int AAPBHGPLIOL(int CDNBBBGILPI, int GHDBPPIMPOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7918C10", Offset = "0x7917410", VA = "0x187918C10")]
	private void JAJJKNOJEKM(NativeArray<int> KPIKEGJFCKA, int ENOJCLNKEPH, int EBAPCDIJGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x79189D0", Offset = "0x79171D0", VA = "0x1879189D0")]
	private void HPDMGDJGDCP(NativeArray<int> KPIKEGJFCKA, int LCOFGEIMJFA, int DKNIEFLJPEK, int HBLJILMGNIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public abstract class MNCDKOCHEDP : IFJNPEGGGGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly EIHLFGMMHPP LDBAAAAADBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	protected readonly DNFJCKJDFHL EKKCFOIAMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private DINNBFHMHHL[] CGMLGBFACIP;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static IFJNPEGGGGL ODDIIHPHFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7925590", Offset = "0x7923D90", VA = "0x187925590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static bool KNPGJHABEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public FCPBOECGDIL NEGIACFFHBH
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FCPBOECGDIL);
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8B5210", Offset = "0x8B3A10", VA = "0x1808B5210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public DNFJCKJDFHL KMDGBLACHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IJKEOMMDACC IPBGJGAGJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public IJKEOMMDACC OMEGLIHJPIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1D0", Offset = "0x8BB9D0", VA = "0x1808BD1D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public IJKEOMMDACC MKBPJKNPLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8BB220", Offset = "0x8B9A20", VA = "0x1808BB220", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IJKEOMMDACC PHHMAOMOBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8B7500", Offset = "0x8B5D00", VA = "0x1808B7500", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7925AF0", Offset = "0x79242F0", VA = "0x187925AF0")]
	public static EBBFPAKHIHA ICJGJDFFHKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7925F00", Offset = "0x7924700", VA = "0x187925F00")]
	[UnityEngine.Scripting.Preserve]
	protected MNCDKOCHEDP([NDCFMLCHJCI(null)] EIHLFGMMHPP LDBAAAAADBJ, [NDCFMLCHJCI(null)] DNFJCKJDFHL EKKCFOIAMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x79251A0", Offset = "0x79239A0", VA = "0x1879251A0", Slot = "6")]
	public EBBFPAKHIHA BDBMLJNBAHE(IEnumerator<IJKEOMMDACC> LCDOHBAOKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7924FA0", Offset = "0x79237A0", VA = "0x187924FA0", Slot = "7")]
	public EBBFPAKHIHA BDBMLJNBAHE(Behaviour IKGPEBFFMPK, IEnumerator<IJKEOMMDACC> LCDOHBAOKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract EBBFPAKHIHA KCCCCGAFLEM(OOOILGHOBHM IKGPEBFFMPK, IEnumerator<IJKEOMMDACC> LCDOHBAOKAL);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7925600", Offset = "0x7923E00", VA = "0x187925600", Slot = "20")]
	public virtual void FGGFCKBCIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7925890", Offset = "0x7924090", VA = "0x187925890", Slot = "9")]
	public void HFFPCCNFIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7925D70", Offset = "0x7924570", VA = "0x187925D70", Slot = "21")]
	protected virtual void LHNLPLKLOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7925870", Offset = "0x7924070", VA = "0x187925870")]
	private void GOCHILFDFAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x79257A0", Offset = "0x7923FA0", VA = "0x1879257A0")]
	private void GHGNAMNFJKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x79251B0", Offset = "0x79239B0", VA = "0x1879251B0")]
	private void CNGLJABOBLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7925850", Offset = "0x7924050", VA = "0x187925850")]
	private void GOBLJNCJIBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7925EE0", Offset = "0x79246E0", VA = "0x187925EE0")]
	private void PMGLKJHINAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7925B80", Offset = "0x7924380", VA = "0x187925B80")]
	private void JBLGHNILGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7925AD0", Offset = "0x79242D0", VA = "0x187925AD0")]
	private void HPKDCONJLMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x79257C0", Offset = "0x7923FC0", VA = "0x1879257C0", Slot = "22")]
	public virtual void GIJIDBCHBEK(FCPBOECGDIL EFJGAMLEOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7925BA0", Offset = "0x79243A0", VA = "0x187925BA0")]
	private void KEJNMGELIEP(DINNBFHMHHL EEBIGFBHEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x221B870", Offset = "0x221A070", VA = "0x18221B870")]
	private DINNBFHMHHL FEIGNEFFPLN(FCPBOECGDIL OCLAPBNMMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract BEPCEBBHGKH FNPAFEHEONF(IEnumerator<IJKEOMMDACC> LCDOHBAOKAL, Behaviour EJOMIDEGKIL, DPJOHDNEBDA PONMPMJLMMH);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract DINNBFHMHHL LKACLFGEKGC(FCPBOECGDIL EFJGAMLEOMN);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x79251D0", Offset = "0x79239D0", VA = "0x1879251D0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7925D90", Offset = "0x7924590", VA = "0x187925D90", Slot = "15")]
	public IJKEOMMDACC MEFLIGHIDNM(FCPBOECGDIL LKAJNMAHFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7925E50", Offset = "0x7924650", VA = "0x187925E50", Slot = "16")]
	public IJKEOMMDACC OIABPIDEOCL(float CKHMGDGNNBB, FCPBOECGDIL LKAJNMAHFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7925DF0", Offset = "0x79245F0", VA = "0x187925DF0", Slot = "17")]
	public IJKEOMMDACC NMMJHLEJANJ(Func<bool> JDBPPNFCIBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal sealed class BEPCEBBHGKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly DPJOHDNEBDA GPMIEMJMELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly HDFONCJJABA IKGPEBFFMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool OFJBPOKMDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private string IKMKCMDHFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private StackTrace OGMHDEHEAPB;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public IEnumerator<IJKEOMMDACC> GIDPBFNPPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IJKEOMMDACC ILCFOOEFICC
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool EGMCJAAPLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x790EA30", Offset = "0x790D230", VA = "0x18790EA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool ILGOELLHGDK
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x997550", Offset = "0x995D50", VA = "0x180997550")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x99EA30", Offset = "0x99D230", VA = "0x18099EA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x790EAB0", Offset = "0x790D2B0", VA = "0x18790EAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float NAKOKMEBPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xC15580", Offset = "0xC13D80", VA = "0x180C15580")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xE6A4D0", Offset = "0xE68CD0", VA = "0x180E6A4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x790F0B0", Offset = "0x790D8B0", VA = "0x18790F0B0")]
	public BEPCEBBHGKH(IEnumerator<IJKEOMMDACC> OICHJCDFLGO, HDFONCJJABA IKGPEBFFMPK, DPJOHDNEBDA GPMIEMJMELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x790EC60", Offset = "0x790D460", VA = "0x18790EC60")]
	public IJKEOMMDACC JPDKPOGLJKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x790E9C0", Offset = "0x790D1C0", VA = "0x18790E9C0")]
	public bool CEEJCLBJINN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x790EF80", Offset = "0x790D780", VA = "0x18790EF80")]
	public void PEICGLEFBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x790EFD0", Offset = "0x790D7D0", VA = "0x18790EFD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x99E930", Offset = "0x99D130", VA = "0x18099E930")]
	[CompilerGenerated]
	private void BOEGBCLIHJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class DPJOHDNEBDA : JGKPNINCKEI, EBBFPAKHIHA, DGGJLAPANLP, MOPOHKAGKCI, IEnumerator, IJKEOMMDACC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private FCPBOECGDIL PECEBDEIILN;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private FCPBOECGDIL OCKHEFDPGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x996E80", Offset = "0x995680", VA = "0x180996E80", Slot = "23")]
		get
		{
			return default(FCPBOECGDIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public FCPBOECGDIL CLGEKLDIAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB0D550", Offset = "0xB0BD50", VA = "0x180B0D550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private float DGJDDBJJOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xB2AED0", Offset = "0xB296D0", VA = "0x180B2AED0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool FNLPLKJEHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7917520", Offset = "0x7915D20", VA = "0x187917520", Slot = "24")]
	private bool PKAKHNHOMMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7917510", Offset = "0x7915D10", VA = "0x187917510", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7917540", Offset = "0x7915D40", VA = "0x187917540")]
	public DPJOHDNEBDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal enum JNANKBFJELM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal sealed class DINNBFHMHHL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum BOMDMKPKOJB
	{
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public struct MKLFDLNGPKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public FCPBOECGDIL AIPFPMCOCFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public BOMDMKPKOJB FPGGAKIKEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public List<BEPCEBBHGKH> BDCHEJOAGEC;
	}

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly BOMDMKPKOJB[] OLBDCDBNGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly FCPBOECGDIL EFJGAMLEOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private bool KPBPBNEJELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly BEPCEBBHGKH[] HBACDPGMKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly List<BEPCEBBHGKH> IIKALHLCACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly Stack<int> OOIAAOAHGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly List<BEPCEBBHGKH> NKNEDIOABBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly Stack<int> NPNGJCFDBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly AECOAGGFDNI CGGOGLCAJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private bool ICKDNMFPFOF;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public MKLFDLNGPKL[,] HOHBMKHPKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8BB220", Offset = "0x8B9A20", VA = "0x1808BB220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7916E70", Offset = "0x7915670", VA = "0x187916E70")]
	public DINNBFHMHHL(FCPBOECGDIL LKAJNMAHFJE, AECOAGGFDNI CGGOGLCAJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7916510", Offset = "0x7914D10", VA = "0x187916510")]
	public void LNGOGLLHPNH(BEPCEBBHGKH OICHJCDFLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7915960", Offset = "0x7914160", VA = "0x187915960")]
	public void AGPPHBJFMMM(IList<BEPCEBBHGKH> AILHOCKBBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7916610", Offset = "0x7914E10", VA = "0x187916610")]
	public void LOGODNIMIAG(IList<BEPCEBBHGKH> AILHOCKBBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7915D60", Offset = "0x7914560", VA = "0x187915D60")]
	private void HEIMJGGMANF(BEPCEBBHGKH OICHJCDFLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7916BB0", Offset = "0x79153B0", VA = "0x187916BB0")]
	private void NMNEBEPAIEE(IList<BEPCEBBHGKH> AILHOCKBBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x79168F0", Offset = "0x79150F0", VA = "0x1879168F0")]
	private JNANKBFJELM MGKMGKNBLFK(BEPCEBBHGKH OICHJCDFLGO)
	{
		return default(JNANKBFJELM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x79163A0", Offset = "0x7914BA0", VA = "0x1879163A0")]
	public void LHNLPLKLOMD(float NFIGBCOCIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7915E50", Offset = "0x7914650", VA = "0x187915E50")]
	public void HFFPCCNFIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7916040", Offset = "0x7914840", VA = "0x187916040")]
	private void JJDBDOJKLOO(List<BEPCEBBHGKH> AILHOCKBBOG, Stack<int> ONLONBDGMHG, bool NKHHCDNGBLE, float PEPCKCFLKCK = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7915C40", Offset = "0x7914440", VA = "0x187915C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7916A70", Offset = "0x7915270", VA = "0x187916A70")]
	private void MMKOEDBBGKP(List<BEPCEBBHGKH> AILHOCKBBOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal class FMANNIIBGOI : AECOAGGFDNI
{
	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "4")]
	public void GDNJOKJINAD(string IKMKCMDHFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
	public void BEBKIGDFNNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public FMANNIIBGOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal class CCDLHMMNJGE : HDFONCJJABA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly Behaviour EJOMIDEGKIL;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x790FF40", Offset = "0x790E740", VA = "0x18790FF40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool JFFJPJACBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x790FFC0", Offset = "0x790E7C0", VA = "0x18790FFC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool FNKNGAPOJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x790FF20", Offset = "0x790E720", VA = "0x18790FF20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public CCDLHMMNJGE(Behaviour EJOMIDEGKIL)
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

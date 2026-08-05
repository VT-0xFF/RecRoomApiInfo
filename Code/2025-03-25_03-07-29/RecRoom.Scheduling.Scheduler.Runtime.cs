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
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8279130", Offset = "0x8278530", VA = "0x188279130", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x827EDB0", Offset = "0x827E1B0", VA = "0x18827EDB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
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
		private delegate List<PlayerLoopSystem> NLOJDENGCIL(List<PlayerLoopSystem> MPFAKACIMFL, int MLGCKFBKIMC);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct JEBFNMGOMJH
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct JEEBAHMJBMA
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static OLDENIALAEA BNMMJGCGAGL;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x8274070", Offset = "0x8273470", VA = "0x188274070")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct MAKIDNIFNGD
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static OLDENIALAEA IFGDCICMHNA;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x82791C0", Offset = "0x82785C0", VA = "0x1882791C0")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct EIAAEDIFAEJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static OLDENIALAEA OAAIEOKCDHH;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x82705F0", Offset = "0x826F9F0", VA = "0x1882705F0")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct DAODFCCNDEF
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static OLDENIALAEA NNAGBCNHEJL;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static OLDENIALAEA BMBELPEPMNA;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static OLDENIALAEA LJKAAEHKFCP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static OLDENIALAEA APGEDFDHCCA;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x826B200", Offset = "0x826A600", VA = "0x18826B200")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct PIIBMHODMJC
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static OLDENIALAEA PEAAJMHGOOC;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x827D8E0", Offset = "0x827CCE0", VA = "0x18827D8E0")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct FEDHPIKDOIA
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static OLDENIALAEA NNAGBCNHEJL;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static OLDENIALAEA BMBELPEPMNA;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static OLDENIALAEA LJKAAEHKFCP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static OLDENIALAEA APGEDFDHCCA;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x82707D0", Offset = "0x826FBD0", VA = "0x1882707D0")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct NKKOHKKLDPA
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static OLDENIALAEA EBMMOPPKBAA;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x827A830", Offset = "0x8279C30", VA = "0x18827A830")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct NLANFJHHFNN
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static OLDENIALAEA MBPCEEEEEAN;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x827AA10", Offset = "0x8279E10", VA = "0x18827AA10")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct BNLIBPKDAJF
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static OLDENIALAEA GPFPJDAIGEG;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x82668B0", Offset = "0x8265CB0", VA = "0x1882668B0")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct POCNODBODBM
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static OLDENIALAEA AGEKEHLOHDL;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x827DAC0", Offset = "0x827CEC0", VA = "0x18827DAC0")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct JIAOOLANEBK
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static OLDENIALAEA CEGCBBAMMPM;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x8274250", Offset = "0x8273650", VA = "0x188274250")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct IGGJCKMLMLA
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static OLDENIALAEA DEKLPAMOHDL;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x8273B30", Offset = "0x8272F30", VA = "0x188273B30")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct IAGJAEEHNLL
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static OLDENIALAEA NKKNEBOAAGM;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x8272410", Offset = "0x8271810", VA = "0x188272410")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct APLDBKLEFMJ
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static OLDENIALAEA PPHMHFOEDMC;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x82639A0", Offset = "0x8262DA0", VA = "0x1882639A0")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct OIPGBMCPJLJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static OLDENIALAEA DHKLJBACGKN;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x827B500", Offset = "0x827A900", VA = "0x18827B500")]
				public static PlayerLoopSystem AMEOHPBFNED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum OPBKJBPCBDB : byte
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
			public struct LNLKDMKNNCC
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class HMHEJJPHFCP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public OPBKJBPCBDB updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
					public HMHEJJPHFCP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x8271FA0", Offset = "0x82713A0", VA = "0x188271FA0")]
					internal void LNBJFHMJDID()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static OHMOKFGANBG<OPBKJBPCBDB> JACHNBEOLJF;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x82788C0", Offset = "0x8277CC0", VA = "0x1882788C0")]
				public static PlayerLoopSystem AMEOHPBFNED(OPBKJBPCBDB IENLANBMMMJ)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct PCHBFFEMOMN
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class NJPNKDBLAEI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public HPEMLNAEDFF.FPPKNLGLCDF key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
					public NJPNKDBLAEI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x827A5B0", Offset = "0x82799B0", VA = "0x18827A5B0")]
					internal void BOBEGOIBIFM()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable GNEPHEIDDMB;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x827D010", Offset = "0x827C410", VA = "0x18827D010")]
				public static PlayerLoopSystem PHMNGJIPLPJ(HPEMLNAEDFF.FPPKNLGLCDF MCBJECJLDOM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct JOGKJJCABPL
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class ILDNMCEFEEB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public HPEMLNAEDFF.FPPKNLGLCDF key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
					public ILDNMCEFEEB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x8273DC0", Offset = "0x82731C0", VA = "0x188273DC0")]
					internal void BOBEGOIBIFM()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x8274430", Offset = "0x8273830", VA = "0x188274430")]
				public static PlayerLoopSystem PHMNGJIPLPJ(HPEMLNAEDFF.FPPKNLGLCDF MCBJECJLDOM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class NEGHJEGMPKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public NEGHJEGMPKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x827A490", Offset = "0x8279890", VA = "0x18827A490")]
			internal List<PlayerLoopSystem> BMPBKAMBMEL(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool NOHAKFHKDEB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool APFLFDFNCDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x826B1C0", Offset = "0x826A5C0", VA = "0x18826B1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8267530", Offset = "0x8266930", VA = "0x188267530")]
		private static void EKAMNAPOKLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x826A670", Offset = "0x8269A70", VA = "0x18826A670")]
		private static void IBMGEJKBBLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8267110", Offset = "0x8266510", VA = "0x188267110")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x826AF80", Offset = "0x826A380", VA = "0x18826AF80")]
		private static void MLJDFHOGCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8266F50", Offset = "0x8266350", VA = "0x188266F50")]
		private static void AIBCGHGBOEP(HPEMLNAEDFF.FPPKNLGLCDF MCBJECJLDOM, PlayerLoopSystem PNELJBMNJOH, Type MPNACIKFLNK, Type CGGDMLLHHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8267150", Offset = "0x8266550", VA = "0x188267150")]
		private static void CEKNPKLOCBJ(PlayerLoopSystem PNELJBMNJOH, Type MPNACIKFLNK, Type CGGDMLLHHKP, NLOJDENGCIL DCICLHJBFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x826A540", Offset = "0x8269940", VA = "0x18826A540")]
		private static void HCEBLGLMLGC(PlayerLoopSystem PNELJBMNJOH, Type MPNACIKFLNK, Type CGGDMLLHHKP, PlayerLoopSystem? NABCMPBDJKM, PlayerLoopSystem? LEDHNMCAEAG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HPEMLNAEDFF
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum FPPKNLGLCDF
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
	public class AKLOCGHCHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly FPPKNLGLCDF IKIIDBDCAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly GJBMPOCOFGD EGGKEHGGDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long AOPHFADCNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long CPGNIMKILHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long FCCPOKKGJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int NJBMCCILLGC;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8263000", Offset = "0x8262400", VA = "0x188263000")]
		public AKLOCGHCHGN(FPPKNLGLCDF DJDACFALICP, int CNAIJKHABIC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8262EB0", Offset = "0x82622B0", VA = "0x188262EB0")]
		public void CHCFALAJONM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8262ED0", Offset = "0x82622D0", VA = "0x188262ED0")]
		public void FCBLCPMBABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8262F20", Offset = "0x8262320", VA = "0x188262F20")]
		public void OGPBNMFJOFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static FPPKNLGLCDF[] JBHENJOJCON;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static AKLOCGHCHGN[] CEBNALGGEOA;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8272020", Offset = "0x8271420", VA = "0x188272020")]
	public static AKLOCGHCHGN FPGJDGJGJFL(FPPKNLGLCDF MCBJECJLDOM, int CNAIJKHABIC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8272210", Offset = "0x8271610", VA = "0x188272210")]
	public static AKLOCGHCHGN JCGFHLJJBLL(FPPKNLGLCDF MCBJECJLDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8272170", Offset = "0x8271570", VA = "0x188272170")]
	public static void GDAOEHKPGNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HFMDAMNFMOF
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface GGCEDFJMCBE
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool EFLHAPHHNLK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AALNGBLOLGO();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class DOEJHHKPAAD : GGCEDFJMCBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action AKLHLNJOCEK;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool EFLHAPHHNLK
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
		public DOEJHHKPAAD(Action AKLHLNJOCEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1031890", Offset = "0x1030C90", VA = "0x181031890", Slot = "5")]
		public void AALNGBLOLGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<GGCEDFJMCBE> IHHIHLDDCMC;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x82718B0", Offset = "0x8270CB0", VA = "0x1882718B0")]
	public static void BKLCDFONJNF(Action AKLHLNJOCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8271D00", Offset = "0x8271100", VA = "0x188271D00")]
	private static void OPKHAOPALDI(GGCEDFJMCBE NGDGOEPBEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8271A20", Offset = "0x8270E20", VA = "0x188271A20")]
	private static void MCDEIKLBLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x82717B0", Offset = "0x8270BB0", VA = "0x1882717B0")]
	private static void BKHMNCCGHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8271950", Offset = "0x8270D50", VA = "0x188271950")]
	private static void HBLJENJACOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class OMDEGDJAAPE
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct BKAHELKFFIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> HOIKCHKIGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string CNIMAACIFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode OCEODMHBGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool KFLPFOEINCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8263E60", Offset = "0x8263260", VA = "0x188263E60")]
		public BKAHELKFFIM(TaskCompletionSource<Scene> CGFKCEOJNHD, string CNIMAACIFLC, LoadSceneMode OCEODMHBGMP, bool KFLPFOEINCD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct ANGCAFGKCEP : IAsyncStateMachine
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
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private HOEFFPEDKPI<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x8263090", Offset = "0x8262490", VA = "0x188263090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8263930", Offset = "0x8262D30", VA = "0x188263930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct ONMFHIFOGFD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x827CCA0", Offset = "0x827C0A0", VA = "0x18827CCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x827CFB0", Offset = "0x827C3B0", VA = "0x18827CFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct EHBBGJPCCME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private BKAHELKFFIM <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x82700C0", Offset = "0x826F4C0", VA = "0x1882700C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8270480", Offset = "0x826F880", VA = "0x188270480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class MCNKLGIENGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BFDPABAFKOD<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MCNKLGIENGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x82793A0", Offset = "0x82787A0", VA = "0x1882793A0")]
		internal void FHJLGDNKNBO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct DFFPMHOGKEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

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
		private MCNKLGIENGK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x826CEE0", Offset = "0x826C2E0", VA = "0x18826CEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x826DA80", Offset = "0x826CE80", VA = "0x18826DA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct GGMMHBEONIF : IAsyncStateMachine
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
		private PEPIFLGHCHM <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8270D10", Offset = "0x8270110", VA = "0x188270D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x82713D0", Offset = "0x82707D0", VA = "0x1882713D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct LJHGOOJGEAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x82773E0", Offset = "0x82767E0", VA = "0x1882773E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8277F00", Offset = "0x8277300", VA = "0x188277F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class LHMDEGLHPGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public BFDPABAFKOD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public LHMDEGLHPGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8276AB0", Offset = "0x8275EB0", VA = "0x188276AB0")]
		internal bool NNFICIBBJHE(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8276850", Offset = "0x8275C50", VA = "0x188276850")]
		internal void KJMOGHEJMFO(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LKAHENCEBCK : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public BFDPABAFKOD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private LHMDEGLHPGF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private PEPIFLGHCHM <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public LKAHENCEBCK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8278860", Offset = "0x8277C60", VA = "0x188278860", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8277F90", Offset = "0x8277390", VA = "0x188277F90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8277F70", Offset = "0x8277370", VA = "0x188277F70")]
		private void KNMHCFDKFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8278810", Offset = "0x8277C10", VA = "0x188278810", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> MNPGJFKCEHC;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static KMDOHMPCNFD HMIJKGOMBFH;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation PICGNJNJLNM;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static KMDOHMPCNFD NEDCJPEOCDI;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string DFBAPNGJKND;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string HPGNGKPDAPK;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority NGGHGKOKPPE;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task DFMKKFDALGI;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> OAOLCHCMAJH;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<BKAHELKFFIM> NKBFLOLLLHD;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task IBNNBNLIIMJ;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> GGLAPPPBLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x827B910", Offset = "0x827AD10", VA = "0x18827B910")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x827BEE0", Offset = "0x827B2E0", VA = "0x18827BEE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x827C430", Offset = "0x827B830", VA = "0x18827C430")]
	[OICEKCKHJCF(OFNMMDPFAJG.EnteredEditModeNextFrame, 0)]
	private static void JLNDPENGEHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x827C140", Offset = "0x827B540", VA = "0x18827C140")]
	[AsyncStateMachine(typeof(ANGCAFGKCEP))]
	public static Task<Scene> INJODMPNMKK(string CNIMAACIFLC, LoadSceneMode OCEODMHBGMP = LoadSceneMode.Single, bool KFLPFOEINCD = false, [Optional] HOEFFPEDKPI<string>.AEKMEBIOPMA JKBNGHEICMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x827C380", Offset = "0x827B780", VA = "0x18827C380")]
	[AsyncStateMachine(typeof(ONMFHIFOGFD))]
	private static Task JLCGEEBFDGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x827C650", Offset = "0x827BA50", VA = "0x18827C650")]
	[AsyncStateMachine(typeof(EHBBGJPCCME))]
	private static Task LMHPDILFIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x827BFF0", Offset = "0x827B3F0", VA = "0x18827BFF0")]
	[AsyncStateMachine(typeof(DFFPMHOGKEH))]
	private static Task<Scene> HHLPMHALEOL(string CNIMAACIFLC, LoadSceneMode OCEODMHBGMP, bool KFLPFOEINCD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x827BC60", Offset = "0x827B060", VA = "0x18827BC60")]
	private static void FBLCEPLDIGL(SceneInstance MOAEMAHGOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x827C7E0", Offset = "0x827BBE0", VA = "0x18827C7E0")]
	private static void OMCDKGOKPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x827BB30", Offset = "0x827AF30", VA = "0x18827BB30")]
	[AsyncStateMachine(typeof(GGMMHBEONIF))]
	private static Task<Scene> EIACLFIFEBE(string CNIMAACIFLC, LoadSceneMode OCEODMHBGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x827C290", Offset = "0x827B690", VA = "0x18827C290")]
	private static bool JACLDNODDHA(string CNIMAACIFLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x827BA20", Offset = "0x827AE20", VA = "0x18827BA20")]
	[AsyncStateMachine(typeof(LJHGOOJGEAD))]
	private static Task<Scene> EGNCODJFIII(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x827BD60", Offset = "0x827B160", VA = "0x18827BD60")]
	public static COLCOEKKCIF<Scene> GBHMBFDEAFL(string CNIMAACIFLC, LoadSceneMode OCEODMHBGMP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x827B810", Offset = "0x827AC10", VA = "0x18827B810")]
	[IteratorStateMachine(typeof(LKAHENCEBCK))]
	private static IEnumerator<OAGIBKDGOAG> DIMCPHCGIOM(string CNIMAACIFLC, LoadSceneMode OCEODMHBGMP, BFDPABAFKOD<Scene> NDBCOIJMEBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x827B8B0", Offset = "0x827ACB0", VA = "0x18827B8B0")]
	public static void DOANGNMMCDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x827C720", Offset = "0x827BB20", VA = "0x18827C720")]
	private static void OKEOGEIIEOI(string CNIMAACIFLC, LoadSceneMode OCEODMHBGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x827C520", Offset = "0x827B920", VA = "0x18827C520")]
	public static bool JNJHFNNPJAE([Out] string PKMHDPBIGJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class PEEGKEDNEHK
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x827D7D0", Offset = "0x827CBD0", VA = "0x18827D7D0")]
	public static IDisposable BEMCNBOCGHO(this NACLFHGEHGD PFPNPMCGHHC, float ACECLMIBACD, Action<float> FIEDJHDADEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x827D860", Offset = "0x827CC60", VA = "0x18827D860")]
	public static IDisposable DMDMICPIKPC(this NACLFHGEHGD PFPNPMCGHHC, Action<float> FIEDJHDADEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x827D750", Offset = "0x827CB50", VA = "0x18827D750")]
	public static IDisposable AEJEDCAALBL(this NACLFHGEHGD PFPNPMCGHHC, Action<float> FIEDJHDADEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LCMFHBPOLNB
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x36BBBE0", Offset = "0x36BAFE0", VA = "0x1836BBBE0")]
	[PALPEKBAJGH]
	public static IDisposable PAOBDNLEGJH<T>(this T DBFKLCEDAMM, Action FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x36BBD90", Offset = "0x36BB190", VA = "0x1836BBD90")]
	[PALPEKBAJGH]
	public static IDisposable PAOBDNLEGJH<T>(this T DBFKLCEDAMM, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x36BB9A0", Offset = "0x36BADA0", VA = "0x1836BB9A0")]
	[PALPEKBAJGH]
	public static IDisposable NABACIPFMBC<T>(this T DBFKLCEDAMM, Action FIEDJHDADEB, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x36BB7E0", Offset = "0x36BABE0", VA = "0x1836BB7E0")]
	[PALPEKBAJGH]
	public static IDisposable KKMCDFOMKLI<T>(this T DBFKLCEDAMM, Action FIEDJHDADEB, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x36BB7E0", Offset = "0x36BABE0", VA = "0x1836BB7E0")]
	[PALPEKBAJGH]
	public static IDisposable KKMCDFOMKLI<T>(this T DBFKLCEDAMM, Action<float> FIEDJHDADEB, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x36BB5E0", Offset = "0x36BA9E0", VA = "0x1836BB5E0")]
	[PALPEKBAJGH]
	public static IDisposable ELFFHLIGMLL<T>(this T DBFKLCEDAMM, Action FIEDJHDADEB, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x36BB890", Offset = "0x36BAC90", VA = "0x1836BB890")]
	[PALPEKBAJGH]
	public static IDisposable LHCOPBFODBD<T>(this T DBFKLCEDAMM, Action FIEDJHDADEB, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x36BB4D0", Offset = "0x36BA8D0", VA = "0x1836BB4D0")]
	[PALPEKBAJGH]
	public static IDisposable BGDMMEANDIB<T>(this T DBFKLCEDAMM, Action FIEDJHDADEB, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x36BB750", Offset = "0x36BAB50", VA = "0x1836BB750")]
	[PALPEKBAJGH]
	public static IDisposable JEFOFEEBNLK<T>(this T DBFKLCEDAMM, float ACECLMIBACD, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8276670", Offset = "0x8275A70", VA = "0x188276670")]
	[PALPEKBAJGH]
	public static IDisposable JEFOFEEBNLK(this MonoBehaviour DBFKLCEDAMM, OKEGJBDPDCK PFPNPMCGHHC, float ACECLMIBACD, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x36BBA30", Offset = "0x36BAE30", VA = "0x1836BBA30")]
	[PALPEKBAJGH]
	public static IDisposable NMAFLPGJCJK<T>(this T DBFKLCEDAMM, float ACECLMIBACD, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x36BB790", Offset = "0x36BAB90", VA = "0x1836BB790")]
	[PALPEKBAJGH]
	public static IDisposable JEJMDAIIPEA<T>(this T DBFKLCEDAMM, float ACECLMIBACD, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x36BB580", Offset = "0x36BA980", VA = "0x1836BB580")]
	[PALPEKBAJGH]
	public static IDisposable EBKDGEJMHCO<T>(this T DBFKLCEDAMM, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x36BB470", Offset = "0x36BA870", VA = "0x1836BB470")]
	[PALPEKBAJGH]
	public static IDisposable ADAGPLBILAL<T>(this T DBFKLCEDAMM, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x36BB940", Offset = "0x36BAD40", VA = "0x1836BB940")]
	[PALPEKBAJGH]
	public static IDisposable MOABGCJMJOL<T>(this T DBFKLCEDAMM, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x36BB690", Offset = "0x36BAA90", VA = "0x1836BB690")]
	[PALPEKBAJGH]
	public static IDisposable GCJJNKJGMEJ<T>(this T DBFKLCEDAMM, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x36BB830", Offset = "0x36BAC30", VA = "0x1836BB830")]
	[PALPEKBAJGH]
	public static IDisposable LGEDEGAMEHM<T>(this T DBFKLCEDAMM, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x36BB8E0", Offset = "0x36BACE0", VA = "0x1836BB8E0")]
	[PALPEKBAJGH]
	public static IDisposable MGEDJEPPAIP<T>(this T DBFKLCEDAMM, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x36BB520", Offset = "0x36BA920", VA = "0x1836BB520")]
	[PALPEKBAJGH]
	public static IDisposable CHEDOMCCKNA<T>(this T DBFKLCEDAMM, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x36BB9E0", Offset = "0x36BADE0", VA = "0x1836BB9E0")]
	[PALPEKBAJGH]
	public static IDisposable NAOAPNOFFOC<T>(this T DBFKLCEDAMM, float ACECLMIBACD, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x36BB6F0", Offset = "0x36BAAF0", VA = "0x1836BB6F0")]
	[PALPEKBAJGH]
	public static IDisposable IKCLIFKLCIP<T>(this T DBFKLCEDAMM, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x36BB630", Offset = "0x36BAA30", VA = "0x1836BB630")]
	[PALPEKBAJGH]
	public static IDisposable FDOEHPCHIAG<T>(this T DBFKLCEDAMM, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true) where T : MonoBehaviour, OKEGJBDPDCK
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class AAPIINHBJNO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class OLPDDLMFHDL : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public OIKDKHDKGAI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private HJIMMLNLINA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public OLPDDLMFHDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x827B6E0", Offset = "0x827AAE0", VA = "0x18827B6E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x827B7C0", Offset = "0x827ABC0", VA = "0x18827B7C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class BFCIHPJHNKO : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public OIKDKHDKGAI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private HJIMMLNLINA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public BFCIHPJHNKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8263C40", Offset = "0x8263040", VA = "0x188263C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8263D30", Offset = "0x8263130", VA = "0x188263D30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x82622A0", Offset = "0x82616A0", VA = "0x1882622A0")]
	public static INGHODAMJIF PAOBDNLEGJH(Action FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8262130", Offset = "0x8261530", VA = "0x188262130")]
	public static INGHODAMJIF PAOBDNLEGJH(Behaviour PFPNPMCGHHC, Action FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x82621C0", Offset = "0x82615C0", VA = "0x1882621C0")]
	public static INGHODAMJIF PAOBDNLEGJH(Behaviour PFPNPMCGHHC, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x82620A0", Offset = "0x82614A0", VA = "0x1882620A0")]
	[IteratorStateMachine(typeof(OLPDDLMFHDL))]
	private static IEnumerator<OAGIBKDGOAG> AGKCHMFAPLD(OIKDKHDKGAI ODLBJDGPLAE, Action FIEDJHDADEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8262010", Offset = "0x8261410", VA = "0x188262010")]
	[IteratorStateMachine(typeof(BFCIHPJHNKO))]
	private static IEnumerator<OAGIBKDGOAG> AGKCHMFAPLD(OIKDKHDKGAI ODLBJDGPLAE, Action<float> FIEDJHDADEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class GLFEMAIHMPK : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class BGGPHDENNPF : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public GLFEMAIHMPK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public BGGPHDENNPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8263D80", Offset = "0x8263180", VA = "0x188263D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8263E10", Offset = "0x8263210", VA = "0x188263E10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly OIKDKHDKGAI FJEPJKOEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action BIIFGFJHGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool FFCJFAOKMAO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool OKPEPBABHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9932A0", Offset = "0x9926A0", VA = "0x1809932A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8271560", Offset = "0x8270960", VA = "0x188271560")]
	public GLFEMAIHMPK(OIKDKHDKGAI FJEPJKOEMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8271440", Offset = "0x8270840", VA = "0x188271440")]
	[IteratorStateMachine(typeof(BGGPHDENNPF))]
	private IEnumerator<OAGIBKDGOAG> ICFJBMPAHOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x82714C0", Offset = "0x82708C0", VA = "0x1882714C0", Slot = "4")]
	public void OnCompleted(Action LAKFHCOEMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	public void AFBAOFBCOBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class FMICLKMJKOC
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8270AE0", Offset = "0x826FEE0", VA = "0x188270AE0")]
	public static GLFEMAIHMPK JAGFCPCIBCF(this OIKDKHDKGAI FJEPJKOEMOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class PDHJCLNKNIO
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class PDEPDKAPLGM : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public GCLILABBIDM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public PDEPDKAPLGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x827D140", Offset = "0x827C540", VA = "0x18827D140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x827D1C0", Offset = "0x827C5C0", VA = "0x18827D1C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x827D650", Offset = "0x827CA50", VA = "0x18827D650")]
	public static INGHODAMJIF PAOBDNLEGJH(float ACECLMIBACD, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, bool IHBMEIGDNJL = true, [Optional] FHPPEPKAGLN DAEKJIAFOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x827D580", Offset = "0x827C980", VA = "0x18827D580")]
	public static INGHODAMJIF PAOBDNLEGJH(MonoBehaviour DBFKLCEDAMM, float ACECLMIBACD, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, bool IHBMEIGDNJL = true, [Optional] FHPPEPKAGLN DAEKJIAFOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x827D490", Offset = "0x827C890", VA = "0x18827D490")]
	public static INGHODAMJIF OLPMPELEHHL(MonoBehaviour DBFKLCEDAMM, float ACECLMIBACD, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, bool IHBMEIGDNJL = true, [Optional] FHPPEPKAGLN DAEKJIAFOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x827D3C0", Offset = "0x827C7C0", VA = "0x18827D3C0")]
	public static INGHODAMJIF MMINHJIAFID(NACLFHGEHGD PFPNPMCGHHC, float ACECLMIBACD, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, bool IHBMEIGDNJL = true, [Optional] FHPPEPKAGLN DAEKJIAFOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x827D210", Offset = "0x827C610", VA = "0x18827D210")]
	private static IEnumerator<OAGIBKDGOAG> AGKCHMFAPLD(JNGKOLBKIBG PMMLKFODIOB, float ACECLMIBACD, OIKDKHDKGAI ODLBJDGPLAE, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x827D2D0", Offset = "0x827C6D0", VA = "0x18827D2D0")]
	private static IEnumerator<OAGIBKDGOAG> BKFMNLKCNFB(JNGKOLBKIBG PMMLKFODIOB, float ACECLMIBACD, OIKDKHDKGAI ODLBJDGPLAE, Action<float> FIEDJHDADEB, bool IHBMEIGDNJL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x827D330", Offset = "0x827C730", VA = "0x18827D330")]
	[IteratorStateMachine(typeof(PDEPDKAPLGM))]
	private static IEnumerator<OAGIBKDGOAG> JOOOANIHLML(GCLILABBIDM FOOPADPDMEK, float ACECLMIBACD, OIKDKHDKGAI ODLBJDGPLAE, Action<float> FIEDJHDADEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class KIDONDAEDFA
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class EHMBJCPBECC : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public OIKDKHDKGAI queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public EHMBJCPBECC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x82704E0", Offset = "0x826F8E0", VA = "0x1882704E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x82705A0", Offset = "0x826F9A0", VA = "0x1882705A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8275B50", Offset = "0x8274F50", VA = "0x188275B50")]
	[IteratorStateMachine(typeof(EHMBJCPBECC))]
	private static IEnumerator<OAGIBKDGOAG> DPJNFEJDHAJ(OIKDKHDKGAI FJEPJKOEMOI, Func<bool> IJHHPJHHECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8275BE0", Offset = "0x8274FE0", VA = "0x188275BE0")]
	public static INGHODAMJIF LKBECOPOLAK(this MonoBehaviour DBFKLCEDAMM, Func<bool> IJHHPJHHECF, OIKDKHDKGAI FJEPJKOEMOI = OIKDKHDKGAI.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class DKBCDNBOGJB
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class IGDMGOHHOJJ : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public OIKDKHDKGAI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public IGDMGOHHOJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8273A70", Offset = "0x8272E70", VA = "0x188273A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8273AE0", Offset = "0x8272EE0", VA = "0x188273AE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class ICADMLMPAPI<T> : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public OIKDKHDKGAI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public ICADMLMPAPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x49AD610", Offset = "0x49ACA10", VA = "0x1849AD610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x49AD6B0", Offset = "0x49ACAB0", VA = "0x1849AD6B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class DHAKAJHIDJK : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public OIKDKHDKGAI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private OAGIBKDGOAG <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public DHAKAJHIDJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x826DAF0", Offset = "0x826CEF0", VA = "0x18826DAF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x826DB80", Offset = "0x826CF80", VA = "0x18826DB80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x826E620", Offset = "0x826DA20", VA = "0x18826E620")]
	[IteratorStateMachine(typeof(IGDMGOHHOJJ))]
	private static IEnumerator<OAGIBKDGOAG> ICFJBMPAHOP(float LLAIDEDFOJF, OIKDKHDKGAI ODLBJDGPLAE, Action HGCIPPLBBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3417BF0", Offset = "0x3416FF0", VA = "0x183417BF0")]
	[IteratorStateMachine(typeof(ICADMLMPAPI<>))]
	private static IEnumerator<OAGIBKDGOAG> ICFJBMPAHOP<T>(float LLAIDEDFOJF, OIKDKHDKGAI ODLBJDGPLAE, Action<T> HGCIPPLBBMM, T PKKPPHDAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x826E890", Offset = "0x826DC90", VA = "0x18826E890")]
	[IteratorStateMachine(typeof(DHAKAJHIDJK))]
	private static IEnumerator<OAGIBKDGOAG> MDHMNELHHFP(float LLAIDEDFOJF, OIKDKHDKGAI ODLBJDGPLAE, Action HGCIPPLBBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x826E6C0", Offset = "0x826DAC0", VA = "0x18826E6C0")]
	public static IDisposable LFIPABIOMDE(this MonoBehaviour DBFKLCEDAMM, float LLAIDEDFOJF, Action HGCIPPLBBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x826E130", Offset = "0x826D530", VA = "0x18826E130")]
	public static INGHODAMJIF BGOIPAOLLKK(this MonoBehaviour DBFKLCEDAMM, float LLAIDEDFOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x826E7A0", Offset = "0x826DBA0", VA = "0x18826E7A0")]
	public static INGHODAMJIF LFIPABIOMDE(this MonoBehaviour DBFKLCEDAMM, float LLAIDEDFOJF, OIKDKHDKGAI ODLBJDGPLAE, Action HGCIPPLBBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x826E440", Offset = "0x826D840", VA = "0x18826E440")]
	public static INGHODAMJIF HIIIGJELENN(this MonoBehaviour DBFKLCEDAMM, Action HGCIPPLBBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3417BA0", Offset = "0x3416FA0", VA = "0x183417BA0")]
	public static INGHODAMJIF HIIIGJELENN<T>(this MonoBehaviour DBFKLCEDAMM, Action<T> HGCIPPLBBMM, T PKKPPHDAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x826E9D0", Offset = "0x826DDD0", VA = "0x18826E9D0")]
	public static INGHODAMJIF NODGJJJAMBM(this MonoBehaviour DBFKLCEDAMM, Action HGCIPPLBBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x826E1C0", Offset = "0x826D5C0", VA = "0x18826E1C0")]
	public static INGHODAMJIF CEIEKKPMPDE(this MonoBehaviour DBFKLCEDAMM, Action HGCIPPLBBMM, [Optional] FHPPEPKAGLN DAEKJIAFOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x826E300", Offset = "0x826D700", VA = "0x18826E300")]
	public static INGHODAMJIF ECLDLNKJJGM(this MonoBehaviour DBFKLCEDAMM, Action HGCIPPLBBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x826E3A0", Offset = "0x826D7A0", VA = "0x18826E3A0")]
	public static INGHODAMJIF HCCFFGCGIPH(this MonoBehaviour DBFKLCEDAMM, Action HGCIPPLBBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x826E930", Offset = "0x826DD30", VA = "0x18826E930")]
	public static INGHODAMJIF NLMHBICNKBB(MonoBehaviour DBFKLCEDAMM, OIKDKHDKGAI FJEPJKOEMOI, Action HGCIPPLBBMM, [Optional] FHPPEPKAGLN DAEKJIAFOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3417CD0", Offset = "0x34170D0", VA = "0x183417CD0")]
	public static INGHODAMJIF NLMHBICNKBB<T>(MonoBehaviour DBFKLCEDAMM, OIKDKHDKGAI FJEPJKOEMOI, Action<T> HGCIPPLBBMM, T PKKPPHDAMAG, [Optional] FHPPEPKAGLN DAEKJIAFOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x826E0A0", Offset = "0x826D4A0", VA = "0x18826E0A0")]
	public static INGHODAMJIF BAJJMIPOKNA(this MonoBehaviour DBFKLCEDAMM, float PKOIOHJFDOM, Action HGCIPPLBBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x826E580", Offset = "0x826D980", VA = "0x18826E580")]
	public static INGHODAMJIF HNJGEGJBAMG(this MonoBehaviour DBFKLCEDAMM, float PKOIOHJFDOM, Action HGCIPPLBBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x826E260", Offset = "0x826D660", VA = "0x18826E260")]
	public static INGHODAMJIF DPIOLJGLEFI(this MonoBehaviour DBFKLCEDAMM, float PKOIOHJFDOM, Action HGCIPPLBBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x826E4E0", Offset = "0x826D8E0", VA = "0x18826E4E0")]
	public static INGHODAMJIF HJOEMDMOICI(this MonoBehaviour DBFKLCEDAMM, float PKOIOHJFDOM, Action HGCIPPLBBMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class MPGOCIAJADH : MJHGAABFBGH, IEnumerable<MJHGAABFBGH>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<MJHGAABFBGH> JLHOFILPGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool LGKBADBFFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action AHHLPKDCECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool IDEODLELBGJ;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CGFIPNIENPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8279820", Offset = "0x8278C20", VA = "0x188279820", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NJGGAKJFHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8279480", Offset = "0x8278880", VA = "0x188279480", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8279C60", Offset = "0x8279060", VA = "0x188279C60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8279D00", Offset = "0x8279100", VA = "0x188279D00")]
	public MPGOCIAJADH([Optional] Action AHHLPKDCECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x82796F0", Offset = "0x8278AF0", VA = "0x1882796F0")]
	public void LLICHLCEEGA(MJHGAABFBGH GAMAGLENBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x82795A0", Offset = "0x82789A0", VA = "0x1882795A0")]
	private void LJMLPKGPAPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8279950", Offset = "0x8278D50", VA = "0x188279950", Slot = "7")]
	public bool MNEAAHFDBDD(bool HEGINIGEJIB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8279960", Offset = "0x8278D60", VA = "0x188279960", Slot = "8")]
	public bool MNEAAHFDBDD(Action AKLHLNJOCEK, bool HEGINIGEJIB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8279520", Offset = "0x8278920", VA = "0x188279520", Slot = "9")]
	public IEnumerator<MJHGAABFBGH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8279520", Offset = "0x8278920", VA = "0x188279520", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OGELHCIKGCH : NACEFHKLMDB
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class JODBIKBCBKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public OGELHCIKGCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public JODBIKBCBKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8273A40", Offset = "0x8272E40", VA = "0x188273A40")]
		internal void KEDDIGMNGOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class IFNAJLMDEEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public OGELHCIKGCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IFNAJLMDEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8273A40", Offset = "0x8272E40", VA = "0x188273A40")]
		internal void OGLMFDKKNJI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float MAJKMAMBIGK;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x8271670", Offset = "0x8270A70", VA = "0x188271670")]
	public OGELHCIKGCH(Behaviour PFPNPMCGHHC, float MAJKMAMBIGK, [Optional] Action AHHLPKDCECB, [Optional] FHPPEPKAGLN DAEKJIAFOBL, [Optional] JNGKOLBKIBG PMMLKFODIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x827B2E0", Offset = "0x827A6E0", VA = "0x18827B2E0", Slot = "9")]
	protected override bool GGODKOIFAOK(Action AKLHLNJOCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x827B3F0", Offset = "0x827A7F0", VA = "0x18827B3F0", Slot = "10")]
	protected override bool GIGCLDNPKNF(Action AKLHLNJOCEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface MJHGAABFBGH
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool CGFIPNIENPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NJGGAKJFHIK;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MNEAAHFDBDD(bool HEGINIGEJIB = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MNEAAHFDBDD(Action AKLHLNJOCEK, bool HEGINIGEJIB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class NACEFHKLMDB : MJHGAABFBGH
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class GAIFILKAPEM : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public NACEFHKLMDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public GAIFILKAPEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8270BF0", Offset = "0x826FFF0", VA = "0x188270BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8270CC0", Offset = "0x82700C0", VA = "0x188270CC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour PFPNPMCGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action AHHLPKDCECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private KPNDCLGPJDN HPLDDHFEIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly FHPPEPKAGLN DAEKJIAFOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly JNGKOLBKIBG PMMLKFODIOB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool CGFIPNIENPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x18FA020", Offset = "0x18F9420", VA = "0x1818FA020", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NJGGAKJFHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8279DC0", Offset = "0x82791C0", VA = "0x188279DC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x827A2C0", Offset = "0x82796C0", VA = "0x18827A2C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x827A360", Offset = "0x8279760", VA = "0x18827A360")]
	protected NACEFHKLMDB(Behaviour PFPNPMCGHHC, [Optional] Action AHHLPKDCECB, [Optional] FHPPEPKAGLN DAEKJIAFOBL, [Optional] JNGKOLBKIBG PMMLKFODIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x827A200", Offset = "0x8279600", VA = "0x18827A200", Slot = "7")]
	public bool MNEAAHFDBDD(bool HEGINIGEJIB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x827A260", Offset = "0x8279660", VA = "0x18827A260", Slot = "8")]
	public bool MNEAAHFDBDD(Action AKLHLNJOCEK, bool HEGINIGEJIB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GGODKOIFAOK(Action AKLHLNJOCEK);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool GIGCLDNPKNF(Action AKLHLNJOCEK);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8279DA0", Offset = "0x82791A0", VA = "0x188279DA0")]
	protected void AHNEBNFLLAH(Action AKLHLNJOCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8279EE0", Offset = "0x82792E0", VA = "0x188279EE0")]
	protected KMDOHMPCNFD IDKJLJNGIMB(float DAJECHOKOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8279E60", Offset = "0x8279260", VA = "0x188279E60")]
	private void DLIEGDBLNFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x827A130", Offset = "0x8279530", VA = "0x18827A130")]
	[IteratorStateMachine(typeof(GAIFILKAPEM))]
	private IEnumerator<OAGIBKDGOAG> JKCJJMPKCPE(float DAJECHOKOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x827A1C0", Offset = "0x82795C0", VA = "0x18827A1C0")]
	[CompilerGenerated]
	private void KBLDDAMCJGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class KNIHFDELHGI : NACEFHKLMDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float KGJEJEPBFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int GNBFMMJGELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float MELAHMGDIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] PIPEPENEBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int DOFCLFAAAHB;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8275F40", Offset = "0x8275340", VA = "0x188275F40")]
	public KNIHFDELHGI(Behaviour PFPNPMCGHHC, float DBPLEMMCNNJ, int GNBFMMJGELJ, [Optional] Action AHHLPKDCECB, float MELAHMGDIFI = 0f, [Optional] FHPPEPKAGLN DAEKJIAFOBL, [Optional] JNGKOLBKIBG PMMLKFODIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "9")]
	protected override bool GGODKOIFAOK(Action AKLHLNJOCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8275CC0", Offset = "0x82750C0", VA = "0x188275CC0", Slot = "10")]
	protected override bool GIGCLDNPKNF(Action AKLHLNJOCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8275EC0", Offset = "0x82752C0", VA = "0x188275EC0")]
	private void PIIJFJFPBEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HFBFAJIMJGO : NACEFHKLMDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float MAJKMAMBIGK;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8271670", Offset = "0x8270A70", VA = "0x188271670")]
	public HFBFAJIMJGO(Behaviour PFPNPMCGHHC, float MAJKMAMBIGK, [Optional] Action AHHLPKDCECB, [Optional] FHPPEPKAGLN DAEKJIAFOBL, [Optional] JNGKOLBKIBG PMMLKFODIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "9")]
	protected override bool GGODKOIFAOK(Action AKLHLNJOCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8271630", Offset = "0x8270A30", VA = "0x188271630", Slot = "10")]
	protected override bool GIGCLDNPKNF(Action AKLHLNJOCEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class ODMPINLCLBA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class OBKIILGIBPB : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public OBKIILGIBPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8263B80", Offset = "0x8262F80", VA = "0x188263B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x827ABF0", Offset = "0x8279FF0", VA = "0x18827ABF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private INGHODAMJIF NHNHJFJAGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NACLFHGEHGD PFPNPMCGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> JMLINPGPAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private OIKDKHDKGAI FJEPJKOEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float ALDGOGPANOM;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x827B140", Offset = "0x827A540", VA = "0x18827B140")]
	public ODMPINLCLBA(NACLFHGEHGD PFPNPMCGHHC, float ACECLMIBACD, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x827AEA0", Offset = "0x827A2A0", VA = "0x18827AEA0")]
	private void HIEPCPHMGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x827B010", Offset = "0x827A410", VA = "0x18827B010")]
	private void NLIPOMNFPMB(string DFEFGBECJNJ, Action OKFPMAFPHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x827ADC0", Offset = "0x827A1C0", VA = "0x18827ADC0")]
	[IteratorStateMachine(typeof(OBKIILGIBPB))]
	private IEnumerator<OAGIBKDGOAG> CFKFPKCKLHM(Action OKFPMAFPHGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x827AE40", Offset = "0x827A240", VA = "0x18827AE40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x827AC40", Offset = "0x827A040", VA = "0x18827AC40")]
	[CompilerGenerated]
	private void BAPJIOONKMI(string MIJGFNBACFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class ECMIDHLOBPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BAJGMMGCJJJ : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public BAJGMMGCJJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8263B80", Offset = "0x8262F80", VA = "0x188263B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8263BF0", Offset = "0x8262FF0", VA = "0x188263BF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private INGHODAMJIF NHNHJFJAGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour DBFKLCEDAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action FIEDJHDADEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> JMLINPGPAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private OIKDKHDKGAI FJEPJKOEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float ALDGOGPANOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool IHBMEIGDNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly FHPPEPKAGLN DAEKJIAFOBL;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x826FB80", Offset = "0x826EF80", VA = "0x18826FB80")]
	public ECMIDHLOBPI(MonoBehaviour DBFKLCEDAMM, Action FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, [Optional] FHPPEPKAGLN DAEKJIAFOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x826FEF0", Offset = "0x826F2F0", VA = "0x18826FEF0")]
	public ECMIDHLOBPI(MonoBehaviour DBFKLCEDAMM, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, [Optional] FHPPEPKAGLN DAEKJIAFOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x826FD10", Offset = "0x826F110", VA = "0x18826FD10")]
	public ECMIDHLOBPI(MonoBehaviour DBFKLCEDAMM, float ACECLMIBACD, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, bool IHBMEIGDNJL = true, [Optional] FHPPEPKAGLN DAEKJIAFOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x49419D0", Offset = "0x4940DD0", VA = "0x1849419D0")]
	private ECMIDHLOBPI(FHPPEPKAGLN DAEKJIAFOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x826F660", Offset = "0x826EA60", VA = "0x18826F660")]
	internal static ECMIDHLOBPI NIFPFOOMIKN(MonoBehaviour DBFKLCEDAMM, float ACECLMIBACD, Action<float> FIEDJHDADEB, OIKDKHDKGAI FJEPJKOEMOI, bool IHBMEIGDNJL = true, [Optional] FHPPEPKAGLN DAEKJIAFOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x826F9C0", Offset = "0x826EDC0", VA = "0x18826F9C0")]
	private void PAOBDNLEGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x826F4E0", Offset = "0x826E8E0", VA = "0x18826F4E0")]
	private void KCJGFHGADOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x826F2E0", Offset = "0x826E6E0", VA = "0x18826F2E0")]
	private void HIEPCPHMGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x826F0C0", Offset = "0x826E4C0", VA = "0x18826F0C0")]
	private void FDBGOKNFMGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x826F890", Offset = "0x826EC90", VA = "0x18826F890")]
	private void NLIPOMNFPMB(string DFEFGBECJNJ, Action OKFPMAFPHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x826EF50", Offset = "0x826E350", VA = "0x18826EF50")]
	[IteratorStateMachine(typeof(BAJGMMGCJJJ))]
	private IEnumerator<OAGIBKDGOAG> CFKFPKCKLHM(Action OKFPMAFPHGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x826F060", Offset = "0x826E460", VA = "0x18826F060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x826EFD0", Offset = "0x826E3D0", VA = "0x18826EFD0")]
	[CompilerGenerated]
	private void DCPEPMFDABH(string MIJGFNBACFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x826F250", Offset = "0x826E650", VA = "0x18826F250")]
	[CompilerGenerated]
	private void GPKPJGHOHME(string MIJGFNBACFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x826F450", Offset = "0x826E850", VA = "0x18826F450")]
	[CompilerGenerated]
	private void JLAKNJIPBHA(string MIJGFNBACFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x826FAF0", Offset = "0x826EEF0", VA = "0x18826FAF0")]
	[CompilerGenerated]
	private void PPGPEODNBIC(string MIJGFNBACFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum ILHNNHFLHGI : byte
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
internal sealed class IIKPHMMMJBD : JNGKOLBKIBG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float NHOMJLBLCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8273DA0", Offset = "0x82731A0", VA = "0x188273DA0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float MCBFNPKODBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8273DB0", Offset = "0x82731B0", VA = "0x188273DB0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double IMEENKEODNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8273D80", Offset = "0x8273180", VA = "0x188273D80", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8273D10", Offset = "0x8273110", VA = "0x188273D10")]
	[BOBPNFIGGBE.NBDKKMMHNGD]
	internal static void KDIILJNJDKF(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	[UnityEngine.Scripting.Preserve]
	internal IIKPHMMMJBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface BAKHOJLBLDN
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACLIBNMNCMI(string MPGDCPPMNJN);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDNPOBMJKHL();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface HOFHBEHCLFN
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool EEIEAOPBBGM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool MEBELHELFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class DHIJIGJEDIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public BNHDHHNLONF CDDNONIMMKK;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int BNBIOAJGDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9901A0", Offset = "0x98F5A0", VA = "0x1809901A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9A02E0", Offset = "0x99F6E0", VA = "0x1809A02E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x826DC90", Offset = "0x826D090", VA = "0x18826DC90")]
	public static OAGIBKDGOAG ABHMDAJBPEI(IEnumerator<OAGIBKDGOAG> LNALIJLNNJF, MGKLMINDLII FECBEAAGNBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x826DBD0", Offset = "0x826CFD0", VA = "0x18826DBD0")]
	public OAGIBKDGOAG ABHMDAJBPEI(MGKLMINDLII[] HBHDGCOOODN, IEnumerator<OAGIBKDGOAG>[] ECJPPLKMBMK, OAGIBKDGOAG[] NBNNMDLKCAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x826E070", Offset = "0x826D470", VA = "0x18826E070")]
	public void PIFBGFMCOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x826DDF0", Offset = "0x826D1F0", VA = "0x18826DDF0")]
	public void FDABHDBHNAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x826DF30", Offset = "0x826D330", VA = "0x18826DF30")]
	public void JENEMBLFKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x826E070", Offset = "0x826D470", VA = "0x18826E070")]
	public void MDEFFPJLFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public DHIJIGJEDIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class BNHDHHNLONF
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct LHPFGDBHGPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public DHIJIGJEDIF OBFIHHGMPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public NACLFHGEHGD OKKFDMCBBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public MGKLMINDLII AAELKEFCMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<OAGIBKDGOAG> NIKIBPEMNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public OAGIBKDGOAG NOKFFAFFKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public ILHNNHFLHGI PCBGIOBMHHO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct FHNBCIFMLCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public OIKDKHDKGAI CAJGJAEBFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<LHPFGDBHGPB> AEFKKANJCHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class KEGLIEJCEAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public MGKLMINDLII promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public BNHDHHNLONF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public NACLFHGEHGD context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public DHIJIGJEDIF routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public ILHNNHFLHGI coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public OAGIBKDGOAG currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<OAGIBKDGOAG> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public KEGLIEJCEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8274650", Offset = "0x8273A50", VA = "0x188274650")]
		internal void FPLKPPKPOHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class FHBJJFMPLCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public DHIJIGJEDIF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public BNHDHHNLONF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FHBJJFMPLCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8270AA0", Offset = "0x826FEA0", VA = "0x188270AA0")]
		internal void JBAFMPJFLJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class CDOJIHJMMLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public DHIJIGJEDIF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public BNHDHHNLONF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CDOJIHJMMLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8266B90", Offset = "0x8265F90", VA = "0x188266B90")]
		internal void AMINAECDMOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DPBPAIHGCFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public DHIJIGJEDIF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public BNHDHHNLONF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DPBPAIHGCFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x826EF10", Offset = "0x826E310", VA = "0x18826EF10")]
		internal void HIBLAFBNECL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const ILHNNHFLHGI IOFHNNFPPOM = ILHNNHFLHGI.Cancelled | ILHNNHFLHGI.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly OIKDKHDKGAI FJEPJKOEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] AEKMFBGHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<ILHNNHFLHGI> AEKHBDDKCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> FEALPLMPOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> NKNOGDEFCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> GDCBMIDCBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> FFNGILCNECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> HLPIGAAFBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> HKGCHDNFHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private DHIJIGJEDIF[] DLFLBLCCMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private MGKLMINDLII[] HBHDGCOOODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NACLFHGEHGD[] CPFBBLNKNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<OAGIBKDGOAG>[] PKIGPOADCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private OAGIBKDGOAG[] HFIMMCGHABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int EJEFKHKIKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int MFDGLHBGGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int LAIMGLECPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float NGLOPFPBBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private LBMAPHOKFMC FHMBELJCGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle LIGHLLPKKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<DHIJIGJEDIF> OOOAEODPLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool LJOGJDHPHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> EMDHMCAMBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> GOGLFJGABCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool DIBFCHGCHEB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public FHNBCIFMLCH[] FMBIKAEPBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA08DB0", Offset = "0xA081B0", VA = "0x180A08DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x82645F0", Offset = "0x82639F0", VA = "0x1882645F0")]
	private static int CIMHMGJLLPA(OIKDKHDKGAI FJEPJKOEMOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8266250", Offset = "0x8265650", VA = "0x188266250")]
	public BNHDHHNLONF(OIKDKHDKGAI FJEPJKOEMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8264260", Offset = "0x8263660", VA = "0x188264260")]
	private void BCFANAFOGOH(int ELLEEADPEHI, int LAKEOKAMKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x82660D0", Offset = "0x82654D0", VA = "0x1882660D0")]
	public void PPODMCGJFLL(NACLFHGEHGD PFPNPMCGHHC, OAGIBKDGOAG FPLNJAMOPON, IEnumerator<OAGIBKDGOAG> LNALIJLNNJF, MGKLMINDLII FECBEAAGNBC, [Optional] DHIJIGJEDIF FECBCOACJHE, ILHNNHFLHGI KOMAFIEPENB = ILHNNHFLHGI.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x82654F0", Offset = "0x82648F0", VA = "0x1882654F0")]
	public void FLLHCEKFAPH(IEnumerable<LHPFGDBHGPB> ACIHAAMALEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8264FA0", Offset = "0x82643A0", VA = "0x188264FA0")]
	private LHPFGDBHGPB EMGBBJJFDAL(int BOHILGPPHHC)
	{
		return default(LHPFGDBHGPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8265A30", Offset = "0x8264E30", VA = "0x188265A30")]
	private void LCHMPOMAEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x335E570", Offset = "0x335D970", VA = "0x18335E570")]
	private static void GDMPMFIIENO<T>(int BOHILGPPHHC, T[] PIOBBMKMOCJ, int EOKAMHLPIFK, [Optional] T ANKEHAMNNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x335E5C0", Offset = "0x335D9C0", VA = "0x18335E5C0")]
	private static void GDMPMFIIENO<T>(int BOHILGPPHHC, NativeArray<T> PIOBBMKMOCJ, int EOKAMHLPIFK, [Optional] T ANKEHAMNNEB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8263EC0", Offset = "0x82632C0", VA = "0x188263EC0")]
	private void AMBIMDPHJIJ(IEnumerable<LHPFGDBHGPB> ACIHAAMALEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8265ED0", Offset = "0x82652D0", VA = "0x188265ED0")]
	private void OJEGGHLAAME(LHPFGDBHGPB CDCLHKHCEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8264620", Offset = "0x8263A20", VA = "0x188264620")]
	private CBNFODCGKFF COCKGHOCHBD(int GCALELDHGLF)
	{
		return default(CBNFODCGKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8265730", Offset = "0x8264B30", VA = "0x188265730")]
	public void GCINDPIMIKH(float GCGCDOCGAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8265470", Offset = "0x8264870", VA = "0x188265470")]
	private void EMIGCCMGAOJ(Action NJNDFFALKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8264440", Offset = "0x8263840", VA = "0x188264440")]
	private void BGBELGOAHFI(Action NJNDFFALKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8264880", Offset = "0x8263C80", VA = "0x188264880")]
	public void EAGJEMFJPEB(float GCGCDOCGAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8265930", Offset = "0x8264D30", VA = "0x188265930")]
	public void JNOHBLLEJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8265DA0", Offset = "0x82651A0", VA = "0x188265DA0")]
	public void MDEFFPJLFDJ(DHIJIGJEDIF FOOPADPDMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x82644C0", Offset = "0x82638C0", VA = "0x1882644C0")]
	public void CFMCJAABNOB(DHIJIGJEDIF FOOPADPDMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8265FA0", Offset = "0x82653A0", VA = "0x188265FA0")]
	public void PLADLEPAFKN(DHIJIGJEDIF FOOPADPDMEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class CABDHKLFNPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly CABDHKLFNPL OGOLFLHIENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action EKMCBBBPJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool AOPCOJBCAIK;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public CABDHKLFNPL(Action EKMCBBBPJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x792E890", Offset = "0x792DC90", VA = "0x18792E890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface KAPDOJMCFGN<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T HNMCNCHEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable JIHDAIMPJGD(UnityEngine.Object PFPNPMCGHHC, Action<T> FOEJNDKEFEH);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface OAABIODJJGJ<T> : KAPDOJMCFGN<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T HNMCNCHEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class HBJLIBALKKO<T> : OAABIODJJGJ<T>, KAPDOJMCFGN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class IECNLPOKAMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public HBJLIBALKKO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public LAEFGAHHPJM<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IECNLPOKAMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x49B6040", Offset = "0x49B5440", VA = "0x1849B6040")]
		internal void GNJIPCLDHFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject HIMKIEMINMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<LAEFGAHHPJM<UnityEngine.Object, Action<T>>> NJFLANPEKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T FJAKJAOMLJM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T HNMCNCHEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA110A0", Offset = "0xA104A0", VA = "0x180A110A0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4873760", Offset = "0x4872B60", VA = "0x184873760", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4873670", Offset = "0x4872A70", VA = "0x184873670")]
	private static bool BPAHANNEAGF(T NJNDFFALKHH, T NLOOBJLDIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4874270", Offset = "0x4873670", VA = "0x184874270")]
	public HBJLIBALKKO(T PJNFFBPFEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x48738B0", Offset = "0x4872CB0", VA = "0x1848738B0", Slot = "6")]
	public IDisposable JIHDAIMPJGD(UnityEngine.Object PFPNPMCGHHC, Action<T> FOEJNDKEFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4873F40", Offset = "0x4873340", VA = "0x184873F40")]
	private void MFILKFGHODA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class ABCIMBBDBFO : DFDDELLLAHL
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class DOAHKAKDNCB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class PDNNEFJHLKH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int IIKCEJDFBDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private DOAHKAKDNCB ODLBJDGPLAE;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xE12620", Offset = "0xE11A20", VA = "0x180E12620")]
			public PDNNEFJHLKH(int IIKCEJDFBDH, DOAHKAKDNCB ODLBJDGPLAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x827D720", Offset = "0x827CB20", VA = "0x18827D720", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class JACMMDILEAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public JACMMDILEAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xD06D70", Offset = "0xD06170", VA = "0x180D06D70")]
			internal bool PEHCFFOMOAG(LOMAKJCAOKD e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class CJBGOMHFADL : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private OAGIBKDGOAG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public DOAHKAKDNCB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public JNGKOLBKIBG timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private HJIMMLNLINA <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<LOMAKJCAOKD> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public CJBGOMHFADL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8266BD0", Offset = "0x8265FD0", VA = "0x188266BD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8266F00", Offset = "0x8266300", VA = "0x188266F00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly OIKDKHDKGAI FJEPJKOEMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private INGHODAMJIF FECBEAAGNBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<LOMAKJCAOKD> AHIADGNGGEP;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x826EE70", Offset = "0x826E270", VA = "0x18826EE70")]
		public DOAHKAKDNCB(OIKDKHDKGAI FJEPJKOEMOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x826EB50", Offset = "0x826DF50", VA = "0x18826EB50")]
		public IDisposable FMDFPLIFLKM(LOMAKJCAOKD HNAEJOMPMJD, FHPPEPKAGLN DAEKJIAFOBL, JNGKOLBKIBG AOBIHHLEODI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x826ECE0", Offset = "0x826E0E0", VA = "0x18826ECE0")]
		private void GNEMKDPHMIH(int IIKCEJDFBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x826EA70", Offset = "0x826DE70", VA = "0x18826EA70")]
		[IteratorStateMachine(typeof(CJBGOMHFADL))]
		private IEnumerator<OAGIBKDGOAG> AGKCHMFAPLD(JNGKOLBKIBG AOBIHHLEODI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x826EB00", Offset = "0x826DF00", VA = "0x18826EB00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class LOMAKJCAOKD
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum KJPCJJOFMEG : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int GLPPJCLEGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int PEOBHBKAJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly OKEGJBDPDCK OKKFDMCBBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour LGILLBBFGHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action NABACIPFMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> PIDNKBHFDEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float FIICJANALJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float FEALPLMPOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string EDDDAEGNADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool LEBNOAEDAHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly KJPCJJOFMEG OHLKEBABJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool AINHPKBEIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool KCNEIMALMAO;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8278DD0", Offset = "0x82781D0", VA = "0x188278DD0")]
		public LOMAKJCAOKD(OKEGJBDPDCK PFPNPMCGHHC, Action FIEDJHDADEB, bool OFDEFFCHMAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8278C50", Offset = "0x8278050", VA = "0x188278C50")]
		public LOMAKJCAOKD(OKEGJBDPDCK PFPNPMCGHHC, Action<float> FIEDJHDADEB, bool OFDEFFCHMAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8278F50", Offset = "0x8278350", VA = "0x188278F50")]
		public LOMAKJCAOKD(OKEGJBDPDCK PFPNPMCGHHC, float ACECLMIBACD, Action<float> FIEDJHDADEB, JNGKOLBKIBG AOBIHHLEODI, KJPCJJOFMEG JBNLFCHJAEO, bool IHBMEIGDNJL, bool OFDEFFCHMAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8278A80", Offset = "0x8277E80", VA = "0x188278A80")]
		public bool PLGBGPHBDPE(float AKIEJPDFOGK, float OKHHGFLPPAL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly FHPPEPKAGLN DAEKJIAFOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly JNGKOLBKIBG PMMLKFODIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<OIKDKHDKGAI, DOAHKAKDNCB> ABBAGGMHGBJ;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x82624E0", Offset = "0x82618E0", VA = "0x1882624E0")]
	[BOBPNFIGGBE.NBDKKMMHNGD]
	internal static void FHBOPKKLLIN(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8262DF0", Offset = "0x82621F0", VA = "0x188262DF0")]
	[UnityEngine.Scripting.Preserve]
	internal ABCIMBBDBFO([GKAMHFFOHNI(null)] FHPPEPKAGLN DAEKJIAFOBL, [GKAMHFFOHNI(null)] JNGKOLBKIBG PMMLKFODIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8262A10", Offset = "0x8261E10", VA = "0x188262A10", Slot = "4")]
	public IDisposable NABACIPFMBC(OKEGJBDPDCK PFPNPMCGHHC, Action FJLFOAFFGHE, OIKDKHDKGAI FJEPJKOEMOI, bool OFDEFFCHMAC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8262C00", Offset = "0x8262000", VA = "0x188262C00", Slot = "5")]
	public IDisposable NABACIPFMBC(OKEGJBDPDCK PFPNPMCGHHC, Action<float> FJLFOAFFGHE, OIKDKHDKGAI FJEPJKOEMOI, bool OFDEFFCHMAC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x8262910", Offset = "0x8261D10", VA = "0x188262910", Slot = "7")]
	public IDisposable JEJMDAIIPEA(OKEGJBDPDCK PFPNPMCGHHC, float ACECLMIBACD, Action<float> FJLFOAFFGHE, OIKDKHDKGAI FJEPJKOEMOI, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x8262690", Offset = "0x8261A90", VA = "0x188262690", Slot = "8")]
	public IDisposable HANKGGPHBLK(OKEGJBDPDCK PFPNPMCGHHC, float ACECLMIBACD, Action<float> FJLFOAFFGHE, OIKDKHDKGAI FJEPJKOEMOI, bool IHBMEIGDNJL = true, bool OFDEFFCHMAC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8262790", Offset = "0x8261B90", VA = "0x188262790", Slot = "6")]
	public IDisposable JEJMDAIIPEA(float ACECLMIBACD, Action<float> FJLFOAFFGHE, bool IHBMEIGDNJL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8262320", Offset = "0x8261720", VA = "0x188262320", Slot = "9")]
	public void CNJFGCHCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8262550", Offset = "0x8261950", VA = "0x188262550")]
	private DOAHKAKDNCB GPICHDIFGKG(OIKDKHDKGAI FJEPJKOEMOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class KGLPGIKMOAH : IELJKELFDLN, FHPPEPKAGLN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private BNHDHHNLONF[] JLOMCGOFGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private BAKHOJLBLDN HMBMJLLBCPP;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8275690", Offset = "0x8274A90", VA = "0x188275690")]
	[BOBPNFIGGBE.NBDKKMMHNGD]
	internal static void KDIILJNJDKF(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x8275A90", Offset = "0x8274E90", VA = "0x188275A90")]
	[UnityEngine.Scripting.Preserve]
	public KGLPGIKMOAH([GKAMHFFOHNI(null)] KHPKOGGLHFA KPOCJLNAIBM, [GKAMHFFOHNI(null)] JNGKOLBKIBG PMMLKFODIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x8274E30", Offset = "0x8274230", VA = "0x188274E30", Slot = "19")]
	public override INGHODAMJIF BMPBOENEGMA(NACLFHGEHGD PFPNPMCGHHC, IEnumerator<OAGIBKDGOAG> ILNKJKLJFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8274F60", Offset = "0x8274360", VA = "0x188274F60", Slot = "20")]
	public override void CNJFGCHCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x82751F0", Offset = "0x82745F0", VA = "0x1882751F0", Slot = "22")]
	public override void COCKICMBOFK(OIKDKHDKGAI FJEPJKOEMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x8275700", Offset = "0x8274B00", VA = "0x188275700", Slot = "21")]
	protected override void NABACIPFMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x8275420", Offset = "0x8274820", VA = "0x188275420")]
	private BNHDHHNLONF DIMLCAMPONG(OIKDKHDKGAI MAIGGPEPIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x8275870", Offset = "0x8274C70", VA = "0x188275870", Slot = "23")]
	internal override LIHAIABKDFD OCLKKLICIBB(IEnumerator<OAGIBKDGOAG> ILNKJKLJFHP, Behaviour PFPNPMCGHHC, MGKLMINDLII FECBEAAGNBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x82754B0", Offset = "0x82748B0", VA = "0x1882754B0", Slot = "24")]
	internal override DEPPMKHAODG GKFCHOLJLJO(OIKDKHDKGAI ODLBJDGPLAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x8275570", Offset = "0x8274970", VA = "0x188275570")]
	private void HGIECFMDGAA(BNHDHHNLONF MNGMJGHFOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x8275450", Offset = "0x8274850", VA = "0x188275450", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct LBMAPHOKFMC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float HMBELENFNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int GOBJKKCPGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> KMCLLEBDJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> FNAFMOPEMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> DPKCHCNPKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<ILHNNHFLHGI> DALHCNDGIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> HONJEFKGEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> FFNGILCNECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> NKNOGDEFCEH;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8276110", Offset = "0x8275510", VA = "0x188276110")]
	public static LBMAPHOKFMC DCJNBNANGBG(int ALNEDKDAOPH, float GCGCDOCGAJH, NativeArray<ILHNNHFLHGI> OCJCJILEHJG, NativeArray<float> PHHLGLMDGIL, NativeArray<int> DNAMAGHJABE, NativeArray<int> CCDKMGOABFI, NativeArray<int> NOOJJMCCGDF, NativeArray<int> FNAFMOPEMFD, NativeArray<int> DPKCHCNPKOI)
	{
		return default(LBMAPHOKFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8276280", Offset = "0x8275680", VA = "0x188276280", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8276170", Offset = "0x8275570", VA = "0x188276170")]
	private bool DKGMJEINAIF(int KDCAMOIGIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8276400", Offset = "0x8275800", VA = "0x188276400")]
	private void HMBKEBALFOP(NativeArray<int> IJCGJAGFPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8276360", Offset = "0x8275760", VA = "0x188276360")]
	private int GKEKLJMJDLF(int OAEMJMBDAKD, int JMKBEFBIEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x82761B0", Offset = "0x82755B0", VA = "0x1882761B0")]
	private void EEAAGOCMPID(NativeArray<int> IJCGJAGFPED, int DHNLAMFKJKB, int NAEIDONDAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8276430", Offset = "0x8275830", VA = "0x188276430")]
	private void NLDCJFJIJDF(NativeArray<int> IJCGJAGFPED, int NDCGOGMGNBH, int COFCFGCDJCL, int BCHGMPPPBIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class IELJKELFDLN : FHPPEPKAGLN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly KHPKOGGLHFA KPOCJLNAIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly JNGKOLBKIBG PMMLKFODIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private DEPPMKHAODG[] MJIBJJLANDB;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static FHPPEPKAGLN DMADMDPHOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x82734C0", Offset = "0x82728C0", VA = "0x1882734C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool NFLEONEBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public OIKDKHDKGAI MOCEOJNEPIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9901A0", Offset = "0x98F5A0", VA = "0x1809901A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(OIKDKHDKGAI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9A02E0", Offset = "0x99F6E0", VA = "0x1809A02E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public JNGKOLBKIBG HFPEBMLDNAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public OAGIBKDGOAG NLJHEBEJMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public OAGIBKDGOAG CLBCBOMDPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x993430", Offset = "0x992830", VA = "0x180993430", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public OAGIBKDGOAG PBNONKOGGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x993290", Offset = "0x992690", VA = "0x180993290", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public OAGIBKDGOAG KPHNMIOGEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x993390", Offset = "0x992790", VA = "0x180993390", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8272E90", Offset = "0x8272290", VA = "0x188272E90")]
	public static INGHODAMJIF IEMLJHJKIDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8273550", Offset = "0x8272950", VA = "0x188273550")]
	[UnityEngine.Scripting.Preserve]
	protected IELJKELFDLN([GKAMHFFOHNI(null)] KHPKOGGLHFA KPOCJLNAIBM, [GKAMHFFOHNI(null)] JNGKOLBKIBG PMMLKFODIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x82727F0", Offset = "0x8271BF0", VA = "0x1882727F0", Slot = "6")]
	public INGHODAMJIF CAFDDKMELKN(IEnumerator<OAGIBKDGOAG> ILNKJKLJFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x82725F0", Offset = "0x82719F0", VA = "0x1882725F0", Slot = "7")]
	public INGHODAMJIF CAFDDKMELKN(Behaviour PFPNPMCGHHC, IEnumerator<OAGIBKDGOAG> ILNKJKLJFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract INGHODAMJIF BMPBOENEGMA(NACLFHGEHGD PFPNPMCGHHC, IEnumerator<OAGIBKDGOAG> ILNKJKLJFHP);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8272800", Offset = "0x8271C00", VA = "0x188272800", Slot = "20")]
	public virtual void CNJFGCHCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x8272FA0", Offset = "0x82723A0", VA = "0x188272FA0", Slot = "9")]
	public void JJNEIALBANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x8273480", Offset = "0x8272880", VA = "0x188273480", Slot = "21")]
	protected virtual void NABACIPFMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8272F20", Offset = "0x8272320", VA = "0x188272F20")]
	private void IFGDCICMHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x82734A0", Offset = "0x82728A0", VA = "0x1882734A0")]
	private void OAAIEOKCDHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x82731E0", Offset = "0x82725E0", VA = "0x1882731E0")]
	private void KKMCDFOMKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8272E10", Offset = "0x8272210", VA = "0x188272E10")]
	private void ELFFHLIGMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8272DF0", Offset = "0x82721F0", VA = "0x188272DF0")]
	private void EBMMOPPKBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8273200", Offset = "0x8272600", VA = "0x188273200")]
	private void MBPCEEEEEAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8273530", Offset = "0x8272930", VA = "0x188273530")]
	private void OPNHJBBAAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x82729A0", Offset = "0x8271DA0", VA = "0x1882729A0", Slot = "22")]
	public virtual void COCKICMBOFK(OIKDKHDKGAI FJEPJKOEMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x82732B0", Offset = "0x82726B0", VA = "0x1882732B0")]
	private void MKJKGGPHMDH(DEPPMKHAODG MNGMJGHFOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2546D90", Offset = "0x2546190", VA = "0x182546D90")]
	private DEPPMKHAODG IKDLMJOAKKH(OIKDKHDKGAI MAIGGPEPIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract LIHAIABKDFD OCLKKLICIBB(IEnumerator<OAGIBKDGOAG> ILNKJKLJFHP, Behaviour DBFKLCEDAMM, MGKLMINDLII NNNJMIMOMOH);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract DEPPMKHAODG GKFCHOLJLJO(OIKDKHDKGAI FJEPJKOEMOI);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8272A30", Offset = "0x8271E30", VA = "0x188272A30", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8272E30", Offset = "0x8272230", VA = "0x188272E30", Slot = "15")]
	public OAGIBKDGOAG FKFDLNFKDFI(OIKDKHDKGAI ODLBJDGPLAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8273220", Offset = "0x8272620", VA = "0x188273220", Slot = "16")]
	public OAGIBKDGOAG MFGGOHFLMEA(float LLAIDEDFOJF, OIKDKHDKGAI ODLBJDGPLAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8272F40", Offset = "0x8272340", VA = "0x188272F40", Slot = "17")]
	public OAGIBKDGOAG JHNIKLFEMBP(Func<bool> IJHHPJHHECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class LIHAIABKDFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly MGKLMINDLII FECBEAAGNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly HOFHBEHCLFN PFPNPMCGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool GKMHBFKGFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string MPGDCPPMNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace EILBAGBLFED;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<OAGIBKDGOAG> NIKIBPEMNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OAGIBKDGOAG NOKFFAFFKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LEJGDIHCFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8276E50", Offset = "0x8276250", VA = "0x188276E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool JHABKMOFIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xB54C40", Offset = "0xB54040", VA = "0x180B54C40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xBA19A0", Offset = "0xBA0DA0", VA = "0x180BA19A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8276F90", Offset = "0x8276390", VA = "0x188276F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float OIFFJIMCICG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xF630F0", Offset = "0xF624F0", VA = "0x180F630F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6C49E20", Offset = "0x6C49220", VA = "0x186C49E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x8277220", Offset = "0x8276620", VA = "0x188277220")]
	public LIHAIABKDFD(IEnumerator<OAGIBKDGOAG> LNALIJLNNJF, HOFHBEHCLFN PFPNPMCGHHC, MGKLMINDLII FECBEAAGNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8276B30", Offset = "0x8275F30", VA = "0x188276B30")]
	public OAGIBKDGOAG ABHMDAJBPEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8276ED0", Offset = "0x82762D0", VA = "0x188276ED0")]
	public bool JDPJJAHEPNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8276F40", Offset = "0x8276340", VA = "0x188276F40")]
	public void MDEFFPJLFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x8277140", Offset = "0x8276540", VA = "0x188277140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xBE8410", Offset = "0xBE7810", VA = "0x180BE8410")]
	[CompilerGenerated]
	private void KOFJKAIPDOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class MGKLMINDLII : POLPJMCNLLL, INGHODAMJIF, KPNDCLGPJDN, KMDOHMPCNFD, IEnumerator, OAGIBKDGOAG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private OIKDKHDKGAI PNGLEHBHIKB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private OIKDKHDKGAI DLBDFKIPCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xCC56B0", Offset = "0xCC4AB0", VA = "0x180CC56B0", Slot = "23")]
		get
		{
			return default(OIKDKHDKGAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public OIKDKHDKGAI CDDNONIMMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xE58630", Offset = "0xE57A30", VA = "0x180E58630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float IJFKAKAHLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xB1C220", Offset = "0xB1B620", VA = "0x180B1C220", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PGJOMKMPDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8279410", Offset = "0x8278810", VA = "0x188279410", Slot = "24")]
	private bool GKNNEBJMNBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8279400", Offset = "0x8278800", VA = "0x188279400", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8279430", Offset = "0x8278830", VA = "0x188279430")]
	public MGKLMINDLII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum CBNFODCGKFF : byte
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
internal sealed class DEPPMKHAODG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum OHCLDJPKEAK
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct PHDAPFJGCKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public OIKDKHDKGAI CAJGJAEBFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public OHCLDJPKEAK GGPGHEACBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<LIHAIABKDFD> CNDDODPNFOF;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly OHCLDJPKEAK[] NJNFOBJJCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly OIKDKHDKGAI FJEPJKOEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool KIIDEKEMBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly LIHAIABKDFD[] JGHEJKOBPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<LIHAIABKDFD> DLBJPDIIALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> ELIOIDAJKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<LIHAIABKDFD> PODBHKBCDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> PFECACHIGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly BAKHOJLBLDN INNMPKCMJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool DIBFCHGCHEB;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public PHDAPFJGCKK[,] FEPEBBCBJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x993290", Offset = "0x992690", VA = "0x180993290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x826CA50", Offset = "0x826BE50", VA = "0x18826CA50")]
	public DEPPMKHAODG(OIKDKHDKGAI ODLBJDGPLAE, BAKHOJLBLDN INNMPKCMJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x826BF70", Offset = "0x826B370", VA = "0x18826BF70")]
	public void GDHJHEKCJFO(LIHAIABKDFD LNALIJLNNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x826B9C0", Offset = "0x826ADC0", VA = "0x18826B9C0")]
	public void BKKMKNEFBCE(IList<LIHAIABKDFD> ECJPPLKMBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x826C3B0", Offset = "0x826B7B0", VA = "0x18826C3B0")]
	public void LJNADHPKAOH(IList<LIHAIABKDFD> ECJPPLKMBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x826C830", Offset = "0x826BC30", VA = "0x18826C830")]
	private void ODLLDCHJDAC(LIHAIABKDFD LNALIJLNNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x826B830", Offset = "0x826AC30", VA = "0x18826B830")]
	private void BIKOGCFLDCA(IList<LIHAIABKDFD> ECJPPLKMBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x826BDF0", Offset = "0x826B1F0", VA = "0x18826BDF0")]
	private CBNFODCGKFF EGLKEAMKDAO(LIHAIABKDFD LNALIJLNNJF)
	{
		return default(CBNFODCGKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x826C6C0", Offset = "0x826BAC0", VA = "0x18826C6C0")]
	public void NABACIPFMBC(float GCGCDOCGAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x826C1C0", Offset = "0x826B5C0", VA = "0x18826C1C0")]
	public void JJNEIALBANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x826B4D0", Offset = "0x826A8D0", VA = "0x18826B4D0")]
	private void AEIFBNMLKCH(List<LIHAIABKDFD> ECJPPLKMBMK, Stack<int> BJPIMDDNIOG, bool NJDACBOGBOA, float MIHEANKFOID = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x826BCD0", Offset = "0x826B0D0", VA = "0x18826BCD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x826C080", Offset = "0x826B480", VA = "0x18826C080")]
	private void JHLKFLNBMLA(List<LIHAIABKDFD> ECJPPLKMBMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class HCKMHPPJHGJ : BAKHOJLBLDN
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
	public void ACLIBNMNCMI(string MPGDCPPMNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
	public void MDNPOBMJKHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public HCKMHPPJHGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class JOOJBGCIMPP : HOFHBEHCLFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour DBFKLCEDAMM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8274560", Offset = "0x8273960", VA = "0x188274560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool EEIEAOPBBGM
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8274600", Offset = "0x8273A00", VA = "0x188274600", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool MEBELHELFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x82745E0", Offset = "0x82739E0", VA = "0x1882745E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public JOOJBGCIMPP(Behaviour DBFKLCEDAMM)
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

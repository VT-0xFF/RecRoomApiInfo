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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x833EA00", Offset = "0x833DE00", VA = "0x18833EA00", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x8345500", Offset = "0x8344900", VA = "0x188345500", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
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
		private delegate List<PlayerLoopSystem> POJLLPLNCLF(List<PlayerLoopSystem> DABPOBHMOMM, int MBDAJDHEAME);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct LOODLFCNGNC
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct BPAPNLJNGHI
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static OPNNLJDPBAB EIPEEDPLOMN;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x832A5D0", Offset = "0x83299D0", VA = "0x18832A5D0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct JIMJLNMCNLJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static OPNNLJDPBAB PAALEGAGDNC;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x833A4B0", Offset = "0x83398B0", VA = "0x18833A4B0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct AHECLPCBGMB
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static OPNNLJDPBAB BGLIKCCEPAK;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x83289D0", Offset = "0x8327DD0", VA = "0x1883289D0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct LLAONEJMCEB
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static OPNNLJDPBAB AAJPBANMDKE;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static OPNNLJDPBAB OCIPEHJKBPE;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static OPNNLJDPBAB BLDHJCHHNHF;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static OPNNLJDPBAB FLMGIPBFNGB;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x833E410", Offset = "0x833D810", VA = "0x18833E410")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct FGNIPELAHLF
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static OPNNLJDPBAB ICEDNICHMJI;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x8334C90", Offset = "0x8334090", VA = "0x188334C90")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct APFNIDMHBOL
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static OPNNLJDPBAB AAJPBANMDKE;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static OPNNLJDPBAB OCIPEHJKBPE;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static OPNNLJDPBAB BLDHJCHHNHF;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static OPNNLJDPBAB FLMGIPBFNGB;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x8329E60", Offset = "0x8329260", VA = "0x188329E60")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct FGOIHILPGJA
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static OPNNLJDPBAB CIFABKMFNNF;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x8334E70", Offset = "0x8334270", VA = "0x188334E70")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct ENPJFECMMLF
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static OPNNLJDPBAB DNHAOKGOAMJ;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x8332DD0", Offset = "0x83321D0", VA = "0x188332DD0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct MHMINHMPFFE
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static OPNNLJDPBAB AEMLNJMNPNB;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x833EB50", Offset = "0x833DF50", VA = "0x18833EB50")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct FEEKOMMJOLN
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static OPNNLJDPBAB KOPKGBGIJHM;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x83348D0", Offset = "0x8333CD0", VA = "0x1883348D0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct CCJIBFJGEJG
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static OPNNLJDPBAB EJKNKFPPJLF;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x832A7B0", Offset = "0x8329BB0", VA = "0x18832A7B0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct JDONPODOEEK
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static OPNNLJDPBAB GBFDOPHAGFE;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x8339390", Offset = "0x8338790", VA = "0x188339390")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct GNBGGDJNMJG
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static OPNNLJDPBAB HKGLNMMMEMC;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x83383D0", Offset = "0x83377D0", VA = "0x1883383D0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct FFOLEFGALON
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static OPNNLJDPBAB KOMFKLEMMAI;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x8334AB0", Offset = "0x8333EB0", VA = "0x188334AB0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct LLPDEOBMMNJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static OPNNLJDPBAB OPKAECHPAIG;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x833E6E0", Offset = "0x833DAE0", VA = "0x18833E6E0")]
				public static PlayerLoopSystem EJMOPNOOINH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum AFLHKPBDODE : byte
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
			public struct NDJOLEHGECN
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class EMPGAKAKDKG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public AFLHKPBDODE updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
					public EMPGAKAKDKG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x8332BE0", Offset = "0x8331FE0", VA = "0x188332BE0")]
					internal void LLBLGHIEJBD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static GLDBGNIANKN<AFLHKPBDODE> CIICAGDOHAC;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x833FF40", Offset = "0x833F340", VA = "0x18833FF40")]
				public static PlayerLoopSystem EJMOPNOOINH(AFLHKPBDODE NBNBCAEGFEF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct FAPMJOHNOFA
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class OOECBLMIBBE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public DKJAJKLNEKO.DMPJPMFLEOB key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
					public OOECBLMIBBE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x8343080", Offset = "0x8342480", VA = "0x188343080")]
					internal void EHMOFKHAMMF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable NNGHCLKINKJ;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x83347A0", Offset = "0x8333BA0", VA = "0x1883347A0")]
				public static PlayerLoopSystem NMNGPGFAEJH(DKJAJKLNEKO.DMPJPMFLEOB DJBLFBEBKGO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct GEGHJKIIOJE
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class ICIFMKPHJLI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public DKJAJKLNEKO.DMPJPMFLEOB key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
					public ICIFMKPHJLI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x83389E0", Offset = "0x8337DE0", VA = "0x1883389E0")]
					internal void EHMOFKHAMMF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x8336390", Offset = "0x8335790", VA = "0x188336390")]
				public static PlayerLoopSystem NMNGPGFAEJH(DKJAJKLNEKO.DMPJPMFLEOB DJBLFBEBKGO)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class HLHLHMGJMND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public HLHLHMGJMND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8338800", Offset = "0x8337C00", VA = "0x188338800")]
			internal List<PlayerLoopSystem> FELPOGCDDOA(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool FJKNIAKLADK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool HMPOAHOJMBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x832B6B0", Offset = "0x832AAB0", VA = "0x18832B6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x832C6D0", Offset = "0x832BAD0", VA = "0x18832C6D0")]
		private static void OKHOLNDAMAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x832BDC0", Offset = "0x832B1C0", VA = "0x18832BDC0")]
		private static void NFMAIOOGLNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x832B430", Offset = "0x832A830", VA = "0x18832B430")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x832B470", Offset = "0x832A870", VA = "0x18832B470")]
		private static void FCGNDMOEADH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x832B820", Offset = "0x832AC20", VA = "0x18832B820")]
		private static void KOHPOIHLDKJ(DKJAJKLNEKO.DMPJPMFLEOB DJBLFBEBKGO, PlayerLoopSystem FNNKLHPGPFG, Type NMEINAFKKIB, Type OALIOHACPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x832B9E0", Offset = "0x832ADE0", VA = "0x18832B9E0")]
		private static void MFKMJJGHONF(PlayerLoopSystem FNNKLHPGPFG, Type NMEINAFKKIB, Type OALIOHACPFH, POJLLPLNCLF HGJICNDEDDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x832B6F0", Offset = "0x832AAF0", VA = "0x18832B6F0")]
		private static void KNJEDINBLIF(PlayerLoopSystem FNNKLHPGPFG, Type NMEINAFKKIB, Type OALIOHACPFH, PlayerLoopSystem? BGPCHIEGBPH, PlayerLoopSystem? JOPCPDEAGCF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class DKJAJKLNEKO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum DMPJPMFLEOB
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
	public class AGCNAKAMPHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly DMPJPMFLEOB CGCIGODIKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly PKKHFAKCKEL AFILOCMPHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long HGBCBCFFBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long HNOGAPJKIEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long IAFFJGLCOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int GBCFFLKDLJN;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8328940", Offset = "0x8327D40", VA = "0x188328940")]
		public AGCNAKAMPHN(DMPJPMFLEOB MAAMJFMLDHP, int EOOALEJKLOJ = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8328920", Offset = "0x8327D20", VA = "0x188328920")]
		public void MCCPNKDNHBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x83288D0", Offset = "0x8327CD0", VA = "0x1883288D0")]
		public void ECJOEIFJHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83287F0", Offset = "0x8327BF0", VA = "0x1883287F0")]
		public void ALBABCDFLAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static DMPJPMFLEOB[] BALLACBGBEH;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static AGCNAKAMPHN[] MCJNJCLHJEP;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x83302F0", Offset = "0x832F6F0", VA = "0x1883302F0")]
	public static AGCNAKAMPHN IIHGGHDMJNI(DMPJPMFLEOB DJBLFBEBKGO, int EOOALEJKLOJ = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x83304E0", Offset = "0x832F8E0", VA = "0x1883304E0")]
	public static AGCNAKAMPHN JBIJMMGICCI(DMPJPMFLEOB DJBLFBEBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8330440", Offset = "0x832F840", VA = "0x188330440")]
	public static void IJOMMGGBNML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DJPCADFFCLO
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface KDFHCGOPDDL
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool DLICIJADICJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CKDFENAGPAE();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class KEAECOOGHLO : KDFHCGOPDDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action IOPCFKOHPBF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DLICIJADICJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
		public KEAECOOGHLO(Action IOPCFKOHPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x104DED0", Offset = "0x104D2D0", VA = "0x18104DED0", Slot = "5")]
		public void CKDFENAGPAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<KDFHCGOPDDL> HAFFFBJGEAC;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x832FE10", Offset = "0x832F210", VA = "0x18832FE10")]
	public static void IDGIODEBEJP(Action IOPCFKOHPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x832FC00", Offset = "0x832F000", VA = "0x18832FC00")]
	private static void HJPIJFMDDCP(KDFHCGOPDDL CIBJOMJAJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x832FEB0", Offset = "0x832F2B0", VA = "0x18832FEB0")]
	private static void JMFGOIJCOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x832FB00", Offset = "0x832EF00", VA = "0x18832FB00")]
	private static void CPPKCHFGCJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8330190", Offset = "0x832F590", VA = "0x188330190")]
	private static void LKEAGGCFIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class EOFIIKGAEJA
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct JHKFALMFLIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> KGEFPEAALJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string DFCMKAEHLAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode IACJAKJLJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool FCCJDBBOCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8339730", Offset = "0x8338B30", VA = "0x188339730")]
		public JHKFALMFLIK(TaskCompletionSource<Scene> LNFGEEIEIAH, string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN, bool FCCJDBBOCBI, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct ANPKJCADJEK : IAsyncStateMachine
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
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private APGKENHKANG<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x8329360", Offset = "0x8328760", VA = "0x188329360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8329C00", Offset = "0x8329000", VA = "0x188329C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GJLPEJLLINN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8337F40", Offset = "0x8337340", VA = "0x188337F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8338250", Offset = "0x8337650", VA = "0x188338250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct DBLLPEMEJKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private JHKFALMFLIK <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x832F6E0", Offset = "0x832EAE0", VA = "0x18832F6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x832FAA0", Offset = "0x832EEA0", VA = "0x18832FAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class NCAGNFIDMBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public COOALICOFAM<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NCAGNFIDMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x833FEE0", Offset = "0x833F2E0", VA = "0x18833FEE0")]
		internal void AAEHNKHAAMD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct DMNKFFFNGEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

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
		private NCAGNFIDMBP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private APGKENHKANG<string>.EEEKGBDKLHP <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x83306E0", Offset = "0x832FAE0", VA = "0x1883306E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8331280", Offset = "0x8330680", VA = "0x188331280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct EDDAEMGOIKI : IAsyncStateMachine
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
		private IFKKDICMKCC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x83322D0", Offset = "0x83316D0", VA = "0x1883322D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8332990", Offset = "0x8331D90", VA = "0x188332990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct DMOFAINGIOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private APGKENHKANG<string>.EEEKGBDKLHP <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private APGKENHKANG<string>.EEEKGBDKLHP <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x83312F0", Offset = "0x83306F0", VA = "0x1883312F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8331E10", Offset = "0x8331210", VA = "0x188331E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class GCOHLHGOHOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public COOALICOFAM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GCOHLHGOHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8336310", Offset = "0x8335710", VA = "0x188336310")]
		internal bool MMIFJAJNHJK(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x83360B0", Offset = "0x83354B0", VA = "0x1883360B0")]
		internal void FLNHBPFCDBI(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class KCBCDEMHMLG : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public COOALICOFAM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private GCOHLHGOHOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IFKKDICMKCC <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public KCBCDEMHMLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x833BBB0", Offset = "0x833AFB0", VA = "0x18833BBB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x833B2C0", Offset = "0x833A6C0", VA = "0x18833B2C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x833BB40", Offset = "0x833AF40", VA = "0x18833BB40")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x833BB60", Offset = "0x833AF60", VA = "0x18833BB60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> FHKINJGNMAD;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static DJNFHDJGNJD HMPIINNBLAL;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation HHPHHFIKGKF;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static DJNFHDJGNJD FICLOIKKDFF;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string KBDANBOIENL;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string FDCKOLAAFIG;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority LPCFLLJIGEO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task CJPBAIGHKCL;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> IGHPOCLMLED;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<JHKFALMFLIK> DKJCCAHEPMB;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task JHGCOJBBJBC;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> EKFFNOHKFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83334F0", Offset = "0x83328F0", VA = "0x1883334F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8333D80", Offset = "0x8333180", VA = "0x188333D80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8333FA0", Offset = "0x83333A0", VA = "0x188333FA0")]
	[IDEKGKHHECE(MPEIPIAKFID.EnteredEditModeNextFrame, 0)]
	private static void GKLFGMOGBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8334440", Offset = "0x8333840", VA = "0x188334440")]
	[AsyncStateMachine(typeof(ANPKJCADJEK))]
	public static Task<Scene> NJHDCKIDFAO(string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN = LoadSceneMode.Single, bool FCCJDBBOCBI = false, [Optional] APGKENHKANG<string>.EEEKGBDKLHP MEIEBOHMIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8333440", Offset = "0x8332840", VA = "0x188333440")]
	[AsyncStateMachine(typeof(GJLPEJLLINN))]
	private static Task BEIJLFCJBEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8334090", Offset = "0x8333490", VA = "0x188334090")]
	[AsyncStateMachine(typeof(DBLLPEMEJKA))]
	private static Task JDBLACMEIOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8334160", Offset = "0x8333560", VA = "0x188334160")]
	[AsyncStateMachine(typeof(DMNKFFFNGEC))]
	private static Task<Scene> JKDENDHLBHL(string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN, bool FCCJDBBOCBI, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8333B90", Offset = "0x8332F90", VA = "0x188333B90")]
	private static void DEHKDAIDOHD(SceneInstance JJKLCHMKBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8333840", Offset = "0x8332C40", VA = "0x188333840")]
	private static void DBJOPJAJCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8333310", Offset = "0x8332710", VA = "0x188333310")]
	[AsyncStateMachine(typeof(EDDAEMGOIKI))]
	private static Task<Scene> AEPOOPHFBBN(string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8333C90", Offset = "0x8333090", VA = "0x188333C90")]
	private static bool DOMPFKKMEHK(string DFCMKAEHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8333E90", Offset = "0x8333290", VA = "0x188333E90")]
	[AsyncStateMachine(typeof(DMOFAINGIOO))]
	private static Task<Scene> GGENPDJMBBE(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x83336C0", Offset = "0x8332AC0", VA = "0x1883336C0")]
	public static GOBMEFCJDOP<Scene> CGEKHHMCGJL(string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8333AF0", Offset = "0x8332EF0", VA = "0x188333AF0")]
	[IteratorStateMachine(typeof(KCBCDEMHMLG))]
	private static IEnumerator<CIKDDGFOAFI> DDDBNMHDPPG(string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN, COOALICOFAM<Scene> IDBGCMHEFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x83343E0", Offset = "0x83337E0", VA = "0x1883343E0")]
	public static void MBLBIEIKNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8333600", Offset = "0x8332A00", VA = "0x188333600")]
	private static void CDHMELKPNLG(string DFCMKAEHLAO, LoadSceneMode IACJAKJLJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x83342B0", Offset = "0x83336B0", VA = "0x1883342B0")]
	public static bool LLHKONIKENE([Out] string ILDPHFIAOCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class KCPCCIIADLA
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x833BD10", Offset = "0x833B110", VA = "0x18833BD10")]
	public static IDisposable NDHOFFKOAIL(this IGCLHBDADKK PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x833BC90", Offset = "0x833B090", VA = "0x18833BC90")]
	public static IDisposable JLCENEHPPLD(this IGCLHBDADKK PCJJKLDOJMD, Action<float> MMFCHLFFDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x833BC10", Offset = "0x833B010", VA = "0x18833BC10")]
	public static IDisposable FAPOFGALNMP(this IGCLHBDADKK PCJJKLDOJMD, Action<float> MMFCHLFFDDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class EHMKKIDGPCB
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3481CD0", Offset = "0x34810D0", VA = "0x183481CD0")]
	[KOHECBFFINE]
	public static IDisposable MFDBAPBBBBP<T>(this T NAECADIONFH, Action MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3481E80", Offset = "0x3481280", VA = "0x183481E80")]
	[KOHECBFFINE]
	public static IDisposable MFDBAPBBBBP<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3482130", Offset = "0x3481530", VA = "0x183482130")]
	[KOHECBFFINE]
	public static IDisposable ODNOMLGNGJI<T>(this T NAECADIONFH, Action MMFCHLFFDDH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x34820E0", Offset = "0x34814E0", VA = "0x1834820E0")]
	[KOHECBFFINE]
	public static IDisposable NACCOEPNHGB<T>(this T NAECADIONFH, Action MMFCHLFFDDH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x34820E0", Offset = "0x34814E0", VA = "0x1834820E0")]
	[KOHECBFFINE]
	public static IDisposable NACCOEPNHGB<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3481A50", Offset = "0x3480E50", VA = "0x183481A50")]
	[KOHECBFFINE]
	public static IDisposable GLMKDEJNHNL<T>(this T NAECADIONFH, Action MMFCHLFFDDH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3481A00", Offset = "0x3480E00", VA = "0x183481A00")]
	[KOHECBFFINE]
	public static IDisposable GFJDOFLDMJC<T>(this T NAECADIONFH, Action MMFCHLFFDDH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3481950", Offset = "0x3480D50", VA = "0x183481950")]
	[KOHECBFFINE]
	public static IDisposable FJLGICJPLCI<T>(this T NAECADIONFH, Action MMFCHLFFDDH, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3481910", Offset = "0x3480D10", VA = "0x183481910")]
	[KOHECBFFINE]
	public static IDisposable CHFDLCMLMJP<T>(this T NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8332A00", Offset = "0x8331E00", VA = "0x188332A00")]
	[KOHECBFFINE]
	public static IDisposable CHFDLCMLMJP(this MonoBehaviour NAECADIONFH, LEGAGIOCBAL PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x34821D0", Offset = "0x34815D0", VA = "0x1834821D0")]
	[KOHECBFFINE]
	public static IDisposable PJBLOJKNAPC<T>(this T NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3482090", Offset = "0x3481490", VA = "0x183482090")]
	[KOHECBFFINE]
	public static IDisposable MOFODJDOAFP<T>(this T NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3481AF0", Offset = "0x3480EF0", VA = "0x183481AF0")]
	[KOHECBFFINE]
	public static IDisposable KAJOOFEJLMP<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x34818B0", Offset = "0x3480CB0", VA = "0x1834818B0")]
	[KOHECBFFINE]
	public static IDisposable BBFPLLFJBDH<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3481BB0", Offset = "0x3480FB0", VA = "0x183481BB0")]
	[KOHECBFFINE]
	public static IDisposable KGEGCKMGMHJ<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x34819A0", Offset = "0x3480DA0", VA = "0x1834819A0")]
	[KOHECBFFINE]
	public static IDisposable GCEPOGIMECB<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3481B50", Offset = "0x3480F50", VA = "0x183481B50")]
	[KOHECBFFINE]
	public static IDisposable KCJEJIDIIJL<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3481C70", Offset = "0x3481070", VA = "0x183481C70")]
	[KOHECBFFINE]
	public static IDisposable MDCDJENNJDC<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3481C10", Offset = "0x3481010", VA = "0x183481C10")]
	[KOHECBFFINE]
	public static IDisposable LPJEHOODCOO<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3481AA0", Offset = "0x3480EA0", VA = "0x183481AA0")]
	[KOHECBFFINE]
	public static IDisposable HKGNFPCBPON<T>(this T NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3482030", Offset = "0x3481430", VA = "0x183482030")]
	[KOHECBFFINE]
	public static IDisposable MHGPMKLOCBF<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3482170", Offset = "0x3481570", VA = "0x183482170")]
	[KOHECBFFINE]
	public static IDisposable PDMDOFMFIKF<T>(this T NAECADIONFH, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true) where T : MonoBehaviour, LEGAGIOCBAL
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class JOEOLEOPBHA
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class POEFKKIDFJI : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public GAMKDKPALGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private PHPFGDACENL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public POEFKKIDFJI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x83442C0", Offset = "0x83436C0", VA = "0x1883442C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83443A0", Offset = "0x83437A0", VA = "0x1883443A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class LMLOAKKFOLD : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public GAMKDKPALGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private PHPFGDACENL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public LMLOAKKFOLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x833E8C0", Offset = "0x833DCC0", VA = "0x18833E8C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x833E9B0", Offset = "0x833DDB0", VA = "0x18833E9B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x833A840", Offset = "0x8339C40", VA = "0x18833A840")]
	public static LBKCJDEOHAA MFDBAPBBBBP(Action MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x833A7B0", Offset = "0x8339BB0", VA = "0x18833A7B0")]
	public static LBKCJDEOHAA MFDBAPBBBBP(Behaviour PCJJKLDOJMD, Action MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x833A8C0", Offset = "0x8339CC0", VA = "0x18833A8C0")]
	public static LBKCJDEOHAA MFDBAPBBBBP(Behaviour PCJJKLDOJMD, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x833A690", Offset = "0x8339A90", VA = "0x18833A690")]
	[IteratorStateMachine(typeof(POEFKKIDFJI))]
	private static IEnumerator<CIKDDGFOAFI> EDDLKNGFLFE(GAMKDKPALGP HKOJAHCOOEL, Action MMFCHLFFDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x833A720", Offset = "0x8339B20", VA = "0x18833A720")]
	[IteratorStateMachine(typeof(LMLOAKKFOLD))]
	private static IEnumerator<CIKDDGFOAFI> EDDLKNGFLFE(GAMKDKPALGP HKOJAHCOOEL, Action<float> MMFCHLFFDDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class AOEEJPMPCOL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class LCPCKOPGLMA : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AOEEJPMPCOL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public LCPCKOPGLMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x833DA80", Offset = "0x833CE80", VA = "0x18833DA80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x833DB10", Offset = "0x833CF10", VA = "0x18833DB10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly GAMKDKPALGP BIENFMKKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action APAODHLMHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool GALNDCKLIHA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool IAEHNHFNHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9AA370", Offset = "0x9A9770", VA = "0x1809AA370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8329D90", Offset = "0x8329190", VA = "0x188329D90")]
	public AOEEJPMPCOL(GAMKDKPALGP BIENFMKKIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8329C70", Offset = "0x8329070", VA = "0x188329C70")]
	[IteratorStateMachine(typeof(LCPCKOPGLMA))]
	private IEnumerator<CIKDDGFOAFI> EPDHEMLABFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8329CF0", Offset = "0x83290F0", VA = "0x188329CF0", Slot = "4")]
	public void OnCompleted(Action KLINOMADKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	public void OFKHKGDALIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class ALMDKHKPDBN
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8329250", Offset = "0x8328650", VA = "0x188329250")]
	public static AOEEJPMPCOL LKDLBOJCELA(this GAMKDKPALGP BIENFMKKIBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class KJJEMIOMHLM
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class CCPKICPOIMG : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public MJDGPJLMNKH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public CCPKICPOIMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x832A990", Offset = "0x8329D90", VA = "0x18832A990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x832AA10", Offset = "0x8329E10", VA = "0x18832AA10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x833BFC0", Offset = "0x833B3C0", VA = "0x18833BFC0")]
	public static LBKCJDEOHAA MFDBAPBBBBP(float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x833C090", Offset = "0x833B490", VA = "0x18833C090")]
	public static LBKCJDEOHAA MFDBAPBBBBP(MonoBehaviour NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x833C160", Offset = "0x833B560", VA = "0x18833C160")]
	public static LBKCJDEOHAA MGNIBBGJJEL(MonoBehaviour NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x833BE60", Offset = "0x833B260", VA = "0x18833BE60")]
	public static LBKCJDEOHAA JCDBIDMKALL(IGCLHBDADKK PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x833BDA0", Offset = "0x833B1A0", VA = "0x18833BDA0")]
	private static IEnumerator<CIKDDGFOAFI> EDDLKNGFLFE(FDGCEIPODAG HNJDEELBCLI, float MIFCKAIMGDB, GAMKDKPALGP HKOJAHCOOEL, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x833C250", Offset = "0x833B650", VA = "0x18833C250")]
	private static IEnumerator<CIKDDGFOAFI> NDOLNCAAIGM(FDGCEIPODAG HNJDEELBCLI, float MIFCKAIMGDB, GAMKDKPALGP HKOJAHCOOEL, Action<float> MMFCHLFFDDH, bool DFODLBNPDAD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x833BF30", Offset = "0x833B330", VA = "0x18833BF30")]
	[IteratorStateMachine(typeof(CCPKICPOIMG))]
	private static IEnumerator<CIKDDGFOAFI> KEJMAKAFPOJ(MJDGPJLMNKH FLNEKKEJNHD, float MIFCKAIMGDB, GAMKDKPALGP HKOJAHCOOEL, Action<float> MMFCHLFFDDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class ENKNOHPAPPA
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JGPHEANHNJF : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public GAMKDKPALGP queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public JGPHEANHNJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8339620", Offset = "0x8338A20", VA = "0x188339620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x83396E0", Offset = "0x8338AE0", VA = "0x1883396E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8332D40", Offset = "0x8332140", VA = "0x188332D40")]
	[IteratorStateMachine(typeof(JGPHEANHNJF))]
	private static IEnumerator<CIKDDGFOAFI> FFEFFHIPKPN(GAMKDKPALGP BIENFMKKIBH, Func<bool> LNDKBMLMEBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8332C60", Offset = "0x8332060", VA = "0x188332C60")]
	public static LBKCJDEOHAA AELPGJNECCF(this MonoBehaviour NAECADIONFH, Func<bool> LNDKBMLMEBB, GAMKDKPALGP BIENFMKKIBH = GAMKDKPALGP.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class CLFAPLMCOGH
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OPOMPGOHDKC : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public GAMKDKPALGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public OPOMPGOHDKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8343300", Offset = "0x8342700", VA = "0x188343300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8343370", Offset = "0x8342770", VA = "0x188343370", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class GKDAJGNAPKG<T> : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public GAMKDKPALGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public GKDAJGNAPKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x48622A0", Offset = "0x48616A0", VA = "0x1848622A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4862340", Offset = "0x4861740", VA = "0x184862340", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class GFGLPJCPOLM : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public GAMKDKPALGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private CIKDDGFOAFI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public GFGLPJCPOLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x83364C0", Offset = "0x83358C0", VA = "0x1883364C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8336550", Offset = "0x8335950", VA = "0x188336550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x832AC40", Offset = "0x832A040", VA = "0x18832AC40")]
	[IteratorStateMachine(typeof(OPOMPGOHDKC))]
	private static IEnumerator<CIKDDGFOAFI> EPDHEMLABFD(float PCFGHPNONAI, GAMKDKPALGP HKOJAHCOOEL, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3406FA0", Offset = "0x34063A0", VA = "0x183406FA0")]
	[IteratorStateMachine(typeof(GKDAJGNAPKG<>))]
	private static IEnumerator<CIKDDGFOAFI> EPDHEMLABFD<T>(float PCFGHPNONAI, GAMKDKPALGP HKOJAHCOOEL, Action<T> MOIIPMBKBLO, T HBNMBAEKPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x832B120", Offset = "0x832A520", VA = "0x18832B120")]
	[IteratorStateMachine(typeof(GFGLPJCPOLM))]
	private static IEnumerator<CIKDDGFOAFI> LLLCJPJMNMM(float PCFGHPNONAI, GAMKDKPALGP HKOJAHCOOEL, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x832AEB0", Offset = "0x832A2B0", VA = "0x18832AEB0")]
	public static IDisposable KLKBCPJGAEN(this MonoBehaviour NAECADIONFH, float PCFGHPNONAI, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x832B1C0", Offset = "0x832A5C0", VA = "0x18832B1C0")]
	public static LBKCJDEOHAA MCLPMOKEJOI(this MonoBehaviour NAECADIONFH, float PCFGHPNONAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x832AF90", Offset = "0x832A390", VA = "0x18832AF90")]
	public static LBKCJDEOHAA KLKBCPJGAEN(this MonoBehaviour NAECADIONFH, float PCFGHPNONAI, GAMKDKPALGP HKOJAHCOOEL, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x832ABA0", Offset = "0x8329FA0", VA = "0x18832ABA0")]
	public static LBKCJDEOHAA ENCGMEHJGKB(this MonoBehaviour NAECADIONFH, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3406F50", Offset = "0x3406350", VA = "0x183406F50")]
	public static LBKCJDEOHAA ENCGMEHJGKB<T>(this MonoBehaviour NAECADIONFH, Action<T> MOIIPMBKBLO, T HBNMBAEKPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x832AB00", Offset = "0x8329F00", VA = "0x18832AB00")]
	public static LBKCJDEOHAA CBLDEGFLMPP(this MonoBehaviour NAECADIONFH, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x832B390", Offset = "0x832A790", VA = "0x18832B390")]
	public static LBKCJDEOHAA PPJCOANLDPA(this MonoBehaviour NAECADIONFH, Action MOIIPMBKBLO, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x832AD80", Offset = "0x832A180", VA = "0x18832AD80")]
	public static LBKCJDEOHAA ICBJDAKCGDI(this MonoBehaviour NAECADIONFH, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x832B250", Offset = "0x832A650", VA = "0x18832B250")]
	public static LBKCJDEOHAA NHMOJGDLCDG(this MonoBehaviour NAECADIONFH, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x832B2F0", Offset = "0x832A6F0", VA = "0x18832B2F0")]
	public static LBKCJDEOHAA PAPKEPHIAEJ(MonoBehaviour NAECADIONFH, GAMKDKPALGP BIENFMKKIBH, Action MOIIPMBKBLO, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3407080", Offset = "0x3406480", VA = "0x183407080")]
	public static LBKCJDEOHAA PAPKEPHIAEJ<T>(MonoBehaviour NAECADIONFH, GAMKDKPALGP BIENFMKKIBH, Action<T> MOIIPMBKBLO, T HBNMBAEKPFF, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x832AE20", Offset = "0x832A220", VA = "0x18832AE20")]
	public static LBKCJDEOHAA JPJAHFNFHEE(this MonoBehaviour NAECADIONFH, float LDNIDDBEFHG, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x832ACE0", Offset = "0x832A0E0", VA = "0x18832ACE0")]
	public static LBKCJDEOHAA HCAKKDHIPJH(this MonoBehaviour NAECADIONFH, float LDNIDDBEFHG, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x832B080", Offset = "0x832A480", VA = "0x18832B080")]
	public static LBKCJDEOHAA LJJEJMAIIMF(this MonoBehaviour NAECADIONFH, float LDNIDDBEFHG, Action MOIIPMBKBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x832AA60", Offset = "0x8329E60", VA = "0x18832AA60")]
	public static LBKCJDEOHAA BOHDLFFADAI(this MonoBehaviour NAECADIONFH, float LDNIDDBEFHG, Action MOIIPMBKBLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class KAGADOACIFP : DJEHKBEDOAJ, IEnumerable<DJEHKBEDOAJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<DJEHKBEDOAJ> PPKFLPGADFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool GLNMJBGEPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action MDAFFLLJPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool IHMPICIMKLE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JJAMIFJHILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x833AA40", Offset = "0x8339E40", VA = "0x18833AA40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FHAMINJBFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x833A9A0", Offset = "0x8339DA0", VA = "0x18833A9A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x833B180", Offset = "0x833A580", VA = "0x18833B180", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x833B220", Offset = "0x833A620", VA = "0x18833B220")]
	public KAGADOACIFP([Optional] Action MDAFFLLJPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x833B050", Offset = "0x833A450", VA = "0x18833B050")]
	public void JJBKLNLGAIJ(DJEHKBEDOAJ MEHIBDIGAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x833AB70", Offset = "0x8339F70", VA = "0x18833AB70")]
	private void EBFHHHFLGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x833AD40", Offset = "0x833A140", VA = "0x18833AD40", Slot = "7")]
	public bool HBCFHNCJIDJ(bool HLPBIKLHEBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x833AD50", Offset = "0x833A150", VA = "0x18833AD50", Slot = "8")]
	public bool HBCFHNCJIDJ(Action IOPCFKOHPBF, bool HLPBIKLHEBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x833ACC0", Offset = "0x833A0C0", VA = "0x18833ACC0", Slot = "9")]
	public IEnumerator<DJEHKBEDOAJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x833ACC0", Offset = "0x833A0C0", VA = "0x18833ACC0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class EOABDIBPEHI : PNBKHDLGNEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HGMMECKMOHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public EOABDIBPEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public HGMMECKMOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x83387D0", Offset = "0x8337BD0", VA = "0x1883387D0")]
		internal void MNCDBBPFBPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class KCOKDOBKAAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public EOABDIBPEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public KCOKDOBKAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x83387D0", Offset = "0x8337BD0", VA = "0x1883387D0")]
		internal void LKKLAOFFFJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float AIJBPJBEONK;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x83331D0", Offset = "0x83325D0", VA = "0x1883331D0")]
	public EOABDIBPEHI(Behaviour PCJJKLDOJMD, float AIJBPJBEONK, [Optional] Action MDAFFLLJPAL, [Optional] OKJPOJGEILK AAECGIEPKCK, [Optional] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8332FB0", Offset = "0x83323B0", VA = "0x188332FB0", Slot = "9")]
	protected override bool CFDCDBJNLDN(Action IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x83330C0", Offset = "0x83324C0", VA = "0x1883330C0", Slot = "10")]
	protected override bool KNINGLDHADG(Action IOPCFKOHPBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface DJEHKBEDOAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JJAMIFJHILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action FHAMINJBFEO;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HBCFHNCJIDJ(bool HLPBIKLHEBD = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HBCFHNCJIDJ(Action IOPCFKOHPBF, bool HLPBIKLHEBD = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class PNBKHDLGNEJ : DJEHKBEDOAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class GLCMCEICOGN : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public PNBKHDLGNEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public GLCMCEICOGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x83382B0", Offset = "0x83376B0", VA = "0x1883382B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8338380", Offset = "0x8337780", VA = "0x188338380", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour PCJJKLDOJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action MDAFFLLJPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NAHOFKDLLJE JACIHFOFPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly OKJPOJGEILK AAECGIEPKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly FDGCEIPODAG HNJDEELBCLI;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JJAMIFJHILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1912960", Offset = "0x1911D60", VA = "0x181912960", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action FHAMINJBFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8343490", Offset = "0x8342890", VA = "0x188343490", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8343900", Offset = "0x8342D00", VA = "0x188343900", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x83439C0", Offset = "0x8342DC0", VA = "0x1883439C0")]
	protected PNBKHDLGNEJ(Behaviour PCJJKLDOJMD, [Optional] Action MDAFFLLJPAL, [Optional] OKJPOJGEILK AAECGIEPKCK, [Optional] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x83435B0", Offset = "0x83429B0", VA = "0x1883435B0", Slot = "7")]
	public bool HBCFHNCJIDJ(bool HLPBIKLHEBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8343610", Offset = "0x8342A10", VA = "0x188343610", Slot = "8")]
	public bool HBCFHNCJIDJ(Action IOPCFKOHPBF, bool HLPBIKLHEBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool CFDCDBJNLDN(Action IOPCFKOHPBF);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool KNINGLDHADG(Action IOPCFKOHPBF);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x83439A0", Offset = "0x8342DA0", VA = "0x1883439A0")]
	protected void PIADILGJJEM(Action IOPCFKOHPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8343670", Offset = "0x8342A70", VA = "0x188343670")]
	protected DJNFHDJGNJD HGOENGHLNJN(float HLOBKBPABIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8343530", Offset = "0x8342930", VA = "0x188343530")]
	private void GCFJIDMKDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8343400", Offset = "0x8342800", VA = "0x188343400")]
	[IteratorStateMachine(typeof(GLCMCEICOGN))]
	private IEnumerator<CIKDDGFOAFI> AJHCGPCJBJF(float HLOBKBPABIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x83438C0", Offset = "0x8342CC0", VA = "0x1883438C0")]
	[CompilerGenerated]
	private void ILKENLLDHAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class ECIFCJKGEGP : PNBKHDLGNEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float BEFOJHNAJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int IDNGCCJFKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float ODNKAOCCDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] NIEFOJLJBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int NGNMNAMFDFC;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8332100", Offset = "0x8331500", VA = "0x188332100")]
	public ECIFCJKGEGP(Behaviour PCJJKLDOJMD, float KHAKPFDJJKN, int IDNGCCJFKFP, [Optional] Action MDAFFLLJPAL, float ODNKAOCCDPJ = 0f, [Optional] OKJPOJGEILK AAECGIEPKCK, [Optional] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "9")]
	protected override bool CFDCDBJNLDN(Action IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8331E80", Offset = "0x8331280", VA = "0x188331E80", Slot = "10")]
	protected override bool KNINGLDHADG(Action IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8332080", Offset = "0x8331480", VA = "0x188332080")]
	private void OILFMMHCNCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NOEGKFAECBB : PNBKHDLGNEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float AIJBPJBEONK;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x83331D0", Offset = "0x83325D0", VA = "0x1883331D0")]
	public NOEGKFAECBB(Behaviour PCJJKLDOJMD, float AIJBPJBEONK, [Optional] Action MDAFFLLJPAL, [Optional] OKJPOJGEILK AAECGIEPKCK, [Optional] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "9")]
	protected override bool CFDCDBJNLDN(Action IOPCFKOHPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8343040", Offset = "0x8342440", VA = "0x188343040", Slot = "10")]
	protected override bool KNINGLDHADG(Action IOPCFKOHPBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class AJDMEBAFFAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IGFJBIIDEMM : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public IGFJBIIDEMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8338920", Offset = "0x8337D20", VA = "0x188338920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8338C90", Offset = "0x8338090", VA = "0x188338C90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private LBKCJDEOHAA MLOFDBNNNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private IGCLHBDADKK PCJJKLDOJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> FEGHKFKPHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private GAMKDKPALGP BIENFMKKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float JNCHGHHILLH;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x83290B0", Offset = "0x83284B0", VA = "0x1883290B0")]
	public AJDMEBAFFAP(IGCLHBDADKK PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8328D90", Offset = "0x8328190", VA = "0x188328D90")]
	private void GBINAKHHHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8328F80", Offset = "0x8328380", VA = "0x188328F80")]
	private void ONOALJGAMCL(string AFHGIBDEPMG, Action IFINDMOOMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8328F00", Offset = "0x8328300", VA = "0x188328F00")]
	[IteratorStateMachine(typeof(IGFJBIIDEMM))]
	private IEnumerator<CIKDDGFOAFI> IGLOPBEHCPA(Action IFINDMOOMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8328BB0", Offset = "0x8327FB0", VA = "0x188328BB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8328C10", Offset = "0x8328010", VA = "0x188328C10")]
	[CompilerGenerated]
	private void EOKGGLHEJMC(string DLAPGFGBDMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class NBCOOEPKKED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class HMIGOLOONNL : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public HMIGOLOONNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8338920", Offset = "0x8337D20", VA = "0x188338920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8338990", Offset = "0x8337D90", VA = "0x188338990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private LBKCJDEOHAA MLOFDBNNNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour NAECADIONFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action MMFCHLFFDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> FEGHKFKPHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private GAMKDKPALGP BIENFMKKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float JNCHGHHILLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool DFODLBNPDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly OKJPOJGEILK AAECGIEPKCK;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x833FB80", Offset = "0x833EF80", VA = "0x18833FB80")]
	public NBCOOEPKKED(MonoBehaviour NAECADIONFH, Action MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x833FD10", Offset = "0x833F110", VA = "0x18833FD10")]
	public NBCOOEPKKED(MonoBehaviour NAECADIONFH, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x833F9A0", Offset = "0x833EDA0", VA = "0x18833F9A0")]
	public NBCOOEPKKED(MonoBehaviour NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x49727B0", Offset = "0x4971BB0", VA = "0x1849727B0")]
	private NBCOOEPKKED(OKJPOJGEILK AAECGIEPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x833ED70", Offset = "0x833E170", VA = "0x18833ED70")]
	internal static NBCOOEPKKED AAAHBMLBMKN(MonoBehaviour NAECADIONFH, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, [Optional] OKJPOJGEILK AAECGIEPKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x833F410", Offset = "0x833E810", VA = "0x18833F410")]
	private void MFDBAPBBBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x833F540", Offset = "0x833E940", VA = "0x18833F540")]
	private void NFIAFHAGNDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x833F000", Offset = "0x833E400", VA = "0x18833F000")]
	private void GBINAKHHHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x833F280", Offset = "0x833E680", VA = "0x18833F280")]
	private void IPNDPPOKLHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x833F870", Offset = "0x833EC70", VA = "0x18833F870")]
	private void ONOALJGAMCL(string AFHGIBDEPMG, Action IFINDMOOMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x833F200", Offset = "0x833E600", VA = "0x18833F200")]
	[IteratorStateMachine(typeof(HMIGOLOONNL))]
	private IEnumerator<CIKDDGFOAFI> IGLOPBEHCPA(Action IFINDMOOMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x833EFA0", Offset = "0x833E3A0", VA = "0x18833EFA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x833F6C0", Offset = "0x833EAC0", VA = "0x18833F6C0")]
	[CompilerGenerated]
	private void NNLJKFMJEPN(string DLAPGFGBDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x833F170", Offset = "0x833E570", VA = "0x18833F170")]
	[CompilerGenerated]
	private void HAFLBBMFJLL(string DLAPGFGBDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x833F7E0", Offset = "0x833EBE0", VA = "0x18833F7E0")]
	[CompilerGenerated]
	private void OCKKCFENNAK(string DLAPGFGBDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x833F750", Offset = "0x833EB50", VA = "0x18833F750")]
	[CompilerGenerated]
	private void OCIKAJHNOLA(string DLAPGFGBDMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum OACGLJJDPGH : byte
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
internal sealed class JFDFEFGGJOL : FDGCEIPODAG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float OKGGONCOGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8339600", Offset = "0x8338A00", VA = "0x188339600", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float JEHINFIHNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8339610", Offset = "0x8338A10", VA = "0x188339610", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double KFDEODFGGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x83395E0", Offset = "0x83389E0", VA = "0x1883395E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8339570", Offset = "0x8338970", VA = "0x188339570")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void BBLAOBGDHMG(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	[UnityEngine.Scripting.Preserve]
	internal JFDFEFGGJOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface CAKEIPBDAHI
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLFDMDAFOJA(string IGEPDAOOLBO);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBMBHPJMPMC();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface HEOACCKMHOL
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool ECMLJIKMDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool FDBBOLDOOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class GBNOEHEDBEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public NHMLKJIGJMP JHHDOLAHEDJ;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int FBMJOLKHIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9A9250", Offset = "0x9A8650", VA = "0x1809A9250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8335F50", Offset = "0x8335350", VA = "0x188335F50")]
	public static CIKDDGFOAFI LGHLLEGIGPB(IEnumerator<CIKDDGFOAFI> GBBPIGBGDCL, MBBBLOJIOMF MCOJNHGAONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8335E90", Offset = "0x8335290", VA = "0x188335E90")]
	public CIKDDGFOAFI LGHLLEGIGPB(MBBBLOJIOMF[] CBBKNJBDLJL, IEnumerator<CIKDDGFOAFI>[] LGMPNMHCPPB, CIKDDGFOAFI[] EBKDHPDJIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8335BE0", Offset = "0x8334FE0", VA = "0x188335BE0")]
	public void ADLELANCLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x8335D50", Offset = "0x8335150", VA = "0x188335D50")]
	public void CMPHFJMAPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8335C10", Offset = "0x8335010", VA = "0x188335C10")]
	public void ANLMKPPOALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8335BE0", Offset = "0x8334FE0", VA = "0x188335BE0")]
	public void OAALHNMPGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public GBNOEHEDBEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class NHMLKJIGJMP
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct KGNFAKIEGDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public GBNOEHEDBEN GDIJDLEPGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public IGCLHBDADKK CLJDABMONFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public MBBBLOJIOMF AOPIMFKAFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<CIKDDGFOAFI> LMDAPDGOMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public CIKDDGFOAFI LJNAJLFNOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public OACGLJJDPGH BEEFDAEONPE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct DECHIOKAOLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public GAMKDKPALGP EFCNOOGOMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<KGNFAKIEGDN> OMNKEHEBJGG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class PNDPNNEMGOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public MBBBLOJIOMF promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public NHMLKJIGJMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public IGCLHBDADKK context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public GBNOEHEDBEN routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public OACGLJJDPGH coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public CIKDDGFOAFI currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<CIKDDGFOAFI> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public PNDPNNEMGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8343AF0", Offset = "0x8342EF0", VA = "0x188343AF0")]
		internal void BCNABLCHONL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class PGGBEIALLLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public GBNOEHEDBEN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public NHMLKJIGJMP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public PGGBEIALLLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x83433C0", Offset = "0x83427C0", VA = "0x1883433C0")]
		internal void BLKCPEFOIJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class MMGOEHIIGHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public GBNOEHEDBEN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public NHMLKJIGJMP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MMGOEHIIGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x833ED30", Offset = "0x833E130", VA = "0x18833ED30")]
		internal void MGIPHIGEHED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class MBNBIDAAJGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public GBNOEHEDBEN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public NHMLKJIGJMP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MBNBIDAAJGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x833EB10", Offset = "0x833DF10", VA = "0x18833EB10")]
		internal void PABOHAMPAJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const OACGLJJDPGH NJMGPHKOEKD = OACGLJJDPGH.Cancelled | OACGLJJDPGH.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly GAMKDKPALGP BIENFMKKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] KOFBPPDBHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<OACGLJJDPGH> PNENGCBEBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> LHANKFAALEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> OBMNFBMILGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> LBGALJMFHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> MFLMHNPBIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> PGMHMIIGAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> MJJIJAALFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private GBNOEHEDBEN[] KJBPDJHOPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private MBBBLOJIOMF[] CBBKNJBDLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private IGCLHBDADKK[] OIGAFJAHKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<CIKDDGFOAFI>[] DCNOBCCMECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private CIKDDGFOAFI[] ABIPCLGNNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int ALCKNAMILAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int HDAIOJEADNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int OPFOLNCOPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float OLKGNKAPBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NDLFNEMCILE HGGAOPDPLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle HIEFNCHKCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<GBNOEHEDBEN> GHIGPMGACCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool LMGCCHBOBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> EMJJAHADJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> ILODFOJAJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool BPBLJHNDPBA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public DECHIOKAOLK[] BOPNDGKMOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA25CB0", Offset = "0xA250B0", VA = "0x180A25CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8341080", Offset = "0x8340480", VA = "0x188341080")]
	private static int CJNNGIMGOKC(GAMKDKPALGP BIENFMKKIBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x83429F0", Offset = "0x8341DF0", VA = "0x1883429F0")]
	public NHMLKJIGJMP(GAMKDKPALGP BIENFMKKIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8340660", Offset = "0x833FA60", VA = "0x188340660")]
	private void ALEJIPPDALK(int PODLDNMBBNM, int MJHFBPPAICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8342870", Offset = "0x8341C70", VA = "0x188342870")]
	public void OCCCLCPPHME(IGCLHBDADKK PCJJKLDOJMD, CIKDDGFOAFI KPAKACAAIJC, IEnumerator<CIKDDGFOAFI> GBBPIGBGDCL, MBBBLOJIOMF MCOJNHGAONG, [Optional] GBNOEHEDBEN AABJHAPOCNF, OACGLJJDPGH OLFHIKKHACA = OACGLJJDPGH.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8341CB0", Offset = "0x83410B0", VA = "0x188341CB0")]
	public void IHGDPCFIMLB(IEnumerable<KGNFAKIEGDN> GIMCMPMHEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8342270", Offset = "0x8341670", VA = "0x188342270")]
	private KGNFAKIEGDN MELJDDGCDHI(int OHKKOKEAPLK)
	{
		return default(KGNFAKIEGDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8340BE0", Offset = "0x833FFE0", VA = "0x188340BE0")]
	private void CEMEAOJCNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x37D0E80", Offset = "0x37D0280", VA = "0x1837D0E80")]
	private static void PPKJIJBAAPL<T>(int OHKKOKEAPLK, T[] BOMDALFHOCL, int MNDMOIHIBEI, [Optional] T LIIPLKNMBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x37D0ED0", Offset = "0x37D02D0", VA = "0x1837D0ED0")]
	private static void PPKJIJBAAPL<T>(int OHKKOKEAPLK, NativeArray<T> BOMDALFHOCL, int MNDMOIHIBEI, [Optional] T LIIPLKNMBHL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8340840", Offset = "0x833FC40", VA = "0x188340840")]
	private void BONHCFEHAFB(IEnumerable<KGNFAKIEGDN> GIMCMPMHEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8342020", Offset = "0x8341420", VA = "0x188342020")]
	private void KCAMFNEKCPM(KGNFAKIEGDN FKMNMHEKICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8341330", Offset = "0x8340730", VA = "0x188341330")]
	private FOFLFGDMFGB EKGJOLGNAON(int KBEEJILCKBE)
	{
		return default(FOFLFGDMFGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8341130", Offset = "0x8340530", VA = "0x188341130")]
	public void EHJIKHCFNEK(float BKAEDIDGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x83420F0", Offset = "0x83414F0", VA = "0x1883420F0")]
	private void LIOLJOMFEMN(Action PCMHLCLONGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x83410B0", Offset = "0x83404B0", VA = "0x1883410B0")]
	private void DCJBLPLNJMK(Action PCMHLCLONGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8341590", Offset = "0x8340990", VA = "0x188341590")]
	public void IHALPLMJDGH(float BKAEDIDGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8342170", Offset = "0x8341570", VA = "0x188342170")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8342740", Offset = "0x8341B40", VA = "0x188342740")]
	public void OAALHNMPGBB(GBNOEHEDBEN FLNEKKEJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8340F50", Offset = "0x8340350", VA = "0x188340F50")]
	public void CFLFBJOCAIG(GBNOEHEDBEN FLNEKKEJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8341EF0", Offset = "0x83412F0", VA = "0x188341EF0")]
	public void ILAJGDCMNKH(GBNOEHEDBEN FLNEKKEJNHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class HEIJPMDAFBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly HEIJPMDAFBL GBADJOAJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action JECALFIKEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool ACJJLPFCEAB;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	public HEIJPMDAFBL(Action JECALFIKEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x79EFCB0", Offset = "0x79EF0B0", VA = "0x1879EFCB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface IAMKHIAIKCA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MLEPBBKMOOK(UnityEngine.Object PCJJKLDOJMD, Action<T> NCAMGLOANBB);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface GKIPKGMAALG<T> : IAMKHIAIKCA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class KHJCMBHAHKL<T> : GKIPKGMAALG<T>, IAMKHIAIKCA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class AMAABNLJHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public KHJCMBHAHKL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public FFBPAJLKGII<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public AMAABNLJHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x49F6AC0", Offset = "0x49F5EC0", VA = "0x1849F6AC0")]
		internal void GPBKKNDHDMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject FHFFINAENIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<FFBPAJLKGII<UnityEngine.Object, Action<T>>> EKKPACHKBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T LLLNOEOKELG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA11750", Offset = "0xA10B50", VA = "0x180A11750", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4D8FBA0", Offset = "0x4D8EFA0", VA = "0x184D8FBA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4D902D0", Offset = "0x4D8F6D0", VA = "0x184D902D0")]
	private static bool LPPBFOOCKEG(T PCMHLCLONGN, T IAJJOLNCJOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4D906F0", Offset = "0x4D8FAF0", VA = "0x184D906F0")]
	public KHJCMBHAHKL(T EKGCIKACHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D90540", Offset = "0x4D8F940", VA = "0x184D90540", Slot = "6")]
	public IDisposable MLEPBBKMOOK(UnityEngine.Object PCJJKLDOJMD, Action<T> NCAMGLOANBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D8FF70", Offset = "0x4D8F370", VA = "0x184D8FF70")]
	private void GDDNOKOHBKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class FPCJJHPDKMI : KEOINNCCKOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class BOEPCIBHJBB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class GNGMLHKJNEC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int NCJKGMLAKGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private BOEPCIBHJBB HKOJAHCOOEL;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xE01330", Offset = "0xE00730", VA = "0x180E01330")]
			public GNGMLHKJNEC(int NCJKGMLAKGH, BOEPCIBHJBB HKOJAHCOOEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x83385B0", Offset = "0x83379B0", VA = "0x1883385B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class NGEKEHHPLIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public NGEKEHHPLIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xD1D8E0", Offset = "0xD1CCE0", VA = "0x180D1D8E0")]
			internal bool NGFGJPIFGOC(JALALGGPCLJ e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class KKKMADCKLGK : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private CIKDDGFOAFI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public BOEPCIBHJBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public FDGCEIPODAG timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private PHPFGDACENL <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<JALALGGPCLJ> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
			[DebuggerHidden]
			public KKKMADCKLGK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x833C2B0", Offset = "0x833B6B0", VA = "0x18833C2B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x833C5E0", Offset = "0x833B9E0", VA = "0x18833C5E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly GAMKDKPALGP BIENFMKKIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private LBKCJDEOHAA MCOJNHGAONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<JALALGGPCLJ> HHOLFJLOEJL;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x832A530", Offset = "0x8329930", VA = "0x18832A530")]
		public BOEPCIBHJBB(GAMKDKPALGP BIENFMKKIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x832A130", Offset = "0x8329530", VA = "0x18832A130")]
		public IDisposable ANEJECHBGKN(JALALGGPCLJ BKLJHDMJNEA, OKJPOJGEILK AAECGIEPKCK, FDGCEIPODAG KINEPAABOFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x832A3A0", Offset = "0x83297A0", VA = "0x18832A3A0")]
		private void OJAIDPJMDOF(int NCJKGMLAKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x832A310", Offset = "0x8329710", VA = "0x18832A310")]
		[IteratorStateMachine(typeof(KKKMADCKLGK))]
		private IEnumerator<CIKDDGFOAFI> EDDLKNGFLFE(FDGCEIPODAG KINEPAABOFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x832A2C0", Offset = "0x83296C0", VA = "0x18832A2C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class JALALGGPCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum FODDNBJJPBE : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int APGOMNDIOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int GEEBDAOOGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly LEGAGIOCBAL CLJDABMONFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour DHHDFDMMIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action ODNOMLGNGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> BFBKADHEJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float PHKFCIELCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float LHANKFAALEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string KAFLMFCDNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool FPFKHADGAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly FODDNBJJPBE AMNBOGOIAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool KMBKKINPIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool KCCNHOPHFAK;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8339210", Offset = "0x8338610", VA = "0x188339210")]
		public JALALGGPCLJ(LEGAGIOCBAL PCJJKLDOJMD, Action MMFCHLFFDDH, bool LHBMPBEGJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8339090", Offset = "0x8338490", VA = "0x188339090")]
		public JALALGGPCLJ(LEGAGIOCBAL PCJJKLDOJMD, Action<float> MMFCHLFFDDH, bool LHBMPBEGJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8338EB0", Offset = "0x83382B0", VA = "0x188338EB0")]
		public JALALGGPCLJ(LEGAGIOCBAL PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> MMFCHLFFDDH, FDGCEIPODAG KINEPAABOFB, FODDNBJJPBE AJPEELGFJOG, bool DFODLBNPDAD, bool LHBMPBEGJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8338CE0", Offset = "0x83380E0", VA = "0x188338CE0")]
		public bool FBEKCKILPGH(float GLBFMHKMALN, float ENOGEACDIOG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly OKJPOJGEILK AAECGIEPKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly FDGCEIPODAG HNJDEELBCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<GAMKDKPALGP, BOEPCIBHJBB> HNMAOHCOFKH;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8335310", Offset = "0x8334710", VA = "0x188335310")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void IINEJNNLFDN(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8335B20", Offset = "0x8334F20", VA = "0x188335B20")]
	[UnityEngine.Scripting.Preserve]
	internal FPCJJHPDKMI([CMKKAFOAFJE(null)] OKJPOJGEILK AAECGIEPKCK, [CMKKAFOAFJE(null)] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8335740", Offset = "0x8334B40", VA = "0x188335740", Slot = "4")]
	public IDisposable ODNOMLGNGJI(LEGAGIOCBAL PCJJKLDOJMD, Action ADLKPPBLCIG, GAMKDKPALGP BIENFMKKIBH, bool LHBMPBEGJFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8335930", Offset = "0x8334D30", VA = "0x188335930", Slot = "5")]
	public IDisposable ODNOMLGNGJI(LEGAGIOCBAL PCJJKLDOJMD, Action<float> ADLKPPBLCIG, GAMKDKPALGP BIENFMKKIBH, bool LHBMPBEGJFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x8335640", Offset = "0x8334A40", VA = "0x188335640", Slot = "7")]
	public IDisposable MOFODJDOAFP(LEGAGIOCBAL PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> ADLKPPBLCIG, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x8335210", Offset = "0x8334610", VA = "0x188335210", Slot = "8")]
	public IDisposable GFABCJJHMFB(LEGAGIOCBAL PCJJKLDOJMD, float MIFCKAIMGDB, Action<float> ADLKPPBLCIG, GAMKDKPALGP BIENFMKKIBH, bool DFODLBNPDAD = true, bool LHBMPBEGJFF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x83354C0", Offset = "0x83348C0", VA = "0x1883354C0", Slot = "6")]
	public IDisposable MOFODJDOAFP(float MIFCKAIMGDB, Action<float> ADLKPPBLCIG, bool DFODLBNPDAD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8335050", Offset = "0x8334450", VA = "0x188335050", Slot = "9")]
	public void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8335380", Offset = "0x8334780", VA = "0x188335380")]
	private BOEPCIBHJBB LMOIAMKNKEF(GAMKDKPALGP BIENFMKKIBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class JHLMMGOJCLI : KOGHDGHAPHO, OKJPOJGEILK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NHMLKJIGJMP[] MCKGFDEEMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private CAKEIPBDAHI DGCPLMAGHEN;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8339AF0", Offset = "0x8338EF0", VA = "0x188339AF0")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void BBLAOBGDHMG(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x833A3F0", Offset = "0x83397F0", VA = "0x18833A3F0")]
	[UnityEngine.Scripting.Preserve]
	public JHLMMGOJCLI([CMKKAFOAFJE(null)] JDPMNOBGDAH CFDLKFAJMNB, [CMKKAFOAFJE(null)] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x8339790", Offset = "0x8338B90", VA = "0x188339790", Slot = "19")]
	public override LBKCJDEOHAA AMFPCJCMAHN(IGCLHBDADKK PCJJKLDOJMD, IEnumerator<CIKDDGFOAFI> EIOOPEFHLCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8339F00", Offset = "0x8339300", VA = "0x188339F00", Slot = "20")]
	public override void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x83398C0", Offset = "0x8338CC0", VA = "0x1883398C0", Slot = "22")]
	public override void ANANINHHPGB(GAMKDKPALGP BIENFMKKIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x833A280", Offset = "0x8339680", VA = "0x18833A280", Slot = "21")]
	protected override void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x833A250", Offset = "0x8339650", VA = "0x18833A250")]
	private NHMLKJIGJMP JKFHIMOPLMJ(GAMKDKPALGP HAFNBBNOLPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x8339B60", Offset = "0x8338F60", VA = "0x188339B60", Slot = "23")]
	internal override LGHBHHAOOJF DICGJIJOJDD(IEnumerator<CIKDDGFOAFI> EIOOPEFHLCK, Behaviour PCJJKLDOJMD, MBBBLOJIOMF MCOJNHGAONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x833A190", Offset = "0x8339590", VA = "0x18833A190", Slot = "24")]
	internal override GIPJODCKMLH JGHCOBFMLLP(GAMKDKPALGP HKOJAHCOOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x8339DE0", Offset = "0x83391E0", VA = "0x188339DE0")]
	private void EIIKJGDNGOB(NHMLKJIGJMP CCMBCEALLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x8339D80", Offset = "0x8339180", VA = "0x188339D80", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct NDLFNEMCILE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float HEJIEJPJLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int LIGBLGELFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> ONANBCEJINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> AHNKEMICNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> PBKOPOLGIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<OACGLJJDPGH> HKMHONJLOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> CKFFPCGLIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> MFLMHNPBIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> OBMNFBMILGF;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x83402F0", Offset = "0x833F6F0", VA = "0x1883402F0")]
	public static NDLFNEMCILE GNHEPACBJCH(int JNPEAKNMDLH, float BKAEDIDGDFB, NativeArray<OACGLJJDPGH> KDEMDDLPBGP, NativeArray<float> CKEHLEAKIFC, NativeArray<int> AEOBJHJIIDB, NativeArray<int> EMBDFAJANLH, NativeArray<int> JLOMNDADBOC, NativeArray<int> AHNKEMICNBI, NativeArray<int> PBKOPOLGIBJ)
	{
		return default(NDLFNEMCILE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8340140", Offset = "0x833F540", VA = "0x188340140", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8340100", Offset = "0x833F500", VA = "0x188340100")]
	private bool AOIEGAKOAIJ(int CJFNAFNJJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x83403F0", Offset = "0x833F7F0", VA = "0x1883403F0")]
	private void NDLEAIEGFGE(NativeArray<int> MIMDNIFNNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8340350", Offset = "0x833F750", VA = "0x188340350")]
	private int LMNBLCGLNLI(int DIAFJLNIJNO, int GLBDMKECJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8340220", Offset = "0x833F620", VA = "0x188340220")]
	private void FGOJDLFLDKG(NativeArray<int> MIMDNIFNNPJ, int BBBBOBBEJCK, int IEDBNFIMLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8340420", Offset = "0x833F820", VA = "0x188340420")]
	private void PMPGEOIIDNN(NativeArray<int> MIMDNIFNNPJ, int POOBILCHBAO, int JLCDNJBBDIA, int AFAPDNGLGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class KOGHDGHAPHO : OKJPOJGEILK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly JDPMNOBGDAH CFDLKFAJMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly FDGCEIPODAG HNJDEELBCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private GIPJODCKMLH[] LPLICKAICEI;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static OKJPOJGEILK DNEPPKLGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x833D4C0", Offset = "0x833C8C0", VA = "0x18833D4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool LCONPCPHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public GAMKDKPALGP HOANBAIMLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GAMKDKPALGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9A9250", Offset = "0x9A8650", VA = "0x1809A9250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public FDGCEIPODAG GEIBEFEOHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public CIKDDGFOAFI HPODLCAMKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public CIKDDGFOAFI HOMHMNKLFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9AA330", Offset = "0x9A9730", VA = "0x1809AA330", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public CIKDDGFOAFI OLBBJOEJENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9AA390", Offset = "0x9A9790", VA = "0x1809AA390", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CIKDDGFOAFI EDPFJFAACDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A60", Offset = "0x9A8E60", VA = "0x1809A9A60", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x833CF40", Offset = "0x833C340", VA = "0x18833CF40")]
	public static LBKCJDEOHAA EGCLGLCIAAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x833D590", Offset = "0x833C990", VA = "0x18833D590")]
	[UnityEngine.Scripting.Preserve]
	protected KOGHDGHAPHO([CMKKAFOAFJE(null)] JDPMNOBGDAH CFDLKFAJMNB, [CMKKAFOAFJE(null)] FDGCEIPODAG HNJDEELBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x833C800", Offset = "0x833BC00", VA = "0x18833C800", Slot = "6")]
	public LBKCJDEOHAA AMNMBKBGPIL(IEnumerator<CIKDDGFOAFI> EIOOPEFHLCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x833C810", Offset = "0x833BC10", VA = "0x18833C810", Slot = "7")]
	public LBKCJDEOHAA AMNMBKBGPIL(Behaviour PCJJKLDOJMD, IEnumerator<CIKDDGFOAFI> EIOOPEFHLCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract LBKCJDEOHAA AMFPCJCMAHN(IGCLHBDADKK PCJJKLDOJMD, IEnumerator<CIKDDGFOAFI> EIOOPEFHLCK);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x833D210", Offset = "0x833C610", VA = "0x18833D210", Slot = "20")]
	public virtual void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x833CFD0", Offset = "0x833C3D0", VA = "0x18833CFD0", Slot = "9")]
	public void FGADMBDMOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x833D550", Offset = "0x833C950", VA = "0x18833D550", Slot = "21")]
	protected virtual void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x833D570", Offset = "0x833C970", VA = "0x18833D570")]
	private void PAALEGAGDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x833CAA0", Offset = "0x833BEA0", VA = "0x18833CAA0")]
	private void BGLIKCCEPAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x833D530", Offset = "0x833C930", VA = "0x18833D530")]
	private void NACCOEPNHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x833D3B0", Offset = "0x833C7B0", VA = "0x18833D3B0")]
	private void GLMKDEJNHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x833CAC0", Offset = "0x833BEC0", VA = "0x18833CAC0")]
	private void CIFABKMFNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x833CB40", Offset = "0x833BF40", VA = "0x18833CB40")]
	private void DNHAOKGOAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x833CF20", Offset = "0x833C320", VA = "0x18833CF20")]
	private void EFJAELFFHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x833CA10", Offset = "0x833BE10", VA = "0x18833CA10", Slot = "22")]
	public virtual void ANANINHHPGB(GAMKDKPALGP BIENFMKKIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x833C630", Offset = "0x833BA30", VA = "0x18833C630")]
	private void ADJHAALFDEO(GIPJODCKMLH CCMBCEALLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x257ABA0", Offset = "0x2579FA0", VA = "0x18257ABA0")]
	private GIPJODCKMLH AHODPDGPPHF(GAMKDKPALGP HAFNBBNOLPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract LGHBHHAOOJF DICGJIJOJDD(IEnumerator<CIKDDGFOAFI> EIOOPEFHLCK, Behaviour NAECADIONFH, MBBBLOJIOMF CNMNNNBIJND);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract GIPJODCKMLH JGHCOBFMLLP(GAMKDKPALGP BIENFMKKIBH);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x833CB60", Offset = "0x833BF60", VA = "0x18833CB60", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x833CAE0", Offset = "0x833BEE0", VA = "0x18833CAE0", Slot = "15")]
	public CIKDDGFOAFI DEOODLAONOC(GAMKDKPALGP HKOJAHCOOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x833D430", Offset = "0x833C830", VA = "0x18833D430", Slot = "16")]
	public CIKDDGFOAFI LJKOBIKBPKF(float PCFGHPNONAI, GAMKDKPALGP HKOJAHCOOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x833D3D0", Offset = "0x833C7D0", VA = "0x18833D3D0", Slot = "17")]
	public CIKDDGFOAFI LBJLBEDDCFL(Func<bool> LNDKBMLMEBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class LGHBHHAOOJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly MBBBLOJIOMF MCOJNHGAONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly HEOACCKMHOL PCJJKLDOJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool IAEHCJGCJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string IGEPDAOOLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace GFBGIIKFMLP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<CIKDDGFOAFI> LMDAPDGOMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CIKDDGFOAFI LJNAJLFNOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool AFHDMDMGJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x833DB60", Offset = "0x833CF60", VA = "0x18833DB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool HNLIDJCMAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xB5F7F0", Offset = "0xB5EBF0", VA = "0x180B5F7F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xBAC750", Offset = "0xBABB50", VA = "0x180BAC750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x833DF70", Offset = "0x833D370", VA = "0x18833DF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float AGGDCAALGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xF68650", Offset = "0xF67A50", VA = "0x180F68650")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1220", Offset = "0x6CF0620", VA = "0x186CF1220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x833E250", Offset = "0x833D650", VA = "0x18833E250")]
	public LGHBHHAOOJF(IEnumerator<CIKDDGFOAFI> GBBPIGBGDCL, HEOACCKMHOL PCJJKLDOJMD, MBBBLOJIOMF MCOJNHGAONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x833DC50", Offset = "0x833D050", VA = "0x18833DC50")]
	public CIKDDGFOAFI LGHLLEGIGPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x833DBE0", Offset = "0x833CFE0", VA = "0x18833DBE0")]
	public bool KIDKHJMECCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x833E120", Offset = "0x833D520", VA = "0x18833E120")]
	public void OAALHNMPGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x833E170", Offset = "0x833D570", VA = "0x18833E170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xBF3000", Offset = "0xBF2400", VA = "0x180BF3000")]
	[CompilerGenerated]
	private void IOPJLLHCAPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class MBBBLOJIOMF : MHGNMOLLGMD, LBKCJDEOHAA, NAHOFKDLLJE, DJNFHDJGNJD, IEnumerator, CIKDDGFOAFI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private GAMKDKPALGP LPPMLJFIMDI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private GAMKDKPALGP GAPMHBKJMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xCB2300", Offset = "0xCB1700", VA = "0x180CB2300", Slot = "23")]
		get
		{
			return default(GAMKDKPALGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GAMKDKPALGP JHHDOLAHEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xE60EB0", Offset = "0xE602B0", VA = "0x180E60EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float OCNLPNGCDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xB269A0", Offset = "0xB25DA0", VA = "0x180B269A0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool IAHLOPJBGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x833EA90", Offset = "0x833DE90", VA = "0x18833EA90", Slot = "24")]
	private bool BKIOAHNMIKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x833EAB0", Offset = "0x833DEB0", VA = "0x18833EAB0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x833EAC0", Offset = "0x833DEC0", VA = "0x18833EAC0")]
	public MBBBLOJIOMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum FOFLFGDMFGB : byte
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
internal sealed class GIPJODCKMLH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum FFOBHIMNPDL
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct BAEAKMMJCOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public GAMKDKPALGP EFCNOOGOMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public FFOBHIMNPDL HAGENLFMPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<LGHBHHAOOJF> EJBMPNFFCIG;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly FFOBHIMNPDL[] PAFLBKGNHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly GAMKDKPALGP BIENFMKKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool KPNOJIOOMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly LGHBHHAOOJF[] KOGADAOGAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<LGHBHHAOOJF> NLPBDJPGHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> INLOAMEADOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<LGHBHHAOOJF> LLOCGFDLHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> PDBIPDDAFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly CAKEIPBDAHI AOOELDLLOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool BPBLJHNDPBA;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BAEAKMMJCOP[,] LDBKAKHMJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA390", Offset = "0x9A9790", VA = "0x1809AA390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8337AC0", Offset = "0x8336EC0", VA = "0x188337AC0")]
	public GIPJODCKMLH(GAMKDKPALGP HKOJAHCOOEL, CAKEIPBDAHI AOOELDLLOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x83371F0", Offset = "0x83365F0", VA = "0x1883371F0")]
	public void FJGPAOHPFPP(LGHBHHAOOJF GBBPIGBGDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8336900", Offset = "0x8335D00", VA = "0x188336900")]
	public void CAICJJKCDCD(IList<LGHBHHAOOJF> LGMPNMHCPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8336BF0", Offset = "0x8335FF0", VA = "0x188336BF0")]
	public void DGHDCIAICNO(IList<LGHBHHAOOJF> LGMPNMHCPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8337470", Offset = "0x8336870", VA = "0x188337470")]
	private void HGHJMFKMDLI(LGHBHHAOOJF GBBPIGBGDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8337560", Offset = "0x8336960", VA = "0x188337560")]
	private void NDMJBFCABGN(IList<LGHBHHAOOJF> LGMPNMHCPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x83372F0", Offset = "0x83366F0", VA = "0x1883372F0")]
	private FOFLFGDMFGB GNMAJKFPJBL(LGHBHHAOOJF GBBPIGBGDCL)
	{
		return default(FOFLFGDMFGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x83376E0", Offset = "0x8336AE0", VA = "0x1883376E0")]
	public void ODNOMLGNGJI(float BKAEDIDGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8337000", Offset = "0x8336400", VA = "0x188337000")]
	public void FGADMBDMOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x83365A0", Offset = "0x83359A0", VA = "0x1883365A0")]
	private void AEPFOKAKIBJ(List<LGHBHHAOOJF> LGMPNMHCPPB, Stack<int> FKDODBOKOOK, bool PFOBALJIODA, float AIPDKLKBJCH = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8336EE0", Offset = "0x83362E0", VA = "0x188336EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8337850", Offset = "0x8336C50", VA = "0x188337850")]
	private void OECBFFKDFAC(List<LGHBHHAOOJF> LGMPNMHCPPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class FMIKGMDDAOA : CAKEIPBDAHI
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
	public void LLFDMDAFOJA(string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
	public void IBMBHPJMPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public FMIKGMDDAOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class HBLOPBLACOC : HEOACCKMHOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour NAECADIONFH;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8338600", Offset = "0x8337A00", VA = "0x188338600", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ECMLJIKMDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8338680", Offset = "0x8337A80", VA = "0x188338680", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool FDBBOLDOOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x83385E0", Offset = "0x83379E0", VA = "0x1883385E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	public HBLOPBLACOC(Behaviour NAECADIONFH)
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

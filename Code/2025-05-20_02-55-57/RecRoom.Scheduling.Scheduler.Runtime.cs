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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8757700", Offset = "0x8756900", VA = "0x188757700", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x875C8A0", Offset = "0x875BAA0", VA = "0x18875C8A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
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
		private delegate List<PlayerLoopSystem> HLAPOFJHOKD(List<PlayerLoopSystem> DCBFMCFDDLJ, int CICLCNFBDPD);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct FIDBIMIEPCF
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct NFGJIDBHDBL
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static JGNOJICCDHE ECDIBFFJEJL;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x8759220", Offset = "0x8758420", VA = "0x188759220")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct MAAJDCJDLGC
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static JGNOJICCDHE OMKPEGMGEDD;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x8757790", Offset = "0x8756990", VA = "0x188757790")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct MGDHIOPACAJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static JGNOJICCDHE AKADOLOBBBC;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x87582F0", Offset = "0x87574F0", VA = "0x1887582F0")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct GJLJJADGBFF
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static JGNOJICCDHE GCMKDNHDNFK;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static JGNOJICCDHE BOGHKAMMNDA;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static JGNOJICCDHE FBNOGEJONKN;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static JGNOJICCDHE LBIINHMPFNG;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x874E240", Offset = "0x874D440", VA = "0x18874E240")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct DCLEONDFIMM
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static JGNOJICCDHE GPPINLFCCAA;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x87455B0", Offset = "0x87447B0", VA = "0x1887455B0")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct OKJAHKDMHGL
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static JGNOJICCDHE GCMKDNHDNFK;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static JGNOJICCDHE BOGHKAMMNDA;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static JGNOJICCDHE FBNOGEJONKN;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static JGNOJICCDHE LBIINHMPFNG;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x875AFB0", Offset = "0x875A1B0", VA = "0x18875AFB0")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct DJDIGNFFBHH
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static JGNOJICCDHE GLLFFDHJIFP;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x8745E30", Offset = "0x8745030", VA = "0x188745E30")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct AIFKMPOOLFD
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static JGNOJICCDHE EBOPIKMHMBP;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x873FFB0", Offset = "0x873F1B0", VA = "0x18873FFB0")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct HCPOOEJCGDL
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static JGNOJICCDHE PLKKEGDECMA;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x87501C0", Offset = "0x874F3C0", VA = "0x1887501C0")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct KOMCJFIMCAG
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static JGNOJICCDHE OCCGLAOHJFN;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x8755580", Offset = "0x8754780", VA = "0x188755580")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct JKIIFDOJGBL
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static JGNOJICCDHE FADJIDHNCJM;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x8753970", Offset = "0x8752B70", VA = "0x188753970")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct DLMOAAGKFHD
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static JGNOJICCDHE DBFGNCDLNCE;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x8748270", Offset = "0x8747470", VA = "0x188748270")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct ADJAOOJPKAL
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static JGNOJICCDHE MCHDPJCMNED;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x873FDD0", Offset = "0x873EFD0", VA = "0x18873FDD0")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct LDBDLKNMLMC
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static JGNOJICCDHE LFDGODKCCIN;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x87561F0", Offset = "0x87553F0", VA = "0x1887561F0")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct JOJGAFNFDAJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static JGNOJICCDHE GOJLFOCICHF;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x8753B50", Offset = "0x8752D50", VA = "0x188753B50")]
				public static PlayerLoopSystem LMGACMOMGBA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum PNCKKCAHMKK : byte
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
			public struct LFFBILJGCDH
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class EPAGCHBFJDI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public PNCKKCAHMKK updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
					public EPAGCHBFJDI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x874C9E0", Offset = "0x874BBE0", VA = "0x18874C9E0")]
					internal void FJDDLPKDGDJ()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static NDCOIAMFCNJ<PNCKKCAHMKK> KHEOBMHLFLK;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x87563D0", Offset = "0x87555D0", VA = "0x1887563D0")]
				public static PlayerLoopSystem LMGACMOMGBA(PNCKKCAHMKK BDFLJMOIGCH)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct MLHNGICJEPO
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class HEMCNFFAOIC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public HDIEBFIJNDE.MFKLNHDEGCC key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
					public HEMCNFFAOIC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x8750790", Offset = "0x874F990", VA = "0x188750790")]
					internal void MGGGECFFNEC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable AHAMBKHMIPO;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x87584D0", Offset = "0x87576D0", VA = "0x1887584D0")]
				public static PlayerLoopSystem MPDDJPKLHPI(HDIEBFIJNDE.MFKLNHDEGCC AGBHGDFILGO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct NIILBJIPAJF
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class OLJKAHGJCID
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public HDIEBFIJNDE.MFKLNHDEGCC key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
					public OLJKAHGJCID()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x875B280", Offset = "0x875A480", VA = "0x18875B280")]
					internal void MGGGECFFNEC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x8759520", Offset = "0x8758720", VA = "0x188759520")]
				public static PlayerLoopSystem MPDDJPKLHPI(HDIEBFIJNDE.MFKLNHDEGCC AGBHGDFILGO)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class PMMNKCFANGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public PMMNKCFANGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x875B670", Offset = "0x875A870", VA = "0x18875B670")]
			internal List<PlayerLoopSystem> FFNMBNBNACO(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool PKGJKIJBGBA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool COMEAGDGFAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8742030", Offset = "0x8741230", VA = "0x188742030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87423E0", Offset = "0x87415E0", VA = "0x1887423E0")]
		private static void NGHBGOKEOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8741340", Offset = "0x8740540", VA = "0x188741340")]
		private static void CKDIPAMLLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8741300", Offset = "0x8740500", VA = "0x188741300")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8742070", Offset = "0x8741270", VA = "0x188742070")]
		private static void IJOIFIHEKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87453F0", Offset = "0x87445F0", VA = "0x1887453F0")]
		private static void OBFNBOCMCHO(HDIEBFIJNDE.MFKLNHDEGCC AGBHGDFILGO, PlayerLoopSystem CLLEDHJDJJD, Type APKKHAPHDOE, Type HGMLNBMCBCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8741C50", Offset = "0x8740E50", VA = "0x188741C50")]
		private static void EOLJBOLCECG(PlayerLoopSystem CLLEDHJDJJD, Type APKKHAPHDOE, Type HGMLNBMCBCN, HLAPOFJHOKD BGHDEOBLLCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x87422B0", Offset = "0x87414B0", VA = "0x1887422B0")]
		private static void LAKHGKHKOLB(PlayerLoopSystem CLLEDHJDJJD, Type APKKHAPHDOE, Type HGMLNBMCBCN, PlayerLoopSystem? OLLMIJIPNMC, PlayerLoopSystem? DNDDLBBAOEB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HDIEBFIJNDE
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum MFKLNHDEGCC
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
	public class CMCELEMGDIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly MFKLNHDEGCC FBJEOMJJAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly PPBIGPHBEBB AKEMNOHAADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long BCMAMMHFDOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long HIEADBGMKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long CAMJCIIGIMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int EBDNAGHANOL;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8741270", Offset = "0x8740470", VA = "0x188741270")]
		public CMCELEMGDIK(MFKLNHDEGCC IEJLCLDENFK, int JFFHNJOHCDL = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8741170", Offset = "0x8740370", VA = "0x188741170")]
		public void KKENNFADFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8741120", Offset = "0x8740320", VA = "0x188741120")]
		public void IOLPAHLPOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8741190", Offset = "0x8740390", VA = "0x188741190")]
		public void MLEFIHOEJOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static MFKLNHDEGCC[] ANEEAEKNMAK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static CMCELEMGDIK[] IHJCDHKHPAF;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x87503A0", Offset = "0x874F5A0", VA = "0x1887503A0")]
	public static CMCELEMGDIK FNJOIMFPJGN(MFKLNHDEGCC AGBHGDFILGO, int JFFHNJOHCDL = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x87504F0", Offset = "0x874F6F0", VA = "0x1887504F0")]
	public static CMCELEMGDIK KBPFLBJMHGA(MFKLNHDEGCC AGBHGDFILGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8750560", Offset = "0x874F760", VA = "0x188750560")]
	public static void OAJFPHPCDEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class FHBPOOEEKGN
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface ONLPPMOFINC
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool FJIOALNONKI
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BKELOGOOEBI();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class NICBDFCNCFJ : ONLPPMOFINC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action HDKINMMJOHF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool FJIOALNONKI
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
		public NICBDFCNCFJ(Action HDKINMMJOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x11579E0", Offset = "0x1156BE0", VA = "0x1811579E0", Slot = "5")]
		public void BKELOGOOEBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<ONLPPMOFINC> FJHGJANFJOG;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x874DBE0", Offset = "0x874CDE0", VA = "0x18874DBE0")]
	public static void FJPJJMOEMII(Action HDKINMMJOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x874D8D0", Offset = "0x874CAD0", VA = "0x18874D8D0")]
	private static void DPEBOHJAEMB(ONLPPMOFINC FOHPBODLMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x874D5F0", Offset = "0x874C7F0", VA = "0x18874D5F0")]
	private static void DOFOPNBAHPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x874DAE0", Offset = "0x874CCE0", VA = "0x18874DAE0")]
	private static void FGOONFLENHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x874DC80", Offset = "0x874CE80", VA = "0x18874DC80")]
	private static void GCCMPNCNBJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class JGMHDHGDPDC
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct NGNLICAKIGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> KLNIDMEBNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string OIMMOCPAEDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode INPGFLAJEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool PDDFIAPODMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8759440", Offset = "0x8758640", VA = "0x188759440")]
		public NGNLICAKIGD(TaskCompletionSource<Scene> LFLCFNCNIIA, string OIMMOCPAEDE, LoadSceneMode INPGFLAJEDP, bool PDDFIAPODMK, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct GOELHPENOKN : IAsyncStateMachine
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
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private EAIPOBMEIGP<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x874ECE0", Offset = "0x874DEE0", VA = "0x18874ECE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x874F580", Offset = "0x874E780", VA = "0x18874F580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct MMFBDHENEFB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8758600", Offset = "0x8757800", VA = "0x188758600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8758910", Offset = "0x8757B10", VA = "0x188758910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct JIBPMACJDLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private NGNLICAKIGD <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8753550", Offset = "0x8752750", VA = "0x188753550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8753910", Offset = "0x8752B10", VA = "0x188753910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class BFCPLLOLBKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public DDFBDPEDLAI<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BFCPLLOLBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8740250", Offset = "0x873F450", VA = "0x188740250")]
		internal void KEPJLLGPOMB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct NMJNHJEDPEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

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
		private BFCPLLOLBKO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8759D40", Offset = "0x8758F40", VA = "0x188759D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x875A8E0", Offset = "0x8759AE0", VA = "0x18875A8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct KKAMMBPHECE : IAsyncStateMachine
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
		private AHAEBJLBPKA <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8754CC0", Offset = "0x8753EC0", VA = "0x188754CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8755380", Offset = "0x8754580", VA = "0x188755380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct HAFPKJJOIAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x874F5F0", Offset = "0x874E7F0", VA = "0x18874F5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8750110", Offset = "0x874F310", VA = "0x188750110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CFFFBGFDFNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public DDFBDPEDLAI<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CFFFBGFDFNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x87402E0", Offset = "0x873F4E0", VA = "0x1887402E0")]
		internal bool GELJEKDJBEG(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8740360", Offset = "0x873F560", VA = "0x188740360")]
		internal void HNIFEGIJCFG(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class MACDNJANJDJ : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public DDFBDPEDLAI<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private CFFFBGFDFNI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private AHAEBJLBPKA <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public MACDNJANJDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8758260", Offset = "0x8757460", VA = "0x188758260", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8757990", Offset = "0x8756B90", VA = "0x188757990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8757970", Offset = "0x8756B70", VA = "0x188757970")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8758210", Offset = "0x8757410", VA = "0x188758210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> EKFAPFPFCEC;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static IJPNCIBDOFL NEBMDDJGDJL;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation NHGPFBFAMJN;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static IJPNCIBDOFL NIEJNEECHDD;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string JDADBOJGOCD;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string JBIAAIACOJP;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority OJGIDAFMMGF;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task IHFJJKKFEFP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> NNHKGEGNIHE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<NGNLICAKIGD> IBIHEKKJNJM;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task ENPILDJGGCD;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> ANODGPLDJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8752160", Offset = "0x8751360", VA = "0x188752160")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8751ED0", Offset = "0x87510D0", VA = "0x188751ED0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8753060", Offset = "0x8752260", VA = "0x188753060")]
	[MPFAIPJMBCK(GGMCIMEHBME.EnteredEditModeNextFrame, 0)]
	private static void OMMCDAPBFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8752F10", Offset = "0x8752110", VA = "0x188752F10")]
	[AsyncStateMachine(typeof(GOELHPENOKN))]
	public static Task<Scene> ODFNMBBBIMI(string OIMMOCPAEDE, LoadSceneMode INPGFLAJEDP = LoadSceneMode.Single, bool PDDFIAPODMK = false, [Optional] EAIPOBMEIGP<string>.MNKIBAEKPMC GNCCMKJCKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x87525C0", Offset = "0x87517C0", VA = "0x1887525C0")]
	[AsyncStateMachine(typeof(MMFBDHENEFB))]
	private static Task DHBDBHAICJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8752B80", Offset = "0x8751D80", VA = "0x188752B80")]
	[AsyncStateMachine(typeof(JIBPMACJDLK))]
	private static Task GOBMEOCHANK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8752670", Offset = "0x8751870", VA = "0x188752670")]
	[AsyncStateMachine(typeof(NMJNHJEDPEE))]
	private static Task<Scene> DNNKJGAMNPK(string OIMMOCPAEDE, LoadSceneMode INPGFLAJEDP, bool PDDFIAPODMK, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8752460", Offset = "0x8751660", VA = "0x188752460")]
	private static void CNFGOHKAECO(SceneInstance BJFPHBLMMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x87527C0", Offset = "0x87519C0", VA = "0x1887527C0")]
	private static void DOMLBANNFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8752330", Offset = "0x8751530", VA = "0x188752330")]
	[AsyncStateMachine(typeof(KKAMMBPHECE))]
	private static Task<Scene> CAHAGMKMJOC(string OIMMOCPAEDE, LoadSceneMode INPGFLAJEDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8752E20", Offset = "0x8752020", VA = "0x188752E20")]
	private static bool OBCGPDCNJCG(string OIMMOCPAEDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8752A70", Offset = "0x8751C70", VA = "0x188752A70")]
	[AsyncStateMachine(typeof(HAFPKJJOIAD))]
	private static Task<Scene> FLNGEPCNAFC(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8751FE0", Offset = "0x87511E0", VA = "0x188751FE0")]
	public static CMEBMOPMCFP<Scene> APHBFMNDGCG(string OIMMOCPAEDE, LoadSceneMode INPGFLAJEDP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8752D80", Offset = "0x8751F80", VA = "0x188752D80")]
	[IteratorStateMachine(typeof(MACDNJANJDJ))]
	private static IEnumerator<EAALCCOKLJL> LNAJEDFFACK(string OIMMOCPAEDE, LoadSceneMode INPGFLAJEDP, DDFBDPEDLAI<Scene> BGNEDPCEOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8752560", Offset = "0x8751760", VA = "0x188752560")]
	public static void CPIKGGHOJAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8752270", Offset = "0x8751470", VA = "0x188752270")]
	private static void BIPNELGMLJE(string OIMMOCPAEDE, LoadSceneMode INPGFLAJEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8752C50", Offset = "0x8751E50", VA = "0x188752C50")]
	public static bool HGJPCEBDMFA([Out] string NICGCEPBEPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class KMDJOMDAHIO
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8755470", Offset = "0x8754670", VA = "0x188755470")]
	public static IDisposable IPEEFFBCADC(this DPLLONCBFPL OPJOIGJBJKN, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x87553F0", Offset = "0x87545F0", VA = "0x1887553F0")]
	public static IDisposable BAPIBMHIPDO(this DPLLONCBFPL OPJOIGJBJKN, Action<float> ICOLDJPNAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8755500", Offset = "0x8754700", VA = "0x188755500")]
	public static IDisposable PIFFGDPJMAD(this DPLLONCBFPL OPJOIGJBJKN, Action<float> ICOLDJPNAIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class EIJPNLLMAPD
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x369BF10", Offset = "0x369B110", VA = "0x18369BF10")]
	[JPCOMPBOBIH]
	public static IDisposable LIAFDKNMNGE<T>(this T JBGDICIDNHG, Action ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x369BD60", Offset = "0x369AF60", VA = "0x18369BD60")]
	[JPCOMPBOBIH]
	public static IDisposable LIAFDKNMNGE<T>(this T JBGDICIDNHG, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x369BC10", Offset = "0x369AE10", VA = "0x18369BC10")]
	[JPCOMPBOBIH]
	public static IDisposable IOJFMKAPHLJ<T>(this T JBGDICIDNHG, Action ICOLDJPNAIC, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x369BB60", Offset = "0x369AD60", VA = "0x18369BB60")]
	[JPCOMPBOBIH]
	public static IDisposable HGPKOGLOGOI<T>(this T JBGDICIDNHG, Action ICOLDJPNAIC, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x369BB60", Offset = "0x369AD60", VA = "0x18369BB60")]
	[JPCOMPBOBIH]
	public static IDisposable HGPKOGLOGOI<T>(this T JBGDICIDNHG, Action<float> ICOLDJPNAIC, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x369BCB0", Offset = "0x369AEB0", VA = "0x18369BCB0")]
	[JPCOMPBOBIH]
	public static IDisposable KGOFHCADHCM<T>(this T JBGDICIDNHG, Action ICOLDJPNAIC, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x369B7F0", Offset = "0x369A9F0", VA = "0x18369B7F0")]
	[JPCOMPBOBIH]
	public static IDisposable BABCLPIFKBB<T>(this T JBGDICIDNHG, Action ICOLDJPNAIC, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x369B900", Offset = "0x369AB00", VA = "0x18369B900")]
	[JPCOMPBOBIH]
	public static IDisposable CFJBBLLIKBP<T>(this T JBGDICIDNHG, Action ICOLDJPNAIC, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x369B9B0", Offset = "0x369ABB0", VA = "0x18369B9B0")]
	[JPCOMPBOBIH]
	public static IDisposable CKOFIMFPIEE<T>(this T JBGDICIDNHG, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x874C800", Offset = "0x874BA00", VA = "0x18874C800")]
	[JPCOMPBOBIH]
	public static IDisposable CKOFIMFPIEE(this MonoBehaviour JBGDICIDNHG, PFFMGCANADG OPJOIGJBJKN, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x369C110", Offset = "0x369B310", VA = "0x18369C110")]
	[JPCOMPBOBIH]
	public static IDisposable OLOCMLDCHNK<T>(this T JBGDICIDNHG, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x369C0C0", Offset = "0x369B2C0", VA = "0x18369C0C0")]
	[JPCOMPBOBIH]
	public static IDisposable OAFJOLGDNMI<T>(this T JBGDICIDNHG, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x369B9F0", Offset = "0x369ABF0", VA = "0x18369B9F0")]
	[JPCOMPBOBIH]
	public static IDisposable DDMCEHBMIPN<T>(this T JBGDICIDNHG, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x369B950", Offset = "0x369AB50", VA = "0x18369B950")]
	[JPCOMPBOBIH]
	public static IDisposable CJDLBHEKAJI<T>(this T JBGDICIDNHG, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x369B8A0", Offset = "0x369AAA0", VA = "0x18369B8A0")]
	[JPCOMPBOBIH]
	public static IDisposable CDKHKFPLJAG<T>(this T JBGDICIDNHG, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x369BB00", Offset = "0x369AD00", VA = "0x18369BB00")]
	[JPCOMPBOBIH]
	public static IDisposable GPBJLJLAMHP<T>(this T JBGDICIDNHG, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x369BAA0", Offset = "0x369ACA0", VA = "0x18369BAA0")]
	[JPCOMPBOBIH]
	public static IDisposable FBHNOJMGLHK<T>(this T JBGDICIDNHG, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x369BBB0", Offset = "0x369ADB0", VA = "0x18369BBB0")]
	[JPCOMPBOBIH]
	public static IDisposable IDNEINLDLLO<T>(this T JBGDICIDNHG, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x369BC50", Offset = "0x369AE50", VA = "0x18369BC50")]
	[JPCOMPBOBIH]
	public static IDisposable JEOLEBEDGPK<T>(this T JBGDICIDNHG, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x369BA50", Offset = "0x369AC50", VA = "0x18369BA50")]
	[JPCOMPBOBIH]
	public static IDisposable FAOJPCEMPEC<T>(this T JBGDICIDNHG, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x369BD00", Offset = "0x369AF00", VA = "0x18369BD00")]
	[JPCOMPBOBIH]
	public static IDisposable KNPCNEDJDIL<T>(this T JBGDICIDNHG, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x369B840", Offset = "0x369AA40", VA = "0x18369B840")]
	[JPCOMPBOBIH]
	public static IDisposable CAMCGCKCFJA<T>(this T JBGDICIDNHG, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true) where T : MonoBehaviour, PFFMGCANADG
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CLJOAHIAPGI
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class ABCBDHHJGCA : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public GOAPOICKGNJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private FDEJKFNDJNM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public ABCBDHHJGCA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x873FB50", Offset = "0x873ED50", VA = "0x18873FB50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x873FC30", Offset = "0x873EE30", VA = "0x18873FC30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class DIPHHAACPLG : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public GOAPOICKGNJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private FDEJKFNDJNM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public DIPHHAACPLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8745CF0", Offset = "0x8744EF0", VA = "0x188745CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8745DE0", Offset = "0x8744FE0", VA = "0x188745DE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x87410A0", Offset = "0x87402A0", VA = "0x1887410A0")]
	public static PEFNPNHCEAP LIAFDKNMNGE(Action ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8740F30", Offset = "0x8740130", VA = "0x188740F30")]
	public static PEFNPNHCEAP LIAFDKNMNGE(Behaviour OPJOIGJBJKN, Action ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8740FC0", Offset = "0x87401C0", VA = "0x188740FC0")]
	public static PEFNPNHCEAP LIAFDKNMNGE(Behaviour OPJOIGJBJKN, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8740E10", Offset = "0x8740010", VA = "0x188740E10")]
	[IteratorStateMachine(typeof(ABCBDHHJGCA))]
	private static IEnumerator<EAALCCOKLJL> CLPJDJAEBDC(GOAPOICKGNJ AJKLJDHODDP, Action ICOLDJPNAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8740EA0", Offset = "0x87400A0", VA = "0x188740EA0")]
	[IteratorStateMachine(typeof(DIPHHAACPLG))]
	private static IEnumerator<EAALCCOKLJL> CLPJDJAEBDC(GOAPOICKGNJ AJKLJDHODDP, Action<float> ICOLDJPNAIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class JHCKPECHJPH : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class DLCNELBEEHA : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public JHCKPECHJPH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public DLCNELBEEHA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8748190", Offset = "0x8747390", VA = "0x188748190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8748220", Offset = "0x8747420", VA = "0x188748220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly GOAPOICKGNJ ADAOGJIIIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action ALJGIOAPCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool AHJJIJKBNOB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool INKNHIHBLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8753480", Offset = "0x8752680", VA = "0x188753480")]
	public JHCKPECHJPH(GOAPOICKGNJ ADAOGJIIIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8753360", Offset = "0x8752560", VA = "0x188753360")]
	[IteratorStateMachine(typeof(DLCNELBEEHA))]
	private IEnumerator<EAALCCOKLJL> DCJKONJDIBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x87533E0", Offset = "0x87525E0", VA = "0x1887533E0", Slot = "4")]
	public void OnCompleted(Action KGOMEKGAMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	public void APOIGBHFMDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class ABMFAALLLIN
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x873FCC0", Offset = "0x873EEC0", VA = "0x18873FCC0")]
	public static JHCKPECHJPH LKNFDOKEILD(this GOAPOICKGNJ ADAOGJIIIMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class OBOFLAGDLCJ
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class IMBGFMOLGKD : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public HFKKDPLCKFN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public IMBGFMOLGKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x87510B0", Offset = "0x87502B0", VA = "0x1887510B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8751130", Offset = "0x8750330", VA = "0x188751130", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x875AD80", Offset = "0x8759F80", VA = "0x18875AD80")]
	public static PEFNPNHCEAP LIAFDKNMNGE(float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, bool LDPOGNBPHON = true, [Optional] IEHEEDGPPGD ELNMJLOPIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x875AE50", Offset = "0x875A050", VA = "0x18875AE50")]
	public static PEFNPNHCEAP LIAFDKNMNGE(MonoBehaviour JBGDICIDNHG, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, bool LDPOGNBPHON = true, [Optional] IEHEEDGPPGD ELNMJLOPIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x875AB60", Offset = "0x8759D60", VA = "0x18875AB60")]
	public static PEFNPNHCEAP GEELLPBGHAK(MonoBehaviour JBGDICIDNHG, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, bool LDPOGNBPHON = true, [Optional] IEHEEDGPPGD ELNMJLOPIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x875AC50", Offset = "0x8759E50", VA = "0x18875AC50")]
	public static PEFNPNHCEAP IFFDMOHAGHF(DPLLONCBFPL OPJOIGJBJKN, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, bool LDPOGNBPHON = true, [Optional] IEHEEDGPPGD ELNMJLOPIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x875AAA0", Offset = "0x8759CA0", VA = "0x18875AAA0")]
	private static IEnumerator<EAALCCOKLJL> CLPJDJAEBDC(KFCKLJEEFCD GKIGIEAMIDD, float ANDKDMDFAMO, GOAPOICKGNJ AJKLJDHODDP, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x875AD20", Offset = "0x8759F20", VA = "0x18875AD20")]
	private static IEnumerator<EAALCCOKLJL> KFBGEPJNPLN(KFCKLJEEFCD GKIGIEAMIDD, float ANDKDMDFAMO, GOAPOICKGNJ AJKLJDHODDP, Action<float> ICOLDJPNAIC, bool LDPOGNBPHON = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x875AF20", Offset = "0x875A120", VA = "0x18875AF20")]
	[IteratorStateMachine(typeof(IMBGFMOLGKD))]
	private static IEnumerator<EAALCCOKLJL> NALNDBMJCEA(HFKKDPLCKFN HKJOHPPOAEM, float ANDKDMDFAMO, GOAPOICKGNJ AJKLJDHODDP, Action<float> ICOLDJPNAIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class HNMLACFAMEB
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class NNKCKEHOOPJ : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public GOAPOICKGNJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public NNKCKEHOOPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x875A950", Offset = "0x8759B50", VA = "0x18875A950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x875AA10", Offset = "0x8759C10", VA = "0x18875AA10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8750BD0", Offset = "0x874FDD0", VA = "0x188750BD0")]
	[IteratorStateMachine(typeof(NNKCKEHOOPJ))]
	private static IEnumerator<EAALCCOKLJL> MAJLOCFDDJP(GOAPOICKGNJ ADAOGJIIIMH, Func<bool> CKBDGPAFKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8750AF0", Offset = "0x874FCF0", VA = "0x188750AF0")]
	public static PEFNPNHCEAP ADNEFCHONIL(this MonoBehaviour JBGDICIDNHG, Func<bool> CKBDGPAFKOM, GOAPOICKGNJ ADAOGJIIIMH = GOAPOICKGNJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class KDBCOEFAHOI
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class AMOAADLPKKA : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public GOAPOICKGNJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public AMOAADLPKKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8740190", Offset = "0x873F390", VA = "0x188740190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8740200", Offset = "0x873F400", VA = "0x188740200", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class NCNLLGJNMHL<T> : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public GOAPOICKGNJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public NCNLLGJNMHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x537BAC0", Offset = "0x537ACC0", VA = "0x18537BAC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x537BB60", Offset = "0x537AD60", VA = "0x18537BB60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class HJOEANMKBBO : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public GOAPOICKGNJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private EAALCCOKLJL <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public HJOEANMKBBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8750A10", Offset = "0x874FC10", VA = "0x188750A10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8750AA0", Offset = "0x874FCA0", VA = "0x188750AA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x87544C0", Offset = "0x87536C0", VA = "0x1887544C0")]
	[IteratorStateMachine(typeof(AMOAADLPKKA))]
	private static IEnumerator<EAALCCOKLJL> DCJKONJDIBG(float ODIBCCLKMAC, GOAPOICKGNJ AJKLJDHODDP, Action OOKJGLKPPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x38A9E80", Offset = "0x38A9080", VA = "0x1838A9E80")]
	[IteratorStateMachine(typeof(NCNLLGJNMHL<>))]
	private static IEnumerator<EAALCCOKLJL> DCJKONJDIBG<T>(float ODIBCCLKMAC, GOAPOICKGNJ AJKLJDHODDP, Action<T> OOKJGLKPPPN, T HLMDGBFCIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8754420", Offset = "0x8753620", VA = "0x188754420")]
	[IteratorStateMachine(typeof(HJOEANMKBBO))]
	private static IEnumerator<EAALCCOKLJL> COPCGOCDABO(float ODIBCCLKMAC, GOAPOICKGNJ AJKLJDHODDP, Action OOKJGLKPPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x8754AB0", Offset = "0x8753CB0", VA = "0x188754AB0")]
	public static IDisposable NJMELKLELPE(this MonoBehaviour JBGDICIDNHG, float ODIBCCLKMAC, Action OOKJGLKPPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8754390", Offset = "0x8753590", VA = "0x188754390")]
	public static PEFNPNHCEAP CGDIFPDLJNP(this MonoBehaviour JBGDICIDNHG, float ODIBCCLKMAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x87549C0", Offset = "0x8753BC0", VA = "0x1887549C0")]
	public static PEFNPNHCEAP NJMELKLELPE(this MonoBehaviour JBGDICIDNHG, float ODIBCCLKMAC, GOAPOICKGNJ AJKLJDHODDP, Action OOKJGLKPPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8754B90", Offset = "0x8753D90", VA = "0x188754B90")]
	public static PEFNPNHCEAP NKPILGKEHPP(this MonoBehaviour JBGDICIDNHG, Action OOKJGLKPPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x38AA0A0", Offset = "0x38A92A0", VA = "0x1838AA0A0")]
	public static PEFNPNHCEAP NKPILGKEHPP<T>(this MonoBehaviour JBGDICIDNHG, Action<T> OOKJGLKPPPN, T HLMDGBFCIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8754880", Offset = "0x8753A80", VA = "0x188754880")]
	public static PEFNPNHCEAP JDCNCBDAGGL(this MonoBehaviour JBGDICIDNHG, Action OOKJGLKPPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8754740", Offset = "0x8753940", VA = "0x188754740")]
	public static PEFNPNHCEAP IILOBJIAMFM(this MonoBehaviour JBGDICIDNHG, Action OOKJGLKPPPN, [Optional] IEHEEDGPPGD ELNMJLOPIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x87542F0", Offset = "0x87534F0", VA = "0x1887542F0")]
	public static PEFNPNHCEAP AAJGKIJNEBN(this MonoBehaviour JBGDICIDNHG, Action OOKJGLKPPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x87547E0", Offset = "0x87539E0", VA = "0x1887547E0")]
	public static PEFNPNHCEAP IOFAIIACIFH(this MonoBehaviour JBGDICIDNHG, Action OOKJGLKPPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8754600", Offset = "0x8753800", VA = "0x188754600")]
	public static PEFNPNHCEAP GEBBPAIGHMB(MonoBehaviour JBGDICIDNHG, GOAPOICKGNJ ADAOGJIIIMH, Action OOKJGLKPPPN, [Optional] IEHEEDGPPGD ELNMJLOPIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x38A9F60", Offset = "0x38A9160", VA = "0x1838A9F60")]
	public static PEFNPNHCEAP GEBBPAIGHMB<T>(MonoBehaviour JBGDICIDNHG, GOAPOICKGNJ ADAOGJIIIMH, Action<T> OOKJGLKPPPN, T HLMDGBFCIDH, [Optional] IEHEEDGPPGD ELNMJLOPIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8754C30", Offset = "0x8753E30", VA = "0x188754C30")]
	public static PEFNPNHCEAP PBEDECLNJBF(this MonoBehaviour JBGDICIDNHG, float MBIDDLMNMHG, Action OOKJGLKPPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8754560", Offset = "0x8753760", VA = "0x188754560")]
	public static PEFNPNHCEAP FJHDHNEELMH(this MonoBehaviour JBGDICIDNHG, float MBIDDLMNMHG, Action OOKJGLKPPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x87546A0", Offset = "0x87538A0", VA = "0x1887546A0")]
	public static PEFNPNHCEAP IIJNGKPCMGH(this MonoBehaviour JBGDICIDNHG, float MBIDDLMNMHG, Action OOKJGLKPPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8754920", Offset = "0x8753B20", VA = "0x188754920")]
	public static PEFNPNHCEAP KBLILEKHKGP(this MonoBehaviour JBGDICIDNHG, float MBIDDLMNMHG, Action OOKJGLKPPPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class LAKCFPADACP : BGILDPHCOKN, IEnumerable<BGILDPHCOKN>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<BGILDPHCOKN> DAFCNJHEEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool CEHAHOCCMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action NBPGBIJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool GOPJHCOPGFE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LPOJAGMBKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8755EB0", Offset = "0x87550B0", VA = "0x188755EB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GFAGNOIKBKE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8755AF0", Offset = "0x8754CF0", VA = "0x188755AF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8755B90", Offset = "0x8754D90", VA = "0x188755B90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8755FE0", Offset = "0x87551E0", VA = "0x188755FE0")]
	public LAKCFPADACP([Optional] Action NBPGBIJCNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8755D80", Offset = "0x8754F80", VA = "0x188755D80")]
	public void OOLDDNFEGEK(BGILDPHCOKN DHDAOMMLJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8755C30", Offset = "0x8754E30", VA = "0x188755C30")]
	private void ONICLENEDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8755A60", Offset = "0x8754C60", VA = "0x188755A60", Slot = "7")]
	public bool FLDHNABEOIF(bool LIEHHNOLAGC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8755760", Offset = "0x8754960", VA = "0x188755760", Slot = "8")]
	public bool FLDHNABEOIF(Action HDKINMMJOHF, bool LIEHHNOLAGC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8755A70", Offset = "0x8754C70", VA = "0x188755A70", Slot = "9")]
	public IEnumerator<BGILDPHCOKN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8755A70", Offset = "0x8754C70", VA = "0x188755A70", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GIGGMIDICCJ : NJLCNKOJLCG
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CEBEJNBNIDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public GIGGMIDICCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CEBEJNBNIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x87402B0", Offset = "0x873F4B0", VA = "0x1887402B0")]
		internal void BJPMKBJFPGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class INDFEKPMNGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public GIGGMIDICCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public INDFEKPMNGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x87402B0", Offset = "0x873F4B0", VA = "0x1887402B0")]
		internal void DIODEBHKBJN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float BPAKOPELAAB;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x874E100", Offset = "0x874D300", VA = "0x18874E100")]
	public GIGGMIDICCJ(Behaviour OPJOIGJBJKN, float BPAKOPELAAB, [Optional] Action NBPGBIJCNAP, [Optional] IEHEEDGPPGD ELNMJLOPIFN, [Optional] KFCKLJEEFCD GKIGIEAMIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x874DFF0", Offset = "0x874D1F0", VA = "0x18874DFF0", Slot = "9")]
	protected override bool ILMOPFHLCIB(Action HDKINMMJOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x874DEE0", Offset = "0x874D0E0", VA = "0x18874DEE0", Slot = "10")]
	protected override bool EGIDAODIFPI(Action HDKINMMJOHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface BGILDPHCOKN
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LPOJAGMBKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GFAGNOIKBKE;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FLDHNABEOIF(bool LIEHHNOLAGC = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FLDHNABEOIF(Action HDKINMMJOHF, bool LIEHHNOLAGC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class NJLCNKOJLCG : BGILDPHCOKN
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KCIDFHEJIDG : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public NJLCNKOJLCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public KCIDFHEJIDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x87541D0", Offset = "0x87533D0", VA = "0x1887541D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x87542A0", Offset = "0x87534A0", VA = "0x1887542A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour OPJOIGJBJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action NBPGBIJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private GCMBNCCDKOG PLLCIPFEFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly IEHEEDGPPGD ELNMJLOPIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly KFCKLJEEFCD GKIGIEAMIDD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LPOJAGMBKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1A653E0", Offset = "0x1A645E0", VA = "0x181A653E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GFAGNOIKBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8759A30", Offset = "0x8758C30", VA = "0x188759A30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8759AD0", Offset = "0x8758CD0", VA = "0x188759AD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8759C10", Offset = "0x8758E10", VA = "0x188759C10")]
	protected NJLCNKOJLCG(Behaviour OPJOIGJBJKN, [Optional] Action NBPGBIJCNAP, [Optional] IEHEEDGPPGD ELNMJLOPIFN, [Optional] KFCKLJEEFCD GKIGIEAMIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8759720", Offset = "0x8758920", VA = "0x188759720", Slot = "7")]
	public bool FLDHNABEOIF(bool LIEHHNOLAGC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8759780", Offset = "0x8758980", VA = "0x188759780", Slot = "8")]
	public bool FLDHNABEOIF(Action HDKINMMJOHF, bool LIEHHNOLAGC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool ILMOPFHLCIB(Action HDKINMMJOHF);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool EGIDAODIFPI(Action HDKINMMJOHF);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8759BF0", Offset = "0x8758DF0", VA = "0x188759BF0")]
	protected void OILPLKKMCCA(Action HDKINMMJOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x87597E0", Offset = "0x87589E0", VA = "0x1887597E0")]
	protected IJPNCIBDOFL HAJBHPJAJPC(float NJODBBGOGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8759B70", Offset = "0x8758D70", VA = "0x188759B70")]
	private void OEHIAKLIGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8759690", Offset = "0x8758890", VA = "0x188759690")]
	[IteratorStateMachine(typeof(KCIDFHEJIDG))]
	private IEnumerator<EAALCCOKLJL> CHOBNLILIIL(float NJODBBGOGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8759650", Offset = "0x8758850", VA = "0x188759650")]
	[CompilerGenerated]
	private void BIPNDFIMLBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class IDAEEOJCFJG : NJLCNKOJLCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float OOEPCJKCPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int DCCMBLCEDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float IGDPFLFDAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] GPJPFEHHICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int NNKGLHKALAJ;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8750EE0", Offset = "0x87500E0", VA = "0x188750EE0")]
	public IDAEEOJCFJG(Behaviour OPJOIGJBJKN, float HDFEBEGFFBO, int DCCMBLCEDDD, [Optional] Action NBPGBIJCNAP, float IGDPFLFDAEA = 0f, [Optional] IEHEEDGPPGD ELNMJLOPIFN, [Optional] KFCKLJEEFCD GKIGIEAMIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "9")]
	protected override bool ILMOPFHLCIB(Action HDKINMMJOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8750CE0", Offset = "0x874FEE0", VA = "0x188750CE0", Slot = "10")]
	protected override bool EGIDAODIFPI(Action HDKINMMJOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8750C60", Offset = "0x874FE60", VA = "0x188750C60")]
	private void CGOBLBCAMOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HCKOINNNCHN : NJLCNKOJLCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float BPAKOPELAAB;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x874E100", Offset = "0x874D300", VA = "0x18874E100")]
	public HCKOINNNCHN(Behaviour OPJOIGJBJKN, float BPAKOPELAAB, [Optional] Action NBPGBIJCNAP, [Optional] IEHEEDGPPGD ELNMJLOPIFN, [Optional] KFCKLJEEFCD GKIGIEAMIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "9")]
	protected override bool ILMOPFHLCIB(Action HDKINMMJOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8750180", Offset = "0x874F380", VA = "0x188750180", Slot = "10")]
	protected override bool EGIDAODIFPI(Action HDKINMMJOHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class JAKMDHEOFEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class PDDJOLCJLGJ : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public PDDJOLCJLGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8756080", Offset = "0x8755280", VA = "0x188756080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x875B620", Offset = "0x875A820", VA = "0x18875B620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private PEFNPNHCEAP AMJABFEAGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private DPLLONCBFPL OPJOIGJBJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> MOLOGLAAOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private GOAPOICKGNJ ADAOGJIIIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float GLCCNOJPACK;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8751680", Offset = "0x8750880", VA = "0x188751680")]
	public JAKMDHEOFEK(DPLLONCBFPL OPJOIGJBJKN, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x87511E0", Offset = "0x87503E0", VA = "0x1887511E0")]
	private void EIOECNFOBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x87513D0", Offset = "0x87505D0", VA = "0x1887513D0")]
	private void IHEGGKMOGCN(string KOIHEPAFBFG, Action GGAKEJKKJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8751350", Offset = "0x8750550", VA = "0x188751350")]
	[IteratorStateMachine(typeof(PDDJOLCJLGJ))]
	private IEnumerator<EAALCCOKLJL> EKMDHLJDDCK(Action GGAKEJKKJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8751180", Offset = "0x8750380", VA = "0x188751180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8751500", Offset = "0x8750700", VA = "0x188751500")]
	[CompilerGenerated]
	private void MFGLPIIACPH(string NHADLBPGDMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class LKMIKPALFLC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class LALAODOFJMD : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public LALAODOFJMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8756080", Offset = "0x8755280", VA = "0x188756080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x87560F0", Offset = "0x87552F0", VA = "0x1887560F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private PEFNPNHCEAP AMJABFEAGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour JBGDICIDNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action ICOLDJPNAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> MOLOGLAAOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private GOAPOICKGNJ ADAOGJIIIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float GLCCNOJPACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool LDPOGNBPHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly IEHEEDGPPGD ELNMJLOPIFN;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8757390", Offset = "0x8756590", VA = "0x188757390")]
	public LKMIKPALFLC(MonoBehaviour JBGDICIDNHG, Action ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, [Optional] IEHEEDGPPGD ELNMJLOPIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x87571C0", Offset = "0x87563C0", VA = "0x1887571C0")]
	public LKMIKPALFLC(MonoBehaviour JBGDICIDNHG, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, [Optional] IEHEEDGPPGD ELNMJLOPIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8757520", Offset = "0x8756720", VA = "0x188757520")]
	public LKMIKPALFLC(MonoBehaviour JBGDICIDNHG, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, bool LDPOGNBPHON = true, [Optional] IEHEEDGPPGD ELNMJLOPIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4BF2960", Offset = "0x4BF1B60", VA = "0x184BF2960")]
	private LKMIKPALFLC(IEHEEDGPPGD ELNMJLOPIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8756620", Offset = "0x8755820", VA = "0x188756620")]
	internal static LKMIKPALFLC BJNDIJNMFDE(MonoBehaviour JBGDICIDNHG, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, GOAPOICKGNJ ADAOGJIIIMH, bool LDPOGNBPHON = true, [Optional] IEHEEDGPPGD ELNMJLOPIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8756E80", Offset = "0x8756080", VA = "0x188756E80")]
	private void LIAFDKNMNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8756FB0", Offset = "0x87561B0", VA = "0x188756FB0")]
	private void NMBODDJEKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8756940", Offset = "0x8755B40", VA = "0x188756940")]
	private void EIOECNFOBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8756B30", Offset = "0x8755D30", VA = "0x188756B30")]
	private void HLGHGCCIBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8756CC0", Offset = "0x8755EC0", VA = "0x188756CC0")]
	private void IHEGGKMOGCN(string KOIHEPAFBFG, Action GGAKEJKKJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8756AB0", Offset = "0x8755CB0", VA = "0x188756AB0")]
	[IteratorStateMachine(typeof(LALAODOFJMD))]
	private IEnumerator<EAALCCOKLJL> EKMDHLJDDCK(Action GGAKEJKKJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x87568E0", Offset = "0x8755AE0", VA = "0x1887568E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8756850", Offset = "0x8755A50", VA = "0x188756850")]
	[CompilerGenerated]
	private void CHJAJJHKIFM(string NHADLBPGDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8756590", Offset = "0x8755790", VA = "0x188756590")]
	[CompilerGenerated]
	private void AGGPKOMDDOD(string NHADLBPGDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8757130", Offset = "0x8756330", VA = "0x188757130")]
	[CompilerGenerated]
	private void PEHEFHNOGGC(string NHADLBPGDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8756DF0", Offset = "0x8755FF0", VA = "0x188756DF0")]
	[CompilerGenerated]
	private void IJPBOOEJJPL(string NHADLBPGDMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum CADJCJGBKHJ : byte
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
internal sealed class LCOFMKHEHGN : KFCKLJEEFCD
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float CFGOBPOFFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x87561E0", Offset = "0x87553E0", VA = "0x1887561E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float FCMFFNGLAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8756160", Offset = "0x8755360", VA = "0x188756160", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double GFANFGKGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8756140", Offset = "0x8755340", VA = "0x188756140", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8756170", Offset = "0x8755370", VA = "0x188756170")]
	[DBIDCJGLKKO.BICJMLCNMCI]
	internal static void OIIIADNPFIO(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	[UnityEngine.Scripting.Preserve]
	internal LCOFMKHEHGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface FFCGMCKGIMM
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFKAOEGBLNB(string DGIAFBEDPNJ);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MCKJLCIADNL();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface PJPGBCEKHJA
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool BFDEOBNNJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool IFIPKLAKGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class CIAAHIPGGKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public DNGGEANLKDK PPNFMBGDOAG;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int PMLOAHGMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8740900", Offset = "0x873FB00", VA = "0x188740900")]
	public static EAALCCOKLJL NKAJGLKGMKL(IEnumerator<EAALCCOKLJL> FNBPEDCKIHM, NICJGAAKMEC HFCKNONPKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8740840", Offset = "0x873FA40", VA = "0x188740840")]
	public EAALCCOKLJL NKAJGLKGMKL(NICJGAAKMEC[] CNKNFOKMAKP, IEnumerator<EAALCCOKLJL>[] BDMEGOLDEOO, EAALCCOKLJL[] JKCEBKCDNOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8740A60", Offset = "0x873FC60", VA = "0x188740A60")]
	public void PGKGGNMHNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x87405C0", Offset = "0x873F7C0", VA = "0x1887405C0")]
	public void FDOELCNKIKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8740700", Offset = "0x873F900", VA = "0x188740700")]
	public void HPGHMFAEPCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8740A60", Offset = "0x873FC60", VA = "0x188740A60")]
	public void PCMJMPFBLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CIAAHIPGGKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class DNGGEANLKDK
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct KFJABLOIEPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public CIAAHIPGGKL EOILICKDDAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public DPLLONCBFPL CCKIMEINDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public NICJGAAKMEC DJGNJPJOMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<EAALCCOKLJL> NGEECNKGAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public EAALCCOKLJL DAKAEOCKOIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CADJCJGBKHJ CEDEKKHBBPH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct EJEOAICLPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public GOAPOICKGNJ EIKLLJBFECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<KFJABLOIEPA> LILANGAFKHA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GKIAEHPFPJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public NICJGAAKMEC promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public DNGGEANLKDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public DPLLONCBFPL context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public CIAAHIPGGKL routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public CADJCJGBKHJ coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public EAALCCOKLJL currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<EAALCCOKLJL> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public GKIAEHPFPJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x874E510", Offset = "0x874D710", VA = "0x18874E510")]
		internal void BMAPCIMPMPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class NPNMKFJAMMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CIAAHIPGGKL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public DNGGEANLKDK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NPNMKFJAMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x875AA60", Offset = "0x8759C60", VA = "0x18875AA60")]
		internal void ANCPKBEDPEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class ABIGINNDFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public CIAAHIPGGKL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public DNGGEANLKDK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ABIGINNDFHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x873FC80", Offset = "0x873EE80", VA = "0x18873FC80")]
		internal void BFKLBCELACH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class NFJNLOONMEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public CIAAHIPGGKL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public DNGGEANLKDK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NFJNLOONMEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8759400", Offset = "0x8758600", VA = "0x188759400")]
		internal void NCGNGALDDIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const CADJCJGBKHJ BCGGBMCAAPB = CADJCJGBKHJ.Cancelled | CADJCJGBKHJ.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly GOAPOICKGNJ ADAOGJIIIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] HINMCFEJMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<CADJCJGBKHJ> FMNAPKEPGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> FNENMMMLODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> CJPCPMPAOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> JPFDPFCEEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> ABDPNLAPHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> PPBHGMCGMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> DLFAIIFLIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private CIAAHIPGGKL[] CMKIOMPHLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NICJGAAKMEC[] CNKNFOKMAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private DPLLONCBFPL[] EHFBEHMHCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<EAALCCOKLJL>[] HFJOPCDMKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private EAALCCOKLJL[] IABBLBDIGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int HOLFHAPOEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int PIBKMAHMMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int AAJLDOONBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float KJGLCNCNHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private DDDCBJFNIKC LFANCNJMCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle PLIOFKAOCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<CIAAHIPGGKL> BALJHGGPPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool MLLNPJBLHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> BHGPDNMEJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> NNKPBFCKJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool JKJPAJBBBIM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public EJEOAICLPBD[] BHHAOGOCJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xAB6880", Offset = "0xAB5A80", VA = "0x180AB6880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x874A3D0", Offset = "0x87495D0", VA = "0x18874A3D0")]
	private static int DAFLKPMMLEA(GOAPOICKGNJ ADAOGJIIIMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x874C1B0", Offset = "0x874B3B0", VA = "0x18874C1B0")]
	public DNGGEANLKDK(GOAPOICKGNJ ADAOGJIIIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x874A680", Offset = "0x8749880", VA = "0x18874A680")]
	private void EHIGCOIGALB(int FBPGACPBGOL, int BKPPPMFAFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x874BF00", Offset = "0x874B100", VA = "0x18874BF00")]
	public void OKIMLIOPLHM(DPLLONCBFPL OPJOIGJBJKN, EAALCCOKLJL EPFIKKFKEOH, IEnumerator<EAALCCOKLJL> FNBPEDCKIHM, NICJGAAKMEC HFCKNONPKCI, [Optional] CIAAHIPGGKL KIKPBEAHGLP, CADJCJGBKHJ GCFBNLFPEFC = CADJCJGBKHJ.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8749E20", Offset = "0x8749020", VA = "0x188749E20")]
	public void AINFJIJKHJI(IEnumerable<KFJABLOIEPA> LADLLOBGDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x874AD00", Offset = "0x8749F00", VA = "0x18874AD00")]
	private KFJABLOIEPA GPFDKIAJABP(int HCBEGDBDAAK)
	{
		return default(KFJABLOIEPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x874A060", Offset = "0x8749260", VA = "0x18874A060")]
	private void BHEKIDANJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3673970", Offset = "0x3672B70", VA = "0x183673970")]
	private static void CKFNBGPNNIJ<T>(int HCBEGDBDAAK, T[] GIKJKGNOIFK, int JAFKPMJIGFL, [Optional] T NBDNMFINOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x36739C0", Offset = "0x3672BC0", VA = "0x1836739C0")]
	private static void CKFNBGPNNIJ<T>(int HCBEGDBDAAK, NativeArray<T> GIKJKGNOIFK, int JAFKPMJIGFL, [Optional] T NBDNMFINOIA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x874A860", Offset = "0x8749A60", VA = "0x18874A860")]
	private void FANEBFPEAEF(IEnumerable<KFJABLOIEPA> LADLLOBGDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x874A400", Offset = "0x8749600", VA = "0x18874A400")]
	private void DEJKKEBOCEG(KFJABLOIEPA APGIJDIIJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x874BCA0", Offset = "0x874AEA0", VA = "0x18874BCA0")]
	private DMMKKIGDEJE MHEHFIJBPIK(int ICIKOPKHHNC)
	{
		return default(DMMKKIGDEJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x874B8F0", Offset = "0x874AAF0", VA = "0x18874B8F0")]
	public void KJHGABBGNOM(float BEBOODADNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x874A600", Offset = "0x8749800", VA = "0x18874A600")]
	private void DHOHBAACIME(Action FCKEKMKDGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x874BC20", Offset = "0x874AE20", VA = "0x18874BC20")]
	private void MEDGOHIFHGD(Action FCKEKMKDGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x874B1D0", Offset = "0x874A3D0", VA = "0x18874B1D0")]
	public void KFAFCBBAILD(float BEBOODADNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x874AC00", Offset = "0x8749E00", VA = "0x18874AC00")]
	public void GNJBDGKPLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x874C080", Offset = "0x874B280", VA = "0x18874C080")]
	public void PCMJMPFBLNN(CIAAHIPGGKL HKJOHPPOAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x874BAF0", Offset = "0x874ACF0", VA = "0x18874BAF0")]
	public void MDMKHHJOEAI(CIAAHIPGGKL HKJOHPPOAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x874A4D0", Offset = "0x87496D0", VA = "0x18874A4D0")]
	public void DFBKPGDDAME(CIAAHIPGGKL HKJOHPPOAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GGPIFNLJDGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly GGPIFNLJDGM MLINAHCDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action NEBLENLODFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool DJOMNIEOFJP;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public GGPIFNLJDGM(Action NEBLENLODFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2E50", Offset = "0x7DE2050", VA = "0x187DE2E50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface GIDLIEIELJL<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PEHNKGMDCBJ(UnityEngine.Object OPJOIGJBJKN, Action<T> HDHJAGHLMKJ);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface LLPAHHPKKNF<T> : GIDLIEIELJL<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class CAOCIHCKKLP<T> : LLPAHHPKKNF<T>, GIDLIEIELJL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class FJLPGMGIOJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public CAOCIHCKKLP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public IONGDEHMNIL<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public FJLPGMGIOJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x49AC990", Offset = "0x49ABB90", VA = "0x1849AC990")]
		internal void KPPBGOBJHIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject IMMMHGDEHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<IONGDEHMNIL<UnityEngine.Object, Action<T>>> MCGLPEBHNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T BPMPIMPDGDP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xAACFF0", Offset = "0xAAC1F0", VA = "0x180AACFF0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6444D20", Offset = "0x6443F20", VA = "0x186444D20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6444DF0", Offset = "0x6443FF0", VA = "0x186444DF0")]
	private static bool PEALPCDAGCN(T FCKEKMKDGOB, T PMDPDEMGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6445210", Offset = "0x6444410", VA = "0x186445210")]
	public CAOCIHCKKLP(T NPOCKJDEFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6444EB0", Offset = "0x64440B0", VA = "0x186444EB0", Slot = "6")]
	public IDisposable PEHNKGMDCBJ(UnityEngine.Object OPJOIGJBJKN, Action<T> HDHJAGHLMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6444610", Offset = "0x6443810", VA = "0x186444610")]
	private void ICPHBHNFFPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class EPGHEMGJDBM : HODIDAPFOLL
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class KCEBMCLCEDH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class MAJPABPAANN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int MKHHKDJKLDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private KCEBMCLCEDH AJKLJDHODDP;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xEC7B70", Offset = "0xEC6D70", VA = "0x180EC7B70")]
			public MAJPABPAANN(int MKHHKDJKLDN, KCEBMCLCEDH AJKLJDHODDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x87582C0", Offset = "0x87574C0", VA = "0x1887582C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class LHAFLEEDMGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public LHAFLEEDMGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool IPKBJFNFMPP(JEOBFHLKALO e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class CIJHGCCKLAC : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private EAALCCOKLJL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public KCEBMCLCEDH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public KFCKLJEEFCD timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private FDEJKFNDJNM <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<JEOBFHLKALO> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
			[DebuggerHidden]
			public CIJHGCCKLAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8740A90", Offset = "0x873FC90", VA = "0x188740A90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8740DC0", Offset = "0x873FFC0", VA = "0x188740DC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly GOAPOICKGNJ ADAOGJIIIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private PEFNPNHCEAP HFCKNONPKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<JEOBFHLKALO> PHDEJHGJNAJ;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8754130", Offset = "0x8753330", VA = "0x188754130")]
		public KCEBMCLCEDH(GOAPOICKGNJ ADAOGJIIIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8753D30", Offset = "0x8752F30", VA = "0x188753D30")]
		public IDisposable ADBEKCOJALE(JEOBFHLKALO FIKCHKFIKLF, IEHEEDGPPGD ELNMJLOPIFN, KFCKLJEEFCD AGHDGMNHDIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8753FA0", Offset = "0x87531A0", VA = "0x188753FA0")]
		private void LGJNAIDKMNM(int MKHHKDJKLDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8753EC0", Offset = "0x87530C0", VA = "0x188753EC0")]
		[IteratorStateMachine(typeof(CIJHGCCKLAC))]
		private IEnumerator<EAALCCOKLJL> CLPJDJAEBDC(KFCKLJEEFCD AGHDGMNHDIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8753F50", Offset = "0x8753150", VA = "0x188753F50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class JEOBFHLKALO
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum BGLOAADMMBI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int NFGALCFGPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int CCDGCEMKGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly PFFMGCANADG CCKIMEINDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour IEOPEGDPKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action IOJFMKAPHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> KLDEDFFFEBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float IHLHJBOFKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float FNENMMMLODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string BGMICIBNDMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool KDDLOOCMIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly BGLOAADMMBI MBIJJOCNCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool HHHAIMHKNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool PBDFABBMKHO;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8751D50", Offset = "0x8750F50", VA = "0x188751D50")]
		public JEOBFHLKALO(PFFMGCANADG OPJOIGJBJKN, Action ICOLDJPNAIC, bool MNGMIIFMNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x87519F0", Offset = "0x8750BF0", VA = "0x1887519F0")]
		public JEOBFHLKALO(PFFMGCANADG OPJOIGJBJKN, Action<float> ICOLDJPNAIC, bool MNGMIIFMNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8751B70", Offset = "0x8750D70", VA = "0x188751B70")]
		public JEOBFHLKALO(PFFMGCANADG OPJOIGJBJKN, float ANDKDMDFAMO, Action<float> ICOLDJPNAIC, KFCKLJEEFCD AGHDGMNHDIP, BGLOAADMMBI AEPCFNBPNDN, bool LDPOGNBPHON, bool MNGMIIFMNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8751820", Offset = "0x8750A20", VA = "0x188751820")]
		public bool LJJDPOEJAEF(float ALBGFINLCPH, float BCCEKGNMJIB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly IEHEEDGPPGD ELNMJLOPIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly KFCKLJEEFCD GKIGIEAMIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<GOAPOICKGNJ, KCEBMCLCEDH> GMFBGAAEHHC;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x874CD60", Offset = "0x874BF60", VA = "0x18874CD60")]
	[DBIDCJGLKKO.BICJMLCNMCI]
	internal static void GMFGKIDBKBG(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x874D530", Offset = "0x874C730", VA = "0x18874D530")]
	[UnityEngine.Scripting.Preserve]
	internal EPGHEMGJDBM([ALHAHLCGLLK(null)] IEHEEDGPPGD ELNMJLOPIFN, [ALHAHLCGLLK(null)] KFCKLJEEFCD GKIGIEAMIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x874CDD0", Offset = "0x874BFD0", VA = "0x18874CDD0", Slot = "4")]
	public IDisposable IOJFMKAPHLJ(PFFMGCANADG OPJOIGJBJKN, Action LKEPFHDAAED, GOAPOICKGNJ ADAOGJIIIMH, bool MNGMIIFMNLK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x874CFC0", Offset = "0x874C1C0", VA = "0x18874CFC0", Slot = "5")]
	public IDisposable IOJFMKAPHLJ(PFFMGCANADG OPJOIGJBJKN, Action<float> LKEPFHDAAED, GOAPOICKGNJ ADAOGJIIIMH, bool MNGMIIFMNLK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x874D330", Offset = "0x874C530", VA = "0x18874D330", Slot = "7")]
	public IDisposable OAFJOLGDNMI(PFFMGCANADG OPJOIGJBJKN, float ANDKDMDFAMO, Action<float> LKEPFHDAAED, GOAPOICKGNJ ADAOGJIIIMH, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x874D430", Offset = "0x874C630", VA = "0x18874D430", Slot = "8")]
	public IDisposable OKDECGKIKHE(PFFMGCANADG OPJOIGJBJKN, float ANDKDMDFAMO, Action<float> LKEPFHDAAED, GOAPOICKGNJ ADAOGJIIIMH, bool LDPOGNBPHON = true, bool MNGMIIFMNLK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x874D1B0", Offset = "0x874C3B0", VA = "0x18874D1B0", Slot = "6")]
	public IDisposable OAFJOLGDNMI(float ANDKDMDFAMO, Action<float> LKEPFHDAAED, bool LDPOGNBPHON = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x874CA60", Offset = "0x874BC60", VA = "0x18874CA60", Slot = "9")]
	public void AJIPEHIHHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x874CC20", Offset = "0x874BE20", VA = "0x18874CC20")]
	private KCEBMCLCEDH BIIDMPOFLCN(GOAPOICKGNJ ADAOGJIIIMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class DJJGEDLEEFI : DKOGEOBEODK, IEHEEDGPPGD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private DNGGEANLKDK[] GKGMAPBPFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private FFCGMCKGIMM CNJKBCCIAJJ;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8746C10", Offset = "0x8745E10", VA = "0x188746C10")]
	[DBIDCJGLKKO.BICJMLCNMCI]
	internal static void OIIIADNPFIO(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x8746C80", Offset = "0x8745E80", VA = "0x188746C80")]
	[UnityEngine.Scripting.Preserve]
	public DJJGEDLEEFI([ALHAHLCGLLK(null)] CEBCNPBDNIA PDIEMLPJOGP, [ALHAHLCGLLK(null)] KFCKLJEEFCD GKIGIEAMIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x87462A0", Offset = "0x87454A0", VA = "0x1887462A0", Slot = "19")]
	public override PEFNPNHCEAP BNEDNGDDOMD(DPLLONCBFPL OPJOIGJBJKN, IEnumerator<EAALCCOKLJL> BFBCLOKABMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8746010", Offset = "0x8745210", VA = "0x188746010", Slot = "20")]
	public override void AJIPEHIHHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x87469E0", Offset = "0x8745BE0", VA = "0x1887469E0", Slot = "22")]
	public override void KLBJNCCLIHN(GOAPOICKGNJ ADAOGJIIIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x87467B0", Offset = "0x87459B0", VA = "0x1887467B0", Slot = "21")]
	protected override void IOJFMKAPHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x8746550", Offset = "0x8745750", VA = "0x188746550")]
	private DNGGEANLKDK EBMAIEDOIAC(GOAPOICKGNJ EDLOHJEBKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x8746580", Offset = "0x8745780", VA = "0x188746580", Slot = "23")]
	internal override MPAIIPHAPHG ILJFNPOEOBK(IEnumerator<EAALCCOKLJL> BFBCLOKABMP, Behaviour OPJOIGJBJKN, NICJGAAKMEC HFCKNONPKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8746920", Offset = "0x8745B20", VA = "0x188746920", Slot = "24")]
	internal override DMKKIJIDLJL IPDMAIOIDJN(GOAPOICKGNJ AJKLJDHODDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x87463D0", Offset = "0x87455D0", VA = "0x1887463D0")]
	private void DIFFBHIHCIA(DNGGEANLKDK BEDPOHPKCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x87464F0", Offset = "0x87456F0", VA = "0x1887464F0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct DDDCBJFNIKC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float JKJHDJNJBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int KLDHOLILLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> KDNNGOEBDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> BPLPGGECBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> BIBBCHDBOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<CADJCJGBKHJ> MAMLMBHIPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> APNDFFOEIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> ABDPNLAPHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> CJPCPMPAOEG;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8745A10", Offset = "0x8744C10", VA = "0x188745A10")]
	public static DDDCBJFNIKC EAIFKKLDBGP(int GDIDMOOCJKL, float BEBOODADNFJ, NativeArray<CADJCJGBKHJ> JNBMLKBJAJJ, NativeArray<float> GBIGHOBFAME, NativeArray<int> KGLADJBJLAN, NativeArray<int> MJMAMEONPGM, NativeArray<int> FEBKIIOAILC, NativeArray<int> BPLPGGECBMI, NativeArray<int> BIBBCHDBOIP)
	{
		return default(DDDCBJFNIKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8745A70", Offset = "0x8744C70", VA = "0x188745A70", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8745790", Offset = "0x8744990", VA = "0x188745790")]
	private bool APGBNKCHBMG(int NIBICIJAIGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8745CC0", Offset = "0x8744EC0", VA = "0x188745CC0")]
	private void LBGDCBHDFKH(NativeArray<int> ICGIIPJBBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8745C20", Offset = "0x8744E20", VA = "0x188745C20")]
	private int IHKLIGGBMEK(int AJBLDLELNPJ, int FDMGPGMJMND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8745B50", Offset = "0x8744D50", VA = "0x188745B50")]
	private void GHCAOEIOGMI(NativeArray<int> ICGIIPJBBDM, int HALOHFIFMED, int DENDMCHJGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x87457D0", Offset = "0x87449D0", VA = "0x1887457D0")]
	private void BGICHKMGDEE(NativeArray<int> ICGIIPJBBDM, int HDADKHFMFJA, int HIGLHLEGBEL, int OMDGDEFCCCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class DKOGEOBEODK : IEHEEDGPPGD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly CEBCNPBDNIA PDIEMLPJOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly KFCKLJEEFCD GKIGIEAMIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private DMKKIJIDLJL[] HJFDMANPPHJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static IEHEEDGPPGD NDDGJHHDBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x87473D0", Offset = "0x87465D0", VA = "0x1887473D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool DBBHGEKFDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public GOAPOICKGNJ EPIJICHNHCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GOAPOICKGNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public KFCKLJEEFCD BPEFOBMCGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public EAALCCOKLJL APCDLBMAANO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public EAALCCOKLJL LINEAKJCILO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public EAALCCOKLJL DJCHKPMJLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EAALCCOKLJL FNMKPAKOHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x87479C0", Offset = "0x8746BC0", VA = "0x1887479C0")]
	public static PEFNPNHCEAP KMGCPBDBHCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8747CA0", Offset = "0x8746EA0", VA = "0x188747CA0")]
	[UnityEngine.Scripting.Preserve]
	protected DKOGEOBEODK([ALHAHLCGLLK(null)] CEBCNPBDNIA PDIEMLPJOGP, [ALHAHLCGLLK(null)] KFCKLJEEFCD GKIGIEAMIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8747A50", Offset = "0x8746C50", VA = "0x188747A50", Slot = "6")]
	public PEFNPNHCEAP MENHHIHEOIL(IEnumerator<EAALCCOKLJL> BFBCLOKABMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8747A60", Offset = "0x8746C60", VA = "0x188747A60", Slot = "7")]
	public PEFNPNHCEAP MENHHIHEOIL(Behaviour OPJOIGJBJKN, IEnumerator<EAALCCOKLJL> BFBCLOKABMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract PEFNPNHCEAP BNEDNGDDOMD(DPLLONCBFPL OPJOIGJBJKN, IEnumerator<EAALCCOKLJL> BFBCLOKABMP);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8746DD0", Offset = "0x8745FD0", VA = "0x188746DD0", Slot = "20")]
	public virtual void AJIPEHIHHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x8747440", Offset = "0x8746640", VA = "0x188747440", Slot = "9")]
	public void GDDILDGEKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x87478F0", Offset = "0x8746AF0", VA = "0x1887478F0", Slot = "21")]
	protected virtual void IOJFMKAPHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8747C80", Offset = "0x8746E80", VA = "0x188747C80")]
	private void OMKPEGMGEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8746F70", Offset = "0x8746170", VA = "0x188746F70")]
	private void AKADOLOBBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x87476A0", Offset = "0x87468A0", VA = "0x1887476A0")]
	private void HGPKOGLOGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8747910", Offset = "0x8746B10", VA = "0x188747910")]
	private void KGOFHCADHCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8747680", Offset = "0x8746880", VA = "0x188747680")]
	private void GLLFFDHJIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x87473B0", Offset = "0x87465B0", VA = "0x1887473B0")]
	private void EBOPIKMHMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8747C60", Offset = "0x8746E60", VA = "0x188747C60")]
	private void MPPLPHKCKNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8747930", Offset = "0x8746B30", VA = "0x188747930", Slot = "22")]
	public virtual void KLBJNCCLIHN(GOAPOICKGNJ ADAOGJIIIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x87476C0", Offset = "0x87468C0", VA = "0x1887476C0")]
	private void HHAPIMFBONI(DMKKIJIDLJL BEDPOHPKCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x269CE80", Offset = "0x269C080", VA = "0x18269CE80")]
	private DMKKIJIDLJL GFJIEGIFDBD(GOAPOICKGNJ EDLOHJEBKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract MPAIIPHAPHG ILJFNPOEOBK(IEnumerator<EAALCCOKLJL> BFBCLOKABMP, Behaviour JBGDICIDNHG, NICJGAAKMEC FDODHKOMEAO);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract DMKKIJIDLJL IPDMAIOIDJN(GOAPOICKGNJ ADAOGJIIIMH);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8746FF0", Offset = "0x87461F0", VA = "0x188746FF0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8747890", Offset = "0x8746A90", VA = "0x188747890", Slot = "15")]
	public EAALCCOKLJL INHKDNHNGMI(GOAPOICKGNJ AJKLJDHODDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8746D40", Offset = "0x8745F40", VA = "0x188746D40", Slot = "16")]
	public EAALCCOKLJL ABJPJMJHNOF(float ODIBCCLKMAC, GOAPOICKGNJ AJKLJDHODDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8746F90", Offset = "0x8746190", VA = "0x188746F90", Slot = "17")]
	public EAALCCOKLJL APOLGCOHBLI(Func<bool> CKBDGPAFKOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class MPAIIPHAPHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly NICJGAAKMEC HFCKNONPKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly PJPGBCEKHJA OPJOIGJBJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool HONAAIGOGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string DGIAFBEDPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace CEBBMIDMMEM;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<EAALCCOKLJL> NGEECNKGAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public EAALCCOKLJL DAKAEOCKOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool DBIDOJIHDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8758970", Offset = "0x8757B70", VA = "0x188758970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool LMEBBOBEMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xC1FDB0", Offset = "0xC1EFB0", VA = "0x180C1FDB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xC54940", Offset = "0xC53B40", VA = "0x180C54940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8758DD0", Offset = "0x8757FD0", VA = "0x188758DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float ACCIMEKDDJL
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x107F620", Offset = "0x107E820", VA = "0x18107F620")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7065D80", Offset = "0x7064F80", VA = "0x187065D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x8759060", Offset = "0x8758260", VA = "0x188759060")]
	public MPAIIPHAPHG(IEnumerator<EAALCCOKLJL> FNBPEDCKIHM, PJPGBCEKHJA OPJOIGJBJKN, NICJGAAKMEC HFCKNONPKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x87589F0", Offset = "0x8757BF0", VA = "0x1887589F0")]
	public EAALCCOKLJL NKAJGLKGMKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8758D10", Offset = "0x8757F10", VA = "0x188758D10")]
	public bool OAICHMMBHLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8758D80", Offset = "0x8757F80", VA = "0x188758D80")]
	public void PCMJMPFBLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x8758F80", Offset = "0x8758180", VA = "0x188758F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xC9C150", Offset = "0xC9B350", VA = "0x180C9C150")]
	[CompilerGenerated]
	private void CMKMCJCGAJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class NICJGAAKMEC : GMCBKNKNOJM, PEFNPNHCEAP, GCMBNCCDKOG, IJPNCIBDOFL, IEnumerator, EAALCCOKLJL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private GOAPOICKGNJ HIKAHPLGPEE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private GOAPOICKGNJ GCIPJDPADJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD753E0", Offset = "0xD745E0", VA = "0x180D753E0", Slot = "23")]
		get
		{
			return default(GOAPOICKGNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GOAPOICKGNJ PPNFMBGDOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xF52F40", Offset = "0xF52140", VA = "0x180F52F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float FJGKKEAIBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xBE8630", Offset = "0xBE7830", VA = "0x180BE8630", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool DDBKJFPAGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x87594B0", Offset = "0x87586B0", VA = "0x1887594B0", Slot = "24")]
	private bool GMGHAOKEGAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x87594A0", Offset = "0x87586A0", VA = "0x1887594A0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x87594D0", Offset = "0x87586D0", VA = "0x1887594D0")]
	public NICJGAAKMEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum DMMKKIGDEJE : byte
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
internal sealed class DMKKIJIDLJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum KKNLBJHGAKK
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct MLMDOCICLMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public GOAPOICKGNJ EIKLLJBFECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public KKNLBJHGAKK ALJPLCHNPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<MPAIIPHAPHG> NBBFKNDHMPL;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly KKNLBJHGAKK[] MFMKMOEFIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly GOAPOICKGNJ ADAOGJIIIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool EFKDDBIIHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly MPAIIPHAPHG[] NFBILNAKBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<MPAIIPHAPHG> IIJMAOJONNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> IDMOCLPPAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<MPAIIPHAPHG> PIMIPODKPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> LBPHPEHDPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly FFCGMCKGIMM OBDCEJLKLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool JKJPAJBBBIM;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MLMDOCICLMN[,] FCJEHEMPJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x87499A0", Offset = "0x8748BA0", VA = "0x1887499A0")]
	public DMKKIJIDLJL(GOAPOICKGNJ AJKLJDHODDP, FFCGMCKGIMM OBDCEJLKLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8749020", Offset = "0x8748220", VA = "0x188749020")]
	public void ILCPOCPIJIN(MPAIIPHAPHG FNBPEDCKIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x87486F0", Offset = "0x87478F0", VA = "0x1887486F0")]
	public void FNHOGENFEIB(IList<MPAIIPHAPHG> BDMEGOLDEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x87489F0", Offset = "0x8747BF0", VA = "0x1887489F0")]
	public void FOABHEJCEDH(IList<MPAIIPHAPHG> BDMEGOLDEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8749780", Offset = "0x8748980", VA = "0x188749780")]
	private void OJCJPDKEDOE(MPAIIPHAPHG FNBPEDCKIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x87495F0", Offset = "0x87487F0", VA = "0x1887495F0")]
	private void OAMHNFBLIFM(IList<MPAIIPHAPHG> BDMEGOLDEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8748450", Offset = "0x8747650", VA = "0x188748450")]
	private DMMKKIGDEJE BJOELOEHMPH(MPAIIPHAPHG FNBPEDCKIHM)
	{
		return default(DMMKKIGDEJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8749120", Offset = "0x8748320", VA = "0x188749120")]
	public void IOJFMKAPHLJ(float BEBOODADNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8748CF0", Offset = "0x8747EF0", VA = "0x188748CF0")]
	public void GDDILDGEKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8749290", Offset = "0x8748490", VA = "0x188749290")]
	private void JNCMOKKMLAM(List<MPAIIPHAPHG> BDMEGOLDEOO, Stack<int> INCHGGMPLMK, bool BPMAACGHOHG, float BEGHGMHMOON = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x87485D0", Offset = "0x87477D0", VA = "0x1887485D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8748EE0", Offset = "0x87480E0", VA = "0x188748EE0")]
	private void HNCHMNJMIMB(List<MPAIIPHAPHG> BDMEGOLDEOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class JDIKCPLFCIP : FFCGMCKGIMM
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void PFKAOEGBLNB(string DGIAFBEDPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
	public void MCKJLCIADNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public JDIKCPLFCIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class PCJNBIFNLNE : PJPGBCEKHJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour JBGDICIDNHG;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x875B5A0", Offset = "0x875A7A0", VA = "0x18875B5A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool BFDEOBNNJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x875B530", Offset = "0x875A730", VA = "0x18875B530", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool IFIPKLAKGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x875B580", Offset = "0x875A780", VA = "0x18875B580", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public PCJNBIFNLNE(Behaviour JBGDICIDNHG)
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

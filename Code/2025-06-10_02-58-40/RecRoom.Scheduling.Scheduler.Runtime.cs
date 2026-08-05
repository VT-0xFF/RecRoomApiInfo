using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8767180", Offset = "0x8766380", VA = "0x188767180", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
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
		private delegate List<PlayerLoopSystem> KGBIFKAJGHP(List<PlayerLoopSystem> IACHGIFMABN, int CIEGMMCHHLL);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct ONCLGMGEMNM
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct JHABPBPAEPI
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static EPHHEFDKGKL OFCFCOPNILI;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x875B420", Offset = "0x875A620", VA = "0x18875B420")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct HAIGMCLOBHK
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static EPHHEFDKGKL EAJGMKMBGDI;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8758F00", Offset = "0x8758100", VA = "0x188758F00")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct HGBDHHMCALI
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static EPHHEFDKGKL JEMBBKANOGA;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x87590E0", Offset = "0x87582E0", VA = "0x1887590E0")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct LEOLICNIKDH
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static EPHHEFDKGKL CFNJFCMNEEF;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static EPHHEFDKGKL FNMIGAJCFFJ;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static EPHHEFDKGKL FNKBCPGBOFF;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static EPHHEFDKGKL FLLJOHBCADA;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x875CAD0", Offset = "0x875BCD0", VA = "0x18875CAD0")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct HIPOGKDHPFB
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static EPHHEFDKGKL DIBEINFEGEB;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x8759C90", Offset = "0x8758E90", VA = "0x188759C90")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct FCCGMDIMAMP
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static EPHHEFDKGKL CFNJFCMNEEF;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static EPHHEFDKGKL FNMIGAJCFFJ;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static EPHHEFDKGKL FNKBCPGBOFF;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static EPHHEFDKGKL FLLJOHBCADA;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x87577B0", Offset = "0x87569B0", VA = "0x1887577B0")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct DNHEMHCKFFB
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static EPHHEFDKGKL BPKDKHGPJDO;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x8756D60", Offset = "0x8755F60", VA = "0x188756D60")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct OMEEDGGDGFO
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static EPHHEFDKGKL AFJDMHNKKKD;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x8765160", Offset = "0x8764360", VA = "0x188765160")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct IHOCGMAEIDJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static EPHHEFDKGKL CNBNBMNAMKH;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x875AEC0", Offset = "0x875A0C0", VA = "0x18875AEC0")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct OAFJKGLCKGM
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static EPHHEFDKGKL FKCPLLJKHOO;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x8764CE0", Offset = "0x8763EE0", VA = "0x188764CE0")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct AFHHIEPBLOG
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static EPHHEFDKGKL MKPKGMLEIBL;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x874F820", Offset = "0x874EA20", VA = "0x18874F820")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct ICAGBLOGDNE
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static EPHHEFDKGKL BKPOHFNIFHI;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x875ABD0", Offset = "0x8759DD0", VA = "0x18875ABD0")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct EHHOPLDBGOP
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static EPHHEFDKGKL OEGOANOFJDG;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x87575D0", Offset = "0x87567D0", VA = "0x1887575D0")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct CHFKJMAOKIN
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static EPHHEFDKGKL AMABNNFENCK;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x87515D0", Offset = "0x87507D0", VA = "0x1887515D0")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public struct ODDLAKHDGEA
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static EPHHEFDKGKL HDGCJKCHKPL;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x8764EC0", Offset = "0x87640C0", VA = "0x188764EC0")]
				public static PlayerLoopSystem JHCAKIHIOMI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public enum EKPANFJAPLN : byte
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
			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public struct BCIECIIDLMA
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class IJODONLPFMI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public EKPANFJAPLN updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
					public IJODONLPFMI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0x875B0A0", Offset = "0x875A2A0", VA = "0x18875B0A0")]
					internal void OFGHLMADPIP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static KFOHPPMEALH<EKPANFJAPLN> EKMKKOOKPLJ;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x874FA30", Offset = "0x874EC30", VA = "0x18874FA30")]
				public static PlayerLoopSystem JHCAKIHIOMI(EKPANFJAPLN AGMKPALPMPN)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000027")]
			internal struct KJOHNLCGDJN
			{
				[Cpp2IlInjected.Token(Token = "0x2000028")]
				[CompilerGenerated]
				private sealed class NDJKDGOLEOA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public NLAHKIALCEA.FABPMADJMJI key;

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
					public NDJKDGOLEOA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005E")]
					[Cpp2IlInjected.Address(RVA = "0x8762DE0", Offset = "0x8761FE0", VA = "0x188762DE0")]
					internal void KGNFNNDIPHD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable HBMNOMLEOHI;

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x875BDC0", Offset = "0x875AFC0", VA = "0x18875BDC0")]
				public static PlayerLoopSystem JAJGFEFBLCE(NLAHKIALCEA.FABPMADJMJI MHDODBCCAJB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002A")]
			internal struct EEBHGONGFJB
			{
				[Cpp2IlInjected.Token(Token = "0x200002B")]
				[CompilerGenerated]
				private sealed class JJLJGMKPHOP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public NLAHKIALCEA.FABPMADJMJI key;

					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
					public JJLJGMKPHOP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x875B7E0", Offset = "0x875A9E0", VA = "0x18875B7E0")]
					internal void KGNFNNDIPHD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x87574A0", Offset = "0x87566A0", VA = "0x1887574A0")]
				public static PlayerLoopSystem JAJGFEFBLCE(NLAHKIALCEA.FABPMADJMJI MHDODBCCAJB)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class IOELGLCFDHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public IOELGLCFDHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x875B300", Offset = "0x875A500", VA = "0x18875B300")]
			internal List<PlayerLoopSystem> KEKGNHDBJBE(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool OAEDDPAILNO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool KDADLABINKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8755390", Offset = "0x8754590", VA = "0x188755390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8752380", Offset = "0x8751580", VA = "0x188752380")]
		private static void DJKFPMMCAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8755BB0", Offset = "0x8754DB0", VA = "0x188755BB0")]
		private static void PJMGJKEAMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8752210", Offset = "0x8751410", VA = "0x188752210")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87557B0", Offset = "0x87549B0", VA = "0x1887557B0")]
		private static void OANBKIIECAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87559F0", Offset = "0x8754BF0", VA = "0x1887559F0")]
		private static void OANNLIBAIDM(NLAHKIALCEA.FABPMADJMJI MHDODBCCAJB, PlayerLoopSystem OLBMOBMPLBN, Type HOODEEMPIBF, Type EJAPPOIIGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87553D0", Offset = "0x87545D0", VA = "0x1887553D0")]
		private static void JNONGKMJBLO(PlayerLoopSystem OLBMOBMPLBN, Type HOODEEMPIBF, Type EJAPPOIIGEH, KGBIFKAJGHP DLNEJGNJMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8752250", Offset = "0x8751450", VA = "0x188752250")]
		private static void CHFFJIDDMKM(PlayerLoopSystem OLBMOBMPLBN, Type HOODEEMPIBF, Type EJAPPOIIGEH, PlayerLoopSystem? CEHGEOEPCCO, PlayerLoopSystem? JGLIGPGDBBE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class NLAHKIALCEA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum FABPMADJMJI
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

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JHFJLPABEPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly FABPMADJMJI FFEBFDJPEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly IIPBECKPKJP DPMGODCMDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long HDNKIPJEFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long AMAHDBIGMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long EMOELMAAGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int OGFPPNJCOJP;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x875B750", Offset = "0x875A950", VA = "0x18875B750")]
		public JHFJLPABEPN(FABPMADJMJI NMNKMPHNNLJ, int IKDAJGLNNEJ = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x875B600", Offset = "0x875A800", VA = "0x18875B600")]
		public void GOAJJHIAPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x875B620", Offset = "0x875A820", VA = "0x18875B620")]
		public void LOAJLBCBPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x875B670", Offset = "0x875A870", VA = "0x18875B670")]
		public void OKIPPNFKOHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static FABPMADJMJI[] KGHHFJHMMNF;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static JHFJLPABEPN[] MFDOHICOGDH;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8764440", Offset = "0x8763640", VA = "0x188764440")]
	public static JHFJLPABEPN HPHMCBBJGFM(FABPMADJMJI MHDODBCCAJB, int IKDAJGLNNEJ = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x87643D0", Offset = "0x87635D0", VA = "0x1887643D0")]
	public static JHFJLPABEPN BNEOLCAJHNC(FABPMADJMJI MHDODBCCAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8764590", Offset = "0x8763790", VA = "0x188764590")]
	public static void JOPLMENLBDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class CNKLHIKGKFI
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface HODBABPMEOI
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool LAMNHKKOCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NMBGHNGELPM();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class KJNHMCJHBNA : HODBABPMEOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action CJLPDLONOLK;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool LAMNHKKOCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
		public KJNHMCJHBNA(Action CJLPDLONOLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1175330", Offset = "0x1174530", VA = "0x181175330", Slot = "5")]
		public void NMBGHNGELPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<HODBABPMEOI> LJPMLGNFMOA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8751B80", Offset = "0x8750D80", VA = "0x188751B80")]
	public static void MLCFPFHDLJD(Action CJLPDLONOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8751F00", Offset = "0x8751100", VA = "0x188751F00")]
	private static void OBBADDDEDFK(HODBABPMEOI JKLMJNEJCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8751C20", Offset = "0x8750E20", VA = "0x188751C20")]
	private static void NBDCKMDNBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8751A80", Offset = "0x8750C80", VA = "0x188751A80")]
	private static void MCJPHMOAOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x87519B0", Offset = "0x8750BB0", VA = "0x1887519B0")]
	private static void IIFPANIIBLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class KOFGDMLPPHO
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x875C3F0", Offset = "0x875B5F0", VA = "0x18875C3F0")]
	public static IDisposable MCIMANLDJJE(this HILNFMOEKON BKDMJHGCDEA, float PHNFPAODELK, Action<float> EDGPFNFJGKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x875C2F0", Offset = "0x875B4F0", VA = "0x18875C2F0")]
	public static IDisposable HNKEGDPCANL(this HILNFMOEKON BKDMJHGCDEA, Action<float> EDGPFNFJGKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x875C370", Offset = "0x875B570", VA = "0x18875C370")]
	public static IDisposable JOJPFNKINOK(this HILNFMOEKON BKDMJHGCDEA, Action<float> EDGPFNFJGKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class INHJBNODIPE
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3A50990", Offset = "0x3A4FB90", VA = "0x183A50990")]
	[JKPCMBPLPDC]
	public static IDisposable POOFNLAFNNI<T>(this T BFDDOFMGEOI, Action EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3A50B40", Offset = "0x3A4FD40", VA = "0x183A50B40")]
	[JKPCMBPLPDC]
	public static IDisposable POOFNLAFNNI<T>(this T BFDDOFMGEOI, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3A507F0", Offset = "0x3A4F9F0", VA = "0x183A507F0")]
	[JKPCMBPLPDC]
	public static IDisposable KJFMNLEBHBJ<T>(this T BFDDOFMGEOI, Action EDGPFNFJGKD, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3A505E0", Offset = "0x3A4F7E0", VA = "0x183A505E0")]
	[JKPCMBPLPDC]
	public static IDisposable CCIAPFEJBJH<T>(this T BFDDOFMGEOI, Action EDGPFNFJGKD, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3A505E0", Offset = "0x3A4F7E0", VA = "0x183A505E0")]
	[JKPCMBPLPDC]
	public static IDisposable CCIAPFEJBJH<T>(this T BFDDOFMGEOI, Action<float> EDGPFNFJGKD, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3A506D0", Offset = "0x3A4F8D0", VA = "0x183A506D0")]
	[JKPCMBPLPDC]
	public static IDisposable DEBKBBLLDAF<T>(this T BFDDOFMGEOI, Action EDGPFNFJGKD, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3A507C0", Offset = "0x3A4F9C0", VA = "0x183A507C0")]
	[JKPCMBPLPDC]
	public static IDisposable KALFEINFCNN<T>(this T BFDDOFMGEOI, Action EDGPFNFJGKD, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3A50860", Offset = "0x3A4FA60", VA = "0x183A50860")]
	[JKPCMBPLPDC]
	public static IDisposable LNNNPDLANNG<T>(this T BFDDOFMGEOI, Action EDGPFNFJGKD, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3A50700", Offset = "0x3A4F900", VA = "0x183A50700")]
	[JKPCMBPLPDC]
	public static IDisposable HBPEMCPHPCL<T>(this T BFDDOFMGEOI, float PHNFPAODELK, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x875B120", Offset = "0x875A320", VA = "0x18875B120")]
	[JKPCMBPLPDC]
	public static IDisposable HBPEMCPHPCL(this MonoBehaviour BFDDOFMGEOI, DJNFGEJICJL BKDMJHGCDEA, float PHNFPAODELK, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3A503F0", Offset = "0x3A4F5F0", VA = "0x183A503F0")]
	[JKPCMBPLPDC]
	public static IDisposable AKBIEKGLIJD<T>(this T BFDDOFMGEOI, float PHNFPAODELK, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3A50950", Offset = "0x3A4FB50", VA = "0x183A50950")]
	[JKPCMBPLPDC]
	public static IDisposable PIFJNJNMBCA<T>(this T BFDDOFMGEOI, float PHNFPAODELK, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3A50650", Offset = "0x3A4F850", VA = "0x183A50650")]
	[JKPCMBPLPDC]
	public static IDisposable CLGLMFGLNOD<T>(this T BFDDOFMGEOI, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3A50910", Offset = "0x3A4FB10", VA = "0x183A50910")]
	[JKPCMBPLPDC]
	public static IDisposable PHGBPNPIMBG<T>(this T BFDDOFMGEOI, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3A50890", Offset = "0x3A4FA90", VA = "0x183A50890")]
	[JKPCMBPLPDC]
	public static IDisposable MJNNBJPNMLK<T>(this T BFDDOFMGEOI, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3A508D0", Offset = "0x3A4FAD0", VA = "0x183A508D0")]
	[JKPCMBPLPDC]
	public static IDisposable ODEICPDFFCL<T>(this T BFDDOFMGEOI, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3A50780", Offset = "0x3A4F980", VA = "0x183A50780")]
	[JKPCMBPLPDC]
	public static IDisposable JLIMADFPJND<T>(this T BFDDOFMGEOI, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3A50820", Offset = "0x3A4FA20", VA = "0x183A50820")]
	[JKPCMBPLPDC]
	public static IDisposable LJDBEAMGBOK<T>(this T BFDDOFMGEOI, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3A505A0", Offset = "0x3A4F7A0", VA = "0x183A505A0")]
	[JKPCMBPLPDC]
	public static IDisposable BOAOFEBOMJN<T>(this T BFDDOFMGEOI, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A50740", Offset = "0x3A4F940", VA = "0x183A50740")]
	[JKPCMBPLPDC]
	public static IDisposable JDCKFKBKJLJ<T>(this T BFDDOFMGEOI, float PHNFPAODELK, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3A50610", Offset = "0x3A4F810", VA = "0x183A50610")]
	[JKPCMBPLPDC]
	public static IDisposable CIFPKDPCMCI<T>(this T BFDDOFMGEOI, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3A50690", Offset = "0x3A4F890", VA = "0x183A50690")]
	[JKPCMBPLPDC]
	public static IDisposable CNPBOAHAJAO<T>(this T BFDDOFMGEOI, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true) where T : MonoBehaviour, DJNFGEJICJL
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IBPPPBJNLCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JLFMGGHLDGA : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public BLKNIDPJAGC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private COOOKCIHCJP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public JLFMGGHLDGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x875BA90", Offset = "0x875AC90", VA = "0x18875BA90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x875BB70", Offset = "0x875AD70", VA = "0x18875BB70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class LDAIJFILMCO : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public BLKNIDPJAGC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private COOOKCIHCJP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public LDAIJFILMCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x875C480", Offset = "0x875B680", VA = "0x18875C480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x875C570", Offset = "0x875B770", VA = "0x18875C570", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x875AB50", Offset = "0x8759D50", VA = "0x18875AB50")]
	public static AFABIGEDGFJ POOFNLAFNNI(Action EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x875A9E0", Offset = "0x8759BE0", VA = "0x18875A9E0")]
	public static AFABIGEDGFJ POOFNLAFNNI(Behaviour BKDMJHGCDEA, Action EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x875AA70", Offset = "0x8759C70", VA = "0x18875AA70")]
	public static AFABIGEDGFJ POOFNLAFNNI(Behaviour BKDMJHGCDEA, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x875A8C0", Offset = "0x8759AC0", VA = "0x18875A8C0")]
	[IteratorStateMachine(typeof(JLFMGGHLDGA))]
	private static IEnumerator<NOFGPJFCPHG> FNHMOJEDALD(BLKNIDPJAGC IIOIMKJECAH, Action EDGPFNFJGKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x875A950", Offset = "0x8759B50", VA = "0x18875A950")]
	[IteratorStateMachine(typeof(LDAIJFILMCO))]
	private static IEnumerator<NOFGPJFCPHG> FNHMOJEDALD(BLKNIDPJAGC IIOIMKJECAH, Action<float> EDGPFNFJGKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class GOEMADADIKL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class CJKMIIMIPIH : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public GOEMADADIKL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public CJKMIIMIPIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x87517F0", Offset = "0x87509F0", VA = "0x1887517F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8751880", Offset = "0x8750A80", VA = "0x188751880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly BLKNIDPJAGC NBJKFEKGNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Action MGOLIPLCADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool HNCNEOFACFM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NIFOKHJINBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3F0", Offset = "0xA0C5F0", VA = "0x180A0D3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8758E30", Offset = "0x8758030", VA = "0x188758E30")]
	public GOEMADADIKL(BLKNIDPJAGC NBJKFEKGNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8758D10", Offset = "0x8757F10", VA = "0x188758D10")]
	[IteratorStateMachine(typeof(CJKMIIMIPIH))]
	private IEnumerator<NOFGPJFCPHG> NGOAFPPFCKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8758D90", Offset = "0x8757F90", VA = "0x188758D90", Slot = "4")]
	public void OnCompleted(Action FHPFPMFGCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	public void DFBDMEHIPDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KCJDGMMDKDI
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x875BBC0", Offset = "0x875ADC0", VA = "0x18875BBC0")]
	public static GOEMADADIKL IFHDNGBNMHF(this BLKNIDPJAGC NBJKFEKGNPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LDPMGBKEODB
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class BENMAMLFBAM : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public NDHPPPBMDEB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public BENMAMLFBAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x874FBF0", Offset = "0x874EDF0", VA = "0x18874FBF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x874FC70", Offset = "0x874EE70", VA = "0x18874FC70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x875C930", Offset = "0x875BB30", VA = "0x18875C930")]
	public static AFABIGEDGFJ POOFNLAFNNI(float PHNFPAODELK, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, bool LICGDFICFAM = true, [Optional] POGLNMFMHLK NIBFMCDFOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x875CA00", Offset = "0x875BC00", VA = "0x18875CA00")]
	public static AFABIGEDGFJ POOFNLAFNNI(MonoBehaviour BFDDOFMGEOI, float PHNFPAODELK, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, bool LICGDFICFAM = true, [Optional] POGLNMFMHLK NIBFMCDFOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x875C620", Offset = "0x875B820", VA = "0x18875C620")]
	public static AFABIGEDGFJ CEPANPGFFLK(MonoBehaviour BFDDOFMGEOI, float PHNFPAODELK, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, bool LICGDFICFAM = true, [Optional] POGLNMFMHLK NIBFMCDFOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x875C860", Offset = "0x875BA60", VA = "0x18875C860")]
	public static AFABIGEDGFJ JIJLFLLNBLP(HILNFMOEKON BKDMJHGCDEA, float PHNFPAODELK, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, bool LICGDFICFAM = true, [Optional] POGLNMFMHLK NIBFMCDFOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x875C710", Offset = "0x875B910", VA = "0x18875C710")]
	private static IEnumerator<NOFGPJFCPHG> FNHMOJEDALD(MEEEEDNDAED HEPIMJLIPCA, float PHNFPAODELK, BLKNIDPJAGC IIOIMKJECAH, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x875C5C0", Offset = "0x875B7C0", VA = "0x18875C5C0")]
	private static IEnumerator<NOFGPJFCPHG> ALMPLJCHBLL(MEEEEDNDAED HEPIMJLIPCA, float PHNFPAODELK, BLKNIDPJAGC IIOIMKJECAH, Action<float> EDGPFNFJGKD, bool LICGDFICFAM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x875C7D0", Offset = "0x875B9D0", VA = "0x18875C7D0")]
	[IteratorStateMachine(typeof(BENMAMLFBAM))]
	private static IEnumerator<NOFGPJFCPHG> GCFGFBHINHM(NDHPPPBMDEB CHGAJALIHNA, float PHNFPAODELK, BLKNIDPJAGC IIOIMKJECAH, Action<float> EDGPFNFJGKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class CGMANDGLPMB
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class IGDDPOHGFFH : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public BLKNIDPJAGC queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public IGDDPOHGFFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x875ADB0", Offset = "0x8759FB0", VA = "0x18875ADB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x875AE70", Offset = "0x875A070", VA = "0x18875AE70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8751540", Offset = "0x8750740", VA = "0x188751540")]
	[IteratorStateMachine(typeof(IGDDPOHGFFH))]
	private static IEnumerator<NOFGPJFCPHG> MFKHKBAPKOM(BLKNIDPJAGC NBJKFEKGNPB, Func<bool> BELLBJOFLIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8751460", Offset = "0x8750660", VA = "0x188751460")]
	public static AFABIGEDGFJ JCABEBIGMMP(this MonoBehaviour BFDDOFMGEOI, Func<bool> BELLBJOFLIE, BLKNIDPJAGC NBJKFEKGNPB = BLKNIDPJAGC.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HGHLFCOOBCA
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class OKBMCLJJBNA : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public BLKNIDPJAGC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public OKBMCLJJBNA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x87650A0", Offset = "0x87642A0", VA = "0x1887650A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8765110", Offset = "0x8764310", VA = "0x188765110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class OGEGHMAFBBK<T> : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public BLKNIDPJAGC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public OGEGHMAFBBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5612EE0", Offset = "0x56120E0", VA = "0x185612EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5612F60", Offset = "0x5612160", VA = "0x185612F60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class CLNPICAIJKG : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public BLKNIDPJAGC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private NOFGPJFCPHG <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public CLNPICAIJKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x87518D0", Offset = "0x8750AD0", VA = "0x1887518D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8751960", Offset = "0x8750B60", VA = "0x188751960", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8759AB0", Offset = "0x8758CB0", VA = "0x188759AB0")]
	[IteratorStateMachine(typeof(OKBMCLJJBNA))]
	private static IEnumerator<NOFGPJFCPHG> NGOAFPPFCKN(float GKFLGCPHKEK, BLKNIDPJAGC IIOIMKJECAH, Action PJBCEMJEHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A1CDA0", Offset = "0x3A1BFA0", VA = "0x183A1CDA0")]
	[IteratorStateMachine(typeof(OGEGHMAFBBK<>))]
	private static IEnumerator<NOFGPJFCPHG> NGOAFPPFCKN<T>(float GKFLGCPHKEK, BLKNIDPJAGC IIOIMKJECAH, Action<T> PJBCEMJEHFE, T BNCBJIMFGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8759400", Offset = "0x8758600", VA = "0x188759400")]
	[IteratorStateMachine(typeof(CLNPICAIJKG))]
	private static IEnumerator<NOFGPJFCPHG> FBJJNEPAOMI(float GKFLGCPHKEK, BLKNIDPJAGC IIOIMKJECAH, Action PJBCEMJEHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x87595D0", Offset = "0x87587D0", VA = "0x1887595D0")]
	public static IDisposable GPELLOGNPBM(this MonoBehaviour BFDDOFMGEOI, float GKFLGCPHKEK, Action PJBCEMJEHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8759A20", Offset = "0x8758C20", VA = "0x188759A20")]
	public static AFABIGEDGFJ MCPKLINCPCG(this MonoBehaviour BFDDOFMGEOI, float GKFLGCPHKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x87596B0", Offset = "0x87588B0", VA = "0x1887596B0")]
	public static AFABIGEDGFJ GPELLOGNPBM(this MonoBehaviour BFDDOFMGEOI, float GKFLGCPHKEK, BLKNIDPJAGC IIOIMKJECAH, Action PJBCEMJEHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8759840", Offset = "0x8758A40", VA = "0x188759840")]
	public static AFABIGEDGFJ KGGIENCPFIG(this MonoBehaviour BFDDOFMGEOI, Action PJBCEMJEHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A1CC40", Offset = "0x3A1BE40", VA = "0x183A1CC40")]
	public static AFABIGEDGFJ KGGIENCPFIG<T>(this MonoBehaviour BFDDOFMGEOI, Action<T> PJBCEMJEHFE, T BNCBJIMFGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x87592C0", Offset = "0x87584C0", VA = "0x1887592C0")]
	public static AFABIGEDGFJ BGFFKMKCILH(this MonoBehaviour BFDDOFMGEOI, Action PJBCEMJEHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8759B50", Offset = "0x8758D50", VA = "0x188759B50")]
	public static AFABIGEDGFJ NNBGPDEAOPJ(this MonoBehaviour BFDDOFMGEOI, Action PJBCEMJEHFE, [Optional] POGLNMFMHLK NIBFMCDFOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x87594A0", Offset = "0x87586A0", VA = "0x1887594A0")]
	public static AFABIGEDGFJ FIFBLACHHLM(this MonoBehaviour BFDDOFMGEOI, Action PJBCEMJEHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8759360", Offset = "0x8758560", VA = "0x188759360")]
	public static AFABIGEDGFJ BHMBOCPDKMM(this MonoBehaviour BFDDOFMGEOI, Action PJBCEMJEHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8759980", Offset = "0x8758B80", VA = "0x188759980")]
	public static AFABIGEDGFJ LMHCMAPEECC(MonoBehaviour BFDDOFMGEOI, BLKNIDPJAGC NBJKFEKGNPB, Action PJBCEMJEHFE, [Optional] POGLNMFMHLK NIBFMCDFOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3A1CC70", Offset = "0x3A1BE70", VA = "0x183A1CC70")]
	public static AFABIGEDGFJ LMHCMAPEECC<T>(MonoBehaviour BFDDOFMGEOI, BLKNIDPJAGC NBJKFEKGNPB, Action<T> PJBCEMJEHFE, T BNCBJIMFGHJ, [Optional] POGLNMFMHLK NIBFMCDFOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8759540", Offset = "0x8758740", VA = "0x188759540")]
	public static AFABIGEDGFJ GHIGGMPCNNI(this MonoBehaviour BFDDOFMGEOI, float HNIJOFMLOIP, Action PJBCEMJEHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x87597A0", Offset = "0x87589A0", VA = "0x1887597A0")]
	public static AFABIGEDGFJ IGFICCJDAEA(this MonoBehaviour BFDDOFMGEOI, float HNIJOFMLOIP, Action PJBCEMJEHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x87598E0", Offset = "0x8758AE0", VA = "0x1887598E0")]
	public static AFABIGEDGFJ KMNENJBFBHJ(this MonoBehaviour BFDDOFMGEOI, float HNIJOFMLOIP, Action PJBCEMJEHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8759BF0", Offset = "0x8758DF0", VA = "0x188759BF0")]
	public static AFABIGEDGFJ PNBLIJIJJMA(this MonoBehaviour BFDDOFMGEOI, float HNIJOFMLOIP, Action PJBCEMJEHFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class NKFDANFMPPM : EBICJFLGMAG, IEnumerable<EBICJFLGMAG>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<EBICJFLGMAG> ICBOEDFOKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool IMAAJBHHANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Action PPJLCOAOGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool BOAMLACGKED;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PDNBCIHJPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8763B30", Offset = "0x8762D30", VA = "0x188763B30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action EEIPOFMPBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8763A90", Offset = "0x8762C90", VA = "0x188763A90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8764100", Offset = "0x8763300", VA = "0x188764100", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x87642F0", Offset = "0x87634F0", VA = "0x1887642F0")]
	public NKFDANFMPPM([Optional] Action PPJLCOAOGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8763C60", Offset = "0x8762E60", VA = "0x188763C60")]
	public void LHOMNBOIMGH(EBICJFLGMAG EPLAGLKPPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x87641A0", Offset = "0x87633A0", VA = "0x1887641A0")]
	private void MIAJANEBOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x87640F0", Offset = "0x87632F0", VA = "0x1887640F0", Slot = "7")]
	public bool LLGMPADMFAH(bool IKLDNLEDLAC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8763DF0", Offset = "0x8762FF0", VA = "0x188763DF0", Slot = "8")]
	public bool LLGMPADMFAH(Action CJLPDLONOLK, bool IKLDNLEDLAC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8763A10", Offset = "0x8762C10", VA = "0x188763A10", Slot = "9")]
	public IEnumerator<EBICJFLGMAG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8763A10", Offset = "0x8762C10", VA = "0x188763A10", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class IBKANNNLGOB : IBIGICNKLJG
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class AHCPDEEKEJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public IBKANNNLGOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AHCPDEEKEJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x874FA00", Offset = "0x874EC00", VA = "0x18874FA00")]
		internal void HFBFOPOFOFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class NDECNKFFIBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IBKANNNLGOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NDECNKFFIBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x874FA00", Offset = "0x874EC00", VA = "0x18874FA00")]
		internal void MADLMGCGIGB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly float NNCOIEJNHCA;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x875A780", Offset = "0x8759980", VA = "0x18875A780")]
	public IBKANNNLGOB(Behaviour BKDMJHGCDEA, float NNCOIEJNHCA, [Optional] Action PPJLCOAOGPL, [Optional] POGLNMFMHLK NIBFMCDFOKG, [Optional] MEEEEDNDAED HEPIMJLIPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x875A560", Offset = "0x8759760", VA = "0x18875A560", Slot = "9")]
	protected override bool GELODEGIGGA(Action CJLPDLONOLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x875A670", Offset = "0x8759870", VA = "0x18875A670", Slot = "10")]
	protected override bool HCAABIJFFMK(Action CJLPDLONOLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface EBICJFLGMAG
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool PDNBCIHJPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action EEIPOFMPBFN;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LLGMPADMFAH(bool IKLDNLEDLAC = false);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LLGMPADMFAH(Action CJLPDLONOLK, bool IKLDNLEDLAC = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class IBIGICNKLJG : EBICJFLGMAG
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class GGAPICPMPDA : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public IBIGICNKLJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public GGAPICPMPDA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8758BF0", Offset = "0x8757DF0", VA = "0x188758BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8758CC0", Offset = "0x8757EC0", VA = "0x188758CC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Behaviour BKDMJHGCDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action PPJLCOAOGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private ABAHHGGDFBO AJIFNLFHDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly POGLNMFMHLK NIBFMCDFOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	protected readonly MEEEEDNDAED HEPIMJLIPCA;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PDNBCIHJPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1B62D40", Offset = "0x1B61F40", VA = "0x181B62D40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action EEIPOFMPBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8759FC0", Offset = "0x87591C0", VA = "0x188759FC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x875A120", Offset = "0x8759320", VA = "0x18875A120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x875A430", Offset = "0x8759630", VA = "0x18875A430")]
	protected IBIGICNKLJG(Behaviour BKDMJHGCDEA, [Optional] Action PPJLCOAOGPL, [Optional] POGLNMFMHLK NIBFMCDFOKG, [Optional] MEEEEDNDAED HEPIMJLIPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x875A060", Offset = "0x8759260", VA = "0x18875A060", Slot = "7")]
	public bool LLGMPADMFAH(bool IKLDNLEDLAC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x875A0C0", Offset = "0x87592C0", VA = "0x18875A0C0", Slot = "8")]
	public bool LLGMPADMFAH(Action CJLPDLONOLK, bool IKLDNLEDLAC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GELODEGIGGA(Action CJLPDLONOLK);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool HCAABIJFFMK(Action CJLPDLONOLK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x875A410", Offset = "0x8759610", VA = "0x18875A410")]
	protected void ONABENAAFLJ(Action CJLPDLONOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x875A1C0", Offset = "0x87593C0", VA = "0x18875A1C0")]
	protected IFBEDABPFIF NFFGFIJBBOM(float PFMGKMLLMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8759E70", Offset = "0x8759070", VA = "0x188759E70")]
	private void AIKNJJHBAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8759F30", Offset = "0x8759130", VA = "0x188759F30")]
	[IteratorStateMachine(typeof(GGAPICPMPDA))]
	private IEnumerator<NOFGPJFCPHG> FKDPPKPJJKM(float PFMGKMLLMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8759EF0", Offset = "0x87590F0", VA = "0x188759EF0")]
	[CompilerGenerated]
	private void EFBPOCKFPPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class ACDIHJAKDPB : IBIGICNKLJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly float NNGJIGDAICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly int COFANOOHPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly float EBOCMIBADCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly float[] FIAABOHIKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int BMOOLDJIKDM;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x874F650", Offset = "0x874E850", VA = "0x18874F650")]
	public ACDIHJAKDPB(Behaviour BKDMJHGCDEA, float OLEDAFGDODH, int COFANOOHPOE, [Optional] Action PPJLCOAOGPL, float EBOCMIBADCK = 0f, [Optional] POGLNMFMHLK NIBFMCDFOKG, [Optional] MEEEEDNDAED HEPIMJLIPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "9")]
	protected override bool GELODEGIGGA(Action CJLPDLONOLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x874F450", Offset = "0x874E650", VA = "0x18874F450", Slot = "10")]
	protected override bool HCAABIJFFMK(Action CJLPDLONOLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x874F3D0", Offset = "0x874E5D0", VA = "0x18874F3D0")]
	private void BDAIOFEPMGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class NKMNHBGLANK : IBIGICNKLJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly float NNCOIEJNHCA;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x875A780", Offset = "0x8759980", VA = "0x18875A780")]
	public NKMNHBGLANK(Behaviour BKDMJHGCDEA, float NNCOIEJNHCA, [Optional] Action PPJLCOAOGPL, [Optional] POGLNMFMHLK NIBFMCDFOKG, [Optional] MEEEEDNDAED HEPIMJLIPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "9")]
	protected override bool GELODEGIGGA(Action CJLPDLONOLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8764390", Offset = "0x8763590", VA = "0x188764390", Slot = "10")]
	protected override bool HCAABIJFFMK(Action CJLPDLONOLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class LNBNHOFEELN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class NNINHKAOHBI : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public NNINHKAOHBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8756CA0", Offset = "0x8755EA0", VA = "0x188756CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8764C90", Offset = "0x8763E90", VA = "0x188764C90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private AFABIGEDGFJ KCLNILNJPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private HILNFMOEKON BKDMJHGCDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Action<float> CONKCNHKPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private BLKNIDPJAGC NBJKFEKGNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private float IDCJKOAMGBE;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x875ED10", Offset = "0x875DF10", VA = "0x18875ED10")]
	public LNBNHOFEELN(HILNFMOEKON BKDMJHGCDEA, float PHNFPAODELK, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x875EB20", Offset = "0x875DD20", VA = "0x18875EB20")]
	private void MLPNBBECKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x875E870", Offset = "0x875DA70", VA = "0x18875E870")]
	private void EOGPBCLEJOK(string HKIJLMNBOAG, Action DKDBPIIEIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x875EC90", Offset = "0x875DE90", VA = "0x18875EC90")]
	[IteratorStateMachine(typeof(NNINHKAOHBI))]
	private IEnumerator<NOFGPJFCPHG> NJODELFGHFE(Action DKDBPIIEIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x875E810", Offset = "0x875DA10", VA = "0x18875E810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x875E9A0", Offset = "0x875DBA0", VA = "0x18875E9A0")]
	[CompilerGenerated]
	private void HFPDPPIBMHG(string GMBDOBOLCOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class GALMFFIFEHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class DJAPDDKJKGM : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public DJAPDDKJKGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8756CA0", Offset = "0x8755EA0", VA = "0x188756CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8756D10", Offset = "0x8755F10", VA = "0x188756D10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private AFABIGEDGFJ KCLNILNJPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private MonoBehaviour BFDDOFMGEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Action EDGPFNFJGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Action<float> CONKCNHKPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private BLKNIDPJAGC NBJKFEKGNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float IDCJKOAMGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool LICGDFICFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly POGLNMFMHLK NIBFMCDFOKG;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x87586B0", Offset = "0x87578B0", VA = "0x1887586B0")]
	public GALMFFIFEHD(MonoBehaviour BFDDOFMGEOI, Action EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, [Optional] POGLNMFMHLK NIBFMCDFOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x8758840", Offset = "0x8757A40", VA = "0x188758840")]
	public GALMFFIFEHD(MonoBehaviour BFDDOFMGEOI, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, [Optional] POGLNMFMHLK NIBFMCDFOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x8758A10", Offset = "0x8757C10", VA = "0x188758A10")]
	public GALMFFIFEHD(MonoBehaviour BFDDOFMGEOI, float PHNFPAODELK, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, bool LICGDFICFAM = true, [Optional] POGLNMFMHLK NIBFMCDFOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4D18DE0", Offset = "0x4D17FE0", VA = "0x184D18DE0")]
	private GALMFFIFEHD(POGLNMFMHLK NIBFMCDFOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x8758350", Offset = "0x8757550", VA = "0x188758350")]
	internal static GALMFFIFEHD OKDGJKCDBLA(MonoBehaviour BFDDOFMGEOI, float PHNFPAODELK, Action<float> EDGPFNFJGKD, BLKNIDPJAGC NBJKFEKGNPB, bool LICGDFICFAM = true, [Optional] POGLNMFMHLK NIBFMCDFOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x8758580", Offset = "0x8757780", VA = "0x188758580")]
	private void POOFNLAFNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x87581D0", Offset = "0x87573D0", VA = "0x1887581D0")]
	private void OHMNHEPHJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x8757FE0", Offset = "0x87571E0", VA = "0x188757FE0")]
	private void MLPNBBECKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8757A80", Offset = "0x8756C80", VA = "0x188757A80")]
	private void AGAJOPJABOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8757E20", Offset = "0x8757020", VA = "0x188757E20")]
	private void EOGPBCLEJOK(string HKIJLMNBOAG, Action DKDBPIIEIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8758150", Offset = "0x8757350", VA = "0x188758150")]
	[IteratorStateMachine(typeof(DJAPDDKJKGM))]
	private IEnumerator<NOFGPJFCPHG> NJODELFGHFE(Action DKDBPIIEIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8757DC0", Offset = "0x8756FC0", VA = "0x188757DC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8757F50", Offset = "0x8757150", VA = "0x188757F50")]
	[CompilerGenerated]
	private void LCEGEFFPENM(string GMBDOBOLCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8757D30", Offset = "0x8756F30", VA = "0x188757D30")]
	[CompilerGenerated]
	private void DKAIFDINKOG(string GMBDOBOLCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8757C10", Offset = "0x8756E10", VA = "0x188757C10")]
	[CompilerGenerated]
	private void ALHFLOIIEFG(string GMBDOBOLCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8757CA0", Offset = "0x8756EA0", VA = "0x188757CA0")]
	[CompilerGenerated]
	private void CCAIPJJFNNK(string GMBDOBOLCOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum HLLCLEFILNJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class KGMDCJABGCH : MEEEEDNDAED
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float FGHKDAFDFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x875BD30", Offset = "0x875AF30", VA = "0x18875BD30", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float ICLLPAKLHLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x875BD40", Offset = "0x875AF40", VA = "0x18875BD40", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public double HEMKOIGOAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x875BD10", Offset = "0x875AF10", VA = "0x18875BD10", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x875BD50", Offset = "0x875AF50", VA = "0x18875BD50")]
	[MGCKGAIBEHC.PCMIGKEOIEO]
	internal static void LDPAGBHHOJF(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	[UnityEngine.Scripting.Preserve]
	internal KGMDCJABGCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface NKOMOODOICF
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPLIICENAIG(string GBOCGPJOEEK);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLJOGDIBFLA();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface EHAKCIMAJDK
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string KGCJIDMKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool GDGBNFIFMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool PFBHMOCNPKF
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class NLNHLNLOIGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public MCPMCBHIODI NJBIGIHLEKG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int IJCKDBACFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA03700", Offset = "0xA02900", VA = "0x180A03700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8764A70", Offset = "0x8763C70", VA = "0x188764A70")]
	public static NOFGPJFCPHG LPCEIKIFELA(IEnumerator<NOFGPJFCPHG> BNGEMBNCCKG, KLIHCEPBEEH EBKLEOAGJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8764BD0", Offset = "0x8763DD0", VA = "0x188764BD0")]
	public NOFGPJFCPHG LPCEIKIFELA(KLIHCEPBEEH[] MALHOHDJNJI, IEnumerator<NOFGPJFCPHG>[] KIBIJDFMOCC, NOFGPJFCPHG[] EGPKLIOGFEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x87647C0", Offset = "0x87639C0", VA = "0x1887647C0")]
	public void ANBHBBEOIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x87647F0", Offset = "0x87639F0", VA = "0x1887647F0")]
	public void BNHOKCMHHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8764930", Offset = "0x8763B30", VA = "0x188764930")]
	public void DKKAKCBECFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x87647C0", Offset = "0x87639C0", VA = "0x1887647C0")]
	public void BHDHLEMKOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public NLNHLNLOIGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class MCPMCBHIODI
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct PCLJPBDNLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public NLNHLNLOIGM FODLOJAJLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public HILNFMOEKON ODILGJPAECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public KLIHCEPBEEH MCKOACFOBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public IEnumerator<NOFGPJFCPHG> BLODAOBFBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public NOFGPJFCPHG DDANPFHOCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public HLLCLEFILNJ GIKBKCDEOCC;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct LALMKNCGIND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public BLKNIDPJAGC BCJPKBOPDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public List<PCLJPBDNLLO> OLNHFLMKFPK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class DGLKNHFIJFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public KLIHCEPBEEH promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public MCPMCBHIODI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public HILNFMOEKON context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public NLNHLNLOIGM routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public HLLCLEFILNJ coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public NOFGPJFCPHG currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public IEnumerator<NOFGPJFCPHG> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DGLKNHFIJFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x87564C0", Offset = "0x87556C0", VA = "0x1887564C0")]
		internal void PELOHBCFDEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class KEODOEAEPID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public NLNHLNLOIGM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public MCPMCBHIODI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KEODOEAEPID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x875BCD0", Offset = "0x875AED0", VA = "0x18875BCD0")]
		internal void IJCJHMKJDLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CCEJIDFAGKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public NLNHLNLOIGM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public MCPMCBHIODI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public CCEJIDFAGKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8750F00", Offset = "0x8750100", VA = "0x188750F00")]
		internal void OPKPBKFHFME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class CHIMKNHIMKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public NLNHLNLOIGM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public MCPMCBHIODI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public CHIMKNHIMKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x87517B0", Offset = "0x87509B0", VA = "0x1887517B0")]
		internal void IDBBFCCMGLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private const HLLCLEFILNJ ILHOMKKFCNI = HLLCLEFILNJ.Cancelled | HLLCLEFILNJ.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly BLKNIDPJAGC NBJKFEKGNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool[] NNIFIAEJCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private NativeArray<HLLCLEFILNJ> PONLKEAMCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NativeArray<float> OMBJGPKMDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private NativeArray<int> AMGIPDNJLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private NativeArray<int> KHBKIPJAHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private NativeArray<int> BMPBECOCAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NativeArray<int> FOOKFDGHCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private NativeArray<int> FGFLGCKMHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private NLNHLNLOIGM[] KKEMJHABGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private KLIHCEPBEEH[] MALHOHDJNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private HILNFMOEKON[] ECNIFLEBJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private IEnumerator<NOFGPJFCPHG>[] ANCHIIKOMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NOFGPJFCPHG[] BAHJINEOCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int OFPFJFALIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int POKPPHJAIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly int LJPOFFHOCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private float KCHOCMHABEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private DPAKCJFHFLN OPBNCGMCHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private JobHandle PIAPGCNAFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private List<NLNHLNLOIGM> ECNNBCCCENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool DNGNCMKBAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private List<Action> CGMDDBOKMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> LAJAPJHGNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool PEEMAMNMBHD;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public LALMKNCGIND[] BNKPBDOCLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xB0C950", Offset = "0xB0BB50", VA = "0x180B0C950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8761210", Offset = "0x8760410", VA = "0x188761210")]
	private static int OGHIABLNIGA(BLKNIDPJAGC NBJKFEKGNPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8761240", Offset = "0x8760440", VA = "0x188761240")]
	public MCPMCBHIODI(BLKNIDPJAGC NBJKFEKGNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x875FEE0", Offset = "0x875F0E0", VA = "0x18875FEE0")]
	private void GAGJNPMOGKJ(int NFKAHNCEKIC, int MCOHDLKOKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8761090", Offset = "0x8760290", VA = "0x188761090")]
	public void OFDFMMIBGJA(HILNFMOEKON BKDMJHGCDEA, NOFGPJFCPHG NLKCIFEJDEN, IEnumerator<NOFGPJFCPHG> BNGEMBNCCKG, KLIHCEPBEEH EBKLEOAGJJF, [Optional] NLNHLNLOIGM NNBGFBBAOLA, HLLCLEFILNJ HGHALACCFNL = HLLCLEFILNJ.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x875EEB0", Offset = "0x875E0B0", VA = "0x18875EEB0")]
	public void AHAFGIOCEMP(IEnumerable<PCLJPBDNLLO> LKHJCBPKAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8760470", Offset = "0x875F670", VA = "0x188760470")]
	private PCLJPBDNLLO JBNBHJNDPCM(int NNKDBEAAOGM)
	{
		return default(PCLJPBDNLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x875FB70", Offset = "0x875ED70", VA = "0x18875FB70")]
	private void FNNAHCCOBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8DB0", Offset = "0x3AE7FB0", VA = "0x183AE8DB0")]
	private static void GBMGLHCHGLE<T>(int NNKDBEAAOGM, T[] EONEDJOKNFM, int GCFCAGDGDIN, [Optional] T NHFDFJJMPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8E00", Offset = "0x3AE8000", VA = "0x183AE8E00")]
	private static void GBMGLHCHGLE<T>(int NNKDBEAAOGM, NativeArray<T> EONEDJOKNFM, int GCFCAGDGDIN, [Optional] T NHFDFJJMPIK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8760940", Offset = "0x875FB40", VA = "0x188760940")]
	private void JMJBDDEGFKJ(IEnumerable<PCLJPBDNLLO> LKHJCBPKAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8760D60", Offset = "0x875FF60", VA = "0x188760D60")]
	private void LHMLMLOAHDL(PCLJPBDNLLO LFFHCNNIECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8760E30", Offset = "0x8760030", VA = "0x188760E30")]
	private PHINPCICANJ MDCADMJPAII(int IJGBCGEFEGD)
	{
		return default(PHINPCICANJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8760270", Offset = "0x875F470", VA = "0x188760270")]
	public void IHCKGLMONAP(float GFNHPMDGFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x87601F0", Offset = "0x875F3F0", VA = "0x1887601F0")]
	private void IFKPBBNKOEB(Action BGPKBCGBDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8760CE0", Offset = "0x875FEE0", VA = "0x188760CE0")]
	private void JPCGCOHFCCE(Action BGPKBCGBDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x875F450", Offset = "0x875E650", VA = "0x18875F450")]
	public void EFLLCDHDFIN(float GFNHPMDGFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x875F220", Offset = "0x875E420", VA = "0x18875F220")]
	public void BHPGJKNEABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x875F0F0", Offset = "0x875E2F0", VA = "0x18875F0F0")]
	public void BHDHLEMKOHM(NLNHLNLOIGM CHGAJALIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x87600C0", Offset = "0x875F2C0", VA = "0x1887600C0")]
	public void IENMIHHEGBA(NLNHLNLOIGM CHGAJALIHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x875F320", Offset = "0x875E520", VA = "0x18875F320")]
	public void DEBNJIMMDPP(NLNHLNLOIGM CHGAJALIHNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NIDLMOJKHGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly NIDLMOJKHGA BCEMEONNHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly Action KGIAEMKECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private bool OLFOBLPNEEI;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public NIDLMOJKHGA(Action KGIAEMKECHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDAE0", Offset = "0x7DBCCE0", VA = "0x187DBDAE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface JNGABGNJPNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T LFLEGEJLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable BDAPKIFGLFA(UnityEngine.Object BKDMJHGCDEA, Action<T> JLAELGGKADP);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface FGEEFCIIBMB<T> : JNGABGNJPNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	new T LFLEGEJLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NEACKFPDCBO<T> : FGEEFCIIBMB<T>, JNGABGNJPNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class DJBHDAEJLPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public NEACKFPDCBO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public BGJLKFNGLAO<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DJBHDAEJLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4212F20", Offset = "0x4212120", VA = "0x184212F20")]
		internal void GPIHONPEOBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static GameObject LCGAIDCCOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly List<BGJLKFNGLAO<UnityEngine.Object, Action<T>>> BHNMOLEFLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private T IGNACDBEHGF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T LFLEGEJLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xB16990", Offset = "0xB15B90", VA = "0x180B16990", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x547CCD0", Offset = "0x547BED0", VA = "0x18547CCD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x547CD70", Offset = "0x547BF70", VA = "0x18547CD70")]
	private static bool LMOAPMCDNAB(T BGPKBCGBDMP, T NIJBGCGEGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x547D410", Offset = "0x547C610", VA = "0x18547D410")]
	public NEACKFPDCBO(T EKJDJKOGFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x547C950", Offset = "0x547BB50", VA = "0x18547C950", Slot = "6")]
	public IDisposable BDAPKIFGLFA(UnityEngine.Object BKDMJHGCDEA, Action<T> JLAELGGKADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x547D120", Offset = "0x547C320", VA = "0x18547D120")]
	private void PEMELCPKIHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class BOOHLOKFKBA : GIOPBGIKLHH
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private class CEHGPHDMJAM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		private class CCILFKCFCGD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private int APBCLGNDGBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private CEHGPHDMJAM IIOIMKJECAH;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xF32E30", Offset = "0xF32030", VA = "0x180F32E30")]
			public CCILFKCFCGD(int APBCLGNDGBE, CEHGPHDMJAM IIOIMKJECAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8750F40", Offset = "0x8750140", VA = "0x188750F40", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class MNNNKAOAOAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public MNNNKAOAOAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA750A0", Offset = "0xA742A0", VA = "0x180A750A0")]
			internal bool EEAPCCDHPJB(CBCANAGMCHK e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class KKGDFOBLMJM : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private NOFGPJFCPHG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public CEHGPHDMJAM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public MEEEEDNDAED timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			private COOOKCIHCJP <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private List<CBCANAGMCHK> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
			[DebuggerHidden]
			public KKGDFOBLMJM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x875BEF0", Offset = "0x875B0F0", VA = "0x18875BEF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x875C220", Offset = "0x875B420", VA = "0x18875C220", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly BLKNIDPJAGC NBJKFEKGNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private AFABIGEDGFJ EBKLEOAGJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly List<CBCANAGMCHK> ELIAJIMNNLM;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x87513C0", Offset = "0x87505C0", VA = "0x1887513C0")]
		public CEHGPHDMJAM(BLKNIDPJAGC NBJKFEKGNPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x87511E0", Offset = "0x87503E0", VA = "0x1887511E0")]
		public IDisposable GGIEIEHLBCE(CBCANAGMCHK DDJEECBJAGI, POGLNMFMHLK NIBFMCDFOKG, MEEEEDNDAED LAEALHELJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8750F70", Offset = "0x8750170", VA = "0x188750F70")]
		private void DDENGPAAFNH(int APBCLGNDGBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8751150", Offset = "0x8750350", VA = "0x188751150")]
		[IteratorStateMachine(typeof(KKGDFOBLMJM))]
		private IEnumerator<NOFGPJFCPHG> FNHMOJEDALD(MEEEEDNDAED LAEALHELJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8751100", Offset = "0x8750300", VA = "0x188751100", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class CBCANAGMCHK
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public enum GEHLBNOPAAE : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static int EBNBJHNOPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly int HHPKMABLCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly DJNFGEJICJL ODILGJPAECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly MonoBehaviour EPPOOBFJAED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly Action KJFMNLEBHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly Action<float> BAINPJLFKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly float OBFKGMPHBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public float OMBJGPKMDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public readonly string KGCJIDMKOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public readonly bool ALJHPKNJHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly GEHLBNOPAAE LLPHMAIGOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool OPBNBJBEJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public bool EDCEOJFJDHO;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8750BA0", Offset = "0x874FDA0", VA = "0x188750BA0")]
		public CBCANAGMCHK(DJNFGEJICJL BKDMJHGCDEA, Action EDGPFNFJGKD, bool GBMDKDKOLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8750A20", Offset = "0x874FC20", VA = "0x188750A20")]
		public CBCANAGMCHK(DJNFGEJICJL BKDMJHGCDEA, Action<float> EDGPFNFJGKD, bool GBMDKDKOLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8750D20", Offset = "0x874FF20", VA = "0x188750D20")]
		public CBCANAGMCHK(DJNFGEJICJL BKDMJHGCDEA, float PHNFPAODELK, Action<float> EDGPFNFJGKD, MEEEEDNDAED LAEALHELJKO, GEHLBNOPAAE EKJEBJJCKNC, bool LICGDFICFAM, bool GBMDKDKOLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8750850", Offset = "0x874FA50", VA = "0x188750850")]
		public bool FHMMJJAAAJA(float MGFEHNJFHAM, float AKHINELDCBO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly POGLNMFMHLK NIBFMCDFOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly MEEEEDNDAED HEPIMJLIPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly Dictionary<BLKNIDPJAGC, CEHGPHDMJAM> DJEAPDAJBCN;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x874FE80", Offset = "0x874F080", VA = "0x18874FE80")]
	[MGCKGAIBEHC.PCMIGKEOIEO]
	internal static void EOOLAECFBOB(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8750790", Offset = "0x874F990", VA = "0x188750790")]
	[UnityEngine.Scripting.Preserve]
	internal BOOHLOKFKBA([NGLIAOPBMFM(null)] POGLNMFMHLK NIBFMCDFOKG, [NGLIAOPBMFM(null)] MEEEEDNDAED HEPIMJLIPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8750220", Offset = "0x874F420", VA = "0x188750220", Slot = "4")]
	public IDisposable KJFMNLEBHBJ(DJNFGEJICJL BKDMJHGCDEA, Action MHPGHAHOBNK, BLKNIDPJAGC NBJKFEKGNPB, bool GBMDKDKOLMO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8750030", Offset = "0x874F230", VA = "0x188750030", Slot = "5")]
	public IDisposable KJFMNLEBHBJ(DJNFGEJICJL BKDMJHGCDEA, Action<float> MHPGHAHOBNK, BLKNIDPJAGC NBJKFEKGNPB, bool GBMDKDKOLMO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x8750690", Offset = "0x874F890", VA = "0x188750690", Slot = "7")]
	public IDisposable PIFJNJNMBCA(DJNFGEJICJL BKDMJHGCDEA, float PHNFPAODELK, Action<float> MHPGHAHOBNK, BLKNIDPJAGC NBJKFEKGNPB, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8750410", Offset = "0x874F610", VA = "0x188750410", Slot = "8")]
	public IDisposable LGHPEOICCMA(DJNFGEJICJL BKDMJHGCDEA, float PHNFPAODELK, Action<float> MHPGHAHOBNK, BLKNIDPJAGC NBJKFEKGNPB, bool LICGDFICFAM = true, bool GBMDKDKOLMO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8750510", Offset = "0x874F710", VA = "0x188750510", Slot = "6")]
	public IDisposable PIFJNJNMBCA(float PHNFPAODELK, Action<float> MHPGHAHOBNK, bool LICGDFICFAM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x874FCC0", Offset = "0x874EEC0", VA = "0x18874FCC0", Slot = "9")]
	public void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x874FEF0", Offset = "0x874F0F0", VA = "0x18874FEF0")]
	private CEHGPHDMJAM JMLIPIOMEPA(BLKNIDPJAGC NBJKFEKGNPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PGFLJOGDIEK : MFMJADFIMCB, POGLNMFMHLK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private MCPMCBHIODI[] NPALCIHMHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NKOMOODOICF JNBJHEAPBPD;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8765BE0", Offset = "0x8764DE0", VA = "0x188765BE0")]
	[MGCKGAIBEHC.PCMIGKEOIEO]
	internal static void LDPAGBHHOJF(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8765FB0", Offset = "0x87651B0", VA = "0x188765FB0")]
	[UnityEngine.Scripting.Preserve]
	public PGFLJOGDIEK([NGLIAOPBMFM(null)] OEEHFFIDOCB NINNCCEOCGN, [NGLIAOPBMFM(null)] MEEEEDNDAED HEPIMJLIPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8765C50", Offset = "0x8764E50", VA = "0x188765C50", Slot = "19")]
	public override AFABIGEDGFJ NLKHIGBCCMB(HILNFMOEKON BKDMJHGCDEA, IEnumerator<NOFGPJFCPHG> CLCIPKAPFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8765400", Offset = "0x8764600", VA = "0x188765400", Slot = "20")]
	public override void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8765720", Offset = "0x8764920", VA = "0x188765720", Slot = "22")]
	public override void IHHJHJDABBA(BLKNIDPJAGC NBJKFEKGNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8765A70", Offset = "0x8764C70", VA = "0x188765A70", Slot = "21")]
	protected override void KJFMNLEBHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x87656F0", Offset = "0x87648F0", VA = "0x1887656F0")]
	private MCPMCBHIODI FJMJBJBFHFI(BLKNIDPJAGC GDHKDBJPDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x8765D80", Offset = "0x8764F80", VA = "0x188765D80", Slot = "23")]
	internal override NJPCOLOIBOO PIDBNAMABIN(IEnumerator<NOFGPJFCPHG> CLCIPKAPFHN, Behaviour BKDMJHGCDEA, KLIHCEPBEEH EBKLEOAGJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x8765340", Offset = "0x8764540", VA = "0x188765340", Slot = "24")]
	internal override LHIGCCPACBN AALCJIBCEAD(BLKNIDPJAGC IIOIMKJECAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8765950", Offset = "0x8764B50", VA = "0x188765950")]
	private void KGDACFDLFKC(MCPMCBHIODI KGKDEGOOGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8765690", Offset = "0x8764890", VA = "0x188765690", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[BurstCompile]
internal struct DPAKCJFHFLN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	[ReadOnly]
	public float OPLCOBOALHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	[ReadOnly]
	public int AINBJMCOOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private NativeArray<int> LMHHBOPHABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private NativeArray<int> ODMPPOEPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private NativeArray<int> GOGFFHEMHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	[ReadOnly]
	public NativeArray<HLLCLEFILNJ> FKBDBIAMJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[ReadOnly]
	public NativeArray<float> JDELDJLMLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	[WriteOnly]
	public NativeArray<int> BMPBECOCAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	[WriteOnly]
	public NativeArray<int> AMGIPDNJLDA;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8756F40", Offset = "0x8756140", VA = "0x188756F40")]
	public static DPAKCJFHFLN DBJJOAFKEPP(int IGNACHBFMIM, float GFNHPMDGFHA, NativeArray<HLLCLEFILNJ> OPFEIANOAGO, NativeArray<float> CLICPLJAEDA, NativeArray<int> HDHONJIHPIF, NativeArray<int> JNFFKFACNBB, NativeArray<int> LAENGOHEKLL, NativeArray<int> ODMPPOEPJKL, NativeArray<int> GOGFFHEMHBA)
	{
		return default(DPAKCJFHFLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x8757040", Offset = "0x8756240", VA = "0x188757040", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x8757430", Offset = "0x8756630", VA = "0x188757430")]
	private bool MMADBEIJOEG(int CMDFFDAPDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x8757470", Offset = "0x8756670", VA = "0x188757470")]
	private void NBMCOBAPOHP(NativeArray<int> MFKIFEAAJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x8756FA0", Offset = "0x87561A0", VA = "0x188756FA0")]
	private int EGPACKCLIGJ(int AMOPLAKIEKI, int EBBCBLHPEED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8757120", Offset = "0x8756320", VA = "0x188757120")]
	private void FMFIPENECOF(NativeArray<int> MFKIFEAAJCA, int LCOMMDLBGIL, int EJNMHOGNAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x87571F0", Offset = "0x87563F0", VA = "0x1887571F0")]
	private void GODIGBPKMOG(NativeArray<int> MFKIFEAAJCA, int DLBKPFKFLAO, int AJEFJFFIKED, int JFFBOCCMACF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class MFMJADFIMCB : POGLNMFMHLK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly OEEHFFIDOCB NINNCCEOCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	protected readonly MEEEEDNDAED HEPIMJLIPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private LHIGCCPACBN[] AILHFDPFGEB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static POGLNMFMHLK AIBLJDBPKAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8761A10", Offset = "0x8760C10", VA = "0x188761A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool CFMEGCKFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public BLKNIDPJAGC LKJBMHMFBPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BLKNIDPJAGC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA03700", Offset = "0xA02900", VA = "0x180A03700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public MEEEEDNDAED KIMBLDOOHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public NOFGPJFCPHG FKOLFPHJACO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public NOFGPJFCPHG ECKPHHHHKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public NOFGPJFCPHG LPOAAIGDNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NOFGPJFCPHG KGLKMMDJPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8762430", Offset = "0x8761630", VA = "0x188762430")]
	public static AFABIGEDGFJ KACLJLLIKKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x87628F0", Offset = "0x8761AF0", VA = "0x1887628F0")]
	[UnityEngine.Scripting.Preserve]
	protected MFMJADFIMCB([NGLIAOPBMFM(null)] OEEHFFIDOCB NINNCCEOCGN, [NGLIAOPBMFM(null)] MEEEEDNDAED HEPIMJLIPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8762220", Offset = "0x8761420", VA = "0x188762220", Slot = "6")]
	public AFABIGEDGFJ JGHBEDNJLDN(IEnumerator<NOFGPJFCPHG> CLCIPKAPFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8762230", Offset = "0x8761430", VA = "0x188762230", Slot = "7")]
	public AFABIGEDGFJ JGHBEDNJLDN(Behaviour BKDMJHGCDEA, IEnumerator<NOFGPJFCPHG> CLCIPKAPFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract AFABIGEDGFJ NLKHIGBCCMB(HILNFMOEKON BKDMJHGCDEA, IEnumerator<NOFGPJFCPHG> CLCIPKAPFHN);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8761B00", Offset = "0x8760D00", VA = "0x188761B00", Slot = "20")]
	public virtual void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x87624E0", Offset = "0x87616E0", VA = "0x1887624E0", Slot = "9")]
	public void MLHAPENNONF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x87624C0", Offset = "0x87616C0", VA = "0x1887624C0", Slot = "21")]
	protected virtual void KJFMNLEBHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8762060", Offset = "0x8761260", VA = "0x188762060")]
	private void EAJGMKMBGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x8762200", Offset = "0x8761400", VA = "0x188762200")]
	private void JEMBBKANOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8761AA0", Offset = "0x8760CA0", VA = "0x188761AA0")]
	private void CCIAPFEJBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8761AE0", Offset = "0x8760CE0", VA = "0x188761AE0")]
	private void DEBKBBLLDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8761A80", Offset = "0x8760C80", VA = "0x188761A80")]
	private void BPKDKHGPJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8761990", Offset = "0x8760B90", VA = "0x188761990")]
	private void AFJDMHNKKKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8761AC0", Offset = "0x8760CC0", VA = "0x188761AC0")]
	private void CHPAFDIBHPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8762170", Offset = "0x8761370", VA = "0x188762170", Slot = "22")]
	public virtual void IHHJHJDABBA(BLKNIDPJAGC NBJKFEKGNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8762720", Offset = "0x8761920", VA = "0x188762720")]
	private void NEPBIEIFBCF(LHIGCCPACBN KGKDEGOOGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2772B60", Offset = "0x2771D60", VA = "0x182772B60")]
	private LHIGCCPACBN NADNFGFHNOI(BLKNIDPJAGC GDHKDBJPDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract NJPCOLOIBOO PIDBNAMABIN(IEnumerator<NOFGPJFCPHG> CLCIPKAPFHN, Behaviour BFDDOFMGEOI, KLIHCEPBEEH AHJDKACHCJI);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract LHIGCCPACBN AALCJIBCEAD(BLKNIDPJAGC NBJKFEKGNPB);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x8761CA0", Offset = "0x8760EA0", VA = "0x188761CA0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8762080", Offset = "0x8761280", VA = "0x188762080", Slot = "15")]
	public NOFGPJFCPHG FKAEJHAKCPB(BLKNIDPJAGC IIOIMKJECAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x87620E0", Offset = "0x87612E0", VA = "0x1887620E0", Slot = "16")]
	public NOFGPJFCPHG HPKHBFBBDOO(float GKFLGCPHKEK, BLKNIDPJAGC IIOIMKJECAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x87619B0", Offset = "0x8760BB0", VA = "0x1887619B0", Slot = "17")]
	public NOFGPJFCPHG AFKPJMNAAIP(Func<bool> BELLBJOFLIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class NJPCOLOIBOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly KLIHCEPBEEH EBKLEOAGJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly EHAKCIMAJDK BKDMJHGCDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly bool KGOMKGJHGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private string GBOCGPJOEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private StackTrace FAPMBMMADIA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerator<NOFGPJFCPHG> BLODAOBFBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NOFGPJFCPHG DDANPFHOCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JPHDKNJDPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8763220", Offset = "0x8762420", VA = "0x188763220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DINMMCGFIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xC777B0", Offset = "0xC769B0", VA = "0x180C777B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xCAC420", Offset = "0xCAB620", VA = "0x180CAC420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string KGCJIDMKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x87632A0", Offset = "0x87624A0", VA = "0x1887632A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float BKBKADDHFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xDE6A80", Offset = "0xDE5C80", VA = "0x180DE6A80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xDE6A90", Offset = "0xDE5C90", VA = "0x180DE6A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8763850", Offset = "0x8762A50", VA = "0x188763850")]
	public NJPCOLOIBOO(IEnumerator<NOFGPJFCPHG> BNGEMBNCCKG, EHAKCIMAJDK BKDMJHGCDEA, KLIHCEPBEEH EBKLEOAGJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8763450", Offset = "0x8762650", VA = "0x188763450")]
	public NOFGPJFCPHG LPCEIKIFELA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x87631B0", Offset = "0x87623B0", VA = "0x1887631B0")]
	public bool DHLKBCMDINK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8763160", Offset = "0x8762360", VA = "0x188763160")]
	public void BHDHLEMKOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8763770", Offset = "0x8762970", VA = "0x188763770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0xCF62D0", Offset = "0xCF54D0", VA = "0x180CF62D0")]
	[CompilerGenerated]
	private void AGIJHDAHABK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class KLIHCEPBEEH : BLOOIBLLBLO, AFABIGEDGFJ, ABAHHGGDFBO, IFBEDABPFIF, IEnumerator, NOFGPJFCPHG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private BLKNIDPJAGC CMGBBGBEICH;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private BLKNIDPJAGC DGADCIIFKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xDD2250", Offset = "0xDD1450", VA = "0x180DD2250", Slot = "23")]
		get
		{
			return default(BLKNIDPJAGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public BLKNIDPJAGC NJBIGIHLEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xF52570", Offset = "0xF51770", VA = "0x180F52570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private float GDNCHFBKLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xC49300", Offset = "0xC48500", VA = "0x180C49300", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool OCKCIEEFEGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x875C280", Offset = "0x875B480", VA = "0x18875C280", Slot = "24")]
	private bool KJODMFMOJJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x875C270", Offset = "0x875B470", VA = "0x18875C270", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x875C2A0", Offset = "0x875B4A0", VA = "0x18875C2A0")]
	public KLIHCEPBEEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal enum PHINPCICANJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class LHIGCCPACBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum ADPCAAILEKC
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public struct FEEPKBENOPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public BLKNIDPJAGC BCJPKBOPDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public ADPCAAILEKC OEENDIGLDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public List<NJPCOLOIBOO> EDJFGPONJJI;
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly ADPCAAILEKC[] PAGLIBKCKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly BLKNIDPJAGC NBJKFEKGNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private bool BCEJFHKFIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly NJPCOLOIBOO[] IMEIOCHJNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<NJPCOLOIBOO> KADKPBAKGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly Stack<int> KBNBLNJCDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly List<NJPCOLOIBOO> LPBACODNKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly Stack<int> NBNIFAAJJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly NKOMOODOICF JDKKKBIDHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private bool PEEMAMNMBHD;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public FEEPKBENOPA[,] FCIILIHHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x875E380", Offset = "0x875D580", VA = "0x18875E380")]
	public LHIGCCPACBN(BLKNIDPJAGC IIOIMKJECAH, NKOMOODOICF JDKKKBIDHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x875D4E0", Offset = "0x875C6E0", VA = "0x18875D4E0")]
	public void GFHKPCLFDEI(NJPCOLOIBOO BNGEMBNCCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x875CDA0", Offset = "0x875BFA0", VA = "0x18875CDA0")]
	public void AGODGJFDFOL(IList<NJPCOLOIBOO> KIBIJDFMOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x875DDF0", Offset = "0x875CFF0", VA = "0x18875DDF0")]
	public void OCIACMKMENJ(IList<NJPCOLOIBOO> KIBIJDFMOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x875E100", Offset = "0x875D300", VA = "0x18875E100")]
	private void PEDEAPACBBC(NJPCOLOIBOO BNGEMBNCCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x875D0B0", Offset = "0x875C2B0", VA = "0x18875D0B0")]
	private void AIMIPEKLFKG(IList<NJPCOLOIBOO> KIBIJDFMOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x875D240", Offset = "0x875C440", VA = "0x18875D240")]
	private PHINPCICANJ BNADKCGIOLB(NJPCOLOIBOO BNGEMBNCCKG)
	{
		return default(PHINPCICANJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x875D730", Offset = "0x875C930", VA = "0x18875D730")]
	public void KJFMNLEBHBJ(float GFNHPMDGFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x875DC00", Offset = "0x875CE00", VA = "0x18875DC00")]
	public void MLHAPENNONF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x875D8A0", Offset = "0x875CAA0", VA = "0x18875D8A0")]
	private void MAFPAKJLBGL(List<NJPCOLOIBOO> KIBIJDFMOCC, Stack<int> EIIHLPNDBDE, bool GBJFKBMHLLP, float MOKHEOEIIHF = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x875D3C0", Offset = "0x875C5C0", VA = "0x18875D3C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x875D5F0", Offset = "0x875C7F0", VA = "0x18875D5F0")]
	private void HCDMJDLKBEA(List<NJPCOLOIBOO> KIBIJDFMOCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal class LBPENOPPIBI : NKOMOODOICF
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	public void NPLIICENAIG(string GBOCGPJOEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
	public void GLJOGDIBFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public LBPENOPPIBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal class MDOINLFIEFD : EHAKCIMAJDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly Behaviour BFDDOFMGEOI;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string KGCJIDMKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x87618C0", Offset = "0x8760AC0", VA = "0x1887618C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool GDGBNFIFMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8761940", Offset = "0x8760B40", VA = "0x188761940", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PFBHMOCNPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x87618A0", Offset = "0x8760AA0", VA = "0x1887618A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public MDOINLFIEFD(Behaviour BFDDOFMGEOI)
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

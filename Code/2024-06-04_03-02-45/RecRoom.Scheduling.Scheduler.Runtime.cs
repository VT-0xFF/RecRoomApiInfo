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
public class FEEJBIFCEMM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority JPFDAKLIDGL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7161030", Offset = "0x715F830", VA = "0x187161030")]
	public FEEJBIFCEMM(ThreadPriority GFIAJBKCDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7161020", Offset = "0x715F820", VA = "0x187161020", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> EJNOELCHOBE(List<PlayerLoopSystem> JKJGJLKEKFD, int NHCNOPLHCDC);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct DFEGLPGJEBD
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct GNEHFENGFDD
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static LFHDLKLNBFG GGNADDCBJND;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x71652E0", Offset = "0x7163AE0", VA = "0x1871652E0")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct MIPKGKOKIDK
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static LFHDLKLNBFG DCJNHGMJAFB;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x716CA40", Offset = "0x716B240", VA = "0x18716CA40")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct IOHFKHIJCLL
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static LFHDLKLNBFG HLHMHJBKBHE;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x7166D70", Offset = "0x7165570", VA = "0x187166D70")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct IHLAJBDIHPI
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static LFHDLKLNBFG KHMJBMAEJJD;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static LFHDLKLNBFG FOGGLBIKNKB;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static LFHDLKLNBFG NAOGHFCBCEF;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static LFHDLKLNBFG BCOKCOJGPCI;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x71668C0", Offset = "0x71650C0", VA = "0x1871668C0")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct JKKHGEEGKLI
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static LFHDLKLNBFG CHALBKLLAAO;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x7168910", Offset = "0x7167110", VA = "0x187168910")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct BNFHEDIKGBC
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static LFHDLKLNBFG KHMJBMAEJJD;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static LFHDLKLNBFG FOGGLBIKNKB;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static LFHDLKLNBFG NAOGHFCBCEF;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static LFHDLKLNBFG BCOKCOJGPCI;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x71587D0", Offset = "0x7156FD0", VA = "0x1871587D0")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct OJPEDEGAMBJ
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static LFHDLKLNBFG KJAKJGOGDPE;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x71701B0", Offset = "0x716E9B0", VA = "0x1871701B0")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct KEALCKLCLJP
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static LFHDLKLNBFG GOGDFAECDIK;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x7168CA0", Offset = "0x71674A0", VA = "0x187168CA0")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct LEBKFGFAHLD
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static LFHDLKLNBFG JJFKCBIBMPN;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x716B0F0", Offset = "0x71698F0", VA = "0x18716B0F0")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct IPNLPNJENKD
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static LFHDLKLNBFG OONNFOPMAMM;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x7167300", Offset = "0x7165B00", VA = "0x187167300")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct ILNNCCOHJKE
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static LFHDLKLNBFG FGADFPNIIKE;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x7166B90", Offset = "0x7165390", VA = "0x187166B90")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct GAPOFGDDKFD
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static LFHDLKLNBFG KLCCJCHGIHA;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x7163C30", Offset = "0x7162430", VA = "0x187163C30")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct IHACMNBIGOB
			{
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public static LFHDLKLNBFG OFHOGJGNPKE;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x71666E0", Offset = "0x7164EE0", VA = "0x1871666E0")]
				public static PlayerLoopSystem LAEOLFAONPI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum GEAFFBMLFPF : byte
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
			public struct BCNLJEOLIJK
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class CNPFHMFEFAA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public GEAFFBMLFPF updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
					public CNPFHMFEFAA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x7158F70", Offset = "0x7157770", VA = "0x187158F70")]
					internal void IBJDDKGFCOH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public static EPMNOCMNENI<GEAFFBMLFPF> NGEILIJMLDH;

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x71572A0", Offset = "0x7155AA0", VA = "0x1871572A0")]
				public static PlayerLoopSystem LAEOLFAONPI(GEAFFBMLFPF LOAALLJFKGJ)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct BGNCADFAOKH
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class LBGOIIDEAII
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public DLPCKJAFICJ.HBPCCMDBNNG key;

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
					public LBGOIIDEAII()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x716ADB0", Offset = "0x71695B0", VA = "0x18716ADB0")]
					internal void FLKLGCGOGEM()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public static IDisposable FJPPECENOAG;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x7157460", Offset = "0x7155C60", VA = "0x187157460")]
				public static PlayerLoopSystem AEJCOCJCBOO(DLPCKJAFICJ.HBPCCMDBNNG JOEHGGMHBAA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct OPFDCJKJIPE
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class OJNMHIKJODL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public DLPCKJAFICJ.HBPCCMDBNNG key;

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
					public OJNMHIKJODL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x716FF00", Offset = "0x716E700", VA = "0x18716FF00")]
					internal void FLKLGCGOGEM()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x7170390", Offset = "0x716EB90", VA = "0x187170390")]
				public static PlayerLoopSystem AEJCOCJCBOO(DLPCKJAFICJ.HBPCCMDBNNG JOEHGGMHBAA)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class PGDFALAHMPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public PGDFALAHMPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7170500", Offset = "0x716ED00", VA = "0x187170500")]
			internal List<PlayerLoopSystem> GGAJKGEPKPG(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool CNNGBGFAAFD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool HMHJOGFEMKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x715C150", Offset = "0x715A950", VA = "0x18715C150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7159210", Offset = "0x7157A10", VA = "0x187159210")]
		private static void DBANJIGPJIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x715C190", Offset = "0x715A990", VA = "0x18715C190")]
		private static void HAGEBNBIMGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7158FF0", Offset = "0x71577F0", VA = "0x187158FF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x715CAA0", Offset = "0x715B2A0", VA = "0x18715CAA0")]
		private static void IIDOMGBKBAG(DLPCKJAFICJ.HBPCCMDBNNG JOEHGGMHBAA, PlayerLoopSystem OODNNOPGEJK, Type LFFICABPNMB, Type OCKEADDFNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x715BD70", Offset = "0x715A570", VA = "0x18715BD70")]
		private static void DJCPINCMJNK(PlayerLoopSystem OODNNOPGEJK, Type LFFICABPNMB, Type OCKEADDFNJN, EJNOELCHOBE BADLCODBHKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x715CC60", Offset = "0x715B460", VA = "0x18715CC60")]
		private static void NEIJINPPFHE(PlayerLoopSystem OODNNOPGEJK, Type LFFICABPNMB, Type OCKEADDFNJN, PlayerLoopSystem? PFOANEMBOIC, PlayerLoopSystem? GJFDHLBPPDA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DLPCKJAFICJ
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum HBPCCMDBNNG
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
	public class ABCGPBNINMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly HBPCCMDBNNG GPHJMCMGGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly OINABMAGLPB HFDHJJJIHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long KAECOPJCFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private long CAAKAPMJCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long BINFNDPBCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int AOLPNMCDGDO;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7156820", Offset = "0x7155020", VA = "0x187156820")]
		public ABCGPBNINMA(HBPCCMDBNNG HBGLFNPMCIB, int JFMFDMNABJC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7156580", Offset = "0x7154D80", VA = "0x187156580")]
		public void BNKIHPKLPED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x71567D0", Offset = "0x7154FD0", VA = "0x1871567D0")]
		public void PMDLMPGDIAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x71565F0", Offset = "0x7154DF0", VA = "0x1871565F0")]
		public void BOMPMHOJGLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static HBPCCMDBNNG[] BFBLEKEMGEJ;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static ABCGPBNINMA[] JOEAFHKJPAK;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x715E6F0", Offset = "0x715CEF0", VA = "0x18715E6F0")]
	public static ABCGPBNINMA KPLOKLAIIFL(HBPCCMDBNNG JOEHGGMHBAA, int JFMFDMNABJC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x715E5E0", Offset = "0x715CDE0", VA = "0x18715E5E0")]
	public static ABCGPBNINMA AIHMEJABCFK(HBPCCMDBNNG JOEHGGMHBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x715E650", Offset = "0x715CE50", VA = "0x18715E650")]
	public static void COBGEPDHLFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class OINABMAGLPB : OKIFONPOKMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public int DMEJBBBBMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Queue<double> BLOEFJAMPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double PHJDDFAGKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double AMCDFFFIAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double KHMHKCJPMBD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double FKCFNGBEEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x716FD30", Offset = "0x716E530", VA = "0x18716FD30", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double FNKMAAOIPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1A07570", Offset = "0x1A05D70", VA = "0x181A07570", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double FLEGGAABPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1EDA2F0", Offset = "0x1ED8AF0", VA = "0x181EDA2F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x716FE00", Offset = "0x716E600", VA = "0x18716FE00")]
	public OINABMAGLPB(int MIJJLLGKBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x716FC10", Offset = "0x716E410", VA = "0x18716FC10", Slot = "7")]
	public void DBHPKOMHDJO(double FCGMGAOCKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x716FD90", Offset = "0x716E590", VA = "0x18716FD90", Slot = "8")]
	public void NJEEDNGOJJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class BBPBKPEDPFP : OKIFONPOKMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private long POAAACAIHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double LNJDOCIBDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double LKOICLHOINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double JDAHNFHOFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double EEEEMEPOCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double PHJDDFAGKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private double AMCDFFFIAPA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double FNKMAAOIPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E33D60", Offset = "0x5E32560", VA = "0x185E33D60", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double FLEGGAABPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E338A0", Offset = "0x5E320A0", VA = "0x185E338A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double JDBMBAGDCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E33890", Offset = "0x5E32090", VA = "0x185E33890")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FKCFNGBEEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x249B070", Offset = "0x2499870", VA = "0x18249B070", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7157110", Offset = "0x7155910", VA = "0x187157110", Slot = "7")]
	public virtual void DBHPKOMHDJO(double FCGMGAOCKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7157230", Offset = "0x7155A30", VA = "0x187157230", Slot = "8")]
	public virtual void NJEEDNGOJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7157270", Offset = "0x7155A70", VA = "0x187157270")]
	public BBPBKPEDPFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NHAHNAJCGJO : BBPBKPEDPFP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double BPKBHINCJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E33D80", Offset = "0x5E32580", VA = "0x185E33D80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5E33D40", Offset = "0x5E32540", VA = "0x185E33D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x716F6E0", Offset = "0x716DEE0", VA = "0x18716F6E0", Slot = "7")]
	public override void DBHPKOMHDJO(double FCGMGAOCKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x716F810", Offset = "0x716E010", VA = "0x18716F810", Slot = "8")]
	public override void NJEEDNGOJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7157270", Offset = "0x7155A70", VA = "0x187157270")]
	public NHAHNAJCGJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface OKIFONPOKMA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double FKCFNGBEEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double FNKMAAOIPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double FLEGGAABPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class MFPLAAMCJBD
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface BJGBPACOPFG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool BFLEDHPFGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DGMMFKFGKCB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private abstract class BBMOIKJIEHJ<TPromise, TMainThreadPromise> : BJGBPACOPFG where TPromise : JHMBDMCOPKA where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly TPromise OMAGKGBNEDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly TMainThreadPromise EILNAAOJENF;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise CDJDGDBJOPI
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x4D17F70", Offset = "0x4D16770", VA = "0x184D17F70")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool BFLEDHPFGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x4D17FD0", Offset = "0x4D167D0", VA = "0x184D17FD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x84B520", Offset = "0x849D20", VA = "0x18084B520")]
		protected BBMOIKJIEHJ(TPromise OMAGKGBNEDE, TMainThreadPromise ONDBBFOGJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4D17F50", Offset = "0x4D16750", VA = "0x184D17F50", Slot = "5")]
		public void DGMMFKFGKCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void AMAFFJDFNON(TPromise OMAGKGBNEDE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class JCMNMNACKAK<T> : BBMOIKJIEHJ<MOJHALOLCAP<T>, DLLABLBIIND<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3F70410", Offset = "0x3F6EC10", VA = "0x183F70410")]
		public JCMNMNACKAK(MOJHALOLCAP<T> OMAGKGBNEDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3F70250", Offset = "0x3F6EA50", VA = "0x183F70250", Slot = "6")]
		protected override void AMAFFJDFNON(MOJHALOLCAP<T> OMAGKGBNEDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2DA0", Offset = "0x3AF15A0", VA = "0x183AF2DA0")]
		[CompilerGenerated]
		private void GIAMHHEJKKN(T KKBKNCNBBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3F703B0", Offset = "0x3F6EBB0", VA = "0x183F703B0")]
		[CompilerGenerated]
		private void LGIILAIDLHF(string EBFMCGAMIGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class HMJHMHGAGAG : BJGBPACOPFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Action BMOCGPMNBAF;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool BFLEDHPFGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
		public HMJHMHGAGAG(Action BMOCGPMNBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8ED750", Offset = "0x8EBF50", VA = "0x1808ED750", Slot = "5")]
		public void DGMMFKFGKCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly List<BJGBPACOPFG> BNGKFMKHDMB;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E230", Offset = "0x2B6CA30", VA = "0x182B6E230")]
	public static MOJHALOLCAP<T> AHCCDHONMAC<T>(this MOJHALOLCAP<T> OMAGKGBNEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x716C200", Offset = "0x716AA00", VA = "0x18716C200")]
	public static void AHCCDHONMAC(Action BMOCGPMNBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E2B0", Offset = "0x2B6CAB0", VA = "0x182B6E2B0")]
	private static MOJHALOLCAP<T> EEMICHELODM<T>(MOJHALOLCAP<T> OMAGKGBNEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x716C580", Offset = "0x716AD80", VA = "0x18716C580")]
	private static void DHMDOEDNINA(BJGBPACOPFG EPIPHJNHEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x716C2A0", Offset = "0x716AAA0", VA = "0x18716C2A0")]
	private static void CLEPDGAMPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x716C780", Offset = "0x716AF80", VA = "0x18716C780")]
	private static void JHMCCBPBFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x716C880", Offset = "0x716B080", VA = "0x18716C880")]
	private static void OCDGCKGNCHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class FCCICGBKDIN
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct HMGKLGOKNOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TaskCompletionSource<Scene> KLOJGIBKNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly string PNDDKBGNFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly LoadSceneMode DMPIELBBOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool NIPFJCKOIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7166680", Offset = "0x7164E80", VA = "0x187166680")]
		public HMGKLGOKNOH(TaskCompletionSource<Scene> KCOFFNCLPOP, string PNDDKBGNFCM, LoadSceneMode DMPIELBBOGG, bool NIPFJCKOIMK, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct HDMIOKIGGKI : IAsyncStateMachine
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
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private NLBODGALKPJ<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x7165530", Offset = "0x7163D30", VA = "0x187165530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7165DD0", Offset = "0x71645D0", VA = "0x187165DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct LPMDHKAAAMA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x716BC90", Offset = "0x716A490", VA = "0x18716BC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x716BFA0", Offset = "0x716A7A0", VA = "0x18716BFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct ANIPICKFNOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private HMGKLGOKNOH <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7156D00", Offset = "0x7155500", VA = "0x187156D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x71570B0", Offset = "0x71558B0", VA = "0x1871570B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class MIFEBJKBLDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public DLLABLBIIND<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public MIFEBJKBLDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x716C9E0", Offset = "0x716B1E0", VA = "0x18716C9E0")]
		internal void LCCCGMIGMGP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct DICDCLIPDKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

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
		private MIFEBJKBLDN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x715D9D0", Offset = "0x715C1D0", VA = "0x18715D9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x715E570", Offset = "0x715CD70", VA = "0x18715E570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct KHAEHFAAEJE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7168E80", Offset = "0x7167680", VA = "0x187168E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7169350", Offset = "0x7167B50", VA = "0x187169350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct DEEONGMOBHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public NLBODGALKPJ<string>.EICLBAKIMEK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private NLBODGALKPJ<string>.EICLBAKIMEK <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x715CD90", Offset = "0x715B590", VA = "0x18715CD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x715D8E0", Offset = "0x715C0E0", VA = "0x18715D8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ENLMFJKIFJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public ENLMFJKIFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x715ED20", Offset = "0x715D520", VA = "0x18715ED20")]
		internal bool NHNJPFLJMPH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class MMPPOCBCFMI : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public EJKPJGCLKPC onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public MMPPOCBCFMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x716ECE0", Offset = "0x716D4E0", VA = "0x18716ECE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x716E910", Offset = "0x716D110", VA = "0x18716E910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x716EC40", Offset = "0x716D440", VA = "0x18716EC40")]
		private void OLLLOCKLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x716EC90", Offset = "0x716D490", VA = "0x18716EC90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class OBONJEEFOFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public DLLABLBIIND<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OBONJEEFOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x716FAB0", Offset = "0x716E2B0", VA = "0x18716FAB0")]
		internal bool DKFOKIILEHA(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x716F850", Offset = "0x716E050", VA = "0x18716F850")]
		internal void AAKOLMKFGON(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class GBACIOGMJDJ : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public DLLABLBIIND<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private OBONJEEFOFJ <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public GBACIOGMJDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7163E10", Offset = "0x7162610", VA = "0x187163E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7164470", Offset = "0x7162C70", VA = "0x187164470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly ICollection<string> FMFNOBAJBGK;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static JHMBDMCOPKA FDNMOCNODGC;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static AsyncOperation NGMKHPKDBNE;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static JHMBDMCOPKA HFKOIOOLMHC;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static string DDFHJEGFBJL;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static ThreadPriority OAKJFOPOIGI;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task JKBHDOKGLFP;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static List<SceneInstance> LCNIOFBOMAB;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly Queue<HMGKLGOKNOH> CLMLODJJDDL;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static Task PLHOEPFNCLC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool KGLPJJIMONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x71605C0", Offset = "0x715EDC0", VA = "0x1871605C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool ECMDEAJJHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7160CC0", Offset = "0x715F4C0", VA = "0x187160CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool BGPLBIKFMMA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7160920", Offset = "0x715F120", VA = "0x187160920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool KGLGJFPMBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7160C30", Offset = "0x715F430", VA = "0x187160C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> EBBHJONKMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x715F8A0", Offset = "0x715E0A0", VA = "0x18715F8A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x715F670", Offset = "0x715DE70", VA = "0x18715F670")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x715F9B0", Offset = "0x715E1B0", VA = "0x18715F9B0")]
	[INMEJIONDCD(CMKKDCGCGFP.EnteredEditModeNextFrame, 0)]
	private static void DLPMKBHGAOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x71607D0", Offset = "0x715EFD0", VA = "0x1871607D0")]
	[AsyncStateMachine(typeof(HDMIOKIGGKI))]
	public static Task<Scene> IHNKCAJHBFE(string PNDDKBGNFCM, LoadSceneMode DMPIELBBOGG = LoadSceneMode.Single, bool NIPFJCKOIMK = false, [Optional] NLBODGALKPJ<string>.EICLBAKIMEK IFANLIPJIHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x715FAA0", Offset = "0x715E2A0", VA = "0x18715FAA0")]
	[AsyncStateMachine(typeof(LPMDHKAAAMA))]
	private static Task EANACJICJII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7160AD0", Offset = "0x715F2D0", VA = "0x187160AD0")]
	[AsyncStateMachine(typeof(ANIPICKFNOM))]
	private static Task JOKHONAPNKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x715FC60", Offset = "0x715E460", VA = "0x18715FC60")]
	[AsyncStateMachine(typeof(DICDCLIPDKF))]
	private static Task<Scene> FFDEKLLFNML(string PNDDKBGNFCM, LoadSceneMode DMPIELBBOGG, bool NIPFJCKOIMK, NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x71609C0", Offset = "0x715F1C0", VA = "0x1871609C0")]
	private static void JOGHAFKJLDM(SceneInstance OFKHAJDAKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x715FDB0", Offset = "0x715E5B0", VA = "0x18715FDB0")]
	private static void FHEMIJAIEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x715F780", Offset = "0x715DF80", VA = "0x18715F780")]
	[AsyncStateMachine(typeof(KHAEHFAAEJE))]
	private static Task<Scene> AGGOELFKKKJ(string PNDDKBGNFCM, LoadSceneMode DMPIELBBOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7160D60", Offset = "0x715F560", VA = "0x187160D60")]
	private static bool PCJDNMBAHNP(string PNDDKBGNFCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x715FB50", Offset = "0x715E350", VA = "0x18715FB50")]
	[AsyncStateMachine(typeof(DEEONGMOBHP))]
	private static Task<Scene> EBCNGMAJDJJ(NLBODGALKPJ<string>.EICLBAKIMEK NOIGIPIHOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x715FFB0", Offset = "0x715E7B0", VA = "0x18715FFB0")]
	public static MOJHALOLCAP<Scene> FJGHNLKPOJI(string PNDDKBGNFCM, LoadSceneMode DMPIELBBOGG = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7160130", Offset = "0x715E930", VA = "0x187160130")]
	public static JHMBDMCOPKA FMMFBNOELFB(string PNDDKBGNFCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7160BA0", Offset = "0x715F3A0", VA = "0x187160BA0")]
	[IteratorStateMachine(typeof(MMPPOCBCFMI))]
	private static IEnumerator<PENLHNEFADH> MEKEPMOJEBN(string PNDDKBGNFCM, EJKPJGCLKPC ABLIPKLLKFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7160520", Offset = "0x715ED20", VA = "0x187160520")]
	[IteratorStateMachine(typeof(GBACIOGMJDJ))]
	private static IEnumerator<PENLHNEFADH> GLLMPNLCMEP(string PNDDKBGNFCM, LoadSceneMode DMPIELBBOGG, DLLABLBIIND<Scene> ABLIPKLLKFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x71603F0", Offset = "0x715EBF0", VA = "0x1871603F0")]
	public static bool GGIPAJEKKPA([Out] string MLLCNKCMEIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class ABNAIFBJHKI
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x71569B0", Offset = "0x71551B0", VA = "0x1871569B0")]
	public static IDisposable DIAMAJDCEGP(this FGKPNLPNGDC BHFMOMNKABO, float AOMJHOEFBOP, Action<float> ECAMNNMLFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7156A40", Offset = "0x7155240", VA = "0x187156A40")]
	public static IDisposable DNOIEFHDLNJ(this FGKPNLPNGDC BHFMOMNKABO, Action<float> ECAMNNMLFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7156930", Offset = "0x7155130", VA = "0x187156930")]
	public static IDisposable DDMAOANGBLB(this FGKPNLPNGDC BHFMOMNKABO, Action<float> ECAMNNMLFFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class GNEEGJLPNCM
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7165250", Offset = "0x7163A50", VA = "0x187165250")]
	public static IDisposable PLGDJHEHMDF(this MonoBehaviour AHGNGLJMDLI, Action ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x71651C0", Offset = "0x71639C0", VA = "0x1871651C0")]
	public static IDisposable PLGDJHEHMDF(this MonoBehaviour AHGNGLJMDLI, Action<float> ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7164AF0", Offset = "0x71632F0", VA = "0x187164AF0")]
	public static IDisposable EAHBMFPNBAD(this MonoBehaviour AHGNGLJMDLI, Action ECAMNNMLFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7164FA0", Offset = "0x71637A0", VA = "0x187164FA0")]
	public static IDisposable NJNAEBHHHEA(this MonoBehaviour AHGNGLJMDLI, Action ECAMNNMLFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7164F20", Offset = "0x7163720", VA = "0x187164F20")]
	public static IDisposable NJNAEBHHHEA(this MonoBehaviour AHGNGLJMDLI, Action<float> ECAMNNMLFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7165140", Offset = "0x7163940", VA = "0x187165140")]
	public static IDisposable OJHFIAAGFPJ(this MonoBehaviour AHGNGLJMDLI, Action ECAMNNMLFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7164920", Offset = "0x7163120", VA = "0x187164920")]
	public static IDisposable CLCNKBINOHE(this MonoBehaviour AHGNGLJMDLI, Action ECAMNNMLFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x71650C0", Offset = "0x71638C0", VA = "0x1871650C0")]
	public static IDisposable OALBPOHFBML(this MonoBehaviour AHGNGLJMDLI, Action ECAMNNMLFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7164B70", Offset = "0x7163370", VA = "0x187164B70")]
	public static IDisposable FDHGHGPPCBP(this MonoBehaviour AHGNGLJMDLI, float AOMJHOEFBOP, Action<float> ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM, bool DPJBFCIDEKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7164CC0", Offset = "0x71634C0", VA = "0x187164CC0")]
	public static IDisposable FPKKJABGGBF(this MonoBehaviour AHGNGLJMDLI, float AOMJHOEFBOP, Action<float> ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM, bool DPJBFCIDEKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7164A50", Offset = "0x7163250", VA = "0x187164A50")]
	public static IDisposable DCLEOEOHBLM(this MonoBehaviour AHGNGLJMDLI, float AOMJHOEFBOP, Action<float> ECAMNNMLFFM, bool DPJBFCIDEKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7164E80", Offset = "0x7163680", VA = "0x187164E80")]
	public static IDisposable LBFKNLAPLFM(this MonoBehaviour AHGNGLJMDLI, Action<float> ECAMNNMLFFM, bool DPJBFCIDEKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7164740", Offset = "0x7162F40", VA = "0x187164740")]
	public static IDisposable BBHHGODFCJC(this MonoBehaviour AHGNGLJMDLI, Action<float> ECAMNNMLFFM, bool DPJBFCIDEKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7164C20", Offset = "0x7163420", VA = "0x187164C20")]
	public static IDisposable FFEHGEEPAKN(this MonoBehaviour AHGNGLJMDLI, Action<float> ECAMNNMLFFM, bool DPJBFCIDEKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7164DE0", Offset = "0x71635E0", VA = "0x187164DE0")]
	public static IDisposable KEPPADPELMA(this MonoBehaviour AHGNGLJMDLI, Action<float> ECAMNNMLFFM, bool DPJBFCIDEKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7164880", Offset = "0x7163080", VA = "0x187164880")]
	public static IDisposable CJLJOKJEEBO(this MonoBehaviour AHGNGLJMDLI, Action<float> ECAMNNMLFFM, bool DPJBFCIDEKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7165020", Offset = "0x7163820", VA = "0x187165020")]
	public static IDisposable NPFEIAKIEOB(this MonoBehaviour AHGNGLJMDLI, Action<float> ECAMNNMLFFM, bool DPJBFCIDEKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x71647E0", Offset = "0x7162FE0", VA = "0x1871647E0")]
	public static IDisposable BFLOKLPAJKE(this MonoBehaviour AHGNGLJMDLI, Action<float> ECAMNNMLFFM, bool DPJBFCIDEKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x71649A0", Offset = "0x71631A0", VA = "0x1871649A0")]
	public static IDisposable CNBKGLKJPMA(this MonoBehaviour AHGNGLJMDLI, float AOMJHOEFBOP, Action<float> ECAMNNMLFFM, bool DPJBFCIDEKO = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class IPGOCOCAKNN
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class EKADOAIOFPM : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public FINOBCNAJBC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private ANHECCDCBDF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public EKADOAIOFPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x715EBB0", Offset = "0x715D3B0", VA = "0x18715EBB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x715EC90", Offset = "0x715D490", VA = "0x18715EC90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class GJNIKIJBAFK : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public FINOBCNAJBC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private ANHECCDCBDF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public GJNIKIJBAFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x71644C0", Offset = "0x7162CC0", VA = "0x1871644C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x71645B0", Offset = "0x7162DB0", VA = "0x1871645B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7167250", Offset = "0x7165A50", VA = "0x187167250")]
	public static JLAFAKOGFMB PLGDJHEHMDF(Action ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7167070", Offset = "0x7165870", VA = "0x187167070")]
	public static JLAFAKOGFMB PLGDJHEHMDF(Behaviour BHFMOMNKABO, Action ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7167130", Offset = "0x7165930", VA = "0x187167130")]
	public static JLAFAKOGFMB PLGDJHEHMDF(Behaviour BHFMOMNKABO, Action<float> ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7166FE0", Offset = "0x71657E0", VA = "0x187166FE0")]
	[IteratorStateMachine(typeof(EKADOAIOFPM))]
	private static IEnumerator<PENLHNEFADH> ELKAOMPJEML(FINOBCNAJBC MILNHPNIAFO, Action ECAMNNMLFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7166F50", Offset = "0x7165750", VA = "0x187166F50")]
	[IteratorStateMachine(typeof(GJNIKIJBAFK))]
	private static IEnumerator<PENLHNEFADH> ELKAOMPJEML(FINOBCNAJBC MILNHPNIAFO, Action<float> ECAMNNMLFFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class MKFGBHADLKG : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class MEIDCJOIDBP : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public MKFGBHADLKG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public MEIDCJOIDBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x716C120", Offset = "0x716A920", VA = "0x18716C120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x716C1B0", Offset = "0x716A9B0", VA = "0x18716C1B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly FINOBCNAJBC LALGNGECBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Action JBPMDNAJJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool LHBHNKHCPFN;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EENFPKNMENE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8472B0", Offset = "0x845AB0", VA = "0x1808472B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x716CD40", Offset = "0x716B540", VA = "0x18716CD40")]
	public MKFGBHADLKG(FINOBCNAJBC LALGNGECBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x716CC20", Offset = "0x716B420", VA = "0x18716CC20")]
	[IteratorStateMachine(typeof(MEIDCJOIDBP))]
	private IEnumerator<PENLHNEFADH> IKMKNEHFFPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x716CCA0", Offset = "0x716B4A0", VA = "0x18716CCA0", Slot = "4")]
	public void OnCompleted(Action KECCIBAPIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	public void BCJMMDGDKOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class GMPPHDMINOA
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7164600", Offset = "0x7162E00", VA = "0x187164600")]
	public static MKFGBHADLKG GBAOEGHLCNE(this FINOBCNAJBC LALGNGECBIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class PLELPBPPMKE
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class HGKBJGDGBGC : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public KONCMEDEEGD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public HGKBJGDGBGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7165E40", Offset = "0x7164640", VA = "0x187165E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7165EC0", Offset = "0x71646C0", VA = "0x187165EC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7171810", Offset = "0x7170010", VA = "0x187171810")]
	public static JLAFAKOGFMB PLGDJHEHMDF(float AOMJHOEFBOP, Action<float> ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM, bool DPJBFCIDEKO = true, [Optional] IHPBHHKIGBI IMFFMIBIOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7171910", Offset = "0x7170110", VA = "0x187171910")]
	public static JLAFAKOGFMB PLGDJHEHMDF(MonoBehaviour AHGNGLJMDLI, float AOMJHOEFBOP, Action<float> ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM, bool DPJBFCIDEKO = true, [Optional] IHPBHHKIGBI IMFFMIBIOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x71716F0", Offset = "0x716FEF0", VA = "0x1871716F0")]
	public static JLAFAKOGFMB NDLENICBGAA(MonoBehaviour AHGNGLJMDLI, float AOMJHOEFBOP, Action<float> ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM, bool DPJBFCIDEKO = true, [Optional] IHPBHHKIGBI IMFFMIBIOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7171430", Offset = "0x716FC30", VA = "0x187171430")]
	public static JLAFAKOGFMB EDFNEFLLKGD(FGKPNLPNGDC BHFMOMNKABO, float AOMJHOEFBOP, Action<float> ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM, bool DPJBFCIDEKO = true, [Optional] IHPBHHKIGBI IMFFMIBIOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x71715A0", Offset = "0x716FDA0", VA = "0x1871715A0")]
	private static IEnumerator<PENLHNEFADH> ELKAOMPJEML(IKKOHKBPELA OKNKELFKHEI, float AOMJHOEFBOP, FINOBCNAJBC MILNHPNIAFO, Action<float> ECAMNNMLFFM, bool DPJBFCIDEKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7171540", Offset = "0x716FD40", VA = "0x187171540")]
	private static IEnumerator<PENLHNEFADH> EFNLGABJCBJ(IKKOHKBPELA OKNKELFKHEI, float AOMJHOEFBOP, FINOBCNAJBC MILNHPNIAFO, Action<float> ECAMNNMLFFM, bool DPJBFCIDEKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7171660", Offset = "0x716FE60", VA = "0x187171660")]
	[IteratorStateMachine(typeof(HGKBJGDGBGC))]
	private static IEnumerator<PENLHNEFADH> FLPDFPEDJFM(KONCMEDEEGD EJIEADLLJFL, float AOMJHOEFBOP, FINOBCNAJBC MILNHPNIAFO, Action<float> ECAMNNMLFFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class JPNJKOOFGDL
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class MMGGJCPEMIM : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public FINOBCNAJBC queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public MMGGJCPEMIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x716E800", Offset = "0x716D000", VA = "0x18716E800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x716E8C0", Offset = "0x716D0C0", VA = "0x18716E8C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7168AF0", Offset = "0x71672F0", VA = "0x187168AF0")]
	[IteratorStateMachine(typeof(MMGGJCPEMIM))]
	private static IEnumerator<PENLHNEFADH> APMJPDEIGJB(FINOBCNAJBC LALGNGECBIM, Func<bool> BKKMFFLBGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7168B80", Offset = "0x7167380", VA = "0x187168B80")]
	public static JLAFAKOGFMB CEIPEBPMIDH(this MonoBehaviour AHGNGLJMDLI, Func<bool> BKKMFFLBGND, FINOBCNAJBC LALGNGECBIM = FINOBCNAJBC.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class PKJMNDHGEMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class LCADJNNDMKO : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public FINOBCNAJBC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public LCADJNNDMKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x716B030", Offset = "0x7169830", VA = "0x18716B030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x716B0A0", Offset = "0x71698A0", VA = "0x18716B0A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class OCCCOKJOIMN : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public FINOBCNAJBC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private PENLHNEFADH <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public OCCCOKJOIMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x716FB30", Offset = "0x716E330", VA = "0x18716FB30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x716FBC0", Offset = "0x716E3C0", VA = "0x18716FBC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7170F30", Offset = "0x716F730", VA = "0x187170F30")]
	[IteratorStateMachine(typeof(LCADJNNDMKO))]
	private static IEnumerator<PENLHNEFADH> IKMKNEHFFPP(float JCJNKLHAGJK, FINOBCNAJBC MILNHPNIAFO, Action CPDLACEKNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7171270", Offset = "0x716FA70", VA = "0x187171270")]
	[IteratorStateMachine(typeof(OCCCOKJOIMN))]
	private static IEnumerator<PENLHNEFADH> NJLACPIHECA(float JCJNKLHAGJK, FINOBCNAJBC MILNHPNIAFO, Action CPDLACEKNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7170C40", Offset = "0x716F440", VA = "0x187170C40")]
	public static IDisposable AKPIFLHGMHN(this MonoBehaviour AHGNGLJMDLI, float JCJNKLHAGJK, Action CPDLACEKNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x71710E0", Offset = "0x716F8E0", VA = "0x1871710E0")]
	public static JLAFAKOGFMB LOCMIMNCODP(this MonoBehaviour AHGNGLJMDLI, float JCJNKLHAGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7170B10", Offset = "0x716F310", VA = "0x187170B10")]
	public static JLAFAKOGFMB AKPIFLHGMHN(this MonoBehaviour AHGNGLJMDLI, float JCJNKLHAGJK, FINOBCNAJBC MILNHPNIAFO, Action CPDLACEKNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7171310", Offset = "0x716FB10", VA = "0x187171310")]
	public static JLAFAKOGFMB OCFAIEANECJ(this MonoBehaviour AHGNGLJMDLI, Action CPDLACEKNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7171400", Offset = "0x716FC00", VA = "0x187171400")]
	public static JLAFAKOGFMB PONJMACNNPA(this MonoBehaviour AHGNGLJMDLI, Action CPDLACEKNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7171000", Offset = "0x716F800", VA = "0x187171000")]
	public static JLAFAKOGFMB LHGCBNCNONO(this MonoBehaviour AHGNGLJMDLI, Action CPDLACEKNJL, [Optional] IHPBHHKIGBI IMFFMIBIOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7170FD0", Offset = "0x716F7D0", VA = "0x187170FD0")]
	public static JLAFAKOGFMB KMDBMFPDDPD(this MonoBehaviour AHGNGLJMDLI, Action CPDLACEKNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7170D60", Offset = "0x716F560", VA = "0x187170D60")]
	public static JLAFAKOGFMB APBBDDKOCCB(this MonoBehaviour AHGNGLJMDLI, Action CPDLACEKNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x71711A0", Offset = "0x716F9A0", VA = "0x1871711A0")]
	private static JLAFAKOGFMB NGBHDICNPCB(MonoBehaviour AHGNGLJMDLI, FINOBCNAJBC LALGNGECBIM, Action CPDLACEKNJL, [Optional] IHPBHHKIGBI IMFFMIBIOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7170E60", Offset = "0x716F660", VA = "0x187170E60")]
	public static JLAFAKOGFMB DFAKFGJBNGM(this MonoBehaviour AHGNGLJMDLI, float PKBBJIPBDHG, Action CPDLACEKNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7171330", Offset = "0x716FB30", VA = "0x187171330")]
	public static JLAFAKOGFMB OFCKAFNLLEK(this MonoBehaviour AHGNGLJMDLI, float PKBBJIPBDHG, Action CPDLACEKNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7170D90", Offset = "0x716F590", VA = "0x187170D90")]
	public static JLAFAKOGFMB BNIEOHPKBIK(this MonoBehaviour AHGNGLJMDLI, float PKBBJIPBDHG, Action CPDLACEKNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7170A40", Offset = "0x716F240", VA = "0x187170A40")]
	public static JLAFAKOGFMB AFHOOEGFAHI(this MonoBehaviour AHGNGLJMDLI, float PKBBJIPBDHG, Action CPDLACEKNJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FABECJLIHPF : MMPKELOKLGP, IEnumerable<MMPKELOKLGP>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly List<MMPKELOKLGP> KKOJDHLOBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool GJCOFAFFPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Action HAAFNCCFDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool BMFMGALDOCK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CDGAEOGAHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x715F190", Offset = "0x715D990", VA = "0x18715F190", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NDMHKCPCGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x715F0F0", Offset = "0x715D8F0", VA = "0x18715F0F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x715ED50", Offset = "0x715D550", VA = "0x18715ED50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x715F5D0", Offset = "0x715DDD0", VA = "0x18715F5D0")]
	public FABECJLIHPF([Optional] Action HAAFNCCFDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x715EDF0", Offset = "0x715D5F0", VA = "0x18715EDF0")]
	public void CNLMKNIMMKA(MMPKELOKLGP FLKAJFKKEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x715EFA0", Offset = "0x715D7A0", VA = "0x18715EFA0")]
	private void JDFNJJKCHFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x715F2C0", Offset = "0x715DAC0", VA = "0x18715F2C0", Slot = "7")]
	public bool NALNCGGJKEP(bool AIDFLNGPPBP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x715F2D0", Offset = "0x715DAD0", VA = "0x18715F2D0", Slot = "8")]
	public bool NALNCGGJKEP(Action BMOCGPMNBAF, bool AIDFLNGPPBP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x715EF20", Offset = "0x715D720", VA = "0x18715EF20", Slot = "9")]
	public IEnumerator<MMPKELOKLGP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x715EF20", Offset = "0x715D720", VA = "0x18715EF20", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class FIGEHBIHCJO : KJEJCPFOODN
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class GOOBBNMLKMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FIGEHBIHCJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public GOOBBNMLKMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x71654C0", Offset = "0x7163CC0", VA = "0x1871654C0")]
		internal void HNGIOJOLOKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class NLKKCCAEAIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public FIGEHBIHCJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public NLKKCCAEAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x71654C0", Offset = "0x7163CC0", VA = "0x1871654C0")]
		internal void LPODPLHBMCL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly float MICKBCBEPEA;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7156B00", Offset = "0x7155300", VA = "0x187156B00")]
	public FIGEHBIHCJO(Behaviour BHFMOMNKABO, float MICKBCBEPEA, [Optional] Action HAAFNCCFDAN, [Optional] IHPBHHKIGBI IMFFMIBIOBG, [Optional] IKKOHKBPELA OKNKELFKHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7161070", Offset = "0x715F870", VA = "0x187161070", Slot = "9")]
	protected override bool HPGFIOJPMFP(Action BMOCGPMNBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7161180", Offset = "0x715F980", VA = "0x187161180", Slot = "10")]
	protected override bool KNPJOFNPBEF(Action BMOCGPMNBAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface MMPKELOKLGP
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool CDGAEOGAHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NDMHKCPCGNN;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NALNCGGJKEP(bool AIDFLNGPPBP = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NALNCGGJKEP(Action BMOCGPMNBAF, bool AIDFLNGPPBP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class KJEJCPFOODN : MMPKELOKLGP
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class LMOJKCHICEA : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public KJEJCPFOODN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public LMOJKCHICEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x716B2D0", Offset = "0x7169AD0", VA = "0x18716B2D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x716B3A0", Offset = "0x7169BA0", VA = "0x18716B3A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Behaviour BHFMOMNKABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action HAAFNCCFDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private PEJDBLFKJJN AOGMFHJMPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly IHPBHHKIGBI IMFFMIBIOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	protected readonly IKKOHKBPELA OKNKELFKHEI;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool CDGAEOGAHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x10BF8E0", Offset = "0x10BE0E0", VA = "0x1810BF8E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NDMHKCPCGNN
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7169810", Offset = "0x7168010", VA = "0x187169810", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7169440", Offset = "0x7167C40", VA = "0x187169440", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7169970", Offset = "0x7168170", VA = "0x187169970")]
	protected KJEJCPFOODN(Behaviour BHFMOMNKABO, [Optional] Action HAAFNCCFDAN, [Optional] IHPBHHKIGBI IMFFMIBIOBG, [Optional] IKKOHKBPELA OKNKELFKHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x71698B0", Offset = "0x71680B0", VA = "0x1871698B0", Slot = "7")]
	public bool NALNCGGJKEP(bool AIDFLNGPPBP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7169910", Offset = "0x7168110", VA = "0x187169910", Slot = "8")]
	public bool NALNCGGJKEP(Action BMOCGPMNBAF, bool AIDFLNGPPBP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool HPGFIOJPMFP(Action BMOCGPMNBAF);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool KNPJOFNPBEF(Action BMOCGPMNBAF);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x71697B0", Offset = "0x7167FB0", VA = "0x1871697B0")]
	protected void IGGPCFPGBKA(Action BMOCGPMNBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x71694E0", Offset = "0x7167CE0", VA = "0x1871694E0")]
	protected JHMBDMCOPKA CGOBFMOPFII(float EKBDOJGAIJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x71693C0", Offset = "0x7167BC0", VA = "0x1871693C0")]
	private void ALFJKKLABOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7169720", Offset = "0x7167F20", VA = "0x187169720")]
	[IteratorStateMachine(typeof(LMOJKCHICEA))]
	private IEnumerator<PENLHNEFADH> HJKFMDEAFED(float EKBDOJGAIJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x71697D0", Offset = "0x7167FD0", VA = "0x1871697D0")]
	[CompilerGenerated]
	private void IOJMIBMJHCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class PIIKIFGIDCK : KJEJCPFOODN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float PIECHLBBBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly int MEEFEABFOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float FFPMBAPHKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly float[] FECABDGHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int HHHONJGOOFJ;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x71708A0", Offset = "0x716F0A0", VA = "0x1871708A0")]
	public PIIKIFGIDCK(Behaviour BHFMOMNKABO, float NAHGKBFMJGL, int MEEFEABFOOK, [Optional] Action HAAFNCCFDAN, float FFPMBAPHKKA = 0f, [Optional] IHPBHHKIGBI IMFFMIBIOBG, [Optional] IKKOHKBPELA OKNKELFKHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "9")]
	protected override bool HPGFIOJPMFP(Action BMOCGPMNBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7170620", Offset = "0x716EE20", VA = "0x187170620", Slot = "10")]
	protected override bool KNPJOFNPBEF(Action BMOCGPMNBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7170820", Offset = "0x716F020", VA = "0x187170820")]
	private void OBHALEHDOMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class AEKLBNLDFCK : KJEJCPFOODN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly float MICKBCBEPEA;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7156B00", Offset = "0x7155300", VA = "0x187156B00")]
	public AEKLBNLDFCK(Behaviour BHFMOMNKABO, float MICKBCBEPEA, [Optional] Action HAAFNCCFDAN, [Optional] IHPBHHKIGBI IMFFMIBIOBG, [Optional] IKKOHKBPELA OKNKELFKHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "9")]
	protected override bool HPGFIOJPMFP(Action BMOCGPMNBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7156AC0", Offset = "0x71552C0", VA = "0x187156AC0", Slot = "10")]
	protected override bool KNPJOFNPBEF(Action BMOCGPMNBAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class HIHAFPGABID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class NDFLFMIJFML : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public NDFLFMIJFML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x716ED70", Offset = "0x716D570", VA = "0x18716ED70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x716EDE0", Offset = "0x716D5E0", VA = "0x18716EDE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private JLAFAKOGFMB KKDCEHKIGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private FGKPNLPNGDC BHFMOMNKABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Action<float> KHLOOIFFOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private FINOBCNAJBC LALGNGECBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float AIADEJCCHOF;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x71664A0", Offset = "0x7164CA0", VA = "0x1871664A0")]
	public HIHAFPGABID(FGKPNLPNGDC BHFMOMNKABO, float AOMJHOEFBOP, Action<float> ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7166150", Offset = "0x7164950", VA = "0x187166150")]
	private void IFNEIOEMADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7165F10", Offset = "0x7164710", VA = "0x187165F10")]
	private void DBLIOHEGJAM(string EBFMCGAMIGF, Action MNHKBFMAAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x71660D0", Offset = "0x71648D0", VA = "0x1871660D0")]
	[IteratorStateMachine(typeof(NDFLFMIJFML))]
	private IEnumerator<PENLHNEFADH> HGJFBICPCFB(Action MNHKBFMAAHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7166070", Offset = "0x7164870", VA = "0x187166070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x71662F0", Offset = "0x7164AF0", VA = "0x1871662F0")]
	[CompilerGenerated]
	private void MAOOJIACJGD(string JLOICJBFAKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class KNNLNJCPAEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class OJEMFBGHBIH : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public OJEMFBGHBIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x716ED70", Offset = "0x716D570", VA = "0x18716ED70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x716FEB0", Offset = "0x716E6B0", VA = "0x18716FEB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private JLAFAKOGFMB KKDCEHKIGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private MonoBehaviour AHGNGLJMDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action ECAMNNMLFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Action<float> KHLOOIFFOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private FINOBCNAJBC LALGNGECBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float AIADEJCCHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool DPJBFCIDEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly IHPBHHKIGBI IMFFMIBIOBG;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x716A980", Offset = "0x7169180", VA = "0x18716A980")]
	public KNNLNJCPAEF(MonoBehaviour AHGNGLJMDLI, Action ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM, [Optional] IHPBHHKIGBI IMFFMIBIOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x716AB70", Offset = "0x7169370", VA = "0x18716AB70")]
	public KNNLNJCPAEF(MonoBehaviour AHGNGLJMDLI, Action<float> ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM, [Optional] IHPBHHKIGBI IMFFMIBIOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x716A730", Offset = "0x7168F30", VA = "0x18716A730")]
	public KNNLNJCPAEF(MonoBehaviour AHGNGLJMDLI, float AOMJHOEFBOP, Action<float> ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM, bool DPJBFCIDEKO = true, [Optional] IHPBHHKIGBI IMFFMIBIOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1B8F7E0", Offset = "0x1B8DFE0", VA = "0x181B8F7E0")]
	private KNNLNJCPAEF(IHPBHHKIGBI IMFFMIBIOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x716A2E0", Offset = "0x7168AE0", VA = "0x18716A2E0")]
	internal static KNNLNJCPAEF KCNIHKDPGDA(MonoBehaviour AHGNGLJMDLI, float AOMJHOEFBOP, Action<float> ECAMNNMLFFM, FINOBCNAJBC LALGNGECBIM, bool DPJBFCIDEKO = true, [Optional] IHPBHHKIGBI IMFFMIBIOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x716A5C0", Offset = "0x7168DC0", VA = "0x18716A5C0")]
	private void PLGDJHEHMDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7169CB0", Offset = "0x71684B0", VA = "0x187169CB0")]
	private void FIOLNGPMICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x716A130", Offset = "0x7168930", VA = "0x18716A130")]
	private void IFNEIOEMADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7169EF0", Offset = "0x71686F0", VA = "0x187169EF0")]
	private void GNNPOBHPKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7169B20", Offset = "0x7168320", VA = "0x187169B20")]
	private void DBLIOHEGJAM(string EBFMCGAMIGF, Action MNHKBFMAAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x716A0B0", Offset = "0x71688B0", VA = "0x18716A0B0")]
	[IteratorStateMachine(typeof(OJEMFBGHBIH))]
	private IEnumerator<PENLHNEFADH> HGJFBICPCFB(Action MNHKBFMAAHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7169C50", Offset = "0x7168450", VA = "0x187169C50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x716A4A0", Offset = "0x7168CA0", VA = "0x18716A4A0")]
	[CompilerGenerated]
	private void MDFLCHKKGBH(string JLOICJBFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7169E60", Offset = "0x7168660", VA = "0x187169E60")]
	[CompilerGenerated]
	private void GKNLBNEECBN(string JLOICJBFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x716A410", Offset = "0x7168C10", VA = "0x18716A410")]
	[CompilerGenerated]
	private void KNNFANPFMPL(string JLOICJBFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x716A530", Offset = "0x7168D30", VA = "0x18716A530")]
	[CompilerGenerated]
	private void PFLJFCNKPHJ(string JLOICJBFAKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Flags]
internal enum LEJKBILFOHM : byte
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
internal sealed class KKCOBMEIIDC : IKKOHKBPELA
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float PHLODIIEKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7169A70", Offset = "0x7168270", VA = "0x187169A70", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float BLALBLLCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7169A80", Offset = "0x7168280", VA = "0x187169A80", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double OFLFOFEDBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7169B00", Offset = "0x7168300", VA = "0x187169B00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7169A90", Offset = "0x7168290", VA = "0x187169A90")]
	[ANLGLDAOJJE(ELBANFBEGNE.None)]
	private static void KLKHAMFMIOA(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	[Preserve]
	internal KKCOBMEIIDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface OCCODACIFEO
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOLEDNONEFN(string GCDLMFGKKMH);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAMOPCDHOMB();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal interface PKAECBCLMOO
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool PDCENHLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JMLEGAGJDGB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class CJODBNGMKEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public GANNDKHKLNI JFLCKMDPNCD;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int CFDBFCCMKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x84CEA0", Offset = "0x84B6A0", VA = "0x18084CEA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7158AD0", Offset = "0x71572D0", VA = "0x187158AD0")]
	public static PENLHNEFADH CNOJEPNBEFL(IEnumerator<PENLHNEFADH> PMNGCBMHHEJ, DFLILELCGNM KKMFDNKGMPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7158C30", Offset = "0x7157430", VA = "0x187158C30")]
	public PENLHNEFADH CNOJEPNBEFL(DFLILELCGNM[] BLENJNNOJNK, IEnumerator<PENLHNEFADH>[] EDPDPDAKICH, PENLHNEFADH[] PHKJCIPHKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7158AA0", Offset = "0x71572A0", VA = "0x187158AA0")]
	public void EKMOMHODKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7158E30", Offset = "0x7157630", VA = "0x187158E30")]
	public void FEDHIDIEHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7158CF0", Offset = "0x71574F0", VA = "0x187158CF0")]
	public void DFPDIENAAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7158AA0", Offset = "0x71572A0", VA = "0x187158AA0")]
	public void AKDFKADPALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public CJODBNGMKEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class GANNDKHKLNI
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct CPHIBBPFGIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public CJODBNGMKEN DLBMLPHHDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public FGKPNLPNGDC DPNNEMHDGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public DFLILELCGNM PINNCAELMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<PENLHNEFADH> KFPGHENPMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public PENLHNEFADH GJKIPMPGMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public LEJKBILFOHM KADELJAFECJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct BIBHICKMIAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public FINOBCNAJBC DAFKNJFIOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<CPHIBBPFGIF> EAKJEPDOMKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class NEJJNFLDECC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public DFLILELCGNM promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public GANNDKHKLNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public FGKPNLPNGDC context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public CJODBNGMKEN routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public LEJKBILFOHM coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public PENLHNEFADH currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<PENLHNEFADH> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public NEJJNFLDECC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x716EE30", Offset = "0x716D630", VA = "0x18716EE30")]
		internal void AGNPLCCBEGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class PAKBKHOCDKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CJODBNGMKEN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public GANNDKHKLNI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public PAKBKHOCDKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x71704C0", Offset = "0x716ECC0", VA = "0x1871704C0")]
		internal void OBOEELNKFAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class HBBJLLFAENO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public CJODBNGMKEN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public GANNDKHKLNI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HBBJLLFAENO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x71654F0", Offset = "0x7163CF0", VA = "0x1871654F0")]
		internal void MLBEHFPMOIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class EKGNGGCEKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public CJODBNGMKEN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public GANNDKHKLNI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public EKGNGGCEKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x715ECE0", Offset = "0x715D4E0", VA = "0x18715ECE0")]
		internal void NPBFABEJNNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const LEJKBILFOHM COIGPBNFIJD = LEJKBILFOHM.Cancelled | LEJKBILFOHM.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly FINOBCNAJBC LALGNGECBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] HCMGHKKFGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<LEJKBILFOHM> OGJNPINFGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> HHBPCJKIANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> APOJDFBDJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> BINKOKGEFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> JCDKHKGOHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> IGAHGHPHCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> CHEBCOHHJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private CJODBNGMKEN[] PGAIBJHJOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private DFLILELCGNM[] BLENJNNOJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private FGKPNLPNGDC[] HPINGIMELLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<PENLHNEFADH>[] AGDJPJAHJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private PENLHNEFADH[] PJCOMAKGIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int JNPIOANHALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int MELGOCPNHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int GAPGEKFLOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float ONDJOKJADHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private BHGGMGBDDKD KIAACEENAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle AGFMFICLCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<CJODBNGMKEN> EGDENGGGLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool EJBIMBOGBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> OOKNLHJEADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> CJPPECNPEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool JIEBBDLBGPG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public BIBHICKMIAI[] MOPFHBDDGBC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8B1E20", Offset = "0x8B0620", VA = "0x1808B1E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x71621F0", Offset = "0x71609F0", VA = "0x1871621F0")]
	private static int GIBLJDEAJDI(FINOBCNAJBC LALGNGECBIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x71635F0", Offset = "0x7161DF0", VA = "0x1871635F0")]
	public GANNDKHKLNI(FINOBCNAJBC LALGNGECBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7162220", Offset = "0x7160A20", VA = "0x187162220")]
	private void HIAEOPDKPIJ(int JEAHAJGDAJM, int JGGAHIJAJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7161680", Offset = "0x715FE80", VA = "0x187161680")]
	public void BOFCAOFJFLO(FGKPNLPNGDC BHFMOMNKABO, PENLHNEFADH GPDNLHIGIDO, IEnumerator<PENLHNEFADH> PMNGCBMHHEJ, DFLILELCGNM KKMFDNKGMPB, [Optional] CJODBNGMKEN BHBMICKPOIO, LEJKBILFOHM HCFCPJHEAOL = LEJKBILFOHM.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7162400", Offset = "0x7160C00", VA = "0x187162400")]
	public void HLODEDBNJDD(IEnumerable<CPHIBBPFGIF> FHKIBJEEPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7161800", Offset = "0x7160000", VA = "0x187161800")]
	private CPHIBBPFGIF CFCFNGGNBPB(int AEGDLDKLODB)
	{
		return default(CPHIBBPFGIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7161D50", Offset = "0x7160550", VA = "0x187161D50")]
	private void FDAKGPIPAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A89780", Offset = "0x2A87F80", VA = "0x182A89780")]
	private static void DIIECFEJGJJ<T>(int AEGDLDKLODB, T[] MILNLKNEMGN, int GGKCGCGFHKJ, [Optional] T BNJPGPOAJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A897D0", Offset = "0x2A87FD0", VA = "0x182A897D0")]
	private static void DIIECFEJGJJ<T>(int AEGDLDKLODB, NativeArray<T> MILNLKNEMGN, int GGKCGCGFHKJ, [Optional] T BNJPGPOAJPA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7162640", Offset = "0x7160E40", VA = "0x187162640")]
	private void IOOKJAEGDKF(IEnumerable<CPHIBBPFGIF> FHKIBJEEPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x71613C0", Offset = "0x715FBC0", VA = "0x1871613C0")]
	private void BDEHEDNOEEK(CPHIBBPFGIF NAOGENBGGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7162C20", Offset = "0x7161420", VA = "0x187162C20")]
	private HDNPBGOJOOE NJJOCFKPCJI(int MADDAENDPEM)
	{
		return default(HDNPBGOJOOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7161480", Offset = "0x715FC80", VA = "0x187161480")]
	public void BGNJJHJANLI(float BDJBDOPLEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7161CD0", Offset = "0x71604D0", VA = "0x187161CD0")]
	private void ENAIJDKEJEL(Action NKCCEIKLOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7163570", Offset = "0x7161D70", VA = "0x187163570")]
	private void NKAGAMMCDII(Action NKCCEIKLOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7162E80", Offset = "0x7161680", VA = "0x187162E80")]
	public void NJNDBDNAHEL(float BDJBDOPLEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x71629F0", Offset = "0x71611F0", VA = "0x1871629F0")]
	public void LDBBLMGLBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7161290", Offset = "0x715FA90", VA = "0x187161290")]
	public void AKDFKADPALL(CJODBNGMKEN EJIEADLLJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7162AF0", Offset = "0x71612F0", VA = "0x187162AF0")]
	public void LPEOMHGKHEC(CJODBNGMKEN EJIEADLLJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x71620C0", Offset = "0x71608C0", VA = "0x1871620C0")]
	public void FMMKDNCBBJD(CJODBNGMKEN EJIEADLLJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class AHJPLJDDKPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly AHJPLJDDKPF IJLPDDOKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Action JFBDEHKEHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private bool NIKEPOPPBPF;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public AHJPLJDDKPF(Action JFBDEHKEHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6924740", Offset = "0x6922F40", VA = "0x186924740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface DFLPJIBMFOI<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T JDDKPJKLOJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable OMDLEFEKOEC(UnityEngine.Object BHFMOMNKABO, Action<T> HNNEMBEMGCE);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface MFKHLCMGIEM<T> : DFLPJIBMFOI<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T JDDKPJKLOJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class KOGCKDBKAKF<T> : MFKHLCMGIEM<T>, DFLPJIBMFOI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class KOIJILJCOCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public KOGCKDBKAKF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public DALEBAFJKFJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KOIJILJCOCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x40BC1D0", Offset = "0x40BA9D0", VA = "0x1840BC1D0")]
		internal void DDIKNFIBCOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static GameObject MFKJPMJEMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<DALEBAFJKFJ<UnityEngine.Object, Action<T>>> BIABOIDHIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T PJHADAAEEOK;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T JDDKPJKLOJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F40", Offset = "0x8E1740", VA = "0x1808E2F40", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x40BBB50", Offset = "0x40BA350", VA = "0x1840BBB50", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x40BB3B0", Offset = "0x40B9BB0", VA = "0x1840BB3B0")]
	private static bool CKAMJOJLPNH(T NKCCEIKLOPK, T ICPBHPBDLLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x40BC110", Offset = "0x40BA910", VA = "0x1840BC110")]
	public KOGCKDBKAKF(T GLMGOAHJHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x40BBE80", Offset = "0x40BA680", VA = "0x1840BBE80", Slot = "6")]
	public IDisposable OMDLEFEKOEC(UnityEngine.Object BHFMOMNKABO, Action<T> HNNEMBEMGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x40BB800", Offset = "0x40BA000", VA = "0x1840BB800")]
	private void DDBPHKONDJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal class MAMNBNHOHIA : DHMCHHIAOGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly IHPBHHKIGBI IMFFMIBIOBG;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x716C0B0", Offset = "0x716A8B0", VA = "0x18716C0B0")]
	[ANLGLDAOJJE(ELBANFBEGNE.None)]
	private static void KLKHAMFMIOA(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	[Preserve]
	internal MAMNBNHOHIA([GNKLNMHODGG(null)] IHPBHHKIGBI IMFFMIBIOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x716C000", Offset = "0x716A800", VA = "0x18716C000", Slot = "4")]
	public IDisposable DCLEOEOHBLM(float AOMJHOEFBOP, Action<float> GLJPAFELCNE, bool DPJBFCIDEKO = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class BJMFNOJINLP : JFECFCEJLMO, IHPBHHKIGBI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private GANNDKHKLNI[] BEKIMCDDNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private OCCODACIFEO PNHONLPHMLL;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7158020", Offset = "0x7156820", VA = "0x187158020")]
	[ANLGLDAOJJE(ELBANFBEGNE.None)]
	private static void KLKHAMFMIOA(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7158710", Offset = "0x7156F10", VA = "0x187158710")]
	[Preserve]
	public BJMFNOJINLP([GNKLNMHODGG(null)] GAMAILNACIO IBGMBBDPOJL, [GNKLNMHODGG(null)] IKKOHKBPELA OKNKELFKHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7157AF0", Offset = "0x71562F0", VA = "0x187157AF0", Slot = "16")]
	public override JLAFAKOGFMB BPMIJJBGAKG(FGKPNLPNGDC BHFMOMNKABO, IEnumerator<PENLHNEFADH> MBFAPJBCOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7158360", Offset = "0x7156B60", VA = "0x187158360", Slot = "17")]
	public override void NJEEDNGOJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7157DF0", Offset = "0x71565F0", VA = "0x187157DF0", Slot = "19")]
	public override void JCOPHOFDKAG(FINOBCNAJBC LALGNGECBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7157C80", Offset = "0x7156480", VA = "0x187157C80", Slot = "18")]
	protected override void EAHBMFPNBAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7158110", Offset = "0x7156910", VA = "0x187158110")]
	private GANNDKHKLNI LDOGMFAHNHL(FINOBCNAJBC HKAKMPIMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7158140", Offset = "0x7156940", VA = "0x187158140", Slot = "20")]
	internal override LNLFHDMCCEC NIBNDJBKCHO(IEnumerator<PENLHNEFADH> MBFAPJBCOGD, Behaviour BHFMOMNKABO, DFLILELCGNM KKMFDNKGMPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7158090", Offset = "0x7156890", VA = "0x187158090", Slot = "21")]
	internal override MLBFKHNPMLB LBJFPPNAKAD(FINOBCNAJBC MILNHPNIAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x71585F0", Offset = "0x7156DF0", VA = "0x1871585F0")]
	private void ONBMFHCENEJ(GANNDKHKLNI DKGOHIDNFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7157C20", Offset = "0x7156420", VA = "0x187157C20", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[BurstCompile]
internal struct BHGGMGBDDKD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public float CEGNPAABHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public int ECNGEJFNIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> DGJNBEPEBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> LCFFJDHBGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NativeArray<int> ADNFBAFHBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<LEJKBILFOHM> JHKMGFOCCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[ReadOnly]
	public NativeArray<float> MLMANFHBLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> JCDKHKGOHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[WriteOnly]
	public NativeArray<int> APOJDFBDJDC;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7157590", Offset = "0x7155D90", VA = "0x187157590")]
	public static BHGGMGBDDKD DLNFHNOLCMJ(int MADGOPPHAGD, float BDJBDOPLEGE, NativeArray<LEJKBILFOHM> JBAKFLADNGE, NativeArray<float> FOKLEFGNKHA, NativeArray<int> AFLPHHJILBN, NativeArray<int> NCDEIADDNAB, NativeArray<int> EOKJCIONPIK, NativeArray<int> LCFFJDHBGPF, NativeArray<int> ADNFBAFHBEA)
	{
		return default(BHGGMGBDDKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7157630", Offset = "0x7155E30", VA = "0x187157630", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x71575F0", Offset = "0x7155DF0", VA = "0x1871575F0")]
	private bool EOHJOJKDBNC(int JBDLDJOINOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x71579F0", Offset = "0x71561F0", VA = "0x1871579F0")]
	private void IFKJGJBHJLI(NativeArray<int> EJOKFOGAAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7157710", Offset = "0x7155F10", VA = "0x187157710")]
	private int FDHOPIGGNHH(int HPJCENNGMPN, int NAOAPMFMBDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7157A20", Offset = "0x7156220", VA = "0x187157A20")]
	private void KCGBICFJLNJ(NativeArray<int> EJOKFOGAAII, int EGCIAPAONBC, int KEIFIHHDEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x71577B0", Offset = "0x7155FB0", VA = "0x1871577B0")]
	private void FLOJJLNHDFL(NativeArray<int> EJOKFOGAAII, int KEMFKBLLPCB, int FMKICOCLMIP, int KGNMAINILBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public abstract class JFECFCEJLMO : IHPBHHKIGBI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly GAMAILNACIO IBGMBBDPOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected readonly IKKOHKBPELA OKNKELFKHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private MLBFKHNPMLB[] COGMLKLEFPN;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static IHPBHHKIGBI DCEJKJKKEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7167F30", Offset = "0x7166730", VA = "0x187167F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool ICIDCBOPNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public FINOBCNAJBC DBMEJFPFLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FINOBCNAJBC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x84CEA0", Offset = "0x84B6A0", VA = "0x18084CEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IKKOHKBPELA FNCJCKCOJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public PENLHNEFADH JKAKHPOLDKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7168160", Offset = "0x7166960", VA = "0x187168160")]
	public static JLAFAKOGFMB NLANIMFHCLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7168420", Offset = "0x7166C20", VA = "0x187168420")]
	[Preserve]
	protected JFECFCEJLMO([GNKLNMHODGG(null)] GAMAILNACIO IBGMBBDPOJL, [GNKLNMHODGG(null)] IKKOHKBPELA OKNKELFKHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x71683F0", Offset = "0x7166BF0", VA = "0x1871683F0", Slot = "6")]
	public JLAFAKOGFMB OHLHHBJPLCP(IEnumerator<PENLHNEFADH> MBFAPJBCOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x71681F0", Offset = "0x71669F0", VA = "0x1871681F0", Slot = "7")]
	public JLAFAKOGFMB OHLHHBJPLCP(Behaviour BHFMOMNKABO, IEnumerator<PENLHNEFADH> MBFAPJBCOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract JLAFAKOGFMB BPMIJJBGAKG(FGKPNLPNGDC BHFMOMNKABO, IEnumerator<PENLHNEFADH> MBFAPJBCOGD);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7167FA0", Offset = "0x71667A0", VA = "0x187167FA0", Slot = "17")]
	public virtual void NJEEDNGOJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7167B90", Offset = "0x7166390", VA = "0x187167B90", Slot = "9")]
	public void EHKHHFGANPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7167B10", Offset = "0x7166310", VA = "0x187167B10", Slot = "18")]
	protected virtual void EAHBMFPNBAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7167730", Offset = "0x7165F30", VA = "0x187167730")]
	private void DCJNHGMJAFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7167E80", Offset = "0x7166680", VA = "0x187167E80")]
	private void HLHMHJBKBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7168140", Offset = "0x7166940", VA = "0x187168140")]
	private void NJNAEBHHHEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7168400", Offset = "0x7166C00", VA = "0x187168400")]
	private void OJHFIAAGFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7167F80", Offset = "0x7166780", VA = "0x187167F80")]
	private void KJAKJGOGDPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7167E60", Offset = "0x7166660", VA = "0x187167E60")]
	private void GOGDFAECDIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7167540", Offset = "0x7165D40", VA = "0x187167540")]
	private void CHDLFIHMPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7167EA0", Offset = "0x71666A0", VA = "0x187167EA0", Slot = "19")]
	public virtual void JCOPHOFDKAG(FINOBCNAJBC LALGNGECBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7167560", Offset = "0x7165D60", VA = "0x187167560")]
	private void CJKOMMNLMKL(MLBFKHNPMLB DKGOHIDNFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E39D30", Offset = "0x1E38530", VA = "0x181E39D30")]
	private MLBFKHNPMLB GDEKFFPFHAG(FINOBCNAJBC HKAKMPIMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract LNLFHDMCCEC NIBNDJBKCHO(IEnumerator<PENLHNEFADH> MBFAPJBCOGD, Behaviour AHGNGLJMDLI, DFLILELCGNM FMOKLKBOEOB);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract MLBFKHNPMLB LBJFPPNAKAD(FINOBCNAJBC LALGNGECBIM);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7167750", Offset = "0x7165F50", VA = "0x187167750", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7167B30", Offset = "0x7166330", VA = "0x187167B30", Slot = "12")]
	public PENLHNEFADH EAIPFGAADLH(FINOBCNAJBC MILNHPNIAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7167DD0", Offset = "0x71665D0", VA = "0x187167DD0", Slot = "13")]
	public PENLHNEFADH GFNCEDOBAFP(float JCJNKLHAGJK, FINOBCNAJBC MILNHPNIAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x71674E0", Offset = "0x7165CE0", VA = "0x1871674E0", Slot = "14")]
	public PENLHNEFADH CEKGAABMOGP(Func<bool> BKKMFFLBGND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class LNLFHDMCCEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly DFLILELCGNM KKMFDNKGMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly PKAECBCLMOO BHFMOMNKABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly bool APPJGDEJBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private string GCDLMFGKKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private StackTrace EIKIFKAHNNB;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<PENLHNEFADH> KFPGHENPMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public PENLHNEFADH GJKIPMPGMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x844F20", Offset = "0x843720", VA = "0x180844F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool LFAMHJDHILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x716B900", Offset = "0x716A100", VA = "0x18716B900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool DLOINIGCLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x991980", Offset = "0x990180", VA = "0x180991980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x991AA0", Offset = "0x9902A0", VA = "0x180991AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x716B440", Offset = "0x7169C40", VA = "0x18716B440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float INKFHFPGMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8B20E0", Offset = "0x8B08E0", VA = "0x1808B20E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5E32ED0", Offset = "0x5E316D0", VA = "0x185E32ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x716BAD0", Offset = "0x716A2D0", VA = "0x18716BAD0")]
	public LNLFHDMCCEC(IEnumerator<PENLHNEFADH> PMNGCBMHHEJ, PKAECBCLMOO BHFMOMNKABO, DFLILELCGNM KKMFDNKGMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x716B5F0", Offset = "0x7169DF0", VA = "0x18716B5F0")]
	public PENLHNEFADH CNOJEPNBEFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x716B980", Offset = "0x716A180", VA = "0x18716B980")]
	public bool OEIJKLIGKJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x716B3F0", Offset = "0x7169BF0", VA = "0x18716B3F0")]
	public void AKDFKADPALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x716B9F0", Offset = "0x716A1F0", VA = "0x18716B9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA32B50", Offset = "0xA31350", VA = "0x180A32B50")]
	[CompilerGenerated]
	private void MJBDICILEJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class DFLILELCGNM : LJHPANCFKIM, JLAFAKOGFMB, PEJDBLFKJJN, JHMBDMCOPKA, IEnumerator, PENLHNEFADH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private FINOBCNAJBC OIBGLLIDDEA;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private FINOBCNAJBC FDOAGNCLLNN
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xFCF480", Offset = "0xFCDC80", VA = "0x180FCF480", Slot = "23")]
		get
		{
			return default(FINOBCNAJBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public FINOBCNAJBC JFLCKMDPNCD
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x14FFA00", Offset = "0x14FE200", VA = "0x1814FFA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float KNNGLKFBNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x9DD730", Offset = "0x9DBF30", VA = "0x1809DD730", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool IBHDGPCBJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x715D960", Offset = "0x715C160", VA = "0x18715D960", Slot = "24")]
	private bool HAIIOJJHEFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x715D950", Offset = "0x715C150", VA = "0x18715D950", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x715D980", Offset = "0x715C180", VA = "0x18715D980")]
	public DFLILELCGNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal enum HDNPBGOJOOE : byte
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
internal sealed class MLBFKHNPMLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum HHFLAEGGDNA
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public struct MODFKKNMKCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public FINOBCNAJBC DAFKNJFIOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public HHFLAEGGDNA LAIHCMNHCFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public List<LNLFHDMCCEC> MLDPILMOJHE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly HHFLAEGGDNA[] MOBIDJPDMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly FINOBCNAJBC LALGNGECBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool GKOKEPPCLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly LNLFHDMCCEC[] COFBHBJMPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<LNLFHDMCCEC> GDIPOPFMHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Stack<int> GKLCOBANNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly List<LNLFHDMCCEC> HCFJOMIMACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Stack<int> ENNDGMOPGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly OCCODACIFEO GHPNLEIMIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private bool JIEBBDLBGPG;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public MODFKKNMKCB[,] HBLCFODEFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8473D0", Offset = "0x845BD0", VA = "0x1808473D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x716E370", Offset = "0x716CB70", VA = "0x18716E370")]
	public MLBFKHNPMLB(FINOBCNAJBC MILNHPNIAFO, OCCODACIFEO GHPNLEIMIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x716E130", Offset = "0x716C930", VA = "0x18716E130")]
	public void PMGKFIPFIMC(LNLFHDMCCEC PMNGCBMHHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x716CE50", Offset = "0x716B650", VA = "0x18716CE50")]
	public void CJLBNBEDLNA(IList<LNLFHDMCCEC> EDPDPDAKICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x716DE20", Offset = "0x716C620", VA = "0x18716DE20")]
	public void LCPMBDLMNPE(IList<LNLFHDMCCEC> EDPDPDAKICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x716DD30", Offset = "0x716C530", VA = "0x18716DD30")]
	private void LBGHKDHDKIC(LNLFHDMCCEC PMNGCBMHHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x716D8A0", Offset = "0x716C0A0", VA = "0x18716D8A0")]
	private void IDKIIACPPDP(IList<LNLFHDMCCEC> EDPDPDAKICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x716D720", Offset = "0x716BF20", VA = "0x18716D720")]
	private HDNPBGOJOOE FBBEGEAPFCB(LNLFHDMCCEC PMNGCBMHHEJ)
	{
		return default(HDNPBGOJOOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x716D3C0", Offset = "0x716BBC0", VA = "0x18716D3C0")]
	public void EAHBMFPNBAD(float BDJBDOPLEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x716D530", Offset = "0x716BD30", VA = "0x18716D530")]
	public void EHKHHFGANPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x716DA30", Offset = "0x716C230", VA = "0x18716DA30")]
	private void JBEGKCPINAJ(List<LNLFHDMCCEC> EDPDPDAKICH, Stack<int> FKOBJPPDIIN, bool HACGAJKJNAN, float BOCPLCNBAAP = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x716D2A0", Offset = "0x716BAA0", VA = "0x18716D2A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x716D160", Offset = "0x716B960", VA = "0x18716D160")]
	private void DJPBNHFHLLB(List<LNLFHDMCCEC> EDPDPDAKICH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class COEIDGFNMHA : OCCODACIFEO
{
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "4")]
	public void NOLEDNONEFN(string GCDLMFGKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
	public void BAMOPCDHOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public COEIDGFNMHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal class NGIOOIADLDO : PKAECBCLMOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly Behaviour AHGNGLJMDLI;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x716F5F0", Offset = "0x716DDF0", VA = "0x18716F5F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool PDCENHLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x716F670", Offset = "0x716DE70", VA = "0x18716F670", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool JMLEGAGJDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x716F6C0", Offset = "0x716DEC0", VA = "0x18716F6C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public NGIOOIADLDO(Behaviour AHGNGLJMDLI)
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

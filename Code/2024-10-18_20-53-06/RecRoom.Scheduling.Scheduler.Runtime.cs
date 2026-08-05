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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7752E20", Offset = "0x7752220", VA = "0x187752E20", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
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
		private delegate List<PlayerLoopSystem> CHCDCNMLKBA(List<PlayerLoopSystem> EOKOCJOFACL, int GDDFBKIMIMD);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct JJGGMMOBEDM
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct DNALOELLLJG
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static LDNMACGBDLI CGLDLHFMAEE;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x773FE80", Offset = "0x773F280", VA = "0x18773FE80")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct GGCKFCJAFBD
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static LDNMACGBDLI GBEBBBKLCAG;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x7744020", Offset = "0x7743420", VA = "0x187744020")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct LPGKGELJEIJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static LDNMACGBDLI OGDJDNKIIEM;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x774B240", Offset = "0x774A640", VA = "0x18774B240")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct BHHJNJLCLIB
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static LDNMACGBDLI EPMMPDGDJOB;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static LDNMACGBDLI FBPECONNFPB;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static LDNMACGBDLI NPNKHAKHIPO;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static LDNMACGBDLI IENECLLOAKE;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x7739E30", Offset = "0x7739230", VA = "0x187739E30")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct CMDLFJMGAJO
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static LDNMACGBDLI GIANKEFOFAL;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x773B830", Offset = "0x773AC30", VA = "0x18773B830")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct JKLFGNFENNJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static LDNMACGBDLI EPMMPDGDJOB;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static LDNMACGBDLI FBPECONNFPB;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static LDNMACGBDLI NPNKHAKHIPO;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static LDNMACGBDLI IENECLLOAKE;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x7748F70", Offset = "0x7748370", VA = "0x187748F70")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct DPOBOMOJFKN
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static LDNMACGBDLI HEBOPGFOPAP;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x7740200", Offset = "0x773F600", VA = "0x187740200")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct AKBNMFKIOPK
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static LDNMACGBDLI FNMKGCJPBBP;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x7738290", Offset = "0x7737690", VA = "0x187738290")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct IGFLDILINOI
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static LDNMACGBDLI IHLINOGDNBG;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x7748790", Offset = "0x7747B90", VA = "0x187748790")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct JJMMKOBFAJK
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static LDNMACGBDLI AENDBHFCJHI;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x7748D90", Offset = "0x7748190", VA = "0x187748D90")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct FOHAJGHCGLA
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static LDNMACGBDLI AOLIMFOMNBG;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x7743D90", Offset = "0x7743190", VA = "0x187743D90")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct FLAOBLHIDKI
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static LDNMACGBDLI NLDHHHPLHBD;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x7743B60", Offset = "0x7742F60", VA = "0x187743B60")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct MKBPIHPGHOO
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static LDNMACGBDLI CFHIHICOMLL;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x774DDB0", Offset = "0x774D1B0", VA = "0x18774DDB0")]
				public static PlayerLoopSystem HHANPAHFGPG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum LFOJONGFMBN : byte
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
			public struct OJJKJFIEBAE
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class OHGHFMLLIPM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public LFOJONGFMBN updateStage;

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
					public OHGHFMLLIPM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x7750540", Offset = "0x774F940", VA = "0x187750540")]
					internal void KPPMJKFABOF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static PJFDJKKNHLD<LFOJONGFMBN> JCDDBHIMDCO;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x7750E70", Offset = "0x7750270", VA = "0x187750E70")]
				public static PlayerLoopSystem HHANPAHFGPG(LFOJONGFMBN DGIENIOOFDP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct GPKBNLJGJJM
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class CMNGPGGJHIE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public KLKCEHKDEFK.BMDJFAMPLON key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
					public CMNGPGGJHIE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x773BA10", Offset = "0x773AE10", VA = "0x18773BA10")]
					internal void OPPBHBFDIED()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable MJDOJLDCGCM;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x77477E0", Offset = "0x7746BE0", VA = "0x1877477E0")]
				public static PlayerLoopSystem PDHPEOHLNGJ(KLKCEHKDEFK.BMDJFAMPLON OEOMDKHBDFI)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct LMNNMFBDGML
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class KHIFBIHBFLP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public KLKCEHKDEFK.BMDJFAMPLON key;

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
					public KHIFBIHBFLP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x7749C10", Offset = "0x7749010", VA = "0x187749C10")]
					internal void OPPBHBFDIED()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x774B110", Offset = "0x774A510", VA = "0x18774B110")]
				public static PlayerLoopSystem PDHPEOHLNGJ(KLKCEHKDEFK.BMDJFAMPLON OEOMDKHBDFI)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class DJEONGJLOLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public DJEONGJLOLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x773FD20", Offset = "0x773F120", VA = "0x18773FD20")]
			internal List<PlayerLoopSystem> KKPODPPLKPJ(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool JOBHHMOKDAD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool CGPMIJBFBOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x773CDC0", Offset = "0x773C1C0", VA = "0x18773CDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x773CE00", Offset = "0x773C200", VA = "0x18773CE00")]
		private static void LKDEIDADCKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x773C4B0", Offset = "0x773B8B0", VA = "0x18773C4B0")]
		private static void FOCHPDBEDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x773BC90", Offset = "0x773B090", VA = "0x18773BC90")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x773BE90", Offset = "0x773B290", VA = "0x18773BE90")]
		private static void DAKHLLCCMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x773BCD0", Offset = "0x773B0D0", VA = "0x18773BCD0")]
		private static void BAMJGDCLLAI(KLKCEHKDEFK.BMDJFAMPLON OEOMDKHBDFI, PlayerLoopSystem HBECPMDEDEK, Type GJCIGDIFIFF, Type BFPNLIENLLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x773C0D0", Offset = "0x773B4D0", VA = "0x18773C0D0")]
		private static void DPGCABPCAPH(PlayerLoopSystem HBECPMDEDEK, Type GJCIGDIFIFF, Type BFPNLIENLLA, CHCDCNMLKBA BAMDHGDMHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x773F950", Offset = "0x773ED50", VA = "0x18773F950")]
		private static void LOEDKABMMMH(PlayerLoopSystem HBECPMDEDEK, Type GJCIGDIFIFF, Type BFPNLIENLLA, PlayerLoopSystem? MEPMNIFAJPA, PlayerLoopSystem? PFIKBBIMPEM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class KLKCEHKDEFK
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum BMDJFAMPLON
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
	public class JNGLKENGOKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly BMDJFAMPLON AELHAEDNDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly DAOEGBMECBF DGEBDOOCCPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long KLNEMNNOFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long ALCOMJADAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long HNDGGALNEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int CFODEELCBNH;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x77495C0", Offset = "0x77489C0", VA = "0x1877495C0")]
		public JNGLKENGOKN(BMDJFAMPLON JCLDKOMBGMP, int LAMPNNNDBKE = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7749550", Offset = "0x7748950", VA = "0x187749550")]
		public void OJHDLDKNIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7749500", Offset = "0x7748900", VA = "0x187749500")]
		public void NCPDFLGAGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7749320", Offset = "0x7748720", VA = "0x187749320")]
		public void GFDNOFMJDGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static BMDJFAMPLON[] PFNCIMINJNE;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static JNGLKENGOKN[] HCHDEIENFPP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7749EC0", Offset = "0x77492C0", VA = "0x187749EC0")]
	public static JNGLKENGOKN FKIJNHPIJEH(BMDJFAMPLON OEOMDKHBDFI, int LAMPNNNDBKE = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x774A140", Offset = "0x7749540", VA = "0x18774A140")]
	public static JNGLKENGOKN PDKKLJINDEE(BMDJFAMPLON OEOMDKHBDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x774A0A0", Offset = "0x77494A0", VA = "0x18774A0A0")]
	public static void LNJGPKNJLDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class DAOEGBMECBF : MOLGPDBBANN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int ILPGNOHEKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> PMOBCFNAIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double DBFICLBOEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double EGCLLCBPEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double OBCAOHDOJKK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double PFMHBLAEGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x773FBA0", Offset = "0x773EFA0", VA = "0x18773FBA0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double DMELAMKPLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5A7CCD0", Offset = "0x5A7C0D0", VA = "0x185A7CCD0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double ILDPLHKNFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x21C5EC0", Offset = "0x21C52C0", VA = "0x1821C5EC0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x773FC70", Offset = "0x773F070", VA = "0x18773FC70")]
	public DAOEGBMECBF(int KHICIPOFKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x773FA80", Offset = "0x773EE80", VA = "0x18773FA80", Slot = "7")]
	public void FAJCBCAJDCA(double OAKJBMEGCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x773FC00", Offset = "0x773F000", VA = "0x18773FC00", Slot = "8")]
	public void PGLAGHNEHAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class FCDFGDHHGMF : MOLGPDBBANN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long HMELIAGANNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double CGKCCAECPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double LAKDDOPBIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double IEPNGGHNBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double FHBDAMDEBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double DBFICLBOEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double EGCLLCBPEBE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double DMELAMKPLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6337C20", Offset = "0x6337020", VA = "0x186337C20", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double ILDPLHKNFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x20BC7F0", Offset = "0x20BBBF0", VA = "0x1820BC7F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double BGKHMPNLHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63380E0", Offset = "0x63374E0", VA = "0x1863380E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double PFMHBLAEGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x27D9FE0", Offset = "0x27D93E0", VA = "0x1827D9FE0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7742760", Offset = "0x7741B60", VA = "0x187742760", Slot = "7")]
	public virtual void FAJCBCAJDCA(double OAKJBMEGCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7742880", Offset = "0x7741C80", VA = "0x187742880", Slot = "8")]
	public virtual void PGLAGHNEHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x77401D0", Offset = "0x773F5D0", VA = "0x1877401D0")]
	public FCDFGDHHGMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DPHDNJINFPO : FCDFGDHHGMF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double IJMBCDHBDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6337C90", Offset = "0x6337090", VA = "0x186337C90")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6337C80", Offset = "0x6337080", VA = "0x186337C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7740060", Offset = "0x773F460", VA = "0x187740060", Slot = "7")]
	public override void FAJCBCAJDCA(double OAKJBMEGCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7740190", Offset = "0x773F590", VA = "0x187740190", Slot = "8")]
	public override void PGLAGHNEHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x77401D0", Offset = "0x773F5D0", VA = "0x1877401D0")]
	public DPHDNJINFPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface MOLGPDBBANN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double PFMHBLAEGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double DMELAMKPLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double ILDPLHKNFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FJEHOANAABK
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface JANANGMCKND
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool EKOCKOFFIII
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HCLIEHAEFCC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class NFKANJAMIOO : JANANGMCKND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Action HJOAJFDFEDM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool EKOCKOFFIII
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
		public NFKANJAMIOO(Action HJOAJFDFEDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xC00F00", Offset = "0xC00300", VA = "0x180C00F00", Slot = "5")]
		public void HCLIEHAEFCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<JANANGMCKND> IEGLOMPPJJF;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7743910", Offset = "0x7742D10", VA = "0x187743910")]
	public static void JAPBJLMMMBH(Action HJOAJFDFEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7743250", Offset = "0x7742650", VA = "0x187743250")]
	private static void FDFFGNOAMJA(JANANGMCKND AJOBFJMENNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7743530", Offset = "0x7742930", VA = "0x187743530")]
	private static void HBNKJELIFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7743810", Offset = "0x7742C10", VA = "0x187743810")]
	private static void IPBKDHCEOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7743460", Offset = "0x7742860", VA = "0x187743460")]
	private static void GNAAEKJLHEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class EDMBDCGNKIM
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct GILPKPIDMIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TaskCompletionSource<Scene> DONGFOEKBKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly string HFGPDDPDFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly LoadSceneMode FGGKEAIICHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly bool MMPGNGKNACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7746BF0", Offset = "0x7745FF0", VA = "0x187746BF0")]
		public GILPKPIDMIM(TaskCompletionSource<Scene> JCMIOIBGHIO, string HFGPDDPDFCO, LoadSceneMode FGGKEAIICHO, bool MMPGNGKNACF, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct NKLBKDHNGCI : IAsyncStateMachine
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
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private OGAFCBAEIIJ<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x774F990", Offset = "0x774ED90", VA = "0x18774F990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7750230", Offset = "0x774F630", VA = "0x187750230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct ONKIGHLDMLD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7751030", Offset = "0x7750430", VA = "0x187751030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7751340", Offset = "0x7750740", VA = "0x187751340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct PLEBBPOBAHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private GILPKPIDMIM <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x77513A0", Offset = "0x77507A0", VA = "0x1877513A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7751760", Offset = "0x7750B60", VA = "0x187751760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class BANNMJGPHPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public PEKLDAEFLGB<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BANNMJGPHPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7738470", Offset = "0x7737870", VA = "0x187738470")]
		internal void NLGJBEPBBPM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct LEADAJLNCKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

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
		private BANNMJGPHPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x774A480", Offset = "0x7749880", VA = "0x18774A480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x774AFE0", Offset = "0x774A3E0", VA = "0x18774AFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct KEPCMGPMHPI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x77496D0", Offset = "0x7748AD0", VA = "0x1877496D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7749BA0", Offset = "0x7748FA0", VA = "0x187749BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct GNBBMIEIKKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7746C50", Offset = "0x7746050", VA = "0x187746C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7747770", Offset = "0x7746B70", VA = "0x187747770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class IGKGFDPHMIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public IGKGFDPHMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7748970", Offset = "0x7747D70", VA = "0x187748970")]
		internal bool JLPBEJGEHPN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class HAONAHJGFHL : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public NEDBBCCLALH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public HAONAHJGFHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7747CF0", Offset = "0x77470F0", VA = "0x187747CF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7747960", Offset = "0x7746D60", VA = "0x187747960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7747910", Offset = "0x7746D10", VA = "0x187747910")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7747CA0", Offset = "0x77470A0", VA = "0x187747CA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class JEGJDDACGJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public PEKLDAEFLGB<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public JEGJDDACGJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x77489A0", Offset = "0x7747DA0", VA = "0x1877489A0")]
		internal bool AIENIEINGGB(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7748A20", Offset = "0x7747E20", VA = "0x187748A20")]
		internal void FGPIFELMACI(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class MICLIFMKGAE : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public PEKLDAEFLGB<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private JEGJDDACGJN <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public MICLIFMKGAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x774C780", Offset = "0x774BB80", VA = "0x18774C780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x774CDE0", Offset = "0x774C1E0", VA = "0x18774CDE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly ICollection<string> PBMCDDBOMOG;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static GELPMBCHBBO FDDAJDBJHBF;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static AsyncOperation NJGLIGAEHLG;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static GELPMBCHBBO KGMLMBFMMIN;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static string CGLGNNHINIP;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static ThreadPriority JGIJPLODKPH;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static Task HLFBMDEJJIG;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static List<SceneInstance> IDFAMOLPNHF;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly Queue<GILPKPIDMIM> GMIKLPKBLPC;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task DFFIJNIGIIH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool CCBMPBBFJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7741390", Offset = "0x7740790", VA = "0x187741390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private static bool DOOPBKNOKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7741A90", Offset = "0x7740E90", VA = "0x187741A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private static bool GFKOKLHOFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7740F40", Offset = "0x7740340", VA = "0x187740F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool GOBCCKJMECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7741B30", Offset = "0x7740F30", VA = "0x187741B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> GHJAKLIAPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7740CE0", Offset = "0x77400E0", VA = "0x187740CE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x77416B0", Offset = "0x7740AB0", VA = "0x1877416B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x77412A0", Offset = "0x77406A0", VA = "0x1877412A0")]
	[AOCOHKCHHOI(HMHKHAIKFEG.EnteredEditModeNextFrame, 0)]
	private static void JCLEGOFIFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7740DF0", Offset = "0x77401F0", VA = "0x187740DF0")]
	[AsyncStateMachine(typeof(NKLBKDHNGCI))]
	public static Task<Scene> GFKCBAJFCBK(string HFGPDDPDFCO, LoadSceneMode FGGKEAIICHO = LoadSceneMode.Single, bool MMPGNGKNACF = false, [Optional] OGAFCBAEIIJ<string>.DDIOHHJLGKB PMKIMANNEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7741940", Offset = "0x7740D40", VA = "0x187741940")]
	[AsyncStateMachine(typeof(ONKIGHLDMLD))]
	private static Task MOJEBGCAFGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7740AE0", Offset = "0x773FEE0", VA = "0x187740AE0")]
	[AsyncStateMachine(typeof(PLEBBPOBAHO))]
	private static Task EEJGACMJDMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7740560", Offset = "0x773F960", VA = "0x187740560")]
	[AsyncStateMachine(typeof(LEADAJLNCKH))]
	private static Task<Scene> ALABGPLODEM(string HFGPDDPDFCO, LoadSceneMode FGGKEAIICHO, bool MMPGNGKNACF, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x77415A0", Offset = "0x77409A0", VA = "0x1877415A0")]
	private static void LGKLMHPPHJP(SceneInstance BHCLGMHGMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x77406B0", Offset = "0x773FAB0", VA = "0x1877406B0")]
	private static void CEIIJOGKFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x77408B0", Offset = "0x773FCB0", VA = "0x1877408B0")]
	[AsyncStateMachine(typeof(KEPCMGPMHPI))]
	private static Task<Scene> DEALPFNDFGA(string HFGPDDPDFCO, LoadSceneMode FGGKEAIICHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x77417C0", Offset = "0x7740BC0", VA = "0x1877417C0")]
	private static bool MBBCFEHPBNM(string HFGPDDPDFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x77409D0", Offset = "0x773FDD0", VA = "0x1877409D0")]
	[AsyncStateMachine(typeof(GNBBMIEIKKN))]
	private static Task<Scene> DKFOCNBEOCM(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x77403E0", Offset = "0x773F7E0", VA = "0x1877403E0")]
	public static MJGAHFINLMO<Scene> AKGJNPEEBMF(string HFGPDDPDFCO, LoadSceneMode FGGKEAIICHO = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7740FE0", Offset = "0x77403E0", VA = "0x187740FE0")]
	public static GELPMBCHBBO JAKPLMGEAHC(string HFGPDDPDFCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x77418B0", Offset = "0x7740CB0", VA = "0x1877418B0")]
	[IteratorStateMachine(typeof(HAONAHJGFHL))]
	private static IEnumerator<DNOIEDKBBPN> MKGPCGMDDBM(string HFGPDDPDFCO, NEDBBCCLALH PONHJFNDGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x77419F0", Offset = "0x7740DF0", VA = "0x1877419F0")]
	[IteratorStateMachine(typeof(MICLIFMKGAE))]
	private static IEnumerator<DNOIEDKBBPN> NEOGEPDFNIP(string HFGPDDPDFCO, LoadSceneMode FGGKEAIICHO, PEKLDAEFLGB<Scene> PONHJFNDGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7740BB0", Offset = "0x773FFB0", VA = "0x187740BB0")]
	public static bool FEPBKPEAMFP([Out] string MFEMKEDLLCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class NLOJKECKBEG
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7750320", Offset = "0x774F720", VA = "0x187750320")]
	public static IDisposable BHEKHJPKJKB(this HNMADAJPBON OMHMFLHBNDJ, float NEBEEHHKGOH, Action<float> BPKCOJNPKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x77503B0", Offset = "0x774F7B0", VA = "0x1877503B0")]
	public static IDisposable NPBFFEHBDCJ(this HNMADAJPBON OMHMFLHBNDJ, Action<float> BPKCOJNPKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x77502A0", Offset = "0x774F6A0", VA = "0x1877502A0")]
	public static IDisposable ADGMHJPAEHG(this HNMADAJPBON OMHMFLHBNDJ, Action<float> BPKCOJNPKIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BNHCGDDLOEL
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x773AC60", Offset = "0x773A060", VA = "0x18773AC60")]
	public static IDisposable CEGFAOEJGPN(this MonoBehaviour KIHMOOGMLJF, Action BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x773ABD0", Offset = "0x7739FD0", VA = "0x18773ABD0")]
	public static IDisposable CEGFAOEJGPN(this MonoBehaviour KIHMOOGMLJF, Action<float> BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x773B4E0", Offset = "0x773A8E0", VA = "0x18773B4E0")]
	public static IDisposable PPNDJIMKPLE(this MonoBehaviour KIHMOOGMLJF, Action BPKCOJNPKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x773B130", Offset = "0x773A530", VA = "0x18773B130")]
	public static IDisposable LPOOLHJIIMD(this MonoBehaviour KIHMOOGMLJF, Action BPKCOJNPKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x773B0B0", Offset = "0x773A4B0", VA = "0x18773B0B0")]
	public static IDisposable LPOOLHJIIMD(this MonoBehaviour KIHMOOGMLJF, Action<float> BPKCOJNPKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x773ACF0", Offset = "0x773A0F0", VA = "0x18773ACF0")]
	public static IDisposable FCOGONABBAA(this MonoBehaviour KIHMOOGMLJF, Action BPKCOJNPKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x773B030", Offset = "0x773A430", VA = "0x18773B030")]
	public static IDisposable LDAPBNGDAEO(this MonoBehaviour KIHMOOGMLJF, Action BPKCOJNPKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x773AB50", Offset = "0x7739F50", VA = "0x18773AB50")]
	public static IDisposable CAOOLHNFDPO(this MonoBehaviour KIHMOOGMLJF, Action BPKCOJNPKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x773AD70", Offset = "0x773A170", VA = "0x18773AD70")]
	public static IDisposable HBGGFLCEPBA(this MonoBehaviour KIHMOOGMLJF, float NEBEEHHKGOH, Action<float> BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP, bool NFLIHDMGDIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x773B000", Offset = "0x773A400", VA = "0x18773B000")]
	public static IDisposable JFFLEKEDKLN(this MonoBehaviour KIHMOOGMLJF, float NEBEEHHKGOH, Action<float> BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP, bool NFLIHDMGDIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x773B300", Offset = "0x773A700", VA = "0x18773B300")]
	public static IDisposable NHJDBCFHJAD(this MonoBehaviour KIHMOOGMLJF, float NEBEEHHKGOH, Action<float> BPKCOJNPKIK, bool NFLIHDMGDIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x773AAB0", Offset = "0x7739EB0", VA = "0x18773AAB0")]
	public static IDisposable BCIKGKIHEJF(this MonoBehaviour KIHMOOGMLJF, Action<float> BPKCOJNPKIK, bool NFLIHDMGDIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x773AF60", Offset = "0x773A360", VA = "0x18773AF60")]
	public static IDisposable IOGEALINMIH(this MonoBehaviour KIHMOOGMLJF, Action<float> BPKCOJNPKIK, bool NFLIHDMGDIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x773AE20", Offset = "0x773A220", VA = "0x18773AE20")]
	public static IDisposable HJMOOHOEGAN(this MonoBehaviour KIHMOOGMLJF, Action<float> BPKCOJNPKIK, bool NFLIHDMGDIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x773B3A0", Offset = "0x773A7A0", VA = "0x18773B3A0")]
	public static IDisposable NJJBJLBLINF(this MonoBehaviour KIHMOOGMLJF, Action<float> BPKCOJNPKIK, bool NFLIHDMGDIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x773B440", Offset = "0x773A840", VA = "0x18773B440")]
	public static IDisposable PBDMJPLOLEO(this MonoBehaviour KIHMOOGMLJF, Action<float> BPKCOJNPKIK, bool NFLIHDMGDIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x773AEC0", Offset = "0x773A2C0", VA = "0x18773AEC0")]
	public static IDisposable IFCGBIMFKGM(this MonoBehaviour KIHMOOGMLJF, Action<float> BPKCOJNPKIK, bool NFLIHDMGDIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x773B260", Offset = "0x773A660", VA = "0x18773B260")]
	public static IDisposable NFNMGHLDFIL(this MonoBehaviour KIHMOOGMLJF, Action<float> BPKCOJNPKIK, bool NFLIHDMGDIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x773B1B0", Offset = "0x773A5B0", VA = "0x18773B1B0")]
	public static IDisposable MOJGMPFHOME(this MonoBehaviour KIHMOOGMLJF, float NEBEEHHKGOH, Action<float> BPKCOJNPKIK, bool NFLIHDMGDIH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class MKOCEGIHDGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class EHCJJKCFCNA : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public MNDPNJJMMAK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private POBELMCPNBG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public EHCJJKCFCNA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7742600", Offset = "0x7741A00", VA = "0x187742600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x77426E0", Offset = "0x7741AE0", VA = "0x1877426E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class BOAJOGOAPMM : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public MNDPNJJMMAK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private POBELMCPNBG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public BOAJOGOAPMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x773B560", Offset = "0x773A960", VA = "0x18773B560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x773B650", Offset = "0x773AA50", VA = "0x18773B650", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x774E100", Offset = "0x774D500", VA = "0x18774E100")]
	public static NFIGMHBJPEE CEGFAOEJGPN(Action BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x774DF90", Offset = "0x774D390", VA = "0x18774DF90")]
	public static NFIGMHBJPEE CEGFAOEJGPN(Behaviour OMHMFLHBNDJ, Action BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x774E020", Offset = "0x774D420", VA = "0x18774E020")]
	public static NFIGMHBJPEE CEGFAOEJGPN(Behaviour OMHMFLHBNDJ, Action<float> BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x774E210", Offset = "0x774D610", VA = "0x18774E210")]
	[IteratorStateMachine(typeof(EHCJJKCFCNA))]
	private static IEnumerator<DNOIEDKBBPN> KJMJEEICHPG(MNDPNJJMMAK EHDJHHMEGNJ, Action BPKCOJNPKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x774E180", Offset = "0x774D580", VA = "0x18774E180")]
	[IteratorStateMachine(typeof(BOAJOGOAPMM))]
	private static IEnumerator<DNOIEDKBBPN> KJMJEEICHPG(MNDPNJJMMAK EHDJHHMEGNJ, Action<float> BPKCOJNPKIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MDGIIDEKALO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class IDBFLCBFGPK : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public MDGIIDEKALO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public IDBFLCBFGPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7748540", Offset = "0x7747940", VA = "0x187748540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x77485D0", Offset = "0x77479D0", VA = "0x1877485D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly MNDPNJJMMAK MJOINICEJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Action BMPKEFDHGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private bool PJKPDNIOBAM;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool IFFFGLPLKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C50", Offset = "0x8B2050", VA = "0x1808B2C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x774C6B0", Offset = "0x774BAB0", VA = "0x18774C6B0")]
	public MDGIIDEKALO(MNDPNJJMMAK MJOINICEJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x774C590", Offset = "0x774B990", VA = "0x18774C590")]
	[IteratorStateMachine(typeof(IDBFLCBFGPK))]
	private IEnumerator<DNOIEDKBBPN> IDOGHAENBNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x774C610", Offset = "0x774BA10", VA = "0x18774C610", Slot = "4")]
	public void OnCompleted(Action FLOCAEKKBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	public void EMLJHBGALAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class OCDCFDBKGFK
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7750430", Offset = "0x774F830", VA = "0x187750430")]
	public static MDGIIDEKALO HAJOPLDNPCH(this MNDPNJJMMAK MJOINICEJKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class EGKMNMJDABL
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class MJGDMDNDOBJ : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public POHEBPKCBLM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public MJGDMDNDOBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x774D810", Offset = "0x774CC10", VA = "0x18774D810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x774D890", Offset = "0x774CC90", VA = "0x18774D890", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7742250", Offset = "0x7741650", VA = "0x187742250")]
	public static NFIGMHBJPEE CEGFAOEJGPN(float NEBEEHHKGOH, Action<float> BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP, bool NFLIHDMGDIH = true, [Optional] IAKIMJPLHMP CLFOMGAKNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7742180", Offset = "0x7741580", VA = "0x187742180")]
	public static NFIGMHBJPEE CEGFAOEJGPN(MonoBehaviour KIHMOOGMLJF, float NEBEEHHKGOH, Action<float> BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP, bool NFLIHDMGDIH = true, [Optional] IAKIMJPLHMP CLFOMGAKNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7742380", Offset = "0x7741780", VA = "0x187742380")]
	public static NFIGMHBJPEE IFAMBHDJJBE(MonoBehaviour KIHMOOGMLJF, float NEBEEHHKGOH, Action<float> BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP, bool NFLIHDMGDIH = true, [Optional] IAKIMJPLHMP CLFOMGAKNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7742530", Offset = "0x7741930", VA = "0x187742530")]
	public static NFIGMHBJPEE MBPDJKCPAHO(HNMADAJPBON OMHMFLHBNDJ, float NEBEEHHKGOH, Action<float> BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP, bool NFLIHDMGDIH = true, [Optional] IAKIMJPLHMP CLFOMGAKNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7742470", Offset = "0x7741870", VA = "0x187742470")]
	private static IEnumerator<DNOIEDKBBPN> KJMJEEICHPG(AENKIEJCCFK MAEFCGGMCJL, float NEBEEHHKGOH, MNDPNJJMMAK EHDJHHMEGNJ, Action<float> BPKCOJNPKIK, bool NFLIHDMGDIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7742320", Offset = "0x7741720", VA = "0x187742320")]
	private static IEnumerator<DNOIEDKBBPN> DKALABGKMFA(AENKIEJCCFK MAEFCGGMCJL, float NEBEEHHKGOH, MNDPNJJMMAK EHDJHHMEGNJ, Action<float> BPKCOJNPKIK, bool NFLIHDMGDIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x77420F0", Offset = "0x77414F0", VA = "0x1877420F0")]
	[IteratorStateMachine(typeof(MJGDMDNDOBJ))]
	private static IEnumerator<DNOIEDKBBPN> BEHFLECGAND(POHEBPKCBLM MMGJCGJMKHN, float NEBEEHHKGOH, MNDPNJJMMAK EHDJHHMEGNJ, Action<float> BPKCOJNPKIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IEKOGJPOIIH
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class JHIBAPGIDJJ : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public MNDPNJJMMAK queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public JHIBAPGIDJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7748C80", Offset = "0x7748080", VA = "0x187748C80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7748D40", Offset = "0x7748140", VA = "0x187748D40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7748620", Offset = "0x7747A20", VA = "0x187748620")]
	[IteratorStateMachine(typeof(JHIBAPGIDJJ))]
	private static IEnumerator<DNOIEDKBBPN> KOJKBKMBEMP(MNDPNJJMMAK MJOINICEJKP, Func<bool> LICAAPPODIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x77486B0", Offset = "0x7747AB0", VA = "0x1877486B0")]
	public static NFIGMHBJPEE NLKMMLBENPK(this MonoBehaviour KIHMOOGMLJF, Func<bool> LICAAPPODIG, MNDPNJJMMAK MJOINICEJKP = MNDPNJJMMAK.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class NJNNFFCPAOI
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class MIJBKOMHONN : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public MNDPNJJMMAK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public MIJBKOMHONN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x774CE30", Offset = "0x774C230", VA = "0x18774CE30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x774CEA0", Offset = "0x774C2A0", VA = "0x18774CEA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class JNDHJBMLKFI : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public MNDPNJJMMAK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private DNOIEDKBBPN <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public JNDHJBMLKFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7749240", Offset = "0x7748640", VA = "0x187749240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x77492D0", Offset = "0x77486D0", VA = "0x1877492D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x774F540", Offset = "0x774E940", VA = "0x18774F540")]
	[IteratorStateMachine(typeof(MIJBKOMHONN))]
	private static IEnumerator<DNOIEDKBBPN> IDOGHAENBNA(float FBMABEBEKJJ, MNDPNJJMMAK EHDJHHMEGNJ, Action KNNCNNMDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x774F720", Offset = "0x774EB20", VA = "0x18774F720")]
	[IteratorStateMachine(typeof(JNDHJBMLKFI))]
	private static IEnumerator<DNOIEDKBBPN> MHMOBJOPDLA(float FBMABEBEKJJ, MNDPNJJMMAK EHDJHHMEGNJ, Action KNNCNNMDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x774F320", Offset = "0x774E720", VA = "0x18774F320")]
	public static IDisposable FGAAHBODABF(this MonoBehaviour KIHMOOGMLJF, float FBMABEBEKJJ, Action KNNCNNMDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x774F100", Offset = "0x774E500", VA = "0x18774F100")]
	public static NFIGMHBJPEE EIJGLPECDPF(this MonoBehaviour KIHMOOGMLJF, float FBMABEBEKJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x774F230", Offset = "0x774E630", VA = "0x18774F230")]
	public static NFIGMHBJPEE FGAAHBODABF(this MonoBehaviour KIHMOOGMLJF, float FBMABEBEKJJ, MNDPNJJMMAK EHDJHHMEGNJ, Action KNNCNNMDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x774F4A0", Offset = "0x774E8A0", VA = "0x18774F4A0")]
	public static NFIGMHBJPEE IANIFKLKGOJ(this MonoBehaviour KIHMOOGMLJF, Action KNNCNNMDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x774F680", Offset = "0x774EA80", VA = "0x18774F680")]
	public static NFIGMHBJPEE MGHKDEPNIML(this MonoBehaviour KIHMOOGMLJF, Action KNNCNNMDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x774F400", Offset = "0x774E800", VA = "0x18774F400")]
	public static NFIGMHBJPEE HIEEDMCGEPH(this MonoBehaviour KIHMOOGMLJF, Action KNNCNNMDAMC, [Optional] IAKIMJPLHMP CLFOMGAKNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x774F060", Offset = "0x774E460", VA = "0x18774F060")]
	public static NFIGMHBJPEE DHNHFNKMGMI(this MonoBehaviour KIHMOOGMLJF, Action KNNCNNMDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x774EFC0", Offset = "0x774E3C0", VA = "0x18774EFC0")]
	public static NFIGMHBJPEE BAJKODKBCDM(this MonoBehaviour KIHMOOGMLJF, Action KNNCNNMDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x774F860", Offset = "0x774EC60", VA = "0x18774F860")]
	private static NFIGMHBJPEE OCIEGGBELEN(MonoBehaviour KIHMOOGMLJF, MNDPNJJMMAK MJOINICEJKP, Action KNNCNNMDAMC, [Optional] IAKIMJPLHMP CLFOMGAKNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x774F900", Offset = "0x774ED00", VA = "0x18774F900")]
	public static NFIGMHBJPEE PGIFCENLFHI(this MonoBehaviour KIHMOOGMLJF, float EALCBDAIFLL, Action KNNCNNMDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x774F190", Offset = "0x774E590", VA = "0x18774F190")]
	public static NFIGMHBJPEE EJMJOPDJLHO(this MonoBehaviour KIHMOOGMLJF, float EALCBDAIFLL, Action KNNCNNMDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x774F5E0", Offset = "0x774E9E0", VA = "0x18774F5E0")]
	public static NFIGMHBJPEE KEDLLKLHKME(this MonoBehaviour KIHMOOGMLJF, float EALCBDAIFLL, Action KNNCNNMDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x774F7C0", Offset = "0x774EBC0", VA = "0x18774F7C0")]
	public static NFIGMHBJPEE NCINANJOAOF(this MonoBehaviour KIHMOOGMLJF, float EALCBDAIFLL, Action KNNCNNMDAMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class MIKELDFPNKN : AMJGCABCMKH, IEnumerable<AMJGCABCMKH>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<AMJGCABCMKH> HJGAPBODECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool LAMFIGLBDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Action OAMKOBIJEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool ICIKAFCGFFA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool HGBFJIPECAE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x774CEF0", Offset = "0x774C2F0", VA = "0x18774CEF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IEAIJEBNNKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x774D210", Offset = "0x774C610", VA = "0x18774D210", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x774D170", Offset = "0x774C570", VA = "0x18774D170", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x774D770", Offset = "0x774CB70", VA = "0x18774D770")]
	public MIKELDFPNKN([Optional] Action OAMKOBIJEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x774D330", Offset = "0x774C730", VA = "0x18774D330")]
	public void LEFBGNCKNFL(AMJGCABCMKH GNKKMDADLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x774D020", Offset = "0x774C420", VA = "0x18774D020")]
	private void DFBHNFPAPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x774D760", Offset = "0x774CB60", VA = "0x18774D760", Slot = "7")]
	public bool MCGAKDKHNJA(bool MALABKOONDB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x774D460", Offset = "0x774C860", VA = "0x18774D460", Slot = "8")]
	public bool MCGAKDKHNJA(Action HJOAJFDFEDM, bool MALABKOONDB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x774D2B0", Offset = "0x774C6B0", VA = "0x18774D2B0", Slot = "9")]
	public IEnumerator<AMJGCABCMKH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x774D2B0", Offset = "0x774C6B0", VA = "0x18774D2B0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class EEPKGDCCFLH : PPJCINCPLDD
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class EOJPNNEHEJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public EEPKGDCCFLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EOJPNNEHEJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7742730", Offset = "0x7741B30", VA = "0x187742730")]
		internal void PHCKDNNPOIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class HAJABDEBFEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public EEPKGDCCFLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HAJABDEBFEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7742730", Offset = "0x7741B30", VA = "0x187742730")]
		internal void DMDNMKLMONB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly float IBNHCLCDGGJ;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7741FB0", Offset = "0x77413B0", VA = "0x187741FB0")]
	public EEPKGDCCFLH(Behaviour OMHMFLHBNDJ, float IBNHCLCDGGJ, [Optional] Action OAMKOBIJEJI, [Optional] IAKIMJPLHMP CLFOMGAKNKD, [Optional] AENKIEJCCFK MAEFCGGMCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7741D90", Offset = "0x7741190", VA = "0x187741D90", Slot = "9")]
	protected override bool HNKPJGEPNKN(Action HJOAJFDFEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7741EA0", Offset = "0x77412A0", VA = "0x187741EA0", Slot = "10")]
	protected override bool OEKPCJOPPMA(Action HJOAJFDFEDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface AMJGCABCMKH
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool HGBFJIPECAE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action IEAIJEBNNKF;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MCGAKDKHNJA(bool MALABKOONDB = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MCGAKDKHNJA(Action HJOAJFDFEDM, bool MALABKOONDB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class PPJCINCPLDD : AMJGCABCMKH
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class FKCDCLEAFCI : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public PPJCINCPLDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public FKCDCLEAFCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7743A40", Offset = "0x7742E40", VA = "0x187743A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7743B10", Offset = "0x7742F10", VA = "0x187743B10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Behaviour OMHMFLHBNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action OAMKOBIJEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private OIBEFKNOBGF EILJMJMGBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly IAKIMJPLHMP CLFOMGAKNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly AENKIEJCCFK MAEFCGGMCJL;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HGBFJIPECAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x11731B0", Offset = "0x11725B0", VA = "0x1811731B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action IEAIJEBNNKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x77519B0", Offset = "0x7750DB0", VA = "0x1877519B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7751850", Offset = "0x7750C50", VA = "0x187751850", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7751D80", Offset = "0x7751180", VA = "0x187751D80")]
	protected PPJCINCPLDD(Behaviour OMHMFLHBNDJ, [Optional] Action OAMKOBIJEJI, [Optional] IAKIMJPLHMP CLFOMGAKNKD, [Optional] AENKIEJCCFK MAEFCGGMCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7751CC0", Offset = "0x77510C0", VA = "0x187751CC0", Slot = "7")]
	public bool MCGAKDKHNJA(bool MALABKOONDB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7751D20", Offset = "0x7751120", VA = "0x187751D20", Slot = "8")]
	public bool MCGAKDKHNJA(Action HJOAJFDFEDM, bool MALABKOONDB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool HNKPJGEPNKN(Action HJOAJFDFEDM);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool OEKPCJOPPMA(Action HJOAJFDFEDM);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7751A50", Offset = "0x7750E50", VA = "0x187751A50")]
	protected void KCFIMNIAHAF(Action HJOAJFDFEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7751A70", Offset = "0x7750E70", VA = "0x187751A70")]
	protected GELPMBCHBBO LBLGBOPOFJK(float AMGMJAOIIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x77518F0", Offset = "0x7750CF0", VA = "0x1877518F0")]
	private void ELNNAOFJGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x77517C0", Offset = "0x7750BC0", VA = "0x1877517C0")]
	[IteratorStateMachine(typeof(FKCDCLEAFCI))]
	private IEnumerator<DNOIEDKBBPN> BFIICABMBLJ(float AMGMJAOIIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7751970", Offset = "0x7750D70", VA = "0x187751970")]
	[CompilerGenerated]
	private void GNGGADMKKHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class BMABFLJJKAK : PPJCINCPLDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float DCJKFILBCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int DOKHAKJAGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float CGBELBKBHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float[] HLJFKCNELNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int DHAMHBMKJKI;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x773A8E0", Offset = "0x7739CE0", VA = "0x18773A8E0")]
	public BMABFLJJKAK(Behaviour OMHMFLHBNDJ, float APPECHPFFPF, int DOKHAKJAGMO, [Optional] Action OAMKOBIJEJI, float CGBELBKBHBI = 0f, [Optional] IAKIMJPLHMP CLFOMGAKNKD, [Optional] AENKIEJCCFK MAEFCGGMCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "9")]
	protected override bool HNKPJGEPNKN(Action HJOAJFDFEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x773A6E0", Offset = "0x7739AE0", VA = "0x18773A6E0", Slot = "10")]
	protected override bool OEKPCJOPPMA(Action HJOAJFDFEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x773A660", Offset = "0x7739A60", VA = "0x18773A660")]
	private void NFJLFDNBHIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LJGJDFMDMCJ : PPJCINCPLDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float IBNHCLCDGGJ;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7741FB0", Offset = "0x77413B0", VA = "0x187741FB0")]
	public LJGJDFMDMCJ(Behaviour OMHMFLHBNDJ, float IBNHCLCDGGJ, [Optional] Action OAMKOBIJEJI, [Optional] IAKIMJPLHMP CLFOMGAKNKD, [Optional] AENKIEJCCFK MAEFCGGMCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "9")]
	protected override bool HNKPJGEPNKN(Action HJOAJFDFEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x774B0D0", Offset = "0x774A4D0", VA = "0x18774B0D0", Slot = "10")]
	protected override bool OEKPCJOPPMA(Action HJOAJFDFEDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class IBDECDFPLDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class FLOOKCPIDJD : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public FLOOKCPIDJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x77429B0", Offset = "0x7741DB0", VA = "0x1877429B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7743D40", Offset = "0x7743140", VA = "0x187743D40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NFIGMHBJPEE FOAKNJBJIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private HNMADAJPBON OMHMFLHBNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Action<float> PIEOHIODDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private MNDPNJJMMAK MJOINICEJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float NCDNEAKOIML;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x77483A0", Offset = "0x77477A0", VA = "0x1877483A0")]
	public IBDECDFPLDD(HNMADAJPBON OMHMFLHBNDJ, float NEBEEHHKGOH, Action<float> BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7748030", Offset = "0x7747430", VA = "0x187748030")]
	private void EABCJHIJMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7747EA0", Offset = "0x77472A0", VA = "0x187747EA0")]
	private void BALKPHHGOHE(string MEDJAOOGFHP, Action BCGGGNNMPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x77481A0", Offset = "0x77475A0", VA = "0x1877481A0")]
	[IteratorStateMachine(typeof(FLOOKCPIDJD))]
	private IEnumerator<DNOIEDKBBPN> IHOHGEDGLFO(Action BCGGGNNMPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7747FD0", Offset = "0x77473D0", VA = "0x187747FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7748220", Offset = "0x7747620", VA = "0x187748220")]
	[CompilerGenerated]
	private void MPHHPHHLJKL(string CDCDIGHMBPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class MBFDELEMBJI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class FECLJBDOFIO : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public FECLJBDOFIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x77429B0", Offset = "0x7741DB0", VA = "0x1877429B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7742A20", Offset = "0x7741E20", VA = "0x187742A20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private NFIGMHBJPEE FOAKNJBJIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private MonoBehaviour KIHMOOGMLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action BPKCOJNPKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Action<float> PIEOHIODDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private MNDPNJJMMAK MJOINICEJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float NCDNEAKOIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private bool NFLIHDMGDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly IAKIMJPLHMP CLFOMGAKNKD;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x774C220", Offset = "0x774B620", VA = "0x18774C220")]
	public MBFDELEMBJI(MonoBehaviour KIHMOOGMLJF, Action BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP, [Optional] IAKIMJPLHMP CLFOMGAKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x774C050", Offset = "0x774B450", VA = "0x18774C050")]
	public MBFDELEMBJI(MonoBehaviour KIHMOOGMLJF, Action<float> BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP, [Optional] IAKIMJPLHMP CLFOMGAKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x774C3B0", Offset = "0x774B7B0", VA = "0x18774C3B0")]
	public MBFDELEMBJI(MonoBehaviour KIHMOOGMLJF, float NEBEEHHKGOH, Action<float> BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP, bool NFLIHDMGDIH = true, [Optional] IAKIMJPLHMP CLFOMGAKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x20C0E60", Offset = "0x20C0260", VA = "0x1820C0E60")]
	private MBFDELEMBJI(IAKIMJPLHMP CLFOMGAKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x774BE20", Offset = "0x774B220", VA = "0x18774BE20")]
	internal static MBFDELEMBJI OFMPIKCOCMG(MonoBehaviour KIHMOOGMLJF, float NEBEEHHKGOH, Action<float> BPKCOJNPKIK, MNDPNJJMMAK MJOINICEJKP, bool NFLIHDMGDIH = true, [Optional] IAKIMJPLHMP CLFOMGAKNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x774B550", Offset = "0x774A950", VA = "0x18774B550")]
	private void CEGFAOEJGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x774BCA0", Offset = "0x774B0A0", VA = "0x18774BCA0")]
	private void NFJKLCCPCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x774B800", Offset = "0x774AC00", VA = "0x18774B800")]
	private void EABCJHIJMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x774B970", Offset = "0x774AD70", VA = "0x18774B970")]
	private void FKCKFKJGKIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x774B420", Offset = "0x774A820", VA = "0x18774B420")]
	private void BALKPHHGOHE(string MEDJAOOGFHP, Action BCGGGNNMPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x774BB90", Offset = "0x774AF90", VA = "0x18774BB90")]
	[IteratorStateMachine(typeof(FECLJBDOFIO))]
	private IEnumerator<DNOIEDKBBPN> IHOHGEDGLFO(Action BCGGGNNMPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x774B7A0", Offset = "0x774ABA0", VA = "0x18774B7A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x774B680", Offset = "0x774AA80", VA = "0x18774B680")]
	[CompilerGenerated]
	private void CMEIDFDGJDG(string CDCDIGHMBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x774B710", Offset = "0x774AB10", VA = "0x18774B710")]
	[CompilerGenerated]
	private void DKOEDGFIBCO(string CDCDIGHMBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x774BB00", Offset = "0x774AF00", VA = "0x18774BB00")]
	[CompilerGenerated]
	private void IBIGEKDGMMI(string CDCDIGHMBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x774BC10", Offset = "0x774B010", VA = "0x18774BC10")]
	[CompilerGenerated]
	private void JIHDCGBPFNJ(string CDCDIGHMBPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum GLMMPKMPIHI : byte
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
internal sealed class GFNKAGBBGEK : AENKIEJCCFK
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float KGPIHNMLGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7743F70", Offset = "0x7743370", VA = "0x187743F70", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float HPFIIAMFPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7743F80", Offset = "0x7743380", VA = "0x187743F80", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public double HGICEBNEEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7744000", Offset = "0x7743400", VA = "0x187744000", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7743F90", Offset = "0x7743390", VA = "0x187743F90")]
	[OAJAKDHKADM.LHNCMMKCKFL]
	internal static void INBAICEHNJG(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	[UnityEngine.Scripting.Preserve]
	internal GFNKAGBBGEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface ICPMOKEBKKP
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COFBIHOGKAH(string DDDHPCNFCEK);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKBIOAEDCCC();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface AECPBFADMKE
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool CADCNCOFEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool FADEAEJCEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class MJNFDCNDLFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public GGHAKJHGEPD GPBJIJMKBCH;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int KMIIBMECGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8A89F0", Offset = "0x8A7DF0", VA = "0x1808A89F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x774DB60", Offset = "0x774CF60", VA = "0x18774DB60")]
	public static DNOIEDKBBPN HGONDPHFEIM(IEnumerator<DNOIEDKBBPN> GPONONEOFOH, LHMHJJPPLHD DNDANBIPKHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x774DCC0", Offset = "0x774D0C0", VA = "0x18774DCC0")]
	public DNOIEDKBBPN HGONDPHFEIM(LHMHJJPPLHD[] HMDAJADOMGM, IEnumerator<DNOIEDKBBPN>[] HPLFDEHJKNF, DNOIEDKBBPN[] BJPOCNNJNKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x774DD80", Offset = "0x774D180", VA = "0x18774DD80")]
	public void LLNHBOOIOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x774D8E0", Offset = "0x774CCE0", VA = "0x18774D8E0")]
	public void BAPGMDCNLOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x774DA20", Offset = "0x774CE20", VA = "0x18774DA20")]
	public void BOICACGAGMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x774DD80", Offset = "0x774D180", VA = "0x18774DD80")]
	public void JBHONAEHGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public MJNFDCNDLFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class GGHAKJHGEPD
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct OHLBIDGLHNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public MJNFDCNDLFN KFPLCIBGOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HNMADAJPBON EFEBNGGOHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public LHMHJJPPLHD KDONECDDKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public IEnumerator<DNOIEDKBBPN> BJCAMFAMJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public DNOIEDKBBPN COHIAIGIGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public GLMMPKMPIHI NEPLPDCBBKG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct FDHIICNEKBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public MNDPNJJMMAK PDBJJIAIFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public List<OHLBIDGLHNN> BEAANACFAJB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class FHFOJPJMODJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public LHMHJJPPLHD promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public GGHAKJHGEPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public HNMADAJPBON context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public MJNFDCNDLFN routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public GLMMPKMPIHI coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public DNOIEDKBBPN currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IEnumerator<DNOIEDKBBPN> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public FHFOJPJMODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7742A70", Offset = "0x7741E70", VA = "0x187742A70")]
		internal void MJFKMOIBFIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class DLOJODFGHGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public MJNFDCNDLFN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public GGHAKJHGEPD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public DLOJODFGHGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x773FE40", Offset = "0x773F240", VA = "0x18773FE40")]
		internal void NIIAFOBLNKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class BONNKONOAKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public MJNFDCNDLFN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public GGHAKJHGEPD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BONNKONOAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x773B6A0", Offset = "0x773AAA0", VA = "0x18773B6A0")]
		internal void BCOOICNHAOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class KLKFGMGDDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public MJNFDCNDLFN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public GGHAKJHGEPD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KLKFGMGDDAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x774A340", Offset = "0x7749740", VA = "0x18774A340")]
		internal void MCGEEFMEGFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private const GLMMPKMPIHI KPOAHMLNHCJ = GLMMPKMPIHI.Cancelled | GLMMPKMPIHI.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly MNDPNJJMMAK MJOINICEJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool[] FCLNDOBOAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<GLMMPKMPIHI> KDPFPDBIJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<float> BACMIFEHLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> EHPJIMFKOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> EHKMKBJJBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> NEFCHNGPMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> NPGDNNAFALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> CBMMKEOMLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private MJNFDCNDLFN[] KOBIECCCNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private LHMHJJPPLHD[] HMDAJADOMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private HNMADAJPBON[] FNEFBHNNLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IEnumerator<DNOIEDKBBPN>[] KFDEFADFGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private DNOIEDKBBPN[] BIIMFDIIKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int PHJCOIJKKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int BIMLHBENMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly int GGAMCBCCCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float HPLNGCFPGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private BLMEFEFDJHG NOKBHFDNPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private JobHandle PDNNFPLIOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<MJNFDCNDLFN> OHCLECGEBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool NNKIJNHMNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> PBHDNFACCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<Action> OPJKPCKAKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool OGHMMJCABAD;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public FDHIICNEKBM[] JCFOKAJFBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8FD890", Offset = "0x8FCC90", VA = "0x1808FD890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7746560", Offset = "0x7745960", VA = "0x187746560")]
	private static int PAOCPDHCMGL(MNDPNJJMMAK MJOINICEJKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7746590", Offset = "0x7745990", VA = "0x187746590")]
	public GGHAKJHGEPD(MNDPNJJMMAK MJOINICEJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7745490", Offset = "0x7744890", VA = "0x187745490")]
	private void ELPBNKHCCFO(int MJOLGJBLMOF, int IJDBDLLMBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7745E30", Offset = "0x7745230", VA = "0x187745E30")]
	public void MHNMPNAKOKM(HNMADAJPBON OMHMFLHBNDJ, DNOIEDKBBPN IEKAINHPCGI, IEnumerator<DNOIEDKBBPN> GPONONEOFOH, LHMHJJPPLHD DNDANBIPKHK, [Optional] MJNFDCNDLFN DJOMCHBGNNF, GLMMPKMPIHI ABOPOAOMJMN = GLMMPKMPIHI.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7746320", Offset = "0x7745720", VA = "0x187746320")]
	public void OPILHCAGHCE(IEnumerable<OHLBIDGLHNN> AOMAPNNJDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x77445A0", Offset = "0x77439A0", VA = "0x1877445A0")]
	private OHLBIDGLHNN BIGGACCHHJH(int OAJLCJFBDII)
	{
		return default(OHLBIDGLHNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7745FB0", Offset = "0x77453B0", VA = "0x187745FB0")]
	private void OKLNLKAFJGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BF90", Offset = "0x2E5B390", VA = "0x182E5BF90")]
	private static void JKLJKCKMAEI<T>(int OAJLCJFBDII, T[] LCFCMENMAAK, int IKJKAFPPDBP, [Optional] T BMCLJKFOHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BFE0", Offset = "0x2E5B3E0", VA = "0x182E5BFE0")]
	private static void JKLJKCKMAEI<T>(int OAJLCJFBDII, NativeArray<T> LCFCMENMAAK, int IKJKAFPPDBP, [Optional] T BMCLJKFOHEA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7744200", Offset = "0x7743600", VA = "0x187744200")]
	private void AMNJBAJBJDC(IEnumerable<OHLBIDGLHNN> AOMAPNNJDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7744B70", Offset = "0x7743F70", VA = "0x187744B70")]
	private void DCBABEKCOBL(OHLBIDGLHNN HLKHKKGBPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7745670", Offset = "0x7744A70", VA = "0x187745670")]
	private NODLDKFGNIH GCLDNICKCFH(int LDPNOONEDHG)
	{
		return default(NODLDKFGNIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7745C30", Offset = "0x7745030", VA = "0x187745C30")]
	public void MGJMGNDBHIF(float PJEMIDEDIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7745BB0", Offset = "0x7744FB0", VA = "0x187745BB0")]
	private void MCCAMPEJIOI(Action NIPIGODEADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x77458D0", Offset = "0x7744CD0", VA = "0x1877458D0")]
	private void IKEGEGMLAFI(Action NIPIGODEADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7744D70", Offset = "0x7744170", VA = "0x187744D70")]
	public void EFNFIPCMMEN(float PJEMIDEDIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7744A70", Offset = "0x7743E70", VA = "0x187744A70")]
	public void BMHCCLKIAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7745950", Offset = "0x7744D50", VA = "0x187745950")]
	public void JBHONAEHGDF(MJNFDCNDLFN MMGJCGJMKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7745A80", Offset = "0x7744E80", VA = "0x187745A80")]
	public void KDKMKDGNDLD(MJNFDCNDLFN MMGJCGJMKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7744C40", Offset = "0x7744040", VA = "0x187744C40")]
	public void DEOBBNBLMPD(MJNFDCNDLFN MMGJCGJMKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class LDBLPGKMCBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly LDBLPGKMCBK JFFGEEEAJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly Action LCFBAKMEMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool NLOIKEFMMEI;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public LDBLPGKMCBK(Action LCFBAKMEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6EB04B0", Offset = "0x6EAF8B0", VA = "0x186EB04B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface HBGGKCEPNMH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T EEMLDMGPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable KPPOLBLCMFF(UnityEngine.Object OMHMFLHBNDJ, Action<T> LKIDIOFBLHL);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface HGKMEKINLEO<T> : HBGGKCEPNMH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	new T EEMLDMGPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class HEDDCFBMBGH<T> : HGKMEKINLEO<T>, HBGGKCEPNMH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class EJIMFGBELJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public HEDDCFBMBGH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public IPECDPPJEHA<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EJIMFGBELJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D390", Offset = "0x3B7C790", VA = "0x183B7D390")]
		internal void EDIPFJHCEII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static GameObject GHGJPKGBEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly List<IPECDPPJEHA<UnityEngine.Object, Action<T>>> CPKILAHILAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private T INLFPJIAFAC;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public T EEMLDMGPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xB47470", Offset = "0xB46870", VA = "0x180B47470", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4120DE0", Offset = "0x41201E0", VA = "0x184120DE0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4120E90", Offset = "0x4120290", VA = "0x184120E90")]
	private static bool ELLLNKEFKDJ(T NIPIGODEADI, T BCMPBHCEGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4121310", Offset = "0x4120710", VA = "0x184121310")]
	public HEDDCFBMBGH(T IOIEEJFICKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4121150", Offset = "0x4120550", VA = "0x184121150", Slot = "6")]
	public IDisposable KPPOLBLCMFF(UnityEngine.Object OMHMFLHBNDJ, Action<T> LKIDIOFBLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x41209D0", Offset = "0x411FDD0", VA = "0x1841209D0")]
	private void DOKHHAODHCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class HPFLBJNJIEO : JNCOMNHABGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly IAKIMJPLHMP CLFOMGAKNKD;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7747D80", Offset = "0x7747180", VA = "0x187747D80")]
	[OAJAKDHKADM.LHNCMMKCKFL]
	internal static void KJGEFJKDGKH(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	[UnityEngine.Scripting.Preserve]
	internal HPFLBJNJIEO([CCLHMIDBCEM(null)] IAKIMJPLHMP CLFOMGAKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7747DF0", Offset = "0x77471F0", VA = "0x187747DF0", Slot = "4")]
	public IDisposable NHJDBCFHJAD(float NEBEEHHKGOH, Action<float> JMKLCPOKHHP, bool NFLIHDMGDIH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class NDHFCIHLJHD : AFKGMGHNBOL, IAKIMJPLHMP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private GGHAKJHGEPD[] DMFOLLLHHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ICPMOKEBKKP JAFDMHMGDDP;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x774E700", Offset = "0x774DB00", VA = "0x18774E700")]
	[OAJAKDHKADM.LHNCMMKCKFL]
	internal static void INBAICEHNJG(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x774EF00", Offset = "0x774E300", VA = "0x18774EF00")]
	[UnityEngine.Scripting.Preserve]
	public NDHFCIHLJHD([CCLHMIDBCEM(null)] PBGDCCLAHEB BEFDLAECEFM, [CCLHMIDBCEM(null)] AENKIEJCCFK MAEFCGGMCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x774E770", Offset = "0x774DB70", VA = "0x18774E770", Slot = "19")]
	public override NFIGMHBJPEE IOOCBBNGBON(HNMADAJPBON OMHMFLHBNDJ, IEnumerator<DNOIEDKBBPN> NFBNNGPGNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x774EB00", Offset = "0x774DF00", VA = "0x18774EB00", Slot = "20")]
	public override void PGLAGHNEHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x774E8D0", Offset = "0x774DCD0", VA = "0x18774E8D0", Slot = "22")]
	public override void NHMNICAKDLG(MNDPNJJMMAK MJOINICEJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x774ED90", Offset = "0x774E190", VA = "0x18774ED90", Slot = "21")]
	protected override void PPNDJIMKPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x774E8A0", Offset = "0x774DCA0", VA = "0x18774E8A0")]
	private GGHAKJHGEPD KHPLNJFECNB(MNDPNJJMMAK DPOLEDLIAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x774E4E0", Offset = "0x774D8E0", VA = "0x18774E4E0", Slot = "23")]
	internal override OIAEIIHLOHG ILONDCJHCGK(IEnumerator<DNOIEDKBBPN> NFBNNGPGNIA, Behaviour OMHMFLHBNDJ, LHMHJJPPLHD DNDANBIPKHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x774E2A0", Offset = "0x774D6A0", VA = "0x18774E2A0", Slot = "24")]
	internal override BCCODNKCPMH ABDOEPMDIMM(MNDPNJJMMAK EHDJHHMEGNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x774E3C0", Offset = "0x774D7C0", VA = "0x18774E3C0")]
	private void FDPJDNAJKMC(GGHAKJHGEPD HHIPLIAMDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x774E360", Offset = "0x774D760", VA = "0x18774E360", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct BLMEFEFDJHG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public float MGDCEMGFAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	public int JLKAEGCDIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> JCINBGMKOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> CKFOCCALPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> PEKGMDABMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<GLMMPKMPIHI> NPFCIJBMMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	public NativeArray<float> DKDDKKCKPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> NEFCHNGPMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[WriteOnly]
	public NativeArray<int> EHPJIMFKOHJ;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x773A450", Offset = "0x7739850", VA = "0x18773A450")]
	public static BLMEFEFDJHG JMOKCOIDHBC(int DKHKHOEHNMJ, float PJEMIDEDIMJ, NativeArray<GLMMPKMPIHI> HMHDBLEKJOM, NativeArray<float> FAHLCBIPBEO, NativeArray<int> OELPLOGOLBA, NativeArray<int> HFDIPGPHFMP, NativeArray<int> AKJEBONDOBA, NativeArray<int> CKFOCCALPCC, NativeArray<int> PEKGMDABMGC)
	{
		return default(BLMEFEFDJHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x773A340", Offset = "0x7739740", VA = "0x18773A340", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x773A580", Offset = "0x7739980", VA = "0x18773A580")]
	private bool MLFMENMOCMH(int HAJICDLBEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x773A420", Offset = "0x7739820", VA = "0x18773A420")]
	private void FEPNALLKGKO(NativeArray<int> INLJCEHKFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x773A5C0", Offset = "0x77399C0", VA = "0x18773A5C0")]
	private int PHCDOMHBFJG(int HBIOLOMEMMA, int JJGDDDGOGHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x773A4B0", Offset = "0x77398B0", VA = "0x18773A4B0")]
	private void LCAPCHPHGBC(NativeArray<int> INLJCEHKFEE, int DDOOKCBIOHA, int BHJLLDMOPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x773A100", Offset = "0x7739500", VA = "0x18773A100")]
	private void BFNCMELBLCI(NativeArray<int> INLJCEHKFEE, int ONNKKGDIIFJ, int EALGPPNBPIG, int KFGCKFLOMFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class AFKGMGHNBOL : IAKIMJPLHMP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly PBGDCCLAHEB BEFDLAECEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected readonly AENKIEJCCFK MAEFCGGMCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private BCCODNKCPMH[] IDBMHDKDMEK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static IAKIMJPLHMP GJPJBBHLIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7737760", Offset = "0x7736B60", VA = "0x187737760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static bool BCAMLDHBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public MNDPNJJMMAK CAAMPJLCLJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MNDPNJJMMAK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8A89F0", Offset = "0x8A7DF0", VA = "0x1808A89F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public AENKIEJCCFK ADBKOOLJBCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DNOIEDKBBPN ALGAJBIEGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DNOIEDKBBPN ICDKKPJOCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4C0", Offset = "0x8AC8C0", VA = "0x1808AD4C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public DNOIEDKBBPN DNCCJGBBPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC00", Offset = "0x8AF000", VA = "0x1808AFC00", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public DNOIEDKBBPN BCEJEAKOLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAF0", Offset = "0x8ABEF0", VA = "0x1808ACAF0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x77376D0", Offset = "0x7736AD0", VA = "0x1877376D0")]
	public static NFIGMHBJPEE GJNDGKGIGMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7737DA0", Offset = "0x77371A0", VA = "0x187737DA0")]
	[UnityEngine.Scripting.Preserve]
	protected AFKGMGHNBOL([CCLHMIDBCEM(null)] PBGDCCLAHEB BEFDLAECEFM, [CCLHMIDBCEM(null)] AENKIEJCCFK MAEFCGGMCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7737660", Offset = "0x7736A60", VA = "0x187737660", Slot = "6")]
	public NFIGMHBJPEE EPAPKGBPEKK(IEnumerator<DNOIEDKBBPN> NFBNNGPGNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7737460", Offset = "0x7736860", VA = "0x187737460", Slot = "7")]
	public NFIGMHBJPEE EPAPKGBPEKK(Behaviour OMHMFLHBNDJ, IEnumerator<DNOIEDKBBPN> NFBNNGPGNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract NFIGMHBJPEE IOOCBBNGBON(HNMADAJPBON OMHMFLHBNDJ, IEnumerator<DNOIEDKBBPN> NFBNNGPGNIA);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7737BE0", Offset = "0x7736FE0", VA = "0x187737BE0", Slot = "20")]
	public virtual void PGLAGHNEHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7737810", Offset = "0x7736C10", VA = "0x187737810", Slot = "9")]
	public void JCLEJNACFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7737D80", Offset = "0x7737180", VA = "0x187737D80", Slot = "21")]
	protected virtual void PPNDJIMKPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x77376B0", Offset = "0x7736AB0", VA = "0x1877376B0")]
	private void GBEBBBKLCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7737B60", Offset = "0x7736F60", VA = "0x187737B60")]
	private void OGDJDNKIIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7737A50", Offset = "0x7736E50", VA = "0x187737A50")]
	private void LPOOLHJIIMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7737670", Offset = "0x7736A70", VA = "0x187737670")]
	private void FCOGONABBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x77377D0", Offset = "0x7736BD0", VA = "0x1877377D0")]
	private void HEBOPGFOPAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7737690", Offset = "0x7736A90", VA = "0x187737690")]
	private void FNMKGCJPBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x77377F0", Offset = "0x7736BF0", VA = "0x1877377F0")]
	private void IELJFAFPJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7737AD0", Offset = "0x7736ED0", VA = "0x187737AD0", Slot = "22")]
	public virtual void NHMNICAKDLG(MNDPNJJMMAK MJOINICEJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7736ED0", Offset = "0x77362D0", VA = "0x187736ED0")]
	private void APEKELCOFKO(BCCODNKCPMH HHIPLIAMDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2125B70", Offset = "0x2124F70", VA = "0x182125B70")]
	private BCCODNKCPMH JCNLDMKEAKN(MNDPNJJMMAK DPOLEDLIAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract OIAEIIHLOHG ILONDCJHCGK(IEnumerator<DNOIEDKBBPN> NFBNNGPGNIA, Behaviour KIHMOOGMLJF, LHMHJJPPLHD KNLEDCAALHC);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract BCCODNKCPMH ABDOEPMDIMM(MNDPNJJMMAK MJOINICEJKP);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x77370A0", Offset = "0x77364A0", VA = "0x1877370A0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7737A70", Offset = "0x7736E70", VA = "0x187737A70", Slot = "15")]
	public DNOIEDKBBPN MPLOIGDEPFN(MNDPNJJMMAK EHDJHHMEGNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7736E40", Offset = "0x7736240", VA = "0x187736E40", Slot = "16")]
	public DNOIEDKBBPN ALECPGOFEPK(float FBMABEBEKJJ, MNDPNJJMMAK EHDJHHMEGNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7737B80", Offset = "0x7736F80", VA = "0x187737B80", Slot = "17")]
	public DNOIEDKBBPN OHGPBCFGDPC(Func<bool> LICAAPPODIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class OIAEIIHLOHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly LHMHJJPPLHD DNDANBIPKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly AECPBFADMKE OMHMFLHBNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool PAGNOPJOBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private string DDDHPCNFCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private StackTrace JFAEIIKGFCK;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerator<DNOIEDKBBPN> BJCAMFAMJKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public DNOIEDKBBPN COHIAIGIGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool NGCMMLPNOLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7750B50", Offset = "0x774FF50", VA = "0x187750B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool OKNKIGBFPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9D2310", Offset = "0x9D1710", VA = "0x1809D2310")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xCD6FE0", Offset = "0xCD63E0", VA = "0x180CD6FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x77505C0", Offset = "0x774F9C0", VA = "0x1877505C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float NIKPDCDDHJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xB473F0", Offset = "0xB467F0", VA = "0x180B473F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xD7A970", Offset = "0xD79D70", VA = "0x180D7A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7750CB0", Offset = "0x77500B0", VA = "0x187750CB0")]
	public OIAEIIHLOHG(IEnumerator<DNOIEDKBBPN> GPONONEOFOH, AECPBFADMKE OMHMFLHBNDJ, LHMHJJPPLHD DNDANBIPKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7750770", Offset = "0x774FB70", VA = "0x187750770")]
	public DNOIEDKBBPN HGONDPHFEIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7750A90", Offset = "0x774FE90", VA = "0x187750A90")]
	public bool IKDDNFONIIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7750B00", Offset = "0x774FF00", VA = "0x187750B00")]
	public void JBHONAEHGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7750BD0", Offset = "0x774FFD0", VA = "0x187750BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0xD3A250", Offset = "0xD39650", VA = "0x180D3A250")]
	[CompilerGenerated]
	private void ODEBNJEAKNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class LHMHJJPPLHD : GBCOAMHMLKP, NFIGMHBJPEE, OIBEFKNOBGF, GELPMBCHBBO, IEnumerator, DNOIEDKBBPN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private MNDPNJJMMAK FFKACJDHCLN;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private MNDPNJJMMAK LJNLKJGJEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA37850", Offset = "0xA36C50", VA = "0x180A37850", Slot = "23")]
		get
		{
			return default(MNDPNJJMMAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public MNDPNJJMMAK GPBJIJMKBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA38B60", Offset = "0xA37F60", VA = "0x180A38B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private float EOBKDKCCHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x9C1650", Offset = "0x9C0A50", VA = "0x1809C1650", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool OHAJLCEIKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x774B060", Offset = "0x774A460", VA = "0x18774B060", Slot = "24")]
	private bool MMHOBFFPJFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x774B050", Offset = "0x774A450", VA = "0x18774B050", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x774B080", Offset = "0x774A480", VA = "0x18774B080")]
	public LHMHJJPPLHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum NODLDKFGNIH : byte
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
internal sealed class BCCODNKCPMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum PPNCHIFJHIB
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct AFIAMNFGIIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public MNDPNJJMMAK PDBJJIAIFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public PPNCHIFJHIB KEKMLCAHEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public List<OIAEIIHLOHG> IGHGNLAFOND;
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly PPNCHIFJHIB[] COKAHCIEJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly MNDPNJJMMAK MJOINICEJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool KHOLOBCEKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly OIAEIIHLOHG[] PKAIMKMIDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<OIAEIIHLOHG> PMMFPJPMGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<int> DMNBOHEOJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<OIAEIIHLOHG> IMIINOFKPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> BPGJLEPPAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly ICPMOKEBKKP LBPOOIHKPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private bool OGHMMJCABAD;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public AFIAMNFGIIE[,] FNPMABAGILC
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC00", Offset = "0x8AF000", VA = "0x1808AFC00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x77399A0", Offset = "0x7738DA0", VA = "0x1877399A0")]
	public BCCODNKCPMH(MNDPNJJMMAK EHDJHHMEGNJ, ICPMOKEBKKP LBPOOIHKPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7739300", Offset = "0x7738700", VA = "0x187739300")]
	public void NFELNNLLOOE(OIAEIIHLOHG GPONONEOFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7738D30", Offset = "0x7738130", VA = "0x187738D30")]
	public void HMMCKLFNACN(IList<OIAEIIHLOHG> HPLFDEHJKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7739410", Offset = "0x7738810", VA = "0x187739410")]
	public void NGHHJBCJGFO(IList<OIAEIIHLOHG> HPLFDEHJKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7739210", Offset = "0x7738610", VA = "0x187739210")]
	private void LHPLMNIPIGK(OIAEIIHLOHG GPONONEOFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7738BB0", Offset = "0x7737FB0", VA = "0x187738BB0")]
	private void HAIFIHNIBMC(IList<OIAEIIHLOHG> HPLFDEHJKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7738610", Offset = "0x7737A10", VA = "0x187738610")]
	private NODLDKFGNIH BPMGGLNILFI(OIAEIIHLOHG GPONONEOFOH)
	{
		return default(NODLDKFGNIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7739700", Offset = "0x7738B00", VA = "0x187739700")]
	public void PPNDJIMKPLE(float PJEMIDEDIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7739020", Offset = "0x7738420", VA = "0x187739020")]
	public void JCLEJNACFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7738790", Offset = "0x7737B90", VA = "0x187738790")]
	private void DHCFOKEHHPM(List<OIAEIIHLOHG> HPLFDEHJKNF, Stack<int> CMFJFEKNMIB, bool MMAOAIBKFPH, float INLMHPKCGKE = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7738A90", Offset = "0x7737E90", VA = "0x187738A90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x77384D0", Offset = "0x77378D0", VA = "0x1877384D0")]
	private void BNJLKABDDHF(List<OIAEIIHLOHG> HPLFDEHJKNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class IHELKFPCKFF : ICPMOKEBKKP
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
	public void COFBIHOGKAH(string DDDHPCNFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
	public void LKBIOAEDCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public IHELKFPCKFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class FEAAFKGBFEP : AECPBFADMKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly Behaviour KIHMOOGMLJF;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x77428C0", Offset = "0x7741CC0", VA = "0x1877428C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool CADCNCOFEFD
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7742960", Offset = "0x7741D60", VA = "0x187742960", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool FADEAEJCEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7742940", Offset = "0x7741D40", VA = "0x187742940", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public FEAAFKGBFEP(Behaviour KIHMOOGMLJF)
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

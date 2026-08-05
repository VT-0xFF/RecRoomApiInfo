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
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GFIONJIFIBL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority HIFIDFMMLJF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5986A40", Offset = "0x5985840", VA = "0x185986A40")]
	public GFIONJIFIBL(ThreadPriority OCKBBOJCEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5986A30", Offset = "0x5985830", VA = "0x185986A30", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> OMPFJKKEHBG(List<PlayerLoopSystem> POEIPOGPNCF, int HPGDPDIBBMI);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct EOBBKKLLAND
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct IHKENPHHJPC
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static CJIPBGMKILF KMCNIMGPMDL;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x5989400", Offset = "0x5988200", VA = "0x185989400")]
				public static PlayerLoopSystem JCOKKJANDLA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct JHNLCIMDEEN
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static CJIPBGMKILF KDEMPONNLHG;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x598AC00", Offset = "0x5989A00", VA = "0x18598AC00")]
				public static PlayerLoopSystem JCOKKJANDLA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct MMOCAPLJICM
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static CJIPBGMKILF BDEIHDGCLCE;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x5991A70", Offset = "0x5990870", VA = "0x185991A70")]
				public static PlayerLoopSystem JCOKKJANDLA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct PLJMHGCBPBE
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static CJIPBGMKILF GLBALGBKCNH;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static CJIPBGMKILF OOGNPDKOFJG;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static CJIPBGMKILF ILGNFDFJOJO;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static CJIPBGMKILF IEBFHELPPDL;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x59967C0", Offset = "0x59955C0", VA = "0x1859967C0")]
				public static PlayerLoopSystem JCOKKJANDLA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct EJMNDGPAOHH
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static CJIPBGMKILF JNGBHKPBGLL;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5985160", Offset = "0x5983F60", VA = "0x185985160")]
				public static PlayerLoopSystem JCOKKJANDLA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct AKIKEDAEGAK
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static CJIPBGMKILF GLBALGBKCNH;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static CJIPBGMKILF OOGNPDKOFJG;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static CJIPBGMKILF ILGNFDFJOJO;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static CJIPBGMKILF IEBFHELPPDL;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x597E6A0", Offset = "0x597D4A0", VA = "0x18597E6A0")]
				public static PlayerLoopSystem JCOKKJANDLA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct MPIKCBENALM
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static CJIPBGMKILF DAGLANKCGDN;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x5992450", Offset = "0x5991250", VA = "0x185992450")]
				public static PlayerLoopSystem JCOKKJANDLA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct NDKNCEGIEED
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static CJIPBGMKILF LHGONOODCND;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5992DA0", Offset = "0x5991BA0", VA = "0x185992DA0")]
				public static PlayerLoopSystem JCOKKJANDLA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct FDGKCCHOIFE
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static CJIPBGMKILF MGGAFGKCLLD;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x5985FC0", Offset = "0x5984DC0", VA = "0x185985FC0")]
				public static PlayerLoopSystem JCOKKJANDLA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct MKIKNPFAHDL
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static CJIPBGMKILF JOPDADLJLLI;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x5991890", Offset = "0x5990690", VA = "0x185991890")]
				public static PlayerLoopSystem JCOKKJANDLA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct OLJCGEAFNFM
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static CJIPBGMKILF KEOEEJIONKM;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x5995E40", Offset = "0x5994C40", VA = "0x185995E40")]
				public static PlayerLoopSystem JCOKKJANDLA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public enum LIBKDDEAEEF : byte
			{
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct MEBCHOGLMNP
			{
				[Cpp2IlInjected.Token(Token = "0x200001E")]
				[CompilerGenerated]
				private sealed class HJFLMFIGGFM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					public LIBKDDEAEEF updateStage;

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
					public HJFLMFIGGFM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x5988C70", Offset = "0x5987A70", VA = "0x185988C70")]
					internal void <CreateSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static global::JDKDAIPFIPL<LIBKDDEAEEF> CMPAANEINCA;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5990C90", Offset = "0x598FA90", VA = "0x185990C90")]
				public static PlayerLoopSystem JCOKKJANDLA(LIBKDDEAEEF NFDHLHEKPBM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct NKPOAAMJLKF
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class KPDNFGCHIKD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public GKGBMECBBOI.LFPCHCFAEAG key;

					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
					public KPDNFGCHIKD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x598DE30", Offset = "0x598CC30", VA = "0x18598DE30")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000035")]
				public static IDisposable DODGJJALOGI;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x59931D0", Offset = "0x5991FD0", VA = "0x1859931D0")]
				public static PlayerLoopSystem MDLBPHBCBKI(GKGBMECBBOI.LFPCHCFAEAG JHANOPJHOLP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			internal struct HJOOHFGMGLK
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				[CompilerGenerated]
				private sealed class KLNEKCGPHNB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public GKGBMECBBOI.LFPCHCFAEAG key;

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
					public KLNEKCGPHNB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x598DA80", Offset = "0x598C880", VA = "0x18598DA80")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x5989000", Offset = "0x5987E00", VA = "0x185989000")]
				public static PlayerLoopSystem MDLBPHBCBKI(GKGBMECBBOI.LFPCHCFAEAG JHANOPJHOLP)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class GLIFBMEDKHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public GLIFBMEDKHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x59878C0", Offset = "0x59866C0", VA = "0x1859878C0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool BKNBLEHNDNE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool GEPECNKHCBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5982A30", Offset = "0x5981830", VA = "0x185982A30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5982A70", Offset = "0x5981870", VA = "0x185982A70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x597F5F0", Offset = "0x597E3F0", VA = "0x18597F5F0")]
		private static void GNFMEMDOKNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5982160", Offset = "0x5980F60", VA = "0x185982160")]
		private static void KHOPAFHBFGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5981C70", Offset = "0x5980A70", VA = "0x185981C70")]
		private static void JJKBJBKLBDF(string EIBKAJFKHCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x597EEA0", Offset = "0x597DCA0", VA = "0x18597EEA0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5981FA0", Offset = "0x5980DA0", VA = "0x185981FA0")]
		private static void KBGKFMLOGHL(GKGBMECBBOI.LFPCHCFAEAG JHANOPJHOLP, ref PlayerLoopSystem KCMEMCFKOEP, Type ELFDAGLKPNP, Type IHIOILIJFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x597F200", Offset = "0x597E000", VA = "0x18597F200")]
		private static void DDOOOFDEHMP(ref PlayerLoopSystem KCMEMCFKOEP, Type ELFDAGLKPNP, Type IHIOILIJFHL, OMPFJKKEHBG NCNMNCFOFLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x597F0D0", Offset = "0x597DED0", VA = "0x18597F0D0")]
		private static void BGLOGLLBOPN(ref PlayerLoopSystem KCMEMCFKOEP, Type ELFDAGLKPNP, Type IHIOILIJFHL, PlayerLoopSystem? CAEHAPALGKL, PlayerLoopSystem? BOOCBHILEPD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GKGBMECBBOI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public enum LFPCHCFAEAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class EPFDHJEINJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly LFPCHCFAEAG ANHLNJKIJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly DGKAHDGMNFL BOJECFEOALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private long FOMBMIPGNFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private long GEFFLIPACKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long NAOOOKBPBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int KCOMIIBCFCM;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5985A50", Offset = "0x5984850", VA = "0x185985A50")]
		public EPFDHJEINJN(LFPCHCFAEAG NPEFCDFIJHL, int PEHIGNPNKFC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x59859E0", Offset = "0x59847E0", VA = "0x1859859E0")]
		public void PBOALCIIENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5985780", Offset = "0x5984580", VA = "0x185985780")]
		public void KPHOCJPDJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x59857E0", Offset = "0x59845E0", VA = "0x1859857E0")]
		public void NOKGCKGACHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static LFPCHCFAEAG[] GFPEHJLFFDF;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static EPFDHJEINJN[] JHLHPFBMEHF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5987450", Offset = "0x5986250", VA = "0x185987450")]
	public static EPFDHJEINJN ANAMNEBMLFG(LFPCHCFAEAG JHANOPJHOLP, int PEHIGNPNKFC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x59876D0", Offset = "0x59864D0", VA = "0x1859876D0")]
	public static EPFDHJEINJN JGBIJNEJHJM(LFPCHCFAEAG JHANOPJHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5987620", Offset = "0x5986420", VA = "0x185987620")]
	public static void EEGFLKNFMHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DGKAHDGMNFL : PHNGIPJFPPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int DDFKEENCLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Queue<double> LPNJGKKJNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private double NFEDIMPGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private double JEAHNGLGEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private double MKPFIBAGODA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double GNCBDPJMPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5983EC0", Offset = "0x5982CC0", VA = "0x185983EC0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double HKMHLAELOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1A17640", Offset = "0x1A16440", VA = "0x181A17640", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double LEEKHPCKAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x37298B0", Offset = "0x37286B0", VA = "0x1837298B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x59840C0", Offset = "0x5982EC0", VA = "0x1859840C0")]
	public DGKAHDGMNFL(int NDGNPJEOHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5983F20", Offset = "0x5982D20", VA = "0x185983F20", Slot = "7")]
	public void JECOKBGODAP(double MMAFFACGBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5984050", Offset = "0x5982E50", VA = "0x185984050", Slot = "8")]
	public void JJEDLPKLPPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class EAFBDANLFGD : PHNGIPJFPPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private long MNBBKKLFBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double CIAFDAPKFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double MLLKIJHOLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double GCAPBLCABKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double HPHICHLEHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double NFEDIMPGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double JEAHNGLGEAL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double HKMHLAELOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1390", Offset = "0x3AE0190", VA = "0x183AE1390", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double LEEKHPCKAKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B4E0", Offset = "0xA9A2E0", VA = "0x180A9B4E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double NGMKODGFICN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x37298A0", Offset = "0x37286A0", VA = "0x1837298A0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double GNCBDPJMPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x35F97F0", Offset = "0x35F85F0", VA = "0x1835F97F0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5984E80", Offset = "0x5983C80", VA = "0x185984E80", Slot = "7")]
	public virtual void JECOKBGODAP(double MMAFFACGBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5984FB0", Offset = "0x5983DB0", VA = "0x185984FB0", Slot = "8")]
	public virtual void JJEDLPKLPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5984FF0", Offset = "0x5983DF0", VA = "0x185984FF0")]
	public EAFBDANLFGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LPKLHADKAMD : EAFBDANLFGD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double JFJCOPAPFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5990AF0", Offset = "0x598F8F0", VA = "0x185990AF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5990C80", Offset = "0x598FA80", VA = "0x185990C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5990B00", Offset = "0x598F900", VA = "0x185990B00", Slot = "7")]
	public override void JECOKBGODAP(double MMAFFACGBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5990C40", Offset = "0x598FA40", VA = "0x185990C40", Slot = "8")]
	public override void JJEDLPKLPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5984FF0", Offset = "0x5983DF0", VA = "0x185984FF0")]
	public LPKLHADKAMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface PHNGIPJFPPL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double GNCBDPJMPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double HKMHLAELOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double LEEKHPCKAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class JGHOIMDGLKG
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private interface CDGABOGJECE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool HLNPDADGAOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IFBNIOMHDFI();
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private abstract class MFJKFLMPLCA<TPromise, TMainThreadPromise> : CDGABOGJECE where TPromise : PONAFBMJJFC where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly TPromise EJCKPIMIFIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected readonly TMainThreadPromise AGHEGFDEJLM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise PGCAGCGBNFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2CF5870", Offset = "0x2CF4670", VA = "0x182CF5870")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HLNPDADGAOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2CF57F0", Offset = "0x2CF45F0", VA = "0x182CF57F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x25DF2E0", Offset = "0x25DE0E0", VA = "0x1825DF2E0")]
		protected MFJKFLMPLCA(TPromise EJCKPIMIFIN, TMainThreadPromise IGKKDOBGKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2CF5840", Offset = "0x2CF4640", VA = "0x182CF5840", Slot = "5")]
		public void IFBNIOMHDFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void IGJLAIPHPLK(TPromise EJCKPIMIFIN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class ODMOHDPJDME<T> : MFJKFLMPLCA<global::OOLBMJPBBIG<T>, global::GMJOIDNGGGA<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3B4AB50", Offset = "0x3B49950", VA = "0x183B4AB50")]
		public ODMOHDPJDME(global::OOLBMJPBBIG<T> EJCKPIMIFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3B4A990", Offset = "0x3B49790", VA = "0x183B4A990", Slot = "6")]
		protected override void IGJLAIPHPLK(global::OOLBMJPBBIG<T> EJCKPIMIFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3B4A960", Offset = "0x3B49760", VA = "0x183B4A960")]
		[CompilerGenerated]
		private void EFIDMHMADDH(T AJCHMFJLMGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1057910", Offset = "0x1056710", VA = "0x181057910")]
		[CompilerGenerated]
		private void CFPLAHGOOGN(string DOIPIGHENCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class NPHBAMKCBEJ : CDGABOGJECE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly Action JBJAGOLOBKN;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HLNPDADGAOM
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
		public NPHBAMKCBEJ(Action JBJAGOLOBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x11E6F10", Offset = "0x11E5D10", VA = "0x1811E6F10", Slot = "5")]
		public void IFBNIOMHDFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<CDGABOGJECE> CHMLJNAMPKK;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x277FDA0", Offset = "0x277EBA0", VA = "0x18277FDA0")]
	public static global::OOLBMJPBBIG<T> KBGOOGIGJII<T>(this global::OOLBMJPBBIG<T> EJCKPIMIFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x598A800", Offset = "0x5989600", VA = "0x18598A800")]
	public static void KBGOOGIGJII(Action JBJAGOLOBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x277FCE0", Offset = "0x277EAE0", VA = "0x18277FCE0")]
	private static global::OOLBMJPBBIG<T> EDEEAHMAMGH<T>(global::OOLBMJPBBIG<T> EJCKPIMIFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x598A600", Offset = "0x5989400", VA = "0x18598A600")]
	private static void JPEHCMFKOBG(CDGABOGJECE NNGFEFJEEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x598A890", Offset = "0x5989690", VA = "0x18598A890")]
	private static void KJAHHJBPOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x598A430", Offset = "0x5989230", VA = "0x18598A430")]
	private static void BBADIENEDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x598A530", Offset = "0x5989330", VA = "0x18598A530")]
	private static void CCIOJIHMPKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OBJKNPGJDDI
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private struct OGEKDMPBMOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public TaskCompletionSource<Scene> GKHKHAANNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public readonly string GBOIDOKOFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly LoadSceneMode PLHFEAPDBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly bool GLPNGKLIAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly EHEFPJIJJBB LKDPBPGJFDJ;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5995DE0", Offset = "0x5994BE0", VA = "0x185995DE0")]
		public OGEKDMPBMOF(TaskCompletionSource<Scene> AJPHIFIEFIB, string GBOIDOKOFKM, LoadSceneMode PLHFEAPDBMM, bool GLPNGKLIAJC, EHEFPJIJJBB LKDPBPGJFDJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DJPCHEAHPPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public EHEFPJIJJBB stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private global::GKMALKFADNA<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5984170", Offset = "0x5982F70", VA = "0x185984170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x59847E0", Offset = "0x59835E0", VA = "0x1859847E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct HJOGLKBLMDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5988D00", Offset = "0x5987B00", VA = "0x185988D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct OFEHKBOIDEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private OGEKDMPBMOF <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5995A50", Offset = "0x5994850", VA = "0x185995A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JFIMPLDIBGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public global::GMJOIDNGGGA<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JFIMPLDIBGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x598A3D0", Offset = "0x59891D0", VA = "0x18598A3D0")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GIOMDGKFKBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private JFIMPLDIBGD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private EHEFPJIJJBB <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private EHEFPJIJJBB <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5986A80", Offset = "0x5985880", VA = "0x185986A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5987400", Offset = "0x5986200", VA = "0x185987400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct FHGFDFLEBOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private EHEFPJIJJBB <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private EHEFPJIJJBB <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x59861A0", Offset = "0x5984FA0", VA = "0x1859861A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x59869E0", Offset = "0x59857E0", VA = "0x1859869E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class OAPGADDMGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public OAPGADDMGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5994690", Offset = "0x5993490", VA = "0x185994690")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class ENEPGHCNJPG : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public OOJANPILAPP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public ENEPGHCNJPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x59856A0", Offset = "0x59844A0", VA = "0x1859856A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5985340", Offset = "0x5984140", VA = "0x185985340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5985730", Offset = "0x5984530", VA = "0x185985730")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5985660", Offset = "0x5984460", VA = "0x185985660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class ICICGJBOEJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public global::GMJOIDNGGGA<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ICICGJBOEJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class IPLOBDMMBHL : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::GMJOIDNGGGA<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private ICICGJBOEJK <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public IPLOBDMMBHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x59897F0", Offset = "0x59885F0", VA = "0x1859897F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5989C40", Offset = "0x5988A40", VA = "0x185989C40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static PONAFBMJJFC KNPCGMPNCDK;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static AsyncOperation MCIPMDPPPCA;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static PONAFBMJJFC BEFIGNOOPLG;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string AEFGEKALBPE;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority IMCLNOHPHKK;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task AOMBKFEIPGA;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Queue<OGEKDMPBMOF> ILLAIGHPEKF;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static Task MOFHLKDFIDK;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool GIKBKJLMAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5995700", Offset = "0x5994500", VA = "0x185995700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool HBDPFLINKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5995590", Offset = "0x5994390", VA = "0x185995590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool IFOHCINOFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5995640", Offset = "0x5994440", VA = "0x185995640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> MKLHHKJMGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5995490", Offset = "0x5994290", VA = "0x185995490")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5994B20", Offset = "0x5993920", VA = "0x185994B20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x59958C0", Offset = "0x59946C0", VA = "0x1859958C0")]
	[GLIGIBNDNJI(BCKENDBGOOK.EnteredEditModeNextFrame, 0)]
	private static void OPIEAIGHMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5994C20", Offset = "0x5993A20", VA = "0x185994C20")]
	[AsyncStateMachine(typeof(DJPCHEAHPPD))]
	public static Task<Scene> COENNFFEABP(string GBOIDOKOFKM, LoadSceneMode PLHFEAPDBMM = LoadSceneMode.Single, bool GLPNGKLIAJC = false, [Optional] EHEFPJIJJBB HAHAHDNLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x59948F0", Offset = "0x59936F0", VA = "0x1859948F0")]
	[AsyncStateMachine(typeof(HJOGLKBLMDM))]
	private static Task BJKCFFHKDLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5994D80", Offset = "0x5993B80", VA = "0x185994D80")]
	[AsyncStateMachine(typeof(OFEHKBOIDEH))]
	private static Task DENABIAKNHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x59949C0", Offset = "0x59937C0", VA = "0x1859949C0")]
	[AsyncStateMachine(typeof(GIOMDGKFKBF))]
	private static Task<Scene> BJLILEAPBAA(string GBOIDOKOFKM, LoadSceneMode PLHFEAPDBMM, bool GLPNGKLIAJC, EHEFPJIJJBB LKDPBPGJFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x59951F0", Offset = "0x5993FF0", VA = "0x1859951F0")]
	[AsyncStateMachine(typeof(FHGFDFLEBOI))]
	private static Task<Scene> EJLMOCECJEA(EHEFPJIJJBB LKDPBPGJFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5994750", Offset = "0x5993550", VA = "0x185994750")]
	public static global::OOLBMJPBBIG<Scene> AHCHKINMJHD(string GBOIDOKOFKM, LoadSceneMode PLHFEAPDBMM = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5994F10", Offset = "0x5993D10", VA = "0x185994F10")]
	public static PONAFBMJJFC EIMOCGHEIMJ(string GBOIDOKOFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x59946C0", Offset = "0x59934C0", VA = "0x1859946C0")]
	[IteratorStateMachine(typeof(ENEPGHCNJPG))]
	private static IEnumerator<OLKFKAFMJCO> ADHIOHEPOAL(string GBOIDOKOFKM, OOJANPILAPP IPAMMLMHLIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5994E70", Offset = "0x5993C70", VA = "0x185994E70")]
	[IteratorStateMachine(typeof(IPLOBDMMBHL))]
	private static IEnumerator<OLKFKAFMJCO> DOECDBDJFJB(string GBOIDOKOFKM, LoadSceneMode PLHFEAPDBMM, global::GMJOIDNGGGA<Scene> IPAMMLMHLIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5995330", Offset = "0x5994130", VA = "0x185995330")]
	public static bool FPFAMBKHAMP(out string HLJEDIKJDIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class AFMLPCEGLFP
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x597E520", Offset = "0x597D320", VA = "0x18597E520")]
	public static IDisposable DAIAKIKFFKE(this FMLFHMDEAFL IJBJKIBEJLN, float NHKNKHBEEBN, Action<float> LOGNMBNKGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x597E5A0", Offset = "0x597D3A0", VA = "0x18597E5A0")]
	public static IDisposable KPBMCCAFJBG(this FMLFHMDEAFL IJBJKIBEJLN, Action<float> LOGNMBNKGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x597E620", Offset = "0x597D420", VA = "0x18597E620")]
	public static IDisposable PEEJCJILCNO(this FMLFHMDEAFL IJBJKIBEJLN, Action<float> LOGNMBNKGBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class MHODEDGDIMI
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5991710", Offset = "0x5990510", VA = "0x185991710")]
	public static IDisposable NPAIFOGJOII(this MonoBehaviour LDKOGEKLCJM, Action LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5991790", Offset = "0x5990590", VA = "0x185991790")]
	public static IDisposable NPAIFOGJOII(this MonoBehaviour LDKOGEKLCJM, Action<float> LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5991050", Offset = "0x598FE50", VA = "0x185991050")]
	public static IDisposable FPKIEKJDLAL(this MonoBehaviour LDKOGEKLCJM, Action LOGNMBNKGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x59910C0", Offset = "0x598FEC0", VA = "0x1859910C0")]
	public static IDisposable GHJGFBNGBHH(this MonoBehaviour LDKOGEKLCJM, Action LOGNMBNKGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5991600", Offset = "0x5990400", VA = "0x185991600")]
	public static IDisposable MFNDAPMLNAF(this MonoBehaviour LDKOGEKLCJM, Action LOGNMBNKGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5991810", Offset = "0x5990610", VA = "0x185991810")]
	public static IDisposable ONFKGIEJJDD(this MonoBehaviour LDKOGEKLCJM, Action LOGNMBNKGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5991380", Offset = "0x5990180", VA = "0x185991380")]
	public static IDisposable JCAEEBAJAND(this MonoBehaviour LDKOGEKLCJM, Action LOGNMBNKGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5991560", Offset = "0x5990360", VA = "0x185991560")]
	public static IDisposable LMNJGJIGCFK(this MonoBehaviour LDKOGEKLCJM, float NHKNKHBEEBN, Action<float> LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, bool EFAIFLDLDBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5991530", Offset = "0x5990330", VA = "0x185991530")]
	public static IDisposable LBBAIDJOMAH(this MonoBehaviour LDKOGEKLCJM, float NHKNKHBEEBN, Action<float> LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, bool EFAIFLDLDBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5991400", Offset = "0x5990200", VA = "0x185991400")]
	public static IDisposable JPFJGMNPGEL(this MonoBehaviour LDKOGEKLCJM, float NHKNKHBEEBN, Action<float> LOGNMBNKGBP, bool EFAIFLDLDBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x59911D0", Offset = "0x598FFD0", VA = "0x1859911D0")]
	public static IDisposable HKLHGBCABMH(this MonoBehaviour LDKOGEKLCJM, Action<float> LOGNMBNKGBP, bool EFAIFLDLDBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5990F20", Offset = "0x598FD20", VA = "0x185990F20")]
	public static IDisposable AAEEMMOBHHN(this MonoBehaviour LDKOGEKLCJM, Action<float> LOGNMBNKGBP, bool EFAIFLDLDBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5991140", Offset = "0x598FF40", VA = "0x185991140")]
	public static IDisposable GMIJEIFEMLI(this MonoBehaviour LDKOGEKLCJM, Action<float> LOGNMBNKGBP, bool EFAIFLDLDBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x59912F0", Offset = "0x59900F0", VA = "0x1859912F0")]
	public static IDisposable IHDJKJNPOBA(this MonoBehaviour LDKOGEKLCJM, Action<float> LOGNMBNKGBP, bool EFAIFLDLDBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x59914A0", Offset = "0x59902A0", VA = "0x1859914A0")]
	public static IDisposable KJDENPIAKCN(this MonoBehaviour LDKOGEKLCJM, Action<float> LOGNMBNKGBP, bool EFAIFLDLDBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5991680", Offset = "0x5990480", VA = "0x185991680")]
	public static IDisposable MOBPEIJABPI(this MonoBehaviour LDKOGEKLCJM, Action<float> LOGNMBNKGBP, bool EFAIFLDLDBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5991260", Offset = "0x5990060", VA = "0x185991260")]
	public static IDisposable HPHBLFLCMLB(this MonoBehaviour LDKOGEKLCJM, Action<float> LOGNMBNKGBP, bool EFAIFLDLDBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5990FB0", Offset = "0x598FDB0", VA = "0x185990FB0")]
	public static IDisposable BLIIBFPFIGJ(this MonoBehaviour LDKOGEKLCJM, float NHKNKHBEEBN, Action<float> LOGNMBNKGBP, bool EFAIFLDLDBG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class KLLMMBHPALK
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class IOBGMCNBDCB : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public HNIOIOPPNAO.MPMODPADNDL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private DAOIOLBHOKD <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public IOBGMCNBDCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x59895E0", Offset = "0x59883E0", VA = "0x1859895E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x59896A0", Offset = "0x59884A0", VA = "0x1859896A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class IPOCDLOIFEP : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public HNIOIOPPNAO.MPMODPADNDL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private DAOIOLBHOKD <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public IPOCDLOIFEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5989C80", Offset = "0x5988A80", VA = "0x185989C80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5989D70", Offset = "0x5988B70", VA = "0x185989D70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x598D800", Offset = "0x598C600", VA = "0x18598D800")]
	public static LGJHLMJKIJM NPAIFOGJOII(Action LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x598D8B0", Offset = "0x598C6B0", VA = "0x18598D8B0")]
	public static LGJHLMJKIJM NPAIFOGJOII(Behaviour IJBJKIBEJLN, Action LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x598D970", Offset = "0x598C770", VA = "0x18598D970")]
	public static LGJHLMJKIJM NPAIFOGJOII(Behaviour IJBJKIBEJLN, Action<float> LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x598D700", Offset = "0x598C500", VA = "0x18598D700")]
	[IteratorStateMachine(typeof(IOBGMCNBDCB))]
	private static IEnumerator<OLKFKAFMJCO> MMBIMJDKICG(HNIOIOPPNAO.MPMODPADNDL GAGLCOBIACG, Action LOGNMBNKGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x598D780", Offset = "0x598C580", VA = "0x18598D780")]
	[IteratorStateMachine(typeof(IPOCDLOIFEP))]
	private static IEnumerator<OLKFKAFMJCO> MMBIMJDKICG(HNIOIOPPNAO.MPMODPADNDL GAGLCOBIACG, Action<float> LOGNMBNKGBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class JADEIDCGBDG
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class MFOPLHJOOJL : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public EEBJIKDBCMB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public MFOPLHJOOJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5990E40", Offset = "0x598FC40", VA = "0x185990E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5990EE0", Offset = "0x598FCE0", VA = "0x185990EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x598A070", Offset = "0x5988E70", VA = "0x18598A070")]
	public static LGJHLMJKIJM NPAIFOGJOII(float NHKNKHBEEBN, Action<float> LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, bool EFAIFLDLDBG = true, [Optional] KDDJAPJLMJH ICLJGLHGBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x598A170", Offset = "0x5988F70", VA = "0x18598A170")]
	public static LGJHLMJKIJM NPAIFOGJOII(MonoBehaviour LDKOGEKLCJM, float NHKNKHBEEBN, Action<float> LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, bool EFAIFLDLDBG = true, [Optional] KDDJAPJLMJH ICLJGLHGBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5989E10", Offset = "0x5988C10", VA = "0x185989E10")]
	public static LGJHLMJKIJM JHJPNFDKHGJ(MonoBehaviour LDKOGEKLCJM, float NHKNKHBEEBN, Action<float> LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, bool EFAIFLDLDBG = true, [Optional] KDDJAPJLMJH ICLJGLHGBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x598A280", Offset = "0x5989080", VA = "0x18598A280")]
	public static LGJHLMJKIJM OOHCHPDMOMC(FMLFHMDEAFL IJBJKIBEJLN, float NHKNKHBEEBN, Action<float> LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, bool EFAIFLDLDBG = true, [Optional] KDDJAPJLMJH ICLJGLHGBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5989F30", Offset = "0x5988D30", VA = "0x185989F30")]
	private static IEnumerator<OLKFKAFMJCO> MMBIMJDKICG(MNMLMKFIJMC GNEJOAKKEAA, float NHKNKHBEEBN, HNIOIOPPNAO.MPMODPADNDL GAGLCOBIACG, Action<float> LOGNMBNKGBP, bool EFAIFLDLDBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5989DB0", Offset = "0x5988BB0", VA = "0x185989DB0")]
	private static IEnumerator<OLKFKAFMJCO> FPPPIDOINCH(MNMLMKFIJMC GNEJOAKKEAA, float NHKNKHBEEBN, HNIOIOPPNAO.MPMODPADNDL GAGLCOBIACG, Action<float> LOGNMBNKGBP, bool EFAIFLDLDBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5989FE0", Offset = "0x5988DE0", VA = "0x185989FE0")]
	[IteratorStateMachine(typeof(MFOPLHJOOJL))]
	private static IEnumerator<OLKFKAFMJCO> NDNFOHOBEEH(EEBJIKDBCMB HIMCNNCGFHH, float NHKNKHBEEBN, HNIOIOPPNAO.MPMODPADNDL GAGLCOBIACG, Action<float> LOGNMBNKGBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class PDFIDJCMKAF
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class CLGAGKJGHJD : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public HNIOIOPPNAO.MPMODPADNDL queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public CLGAGKJGHJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x597EBB0", Offset = "0x597D9B0", VA = "0x18597EBB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x597EC60", Offset = "0x597DA60", VA = "0x18597EC60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5996740", Offset = "0x5995540", VA = "0x185996740")]
	[IteratorStateMachine(typeof(CLGAGKJGHJD))]
	private static IEnumerator<OLKFKAFMJCO> FJICNPNJDAP(HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, Func<bool> IMGEDHKJCMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5996630", Offset = "0x5995430", VA = "0x185996630")]
	public static LGJHLMJKIJM ELEDODKFJMI(this MonoBehaviour LDKOGEKLCJM, Func<bool> IMGEDHKJCMM, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP = HNIOIOPPNAO.MPMODPADNDL.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class LKJDKCADOAB
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class NKPKNMBBKPP : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public HNIOIOPPNAO.MPMODPADNDL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public NKPKNMBBKPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x59930D0", Offset = "0x5991ED0", VA = "0x1859930D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5993190", Offset = "0x5991F90", VA = "0x185993190", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class IOGODECKIEJ : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public HNIOIOPPNAO.MPMODPADNDL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private OLKFKAFMJCO <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public IOGODECKIEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x59896E0", Offset = "0x59884E0", VA = "0x1859896E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x59897B0", Offset = "0x59885B0", VA = "0x1859897B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x59903E0", Offset = "0x598F1E0", VA = "0x1859903E0")]
	[IteratorStateMachine(typeof(NKPKNMBBKPP))]
	private static IEnumerator<OLKFKAFMJCO> JJMNBLFHHPK(float AHLFLDNKOCA, HNIOIOPPNAO.MPMODPADNDL GAGLCOBIACG, Action PFGGBMFPGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5990A60", Offset = "0x598F860", VA = "0x185990A60")]
	[IteratorStateMachine(typeof(IOGODECKIEJ))]
	private static IEnumerator<OLKFKAFMJCO> OLLBAEHBNNK(float AHLFLDNKOCA, HNIOIOPPNAO.MPMODPADNDL GAGLCOBIACG, Action PFGGBMFPGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5990620", Offset = "0x598F420", VA = "0x185990620")]
	public static IDisposable LJOGAHBLHHA(this MonoBehaviour LDKOGEKLCJM, float AHLFLDNKOCA, Action PFGGBMFPGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5990870", Offset = "0x598F670", VA = "0x185990870")]
	public static LGJHLMJKIJM MAFGLJGCDBJ(this MonoBehaviour LDKOGEKLCJM, float AHLFLDNKOCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5990740", Offset = "0x598F540", VA = "0x185990740")]
	public static LGJHLMJKIJM LJOGAHBLHHA(this MonoBehaviour LDKOGEKLCJM, float AHLFLDNKOCA, HNIOIOPPNAO.MPMODPADNDL GAGLCOBIACG, Action PFGGBMFPGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x59900F0", Offset = "0x598EEF0", VA = "0x1859900F0")]
	public static LGJHLMJKIJM AKNPEFJGONJ(this MonoBehaviour LDKOGEKLCJM, Action PFGGBMFPGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x59902B0", Offset = "0x598F0B0", VA = "0x1859902B0")]
	public static LGJHLMJKIJM HMLOICKFGHP(this MonoBehaviour LDKOGEKLCJM, Action PFGGBMFPGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5990540", Offset = "0x598F340", VA = "0x185990540")]
	public static LGJHLMJKIJM LEDELBAGHPO(this MonoBehaviour LDKOGEKLCJM, Action PFGGBMFPGEK, [Optional] KDDJAPJLMJH ICLJGLHGBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x59903B0", Offset = "0x598F1B0", VA = "0x1859903B0")]
	public static LGJHLMJKIJM JBLFEGILPIF(this MonoBehaviour LDKOGEKLCJM, Action PFGGBMFPGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5990930", Offset = "0x598F730", VA = "0x185990930")]
	public static LGJHLMJKIJM MNGPBBDFNAA(this MonoBehaviour LDKOGEKLCJM, Action PFGGBMFPGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5990A30", Offset = "0x598F830", VA = "0x185990A30")]
	public static LGJHLMJKIJM OBOIEPGINCO(this MonoBehaviour LDKOGEKLCJM, Action PFGGBMFPGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5990960", Offset = "0x598F760", VA = "0x185990960")]
	private static LGJHLMJKIJM NILGNOBIEPM(MonoBehaviour LDKOGEKLCJM, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, Action PFGGBMFPGEK, [Optional] KDDJAPJLMJH ICLJGLHGBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5990470", Offset = "0x598F270", VA = "0x185990470")]
	public static LGJHLMJKIJM KPFDHBJIDEJ(this MonoBehaviour LDKOGEKLCJM, float GLKKINNDCBA, Action PFGGBMFPGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x59902E0", Offset = "0x598F0E0", VA = "0x1859902E0")]
	public static LGJHLMJKIJM ILNGMIIGLKF(this MonoBehaviour LDKOGEKLCJM, float GLKKINNDCBA, Action PFGGBMFPGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5990110", Offset = "0x598EF10", VA = "0x185990110")]
	public static LGJHLMJKIJM EJLECPNAIEF(this MonoBehaviour LDKOGEKLCJM, float GLKKINNDCBA, Action PFGGBMFPGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x59901E0", Offset = "0x598EFE0", VA = "0x1859901E0")]
	public static LGJHLMJKIJM FINOOKPBACF(this MonoBehaviour LDKOGEKLCJM, float GLKKINNDCBA, Action PFGGBMFPGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class AFIKMFGPEIB : BGPMLGCPCJE, IEnumerable<BGPMLGCPCJE>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly List<BGPMLGCPCJE> HCKGJFOCKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool FDHIBJJMEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Action GBNMJOJPJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool NLLAFJNANKN;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool PFAPNJGDEMK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x597DD10", Offset = "0x597CB10", VA = "0x18597DD10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GOGPPADCFDC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x597E2B0", Offset = "0x597D0B0", VA = "0x18597E2B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x597DBF0", Offset = "0x597C9F0", VA = "0x18597DBF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x597E480", Offset = "0x597D280", VA = "0x18597E480")]
	public AFIKMFGPEIB([Optional] Action GBNMJOJPJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x597E350", Offset = "0x597D150", VA = "0x18597E350")]
	public void OEECIDDHIAM(BGPMLGCPCJE PMIHHPGOGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x597E140", Offset = "0x597CF40", VA = "0x18597E140")]
	private void KANHIHGFEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x597DE50", Offset = "0x597CC50", VA = "0x18597DE50", Slot = "7")]
	public bool JNANKLAPNGE(bool ONFDAKCOPIF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x597DE60", Offset = "0x597CC60", VA = "0x18597DE60", Slot = "8")]
	public bool JNANKLAPNGE(Action JBJAGOLOBKN, bool ONFDAKCOPIF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x597DC90", Offset = "0x597CA90", VA = "0x18597DC90", Slot = "9")]
	public IEnumerator<BGPMLGCPCJE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x597DC90", Offset = "0x597CA90", VA = "0x18597DC90", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class CNGPIDANMAE : DLFHJBBDNJJ
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class KBHIKMPFGLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public CNGPIDANMAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public KBHIKMPFGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x597EA40", Offset = "0x597D840", VA = "0x18597EA40")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class BBPKEFGBJGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CNGPIDANMAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BBPKEFGBJGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x597EA40", Offset = "0x597D840", VA = "0x18597EA40")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly float PIFCHIMNNLF;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x597EAB0", Offset = "0x597D8B0", VA = "0x18597EAB0")]
	public CNGPIDANMAE(Behaviour IJBJKIBEJLN, float PIFCHIMNNLF, [Optional] Action GBNMJOJPJAF, [Optional] KDDJAPJLMJH ICLJGLHGBOE, [Optional] MNMLMKFIJMC GNEJOAKKEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x597ECA0", Offset = "0x597DAA0", VA = "0x18597ECA0", Slot = "9")]
	protected override bool AMCBLLNPDIF(Action JBJAGOLOBKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x597EDA0", Offset = "0x597DBA0", VA = "0x18597EDA0", Slot = "10")]
	protected override bool HNFKJPENEPE(Action JBJAGOLOBKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface BGPMLGCPCJE
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool PFAPNJGDEMK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GOGPPADCFDC;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JNANKLAPNGE(bool ONFDAKCOPIF = false);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JNANKLAPNGE(Action JBJAGOLOBKN, bool ONFDAKCOPIF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class DLFHJBBDNJJ : BGPMLGCPCJE
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class NDOLBJPGDIE : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public DLFHJBBDNJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public NDOLBJPGDIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5992F80", Offset = "0x5991D80", VA = "0x185992F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5993050", Offset = "0x5991E50", VA = "0x185993050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly Behaviour IJBJKIBEJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Action GBNMJOJPJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private BMBBAPOFAOP LKPPJBFBEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly KDDJAPJLMJH ICLJGLHGBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	protected readonly MNMLMKFIJMC GNEJOAKKEAA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PFAPNJGDEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7927E0", Offset = "0x7915E0", VA = "0x1807927E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GOGPPADCFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5984CE0", Offset = "0x5983AE0", VA = "0x185984CE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5984830", Offset = "0x5983630", VA = "0x185984830", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5984D80", Offset = "0x5983B80", VA = "0x185984D80")]
	protected DLFHJBBDNJJ(Behaviour IJBJKIBEJLN, [Optional] Action GBNMJOJPJAF, [Optional] KDDJAPJLMJH ICLJGLHGBOE, [Optional] MNMLMKFIJMC GNEJOAKKEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5984BC0", Offset = "0x59839C0", VA = "0x185984BC0", Slot = "7")]
	public bool JNANKLAPNGE(bool ONFDAKCOPIF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5984B70", Offset = "0x5983970", VA = "0x185984B70", Slot = "8")]
	public bool JNANKLAPNGE(Action JBJAGOLOBKN, bool ONFDAKCOPIF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool AMCBLLNPDIF(Action JBJAGOLOBKN);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool HNFKJPENEPE(Action JBJAGOLOBKN);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5984B50", Offset = "0x5983950", VA = "0x185984B50")]
	protected void IOGOKCMDOIF(Action JBJAGOLOBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5984950", Offset = "0x5983750", VA = "0x185984950")]
	protected PONAFBMJJFC EJOKGEPOCDB(float ALMHHJAPIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5984C20", Offset = "0x5983A20", VA = "0x185984C20")]
	private void JNGLBFFBJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x59848D0", Offset = "0x59836D0", VA = "0x1859848D0")]
	[IteratorStateMachine(typeof(NDOLBJPGDIE))]
	private IEnumerator<OLKFKAFMJCO> DMPLKCHMJPL(float ALMHHJAPIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5984CA0", Offset = "0x5983AA0", VA = "0x185984CA0")]
	[CompilerGenerated]
	private void KJHBFFIBPMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FAIGCEMAHKF : DLFHJBBDNJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float KEBJFIPCFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly int LHJLEPDCFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float BBKEPGHPLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly float[] ELCOKCIHHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private int ALNIABIKPAP;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5985E10", Offset = "0x5984C10", VA = "0x185985E10")]
	public FAIGCEMAHKF(Behaviour IJBJKIBEJLN, float MJHBIPMBKJN, int LHJLEPDCFDJ, [Optional] Action GBNMJOJPJAF, float BBKEPGHPLCH = 0f, [Optional] KDDJAPJLMJH ICLJGLHGBOE, [Optional] MNMLMKFIJMC GNEJOAKKEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "9")]
	protected override bool AMCBLLNPDIF(Action JBJAGOLOBKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5985BE0", Offset = "0x59849E0", VA = "0x185985BE0", Slot = "10")]
	protected override bool HNFKJPENEPE(Action JBJAGOLOBKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5985B50", Offset = "0x5984950", VA = "0x185985B50")]
	private void BCNEAEBMMJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class BKJNHHBHADP : DLFHJBBDNJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float PIFCHIMNNLF;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x597EAB0", Offset = "0x597D8B0", VA = "0x18597EAB0")]
	public BKJNHHBHADP(Behaviour IJBJKIBEJLN, float PIFCHIMNNLF, [Optional] Action GBNMJOJPJAF, [Optional] KDDJAPJLMJH ICLJGLHGBOE, [Optional] MNMLMKFIJMC GNEJOAKKEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "9")]
	protected override bool AMCBLLNPDIF(Action JBJAGOLOBKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x597EA70", Offset = "0x597D870", VA = "0x18597EA70", Slot = "10")]
	protected override bool HNFKJPENEPE(Action JBJAGOLOBKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public sealed class NAJOJDNMCKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class HGDIMGHJINP : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public HGDIMGHJINP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5988B90", Offset = "0x5987990", VA = "0x185988B90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5988C30", Offset = "0x5987A30", VA = "0x185988C30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private LGJHLMJKIJM PEJMJNLFJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private FMLFHMDEAFL IJBJKIBEJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Action<float> NLNBJDILAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private float CDDPMAHLCPF;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5992BC0", Offset = "0x59919C0", VA = "0x185992BC0")]
	public NAJOJDNMCKC(FMLFHMDEAFL IJBJKIBEJLN, float NHKNKHBEEBN, Action<float> LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5992630", Offset = "0x5991430", VA = "0x185992630")]
	private void AMKAFKOBFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x59927E0", Offset = "0x59915E0", VA = "0x1859927E0")]
	private void DHHCAJCFDLC(string DOIPIGHENCB, Action MAMKLMIMAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5992B50", Offset = "0x5991950", VA = "0x185992B50")]
	[IteratorStateMachine(typeof(HGDIMGHJINP))]
	private IEnumerator<OLKFKAFMJCO> OHGGNEOPJFJ(Action MAMKLMIMAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5992940", Offset = "0x5991740", VA = "0x185992940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x59929A0", Offset = "0x59917A0", VA = "0x1859929A0")]
	[CompilerGenerated]
	private void HECGDIAOLHH(string EBHODPHNEOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class DDNPAOIPIDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class LAFKECAFCPP : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public LAFKECAFCPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x598E0A0", Offset = "0x598CEA0", VA = "0x18598E0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x598E140", Offset = "0x598CF40", VA = "0x18598E140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private LGJHLMJKIJM PEJMJNLFJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private MonoBehaviour LDKOGEKLCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Action LOGNMBNKGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Action<float> NLNBJDILAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private float CDDPMAHLCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool EFAIFLDLDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly KDDJAPJLMJH ICLJGLHGBOE;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5983A80", Offset = "0x5982880", VA = "0x185983A80")]
	public DDNPAOIPIDB(MonoBehaviour LDKOGEKLCJM, Action LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, [Optional] KDDJAPJLMJH ICLJGLHGBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5983C80", Offset = "0x5982A80", VA = "0x185983C80")]
	public DDNPAOIPIDB(MonoBehaviour LDKOGEKLCJM, Action<float> LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, [Optional] KDDJAPJLMJH ICLJGLHGBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5983830", Offset = "0x5982630", VA = "0x185983830")]
	public DDNPAOIPIDB(MonoBehaviour LDKOGEKLCJM, float NHKNKHBEEBN, Action<float> LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, bool EFAIFLDLDBG = true, [Optional] KDDJAPJLMJH ICLJGLHGBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x41BBA40", Offset = "0x41BA840", VA = "0x1841BBA40")]
	private DDNPAOIPIDB(KDDJAPJLMJH ICLJGLHGBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5983200", Offset = "0x5982000", VA = "0x185983200")]
	internal static DDNPAOIPIDB GEGNJPKBGBM(MonoBehaviour LDKOGEKLCJM, float NHKNKHBEEBN, Action<float> LOGNMBNKGBP, HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, bool EFAIFLDLDBG = true, [Optional] KDDJAPJLMJH ICLJGLHGBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5983650", Offset = "0x5982450", VA = "0x185983650")]
	private void NPAIFOGJOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x59834A0", Offset = "0x59822A0", VA = "0x1859834A0")]
	private void KAOFLFKCPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5982BD0", Offset = "0x59819D0", VA = "0x185982BD0")]
	private void AMKAFKOBFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5983030", Offset = "0x5981E30", VA = "0x185983030")]
	private void FFONKOEOCIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5982EA0", Offset = "0x5981CA0", VA = "0x185982EA0")]
	private void DHHCAJCFDLC(string DOIPIGHENCB, Action MAMKLMIMAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x59837C0", Offset = "0x59825C0", VA = "0x1859837C0")]
	[IteratorStateMachine(typeof(LAFKECAFCPP))]
	private IEnumerator<OLKFKAFMJCO> OHGGNEOPJFJ(Action MAMKLMIMAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5982FD0", Offset = "0x5981DD0", VA = "0x185982FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5982B40", Offset = "0x5981940", VA = "0x185982B40")]
	[CompilerGenerated]
	private void AFLFBGKLLLE(string EBHODPHNEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5982D80", Offset = "0x5981B80", VA = "0x185982D80")]
	[CompilerGenerated]
	private void DDDLBOGEHCH(string EBHODPHNEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5982E10", Offset = "0x5981C10", VA = "0x185982E10")]
	[CompilerGenerated]
	private void DFCDINMBOBN(string EBHODPHNEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5982AB0", Offset = "0x59818B0", VA = "0x185982AB0")]
	[CompilerGenerated]
	private void ADBAJCNLMLM(string EBHODPHNEOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Flags]
internal enum JELOEOHJEOF : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class EFABCKAHNEC : MNMLMKFIJMC
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public float JALBNKJHGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x59850C0", Offset = "0x5983EC0", VA = "0x1859850C0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public float AIGBPGLJBGH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x59850B0", Offset = "0x5983EB0", VA = "0x1859850B0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public double EKFJEPPGICP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5985140", Offset = "0x5983F40", VA = "0x185985140", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x59850D0", Offset = "0x5983ED0", VA = "0x1859850D0")]
	[CFDOMFEMHNO(ANAFFCEINAM.None)]
	private static void PEBFIEIHMDK(GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	[Preserve]
	internal EFABCKAHNEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal interface NOJIALEGMNH
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKFICDJOGPC(string ICIEGOLHGJN);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPEPJILJLFJ();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface KIIMNOKIKAC
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string JAGOKEMFLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool MFIKILBBBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool NCDCHINIGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class PAIEGLCKHCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public JNGPDABHOGG MFLAGNNDNEA;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int CEEBBJGGBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x740040", Offset = "0x73EE40", VA = "0x180740040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7620C0", Offset = "0x760EC0", VA = "0x1807620C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5996300", Offset = "0x5995100", VA = "0x185996300")]
	public static OLKFKAFMJCO KJKANIODKMH(IEnumerator<OLKFKAFMJCO> IPNDPOFCJMA, EBNOENMKLPI MDMLEAMEPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5996220", Offset = "0x5995020", VA = "0x185996220")]
	public OLKFKAFMJCO KJKANIODKMH(EBNOENMKLPI[] PBDJPBKPEEO, IEnumerator<OLKFKAFMJCO>[] BMDLIAGHHGE, OLKFKAFMJCO[] PDDPAADGENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x59961F0", Offset = "0x5994FF0", VA = "0x1859961F0")]
	public void LCOCIEPDKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x59960B0", Offset = "0x5994EB0", VA = "0x1859960B0")]
	public void CBOGAMNKKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x59964B0", Offset = "0x59952B0", VA = "0x1859964B0")]
	public void MCEPJDGLPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x59961F0", Offset = "0x5994FF0", VA = "0x1859961F0")]
	public void GEKMIDEDNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public PAIEGLCKHCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class JNGPDABHOGG
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct HGNGFABHAMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public PAIEGLCKHCL HBIALLKBCNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public FMLFHMDEAFL BLDCJNPEBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public EBNOENMKLPI GBJLGGKCNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public IEnumerator<OLKFKAFMJCO> DFIBPFCKBEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public OLKFKAFMJCO LHLBCKIOAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JELOEOHJEOF FIAAFBLOIDP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct NMNAIBBBKGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public HNIOIOPPNAO.MPMODPADNDL KGPGOKKAOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public List<HGNGFABHAMI> DMEHAHLLHCN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MNCOCHEMMNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public EBNOENMKLPI promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public JNGPDABHOGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public FMLFHMDEAFL context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public PAIEGLCKHCL routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JELOEOHJEOF coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public OLKFKAFMJCO currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public IEnumerator<OLKFKAFMJCO> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public MNCOCHEMMNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5991C50", Offset = "0x5990A50", VA = "0x185991C50")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class NEGEAMMGFKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public PAIEGLCKHCL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public JNGPDABHOGG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public NEGEAMMGFKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x5993090", Offset = "0x5991E90", VA = "0x185993090")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class JAHIOGOIOFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public PAIEGLCKHCL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public JNGPDABHOGG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JAHIOGOIOFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x598A390", Offset = "0x5989190", VA = "0x18598A390")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class PBFGDIGIOMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public PAIEGLCKHCL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public JNGPDABHOGG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PBFGDIGIOMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x59965F0", Offset = "0x59953F0", VA = "0x1859965F0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private const JELOEOHJEOF HJACHPAGNCO = JELOEOHJEOF.Cancelled | JELOEOHJEOF.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private bool[] HOADEPKJDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<JELOEOHJEOF> HFLEADMLEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeArray<float> OPDPMFKMLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeArray<int> GLAOIIKKNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private NativeArray<int> NBBELLAODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private NativeArray<int> HFBBFJABELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private NativeArray<int> BMGJILDLPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private NativeArray<int> CLMDLPIGOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private PAIEGLCKHCL[] IOAOPDMNHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private EBNOENMKLPI[] PBDJPBKPEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private FMLFHMDEAFL[] BLOBKAMGELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private IEnumerator<OLKFKAFMJCO>[] IIALGOGFBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private OLKFKAFMJCO[] FAAJKHFEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int EBJEEOFAOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int JNGKGNOBDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly int BNMNOFALCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private float JGEAFAAOEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private LCFEAODGCLM HJEJMOGLHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private JobHandle DHAFHCBHKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private List<PAIEGLCKHCL> LMIKLNDIMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool PFOHKOMFIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private List<Action> MECLKIPIGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private List<Action> KNBPPECBMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool MDGIGHDAKFN;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NMNAIBBBKGP[] OMIMOHOFJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x13249A0", Offset = "0x13237A0", VA = "0x1813249A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x598C920", Offset = "0x598B720", VA = "0x18598C920")]
	private static int LKFGBELBPFM(HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x598D100", Offset = "0x598BF00", VA = "0x18598D100")]
	public JNGPDABHOGG(HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x598C600", Offset = "0x598B400", VA = "0x18598C600")]
	private void JOONBLEPCGN(ref int LMBCKLMJEOK, int GJPPBHMGBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x598CC90", Offset = "0x598BA90", VA = "0x18598CC90")]
	public void MDAMJDLONKA(FMLFHMDEAFL IJBJKIBEJLN, OLKFKAFMJCO IKEPIAIKEJH, IEnumerator<OLKFKAFMJCO> IPNDPOFCJMA, EBNOENMKLPI MDMLEAMEPOH, [Optional] PAIEGLCKHCL BGHOCNPKKKB, JELOEOHJEOF JKKGHHCBKMF = JELOEOHJEOF.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x598CE10", Offset = "0x598BC10", VA = "0x18598CE10")]
	public void NDBILFDGAPJ(IEnumerable<HGNGFABHAMI> DDIEJMIKFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x598BB70", Offset = "0x598A970", VA = "0x18598BB70")]
	private HGNGFABHAMI HNELOJOKLAD(int BMFEBENNDDE)
	{
		return default(HGNGFABHAMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x598C080", Offset = "0x598AE80", VA = "0x18598C080")]
	private void IOLLLFCBPDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x16434B0", Offset = "0x16422B0", VA = "0x1816434B0")]
	private static void EEACHJDALGD<T>(int BMFEBENNDDE, T[] JLJLNCPFOPK, int MKGODNJCKOC, [Optional] T GIDGDJHMCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x1643490", Offset = "0x1642290", VA = "0x181643490")]
	private static void EEACHJDALGD<T>(int BMFEBENNDDE, NativeArray<T> JLJLNCPFOPK, int MKGODNJCKOC, [Optional] T GIDGDJHMCIM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x598B7F0", Offset = "0x598A5F0", VA = "0x18598B7F0")]
	private void GNKPCCKGAAL(IEnumerable<HGNGFABHAMI> DDIEJMIKFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x598BAA0", Offset = "0x598A8A0", VA = "0x18598BAA0")]
	private void HAGMDKJKPNM(HGNGFABHAMI BOJPDPBNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x598C9D0", Offset = "0x598B7D0", VA = "0x18598C9D0")]
	private NIBKOGHKMIG MBHDBMGOAKI(int FPFPMCOECCE)
	{
		return default(NIBKOGHKMIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x598C420", Offset = "0x598B220", VA = "0x18598C420")]
	public void JBCLBFFJHNG(float NLBFPPDGBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x598C950", Offset = "0x598B750", VA = "0x18598C950")]
	private void LLLNDALGPDL(Action GCKGDDMIIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x598B640", Offset = "0x598A440", VA = "0x18598B640")]
	private void GAEGNAAMNCE(Action GCKGDDMIIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x598ADE0", Offset = "0x5989BE0", VA = "0x18598ADE0")]
	public void AIDHAHMJFKA(float NLBFPPDGBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x598D000", Offset = "0x598BE00", VA = "0x18598D000")]
	public void NFGECJODELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x598B6C0", Offset = "0x598A4C0", VA = "0x18598B6C0")]
	public void GEKMIDEDNJD(PAIEGLCKHCL HIMCNNCGFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x598C7F0", Offset = "0x598B5F0", VA = "0x18598C7F0")]
	public void JPDIKLAPKIF(PAIEGLCKHCL HIMCNNCGFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x598B510", Offset = "0x598A310", VA = "0x18598B510")]
	public void DLNLNEMKJCM(PAIEGLCKHCL HIMCNNCGFHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class KNEFCLCMLFN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly KNEFCLCMLFN KLPFABJKKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly Action KFHMBDLJFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private bool OCJGGEPKHAO;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	public KNEFCLCMLFN(Action KFHMBDLJFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x598DD10", Offset = "0x598CB10", VA = "0x18598DD10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface PEPLPCMPGHK<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	T KCKILJPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable FLJMNLNAPJA(UnityEngine.Object IJBJKIBEJLN, Action<T> GOMFKDEKLOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface EIOHEPDJMPK<T> : global::PEPLPCMPGHK<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	new T KCKILJPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class OBIJHNJNOCJ<T> : global::EIOHEPDJMPK<T>, global::PEPLPCMPGHK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class CLPBPBKKJJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public global::OBIJHNJNOCJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public global::NNDIPDGGNAB<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public CLPBPBKKJJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x2DCADE0", Offset = "0x2DC9BE0", VA = "0x182DCADE0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static GameObject OMDCHOGCLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly List<global::NNDIPDGGNAB<UnityEngine.Object, Action<T>>> MHELLNEMIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private T OCNELDAFJIL;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T KCKILJPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x75BA60", Offset = "0x75A860", VA = "0x18075BA60", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2C52EC0", Offset = "0x2C51CC0", VA = "0x182C52EC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C53970", Offset = "0x2C52770", VA = "0x182C53970")]
	private static bool HPNMHEFLGIJ(T GCKGDDMIIDO, T EJKHFJILHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C539D0", Offset = "0x2C527D0", VA = "0x182C539D0")]
	public OBIJHNJNOCJ(T BIFNOKICKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2C53660", Offset = "0x2C52460", VA = "0x182C53660", Slot = "6")]
	public IDisposable FLJMNLNAPJA(UnityEngine.Object IJBJKIBEJLN, Action<T> GOMFKDEKLOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2C53300", Offset = "0x2C52100", VA = "0x182C53300")]
	private void DBBCONHIPCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class AMMAOHJCLOH : CLHIBMKHEGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly KDDJAPJLMJH ICLJGLHGBOE;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x597E9D0", Offset = "0x597D7D0", VA = "0x18597E9D0")]
	[CFDOMFEMHNO(ANAFFCEINAM.None)]
	private static void PEBFIEIHMDK(GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	[Preserve]
	internal AMMAOHJCLOH([HDMGOABMPFL(null)] KDDJAPJLMJH ICLJGLHGBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x597E930", Offset = "0x597D730", VA = "0x18597E930", Slot = "4")]
	public IDisposable JPFJGMNPGEL(float NHKNKHBEEBN, Action<float> FNIOCOFMFAB, bool EFAIFLDLDBG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[BurstCompile]
internal struct LCFEAODGCLM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	public float CKLNJAMEDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	public int PLFPIMGKHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private NativeArray<int> GLJMDKAAEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private NativeArray<int> BJLIAIOBLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private NativeArray<int> LLKICOPELAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[ReadOnly]
	public NativeArray<JELOEOHJEOF> IKNMLJGKGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	public NativeArray<float> MILNBJHJLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[WriteOnly]
	public NativeArray<int> HFBBFJABELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[WriteOnly]
	public NativeArray<int> GLAOIIKKNAI;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x598E180", Offset = "0x598CF80", VA = "0x18598E180")]
	public static LCFEAODGCLM CJALKNOJAHB(int FIELMLAJBON, float NLBFPPDGBCE, NativeArray<JELOEOHJEOF> AJEFGFIFDAM, NativeArray<float> BAPPAEPNPLN, NativeArray<int> EOLOCMGHLID, NativeArray<int> NBCEFPMBOJO, NativeArray<int> MMHIMONHDIG, NativeArray<int> BJLIAIOBLBM, NativeArray<int> LLKICOPELAD)
	{
		return default(LCFEAODGCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x598E1E0", Offset = "0x598CFE0", VA = "0x18598E1E0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x598E320", Offset = "0x598D120", VA = "0x18598E320")]
	private bool FLLAOIKLNFB(int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x598E660", Offset = "0x598D460", VA = "0x18598E660")]
	private void OJBIPIHMJBL(NativeArray<int> MKJCGGFKKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x598E2C0", Offset = "0x598D0C0", VA = "0x18598E2C0")]
	private int FGHJKEHIAIA(int BOCLHPGGFGL, int FAFPBNLMLIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x598E590", Offset = "0x598D390", VA = "0x18598E590")]
	private void OIALOIFGKFC(NativeArray<int> MKJCGGFKKOF, int DEDKHJMMIEL, int AIIJMECGAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x598E360", Offset = "0x598D160", VA = "0x18598E360")]
	private void HAIFEPEPPAM(NativeArray<int> MKJCGGFKKOF, int NAJBNNJDLBF, int AONJEKMDGEL, int CHGPENNIGOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class NMIEPFKKGEM : HBCOIJJMMCJ, KDDJAPJLMJH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private JNGPDABHOGG[] JLFAMIPEGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private NOJIALEGMNH HHBEMELFPFG;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5993D90", Offset = "0x5992B90", VA = "0x185993D90")]
	[CFDOMFEMHNO(ANAFFCEINAM.None)]
	private static void PEBFIEIHMDK(GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5993E00", Offset = "0x5992C00", VA = "0x185993E00")]
	[Preserve]
	public NMIEPFKKGEM([HDMGOABMPFL(null)] JKFABJNLKME EKKKKGILECJ, [HDMGOABMPFL(null)] MNMLMKFIJMC GNEJOAKKEAA, [HDMGOABMPFL(null)] BOPJIADLCDP LECNCOLGLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5993370", Offset = "0x5992170", VA = "0x185993370", Slot = "12")]
	public override LGJHLMJKIJM FACIBFCBHJN(FMLFHMDEAFL IJBJKIBEJLN, IEnumerator<OLKFKAFMJCO> ANNGNKOEMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5993730", Offset = "0x5992530", VA = "0x185993730", Slot = "13")]
	public override void JJEDLPKLPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5993A10", Offset = "0x5992810", VA = "0x185993A10", Slot = "15")]
	public override void KDFCBMBKNKJ(HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x59934B0", Offset = "0x59922B0", VA = "0x1859934B0", Slot = "14")]
	protected override void FPKIEKJDLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5993D50", Offset = "0x5992B50", VA = "0x185993D50")]
	private JNGPDABHOGG ODHPLCNGIJP(HNIOIOPPNAO.MPMODPADNDL LEDIIMFEFLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5993BF0", Offset = "0x59929F0", VA = "0x185993BF0", Slot = "16")]
	internal override NOBKMPIMMKC OAHCDMFIJNF(IEnumerator<OLKFKAFMJCO> ANNGNKOEMKN, Behaviour IJBJKIBEJLN, EBNOENMKLPI MDMLEAMEPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x59936C0", Offset = "0x59924C0", VA = "0x1859936C0", Slot = "17")]
	internal override LHFABNCFFME IBPOBJMIOOM(HNIOIOPPNAO.MPMODPADNDL GAGLCOBIACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5993590", Offset = "0x5992390", VA = "0x185993590")]
	private void HIFANJHBNAE(JNGPDABHOGG GKMCNHFKJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5993300", Offset = "0x5992100", VA = "0x185993300", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class HBCOIJJMMCJ : KDDJAPJLMJH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly JKFABJNLKME EKKKKGILECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	protected readonly MNMLMKFIJMC GNEJOAKKEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly BOPJIADLCDP LECNCOLGLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private LHFABNCFFME[] JBPHKHJKGGI;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static KDDJAPJLMJH NHLDGJJELOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5988730", Offset = "0x5987530", VA = "0x185988730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static bool PBGELHMIIFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public HNIOIOPPNAO.MPMODPADNDL JGIGCOPNFMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x740040", Offset = "0x73EE40", VA = "0x180740040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(HNIOIOPPNAO.MPMODPADNDL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7620C0", Offset = "0x760EC0", VA = "0x1807620C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MNMLMKFIJMC LDHBJGFGABN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5988040", Offset = "0x5986E40", VA = "0x185988040")]
	public static LGJHLMJKIJM GMPPLOFIHCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x59887E0", Offset = "0x59875E0", VA = "0x1859887E0")]
	[Preserve]
	protected HBCOIJJMMCJ([HDMGOABMPFL(null)] JKFABJNLKME EKKKKGILECJ, [HDMGOABMPFL(null)] MNMLMKFIJMC GNEJOAKKEAA, [HDMGOABMPFL(null)] BOPJIADLCDP LECNCOLGLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5987DC0", Offset = "0x5986BC0", VA = "0x185987DC0", Slot = "6")]
	public LGJHLMJKIJM ECBHNDAKKOH(IEnumerator<OLKFKAFMJCO> ANNGNKOEMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5987DD0", Offset = "0x5986BD0", VA = "0x185987DD0", Slot = "7")]
	public LGJHLMJKIJM ECBHNDAKKOH(Behaviour IJBJKIBEJLN, IEnumerator<OLKFKAFMJCO> ANNGNKOEMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract LGJHLMJKIJM FACIBFCBHJN(FMLFHMDEAFL IJBJKIBEJLN, IEnumerator<OLKFKAFMJCO> ANNGNKOEMKN);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x59882B0", Offset = "0x59870B0", VA = "0x1859882B0", Slot = "13")]
	public virtual void JJEDLPKLPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5988780", Offset = "0x5987580", VA = "0x185988780", Slot = "9")]
	public void PIPEGMDNLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5988000", Offset = "0x5986E00", VA = "0x185988000", Slot = "14")]
	protected virtual void FPKIEKJDLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5988490", Offset = "0x5987290", VA = "0x185988490")]
	private void KDEMPONNLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x59879E0", Offset = "0x59867E0", VA = "0x1859879E0")]
	private void BDEIHDGCLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5988020", Offset = "0x5986E20", VA = "0x185988020")]
	private void GHJGFBNGBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5988710", Offset = "0x5987510", VA = "0x185988710")]
	private void MFNDAPMLNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5987A20", Offset = "0x5986820", VA = "0x185987A20")]
	private void DAGLANKCGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x59886F0", Offset = "0x59874F0", VA = "0x1859886F0")]
	private void LHGONOODCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5987A00", Offset = "0x5986800", VA = "0x185987A00")]
	private void CHBBJGBINEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x59884B0", Offset = "0x59872B0", VA = "0x1859884B0", Slot = "15")]
	public virtual void KDFCBMBKNKJ(HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x59880E0", Offset = "0x5986EE0", VA = "0x1859880E0")]
	private void HLMKLMBPHBI(LHFABNCFFME GKMCNHFKJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0xC255E0", Offset = "0xC243E0", VA = "0x180C255E0")]
	private LHFABNCFFME NIMNJBENELB(HNIOIOPPNAO.MPMODPADNDL LEDIIMFEFLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract NOBKMPIMMKC OAHCDMFIJNF(IEnumerator<OLKFKAFMJCO> ANNGNKOEMKN, Behaviour LDKOGEKLCJM, EBNOENMKLPI FDFNJHLFEAA);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract LHFABNCFFME IBPOBJMIOOM(HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5987A40", Offset = "0x5986840", VA = "0x185987A40", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class NOBKMPIMMKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly EBNOENMKLPI MDMLEAMEPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly KIIMNOKIKAC IJBJKIBEJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool AJGHDIJMHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private string ICIEGOLHGJN;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IEnumerator<OLKFKAFMJCO> DFIBPFCKBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public OLKFKAFMJCO LHLBCKIOAJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7612D0", Offset = "0x7600D0", VA = "0x1807612D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool LMFLEJIKNAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5994430", Offset = "0x5993230", VA = "0x185994430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EKOBGNOCEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8F4C00", Offset = "0x8F3A00", VA = "0x1808F4C00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xAD3C50", Offset = "0xAD2A50", VA = "0x180AD3C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string JAGOKEMFLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5993F50", Offset = "0x5992D50", VA = "0x185993F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public float APBIEHANLFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x154C1F0", Offset = "0x154AFF0", VA = "0x18154C1F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x16CBD00", Offset = "0x16CAB00", VA = "0x1816CBD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5994590", Offset = "0x5993390", VA = "0x185994590")]
	public NOBKMPIMMKC(IEnumerator<OLKFKAFMJCO> IPNDPOFCJMA, KIIMNOKIKAC IJBJKIBEJLN, EBNOENMKLPI MDMLEAMEPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x59940E0", Offset = "0x5992EE0", VA = "0x1859940E0")]
	public OLKFKAFMJCO KJKANIODKMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x59943C0", Offset = "0x59931C0", VA = "0x1859943C0")]
	public bool PIEAKHAGHEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5993ED0", Offset = "0x5992CD0", VA = "0x185993ED0")]
	public void GEKMIDEDNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x59944B0", Offset = "0x59932B0", VA = "0x1859944B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x156C400", Offset = "0x156B200", VA = "0x18156C400")]
	[CompilerGenerated]
	private void LOGEPADCLIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class EBNOENMKLPI : HMOIJJCHILN, LGJHLMJKIJM, BMBBAPOFAOP, PONAFBMJJFC, IEnumerator, OLKFKAFMJCO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private HNIOIOPPNAO.MPMODPADNDL MNNKFADEAHN;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private HNIOIOPPNAO.MPMODPADNDL IEBPCMAOPBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7FCC10", Offset = "0x7FBA10", VA = "0x1807FCC10", Slot = "23")]
		get
		{
			return default(HNIOIOPPNAO.MPMODPADNDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public HNIOIOPPNAO.MPMODPADNDL MFLAGNNDNEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xA93840", Offset = "0xA92640", VA = "0x180A93840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float JMBFKDFLGKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x11A9230", Offset = "0x11A8030", VA = "0x1811A9230", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool FIFCMANKPJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5985030", Offset = "0x5983E30", VA = "0x185985030", Slot = "24")]
	private bool GIBDOFHONDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5985020", Offset = "0x5983E20", VA = "0x185985020", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5985050", Offset = "0x5983E50", VA = "0x185985050")]
	public EBNOENMKLPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal enum NIBKOGHKMIG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class LHFABNCFFME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum FKKPBKHLLAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public struct OPKCBKCPNKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public HNIOIOPPNAO.MPMODPADNDL KGPGOKKAOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public FKKPBKHLLAB GGNAHOACFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public List<NOBKMPIMMKC> EGFJMHEBDBH;
	}

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static readonly FKKPBKHLLAB[] AJKADBBLLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool OCEGCINAFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly NOBKMPIMMKC[] LIHFPGNBBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly List<NOBKMPIMMKC> LCFHDKJAGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly Stack<int> HJJHNIJGGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly List<NOBKMPIMMKC> KGFIGIEOBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Stack<int> KPKOOFAKGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly NOJIALEGMNH LACJJAHKALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private bool MDGIGHDAKFN;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public OPKCBKCPNKL[,] FPPAJLDJAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7400D0", Offset = "0x73EED0", VA = "0x1807400D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x598FB10", Offset = "0x598E910", VA = "0x18598FB10")]
	public LHFABNCFFME(HNIOIOPPNAO.MPMODPADNDL GAGLCOBIACG, NOJIALEGMNH LACJJAHKALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x598EE40", Offset = "0x598DC40", VA = "0x18598EE40")]
	public void HIADGELMHCJ(NOBKMPIMMKC IPNDPOFCJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x598EF60", Offset = "0x598DD60", VA = "0x18598EF60")]
	public void JGDEBJLMMIP(IList<NOBKMPIMMKC> BMDLIAGHHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x598E7D0", Offset = "0x598D5D0", VA = "0x18598E7D0")]
	public void EDEOMLLBEJO(IList<NOBKMPIMMKC> BMDLIAGHHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x598ED40", Offset = "0x598DB40", VA = "0x18598ED40")]
	private void HFANJDGBBKO(NOBKMPIMMKC IPNDPOFCJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x598F880", Offset = "0x598E680", VA = "0x18598F880")]
	private void PNKEJBHHHOL(IList<NOBKMPIMMKC> BMDLIAGHHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x598EBE0", Offset = "0x598D9E0", VA = "0x18598EBE0")]
	private NIBKOGHKMIG GPGBAAHOLIN(NOBKMPIMMKC IPNDPOFCJMA)
	{
		return default(NIBKOGHKMIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x598EAA0", Offset = "0x598D8A0", VA = "0x18598EAA0")]
	public void FPKIEKJDLAL(float NLBFPPDGBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x598F670", Offset = "0x598E470", VA = "0x18598F670")]
	public void PIPEGMDNLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x598F350", Offset = "0x598E150", VA = "0x18598F350")]
	private void OPNDEICIJAK(List<NOBKMPIMMKC> BMDLIAGHHGE, Stack<int> MBMFKFDEKKE, bool MNNMKJHBAJG, float EIJDBDJIKPB = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x598E690", Offset = "0x598D490", VA = "0x18598E690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x598F230", Offset = "0x598E030", VA = "0x18598F230")]
	private void NIJICCGADAL(List<NOBKMPIMMKC> BMDLIAGHHGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal class OMADKBAMDGO : NOJIALEGMNH
{
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "4")]
	public void BKFICDJOGPC(string ICIEGOLHGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
	public void FPEPJILJLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public OMADKBAMDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal class LIMNJCNOIMA : KIIMNOKIKAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Behaviour LDKOGEKLCJM;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public string JAGOKEMFLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5990000", Offset = "0x598EE00", VA = "0x185990000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool MFIKILBBBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5990090", Offset = "0x598EE90", VA = "0x185990090", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool NCDCHINIGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x598FFE0", Offset = "0x598EDE0", VA = "0x18598FFE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	public LIMNJCNOIMA(Behaviour LDKOGEKLCJM)
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

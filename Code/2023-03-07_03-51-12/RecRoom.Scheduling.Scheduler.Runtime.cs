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
public class PLNGHDKDMIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority AANPPJOEGKJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x58A5FB0", Offset = "0x58A53B0", VA = "0x1858A5FB0")]
	public PLNGHDKDMIG(ThreadPriority NEMBGDJDHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x58A5FA0", Offset = "0x58A53A0", VA = "0x1858A5FA0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> EIBODNNJCBP(List<PlayerLoopSystem> EIINEJPEGBG, int DKOIPILACDA);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct MKIKMCEEGDO
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct GNDHAGHJKMC
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static EKMBIMLBDEI HKKKCONLGCF;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x589BB90", Offset = "0x589AF90", VA = "0x18589BB90")]
				public static PlayerLoopSystem ONGKNNLKPCJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct GPJFIPCGCGK
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static EKMBIMLBDEI IBKAKBCOICD;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x589BD70", Offset = "0x589B170", VA = "0x18589BD70")]
				public static PlayerLoopSystem ONGKNNLKPCJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct ILHOIFLLDBO
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static EKMBIMLBDEI BNHIAIPDLKA;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x589C340", Offset = "0x589B740", VA = "0x18589C340")]
				public static PlayerLoopSystem ONGKNNLKPCJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct BPGJFLOKJLN
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static EKMBIMLBDEI EKLHPMNEJEO;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static EKMBIMLBDEI PGIDNPHJPIP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static EKMBIMLBDEI BGMOCIHBEBE;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static EKMBIMLBDEI NHMKJNLEAAP;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x5894640", Offset = "0x5893A40", VA = "0x185894640")]
				public static PlayerLoopSystem ONGKNNLKPCJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct BDDONBJNHBN
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static EKMBIMLBDEI BIJFLBCCBJK;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5891B50", Offset = "0x5890F50", VA = "0x185891B50")]
				public static PlayerLoopSystem ONGKNNLKPCJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct JJIMHCBEPJO
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static EKMBIMLBDEI EKLHPMNEJEO;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static EKMBIMLBDEI PGIDNPHJPIP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static EKMBIMLBDEI BGMOCIHBEBE;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static EKMBIMLBDEI NHMKJNLEAAP;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x589C9D0", Offset = "0x589BDD0", VA = "0x18589C9D0")]
				public static PlayerLoopSystem ONGKNNLKPCJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct CCKDMKGDCCI
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static EKMBIMLBDEI LKNAGGDJCKB;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x5894CB0", Offset = "0x58940B0", VA = "0x185894CB0")]
				public static PlayerLoopSystem ONGKNNLKPCJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct HEEJENPFBPA
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static EKMBIMLBDEI IIEMDEIPCAC;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x589C160", Offset = "0x589B560", VA = "0x18589C160")]
				public static PlayerLoopSystem ONGKNNLKPCJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct PHNPPDNOIPM
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static EKMBIMLBDEI INELPDLJOMD;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x58A5610", Offset = "0x58A4A10", VA = "0x1858A5610")]
				public static PlayerLoopSystem ONGKNNLKPCJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct FGELCENKOAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static EKMBIMLBDEI LDHMFKEOPLO;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x589AAD0", Offset = "0x5899ED0", VA = "0x18589AAD0")]
				public static PlayerLoopSystem ONGKNNLKPCJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct OAIJFHCFLAH
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static EKMBIMLBDEI NNAAMMKNGNK;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x58A2210", Offset = "0x58A1610", VA = "0x1858A2210")]
				public static PlayerLoopSystem ONGKNNLKPCJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct HCGPHMENJPG
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class PLJKDPKMDKO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public GIODHPLJCDC.NLKCPHLHHLP key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
					public PLJKDPKMDKO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x58A5D30", Offset = "0x58A5130", VA = "0x1858A5D30")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable KEBNLGKIMDP;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x589BF50", Offset = "0x589B350", VA = "0x18589BF50")]
				public static PlayerLoopSystem PBCBNNAGNCN(GIODHPLJCDC.NLKCPHLHHLP NPBDKCONLNC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct MOPJKFJDGEG
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class FBKLMLHKLJB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002E")]
					public GIODHPLJCDC.NLKCPHLHHLP key;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
					public FBKLMLHKLJB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x5899690", Offset = "0x5898A90", VA = "0x185899690")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x58A07C0", Offset = "0x589FBC0", VA = "0x1858A07C0")]
				public static PlayerLoopSystem PBCBNNAGNCN(GIODHPLJCDC.NLKCPHLHHLP NPBDKCONLNC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class BMCMHEEKHEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public BMCMHEEKHEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x58935F0", Offset = "0x58929F0", VA = "0x1858935F0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KAPJFGMNFGJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool JJCJCDKJEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x58983C0", Offset = "0x58977C0", VA = "0x1858983C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5897AB0", Offset = "0x5896EB0", VA = "0x185897AB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5895660", Offset = "0x5894A60", VA = "0x185895660")]
		private static void DIOFJBPHAPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5897AF0", Offset = "0x5896EF0", VA = "0x185897AF0")]
		private static void LOENGGPJPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5898400", Offset = "0x5897800", VA = "0x185898400")]
		private static void PMGMKNGGPOC(string DGCHFHDKNAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5895300", Offset = "0x5894700", VA = "0x185895300")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5897500", Offset = "0x5896900", VA = "0x185897500")]
		private static void ENONKGNMCFH(GIODHPLJCDC.NLKCPHLHHLP NPBDKCONLNC, ref PlayerLoopSystem DHONJCAKHHJ, Type MGBHLMMBBGC, Type JOELPGMCNCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x58976C0", Offset = "0x5896AC0", VA = "0x1858976C0")]
		private static void EOMFDJPGNGF(ref PlayerLoopSystem DHONJCAKHHJ, Type MGBHLMMBBGC, Type JOELPGMCNCH, EIBODNNJCBP LNHPAKJEPBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5895530", Offset = "0x5894930", VA = "0x185895530")]
		private static void CPAEBEPNDBG(ref PlayerLoopSystem DHONJCAKHHJ, Type MGBHLMMBBGC, Type JOELPGMCNCH, PlayerLoopSystem? ODFKKDEMPHI, PlayerLoopSystem? FFIBGJCHPEF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class GIODHPLJCDC
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum NLKCPHLHHLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class KCBHFLFDBCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly NLKCPHLHHLP DPOBJJNOKGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly EBEGKBONKLL AAPNMELOCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long LKBOGPLMEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long ONDACOILJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long HDHENFMHEKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int MEFNJFJELDK;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x589DBF0", Offset = "0x589CFF0", VA = "0x18589DBF0")]
		public KCBHFLFDBCH(NLKCPHLHHLP JDOAPBCCPJG, int PDGOBIAPKIK = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x589D980", Offset = "0x589CD80", VA = "0x18589D980")]
		public void HLFCEFPBJPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x589D920", Offset = "0x589CD20", VA = "0x18589D920")]
		public void ECKIOGAAJKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x589D9F0", Offset = "0x589CDF0", VA = "0x18589D9F0")]
		public void OINEOJIHBCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static NLKCPHLHHLP[] CIPAMAABPMJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static KCBHFLFDBCH[] CCNGGCHCNLF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x589B720", Offset = "0x589AB20", VA = "0x18589B720")]
	public static KCBHFLFDBCH JGJOBLDDLGG(NLKCPHLHHLP NPBDKCONLNC, int PDGOBIAPKIK = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x589B9A0", Offset = "0x589ADA0", VA = "0x18589B9A0")]
	public static KCBHFLFDBCH PGGMLEKHBDF(NLKCPHLHHLP NPBDKCONLNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x589B8F0", Offset = "0x589ACF0", VA = "0x18589B8F0")]
	public static void JOAOKIJLOOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EBEGKBONKLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int GBIFEONJMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Queue<double> GDMADLELLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double NEOBGLMFFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double OKNLCAAGMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double IHBCJCIFDNE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double MJKCCPBJALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5898A70", Offset = "0x5897E70", VA = "0x185898A70", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5898B40", Offset = "0x5897F40", VA = "0x185898B40")]
	public EBEGKBONKLL(int OHHCJDMCAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5898940", Offset = "0x5897D40", VA = "0x185898940", Slot = "4")]
	public void GIANIHJGEHI(double MMHJJFKDNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5898AD0", Offset = "0x5897ED0", VA = "0x185898AD0", Slot = "5")]
	public void LMINFOAGFJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class AKKFOGDEEII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private long NDNADCNCIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double MFFPAPLGENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double GFMDEDIHBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private double GELELODNGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private double DIJNNKJLKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private double NEOBGLMFFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private double OKNLCAAGMLN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double FFNDANDEHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4110EF0", Offset = "0x41102F0", VA = "0x184110EF0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double KHBGAPOLKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xED74B0", Offset = "0xED68B0", VA = "0x180ED74B0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double KBGIOHCAIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8D27F0", Offset = "0x8D1BF0", VA = "0x1808D27F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double MJKCCPBJALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9EC7E0", Offset = "0x9EBBE0", VA = "0x1809EC7E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5890FE0", Offset = "0x58903E0", VA = "0x185890FE0", Slot = "7")]
	public virtual void GIANIHJGEHI(double MMHJJFKDNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5891110", Offset = "0x5890510", VA = "0x185891110", Slot = "8")]
	public virtual void LMINFOAGFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5891150", Offset = "0x5890550", VA = "0x185891150")]
	public AKKFOGDEEII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JMAKDCFOILI : AKKFOGDEEII
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double KBAGFNEMAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x589CC60", Offset = "0x589C060", VA = "0x18589CC60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x589CDF0", Offset = "0x589C1F0", VA = "0x18589CDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x589CC70", Offset = "0x589C070", VA = "0x18589CC70", Slot = "7")]
	public override void GIANIHJGEHI(double MMHJJFKDNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x589CDB0", Offset = "0x589C1B0", VA = "0x18589CDB0", Slot = "8")]
	public override void LMINFOAGFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5891150", Offset = "0x5890550", VA = "0x185891150")]
	public JMAKDCFOILI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class NGALPOKKCOM
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private interface MOOGOLIJFKM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool EOMLHEIHKPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ENDFAGEBOAN();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private abstract class OHLCLGJGEBN<TPromise, TMainThreadPromise> : MOOGOLIJFKM where TPromise : NDNJBANLHJC where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly TPromise EHIJAKLEDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected readonly TMainThreadPromise GDGKJMIFKFP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public TPromise ELLHOBOKBPL
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2CC6FB0", Offset = "0x2CC63B0", VA = "0x182CC6FB0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EOMLHEIHKPN
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x2CC6F60", Offset = "0x2CC6360", VA = "0x182CC6F60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x27EC770", Offset = "0x27EBB70", VA = "0x1827EC770")]
		protected OHLCLGJGEBN(TPromise EHIJAKLEDDO, TMainThreadPromise OLFNCNNKFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2CC6F30", Offset = "0x2CC6330", VA = "0x182CC6F30", Slot = "5")]
		public void ENDFAGEBOAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void AHBIFEKGNKI(TPromise EHIJAKLEDDO);
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class MMPAHKNJGMB<T> : OHLCLGJGEBN<global::HPHDJAFFHCN<T>, global::FEKGIBNPEAH<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x35F6020", Offset = "0x35F5420", VA = "0x1835F6020")]
		public MMPAHKNJGMB(global::HPHDJAFFHCN<T> EHIJAKLEDDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x35F5E90", Offset = "0x35F5290", VA = "0x1835F5E90", Slot = "6")]
		protected override void AHBIFEKGNKI(global::HPHDJAFFHCN<T> EHIJAKLEDDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x35F5FF0", Offset = "0x35F53F0", VA = "0x1835F5FF0")]
		[CompilerGenerated]
		private void DNGMIJHHOJK(T CGKNIAMFPAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2537DC0", Offset = "0x25371C0", VA = "0x182537DC0")]
		[CompilerGenerated]
		private void HDIBLMAEDII(string MCGMECECHJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class GCNNIHJANAB : MOOGOLIJFKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Action EFFJGLADCMH;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool EOMLHEIHKPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x798260", Offset = "0x797660", VA = "0x180798260", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
		public GCNNIHJANAB(Action EFFJGLADCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x19C6EC0", Offset = "0x19C62C0", VA = "0x1819C6EC0", Slot = "5")]
		public void ENDFAGEBOAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly List<MOOGOLIJFKM> LBGNOMCFNNI;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3208240", Offset = "0x3207640", VA = "0x183208240")]
	public static global::HPHDJAFFHCN<T> FKHDJNGNFHK<T>(this global::HPHDJAFFHCN<T> EHIJAKLEDDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x58A0CE0", Offset = "0x58A00E0", VA = "0x1858A0CE0")]
	public static void FKHDJNGNFHK(Action EFFJGLADCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3208180", Offset = "0x3207580", VA = "0x183208180")]
	private static global::HPHDJAFFHCN<T> FDAPOBMNBEB<T>(global::HPHDJAFFHCN<T> EHIJAKLEDDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x58A0D70", Offset = "0x58A0170", VA = "0x1858A0D70")]
	private static void LKJNABOEJKH(MOOGOLIJFKM CLEIHIMOBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x58A08F0", Offset = "0x589FCF0", VA = "0x1858A08F0")]
	private static void CEFGKGIPPPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x58A0BE0", Offset = "0x589FFE0", VA = "0x1858A0BE0")]
	private static void EFEDHILIEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x58A0F70", Offset = "0x58A0370", VA = "0x1858A0F70")]
	private static void NKDOLGDBCFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class PNEIOLEAKNM
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private struct EGAJEONBEPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<Scene> BLEKCFMJMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly string DFHBGAHLFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly LoadSceneMode PAEMKGJOPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly bool BDMEDJAANHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly MIPBMMJKKCH KNJJIICJOLE;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5898D20", Offset = "0x5898120", VA = "0x185898D20")]
		public EGAJEONBEPO(TaskCompletionSource<Scene> EPKNDDMKEEK, string DFHBGAHLFPK, LoadSceneMode PAEMKGJOPLA, bool BDMEDJAANHE, MIPBMMJKKCH KNJJIICJOLE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct FLKFKBOFNNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public MIPBMMJKKCH stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private global::PADKJAANMNM<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x589ACB0", Offset = "0x589A0B0", VA = "0x18589ACB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x589B320", Offset = "0x589A720", VA = "0x18589B320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct LIAGEHFKHFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x589F910", Offset = "0x589ED10", VA = "0x18589F910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JCGCNFCOKPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private EGAJEONBEPO <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x589C610", Offset = "0x589BA10", VA = "0x18589C610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class FLPJBOAFJLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public global::FEKGIBNPEAH<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public FLPJBOAFJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x589B370", Offset = "0x589A770", VA = "0x18589B370")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct BBGLJONHEPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private FLPJBOAFJLO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private MIPBMMJKKCH <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private MIPBMMJKKCH <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5891180", Offset = "0x5890580", VA = "0x185891180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5891B00", Offset = "0x5890F00", VA = "0x185891B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct NLLGLANILKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public MIPBMMJKKCH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private MIPBMMJKKCH <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private MIPBMMJKKCH <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x58A1880", Offset = "0x58A0C80", VA = "0x1858A1880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x58A20C0", Offset = "0x58A14C0", VA = "0x1858A20C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class JIPJDPAMHFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JIPJDPAMHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x589C9A0", Offset = "0x589BDA0", VA = "0x18589C9A0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class NIJJAINJJIC : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private HHHNIDIHMIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public HAAHJPGNIMD onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
		[DebuggerHidden]
		public NIJJAINJJIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x58A1420", Offset = "0x58A0820", VA = "0x1858A1420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x58A10C0", Offset = "0x58A04C0", VA = "0x1858A10C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x58A14B0", Offset = "0x58A08B0", VA = "0x1858A14B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x58A13E0", Offset = "0x58A07E0", VA = "0x1858A13E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class CAHLPEJCEEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public global::FEKGIBNPEAH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public CAHLPEJCEEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class KIEHHPMDPKN : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private HHHNIDIHMIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public global::FEKGIBNPEAH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private CAHLPEJCEEP <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
		[DebuggerHidden]
		public KIEHHPMDPKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x589E500", Offset = "0x589D900", VA = "0x18589E500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x589E950", Offset = "0x589DD50", VA = "0x18589E950", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static NDNJBANLHJC IDEOLFKPGPJ;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AsyncOperation ANPBCLEBGLH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static NDNJBANLHJC BICOIFFNGDA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static string KKEDLMEBIBA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static ThreadPriority FLCJCKNNHNC;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Task CCIEOMEAGAC;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly Queue<EGAJEONBEPO> OHLMCGMNOMB;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task GCIACDKDKID;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool GHIBPEGCOBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x58A6740", Offset = "0x58A5B40", VA = "0x1858A6740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool GAKHNMJFEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x58A6210", Offset = "0x58A5610", VA = "0x1858A6210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private static bool GBLOFGGOFOD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x58A5FF0", Offset = "0x58A53F0", VA = "0x1858A5FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> IBBDNHOBMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x58A62C0", Offset = "0x58A56C0", VA = "0x1858A62C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x58A71C0", Offset = "0x58A65C0", VA = "0x1858A71C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x58A6CD0", Offset = "0x58A60D0", VA = "0x1858A6CD0")]
	[MDHPGGNLEAB(GDPBHGFFFDB.EnteredEditModeNextFrame, 0)]
	private static void KACADJONELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x58A6460", Offset = "0x58A5860", VA = "0x1858A6460")]
	[AsyncStateMachine(typeof(FLKFKBOFNNH))]
	public static Task<Scene> EIPBKMEKEFI(string DFHBGAHLFPK, LoadSceneMode PAEMKGJOPLA = LoadSceneMode.Single, bool BDMEDJAANHE = false, [Optional] MIPBMMJKKCH KNEHLAJFNAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x58A6AA0", Offset = "0x58A5EA0", VA = "0x1858A6AA0")]
	[AsyncStateMachine(typeof(LIAGEHFKHFP))]
	private static Task ICHFJNGNPAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x58A6650", Offset = "0x58A5A50", VA = "0x1858A6650")]
	[AsyncStateMachine(typeof(JCGCNFCOKPJ))]
	private static Task FMMMDLHFOJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x58A6B70", Offset = "0x58A5F70", VA = "0x1858A6B70")]
	[AsyncStateMachine(typeof(BBGLJONHEPM))]
	private static Task<Scene> ILBBJBNEKIP(string DFHBGAHLFPK, LoadSceneMode PAEMKGJOPLA, bool BDMEDJAANHE, MIPBMMJKKCH KNJJIICJOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x58A6DA0", Offset = "0x58A61A0", VA = "0x1858A6DA0")]
	[AsyncStateMachine(typeof(NLLGLANILKG))]
	private static Task<Scene> NFPFHOLFNAO(MIPBMMJKKCH KNJJIICJOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x58A6900", Offset = "0x58A5D00", VA = "0x1858A6900")]
	public static global::HPHDJAFFHCN<Scene> HFKMNMILCAM(string DFHBGAHLFPK, LoadSceneMode PAEMKGJOPLA = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x58A6EE0", Offset = "0x58A62E0", VA = "0x1858A6EE0")]
	public static NDNJBANLHJC PFDOAIMEMOD(string DFHBGAHLFPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x58A65C0", Offset = "0x58A59C0", VA = "0x1858A65C0")]
	[IteratorStateMachine(typeof(NIJJAINJJIC))]
	private static IEnumerator<HHHNIDIHMIA> FBNJCOMPGNE(string DFHBGAHLFPK, HAAHJPGNIMD BFKNOBNFFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x58A63C0", Offset = "0x58A57C0", VA = "0x1858A63C0")]
	[IteratorStateMachine(typeof(KIEHHPMDPKN))]
	private static IEnumerator<HHHNIDIHMIA> EDGHJEEIIOA(string DFHBGAHLFPK, LoadSceneMode PAEMKGJOPLA, global::FEKGIBNPEAH<Scene> BFKNOBNFFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x58A60B0", Offset = "0x58A54B0", VA = "0x1858A60B0")]
	public static bool CNPMBGAOJBD(out string AKDCAFIAFAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class EMAEHDPGOBM
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5898FC0", Offset = "0x58983C0", VA = "0x185898FC0")]
	public static IDisposable LHEGNAHPGGC(this LKCOCDLDCAN OEGBAMNPENI, float DAOMPNKAMLD, Action<float> AOHMGFJIPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5898EC0", Offset = "0x58982C0", VA = "0x185898EC0")]
	public static IDisposable BNHHLFKDCMM(this LKCOCDLDCAN OEGBAMNPENI, Action<float> AOHMGFJIPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5898F40", Offset = "0x5898340", VA = "0x185898F40")]
	public static IDisposable CPPOBGDPGND(this LKCOCDLDCAN OEGBAMNPENI, Action<float> AOHMGFJIPGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class ACBJFJGIGJH
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x58900E0", Offset = "0x588F4E0", VA = "0x1858900E0")]
	public static IDisposable JKGPMEFCICA(this MonoBehaviour GOGAOCOHIBI, Action AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5890060", Offset = "0x588F460", VA = "0x185890060")]
	public static IDisposable JKGPMEFCICA(this MonoBehaviour GOGAOCOHIBI, Action<float> AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5890200", Offset = "0x588F600", VA = "0x185890200")]
	public static IDisposable LOGJNOLNCGE(this MonoBehaviour GOGAOCOHIBI, Action AOHMGFJIPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x588FFE0", Offset = "0x588F3E0", VA = "0x18588FFE0")]
	public static IDisposable IBNFJMIBNMN(this MonoBehaviour GOGAOCOHIBI, Action AOHMGFJIPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5890410", Offset = "0x588F810", VA = "0x185890410")]
	public static IDisposable PLGFJFBAIIN(this MonoBehaviour GOGAOCOHIBI, Action AOHMGFJIPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x588FB50", Offset = "0x588EF50", VA = "0x18588FB50")]
	public static IDisposable AEBJLKABJKD(this MonoBehaviour GOGAOCOHIBI, Action AOHMGFJIPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5890270", Offset = "0x588F670", VA = "0x185890270")]
	public static IDisposable LPJLLDNBDAP(this MonoBehaviour GOGAOCOHIBI, Action AOHMGFJIPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x588FD90", Offset = "0x588F190", VA = "0x18588FD90")]
	public static IDisposable FJFGFLDGHGA(this MonoBehaviour GOGAOCOHIBI, float DAOMPNKAMLD, Action<float> AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG, bool CLPIFMIODCM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x588FBD0", Offset = "0x588EFD0", VA = "0x18588FBD0")]
	public static IDisposable AIGCOJEJKMC(this MonoBehaviour GOGAOCOHIBI, float DAOMPNKAMLD, Action<float> AOHMGFJIPGD, bool CLPIFMIODCM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x588FD00", Offset = "0x588F100", VA = "0x18588FD00")]
	public static IDisposable DBPLIKALAGN(this MonoBehaviour GOGAOCOHIBI, Action<float> AOHMGFJIPGD, bool CLPIFMIODCM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5890490", Offset = "0x588F890", VA = "0x185890490")]
	public static IDisposable PPENLIMNEOH(this MonoBehaviour GOGAOCOHIBI, Action<float> AOHMGFJIPGD, bool CLPIFMIODCM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x588FEC0", Offset = "0x588F2C0", VA = "0x18588FEC0")]
	public static IDisposable GPKPGKEJJLB(this MonoBehaviour GOGAOCOHIBI, Action<float> AOHMGFJIPGD, bool CLPIFMIODCM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x58902F0", Offset = "0x588F6F0", VA = "0x1858902F0")]
	public static IDisposable MODAPAAKNAL(this MonoBehaviour GOGAOCOHIBI, Action<float> AOHMGFJIPGD, bool CLPIFMIODCM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x588FF50", Offset = "0x588F350", VA = "0x18588FF50")]
	public static IDisposable HGHANDHJDEI(this MonoBehaviour GOGAOCOHIBI, Action<float> AOHMGFJIPGD, bool CLPIFMIODCM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x588FC70", Offset = "0x588F070", VA = "0x18588FC70")]
	public static IDisposable BNMEDDPBGJP(this MonoBehaviour GOGAOCOHIBI, Action<float> AOHMGFJIPGD, bool CLPIFMIODCM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5890380", Offset = "0x588F780", VA = "0x185890380")]
	public static IDisposable OBLKNAFOEMC(this MonoBehaviour GOGAOCOHIBI, Action<float> AOHMGFJIPGD, bool CLPIFMIODCM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5890160", Offset = "0x588F560", VA = "0x185890160")]
	public static IDisposable JOGAOLFAOEK(this MonoBehaviour GOGAOCOHIBI, float DAOMPNKAMLD, Action<float> AOHMGFJIPGD, bool CLPIFMIODCM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x588FE30", Offset = "0x588F230", VA = "0x18588FE30")]
	public static IDisposable GOBNHCICODK(this MonoBehaviour GOGAOCOHIBI, Action<float> AOHMGFJIPGD, bool CLPIFMIODCM = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NJEFMBDJENI
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class NOFIJAOGBGA : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private HHHNIDIHMIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public FBAPKPGAINI.CJKALMCHPOC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EIHKDMKIMAN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
		[DebuggerHidden]
		public NOFIJAOGBGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x58A2110", Offset = "0x58A1510", VA = "0x1858A2110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x58A21D0", Offset = "0x58A15D0", VA = "0x1858A21D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EBKHBELOEED : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private HHHNIDIHMIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public FBAPKPGAINI.CJKALMCHPOC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private EIHKDMKIMAN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
		[DebuggerHidden]
		public EBKHBELOEED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5898BF0", Offset = "0x5897FF0", VA = "0x185898BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5898CE0", Offset = "0x58980E0", VA = "0x185898CE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x58A17D0", Offset = "0x58A0BD0", VA = "0x1858A17D0")]
	public static IPHLGHEAMKL JKGPMEFCICA(Action AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x58A1600", Offset = "0x58A0A00", VA = "0x1858A1600")]
	public static IPHLGHEAMKL JKGPMEFCICA(Behaviour OEGBAMNPENI, Action AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x58A16C0", Offset = "0x58A0AC0", VA = "0x1858A16C0")]
	public static IPHLGHEAMKL JKGPMEFCICA(Behaviour OEGBAMNPENI, Action<float> AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x58A1580", Offset = "0x58A0980", VA = "0x1858A1580")]
	[IteratorStateMachine(typeof(NOFIJAOGBGA))]
	private static IEnumerator<HHHNIDIHMIA> CAIPCIDFKOE(FBAPKPGAINI.CJKALMCHPOC BICKJDNHDLM, Action AOHMGFJIPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x58A1500", Offset = "0x58A0900", VA = "0x1858A1500")]
	[IteratorStateMachine(typeof(EBKHBELOEED))]
	private static IEnumerator<HHHNIDIHMIA> CAIPCIDFKOE(FBAPKPGAINI.CJKALMCHPOC BICKJDNHDLM, Action<float> AOHMGFJIPGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LLMHDODAKDF
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class DGDCMDHEEEE : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private HHHNIDIHMIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public KPHGPBAAKFB schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public FBAPKPGAINI.CJKALMCHPOC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private DBNDGBFENBA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
		[DebuggerHidden]
		public DGDCMDHEEEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5898730", Offset = "0x5897B30", VA = "0x185898730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5898870", Offset = "0x5897C70", VA = "0x185898870", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x589FDD0", Offset = "0x589F1D0", VA = "0x18589FDD0")]
	public static IPHLGHEAMKL JKGPMEFCICA(float DAOMPNKAMLD, Action<float> AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG, bool CLPIFMIODCM = true, [Optional] LNALHCPHCLJ CGMMAAPBPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x589FCC0", Offset = "0x589F0C0", VA = "0x18589FCC0")]
	public static IPHLGHEAMKL JKGPMEFCICA(MonoBehaviour GOGAOCOHIBI, float DAOMPNKAMLD, Action<float> AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG, bool CLPIFMIODCM = true, [Optional] LNALHCPHCLJ CGMMAAPBPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x589FED0", Offset = "0x589F2D0", VA = "0x18589FED0")]
	public static IPHLGHEAMKL KOBGJJJPKGI(LKCOCDLDCAN OEGBAMNPENI, float DAOMPNKAMLD, Action<float> AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG, bool CLPIFMIODCM = true, [Optional] LNALHCPHCLJ CGMMAAPBPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x589FC10", Offset = "0x589F010", VA = "0x18589FC10")]
	[IteratorStateMachine(typeof(DGDCMDHEEEE))]
	private static IEnumerator<HHHNIDIHMIA> CAIPCIDFKOE(KPHGPBAAKFB CBCBAJKGEMC, float DAOMPNKAMLD, FBAPKPGAINI.CJKALMCHPOC BICKJDNHDLM, Action<float> AOHMGFJIPGD, bool CLPIFMIODCM = true, [Optional] LNALHCPHCLJ CGMMAAPBPCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class AEFOENIEHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class JAHHMNDHJME : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private HHHNIDIHMIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public FBAPKPGAINI.CJKALMCHPOC queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
		[DebuggerHidden]
		public JAHHMNDHJME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x589C520", Offset = "0x589B920", VA = "0x18589C520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x589C5D0", Offset = "0x589B9D0", VA = "0x18589C5D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5890520", Offset = "0x588F920", VA = "0x185890520")]
	[IteratorStateMachine(typeof(JAHHMNDHJME))]
	private static IEnumerator<HHHNIDIHMIA> DMHNDOHKBKG(FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG, Func<bool> EPHCJOPEJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x58905A0", Offset = "0x588F9A0", VA = "0x1858905A0")]
	public static IPHLGHEAMKL JEOFIJCCKMI(this MonoBehaviour GOGAOCOHIBI, Func<bool> EPHCJOPEJAM, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG = FBAPKPGAINI.CJKALMCHPOC.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LDOBBGDFCON
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class OEAFPBBLPOO : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private HHHNIDIHMIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public FBAPKPGAINI.CJKALMCHPOC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
		[DebuggerHidden]
		public OEAFPBBLPOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x58A23F0", Offset = "0x58A17F0", VA = "0x1858A23F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x58A24B0", Offset = "0x58A18B0", VA = "0x1858A24B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x589F740", Offset = "0x589EB40", VA = "0x18589F740")]
	[IteratorStateMachine(typeof(OEAFPBBLPOO))]
	private static IEnumerator<HHHNIDIHMIA> OFKPKICDLPI(float KIGCMENMIJC, FBAPKPGAINI.CJKALMCHPOC BICKJDNHDLM, Action BKAPBNHJDFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x589F490", Offset = "0x589E890", VA = "0x18589F490")]
	public static IPHLGHEAMKL GLELICDHOCA(this MonoBehaviour GOGAOCOHIBI, float KIGCMENMIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x589F720", Offset = "0x589EB20", VA = "0x18589F720")]
	public static IPHLGHEAMKL NMIBCPCGEBA(this MonoBehaviour GOGAOCOHIBI, Action BKAPBNHJDFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x589F620", Offset = "0x589EA20", VA = "0x18589F620")]
	public static IPHLGHEAMKL LOKHBMPONMH(this MonoBehaviour GOGAOCOHIBI, Action BKAPBNHJDFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x589F380", Offset = "0x589E780", VA = "0x18589F380")]
	public static IPHLGHEAMKL FPFNPMOHCGG(this MonoBehaviour GOGAOCOHIBI, Action BKAPBNHJDFL, [Optional] LNALHCPHCLJ CGMMAAPBPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x589F460", Offset = "0x589E860", VA = "0x18589F460")]
	public static IPHLGHEAMKL GCFHPGOIGMK(this MonoBehaviour GOGAOCOHIBI, Action BKAPBNHJDFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x589F350", Offset = "0x589E750", VA = "0x18589F350")]
	public static IPHLGHEAMKL EFMHPIOBFNI(this MonoBehaviour GOGAOCOHIBI, Action BKAPBNHJDFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x589F7D0", Offset = "0x589EBD0", VA = "0x18589F7D0")]
	public static IPHLGHEAMKL PHCEGJABAAO(this MonoBehaviour GOGAOCOHIBI, Action BKAPBNHJDFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x589F550", Offset = "0x589E950", VA = "0x18589F550")]
	private static IPHLGHEAMKL LCELEMPLOGD(MonoBehaviour GOGAOCOHIBI, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG, Action BKAPBNHJDFL, [Optional] LNALHCPHCLJ CGMMAAPBPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x589F0E0", Offset = "0x589E4E0", VA = "0x18589F0E0")]
	public static IPHLGHEAMKL ABOOANIKFHD(this MonoBehaviour GOGAOCOHIBI, float FMMBIALMKEP, Action BKAPBNHJDFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x589F280", Offset = "0x589E680", VA = "0x18589F280")]
	public static IPHLGHEAMKL CNECLIIBCAI(this MonoBehaviour GOGAOCOHIBI, float FMMBIALMKEP, Action BKAPBNHJDFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x589F1B0", Offset = "0x589E5B0", VA = "0x18589F1B0")]
	public static IPHLGHEAMKL BNDKBFMPFLG(this MonoBehaviour GOGAOCOHIBI, float FMMBIALMKEP, Action BKAPBNHJDFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x589F650", Offset = "0x589EA50", VA = "0x18589F650")]
	public static IPHLGHEAMKL MELMCMBBKCL(this MonoBehaviour GOGAOCOHIBI, float FMMBIALMKEP, Action BKAPBNHJDFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class AKJCNABBPEO : BCABBJBCICC, IEnumerable<BCABBJBCICC>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly List<BCABBJBCICC> AABGLPDPKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool HEJEAJDAHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Action CLPDOCMBOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool GKJBBFLMMND;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool AFHGCGBGFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5890C90", Offset = "0x5890090", VA = "0x185890C90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GOCABMDILHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5890BF0", Offset = "0x588FFF0", VA = "0x185890BF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5890B50", Offset = "0x588FF50", VA = "0x185890B50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5890F40", Offset = "0x5890340", VA = "0x185890F40")]
	public AKJCNABBPEO([Optional] Action CLPDOCMBOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x58906B0", Offset = "0x588FAB0", VA = "0x1858906B0")]
	public void BKCAAEBNAMB(BCABBJBCICC LGKPDENNEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5890DD0", Offset = "0x58901D0", VA = "0x185890DD0")]
	private void KNAIENKCHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5890B40", Offset = "0x588FF40", VA = "0x185890B40", Slot = "7")]
	public bool IMAHCFIGOIL(bool MGJBBFOJNFN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5890860", Offset = "0x588FC60", VA = "0x185890860", Slot = "8")]
	public bool IMAHCFIGOIL(Action EFFJGLADCMH, bool MGJBBFOJNFN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x58907E0", Offset = "0x588FBE0", VA = "0x1858907E0", Slot = "9")]
	public IEnumerator<BCABBJBCICC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x58907E0", Offset = "0x588FBE0", VA = "0x1858907E0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class KECDNCFHODM : ENIIDMHCIIL
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class JOAKCGCOLDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public KECDNCFHODM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JOAKCGCOLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x58935C0", Offset = "0x58929C0", VA = "0x1858935C0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class BJHFNGLAOHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public KECDNCFHODM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BJHFNGLAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x58935C0", Offset = "0x58929C0", VA = "0x1858935C0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly float KFCMNAMLLHC;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x589E400", Offset = "0x589D800", VA = "0x18589E400")]
	public KECDNCFHODM(Behaviour OEGBAMNPENI, float KFCMNAMLLHC, [Optional] Action CLPDOCMBOJD, [Optional] LNALHCPHCLJ CGMMAAPBPCI, [Optional] KPHGPBAAKFB CBCBAJKGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x589E300", Offset = "0x589D700", VA = "0x18589E300", Slot = "9")]
	protected override bool GKPDFLIJMDA(Action EFFJGLADCMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x589E200", Offset = "0x589D600", VA = "0x18589E200", Slot = "10")]
	protected override bool FHKMCEEBOOD(Action EFFJGLADCMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface BCABBJBCICC
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool AFHGCGBGFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GOCABMDILHA;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IMAHCFIGOIL(bool MGJBBFOJNFN = false);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IMAHCFIGOIL(Action EFFJGLADCMH, bool MGJBBFOJNFN = false);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class ENIIDMHCIIL : BCABBJBCICC
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class GALLLJIKKNN : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private HHHNIDIHMIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ENIIDMHCIIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
		[DebuggerHidden]
		public GALLLJIKKNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x589B4B0", Offset = "0x589A8B0", VA = "0x18589B4B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x589B580", Offset = "0x589A980", VA = "0x18589B580", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Behaviour OEGBAMNPENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action CLPDOCMBOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private COANNBMMJHK HIOMPGLAPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly LNALHCPHCLJ CGMMAAPBPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly KPHGPBAAKFB CBCBAJKGEMC;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AFHGCGBGFCA
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x973220", Offset = "0x972620", VA = "0x180973220", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GOCABMDILHA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5899410", Offset = "0x5898810", VA = "0x185899410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5899370", Offset = "0x5898770", VA = "0x185899370", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5899590", Offset = "0x5898990", VA = "0x185899590")]
	protected ENIIDMHCIIL(Behaviour OEGBAMNPENI, [Optional] Action CLPDOCMBOJD, [Optional] LNALHCPHCLJ CGMMAAPBPCI, [Optional] KPHGPBAAKFB CBCBAJKGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5899310", Offset = "0x5898710", VA = "0x185899310", Slot = "7")]
	public bool IMAHCFIGOIL(bool MGJBBFOJNFN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x58992C0", Offset = "0x58986C0", VA = "0x1858992C0", Slot = "8")]
	public bool IMAHCFIGOIL(Action EFFJGLADCMH, bool MGJBBFOJNFN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GKPDFLIJMDA(Action EFFJGLADCMH);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool FHKMCEEBOOD(Action EFFJGLADCMH);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5899530", Offset = "0x5898930", VA = "0x185899530")]
	protected void LBHBCKHIMGC(Action EFFJGLADCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x58990C0", Offset = "0x58984C0", VA = "0x1858990C0")]
	protected NDNJBANLHJC ICMAMPOPGGO(float LFHMONLDFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5899040", Offset = "0x5898440", VA = "0x185899040")]
	private void CDJAMNNMFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x58994B0", Offset = "0x58988B0", VA = "0x1858994B0")]
	[IteratorStateMachine(typeof(GALLLJIKKNN))]
	private IEnumerator<HHHNIDIHMIA> KLJAPINBLFJ(float LFHMONLDFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5899550", Offset = "0x5898950", VA = "0x185899550")]
	[CompilerGenerated]
	private void NOGDNLFPEOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class CKKLPOHOJDP : ENIIDMHCIIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly float CAKBAMEHNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly int HELJEIKCBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float ELJKOMNJFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly float[] GGJFNAIGKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int MIIDHMEPMME;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5895150", Offset = "0x5894550", VA = "0x185895150")]
	public CKKLPOHOJDP(Behaviour OEGBAMNPENI, float ENOAEHJKHLK, int HELJEIKCBED, [Optional] Action CLPDOCMBOJD, float ELJKOMNJFIL = 0f, [Optional] LNALHCPHCLJ CGMMAAPBPCI, [Optional] KPHGPBAAKFB CBCBAJKGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "9")]
	protected override bool GKPDFLIJMDA(Action EFFJGLADCMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5894E90", Offset = "0x5894290", VA = "0x185894E90", Slot = "10")]
	protected override bool FHKMCEEBOOD(Action EFFJGLADCMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x58950C0", Offset = "0x58944C0", VA = "0x1858950C0")]
	private void NPHMIKPOGLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class KLIAKDNFKKO : ENIIDMHCIIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly float KFCMNAMLLHC;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x589E400", Offset = "0x589D800", VA = "0x18589E400")]
	public KLIAKDNFKKO(Behaviour OEGBAMNPENI, float KFCMNAMLLHC, [Optional] Action CLPDOCMBOJD, [Optional] LNALHCPHCLJ CGMMAAPBPCI, [Optional] KPHGPBAAKFB CBCBAJKGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "9")]
	protected override bool GKPDFLIJMDA(Action EFFJGLADCMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x589E990", Offset = "0x589DD90", VA = "0x18589E990", Slot = "10")]
	protected override bool FHKMCEEBOOD(Action EFFJGLADCMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class OKGNGPKGECN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class FODBAOIAKPK : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private HHHNIDIHMIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
		[DebuggerHidden]
		public FODBAOIAKPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x589B3D0", Offset = "0x589A7D0", VA = "0x18589B3D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x589B470", Offset = "0x589A870", VA = "0x18589B470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private IPHLGHEAMKL KIHKPLEBAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private LKCOCDLDCAN OEGBAMNPENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private Action<float> MFEOEFCKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private float LJMHCLAOGNI;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x58A53A0", Offset = "0x58A47A0", VA = "0x1858A53A0")]
	public OKGNGPKGECN(LKCOCDLDCAN OEGBAMNPENI, float DAOMPNKAMLD, Action<float> AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x58A5020", Offset = "0x58A4420", VA = "0x1858A5020")]
	private void EALFGDNOELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x58A51D0", Offset = "0x58A45D0", VA = "0x1858A51D0")]
	private void JJMJFGLLLNJ(string MCGMECECHJK, Action AGDNNKAPPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x58A5330", Offset = "0x58A4730", VA = "0x1858A5330")]
	[IteratorStateMachine(typeof(FODBAOIAKPK))]
	private IEnumerator<HHHNIDIHMIA> LLHILFBDMIG(Action AGDNNKAPPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x58A4FC0", Offset = "0x58A43C0", VA = "0x1858A4FC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x58A4E10", Offset = "0x58A4210", VA = "0x1858A4E10")]
	[CompilerGenerated]
	private void ANAGBGGPLDC(string EPPMCIFCHBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class BOBDAOADKLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class HCLCFBNINFF : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private HHHNIDIHMIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
		[DebuggerHidden]
		public HCLCFBNINFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x589C080", Offset = "0x589B480", VA = "0x18589C080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x589C120", Offset = "0x589B520", VA = "0x18589C120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private IPHLGHEAMKL KIHKPLEBAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MonoBehaviour GOGAOCOHIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Action AOHMGFJIPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Action<float> MFEOEFCKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private float LJMHCLAOGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool CLPIFMIODCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly LNALHCPHCLJ CGMMAAPBPCI;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5893FA0", Offset = "0x58933A0", VA = "0x185893FA0")]
	public BOBDAOADKLD(MonoBehaviour GOGAOCOHIBI, Action AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG, [Optional] LNALHCPHCLJ CGMMAAPBPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5894400", Offset = "0x5893800", VA = "0x185894400")]
	public BOBDAOADKLD(MonoBehaviour GOGAOCOHIBI, Action<float> AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG, [Optional] LNALHCPHCLJ CGMMAAPBPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x58941A0", Offset = "0x58935A0", VA = "0x1858941A0")]
	public BOBDAOADKLD(MonoBehaviour GOGAOCOHIBI, float DAOMPNKAMLD, Action<float> AOHMGFJIPGD, FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG, bool CLPIFMIODCM = true, [Optional] LNALHCPHCLJ CGMMAAPBPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5893D30", Offset = "0x5893130", VA = "0x185893D30")]
	private void JKGPMEFCICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5893830", Offset = "0x5892C30", VA = "0x185893830")]
	private void DMHBIPOOHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5893A40", Offset = "0x5892E40", VA = "0x185893A40")]
	private void EALFGDNOELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5893C00", Offset = "0x5893000", VA = "0x185893C00")]
	private void JJMJFGLLLNJ(string MCGMECECHJK, Action AGDNNKAPPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5893EA0", Offset = "0x58932A0", VA = "0x185893EA0")]
	[IteratorStateMachine(typeof(HCLCFBNINFF))]
	private IEnumerator<HHHNIDIHMIA> LLHILFBDMIG(Action AGDNNKAPPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x58939E0", Offset = "0x5892DE0", VA = "0x1858939E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x58937A0", Offset = "0x5892BA0", VA = "0x1858937A0")]
	[CompilerGenerated]
	private void CAGBDKJNLDE(string EPPMCIFCHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5893F10", Offset = "0x5893310", VA = "0x185893F10")]
	[CompilerGenerated]
	private void ODBNMLNMFCC(string EPPMCIFCHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5893710", Offset = "0x5892B10", VA = "0x185893710")]
	[CompilerGenerated]
	private void ACMGENBOBEI(string EPPMCIFCHBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[Flags]
internal enum DMMIIHPDJIL : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class EKNHKBEMNFH : KPHGPBAAKFB
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float BJHMKMKOODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5898EA0", Offset = "0x58982A0", VA = "0x185898EA0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float POILLBALEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5898EB0", Offset = "0x58982B0", VA = "0x185898EB0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double JOHLNNHDOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5898E80", Offset = "0x5898280", VA = "0x185898E80", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5898E10", Offset = "0x5898210", VA = "0x185898E10")]
	[KPHLIICFIPJ(OEKFJILJDLM.None)]
	private static void IBABMEFBFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	[Preserve]
	internal EKNHKBEMNFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface ABCFCAGGBDE
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPEBDGKFGJB(string LBEPPIIBMPA);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCKOJPIEKFD();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal interface GHDECHCGAKC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	string LJDFOHKOPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool FDLECAKAGNC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool KLFEDKAAOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class PKPNNDANLKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public OIKFLLPJDHB IAJHJOOKEII;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int JNPBIMHEMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4780", Offset = "0x6E3B80", VA = "0x1806E4780", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x75ED00", Offset = "0x75E100", VA = "0x18075ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x58A5A40", Offset = "0x58A4E40", VA = "0x1858A5A40")]
	public static HHHNIDIHMIA JFKDKDPKICO(IEnumerator<HHHNIDIHMIA> HLAGDCAAGCG, EAHGIPAPNPA IHAHGKJEDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x58A5960", Offset = "0x58A4D60", VA = "0x1858A5960")]
	public HHHNIDIHMIA JFKDKDPKICO(EAHGIPAPNPA[] EIIHCKOAAKI, IEnumerator<HHHNIDIHMIA>[] OAOKINKGDFC, HHHNIDIHMIA[] CDMMIIDDBKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x58A57F0", Offset = "0x58A4BF0", VA = "0x1858A57F0")]
	public void CLELKEFNLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x58A5820", Offset = "0x58A4C20", VA = "0x1858A5820")]
	public void DFEKOCCKEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x58A5BF0", Offset = "0x58A4FF0", VA = "0x1858A5BF0")]
	public void OBPJLFCCNPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x58A57F0", Offset = "0x58A4BF0", VA = "0x1858A57F0")]
	public void FIGPHFJKAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public PKPNNDANLKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class OIKFLLPJDHB
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct CEKJDFJBJLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public PKPNNDANLKO OAHKMJBJPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public LKCOCDLDCAN PHGMKIHCLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public EAHGIPAPNPA ADBBMJICNMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public IEnumerator<HHHNIDIHMIA> PAIDDCPAJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public HHHNIDIHMIA ANBLNKKONFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public DMMIIHPDJIL IHPBBEBBNJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct IPKAFBHFPDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public FBAPKPGAINI.CJKALMCHPOC BLMNFENNJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public List<CEKJDFJBJLG> NOLBLFJODDB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MODJHNKKBEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public EAHGIPAPNPA promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public OIKFLLPJDHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public LKCOCDLDCAN context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public PKPNNDANLKO routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public DMMIIHPDJIL coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public HHHNIDIHMIA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public IEnumerator<HHHNIDIHMIA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public MODJHNKKBEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x589FFE0", Offset = "0x589F3E0", VA = "0x18589FFE0")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class OKHFGKOMHOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public PKPNNDANLKO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public OIKFLLPJDHB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public OKHFGKOMHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x58A5590", Offset = "0x58A4990", VA = "0x1858A5590")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GBOBDAPGLEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public PKPNNDANLKO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public OIKFLLPJDHB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public GBOBDAPGLEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x589B5C0", Offset = "0x589A9C0", VA = "0x18589B5C0")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class PHMCDMOKLDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public PKPNNDANLKO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public OIKFLLPJDHB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public PHMCDMOKLDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x58A55D0", Offset = "0x58A49D0", VA = "0x1858A55D0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private const DMMIIHPDJIL AEPIIMMIGID = DMMIIHPDJIL.Cancelled | DMMIIHPDJIL.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private bool[] CLNAHPFPJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<DMMIIHPDJIL> JIOLFMHKBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<float> LAIIODLMHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<int> IAJCPCGPJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<int> OFFOGFGPMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<int> BNOPLIEGHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<int> KLCADFOFNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private NativeArray<int> KFJLPJDPJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private PKPNNDANLKO[] HABGHBGJEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private EAHGIPAPNPA[] EIIHCKOAAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private LKCOCDLDCAN[] EMHPMNKEGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private IEnumerator<HHHNIDIHMIA>[] MGFAJFPPGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private HHHNIDIHMIA[] FDNEKMFHDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int DGIDLAEIEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int NANBMPFBPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly int CMFFFGBOHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float LFMLKHPFFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private KCLFDBIJICB ODKJMENPEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private JobHandle PJEOCKPNMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private List<PKPNNDANLKO> DCAPBLPPHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool HIMIDFDANED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private List<Action> KHACKKAAMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private List<Action> HLBLAEAGBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private bool HMFFMDFDBNC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IPKAFBHFPDC[] LLLBHECCIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7F18B0", Offset = "0x7F0CB0", VA = "0x1807F18B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x58A30A0", Offset = "0x58A24A0", VA = "0x1858A30A0")]
	private static int HMLDCOJOANE(FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x58A4810", Offset = "0x58A3C10", VA = "0x1858A4810")]
	public OIKFLLPJDHB(FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x58A34F0", Offset = "0x58A28F0", VA = "0x1858A34F0")]
	private void IIHLDPBNPBI(ref int EHPBMPGJKFF, int FLENFLLGNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x58A4690", Offset = "0x58A3A90", VA = "0x1858A4690")]
	public void OLIFBOJBHOH(LKCOCDLDCAN OEGBAMNPENI, HHHNIDIHMIA FGBGGMAKFKL, IEnumerator<HHHNIDIHMIA> HLAGDCAAGCG, EAHGIPAPNPA IHAHGKJEDDP, [Optional] PKPNNDANLKO ABINNAOGFPI, DMMIIHPDJIL LCKPPHPCGKI = DMMIIHPDJIL.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x58A3300", Offset = "0x58A2700", VA = "0x1858A3300")]
	public void IHIHANEDMEJ(IEnumerable<CEKJDFJBJLG> INBCJFHDJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x58A24F0", Offset = "0x58A18F0", VA = "0x1858A24F0")]
	private CEKJDFJBJLG CMPDFPJCIGM(int EAKDCBNIMDC)
	{
		return default(CEKJDFJBJLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x58A4070", Offset = "0x58A3470", VA = "0x1858A4070")]
	private void LCCAHIHGPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x32179F0", Offset = "0x3216DF0", VA = "0x1832179F0")]
	private static void LHOMCIGEAJC<T>(int EAKDCBNIMDC, T[] FKAEDDIKFOL, int OLGJFEONMLB, [Optional] T BGIFGGFECJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x32179D0", Offset = "0x3216DD0", VA = "0x1832179D0")]
	private static void LHOMCIGEAJC<T>(int EAKDCBNIMDC, NativeArray<T> FKAEDDIKFOL, int OLGJFEONMLB, [Optional] T BGIFGGFECJG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x58A2A00", Offset = "0x58A1E00", VA = "0x1858A2A00")]
	private void ECFAAKCOODM(IEnumerable<CEKJDFJBJLG> INBCJFHDJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x58A4410", Offset = "0x58A3810", VA = "0x1858A4410")]
	private void LOIIIIMFOLI(CEKJDFJBJLG JGBIDAJMHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x58A2CB0", Offset = "0x58A20B0", VA = "0x1858A2CB0")]
	private NHOLPLCMIFG FFKHOELDLPP(int LGAPGDJFPDK)
	{
		return default(NHOLPLCMIFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x58A3E90", Offset = "0x58A3290", VA = "0x1858A3E90")]
	public void JFBKMCDGIAC(float FBKFHMCJGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x58A3E10", Offset = "0x58A3210", VA = "0x1858A3E10")]
	private void IMBJDEPOJEB(Action KEPOHMNFLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x58A44E0", Offset = "0x58A38E0", VA = "0x1858A44E0")]
	private void MAOIIKDPCBO(Action KEPOHMNFLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x58A36E0", Offset = "0x58A2AE0", VA = "0x1858A36E0")]
	public void IKPMMJJIFCO(float FBKFHMCJGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x58A3200", Offset = "0x58A2600", VA = "0x1858A3200")]
	public void IDPLHJEPBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x58A2F70", Offset = "0x58A2370", VA = "0x1858A2F70")]
	public void FIGPHFJKAAA(PKPNNDANLKO IDAIEMPOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x58A4560", Offset = "0x58A3960", VA = "0x1858A4560")]
	public void MGFEJKFJGGC(PKPNNDANLKO IDAIEMPOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x58A30D0", Offset = "0x58A24D0", VA = "0x1858A30D0")]
	public void IABHFOIIKJO(PKPNNDANLKO IDAIEMPOLJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GFGBMANKNKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static readonly GFGBMANKNKE AEEILNKOPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly Action JACHNLOJJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool MDPNAAPBFCF;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
	public GFGBMANKNKE(Action JACHNLOJJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x589B600", Offset = "0x589AA00", VA = "0x18589B600", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface NFKPMHDCJJF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	T EJBPMDLBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PFIANHBGFMM(UnityEngine.Object OEGBAMNPENI, Action<T> JEODCAGLDPB);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface OCGLNBJLLND<T> : global::NFKPMHDCJJF<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	new T EJBPMDLBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class LEGCCBGGPHO<T> : global::OCGLNBJLLND<T>, global::NFKPMHDCJJF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class IBGFBAKNIDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public global::LEGCCBGGPHO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public global::MOEMHBGIAPF<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public IBGFBAKNIDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4A71ED0", Offset = "0x4A712D0", VA = "0x184A71ED0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static GameObject LCAKJDLJLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly List<global::MOEMHBGIAPF<UnityEngine.Object, Action<T>>> BDGAJLHFGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private T EDNIOKCKPFI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public T EJBPMDLBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x85F6B0", Offset = "0x85EAB0", VA = "0x18085F6B0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2E9BD90", Offset = "0x2E9B190", VA = "0x182E9BD90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2E9B670", Offset = "0x2E9AA70", VA = "0x182E9B670")]
	private static bool BGPFHOJMBMO(T KEPOHMNFLGL, T CFEKEMJOJGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C1F0", Offset = "0x2E9B5F0", VA = "0x182E9C1F0")]
	public LEGCCBGGPHO(T NGGAFIOLDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2E9BFE0", Offset = "0x2E9B3E0", VA = "0x182E9BFE0", Slot = "6")]
	public IDisposable PFIANHBGFMM(UnityEngine.Object OEGBAMNPENI, Action<T> JEODCAGLDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2E9B6D0", Offset = "0x2E9AAD0", VA = "0x182E9B6D0")]
	private void CCNIIIMHLLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal class CCFDHDJPJON : APKFJPMDNPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly LNALHCPHCLJ CGMMAAPBPCI;

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5894C40", Offset = "0x5894040", VA = "0x185894C40")]
	[KPHLIICFIPJ(OEKFJILJDLM.None)]
	private static void IBABMEFBFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
	[Preserve]
	internal CCFDHDJPJON([ANGFGGDOPHE(null)] LNALHCPHCLJ CGMMAAPBPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5894BA0", Offset = "0x5893FA0", VA = "0x185894BA0", Slot = "4")]
	public IDisposable AIGCOJEJKMC(float DAOMPNKAMLD, Action<float> KCKLDKHBENC, bool CLPIFMIODCM = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[BurstCompile]
internal struct KCLFDBIJICB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[ReadOnly]
	public float KEEOMCBFPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	[ReadOnly]
	public int BCJDLENODAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NativeArray<int> CDMNDDEKAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NativeArray<int> AMOLFEKHGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private NativeArray<int> OPPHJGFEOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[ReadOnly]
	public NativeArray<DMMIIHPDJIL> CAACOJGLIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[ReadOnly]
	public NativeArray<float> AJNBHGPPAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[WriteOnly]
	public NativeArray<int> BNOPLIEGHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[WriteOnly]
	public NativeArray<int> IAJCPCGPJCL;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x589E1A0", Offset = "0x589D5A0", VA = "0x18589E1A0")]
	public static KCLFDBIJICB PELCFOCODBC(int IGOPHAGFIOK, float FBKFHMCJGEO, NativeArray<DMMIIHPDJIL> OBIPOALLMNL, NativeArray<float> LHOAAFOODPE, NativeArray<int> PNOKKEEGGCG, NativeArray<int> LBNKFPMOFPK, NativeArray<int> KLKADODPHKI, NativeArray<int> AMOLFEKHGOI, NativeArray<int> OPPHJGFEOOI)
	{
		return default(KCLFDBIJICB);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x589DCF0", Offset = "0x589D0F0", VA = "0x18589DCF0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x589DDD0", Offset = "0x589D1D0", VA = "0x18589DDD0")]
	private bool FCNIBINJLNC(int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x589DE10", Offset = "0x589D210", VA = "0x18589DE10")]
	private void FNIHLBCOEHM(NativeArray<int> FBECMLLODGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x589E070", Offset = "0x589D470", VA = "0x18589E070")]
	private int MCAEBHLAECA(int PDPDDOPHICC, int DIDFBOECOBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x589E0D0", Offset = "0x589D4D0", VA = "0x18589E0D0")]
	private void MMJFCHEOADK(NativeArray<int> FBECMLLODGH, int DDKDIHOPPNJ, int NJOAOGNOOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x589DE40", Offset = "0x589D240", VA = "0x18589DE40")]
	private void JBGKCPHOOGJ(NativeArray<int> FBECMLLODGH, int CBCEEJHNPKN, int FFKMJEOJIOG, int EMFCLIJFGKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class JNFOLODDFGA : FDEIIPODGDP, LNALHCPHCLJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private OIKFLLPJDHB[] LACEMMFINNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private ABCFCAGGBDE IPNHCLBGPLB;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x589D1F0", Offset = "0x589C5F0", VA = "0x18589D1F0")]
	[KPHLIICFIPJ(OEKFJILJDLM.None)]
	private static void IBABMEFBFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x589D850", Offset = "0x589CC50", VA = "0x18589D850")]
	[Preserve]
	public JNFOLODDFGA([ANGFGGDOPHE(null)] ANAMKLDCIKN CANPHOBCIHJ, [ANGFGGDOPHE(null)] KPHGPBAAKFB CBCBAJKGEMC, [ANGFGGDOPHE(null)] CBIGKJLCBOP BDGEBLFEODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x589D630", Offset = "0x589CA30", VA = "0x18589D630", Slot = "12")]
	public override IPHLGHEAMKL LOADICPPPDO(LKCOCDLDCAN OEGBAMNPENI, IEnumerator<HHHNIDIHMIA> DMGLEBOKAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x589D350", Offset = "0x589C750", VA = "0x18589D350", Slot = "13")]
	public override void LMINFOAGFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x589CE70", Offset = "0x589C270", VA = "0x18589CE70", Slot = "15")]
	public override void DOEICGBKFBB(FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x589D770", Offset = "0x589CB70", VA = "0x18589D770", Slot = "14")]
	protected override void LOGJNOLNCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x589D310", Offset = "0x589C710", VA = "0x18589D310")]
	private OIKFLLPJDHB JDBLHPKNKAD(FBAPKPGAINI.CJKALMCHPOC BKGBGEHNCAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x589D260", Offset = "0x589C660", VA = "0x18589D260", Slot = "16")]
	internal override LBEIIKNAKGB IPCNMPCEOAP(IEnumerator<HHHNIDIHMIA> DMGLEBOKAHB, Behaviour OEGBAMNPENI, EAHGIPAPNPA IHAHGKJEDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x589CE00", Offset = "0x589C200", VA = "0x18589CE00", Slot = "17")]
	internal override BEDELEOJJKI CKDBKMEAAIL(FBAPKPGAINI.CJKALMCHPOC BICKJDNHDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x589D0C0", Offset = "0x589C4C0", VA = "0x18589D0C0")]
	private void FNPIMODFEHH(OIKFLLPJDHB BIDHADBPALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x589D050", Offset = "0x589C450", VA = "0x18589D050", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class FDEIIPODGDP : LNALHCPHCLJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly ANAMKLDCIKN CANPHOBCIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	protected readonly KPHGPBAAKFB CBCBAJKGEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly CBIGKJLCBOP BDGEBLFEODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private BEDELEOJJKI[] FGJGJGGFAJC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static LNALHCPHCLJ KGGJIHLJBIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x589A140", Offset = "0x5899540", VA = "0x18589A140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static bool BFCALEBFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x798260", Offset = "0x797660", VA = "0x180798260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FBAPKPGAINI.CJKALMCHPOC HCKHGMIIEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E4780", Offset = "0x6E3B80", VA = "0x1806E4780", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FBAPKPGAINI.CJKALMCHPOC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x75ED00", Offset = "0x75E100", VA = "0x18075ED00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public KPHGPBAAKFB IGAHDLGOFON
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x589A660", Offset = "0x5899A60", VA = "0x18589A660")]
	public static IPHLGHEAMKL OHBINLKFBFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x589A720", Offset = "0x5899B20", VA = "0x18589A720")]
	[Preserve]
	protected FDEIIPODGDP([ANGFGGDOPHE(null)] ANAMKLDCIKN CANPHOBCIHJ, [ANGFGGDOPHE(null)] KPHGPBAAKFB CBCBAJKGEMC, [ANGFGGDOPHE(null)] CBIGKJLCBOP BDGEBLFEODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5899B50", Offset = "0x5898F50", VA = "0x185899B50", Slot = "6")]
	public IPHLGHEAMKL BFJDGLKAEGF(IEnumerator<HHHNIDIHMIA> DMGLEBOKAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5899920", Offset = "0x5898D20", VA = "0x185899920", Slot = "7")]
	public IPHLGHEAMKL BFJDGLKAEGF(Behaviour OEGBAMNPENI, IEnumerator<HHHNIDIHMIA> DMGLEBOKAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract IPHLGHEAMKL LOADICPPPDO(LKCOCDLDCAN OEGBAMNPENI, IEnumerator<HHHNIDIHMIA> DMGLEBOKAHB);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x589A440", Offset = "0x5899840", VA = "0x18589A440", Slot = "13")]
	public virtual void LMINFOAGFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x589A190", Offset = "0x5899590", VA = "0x18589A190", Slot = "9")]
	public void GHDDIOJMKPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x589A620", Offset = "0x5899A20", VA = "0x18589A620", Slot = "14")]
	protected virtual void LOGJNOLNCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x589A3C0", Offset = "0x58997C0", VA = "0x18589A3C0")]
	private void IBKAKBCOICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5899B60", Offset = "0x5898F60", VA = "0x185899B60")]
	private void BNHIAIPDLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x589A3E0", Offset = "0x58997E0", VA = "0x18589A3E0")]
	private void IBNFJMIBNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x589A700", Offset = "0x5899B00", VA = "0x18589A700")]
	private void PLGFJFBAIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x589A420", Offset = "0x5899820", VA = "0x18589A420")]
	private void LKNAGGDJCKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x589A400", Offset = "0x5899800", VA = "0x18589A400")]
	private void IIEMDEIPCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x589A640", Offset = "0x5899A40", VA = "0x18589A640")]
	private void NPHMOCIHLHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5899B80", Offset = "0x5898F80", VA = "0x185899B80", Slot = "15")]
	public virtual void DOEICGBKFBB(FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x589A1F0", Offset = "0x58995F0", VA = "0x18589A1F0")]
	private void GKDOOMDBADH(BEDELEOJJKI BIDHADBPALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x1424FF0", Offset = "0x14243F0", VA = "0x181424FF0")]
	private BEDELEOJJKI EKKKJBCAHHI(FBAPKPGAINI.CJKALMCHPOC BKGBGEHNCAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract LBEIIKNAKGB IPCNMPCEOAP(IEnumerator<HHHNIDIHMIA> DMGLEBOKAHB, Behaviour GOGAOCOHIBI, EAHGIPAPNPA LAFOCGAFIGF);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract BEDELEOJJKI CKDBKMEAAIL(FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5899DC0", Offset = "0x58991C0", VA = "0x185899DC0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class LBEIIKNAKGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly EAHGIPAPNPA IHAHGKJEDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly GHDECHCGAKC OEGBAMNPENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly bool ABBLGPGKJFL;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IEnumerator<HHHNIDIHMIA> PAIDDCPAJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public HHHNIDIHMIA ANBLNKKONFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x77DF40", Offset = "0x77D340", VA = "0x18077DF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool JHHAGFEGLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x589ED10", Offset = "0x589E110", VA = "0x18589ED10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool NAGGNHENELA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x76D170", Offset = "0x76C570", VA = "0x18076D170")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x76D190", Offset = "0x76C590", VA = "0x18076D190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string LJDFOHKOPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6C72D0", Offset = "0x6C66D0", VA = "0x1806C72D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7776A0", Offset = "0x776AA0", VA = "0x1807776A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float IINNOPODDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FC0", Offset = "0x8D33C0", VA = "0x1808D3FC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1A21BE0", Offset = "0x1A20FE0", VA = "0x181A21BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x589EEC0", Offset = "0x589E2C0", VA = "0x18589EEC0")]
	public LBEIIKNAKGB(IEnumerator<HHHNIDIHMIA> HLAGDCAAGCG, GHDECHCGAKC OEGBAMNPENI, EAHGIPAPNPA IHAHGKJEDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x589EA50", Offset = "0x589DE50", VA = "0x18589EA50")]
	public HHHNIDIHMIA JFKDKDPKICO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x589ED90", Offset = "0x589E190", VA = "0x18589ED90")]
	public bool PDACGIAJKOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x589E9D0", Offset = "0x589DDD0", VA = "0x18589E9D0")]
	public void FIGPHFJKAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x589EE00", Offset = "0x589E200", VA = "0x18589EE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x209C6C0", Offset = "0x209BAC0", VA = "0x18209C6C0")]
	[CompilerGenerated]
	private void BMBFKKBMBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class EAHGIPAPNPA : MFFMLCCENOO, IPHLGHEAMKL, COANNBMMJHK, NDNJBANLHJC, IEnumerator, HHHNIDIHMIA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private FBAPKPGAINI.CJKALMCHPOC AOCNDONMEBD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private FBAPKPGAINI.CJKALMCHPOC BJIMAJLAMNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x845BC0", Offset = "0x844FC0", VA = "0x180845BC0", Slot = "23")]
		get
		{
			return default(FBAPKPGAINI.CJKALMCHPOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public FBAPKPGAINI.CJKALMCHPOC IAJHJOOKEII
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xED8740", Offset = "0xED7B40", VA = "0x180ED8740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private float IMPFHMEILCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xAF43C0", Offset = "0xAF37C0", VA = "0x180AF43C0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x58988C0", Offset = "0x5897CC0", VA = "0x1858988C0", Slot = "24")]
	private bool PHOBHNGKDPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x58988B0", Offset = "0x5897CB0", VA = "0x1858988B0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x58988E0", Offset = "0x5897CE0", VA = "0x1858988E0")]
	public EAHGIPAPNPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal enum NHOLPLCMIFG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal sealed class BEDELEOJJKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public enum MPINIFNMJIP
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct JFODIPDJEKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public FBAPKPGAINI.CJKALMCHPOC BLMNFENNJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public MPINIFNMJIP IIGDLAHIONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public List<LBEIIKNAKGB> MGDNMIPDCBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly MPINIFNMJIP[] KMAABCGMOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly FBAPKPGAINI.CJKALMCHPOC GNBLLMKKHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool MEALPKCPIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly LBEIIKNAKGB[] CGENHBLPLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly List<LBEIIKNAKGB> GCDOIIFAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly Stack<int> BGAFOLPBPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly List<LBEIIKNAKGB> DPKLJNCOLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly Stack<int> EFODMEBBGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly ABCFCAGGBDE BPIPEPEOJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private bool HMFFMDFDBNC;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JFODIPDJEKB[,] BPGKLKPIHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6E1530", Offset = "0x6E0930", VA = "0x1806E1530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x58930F0", Offset = "0x58924F0", VA = "0x1858930F0")]
	public BEDELEOJJKI(FBAPKPGAINI.CJKALMCHPOC BICKJDNHDLM, ABCFCAGGBDE BPIPEPEOJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5892A60", Offset = "0x5891E60", VA = "0x185892A60")]
	public void IDMPKBLOEDG(LBEIIKNAKGB HLAGDCAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5892790", Offset = "0x5891B90", VA = "0x185892790")]
	public void HJLGNBMKLLI(IList<LBEIIKNAKGB> OAOKINKGDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5891FD0", Offset = "0x58913D0", VA = "0x185891FD0")]
	public void BJLAFDPJDMA(IList<LBEIIKNAKGB> OAOKINKGDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5892DA0", Offset = "0x58921A0", VA = "0x185892DA0")]
	private void LNMKOFPCJJB(LBEIIKNAKGB HLAGDCAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5891E50", Offset = "0x5891250", VA = "0x185891E50")]
	private void BIKHFGBCINJ(IList<LBEIIKNAKGB> OAOKINKGDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x58923E0", Offset = "0x58917E0", VA = "0x1858923E0")]
	private NHOLPLCMIFG FBAMPFGKHNO(LBEIIKNAKGB HLAGDCAAGCG)
	{
		return default(NHOLPLCMIFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5892EA0", Offset = "0x58922A0", VA = "0x185892EA0")]
	public void LOGJNOLNCGE(float FBKFHMCJGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5892580", Offset = "0x5891980", VA = "0x185892580")]
	public void GHDDIOJMKPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5892B80", Offset = "0x5891F80", VA = "0x185892B80")]
	private void LELLMBEFLPF(List<LBEIIKNAKGB> OAOKINKGDFC, Stack<int> CBAFHCOKABI, bool PLJGNEBFADC, float JJGIAEALBIN = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x58922A0", Offset = "0x58916A0", VA = "0x1858922A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5891D30", Offset = "0x5891130", VA = "0x185891D30")]
	private void ANOAKDJNGFG(List<LBEIIKNAKGB> OAOKINKGDFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class EAGJEKFKAPJ : ABCFCAGGBDE
{
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "4")]
	public void PPEBDGKFGJB(string LBEPPIIBMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
	public void KCKOJPIEKFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public EAGJEKFKAPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class LGJPNKEPNGH : GHDECHCGAKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly Behaviour GOGAOCOHIBI;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string LJDFOHKOPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x589F880", Offset = "0x589EC80", VA = "0x18589F880", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool FDLECAKAGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x589F800", Offset = "0x589EC00", VA = "0x18589F800", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool KLFEDKAAOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x589F860", Offset = "0x589EC60", VA = "0x18589F860", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
	public LGJPNKEPNGH(Behaviour GOGAOCOHIBI)
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

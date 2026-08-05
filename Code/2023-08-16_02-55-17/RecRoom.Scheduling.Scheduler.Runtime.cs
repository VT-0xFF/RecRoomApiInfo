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
public class IKFHCCEPJHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority ADEOPGMLCDH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E651D0", Offset = "0x4E643D0", VA = "0x184E651D0")]
	public IKFHCCEPJHL(ThreadPriority NKHHFIJPDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E651C0", Offset = "0x4E643C0", VA = "0x184E651C0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> HDNJMFDLCPG(List<PlayerLoopSystem> BLJLNGLFFBB, int LNOGJODJFIB);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct IBBOHNFLOLM
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct OLPDJKBKOHB
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static HFMPGNIBJKD CHHDBCBMEBC;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x4E70F90", Offset = "0x4E70190", VA = "0x184E70F90")]
				public static PlayerLoopSystem BKFPMNNLOGO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct AMHJLCJANBP
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static HFMPGNIBJKD OMNPEKPEGAO;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x4E57F80", Offset = "0x4E57180", VA = "0x184E57F80")]
				public static PlayerLoopSystem BKFPMNNLOGO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct HBIBKEEIABM
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static HFMPGNIBJKD DBLLMJMOJKI;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4E64010", Offset = "0x4E63210", VA = "0x184E64010")]
				public static PlayerLoopSystem BKFPMNNLOGO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct MAHCDKDBMDH
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static HFMPGNIBJKD BEOEIACIANM;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static HFMPGNIBJKD BFGAHIAMCNI;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static HFMPGNIBJKD GDBEGNIBLAA;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static HFMPGNIBJKD EHNDEDOGNJP;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x4E6BE90", Offset = "0x4E6B090", VA = "0x184E6BE90")]
				public static PlayerLoopSystem BKFPMNNLOGO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct CANKHHPMOEI
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static HFMPGNIBJKD OONNDFFAILN;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x4E58B20", Offset = "0x4E57D20", VA = "0x184E58B20")]
				public static PlayerLoopSystem BKFPMNNLOGO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct KFEPCCABBAM
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static HFMPGNIBJKD BEOEIACIANM;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static HFMPGNIBJKD BFGAHIAMCNI;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static HFMPGNIBJKD GDBEGNIBLAA;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static HFMPGNIBJKD EHNDEDOGNJP;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x4E68290", Offset = "0x4E67490", VA = "0x184E68290")]
				public static PlayerLoopSystem BKFPMNNLOGO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct HBDADBOBDOM
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static HFMPGNIBJKD OKGBENAACBN;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x4E63E00", Offset = "0x4E63000", VA = "0x184E63E00")]
				public static PlayerLoopSystem BKFPMNNLOGO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct NMEPHBMKFIA
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static HFMPGNIBJKD FJOLIIBNFDF;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x4E70600", Offset = "0x4E6F800", VA = "0x184E70600")]
				public static PlayerLoopSystem BKFPMNNLOGO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct IOOGJKMDBMI
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static HFMPGNIBJKD MJNCCGGPGBP;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x4E65210", Offset = "0x4E64410", VA = "0x184E65210")]
				public static PlayerLoopSystem BKFPMNNLOGO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct CLKBPHNFDPB
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static HFMPGNIBJKD CNLHIPAGFBL;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x4E59270", Offset = "0x4E58470", VA = "0x184E59270")]
				public static PlayerLoopSystem BKFPMNNLOGO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct EONIOOBKJEB
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static HFMPGNIBJKD KJIDOAKCNCO;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x4E614F0", Offset = "0x4E606F0", VA = "0x184E614F0")]
				public static PlayerLoopSystem BKFPMNNLOGO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct DCDJBEJEPMD
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static HFMPGNIBJKD KNMFIFMKLAO;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x4E5E730", Offset = "0x4E5D930", VA = "0x184E5E730")]
				public static PlayerLoopSystem BKFPMNNLOGO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum GPAEKMKADMK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct MDGFGAABGMD
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class IHEJDNPGCEA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public GPAEKMKADMK updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
					public IHEJDNPGCEA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x4E65130", Offset = "0x4E64330", VA = "0x184E65130")]
					internal void PBJHGAMLLAD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static CHBPAJLHAAD<GPAEKMKADMK> HJLEDGECEPI;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x4E6C150", Offset = "0x4E6B350", VA = "0x184E6C150")]
				public static PlayerLoopSystem BKFPMNNLOGO(GPAEKMKADMK DHHIPPAMAHO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct JMINPOOHDFI
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class CKHLFNPKPJI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public MFPLDHECBNJ.HELGMNFAGDD key;

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
					public CKHLFNPKPJI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x4E58FA0", Offset = "0x4E581A0", VA = "0x184E58FA0")]
					internal void EMLEFMJFPND()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable FPHCHEMBFEB;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x4E665A0", Offset = "0x4E657A0", VA = "0x184E665A0")]
				public static PlayerLoopSystem BMHNCDDOLKH(MFPLDHECBNJ.HELGMNFAGDD JCEGKCPOPDM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct CLPHCJNHMNA
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class IBPDLBLFOLF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public MFPLDHECBNJ.HELGMNFAGDD key;

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
					public IBPDLBLFOLF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x4E64CA0", Offset = "0x4E63EA0", VA = "0x184E64CA0")]
					internal void EMLEFMJFPND()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x4E59480", Offset = "0x4E58680", VA = "0x184E59480")]
				public static PlayerLoopSystem BMHNCDDOLKH(MFPLDHECBNJ.HELGMNFAGDD JCEGKCPOPDM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class EMMJAFCCCOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public EMMJAFCCCOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4E613D0", Offset = "0x4E605D0", VA = "0x184E613D0")]
			internal List<PlayerLoopSystem> NIKBFFNFMOI(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool BJIMHGOCKGP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool NOPFKCCHHKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x4E5DCE0", Offset = "0x4E5CEE0", VA = "0x184E5DCE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x4E5CC80", Offset = "0x4E5BE80", VA = "0x184E5CC80")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4E5A200", Offset = "0x4E59400", VA = "0x184E5A200")]
		private static void BCNHJFNBDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E5CCC0", Offset = "0x4E5BEC0", VA = "0x184E5CCC0")]
		private static void GCGJCPMAMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E5D9B0", Offset = "0x4E5CBB0", VA = "0x184E5D9B0")]
		private static void JEOKPFDBLCF(string ECNMKMFINJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E59FD0", Offset = "0x4E591D0", VA = "0x184E59FD0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4E5DD20", Offset = "0x4E5CF20", VA = "0x184E5DD20")]
		private static void LCHLJGMPLMA(MFPLDHECBNJ.HELGMNFAGDD JCEGKCPOPDM, ref PlayerLoopSystem MDHCLDBCHIP, Type EPBFCAALDOM, Type CJEJCFPBMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4E5D590", Offset = "0x4E5C790", VA = "0x184E5D590")]
		private static void HKGMHBJIJCH(ref PlayerLoopSystem MDHCLDBCHIP, Type EPBFCAALDOM, Type CJEJCFPBMEH, HDNJMFDLCPG IOKCONAMDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E5CB50", Offset = "0x4E5BD50", VA = "0x184E5CB50")]
		private static void BFJMNOIAAAG(ref PlayerLoopSystem MDHCLDBCHIP, Type EPBFCAALDOM, Type CJEJCFPBMEH, PlayerLoopSystem? MGDBAHFAOLI, PlayerLoopSystem? AFDGOFOIMPN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class MFPLDHECBNJ
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum HELGMNFAGDD
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class HNNGDKAPNFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly HELGMNFAGDD JONLEABEPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly LMHAHFPLFHN FBHCDDNNOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long JFPCHPNHCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long HLKJHIOHNNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long CCBMKAPBGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int IPEELLAADCJ;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4E64AC0", Offset = "0x4E63CC0", VA = "0x184E64AC0")]
		public HNNGDKAPNFD(HELGMNFAGDD MNCJGPEPHJL, int OGJJLEFCMOE = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4E649F0", Offset = "0x4E63BF0", VA = "0x184E649F0")]
		public void JDLDFBGDPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4E64A60", Offset = "0x4E63C60", VA = "0x184E64A60")]
		public void NOINBBIGIII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4E647F0", Offset = "0x4E639F0", VA = "0x184E647F0")]
		public void EHGIIFNFJMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static HELGMNFAGDD[] FHKADOCDBKL;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static HNNGDKAPNFD[] NNCIDLNDBFK;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C3E0", Offset = "0x4E6B5E0", VA = "0x184E6C3E0")]
	public static HNNGDKAPNFD KHGFHPPBNNK(HELGMNFAGDD JCEGKCPOPDM, int OGJJLEFCMOE = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C5C0", Offset = "0x4E6B7C0", VA = "0x184E6C5C0")]
	public static HNNGDKAPNFD LOEFAJFFHCC(HELGMNFAGDD JCEGKCPOPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C330", Offset = "0x4E6B530", VA = "0x184E6C330")]
	public static void DEBKLPPJGPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class JLPKIBAMJMN
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private interface FCJJFAJMDGL
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool HGHIJNDCJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OJAKBINLFPA();
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private abstract class KFAKNFCKPMJ<TPromise, TMainThreadPromise> : FCJJFAJMDGL where TPromise : GIOBGNHJLID where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly TPromise NDEICNPLHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected readonly TMainThreadPromise KNOINLCIAND;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TPromise AFJKJLPHMDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2298DB0", Offset = "0x2297FB0", VA = "0x182298DB0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool HGHIJNDCJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2298E10", Offset = "0x2298010", VA = "0x182298E10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1EC27E0", Offset = "0x1EC19E0", VA = "0x181EC27E0")]
		protected KFAKNFCKPMJ(TPromise NDEICNPLHON, TMainThreadPromise FNHNCOKMKIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2298E60", Offset = "0x2298060", VA = "0x182298E60", Slot = "5")]
		public void OJAKBINLFPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void BJOMADKEONB(TPromise NDEICNPLHON);
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class DEHOKPCEJPA<T> : KFAKNFCKPMJ<OOMFLHAHLDK<T>, GCGDLGCIGBG<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x21C6D90", Offset = "0x21C5F90", VA = "0x1821C6D90")]
		public DEHOKPCEJPA(OOMFLHAHLDK<T> NDEICNPLHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x21C6B60", Offset = "0x21C5D60", VA = "0x1821C6B60", Slot = "6")]
		protected override void BJOMADKEONB(OOMFLHAHLDK<T> NDEICNPLHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x21C6D60", Offset = "0x21C5F60", VA = "0x1821C6D60")]
		[CompilerGenerated]
		private void LELALHOBIDO(T GAMJEJDMFJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xBB7740", Offset = "0xBB6940", VA = "0x180BB7740")]
		[CompilerGenerated]
		private void JNCGLPKLECD(string BMNKLBFFLLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class POKNOGDBJEF : FCJJFAJMDGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Action AMEKOPCKNIK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool HGHIJNDCJNK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
		public POKNOGDBJEF(Action AMEKOPCKNIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BEB00", Offset = "0x8BDD00", VA = "0x1808BEB00", Slot = "5")]
		public void OJAKBINLFPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<FCJJFAJMDGL> ABPOHFDGGKN;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1B36CB0", Offset = "0x1B35EB0", VA = "0x181B36CB0")]
	public static OOMFLHAHLDK<T> ICPIBKIPHOA<T>(this OOMFLHAHLDK<T> NDEICNPLHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4E662C0", Offset = "0x4E654C0", VA = "0x184E662C0")]
	public static void ICPIBKIPHOA(Action AMEKOPCKNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1B36D20", Offset = "0x1B35F20", VA = "0x181B36D20")]
	private static OOMFLHAHLDK<T> MHJECADNMHA<T>(OOMFLHAHLDK<T> NDEICNPLHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4E660C0", Offset = "0x4E652C0", VA = "0x184E660C0")]
	private static void EGIAGAEEPPD(FCJJFAJMDGL IDGKKNIGEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4E65DC0", Offset = "0x4E64FC0", VA = "0x184E65DC0")]
	private static void AKCDJHPMFKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4E66420", Offset = "0x4E65620", VA = "0x184E66420")]
	private static void MHEFOMBALIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4E66350", Offset = "0x4E65550", VA = "0x184E66350")]
	private static void KNBAJFIHMAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MLPMEMALGHC
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private struct CBCFPPDCCBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<Scene> GHOJJIJLINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly string NIMNFAHNKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly LoadSceneMode ACCPJPCEJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly bool JCBICPFAOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4E58DC0", Offset = "0x4E57FC0", VA = "0x184E58DC0")]
		public CBCFPPDCCBN(TaskCompletionSource<Scene> BHFMDEGDAIH, string NIMNFAHNKAM, LoadSceneMode ACCPJPCEJJA, bool JCBICPFAOBN, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class LKALODIHNAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private GAKPIOFBDII<string> <toDispose>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private OIHENDAIDID <stackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private CBCFPPDCCBN <queuedSceneLoad>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LKALODIHNAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4E688E0", Offset = "0x4E67AE0", VA = "0x184E688E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class BEFOFLENBDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BEFOFLENBDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4E587E0", Offset = "0x4E579E0", VA = "0x184E587E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class PKILKOONKKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private CBCFPPDCCBN <dequeued>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Scene <scene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Scene <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PKILKOONKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4E718B0", Offset = "0x4E70AB0", VA = "0x184E718B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class CLCNMIHACCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public GCGDLGCIGBG<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CLCNMIHACCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4E59210", Offset = "0x4E58410", VA = "0x184E59210")]
		internal void MDKGIBMALDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class CMKPJMMKIFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <loadSceneTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private CLCNMIHACCF <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool <shouldLoadEmptyScene>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Scene <emptyScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Scene <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CMKPJMMKIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4E595E0", Offset = "0x4E587E0", VA = "0x184E595E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class ABPBJOIEODN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private SceneInstance <instance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ABPBJOIEODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4E57A90", Offset = "0x4E56C90", VA = "0x184E57A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class DFNFLDIBAAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Scene <emptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <emptySceneRoutineTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <emptySceneTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DFNFLDIBAAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4E5E980", Offset = "0x4E5DB80", VA = "0x184E5E980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MOMMLADPHKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MOMMLADPHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4E6EAB0", Offset = "0x4E6DCB0", VA = "0x184E6EAB0")]
		internal bool KDEDIFNJIEI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class BAACCIBDBMG : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public MGJKNPFOJOG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <sample>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private MOMMLADPHKN <>8__3;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public BAACCIBDBMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4E58560", Offset = "0x4E57760", VA = "0x184E58560", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4E581E0", Offset = "0x4E573E0", VA = "0x184E581E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4E58190", Offset = "0x4E57390", VA = "0x184E58190")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4E58520", Offset = "0x4E57720", VA = "0x184E58520", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class FHGELNHBIMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public GCGDLGCIGBG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FHGELNHBIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4E61700", Offset = "0x4E60900", VA = "0x184E61700")]
		internal bool DOEPIINMDIA(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4E61780", Offset = "0x4E60980", VA = "0x184E61780")]
		internal void JMHKGCOEMBP(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class DBJDBCFDGHP : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public GCGDLGCIGBG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private FHGELNHBIMJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public DBJDBCFDGHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4E5DEF0", Offset = "0x4E5D0F0", VA = "0x184E5DEF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4E5E6F0", Offset = "0x4E5D8F0", VA = "0x184E5E6F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly ICollection<string> CAOLENBCBFI;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static GIOBGNHJLID GDJLCFEAMBB;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AsyncOperation BOCIDJFLLGM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static GIOBGNHJLID IMNMGKLEJJF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static string OKCPNHOGMHP;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static ThreadPriority CHOBIFLLEEB;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task FAPJIPBEPKD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static List<SceneInstance> GCCKBAEKMDJ;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Queue<CBCFPPDCCBN> EHCDCCHBAIL;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Task JFHMMFEEGBF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool HGMBLDDMGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4E6D8C0", Offset = "0x4E6CAC0", VA = "0x184E6D8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool DBEIPBHGAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4E6D480", Offset = "0x4E6C680", VA = "0x184E6D480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private static bool IPPMDJJFFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4E6E1E0", Offset = "0x4E6D3E0", VA = "0x184E6E1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static bool GNHEFADODGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4E6D540", Offset = "0x4E6C740", VA = "0x184E6D540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> HBDALBGLGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4E6DF30", Offset = "0x4E6D130", VA = "0x184E6DF30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4E6CE30", Offset = "0x4E6C030", VA = "0x184E6CE30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4E6D150", Offset = "0x4E6C350", VA = "0x184E6D150")]
	[EEIOFBLGGPF(JGEIHADJKJD.EnteredEditModeNextFrame, 0)]
	private static void ENNCCOAEOPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4E6DD80", Offset = "0x4E6CF80", VA = "0x184E6DD80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LKALODIHNAI))]
	public static Task<Scene> MEIBNMDOACC(string NIMNFAHNKAM, LoadSceneMode ACCPJPCEJJA = LoadSceneMode.Single, bool JCBICPFAOBN = false, [Optional] GAKPIOFBDII<string>.JOKPHMHCDCF HMFAHCBBGLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4E6D220", Offset = "0x4E6C420", VA = "0x184E6D220")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BEFOFLENBDN))]
	private static Task ENOABJBKPPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4E6CD30", Offset = "0x4E6BF30", VA = "0x184E6CD30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PKILKOONKKH))]
	private static Task BKLKCNFMAGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4E6E030", Offset = "0x4E6D230", VA = "0x184E6E030")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CMKPJMMKIFK))]
	private static Task<Scene> NPEOMMHGFLH(string NIMNFAHNKAM, LoadSceneMode ACCPJPCEJJA, bool JCBICPFAOBN, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4E6DB40", Offset = "0x4E6CD40", VA = "0x184E6DB40")]
	private static void KNEKMLBIHHK(SceneInstance PEJFNLJIKME, LoadSceneMode ACCPJPCEJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C930", Offset = "0x4E6BB30", VA = "0x184E6C930")]
	private static void AEFEKJBMFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4E6D320", Offset = "0x4E6C520", VA = "0x184E6D320")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ABPBJOIEODN))]
	private static Task<Scene> HCNFHJMBMDD(string NIMNFAHNKAM, LoadSceneMode ACCPJPCEJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4E6D060", Offset = "0x4E6C260", VA = "0x184E6D060")]
	private static bool DHKMMHNOJPL(string NIMNFAHNKAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4E6DC30", Offset = "0x4E6CE30", VA = "0x184E6DC30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DFNFLDIBAAA))]
	private static Task<Scene> LLHDGJJKOKA(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C9D0", Offset = "0x4E6BBD0", VA = "0x184E6C9D0")]
	public static OOMFLHAHLDK<Scene> AIEKMEINPAD(string NIMNFAHNKAM, LoadSceneMode ACCPJPCEJJA = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4E6D5F0", Offset = "0x4E6C7F0", VA = "0x184E6D5F0")]
	public static GIOBGNHJLID JPLBMPBLDOB(string NIMNFAHNKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4E6CFD0", Offset = "0x4E6C1D0", VA = "0x184E6CFD0")]
	[IteratorStateMachine(typeof(BAACCIBDBMG))]
	private static IEnumerator<MPEFECEHMLJ> DFJOJDDCMEL(string NIMNFAHNKAM, MGJKNPFOJOG NAHJMFNJFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4E6CF30", Offset = "0x4E6C130", VA = "0x184E6CF30")]
	[IteratorStateMachine(typeof(DBJDBCFDGHP))]
	private static IEnumerator<MPEFECEHMLJ> CIGLANJLGIE(string NIMNFAHNKAM, LoadSceneMode ACCPJPCEJJA, GCGDLGCIGBG<Scene> NAHJMFNJFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4E6CBC0", Offset = "0x4E6BDC0", VA = "0x184E6CBC0")]
	public static bool AKONMACBNBH(out string NIDEAPKDAHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class LMHAHFPLFHN : ANIMDPPJKOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int PCJNBKOEEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Queue<double> JCHEAFNBALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private double JGECELACBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private double CBOHJJDJGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private double BIMGJKHMJAM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public double DIEHHJLKPCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E6BD70", Offset = "0x4E6AF70", VA = "0x184E6BD70", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double IIOMLNOMNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xF9B220", Offset = "0xF9A420", VA = "0x180F9B220", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double JOLGJKIIJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D06370", Offset = "0x3D05570", VA = "0x183D06370", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BDE0", Offset = "0x4E6AFE0", VA = "0x184E6BDE0")]
	public LMHAHFPLFHN(int BMECOCNGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BBD0", Offset = "0x4E6ADD0", VA = "0x184E6BBD0", Slot = "7")]
	public void AIGILIECEDP(double OGOIFONOCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BD00", Offset = "0x4E6AF00", VA = "0x184E6BD00", Slot = "8")]
	public void FNKHNDBLOJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class GOJBIOPNDOO : ANIMDPPJKOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private long BKHJHJOLNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private double KJDMNIOCHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private double PHCPKLBIPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private double JKANLNOICDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private double MPHDHJIDJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private double JGECELACBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private double CBOHJJDJGAA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7E9420", Offset = "0x7E8620", VA = "0x1807E9420")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double IIOMLNOMNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4E63DB0", Offset = "0x4E62FB0", VA = "0x184E63DB0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double JOLGJKIIJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4E63DA0", Offset = "0x4E62FA0", VA = "0x184E63DA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double BPAEFAJFGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4E63D40", Offset = "0x4E62F40", VA = "0x184E63D40")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double DIEHHJLKPCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4E63D90", Offset = "0x4E62F90", VA = "0x184E63D90", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4E63C10", Offset = "0x4E62E10", VA = "0x184E63C10", Slot = "7")]
	public virtual void AIGILIECEDP(double OGOIFONOCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E63D50", Offset = "0x4E62F50", VA = "0x184E63D50", Slot = "8")]
	public virtual void FNKHNDBLOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4E63DC0", Offset = "0x4E62FC0", VA = "0x184E63DC0")]
	public GOJBIOPNDOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class MJAHJGCJPKE : GOJBIOPNDOO
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public double NNNHEGPMJAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D063B0", Offset = "0x3D055B0", VA = "0x183D063B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D06300", Offset = "0x3D05500", VA = "0x183D06300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C7B0", Offset = "0x4E6B9B0", VA = "0x184E6C7B0", Slot = "7")]
	public override void AIGILIECEDP(double OGOIFONOCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C8F0", Offset = "0x4E6BAF0", VA = "0x184E6C8F0", Slot = "8")]
	public override void FNKHNDBLOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4E63DC0", Offset = "0x4E62FC0", VA = "0x184E63DC0")]
	public MJAHJGCJPKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface ANIMDPPJKOO
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	double DIEHHJLKPCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double IIOMLNOMNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	double JOLGJKIIJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class NKNMEKFAECN : BHAAELJEGPN
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public float OALAGKEBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4E705C0", Offset = "0x4E6F7C0", VA = "0x184E705C0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public float CPEFHCBPJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4E705D0", Offset = "0x4E6F7D0", VA = "0x184E705D0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public double NNCEBBLGJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4E705E0", Offset = "0x4E6F7E0", VA = "0x184E705E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4E70550", Offset = "0x4E6F750", VA = "0x184E70550")]
	[GKCPJLBLCDF(EHLDMJJGFKP.None)]
	private static void CBJFBKKBGCJ(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	[Preserve]
	internal NKNMEKFAECN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class EIMFJFANAMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class KICLPEPLFBB : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public EIMFJFANAMC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public KICLPEPLFBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4E64BF0", Offset = "0x4E63DF0", VA = "0x184E64BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4E68550", Offset = "0x4E67750", VA = "0x184E68550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private NHIOCEAPLGE HAEDCIKLKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private MonoBehaviour NOJBMHOHPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Action BCDNPHJJGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Action<float> GCAKMBNPLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private KMDHDDICNKI DJDNICKNLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float CMBAOOPFFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool AAPIABGMGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly PEMCPFGJHKJ DIFFCPFJEFJ;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4E611D0", Offset = "0x4E603D0", VA = "0x184E611D0")]
	public EIMFJFANAMC(MonoBehaviour NOJBMHOHPDB, Action BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4E60D40", Offset = "0x4E5FF40", VA = "0x184E60D40")]
	public EIMFJFANAMC(MonoBehaviour NOJBMHOHPDB, Action<float> BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4E60F80", Offset = "0x4E60180", VA = "0x184E60F80")]
	public EIMFJFANAMC(MonoBehaviour NOJBMHOHPDB, float AGJGDJAOOBG, Action<float> BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN, bool AAPIABGMGOD = true, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3C8F940", Offset = "0x3C8EB40", VA = "0x183C8F940")]
	private EIMFJFANAMC(PEMCPFGJHKJ DIFFCPFJEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4E60110", Offset = "0x4E5F310", VA = "0x184E60110")]
	internal static EIMFJFANAMC BGKALJCNBED(MonoBehaviour NOJBMHOHPDB, float AGJGDJAOOBG, Action<float> BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN, bool AAPIABGMGOD = true, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4E605F0", Offset = "0x4E5F7F0", VA = "0x184E605F0")]
	private void HMONKOBOGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E603B0", Offset = "0x4E5F5B0", VA = "0x184E603B0")]
	private void GJLFEEPPEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4E60760", Offset = "0x4E5F960", VA = "0x184E60760")]
	private void JLBONNFILOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E60A30", Offset = "0x4E5FC30", VA = "0x184E60A30")]
	private void OFMGLNIMEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E60C00", Offset = "0x4E5FE00", VA = "0x184E60C00")]
	private void PKONGANNDNO(string BMNKLBFFLLF, Action FPJMAMFABCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E60320", Offset = "0x4E5F520", VA = "0x184E60320")]
	[IteratorStateMachine(typeof(KICLPEPLFBB))]
	private IEnumerator<MPEFECEHMLJ> EKMHNNLJIOF(Action FPJMAMFABCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4E60230", Offset = "0x4E5F430", VA = "0x184E60230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4E60560", Offset = "0x4E5F760", VA = "0x184E60560")]
	[CompilerGenerated]
	private void HHJIPKAPBHI(string IPCCCBDDHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4E609A0", Offset = "0x4E5FBA0", VA = "0x184E609A0")]
	[CompilerGenerated]
	private void LCBBFDKMIPI(string IPCCCBDDHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4E60290", Offset = "0x4E5F490", VA = "0x184E60290")]
	[CompilerGenerated]
	private void EEBPLANNAOL(string IPCCCBDDHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4E60910", Offset = "0x4E5FB10", VA = "0x184E60910")]
	[CompilerGenerated]
	private void KMEOMPNKDLP(string IPCCCBDDHCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct NCHOFOHMNDF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[ReadOnly]
	public float IBFGAPNPDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	public int PHGAHAHCDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<int> JNHGMBOCEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<int> PMJBOLOPPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeArray<int> KMFAHDGGCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	public NativeArray<FEGHDIDANOJ> MMFDBFEAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	public NativeArray<float> KPHGEPGMJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[WriteOnly]
	public NativeArray<int> NIKCOABBBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[WriteOnly]
	public NativeArray<int> GPJINIFDFBO;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4E6EF30", Offset = "0x4E6E130", VA = "0x184E6EF30")]
	public static NCHOFOHMNDF JKAAGGANCJG(int JKHDJBCLHEF, float OHOPLMJABGE, NativeArray<FEGHDIDANOJ> JGAJMKHEDBI, NativeArray<float> JPCLJFMMPJJ, NativeArray<int> GJJLOCOIFIC, NativeArray<int> JNEMJKMKDBL, NativeArray<int> DIIKHLMIEGO, NativeArray<int> PMJBOLOPPEH, NativeArray<int> KMFAHDGGCLK)
	{
		return default(NCHOFOHMNDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4E6EC40", Offset = "0x4E6DE40", VA = "0x184E6EC40", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F0B0", Offset = "0x4E6E2B0", VA = "0x184E6F0B0")]
	private bool MLCMPIPBKKA(int NNAODBDJDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4E6EC10", Offset = "0x4E6DE10", VA = "0x184E6EC10")]
	private void DBDHFMAJOKG(NativeArray<int> DCEOIHBDKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4E6EBB0", Offset = "0x4E6DDB0", VA = "0x184E6EBB0")]
	private int CEPKNKFOCBH(int KJACNMHBIPG, int AEFDCDDBMLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4E6EFE0", Offset = "0x4E6E1E0", VA = "0x184E6EFE0")]
	private void JKOMHFGHFFI(NativeArray<int> DCEOIHBDKAG, int AMPLBLPGGKA, int CINIEBHLBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4E6ED20", Offset = "0x4E6DF20", VA = "0x184E6ED20")]
	private void IJFDCFBJCNI(NativeArray<int> DCEOIHBDKAG, int GBHKNNKIDGH, int JCCCNLOBJLP, int LLBJEKPCNIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class GCIBPBHKMML : MNFFBMICADD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly float AECEJIELMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly int BIOEJPLHEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float NCJHNFFIKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly float[] NENDMKLNGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private int FMBDJAOONFF;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4E626A0", Offset = "0x4E618A0", VA = "0x184E626A0")]
	public GCIBPBHKMML(Behaviour JDFBABENAGD, float JHEEAIEBBOA, int BIOEJPLHEFL, [Optional] Action OMAKMCDCMOG, float NCJHNFFIKIL = 0f, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ, [Optional] BHAAELJEGPN DCBIKOMLPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x929790", Offset = "0x928990", VA = "0x180929790", Slot = "9")]
	protected override bool DHNMKNEGAOK(Action AMEKOPCKNIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4E623E0", Offset = "0x4E615E0", VA = "0x184E623E0", Slot = "10")]
	protected override bool GAAJCLDPAJA(Action AMEKOPCKNIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4E62610", Offset = "0x4E61810", VA = "0x184E62610")]
	private void KPKAEJIPLAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public abstract class GLLOAGMLFCP : PEMCPFGJHKJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly CMEIMDNBBNE IJIIHDGIHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected readonly BHAAELJEGPN DCBIKOMLPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly EOIMOEDCBGO JONNKNHFIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private KCCBHHHCOKA[] DDHLEBPJKAE;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static PEMCPFGJHKJ JHOAALADPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4E63790", Offset = "0x4E62990", VA = "0x184E63790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool DILEBBOMEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public KMDHDDICNKI HPNGIENDFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E2180", Offset = "0x7E1380", VA = "0x1807E2180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(KMDHDDICNKI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xB4F8A0", Offset = "0xB4EAA0", VA = "0x180B4F8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public BHAAELJEGPN OAGKPJFMKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4E63000", Offset = "0x4E62200", VA = "0x184E63000")]
	public static NHIOCEAPLGE FJDPIIFOILM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4E63860", Offset = "0x4E62A60", VA = "0x184E63860")]
	[Preserve]
	protected GLLOAGMLFCP([NDGONEEEGIA(null)] CMEIMDNBBNE IJIIHDGIHGJ, [NDGONEEEGIA(null)] BHAAELJEGPN DCBIKOMLPDI, [NDGONEEEGIA(null)] EOIMOEDCBGO JONNKNHFIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4E634C0", Offset = "0x4E626C0", VA = "0x184E634C0", Slot = "6")]
	public NHIOCEAPLGE GNJLBDDANJL(IEnumerator<MPEFECEHMLJ> CLGDCDPMHFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4E63290", Offset = "0x4E62490", VA = "0x184E63290", Slot = "7")]
	public NHIOCEAPLGE GNJLBDDANJL(Behaviour JDFBABENAGD, IEnumerator<MPEFECEHMLJ> CLGDCDPMHFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract NHIOCEAPLGE ANMJCPMPJLM(LLMOJONNGLL JDFBABENAGD, IEnumerator<MPEFECEHMLJ> CLGDCDPMHFF);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4E630B0", Offset = "0x4E622B0", VA = "0x184E630B0", Slot = "13")]
	public virtual void FNKHNDBLOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4E634D0", Offset = "0x4E626D0", VA = "0x184E634D0", Slot = "9")]
	public void HOCJFCPLLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E330", Offset = "0x1C3D530", VA = "0x181C3E330", Slot = "14")]
	protected virtual void KGILAIAHHCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4E63800", Offset = "0x4E62A00", VA = "0x184E63800")]
	private void OMNPEKPEGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4E62C20", Offset = "0x4E61E20", VA = "0x184E62C20")]
	private void DBLLMJMOJKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4E63530", Offset = "0x4E62730", VA = "0x184E63530")]
	private void LBFNILJHKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4E63820", Offset = "0x4E62A20", VA = "0x184E63820")]
	private void PKDIGHCDKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4E637E0", Offset = "0x4E629E0", VA = "0x184E637E0")]
	private void OKGBENAACBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4E63090", Offset = "0x4E62290", VA = "0x184E63090")]
	private void FJOLIIBNFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4E63840", Offset = "0x4E62A40", VA = "0x184E63840")]
	private void PNNKJMPMPAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4E63550", Offset = "0x4E62750", VA = "0x184E63550", Slot = "15")]
	public virtual void LLLFAAJMHGJ(KMDHDDICNKI DJDNICKNLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4E62A50", Offset = "0x4E61C50", VA = "0x184E62A50")]
	private void BIGGNIFDEFC(KCCBHHHCOKA IJNKOKNMHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4E62FC0", Offset = "0x4E621C0", VA = "0x184E62FC0")]
	private KCCBHHHCOKA EBBIGKKLMMG(KMDHDDICNKI FBNKHAJKFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract OCDFNMBEICN MAJNKMOKHGJ(IEnumerator<MPEFECEHMLJ> CLGDCDPMHFF, Behaviour NOJBMHOHPDB, CAOLHGADNKE HKFOOIBGILM);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract KCCBHHHCOKA FOLEOGGNCLA(KMDHDDICNKI DJDNICKNLDN);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4E62C40", Offset = "0x4E61E40", VA = "0x184E62C40", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DLJMIMPEGKN : GLLOAGMLFCP, PEMCPFGJHKJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private LKHBCCPDOMK[] KLHLNMGIMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private ILELLEANGKP MCPOACPELBI;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4E5F480", Offset = "0x4E5E680", VA = "0x184E5F480")]
	[GKCPJLBLCDF(EHLDMJJGFKP.None)]
	private static void CBJFBKKBGCJ(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4E5FE20", Offset = "0x4E5F020", VA = "0x184E5FE20")]
	[Preserve]
	public DLJMIMPEGKN([NDGONEEEGIA(null)] CMEIMDNBBNE IJIIHDGIHGJ, [NDGONEEEGIA(null)] BHAAELJEGPN DCBIKOMLPDI, [NDGONEEEGIA(null)] EOIMOEDCBGO JONNKNHFIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4E5F330", Offset = "0x4E5E530", VA = "0x184E5F330", Slot = "12")]
	public override NHIOCEAPLGE ANMJCPMPJLM(LLMOJONNGLL JDFBABENAGD, IEnumerator<MPEFECEHMLJ> CLGDCDPMHFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4E5F560", Offset = "0x4E5E760", VA = "0x184E5F560", Slot = "13")]
	public override void FNKHNDBLOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4E5F980", Offset = "0x4E5EB80", VA = "0x184E5F980", Slot = "15")]
	public override void LLLFAAJMHGJ(KMDHDDICNKI DJDNICKNLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4E5F8A0", Offset = "0x4E5EAA0", VA = "0x184E5F8A0", Slot = "14")]
	protected override void KGILAIAHHCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4E5FDE0", Offset = "0x4E5EFE0", VA = "0x184E5FDE0")]
	private LKHBCCPDOMK PGFIDIIBAHE(KMDHDDICNKI FBNKHAJKFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4E5FB50", Offset = "0x4E5ED50", VA = "0x184E5FB50", Slot = "16")]
	internal override OCDFNMBEICN MAJNKMOKHGJ(IEnumerator<MPEFECEHMLJ> CLGDCDPMHFF, Behaviour JDFBABENAGD, CAOLHGADNKE HBNJPDHFEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4E5F830", Offset = "0x4E5EA30", VA = "0x184E5F830", Slot = "17")]
	internal override KCCBHHHCOKA FOLEOGGNCLA(KMDHDDICNKI EKPKHDPLAGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4E5FCC0", Offset = "0x4E5EEC0", VA = "0x184E5FCC0")]
	private void OMKEHGGFMMA(LKHBCCPDOMK IJNKOKNMHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4E5F4F0", Offset = "0x4E5E6F0", VA = "0x184E5F4F0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class LLCIECCHGCF
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class ECNMIMHHPPB : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public KMDHDDICNKI queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public ECNMIMHHPPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4E60020", Offset = "0x4E5F220", VA = "0x184E60020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4E600D0", Offset = "0x4E5F2D0", VA = "0x184E600D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BB50", Offset = "0x4E6AD50", VA = "0x184E6BB50")]
	[IteratorStateMachine(typeof(ECNMIMHHPPB))]
	private static IEnumerator<MPEFECEHMLJ> MEPMPMCGAAL(KMDHDDICNKI DJDNICKNLDN, Func<bool> DGFAPLOODCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BA40", Offset = "0x4E6AC40", VA = "0x184E6BA40")]
	public static NHIOCEAPLGE LKNLEFKBMDM(this MonoBehaviour NOJBMHOHPDB, Func<bool> DGFAPLOODCD, KMDHDDICNKI DJDNICKNLDN = KMDHDDICNKI.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class OCDFNMBEICN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly CAOLHGADNKE HBNJPDHFEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly CINKFGPDNNC JDFBABENAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly bool NPDPHLFEMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private string JPKENOAMLIN;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IEnumerator<MPEFECEHMLJ> DEPAFNIGNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public MPEFECEHMLJ NJJMFJOEKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool MHHAAPMKMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4E70D20", Offset = "0x4E6FF20", VA = "0x184E70D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool KBEHPDMKFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA92EC0", Offset = "0xA920C0", VA = "0x180A92EC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x904E30", Offset = "0x904030", VA = "0x180904E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4E70910", Offset = "0x4E6FB10", VA = "0x184E70910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float EODADKCGLHI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xC9B710", Offset = "0xC9A910", VA = "0x180C9B710")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x10F0280", Offset = "0x10EF480", VA = "0x1810F0280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4E70E80", Offset = "0x4E70080", VA = "0x184E70E80")]
	public OCDFNMBEICN(IEnumerator<MPEFECEHMLJ> PBOBEIBCONO, CINKFGPDNNC JDFBABENAGD, CAOLHGADNKE HBNJPDHFEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4E70A90", Offset = "0x4E6FC90", VA = "0x184E70A90")]
	public MPEFECEHMLJ JLIEBJPPIIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4E70890", Offset = "0x4E6FA90", VA = "0x184E70890")]
	public bool AOJJIBDLGCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4E70810", Offset = "0x4E6FA10", VA = "0x184E70810")]
	public void ACJHAMOBBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4E70DA0", Offset = "0x4E6FFA0", VA = "0x184E70DA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xB80B80", Offset = "0xB7FD80", VA = "0x180B80B80")]
	[CompilerGenerated]
	private void CNDGCFNEJIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class ONKKJKHDMLM
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class FPJLMBCNHPG : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public GDJJGOCEHPA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public KMDHDDICNKI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public FPJLMBCNHPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4E619F0", Offset = "0x4E60BF0", VA = "0x184E619F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4E61A90", Offset = "0x4E60C90", VA = "0x184E61A90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4E712C0", Offset = "0x4E704C0", VA = "0x184E712C0")]
	public static NHIOCEAPLGE HMONKOBOGHB(float AGJGDJAOOBG, Action<float> BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN, bool AAPIABGMGOD = true, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4E713C0", Offset = "0x4E705C0", VA = "0x184E713C0")]
	public static NHIOCEAPLGE HMONKOBOGHB(MonoBehaviour NOJBMHOHPDB, float AGJGDJAOOBG, Action<float> BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN, bool AAPIABGMGOD = true, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4E711A0", Offset = "0x4E703A0", VA = "0x184E711A0")]
	public static NHIOCEAPLGE GNABNBIHELC(MonoBehaviour NOJBMHOHPDB, float AGJGDJAOOBG, Action<float> BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN, bool AAPIABGMGOD = true, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4E714D0", Offset = "0x4E706D0", VA = "0x184E714D0")]
	public static NHIOCEAPLGE KEELPHJDFJO(LLMOJONNGLL JDFBABENAGD, float AGJGDJAOOBG, Action<float> BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN, bool AAPIABGMGOD = true, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4E71690", Offset = "0x4E70890", VA = "0x184E71690")]
	private static IEnumerator<MPEFECEHMLJ> LMHNGMOGJKH(BHAAELJEGPN DCBIKOMLPDI, float AGJGDJAOOBG, KMDHDDICNKI EKPKHDPLAGE, Action<float> BCDNPHJJGCA, bool AAPIABGMGOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4E71740", Offset = "0x4E70940", VA = "0x184E71740")]
	private static IEnumerator<MPEFECEHMLJ> PDDIPJKAODP(BHAAELJEGPN DCBIKOMLPDI, float AGJGDJAOOBG, KMDHDDICNKI EKPKHDPLAGE, Action<float> BCDNPHJJGCA, bool AAPIABGMGOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4E715E0", Offset = "0x4E707E0", VA = "0x184E715E0")]
	[IteratorStateMachine(typeof(FPJLMBCNHPG))]
	private static IEnumerator<MPEFECEHMLJ> KIOBLKOKAGO(GDJJGOCEHPA OMADHLCIHMK, float AGJGDJAOOBG, KMDHDDICNKI EKPKHDPLAGE, Action<float> BCDNPHJJGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface KBAEHANIBHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool ONBIDKNFAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action KHAOALOJJLI;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GBLABONAANN(bool BEIAPGFNLDJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GBLABONAANN(Action AMEKOPCKNIK, bool BEIAPGFNLDJ = false);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BAAEJEEGOMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static readonly BAAEJEEGOMF LKJHINFHCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Action CKIHKFJOMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool IFCDFOBKGCM;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x120A1A0", Offset = "0x12093A0", VA = "0x18120A1A0")]
	public BAAEJEEGOMF(Action CKIHKFJOMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x4E585F0", Offset = "0x4E577F0", VA = "0x184E585F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface GIAMMEDNHJP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T HDFPEMDEFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NJPIFHDDAMH(UnityEngine.Object JDFBABENAGD, Action<T> BNMFDOOABHD);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface DEKCOIADDKB<T> : GIAMMEDNHJP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T HDFPEMDEFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class DCKLGAHIIAJ<T> : DEKCOIADDKB<T>, GIAMMEDNHJP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class BGGHBFCLJON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public DCKLGAHIIAJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public KKKJJIOCNBF<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public BGGHBFCLJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2314D70", Offset = "0x2313F70", VA = "0x182314D70")]
		internal void GOPJCADPECK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static GameObject DMNGJFCAPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly List<KKKJJIOCNBF<UnityEngine.Object, Action<T>>> KLLGBMBFNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private T LJFELHMLNCH;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T HDFPEMDEFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xDBFB20", Offset = "0xDBED20", VA = "0x180DBFB20", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x299BA90", Offset = "0x299AC90", VA = "0x18299BA90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x299BA20", Offset = "0x299AC20", VA = "0x18299BA20")]
	private static bool FGKPJBMHJEG(T GGFLAOCNMAP, T PIINDHALINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x299BE50", Offset = "0x299B050", VA = "0x18299BE50")]
	public DCKLGAHIIAJ(T JNFPHOODJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x299BCE0", Offset = "0x299AEE0", VA = "0x18299BCE0", Slot = "6")]
	public IDisposable NJPIFHDDAMH(UnityEngine.Object JDFBABENAGD, Action<T> BNMFDOOABHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x299B660", Offset = "0x299A860", VA = "0x18299B660")]
	private void DDEIEPCILLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface ILELLEANGKP
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDMCFOCKGHA(string JPKENOAMLIN);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFCIGLBBMCO();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class LILDKJBBHJP : ILELLEANGKP
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "4")]
	public void PDMCFOCKGHA(string JPKENOAMLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
	public void IFCIGLBBMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public LILDKJBBHJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class IEEOPHKKCDJ : MNFFBMICADD
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class HODMFEPCPJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public IEEOPHKKCDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HODMFEPCPJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4E64BC0", Offset = "0x4E63DC0", VA = "0x184E64BC0")]
		internal void JEOKAMMOMKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class KIJDGLFCDDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public IEEOPHKKCDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KIJDGLFCDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4E64BC0", Offset = "0x4E63DC0", VA = "0x184E64BC0")]
		internal void NFOALFOIDNG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly float CIEDLGGOGHK;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4E62890", Offset = "0x4E61A90", VA = "0x184E62890")]
	public IEEOPHKKCDJ(Behaviour JDFBABENAGD, float CIEDLGGOGHK, [Optional] Action OMAKMCDCMOG, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ, [Optional] BHAAELJEGPN DCBIKOMLPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4E64F30", Offset = "0x4E64130", VA = "0x184E64F30", Slot = "9")]
	protected override bool DHNMKNEGAOK(Action AMEKOPCKNIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4E65030", Offset = "0x4E64230", VA = "0x184E65030", Slot = "10")]
	protected override bool GAAJCLDPAJA(Action AMEKOPCKNIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class GABJKNJAANO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IAGCCDJIDJJ : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public GABJKNJAANO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public IAGCCDJIDJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4E64BF0", Offset = "0x4E63DF0", VA = "0x184E64BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4E64C60", Offset = "0x4E63E60", VA = "0x184E64C60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private NHIOCEAPLGE HAEDCIKLKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private LLMOJONNGLL JDFBABENAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private Action<float> GCAKMBNPLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private KMDHDDICNKI DJDNICKNLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private float CMBAOOPFFAE;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4E620B0", Offset = "0x4E612B0", VA = "0x184E620B0")]
	public GABJKNJAANO(LLMOJONNGLL JDFBABENAGD, float AGJGDJAOOBG, Action<float> BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4E61D80", Offset = "0x4E60F80", VA = "0x184E61D80")]
	private void JLBONNFILOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4E61F30", Offset = "0x4E61130", VA = "0x184E61F30")]
	private void PKONGANNDNO(string BMNKLBFFLLF, Action FPJMAMFABCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4E61CF0", Offset = "0x4E60EF0", VA = "0x184E61CF0")]
	[IteratorStateMachine(typeof(IAGCCDJIDJJ))]
	private IEnumerator<MPEFECEHMLJ> EKMHNNLJIOF(Action FPJMAMFABCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4E61C90", Offset = "0x4E60E90", VA = "0x184E61C90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4E61AD0", Offset = "0x4E60CD0", VA = "0x184E61AD0")]
	[CompilerGenerated]
	private void BABDPHMPOLK(string IPCCCBDDHCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class LKHBCCPDOMK
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct JBJKEGLAJPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public HGMNEGGEPPD AFKKEALCLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public LLMOJONNGLL LKKDABBDHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CAOLHGADNKE CHJHKAOFFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<MPEFECEHMLJ> DEPAFNIGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public MPEFECEHMLJ NJJMFJOEKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public FEGHDIDANOJ GLEHPJKNBFN;
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct JMMJKJGGJJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public KMDHDDICNKI PINFFKONKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<JBJKEGLAJPN> NCJJBPMAPJL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class AANMANOAKBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CAOLHGADNKE promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public LKHBCCPDOMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public LLMOJONNGLL context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public HGMNEGGEPPD routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public FEGHDIDANOJ coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public MPEFECEHMLJ currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<MPEFECEHMLJ> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AANMANOAKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4E56F30", Offset = "0x4E56130", VA = "0x184E56F30")]
		internal void OKLFOFBHHBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MOKNGADDKNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public HGMNEGGEPPD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public LKHBCCPDOMK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MOKNGADDKNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4E6EA70", Offset = "0x4E6DC70", VA = "0x184E6EA70")]
		internal void MALHGKOMIDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class GCBILJOMOFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public HGMNEGGEPPD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public LKHBCCPDOMK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GCBILJOMOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4E623A0", Offset = "0x4E615A0", VA = "0x184E623A0")]
		internal void GAILNFIBBNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class DDAKFFCDEFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public HGMNEGGEPPD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public LKHBCCPDOMK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DDAKFFCDEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4E5E940", Offset = "0x4E5DB40", VA = "0x184E5E940")]
		internal void KDLIKCMBMOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const FEGHDIDANOJ FLMBAOENFMI = FEGHDIDANOJ.Cancelled | FEGHDIDANOJ.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly KMDHDDICNKI DJDNICKNLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] JJCKNDHMOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<FEGHDIDANOJ> LLGPGNIPNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> LACAGNIMLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> GPJINIFDFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> JECLEBCDNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> NIKCOABBBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> FDHCHOOOGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> OANGJICEPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private HGMNEGGEPPD[] AJNAIDHEKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private CAOLHGADNKE[] GNHNDGHLNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private LLMOJONNGLL[] CKOEBGGHIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<MPEFECEHMLJ>[] HCHOMDAAIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private MPEFECEHMLJ[] GDIMPJLHIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int DFHHPAPODEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int HCKHKGKDPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int BAHCKHJIKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float LFJHMEIIMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private NCHOFOHMNDF FDINJMAIFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle OCNAKCJAIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<HGMNEGGEPPD> GFMCGBCBLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool EBGFJICLFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> NEAKNCHBFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> IGFFOJELLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool CEBFJGFKCCD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public JMMJKJGGJJP[] ILCBBMCHFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xC9B720", Offset = "0xC9A920", VA = "0x180C9B720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4E6A1F0", Offset = "0x4E693F0", VA = "0x184E6A1F0")]
	private static int GDJHFCECKJK(KMDHDDICNKI DJDNICKNLDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B430", Offset = "0x4E6A630", VA = "0x184E6B430")]
	public LKHBCCPDOMK(KMDHDDICNKI DJDNICKNLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4E69590", Offset = "0x4E68790", VA = "0x184E69590")]
	private void DHCFJPIHCBO(ref int OBKCKFLBPDO, int DLJNDKOIJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4E69CE0", Offset = "0x4E68EE0", VA = "0x184E69CE0")]
	public void EBCBIDKGAML(LLMOJONNGLL JDFBABENAGD, MPEFECEHMLJ NLAGECBNBDG, IEnumerator<MPEFECEHMLJ> PBOBEIBCONO, CAOLHGADNKE HBNJPDHFEKF, [Optional] HGMNEGGEPPD BEHPNHAECCP, FEGHDIDANOJ FMNHKOKNCEG = FEGHDIDANOJ.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4E6A2A0", Offset = "0x4E694A0", VA = "0x184E6A2A0")]
	public void HMBGKLGIBGE(IEnumerable<JBJKEGLAJPN> JFMLGAJGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4E69780", Offset = "0x4E68980", VA = "0x184E69780")]
	private JBJKEGLAJPN DMGKFDLGGNC(int JNGANKMDALI)
	{
		return default(JBJKEGLAJPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4E6ABC0", Offset = "0x4E69DC0", VA = "0x184E6ABC0")]
	private void NBNGLCCOEKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x19F71D0", Offset = "0x19F63D0", VA = "0x1819F71D0")]
	private static void JKEHPFOKNMD<T>(int JNGANKMDALI, T[] GEEFBIEOLIK, int JPJMMBFGIEG, [Optional] T HEKBBECGHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x19F71B0", Offset = "0x19F63B0", VA = "0x1819F71B0")]
	private static void JKEHPFOKNMD<T>(int JNGANKMDALI, NativeArray<T> GEEFBIEOLIK, int JPJMMBFGIEG, [Optional] T HEKBBECGHIL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4E691C0", Offset = "0x4E683C0", VA = "0x184E691C0")]
	private void CEEELMBFKHM(IEnumerable<JBJKEGLAJPN> JFMLGAJGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4E6AF70", Offset = "0x4E6A170", VA = "0x184E6AF70")]
	private void ODDNIHCCIHE(JBJKEGLAJPN LCNBDGABIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B040", Offset = "0x4E6A240", VA = "0x184E6B040")]
	private AGBNLCCOPJF PDLHFOKAIAJ(int OAHECEOHKKD)
	{
		return default(AGBNLCCOPJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4E6A010", Offset = "0x4E69210", VA = "0x184E6A010")]
	public void FNDMBCEIDKH(float OHOPLMJABGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4E69F90", Offset = "0x4E69190", VA = "0x184E69F90")]
	private void FKCBCAFONKI(Action GGFLAOCNMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4E6A220", Offset = "0x4E69420", VA = "0x184E6A220")]
	private void HHDAPFJNPDO(Action GGFLAOCNMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4E6A480", Offset = "0x4E69680", VA = "0x184E6A480")]
	public void LFKGEIFBIOI(float OHOPLMJABGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4E69490", Offset = "0x4E68690", VA = "0x184E69490")]
	public void DFBADGMPLED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4E69090", Offset = "0x4E68290", VA = "0x184E69090")]
	public void ACJHAMOBBFB(HGMNEGGEPPD OMADHLCIHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x4E69E60", Offset = "0x4E69060", VA = "0x184E69E60")]
	public void FKANBCJCLPF(HGMNEGGEPPD OMADHLCIHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B300", Offset = "0x4E6A500", VA = "0x184E6B300")]
	public void POPEIIBEHAJ(HGMNEGGEPPD OMADHLCIHMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class JFOBIIIHKHC : KBAEHANIBHJ, IEnumerable<KBAEHANIBHJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly List<KBAEHANIBHJ> FLGBOFLFGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool HILMKHOPDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Action OMAKMCDCMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private bool LPMLOGPIPNI;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ONBIDKNFAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4E65AC0", Offset = "0x4E64CC0", VA = "0x184E65AC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action KHAOALOJJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4E65C00", Offset = "0x4E64E00", VA = "0x184E65C00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4E65540", Offset = "0x4E64740", VA = "0x184E65540", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4E65D20", Offset = "0x4E64F20", VA = "0x184E65D20")]
	public JFOBIIIHKHC([Optional] Action OMAKMCDCMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4E65420", Offset = "0x4E64620", VA = "0x184E65420")]
	public void CKPKOIJGHLD(KBAEHANIBHJ OBEAPAFMCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4E658E0", Offset = "0x4E64AE0", VA = "0x184E658E0")]
	private void GJOJCONMGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4E658C0", Offset = "0x4E64AC0", VA = "0x184E658C0", Slot = "7")]
	public bool GBLABONAANN(bool BEIAPGFNLDJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4E655E0", Offset = "0x4E647E0", VA = "0x184E655E0", Slot = "8")]
	public bool GBLABONAANN(Action AMEKOPCKNIK, bool BEIAPGFNLDJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4E65A40", Offset = "0x4E64C40", VA = "0x184E65A40", Slot = "9")]
	public IEnumerator<KBAEHANIBHJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4E65CA0", Offset = "0x4E64EA0", VA = "0x184E65CA0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class MNFFBMICADD : KBAEHANIBHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class PDIMGPGDBLN : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public MNFFBMICADD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public PDIMGPGDBLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4E717A0", Offset = "0x4E709A0", VA = "0x184E717A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4E71870", Offset = "0x4E70A70", VA = "0x184E71870", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly Behaviour JDFBABENAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly Action OMAKMCDCMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private CICCNDFLPHA MPOEPLMLFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly PEMCPFGJHKJ DIFFCPFJEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	protected readonly BHAAELJEGPN DCBIKOMLPDI;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool ONBIDKNFAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xB9DDC0", Offset = "0xB9CFC0", VA = "0x180B9DDC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action KHAOALOJJLI
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4E6E8D0", Offset = "0x4E6DAD0", VA = "0x184E6E8D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4E6E560", Offset = "0x4E6D760", VA = "0x184E6E560", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4E6E970", Offset = "0x4E6DB70", VA = "0x184E6E970")]
	protected MNFFBMICADD(Behaviour JDFBABENAGD, [Optional] Action OMAKMCDCMOG, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ, [Optional] BHAAELJEGPN DCBIKOMLPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4E6E650", Offset = "0x4E6D850", VA = "0x184E6E650", Slot = "7")]
	public bool GBLABONAANN(bool BEIAPGFNLDJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4E6E600", Offset = "0x4E6D800", VA = "0x184E6E600", Slot = "8")]
	public bool GBLABONAANN(Action AMEKOPCKNIK, bool BEIAPGFNLDJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool DHNMKNEGAOK(Action AMEKOPCKNIK);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool GAAJCLDPAJA(Action AMEKOPCKNIK);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4E6E8B0", Offset = "0x4E6DAB0", VA = "0x184E6E8B0")]
	protected void LKEEHBKNHNO(Action AMEKOPCKNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4E6E6B0", Offset = "0x4E6D8B0", VA = "0x184E6E6B0")]
	protected GIOBGNHJLID GJBPLJMCDFF(float KPNFPBFKGFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4E6E420", Offset = "0x4E6D620", VA = "0x184E6E420")]
	private void BJHINCPCADB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x4E6E4A0", Offset = "0x4E6D6A0", VA = "0x184E6E4A0")]
	[IteratorStateMachine(typeof(PDIMGPGDBLN))]
	private IEnumerator<MPEFECEHMLJ> BKIILEKEODC(float KPNFPBFKGFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x4E6E520", Offset = "0x4E6D720", VA = "0x184E6E520")]
	[CompilerGenerated]
	private void DNHADDMMOAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Flags]
internal enum FEGHDIDANOJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class HGMNEGGEPPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public LKHBCCPDOMK HKPCPBIBJLG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int BBOMBIMAMPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E2180", Offset = "0x7E1380", VA = "0x1807E2180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xB4F8A0", Offset = "0xB4EAA0", VA = "0x180B4F8A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4E642E0", Offset = "0x4E634E0", VA = "0x184E642E0")]
	public static MPEFECEHMLJ JLIEBJPPIIC(IEnumerator<MPEFECEHMLJ> PBOBEIBCONO, CAOLHGADNKE HBNJPDHFEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x4E64490", Offset = "0x4E63690", VA = "0x184E64490")]
	public MPEFECEHMLJ JLIEBJPPIIC(CAOLHGADNKE[] GNHNDGHLNGG, IEnumerator<MPEFECEHMLJ>[] HKODPBHFDLA, MPEFECEHMLJ[] EFPPMFPDBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4E642B0", Offset = "0x4E634B0", VA = "0x184E642B0")]
	public void EPFPOELLAPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4E64570", Offset = "0x4E63770", VA = "0x184E64570")]
	public void PABPDJDMAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4E646B0", Offset = "0x4E638B0", VA = "0x184E646B0")]
	public void PAKPAJKDFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4E642B0", Offset = "0x4E634B0", VA = "0x184E642B0")]
	public void ACJHAMOBBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public HGMNEGGEPPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class KBNBEHLFMJA : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class BDGJAJHHOII : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public KBNBEHLFMJA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public BDGJAJHHOII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4E58710", Offset = "0x4E57910", VA = "0x184E58710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4E587A0", Offset = "0x4E579A0", VA = "0x184E587A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly KMDHDDICNKI DJDNICKNLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Action HMJOMPPJHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private bool INDGJLBCDAM;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool JAPNBMCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x94E3A0", Offset = "0x94D5A0", VA = "0x18094E3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4E667F0", Offset = "0x4E659F0", VA = "0x184E667F0")]
	public KBNBEHLFMJA(KMDHDDICNKI DJDNICKNLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4E66700", Offset = "0x4E65900", VA = "0x184E66700")]
	[IteratorStateMachine(typeof(BDGJAJHHOII))]
	private IEnumerator<MPEFECEHMLJ> JGFKJGEDBAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4E66770", Offset = "0x4E65970", VA = "0x184E66770", Slot = "4")]
	public void OnCompleted(Action EHAOPNOFCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public void DPKOFBJOIHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class EBBFGIBIHHG
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4E5FEF0", Offset = "0x4E5F0F0", VA = "0x184E5FEF0")]
	public static KBNBEHLFMJA MNBEJFECGED(this KMDHDDICNKI DJDNICKNLDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal class GAHGEBGFOHD : OCILFANHGGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly PEMCPFGJHKJ DIFFCPFJEFJ;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4E62330", Offset = "0x4E61530", VA = "0x184E62330")]
	[GKCPJLBLCDF(EHLDMJJGFKP.None)]
	private static void CBJFBKKBGCJ(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	[Preserve]
	internal GAHGEBGFOHD([NDGONEEEGIA(null)] PEMCPFGJHKJ DIFFCPFJEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E62290", Offset = "0x4E61490", VA = "0x184E62290", Slot = "4")]
	public IDisposable AHOPOMKMLGP(float AGJGDJAOOBG, Action<float> JHGMNDBGFFP, bool AAPIABGMGOD = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal enum AGBNLCCOPJF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class KCCBHHHCOKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum BCFPBACKHGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct ADHMJBKMBLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public KMDHDDICNKI PINFFKONKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public BCFPBACKHGH ANNOBJDPLHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public List<OCDFNMBEICN> CAGEBPFFAEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static readonly BCFPBACKHGH[] ECIEGAFNJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly KMDHDDICNKI DJDNICKNLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private bool LIPACDHIAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly OCDFNMBEICN[] HDKDJIBNECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly List<OCDFNMBEICN> BHACMBMNGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Stack<int> IONFLCOFCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly List<OCDFNMBEICN> DDFJJKGNMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Stack<int> GHMOFGAJKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly ILELLEANGKP PDPMNOPHMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private bool CEBFJGFKCCD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ADHMJBKMBLF[,] MMEGHIGGPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4E67DC0", Offset = "0x4E66FC0", VA = "0x184E67DC0")]
	public KCCBHHHCOKA(KMDHDDICNKI EKPKHDPLAGE, ILELLEANGKP PDPMNOPHMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4E67690", Offset = "0x4E66890", VA = "0x184E67690")]
	public void LAFICBDCEFI(OCDFNMBEICN PBOBEIBCONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4E670E0", Offset = "0x4E662E0", VA = "0x184E670E0")]
	public void JFLPHEJIMJD(IList<OCDFNMBEICN> HKODPBHFDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4E678B0", Offset = "0x4E66AB0", VA = "0x184E678B0")]
	public void OMNMDFNMJFH(IList<OCDFNMBEICN> HKODPBHFDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4E677B0", Offset = "0x4E669B0", VA = "0x184E677B0")]
	private void ODEHNMAOJDG(OCDFNMBEICN PBOBEIBCONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4E673B0", Offset = "0x4E665B0", VA = "0x184E673B0")]
	private void KAFOFFKLFMN(IList<OCDFNMBEICN> HKODPBHFDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4E668F0", Offset = "0x4E65AF0", VA = "0x184E668F0")]
	private AGBNLCCOPJF BINAJJMBMAO(OCDFNMBEICN PBOBEIBCONO)
	{
		return default(AGBNLCCOPJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4E67540", Offset = "0x4E66740", VA = "0x184E67540")]
	public void KGILAIAHHCE(float OHOPLMJABGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4E66ED0", Offset = "0x4E660D0", VA = "0x184E66ED0")]
	public void HOCJFCPLLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4E66B90", Offset = "0x4E65D90", VA = "0x184E66B90")]
	private void HNONFABFNFN(List<OCDFNMBEICN> HKODPBHFDLA, Stack<int> CFFLPJBLGOA, bool PPKOCNLKGJI, float DBOHCNEIDEC = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4E66A50", Offset = "0x4E65C50", VA = "0x184E66A50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4E67B80", Offset = "0x4E66D80", VA = "0x184E67B80")]
	private void PCLALIDCIEG(List<OCDFNMBEICN> HKODPBHFDLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class LEAFKDFKAFA : CINKFGPDNNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Behaviour NOJBMHOHPDB;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4E687D0", Offset = "0x4E679D0", VA = "0x184E687D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool DEKBKAFCAME
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4E68880", Offset = "0x4E67A80", VA = "0x184E68880", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool LBOKBNIOFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4E68860", Offset = "0x4E67A60", VA = "0x184E68860", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	public LEAFKDFKAFA(Behaviour NOJBMHOHPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class GCJCONAGPND : MNFFBMICADD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly float CIEDLGGOGHK;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4E62890", Offset = "0x4E61A90", VA = "0x184E62890")]
	public GCJCONAGPND(Behaviour JDFBABENAGD, float CIEDLGGOGHK, [Optional] Action OMAKMCDCMOG, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ, [Optional] BHAAELJEGPN DCBIKOMLPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x929790", Offset = "0x928990", VA = "0x180929790", Slot = "9")]
	protected override bool DHNMKNEGAOK(Action AMEKOPCKNIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E62850", Offset = "0x4E61A50", VA = "0x184E62850", Slot = "10")]
	protected override bool GAAJCLDPAJA(Action AMEKOPCKNIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class CJELAGGHHCL
{
	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4E58E20", Offset = "0x4E58020", VA = "0x184E58E20")]
	public static IDisposable BDJDNGECBKP(this LLMOJONNGLL JDFBABENAGD, float AGJGDJAOOBG, Action<float> BCDNPHJJGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E58EA0", Offset = "0x4E580A0", VA = "0x184E58EA0")]
	public static IDisposable DGKFGKJOLJA(this LLMOJONNGLL JDFBABENAGD, Action<float> BCDNPHJJGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E58F20", Offset = "0x4E58120", VA = "0x184E58F20")]
	public static IDisposable MGKBPBFELPI(this LLMOJONNGLL JDFBABENAGD, Action<float> BCDNPHJJGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class ABEMALDBCHF
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class KLBFPNEPJDC : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public KMDHDDICNKI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private BGGHJAJDAHA <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public KLBFPNEPJDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4E68590", Offset = "0x4E67790", VA = "0x184E68590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4E68660", Offset = "0x4E67860", VA = "0x184E68660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class LBPHBOAADDP : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public KMDHDDICNKI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private BGGHJAJDAHA <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public LBPHBOAADDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4E686A0", Offset = "0x4E678A0", VA = "0x184E686A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4E68790", Offset = "0x4E67990", VA = "0x184E68790", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E57710", Offset = "0x4E56910", VA = "0x184E57710")]
	public static NHIOCEAPLGE HMONKOBOGHB(Action BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4E577C0", Offset = "0x4E569C0", VA = "0x184E577C0")]
	public static NHIOCEAPLGE HMONKOBOGHB(Behaviour JDFBABENAGD, Action BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4E57880", Offset = "0x4E56A80", VA = "0x184E57880")]
	public static NHIOCEAPLGE HMONKOBOGHB(Behaviour JDFBABENAGD, Action<float> BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4E57990", Offset = "0x4E56B90", VA = "0x184E57990")]
	[IteratorStateMachine(typeof(KLBFPNEPJDC))]
	private static IEnumerator<MPEFECEHMLJ> LMHNGMOGJKH(KMDHDDICNKI EKPKHDPLAGE, Action BCDNPHJJGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4E57A10", Offset = "0x4E56C10", VA = "0x184E57A10")]
	[IteratorStateMachine(typeof(LBPHBOAADDP))]
	private static IEnumerator<MPEFECEHMLJ> LMHNGMOGJKH(KMDHDDICNKI EKPKHDPLAGE, Action<float> BCDNPHJJGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class NIDFAOLDDEP
{
	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F610", Offset = "0x4E6E810", VA = "0x184E6F610")]
	public static IDisposable HMONKOBOGHB(this MonoBehaviour NOJBMHOHPDB, Action BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F590", Offset = "0x4E6E790", VA = "0x184E6F590")]
	public static IDisposable HMONKOBOGHB(this MonoBehaviour NOJBMHOHPDB, Action<float> BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F7B0", Offset = "0x4E6E9B0", VA = "0x184E6F7B0")]
	public static IDisposable KGILAIAHHCE(this MonoBehaviour NOJBMHOHPDB, Action BCDNPHJJGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F820", Offset = "0x4E6EA20", VA = "0x184E6F820")]
	public static IDisposable LBFNILJHKNK(this MonoBehaviour NOJBMHOHPDB, Action BCDNPHJJGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F9C0", Offset = "0x4E6EBC0", VA = "0x184E6F9C0")]
	public static IDisposable PKDIGHCDKKE(this MonoBehaviour NOJBMHOHPDB, Action BCDNPHJJGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F690", Offset = "0x4E6E890", VA = "0x184E6F690")]
	public static IDisposable IACKMEKIPFA(this MonoBehaviour NOJBMHOHPDB, Action BCDNPHJJGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FAD0", Offset = "0x4E6ECD0", VA = "0x184E6FAD0")]
	public static IDisposable PMMALJGHDGI(this MonoBehaviour NOJBMHOHPDB, Action BCDNPHJJGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F340", Offset = "0x4E6E540", VA = "0x184E6F340")]
	public static IDisposable EJGDEBJMLBH(this MonoBehaviour NOJBMHOHPDB, float AGJGDJAOOBG, Action<float> BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN, bool AAPIABGMGOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F220", Offset = "0x4E6E420", VA = "0x184E6F220")]
	public static IDisposable DCNDENPKMMO(this MonoBehaviour NOJBMHOHPDB, float AGJGDJAOOBG, Action<float> BCDNPHJJGCA, KMDHDDICNKI DJDNICKNLDN, bool AAPIABGMGOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F0F0", Offset = "0x4E6E2F0", VA = "0x184E6F0F0")]
	public static IDisposable AHOPOMKMLGP(this MonoBehaviour NOJBMHOHPDB, float AGJGDJAOOBG, Action<float> BCDNPHJJGCA, bool AAPIABGMGOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FA40", Offset = "0x4E6EC40", VA = "0x184E6FA40")]
	public static IDisposable PKIFDIAFPHJ(this MonoBehaviour NOJBMHOHPDB, Action<float> BCDNPHJJGCA, bool AAPIABGMGOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F8A0", Offset = "0x4E6EAA0", VA = "0x184E6F8A0")]
	public static IDisposable NDPOHJBELIE(this MonoBehaviour NOJBMHOHPDB, Action<float> BCDNPHJJGCA, bool AAPIABGMGOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F500", Offset = "0x4E6E700", VA = "0x184E6F500")]
	public static IDisposable GPCEDAIGLEI(this MonoBehaviour NOJBMHOHPDB, Action<float> BCDNPHJJGCA, bool AAPIABGMGOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F930", Offset = "0x4E6EB30", VA = "0x184E6F930")]
	public static IDisposable PFOCOPIBJOC(this MonoBehaviour NOJBMHOHPDB, Action<float> BCDNPHJJGCA, bool AAPIABGMGOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F3E0", Offset = "0x4E6E5E0", VA = "0x184E6F3E0")]
	public static IDisposable FACOKAMNFGI(this MonoBehaviour NOJBMHOHPDB, Action<float> BCDNPHJJGCA, bool AAPIABGMGOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F470", Offset = "0x4E6E670", VA = "0x184E6F470")]
	public static IDisposable FHMIGMCNAMP(this MonoBehaviour NOJBMHOHPDB, Action<float> BCDNPHJJGCA, bool AAPIABGMGOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F190", Offset = "0x4E6E390", VA = "0x184E6F190")]
	public static IDisposable BBFIPEAFGCK(this MonoBehaviour NOJBMHOHPDB, Action<float> BCDNPHJJGCA, bool AAPIABGMGOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F710", Offset = "0x4E6E910", VA = "0x184E6F710")]
	public static IDisposable IJDNJHDOMMF(this MonoBehaviour NOJBMHOHPDB, float AGJGDJAOOBG, Action<float> BCDNPHJJGCA, bool AAPIABGMGOD = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class CAOLHGADNKE : BOBANGGLKDD, NHIOCEAPLGE, CICCNDFLPHA, GIOBGNHJLID, IEnumerator, MPEFECEHMLJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private KMDHDDICNKI IEHJBJNAMIP;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private KMDHDDICNKI BHGHMKCBILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xFCDE70", Offset = "0xFCD070", VA = "0x180FCDE70", Slot = "23")]
		get
		{
			return default(KMDHDDICNKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public KMDHDDICNKI HKPCPBIBJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA92BA0", Offset = "0xA91DA0", VA = "0x180A92BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private float GOBJDIOMOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xAFA4D0", Offset = "0xAF96D0", VA = "0x180AFA4D0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool KGBFDFPBHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4E58D30", Offset = "0x4E57F30", VA = "0x184E58D30", Slot = "24")]
	private bool DILPCHINGGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4E58D50", Offset = "0x4E57F50", VA = "0x184E58D50", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4E58D60", Offset = "0x4E57F60", VA = "0x184E58D60")]
	public CAOLHGADNKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal interface CINKFGPDNNC
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DEKBKAFCAME
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool LBOKBNIOFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class NKKMLIDEKDM
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class GELEKIIJANC : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public KMDHDDICNKI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public GELEKIIJANC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4E629A0", Offset = "0x4E61BA0", VA = "0x184E629A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4E62A10", Offset = "0x4E61C10", VA = "0x184E62A10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class NACFBCHIIMJ : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public KMDHDDICNKI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private MPEFECEHMLJ <wait>5__1;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public NACFBCHIIMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4E6EAE0", Offset = "0x4E6DCE0", VA = "0x184E6EAE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x4E6EB70", Offset = "0x4E6DD70", VA = "0x184E6EB70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FEC0", Offset = "0x4E6F0C0", VA = "0x184E6FEC0")]
	[IteratorStateMachine(typeof(GELEKIIJANC))]
	private static IEnumerator<MPEFECEHMLJ> JGFKJGEDBAA(float IDAEOLGPOPH, KMDHDDICNKI EKPKHDPLAGE, Action JLLIOKOLDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4E70120", Offset = "0x4E6F320", VA = "0x184E70120")]
	[IteratorStateMachine(typeof(NACFBCHIIMJ))]
	private static IEnumerator<MPEFECEHMLJ> MIPJCGLCALE(float IDAEOLGPOPH, KMDHDDICNKI EKPKHDPLAGE, Action JLLIOKOLDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4E70400", Offset = "0x4E6F600", VA = "0x184E70400")]
	public static IDisposable OGFGIGECCLI(this MonoBehaviour NOJBMHOHPDB, float IDAEOLGPOPH, Action JLLIOKOLDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4E70210", Offset = "0x4E6F410", VA = "0x184E70210")]
	public static NHIOCEAPLGE NDPKBGHGCON(this MonoBehaviour NOJBMHOHPDB, float IDAEOLGPOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4E702D0", Offset = "0x4E6F4D0", VA = "0x184E702D0")]
	public static NHIOCEAPLGE OGFGIGECCLI(this MonoBehaviour NOJBMHOHPDB, float IDAEOLGPOPH, KMDHDDICNKI EKPKHDPLAGE, Action JLLIOKOLDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FC20", Offset = "0x4E6EE20", VA = "0x184E6FC20")]
	public static NHIOCEAPLGE EHODPNHGNCL(this MonoBehaviour NOJBMHOHPDB, Action JLLIOKOLDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4E701B0", Offset = "0x4E6F3B0", VA = "0x184E701B0")]
	public static NHIOCEAPLGE MPJHHEGDKJP(this MonoBehaviour NOJBMHOHPDB, Action JLLIOKOLDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FC40", Offset = "0x4E6EE40", VA = "0x184E6FC40")]
	public static NHIOCEAPLGE FAOBHLIAKEH(this MonoBehaviour NOJBMHOHPDB, Action JLLIOKOLDJD, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FF50", Offset = "0x4E6F150", VA = "0x184E6FF50")]
	public static NHIOCEAPLGE LOMIOAHJFDP(this MonoBehaviour NOJBMHOHPDB, Action JLLIOKOLDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4E701E0", Offset = "0x4E6F3E0", VA = "0x184E701E0")]
	public static NHIOCEAPLGE NDOLDPFPPID(this MonoBehaviour NOJBMHOHPDB, Action JLLIOKOLDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4E70520", Offset = "0x4E6F720", VA = "0x184E70520")]
	public static NHIOCEAPLGE PHNCMJMGFBE(this MonoBehaviour NOJBMHOHPDB, Action JLLIOKOLDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FDF0", Offset = "0x4E6EFF0", VA = "0x184E6FDF0")]
	private static NHIOCEAPLGE IKLAELMOOGJ(MonoBehaviour NOJBMHOHPDB, KMDHDDICNKI DJDNICKNLDN, Action JLLIOKOLDJD, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FF80", Offset = "0x4E6F180", VA = "0x184E6FF80")]
	public static NHIOCEAPLGE MBOELDPFHIM(this MonoBehaviour NOJBMHOHPDB, float AOJPIKCCPAJ, Action JLLIOKOLDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FB50", Offset = "0x4E6ED50", VA = "0x184E6FB50")]
	public static NHIOCEAPLGE BHEIDLPJEAO(this MonoBehaviour NOJBMHOHPDB, float AOJPIKCCPAJ, Action JLLIOKOLDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FD20", Offset = "0x4E6EF20", VA = "0x184E6FD20")]
	public static NHIOCEAPLGE GMJAENEFAND(this MonoBehaviour NOJBMHOHPDB, float AOJPIKCCPAJ, Action JLLIOKOLDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4E70050", Offset = "0x4E6F250", VA = "0x184E70050")]
	public static NHIOCEAPLGE MEGJKGKONMN(this MonoBehaviour NOJBMHOHPDB, float AOJPIKCCPAJ, Action JLLIOKOLDJD)
	{
		return null;
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

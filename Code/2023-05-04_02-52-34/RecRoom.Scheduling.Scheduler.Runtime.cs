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
public class KKNDEEAADEN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority OPKMMOKDHCO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x58835B0", Offset = "0x58829B0", VA = "0x1858835B0")]
	public KKNDEEAADEN(ThreadPriority GCPNDINHBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x58835A0", Offset = "0x58829A0", VA = "0x1858835A0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> MHJBIDJCCNA(List<PlayerLoopSystem> DFKHIBLIHPO, int CDPIBDAMOBN);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct FNFBNDHPIEG
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct EBGMGPAEHBL
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static FNCKCCFNKKK POAHNBBMINK;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x587ACF0", Offset = "0x587A0F0", VA = "0x18587ACF0")]
				public static PlayerLoopSystem NLDJOGFILIH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct LDOFAPBAJDB
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static FNCKCCFNKKK LMMGKJCLHLA;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x5885C10", Offset = "0x5885010", VA = "0x185885C10")]
				public static PlayerLoopSystem NLDJOGFILIH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct CFLBIIODNHO
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static FNCKCCFNKKK FDNBFEIPIOI;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x5876620", Offset = "0x5875A20", VA = "0x185876620")]
				public static PlayerLoopSystem NLDJOGFILIH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct LDHAPEABIEC
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static FNCKCCFNKKK BGAMHHKNFAF;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static FNCKCCFNKKK HLGGDPALIAI;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static FNCKCCFNKKK EEFALAPBDKB;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static FNCKCCFNKKK LECPOKEILHI;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x5885980", Offset = "0x5884D80", VA = "0x185885980")]
				public static PlayerLoopSystem NLDJOGFILIH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct OMDLPCGLDIF
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static FNCKCCFNKKK JDCPINCBNMM;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5889680", Offset = "0x5888A80", VA = "0x185889680")]
				public static PlayerLoopSystem NLDJOGFILIH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct MMLICINDKKI
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static FNCKCCFNKKK BGAMHHKNFAF;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static FNCKCCFNKKK HLGGDPALIAI;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static FNCKCCFNKKK EEFALAPBDKB;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static FNCKCCFNKKK LECPOKEILHI;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x5887A70", Offset = "0x5886E70", VA = "0x185887A70")]
				public static PlayerLoopSystem NLDJOGFILIH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct ADMDOPPJPKD
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static FNCKCCFNKKK OAPIKDKBAKC;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x5874580", Offset = "0x5873980", VA = "0x185874580")]
				public static PlayerLoopSystem NLDJOGFILIH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct LDAAAKIEIEB
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static FNCKCCFNKKK LOHHIIMJGPL;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x58857A0", Offset = "0x5884BA0", VA = "0x1858857A0")]
				public static PlayerLoopSystem NLDJOGFILIH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct JNGEFFPDFOH
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static FNCKCCFNKKK ELLLIFDHKJF;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x5882A20", Offset = "0x5881E20", VA = "0x185882A20")]
				public static PlayerLoopSystem NLDJOGFILIH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct CKFKNCLAIFG
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static FNCKCCFNKKK NCBEPGLPBCO;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x5876C70", Offset = "0x5876070", VA = "0x185876C70")]
				public static PlayerLoopSystem NLDJOGFILIH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct CAOEHDAPFCA
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static FNCKCCFNKKK MJEKCBJKCNF;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x5875FD0", Offset = "0x58753D0", VA = "0x185875FD0")]
				public static PlayerLoopSystem NLDJOGFILIH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public enum ADGPHKJDIJE : byte
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
			public struct BDBOBIHKNHE
			{
				[Cpp2IlInjected.Token(Token = "0x200001E")]
				[CompilerGenerated]
				private sealed class IGGPFCPLJOH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					public ADGPHKJDIJE updateStage;

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
					public IGGPFCPLJOH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x587E5D0", Offset = "0x587D9D0", VA = "0x18587E5D0")]
					internal void <CreateSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static global::PCAPMAFAHIC<ADGPHKJDIJE> FAGGFBDPKFG;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5874D40", Offset = "0x5874140", VA = "0x185874D40")]
				public static PlayerLoopSystem NLDJOGFILIH(ADGPHKJDIJE JFDPCJMJLJN)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct HGAAGNKKEIO
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class LFMEICIHFCL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public CFLOLCEHAGK.AKGJFMHHNJE key;

					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
					public LFMEICIHFCL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x5887290", Offset = "0x5886690", VA = "0x185887290")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000035")]
				public static IDisposable EHPCJBKPFCO;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x587D980", Offset = "0x587CD80", VA = "0x18587D980")]
				public static PlayerLoopSystem DKGOFNOFANP(CFLOLCEHAGK.AKGJFMHHNJE OGFDNCPKECB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			internal struct KEGHOCEBPON
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				[CompilerGenerated]
				private sealed class CMJOOGPFHDC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public CFLOLCEHAGK.AKGJFMHHNJE key;

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
					public CMJOOGPFHDC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x5876E50", Offset = "0x5876250", VA = "0x185876E50")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x5882C00", Offset = "0x5882000", VA = "0x185882C00")]
				public static PlayerLoopSystem DKGOFNOFANP(CFLOLCEHAGK.AKGJFMHHNJE OGFDNCPKECB)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class FJFGAELAHDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public FJFGAELAHDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x587BCD0", Offset = "0x587B0D0", VA = "0x18587BCD0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool HNJKBJHCBMP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool MNFELHKEFOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x587A0F0", Offset = "0x58794F0", VA = "0x18587A0F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5879CC0", Offset = "0x58790C0", VA = "0x185879CC0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5877640", Offset = "0x5876A40", VA = "0x185877640")]
		private static void EJCKFBLGCNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x587A420", Offset = "0x5879820", VA = "0x18587A420")]
		private static void NICHBDLDNJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5877310", Offset = "0x5876710", VA = "0x185877310")]
		private static void BPEPAKPFDFO(string DOACCAJGALA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x58770E0", Offset = "0x58764E0", VA = "0x1858770E0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x587A130", Offset = "0x5879530", VA = "0x18587A130")]
		private static void KHDOELGFPOB(CFLOLCEHAGK.AKGJFMHHNJE OGFDNCPKECB, ref PlayerLoopSystem EHMGMKKDIEF, Type ENIANPNCBDN, Type PECGCGIPCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5879D00", Offset = "0x5879100", VA = "0x185879D00")]
		private static void GLKANCNKNEN(ref PlayerLoopSystem EHMGMKKDIEF, Type ENIANPNCBDN, Type PECGCGIPCLI, MHJBIDJCCNA LOHKAMFIJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x587A2F0", Offset = "0x58796F0", VA = "0x18587A2F0")]
		private static void MCEEOGJPEKD(ref PlayerLoopSystem EHMGMKKDIEF, Type ENIANPNCBDN, Type PECGCGIPCLI, PlayerLoopSystem? BGLMDLBHODL, PlayerLoopSystem? AAOGIIBEPCC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class CFLOLCEHAGK
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public enum AKGJFMHHNJE
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
	public class PJIFMKNALMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly AKGJFMHHNJE FDBPADCCNFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly AGLDDIPHHDH DIBALKOANFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private long FAPMLKJJLDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private long MLFOHKEPDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long HOPCEIIKHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int CAEFJIMAPAI;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x588AB40", Offset = "0x5889F40", VA = "0x18588AB40")]
		public PJIFMKNALMK(AKGJFMHHNJE FINHIPLPKNB, int CAOCOMEFLJF = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x588AAD0", Offset = "0x5889ED0", VA = "0x18588AAD0")]
		public void MEDONDFDBBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x588A870", Offset = "0x5889C70", VA = "0x18588A870")]
		public void FBILGAAKNJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x588A8D0", Offset = "0x5889CD0", VA = "0x18588A8D0")]
		public void HOPBCJAIDPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static AKGJFMHHNJE[] IPHKHEEIKPC;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static PJIFMKNALMK[] PPGLGDGEPEJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5876800", Offset = "0x5875C00", VA = "0x185876800")]
	public static PJIFMKNALMK AJPNILGLKII(AKGJFMHHNJE OGFDNCPKECB, int CAOCOMEFLJF = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5876A80", Offset = "0x5875E80", VA = "0x185876A80")]
	public static PJIFMKNALMK KHOPHLFOOAI(AKGJFMHHNJE OGFDNCPKECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x58769D0", Offset = "0x5875DD0", VA = "0x1858769D0")]
	public static void GAHLACOEALB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class AGLDDIPHHDH : EBPAFFJGMHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int CNLLNGHFNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Queue<double> MHHPOFNKLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private double ONLKOJHBEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private double JKHCMKCHKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private double BLMDOMKKAJO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double JNMMJBEPGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5874760", Offset = "0x5873B60", VA = "0x185874760", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double ODLPMBNOKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2158D20", Offset = "0x2158120", VA = "0x182158D20", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double DCKEFAHDOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3404A70", Offset = "0x3403E70", VA = "0x183404A70", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5874960", Offset = "0x5873D60", VA = "0x185874960")]
	public AGLDDIPHHDH(int FLDPANKCPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5874830", Offset = "0x5873C30", VA = "0x185874830", Slot = "7")]
	public void LIPGHGOJIGK(double IHADMCKJLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x58747C0", Offset = "0x5873BC0", VA = "0x1858747C0", Slot = "8")]
	public void JAIKDMLJCNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class MIPICNJKCGI : EBPAFFJGMHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private long EJMNNLNLAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double ABFJAPBKNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double GDKOCKNOOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double FCMGEONBMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double LCEPADHPPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double ONLKOJHBEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double JKHCMKCHKPC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double ODLPMBNOKOC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x382A6A0", Offset = "0x3829AA0", VA = "0x18382A6A0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double DCKEFAHDOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9949B0", Offset = "0x993DB0", VA = "0x1809949B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double NGIHKBPLHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3404A60", Offset = "0x3403E60", VA = "0x183404A60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JNMMJBEPGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x382A5D0", Offset = "0x38299D0", VA = "0x18382A5D0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5887940", Offset = "0x5886D40", VA = "0x185887940", Slot = "7")]
	public virtual void LIPGHGOJIGK(double IHADMCKJLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5887900", Offset = "0x5886D00", VA = "0x185887900", Slot = "8")]
	public virtual void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x587B3F0", Offset = "0x587A7F0", VA = "0x18587B3F0")]
	public MIPICNJKCGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class EPDKECCIADE : MIPICNJKCGI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double GFBCKLOIMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x587B3E0", Offset = "0x587A7E0", VA = "0x18587B3E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x587B290", Offset = "0x587A690", VA = "0x18587B290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x587B2A0", Offset = "0x587A6A0", VA = "0x18587B2A0", Slot = "7")]
	public override void LIPGHGOJIGK(double IHADMCKJLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x587B250", Offset = "0x587A650", VA = "0x18587B250", Slot = "8")]
	public override void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x587B3F0", Offset = "0x587A7F0", VA = "0x18587B3F0")]
	public EPDKECCIADE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface EBPAFFJGMHA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double JNMMJBEPGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double ODLPMBNOKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double DCKEFAHDOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class EPFCNJIDKOC
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private interface FHJPFKKFEPC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool NPGAFGJFFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JHOFICMAMCM();
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private abstract class PGKLBOFEBPO<TPromise, TMainThreadPromise> : FHJPFKKFEPC where TPromise : JKAHJLGEFLE where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly TPromise NIMKDFKLNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected readonly TMainThreadPromise PFANFCEJODJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise DNPHCLDCOML
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA440", Offset = "0x2AB9840", VA = "0x182ABA440")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NPGAFGJFFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA3F0", Offset = "0x2AB97F0", VA = "0x182ABA3F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F9ECC0", Offset = "0x1F9E0C0", VA = "0x181F9ECC0")]
		protected PGKLBOFEBPO(TPromise NIMKDFKLNDK, TMainThreadPromise EGFJPGIGHPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA4A0", Offset = "0x2AB98A0", VA = "0x182ABA4A0", Slot = "5")]
		public void JHOFICMAMCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void HCNFJLAKMOA(TPromise NIMKDFKLNDK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class CFKMAKAJBNA<T> : PGKLBOFEBPO<global::ODHJGGEEIEO<T>, global::GOEHKJJNHGC<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4190B20", Offset = "0x418FF20", VA = "0x184190B20")]
		public CFKMAKAJBNA(global::ODHJGGEEIEO<T> NIMKDFKLNDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4190910", Offset = "0x418FD10", VA = "0x184190910", Slot = "6")]
		protected override void HCNFJLAKMOA(global::ODHJGGEEIEO<T> NIMKDFKLNDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x41908E0", Offset = "0x418FCE0", VA = "0x1841908E0")]
		[CompilerGenerated]
		private void FANOMDKAMAK(T JGINNNKFHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xF92410", Offset = "0xF91810", VA = "0x180F92410")]
		[CompilerGenerated]
		private void BPEBLIMNHBN(string NOGDNAGMMCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class FNBCFJPBDOG : FHJPFKKFEPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly Action DAAMKALKLMO;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NPGAFGJFFDP
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
		public FNBCFJPBDOG(Action DAAMKALKLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xCDC8D0", Offset = "0xCDBCD0", VA = "0x180CDC8D0", Slot = "5")]
		public void JHOFICMAMCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<FHJPFKKFEPC> FCKBAJAPLDD;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2192200", Offset = "0x2191600", VA = "0x182192200")]
	public static global::ODHJGGEEIEO<T> FIDHHFBMPEN<T>(this global::ODHJGGEEIEO<T> NIMKDFKLNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x587B910", Offset = "0x587AD10", VA = "0x18587B910")]
	public static void FIDHHFBMPEN(Action DAAMKALKLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2192140", Offset = "0x2191540", VA = "0x182192140")]
	private static global::ODHJGGEEIEO<T> CKADFHBCEOO<T>(global::ODHJGGEEIEO<T> NIMKDFKLNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x587B420", Offset = "0x587A820", VA = "0x18587B420")]
	private static void APLPMHJOIGB(FHJPFKKFEPC LMJMPFKGFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x587B620", Offset = "0x587AA20", VA = "0x18587B620")]
	private static void ELDOBJODGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x587BA70", Offset = "0x587AE70", VA = "0x18587BA70")]
	private static void JFPNKIHPIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x587B9A0", Offset = "0x587ADA0", VA = "0x18587B9A0")]
	private static void JDGHJKECDEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KOKHLGLBIBM
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private struct BOLIGHPPICA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public TaskCompletionSource<Scene> CGMKAEHNKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public readonly string HJEGLBELAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly LoadSceneMode AHPJCIAEOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly bool LNHAKJNDEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly HKNIJBILNIP BDBJGJIIKDE;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5875BE0", Offset = "0x5874FE0", VA = "0x185875BE0")]
		public BOLIGHPPICA(TaskCompletionSource<Scene> MFBBPIFPOJB, string HJEGLBELAHC, LoadSceneMode AHPJCIAEOLA, bool LNHAKJNDEPA, HKNIJBILNIP BDBJGJIIKDE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct GNHLLJENEMO : IAsyncStateMachine
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
		public HKNIJBILNIP stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private global::JIHOHILIMPL<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x587D280", Offset = "0x587C680", VA = "0x18587D280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x587D8F0", Offset = "0x587CCF0", VA = "0x18587D8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct APPHDEKJLEK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5874A40", Offset = "0x5873E40", VA = "0x185874A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct BPHPMJFJAKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private BOLIGHPPICA <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5875C40", Offset = "0x5875040", VA = "0x185875C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JIIBLEJNONE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public global::GOEHKJJNHGC<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public JIIBLEJNONE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x587EEF0", Offset = "0x587E2F0", VA = "0x18587EEF0")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NLENNEHFFDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public HKNIJBILNIP stackTimer;

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
		private JIIBLEJNONE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private HKNIJBILNIP <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private HKNIJBILNIP <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5888820", Offset = "0x5887C20", VA = "0x185888820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x58891A0", Offset = "0x58885A0", VA = "0x1858891A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct LBGLJBEHLMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private HKNIJBILNIP <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private HKNIJBILNIP <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5884F10", Offset = "0x5884310", VA = "0x185884F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5885750", Offset = "0x5884B50", VA = "0x185885750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class KKIEENKEANG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public KKIEENKEANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5883570", Offset = "0x5882970", VA = "0x185883570")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class GJKLNALLCIK : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public IDFJJMAGGAN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public GJKLNALLCIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x587D1A0", Offset = "0x587C5A0", VA = "0x18587D1A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x587CE40", Offset = "0x587C240", VA = "0x18587CE40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x587D230", Offset = "0x587C630", VA = "0x18587D230")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x587D160", Offset = "0x587C560", VA = "0x18587D160", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PNOIGNKGDDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public global::GOEHKJJNHGC<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PNOIGNKGDDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class OFLNAFGDKEO : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::GOEHKJJNHGC<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private PNOIGNKGDDA <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public OFLNAFGDKEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x58891F0", Offset = "0x58885F0", VA = "0x1858891F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5889640", Offset = "0x5888A40", VA = "0x185889640", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static JKAHJLGEFLE OFFFHPMILIP;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static AsyncOperation OAFNDOECFJO;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static JKAHJLGEFLE CDFFCKBHCCP;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string PCILCAGPPCP;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority GGAFKAHNDKE;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task DNCMJNBEANO;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Queue<BOLIGHPPICA> JMLCBLNCIKB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static Task NOAIMKBIJEE;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool CBPOKIIPEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5884250", Offset = "0x5883650", VA = "0x185884250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool EFPDCCLLNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5883BC0", Offset = "0x5882FC0", VA = "0x185883BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool EFIAEPFCKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5883C70", Offset = "0x5883070", VA = "0x185883C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> COCELKPADJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5884410", Offset = "0x5883810", VA = "0x185884410")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5883D30", Offset = "0x5883130", VA = "0x185883D30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5884020", Offset = "0x5883420", VA = "0x185884020")]
	[PAECCEJEKMD(KFMLDOLCGMJ.EnteredEditModeNextFrame, 0)]
	private static void FDEFJDBOIBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5883EC0", Offset = "0x58832C0", VA = "0x185883EC0")]
	[AsyncStateMachine(typeof(GNHLLJENEMO))]
	public static Task<Scene> EKPEPFCICAM(string HJEGLBELAHC, LoadSceneMode AHPJCIAEOLA = LoadSceneMode.Single, bool LNHAKJNDEPA = false, [Optional] HKNIJBILNIP KOBNLIMODNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5884C80", Offset = "0x5884080", VA = "0x185884C80")]
	[AsyncStateMachine(typeof(APPHDEKJLEK))]
	private static Task PKLAJNIBGND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5884810", Offset = "0x5883C10", VA = "0x185884810")]
	[AsyncStateMachine(typeof(BPHPMJFJAKL))]
	private static Task OCNOCEJJJEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x58840F0", Offset = "0x58834F0", VA = "0x1858840F0")]
	[AsyncStateMachine(typeof(NLENNEHFFDM))]
	private static Task<Scene> JGAKHJPMHDE(string HJEGLBELAHC, LoadSceneMode AHPJCIAEOLA, bool LNHAKJNDEPA, HKNIJBILNIP BDBJGJIIKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5883A80", Offset = "0x5882E80", VA = "0x185883A80")]
	[AsyncStateMachine(typeof(LBGLJBEHLMH))]
	private static Task<Scene> BDDOBENBKOO(HKNIJBILNIP BDBJGJIIKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5884510", Offset = "0x5883910", VA = "0x185884510")]
	public static global::ODHJGGEEIEO<Scene> NAIFNKKLBIH(string HJEGLBELAHC, LoadSceneMode AHPJCIAEOLA = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x58849A0", Offset = "0x5883DA0", VA = "0x1858849A0")]
	public static JKAHJLGEFLE OJCEBGMNDDC(string HJEGLBELAHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5883E30", Offset = "0x5883230", VA = "0x185883E30")]
	[IteratorStateMachine(typeof(GJKLNALLCIK))]
	private static IEnumerator<MEOADLJIECK> DAFEBBFCJAK(string HJEGLBELAHC, IDFJJMAGGAN FCCIKGLCAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5884900", Offset = "0x5883D00", VA = "0x185884900")]
	[IteratorStateMachine(typeof(OFLNAFGDKEO))]
	private static IEnumerator<MEOADLJIECK> OGHMMBFAJKB(string HJEGLBELAHC, LoadSceneMode AHPJCIAEOLA, global::GOEHKJJNHGC<Scene> FCCIKGLCAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x58846B0", Offset = "0x5883AB0", VA = "0x1858846B0")]
	public static bool OALJGCIAFFD(out string FBAGAPENNHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class EIPNMJIMBPA
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x587AF50", Offset = "0x587A350", VA = "0x18587AF50")]
	public static IDisposable HOCBBOIPBOC(this MFABPFMFOOL PKDAKJPDDGD, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x587AFD0", Offset = "0x587A3D0", VA = "0x18587AFD0")]
	public static IDisposable IJBDNLJPKAB(this MFABPFMFOOL PKDAKJPDDGD, Action<float> KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x587AED0", Offset = "0x587A2D0", VA = "0x18587AED0")]
	public static IDisposable FCMPFHDDAME(this MFABPFMFOOL PKDAKJPDDGD, Action<float> KPOMAEBEHKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class PKFIGPIKAFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x588B090", Offset = "0x588A490", VA = "0x18588B090")]
	public static IDisposable IMAHKDEDKIM(this MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x588B010", Offset = "0x588A410", VA = "0x18588B010")]
	public static IDisposable IMAHKDEDKIM(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x588AE80", Offset = "0x588A280", VA = "0x18588AE80")]
	public static IDisposable HGAJENLLFEE(this MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x588B380", Offset = "0x588A780", VA = "0x18588B380")]
	public static IDisposable MCKPAKFDOPH(this MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x588B530", Offset = "0x588A930", VA = "0x18588B530")]
	public static IDisposable OOGMPBGFDHI(this MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x588AF90", Offset = "0x588A390", VA = "0x18588AF90")]
	public static IDisposable IBCINEDGOLC(this MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x588ACD0", Offset = "0x588A0D0", VA = "0x18588ACD0")]
	public static IDisposable ENFGOLIEKAL(this MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x588B490", Offset = "0x588A890", VA = "0x18588B490")]
	public static IDisposable ONBIKHJIOCG(this MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x588B1A0", Offset = "0x588A5A0", VA = "0x18588B1A0")]
	public static IDisposable JDMFBFEPOPO(this MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x588AD50", Offset = "0x588A150", VA = "0x18588AD50")]
	public static IDisposable GIAFBKJHPCK(this MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x588B260", Offset = "0x588A660", VA = "0x18588B260")]
	public static IDisposable KLJJLHEJOCA(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x588B110", Offset = "0x588A510", VA = "0x18588B110")]
	public static IDisposable IOJPAMIKFGK(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x588ADF0", Offset = "0x588A1F0", VA = "0x18588ADF0")]
	public static IDisposable GMNOANOFBPM(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x588AC40", Offset = "0x588A040", VA = "0x18588AC40")]
	public static IDisposable BPAGGPIJLIM(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x588B2F0", Offset = "0x588A6F0", VA = "0x18588B2F0")]
	public static IDisposable LAMFHDNEODJ(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x588B1D0", Offset = "0x588A5D0", VA = "0x18588B1D0")]
	public static IDisposable KCCJANAGDHE(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x588B400", Offset = "0x588A800", VA = "0x18588B400")]
	public static IDisposable OMNJJMPLBKK(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x588AEF0", Offset = "0x588A2F0", VA = "0x18588AEF0")]
	public static IDisposable HGGPNNBPFOM(this MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x588B5B0", Offset = "0x588A9B0", VA = "0x18588B5B0")]
	public static IDisposable PCBCCAKHBPN(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class KLOAAFEBNCA
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class PEDEJKAGHEM : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public GLMLDOMIGMH.NMMGBICHGHP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private DNDJAICDGLN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public PEDEJKAGHEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5889F70", Offset = "0x5889370", VA = "0x185889F70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x588A030", Offset = "0x5889430", VA = "0x18588A030", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class KFLKEFDGJID : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public GLMLDOMIGMH.NMMGBICHGHP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private DNDJAICDGLN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public KFLKEFDGJID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5882D30", Offset = "0x5882130", VA = "0x185882D30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5882E20", Offset = "0x5882220", VA = "0x185882E20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5883810", Offset = "0x5882C10", VA = "0x185883810")]
	public static GNGMNANCADP IMAHKDEDKIM(Action KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x58838C0", Offset = "0x5882CC0", VA = "0x1858838C0")]
	public static GNGMNANCADP IMAHKDEDKIM(Behaviour PKDAKJPDDGD, Action KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5883700", Offset = "0x5882B00", VA = "0x185883700")]
	public static GNGMNANCADP IMAHKDEDKIM(Behaviour PKDAKJPDDGD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5883A00", Offset = "0x5882E00", VA = "0x185883A00")]
	[IteratorStateMachine(typeof(PEDEJKAGHEM))]
	private static IEnumerator<MEOADLJIECK> NMADIIFMKMG(GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5883980", Offset = "0x5882D80", VA = "0x185883980")]
	[IteratorStateMachine(typeof(KFLKEFDGJID))]
	private static IEnumerator<MEOADLJIECK> NMADIIFMKMG(GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action<float> KPOMAEBEHKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class HGFPHCBCIPO
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class MMOOLGDCAOD : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public PFGLMDEFIKI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public MMOOLGDCAOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5887D00", Offset = "0x5887100", VA = "0x185887D00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5887DA0", Offset = "0x58871A0", VA = "0x185887DA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x587DEE0", Offset = "0x587D2E0", VA = "0x18587DEE0")]
	public static GNGMNANCADP IMAHKDEDKIM(float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x587DDD0", Offset = "0x587D1D0", VA = "0x18587DDD0")]
	public static GNGMNANCADP IMAHKDEDKIM(MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x587DAB0", Offset = "0x587CEB0", VA = "0x18587DAB0")]
	public static GNGMNANCADP CDFJHJKJINK(MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x587DC30", Offset = "0x587D030", VA = "0x18587DC30")]
	public static GNGMNANCADP GKMBECKDMJE(MFABPFMFOOL PKDAKJPDDGD, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x587DFE0", Offset = "0x587D3E0", VA = "0x18587DFE0")]
	private static IEnumerator<MEOADLJIECK> NMADIIFMKMG(DBHPJOBGDCD JGJBGLEMPFO, float GBKEOCDGBDD, GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x587DBD0", Offset = "0x587CFD0", VA = "0x18587DBD0")]
	private static IEnumerator<MEOADLJIECK> FAEOMPJFKDP(DBHPJOBGDCD JGJBGLEMPFO, float GBKEOCDGBDD, GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x587DD40", Offset = "0x587D140", VA = "0x18587DD40")]
	[IteratorStateMachine(typeof(MMOOLGDCAOD))]
	private static IEnumerator<MEOADLJIECK> HKKMAJMPJNP(PFGLMDEFIKI LJOLPEJEKCE, float GBKEOCDGBDD, GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action<float> KPOMAEBEHKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class BIOPFBCEJHC
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class ELPCBNPMENB : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public GLMLDOMIGMH.NMMGBICHGHP queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public ELPCBNPMENB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x587B050", Offset = "0x587A450", VA = "0x18587B050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x587B100", Offset = "0x587A500", VA = "0x18587B100", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5875A50", Offset = "0x5874E50", VA = "0x185875A50")]
	[IteratorStateMachine(typeof(ELPCBNPMENB))]
	private static IEnumerator<MEOADLJIECK> BIHGGDMDIOA(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, Func<bool> LAGGEGOCCOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5875AD0", Offset = "0x5874ED0", VA = "0x185875AD0")]
	public static GNGMNANCADP EFLOKABNINK(this MonoBehaviour GEEDNCPBAAN, Func<bool> LAGGEGOCCOE, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI = GLMLDOMIGMH.NMMGBICHGHP.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class GDPKEMEMAOI
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class LAENJIMPMBF : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public GLMLDOMIGMH.NMMGBICHGHP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public LAENJIMPMBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5884E10", Offset = "0x5884210", VA = "0x185884E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5884ED0", Offset = "0x58842D0", VA = "0x185884ED0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class EOAECMNEJBM : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public GLMLDOMIGMH.NMMGBICHGHP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private MEOADLJIECK <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public EOAECMNEJBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x587B140", Offset = "0x587A540", VA = "0x18587B140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x587B210", Offset = "0x587A610", VA = "0x18587B210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x587C4A0", Offset = "0x587B8A0", VA = "0x18587C4A0")]
	[IteratorStateMachine(typeof(LAENJIMPMBF))]
	private static IEnumerator<MEOADLJIECK> LBCIFDIBHCO(float ONPCMEEMBBB, GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x587BE10", Offset = "0x587B210", VA = "0x18587BE10")]
	[IteratorStateMachine(typeof(EOAECMNEJBM))]
	private static IEnumerator<MEOADLJIECK> CMDPEEFIFIA(float ONPCMEEMBBB, GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x587C250", Offset = "0x587B650", VA = "0x18587C250")]
	public static IDisposable GOMILCMCHHO(this MonoBehaviour GEEDNCPBAAN, float ONPCMEEMBBB, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x587C730", Offset = "0x587BB30", VA = "0x18587C730")]
	public static GNGMNANCADP PJPDMCHNEHN(this MonoBehaviour GEEDNCPBAAN, float ONPCMEEMBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x587C370", Offset = "0x587B770", VA = "0x18587C370")]
	public static GNGMNANCADP GOMILCMCHHO(this MonoBehaviour GEEDNCPBAAN, float ONPCMEEMBBB, GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x587BDF0", Offset = "0x587B1F0", VA = "0x18587BDF0")]
	public static GNGMNANCADP BBAKCDOPDAJ(this MonoBehaviour GEEDNCPBAAN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x587C630", Offset = "0x587BA30", VA = "0x18587C630")]
	public static GNGMNANCADP OOKBBBJAGNM(this MonoBehaviour GEEDNCPBAAN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x587BEA0", Offset = "0x587B2A0", VA = "0x18587BEA0")]
	public static GNGMNANCADP DFONFJPDFIC(this MonoBehaviour GEEDNCPBAAN, Action MPPDBHKFNNP, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x587C530", Offset = "0x587B930", VA = "0x18587C530")]
	public static GNGMNANCADP LCMHEILCJCP(this MonoBehaviour GEEDNCPBAAN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x587C050", Offset = "0x587B450", VA = "0x18587C050")]
	public static GNGMNANCADP FEAPICJOCIA(this MonoBehaviour GEEDNCPBAAN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x587C150", Offset = "0x587B550", VA = "0x18587C150")]
	public static GNGMNANCADP GDNCGDFGMDL(this MonoBehaviour GEEDNCPBAAN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x587BF80", Offset = "0x587B380", VA = "0x18587BF80")]
	private static GNGMNANCADP DMHFNNNDEDJ(MonoBehaviour GEEDNCPBAAN, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, Action MPPDBHKFNNP, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x587C660", Offset = "0x587BA60", VA = "0x18587C660")]
	public static GNGMNANCADP PCFKAHCFJDJ(this MonoBehaviour GEEDNCPBAAN, float HGKENILGLLN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x587C560", Offset = "0x587B960", VA = "0x18587C560")]
	public static GNGMNANCADP MCJLJCBPKNC(this MonoBehaviour GEEDNCPBAAN, float HGKENILGLLN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x587C180", Offset = "0x587B580", VA = "0x18587C180")]
	public static GNGMNANCADP GNDPOPGKHNB(this MonoBehaviour GEEDNCPBAAN, float HGKENILGLLN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x587C080", Offset = "0x587B480", VA = "0x18587C080")]
	public static GNGMNANCADP FJKIKPFOLMN(this MonoBehaviour GEEDNCPBAAN, float HGKENILGLLN, Action MPPDBHKFNNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class NKFMIAEHLOL : EKNEAHEJGOI, IEnumerable<EKNEAHEJGOI>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly List<EKNEAHEJGOI> EOKILDFPGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool CKMKGJHDECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Action DCLLICGCKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool FLOPPOINHJI;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool GEMCNEPLAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5888640", Offset = "0x5887A40", VA = "0x185888640", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NMOMHIOGMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x58885A0", Offset = "0x58879A0", VA = "0x1858885A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5887EF0", Offset = "0x58872F0", VA = "0x185887EF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5888780", Offset = "0x5887B80", VA = "0x185888780")]
	public NKFMIAEHLOL([Optional] Action DCLLICGCKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5887F90", Offset = "0x5887390", VA = "0x185887F90")]
	public void AGMLDLCGDGN(EKNEAHEJGOI JLOAMIDJLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5888430", Offset = "0x5887830", VA = "0x185888430")]
	private void IJIAAMFDDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5888420", Offset = "0x5887820", VA = "0x185888420", Slot = "7")]
	public bool ICDHPIEDOAL(bool HKPPDHFDHMN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5888140", Offset = "0x5887540", VA = "0x185888140", Slot = "8")]
	public bool ICDHPIEDOAL(Action DAAMKALKLMO, bool HKPPDHFDHMN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x58880C0", Offset = "0x58874C0", VA = "0x1858880C0", Slot = "9")]
	public IEnumerator<EKNEAHEJGOI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x58880C0", Offset = "0x58874C0", VA = "0x1858880C0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class PCOFEDOPEAC : GFDCPLJLPNI
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class NLPNGIMBFDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public PCOFEDOPEAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NLPNGIMBFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5874A10", Offset = "0x5873E10", VA = "0x185874A10")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class AOLKFOHJFPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public PCOFEDOPEAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public AOLKFOHJFPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5874A10", Offset = "0x5873E10", VA = "0x185874A10")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly float KFLEPGFKDCH;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5887540", Offset = "0x5886940", VA = "0x185887540")]
	public PCOFEDOPEAC(Behaviour PKDAKJPDDGD, float KFLEPGFKDCH, [Optional] Action DCLLICGCKKL, [Optional] ABIJEIDBFLE ALGKCFEJIHD, [Optional] DBHPJOBGDCD JGJBGLEMPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5889D70", Offset = "0x5889170", VA = "0x185889D70", Slot = "9")]
	protected override bool GOGFGDIMHFG(Action DAAMKALKLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5889E70", Offset = "0x5889270", VA = "0x185889E70", Slot = "10")]
	protected override bool HCGJACEOKKB(Action DAAMKALKLMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface EKNEAHEJGOI
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool GEMCNEPLAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NMOMHIOGMHM;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ICDHPIEDOAL(bool HKPPDHFDHMN = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ICDHPIEDOAL(Action DAAMKALKLMO, bool HKPPDHFDHMN = false);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class GFDCPLJLPNI : EKNEAHEJGOI
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class MBDDBMLPFGA : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public GFDCPLJLPNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public MBDDBMLPFGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5887760", Offset = "0x5886B60", VA = "0x185887760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5887830", Offset = "0x5886C30", VA = "0x185887830", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly Behaviour PKDAKJPDDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Action DCLLICGCKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private PLALJAJNMKE PKJNNBGJLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly ABIJEIDBFLE ALGKCFEJIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	protected readonly DBHPJOBGDCD JGJBGLEMPFO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GEMCNEPLAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8A9260", Offset = "0x8A8660", VA = "0x1808A9260", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NMOMHIOGMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x587CCA0", Offset = "0x587C0A0", VA = "0x18587CCA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x587C7F0", Offset = "0x587BBF0", VA = "0x18587C7F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x587CD40", Offset = "0x587C140", VA = "0x18587CD40")]
	protected GFDCPLJLPNI(Behaviour PKDAKJPDDGD, [Optional] Action DCLLICGCKKL, [Optional] ABIJEIDBFLE ALGKCFEJIHD, [Optional] DBHPJOBGDCD JGJBGLEMPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x587C930", Offset = "0x587BD30", VA = "0x18587C930", Slot = "7")]
	public bool ICDHPIEDOAL(bool HKPPDHFDHMN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x587C990", Offset = "0x587BD90", VA = "0x18587C990", Slot = "8")]
	public bool ICDHPIEDOAL(Action DAAMKALKLMO, bool HKPPDHFDHMN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GOGFGDIMHFG(Action DAAMKALKLMO);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool HCGJACEOKKB(Action DAAMKALKLMO);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x587C890", Offset = "0x587BC90", VA = "0x18587C890")]
	protected void DPFEAIHCFLK(Action DAAMKALKLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x587C9E0", Offset = "0x587BDE0", VA = "0x18587C9E0")]
	protected JKAHJLGEFLE KDDIGGOJCMO(float JDMBDIMAGHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x587CBE0", Offset = "0x587BFE0", VA = "0x18587CBE0")]
	private void LCMGPDMHDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x587C8B0", Offset = "0x587BCB0", VA = "0x18587C8B0")]
	[IteratorStateMachine(typeof(MBDDBMLPFGA))]
	private IEnumerator<MEOADLJIECK> GFBIPBECEDG(float JDMBDIMAGHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x587CC60", Offset = "0x587C060", VA = "0x18587CC60")]
	[CompilerGenerated]
	private void MIBEJAHHPGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CDPCAHHAGKC : GFDCPLJLPNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float BFNLGGDCMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly int KCBGDMLLCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float IDLFMJMEMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly float[] FCDNNCEMMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private int HPHMFBIPIAE;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5876470", Offset = "0x5875870", VA = "0x185876470")]
	public CDPCAHHAGKC(Behaviour PKDAKJPDDGD, float OODNIADNGEH, int KCBGDMLLCBF, [Optional] Action DCLLICGCKKL, float IDLFMJMEMKG = 0f, [Optional] ABIJEIDBFLE ALGKCFEJIHD, [Optional] DBHPJOBGDCD JGJBGLEMPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "9")]
	protected override bool GOGFGDIMHFG(Action DAAMKALKLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5876240", Offset = "0x5875640", VA = "0x185876240", Slot = "10")]
	protected override bool HCGJACEOKKB(Action DAAMKALKLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x58761B0", Offset = "0x58755B0", VA = "0x1858761B0")]
	private void EKCBHGNOFCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class LHAKMONOEJJ : GFDCPLJLPNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float KFLEPGFKDCH;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5887540", Offset = "0x5886940", VA = "0x185887540")]
	public LHAKMONOEJJ(Behaviour PKDAKJPDDGD, float KFLEPGFKDCH, [Optional] Action DCLLICGCKKL, [Optional] ABIJEIDBFLE ALGKCFEJIHD, [Optional] DBHPJOBGDCD JGJBGLEMPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "9")]
	protected override bool GOGFGDIMHFG(Action DAAMKALKLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5887500", Offset = "0x5886900", VA = "0x185887500", Slot = "10")]
	protected override bool HCGJACEOKKB(Action DAAMKALKLMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public sealed class ILHFFMODJAK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class IPIBOMGLLOG : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public IPIBOMGLLOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x587EDD0", Offset = "0x587E1D0", VA = "0x18587EDD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x587EE70", Offset = "0x587E270", VA = "0x18587EE70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private GNGMNANCADP HCOCLDAEPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private MFABPFMFOOL PKDAKJPDDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Action<float> MNLFHECKDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private float IIDLJEBGBDM;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x587EBF0", Offset = "0x587DFF0", VA = "0x18587EBF0")]
	public ILHFFMODJAK(MFABPFMFOOL PKDAKJPDDGD, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x587E660", Offset = "0x587DA60", VA = "0x18587E660")]
	private void CBIBMGBBAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x587EA90", Offset = "0x587DE90", VA = "0x18587EA90")]
	private void PIMDONHFHIO(string NOGDNAGMMCO, Action ALIMKEFEGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x587E870", Offset = "0x587DC70", VA = "0x18587E870")]
	[IteratorStateMachine(typeof(IPIBOMGLLOG))]
	private IEnumerator<MEOADLJIECK> KDGBKGJFNMA(Action ALIMKEFEGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x587E810", Offset = "0x587DC10", VA = "0x18587E810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x587E8E0", Offset = "0x587DCE0", VA = "0x18587E8E0")]
	[CompilerGenerated]
	private void OMGFLAIPLHH(string CCICIDAGDNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class LFGIECBFELB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class FCGHKCCNBNF : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public FCGHKCCNBNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x587BBF0", Offset = "0x587AFF0", VA = "0x18587BBF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x587BC90", Offset = "0x587B090", VA = "0x18587BC90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private GNGMNANCADP HCOCLDAEPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private MonoBehaviour GEEDNCPBAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Action KPOMAEBEHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Action<float> MNLFHECKDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private float IIDLJEBGBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool LPBEOOKCPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly ABIJEIDBFLE ALGKCFEJIHD;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5886C00", Offset = "0x5886000", VA = "0x185886C00")]
	public LFGIECBFELB(MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5886E00", Offset = "0x5886200", VA = "0x185886E00")]
	public LFGIECBFELB(MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5887040", Offset = "0x5886440", VA = "0x185887040")]
	public LFGIECBFELB(MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3F0EE20", Offset = "0x3F0E220", VA = "0x183F0EE20")]
	private LFGIECBFELB(ABIJEIDBFLE ALGKCFEJIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5885E80", Offset = "0x5885280", VA = "0x185885E80")]
	internal static LFGIECBFELB BAPGBKPPHPG(MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5886620", Offset = "0x5885A20", VA = "0x185886620")]
	private void IMAHKDEDKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5886820", Offset = "0x5885C20", VA = "0x185886820")]
	private void KCIJCOHAGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5886120", Offset = "0x5885520", VA = "0x185886120")]
	private void CBIBMGBBAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5886330", Offset = "0x5885730", VA = "0x185886330")]
	private void ECMIMKMDJGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5886AD0", Offset = "0x5885ED0", VA = "0x185886AD0")]
	private void PIMDONHFHIO(string NOGDNAGMMCO, Action ALIMKEFEGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x58869D0", Offset = "0x5885DD0", VA = "0x1858869D0")]
	[IteratorStateMachine(typeof(FCGHKCCNBNF))]
	private IEnumerator<MEOADLJIECK> KDGBKGJFNMA(Action ALIMKEFEGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x58862D0", Offset = "0x58856D0", VA = "0x1858862D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5886A40", Offset = "0x5885E40", VA = "0x185886A40")]
	[CompilerGenerated]
	private void NHNPILPGMGG(string CCICIDAGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5886590", Offset = "0x5885990", VA = "0x185886590")]
	[CompilerGenerated]
	private void HNFPLHGMJFC(string CCICIDAGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5886500", Offset = "0x5885900", VA = "0x185886500")]
	[CompilerGenerated]
	private void EHCLGLMONOH(string CCICIDAGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5886790", Offset = "0x5885B90", VA = "0x185886790")]
	[CompilerGenerated]
	private void INHBHGNCODK(string CCICIDAGDNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Flags]
internal enum MPPOCDJEFNF : byte
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
internal sealed class ABBJEDKACOI : DBHPJOBGDCD
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public float KCFJKPKMGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5872BE0", Offset = "0x5871FE0", VA = "0x185872BE0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public float ONLLPCFDIHI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5872B40", Offset = "0x5871F40", VA = "0x185872B40", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public double OOHNDBILHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5872B50", Offset = "0x5871F50", VA = "0x185872B50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5872B70", Offset = "0x5871F70", VA = "0x185872B70")]
	[JDDIJBKLPJE(GHILFLKBMBN.None)]
	private static void JCIGPGHKKDF(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	[Preserve]
	internal ABBJEDKACOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal interface PCNMAAACDHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFOJNDFJOMK(string AMNLGEBHFHK);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJIMPAHFKLD();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface IMKJAFDIHLC
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string HOIPOKICKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool ADOEMHIFDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool EKBEMIJIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class HNJGKNDICLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public JMBCPOOFJNA EFFFFHEEIDA;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int CMHFEELAEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x72B020", Offset = "0x72A420", VA = "0x18072B020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7358F0", Offset = "0x734CF0", VA = "0x1807358F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x587E340", Offset = "0x587D740", VA = "0x18587E340")]
	public static MEOADLJIECK MHNFLJCFEFI(IEnumerator<MEOADLJIECK> FIMKDMIIEGJ, LEHHMJHIFKG EKHBCMEIBCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x587E4F0", Offset = "0x587D8F0", VA = "0x18587E4F0")]
	public MEOADLJIECK MHNFLJCFEFI(LEHHMJHIFKG[] GPJJKAFDPOP, IEnumerator<MEOADLJIECK>[] DMGGHGLAPHC, MEOADLJIECK[] BHDOBMCDEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x587E1D0", Offset = "0x587D5D0", VA = "0x18587E1D0")]
	public void GGMHIANBBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x587E200", Offset = "0x587D600", VA = "0x18587E200")]
	public void MDNFGOHFKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x587E090", Offset = "0x587D490", VA = "0x18587E090")]
	public void AGNLADGIKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x587E1D0", Offset = "0x587D5D0", VA = "0x18587E1D0")]
	public void GJMJKHONEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public HNJGKNDICLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class JMBCPOOFJNA
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct IENJEAKOOPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public HNJGKNDICLP GPKCKIDHJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public MFABPFMFOOL FDIDBDKBNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public LEHHMJHIFKG AAKPPKIFLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public IEnumerator<MEOADLJIECK> LHFJOKLOLHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public MEOADLJIECK BDJOJFBNGPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public MPPOCDJEFNF NHCMCNLNKJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct MJPLJFDFING
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public GLMLDOMIGMH.NMMGBICHGHP GCACLLDBNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public List<IENJEAKOOPE> CLKALJBPPHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class PHFJDLFPBJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public LEHHMJHIFKG promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public JMBCPOOFJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public MFABPFMFOOL context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public HNJGKNDICLP routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public MPPOCDJEFNF coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public MEOADLJIECK currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public IEnumerator<MEOADLJIECK> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PHFJDLFPBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x588A070", Offset = "0x5889470", VA = "0x18588A070")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class JBDNKBNFBEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public HNJGKNDICLP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public JMBCPOOFJNA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public JBDNKBNFBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x587EEB0", Offset = "0x587E2B0", VA = "0x18587EEB0")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class GPCLIHLHKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public HNJGKNDICLP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public JMBCPOOFJNA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GPCLIHLHKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x587D940", Offset = "0x587CD40", VA = "0x18587D940")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class BFOEPPEHBJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HNJGKNDICLP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public JMBCPOOFJNA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public BFOEPPEHBJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x5874EF0", Offset = "0x58742F0", VA = "0x185874EF0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private const MPPOCDJEFNF EMGAJJIAMCI = MPPOCDJEFNF.Cancelled | MPPOCDJEFNF.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private bool[] ENNCBGAIDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<MPPOCDJEFNF> GOLLBPGFMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeArray<float> AAOOGBJBKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeArray<int> KBBBPNCCAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private NativeArray<int> KCAGBGNNKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private NativeArray<int> LDMLENLBPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private NativeArray<int> ENKONDDNJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private NativeArray<int> LPJGMPMMDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private HNJGKNDICLP[] EBNJJFCGMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private LEHHMJHIFKG[] GPJJKAFDPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private MFABPFMFOOL[] IDFDCJELIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private IEnumerator<MEOADLJIECK>[] MENDAMLDGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private MEOADLJIECK[] MBHMIEMPOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int IEFIAEFHBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int IPADGNLNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly int BDGJGFLHFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private float BDIMLDPHEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private OPIGJNBABPG GNOHABNDEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private JobHandle FMPBBAIJGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private List<HNJGKNDICLP> IDLJFCCLFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool CEMPLNENMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private List<Action> AOHDEOMFPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private List<Action> PNIHJLBNLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool CPLOLCGMLGP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MJPLJFDFING[] ILPAOAAPPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xE16840", Offset = "0xE15C40", VA = "0x180E16840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5880DA0", Offset = "0x58801A0", VA = "0x185880DA0")]
	private static int NLFDPOACHIJ(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5881270", Offset = "0x5880670", VA = "0x185881270")]
	public JMBCPOOFJNA(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5880DD0", Offset = "0x58801D0", VA = "0x185880DD0")]
	private void OPJFILHAJNP(ref int EDBLIJGFKHM, int KIFKNMFJJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x587F520", Offset = "0x587E920", VA = "0x18587F520")]
	public void CONEEMMJOIG(MFABPFMFOOL PKDAKJPDDGD, MEOADLJIECK CBIKKBFKCOE, IEnumerator<MEOADLJIECK> FIMKDMIIEGJ, LEHHMJHIFKG EKHBCMEIBCI, [Optional] HNJGKNDICLP DFAIGLLCAHG, MPPOCDJEFNF PJOANNGLEFL = MPPOCDJEFNF.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x587F330", Offset = "0x587E730", VA = "0x18587F330")]
	public void CHOPNOPODPD(IEnumerable<IENJEAKOOPE> EPLKCKDIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5880810", Offset = "0x587FC10", VA = "0x185880810")]
	private IENJEAKOOPE KCEFPJFPIBL(int CCLADLMOKAJ)
	{
		return default(IENJEAKOOPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5880090", Offset = "0x587F490", VA = "0x185880090")]
	private void FJKHCIOMKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x210F360", Offset = "0x210E760", VA = "0x18210F360")]
	private static void FBIFHCFOPJG<T>(int CCLADLMOKAJ, T[] JEMKOPFCBCN, int GBNBGNMHGLO, [Optional] T KGOLEALODOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x210F340", Offset = "0x210E740", VA = "0x18210F340")]
	private static void FBIFHCFOPJG<T>(int CCLADLMOKAJ, NativeArray<T> JEMKOPFCBCN, int GBNBGNMHGLO, [Optional] T KGOLEALODOB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5880FC0", Offset = "0x58803C0", VA = "0x185880FC0")]
	private void PCOEJFADDBK(IEnumerable<IENJEAKOOPE> EPLKCKDIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5880740", Offset = "0x587FB40", VA = "0x185880740")]
	private void HACFKDKDOOF(IENJEAKOOPE ODMDCCBJPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x587F6A0", Offset = "0x587EAA0", VA = "0x18587F6A0")]
	private AFONPMGCJBM DFJNLNCGBBF(int DENALOGECKH)
	{
		return default(AFONPMGCJBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5880560", Offset = "0x587F960", VA = "0x185880560")]
	public void GMFJPJLFNAK(float KEACOEKDBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x587F2B0", Offset = "0x587E6B0", VA = "0x18587F2B0")]
	private void CCKKHEBEEIN(Action HFOFADIOHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5880D20", Offset = "0x5880120", VA = "0x185880D20")]
	private void NEHECOBJDKL(Action HFOFADIOHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x587F960", Offset = "0x587ED60", VA = "0x18587F960")]
	public void EPCHJMCPLMJ(float KEACOEKDBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x587EF50", Offset = "0x587E350", VA = "0x18587EF50")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5880430", Offset = "0x587F830", VA = "0x185880430")]
	public void GJMJKHONEFD(HNJGKNDICLP LJOLPEJEKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x587F180", Offset = "0x587E580", VA = "0x18587F180")]
	public void CBABINIJGKF(HNJGKNDICLP LJOLPEJEKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x587F050", Offset = "0x587E450", VA = "0x18587F050")]
	public void BODBAHBHNPF(HNJGKNDICLP LJOLPEJEKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class LHLGDPFGIHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly LHLGDPFGIHG IDMILJKGOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly Action DGALPKMLGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private bool AJCOIBJBODA;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
	public LHLGDPFGIHG(Action DGALPKMLGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5887640", Offset = "0x5886A40", VA = "0x185887640", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface FICMIPELEIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable JDHNOHBGCBF(UnityEngine.Object PKDAKJPDDGD, Action<T> LALKOPDMNLC);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface NPIPHHHJDNL<T> : global::FICMIPELEIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	new T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class KKFKKAFPOKK<T> : global::NPIPHHHJDNL<T>, global::FICMIPELEIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class OPNOCBDLMJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public global::KKFKKAFPOKK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public global::KHDOJBFMABD<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public OPNOCBDLMJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3B53500", Offset = "0x3B52900", VA = "0x183B53500")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static GameObject IGIAIHIAEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly List<global::KHDOJBFMABD<UnityEngine.Object, Action<T>>> BAHBBDEBBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private T EJHMLBGNOHI;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x72F260", Offset = "0x72E660", VA = "0x18072F260", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3397F30", Offset = "0x3397330", VA = "0x183397F30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3397BC0", Offset = "0x3396FC0", VA = "0x183397BC0")]
	private static bool AHIHBCIGHPH(T HFOFADIOHHP, T GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x33986D0", Offset = "0x3397AD0", VA = "0x1833986D0")]
	public KKFKKAFPOKK(T LMOELINAFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3397C50", Offset = "0x3397050", VA = "0x183397C50", Slot = "6")]
	public IDisposable JDHNOHBGCBF(UnityEngine.Object PKDAKJPDDGD, Action<T> LALKOPDMNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3398010", Offset = "0x3397410", VA = "0x183398010")]
	private void PJENENJFBPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class KLNBJNPPHKE : EOFMOAKCMLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly ABIJEIDBFLE ALGKCFEJIHD;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5883690", Offset = "0x5882A90", VA = "0x185883690")]
	[JDDIJBKLPJE(GHILFLKBMBN.None)]
	private static void JCIGPGHKKDF(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
	[Preserve]
	internal KLNBJNPPHKE([LIKONNNLKGK(null)] ABIJEIDBFLE ALGKCFEJIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x58835F0", Offset = "0x58829F0", VA = "0x1858835F0", Slot = "4")]
	public IDisposable GIAFBKJHPCK(float GBKEOCDGBDD, Action<float> MIKGEIBIMCG, bool LPBEOOKCPMN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[BurstCompile]
internal struct OPIGJNBABPG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	public float EIGDBDNLKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	public int IMNJEJAFOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private NativeArray<int> KPMIGPNKIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private NativeArray<int> OGDCKDMLPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private NativeArray<int> KAPBBOOBMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[ReadOnly]
	public NativeArray<MPPOCDJEFNF> EIMAGJMFIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	public NativeArray<float> INNKFDJLEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[WriteOnly]
	public NativeArray<int> LDMLENLBPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[WriteOnly]
	public NativeArray<int> KBBBPNCCAMN;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5889BD0", Offset = "0x5888FD0", VA = "0x185889BD0")]
	public static OPIGJNBABPG IDIKGABNBEI(int PGGBCPANCPE, float KEACOEKDBMO, NativeArray<MPPOCDJEFNF> GLHBMOEBJHE, NativeArray<float> ECBJDGDKNOE, NativeArray<int> GJAJGIDOMIA, NativeArray<int> NPLLFCHKICN, NativeArray<int> GDJHMCFPKEI, NativeArray<int> OGDCKDMLPAC, NativeArray<int> KAPBBOOBMPG)
	{
		return default(OPIGJNBABPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5889AF0", Offset = "0x5888EF0", VA = "0x185889AF0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5889D30", Offset = "0x5889130", VA = "0x185889D30")]
	private bool PIJNFGDLFJO(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5889C30", Offset = "0x5889030", VA = "0x185889C30")]
	private void KOOGGAIBGHL(NativeArray<int> PODMIAGABCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5889A90", Offset = "0x5888E90", VA = "0x185889A90")]
	private int EPBKBKLCJDL(int FCPAMLNPMML, int KMDPNEFDEMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5889C60", Offset = "0x5889060", VA = "0x185889C60")]
	private void NPBAKECKDLM(NativeArray<int> PODMIAGABCD, int GMEAMCBCPJO, int NFAMBOPBCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5889860", Offset = "0x5888C60", VA = "0x185889860")]
	private void DJEPJDJLGEO(NativeArray<int> PODMIAGABCD, int OKDDOFKNICG, int EAIECFKKDBK, int JODEMGNGNMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class BGOKCNKGIMF : JNGCDGNBPFH, ABIJEIDBFLE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private JMBCPOOFJNA[] MHLHIMIJCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private PCNMAAACDHJ OLELHAIJMJK;

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5875860", Offset = "0x5874C60", VA = "0x185875860")]
	[JDDIJBKLPJE(GHILFLKBMBN.None)]
	private static void JCIGPGHKKDF(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5875980", Offset = "0x5874D80", VA = "0x185875980")]
	[Preserve]
	public BGOKCNKGIMF([LIKONNNLKGK(null)] OHOEHKDLBJA EANHCIMIPKM, [LIKONNNLKGK(null)] DBHPJOBGDCD JGJBGLEMPFO, [LIKONNNLKGK(null)] LINIFLKHMOG LDCGFBEHFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x58750D0", Offset = "0x58744D0", VA = "0x1858750D0", Slot = "12")]
	public override GNGMNANCADP DPLPJDEFCHN(MFABPFMFOOL PKDAKJPDDGD, IEnumerator<MEOADLJIECK> FDJLJICJMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5875580", Offset = "0x5874980", VA = "0x185875580", Slot = "13")]
	public override void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x58752C0", Offset = "0x58746C0", VA = "0x1858752C0", Slot = "15")]
	public override void FHAKFCMFHLD(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x58754A0", Offset = "0x58748A0", VA = "0x1858754A0", Slot = "14")]
	protected override void HGAJENLLFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5875280", Offset = "0x5874680", VA = "0x185875280")]
	private JMBCPOOFJNA EAGOPABBFBI(GLMLDOMIGMH.NMMGBICHGHP OGILDIMGIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x58758D0", Offset = "0x5874CD0", VA = "0x1858758D0", Slot = "16")]
	internal override KHMJIPMGIGA MCMDFMNHGBO(IEnumerator<MEOADLJIECK> FDJLJICJMNI, Behaviour PKDAKJPDDGD, LEHHMJHIFKG EKHBCMEIBCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5874F30", Offset = "0x5874330", VA = "0x185874F30", Slot = "17")]
	internal override ACFMMCDBEDA DADLLGHBKAC(GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5874FA0", Offset = "0x58743A0", VA = "0x185874FA0")]
	private void DGPKHNPJFNK(JMBCPOOFJNA EAAPDJPJFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5875210", Offset = "0x5874610", VA = "0x185875210", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class JNGCDGNBPFH : ABIJEIDBFLE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly OHOEHKDLBJA EANHCIMIPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	protected readonly DBHPJOBGDCD JGJBGLEMPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly LINIFLKHMOG LDCGFBEHFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private ACFMMCDBEDA[] JGMGHKIGDEG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static ABIJEIDBFLE AGBLMGNNIDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5881A40", Offset = "0x5880E40", VA = "0x185881A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static bool CDOMMGFPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public GLMLDOMIGMH.NMMGBICHGHP BJGCDFPHEFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x72B020", Offset = "0x72A420", VA = "0x18072B020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GLMLDOMIGMH.NMMGBICHGHP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7358F0", Offset = "0x734CF0", VA = "0x1807358F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DBHPJOBGDCD CGIFABIIKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5881E10", Offset = "0x5881210", VA = "0x185881E10")]
	public static GNGMNANCADP EGGBEKEKBDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5882670", Offset = "0x5881A70", VA = "0x185882670")]
	[Preserve]
	protected JNGCDGNBPFH([LIKONNNLKGK(null)] OHOEHKDLBJA EANHCIMIPKM, [LIKONNNLKGK(null)] DBHPJOBGDCD JGJBGLEMPFO, [LIKONNNLKGK(null)] LINIFLKHMOG LDCGFBEHFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5882370", Offset = "0x5881770", VA = "0x185882370", Slot = "6")]
	public GNGMNANCADP KJENKEOBMBM(IEnumerator<MEOADLJIECK> FDJLJICJMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5882380", Offset = "0x5881780", VA = "0x185882380", Slot = "7")]
	public GNGMNANCADP KJENKEOBMBM(Behaviour PKDAKJPDDGD, IEnumerator<MEOADLJIECK> FDJLJICJMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract GNGMNANCADP DPLPJDEFCHN(MFABPFMFOOL PKDAKJPDDGD, IEnumerator<MEOADLJIECK> FDJLJICJMNI);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5882130", Offset = "0x5881530", VA = "0x185882130", Slot = "13")]
	public virtual void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5882310", Offset = "0x5881710", VA = "0x185882310", Slot = "9")]
	public void KAOBHLIBGDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5882110", Offset = "0x5881510", VA = "0x185882110", Slot = "14")]
	protected virtual void HGAJENLLFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x58825D0", Offset = "0x58819D0", VA = "0x1858825D0")]
	private void LMMGKJCLHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5881EB0", Offset = "0x58812B0", VA = "0x185881EB0")]
	private void FDNBFEIPIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5882610", Offset = "0x5881A10", VA = "0x185882610")]
	private void MCKPAKFDOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5882650", Offset = "0x5881A50", VA = "0x185882650")]
	private void OOGMPBGFDHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5882630", Offset = "0x5881A30", VA = "0x185882630")]
	private void OAPIKDKBAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x58825F0", Offset = "0x58819F0", VA = "0x1858825F0")]
	private void LOHHIIMJGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x58825B0", Offset = "0x58819B0", VA = "0x1858825B0")]
	private void LHGMILCJEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5881ED0", Offset = "0x58812D0", VA = "0x185881ED0", Slot = "15")]
	public virtual void FHAKFCMFHLD(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5881870", Offset = "0x5880C70", VA = "0x185881870")]
	private void ACHCPMGNLKJ(ACFMMCDBEDA EAAPDJPJFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0xACE470", Offset = "0xACD870", VA = "0x180ACE470")]
	private ACFMMCDBEDA DCNIDGNJLBM(GLMLDOMIGMH.NMMGBICHGHP OGILDIMGIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract KHMJIPMGIGA MCMDFMNHGBO(IEnumerator<MEOADLJIECK> FDJLJICJMNI, Behaviour GEEDNCPBAAN, LEHHMJHIFKG GEIKLDGIHAP);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract ACFMMCDBEDA DADLLGHBKAC(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5881A90", Offset = "0x5880E90", VA = "0x185881A90", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class KHMJIPMGIGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly LEHHMJHIFKG EKHBCMEIBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly IMKJAFDIHLC PKDAKJPDDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool HCJCBHIFPIP;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IEnumerator<MEOADLJIECK> LHFJOKLOLHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x734AE0", Offset = "0x733EE0", VA = "0x180734AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public MEOADLJIECK BDJOJFBNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x734AF0", Offset = "0x733EF0", VA = "0x180734AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MCJHGGJCBJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5882EE0", Offset = "0x58822E0", VA = "0x185882EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DGFKNBLGLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9A6940", Offset = "0x9A5D40", VA = "0x1809A6940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x26485C0", Offset = "0x26479C0", VA = "0x1826485C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string HOIPOKICKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x735A10", Offset = "0x734E10", VA = "0x180735A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x735A20", Offset = "0x734E20", VA = "0x180735A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public float POOLMLEGCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xF09170", Offset = "0xF08570", VA = "0x180F09170")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xCBBE30", Offset = "0xCBB230", VA = "0x180CBBE30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5883350", Offset = "0x5882750", VA = "0x185883350")]
	public KHMJIPMGIGA(IEnumerator<MEOADLJIECK> FIMKDMIIEGJ, IMKJAFDIHLC PKDAKJPDDGD, LEHHMJHIFKG EKHBCMEIBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5882F60", Offset = "0x5882360", VA = "0x185882F60")]
	public MEOADLJIECK MHNFLJCFEFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5883220", Offset = "0x5882620", VA = "0x185883220")]
	public bool OJCABMAMFDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5882E60", Offset = "0x5882260", VA = "0x185882E60")]
	public void GJMJKHONEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5883290", Offset = "0x5882690", VA = "0x185883290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x164B6B0", Offset = "0x164AAB0", VA = "0x18164B6B0")]
	[CompilerGenerated]
	private void IEEPIKIDHIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class LEHHMJHIFKG : EIHEIMLHIPL, GNGMNANCADP, PLALJAJNMKE, JKAHJLGEFLE, IEnumerator, MEOADLJIECK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private GLMLDOMIGMH.NMMGBICHGHP ENNLNDGOJPJ;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private GLMLDOMIGMH.NMMGBICHGHP BJDHBLFMJJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x808970", Offset = "0x807D70", VA = "0x180808970", Slot = "23")]
		get
		{
			return default(GLMLDOMIGMH.NMMGBICHGHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GLMLDOMIGMH.NMMGBICHGHP EFFFFHEEIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xBB01A0", Offset = "0xBAF5A0", VA = "0x180BB01A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float PDNPPGNGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1133200", Offset = "0x1132600", VA = "0x181133200", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool NNJPKLCGOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5885E00", Offset = "0x5885200", VA = "0x185885E00", Slot = "24")]
	private bool LPIGJHMDKAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5885DF0", Offset = "0x58851F0", VA = "0x185885DF0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5885E20", Offset = "0x5885220", VA = "0x185885E20")]
	public LEHHMJHIFKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal enum AFONPMGCJBM : byte
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
internal sealed class ACFMMCDBEDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum INANCDAPDFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public struct MEDDILFMEHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public GLMLDOMIGMH.NMMGBICHGHP GCACLLDBNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public INANCDAPDFI JJGMMPNNCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public List<KHMJIPMGIGA> EEFAEDBMCPN;
	}

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static readonly INANCDAPDFI[] DIEPENCABID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool NGPMIGICBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly KHMJIPMGIGA[] JEAMECAMLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly List<KHMJIPMGIGA> NIGHDGJKOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly Stack<int> IDMCEJPKJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly List<KHMJIPMGIGA> EAMFKCNCFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Stack<int> EJAGEPBIGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly PCNMAAACDHJ FIAPOBKKKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private bool CPLOLCGMLGP;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public MEDDILFMEHA[,] DNKGIGHBEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x72B0F0", Offset = "0x72A4F0", VA = "0x18072B0F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x58740B0", Offset = "0x58734B0", VA = "0x1858740B0")]
	public ACFMMCDBEDA(GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, PCNMAAACDHJ FIAPOBKKKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5873E80", Offset = "0x5873280", VA = "0x185873E80")]
	public void NJPILMDMCLK(KHMJIPMGIGA FIMKDMIIEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5873700", Offset = "0x5872B00", VA = "0x185873700")]
	public void IDLHFEPIOPG(IList<KHMJIPMGIGA> DMGGHGLAPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5873050", Offset = "0x5872450", VA = "0x185873050")]
	public void FDAODGENLMG(IList<KHMJIPMGIGA> DMGGHGLAPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x58739D0", Offset = "0x5872DD0", VA = "0x1858739D0")]
	private void JAGFGPOFGDD(KHMJIPMGIGA FIMKDMIIEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5873440", Offset = "0x5872840", VA = "0x185873440")]
	private void GBHDNKJKCLI(IList<KHMJIPMGIGA> DMGGHGLAPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5873CE0", Offset = "0x58730E0", VA = "0x185873CE0")]
	private AFONPMGCJBM NIIPBFJAPAE(KHMJIPMGIGA FIMKDMIIEGJ)
	{
		return default(AFONPMGCJBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x58735C0", Offset = "0x58729C0", VA = "0x1858735C0")]
	public void HGAJENLLFEE(float KEACOEKDBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5873AD0", Offset = "0x5872ED0", VA = "0x185873AD0")]
	public void KAOBHLIBGDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5872D30", Offset = "0x5872130", VA = "0x185872D30")]
	private void EAAAGFAJEPN(List<KHMJIPMGIGA> DMGGHGLAPHC, Stack<int> KJEOBHANEIJ, bool EOMLHGLDDIM, float GLOPLLAAJOM = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5872BF0", Offset = "0x5871FF0", VA = "0x185872BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5873320", Offset = "0x5872720", VA = "0x185873320")]
	private void FDOGMNBIEPE(List<KHMJIPMGIGA> DMGGHGLAPHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal class LLBJIDDLEIG : PCNMAAACDHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "4")]
	public void IFOJNDFJOMK(string AMNLGEBHFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
	public void NJIMPAHFKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public LLBJIDDLEIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal class MPCJFMJIMII : IMKJAFDIHLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Behaviour GEEDNCPBAAN;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public string HOIPOKICKKE
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5887E60", Offset = "0x5887260", VA = "0x185887E60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool ADOEMHIFDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5887DE0", Offset = "0x58871E0", VA = "0x185887DE0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool EKBEMIJIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5887E40", Offset = "0x5887240", VA = "0x185887E40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
	public MPCJFMJIMII(Behaviour GEEDNCPBAAN)
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

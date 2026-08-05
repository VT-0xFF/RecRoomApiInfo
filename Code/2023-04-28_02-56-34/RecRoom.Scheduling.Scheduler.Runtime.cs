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
	[Cpp2IlInjected.Address(RVA = "0x586BAE0", Offset = "0x586A4E0", VA = "0x18586BAE0")]
	public KKNDEEAADEN(ThreadPriority GCPNDINHBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x586BAD0", Offset = "0x586A4D0", VA = "0x18586BAD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5863220", Offset = "0x5861C20", VA = "0x185863220")]
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
				[Cpp2IlInjected.Address(RVA = "0x586E140", Offset = "0x586CB40", VA = "0x18586E140")]
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
				[Cpp2IlInjected.Address(RVA = "0x585EB50", Offset = "0x585D550", VA = "0x18585EB50")]
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
				[Cpp2IlInjected.Address(RVA = "0x586DEB0", Offset = "0x586C8B0", VA = "0x18586DEB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5871BB0", Offset = "0x58705B0", VA = "0x185871BB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x586FFA0", Offset = "0x586E9A0", VA = "0x18586FFA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x585CAB0", Offset = "0x585B4B0", VA = "0x18585CAB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x586DCD0", Offset = "0x586C6D0", VA = "0x18586DCD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x586AF50", Offset = "0x5869950", VA = "0x18586AF50")]
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
				[Cpp2IlInjected.Address(RVA = "0x585F1A0", Offset = "0x585DBA0", VA = "0x18585F1A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x585E500", Offset = "0x585CF00", VA = "0x18585E500")]
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
					[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
					public IGGPFCPLJOH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x5866B00", Offset = "0x5865500", VA = "0x185866B00")]
					internal void <CreateSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static global::PCAPMAFAHIC<ADGPHKJDIJE> FAGGFBDPKFG;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x585D270", Offset = "0x585BC70", VA = "0x18585D270")]
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
					[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
					public LFMEICIHFCL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x586F7C0", Offset = "0x586E1C0", VA = "0x18586F7C0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000035")]
				public static IDisposable EHPCJBKPFCO;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x5865EB0", Offset = "0x58648B0", VA = "0x185865EB0")]
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
					[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
					public CMJOOGPFHDC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x585F380", Offset = "0x585DD80", VA = "0x18585F380")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x586B130", Offset = "0x5869B30", VA = "0x18586B130")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public FJFGAELAHDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5864200", Offset = "0x5862C00", VA = "0x185864200")]
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
			[Cpp2IlInjected.Address(RVA = "0x5862620", Offset = "0x5861020", VA = "0x185862620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x58621F0", Offset = "0x5860BF0", VA = "0x1858621F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x585FB70", Offset = "0x585E570", VA = "0x18585FB70")]
		private static void EJCKFBLGCNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5862950", Offset = "0x5861350", VA = "0x185862950")]
		private static void NICHBDLDNJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x585F840", Offset = "0x585E240", VA = "0x18585F840")]
		private static void BPEPAKPFDFO(string DOACCAJGALA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x585F610", Offset = "0x585E010", VA = "0x18585F610")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5862660", Offset = "0x5861060", VA = "0x185862660")]
		private static void KHDOELGFPOB(CFLOLCEHAGK.AKGJFMHHNJE OGFDNCPKECB, ref PlayerLoopSystem EHMGMKKDIEF, Type ENIANPNCBDN, Type PECGCGIPCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5862230", Offset = "0x5860C30", VA = "0x185862230")]
		private static void GLKANCNKNEN(ref PlayerLoopSystem EHMGMKKDIEF, Type ENIANPNCBDN, Type PECGCGIPCLI, MHJBIDJCCNA LOHKAMFIJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5862820", Offset = "0x5861220", VA = "0x185862820")]
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
		[Cpp2IlInjected.Address(RVA = "0x5873070", Offset = "0x5871A70", VA = "0x185873070")]
		public PJIFMKNALMK(AKGJFMHHNJE FINHIPLPKNB, int CAOCOMEFLJF = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5873000", Offset = "0x5871A00", VA = "0x185873000")]
		public void MEDONDFDBBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5872DA0", Offset = "0x58717A0", VA = "0x185872DA0")]
		public void FBILGAAKNJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5872E00", Offset = "0x5871800", VA = "0x185872E00")]
		public void HOPBCJAIDPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static AKGJFMHHNJE[] IPHKHEEIKPC;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static PJIFMKNALMK[] PPGLGDGEPEJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x585ED30", Offset = "0x585D730", VA = "0x18585ED30")]
	public static PJIFMKNALMK AJPNILGLKII(AKGJFMHHNJE OGFDNCPKECB, int CAOCOMEFLJF = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x585EFB0", Offset = "0x585D9B0", VA = "0x18585EFB0")]
	public static PJIFMKNALMK KHOPHLFOOAI(AKGJFMHHNJE OGFDNCPKECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x585EF00", Offset = "0x585D900", VA = "0x18585EF00")]
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
		[Cpp2IlInjected.Address(RVA = "0x585CC90", Offset = "0x585B690", VA = "0x18585CC90", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double ODLPMBNOKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x22BD150", Offset = "0x22BBB50", VA = "0x1822BD150", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double DCKEFAHDOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x36853A0", Offset = "0x3683DA0", VA = "0x1836853A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x585CE90", Offset = "0x585B890", VA = "0x18585CE90")]
	public AGLDDIPHHDH(int FLDPANKCPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x585CD60", Offset = "0x585B760", VA = "0x18585CD60", Slot = "7")]
	public void LIPGHGOJIGK(double IHADMCKJLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x585CCF0", Offset = "0x585B6F0", VA = "0x18585CCF0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double ODLPMBNOKOC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3A3EF20", Offset = "0x3A3D920", VA = "0x183A3EF20", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double DCKEFAHDOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA54260", Offset = "0xA52C60", VA = "0x180A54260", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double NGIHKBPLHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3685390", Offset = "0x3683D90", VA = "0x183685390")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JNMMJBEPGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3A3EE50", Offset = "0x3A3D850", VA = "0x183A3EE50", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x586FE70", Offset = "0x586E870", VA = "0x18586FE70", Slot = "7")]
	public virtual void LIPGHGOJIGK(double IHADMCKJLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x586FE30", Offset = "0x586E830", VA = "0x18586FE30", Slot = "8")]
	public virtual void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5863920", Offset = "0x5862320", VA = "0x185863920")]
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
		[Cpp2IlInjected.Address(RVA = "0x5863910", Offset = "0x5862310", VA = "0x185863910")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x58637C0", Offset = "0x58621C0", VA = "0x1858637C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x58637D0", Offset = "0x58621D0", VA = "0x1858637D0", Slot = "7")]
	public override void LIPGHGOJIGK(double IHADMCKJLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5863780", Offset = "0x5862180", VA = "0x185863780", Slot = "8")]
	public override void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5863920", Offset = "0x5862320", VA = "0x185863920")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C3AD40", Offset = "0x2C39740", VA = "0x182C3AD40")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NPGAFGJFFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2C3ACF0", Offset = "0x2C396F0", VA = "0x182C3ACF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2642100", Offset = "0x2640B00", VA = "0x182642100")]
		protected PGKLBOFEBPO(TPromise NIMKDFKLNDK, TMainThreadPromise EGFJPGIGHPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2C3ADA0", Offset = "0x2C397A0", VA = "0x182C3ADA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2EF0AD0", Offset = "0x2EEF4D0", VA = "0x182EF0AD0")]
		public CFKMAKAJBNA(global::ODHJGGEEIEO<T> NIMKDFKLNDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2EF08C0", Offset = "0x2EEF2C0", VA = "0x182EF08C0", Slot = "6")]
		protected override void HCNFJLAKMOA(global::ODHJGGEEIEO<T> NIMKDFKLNDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2EF0890", Offset = "0x2EEF290", VA = "0x182EF0890")]
		[CompilerGenerated]
		private void FANOMDKAMAK(T JGINNNKFHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x225A410", Offset = "0x2258E10", VA = "0x18225A410")]
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
			[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
		public FNBCFJPBDOG(Action DAAMKALKLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xE5FD60", Offset = "0xE5E760", VA = "0x180E5FD60", Slot = "5")]
		public void JHOFICMAMCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<FHJPFKKFEPC> FCKBAJAPLDD;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x21D3010", Offset = "0x21D1A10", VA = "0x1821D3010")]
	public static global::ODHJGGEEIEO<T> FIDHHFBMPEN<T>(this global::ODHJGGEEIEO<T> NIMKDFKLNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5863E40", Offset = "0x5862840", VA = "0x185863E40")]
	public static void FIDHHFBMPEN(Action DAAMKALKLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x21D2F50", Offset = "0x21D1950", VA = "0x1821D2F50")]
	private static global::ODHJGGEEIEO<T> CKADFHBCEOO<T>(global::ODHJGGEEIEO<T> NIMKDFKLNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5863950", Offset = "0x5862350", VA = "0x185863950")]
	private static void APLPMHJOIGB(FHJPFKKFEPC LMJMPFKGFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5863B50", Offset = "0x5862550", VA = "0x185863B50")]
	private static void ELDOBJODGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5863FA0", Offset = "0x58629A0", VA = "0x185863FA0")]
	private static void JFPNKIHPIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5863ED0", Offset = "0x58628D0", VA = "0x185863ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x585E110", Offset = "0x585CB10", VA = "0x18585E110")]
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
		[Cpp2IlInjected.Address(RVA = "0x58657B0", Offset = "0x58641B0", VA = "0x1858657B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5865E20", Offset = "0x5864820", VA = "0x185865E20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x585CF70", Offset = "0x585B970", VA = "0x18585CF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x585E170", Offset = "0x585CB70", VA = "0x18585E170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public JIIBLEJNONE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5867420", Offset = "0x5865E20", VA = "0x185867420")]
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
		[Cpp2IlInjected.Address(RVA = "0x5870D50", Offset = "0x586F750", VA = "0x185870D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x58716D0", Offset = "0x58700D0", VA = "0x1858716D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x586D440", Offset = "0x586BE40", VA = "0x18586D440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x586DC80", Offset = "0x586C680", VA = "0x18586DC80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public KKIEENKEANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x586BAA0", Offset = "0x586A4A0", VA = "0x18586BAA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public GJKLNALLCIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x58656D0", Offset = "0x58640D0", VA = "0x1858656D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5865370", Offset = "0x5863D70", VA = "0x185865370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5865760", Offset = "0x5864160", VA = "0x185865760")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5865690", Offset = "0x5864090", VA = "0x185865690", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public OFLNAFGDKEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5871720", Offset = "0x5870120", VA = "0x185871720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5871B70", Offset = "0x5870570", VA = "0x185871B70", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x586C780", Offset = "0x586B180", VA = "0x18586C780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool EFPDCCLLNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x586C0F0", Offset = "0x586AAF0", VA = "0x18586C0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool EFIAEPFCKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x586C1A0", Offset = "0x586ABA0", VA = "0x18586C1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> COCELKPADJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x586C940", Offset = "0x586B340", VA = "0x18586C940")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x586C260", Offset = "0x586AC60", VA = "0x18586C260")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x586C550", Offset = "0x586AF50", VA = "0x18586C550")]
	[PAECCEJEKMD(KFMLDOLCGMJ.EnteredEditModeNextFrame, 0)]
	private static void FDEFJDBOIBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x586C3F0", Offset = "0x586ADF0", VA = "0x18586C3F0")]
	[AsyncStateMachine(typeof(GNHLLJENEMO))]
	public static Task<Scene> EKPEPFCICAM(string HJEGLBELAHC, LoadSceneMode AHPJCIAEOLA = LoadSceneMode.Single, bool LNHAKJNDEPA = false, [Optional] HKNIJBILNIP KOBNLIMODNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x586D1B0", Offset = "0x586BBB0", VA = "0x18586D1B0")]
	[AsyncStateMachine(typeof(APPHDEKJLEK))]
	private static Task PKLAJNIBGND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x586CD40", Offset = "0x586B740", VA = "0x18586CD40")]
	[AsyncStateMachine(typeof(BPHPMJFJAKL))]
	private static Task OCNOCEJJJEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x586C620", Offset = "0x586B020", VA = "0x18586C620")]
	[AsyncStateMachine(typeof(NLENNEHFFDM))]
	private static Task<Scene> JGAKHJPMHDE(string HJEGLBELAHC, LoadSceneMode AHPJCIAEOLA, bool LNHAKJNDEPA, HKNIJBILNIP BDBJGJIIKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x586BFB0", Offset = "0x586A9B0", VA = "0x18586BFB0")]
	[AsyncStateMachine(typeof(LBGLJBEHLMH))]
	private static Task<Scene> BDDOBENBKOO(HKNIJBILNIP BDBJGJIIKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x586CA40", Offset = "0x586B440", VA = "0x18586CA40")]
	public static global::ODHJGGEEIEO<Scene> NAIFNKKLBIH(string HJEGLBELAHC, LoadSceneMode AHPJCIAEOLA = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x586CED0", Offset = "0x586B8D0", VA = "0x18586CED0")]
	public static JKAHJLGEFLE OJCEBGMNDDC(string HJEGLBELAHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x586C360", Offset = "0x586AD60", VA = "0x18586C360")]
	[IteratorStateMachine(typeof(GJKLNALLCIK))]
	private static IEnumerator<MEOADLJIECK> DAFEBBFCJAK(string HJEGLBELAHC, IDFJJMAGGAN FCCIKGLCAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x586CE30", Offset = "0x586B830", VA = "0x18586CE30")]
	[IteratorStateMachine(typeof(OFLNAFGDKEO))]
	private static IEnumerator<MEOADLJIECK> OGHMMBFAJKB(string HJEGLBELAHC, LoadSceneMode AHPJCIAEOLA, global::GOEHKJJNHGC<Scene> FCCIKGLCAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x586CBE0", Offset = "0x586B5E0", VA = "0x18586CBE0")]
	public static bool OALJGCIAFFD(out string FBAGAPENNHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class EIPNMJIMBPA
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5863480", Offset = "0x5861E80", VA = "0x185863480")]
	public static IDisposable HOCBBOIPBOC(this MFABPFMFOOL PKDAKJPDDGD, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5863500", Offset = "0x5861F00", VA = "0x185863500")]
	public static IDisposable IJBDNLJPKAB(this MFABPFMFOOL PKDAKJPDDGD, Action<float> KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5863400", Offset = "0x5861E00", VA = "0x185863400")]
	public static IDisposable FCMPFHDDAME(this MFABPFMFOOL PKDAKJPDDGD, Action<float> KPOMAEBEHKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class PKFIGPIKAFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x58735C0", Offset = "0x5871FC0", VA = "0x1858735C0")]
	public static IDisposable IMAHKDEDKIM(this MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5873540", Offset = "0x5871F40", VA = "0x185873540")]
	public static IDisposable IMAHKDEDKIM(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x58733B0", Offset = "0x5871DB0", VA = "0x1858733B0")]
	public static IDisposable HGAJENLLFEE(this MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x58738B0", Offset = "0x58722B0", VA = "0x1858738B0")]
	public static IDisposable MCKPAKFDOPH(this MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5873A60", Offset = "0x5872460", VA = "0x185873A60")]
	public static IDisposable OOGMPBGFDHI(this MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x58734C0", Offset = "0x5871EC0", VA = "0x1858734C0")]
	public static IDisposable IBCINEDGOLC(this MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5873200", Offset = "0x5871C00", VA = "0x185873200")]
	public static IDisposable ENFGOLIEKAL(this MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x58739C0", Offset = "0x58723C0", VA = "0x1858739C0")]
	public static IDisposable ONBIKHJIOCG(this MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x58736D0", Offset = "0x58720D0", VA = "0x1858736D0")]
	public static IDisposable JDMFBFEPOPO(this MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5873280", Offset = "0x5871C80", VA = "0x185873280")]
	public static IDisposable GIAFBKJHPCK(this MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5873790", Offset = "0x5872190", VA = "0x185873790")]
	public static IDisposable KLJJLHEJOCA(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5873640", Offset = "0x5872040", VA = "0x185873640")]
	public static IDisposable IOJPAMIKFGK(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5873320", Offset = "0x5871D20", VA = "0x185873320")]
	public static IDisposable GMNOANOFBPM(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5873170", Offset = "0x5871B70", VA = "0x185873170")]
	public static IDisposable BPAGGPIJLIM(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5873820", Offset = "0x5872220", VA = "0x185873820")]
	public static IDisposable LAMFHDNEODJ(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5873700", Offset = "0x5872100", VA = "0x185873700")]
	public static IDisposable KCCJANAGDHE(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5873930", Offset = "0x5872330", VA = "0x185873930")]
	public static IDisposable OMNJJMPLBKK(this MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5873420", Offset = "0x5871E20", VA = "0x185873420")]
	public static IDisposable HGGPNNBPFOM(this MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5873AE0", Offset = "0x58724E0", VA = "0x185873AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public PEDEJKAGHEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x58724A0", Offset = "0x5870EA0", VA = "0x1858724A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5872560", Offset = "0x5870F60", VA = "0x185872560", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public KFLKEFDGJID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x586B260", Offset = "0x5869C60", VA = "0x18586B260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x586B350", Offset = "0x5869D50", VA = "0x18586B350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x586BD40", Offset = "0x586A740", VA = "0x18586BD40")]
	public static GNGMNANCADP IMAHKDEDKIM(Action KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x586BDF0", Offset = "0x586A7F0", VA = "0x18586BDF0")]
	public static GNGMNANCADP IMAHKDEDKIM(Behaviour PKDAKJPDDGD, Action KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x586BC30", Offset = "0x586A630", VA = "0x18586BC30")]
	public static GNGMNANCADP IMAHKDEDKIM(Behaviour PKDAKJPDDGD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x586BF30", Offset = "0x586A930", VA = "0x18586BF30")]
	[IteratorStateMachine(typeof(PEDEJKAGHEM))]
	private static IEnumerator<MEOADLJIECK> NMADIIFMKMG(GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action KPOMAEBEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x586BEB0", Offset = "0x586A8B0", VA = "0x18586BEB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public MMOOLGDCAOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5870230", Offset = "0x586EC30", VA = "0x185870230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x58702D0", Offset = "0x586ECD0", VA = "0x1858702D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5866410", Offset = "0x5864E10", VA = "0x185866410")]
	public static GNGMNANCADP IMAHKDEDKIM(float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5866300", Offset = "0x5864D00", VA = "0x185866300")]
	public static GNGMNANCADP IMAHKDEDKIM(MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5865FE0", Offset = "0x58649E0", VA = "0x185865FE0")]
	public static GNGMNANCADP CDFJHJKJINK(MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5866160", Offset = "0x5864B60", VA = "0x185866160")]
	public static GNGMNANCADP GKMBECKDMJE(MFABPFMFOOL PKDAKJPDDGD, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5866510", Offset = "0x5864F10", VA = "0x185866510")]
	private static IEnumerator<MEOADLJIECK> NMADIIFMKMG(DBHPJOBGDCD JGJBGLEMPFO, float GBKEOCDGBDD, GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5866100", Offset = "0x5864B00", VA = "0x185866100")]
	private static IEnumerator<MEOADLJIECK> FAEOMPJFKDP(DBHPJOBGDCD JGJBGLEMPFO, float GBKEOCDGBDD, GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action<float> KPOMAEBEHKO, bool LPBEOOKCPMN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5866270", Offset = "0x5864C70", VA = "0x185866270")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public ELPCBNPMENB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5863580", Offset = "0x5861F80", VA = "0x185863580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5863630", Offset = "0x5862030", VA = "0x185863630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x585DF80", Offset = "0x585C980", VA = "0x18585DF80")]
	[IteratorStateMachine(typeof(ELPCBNPMENB))]
	private static IEnumerator<MEOADLJIECK> BIHGGDMDIOA(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, Func<bool> LAGGEGOCCOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x585E000", Offset = "0x585CA00", VA = "0x18585E000")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public LAENJIMPMBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x586D340", Offset = "0x586BD40", VA = "0x18586D340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x586D400", Offset = "0x586BE00", VA = "0x18586D400", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public EOAECMNEJBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5863670", Offset = "0x5862070", VA = "0x185863670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5863740", Offset = "0x5862140", VA = "0x185863740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x58649D0", Offset = "0x58633D0", VA = "0x1858649D0")]
	[IteratorStateMachine(typeof(LAENJIMPMBF))]
	private static IEnumerator<MEOADLJIECK> LBCIFDIBHCO(float ONPCMEEMBBB, GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5864340", Offset = "0x5862D40", VA = "0x185864340")]
	[IteratorStateMachine(typeof(EOAECMNEJBM))]
	private static IEnumerator<MEOADLJIECK> CMDPEEFIFIA(float ONPCMEEMBBB, GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5864780", Offset = "0x5863180", VA = "0x185864780")]
	public static IDisposable GOMILCMCHHO(this MonoBehaviour GEEDNCPBAAN, float ONPCMEEMBBB, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5864C60", Offset = "0x5863660", VA = "0x185864C60")]
	public static GNGMNANCADP PJPDMCHNEHN(this MonoBehaviour GEEDNCPBAAN, float ONPCMEEMBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x58648A0", Offset = "0x58632A0", VA = "0x1858648A0")]
	public static GNGMNANCADP GOMILCMCHHO(this MonoBehaviour GEEDNCPBAAN, float ONPCMEEMBBB, GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5864320", Offset = "0x5862D20", VA = "0x185864320")]
	public static GNGMNANCADP BBAKCDOPDAJ(this MonoBehaviour GEEDNCPBAAN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5864B60", Offset = "0x5863560", VA = "0x185864B60")]
	public static GNGMNANCADP OOKBBBJAGNM(this MonoBehaviour GEEDNCPBAAN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x58643D0", Offset = "0x5862DD0", VA = "0x1858643D0")]
	public static GNGMNANCADP DFONFJPDFIC(this MonoBehaviour GEEDNCPBAAN, Action MPPDBHKFNNP, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5864A60", Offset = "0x5863460", VA = "0x185864A60")]
	public static GNGMNANCADP LCMHEILCJCP(this MonoBehaviour GEEDNCPBAAN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5864580", Offset = "0x5862F80", VA = "0x185864580")]
	public static GNGMNANCADP FEAPICJOCIA(this MonoBehaviour GEEDNCPBAAN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5864680", Offset = "0x5863080", VA = "0x185864680")]
	public static GNGMNANCADP GDNCGDFGMDL(this MonoBehaviour GEEDNCPBAAN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x58644B0", Offset = "0x5862EB0", VA = "0x1858644B0")]
	private static GNGMNANCADP DMHFNNNDEDJ(MonoBehaviour GEEDNCPBAAN, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, Action MPPDBHKFNNP, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5864B90", Offset = "0x5863590", VA = "0x185864B90")]
	public static GNGMNANCADP PCFKAHCFJDJ(this MonoBehaviour GEEDNCPBAAN, float HGKENILGLLN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5864A90", Offset = "0x5863490", VA = "0x185864A90")]
	public static GNGMNANCADP MCJLJCBPKNC(this MonoBehaviour GEEDNCPBAAN, float HGKENILGLLN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x58646B0", Offset = "0x58630B0", VA = "0x1858646B0")]
	public static GNGMNANCADP GNDPOPGKHNB(this MonoBehaviour GEEDNCPBAAN, float HGKENILGLLN, Action MPPDBHKFNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x58645B0", Offset = "0x5862FB0", VA = "0x1858645B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5870B70", Offset = "0x586F570", VA = "0x185870B70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NMOMHIOGMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5870AD0", Offset = "0x586F4D0", VA = "0x185870AD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5870420", Offset = "0x586EE20", VA = "0x185870420", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5870CB0", Offset = "0x586F6B0", VA = "0x185870CB0")]
	public NKFMIAEHLOL([Optional] Action DCLLICGCKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x58704C0", Offset = "0x586EEC0", VA = "0x1858704C0")]
	public void AGMLDLCGDGN(EKNEAHEJGOI JLOAMIDJLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5870960", Offset = "0x586F360", VA = "0x185870960")]
	private void IJIAAMFDDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5870950", Offset = "0x586F350", VA = "0x185870950", Slot = "7")]
	public bool ICDHPIEDOAL(bool HKPPDHFDHMN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5870670", Offset = "0x586F070", VA = "0x185870670", Slot = "8")]
	public bool ICDHPIEDOAL(Action DAAMKALKLMO, bool HKPPDHFDHMN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x58705F0", Offset = "0x586EFF0", VA = "0x1858705F0", Slot = "9")]
	public IEnumerator<EKNEAHEJGOI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x58705F0", Offset = "0x586EFF0", VA = "0x1858705F0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NLPNGIMBFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x585CF40", Offset = "0x585B940", VA = "0x18585CF40")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public AOLKFOHJFPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x585CF40", Offset = "0x585B940", VA = "0x18585CF40")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly float KFLEPGFKDCH;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x586FA70", Offset = "0x586E470", VA = "0x18586FA70")]
	public PCOFEDOPEAC(Behaviour PKDAKJPDDGD, float KFLEPGFKDCH, [Optional] Action DCLLICGCKKL, [Optional] ABIJEIDBFLE ALGKCFEJIHD, [Optional] DBHPJOBGDCD JGJBGLEMPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x58722A0", Offset = "0x5870CA0", VA = "0x1858722A0", Slot = "9")]
	protected override bool GOGFGDIMHFG(Action DAAMKALKLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x58723A0", Offset = "0x5870DA0", VA = "0x1858723A0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public MBDDBMLPFGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x586FC90", Offset = "0x586E690", VA = "0x18586FC90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x586FD60", Offset = "0x586E760", VA = "0x18586FD60", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x762140", Offset = "0x760B40", VA = "0x180762140", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NMOMHIOGMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x58651D0", Offset = "0x5863BD0", VA = "0x1858651D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5864D20", Offset = "0x5863720", VA = "0x185864D20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5865270", Offset = "0x5863C70", VA = "0x185865270")]
	protected GFDCPLJLPNI(Behaviour PKDAKJPDDGD, [Optional] Action DCLLICGCKKL, [Optional] ABIJEIDBFLE ALGKCFEJIHD, [Optional] DBHPJOBGDCD JGJBGLEMPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5864E60", Offset = "0x5863860", VA = "0x185864E60", Slot = "7")]
	public bool ICDHPIEDOAL(bool HKPPDHFDHMN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5864EC0", Offset = "0x58638C0", VA = "0x185864EC0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x5864DC0", Offset = "0x58637C0", VA = "0x185864DC0")]
	protected void DPFEAIHCFLK(Action DAAMKALKLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5864F10", Offset = "0x5863910", VA = "0x185864F10")]
	protected JKAHJLGEFLE KDDIGGOJCMO(float JDMBDIMAGHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5865110", Offset = "0x5863B10", VA = "0x185865110")]
	private void LCMGPDMHDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5864DE0", Offset = "0x58637E0", VA = "0x185864DE0")]
	[IteratorStateMachine(typeof(MBDDBMLPFGA))]
	private IEnumerator<MEOADLJIECK> GFBIPBECEDG(float JDMBDIMAGHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5865190", Offset = "0x5863B90", VA = "0x185865190")]
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
	[Cpp2IlInjected.Address(RVA = "0x585E9A0", Offset = "0x585D3A0", VA = "0x18585E9A0")]
	public CDPCAHHAGKC(Behaviour PKDAKJPDDGD, float OODNIADNGEH, int KCBGDMLLCBF, [Optional] Action DCLLICGCKKL, float IDLFMJMEMKG = 0f, [Optional] ABIJEIDBFLE ALGKCFEJIHD, [Optional] DBHPJOBGDCD JGJBGLEMPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "9")]
	protected override bool GOGFGDIMHFG(Action DAAMKALKLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x585E770", Offset = "0x585D170", VA = "0x18585E770", Slot = "10")]
	protected override bool HCGJACEOKKB(Action DAAMKALKLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x585E6E0", Offset = "0x585D0E0", VA = "0x18585E6E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x586FA70", Offset = "0x586E470", VA = "0x18586FA70")]
	public LHAKMONOEJJ(Behaviour PKDAKJPDDGD, float KFLEPGFKDCH, [Optional] Action DCLLICGCKKL, [Optional] ABIJEIDBFLE ALGKCFEJIHD, [Optional] DBHPJOBGDCD JGJBGLEMPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "9")]
	protected override bool GOGFGDIMHFG(Action DAAMKALKLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x586FA30", Offset = "0x586E430", VA = "0x18586FA30", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public IPIBOMGLLOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5867300", Offset = "0x5865D00", VA = "0x185867300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x58673A0", Offset = "0x5865DA0", VA = "0x1858673A0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x5867120", Offset = "0x5865B20", VA = "0x185867120")]
	public ILHFFMODJAK(MFABPFMFOOL PKDAKJPDDGD, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5866B90", Offset = "0x5865590", VA = "0x185866B90")]
	private void CBIBMGBBAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5866FC0", Offset = "0x58659C0", VA = "0x185866FC0")]
	private void PIMDONHFHIO(string NOGDNAGMMCO, Action ALIMKEFEGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5866DA0", Offset = "0x58657A0", VA = "0x185866DA0")]
	[IteratorStateMachine(typeof(IPIBOMGLLOG))]
	private IEnumerator<MEOADLJIECK> KDGBKGJFNMA(Action ALIMKEFEGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5866D40", Offset = "0x5865740", VA = "0x185866D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5866E10", Offset = "0x5865810", VA = "0x185866E10")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public FCGHKCCNBNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5864120", Offset = "0x5862B20", VA = "0x185864120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x58641C0", Offset = "0x5862BC0", VA = "0x1858641C0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x586F130", Offset = "0x586DB30", VA = "0x18586F130")]
	public LFGIECBFELB(MonoBehaviour GEEDNCPBAAN, Action KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x586F330", Offset = "0x586DD30", VA = "0x18586F330")]
	public LFGIECBFELB(MonoBehaviour GEEDNCPBAAN, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x586F570", Offset = "0x586DF70", VA = "0x18586F570")]
	public LFGIECBFELB(MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x40E19C0", Offset = "0x40E03C0", VA = "0x1840E19C0")]
	private LFGIECBFELB(ABIJEIDBFLE ALGKCFEJIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x586E3B0", Offset = "0x586CDB0", VA = "0x18586E3B0")]
	internal static LFGIECBFELB BAPGBKPPHPG(MonoBehaviour GEEDNCPBAAN, float GBKEOCDGBDD, Action<float> KPOMAEBEHKO, GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, bool LPBEOOKCPMN = true, [Optional] ABIJEIDBFLE ALGKCFEJIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x586EB50", Offset = "0x586D550", VA = "0x18586EB50")]
	private void IMAHKDEDKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x586ED50", Offset = "0x586D750", VA = "0x18586ED50")]
	private void KCIJCOHAGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x586E650", Offset = "0x586D050", VA = "0x18586E650")]
	private void CBIBMGBBAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x586E860", Offset = "0x586D260", VA = "0x18586E860")]
	private void ECMIMKMDJGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x586F000", Offset = "0x586DA00", VA = "0x18586F000")]
	private void PIMDONHFHIO(string NOGDNAGMMCO, Action ALIMKEFEGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x586EF00", Offset = "0x586D900", VA = "0x18586EF00")]
	[IteratorStateMachine(typeof(FCGHKCCNBNF))]
	private IEnumerator<MEOADLJIECK> KDGBKGJFNMA(Action ALIMKEFEGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x586E800", Offset = "0x586D200", VA = "0x18586E800", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x586EF70", Offset = "0x586D970", VA = "0x18586EF70")]
	[CompilerGenerated]
	private void NHNPILPGMGG(string CCICIDAGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x586EAC0", Offset = "0x586D4C0", VA = "0x18586EAC0")]
	[CompilerGenerated]
	private void HNFPLHGMJFC(string CCICIDAGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x586EA30", Offset = "0x586D430", VA = "0x18586EA30")]
	[CompilerGenerated]
	private void EHCLGLMONOH(string CCICIDAGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x586ECC0", Offset = "0x586D6C0", VA = "0x18586ECC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x585B110", Offset = "0x5859B10", VA = "0x18585B110", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public float ONLLPCFDIHI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x585B070", Offset = "0x5859A70", VA = "0x18585B070", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public double OOHNDBILHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x585B080", Offset = "0x5859A80", VA = "0x18585B080", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x585B0A0", Offset = "0x5859AA0", VA = "0x18585B0A0")]
	[JDDIJBKLPJE(GHILFLKBMBN.None)]
	private static void JCIGPGHKKDF(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x725A20", VA = "0x180727020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7318F0", Offset = "0x7302F0", VA = "0x1807318F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5866870", Offset = "0x5865270", VA = "0x185866870")]
	public static MEOADLJIECK MHNFLJCFEFI(IEnumerator<MEOADLJIECK> FIMKDMIIEGJ, LEHHMJHIFKG EKHBCMEIBCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5866A20", Offset = "0x5865420", VA = "0x185866A20")]
	public MEOADLJIECK MHNFLJCFEFI(LEHHMJHIFKG[] GPJJKAFDPOP, IEnumerator<MEOADLJIECK>[] DMGGHGLAPHC, MEOADLJIECK[] BHDOBMCDEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5866700", Offset = "0x5865100", VA = "0x185866700")]
	public void GGMHIANBBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5866730", Offset = "0x5865130", VA = "0x185866730")]
	public void MDNFGOHFKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x58665C0", Offset = "0x5864FC0", VA = "0x1858665C0")]
	public void AGNLADGIKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5866700", Offset = "0x5865100", VA = "0x185866700")]
	public void GJMJKHONEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public PHFJDLFPBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x58725A0", Offset = "0x5870FA0", VA = "0x1858725A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public JBDNKBNFBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x58673E0", Offset = "0x5865DE0", VA = "0x1858673E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public GPCLIHLHKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5865E70", Offset = "0x5864870", VA = "0x185865E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public BFOEPPEHBJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x585D420", Offset = "0x585BE20", VA = "0x18585D420")]
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
		[Cpp2IlInjected.Address(RVA = "0xF87FD0", Offset = "0xF869D0", VA = "0x180F87FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x58692D0", Offset = "0x5867CD0", VA = "0x1858692D0")]
	private static int NLFDPOACHIJ(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x58697A0", Offset = "0x58681A0", VA = "0x1858697A0")]
	public JMBCPOOFJNA(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5869300", Offset = "0x5867D00", VA = "0x185869300")]
	private void OPJFILHAJNP(ref int EDBLIJGFKHM, int KIFKNMFJJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5867A50", Offset = "0x5866450", VA = "0x185867A50")]
	public void CONEEMMJOIG(MFABPFMFOOL PKDAKJPDDGD, MEOADLJIECK CBIKKBFKCOE, IEnumerator<MEOADLJIECK> FIMKDMIIEGJ, LEHHMJHIFKG EKHBCMEIBCI, [Optional] HNJGKNDICLP DFAIGLLCAHG, MPPOCDJEFNF PJOANNGLEFL = MPPOCDJEFNF.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5867860", Offset = "0x5866260", VA = "0x185867860")]
	public void CHOPNOPODPD(IEnumerable<IENJEAKOOPE> EPLKCKDIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5868D40", Offset = "0x5867740", VA = "0x185868D40")]
	private IENJEAKOOPE KCEFPJFPIBL(int CCLADLMOKAJ)
	{
		return default(IENJEAKOOPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x58685C0", Offset = "0x5866FC0", VA = "0x1858685C0")]
	private void FJKHCIOMKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x199AA40", Offset = "0x1999440", VA = "0x18199AA40")]
	private static void FBIFHCFOPJG<T>(int CCLADLMOKAJ, T[] JEMKOPFCBCN, int GBNBGNMHGLO, [Optional] T KGOLEALODOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x199AA20", Offset = "0x1999420", VA = "0x18199AA20")]
	private static void FBIFHCFOPJG<T>(int CCLADLMOKAJ, NativeArray<T> JEMKOPFCBCN, int GBNBGNMHGLO, [Optional] T KGOLEALODOB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x58694F0", Offset = "0x5867EF0", VA = "0x1858694F0")]
	private void PCOEJFADDBK(IEnumerable<IENJEAKOOPE> EPLKCKDIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5868C70", Offset = "0x5867670", VA = "0x185868C70")]
	private void HACFKDKDOOF(IENJEAKOOPE ODMDCCBJPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5867BD0", Offset = "0x58665D0", VA = "0x185867BD0")]
	private AFONPMGCJBM DFJNLNCGBBF(int DENALOGECKH)
	{
		return default(AFONPMGCJBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5868A90", Offset = "0x5867490", VA = "0x185868A90")]
	public void GMFJPJLFNAK(float KEACOEKDBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x58677E0", Offset = "0x58661E0", VA = "0x1858677E0")]
	private void CCKKHEBEEIN(Action HFOFADIOHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5869250", Offset = "0x5867C50", VA = "0x185869250")]
	private void NEHECOBJDKL(Action HFOFADIOHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5867E90", Offset = "0x5866890", VA = "0x185867E90")]
	public void EPCHJMCPLMJ(float KEACOEKDBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5867480", Offset = "0x5865E80", VA = "0x185867480")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5868960", Offset = "0x5867360", VA = "0x185868960")]
	public void GJMJKHONEFD(HNJGKNDICLP LJOLPEJEKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x58676B0", Offset = "0x58660B0", VA = "0x1858676B0")]
	public void CBABINIJGKF(HNJGKNDICLP LJOLPEJEKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5867580", Offset = "0x5865F80", VA = "0x185867580")]
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
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
	public LHLGDPFGIHG(Action DGALPKMLGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x586FB70", Offset = "0x586E570", VA = "0x18586FB70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public OPNOCBDLMJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FB50", Offset = "0x3D0E550", VA = "0x183D0FB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B260", Offset = "0x729C60", VA = "0x18072B260", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x38F5C90", Offset = "0x38F4690", VA = "0x1838F5C90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x38F5920", Offset = "0x38F4320", VA = "0x1838F5920")]
	private static bool AHIHBCIGHPH(T HFOFADIOHHP, T GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x38F6430", Offset = "0x38F4E30", VA = "0x1838F6430")]
	public KKFKKAFPOKK(T LMOELINAFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x38F59B0", Offset = "0x38F43B0", VA = "0x1838F59B0", Slot = "6")]
	public IDisposable JDHNOHBGCBF(UnityEngine.Object PKDAKJPDDGD, Action<T> LALKOPDMNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x38F5D70", Offset = "0x38F4770", VA = "0x1838F5D70")]
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
	[Cpp2IlInjected.Address(RVA = "0x586BBC0", Offset = "0x586A5C0", VA = "0x18586BBC0")]
	[JDDIJBKLPJE(GHILFLKBMBN.None)]
	private static void JCIGPGHKKDF(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
	[Preserve]
	internal KLNBJNPPHKE([LIKONNNLKGK(null)] ABIJEIDBFLE ALGKCFEJIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x586BB20", Offset = "0x586A520", VA = "0x18586BB20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5872100", Offset = "0x5870B00", VA = "0x185872100")]
	public static OPIGJNBABPG IDIKGABNBEI(int PGGBCPANCPE, float KEACOEKDBMO, NativeArray<MPPOCDJEFNF> GLHBMOEBJHE, NativeArray<float> ECBJDGDKNOE, NativeArray<int> GJAJGIDOMIA, NativeArray<int> NPLLFCHKICN, NativeArray<int> GDJHMCFPKEI, NativeArray<int> OGDCKDMLPAC, NativeArray<int> KAPBBOOBMPG)
	{
		return default(OPIGJNBABPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5872020", Offset = "0x5870A20", VA = "0x185872020", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5872260", Offset = "0x5870C60", VA = "0x185872260")]
	private bool PIJNFGDLFJO(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5872160", Offset = "0x5870B60", VA = "0x185872160")]
	private void KOOGGAIBGHL(NativeArray<int> PODMIAGABCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5871FC0", Offset = "0x58709C0", VA = "0x185871FC0")]
	private int EPBKBKLCJDL(int FCPAMLNPMML, int KMDPNEFDEMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5872190", Offset = "0x5870B90", VA = "0x185872190")]
	private void NPBAKECKDLM(NativeArray<int> PODMIAGABCD, int GMEAMCBCPJO, int NFAMBOPBCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5871D90", Offset = "0x5870790", VA = "0x185871D90")]
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
	[Cpp2IlInjected.Address(RVA = "0x585DD90", Offset = "0x585C790", VA = "0x18585DD90")]
	[JDDIJBKLPJE(GHILFLKBMBN.None)]
	private static void JCIGPGHKKDF(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x585DEB0", Offset = "0x585C8B0", VA = "0x18585DEB0")]
	[Preserve]
	public BGOKCNKGIMF([LIKONNNLKGK(null)] OHOEHKDLBJA EANHCIMIPKM, [LIKONNNLKGK(null)] DBHPJOBGDCD JGJBGLEMPFO, [LIKONNNLKGK(null)] LINIFLKHMOG LDCGFBEHFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x585D600", Offset = "0x585C000", VA = "0x18585D600", Slot = "12")]
	public override GNGMNANCADP DPLPJDEFCHN(MFABPFMFOOL PKDAKJPDDGD, IEnumerator<MEOADLJIECK> FDJLJICJMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x585DAB0", Offset = "0x585C4B0", VA = "0x18585DAB0", Slot = "13")]
	public override void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x585D7F0", Offset = "0x585C1F0", VA = "0x18585D7F0", Slot = "15")]
	public override void FHAKFCMFHLD(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x585D9D0", Offset = "0x585C3D0", VA = "0x18585D9D0", Slot = "14")]
	protected override void HGAJENLLFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x585D7B0", Offset = "0x585C1B0", VA = "0x18585D7B0")]
	private JMBCPOOFJNA EAGOPABBFBI(GLMLDOMIGMH.NMMGBICHGHP OGILDIMGIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x585DE00", Offset = "0x585C800", VA = "0x18585DE00", Slot = "16")]
	internal override KHMJIPMGIGA MCMDFMNHGBO(IEnumerator<MEOADLJIECK> FDJLJICJMNI, Behaviour PKDAKJPDDGD, LEHHMJHIFKG EKHBCMEIBCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x585D460", Offset = "0x585BE60", VA = "0x18585D460", Slot = "17")]
	internal override ACFMMCDBEDA DADLLGHBKAC(GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x585D4D0", Offset = "0x585BED0", VA = "0x18585D4D0")]
	private void DGPKHNPJFNK(JMBCPOOFJNA EAAPDJPJFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x585D740", Offset = "0x585C140", VA = "0x18585D740", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x5869F70", Offset = "0x5868970", VA = "0x185869F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static bool CDOMMGFPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public GLMLDOMIGMH.NMMGBICHGHP BJGCDFPHEFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x725A20", VA = "0x180727020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GLMLDOMIGMH.NMMGBICHGHP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7318F0", Offset = "0x7302F0", VA = "0x1807318F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DBHPJOBGDCD CGIFABIIKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x586A340", Offset = "0x5868D40", VA = "0x18586A340")]
	public static GNGMNANCADP EGGBEKEKBDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x586ABA0", Offset = "0x58695A0", VA = "0x18586ABA0")]
	[Preserve]
	protected JNGCDGNBPFH([LIKONNNLKGK(null)] OHOEHKDLBJA EANHCIMIPKM, [LIKONNNLKGK(null)] DBHPJOBGDCD JGJBGLEMPFO, [LIKONNNLKGK(null)] LINIFLKHMOG LDCGFBEHFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x586A8A0", Offset = "0x58692A0", VA = "0x18586A8A0", Slot = "6")]
	public GNGMNANCADP KJENKEOBMBM(IEnumerator<MEOADLJIECK> FDJLJICJMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x586A8B0", Offset = "0x58692B0", VA = "0x18586A8B0", Slot = "7")]
	public GNGMNANCADP KJENKEOBMBM(Behaviour PKDAKJPDDGD, IEnumerator<MEOADLJIECK> FDJLJICJMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract GNGMNANCADP DPLPJDEFCHN(MFABPFMFOOL PKDAKJPDDGD, IEnumerator<MEOADLJIECK> FDJLJICJMNI);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x586A660", Offset = "0x5869060", VA = "0x18586A660", Slot = "13")]
	public virtual void JAIKDMLJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x586A840", Offset = "0x5869240", VA = "0x18586A840", Slot = "9")]
	public void KAOBHLIBGDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x586A640", Offset = "0x5869040", VA = "0x18586A640", Slot = "14")]
	protected virtual void HGAJENLLFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x586AB00", Offset = "0x5869500", VA = "0x18586AB00")]
	private void LMMGKJCLHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x586A3E0", Offset = "0x5868DE0", VA = "0x18586A3E0")]
	private void FDNBFEIPIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x586AB40", Offset = "0x5869540", VA = "0x18586AB40")]
	private void MCKPAKFDOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x586AB80", Offset = "0x5869580", VA = "0x18586AB80")]
	private void OOGMPBGFDHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x586AB60", Offset = "0x5869560", VA = "0x18586AB60")]
	private void OAPIKDKBAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x586AB20", Offset = "0x5869520", VA = "0x18586AB20")]
	private void LOHHIIMJGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x586AAE0", Offset = "0x58694E0", VA = "0x18586AAE0")]
	private void LHGMILCJEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x586A400", Offset = "0x5868E00", VA = "0x18586A400", Slot = "15")]
	public virtual void FHAKFCMFHLD(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5869DA0", Offset = "0x58687A0", VA = "0x185869DA0")]
	private void ACHCPMGNLKJ(ACFMMCDBEDA EAAPDJPJFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0xBA6AD0", Offset = "0xBA54D0", VA = "0x180BA6AD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5869FC0", Offset = "0x58689C0", VA = "0x185869FC0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x730AE0", Offset = "0x72F4E0", VA = "0x180730AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public MEOADLJIECK BDJOJFBNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x730AF0", Offset = "0x72F4F0", VA = "0x180730AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MCJHGGJCBJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x586B410", Offset = "0x5869E10", VA = "0x18586B410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DGFKNBLGLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA66190", Offset = "0xA64B90", VA = "0x180A66190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x263BC50", Offset = "0x263A650", VA = "0x18263BC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string HOIPOKICKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x731A20", Offset = "0x730420", VA = "0x180731A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public float POOLMLEGCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x10C1BA0", Offset = "0x10C05A0", VA = "0x1810C1BA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x10C1BB0", Offset = "0x10C05B0", VA = "0x1810C1BB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x586B880", Offset = "0x586A280", VA = "0x18586B880")]
	public KHMJIPMGIGA(IEnumerator<MEOADLJIECK> FIMKDMIIEGJ, IMKJAFDIHLC PKDAKJPDDGD, LEHHMJHIFKG EKHBCMEIBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x586B490", Offset = "0x5869E90", VA = "0x18586B490")]
	public MEOADLJIECK MHNFLJCFEFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x586B750", Offset = "0x586A150", VA = "0x18586B750")]
	public bool OJCABMAMFDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x586B390", Offset = "0x5869D90", VA = "0x18586B390")]
	public void GJMJKHONEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x586B7C0", Offset = "0x586A1C0", VA = "0x18586B7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x16FD4A0", Offset = "0x16FBEA0", VA = "0x1816FD4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B5070", Offset = "0x7B3A70", VA = "0x1807B5070", Slot = "23")]
		get
		{
			return default(GLMLDOMIGMH.NMMGBICHGHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GLMLDOMIGMH.NMMGBICHGHP EFFFFHEEIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA4C560", Offset = "0xA4AF60", VA = "0x180A4C560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float PDNPPGNGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x12E9F50", Offset = "0x12E8950", VA = "0x1812E9F50", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool NNJPKLCGOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x586E330", Offset = "0x586CD30", VA = "0x18586E330", Slot = "24")]
	private bool LPIGJHMDKAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x586E320", Offset = "0x586CD20", VA = "0x18586E320", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x586E350", Offset = "0x586CD50", VA = "0x18586E350")]
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
		[Cpp2IlInjected.Address(RVA = "0x7270F0", Offset = "0x725AF0", VA = "0x1807270F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x585C5E0", Offset = "0x585AFE0", VA = "0x18585C5E0")]
	public ACFMMCDBEDA(GLMLDOMIGMH.NMMGBICHGHP OFLALIMFMPN, PCNMAAACDHJ FIAPOBKKKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x585C3B0", Offset = "0x585ADB0", VA = "0x18585C3B0")]
	public void NJPILMDMCLK(KHMJIPMGIGA FIMKDMIIEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x585BC30", Offset = "0x585A630", VA = "0x18585BC30")]
	public void IDLHFEPIOPG(IList<KHMJIPMGIGA> DMGGHGLAPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x585B580", Offset = "0x5859F80", VA = "0x18585B580")]
	public void FDAODGENLMG(IList<KHMJIPMGIGA> DMGGHGLAPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x585BF00", Offset = "0x585A900", VA = "0x18585BF00")]
	private void JAGFGPOFGDD(KHMJIPMGIGA FIMKDMIIEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x585B970", Offset = "0x585A370", VA = "0x18585B970")]
	private void GBHDNKJKCLI(IList<KHMJIPMGIGA> DMGGHGLAPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x585C210", Offset = "0x585AC10", VA = "0x18585C210")]
	private AFONPMGCJBM NIIPBFJAPAE(KHMJIPMGIGA FIMKDMIIEGJ)
	{
		return default(AFONPMGCJBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x585BAF0", Offset = "0x585A4F0", VA = "0x18585BAF0")]
	public void HGAJENLLFEE(float KEACOEKDBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x585C000", Offset = "0x585AA00", VA = "0x18585C000")]
	public void KAOBHLIBGDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x585B260", Offset = "0x5859C60", VA = "0x18585B260")]
	private void EAAAGFAJEPN(List<KHMJIPMGIGA> DMGGHGLAPHC, Stack<int> KJEOBHANEIJ, bool EOMLHGLDDIM, float GLOPLLAAJOM = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x585B120", Offset = "0x5859B20", VA = "0x18585B120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x585B850", Offset = "0x585A250", VA = "0x18585B850")]
	private void FDOGMNBIEPE(List<KHMJIPMGIGA> DMGGHGLAPHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal class LLBJIDDLEIG : PCNMAAACDHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "4")]
	public void IFOJNDFJOMK(string AMNLGEBHFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
	public void NJIMPAHFKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x5870390", Offset = "0x586ED90", VA = "0x185870390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool ADOEMHIFDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5870310", Offset = "0x586ED10", VA = "0x185870310", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool EKBEMIJIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5870370", Offset = "0x586ED70", VA = "0x185870370", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
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

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
public class PHLOFEOPBJB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority HPLGHOOFCEK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5569B80", Offset = "0x5568180", VA = "0x185569B80")]
	public PHLOFEOPBJB(ThreadPriority ICFMBEFAIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5569B70", Offset = "0x5568170", VA = "0x185569B70", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> GGOCBJMNNIH(List<PlayerLoopSystem> FLDPOGAHGIJ, int PLPPGOLDJML);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct DFDDIJHJKDD
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct PNDBNKOMOGH
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static FHIFKLKAEJA EGJINPKMIFG;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x5569F50", Offset = "0x5568550", VA = "0x185569F50")]
				public static PlayerLoopSystem FFENIPAJFGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct GLGDKKHJBNO
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static FHIFKLKAEJA CEAGAHDIMJF;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x555D770", Offset = "0x555BD70", VA = "0x18555D770")]
				public static PlayerLoopSystem FFENIPAJFGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct GKKLKKHOEPK
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static FHIFKLKAEJA JGBALHMOEMI;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x555D590", Offset = "0x555BB90", VA = "0x18555D590")]
				public static PlayerLoopSystem FFENIPAJFGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct NALBKMJEOKC
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static FHIFKLKAEJA KHOPCBCIMDO;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static FHIFKLKAEJA JFKCKMKJFLF;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static FHIFKLKAEJA PLCGEAMLADH;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static FHIFKLKAEJA MBLMFPEBNGO;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x5565A70", Offset = "0x5564070", VA = "0x185565A70")]
				public static PlayerLoopSystem FFENIPAJFGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct AEFILEEFAJL
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static FHIFKLKAEJA FDLCCLCFPCP;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5552F80", Offset = "0x5551580", VA = "0x185552F80")]
				public static PlayerLoopSystem FFENIPAJFGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct IDAFDNGLMNH
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static FHIFKLKAEJA KHOPCBCIMDO;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static FHIFKLKAEJA JFKCKMKJFLF;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static FHIFKLKAEJA PLCGEAMLADH;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static FHIFKLKAEJA MBLMFPEBNGO;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x555DD10", Offset = "0x555C310", VA = "0x18555DD10")]
				public static PlayerLoopSystem FFENIPAJFGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct NPBMCOPGIEA
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static FHIFKLKAEJA ENJONKICFGL;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x5568D10", Offset = "0x5567310", VA = "0x185568D10")]
				public static PlayerLoopSystem FFENIPAJFGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct GDJFBOOPOCP
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static FHIFKLKAEJA BJLIBIFCADL;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x555AAB0", Offset = "0x55590B0", VA = "0x18555AAB0")]
				public static PlayerLoopSystem FFENIPAJFGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct ALBLFNCGJDC
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static FHIFKLKAEJA OLGKMEFCGLC;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x5553F20", Offset = "0x5552520", VA = "0x185553F20")]
				public static PlayerLoopSystem FFENIPAJFGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct OBNJHNKPAFN
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static FHIFKLKAEJA GKGENHHEAPN;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x5569400", Offset = "0x5567A00", VA = "0x185569400")]
				public static PlayerLoopSystem FFENIPAJFGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct BOCMMJAAFPL
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static FHIFKLKAEJA GAAJJGHJMNG;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x5554570", Offset = "0x5552B70", VA = "0x185554570")]
				public static PlayerLoopSystem FFENIPAJFGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct JNLDMMKNLLN
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class KBFPOIKHCCA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public DCFOKCCEJKL.KHCIJNHJPJK key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
					public KBFPOIKHCCA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x555FFA0", Offset = "0x555E5A0", VA = "0x18555FFA0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable DKNLFNJKCJE;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x555F6A0", Offset = "0x555DCA0", VA = "0x18555F6A0")]
				public static PlayerLoopSystem NKGPBEMNBMP(DCFOKCCEJKL.KHCIJNHJPJK AIGAKEKDKHM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct ENCMFACIHKF
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class HCKHOFJBAJK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002E")]
					public DCFOKCCEJKL.KHCIJNHJPJK key;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
					public HCKHOFJBAJK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x555D950", Offset = "0x555BF50", VA = "0x18555D950")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x5559560", Offset = "0x5557B60", VA = "0x185559560")]
				public static PlayerLoopSystem NKGPBEMNBMP(DCFOKCCEJKL.KHCIJNHJPJK AIGAKEKDKHM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class CKLMGEPCFKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public CKLMGEPCFKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5554A80", Offset = "0x5553080", VA = "0x185554A80")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool OEJMINCMEKH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool ADEGKFNOBOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5557BA0", Offset = "0x55561A0", VA = "0x185557BA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5556C70", Offset = "0x5555270", VA = "0x185556C70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5554DD0", Offset = "0x55533D0", VA = "0x185554DD0")]
		private static void BIEJIKGIAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5556FA0", Offset = "0x55555A0", VA = "0x185556FA0")]
		private static void MLIJPNCIKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5557870", Offset = "0x5555E70", VA = "0x185557870")]
		private static void NNELPADLHDB(string GIEANINLCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5554BA0", Offset = "0x55531A0", VA = "0x185554BA0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5556CB0", Offset = "0x55552B0", VA = "0x185556CB0")]
		private static void DANOGJONOKC(DCFOKCCEJKL.KHCIJNHJPJK AIGAKEKDKHM, ref PlayerLoopSystem MLCKPMIEFOM, Type PFLJHLPGIOF, Type ELMAGEBOEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5557BE0", Offset = "0x55561E0", VA = "0x185557BE0")]
		private static void PIAIANELFLE(ref PlayerLoopSystem MLCKPMIEFOM, Type PFLJHLPGIOF, Type ELMAGEBOEPD, GGOCBJMNNIH GJPCIAKICEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5556E70", Offset = "0x5555470", VA = "0x185556E70")]
		private static void DCEFIKHOEOB(ref PlayerLoopSystem MLCKPMIEFOM, Type PFLJHLPGIOF, Type ELMAGEBOEPD, PlayerLoopSystem? KPBAANAONIN, PlayerLoopSystem? CHJBJDKEMME)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DCFOKCCEJKL
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum KHCIJNHJPJK
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
	public class KGMJNMKKDFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly KHCIJNHJPJK JDJEJCOFBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly ECGBCGEFHKL ABCINAMNPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long JCJBGGEHJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long DCCAPHBMAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long PPDMOHMPFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int GGNFDKJNLAD;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x55628F0", Offset = "0x5560EF0", VA = "0x1855628F0")]
		public KGMJNMKKDFI(KHCIJNHJPJK IGHIKIPKNJF, int AANPJGONDHI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5562620", Offset = "0x5560C20", VA = "0x185562620")]
		public void CHPKMIBAFMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5562890", Offset = "0x5560E90", VA = "0x185562890")]
		public void FGCKAGLGGPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5562690", Offset = "0x5560C90", VA = "0x185562690")]
		public void DBGKOKGBAAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static KHCIJNHJPJK[] KPEOKGJADAP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static KGMJNMKKDFI[] IDFLJIINNCO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5558800", Offset = "0x5556E00", VA = "0x185558800")]
	public static KGMJNMKKDFI JEPCHLEPEJH(KHCIJNHJPJK AIGAKEKDKHM, int AANPJGONDHI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x55589D0", Offset = "0x5556FD0", VA = "0x1855589D0")]
	public static KGMJNMKKDFI KAMFCPEJJFD(KHCIJNHJPJK AIGAKEKDKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5558750", Offset = "0x5556D50", VA = "0x185558750")]
	public static void BHGIBJPFAII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class ECGBCGEFHKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int JJMGHEDHNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Queue<double> EOIDAKPGNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double MJBMGGEOKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double CGFBNEMNBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double FPECDFCFNOO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double JEOMGLGILCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5558D60", Offset = "0x5557360", VA = "0x185558D60", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5558DC0", Offset = "0x55573C0", VA = "0x185558DC0")]
	public ECGBCGEFHKL(int EKHFOIGILBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5558C30", Offset = "0x5557230", VA = "0x185558C30", Slot = "4")]
	public void KCNELGBFHJA(double PHMPKLAMLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5558BC0", Offset = "0x55571C0", VA = "0x185558BC0", Slot = "5")]
	public void GJKIOCLBKIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EDMBJHPLMAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private long FPLNDBJJHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double PMJCAGIKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double DLPPEAHELFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private double MOPPHJGBMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private double DGOGHFCNGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private double MJBMGGEOKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private double CGFBNEMNBGA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double EJLJGMIDEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9FB130", Offset = "0x9F9730", VA = "0x1809FB130", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double IOJPOBGMBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9FB1B0", Offset = "0x9F97B0", VA = "0x1809FB1B0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double INCDFANECPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x885650", Offset = "0x883C50", VA = "0x180885650")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JEOMGLGILCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9FB050", Offset = "0x9F9650", VA = "0x1809FB050", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5558EB0", Offset = "0x55574B0", VA = "0x185558EB0", Slot = "7")]
	public void KCNELGBFHJA(double PHMPKLAMLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5558E70", Offset = "0x5557470", VA = "0x185558E70", Slot = "8")]
	public void GJKIOCLBKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5558FE0", Offset = "0x55575E0", VA = "0x185558FE0")]
	public EDMBJHPLMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class JNMGMDBEJNE
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private interface GNHLFFLHGGD
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool IAKIPFHNFNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ADFDICGOODJ();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private abstract class LLLNLEGLMDE<TPromise, TMainThreadPromise> : GNHLFFLHGGD where TPromise : IGOPHNBFNOE where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly TPromise NEGNAEKOKFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected readonly TMainThreadPromise NNLPKEDLMIJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise LLFKIFDJBBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3051020", Offset = "0x304F620", VA = "0x183051020")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IAKIPFHNFNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3050FD0", Offset = "0x304F5D0", VA = "0x183050FD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3051080", Offset = "0x304F680", VA = "0x183051080")]
		protected LLLNLEGLMDE(TPromise NEGNAEKOKFO, TMainThreadPromise NKHDJPDIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3050FA0", Offset = "0x304F5A0", VA = "0x183050FA0", Slot = "5")]
		public void ADFDICGOODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void HBNIPIINENP(TPromise NEGNAEKOKFO);
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private class MLMHCCBFLOA<T> : LLLNLEGLMDE<global::DIHJKCFGFNO<T>, global::HCPAFFBNPPI<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3B59D80", Offset = "0x3B58380", VA = "0x183B59D80")]
		public MLMHCCBFLOA(global::DIHJKCFGFNO<T> NEGNAEKOKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3B59B70", Offset = "0x3B58170", VA = "0x183B59B70", Slot = "6")]
		protected override void HBNIPIINENP(global::DIHJKCFGFNO<T> NEGNAEKOKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3B59B40", Offset = "0x3B58140", VA = "0x183B59B40")]
		[CompilerGenerated]
		private void GJJINNIDHDB(T BIDLMNEFHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x22996E0", Offset = "0x2297CE0", VA = "0x1822996E0")]
		[CompilerGenerated]
		private void FLFPNHNIOLB(string OOMNIJBIFDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class GBHODKCLEIP : GNHLFFLHGGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly Action PBOHOIMMGFG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IAKIPFHNFNG
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
		public GBHODKCLEIP(Action PBOHOIMMGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1C9B950", Offset = "0x1C99F50", VA = "0x181C9B950", Slot = "5")]
		public void ADFDICGOODJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<GNHLFFLHGGD> LMNPFMCGKCK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3082FC0", Offset = "0x30815C0", VA = "0x183082FC0")]
	public static global::DIHJKCFGFNO<T> MCPBIFJAFDA<T>(this global::DIHJKCFGFNO<T> NEGNAEKOKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x555FB90", Offset = "0x555E190", VA = "0x18555FB90")]
	public static void MCPBIFJAFDA(Action PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3083030", Offset = "0x3081630", VA = "0x183083030")]
	private static global::DIHJKCFGFNO<T> OJPDDDHAAPA<T>(global::DIHJKCFGFNO<T> NEGNAEKOKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x555FC20", Offset = "0x555E220", VA = "0x18555FC20")]
	private static void NFKEEAJHDKN(GNHLFFLHGGD PEKMEFNFBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x555F8A0", Offset = "0x555DEA0", VA = "0x18555F8A0")]
	private static void HKLDAGIMMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x555FE20", Offset = "0x555E420", VA = "0x18555FE20")]
	private static void NNBADIOOCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x555F7D0", Offset = "0x555DDD0", VA = "0x18555F7D0")]
	private static void BHAOFHGLBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class KMFLODPKHNA
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct PPFBODIDGHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TaskCompletionSource<Scene> BDLAHCHFMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly string NILDNJGDILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly LoadSceneMode OLPMEINLGMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool LFOMIKJHJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly GPNAMOIINIG AEKLGCBMNDP;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x556A250", Offset = "0x5568850", VA = "0x18556A250")]
		public PPFBODIDGHA(TaskCompletionSource<Scene> FELNAAAPKJO, string NILDNJGDILH, LoadSceneMode OLPMEINLGMG, bool LFOMIKJHJFO, GPNAMOIINIG AEKLGCBMNDP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct JMKEIJPBCOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public GPNAMOIINIG stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::IMNAINPHIAI<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x555ED10", Offset = "0x555D310", VA = "0x18555ED10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x555F380", Offset = "0x555D980", VA = "0x18555F380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct KCFOCPCPKKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5560A90", Offset = "0x555F090", VA = "0x185560A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct PIILBHBPKPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private PPFBODIDGHA <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5569BC0", Offset = "0x55681C0", VA = "0x185569BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class CHDGLHFAIOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public global::HCPAFFBNPPI<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public CHDGLHFAIOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5554750", Offset = "0x5552D50", VA = "0x185554750")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct FBNGEOJEGDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private CHDGLHFAIOL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private GPNAMOIINIG <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private GPNAMOIINIG <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5559690", Offset = "0x5557C90", VA = "0x185559690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x555A010", Offset = "0x5558610", VA = "0x18555A010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct KCDGNCDEIOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private GPNAMOIINIG <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private GPNAMOIINIG <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5560200", Offset = "0x555E800", VA = "0x185560200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5560A40", Offset = "0x555F040", VA = "0x185560A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class HOPPNNCANGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public HOPPNNCANGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x555DCE0", Offset = "0x555C2E0", VA = "0x18555DCE0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class BAMALLMECBG : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private PBBBHKGHFDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public EONHFJBEBFJ onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
		[DebuggerHidden]
		public BAMALLMECBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5554460", Offset = "0x5552A60", VA = "0x185554460", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5554100", Offset = "0x5552700", VA = "0x185554100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x55544F0", Offset = "0x5552AF0", VA = "0x1855544F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5554420", Offset = "0x5552A20", VA = "0x185554420", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JNFLLNFPLIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public global::HCPAFFBNPPI<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public JNFLLNFPLIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class NEPIAHAAOFD : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private PBBBHKGHFDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public global::HCPAFFBNPPI<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private JNFLLNFPLIA <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
		[DebuggerHidden]
		public NEPIAHAAOFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5566500", Offset = "0x5564B00", VA = "0x185566500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5566950", Offset = "0x5564F50", VA = "0x185566950", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static IGOPHNBFNOE GDIIOPJFNGH;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AsyncOperation LOOLFECCFIB;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static IGOPHNBFNOE NMFNKHFBGJF;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static string PEHOHOKJAAA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ThreadPriority KKBBMLJMHKF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Task GEIELPAEAIE;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Queue<PPFBODIDGHA> KBIBCDGNDEP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Task JDEMMGBMOBP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool NDCPLMBBIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5563820", Offset = "0x5561E20", VA = "0x185563820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool ELHBBJOBOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5564020", Offset = "0x5562620", VA = "0x185564020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool OMBJFIHCIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5563760", Offset = "0x5561D60", VA = "0x185563760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> EFJAHIPAOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x55639E0", Offset = "0x5561FE0", VA = "0x1855639E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5563F20", Offset = "0x5562520", VA = "0x185563F20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5563E50", Offset = "0x5562450", VA = "0x185563E50")]
	[IIADNJEBFGG(NKLKDILCDDO.EnteredEditModeNextFrame, 0)]
	private static void DLLGPHMEDNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5563BB0", Offset = "0x55621B0", VA = "0x185563BB0")]
	[AsyncStateMachine(typeof(JMKEIJPBCOO))]
	public static Task<Scene> COFLJINONFP(string NILDNJGDILH, LoadSceneMode OLPMEINLGMG = LoadSceneMode.Single, bool LFOMIKJHJFO = false, [Optional] GPNAMOIINIG POBIKBKNHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5563AE0", Offset = "0x55620E0", VA = "0x185563AE0")]
	[AsyncStateMachine(typeof(KCFOCPCPKKD))]
	private static Task CKGFHEJIJEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5564230", Offset = "0x5562830", VA = "0x185564230")]
	[AsyncStateMachine(typeof(PIILBHBPKPE))]
	private static Task LMBFDPBLMPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5563320", Offset = "0x5561920", VA = "0x185563320")]
	[AsyncStateMachine(typeof(FBNGEOJEGDG))]
	private static Task<Scene> AJIBINHKPJC(string NILDNJGDILH, LoadSceneMode OLPMEINLGMG, bool LFOMIKJHJFO, GPNAMOIINIG AEKLGCBMNDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5563D10", Offset = "0x5562310", VA = "0x185563D10")]
	[AsyncStateMachine(typeof(KCDGNCDEIOF))]
	private static Task<Scene> DGALEELANFI(GPNAMOIINIG AEKLGCBMNDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5564450", Offset = "0x5562A50", VA = "0x185564450")]
	public static global::DIHJKCFGFNO<Scene> PDADAOBLKDG(string NILDNJGDILH, LoadSceneMode OLPMEINLGMG = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5563480", Offset = "0x5561A80", VA = "0x185563480")]
	public static IGOPHNBFNOE BJEICGPGGGA(string NILDNJGDILH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5564320", Offset = "0x5562920", VA = "0x185564320")]
	[IteratorStateMachine(typeof(BAMALLMECBG))]
	private static IEnumerator<PBBBHKGHFDI> NEGONDBLOMP(string NILDNJGDILH, EONHFJBEBFJ ILDFBDKJCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x55643B0", Offset = "0x55629B0", VA = "0x1855643B0")]
	[IteratorStateMachine(typeof(NEPIAHAAOFD))]
	private static IEnumerator<PBBBHKGHFDI> OECEEJIKEMN(string NILDNJGDILH, LoadSceneMode OLPMEINLGMG, global::HCPAFFBNPPI<Scene> ILDFBDKJCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x55640D0", Offset = "0x55626D0", VA = "0x1855640D0")]
	public static bool JKDLPEELDJE(out string EJMMBGPNEEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GAAHKNNALDC
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x555A930", Offset = "0x5558F30", VA = "0x18555A930")]
	public static IDisposable JLPMEINGILD(this CLNDCOMJDEJ JOOJGLPIMBB, float HJMBIJHLIAC, Action<float> JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x555A9B0", Offset = "0x5558FB0", VA = "0x18555A9B0")]
	public static IDisposable KLCDDPPJDHD(this CLNDCOMJDEJ JOOJGLPIMBB, Action<float> JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x555AA30", Offset = "0x5559030", VA = "0x18555AA30")]
	public static IDisposable OPJJJFFFEDL(this CLNDCOMJDEJ JOOJGLPIMBB, Action<float> JDEFICMNKIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class AKJKCBPLNCN
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5553680", Offset = "0x5551C80", VA = "0x185553680")]
	public static IDisposable DAKOOMPABPM(this MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5553700", Offset = "0x5551D00", VA = "0x185553700")]
	public static IDisposable DAKOOMPABPM(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x55539B0", Offset = "0x5551FB0", VA = "0x1855539B0")]
	public static IDisposable LJKNPIDDPEM(this MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5553C60", Offset = "0x5552260", VA = "0x185553C60")]
	public static IDisposable MKJLJFAPFNF(this MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5553B40", Offset = "0x5552140", VA = "0x185553B40")]
	public static IDisposable MFKBPBMEILP(this MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5553EA0", Offset = "0x55524A0", VA = "0x185553EA0")]
	public static IDisposable PADJFMGMJLG(this MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5553810", Offset = "0x5551E10", VA = "0x185553810")]
	public static IDisposable FBMFPGJNNGL(this MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5553D70", Offset = "0x5552370", VA = "0x185553D70")]
	public static IDisposable OBFAOPIKFBP(this MonoBehaviour ODGNFNGJPCH, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5553BC0", Offset = "0x55521C0", VA = "0x185553BC0")]
	public static IDisposable MFMMPBBLOKN(this MonoBehaviour ODGNFNGJPCH, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5553AB0", Offset = "0x55520B0", VA = "0x185553AB0")]
	public static IDisposable LOIHDHIDHAJ(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5553550", Offset = "0x5551B50", VA = "0x185553550")]
	public static IDisposable AKIBHPOGGPB(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5553890", Offset = "0x5551E90", VA = "0x185553890")]
	public static IDisposable FGDCODGPBML(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5553A20", Offset = "0x5552020", VA = "0x185553A20")]
	public static IDisposable LNKDMLFJIKA(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5553920", Offset = "0x5551F20", VA = "0x185553920")]
	public static IDisposable JLFGFNMFACC(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5553CE0", Offset = "0x55522E0", VA = "0x185553CE0")]
	public static IDisposable NEPBGPILGII(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5553780", Offset = "0x5551D80", VA = "0x185553780")]
	public static IDisposable DMMAMMJJECL(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x55535E0", Offset = "0x5551BE0", VA = "0x1855535E0")]
	public static IDisposable CHBOCHOOFOM(this MonoBehaviour ODGNFNGJPCH, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5553E10", Offset = "0x5552410", VA = "0x185553E10")]
	public static IDisposable OONHJAACBNN(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class AIEBAMPGJGO
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class IGFBPPPFEGA : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private PBBBHKGHFDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public MHOFAIKCPGB.KOLFCAKAGLO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private MCFLFEEAPIK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
		[DebuggerHidden]
		public IGFBPPPFEGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x555EAC0", Offset = "0x555D0C0", VA = "0x18555EAC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x555EB80", Offset = "0x555D180", VA = "0x18555EB80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class OFHBMPPGCLA : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private PBBBHKGHFDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public MHOFAIKCPGB.KOLFCAKAGLO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private MCFLFEEAPIK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
		[DebuggerHidden]
		public OFHBMPPGCLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x55695E0", Offset = "0x5567BE0", VA = "0x1855695E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x55696D0", Offset = "0x5567CD0", VA = "0x1855696D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5553160", Offset = "0x5551760", VA = "0x185553160")]
	public static PFHLOLIKNNP DAKOOMPABPM(Action JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5553280", Offset = "0x5551880", VA = "0x185553280")]
	public static PFHLOLIKNNP DAKOOMPABPM(Behaviour JOOJGLPIMBB, Action JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5553340", Offset = "0x5551940", VA = "0x185553340")]
	public static PFHLOLIKNNP DAKOOMPABPM(Behaviour JOOJGLPIMBB, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5553450", Offset = "0x5551A50", VA = "0x185553450")]
	[IteratorStateMachine(typeof(IGFBPPPFEGA))]
	private static IEnumerator<PBBBHKGHFDI> POIMJACBGDI(MHOFAIKCPGB.KOLFCAKAGLO OBOHCOMMCNH, Action JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x55534D0", Offset = "0x5551AD0", VA = "0x1855534D0")]
	[IteratorStateMachine(typeof(OFHBMPPGCLA))]
	private static IEnumerator<PBBBHKGHFDI> POIMJACBGDI(MHOFAIKCPGB.KOLFCAKAGLO OBOHCOMMCNH, Action<float> JDEFICMNKIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class CKGFCHACLLK
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class OGPHPCNBNLN : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private PBBBHKGHFDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LNEBFMEKLAN schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public MHOFAIKCPGB.KOLFCAKAGLO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private JJOCFBBHDIH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
		[DebuggerHidden]
		public OGPHPCNBNLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5569710", Offset = "0x5567D10", VA = "0x185569710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5569850", Offset = "0x5567E50", VA = "0x185569850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x55547B0", Offset = "0x5552DB0", VA = "0x1855547B0")]
	public static PFHLOLIKNNP DAKOOMPABPM(MonoBehaviour ODGNFNGJPCH, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, bool CGFBNJGILPC = true, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x55548C0", Offset = "0x5552EC0", VA = "0x1855548C0")]
	public static PFHLOLIKNNP FFKHDJLKAMJ(CLNDCOMJDEJ JOOJGLPIMBB, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, bool CGFBNJGILPC = true, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x55549D0", Offset = "0x5552FD0", VA = "0x1855549D0")]
	[IteratorStateMachine(typeof(OGPHPCNBNLN))]
	private static IEnumerator<PBBBHKGHFDI> POIMJACBGDI(LNEBFMEKLAN MNBFEGECFIK, float HJMBIJHLIAC, MHOFAIKCPGB.KOLFCAKAGLO OBOHCOMMCNH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NNFCDKFEEOO
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class NCEIMNHCHPI : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private PBBBHKGHFDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public MHOFAIKCPGB.KOLFCAKAGLO queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
		[DebuggerHidden]
		public NCEIMNHCHPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5566410", Offset = "0x5564A10", VA = "0x185566410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x55664C0", Offset = "0x5564AC0", VA = "0x1855664C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5568B80", Offset = "0x5567180", VA = "0x185568B80")]
	[IteratorStateMachine(typeof(NCEIMNHCHPI))]
	private static IEnumerator<PBBBHKGHFDI> JEJPCAKOMBC(MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, Func<bool> NGDPMIDAOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5568C00", Offset = "0x5567200", VA = "0x185568C00")]
	public static PFHLOLIKNNP KPLGMPPMIOJ(this MonoBehaviour ODGNFNGJPCH, Func<bool> NGDPMIDAOCB, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD = MHOFAIKCPGB.KOLFCAKAGLO.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FPPBPNBMOFB
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class FCEICEDPKCE : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private PBBBHKGHFDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public MHOFAIKCPGB.KOLFCAKAGLO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
		[DebuggerHidden]
		public FCEICEDPKCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x555A060", Offset = "0x5558660", VA = "0x18555A060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x555A120", Offset = "0x5558720", VA = "0x18555A120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x555A5A0", Offset = "0x5558BA0", VA = "0x18555A5A0")]
	[IteratorStateMachine(typeof(FCEICEDPKCE))]
	private static IEnumerator<PBBBHKGHFDI> JGLOMNMHEHC(float HPFCHMNJJNH, MHOFAIKCPGB.KOLFCAKAGLO OBOHCOMMCNH, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x555A3E0", Offset = "0x55589E0", VA = "0x18555A3E0")]
	public static PFHLOLIKNNP GLOAKIPJOIH(this MonoBehaviour ODGNFNGJPCH, float HPFCHMNJJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x555A3C0", Offset = "0x55589C0", VA = "0x18555A3C0")]
	public static PFHLOLIKNNP EMGLHOBDMKK(this MonoBehaviour ODGNFNGJPCH, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x555A800", Offset = "0x5558E00", VA = "0x18555A800")]
	public static PFHLOLIKNNP MIKHBGGKLEA(this MonoBehaviour ODGNFNGJPCH, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x555A210", Offset = "0x5558810", VA = "0x18555A210")]
	public static PFHLOLIKNNP DAIMLEJNMHM(this MonoBehaviour ODGNFNGJPCH, Action FIFMLJNEANH, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x555A900", Offset = "0x5558F00", VA = "0x18555A900")]
	public static PFHLOLIKNNP MPJNOLCMKLM(this MonoBehaviour ODGNFNGJPCH, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x555A570", Offset = "0x5558B70", VA = "0x18555A570")]
	public static PFHLOLIKNNP JDDFFMCGPBB(this MonoBehaviour ODGNFNGJPCH, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x555A7D0", Offset = "0x5558DD0", VA = "0x18555A7D0")]
	public static PFHLOLIKNNP MBOEGKCHMFG(this MonoBehaviour ODGNFNGJPCH, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x555A700", Offset = "0x5558D00", VA = "0x18555A700")]
	private static PFHLOLIKNNP LEIHDKHALJI(MonoBehaviour ODGNFNGJPCH, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, Action FIFMLJNEANH, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x555A830", Offset = "0x5558E30", VA = "0x18555A830")]
	public static PFHLOLIKNNP MLDDEOPGHMM(this MonoBehaviour ODGNFNGJPCH, float KPAJFKNBMOD, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x555A630", Offset = "0x5558C30", VA = "0x18555A630")]
	public static PFHLOLIKNNP LCFLBIJHAMK(this MonoBehaviour ODGNFNGJPCH, float KPAJFKNBMOD, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x555A4A0", Offset = "0x5558AA0", VA = "0x18555A4A0")]
	public static PFHLOLIKNNP GMIPAKPOMLL(this MonoBehaviour ODGNFNGJPCH, float KPAJFKNBMOD, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x555A2F0", Offset = "0x55588F0", VA = "0x18555A2F0")]
	public static PFHLOLIKNNP EFODFNJILGI(this MonoBehaviour ODGNFNGJPCH, float KPAJFKNBMOD, Action FIFMLJNEANH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class KIFKPPLLGPN : DDGADFNBJEA, IEnumerable<DDGADFNBJEA>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly List<DDGADFNBJEA> EPGLGNGPLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool OCGEAHFMHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Action OIBMCKPPBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool GHDKFPPIPKJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool ECHNEAANNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5562A70", Offset = "0x5561070", VA = "0x185562A70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PPHMJFCAAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5563010", Offset = "0x5561610", VA = "0x185563010", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x55630B0", Offset = "0x55616B0", VA = "0x1855630B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5563280", Offset = "0x5561880", VA = "0x185563280")]
	public KIFKPPLLGPN([Optional] Action OIBMCKPPBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5563150", Offset = "0x5561750", VA = "0x185563150")]
	public void MFMCNFFMIAP(DDGADFNBJEA AEEHGLPNAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5562EA0", Offset = "0x55614A0", VA = "0x185562EA0")]
	private void JENICKDDBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5562E90", Offset = "0x5561490", VA = "0x185562E90", Slot = "7")]
	public bool IBOACONOGAB(bool CBEIFKNKIIE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5562BB0", Offset = "0x55611B0", VA = "0x185562BB0", Slot = "8")]
	public bool IBOACONOGAB(Action PBOHOIMMGFG, bool CBEIFKNKIIE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x55629F0", Offset = "0x5560FF0", VA = "0x1855629F0", Slot = "9")]
	public IEnumerator<DDGADFNBJEA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x55629F0", Offset = "0x5560FF0", VA = "0x1855629F0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PANOLDNAHHM : MALPHHCJNOE
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class BDIEEIENHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public PANOLDNAHHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public BDIEEIENHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5554540", Offset = "0x5552B40", VA = "0x185554540")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class JKBBKMAINPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public PANOLDNAHHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public JKBBKMAINPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5554540", Offset = "0x5552B40", VA = "0x185554540")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly float HDBAHOEEOEG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5552E80", Offset = "0x5551480", VA = "0x185552E80")]
	public PANOLDNAHHM(Behaviour JOOJGLPIMBB, float HDBAHOEEOEG, [Optional] Action OIBMCKPPBPB, [Optional] KGCDBDIBGAO BFOBPCDPEEB, [Optional] LNEBFMEKLAN MNBFEGECFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5569970", Offset = "0x5567F70", VA = "0x185569970", Slot = "9")]
	protected override bool APBJMHMCEDD(Action PBOHOIMMGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5569A70", Offset = "0x5568070", VA = "0x185569A70", Slot = "10")]
	protected override bool LPMJKMGFAHM(Action PBOHOIMMGFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface DDGADFNBJEA
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool ECHNEAANNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PPHMJFCAAPL;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IBOACONOGAB(bool CBEIFKNKIIE = false);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IBOACONOGAB(Action PBOHOIMMGFG, bool CBEIFKNKIIE = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class MALPHHCJNOE : DDGADFNBJEA
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class NFCINBGNKHE : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private PBBBHKGHFDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public MALPHHCJNOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
		[DebuggerHidden]
		public NFCINBGNKHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5566990", Offset = "0x5564F90", VA = "0x185566990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5566A60", Offset = "0x5565060", VA = "0x185566A60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Behaviour JOOJGLPIMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Action OIBMCKPPBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private MBDFLNKMPLG PPDOBNPGKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly KGCDBDIBGAO BFOBPCDPEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	protected readonly LNEBFMEKLAN MNBFEGECFIK;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool ECHNEAANNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x93EBD0", Offset = "0x93D1D0", VA = "0x18093EBD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action PPHMJFCAAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5564FE0", Offset = "0x55635E0", VA = "0x185564FE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x55652C0", Offset = "0x55638C0", VA = "0x1855652C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5565360", Offset = "0x5563960", VA = "0x185565360")]
	protected MALPHHCJNOE(Behaviour JOOJGLPIMBB, [Optional] Action OIBMCKPPBPB, [Optional] KGCDBDIBGAO BFOBPCDPEEB, [Optional] LNEBFMEKLAN MNBFEGECFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5564F10", Offset = "0x5563510", VA = "0x185564F10", Slot = "7")]
	public bool IBOACONOGAB(bool CBEIFKNKIIE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5564F70", Offset = "0x5563570", VA = "0x185564F70", Slot = "8")]
	public bool IBOACONOGAB(Action PBOHOIMMGFG, bool CBEIFKNKIIE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool APBJMHMCEDD(Action PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LPMJKMGFAHM(Action PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5564FC0", Offset = "0x55635C0", VA = "0x185564FC0")]
	protected void JDFNEPJFBCC(Action PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5565080", Offset = "0x5563680", VA = "0x185565080")]
	protected IGOPHNBFNOE JNHIOKCDBAM(float OLGHJNFBDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5564E10", Offset = "0x5563410", VA = "0x185564E10")]
	private void FBLBHFELLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5564E90", Offset = "0x5563490", VA = "0x185564E90")]
	[IteratorStateMachine(typeof(NFCINBGNKHE))]
	private IEnumerator<PBBBHKGHFDI> HFDOGELEFJI(float OLGHJNFBDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5565280", Offset = "0x5563880", VA = "0x185565280")]
	[CompilerGenerated]
	private void KEJJCNJAANH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class EKLKECFANDG : MALPHHCJNOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly float NDDMHKBNHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly int LPCJGLIPHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly float ADFAOEGMADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float[] CIJHBFNGLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int FPPLNFDHCMG;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x55593B0", Offset = "0x55579B0", VA = "0x1855593B0")]
	public EKLKECFANDG(Behaviour JOOJGLPIMBB, float BKJBDGDDNGF, int LPCJGLIPHMD, [Optional] Action OIBMCKPPBPB, float ADFAOEGMADM = 0f, [Optional] KGCDBDIBGAO BFOBPCDPEEB, [Optional] LNEBFMEKLAN MNBFEGECFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "9")]
	protected override bool APBJMHMCEDD(Action PBOHOIMMGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5559180", Offset = "0x5557780", VA = "0x185559180", Slot = "10")]
	protected override bool LPMJKMGFAHM(Action PBOHOIMMGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x55590F0", Offset = "0x55576F0", VA = "0x1855590F0")]
	private void FEMDAFEANAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class ADDEAEGDLPH : MALPHHCJNOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly float HDBAHOEEOEG;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5552E80", Offset = "0x5551480", VA = "0x185552E80")]
	public ADDEAEGDLPH(Behaviour JOOJGLPIMBB, float HDBAHOEEOEG, [Optional] Action OIBMCKPPBPB, [Optional] KGCDBDIBGAO BFOBPCDPEEB, [Optional] LNEBFMEKLAN MNBFEGECFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "9")]
	protected override bool APBJMHMCEDD(Action PBOHOIMMGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5552E40", Offset = "0x5551440", VA = "0x185552E40", Slot = "10")]
	protected override bool LPMJKMGFAHM(Action PBOHOIMMGFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class DANOCJHHGHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class ONGCPBGLEJK : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private PBBBHKGHFDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
		[DebuggerHidden]
		public ONGCPBGLEJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5569890", Offset = "0x5567E90", VA = "0x185569890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5569930", Offset = "0x5567F30", VA = "0x185569930", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private PFHLOLIKNNP KFKHNHJMDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private CLNDCOMJDEJ JOOJGLPIMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action<float> KOCLAFOGOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private float CNGCADABJGD;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5558560", Offset = "0x5556B60", VA = "0x185558560")]
	public DANOCJHHGHF(CLNDCOMJDEJ JOOJGLPIMBB, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5558030", Offset = "0x5556630", VA = "0x185558030")]
	private void GIHBOGOILJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5558250", Offset = "0x5556850", VA = "0x185558250")]
	private void MMHIFFCFPII(string OOMNIJBIFDC, Action COFOLKDPBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x55581E0", Offset = "0x55567E0", VA = "0x1855581E0")]
	[IteratorStateMachine(typeof(ONGCPBGLEJK))]
	private IEnumerator<PBBBHKGHFDI> KOAIBEDHDAN(Action COFOLKDPBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5557FD0", Offset = "0x55565D0", VA = "0x185557FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x55583B0", Offset = "0x55569B0", VA = "0x1855583B0")]
	[CompilerGenerated]
	private void NHLPBONDMCP(string CNABBHHIHOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class NHLPGIIMOAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class EILOAMHAKFE : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private PBBBHKGHFDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
		[DebuggerHidden]
		public EILOAMHAKFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5559010", Offset = "0x5557610", VA = "0x185559010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x55590B0", Offset = "0x55576B0", VA = "0x1855590B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private PFHLOLIKNNP KFKHNHJMDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private MonoBehaviour ODGNFNGJPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Action JDEFICMNKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Action<float> KOCLAFOGOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private float CNGCADABJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool CGFBNJGILPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly KGCDBDIBGAO BFOBPCDPEEB;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x55684E0", Offset = "0x5566AE0", VA = "0x1855684E0")]
	public NHLPGIIMOAJ(MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5568940", Offset = "0x5566F40", VA = "0x185568940")]
	public NHLPGIIMOAJ(MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x55686E0", Offset = "0x5566CE0", VA = "0x1855686E0")]
	public NHLPGIIMOAJ(MonoBehaviour ODGNFNGJPCH, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, bool CGFBNJGILPC = true, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5567E90", Offset = "0x5566490", VA = "0x185567E90")]
	private void DAKOOMPABPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5567CE0", Offset = "0x55662E0", VA = "0x185567CE0")]
	private void CPAGJNLDGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x55680F0", Offset = "0x55666F0", VA = "0x1855680F0")]
	private void GIHBOGOILJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x55683B0", Offset = "0x55669B0", VA = "0x1855683B0")]
	private void MMHIFFCFPII(string OOMNIJBIFDC, Action COFOLKDPBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x55682B0", Offset = "0x55668B0", VA = "0x1855682B0")]
	[IteratorStateMachine(typeof(EILOAMHAKFE))]
	private IEnumerator<PBBBHKGHFDI> KOAIBEDHDAN(Action COFOLKDPBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5568090", Offset = "0x5566690", VA = "0x185568090", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5568320", Offset = "0x5566920", VA = "0x185568320")]
	[CompilerGenerated]
	private void LEFGHIHAHMC(string CNABBHHIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5568000", Offset = "0x5566600", VA = "0x185568000")]
	[CompilerGenerated]
	private void DAPECJPJBJE(string CNABBHHIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5567C50", Offset = "0x5566250", VA = "0x185567C50")]
	[CompilerGenerated]
	private void BMJNENMCNBG(string CNABBHHIHOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum PIMOAFDPPMD : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class FNONOHJNGHM : LNEBFMEKLAN
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float DODGLIKNFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x555A200", Offset = "0x5558800", VA = "0x18555A200", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float LEEHLJLBPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x555A1F0", Offset = "0x55587F0", VA = "0x18555A1F0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public double CEKALADGLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x555A160", Offset = "0x5558760", VA = "0x18555A160", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x555A180", Offset = "0x5558780", VA = "0x18555A180")]
	[PILNOHNDGDF(KBMKLHMPDPB.None)]
	private static void HJAIOHOJGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	[Preserve]
	internal FNONOHJNGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface BLPLFNDOFAH
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGIEDNINPML(string NBODBMLPNJA);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJBLNCKIDAA();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface IENELFHEJAC
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IAIALDMGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool AGNKCFCGOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class MOHJMAPEAFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public GHONPBCIBMO JMAFMGEKEFF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int DNFPKCNMAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x695660", Offset = "0x693C60", VA = "0x180695660", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x709AB0", Offset = "0x7080B0", VA = "0x180709AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x55656A0", Offset = "0x5563CA0", VA = "0x1855656A0")]
	public static PBBBHKGHFDI LKHCGHCLIIO(IEnumerator<PBBBHKGHFDI> FHAENLMAGBC, MNIGMFPGMHH KABGCAHOLIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5565850", Offset = "0x5563E50", VA = "0x185565850")]
	public PBBBHKGHFDI LKHCGHCLIIO(MNIGMFPGMHH[] MHFCMKLHCIN, IEnumerator<PBBBHKGHFDI>[] LCMAJMBHADE, PBBBHKGHFDI[] KPAKLCMGIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5565530", Offset = "0x5563B30", VA = "0x185565530")]
	public void EKEMMBCNMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5565560", Offset = "0x5563B60", VA = "0x185565560")]
	public void LCAEAOAKCJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5565930", Offset = "0x5563F30", VA = "0x185565930")]
	public void PCLOHHPFCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5565530", Offset = "0x5563B30", VA = "0x185565530")]
	public void BMOABCGDMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MOHJMAPEAFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class GHONPBCIBMO
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct NGKCAGOKHBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public MOHJMAPEAFG DIDCFMDGBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public CLNDCOMJDEJ HAOHMFCJCDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public MNIGMFPGMHH FMCFGPOMGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public IEnumerator<PBBBHKGHFDI> EJOBLNJCADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public PBBBHKGHFDI CKGELKGNAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public PIMOAFDPPMD EBKJDEBOMBO;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct FAGKEAEOCJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public MHOFAIKCPGB.KOLFCAKAGLO LFAGOGGJLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<NGKCAGOKHBM> NIOOOFBJJJP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LDDDIIDKCAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public GHONPBCIBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public CLNDCOMJDEJ context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public MOHJMAPEAFG routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public PIMOAFDPPMD coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public MNIGMFPGMHH promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public PBBBHKGHFDI currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public IEnumerator<PBBBHKGHFDI> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LDDDIIDKCAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x55646B0", Offset = "0x5562CB0", VA = "0x1855646B0")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MKGFEEDDKHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public MOHJMAPEAFG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public GHONPBCIBMO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public MKGFEEDDKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5565460", Offset = "0x5563A60", VA = "0x185565460")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class LHGMJAKEIPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public MOHJMAPEAFG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public GHONPBCIBMO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LHGMJAKEIPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5564DD0", Offset = "0x55633D0", VA = "0x185564DD0")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class INCACAAMMBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public MOHJMAPEAFG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public GHONPBCIBMO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public INCACAAMMBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x555EBC0", Offset = "0x555D1C0", VA = "0x18555EBC0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const PIMOAFDPPMD LFMBPAHBHMP = PIMOAFDPPMD.Cancelled | PIMOAFDPPMD.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool[] HGDDMDFMNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<PIMOAFDPPMD> MNKCPBMJOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<float> DEHKMOAHEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<int> AMFJJGDAOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<int> CNPMDLDCGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<int> OHOPHKDMGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<int> FDCALOGOFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<int> OCIGIIPJKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private MOHJMAPEAFG[] GIKEBCFKDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private MNIGMFPGMHH[] MHFCMKLHCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private CLNDCOMJDEJ[] MMENBHPAIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private IEnumerator<PBBBHKGHFDI>[] BPNBAAHDDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private PBBBHKGHFDI[] DFHOGDMCPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int MGIMDDLKHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int FHGNFGIEADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly int PLJBLNIOMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float FDDCGNOAHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private OBKDEHDFLJL BODCMEOEMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private JobHandle PFGBAAJBGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private List<MOHJMAPEAFG> INBBCBBBKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool GGPBNJLFBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private List<Action> LMPDKCFPAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private List<Action> CPOMIABBEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private bool IAHDODBKJCA;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public FAGKEAEOCJJ[] BLJDPMOEDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7962E0", Offset = "0x7948E0", VA = "0x1807962E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x555B9A0", Offset = "0x5559FA0", VA = "0x18555B9A0")]
	private static int MEBGPKBIMIP(MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x555CF90", Offset = "0x555B590", VA = "0x18555CF90")]
	public GHONPBCIBMO(MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x555CDA0", Offset = "0x555B3A0", VA = "0x18555CDA0")]
	private void PBGCDICOKIP(ref int NKFGDNONPOH, int ECELDGDOKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x555AD20", Offset = "0x5559320", VA = "0x18555AD20")]
	public void BDAJMIMGMKF(CLNDCOMJDEJ JOOJGLPIMBB, PBBBHKGHFDI MDCOBANIECI, IEnumerator<PBBBHKGHFDI> FHAENLMAGBC, MNIGMFPGMHH KABGCAHOLIL, [Optional] MOHJMAPEAFG LGAANHMELBE, PIMOAFDPPMD NGHPDPLAOKG = PIMOAFDPPMD.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x555B400", Offset = "0x5559A00", VA = "0x18555B400")]
	public void CAMAAPDKPFE(IEnumerable<NGKCAGOKHBM> KOJFCGBHKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x555C5D0", Offset = "0x555ABD0", VA = "0x18555C5D0")]
	private NGKCAGOKHBM OPDJECBBJPP(int DMOKNJMDEDG)
	{
		return default(NGKCAGOKHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x555B9D0", Offset = "0x5559FD0", VA = "0x18555B9D0")]
	private void MKBIJHDEJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x32C1200", Offset = "0x32BF800", VA = "0x1832C1200")]
	private static void KFOPDAOHPJI<T>(int DMOKNJMDEDG, T[] KBOPBPPCPOM, int JLMAIAGOBFJ, [Optional] T POGGLOKDALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x32C11E0", Offset = "0x32BF7E0", VA = "0x1832C11E0")]
	private static void KFOPDAOHPJI<T>(int DMOKNJMDEDG, NativeArray<T> KBOPBPPCPOM, int JLMAIAGOBFJ, [Optional] T POGGLOKDALP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x555AF20", Offset = "0x5559520", VA = "0x18555AF20")]
	private void BKMCABHKOOJ(IEnumerable<NGKCAGOKHBM> KOJFCGBHKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x555B7A0", Offset = "0x5559DA0", VA = "0x18555B7A0")]
	private void IAPPJGHIEDF(NGKCAGOKHBM CCHJOKLPFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x555CAE0", Offset = "0x555B0E0", VA = "0x18555CAE0")]
	private ILDDABJHBPK OPPGLBHIMIJ(int EIGMJAMPPED)
	{
		return default(ILDDABJHBPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x555C3F0", Offset = "0x555A9F0", VA = "0x18555C3F0")]
	public void NICFGPAAKHN(float PBLDCFGNOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x555AEA0", Offset = "0x55594A0", VA = "0x18555AEA0")]
	private void BEFKFFJAKJJ(Action IKAMJBDPPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x555B5F0", Offset = "0x5559BF0", VA = "0x18555B5F0")]
	private void CDJGCFKHOLO(Action IKAMJBDPPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x555BD70", Offset = "0x555A370", VA = "0x18555BD70")]
	public void NCPILDEGNAM(float PBLDCFGNOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x555B300", Offset = "0x5559900", VA = "0x18555B300")]
	public void BOHBKACNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x555B1D0", Offset = "0x55597D0", VA = "0x18555B1D0")]
	public void BMOABCGDMKJ(MOHJMAPEAFG HIIELMICFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x555B670", Offset = "0x5559C70", VA = "0x18555B670")]
	public void DKDNBCMJFNM(MOHJMAPEAFG HIIELMICFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x555B870", Offset = "0x5559E70", VA = "0x18555B870")]
	public void KCONJJFHLJH(MOHJMAPEAFG HIIELMICFPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class POHJKHMBBCM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static readonly POHJKHMBBCM NGOMAJBEGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly Action MHLGMBEKHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool GLPBIJFMILI;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
	public POHJKHMBBCM(Action MHLGMBEKHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x556A130", Offset = "0x5568730", VA = "0x18556A130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface BKJBADPEBEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T OIHHNPGGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable POFJDPCJCNM(UnityEngine.Object JOOJGLPIMBB, Action<T> MKDJKLFIEBH);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface MLENBCGFPNO<T> : global::BKJBADPEBEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T OIHHNPGGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GGIAOELCBNC<T> : global::MLENBCGFPNO<T>, global::BKJBADPEBEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class DHOONAPFIIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public global::GGIAOELCBNC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public global::GEFDKGMPAKE<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public DHOONAPFIIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x341CF50", Offset = "0x341B550", VA = "0x18341CF50")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static GameObject DDDAONNFKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly List<global::GEFDKGMPAKE<UnityEngine.Object, Action<T>>> OFNEIOJHKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private T NMMKKOBNPOD;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T OIHHNPGGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7834A0", Offset = "0x781AA0", VA = "0x1807834A0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x37D2010", Offset = "0x37D0610", VA = "0x1837D2010", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x37D2760", Offset = "0x37D0D60", VA = "0x1837D2760")]
	private static bool GIMOCOEIIFH(T IKAMJBDPPHG, T LKLEFAIICIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x37D2B40", Offset = "0x37D1140", VA = "0x1837D2B40")]
	public GGIAOELCBNC(T DFAFMEDPJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x37D2930", Offset = "0x37D0F30", VA = "0x1837D2930", Slot = "6")]
	public IDisposable POFJDPCJCNM(UnityEngine.Object JOOJGLPIMBB, Action<T> MKDJKLFIEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x37D2070", Offset = "0x37D0670", VA = "0x1837D2070")]
	private void CCJOHHGNBDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class HOLABMEANMO : CDLBFOEHOCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly KGCDBDIBGAO BFOBPCDPEEB;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x555DBD0", Offset = "0x555C1D0", VA = "0x18555DBD0")]
	[PILNOHNDGDF(KBMKLHMPDPB.None)]
	private static void HJAIOHOJGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
	[Preserve]
	internal HOLABMEANMO([KICKHKJFGOO(null)] KGCDBDIBGAO BFOBPCDPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x555DC40", Offset = "0x555C240", VA = "0x18555DC40", Slot = "4")]
	public IDisposable MFMMPBBLOKN(float HJMBIJHLIAC, Action<float> ONHFNOPIIKL, bool CGFBNJGILPC = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct OBKDEHDFLJL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[ReadOnly]
	public float BPGOOIBKFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[ReadOnly]
	public int PHNJKHODKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private NativeArray<int> PIADOGGAJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NativeArray<int> BIDCMFPOHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NativeArray<int> ALMBDAPMDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[ReadOnly]
	public NativeArray<PIMOAFDPPMD> JAGOEAGADFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[ReadOnly]
	public NativeArray<float> JJHFPKHJAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[WriteOnly]
	public NativeArray<int> OHOPHKDMGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[WriteOnly]
	public NativeArray<int> AMFJJGDAOLI;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5568EF0", Offset = "0x55674F0", VA = "0x185568EF0")]
	public static OBKDEHDFLJL CBFHJGEFJHE(int IKKEDAGPBHE, float PBLDCFGNOHJ, NativeArray<PIMOAFDPPMD> KOBENMEDPDK, NativeArray<float> AAPMLBENMGE, NativeArray<int> MPGELLBPIFA, NativeArray<int> AKBBGAONMJL, NativeArray<int> IHPHPABALHO, NativeArray<int> BIDCMFPOHHC, NativeArray<int> ALMBDAPMDEC)
	{
		return default(OBKDEHDFLJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5569180", Offset = "0x5567780", VA = "0x185569180", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x55693C0", Offset = "0x55679C0", VA = "0x1855693C0")]
	private bool OIPONDIPHON(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5569390", Offset = "0x5567990", VA = "0x185569390")]
	private void LFIICJJLKIO(NativeArray<int> CLIBABKADFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5569260", Offset = "0x5567860", VA = "0x185569260")]
	private int FFHFEDMHKAM(int FKCFBOPOBEJ, int PIPGONBPIBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x55692C0", Offset = "0x55678C0", VA = "0x1855692C0")]
	private void KHFNFKJPHGC(NativeArray<int> CLIBABKADFD, int EDNJKCLGGMP, int KNIJILCEPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5568F50", Offset = "0x5567550", VA = "0x185568F50")]
	private void DEMOILGKJFC(NativeArray<int> CLIBABKADFD, int DMMMPIBGENC, int OLDCDLINBPP, int NNEKGNLDNEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class IDEODOAOOHA : NFEEFIEBPCI, KGCDBDIBGAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private GHONPBCIBMO[] NELNNKPKBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private BLPLFNDOFAH MNFOIIIALCI;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x555E650", Offset = "0x555CC50", VA = "0x18555E650")]
	[PILNOHNDGDF(KBMKLHMPDPB.None)]
	private static void HJAIOHOJGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x555E9F0", Offset = "0x555CFF0", VA = "0x18555E9F0")]
	[Preserve]
	public IDEODOAOOHA([KICKHKJFGOO(null)] JCOBEIJLFLN OIGHAAEIDKI, [KICKHKJFGOO(null)] LNEBFMEKLAN MNBFEGECFIK, [KICKHKJFGOO(null)] MHGIPBABGBF NOGOJINIIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x555E1F0", Offset = "0x555C7F0", VA = "0x18555E1F0", Slot = "12")]
	public override PFHLOLIKNNP EDBFINJMIEL(CLNDCOMJDEJ JOOJGLPIMBB, IEnumerator<PBBBHKGHFDI> DPHBBEKEJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x555E370", Offset = "0x555C970", VA = "0x18555E370", Slot = "13")]
	public override void GJKIOCLBKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x555DFA0", Offset = "0x555C5A0", VA = "0x18555DFA0", Slot = "15")]
	public override void AONFMABCECL(MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x555E730", Offset = "0x555CD30", VA = "0x18555E730", Slot = "14")]
	protected override void LJKNPIDDPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x555E330", Offset = "0x555C930", VA = "0x18555E330")]
	private GHONPBCIBMO GDEMCOADJBL(MHOFAIKCPGB.KOLFCAKAGLO MCLMFJEAHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x555E810", Offset = "0x555CE10", VA = "0x18555E810", Slot = "16")]
	internal override NBHNLOFJONK NLADIJCIJHD(IEnumerator<PBBBHKGHFDI> DPHBBEKEJEO, Behaviour JOOJGLPIMBB, MNIGMFPGMHH KABGCAHOLIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x555E6C0", Offset = "0x555CCC0", VA = "0x18555E6C0", Slot = "17")]
	internal override KDCINJGACHH JCMPEPEAEGB(MHOFAIKCPGB.KOLFCAKAGLO OBOHCOMMCNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x555E8C0", Offset = "0x555CEC0", VA = "0x18555E8C0")]
	private void NPIFIIOBFMI(GHONPBCIBMO GJLFNKLPGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x555E180", Offset = "0x555C780", VA = "0x18555E180", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class NFEEFIEBPCI : KGCDBDIBGAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly JCOBEIJLFLN OIGHAAEIDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	protected readonly LNEBFMEKLAN MNBFEGECFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly MHGIPBABGBF NOGOJINIIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private KDCINJGACHH[] GFCKIGMAKFB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static KGCDBDIBGAO LOGBPMLPMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5566F20", Offset = "0x5565520", VA = "0x185566F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static bool MGEAADBCNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MHOFAIKCPGB.KOLFCAKAGLO IOOMAPFJFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x695660", Offset = "0x693C60", VA = "0x180695660", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MHOFAIKCPGB.KOLFCAKAGLO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x709AB0", Offset = "0x7080B0", VA = "0x180709AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LNEBFMEKLAN AECMHKBLDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5567760", Offset = "0x5565D60", VA = "0x185567760")]
	public static PFHLOLIKNNP GLIEOPEGOIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x55678A0", Offset = "0x5565EA0", VA = "0x1855678A0")]
	[Preserve]
	protected NFEEFIEBPCI([KICKHKJFGOO(null)] JCOBEIJLFLN OIGHAAEIDKI, [KICKHKJFGOO(null)] LNEBFMEKLAN MNBFEGECFIK, [KICKHKJFGOO(null)] MHGIPBABGBF NOGOJINIIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5566CE0", Offset = "0x55652E0", VA = "0x185566CE0", Slot = "6")]
	public PFHLOLIKNNP BABMLJMPJCC(IEnumerator<PBBBHKGHFDI> DPHBBEKEJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5566CF0", Offset = "0x55652F0", VA = "0x185566CF0", Slot = "7")]
	public PFHLOLIKNNP BABMLJMPJCC(Behaviour JOOJGLPIMBB, IEnumerator<PBBBHKGHFDI> DPHBBEKEJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract PFHLOLIKNNP EDBFINJMIEL(CLNDCOMJDEJ JOOJGLPIMBB, IEnumerator<PBBBHKGHFDI> DPHBBEKEJEO);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5567580", Offset = "0x5565B80", VA = "0x185567580", Slot = "13")]
	public virtual void GJKIOCLBKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5567180", Offset = "0x5565780", VA = "0x185567180", Slot = "9")]
	public void DOLLKIFOHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5567840", Offset = "0x5565E40", VA = "0x185567840", Slot = "14")]
	protected virtual void LJKNPIDDPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5566F90", Offset = "0x5565590", VA = "0x185566F90")]
	private void CEAGAHDIMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5567820", Offset = "0x5565E20", VA = "0x185567820")]
	private void JGBALHMOEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5567880", Offset = "0x5565E80", VA = "0x185567880")]
	private void MKJLJFAPFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5567860", Offset = "0x5565E60", VA = "0x185567860")]
	private void MFKBPBMEILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5567560", Offset = "0x5565B60", VA = "0x185567560")]
	private void ENJONKICFGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5566F70", Offset = "0x5565570", VA = "0x185566F70")]
	private void BJLIBIFCADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5567800", Offset = "0x5565E00", VA = "0x185567800")]
	private void IKHIFIDLHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5566AA0", Offset = "0x55650A0", VA = "0x185566AA0", Slot = "15")]
	public virtual void AONFMABCECL(MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5566FB0", Offset = "0x55655B0", VA = "0x185566FB0")]
	private void DAIAMPCOLFJ(KDCINJGACHH GJLFNKLPGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x164BE00", Offset = "0x164A400", VA = "0x18164BE00")]
	private KDCINJGACHH CBGEDDCPNNO(MHOFAIKCPGB.KOLFCAKAGLO MCLMFJEAHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract NBHNLOFJONK NLADIJCIJHD(IEnumerator<PBBBHKGHFDI> DPHBBEKEJEO, Behaviour ODGNFNGJPCH, MNIGMFPGMHH LEEAKDBKPKA);

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract KDCINJGACHH JCMPEPEAEGB(MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x55671E0", Offset = "0x55657E0", VA = "0x1855671E0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class NBHNLOFJONK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly MNIGMFPGMHH KABGCAHOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly IENELFHEJAC JOOJGLPIMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly bool OBFGDKLIFPI;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<PBBBHKGHFDI> EJOBLNJCADO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x71E880", Offset = "0x71CE80", VA = "0x18071E880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PBBBHKGHFDI CKGELKGNAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x728F30", Offset = "0x727530", VA = "0x180728F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool HBJKFNKOAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5565DF0", Offset = "0x55643F0", VA = "0x185565DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool OBEAAKCFCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x718160", Offset = "0x716760", VA = "0x180718160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x718180", Offset = "0x716780", VA = "0x180718180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x722690", Offset = "0x720C90", VA = "0x180722690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float MOJMOJILANA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x886E10", Offset = "0x885410", VA = "0x180886E10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1498110", Offset = "0x1496710", VA = "0x181498110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x55661F0", Offset = "0x55647F0", VA = "0x1855661F0")]
	public NBHNLOFJONK(IEnumerator<PBBBHKGHFDI> FHAENLMAGBC, IENELFHEJAC JOOJGLPIMBB, MNIGMFPGMHH KABGCAHOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5565E70", Offset = "0x5564470", VA = "0x185565E70")]
	public PBBBHKGHFDI LKHCGHCLIIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5565D00", Offset = "0x5564300", VA = "0x185565D00")]
	public bool ABNHMMOEEJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5565D70", Offset = "0x5564370", VA = "0x185565D70")]
	public void BMOABCGDMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5566130", Offset = "0x5564730", VA = "0x185566130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2941790", Offset = "0x293FD90", VA = "0x182941790")]
	[CompilerGenerated]
	private void OCPABGLPIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class MNIGMFPGMHH : FPBFHLLAHJO, PFHLOLIKNNP, MBDFLNKMPLG, IGOPHNBFNOE, IEnumerator, PBBBHKGHFDI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private MHOFAIKCPGB.KOLFCAKAGLO FAMJBIDOEKD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private MHOFAIKCPGB.KOLFCAKAGLO NKIPOHNPLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x810290", Offset = "0x80E890", VA = "0x180810290", Slot = "23")]
		get
		{
			return default(MHOFAIKCPGB.KOLFCAKAGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MHOFAIKCPGB.KOLFCAKAGLO JMAFMGEKEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8BB200", Offset = "0x8B9800", VA = "0x1808BB200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float KJONGBFIMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x9FB070", Offset = "0x9F9670", VA = "0x1809FB070", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x55654B0", Offset = "0x5563AB0", VA = "0x1855654B0", Slot = "24")]
	private bool HPEKEMHDMLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x55654A0", Offset = "0x5563AA0", VA = "0x1855654A0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x55654D0", Offset = "0x5563AD0", VA = "0x1855654D0")]
	public MNIGMFPGMHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal enum ILDDABJHBPK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class KDCINJGACHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum JKLAKBOMGON
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct KFPELJLDDAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public MHOFAIKCPGB.KOLFCAKAGLO LFAGOGGJLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public JKLAKBOMGON AKKECNHOOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public List<NBHNLOFJONK> PIICOOJHOOL;
	}

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly JKLAKBOMGON[] AOIAGBFAGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool EEFJOFDKPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly NBHNLOFJONK[] KEEJAOHGBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<NBHNLOFJONK> DNFLIMOCAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Stack<int> KNKNEKPJOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly List<NBHNLOFJONK> EJEPKABOOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Stack<int> PHCECIJIODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly BLPLFNDOFAH OEPIECOLOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private bool IAHDODBKJCA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KFPELJLDDAJ[,] NFDLOOFCLEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x694B00", Offset = "0x693100", VA = "0x180694B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5562150", Offset = "0x5560750", VA = "0x185562150")]
	public KDCINJGACHH(MHOFAIKCPGB.KOLFCAKAGLO OBOHCOMMCNH, BLPLFNDOFAH OEPIECOLOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x55616D0", Offset = "0x555FCD0", VA = "0x1855616D0")]
	public void GOEJPGPIKLK(NBHNLOFJONK FHAENLMAGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5561280", Offset = "0x555F880", VA = "0x185561280")]
	public void EKCLHFOOCGG(IList<NBHNLOFJONK> LCMAJMBHADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5561C70", Offset = "0x5560270", VA = "0x185561C70")]
	public void NMNKLCNEJPM(IList<NBHNLOFJONK> LCMAJMBHADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5561F40", Offset = "0x5560540", VA = "0x185561F40")]
	private void PIFBMNACNLC(NBHNLOFJONK FHAENLMAGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5561550", Offset = "0x555FB50", VA = "0x185561550")]
	private void FKKJIGHCMLB(IList<NBHNLOFJONK> LCMAJMBHADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5560D90", Offset = "0x555F390", VA = "0x185560D90")]
	private ILDDABJHBPK BGKHGNGEKKF(NBHNLOFJONK FHAENLMAGBC)
	{
		return default(ILDDABJHBPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5561B30", Offset = "0x5560130", VA = "0x185561B30")]
	public void LJKNPIDDPEM(float PBLDCFGNOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5560F30", Offset = "0x555F530", VA = "0x185560F30")]
	public void DOLLKIFOHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5561910", Offset = "0x555FF10", VA = "0x185561910")]
	private void LHDEBNPAEDE(List<NBHNLOFJONK> LCMAJMBHADE, Stack<int> HLLBEDPICKP, bool BGLJFFMHGPC, float BDJOGEDLAMK = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5561140", Offset = "0x555F740", VA = "0x185561140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x55617F0", Offset = "0x555FDF0", VA = "0x1855617F0")]
	private void KFABFFEDEIK(List<NBHNLOFJONK> LCMAJMBHADE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class NFLKAKFNPLI : BLPLFNDOFAH
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
	public void HGIEDNINPML(string NBODBMLPNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
	public void IJBLNCKIDAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public NFLKAKFNPLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class JHGCLIFPLNN : IENELFHEJAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Behaviour ODGNFNGJPCH;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x555EC80", Offset = "0x555D280", VA = "0x18555EC80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IAIALDMGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x555EC20", Offset = "0x555D220", VA = "0x18555EC20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool AGNKCFCGOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x555EC00", Offset = "0x555D200", VA = "0x18555EC00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
	public JHGCLIFPLNN(Behaviour ODGNFNGJPCH)
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

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
	[Cpp2IlInjected.Address(RVA = "0x52AE620", Offset = "0x52AD020", VA = "0x1852AE620")]
	public PHLOFEOPBJB(ThreadPriority ICFMBEFAIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x52AE610", Offset = "0x52AD010", VA = "0x1852AE610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x52AE9F0", Offset = "0x52AD3F0", VA = "0x1852AE9F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x52A2210", Offset = "0x52A0C10", VA = "0x1852A2210")]
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
				[Cpp2IlInjected.Address(RVA = "0x52A2030", Offset = "0x52A0A30", VA = "0x1852A2030")]
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
				[Cpp2IlInjected.Address(RVA = "0x52AA510", Offset = "0x52A8F10", VA = "0x1852AA510")]
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
				[Cpp2IlInjected.Address(RVA = "0x5297A20", Offset = "0x5296420", VA = "0x185297A20")]
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
				[Cpp2IlInjected.Address(RVA = "0x52A27B0", Offset = "0x52A11B0", VA = "0x1852A27B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x52AD7B0", Offset = "0x52AC1B0", VA = "0x1852AD7B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x529F550", Offset = "0x529DF50", VA = "0x18529F550")]
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
				[Cpp2IlInjected.Address(RVA = "0x52989C0", Offset = "0x52973C0", VA = "0x1852989C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x52ADEA0", Offset = "0x52AC8A0", VA = "0x1852ADEA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5299010", Offset = "0x5297A10", VA = "0x185299010")]
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
					[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
					public KBFPOIKHCCA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x52A4A40", Offset = "0x52A3440", VA = "0x1852A4A40")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable DKNLFNJKCJE;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x52A4140", Offset = "0x52A2B40", VA = "0x1852A4140")]
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
					[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
					public HCKHOFJBAJK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x52A23F0", Offset = "0x52A0DF0", VA = "0x1852A23F0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x529E000", Offset = "0x529CA00", VA = "0x18529E000")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public CKLMGEPCFKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5299520", Offset = "0x5297F20", VA = "0x185299520")]
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
			[Cpp2IlInjected.Address(RVA = "0x529C640", Offset = "0x529B040", VA = "0x18529C640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x529B710", Offset = "0x529A110", VA = "0x18529B710")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5299870", Offset = "0x5298270", VA = "0x185299870")]
		private static void BIEJIKGIAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x529BA40", Offset = "0x529A440", VA = "0x18529BA40")]
		private static void MLIJPNCIKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x529C310", Offset = "0x529AD10", VA = "0x18529C310")]
		private static void NNELPADLHDB(string GIEANINLCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5299640", Offset = "0x5298040", VA = "0x185299640")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x529B750", Offset = "0x529A150", VA = "0x18529B750")]
		private static void DANOGJONOKC(DCFOKCCEJKL.KHCIJNHJPJK AIGAKEKDKHM, ref PlayerLoopSystem MLCKPMIEFOM, Type PFLJHLPGIOF, Type ELMAGEBOEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x529C680", Offset = "0x529B080", VA = "0x18529C680")]
		private static void PIAIANELFLE(ref PlayerLoopSystem MLCKPMIEFOM, Type PFLJHLPGIOF, Type ELMAGEBOEPD, GGOCBJMNNIH GJPCIAKICEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x529B910", Offset = "0x529A310", VA = "0x18529B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x52A7390", Offset = "0x52A5D90", VA = "0x1852A7390")]
		public KGMJNMKKDFI(KHCIJNHJPJK IGHIKIPKNJF, int AANPJGONDHI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x52A70C0", Offset = "0x52A5AC0", VA = "0x1852A70C0")]
		public void CHPKMIBAFMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x52A7330", Offset = "0x52A5D30", VA = "0x1852A7330")]
		public void FGCKAGLGGPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x52A7130", Offset = "0x52A5B30", VA = "0x1852A7130")]
		public void DBGKOKGBAAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static KHCIJNHJPJK[] KPEOKGJADAP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static KGMJNMKKDFI[] IDFLJIINNCO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x529D2A0", Offset = "0x529BCA0", VA = "0x18529D2A0")]
	public static KGMJNMKKDFI JEPCHLEPEJH(KHCIJNHJPJK AIGAKEKDKHM, int AANPJGONDHI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x529D470", Offset = "0x529BE70", VA = "0x18529D470")]
	public static KGMJNMKKDFI KAMFCPEJJFD(KHCIJNHJPJK AIGAKEKDKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x529D1F0", Offset = "0x529BBF0", VA = "0x18529D1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x529D800", Offset = "0x529C200", VA = "0x18529D800", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x529D860", Offset = "0x529C260", VA = "0x18529D860")]
	public ECGBCGEFHKL(int EKHFOIGILBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x529D6D0", Offset = "0x529C0D0", VA = "0x18529D6D0", Slot = "4")]
	public void KCNELGBFHJA(double PHMPKLAMLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x529D660", Offset = "0x529C060", VA = "0x18529D660", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double EJLJGMIDEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x358EFB0", Offset = "0x358D9B0", VA = "0x18358EFB0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double IOJPOBGMBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA9DE20", Offset = "0xA9C820", VA = "0x180A9DE20", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double INCDFANECPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x32A5420", Offset = "0x32A3E20", VA = "0x1832A5420")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JEOMGLGILCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x358EEE0", Offset = "0x358D8E0", VA = "0x18358EEE0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x529D950", Offset = "0x529C350", VA = "0x18529D950", Slot = "7")]
	public void KCNELGBFHJA(double PHMPKLAMLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x529D910", Offset = "0x529C310", VA = "0x18529D910", Slot = "8")]
	public void GJKIOCLBKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x529DA80", Offset = "0x529C480", VA = "0x18529DA80")]
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
			[Cpp2IlInjected.Address(RVA = "0x2263400", Offset = "0x2261E00", VA = "0x182263400")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IAKIPFHNFNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x22633B0", Offset = "0x2261DB0", VA = "0x1822633B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2263460", Offset = "0x2261E60", VA = "0x182263460")]
		protected LLLNLEGLMDE(TPromise NEGNAEKOKFO, TMainThreadPromise NKHDJPDIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2263380", Offset = "0x2261D80", VA = "0x182263380", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2EAFBB0", Offset = "0x2EAE5B0", VA = "0x182EAFBB0")]
		public MLMHCCBFLOA(global::DIHJKCFGFNO<T> NEGNAEKOKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2EAF9A0", Offset = "0x2EAE3A0", VA = "0x182EAF9A0", Slot = "6")]
		protected override void HBNIPIINENP(global::DIHJKCFGFNO<T> NEGNAEKOKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2EAF970", Offset = "0x2EAE370", VA = "0x182EAF970")]
		[CompilerGenerated]
		private void GJJINNIDHDB(T BIDLMNEFHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x14A6D60", Offset = "0x14A5760", VA = "0x1814A6D60")]
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
			[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696A20", VA = "0x180698020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676940", VA = "0x180677F40")]
		public GBHODKCLEIP(Action PBOHOIMMGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1342BF0", Offset = "0x13415F0", VA = "0x181342BF0", Slot = "5")]
		public void ADFDICGOODJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<GNHLFFLHGGD> LMNPFMCGKCK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22956F0", Offset = "0x22940F0", VA = "0x1822956F0")]
	public static global::DIHJKCFGFNO<T> MCPBIFJAFDA<T>(this global::DIHJKCFGFNO<T> NEGNAEKOKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x52A4630", Offset = "0x52A3030", VA = "0x1852A4630")]
	public static void MCPBIFJAFDA(Action PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2295760", Offset = "0x2294160", VA = "0x182295760")]
	private static global::DIHJKCFGFNO<T> OJPDDDHAAPA<T>(global::DIHJKCFGFNO<T> NEGNAEKOKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x52A46C0", Offset = "0x52A30C0", VA = "0x1852A46C0")]
	private static void NFKEEAJHDKN(GNHLFFLHGGD PEKMEFNFBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x52A4340", Offset = "0x52A2D40", VA = "0x1852A4340")]
	private static void HKLDAGIMMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x52A48C0", Offset = "0x52A32C0", VA = "0x1852A48C0")]
	private static void NNBADIOOCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x52A4270", Offset = "0x52A2C70", VA = "0x1852A4270")]
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
		[Cpp2IlInjected.Address(RVA = "0x52AECF0", Offset = "0x52AD6F0", VA = "0x1852AECF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x52A37B0", Offset = "0x52A21B0", VA = "0x1852A37B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x52A3E20", Offset = "0x52A2820", VA = "0x1852A3E20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x52A5530", Offset = "0x52A3F30", VA = "0x1852A5530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DD20", VA = "0x18067F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x52AE660", Offset = "0x52AD060", VA = "0x1852AE660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DD20", VA = "0x18067F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public CHDGLHFAIOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x52991F0", Offset = "0x5297BF0", VA = "0x1852991F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x529E130", Offset = "0x529CB30", VA = "0x18529E130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x529EAB0", Offset = "0x529D4B0", VA = "0x18529EAB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x52A4CA0", Offset = "0x52A36A0", VA = "0x1852A4CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x52A54E0", Offset = "0x52A3EE0", VA = "0x1852A54E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public HOPPNNCANGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x52A2780", Offset = "0x52A1180", VA = "0x1852A2780")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public BAMALLMECBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5298F00", Offset = "0x5297900", VA = "0x185298F00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5298BA0", Offset = "0x52975A0", VA = "0x185298BA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5298F90", Offset = "0x5297990", VA = "0x185298F90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5298EC0", Offset = "0x52978C0", VA = "0x185298EC0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public NEPIAHAAOFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x52AAFA0", Offset = "0x52A99A0", VA = "0x1852AAFA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x52AB3F0", Offset = "0x52A9DF0", VA = "0x1852AB3F0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x52A82C0", Offset = "0x52A6CC0", VA = "0x1852A82C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool ELHBBJOBOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x52A8AC0", Offset = "0x52A74C0", VA = "0x1852A8AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool OMBJFIHCIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x52A8200", Offset = "0x52A6C00", VA = "0x1852A8200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> EFJAHIPAOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x52A8480", Offset = "0x52A6E80", VA = "0x1852A8480")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x52A89C0", Offset = "0x52A73C0", VA = "0x1852A89C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x52A88F0", Offset = "0x52A72F0", VA = "0x1852A88F0")]
	[IIADNJEBFGG(NKLKDILCDDO.EnteredEditModeNextFrame, 0)]
	private static void DLLGPHMEDNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x52A8650", Offset = "0x52A7050", VA = "0x1852A8650")]
	[AsyncStateMachine(typeof(JMKEIJPBCOO))]
	public static Task<Scene> COFLJINONFP(string NILDNJGDILH, LoadSceneMode OLPMEINLGMG = LoadSceneMode.Single, bool LFOMIKJHJFO = false, [Optional] GPNAMOIINIG POBIKBKNHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x52A8580", Offset = "0x52A6F80", VA = "0x1852A8580")]
	[AsyncStateMachine(typeof(KCFOCPCPKKD))]
	private static Task CKGFHEJIJEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x52A8CD0", Offset = "0x52A76D0", VA = "0x1852A8CD0")]
	[AsyncStateMachine(typeof(PIILBHBPKPE))]
	private static Task LMBFDPBLMPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x52A7DC0", Offset = "0x52A67C0", VA = "0x1852A7DC0")]
	[AsyncStateMachine(typeof(FBNGEOJEGDG))]
	private static Task<Scene> AJIBINHKPJC(string NILDNJGDILH, LoadSceneMode OLPMEINLGMG, bool LFOMIKJHJFO, GPNAMOIINIG AEKLGCBMNDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x52A87B0", Offset = "0x52A71B0", VA = "0x1852A87B0")]
	[AsyncStateMachine(typeof(KCDGNCDEIOF))]
	private static Task<Scene> DGALEELANFI(GPNAMOIINIG AEKLGCBMNDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x52A8EF0", Offset = "0x52A78F0", VA = "0x1852A8EF0")]
	public static global::DIHJKCFGFNO<Scene> PDADAOBLKDG(string NILDNJGDILH, LoadSceneMode OLPMEINLGMG = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x52A7F20", Offset = "0x52A6920", VA = "0x1852A7F20")]
	public static IGOPHNBFNOE BJEICGPGGGA(string NILDNJGDILH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x52A8DC0", Offset = "0x52A77C0", VA = "0x1852A8DC0")]
	[IteratorStateMachine(typeof(BAMALLMECBG))]
	private static IEnumerator<PBBBHKGHFDI> NEGONDBLOMP(string NILDNJGDILH, EONHFJBEBFJ ILDFBDKJCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x52A8E50", Offset = "0x52A7850", VA = "0x1852A8E50")]
	[IteratorStateMachine(typeof(NEPIAHAAOFD))]
	private static IEnumerator<PBBBHKGHFDI> OECEEJIKEMN(string NILDNJGDILH, LoadSceneMode OLPMEINLGMG, global::HCPAFFBNPPI<Scene> ILDFBDKJCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x52A8B70", Offset = "0x52A7570", VA = "0x1852A8B70")]
	public static bool JKDLPEELDJE(out string EJMMBGPNEEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GAAHKNNALDC
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x529F3D0", Offset = "0x529DDD0", VA = "0x18529F3D0")]
	public static IDisposable JLPMEINGILD(this CLNDCOMJDEJ JOOJGLPIMBB, float HJMBIJHLIAC, Action<float> JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x529F450", Offset = "0x529DE50", VA = "0x18529F450")]
	public static IDisposable KLCDDPPJDHD(this CLNDCOMJDEJ JOOJGLPIMBB, Action<float> JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x529F4D0", Offset = "0x529DED0", VA = "0x18529F4D0")]
	public static IDisposable OPJJJFFFEDL(this CLNDCOMJDEJ JOOJGLPIMBB, Action<float> JDEFICMNKIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class AKJKCBPLNCN
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5298120", Offset = "0x5296B20", VA = "0x185298120")]
	public static IDisposable DAKOOMPABPM(this MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x52981A0", Offset = "0x5296BA0", VA = "0x1852981A0")]
	public static IDisposable DAKOOMPABPM(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5298450", Offset = "0x5296E50", VA = "0x185298450")]
	public static IDisposable LJKNPIDDPEM(this MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5298700", Offset = "0x5297100", VA = "0x185298700")]
	public static IDisposable MKJLJFAPFNF(this MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x52985E0", Offset = "0x5296FE0", VA = "0x1852985E0")]
	public static IDisposable MFKBPBMEILP(this MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5298940", Offset = "0x5297340", VA = "0x185298940")]
	public static IDisposable PADJFMGMJLG(this MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x52982B0", Offset = "0x5296CB0", VA = "0x1852982B0")]
	public static IDisposable FBMFPGJNNGL(this MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5298810", Offset = "0x5297210", VA = "0x185298810")]
	public static IDisposable OBFAOPIKFBP(this MonoBehaviour ODGNFNGJPCH, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5298660", Offset = "0x5297060", VA = "0x185298660")]
	public static IDisposable MFMMPBBLOKN(this MonoBehaviour ODGNFNGJPCH, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5298550", Offset = "0x5296F50", VA = "0x185298550")]
	public static IDisposable LOIHDHIDHAJ(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5297FF0", Offset = "0x52969F0", VA = "0x185297FF0")]
	public static IDisposable AKIBHPOGGPB(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5298330", Offset = "0x5296D30", VA = "0x185298330")]
	public static IDisposable FGDCODGPBML(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x52984C0", Offset = "0x5296EC0", VA = "0x1852984C0")]
	public static IDisposable LNKDMLFJIKA(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x52983C0", Offset = "0x5296DC0", VA = "0x1852983C0")]
	public static IDisposable JLFGFNMFACC(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5298780", Offset = "0x5297180", VA = "0x185298780")]
	public static IDisposable NEPBGPILGII(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5298220", Offset = "0x5296C20", VA = "0x185298220")]
	public static IDisposable DMMAMMJJECL(this MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5298080", Offset = "0x5296A80", VA = "0x185298080")]
	public static IDisposable CHBOCHOOFOM(this MonoBehaviour ODGNFNGJPCH, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, bool CGFBNJGILPC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x52988B0", Offset = "0x52972B0", VA = "0x1852988B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public IGFBPPPFEGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x52A3560", Offset = "0x52A1F60", VA = "0x1852A3560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x52A3620", Offset = "0x52A2020", VA = "0x1852A3620", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public OFHBMPPGCLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x52AE080", Offset = "0x52ACA80", VA = "0x1852AE080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x52AE170", Offset = "0x52ACB70", VA = "0x1852AE170", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5297C00", Offset = "0x5296600", VA = "0x185297C00")]
	public static PFHLOLIKNNP DAKOOMPABPM(Action JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5297D20", Offset = "0x5296720", VA = "0x185297D20")]
	public static PFHLOLIKNNP DAKOOMPABPM(Behaviour JOOJGLPIMBB, Action JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5297DE0", Offset = "0x52967E0", VA = "0x185297DE0")]
	public static PFHLOLIKNNP DAKOOMPABPM(Behaviour JOOJGLPIMBB, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5297EF0", Offset = "0x52968F0", VA = "0x185297EF0")]
	[IteratorStateMachine(typeof(IGFBPPPFEGA))]
	private static IEnumerator<PBBBHKGHFDI> POIMJACBGDI(MHOFAIKCPGB.KOLFCAKAGLO OBOHCOMMCNH, Action JDEFICMNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5297F70", Offset = "0x5296970", VA = "0x185297F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public OGPHPCNBNLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x52AE1B0", Offset = "0x52ACBB0", VA = "0x1852AE1B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x52AE2F0", Offset = "0x52ACCF0", VA = "0x1852AE2F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5299250", Offset = "0x5297C50", VA = "0x185299250")]
	public static PFHLOLIKNNP DAKOOMPABPM(MonoBehaviour ODGNFNGJPCH, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, bool CGFBNJGILPC = true, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5299360", Offset = "0x5297D60", VA = "0x185299360")]
	public static PFHLOLIKNNP FFKHDJLKAMJ(CLNDCOMJDEJ JOOJGLPIMBB, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, bool CGFBNJGILPC = true, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5299470", Offset = "0x5297E70", VA = "0x185299470")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public NCEIMNHCHPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x52AAEB0", Offset = "0x52A98B0", VA = "0x1852AAEB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x52AAF60", Offset = "0x52A9960", VA = "0x1852AAF60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x52AD620", Offset = "0x52AC020", VA = "0x1852AD620")]
	[IteratorStateMachine(typeof(NCEIMNHCHPI))]
	private static IEnumerator<PBBBHKGHFDI> JEJPCAKOMBC(MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, Func<bool> NGDPMIDAOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x52AD6A0", Offset = "0x52AC0A0", VA = "0x1852AD6A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public FCEICEDPKCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x529EB00", Offset = "0x529D500", VA = "0x18529EB00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x529EBC0", Offset = "0x529D5C0", VA = "0x18529EBC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x529F040", Offset = "0x529DA40", VA = "0x18529F040")]
	[IteratorStateMachine(typeof(FCEICEDPKCE))]
	private static IEnumerator<PBBBHKGHFDI> JGLOMNMHEHC(float HPFCHMNJJNH, MHOFAIKCPGB.KOLFCAKAGLO OBOHCOMMCNH, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x529EE80", Offset = "0x529D880", VA = "0x18529EE80")]
	public static PFHLOLIKNNP GLOAKIPJOIH(this MonoBehaviour ODGNFNGJPCH, float HPFCHMNJJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x529EE60", Offset = "0x529D860", VA = "0x18529EE60")]
	public static PFHLOLIKNNP EMGLHOBDMKK(this MonoBehaviour ODGNFNGJPCH, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x529F2A0", Offset = "0x529DCA0", VA = "0x18529F2A0")]
	public static PFHLOLIKNNP MIKHBGGKLEA(this MonoBehaviour ODGNFNGJPCH, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x529ECB0", Offset = "0x529D6B0", VA = "0x18529ECB0")]
	public static PFHLOLIKNNP DAIMLEJNMHM(this MonoBehaviour ODGNFNGJPCH, Action FIFMLJNEANH, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x529F3A0", Offset = "0x529DDA0", VA = "0x18529F3A0")]
	public static PFHLOLIKNNP MPJNOLCMKLM(this MonoBehaviour ODGNFNGJPCH, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x529F010", Offset = "0x529DA10", VA = "0x18529F010")]
	public static PFHLOLIKNNP JDDFFMCGPBB(this MonoBehaviour ODGNFNGJPCH, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x529F270", Offset = "0x529DC70", VA = "0x18529F270")]
	public static PFHLOLIKNNP MBOEGKCHMFG(this MonoBehaviour ODGNFNGJPCH, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x529F1A0", Offset = "0x529DBA0", VA = "0x18529F1A0")]
	private static PFHLOLIKNNP LEIHDKHALJI(MonoBehaviour ODGNFNGJPCH, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, Action FIFMLJNEANH, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x529F2D0", Offset = "0x529DCD0", VA = "0x18529F2D0")]
	public static PFHLOLIKNNP MLDDEOPGHMM(this MonoBehaviour ODGNFNGJPCH, float KPAJFKNBMOD, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x529F0D0", Offset = "0x529DAD0", VA = "0x18529F0D0")]
	public static PFHLOLIKNNP LCFLBIJHAMK(this MonoBehaviour ODGNFNGJPCH, float KPAJFKNBMOD, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x529EF40", Offset = "0x529D940", VA = "0x18529EF40")]
	public static PFHLOLIKNNP GMIPAKPOMLL(this MonoBehaviour ODGNFNGJPCH, float KPAJFKNBMOD, Action FIFMLJNEANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x529ED90", Offset = "0x529D790", VA = "0x18529ED90")]
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
		[Cpp2IlInjected.Address(RVA = "0x52A7510", Offset = "0x52A5F10", VA = "0x1852A7510", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PPHMJFCAAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x52A7AB0", Offset = "0x52A64B0", VA = "0x1852A7AB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x52A7B50", Offset = "0x52A6550", VA = "0x1852A7B50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x52A7D20", Offset = "0x52A6720", VA = "0x1852A7D20")]
	public KIFKPPLLGPN([Optional] Action OIBMCKPPBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x52A7BF0", Offset = "0x52A65F0", VA = "0x1852A7BF0")]
	public void MFMCNFFMIAP(DDGADFNBJEA AEEHGLPNAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x52A7940", Offset = "0x52A6340", VA = "0x1852A7940")]
	private void JENICKDDBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x52A7930", Offset = "0x52A6330", VA = "0x1852A7930", Slot = "7")]
	public bool IBOACONOGAB(bool CBEIFKNKIIE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x52A7650", Offset = "0x52A6050", VA = "0x1852A7650", Slot = "8")]
	public bool IBOACONOGAB(Action PBOHOIMMGFG, bool CBEIFKNKIIE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x52A7490", Offset = "0x52A5E90", VA = "0x1852A7490", Slot = "9")]
	public IEnumerator<DDGADFNBJEA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x52A7490", Offset = "0x52A5E90", VA = "0x1852A7490", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public BDIEEIENHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5298FE0", Offset = "0x52979E0", VA = "0x185298FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public JKBBKMAINPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5298FE0", Offset = "0x52979E0", VA = "0x185298FE0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly float HDBAHOEEOEG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5297920", Offset = "0x5296320", VA = "0x185297920")]
	public PANOLDNAHHM(Behaviour JOOJGLPIMBB, float HDBAHOEEOEG, [Optional] Action OIBMCKPPBPB, [Optional] KGCDBDIBGAO BFOBPCDPEEB, [Optional] LNEBFMEKLAN MNBFEGECFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x52AE410", Offset = "0x52ACE10", VA = "0x1852AE410", Slot = "9")]
	protected override bool APBJMHMCEDD(Action PBOHOIMMGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x52AE510", Offset = "0x52ACF10", VA = "0x1852AE510", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public NFCINBGNKHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x52AB430", Offset = "0x52A9E30", VA = "0x1852AB430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x52AB500", Offset = "0x52A9F00", VA = "0x1852AB500", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8910", Offset = "0x6C7310", VA = "0x1806C8910", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action PPHMJFCAAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x52A9A80", Offset = "0x52A8480", VA = "0x1852A9A80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x52A9D60", Offset = "0x52A8760", VA = "0x1852A9D60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x52A9E00", Offset = "0x52A8800", VA = "0x1852A9E00")]
	protected MALPHHCJNOE(Behaviour JOOJGLPIMBB, [Optional] Action OIBMCKPPBPB, [Optional] KGCDBDIBGAO BFOBPCDPEEB, [Optional] LNEBFMEKLAN MNBFEGECFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x52A99B0", Offset = "0x52A83B0", VA = "0x1852A99B0", Slot = "7")]
	public bool IBOACONOGAB(bool CBEIFKNKIIE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x52A9A10", Offset = "0x52A8410", VA = "0x1852A9A10", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x52A9A60", Offset = "0x52A8460", VA = "0x1852A9A60")]
	protected void JDFNEPJFBCC(Action PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x52A9B20", Offset = "0x52A8520", VA = "0x1852A9B20")]
	protected IGOPHNBFNOE JNHIOKCDBAM(float OLGHJNFBDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x52A98B0", Offset = "0x52A82B0", VA = "0x1852A98B0")]
	private void FBLBHFELLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x52A9930", Offset = "0x52A8330", VA = "0x1852A9930")]
	[IteratorStateMachine(typeof(NFCINBGNKHE))]
	private IEnumerator<PBBBHKGHFDI> HFDOGELEFJI(float OLGHJNFBDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x52A9D20", Offset = "0x52A8720", VA = "0x1852A9D20")]
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
	[Cpp2IlInjected.Address(RVA = "0x529DE50", Offset = "0x529C850", VA = "0x18529DE50")]
	public EKLKECFANDG(Behaviour JOOJGLPIMBB, float BKJBDGDDNGF, int LPCJGLIPHMD, [Optional] Action OIBMCKPPBPB, float ADFAOEGMADM = 0f, [Optional] KGCDBDIBGAO BFOBPCDPEEB, [Optional] LNEBFMEKLAN MNBFEGECFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "9")]
	protected override bool APBJMHMCEDD(Action PBOHOIMMGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x529DC20", Offset = "0x529C620", VA = "0x18529DC20", Slot = "10")]
	protected override bool LPMJKMGFAHM(Action PBOHOIMMGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x529DB90", Offset = "0x529C590", VA = "0x18529DB90")]
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
	[Cpp2IlInjected.Address(RVA = "0x5297920", Offset = "0x5296320", VA = "0x185297920")]
	public ADDEAEGDLPH(Behaviour JOOJGLPIMBB, float HDBAHOEEOEG, [Optional] Action OIBMCKPPBPB, [Optional] KGCDBDIBGAO BFOBPCDPEEB, [Optional] LNEBFMEKLAN MNBFEGECFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "9")]
	protected override bool APBJMHMCEDD(Action PBOHOIMMGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x52978E0", Offset = "0x52962E0", VA = "0x1852978E0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public ONGCPBGLEJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x52AE330", Offset = "0x52ACD30", VA = "0x1852AE330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x52AE3D0", Offset = "0x52ACDD0", VA = "0x1852AE3D0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x529D000", Offset = "0x529BA00", VA = "0x18529D000")]
	public DANOCJHHGHF(CLNDCOMJDEJ JOOJGLPIMBB, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x529CAD0", Offset = "0x529B4D0", VA = "0x18529CAD0")]
	private void GIHBOGOILJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x529CCF0", Offset = "0x529B6F0", VA = "0x18529CCF0")]
	private void MMHIFFCFPII(string OOMNIJBIFDC, Action COFOLKDPBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x529CC80", Offset = "0x529B680", VA = "0x18529CC80")]
	[IteratorStateMachine(typeof(ONGCPBGLEJK))]
	private IEnumerator<PBBBHKGHFDI> KOAIBEDHDAN(Action COFOLKDPBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x529CA70", Offset = "0x529B470", VA = "0x18529CA70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x529CE50", Offset = "0x529B850", VA = "0x18529CE50")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public EILOAMHAKFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x529DAB0", Offset = "0x529C4B0", VA = "0x18529DAB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x529DB50", Offset = "0x529C550", VA = "0x18529DB50", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x52ACF80", Offset = "0x52AB980", VA = "0x1852ACF80")]
	public NHLPGIIMOAJ(MonoBehaviour ODGNFNGJPCH, Action JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x52AD3E0", Offset = "0x52ABDE0", VA = "0x1852AD3E0")]
	public NHLPGIIMOAJ(MonoBehaviour ODGNFNGJPCH, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x52AD180", Offset = "0x52ABB80", VA = "0x1852AD180")]
	public NHLPGIIMOAJ(MonoBehaviour ODGNFNGJPCH, float HJMBIJHLIAC, Action<float> JDEFICMNKIF, MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD, bool CGFBNJGILPC = true, [Optional] KGCDBDIBGAO BFOBPCDPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x52AC930", Offset = "0x52AB330", VA = "0x1852AC930")]
	private void DAKOOMPABPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x52AC780", Offset = "0x52AB180", VA = "0x1852AC780")]
	private void CPAGJNLDGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x52ACB90", Offset = "0x52AB590", VA = "0x1852ACB90")]
	private void GIHBOGOILJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x52ACE50", Offset = "0x52AB850", VA = "0x1852ACE50")]
	private void MMHIFFCFPII(string OOMNIJBIFDC, Action COFOLKDPBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x52ACD50", Offset = "0x52AB750", VA = "0x1852ACD50")]
	[IteratorStateMachine(typeof(EILOAMHAKFE))]
	private IEnumerator<PBBBHKGHFDI> KOAIBEDHDAN(Action COFOLKDPBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x52ACB30", Offset = "0x52AB530", VA = "0x1852ACB30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x52ACDC0", Offset = "0x52AB7C0", VA = "0x1852ACDC0")]
	[CompilerGenerated]
	private void LEFGHIHAHMC(string CNABBHHIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x52ACAA0", Offset = "0x52AB4A0", VA = "0x1852ACAA0")]
	[CompilerGenerated]
	private void DAPECJPJBJE(string CNABBHHIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x52AC6F0", Offset = "0x52AB0F0", VA = "0x1852AC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x529ECA0", Offset = "0x529D6A0", VA = "0x18529ECA0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float LEEHLJLBPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x529EC90", Offset = "0x529D690", VA = "0x18529EC90", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public double CEKALADGLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x529EC00", Offset = "0x529D600", VA = "0x18529EC00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x529EC20", Offset = "0x529D620", VA = "0x18529EC20")]
	[PILNOHNDGDF(KBMKLHMPDPB.None)]
	private static void HJAIOHOJGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675A40", VA = "0x180677040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x697F30", Offset = "0x696930", VA = "0x180697F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x52AA140", Offset = "0x52A8B40", VA = "0x1852AA140")]
	public static PBBBHKGHFDI LKHCGHCLIIO(IEnumerator<PBBBHKGHFDI> FHAENLMAGBC, MNIGMFPGMHH KABGCAHOLIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x52AA2F0", Offset = "0x52A8CF0", VA = "0x1852AA2F0")]
	public PBBBHKGHFDI LKHCGHCLIIO(MNIGMFPGMHH[] MHFCMKLHCIN, IEnumerator<PBBBHKGHFDI>[] LCMAJMBHADE, PBBBHKGHFDI[] KPAKLCMGIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x52A9FD0", Offset = "0x52A89D0", VA = "0x1852A9FD0")]
	public void EKEMMBCNMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x52AA000", Offset = "0x52A8A00", VA = "0x1852AA000")]
	public void LCAEAOAKCJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x52AA3D0", Offset = "0x52A8DD0", VA = "0x1852AA3D0")]
	public void PCLOHHPFCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x52A9FD0", Offset = "0x52A89D0", VA = "0x1852A9FD0")]
	public void BMOABCGDMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public LDDDIIDKCAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x52A9150", Offset = "0x52A7B50", VA = "0x1852A9150")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public MKGFEEDDKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x52A9F00", Offset = "0x52A8900", VA = "0x1852A9F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public LHGMJAKEIPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x52A9870", Offset = "0x52A8270", VA = "0x1852A9870")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public INCACAAMMBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x52A3660", Offset = "0x52A2060", VA = "0x1852A3660")]
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
		[Cpp2IlInjected.Address(RVA = "0xFC3410", Offset = "0xFC1E10", VA = "0x180FC3410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x52A0440", Offset = "0x529EE40", VA = "0x1852A0440")]
	private static int MEBGPKBIMIP(MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x52A1A30", Offset = "0x52A0430", VA = "0x1852A1A30")]
	public GHONPBCIBMO(MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x52A1840", Offset = "0x52A0240", VA = "0x1852A1840")]
	private void PBGCDICOKIP(ref int NKFGDNONPOH, int ECELDGDOKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x529F7C0", Offset = "0x529E1C0", VA = "0x18529F7C0")]
	public void BDAJMIMGMKF(CLNDCOMJDEJ JOOJGLPIMBB, PBBBHKGHFDI MDCOBANIECI, IEnumerator<PBBBHKGHFDI> FHAENLMAGBC, MNIGMFPGMHH KABGCAHOLIL, [Optional] MOHJMAPEAFG LGAANHMELBE, PIMOAFDPPMD NGHPDPLAOKG = PIMOAFDPPMD.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x529FEA0", Offset = "0x529E8A0", VA = "0x18529FEA0")]
	public void CAMAAPDKPFE(IEnumerable<NGKCAGOKHBM> KOJFCGBHKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x52A1070", Offset = "0x529FA70", VA = "0x1852A1070")]
	private NGKCAGOKHBM OPDJECBBJPP(int DMOKNJMDEDG)
	{
		return default(NGKCAGOKHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x52A0470", Offset = "0x529EE70", VA = "0x1852A0470")]
	private void MKBIJHDEJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x24F29E0", Offset = "0x24F13E0", VA = "0x1824F29E0")]
	private static void KFOPDAOHPJI<T>(int DMOKNJMDEDG, T[] KBOPBPPCPOM, int JLMAIAGOBFJ, [Optional] T POGGLOKDALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x24F29C0", Offset = "0x24F13C0", VA = "0x1824F29C0")]
	private static void KFOPDAOHPJI<T>(int DMOKNJMDEDG, NativeArray<T> KBOPBPPCPOM, int JLMAIAGOBFJ, [Optional] T POGGLOKDALP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x529F9C0", Offset = "0x529E3C0", VA = "0x18529F9C0")]
	private void BKMCABHKOOJ(IEnumerable<NGKCAGOKHBM> KOJFCGBHKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x52A0240", Offset = "0x529EC40", VA = "0x1852A0240")]
	private void IAPPJGHIEDF(NGKCAGOKHBM CCHJOKLPFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x52A1580", Offset = "0x529FF80", VA = "0x1852A1580")]
	private ILDDABJHBPK OPPGLBHIMIJ(int EIGMJAMPPED)
	{
		return default(ILDDABJHBPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x52A0E90", Offset = "0x529F890", VA = "0x1852A0E90")]
	public void NICFGPAAKHN(float PBLDCFGNOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x529F940", Offset = "0x529E340", VA = "0x18529F940")]
	private void BEFKFFJAKJJ(Action IKAMJBDPPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x52A0090", Offset = "0x529EA90", VA = "0x1852A0090")]
	private void CDJGCFKHOLO(Action IKAMJBDPPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x52A0810", Offset = "0x529F210", VA = "0x1852A0810")]
	public void NCPILDEGNAM(float PBLDCFGNOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x529FDA0", Offset = "0x529E7A0", VA = "0x18529FDA0")]
	public void BOHBKACNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x529FC70", Offset = "0x529E670", VA = "0x18529FC70")]
	public void BMOABCGDMKJ(MOHJMAPEAFG HIIELMICFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x52A0110", Offset = "0x529EB10", VA = "0x1852A0110")]
	public void DKDNBCMJFNM(MOHJMAPEAFG HIIELMICFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x52A0310", Offset = "0x529ED10", VA = "0x1852A0310")]
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
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676940", VA = "0x180677F40")]
	public POHJKHMBBCM(Action MHLGMBEKHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x52AEBD0", Offset = "0x52AD5D0", VA = "0x1852AEBD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public DHOONAPFIIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x264EAD0", Offset = "0x264D4D0", VA = "0x18264EAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6902D0", VA = "0x1806918D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2A76F80", Offset = "0x2A75980", VA = "0x182A76F80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2A776D0", Offset = "0x2A760D0", VA = "0x182A776D0")]
	private static bool GIMOCOEIIFH(T IKAMJBDPPHG, T LKLEFAIICIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2A77AB0", Offset = "0x2A764B0", VA = "0x182A77AB0")]
	public GGIAOELCBNC(T DFAFMEDPJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2A778A0", Offset = "0x2A762A0", VA = "0x182A778A0", Slot = "6")]
	public IDisposable POFJDPCJCNM(UnityEngine.Object JOOJGLPIMBB, Action<T> MKDJKLFIEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2A76FE0", Offset = "0x2A759E0", VA = "0x182A76FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x52A2670", Offset = "0x52A1070", VA = "0x1852A2670")]
	[PILNOHNDGDF(KBMKLHMPDPB.None)]
	private static void HJAIOHOJGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676940", VA = "0x180677F40")]
	[Preserve]
	internal HOLABMEANMO([KICKHKJFGOO(null)] KGCDBDIBGAO BFOBPCDPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x52A26E0", Offset = "0x52A10E0", VA = "0x1852A26E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x52AD990", Offset = "0x52AC390", VA = "0x1852AD990")]
	public static OBKDEHDFLJL CBFHJGEFJHE(int IKKEDAGPBHE, float PBLDCFGNOHJ, NativeArray<PIMOAFDPPMD> KOBENMEDPDK, NativeArray<float> AAPMLBENMGE, NativeArray<int> MPGELLBPIFA, NativeArray<int> AKBBGAONMJL, NativeArray<int> IHPHPABALHO, NativeArray<int> BIDCMFPOHHC, NativeArray<int> ALMBDAPMDEC)
	{
		return default(OBKDEHDFLJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x52ADC20", Offset = "0x52AC620", VA = "0x1852ADC20", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x52ADE60", Offset = "0x52AC860", VA = "0x1852ADE60")]
	private bool OIPONDIPHON(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x52ADE30", Offset = "0x52AC830", VA = "0x1852ADE30")]
	private void LFIICJJLKIO(NativeArray<int> CLIBABKADFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x52ADD00", Offset = "0x52AC700", VA = "0x1852ADD00")]
	private int FFHFEDMHKAM(int FKCFBOPOBEJ, int PIPGONBPIBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x52ADD60", Offset = "0x52AC760", VA = "0x1852ADD60")]
	private void KHFNFKJPHGC(NativeArray<int> CLIBABKADFD, int EDNJKCLGGMP, int KNIJILCEPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x52AD9F0", Offset = "0x52AC3F0", VA = "0x1852AD9F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x52A30F0", Offset = "0x52A1AF0", VA = "0x1852A30F0")]
	[PILNOHNDGDF(KBMKLHMPDPB.None)]
	private static void HJAIOHOJGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x52A3490", Offset = "0x52A1E90", VA = "0x1852A3490")]
	[Preserve]
	public IDEODOAOOHA([KICKHKJFGOO(null)] JCOBEIJLFLN OIGHAAEIDKI, [KICKHKJFGOO(null)] LNEBFMEKLAN MNBFEGECFIK, [KICKHKJFGOO(null)] MHGIPBABGBF NOGOJINIIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x52A2C90", Offset = "0x52A1690", VA = "0x1852A2C90", Slot = "12")]
	public override PFHLOLIKNNP EDBFINJMIEL(CLNDCOMJDEJ JOOJGLPIMBB, IEnumerator<PBBBHKGHFDI> DPHBBEKEJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x52A2E10", Offset = "0x52A1810", VA = "0x1852A2E10", Slot = "13")]
	public override void GJKIOCLBKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x52A2A40", Offset = "0x52A1440", VA = "0x1852A2A40", Slot = "15")]
	public override void AONFMABCECL(MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x52A31D0", Offset = "0x52A1BD0", VA = "0x1852A31D0", Slot = "14")]
	protected override void LJKNPIDDPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x52A2DD0", Offset = "0x52A17D0", VA = "0x1852A2DD0")]
	private GHONPBCIBMO GDEMCOADJBL(MHOFAIKCPGB.KOLFCAKAGLO MCLMFJEAHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x52A32B0", Offset = "0x52A1CB0", VA = "0x1852A32B0", Slot = "16")]
	internal override NBHNLOFJONK NLADIJCIJHD(IEnumerator<PBBBHKGHFDI> DPHBBEKEJEO, Behaviour JOOJGLPIMBB, MNIGMFPGMHH KABGCAHOLIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x52A3160", Offset = "0x52A1B60", VA = "0x1852A3160", Slot = "17")]
	internal override KDCINJGACHH JCMPEPEAEGB(MHOFAIKCPGB.KOLFCAKAGLO OBOHCOMMCNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x52A3360", Offset = "0x52A1D60", VA = "0x1852A3360")]
	private void NPIFIIOBFMI(GHONPBCIBMO GJLFNKLPGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x52A2C20", Offset = "0x52A1620", VA = "0x1852A2C20", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x52AB9C0", Offset = "0x52AA3C0", VA = "0x1852AB9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static bool MGEAADBCNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696A20", VA = "0x180698020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MHOFAIKCPGB.KOLFCAKAGLO IOOMAPFJFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675A40", VA = "0x180677040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MHOFAIKCPGB.KOLFCAKAGLO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x697F30", Offset = "0x696930", VA = "0x180697F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LNEBFMEKLAN AECMHKBLDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x52AC200", Offset = "0x52AAC00", VA = "0x1852AC200")]
	public static PFHLOLIKNNP GLIEOPEGOIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x52AC340", Offset = "0x52AAD40", VA = "0x1852AC340")]
	[Preserve]
	protected NFEEFIEBPCI([KICKHKJFGOO(null)] JCOBEIJLFLN OIGHAAEIDKI, [KICKHKJFGOO(null)] LNEBFMEKLAN MNBFEGECFIK, [KICKHKJFGOO(null)] MHGIPBABGBF NOGOJINIIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x52AB780", Offset = "0x52AA180", VA = "0x1852AB780", Slot = "6")]
	public PFHLOLIKNNP BABMLJMPJCC(IEnumerator<PBBBHKGHFDI> DPHBBEKEJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x52AB790", Offset = "0x52AA190", VA = "0x1852AB790", Slot = "7")]
	public PFHLOLIKNNP BABMLJMPJCC(Behaviour JOOJGLPIMBB, IEnumerator<PBBBHKGHFDI> DPHBBEKEJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract PFHLOLIKNNP EDBFINJMIEL(CLNDCOMJDEJ JOOJGLPIMBB, IEnumerator<PBBBHKGHFDI> DPHBBEKEJEO);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x52AC020", Offset = "0x52AAA20", VA = "0x1852AC020", Slot = "13")]
	public virtual void GJKIOCLBKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x52ABC20", Offset = "0x52AA620", VA = "0x1852ABC20", Slot = "9")]
	public void DOLLKIFOHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x52AC2E0", Offset = "0x52AACE0", VA = "0x1852AC2E0", Slot = "14")]
	protected virtual void LJKNPIDDPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x52ABA30", Offset = "0x52AA430", VA = "0x1852ABA30")]
	private void CEAGAHDIMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x52AC2C0", Offset = "0x52AACC0", VA = "0x1852AC2C0")]
	private void JGBALHMOEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x52AC320", Offset = "0x52AAD20", VA = "0x1852AC320")]
	private void MKJLJFAPFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x52AC300", Offset = "0x52AAD00", VA = "0x1852AC300")]
	private void MFKBPBMEILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x52AC000", Offset = "0x52AAA00", VA = "0x1852AC000")]
	private void ENJONKICFGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x52ABA10", Offset = "0x52AA410", VA = "0x1852ABA10")]
	private void BJLIBIFCADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x52AC2A0", Offset = "0x52AACA0", VA = "0x1852AC2A0")]
	private void IKHIFIDLHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x52AB540", Offset = "0x52A9F40", VA = "0x1852AB540", Slot = "15")]
	public virtual void AONFMABCECL(MHOFAIKCPGB.KOLFCAKAGLO OIFKONGDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x52ABA50", Offset = "0x52AA450", VA = "0x1852ABA50")]
	private void DAIAMPCOLFJ(KDCINJGACHH GJLFNKLPGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0xC08C80", Offset = "0xC07680", VA = "0x180C08C80")]
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
	[Cpp2IlInjected.Address(RVA = "0x52ABC80", Offset = "0x52AA680", VA = "0x1852ABC80", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695B30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PBBBHKGHFDI CKGELKGNAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695B40", VA = "0x180697140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool HBJKFNKOAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x52AA890", Offset = "0x52A9290", VA = "0x1852AA890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool OBEAAKCFCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8732B0", Offset = "0x871CB0", VA = "0x1808732B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8126F0", Offset = "0x8110F0", VA = "0x1808126F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67CF70", VA = "0x18067E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x67E590", Offset = "0x67CF90", VA = "0x18067E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float MOJMOJILANA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x107D080", Offset = "0x107BA80", VA = "0x18107D080")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x107CF50", Offset = "0x107B950", VA = "0x18107CF50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x52AAC90", Offset = "0x52A9690", VA = "0x1852AAC90")]
	public NBHNLOFJONK(IEnumerator<PBBBHKGHFDI> FHAENLMAGBC, IENELFHEJAC JOOJGLPIMBB, MNIGMFPGMHH KABGCAHOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x52AA910", Offset = "0x52A9310", VA = "0x1852AA910")]
	public PBBBHKGHFDI LKHCGHCLIIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x52AA7A0", Offset = "0x52A91A0", VA = "0x1852AA7A0")]
	public bool ABNHMMOEEJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x52AA810", Offset = "0x52A9210", VA = "0x1852AA810")]
	public void BMOABCGDMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x52AABD0", Offset = "0x52A95D0", VA = "0x1852AABD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1B50410", Offset = "0x1B4EE10", VA = "0x181B50410")]
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
		[Cpp2IlInjected.Address(RVA = "0x71B510", Offset = "0x719F10", VA = "0x18071B510", Slot = "23")]
		get
		{
			return default(MHOFAIKCPGB.KOLFCAKAGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MHOFAIKCPGB.KOLFCAKAGLO JMAFMGEKEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x81CB40", Offset = "0x81B540", VA = "0x18081CB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float KJONGBFIMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x12DC850", Offset = "0x12DB250", VA = "0x1812DC850", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x52A9F50", Offset = "0x52A8950", VA = "0x1852A9F50", Slot = "24")]
	private bool HPEKEMHDMLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x52A9F40", Offset = "0x52A8940", VA = "0x1852A9F40", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x52A9F70", Offset = "0x52A8970", VA = "0x1852A9F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6770D0", Offset = "0x675AD0", VA = "0x1806770D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x52A6BF0", Offset = "0x52A55F0", VA = "0x1852A6BF0")]
	public KDCINJGACHH(MHOFAIKCPGB.KOLFCAKAGLO OBOHCOMMCNH, BLPLFNDOFAH OEPIECOLOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x52A6170", Offset = "0x52A4B70", VA = "0x1852A6170")]
	public void GOEJPGPIKLK(NBHNLOFJONK FHAENLMAGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x52A5D20", Offset = "0x52A4720", VA = "0x1852A5D20")]
	public void EKCLHFOOCGG(IList<NBHNLOFJONK> LCMAJMBHADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x52A6710", Offset = "0x52A5110", VA = "0x1852A6710")]
	public void NMNKLCNEJPM(IList<NBHNLOFJONK> LCMAJMBHADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x52A69E0", Offset = "0x52A53E0", VA = "0x1852A69E0")]
	private void PIFBMNACNLC(NBHNLOFJONK FHAENLMAGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x52A5FF0", Offset = "0x52A49F0", VA = "0x1852A5FF0")]
	private void FKKJIGHCMLB(IList<NBHNLOFJONK> LCMAJMBHADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x52A5830", Offset = "0x52A4230", VA = "0x1852A5830")]
	private ILDDABJHBPK BGKHGNGEKKF(NBHNLOFJONK FHAENLMAGBC)
	{
		return default(ILDDABJHBPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x52A65D0", Offset = "0x52A4FD0", VA = "0x1852A65D0")]
	public void LJKNPIDDPEM(float PBLDCFGNOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x52A59D0", Offset = "0x52A43D0", VA = "0x1852A59D0")]
	public void DOLLKIFOHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x52A63B0", Offset = "0x52A4DB0", VA = "0x1852A63B0")]
	private void LHDEBNPAEDE(List<NBHNLOFJONK> LCMAJMBHADE, Stack<int> HLLBEDPICKP, bool BGLJFFMHGPC, float BDJOGEDLAMK = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x52A5BE0", Offset = "0x52A45E0", VA = "0x1852A5BE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x52A6290", Offset = "0x52A4C90", VA = "0x1852A6290")]
	private void KFABFFEDEIK(List<NBHNLOFJONK> LCMAJMBHADE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class NFLKAKFNPLI : BLPLFNDOFAH
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "4")]
	public void HGIEDNINPML(string NBODBMLPNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
	public void IJBLNCKIDAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x52A3720", Offset = "0x52A2120", VA = "0x1852A3720", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IAIALDMGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x52A36C0", Offset = "0x52A20C0", VA = "0x1852A36C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool AGNKCFCGOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x52A36A0", Offset = "0x52A20A0", VA = "0x1852A36A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676940", VA = "0x180677F40")]
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

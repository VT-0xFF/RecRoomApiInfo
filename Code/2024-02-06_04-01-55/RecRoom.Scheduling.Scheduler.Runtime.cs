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
public class LFMDOCCAHFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority LICBALDHBEN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67AC900", Offset = "0x67ABD00", VA = "0x1867AC900")]
	public LFMDOCCAHFL(ThreadPriority CCNJDNOBKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67AC8F0", Offset = "0x67ABCF0", VA = "0x1867AC8F0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> DOJOCFFGBPF(List<PlayerLoopSystem> CLHCLDFHFKO, int EILHFHACKAP);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct EEKJDNDLLJL
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct CAFKOMCMBAE
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static DICJLHNIKOO CPEDKBIEKJA;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x679E7A0", Offset = "0x679DBA0", VA = "0x18679E7A0")]
				public static PlayerLoopSystem OMAALNBPKCC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct FBJGOHHIHME
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static DICJLHNIKOO JBKMNEHECEM;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x67A3DC0", Offset = "0x67A31C0", VA = "0x1867A3DC0")]
				public static PlayerLoopSystem OMAALNBPKCC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct JBEEMBPNGOA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static DICJLHNIKOO GMPJFINHIAE;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x67A9870", Offset = "0x67A8C70", VA = "0x1867A9870")]
				public static PlayerLoopSystem OMAALNBPKCC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct BJCKLJONHDD
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static DICJLHNIKOO OJNNIBHGGIC;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static DICJLHNIKOO CIAMIMAEGNB;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static DICJLHNIKOO PFLEKBIPIIJ;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static DICJLHNIKOO PKEFJKBLGMF;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x679D950", Offset = "0x679CD50", VA = "0x18679D950")]
				public static PlayerLoopSystem OMAALNBPKCC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct KKEDKDGEKIC
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static DICJLHNIKOO KFLNHIEKPKJ;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x67AAD00", Offset = "0x67AA100", VA = "0x1867AAD00")]
				public static PlayerLoopSystem OMAALNBPKCC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct ADDPHFJEIAC
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static DICJLHNIKOO OJNNIBHGGIC;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static DICJLHNIKOO CIAMIMAEGNB;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static DICJLHNIKOO PFLEKBIPIIJ;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static DICJLHNIKOO PKEFJKBLGMF;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x67997B0", Offset = "0x6798BB0", VA = "0x1867997B0")]
				public static PlayerLoopSystem OMAALNBPKCC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct AJCGBAPPEJB
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static DICJLHNIKOO MHMMHPLNGHF;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x679A4E0", Offset = "0x67998E0", VA = "0x18679A4E0")]
				public static PlayerLoopSystem OMAALNBPKCC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct NLNPAIEOLKG
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static DICJLHNIKOO DMLEDACAHCE;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x67B17F0", Offset = "0x67B0BF0", VA = "0x1867B17F0")]
				public static PlayerLoopSystem OMAALNBPKCC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct DFHCPLLMAHA
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static DICJLHNIKOO DEHDMAIACNO;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x67A2670", Offset = "0x67A1A70", VA = "0x1867A2670")]
				public static PlayerLoopSystem OMAALNBPKCC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct AKBDEBHDCKI
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static DICJLHNIKOO NHDADFJHDDG;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x679B280", Offset = "0x679A680", VA = "0x18679B280")]
				public static PlayerLoopSystem OMAALNBPKCC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct AGOOIFLMACH
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static DICJLHNIKOO IOLFGNGKDHM;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x679A2E0", Offset = "0x67996E0", VA = "0x18679A2E0")]
				public static PlayerLoopSystem OMAALNBPKCC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct JGLMAAMINIB
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static DICJLHNIKOO PALNBIJDOIM;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x67A9A70", Offset = "0x67A8E70", VA = "0x1867A9A70")]
				public static PlayerLoopSystem OMAALNBPKCC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum ECNADFEHBNI : byte
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
			public struct OPKDCJBFJGG
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class BIKGIGCLIJD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public ECNADFEHBNI updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
					public BIKGIGCLIJD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x679D8D0", Offset = "0x679CCD0", VA = "0x18679D8D0")]
					internal void DEFNMLIJHEC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static EPDOKNAGJLN<ECNADFEHBNI> CGGPCOCKDJI;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x67B43A0", Offset = "0x67B37A0", VA = "0x1867B43A0")]
				public static PlayerLoopSystem OMAALNBPKCC(ECNADFEHBNI JAOGCGIOEHK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct IFBFHHIEFND
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class KEENDBIPKCL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public BCOHOBIKADM.HCDBPAEAJMB key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
					public KEENDBIPKCL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x67AA620", Offset = "0x67A9A20", VA = "0x1867AA620")]
					internal void FJANDCBNCGP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable OPGKJAOGDKL;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x67A8AA0", Offset = "0x67A7EA0", VA = "0x1867A8AA0")]
				public static PlayerLoopSystem MGCJMKCKBNG(BCOHOBIKADM.HCDBPAEAJMB GPGELODKPOB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct DAENDEGACHH
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class JHEFGPHMDKF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public BCOHOBIKADM.HCDBPAEAJMB key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
					public JHEFGPHMDKF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x67A9C70", Offset = "0x67A9070", VA = "0x1867A9C70")]
					internal void FJANDCBNCGP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x67A2540", Offset = "0x67A1940", VA = "0x1867A2540")]
				public static PlayerLoopSystem MGCJMKCKBNG(BCOHOBIKADM.HCDBPAEAJMB GPGELODKPOB)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class BIBKJJHKHBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public BIBKJJHKHBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x679D7B0", Offset = "0x679CBB0", VA = "0x18679D7B0")]
			internal List<PlayerLoopSystem> EHMNADANKMG(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool DIOAOPOJIOL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool KLKMLOFLCON
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x67A1720", Offset = "0x67A0B20", VA = "0x1867A1720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x679EC30", Offset = "0x679E030", VA = "0x18679EC30")]
		private static void EGOGLBDHCPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67A1C70", Offset = "0x67A1070", VA = "0x1867A1C70")]
		private static void OBNPAONMNMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x679EA00", Offset = "0x679DE00", VA = "0x18679EA00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67A1560", Offset = "0x67A0960", VA = "0x1867A1560")]
		private static void FCJCBOGGNDM(BCOHOBIKADM.HCDBPAEAJMB GPGELODKPOB, PlayerLoopSystem EPJGJAMPGPP, Type BEKCBBFIPGB, Type FEKFJLJLKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67A1890", Offset = "0x67A0C90", VA = "0x1867A1890")]
		private static void KPPPEFLELPL(PlayerLoopSystem EPJGJAMPGPP, Type BEKCBBFIPGB, Type FEKFJLJLKBI, DOJOCFFGBPF BBPCPNNJHFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67A1760", Offset = "0x67A0B60", VA = "0x1867A1760")]
		private static void ICEOOALIKPM(PlayerLoopSystem EPJGJAMPGPP, Type BEKCBBFIPGB, Type FEKFJLJLKBI, PlayerLoopSystem? OGAKLODMLLH, PlayerLoopSystem? KDLEDJGLOKH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class BCOHOBIKADM
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum HCDBPAEAJMB
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
	public class MDPHAPOAHMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly HCDBPAEAJMB BDLOJGHNJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly AGJMJKDGIMK PPLMBAIFHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long IIILEGNJBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long OMEBLKBKHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long BDHGCNDBEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int CCMNBHFFOKA;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x67ADA60", Offset = "0x67ACE60", VA = "0x1867ADA60")]
		public MDPHAPOAHMJ(HCDBPAEAJMB EJDKIPDFGNO, int NKKEMGJKIGC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x67AD9A0", Offset = "0x67ACDA0", VA = "0x1867AD9A0")]
		public void EGHENLEGDFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x67ADA10", Offset = "0x67ACE10", VA = "0x1867ADA10")]
		public void HJHNACAKHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x67AD7C0", Offset = "0x67ACBC0", VA = "0x1867AD7C0")]
		public void CBAKHCFDFIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static HCDBPAEAJMB[] LBCBFDBAEJM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static MDPHAPOAHMJ[] CDLLJEOHOCE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x679C9E0", Offset = "0x679BDE0", VA = "0x18679C9E0")]
	public static MDPHAPOAHMJ MPIMHHACPEH(HCDBPAEAJMB GPGELODKPOB, int NKKEMGJKIGC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x679C970", Offset = "0x679BD70", VA = "0x18679C970")]
	public static MDPHAPOAHMJ HANHONKCLHL(HCDBPAEAJMB GPGELODKPOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x679CBC0", Offset = "0x679BFC0", VA = "0x18679CBC0")]
	public static void PKPIBKPHENF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class AGJMJKDGIMK : HDJCNNPMBAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int JFLPNMOJNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> CMGPGIPHHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double MOPJGAAPLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double MFCGJJICHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double MJBONNAFEMH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double INGJMJBDKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x679A1D0", Offset = "0x67995D0", VA = "0x18679A1D0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double FMNPMFJGGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x175E5E0", Offset = "0x175D9E0", VA = "0x18175E5E0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double ABCAJGECHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D051F0", Offset = "0x1D045F0", VA = "0x181D051F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x679A230", Offset = "0x6799630", VA = "0x18679A230")]
	public AGJMJKDGIMK(int FGOICGJEFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x679A0B0", Offset = "0x67994B0", VA = "0x18679A0B0", Slot = "7")]
	public void DGFHELDBKIB(double LEPPJAEDELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x679A040", Offset = "0x6799440", VA = "0x18679A040", Slot = "8")]
	public void CJNCIGMNEAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class FGIICFAKOGL : HDJCNNPMBAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long CBPPKGAPPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double FKJGJAEKDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double EDEDLEPPEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double JJMHGLEJGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double KGCDDDJJAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double MOPJGAAPLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double MFCGJJICHPO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double FMNPMFJGGME
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x56B29D0", Offset = "0x56B1DD0", VA = "0x1856B29D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double ABCAJGECHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x56B2EC0", Offset = "0x56B22C0", VA = "0x1856B2EC0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double JBDGNFIELGH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x56B2A60", Offset = "0x56B1E60", VA = "0x1856B2A60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double INGJMJBDKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x21B4360", Offset = "0x21B3760", VA = "0x1821B4360", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x67A41A0", Offset = "0x67A35A0", VA = "0x1867A41A0", Slot = "7")]
	public virtual void DGFHELDBKIB(double LEPPJAEDELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x67A4160", Offset = "0x67A3560", VA = "0x1867A4160", Slot = "8")]
	public virtual void CJNCIGMNEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x67A4130", Offset = "0x67A3530", VA = "0x1867A4130")]
	public FGIICFAKOGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FEJPAJOJNMK : FGIICFAKOGL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double ABDHDCEMFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x56B2A90", Offset = "0x56B1E90", VA = "0x1856B2A90")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x56B2A30", Offset = "0x56B1E30", VA = "0x1856B2A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x67A4000", Offset = "0x67A3400", VA = "0x1867A4000", Slot = "7")]
	public override void DGFHELDBKIB(double LEPPJAEDELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67A3FC0", Offset = "0x67A33C0", VA = "0x1867A3FC0", Slot = "8")]
	public override void CJNCIGMNEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x67A4130", Offset = "0x67A3530", VA = "0x1867A4130")]
	public FEJPAJOJNMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface HDJCNNPMBAI
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double INGJMJBDKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double FMNPMFJGGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double ABCAJGECHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class MGCDOJBHNLK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface PEIGOIIAFPH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool OCAHLBKCDIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DMBFJJDECOC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class LOGGIFOCKHL<TPromise, TMainThreadPromise> : PEIGOIIAFPH where TPromise : IIJBCHKFBNI where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise FMNADAHDJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise ACKDGJEKGIB;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise MKLMJILLJJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3BE42E0", Offset = "0x3BE36E0", VA = "0x183BE42E0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OCAHLBKCDIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3BE4340", Offset = "0x3BE3740", VA = "0x183BE4340", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7A4380", Offset = "0x7A3780", VA = "0x1807A4380")]
		protected LOGGIFOCKHL(TPromise FMNADAHDJEO, TMainThreadPromise PMDMNLGJGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3BE42C0", Offset = "0x3BE36C0", VA = "0x183BE42C0", Slot = "5")]
		public void DMBFJJDECOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void HGPOBFNKGBJ(TPromise FMNADAHDJEO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class FKPEJLNBOJM<T> : LOGGIFOCKHL<GKAGCLBDDCM<T>, LGIBOMCBCJH<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3648B70", Offset = "0x3647F70", VA = "0x183648B70")]
		public FKPEJLNBOJM(GKAGCLBDDCM<T> FMNADAHDJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x36489F0", Offset = "0x3647DF0", VA = "0x1836489F0", Slot = "6")]
		protected override void HGPOBFNKGBJ(GKAGCLBDDCM<T> FMNADAHDJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3648B40", Offset = "0x3647F40", VA = "0x183648B40")]
		[CompilerGenerated]
		private void PJMCIMEBMAG(T ANIEEDIHIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x36489C0", Offset = "0x3647DC0", VA = "0x1836489C0")]
		[CompilerGenerated]
		private void GPHCAOLNFBK(string FHHKCHCDKKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class KEAKILBPPDO : PEIGOIIAFPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action HKJBPIINLDG;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OCAHLBKCDIE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
		public KEAKILBPPDO(Action HKJBPIINLDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB93E80", Offset = "0xB93280", VA = "0x180B93E80", Slot = "5")]
		public void DMBFJJDECOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<PEIGOIIAFPH> KHDKFPNLOPC;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2751B30", Offset = "0x2750F30", VA = "0x182751B30")]
	public static GKAGCLBDDCM<T> BNBLGPNEBPD<T>(this GKAGCLBDDCM<T> FMNADAHDJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x67ADC70", Offset = "0x67AD070", VA = "0x1867ADC70")]
	public static void BNBLGPNEBPD(Action HKJBPIINLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2751B90", Offset = "0x2750F90", VA = "0x182751B90")]
	private static GKAGCLBDDCM<T> EDKKPPJKMJI<T>(GKAGCLBDDCM<T> FMNADAHDJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67ADFF0", Offset = "0x67AD3F0", VA = "0x1867ADFF0")]
	private static void DIAPOFEPDHH(PEIGOIIAFPH OLOPHALANKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x67ADD10", Offset = "0x67AD110", VA = "0x1867ADD10")]
	private static void COFEJDNPMND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x67ADB70", Offset = "0x67ACF70", VA = "0x1867ADB70")]
	private static void AKGIOBOAIKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67AE200", Offset = "0x67AD600", VA = "0x1867AE200")]
	private static void MEJPPOCFHEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class HDJPNHBEFFN
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct BBGIKOGKLJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> FPPINIAMECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string OLCMEKHJINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode MIKNJMODLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool HHHBGCGCCMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly PHNJPJKEIOH<string>.DNICKHEMCOE LJJPIIKFGCC;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x679C1B0", Offset = "0x679B5B0", VA = "0x18679C1B0")]
		public BBGIKOGKLJH(TaskCompletionSource<Scene> FGKMLCAPEPJ, string OLCMEKHJINK, LoadSceneMode MIKNJMODLNH, bool HHHBGCGCCMO, PHNJPJKEIOH<string>.DNICKHEMCOE LJJPIIKFGCC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct MJLIFDGKBNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public PHNJPJKEIOH<string>.DNICKHEMCOE stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private PHNJPJKEIOH<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x67AE370", Offset = "0x67AD770", VA = "0x1867AE370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x67AEC10", Offset = "0x67AE010", VA = "0x1867AEC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct KENEHDMGFDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x67AA860", Offset = "0x67A9C60", VA = "0x1867AA860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x67AAB80", Offset = "0x67A9F80", VA = "0x1867AAB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct AFIDAIPFFDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private BBGIKOGKLJH <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6799AA0", Offset = "0x6798EA0", VA = "0x186799AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6799E50", Offset = "0x6799250", VA = "0x186799E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class CKHIPHAKFAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LGIBOMCBCJH<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public CKHIPHAKFAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x679E9A0", Offset = "0x679DDA0", VA = "0x18679E9A0")]
		internal void DANIGECBOIL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct HBKNBKIDFME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public PHNJPJKEIOH<string>.DNICKHEMCOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private CKHIPHAKFAI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private PHNJPJKEIOH<string>.DNICKHEMCOE <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private PHNJPJKEIOH<string>.DNICKHEMCOE <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x67A6310", Offset = "0x67A5710", VA = "0x1867A6310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x67A6EB0", Offset = "0x67A62B0", VA = "0x1867A6EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct IJMLKCPEELN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x67A8D00", Offset = "0x67A8100", VA = "0x1867A8D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x67A9210", Offset = "0x67A8610", VA = "0x1867A9210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct BAFCEJEEJLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public PHNJPJKEIOH<string>.DNICKHEMCOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private PHNJPJKEIOH<string>.DNICKHEMCOE <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private PHNJPJKEIOH<string>.DNICKHEMCOE <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x679B5F0", Offset = "0x679A9F0", VA = "0x18679B5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x679C140", Offset = "0x679B540", VA = "0x18679C140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class AKNKMGFBHDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public AKNKMGFBHDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x679B480", Offset = "0x679A880", VA = "0x18679B480")]
		internal bool IHLFAGMPAJC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NAIIFNJOMFK : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public JLJKALKJOAC onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public NAIIFNJOMFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x67AF3A0", Offset = "0x67AE7A0", VA = "0x1867AF3A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x67AF010", Offset = "0x67AE410", VA = "0x1867AF010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x67AEFC0", Offset = "0x67AE3C0", VA = "0x1867AEFC0")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x67AF350", Offset = "0x67AE750", VA = "0x1867AF350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class BDAALNGHJJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public LGIBOMCBCJH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public BDAALNGHJJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x679CE00", Offset = "0x679C200", VA = "0x18679CE00")]
		internal bool BPAEGGFPCDO(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x679CE80", Offset = "0x679C280", VA = "0x18679CE80")]
		internal void ELELGNFBEGN(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class BBIFBEAIIAE : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public LGIBOMCBCJH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private BDAALNGHJJG <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public BBIFBEAIIAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x679C210", Offset = "0x679B610", VA = "0x18679C210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x679C920", Offset = "0x679BD20", VA = "0x18679C920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> IDCFEAHEFKL;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static IIJBCHKFBNI CPKACBDICJK;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation LAOBDCAEADA;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static IIJBCHKFBNI MFPJHLENDHE;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string GKCJIECHJLB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority BCAFCDJMIJF;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task EMIFNNNFPIA;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> FLCCHBDPKEF;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<BBGIKOGKLJH> ILFKNBONMHD;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task IOKCGAPDCON;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool GPAELKOHDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x67A81D0", Offset = "0x67A75D0", VA = "0x1867A81D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool OGAJBPAHGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x67A7F30", Offset = "0x67A7330", VA = "0x1867A7F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool INLHIKADJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x67A85F0", Offset = "0x67A79F0", VA = "0x1867A85F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool NGIONAIKIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x67A7590", Offset = "0x67A6990", VA = "0x1867A7590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> HGBDAKPANGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x67A83F0", Offset = "0x67A77F0", VA = "0x1867A83F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x67A7320", Offset = "0x67A6720", VA = "0x1867A7320")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x67A7BC0", Offset = "0x67A6FC0", VA = "0x1867A7BC0")]
	[AFMMEBJJOHC(EHBEGHACGPO.EnteredEditModeNextFrame, 0)]
	private static void HBIEJFHCPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x67A71D0", Offset = "0x67A65D0", VA = "0x1867A71D0")]
	[AsyncStateMachine(typeof(MJLIFDGKBNI))]
	public static Task<Scene> ALHOFLGDHOA(string OLCMEKHJINK, LoadSceneMode MIKNJMODLNH = LoadSceneMode.Single, bool HHHBGCGCCMO = false, [Optional] PHNJPJKEIOH<string>.DNICKHEMCOE ACCDCEEEKLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x67A78F0", Offset = "0x67A6CF0", VA = "0x1867A78F0")]
	[AsyncStateMachine(typeof(KENEHDMGFDC))]
	private static Task GEHNEONFCLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x67A7FD0", Offset = "0x67A73D0", VA = "0x1867A7FD0")]
	[AsyncStateMachine(typeof(AFIDAIPFFDC))]
	private static Task JPACBFBLDKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x67A7DE0", Offset = "0x67A71E0", VA = "0x1867A7DE0")]
	[AsyncStateMachine(typeof(HBKNBKIDFME))]
	private static Task<Scene> IODOJNOFHJH(string OLCMEKHJINK, LoadSceneMode MIKNJMODLNH, bool HHHBGCGCCMO, PHNJPJKEIOH<string>.DNICKHEMCOE LJJPIIKFGCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x67A7430", Offset = "0x67A6830", VA = "0x1867A7430")]
	private static void BJPINILMJFA(SceneInstance EANIAGEJDFL, LoadSceneMode MIKNJMODLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67A8690", Offset = "0x67A7A90", VA = "0x1867A8690")]
	private static void OKFBOMLLMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x67A7CC0", Offset = "0x67A70C0", VA = "0x1867A7CC0")]
	[AsyncStateMachine(typeof(IJMLKCPEELN))]
	private static Task<Scene> IDCJJPLHOHJ(string OLCMEKHJINK, LoadSceneMode MIKNJMODLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x67A8500", Offset = "0x67A7900", VA = "0x1867A8500")]
	private static bool NIJNHDKIMEM(string OLCMEKHJINK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67A70C0", Offset = "0x67A64C0", VA = "0x1867A70C0")]
	[AsyncStateMachine(typeof(BAFCEJEEJLG))]
	private static Task<Scene> AHKABMGFPDF(PHNJPJKEIOH<string>.DNICKHEMCOE LJJPIIKFGCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67A7A40", Offset = "0x67A6E40", VA = "0x1867A7A40")]
	public static GKAGCLBDDCM<Scene> HBCOHBKALEJ(string OLCMEKHJINK, LoadSceneMode MIKNJMODLNH = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67A7620", Offset = "0x67A6A20", VA = "0x1867A7620")]
	public static IIJBCHKFBNI FKLLAJPDDON(string OLCMEKHJINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67A8750", Offset = "0x67A7B50", VA = "0x1867A8750")]
	[IteratorStateMachine(typeof(NAIIFNJOMFK))]
	private static IEnumerator<ALCMBHLDKFG> PPNDHLMKIEJ(string OLCMEKHJINK, JLJKALKJOAC AFFNOMIGAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x67A79A0", Offset = "0x67A6DA0", VA = "0x1867A79A0")]
	[IteratorStateMachine(typeof(BBIFBEAIIAE))]
	private static IEnumerator<ALCMBHLDKFG> GGCCHFODOEA(string OLCMEKHJINK, LoadSceneMode MIKNJMODLNH, LGIBOMCBCJH<Scene> AFFNOMIGAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x67A80A0", Offset = "0x67A74A0", VA = "0x1867A80A0")]
	public static bool LDKOKCIDLEI([Out] string ICFPOOEMAAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class AGJBEHAANKD
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6799EB0", Offset = "0x67992B0", VA = "0x186799EB0")]
	public static IDisposable EDMHOOKMCKM(this JMBKFDFNLDJ HFPPGLCONIA, float FAJDAMILNMK, Action<float> GLBGFJJCOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6799FC0", Offset = "0x67993C0", VA = "0x186799FC0")]
	public static IDisposable MMCNIMIGCBK(this JMBKFDFNLDJ HFPPGLCONIA, Action<float> GLBGFJJCOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6799F40", Offset = "0x6799340", VA = "0x186799F40")]
	public static IDisposable IKHKGKLDGII(this JMBKFDFNLDJ HFPPGLCONIA, Action<float> GLBGFJJCOHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class AJFDHJBGOME
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x679ACF0", Offset = "0x679A0F0", VA = "0x18679ACF0")]
	public static IDisposable LFFKDPCMMLE(this MonoBehaviour CBOGFEPHCCP, Action GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x679AD80", Offset = "0x679A180", VA = "0x18679AD80")]
	public static IDisposable LFFKDPCMMLE(this MonoBehaviour CBOGFEPHCCP, Action<float> GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x679B160", Offset = "0x679A560", VA = "0x18679B160")]
	public static IDisposable NEPLKJNDANP(this MonoBehaviour CBOGFEPHCCP, Action GLBGFJJCOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x679AF30", Offset = "0x679A330", VA = "0x18679AF30")]
	public static IDisposable MBFELDBDGBB(this MonoBehaviour CBOGFEPHCCP, Action GLBGFJJCOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x679AEB0", Offset = "0x679A2B0", VA = "0x18679AEB0")]
	public static IDisposable MBFELDBDGBB(this MonoBehaviour CBOGFEPHCCP, Action<float> GLBGFJJCOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x679B0E0", Offset = "0x679A4E0", VA = "0x18679B0E0")]
	public static IDisposable MIPBKPIGOKL(this MonoBehaviour CBOGFEPHCCP, Action GLBGFJJCOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x679A970", Offset = "0x6799D70", VA = "0x18679A970")]
	public static IDisposable JLJDHJJHJJC(this MonoBehaviour CBOGFEPHCCP, Action GLBGFJJCOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x679AFB0", Offset = "0x679A3B0", VA = "0x18679AFB0")]
	public static IDisposable MDILLFHAMKD(this MonoBehaviour CBOGFEPHCCP, Action GLBGFJJCOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x679A8C0", Offset = "0x6799CC0", VA = "0x18679A8C0")]
	public static IDisposable COFIDPCFONJ(this MonoBehaviour CBOGFEPHCCP, float FAJDAMILNMK, Action<float> GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM, bool PMDMJCCNJDD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x679AA90", Offset = "0x6799E90", VA = "0x18679AA90")]
	public static IDisposable KKAGKJJFABN(this MonoBehaviour CBOGFEPHCCP, float FAJDAMILNMK, Action<float> GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM, bool PMDMJCCNJDD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x679AC50", Offset = "0x679A050", VA = "0x18679AC50")]
	public static IDisposable KMPKGACCHEI(this MonoBehaviour CBOGFEPHCCP, float FAJDAMILNMK, Action<float> GLBGFJJCOHF, bool PMDMJCCNJDD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x679A9F0", Offset = "0x6799DF0", VA = "0x18679A9F0")]
	public static IDisposable JPIKHEOPKHC(this MonoBehaviour CBOGFEPHCCP, Action<float> GLBGFJJCOHF, bool PMDMJCCNJDD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x679AE10", Offset = "0x679A210", VA = "0x18679AE10")]
	public static IDisposable LKLAALCBPNP(this MonoBehaviour CBOGFEPHCCP, Action<float> GLBGFJJCOHF, bool PMDMJCCNJDD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x679A6E0", Offset = "0x6799AE0", VA = "0x18679A6E0")]
	public static IDisposable ADPIOOAAFFA(this MonoBehaviour CBOGFEPHCCP, Action<float> GLBGFJJCOHF, bool PMDMJCCNJDD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x679B1E0", Offset = "0x679A5E0", VA = "0x18679B1E0")]
	public static IDisposable OEOMOEBGEBG(this MonoBehaviour CBOGFEPHCCP, Action<float> GLBGFJJCOHF, bool PMDMJCCNJDD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x679A780", Offset = "0x6799B80", VA = "0x18679A780")]
	public static IDisposable BIPPPCHKEMM(this MonoBehaviour CBOGFEPHCCP, Action<float> GLBGFJJCOHF, bool PMDMJCCNJDD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x679A820", Offset = "0x6799C20", VA = "0x18679A820")]
	public static IDisposable BPAJBNBKDBM(this MonoBehaviour CBOGFEPHCCP, Action<float> GLBGFJJCOHF, bool PMDMJCCNJDD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x679ABB0", Offset = "0x6799FB0", VA = "0x18679ABB0")]
	public static IDisposable KLJGKFDHOAH(this MonoBehaviour CBOGFEPHCCP, Action<float> GLBGFJJCOHF, bool PMDMJCCNJDD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x679B030", Offset = "0x679A430", VA = "0x18679B030")]
	public static IDisposable MGBGAICCLHO(this MonoBehaviour CBOGFEPHCCP, float FAJDAMILNMK, Action<float> GLBGFJJCOHF, bool PMDMJCCNJDD = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PDBBPIJNPFM
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class JHKDJCEBMAE : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public BBBNCPMDOIF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private ALFEFKLEGEI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public JHKDJCEBMAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x67A9EE0", Offset = "0x67A92E0", VA = "0x1867A9EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x67A9FC0", Offset = "0x67A93C0", VA = "0x1867A9FC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JOEGABBJJGL : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public BBBNCPMDOIF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private ALFEFKLEGEI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public JOEGABBJJGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x67AA4E0", Offset = "0x67A98E0", VA = "0x1867AA4E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x67AA5D0", Offset = "0x67A99D0", VA = "0x1867AA5D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x67B4870", Offset = "0x67B3C70", VA = "0x1867B4870")]
	public static ICANAFEODIJ LFFKDPCMMLE(Action GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x67B47B0", Offset = "0x67B3BB0", VA = "0x1867B47B0")]
	public static ICANAFEODIJ LFFKDPCMMLE(Behaviour HFPPGLCONIA, Action GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x67B4690", Offset = "0x67B3A90", VA = "0x1867B4690")]
	public static ICANAFEODIJ LFFKDPCMMLE(Behaviour HFPPGLCONIA, Action<float> GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x67B4570", Offset = "0x67B3970", VA = "0x1867B4570")]
	[IteratorStateMachine(typeof(JHKDJCEBMAE))]
	private static IEnumerator<ALCMBHLDKFG> DNNACGEDEAI(BBBNCPMDOIF NIBIMNHOJEB, Action GLBGFJJCOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67B4600", Offset = "0x67B3A00", VA = "0x1867B4600")]
	[IteratorStateMachine(typeof(JOEGABBJJGL))]
	private static IEnumerator<ALCMBHLDKFG> DNNACGEDEAI(BBBNCPMDOIF NIBIMNHOJEB, Action<float> GLBGFJJCOHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NKJHEDDFIBJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class HCPJJCPENGI : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public NKJHEDDFIBJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public HCPJJCPENGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x67A6FE0", Offset = "0x67A63E0", VA = "0x1867A6FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x67A7070", Offset = "0x67A6470", VA = "0x1867A7070", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly BBBNCPMDOIF FFNIICBEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action ELGMDJNPNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool ELMBCLMOBLN;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EKIHIOAGCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A00", Offset = "0x7A4E00", VA = "0x1807A5A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x67B16E0", Offset = "0x67B0AE0", VA = "0x1867B16E0")]
	public NKJHEDDFIBJ(BBBNCPMDOIF FFNIICBEDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x67B1660", Offset = "0x67B0A60", VA = "0x1867B1660")]
	[IteratorStateMachine(typeof(HCPJJCPENGI))]
	private IEnumerator<ALCMBHLDKFG> PLHJADOPNDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x67B15C0", Offset = "0x67B09C0", VA = "0x1867B15C0", Slot = "4")]
	public void OnCompleted(Action NHFEKMCDLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
	public void FNOMCIFMAHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class ALNMAEEACBN
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x679B4B0", Offset = "0x679A8B0", VA = "0x18679B4B0")]
	public static NKJHEDDFIBJ JHNBDACJOPK(this BBBNCPMDOIF FFNIICBEDFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class JAIAOGIAIKI
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class HHGCCGPGHNC : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public FJMHDJEJOFI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public HHGCCGPGHNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x67A89D0", Offset = "0x67A7DD0", VA = "0x1867A89D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x67A8A50", Offset = "0x67A7E50", VA = "0x1867A8A50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x67A9460", Offset = "0x67A8860", VA = "0x1867A9460")]
	public static ICANAFEODIJ LFFKDPCMMLE(float FAJDAMILNMK, Action<float> GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM, bool PMDMJCCNJDD = true, [Optional] FDNFEOIFBAK PPOFDEPAABP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x67A9560", Offset = "0x67A8960", VA = "0x1867A9560")]
	public static ICANAFEODIJ LFFKDPCMMLE(MonoBehaviour CBOGFEPHCCP, float FAJDAMILNMK, Action<float> GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM, bool PMDMJCCNJDD = true, [Optional] FDNFEOIFBAK PPOFDEPAABP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x67A9340", Offset = "0x67A8740", VA = "0x1867A9340")]
	public static ICANAFEODIJ EDOAKAHGILJ(MonoBehaviour CBOGFEPHCCP, float FAJDAMILNMK, Action<float> GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM, bool PMDMJCCNJDD = true, [Optional] FDNFEOIFBAK PPOFDEPAABP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x67A9760", Offset = "0x67A8B60", VA = "0x1867A9760")]
	public static ICANAFEODIJ PPKEAILCLNJ(JMBKFDFNLDJ HFPPGLCONIA, float FAJDAMILNMK, Action<float> GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM, bool PMDMJCCNJDD = true, [Optional] FDNFEOIFBAK PPOFDEPAABP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x67A9280", Offset = "0x67A8680", VA = "0x1867A9280")]
	private static IEnumerator<ALCMBHLDKFG> DNNACGEDEAI(NBDIAHEAIDP HANLJMIGMIH, float FAJDAMILNMK, BBBNCPMDOIF NIBIMNHOJEB, Action<float> GLBGFJJCOHF, bool PMDMJCCNJDD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x67A9700", Offset = "0x67A8B00", VA = "0x1867A9700")]
	private static IEnumerator<ALCMBHLDKFG> NJIIBGLMAGE(NBDIAHEAIDP HANLJMIGMIH, float FAJDAMILNMK, BBBNCPMDOIF NIBIMNHOJEB, Action<float> GLBGFJJCOHF, bool PMDMJCCNJDD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x67A9670", Offset = "0x67A8A70", VA = "0x1867A9670")]
	[IteratorStateMachine(typeof(HHGCCGPGHNC))]
	private static IEnumerator<ALCMBHLDKFG> MGJKCFGPKEP(FJMHDJEJOFI HGMAGJBELDF, float FAJDAMILNMK, BBBNCPMDOIF NIBIMNHOJEB, Action<float> GLBGFJJCOHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class BKKKDEBAICH
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class MDOBBPKPNDN : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public BBBNCPMDOIF queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public MDOBBPKPNDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x67AD6B0", Offset = "0x67ACAB0", VA = "0x1867AD6B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x67AD770", Offset = "0x67ACB70", VA = "0x1867AD770", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x679DC40", Offset = "0x679D040", VA = "0x18679DC40")]
	[IteratorStateMachine(typeof(MDOBBPKPNDN))]
	private static IEnumerator<ALCMBHLDKFG> EGPIPKIOBIL(BBBNCPMDOIF FFNIICBEDFM, Func<bool> CGICPLGALCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x679DCD0", Offset = "0x679D0D0", VA = "0x18679DCD0")]
	public static ICANAFEODIJ LAEBCFAAOMH(this MonoBehaviour CBOGFEPHCCP, Func<bool> CGICPLGALCI, BBBNCPMDOIF FFNIICBEDFM = BBBNCPMDOIF.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class FLDGOOFIHKN
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class GGEFDLNCNFP : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public BBBNCPMDOIF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public GGEFDLNCNFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x67A61D0", Offset = "0x67A55D0", VA = "0x1867A61D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x67A6240", Offset = "0x67A5640", VA = "0x1867A6240", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class MPOJGLHDLBC : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public BBBNCPMDOIF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private ALCMBHLDKFG <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public MPOJGLHDLBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x67AEEA0", Offset = "0x67AE2A0", VA = "0x1867AEEA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x67AEF30", Offset = "0x67AE330", VA = "0x1867AEF30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x67A4D60", Offset = "0x67A4160", VA = "0x1867A4D60")]
	[IteratorStateMachine(typeof(GGEFDLNCNFP))]
	private static IEnumerator<ALCMBHLDKFG> PLHJADOPNDP(float MINLHDMFCJJ, BBBNCPMDOIF NIBIMNHOJEB, Action KCPEOJNECNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x67A47F0", Offset = "0x67A3BF0", VA = "0x1867A47F0")]
	[IteratorStateMachine(typeof(MPOJGLHDLBC))]
	private static IEnumerator<ALCMBHLDKFG> KGECAELOPKF(float MINLHDMFCJJ, BBBNCPMDOIF NIBIMNHOJEB, Action KCPEOJNECNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x67A4B10", Offset = "0x67A3F10", VA = "0x1867A4B10")]
	public static IDisposable PBAIDFMMOOB(this MonoBehaviour CBOGFEPHCCP, float MINLHDMFCJJ, Action KCPEOJNECNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x67A4890", Offset = "0x67A3C90", VA = "0x1867A4890")]
	public static ICANAFEODIJ KNNOLDNEMDK(this MonoBehaviour CBOGFEPHCCP, float MINLHDMFCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x67A4C30", Offset = "0x67A4030", VA = "0x1867A4C30")]
	public static ICANAFEODIJ PBAIDFMMOOB(this MonoBehaviour CBOGFEPHCCP, float MINLHDMFCJJ, BBBNCPMDOIF NIBIMNHOJEB, Action KCPEOJNECNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x67A4AF0", Offset = "0x67A3EF0", VA = "0x1867A4AF0")]
	public static ICANAFEODIJ OHFJMBGBIJG(this MonoBehaviour CBOGFEPHCCP, Action KCPEOJNECNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x67A46F0", Offset = "0x67A3AF0", VA = "0x1867A46F0")]
	public static ICANAFEODIJ FMNFKENLFFG(this MonoBehaviour CBOGFEPHCCP, Action KCPEOJNECNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x67A4610", Offset = "0x67A3A10", VA = "0x1867A4610")]
	public static ICANAFEODIJ FKKLHJPLBEB(this MonoBehaviour CBOGFEPHCCP, Action KCPEOJNECNI, [Optional] FDNFEOIFBAK PPOFDEPAABP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x67A45B0", Offset = "0x67A39B0", VA = "0x1867A45B0")]
	public static ICANAFEODIJ EFMMDOGPNHB(this MonoBehaviour CBOGFEPHCCP, Action KCPEOJNECNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x67A44B0", Offset = "0x67A38B0", VA = "0x1867A44B0")]
	public static ICANAFEODIJ CKKLGEJEIEO(this MonoBehaviour CBOGFEPHCCP, Action KCPEOJNECNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x67A45E0", Offset = "0x67A39E0", VA = "0x1867A45E0")]
	public static ICANAFEODIJ FFLJHMACEEJ(this MonoBehaviour CBOGFEPHCCP, Action KCPEOJNECNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x67A43E0", Offset = "0x67A37E0", VA = "0x1867A43E0")]
	private static ICANAFEODIJ AEFOEPINKDN(MonoBehaviour CBOGFEPHCCP, BBBNCPMDOIF FFNIICBEDFM, Action KCPEOJNECNI, [Optional] FDNFEOIFBAK PPOFDEPAABP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67A44E0", Offset = "0x67A38E0", VA = "0x1867A44E0")]
	public static ICANAFEODIJ ECCIIJJGAGL(this MonoBehaviour CBOGFEPHCCP, float OGKAMDFPDFE, Action KCPEOJNECNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x67A4950", Offset = "0x67A3D50", VA = "0x1867A4950")]
	public static ICANAFEODIJ MECGGMDDNJC(this MonoBehaviour CBOGFEPHCCP, float OGKAMDFPDFE, Action KCPEOJNECNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x67A4720", Offset = "0x67A3B20", VA = "0x1867A4720")]
	public static ICANAFEODIJ JIKFMLJMPBP(this MonoBehaviour CBOGFEPHCCP, float OGKAMDFPDFE, Action KCPEOJNECNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x67A4A20", Offset = "0x67A3E20", VA = "0x1867A4A20")]
	public static ICANAFEODIJ NAIHPPBCPED(this MonoBehaviour CBOGFEPHCCP, float OGKAMDFPDFE, Action KCPEOJNECNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class LLLGDPHACFI : PECGDHEJDOJ, IEnumerable<PECGDHEJDOJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<PECGDHEJDOJ> CGKGHIMPEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool LEHOPFANFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action DOOCEGIAHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool NMIBOOODPCM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LDIFELKMNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x67ACD90", Offset = "0x67AC190", VA = "0x1867ACD90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NLBLGPNDEHK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x67ACB10", Offset = "0x67ABF10", VA = "0x1867ACB10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x67ACA70", Offset = "0x67ABE70", VA = "0x1867ACA70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x67AD1F0", Offset = "0x67AC5F0", VA = "0x1867AD1F0")]
	public LLLGDPHACFI([Optional] Action DOOCEGIAHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x67AC940", Offset = "0x67ABD40", VA = "0x1867AC940")]
	public void AFPNFDHLNMK(PECGDHEJDOJ FBHNDOJEPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x67ACC30", Offset = "0x67AC030", VA = "0x1867ACC30")]
	private void JCMANGBBHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x67AD1E0", Offset = "0x67AC5E0", VA = "0x1867AD1E0", Slot = "7")]
	public bool PMIAIDPOHPP(bool BICEHKAFMDO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x67ACED0", Offset = "0x67AC2D0", VA = "0x1867ACED0", Slot = "8")]
	public bool PMIAIDPOHPP(Action HKJBPIINLDG, bool BICEHKAFMDO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x67ACBB0", Offset = "0x67ABFB0", VA = "0x1867ACBB0", Slot = "9")]
	public IEnumerator<PECGDHEJDOJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x67ACBB0", Offset = "0x67ABFB0", VA = "0x1867ACBB0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class MOCPDMBNJAF : BHFBHCJJHIL
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class ODJKLHEENEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public MOCPDMBNJAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public ODJKLHEENEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x67AAF00", Offset = "0x67AA300", VA = "0x1867AAF00")]
		internal void APANOIKNAMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class KMNKADBGENF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public MOCPDMBNJAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public KMNKADBGENF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x67AAF00", Offset = "0x67AA300", VA = "0x1867AAF00")]
		internal void OCCMHDAGADI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float IKAPJCEOKIG;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x67A60D0", Offset = "0x67A54D0", VA = "0x1867A60D0")]
	public MOCPDMBNJAF(Behaviour HFPPGLCONIA, float IKAPJCEOKIG, [Optional] Action DOOCEGIAHFJ, [Optional] FDNFEOIFBAK PPOFDEPAABP, [Optional] NBDIAHEAIDP HANLJMIGMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x67AED90", Offset = "0x67AE190", VA = "0x1867AED90", Slot = "9")]
	protected override bool HNEMNIHHMIB(Action HKJBPIINLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x67AEC80", Offset = "0x67AE080", VA = "0x1867AEC80", Slot = "10")]
	protected override bool FLKBOFEGONP(Action HKJBPIINLDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface PECGDHEJDOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool LDIFELKMNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NLBLGPNDEHK;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PMIAIDPOHPP(bool BICEHKAFMDO = false);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PMIAIDPOHPP(Action HKJBPIINLDG, bool BICEHKAFMDO = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class BHFBHCJJHIL : PECGDHEJDOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class FKGCIKANMJJ : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public BHFBHCJJHIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public FKGCIKANMJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x67A42C0", Offset = "0x67A36C0", VA = "0x1867A42C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x67A4390", Offset = "0x67A3790", VA = "0x1867A4390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour HFPPGLCONIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action DOOCEGIAHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private JJJCAKKGAHC DDEFJMDNKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly FDNFEOIFBAK PPOFDEPAABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly NBDIAHEAIDP HANLJMIGMIH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LDIFELKMNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xF14020", Offset = "0xF13420", VA = "0x180F14020", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NLBLGPNDEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x679D1A0", Offset = "0x679C5A0", VA = "0x18679D1A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x679D100", Offset = "0x679C500", VA = "0x18679D100", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x679D6B0", Offset = "0x679CAB0", VA = "0x18679D6B0")]
	protected BHFBHCJJHIL(Behaviour HFPPGLCONIA, [Optional] Action DOOCEGIAHFJ, [Optional] FDNFEOIFBAK PPOFDEPAABP, [Optional] NBDIAHEAIDP HANLJMIGMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x679D5F0", Offset = "0x679C9F0", VA = "0x18679D5F0", Slot = "7")]
	public bool PMIAIDPOHPP(bool BICEHKAFMDO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x679D650", Offset = "0x679CA50", VA = "0x18679D650", Slot = "8")]
	public bool PMIAIDPOHPP(Action HKJBPIINLDG, bool BICEHKAFMDO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool HNEMNIHHMIB(Action HKJBPIINLDG);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool FLKBOFEGONP(Action HKJBPIINLDG);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x679D280", Offset = "0x679C680", VA = "0x18679D280")]
	protected void OGPGJJFELCO(Action HKJBPIINLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x679D2A0", Offset = "0x679C6A0", VA = "0x18679D2A0")]
	protected IIJBCHKFBNI OPHNADFBPLF(float POAEONMMKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x679D570", Offset = "0x679C970", VA = "0x18679D570")]
	private void PLAJLIHPDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x679D4E0", Offset = "0x679C8E0", VA = "0x18679D4E0")]
	[IteratorStateMachine(typeof(FKGCIKANMJJ))]
	private IEnumerator<ALCMBHLDKFG> PBKHOBINBGM(float POAEONMMKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x679D240", Offset = "0x679C640", VA = "0x18679D240")]
	[CompilerGenerated]
	private void NEKAJFPPEED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class MAOGJBCGOLC : BHFBHCJJHIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float DBDIICGBODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int HNJGMLNFLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float LFEKPCPJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] ODGHJFOAGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int EFCMBNHOEAL;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x67AD510", Offset = "0x67AC910", VA = "0x1867AD510")]
	public MAOGJBCGOLC(Behaviour HFPPGLCONIA, float GPBAFAAPILE, int HNJGMLNFLFC, [Optional] Action DOOCEGIAHFJ, float LFEKPCPJMIK = 0f, [Optional] FDNFEOIFBAK PPOFDEPAABP, [Optional] NBDIAHEAIDP HANLJMIGMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "9")]
	protected override bool HNEMNIHHMIB(Action HKJBPIINLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x67AD310", Offset = "0x67AC710", VA = "0x1867AD310", Slot = "10")]
	protected override bool FLKBOFEGONP(Action HKJBPIINLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x67AD290", Offset = "0x67AC690", VA = "0x1867AD290")]
	private void CCHHIMKNDEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GCDGBPKBNII : BHFBHCJJHIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float IKAPJCEOKIG;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x67A60D0", Offset = "0x67A54D0", VA = "0x1867A60D0")]
	public GCDGBPKBNII(Behaviour HFPPGLCONIA, float IKAPJCEOKIG, [Optional] Action DOOCEGIAHFJ, [Optional] FDNFEOIFBAK PPOFDEPAABP, [Optional] NBDIAHEAIDP HANLJMIGMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "9")]
	protected override bool HNEMNIHHMIB(Action HKJBPIINLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x67A6090", Offset = "0x67A5490", VA = "0x1867A6090", Slot = "10")]
	protected override bool FLKBOFEGONP(Action HKJBPIINLDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class EBNCCLMCILB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class HBPJDACBIJC : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public HBPJDACBIJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x67A6F20", Offset = "0x67A6320", VA = "0x1867A6F20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x67A6F90", Offset = "0x67A6390", VA = "0x1867A6F90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private ICANAFEODIJ GFHADJCNKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private JMBKFDFNLDJ HFPPGLCONIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> CACBLFIALLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private BBBNCPMDOIF FFNIICBEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float ANNAJCBGLJC;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x67A3BE0", Offset = "0x67A2FE0", VA = "0x1867A3BE0")]
	public EBNCCLMCILB(JMBKFDFNLDJ HFPPGLCONIA, float FAJDAMILNMK, Action<float> GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x67A3A40", Offset = "0x67A2E40", VA = "0x1867A3A40")]
	private void MPHOBCCGKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x67A3860", Offset = "0x67A2C60", VA = "0x1867A3860")]
	private void KIJLIDPHJJD(string FHHKCHCDKKO, Action LNHHDOBCKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x67A39C0", Offset = "0x67A2DC0", VA = "0x1867A39C0")]
	[IteratorStateMachine(typeof(HBPJDACBIJC))]
	private IEnumerator<ALCMBHLDKFG> MFDIKNJNLAO(Action LNHHDOBCKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x67A3650", Offset = "0x67A2A50", VA = "0x1867A3650", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x67A36B0", Offset = "0x67A2AB0", VA = "0x1867A36B0")]
	[CompilerGenerated]
	private void FFBBMGHBLPH(string ADINNMOLMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class GADKNNOAJOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class NGLPBOCIOFJ : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public NGLPBOCIOFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x67A6F20", Offset = "0x67A6320", VA = "0x1867A6F20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x67AF990", Offset = "0x67AED90", VA = "0x1867AF990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private ICANAFEODIJ GFHADJCNKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour CBOGFEPHCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action GLBGFJJCOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> CACBLFIALLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private BBBNCPMDOIF FFNIICBEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float ANNAJCBGLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool PMDMJCCNJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly FDNFEOIFBAK PPOFDEPAABP;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x67A5EA0", Offset = "0x67A52A0", VA = "0x1867A5EA0")]
	public GADKNNOAJOB(MonoBehaviour CBOGFEPHCCP, Action GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM, [Optional] FDNFEOIFBAK PPOFDEPAABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x67A5A10", Offset = "0x67A4E10", VA = "0x1867A5A10")]
	public GADKNNOAJOB(MonoBehaviour CBOGFEPHCCP, Action<float> GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM, [Optional] FDNFEOIFBAK PPOFDEPAABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x67A5C50", Offset = "0x67A5050", VA = "0x1867A5C50")]
	public GADKNNOAJOB(MonoBehaviour CBOGFEPHCCP, float FAJDAMILNMK, Action<float> GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM, bool PMDMJCCNJDD = true, [Optional] FDNFEOIFBAK PPOFDEPAABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x18D55D0", Offset = "0x18D49D0", VA = "0x1818D55D0")]
	private GADKNNOAJOB(FDNFEOIFBAK PPOFDEPAABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x67A5020", Offset = "0x67A4420", VA = "0x1867A5020")]
	internal static GADKNNOAJOB HMPOPGONEBP(MonoBehaviour CBOGFEPHCCP, float FAJDAMILNMK, Action<float> GLBGFJJCOHF, BBBNCPMDOIF FFNIICBEDFM, bool PMDMJCCNJDD = true, [Optional] FDNFEOIFBAK PPOFDEPAABP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x67A53A0", Offset = "0x67A47A0", VA = "0x1867A53A0")]
	private void LFFKDPCMMLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x67A5510", Offset = "0x67A4910", VA = "0x1867A5510")]
	private void MBILDDNDGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x67A5740", Offset = "0x67A4B40", VA = "0x1867A5740")]
	private void MPHOBCCGKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x67A4E00", Offset = "0x67A4200", VA = "0x1867A4E00")]
	private void BKIJMMNPFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x67A5270", Offset = "0x67A4670", VA = "0x1867A5270")]
	private void KIJLIDPHJJD(string FHHKCHCDKKO, Action LNHHDOBCKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x67A56C0", Offset = "0x67A4AC0", VA = "0x1867A56C0")]
	[IteratorStateMachine(typeof(NGLPBOCIOFJ))]
	private IEnumerator<ALCMBHLDKFG> MFDIKNJNLAO(Action LNHHDOBCKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x67A4FC0", Offset = "0x67A43C0", VA = "0x1867A4FC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x67A5150", Offset = "0x67A4550", VA = "0x1867A5150")]
	[CompilerGenerated]
	private void IKLJOONLAOB(string ADINNMOLMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x67A58F0", Offset = "0x67A4CF0", VA = "0x1867A58F0")]
	[CompilerGenerated]
	private void NDMEODHNDML(string ADINNMOLMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x67A5980", Offset = "0x67A4D80", VA = "0x1867A5980")]
	[CompilerGenerated]
	private void PKMOIOAOMJB(string ADINNMOLMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x67A51E0", Offset = "0x67A45E0", VA = "0x1867A51E0")]
	[CompilerGenerated]
	private void JANLHMCLEDM(string ADINNMOLMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum NEHPJHGAONG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal sealed class DPGJCMAINNO : NBDIAHEAIDP
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float EDGHECPBEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x67A35A0", Offset = "0x67A29A0", VA = "0x1867A35A0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float GJLIGEFLJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x67A35B0", Offset = "0x67A29B0", VA = "0x1867A35B0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double KHAPFNGGBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x67A35C0", Offset = "0x67A29C0", VA = "0x1867A35C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x67A35E0", Offset = "0x67A29E0", VA = "0x1867A35E0")]
	[HMKFFNEGBBO(FMOKCMPGPEB.None)]
	private static void IKPNECJGIFM(FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	[Preserve]
	internal DPGJCMAINNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface BMIDIBELGGP
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBGNEJDJGFL(string GFBABMFGHOJ);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBKJCFBFLMN();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface ALEBLCFBKCN
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool OOIEMCANFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool DJGDFMNFDKE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class JIFLIBLGKPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public OEIMOJHJJIL AGDCGFIPHHC;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int BLAEHDOLMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x79E180", Offset = "0x79D580", VA = "0x18079E180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCF0", Offset = "0x7AB0F0", VA = "0x1807ABCF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x67AA240", Offset = "0x67A9640", VA = "0x1867AA240")]
	public static ALCMBHLDKFG JOJCBAEMHCK(IEnumerator<ALCMBHLDKFG> FJPGKBGLJKP, HBDOOKBILLH POALHKMFHBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x67AA180", Offset = "0x67A9580", VA = "0x1867AA180")]
	public ALCMBHLDKFG JOJCBAEMHCK(HBDOOKBILLH[] MADKJNMFFDA, IEnumerator<ALCMBHLDKFG>[] EDJFJJKJHKO, ALCMBHLDKFG[] PHEAJAGCCEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x67AA010", Offset = "0x67A9410", VA = "0x1867AA010")]
	public void LKOPKCEJELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x67AA040", Offset = "0x67A9440", VA = "0x1867AA040")]
	public void GCBCOHLHCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x67AA3A0", Offset = "0x67A97A0", VA = "0x1867AA3A0")]
	public void OACCNJMPIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x67AA010", Offset = "0x67A9410", VA = "0x1867AA010")]
	public void FLLHJINFCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public JIFLIBLGKPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class OEIMOJHJJIL
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct OCDFJDCPHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public JIFLIBLGKPL BNEDJDOJLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public JMBKFDFNLDJ MGADIJGPGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HBDOOKBILLH AAGIPLIFJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<ALCMBHLDKFG> AHDEGCHHKCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public ALCMBHLDKFG JMJELCFIOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public NEHPJHGAONG GMABPPKGIDD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct LBKLEGIMKIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public BBBNCPMDOIF EFABDLEPIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<OCDFJDCPHGN> OOPILEBOIEH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class NHMNHOCFKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public HBDOOKBILLH promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public OEIMOJHJJIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public JMBKFDFNLDJ context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public JIFLIBLGKPL routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public NEHPJHGAONG coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public ALCMBHLDKFG currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<ALCMBHLDKFG> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public NHMNHOCFKNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x67AF9E0", Offset = "0x67AEDE0", VA = "0x1867AF9E0")]
		internal void DIDKHBBOJOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class IGEKCLIGEGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public JIFLIBLGKPL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public OEIMOJHJJIL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public IGEKCLIGEGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x67A8BD0", Offset = "0x67A7FD0", VA = "0x1867A8BD0")]
		internal void NPNHBOCMEPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class NAEHOFKJACN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public JIFLIBLGKPL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public OEIMOJHJJIL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public NAEHOFKJACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x67AEF80", Offset = "0x67AE380", VA = "0x1867AEF80")]
		internal void BDPJECAPOKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DPAKPLJILNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public JIFLIBLGKPL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public OEIMOJHJJIL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public DPAKPLJILNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x67A3560", Offset = "0x67A2960", VA = "0x1867A3560")]
		internal void BONLPLKABMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const NEHPJHGAONG MFCHHJGCPEP = NEHPJHGAONG.Cancelled | NEHPJHGAONG.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly BBBNCPMDOIF FFNIICBEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] PMBFHIPMLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<NEHPJHGAONG> NDLGKIIOPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> BOLILCPGHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> AFDCKNBONEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> PIKOEHLMHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> OGLEJPKDJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> HMFGBHGACBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> EGDNANOJODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private JIFLIBLGKPL[] HEHLGFFAEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private HBDOOKBILLH[] MADKJNMFFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private JMBKFDFNLDJ[] CNOEEKBJDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<ALCMBHLDKFG>[] DEHLNPEMKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private ALCMBHLDKFG[] HLGFIMFPLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int DGOGCAELJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int LNJIGPAGCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int CKBMCCEJOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float HAIIHPGNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NFFDHDFCKAF CLDGDADHPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle GKHFJKKIKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<JIFLIBLGKPL> FFDBIOPMFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool FLMKFPKIHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> KHLNJINNCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> AKDDJJKLIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool CLOIDJOGBEA;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public LBKLEGIMKIJ[] ACNECCGEJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x90BD30", Offset = "0x90B130", VA = "0x18090BD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x67B30E0", Offset = "0x67B24E0", VA = "0x1867B30E0")]
	private static int NADGEIDBNJL(BBBNCPMDOIF FFNIICBEDFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x67B3D50", Offset = "0x67B3150", VA = "0x1867B3D50")]
	public OEIMOJHJJIL(BBBNCPMDOIF FFNIICBEDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x67B35E0", Offset = "0x67B29E0", VA = "0x1867B35E0")]
	private void OGFBPNEMFKA(int GGOEAMBGOHN, int JODKMOHPEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x67B2F60", Offset = "0x67B2360", VA = "0x1867B2F60")]
	public void LFDJMNEEPKF(JMBKFDFNLDJ HFPPGLCONIA, ALCMBHLDKFG NPBEIEJEAHO, IEnumerator<ALCMBHLDKFG> FJPGKBGLJKP, HBDOOKBILLH POALHKMFHBE, [Optional] JIFLIBLGKPL JNDAPGFBHGD, NEHPJHGAONG PKIJOMKPBCM = NEHPJHGAONG.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x67B1D90", Offset = "0x67B1190", VA = "0x1867B1D90")]
	public void HMFLAEKIEJM(IEnumerable<OCDFJDCPHGN> MIFGOKJLFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x67B3110", Offset = "0x67B2510", VA = "0x1867B3110")]
	private OCDFJDCPHGN NOCFAIIAECN(int INGOHICNLOP)
	{
		return default(OCDFJDCPHGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x67B1FD0", Offset = "0x67B13D0", VA = "0x1867B1FD0")]
	private void HOINENFGKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x27D6160", Offset = "0x27D5560", VA = "0x1827D6160")]
	private static void FECOPOLPJOJ<T>(int INGOHICNLOP, T[] CIAGJAKCBJG, int HFPFBPPBALK, [Optional] T ENEKKDKAJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x27D61B0", Offset = "0x27D55B0", VA = "0x1827D61B0")]
	private static void FECOPOLPJOJ<T>(int INGOHICNLOP, NativeArray<T> CIAGJAKCBJG, int HFPFBPPBALK, [Optional] T ENEKKDKAJFJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x67B2B40", Offset = "0x67B1F40", VA = "0x1867B2B40")]
	private void KFDMBMEPGLM(IEnumerable<OCDFJDCPHGN> MIFGOKJLFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x67B19F0", Offset = "0x67B0DF0", VA = "0x1867B19F0")]
	private void EMMNJAIIGOC(OCDFJDCPHGN AAGIMECKKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x67B3AF0", Offset = "0x67B2EF0", VA = "0x1867B3AF0")]
	private KNMONCLAKBM PHAJFKBLHDA(int BJFHONOLKIO)
	{
		return default(KNMONCLAKBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x67B37C0", Offset = "0x67B2BC0", VA = "0x1867B37C0")]
	public void OJLOPPPDGCP(float BKCOBIPKMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x67B1D10", Offset = "0x67B1110", VA = "0x1867B1D10")]
	private void HLFMEOIGNFJ(Action KHCOFGFJDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x67B2EE0", Offset = "0x67B22E0", VA = "0x1867B2EE0")]
	private void KJAENIIGLHA(Action KHCOFGFJDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x67B2440", Offset = "0x67B1840", VA = "0x1867B2440")]
	public void IEKADIDJPOC(float BKCOBIPKMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x67B2340", Offset = "0x67B1740", VA = "0x1867B2340")]
	public void IEJPDCFHNJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x67B1BE0", Offset = "0x67B0FE0", VA = "0x1867B1BE0")]
	public void FLLHJINFCEJ(JIFLIBLGKPL HGMAGJBELDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x67B1AB0", Offset = "0x67B0EB0", VA = "0x1867B1AB0")]
	public void FGPADAGLJKH(JIFLIBLGKPL HGMAGJBELDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x67B39C0", Offset = "0x67B2DC0", VA = "0x1867B39C0")]
	public void OLNNMALLGIG(JIFLIBLGKPL HGMAGJBELDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class BPJPGPDFCHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly BPJPGPDFCHK IEOIBINPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action MKAMNANGLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool BDMHAMLDKKB;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	public BPJPGPDFCHK(Action MKAMNANGLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x610E1B0", Offset = "0x610D5B0", VA = "0x18610E1B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface IIDNGIFCBAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T BDGBGLMDOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable ELFLFIJBLJM(UnityEngine.Object HFPPGLCONIA, Action<T> BCNJFEEHBHO);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface ALNEABMGMFF<T> : IIDNGIFCBAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T BDGBGLMDOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class INFMOMICBIJ<T> : ALNEABMGMFF<T>, IIDNGIFCBAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class AAFCGHGIPJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public INFMOMICBIJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public PNOPFGEDAKM<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public AAFCGHGIPJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x36B1FC0", Offset = "0x36B13C0", VA = "0x1836B1FC0")]
		internal void AIIKPOALEOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject FIPHEEMPMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<PNOPFGEDAKM<UnityEngine.Object, Action<T>>> JJELBAPNADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T HMEKFBKFGCE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T BDGBGLMDOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x817E40", Offset = "0x817240", VA = "0x180817E40", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x383C730", Offset = "0x383BB30", VA = "0x18383C730", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x383C660", Offset = "0x383BA60", VA = "0x18383C660")]
	private static bool CJCPFOKMNJI(T KHCOFGFJDMP, T NFAPJGNODPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x383D260", Offset = "0x383C660", VA = "0x18383D260")]
	public INFMOMICBIJ(T CKFLPNJNJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x383C830", Offset = "0x383BC30", VA = "0x18383C830", Slot = "6")]
	public IDisposable ELFLFIJBLJM(UnityEngine.Object HFPPGLCONIA, Action<T> BCNJFEEHBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x383CE80", Offset = "0x383C280", VA = "0x18383CE80")]
	private void GNGAHHCIGKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class KJANAILMCNB : CGEPDILCHBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly FDNFEOIFBAK PPOFDEPAABP;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x67AABE0", Offset = "0x67A9FE0", VA = "0x1867AABE0")]
	[HMKFFNEGBBO(FMOKCMPGPEB.None)]
	private static void IKPNECJGIFM(FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	[Preserve]
	internal KJANAILMCNB([POFPGPCOKGP(null)] FDNFEOIFBAK PPOFDEPAABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x67AAC50", Offset = "0x67AA050", VA = "0x1867AAC50", Slot = "4")]
	public IDisposable KMPKGACCHEI(float FAJDAMILNMK, Action<float> KNDPECEGMIA, bool PMDMJCCNJDD = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class DMDLDELABKH : NIFKNPNHCJC, FDNFEOIFBAK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private OEIMOJHJJIL[] GIKCALKPBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private BMIDIBELGGP EDFMONEHJPO;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x67A2FC0", Offset = "0x67A23C0", VA = "0x1867A2FC0")]
	[HMKFFNEGBBO(FMOKCMPGPEB.None)]
	private static void IKPNECJGIFM(FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x67A34A0", Offset = "0x67A28A0", VA = "0x1867A34A0")]
	[Preserve]
	public DMDLDELABKH([POFPGPCOKGP(null)] MKJDOMGIMCK KFBBBCACFBK, [POFPGPCOKGP(null)] NBDIAHEAIDP HANLJMIGMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x67A3030", Offset = "0x67A2430", VA = "0x1867A3030", Slot = "16")]
	public override ICANAFEODIJ JFEGGKIBHEH(JMBKFDFNLDJ HFPPGLCONIA, IEnumerator<ALCMBHLDKFG> OCOGJJHJJPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x67A2AA0", Offset = "0x67A1EA0", VA = "0x1867A2AA0", Slot = "17")]
	public override void CJNCIGMNEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x67A2870", Offset = "0x67A1C70", VA = "0x1867A2870", Slot = "19")]
	public override void ACMMHMPABDC(BBBNCPMDOIF FFNIICBEDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x67A3210", Offset = "0x67A2610", VA = "0x1867A3210", Slot = "18")]
	protected override void NEPLKJNDANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x67A3160", Offset = "0x67A2560", VA = "0x1867A3160")]
	private OEIMOJHJJIL LDCNCGJDHDL(BBBNCPMDOIF FICJMFBEBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x67A2D90", Offset = "0x67A2190", VA = "0x1867A2D90", Slot = "20")]
	internal override BNMBFGDJKEO GFLNEHNAFHP(IEnumerator<ALCMBHLDKFG> OCOGJJHJJPJ, Behaviour HFPPGLCONIA, HBDOOKBILLH POALHKMFHBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x67A3190", Offset = "0x67A2590", VA = "0x1867A3190", Slot = "21")]
	internal override KPBHFDCCBPH MHCFMFLKGFA(BBBNCPMDOIF NIBIMNHOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x67A3380", Offset = "0x67A2780", VA = "0x1867A3380")]
	private void NMOMHHIHHPD(OEIMOJHJJIL PHCKKBECFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x67A2D30", Offset = "0x67A2130", VA = "0x1867A2D30", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct NFFDHDFCKAF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float OHHEEMGLNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int KGFIFFAJLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> BMIAGIDNGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> MGKJEGMJGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> OOICCBKAMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<NEHPJHGAONG> DNDALLBPOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> IPLCDNBOGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> OGLEJPKDJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> AFDCKNBONEE;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x67AF580", Offset = "0x67AE980", VA = "0x1867AF580")]
	public static NFFDHDFCKAF HDHFILGDDKG(int BLEAGLLLPFI, float BKCOBIPKMLL, NativeArray<NEHPJHGAONG> PHMBOEIEDAC, NativeArray<float> NMEKAEALBPB, NativeArray<int> ENFONEEIHCE, NativeArray<int> LLKLAKHMAMB, NativeArray<int> GIJHGDHBODO, NativeArray<int> MGKJEGMJGNG, NativeArray<int> OOICCBKAMMD)
	{
		return default(NFFDHDFCKAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x67AF4A0", Offset = "0x67AE8A0", VA = "0x1867AF4A0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x67AF430", Offset = "0x67AE830", VA = "0x1867AF430")]
	private bool AKJINCLJGJI(int AHDNEIKOMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x67AF470", Offset = "0x67AE870", VA = "0x1867AF470")]
	private void EKLMLJNJCJK(NativeArray<int> KNIBGNNBLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x67AF6B0", Offset = "0x67AEAB0", VA = "0x1867AF6B0")]
	private int LLKLPPKHBMG(int DJPPCBNLOBO, int OLKFMLMPDHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x67AF5E0", Offset = "0x67AE9E0", VA = "0x1867AF5E0")]
	private void JCMPBFKIEMA(NativeArray<int> KNIBGNNBLFL, int NJDOINCMDKB, int DMMNOJMKOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x67AF750", Offset = "0x67AEB50", VA = "0x1867AF750")]
	private void MMHJBLBJPFI(NativeArray<int> KNIBGNNBLFL, int AADPLHOEACC, int DEFNIIKGBEI, int MPCNFHNEMGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class NIFKNPNHCJC : FDNFEOIFBAK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly MKJDOMGIMCK KFBBBCACFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly NBDIAHEAIDP HANLJMIGMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private KPBHFDCCBPH[] ADKIDHPHPDA;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static FDNFEOIFBAK GHDJCOLHINO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x67B0ED0", Offset = "0x67B02D0", VA = "0x1867B0ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool HGMIANMMKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BBBNCPMDOIF DBIADDPLINK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x79E180", Offset = "0x79D580", VA = "0x18079E180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BBBNCPMDOIF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCF0", Offset = "0x7AB0F0", VA = "0x1807ABCF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NBDIAHEAIDP DMFGICBLIID
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public ALCMBHLDKFG DGJJGDJDMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x67B0FA0", Offset = "0x67B03A0", VA = "0x1867B0FA0")]
	public static ICANAFEODIJ LDJOANPNKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x67B10D0", Offset = "0x67B04D0", VA = "0x1867B10D0")]
	[Preserve]
	protected NIFKNPNHCJC([POFPGPCOKGP(null)] MKJDOMGIMCK KFBBBCACFBK, [POFPGPCOKGP(null)] NBDIAHEAIDP HANLJMIGMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x67B0220", Offset = "0x67AF620", VA = "0x1867B0220", Slot = "6")]
	public ICANAFEODIJ BAFODOIJADE(IEnumerator<ALCMBHLDKFG> OCOGJJHJJPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x67B0230", Offset = "0x67AF630", VA = "0x1867B0230", Slot = "7")]
	public ICANAFEODIJ BAFODOIJADE(Behaviour HFPPGLCONIA, IEnumerator<ALCMBHLDKFG> OCOGJJHJJPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract ICANAFEODIJ JFEGGKIBHEH(JMBKFDFNLDJ HFPPGLCONIA, IEnumerator<ALCMBHLDKFG> OCOGJJHJJPJ);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x67B0430", Offset = "0x67AF830", VA = "0x1867B0430", Slot = "17")]
	public virtual void CJNCIGMNEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x67B05D0", Offset = "0x67AF9D0", VA = "0x1867B05D0", Slot = "9")]
	public void DBILOMBMDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x67B1090", Offset = "0x67B0490", VA = "0x1867B1090", Slot = "18")]
	protected virtual void NEPLKJNDANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x67B0F80", Offset = "0x67B0380", VA = "0x1867B0F80")]
	private void JBKMNEHECEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x67B0C80", Offset = "0x67B0080", VA = "0x1867B0C80")]
	private void GMPJFINHIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x67B1030", Offset = "0x67B0430", VA = "0x1867B1030")]
	private void MBFELDBDGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x67B1070", Offset = "0x67B0470", VA = "0x1867B1070")]
	private void MIPBKPIGOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x67B1050", Offset = "0x67B0450", VA = "0x1867B1050")]
	private void MHMMHPLNGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x67B0810", Offset = "0x67AFC10", VA = "0x1867B0810")]
	private void DMLEDACAHCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x67B10B0", Offset = "0x67B04B0", VA = "0x1867B10B0")]
	private void PKALCPINLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x67B0190", Offset = "0x67AF590", VA = "0x1867B0190", Slot = "19")]
	public virtual void ACMMHMPABDC(BBBNCPMDOIF FFNIICBEDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x67B0CA0", Offset = "0x67B00A0", VA = "0x1867B0CA0")]
	private void HCDDGLIGCNE(KPBHFDCCBPH PHCKKBECFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1C64860", Offset = "0x1C63C60", VA = "0x181C64860")]
	private KPBHFDCCBPH GKBAIFFAHNP(BBBNCPMDOIF FICJMFBEBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract BNMBFGDJKEO GFLNEHNAFHP(IEnumerator<ALCMBHLDKFG> OCOGJJHJJPJ, Behaviour CBOGFEPHCCP, HBDOOKBILLH FAGENCDDIMO);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract KPBHFDCCBPH MHCFMFLKGFA(BBBNCPMDOIF FFNIICBEDFM);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x67B0830", Offset = "0x67AFC30", VA = "0x1867B0830", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x67B0E70", Offset = "0x67B0270", VA = "0x1867B0E70", Slot = "12")]
	public ALCMBHLDKFG HMNKJICGEPO(BBBNCPMDOIF NIBIMNHOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x67B0BF0", Offset = "0x67AFFF0", VA = "0x1867B0BF0", Slot = "13")]
	public ALCMBHLDKFG FCFBKBIDOOM(float MINLHDMFCJJ, BBBNCPMDOIF NIBIMNHOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x67B0F20", Offset = "0x67B0320", VA = "0x1867B0F20", Slot = "14")]
	public ALCMBHLDKFG INHCLHNABND(Func<bool> CGICPLGALCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class BNMBFGDJKEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly HBDOOKBILLH POALHKMFHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly ALEBLCFBKCN HFPPGLCONIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool OPOHHACHAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string GFBABMFGHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace LFNAGLINDLD;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<ALCMBHLDKFG> AHDEGCHHKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A26E0", Offset = "0x7A1AE0", VA = "0x1807A26E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public ALCMBHLDKFG JMJELCFIOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A2700", Offset = "0x7A1B00", VA = "0x1807A2700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool NOOJLGHEAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x679E370", Offset = "0x679D770", VA = "0x18679E370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool DKIGLHFLNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x80E990", Offset = "0x80DD90", VA = "0x18080E990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x80E9A0", Offset = "0x80DDA0", VA = "0x18080E9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x679E1C0", Offset = "0x679D5C0", VA = "0x18679E1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float KJDENJNAHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1072920", Offset = "0x1071D20", VA = "0x181072920")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x56AFBD0", Offset = "0x56AEFD0", VA = "0x1856AFBD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x679E4D0", Offset = "0x679D8D0", VA = "0x18679E4D0")]
	public BNMBFGDJKEO(IEnumerator<ALCMBHLDKFG> FJPGKBGLJKP, ALEBLCFBKCN HFPPGLCONIA, HBDOOKBILLH POALHKMFHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x679DEB0", Offset = "0x679D2B0", VA = "0x18679DEB0")]
	public ALCMBHLDKFG JOJCBAEMHCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x679DDF0", Offset = "0x679D1F0", VA = "0x18679DDF0")]
	public bool DGBDDFCIFEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x679DE60", Offset = "0x679D260", VA = "0x18679DE60")]
	public void FLLHJINFCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x679E3F0", Offset = "0x679D7F0", VA = "0x18679E3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x88BBB0", Offset = "0x88AFB0", VA = "0x18088BBB0")]
	[CompilerGenerated]
	private void GBPAOLIJHAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class HBDOOKBILLH : JMJGJHAFLAB, ICANAFEODIJ, JJJCAKKGAHC, IIJBCHKFBNI, IEnumerator, ALCMBHLDKFG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private BBBNCPMDOIF HJAJPCEEGLN;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private BBBNCPMDOIF BOJECIIFMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xDF4A70", Offset = "0xDF3E70", VA = "0x180DF4A70", Slot = "23")]
		get
		{
			return default(BBBNCPMDOIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BBBNCPMDOIF AGDCGFIPHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x12D6C80", Offset = "0x12D6080", VA = "0x1812D6C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float EPPFCHLOGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE630", Offset = "0x7EDA30", VA = "0x1807EE630", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool NGKBJOCLECI
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x67A62A0", Offset = "0x67A56A0", VA = "0x1867A62A0", Slot = "24")]
	private bool IACIIJNDEOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x67A6290", Offset = "0x67A5690", VA = "0x1867A6290", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x67A62C0", Offset = "0x67A56C0", VA = "0x1867A62C0")]
	public HBDOOKBILLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum KNMONCLAKBM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class KPBHFDCCBPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum CJONNCBFJBD
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct HNHEPNNEOCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public BBBNCPMDOIF EFABDLEPIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CJONNCBFJBD ILFGKKPMFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<BNMBFGDJKEO> APGNIEADLIK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly CJONNCBFJBD[] GOKHHHICADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly BBBNCPMDOIF FFNIICBEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool CHJBFHAEHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly BNMBFGDJKEO[] KKMGDNMDEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<BNMBFGDJKEO> FIDELCDIJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> BHPBOIJLCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<BNMBFGDJKEO> PAPOBCNHIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> ANOPPMAFOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly BMIDIBELGGP HLGNDCMNJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool CLOIDJOGBEA;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public HNHEPNNEOCF[,] NGMPOFHOGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x79E7C0", Offset = "0x79DBC0", VA = "0x18079E7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x67AC450", Offset = "0x67AB850", VA = "0x1867AC450")]
	public KPBHFDCCBPH(BBBNCPMDOIF NIBIMNHOJEB, BMIDIBELGGP HLGNDCMNJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x67AC0A0", Offset = "0x67AB4A0", VA = "0x1867AC0A0")]
	public void KDFCEGKAEEH(BNMBFGDJKEO FJPGKBGLJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x67AB230", Offset = "0x67AA630", VA = "0x1867AB230")]
	public void BEKCPBEFNGM(IList<BNMBFGDJKEO> EDJFJJKJHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x67ABD90", Offset = "0x67AB190", VA = "0x1867ABD90")]
	public void JBFGMKFMOML(IList<BNMBFGDJKEO> EDJFJJKJHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x67ABCA0", Offset = "0x67AB0A0", VA = "0x1867ABCA0")]
	private void HJFAIBEHABK(BNMBFGDJKEO FJPGKBGLJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x67ABB10", Offset = "0x67AAF10", VA = "0x1867ABB10")]
	private void GFCAKMMCAAA(IList<BNMBFGDJKEO> EDJFJJKJHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x67AB990", Offset = "0x67AAD90", VA = "0x1867AB990")]
	private KNMONCLAKBM GCFGOOCDJEC(BNMBFGDJKEO FJPGKBGLJKP)
	{
		return default(KNMONCLAKBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x67AC1A0", Offset = "0x67AB5A0", VA = "0x1867AC1A0")]
	public void NEPLKJNDANP(float BKCOBIPKMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x67AB680", Offset = "0x67AAA80", VA = "0x1867AB680")]
	public void DBILOMBMDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x67AAF30", Offset = "0x67AA330", VA = "0x1867AAF30")]
	private void AFBCHCDFICI(List<BNMBFGDJKEO> EDJFJJKJHKO, Stack<int> LIGBJDAOLJL, bool HAFNACLLPCB, float DGJOGELICGL = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x67AB870", Offset = "0x67AAC70", VA = "0x1867AB870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x67AB540", Offset = "0x67AA940", VA = "0x1867AB540")]
	private void DBANIOCHLME(List<BNMBFGDJKEO> EDJFJJKJHKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class KILCLCEBLEG : BMIDIBELGGP
{
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "4")]
	public void HBGNEJDJGFL(string GFBABMFGHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
	public void GBKJCFBFLMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public KILCLCEBLEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class IHMBOEFNMIJ : ALEBLCFBKCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour CBOGFEPHCCP;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x67A8C80", Offset = "0x67A8080", VA = "0x1867A8C80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool OOIEMCANFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x67A8C10", Offset = "0x67A8010", VA = "0x1867A8C10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool DJGDFMNFDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x67A8C60", Offset = "0x67A8060", VA = "0x1867A8C60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	public IHMBOEFNMIJ(Behaviour CBOGFEPHCCP)
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

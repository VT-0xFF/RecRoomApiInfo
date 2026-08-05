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
public class KBLHNODHIMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority CHAFNEAJHPC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69D36F0", Offset = "0x69D28F0", VA = "0x1869D36F0")]
	public KBLHNODHIMA(ThreadPriority JMHGAMONBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69D36E0", Offset = "0x69D28E0", VA = "0x1869D36E0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> NAHCPIKHCMJ(List<PlayerLoopSystem> KACIDHHAJIK, int FDGACHKPEEL);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct NFKKHNIBHHJ
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct GPNAOIGPBMF
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static DPAIEAIPOBP DDGCBBGJFOK;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x69D0A40", Offset = "0x69CFC40", VA = "0x1869D0A40")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct DMHFAMIOLHO
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static DPAIEAIPOBP GDDFPPHGLFB;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x69CB000", Offset = "0x69CA200", VA = "0x1869CB000")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct EDMNJDJCBOB
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static DPAIEAIPOBP ECADEJMPLOF;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x69CB590", Offset = "0x69CA790", VA = "0x1869CB590")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct BJJNCFFIHCH
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static DPAIEAIPOBP FPPNFMNAPGM;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static DPAIEAIPOBP OIPJPHHIGIB;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static DPAIEAIPOBP BLCAEJNPDOK;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static DPAIEAIPOBP HPLPIDGHNJP;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x69C49E0", Offset = "0x69C3BE0", VA = "0x1869C49E0")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct ENNJFMIOKCP
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static DPAIEAIPOBP GJDMDPEMOLB;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x69CC4D0", Offset = "0x69CB6D0", VA = "0x1869CC4D0")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct JMOENKFGLBL
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static DPAIEAIPOBP FPPNFMNAPGM;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static DPAIEAIPOBP OIPJPHHIGIB;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static DPAIEAIPOBP BLCAEJNPDOK;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static DPAIEAIPOBP HPLPIDGHNJP;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x69D2FF0", Offset = "0x69D21F0", VA = "0x1869D2FF0")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct EKGLKLABGLM
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static DPAIEAIPOBP AHAOFCLPKKH;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x69CBE20", Offset = "0x69CB020", VA = "0x1869CBE20")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct BKKNMBLJHGG
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static DPAIEAIPOBP OLJPFMONOJO;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x69C4CB0", Offset = "0x69C3EB0", VA = "0x1869C4CB0")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct LKCHNFDGACM
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static DPAIEAIPOBP ACGPKNGIKIA;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x69D5720", Offset = "0x69D4920", VA = "0x1869D5720")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct KCBPAOPNEBN
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static DPAIEAIPOBP GFCPDPLECGG;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x69D3730", Offset = "0x69D2930", VA = "0x1869D3730")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct FDJHMAPFEGG
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static DPAIEAIPOBP JOMMDHOBPNG;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x69CC6E0", Offset = "0x69CB8E0", VA = "0x1869CC6E0")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct HOEEBHLLNAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static DPAIEAIPOBP NFMMMMHIINL;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x69D2020", Offset = "0x69D1220", VA = "0x1869D2020")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct DEBFAGEADDL
			{
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public static DPAIEAIPOBP CAACKDIFGFP;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x69CAE20", Offset = "0x69CA020", VA = "0x1869CAE20")]
				public static PlayerLoopSystem GKKOBOHJEDJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum GENKDPPEMAF : byte
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
			public struct AFMPILLIMMN
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class GKLLAEDCCII
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public GENKDPPEMAF updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
					public GKLLAEDCCII()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x69CFDB0", Offset = "0x69CEFB0", VA = "0x1869CFDB0")]
					internal void NLIMOODFCKO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public static CNGIJFFLIEN<GENKDPPEMAF> FPPKEKBOHCC;

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x69C1710", Offset = "0x69C0910", VA = "0x1869C1710")]
				public static PlayerLoopSystem GKKOBOHJEDJ(GENKDPPEMAF EAHLEAIJMFK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct FJEDNIHKDNL
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class KEODENAINMH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public HAILPGOFFDM.POGPAHCJMGA key;

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
					public KEODENAINMH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x69D4C80", Offset = "0x69D3E80", VA = "0x1869D4C80")]
					internal void DDNMFEGOJIC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public static IDisposable DBGPFFGCNLO;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x69CF430", Offset = "0x69CE630", VA = "0x1869CF430")]
				public static PlayerLoopSystem NNGFJCMDACB(HAILPGOFFDM.POGPAHCJMGA GHBNLDGJPCB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct NLFMIKIMKLP
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class OEHDFJIKGIL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public HAILPGOFFDM.POGPAHCJMGA key;

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
					public OEHDFJIKGIL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x69D7870", Offset = "0x69D6A70", VA = "0x1869D7870")]
					internal void DDNMFEGOJIC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x69D6190", Offset = "0x69D5390", VA = "0x1869D6190")]
				public static PlayerLoopSystem NNGFJCMDACB(HAILPGOFFDM.POGPAHCJMGA GHBNLDGJPCB)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class LOJFJALGDAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public LOJFJALGDAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x69D5B50", Offset = "0x69D4D50", VA = "0x1869D5B50")]
			internal List<PlayerLoopSystem> NPBKDGLICNH(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool HNCBNKMLNFC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool JIDKELODPPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x69CA9D0", Offset = "0x69C9BD0", VA = "0x1869CA9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69C7050", Offset = "0x69C6250", VA = "0x1869C7050")]
		private static void CIPKPCPNPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69CA0C0", Offset = "0x69C92C0", VA = "0x1869CA0C0")]
		private static void KGIAHDOLDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69C6E30", Offset = "0x69C6030", VA = "0x1869C6E30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69C6C70", Offset = "0x69C5E70", VA = "0x1869C6C70")]
		private static void ABCHNOFHCHL(HAILPGOFFDM.POGPAHCJMGA GHBNLDGJPCB, PlayerLoopSystem CGLECJKDGKK, Type OLGJDHDOPKL, Type LKMNMMPMNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69C9BB0", Offset = "0x69C8DB0", VA = "0x1869C9BB0")]
		private static void JAJOLCGBENG(PlayerLoopSystem CGLECJKDGKK, Type OLGJDHDOPKL, Type LKMNMMPMNHD, NAHCPIKHCMJ GAEKPGPMECE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69C9F90", Offset = "0x69C9190", VA = "0x1869C9F90")]
		private static void JGMDGAPMIEI(PlayerLoopSystem CGLECJKDGKK, Type OLGJDHDOPKL, Type LKMNMMPMNHD, PlayerLoopSystem? MMGGEEDEPEM, PlayerLoopSystem? IBFOCKLBJFJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class HAILPGOFFDM
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum POGPAHCJMGA
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
	public class KOGOAIICGIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly POGPAHCJMGA DJNMKANPFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly OBLGEJBPIMA MKOBBNPGANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long HMNCNIJAMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private long KPODOAJPNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long HEKMCOPCIIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int MANKGBNBAPL;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69D51A0", Offset = "0x69D43A0", VA = "0x1869D51A0")]
		public KOGOAIICGIE(POGPAHCJMGA CLIAPELKLIB, int MBEAOMOFNFC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69D50E0", Offset = "0x69D42E0", VA = "0x1869D50E0")]
		public void GNLLPMECDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69D5150", Offset = "0x69D4350", VA = "0x1869D5150")]
		public void OMDPECFLBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69D4F00", Offset = "0x69D4100", VA = "0x1869D4F00")]
		public void BMGBHLHCCNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static POGPAHCJMGA[] MCJHBMELKHF;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static KOGOAIICGIE[] OFOIOFJDOFL;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69D0E50", Offset = "0x69D0050", VA = "0x1869D0E50")]
	public static KOGOAIICGIE KJMKAMLLJGO(POGPAHCJMGA GHBNLDGJPCB, int MBEAOMOFNFC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69D1030", Offset = "0x69D0230", VA = "0x1869D1030")]
	public static KOGOAIICGIE PLNICBOODAJ(POGPAHCJMGA GHBNLDGJPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x69D0DB0", Offset = "0x69CFFB0", VA = "0x1869D0DB0")]
	public static void IOMCECLCMMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class OBLGEJBPIMA : JKFBGCHCPDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public int LPIFGKKGKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Queue<double> AFKMDFGLAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double HBDGBCALKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double JDDCNPMIKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double NHACJLCGJAL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double BAOLDGCGFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69D7640", Offset = "0x69D6840", VA = "0x1869D7640", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double PBOAKHNJDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1865420", Offset = "0x1864620", VA = "0x181865420", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double JKKOBBDBJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4970", Offset = "0x1DC3B70", VA = "0x181DC4970", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69D77C0", Offset = "0x69D69C0", VA = "0x1869D77C0")]
	public OBLGEJBPIMA(int DMOFJFEAJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69D76A0", Offset = "0x69D68A0", VA = "0x1869D76A0", Slot = "7")]
	public void NFJLMJEKCKN(double FKBAIKAGEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x69D75D0", Offset = "0x69D67D0", VA = "0x1869D75D0", Slot = "8")]
	public void GKFNPGBHNDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HAFEDKCCJIG : JKFBGCHCPDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private long KMJOEPJMADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double DOINGLOLAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double POLOFCKLJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double OFJGNHBDAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double HLEENHPDGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double HBDGBCALKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private double JDDCNPMIKLE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double PBOAKHNJDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x57363D0", Offset = "0x57355D0", VA = "0x1857363D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JKKOBBDBJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5736430", Offset = "0x5735630", VA = "0x185736430", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double LAGEDCMNEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5736480", Offset = "0x5735680", VA = "0x185736480")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double BAOLDGCGFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x233D430", Offset = "0x233C630", VA = "0x18233D430", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69D0C60", Offset = "0x69CFE60", VA = "0x1869D0C60", Slot = "7")]
	public virtual void NFJLMJEKCKN(double FKBAIKAGEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69D0C20", Offset = "0x69CFE20", VA = "0x1869D0C20", Slot = "8")]
	public virtual void GKFNPGBHNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69D0D80", Offset = "0x69CFF80", VA = "0x1869D0D80")]
	public HAFEDKCCJIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NOBGGJJMKML : HAFEDKCCJIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double CNOOIEGLGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5736440", Offset = "0x5735640", VA = "0x185736440")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x57363E0", Offset = "0x57355E0", VA = "0x1857363E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x69D6CF0", Offset = "0x69D5EF0", VA = "0x1869D6CF0", Slot = "7")]
	public override void NFJLMJEKCKN(double FKBAIKAGEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x69D6CB0", Offset = "0x69D5EB0", VA = "0x1869D6CB0", Slot = "8")]
	public override void GKFNPGBHNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x69D0D80", Offset = "0x69CFF80", VA = "0x1869D0D80")]
	public NOBGGJJMKML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface JKFBGCHCPDO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double BAOLDGCGFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double PBOAKHNJDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double JKKOBBDBJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class JAKAAPMMBDP
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface ALGHIBKEFJH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool BNPHOMDKMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MHOCMODHEJI();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private abstract class JCGKNDGPFJH<TPromise, TMainThreadPromise> : ALGHIBKEFJH where TPromise : BCIJDCGHKGJ where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly TPromise EJPBLHAHGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly TMainThreadPromise HPMAOOGCACC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise BFCGAEEKFJD
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3BEBAC0", Offset = "0x3BEACC0", VA = "0x183BEBAC0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool BNPHOMDKMJF
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x3BEBB40", Offset = "0x3BEAD40", VA = "0x183BEBB40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8ED0", Offset = "0x7B80D0", VA = "0x1807B8ED0")]
		protected JCGKNDGPFJH(TPromise EJPBLHAHGGP, TMainThreadPromise KOIGOMMBOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3BEBB20", Offset = "0x3BEAD20", VA = "0x183BEBB20", Slot = "5")]
		public void MHOCMODHEJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void PEAMKMCHFAA(TPromise EJPBLHAHGGP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class GKBBFBMFIKI<T> : JCGKNDGPFJH<OCNPNNKFOAO<T>, CMFDFPCKGIA<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x387A180", Offset = "0x3879380", VA = "0x18387A180")]
		public GKBBFBMFIKI(OCNPNNKFOAO<T> EJPBLHAHGGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3879F50", Offset = "0x3879150", VA = "0x183879F50", Slot = "6")]
		protected override void PEAMKMCHFAA(OCNPNNKFOAO<T> EJPBLHAHGGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x377C6F0", Offset = "0x377B8F0", VA = "0x18377C6F0")]
		[CompilerGenerated]
		private void GACDBGPMOKM(T IFJGEIAONPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x387A150", Offset = "0x3879350", VA = "0x18387A150")]
		[CompilerGenerated]
		private void PJHGABEOLGO(string AABEEDLKHEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class KCHCGKACAKD : ALGHIBKEFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Action OFOIHENMFDE;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool BNPHOMDKMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
		public KCHCGKACAKD(Action OFOIHENMFDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xC31C70", Offset = "0xC30E70", VA = "0x180C31C70", Slot = "5")]
		public void MHOCMODHEJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly List<ALGHIBKEFJH> IFEJKGKPEIP;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x28D52E0", Offset = "0x28D44E0", VA = "0x1828D52E0")]
	public static OCNPNNKFOAO<T> BOPAHBOFJLE<T>(this OCNPNNKFOAO<T> EJPBLHAHGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x69D26E0", Offset = "0x69D18E0", VA = "0x1869D26E0")]
	public static void BOPAHBOFJLE(Action OFOIHENMFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x28D5340", Offset = "0x28D4540", VA = "0x1828D5340")]
	private static OCNPNNKFOAO<T> EHMDBKFEIHM<T>(OCNPNNKFOAO<T> EJPBLHAHGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69D2470", Offset = "0x69D1670", VA = "0x1869D2470")]
	private static void BDPMNGAIBEC(ALGHIBKEFJH JNJLGPCBFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69D2950", Offset = "0x69D1B50", VA = "0x1869D2950")]
	private static void NOAHCECOIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69D2780", Offset = "0x69D1980", VA = "0x1869D2780")]
	private static void ECBMJEBOMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x69D2880", Offset = "0x69D1A80", VA = "0x1869D2880")]
	private static void MABDEBEEMKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class ADAJCAMLOJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct BEIOCNOLPMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TaskCompletionSource<Scene> JAHHHCDICBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly string OGOHIBFAAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly LoadSceneMode CHMANNBEJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool FCJKBHLOHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly FMDPIFHBCJG<string>.BBMCKKPJOID NKAOGPCKJHO;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x69C4980", Offset = "0x69C3B80", VA = "0x1869C4980")]
		public BEIOCNOLPMF(TaskCompletionSource<Scene> JLBCNFNJHEH, string OGOHIBFAAOB, LoadSceneMode CHMANNBEJPC, bool FCJKBHLOHBJ, FMDPIFHBCJG<string>.BBMCKKPJOID NKAOGPCKJHO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct AGCCDEFFBKM : IAsyncStateMachine
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
		public FMDPIFHBCJG<string>.BBMCKKPJOID stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private FMDPIFHBCJG<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x69C18D0", Offset = "0x69C0AD0", VA = "0x1869C18D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x69C2170", Offset = "0x69C1370", VA = "0x1869C2170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct MOKPDDHFNBE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69D5E20", Offset = "0x69D5020", VA = "0x1869D5E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x69D6130", Offset = "0x69D5330", VA = "0x1869D6130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct DAMLDMAEPLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private BEIOCNOLPMF <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x69CAA10", Offset = "0x69C9C10", VA = "0x1869CAA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x69CADC0", Offset = "0x69C9FC0", VA = "0x1869CADC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class MOGILBNJAPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CMFDFPCKGIA<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public MOGILBNJAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x69D5DC0", Offset = "0x69D4FC0", VA = "0x1869D5DC0")]
		internal void IIBEIOPGIKB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct OLHHJKIMEMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public FMDPIFHBCJG<string>.BBMCKKPJOID stackTimer;

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
		private MOGILBNJAPO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private FMDPIFHBCJG<string>.BBMCKKPJOID <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private FMDPIFHBCJG<string>.BBMCKKPJOID <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x69D7B20", Offset = "0x69D6D20", VA = "0x1869D7B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69D86C0", Offset = "0x69D78C0", VA = "0x1869D86C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct BCMOJDKKCLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x69C4390", Offset = "0x69C3590", VA = "0x1869C4390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x69C4890", Offset = "0x69C3A90", VA = "0x1869C4890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct PLOJIMPNJHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public FMDPIFHBCJG<string>.BBMCKKPJOID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private FMDPIFHBCJG<string>.BBMCKKPJOID <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private FMDPIFHBCJG<string>.BBMCKKPJOID <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x69D9ED0", Offset = "0x69D90D0", VA = "0x1869D9ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x69DAA20", Offset = "0x69D9C20", VA = "0x1869DAA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class MGLNCGIBEDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public MGLNCGIBEDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69D5D90", Offset = "0x69D4F90", VA = "0x1869D5D90")]
		internal bool CKIGKNOIIBF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class HBOPDBOKEBD : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public EAEPIGKFFMI onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public HBOPDBOKEBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x69D1600", Offset = "0x69D0800", VA = "0x1869D1600", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x69D1280", Offset = "0x69D0480", VA = "0x1869D1280", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x69D1230", Offset = "0x69D0430", VA = "0x1869D1230")]
		private void KNOPPBKNOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69D15B0", Offset = "0x69D07B0", VA = "0x1869D15B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class LCCFFFCHPCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CMFDFPCKGIA<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public LCCFFFCHPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x69D52B0", Offset = "0x69D44B0", VA = "0x1869D52B0")]
		internal bool HBHAIIPGDPJ(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x69D5330", Offset = "0x69D4530", VA = "0x1869D5330")]
		internal void OINPCHNOKHG(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class AKPDNMJEHBK : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CMFDFPCKGIA<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private LCCFFFCHPCP <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public AKPDNMJEHBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x69C21E0", Offset = "0x69C13E0", VA = "0x1869C21E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x69C28D0", Offset = "0x69C1AD0", VA = "0x1869C28D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly ICollection<string> FNOPGLJBDGF;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static BCIJDCGHKGJ KLONCHDBICJ;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static AsyncOperation BFIGKMMODDB;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static BCIJDCGHKGJ GNOOBPKBOBJ;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static string AFJJMDPFIAD;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static ThreadPriority ICLOECCDFEG;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task POABHDKIKIP;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static List<SceneInstance> HGMPBDMNENC;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly Queue<BEIOCNOLPMF> MPKEBAPPJPG;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static Task ACENLBBDPKM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool BGEFOPDPIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69BF7E0", Offset = "0x69BE9E0", VA = "0x1869BF7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool KOCPFBODCIO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69C0910", Offset = "0x69BFB10", VA = "0x1869C0910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool HOEJALEPOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x69C0190", Offset = "0x69BF390", VA = "0x1869C0190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool ELOKNJEFNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x69BFAE0", Offset = "0x69BECE0", VA = "0x1869BFAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> NOGKEJODLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x69BFE40", Offset = "0x69BF040", VA = "0x1869BFE40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x69BFC10", Offset = "0x69BEE10", VA = "0x1869BFC10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x69BF9F0", Offset = "0x69BEBF0", VA = "0x1869BF9F0")]
	[LOEDIHPHLOK(JJHPCOMEMKL.EnteredEditModeNextFrame, 0)]
	private static void CNNKMPHMPKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x69C0640", Offset = "0x69BF840", VA = "0x1869C0640")]
	[AsyncStateMachine(typeof(AGCCDEFFBKM))]
	public static Task<Scene> KPBDMDOGLGA(string OGOHIBFAAOB, LoadSceneMode CHMANNBEJPC = LoadSceneMode.Single, bool FCJKBHLOHBJ = false, [Optional] FMDPIFHBCJG<string>.BBMCKKPJOID CBJMAAJLGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x69C0B10", Offset = "0x69BFD10", VA = "0x1869C0B10")]
	[AsyncStateMachine(typeof(MOKPDDHFNBE))]
	private static Task OCGKGIDCLJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x69C0C50", Offset = "0x69BFE50", VA = "0x1869C0C50")]
	[AsyncStateMachine(typeof(DAMLDMAEPLH))]
	private static Task OLEFIDIJNMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x69C0230", Offset = "0x69BF430", VA = "0x1869C0230")]
	[AsyncStateMachine(typeof(OLHHJKIMEMJ))]
	private static Task<Scene> KJJKJOBHOPD(string OGOHIBFAAOB, LoadSceneMode CHMANNBEJPC, bool FCJKBHLOHBJ, FMDPIFHBCJG<string>.BBMCKKPJOID NKAOGPCKJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69C09B0", Offset = "0x69BFBB0", VA = "0x1869C09B0")]
	private static void OBGALGKEPIL(SceneInstance KLPCJKOHLOK, LoadSceneMode CHMANNBEJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69BF720", Offset = "0x69BE920", VA = "0x1869BF720")]
	private static void AMPMAMDMPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x69BFD20", Offset = "0x69BEF20", VA = "0x1869BFD20")]
	[AsyncStateMachine(typeof(BCMOJDKKCLN))]
	private static Task<Scene> HELHPGIOJPC(string OGOHIBFAAOB, LoadSceneMode CHMANNBEJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x69C0D20", Offset = "0x69BFF20", VA = "0x1869C0D20")]
	private static bool PBMGOMGOONF(string OGOHIBFAAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x69BFF50", Offset = "0x69BF150", VA = "0x1869BFF50")]
	[AsyncStateMachine(typeof(PLOJIMPNJHH))]
	private static Task<Scene> JGJJGKGDKOL(FMDPIFHBCJG<string>.BBMCKKPJOID NKAOGPCKJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x69C0790", Offset = "0x69BF990", VA = "0x1869C0790")]
	public static OCNPNNKFOAO<Scene> LAHIMJBBHBD(string OGOHIBFAAOB, LoadSceneMode CHMANNBEJPC = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x69C0380", Offset = "0x69BF580", VA = "0x1869C0380")]
	public static BCIJDCGHKGJ KMJCMACLDHM(string OGOHIBFAAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x69C0BC0", Offset = "0x69BFDC0", VA = "0x1869C0BC0")]
	[IteratorStateMachine(typeof(HBOPDBOKEBD))]
	private static IEnumerator<AHKNJJJKEOF> ODLMFKAEKAF(string OGOHIBFAAOB, EAEPIGKFFMI GJBOJKDGKDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x69BFB70", Offset = "0x69BED70", VA = "0x1869BFB70")]
	[IteratorStateMachine(typeof(AKPDNMJEHBK))]
	private static IEnumerator<AHKNJJJKEOF> GCHGLHLFLJH(string OGOHIBFAAOB, LoadSceneMode CHMANNBEJPC, CMFDFPCKGIA<Scene> GJBOJKDGKDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69C0060", Offset = "0x69BF260", VA = "0x1869C0060")]
	public static bool JOKLAGIAGEE([Out] string JCNGANJJADD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LHFNCPFFDDB
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x69D5690", Offset = "0x69D4890", VA = "0x1869D5690")]
	public static IDisposable PDKCDKECHBP(this JMDKMEBHIKH DPGBKIGAHAN, float AOOLIOLPNLC, Action<float> LONIJHJPBBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x69D5610", Offset = "0x69D4810", VA = "0x1869D5610")]
	public static IDisposable ICBGAIMEIDG(this JMDKMEBHIKH DPGBKIGAHAN, Action<float> LONIJHJPBBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x69D5590", Offset = "0x69D4790", VA = "0x1869D5590")]
	public static IDisposable HBHFMGABOJM(this JMDKMEBHIKH DPGBKIGAHAN, Action<float> LONIJHJPBBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class CIFKNABAHGF
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x69C5FD0", Offset = "0x69C51D0", VA = "0x1869C5FD0")]
	public static IDisposable HCLMNNJLCLG(this MonoBehaviour BNBIONJEEEH, Action LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x69C6060", Offset = "0x69C5260", VA = "0x1869C6060")]
	public static IDisposable HCLMNNJLCLG(this MonoBehaviour BNBIONJEEEH, Action<float> LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x69C62D0", Offset = "0x69C54D0", VA = "0x1869C62D0")]
	public static IDisposable MOLHGBBEJOJ(this MonoBehaviour BNBIONJEEEH, Action LONIJHJPBBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x69C6610", Offset = "0x69C5810", VA = "0x1869C6610")]
	public static IDisposable PCGAADGDHNM(this MonoBehaviour BNBIONJEEEH, Action LONIJHJPBBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69C6690", Offset = "0x69C5890", VA = "0x1869C6690")]
	public static IDisposable PCGAADGDHNM(this MonoBehaviour BNBIONJEEEH, Action<float> LONIJHJPBBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x69C5CC0", Offset = "0x69C4EC0", VA = "0x1869C5CC0")]
	public static IDisposable EMNKGFJMOIC(this MonoBehaviour BNBIONJEEEH, Action LONIJHJPBBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x69C6350", Offset = "0x69C5550", VA = "0x1869C6350")]
	public static IDisposable MPFEGBDPHNG(this MonoBehaviour BNBIONJEEEH, Action LONIJHJPBBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x69C6590", Offset = "0x69C5790", VA = "0x1869C6590")]
	public static IDisposable OLFALEOCHIK(this MonoBehaviour BNBIONJEEEH, Action LONIJHJPBBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x69C5B70", Offset = "0x69C4D70", VA = "0x1869C5B70")]
	public static IDisposable ACOKGNHOFIC(this MonoBehaviour BNBIONJEEEH, float AOOLIOLPNLC, Action<float> LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL, bool MIEFAMJDOMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x69C6470", Offset = "0x69C5670", VA = "0x1869C6470")]
	public static IDisposable NHCAMOGGNBD(this MonoBehaviour BNBIONJEEEH, float AOOLIOLPNLC, Action<float> LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL, bool MIEFAMJDOMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x69C5D40", Offset = "0x69C4F40", VA = "0x1869C5D40")]
	public static IDisposable ENHNLFAPFNG(this MonoBehaviour BNBIONJEEEH, float AOOLIOLPNLC, Action<float> LONIJHJPBBI, bool MIEFAMJDOMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x69C5DE0", Offset = "0x69C4FE0", VA = "0x1869C5DE0")]
	public static IDisposable EOJJFGOGKIJ(this MonoBehaviour BNBIONJEEEH, Action<float> LONIJHJPBBI, bool MIEFAMJDOMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x69C5C20", Offset = "0x69C4E20", VA = "0x1869C5C20")]
	public static IDisposable CAELGMBFKGJ(this MonoBehaviour BNBIONJEEEH, Action<float> LONIJHJPBBI, bool MIEFAMJDOMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x69C6190", Offset = "0x69C5390", VA = "0x1869C6190")]
	public static IDisposable IFMIGEIHMBB(this MonoBehaviour BNBIONJEEEH, Action<float> LONIJHJPBBI, bool MIEFAMJDOMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69C5E80", Offset = "0x69C5080", VA = "0x1869C5E80")]
	public static IDisposable EPAOKLMMIPP(this MonoBehaviour BNBIONJEEEH, Action<float> LONIJHJPBBI, bool MIEFAMJDOMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x69C6230", Offset = "0x69C5430", VA = "0x1869C6230")]
	public static IDisposable LFDOMNHGALG(this MonoBehaviour BNBIONJEEEH, Action<float> LONIJHJPBBI, bool MIEFAMJDOMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x69C60F0", Offset = "0x69C52F0", VA = "0x1869C60F0")]
	public static IDisposable HMBFPDFPOPD(this MonoBehaviour BNBIONJEEEH, Action<float> LONIJHJPBBI, bool MIEFAMJDOMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x69C63D0", Offset = "0x69C55D0", VA = "0x1869C63D0")]
	public static IDisposable NEKOCHOADPD(this MonoBehaviour BNBIONJEEEH, Action<float> LONIJHJPBBI, bool MIEFAMJDOMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x69C5F20", Offset = "0x69C5120", VA = "0x1869C5F20")]
	public static IDisposable GCNDKNBNNCK(this MonoBehaviour BNBIONJEEEH, float AOOLIOLPNLC, Action<float> LONIJHJPBBI, bool MIEFAMJDOMD = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class EABIHPBANIE
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class LMEEHKJGPMP : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public OHNPMNDOFFO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private DIECEPJHGJN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public LMEEHKJGPMP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x69D5900", Offset = "0x69D4B00", VA = "0x1869D5900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x69D59E0", Offset = "0x69D4BE0", VA = "0x1869D59E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class OPKIPBAOFIM : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public OHNPMNDOFFO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private DIECEPJHGJN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public OPKIPBAOFIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x69D9B60", Offset = "0x69D8D60", VA = "0x1869D9B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x69D9C50", Offset = "0x69D8E50", VA = "0x1869D9C50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x69CB1E0", Offset = "0x69CA3E0", VA = "0x1869CB1E0")]
	public static CHAGHAGMDBI HCLMNNJLCLG(Action LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x69CB3B0", Offset = "0x69CA5B0", VA = "0x1869CB3B0")]
	public static CHAGHAGMDBI HCLMNNJLCLG(Behaviour DPGBKIGAHAN, Action LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x69CB290", Offset = "0x69CA490", VA = "0x1869CB290")]
	public static CHAGHAGMDBI HCLMNNJLCLG(Behaviour DPGBKIGAHAN, Action<float> LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x69CB500", Offset = "0x69CA700", VA = "0x1869CB500")]
	[IteratorStateMachine(typeof(LMEEHKJGPMP))]
	private static IEnumerator<AHKNJJJKEOF> OAHLACJGLDA(OHNPMNDOFFO DLDPCBBNGHJ, Action LONIJHJPBBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x69CB470", Offset = "0x69CA670", VA = "0x1869CB470")]
	[IteratorStateMachine(typeof(OPKIPBAOFIM))]
	private static IEnumerator<AHKNJJJKEOF> OAHLACJGLDA(OHNPMNDOFFO DLDPCBBNGHJ, Action<float> LONIJHJPBBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class PLNKFKANEML : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class KEHHFAODMHD : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public PLNKFKANEML <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public KEHHFAODMHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x69D4BA0", Offset = "0x69D3DA0", VA = "0x1869D4BA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3E30", VA = "0x1869D4C30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly OHNPMNDOFFO DLKMPOPEHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Action EICODCBMMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool BDDOEBHFFCJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool ANGKECGLEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B77B0", Offset = "0x7B69B0", VA = "0x1807B77B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x69D9DC0", Offset = "0x69D8FC0", VA = "0x1869D9DC0")]
	public PLNKFKANEML(OHNPMNDOFFO DLKMPOPEHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x69D9CA0", Offset = "0x69D8EA0", VA = "0x1869D9CA0")]
	[IteratorStateMachine(typeof(KEHHFAODMHD))]
	private IEnumerator<AHKNJJJKEOF> GMOEOGJBDPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x69D9D20", Offset = "0x69D8F20", VA = "0x1869D9D20", Slot = "4")]
	public void OnCompleted(Action AGOECHPGPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
	public void KDJAGEBEMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class AFKNNNCBDEF
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x69C15D0", Offset = "0x69C07D0", VA = "0x1869C15D0")]
	public static PLNKFKANEML ONNEONFHIAP(this OHNPMNDOFFO DLKMPOPEHOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class ADKCCAOPFAJ
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class BBFNEEJMACC : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public OKHPPBNGKJM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public BBFNEEJMACC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x69C42C0", Offset = "0x69C34C0", VA = "0x1869C42C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x69C4340", Offset = "0x69C3540", VA = "0x1869C4340", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x69C11E0", Offset = "0x69C03E0", VA = "0x1869C11E0")]
	public static CHAGHAGMDBI HCLMNNJLCLG(float AOOLIOLPNLC, Action<float> LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL, bool MIEFAMJDOMD = true, [Optional] HKMBNJGAHLP KJOCENHKPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69C10D0", Offset = "0x69C02D0", VA = "0x1869C10D0")]
	public static CHAGHAGMDBI HCLMNNJLCLG(MonoBehaviour BNBIONJEEEH, float AOOLIOLPNLC, Action<float> LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL, bool MIEFAMJDOMD = true, [Optional] HKMBNJGAHLP KJOCENHKPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x69C12E0", Offset = "0x69C04E0", VA = "0x1869C12E0")]
	public static CHAGHAGMDBI NOLPHCFOHND(MonoBehaviour BNBIONJEEEH, float AOOLIOLPNLC, Action<float> LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL, bool MIEFAMJDOMD = true, [Optional] HKMBNJGAHLP KJOCENHKPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x69C14C0", Offset = "0x69C06C0", VA = "0x1869C14C0")]
	public static CHAGHAGMDBI OMHECIBKMIA(JMDKMEBHIKH DPGBKIGAHAN, float AOOLIOLPNLC, Action<float> LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL, bool MIEFAMJDOMD = true, [Optional] HKMBNJGAHLP KJOCENHKPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x69C1400", Offset = "0x69C0600", VA = "0x1869C1400")]
	private static IEnumerator<AHKNJJJKEOF> OAHLACJGLDA(LPLIGCHBBNB NNJINHLABNJ, float AOOLIOLPNLC, OHNPMNDOFFO DLDPCBBNGHJ, Action<float> LONIJHJPBBI, bool MIEFAMJDOMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x69C0FE0", Offset = "0x69C01E0", VA = "0x1869C0FE0")]
	private static IEnumerator<AHKNJJJKEOF> DOBECOPJGAN(LPLIGCHBBNB NNJINHLABNJ, float AOOLIOLPNLC, OHNPMNDOFFO DLDPCBBNGHJ, Action<float> LONIJHJPBBI, bool MIEFAMJDOMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x69C1040", Offset = "0x69C0240", VA = "0x1869C1040")]
	[IteratorStateMachine(typeof(BBFNEEJMACC))]
	private static IEnumerator<AHKNJJJKEOF> GICBHEPFBBM(OKHPPBNGKJM BBKNCKKODEJ, float AOOLIOLPNLC, OHNPMNDOFFO DLDPCBBNGHJ, Action<float> LONIJHJPBBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class FGBFJIIHMJN
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class JMJMCEPNKCL : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public OHNPMNDOFFO queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public JMJMCEPNKCL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x69D2EE0", Offset = "0x69D20E0", VA = "0x1869D2EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x69D2FA0", Offset = "0x69D21A0", VA = "0x1869D2FA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x69CCA20", Offset = "0x69CBC20", VA = "0x1869CCA20")]
	[IteratorStateMachine(typeof(JMJMCEPNKCL))]
	private static IEnumerator<AHKNJJJKEOF> IFNLPNJJJEO(OHNPMNDOFFO DLKMPOPEHOL, Func<bool> NKMMDGAKEGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x69CC900", Offset = "0x69CBB00", VA = "0x1869CC900")]
	public static CHAGHAGMDBI GNKPBICEIGA(this MonoBehaviour BNBIONJEEEH, Func<bool> NKMMDGAKEGM, OHNPMNDOFFO DLKMPOPEHOL = OHNPMNDOFFO.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class NMPNGEKJMAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class IBHKPBMLGJO : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public OHNPMNDOFFO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public IBHKPBMLGJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x69D22B0", Offset = "0x69D14B0", VA = "0x1869D22B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x69D2320", Offset = "0x69D1520", VA = "0x1869D2320", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class GFALAJAHPBO : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public OHNPMNDOFFO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private AHKNJJJKEOF <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public GFALAJAHPBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x69CFCD0", Offset = "0x69CEED0", VA = "0x1869CFCD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x69CFD60", Offset = "0x69CEF60", VA = "0x1869CFD60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x69D6570", Offset = "0x69D5770", VA = "0x1869D6570")]
	[IteratorStateMachine(typeof(IBHKPBMLGJO))]
	private static IEnumerator<AHKNJJJKEOF> GMOEOGJBDPI(float AJKELOHAHIE, OHNPMNDOFFO DLDPCBBNGHJ, Action CMJCJMMJFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x69D64A0", Offset = "0x69D56A0", VA = "0x1869D64A0")]
	[IteratorStateMachine(typeof(GFALAJAHPBO))]
	private static IEnumerator<AHKNJJJKEOF> DDCCAOMEFGJ(float AJKELOHAHIE, OHNPMNDOFFO DLDPCBBNGHJ, Action CMJCJMMJFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x69D6A60", Offset = "0x69D5C60", VA = "0x1869D6A60")]
	public static IDisposable PIKKKMBGBBI(this MonoBehaviour BNBIONJEEEH, float AJKELOHAHIE, Action CMJCJMMJFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x69D66E0", Offset = "0x69D58E0", VA = "0x1869D66E0")]
	public static CHAGHAGMDBI HMAICIKHHLJ(this MonoBehaviour BNBIONJEEEH, float AJKELOHAHIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x69D6B80", Offset = "0x69D5D80", VA = "0x1869D6B80")]
	public static CHAGHAGMDBI PIKKKMBGBBI(this MonoBehaviour BNBIONJEEEH, float AJKELOHAHIE, OHNPMNDOFFO DLDPCBBNGHJ, Action CMJCJMMJFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x69D6970", Offset = "0x69D5B70", VA = "0x1869D6970")]
	public static CHAGHAGMDBI KMHEBBFFGFK(this MonoBehaviour BNBIONJEEEH, Action CMJCJMMJFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x69D6540", Offset = "0x69D5740", VA = "0x1869D6540")]
	public static CHAGHAGMDBI ENLEKNFADJD(this MonoBehaviour BNBIONJEEEH, Action CMJCJMMJFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x69D62F0", Offset = "0x69D54F0", VA = "0x1869D62F0")]
	public static CHAGHAGMDBI AKDIFMMKIDJ(this MonoBehaviour BNBIONJEEEH, Action CMJCJMMJFOB, [Optional] HKMBNJGAHLP KJOCENHKPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x69D67A0", Offset = "0x69D59A0", VA = "0x1869D67A0")]
	public static CHAGHAGMDBI IJHKMGEJEJN(this MonoBehaviour BNBIONJEEEH, Action CMJCJMMJFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x69D62C0", Offset = "0x69D54C0", VA = "0x1869D62C0")]
	public static CHAGHAGMDBI AAHDNNLKFGH(this MonoBehaviour BNBIONJEEEH, Action CMJCJMMJFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x69D68A0", Offset = "0x69D5AA0", VA = "0x1869D68A0")]
	private static CHAGHAGMDBI JPJECPCBJMN(MonoBehaviour BNBIONJEEEH, OHNPMNDOFFO DLKMPOPEHOL, Action CMJCJMMJFOB, [Optional] HKMBNJGAHLP KJOCENHKPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x69D6610", Offset = "0x69D5810", VA = "0x1869D6610")]
	public static CHAGHAGMDBI HLNAIKKHGEA(this MonoBehaviour BNBIONJEEEH, float EFBGHLANICN, Action CMJCJMMJFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x69D67D0", Offset = "0x69D59D0", VA = "0x1869D67D0")]
	public static CHAGHAGMDBI JDHOCFODFAM(this MonoBehaviour BNBIONJEEEH, float EFBGHLANICN, Action CMJCJMMJFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x69D6990", Offset = "0x69D5B90", VA = "0x1869D6990")]
	public static CHAGHAGMDBI OOAEOAOHFGK(this MonoBehaviour BNBIONJEEEH, float EFBGHLANICN, Action CMJCJMMJFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x69D63D0", Offset = "0x69D55D0", VA = "0x1869D63D0")]
	public static CHAGHAGMDBI CMHAKDPHMJM(this MonoBehaviour BNBIONJEEEH, float EFBGHLANICN, Action CMJCJMMJFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GOLMIDHFHME : GHNEFHPHOJG, IEnumerable<GHNEFHPHOJG>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly List<GHNEFHPHOJG> LGNELJJMPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool AAFJIFHKBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Action IGHKAOIIOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool FMOEGDAIEKB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PFBBNMODBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x69D06E0", Offset = "0x69CF8E0", VA = "0x1869D06E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BKKBENEKIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x69D08B0", Offset = "0x69CFAB0", VA = "0x1869D08B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x69D0810", Offset = "0x69CFA10", VA = "0x1869D0810", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x69D0950", Offset = "0x69CFB50", VA = "0x1869D0950")]
	public GOLMIDHFHME([Optional] Action IGHKAOIIOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x69D04D0", Offset = "0x69CF6D0", VA = "0x1869D04D0")]
	public void GHBEENLPKLN(GHNEFHPHOJG FNMNKHIOEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x69D0070", Offset = "0x69CF270", VA = "0x1869D0070")]
	private void DEMCGFELFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x69D04C0", Offset = "0x69CF6C0", VA = "0x1869D04C0", Slot = "7")]
	public bool GENEDOLCELE(bool HLOIBGCELIK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x69D01C0", Offset = "0x69CF3C0", VA = "0x1869D01C0", Slot = "8")]
	public bool GENEDOLCELE(Action OFOIHENMFDE, bool HLOIBGCELIK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x69D0660", Offset = "0x69CF860", VA = "0x1869D0660", Slot = "9")]
	public IEnumerator<GHNEFHPHOJG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x69D0660", Offset = "0x69CF860", VA = "0x1869D0660", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class JDLFBPDKGKN : EJCMFINNEBB
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class OLGLODCHDJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public JDLFBPDKGKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public OLGLODCHDJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x69CC6B0", Offset = "0x69CB8B0", VA = "0x1869CC6B0")]
		internal void OJPGOAOFOEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class FAGDBHHIBOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public JDLFBPDKGKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public FAGDBHHIBOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x69CC6B0", Offset = "0x69CB8B0", VA = "0x1869CC6B0")]
		internal void JFOCBBFDAMI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly float GHPIFLDKLKB;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x69CFE70", Offset = "0x69CF070", VA = "0x1869CFE70")]
	public JDLFBPDKGKN(Behaviour DPGBKIGAHAN, float GHPIFLDKLKB, [Optional] Action IGHKAOIIOOA, [Optional] HKMBNJGAHLP KJOCENHKPII, [Optional] LPLIGCHBBNB NNJINHLABNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x69D2DD0", Offset = "0x69D1FD0", VA = "0x1869D2DD0", Slot = "9")]
	protected override bool HFJGECAHIEH(Action OFOIHENMFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x69D2CC0", Offset = "0x69D1EC0", VA = "0x1869D2CC0", Slot = "10")]
	protected override bool DKJPFFDOFDC(Action OFOIHENMFDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface GHNEFHPHOJG
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool PFBBNMODBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BKKBENEKIAN;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GENEDOLCELE(bool HLOIBGCELIK = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GENEDOLCELE(Action OFOIHENMFDE, bool HLOIBGCELIK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class EJCMFINNEBB : GHNEFHPHOJG
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class LNENGPDFEEA : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public EJCMFINNEBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public LNENGPDFEEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x69D5A30", Offset = "0x69D4C30", VA = "0x1869D5A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x69D5B00", Offset = "0x69D4D00", VA = "0x1869D5B00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Behaviour DPGBKIGAHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action IGHKAOIIOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private GBBJKEKGBAN BLCBJHFABEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly HKMBNJGAHLP KJOCENHKPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	protected readonly LPLIGCHBBNB NNJINHLABNJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool PFBBNMODBHP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xF83030", Offset = "0xF82230", VA = "0x180F83030", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BKKBENEKIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x69CBBC0", Offset = "0x69CADC0", VA = "0x1869CBBC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x69CB8E0", Offset = "0x69CAAE0", VA = "0x1869CB8E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x69CBD20", Offset = "0x69CAF20", VA = "0x1869CBD20")]
	protected EJCMFINNEBB(Behaviour DPGBKIGAHAN, [Optional] Action IGHKAOIIOOA, [Optional] HKMBNJGAHLP KJOCENHKPII, [Optional] LPLIGCHBBNB NNJINHLABNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x69CB880", Offset = "0x69CAA80", VA = "0x1869CB880", Slot = "7")]
	public bool GENEDOLCELE(bool HLOIBGCELIK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x69CB820", Offset = "0x69CAA20", VA = "0x1869CB820", Slot = "8")]
	public bool GENEDOLCELE(Action OFOIHENMFDE, bool HLOIBGCELIK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool HFJGECAHIEH(Action OFOIHENMFDE);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool DKJPFFDOFDC(Action OFOIHENMFDE);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x69CB770", Offset = "0x69CA970", VA = "0x1869CB770")]
	protected void BKFOGPMNNKB(Action OFOIHENMFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x69CB980", Offset = "0x69CAB80", VA = "0x1869CB980")]
	protected BCIJDCGHKGJ IBDCMHEHDMN(float HNIIIDMFIPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x69CBCA0", Offset = "0x69CAEA0", VA = "0x1869CBCA0")]
	private void OFAKHKIOBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x69CB790", Offset = "0x69CA990", VA = "0x1869CB790")]
	[IteratorStateMachine(typeof(LNENGPDFEEA))]
	private IEnumerator<AHKNJJJKEOF> ECFHNGANFBN(float HNIIIDMFIPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x69CBC60", Offset = "0x69CAE60", VA = "0x1869CBC60")]
	[CompilerGenerated]
	private void LFOCDBHAOIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class JPIIBBLKDDB : EJCMFINNEBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float MCPJCDCJHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly int IEPCHNLAMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float AGINFJHJCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly float[] NEDFGKJHNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int MHBEKOBEODG;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x69D3540", Offset = "0x69D2740", VA = "0x1869D3540")]
	public JPIIBBLKDDB(Behaviour DPGBKIGAHAN, float JLCDFHDPLIO, int IEPCHNLAMKJ, [Optional] Action IGHKAOIIOOA, float AGINFJHJCHD = 0f, [Optional] HKMBNJGAHLP KJOCENHKPII, [Optional] LPLIGCHBBNB NNJINHLABNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "9")]
	protected override bool HFJGECAHIEH(Action OFOIHENMFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x69D32C0", Offset = "0x69D24C0", VA = "0x1869D32C0", Slot = "10")]
	protected override bool DKJPFFDOFDC(Action OFOIHENMFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x69D34C0", Offset = "0x69D26C0", VA = "0x1869D34C0")]
	private void PDABMCLMNJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class GLPANGADPBM : EJCMFINNEBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly float GHPIFLDKLKB;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x69CFE70", Offset = "0x69CF070", VA = "0x1869CFE70")]
	public GLPANGADPBM(Behaviour DPGBKIGAHAN, float GHPIFLDKLKB, [Optional] Action IGHKAOIIOOA, [Optional] HKMBNJGAHLP KJOCENHKPII, [Optional] LPLIGCHBBNB NNJINHLABNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "9")]
	protected override bool HFJGECAHIEH(Action OFOIHENMFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x69CFE30", Offset = "0x69CF030", VA = "0x1869CFE30", Slot = "10")]
	protected override bool DKJPFFDOFDC(Action OFOIHENMFDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class FLIKJCIHGOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GNOODBNBLKJ : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public GNOODBNBLKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x69CFFB0", Offset = "0x69CF1B0", VA = "0x1869CFFB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x69D0020", Offset = "0x69CF220", VA = "0x1869D0020", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private CHAGHAGMDBI GHBFAOIFNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private JMDKMEBHIKH DPGBKIGAHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Action<float> FEHHKKIHGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private OHNPMNDOFFO DLKMPOPEHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float BLAPMFLCKCC;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x69CFAF0", Offset = "0x69CECF0", VA = "0x1869CFAF0")]
	public FLIKJCIHGOH(JMDKMEBHIKH DPGBKIGAHAN, float AOOLIOLPNLC, Action<float> LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x69CF5C0", Offset = "0x69CE7C0", VA = "0x1869CF5C0")]
	private void GPDKNPONJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x69CF990", Offset = "0x69CEB90", VA = "0x1869CF990")]
	private void JIPALLIJBOB(string AABEEDLKHEA, Action JBBIKPKONLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x69CF760", Offset = "0x69CE960", VA = "0x1869CF760")]
	[IteratorStateMachine(typeof(GNOODBNBLKJ))]
	private IEnumerator<AHKNJJJKEOF> IBOGLNLEHMM(Action JBBIKPKONLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x69CF560", Offset = "0x69CE760", VA = "0x1869CF560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x69CF7E0", Offset = "0x69CE9E0", VA = "0x1869CF7E0")]
	[CompilerGenerated]
	private void JDOJNEMIGAD(string OGMFBLJMCMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class KCKMMJKMNFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class GOMOEGKFDKI : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public GOMOEGKFDKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x69CFFB0", Offset = "0x69CF1B0", VA = "0x1869CFFB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x69D09F0", Offset = "0x69CFBF0", VA = "0x1869D09F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private CHAGHAGMDBI GHBFAOIFNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private MonoBehaviour BNBIONJEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action LONIJHJPBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Action<float> FEHHKKIHGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private OHNPMNDOFFO DLKMPOPEHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float BLAPMFLCKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool MIEFAMJDOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly HKMBNJGAHLP KJOCENHKPII;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x69D4520", Offset = "0x69D3720", VA = "0x1869D4520")]
	public KCKMMJKMNFH(MonoBehaviour BNBIONJEEEH, Action LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL, [Optional] HKMBNJGAHLP KJOCENHKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x69D4710", Offset = "0x69D3910", VA = "0x1869D4710")]
	public KCKMMJKMNFH(MonoBehaviour BNBIONJEEEH, Action<float> LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL, [Optional] HKMBNJGAHLP KJOCENHKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x69D4950", Offset = "0x69D3B50", VA = "0x1869D4950")]
	public KCKMMJKMNFH(MonoBehaviour BNBIONJEEEH, float AOOLIOLPNLC, Action<float> LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL, bool MIEFAMJDOMD = true, [Optional] HKMBNJGAHLP KJOCENHKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1A16780", Offset = "0x1A15980", VA = "0x181A16780")]
	private KCKMMJKMNFH(HKMBNJGAHLP KJOCENHKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x69D39A0", Offset = "0x69D2BA0", VA = "0x1869D39A0")]
	internal static KCKMMJKMNFH CABABHAHGMI(MonoBehaviour BNBIONJEEEH, float AOOLIOLPNLC, Action<float> LONIJHJPBBI, OHNPMNDOFFO DLKMPOPEHOL, bool MIEFAMJDOMD = true, [Optional] HKMBNJGAHLP KJOCENHKPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x69D3E00", Offset = "0x69D3000", VA = "0x1869D3E00")]
	private void HCLMNNJLCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x69D3FF0", Offset = "0x69D31F0", VA = "0x1869D3FF0")]
	private void JBNBPHBECAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x69D3BC0", Offset = "0x69D2DC0", VA = "0x1869D3BC0")]
	private void GPDKNPONJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x69D41A0", Offset = "0x69D33A0", VA = "0x1869D41A0")]
	private void JGOJHNOBGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x69D4360", Offset = "0x69D3560", VA = "0x1869D4360")]
	private void JIPALLIJBOB(string AABEEDLKHEA, Action JBBIKPKONLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x69D3F70", Offset = "0x69D3170", VA = "0x1869D3F70")]
	[IteratorStateMachine(typeof(GOMOEGKFDKI))]
	private IEnumerator<AHKNJJJKEOF> IBOGLNLEHMM(Action JBBIKPKONLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x69D3B60", Offset = "0x69D2D60", VA = "0x1869D3B60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x69D3D70", Offset = "0x69D2F70", VA = "0x1869D3D70")]
	[CompilerGenerated]
	private void HBIJPGJFAMC(string OGMFBLJMCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x69D4490", Offset = "0x69D3690", VA = "0x1869D4490")]
	[CompilerGenerated]
	private void PLHCIFHGAHH(string OGMFBLJMCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x69D3AD0", Offset = "0x69D2CD0", VA = "0x1869D3AD0")]
	[CompilerGenerated]
	private void CAMAHDGAPKF(string OGMFBLJMCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x69D3910", Offset = "0x69D2B10", VA = "0x1869D3910")]
	[CompilerGenerated]
	private void AIIOGEFIIJO(string OGMFBLJMCMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Flags]
internal enum PKNNFFPJOCN : byte
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
internal sealed class HPMNJNKKGBC : LPLIGCHBBNB
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float DOHDJPEFMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x69D2290", Offset = "0x69D1490", VA = "0x1869D2290", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float HBOLPLFPJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x69D22A0", Offset = "0x69D14A0", VA = "0x1869D22A0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double JMLDAHHHDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x69D2200", Offset = "0x69D1400", VA = "0x1869D2200", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x69D2220", Offset = "0x69D1420", VA = "0x1869D2220")]
	[BDCLMMIIFOD(CIJFMPALMOO.None)]
	private static void AMDCJFPBGPG(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	[Preserve]
	internal HPMNJNKKGBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface OGPKKFBGLGA
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIFJGNHGBGF(string MPENHPFDCDK);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFIFNKIFCAB();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal interface GOPGBHLMMBG
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool MOOOKMKIDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool OHGCGAEDIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class ELPMFLNCNNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public FIDMDDBDLJL EDGHEEGHKBA;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int ABDHHHCLNNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7BE610", Offset = "0x7BD810", VA = "0x1807BE610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x69CC2B0", Offset = "0x69CB4B0", VA = "0x1869CC2B0")]
	public static AHKNJJJKEOF ONKONPKPBHL(IEnumerator<AHKNJJJKEOF> AELNFJILOEJ, BDAFBNMDGFA MKIEMKMJMHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x69CC410", Offset = "0x69CB610", VA = "0x1869CC410")]
	public AHKNJJJKEOF ONKONPKPBHL(BDAFBNMDGFA[] AGCHBGDMDCC, IEnumerator<AHKNJJJKEOF>[] ILLGEAGMMEJ, AHKNJJJKEOF[] HJCFFMMDPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x69CC000", Offset = "0x69CB200", VA = "0x1869CC000")]
	public void LFHNFMDFAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x69CC170", Offset = "0x69CB370", VA = "0x1869CC170")]
	public void NKEEGBKPAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x69CC030", Offset = "0x69CB230", VA = "0x1869CC030")]
	public void GKJJNHOIFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x69CC000", Offset = "0x69CB200", VA = "0x1869CC000")]
	public void FCFDEGOKGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public ELPMFLNCNNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class FIDMDDBDLJL
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct EEECFALCBII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public ELPMFLNCNNF DBJHGNJLICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public JMDKMEBHIKH CAJOPEHANJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public BDAFBNMDGFA EOAIMGBHGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<AHKNJJJKEOF> EHMLLCOFAND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AHKNJJJKEOF FLLAIENCDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public PKNNFFPJOCN BHEPOJMIFNM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct OJJNCCFCILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public OHNPMNDOFFO KDDPOKPKFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<EEECFALCBII> OKMMLIKDOAI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class OANBLJICLBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public BDAFBNMDGFA promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public FIDMDDBDLJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public JMDKMEBHIKH context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public ELPMFLNCNNF routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public PKNNFFPJOCN coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AHKNJJJKEOF currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<AHKNJJJKEOF> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public OANBLJICLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x69D6E20", Offset = "0x69D6020", VA = "0x1869D6E20")]
		internal void FPCIEHJLGFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class GNONPEBCHAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public ELPMFLNCNNF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public FIDMDDBDLJL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public GNONPEBCHAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x69CFF70", Offset = "0x69CF170", VA = "0x1869CFF70")]
		internal void LFBJILOEBHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class PODMOIMKBII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ELPMFLNCNNF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public FIDMDDBDLJL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public PODMOIMKBII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x69DAA90", Offset = "0x69D9C90", VA = "0x1869DAA90")]
		internal void IGMKHFGJKKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class FEIJCAGKOJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public ELPMFLNCNNF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public FIDMDDBDLJL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public FEIJCAGKOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x69CC8C0", Offset = "0x69CBAC0", VA = "0x1869CC8C0")]
		internal void FGMBACBNEBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const PKNNFFPJOCN PNAMDACADBF = PKNNFFPJOCN.Cancelled | PKNNFFPJOCN.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly OHNPMNDOFFO DLKMPOPEHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] EGPIDDAPGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<PKNNFFPJOCN> LMKFJMCIGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> OBELKEIMPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> IDGBLNEFHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> LBIIMLNJGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> LFLECKDIGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> DEEOKIAKOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> MGCEHINGMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private ELPMFLNCNNF[] LGEMLIMFPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private BDAFBNMDGFA[] AGCHBGDMDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private JMDKMEBHIKH[] BJAHGJJDFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<AHKNJJJKEOF>[] BGDOHOCIIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private AHKNJJJKEOF[] GAMLHGLDCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int CJFHCGIGDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int ONEEJBCNCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int HMLMMJABKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float HNIJDFOBPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private CJKBAPMOCLB GOLJMBKDBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle MPLFCKBJCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<ELPMFLNCNNF> INGHLDBDPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool IFKJIAJPHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> AKAMEAMHGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> KDOBCOLPAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool NLPFOABILHI;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public OJJNCCFCILJ[] NBMKFPNFDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA20B60", Offset = "0xA1FD60", VA = "0x180A20B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x69CDC00", Offset = "0x69CCE00", VA = "0x1869CDC00")]
	private static int MAHAJCBGNDF(OHNPMNDOFFO DLKMPOPEHOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x69CEE00", Offset = "0x69CE000", VA = "0x1869CEE00")]
	public FIDMDDBDLJL(OHNPMNDOFFO DLKMPOPEHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x69CD610", Offset = "0x69CC810", VA = "0x1869CD610")]
	private void IOIJLLIGENO(int JEBCNFHLAMG, int DGNMBBCAJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x69CD060", Offset = "0x69CC260", VA = "0x1869CD060")]
	public void EAOIBMIDFGL(JMDKMEBHIKH DPGBKIGAHAN, AHKNJJJKEOF AFOEDHEOODP, IEnumerator<AHKNJJJKEOF> AELNFJILOEJ, BDAFBNMDGFA MKIEMKMJMHI, [Optional] ELPMFLNCNNF BPPEBKPJMGL, PKNNFFPJOCN OHMIHKKDLKE = PKNNFFPJOCN.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x69CCE20", Offset = "0x69CC020", VA = "0x1869CCE20")]
	public void CPGDDCDOCPB(IEnumerable<EEECFALCBII> FCAHIELKAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x69CE510", Offset = "0x69CD710", VA = "0x1869CE510")]
	private EEECFALCBII NBCNDIBGHBG(int IOMFONNHJBG)
	{
		return default(EEECFALCBII);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x69CCAB0", Offset = "0x69CBCB0", VA = "0x1869CCAB0")]
	private void APIEJNBIJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x28791B0", Offset = "0x28783B0", VA = "0x1828791B0")]
	private static void ODPPLCGOPBG<T>(int IOMFONNHJBG, T[] ODENNHNENKO, int ANCJPCFOHBG, [Optional] T DHOOMPPGEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2879200", Offset = "0x2878400", VA = "0x182879200")]
	private static void ODPPLCGOPBG<T>(int IOMFONNHJBG, NativeArray<T> ODENNHNENKO, int ANCJPCFOHBG, [Optional] T DHOOMPPGEBF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x69CEA60", Offset = "0x69CDC60", VA = "0x1869CEA60")]
	private void ONHIIOCLOIC(IEnumerable<EEECFALCBII> FCAHIELKAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x69CE320", Offset = "0x69CD520", VA = "0x1869CE320")]
	private void MEELCFKLLLJ(EEECFALCBII AGEJKKLAMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x69CD7F0", Offset = "0x69CC9F0", VA = "0x1869CD7F0")]
	private LLEJNAPPPJA KJIKFHOBFOG(int LPAODLJACGG)
	{
		return default(LLEJNAPPPJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x69CD410", Offset = "0x69CC610", VA = "0x1869CD410")]
	public void IJBOMDKNACJ(float BHDDECHEFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x69CDB80", Offset = "0x69CCD80", VA = "0x1869CDB80")]
	private void LBCHJAFCNCA(Action LLLCBODKBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x69CE9E0", Offset = "0x69CDBE0", VA = "0x1869CE9E0")]
	private void OKKMHEFEAME(Action LLLCBODKBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x69CDC30", Offset = "0x69CCE30", VA = "0x1869CDC30")]
	public void MDLBBKPGJFF(float BHDDECHEFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x69CD310", Offset = "0x69CC510", VA = "0x1869CD310")]
	public void FMINDOPCMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x69CD1E0", Offset = "0x69CC3E0", VA = "0x1869CD1E0")]
	public void FCFDEGOKGAF(ELPMFLNCNNF BBKNCKKODEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x69CDA50", Offset = "0x69CCC50", VA = "0x1869CDA50")]
	public void KNDPGPILJHC(ELPMFLNCNNF BBKNCKKODEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x69CE3E0", Offset = "0x69CD5E0", VA = "0x1869CE3E0")]
	public void MJAKKGOHNNC(ELPMFLNCNNF BBKNCKKODEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class IOMAAHJECAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly IOMAAHJECAE NONABGLHMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Action JJKIGLNGDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private bool FKFJMFIPHOO;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public IOMAAHJECAE(Action JJKIGLNGDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x61EAEB0", Offset = "0x61EA0B0", VA = "0x1861EAEB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface LEBANFGCMJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T LJLHDNLHLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NAANBJBBHJI(UnityEngine.Object DPGBKIGAHAN, Action<T> PIPFELFELLC);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface MEMBIFAFPMN<T> : LEBANFGCMJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T LJLHDNLHLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GDELOEPANAK<T> : MEMBIFAFPMN<T>, LEBANFGCMJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class FNPONDILLBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public GDELOEPANAK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public JMPNLFGJEMK<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public FNPONDILLBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x37C3A50", Offset = "0x37C2C50", VA = "0x1837C3A50")]
		internal void MNEKJCEHKJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static GameObject NHCMCJLAAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<JMPNLFGJEMK<UnityEngine.Object, Action<T>>> ABMOODCDAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T PICEHMDGEHN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T LJLHDNLHLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x82DA00", Offset = "0x82CC00", VA = "0x18082DA00", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x38589C0", Offset = "0x3857BC0", VA = "0x1838589C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3859040", Offset = "0x3858240", VA = "0x183859040")]
	private static bool JEIKOEGKGII(T LLLCBODKBAN, T HIOEJKGFIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3859400", Offset = "0x3858600", VA = "0x183859400")]
	public GDELOEPANAK(T IPJDAPHPCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3859280", Offset = "0x3858480", VA = "0x183859280", Slot = "6")]
	public IDisposable NAANBJBBHJI(UnityEngine.Object DPGBKIGAHAN, Action<T> PIPFELFELLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3858D20", Offset = "0x3857F20", VA = "0x183858D20")]
	private void IFJKINEHMJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal class MGDMDIOHJGH : JPKCBKLCIBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly HKMBNJGAHLP KJOCENHKPII;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x69D5C70", Offset = "0x69D4E70", VA = "0x1869D5C70")]
	[BDCLMMIIFOD(CIJFMPALMOO.None)]
	private static void AMDCJFPBGPG(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	[Preserve]
	internal MGDMDIOHJGH([MINIJLJAKNC(null)] HKMBNJGAHLP KJOCENHKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x69D5CE0", Offset = "0x69D4EE0", VA = "0x1869D5CE0", Slot = "4")]
	public IDisposable ENHNLFAPFNG(float AOOLIOLPNLC, Action<float> CMMPHMKBCDC, bool MIEFAMJDOMD = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class BMKPLECPHMP : ONEPDGELCHK, HKMBNJGAHLP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private FIDMDDBDLJL[] HLOFNLNEKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private OGPKKFBGLGA NHBBKLFOBDK;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x69C51E0", Offset = "0x69C43E0", VA = "0x1869C51E0")]
	[BDCLMMIIFOD(CIJFMPALMOO.None)]
	private static void AMDCJFPBGPG(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x69C5AB0", Offset = "0x69C4CB0", VA = "0x1869C5AB0")]
	[Preserve]
	public BMKPLECPHMP([MINIJLJAKNC(null)] IALHLEBPDCN NLEPOECAMOB, [MINIJLJAKNC(null)] LPLIGCHBBNB NNJINHLABNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x69C5980", Offset = "0x69C4B80", VA = "0x1869C5980", Slot = "16")]
	public override CHAGHAGMDBI OGFMDIJOJKI(JMDKMEBHIKH DPGBKIGAHAN, IEnumerator<AHKNJJJKEOF> IOLKBKKBGJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x69C54D0", Offset = "0x69C46D0", VA = "0x1869C54D0", Slot = "17")]
	public override void GKFNPGBHNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x69C4E90", Offset = "0x69C4090", VA = "0x1869C4E90", Slot = "19")]
	public override void AEHKBHLPPBI(OHNPMNDOFFO DLKMPOPEHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x69C57E0", Offset = "0x69C49E0", VA = "0x1869C57E0", Slot = "18")]
	protected override void MOLHGBBEJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x69C5950", Offset = "0x69C4B50", VA = "0x1869C5950")]
	private FIDMDDBDLJL OBJCKLFKPJH(OHNPMNDOFFO MJMAEGDPBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x69C5250", Offset = "0x69C4450", VA = "0x1869C5250", Slot = "20")]
	internal override HLMCIJHIKEF CNFJLJHEEOJ(IEnumerator<AHKNJJJKEOF> IOLKBKKBGJI, Behaviour DPGBKIGAHAN, BDAFBNMDGFA MKIEMKMJMHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x69C5760", Offset = "0x69C4960", VA = "0x1869C5760", Slot = "21")]
	internal override ANHEAFCNCKK JOJNLLPGNMN(OHNPMNDOFFO DLDPCBBNGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x69C50C0", Offset = "0x69C42C0", VA = "0x1869C50C0")]
	private void AJEIBPCMFIO(FIDMDDBDLJL OEJADGHMBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x69C5470", Offset = "0x69C4670", VA = "0x1869C5470", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[BurstCompile]
internal struct CJKBAPMOCLB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public float ANKMONIJOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public int LNHPBNNHBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> EJCPEPCKONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> JMJCEIGLEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NativeArray<int> MHKIKJICCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<PKNNFFPJOCN> LFACCMHIBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[ReadOnly]
	public NativeArray<float> AMMEHEFLFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> LFLECKDIGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[WriteOnly]
	public NativeArray<int> IDGBLNEFHCB;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x69C67E0", Offset = "0x69C59E0", VA = "0x1869C67E0")]
	public static CJKBAPMOCLB DMOLILFLBFL(int FEHFFABEOKK, float BHDDECHEFPF, NativeArray<PKNNFFPJOCN> BLGBECGINKN, NativeArray<float> PKDCABPKPMG, NativeArray<int> HGOEDGFGBMO, NativeArray<int> KHCPKIMDGEI, NativeArray<int> KFOCMLFDKFG, NativeArray<int> JMJCEIGLEKL, NativeArray<int> MHKIKJICCKO)
	{
		return default(CJKBAPMOCLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x69C6840", Offset = "0x69C5A40", VA = "0x1869C6840", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x69C6C30", Offset = "0x69C5E30", VA = "0x1869C6C30")]
	private bool MHIMOLGKAAE(int MBGANDEDPDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x69C67B0", Offset = "0x69C59B0", VA = "0x1869C67B0")]
	private void BOGKNJBFPNE(NativeArray<int> NJKFGGCMEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x69C6710", Offset = "0x69C5910", VA = "0x1869C6710")]
	private int AJPALACJAHH(int GCJPDAMECKI, int ADLPGEBHMIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x69C6920", Offset = "0x69C5B20", VA = "0x1869C6920")]
	private void FHBJHJBLMAJ(NativeArray<int> NJKFGGCMEIF, int JKFNMLGFKHD, int COLCKPIEBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x69C69F0", Offset = "0x69C5BF0", VA = "0x1869C69F0")]
	private void KPHOAFEBNGA(NativeArray<int> NJKFGGCMEIF, int CJHFBOJKJML, int BEJCLNDAFHK, int JMMLGPIFOMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public abstract class ONEPDGELCHK : HKMBNJGAHLP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly IALHLEBPDCN NLEPOECAMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected readonly LPLIGCHBBNB NNJINHLABNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private ANHEAFCNCKK[] AHDNBELCCDM;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static HKMBNJGAHLP EELHBDDPCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x69D92C0", Offset = "0x69D84C0", VA = "0x1869D92C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool HKJFMKICGME
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OHNPMNDOFFO HDKPOHAFBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(OHNPMNDOFFO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BE610", Offset = "0x7BD810", VA = "0x1807BE610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LPLIGCHBBNB FEPKGHJMNND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AHKNJJJKEOF KCJMEJJPNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x69D95E0", Offset = "0x69D87E0", VA = "0x1869D95E0")]
	public static CHAGHAGMDBI PHDFLCFKPOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x69D9670", Offset = "0x69D8870", VA = "0x1869D9670")]
	[Preserve]
	protected ONEPDGELCHK([MINIJLJAKNC(null)] IALHLEBPDCN NLEPOECAMOB, [MINIJLJAKNC(null)] LPLIGCHBBNB NNJINHLABNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x69D9390", Offset = "0x69D8590", VA = "0x1869D9390", Slot = "6")]
	public CHAGHAGMDBI OFGPKDDGEPG(IEnumerator<AHKNJJJKEOF> IOLKBKKBGJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x69D93A0", Offset = "0x69D85A0", VA = "0x1869D93A0", Slot = "7")]
	public CHAGHAGMDBI OFGPKDDGEPG(Behaviour DPGBKIGAHAN, IEnumerator<AHKNJJJKEOF> IOLKBKKBGJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract CHAGHAGMDBI OGFMDIJOJKI(JMDKMEBHIKH DPGBKIGAHAN, IEnumerator<AHKNJJJKEOF> IOLKBKKBGJI);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x69D9090", Offset = "0x69D8290", VA = "0x1869D9090", Slot = "17")]
	public virtual void GKFNPGBHNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x69D8C40", Offset = "0x69D7E40", VA = "0x1869D8C40", Slot = "9")]
	public void FGGAKBBCFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x69D9310", Offset = "0x69D8510", VA = "0x1869D9310", Slot = "18")]
	protected virtual void MOLHGBBEJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x69D9070", Offset = "0x69D8270", VA = "0x1869D9070")]
	private void GDDFPPHGLFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x69D8C00", Offset = "0x69D7E00", VA = "0x1869D8C00")]
	private void ECADEJMPLOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x69D95C0", Offset = "0x69D87C0", VA = "0x1869D95C0")]
	private void PCGAADGDHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x69D8C20", Offset = "0x69D7E20", VA = "0x1869D8C20")]
	private void EMNKGFJMOIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x69D87C0", Offset = "0x69D79C0", VA = "0x1869D87C0")]
	private void AHAOFCLPKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x69D95A0", Offset = "0x69D87A0", VA = "0x1869D95A0")]
	private void OLJPFMONOJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x69D8E80", Offset = "0x69D8080", VA = "0x1869D8E80")]
	private void GABFACJEAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x69D8730", Offset = "0x69D7930", VA = "0x1869D8730", Slot = "19")]
	public virtual void AEHKBHLPPBI(OHNPMNDOFFO DLKMPOPEHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x69D8EA0", Offset = "0x69D80A0", VA = "0x1869D8EA0")]
	private void GCEMCAJJFHL(ANHEAFCNCKK OEJADGHMBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1D23E90", Offset = "0x1D23090", VA = "0x181D23E90")]
	private ANHEAFCNCKK BEFEMBNDELO(OHNPMNDOFFO MJMAEGDPBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract HLMCIJHIKEF CNFJLJHEEOJ(IEnumerator<AHKNJJJKEOF> IOLKBKKBGJI, Behaviour BNBIONJEEEH, BDAFBNMDGFA HCBHHFCEKDF);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract ANHEAFCNCKK JOJNLLPGNMN(OHNPMNDOFFO DLKMPOPEHOL);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x69D8840", Offset = "0x69D7A40", VA = "0x1869D8840", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x69D87E0", Offset = "0x69D79E0", VA = "0x1869D87E0", Slot = "12")]
	public AHKNJJJKEOF CHFKCFHMLKN(OHNPMNDOFFO DLDPCBBNGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x69D9230", Offset = "0x69D8430", VA = "0x1869D9230", Slot = "13")]
	public AHKNJJJKEOF JCOBOMCJPPN(float AJKELOHAHIE, OHNPMNDOFFO DLDPCBBNGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x69D9330", Offset = "0x69D8530", VA = "0x1869D9330", Slot = "14")]
	public AHKNJJJKEOF NEMABAOLGPK(Func<bool> NKMMDGAKEGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class HLMCIJHIKEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly BDAFBNMDGFA MKIEMKMJMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly GOPGBHLMMBG DPGBKIGAHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly bool BEFBJILCPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private string MPENHPFDCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private StackTrace ECIIKLMPILO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<AHKNJJJKEOF> EHMLLCOFAND
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public AHKNJJJKEOF FLLAIENCDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B32F0", VA = "0x1807B40F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool LDDCBECNNDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x69D1700", Offset = "0x69D0900", VA = "0x1869D1700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool JJFPKKGMONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x87F490", Offset = "0x87E690", VA = "0x18087F490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x87F5B0", Offset = "0x87E7B0", VA = "0x18087F5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x69D17D0", Offset = "0x69D09D0", VA = "0x1869D17D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float GFICNBNFFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x111EF10", Offset = "0x111E110", VA = "0x18111EF10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x57351E0", Offset = "0x57343E0", VA = "0x1857351E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x69D1D70", Offset = "0x69D0F70", VA = "0x1869D1D70")]
	public HLMCIJHIKEF(IEnumerator<AHKNJJJKEOF> AELNFJILOEJ, GOPGBHLMMBG DPGBKIGAHAN, BDAFBNMDGFA MKIEMKMJMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x69D1980", Offset = "0x69D0B80", VA = "0x1869D1980")]
	public AHKNJJJKEOF ONKONPKPBHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x69D1690", Offset = "0x69D0890", VA = "0x1869D1690")]
	public bool AMMAEMGMLBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x69D1780", Offset = "0x69D0980", VA = "0x1869D1780")]
	public void FCFDEGOKGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x69D1C90", Offset = "0x69D0E90", VA = "0x1869D1C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x910DF0", Offset = "0x90FFF0", VA = "0x180910DF0")]
	[CompilerGenerated]
	private void ACDBEEACDGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class BDAFBNMDGFA : AAGPBCCKGMO, CHAGHAGMDBI, GBBJKEKGBAN, BCIJDCGHKGJ, IEnumerator, AHKNJJJKEOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private OHNPMNDOFFO GMMFOBPOGPA;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private OHNPMNDOFFO GBHHBKIBFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xEADA90", Offset = "0xEACC90", VA = "0x180EADA90", Slot = "23")]
		get
		{
			return default(OHNPMNDOFFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public OHNPMNDOFFO EDGHEEGHKBA
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x13B42D0", Offset = "0x13B34D0", VA = "0x1813B42D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float PPLJOLMOKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8CACB0", Offset = "0x8C9EB0", VA = "0x1808CACB0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool GJBNMKPJNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x69C4910", Offset = "0x69C3B10", VA = "0x1869C4910", Slot = "24")]
	private bool OBIJNKGIEHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x69C4900", Offset = "0x69C3B00", VA = "0x1869C4900", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x69C4930", Offset = "0x69C3B30", VA = "0x1869C4930")]
	public BDAFBNMDGFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal enum LLEJNAPPPJA : byte
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
internal sealed class ANHEAFCNCKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum GGHKBJKNIPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public struct PNOBCMEKPGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public OHNPMNDOFFO KDDPOKPKFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public GGHKBJKNIPA PLGJHDFNPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public List<HLMCIJHIKEF> PFBEMKLKMJG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly GGHKBJKNIPA[] DJDNMFIPBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly OHNPMNDOFFO DLKMPOPEHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool MIGKHECNLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly HLMCIJHIKEF[] LDAJBDHHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<HLMCIJHIKEF> OINLJADJDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Stack<int> CFCBBLOJFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly List<HLMCIJHIKEF> ELKCLJICMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Stack<int> JHEHCELANJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly OGPKKFBGLGA MDNCJIINLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private bool NLPFOABILHI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public PNOBCMEKPGN[,] BDNHKEPIEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7B7520", Offset = "0x7B6720", VA = "0x1807B7520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x69C3E40", Offset = "0x69C3040", VA = "0x1869C3E40")]
	public ANHEAFCNCKK(OHNPMNDOFFO DLDPCBBNGHJ, OGPKKFBGLGA MDNCJIINLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x69C3620", Offset = "0x69C2820", VA = "0x1869C3620")]
	public void JNOOCPHFLFK(HLMCIJHIKEF AELNFJILOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x69C2920", Offset = "0x69C1B20", VA = "0x1869C2920")]
	public void ANJCJLHAAFM(IList<HLMCIJHIKEF> ILLGEAGMMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x69C2C10", Offset = "0x69C1E10", VA = "0x1869C2C10")]
	public void BMBOPDNJBBC(IList<HLMCIJHIKEF> ILLGEAGMMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x69C3160", Offset = "0x69C2360", VA = "0x1869C3160")]
	private void ELAPOKLJPJH(HLMCIJHIKEF AELNFJILOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x69C32B0", Offset = "0x69C24B0", VA = "0x1869C32B0")]
	private void FEFOLADCCJB(IList<HLMCIJHIKEF> ILLGEAGMMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x69C3890", Offset = "0x69C2A90", VA = "0x1869C3890")]
	private LLEJNAPPPJA OEPHPHHOAOF(HLMCIJHIKEF AELNFJILOEJ)
	{
		return default(LLEJNAPPPJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2920", VA = "0x1869C3720")]
	public void MOLHGBBEJOJ(float BHDDECHEFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x69C3430", Offset = "0x69C2630", VA = "0x1869C3430")]
	public void FGGAKBBCFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x69C3A10", Offset = "0x69C2C10", VA = "0x1869C3A10")]
	private void PBPBNFMBPOJ(List<HLMCIJHIKEF> ILLGEAGMMEJ, Stack<int> KEJDLAGONBN, bool OGKCPKAGOIM, float EPDKHOGHNAL = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x69C3040", Offset = "0x69C2240", VA = "0x1869C3040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x69C2F00", Offset = "0x69C2100", VA = "0x1869C2F00")]
	private void DMOOGKAPIID(List<HLMCIJHIKEF> ILLGEAGMMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class IMALBONGCAM : OGPKKFBGLGA
{
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "4")]
	public void JIFJGNHGBGF(string MPENHPFDCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
	public void NFIFNKIFCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public IMALBONGCAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal class HMNJEGLPBEC : GOPGBHLMMBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly Behaviour BNBIONJEEEH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x69D1F50", Offset = "0x69D1150", VA = "0x1869D1F50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MOOOKMKIDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x69D1FD0", Offset = "0x69D11D0", VA = "0x1869D1FD0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool OHGCGAEDIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x69D1F30", Offset = "0x69D1130", VA = "0x1869D1F30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public HMNJEGLPBEC(Behaviour BNBIONJEEEH)
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

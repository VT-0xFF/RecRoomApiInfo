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
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private delegate List<PlayerLoopSystem> GGAGJDMFKBL(List<PlayerLoopSystem> MNHBGCGMNLL, int IKMHPECLKKA);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct CHEJAGKCFGN
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct LEMIOOJOKJF
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static PEHINEDJEEO OBGAEKNNGED;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x72C0B40", Offset = "0x72BFB40", VA = "0x1872C0B40")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct BBMPLNFLDGD
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static PEHINEDJEEO LFIPIFONGGL;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x72AB5D0", Offset = "0x72AA5D0", VA = "0x1872AB5D0")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct AIJKJJPJMFJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static PEHINEDJEEO FADEPKCALHN;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x72AA3E0", Offset = "0x72A93E0", VA = "0x1872AA3E0")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct PONCJJGLDHL
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static PEHINEDJEEO MOMCODEKFFM;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static PEHINEDJEEO KANOHOLMDJI;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static PEHINEDJEEO ENAAAONDHDP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static PEHINEDJEEO ODKKPBPNLNI;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x72C5420", Offset = "0x72C4420", VA = "0x1872C5420")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct PDDIDLNGPBM
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static PEHINEDJEEO BAAAEEGGLKM;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x72C4660", Offset = "0x72C3660", VA = "0x1872C4660")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct FMHELGNNAOM
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static PEHINEDJEEO MOMCODEKFFM;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static PEHINEDJEEO KANOHOLMDJI;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static PEHINEDJEEO ENAAAONDHDP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static PEHINEDJEEO ODKKPBPNLNI;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x72B3E40", Offset = "0x72B2E40", VA = "0x1872B3E40")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct CEOIGPLPHBK
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static PEHINEDJEEO GDOMLBBGJLB;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x72ACFA0", Offset = "0x72ABFA0", VA = "0x1872ACFA0")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct AGAJPMDKDPI
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static PEHINEDJEEO ECFPEBMNBFG;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x72AA1E0", Offset = "0x72A91E0", VA = "0x1872AA1E0")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct LAAJCBFBGDA
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static PEHINEDJEEO DPJPALLNHAA;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x72C03B0", Offset = "0x72BF3B0", VA = "0x1872C03B0")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct FHBLCPHDEPE
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static PEHINEDJEEO HMNKHCJKEGN;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x72B3A50", Offset = "0x72B2A50", VA = "0x1872B3A50")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct GJGJHDEPMDK
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static PEHINEDJEEO OGAOCKMPHLL;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x72B6290", Offset = "0x72B5290", VA = "0x1872B6290")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct ODCKHKGGDJM
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static PEHINEDJEEO HPBFGLHHMHE;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x72C3040", Offset = "0x72C2040", VA = "0x1872C3040")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct INCDDMABOCP
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static PEHINEDJEEO AKKLDDHIBIA;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x72BCFF0", Offset = "0x72BBFF0", VA = "0x1872BCFF0")]
				public static PlayerLoopSystem GKHLJMEIJEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public enum OOBIAIKABCJ : byte
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
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct GOJGCHGDFAP
			{
				[Cpp2IlInjected.Token(Token = "0x2000021")]
				[CompilerGenerated]
				private sealed class OBNFJEDDEOJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public OOBIAIKABCJ updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
					public OBNFJEDDEOJ()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x72C2FC0", Offset = "0x72C1FC0", VA = "0x1872C2FC0")]
					internal void GFFPOJFMMAG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static HLGIBODIABL<OOBIAIKABCJ> OGLPCJBHMFA;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x72B6620", Offset = "0x72B5620", VA = "0x1872B6620")]
				public static PlayerLoopSystem GKHLJMEIJEE(OOBIAIKABCJ PHKCAMMAJIB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			internal struct IANPLJOJNCM
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				[CompilerGenerated]
				private sealed class CENPDOFOGGD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public KFOJIFEHBII.CCIOIABCFJA key;

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
					public CENPDOFOGGD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x72ACD60", Offset = "0x72ABD60", VA = "0x1872ACD60")]
					internal void GMMKNKLEKCK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable EAIFDIMBCBO;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x72BA0D0", Offset = "0x72B90D0", VA = "0x1872BA0D0")]
				public static PlayerLoopSystem PPBLLOHPCGP(KFOJIFEHBII.CCIOIABCFJA GMFCIHEFPPO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000025")]
			internal struct FKGLHDGIAJJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class KILMDMNKJCM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public KFOJIFEHBII.CCIOIABCFJA key;

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
					public KILMDMNKJCM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x72C00B0", Offset = "0x72BF0B0", VA = "0x1872C00B0")]
					internal void GMMKNKLEKCK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x72B3C50", Offset = "0x72B2C50", VA = "0x1872B3C50")]
				public static PlayerLoopSystem PPBLLOHPCGP(KFOJIFEHBII.CCIOIABCFJA GMFCIHEFPPO)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class JCJJOLHOIFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public JCJJOLHOIFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x72BD420", Offset = "0x72BC420", VA = "0x1872BD420")]
			internal List<PlayerLoopSystem> NMDMKDCMLAL(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool GEFNJOPIHFK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool NHECODGGMHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x72AE390", Offset = "0x72AD390", VA = "0x1872AE390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72AE590", Offset = "0x72AD590", VA = "0x1872AE590")]
		private static void JCMEJNJDPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72AD2E0", Offset = "0x72AC2E0", VA = "0x1872AD2E0")]
		private static void AHINBGOEODK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72ADBF0", Offset = "0x72ACBF0", VA = "0x1872ADBF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72ADC30", Offset = "0x72ACC30", VA = "0x1872ADC30")]
		private static void BBPIKDECHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72AE3D0", Offset = "0x72AD3D0", VA = "0x1872AE3D0")]
		private static void GLLOIPEHGON(KFOJIFEHBII.CCIOIABCFJA GMFCIHEFPPO, PlayerLoopSystem PCLFOMLABIC, Type ADELBFNNLAD, Type PCFKODJKFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72ADFB0", Offset = "0x72ACFB0", VA = "0x1872ADFB0")]
		private static void CBJKCMDCDAI(PlayerLoopSystem PCLFOMLABIC, Type ADELBFNNLAD, Type PCFKODJKFID, GGAGJDMFKBL FPOIDICJLAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72ADE80", Offset = "0x72ACE80", VA = "0x1872ADE80")]
		private static void CBEAGEPAEJH(PlayerLoopSystem PCLFOMLABIC, Type ADELBFNNLAD, Type PCFKODJKFID, PlayerLoopSystem? MMFOEDHIDPF, PlayerLoopSystem? DELCKDJHGEG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class KFOJIFEHBII
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum CCIOIABCFJA
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

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JFHEOCFEANE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly CCIOIABCFJA GHBOMBCCGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly CEEGFOPJJKM JDFNFLAPAFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long IJCEAIKNCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long CPABDKAKIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long JOKGOEOFOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int ENDDKHMMFPC;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x72BDB40", Offset = "0x72BCB40", VA = "0x1872BDB40")]
		public JFHEOCFEANE(CCIOIABCFJA DGFAEHGEDFG, int NNLBBJFKJNA = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x72BD8A0", Offset = "0x72BC8A0", VA = "0x1872BD8A0")]
		public void LNEAJEBAENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72BD910", Offset = "0x72BC910", VA = "0x1872BD910")]
		public void NBNHBHIDNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72BD960", Offset = "0x72BC960", VA = "0x1872BD960")]
		public void POBKGBBEPHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static CCIOIABCFJA[] NNFGDHAHFHI;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static JFHEOCFEANE[] EJBCGNCOPBB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x72BFCC0", Offset = "0x72BECC0", VA = "0x1872BFCC0")]
	public static JFHEOCFEANE IPJBMKBOGPP(CCIOIABCFJA GMFCIHEFPPO, int NNLBBJFKJNA = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72BFEA0", Offset = "0x72BEEA0", VA = "0x1872BFEA0")]
	public static JFHEOCFEANE PKCMEPLMAMO(CCIOIABCFJA GMFCIHEFPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72BFC20", Offset = "0x72BEC20", VA = "0x1872BFC20")]
	public static void CDNMAJAJIFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class CEEGFOPJJKM : LKABGDOCAFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int BGGDGDHHFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> KNGAAJEPAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double EGMGMOAFAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double LJPDMCKLOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double OHBLLHKDFGP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double NCOMAICFHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72ACA20", Offset = "0x72ABA20", VA = "0x1872ACA20", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double OMPFBIPHIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1B6DC40", Offset = "0x1B6CC40", VA = "0x181B6DC40", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BEBLGGDBNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4AE0", Offset = "0x1FA3AE0", VA = "0x181FA4AE0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72ACBA0", Offset = "0x72ABBA0", VA = "0x1872ACBA0")]
	public CEEGFOPJJKM(int HFPDBPHAKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72ACA80", Offset = "0x72ABA80", VA = "0x1872ACA80", Slot = "7")]
	public void IIHBGCPGAIA(double AAINAOCHJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x72AC9B0", Offset = "0x72AB9B0", VA = "0x1872AC9B0", Slot = "8")]
	public void CLDDABPDPLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class DBGGBMKHHGP : LKABGDOCAFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long DOPPKGNLPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double LJCIKDAAFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double KLFPCFPPDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double PJJIJHNGBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double CJLNDLKGGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double EGMGMOAFAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double LJPDMCKLOMA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double OMPFBIPHIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5EFD2F0", Offset = "0x5EFC2F0", VA = "0x185EFD2F0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BEBLGGDBNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5EFD330", Offset = "0x5EFC330", VA = "0x185EFD330", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double IIHNHJPCLDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5EFD7A0", Offset = "0x5EFC7A0", VA = "0x185EFD7A0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double NCOMAICFHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x25A8E40", Offset = "0x25A7E40", VA = "0x1825A8E40", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72B1230", Offset = "0x72B0230", VA = "0x1872B1230", Slot = "7")]
	public virtual void IIHBGCPGAIA(double AAINAOCHJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x72B11F0", Offset = "0x72B01F0", VA = "0x1872B11F0", Slot = "8")]
	public virtual void CLDDABPDPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x72B1350", Offset = "0x72B0350", VA = "0x1872B1350")]
	public DBGGBMKHHGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class KBIHDNHHLNB : DBGGBMKHHGP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double PNPLCCGFHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5EFD2D0", Offset = "0x5EFC2D0", VA = "0x185EFD2D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5EFD790", Offset = "0x5EFC790", VA = "0x185EFD790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72BFAF0", Offset = "0x72BEAF0", VA = "0x1872BFAF0", Slot = "7")]
	public override void IIHBGCPGAIA(double AAINAOCHJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72BFAB0", Offset = "0x72BEAB0", VA = "0x1872BFAB0", Slot = "8")]
	public override void CLDDABPDPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x72B1350", Offset = "0x72B0350", VA = "0x1872B1350")]
	public KBIHDNHHLNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface LKABGDOCAFK
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double NCOMAICFHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double OMPFBIPHIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double BEBLGGDBNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MEENMPJGICG
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private interface OPPGPPPOHGN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool ILGBEHMKBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DLAELEJPAOG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private abstract class GNKJPBIDDDA<TPromise, TMainThreadPromise> : OPPGPPPOHGN where TPromise : OBDNBLKJHLC where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly TPromise HHJDMJHKMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected readonly TMainThreadPromise KKBNGAIFPBE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise OHFIDENHFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3D94930", Offset = "0x3D93930", VA = "0x183D94930")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ILGBEHMKBEP
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3D948C0", Offset = "0x3D938C0", VA = "0x183D948C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x857060", Offset = "0x856060", VA = "0x180857060")]
		protected GNKJPBIDDDA(TPromise HHJDMJHKMJG, TMainThreadPromise ACCNKJOLGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3D94910", Offset = "0x3D93910", VA = "0x183D94910", Slot = "5")]
		public void DLAELEJPAOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void MBLEKCMFFEL(TPromise HHJDMJHKMJG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class LEDAIOHMCDJ<T> : GNKJPBIDDDA<EPEDBCONEGO<T>, DHBDANMFKCI<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x42E4C70", Offset = "0x42E3C70", VA = "0x1842E4C70")]
		public LEDAIOHMCDJ(EPEDBCONEGO<T> HHJDMJHKMJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x42E4B20", Offset = "0x42E3B20", VA = "0x1842E4B20", Slot = "6")]
		protected override void MBLEKCMFFEL(EPEDBCONEGO<T> HHJDMJHKMJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3D7ED50", Offset = "0x3D7DD50", VA = "0x183D7ED50")]
		[CompilerGenerated]
		private void CODMCKKHLAD(T KNFGDDANCCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x42E4AD0", Offset = "0x42E3AD0", VA = "0x1842E4AD0")]
		[CompilerGenerated]
		private void CFDKIBPAMFN(string EHELKEOJPOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class ABDPJAFHBEH : OPPGPPPOHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Action JFOAFIPDIOA;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ILGBEHMKBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
		public ABDPJAFHBEH(Action JFOAFIPDIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA13880", Offset = "0xA12880", VA = "0x180A13880", Slot = "5")]
		public void DLAELEJPAOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<OPPGPPPOHGN> OFHLNFKOBOO;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D9B0", Offset = "0x2C9C9B0", VA = "0x182C9D9B0")]
	public static EPEDBCONEGO<T> ODPDMALBBOB<T>(this EPEDBCONEGO<T> HHJDMJHKMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x72C1FD0", Offset = "0x72C0FD0", VA = "0x1872C1FD0")]
	public static void ODPDMALBBOB(Action JFOAFIPDIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D8C0", Offset = "0x2C9C8C0", VA = "0x182C9D8C0")]
	private static EPEDBCONEGO<T> FANENKFEJCK<T>(EPEDBCONEGO<T> HHJDMJHKMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72C1900", Offset = "0x72C0900", VA = "0x1872C1900")]
	private static void IJEINPOGKCF(OPPGPPPOHGN CAJNHIIINHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72C1B10", Offset = "0x72C0B10", VA = "0x1872C1B10")]
	private static void JOIKPKFNHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72C1ED0", Offset = "0x72C0ED0", VA = "0x1872C1ED0")]
	private static void LHCNCJCPCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x72C1DF0", Offset = "0x72C0DF0", VA = "0x1872C1DF0")]
	private static void KFGMONLEHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class JGJNPFKHLNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct DABOHONFEGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public TaskCompletionSource<Scene> CLCJCAINMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly string FEBNLODCIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly LoadSceneMode AAHPHOGFNDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly bool FMIADNGFDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72B1190", Offset = "0x72B0190", VA = "0x1872B1190")]
		public DABOHONFEGA(TaskCompletionSource<Scene> BBGHNPFEHON, string FEBNLODCIFJ, LoadSceneMode AAHPHOGFNDH, bool FMIADNGFDCN, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct BOAOKLHFCEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private KLCBNGOGDPF<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x72AB980", Offset = "0x72AA980", VA = "0x1872AB980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x72AC220", Offset = "0x72AB220", VA = "0x1872AC220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct ANIMJPOICCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x72AB220", Offset = "0x72AA220", VA = "0x1872AB220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72AB540", Offset = "0x72AA540", VA = "0x1872AB540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct LCCILIJKFCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private DABOHONFEGA <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x72C05F0", Offset = "0x72BF5F0", VA = "0x1872C05F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x72C09A0", Offset = "0x72BF9A0", VA = "0x1872C09A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class JFDABHGILBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public DHBDANMFKCI<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JFDABHGILBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72BD840", Offset = "0x72BC840", VA = "0x1872BD840")]
		internal void ECBBLMODCHJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct AJFNBIKAFOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private JFDABHGILBH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x72AA5E0", Offset = "0x72A95E0", VA = "0x1872AA5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x72AB180", Offset = "0x72AA180", VA = "0x1872AB180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct MHNHJPPODNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x72C2100", Offset = "0x72C1100", VA = "0x1872C2100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72C25D0", Offset = "0x72C15D0", VA = "0x1872C25D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct POHCAHKBMNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72C4860", Offset = "0x72C3860", VA = "0x1872C4860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72C53B0", Offset = "0x72C43B0", VA = "0x1872C53B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class BBBOFAOHAJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public BBBOFAOHAJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72AB5A0", Offset = "0x72AA5A0", VA = "0x1872AB5A0")]
		internal bool ODGPJLCJEGE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class JNFGENDELIA : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public NEIBFFKKMCM onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public JNFGENDELIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72BFA20", Offset = "0x72BEA20", VA = "0x1872BFA20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x72BF690", Offset = "0x72BE690", VA = "0x1872BF690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x72BF640", Offset = "0x72BE640", VA = "0x1872BF640")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x72BF9D0", Offset = "0x72BE9D0", VA = "0x1872BF9D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class JEDFLPOACBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public DHBDANMFKCI<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JEDFLPOACBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x72BD7C0", Offset = "0x72BC7C0", VA = "0x1872BD7C0")]
		internal bool PFLHJCHBIOI(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x72BD540", Offset = "0x72BC540", VA = "0x1872BD540")]
		internal void MIECGNNNDCG(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class GPFKBDLADAF : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public DHBDANMFKCI<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private JEDFLPOACBF <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public GPFKBDLADAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x72B67F0", Offset = "0x72B57F0", VA = "0x1872B67F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x72B6E70", Offset = "0x72B5E70", VA = "0x1872B6E70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly ICollection<string> FFAGJEMGNAB;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static OBDNBLKJHLC LKDIGGJKLCF;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static AsyncOperation AAKMIBFHFBM;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static OBDNBLKJHLC GPBOIECMPKC;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static string FEJFPLDIEIK;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static ThreadPriority ILGPGGMMKGE;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task HLBDCBOLICD;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static List<SceneInstance> LHGMJHKKBLK;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Queue<DABOHONFEGA> HAJANOHELNA;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Task KFPIBPMMKHO;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool DKFFNJHLGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x72BEEA0", Offset = "0x72BDEA0", VA = "0x1872BEEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool PLOJOEJOOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x72BEE00", Offset = "0x72BDE00", VA = "0x1872BEE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool LKFHFFFEJJP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x72BE070", Offset = "0x72BD070", VA = "0x1872BE070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool NANCNJAIJJC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x72BDC50", Offset = "0x72BCC50", VA = "0x1872BDC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> ACIFBIIEKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72BE530", Offset = "0x72BD530", VA = "0x1872BE530")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72BE640", Offset = "0x72BD640", VA = "0x1872BE640")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x72BF350", Offset = "0x72BE350", VA = "0x1872BF350")]
	[HMFADHOHJJA(NHNHBJDDABK.EnteredEditModeNextFrame, 0)]
	private static void PBCHCGBNBGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x72BE2F0", Offset = "0x72BD2F0", VA = "0x1872BE2F0")]
	[AsyncStateMachine(typeof(BOAOKLHFCEB))]
	public static Task<Scene> GKOKEHJKDGL(string FEBNLODCIFJ, LoadSceneMode AAHPHOGFNDH = LoadSceneMode.Single, bool FMIADNGFDCN = false, [Optional] KLCBNGOGDPF<string>.BPJNBAPCFPO AFFGLOKHNOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x72BE240", Offset = "0x72BD240", VA = "0x1872BE240")]
	[AsyncStateMachine(typeof(ANIMJPOICCC))]
	private static Task GJPADMAGOEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x72BDDE0", Offset = "0x72BCDE0", VA = "0x1872BDDE0")]
	[AsyncStateMachine(typeof(LCCILIJKFCK))]
	private static Task CLCEKOOGECD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x72BECB0", Offset = "0x72BDCB0", VA = "0x1872BECB0")]
	[AsyncStateMachine(typeof(AJFNBIKAFOF))]
	private static Task<Scene> LICIOMBOLFJ(string FEBNLODCIFJ, LoadSceneMode AAHPHOGFNDH, bool FMIADNGFDCN, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x72BDCE0", Offset = "0x72BCCE0", VA = "0x1872BDCE0")]
	private static void CKPFOMCCCPP(SceneInstance KCAPGDAGEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x72BE750", Offset = "0x72BD750", VA = "0x1872BE750")]
	private static void IEPMDIHHHCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x72BDEB0", Offset = "0x72BCEB0", VA = "0x1872BDEB0")]
	[AsyncStateMachine(typeof(MHNHJPPODNN))]
	private static Task<Scene> DENBMKLOOFN(string FEBNLODCIFJ, LoadSceneMode AAHPHOGFNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x72BE440", Offset = "0x72BD440", VA = "0x1872BE440")]
	private static bool GMDKPABHLAE(string FEBNLODCIFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x72BF240", Offset = "0x72BE240", VA = "0x1872BF240")]
	[AsyncStateMachine(typeof(POHCAHKBMNE))]
	private static Task<Scene> PABACFGIBJI(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x72BF0C0", Offset = "0x72BE0C0", VA = "0x1872BF0C0")]
	public static EPEDBCONEGO<Scene> OFHNMFFPNHK(string FEBNLODCIFJ, LoadSceneMode AAHPHOGFNDH = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x72BE9E0", Offset = "0x72BD9E0", VA = "0x1872BE9E0")]
	public static OBDNBLKJHLC ILKBLEGCIJE(string FEBNLODCIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x72BE950", Offset = "0x72BD950", VA = "0x1872BE950")]
	[IteratorStateMachine(typeof(JNFGENDELIA))]
	private static IEnumerator<FAKEPIEMOLB> IGNKOOMMNFB(string FEBNLODCIFJ, NEIBFFKKMCM OMCICLIHNDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x72BDFD0", Offset = "0x72BCFD0", VA = "0x1872BDFD0")]
	[IteratorStateMachine(typeof(GPFKBDLADAF))]
	private static IEnumerator<FAKEPIEMOLB> EGOFDJMHOOH(string FEBNLODCIFJ, LoadSceneMode AAHPHOGFNDH, DHBDANMFKCI<Scene> OMCICLIHNDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x72BE110", Offset = "0x72BD110", VA = "0x1872BE110")]
	public static bool GFEAHNGJICE([Out] string MFKONNMHFJB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GNNFMANOEGC
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x72B6510", Offset = "0x72B5510", VA = "0x1872B6510")]
	public static IDisposable GOBEGHGDNKK(this PMEANFDAKDJ PDLLDMABKGP, float NHAHIBOLKFP, Action<float> CIHODCMNLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x72B65A0", Offset = "0x72B55A0", VA = "0x1872B65A0")]
	public static IDisposable IIOFGCCICPA(this PMEANFDAKDJ PDLLDMABKGP, Action<float> CIHODCMNLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x72B6490", Offset = "0x72B5490", VA = "0x1872B6490")]
	public static IDisposable FNGOMMDAMCJ(this PMEANFDAKDJ PDLLDMABKGP, Action<float> CIHODCMNLEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class ECCFGCHDMJO
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x72B3570", Offset = "0x72B2570", VA = "0x1872B3570")]
	public static IDisposable MHENPBGMIMI(this MonoBehaviour PCDPAPNKMFB, Action CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x72B3600", Offset = "0x72B2600", VA = "0x1872B3600")]
	public static IDisposable MHENPBGMIMI(this MonoBehaviour PCDPAPNKMFB, Action<float> CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x72B30C0", Offset = "0x72B20C0", VA = "0x1872B30C0")]
	public static IDisposable GACAEOGENLN(this MonoBehaviour PCDPAPNKMFB, Action CIHODCMNLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x72B2FC0", Offset = "0x72B1FC0", VA = "0x1872B2FC0")]
	public static IDisposable FKADPNLKBOK(this MonoBehaviour PCDPAPNKMFB, Action CIHODCMNLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x72B3040", Offset = "0x72B2040", VA = "0x1872B3040")]
	public static IDisposable FKADPNLKBOK(this MonoBehaviour PCDPAPNKMFB, Action<float> CIHODCMNLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x72B2EA0", Offset = "0x72B1EA0", VA = "0x1872B2EA0")]
	public static IDisposable CKPHNMOIKMP(this MonoBehaviour PCDPAPNKMFB, Action CIHODCMNLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x72B3280", Offset = "0x72B2280", VA = "0x1872B3280")]
	public static IDisposable GFPBPPDLFFN(this MonoBehaviour PCDPAPNKMFB, Action CIHODCMNLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x72B34F0", Offset = "0x72B24F0", VA = "0x1872B34F0")]
	public static IDisposable LHBEDPAJMOI(this MonoBehaviour PCDPAPNKMFB, Action CIHODCMNLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x72B37D0", Offset = "0x72B27D0", VA = "0x1872B37D0")]
	public static IDisposable PJBICIJFNKM(this MonoBehaviour PCDPAPNKMFB, float NHAHIBOLKFP, Action<float> CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO, bool EFIIPLCIKJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x72B2D80", Offset = "0x72B1D80", VA = "0x1872B2D80")]
	public static IDisposable BNBMGADPGJG(this MonoBehaviour PCDPAPNKMFB, float NHAHIBOLKFP, Action<float> CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO, bool EFIIPLCIKJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x72B2F20", Offset = "0x72B1F20", VA = "0x1872B2F20")]
	public static IDisposable FGIEGAGHFJD(this MonoBehaviour PCDPAPNKMFB, float NHAHIBOLKFP, Action<float> CIHODCMNLEG, bool EFIIPLCIKJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x72B3690", Offset = "0x72B2690", VA = "0x1872B3690")]
	public static IDisposable MKFMHOGNEDM(this MonoBehaviour PCDPAPNKMFB, Action<float> CIHODCMNLEG, bool EFIIPLCIKJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x72B3140", Offset = "0x72B2140", VA = "0x1872B3140")]
	public static IDisposable GEFINBEOFIA(this MonoBehaviour PCDPAPNKMFB, Action<float> CIHODCMNLEG, bool EFIIPLCIKJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x72B3450", Offset = "0x72B2450", VA = "0x1872B3450")]
	public static IDisposable LCGCMHHEEFB(this MonoBehaviour PCDPAPNKMFB, Action<float> CIHODCMNLEG, bool EFIIPLCIKJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72B3300", Offset = "0x72B2300", VA = "0x1872B3300")]
	public static IDisposable GGJPIHHIPAN(this MonoBehaviour PCDPAPNKMFB, Action<float> CIHODCMNLEG, bool EFIIPLCIKJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72B3730", Offset = "0x72B2730", VA = "0x1872B3730")]
	public static IDisposable PENBBFEFKIG(this MonoBehaviour PCDPAPNKMFB, Action<float> CIHODCMNLEG, bool EFIIPLCIKJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72B31E0", Offset = "0x72B21E0", VA = "0x1872B31E0")]
	public static IDisposable GEKIPLLFIFF(this MonoBehaviour PCDPAPNKMFB, Action<float> CIHODCMNLEG, bool EFIIPLCIKJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x72B2CE0", Offset = "0x72B1CE0", VA = "0x1872B2CE0")]
	public static IDisposable BDFIGNOIOKJ(this MonoBehaviour PCDPAPNKMFB, Action<float> CIHODCMNLEG, bool EFIIPLCIKJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72B33A0", Offset = "0x72B23A0", VA = "0x1872B33A0")]
	public static IDisposable HAFIFJHODIL(this MonoBehaviour PCDPAPNKMFB, float NHAHIBOLKFP, Action<float> CIHODCMNLEG, bool EFIIPLCIKJH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class DONHPFFAJAB
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class BPFPALBNOCE : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public GELFNACLEAD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private CJANGPLJHDO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public BPFPALBNOCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x72AC290", Offset = "0x72AB290", VA = "0x1872AC290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x72AC370", Offset = "0x72AB370", VA = "0x1872AC370", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class COHAGADNEJN : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public GELFNACLEAD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private CJANGPLJHDO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public COHAGADNEJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x72AD1A0", Offset = "0x72AC1A0", VA = "0x1872AD1A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x72AD290", Offset = "0x72AC290", VA = "0x1872AD290", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x72B29F0", Offset = "0x72B19F0", VA = "0x1872B29F0")]
	public static HDBNHMIPDLF MHENPBGMIMI(Action CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x72B2930", Offset = "0x72B1930", VA = "0x1872B2930")]
	public static HDBNHMIPDLF MHENPBGMIMI(Behaviour PDLLDMABKGP, Action CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x72B2AA0", Offset = "0x72B1AA0", VA = "0x1872B2AA0")]
	public static HDBNHMIPDLF MHENPBGMIMI(Behaviour PDLLDMABKGP, Action<float> CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x72B2C50", Offset = "0x72B1C50", VA = "0x1872B2C50")]
	[IteratorStateMachine(typeof(BPFPALBNOCE))]
	private static IEnumerator<FAKEPIEMOLB> OPGCGBDELOJ(GELFNACLEAD PICPEPAPJBI, Action CIHODCMNLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x72B2BC0", Offset = "0x72B1BC0", VA = "0x1872B2BC0")]
	[IteratorStateMachine(typeof(COHAGADNEJN))]
	private static IEnumerator<FAKEPIEMOLB> OPGCGBDELOJ(GELFNACLEAD PICPEPAPJBI, Action<float> CIHODCMNLEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class IPKNLPBJJLL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class FCAGCGOMAFE : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public IPKNLPBJJLL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public FCAGCGOMAFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x72B3970", Offset = "0x72B2970", VA = "0x1872B3970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x72B3A00", Offset = "0x72B2A00", VA = "0x1872B3A00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly GELFNACLEAD AIGKOJHJBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Action EMBHNFJHMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool LEDKEDFKOLF;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DCLFDPKOLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x851860", Offset = "0x850860", VA = "0x180851860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x72BD310", Offset = "0x72BC310", VA = "0x1872BD310")]
	public IPKNLPBJJLL(GELFNACLEAD AIGKOJHJBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x72BD1F0", Offset = "0x72BC1F0", VA = "0x1872BD1F0")]
	[IteratorStateMachine(typeof(FCAGCGOMAFE))]
	private IEnumerator<FAKEPIEMOLB> MPFDJBBKIOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x72BD270", Offset = "0x72BC270", VA = "0x1872BD270", Slot = "4")]
	public void OnCompleted(Action DDPGPKCMHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	public void DMBGOCBKJFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LEDALGLFKAL
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x72C0A00", Offset = "0x72BFA00", VA = "0x1872C0A00")]
	public static IPKNLPBJJLL KJJJNEGPHHP(this GELFNACLEAD AIGKOJHJBHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class CDCECKGPPJN
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class GBEAAJDOHKP : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public JBMHLKLINIC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public GBEAAJDOHKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x72B61C0", Offset = "0x72B51C0", VA = "0x1872B61C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x72B6240", Offset = "0x72B5240", VA = "0x1872B6240", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x72AC6E0", Offset = "0x72AB6E0", VA = "0x1872AC6E0")]
	public static HDBNHMIPDLF MHENPBGMIMI(float NHAHIBOLKFP, Action<float> CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO, bool EFIIPLCIKJH = true, [Optional] MGMNJOKCKBN LGKKNNLAAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x72AC5D0", Offset = "0x72AB5D0", VA = "0x1872AC5D0")]
	public static HDBNHMIPDLF MHENPBGMIMI(MonoBehaviour PCDPAPNKMFB, float NHAHIBOLKFP, Action<float> CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO, bool EFIIPLCIKJH = true, [Optional] MGMNJOKCKBN LGKKNNLAAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x72AC3C0", Offset = "0x72AB3C0", VA = "0x1872AC3C0")]
	public static HDBNHMIPDLF CNMNMPHGPKL(MonoBehaviour PCDPAPNKMFB, float NHAHIBOLKFP, Action<float> CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO, bool EFIIPLCIKJH = true, [Optional] MGMNJOKCKBN LGKKNNLAAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x72AC7E0", Offset = "0x72AB7E0", VA = "0x1872AC7E0")]
	public static HDBNHMIPDLF MKDGOKHPHFI(PMEANFDAKDJ PDLLDMABKGP, float NHAHIBOLKFP, Action<float> CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO, bool EFIIPLCIKJH = true, [Optional] MGMNJOKCKBN LGKKNNLAAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x72AC8F0", Offset = "0x72AB8F0", VA = "0x1872AC8F0")]
	private static IEnumerator<FAKEPIEMOLB> OPGCGBDELOJ(ABEHEBGHAMO AHPINDPGGJA, float NHAHIBOLKFP, GELFNACLEAD PICPEPAPJBI, Action<float> CIHODCMNLEG, bool EFIIPLCIKJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x72AC4E0", Offset = "0x72AB4E0", VA = "0x1872AC4E0")]
	private static IEnumerator<FAKEPIEMOLB> DEJNCNFMBLI(ABEHEBGHAMO AHPINDPGGJA, float NHAHIBOLKFP, GELFNACLEAD PICPEPAPJBI, Action<float> CIHODCMNLEG, bool EFIIPLCIKJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x72AC540", Offset = "0x72AB540", VA = "0x1872AC540")]
	[IteratorStateMachine(typeof(GBEAAJDOHKP))]
	private static IEnumerator<FAKEPIEMOLB> JPIDNFIFJBF(JBMHLKLINIC FKKHKACLNNJ, float NHAHIBOLKFP, GELFNACLEAD PICPEPAPJBI, Action<float> CIHODCMNLEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class BGCCOKNPEGN
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class CEFBIHNAEBM : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public GELFNACLEAD queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public CEFBIHNAEBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x72ACC50", Offset = "0x72ABC50", VA = "0x1872ACC50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x72ACD10", Offset = "0x72ABD10", VA = "0x1872ACD10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x72AB8F0", Offset = "0x72AA8F0", VA = "0x1872AB8F0")]
	[IteratorStateMachine(typeof(CEFBIHNAEBM))]
	private static IEnumerator<FAKEPIEMOLB> FDLHAKILJCF(GELFNACLEAD AIGKOJHJBHO, Func<bool> MKNHBDKKONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x72AB7D0", Offset = "0x72AA7D0", VA = "0x1872AB7D0")]
	public static HDBNHMIPDLF EHMFDACFNKN(this MonoBehaviour PCDPAPNKMFB, Func<bool> MKNHBDKKONJ, GELFNACLEAD AIGKOJHJBHO = GELFNACLEAD.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PAJAFIHKIOP
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class FLPGKAFFHKO : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public GELFNACLEAD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public FLPGKAFFHKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x72B3D80", Offset = "0x72B2D80", VA = "0x1872B3D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x72B3DF0", Offset = "0x72B2DF0", VA = "0x1872B3DF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class OLKDDGLBHIP : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public GELFNACLEAD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private FAKEPIEMOLB <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public OLKDDGLBHIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x72C3B90", Offset = "0x72C2B90", VA = "0x1872C3B90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x72C3C20", Offset = "0x72C2C20", VA = "0x1872C3C20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x72C45C0", Offset = "0x72C35C0", VA = "0x1872C45C0")]
	[IteratorStateMachine(typeof(FLPGKAFFHKO))]
	private static IEnumerator<FAKEPIEMOLB> MPFDJBBKIOF(float GHCGFNCODKM, GELFNACLEAD PICPEPAPJBI, Action BOJOFOCMOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x72C4270", Offset = "0x72C3270", VA = "0x1872C4270")]
	[IteratorStateMachine(typeof(OLKDDGLBHIP))]
	private static IEnumerator<FAKEPIEMOLB> LJBEOAPIPPC(float GHCGFNCODKM, GELFNACLEAD PICPEPAPJBI, Action BOJOFOCMOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x72C4000", Offset = "0x72C3000", VA = "0x1872C4000")]
	public static IDisposable IOGIBNFPGCC(this MonoBehaviour PCDPAPNKMFB, float GHCGFNCODKM, Action BOJOFOCMOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x72C3DA0", Offset = "0x72C2DA0", VA = "0x1872C3DA0")]
	public static HDBNHMIPDLF FHIMOGGLMII(this MonoBehaviour PCDPAPNKMFB, float GHCGFNCODKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x72C4120", Offset = "0x72C3120", VA = "0x1872C4120")]
	public static HDBNHMIPDLF IOGIBNFPGCC(this MonoBehaviour PCDPAPNKMFB, float GHCGFNCODKM, GELFNACLEAD PICPEPAPJBI, Action BOJOFOCMOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x72C4250", Offset = "0x72C3250", VA = "0x1872C4250")]
	public static HDBNHMIPDLF LIPNOCDGELK(this MonoBehaviour PCDPAPNKMFB, Action BOJOFOCMOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x72C4310", Offset = "0x72C3310", VA = "0x1872C4310")]
	public static HDBNHMIPDLF LLOKBEDNAEI(this MonoBehaviour PCDPAPNKMFB, Action BOJOFOCMOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72C44E0", Offset = "0x72C34E0", VA = "0x1872C44E0")]
	public static HDBNHMIPDLF MJNFKBJPGKP(this MonoBehaviour PCDPAPNKMFB, Action BOJOFOCMOIF, [Optional] MGMNJOKCKBN LGKKNNLAAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72C3CA0", Offset = "0x72C2CA0", VA = "0x1872C3CA0")]
	public static HDBNHMIPDLF CKPGCDENOAH(this MonoBehaviour PCDPAPNKMFB, Action BOJOFOCMOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x72C3C70", Offset = "0x72C2C70", VA = "0x1872C3C70")]
	public static HDBNHMIPDLF ALGIKOBAKAL(this MonoBehaviour PCDPAPNKMFB, Action BOJOFOCMOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x72C3E60", Offset = "0x72C2E60", VA = "0x1872C3E60")]
	private static HDBNHMIPDLF FKFFDIJFPIG(MonoBehaviour PCDPAPNKMFB, GELFNACLEAD AIGKOJHJBHO, Action BOJOFOCMOIF, [Optional] MGMNJOKCKBN LGKKNNLAAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x72C4410", Offset = "0x72C3410", VA = "0x1872C4410")]
	public static HDBNHMIPDLF MILJHMAMCJC(this MonoBehaviour PCDPAPNKMFB, float LAKFDKHNDIN, Action BOJOFOCMOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x72C4340", Offset = "0x72C3340", VA = "0x1872C4340")]
	public static HDBNHMIPDLF MCDKKPFHDJA(this MonoBehaviour PCDPAPNKMFB, float LAKFDKHNDIN, Action BOJOFOCMOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x72C3F30", Offset = "0x72C2F30", VA = "0x1872C3F30")]
	public static HDBNHMIPDLF GFHJMNLIMBL(this MonoBehaviour PCDPAPNKMFB, float LAKFDKHNDIN, Action BOJOFOCMOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x72C3CD0", Offset = "0x72C2CD0", VA = "0x1872C3CD0")]
	public static HDBNHMIPDLF ECJPLAJJALM(this MonoBehaviour PCDPAPNKMFB, float LAKFDKHNDIN, Action BOJOFOCMOIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class OEKFMBPLEBH : ALJCCOKCKBJ, IEnumerable<ALJCCOKCKBJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly List<ALJCCOKCKBJ> HIDCILHBAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool CBILPMPDPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Action ENFGICEPNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool OKNALCNDOAC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IPCJHFAMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x72C39B0", Offset = "0x72C29B0", VA = "0x1872C39B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DCPNLKMPDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x72C3560", Offset = "0x72C2560", VA = "0x1872C3560", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x72C3910", Offset = "0x72C2910", VA = "0x1872C3910", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x72C3AF0", Offset = "0x72C2AF0", VA = "0x1872C3AF0")]
	public OEKFMBPLEBH([Optional] Action ENFGICEPNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x72C3600", Offset = "0x72C2600", VA = "0x1872C3600")]
	public void GKAGDNHKNII(ALJCCOKCKBJ CMPFJJAMKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x72C37B0", Offset = "0x72C27B0", VA = "0x1872C37B0")]
	private void HLEJKGGKCFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x72C3550", Offset = "0x72C2550", VA = "0x1872C3550", Slot = "7")]
	public bool EPJDPCKICAL(bool HPJKELEMMFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x72C3240", Offset = "0x72C2240", VA = "0x1872C3240", Slot = "8")]
	public bool EPJDPCKICAL(Action JFOAFIPDIOA, bool HPJKELEMMFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x72C3730", Offset = "0x72C2730", VA = "0x1872C3730", Slot = "9")]
	public IEnumerator<ALJCCOKCKBJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x72C3730", Offset = "0x72C2730", VA = "0x1872C3730", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class HDOBHHCHHGK : LFHLLEKOCJM
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CKFHDKMFNJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public HDOBHHCHHGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CKFHDKMFNJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x72AB1F0", Offset = "0x72AA1F0", VA = "0x1872AB1F0")]
		internal void FGCOKFCANEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class AMJMPPDBHIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public HDOBHHCHHGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public AMJMPPDBHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x72AB1F0", Offset = "0x72AA1F0", VA = "0x1872AB1F0")]
		internal void NMNKDCGFCNL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float DNPLDODKFED;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x72B9A90", Offset = "0x72B8A90", VA = "0x1872B9A90")]
	public HDOBHHCHHGK(Behaviour PDLLDMABKGP, float DNPLDODKFED, [Optional] Action ENFGICEPNME, [Optional] MGMNJOKCKBN LGKKNNLAAIB, [Optional] ABEHEBGHAMO AHPINDPGGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x72B9980", Offset = "0x72B8980", VA = "0x1872B9980", Slot = "9")]
	protected override bool EGNDCFBNGHB(Action JFOAFIPDIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x72B9870", Offset = "0x72B8870", VA = "0x1872B9870", Slot = "10")]
	protected override bool CJJHOHCAIMF(Action JFOAFIPDIOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface ALJCCOKCKBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IPCJHFAMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DCPNLKMPDGA;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EPJDPCKICAL(bool HPJKELEMMFE = false);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EPJDPCKICAL(Action JFOAFIPDIOA, bool HPJKELEMMFE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public abstract class LFHLLEKOCJM : ALJCCOKCKBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class HMPFHLJMHPI : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public LFHLLEKOCJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public HMPFHLJMHPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x72B9FB0", Offset = "0x72B8FB0", VA = "0x1872B9FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x72BA080", Offset = "0x72B9080", VA = "0x1872BA080", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Behaviour PDLLDMABKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action ENFGICEPNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private AKGDPKBFKBL FNBJHOPDPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly MGMNJOKCKBN LGKKNNLAAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly ABEHEBGHAMO AHPINDPGGJA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool IPCJHFAMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xF91990", Offset = "0xF90990", VA = "0x180F91990", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DCPNLKMPDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x72C10C0", Offset = "0x72C00C0", VA = "0x1872C10C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x72C11C0", Offset = "0x72C01C0", VA = "0x1872C11C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x72C12F0", Offset = "0x72C02F0", VA = "0x1872C12F0")]
	protected LFHLLEKOCJM(Behaviour PDLLDMABKGP, [Optional] Action ENFGICEPNME, [Optional] MGMNJOKCKBN LGKKNNLAAIB, [Optional] ABEHEBGHAMO AHPINDPGGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x72C1000", Offset = "0x72C0000", VA = "0x1872C1000", Slot = "7")]
	public bool EPJDPCKICAL(bool HPJKELEMMFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x72C1060", Offset = "0x72C0060", VA = "0x1872C1060", Slot = "8")]
	public bool EPJDPCKICAL(Action JFOAFIPDIOA, bool HPJKELEMMFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool EGNDCFBNGHB(Action JFOAFIPDIOA);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool CJJHOHCAIMF(Action JFOAFIPDIOA);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x72C1160", Offset = "0x72C0160", VA = "0x1872C1160")]
	protected void IIABMEMLGNP(Action JFOAFIPDIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x72C0D40", Offset = "0x72BFD40", VA = "0x1872C0D40")]
	protected OBDNBLKJHLC AEEAPBOJFEI(float OCJBGOIAOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x72C0F80", Offset = "0x72BFF80", VA = "0x1872C0F80")]
	private void EPGCKCPMKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x72C1260", Offset = "0x72C0260", VA = "0x1872C1260")]
	[IteratorStateMachine(typeof(HMPFHLJMHPI))]
	private IEnumerator<FAKEPIEMOLB> MPIKBMEJIFN(float OCJBGOIAOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x72C1180", Offset = "0x72C0180", VA = "0x1872C1180")]
	[CompilerGenerated]
	private void JEPNPNBIFCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HHKODCGHBCL : LFHLLEKOCJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float ALLJBEMAEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly int LIEOJDHIPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float CGGIFBIHAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float[] DLLIFNLLECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private int GLHOMEEMHEP;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x72B9E10", Offset = "0x72B8E10", VA = "0x1872B9E10")]
	public HHKODCGHBCL(Behaviour PDLLDMABKGP, float MFDMEIEDNMK, int LIEOJDHIPHP, [Optional] Action ENFGICEPNME, float CGGIFBIHAEO = 0f, [Optional] MGMNJOKCKBN LGKKNNLAAIB, [Optional] ABEHEBGHAMO AHPINDPGGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "9")]
	protected override bool EGNDCFBNGHB(Action JFOAFIPDIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x72B9C10", Offset = "0x72B8C10", VA = "0x1872B9C10", Slot = "10")]
	protected override bool CJJHOHCAIMF(Action JFOAFIPDIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x72B9B90", Offset = "0x72B8B90", VA = "0x1872B9B90")]
	private void BHIAJFPNBMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class LPFOLBGJDPL : LFHLLEKOCJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly float DNPLDODKFED;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x72B9A90", Offset = "0x72B8A90", VA = "0x1872B9A90")]
	public LPFOLBGJDPL(Behaviour PDLLDMABKGP, float DNPLDODKFED, [Optional] Action ENFGICEPNME, [Optional] MGMNJOKCKBN LGKKNNLAAIB, [Optional] ABEHEBGHAMO AHPINDPGGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "9")]
	protected override bool EGNDCFBNGHB(Action JFOAFIPDIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x72C13F0", Offset = "0x72C03F0", VA = "0x1872C13F0", Slot = "10")]
	protected override bool CJJHOHCAIMF(Action JFOAFIPDIOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public sealed class DBGPMBHLLLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class KPCCKNKDGOL : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public KPCCKNKDGOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x72AA120", Offset = "0x72A9120", VA = "0x1872AA120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x72C0360", Offset = "0x72BF360", VA = "0x1872C0360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private HDBNHMIPDLF IGGJIEBJBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private PMEANFDAKDJ PDLLDMABKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Action<float> DIONKEPPKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private GELFNACLEAD AIGKOJHJBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private float CPNPDACAMKF;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x72B1910", Offset = "0x72B0910", VA = "0x1872B1910")]
	public DBGPMBHLLLJ(PMEANFDAKDJ PDLLDMABKGP, float NHAHIBOLKFP, Action<float> CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x72B1460", Offset = "0x72B0460", VA = "0x1872B1460")]
	private void JGJPIFABHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x72B1600", Offset = "0x72B0600", VA = "0x1872B1600")]
	private void JHGHNPMNFBH(string EHELKEOJPOO, Action OFAKFNFICMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72B13E0", Offset = "0x72B03E0", VA = "0x1872B13E0")]
	[IteratorStateMachine(typeof(KPCCKNKDGOL))]
	private IEnumerator<FAKEPIEMOLB> FGCOOJFIMEJ(Action OFAKFNFICMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x72B1380", Offset = "0x72B0380", VA = "0x1872B1380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x72B1760", Offset = "0x72B0760", VA = "0x1872B1760")]
	[CompilerGenerated]
	private void PMANANJBEGA(string KCICFLBDCAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class FNDJFGJGDOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class AELGGLPMPJD : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public AELGGLPMPJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x72AA120", Offset = "0x72A9120", VA = "0x1872AA120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x72AA190", Offset = "0x72A9190", VA = "0x1872AA190", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private HDBNHMIPDLF IGGJIEBJBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private MonoBehaviour PCDPAPNKMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Action CIHODCMNLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action<float> DIONKEPPKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private GELFNACLEAD AIGKOJHJBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private float CPNPDACAMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool EFIIPLCIKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly MGMNJOKCKBN LGKKNNLAAIB;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x72B52A0", Offset = "0x72B42A0", VA = "0x1872B52A0")]
	public FNDJFGJGDOA(MonoBehaviour PCDPAPNKMFB, Action CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO, [Optional] MGMNJOKCKBN LGKKNNLAAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x72B56E0", Offset = "0x72B46E0", VA = "0x1872B56E0")]
	public FNDJFGJGDOA(MonoBehaviour PCDPAPNKMFB, Action<float> CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO, [Optional] MGMNJOKCKBN LGKKNNLAAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x72B5490", Offset = "0x72B4490", VA = "0x1872B5490")]
	public FNDJFGJGDOA(MonoBehaviour PCDPAPNKMFB, float NHAHIBOLKFP, Action<float> CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO, bool EFIIPLCIKJH = true, [Optional] MGMNJOKCKBN LGKKNNLAAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B370", Offset = "0x3E5A370", VA = "0x183E5B370")]
	private FNDJFGJGDOA(MGMNJOKCKBN LGKKNNLAAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x72B4690", Offset = "0x72B3690", VA = "0x1872B4690")]
	internal static FNDJFGJGDOA BMLOJFBLIFI(MonoBehaviour PCDPAPNKMFB, float NHAHIBOLKFP, Action<float> CIHODCMNLEG, GELFNACLEAD AIGKOJHJBHO, bool EFIIPLCIKJH = true, [Optional] MGMNJOKCKBN LGKKNNLAAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x72B4EE0", Offset = "0x72B3EE0", VA = "0x1872B4EE0")]
	private void MHENPBGMIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x72B4D30", Offset = "0x72B3D30", VA = "0x1872B4D30")]
	private void KPLNJEJBDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x72B49C0", Offset = "0x72B39C0", VA = "0x1872B49C0")]
	private void JGJPIFABHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x72B50E0", Offset = "0x72B40E0", VA = "0x1872B50E0")]
	private void OOBEMCIHEBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x72B4B70", Offset = "0x72B3B70", VA = "0x1872B4B70")]
	private void JHGHNPMNFBH(string EHELKEOJPOO, Action OFAKFNFICMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x72B48B0", Offset = "0x72B38B0", VA = "0x1872B48B0")]
	[IteratorStateMachine(typeof(AELGGLPMPJD))]
	private IEnumerator<FAKEPIEMOLB> FGCOOJFIMEJ(Action OFAKFNFICMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x72B4850", Offset = "0x72B3850", VA = "0x1872B4850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x72B4930", Offset = "0x72B3930", VA = "0x1872B4930")]
	[CompilerGenerated]
	private void IKJBJMCLFLM(string KCICFLBDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x72B5050", Offset = "0x72B4050", VA = "0x1872B5050")]
	[CompilerGenerated]
	private void NPNLOAALACC(string KCICFLBDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x72B47C0", Offset = "0x72B37C0", VA = "0x1872B47C0")]
	[CompilerGenerated]
	private void CPFMAGMBOOD(string KCICFLBDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x72B4CA0", Offset = "0x72B3CA0", VA = "0x1872B4CA0")]
	[CompilerGenerated]
	private void KGAECILNPFG(string KCICFLBDCAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[Flags]
internal enum MJFEKIFJCGK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class NMLDFEIGNGA : ABEHEBGHAMO
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float FNEMAOGEBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x72C2F90", Offset = "0x72C1F90", VA = "0x1872C2F90", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float HNPHDEDCPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x72C2F80", Offset = "0x72C1F80", VA = "0x1872C2F80", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double BDLGGIIAFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x72C2FA0", Offset = "0x72C1FA0", VA = "0x1872C2FA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x72C2F10", Offset = "0x72C1F10", VA = "0x1872C2F10")]
	[ONAOIKEPAJE(IKAJKCKEGIH.None)]
	private static void ACLEMPFHCOI(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	[Preserve]
	internal NMLDFEIGNGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface PCCGAJFFHNK
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFKPBGNJLEH(string CKEJJGPNKGO);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDKOLEDEPHA();
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface PJMJBLACCMC
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool LEDIDDIHCAG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JHJHJJHFEDP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal class MBBGEFJEKHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public HALNGKAEIBH AMFCDJHFHNH;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int LCNJIFOOGIB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8511A0", Offset = "0x8501A0", VA = "0x1808511A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x854620", Offset = "0x853620", VA = "0x180854620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x72C1660", Offset = "0x72C0660", VA = "0x1872C1660")]
	public static FAKEPIEMOLB MPKAABMPPJG(IEnumerator<FAKEPIEMOLB> CDINHGBMNME, DNJEFACHJMM EOGFOEMDEIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x72C15A0", Offset = "0x72C05A0", VA = "0x1872C15A0")]
	public FAKEPIEMOLB MPKAABMPPJG(DNJEFACHJMM[] BAECBDAKBOI, IEnumerator<FAKEPIEMOLB>[] HPKDIEFMGLD, FAKEPIEMOLB[] FAGMEFPFLGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x72C1430", Offset = "0x72C0430", VA = "0x1872C1430")]
	public void KLIGDCOPABP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x72C17C0", Offset = "0x72C07C0", VA = "0x1872C17C0")]
	public void NMOJDLGEJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x72C1460", Offset = "0x72C0460", VA = "0x1872C1460")]
	public void KPGJCKLLLPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x72C1430", Offset = "0x72C0430", VA = "0x1872C1430")]
	public void BCGNNIMMKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public MBBGEFJEKHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class HALNGKAEIBH
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CDOHHJHLAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public MBBGEFJEKHM LJNKKNPAKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public PMEANFDAKDJ MCHFEIDDPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public DNJEFACHJMM GDADJGDBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IEnumerator<FAKEPIEMOLB> FDMLIGBNAFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public FAKEPIEMOLB KCAPOGCCMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public MJFEKIFJCGK DLKKHHOLOAO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct OMKCHAFPANH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public GELFNACLEAD OLLHNKBAKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public List<CDOHHJHLAJA> MACLONOICOB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class MICACFHNJCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public DNJEFACHJMM promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public HALNGKAEIBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public PMEANFDAKDJ context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public MBBGEFJEKHM routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public MJFEKIFJCGK coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public FAKEPIEMOLB currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IEnumerator<FAKEPIEMOLB> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public MICACFHNJCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x72C2640", Offset = "0x72C1640", VA = "0x1872C2640")]
		internal void IENOPKDLHDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class LAGHKGKJIAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public MBBGEFJEKHM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public HALNGKAEIBH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public LAGHKGKJIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x72C05B0", Offset = "0x72BF5B0", VA = "0x1872C05B0")]
		internal void OBDBCPHCCDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DJFDPKOIICH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public MBBGEFJEKHM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public HALNGKAEIBH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DJFDPKOIICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x72B2870", Offset = "0x72B1870", VA = "0x1872B2870")]
		internal void PKIHNIAJNKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class KLMBLPKBJDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public MBBGEFJEKHM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public HALNGKAEIBH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public KLMBLPKBJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x72C0320", Offset = "0x72BF320", VA = "0x1872C0320")]
		internal void PLGMBDOGNAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const MJFEKIFJCGK JGIMADLKIEI = MJFEKIFJCGK.Cancelled | MJFEKIFJCGK.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly GELFNACLEAD AIGKOJHJBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool[] FCMECGPAEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<MJFEKIFJCGK> PGCCHHNKGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<float> KOHLMLDDNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> GPJKLEHPBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> BIEEKMENDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> KLMMIEIGKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> LOEJBPPAGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> KANOIKHGFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private MBBGEFJEKHM[] AIHFAELECEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private DNJEFACHJMM[] BAECBDAKBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private PMEANFDAKDJ[] BNNMBAEHEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IEnumerator<FAKEPIEMOLB>[] KDCCKILMJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private FAKEPIEMOLB[] LMANLEEJELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int PECKCBEPLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int BPIECAEAGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly int DJEFMBABFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float MCOJBCDBNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private FNBFEIDNJMJ DAAMILNCDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private JobHandle AJJKEOKHBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<MBBGEFJEKHM> AJOKHPCOKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool LGILNEIIGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private List<Action> MCHLDDNIMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> MHCGDAGLMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private bool EMBMGADKEBB;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public OMKCHAFPANH[] KILEEKNDLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x99B320", Offset = "0x99A320", VA = "0x18099B320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x72B8530", Offset = "0x72B7530", VA = "0x1872B8530")]
	private static int GNJJCOCBBMI(GELFNACLEAD AIGKOJHJBHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x72B9220", Offset = "0x72B8220", VA = "0x1872B9220")]
	public HALNGKAEIBH(GELFNACLEAD AIGKOJHJBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x72B81A0", Offset = "0x72B71A0", VA = "0x1872B81A0")]
	private void GFJKKJBIKAG(int BHEIKOBDFCJ, int KDPAPDJOALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x72B7380", Offset = "0x72B6380", VA = "0x1872B7380")]
	public void CJCDHLHFALN(PMEANFDAKDJ PDLLDMABKGP, FAKEPIEMOLB LEHMKOFINMK, IEnumerator<FAKEPIEMOLB> CDINHGBMNME, DNJEFACHJMM EOGFOEMDEIF, [Optional] MBBGEFJEKHM IHHEGPEBEMI, MJFEKIFJCGK OFFOGHCHJDK = MJFEKIFJCGK.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x72B8DA0", Offset = "0x72B7DA0", VA = "0x1872B8DA0")]
	public void LIHBHDHNEGP(IEnumerable<CDOHHJHLAJA> MEFNKDEHICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x72B8560", Offset = "0x72B7560", VA = "0x1872B8560")]
	private CDOHHJHLAJA IFMJODJJLEH(int CGNEFAAKNEB)
	{
		return default(CDOHHJHLAJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x72B8A30", Offset = "0x72B7A30", VA = "0x1872B8A30")]
	private void LCKFDBJIGMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE240", Offset = "0x2BBD240", VA = "0x182BBE240")]
	private static void JADMLIIGCAF<T>(int CGNEFAAKNEB, T[] HKDGCJNNPNB, int GHACOABIHDA, [Optional] T KFBMCBJGLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE290", Offset = "0x2BBD290", VA = "0x182BBE290")]
	private static void JADMLIIGCAF<T>(int CGNEFAAKNEB, NativeArray<T> HKDGCJNNPNB, int GHACOABIHDA, [Optional] T KFBMCBJGLOH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x72B7500", Offset = "0x72B6500", VA = "0x1872B7500")]
	private void EECHEJLOGHJ(IEnumerable<CDOHHJHLAJA> MEFNKDEHICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x72B9160", Offset = "0x72B8160", VA = "0x1872B9160")]
	private void OOFEEHFEPPF(CDOHHJHLAJA NGDFFBGALKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x72B6FF0", Offset = "0x72B5FF0", VA = "0x1872B6FF0")]
	private CDEALKPEPCJ BHFMMHNGLGH(int NMBPDMNAJKE)
	{
		return default(CDEALKPEPCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x72B78A0", Offset = "0x72B68A0", VA = "0x1872B78A0")]
	public void EEFNCKHPFNE(float JAKDMONMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x72B8FE0", Offset = "0x72B7FE0", VA = "0x1872B8FE0")]
	private void NLAAGBLHFCI(Action MHGINKKGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x72B84B0", Offset = "0x72B74B0", VA = "0x1872B84B0")]
	private void GMMIOCMGMIF(Action MHGINKKGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x72B7AA0", Offset = "0x72B6AA0", VA = "0x1872B7AA0")]
	public void EPCKLMLAGBL(float JAKDMONMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x72B9060", Offset = "0x72B8060", VA = "0x1872B9060")]
	public void NNJJIJJFMLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x72B6EC0", Offset = "0x72B5EC0", VA = "0x1872B6EC0")]
	public void BCGNNIMMKEK(MBBGEFJEKHM FKKHKACLNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x72B8380", Offset = "0x72B7380", VA = "0x1872B8380")]
	public void GMCBDJENCDH(MBBGEFJEKHM FKKHKACLNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x72B7250", Offset = "0x72B6250", VA = "0x1872B7250")]
	public void CHILAAMBAKO(MBBGEFJEKHM FKKHKACLNNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class NEEDEDEPKAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static readonly NEEDEDEPKAN MEMMBNOMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Action AELCBPEPGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool IHDIIKNEDCC;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public NEEDEDEPKAN(Action AELCBPEPGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B1A0", Offset = "0x6A4A1A0", VA = "0x186A4B1A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface AKEGGAMKFIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T JMEAFIDIDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable EOPKHJLEJHC(UnityEngine.Object PDLLDMABKGP, Action<T> HCFDCFGNBIA);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface FMHANFHGECE<T> : AKEGGAMKFIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T JMEAFIDIDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class BOOBJJPCLHB<T> : FMHANFHGECE<T>, AKEGGAMKFIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class DCOIAMFADEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public BOOBJJPCLHB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public MFCGGDPIIAM<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DCOIAMFADEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x58218F0", Offset = "0x58208F0", VA = "0x1858218F0")]
		internal void KBHBJBPPPCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static GameObject JPFFAHKJFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<MFCGGDPIIAM<UnityEngine.Object, Action<T>>> BIABNBOAIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private T FCMCBJLHAPF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T JMEAFIDIDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x95D990", Offset = "0x95C990", VA = "0x18095D990", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7E20", Offset = "0x4EA6E20", VA = "0x184EA7E20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7890", Offset = "0x4EA6890", VA = "0x184EA7890")]
	private static bool ADDDNNFJBLD(T MHGINKKGGNL, T JCHFDOINNOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7EC0", Offset = "0x4EA6EC0", VA = "0x184EA7EC0")]
	public BOOBJJPCLHB(T OGCDOAOBBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7950", Offset = "0x4EA6950", VA = "0x184EA7950", Slot = "6")]
	public IDisposable EOPKHJLEJHC(UnityEngine.Object PDLLDMABKGP, Action<T> HCFDCFGNBIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7B00", Offset = "0x4EA6B00", VA = "0x184EA7B00")]
	private void HNPPJGFBKMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class DIIOHKHGBNE : EENBGMKMPAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly MGMNJOKCKBN LGKKNNLAAIB;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x72B2750", Offset = "0x72B1750", VA = "0x1872B2750")]
	[ONAOIKEPAJE(IKAJKCKEGIH.None)]
	private static void ACLEMPFHCOI(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	[Preserve]
	internal DIIOHKHGBNE([JONIFKKOOAA(null)] MGMNJOKCKBN LGKKNNLAAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x72B27C0", Offset = "0x72B17C0", VA = "0x1872B27C0", Slot = "4")]
	public IDisposable FGIEGAGHFJD(float NHAHIBOLKFP, Action<float> IPCEAEAAIHH, bool EFIIPLCIKJH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class DDHIPEHKBEM : IDBBLNDNCGM, MGMNJOKCKBN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private HALNGKAEIBH[] DJJGEDADBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private PCCGAJFFHNK IDPDIHOAEJN;

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x72B1AF0", Offset = "0x72B0AF0", VA = "0x1872B1AF0")]
	[ONAOIKEPAJE(IKAJKCKEGIH.None)]
	private static void ACLEMPFHCOI(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x72B2690", Offset = "0x72B1690", VA = "0x1872B2690")]
	[Preserve]
	public DDHIPEHKBEM([JONIFKKOOAA(null)] MIJJCBKIGMK NFOMMFPLFFA, [JONIFKKOOAA(null)] ABEHEBGHAMO AHPINDPGGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x72B2560", Offset = "0x72B1560", VA = "0x1872B2560", Slot = "18")]
	public override HDBNHMIPDLF NNHPOAKLPII(PMEANFDAKDJ PDLLDMABKGP, IEnumerator<FAKEPIEMOLB> GKEIJCHDIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x72B1B60", Offset = "0x72B0B60", VA = "0x1872B1B60", Slot = "19")]
	public override void CLDDABPDPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x72B2330", Offset = "0x72B1330", VA = "0x1872B2330", Slot = "21")]
	public override void MLNICAOCECA(GELFNACLEAD AIGKOJHJBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x72B2090", Offset = "0x72B1090", VA = "0x1872B2090", Slot = "20")]
	protected override void GACAEOGENLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x72B2280", Offset = "0x72B1280", VA = "0x1872B2280")]
	private HALNGKAEIBH KOBIJBNLMLI(GELFNACLEAD HNGLFCFOHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x72B1E60", Offset = "0x72B0E60", VA = "0x1872B1E60", Slot = "22")]
	internal override FPCIANIOIEH GABMJEAJGMG(IEnumerator<FAKEPIEMOLB> GKEIJCHDIBB, Behaviour PDLLDMABKGP, DNJEFACHJMM EOGFOEMDEIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x72B22B0", Offset = "0x72B12B0", VA = "0x1872B22B0", Slot = "23")]
	internal override IIENJBOICCK MIHJKCFADMH(GELFNACLEAD PICPEPAPJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x72B2160", Offset = "0x72B1160", VA = "0x1872B2160")]
	private void IEFGNEPMOMK(HALNGKAEIBH LBDPAEAFAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x72B1E00", Offset = "0x72B0E00", VA = "0x1872B1E00", Slot = "24")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[BurstCompile]
internal struct FNBFEIDNJMJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	public float DHKGEDIFAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public int LOJLFDEGICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> EPBOACLNBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> BOFIMFFDCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> JPHBLKBPLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	public NativeArray<MJFEKIFJCGK> AODPGMELDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<float> HDBEFLFDLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[WriteOnly]
	public NativeArray<int> KLMMIEIGKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> GPJKLEHPBOI;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x72B4450", Offset = "0x72B3450", VA = "0x1872B4450")]
	public static FNBFEIDNJMJ EAPGIKBOING(int FDCOABMOFFP, float JAKDMONMIBD, NativeArray<MJFEKIFJCGK> BCCOKAAKJFF, NativeArray<float> AFKOOJGNBEL, NativeArray<int> BCHHPFJOLKF, NativeArray<int> HJLBKIEBAAH, NativeArray<int> CPKJKIOHIGB, NativeArray<int> BOFIMFFDCJD, NativeArray<int> JPHBLKBPLGF)
	{
		return default(FNBFEIDNJMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x72B4580", Offset = "0x72B3580", VA = "0x1872B4580", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x72B4410", Offset = "0x72B3410", VA = "0x1872B4410")]
	private bool DPNILMOIDLH(int HCALFJOJKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x72B4660", Offset = "0x72B3660", VA = "0x1872B4660")]
	private void OOOAAMHBBDO(NativeArray<int> NPJKGHONCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x72B4370", Offset = "0x72B3370", VA = "0x1872B4370")]
	private int DFGNOALLBDK(int HGJNEDKOBKM, int KBHDHJBMNGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x72B44B0", Offset = "0x72B34B0", VA = "0x1872B44B0")]
	private void EGGOMFPLNNO(NativeArray<int> NPJKGHONCPP, int JPPLAJHALPG, int IELHIIDGIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x72B4130", Offset = "0x72B3130", VA = "0x1872B4130")]
	private void COOGHHMCMJC(NativeArray<int> NPJKGHONCPP, int MDGKLJBILCM, int KDINNGPKGBJ, int IMJELLMHJKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class IDBBLNDNCGM : MGMNJOKCKBN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly MIJJCBKIGMK NFOMMFPLFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected readonly ABEHEBGHAMO AHPINDPGGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private IIENJBOICCK[] FHDGHMJILGI;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static MGMNJOKCKBN PNNELGGLBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x72BA420", Offset = "0x72B9420", VA = "0x1872BA420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool EFBLDNCDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GELFNACLEAD FBHJBGLJCNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8511A0", Offset = "0x8501A0", VA = "0x1808511A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GELFNACLEAD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x854620", Offset = "0x853620", VA = "0x180854620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ABEHEBGHAMO GBNBGEKEMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public FAKEPIEMOLB GKCAFFOBMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public FAKEPIEMOLB AFLFMMCCGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8517B0", Offset = "0x8507B0", VA = "0x1808517B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FAKEPIEMOLB NBEBCHDPCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x8507F0", VA = "0x1808517F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x72BB090", Offset = "0x72BA090", VA = "0x1872BB090")]
	public static HDBNHMIPDLF PJEHFMAJNDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x72BB140", Offset = "0x72BA140", VA = "0x1872BB140")]
	[Preserve]
	protected IDBBLNDNCGM([JONIFKKOOAA(null)] MIJJCBKIGMK NFOMMFPLFFA, [JONIFKKOOAA(null)] ABEHEBGHAMO AHPINDPGGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x72BAE80", Offset = "0x72B9E80", VA = "0x1872BAE80", Slot = "6")]
	public HDBNHMIPDLF PCBFBKDIPKL(IEnumerator<FAKEPIEMOLB> GKEIJCHDIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x72BAE90", Offset = "0x72B9E90", VA = "0x1872BAE90", Slot = "7")]
	public HDBNHMIPDLF PCBFBKDIPKL(Behaviour PDLLDMABKGP, IEnumerator<FAKEPIEMOLB> GKEIJCHDIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract HDBNHMIPDLF NNHPOAKLPII(PMEANFDAKDJ PDLLDMABKGP, IEnumerator<FAKEPIEMOLB> GKEIJCHDIBB);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x72BA280", Offset = "0x72B9280", VA = "0x1872BA280", Slot = "19")]
	public virtual void CLDDABPDPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x72BA500", Offset = "0x72B9500", VA = "0x1872BA500", Slot = "9")]
	public void DOOIKIFNHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x72BAB60", Offset = "0x72B9B60", VA = "0x1872BAB60", Slot = "20")]
	protected virtual void GACAEOGENLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x72BAD70", Offset = "0x72B9D70", VA = "0x1872BAD70")]
	private void LFIPIFONGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x72BAB20", Offset = "0x72B9B20", VA = "0x1872BAB20")]
	private void FADEPKCALHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x72BAB40", Offset = "0x72B9B40", VA = "0x1872BAB40")]
	private void FKADPNLKBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x72BA260", Offset = "0x72B9260", VA = "0x1872BA260")]
	private void CKPHNMOIKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x72BAB80", Offset = "0x72B9B80", VA = "0x1872BAB80")]
	private void GDOMLBBGJLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x72BAB00", Offset = "0x72B9B00", VA = "0x1872BAB00")]
	private void ECFPEBMNBFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x72BB120", Offset = "0x72BA120", VA = "0x1872BB120")]
	private void PODMIKIOCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x72BADF0", Offset = "0x72B9DF0", VA = "0x1872BADF0", Slot = "21")]
	public virtual void MLNICAOCECA(GELFNACLEAD AIGKOJHJBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x72BABA0", Offset = "0x72B9BA0", VA = "0x1872BABA0")]
	private void GGCHMFBPEDN(IIENJBOICCK LBDPAEAFAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1F03FD0", Offset = "0x1F02FD0", VA = "0x181F03FD0")]
	private IIENJBOICCK FMFOAJAJBPM(GELFNACLEAD HNGLFCFOHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract FPCIANIOIEH GABMJEAJGMG(IEnumerator<FAKEPIEMOLB> GKEIJCHDIBB, Behaviour PCDPAPNKMFB, DNJEFACHJMM OKDMBMMAOGL);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract IIENJBOICCK MIHJKCFADMH(GELFNACLEAD AIGKOJHJBHO);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x72BA740", Offset = "0x72B9740", VA = "0x1872BA740", Slot = "24")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x72BAD90", Offset = "0x72B9D90", VA = "0x1872BAD90", Slot = "14")]
	public FAKEPIEMOLB LOLBMIBCOFP(GELFNACLEAD PICPEPAPJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x72BA470", Offset = "0x72B9470", VA = "0x1872BA470", Slot = "15")]
	public FAKEPIEMOLB DDCLNCKBNOC(float GHCGFNCODKM, GELFNACLEAD PICPEPAPJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x72BA200", Offset = "0x72B9200", VA = "0x1872BA200", Slot = "16")]
	public FAKEPIEMOLB CAOAOCBBBDN(Func<bool> MKNHBDKKONJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class FPCIANIOIEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly DNJEFACHJMM EOGFOEMDEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly PJMJBLACCMC PDLLDMABKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly bool LAMJJLOGFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private string CKEJJGPNKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private StackTrace KOINMLBGFON;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IEnumerator<FAKEPIEMOLB> FDMLIGBNAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public FAKEPIEMOLB KCAPOGCCMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool FOFECMPBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x72B59E0", Offset = "0x72B49E0", VA = "0x1872B59E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool PKPDMIGFKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x95D910", Offset = "0x95C910", VA = "0x18095D910")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xAE4D20", Offset = "0xAE3D20", VA = "0x180AE4D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x72B5D70", Offset = "0x72B4D70", VA = "0x1872B5D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float IBIPKAFJIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x95D8B0", Offset = "0x95C8B0", VA = "0x18095D8B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5EF60B0", Offset = "0x5EF50B0", VA = "0x185EF60B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x72B6000", Offset = "0x72B5000", VA = "0x1872B6000")]
	public FPCIANIOIEH(IEnumerator<FAKEPIEMOLB> CDINHGBMNME, PJMJBLACCMC PDLLDMABKGP, DNJEFACHJMM EOGFOEMDEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x72B5A60", Offset = "0x72B4A60", VA = "0x1872B5A60")]
	public FAKEPIEMOLB MPKAABMPPJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x72B5970", Offset = "0x72B4970", VA = "0x1872B5970")]
	public bool KLHHPJDOINK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x72B5920", Offset = "0x72B4920", VA = "0x1872B5920")]
	public void BCGNNIMMKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x72B5F20", Offset = "0x72B4F20", VA = "0x1872B5F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xB5C2C0", Offset = "0xB5B2C0", VA = "0x180B5C2C0")]
	[CompilerGenerated]
	private void CFPMHBBAJMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class DNJEFACHJMM : CENFBDHFHEH, HDBNHMIPDLF, AKGDPKBFKBL, OBDNBLKJHLC, IEnumerator, FAKEPIEMOLB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private GELFNACLEAD KLLAFEGLHEO;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private GELFNACLEAD LOKCCABHGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x10FA380", Offset = "0x10F9380", VA = "0x1810FA380", Slot = "23")]
		get
		{
			return default(GELFNACLEAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public GELFNACLEAD AMFCDJHFHNH
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x164B3D0", Offset = "0x164A3D0", VA = "0x18164B3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private float GAJKOHOINCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x95F230", Offset = "0x95E230", VA = "0x18095F230", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool GEGJFFBDNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x72B28C0", Offset = "0x72B18C0", VA = "0x1872B28C0", Slot = "24")]
	private bool JHMDLEGBFIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x72B28B0", Offset = "0x72B18B0", VA = "0x1872B28B0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x72B28E0", Offset = "0x72B18E0", VA = "0x1872B28E0")]
	public DNJEFACHJMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal enum CDEALKPEPCJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal sealed class IIENJBOICCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum HFJMDCFJFCO
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct AEGDECJMBGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GELFNACLEAD OLLHNKBAKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public HFJMDCFJFCO NNJNJJKMDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<FPCIANIOIEH> GGAPJHNEBAK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly HFJMDCFJFCO[] EDPJLOBJLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly GELFNACLEAD AIGKOJHJBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private bool EBEEBMNAFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly FPCIANIOIEH[] IMGEIPCJEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<FPCIANIOIEH> PDJDDNACPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> LHNIFCOBODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly List<FPCIANIOIEH> GENLKGLFOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Stack<int> OGIAJNBDJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly PCCGAJFFHNK IJALIMOJCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private bool EMBMGADKEBB;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public AEGDECJMBGE[,] OBDHIPEKAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x8507F0", VA = "0x1808517F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x72BCB40", Offset = "0x72BBB40", VA = "0x1872BCB40")]
	public IIENJBOICCK(GELFNACLEAD PICPEPAPJBI, PCCGAJFFHNK IJALIMOJCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x72BC200", Offset = "0x72BB200", VA = "0x1872BC200")]
	public void EONDEFHGKJB(FPCIANIOIEH CDINHGBMNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x72BC570", Offset = "0x72BB570", VA = "0x1872BC570")]
	public void NFLIPMGFMPC(IList<FPCIANIOIEH> HPKDIEFMGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x72BB7B0", Offset = "0x72BA7B0", VA = "0x1872BB7B0")]
	public void BODMPILEABK(IList<FPCIANIOIEH> HPKDIEFMGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x72BC480", Offset = "0x72BB480", VA = "0x1872BC480")]
	private void LGODPODJLLI(FPCIANIOIEH CDINHGBMNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x72BC870", Offset = "0x72BB870", VA = "0x1872BC870")]
	private void NHBKIIDAPAL(IList<FPCIANIOIEH> HPKDIEFMGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x72BB630", Offset = "0x72BA630", VA = "0x1872BB630")]
	private CDEALKPEPCJ AINBKPHFNNP(FPCIANIOIEH CDINHGBMNME)
	{
		return default(CDEALKPEPCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x72BC310", Offset = "0x72BB310", VA = "0x1872BC310")]
	public void GACAEOGENLN(float JAKDMONMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x72BBDB0", Offset = "0x72BADB0", VA = "0x1872BBDB0")]
	public void DOOIKIFNHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x72BBAB0", Offset = "0x72BAAB0", VA = "0x1872BBAB0")]
	private void DCLNKGNIOCJ(List<FPCIANIOIEH> HPKDIEFMGLD, Stack<int> HIHCOMCDPPB, bool CHCFMICOPJD, float KBOHHJOFCDF = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x72BBFA0", Offset = "0x72BAFA0", VA = "0x1872BBFA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x72BC0C0", Offset = "0x72BB0C0", VA = "0x1872BC0C0")]
	private void ENMFKNEFPKE(List<FPCIANIOIEH> HPKDIEFMGLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class HAHLMOMIIMF : PCCGAJFFHNK
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
	public void AFKPBGNJLEH(string CKEJJGPNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
	public void NDKOLEDEPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public HAHLMOMIIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class EOHNCOOCDAB : PJMJBLACCMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly Behaviour PCDPAPNKMFB;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x72B38F0", Offset = "0x72B28F0", VA = "0x1872B38F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool LEDIDDIHCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x72B38A0", Offset = "0x72B28A0", VA = "0x1872B38A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool JHJHJJHFEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x72B3880", Offset = "0x72B2880", VA = "0x1872B3880", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public EOHNCOOCDAB(Behaviour PCDPAPNKMFB)
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

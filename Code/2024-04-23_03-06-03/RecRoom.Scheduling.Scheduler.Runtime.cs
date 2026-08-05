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
public class LNENOGOJENC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority BNGMHOAFKMP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B65FD0", Offset = "0x6B64FD0", VA = "0x186B65FD0")]
	public LNENOGOJENC(ThreadPriority GHJLHONDCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B65FC0", Offset = "0x6B64FC0", VA = "0x186B65FC0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> DPPINJBFLKM(List<PlayerLoopSystem> AJIFPHNPEDN, int HAKBDMIIDFF);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct AMCKDCOLGLE
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct CGANPCJMAOK
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static ONDMBBPPJJI NEHBOMCIMEL;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x6B51FA0", Offset = "0x6B50FA0", VA = "0x186B51FA0")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct LMNEJHNGNPH
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static ONDMBBPPJJI CEDGFCAAOOA;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x6B65DC0", Offset = "0x6B64DC0", VA = "0x186B65DC0")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct KKGCPELFIDA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static ONDMBBPPJJI OFEOOJADMKM;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6B61630", Offset = "0x6B60630", VA = "0x186B61630")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct OABNGMOCHHI
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static ONDMBBPPJJI KOGHJIGCPJF;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static ONDMBBPPJJI DIGNNGIFALP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static ONDMBBPPJJI CENOOFFDPCB;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static ONDMBBPPJJI DBGCFOLALCE;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x6B69880", Offset = "0x6B68880", VA = "0x186B69880")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct IPIOMDIEDDH
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static ONDMBBPPJJI PFDCKEKFHOF;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x6B5D590", Offset = "0x6B5C590", VA = "0x186B5D590")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct DEOFJFHFDII
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static ONDMBBPPJJI KOGHJIGCPJF;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static ONDMBBPPJJI DIGNNGIFALP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static ONDMBBPPJJI CENOOFFDPCB;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static ONDMBBPPJJI DBGCFOLALCE;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x6B56100", Offset = "0x6B55100", VA = "0x186B56100")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct KOMCHLFPJLK
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static ONDMBBPPJJI ELLOHGMFIHA;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x6B61830", Offset = "0x6B60830", VA = "0x186B61830")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct JGDGFBPGMFD
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static ONDMBBPPJJI ONALAEOGPOL;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6B5EDF0", Offset = "0x6B5DDF0", VA = "0x186B5EDF0")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct LHKEHOMAMIJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static ONDMBBPPJJI IPMMMHAMBHN;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6B63010", Offset = "0x6B62010", VA = "0x186B63010")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct LKNCJJEJHOF
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static ONDMBBPPJJI IFIENCNKAGH;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6B65BC0", Offset = "0x6B64BC0", VA = "0x186B65BC0")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct EHBOIOCPMGJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static ONDMBBPPJJI AMAFDEKJMMB;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6B57680", Offset = "0x6B56680", VA = "0x186B57680")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct OFBMMPOJAHA
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static ONDMBBPPJJI HDIMBOMENAD;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x6B6A510", Offset = "0x6B69510", VA = "0x186B6A510")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct NKJBMEECIDE
			{
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public static ONDMBBPPJJI GHCHDIHNMDJ;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6B68B20", Offset = "0x6B67B20", VA = "0x186B68B20")]
				public static PlayerLoopSystem ODMKPJFCPMD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum EBHKEMIBOPD : byte
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
			public struct OIILAODLMFN
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class ADAFGGODINC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public EBHKEMIBOPD updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
					public ADAFGGODINC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x6B50D10", Offset = "0x6B4FD10", VA = "0x186B50D10")]
					internal void KHMHHAHEPDL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public static MIADACEFMCK<EBHKEMIBOPD> HHOPFLJNBMO;

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x6B6A760", Offset = "0x6B69760", VA = "0x186B6A760")]
				public static PlayerLoopSystem ODMKPJFCPMD(EBHKEMIBOPD HDFNCODOMCM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct JLNJPCACJNC
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class EONKKJNNDJB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public FECHOABCAKA.NIADMMNJNCG key;

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
					public EONKKJNNDJB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x6B57EF0", Offset = "0x6B56EF0", VA = "0x186B57EF0")]
					internal void BFFDOJOBFOL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public static IDisposable BMPEMLJOJJB;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x6B5EFF0", Offset = "0x6B5DFF0", VA = "0x186B5EFF0")]
				public static PlayerLoopSystem JLKGLJBBDMM(FECHOABCAKA.NIADMMNJNCG OHNEPKBBADL)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct BFEBJOLLMLP
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class KFDMFOAHKOL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public FECHOABCAKA.NIADMMNJNCG key;

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
					public KFDMFOAHKOL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x6B5F280", Offset = "0x6B5E280", VA = "0x186B5F280")]
					internal void BFFDOJOBFOL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x6B51890", Offset = "0x6B50890", VA = "0x186B51890")]
				public static PlayerLoopSystem JLKGLJBBDMM(FECHOABCAKA.NIADMMNJNCG OHNEPKBBADL)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class JFNCLMCAHFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public JFNCLMCAHFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6B5ECD0", Offset = "0x6B5DCD0", VA = "0x186B5ECD0")]
			internal List<PlayerLoopSystem> BPNHENONKPP(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool NKIEOOEEDJM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool LEELILLDNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6B55CE0", Offset = "0x6B54CE0", VA = "0x186B55CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B526A0", Offset = "0x6B516A0", VA = "0x186B526A0")]
		private static void BLFDFFLMDJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B553D0", Offset = "0x6B543D0", VA = "0x186B553D0")]
		private static void GNGEHIONCOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B52470", Offset = "0x6B51470", VA = "0x186B52470")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B522B0", Offset = "0x6B512B0", VA = "0x186B522B0")]
		private static void AGAANLFOINM(FECHOABCAKA.NIADMMNJNCG OHNEPKBBADL, PlayerLoopSystem AOPJOJIKGKL, Type CHLCIPIGFOM, Type MFMLIIDBLDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6B55D20", Offset = "0x6B54D20", VA = "0x186B55D20")]
		private static void LKHKLCIPAJP(PlayerLoopSystem AOPJOJIKGKL, Type CHLCIPIGFOM, Type MFMLIIDBLDC, DPPINJBFLKM OLJNCADHIOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B552A0", Offset = "0x6B542A0", VA = "0x186B552A0")]
		private static void CAPOICKFPPG(PlayerLoopSystem AOPJOJIKGKL, Type CHLCIPIGFOM, Type MFMLIIDBLDC, PlayerLoopSystem? BFFGBKPFLAL, PlayerLoopSystem? JDLKLGECDAO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class FECHOABCAKA
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum NIADMMNJNCG
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
	public class MDKEKIJDNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly NIADMMNJNCG CBPIACNKICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly FAPANBOABJG CHFFHGLDLIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long OGGDCCDGLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private long NBALOFFCAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long PLHDHGKDIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int NBGGFDMHFNG;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6B675A0", Offset = "0x6B665A0", VA = "0x186B675A0")]
		public MDKEKIJDNEM(NIADMMNJNCG ABENCJEKFFL, int COBBHCMAKOC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B67300", Offset = "0x6B66300", VA = "0x186B67300")]
		public void AEANNNGBNEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B67550", Offset = "0x6B66550", VA = "0x186B67550")]
		public void HAEBCBLNAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6B67370", Offset = "0x6B66370", VA = "0x186B67370")]
		public void BLBFLCMBCBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static NIADMMNJNCG[] JELCACBFHFO;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static MDKEKIJDNEM[] CIKAHOHFIGP;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6B58AD0", Offset = "0x6B57AD0", VA = "0x186B58AD0")]
	public static MDKEKIJDNEM OKAEPKLIJAB(NIADMMNJNCG OHNEPKBBADL, int COBBHCMAKOC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6B58A60", Offset = "0x6B57A60", VA = "0x186B58A60")]
	public static MDKEKIJDNEM KACCLOGGNAK(NIADMMNJNCG OHNEPKBBADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B589C0", Offset = "0x6B579C0", VA = "0x186B589C0")]
	public static void BPALACCNINO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FAPANBOABJG : LCOLBCAIECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public int AHBJNBONLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Queue<double> DHIDGLNOFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double HBOEBLPEGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double ILNGOKDLDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double PKJOAJLCCFI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double HIGNMMLGLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6B58250", Offset = "0x6B57250", VA = "0x186B58250", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double NIOKFBAFFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x18AB610", Offset = "0x18AA610", VA = "0x1818AB610", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double JLDLLBDBBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9150", Offset = "0x1DF8150", VA = "0x181DF9150", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B58320", Offset = "0x6B57320", VA = "0x186B58320")]
	public FAPANBOABJG(int NLJFNDNHOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6B58130", Offset = "0x6B57130", VA = "0x186B58130", Slot = "7")]
	public void BPIHAJEKHLO(double PAFHPJKJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B582B0", Offset = "0x6B572B0", VA = "0x186B582B0", Slot = "8")]
	public void KNIDJLMEEBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class KAIGBAMCAGA : LCOLBCAIECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private long MJMIIGGLEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double GFFFEGPEJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double NCOBLDCBMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double FAAHNHGLGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double HIAJLENNAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double HBOEBLPEGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private double ILNGOKDLDJC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double NIOKFBAFFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x58A29D0", Offset = "0x58A19D0", VA = "0x1858A29D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JLDLLBDBBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x58A2EA0", Offset = "0x58A1EA0", VA = "0x1858A2EA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double EJDJMOFKCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x58A2E70", Offset = "0x58A1E70", VA = "0x1858A2E70")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double HIGNMMLGLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2379720", Offset = "0x2378720", VA = "0x182379720", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B5F120", Offset = "0x6B5E120", VA = "0x186B5F120", Slot = "7")]
	public virtual void BPIHAJEKHLO(double PAFHPJKJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B5F240", Offset = "0x6B5E240", VA = "0x186B5F240", Slot = "8")]
	public virtual void KNIDJLMEEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B579F0", Offset = "0x6B569F0", VA = "0x186B579F0")]
	public KAIGBAMCAGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class ELHKHCEBMPP : KAIGBAMCAGA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double JFKCMLEKCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x58A2E50", Offset = "0x58A1E50", VA = "0x1858A2E50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x58A2E40", Offset = "0x58A1E40", VA = "0x1858A2E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6B57880", Offset = "0x6B56880", VA = "0x186B57880", Slot = "7")]
	public override void BPIHAJEKHLO(double PAFHPJKJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6B579B0", Offset = "0x6B569B0", VA = "0x186B579B0", Slot = "8")]
	public override void KNIDJLMEEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6B579F0", Offset = "0x6B569F0", VA = "0x186B579F0")]
	public ELHKHCEBMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LCOLBCAIECA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double HIGNMMLGLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double NIOKFBAFFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double JLDLLBDBBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GBPNNGNHDAK
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface ALBKCPOLNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool FBOIHLABJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DDOGPGPMMPB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private abstract class ENMEHNHHGPP<TPromise, TMainThreadPromise> : ALBKCPOLNEJ where TPromise : PGOMONKDBKH where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly TPromise APOAAEPOBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly TMainThreadPromise JHKEDEEGJHC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise DPOBJAFOFLD
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3532FB0", Offset = "0x3531FB0", VA = "0x183532FB0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FBOIHLABJLL
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x3533030", Offset = "0x3532030", VA = "0x183533030", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA10", Offset = "0x7CDA10", VA = "0x1807CEA10")]
		protected ENMEHNHHGPP(TPromise APOAAEPOBMH, TMainThreadPromise PGPIDCFJKLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3533010", Offset = "0x3532010", VA = "0x183533010", Slot = "5")]
		public void DDOGPGPMMPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void DOCNFKGKMIH(TPromise APOAAEPOBMH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class JIPAJADMNKH<T> : ENMEHNHHGPP<MLBHOBCFFDI<T>, AGLJGCDAHHO<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2130", Offset = "0x3CD1130", VA = "0x183CD2130")]
		public JIPAJADMNKH(MLBHOBCFFDI<T> APOAAEPOBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1EC0", Offset = "0x3CD0EC0", VA = "0x183CD1EC0", Slot = "6")]
		protected override void DOCNFKGKMIH(MLBHOBCFFDI<T> APOAAEPOBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2100", Offset = "0x3CD1100", VA = "0x183CD2100")]
		[CompilerGenerated]
		private void IODDIPHIKML(T NIKEINPNLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3CD20D0", Offset = "0x3CD10D0", VA = "0x183CD20D0")]
		[CompilerGenerated]
		private void HKADIOFHEBL(string FKMKCMGJCIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class IMPJNNADBMA : ALBKCPOLNEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Action LNMJHEPMAAO;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FBOIHLABJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
		public IMPJNNADBMA(Action LNMJHEPMAAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xC3B6D0", Offset = "0xC3A6D0", VA = "0x180C3B6D0", Slot = "5")]
		public void DDOGPGPMMPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly List<ALBKCPOLNEJ> ENEHBBHDJHA;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x28B7870", Offset = "0x28B6870", VA = "0x1828B7870")]
	public static MLBHOBCFFDI<T> AILLEELMGAN<T>(this MLBHOBCFFDI<T> APOAAEPOBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B59A80", Offset = "0x6B58A80", VA = "0x186B59A80")]
	public static void AILLEELMGAN(Action LNMJHEPMAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x28B78D0", Offset = "0x28B68D0", VA = "0x1828B78D0")]
	private static MLBHOBCFFDI<T> FNMLHIMPDGG<T>(MLBHOBCFFDI<T> APOAAEPOBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B59F00", Offset = "0x6B58F00", VA = "0x186B59F00")]
	private static void MOCCHDAPGFP(ALBKCPOLNEJ GGFIFGABLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B59B20", Offset = "0x6B58B20", VA = "0x186B59B20")]
	private static void FBGLHOOJAGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B59E00", Offset = "0x6B58E00", VA = "0x186B59E00")]
	private static void HNOMILILMGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A110", Offset = "0x6B59110", VA = "0x186B5A110")]
	private static void NGJNFNONJCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class PDAAKMJNLAI
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct LOJNOBPLJEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TaskCompletionSource<Scene> BLFGDNOGADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly string DGPOLNCNDIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly LoadSceneMode CELMHKDHMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool DKCODGHGAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6B66010", Offset = "0x6B65010", VA = "0x186B66010")]
		public LOJNOBPLJEG(TaskCompletionSource<Scene> JJEONHGCOBI, string DGPOLNCNDIL, LoadSceneMode CELMHKDHMOI, bool DKCODGHGAEK, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NEAKOCKIPHD : IAsyncStateMachine
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
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private NENCAGLHEIB<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x6B68210", Offset = "0x6B67210", VA = "0x186B68210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6B68AB0", Offset = "0x6B67AB0", VA = "0x186B68AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct DGALHCEIIHO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6B563F0", Offset = "0x6B553F0", VA = "0x186B563F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6B56710", Offset = "0x6B55710", VA = "0x186B56710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct CFKDBGOEACK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private LOJNOBPLJEG <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6B51B90", Offset = "0x6B50B90", VA = "0x186B51B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6B51F40", Offset = "0x6B50F40", VA = "0x186B51F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HDODOLIGOOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AGLJGCDAHHO<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public HDODOLIGOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6B5C100", Offset = "0x6B5B100", VA = "0x186B5C100")]
		internal void KEPGGKDEJPO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct EBDNDCBHGHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

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
		private HDODOLIGOOH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6B56770", Offset = "0x6B55770", VA = "0x186B56770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6B57310", Offset = "0x6B56310", VA = "0x186B57310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct OEKIONIONIN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6B69F90", Offset = "0x6B68F90", VA = "0x186B69F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6B6A4A0", Offset = "0x6B694A0", VA = "0x186B6A4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct LBNDDCNJJPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6B61A30", Offset = "0x6B60A30", VA = "0x186B61A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6B62580", Offset = "0x6B61580", VA = "0x186B62580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LGMJFPHBJKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public LGMJFPHBJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6B62FE0", Offset = "0x6B61FE0", VA = "0x186B62FE0")]
		internal bool EMAOBKKCPLI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class HEILOHFIDEK : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public KODAAIAJNHH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public HEILOHFIDEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6B5C540", Offset = "0x6B5B540", VA = "0x186B5C540", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6B5C1B0", Offset = "0x6B5B1B0", VA = "0x186B5C1B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6B5C160", Offset = "0x6B5B160", VA = "0x186B5C160")]
		private void HPAIKACEAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6B5C4F0", Offset = "0x6B5B4F0", VA = "0x186B5C4F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class EBMILNPFCDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public AGLJGCDAHHO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public EBMILNPFCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6B57600", Offset = "0x6B56600", VA = "0x186B57600")]
		internal bool NBFIHEMAIHN(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6B57380", Offset = "0x6B56380", VA = "0x186B57380")]
		internal void DFEJNDIFALH(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class KHFONFIAIMP : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AGLJGCDAHHO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private EBMILNPFCDH <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public KHFONFIAIMP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6B5F4F0", Offset = "0x6B5E4F0", VA = "0x186B5F4F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6B5FC00", Offset = "0x6B5EC00", VA = "0x186B5FC00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly ICollection<string> KILFALOKHAL;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static PGOMONKDBKH BLKEBOELFNI;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static AsyncOperation AAMPLDAIOKB;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static PGOMONKDBKH EAMKMOKCNLF;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static string EOAPJDNCCNE;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static ThreadPriority NLPPGLCEGIA;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task IAJOICFOHEO;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static List<SceneInstance> BKGLPGMMDHJ;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly Queue<LOJNOBPLJEG> AEPHMKKHIAN;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static Task IOPHPILMGND;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool ADKNOHOADAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6B6AFA0", Offset = "0x6B69FA0", VA = "0x186B6AFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool PLLENCGLGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6B6B250", Offset = "0x6B6A250", VA = "0x186B6B250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool BPKLNBLFOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6B6BFB0", Offset = "0x6B6AFB0", VA = "0x186B6BFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool EKPJMMIOAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6B6B1C0", Offset = "0x6B6A1C0", VA = "0x186B6B1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> CHNBHAHLILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6B6A930", Offset = "0x6B69930", VA = "0x186B6A930")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6B6AB90", Offset = "0x6B69B90", VA = "0x186B6AB90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BB40", Offset = "0x6B6AB40", VA = "0x186B6BB40")]
	[LDBHLFMBBNG(EOOOIHNINMG.EnteredEditModeNextFrame, 0)]
	private static void KPDBFNDBAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6B6AA40", Offset = "0x6B69A40", VA = "0x186B6AA40")]
	[AsyncStateMachine(typeof(NEAKOCKIPHD))]
	public static Task<Scene> BBNJNLFCFOF(string DGPOLNCNDIL, LoadSceneMode CELMHKDHMOI = LoadSceneMode.Single, bool DKCODGHGAEK = false, [Optional] NENCAGLHEIB<string>.OGJMFKKDMDA HMBLCDDCAJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B8A0", Offset = "0x6B6A8A0", VA = "0x186B6B8A0")]
	[AsyncStateMachine(typeof(DGALHCEIIHO))]
	private static Task JDAOFHJCAMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BC40", Offset = "0x6B6AC40", VA = "0x186B6BC40")]
	[AsyncStateMachine(typeof(CFKDBGOEACK))]
	private static Task NKMLFINGBHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B6ADB0", Offset = "0x6B69DB0", VA = "0x186B6ADB0")]
	[AsyncStateMachine(typeof(EBDNDCBHGHG))]
	private static Task<Scene> CKKEHMCBOGH(string DGPOLNCNDIL, LoadSceneMode CELMHKDHMOI, bool DKCODGHGAEK, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B9E0", Offset = "0x6B6A9E0", VA = "0x186B6B9E0")]
	private static void KHFNACCGJGJ(SceneInstance ILCIGJJMCEH, LoadSceneMode CELMHKDHMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B6F0", Offset = "0x6B6A6F0", VA = "0x186B6B6F0")]
	private static void ICDKBJCKDLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BE90", Offset = "0x6B6AE90", VA = "0x186B6BE90")]
	[AsyncStateMachine(typeof(OEKIONIONIN))]
	private static Task<Scene> PAPLCBDICMO(string DGPOLNCNDIL, LoadSceneMode CELMHKDHMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B7B0", Offset = "0x6B6A7B0", VA = "0x186B6B7B0")]
	private static bool IHFAJPGIGKJ(string DGPOLNCNDIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B6ACA0", Offset = "0x6B69CA0", VA = "0x186B6ACA0")]
	[AsyncStateMachine(typeof(LBNDDCNJJPD))]
	private static Task<Scene> CGNPLKPNFED(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BD10", Offset = "0x6B6AD10", VA = "0x186B6BD10")]
	public static MLBHOBCFFDI<Scene> OEOHCFAGPIF(string DGPOLNCNDIL, LoadSceneMode CELMHKDHMOI = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B420", Offset = "0x6B6A420", VA = "0x186B6B420")]
	public static PGOMONKDBKH HJGFENELBCO(string DGPOLNCNDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B950", Offset = "0x6B6A950", VA = "0x186B6B950")]
	[IteratorStateMachine(typeof(HEILOHFIDEK))]
	private static IEnumerator<JHIBCIKJMBL> KACAMILDLON(string DGPOLNCNDIL, KODAAIAJNHH JKNAMLPPEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B6AF00", Offset = "0x6B69F00", VA = "0x186B6AF00")]
	[IteratorStateMachine(typeof(KHFONFIAIMP))]
	private static IEnumerator<JHIBCIKJMBL> DDKOADCKJEM(string DGPOLNCNDIL, LoadSceneMode CELMHKDHMOI, AGLJGCDAHHO<Scene> JKNAMLPPEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B2F0", Offset = "0x6B6A2F0", VA = "0x186B6B2F0")]
	public static bool GNOEJBOCOOB([Out] string GMEEMIPAIEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class MENCMJLGOCG
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6B67730", Offset = "0x6B66730", VA = "0x186B67730")]
	public static IDisposable LHCGOELADOG(this FGEMNFOIAEP DFKOHNJAKHM, float MHPAHFGNGLL, Action<float> GGJDPCAEIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6B676B0", Offset = "0x6B666B0", VA = "0x186B676B0")]
	public static IDisposable HIPNFFGJBKF(this FGEMNFOIAEP DFKOHNJAKHM, Action<float> GGJDPCAEIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6B677C0", Offset = "0x6B667C0", VA = "0x186B677C0")]
	public static IDisposable OFOODPGBFKK(this FGEMNFOIAEP DFKOHNJAKHM, Action<float> GGJDPCAEIIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class GCOKPIDGLNO
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6B5AD90", Offset = "0x6B59D90", VA = "0x186B5AD90")]
	public static IDisposable PGABPOMFABJ(this MonoBehaviour ODNBCIDMCKP, Action GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6B5AD00", Offset = "0x6B59D00", VA = "0x186B5AD00")]
	public static IDisposable PGABPOMFABJ(this MonoBehaviour ODNBCIDMCKP, Action<float> GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A280", Offset = "0x6B59280", VA = "0x186B5A280")]
	public static IDisposable ACILEHIEJCJ(this MonoBehaviour ODNBCIDMCKP, Action GGJDPCAEIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A690", Offset = "0x6B59690", VA = "0x186B5A690")]
	public static IDisposable FMNLHEPNJBM(this MonoBehaviour ODNBCIDMCKP, Action GGJDPCAEIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A610", Offset = "0x6B59610", VA = "0x186B5A610")]
	public static IDisposable FMNLHEPNJBM(this MonoBehaviour ODNBCIDMCKP, Action<float> GGJDPCAEIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6B5AC80", Offset = "0x6B59C80", VA = "0x186B5AC80")]
	public static IDisposable OJKELICICFG(this MonoBehaviour ODNBCIDMCKP, Action GGJDPCAEIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A8F0", Offset = "0x6B598F0", VA = "0x186B5A8F0")]
	public static IDisposable KEPBJMMJHBH(this MonoBehaviour ODNBCIDMCKP, Action GGJDPCAEIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A300", Offset = "0x6B59300", VA = "0x186B5A300")]
	public static IDisposable DEEBPNJMKFK(this MonoBehaviour ODNBCIDMCKP, Action GGJDPCAEIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A380", Offset = "0x6B59380", VA = "0x186B5A380")]
	public static IDisposable DGEBDPNEECH(this MonoBehaviour ODNBCIDMCKP, float MHPAHFGNGLL, Action<float> GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML, bool PNDJOBOMDCI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6B5AA10", Offset = "0x6B59A10", VA = "0x186B5AA10")]
	public static IDisposable NIBKODHDHGE(this MonoBehaviour ODNBCIDMCKP, float MHPAHFGNGLL, Action<float> GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML, bool PNDJOBOMDCI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6B5AB30", Offset = "0x6B59B30", VA = "0x186B5AB30")]
	public static IDisposable NJFMOAKGCAL(this MonoBehaviour ODNBCIDMCKP, float MHPAHFGNGLL, Action<float> GGJDPCAEIIE, bool PNDJOBOMDCI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A850", Offset = "0x6B59850", VA = "0x186B5A850")]
	public static IDisposable JGBFPGOBPOI(this MonoBehaviour ODNBCIDMCKP, Action<float> GGJDPCAEIIE, bool PNDJOBOMDCI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A7B0", Offset = "0x6B597B0", VA = "0x186B5A7B0")]
	public static IDisposable IOILFJEEEPG(this MonoBehaviour ODNBCIDMCKP, Action<float> GGJDPCAEIIE, bool PNDJOBOMDCI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A570", Offset = "0x6B59570", VA = "0x186B5A570")]
	public static IDisposable EBHBOAJBBGI(this MonoBehaviour ODNBCIDMCKP, Action<float> GGJDPCAEIIE, bool PNDJOBOMDCI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A710", Offset = "0x6B59710", VA = "0x186B5A710")]
	public static IDisposable HOLDKBHBMDH(this MonoBehaviour ODNBCIDMCKP, Action<float> GGJDPCAEIIE, bool PNDJOBOMDCI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A970", Offset = "0x6B59970", VA = "0x186B5A970")]
	public static IDisposable NGLLEILOJDF(this MonoBehaviour ODNBCIDMCKP, Action<float> GGJDPCAEIIE, bool PNDJOBOMDCI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A4D0", Offset = "0x6B594D0", VA = "0x186B5A4D0")]
	public static IDisposable DOGGPBBGOGE(this MonoBehaviour ODNBCIDMCKP, Action<float> GGJDPCAEIIE, bool PNDJOBOMDCI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6B5A430", Offset = "0x6B59430", VA = "0x186B5A430")]
	public static IDisposable DGGNBDKNGOB(this MonoBehaviour ODNBCIDMCKP, Action<float> GGJDPCAEIIE, bool PNDJOBOMDCI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6B5ABD0", Offset = "0x6B59BD0", VA = "0x186B5ABD0")]
	public static IDisposable OBAPCBOIPMM(this MonoBehaviour ODNBCIDMCKP, float MHPAHFGNGLL, Action<float> GGJDPCAEIIE, bool PNDJOBOMDCI = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NOGDLJLJLLP
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class MJHOAMJIGFP : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public DLJPFICMPDE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private BNGDJGOIPBN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public MJHOAMJIGFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6B67840", Offset = "0x6B66840", VA = "0x186B67840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6B67920", Offset = "0x6B66920", VA = "0x186B67920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class BAGNCOALPKC : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public DLJPFICMPDE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private BNGDJGOIPBN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public BAGNCOALPKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6B51720", Offset = "0x6B50720", VA = "0x186B51720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6B51810", Offset = "0x6B50810", VA = "0x186B51810", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6B694D0", Offset = "0x6B684D0", VA = "0x186B694D0")]
	public static EOCGEKKEBMP PGABPOMFABJ(Action GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6B69580", Offset = "0x6B68580", VA = "0x186B69580")]
	public static EOCGEKKEBMP PGABPOMFABJ(Behaviour DFKOHNJAKHM, Action GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6B69640", Offset = "0x6B68640", VA = "0x186B69640")]
	public static EOCGEKKEBMP PGABPOMFABJ(Behaviour DFKOHNJAKHM, Action<float> GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6B697F0", Offset = "0x6B687F0", VA = "0x186B697F0")]
	[IteratorStateMachine(typeof(MJHOAMJIGFP))]
	private static IEnumerator<JHIBCIKJMBL> PNKNIENMPMI(DLJPFICMPDE AAHIACOIGAI, Action GGJDPCAEIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6B69760", Offset = "0x6B68760", VA = "0x186B69760")]
	[IteratorStateMachine(typeof(BAGNCOALPKC))]
	private static IEnumerator<JHIBCIKJMBL> PNKNIENMPMI(DLJPFICMPDE AAHIACOIGAI, Action<float> GGJDPCAEIIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class IJKDACDNEJG : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class FMIOMLEICNF : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public IJKDACDNEJG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public FMIOMLEICNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6B59050", Offset = "0x6B58050", VA = "0x186B59050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6B590E0", Offset = "0x6B580E0", VA = "0x186B590E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly DLJPFICMPDE KGCOFKKMBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Action AJANFAPHMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool NJFPDENCBMA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool IJLLMBECAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5790", VA = "0x1807C6790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6B5D280", Offset = "0x6B5C280", VA = "0x186B5D280")]
	public IJKDACDNEJG(DLJPFICMPDE KGCOFKKMBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6B5D160", Offset = "0x6B5C160", VA = "0x186B5D160")]
	[IteratorStateMachine(typeof(FMIOMLEICNF))]
	private IEnumerator<JHIBCIKJMBL> EFPFDGMBJDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6B5D1E0", Offset = "0x6B5C1E0", VA = "0x186B5D1E0", Slot = "4")]
	public void OnCompleted(Action KPEFKFKJKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	public void BCLMOFPPMLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class IOGCGNCMMMK
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B5D390", Offset = "0x6B5C390", VA = "0x186B5D390")]
	public static IJKDACDNEJG KIMBMIDADNK(this DLJPFICMPDE KGCOFKKMBML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class FBHADEHJKBI
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class IECNJLCBEOH : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public ICFAFGNNOHM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public IECNJLCBEOH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6B5C8D0", Offset = "0x6B5B8D0", VA = "0x186B5C8D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6B5C950", Offset = "0x6B5B950", VA = "0x186B5C950", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6B586F0", Offset = "0x6B576F0", VA = "0x186B586F0")]
	public static EOCGEKKEBMP PGABPOMFABJ(float MHPAHFGNGLL, Action<float> GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML, bool PNDJOBOMDCI = true, [Optional] PDJJIFOPPPL LDNIAKCKACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6B587F0", Offset = "0x6B577F0", VA = "0x186B587F0")]
	public static EOCGEKKEBMP PGABPOMFABJ(MonoBehaviour ODNBCIDMCKP, float MHPAHFGNGLL, Action<float> GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML, bool PNDJOBOMDCI = true, [Optional] PDJJIFOPPPL LDNIAKCKACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6B583D0", Offset = "0x6B573D0", VA = "0x186B583D0")]
	public static EOCGEKKEBMP ADJLEAFBBEB(MonoBehaviour ODNBCIDMCKP, float MHPAHFGNGLL, Action<float> GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML, bool PNDJOBOMDCI = true, [Optional] PDJJIFOPPPL LDNIAKCKACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6B58550", Offset = "0x6B57550", VA = "0x186B58550")]
	public static EOCGEKKEBMP BEIPFOAHCOD(FGEMNFOIAEP DFKOHNJAKHM, float MHPAHFGNGLL, Action<float> GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML, bool PNDJOBOMDCI = true, [Optional] PDJJIFOPPPL LDNIAKCKACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6B58900", Offset = "0x6B57900", VA = "0x186B58900")]
	private static IEnumerator<JHIBCIKJMBL> PNKNIENMPMI(IGDCEBBCAGI HNHOHLLJALC, float MHPAHFGNGLL, DLJPFICMPDE AAHIACOIGAI, Action<float> GGJDPCAEIIE, bool PNDJOBOMDCI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6B584F0", Offset = "0x6B574F0", VA = "0x186B584F0")]
	private static IEnumerator<JHIBCIKJMBL> BBAKMNJBAJM(IGDCEBBCAGI HNHOHLLJALC, float MHPAHFGNGLL, DLJPFICMPDE AAHIACOIGAI, Action<float> GGJDPCAEIIE, bool PNDJOBOMDCI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6B58660", Offset = "0x6B57660", VA = "0x186B58660")]
	[IteratorStateMachine(typeof(IECNJLCBEOH))]
	private static IEnumerator<JHIBCIKJMBL> EHBPLPBEOLO(ICFAFGNNOHM DCFBJOGNPMG, float MHPAHFGNGLL, DLJPFICMPDE AAHIACOIGAI, Action<float> GGJDPCAEIIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class AMPGKBPJPJO
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class JEICPMAPAAK : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public DLJPFICMPDE queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public JEICPMAPAAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6B5EBC0", Offset = "0x6B5DBC0", VA = "0x186B5EBC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6B5EC80", Offset = "0x6B5DC80", VA = "0x186B5EC80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6B51530", Offset = "0x6B50530", VA = "0x186B51530")]
	[IteratorStateMachine(typeof(JEICPMAPAAK))]
	private static IEnumerator<JHIBCIKJMBL> BKFDKAODKDD(DLJPFICMPDE KGCOFKKMBML, Func<bool> KOGAEBNIPPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6B515C0", Offset = "0x6B505C0", VA = "0x186B515C0")]
	public static EOCGEKKEBMP NAJGJPOPDNI(this MonoBehaviour ODNBCIDMCKP, Func<bool> KOGAEBNIPPH, DLJPFICMPDE KGCOFKKMBML = DLJPFICMPDE.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class LDCNLCIPOLI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class IPCOPCJCJNH : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public DLJPFICMPDE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public IPCOPCJCJNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6B5D4D0", Offset = "0x6B5C4D0", VA = "0x186B5D4D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6B5D540", Offset = "0x6B5C540", VA = "0x186B5D540", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class HOAJDDADLBA : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public DLJPFICMPDE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private JHIBCIKJMBL <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public HOAJDDADLBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6B5C5D0", Offset = "0x6B5B5D0", VA = "0x186B5C5D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6B5C660", Offset = "0x6B5B660", VA = "0x186B5C660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6B62A00", Offset = "0x6B61A00", VA = "0x186B62A00")]
	[IteratorStateMachine(typeof(IPCOPCJCJNH))]
	private static IEnumerator<JHIBCIKJMBL> EFPFDGMBJDF(float FHPCLBOOPLN, DLJPFICMPDE AAHIACOIGAI, Action DCLBDAHBMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6B62D20", Offset = "0x6B61D20", VA = "0x186B62D20")]
	[IteratorStateMachine(typeof(HOAJDDADLBA))]
	private static IEnumerator<JHIBCIKJMBL> HLFNJGCFLEM(float FHPCLBOOPLN, DLJPFICMPDE AAHIACOIGAI, Action DCLBDAHBMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6B62720", Offset = "0x6B61720", VA = "0x186B62720")]
	public static IDisposable BHMNDMJGPKC(this MonoBehaviour ODNBCIDMCKP, float FHPCLBOOPLN, Action DCLBDAHBMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6B62870", Offset = "0x6B61870", VA = "0x186B62870")]
	public static EOCGEKKEBMP DGKOFGDFPKM(this MonoBehaviour ODNBCIDMCKP, float FHPCLBOOPLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6B625F0", Offset = "0x6B615F0", VA = "0x186B625F0")]
	public static EOCGEKKEBMP BHMNDMJGPKC(this MonoBehaviour ODNBCIDMCKP, float FHPCLBOOPLN, DLJPFICMPDE AAHIACOIGAI, Action DCLBDAHBMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6B62DC0", Offset = "0x6B61DC0", VA = "0x186B62DC0")]
	public static EOCGEKKEBMP JFDKPACLGMD(this MonoBehaviour ODNBCIDMCKP, Action DCLBDAHBMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6B62840", Offset = "0x6B61840", VA = "0x186B62840")]
	public static EOCGEKKEBMP CJOOKGGJFKA(this MonoBehaviour ODNBCIDMCKP, Action DCLBDAHBMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6B62C40", Offset = "0x6B61C40", VA = "0x186B62C40")]
	public static EOCGEKKEBMP GFMFPIPHEPL(this MonoBehaviour ODNBCIDMCKP, Action DCLBDAHBMFI, [Optional] PDJJIFOPPPL LDNIAKCKACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6B62DE0", Offset = "0x6B61DE0", VA = "0x186B62DE0")]
	public static EOCGEKKEBMP JJFGGIKPOCK(this MonoBehaviour ODNBCIDMCKP, Action DCLBDAHBMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6B62E10", Offset = "0x6B61E10", VA = "0x186B62E10")]
	public static EOCGEKKEBMP LNBCKNGJJPD(this MonoBehaviour ODNBCIDMCKP, Action DCLBDAHBMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6B62930", Offset = "0x6B61930", VA = "0x186B62930")]
	private static EOCGEKKEBMP DIEJPFKNLAD(MonoBehaviour ODNBCIDMCKP, DLJPFICMPDE KGCOFKKMBML, Action DCLBDAHBMFI, [Optional] PDJJIFOPPPL LDNIAKCKACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6B62B70", Offset = "0x6B61B70", VA = "0x186B62B70")]
	public static EOCGEKKEBMP GAJECIICHKE(this MonoBehaviour ODNBCIDMCKP, float JGBJPJKFLOE, Action DCLBDAHBMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6B62F10", Offset = "0x6B61F10", VA = "0x186B62F10")]
	public static EOCGEKKEBMP NFKPKLIGCKE(this MonoBehaviour ODNBCIDMCKP, float JGBJPJKFLOE, Action DCLBDAHBMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6B62E40", Offset = "0x6B61E40", VA = "0x186B62E40")]
	public static EOCGEKKEBMP MAIFJABKLKF(this MonoBehaviour ODNBCIDMCKP, float JGBJPJKFLOE, Action DCLBDAHBMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6B62AA0", Offset = "0x6B61AA0", VA = "0x186B62AA0")]
	public static EOCGEKKEBMP FEACNJGPLIK(this MonoBehaviour ODNBCIDMCKP, float JGBJPJKFLOE, Action DCLBDAHBMFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FMPONHMOMGA : EMPJCCAFEDA, IEnumerable<EMPJCCAFEDA>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly List<EMPJCCAFEDA> IELJPENDAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool BLHIJDNNJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Action BCPKHOOFFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool JFIOCPGBFHP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PEDMNDHKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6B59300", Offset = "0x6B58300", VA = "0x186B59300", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NEKDOLAEDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6B59940", Offset = "0x6B58940", VA = "0x186B59940", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6B59260", Offset = "0x6B58260", VA = "0x186B59260", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6B599E0", Offset = "0x6B589E0", VA = "0x186B599E0")]
	public FMPONHMOMGA([Optional] Action BCPKHOOFFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6B59130", Offset = "0x6B58130", VA = "0x186B59130")]
	public void BGLDHBEBEIE(EMPJCCAFEDA DGNAAFOCGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6B597E0", Offset = "0x6B587E0", VA = "0x186B597E0")]
	private void NGCMNJCHJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6B597D0", Offset = "0x6B587D0", VA = "0x186B597D0", Slot = "7")]
	public bool LENANMBJDOP(bool CLNMAALIOEC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6B594C0", Offset = "0x6B584C0", VA = "0x186B594C0", Slot = "8")]
	public bool LENANMBJDOP(Action LNMJHEPMAAO, bool CLNMAALIOEC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6B59440", Offset = "0x6B58440", VA = "0x186B59440", Slot = "9")]
	public IEnumerator<EMPJCCAFEDA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6B59440", Offset = "0x6B58440", VA = "0x186B59440", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class IDGAKOBKOLG : AFMBJFKOOJD
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class MFDIKBBDEDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public IDGAKOBKOLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public MFDIKBBDEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6B51860", Offset = "0x6B50860", VA = "0x186B51860")]
		internal void KCFOCKMCGGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class BBKEKFCHGDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public IDGAKOBKOLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public BBKEKFCHGDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6B51860", Offset = "0x6B50860", VA = "0x186B51860")]
		internal void DEKINIJNHEN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly float HEPCHPNIOME;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6B58F50", Offset = "0x6B57F50", VA = "0x186B58F50")]
	public IDGAKOBKOLG(Behaviour DFKOHNJAKHM, float HEPCHPNIOME, [Optional] Action BCPKHOOFFMN, [Optional] PDJJIFOPPPL LDNIAKCKACA, [Optional] IGDCEBBCAGI HNHOHLLJALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6B5C7C0", Offset = "0x6B5B7C0", VA = "0x186B5C7C0", Slot = "9")]
	protected override bool ECBFLENFGBM(Action LNMJHEPMAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6B5C6B0", Offset = "0x6B5B6B0", VA = "0x186B5C6B0", Slot = "10")]
	protected override bool BHGKHCJPPPP(Action LNMJHEPMAAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface EMPJCCAFEDA
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool PEDMNDHKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NEKDOLAEDIO;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LENANMBJDOP(bool CLNMAALIOEC = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LENANMBJDOP(Action LNMJHEPMAAO, bool CLNMAALIOEC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class AFMBJFKOOJD : EMPJCCAFEDA
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class CCEHJJFJIMO : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AFMBJFKOOJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public CCEHJJFJIMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6B51A70", Offset = "0x6B50A70", VA = "0x186B51A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6B51B40", Offset = "0x6B50B40", VA = "0x186B51B40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Behaviour DFKOHNJAKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action BCPKHOOFFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private HNENBNAEPGI ELPHCBBGKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly PDJJIFOPPPL LDNIAKCKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	protected readonly IGDCEBBCAGI HNHOHLLJALC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool PEDMNDHKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xFBFEB0", Offset = "0xFBEEB0", VA = "0x180FBFEB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NEKDOLAEDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6B512A0", Offset = "0x6B502A0", VA = "0x186B512A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6B50DD0", Offset = "0x6B4FDD0", VA = "0x186B50DD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6B51340", Offset = "0x6B50340", VA = "0x186B51340")]
	protected AFMBJFKOOJD(Behaviour DFKOHNJAKHM, [Optional] Action BCPKHOOFFMN, [Optional] PDJJIFOPPPL LDNIAKCKACA, [Optional] IGDCEBBCAGI HNHOHLLJALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6B511A0", Offset = "0x6B501A0", VA = "0x186B511A0", Slot = "7")]
	public bool LENANMBJDOP(bool CLNMAALIOEC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6B51140", Offset = "0x6B50140", VA = "0x186B51140", Slot = "8")]
	public bool LENANMBJDOP(Action LNMJHEPMAAO, bool CLNMAALIOEC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool ECBFLENFGBM(Action LNMJHEPMAAO);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool BHGKHCJPPPP(Action LNMJHEPMAAO);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6B51200", Offset = "0x6B50200", VA = "0x186B51200")]
	protected void LFNNPKPIKJP(Action LNMJHEPMAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6B50F00", Offset = "0x6B4FF00", VA = "0x186B50F00")]
	protected PGOMONKDBKH KBFNBIBAFGH(float NALPHCAAKLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6B51220", Offset = "0x6B50220", VA = "0x186B51220")]
	private void MHNHNGMDNFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6B50E70", Offset = "0x6B4FE70", VA = "0x186B50E70")]
	[IteratorStateMachine(typeof(CCEHJJFJIMO))]
	private IEnumerator<JHIBCIKJMBL> GKABIDLPJEI(float NALPHCAAKLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6B50D90", Offset = "0x6B4FD90", VA = "0x186B50D90")]
	[CompilerGenerated]
	private void ANLJJKMPICD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class OCGPBCLGMMH : AFMBJFKOOJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float COHAHBBNEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly int DDPGAGNMCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float AJJLIAIPHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly float[] EAEMDGEPMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int GBIEJAPFKGO;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6B69DF0", Offset = "0x6B68DF0", VA = "0x186B69DF0")]
	public OCGPBCLGMMH(Behaviour DFKOHNJAKHM, float PFKFMMHDBKB, int DDPGAGNMCLC, [Optional] Action BCPKHOOFFMN, float AJJLIAIPHBE = 0f, [Optional] PDJJIFOPPPL LDNIAKCKACA, [Optional] IGDCEBBCAGI HNHOHLLJALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "9")]
	protected override bool ECBFLENFGBM(Action LNMJHEPMAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6B69B70", Offset = "0x6B68B70", VA = "0x186B69B70", Slot = "10")]
	protected override bool BHGKHCJPPPP(Action LNMJHEPMAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6B69D70", Offset = "0x6B68D70", VA = "0x186B69D70")]
	private void IIAIJNIAAMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class FJFNIMMPCNK : AFMBJFKOOJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly float HEPCHPNIOME;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6B58F50", Offset = "0x6B57F50", VA = "0x186B58F50")]
	public FJFNIMMPCNK(Behaviour DFKOHNJAKHM, float HEPCHPNIOME, [Optional] Action BCPKHOOFFMN, [Optional] PDJJIFOPPPL LDNIAKCKACA, [Optional] IGDCEBBCAGI HNHOHLLJALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "9")]
	protected override bool ECBFLENFGBM(Action LNMJHEPMAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6B58F10", Offset = "0x6B57F10", VA = "0x186B58F10", Slot = "10")]
	protected override bool BHGKHCJPPPP(Action LNMJHEPMAAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class NNGIKGKLCFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class FIICFENJMBG : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public FIICFENJMBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6B58E50", Offset = "0x6B57E50", VA = "0x186B58E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6B58EC0", Offset = "0x6B57EC0", VA = "0x186B58EC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private EOCGEKKEBMP GJBBCGPOBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private FGEMNFOIAEP DFKOHNJAKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Action<float> IABFCEIFJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private DLJPFICMPDE KGCOFKKMBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float POICGEJNPEK;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6B692F0", Offset = "0x6B682F0", VA = "0x186B692F0")]
	public NNGIKGKLCFJ(FGEMNFOIAEP DFKOHNJAKHM, float MHPAHFGNGLL, Action<float> GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6B69150", Offset = "0x6B68150", VA = "0x186B69150")]
	private void PFDCLJOAOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6B68FF0", Offset = "0x6B67FF0", VA = "0x186B68FF0")]
	private void OAJMCHNECGE(string FKMKCMGJCIN, Action DMEPMPHMJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6B68DC0", Offset = "0x6B67DC0", VA = "0x186B68DC0")]
	[IteratorStateMachine(typeof(FIICFENJMBG))]
	private IEnumerator<JHIBCIKJMBL> HKGEFPGOGBH(Action DMEPMPHMJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6B68D60", Offset = "0x6B67D60", VA = "0x186B68D60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6B68E40", Offset = "0x6B67E40", VA = "0x186B68E40")]
	[CompilerGenerated]
	private void MOCIFKMOLCF(string BDHJMINHKON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class MBBPNEBGCOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class OHFOFBNAHKJ : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public OHFOFBNAHKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6B58E50", Offset = "0x6B57E50", VA = "0x186B58E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6B6A710", Offset = "0x6B69710", VA = "0x186B6A710", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private EOCGEKKEBMP GJBBCGPOBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private MonoBehaviour ODNBCIDMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action GGJDPCAEIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Action<float> IABFCEIFJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private DLJPFICMPDE KGCOFKKMBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float POICGEJNPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool PNDJOBOMDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly PDJJIFOPPPL LDNIAKCKACA;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6B66C80", Offset = "0x6B65C80", VA = "0x186B66C80")]
	public MBBPNEBGCOA(MonoBehaviour ODNBCIDMCKP, Action GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML, [Optional] PDJJIFOPPPL LDNIAKCKACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6B66E70", Offset = "0x6B65E70", VA = "0x186B66E70")]
	public MBBPNEBGCOA(MonoBehaviour ODNBCIDMCKP, Action<float> GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML, [Optional] PDJJIFOPPPL LDNIAKCKACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6B670B0", Offset = "0x6B660B0", VA = "0x186B670B0")]
	public MBBPNEBGCOA(MonoBehaviour ODNBCIDMCKP, float MHPAHFGNGLL, Action<float> GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML, bool PNDJOBOMDCI = true, [Optional] PDJJIFOPPPL LDNIAKCKACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1A46C00", Offset = "0x1A45C00", VA = "0x181A46C00")]
	private MBBPNEBGCOA(PDJJIFOPPPL LDNIAKCKACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6B66670", Offset = "0x6B65670", VA = "0x186B66670")]
	internal static MBBPNEBGCOA KMIKPKEMEAD(MonoBehaviour ODNBCIDMCKP, float MHPAHFGNGLL, Action<float> GGJDPCAEIIE, DLJPFICMPDE KGCOFKKMBML, bool PNDJOBOMDCI = true, [Optional] PDJJIFOPPPL LDNIAKCKACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6B66B10", Offset = "0x6B65B10", VA = "0x186B66B10")]
	private void PGABPOMFABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6B661F0", Offset = "0x6B651F0", VA = "0x186B661F0")]
	private void HDFAKLCMCLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6B66960", Offset = "0x6B65960", VA = "0x186B66960")]
	private void PFDCLJOAOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6B664B0", Offset = "0x6B654B0", VA = "0x186B664B0")]
	private void JNMECDBIKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6B667A0", Offset = "0x6B657A0", VA = "0x186B667A0")]
	private void OAJMCHNECGE(string FKMKCMGJCIN, Action DMEPMPHMJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6B663A0", Offset = "0x6B653A0", VA = "0x186B663A0")]
	[IteratorStateMachine(typeof(OHFOFBNAHKJ))]
	private IEnumerator<JHIBCIKJMBL> HKGEFPGOGBH(Action DMEPMPHMJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6B66190", Offset = "0x6B65190", VA = "0x186B66190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6B668D0", Offset = "0x6B658D0", VA = "0x186B668D0")]
	[CompilerGenerated]
	private void OBHBAFBFELC(string BDHJMINHKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6B66420", Offset = "0x6B65420", VA = "0x186B66420")]
	[CompilerGenerated]
	private void IPAHOMHIDKB(string BDHJMINHKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6B66100", Offset = "0x6B65100", VA = "0x186B66100")]
	[CompilerGenerated]
	private void COKHCMANFCC(string BDHJMINHKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6B66070", Offset = "0x6B65070", VA = "0x186B66070")]
	[CompilerGenerated]
	private void AGAINPNLKIH(string BDHJMINHKON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Flags]
internal enum GFPAFFBFIDB : byte
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
internal sealed class BFIBLAEJEDD : IGDCEBBCAGI
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float PJHOBHPEKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6B519C0", Offset = "0x6B509C0", VA = "0x186B519C0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float HANFADPBCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6B519D0", Offset = "0x6B509D0", VA = "0x186B519D0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double HMIKKHILAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6B51A50", Offset = "0x6B50A50", VA = "0x186B51A50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6B519E0", Offset = "0x6B509E0", VA = "0x186B519E0")]
	[ILJDPBHFAFI(DIDBPCEENMM.None)]
	private static void LJGEHEAHHOL(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	[Preserve]
	internal BFIBLAEJEDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface IDDHMHHAJAO
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEADJHCAEHI(string ONGJKHHOIAM);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJNJLBBPMHM();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal interface JOPFCFAJIDD
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool ODMLOOGJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool EPBMFDOOIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class EMOIGIIPBBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public LHOBCJGAMNG ADFFNFEKNKL;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int CBOGBOOIKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7BF180", Offset = "0x7BE180", VA = "0x1807BF180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D50", Offset = "0x7C1D50", VA = "0x1807C2D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6B57A20", Offset = "0x6B56A20", VA = "0x186B57A20")]
	public static JHIBCIKJMBL CPMCNNEPFNF(IEnumerator<JHIBCIKJMBL> LKICDFHNBJG, GHDDGJLFACK GNIAEDIBPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6B57B80", Offset = "0x6B56B80", VA = "0x186B57B80")]
	public JHIBCIKJMBL CPMCNNEPFNF(GHDDGJLFACK[] JEDLAIMIKBC, IEnumerator<JHIBCIKJMBL>[] KHJJKKFOGBF, JHIBCIKJMBL[] GLHNPFKPELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6B57C40", Offset = "0x6B56C40", VA = "0x186B57C40")]
	public void KCHBFPAKLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6B57DB0", Offset = "0x6B56DB0", VA = "0x186B57DB0")]
	public void MIBOCEJDIOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6B57C70", Offset = "0x6B56C70", VA = "0x186B57C70")]
	public void JKFDCCOJNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6B57C40", Offset = "0x6B56C40", VA = "0x186B57C40")]
	public void IKNLGAIIHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public EMOIGIIPBBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class LHOBCJGAMNG
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct PAENFGIPLBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public EMOIGIIPBBH JMPJMGECOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public FGEMNFOIAEP MBAHPDBNFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public GHDDGJLFACK MLOMLKJBNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<JHIBCIKJMBL> NANIABMOLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public JHIBCIKJMBL ENNMKAJHCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public GFPAFFBFIDB CNBPOBIHODP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct HHHCFNOIECH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public DLJPFICMPDE NDADDIHEJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<PAENFGIPLBI> PEOJFHJHIOB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class IEGCEIPEGII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public GHDDGJLFACK promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public LHOBCJGAMNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public FGEMNFOIAEP context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public EMOIGIIPBBH routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public GFPAFFBFIDB coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public JHIBCIKJMBL currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<JHIBCIKJMBL> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public IEGCEIPEGII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6B5C9A0", Offset = "0x6B5B9A0", VA = "0x186B5C9A0")]
		internal void DIDBIAKHOON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class PJEPDLGDEGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public EMOIGIIPBBH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public LHOBCJGAMNG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public PJEPDLGDEGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6B6C240", Offset = "0x6B6B240", VA = "0x186B6C240")]
		internal void JLAJPNDDGHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class NKMJHCNDCJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public EMOIGIIPBBH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public LHOBCJGAMNG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public NKMJHCNDCJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6B68D20", Offset = "0x6B67D20", VA = "0x186B68D20")]
		internal void IEHAKMIDIMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class APDNKOIBGKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public EMOIGIIPBBH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public LHOBCJGAMNG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public APDNKOIBGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6B516E0", Offset = "0x6B506E0", VA = "0x186B516E0")]
		internal void BBHFDPCFPAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const GFPAFFBFIDB MGMHGALMFMK = GFPAFFBFIDB.Cancelled | GFPAFFBFIDB.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly DLJPFICMPDE KGCOFKKMBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] IKECNLBGMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<GFPAFFBFIDB> CCCDAGFIIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> JNFEKHIBPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> PNDHCOBNKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> GANIIBCEFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> AJEFNGHFPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> JOFGPFNLOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> LJNMLADIFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private EMOIGIIPBBH[] AJCGJGJBABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private GHDDGJLFACK[] JEDLAIMIKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private FGEMNFOIAEP[] BCIJDBFNDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<JHIBCIKJMBL>[] AOLKHECLMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JHIBCIKJMBL[] DEMHJNFBKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int OEMNCJLFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int AFDLPCPCHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int HAMFJGMCCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float PEBCMMMAKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private GEPKGPFJEHC MEECNOPFDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle KHCIJBDGKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<EMOIGIIPBBH> NIELFKDEMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool LJGGHPHLJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> HOLAMJFLKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> JLAIDDOLGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool KBPDDNADGAJ;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public HHHCFNOIECH[] OIEKOELMPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA2F5A0", Offset = "0xA2E5A0", VA = "0x180A2F5A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6B652E0", Offset = "0x6B642E0", VA = "0x186B652E0")]
	private static int NPPLDOIKIBH(DLJPFICMPDE KGCOFKKMBML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6B65570", Offset = "0x6B64570", VA = "0x186B65570")]
	public LHOBCJGAMNG(DLJPFICMPDE KGCOFKKMBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6B63990", Offset = "0x6B62990", VA = "0x186B63990")]
	private void DEDKGEIHHAA(int LHNILGDNJCF, int ODEIMBIAPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6B632D0", Offset = "0x6B622D0", VA = "0x186B632D0")]
	public void ALJKMMCEIOB(FGEMNFOIAEP DFKOHNJAKHM, JHIBCIKJMBL KMJBLDHBLMM, IEnumerator<JHIBCIKJMBL> LKICDFHNBJG, GHDDGJLFACK GNIAEDIBPKI, [Optional] EMOIGIIPBBH BOJIGCBNHOF, GFPAFFBFIDB OLPJIJCHFBG = GFPAFFBFIDB.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6B63550", Offset = "0x6B62550", VA = "0x186B63550")]
	public void CENKJJGAGNC(IEnumerable<PAENFGIPLBI> HBGPGFOIDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6B64270", Offset = "0x6B63270", VA = "0x186B64270")]
	private PAENFGIPLBI EOAFHLNAAFE(int KNLFOJCHIHH)
	{
		return default(PAENFGIPLBI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B64F70", Offset = "0x6B63F70", VA = "0x186B64F70")]
	private void NGMAFMOAGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2962BB0", Offset = "0x2961BB0", VA = "0x182962BB0")]
	private static void BJDEOMMKMBG<T>(int KNLFOJCHIHH, T[] LGCPCEPLFBJ, int GFFAGBDKDAI, [Optional] T HEAEDFCCCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2962C00", Offset = "0x2961C00", VA = "0x182962C00")]
	private static void BJDEOMMKMBG<T>(int KNLFOJCHIHH, NativeArray<T> LGCPCEPLFBJ, int GFFAGBDKDAI, [Optional] T HEAEDFCCCNK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B64740", Offset = "0x6B63740", VA = "0x186B64740")]
	private void FOINDLFGPJK(IEnumerable<PAENFGIPLBI> HBGPGFOIDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B63210", Offset = "0x6B62210", VA = "0x186B63210")]
	private void AJCCOKNKPFD(PAENFGIPLBI BGLMGIADMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B65310", Offset = "0x6B64310", VA = "0x186B65310")]
	private OPGCFBKBHPG PFDJIOFIEED(int KPEIINOAGCB)
	{
		return default(OPGCFBKBHPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B63790", Offset = "0x6B62790", VA = "0x186B63790")]
	public void CHJIMNFEMDJ(float NMIEKNEGIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B64DC0", Offset = "0x6B63DC0", VA = "0x186B64DC0")]
	private void KKCBKGFGGIA(Action AAOIMEIMECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B64AE0", Offset = "0x6B63AE0", VA = "0x186B64AE0")]
	private void HMKLMMLMCBO(Action AAOIMEIMECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B63B70", Offset = "0x6B62B70", VA = "0x186B63B70")]
	public void DHAFFCOOBBI(float NMIEKNEGIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B63450", Offset = "0x6B62450", VA = "0x186B63450")]
	public void BPEPGBDJLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B64B60", Offset = "0x6B63B60", VA = "0x186B64B60")]
	public void IKNLGAIIHPD(EMOIGIIPBBH DCFBJOGNPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B64C90", Offset = "0x6B63C90", VA = "0x186B64C90")]
	public void JGIGAFBJLMB(EMOIGIIPBBH DCFBJOGNPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B64E40", Offset = "0x6B63E40", VA = "0x186B64E40")]
	public void KKMLCHPFCEK(EMOIGIIPBBH DCFBJOGNPMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class CHFBHJLJOLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly CHFBHJLJOLM LGJIMEKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Action PNPLLJEEJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private bool OBBFCMJHMOD;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	public CHFBHJLJOLM(Action PNPLLJEEJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6368040", Offset = "0x6367040", VA = "0x186368040", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface KJDGOOFHAGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T DMDNAKDAMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable ONLBIALOLHN(UnityEngine.Object DFKOHNJAKHM, Action<T> DCKBCOLIIEP);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface DPCOKEDCLHM<T> : KJDGOOFHAGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T DMDNAKDAMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class OAKJAENNCKO<T> : DPCOKEDCLHM<T>, KJDGOOFHAGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class ACIIABPHCDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public OAKJAENNCKO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ICCNAAKNKGE<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public ACIIABPHCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x394A4D0", Offset = "0x39494D0", VA = "0x18394A4D0")]
		internal void MNKEDKJPIBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static GameObject OKEBAJENMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<ICCNAAKNKGE<UnityEngine.Object, Action<T>>> OELCMMPLPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T IJKDPLKGHGN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T DMDNAKDAMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x82BFE0", Offset = "0x82AFE0", VA = "0x18082BFE0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4182130", Offset = "0x4181130", VA = "0x184182130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x41821B0", Offset = "0x41811B0", VA = "0x1841821B0")]
	private static bool FGKBCGPEGLO(T AAOIMEIMECG, T ABLGCHAEIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4182C30", Offset = "0x4181C30", VA = "0x184182C30")]
	public OAKJAENNCKO(T CGNJJBDICNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4182910", Offset = "0x4181910", VA = "0x184182910", Slot = "6")]
	public IDisposable ONLBIALOLHN(UnityEngine.Object DFKOHNJAKHM, Action<T> DCKBCOLIIEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x41825E0", Offset = "0x41815E0", VA = "0x1841825E0")]
	private void ONIBBBMALJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal class PLIILAEIHGK : LNIGHMHFPGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly PDJJIFOPPPL LDNIAKCKACA;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C280", Offset = "0x6B6B280", VA = "0x186B6C280")]
	[ILJDPBHFAFI(DIDBPCEENMM.None)]
	private static void LJGEHEAHHOL(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	[Preserve]
	internal PLIILAEIHGK([POILJEECDED(null)] PDJJIFOPPPL LDNIAKCKACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C2F0", Offset = "0x6B6B2F0", VA = "0x186B6C2F0", Slot = "4")]
	public IDisposable NJFMOAKGCAL(float MHPAHFGNGLL, Action<float> HLFIKKGGCCK, bool PNDJOBOMDCI = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class HDDBLMAHLGE : JBHKCMFLKCG, PDJJIFOPPPL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private LHOBCJGAMNG[] DEFMKBDOEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private IDDHMHHAJAO MPPCLAFFCAE;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6B5BFD0", Offset = "0x6B5AFD0", VA = "0x186B5BFD0")]
	[ILJDPBHFAFI(DIDBPCEENMM.None)]
	private static void LJGEHEAHHOL(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6B5C040", Offset = "0x6B5B040", VA = "0x186B5C040")]
	[Preserve]
	public HDDBLMAHLGE([POILJEECDED(null)] OKENFDPEJNA MNBFAJCKCNN, [POILJEECDED(null)] IGDCEBBCAGI HNHOHLLJALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B5A0", Offset = "0x6B5A5A0", VA = "0x186B5B5A0", Slot = "16")]
	public override EOCGEKKEBMP BCIFCICIGBE(FGEMNFOIAEP DFKOHNJAKHM, IEnumerator<JHIBCIKJMBL> GJDEFPKIJDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6B5BA80", Offset = "0x6B5AA80", VA = "0x186B5BA80", Slot = "17")]
	public override void KNIDJLMEEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6B5BD20", Offset = "0x6B5AD20", VA = "0x186B5BD20", Slot = "19")]
	public override void KNOHODFHADN(DLJPFICMPDE KGCOFKKMBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B400", Offset = "0x6B5A400", VA = "0x186B5B400", Slot = "18")]
	protected override void ACILEHIEJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B570", Offset = "0x6B5A570", VA = "0x186B5B570")]
	private LHOBCJGAMNG APLKENFBIHK(DLJPFICMPDE KBCNAJKPHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B6D0", Offset = "0x6B5A6D0", VA = "0x186B5B6D0", Slot = "20")]
	internal override NCFOIPIADBE DAGJCCIKCLG(IEnumerator<JHIBCIKJMBL> GJDEFPKIJDD, Behaviour DFKOHNJAKHM, GHDDGJLFACK GNIAEDIBPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6B5BF50", Offset = "0x6B5AF50", VA = "0x186B5BF50", Slot = "21")]
	internal override KHHMKPPJOHK LBPGIBFBIHB(DLJPFICMPDE AAHIACOIGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B960", Offset = "0x6B5A960", VA = "0x186B5B960")]
	private void ECNHBHEGHDM(LHOBCJGAMNG AFKKEJLNCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B900", Offset = "0x6B5A900", VA = "0x186B5B900", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[BurstCompile]
internal struct GEPKGPFJEHC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public float KBCNOBGBPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public int FIMPADFGAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> DCKDPCFLICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> MJICGJFELID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NativeArray<int> EGMEACFCFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<GFPAFFBFIDB> CAGGOFMBLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[ReadOnly]
	public NativeArray<float> FLNKECGGPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> AJEFNGHFPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[WriteOnly]
	public NativeArray<int> PNDHCOBNKHJ;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6B5AEF0", Offset = "0x6B59EF0", VA = "0x186B5AEF0")]
	public static GEPKGPFJEHC EOFBBDOECDH(int AKKEPFIAKNN, float NMIEKNEGIHF, NativeArray<GFPAFFBFIDB> GJAIFCFBIEG, NativeArray<float> DNNPBFLJOML, NativeArray<int> JHPIDONMLKL, NativeArray<int> BLCHOEGFDMB, NativeArray<int> MPJMDMIEPNH, NativeArray<int> MJICGJFELID, NativeArray<int> EGMEACFCFMN)
	{
		return default(GEPKGPFJEHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6B5AF50", Offset = "0x6B59F50", VA = "0x186B5AF50", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B030", Offset = "0x6B5A030", VA = "0x186B5B030")]
	private bool FEFJCFMHODI(int GPEHCABDGEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B2B0", Offset = "0x6B5A2B0", VA = "0x186B5B2B0")]
	private void JKKAFPIKICO(NativeArray<int> FHFGIJNAOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B2E0", Offset = "0x6B5A2E0", VA = "0x186B5B2E0")]
	private int KJDOCGKNCJI(int MAFLPMPNOHC, int FAJAPDMKIAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6B5AE20", Offset = "0x6B59E20", VA = "0x186B5AE20")]
	private void CBCCCHFFEJF(NativeArray<int> FHFGIJNAOCM, int NEOFPKMHOML, int HOBDDCFEELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B070", Offset = "0x6B5A070", VA = "0x186B5B070")]
	private void HBNNNJDEHPO(NativeArray<int> FHFGIJNAOCM, int BCJMGNKJAMF, int FIGOHKLAMIL, int NAOABONALHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public abstract class JBHKCMFLKCG : PDJJIFOPPPL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly OKENFDPEJNA MNBFAJCKCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected readonly IGDCEBBCAGI HNHOHLLJALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private KHHMKPPJOHK[] EHBFIPHHEDO;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static PDJJIFOPPPL AFPJCELPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6B5DDF0", Offset = "0x6B5CDF0", VA = "0x186B5DDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool OLODGLIPGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DLJPFICMPDE NFECMCPONNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BF180", Offset = "0x7BE180", VA = "0x1807BF180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(DLJPFICMPDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D50", Offset = "0x7C1D50", VA = "0x1807C2D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IGDCEBBCAGI MDMHMPMIMOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JHIBCIKJMBL EODAFFCKDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E280", Offset = "0x6B5D280", VA = "0x186B5E280")]
	public static EOCGEKKEBMP FBAFPPMJBBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E6D0", Offset = "0x6B5D6D0", VA = "0x186B5E6D0")]
	[Preserve]
	protected JBHKCMFLKCG([POILJEECDED(null)] OKENFDPEJNA MNBFAJCKCNN, [POILJEECDED(null)] IGDCEBBCAGI HNHOHLLJALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6B5D9B0", Offset = "0x6B5C9B0", VA = "0x186B5D9B0", Slot = "6")]
	public EOCGEKKEBMP AOFLBJDIDMG(IEnumerator<JHIBCIKJMBL> GJDEFPKIJDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6B5D7B0", Offset = "0x6B5C7B0", VA = "0x186B5D7B0", Slot = "7")]
	public EOCGEKKEBMP AOFLBJDIDMG(Behaviour DFKOHNJAKHM, IEnumerator<JHIBCIKJMBL> GJDEFPKIJDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract EOCGEKKEBMP BCIFCICIGBE(FGEMNFOIAEP DFKOHNJAKHM, IEnumerator<JHIBCIKJMBL> GJDEFPKIJDD);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E440", Offset = "0x6B5D440", VA = "0x186B5E440", Slot = "17")]
	public virtual void KNIDJLMEEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6B5DBB0", Offset = "0x6B5CBB0", VA = "0x186B5DBB0", Slot = "9")]
	public void CPPKKKJCOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6B5D790", Offset = "0x6B5C790", VA = "0x186B5D790", Slot = "18")]
	protected virtual void ACILEHIEJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6B5D9C0", Offset = "0x6B5C9C0", VA = "0x186B5D9C0")]
	private void CEDGFCAAOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E670", Offset = "0x6B5D670", VA = "0x186B5E670")]
	private void OFEOOJADMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E310", Offset = "0x6B5D310", VA = "0x186B5E310")]
	private void FMNLHEPNJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E690", Offset = "0x6B5D690", VA = "0x186B5E690")]
	private void OJKELICICFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E200", Offset = "0x6B5D200", VA = "0x186B5E200")]
	private void ELLOHGMFIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E6B0", Offset = "0x6B5D6B0", VA = "0x186B5E6B0")]
	private void ONALAEOGPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E390", Offset = "0x6B5D390", VA = "0x186B5E390")]
	private void GPFBBBKKCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E5E0", Offset = "0x6B5D5E0", VA = "0x186B5E5E0", Slot = "19")]
	public virtual void KNOHODFHADN(DLJPFICMPDE KGCOFKKMBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6B5D9E0", Offset = "0x6B5C9E0", VA = "0x186B5D9E0")]
	private void CLIKLPGFGKI(KHHMKPPJOHK AFKKEJLNCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1D58370", Offset = "0x1D57370", VA = "0x181D58370")]
	private KHHMKPPJOHK OIKIPMNPELN(DLJPFICMPDE KBCNAJKPHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract NCFOIPIADBE DAGJCCIKCLG(IEnumerator<JHIBCIKJMBL> GJDEFPKIJDD, Behaviour ODNBCIDMCKP, GHDDGJLFACK AIENHMMHOCB);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract KHHMKPPJOHK LBPGIBFBIHB(DLJPFICMPDE KGCOFKKMBML);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6B5DE40", Offset = "0x6B5CE40", VA = "0x186B5DE40", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E330", Offset = "0x6B5D330", VA = "0x186B5E330", Slot = "12")]
	public JHIBCIKJMBL GEHPKPGOJEC(DLJPFICMPDE AAHIACOIGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E3B0", Offset = "0x6B5D3B0", VA = "0x186B5E3B0", Slot = "13")]
	public JHIBCIKJMBL HBDIKOLFDEJ(float FHPCLBOOPLN, DLJPFICMPDE AAHIACOIGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B5E220", Offset = "0x6B5D220", VA = "0x186B5E220", Slot = "14")]
	public JHIBCIKJMBL ENINKDGAMDI(Func<bool> KOGAEBNIPPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class NCFOIPIADBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly GHDDGJLFACK GNIAEDIBPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly JOPFCFAJIDD DFKOHNJAKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly bool BGEBFECGFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private string ONGJKHHOIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private StackTrace OINILNFLOPK;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<JHIBCIKJMBL> NANIABMOLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C35D0", Offset = "0x7C25D0", VA = "0x1807C35D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public JHIBCIKJMBL ENNMKAJHCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DD0", Offset = "0x7C0DD0", VA = "0x1807C1DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool LKIJGMFPFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6B67E30", Offset = "0x6B66E30", VA = "0x186B67E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool IFFLHKDGNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x889610", Offset = "0x888610", VA = "0x180889610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x889730", Offset = "0x888730", VA = "0x180889730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6B67970", Offset = "0x6B66970", VA = "0x186B67970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float LJHLGLPGBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1138880", Offset = "0x1137880", VA = "0x181138880")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5898CB0", Offset = "0x5897CB0", VA = "0x185898CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6B68050", Offset = "0x6B67050", VA = "0x186B68050")]
	public NCFOIPIADBE(IEnumerator<JHIBCIKJMBL> LKICDFHNBJG, JOPFCFAJIDD DFKOHNJAKHM, GHDDGJLFACK GNIAEDIBPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6B67B20", Offset = "0x6B66B20", VA = "0x186B67B20")]
	public JHIBCIKJMBL CPMCNNEPFNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6B67F00", Offset = "0x6B66F00", VA = "0x186B67F00")]
	public bool OKFGMJEBGHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6B67EB0", Offset = "0x6B66EB0", VA = "0x186B67EB0")]
	public void IKNLGAIIHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6B67F70", Offset = "0x6B66F70", VA = "0x186B67F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x910980", Offset = "0x90F980", VA = "0x180910980")]
	[CompilerGenerated]
	private void AIGHDMEIECN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class GHDDGJLFACK : OMKOEJMCDFF, EOCGEKKEBMP, HNENBNAEPGI, PGOMONKDBKH, IEnumerator, JHIBCIKJMBL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private DLJPFICMPDE CMEOKLHPJEI;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private DLJPFICMPDE LPNCOBBDBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xEBA320", Offset = "0xEB9320", VA = "0x180EBA320", Slot = "23")]
		get
		{
			return default(DLJPFICMPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public DLJPFICMPDE ADFFNFEKNKL
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x13D42C0", Offset = "0x13D32C0", VA = "0x1813D42C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float ACBONKOPNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8D60E0", Offset = "0x8D50E0", VA = "0x1808D60E0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool JKBPDJGGIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B390", Offset = "0x6B5A390", VA = "0x186B5B390", Slot = "24")]
	private bool GBOJEEEJDIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B380", Offset = "0x6B5A380", VA = "0x186B5B380", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B3B0", Offset = "0x6B5A3B0", VA = "0x186B5B3B0")]
	public GHDDGJLFACK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal enum OPGCFBKBHPG : byte
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
internal sealed class KHHMKPPJOHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum BILKILPMNLG
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public struct HAMKBKCKCPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public DLJPFICMPDE NDADDIHEJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public BILKILPMNLG HDEDLEKKPOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public List<NCFOIPIADBE> BFMHGKIHDNE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly BILKILPMNLG[] GJANFNDEDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly DLJPFICMPDE KGCOFKKMBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool APLAKCFMBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly NCFOIPIADBE[] FCGKHFLNKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<NCFOIPIADBE> GJNLJILLAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Stack<int> GGFLMJGFIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly List<NCFOIPIADBE> HAMKODKLBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Stack<int> MNAGLMEKIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly IDDHMHHAJAO BMNGDKGLILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private bool KBPDDNADGAJ;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public HAMKBKCKCPP[,] LCKNCILPJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7C6560", Offset = "0x7C5560", VA = "0x1807C6560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6B61180", Offset = "0x6B60180", VA = "0x186B61180")]
	public KHHMKPPJOHK(DLJPFICMPDE AAHIACOIGAI, IDDHMHHAJAO BMNGDKGLILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6B60DF0", Offset = "0x6B5FDF0", VA = "0x186B60DF0")]
	public void OKHMEEIOCII(NCFOIPIADBE LKICDFHNBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6B601C0", Offset = "0x6B5F1C0", VA = "0x186B601C0")]
	public void FFMIAPABOMG(IList<NCFOIPIADBE> KHJJKKFOGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6B604D0", Offset = "0x6B5F4D0", VA = "0x186B604D0")]
	public void GIOMKOKAGML(IList<NCFOIPIADBE> KHJJKKFOGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6B5FDC0", Offset = "0x6B5EDC0", VA = "0x186B5FDC0")]
	private void ACOGKHGEHHB(NCFOIPIADBE LKICDFHNBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6B60C60", Offset = "0x6B5FC60", VA = "0x186B60C60")]
	private void MFIABDHGHNN(IList<NCFOIPIADBE> KHJJKKFOGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6B60AE0", Offset = "0x6B5FAE0", VA = "0x186B60AE0")]
	private OPGCFBKBHPG LFANFNKDLBG(NCFOIPIADBE LKICDFHNBJG)
	{
		return default(OPGCFBKBHPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6B5FC50", Offset = "0x6B5EC50", VA = "0x186B5FC50")]
	public void ACILEHIEJCJ(float NMIEKNEGIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6B5FEB0", Offset = "0x6B5EEB0", VA = "0x186B5FEB0")]
	public void CPPKKKJCOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6B607E0", Offset = "0x6B5F7E0", VA = "0x186B607E0")]
	private void KILOGEHOMAI(List<NCFOIPIADBE> KHJJKKFOGBF, Stack<int> OAOAEICKODL, bool KLCNKKCEDMH, float BNHGAHEFMDF = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6B600A0", Offset = "0x6B5F0A0", VA = "0x186B600A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6B60F00", Offset = "0x6B5FF00", VA = "0x186B60F00")]
	private void PDKNNDIHGGJ(List<NCFOIPIADBE> KHJJKKFOGBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class CACAJINHOEI : IDDHMHHAJAO
{
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
	public void DEADJHCAEHI(string ONGJKHHOIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
	public void LJNJLBBPMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public CACAJINHOEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal class AHOMEEACMNA : JOPFCFAJIDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly Behaviour ODNBCIDMCKP;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6B51440", Offset = "0x6B50440", VA = "0x186B51440", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool ODMLOOGJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6B514C0", Offset = "0x6B504C0", VA = "0x186B514C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool EPBMFDOOIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6B51510", Offset = "0x6B50510", VA = "0x186B51510", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	public AHOMEEACMNA(Behaviour ODNBCIDMCKP)
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

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
public class EGOJNOCCOCF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority ONDLGJKOECO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x635F3D0", Offset = "0x635E7D0", VA = "0x18635F3D0")]
	public EGOJNOCCOCF(ThreadPriority IKCMFEBGMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x635F3C0", Offset = "0x635E7C0", VA = "0x18635F3C0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> NEELCJCGGID(List<PlayerLoopSystem> MCIPOELAAMA, int EIAILPBGPFJ);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct GLJACNGLEHJ
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct HILHEKJKMOJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static HJKDHGFMLBJ EJOJLANAKCN;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x6362C40", Offset = "0x6362040", VA = "0x186362C40")]
				public static PlayerLoopSystem OOFIJINHLKF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct LMGEPEDINPK
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static HJKDHGFMLBJ GDPIFNKKMDF;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x636C350", Offset = "0x636B750", VA = "0x18636C350")]
				public static PlayerLoopSystem OOFIJINHLKF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct IKOCEIKBEKH
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static HJKDHGFMLBJ IMGOBDAACKH;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6364980", Offset = "0x6363D80", VA = "0x186364980")]
				public static PlayerLoopSystem OOFIJINHLKF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct DGFCHHKEANF
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static HJKDHGFMLBJ BCAOLPPOIGM;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static HJKDHGFMLBJ KCBKMLIJJCM;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static HJKDHGFMLBJ ACDEDPGIKPL;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static HJKDHGFMLBJ LFNAMFAPCNL;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x635E1B0", Offset = "0x635D5B0", VA = "0x18635E1B0")]
				public static PlayerLoopSystem OOFIJINHLKF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct GNOFHFMAAEA
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static HJKDHGFMLBJ GJAEEEEFGPP;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x63626C0", Offset = "0x6361AC0", VA = "0x1863626C0")]
				public static PlayerLoopSystem OOFIJINHLKF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct LDGFOIBCPJH
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static HJKDHGFMLBJ BCAOLPPOIGM;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static HJKDHGFMLBJ KCBKMLIJJCM;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static HJKDHGFMLBJ ACDEDPGIKPL;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static HJKDHGFMLBJ LFNAMFAPCNL;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x6367AF0", Offset = "0x6366EF0", VA = "0x186367AF0")]
				public static PlayerLoopSystem OOFIJINHLKF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct FGFKGOFIJFP
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static HJKDHGFMLBJ KEJEDDBGIKA;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x635FFB0", Offset = "0x635F3B0", VA = "0x18635FFB0")]
				public static PlayerLoopSystem OOFIJINHLKF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct NCIAFPBAGBE
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static HJKDHGFMLBJ GMEEMAAANOM;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x636DFC0", Offset = "0x636D3C0", VA = "0x18636DFC0")]
				public static PlayerLoopSystem OOFIJINHLKF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct HLDJJMKLJPD
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static HJKDHGFMLBJ NCIIKJJJNGP;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6362E40", Offset = "0x6362240", VA = "0x186362E40")]
				public static PlayerLoopSystem OOFIJINHLKF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct LIHCMAPPPOK
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static HJKDHGFMLBJ ECBICLEGJIJ;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x636C150", Offset = "0x636B550", VA = "0x18636C150")]
				public static PlayerLoopSystem OOFIJINHLKF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct MGKHOJOIEJK
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static HJKDHGFMLBJ DIKOBGNFGBC;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x636D040", Offset = "0x636C440", VA = "0x18636D040")]
				public static PlayerLoopSystem OOFIJINHLKF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct GHCDEANFGBL
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static HJKDHGFMLBJ LOMECCLMMNF;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x6361D40", Offset = "0x6361140", VA = "0x186361D40")]
				public static PlayerLoopSystem OOFIJINHLKF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum IOAOKPPDGGE : byte
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
			public struct BLFPEGAHEFC
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class BJMIGJFLCHF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public IOAOKPPDGGE updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
					public BJMIGJFLCHF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x6357A00", Offset = "0x6356E00", VA = "0x186357A00")]
					internal void PLHMEOJPADI()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static KNCNJDFAHCK<IOAOKPPDGGE> NBDJFPHKGOE;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6357A80", Offset = "0x6356E80", VA = "0x186357A80")]
				public static PlayerLoopSystem OOFIJINHLKF(IOAOKPPDGGE GNAOLBNCMAP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct OHMAGHELKDH
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class EDLMPLDHILK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public PCICEJMEGME.NNBLCIBJKAC key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
					public EDLMPLDHILK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x635F140", Offset = "0x635E540", VA = "0x18635F140")]
					internal void PNOAHAHECFK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable KIAMKAGKELN;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x636EF30", Offset = "0x636E330", VA = "0x18636EF30")]
				public static PlayerLoopSystem JLJNMJIMIDD(PCICEJMEGME.NNBLCIBJKAC IHHOPACLNAK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct IMGDMPEKMPO
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class LOFAFHPHGCL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public PCICEJMEGME.NNBLCIBJKAC key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
					public LOFAFHPHGCL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x636C620", Offset = "0x636BA20", VA = "0x18636C620")]
					internal void PNOAHAHECFK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x6364B80", Offset = "0x6363F80", VA = "0x186364B80")]
				public static PlayerLoopSystem JLJNMJIMIDD(PCICEJMEGME.NNBLCIBJKAC IHHOPACLNAK)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class JBMLLDNPPPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public JBMLLDNPPPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6365180", Offset = "0x6364580", VA = "0x186365180")]
			internal List<PlayerLoopSystem> KKEFDKCFFFB(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool JGABKAPBEAO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool HFFHCNOEEHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x635D770", Offset = "0x635CB70", VA = "0x18635D770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x635A670", Offset = "0x6359A70", VA = "0x18635A670")]
		private static void AOPELABHDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x635D8E0", Offset = "0x635CCE0", VA = "0x18635D8E0")]
		private static void OJEHEHGOIMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x635CFA0", Offset = "0x635C3A0", VA = "0x18635CFA0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x635D1D0", Offset = "0x635C5D0", VA = "0x18635D1D0")]
		private static void DKGAMLEKCHM(PCICEJMEGME.NNBLCIBJKAC IHHOPACLNAK, PlayerLoopSystem KALKMCGHPNF, Type FKDKIAADOKI, Type BENLOHOJHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x635D390", Offset = "0x635C790", VA = "0x18635D390")]
		private static void EEAOAHPDHCL(PlayerLoopSystem KALKMCGHPNF, Type FKDKIAADOKI, Type BENLOHOJHMD, NEELCJCGGID PODOPBHFJNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x635D7B0", Offset = "0x635CBB0", VA = "0x18635D7B0")]
		private static void JBNJNFLAGDI(PlayerLoopSystem KALKMCGHPNF, Type FKDKIAADOKI, Type BENLOHOJHMD, PlayerLoopSystem? LJEMBPOMLCB, PlayerLoopSystem? JPKHDAGPDOF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PCICEJMEGME
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum NNBLCIBJKAC
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
	public class NEJHBOCCPCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly NNBLCIBJKAC PCIKKLEGAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly GCCCILMGEBL FHPOOGEKIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long NICFGBJJGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long APGEJEFGIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long OCMEOCBPDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int NJOKAGBKACB;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x636E7A0", Offset = "0x636DBA0", VA = "0x18636E7A0")]
		public NEJHBOCCPCO(NNBLCIBJKAC OJJPGPJBCDP, int GCJEMEJDLDO = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x636E550", Offset = "0x636D950", VA = "0x18636E550")]
		public void OFHFGOKOBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x636E500", Offset = "0x636D900", VA = "0x18636E500")]
		public void HDPPNLFNIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x636E5C0", Offset = "0x636D9C0", VA = "0x18636E5C0")]
		public void PPLMDNIGAJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static NNBLCIBJKAC[] COFPOKKDJHF;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static NEJHBOCCPCO[] IFIIFBJBPCG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x636FAC0", Offset = "0x636EEC0", VA = "0x18636FAC0")]
	public static NEJHBOCCPCO OKGDANMKPPB(NNBLCIBJKAC IHHOPACLNAK, int GCJEMEJDLDO = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x636FA50", Offset = "0x636EE50", VA = "0x18636FA50")]
	public static NEJHBOCCPCO NENDEJMFLIP(NNBLCIBJKAC IHHOPACLNAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x636F9B0", Offset = "0x636EDB0", VA = "0x18636F9B0")]
	public static void AIFFKPNJIBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GCCCILMGEBL : DPGNLFBMOKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int BCDAAMAACAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> GLHMOMPDEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double MAKCHOBJLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double NFJOIFHGCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double PMNNKICOJDP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double MLNOOAMBLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x63615C0", Offset = "0x63609C0", VA = "0x1863615C0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double HOHGBGMCBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x15E4520", Offset = "0x15E3920", VA = "0x1815E4520", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double KIPFNHCNCCO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1BF57A0", Offset = "0x1BF4BA0", VA = "0x181BF57A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6361740", Offset = "0x6360B40", VA = "0x186361740")]
	public GCCCILMGEBL(int AECDDDEOHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6361620", Offset = "0x6360A20", VA = "0x186361620", Slot = "7")]
	public void NHAFHJEPHBA(double FLJKEGLJDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6361550", Offset = "0x6360950", VA = "0x186361550", Slot = "8")]
	public void CGCDLMDFFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class CHPKOMEDPLN : DPGNLFBMOKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long CHEGLPEPHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double DGMBGLCAEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double DMKAOCEJHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double IMPCEGGEBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double ABGILBDHHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double MAKCHOBJLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double NFJOIFHGCKE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double HOHGBGMCBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x53B4EA0", Offset = "0x53B42A0", VA = "0x1853B4EA0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double KIPFNHCNCCO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x53B4F00", Offset = "0x53B4300", VA = "0x1853B4F00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double FLCMPKNMBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x53B53B0", Offset = "0x53B47B0", VA = "0x1853B53B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MLNOOAMBLIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0160", Offset = "0x1F9F560", VA = "0x181FA0160", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x63598F0", Offset = "0x6358CF0", VA = "0x1863598F0", Slot = "7")]
	public virtual void NHAFHJEPHBA(double FLJKEGLJDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x63598B0", Offset = "0x6358CB0", VA = "0x1863598B0", Slot = "8")]
	public virtual void CGCDLMDFFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6359A10", Offset = "0x6358E10", VA = "0x186359A10")]
	public CHPKOMEDPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HIDLKMLHOKH : CHPKOMEDPLN
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double ONKBFHMANPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x53B53A0", Offset = "0x53B47A0", VA = "0x1853B53A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x53B5370", Offset = "0x53B4770", VA = "0x1853B5370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6362B10", Offset = "0x6361F10", VA = "0x186362B10", Slot = "7")]
	public override void NHAFHJEPHBA(double FLJKEGLJDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6362AD0", Offset = "0x6361ED0", VA = "0x186362AD0", Slot = "8")]
	public override void CGCDLMDFFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6359A10", Offset = "0x6358E10", VA = "0x186359A10")]
	public HIDLKMLHOKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DPGNLFBMOKB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double MLNOOAMBLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double HOHGBGMCBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double KIPFNHCNCCO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LCBGMFNEBAB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface DEHJAKDHKIL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool GFBDPMNBOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GIKDBELLELC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class FCDOPAHDPFD<TPromise, TMainThreadPromise> : DEHJAKDHKIL where TPromise : IKPLFJCHDDD where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise IHIEFLMKMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise GAOOBDOJMCF;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise CNODAGDCDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x33811B0", Offset = "0x33805B0", VA = "0x1833811B0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GFBDPMNBOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3381210", Offset = "0x3380610", VA = "0x183381210", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x769080", Offset = "0x768480", VA = "0x180769080")]
		protected FCDOPAHDPFD(TPromise IHIEFLMKMNK, TMainThreadPromise LCOEIEBAAOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3381190", Offset = "0x3380590", VA = "0x183381190", Slot = "5")]
		public void GIKDBELLELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void NKNANALEOHD(TPromise IHIEFLMKMNK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class OHDBHIBKLNE<T> : FCDOPAHDPFD<DMGBOCKAFMH<T>, BOLHGOALIJH<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3CD58A0", Offset = "0x3CD4CA0", VA = "0x183CD58A0")]
		public OHDBHIBKLNE(DMGBOCKAFMH<T> IHIEFLMKMNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3CD56F0", Offset = "0x3CD4AF0", VA = "0x183CD56F0", Slot = "6")]
		protected override void NKNANALEOHD(DMGBOCKAFMH<T> IHIEFLMKMNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x35E9A60", Offset = "0x35E8E60", VA = "0x1835E9A60")]
		[CompilerGenerated]
		private void CCKBHECKNMO(T BBHPNPGLHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD56C0", Offset = "0x3CD4AC0", VA = "0x183CD56C0")]
		[CompilerGenerated]
		private void AIPHBCNLCLG(string NJAPBBBJJNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class ILPHPHEEEPA : DEHJAKDHKIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action PAFFKHOCLGN;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GFBDPMNBOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
		public ILPHPHEEEPA(Action PAFFKHOCLGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA95F10", Offset = "0xA95310", VA = "0x180A95F10", Slot = "5")]
		public void GIKDBELLELC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<DEHJAKDHKIL> DCNBGGECOHC;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x244BCD0", Offset = "0x244B0D0", VA = "0x18244BCD0")]
	public static DMGBOCKAFMH<T> MDJONCJILGL<T>(this DMGBOCKAFMH<T> IHIEFLMKMNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6367600", Offset = "0x6366A00", VA = "0x186367600")]
	public static void MDJONCJILGL(Action PAFFKHOCLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x244BC10", Offset = "0x244B010", VA = "0x18244BC10")]
	private static DMGBOCKAFMH<T> ABJGNJFIJCB<T>(DMGBOCKAFMH<T> IHIEFLMKMNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x63673F0", Offset = "0x63667F0", VA = "0x1863673F0")]
	private static void EAFIACDDDHL(DEHJAKDHKIL HLPOOIAFIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x63676A0", Offset = "0x6366AA0", VA = "0x1863676A0")]
	private static void NPBBEJOJLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x63672F0", Offset = "0x63666F0", VA = "0x1863672F0")]
	private static void APMFACANAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6367980", Offset = "0x6366D80", VA = "0x186367980")]
	private static void OKBEJOPMGPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class IJKBBBDJDDC
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct NFGFFIKMMON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> FMKONHDNBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string GJEIIMEENIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode KEBODDGLOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool OEHLEEEPFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x636E8B0", Offset = "0x636DCB0", VA = "0x18636E8B0")]
		public NFGFFIKMMON(TaskCompletionSource<Scene> PBBFJNMKHCI, string GJEIIMEENIK, LoadSceneMode KEBODDGLOLP, bool OEHLEEEPFHF, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct BPDLLBJAGBJ : IAsyncStateMachine
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
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private KGKDBPAMFIO<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x6357C50", Offset = "0x6357050", VA = "0x186357C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x63584F0", Offset = "0x63578F0", VA = "0x1863584F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct BALAJPENEGD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63575A0", Offset = "0x63569A0", VA = "0x1863575A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x63578C0", Offset = "0x6356CC0", VA = "0x1863578C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GDFADFELJPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private NFGFFIKMMON <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x63617F0", Offset = "0x6360BF0", VA = "0x1863617F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6361BA0", Offset = "0x6360FA0", VA = "0x186361BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class ANFLNMEOIGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BOLHGOALIJH<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ANFLNMEOIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6357540", Offset = "0x6356940", VA = "0x186357540")]
		internal void JAAILCLBHBF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct NAGHHPKKELE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

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
		private ANFLNMEOIGF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x636D370", Offset = "0x636C770", VA = "0x18636D370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x636DF10", Offset = "0x636D310", VA = "0x18636DF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct PKPJGGMNBGC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x636FFD0", Offset = "0x636F3D0", VA = "0x18636FFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x63704E0", Offset = "0x636F8E0", VA = "0x1863704E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct JKKANEEKJHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KGKDBPAMFIO<string>.HDBHKIOKMPF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6365950", Offset = "0x6364D50", VA = "0x186365950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x63664A0", Offset = "0x63658A0", VA = "0x1863664A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class DJHLHDDFFEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DJHLHDDFFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x635E4A0", Offset = "0x635D8A0", VA = "0x18635E4A0")]
		internal bool PJMPLCECGKI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class OGPJLJJFCMJ : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public NMHMFMOCBJF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public OGPJLJJFCMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x636EEA0", Offset = "0x636E2A0", VA = "0x18636EEA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x636EAC0", Offset = "0x636DEC0", VA = "0x18636EAC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x636EE00", Offset = "0x636E200", VA = "0x18636EE00")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x636EE50", Offset = "0x636E250", VA = "0x18636EE50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class JAIIIGGAEEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public BOLHGOALIJH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public JAIIIGGAEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6365100", Offset = "0x6364500", VA = "0x186365100")]
		internal bool LNPCKNEKFEH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6364E80", Offset = "0x6364280", VA = "0x186364E80")]
		internal void HPNLPGPHPDN(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class GBJCAPEMAIK : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public BOLHGOALIJH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private JAIIIGGAEEH <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public GBJCAPEMAIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6360CD0", Offset = "0x63600D0", VA = "0x186360CD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x63613E0", Offset = "0x63607E0", VA = "0x1863613E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> MGLOBLNGILB;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static IKPLFJCHDDD KLPBAKMFDMG;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation DDAAPEFIFLC;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static IKPLFJCHDDD OJKHDCFAOFK;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string CPAEPLBMFJE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority HKEJLKJKCKB;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task JGHKBLFKLLF;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> KGNDEJAHKCI;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<NFGFFIKMMON> GLBIBPOAMKE;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task APGAOAPIHDH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool GEKILCCEKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6364410", Offset = "0x6363810", VA = "0x186364410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool DLKODBANHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6363110", Offset = "0x6362510", VA = "0x186363110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool HDJIDJACEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6363070", Offset = "0x6362470", VA = "0x186363070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool DMMMHMHLNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6364250", Offset = "0x6363650", VA = "0x186364250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> NNKFLOPMDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6363460", Offset = "0x6362860", VA = "0x186363460")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6363250", Offset = "0x6362650", VA = "0x186363250")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6363360", Offset = "0x6362760", VA = "0x186363360")]
	[EHPPELLEMKJ(BNMAFOGGIIG.EnteredEditModeNextFrame, 0)]
	private static void BGGDINLGCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6364100", Offset = "0x6363500", VA = "0x186364100")]
	[AsyncStateMachine(typeof(BPDLLBJAGBJ))]
	public static Task<Scene> JEONKIKCOLH(string GJEIIMEENIK, LoadSceneMode KEBODDGLOLP = LoadSceneMode.Single, bool OEHLEEEPFHF = false, [Optional] KGKDBPAMFIO<string>.HDBHKIOKMPF CMLPNHHNJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x63636F0", Offset = "0x6362AF0", VA = "0x1863636F0")]
	[AsyncStateMachine(typeof(BALAJPENEGD))]
	private static Task CDBJDDDBAJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6363BF0", Offset = "0x6362FF0", VA = "0x186363BF0")]
	[AsyncStateMachine(typeof(GDFADFELJPP))]
	private static Task EBJAGKAFDDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6363FB0", Offset = "0x63633B0", VA = "0x186363FB0")]
	[AsyncStateMachine(typeof(NAGHHPKKELE))]
	private static Task<Scene> IPKMPGCDCKN(string GJEIIMEENIK, LoadSceneMode KEBODDGLOLP, bool OEHLEEEPFHF, KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6364630", Offset = "0x6363A30", VA = "0x186364630")]
	private static void MBFLJBDBADD(SceneInstance CLFOAALEFAI, LoadSceneMode KEBODDGLOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6363EF0", Offset = "0x63632F0", VA = "0x186363EF0")]
	private static void ILDGOHDLHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6363DD0", Offset = "0x63631D0", VA = "0x186363DD0")]
	[AsyncStateMachine(typeof(PKPJGGMNBGC))]
	private static Task<Scene> IBAICMEAGNL(string GJEIIMEENIK, LoadSceneMode KEBODDGLOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6363B00", Offset = "0x6362F00", VA = "0x186363B00")]
	private static bool DOEMHHIMBFI(string GJEIIMEENIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6363CC0", Offset = "0x63630C0", VA = "0x186363CC0")]
	[AsyncStateMachine(typeof(JKKANEEKJHC))]
	private static Task<Scene> GNCEEKIFBFC(KGKDBPAMFIO<string>.HDBHKIOKMPF LDDJCLDMANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6363570", Offset = "0x6362970", VA = "0x186363570")]
	public static DMGBOCKAFMH<Scene> BLNGMELJKFK(string GJEIIMEENIK, LoadSceneMode KEBODDGLOLP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6363830", Offset = "0x6362C30", VA = "0x186363830")]
	public static IKPLFJCHDDD DFAHDMDIOMP(string GJEIIMEENIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x63637A0", Offset = "0x6362BA0", VA = "0x1863637A0")]
	[IteratorStateMachine(typeof(OGPJLJJFCMJ))]
	private static IEnumerator<AOAPPGOKEOI> CFNHGGHOJHH(string GJEIIMEENIK, NMHMFMOCBJF OFCGGBPDNMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x63631B0", Offset = "0x63625B0", VA = "0x1863631B0")]
	[IteratorStateMachine(typeof(GBJCAPEMAIK))]
	private static IEnumerator<AOAPPGOKEOI> APCNOGJEMNO(string GJEIIMEENIK, LoadSceneMode KEBODDGLOLP, BOLHGOALIJH<Scene> OFCGGBPDNMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x63642E0", Offset = "0x63636E0", VA = "0x1863642E0")]
	public static bool LEAMOKHEKOI([Out] string MCIAINBMPMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class HFEIHJJJHFM
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6362A40", Offset = "0x6361E40", VA = "0x186362A40")]
	public static IDisposable OFIBCMKMFPM(this DHIMCJCHAKB CNKGFJIJGPA, float AIAGCKBAEFI, Action<float> MBBGMGFANPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6362940", Offset = "0x6361D40", VA = "0x186362940")]
	public static IDisposable LLBKCAAEGKL(this DHIMCJCHAKB CNKGFJIJGPA, Action<float> MBBGMGFANPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x63629C0", Offset = "0x6361DC0", VA = "0x1863629C0")]
	public static IDisposable NPDCOAAKGNF(this DHIMCJCHAKB CNKGFJIJGPA, Action<float> MBBGMGFANPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FOJPINNJBJH
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6360840", Offset = "0x635FC40", VA = "0x186360840")]
	public static IDisposable JABMNMOIDIP(this MonoBehaviour ACIJMAHOIPB, Action MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x63608D0", Offset = "0x635FCD0", VA = "0x1863608D0")]
	public static IDisposable JABMNMOIDIP(this MonoBehaviour ACIJMAHOIPB, Action<float> MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6360960", Offset = "0x635FD60", VA = "0x186360960")]
	public static IDisposable MCPJDCOFDHA(this MonoBehaviour ACIJMAHOIPB, Action MBBGMGFANPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6360A80", Offset = "0x635FE80", VA = "0x186360A80")]
	public static IDisposable OIDBFPCGOHI(this MonoBehaviour ACIJMAHOIPB, Action MBBGMGFANPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6360250", Offset = "0x635F650", VA = "0x186360250")]
	public static IDisposable BHIDFMIADLP(this MonoBehaviour ACIJMAHOIPB, Action MBBGMGFANPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x63607C0", Offset = "0x635FBC0", VA = "0x1863607C0")]
	public static IDisposable GABPNLLMKOI(this MonoBehaviour ACIJMAHOIPB, Action MBBGMGFANPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6360600", Offset = "0x635FA00", VA = "0x186360600")]
	public static IDisposable DOFOBHHJCMK(this MonoBehaviour ACIJMAHOIPB, Action MBBGMGFANPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x63602D0", Offset = "0x635F6D0", VA = "0x1863602D0")]
	public static IDisposable CDKCJHJKCNE(this MonoBehaviour ACIJMAHOIPB, float AIAGCKBAEFI, Action<float> MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG, bool NOEHMNFHAIB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6360BB0", Offset = "0x635FFB0", VA = "0x186360BB0")]
	public static IDisposable PIFMPOEEEOA(this MonoBehaviour ACIJMAHOIPB, float AIAGCKBAEFI, Action<float> MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG, bool NOEHMNFHAIB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x63609E0", Offset = "0x635FDE0", VA = "0x1863609E0")]
	public static IDisposable MHOODMOGEMD(this MonoBehaviour ACIJMAHOIPB, float AIAGCKBAEFI, Action<float> MBBGMGFANPJ, bool NOEHMNFHAIB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6360720", Offset = "0x635FB20", VA = "0x186360720")]
	public static IDisposable FCGHFCNNFGO(this MonoBehaviour ACIJMAHOIPB, Action<float> MBBGMGFANPJ, bool NOEHMNFHAIB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x63601B0", Offset = "0x635F5B0", VA = "0x1863601B0")]
	public static IDisposable ADJAHOKNLJI(this MonoBehaviour ACIJMAHOIPB, Action<float> MBBGMGFANPJ, bool NOEHMNFHAIB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6360380", Offset = "0x635F780", VA = "0x186360380")]
	public static IDisposable CEHILJCNMHG(this MonoBehaviour ACIJMAHOIPB, Action<float> MBBGMGFANPJ, bool NOEHMNFHAIB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6360680", Offset = "0x635FA80", VA = "0x186360680")]
	public static IDisposable EFPHFOFHLBG(this MonoBehaviour ACIJMAHOIPB, Action<float> MBBGMGFANPJ, bool NOEHMNFHAIB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6360420", Offset = "0x635F820", VA = "0x186360420")]
	public static IDisposable CKKBLAFFCPJ(this MonoBehaviour ACIJMAHOIPB, Action<float> MBBGMGFANPJ, bool NOEHMNFHAIB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6360560", Offset = "0x635F960", VA = "0x186360560")]
	public static IDisposable DFGJKHELDAJ(this MonoBehaviour ACIJMAHOIPB, Action<float> MBBGMGFANPJ, bool NOEHMNFHAIB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x63604C0", Offset = "0x635F8C0", VA = "0x1863604C0")]
	public static IDisposable DCNONCELBMH(this MonoBehaviour ACIJMAHOIPB, Action<float> MBBGMGFANPJ, bool NOEHMNFHAIB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6360B00", Offset = "0x635FF00", VA = "0x186360B00")]
	public static IDisposable PBHMHMHDLEF(this MonoBehaviour ACIJMAHOIPB, float AIAGCKBAEFI, Action<float> MBBGMGFANPJ, bool NOEHMNFHAIB = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class OJDDAHHKBHE
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class MMFCFDNCJHE : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public BKEELODPLGM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private FEIMDPPAFBK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public MMFCFDNCJHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x636D240", Offset = "0x636C640", VA = "0x18636D240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x636D320", Offset = "0x636C720", VA = "0x18636D320", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class GGGENOFKELL : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public BKEELODPLGM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private FEIMDPPAFBK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public GGGENOFKELL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6361C00", Offset = "0x6361000", VA = "0x186361C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6361CF0", Offset = "0x63610F0", VA = "0x186361CF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x636F180", Offset = "0x636E580", VA = "0x18636F180")]
	public static GKKBBPDHGPP JABMNMOIDIP(Action MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x636F350", Offset = "0x636E750", VA = "0x18636F350")]
	public static GKKBBPDHGPP JABMNMOIDIP(Behaviour CNKGFJIJGPA, Action MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x636F230", Offset = "0x636E630", VA = "0x18636F230")]
	public static GKKBBPDHGPP JABMNMOIDIP(Behaviour CNKGFJIJGPA, Action<float> MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x636F060", Offset = "0x636E460", VA = "0x18636F060")]
	[IteratorStateMachine(typeof(MMFCFDNCJHE))]
	private static IEnumerator<AOAPPGOKEOI> HCLIABDGCPI(BKEELODPLGM IBCFCPNGPOO, Action MBBGMGFANPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x636F0F0", Offset = "0x636E4F0", VA = "0x18636F0F0")]
	[IteratorStateMachine(typeof(GGGENOFKELL))]
	private static IEnumerator<AOAPPGOKEOI> HCLIABDGCPI(BKEELODPLGM IBCFCPNGPOO, Action<float> MBBGMGFANPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NDFMPNOECFM : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class BGDNEEBLKLL : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public NDFMPNOECFM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public BGDNEEBLKLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6357920", Offset = "0x6356D20", VA = "0x186357920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x63579B0", Offset = "0x6356DB0", VA = "0x1863579B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly BKEELODPLGM NPEICFPFAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action HAEBEJGPKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool JJPIHJGGHOF;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HILLDNJKHHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x767950", Offset = "0x766D50", VA = "0x180767950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x636E2E0", Offset = "0x636D6E0", VA = "0x18636E2E0")]
	public NDFMPNOECFM(BKEELODPLGM NPEICFPFAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x636E1C0", Offset = "0x636D5C0", VA = "0x18636E1C0")]
	[IteratorStateMachine(typeof(BGDNEEBLKLL))]
	private IEnumerator<AOAPPGOKEOI> DKLADNFKJJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x636E240", Offset = "0x636D640", VA = "0x18636E240", Slot = "4")]
	public void OnCompleted(Action AOJEMMBDHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public void BMDPJCBEKPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class ENMGNPGGENO
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x635F520", Offset = "0x635E920", VA = "0x18635F520")]
	public static NDFMPNOECFM IGKNDCIJPBN(this BKEELODPLGM NPEICFPFAEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class JKMFLLHEEKN
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class LOEFIJKKJJH : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public ECFFAEHONOO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public LOEFIJKKJJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x636C550", Offset = "0x636B950", VA = "0x18636C550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x636C5D0", Offset = "0x636B9D0", VA = "0x18636C5D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x63667E0", Offset = "0x6365BE0", VA = "0x1863667E0")]
	public static GKKBBPDHGPP JABMNMOIDIP(float AIAGCKBAEFI, Action<float> MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG, bool NOEHMNFHAIB = true, [Optional] EKOFEKNNHFP LONGOFLOLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x63668E0", Offset = "0x6365CE0", VA = "0x1863668E0")]
	public static GKKBBPDHGPP JABMNMOIDIP(MonoBehaviour ACIJMAHOIPB, float AIAGCKBAEFI, Action<float> MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG, bool NOEHMNFHAIB = true, [Optional] EKOFEKNNHFP LONGOFLOLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6366600", Offset = "0x6365A00", VA = "0x186366600")]
	public static GKKBBPDHGPP FKEEGAEHGNE(MonoBehaviour ACIJMAHOIPB, float AIAGCKBAEFI, Action<float> MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG, bool NOEHMNFHAIB = true, [Optional] EKOFEKNNHFP LONGOFLOLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x63669F0", Offset = "0x6365DF0", VA = "0x1863669F0")]
	public static GKKBBPDHGPP OLJAKJMABEJ(DHIMCJCHAKB CNKGFJIJGPA, float AIAGCKBAEFI, Action<float> MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG, bool NOEHMNFHAIB = true, [Optional] EKOFEKNNHFP LONGOFLOLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6366720", Offset = "0x6365B20", VA = "0x186366720")]
	private static IEnumerator<AOAPPGOKEOI> HCLIABDGCPI(NNEHOLBFJHC DFGFONAAOEH, float AIAGCKBAEFI, BKEELODPLGM IBCFCPNGPOO, Action<float> MBBGMGFANPJ, bool NOEHMNFHAIB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x63665A0", Offset = "0x63659A0", VA = "0x1863665A0")]
	private static IEnumerator<AOAPPGOKEOI> ELLJHIDDHAM(NNEHOLBFJHC DFGFONAAOEH, float AIAGCKBAEFI, BKEELODPLGM IBCFCPNGPOO, Action<float> MBBGMGFANPJ, bool NOEHMNFHAIB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6366510", Offset = "0x6365910", VA = "0x186366510")]
	[IteratorStateMachine(typeof(LOEFIJKKJJH))]
	private static IEnumerator<AOAPPGOKEOI> CKHFALMEKEL(ECFFAEHONOO INPMCBOKLKC, float AIAGCKBAEFI, BKEELODPLGM IBCFCPNGPOO, Action<float> MBBGMGFANPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class NKNJOPJMBCD
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class NEELHIHHKBI : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public BKEELODPLGM queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public NEELHIHHKBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x636E3F0", Offset = "0x636D7F0", VA = "0x18636E3F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x636E4B0", Offset = "0x636D8B0", VA = "0x18636E4B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x636EA30", Offset = "0x636DE30", VA = "0x18636EA30")]
	[IteratorStateMachine(typeof(NEELHIHHKBI))]
	private static IEnumerator<AOAPPGOKEOI> MLKFMGOBKNM(BKEELODPLGM NPEICFPFAEG, Func<bool> GIMEOEFLEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x636E910", Offset = "0x636DD10", VA = "0x18636E910")]
	public static GKKBBPDHGPP MAAINCIJNDF(this MonoBehaviour ACIJMAHOIPB, Func<bool> GIMEOEFLEBE, BKEELODPLGM NPEICFPFAEG = BKEELODPLGM.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class ABBIJGFLFBH
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class EMLPKEIGKDF : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public BKEELODPLGM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public EMLPKEIGKDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x635F460", Offset = "0x635E860", VA = "0x18635F460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x635F4D0", Offset = "0x635E8D0", VA = "0x18635F4D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class ECGCFOPCCIA : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public BKEELODPLGM queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private AOAPPGOKEOI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public ECGCFOPCCIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x635F060", Offset = "0x635E460", VA = "0x18635F060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x635F0F0", Offset = "0x635E4F0", VA = "0x18635F0F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6356B60", Offset = "0x6355F60", VA = "0x186356B60")]
	[IteratorStateMachine(typeof(EMLPKEIGKDF))]
	private static IEnumerator<AOAPPGOKEOI> DKLADNFKJJH(float OJILNLBEDDP, BKEELODPLGM IBCFCPNGPOO, Action LGMHODENKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6357200", Offset = "0x6356600", VA = "0x186357200")]
	[IteratorStateMachine(typeof(ECGCFOPCCIA))]
	private static IEnumerator<AOAPPGOKEOI> NKCHHLNFMKK(float OJILNLBEDDP, BKEELODPLGM IBCFCPNGPOO, Action LGMHODENKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6356C30", Offset = "0x6356030", VA = "0x186356C30")]
	public static IDisposable EHEDMONKPCG(this MonoBehaviour ACIJMAHOIPB, float OJILNLBEDDP, Action LGMHODENKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6356EA0", Offset = "0x63562A0", VA = "0x186356EA0")]
	public static GKKBBPDHGPP GAHOGILNPNE(this MonoBehaviour ACIJMAHOIPB, float OJILNLBEDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6356D50", Offset = "0x6356150", VA = "0x186356D50")]
	public static GKKBBPDHGPP EHEDMONKPCG(this MonoBehaviour ACIJMAHOIPB, float OJILNLBEDDP, BKEELODPLGM IBCFCPNGPOO, Action LGMHODENKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6356E80", Offset = "0x6356280", VA = "0x186356E80")]
	public static GKKBBPDHGPP ELEOCJKOLDH(this MonoBehaviour ACIJMAHOIPB, Action LGMHODENKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6356B00", Offset = "0x6355F00", VA = "0x186356B00")]
	public static GKKBBPDHGPP AGJBBMNEGME(this MonoBehaviour ACIJMAHOIPB, Action LGMHODENKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6357370", Offset = "0x6356770", VA = "0x186357370")]
	public static GKKBBPDHGPP PNLBPBMMAOI(this MonoBehaviour ACIJMAHOIPB, Action LGMHODENKOA, [Optional] EKOFEKNNHFP LONGOFLOLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6356C00", Offset = "0x6356000", VA = "0x186356C00")]
	public static GKKBBPDHGPP DMBBOOPGCHM(this MonoBehaviour ACIJMAHOIPB, Action LGMHODENKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6356B30", Offset = "0x6355F30", VA = "0x186356B30")]
	public static GKKBBPDHGPP CLDMPNMHHMC(this MonoBehaviour ACIJMAHOIPB, Action LGMHODENKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6357030", Offset = "0x6356430", VA = "0x186357030")]
	public static GKKBBPDHGPP JHLNJNOPEFB(this MonoBehaviour ACIJMAHOIPB, Action LGMHODENKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6357060", Offset = "0x6356460", VA = "0x186357060")]
	private static GKKBBPDHGPP KCHKICEJHMF(MonoBehaviour ACIJMAHOIPB, BKEELODPLGM NPEICFPFAEG, Action LGMHODENKOA, [Optional] EKOFEKNNHFP LONGOFLOLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6356F60", Offset = "0x6356360", VA = "0x186356F60")]
	public static GKKBBPDHGPP GDGAGDFHOGO(this MonoBehaviour ACIJMAHOIPB, float DALCHJFEBMM, Action LGMHODENKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6356A30", Offset = "0x6355E30", VA = "0x186356A30")]
	public static GKKBBPDHGPP AFFPGBCLCAP(this MonoBehaviour ACIJMAHOIPB, float DALCHJFEBMM, Action LGMHODENKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x63572A0", Offset = "0x63566A0", VA = "0x1863572A0")]
	public static GKKBBPDHGPP OLFFHAFMGOD(this MonoBehaviour ACIJMAHOIPB, float DALCHJFEBMM, Action LGMHODENKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6357130", Offset = "0x6356530", VA = "0x186357130")]
	public static GKKBBPDHGPP LJGPAJKHBDI(this MonoBehaviour ACIJMAHOIPB, float DALCHJFEBMM, Action LGMHODENKOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class FBDFFIJGNCA : HFOFNKEAENC, IEnumerable<HFOFNKEAENC>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<HFOFNKEAENC> KFNIADHHBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool CDFAGMMJMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action FAKFHJGOFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool DPBADFJKPKJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool OPBLFJJFAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x635FD30", Offset = "0x635F130", VA = "0x18635FD30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OMHDNENBJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x635FE70", Offset = "0x635F270", VA = "0x18635FE70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x635F980", Offset = "0x635ED80", VA = "0x18635F980", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x635FF10", Offset = "0x635F310", VA = "0x18635FF10")]
	public FBDFFIJGNCA([Optional] Action FAKFHJGOFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x635FB80", Offset = "0x635EF80", VA = "0x18635FB80")]
	public void GIHKKMKIIOJ(HFOFNKEAENC AKAGKOGBBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x635FA20", Offset = "0x635EE20", VA = "0x18635FA20")]
	private void FCPCOIMNHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x635F970", Offset = "0x635ED70", VA = "0x18635F970", Slot = "7")]
	public bool CKFADCBBMMF(bool EAJNNLJOPDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x635F660", Offset = "0x635EA60", VA = "0x18635F660", Slot = "8")]
	public bool CKFADCBBMMF(Action PAFFKHOCLGN, bool EAJNNLJOPDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x635FCB0", Offset = "0x635F0B0", VA = "0x18635FCB0", Slot = "9")]
	public IEnumerator<HFOFNKEAENC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x635FCB0", Offset = "0x635F0B0", VA = "0x18635FCB0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KMHFIFKAKPH : JGJIPFAMIJI
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HOGHMEDLMFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public KMHFIFKAKPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HOGHMEDLMFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6363040", Offset = "0x6362440", VA = "0x186363040")]
		internal void NHMJIECDJHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class MEDLHKPGNJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public KMHFIFKAKPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public MEDLHKPGNJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6363040", Offset = "0x6362440", VA = "0x186363040")]
		internal void MLCMFFFFGFM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float GANHELGJHAE;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x63671F0", Offset = "0x63665F0", VA = "0x1863671F0")]
	public KMHFIFKAKPH(Behaviour CNKGFJIJGPA, float GANHELGJHAE, [Optional] Action FAKFHJGOFEK, [Optional] EKOFEKNNHFP LONGOFLOLFA, [Optional] NNEHOLBFJHC DFGFONAAOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x63670E0", Offset = "0x63664E0", VA = "0x1863670E0", Slot = "9")]
	protected override bool OLJBMPPLKCE(Action PAFFKHOCLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6366FD0", Offset = "0x63663D0", VA = "0x186366FD0", Slot = "10")]
	protected override bool OCNANEDENCJ(Action PAFFKHOCLGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface HFOFNKEAENC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OPBLFJJFAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OMHDNENBJEH;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CKFADCBBMMF(bool EAJNNLJOPDA = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CKFADCBBMMF(Action PAFFKHOCLGN, bool EAJNNLJOPDA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class JGJIPFAMIJI : HFOFNKEAENC
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class GCBOAIKAAKH : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public JGJIPFAMIJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public GCBOAIKAAKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6361430", Offset = "0x6360830", VA = "0x186361430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6361500", Offset = "0x6360900", VA = "0x186361500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour CNKGFJIJGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action FAKFHJGOFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private KBDGBPHCLNK FPHHJGGCNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly EKOFEKNNHFP LONGOFLOLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly NNEHOLBFJHC DFGFONAAOEH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool OPBLFJJFAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xDC2350", Offset = "0xDC1750", VA = "0x180DC2350", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OMHDNENBJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6365750", Offset = "0x6364B50", VA = "0x186365750", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x63656B0", Offset = "0x6364AB0", VA = "0x1863656B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6365850", Offset = "0x6364C50", VA = "0x186365850")]
	protected JGJIPFAMIJI(Behaviour CNKGFJIJGPA, [Optional] Action FAKFHJGOFEK, [Optional] EKOFEKNNHFP LONGOFLOLFA, [Optional] NNEHOLBFJHC DFGFONAAOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6365570", Offset = "0x6364970", VA = "0x186365570", Slot = "7")]
	public bool CKFADCBBMMF(bool EAJNNLJOPDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x63655D0", Offset = "0x63649D0", VA = "0x1863655D0", Slot = "8")]
	public bool CKFADCBBMMF(Action PAFFKHOCLGN, bool EAJNNLJOPDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OLJBMPPLKCE(Action PAFFKHOCLGN);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool OCNANEDENCJ(Action PAFFKHOCLGN);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x63657F0", Offset = "0x6364BF0", VA = "0x1863657F0")]
	protected void LOBAOBNEFPP(Action PAFFKHOCLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6365330", Offset = "0x6364730", VA = "0x186365330")]
	protected IKPLFJCHDDD BKFPBDPFJCA(float DGGLMJANNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6365630", Offset = "0x6364A30", VA = "0x186365630")]
	private void CKGBNBBAAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x63652A0", Offset = "0x63646A0", VA = "0x1863652A0")]
	[IteratorStateMachine(typeof(GCBOAIKAAKH))]
	private IEnumerator<AOAPPGOKEOI> AOIBLCHENLL(float DGGLMJANNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6365810", Offset = "0x6364C10", VA = "0x186365810")]
	[CompilerGenerated]
	private void MLGKBFHDKPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class DPHCKCAKDAJ : JGJIPFAMIJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float LGKMANAEOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int MNLDBDIHFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float KJEAOIPCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] FJIOGBFNGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int INJGFJNMEOO;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x635EEC0", Offset = "0x635E2C0", VA = "0x18635EEC0")]
	public DPHCKCAKDAJ(Behaviour CNKGFJIJGPA, float FGGJKHFDLNG, int MNLDBDIHFNC, [Optional] Action FAKFHJGOFEK, float KJEAOIPCOJI = 0f, [Optional] EKOFEKNNHFP LONGOFLOLFA, [Optional] NNEHOLBFJHC DFGFONAAOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "9")]
	protected override bool OLJBMPPLKCE(Action PAFFKHOCLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x635ECC0", Offset = "0x635E0C0", VA = "0x18635ECC0", Slot = "10")]
	protected override bool OCNANEDENCJ(Action PAFFKHOCLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x635EC40", Offset = "0x635E040", VA = "0x18635EC40")]
	private void BAHNLOEPHGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class ONFBPKAEEFG : JGJIPFAMIJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float GANHELGJHAE;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x63671F0", Offset = "0x63665F0", VA = "0x1863671F0")]
	public ONFBPKAEEFG(Behaviour CNKGFJIJGPA, float GANHELGJHAE, [Optional] Action FAKFHJGOFEK, [Optional] EKOFEKNNHFP LONGOFLOLFA, [Optional] NNEHOLBFJHC DFGFONAAOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "9")]
	protected override bool OLJBMPPLKCE(Action PAFFKHOCLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x636F410", Offset = "0x636E810", VA = "0x18636F410", Slot = "10")]
	protected override bool OCNANEDENCJ(Action PAFFKHOCLGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class DOBDKIDCPKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class EIFGIHHNKML : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public EIFGIHHNKML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6358560", Offset = "0x6357960", VA = "0x186358560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x635F410", Offset = "0x635E810", VA = "0x18635F410", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GKKBBPDHGPP GEBIPNHEIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private DHIMCJCHAKB CNKGFJIJGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> MDILIFMPGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private BKEELODPLGM NPEICFPFAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float EIMMFKJADCO;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x635EA60", Offset = "0x635DE60", VA = "0x18635EA60")]
	public DOBDKIDCPKG(DHIMCJCHAKB CNKGFJIJGPA, float AIAGCKBAEFI, Action<float> MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x635E530", Offset = "0x635D930", VA = "0x18635E530")]
	private void IFEOMMLLHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x635E880", Offset = "0x635DC80", VA = "0x18635E880")]
	private void MMEOPMDCLEN(string NJAPBBBJJNP, Action POCNMBNHFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x635E9E0", Offset = "0x635DDE0", VA = "0x18635E9E0")]
	[IteratorStateMachine(typeof(EIFGIHHNKML))]
	private IEnumerator<AOAPPGOKEOI> NFHGBCJICHP(Action POCNMBNHFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x635E4D0", Offset = "0x635D8D0", VA = "0x18635E4D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x635E6D0", Offset = "0x635DAD0", VA = "0x18635E6D0")]
	[CompilerGenerated]
	private void LHDFNDLMIIO(string BGPAKNDLMFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class CBIKADJMMBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class CAACJNPIAKI : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public CAACJNPIAKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6358560", Offset = "0x6357960", VA = "0x186358560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x63585D0", Offset = "0x63579D0", VA = "0x1863585D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private GKKBBPDHGPP GEBIPNHEIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour ACIJMAHOIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action MBBGMGFANPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> MDILIFMPGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private BKEELODPLGM NPEICFPFAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float EIMMFKJADCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool NOEHMNFHAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly EKOFEKNNHFP LONGOFLOLFA;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6359230", Offset = "0x6358630", VA = "0x186359230")]
	public CBIKADJMMBF(MonoBehaviour ACIJMAHOIPB, Action MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG, [Optional] EKOFEKNNHFP LONGOFLOLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6359670", Offset = "0x6358A70", VA = "0x186359670")]
	public CBIKADJMMBF(MonoBehaviour ACIJMAHOIPB, Action<float> MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG, [Optional] EKOFEKNNHFP LONGOFLOLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6359420", Offset = "0x6358820", VA = "0x186359420")]
	public CBIKADJMMBF(MonoBehaviour ACIJMAHOIPB, float AIAGCKBAEFI, Action<float> MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG, bool NOEHMNFHAIB = true, [Optional] EKOFEKNNHFP LONGOFLOLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x17A14F0", Offset = "0x17A08F0", VA = "0x1817A14F0")]
	private CBIKADJMMBF(EKOFEKNNHFP LONGOFLOLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6358A30", Offset = "0x6357E30", VA = "0x186358A30")]
	internal static CBIKADJMMBF JMJJEMODFPJ(MonoBehaviour ACIJMAHOIPB, float AIAGCKBAEFI, Action<float> MBBGMGFANPJ, BKEELODPLGM NPEICFPFAEG, bool NOEHMNFHAIB = true, [Optional] EKOFEKNNHFP LONGOFLOLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x63588C0", Offset = "0x6357CC0", VA = "0x1863588C0")]
	private void JABMNMOIDIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6359080", Offset = "0x6358480", VA = "0x186359080")]
	private void NPAAMPBNFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6358710", Offset = "0x6357B10", VA = "0x186358710")]
	private void IFEOMMLLHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6358D10", Offset = "0x6358110", VA = "0x186358D10")]
	private void MDAGMOBNDOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6358ED0", Offset = "0x63582D0", VA = "0x186358ED0")]
	private void MMEOPMDCLEN(string NJAPBBBJJNP, Action POCNMBNHFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6359000", Offset = "0x6358400", VA = "0x186359000")]
	[IteratorStateMachine(typeof(CAACJNPIAKI))]
	private IEnumerator<AOAPPGOKEOI> NFHGBCJICHP(Action POCNMBNHFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6358620", Offset = "0x6357A20", VA = "0x186358620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6358B60", Offset = "0x6357F60", VA = "0x186358B60")]
	[CompilerGenerated]
	private void LEBEJAMODPB(string BGPAKNDLMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6358BF0", Offset = "0x6357FF0", VA = "0x186358BF0")]
	[CompilerGenerated]
	private void LFAIBMDLPIH(string BGPAKNDLMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6358680", Offset = "0x6357A80", VA = "0x186358680")]
	[CompilerGenerated]
	private void FJEHFEEIKBC(string BGPAKNDLMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6358C80", Offset = "0x6358080", VA = "0x186358C80")]
	[CompilerGenerated]
	private void LFNENAKMKCE(string BGPAKNDLMFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum OCMHNFOCMAA : byte
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
internal sealed class IOEAFFGECIO : NNEHOLBFJHC
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float AFJAGFPAEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6364E00", Offset = "0x6364200", VA = "0x186364E00", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float BMDEHLEEOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6364DF0", Offset = "0x63641F0", VA = "0x186364DF0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double NHOBHEGNFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6364DD0", Offset = "0x63641D0", VA = "0x186364DD0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6364E10", Offset = "0x6364210", VA = "0x186364E10")]
	[DCEDJGMCFCN(IIPPAMCLFBJ.None)]
	private static void PODIJJHNPLH(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	[Preserve]
	internal IOEAFFGECIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface OPJMNLNLOII
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNJNECAGCPB(string DKFEAPHKBMP);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBMELDICGAE();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface OHKGJALDDLC
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool LKDFKBGEPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool LMBNHJJPJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class KDGCGPCAKMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public LGNGFGJCMFG IDPEIBBPAFO;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int ICOODGEKGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x762180", Offset = "0x761580", VA = "0x180762180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7712D0", Offset = "0x7706D0", VA = "0x1807712D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6366D30", Offset = "0x6366130", VA = "0x186366D30")]
	public static AOAPPGOKEOI KFNDFJKOBIA(IEnumerator<AOAPPGOKEOI> DGDJFMNDHDH, HBNILDMFFMM KNLNCNMIJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6366C70", Offset = "0x6366070", VA = "0x186366C70")]
	public AOAPPGOKEOI KFNDFJKOBIA(HBNILDMFFMM[] KACPFBEAONH, IEnumerator<AOAPPGOKEOI>[] GBHGLJEKKAA, AOAPPGOKEOI[] OEGKGJDBFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6366C40", Offset = "0x6366040", VA = "0x186366C40")]
	public void LPHCDEPNBCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6366B00", Offset = "0x6365F00", VA = "0x186366B00")]
	public void FONPAHAKCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6366E90", Offset = "0x6366290", VA = "0x186366E90")]
	public void NIONJIBLFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6366C40", Offset = "0x6366040", VA = "0x186366C40")]
	public void JGPNGJLKHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public KDGCGPCAKMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class LGNGFGJCMFG
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct OALABMFLMKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public KDGCGPCAKMA FDODLCFHLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public DHIMCJCHAKB KICFLDPKIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HBNILDMFFMM ACELFLOOKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<AOAPPGOKEOI> COJFEAGKMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AOAPPGOKEOI GCDEEIMIIPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public OCMHNFOCMAA CNFPDKLNLOK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct LDFPPHPFGNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public BKEELODPLGM EPLGBKOAAJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<OALABMFLMKH> PNEBKLEFPBC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class LPOKJDKJNAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public HBNILDMFFMM promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public LGNGFGJCMFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public DHIMCJCHAKB context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public KDGCGPCAKMA routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public OCMHNFOCMAA coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AOAPPGOKEOI currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<AOAPPGOKEOI> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public LPOKJDKJNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x636C890", Offset = "0x636BC90", VA = "0x18636C890")]
		internal void BFBDPLABNCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class EGKGNIGIHIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public KDGCGPCAKMA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public LGNGFGJCMFG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public EGKGNIGIHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x635F380", Offset = "0x635E780", VA = "0x18635F380")]
		internal void NAFCPNDMDMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class NBJHMHGHANG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public KDGCGPCAKMA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public LGNGFGJCMFG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public NBJHMHGHANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x636DF80", Offset = "0x636D380", VA = "0x18636DF80")]
		internal void BAKCFJDAIFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class PECJHGDOIKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public KDGCGPCAKMA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public LGNGFGJCMFG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public PECJHGDOIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x636FE40", Offset = "0x636F240", VA = "0x18636FE40")]
		internal void NDPIEGBCDFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const OCMHNFOCMAA FIAOMLFPNOK = OCMHNFOCMAA.Cancelled | OCMHNFOCMAA.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly BKEELODPLGM NPEICFPFAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] FGAHKKKJIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<OCMHNFOCMAA> ELEFJMHGLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> CIAAOKIBBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> HFPHLFOODKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> MFCPALAEDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> KKDOBIOKABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> LFMPACICPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> MABLJKHOOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private KDGCGPCAKMA[] JHFOJPMAFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private HBNILDMFFMM[] KACPFBEAONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private DHIMCJCHAKB[] KLLAFJKPEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<AOAPPGOKEOI>[] KHPEKGEDDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private AOAPPGOKEOI[] DMDGNIAEDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int MECFPIBPLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int ACGAEDNGFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int OLKCDCNIPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float EFBINKBLMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private PCGNEJLJFBA MGADKCGFHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle GABBNCDCDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<KDGCGPCAKMA> PCGLCEKGILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool PKAFHHKHMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> FAHGNIENDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> FEFJNOFAEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool FKCMADKNOHH;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public LDFPPHPFGNL[] JFAILCKBFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x89BBE0", Offset = "0x89AFE0", VA = "0x18089BBE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x636A4A0", Offset = "0x63698A0", VA = "0x18636A4A0")]
	private static int HGHIGBKJJHA(BKEELODPLGM NPEICFPFAEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x636BB00", Offset = "0x636AF00", VA = "0x18636BB00")]
	public LGNGFGJCMFG(BKEELODPLGM NPEICFPFAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6369DD0", Offset = "0x63691D0", VA = "0x186369DD0")]
	private void EJMIHINCIFE(int KCBLEFIHLHA, int LCICNLLOKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x636A320", Offset = "0x6369720", VA = "0x18636A320")]
	public void HFCIJDBGFFK(DHIMCJCHAKB CNKGFJIJGPA, AOAPPGOKEOI NAPNGKOJFPN, IEnumerator<AOAPPGOKEOI> DGDJFMNDHDH, HBNILDMFFMM KNLNCNMIJHD, [Optional] KDGCGPCAKMA LEJAABKFCII, OCMHNFOCMAA CDLOMGKEKDA = OCMHNFOCMAA.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6369FB0", Offset = "0x63693B0", VA = "0x186369FB0")]
	public void FDOKNFHKCAH(IEnumerable<OALABMFLMKH> BDLBNEFNAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x636AD00", Offset = "0x636A100", VA = "0x18636AD00")]
	private OALABMFLMKH JDMNCNKKDNO(int FFIPIPILLKL)
	{
		return default(OALABMFLMKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x63697A0", Offset = "0x6368BA0", VA = "0x1863697A0")]
	private void AALMFGJIDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x244D4D0", Offset = "0x244C8D0", VA = "0x18244D4D0")]
	private static void OOOFHNGIJFN<T>(int FFIPIPILLKL, T[] HFADMBCCIHD, int JGDHMDLNCOL, [Optional] T JFFMHMFHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x244D520", Offset = "0x244C920", VA = "0x18244D520")]
	private static void OOOFHNGIJFN<T>(int FFIPIPILLKL, NativeArray<T> HFADMBCCIHD, int JGDHMDLNCOL, [Optional] T JFFMHMFHEJB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x636B660", Offset = "0x636AA60", VA = "0x18636B660")]
	private void NJLGFNIBBIC(IEnumerable<OALABMFLMKH> BDLBNEFNAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6369D10", Offset = "0x6369110", VA = "0x186369D10")]
	private void EHCIHIENHCM(OALABMFLMKH MGHGJIJLFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x636B400", Offset = "0x636A800", VA = "0x18636B400")]
	private AELEDPEJHKJ NDKABCHBAHK(int ILAFMMLBBAD)
	{
		return default(AELEDPEJHKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6369B10", Offset = "0x6368F10", VA = "0x186369B10")]
	public void ALGNJJKJIIC(float HOKGCNFFPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x636B300", Offset = "0x636A700", VA = "0x18636B300")]
	private void KMMJHIHDOMB(Action BOGGCLFEFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x636B380", Offset = "0x636A780", VA = "0x18636B380")]
	private void NAMABMHANHP(Action BOGGCLFEFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x636A600", Offset = "0x6369A00", VA = "0x18636A600")]
	public void IHMNMACJELC(float HOKGCNFFPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x636BA00", Offset = "0x636AE00", VA = "0x18636BA00")]
	public void OCOEOHNAACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x636B1D0", Offset = "0x636A5D0", VA = "0x18636B1D0")]
	public void JGPNGJLKHJE(KDGCGPCAKMA INPMCBOKLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x636A4D0", Offset = "0x63698D0", VA = "0x18636A4D0")]
	public void HJHMCODJNOE(KDGCGPCAKMA INPMCBOKLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x636A1F0", Offset = "0x63695F0", VA = "0x18636A1F0")]
	public void HCNCMOCKIOC(KDGCGPCAKMA INPMCBOKLKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PKOIPBCMNJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly PKOIPBCMNJN KLACMHEBBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action GHBIGGOOOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool CHCAJAAKAHP;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	public PKOIPBCMNJN(Action GHBIGGOOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x636FE80", Offset = "0x636F280", VA = "0x18636FE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface IBIGOEIIEEM<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T OFPAGNFLHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable FCEHINGIFJP(UnityEngine.Object CNKGFJIJGPA, Action<T> LONACEKDCMO);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface PBAFMLNFDIP<T> : IBIGOEIIEEM<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T OFPAGNFLHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class LIFCCEKAIEI<T> : PBAFMLNFDIP<T>, IBIGOEIIEEM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class IODPFGJFEGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public LIFCCEKAIEI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public KPDLCEIOGLA<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public IODPFGJFEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x35F9DE0", Offset = "0x35F91E0", VA = "0x1835F9DE0")]
		internal void FJBCOPALGDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject IHNEHCMAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<KPDLCEIOGLA<UnityEngine.Object, Action<T>>> IKJFPOJCGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T DFOBCBFJHGB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T OFPAGNFLHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x804D90", Offset = "0x804190", VA = "0x180804D90", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x38DE800", Offset = "0x38DDC00", VA = "0x1838DE800", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x38DE730", Offset = "0x38DDB30", VA = "0x1838DE730")]
	private static bool NCGHOHOFLBE(T BOGGCLFEFDJ, T OGHJEHJOFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x38DE900", Offset = "0x38DDD00", VA = "0x1838DE900")]
	public LIFCCEKAIEI(T DOGGDGDPECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x38DDD80", Offset = "0x38DD180", VA = "0x1838DDD80", Slot = "6")]
	public IDisposable FCEHINGIFJP(UnityEngine.Object CNKGFJIJGPA, Action<T> LONACEKDCMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x38DE3D0", Offset = "0x38DD7D0", VA = "0x1838DE3D0")]
	private void IPNIGAEBGIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class INNNMHGILNK : LHKAFLOOFPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly EKOFEKNNHFP LONGOFLOLFA;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6364D60", Offset = "0x6364160", VA = "0x186364D60")]
	[DCEDJGMCFCN(IIPPAMCLFBJ.None)]
	private static void PODIJJHNPLH(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	[Preserve]
	internal INNNMHGILNK([LMAFJMDCBJO(null)] EKOFEKNNHFP LONGOFLOLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6364CB0", Offset = "0x63640B0", VA = "0x186364CB0", Slot = "4")]
	public IDisposable MHOODMOGEMD(float AIAGCKBAEFI, Action<float> AIBILCAOCLG, bool NOEHMNFHAIB = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class CLOIJGFPHHA : POGBCJKCOJC, EKOFEKNNHFP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private LGNGFGJCMFG[] ANNHHFIBAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private OPJMNLNLOII CINHAADEAIM;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x635A540", Offset = "0x6359940", VA = "0x18635A540")]
	[DCEDJGMCFCN(IIPPAMCLFBJ.None)]
	private static void PODIJJHNPLH(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x635A5B0", Offset = "0x63599B0", VA = "0x18635A5B0")]
	[Preserve]
	public CLOIJGFPHHA([LMAFJMDCBJO(null)] CDOHLKFPFCC NEDONNIIMNO, [LMAFJMDCBJO(null)] NNEHOLBFJHC DFGFONAAOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6359CD0", Offset = "0x63590D0", VA = "0x186359CD0", Slot = "16")]
	public override GKKBBPDHGPP CLEBJANKLPM(DHIMCJCHAKB CNKGFJIJGPA, IEnumerator<AOAPPGOKEOI> JHAHAKNAGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6359A40", Offset = "0x6358E40", VA = "0x186359A40", Slot = "17")]
	public override void CGCDLMDFFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x635A120", Offset = "0x6359520", VA = "0x18635A120", Slot = "19")]
	public override void FGBEFCDDNPN(BKEELODPLGM NPEICFPFAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x635A350", Offset = "0x6359750", VA = "0x18635A350", Slot = "18")]
	protected override void MCPJDCOFDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6359E00", Offset = "0x6359200", VA = "0x186359E00")]
	private LGNGFGJCMFG DFLCCJNMCIO(BKEELODPLGM DJMKKNDNCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6359FB0", Offset = "0x63593B0", VA = "0x186359FB0", Slot = "20")]
	internal override GIPFIKBKBIO EEAKDEOFPPM(IEnumerator<AOAPPGOKEOI> JHAHAKNAGHG, Behaviour CNKGFJIJGPA, HBNILDMFFMM KNLNCNMIJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x635A4C0", Offset = "0x63598C0", VA = "0x18635A4C0", Slot = "21")]
	internal override LGBPBMLDKLB MOINENJKGJJ(BKEELODPLGM IBCFCPNGPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6359E30", Offset = "0x6359230", VA = "0x186359E30")]
	private void DJFIMMHAOHC(LGNGFGJCMFG NHDBMPPILLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6359F50", Offset = "0x6359350", VA = "0x186359F50", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct PCGNEJLJFBA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float HLIMKLLIAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int FNJIEIJOIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> DKKLFAGEFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> IJAPMOGAJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> FKJMJHHBHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<OCMHNFOCMAA> KLCJAJHLKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> CKNGNBCCEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> KKDOBIOKABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> HFPHLFOODKM;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x636F950", Offset = "0x636ED50", VA = "0x18636F950")]
	public static PCGNEJLJFBA PJBIIEEDKDI(int IHFLLHLLGCH, float HOKGCNFFPBI, NativeArray<OCMHNFOCMAA> LBABINEONKL, NativeArray<float> GJPCBGDCKMD, NativeArray<int> LIALPJDFPNF, NativeArray<int> GLIKEEFJCCO, NativeArray<int> MFNDJNDDCDM, NativeArray<int> IJAPMOGAJLG, NativeArray<int> FKJMJHHBHBA)
	{
		return default(PCGNEJLJFBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x636F4F0", Offset = "0x636E8F0", VA = "0x18636F4F0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x636F5D0", Offset = "0x636E9D0", VA = "0x18636F5D0")]
	private bool GIFOMNADJEP(int JPEMHHILGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x636F610", Offset = "0x636EA10", VA = "0x18636F610")]
	private void JJLEHEPNKMJ(NativeArray<int> EEIHIIBPGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x636F450", Offset = "0x636E850", VA = "0x18636F450")]
	private int DEDDIBKKHNF(int NGNLLAKIDMD, int DGEMLMIDPCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x636F640", Offset = "0x636EA40", VA = "0x18636F640")]
	private void NONENFGEGJA(NativeArray<int> EEIHIIBPGEI, int HJPHIMLIILO, int OADEONFPOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x636F710", Offset = "0x636EB10", VA = "0x18636F710")]
	private void OMHLLGLJCBL(NativeArray<int> EEIHIIBPGEI, int HBMODJFLFEK, int KMLCLMJDFDH, int FPNFNLHCJHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class POGBCJKCOJC : EKOFEKNNHFP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly CDOHLKFPFCC NEDONNIIMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly NNEHOLBFJHC DFGFONAAOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private LGBPBMLDKLB[] JNMCDBKBEED;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static EKOFEKNNHFP OMCMBELJBID
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x63705D0", Offset = "0x636F9D0", VA = "0x1863705D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool JMGKFCEFHMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BKEELODPLGM AADMLHDKIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x762180", Offset = "0x761580", VA = "0x180762180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BKEELODPLGM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7712D0", Offset = "0x7706D0", VA = "0x1807712D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NNEHOLBFJHC GKLBOANCLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AOAPPGOKEOI JJMDIGIKPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7653E0", Offset = "0x7647E0", VA = "0x1807653E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6371400", Offset = "0x6370800", VA = "0x186371400")]
	public static GKKBBPDHGPP PKOGNIMPNPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6371490", Offset = "0x6370890", VA = "0x186371490")]
	[Preserve]
	protected POGBCJKCOJC([LMAFJMDCBJO(null)] CDOHLKFPFCC NEDONNIIMNO, [LMAFJMDCBJO(null)] NNEHOLBFJHC DFGFONAAOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6371190", Offset = "0x6370590", VA = "0x186371190", Slot = "6")]
	public GKKBBPDHGPP LAGINJJKIEC(IEnumerator<AOAPPGOKEOI> JHAHAKNAGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x63711A0", Offset = "0x63705A0", VA = "0x1863711A0", Slot = "7")]
	public GKKBBPDHGPP LAGINJJKIEC(Behaviour CNKGFJIJGPA, IEnumerator<AOAPPGOKEOI> JHAHAKNAGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract GKKBBPDHGPP CLEBJANKLPM(DHIMCJCHAKB CNKGFJIJGPA, IEnumerator<AOAPPGOKEOI> JHAHAKNAGHG);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6370620", Offset = "0x636FA20", VA = "0x186370620", Slot = "17")]
	public virtual void CGCDLMDFFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6370CE0", Offset = "0x63700E0", VA = "0x186370CE0", Slot = "9")]
	public void HCGJCCLDJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x63713C0", Offset = "0x63707C0", VA = "0x1863713C0", Slot = "18")]
	protected virtual void MCPJDCOFDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6370CA0", Offset = "0x63700A0", VA = "0x186370CA0")]
	private void GDPIFNKKMDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6370F80", Offset = "0x6370380", VA = "0x186370F80")]
	private void IMGOBDAACKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x63713E0", Offset = "0x63707E0", VA = "0x1863713E0")]
	private void OIDBFPCGOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x63705B0", Offset = "0x636F9B0", VA = "0x1863705B0")]
	private void BHIDFMIADLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6370FA0", Offset = "0x63703A0", VA = "0x186370FA0")]
	private void KEJEDDBGIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6370CC0", Offset = "0x63700C0", VA = "0x186370CC0")]
	private void GMEEMAAANOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x63713A0", Offset = "0x63707A0", VA = "0x1863713A0")]
	private void MCOJGMPOIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6370C10", Offset = "0x6370010", VA = "0x186370C10", Slot = "19")]
	public virtual void FGBEFCDDNPN(BKEELODPLGM NPEICFPFAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6370FC0", Offset = "0x63703C0", VA = "0x186370FC0")]
	private void KMPCEJGCEFD(LGBPBMLDKLB NHDBMPPILLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1B54E00", Offset = "0x1B54200", VA = "0x181B54E00")]
	private LGBPBMLDKLB PDPFDBACPAC(BKEELODPLGM DJMKKNDNCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract GIPFIKBKBIO EEAKDEOFPPM(IEnumerator<AOAPPGOKEOI> JHAHAKNAGHG, Behaviour ACIJMAHOIPB, HBNILDMFFMM GIMEEOHIJNO);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract LGBPBMLDKLB MOINENJKGJJ(BKEELODPLGM NPEICFPFAEG);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x63707C0", Offset = "0x636FBC0", VA = "0x1863707C0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6370550", Offset = "0x636F950", VA = "0x186370550", Slot = "12")]
	public AOAPPGOKEOI AFKEGCIPDGF(BKEELODPLGM IBCFCPNGPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6370B80", Offset = "0x636FF80", VA = "0x186370B80", Slot = "13")]
	public AOAPPGOKEOI FBLBPCJGAKK(float OJILNLBEDDP, BKEELODPLGM IBCFCPNGPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6370F20", Offset = "0x6370320", VA = "0x186370F20", Slot = "14")]
	public AOAPPGOKEOI ILIIMIGLANL(Func<bool> GIMEOEFLEBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class GIPFIKBKBIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly HBNILDMFFMM KNLNCNMIJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly OHKGJALDDLC CNKGFJIJGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool MOAFGJAIFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string DKFEAPHKBMP;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<AOAPPGOKEOI> COJFEAGKMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x764460", Offset = "0x763860", VA = "0x180764460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public AOAPPGOKEOI GCDEEIMIIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x7644F0", VA = "0x1807650F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool PJNEMAHLIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6362450", Offset = "0x6361850", VA = "0x186362450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool MFKIICIPHPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E72F0", Offset = "0x7E66F0", VA = "0x1807E72F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xABC920", Offset = "0xABBD20", VA = "0x180ABC920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6361F40", Offset = "0x6361340", VA = "0x186361F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float EIJMCFBIDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1004120", Offset = "0x1003520", VA = "0x181004120")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x10B7BA0", Offset = "0x10B6FA0", VA = "0x1810B7BA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x63625B0", Offset = "0x63619B0", VA = "0x1863625B0")]
	public GIPFIKBKBIO(IEnumerator<AOAPPGOKEOI> DGDJFMNDHDH, OHKGJALDDLC CNKGFJIJGPA, HBNILDMFFMM KNLNCNMIJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x63621B0", Offset = "0x63615B0", VA = "0x1863621B0")]
	public AOAPPGOKEOI KFNDFJKOBIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6362140", Offset = "0x6361540", VA = "0x186362140")]
	public bool JNMNHMFEEEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x63620F0", Offset = "0x63614F0", VA = "0x1863620F0")]
	public void JGPNGJLKHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x63624D0", Offset = "0x63618D0", VA = "0x1863624D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7F9AF0", Offset = "0x7F8EF0", VA = "0x1807F9AF0")]
	[CompilerGenerated]
	private void HPKEKDLNPON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class HBNILDMFFMM : GIMMHIBLBHM, GKKBBPDHGPP, KBDGBPHCLNK, IKPLFJCHDDD, IEnumerator, AOAPPGOKEOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private BKEELODPLGM KLMGIPDHGAO;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private BKEELODPLGM HAPPPFLJBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xCD0B60", Offset = "0xCCFF60", VA = "0x180CD0B60", Slot = "23")]
		get
		{
			return default(BKEELODPLGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BKEELODPLGM IDPEIBBPAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x11B4B60", Offset = "0x11B3F60", VA = "0x1811B4B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float AELEPDMEMMA
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A50", Offset = "0x7B5E50", VA = "0x1807B6A50", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool LEFMODODEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x63628D0", Offset = "0x6361CD0", VA = "0x1863628D0", Slot = "24")]
	private bool LBOBOJGCNDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x63628C0", Offset = "0x6361CC0", VA = "0x1863628C0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x63628F0", Offset = "0x6361CF0", VA = "0x1863628F0")]
	public HBNILDMFFMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum AELEDPEJHKJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class LGBPBMLDKLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum OEBPOPKMEIK
	{
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct EFMLBGHGCML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public BKEELODPLGM EPLGBKOAAJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public OEBPOPKMEIK BABMJOEHJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public List<GIPFIKBKBIO> ALIPPJFLDHB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly OEBPOPKMEIK[] NOBOJAINMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly BKEELODPLGM NPEICFPFAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private bool GJAALHLFHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly GIPFIKBKBIO[] KBDOIPFDGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly List<GIPFIKBKBIO> LJIDBACOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly Stack<int> KIOJHMGIBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<GIPFIKBKBIO> EMPPAFAPFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<int> CCKKHBHHDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly OPJMNLNLOII GIMGIEHBGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private bool FKCMADKNOHH;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public EFMLBGHGCML[,] MLCFIGLEAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7653E0", Offset = "0x7647E0", VA = "0x1807653E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6369300", Offset = "0x6368700", VA = "0x186369300")]
	public LGBPBMLDKLB(BKEELODPLGM IBCFCPNGPOO, OPJMNLNLOII GIMGIEHBGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x63690C0", Offset = "0x63684C0", VA = "0x1863690C0")]
	public void OGEOEJCLGBP(GIPFIKBKBIO DGDJFMNDHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6368DB0", Offset = "0x63681B0", VA = "0x186368DB0")]
	public void MEIDDBLAIEL(IList<GIPFIKBKBIO> GBHGLJEKKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x63687B0", Offset = "0x6367BB0", VA = "0x1863687B0")]
	public void IOBCODBPGGL(IList<GIPFIKBKBIO> GBHGLJEKKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x63686C0", Offset = "0x6367AC0", VA = "0x1863686C0")]
	private void HOGLJCMKIMK(GIPFIKBKBIO DGDJFMNDHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6368340", Offset = "0x6367740", VA = "0x186368340")]
	private void HBEHGPIAMAC(IList<GIPFIKBKBIO> GBHGLJEKKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6368AC0", Offset = "0x6367EC0", VA = "0x186368AC0")]
	private AELEDPEJHKJ KFMBEKNMBKH(GIPFIKBKBIO DGDJFMNDHDH)
	{
		return default(AELEDPEJHKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6368C40", Offset = "0x6368040", VA = "0x186368C40")]
	public void MCPJDCOFDHA(float HOKGCNFFPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x63684D0", Offset = "0x63678D0", VA = "0x1863684D0")]
	public void HCGJCCLDJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6367DE0", Offset = "0x63671E0", VA = "0x186367DE0")]
	private void BNBHCHOFLKJ(List<GIPFIKBKBIO> GBHGLJEKKAA, Stack<int> IOHGDEDMHLH, bool PGFDFIBDHCN, float BOBNNFBIFPO = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x63680E0", Offset = "0x63674E0", VA = "0x1863680E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6368200", Offset = "0x6367600", VA = "0x186368200")]
	private void FACKNIODDHG(List<GIPFIKBKBIO> GBHGLJEKKAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class AKBANCNJHPK : OPJMNLNLOII
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "4")]
	public void KNJNECAGCPB(string DKFEAPHKBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
	public void OBMELDICGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public AKBANCNJHPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class AHFEGHPFDFF : OHKGJALDDLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Behaviour ACIJMAHOIPB;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x63574A0", Offset = "0x63568A0", VA = "0x1863574A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool LKDFKBGEPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6357450", Offset = "0x6356850", VA = "0x186357450", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool LMBNHJJPJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6357520", Offset = "0x6356920", VA = "0x186357520", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	public AHFEGHPFDFF(Behaviour ACIJMAHOIPB)
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

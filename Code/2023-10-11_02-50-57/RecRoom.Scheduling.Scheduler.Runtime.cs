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
public class JIBHJPAIMBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority BLCICGIPDBL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6370C80", Offset = "0x636FA80", VA = "0x186370C80")]
	public JIBHJPAIMBN(ThreadPriority GJKGLKOGJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6370C70", Offset = "0x636FA70", VA = "0x186370C70", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> CGCFGFBEAAO(List<PlayerLoopSystem> DECADLJJLLJ, int IMIEHEOLEAD);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct ICJLOCAIOJN
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct JKMFHMPFIOH
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static ECJBBEDPNJE GOKMJIBBNPL;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x63718F0", Offset = "0x63706F0", VA = "0x1863718F0")]
				public static PlayerLoopSystem IMBHCAJLDFA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct CLDGLBKGJJI
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static ECJBBEDPNJE KGBKGHPENBF;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x6367060", Offset = "0x6365E60", VA = "0x186367060")]
				public static PlayerLoopSystem IMBHCAJLDFA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct KNLDLOEFOCA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static ECJBBEDPNJE COHGGENIEPD;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6374780", Offset = "0x6373580", VA = "0x186374780")]
				public static PlayerLoopSystem IMBHCAJLDFA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct EAECLIOBIDM
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static ECJBBEDPNJE KPKAFNJMLKK;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static ECJBBEDPNJE KEMPCPNPCCG;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static ECJBBEDPNJE JPOEJFPMCNM;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static ECJBBEDPNJE PNFDOPIIOEH;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x636B9F0", Offset = "0x636A7F0", VA = "0x18636B9F0")]
				public static PlayerLoopSystem IMBHCAJLDFA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct GMPEBJNIBCA
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static ECJBBEDPNJE KIDJAMLMCLF;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x636E510", Offset = "0x636D310", VA = "0x18636E510")]
				public static PlayerLoopSystem IMBHCAJLDFA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct KDCKPBKALOH
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static ECJBBEDPNJE KPKAFNJMLKK;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static ECJBBEDPNJE KEMPCPNPCCG;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static ECJBBEDPNJE JPOEJFPMCNM;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static ECJBBEDPNJE PNFDOPIIOEH;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x6371FE0", Offset = "0x6370DE0", VA = "0x186371FE0")]
				public static PlayerLoopSystem IMBHCAJLDFA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct MPIPJFPANCI
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static ECJBBEDPNJE NLGFDJIKOBK;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x6377B10", Offset = "0x6376910", VA = "0x186377B10")]
				public static PlayerLoopSystem IMBHCAJLDFA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct GBILJPJAHCP
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static ECJBBEDPNJE LMJDCGPLJPB;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x636D200", Offset = "0x636C000", VA = "0x18636D200")]
				public static PlayerLoopSystem IMBHCAJLDFA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct KMBJGIMLODE
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static ECJBBEDPNJE MBMBFHLFKDL;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6373D80", Offset = "0x6372B80", VA = "0x186373D80")]
				public static PlayerLoopSystem IMBHCAJLDFA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct CLFAJMIGFPK
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static ECJBBEDPNJE GJJKDFPLMAP;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6367260", Offset = "0x6366060", VA = "0x186367260")]
				public static PlayerLoopSystem IMBHCAJLDFA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct HHGPFLNILOP
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static ECJBBEDPNJE DPEDNPFIKMM;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x636F2E0", Offset = "0x636E0E0", VA = "0x18636F2E0")]
				public static PlayerLoopSystem IMBHCAJLDFA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct HGIEJCCLIPG
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static ECJBBEDPNJE HPJGKFHLHDM;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x636F0E0", Offset = "0x636DEE0", VA = "0x18636F0E0")]
				public static PlayerLoopSystem IMBHCAJLDFA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum EIEEKCOGGPD : byte
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
			public struct MBOHCHNFJOP
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class IADAPCCHMKB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public EIEEKCOGGPD updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
					public IADAPCCHMKB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x636F4E0", Offset = "0x636E2E0", VA = "0x18636F4E0")]
					internal void LOPDELLJMFB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static HEBNGJMIMPC<EIEEKCOGGPD> BDMBKHIDJAP;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6377940", Offset = "0x6376740", VA = "0x186377940")]
				public static PlayerLoopSystem IMBHCAJLDFA(EIEEKCOGGPD LMLJBJIJOLC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct LICNAFMIFEE
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class CEGKLNLNFNL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public PGDDFKDAOHA.HCOFHCIIFOG key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
					public CEGKLNLNFNL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6366CD0", Offset = "0x6365AD0", VA = "0x186366CD0")]
					internal void AAOJPJCPBEJ()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable KBEDEFHCKNP;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x6374E60", Offset = "0x6373C60", VA = "0x186374E60")]
				public static PlayerLoopSystem CNEKPPFCPEB(PGDDFKDAOHA.HCOFHCIIFOG JLDFGFPAIIN)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct AMNBNNDDOLP
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class BGHOABEEGPK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public PGDDFKDAOHA.HCOFHCIIFOG key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
					public BGHOABEEGPK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x6366590", Offset = "0x6365390", VA = "0x186366590")]
					internal void AAOJPJCPBEJ()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x63653E0", Offset = "0x63641E0", VA = "0x1863653E0")]
				public static PlayerLoopSystem CNEKPPFCPEB(PGDDFKDAOHA.HCOFHCIIFOG JLDFGFPAIIN)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class IPJIKMMIPMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public IPJIKMMIPMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x636F6E0", Offset = "0x636E4E0", VA = "0x18636F6E0")]
			internal List<PlayerLoopSystem> MBJMNLDJHCM(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool CPDFNJJNIGI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool CNFIJOBBBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x636A370", Offset = "0x6369170", VA = "0x18636A370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6367A40", Offset = "0x6366840", VA = "0x186367A40")]
		private static void DNDLOECKIAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x636A4E0", Offset = "0x63692E0", VA = "0x18636A4E0")]
		private static void GFEIPCHBIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6367810", Offset = "0x6366610", VA = "0x186367810")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x636B190", Offset = "0x6369F90", VA = "0x18636B190")]
		private static void LGBDCPFEJGB(PGDDFKDAOHA.HCOFHCIIFOG JLDFGFPAIIN, PlayerLoopSystem HPIGKBCBIDG, Type LBBOBHLMNNF, Type EOHAJNIJDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x636ADB0", Offset = "0x6369BB0", VA = "0x18636ADB0")]
		private static void HELGODJIKCA(PlayerLoopSystem HPIGKBCBIDG, Type LBBOBHLMNNF, Type EOHAJNIJDBO, CGCFGFBEAAO LFMLNEPHKIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x636A3B0", Offset = "0x63691B0", VA = "0x18636A3B0")]
		private static void FKNLLJPJLHC(PlayerLoopSystem HPIGKBCBIDG, Type LBBOBHLMNNF, Type EOHAJNIJDBO, PlayerLoopSystem? GPEDBIDBFFE, PlayerLoopSystem? BOKEKHHLAIM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PGDDFKDAOHA
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum HCOFHCIIFOG
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
	public class GFFNBAALIBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly HCOFHCIIFOG NNNECIADMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly OLPDLIJAFKG AJAGLOENLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long KOFMEHMODBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long GHLIDEKDLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long CFAPIBGCFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int IOAFLKDBCLC;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x636E400", Offset = "0x636D200", VA = "0x18636E400")]
		public GFFNBAALIBA(HCOFHCIIFOG OLICEMCHFEL, int LJOMKGNABIO = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x636E160", Offset = "0x636CF60", VA = "0x18636E160")]
		public void IPNLJOAKFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x636E1D0", Offset = "0x636CFD0", VA = "0x18636E1D0")]
		public void JHEBMMJDMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x636E220", Offset = "0x636D020", VA = "0x18636E220")]
		public void PANJHPKLLLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static HCOFHCIIFOG[] LIDIAFIGIKD;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static GFFNBAALIBA[] CEMOFPJGGMM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6379F10", Offset = "0x6378D10", VA = "0x186379F10")]
	public static GFFNBAALIBA DAPOBGAAPMG(HCOFHCIIFOG JLDFGFPAIIN, int LJOMKGNABIO = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6379EA0", Offset = "0x6378CA0", VA = "0x186379EA0")]
	public static GFFNBAALIBA BEDENILKBII(HCOFHCIIFOG JLDFGFPAIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x637A0F0", Offset = "0x6378EF0", VA = "0x18637A0F0")]
	public static void DOOJIJBAHKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OLPDLIJAFKG : HLLOOJFGKKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int JPNAKAFOBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> CIKFCJEMPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double GBOBLEMPFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double COGFLCBHIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double CCLDHADCKDN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double KKEPFIPDPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6379AC0", Offset = "0x63788C0", VA = "0x186379AC0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double GPBHKALFDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x160FEA0", Offset = "0x160ECA0", VA = "0x18160FEA0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double FLFMLCNMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1BFC3B0", Offset = "0x1BFB1B0", VA = "0x181BFC3B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6379C40", Offset = "0x6378A40", VA = "0x186379C40")]
	public OLPDLIJAFKG(int AAFGFBMDFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6379B20", Offset = "0x6378920", VA = "0x186379B20", Slot = "7")]
	public void HKLNJEIECMG(double AACJDNHHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6379A50", Offset = "0x6378850", VA = "0x186379A50", Slot = "8")]
	public void AOMGIBAKPFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LNHKJEFDNJP : HLLOOJFGKKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long HLFCMANHPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double MENNGLKBOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double LFAALEJDCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double CHGEHOPAFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double KAAOCHGBLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double GBOBLEMPFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double COGFLCBHIIG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double GPBHKALFDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x538EB10", Offset = "0x538D910", VA = "0x18538EB10", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double FLFMLCNMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x538EFD0", Offset = "0x538DDD0", VA = "0x18538EFD0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double DBPBOFLGNCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x538EAF0", Offset = "0x538D8F0", VA = "0x18538EAF0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double KKEPFIPDPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6580", Offset = "0x1FB5380", VA = "0x181FB6580", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6376990", Offset = "0x6375790", VA = "0x186376990", Slot = "7")]
	public virtual void HKLNJEIECMG(double AACJDNHHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6376950", Offset = "0x6375750", VA = "0x186376950", Slot = "8")]
	public virtual void AOMGIBAKPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6370C00", Offset = "0x636FA00", VA = "0x186370C00")]
	public LNHKJEFDNJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JFONGONELML : LNHKJEFDNJP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double NPAJCFADELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x538EB20", Offset = "0x538D920", VA = "0x18538EB20")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x538EB40", Offset = "0x538D940", VA = "0x18538EB40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6370AD0", Offset = "0x636F8D0", VA = "0x186370AD0", Slot = "7")]
	public override void HKLNJEIECMG(double AACJDNHHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6370A90", Offset = "0x636F890", VA = "0x186370A90", Slot = "8")]
	public override void AOMGIBAKPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6370C00", Offset = "0x636FA00", VA = "0x186370C00")]
	public JFONGONELML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface HLLOOJFGKKP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double KKEPFIPDPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double GPBHKALFDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double FLFMLCNMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class KNFIDLENBOD
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface MAAIJHGAOIF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool KKEEDHHHBDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ENKNHBEMBCD();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class OLILBEAOEGA<TPromise, TMainThreadPromise> : MAAIJHGAOIF where TPromise : KKKGKPAKNDP where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise KBBEPBKIIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise ONIDLBGINPL;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise ADICLOLHGHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3D2F3F0", Offset = "0x3D2E1F0", VA = "0x183D2F3F0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KKEEDHHHBDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3D2F3A0", Offset = "0x3D2E1A0", VA = "0x183D2F3A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76A6C0", Offset = "0x7694C0", VA = "0x18076A6C0")]
		protected OLILBEAOEGA(TPromise KBBEPBKIIBH, TMainThreadPromise PLHLKCJLKEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F380", Offset = "0x3D2E180", VA = "0x183D2F380", Slot = "5")]
		public void ENKNHBEMBCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void HGEHNCAHIPD(TPromise KBBEPBKIIBH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class GMOEHIADNLK<T> : OLILBEAOEGA<BOOMHLJDOCA<T>, HAHMAHGOHIO<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x34D6990", Offset = "0x34D5790", VA = "0x1834D6990")]
		public GMOEHIADNLK(BOOMHLJDOCA<T> KBBEPBKIIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x34D6750", Offset = "0x34D5550", VA = "0x1834D6750", Slot = "6")]
		protected override void HGEHNCAHIPD(BOOMHLJDOCA<T> KBBEPBKIIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x301C160", Offset = "0x301AF60", VA = "0x18301C160")]
		[CompilerGenerated]
		private void MGOKFGOAADK(T EKOLPKLNMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x34D6960", Offset = "0x34D5760", VA = "0x1834D6960")]
		[CompilerGenerated]
		private void NAIJHODBGII(string OGJCCLJIEPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class JGLHPNPIKHA : MAAIJHGAOIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action HMHDIIODGFG;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool KKEEDHHHBDD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
		public JGLHPNPIKHA(Action HMHDIIODGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xADB470", Offset = "0xADA270", VA = "0x180ADB470", Slot = "5")]
		public void ENKNHBEMBCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<MAAIJHGAOIF> FKHLIIPPCJO;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2401BB0", Offset = "0x24009B0", VA = "0x182401BB0")]
	public static BOOMHLJDOCA<T> HCJBONPNFOJ<T>(this BOOMHLJDOCA<T> KBBEPBKIIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6374650", Offset = "0x6373450", VA = "0x186374650")]
	public static void HCJBONPNFOJ(Action HMHDIIODGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2401AF0", Offset = "0x24008F0", VA = "0x182401AF0")]
	private static BOOMHLJDOCA<T> CJNFNCPBMEP<T>(BOOMHLJDOCA<T> KBBEPBKIIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6374060", Offset = "0x6372E60", VA = "0x186374060")]
	private static void FNKICGJKMMI(MAAIJHGAOIF OMMGHFAMGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6374370", Offset = "0x6373170", VA = "0x186374370")]
	private static void HACHODCPBOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6374270", Offset = "0x6373070", VA = "0x186374270")]
	private static void GPILKKEOCIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6373F80", Offset = "0x6372D80", VA = "0x186373F80")]
	private static void EMINOKCOMMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class KKEIOJAHJPN
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct KIBLHKFGHDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> AHPPNLJEMED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string EPCCHKDEDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode DFFGMPJIBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool KLHIAFKDFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x63722D0", Offset = "0x63710D0", VA = "0x1863722D0")]
		public KIBLHKFGHDE(TaskCompletionSource<Scene> HBJHKLELGAL, string EPCCHKDEDAA, LoadSceneMode DFFGMPJIBAD, bool KLHIAFKDFBA, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct AICGAECJKFG : IAsyncStateMachine
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
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private EIIPDELDDBE<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x63644E0", Offset = "0x63632E0", VA = "0x1863644E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6364D80", Offset = "0x6363B80", VA = "0x186364D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct KBKILNPMFAD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6371C60", Offset = "0x6370A60", VA = "0x186371C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6371F80", Offset = "0x6370D80", VA = "0x186371F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct PLKILJMGAID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private KIBLHKFGHDE <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x637A330", Offset = "0x6379130", VA = "0x18637A330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x637A6E0", Offset = "0x63794E0", VA = "0x18637A6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GDKANJMABEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public HAHMAHGOHIO<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public GDKANJMABEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x636E100", Offset = "0x636CF00", VA = "0x18636E100")]
		internal void MLAOHCCKMEG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct AFGCEAJMBPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

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
		private GDKANJMABEB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6360F20", Offset = "0x635FD20", VA = "0x186360F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6361AC0", Offset = "0x63608C0", VA = "0x186361AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct GCEICNFMEMI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x636D400", Offset = "0x636C200", VA = "0x18636D400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x636D910", Offset = "0x636C710", VA = "0x18636D910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct NKGDJDECJEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x63785A0", Offset = "0x63773A0", VA = "0x1863785A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x63790F0", Offset = "0x6377EF0", VA = "0x1863790F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class DMJCIINHLNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public DMJCIINHLNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x636B9C0", Offset = "0x636A7C0", VA = "0x18636B9C0")]
		internal bool OOCJNEAMCMG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class LPMPAOJNJEA : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public PFGLJDAMMPM onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public LPMPAOJNJEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6376E90", Offset = "0x6375C90", VA = "0x186376E90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6376B00", Offset = "0x6375900", VA = "0x186376B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6376AB0", Offset = "0x63758B0", VA = "0x186376AB0")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6376E40", Offset = "0x6375C40", VA = "0x186376E40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class PPGBNBPDJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public HAHMAHGOHIO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public PPGBNBPDJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x637BDF0", Offset = "0x637ABF0", VA = "0x18637BDF0")]
		internal bool LNICCGMCEEO(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x637BB70", Offset = "0x637A970", VA = "0x18637BB70")]
		internal void EIDPHCNIEAF(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class ECPLHBDBJDI : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HAHMAHGOHIO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private PPGBNBPDJNA <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public ECPLHBDBJDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x636C860", Offset = "0x636B660", VA = "0x18636C860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x636CF70", Offset = "0x636BD70", VA = "0x18636CF70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> KHEJKNGAODM;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static KKKGKPAKNDP PEAHCECIFFG;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation JNIICPNIILO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static KKKGKPAKNDP CJMCILAAOFG;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string CENFAOHPEIB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority AACHNHCDKMO;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task CMLEFJLFDKE;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> NHNCCNAPEMN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<KIBLHKFGHDE> NAMDFIMBJAN;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task NKDMIKEPKIE;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool DDCIJBEFOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6373720", Offset = "0x6372520", VA = "0x186373720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool BFMIGCIJIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6373280", Offset = "0x6372080", VA = "0x186373280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool GGAKBIJPNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6372D70", Offset = "0x6371B70", VA = "0x186372D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool JACIJAJLFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6372680", Offset = "0x6371480", VA = "0x186372680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> AKMICOFLJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6372820", Offset = "0x6371620", VA = "0x186372820")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6372710", Offset = "0x6371510", VA = "0x186372710")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6373940", Offset = "0x6372740", VA = "0x186373940")]
	[LOBGHKGANIF(NHPGDCIEJKL.EnteredEditModeNextFrame, 0)]
	private static void PLJGENLIDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6372B70", Offset = "0x6371970", VA = "0x186372B70")]
	[AsyncStateMachine(typeof(AICGAECJKFG))]
	public static Task<Scene> ICOAKFLMNDH(string EPCCHKDEDAA, LoadSceneMode DFFGMPJIBAD = LoadSceneMode.Single, bool KLHIAFKDFBA = false, [Optional] EIIPDELDDBE<string>.OABKDIIPOLN NAPKPCKADJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6372CC0", Offset = "0x6371AC0", VA = "0x186372CC0")]
	[AsyncStateMachine(typeof(KBKILNPMFAD))]
	private static Task IIHCPLDCDAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x63731B0", Offset = "0x6371FB0", VA = "0x1863731B0")]
	[AsyncStateMachine(typeof(PLKILJMGAID))]
	private static Task KKGDDDHLLMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6373A40", Offset = "0x6372840", VA = "0x186373A40")]
	[AsyncStateMachine(typeof(AFGCEAJMBPL))]
	private static Task<Scene> PLPDHODGGDL(string EPCCHKDEDAA, LoadSceneMode DFFGMPJIBAD, bool KLHIAFKDFBA, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6372ED0", Offset = "0x6371CD0", VA = "0x186372ED0")]
	private static void JCPNBCPDPAK(SceneInstance JGOGHBIKMPG, LoadSceneMode DFFGMPJIBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6372E10", Offset = "0x6371C10", VA = "0x186372E10")]
	private static void JCMJBHKHIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6372560", Offset = "0x6371360", VA = "0x186372560")]
	[AsyncStateMachine(typeof(GCEICNFMEMI))]
	private static Task<Scene> CADFAILOPBL(string EPCCHKDEDAA, LoadSceneMode DFFGMPJIBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6372470", Offset = "0x6371270", VA = "0x186372470")]
	private static bool BIOJANDPAMA(string EPCCHKDEDAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6372A60", Offset = "0x6371860", VA = "0x186372A60")]
	[AsyncStateMachine(typeof(NKGDJDECJEK))]
	private static Task<Scene> HBEKLBPMJKN(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6373030", Offset = "0x6371E30", VA = "0x186373030")]
	public static BOOMHLJDOCA<Scene> KADMKMHKIIP(string EPCCHKDEDAA, LoadSceneMode DFFGMPJIBAD = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6373450", Offset = "0x6372250", VA = "0x186373450")]
	public static KKKGKPAKNDP OCHBJIKNIEH(string EPCCHKDEDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6373320", Offset = "0x6372120", VA = "0x186373320")]
	[IteratorStateMachine(typeof(LPMPAOJNJEA))]
	private static IEnumerator<CCMEGKBIKJP> MDPBKKJBIAM(string EPCCHKDEDAA, PFGLJDAMMPM OGLCEKFANMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x63733B0", Offset = "0x63721B0", VA = "0x1863733B0")]
	[IteratorStateMachine(typeof(ECPLHBDBJDI))]
	private static IEnumerator<CCMEGKBIKJP> NINLECLBCJJ(string EPCCHKDEDAA, LoadSceneMode DFFGMPJIBAD, HAHMAHGOHIO<Scene> OGLCEKFANMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6372930", Offset = "0x6371730", VA = "0x186372930")]
	public static bool GIOKCPDLOEG([Out] string CEDIJCMELMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GAANJBGHLGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x636D070", Offset = "0x636BE70", VA = "0x18636D070")]
	public static IDisposable KBOGJNPIFKL(this GECCANDAKGE GMNCNEPJHHN, float IFPAEJGCKJD, Action<float> EEMIJKOCPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x636D100", Offset = "0x636BF00", VA = "0x18636D100")]
	public static IDisposable LKGBIFMBJOC(this GECCANDAKGE GMNCNEPJHHN, Action<float> EEMIJKOCPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x636D180", Offset = "0x636BF80", VA = "0x18636D180")]
	public static IDisposable PGCCKDKDOGI(this GECCANDAKGE GMNCNEPJHHN, Action<float> EEMIJKOCPIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class ANBIMGEDCLO
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6365620", Offset = "0x6364420", VA = "0x186365620")]
	public static IDisposable BEEPFCMOJHC(this MonoBehaviour OLPNFBGADIK, Action EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6365590", Offset = "0x6364390", VA = "0x186365590")]
	public static IDisposable BEEPFCMOJHC(this MonoBehaviour OLPNFBGADIK, Action<float> EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6365FB0", Offset = "0x6364DB0", VA = "0x186365FB0")]
	public static IDisposable PFMOOMMEHLD(this MonoBehaviour OLPNFBGADIK, Action EEMIJKOCPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6365510", Offset = "0x6364310", VA = "0x186365510")]
	public static IDisposable AAFGKGBKHHD(this MonoBehaviour OLPNFBGADIK, Action EEMIJKOCPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6365A30", Offset = "0x6364830", VA = "0x186365A30")]
	public static IDisposable GOBODFCNJGI(this MonoBehaviour OLPNFBGADIK, Action EEMIJKOCPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6365AB0", Offset = "0x63648B0", VA = "0x186365AB0")]
	public static IDisposable HPGEIJOCMFN(this MonoBehaviour OLPNFBGADIK, Action EEMIJKOCPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x63656B0", Offset = "0x63644B0", VA = "0x1863656B0")]
	public static IDisposable BJCNGFIFHEO(this MonoBehaviour OLPNFBGADIK, Action EEMIJKOCPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6365C80", Offset = "0x6364A80", VA = "0x186365C80")]
	public static IDisposable MCIOJAFCDEI(this MonoBehaviour OLPNFBGADIK, float IFPAEJGCKJD, Action<float> EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE, bool JHGNNOGNEPL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6365910", Offset = "0x6364710", VA = "0x186365910")]
	public static IDisposable EBPFPBFBLPP(this MonoBehaviour OLPNFBGADIK, float IFPAEJGCKJD, Action<float> EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE, bool JHGNNOGNEPL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6365730", Offset = "0x6364530", VA = "0x186365730")]
	public static IDisposable BOLLLCABDDN(this MonoBehaviour OLPNFBGADIK, float IFPAEJGCKJD, Action<float> EEMIJKOCPIJ, bool JHGNNOGNEPL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6365E70", Offset = "0x6364C70", VA = "0x186365E70")]
	public static IDisposable OGFOMHCIBGG(this MonoBehaviour OLPNFBGADIK, Action<float> EEMIJKOCPIJ, bool JHGNNOGNEPL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6365B30", Offset = "0x6364930", VA = "0x186365B30")]
	public static IDisposable JKECIPEANLG(this MonoBehaviour OLPNFBGADIK, Action<float> EEMIJKOCPIJ, bool JHGNNOGNEPL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6365F10", Offset = "0x6364D10", VA = "0x186365F10")]
	public static IDisposable PAMEEALMCEO(this MonoBehaviour OLPNFBGADIK, Action<float> EEMIJKOCPIJ, bool JHGNNOGNEPL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6365DD0", Offset = "0x6364BD0", VA = "0x186365DD0")]
	public static IDisposable OFNJGKBJDJK(this MonoBehaviour OLPNFBGADIK, Action<float> EEMIJKOCPIJ, bool JHGNNOGNEPL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6365870", Offset = "0x6364670", VA = "0x186365870")]
	public static IDisposable EBLDCCAMOGP(this MonoBehaviour OLPNFBGADIK, Action<float> EEMIJKOCPIJ, bool JHGNNOGNEPL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x63657D0", Offset = "0x63645D0", VA = "0x1863657D0")]
	public static IDisposable DHKLBIFGHHI(this MonoBehaviour OLPNFBGADIK, Action<float> EEMIJKOCPIJ, bool JHGNNOGNEPL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6365D30", Offset = "0x6364B30", VA = "0x186365D30")]
	public static IDisposable NOLIDAJNFHB(this MonoBehaviour OLPNFBGADIK, Action<float> EEMIJKOCPIJ, bool JHGNNOGNEPL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6365BD0", Offset = "0x63649D0", VA = "0x186365BD0")]
	public static IDisposable LHIJAMEPBHP(this MonoBehaviour OLPNFBGADIK, float IFPAEJGCKJD, Action<float> EEMIJKOCPIJ, bool JHGNNOGNEPL = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CONJNEBHFDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class NOMEMMJJPIM : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public MIJAHBFLJPH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private GMDHIBKFNGF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public NOMEMMJJPIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6379810", Offset = "0x6378610", VA = "0x186379810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x63798F0", Offset = "0x63786F0", VA = "0x1863798F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class IOFCNBEFBDP : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public MIJAHBFLJPH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private GMDHIBKFNGF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public IOFCNBEFBDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x636F5A0", Offset = "0x636E3A0", VA = "0x18636F5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x636F690", Offset = "0x636E490", VA = "0x18636F690", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x63676A0", Offset = "0x63664A0", VA = "0x1863676A0")]
	public static FFHNDEGIGAM BEEPFCMOJHC(Action EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6367750", Offset = "0x6366550", VA = "0x186367750")]
	public static FFHNDEGIGAM BEEPFCMOJHC(Behaviour GMNCNEPJHHN, Action EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6367580", Offset = "0x6366380", VA = "0x186367580")]
	public static FFHNDEGIGAM BEEPFCMOJHC(Behaviour GMNCNEPJHHN, Action<float> EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6367460", Offset = "0x6366260", VA = "0x186367460")]
	[IteratorStateMachine(typeof(NOMEMMJJPIM))]
	private static IEnumerator<CCMEGKBIKJP> BALBHBGGEAC(MIJAHBFLJPH MKEMCEBLCJD, Action EEMIJKOCPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x63674F0", Offset = "0x63662F0", VA = "0x1863674F0")]
	[IteratorStateMachine(typeof(IOFCNBEFBDP))]
	private static IEnumerator<CCMEGKBIKJP> BALBHBGGEAC(MIJAHBFLJPH MKEMCEBLCJD, Action<float> EEMIJKOCPIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class ECFHMMDAPOO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class DFPDDFEPEOC : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public ECFHMMDAPOO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public DFPDDFEPEOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x636B8E0", Offset = "0x636A6E0", VA = "0x18636B8E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x636B970", Offset = "0x636A770", VA = "0x18636B970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly MIJAHBFLJPH LIPJGLJHEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action EOHHKEDCJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool AIDJHFOFHBC;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LCMEEIPDKPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x76B180", Offset = "0x769F80", VA = "0x18076B180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x636BE00", Offset = "0x636AC00", VA = "0x18636BE00")]
	public ECFHMMDAPOO(MIJAHBFLJPH LIPJGLJHEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x636BCE0", Offset = "0x636AAE0", VA = "0x18636BCE0")]
	[IteratorStateMachine(typeof(DFPDDFEPEOC))]
	private IEnumerator<CCMEGKBIKJP> JGGAOHKIBNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x636BD60", Offset = "0x636AB60", VA = "0x18636BD60", Slot = "4")]
	public void OnCompleted(Action AKAOLLINCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	public void MOEHNFAAKKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class KJCOPJBEKOK
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6372330", Offset = "0x6371130", VA = "0x186372330")]
	public static ECFHMMDAPOO EBBCBJPMOFL(this MIJAHBFLJPH LIPJGLJHEFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class AIOEAICCILB
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class HDPDLIBNJHK : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public GHBDMAOELDE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public HDPDLIBNJHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x636E8A0", Offset = "0x636D6A0", VA = "0x18636E8A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x636E920", Offset = "0x636D720", VA = "0x18636E920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6364FC0", Offset = "0x6363DC0", VA = "0x186364FC0")]
	public static FFHNDEGIGAM BEEPFCMOJHC(float IFPAEJGCKJD, Action<float> EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE, bool JHGNNOGNEPL = true, [Optional] KLFFABBGDHC HOEEDMFCBGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6364EB0", Offset = "0x6363CB0", VA = "0x186364EB0")]
	public static FFHNDEGIGAM BEEPFCMOJHC(MonoBehaviour OLPNFBGADIK, float IFPAEJGCKJD, Action<float> EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE, bool JHGNNOGNEPL = true, [Optional] KLFFABBGDHC HOEEDMFCBGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6365120", Offset = "0x6363F20", VA = "0x186365120")]
	public static FFHNDEGIGAM IPMDALEAFJJ(MonoBehaviour OLPNFBGADIK, float IFPAEJGCKJD, Action<float> EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE, bool JHGNNOGNEPL = true, [Optional] KLFFABBGDHC HOEEDMFCBGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6365240", Offset = "0x6364040", VA = "0x186365240")]
	public static FFHNDEGIGAM KFMFHCKBACG(GECCANDAKGE GMNCNEPJHHN, float IFPAEJGCKJD, Action<float> EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE, bool JHGNNOGNEPL = true, [Optional] KLFFABBGDHC HOEEDMFCBGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6364DF0", Offset = "0x6363BF0", VA = "0x186364DF0")]
	private static IEnumerator<CCMEGKBIKJP> BALBHBGGEAC(OPGHEHENADM PFKMAJGEAHD, float IFPAEJGCKJD, MIJAHBFLJPH MKEMCEBLCJD, Action<float> EEMIJKOCPIJ, bool JHGNNOGNEPL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x63650C0", Offset = "0x6363EC0", VA = "0x1863650C0")]
	private static IEnumerator<CCMEGKBIKJP> INBFENAIFFJ(OPGHEHENADM PFKMAJGEAHD, float IFPAEJGCKJD, MIJAHBFLJPH MKEMCEBLCJD, Action<float> EEMIJKOCPIJ, bool JHGNNOGNEPL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6365350", Offset = "0x6364150", VA = "0x186365350")]
	[IteratorStateMachine(typeof(HDPDLIBNJHK))]
	private static IEnumerator<CCMEGKBIKJP> OMNNJECOJDG(GHBDMAOELDE DNDNNAAGMEL, float IFPAEJGCKJD, MIJAHBFLJPH MKEMCEBLCJD, Action<float> EEMIJKOCPIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class OOEBEHHFFLP
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class OEGEMOJHNOB : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public MIJAHBFLJPH queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public OEGEMOJHNOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6379940", Offset = "0x6378740", VA = "0x186379940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6379A00", Offset = "0x6378800", VA = "0x186379A00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6379CF0", Offset = "0x6378AF0", VA = "0x186379CF0")]
	[IteratorStateMachine(typeof(OEGEMOJHNOB))]
	private static IEnumerator<CCMEGKBIKJP> CHCCPOGJDFA(MIJAHBFLJPH LIPJGLJHEFE, Func<bool> NDIKNGPKKGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6379D80", Offset = "0x6378B80", VA = "0x186379D80")]
	public static FFHNDEGIGAM DEGPKPPDIOG(this MonoBehaviour OLPNFBGADIK, Func<bool> NDIKNGPKKGH, MIJAHBFLJPH LIPJGLJHEFE = MIJAHBFLJPH.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LPPHHBMKILP
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class LCEPAJNCNID : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public MIJAHBFLJPH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public LCEPAJNCNID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6374980", Offset = "0x6373780", VA = "0x186374980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x63749F0", Offset = "0x63737F0", VA = "0x1863749F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class NGKLBLFHEFA : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public MIJAHBFLJPH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private CCMEGKBIKJP <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public NGKLBLFHEFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x63784C0", Offset = "0x63772C0", VA = "0x1863784C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6378550", Offset = "0x6377350", VA = "0x186378550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x63776C0", Offset = "0x63764C0", VA = "0x1863776C0")]
	[IteratorStateMachine(typeof(LCEPAJNCNID))]
	private static IEnumerator<CCMEGKBIKJP> JGGAOHKIBNA(float MILPBPEIAGI, MIJAHBFLJPH MKEMCEBLCJD, Action BCIFBAGGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6377320", Offset = "0x6376120", VA = "0x186377320")]
	[IteratorStateMachine(typeof(NGKLBLFHEFA))]
	private static IEnumerator<CCMEGKBIKJP> DMCAEGEOANE(float MILPBPEIAGI, MIJAHBFLJPH MKEMCEBLCJD, Action BCIFBAGGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x63770B0", Offset = "0x6375EB0", VA = "0x1863770B0")]
	public static IDisposable BLPDBMNBJLK(this MonoBehaviour OLPNFBGADIK, float MILPBPEIAGI, Action BCIFBAGGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6376F20", Offset = "0x6375D20", VA = "0x186376F20")]
	public static FFHNDEGIGAM AGOLPIILONJ(this MonoBehaviour OLPNFBGADIK, float MILPBPEIAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x63771D0", Offset = "0x6375FD0", VA = "0x1863771D0")]
	public static FFHNDEGIGAM BLPDBMNBJLK(this MonoBehaviour OLPNFBGADIK, float MILPBPEIAGI, MIJAHBFLJPH MKEMCEBLCJD, Action BCIFBAGGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6377300", Offset = "0x6376100", VA = "0x186377300")]
	public static FFHNDEGIGAM BOGPMBKDHNA(this MonoBehaviour OLPNFBGADIK, Action BCIFBAGGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x63774F0", Offset = "0x63762F0", VA = "0x1863774F0")]
	public static FFHNDEGIGAM HBBCGCNLGGI(this MonoBehaviour OLPNFBGADIK, Action BCIFBAGGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6377760", Offset = "0x6376560", VA = "0x186377760")]
	public static FFHNDEGIGAM KFHDMIPOOAD(this MonoBehaviour OLPNFBGADIK, Action BCIFBAGGNNA, [Optional] KLFFABBGDHC HOEEDMFCBGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6377840", Offset = "0x6376640", VA = "0x186377840")]
	public static FFHNDEGIGAM KMFMCBBMLGJ(this MonoBehaviour OLPNFBGADIK, Action BCIFBAGGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x63774C0", Offset = "0x63762C0", VA = "0x1863774C0")]
	public static FFHNDEGIGAM FHFDNJBDKOD(this MonoBehaviour OLPNFBGADIK, Action BCIFBAGGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6377490", Offset = "0x6376290", VA = "0x186377490")]
	public static FFHNDEGIGAM EMEDEIAJHOC(this MonoBehaviour OLPNFBGADIK, Action BCIFBAGGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x63773C0", Offset = "0x63761C0", VA = "0x1863773C0")]
	private static FFHNDEGIGAM EIPIIBDDFKB(MonoBehaviour OLPNFBGADIK, MIJAHBFLJPH LIPJGLJHEFE, Action BCIFBAGGNNA, [Optional] KLFFABBGDHC HOEEDMFCBGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6377870", Offset = "0x6376670", VA = "0x186377870")]
	public static FFHNDEGIGAM PJDDDBGDGCF(this MonoBehaviour OLPNFBGADIK, float IPNHLKNPDIF, Action BCIFBAGGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x63775F0", Offset = "0x63763F0", VA = "0x1863775F0")]
	public static FFHNDEGIGAM IPEIJJKHPPA(this MonoBehaviour OLPNFBGADIK, float IPNHLKNPDIF, Action BCIFBAGGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6377520", Offset = "0x6376320", VA = "0x186377520")]
	public static FFHNDEGIGAM HCBGADJODFG(this MonoBehaviour OLPNFBGADIK, float IPNHLKNPDIF, Action BCIFBAGGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6376FE0", Offset = "0x6375DE0", VA = "0x186376FE0")]
	public static FFHNDEGIGAM AMFJPPEBDKG(this MonoBehaviour OLPNFBGADIK, float IPNHLKNPDIF, Action BCIFBAGGNNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class ECKECOKPOEF : MFOHNDAKBMC, IEnumerable<MFOHNDAKBMC>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<MFOHNDAKBMC> OIHAHHCHKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool EPLEAMAPCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action MECOKFDCOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool GGGKFBKCBHG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LOKNJIJKBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x636C680", Offset = "0x636B480", VA = "0x18636C680", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EJIKLOOKPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x636C3E0", Offset = "0x636B1E0", VA = "0x18636C3E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x636C480", Offset = "0x636B280", VA = "0x18636C480", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x636C7C0", Offset = "0x636B5C0", VA = "0x18636C7C0")]
	public ECKECOKPOEF([Optional] Action MECOKFDCOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x636BF10", Offset = "0x636AD10", VA = "0x18636BF10")]
	public void AAFNAGDLNDC(MFOHNDAKBMC DKPLCNHOKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x636C520", Offset = "0x636B320", VA = "0x18636C520")]
	private void MMHAOMFCNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x636C350", Offset = "0x636B150", VA = "0x18636C350", Slot = "7")]
	public bool FMHFFBPMNFH(bool PJCPHDDKADF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x636C040", Offset = "0x636AE40", VA = "0x18636C040", Slot = "8")]
	public bool FMHFFBPMNFH(Action HMHDIIODGFG, bool PJCPHDDKADF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x636C360", Offset = "0x636B160", VA = "0x18636C360", Slot = "9")]
	public IEnumerator<MFOHNDAKBMC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x636C360", Offset = "0x636B160", VA = "0x18636C360", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BMGCPOHHPPA : NKJJICBMALC
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CKEDKFDCHAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public BMGCPOHHPPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public CKEDKFDCHAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6367030", Offset = "0x6365E30", VA = "0x186367030")]
		internal void KLELECAKPPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class OPEBCPADKKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public BMGCPOHHPPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public OPEBCPADKKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6367030", Offset = "0x6365E30", VA = "0x186367030")]
		internal void FNKHACPGGKD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float PNCEHCHGKHA;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6366AA0", Offset = "0x63658A0", VA = "0x186366AA0")]
	public BMGCPOHHPPA(Behaviour GMNCNEPJHHN, float PNCEHCHGKHA, [Optional] Action MECOKFDCOHP, [Optional] KLFFABBGDHC HOEEDMFCBGA, [Optional] OPGHEHENADM PFKMAJGEAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6366880", Offset = "0x6365680", VA = "0x186366880", Slot = "9")]
	protected override bool MFCOLNNNGCI(Action HMHDIIODGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6366990", Offset = "0x6365790", VA = "0x186366990", Slot = "10")]
	protected override bool NIGFOPNCMBP(Action HMHDIIODGFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface MFOHNDAKBMC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool LOKNJIJKBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action EJIKLOOKPCL;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FMHFFBPMNFH(bool PJCPHDDKADF = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FMHFFBPMNFH(Action HMHDIIODGFG, bool PJCPHDDKADF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class NKJJICBMALC : MFOHNDAKBMC
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CFCKDNMIADI : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NKJJICBMALC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public CFCKDNMIADI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6366F10", Offset = "0x6365D10", VA = "0x186366F10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6366FE0", Offset = "0x6365DE0", VA = "0x186366FE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour GMNCNEPJHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action MECOKFDCOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private BJEHAIIHJME PDMPBJIFFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly KLFFABBGDHC HOEEDMFCBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly OPGHEHENADM PFKMAJGEAHD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LOKNJIJKBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xDE0280", Offset = "0xDDF080", VA = "0x180DE0280", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action EJIKLOOKPCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6379480", Offset = "0x6378280", VA = "0x186379480", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6379520", Offset = "0x6378320", VA = "0x186379520", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6379710", Offset = "0x6378510", VA = "0x186379710")]
	protected NKJJICBMALC(Behaviour GMNCNEPJHHN, [Optional] Action MECOKFDCOHP, [Optional] KLFFABBGDHC HOEEDMFCBGA, [Optional] OPGHEHENADM PFKMAJGEAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x63791E0", Offset = "0x6377FE0", VA = "0x1863791E0", Slot = "7")]
	public bool FMHFFBPMNFH(bool PJCPHDDKADF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6379180", Offset = "0x6377F80", VA = "0x186379180", Slot = "8")]
	public bool FMHFFBPMNFH(Action HMHDIIODGFG, bool PJCPHDDKADF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool MFCOLNNNGCI(Action HMHDIIODGFG);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NIGFOPNCMBP(Action HMHDIIODGFG);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6379160", Offset = "0x6377F60", VA = "0x186379160")]
	protected void DFMCEIICOPN(Action HMHDIIODGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6379240", Offset = "0x6378040", VA = "0x186379240")]
	protected KKKGKPAKNDP JMOJDDCNDGM(float IBPBGABDEAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6379690", Offset = "0x6378490", VA = "0x186379690")]
	private void OFJFGLMGEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x63795C0", Offset = "0x63783C0", VA = "0x1863795C0")]
	[IteratorStateMachine(typeof(CFCKDNMIADI))]
	private IEnumerator<CCMEGKBIKJP> LJOGNFPCBKK(float IBPBGABDEAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6379650", Offset = "0x6378450", VA = "0x186379650")]
	[CompilerGenerated]
	private void NCDBCLCEDPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class LGGEIAAEDKH : NKJJICBMALC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float KIIDCEFEAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int HNJHAHILDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float MNKNPCHHGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] CNIJAAEEDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int CABJPBPCBFI;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6374CC0", Offset = "0x6373AC0", VA = "0x186374CC0")]
	public LGGEIAAEDKH(Behaviour GMNCNEPJHHN, float ODFPLEJCGKM, int HNJHAHILDPD, [Optional] Action MECOKFDCOHP, float MNKNPCHHGIL = 0f, [Optional] KLFFABBGDHC HOEEDMFCBGA, [Optional] OPGHEHENADM PFKMAJGEAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "9")]
	protected override bool MFCOLNNNGCI(Action HMHDIIODGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6374AC0", Offset = "0x63738C0", VA = "0x186374AC0", Slot = "10")]
	protected override bool NIGFOPNCMBP(Action HMHDIIODGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6374A40", Offset = "0x6373840", VA = "0x186374A40")]
	private void KNONCJNMGHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HDJACEBNKAF : NKJJICBMALC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float PNCEHCHGKHA;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6366AA0", Offset = "0x63658A0", VA = "0x186366AA0")]
	public HDJACEBNKAF(Behaviour GMNCNEPJHHN, float PNCEHCHGKHA, [Optional] Action MECOKFDCOHP, [Optional] KLFFABBGDHC HOEEDMFCBGA, [Optional] OPGHEHENADM PFKMAJGEAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "9")]
	protected override bool MFCOLNNNGCI(Action HMHDIIODGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x636E860", Offset = "0x636D660", VA = "0x18636E860", Slot = "10")]
	protected override bool NIGFOPNCMBP(Action HMHDIIODGFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class HFMFNKKNKNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class JNBOGFLILDA : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public JNBOGFLILDA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x636B350", Offset = "0x636A150", VA = "0x18636B350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6371C10", Offset = "0x6370A10", VA = "0x186371C10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private FFHNDEGIGAM DDNIFKLMFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private GECCANDAKGE GMNCNEPJHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> DPHBBGOELGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private MIJAHBFLJPH LIPJGLJHEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float IOOGKDDPFOF;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x636EF00", Offset = "0x636DD00", VA = "0x18636EF00")]
	public HFMFNKKNKNI(GECCANDAKGE GMNCNEPJHHN, float IFPAEJGCKJD, Action<float> EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x636EB80", Offset = "0x636D980", VA = "0x18636EB80")]
	private void GFNLEMMKEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x636ED20", Offset = "0x636DB20", VA = "0x18636ED20")]
	private void HLKDEMDAFCK(string OGJCCLJIEPL, Action OJMPIFAFEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x636EE80", Offset = "0x636DC80", VA = "0x18636EE80")]
	[IteratorStateMachine(typeof(JNBOGFLILDA))]
	private IEnumerator<CCMEGKBIKJP> IBIBJGEOBBL(Action OJMPIFAFEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x636EB20", Offset = "0x636D920", VA = "0x18636EB20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x636E970", Offset = "0x636D770", VA = "0x18636E970")]
	[CompilerGenerated]
	private void DOPMLLKEPAF(string LLMCFHBADKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class JBNOLBMJOEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class DENHCHPGEAP : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public DENHCHPGEAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x636B350", Offset = "0x636A150", VA = "0x18636B350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x636B3C0", Offset = "0x636A1C0", VA = "0x18636B3C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private FFHNDEGIGAM DDNIFKLMFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour OLPNFBGADIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action EEMIJKOCPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> DPHBBGOELGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private MIJAHBFLJPH LIPJGLJHEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float IOOGKDDPFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool JHGNNOGNEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly KLFFABBGDHC HOEEDMFCBGA;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6370410", Offset = "0x636F210", VA = "0x186370410")]
	public JBNOLBMJOEK(MonoBehaviour OLPNFBGADIK, Action EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE, [Optional] KLFFABBGDHC HOEEDMFCBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6370600", Offset = "0x636F400", VA = "0x186370600")]
	public JBNOLBMJOEK(MonoBehaviour OLPNFBGADIK, Action<float> EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE, [Optional] KLFFABBGDHC HOEEDMFCBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6370840", Offset = "0x636F640", VA = "0x186370840")]
	public JBNOLBMJOEK(MonoBehaviour OLPNFBGADIK, float IFPAEJGCKJD, Action<float> EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE, bool JHGNNOGNEPL = true, [Optional] KLFFABBGDHC HOEEDMFCBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x17A1CF0", Offset = "0x17A0AF0", VA = "0x1817A1CF0")]
	private JBNOLBMJOEK(KLFFABBGDHC HOEEDMFCBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x636FCB0", Offset = "0x636EAB0", VA = "0x18636FCB0")]
	internal static JBNOLBMJOEK FNBHPADKBPJ(MonoBehaviour OLPNFBGADIK, float IFPAEJGCKJD, Action<float> EEMIJKOCPIJ, MIJAHBFLJPH LIPJGLJHEFE, bool JHGNNOGNEPL = true, [Optional] KLFFABBGDHC HOEEDMFCBGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x636F890", Offset = "0x636E690", VA = "0x18636F890")]
	private void BEEPFCMOJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x63701D0", Offset = "0x636EFD0", VA = "0x1863701D0")]
	private void NJDPNOCGJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x636FDE0", Offset = "0x636EBE0", VA = "0x18636FDE0")]
	private void GFNLEMMKEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x636FAF0", Offset = "0x636E8F0", VA = "0x18636FAF0")]
	private void FKKIJIMCKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x636FF90", Offset = "0x636ED90", VA = "0x18636FF90")]
	private void HLKDEMDAFCK(string OGJCCLJIEPL, Action OJMPIFAFEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6370150", Offset = "0x636EF50", VA = "0x186370150")]
	[IteratorStateMachine(typeof(DENHCHPGEAP))]
	private IEnumerator<CCMEGKBIKJP> IBIBJGEOBBL(Action OJMPIFAFEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x636FA90", Offset = "0x636E890", VA = "0x18636FA90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x636F800", Offset = "0x636E600", VA = "0x18636F800")]
	[CompilerGenerated]
	private void BBELOAOFGIJ(string LLMCFHBADKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6370380", Offset = "0x636F180", VA = "0x186370380")]
	[CompilerGenerated]
	private void PDMDBENCBBG(string LLMCFHBADKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x63700C0", Offset = "0x636EEC0", VA = "0x1863700C0")]
	[CompilerGenerated]
	private void HOEJOAEBCJL(string LLMCFHBADKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x636FA00", Offset = "0x636E800", VA = "0x18636FA00")]
	[CompilerGenerated]
	private void CPBKIMNMBIN(string LLMCFHBADKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum BAMKHLNGABD : byte
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
internal sealed class FPHEHOLIPGI : OPGHEHENADM
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float CJPOLAFDMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x636D060", Offset = "0x636BE60", VA = "0x18636D060", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float JKMGKEANIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x636CFC0", Offset = "0x636BDC0", VA = "0x18636CFC0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double NOBAOFDDALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x636D040", Offset = "0x636BE40", VA = "0x18636D040", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x636CFD0", Offset = "0x636BDD0", VA = "0x18636CFD0")]
	[GAPOPKHLLNB(OGJCEJIMIKL.None)]
	private static void CMFPJFHGGNL(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	[Preserve]
	internal FPHEHOLIPGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface MIAMIOJAAMD
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFKCBFNBGCC(string ONIBECKLJDD);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIELHODIFIH();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface CIDMKIBILPD
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool GELNFKLAMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JMCKOBPKAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class DFDGFEKMNMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public AICAJHMPFHF KGAKEECNJOC;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int CPCFHDJMLHI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75FF80", VA = "0x180761180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x761610", Offset = "0x760410", VA = "0x180761610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x636B6C0", Offset = "0x636A4C0", VA = "0x18636B6C0")]
	public static CCMEGKBIKJP PIGJIDJEPNA(IEnumerator<CCMEGKBIKJP> LOILEPALJKC, BHAKKOPMMPP FPDKNAOCMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x636B820", Offset = "0x636A620", VA = "0x18636B820")]
	public CCMEGKBIKJP PIGJIDJEPNA(BHAKKOPMMPP[] PPCLEJJHCMG, IEnumerator<CCMEGKBIKJP>[] PMJMEONPPME, CCMEGKBIKJP[] HCIGLDABBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x636B410", Offset = "0x636A210", VA = "0x18636B410")]
	public void AAMDOEACONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x636B580", Offset = "0x636A380", VA = "0x18636B580")]
	public void NCDNGJGAIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x636B440", Offset = "0x636A240", VA = "0x18636B440")]
	public void MFGILKFCHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x636B410", Offset = "0x636A210", VA = "0x18636B410")]
	public void HONJIECJPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DFDGFEKMNMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class AICAJHMPFHF
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct KJCFFAHJPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public DFDGFEKMNMO LGFPLDMGBOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public GECCANDAKGE JFJFFBOHGCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public BHAKKOPMMPP FAEMDIEHBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<CCMEGKBIKJP> PHKOPLHCFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public CCMEGKBIKJP NKEAKEHBKJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public BAMKHLNGABD OJGKBAPGMAE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct HOEAPBHJHJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public MIJAHBFLJPH IIKKPJAPBPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<KJCFFAHJPNM> FPNMGJPCLPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class NACOICBCIMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public BHAKKOPMMPP promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AICAJHMPFHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public GECCANDAKGE context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public DFDGFEKMNMO routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public BAMKHLNGABD coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CCMEGKBIKJP currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<CCMEGKBIKJP> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public NACOICBCIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6377D10", Offset = "0x6376B10", VA = "0x186377D10")]
		internal void JFHOFBMBMNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class JHHAGBFHACK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public DFDGFEKMNMO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public AICAJHMPFHF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public JHHAGBFHACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6370C30", Offset = "0x636FA30", VA = "0x186370C30")]
		internal void JGDNNJCJDGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class IBCKBMDKEOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public DFDGFEKMNMO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public AICAJHMPFHF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public IBCKBMDKEOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x636F560", Offset = "0x636E360", VA = "0x18636F560")]
		internal void EAHEJJDGJOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class CCGIDOKFIIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public DFDGFEKMNMO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public AICAJHMPFHF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public CCGIDOKFIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6366C90", Offset = "0x6365A90", VA = "0x186366C90")]
		internal void GEIMAKCKCJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const BAMKHLNGABD JEDABIDMFDI = BAMKHLNGABD.Cancelled | BAMKHLNGABD.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly MIJAHBFLJPH LIPJGLJHEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] IEJDDALAIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<BAMKHLNGABD> PBJMLINMBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> ANAOEEHLOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> ELAONHEBPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> BGOKDNAIOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> PCGBAMNLIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> NJIBADKGEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> FNLOLBHBHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private DFDGFEKMNMO[] IAAEJJFAMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private BHAKKOPMMPP[] PPCLEJJHCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private GECCANDAKGE[] EFPGDNKOPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<CCMEGKBIKJP>[] BANEPICPHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private CCMEGKBIKJP[] IBLNKNHBNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int IIHKDHDAIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int DECKGNHFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int FIHAMENAGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float IFIGIIPDCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private BFOKPBJDDAD KOBPAIHKPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle GLAHIEHBNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<DFDGFEKMNMO> CCFKLPKEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool GLAKMDMFMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> BKLAJFCBDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> HPMDJELNJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool ACBFGJGJIOC;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public HOEAPBHJHJJ[] DBLGEPAPJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B40", Offset = "0x8B3940", VA = "0x1808B4B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6362DE0", Offset = "0x6361BE0", VA = "0x186362DE0")]
	private static int JNPPCELBEKG(MIJAHBFLJPH LIPJGLJHEFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6363E90", Offset = "0x6362C90", VA = "0x186363E90")]
	public AICAJHMPFHF(MIJAHBFLJPH LIPJGLJHEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6362E10", Offset = "0x6361C10", VA = "0x186362E10")]
	private void JOIMMJOGEHG(int DGFJACFHNAB, int OIHGCLDMNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6363D10", Offset = "0x6362B10", VA = "0x186363D10")]
	public void PPHBBJOONFL(GECCANDAKGE GMNCNEPJHHN, CCMEGKBIKJP FHOHDDNAFFD, IEnumerator<CCMEGKBIKJP> LOILEPALJKC, BHAKKOPMMPP FPDKNAOCMNH, [Optional] DFDGFEKMNMO KCICEGBGAFB, BAMKHLNGABD LLACMOHLNAC = BAMKHLNGABD.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6361BF0", Offset = "0x63609F0", VA = "0x186361BF0")]
	public void CHMNCEOJBNE(IEnumerable<KJCFFAHJPNM> PAOIEMKNJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6362630", Offset = "0x6361430", VA = "0x186362630")]
	private KJCFFAHJPNM GEKOHAJCJBF(int NNPGDODCBDJ)
	{
		return default(KJCFFAHJPNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6363600", Offset = "0x6362400", VA = "0x186363600")]
	private void OMKICDHPCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x29B2BE0", Offset = "0x29B19E0", VA = "0x1829B2BE0")]
	private static void NMEJJIFMMCA<T>(int NNPGDODCBDJ, T[] LGDPLAMEDOK, int MEDHPDICIDE, [Optional] T MEPOJNBBKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x29B2C30", Offset = "0x29B1A30", VA = "0x1829B2C30")]
	private static void NMEJJIFMMCA<T>(int NNPGDODCBDJ, NativeArray<T> LGDPLAMEDOK, int MEDHPDICIDE, [Optional] T MEPOJNBBKBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6363970", Offset = "0x6362770", VA = "0x186363970")]
	private void OMOLANJDKAH(IEnumerable<KJCFFAHJPNM> PAOIEMKNJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6361B30", Offset = "0x6360930", VA = "0x186361B30")]
	private void AJDDEPJLDJG(KJCFFAHJPNM HPJJKMNOFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x63633A0", Offset = "0x63621A0", VA = "0x1863633A0")]
	private COACANNIAIE NPBBEHNBEEA(int DDMGAJCLKNN)
	{
		return default(COACANNIAIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6362FF0", Offset = "0x6361DF0", VA = "0x186362FF0")]
	public void MNMEPPCJLOJ(float KHIEIHEOENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6362C30", Offset = "0x6361A30", VA = "0x186362C30")]
	private void IFKLMIPCIEB(Action MACGGKMNKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6363320", Offset = "0x6362120", VA = "0x186363320")]
	private void NOIMAGIJIPE(Action MACGGKMNKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6361F30", Offset = "0x6360D30", VA = "0x186361F30")]
	public void FGMBHGBAFFB(float KHIEIHEOENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6361E30", Offset = "0x6360C30", VA = "0x186361E30")]
	public void DGLGEELFCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6362B00", Offset = "0x6361900", VA = "0x186362B00")]
	public void HONJIECJPOJ(DFDGFEKMNMO DNDNNAAGMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6362CB0", Offset = "0x6361AB0", VA = "0x186362CB0")]
	public void IGCAFFMOBDK(DFDGFEKMNMO DNDNNAAGMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x63631F0", Offset = "0x6361FF0", VA = "0x1863631F0")]
	public void NLMPEEOLAOJ(DFDGFEKMNMO DNDNNAAGMEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GOCKHGJADJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly GOCKHGJADJD AFMDONMGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action AOMKKCALAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool FABLEFHCLJG;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	public GOCKHGJADJD(Action AOMKKCALAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x636E710", Offset = "0x636D510", VA = "0x18636E710", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface ACKBHPDADAB<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T GMPOHOAMMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable AGHOACIDOEG(UnityEngine.Object GMNCNEPJHHN, Action<T> POAOKBMAHEF);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface HLJHOCOIFDB<T> : ACKBHPDADAB<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T GMPOHOAMMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class GONEPPFKDBI<T> : HLJHOCOIFDB<T>, ACKBHPDADAB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class IJLHIEAPENG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public GONEPPFKDBI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public INHELDLJPNF<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public IJLHIEAPENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x36834F0", Offset = "0x36822F0", VA = "0x1836834F0")]
		internal void MDGGCCCHNJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject JCENEMLPDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<INHELDLJPNF<UnityEngine.Object, Action<T>>> PGHFKOCGBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T DNFLABFDOMC;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T GMPOHOAMMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BF0", Offset = "0x7CF9F0", VA = "0x1807D0BF0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x34E1110", Offset = "0x34DFF10", VA = "0x1834E1110", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x34E1040", Offset = "0x34DFE40", VA = "0x1834E1040")]
	private static bool FNGKJPJLCAJ(T MACGGKMNKNM, T JHKDDIMPPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x34E1920", Offset = "0x34E0720", VA = "0x1834E1920")]
	public GONEPPFKDBI(T HDPJFDDCDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x34E0E80", Offset = "0x34DFC80", VA = "0x1834E0E80", Slot = "6")]
	public IDisposable AGHOACIDOEG(UnityEngine.Object GMNCNEPJHHN, Action<T> POAOKBMAHEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x34E1540", Offset = "0x34E0340", VA = "0x1834E1540")]
	private void IJDLDAPPKKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class JLKAFNCJPNF : JEFGKLACNJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly KLFFABBGDHC HOEEDMFCBGA;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6371BA0", Offset = "0x63709A0", VA = "0x186371BA0")]
	[GAPOPKHLLNB(OGJCEJIMIKL.None)]
	private static void CMFPJFHGGNL(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	[Preserve]
	internal JLKAFNCJPNF([NMBHAKGIBHG(null)] KLFFABBGDHC HOEEDMFCBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6371AF0", Offset = "0x63708F0", VA = "0x186371AF0", Slot = "4")]
	public IDisposable BOLLLCABDDN(float IFPAEJGCKJD, Action<float> MEKLMIFMFCO, bool JHGNNOGNEPL = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class JKHFENNOKBF : PPDCEJLPLDG, KLFFABBGDHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private AICAJHMPFHF[] FCIBAKOLHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private MIAMIOJAAMD FPBJLGECPBC;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6370F50", Offset = "0x636FD50", VA = "0x186370F50")]
	[GAPOPKHLLNB(OGJCEJIMIKL.None)]
	private static void CMFPJFHGGNL(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6371830", Offset = "0x6370630", VA = "0x186371830")]
	[Preserve]
	public JKHFENNOKBF([NMBHAKGIBHG(null)] OICAFJIFHLP KLNJPJDBGNG, [NMBHAKGIBHG(null)] OPGHEHENADM PFKMAJGEAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6371210", Offset = "0x6370010", VA = "0x186371210", Slot = "16")]
	public override FFHNDEGIGAM INFBHNDNFCG(GECCANDAKGE GMNCNEPJHHN, IEnumerator<CCMEGKBIKJP> DKGNMLGBHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6370CC0", Offset = "0x636FAC0", VA = "0x186370CC0", Slot = "17")]
	public override void AOMGIBAKPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6371490", Offset = "0x6370290", VA = "0x186371490", Slot = "19")]
	public override void NFBGIHAFFFE(MIJAHBFLJPH LIPJGLJHEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x63716C0", Offset = "0x63704C0", VA = "0x1863716C0", Slot = "18")]
	protected override void PFMOOMMEHLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6371460", Offset = "0x6370260", VA = "0x186371460")]
	private AICAJHMPFHF LNLGNLNIGLK(MIJAHBFLJPH PEMNIEMPPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6371020", Offset = "0x636FE20", VA = "0x186371020", Slot = "20")]
	internal override GDANPDMOGBN FIKLMNMIENJ(IEnumerator<CCMEGKBIKJP> DKGNMLGBHIB, Behaviour GMNCNEPJHHN, BHAKKOPMMPP FPDKNAOCMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6371190", Offset = "0x636FF90", VA = "0x186371190", Slot = "21")]
	internal override LKFILDAAACM HKLGMFOMKAJ(MIJAHBFLJPH MKEMCEBLCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6371340", Offset = "0x6370140", VA = "0x186371340")]
	private void LJCAJKOALBN(AICAJHMPFHF HFMCIJBJHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6370FC0", Offset = "0x636FDC0", VA = "0x186370FC0", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct BFOKPBJDDAD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float BFNAACBMAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int BFFGALINEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> JGOANFPDHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> AHLOMABBNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> IDEMDNLBLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<BAMKHLNGABD> PLMNHGOHFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> OGMNGIHCCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> PCGBAMNLIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> ELAONHEBPFH;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6366420", Offset = "0x6365220", VA = "0x186366420")]
	public static BFOKPBJDDAD HKJMJGOBNGA(int GOANHFKDNPK, float KHIEIHEOENH, NativeArray<BAMKHLNGABD> EKEKOALMOMP, NativeArray<float> NOCABDDKFGM, NativeArray<int> AKBAMJBOMKO, NativeArray<int> IGAGDNOOKEK, NativeArray<int> PACLNCLPAGM, NativeArray<int> AHLOMABBNHL, NativeArray<int> IDEMDNLBLAC)
	{
		return default(BFOKPBJDDAD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6366340", Offset = "0x6365140", VA = "0x186366340", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6366550", Offset = "0x6365350", VA = "0x186366550")]
	private bool KIPCHECBEDO(int DOJILIOCHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6366030", Offset = "0x6364E30", VA = "0x186366030")]
	private void AOJHJCMHMOG(NativeArray<int> DEHGNHJPNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x63662A0", Offset = "0x63650A0", VA = "0x1863662A0")]
	private int EMFKOIIHLNM(int EGINMGIDNIG, int ALBMBMBNNOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6366480", Offset = "0x6365280", VA = "0x186366480")]
	private void JKKGDGPGEJD(NativeArray<int> DEHGNHJPNLN, int FJDLFOIPMIH, int HFPPDNNHFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6366060", Offset = "0x6364E60", VA = "0x186366060")]
	private void DIGCLJHICED(NativeArray<int> DEHGNHJPNLN, int JCIKLPNELJC, int IDHDHBGEKBG, int DCOGDPNEPGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class PPDCEJLPLDG : KLFFABBGDHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly OICAFJIFHLP KLNJPJDBGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly OPGHEHENADM PFKMAJGEAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private LKFILDAAACM[] CBKLNIBDJNB;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static KLFFABBGDHC GOPCOAILBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x637ADD0", Offset = "0x6379BD0", VA = "0x18637ADD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MIJAHBFLJPH JAHEDNJDAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75FF80", VA = "0x180761180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MIJAHBFLJPH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x761610", Offset = "0x760410", VA = "0x180761610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public OPGHEHENADM CDPCLMIFMFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public CCMEGKBIKJP HMBMMCHMAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x76B160", Offset = "0x769F60", VA = "0x18076B160", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x637AD40", Offset = "0x6379B40", VA = "0x18637AD40")]
	public static FFHNDEGIGAM EKKMACGMHHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x637B680", Offset = "0x637A480", VA = "0x18637B680")]
	[Preserve]
	protected PPDCEJLPLDG([NMBHAKGIBHG(null)] OICAFJIFHLP KLNJPJDBGNG, [NMBHAKGIBHG(null)] OPGHEHENADM PFKMAJGEAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x637B650", Offset = "0x637A450", VA = "0x18637B650", Slot = "6")]
	public FFHNDEGIGAM ODBEBJNFCLL(IEnumerator<CCMEGKBIKJP> DKGNMLGBHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x637B450", Offset = "0x637A250", VA = "0x18637B450", Slot = "7")]
	public FFHNDEGIGAM ODBEBJNFCLL(Behaviour GMNCNEPJHHN, IEnumerator<CCMEGKBIKJP> DKGNMLGBHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract FFHNDEGIGAM INFBHNDNFCG(GECCANDAKGE GMNCNEPJHHN, IEnumerator<CCMEGKBIKJP> DKGNMLGBHIB);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x637A760", Offset = "0x6379560", VA = "0x18637A760", Slot = "17")]
	public virtual void AOMGIBAKPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x637AF90", Offset = "0x6379D90", VA = "0x18637AF90", Slot = "9")]
	public void MEGDKAOOPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x637B660", Offset = "0x637A460", VA = "0x18637B660", Slot = "18")]
	protected virtual void PFMOOMMEHLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x637AEC0", Offset = "0x6379CC0", VA = "0x18637AEC0")]
	private void KGBKGHPENBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x637A900", Offset = "0x6379700", VA = "0x18637A900")]
	private void COHGGENIEPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x637A740", Offset = "0x6379540", VA = "0x18637A740")]
	private void AAFGKGBKHHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x637AE80", Offset = "0x6379C80", VA = "0x18637AE80")]
	private void GOBODFCNJGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x637B430", Offset = "0x637A230", VA = "0x18637B430")]
	private void NLGFDJIKOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x637AF70", Offset = "0x6379D70", VA = "0x18637AF70")]
	private void LMJDCGPLJPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x637AEA0", Offset = "0x6379CA0", VA = "0x18637AEA0")]
	private void HICCAOFMPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x637B3A0", Offset = "0x637A1A0", VA = "0x18637B3A0", Slot = "19")]
	public virtual void NFBGIHAFFFE(MIJAHBFLJPH LIPJGLJHEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x637B1D0", Offset = "0x6379FD0", VA = "0x18637B1D0")]
	private void MLEGCJHGDBC(LKFILDAAACM HFMCIJBJHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1B5BA10", Offset = "0x1B5A810", VA = "0x181B5BA10")]
	private LKFILDAAACM PACEILJIPFK(MIJAHBFLJPH PEMNIEMPPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract GDANPDMOGBN FIKLMNMIENJ(IEnumerator<CCMEGKBIKJP> DKGNMLGBHIB, Behaviour OLPNFBGADIK, BHAKKOPMMPP LHFPEJHEEIJ);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract LKFILDAAACM HKLGMFOMKAJ(MIJAHBFLJPH LIPJGLJHEFE);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x637A980", Offset = "0x6379780", VA = "0x18637A980", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x637A920", Offset = "0x6379720", VA = "0x18637A920", Slot = "12")]
	public CCMEGKBIKJP DILCJAEOBDE(MIJAHBFLJPH MKEMCEBLCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x637AEE0", Offset = "0x6379CE0", VA = "0x18637AEE0", Slot = "13")]
	public CCMEGKBIKJP KODPMILMIIP(float MILPBPEIAGI, MIJAHBFLJPH MKEMCEBLCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x637AE20", Offset = "0x6379C20", VA = "0x18637AE20", Slot = "14")]
	public CCMEGKBIKJP GGINDEEIMFL(Func<bool> NDIKNGPKKGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class GDANPDMOGBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly BHAKKOPMMPP FPDKNAOCMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly CIDMKIBILPD GMNCNEPJHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool AJKDJHNJAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string ONIBECKLJDD;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<CCMEGKBIKJP> PHKOPLHCFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x763960", Offset = "0x762760", VA = "0x180763960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public CCMEGKBIKJP NKEAKEHBKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x761630", Offset = "0x760430", VA = "0x180761630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool PCIMOLJAHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x636DBF0", Offset = "0x636C9F0", VA = "0x18636DBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool DHMABMJPOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x802FF0", Offset = "0x801DF0", VA = "0x180802FF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xAF80F0", Offset = "0xAF6EF0", VA = "0x180AF80F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x636D9D0", Offset = "0x636C7D0", VA = "0x18636D9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float EPMBBNMJPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1017730", Offset = "0x1016530", VA = "0x181017730")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x10D3EB0", Offset = "0x10D2CB0", VA = "0x1810D3EB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x636DFF0", Offset = "0x636CDF0", VA = "0x18636DFF0")]
	public GDANPDMOGBN(IEnumerator<CCMEGKBIKJP> LOILEPALJKC, CIDMKIBILPD GMNCNEPJHHN, BHAKKOPMMPP FPDKNAOCMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x636DC70", Offset = "0x636CA70", VA = "0x18636DC70")]
	public CCMEGKBIKJP PIGJIDJEPNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x636DB80", Offset = "0x636C980", VA = "0x18636DB80")]
	public bool NHFIEBFMGCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x636D980", Offset = "0x636C780", VA = "0x18636D980")]
	public void HONJIECJPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x636DF10", Offset = "0x636CD10", VA = "0x18636DF10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x81A510", Offset = "0x819310", VA = "0x18081A510")]
	[CompilerGenerated]
	private void ELAHBIBCIEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class BHAKKOPMMPP : JPPJFNHFEGN, FFHNDEGIGAM, BJEHAIIHJME, KKKGKPAKNDP, IEnumerator, CCMEGKBIKJP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private MIJAHBFLJPH NGOPDKMODMK;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private MIJAHBFLJPH DLOMPJCKLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xCF07C0", Offset = "0xCEF5C0", VA = "0x180CF07C0", Slot = "23")]
		get
		{
			return default(MIJAHBFLJPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public MIJAHBFLJPH KGAKEECNJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x11D2800", Offset = "0x11D1600", VA = "0x1811D2800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float LJABFBJMDEK
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6040", Offset = "0x7B4E40", VA = "0x1807B6040", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool FOGOMDADKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6366800", Offset = "0x6365600", VA = "0x186366800", Slot = "24")]
	private bool ANGKDLFMLDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6366820", Offset = "0x6365620", VA = "0x186366820", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6366830", Offset = "0x6365630", VA = "0x186366830")]
	public BHAKKOPMMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum COACANNIAIE : byte
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
internal sealed class LKFILDAAACM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum GOPIFMMGHJC
	{
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct POOHJBNGKKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public MIJAHBFLJPH IIKKPJAPBPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public GOPIFMMGHJC PIFIMJIOOIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public List<GDANPDMOGBN> INGNJLFCEAP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly GOPIFMMGHJC[] PCKMEMHOAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly MIJAHBFLJPH LIPJGLJHEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private bool ADIBILLIEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly GDANPDMOGBN[] AFPDCIENCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly List<GDANPDMOGBN> KDIFIOKJDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly Stack<int> OOCIDPPFEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<GDANPDMOGBN> ONKBAJJGCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<int> EBAHHCGAGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly MIAMIOJAAMD HKDFFGEKEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private bool ACBFGJGJIOC;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public POOHJBNGKKK[,] PCEKKMAOHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x76B160", Offset = "0x769F60", VA = "0x18076B160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x63764B0", Offset = "0x63752B0", VA = "0x1863764B0")]
	public LKFILDAAACM(MIJAHBFLJPH MKEMCEBLCJD, MIAMIOJAAMD HKDFFGEKEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6376100", Offset = "0x6374F00", VA = "0x186376100")]
	public void PEAMEJKINDN(GDANPDMOGBN LOILEPALJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6375630", Offset = "0x6374430", VA = "0x186375630")]
	public void LENACDFPFFE(IList<GDANPDMOGBN> PMJMEONPPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6375B30", Offset = "0x6374930", VA = "0x186375B30")]
	public void MKLGMFAOLAB(IList<GDANPDMOGBN> PMJMEONPPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6374F90", Offset = "0x6373D90", VA = "0x186374F90")]
	private void ACDOIGPHPLM(GDANPDMOGBN LOILEPALJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x63754A0", Offset = "0x63742A0", VA = "0x1863754A0")]
	private void HMPOJKLALPD(IList<GDANPDMOGBN> PMJMEONPPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6375F80", Offset = "0x6374D80", VA = "0x186375F80")]
	private COACANNIAIE ONBKFPPJOAA(GDANPDMOGBN LOILEPALJKC)
	{
		return default(COACANNIAIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6376200", Offset = "0x6375000", VA = "0x186376200")]
	public void PFMOOMMEHLD(float KHIEIHEOENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6375940", Offset = "0x6374740", VA = "0x186375940")]
	public void MEGDKAOOPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x63751A0", Offset = "0x6373FA0", VA = "0x1863751A0")]
	private void FHMFFHICFEN(List<GDANPDMOGBN> PMJMEONPPME, Stack<int> LMANLOCHPAJ, bool AJEOGKDOLPG, float OOMOJLKEFCA = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6375080", Offset = "0x6373E80", VA = "0x186375080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6375E40", Offset = "0x6374C40", VA = "0x186375E40")]
	private void NOCOFJOGKIP(List<GDANPDMOGBN> PMJMEONPPME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class BEOGFBCNMOO : MIAMIOJAAMD
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
	public void BFKCBFNBGCC(string ONIBECKLJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
	public void PIELHODIFIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BEOGFBCNMOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class CAIBCDKDAGC : CIDMKIBILPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Behaviour OLPNFBGADIK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6366C10", Offset = "0x6365A10", VA = "0x186366C10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GELNFKLAMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6366BA0", Offset = "0x63659A0", VA = "0x186366BA0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool JMCKOBPKAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6366BF0", Offset = "0x63659F0", VA = "0x186366BF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	public CAIBCDKDAGC(Behaviour OLPNFBGADIK)
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

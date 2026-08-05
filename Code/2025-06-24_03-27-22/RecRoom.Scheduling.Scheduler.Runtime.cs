using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88EB9D0", Offset = "0x88EA5D0", VA = "0x1888EB9D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private delegate List<PlayerLoopSystem> PKDHBCJEJHB(List<PlayerLoopSystem> OJFDFCNOHKO, int HIAMAEDNMCB);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct HGJLILPCKBC
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct FNCIAECJBPD
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static HBAAEHCBNNO CONHICFJNHJ;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x88E0DF0", Offset = "0x88DF9F0", VA = "0x1888E0DF0")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct BGMBDNALPAO
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static HBAAEHCBNNO BNPEIKKIJJA;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x88D59D0", Offset = "0x88D45D0", VA = "0x1888D59D0")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct KKFJOABDJLI
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static HBAAEHCBNNO NHMBCMEPPDO;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x88E6ED0", Offset = "0x88E5AD0", VA = "0x1888E6ED0")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct GPDPDIBGIPK
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static HBAAEHCBNNO HLJANGECAJN;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static HBAAEHCBNNO BLJKLBCENAO;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static HBAAEHCBNNO GDMEEJHGKHL;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static HBAAEHCBNNO KBGEHDNFEPB;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x88E1A10", Offset = "0x88E0610", VA = "0x1888E1A10")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct IMIBMAINAPD
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static HBAAEHCBNNO MKJGMLCFDHO;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x88E4740", Offset = "0x88E3340", VA = "0x1888E4740")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct EAGOEKDPDAB
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static HBAAEHCBNNO HLJANGECAJN;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static HBAAEHCBNNO BLJKLBCENAO;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static HBAAEHCBNNO GDMEEJHGKHL;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static HBAAEHCBNNO KBGEHDNFEPB;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x88DEB40", Offset = "0x88DD740", VA = "0x1888DEB40")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct HPOFINMPMLP
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static HBAAEHCBNNO CBCCCJOHLJJ;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x88E1E10", Offset = "0x88E0A10", VA = "0x1888E1E10")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct OALNPHHPPHM
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static HBAAEHCBNNO LMDGEDFEGLO;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x88EA620", Offset = "0x88E9220", VA = "0x1888EA620")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct KHCJKKGHJDN
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static HBAAEHCBNNO LHEIGEDKIJG;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x88E6CF0", Offset = "0x88E58F0", VA = "0x1888E6CF0")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct BFDHLNCEJHJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static HBAAEHCBNNO HKOMJIBABDO;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x88D5770", Offset = "0x88D4370", VA = "0x1888D5770")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct GLIINHBMOEB
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static HBAAEHCBNNO FCBMMLGKAIH;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x88E15D0", Offset = "0x88E01D0", VA = "0x1888E15D0")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct COPAPMLJKNG
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static HBAAEHCBNNO NPPHPHKDPNK;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x88D75A0", Offset = "0x88D61A0", VA = "0x1888D75A0")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct CAECGKGGOCL
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static HBAAEHCBNNO IENGIJCFDGN;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x88D6D20", Offset = "0x88D5920", VA = "0x1888D6D20")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct GOOIMNDHEHI
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static HBAAEHCBNNO NHPCAPNJAME;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x88E1830", Offset = "0x88E0430", VA = "0x1888E1830")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public struct NLGGCHFOMKH
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static HBAAEHCBNNO HNDCJFPPKBM;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x88E9C90", Offset = "0x88E8890", VA = "0x1888E9C90")]
				public static PlayerLoopSystem NLCHOEJPNNI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public enum INICJMLLNMI : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public struct JLDFHDDAFOH
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class GMADJJELNEP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public INICJMLLNMI updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
					public GMADJJELNEP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0x88E17B0", Offset = "0x88E03B0", VA = "0x1888E17B0")]
					internal void KPPOACOKOPB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static PJAJEBBNNBK<INICJMLLNMI> HJEJIAOBBJB;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x88E6900", Offset = "0x88E5500", VA = "0x1888E6900")]
				public static PlayerLoopSystem NLCHOEJPNNI(INICJMLLNMI NFHNEPMLMGF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000027")]
			internal struct DLPMCBDABPD
			{
				[Cpp2IlInjected.Token(Token = "0x2000028")]
				[CompilerGenerated]
				private sealed class EKAOPGPCPOG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public IBKGGDOJKMK.BAEHAGNMGLD key;

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
					public EKAOPGPCPOG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005E")]
					[Cpp2IlInjected.Address(RVA = "0x88E00F0", Offset = "0x88DECF0", VA = "0x1888E00F0")]
					internal void EPGOFMEHEAI()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable FHLOIHILMON;

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x88DE620", Offset = "0x88DD220", VA = "0x1888DE620")]
				public static PlayerLoopSystem DJEGCMAHOGB(IBKGGDOJKMK.BAEHAGNMGLD MEPFFFGIFGB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002A")]
			internal struct HCIFKGKBGBH
			{
				[Cpp2IlInjected.Token(Token = "0x200002B")]
				[CompilerGenerated]
				private sealed class EADIOEOLOHN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public IBKGGDOJKMK.BAEHAGNMGLD key;

					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
					public EADIOEOLOHN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x88DE890", Offset = "0x88DD490", VA = "0x1888DE890")]
					internal void EPGOFMEHEAI()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x88E1CE0", Offset = "0x88E08E0", VA = "0x1888E1CE0")]
				public static PlayerLoopSystem DJEGCMAHOGB(IBKGGDOJKMK.BAEHAGNMGLD MEPFFFGIFGB)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class CBJLHKAEBCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public CBJLHKAEBCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x88D6F00", Offset = "0x88D5B00", VA = "0x1888D6F00")]
			internal List<PlayerLoopSystem> JPJIGMNKHAG(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool JINBMOGBIDJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool DHCPEEPFPHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x88D7CD0", Offset = "0x88D68D0", VA = "0x1888D7CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88D7F50", Offset = "0x88D6B50", VA = "0x1888D7F50")]
		private static void LKENHGGFCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88DAF60", Offset = "0x88D9B60", VA = "0x1888DAF60")]
		private static void MBPPHKJAAEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88D7780", Offset = "0x88D6380", VA = "0x1888D7780")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88D7D10", Offset = "0x88D6910", VA = "0x1888D7D10")]
		private static void HNBMIAHJIJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88DB870", Offset = "0x88DA470", VA = "0x1888DB870")]
		private static void PPENGBJNDMH(IBKGGDOJKMK.BAEHAGNMGLD MEPFFFGIFGB, PlayerLoopSystem KHEMAMNOHFF, Type OIHGHGDHAKL, Type BBINHPNNIOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88D77C0", Offset = "0x88D63C0", VA = "0x1888D77C0")]
		private static void FHDLHCKLHHB(PlayerLoopSystem KHEMAMNOHFF, Type OIHGHGDHAKL, Type BBINHPNNIOG, PKDHBCJEJHB NKDMGFNGJAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88D7BA0", Offset = "0x88D67A0", VA = "0x1888D7BA0")]
		private static void HFIJOFKELEF(PlayerLoopSystem KHEMAMNOHFF, Type OIHGHGDHAKL, Type BBINHPNNIOG, PlayerLoopSystem? OLIDCOOFFFH, PlayerLoopSystem? NIIGKLLKCBE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class IBKGGDOJKMK
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum BAEHAGNMGLD
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		OMPrePhysicsFixedUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class KCLFBPDMMPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly BAEHAGNMGLD LKPCJMCMLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly LJIOGGLDENE LALCGNJPMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long JGLEIKHFJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long HEHKFMAEJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long IAPGNIJEOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int LOGPOEBDAEM;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x88E6C10", Offset = "0x88E5810", VA = "0x1888E6C10")]
		public KCLFBPDMMPF(BAEHAGNMGLD ANKOFDFILFF, int IIDAFMMAPKC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x88E6B10", Offset = "0x88E5710", VA = "0x1888E6B10")]
		public void FKFGCCINGGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x88E6AC0", Offset = "0x88E56C0", VA = "0x1888E6AC0")]
		public void DPGBGKAFHCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x88E6B30", Offset = "0x88E5730", VA = "0x1888E6B30")]
		public void KKOILLDDAID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static BAEHAGNMGLD[] JOLHAGOLEFI;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static KCLFBPDMMPF[] FJIMMCJOEDA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x88E2100", Offset = "0x88E0D00", VA = "0x1888E2100")]
	public static KCLFBPDMMPF JGCDCEOGKAB(BAEHAGNMGLD MEPFFFGIFGB, int IIDAFMMAPKC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x88E2090", Offset = "0x88E0C90", VA = "0x1888E2090")]
	public static KCLFBPDMMPF FMMJIGLFFOE(BAEHAGNMGLD MEPFFFGIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x88E1FF0", Offset = "0x88E0BF0", VA = "0x1888E1FF0")]
	public static void FKAMPFFAAIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class IGOGODFPGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface HOPMGMBMFKN
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool NANJIKNIIJN
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JLDGPNOKBIC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class ELJDHLKGDML : HOPMGMBMFKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action IFDCDCHOGGB;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool NANJIKNIIJN
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
		public ELJDHLKGDML(Action IFDCDCHOGGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x11FDA70", Offset = "0x11FC670", VA = "0x1811FDA70", Slot = "5")]
		public void JLDGPNOKBIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<HOPMGMBMFKN> DFJDEHALIAP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x88E42C0", Offset = "0x88E2EC0", VA = "0x1888E42C0")]
	public static void MGKOKFJIDCD(Action IFDCDCHOGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x88E4430", Offset = "0x88E3030", VA = "0x1888E4430")]
	private static void NMKCEABPHHM(HOPMGMBMFKN FINNNOPINOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x88E3FE0", Offset = "0x88E2BE0", VA = "0x1888E3FE0")]
	private static void DGOBOABOLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x88E3EE0", Offset = "0x88E2AE0", VA = "0x1888E3EE0")]
	private static void CJNPNFLCIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x88E4360", Offset = "0x88E2F60", VA = "0x1888E4360")]
	private static void MJAILHMDMMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class FAIGDPMAGAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x88E05C0", Offset = "0x88DF1C0", VA = "0x1888E05C0")]
	public static IDisposable LEBMDFEPCDP(this OHAAOAKGENJ CBLPKFIJGLH, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x88E0650", Offset = "0x88DF250", VA = "0x1888E0650")]
	public static IDisposable LFNIJGLFENE(this OHAAOAKGENJ CBLPKFIJGLH, Action<float> DFEBMFPCKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x88E0540", Offset = "0x88DF140", VA = "0x1888E0540")]
	public static IDisposable KJHNKIELIAH(this OHAAOAKGENJ CBLPKFIJGLH, Action<float> DFEBMFPCKKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DJPIHKCKKDH
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x38E85C0", Offset = "0x38E71C0", VA = "0x1838E85C0")]
	[LHPJEGGMPCF]
	public static IDisposable AODADJNGGPM<T>(this T HBHJKEHGKLF, Action DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x38E8770", Offset = "0x38E7370", VA = "0x1838E8770")]
	[LHPJEGGMPCF]
	public static IDisposable AODADJNGGPM<T>(this T HBHJKEHGKLF, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x38E8DD0", Offset = "0x38E79D0", VA = "0x1838E8DD0")]
	[LHPJEGGMPCF]
	public static IDisposable NJCBLGMIGNH<T>(this T HBHJKEHGKLF, Action DFEBMFPCKKN, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x38E8C70", Offset = "0x38E7870", VA = "0x1838E8C70")]
	[LHPJEGGMPCF]
	public static IDisposable FJIEHIADHLD<T>(this T HBHJKEHGKLF, Action DFEBMFPCKKN, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x38E8C70", Offset = "0x38E7870", VA = "0x1838E8C70")]
	[LHPJEGGMPCF]
	public static IDisposable FJIEHIADHLD<T>(this T HBHJKEHGKLF, Action<float> DFEBMFPCKKN, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x38E8D20", Offset = "0x38E7920", VA = "0x1838E8D20")]
	[LHPJEGGMPCF]
	public static IDisposable LDHLHECGDJI<T>(this T HBHJKEHGKLF, Action DFEBMFPCKKN, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38E8B40", Offset = "0x38E7740", VA = "0x1838E8B40")]
	[LHPJEGGMPCF]
	public static IDisposable CCAINOGFLOK<T>(this T HBHJKEHGKLF, Action DFEBMFPCKKN, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x38E8B10", Offset = "0x38E7710", VA = "0x1838E8B10")]
	[LHPJEGGMPCF]
	public static IDisposable BPEDEBBBCIJ<T>(this T HBHJKEHGKLF, Action DFEBMFPCKKN, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x38E8CA0", Offset = "0x38E78A0", VA = "0x1838E8CA0")]
	[LHPJEGGMPCF]
	public static IDisposable HJFANHEFCHJ<T>(this T HBHJKEHGKLF, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x88DE440", Offset = "0x88DD040", VA = "0x1888DE440")]
	[LHPJEGGMPCF]
	public static IDisposable HJFANHEFCHJ(this MonoBehaviour HBHJKEHGKLF, MIGNIEJDGMD CBLPKFIJGLH, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x38E8960", Offset = "0x38E7560", VA = "0x1838E8960")]
	[LHPJEGGMPCF]
	public static IDisposable BIDBBIOOGME<T>(this T HBHJKEHGKLF, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x38E8D50", Offset = "0x38E7950", VA = "0x1838E8D50")]
	[LHPJEGGMPCF]
	public static IDisposable LHLKIDHNGDM<T>(this T HBHJKEHGKLF, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x38E8E00", Offset = "0x38E7A00", VA = "0x1838E8E00")]
	[LHPJEGGMPCF]
	public static IDisposable NMJADAGIKFK<T>(this T HBHJKEHGKLF, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x38E8CE0", Offset = "0x38E78E0", VA = "0x1838E8CE0")]
	[LHPJEGGMPCF]
	public static IDisposable HNPFJPDDCOJ<T>(this T HBHJKEHGKLF, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x38E8BF0", Offset = "0x38E77F0", VA = "0x1838E8BF0")]
	[LHPJEGGMPCF]
	public static IDisposable DBKOCOBPCCK<T>(this T HBHJKEHGKLF, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38E8580", Offset = "0x38E7180", VA = "0x1838E8580")]
	[LHPJEGGMPCF]
	public static IDisposable AAIBBEGHEEL<T>(this T HBHJKEHGKLF, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x38E8B70", Offset = "0x38E7770", VA = "0x1838E8B70")]
	[LHPJEGGMPCF]
	public static IDisposable CKGFBOKCCIN<T>(this T HBHJKEHGKLF, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x38E8C30", Offset = "0x38E7830", VA = "0x1838E8C30")]
	[LHPJEGGMPCF]
	public static IDisposable DEPNKEDBMGF<T>(this T HBHJKEHGKLF, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x38E8E40", Offset = "0x38E7A40", VA = "0x1838E8E40")]
	[LHPJEGGMPCF]
	public static IDisposable OMHBOOLIEKC<T>(this T HBHJKEHGKLF, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x38E8920", Offset = "0x38E7520", VA = "0x1838E8920")]
	[LHPJEGGMPCF]
	public static IDisposable BDCDBGCJNBH<T>(this T HBHJKEHGKLF, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x38E8D90", Offset = "0x38E7990", VA = "0x1838E8D90")]
	[LHPJEGGMPCF]
	public static IDisposable LPODKNOPMKP<T>(this T HBHJKEHGKLF, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x38E8BB0", Offset = "0x38E77B0", VA = "0x1838E8BB0")]
	[LHPJEGGMPCF]
	public static IDisposable DAONALJNKDE<T>(this T HBHJKEHGKLF, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true) where T : MonoBehaviour, MIGNIEJDGMD
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class EFKHNPCCOGN
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class LHOFOEBOCKE : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public GEPHJDONOHJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private JIGHMKGKIBE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public LHOFOEBOCKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x88E8500", Offset = "0x88E7100", VA = "0x1888E8500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x88E85E0", Offset = "0x88E71E0", VA = "0x1888E85E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class DMKEKCLPJNC : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public GEPHJDONOHJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private JIGHMKGKIBE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public DMKEKCLPJNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x88DE750", Offset = "0x88DD350", VA = "0x1888DE750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x88DE840", Offset = "0x88DD440", VA = "0x1888DE840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x88DFDE0", Offset = "0x88DE9E0", VA = "0x1888DFDE0")]
	public static GCBFJNEKOIO AODADJNGGPM(Action DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x88DFE60", Offset = "0x88DEA60", VA = "0x1888DFE60")]
	public static GCBFJNEKOIO AODADJNGGPM(Behaviour CBLPKFIJGLH, Action DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x88DFEF0", Offset = "0x88DEAF0", VA = "0x1888DFEF0")]
	public static GCBFJNEKOIO AODADJNGGPM(Behaviour CBLPKFIJGLH, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x88DFFD0", Offset = "0x88DEBD0", VA = "0x1888DFFD0")]
	[IteratorStateMachine(typeof(LHOFOEBOCKE))]
	private static IEnumerator<FCPCPCAPDCM> MJMEBGGPPEN(GEPHJDONOHJ LJMMOFEBMGE, Action DFEBMFPCKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x88E0060", Offset = "0x88DEC60", VA = "0x1888E0060")]
	[IteratorStateMachine(typeof(DMKEKCLPJNC))]
	private static IEnumerator<FCPCPCAPDCM> MJMEBGGPPEN(GEPHJDONOHJ LJMMOFEBMGE, Action<float> DFEBMFPCKKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class NALLAIECFFG : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class NNGJEJFBDNF : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NALLAIECFFG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public NNGJEJFBDNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x88E9F80", Offset = "0x88E8B80", VA = "0x1888E9F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x88EA010", Offset = "0x88E8C10", VA = "0x1888EA010", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly GEPHJDONOHJ OBNGFOLADNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Action IHNMFLEHEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool EFDHOLLALNA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GHBNADMNCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA247B0", Offset = "0xA233B0", VA = "0x180A247B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x88E9B90", Offset = "0x88E8790", VA = "0x1888E9B90")]
	public NALLAIECFFG(GEPHJDONOHJ OBNGFOLADNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x88E9A70", Offset = "0x88E8670", VA = "0x1888E9A70")]
	[IteratorStateMachine(typeof(NNGJEJFBDNF))]
	private IEnumerator<FCPCPCAPDCM> GPEDMKJBMGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x88E9AF0", Offset = "0x88E86F0", VA = "0x1888E9AF0", Slot = "4")]
	public void OnCompleted(Action JPMKDGPIIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	public void BOPJECOALEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NMECNLFFMEO
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x88E9E70", Offset = "0x88E8A70", VA = "0x1888E9E70")]
	public static NALLAIECFFG LCIABKLGBLO(this GEPHJDONOHJ OBNGFOLADNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EFJFMLEIMEP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class IDCMPJMBIEJ : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public NJBMAEODDHN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public IDCMPJMBIEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x88E23E0", Offset = "0x88E0FE0", VA = "0x1888E23E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x88E2460", Offset = "0x88E1060", VA = "0x1888E2460", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x88DFA00", Offset = "0x88DE600", VA = "0x1888DFA00")]
	public static GCBFJNEKOIO AODADJNGGPM(float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, bool ADPHOJOPGKO = true, [Optional] IPNEFGFBDID KHIBKDLKLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x88DF930", Offset = "0x88DE530", VA = "0x1888DF930")]
	public static GCBFJNEKOIO AODADJNGGPM(MonoBehaviour HBHJKEHGKLF, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, bool ADPHOJOPGKO = true, [Optional] IPNEFGFBDID KHIBKDLKLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x88DFC30", Offset = "0x88DE830", VA = "0x1888DFC30")]
	public static GCBFJNEKOIO IDLHMHIBLNL(MonoBehaviour HBHJKEHGKLF, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, bool ADPHOJOPGKO = true, [Optional] IPNEFGFBDID KHIBKDLKLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x88DFAD0", Offset = "0x88DE6D0", VA = "0x1888DFAD0")]
	public static GCBFJNEKOIO GFBMKKGHFNP(OHAAOAKGENJ CBLPKFIJGLH, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, bool ADPHOJOPGKO = true, [Optional] IPNEFGFBDID KHIBKDLKLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x88DFD20", Offset = "0x88DE920", VA = "0x1888DFD20")]
	private static IEnumerator<FCPCPCAPDCM> MJMEBGGPPEN(DHBIPHECKBB GEFFMALAFGG, float FJLIIHLLAJI, GEPHJDONOHJ LJMMOFEBMGE, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x88DF8D0", Offset = "0x88DE4D0", VA = "0x1888DF8D0")]
	private static IEnumerator<FCPCPCAPDCM> AFNCDHNKBGM(DHBIPHECKBB GEFFMALAFGG, float FJLIIHLLAJI, GEPHJDONOHJ LJMMOFEBMGE, Action<float> DFEBMFPCKKN, bool ADPHOJOPGKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x88DFBA0", Offset = "0x88DE7A0", VA = "0x1888DFBA0")]
	[IteratorStateMachine(typeof(IDCMPJMBIEJ))]
	private static IEnumerator<FCPCPCAPDCM> GKOHALBKNNO(NJBMAEODDHN CBELPFGHIOI, float FJLIIHLLAJI, GEPHJDONOHJ LJMMOFEBMGE, Action<float> DFEBMFPCKKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class NOHDECLKIHK
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class EKBNJDBCLDI : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public GEPHJDONOHJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public EKBNJDBCLDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x88E0370", Offset = "0x88DEF70", VA = "0x1888E0370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x88E0430", Offset = "0x88DF030", VA = "0x1888E0430", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x88EA140", Offset = "0x88E8D40", VA = "0x1888EA140")]
	[IteratorStateMachine(typeof(EKBNJDBCLDI))]
	private static IEnumerator<FCPCPCAPDCM> PPHAIACPJEE(GEPHJDONOHJ OBNGFOLADNN, Func<bool> JIMAJCFJLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x88EA060", Offset = "0x88E8C60", VA = "0x1888EA060")]
	public static GCBFJNEKOIO ENJFKLNEEHA(this MonoBehaviour HBHJKEHGKLF, Func<bool> JIMAJCFJLFE, GEPHJDONOHJ OBNGFOLADNN = GEPHJDONOHJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EEFBFAHAILP
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class PGOALKFPLAF : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public GEPHJDONOHJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public PGOALKFPLAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x88EA800", Offset = "0x88E9400", VA = "0x1888EA800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x88EA870", Offset = "0x88E9470", VA = "0x1888EA870", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class ELFEJNJFIAO<T> : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public GEPHJDONOHJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public ELFEJNJFIAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x47391B0", Offset = "0x4737DB0", VA = "0x1847391B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4739230", Offset = "0x4737E30", VA = "0x184739230", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class AICFCOJFDNJ : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public GEPHJDONOHJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private FCPCPCAPDCM <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public AICFCOJFDNJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x88D4610", Offset = "0x88D3210", VA = "0x1888D4610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x88D46A0", Offset = "0x88D32A0", VA = "0x1888D46A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x88DF120", Offset = "0x88DDD20", VA = "0x1888DF120")]
	[IteratorStateMachine(typeof(PGOALKFPLAF))]
	private static IEnumerator<FCPCPCAPDCM> GPEDMKJBMGP(float KLCDLOHEBCJ, GEPHJDONOHJ LJMMOFEBMGE, Action PAGHHLHAGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3907550", Offset = "0x3906150", VA = "0x183907550")]
	[IteratorStateMachine(typeof(ELFEJNJFIAO<>))]
	private static IEnumerator<FCPCPCAPDCM> GPEDMKJBMGP<T>(float KLCDLOHEBCJ, GEPHJDONOHJ LJMMOFEBMGE, Action<T> PAGHHLHAGEE, T NOONBIFJDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x88DF080", Offset = "0x88DDC80", VA = "0x1888DF080")]
	[IteratorStateMachine(typeof(AICFCOJFDNJ))]
	private static IEnumerator<FCPCPCAPDCM> GNMHHKEHNCF(float KLCDLOHEBCJ, GEPHJDONOHJ LJMMOFEBMGE, Action PAGHHLHAGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x88DF490", Offset = "0x88DE090", VA = "0x1888DF490")]
	public static IDisposable LGIBJBPDMCG(this MonoBehaviour HBHJKEHGKLF, float KLCDLOHEBCJ, Action PAGHHLHAGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x88DF6B0", Offset = "0x88DE2B0", VA = "0x1888DF6B0")]
	public static GCBFJNEKOIO PBPFDDCDOLE(this MonoBehaviour HBHJKEHGKLF, float KLCDLOHEBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x88DF3A0", Offset = "0x88DDFA0", VA = "0x1888DF3A0")]
	public static GCBFJNEKOIO LGIBJBPDMCG(this MonoBehaviour HBHJKEHGKLF, float KLCDLOHEBCJ, GEPHJDONOHJ LJMMOFEBMGE, Action PAGHHLHAGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x88DF300", Offset = "0x88DDF00", VA = "0x1888DF300")]
	public static GCBFJNEKOIO LAPBIACJADD(this MonoBehaviour HBHJKEHGKLF, Action PAGHHLHAGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3907610", Offset = "0x3906210", VA = "0x183907610")]
	public static GCBFJNEKOIO LAPBIACJADD<T>(this MonoBehaviour HBHJKEHGKLF, Action<T> PAGHHLHAGEE, T NOONBIFJDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x88DEE10", Offset = "0x88DDA10", VA = "0x1888DEE10")]
	public static GCBFJNEKOIO AANODBLKBGN(this MonoBehaviour HBHJKEHGKLF, Action PAGHHLHAGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x88DF610", Offset = "0x88DE210", VA = "0x1888DF610")]
	public static GCBFJNEKOIO OIHHADDHIOK(this MonoBehaviour HBHJKEHGKLF, Action PAGHHLHAGEE, [Optional] IPNEFGFBDID KHIBKDLKLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x88DEFE0", Offset = "0x88DDBE0", VA = "0x1888DEFE0")]
	public static GCBFJNEKOIO FCEMECEBAOC(this MonoBehaviour HBHJKEHGKLF, Action PAGHHLHAGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x88DF740", Offset = "0x88DE340", VA = "0x1888DF740")]
	public static GCBFJNEKOIO POCIAFCCMNA(this MonoBehaviour HBHJKEHGKLF, Action PAGHHLHAGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x88DEF40", Offset = "0x88DDB40", VA = "0x1888DEF40")]
	public static GCBFJNEKOIO EEAOJNFFJAB(MonoBehaviour HBHJKEHGKLF, GEPHJDONOHJ OBNGFOLADNN, Action PAGHHLHAGEE, [Optional] IPNEFGFBDID KHIBKDLKLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3907420", Offset = "0x3906020", VA = "0x183907420")]
	public static GCBFJNEKOIO EEAOJNFFJAB<T>(MonoBehaviour HBHJKEHGKLF, GEPHJDONOHJ OBNGFOLADNN, Action<T> PAGHHLHAGEE, T NOONBIFJDPN, [Optional] IPNEFGFBDID KHIBKDLKLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x88DEEB0", Offset = "0x88DDAB0", VA = "0x1888DEEB0")]
	public static GCBFJNEKOIO DKEMDOIEHMO(this MonoBehaviour HBHJKEHGKLF, float AKLIKBPKKLM, Action PAGHHLHAGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x88DF260", Offset = "0x88DDE60", VA = "0x1888DF260")]
	public static GCBFJNEKOIO KOKGCJAMKOB(this MonoBehaviour HBHJKEHGKLF, float AKLIKBPKKLM, Action PAGHHLHAGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x88DF570", Offset = "0x88DE170", VA = "0x1888DF570")]
	public static GCBFJNEKOIO ODFLNAHMJCL(this MonoBehaviour HBHJKEHGKLF, float AKLIKBPKKLM, Action PAGHHLHAGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x88DF1C0", Offset = "0x88DDDC0", VA = "0x1888DF1C0")]
	public static GCBFJNEKOIO HDBNPKMDODG(this MonoBehaviour HBHJKEHGKLF, float AKLIKBPKKLM, Action PAGHHLHAGEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class AEHIOEINLPG : KAFBJENNCBI, IEnumerable<KAFBJENNCBI>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<KAFBJENNCBI> DKFICONGHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool OMMHOHOECII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Action GMPLMLAFKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool OICJJOLABIC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool POOELNHKJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x88D4160", Offset = "0x88D2D60", VA = "0x1888D4160", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action HPKNLDDKAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x88D3C90", Offset = "0x88D2890", VA = "0x1888D3C90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x88D3D30", Offset = "0x88D2930", VA = "0x1888D3D30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x88D4570", Offset = "0x88D3170", VA = "0x1888D4570")]
	public AEHIOEINLPG([Optional] Action GMPLMLAFKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x88D43E0", Offset = "0x88D2FE0", VA = "0x1888D43E0")]
	public void NKAMMCABBBC(KAFBJENNCBI DLGCNCPPPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x88D4290", Offset = "0x88D2E90", VA = "0x1888D4290")]
	private void LBLMLPOGHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x88D40D0", Offset = "0x88D2CD0", VA = "0x1888D40D0", Slot = "7")]
	public bool ENMCGEDHNPE(bool JMDCPKFBLOI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x88D3DD0", Offset = "0x88D29D0", VA = "0x1888D3DD0", Slot = "8")]
	public bool ENMCGEDHNPE(Action IFDCDCHOGGB, bool JMDCPKFBLOI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x88D40E0", Offset = "0x88D2CE0", VA = "0x1888D40E0", Slot = "9")]
	public IEnumerator<KAFBJENNCBI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x88D40E0", Offset = "0x88D2CE0", VA = "0x1888D40E0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MPAAJGGBNMI : FBHJLBMNKKF
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class MFCPINDCIAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public MPAAJGGBNMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MFCPINDCIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x88E0DC0", Offset = "0x88DF9C0", VA = "0x1888E0DC0")]
		internal void LLFDAALJEGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class FHNKLCHLMIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public MPAAJGGBNMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FHNKLCHLMIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x88E0DC0", Offset = "0x88DF9C0", VA = "0x1888E0DC0")]
		internal void BOCGJCNFHGG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly float KIEMKCGADDJ;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x88E1110", Offset = "0x88DFD10", VA = "0x1888E1110")]
	public MPAAJGGBNMI(Behaviour CBLPKFIJGLH, float KIEMKCGADDJ, [Optional] Action GMPLMLAFKHM, [Optional] IPNEFGFBDID KHIBKDLKLHO, [Optional] DHBIPHECKBB GEFFMALAFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x88E91A0", Offset = "0x88E7DA0", VA = "0x1888E91A0", Slot = "9")]
	protected override bool ALAADMKJFPK(Action IFDCDCHOGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x88E92B0", Offset = "0x88E7EB0", VA = "0x1888E92B0", Slot = "10")]
	protected override bool FOEKMONNGEJ(Action IFDCDCHOGGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface KAFBJENNCBI
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool POOELNHKJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HPKNLDDKAGD;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ENMCGEDHNPE(bool JMDCPKFBLOI = false);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ENMCGEDHNPE(Action IFDCDCHOGGB, bool JMDCPKFBLOI = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class FBHJLBMNKKF : KAFBJENNCBI
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class LMCONEJBNHO : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public FBHJLBMNKKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public LMCONEJBNHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x88E8630", Offset = "0x88E7230", VA = "0x1888E8630", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x88E8700", Offset = "0x88E7300", VA = "0x1888E8700", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Behaviour CBLPKFIJGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action GMPLMLAFKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private LKEMGHMAMLP NELDDFHGMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly IPNEFGFBDID KHIBKDLKLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	protected readonly DHBIPHECKBB GEFFMALAFGG;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool POOELNHKJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2410", Offset = "0x1BC1010", VA = "0x181BC2410", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action HPKNLDDKAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x88E0750", Offset = "0x88DF350", VA = "0x1888E0750", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x88E07F0", Offset = "0x88DF3F0", VA = "0x1888E07F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x88E0C90", Offset = "0x88DF890", VA = "0x1888E0C90")]
	protected FBHJLBMNKKF(Behaviour CBLPKFIJGLH, [Optional] Action GMPLMLAFKHM, [Optional] IPNEFGFBDID KHIBKDLKLHO, [Optional] DHBIPHECKBB GEFFMALAFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x88E08F0", Offset = "0x88DF4F0", VA = "0x1888E08F0", Slot = "7")]
	public bool ENMCGEDHNPE(bool JMDCPKFBLOI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x88E0890", Offset = "0x88DF490", VA = "0x1888E0890", Slot = "8")]
	public bool ENMCGEDHNPE(Action IFDCDCHOGGB, bool JMDCPKFBLOI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool ALAADMKJFPK(Action IFDCDCHOGGB);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool FOEKMONNGEJ(Action IFDCDCHOGGB);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x88E0C70", Offset = "0x88DF870", VA = "0x1888E0C70")]
	protected void KOLJGCLOPME(Action IFDCDCHOGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x88E0950", Offset = "0x88DF550", VA = "0x1888E0950")]
	protected AFMJGMMOLON FDEGOHKGLFJ(float PMNGLFBCFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x88E06D0", Offset = "0x88DF2D0", VA = "0x1888E06D0")]
	private void ACFDAJAMCCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x88E0BE0", Offset = "0x88DF7E0", VA = "0x1888E0BE0")]
	[IteratorStateMachine(typeof(LMCONEJBNHO))]
	private IEnumerator<FCPCPCAPDCM> HDBJPOIEIAA(float PMNGLFBCFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x88E0BA0", Offset = "0x88DF7A0", VA = "0x1888E0BA0")]
	[CompilerGenerated]
	private void FKJHPMDAAFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class NPFEHHOEHCH : FBHJLBMNKKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly float HHGKIIMDEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly int GJIOFNNIFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly float KHDOMJNJHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly float[] PEGONDNFBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int JIIGGDIAJLH;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x88EA450", Offset = "0x88E9050", VA = "0x1888EA450")]
	public NPFEHHOEHCH(Behaviour CBLPKFIJGLH, float KKPNHBCFFJL, int GJIOFNNIFKJ, [Optional] Action GMPLMLAFKHM, float KHDOMJNJHBK = 0f, [Optional] IPNEFGFBDID KHIBKDLKLHO, [Optional] DHBIPHECKBB GEFFMALAFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "9")]
	protected override bool ALAADMKJFPK(Action IFDCDCHOGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x88EA1D0", Offset = "0x88E8DD0", VA = "0x1888EA1D0", Slot = "10")]
	protected override bool FOEKMONNGEJ(Action IFDCDCHOGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x88EA3D0", Offset = "0x88E8FD0", VA = "0x1888EA3D0")]
	private void MHPCMJFCAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class GDAMNHLOKAG : FBHJLBMNKKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly float KIEMKCGADDJ;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x88E1110", Offset = "0x88DFD10", VA = "0x1888E1110")]
	public GDAMNHLOKAG(Behaviour CBLPKFIJGLH, float KIEMKCGADDJ, [Optional] Action GMPLMLAFKHM, [Optional] IPNEFGFBDID KHIBKDLKLHO, [Optional] DHBIPHECKBB GEFFMALAFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "9")]
	protected override bool ALAADMKJFPK(Action IFDCDCHOGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x88E10D0", Offset = "0x88DFCD0", VA = "0x1888E10D0", Slot = "10")]
	protected override bool FOEKMONNGEJ(Action IFDCDCHOGGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class KPLHPCBPBMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class KEJIJJMAFID : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public KEJIJJMAFID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x88E0480", Offset = "0x88DF080", VA = "0x1888E0480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x88E6CA0", Offset = "0x88E58A0", VA = "0x1888E6CA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private GCBFJNEKOIO EIFALMHNKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private OHAAOAKGENJ CBLPKFIJGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Action<float> NEJOPBBJKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private GEPHJDONOHJ OBNGFOLADNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private float IDPPKLIIDNM;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x88E8320", Offset = "0x88E6F20", VA = "0x1888E8320")]
	public KPLHPCBPBMD(OHAAOAKGENJ CBLPKFIJGLH, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x88E7E80", Offset = "0x88E6A80", VA = "0x1888E7E80")]
	private void EIIDBLFDEOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x88E8070", Offset = "0x88E6C70", VA = "0x1888E8070")]
	private void JLINBDPKJHE(string AJLIMPCCGHB, Action ONAJKMEFNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x88E7FF0", Offset = "0x88E6BF0", VA = "0x1888E7FF0")]
	[IteratorStateMachine(typeof(KEJIJJMAFID))]
	private IEnumerator<FCPCPCAPDCM> HCNMMCCJBFB(Action ONAJKMEFNEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x88E7E20", Offset = "0x88E6A20", VA = "0x1888E7E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x88E81A0", Offset = "0x88E6DA0", VA = "0x1888E81A0")]
	[CompilerGenerated]
	private void MKCNACOFDCC(string FCEJBDLGOKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class BMLONMHAEIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class ELBEFKNIECN : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public ELBEFKNIECN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x88E0480", Offset = "0x88DF080", VA = "0x1888E0480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x88E04F0", Offset = "0x88DF0F0", VA = "0x1888E04F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private GCBFJNEKOIO EIFALMHNKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private MonoBehaviour HBHJKEHGKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Action DFEBMFPCKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Action<float> NEJOPBBJKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private GEPHJDONOHJ OBNGFOLADNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float IDPPKLIIDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool ADPHOJOPGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly IPNEFGFBDID KHIBKDLKLHO;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x88D69C0", Offset = "0x88D55C0", VA = "0x1888D69C0")]
	public BMLONMHAEIE(MonoBehaviour HBHJKEHGKLF, Action DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, [Optional] IPNEFGFBDID KHIBKDLKLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x88D6B50", Offset = "0x88D5750", VA = "0x1888D6B50")]
	public BMLONMHAEIE(MonoBehaviour HBHJKEHGKLF, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, [Optional] IPNEFGFBDID KHIBKDLKLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x88D67E0", Offset = "0x88D53E0", VA = "0x1888D67E0")]
	public BMLONMHAEIE(MonoBehaviour HBHJKEHGKLF, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, bool ADPHOJOPGKO = true, [Optional] IPNEFGFBDID KHIBKDLKLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4DF4A20", Offset = "0x4DF3620", VA = "0x184DF4A20")]
	private BMLONMHAEIE(IPNEFGFBDID KHIBKDLKLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x88D6520", Offset = "0x88D5120", VA = "0x1888D6520")]
	internal static BMLONMHAEIE MOLAKIAMKKC(MonoBehaviour HBHJKEHGKLF, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, GEPHJDONOHJ OBNGFOLADNN, bool ADPHOJOPGKO = true, [Optional] IPNEFGFBDID KHIBKDLKLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x88D5BB0", Offset = "0x88D47B0", VA = "0x1888D5BB0")]
	private void AODADJNGGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x88D5CE0", Offset = "0x88D48E0", VA = "0x1888D5CE0")]
	private void DLHNIGHMMEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x88D5EC0", Offset = "0x88D4AC0", VA = "0x1888D5EC0")]
	private void EIIDBLFDEOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x88D6300", Offset = "0x88D4F00", VA = "0x1888D6300")]
	private void KKPOEAKJFMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x88D6140", Offset = "0x88D4D40", VA = "0x1888D6140")]
	private void JLINBDPKJHE(string AJLIMPCCGHB, Action ONAJKMEFNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x88D60C0", Offset = "0x88D4CC0", VA = "0x1888D60C0")]
	[IteratorStateMachine(typeof(ELBEFKNIECN))]
	private IEnumerator<FCPCPCAPDCM> HCNMMCCJBFB(Action ONAJKMEFNEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x88D5E60", Offset = "0x88D4A60", VA = "0x1888D5E60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x88D6490", Offset = "0x88D5090", VA = "0x1888D6490")]
	[CompilerGenerated]
	private void KPBDLPLLHKN(string FCEJBDLGOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x88D6270", Offset = "0x88D4E70", VA = "0x1888D6270")]
	[CompilerGenerated]
	private void KAOFJFLDJAO(string FCEJBDLGOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x88D6750", Offset = "0x88D5350", VA = "0x1888D6750")]
	[CompilerGenerated]
	private void PGLCFEAGGNA(string FCEJBDLGOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x88D6030", Offset = "0x88D4C30", VA = "0x1888D6030")]
	[CompilerGenerated]
	private void FJLCFICHJGE(string FCEJBDLGOKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum AEANELELPJC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class CKLFPEDKHBB : DHBIPHECKBB
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float DOCMGEGHDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x88D7560", Offset = "0x88D6160", VA = "0x1888D7560", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float KPDCEEACEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x88D7570", Offset = "0x88D6170", VA = "0x1888D7570", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public double AHBHFOBMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x88D7580", Offset = "0x88D6180", VA = "0x1888D7580", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x88D74F0", Offset = "0x88D60F0", VA = "0x1888D74F0")]
	[IGNGJLOKDFM.EEFPBBAIHAI]
	internal static void BACILHPJJBN(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	[UnityEngine.Scripting.Preserve]
	internal CKLFPEDKHBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface AIGKLMEGAAA
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFOOJFOCODD(string LAOCJKNALFF);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFDHDEJLIMF();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface IJEDJBNNHFN
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string AJPMCBKCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool LMKOJHJBBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool LOHACKGDPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class CJLNBPEBJHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public DFBHOHADBBL CBJCBDEECFH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int FCJKCAOMEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA20EC0", Offset = "0xA1FAC0", VA = "0x180A20EC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x88D7390", Offset = "0x88D5F90", VA = "0x1888D7390")]
	public static FCPCPCAPDCM ONILNKOLGEB(IEnumerator<FCPCPCAPDCM> BLDKOOJADNH, BFFCMDJIKGB IMCMOLJBMFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x88D72D0", Offset = "0x88D5ED0", VA = "0x1888D72D0")]
	public FCPCPCAPDCM ONILNKOLGEB(BFFCMDJIKGB[] NOBJKHPODMB, IEnumerator<FCPCPCAPDCM>[] DHKKNJFHDJO, FCPCPCAPDCM[] LLKFEGONODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x88D7160", Offset = "0x88D5D60", VA = "0x1888D7160")]
	public void NGJOHLCOAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x88D7190", Offset = "0x88D5D90", VA = "0x1888D7190")]
	public void MGMFIGFGNHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x88D7020", Offset = "0x88D5C20", VA = "0x1888D7020")]
	public void DFPIAGAIGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x88D7160", Offset = "0x88D5D60", VA = "0x1888D7160")]
	public void LEAINMHIBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public CJLNBPEBJHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class DFBHOHADBBL
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct HALGDMEKNFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CJLNBPEBJHJ KGPGAOAGIBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public OHAAOAKGENJ AKIOFALGPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public BFFCMDJIKGB FIGBOILBPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public IEnumerator<FCPCPCAPDCM> BGAAMJNNMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FCPCPCAPDCM HGCINPCHCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AEANELELPJC BMIDKFLKBPO;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct HNJJACIOJLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public GEPHJDONOHJ OGGOOFLBCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public List<HALGDMEKNFJ> FFBLJDIIPBK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class ANCPFGGLDGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public BFFCMDJIKGB promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public DFBHOHADBBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public OHAAOAKGENJ context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public CJLNBPEBJHJ routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AEANELELPJC coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public FCPCPCAPDCM currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public IEnumerator<FCPCPCAPDCM> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ANCPFGGLDGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x88D46F0", Offset = "0x88D32F0", VA = "0x1888D46F0")]
		internal void GMDOEILDKLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class KNKMGOMMLLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public CJLNBPEBJHJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public DFBHOHADBBL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KNKMGOMMLLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x88E7DE0", Offset = "0x88E69E0", VA = "0x1888E7DE0")]
		internal void ECOLJPNEGBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class LFLCJOMMKEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CJLNBPEBJHJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public DFBHOHADBBL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LFLCJOMMKEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x88E84C0", Offset = "0x88E70C0", VA = "0x1888E84C0")]
		internal void FNJFLAANEFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class DIPCCNDOJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public CJLNBPEBJHJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public DFBHOHADBBL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public DIPCCNDOJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x88DE400", Offset = "0x88DD000", VA = "0x1888DE400")]
		internal void PGMEIKIPLLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private const AEANELELPJC DLFEPIEFKHP = AEANELELPJC.Cancelled | AEANELELPJC.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly GEPHJDONOHJ OBNGFOLADNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool[] PHHACBNGGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private NativeArray<AEANELELPJC> PPBNHIIAGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NativeArray<float> KKNJOFFBBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private NativeArray<int> GAANGIAAPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private NativeArray<int> AGEKICGIBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private NativeArray<int> NNJGIMAICIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NativeArray<int> BPAGPAKMIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private NativeArray<int> AAJHOJPBGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private CJLNBPEBJHJ[] DOACNLOEGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private BFFCMDJIKGB[] NOBJKHPODMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private OHAAOAKGENJ[] OBEGMPEJKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private IEnumerator<FCPCPCAPDCM>[] OEPLMEHOCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private FCPCPCAPDCM[] OKIAGLPHAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int MKILOGBJGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int PDJAEHLNOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly int NAFCJAHNOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private float BPNOMBIJLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private MEAMAFCOHOC LFBNHILJIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private JobHandle CMFCEMJILNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private List<CJLNBPEBJHJ> JLGDHEAJBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool BHOMLJNLEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private List<Action> AKOKOCHNGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> FLMEMJKLMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool OPMDAHGEIHA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public HNJJACIOJLP[] BKCAAGJMJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xB50460", Offset = "0xB4F060", VA = "0x180B50460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x88DC870", Offset = "0x88DB470", VA = "0x1888DC870")]
	private static int FLMLJOHDIMO(GEPHJDONOHJ OBNGFOLADNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x88DDDB0", Offset = "0x88DC9B0", VA = "0x1888DDDB0")]
	public DFBHOHADBBL(GEPHJDONOHJ OBNGFOLADNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x88DC8A0", Offset = "0x88DB4A0", VA = "0x1888DC8A0")]
	private void HDLBBLBIHNC(int MJNLKLOCJAM, int OFIBPADMOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x88DCB00", Offset = "0x88DB700", VA = "0x1888DCB00")]
	public void IHDBLLJAOAJ(OHAAOAKGENJ CBLPKFIJGLH, FCPCPCAPDCM GOLOJJNGGLG, IEnumerator<FCPCPCAPDCM> BLDKOOJADNH, BFFCMDJIKGB IMCMOLJBMFN, [Optional] CJLNBPEBJHJ LPFAOPGOLOP, AEANELELPJC LCFKPOKJHBE = AEANELELPJC.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x88DD7E0", Offset = "0x88DC3E0", VA = "0x1888DD7E0")]
	public void MNKKDLLNIJE(IEnumerable<HALGDMEKNFJ> OIKCDPLIHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x88DCC80", Offset = "0x88DB880", VA = "0x1888DCC80")]
	private HALGDMEKNFJ ILBHHDJAACM(int GHNAJLCENOJ)
	{
		return default(HALGDMEKNFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x88DBA30", Offset = "0x88DA630", VA = "0x1888DBA30")]
	private void BNHGOIEMLJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x38E4E40", Offset = "0x38E3A40", VA = "0x1838E4E40")]
	private static void LNJLDIGPFOP<T>(int GHNAJLCENOJ, T[] IMDOBFNCEPL, int DKFJGBGJGBG, [Optional] T KCDMNFKHOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x38E4E90", Offset = "0x38E3A90", VA = "0x1838E4E90")]
	private static void LNJLDIGPFOP<T>(int GHNAJLCENOJ, NativeArray<T> IMDOBFNCEPL, int DKFJGBGJGBG, [Optional] T KCDMNFKHOBE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x88DDA20", Offset = "0x88DC620", VA = "0x1888DDA20")]
	private void OELIALLLOIP(IEnumerable<HALGDMEKNFJ> OIKCDPLIHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x88DBDA0", Offset = "0x88DA9A0", VA = "0x1888DBDA0")]
	private void BODLKCGKLPH(HALGDMEKNFJ EHEIHODJJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x88DD150", Offset = "0x88DBD50", VA = "0x1888DD150")]
	private CCHIEOOAEJF JPOPBGLLCPO(int ANMHHOMKDNP)
	{
		return default(CCHIEOOAEJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x88DD5E0", Offset = "0x88DC1E0", VA = "0x1888DD5E0")]
	public void MHBFIPDKIBH(float CHNONDHAGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x88DBE70", Offset = "0x88DAA70", VA = "0x1888DBE70")]
	private void BOMEFMFHJEF(Action ABBBJFPFEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x88DCA80", Offset = "0x88DB680", VA = "0x1888DCA80")]
	private void HNMGNBPKHDI(Action ABBBJFPFEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x88DC150", Offset = "0x88DAD50", VA = "0x1888DC150")]
	public void FCEAGJAJONC(float CHNONDHAGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x88DD3B0", Offset = "0x88DBFB0", VA = "0x1888DD3B0")]
	public void LDCCMKMJIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x88DD4B0", Offset = "0x88DC0B0", VA = "0x1888DD4B0")]
	public void LEAINMHIBHD(CJLNBPEBJHJ CBELPFGHIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x88DC020", Offset = "0x88DAC20", VA = "0x1888DC020")]
	public void CPAMPFHGGFK(CJLNBPEBJHJ CBELPFGHIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x88DBEF0", Offset = "0x88DAAF0", VA = "0x1888DBEF0")]
	public void CCGPFILCBCP(CJLNBPEBJHJ CBELPFGHIOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class GCJCOGCBCAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly GCJCOGCBCAH LELJIFADAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly Action MCMBPBIMNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private bool OCBGCPNOEJE;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public GCJCOGCBCAH(Action MCMBPBIMNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C340", Offset = "0x7F2AF40", VA = "0x187F2C340", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface PLFGEAAHHNJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable LHIBBMJFOAM(UnityEngine.Object CBLPKFIJGLH, Action<T> PDAOIIDFCLN);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface MDDOKJCGGFK<T> : PLFGEAAHHNJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	new T IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class AFPMNNIGNCD<T> : MDDOKJCGGFK<T>, PLFGEAAHHNJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class KCALEIOAJDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public AFPMNNIGNCD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public MOCPDNLEKIK<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KCALEIOAJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x51CCB70", Offset = "0x51CB770", VA = "0x1851CCB70")]
		internal void KLJCMBECIGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static GameObject IENGKPHCGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly List<MOCPDNLEKIK<UnityEngine.Object, Action<T>>> OGMPAECHPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private T ODNFHFLAFOB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA6B040", Offset = "0xA69C40", VA = "0x180A6B040", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4D64770", Offset = "0x4D63370", VA = "0x184D64770", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4D640D0", Offset = "0x4D62CD0", VA = "0x184D640D0")]
	private static bool DDBBNLDGEGK(T ABBBJFPFEKP, T KLKIJPOLHDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4D64C10", Offset = "0x4D63810", VA = "0x184D64C10")]
	public AFPMNNIGNCD(T IEPFBBNOGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4D649E0", Offset = "0x4D635E0", VA = "0x184D649E0", Slot = "6")]
	public IDisposable LHIBBMJFOAM(UnityEngine.Object CBLPKFIJGLH, Action<T> PDAOIIDFCLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4D64480", Offset = "0x4D63080", VA = "0x184D64480")]
	private void EOCLHBOKNFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class JEOPIFBPFDO : OBEILBEGJHN
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private class MOFEGKJEOEB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		private class NKAODJBHFHN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private int ALPNKEJICNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private MOFEGKJEOEB LJMMOFEBMGE;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xF69A80", Offset = "0xF68680", VA = "0x180F69A80")]
			public NKAODJBHFHN(int ALPNKEJICNA, MOFEGKJEOEB LJMMOFEBMGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x88E9C60", Offset = "0x88E8860", VA = "0x1888E9C60", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class KNFGNDEABPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public KNFGNDEABPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAA0", Offset = "0xAAD6A0", VA = "0x180AAEAA0")]
			internal bool BPJAJLFFBIA(MPGGDNALLBA e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class GGAIBPKDMGF : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private FCPCPCAPDCM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public MOFEGKJEOEB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public DHBIPHECKBB timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			private JIGHMKGKIBE <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private List<MPGGDNALLBA> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
			[DebuggerHidden]
			public GGAIBPKDMGF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x88E1250", Offset = "0x88DFE50", VA = "0x1888E1250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x88E1580", Offset = "0x88E0180", VA = "0x1888E1580", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly GEPHJDONOHJ OBNGFOLADNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private GCBFJNEKOIO IMCMOLJBMFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly List<MPGGDNALLBA> CAPOGHJBIAH;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x88E9100", Offset = "0x88E7D00", VA = "0x1888E9100")]
		public MOFEGKJEOEB(GEPHJDONOHJ OBNGFOLADNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x88E8D00", Offset = "0x88E7900", VA = "0x1888E8D00")]
		public IDisposable EGJHNMCELGP(MPGGDNALLBA EMGGBMKCHNB, IPNEFGFBDID KHIBKDLKLHO, DHBIPHECKBB KDCDPEHJICI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x88E8F70", Offset = "0x88E7B70", VA = "0x1888E8F70")]
		private void NNDICELHEHI(int ALPNKEJICNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x88E8EE0", Offset = "0x88E7AE0", VA = "0x1888E8EE0")]
		[IteratorStateMachine(typeof(GGAIBPKDMGF))]
		private IEnumerator<FCPCPCAPDCM> MJMEBGGPPEN(DHBIPHECKBB KDCDPEHJICI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x88E8CB0", Offset = "0x88E78B0", VA = "0x1888E8CB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class MPGGDNALLBA
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public enum FNICCHAJIDI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static int OJLBFHEDOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly int PAAINMNNDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly MIGNIEJDGMD AKIOFALGPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly MonoBehaviour BIJBIBEECAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly Action NJCBLGMIGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly Action<float> KFFHFAHBDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly float FEBPJOBJCGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public float KKNJOFFBBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public readonly string AJPMCBKCCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public readonly bool KABDNONOLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly FNICCHAJIDI MCIHFCHOAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool NBABDHNMAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public bool GONAJCDKCHD;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x88E98F0", Offset = "0x88E84F0", VA = "0x1888E98F0")]
		public MPGGDNALLBA(MIGNIEJDGMD CBLPKFIJGLH, Action DFEBMFPCKKN, bool JKIOAAKPNGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x88E9590", Offset = "0x88E8190", VA = "0x1888E9590")]
		public MPGGDNALLBA(MIGNIEJDGMD CBLPKFIJGLH, Action<float> DFEBMFPCKKN, bool JKIOAAKPNGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x88E9710", Offset = "0x88E8310", VA = "0x1888E9710")]
		public MPGGDNALLBA(MIGNIEJDGMD CBLPKFIJGLH, float FJLIIHLLAJI, Action<float> DFEBMFPCKKN, DHBIPHECKBB KDCDPEHJICI, FNICCHAJIDI EHFMKAPJLMD, bool ADPHOJOPGKO, bool JKIOAAKPNGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x88E93C0", Offset = "0x88E7FC0", VA = "0x1888E93C0")]
		public bool OGBFDHKCJOA(float COICELPPBEA, float IOBMCBBJIBD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly IPNEFGFBDID KHIBKDLKLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly DHBIPHECKBB GEFFMALAFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly Dictionary<GEPHJDONOHJ, MOFEGKJEOEB> KFHBGKFLMCJ;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x88E5E70", Offset = "0x88E4A70", VA = "0x1888E5E70")]
	[IGNGJLOKDFM.EEFPBBAIHAI]
	internal static void DPCDEJIMPBK(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x88E6840", Offset = "0x88E5440", VA = "0x1888E6840")]
	[UnityEngine.Scripting.Preserve]
	internal JEOPIFBPFDO([GFNPNOLPMKK(null)] IPNEFGFBDID KHIBKDLKLHO, [GFNPNOLPMKK(null)] DHBIPHECKBB GEFFMALAFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x88E6650", Offset = "0x88E5250", VA = "0x1888E6650", Slot = "4")]
	public IDisposable NJCBLGMIGNH(MIGNIEJDGMD CBLPKFIJGLH, Action LKGGIMHKLEG, GEPHJDONOHJ OBNGFOLADNN, bool JKIOAAKPNGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x88E6460", Offset = "0x88E5060", VA = "0x1888E6460", Slot = "5")]
	public IDisposable NJCBLGMIGNH(MIGNIEJDGMD CBLPKFIJGLH, Action<float> LKGGIMHKLEG, GEPHJDONOHJ OBNGFOLADNN, bool JKIOAAKPNGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x88E61A0", Offset = "0x88E4DA0", VA = "0x1888E61A0", Slot = "7")]
	public IDisposable LHLKIDHNGDM(MIGNIEJDGMD CBLPKFIJGLH, float FJLIIHLLAJI, Action<float> LKGGIMHKLEG, GEPHJDONOHJ OBNGFOLADNN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x88E5D70", Offset = "0x88E4970", VA = "0x1888E5D70", Slot = "8")]
	public IDisposable CPBOEIHNCKJ(MIGNIEJDGMD CBLPKFIJGLH, float FJLIIHLLAJI, Action<float> LKGGIMHKLEG, GEPHJDONOHJ OBNGFOLADNN, bool ADPHOJOPGKO = true, bool JKIOAAKPNGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x88E6020", Offset = "0x88E4C20", VA = "0x1888E6020", Slot = "6")]
	public IDisposable LHLKIDHNGDM(float FJLIIHLLAJI, Action<float> LKGGIMHKLEG, bool ADPHOJOPGKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x88E62A0", Offset = "0x88E4EA0", VA = "0x1888E62A0", Slot = "9")]
	public void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x88E5EE0", Offset = "0x88E4AE0", VA = "0x1888E5EE0")]
	private MOFEGKJEOEB HMDDJNOPMBB(GEPHJDONOHJ OBNGFOLADNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KLKMECOFDGJ : JBMGJHAJOEP, IPNEFGFBDID, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private DFBHOHADBBL[] FBBFAKDHNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private AIGKLMEGAAA BOABCIJPJAJ;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x88E70B0", Offset = "0x88E5CB0", VA = "0x1888E70B0")]
	[IGNGJLOKDFM.EEFPBBAIHAI]
	internal static void BACILHPJJBN(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x88E7D20", Offset = "0x88E6920", VA = "0x1888E7D20")]
	[UnityEngine.Scripting.Preserve]
	public KLKMECOFDGJ([GFNPNOLPMKK(null)] IPLLKNIPHEG EFNGLAJDDOK, [GFNPNOLPMKK(null)] DHBIPHECKBB GEFFMALAFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x88E7180", Offset = "0x88E5D80", VA = "0x1888E7180", Slot = "19")]
	public override GCBFJNEKOIO FAGAJDDJLGL(OHAAOAKGENJ CBLPKFIJGLH, IEnumerator<FCPCPCAPDCM> KHKKNEGCAOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x88E78F0", Offset = "0x88E64F0", VA = "0x1888E78F0", Slot = "20")]
	public override void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x88E72B0", Offset = "0x88E5EB0", VA = "0x1888E72B0", Slot = "22")]
	public override void HLBJILOHPID(GEPHJDONOHJ OBNGFOLADNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x88E7B80", Offset = "0x88E6780", VA = "0x1888E7B80", Slot = "21")]
	protected override void NJCBLGMIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x88E7CF0", Offset = "0x88E68F0", VA = "0x1888E7CF0")]
	private DFBHOHADBBL POFBOEJHMPL(GEPHJDONOHJ OPOPAMPKKGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x88E75A0", Offset = "0x88E61A0", VA = "0x1888E75A0", Slot = "23")]
	internal override AOFCGDPPINL JEALHNAMOJF(IEnumerator<FCPCPCAPDCM> KHKKNEGCAOM, Behaviour CBLPKFIJGLH, BFFCMDJIKGB IMCMOLJBMFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x88E74E0", Offset = "0x88E60E0", VA = "0x1888E74E0", Slot = "24")]
	internal override IDJBBNCEMAA JDMHHPBLFLC(GEPHJDONOHJ LJMMOFEBMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x88E77D0", Offset = "0x88E63D0", VA = "0x1888E77D0")]
	private void KCHLILDJFLM(DFBHOHADBBL CLIOFDHGCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x88E7120", Offset = "0x88E5D20", VA = "0x1888E7120", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[BurstCompile]
internal struct MEAMAFCOHOC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	[ReadOnly]
	public float KIHMBCLMGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	[ReadOnly]
	public int DIJDGJGGDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private NativeArray<int> EPADMDMCIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private NativeArray<int> FAOGLCFJFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private NativeArray<int> JNBECECCFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	[ReadOnly]
	public NativeArray<AEANELELPJC> PBALJBJOLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[ReadOnly]
	public NativeArray<float> IHKMEIJBOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	[WriteOnly]
	public NativeArray<int> NNJGIMAICIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	[WriteOnly]
	public NativeArray<int> GAANGIAAPLF;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x88E8870", Offset = "0x88E7470", VA = "0x1888E8870")]
	public static MEAMAFCOHOC GLOMJONEBBE(int DFNIDBEDDOM, float CHNONDHAGOC, NativeArray<AEANELELPJC> GHPIECCAHLP, NativeArray<float> FIJDPKDONIE, NativeArray<int> CBPAFAGBGIJ, NativeArray<int> FEGHBMJFLHI, NativeArray<int> BAGIINMCIOL, NativeArray<int> FAOGLCFJFIM, NativeArray<int> JNBECECCFJG)
	{
		return default(MEAMAFCOHOC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x88E8790", Offset = "0x88E7390", VA = "0x1888E8790", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x88E8750", Offset = "0x88E7350", VA = "0x1888E8750")]
	private bool ECBNEMIGOBP(int EMMACFPOKFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x88E8A40", Offset = "0x88E7640", VA = "0x1888E8A40")]
	private void JCJCOALFFDI(NativeArray<int> FDMCBAIJLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x88E88D0", Offset = "0x88E74D0", VA = "0x1888E88D0")]
	private int HCNBBIAKHGO(int NANAAPFBDAD, int LOKBJFEHFLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x88E8970", Offset = "0x88E7570", VA = "0x1888E8970")]
	private void IEALMDHHION(NativeArray<int> FDMCBAIJLPI, int JKKGKGJFPFC, int DGCKGHIBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x88E8A70", Offset = "0x88E7670", VA = "0x1888E8A70")]
	private void NIILMCJECNN(NativeArray<int> FDMCBAIJLPI, int BMOGKAIIGLB, int LIIJFEKGHDF, int CAPHCACAPIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class JBMGJHAJOEP : IPNEFGFBDID, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly IPLLKNIPHEG EFNGLAJDDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	protected readonly DHBIPHECKBB GEFFMALAFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private IDJBBNCEMAA[] PNFGENAJKDK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static IPNEFGFBDID LBPNLDGACAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x88E4920", Offset = "0x88E3520", VA = "0x1888E4920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool PPEBHELAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GEPHJDONOHJ LEFNBPPKMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GEPHJDONOHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA20EC0", Offset = "0xA1FAC0", VA = "0x180A20EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public DHBIPHECKBB GNCBODDDAJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FCPCPCAPDCM COGDHOLOCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public FCPCPCAPDCM EHGOFLMFCFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA24670", Offset = "0xA23270", VA = "0x180A24670", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public FCPCPCAPDCM HHPGIKGLDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FCPCPCAPDCM LAEFDPHCFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6A0", Offset = "0xA1B2A0", VA = "0x180A1C6A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x88E5790", Offset = "0x88E4390", VA = "0x1888E5790")]
	public static GCBFJNEKOIO PAPADAODDCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x88E5880", Offset = "0x88E4480", VA = "0x1888E5880")]
	[UnityEngine.Scripting.Preserve]
	protected JBMGJHAJOEP([GFNPNOLPMKK(null)] IPLLKNIPHEG EFNGLAJDDOK, [GFNPNOLPMKK(null)] DHBIPHECKBB GEFFMALAFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x88E5210", Offset = "0x88E3E10", VA = "0x1888E5210", Slot = "6")]
	public GCBFJNEKOIO KNAKIDBGLNI(IEnumerator<FCPCPCAPDCM> KHKKNEGCAOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x88E5010", Offset = "0x88E3C10", VA = "0x1888E5010", Slot = "7")]
	public GCBFJNEKOIO KNAKIDBGLNI(Behaviour CBLPKFIJGLH, IEnumerator<FCPCPCAPDCM> KHKKNEGCAOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract GCBFJNEKOIO FAGAJDDJLGL(OHAAOAKGENJ CBLPKFIJGLH, IEnumerator<FCPCPCAPDCM> KHKKNEGCAOM);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x88E5520", Offset = "0x88E4120", VA = "0x1888E5520", Slot = "20")]
	public virtual void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x88E5280", Offset = "0x88E3E80", VA = "0x1888E5280", Slot = "9")]
	public void LMIKOGBEPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x88E56E0", Offset = "0x88E42E0", VA = "0x1888E56E0", Slot = "21")]
	protected virtual void NJCBLGMIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x88E4990", Offset = "0x88E3590", VA = "0x1888E4990")]
	private void BNPEIKKIJJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x88E56C0", Offset = "0x88E42C0", VA = "0x1888E56C0")]
	private void NHMBCMEPPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x88E4D90", Offset = "0x88E3990", VA = "0x1888E4D90")]
	private void FJIEHIADHLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x88E5220", Offset = "0x88E3E20", VA = "0x1888E5220")]
	private void LDHLHECGDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x88E49B0", Offset = "0x88E35B0", VA = "0x1888E49B0")]
	private void CBCCCJOHLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x88E5260", Offset = "0x88E3E60", VA = "0x1888E5260")]
	private void LMDGEDFEGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x88E5240", Offset = "0x88E3E40", VA = "0x1888E5240")]
	private void LIOFCNGDGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x88E4DB0", Offset = "0x88E39B0", VA = "0x1888E4DB0", Slot = "22")]
	public virtual void HLBJILOHPID(GEPHJDONOHJ OBNGFOLADNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x88E4E40", Offset = "0x88E3A40", VA = "0x1888E4E40")]
	private void JAIAAOGNEKB(IDJBBNCEMAA CLIOFDHGCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x27F5D40", Offset = "0x27F4940", VA = "0x1827F5D40")]
	private IDJBBNCEMAA IJNNANOHLFF(GEPHJDONOHJ OPOPAMPKKGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract AOFCGDPPINL JEALHNAMOJF(IEnumerator<FCPCPCAPDCM> KHKKNEGCAOM, Behaviour HBHJKEHGKLF, BFFCMDJIKGB MHAHEKBMBNM);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract IDJBBNCEMAA JDMHHPBLFLC(GEPHJDONOHJ OBNGFOLADNN);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x88E49D0", Offset = "0x88E35D0", VA = "0x1888E49D0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x88E5820", Offset = "0x88E4420", VA = "0x1888E5820", Slot = "15")]
	public FCPCPCAPDCM PNJHPNALDMG(GEPHJDONOHJ LJMMOFEBMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x88E5700", Offset = "0x88E4300", VA = "0x1888E5700", Slot = "16")]
	public FCPCPCAPDCM ONJIPNHOLPP(float KLCDLOHEBCJ, GEPHJDONOHJ LJMMOFEBMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x88E54C0", Offset = "0x88E40C0", VA = "0x1888E54C0", Slot = "17")]
	public FCPCPCAPDCM NFBBCAPHEHB(Func<bool> JIMAJCFJLFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class AOFCGDPPINL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly BFFCMDJIKGB IMCMOLJBMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly IJEDJBNNHFN CBLPKFIJGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly bool JPFKFAHDBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private string LAOCJKNALFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private StackTrace IIGNHDFGFCK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerator<FCPCPCAPDCM> BGAAMJNNMMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FCPCPCAPDCM HGCINPCHCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool AHBMINOCDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x88D4F30", Offset = "0x88D3B30", VA = "0x1888D4F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool IAFAOJPHJFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xCBAD60", Offset = "0xCB9960", VA = "0x180CBAD60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xCEF8C0", Offset = "0xCEE4C0", VA = "0x180CEF8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string AJPMCBKCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x88D5000", Offset = "0x88D3C00", VA = "0x1888D5000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float CDPJCPKDFPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xE24770", Offset = "0xE23370", VA = "0x180E24770")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xE24780", Offset = "0xE23380", VA = "0x180E24780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x88D55B0", Offset = "0x88D41B0", VA = "0x1888D55B0")]
	public AOFCGDPPINL(IEnumerator<FCPCPCAPDCM> BLDKOOJADNH, IJEDJBNNHFN CBLPKFIJGLH, BFFCMDJIKGB IMCMOLJBMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x88D51B0", Offset = "0x88D3DB0", VA = "0x1888D51B0")]
	public FCPCPCAPDCM ONILNKOLGEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x88D4EC0", Offset = "0x88D3AC0", VA = "0x1888D4EC0")]
	public bool FJKOJHCPGKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x88D4FB0", Offset = "0x88D3BB0", VA = "0x1888D4FB0")]
	public void LEAINMHIBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x88D54D0", Offset = "0x88D40D0", VA = "0x1888D54D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38A50", VA = "0x180D39E50")]
	[CompilerGenerated]
	private void LGOENINGFDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class BFFCMDJIKGB : HMMOILLMCHC, GCBFJNEKOIO, LKEMGHMAMLP, AFMJGMMOLON, IEnumerator, FCPCPCAPDCM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private GEPHJDONOHJ IGIMHFNAPDA;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private GEPHJDONOHJ EIAELMHHOED
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA9A070", Offset = "0xA98C70", VA = "0x180A9A070", Slot = "23")]
		get
		{
			return default(GEPHJDONOHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public GEPHJDONOHJ CBJCBDEECFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xFB17A0", Offset = "0xFB03A0", VA = "0x180FB17A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private float GHEMLADPHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA6E320", Offset = "0xA6CF20", VA = "0x180A6E320", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DCHBJBEFPMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x88D5950", Offset = "0x88D4550", VA = "0x1888D5950", Slot = "24")]
	private bool CFDKPDFCNLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x88D5970", Offset = "0x88D4570", VA = "0x1888D5970", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x88D5980", Offset = "0x88D4580", VA = "0x1888D5980")]
	public BFFCMDJIKGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal enum CCHIEOOAEJF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class IDJBBNCEMAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum DFKOBGDCLOB
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public struct BPPMMHIEMNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public GEPHJDONOHJ OGGOOFLBCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public DFKOBGDCLOB FPKLGKPGMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public List<AOFCGDPPINL> HHGGJEPOAGK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly DFKOBGDCLOB[] OGPPGOLIOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly GEPHJDONOHJ OBNGFOLADNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private bool DPCBKBKOPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly AOFCGDPPINL[] FDGAAKIKFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<AOFCGDPPINL> BFEGELKMKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly Stack<int> ILALCKEKLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly List<AOFCGDPPINL> IIOEPIDPKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly Stack<int> CIPCIJLMOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly AIGKLMEGAAA COBJOHNKJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private bool OPMDAHGEIHA;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public BPPMMHIEMNP[,] BKHAIIFLKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x88E3A60", Offset = "0x88E2660", VA = "0x1888E3A60")]
	public IDJBBNCEMAA(GEPHJDONOHJ LJMMOFEBMGE, AIGKLMEGAAA COBJOHNKJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x88E3830", Offset = "0x88E2430", VA = "0x1888E3830")]
	public void PJNHOMFFFMF(AOFCGDPPINL BLDKOOJADNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x88E29F0", Offset = "0x88E15F0", VA = "0x1888E29F0")]
	public void HNPLOLEOEIE(IList<AOFCGDPPINL> DHKKNJFHDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x88E2CF0", Offset = "0x88E18F0", VA = "0x1888E2CF0")]
	public void IIEBIDNHAMD(IList<AOFCGDPPINL> DHKKNJFHDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x88E2760", Offset = "0x88E1360", VA = "0x1888E2760")]
	private void GAJPBFOCIBF(AOFCGDPPINL BLDKOOJADNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x88E24B0", Offset = "0x88E10B0", VA = "0x1888E24B0")]
	private void ACCIGEGMHKB(IList<AOFCGDPPINL> DHKKNJFHDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x88E2FF0", Offset = "0x88E1BF0", VA = "0x1888E2FF0")]
	private CCHIEOOAEJF KBFJGKNPOEE(AOFCGDPPINL BLDKOOJADNH)
	{
		return default(CCHIEOOAEJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x88E3360", Offset = "0x88E1F60", VA = "0x1888E3360")]
	public void NJCBLGMIGNH(float CHNONDHAGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x88E3170", Offset = "0x88E1D70", VA = "0x1888E3170")]
	public void LMIKOGBEPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x88E34D0", Offset = "0x88E20D0", VA = "0x1888E34D0")]
	private void OLIHNFCDHFN(List<AOFCGDPPINL> DHKKNJFHDJO, Stack<int> NPJONCKOMPM, bool IPHCAOGFBII, float PINANGGGOAL = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x88E2640", Offset = "0x88E1240", VA = "0x1888E2640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x88E28B0", Offset = "0x88E14B0", VA = "0x1888E28B0")]
	private void GALHFEDJANL(List<AOFCGDPPINL> DHKKNJFHDJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal class NFPPOHMNGGB : AIGKLMEGAAA
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	public void OFOOJFOCODD(string LAOCJKNALFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
	public void OFDHDEJLIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public NFPPOHMNGGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal class EEPCGEBMPGK : IJEDJBNNHFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly Behaviour HBHJKEHGKLF;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string AJPMCBKCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x88DF850", Offset = "0x88DE450", VA = "0x1888DF850", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool LMKOJHJBBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x88DF7E0", Offset = "0x88DE3E0", VA = "0x1888DF7E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LOHACKGDPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x88DF830", Offset = "0x88DE430", VA = "0x1888DF830", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public EEPCGEBMPGK(Behaviour HBHJKEHGKLF)
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

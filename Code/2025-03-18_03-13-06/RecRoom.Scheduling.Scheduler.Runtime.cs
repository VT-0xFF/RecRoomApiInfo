using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
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
namespace _LogRegistration.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8057660", Offset = "0x8056860", VA = "0x188057660", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x805E2B0", Offset = "0x805D4B0", VA = "0x18805E2B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private delegate List<PlayerLoopSystem> KHMIDJKCJHA(List<PlayerLoopSystem> ANIBJIEMCBH, int PLECEPDDDLG);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct GEJHEIOPNEP
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct KAICACGHEME
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static MIOEGIOIKAG ECBCOKCMOPJ;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x8054040", Offset = "0x8053240", VA = "0x188054040")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct APGFCMFIBOH
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static MIOEGIOIKAG AGDPFHFDPMC;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x8041830", Offset = "0x8040A30", VA = "0x188041830")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct GKECNOMNBFH
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static MIOEGIOIKAG FLENHAKCOPD;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x804C380", Offset = "0x804B580", VA = "0x18804C380")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct IOLFLEONHLA
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static MIOEGIOIKAG KMKPNHCODJM;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static MIOEGIOIKAG JCCMKBCLOMK;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static MIOEGIOIKAG NDDMLKLLODF;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static MIOEGIOIKAG MMNLLCHNDHC;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x8050420", Offset = "0x804F620", VA = "0x188050420")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct NHKEFEJGNJM
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static MIOEGIOIKAG MPICBDPMPFP;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x8058440", Offset = "0x8057640", VA = "0x188058440")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct IGCGBHIELJI
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static MIOEGIOIKAG KMKPNHCODJM;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static MIOEGIOIKAG JCCMKBCLOMK;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static MIOEGIOIKAG NDDMLKLLODF;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static MIOEGIOIKAG MMNLLCHNDHC;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x804E370", Offset = "0x804D570", VA = "0x18804E370")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct AGNEGEEAJOD
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static MIOEGIOIKAG DKBKBNGEENA;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x8041540", Offset = "0x8040740", VA = "0x188041540")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct IIEPPICKIOJ
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static MIOEGIOIKAG FJLJCHBHMGI;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x804E640", Offset = "0x804D840", VA = "0x18804E640")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct MDLPOGCGDPL
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static MIOEGIOIKAG FHDJHCDCEBG;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x8057F00", Offset = "0x8057100", VA = "0x188057F00")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct NFIDBFLMELB
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static MIOEGIOIKAG JHICNKADDNE;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x8058260", Offset = "0x8057460", VA = "0x188058260")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct JGDKHJJBGHJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static MIOEGIOIKAG KNNDKECPAAE;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x8050720", Offset = "0x804F920", VA = "0x188050720")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct DBAKFACLGPE
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static MIOEGIOIKAG IFILHHFPPEI;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x8047250", Offset = "0x8046450", VA = "0x188047250")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct GIHGBBBIKLD
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static MIOEGIOIKAG EJBJOMNGEJM;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x804C1A0", Offset = "0x804B3A0", VA = "0x18804C1A0")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct HHJFAKLIHDO
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static MIOEGIOIKAG AHCGKBCOOHN;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x804CBC0", Offset = "0x804BDC0", VA = "0x18804CBC0")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct HHCOHGAJPLI
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static MIOEGIOIKAG ACLFOMJIJMA;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x804C9E0", Offset = "0x804BBE0", VA = "0x18804C9E0")]
				public static PlayerLoopSystem CMPJCFGCDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum ELLEIHKNGLG : byte
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
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public struct PAJGGCAIFAM
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class LDOIMLDDNGA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public ELLEIHKNGLG updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
					public LDOIMLDDNGA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x80567D0", Offset = "0x80559D0", VA = "0x1880567D0")]
					internal void PMNBFNGDPIG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static CHAOMIGHCFG<ELLEIHKNGLG> NHPAFMBCMFG;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x805C5B0", Offset = "0x805B7B0", VA = "0x18805C5B0")]
				public static PlayerLoopSystem CMPJCFGCDAO(ELLEIHKNGLG KEKGFNBBICN)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct GDMOPMHHNHB
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class FBADNEFAIFI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public ONGKCMOHPIC.KMCNKHHGPJH key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
					public FBADNEFAIFI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x8049CF0", Offset = "0x8048EF0", VA = "0x188049CF0")]
					internal void GCKLHABAGJP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable ECGHEFAHANN;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x804B720", Offset = "0x804A920", VA = "0x18804B720")]
				public static PlayerLoopSystem BFMMJJGFEHO(ONGKCMOHPIC.KMCNKHHGPJH MBDBONINAPC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct NBIMDDHHIJF
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class CGGCJNHCKMP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public ONGKCMOHPIC.KMCNKHHGPJH key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
					public CGGCJNHCKMP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x8042B60", Offset = "0x8041D60", VA = "0x188042B60")]
					internal void GCKLHABAGJP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x8058130", Offset = "0x8057330", VA = "0x188058130")]
				public static PlayerLoopSystem BFMMJJGFEHO(ONGKCMOHPIC.KMCNKHHGPJH MBDBONINAPC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class MCJJKKEMADL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public MCJJKKEMADL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8057DE0", Offset = "0x8056FE0", VA = "0x188057DE0")]
			internal List<PlayerLoopSystem> IGKBDDHNNOO(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool DFFGNDMCLGH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool BBDKFOCPHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8043E00", Offset = "0x8043000", VA = "0x188043E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8043E40", Offset = "0x8043040", VA = "0x188043E40")]
		private static void LKFDLAEMKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8042FE0", Offset = "0x80421E0", VA = "0x188042FE0")]
		private static void CFHMHKCCCHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8042FA0", Offset = "0x80421A0", VA = "0x188042FA0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8047010", Offset = "0x8046210", VA = "0x188047010")]
		private static void NBNPAIOMNFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8046E50", Offset = "0x8046050", VA = "0x188046E50")]
		private static void LNBBJCLIIPH(ONGKCMOHPIC.KMCNKHHGPJH MBDBONINAPC, PlayerLoopSystem DNFNJKHLABI, Type KLNDNEMIMDN, Type AFNFCCFGLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80438F0", Offset = "0x8042AF0", VA = "0x1880438F0")]
		private static void DCKBMLNBACP(PlayerLoopSystem DNFNJKHLABI, Type KLNDNEMIMDN, Type AFNFCCFGLJB, KHMIDJKCJHA JCKBDHFBBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8043CD0", Offset = "0x8042ED0", VA = "0x188043CD0")]
		private static void IFPHFEAEIIK(PlayerLoopSystem DNFNJKHLABI, Type KLNDNEMIMDN, Type AFNFCCFGLJB, PlayerLoopSystem? AJJFNFCFGGD, PlayerLoopSystem? LODNLMGGHFB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class ONGKCMOHPIC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum KMCNKHHGPJH
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

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class OHBAJNMLBIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly KMCNKHHGPJH IAIGMBMHJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly EJIBMBADIHL CJNHALLBEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long EHBHAEHNIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long ICMPBANIGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long JOJEANMPLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int NJNPICECLBK;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x805C130", Offset = "0x805B330", VA = "0x18805C130")]
		public OHBAJNMLBIL(KMCNKHHGPJH CMPKDANMGLA, int OJMGHDGPJOA = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x805C110", Offset = "0x805B310", VA = "0x18805C110")]
		public void LHNAPGGNJJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x805C0C0", Offset = "0x805B2C0", VA = "0x18805C0C0")]
		public void KIGCLBEKBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x805BFE0", Offset = "0x805B1E0", VA = "0x18805BFE0")]
		public void EOJJPKGDJKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static KMCNKHHGPJH[] JFNEOCKEBCP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static OHBAJNMLBIL[] LBBAGAMICPB;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x805C2D0", Offset = "0x805B4D0", VA = "0x18805C2D0")]
	public static OHBAJNMLBIL ENJEHGBKBNJ(KMCNKHHGPJH MBDBONINAPC, int OJMGHDGPJOA = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x805C1C0", Offset = "0x805B3C0", VA = "0x18805C1C0")]
	public static OHBAJNMLBIL AIKJMOJGDKB(KMCNKHHGPJH MBDBONINAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x805C230", Offset = "0x805B430", VA = "0x18805C230")]
	public static void EACONOENIPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PIKIKKJNADB
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface KIJGEHOICEA
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool LHMKGADFJCH
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EBLGNCPCOGB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class BHEHEIAGGGE : KIJGEHOICEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action GJDAMJHNAPC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool LHMKGADFJCH
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
		public BHEHEIAGGGE(Action GJDAMJHNAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xFC9E60", Offset = "0xFC9060", VA = "0x180FC9E60", Slot = "5")]
		public void EBLGNCPCOGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<KIJGEHOICEA> CKOEOKFDEON;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x805C940", Offset = "0x805BB40", VA = "0x18805C940")]
	public static void BLPHBGJMIAH(Action GJDAMJHNAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x805CAB0", Offset = "0x805BCB0", VA = "0x18805CAB0")]
	private static void MIEIIDIKHLH(KIJGEHOICEA AEBLBBNJJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x805CCC0", Offset = "0x805BEC0", VA = "0x18805CCC0")]
	private static void OHMPPJCDMNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x805C840", Offset = "0x805BA40", VA = "0x18805C840")]
	private static void AHBMKFEFJGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x805C9E0", Offset = "0x805BBE0", VA = "0x18805C9E0")]
	private static void GIIFGIHGJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DNJEFEFCIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct FHKLFBINEKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> BCJDIHFDJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string KHFLPBDLHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode HBILLFFIHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool MJALFHIMEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x804AB80", Offset = "0x8049D80", VA = "0x18804AB80")]
		public FHKLFBINEKH(TaskCompletionSource<Scene> LEGMNCHIOIB, string KHFLPBDLHLB, LoadSceneMode HBILLFFIHMP, bool MJALFHIMEFL, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct JIPLNKLBEDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private AGOOCHPPHOP<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8050900", Offset = "0x804FB00", VA = "0x188050900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x80511A0", Offset = "0x80503A0", VA = "0x1880511A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GBDBMLEJIAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x804B3B0", Offset = "0x804A5B0", VA = "0x18804B3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x804B6C0", Offset = "0x804A8C0", VA = "0x18804B6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct ICKNGCFIFHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private FHKLFBINEKH <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x804DAC0", Offset = "0x804CCC0", VA = "0x18804DAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x804DE80", Offset = "0x804D080", VA = "0x18804DE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class BOIPHIMLLAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public DGOEEBMKNIM<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public BOIPHIMLLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x80421E0", Offset = "0x80413E0", VA = "0x1880421E0")]
		internal void MOLLIGBIKKG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct FGDFKHNAEAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private BOIPHIMLLAM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8049F70", Offset = "0x8049170", VA = "0x188049F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x804AB10", Offset = "0x8049D10", VA = "0x18804AB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct BGDPNMPJDOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IFOOKNGMDBJ <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8041A90", Offset = "0x8040C90", VA = "0x188041A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8042140", Offset = "0x8041340", VA = "0x188042140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct NKJGJKDCNBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8059AF0", Offset = "0x8058CF0", VA = "0x188059AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x805A610", Offset = "0x8059810", VA = "0x18805A610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NIJKLDEPCGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public DGOEEBMKNIM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NIJKLDEPCGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8059060", Offset = "0x8058260", VA = "0x188059060")]
		internal bool NIBBFJMOKDH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8058E00", Offset = "0x8058000", VA = "0x188058E00")]
		internal void AKOHADDNIIC(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class GGGGJIMCDCG : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public DGOEEBMKNIM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private NIJKLDEPCGK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IFOOKNGMDBJ <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public GGGGJIMCDCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x804C140", Offset = "0x804B340", VA = "0x18804C140", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x804B850", Offset = "0x804AA50", VA = "0x18804B850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x804C0D0", Offset = "0x804B2D0", VA = "0x18804C0D0")]
		private void PIKGOAEJJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x804C0F0", Offset = "0x804B2F0", VA = "0x18804C0F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> HOCIAMALNPM;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static LHBFOPKLGGA AEMMPIODGPE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation OJFGAPFBAJO;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static LHBFOPKLGGA CFCGFCEGFLA;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string NGGANOHFFPJ;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string BNBHDLAMPAD;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority BNEDDJIHJIH;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task IHNFJDEGFCA;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> CNCCONHCKGJ;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<FHKLFBINEKH> KAJLNPCFEJK;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task OJHALFFPKOO;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> CFNDLCEJAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x80484E0", Offset = "0x80476E0", VA = "0x1880484E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8048C20", Offset = "0x8047E20", VA = "0x188048C20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8049020", Offset = "0x8048220", VA = "0x188049020")]
	[GHGPNDCMIJI(EIBKBHOJJHA.EnteredEditModeNextFrame, 0)]
	private static void KAKBICPNCIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8048720", Offset = "0x8047920", VA = "0x188048720")]
	[AsyncStateMachine(typeof(JIPLNKLBEDH))]
	public static Task<Scene> FHNFBHICDOM(string KHFLPBDLHLB, LoadSceneMode HBILLFFIHMP = LoadSceneMode.Single, bool MJALFHIMEFL = false, [Optional] AGOOCHPPHOP<string>.ABBPACGFNKJ MKLMGKDAFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8049460", Offset = "0x8048660", VA = "0x188049460")]
	[AsyncStateMachine(typeof(GBDBMLEJIAI))]
	private static Task PMCLKEDGGNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8048DD0", Offset = "0x8047FD0", VA = "0x188048DD0")]
	[AsyncStateMachine(typeof(ICKNGCFIFHB))]
	private static Task JOIDECOPBKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8049110", Offset = "0x8048310", VA = "0x188049110")]
	[AsyncStateMachine(typeof(FGDFKHNAEAO))]
	private static Task<Scene> LOJALLPGLKD(string KHFLPBDLHLB, LoadSceneMode HBILLFFIHMP, bool MJALFHIMEFL, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8048870", Offset = "0x8047A70", VA = "0x188048870")]
	private static void FNMLMNBFMHM(SceneInstance IMMKPGPNBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8048970", Offset = "0x8047B70", VA = "0x188048970")]
	private static void FPIEHDIBLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x80482F0", Offset = "0x80474F0", VA = "0x1880482F0")]
	[AsyncStateMachine(typeof(BGDPNMPJDOK))]
	private static Task<Scene> BCKOLECLBCJ(string KHFLPBDLHLB, LoadSceneMode HBILLFFIHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8049260", Offset = "0x8048460", VA = "0x188049260")]
	private static bool OMLEJNFJPGO(string KHFLPBDLHLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8049350", Offset = "0x8048550", VA = "0x188049350")]
	[AsyncStateMachine(typeof(NKJGJKDCNBE))]
	private static Task<Scene> PIGOKJKJJAF(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8048EA0", Offset = "0x80480A0", VA = "0x188048EA0")]
	public static JBBNLHPJHLB<Scene> JPFJCDHAPPK(string KHFLPBDLHLB, LoadSceneMode HBILLFFIHMP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8048D30", Offset = "0x8047F30", VA = "0x188048D30")]
	[IteratorStateMachine(typeof(GGGGJIMCDCG))]
	private static IEnumerator<DEPLMKJKOMK> JMKJBFCLMII(string KHFLPBDLHLB, LoadSceneMode HBILLFFIHMP, DGOEEBMKNIM<Scene> AILKMAHCLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8048290", Offset = "0x8047490", VA = "0x188048290")]
	public static void BCBMDECKCMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8048420", Offset = "0x8047620", VA = "0x188048420")]
	private static void BDBJEFMGKNH(string KHFLPBDLHLB, LoadSceneMode HBILLFFIHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x80485F0", Offset = "0x80477F0", VA = "0x1880485F0")]
	public static bool BMOJCPNNKJF([Out] string GFOPCPMNEBH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class CJBHBBFNKME
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8042E10", Offset = "0x8042010", VA = "0x188042E10")]
	public static IDisposable HMKPCGKGAAD(this GHOJMPLOGCA IBLIOEFMDMM, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8042F20", Offset = "0x8042120", VA = "0x188042F20")]
	public static IDisposable PLGKCHBNOAI(this GHOJMPLOGCA IBLIOEFMDMM, Action<float> CPCMNBFFKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8042EA0", Offset = "0x80420A0", VA = "0x188042EA0")]
	public static IDisposable HOHJKOMKGEP(this GHOJMPLOGCA IBLIOEFMDMM, Action<float> CPCMNBFFKHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class DBBAHHAGHGB
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x32BF360", Offset = "0x32BE560", VA = "0x1832BF360")]
	[KDPJIIBNIOJ]
	public static IDisposable AKPAKLJLBNP<T>(this T OCKFPLAMBGC, Action CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x32BF1B0", Offset = "0x32BE3B0", VA = "0x1832BF1B0")]
	[KDPJIIBNIOJ]
	public static IDisposable AKPAKLJLBNP<T>(this T OCKFPLAMBGC, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x32BF610", Offset = "0x32BE810", VA = "0x1832BF610")]
	[KDPJIIBNIOJ]
	public static IDisposable DJHAIOPCIPI<T>(this T OCKFPLAMBGC, Action CPCMNBFFKHP, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x32BFC50", Offset = "0x32BEE50", VA = "0x1832BFC50")]
	[KDPJIIBNIOJ]
	public static IDisposable PNGPGKBPEGK<T>(this T OCKFPLAMBGC, Action CPCMNBFFKHP, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x32BFC50", Offset = "0x32BEE50", VA = "0x1832BFC50")]
	[KDPJIIBNIOJ]
	public static IDisposable PNGPGKBPEGK<T>(this T OCKFPLAMBGC, Action<float> CPCMNBFFKHP, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x32BF790", Offset = "0x32BE990", VA = "0x1832BF790")]
	[KDPJIIBNIOJ]
	public static IDisposable HKIAAIILALA<T>(this T OCKFPLAMBGC, Action CPCMNBFFKHP, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x32BF6B0", Offset = "0x32BE8B0", VA = "0x1832BF6B0")]
	[KDPJIIBNIOJ]
	public static IDisposable FOHAPHNMJCJ<T>(this T OCKFPLAMBGC, Action CPCMNBFFKHP, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x32BF6F0", Offset = "0x32BE8F0", VA = "0x1832BF6F0")]
	[KDPJIIBNIOJ]
	public static IDisposable HGNICGJPLFB<T>(this T OCKFPLAMBGC, Action CPCMNBFFKHP, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x32BFBB0", Offset = "0x32BEDB0", VA = "0x1832BFBB0")]
	[KDPJIIBNIOJ]
	public static IDisposable OLBHMJGHLMC<T>(this T OCKFPLAMBGC, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8047430", Offset = "0x8046630", VA = "0x188047430")]
	[KDPJIIBNIOJ]
	public static IDisposable OLBHMJGHLMC(this MonoBehaviour OCKFPLAMBGC, LCCLDLHOIOG IBLIOEFMDMM, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x32BF9A0", Offset = "0x32BEBA0", VA = "0x1832BF9A0")]
	[KDPJIIBNIOJ]
	public static IDisposable MCACPBOKMJA<T>(this T OCKFPLAMBGC, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x32BF560", Offset = "0x32BE760", VA = "0x1832BF560")]
	[KDPJIIBNIOJ]
	public static IDisposable CAADOBHPEGO<T>(this T OCKFPLAMBGC, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x32BF650", Offset = "0x32BE850", VA = "0x1832BF650")]
	[KDPJIIBNIOJ]
	public static IDisposable EMHKMCEMMMF<T>(this T OCKFPLAMBGC, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x32BF7D0", Offset = "0x32BE9D0", VA = "0x1832BF7D0")]
	[KDPJIIBNIOJ]
	public static IDisposable HPCHPGJNJPP<T>(this T OCKFPLAMBGC, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x32BF8F0", Offset = "0x32BEAF0", VA = "0x1832BF8F0")]
	[KDPJIIBNIOJ]
	public static IDisposable JNPAJLNLCFK<T>(this T OCKFPLAMBGC, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x32BFB50", Offset = "0x32BED50", VA = "0x1832BFB50")]
	[KDPJIIBNIOJ]
	public static IDisposable NIJOBKPLMIH<T>(this T OCKFPLAMBGC, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x32BF830", Offset = "0x32BEA30", VA = "0x1832BF830")]
	[KDPJIIBNIOJ]
	public static IDisposable IBFNIBCGGJH<T>(this T OCKFPLAMBGC, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x32BF730", Offset = "0x32BE930", VA = "0x1832BF730")]
	[KDPJIIBNIOJ]
	public static IDisposable HHFGCKJKLHD<T>(this T OCKFPLAMBGC, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x32BFBF0", Offset = "0x32BEDF0", VA = "0x1832BFBF0")]
	[KDPJIIBNIOJ]
	public static IDisposable PDMAMIOBAOK<T>(this T OCKFPLAMBGC, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x32BF950", Offset = "0x32BEB50", VA = "0x1832BF950")]
	[KDPJIIBNIOJ]
	public static IDisposable MBGIMOHBNBL<T>(this T OCKFPLAMBGC, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x32BF890", Offset = "0x32BEA90", VA = "0x1832BF890")]
	[KDPJIIBNIOJ]
	public static IDisposable JFOHIJBHJAO<T>(this T OCKFPLAMBGC, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x32BF5B0", Offset = "0x32BE7B0", VA = "0x1832BF5B0")]
	[KDPJIIBNIOJ]
	public static IDisposable DILEIHKPJDD<T>(this T OCKFPLAMBGC, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true) where T : MonoBehaviour, LCCLDLHOIOG
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KCGOMJAJIIG
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class EFHGKIIBDAL : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public ENANHDDEDLG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private GGEBJJJDKAD <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public EFHGKIIBDAL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8049720", Offset = "0x8048920", VA = "0x188049720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8049800", Offset = "0x8048A00", VA = "0x188049800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class NPODMJFHGLL : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public ENANHDDEDLG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private GGEBJJJDKAD <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public NPODMJFHGLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x805A680", Offset = "0x8059880", VA = "0x18805A680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x805A770", Offset = "0x8059970", VA = "0x18805A770", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8054220", Offset = "0x8053420", VA = "0x188054220")]
	public static PHFJKNHMAKK AKPAKLJLBNP(Action CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8054380", Offset = "0x8053580", VA = "0x188054380")]
	public static PHFJKNHMAKK AKPAKLJLBNP(Behaviour IBLIOEFMDMM, Action CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x80542A0", Offset = "0x80534A0", VA = "0x1880542A0")]
	public static PHFJKNHMAKK AKPAKLJLBNP(Behaviour IBLIOEFMDMM, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x80544A0", Offset = "0x80536A0", VA = "0x1880544A0")]
	[IteratorStateMachine(typeof(EFHGKIIBDAL))]
	private static IEnumerator<DEPLMKJKOMK> IEHGNHIFBCN(ENANHDDEDLG HIFNOPIHKOC, Action CPCMNBFFKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8054410", Offset = "0x8053610", VA = "0x188054410")]
	[IteratorStateMachine(typeof(NPODMJFHGLL))]
	private static IEnumerator<DEPLMKJKOMK> IEHGNHIFBCN(ENANHDDEDLG HIFNOPIHKOC, Action<float> CPCMNBFFKHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class FJABFMCCBJD : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class HCAILPNODIM : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public FJABFMCCBJD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public HCAILPNODIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x804C900", Offset = "0x804BB00", VA = "0x18804C900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x804C990", Offset = "0x804BB90", VA = "0x18804C990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly ENANHDDEDLG PONIMGFCIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action GGDNGLAOIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool AHKKLCMKMOO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool CMJCGBCLKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x964F10", Offset = "0x964110", VA = "0x180964F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x804AD00", Offset = "0x8049F00", VA = "0x18804AD00")]
	public FJABFMCCBJD(ENANHDDEDLG PONIMGFCIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x804ABE0", Offset = "0x8049DE0", VA = "0x18804ABE0")]
	[IteratorStateMachine(typeof(HCAILPNODIM))]
	private IEnumerator<DEPLMKJKOMK> FFNJFILDFGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x804AC60", Offset = "0x8049E60", VA = "0x18804AC60", Slot = "4")]
	public void OnCompleted(Action AEDLOEEBJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	public void LFFOABONJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class ALCGHMKJMDO
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8041720", Offset = "0x8040920", VA = "0x188041720")]
	public static FJABFMCCBJD KJDMAOPKNEK(this ENANHDDEDLG PONIMGFCIDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class INBKCPGMKLN
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class PGJHGABEHIE : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public GFGDFKDNDPN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public PGJHGABEHIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x805C770", Offset = "0x805B970", VA = "0x18805C770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x805C7F0", Offset = "0x805B9F0", VA = "0x18805C7F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x804EB90", Offset = "0x804DD90", VA = "0x18804EB90")]
	public static PHFJKNHMAKK AKPAKLJLBNP(float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, bool IGNDLPJKCOC = true, [Optional] HHDHIMDCBCN CAKLLNDAEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x804EAC0", Offset = "0x804DCC0", VA = "0x18804EAC0")]
	public static PHFJKNHMAKK AKPAKLJLBNP(MonoBehaviour OCKFPLAMBGC, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, bool IGNDLPJKCOC = true, [Optional] HHDHIMDCBCN CAKLLNDAEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x804EEE0", Offset = "0x804E0E0", VA = "0x18804EEE0")]
	public static PHFJKNHMAKK PKGPLOAAPHL(MonoBehaviour OCKFPLAMBGC, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, bool IGNDLPJKCOC = true, [Optional] HHDHIMDCBCN CAKLLNDAEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x804EE10", Offset = "0x804E010", VA = "0x18804EE10")]
	public static PHFJKNHMAKK PHEOHHGDLGE(GHOJMPLOGCA IBLIOEFMDMM, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, bool IGNDLPJKCOC = true, [Optional] HHDHIMDCBCN CAKLLNDAEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x804ED50", Offset = "0x804DF50", VA = "0x18804ED50")]
	private static IEnumerator<DEPLMKJKOMK> IEHGNHIFBCN(EFFGNPFPGCE KAGEOEHJPMD, float ICNOJKMHEGP, ENANHDDEDLG HIFNOPIHKOC, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x804ECF0", Offset = "0x804DEF0", VA = "0x18804ECF0")]
	private static IEnumerator<DEPLMKJKOMK> FMNPMPFNDBM(EFFGNPFPGCE KAGEOEHJPMD, float ICNOJKMHEGP, ENANHDDEDLG HIFNOPIHKOC, Action<float> CPCMNBFFKHP, bool IGNDLPJKCOC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x804EC60", Offset = "0x804DE60", VA = "0x18804EC60")]
	[IteratorStateMachine(typeof(PGJHGABEHIE))]
	private static IEnumerator<DEPLMKJKOMK> EIDKEIEHCKC(GFGDFKDNDPN KMDIFJLABDM, float ICNOJKMHEGP, ENANHDDEDLG HIFNOPIHKOC, Action<float> CPCMNBFFKHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class PMJIOHNHHBM
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class FOPAIEGAAGM : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public ENANHDDEDLG queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public FOPAIEGAAGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x804B2A0", Offset = "0x804A4A0", VA = "0x18804B2A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x804B360", Offset = "0x804A560", VA = "0x18804B360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x805D030", Offset = "0x805C230", VA = "0x18805D030")]
	[IteratorStateMachine(typeof(FOPAIEGAAGM))]
	private static IEnumerator<DEPLMKJKOMK> ACHDMPBACPN(ENANHDDEDLG PONIMGFCIDF, Func<bool> FPPMNPIKPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x805D0C0", Offset = "0x805C2C0", VA = "0x18805D0C0")]
	public static PHFJKNHMAKK JIABMCLFABA(this MonoBehaviour OCKFPLAMBGC, Func<bool> FPPMNPIKPAP, ENANHDDEDLG PONIMGFCIDF = ENANHDDEDLG.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NIKKCAAOEBC
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class IMGDFHLEIEL : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public ENANHDDEDLG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public IMGDFHLEIEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x804EA00", Offset = "0x804DC00", VA = "0x18804EA00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x804EA70", Offset = "0x804DC70", VA = "0x18804EA70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class HKGHADMLFNO<T> : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ENANHDDEDLG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public HKGHADMLFNO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x46B3E30", Offset = "0x46B3030", VA = "0x1846B3E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x46B3ED0", Offset = "0x46B30D0", VA = "0x1846B3ED0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class IJLDNNDFODA : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ENANHDDEDLG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private DEPLMKJKOMK <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public IJLDNNDFODA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x804E820", Offset = "0x804DA20", VA = "0x18804E820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x804E8B0", Offset = "0x804DAB0", VA = "0x18804E8B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8059490", Offset = "0x8058690", VA = "0x188059490")]
	[IteratorStateMachine(typeof(IMGDFHLEIEL))]
	private static IEnumerator<DEPLMKJKOMK> FFNJFILDFGO(float KDJGAOFKCEM, ENANHDDEDLG HIFNOPIHKOC, Action GGGDPGAGPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3610970", Offset = "0x360FB70", VA = "0x183610970")]
	[IteratorStateMachine(typeof(HKGHADMLFNO<>))]
	private static IEnumerator<DEPLMKJKOMK> FFNJFILDFGO<T>(float KDJGAOFKCEM, ENANHDDEDLG HIFNOPIHKOC, Action<T> GGGDPGAGPON, T DLGGINKGFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x80597B0", Offset = "0x80589B0", VA = "0x1880597B0")]
	[IteratorStateMachine(typeof(IJLDNNDFODA))]
	private static IEnumerator<DEPLMKJKOMK> KIMEDJOMNDL(float KDJGAOFKCEM, ENANHDDEDLG HIFNOPIHKOC, Action GGGDPGAGPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x8059270", Offset = "0x8058470", VA = "0x188059270")]
	public static IDisposable BNFJOJBAOLL(this MonoBehaviour OCKFPLAMBGC, float KDJGAOFKCEM, Action GGGDPGAGPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8059850", Offset = "0x8058A50", VA = "0x188059850")]
	public static PHFJKNHMAKK KPIGAOJBFFP(this MonoBehaviour OCKFPLAMBGC, float KDJGAOFKCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8059180", Offset = "0x8058380", VA = "0x188059180")]
	public static PHFJKNHMAKK BNFJOJBAOLL(this MonoBehaviour OCKFPLAMBGC, float KDJGAOFKCEM, ENANHDDEDLG HIFNOPIHKOC, Action GGGDPGAGPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x80595D0", Offset = "0x80587D0", VA = "0x1880595D0")]
	public static PHFJKNHMAKK HLIEKPEEPCP(this MonoBehaviour OCKFPLAMBGC, Action GGGDPGAGPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3610A50", Offset = "0x360FC50", VA = "0x183610A50")]
	public static PHFJKNHMAKK HLIEKPEEPCP<T>(this MonoBehaviour OCKFPLAMBGC, Action<T> GGGDPGAGPON, T DLGGINKGFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x80593F0", Offset = "0x80585F0", VA = "0x1880593F0")]
	public static PHFJKNHMAKK DLGPBMJNOMO(this MonoBehaviour OCKFPLAMBGC, Action GGGDPGAGPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8059980", Offset = "0x8058B80", VA = "0x188059980")]
	public static PHFJKNHMAKK OPBNJJDEOHA(this MonoBehaviour OCKFPLAMBGC, Action GGGDPGAGPON, [Optional] HHDHIMDCBCN CAKLLNDAEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8059670", Offset = "0x8058870", VA = "0x188059670")]
	public static PHFJKNHMAKK IMOPCHIKDCK(this MonoBehaviour OCKFPLAMBGC, Action GGGDPGAGPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8059530", Offset = "0x8058730", VA = "0x188059530")]
	public static PHFJKNHMAKK HBACJPFBKKI(this MonoBehaviour OCKFPLAMBGC, Action GGGDPGAGPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8059350", Offset = "0x8058550", VA = "0x188059350")]
	public static PHFJKNHMAKK DABBHDNGECE(MonoBehaviour OCKFPLAMBGC, ENANHDDEDLG PONIMGFCIDF, Action GGGDPGAGPON, [Optional] HHDHIMDCBCN CAKLLNDAEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3610830", Offset = "0x360FA30", VA = "0x183610830")]
	public static PHFJKNHMAKK DABBHDNGECE<T>(MonoBehaviour OCKFPLAMBGC, ENANHDDEDLG PONIMGFCIDF, Action<T> GGGDPGAGPON, T DLGGINKGFFM, [Optional] HHDHIMDCBCN CAKLLNDAEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8059A20", Offset = "0x8058C20", VA = "0x188059A20")]
	public static PHFJKNHMAKK PBAPNOCEDBB(this MonoBehaviour OCKFPLAMBGC, float OIOMEDANFCP, Action GGGDPGAGPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x80590E0", Offset = "0x80582E0", VA = "0x1880590E0")]
	public static PHFJKNHMAKK AHCLPIPHDLG(this MonoBehaviour OCKFPLAMBGC, float OIOMEDANFCP, Action GGGDPGAGPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8059710", Offset = "0x8058910", VA = "0x188059710")]
	public static PHFJKNHMAKK KHKHDGJMFJN(this MonoBehaviour OCKFPLAMBGC, float OIOMEDANFCP, Action GGGDPGAGPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x80598E0", Offset = "0x8058AE0", VA = "0x1880598E0")]
	public static PHFJKNHMAKK NJHNPIAACMP(this MonoBehaviour OCKFPLAMBGC, float OIOMEDANFCP, Action GGGDPGAGPON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class CEHHALNCPFI : CCCHMDLMIBJ, IEnumerable<CCCHMDLMIBJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<CCCHMDLMIBJ> HIICGBCBMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool FGHPDPPBHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action LJLNGMLOKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool HOOJLJONFPA;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FHDLMMFGBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8042860", Offset = "0x8041A60", VA = "0x188042860", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GADBJAAMBAN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8042720", Offset = "0x8041920", VA = "0x188042720", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x80427C0", Offset = "0x80419C0", VA = "0x1880427C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8042AC0", Offset = "0x8041CC0", VA = "0x188042AC0")]
	public CEHHALNCPFI([Optional] Action LJLNGMLOKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8042990", Offset = "0x8041B90", VA = "0x188042990")]
	public void OFEFHMDJLMD(CCCHMDLMIBJ BAMMDJLBBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8042240", Offset = "0x8041440", VA = "0x188042240")]
	private void CDCPFLDNHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8042710", Offset = "0x8041910", VA = "0x188042710", Slot = "7")]
	public bool ILJCFPAKOAG(bool CPGNGBBHKKK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8042410", Offset = "0x8041610", VA = "0x188042410", Slot = "8")]
	public bool ILJCFPAKOAG(Action GJDAMJHNAPC, bool CPGNGBBHKKK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8042390", Offset = "0x8041590", VA = "0x188042390", Slot = "9")]
	public IEnumerator<CCCHMDLMIBJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8042390", Offset = "0x8041590", VA = "0x188042390", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HBIMDBHDPDO : MBKHIJPJMCB
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class JDMEIJHALIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public HBIMDBHDPDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JDMEIJHALIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x80506F0", Offset = "0x804F8F0", VA = "0x1880506F0")]
		internal void NIEFIJMOKPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class NFHPMMNFPHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public HBIMDBHDPDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NFHPMMNFPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x80506F0", Offset = "0x804F8F0", VA = "0x1880506F0")]
		internal void JLOPBKINKBE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float IOLJPGNEPAF;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x804C7C0", Offset = "0x804B9C0", VA = "0x18804C7C0")]
	public HBIMDBHDPDO(Behaviour IBLIOEFMDMM, float IOLJPGNEPAF, [Optional] Action LJLNGMLOKKD, [Optional] HHDHIMDCBCN CAKLLNDAEHB, [Optional] EFFGNPFPGCE KAGEOEHJPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x804C6B0", Offset = "0x804B8B0", VA = "0x18804C6B0", Slot = "9")]
	protected override bool OCAABLHEGAP(Action GJDAMJHNAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x804C5A0", Offset = "0x804B7A0", VA = "0x18804C5A0", Slot = "10")]
	protected override bool JDLAAOCBIHP(Action GJDAMJHNAPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface CCCHMDLMIBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool FHDLMMFGBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GADBJAAMBAN;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ILJCFPAKOAG(bool CPGNGBBHKKK = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ILJCFPAKOAG(Action GJDAMJHNAPC, bool CPGNGBBHKKK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class MBKHIJPJMCB : CCCHMDLMIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KHJGGDIMBED : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public MBKHIJPJMCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public KHJGGDIMBED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8054620", Offset = "0x8053820", VA = "0x188054620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x80546F0", Offset = "0x80538F0", VA = "0x1880546F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour IBLIOEFMDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action LJLNGMLOKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private EMKGHLOECBM IEGFHGMDFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly HHDHIMDCBCN CAKLLNDAEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly EFFGNPFPGCE KAGEOEHJPMD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FHDLMMFGBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x18739A0", Offset = "0x1872BA0", VA = "0x1818739A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GADBJAAMBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8057870", Offset = "0x8056A70", VA = "0x188057870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8057B60", Offset = "0x8056D60", VA = "0x188057B60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8057CB0", Offset = "0x8056EB0", VA = "0x188057CB0")]
	protected MBKHIJPJMCB(Behaviour IBLIOEFMDMM, [Optional] Action LJLNGMLOKKD, [Optional] HHDHIMDCBCN CAKLLNDAEHB, [Optional] EFFGNPFPGCE KAGEOEHJPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8057810", Offset = "0x8056A10", VA = "0x188057810", Slot = "7")]
	public bool ILJCFPAKOAG(bool CPGNGBBHKKK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x80577B0", Offset = "0x80569B0", VA = "0x1880577B0", Slot = "8")]
	public bool ILJCFPAKOAG(Action GJDAMJHNAPC, bool CPGNGBBHKKK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OCAABLHEGAP(Action GJDAMJHNAPC);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool JDLAAOCBIHP(Action GJDAMJHNAPC);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8057C90", Offset = "0x8056E90", VA = "0x188057C90")]
	protected void PDMBMNGJLOC(Action GJDAMJHNAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8057910", Offset = "0x8056B10", VA = "0x188057910")]
	protected LHBFOPKLGGA NFGBODLFBLH(float MBNMMCCMGDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x80576F0", Offset = "0x80568F0", VA = "0x1880576F0")]
	private void CKPENJMEJGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8057C00", Offset = "0x8056E00", VA = "0x188057C00")]
	[IteratorStateMachine(typeof(KHJGGDIMBED))]
	private IEnumerator<DEPLMKJKOMK> OBMAHOEGNGE(float MBNMMCCMGDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8057770", Offset = "0x8056970", VA = "0x188057770")]
	[CompilerGenerated]
	private void DBBDFOMNACA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class IFLKECNMJEE : MBKHIJPJMCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float IAPNGOIGJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int EMOABKPOHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float DCCPBMBPKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] EHMGPDGFGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int MDKAJNDMFEB;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x804E1A0", Offset = "0x804D3A0", VA = "0x18804E1A0")]
	public IFLKECNMJEE(Behaviour IBLIOEFMDMM, float GCAFHFNBAAI, int EMOABKPOHNN, [Optional] Action LJLNGMLOKKD, float DCCPBMBPKKE = 0f, [Optional] HHDHIMDCBCN CAKLLNDAEHB, [Optional] EFFGNPFPGCE KAGEOEHJPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "9")]
	protected override bool OCAABLHEGAP(Action GJDAMJHNAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x804DFA0", Offset = "0x804D1A0", VA = "0x18804DFA0", Slot = "10")]
	protected override bool JDLAAOCBIHP(Action GJDAMJHNAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x804DF20", Offset = "0x804D120", VA = "0x18804DF20")]
	private void ICPJKPBHNNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NJDMFBDMJMM : MBKHIJPJMCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float IOLJPGNEPAF;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x804C7C0", Offset = "0x804B9C0", VA = "0x18804C7C0")]
	public NJDMFBDMJMM(Behaviour IBLIOEFMDMM, float IOLJPGNEPAF, [Optional] Action LJLNGMLOKKD, [Optional] HHDHIMDCBCN CAKLLNDAEHB, [Optional] EFFGNPFPGCE KAGEOEHJPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "9")]
	protected override bool OCAABLHEGAP(Action GJDAMJHNAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8059AB0", Offset = "0x8058CB0", VA = "0x188059AB0", Slot = "10")]
	protected override bool JDLAAOCBIHP(Action GJDAMJHNAPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class KJLGHOLAKKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class NAEFJNOEMIO : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public NAEFJNOEMIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8051590", Offset = "0x8050790", VA = "0x188051590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x80580E0", Offset = "0x80572E0", VA = "0x1880580E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private PHFJKNHMAKK NAMJIKPODOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private GHOJMPLOGCA IBLIOEFMDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> GPDPANNFBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private ENANHDDEDLG PONIMGFCIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float KGDADHEINEN;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8056630", Offset = "0x8055830", VA = "0x188056630")]
	public KJLGHOLAKKC(GHOJMPLOGCA IBLIOEFMDMM, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8056130", Offset = "0x8055330", VA = "0x188056130")]
	private void AMBMCLFFJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8056500", Offset = "0x8055700", VA = "0x188056500")]
	private void OBBMGLACHBJ(string HHOJHACJLGI, Action OJDFFCNELMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8056420", Offset = "0x8055620", VA = "0x188056420")]
	[IteratorStateMachine(typeof(NAEFJNOEMIO))]
	private IEnumerator<DEPLMKJKOMK> DNMEICMOHKE(Action OJDFFCNELMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x80564A0", Offset = "0x80556A0", VA = "0x1880564A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x80562A0", Offset = "0x80554A0", VA = "0x1880562A0")]
	[CompilerGenerated]
	private void BAEOEBLJLNA(string OLLOHIKPLMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class OCBAAJILHIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JPODFMJLFBC : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public JPODFMJLFBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8051590", Offset = "0x8050790", VA = "0x188051590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8051600", Offset = "0x8050800", VA = "0x188051600", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private PHFJKNHMAKK NAMJIKPODOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour OCKFPLAMBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action CPCMNBFFKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> GPDPANNFBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private ENANHDDEDLG PONIMGFCIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float KGDADHEINEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool IGNDLPJKCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly HHDHIMDCBCN CAKLLNDAEHB;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x805BE50", Offset = "0x805B050", VA = "0x18805BE50")]
	public OCBAAJILHIE(MonoBehaviour OCKFPLAMBGC, Action CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, [Optional] HHDHIMDCBCN CAKLLNDAEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x805BAA0", Offset = "0x805ACA0", VA = "0x18805BAA0")]
	public OCBAAJILHIE(MonoBehaviour OCKFPLAMBGC, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, [Optional] HHDHIMDCBCN CAKLLNDAEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x805BC70", Offset = "0x805AE70", VA = "0x18805BC70")]
	public OCBAAJILHIE(MonoBehaviour OCKFPLAMBGC, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, bool IGNDLPJKCOC = true, [Optional] HHDHIMDCBCN CAKLLNDAEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x46E5F70", Offset = "0x46E5170", VA = "0x1846E5F70")]
	private OCBAAJILHIE(HHDHIMDCBCN CAKLLNDAEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x805B870", Offset = "0x805AA70", VA = "0x18805B870")]
	internal static OCBAAJILHIE PPDGKJCIKFI(MonoBehaviour OCKFPLAMBGC, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, ENANHDDEDLG PONIMGFCIDF, bool IGNDLPJKCOC = true, [Optional] HHDHIMDCBCN CAKLLNDAEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x805B090", Offset = "0x805A290", VA = "0x18805B090")]
	private void AKPAKLJLBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x805B6F0", Offset = "0x805A8F0", VA = "0x18805B6F0")]
	private void PJCPPBKLAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x805B1C0", Offset = "0x805A3C0", VA = "0x18805B1C0")]
	private void AMBMCLFFJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x805AE70", Offset = "0x805A070", VA = "0x18805AE70")]
	private void AAHJMKAOEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x805B5C0", Offset = "0x805A7C0", VA = "0x18805B5C0")]
	private void OBBMGLACHBJ(string HHOJHACJLGI, Action OJDFFCNELMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x805B330", Offset = "0x805A530", VA = "0x18805B330")]
	[IteratorStateMachine(typeof(JPODFMJLFBC))]
	private IEnumerator<DEPLMKJKOMK> DNMEICMOHKE(Action OJDFFCNELMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x805B3B0", Offset = "0x805A5B0", VA = "0x18805B3B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x805B530", Offset = "0x805A730", VA = "0x18805B530")]
	[CompilerGenerated]
	private void MFMIFNBHNCG(string OLLOHIKPLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x805B4A0", Offset = "0x805A6A0", VA = "0x18805B4A0")]
	[CompilerGenerated]
	private void IMLMDBIKDGK(string OLLOHIKPLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x805B410", Offset = "0x805A610", VA = "0x18805B410")]
	[CompilerGenerated]
	private void EHAFKNPOLPI(string OLLOHIKPLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x805B000", Offset = "0x805A200", VA = "0x18805B000")]
	[CompilerGenerated]
	private void ADJMLGFOGEI(string OLLOHIKPLMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum OHNBFKOIADG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal sealed class KEMHMNFBPCB : EFFGNPFPGCE
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float JEBELGDGHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x80545D0", Offset = "0x80537D0", VA = "0x1880545D0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float FAJNMMCBKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8054530", Offset = "0x8053730", VA = "0x188054530", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double JLLGOKJHMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8054540", Offset = "0x8053740", VA = "0x188054540", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8054560", Offset = "0x8053760", VA = "0x188054560")]
	[LDKBBAENJDF.JPBGCAANJAC]
	internal static void JHDFHEGIBHJ(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	[UnityEngine.Scripting.Preserve]
	internal KEMHMNFBPCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface KAKJJICIHNC
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNAHJADIKBC(string MBDFMCIDAOB);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIGMDLHPAGE();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface DNOIFFHOJHI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string FOBFABOAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LEEPFAKCGED
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool AFEOGAMCBBL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class FLKJENFLNED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public KAEHBIPBGPO EIOJACFEHHC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int PGEMEJBADFN
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x971850", Offset = "0x970A50", VA = "0x180971850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x804AF40", Offset = "0x804A140", VA = "0x18804AF40")]
	public static DEPLMKJKOMK HJBADGAOCAI(IEnumerator<DEPLMKJKOMK> FKOCJNFKHDG, BBOFDCOEFNG DKIHAOLPIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x804B0A0", Offset = "0x804A2A0", VA = "0x18804B0A0")]
	public DEPLMKJKOMK HJBADGAOCAI(BBOFDCOEFNG[] HELODOJICFC, IEnumerator<DEPLMKJKOMK>[] DMOIOHGBOIC, DEPLMKJKOMK[] JJJEMLBKAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x804AF10", Offset = "0x804A110", VA = "0x18804AF10")]
	public void HBCPOFIIAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x804ADD0", Offset = "0x8049FD0", VA = "0x18804ADD0")]
	public void EICILEBBKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x804B160", Offset = "0x804A360", VA = "0x18804B160")]
	public void ILFBGLIGLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x804AF10", Offset = "0x804A110", VA = "0x18804AF10")]
	public void OGCCBPDGCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public FLKJENFLNED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class KAEHBIPBGPO
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct KIFEFINFHBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public FLKJENFLNED CIODCLEFLGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public GHOJMPLOGCA ADOPBHOJDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public BBOFDCOEFNG KPGBHIEHFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<DEPLMKJKOMK> NGNCMLDINLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public DEPLMKJKOMK CHGNKNOKAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public OHNBFKOIADG AJJJBEOICCH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CJIFCFHEBDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public ENANHDDEDLG JBAEPKMBFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<KIFEFINFHBJ> OJPPPEMNJLL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class NHKGCLKALKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public BBOFDCOEFNG promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public KAEHBIPBGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public GHOJMPLOGCA context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public FLKJENFLNED routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public OHNBFKOIADG coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public DEPLMKJKOMK currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<DEPLMKJKOMK> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NHKGCLKALKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8058620", Offset = "0x8057820", VA = "0x188058620")]
		internal void FACLAMHMFGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class GMEHJKKMDGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public FLKJENFLNED schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public KAEHBIPBGPO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GMEHJKKMDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x804C560", Offset = "0x804B760", VA = "0x18804C560")]
		internal void NELIGIFGIPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class KFBKLOMGJJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public FLKJENFLNED schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public KAEHBIPBGPO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KFBKLOMGJJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x80545E0", Offset = "0x80537E0", VA = "0x1880545E0")]
		internal void CMCDCDNMGEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class IFHFBMBGMKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public FLKJENFLNED schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public KAEHBIPBGPO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public IFHFBMBGMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x804DEE0", Offset = "0x804D0E0", VA = "0x18804DEE0")]
		internal void EGBCOONNMIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const OHNBFKOIADG MJFALLNOHEC = OHNBFKOIADG.Cancelled | OHNBFKOIADG.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly ENANHDDEDLG PONIMGFCIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] DKNHKFFLHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<OHNBFKOIADG> HFKGNDNKHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> HNLDAMCHDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> DJPMCCGFPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> EDJNMBMMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> KKLFHCBBIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> DBKMNGOJFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> IJNECBACHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private FLKJENFLNED[] FCAADAKEGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private BBOFDCOEFNG[] HELODOJICFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private GHOJMPLOGCA[] MIMCPDGCPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<DEPLMKJKOMK>[] LOKJIFFIHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private DEPLMKJKOMK[] LNFJKJIDMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int EBFFMFGJAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int ECPBKIMJCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int NNCKPODCGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float FEFMNLHAAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private LEAFBDLBEJE OEPLHLDKPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle JAHMPGDOILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<FLKJENFLNED> FMMNMLGPKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool AAFLBDBMMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> PKMOAAGGIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> EENAHAOIOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool MMPPABGHOOI;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public CJIFCFHEBDO[] HPFINPDBJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9D1AE0", Offset = "0x9D0CE0", VA = "0x1809D1AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x80539B0", Offset = "0x8052BB0", VA = "0x1880539B0")]
	private static int PNLIKOCGGOO(ENANHDDEDLG PONIMGFCIDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x80539E0", Offset = "0x8052BE0", VA = "0x1880539E0")]
	public KAEHBIPBGPO(ENANHDDEDLG PONIMGFCIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8053570", Offset = "0x8052770", VA = "0x188053570")]
	private void MKEENEGIOND(int FMJACIBJPPB, int KFOBHJHKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8052E20", Offset = "0x8052020", VA = "0x188052E20")]
	public void KEDCDGJFEJK(GHOJMPLOGCA IBLIOEFMDMM, DEPLMKJKOMK LNDMAJGGGIE, IEnumerator<DEPLMKJKOMK> FKOCJNFKHDG, BBOFDCOEFNG DKIHAOLPIJN, [Optional] FLKJENFLNED PLHJCGFLBEE, OHNBFKOIADG PGJDECFNBGK = OHNBFKOIADG.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8052740", Offset = "0x8051940", VA = "0x188052740")]
	public void GMILALKDDAH(IEnumerable<KIFEFINFHBJ> JABGFHONJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8051650", Offset = "0x8050850", VA = "0x188051650")]
	private KIFEFINFHBJ BIBDMDNGDDG(int IPHBOIIGOAF)
	{
		return default(KIFEFINFHBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8052FA0", Offset = "0x80521A0", VA = "0x188052FA0")]
	private void KNOKBODOAOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x351F820", Offset = "0x351EA20", VA = "0x18351F820")]
	private static void MMEJKAOAJMF<T>(int IPHBOIIGOAF, T[] PIPGBPMKGBO, int IAGJHPFNLHJ, [Optional] T LJILHFFOLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x351F870", Offset = "0x351EA70", VA = "0x18351F870")]
	private static void MMEJKAOAJMF<T>(int IPHBOIIGOAF, NativeArray<T> PIPGBPMKGBO, int IAGJHPFNLHJ, [Optional] T LJILHFFOLDN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8052A80", Offset = "0x8051C80", VA = "0x188052A80")]
	private void HJKKFMFDELM(IEnumerable<KIFEFINFHBJ> JABGFHONJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8052670", Offset = "0x8051870", VA = "0x188052670")]
	private void GCNLDHGFEEK(KIFEFINFHBJ LCFEKEAKAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8053310", Offset = "0x8052510", VA = "0x188053310")]
	private FNLNCBOCACC MDCJBDEEDBH(int OKBEMFGAHOL)
	{
		return default(FNLNCBOCACC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8052370", Offset = "0x8051570", VA = "0x188052370")]
	public void EPBFGANFHDJ(float IJEINPFHNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8052570", Offset = "0x8051770", VA = "0x188052570")]
	private void FFDEDHBGJDF(Action IHGFIECIOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x80525F0", Offset = "0x80517F0", VA = "0x1880525F0")]
	private void FLJGMHEFPAG(Action IHGFIECIOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8051C50", Offset = "0x8050E50", VA = "0x188051C50")]
	public void EHJPGMEIGPL(float IJEINPFHNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8052980", Offset = "0x8051B80", VA = "0x188052980")]
	public void GNPGDFFJFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8053880", Offset = "0x8052A80", VA = "0x188053880")]
	public void OGCCBPDGCLP(FLKJENFLNED KMDIFJLABDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8051B20", Offset = "0x8050D20", VA = "0x188051B20")]
	public void CGHBEDDHAFA(FLKJENFLNED KMDIFJLABDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8053750", Offset = "0x8052950", VA = "0x188053750")]
	public void MPEHGMFJDGD(FLKJENFLNED KMDIFJLABDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class IMFALNJNJOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly IMFALNJNJOP CENLOHBLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action JMDPHDEMCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool FEHOKBMGFLG;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public IMFALNJNJOP(Action JMDPHDEMCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7711BD0", Offset = "0x7710DD0", VA = "0x187711BD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface KNGCLKEEHIP<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T CADNOMLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PKCDPBMKDDK(UnityEngine.Object IBLIOEFMDMM, Action<T> BPBJHCGMOPH);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface PJENKGLLENJ<T> : KNGCLKEEHIP<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T CADNOMLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class PJDDMAJNFEA<T> : PJENKGLLENJ<T>, KNGCLKEEHIP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class DCDJHCEKHFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public PJDDMAJNFEA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public HAMAAIFHDEF<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DCDJHCEKHFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6378AA0", Offset = "0x6377CA0", VA = "0x186378AA0")]
		internal void BGOIDHKBCFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject JCJIBEDINGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<HAMAAIFHDEF<UnityEngine.Object, Action<T>>> HOGFBAFMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T POIKBKLOBIK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T CADNOMLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xC04650", Offset = "0xC03850", VA = "0x180C04650", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x512DB90", Offset = "0x512CD90", VA = "0x18512DB90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x512E290", Offset = "0x512D490", VA = "0x18512E290")]
	private static bool OILHHDGCEFB(T IHGFIECIOLJ, T FHOBAJOBBGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x512E7A0", Offset = "0x512D9A0", VA = "0x18512E7A0")]
	public PJDDMAJNFEA(T CAPANFIICFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x512E530", Offset = "0x512D730", VA = "0x18512E530", Slot = "6")]
	public IDisposable PKCDPBMKDDK(UnityEngine.Object IBLIOEFMDMM, Action<T> BPBJHCGMOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x512DC30", Offset = "0x512CE30", VA = "0x18512DC30")]
	private void JEEFAMJCNBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class DJJKMOCBOFJ : EPPLHJMCMBA
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class ENDCNNNMPDJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class BLJAKMMCAKG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int JDNOHHGIHEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private ENDCNNNMPDJ HIFNOPIHKOC;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xD978B0", Offset = "0xD96AB0", VA = "0x180D978B0")]
			public BLJAKMMCAKG(int JDNOHHGIHEO, ENDCNNNMPDJ HIFNOPIHKOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x80421B0", Offset = "0x80413B0", VA = "0x1880421B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class KKFCIIGCLIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public KKFCIIGCLIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xCB1360", Offset = "0xCB0560", VA = "0x180CB1360")]
			internal bool HNBMAFKLIIE(OBHOMELBLCJ e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class JJPMCKPFFHJ : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private DEPLMKJKOMK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public ENDCNNNMPDJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public EFFGNPFPGCE timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private GGEBJJJDKAD <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<OBHOMELBLCJ> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
			[DebuggerHidden]
			public JJPMCKPFFHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8051210", Offset = "0x8050410", VA = "0x188051210", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8051540", Offset = "0x8050740", VA = "0x188051540", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly ENANHDDEDLG PONIMGFCIDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private PHFJKNHMAKK DKIHAOLPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<OBHOMELBLCJ> NGFNHFEAIDO;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8049C50", Offset = "0x8048E50", VA = "0x188049C50")]
		public ENDCNNNMPDJ(ENANHDDEDLG PONIMGFCIDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8049AC0", Offset = "0x8048CC0", VA = "0x188049AC0")]
		public IDisposable JOKBNJCNPAG(OBHOMELBLCJ PLCJOILAEMA, HHDHIMDCBCN CAKLLNDAEHB, EFFGNPFPGCE MLINJELIMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8049850", Offset = "0x8048A50", VA = "0x188049850")]
		private void CMBIPPLANAP(int JDNOHHGIHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8049A30", Offset = "0x8048C30", VA = "0x188049A30")]
		[IteratorStateMachine(typeof(JJPMCKPFFHJ))]
		private IEnumerator<DEPLMKJKOMK> IEHGNHIFBCN(EFFGNPFPGCE MLINJELIMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x80499E0", Offset = "0x8048BE0", VA = "0x1880499E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class OBHOMELBLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum ENMDBDMBINI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int FGPBCEAFGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int HOJBPJFAOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly LCCLDLHOIOG ADOPBHOJDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour KHAFPBOEPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action DJHAIOPCIPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> EIMDLGFCOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float DPIDKHKADJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float HNLDAMCHDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string FOBFABOAOEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool NHELAMOLPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly ENMDBDMBINI MDIJAGLLEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool DILHCPACMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool PBIMMLLDMNB;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x805A990", Offset = "0x8059B90", VA = "0x18805A990")]
		public OBHOMELBLCJ(LCCLDLHOIOG IBLIOEFMDMM, Action CPCMNBFFKHP, bool GONBCHOMILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x805ACF0", Offset = "0x8059EF0", VA = "0x18805ACF0")]
		public OBHOMELBLCJ(LCCLDLHOIOG IBLIOEFMDMM, Action<float> CPCMNBFFKHP, bool GONBCHOMILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x805AB10", Offset = "0x8059D10", VA = "0x18805AB10")]
		public OBHOMELBLCJ(LCCLDLHOIOG IBLIOEFMDMM, float ICNOJKMHEGP, Action<float> CPCMNBFFKHP, EFFGNPFPGCE MLINJELIMFI, ENMDBDMBINI DGNAKLEIBPN, bool IGNDLPJKCOC, bool GONBCHOMILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x805A7C0", Offset = "0x80599C0", VA = "0x18805A7C0")]
		public bool DHFHPCGBGGO(float HFMGEOLGMMO, float ALNCKHBPHAC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly HHDHIMDCBCN CAKLLNDAEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly EFFGNPFPGCE KAGEOEHJPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<ENANHDDEDLG, ENDCNNNMPDJ> KNMICKEGOJI;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8047F30", Offset = "0x8047130", VA = "0x188047F30")]
	[LDKBBAENJDF.JPBGCAANJAC]
	internal static void NMJIKJFEHOM(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x80480E0", Offset = "0x80472E0", VA = "0x1880480E0")]
	[UnityEngine.Scripting.Preserve]
	internal DJJKMOCBOFJ([KMMHIEIDBEA(null)] HHDHIMDCBCN CAKLLNDAEHB, [KMMHIEIDBEA(null)] EFFGNPFPGCE KAGEOEHJPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8047A50", Offset = "0x8046C50", VA = "0x188047A50", Slot = "4")]
	public IDisposable DJHAIOPCIPI(LCCLDLHOIOG IBLIOEFMDMM, Action GIIPLELNBKP, ENANHDDEDLG PONIMGFCIDF, bool GONBCHOMILD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8047C40", Offset = "0x8046E40", VA = "0x188047C40", Slot = "5")]
	public IDisposable DJHAIOPCIPI(LCCLDLHOIOG IBLIOEFMDMM, Action<float> GIIPLELNBKP, ENANHDDEDLG PONIMGFCIDF, bool GONBCHOMILD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x8047790", Offset = "0x8046990", VA = "0x188047790", Slot = "7")]
	public IDisposable CAADOBHPEGO(LCCLDLHOIOG IBLIOEFMDMM, float ICNOJKMHEGP, Action<float> GIIPLELNBKP, ENANHDDEDLG PONIMGFCIDF, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x8047E30", Offset = "0x8047030", VA = "0x188047E30", Slot = "8")]
	public IDisposable EMCDCKJDOHK(LCCLDLHOIOG IBLIOEFMDMM, float ICNOJKMHEGP, Action<float> GIIPLELNBKP, ENANHDDEDLG PONIMGFCIDF, bool IGNDLPJKCOC = true, bool GONBCHOMILD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8047610", Offset = "0x8046810", VA = "0x188047610", Slot = "6")]
	public IDisposable CAADOBHPEGO(float ICNOJKMHEGP, Action<float> GIIPLELNBKP, bool IGNDLPJKCOC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8047890", Offset = "0x8046A90", VA = "0x188047890", Slot = "9")]
	public void DICECPNPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8047FA0", Offset = "0x80471A0", VA = "0x188047FA0")]
	private ENDCNNNMPDJ OFJEIMMEJBC(ENANHDDEDLG PONIMGFCIDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class HODKGMALDAL : INFLGJHHFON, HHDHIMDCBCN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private KAEHBIPBGPO[] AGJBCMFMKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private KAKJJICIHNC KGNAJLNGKPL;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x804D540", Offset = "0x804C740", VA = "0x18804D540")]
	[LDKBBAENJDF.JPBGCAANJAC]
	internal static void JHDFHEGIBHJ(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x804DA00", Offset = "0x804CC00", VA = "0x18804DA00")]
	[UnityEngine.Scripting.Preserve]
	public HODKGMALDAL([KMMHIEIDBEA(null)] AMADEAABKJE KKCCAJCKAOD, [KMMHIEIDBEA(null)] EFFGNPFPGCE KAGEOEHJPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x804D3E0", Offset = "0x804C5E0", VA = "0x18804D3E0", Slot = "19")]
	public override PHFJKNHMAKK FGEMPPBBLLE(GHOJMPLOGCA IBLIOEFMDMM, IEnumerator<DEPLMKJKOMK> IKGHEFFLHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x804CF80", Offset = "0x804C180", VA = "0x18804CF80", Slot = "20")]
	public override void DICECPNPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x804D5B0", Offset = "0x804C7B0", VA = "0x18804D5B0", Slot = "22")]
	public override void OGFHAHKFHGH(ENANHDDEDLG PONIMGFCIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x804D210", Offset = "0x804C410", VA = "0x18804D210", Slot = "21")]
	protected override void DJHAIOPCIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x804D510", Offset = "0x804C710", VA = "0x18804D510")]
	private KAEHBIPBGPO IINGKGGCEEK(ENANHDDEDLG NNILCBOLNDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x804D7E0", Offset = "0x804C9E0", VA = "0x18804D7E0", Slot = "23")]
	internal override LGKDDGAAOHD PFPIGLOAJAD(IEnumerator<DEPLMKJKOMK> IKGHEFFLHDK, Behaviour IBLIOEFMDMM, BBOFDCOEFNG DKIHAOLPIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x804CEC0", Offset = "0x804C0C0", VA = "0x18804CEC0", Slot = "24")]
	internal override KHPLJLKMDFP CBHGILNLKID(ENANHDDEDLG HIFNOPIHKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x804CDA0", Offset = "0x804BFA0", VA = "0x18804CDA0")]
	private void AOLPHEBMBCL(KAEHBIPBGPO KOHHNPMDNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x804D380", Offset = "0x804C580", VA = "0x18804D380", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct LEAFBDLBEJE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float OJBFIOODJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int HIFMNJEIGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> LECEHBJEBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> PFJHGABHGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> ICLDJABFBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<OHNBFKOIADG> LKGBJALAHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> IPFENMGOPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> KKLFHCBBIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> DJPMCCGFPFP;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8056B10", Offset = "0x8055D10", VA = "0x188056B10")]
	public static LEAFBDLBEJE JENMMFKNHKF(int HNMPLGPJBOJ, float IJEINPFHNPG, NativeArray<OHNBFKOIADG> IJMMNOKHIKK, NativeArray<float> DNGKALNFCLL, NativeArray<int> DEFECLLIFKL, NativeArray<int> GFBNBPCBKIF, NativeArray<int> PANCJIPGJPC, NativeArray<int> PFJHGABHGMI, NativeArray<int> ICLDJABFBDE)
	{
		return default(LEAFBDLBEJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8056880", Offset = "0x8055A80", VA = "0x188056880", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8056960", Offset = "0x8055B60", VA = "0x188056960")]
	private bool GAKNNMBBPPM(int KOOLKCPAFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8056850", Offset = "0x8055A50", VA = "0x188056850")]
	private void EDNDBDKHMBO(NativeArray<int> LOJLBKJLMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x80569A0", Offset = "0x8055BA0", VA = "0x1880569A0")]
	private int HALPCFCMMPC(int INGEHJNJKHC, int CAMMFEJJAKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8056A40", Offset = "0x8055C40", VA = "0x188056A40")]
	private void IKGNPHLHOAH(NativeArray<int> LOJLBKJLMJL, int AAMMEKGENCM, int LIBECIMLPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8056B70", Offset = "0x8055D70", VA = "0x188056B70")]
	private void NFCKOLNMGPL(NativeArray<int> LOJLBKJLMJL, int NMOJEKFGMCA, int NBMLLNEMEJM, int FEHCAONCIMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class INFLGJHHFON : HHDHIMDCBCN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly AMADEAABKJE KKCCAJCKAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly EFFGNPFPGCE KAGEOEHJPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private KHPLJLKMDFP[] CLMGJPJJBIE;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static HHDHIMDCBCN JLGHKLNHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x804F9F0", Offset = "0x804EBF0", VA = "0x18804F9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool OBBODMNOFFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ENANHDDEDLG IOLDDHGPNMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(ENANHDDEDLG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x971850", Offset = "0x970A50", VA = "0x180971850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public EFFGNPFPGCE FFEAJECBAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public DEPLMKJKOMK CLANNLDBEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public DEPLMKJKOMK NJKBDDIICLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x96A6B0", Offset = "0x9698B0", VA = "0x18096A6B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public DEPLMKJKOMK BDEBMNGHAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DEPLMKJKOMK OHBGHJFDLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960830", VA = "0x180961630", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x804FA60", Offset = "0x804EC60", VA = "0x18804FA60")]
	public static PHFJKNHMAKK MKBLDOBCGON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x804FF30", Offset = "0x804F130", VA = "0x18804FF30")]
	[UnityEngine.Scripting.Preserve]
	protected INFLGJHHFON([KMMHIEIDBEA(null)] AMADEAABKJE KKCCAJCKAOD, [KMMHIEIDBEA(null)] EFFGNPFPGCE KAGEOEHJPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x804F7E0", Offset = "0x804E9E0", VA = "0x18804F7E0", Slot = "6")]
	public PHFJKNHMAKK IDKCINHHAJH(IEnumerator<DEPLMKJKOMK> IKGHEFFLHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x804F7F0", Offset = "0x804E9F0", VA = "0x18804F7F0", Slot = "7")]
	public PHFJKNHMAKK IDKCINHHAJH(Behaviour IBLIOEFMDMM, IEnumerator<DEPLMKJKOMK> IKGHEFFLHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract PHFJKNHMAKK FGEMPPBBLLE(GHOJMPLOGCA IBLIOEFMDMM, IEnumerator<DEPLMKJKOMK> IKGHEFFLHDK);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x804EFF0", Offset = "0x804E1F0", VA = "0x18804EFF0", Slot = "20")]
	public virtual void DICECPNPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x804FCF0", Offset = "0x804EEF0", VA = "0x18804FCF0", Slot = "9")]
	public void PNLGMDLJNCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x804F190", Offset = "0x804E390", VA = "0x18804F190", Slot = "21")]
	protected virtual void DJHAIOPCIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x804EFD0", Offset = "0x804E1D0", VA = "0x18804EFD0")]
	private void AGDPFHFDPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x804F7A0", Offset = "0x804E9A0", VA = "0x18804F7A0")]
	private void FLENHAKCOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x804FCD0", Offset = "0x804EED0", VA = "0x18804FCD0")]
	private void PNGPGKBPEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x804F7C0", Offset = "0x804E9C0", VA = "0x18804F7C0")]
	private void HKIAAIILALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x804F1B0", Offset = "0x804E3B0", VA = "0x18804F1B0")]
	private void DKBKBNGEENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x804F780", Offset = "0x804E980", VA = "0x18804F780")]
	private void FJLJCHBHMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x804F590", Offset = "0x804E790", VA = "0x18804F590")]
	private void EBIHFIFIHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x804FBE0", Offset = "0x804EDE0", VA = "0x18804FBE0", Slot = "22")]
	public virtual void OGFHAHKFHGH(ENANHDDEDLG PONIMGFCIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x804F5B0", Offset = "0x804E7B0", VA = "0x18804F5B0")]
	private void ECGPDPKAELH(KHPLJLKMDFP KOHHNPMDNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x24BB410", Offset = "0x24BA610", VA = "0x1824BB410")]
	private KHPLJLKMDFP HLFLMPIEHED(ENANHDDEDLG NNILCBOLNDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract LGKDDGAAOHD PFPIGLOAJAD(IEnumerator<DEPLMKJKOMK> IKGHEFFLHDK, Behaviour OCKFPLAMBGC, BBOFDCOEFNG HJHHIEGBPJJ);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract KHPLJLKMDFP CBHGILNLKID(ENANHDDEDLG PONIMGFCIDF);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x804F1D0", Offset = "0x804E3D0", VA = "0x18804F1D0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x804FC70", Offset = "0x804EE70", VA = "0x18804FC70", Slot = "15")]
	public DEPLMKJKOMK ONKGMODIOFD(ENANHDDEDLG HIFNOPIHKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x804FB50", Offset = "0x804ED50", VA = "0x18804FB50", Slot = "16")]
	public DEPLMKJKOMK NIIDOHBCONG(float KDJGAOFKCEM, ENANHDDEDLG HIFNOPIHKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x804FAF0", Offset = "0x804ECF0", VA = "0x18804FAF0", Slot = "17")]
	public DEPLMKJKOMK MODNLNOLEPJ(Func<bool> FPPMNPIKPAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class LGKDDGAAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly BBOFDCOEFNG DKIHAOLPIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly DNOIFFHOJHI IBLIOEFMDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool JCCGOAGPLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string MBDFMCIDAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace NKOBNJPJPCJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<DEPLMKJKOMK> NGNCMLDINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DEPLMKJKOMK CHGNKNOKAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool OHJNCGEGDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8057280", Offset = "0x8056480", VA = "0x188057280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool CEHINAOGDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xB05410", Offset = "0xB04610", VA = "0x180B05410")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xB52430", Offset = "0xB51630", VA = "0x180B52430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string FOBFABOAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x80570D0", Offset = "0x80562D0", VA = "0x1880570D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float JGHEEOMPEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xEFE5E0", Offset = "0xEFD7E0", VA = "0x180EFE5E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6A67DF0", Offset = "0x6A66FF0", VA = "0x186A67DF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x80574A0", Offset = "0x80566A0", VA = "0x1880574A0")]
	public LGKDDGAAOHD(IEnumerator<DEPLMKJKOMK> FKOCJNFKHDG, DNOIFFHOJHI IBLIOEFMDMM, BBOFDCOEFNG DKIHAOLPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8056DB0", Offset = "0x8055FB0", VA = "0x188056DB0")]
	public DEPLMKJKOMK HJBADGAOCAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8057300", Offset = "0x8056500", VA = "0x188057300")]
	public bool NHMENLNNOEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8057370", Offset = "0x8056570", VA = "0x188057370")]
	public void OGCCBPDGCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x80573C0", Offset = "0x80565C0", VA = "0x1880573C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xB98920", Offset = "0xB97B20", VA = "0x180B98920")]
	[CompilerGenerated]
	private void FGNJOBCBONN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class BBOFDCOEFNG : JFIFLFLLDOF, PHFJKNHMAKK, EMKGHLOECBM, LHBFOPKLGGA, IEnumerator, DEPLMKJKOMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private ENANHDDEDLG ICPBBGLELOE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private ENANHDDEDLG PEAKLLHPHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xC56DA0", Offset = "0xC55FA0", VA = "0x180C56DA0", Slot = "23")]
		get
		{
			return default(ENANHDDEDLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ENANHDDEDLG EIOJACFEHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xDF7EC0", Offset = "0xDF70C0", VA = "0x180DF7EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float BECGLCHIPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAC8270", Offset = "0xAC7470", VA = "0x180AC8270", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool GOCDKFEKMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8041A20", Offset = "0x8040C20", VA = "0x188041A20", Slot = "24")]
	private bool GDHEKINFDIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8041A10", Offset = "0x8040C10", VA = "0x188041A10", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8041A40", Offset = "0x8040C40", VA = "0x188041A40")]
	public BBOFDCOEFNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum FNLNCBOCACC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class KHPLJLKMDFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum MIBPCBEAFDM
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct BBDIBKBFLLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public ENANHDDEDLG JBAEPKMBFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public MIBPCBEAFDM PIGFMLENMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<LGKDDGAAOHD> GDDJCLCBBDN;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly MIBPCBEAFDM[] FJOACFADONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly ENANHDDEDLG PONIMGFCIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool KBACOOCFLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly LGKDDGAAOHD[] LEOHPBMMDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<LGKDDGAAOHD> HKFIDFLKLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> LFLLIMEBIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<LGKDDGAAOHD> FGOJJIAPLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> CDKCBLGCNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly KAKJJICIHNC JPENEJDNNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool MMPPABGHOOI;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BBDIBKBFLLH[,] AILHFAOHGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8055CA0", Offset = "0x8054EA0", VA = "0x188055CA0")]
	public KHPLJLKMDFP(ENANHDDEDLG HIFNOPIHKOC, KAKJJICIHNC JPENEJDNNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8054B90", Offset = "0x8053D90", VA = "0x188054B90")]
	public void CMLPBGLGMNB(LGKDDGAAOHD FKOCJNFKHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8055680", Offset = "0x8054880", VA = "0x188055680")]
	public void PJEFMEFHFKN(IList<LGKDDGAAOHD> DMOIOHGBOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8055380", Offset = "0x8054580", VA = "0x188055380")]
	public void MNEIHJKPJJO(IList<LGKDDGAAOHD> DMOIOHGBOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8054740", Offset = "0x8053940", VA = "0x188054740")]
	private void ANPMIGHODFL(LGKDDGAAOHD FKOCJNFKHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x80551F0", Offset = "0x80543F0", VA = "0x1880551F0")]
	private void JDPKEOBAEOP(IList<LGKDDGAAOHD> DMOIOHGBOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8055070", Offset = "0x8054270", VA = "0x188055070")]
	private FNLNCBOCACC IKIBKEMLPMB(LGKDDGAAOHD FKOCJNFKHDG)
	{
		return default(FNLNCBOCACC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8054CA0", Offset = "0x8053EA0", VA = "0x188054CA0")]
	public void DJHAIOPCIPI(float IJEINPFHNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8055980", Offset = "0x8054B80", VA = "0x188055980")]
	public void PNLGMDLJNCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8054830", Offset = "0x8053A30", VA = "0x188054830")]
	private void BGCEFGNLMLA(List<LGKDDGAAOHD> DMOIOHGBOIC, Stack<int> MHNILPHKBAF, bool OPPLKAJANFI, float INKAAINCJIF = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8054E10", Offset = "0x8054010", VA = "0x188054E10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8054F30", Offset = "0x8054130", VA = "0x188054F30")]
	private void ECKLCOFEFEB(List<LGKDDGAAOHD> DMOIOHGBOIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class DHMJGGPOBIC : KAKJJICIHNC
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
	public void PNAHJADIKBC(string MBDFMCIDAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
	public void AIGMDLHPAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DHMJGGPOBIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class DNEJPJFGIOF : DNOIFFHOJHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour OCKFPLAMBGC;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string FOBFABOAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x80481C0", Offset = "0x80473C0", VA = "0x1880481C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LEEPFAKCGED
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8048240", Offset = "0x8047440", VA = "0x188048240", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool AFEOGAMCBBL
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x80481A0", Offset = "0x80473A0", VA = "0x1880481A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public DNEJPJFGIOF(Behaviour OCKFPLAMBGC)
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

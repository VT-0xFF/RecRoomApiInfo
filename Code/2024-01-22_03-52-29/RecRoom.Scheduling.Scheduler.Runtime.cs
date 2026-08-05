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
public class PIAGDEDOAHI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority KLDIIIBIMIH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6730150", Offset = "0x672F550", VA = "0x186730150")]
	public PIAGDEDOAHI(ThreadPriority KOGFIHBALGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6730140", Offset = "0x672F540", VA = "0x186730140", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> KOOBIAPEOLC(List<PlayerLoopSystem> ACFNMPOFKDJ, int ENPKFMIIEKO);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct IFFJCIBEFJE
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct MMLMCLBMGOL
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static DECPPMKECOG AGDEGPKFEEP;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x672A6C0", Offset = "0x6729AC0", VA = "0x18672A6C0")]
				public static PlayerLoopSystem PHFNIHDHDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct PFOOEIIGEJL
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static DECPPMKECOG ACOJMAFNOCG;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x672F6E0", Offset = "0x672EAE0", VA = "0x18672F6E0")]
				public static PlayerLoopSystem PHFNIHDHDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct LKFBLKMPKGB
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static DECPPMKECOG IEOOMKEHOGM;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6729440", Offset = "0x6728840", VA = "0x186729440")]
				public static PlayerLoopSystem PHFNIHDHDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct LKPCNHKOHCC
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static DECPPMKECOG FACHIGIDOLI;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static DECPPMKECOG KGBLCGLMEPM;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static DECPPMKECOG LFCDOKKMBBJ;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static DECPPMKECOG NHNIHNJMDKD;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x6729930", Offset = "0x6728D30", VA = "0x186729930")]
				public static PlayerLoopSystem PHFNIHDHDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct LMELJHOKDHP
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static DECPPMKECOG IFMJLNBEDKC;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x6729C20", Offset = "0x6729020", VA = "0x186729C20")]
				public static PlayerLoopSystem PHFNIHDHDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct LKNGMFJGBBO
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static DECPPMKECOG FACHIGIDOLI;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static DECPPMKECOG KGBLCGLMEPM;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static DECPPMKECOG LFCDOKKMBBJ;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static DECPPMKECOG NHNIHNJMDKD;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x6729640", Offset = "0x6728A40", VA = "0x186729640")]
				public static PlayerLoopSystem PHFNIHDHDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct FMJCIEPDMDH
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static DECPPMKECOG EJHFDOODODH;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x671FB40", Offset = "0x671EF40", VA = "0x18671FB40")]
				public static PlayerLoopSystem PHFNIHDHDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct CLANGFGJOML
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static DECPPMKECOG JCLINCBBFGN;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6718A10", Offset = "0x6717E10", VA = "0x186718A10")]
				public static PlayerLoopSystem PHFNIHDHDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct KMLPNGNONNC
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static DECPPMKECOG MGMMBFEFEHL;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6728550", Offset = "0x6727950", VA = "0x186728550")]
				public static PlayerLoopSystem PHFNIHDHDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct HFBICLDGLFH
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static DECPPMKECOG BPMBEEDJJJO;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6724C20", Offset = "0x6724020", VA = "0x186724C20")]
				public static PlayerLoopSystem PHFNIHDHDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct NDAEPOGGLCH
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static DECPPMKECOG PJLOHPMDAJP;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x672B060", Offset = "0x672A460", VA = "0x18672B060")]
				public static PlayerLoopSystem PHFNIHDHDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct NJBPIDACKPA
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static DECPPMKECOG HDNBEMLPLPD;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x672CC20", Offset = "0x672C020", VA = "0x18672CC20")]
				public static PlayerLoopSystem PHFNIHDHDAO()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum FLEPMEHOFPB : byte
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
			public struct CEGJIMNIKOJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class ABALOIMLJJN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public FLEPMEHOFPB updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
					public ABALOIMLJJN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x6715020", Offset = "0x6714420", VA = "0x186715020")]
					internal void HHGDGMDFCDB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static NFAKNFEBDCB<FLEPMEHOFPB> EBBCIMOBGIN;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6716780", Offset = "0x6715B80", VA = "0x186716780")]
				public static PlayerLoopSystem PHFNIHDHDAO(FLEPMEHOFPB NJLIEDIPAEI)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct ANDFFMLNBNJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class PCMKJAFLGLO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public GHLGOJHFDOB.BOKBJPDKNFJ key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
					public PCMKJAFLGLO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x672F4A0", Offset = "0x672E8A0", VA = "0x18672F4A0")]
					internal void PHLDCNOMAEO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable GAAEBLMCIHD;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x6715100", Offset = "0x6714500", VA = "0x186715100")]
				public static PlayerLoopSystem FABPMNFJANC(GHLGOJHFDOB.BOKBJPDKNFJ CONEAMPCFEL)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct OPJHBAINIDJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class DIPGEDDEGMO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public GHLGOJHFDOB.BOKBJPDKNFJ key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
					public DIPGEDDEGMO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x671DC40", Offset = "0x671D040", VA = "0x18671DC40")]
					internal void PHLDCNOMAEO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x672DB60", Offset = "0x672CF60", VA = "0x18672DB60")]
				public static PlayerLoopSystem FABPMNFJANC(GHLGOJHFDOB.BOKBJPDKNFJ CONEAMPCFEL)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class BHKNMNGLOGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public BHKNMNGLOGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x67155E0", Offset = "0x67149E0", VA = "0x1867155E0")]
			internal List<PlayerLoopSystem> KFMJLILJDPK(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KHLDEFCMBOD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool GMHILHHDLBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x671A270", Offset = "0x6719670", VA = "0x18671A270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x671B250", Offset = "0x671A650", VA = "0x18671B250")]
		private static void OOFHGIBKFHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x671A690", Offset = "0x6719A90", VA = "0x18671A690")]
		private static void IPEIFPMAJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x671A040", Offset = "0x6719440", VA = "0x18671A040")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x671B090", Offset = "0x671A490", VA = "0x18671B090")]
		private static void NCDPNCGGGPI(GHLGOJHFDOB.BOKBJPDKNFJ CONEAMPCFEL, PlayerLoopSystem IDFBKBBBDJK, Type DKBIODMLDGI, Type LNHGMNFOJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x671A2B0", Offset = "0x67196B0", VA = "0x18671A2B0")]
		private static void IMMKGGAPOLB(PlayerLoopSystem IDFBKBBBDJK, Type DKBIODMLDGI, Type LNHGMNFOJOG, KOOBIAPEOLC GDGNBGMHLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x671AF60", Offset = "0x671A360", VA = "0x18671AF60")]
		private static void MPAALDHDEGA(PlayerLoopSystem IDFBKBBBDJK, Type DKBIODMLDGI, Type LNHGMNFOJOG, PlayerLoopSystem? KKPBHKDKJDM, PlayerLoopSystem? AOAAIHEFJDA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GHLGOJHFDOB
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum BOKBJPDKNFJ
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
	public class AOHEFKMNCAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly BOKBJPDKNFJ HMLHCIDDMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly GPEPFFEDMCA POGMHHCEIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long GIKIHCLGCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long INMJICDGIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long FGPJNJNLOJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int LPDMBKAAPPK;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x67154D0", Offset = "0x67148D0", VA = "0x1867154D0")]
		public AOHEFKMNCAI(BOKBJPDKNFJ CELIBNMNEIM, int HEDDGLJJNAE = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6715280", Offset = "0x6714680", VA = "0x186715280")]
		public void HCDKENCGNIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6715230", Offset = "0x6714630", VA = "0x186715230")]
		public void GKBNCPAPKEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x67152F0", Offset = "0x67146F0", VA = "0x1867152F0")]
		public void PKONFNLHOIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static BOKBJPDKNFJ[] AOEJIFFKFPK;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static AOHEFKMNCAI[] LHMNMFPBCJI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x67236B0", Offset = "0x6722AB0", VA = "0x1867236B0")]
	public static AOHEFKMNCAI AOOGLEPDMFA(BOKBJPDKNFJ CONEAMPCFEL, int HEDDGLJJNAE = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6723930", Offset = "0x6722D30", VA = "0x186723930")]
	public static AOHEFKMNCAI JOKIFIJHKLJ(BOKBJPDKNFJ CONEAMPCFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6723890", Offset = "0x6722C90", VA = "0x186723890")]
	public static void HDPHDOADCND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GPEPFFEDMCA : CECGDKLBKDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int GIIJGLKGIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> MFEJLAKMNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double BMPNIIEFPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double NNAEFEPNKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double IBILABEPOMO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double CPEGPHAFNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x67249F0", Offset = "0x6723DF0", VA = "0x1867249F0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double KLPCLFMMPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1755D80", Offset = "0x1755180", VA = "0x181755D80", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double EHDNFPOBNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6090", Offset = "0x1CE5490", VA = "0x181CE6090", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6724B70", Offset = "0x6723F70", VA = "0x186724B70")]
	public GPEPFFEDMCA(int CKDHBMAOJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6724A50", Offset = "0x6723E50", VA = "0x186724A50", Slot = "7")]
	public void NKKEHFHKMCG(double OFNBMJMBJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6724980", Offset = "0x6723D80", VA = "0x186724980", Slot = "8")]
	public void AIKIIHKLAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HOBNPMOCDOK : CECGDKLBKDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long GNHCGOJHAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double GPJOMCAMBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double GJKJKAKBGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double JNMMCDAGNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double MEEKFNGNDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double BMPNIIEFPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double NNAEFEPNKEA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double KLPCLFMMPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5648EE0", Offset = "0x56482E0", VA = "0x185648EE0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double EHDNFPOBNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5648F20", Offset = "0x5648320", VA = "0x185648F20", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double OHEHFBHGKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5648F50", Offset = "0x5648350", VA = "0x185648F50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double CPEGPHAFNOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x21603E0", Offset = "0x215F7E0", VA = "0x1821603E0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6725000", Offset = "0x6724400", VA = "0x186725000", Slot = "7")]
	public virtual void NKKEHFHKMCG(double OFNBMJMBJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6724FC0", Offset = "0x67243C0", VA = "0x186724FC0", Slot = "8")]
	public virtual void AIKIIHKLAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6724F90", Offset = "0x6724390", VA = "0x186724F90")]
	public HOBNPMOCDOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HIPBKJAOGAE : HOBNPMOCDOK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double DAOIFMCLKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5648E70", Offset = "0x5648270", VA = "0x185648E70")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5648F40", Offset = "0x5648340", VA = "0x185648F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6724E60", Offset = "0x6724260", VA = "0x186724E60", Slot = "7")]
	public override void NKKEHFHKMCG(double OFNBMJMBJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6724E20", Offset = "0x6724220", VA = "0x186724E20", Slot = "8")]
	public override void AIKIIHKLAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6724F90", Offset = "0x6724390", VA = "0x186724F90")]
	public HIPBKJAOGAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface CECGDKLBKDI
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double CPEGPHAFNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double KLPCLFMMPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double EHDNFPOBNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class MIIFDCEPCAC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface LOKDHIMJDLF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool DAKIJBJFOPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LBKEKNGOEKH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class KHMOGMFAEFD<TPromise, TMainThreadPromise> : LOKDHIMJDLF where TPromise : DONEJHADFEN where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise BDDMOGBHBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise EGCKGJPMPDC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise FBOEALAGNIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3B43450", Offset = "0x3B42850", VA = "0x183B43450")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DAKIJBJFOPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3B434D0", Offset = "0x3B428D0", VA = "0x183B434D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7999C0", Offset = "0x798DC0", VA = "0x1807999C0")]
		protected KHMOGMFAEFD(TPromise BDDMOGBHBEF, TMainThreadPromise DPPCECHDEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3B434B0", Offset = "0x3B428B0", VA = "0x183B434B0", Slot = "5")]
		public void LBKEKNGOEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void KIICHLDOCED(TPromise BDDMOGBHBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class CPBDIALFGCG<T> : KHMOGMFAEFD<BIDJOPNIEEO<T>, BFHEMFPMLCM<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4C8D230", Offset = "0x4C8C630", VA = "0x184C8D230")]
		public CPBDIALFGCG(BIDJOPNIEEO<T> BDDMOGBHBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4C8D080", Offset = "0x4C8C480", VA = "0x184C8D080", Slot = "6")]
		protected override void KIICHLDOCED(BIDJOPNIEEO<T> BDDMOGBHBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x324BB00", Offset = "0x324AF00", VA = "0x18324BB00")]
		[CompilerGenerated]
		private void IKKMKOKPBLP(T APCONDCGDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4C8D050", Offset = "0x4C8C450", VA = "0x184C8D050")]
		[CompilerGenerated]
		private void AJEKGBJFOBF(string HNINMPIFBCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class IFGCBBHHCKP : LOKDHIMJDLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action EEEBGEOHFMI;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool DAKIJBJFOPC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
		public IFGCBBHHCKP(Action EEEBGEOHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB9A2B0", Offset = "0xB996B0", VA = "0x180B9A2B0", Slot = "5")]
		public void LBKEKNGOEKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<LOKDHIMJDLF> HDALBLMIOFN;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x26F3510", Offset = "0x26F2910", VA = "0x1826F3510")]
	public static BIDJOPNIEEO<T> EBBJPDGMGKO<T>(this BIDJOPNIEEO<T> BDDMOGBHBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6729E90", Offset = "0x6729290", VA = "0x186729E90")]
	public static void EBBJPDGMGKO(Action EEEBGEOHFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x26F3570", Offset = "0x26F2970", VA = "0x1826F3570")]
	private static BIDJOPNIEEO<T> GCJKNLHCNEG<T>(BIDJOPNIEEO<T> BDDMOGBHBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x672A110", Offset = "0x6729510", VA = "0x18672A110")]
	private static void KJDABNPHCEN(LOKDHIMJDLF HOCLJMLPAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x672A320", Offset = "0x6729720", VA = "0x18672A320")]
	private static void MCDOOJJMKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6729F30", Offset = "0x6729330", VA = "0x186729F30")]
	private static void IIPJEGCKENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x672A030", Offset = "0x6729430", VA = "0x18672A030")]
	private static void JHGHKJODBGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class CGOGHFKDGKC
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct GNFDLPDDAGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> PCNCLGIFCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string FAHIAKAEJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode CDDICGAPBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool KHCEDLAFEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly CMHFDFEDOCF<string>.NHIEDOHKMHG IKAOEHOFHFG;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6723D60", Offset = "0x6723160", VA = "0x186723D60")]
		public GNFDLPDDAGH(TaskCompletionSource<Scene> HKIDIBCINJK, string FAHIAKAEJIA, LoadSceneMode CDDICGAPBLD, bool KHCEDLAFEJD, CMHFDFEDOCF<string>.NHIEDOHKMHG IKAOEHOFHFG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct EEEHJFHDJAB : IAsyncStateMachine
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
		public CMHFDFEDOCF<string>.NHIEDOHKMHG stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private CMHFDFEDOCF<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x671E910", Offset = "0x671DD10", VA = "0x18671E910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x671F1B0", Offset = "0x671E5B0", VA = "0x18671F1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct EGOIJPFKKFJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x671F5D0", Offset = "0x671E9D0", VA = "0x18671F5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x671F8F0", Offset = "0x671ECF0", VA = "0x18671F8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct KHDGLJBJIBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private GNFDLPDDAGH <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x67280F0", Offset = "0x67274F0", VA = "0x1867280F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x67284A0", Offset = "0x67278A0", VA = "0x1867284A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class AEHEKBNCMEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BFHEMFPMLCM<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public AEHEKBNCMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x67150A0", Offset = "0x67144A0", VA = "0x1867150A0")]
		internal void FAJMGPMOIFL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct HONPODADKBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public CMHFDFEDOCF<string>.NHIEDOHKMHG stackTimer;

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
		private AEHEKBNCMEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private CMHFDFEDOCF<string>.NHIEDOHKMHG <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private CMHFDFEDOCF<string>.NHIEDOHKMHG <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x67259C0", Offset = "0x6724DC0", VA = "0x1867259C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6726560", Offset = "0x6725960", VA = "0x186726560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct PANKHOLIFLF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x672DC90", Offset = "0x672D090", VA = "0x18672DC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x672E1A0", Offset = "0x672D5A0", VA = "0x18672E1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct GNJHLHJNHFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CMHFDFEDOCF<string>.NHIEDOHKMHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private CMHFDFEDOCF<string>.NHIEDOHKMHG <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private CMHFDFEDOCF<string>.NHIEDOHKMHG <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6723DC0", Offset = "0x67231C0", VA = "0x186723DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6724910", Offset = "0x6723D10", VA = "0x186724910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class MLKMGEKLLJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public MLKMGEKLLJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x672A690", Offset = "0x6729A90", VA = "0x18672A690")]
		internal bool OONPJCFIBML()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class BJCCKBAPBBH : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public EJJODCOIBAE onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public BJCCKBAPBBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6715AE0", Offset = "0x6714EE0", VA = "0x186715AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6715700", Offset = "0x6714B00", VA = "0x186715700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6715A40", Offset = "0x6714E40", VA = "0x186715A40")]
		private void OPFNICOLGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6715A90", Offset = "0x6714E90", VA = "0x186715A90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class PHAJNEJNFMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public BFHEMFPMLCM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public PHAJNEJNFMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x672FE40", Offset = "0x672F240", VA = "0x18672FE40")]
		internal bool ANCOAJFCLNF(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x672FEC0", Offset = "0x672F2C0", VA = "0x18672FEC0")]
		internal void GAJPPCCCIBD(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class NKPBAEBDLBD : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public BFHEMFPMLCM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private PHAJNEJNFMP <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public NKPBAEBDLBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x672CE20", Offset = "0x672C220", VA = "0x18672CE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x672D530", Offset = "0x672C930", VA = "0x18672D530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> NCHIMPJHPMF;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static DONEJHADFEN KFPCBLENJCN;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation FDHGNBBPLJL;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static DONEJHADFEN FJFEEODBGBL;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string LEJANFFMLLM;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority NHMCJGAHLPJ;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task BMHFJEILKHL;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> FHMIKLKGCNN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<GNFDLPDDAGH> PHHHNMAJNAE;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task EFBLAJPOBJK;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool GILFIMGJJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6717350", Offset = "0x6716750", VA = "0x186717350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool FKEMHJABLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6716B20", Offset = "0x6715F20", VA = "0x186716B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool PMGFKHJOCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x67176F0", Offset = "0x6716AF0", VA = "0x1867176F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool AFBDANOMMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6716A90", Offset = "0x6715E90", VA = "0x186716A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> ADOCGKEDAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6717FA0", Offset = "0x67173A0", VA = "0x186717FA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6716BC0", Offset = "0x6715FC0", VA = "0x186716BC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6716990", Offset = "0x6715D90", VA = "0x186716990")]
	[ENPAFNLIOMH(MAAKBDKIBHC.EnteredEditModeNextFrame, 0)]
	private static void AAHBHNDGDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6717B80", Offset = "0x6716F80", VA = "0x186717B80")]
	[AsyncStateMachine(typeof(EEEHJFHDJAB))]
	public static Task<Scene> NCOELPKCPAE(string FAHIAKAEJIA, LoadSceneMode CDDICGAPBLD = LoadSceneMode.Single, bool KHCEDLAFEJD = false, [Optional] CMHFDFEDOCF<string>.NHIEDOHKMHG PFPDFAKPECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6717640", Offset = "0x6716A40", VA = "0x186717640")]
	[AsyncStateMachine(typeof(EGOIJPFKKFJ))]
	private static Task JHCELPJKGNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6717570", Offset = "0x6716970", VA = "0x186717570")]
	[AsyncStateMachine(typeof(KHDGLJBJIBA))]
	private static Task JGDHFHGPNJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6716CD0", Offset = "0x67160D0", VA = "0x186716CD0")]
	[AsyncStateMachine(typeof(HONPODADKBP))]
	private static Task<Scene> BOHDGDCKBOI(string FAHIAKAEJIA, LoadSceneMode CDDICGAPBLD, bool KHCEDLAFEJD, CMHFDFEDOCF<string>.NHIEDOHKMHG IKAOEHOFHFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6717A20", Offset = "0x6716E20", VA = "0x186717A20")]
	private static void MNPDOJHLJIN(SceneInstance JDMDDMDPEKF, LoadSceneMode CDDICGAPBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6716FB0", Offset = "0x67163B0", VA = "0x186716FB0")]
	private static void EIDIFMJKBOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6717100", Offset = "0x6716500", VA = "0x186717100")]
	[AsyncStateMachine(typeof(PANKHOLIFLF))]
	private static Task<Scene> FHFOBFIALIE(string FAHIAKAEJIA, LoadSceneMode CDDICGAPBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6716EC0", Offset = "0x67162C0", VA = "0x186716EC0")]
	private static bool EHDDAMHBCBJ(string FAHIAKAEJIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6717790", Offset = "0x6716B90", VA = "0x186717790")]
	[AsyncStateMachine(typeof(GNJHLHJNHFC))]
	private static Task<Scene> KOMFOHHPDDE(CMHFDFEDOCF<string>.NHIEDOHKMHG IKAOEHOFHFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67178A0", Offset = "0x6716CA0", VA = "0x1867178A0")]
	public static BIDJOPNIEEO<Scene> KOOGLCNLNIO(string FAHIAKAEJIA, LoadSceneMode CDDICGAPBLD = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6717CD0", Offset = "0x67170D0", VA = "0x186717CD0")]
	public static DONEJHADFEN OMOGCANNHFF(string FAHIAKAEJIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6717070", Offset = "0x6716470", VA = "0x186717070")]
	[IteratorStateMachine(typeof(BJCCKBAPBBH))]
	private static IEnumerator<LEOLCGBMIAN> EPMHAPGIOIK(string FAHIAKAEJIA, EJJODCOIBAE ALOFPKLELIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6716E20", Offset = "0x6716220", VA = "0x186716E20")]
	[IteratorStateMachine(typeof(NKPBAEBDLBD))]
	private static IEnumerator<LEOLCGBMIAN> DJLNIEGHKGO(string FAHIAKAEJIA, LoadSceneMode CDDICGAPBLD, BFHEMFPMLCM<Scene> ALOFPKLELIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6717220", Offset = "0x6716620", VA = "0x186717220")]
	public static bool GIMAFFBAKBM([Out] string NJGNMDLIHLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class EAAKAEPPGHA
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x671E760", Offset = "0x671DB60", VA = "0x18671E760")]
	public static IDisposable MFANNEDBCJA(this MGDBKGBBNLH AOGDICEMNLI, float JCJHMNEIBFN, Action<float> PEDGAJMEGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x671E660", Offset = "0x671DA60", VA = "0x18671E660")]
	public static IDisposable EGLIHHLAJCB(this MGDBKGBBNLH AOGDICEMNLI, Action<float> PEDGAJMEGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x671E6E0", Offset = "0x671DAE0", VA = "0x18671E6E0")]
	public static IDisposable JMMFOPKEINJ(this MGDBKGBBNLH AOGDICEMNLI, Action<float> PEDGAJMEGLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GEDPKJFFOEL
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6723170", Offset = "0x6722570", VA = "0x186723170")]
	public static IDisposable NJLKCIDMEGA(this MonoBehaviour NCKPIIOOHBK, Action PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x67230E0", Offset = "0x67224E0", VA = "0x1867230E0")]
	public static IDisposable NJLKCIDMEGA(this MonoBehaviour NCKPIIOOHBK, Action<float> PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6722A20", Offset = "0x6721E20", VA = "0x186722A20")]
	public static IDisposable AKOCPLJFKLG(this MonoBehaviour NCKPIIOOHBK, Action PEDGAJMEGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6722BE0", Offset = "0x6721FE0", VA = "0x186722BE0")]
	public static IDisposable CDCKLMHNAOM(this MonoBehaviour NCKPIIOOHBK, Action PEDGAJMEGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6722C60", Offset = "0x6722060", VA = "0x186722C60")]
	public static IDisposable CDCKLMHNAOM(this MonoBehaviour NCKPIIOOHBK, Action<float> PEDGAJMEGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6722D80", Offset = "0x6722180", VA = "0x186722D80")]
	public static IDisposable COBFCIDFCFC(this MonoBehaviour NCKPIIOOHBK, Action PEDGAJMEGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6723200", Offset = "0x6722600", VA = "0x186723200")]
	public static IDisposable OJFIFIMMLNM(this MonoBehaviour NCKPIIOOHBK, Action PEDGAJMEGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6722FC0", Offset = "0x67223C0", VA = "0x186722FC0")]
	public static IDisposable JFBENNBBANK(this MonoBehaviour NCKPIIOOHBK, Action PEDGAJMEGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6722830", Offset = "0x6721C30", VA = "0x186722830")]
	public static IDisposable ACCGNNEJDCF(this MonoBehaviour NCKPIIOOHBK, float JCJHMNEIBFN, Action<float> PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM, bool LMOIPINPCFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6722E00", Offset = "0x6722200", VA = "0x186722E00")]
	public static IDisposable FDJMLGLEGMD(this MonoBehaviour NCKPIIOOHBK, float JCJHMNEIBFN, Action<float> PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM, bool LMOIPINPCFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6723280", Offset = "0x6722680", VA = "0x186723280")]
	public static IDisposable PGGIIBNGFNM(this MonoBehaviour NCKPIIOOHBK, float JCJHMNEIBFN, Action<float> PEDGAJMEGLC, bool LMOIPINPCFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6722B40", Offset = "0x6721F40", VA = "0x186722B40")]
	public static IDisposable APIBLDFAGEM(this MonoBehaviour NCKPIIOOHBK, Action<float> PEDGAJMEGLC, bool LMOIPINPCFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6723040", Offset = "0x6722440", VA = "0x186723040")]
	public static IDisposable KNPACANCOFO(this MonoBehaviour NCKPIIOOHBK, Action<float> PEDGAJMEGLC, bool LMOIPINPCFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6722CE0", Offset = "0x67220E0", VA = "0x186722CE0")]
	public static IDisposable CDKAAMDHIIE(this MonoBehaviour NCKPIIOOHBK, Action<float> PEDGAJMEGLC, bool LMOIPINPCFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67228E0", Offset = "0x6721CE0", VA = "0x1867228E0")]
	public static IDisposable ACFHBMJKKCO(this MonoBehaviour NCKPIIOOHBK, Action<float> PEDGAJMEGLC, bool LMOIPINPCFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6722F20", Offset = "0x6722320", VA = "0x186722F20")]
	public static IDisposable FMFMEJKBEMF(this MonoBehaviour NCKPIIOOHBK, Action<float> PEDGAJMEGLC, bool LMOIPINPCFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6722980", Offset = "0x6721D80", VA = "0x186722980")]
	public static IDisposable AKGJDELFCGB(this MonoBehaviour NCKPIIOOHBK, Action<float> PEDGAJMEGLC, bool LMOIPINPCFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6722AA0", Offset = "0x6721EA0", VA = "0x186722AA0")]
	public static IDisposable ALLBAOKBJFH(this MonoBehaviour NCKPIIOOHBK, Action<float> PEDGAJMEGLC, bool LMOIPINPCFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6723320", Offset = "0x6722720", VA = "0x186723320")]
	public static IDisposable PHEAGNBBCNB(this MonoBehaviour NCKPIIOOHBK, float JCJHMNEIBFN, Action<float> PEDGAJMEGLC, bool LMOIPINPCFJ = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class EFAFIHDFNKL
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class GHHHFJDIKAH : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public IMBPJMJMPCK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private IEOCPJJGNJB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public GHHHFJDIKAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6723580", Offset = "0x6722980", VA = "0x186723580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6723660", Offset = "0x6722A60", VA = "0x186723660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class OBPBJFNOBKO : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IMBPJMJMPCK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private IEOCPJJGNJB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public OBPBJFNOBKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x672D600", Offset = "0x672CA00", VA = "0x18672D600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x672D6F0", Offset = "0x672CAF0", VA = "0x18672D6F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x671F340", Offset = "0x671E740", VA = "0x18671F340")]
	public static DEMHINFLCEG NJLKCIDMEGA(Action PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x671F510", Offset = "0x671E910", VA = "0x18671F510")]
	public static DEMHINFLCEG NJLKCIDMEGA(Behaviour AOGDICEMNLI, Action PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x671F3F0", Offset = "0x671E7F0", VA = "0x18671F3F0")]
	public static DEMHINFLCEG NJLKCIDMEGA(Behaviour AOGDICEMNLI, Action<float> PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x671F2B0", Offset = "0x671E6B0", VA = "0x18671F2B0")]
	[IteratorStateMachine(typeof(GHHHFJDIKAH))]
	private static IEnumerator<LEOLCGBMIAN> JGAHPLIDMEL(IMBPJMJMPCK AHMBIAJBCCG, Action PEDGAJMEGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x671F220", Offset = "0x671E620", VA = "0x18671F220")]
	[IteratorStateMachine(typeof(OBPBJFNOBKO))]
	private static IEnumerator<LEOLCGBMIAN> JGAHPLIDMEL(IMBPJMJMPCK AHMBIAJBCCG, Action<float> PEDGAJMEGLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class OMNBOCKPGMJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class NCNOBGKCPLD : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public OMNBOCKPGMJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public NCNOBGKCPLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x672AF80", Offset = "0x672A380", VA = "0x18672AF80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x672B010", Offset = "0x672A410", VA = "0x18672B010", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly IMBPJMJMPCK NKPGBGDGEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action IAEAIBILANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool BCEABOIGKCH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool AFAAFCBBNEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x793FF0", Offset = "0x7933F0", VA = "0x180793FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x672DA50", Offset = "0x672CE50", VA = "0x18672DA50")]
	public OMNBOCKPGMJ(IMBPJMJMPCK NKPGBGDGEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x672D930", Offset = "0x672CD30", VA = "0x18672D930")]
	[IteratorStateMachine(typeof(NCNOBGKCPLD))]
	private IEnumerator<LEOLCGBMIAN> LHJBKINJMOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x672D9B0", Offset = "0x672CDB0", VA = "0x18672D9B0", Slot = "4")]
	public void OnCompleted(Action GBCGPGPMMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440")]
	public void JONBGDAHKMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class FPDIIELEMGP
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x67226F0", Offset = "0x6721AF0", VA = "0x1867226F0")]
	public static OMNBOCKPGMJ OLICJBAOPML(this IMBPJMJMPCK NKPGBGDGEKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class NBBJONIMHFO
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class MNCDBEMEKOD : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public LDGANKGENND schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public MNCDBEMEKOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x672A8C0", Offset = "0x6729CC0", VA = "0x18672A8C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x672A940", Offset = "0x6729D40", VA = "0x18672A940", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x672AE80", Offset = "0x672A280", VA = "0x18672AE80")]
	public static DEMHINFLCEG NJLKCIDMEGA(float JCJHMNEIBFN, Action<float> PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM, bool LMOIPINPCFJ = true, [Optional] EDBEAKKGJFP KGKDGHCKLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x672AD70", Offset = "0x672A170", VA = "0x18672AD70")]
	public static DEMHINFLCEG NJLKCIDMEGA(MonoBehaviour NCKPIIOOHBK, float JCJHMNEIBFN, Action<float> PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM, bool LMOIPINPCFJ = true, [Optional] EDBEAKKGJFP KGKDGHCKLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x672ABC0", Offset = "0x6729FC0", VA = "0x18672ABC0")]
	public static DEMHINFLCEG MEMMINKCJOO(MonoBehaviour NCKPIIOOHBK, float JCJHMNEIBFN, Action<float> PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM, bool LMOIPINPCFJ = true, [Optional] EDBEAKKGJFP KGKDGHCKLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x672A9F0", Offset = "0x6729DF0", VA = "0x18672A9F0")]
	public static DEMHINFLCEG DLPIPNPEINI(MGDBKGBBNLH AOGDICEMNLI, float JCJHMNEIBFN, Action<float> PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM, bool LMOIPINPCFJ = true, [Optional] EDBEAKKGJFP KGKDGHCKLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x672AB00", Offset = "0x6729F00", VA = "0x18672AB00")]
	private static IEnumerator<LEOLCGBMIAN> JGAHPLIDMEL(JFPGCJOGBEE DMANFGNBGKF, float JCJHMNEIBFN, IMBPJMJMPCK AHMBIAJBCCG, Action<float> PEDGAJMEGLC, bool LMOIPINPCFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x672A990", Offset = "0x6729D90", VA = "0x18672A990")]
	private static IEnumerator<LEOLCGBMIAN> AGNBPPGINAA(JFPGCJOGBEE DMANFGNBGKF, float JCJHMNEIBFN, IMBPJMJMPCK AHMBIAJBCCG, Action<float> PEDGAJMEGLC, bool LMOIPINPCFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x672ACE0", Offset = "0x672A0E0", VA = "0x18672ACE0")]
	[IteratorStateMachine(typeof(MNCDBEMEKOD))]
	private static IEnumerator<LEOLCGBMIAN> MOELJBFGKIM(LDGANKGENND EJKPEAFJAMO, float JCJHMNEIBFN, IMBPJMJMPCK AHMBIAJBCCG, Action<float> PEDGAJMEGLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class EJDIIPJKNPK
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class OEHNFADFKJH : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public IMBPJMJMPCK queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public OEHNFADFKJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x672D740", Offset = "0x672CB40", VA = "0x18672D740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x672D800", Offset = "0x672CC00", VA = "0x18672D800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x671FA70", Offset = "0x671EE70", VA = "0x18671FA70")]
	[IteratorStateMachine(typeof(OEHNFADFKJH))]
	private static IEnumerator<LEOLCGBMIAN> NDEJGAJJMEF(IMBPJMJMPCK NKPGBGDGEKM, Func<bool> NDMNCGHKEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x671F950", Offset = "0x671ED50", VA = "0x18671F950")]
	public static DEMHINFLCEG GCDOGLMACAM(this MonoBehaviour NCKPIIOOHBK, Func<bool> NDMNCGHKEPJ, IMBPJMJMPCK NKPGBGDGEKM = IMBPJMJMPCK.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class BMAOJLGALHG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class GEJDBNMEGBE : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public IMBPJMJMPCK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public GEJDBNMEGBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x67234C0", Offset = "0x67228C0", VA = "0x1867234C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6723530", Offset = "0x6722930", VA = "0x186723530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class OIMPGOBKPGH : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public IMBPJMJMPCK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private LEOLCGBMIAN <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public OIMPGOBKPGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x672D850", Offset = "0x672CC50", VA = "0x18672D850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x672D8E0", Offset = "0x672CCE0", VA = "0x18672D8E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x67162E0", Offset = "0x67156E0", VA = "0x1867162E0")]
	[IteratorStateMachine(typeof(GEJDBNMEGBE))]
	private static IEnumerator<LEOLCGBMIAN> LHJBKINJMOO(float PPLAIKBLALP, IMBPJMJMPCK AHMBIAJBCCG, Action HHLGGDGPLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6715E60", Offset = "0x6715260", VA = "0x186715E60")]
	[IteratorStateMachine(typeof(OIMPGOBKPGH))]
	private static IEnumerator<LEOLCGBMIAN> ECKFOKFJFJF(float PPLAIKBLALP, IMBPJMJMPCK AHMBIAJBCCG, Action HHLGGDGPLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6716480", Offset = "0x6715880", VA = "0x186716480")]
	public static IDisposable PENBAEMDLGO(this MonoBehaviour NCKPIIOOHBK, float PPLAIKBLALP, Action HHLGGDGPLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6715D80", Offset = "0x6715180", VA = "0x186715D80")]
	public static DEMHINFLCEG BPDAHDILKOF(this MonoBehaviour NCKPIIOOHBK, float PPLAIKBLALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x67165A0", Offset = "0x67159A0", VA = "0x1867165A0")]
	public static DEMHINFLCEG PENBAEMDLGO(this MonoBehaviour NCKPIIOOHBK, float PPLAIKBLALP, IMBPJMJMPCK AHMBIAJBCCG, Action HHLGGDGPLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6715E40", Offset = "0x6715240", VA = "0x186715E40")]
	public static DEMHINFLCEG CFKIPLHAPGH(this MonoBehaviour NCKPIIOOHBK, Action HHLGGDGPLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x67160B0", Offset = "0x67154B0", VA = "0x1867160B0")]
	public static DEMHINFLCEG HHJGDHCBGNN(this MonoBehaviour NCKPIIOOHBK, Action HHLGGDGPLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6715FD0", Offset = "0x67153D0", VA = "0x186715FD0")]
	public static DEMHINFLCEG GOFIEPHALKF(this MonoBehaviour NCKPIIOOHBK, Action HHLGGDGPLKF, [Optional] EDBEAKKGJFP KGKDGHCKLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6716380", Offset = "0x6715780", VA = "0x186716380")]
	public static DEMHINFLCEG LHLBNGODOPM(this MonoBehaviour NCKPIIOOHBK, Action HHLGGDGPLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x67162B0", Offset = "0x67156B0", VA = "0x1867162B0")]
	public static DEMHINFLCEG LDEMBHIFPEJ(this MonoBehaviour NCKPIIOOHBK, Action HHLGGDGPLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x67161B0", Offset = "0x67155B0", VA = "0x1867161B0")]
	public static DEMHINFLCEG IHMKCANAOAC(this MonoBehaviour NCKPIIOOHBK, Action HHLGGDGPLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x67160E0", Offset = "0x67154E0", VA = "0x1867160E0")]
	private static DEMHINFLCEG IGDFPMBOAKM(MonoBehaviour NCKPIIOOHBK, IMBPJMJMPCK NKPGBGDGEKM, Action HHLGGDGPLKF, [Optional] EDBEAKKGJFP KGKDGHCKLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6715CB0", Offset = "0x67150B0", VA = "0x186715CB0")]
	public static DEMHINFLCEG AHGPJOPELFK(this MonoBehaviour NCKPIIOOHBK, float HICHDEBAFIH, Action HHLGGDGPLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x67161E0", Offset = "0x67155E0", VA = "0x1867161E0")]
	public static DEMHINFLCEG LBFFAGFLJCL(this MonoBehaviour NCKPIIOOHBK, float HICHDEBAFIH, Action HHLGGDGPLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x67163B0", Offset = "0x67157B0", VA = "0x1867163B0")]
	public static DEMHINFLCEG OLNGHNKBMMP(this MonoBehaviour NCKPIIOOHBK, float HICHDEBAFIH, Action HHLGGDGPLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6715F00", Offset = "0x6715300", VA = "0x186715F00")]
	public static DEMHINFLCEG FHFBCHNGNAK(this MonoBehaviour NCKPIIOOHBK, float HICHDEBAFIH, Action HHLGGDGPLKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class IFICOBODEJN : GACLONJEIFK, IEnumerable<GACLONJEIFK>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<GACLONJEIFK> LIONGEOCDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool NOAANDJNLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action PPPCIBGFEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool JBBKMGBLDHJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NMGOOMOAMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6726980", Offset = "0x6725D80", VA = "0x186726980", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KKJEIABPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6726E60", Offset = "0x6726260", VA = "0x186726E60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6726F00", Offset = "0x6726300", VA = "0x186726F00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6726FA0", Offset = "0x67263A0", VA = "0x186726FA0")]
	public IFICOBODEJN([Optional] Action PPPCIBGFEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6726850", Offset = "0x6725C50", VA = "0x186726850")]
	public void DEAIBIAHPPK(GACLONJEIFK EDNAHCFDGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x67266F0", Offset = "0x6725AF0", VA = "0x1867266F0")]
	private void BKCMHHOECNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6726E50", Offset = "0x6726250", VA = "0x186726E50", Slot = "7")]
	public bool HAFPJGGNICP(bool LHIOHICKLJF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6726B40", Offset = "0x6725F40", VA = "0x186726B40", Slot = "8")]
	public bool HAFPJGGNICP(Action EEEBGEOHFMI, bool LHIOHICKLJF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6726AC0", Offset = "0x6725EC0", VA = "0x186726AC0", Slot = "9")]
	public IEnumerator<GACLONJEIFK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6726AC0", Offset = "0x6725EC0", VA = "0x186726AC0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GMOOFNHNJBM : JPHHHBIBPNO
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MNHEMPIDLCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public GMOOFNHNJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public MNHEMPIDLCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6729E20", Offset = "0x6729220", VA = "0x186729E20")]
		internal void KOOKKKNAOOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class LNOLOLIAPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public GMOOFNHNJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public LNOLOLIAPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6729E20", Offset = "0x6729220", VA = "0x186729E20")]
		internal void MKPDBBNCHDF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float DLNFPECHKGN;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6715BB0", Offset = "0x6714FB0", VA = "0x186715BB0")]
	public GMOOFNHNJBM(Behaviour AOGDICEMNLI, float DLNFPECHKGN, [Optional] Action PPPCIBGFEII, [Optional] EDBEAKKGJFP KGKDGHCKLNH, [Optional] JFPGCJOGBEE DMANFGNBGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6723C50", Offset = "0x6723050", VA = "0x186723C50", Slot = "9")]
	protected override bool GJEEBFJFLLG(Action EEEBGEOHFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6723B40", Offset = "0x6722F40", VA = "0x186723B40", Slot = "10")]
	protected override bool CDHOFDKHNNI(Action EEEBGEOHFMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface GACLONJEIFK
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool NMGOOMOAMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action KKJEIABPPEE;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HAFPJGGNICP(bool LHIOHICKLJF = false);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HAFPJGGNICP(Action EEEBGEOHFMI, bool LHIOHICKLJF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class JPHHHBIBPNO : GACLONJEIFK
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class IAOLDOFHKAB : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public JPHHHBIBPNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public IAOLDOFHKAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x67265D0", Offset = "0x67259D0", VA = "0x1867265D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x67266A0", Offset = "0x6725AA0", VA = "0x1867266A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour AOGDICEMNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action PPPCIBGFEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NHJNJBGGLID LMFMLFMHKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly EDBEAKKGJFP KGKDGHCKLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly JFPGCJOGBEE DMANFGNBGKF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool NMGOOMOAMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xEE4D30", Offset = "0xEE4130", VA = "0x180EE4D30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action KKJEIABPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x67279E0", Offset = "0x6726DE0", VA = "0x1867279E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6727A80", Offset = "0x6726E80", VA = "0x186727A80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6727B20", Offset = "0x6726F20", VA = "0x186727B20")]
	protected JPHHHBIBPNO(Behaviour AOGDICEMNLI, [Optional] Action PPPCIBGFEII, [Optional] EDBEAKKGJFP KGKDGHCKLNH, [Optional] JFPGCJOGBEE DMANFGNBGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6727610", Offset = "0x6726A10", VA = "0x186727610", Slot = "7")]
	public bool HAFPJGGNICP(bool LHIOHICKLJF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6727670", Offset = "0x6726A70", VA = "0x186727670", Slot = "8")]
	public bool HAFPJGGNICP(Action EEEBGEOHFMI, bool LHIOHICKLJF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GJEEBFJFLLG(Action EEEBGEOHFMI);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool CDHOFDKHNNI(Action EEEBGEOHFMI);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x67275F0", Offset = "0x67269F0", VA = "0x1867275F0")]
	protected void CLNGDMKEMAL(Action EEEBGEOHFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6727760", Offset = "0x6726B60", VA = "0x186727760")]
	protected DONEJHADFEN INEJNPILCNI(float NNDGBAFPCAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6727570", Offset = "0x6726970", VA = "0x186727570")]
	private void CKINMIPNHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x67276D0", Offset = "0x6726AD0", VA = "0x1867276D0")]
	[IteratorStateMachine(typeof(IAOLDOFHKAB))]
	private IEnumerator<LEOLCGBMIAN> IGGFBKPMBBL(float NNDGBAFPCAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x67279A0", Offset = "0x6726DA0", VA = "0x1867279A0")]
	[CompilerGenerated]
	private void JMIEELOMIJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class JHGMBNGCOJN : JPHHHBIBPNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float MMGMNCNMBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int EAFMIIACALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float JDBDHFGDPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] EMPDHEGMMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int NEGOKDOKFGB;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x67272C0", Offset = "0x67266C0", VA = "0x1867272C0")]
	public JHGMBNGCOJN(Behaviour AOGDICEMNLI, float PLEBEEOGAGF, int EAFMIIACALK, [Optional] Action PPPCIBGFEII, float JDBDHFGDPAA = 0f, [Optional] EDBEAKKGJFP KGKDGHCKLNH, [Optional] JFPGCJOGBEE DMANFGNBGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "9")]
	protected override bool GJEEBFJFLLG(Action EEEBGEOHFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6727040", Offset = "0x6726440", VA = "0x186727040", Slot = "10")]
	protected override bool CDHOFDKHNNI(Action EEEBGEOHFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6727240", Offset = "0x6726640", VA = "0x186727240")]
	private void LDMONLPPEIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class BJPKBFPOMII : JPHHHBIBPNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float DLNFPECHKGN;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6715BB0", Offset = "0x6714FB0", VA = "0x186715BB0")]
	public BJPKBFPOMII(Behaviour AOGDICEMNLI, float DLNFPECHKGN, [Optional] Action PPPCIBGFEII, [Optional] EDBEAKKGJFP KGKDGHCKLNH, [Optional] JFPGCJOGBEE DMANFGNBGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "9")]
	protected override bool GJEEBFJFLLG(Action EEEBGEOHFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6715B70", Offset = "0x6714F70", VA = "0x186715B70", Slot = "10")]
	protected override bool CDHOFDKHNNI(Action EEEBGEOHFMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class CINNCODHOIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class KIAOFCDKPHB : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public KIAOFCDKPHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x671DB80", Offset = "0x671CF80", VA = "0x18671DB80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6728500", Offset = "0x6727900", VA = "0x186728500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private DEMHINFLCEG HAOMGFKHLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private MGDBKGBBNLH AOGDICEMNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> JGJOCGGEPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private IMBPJMJMPCK NKPGBGDGEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float KMOOPJEOAOC;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6718830", Offset = "0x6717C30", VA = "0x186718830")]
	public CINNCODHOIM(MGDBKGBBNLH AOGDICEMNLI, float JCJHMNEIBFN, Action<float> PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6718610", Offset = "0x6717A10", VA = "0x186718610")]
	private void LPCLAAMDHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x67182A0", Offset = "0x67176A0", VA = "0x1867182A0")]
	private void AFBIEMCLPAP(string HNINMPIFBCK, Action LIEFGHKNEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x67187B0", Offset = "0x6717BB0", VA = "0x1867187B0")]
	[IteratorStateMachine(typeof(KIAOFCDKPHB))]
	private IEnumerator<LEOLCGBMIAN> LPPAEEHKHEI(Action LIEFGHKNEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6718400", Offset = "0x6717800", VA = "0x186718400", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6718460", Offset = "0x6717860", VA = "0x186718460")]
	[CompilerGenerated]
	private void FJNHOACELCL(string CFJCPBMIHPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class PCHOOLKHJAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class DDNGLEPEGJA : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public DDNGLEPEGJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x671DB80", Offset = "0x671CF80", VA = "0x18671DB80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x671DBF0", Offset = "0x671CFF0", VA = "0x18671DBF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private DEMHINFLCEG HAOMGFKHLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour NCKPIIOOHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action PEDGAJMEGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> JGJOCGGEPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private IMBPJMJMPCK NKPGBGDGEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float KMOOPJEOAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool LMOIPINPCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly EDBEAKKGJFP KGKDGHCKLNH;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x672EE20", Offset = "0x672E220", VA = "0x18672EE20")]
	public PCHOOLKHJAC(MonoBehaviour NCKPIIOOHBK, Action PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM, [Optional] EDBEAKKGJFP KGKDGHCKLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x672F260", Offset = "0x672E660", VA = "0x18672F260")]
	public PCHOOLKHJAC(MonoBehaviour NCKPIIOOHBK, Action<float> PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM, [Optional] EDBEAKKGJFP KGKDGHCKLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x672F010", Offset = "0x672E410", VA = "0x18672F010")]
	public PCHOOLKHJAC(MonoBehaviour NCKPIIOOHBK, float JCJHMNEIBFN, Action<float> PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM, bool LMOIPINPCFJ = true, [Optional] EDBEAKKGJFP KGKDGHCKLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x18E46B0", Offset = "0x18E3AB0", VA = "0x1818E46B0")]
	private PCHOOLKHJAC(EDBEAKKGJFP KGKDGHCKLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x672EA70", Offset = "0x672DE70", VA = "0x18672EA70")]
	internal static PCHOOLKHJAC LPGICPNHFMI(MonoBehaviour NCKPIIOOHBK, float JCJHMNEIBFN, Action<float> PEDGAJMEGLC, IMBPJMJMPCK NKPGBGDGEKM, bool LMOIPINPCFJ = true, [Optional] EDBEAKKGJFP KGKDGHCKLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x672EC20", Offset = "0x672E020", VA = "0x18672EC20")]
	private void NJLKCIDMEGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x672E340", Offset = "0x672D740", VA = "0x18672E340")]
	private void BBJKMNLBMMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x672E8C0", Offset = "0x672DCC0", VA = "0x18672E8C0")]
	private void LPCLAAMDHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x672E700", Offset = "0x672DB00", VA = "0x18672E700")]
	private void LNMHMICJCEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x672E210", Offset = "0x672D610", VA = "0x18672E210")]
	private void AFBIEMCLPAP(string HNINMPIFBCK, Action LIEFGHKNEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x672EBA0", Offset = "0x672DFA0", VA = "0x18672EBA0")]
	[IteratorStateMachine(typeof(DDNGLEPEGJA))]
	private IEnumerator<LEOLCGBMIAN> LPPAEEHKHEI(Action LIEFGHKNEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x672E580", Offset = "0x672D980", VA = "0x18672E580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x672E670", Offset = "0x672DA70", VA = "0x18672E670")]
	[CompilerGenerated]
	private void LDFPBHOMIAM(string CFJCPBMIHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x672E5E0", Offset = "0x672D9E0", VA = "0x18672E5E0")]
	[CompilerGenerated]
	private void JLNNBMFPFIE(string CFJCPBMIHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x672ED90", Offset = "0x672E190", VA = "0x18672ED90")]
	[CompilerGenerated]
	private void NKMMCLPBLMI(string CFJCPBMIHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x672E4F0", Offset = "0x672D8F0", VA = "0x18672E4F0")]
	[CompilerGenerated]
	private void BHEDMGFKAOF(string CFJCPBMIHPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum GJKMFOMCCKE : byte
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
internal sealed class CDDGIKLJLFL : JFPGCJOGBEE
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float GDBDBBEFCIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x67166D0", Offset = "0x6715AD0", VA = "0x1867166D0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float PFLACNDJPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x67166E0", Offset = "0x6715AE0", VA = "0x1867166E0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double IDPGMECDFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x67166F0", Offset = "0x6715AF0", VA = "0x1867166F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6716710", Offset = "0x6715B10", VA = "0x186716710")]
	[ABIGJEDBLLA(BMBIBJGPNHE.None)]
	private static void LECIAOIGEFG(DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	[Preserve]
	internal CDDGIKLJLFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface ECKHBEKMHNP
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPOJCHBMODJ(string ADLKEGECLOG);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFBLKGBJHEM();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface NENAGHBACBF
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string DACJMNMHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool PEEHDGOMBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool GDKCOIEEJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class KCOIIHMOKCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public FNBFFPMFBGG INMPFINMHJA;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int GOBEDCIKOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x78F180", Offset = "0x78E580", VA = "0x18078F180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x79D9F0", Offset = "0x79CDF0", VA = "0x18079D9F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6727F90", Offset = "0x6727390", VA = "0x186727F90")]
	public static LEOLCGBMIAN NPEHDOCAIOD(IEnumerator<LEOLCGBMIAN> NPIACMMMMAE, NPNPJLJBMMJ EMJJOLLBABB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6727ED0", Offset = "0x67272D0", VA = "0x186727ED0")]
	public LEOLCGBMIAN NPEHDOCAIOD(NPNPJLJBMMJ[] CPJBCEACOJJ, IEnumerator<LEOLCGBMIAN>[] JNBAEANGDNN, LEOLCGBMIAN[] ABPBONFIOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6727C20", Offset = "0x6727020", VA = "0x186727C20")]
	public void BLLLIFCJLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6727D90", Offset = "0x6727190", VA = "0x186727D90")]
	public void MEIFKDFPOCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6727C50", Offset = "0x6727050", VA = "0x186727C50")]
	public void IPEJNIPHHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6727C20", Offset = "0x6727020", VA = "0x186727C20")]
	public void NHJHAGACHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public KCOIIHMOKCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class FNBFFPMFBGG
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct DAPABKKMCKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public KCOIIHMOKCI BAODJCKBDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public MGDBKGBBNLH GIDBCGOMBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public NPNPJLJBMMJ FGMMGIBIIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<LEOLCGBMIAN> JIKBHHCGCMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public LEOLCGBMIAN JBFKKALMLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public GJKMFOMCCKE DAALDCKJMHK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CFDGHCBEKFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IMBPJMJMPCK HMGDJEJGKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<DAPABKKMCKM> PKDEOGDLIIE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class DMIJEGMPEMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public NPNPJLJBMMJ promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public FNBFFPMFBGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public MGDBKGBBNLH context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public KCOIIHMOKCI routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public GJKMFOMCCKE coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public LEOLCGBMIAN currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<LEOLCGBMIAN> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public DMIJEGMPEMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x671DEB0", Offset = "0x671D2B0", VA = "0x18671DEB0")]
		internal void JNAJIGBOJIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class MACKPGPIEGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public KCOIIHMOKCI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public FNBFFPMFBGG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public MACKPGPIEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6729E50", Offset = "0x6729250", VA = "0x186729E50")]
		internal void IPIMAEBBBPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class ENNEMLLDJIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public KCOIIHMOKCI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public FNBFFPMFBGG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public ENNEMLLDJIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x671FB00", Offset = "0x671EF00", VA = "0x18671FB00")]
		internal void NPKLDANIJBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class CGMADDJHBHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public KCOIIHMOKCI schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public FNBFFPMFBGG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public CGMADDJHBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6716950", Offset = "0x6715D50", VA = "0x186716950")]
		internal void KKDDBCHAINK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const GJKMFOMCCKE OCFACLEIPLL = GJKMFOMCCKE.Cancelled | GJKMFOMCCKE.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly IMBPJMJMPCK NKPGBGDGEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] HHLDHAPKDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<GJKMFOMCCKE> OLFLNFJDAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> LECLHNFHHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> GBAPDGEOOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> JOLMPBPABLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> JPBNDBPDPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> LOECOEBCAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> PKLKFJDHCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private KCOIIHMOKCI[] INKEHBNLIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NPNPJLJBMMJ[] CPJBCEACOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private MGDBKGBBNLH[] BLAJEKBBJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<LEOLCGBMIAN>[] NBAHADBGLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private LEOLCGBMIAN[] PNPKEGKIECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int ICHNHAKCFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int BPEPAFIGLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int BMGOHACPBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float MJLEPMKEPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private PGBDOALIBIK IGAGDLPGFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle KIKFPNCPKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<KCOIIHMOKCI> MIGOIFKKBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool HMPBNPNNJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> FIBNGHDCHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> GELCFANBGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool APGFNPJPPLE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public CFDGHCBEKFO[] ACPCNDDCBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x999E00", Offset = "0x999200", VA = "0x180999E00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x671FD40", Offset = "0x671F140", VA = "0x18671FD40")]
	private static int AICKKODHNDF(IMBPJMJMPCK NKPGBGDGEKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x67220A0", Offset = "0x67214A0", VA = "0x1867220A0")]
	public FNBFFPMFBGG(IMBPJMJMPCK NKPGBGDGEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6721420", Offset = "0x6720820", VA = "0x186721420")]
	private void NCJCNKKPFHD(int BINHMICPJGK, int HBJBJHGCDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x67212A0", Offset = "0x67206A0", VA = "0x1867212A0")]
	public void MIDIDCDLLNG(MGDBKGBBNLH AOGDICEMNLI, LEOLCGBMIAN KDFECPAAFPA, IEnumerator<LEOLCGBMIAN> NPIACMMMMAE, NPNPJLJBMMJ EMJJOLLBABB, [Optional] KCOIIHMOKCI PNLGPGAOMNF, GJKMFOMCCKE MHFJNHLPCNI = GJKMFOMCCKE.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6721600", Offset = "0x6720A00", VA = "0x186721600")]
	public void NGBBCEMFLAB(IEnumerable<DAPABKKMCKM> IIJPLPJAFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x671FEA0", Offset = "0x671F2A0", VA = "0x18671FEA0")]
	private DAPABKKMCKM CAEAODBIBBD(int JPPHGDICPFM)
	{
		return default(DAPABKKMCKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x67205F0", Offset = "0x671F9F0", VA = "0x1867205F0")]
	private void GHJLJBBOIIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x25DCCC0", Offset = "0x25DC0C0", VA = "0x1825DCCC0")]
	private static void PNPMBJFEFNG<T>(int JPPHGDICPFM, T[] DGAFLDJEJPA, int KKEOKHMHDHC, [Optional] T KNHIMDKGGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x25DCD10", Offset = "0x25DC110", VA = "0x1825DCD10")]
	private static void PNPMBJFEFNG<T>(int JPPHGDICPFM, NativeArray<T> DGAFLDJEJPA, int KKEOKHMHDHC, [Optional] T KNHIMDKGGFB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6721AA0", Offset = "0x6720EA0", VA = "0x186721AA0")]
	private void NKMPKIAJMKH(IEnumerable<DAPABKKMCKM> IIJPLPJAFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x67211E0", Offset = "0x67205E0", VA = "0x1867211E0")]
	private void KMPBLOJKPPI(DAPABKKMCKM ANKMFIEJCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6721E40", Offset = "0x6721240", VA = "0x186721E40")]
	private OEDAOAPDPEF PJCBGDGOAJL(int KCFGMBIHFLK)
	{
		return default(OEDAOAPDPEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x67203F0", Offset = "0x671F7F0", VA = "0x1867203F0")]
	public void DMJKFJBGABL(float HAOJPBKMLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6720960", Offset = "0x671FD60", VA = "0x186720960")]
	private void GJILHANPJBN(Action OJBODDLNJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6720370", Offset = "0x671F770", VA = "0x186720370")]
	private void DCBPOFGJCMO(Action OJBODDLNJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x67209E0", Offset = "0x671FDE0", VA = "0x1867209E0")]
	public void IGBNNBFBADP(float HAOJPBKMLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x67210E0", Offset = "0x67204E0", VA = "0x1867210E0")]
	public void ILMOPHDNONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6721970", Offset = "0x6720D70", VA = "0x186721970")]
	public void NHJHAGACHCL(KCOIIHMOKCI EJKPEAFJAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6721840", Offset = "0x6720C40", VA = "0x186721840")]
	public void NGLCIKKAOIO(KCOIIHMOKCI EJKPEAFJAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x671FD70", Offset = "0x671F170", VA = "0x18671FD70")]
	public void AMIOBDHCEKP(KCOIIHMOKCI EJKPEAFJAMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JKONMHMOGJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly JKONMHMOGJE HNPOJGAPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action MLLHGDLMPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool ENCMOAFILAH;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	public JKONMHMOGJE(Action MLLHGDLMPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6098640", Offset = "0x6097A40", VA = "0x186098640", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface AOMHODHEKGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T BFBAIKCHJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable LFLJFCLPMID(UnityEngine.Object AOGDICEMNLI, Action<T> KMAEHEGGDGO);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface FIAICGJLMFF<T> : AOMHODHEKGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T BFBAIKCHJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class IONLANNEPNL<T> : FIAICGJLMFF<T>, AOMHODHEKGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class OHKAFGCJPJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public IONLANNEPNL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public PJEPJKBJEFI<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public OHKAFGCJPJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1E40", Offset = "0x3FA1240", VA = "0x183FA1E40")]
		internal void CIHLGGFADOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject EMEGAAILKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<PJEPJKBJEFI<UnityEngine.Object, Action<T>>> DBIOENDPALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T EDPLCLECGLF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T BFBAIKCHJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x817E60", Offset = "0x817260", VA = "0x180817E60", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3924E70", Offset = "0x3924270", VA = "0x183924E70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3924D70", Offset = "0x3924170", VA = "0x183924D70")]
	private static bool MAMFMFIEJGI(T OJBODDLNJNK, T BLEBDLHLENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3924F70", Offset = "0x3924370", VA = "0x183924F70")]
	public IONLANNEPNL(T GNCAJOOLKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3924A50", Offset = "0x3923E50", VA = "0x183924A50", Slot = "6")]
	public IDisposable LFLJFCLPMID(UnityEngine.Object AOGDICEMNLI, Action<T> KMAEHEGGDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3924720", Offset = "0x3923B20", VA = "0x183924720")]
	private void GGGEBIMEMPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class EEAKCIJBECD : MKBABOPAJPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly EDBEAKKGJFP KGKDGHCKLNH;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x671E7F0", Offset = "0x671DBF0", VA = "0x18671E7F0")]
	[ABIGJEDBLLA(BMBIBJGPNHE.None)]
	private static void LECIAOIGEFG(DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	[Preserve]
	internal EEAKCIJBECD([AKCMIAONCHN(null)] EDBEAKKGJFP KGKDGHCKLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x671E860", Offset = "0x671DC60", VA = "0x18671E860", Slot = "4")]
	public IDisposable PGGIIBNGFNM(float JCJHMNEIBFN, Action<float> COPFOFGFOAL, bool LMOIPINPCFJ = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class LJBNMAFAGDC : CLODABAINFK, EDBEAKKGJFP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private FNBFFPMFBGG[] JHPLFHBOCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private ECKHBEKMHNP BGEKHEIJHPN;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6729060", Offset = "0x6728460", VA = "0x186729060")]
	[ABIGJEDBLLA(BMBIBJGPNHE.None)]
	private static void LECIAOIGEFG(DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6729380", Offset = "0x6728780", VA = "0x186729380")]
	[Preserve]
	public LJBNMAFAGDC([AKCMIAONCHN(null)] KHBCOBDANEC GPOMEEAMGGJ, [AKCMIAONCHN(null)] JFPGCJOGBEE DMANFGNBGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6728BB0", Offset = "0x6727FB0", VA = "0x186728BB0", Slot = "16")]
	public override DEMHINFLCEG EBPGMNDPOJG(MGDBKGBBNLH AOGDICEMNLI, IEnumerator<LEOLCGBMIAN> KGNCBLDENLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6728750", Offset = "0x6727B50", VA = "0x186728750", Slot = "17")]
	public override void AIKIIHKLAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6728D10", Offset = "0x6728110", VA = "0x186728D10", Slot = "19")]
	public override void JFLABFGPLIH(IMBPJMJMPCK NKPGBGDGEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x67289E0", Offset = "0x6727DE0", VA = "0x1867289E0", Slot = "18")]
	protected override void AKOCPLJFKLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6728CE0", Offset = "0x67280E0", VA = "0x186728CE0")]
	private FNBFFPMFBGG GEILNNLONBF(IMBPJMJMPCK KHENBEDBKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x67290D0", Offset = "0x67284D0", VA = "0x1867290D0", Slot = "20")]
	internal override HOHJNKFGOEM MAHAODIGJCA(IEnumerator<LEOLCGBMIAN> KGNCBLDENLM, Behaviour AOGDICEMNLI, NPNPJLJBMMJ EMJJOLLBABB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6729300", Offset = "0x6728700", VA = "0x186729300", Slot = "21")]
	internal override NGEAEGBIHHK OICDEJDJAOF(IMBPJMJMPCK AHMBIAJBCCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6728F40", Offset = "0x6728340", VA = "0x186728F40")]
	private void JPGDFKEKIFM(FNBFFPMFBGG HMGIECDOLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6728B50", Offset = "0x6727F50", VA = "0x186728B50", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct PGBDOALIBIK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float GDLGKCJDJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int OGLFPMMOJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> ENOPGOJLNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> LGEMBGEKBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> KADPLOEBIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<GJKMFOMCCKE> GNJEILFENEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> OOBBPBKOPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> JPBNDBPDPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> GBAPDGEOOGA;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x672FA50", Offset = "0x672EE50", VA = "0x18672FA50")]
	public static PGBDOALIBIK CNMCABBAMHK(int LAHMAAHHEKP, float HAOJPBKMLBP, NativeArray<GJKMFOMCCKE> CHBDGAHBKHF, NativeArray<float> NMADMPBFMFE, NativeArray<int> CNNLOGOGCMB, NativeArray<int> PNJCAFKGBGH, NativeArray<int> ELCEECIMDKF, NativeArray<int> LGEMBGEKBPE, NativeArray<int> KADPLOEBIIH)
	{
		return default(PGBDOALIBIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x672FCF0", Offset = "0x672F0F0", VA = "0x18672FCF0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x672FDD0", Offset = "0x672F1D0", VA = "0x18672FDD0")]
	private bool HPJFINKCNBB(int FGBBDGJMFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x672FE10", Offset = "0x672F210", VA = "0x18672FE10")]
	private void JNHBNBNLMFK(NativeArray<int> AMDPKINKLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x672F8E0", Offset = "0x672ECE0", VA = "0x18672F8E0")]
	private int AMHGGBNJCBI(int PPCEPOLNGPM, int DECIHPABFNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x672F980", Offset = "0x672ED80", VA = "0x18672F980")]
	private void CMEKPAMDPJN(NativeArray<int> AMDPKINKLFK, int COCCHDPNMMO, int LFEGGLDFJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x672FAB0", Offset = "0x672EEB0", VA = "0x18672FAB0")]
	private void DLEJBIACPBA(NativeArray<int> AMDPKINKLFK, int BMBPNBLGOBN, int LMHIFPGGCAB, int HBMDCAIFJLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class CLODABAINFK : EDBEAKKGJFP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly KHBCOBDANEC GPOMEEAMGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly JFPGCJOGBEE DMANFGNBGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private NGEAEGBIHHK[] JKOOCJKLBIH;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static EDBEAKKGJFP OKALMGBNAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6719100", Offset = "0x6718500", VA = "0x186719100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool KJBEDCLLEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IMBPJMJMPCK PBMDBCNJGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x78F180", Offset = "0x78E580", VA = "0x18078F180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(IMBPJMJMPCK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x79D9F0", Offset = "0x79CDF0", VA = "0x18079D9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public JFPGCJOGBEE JIDGOGLPAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public LEOLCGBMIAN KGKJGMLKACD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6719AA0", Offset = "0x6718EA0", VA = "0x186719AA0")]
	public static DEMHINFLCEG NEMOALGFGEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6719B50", Offset = "0x6718F50", VA = "0x186719B50")]
	[Preserve]
	protected CLODABAINFK([AKCMIAONCHN(null)] KHBCOBDANEC GPOMEEAMGGJ, [AKCMIAONCHN(null)] JFPGCJOGBEE DMANFGNBGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6719590", Offset = "0x6718990", VA = "0x186719590", Slot = "6")]
	public DEMHINFLCEG ENCHDBDKILG(IEnumerator<LEOLCGBMIAN> KGNCBLDENLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x67195A0", Offset = "0x67189A0", VA = "0x1867195A0", Slot = "7")]
	public DEMHINFLCEG ENCHDBDKILG(Behaviour AOGDICEMNLI, IEnumerator<LEOLCGBMIAN> KGNCBLDENLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract DEMHINFLCEG EBPGMNDPOJG(MGDBKGBBNLH AOGDICEMNLI, IEnumerator<LEOLCGBMIAN> KGNCBLDENLM);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6718C30", Offset = "0x6718030", VA = "0x186718C30", Slot = "17")]
	public virtual void AIKIIHKLAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6718E10", Offset = "0x6718210", VA = "0x186718E10", Slot = "9")]
	public void CJMBOMHEAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6718DD0", Offset = "0x67181D0", VA = "0x186718DD0", Slot = "18")]
	protected virtual void AKOCPLJFKLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6718C10", Offset = "0x6718010", VA = "0x186718C10")]
	private void ACOJMAFNOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x67199D0", Offset = "0x6718DD0", VA = "0x1867199D0")]
	private void IEOOMKEHOGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6718DF0", Offset = "0x67181F0", VA = "0x186718DF0")]
	private void CDCKLMHNAOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x67190E0", Offset = "0x67184E0", VA = "0x1867190E0")]
	private void COBFCIDFCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6719570", Offset = "0x6718970", VA = "0x186719570")]
	private void EJHFDOODODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x67199F0", Offset = "0x6718DF0", VA = "0x1867199F0")]
	private void JCLINCBBFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6719B30", Offset = "0x6718F30", VA = "0x186719B30")]
	private void OCKJHHPBALI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6719A10", Offset = "0x6718E10", VA = "0x186719A10", Slot = "19")]
	public virtual void JFLABFGPLIH(IMBPJMJMPCK NKPGBGDGEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6719800", Offset = "0x6718C00", VA = "0x186719800")]
	private void FOJPHOEPGKF(NGEAEGBIHHK HMGIECDOLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1C45700", Offset = "0x1C44B00", VA = "0x181C45700")]
	private NGEAEGBIHHK HBHDEAHDNLH(IMBPJMJMPCK KHENBEDBKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract HOHJNKFGOEM MAHAODIGJCA(IEnumerator<LEOLCGBMIAN> KGNCBLDENLM, Behaviour NCKPIIOOHBK, NPNPJLJBMMJ NILKBNBMOKH);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract NGEAEGBIHHK OICDEJDJAOF(IMBPJMJMPCK NKPGBGDGEKM);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6719150", Offset = "0x6718550", VA = "0x186719150", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x67197A0", Offset = "0x6718BA0", VA = "0x1867197A0", Slot = "12")]
	public LEOLCGBMIAN FDJGBOFLFGE(IMBPJMJMPCK AHMBIAJBCCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6719050", Offset = "0x6718450", VA = "0x186719050", Slot = "13")]
	public LEOLCGBMIAN CKBKCJMCNMI(float PPLAIKBLALP, IMBPJMJMPCK AHMBIAJBCCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6719510", Offset = "0x6718910", VA = "0x186719510", Slot = "14")]
	public LEOLCGBMIAN EAOELLOFGDJ(Func<bool> NDMNCGHKEPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class HOHJNKFGOEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly NPNPJLJBMMJ EMJJOLLBABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly NENAGHBACBF AOGDICEMNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool KPDKEIFGDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string ADLKEGECLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace NINOFAAKGOK;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<LEOLCGBMIAN> JIKBHHCGCMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x793930", Offset = "0x792D30", VA = "0x180793930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public LEOLCGBMIAN JBFKKALMLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x792A30", Offset = "0x791E30", VA = "0x180792A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool FEFOBJBONKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6725630", Offset = "0x6724A30", VA = "0x186725630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool DDBKHANGCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x806600", Offset = "0x805A00", VA = "0x180806600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x806610", Offset = "0x805A10", VA = "0x180806610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string DACJMNMHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6725170", Offset = "0x6724570", VA = "0x186725170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float MONJLKPJGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x106BCA0", Offset = "0x106B0A0", VA = "0x18106BCA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x563C0C0", Offset = "0x563B4C0", VA = "0x18563C0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6725800", Offset = "0x6724C00", VA = "0x186725800")]
	public HOHJNKFGOEM(IEnumerator<LEOLCGBMIAN> NPIACMMMMAE, NENAGHBACBF AOGDICEMNLI, NPNPJLJBMMJ EMJJOLLBABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6725320", Offset = "0x6724720", VA = "0x186725320")]
	public LEOLCGBMIAN NPEHDOCAIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x67256B0", Offset = "0x6724AB0", VA = "0x1867256B0")]
	public bool PMKCMEENFMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6725120", Offset = "0x6724520", VA = "0x186725120")]
	public void NHJHAGACHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6725720", Offset = "0x6724B20", VA = "0x186725720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x88DC00", Offset = "0x88D000", VA = "0x18088DC00")]
	[CompilerGenerated]
	private void PAMLDCBCJOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class NPNPJLJBMMJ : HOJPIMOIENL, DEMHINFLCEG, NHJNJBGGLID, DONEJHADFEN, IEnumerator, LEOLCGBMIAN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private IMBPJMJMPCK GAKGIEFADPJ;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private IMBPJMJMPCK KLPFMFLFGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xDE6770", Offset = "0xDE5B70", VA = "0x180DE6770", Slot = "23")]
		get
		{
			return default(IMBPJMJMPCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IMBPJMJMPCK INMPFINMHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x12E9900", Offset = "0x12E8D00", VA = "0x1812E9900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float INJGFJAFMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7E18D0", Offset = "0x7E0CD0", VA = "0x1807E18D0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool DPJJNHBOHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x672D590", Offset = "0x672C990", VA = "0x18672D590", Slot = "24")]
	private bool FONGPEAMLLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x672D580", Offset = "0x672C980", VA = "0x18672D580", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x672D5B0", Offset = "0x672C9B0", VA = "0x18672D5B0")]
	public NPNPJLJBMMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum OEDAOAPDPEF : byte
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
internal sealed class NGEAEGBIHHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum MKMKLMMFOOL
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct FEJFIGAGKHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public IMBPJMJMPCK HMGDJEJGKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public MKMKLMMFOOL ALFIMNEEDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<HOHJNKFGOEM> KILEIJEDEAC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly MKMKLMMFOOL[] MDMKFBIOCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly IMBPJMJMPCK NKPGBGDGEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool ALNCPCDGNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly HOHJNKFGOEM[] CPOHKFPBIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<HOHJNKFGOEM> MJMAIOEHHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> ONLNDIDOHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<HOHJNKFGOEM> NKANFPBDGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> JCJNBDEHODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly ECKHBEKMHNP LOLNOALPHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool APGFNPJPPLE;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public FEJFIGAGKHC[,] ONPIJIHOEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x78F350", Offset = "0x78E750", VA = "0x18078F350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x672C780", Offset = "0x672BB80", VA = "0x18672C780")]
	public NGEAEGBIHHK(IMBPJMJMPCK AHMBIAJBCCG, ECKHBEKMHNP LOLNOALPHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x672BB30", Offset = "0x672AF30", VA = "0x18672BB30")]
	public void ECMPODLNLHC(HOHJNKFGOEM NPIACMMMMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x672B3D0", Offset = "0x672A7D0", VA = "0x18672B3D0")]
	public void BAECMGDBFCE(IList<HOHJNKFGOEM> JNBAEANGDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x672BDC0", Offset = "0x672B1C0", VA = "0x18672BDC0")]
	public void ENMDCLLJJOI(IList<HOHJNKFGOEM> JNBAEANGDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x672C550", Offset = "0x672B950", VA = "0x18672C550")]
	private void JEILEGEELII(HOHJNKFGOEM NPIACMMMMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x672BC30", Offset = "0x672B030", VA = "0x18672BC30")]
	private void EDDGDJIJNCD(IList<HOHJNKFGOEM> JNBAEANGDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x672C0D0", Offset = "0x672B4D0", VA = "0x18672C0D0")]
	private OEDAOAPDPEF FNEODMLLCGB(HOHJNKFGOEM NPIACMMMMAE)
	{
		return default(OEDAOAPDPEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x672B260", Offset = "0x672A660", VA = "0x18672B260")]
	public void AKOCPLJFKLG(float HAOJPBKMLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x672B6E0", Offset = "0x672AAE0", VA = "0x18672B6E0")]
	public void CJMBOMHEAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x672C250", Offset = "0x672B650", VA = "0x18672C250")]
	private void GODDFODJGMH(List<HOHJNKFGOEM> JNBAEANGDNN, Stack<int> ABDGPEPCECA, bool PGBNIAEIAKC, float FJMDODKMJMM = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x672BA10", Offset = "0x672AE10", VA = "0x18672BA10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x672B8D0", Offset = "0x672ACD0", VA = "0x18672B8D0")]
	private void DJAKDCFCOPB(List<HOHJNKFGOEM> JNBAEANGDNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class FIJDPDJPFKJ : ECKHBEKMHNP
{
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "4")]
	public void MPOJCHBMODJ(string ADLKEGECLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
	public void GFBLKGBJHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public FIJDPDJPFKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class GEFKOJJMLKB : NENAGHBACBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour NCKPIIOOHBK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string DACJMNMHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6723440", Offset = "0x6722840", VA = "0x186723440", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool PEEHDGOMBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x67233D0", Offset = "0x67227D0", VA = "0x1867233D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GDKCOIEEJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6723420", Offset = "0x6722820", VA = "0x186723420", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	public GEFKOJJMLKB(Behaviour NCKPIIOOHBK)
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

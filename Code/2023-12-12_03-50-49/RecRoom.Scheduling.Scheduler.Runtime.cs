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
public class LGLAKAKIFOC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority PPKBCOMHHED;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6506D80", Offset = "0x6505580", VA = "0x186506D80")]
	public LGLAKAKIFOC(ThreadPriority JPPHMEEPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6506D70", Offset = "0x6505570", VA = "0x186506D70", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> GNBBFJMJPGO(List<PlayerLoopSystem> MDPDIFLCNNM, int HOBMAKPPNAJ);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct OLDINFDBKBJ
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct JFOBNPFCKCF
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static LJECGABKDKN DBMNAOLGLDD;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x6501560", Offset = "0x64FFD60", VA = "0x186501560")]
				public static PlayerLoopSystem KLCCOFEHKAF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct AAAMNPDBFOL
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static LJECGABKDKN NNOOJFNPPLK;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x64F3450", Offset = "0x64F1C50", VA = "0x1864F3450")]
				public static PlayerLoopSystem KLCCOFEHKAF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct FIMLIDILLJG
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static LJECGABKDKN KJIADOEHDHP;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x64FC250", Offset = "0x64FAA50", VA = "0x1864FC250")]
				public static PlayerLoopSystem KLCCOFEHKAF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct PLCCBMCBLMI
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static LJECGABKDKN FMCHEDJGCGC;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static LJECGABKDKN BEEFDNMIBEI;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static LJECGABKDKN KFCDJNBICDO;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static LJECGABKDKN AEIPPOEPGJL;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x650E310", Offset = "0x650CB10", VA = "0x18650E310")]
				public static PlayerLoopSystem KLCCOFEHKAF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct BBFACFMDBNK
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static LJECGABKDKN KAEOPPHIIMA;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x64F3C00", Offset = "0x64F2400", VA = "0x1864F3C00")]
				public static PlayerLoopSystem KLCCOFEHKAF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct DDEIIFCMDFC
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static LJECGABKDKN FMCHEDJGCGC;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static LJECGABKDKN BEEFDNMIBEI;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static LJECGABKDKN KFCDJNBICDO;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static LJECGABKDKN AEIPPOEPGJL;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x64F8EE0", Offset = "0x64F76E0", VA = "0x1864F8EE0")]
				public static PlayerLoopSystem KLCCOFEHKAF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct MJKJLCNOGEJ
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static LJECGABKDKN DEJHJPFGJDL;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x65073A0", Offset = "0x6505BA0", VA = "0x1865073A0")]
				public static PlayerLoopSystem KLCCOFEHKAF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct EIJOLDDCHLL
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static LJECGABKDKN AOPEOBHCFOH;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x64FB7F0", Offset = "0x64F9FF0", VA = "0x1864FB7F0")]
				public static PlayerLoopSystem KLCCOFEHKAF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct ONCIGCGCMGI
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static LJECGABKDKN PMPEHDBPMFG;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x650C6D0", Offset = "0x650AED0", VA = "0x18650C6D0")]
				public static PlayerLoopSystem KLCCOFEHKAF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct AFMINJGNKPN
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static LJECGABKDKN OOKJBKDOKLI;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x64F3650", Offset = "0x64F1E50", VA = "0x1864F3650")]
				public static PlayerLoopSystem KLCCOFEHKAF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct LIFAHOGILEI
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static LJECGABKDKN MMAMLOHAKCB;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6506E20", Offset = "0x6505620", VA = "0x186506E20")]
				public static PlayerLoopSystem KLCCOFEHKAF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct ONHLMGHJOJL
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static LJECGABKDKN ABBBPLJHHBP;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x650C8D0", Offset = "0x650B0D0", VA = "0x18650C8D0")]
				public static PlayerLoopSystem KLCCOFEHKAF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum KMPEGDCDJFM : byte
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
			public struct NHDOOPMOFGP
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class NLBPFGIDLDG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public KMPEGDCDJFM updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
					public NLBPFGIDLDG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x650A1D0", Offset = "0x65089D0", VA = "0x18650A1D0")]
					internal void POICKDGCFKO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static LBEDKEAJHCP<KMPEGDCDJFM> APAMKPLNJIG;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6509A00", Offset = "0x6508200", VA = "0x186509A00")]
				public static PlayerLoopSystem KLCCOFEHKAF(KMPEGDCDJFM AEDEOENHKND)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct NKHCJNABMDB
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class KGBFCBOIELL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public IFCKLKOEAEA.JLKAKCFMIOC key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
					public KGBFCBOIELL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6502E20", Offset = "0x6501620", VA = "0x186502E20")]
					internal void BHPJLBPIDMK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable NLDICCFJOAC;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x650A040", Offset = "0x6508840", VA = "0x18650A040")]
				public static PlayerLoopSystem AMFAMNBOBFH(IFCKLKOEAEA.JLKAKCFMIOC EMBEECDJLJB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct MFGFMICLJNJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class PKPCFGHLIAF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public IFCKLKOEAEA.JLKAKCFMIOC key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
					public PKPCFGHLIAF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x650E0A0", Offset = "0x650C8A0", VA = "0x18650E0A0")]
					internal void BHPJLBPIDMK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x65070E0", Offset = "0x65058E0", VA = "0x1865070E0")]
				public static PlayerLoopSystem AMFAMNBOBFH(IFCKLKOEAEA.JLKAKCFMIOC EMBEECDJLJB)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class NAMACBGNCLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public NAMACBGNCLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6508EB0", Offset = "0x65076B0", VA = "0x186508EB0")]
			internal List<PlayerLoopSystem> FLPMDDEHKDM(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool GHFAIFJIHOF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool ABKDDHANADC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x64F5560", Offset = "0x64F3D60", VA = "0x1864F5560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64F6540", Offset = "0x64F4D40", VA = "0x1864F6540")]
		private static void ODAIDAGMICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64F5C70", Offset = "0x64F4470", VA = "0x1864F5C70")]
		private static void OAFDOCDHJKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64F5330", Offset = "0x64F3B30", VA = "0x1864F5330")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64F5AB0", Offset = "0x64F42B0", VA = "0x1864F5AB0")]
		private static void KCGNAMABGAJ(IFCKLKOEAEA.JLKAKCFMIOC EMBEECDJLJB, PlayerLoopSystem JBNJGHFHOIN, Type FNCDLKPFOGM, Type BHHMHFJHDNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64F55A0", Offset = "0x64F3DA0", VA = "0x1864F55A0")]
		private static void DLHCOEAKDFE(PlayerLoopSystem JBNJGHFHOIN, Type FNCDLKPFOGM, Type BHHMHFJHDNG, GNBBFJMJPGO JHHNAKJIGBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64F5980", Offset = "0x64F4180", VA = "0x1864F5980")]
		private static void EFDOHPKNELG(PlayerLoopSystem JBNJGHFHOIN, Type FNCDLKPFOGM, Type BHHMHFJHDNG, PlayerLoopSystem? IMHGMHHJCMD, PlayerLoopSystem? PEFNJOEJAOL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class IFCKLKOEAEA
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum JLKAKCFMIOC
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
	public class AHPCHDDGLCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly JLKAKCFMIOC EGGOJMIDNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly NNMNOJDNBGD JBBGJNDGNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long PMKJAECLDPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long CCKKJFMIDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long CFJBDIMKIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int BIBGFCLFMOF;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64F3AF0", Offset = "0x64F22F0", VA = "0x1864F3AF0")]
		public AHPCHDDGLCG(JLKAKCFMIOC GJAPCBDHBAJ, int IJGBAEOICHB = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64F38A0", Offset = "0x64F20A0", VA = "0x1864F38A0")]
		public void CGGKEOBHHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64F3850", Offset = "0x64F2050", VA = "0x1864F3850")]
		public void BIECEACLHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64F3910", Offset = "0x64F2110", VA = "0x1864F3910")]
		public void NBJGFINKEGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static JLKAKCFMIOC[] BHDCAIAHBEE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static AHPCHDDGLCG[] EEAIEMGHPNO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x65010D0", Offset = "0x64FF8D0", VA = "0x1865010D0")]
	public static AHPCHDDGLCG LJELPDAILOM(JLKAKCFMIOC EMBEECDJLJB, int IJGBAEOICHB = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x65012B0", Offset = "0x64FFAB0", VA = "0x1865012B0")]
	public static AHPCHDDGLCG ONHGDLCPOAA(JLKAKCFMIOC EMBEECDJLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6501320", Offset = "0x64FFB20", VA = "0x186501320")]
	public static void PAFJDEJPPFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NNMNOJDNBGD : NLDJAMGCCON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int MNDOEBGELHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> PKNMCEHBJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double LNKNIJLOFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double ECDEJDOACEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double APDHOAJCLCP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double EIMDKIBBKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x650A4D0", Offset = "0x6508CD0", VA = "0x18650A4D0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double IFOOKAEJEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x16FF330", Offset = "0x16FDB30", VA = "0x1816FF330", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double MGKDOCCGPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1C973C0", Offset = "0x1C95BC0", VA = "0x181C973C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x650A530", Offset = "0x6508D30", VA = "0x18650A530")]
	public NNMNOJDNBGD(int MOPPOIDCFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x650A340", Offset = "0x6508B40", VA = "0x18650A340", Slot = "7")]
	public void CLKBNGODPHL(double IDCGMKDPLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x650A460", Offset = "0x6508C60", VA = "0x18650A460", Slot = "8")]
	public void EINJMPIPEHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class IDHPKOCNNOC : NLDJAMGCCON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long PPKDCOOCBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double KDNHCMMLGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double MJIEBAMMLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double NDABJJHELOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double NPMMNAECCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double LNKNIJLOFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double ECDEJDOACEB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double IFOOKAEJEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x54B0DE0", Offset = "0x54AF5E0", VA = "0x1854B0DE0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double MGKDOCCGPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x54B0DD0", Offset = "0x54AF5D0", VA = "0x1854B0DD0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double BHCNFBFGMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x54B0930", Offset = "0x54AF130", VA = "0x1854B0930")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double EIMDKIBBKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x209FFF0", Offset = "0x209E7F0", VA = "0x18209FFF0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6500950", Offset = "0x64FF150", VA = "0x186500950", Slot = "7")]
	public virtual void CLKBNGODPHL(double IDCGMKDPLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6500A70", Offset = "0x64FF270", VA = "0x186500A70", Slot = "8")]
	public virtual void EINJMPIPEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6500AB0", Offset = "0x64FF2B0", VA = "0x186500AB0")]
	public IDHPKOCNNOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class OOKDPJHPHEA : IDHPKOCNNOC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double BPOMGDMODKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x54B08E0", Offset = "0x54AF0E0", VA = "0x1854B08E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x54B0960", Offset = "0x54AF160", VA = "0x1854B0960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x650CAD0", Offset = "0x650B2D0", VA = "0x18650CAD0", Slot = "7")]
	public override void CLKBNGODPHL(double IDCGMKDPLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x650CC00", Offset = "0x650B400", VA = "0x18650CC00", Slot = "8")]
	public override void EINJMPIPEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6500AB0", Offset = "0x64FF2B0", VA = "0x186500AB0")]
	public OOKDPJHPHEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface NLDJAMGCCON
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double EIMDKIBBKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double IFOOKAEJEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double MGKDOCCGPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HKMDHHILGOM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface GOEECJAHDJP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool GKAFEJBNMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NJFDFAHEDCH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class LCHABNGBFOC<TPromise, TMainThreadPromise> : GOEECJAHDJP where TPromise : BEGOMKNHMOK where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise KBEOIJGHGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise NIJKOBJBDAJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise CANOFKHFHEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x39EE710", Offset = "0x39ECF10", VA = "0x1839EE710")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GKAFEJBNMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x39EE770", Offset = "0x39ECF70", VA = "0x1839EE770", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x77D5B0", Offset = "0x77BDB0", VA = "0x18077D5B0")]
		protected LCHABNGBFOC(TPromise KBEOIJGHGMA, TMainThreadPromise FIBOKEOMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x39EE7C0", Offset = "0x39ECFC0", VA = "0x1839EE7C0", Slot = "5")]
		public void NJFDFAHEDCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void HMGFKLIECBJ(TPromise KBEOIJGHGMA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class FKCPFOAFLCP<T> : LCHABNGBFOC<CNJPNJMNEEH<T>, LHAPPAOCNNP<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x347AC60", Offset = "0x3479460", VA = "0x18347AC60")]
		public FKCPFOAFLCP(CNJPNJMNEEH<T> KBEOIJGHGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x347AA20", Offset = "0x3479220", VA = "0x18347AA20", Slot = "6")]
		protected override void HMGFKLIECBJ(CNJPNJMNEEH<T> KBEOIJGHGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x347AC30", Offset = "0x3479430", VA = "0x18347AC30")]
		[CompilerGenerated]
		private void IHEDCOKCIIK(T MLABNLLFODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x347A9F0", Offset = "0x34791F0", VA = "0x18347A9F0")]
		[CompilerGenerated]
		private void FPNENGNJHCB(string MFCNDEMKIPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class FFEJLDKIMEC : GOEECJAHDJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action KJDOCFCKCJE;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GKAFEJBNMPG
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x78D2A0", Offset = "0x78BAA0", VA = "0x18078D2A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
		public FFEJLDKIMEC(Action KJDOCFCKCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB5E740", Offset = "0xB5CF40", VA = "0x180B5E740", Slot = "5")]
		public void NJFDFAHEDCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<GOEECJAHDJP> HGLDHIIGJEA;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x24F3C20", Offset = "0x24F2420", VA = "0x1824F3C20")]
	public static CNJPNJMNEEH<T> FPJNPKCIDEP<T>(this CNJPNJMNEEH<T> KBEOIJGHGMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x64FF770", Offset = "0x64FDF70", VA = "0x1864FF770")]
	public static void FPJNPKCIDEP(Action KJDOCFCKCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x24F3B60", Offset = "0x24F2360", VA = "0x1824F3B60")]
	private static CNJPNJMNEEH<T> AGFHDPHJBGE<T>(CNJPNJMNEEH<T> KBEOIJGHGMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x64FF910", Offset = "0x64FE110", VA = "0x1864FF910")]
	private static void NJHAPIJFNMP(GOEECJAHDJP EMGGADNIPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x64FF490", Offset = "0x64FDC90", VA = "0x1864FF490")]
	private static void EKKECAPPIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x64FF810", Offset = "0x64FE010", VA = "0x1864FF810")]
	private static void KJKIHFJCIHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x64FF3B0", Offset = "0x64FDBB0", VA = "0x1864FF3B0")]
	private static void AHHNOFJKNHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MLBICDJAECF
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct NKPIOFOBCAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> FOKOCMNDIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string FLNADIENFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode HMCKEJJIBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool HACNHMJCJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x650A170", Offset = "0x6508970", VA = "0x18650A170")]
		public NKPIOFOBCAP(TaskCompletionSource<Scene> HDOBCOGKHBC, string FLNADIENFAK, LoadSceneMode HMCKEJJIBOM, bool HACNHMJCJDJ, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct FJDLBDGCHNK : IAsyncStateMachine
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
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private FHBHLKGBKLK<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x64FC450", Offset = "0x64FAC50", VA = "0x1864FC450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x64FCCF0", Offset = "0x64FB4F0", VA = "0x1864FCCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct HOEGHJMJAAO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x64FFBB0", Offset = "0x64FE3B0", VA = "0x1864FFBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x64FFED0", Offset = "0x64FE6D0", VA = "0x1864FFED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GPCFMOBLFON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private NKPIOFOBCAP <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x64FEEC0", Offset = "0x64FD6C0", VA = "0x1864FEEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x64FF270", Offset = "0x64FDA70", VA = "0x1864FF270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class LHJJHOBMOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LHAPPAOCNNP<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public LHJJHOBMOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6506DC0", Offset = "0x65055C0", VA = "0x186506DC0")]
		internal void FNCEDLNOBLF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct EALPBADHIFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

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
		private LHJJHOBMOLI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x64FABE0", Offset = "0x64F93E0", VA = "0x1864FABE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x64FB780", Offset = "0x64F9F80", VA = "0x1864FB780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct OBCMFFPBHMM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x650A5E0", Offset = "0x6508DE0", VA = "0x18650A5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x650AAF0", Offset = "0x65092F0", VA = "0x18650AAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct DPLFNCDDPIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x64FA020", Offset = "0x64F8820", VA = "0x1864FA020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x64FAB70", Offset = "0x64F9370", VA = "0x1864FAB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class DAJJCGHOIMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public DAJJCGHOIMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x64F8EB0", Offset = "0x64F76B0", VA = "0x1864F8EB0")]
		internal bool ENFCIIMFMGC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NJOHHPEAIDE : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private HHDDIFIMNDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public GOHGMMDPJIA onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public NJOHHPEAIDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6509FB0", Offset = "0x65087B0", VA = "0x186509FB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6509C20", Offset = "0x6508420", VA = "0x186509C20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6509BD0", Offset = "0x65083D0", VA = "0x186509BD0")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6509F60", Offset = "0x6508760", VA = "0x186509F60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FFACGLAPHBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public LHAPPAOCNNP<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public FFACGLAPHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x64FC1D0", Offset = "0x64FA9D0", VA = "0x1864FC1D0")]
		internal bool LGHKHEBJIDD(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x64FBF50", Offset = "0x64FA750", VA = "0x1864FBF50")]
		internal void KBMEFPPHDOK(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class BHLHFBGCCMF : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private HHDDIFIMNDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public LHAPPAOCNNP<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private FFACGLAPHBF <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public BHLHFBGCCMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x64F42D0", Offset = "0x64F2AD0", VA = "0x1864F42D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x64F49E0", Offset = "0x64F31E0", VA = "0x1864F49E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> MDKEBMMAACM;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static BEGOMKNHMOK PABGFADKMHI;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation OEICOBEOIPA;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BEGOMKNHMOK CNJNNFGJHJD;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string MDGNELEFLGB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority NFOAHLGGOEC;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task GBNLELPDALE;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> MNKLFEPAOMP;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<NKPIOFOBCAP> IPECMCIIOEL;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task PJBPBHEIEFM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool PKDEALMDFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6507810", Offset = "0x6506010", VA = "0x186507810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool ADIKIEDFIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x65085F0", Offset = "0x6506DF0", VA = "0x1865085F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool AEJMJOEPAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6508970", Offset = "0x6507170", VA = "0x186508970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool MGALMMOCCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6507FA0", Offset = "0x65067A0", VA = "0x186507FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> NIBAGJDOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6508860", Offset = "0x6507060", VA = "0x186508860")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6507AE0", Offset = "0x65062E0", VA = "0x186507AE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6507BF0", Offset = "0x65063F0", VA = "0x186507BF0")]
	[BDLCJDMJIJC(JPHNAFLMPCK.EnteredEditModeNextFrame, 0)]
	private static void CNFDMHFOCEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6508A10", Offset = "0x6507210", VA = "0x186508A10")]
	[AsyncStateMachine(typeof(FJDLBDGCHNK))]
	public static Task<Scene> NPMEMPADKAP(string FLNADIENFAK, LoadSceneMode HMCKEJJIBOM = LoadSceneMode.Single, bool HACNHMJCJDJ = false, [Optional] FHBHLKGBKLK<string>.CAOEJONIOII ONLHCJKCGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6507A30", Offset = "0x6506230", VA = "0x186507A30")]
	[AsyncStateMachine(typeof(HOEGHJMJAAO))]
	private static Task BEFPAIFCJCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x65080D0", Offset = "0x65068D0", VA = "0x1865080D0")]
	[AsyncStateMachine(typeof(GPCFMOBLFON))]
	private static Task HEIMBNFGIMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x65076C0", Offset = "0x6505EC0", VA = "0x1865076C0")]
	[AsyncStateMachine(typeof(EALPBADHIFG))]
	private static Task<Scene> AANKHOICIMP(string FLNADIENFAK, LoadSceneMode HMCKEJJIBOM, bool HACNHMJCJDJ, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6508B60", Offset = "0x6507360", VA = "0x186508B60")]
	private static void OJOAJCPEIBJ(SceneInstance PIOFGCGEFCD, LoadSceneMode HMCKEJJIBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6508690", Offset = "0x6506E90", VA = "0x186508690")]
	private static void KKLDGEHCHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x65075A0", Offset = "0x6505DA0", VA = "0x1865075A0")]
	[AsyncStateMachine(typeof(OBCMFFPBHMM))]
	private static Task<Scene> AAIGAIEEHJH(string FLNADIENFAK, LoadSceneMode HMCKEJJIBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6507D80", Offset = "0x6506580", VA = "0x186507D80")]
	private static bool EMBOJGOAFBG(string FLNADIENFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6508750", Offset = "0x6506F50", VA = "0x186508750")]
	[AsyncStateMachine(typeof(DPLFNCDDPIG))]
	private static Task<Scene> LEOAKENAMBM(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x65081A0", Offset = "0x65069A0", VA = "0x1865081A0")]
	public static CNJPNJMNEEH<Scene> HPJCAKPINKE(string FLNADIENFAK, LoadSceneMode HMCKEJJIBOM = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6508320", Offset = "0x6506B20", VA = "0x186508320")]
	public static BEGOMKNHMOK IFFPEJEMGLM(string FLNADIENFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6507CF0", Offset = "0x65064F0", VA = "0x186507CF0")]
	[IteratorStateMachine(typeof(NJOHHPEAIDE))]
	private static IEnumerator<HHDDIFIMNDJ> DKKDHPMPPPJ(string FLNADIENFAK, GOHGMMDPJIA AMNKOMDAEEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6508030", Offset = "0x6506830", VA = "0x186508030")]
	[IteratorStateMachine(typeof(BHLHFBGCCMF))]
	private static IEnumerator<HHDDIFIMNDJ> GKLCLAMADPI(string FLNADIENFAK, LoadSceneMode HMCKEJJIBOM, LHAPPAOCNNP<Scene> AMNKOMDAEEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6507E70", Offset = "0x6506670", VA = "0x186507E70")]
	public static bool FBGIJOCLBPN([Out] string ABBOHLJHMLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class MFKNLILGCFG
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6507310", Offset = "0x6505B10", VA = "0x186507310")]
	public static IDisposable GGOGJEBBIDM(this DJDABJADMBM LFDLOIPEDMO, float MHMFPDLGAEB, Action<float> FCGOAPMCHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6507290", Offset = "0x6505A90", VA = "0x186507290")]
	public static IDisposable ADOHNAPFFKB(this DJDABJADMBM LFDLOIPEDMO, Action<float> FCGOAPMCHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6507210", Offset = "0x6505A10", VA = "0x186507210")]
	public static IDisposable AAAJPEHINPG(this DJDABJADMBM LFDLOIPEDMO, Action<float> FCGOAPMCHNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DHOGFELPHJI
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x64F9CD0", Offset = "0x64F84D0", VA = "0x1864F9CD0")]
	public static IDisposable PEPJBHKJDLD(this MonoBehaviour NAKKDFCMEME, Action FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x64F9D60", Offset = "0x64F8560", VA = "0x1864F9D60")]
	public static IDisposable PEPJBHKJDLD(this MonoBehaviour NAKKDFCMEME, Action<float> FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x64F9C50", Offset = "0x64F8450", VA = "0x1864F9C50")]
	public static IDisposable OMANMGAMPNF(this MonoBehaviour NAKKDFCMEME, Action FCGOAPMCHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x64F9B50", Offset = "0x64F8350", VA = "0x1864F9B50")]
	public static IDisposable OBFGJLHMCFF(this MonoBehaviour NAKKDFCMEME, Action FCGOAPMCHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x64F9BD0", Offset = "0x64F83D0", VA = "0x1864F9BD0")]
	public static IDisposable OBFGJLHMCFF(this MonoBehaviour NAKKDFCMEME, Action<float> FCGOAPMCHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x64F9990", Offset = "0x64F8190", VA = "0x1864F9990")]
	public static IDisposable LPLGEFOKLIP(this MonoBehaviour NAKKDFCMEME, Action FCGOAPMCHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x64F92D0", Offset = "0x64F7AD0", VA = "0x1864F92D0")]
	public static IDisposable FIGKNEBNEHH(this MonoBehaviour NAKKDFCMEME, Action FCGOAPMCHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x64F9250", Offset = "0x64F7A50", VA = "0x1864F9250")]
	public static IDisposable CGMCGLIAFAM(this MonoBehaviour NAKKDFCMEME, Action FCGOAPMCHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x64F95B0", Offset = "0x64F7DB0", VA = "0x1864F95B0")]
	public static IDisposable HAEFPNFFKAM(this MonoBehaviour NAKKDFCMEME, float MHMFPDLGAEB, Action<float> FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ, bool OIDHDBOOBHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x64F9490", Offset = "0x64F7C90", VA = "0x1864F9490")]
	public static IDisposable GMFBCBGNPHH(this MonoBehaviour NAKKDFCMEME, float MHMFPDLGAEB, Action<float> FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ, bool OIDHDBOOBHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x64F9710", Offset = "0x64F7F10", VA = "0x1864F9710")]
	public static IDisposable IIGPGGHEDHJ(this MonoBehaviour NAKKDFCMEME, float MHMFPDLGAEB, Action<float> FCGOAPMCHNB, bool OIDHDBOOBHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x64F97B0", Offset = "0x64F7FB0", VA = "0x1864F97B0")]
	public static IDisposable ILFPIENCCIC(this MonoBehaviour NAKKDFCMEME, Action<float> FCGOAPMCHNB, bool OIDHDBOOBHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x64F98F0", Offset = "0x64F80F0", VA = "0x1864F98F0")]
	public static IDisposable KOGBLBCBGMD(this MonoBehaviour NAKKDFCMEME, Action<float> FCGOAPMCHNB, bool OIDHDBOOBHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x64F9A10", Offset = "0x64F8210", VA = "0x1864F9A10")]
	public static IDisposable MIODLDALONC(this MonoBehaviour NAKKDFCMEME, Action<float> FCGOAPMCHNB, bool OIDHDBOOBHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x64F9850", Offset = "0x64F8050", VA = "0x1864F9850")]
	public static IDisposable KKGELPDHIHM(this MonoBehaviour NAKKDFCMEME, Action<float> FCGOAPMCHNB, bool OIDHDBOOBHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x64F9AB0", Offset = "0x64F82B0", VA = "0x1864F9AB0")]
	public static IDisposable NOJOIDENLPB(this MonoBehaviour NAKKDFCMEME, Action<float> FCGOAPMCHNB, bool OIDHDBOOBHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x64F9350", Offset = "0x64F7B50", VA = "0x1864F9350")]
	public static IDisposable FJMBDOPNIBA(this MonoBehaviour NAKKDFCMEME, Action<float> FCGOAPMCHNB, bool OIDHDBOOBHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x64F93F0", Offset = "0x64F7BF0", VA = "0x1864F93F0")]
	public static IDisposable GAFGLNONNOH(this MonoBehaviour NAKKDFCMEME, Action<float> FCGOAPMCHNB, bool OIDHDBOOBHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x64F9660", Offset = "0x64F7E60", VA = "0x1864F9660")]
	public static IDisposable IHPKNLCCFGC(this MonoBehaviour NAKKDFCMEME, float MHMFPDLGAEB, Action<float> FCGOAPMCHNB, bool OIDHDBOOBHP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class FOBOICKAMOA
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class CJLPJBEFAGF : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private HHDDIFIMNDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public DJINKDPOIHN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private MLHJMGMDCFA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public CJLPJBEFAGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x64F4B50", Offset = "0x64F3350", VA = "0x1864F4B50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x64F4C30", Offset = "0x64F3430", VA = "0x1864F4C30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class LAKKNMNGGGB : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private HHDDIFIMNDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public DJINKDPOIHN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private MLHJMGMDCFA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public LAKKNMNGGGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6506700", Offset = "0x6504F00", VA = "0x186506700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x65067F0", Offset = "0x6504FF0", VA = "0x1865067F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x64FD060", Offset = "0x64FB860", VA = "0x1864FD060")]
	public static LKIMHCEDPCI PEPJBHKJDLD(Action FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x64FCFA0", Offset = "0x64FB7A0", VA = "0x1864FCFA0")]
	public static LKIMHCEDPCI PEPJBHKJDLD(Behaviour LFDLOIPEDMO, Action FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x64FCE80", Offset = "0x64FB680", VA = "0x1864FCE80")]
	public static LKIMHCEDPCI PEPJBHKJDLD(Behaviour LFDLOIPEDMO, Action<float> FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x64FCDF0", Offset = "0x64FB5F0", VA = "0x1864FCDF0")]
	[IteratorStateMachine(typeof(CJLPJBEFAGF))]
	private static IEnumerator<HHDDIFIMNDJ> FPDEDMOFOKM(DJINKDPOIHN IHOPAFHILPH, Action FCGOAPMCHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x64FCD60", Offset = "0x64FB560", VA = "0x1864FCD60")]
	[IteratorStateMachine(typeof(LAKKNMNGGGB))]
	private static IEnumerator<HHDDIFIMNDJ> FPDEDMOFOKM(DJINKDPOIHN IHOPAFHILPH, Action<float> FCGOAPMCHNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class DLOLEFONJFF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class HFPDKLBDHHJ : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private HHDDIFIMNDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public DLOLEFONJFF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public HFPDKLBDHHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x64FF2D0", Offset = "0x64FDAD0", VA = "0x1864FF2D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x64FF360", Offset = "0x64FDB60", VA = "0x1864FF360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly DJINKDPOIHN IIKKOCDJGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action HDNDOBINGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool MEFLNKJPIJB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JMLBJKCFCHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x77D7A0", Offset = "0x77BFA0", VA = "0x18077D7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x64F9F10", Offset = "0x64F8710", VA = "0x1864F9F10")]
	public DLOLEFONJFF(DJINKDPOIHN IIKKOCDJGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x64F9DF0", Offset = "0x64F85F0", VA = "0x1864F9DF0")]
	[IteratorStateMachine(typeof(HFPDKLBDHHJ))]
	private IEnumerator<HHDDIFIMNDJ> HOPNDAMAAPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x64F9E70", Offset = "0x64F8670", VA = "0x1864F9E70", Slot = "4")]
	public void OnCompleted(Action JPCBANHILHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
	public void DEGLNODELFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class PAFODBIJGJI
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x650CC40", Offset = "0x650B440", VA = "0x18650CC40")]
	public static DLOLEFONJFF NDIAGNCOELE(this DJINKDPOIHN IIKKOCDJGJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class IEIHMLNFOAM
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class GAFJCHCMNDM : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private HHDDIFIMNDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public ILJJDJMMJGC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public GAFJCHCMNDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x64FECB0", Offset = "0x64FD4B0", VA = "0x1864FECB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x64FED30", Offset = "0x64FD530", VA = "0x1864FED30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6500FD0", Offset = "0x64FF7D0", VA = "0x186500FD0")]
	public static LKIMHCEDPCI PEPJBHKJDLD(float MHMFPDLGAEB, Action<float> FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ, bool OIDHDBOOBHP = true, [Optional] JNLGLOFFOHI BGNGHLNFJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6500EC0", Offset = "0x64FF6C0", VA = "0x186500EC0")]
	public static LKIMHCEDPCI PEPJBHKJDLD(MonoBehaviour NAKKDFCMEME, float MHMFPDLGAEB, Action<float> FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ, bool OIDHDBOOBHP = true, [Optional] JNLGLOFFOHI BGNGHLNFJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6500AE0", Offset = "0x64FF2E0", VA = "0x186500AE0")]
	public static LKIMHCEDPCI AAJGPPKBANP(MonoBehaviour NAKKDFCMEME, float MHMFPDLGAEB, Action<float> FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ, bool OIDHDBOOBHP = true, [Optional] JNLGLOFFOHI BGNGHLNFJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6500DB0", Offset = "0x64FF5B0", VA = "0x186500DB0")]
	public static LKIMHCEDPCI GFKGCENFKCD(DJDABJADMBM LFDLOIPEDMO, float MHMFPDLGAEB, Action<float> FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ, bool OIDHDBOOBHP = true, [Optional] JNLGLOFFOHI BGNGHLNFJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6500CF0", Offset = "0x64FF4F0", VA = "0x186500CF0")]
	private static IEnumerator<HHDDIFIMNDJ> FPDEDMOFOKM(EJGBDPIPIGA AKKKKHHOJPO, float MHMFPDLGAEB, DJINKDPOIHN IHOPAFHILPH, Action<float> FCGOAPMCHNB, bool OIDHDBOOBHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6500C90", Offset = "0x64FF490", VA = "0x186500C90")]
	private static IEnumerator<HHDDIFIMNDJ> FFKBHMNIIIG(EJGBDPIPIGA AKKKKHHOJPO, float MHMFPDLGAEB, DJINKDPOIHN IHOPAFHILPH, Action<float> FCGOAPMCHNB, bool OIDHDBOOBHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6500C00", Offset = "0x64FF400", VA = "0x186500C00")]
	[IteratorStateMachine(typeof(GAFJCHCMNDM))]
	private static IEnumerator<HHDDIFIMNDJ> FCALINBJFII(ILJJDJMMJGC HFAGJMAIALI, float MHMFPDLGAEB, DJINKDPOIHN IHOPAFHILPH, Action<float> FCGOAPMCHNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class OGFPCEHNFML
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class GJAFKAGMKEO : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private HHDDIFIMNDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public DJINKDPOIHN queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public GJAFKAGMKEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x64FEDB0", Offset = "0x64FD5B0", VA = "0x1864FEDB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x64FEE70", Offset = "0x64FD670", VA = "0x1864FEE70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x650C520", Offset = "0x650AD20", VA = "0x18650C520")]
	[IteratorStateMachine(typeof(GJAFKAGMKEO))]
	private static IEnumerator<HHDDIFIMNDJ> HIMKDFECBGK(DJINKDPOIHN IIKKOCDJGJJ, Func<bool> CPCFGJNAACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x650C5B0", Offset = "0x650ADB0", VA = "0x18650C5B0")]
	public static LKIMHCEDPCI HLEJGAHDHFJ(this MonoBehaviour NAKKDFCMEME, Func<bool> CPCFGJNAACA, DJINKDPOIHN IIKKOCDJGJJ = DJINKDPOIHN.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class HPJCJCCLJDN
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class MEKOHCEODLF : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private HHDDIFIMNDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public DJINKDPOIHN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public MEKOHCEODLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6507020", Offset = "0x6505820", VA = "0x186507020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6507090", Offset = "0x6505890", VA = "0x186507090", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class NBBKAODNAMC : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private HHDDIFIMNDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public DJINKDPOIHN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private HHDDIFIMNDJ <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public NBBKAODNAMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6508FD0", Offset = "0x65077D0", VA = "0x186508FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6509060", Offset = "0x6507860", VA = "0x186509060", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6500320", Offset = "0x64FEB20", VA = "0x186500320")]
	[IteratorStateMachine(typeof(MEKOHCEODLF))]
	private static IEnumerator<HHDDIFIMNDJ> HOPNDAMAAPF(float GDAIBLFKMLM, DJINKDPOIHN IHOPAFHILPH, Action KCILOJEPOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x65000D0", Offset = "0x64FE8D0", VA = "0x1865000D0")]
	[IteratorStateMachine(typeof(NBBKAODNAMC))]
	private static IEnumerator<HHDDIFIMNDJ> EOCCDAGFNJF(float GDAIBLFKMLM, DJINKDPOIHN IHOPAFHILPH, Action KCILOJEPOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6500700", Offset = "0x64FEF00", VA = "0x186500700")]
	public static IDisposable MLFHMMIDLDD(this MonoBehaviour NAKKDFCMEME, float GDAIBLFKMLM, Action KCILOJEPOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6500170", Offset = "0x64FE970", VA = "0x186500170")]
	public static LKIMHCEDPCI FGCDCKEJDFB(this MonoBehaviour NAKKDFCMEME, float GDAIBLFKMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x65005D0", Offset = "0x64FEDD0", VA = "0x1865005D0")]
	public static LKIMHCEDPCI MLFHMMIDLDD(this MonoBehaviour NAKKDFCMEME, float GDAIBLFKMLM, DJINKDPOIHN IHOPAFHILPH, Action KCILOJEPOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6500230", Offset = "0x64FEA30", VA = "0x186500230")]
	public static LKIMHCEDPCI FOPEFBJHGMF(this MonoBehaviour NAKKDFCMEME, Action KCILOJEPOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6500920", Offset = "0x64FF120", VA = "0x186500920")]
	public static LKIMHCEDPCI PEACDNENMEL(this MonoBehaviour NAKKDFCMEME, Action KCILOJEPOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6500420", Offset = "0x64FEC20", VA = "0x186500420")]
	public static LKIMHCEDPCI MKADHNDPIKP(this MonoBehaviour NAKKDFCMEME, Action KCILOJEPOFM, [Optional] JNLGLOFFOHI BGNGHLNFJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6500820", Offset = "0x64FF020", VA = "0x186500820")]
	public static LKIMHCEDPCI NEFFEMJDFEL(this MonoBehaviour NAKKDFCMEME, Action KCILOJEPOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x65003F0", Offset = "0x64FEBF0", VA = "0x1865003F0")]
	public static LKIMHCEDPCI KKBPDOIJFAL(this MonoBehaviour NAKKDFCMEME, Action KCILOJEPOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x65003C0", Offset = "0x64FEBC0", VA = "0x1865003C0")]
	public static LKIMHCEDPCI IANHLOLILNP(this MonoBehaviour NAKKDFCMEME, Action KCILOJEPOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6500000", Offset = "0x64FE800", VA = "0x186500000")]
	private static LKIMHCEDPCI BIJFDDIJGML(MonoBehaviour NAKKDFCMEME, DJINKDPOIHN IIKKOCDJGJJ, Action KCILOJEPOFM, [Optional] JNLGLOFFOHI BGNGHLNFJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x64FFF30", Offset = "0x64FE730", VA = "0x1864FFF30")]
	public static LKIMHCEDPCI BGDOOBCNJKO(this MonoBehaviour NAKKDFCMEME, float JOCKHJCGAPG, Action KCILOJEPOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6500250", Offset = "0x64FEA50", VA = "0x186500250")]
	public static LKIMHCEDPCI GAKFCOOMBBI(this MonoBehaviour NAKKDFCMEME, float JOCKHJCGAPG, Action KCILOJEPOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6500850", Offset = "0x64FF050", VA = "0x186500850")]
	public static LKIMHCEDPCI NPBFIOCAHGJ(this MonoBehaviour NAKKDFCMEME, float JOCKHJCGAPG, Action KCILOJEPOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6500500", Offset = "0x64FED00", VA = "0x186500500")]
	public static LKIMHCEDPCI MKHJLIHJEPH(this MonoBehaviour NAKKDFCMEME, float JOCKHJCGAPG, Action KCILOJEPOFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class NCLOFGIIMFK : JKGBGOIEJMB, IEnumerable<JKGBGOIEJMB>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<JKGBGOIEJMB> FLAIOCPIHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool HONBGPPBPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action IIHOJDOOBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool ABMLOGHPMIN;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LAEBMGCHBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6509650", Offset = "0x6507E50", VA = "0x186509650", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IIEKAJBGGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6509530", Offset = "0x6507D30", VA = "0x186509530", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x65098C0", Offset = "0x65080C0", VA = "0x1865098C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6509960", Offset = "0x6508160", VA = "0x186509960")]
	public NCLOFGIIMFK([Optional] Action IIHOJDOOBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6509790", Offset = "0x6507F90", VA = "0x186509790")]
	public void INCGBOEKEGG(JKGBGOIEJMB KOFGPMOKBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x65090B0", Offset = "0x65078B0", VA = "0x1865090B0")]
	private void CFMBPJKIKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6509210", Offset = "0x6507A10", VA = "0x186509210", Slot = "7")]
	public bool DMMBCCMOKAL(bool PPEPKNMOGPK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6509220", Offset = "0x6507A20", VA = "0x186509220", Slot = "8")]
	public bool DMMBCCMOKAL(Action KJDOCFCKCJE, bool PPEPKNMOGPK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x65095D0", Offset = "0x6507DD0", VA = "0x1865095D0", Slot = "9")]
	public IEnumerator<JKGBGOIEJMB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x65095D0", Offset = "0x6507DD0", VA = "0x1865095D0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LEIEGGNLOPB : CMCLEJBLNDM
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MMJJBODIIHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public LEIEGGNLOPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public MMJJBODIIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x64FED80", Offset = "0x64FD580", VA = "0x1864FED80")]
		internal void JKKFLCDPPCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class GHAODNJILPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public LEIEGGNLOPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GHAODNJILPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x64FED80", Offset = "0x64FD580", VA = "0x1864FED80")]
		internal void PCDHOPIOEAJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float BMDFGJFJDBL;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6506C70", Offset = "0x6505470", VA = "0x186506C70")]
	public LEIEGGNLOPB(Behaviour LFDLOIPEDMO, float BMDFGJFJDBL, [Optional] Action IIHOJDOOBIF, [Optional] JNLGLOFFOHI BGNGHLNFJKM, [Optional] EJGBDPIPIGA AKKKKHHOJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6506B60", Offset = "0x6505360", VA = "0x186506B60", Slot = "9")]
	protected override bool LLLBKLJEDEB(Action KJDOCFCKCJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6506A50", Offset = "0x6505250", VA = "0x186506A50", Slot = "10")]
	protected override bool GNCJFDIEKMC(Action KJDOCFCKCJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface JKGBGOIEJMB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool LAEBMGCHBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action IIEKAJBGGBB;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DMMBCCMOKAL(bool PPEPKNMOGPK = false);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DMMBCCMOKAL(Action KJDOCFCKCJE, bool PPEPKNMOGPK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class CMCLEJBLNDM : JKGBGOIEJMB
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class BJNNHJCEHFH : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private HHDDIFIMNDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public CMCLEJBLNDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public BJNNHJCEHFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x64F4A30", Offset = "0x64F3230", VA = "0x1864F4A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x64F4B00", Offset = "0x64F3300", VA = "0x1864F4B00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour LFDLOIPEDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action IIHOJDOOBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private BIBLBPOCMFE OPCONBDJFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly JNLGLOFFOHI BGNGHLNFJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly EJGBDPIPIGA AKKKKHHOJPO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LAEBMGCHBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xEAA650", Offset = "0xEA8E50", VA = "0x180EAA650", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action IIEKAJBGGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x64F4DF0", Offset = "0x64F35F0", VA = "0x1864F4DF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x64F50D0", Offset = "0x64F38D0", VA = "0x1864F50D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x64F5230", Offset = "0x64F3A30", VA = "0x1864F5230")]
	protected CMCLEJBLNDM(Behaviour LFDLOIPEDMO, [Optional] Action IIHOJDOOBIF, [Optional] JNLGLOFFOHI BGNGHLNFJKM, [Optional] EJGBDPIPIGA AKKKKHHOJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x64F4D30", Offset = "0x64F3530", VA = "0x1864F4D30", Slot = "7")]
	public bool DMMBCCMOKAL(bool PPEPKNMOGPK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x64F4D90", Offset = "0x64F3590", VA = "0x1864F4D90", Slot = "8")]
	public bool DMMBCCMOKAL(Action KJDOCFCKCJE, bool PPEPKNMOGPK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool LLLBKLJEDEB(Action KJDOCFCKCJE);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool GNCJFDIEKMC(Action KJDOCFCKCJE);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x64F4D10", Offset = "0x64F3510", VA = "0x1864F4D10")]
	protected void BLBIHNBIFJL(Action KJDOCFCKCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x64F4E90", Offset = "0x64F3690", VA = "0x1864F4E90")]
	protected BEGOMKNHMOK IHOGPOADJDM(float IMMFEJCLFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x64F5170", Offset = "0x64F3970", VA = "0x1864F5170")]
	private void LNIDCMFMGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x64F4C80", Offset = "0x64F3480", VA = "0x1864F4C80")]
	[IteratorStateMachine(typeof(BJNNHJCEHFH))]
	private IEnumerator<HHDDIFIMNDJ> BEOKOFFGGAP(float IMMFEJCLFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x64F51F0", Offset = "0x64F39F0", VA = "0x1864F51F0")]
	[CompilerGenerated]
	private void NPNJEMPACHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class JOOCMJCHHCC : CMCLEJBLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float LOBNPBIODNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int HAKCBBLIBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float MGPOFMPDENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] JGECOMCLJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int HJBMKMIAMOM;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6502C80", Offset = "0x6501480", VA = "0x186502C80")]
	public JOOCMJCHHCC(Behaviour LFDLOIPEDMO, float BKPBEJOPGAH, int HAKCBBLIBOF, [Optional] Action IIHOJDOOBIF, float MGPOFMPDENE = 0f, [Optional] JNLGLOFFOHI BGNGHLNFJKM, [Optional] EJGBDPIPIGA AKKKKHHOJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "9")]
	protected override bool LLLBKLJEDEB(Action KJDOCFCKCJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6502A00", Offset = "0x6501200", VA = "0x186502A00", Slot = "10")]
	protected override bool GNCJFDIEKMC(Action KJDOCFCKCJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6502C00", Offset = "0x6501400", VA = "0x186502C00")]
	private void NALLACKCKAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class PHDIPJCKGGI : CMCLEJBLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float BMDFGJFJDBL;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6506C70", Offset = "0x6505470", VA = "0x186506C70")]
	public PHDIPJCKGGI(Behaviour LFDLOIPEDMO, float BMDFGJFJDBL, [Optional] Action IIHOJDOOBIF, [Optional] JNLGLOFFOHI BGNGHLNFJKM, [Optional] EJGBDPIPIGA AKKKKHHOJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "9")]
	protected override bool LLLBKLJEDEB(Action KJDOCFCKCJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x650E010", Offset = "0x650C810", VA = "0x18650E010", Slot = "10")]
	protected override bool GNCJFDIEKMC(Action KJDOCFCKCJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class FPGAKJBMFAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class PKKDGCJCIKH : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private HHDDIFIMNDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public PKKDGCJCIKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6506990", Offset = "0x6505190", VA = "0x186506990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x650E050", Offset = "0x650C850", VA = "0x18650E050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private LKIMHCEDPCI HLPEABJMFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private DJDABJADMBM LFDLOIPEDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> ENHBHECCKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private DJINKDPOIHN IIKKOCDJGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float DOLJMNEINCK;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x64FD6A0", Offset = "0x64FBEA0", VA = "0x1864FD6A0")]
	public FPGAKJBMFAD(DJDABJADMBM LFDLOIPEDMO, float MHMFPDLGAEB, Action<float> FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x64FD3A0", Offset = "0x64FBBA0", VA = "0x1864FD3A0")]
	private void EODILLNIOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x64FD540", Offset = "0x64FBD40", VA = "0x1864FD540")]
	private void JBOJPJMIEFA(string MFCNDEMKIPG, Action LONBGILELAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x64FD110", Offset = "0x64FB910", VA = "0x1864FD110")]
	[IteratorStateMachine(typeof(PKKDGCJCIKH))]
	private IEnumerator<HHDDIFIMNDJ> BLMLADLIPKL(Action LONBGILELAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x64FD340", Offset = "0x64FBB40", VA = "0x1864FD340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x64FD190", Offset = "0x64FB990", VA = "0x1864FD190")]
	[CompilerGenerated]
	private void DKPKKMCPMDI(string GKFJGAEIAFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class PEGHDELMPJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class LDOFFBOFAJJ : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private HHDDIFIMNDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public LDOFFBOFAJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6506990", Offset = "0x6505190", VA = "0x186506990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6506A00", Offset = "0x6505200", VA = "0x186506A00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private LKIMHCEDPCI HLPEABJMFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour NAKKDFCMEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action FCGOAPMCHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> ENHBHECCKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private DJINKDPOIHN IIKKOCDJGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float DOLJMNEINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool OIDHDBOOBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly JNLGLOFFOHI BGNGHLNFJKM;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x650D990", Offset = "0x650C190", VA = "0x18650D990")]
	public PEGHDELMPJN(MonoBehaviour NAKKDFCMEME, Action FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ, [Optional] JNLGLOFFOHI BGNGHLNFJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x650DDD0", Offset = "0x650C5D0", VA = "0x18650DDD0")]
	public PEGHDELMPJN(MonoBehaviour NAKKDFCMEME, Action<float> FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ, [Optional] JNLGLOFFOHI BGNGHLNFJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x650DB80", Offset = "0x650C380", VA = "0x18650DB80")]
	public PEGHDELMPJN(MonoBehaviour NAKKDFCMEME, float MHMFPDLGAEB, Action<float> FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ, bool OIDHDBOOBHP = true, [Optional] JNLGLOFFOHI BGNGHLNFJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1893190", Offset = "0x1891990", VA = "0x181893190")]
	private PEGHDELMPJN(JNLGLOFFOHI BGNGHLNFJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x650D660", Offset = "0x650BE60", VA = "0x18650D660")]
	internal static PEGHDELMPJN MAKFIMEFHBF(MonoBehaviour NAKKDFCMEME, float MHMFPDLGAEB, Action<float> FCGOAPMCHNB, DJINKDPOIHN IIKKOCDJGJJ, bool OIDHDBOOBHP = true, [Optional] JNLGLOFFOHI BGNGHLNFJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x650D790", Offset = "0x650BF90", VA = "0x18650D790")]
	private void PEPJBHKJDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x650D050", Offset = "0x650B850", VA = "0x18650D050")]
	private void CHLDOFFPLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x650D260", Offset = "0x650BA60", VA = "0x18650D260")]
	private void EODILLNIOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x650CE10", Offset = "0x650B610", VA = "0x18650CE10")]
	private void BACKIAFCJOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x650D4A0", Offset = "0x650BCA0", VA = "0x18650D4A0")]
	private void JBOJPJMIEFA(string MFCNDEMKIPG, Action LONBGILELAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x650CFD0", Offset = "0x650B7D0", VA = "0x18650CFD0")]
	[IteratorStateMachine(typeof(LDOFFBOFAJJ))]
	private IEnumerator<HHDDIFIMNDJ> BLMLADLIPKL(Action LONBGILELAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x650D200", Offset = "0x650BA00", VA = "0x18650D200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x650D410", Offset = "0x650BC10", VA = "0x18650D410")]
	[CompilerGenerated]
	private void FIJFJEDOIGN(string GKFJGAEIAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x650D5D0", Offset = "0x650BDD0", VA = "0x18650D5D0")]
	[CompilerGenerated]
	private void JNHNNELDPNH(string GKFJGAEIAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x650CD80", Offset = "0x650B580", VA = "0x18650CD80")]
	[CompilerGenerated]
	private void AGDOEGGJFGO(string GKFJGAEIAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x650D900", Offset = "0x650C100", VA = "0x18650D900")]
	[CompilerGenerated]
	private void PHLMLMONDMN(string GKFJGAEIAFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum LDDNDGMCBOD : byte
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
internal sealed class JJOILEAPIKE : EJGBDPIPIGA
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float IEKPOGMNAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x65017A0", Offset = "0x64FFFA0", VA = "0x1865017A0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float LBFHFHBOMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x65017D0", Offset = "0x64FFFD0", VA = "0x1865017D0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double NMLMHFNHKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x65017B0", Offset = "0x64FFFB0", VA = "0x1865017B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x65017E0", Offset = "0x64FFFE0", VA = "0x1865017E0")]
	[IOOPNJKFHOG(FICJCHGEBPC.None)]
	private static void OIMDAPJKMGI(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	[Preserve]
	internal JJOILEAPIKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface EEFHILGIEHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAEEGPEBCAF(string PMDCAPIFBIP);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EONHJLFDNEM();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface IJKMFCDAAKN
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string JOBPEPKBADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool GHOHJDFGENL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool AKBOIJDHGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class BHGHNBDEKNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public KHBDGGIHACJ ENKCFBCIJGB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int EGOJHBDPODL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x771180", Offset = "0x76F980", VA = "0x180771180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x77C550", Offset = "0x77AD50", VA = "0x18077C550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x64F3E00", Offset = "0x64F2600", VA = "0x1864F3E00")]
	public static HHDDIFIMNDJ ACEEHLBGPCM(IEnumerator<HHDDIFIMNDJ> MDNPBHLNMFC, DDNBLAKOKAH MAJIEHJIJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x64F3F60", Offset = "0x64F2760", VA = "0x1864F3F60")]
	public HHDDIFIMNDJ ACEEHLBGPCM(DDNBLAKOKAH[] MCPBNOOBEAF, IEnumerator<HHDDIFIMNDJ>[] ICIKBGHENEA, HHDDIFIMNDJ[] KIJNNFHPLOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x64F4020", Offset = "0x64F2820", VA = "0x1864F4020")]
	public void GBIPAJGDPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x64F4190", Offset = "0x64F2990", VA = "0x1864F4190")]
	public void LGGGKJCJDML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x64F4050", Offset = "0x64F2850", VA = "0x1864F4050")]
	public void JEGBKHABPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x64F4020", Offset = "0x64F2820", VA = "0x1864F4020")]
	public void GGPHDHEGLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public BHGHNBDEKNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class KHBDGGIHACJ
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct AAMBMFGKLFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public BHGHNBDEKNN HDMIKPDDMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public DJDABJADMBM NFCNKBPCFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public DDNBLAKOKAH CDDPGBNMIIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<HHDDIFIMNDJ> BBOLGOIBAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public HHDDIFIMNDJ MNGIBNCFHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public LDDNDGMCBOD EEIMDKGJBMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct OMJIIOFDPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public DJINKDPOIHN GBCGIKECHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<AAMBMFGKLFB> CLMPDFNDFKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JOLIMLKFGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public DDNBLAKOKAH promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public KHBDGGIHACJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public DJDABJADMBM context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public BHGHNBDEKNN routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public LDDNDGMCBOD coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public HHDDIFIMNDJ currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<HHDDIFIMNDJ> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JOLIMLKFGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6502250", Offset = "0x6500A50", VA = "0x186502250")]
		internal void MCBCGFOILBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class DAICHMDLHFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public BHGHNBDEKNN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public KHBDGGIHACJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public DAICHMDLHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x64F8E70", Offset = "0x64F7670", VA = "0x1864F8E70")]
		internal void ODONKABCIFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class JOEHOCAGBMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public BHGHNBDEKNN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public KHBDGGIHACJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JOEHOCAGBMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6502210", Offset = "0x6500A10", VA = "0x186502210")]
		internal void HIHAPIMKNEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class JGKNBKHMDPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public BHGHNBDEKNN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public KHBDGGIHACJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JGKNBKHMDPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6501760", Offset = "0x64FFF60", VA = "0x186501760")]
		internal void ICOOHFOJMKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const LDDNDGMCBOD PKNLGMALAMK = LDDNDGMCBOD.Cancelled | LDDNDGMCBOD.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly DJINKDPOIHN IIKKOCDJGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] GBLPNEHFNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<LDDNDGMCBOD> EGOJDKAOOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> GODPDJCBPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> HFCELHKKKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> KEDOEHHFMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> NLELGGCLMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> KDHNIJBBJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> DNGCKJNPIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private BHGHNBDEKNN[] MGDMGJNPAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private DDNBLAKOKAH[] MCPBNOOBEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private DJDABJADMBM[] PIBACEKFBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<HHDDIFIMNDJ>[] LJGGBPCOHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private HHDDIFIMNDJ[] GJLFLEGNGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int KDNHBDLIMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int JHAJBCMGPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int CHMJMGJFABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float AOPBFMAMPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private ELKFMGDBPBA LCBELIPODIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle EFKPMGKMFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<BHGHNBDEKNN> FIFKMNIADND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool LCCHELKBCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> ONCPKBDNLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> LPELGDJGGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool MEFKJMGPCPM;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public OMJIIOFDPCC[] LHLBBBBEFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x966BF0", Offset = "0x9653F0", VA = "0x180966BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6505390", Offset = "0x6503B90", VA = "0x186505390")]
	private static int OCIKDEMJFHE(DJINKDPOIHN IIKKOCDJGJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x65053C0", Offset = "0x6503BC0", VA = "0x1865053C0")]
	public KHBDGGIHACJ(DJINKDPOIHN IIKKOCDJGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6503F90", Offset = "0x6502790", VA = "0x186503F90")]
	private void GDJDHPBCPDH(int KJBDHBOIKGN, int LGNOIFAHHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6503830", Offset = "0x6502030", VA = "0x186503830")]
	public void CCOEENPKNJH(DJDABJADMBM LFDLOIPEDMO, HHDDIFIMNDJ EKJELAHOEFA, IEnumerator<HHDDIFIMNDJ> MDNPBHLNMFC, DDNBLAKOKAH MAJIEHJIJBF, [Optional] BHGHNBDEKNN GHFDBMJDMBO, LDDNDGMCBOD CCIJNLEIHBM = LDDNDGMCBOD.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6503AF0", Offset = "0x65022F0", VA = "0x186503AF0")]
	public void DOGNCNLECIL(IEnumerable<AAMBMFGKLFB> PLHJAPBLOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6503060", Offset = "0x6501860", VA = "0x186503060")]
	private AAMBMFGKLFB AFEADHKJKPL(int KHGGKCMKLOL)
	{
		return default(AAMBMFGKLFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6505020", Offset = "0x6503820", VA = "0x186505020")]
	private void NLMHEKFFAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2557CF0", Offset = "0x25564F0", VA = "0x182557CF0")]
	private static void NJDNAEBCGBH<T>(int KHGGKCMKLOL, T[] POFAHIJNMIM, int NKCDHJPJBIF, [Optional] T CPOCOPOCPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2557D40", Offset = "0x2556540", VA = "0x182557D40")]
	private static void NJDNAEBCGBH<T>(int KHGGKCMKLOL, NativeArray<T> POFAHIJNMIM, int NKCDHJPJBIF, [Optional] T CPOCOPOCPEI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6504580", Offset = "0x6502D80", VA = "0x186504580")]
	private void LGJPIEIPCML(IEnumerable<AAMBMFGKLFB> PLHJAPBLOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x65039B0", Offset = "0x65021B0", VA = "0x1865039B0")]
	private void CHKABNGGNLI(AAMBMFGKLFB IGIBKLNLLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x65042A0", Offset = "0x6502AA0", VA = "0x1865042A0")]
	private EJFCANDKIGP GNKAOMLKADN(int DOOHEABNHHJ)
	{
		return default(EJFCANDKIGP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6503630", Offset = "0x6501E30", VA = "0x186503630")]
	public void BLHLHDHECEH(float NKIJCBIIGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6503A70", Offset = "0x6502270", VA = "0x186503A70")]
	private void DGLOJJIABPM(Action GIFKCLLLICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6504500", Offset = "0x6502D00", VA = "0x186504500")]
	private void HGPKENCGKCO(Action GIFKCLLLICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6504920", Offset = "0x6503120", VA = "0x186504920")]
	public void NGKNFHFPDNH(float NKIJCBIIGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6503530", Offset = "0x6501D30", VA = "0x186503530")]
	public void ALEHCMDHAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6504170", Offset = "0x6502970", VA = "0x186504170")]
	public void GGPHDHEGLGO(BHGHNBDEKNN HFAGJMAIALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6503D30", Offset = "0x6502530", VA = "0x186503D30")]
	public void FILEMDPPIIG(BHGHNBDEKNN HFAGJMAIALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6503E60", Offset = "0x6502660", VA = "0x186503E60")]
	public void FOFAECFEFND(BHGHNBDEKNN HFAGJMAIALI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class LDENFGIODLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly LDENFGIODLF NJCGGNOBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action OMPFANPIIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool INDDNGMBDBO;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	public LDENFGIODLF(Action OMPFANPIIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6506840", Offset = "0x6505040", VA = "0x186506840", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface ANHHICJMLII<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T HMHFMLFLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable EDNLDCPNLJM(UnityEngine.Object LFDLOIPEDMO, Action<T> JFHJADHDDFO);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface OHACKLPLKMO<T> : ANHHICJMLII<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T HMHFMLFLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class LPHCBEMAFMJ<T> : OHACKLPLKMO<T>, ANHHICJMLII<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class JLOGLBEOGKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public LPHCBEMAFMJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public DBMMIPKMIHD<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JLOGLBEOGKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x38B0050", Offset = "0x38AE850", VA = "0x1838B0050")]
		internal void CDJMLIENLDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject FBKFMEJFKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<DBMMIPKMIHD<UnityEngine.Object, Action<T>>> POHJACKOFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T CAHEMAFFNOL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T HMHFMLFLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F30", Offset = "0x7F5730", VA = "0x1807F6F30", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3A79750", Offset = "0x3A77F50", VA = "0x183A79750", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A79650", Offset = "0x3A77E50", VA = "0x183A79650")]
	private static bool CEPMDCHEEFH(T GIFKCLLLICD, T KIOLHHMPBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A7A280", Offset = "0x3A78A80", VA = "0x183A7A280")]
	public LPHCBEMAFMJ(T CAMPGFGKCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A799E0", Offset = "0x3A781E0", VA = "0x183A799E0", Slot = "6")]
	public IDisposable EDNLDCPNLJM(UnityEngine.Object LFDLOIPEDMO, Action<T> JFHJADHDDFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A79B70", Offset = "0x3A78370", VA = "0x183A79B70")]
	private void JNJOMNGLLHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class JNAPOOPPBGH : MPJNIDDKIGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly JNLGLOFFOHI BGNGHLNFJKM;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6501900", Offset = "0x6500100", VA = "0x186501900")]
	[IOOPNJKFHOG(FICJCHGEBPC.None)]
	private static void OIMDAPJKMGI(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	[Preserve]
	internal JNAPOOPPBGH([NBBCAEDCKMG(null)] JNLGLOFFOHI BGNGHLNFJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6501850", Offset = "0x6500050", VA = "0x186501850", Slot = "4")]
	public IDisposable IIGPGGHEDHJ(float MHMFPDLGAEB, Action<float> CGEKFPDGHCG, bool OIDHDBOOBHP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class KLCFHEKDIDH : FPLDNJCBDKH, JNLGLOFFOHI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private KHBDGGIHACJ[] NJLNIIHHADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private EEFHILGIEHJ IPJKMDJJDKB;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6506460", Offset = "0x6504C60", VA = "0x186506460")]
	[IOOPNJKFHOG(FICJCHGEBPC.None)]
	private static void OIMDAPJKMGI(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6506640", Offset = "0x6504E40", VA = "0x186506640")]
	[Preserve]
	public KLCFHEKDIDH([NBBCAEDCKMG(null)] EKAPBENGAHK MEEBBAAHAKK, [NBBCAEDCKMG(null)] EJGBDPIPIGA AKKKKHHOJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6506300", Offset = "0x6504B00", VA = "0x186506300", Slot = "17")]
	public override LKIMHCEDPCI GKEJGNLGKNA(DJDABJADMBM LFDLOIPEDMO, IEnumerator<HHDDIFIMNDJ> HGHFLDFHHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6505FF0", Offset = "0x65047F0", VA = "0x186505FF0", Slot = "18")]
	public override void EINJMPIPEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6505A10", Offset = "0x6504210", VA = "0x186505A10", Slot = "20")]
	public override void ACLKNNOIHOP(DJINKDPOIHN IIKKOCDJGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x65064D0", Offset = "0x6504CD0", VA = "0x1865064D0", Slot = "19")]
	protected override void OMANMGAMPNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6506430", Offset = "0x6504C30", VA = "0x186506430")]
	private KHBDGGIHACJ JEBADEJBEMN(DJINKDPOIHN HJNJPNKDEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6505D60", Offset = "0x6504560", VA = "0x186505D60", Slot = "21")]
	internal override JNFCOOFIAOE BHGBDAJJFCN(IEnumerator<HHDDIFIMNDJ> HGHFLDFHHAE, Behaviour LFDLOIPEDMO, DDNBLAKOKAH MAJIEHJIJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6506280", Offset = "0x6504A80", VA = "0x186506280", Slot = "22")]
	internal override OEMNCDKPMCL EOCGDAEBDNG(DJINKDPOIHN IHOPAFHILPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6505C40", Offset = "0x6504440", VA = "0x186505C40")]
	private void BGOJABPBODN(KHBDGGIHACJ GEOAOFKGPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6505F90", Offset = "0x6504790", VA = "0x186505F90", Slot = "23")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct ELKFMGDBPBA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float KKLEPADLIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int KOHIMDKJKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> EOLPOOCFIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> BNDMGALILBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> JHNKPPECKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<LDDNDGMCBOD> ILBMDFIJMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> NBGMGGOLBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> NLELGGCLMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> HFCELHKKKCE;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x64FBDE0", Offset = "0x64FA5E0", VA = "0x1864FBDE0")]
	public static ELKFMGDBPBA OEONKPJDENI(int BDLFIFBCNCN, float NKIJCBIIGBE, NativeArray<LDDNDGMCBOD> HAGEIODPEIF, NativeArray<float> IGCLBGMAHEG, NativeArray<int> FHLDDJCELEC, NativeArray<int> JBLDHFHGAAJ, NativeArray<int> EKJKGPLKHCE, NativeArray<int> BNDMGALILBJ, NativeArray<int> JHNKPPECKJL)
	{
		return default(ELKFMGDBPBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x64FB9F0", Offset = "0x64FA1F0", VA = "0x1864FB9F0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x64FBF10", Offset = "0x64FA710", VA = "0x1864FBF10")]
	private bool PABOAEJNONM(int EAHCFBMNNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x64FBD10", Offset = "0x64FA510", VA = "0x1864FBD10")]
	private void JMINIHCAHNK(NativeArray<int> IGBGCCOMDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x64FBD40", Offset = "0x64FA540", VA = "0x1864FBD40")]
	private int KPODEENMHAE(int NNMBEMMIJBC, int HOKNABGIGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x64FBE40", Offset = "0x64FA640", VA = "0x1864FBE40")]
	private void OGINAKIJFCA(NativeArray<int> IGBGCCOMDEP, int BGNOMPEIIFC, int PMKDCBJFJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x64FBAD0", Offset = "0x64FA2D0", VA = "0x1864FBAD0")]
	private void HNNACEFHIME(NativeArray<int> IGBGCCOMDEP, int MAOIFHBJEPE, int OCIPKGKGCAB, int EPMCHBMFPDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class FPLDNJCBDKH : JNLGLOFFOHI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly EKAPBENGAHK MEEBBAAHAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly EJGBDPIPIGA AKKKKHHOJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private OEMNCDKPMCL[] IEFJGEHLDHK;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static JNLGLOFFOHI ODCBNHJKAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x64FD930", Offset = "0x64FC130", VA = "0x1864FD930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool PCAIHPKKNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x78D2A0", Offset = "0x78BAA0", VA = "0x18078D2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DJINKDPOIHN MEHBNMIMDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x771180", Offset = "0x76F980", VA = "0x180771180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(DJINKDPOIHN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x77C550", Offset = "0x77AD50", VA = "0x18077C550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EJGBDPIPIGA LDKMGGHLDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public HHDDIFIMNDJ HKHKHLFEDBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public HHDDIFIMNDJ ALPPDPKNPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7771E0", Offset = "0x7759E0", VA = "0x1807771E0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x64FE0D0", Offset = "0x64FC8D0", VA = "0x1864FE0D0")]
	public static LKIMHCEDPCI HAGLJADHFEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x64FE7C0", Offset = "0x64FCFC0", VA = "0x1864FE7C0")]
	[Preserve]
	protected FPLDNJCBDKH([NBBCAEDCKMG(null)] EKAPBENGAHK MEEBBAAHAKK, [NBBCAEDCKMG(null)] EJGBDPIPIGA AKKKKHHOJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x64FE7B0", Offset = "0x64FCFB0", VA = "0x1864FE7B0", Slot = "6")]
	public LKIMHCEDPCI PODNDBGONHN(IEnumerator<HHDDIFIMNDJ> HGHFLDFHHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x64FE5B0", Offset = "0x64FCDB0", VA = "0x1864FE5B0", Slot = "7")]
	public LKIMHCEDPCI PODNDBGONHN(Behaviour LFDLOIPEDMO, IEnumerator<HHDDIFIMNDJ> HGHFLDFHHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract LKIMHCEDPCI GKEJGNLGKNA(DJDABJADMBM LFDLOIPEDMO, IEnumerator<HHDDIFIMNDJ> HGHFLDFHHAE);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x64FDF30", Offset = "0x64FC730", VA = "0x1864FDF30", Slot = "18")]
	public virtual void EINJMPIPEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x64FE370", Offset = "0x64FCB70", VA = "0x1864FE370", Slot = "9")]
	public void PDHLDPKABAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x64FE350", Offset = "0x64FCB50", VA = "0x1864FE350", Slot = "19")]
	protected virtual void OMANMGAMPNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x64FE310", Offset = "0x64FCB10", VA = "0x1864FE310")]
	private void NNOOJFNPPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x64FE160", Offset = "0x64FC960", VA = "0x1864FE160")]
	private void KJIADOEHDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x64FE330", Offset = "0x64FCB30", VA = "0x1864FE330")]
	private void OBFGJLHMCFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x64FE210", Offset = "0x64FCA10", VA = "0x1864FE210")]
	private void LPLGEFOKLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x64FD980", Offset = "0x64FC180", VA = "0x1864FD980")]
	private void DEJHJPFGJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x64FD910", Offset = "0x64FC110", VA = "0x1864FD910")]
	private void AOPEOBHCFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x64FE290", Offset = "0x64FCA90", VA = "0x1864FE290")]
	private void NCACAKPGKJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x64FD880", Offset = "0x64FC080", VA = "0x1864FD880", Slot = "20")]
	public virtual void ACLKNNOIHOP(DJINKDPOIHN IIKKOCDJGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x64FD9A0", Offset = "0x64FC1A0", VA = "0x1864FD9A0")]
	private void DJOGEEFDJCP(OEMNCDKPMCL GEOAOFKGPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1BF6A40", Offset = "0x1BF5240", VA = "0x181BF6A40")]
	private OEMNCDKPMCL OLFJFPDOIPM(DJINKDPOIHN HJNJPNKDEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract JNFCOOFIAOE BHGBDAJJFCN(IEnumerator<HHDDIFIMNDJ> HGHFLDFHHAE, Behaviour NAKKDFCMEME, DDNBLAKOKAH HFPOGDLPOIJ);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract OEMNCDKPMCL EOCGDAEBDNG(DJINKDPOIHN IIKKOCDJGJJ);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x64FDB70", Offset = "0x64FC370", VA = "0x1864FDB70", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x64FE230", Offset = "0x64FCA30", VA = "0x1864FE230", Slot = "13")]
	public HHDDIFIMNDJ MHPELFKNFCH(DJINKDPOIHN IHOPAFHILPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x64FE180", Offset = "0x64FC980", VA = "0x1864FE180", Slot = "14")]
	public HHDDIFIMNDJ KOHIEJMKNCO(float GDAIBLFKMLM, DJINKDPOIHN IHOPAFHILPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x64FE2B0", Offset = "0x64FCAB0", VA = "0x1864FE2B0", Slot = "15")]
	public HHDDIFIMNDJ NDONPADLFPM(Func<bool> CPCFGJNAACA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class JNFCOOFIAOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly DDNBLAKOKAH MAJIEHJIJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly IJKMFCDAAKN LFDLOIPEDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool OPFDIGGCPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string PMDCAPIFBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace GPDAEBMILJC;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerator<HHDDIFIMNDJ> BBOLGOIBAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public HHDDIFIMNDJ MNGIBNCFHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773780", VA = "0x180774F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool OHMBIDFFKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6501C80", Offset = "0x6500480", VA = "0x186501C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool JNCGEGFGFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA70", Offset = "0x7DE270", VA = "0x1807DFA70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA80", Offset = "0x7DE280", VA = "0x1807DFA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string JOBPEPKBADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6501DC0", Offset = "0x65005C0", VA = "0x186501DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float LBHPPJLHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1027910", Offset = "0x1026110", VA = "0x181027910")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x54A91C0", Offset = "0x54A79C0", VA = "0x1854A91C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6502050", Offset = "0x6500850", VA = "0x186502050")]
	public JNFCOOFIAOE(IEnumerator<HHDDIFIMNDJ> MDNPBHLNMFC, IJKMFCDAAKN LFDLOIPEDMO, DDNBLAKOKAH MAJIEHJIJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6501970", Offset = "0x6500170", VA = "0x186501970")]
	public HHDDIFIMNDJ ACEEHLBGPCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6501D50", Offset = "0x6500550", VA = "0x186501D50")]
	public bool GKCHFMIGEAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6501D00", Offset = "0x6500500", VA = "0x186501D00")]
	public void GGPHDHEGLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6501F70", Offset = "0x6500770", VA = "0x186501F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8600A0", Offset = "0x85E8A0", VA = "0x1808600A0")]
	[CompilerGenerated]
	private void HAIOGIBAJPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class DDNBLAKOKAH : BMHCLEPLHMK, LKIMHCEDPCI, BIBLBPOCMFE, BEGOMKNHMOK, IEnumerator, HHDDIFIMNDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private DJINKDPOIHN KNELLICKJCK;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private DJINKDPOIHN BOKCOICBGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xDA9380", Offset = "0xDA7B80", VA = "0x180DA9380", Slot = "23")]
		get
		{
			return default(DJINKDPOIHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public DJINKDPOIHN ENKCFBCIJGB
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x12A0E10", Offset = "0x129F610", VA = "0x1812A0E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private float PDAMDPOHBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F70", Offset = "0x7C5770", VA = "0x1807C6F70", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool HIINBJDKPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x64F91D0", Offset = "0x64F79D0", VA = "0x1864F91D0", Slot = "24")]
	private bool DNIBFDBPLPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x64F91F0", Offset = "0x64F79F0", VA = "0x1864F91F0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x64F9200", Offset = "0x64F7A00", VA = "0x1864F9200")]
	public DDNBLAKOKAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum EJFCANDKIGP : byte
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
internal sealed class OEMNCDKPMCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum OPMHFGCFJHI
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct BBHNIHIBJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public DJINKDPOIHN GBCGIKECHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public OPMHFGCFJHI GFEDHNLBGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<JNFCOOFIAOE> BHAPNNMALBN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OPMHFGCFJHI[] IMJHCJNCCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly DJINKDPOIHN IIKKOCDJGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool MFHHMCEKDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly JNFCOOFIAOE[] GLJCMGOLDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<JNFCOOFIAOE> ANBOJHDLCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> CLPCLFMCIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<JNFCOOFIAOE> JEBKDNIAMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> FOLCNMHIEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly EEFHILGIEHJ AKNGMDFOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool MEFKJMGPCPM;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public BBHNIHIBJAD[,] PKNMFHGGIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7771E0", Offset = "0x7759E0", VA = "0x1807771E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x650C080", Offset = "0x650A880", VA = "0x18650C080")]
	public OEMNCDKPMCL(DJINKDPOIHN IHOPAFHILPH, EEFHILGIEHJ AKNGMDFOOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x650B3D0", Offset = "0x6509BD0", VA = "0x18650B3D0")]
	public void GKAEIEAHICM(JNFCOOFIAOE MDNPBHLNMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x650B4D0", Offset = "0x6509CD0", VA = "0x18650B4D0")]
	public void GKMCJMBIJFE(IList<JNFCOOFIAOE> ICIKBGHENEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x650ACA0", Offset = "0x65094A0", VA = "0x18650ACA0")]
	public void BLJGAODJCDE(IList<JNFCOOFIAOE> ICIKBGHENEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x650B970", Offset = "0x650A170", VA = "0x18650B970")]
	private void JFCGFKGPIBM(JNFCOOFIAOE MDNPBHLNMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x650B7E0", Offset = "0x6509FE0", VA = "0x18650B7E0")]
	private void HPEKJBNMKKB(IList<JNFCOOFIAOE> ICIKBGHENEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x650BA60", Offset = "0x650A260", VA = "0x18650BA60")]
	private EJFCANDKIGP MAAEGEIFHOH(JNFCOOFIAOE MDNPBHLNMFC)
	{
		return default(EJFCANDKIGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x650BBE0", Offset = "0x650A3E0", VA = "0x18650BBE0")]
	public void OMANMGAMPNF(float NKIJCBIIGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x650BD50", Offset = "0x650A550", VA = "0x18650BD50")]
	public void PDHLDPKABAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x650B0D0", Offset = "0x65098D0", VA = "0x18650B0D0")]
	private void EONNDPHAEID(List<JNFCOOFIAOE> ICIKBGHENEA, Stack<int> EGNDHLDMNFB, bool DDIONKKFNAN, float FCKAFNOBOAE = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x650AFB0", Offset = "0x65097B0", VA = "0x18650AFB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x650AB60", Offset = "0x6509360", VA = "0x18650AB60")]
	private void AENAPGKJMEI(List<JNFCOOFIAOE> ICIKBGHENEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class DPHJAEKFKBH : EEFHILGIEHJ
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "4")]
	public void NAEEGPEBCAF(string PMDCAPIFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
	public void EONHJLFDNEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public DPHJAEKFKBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class NNCFGOGCHHM : IJKMFCDAAKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour NAKKDFCMEME;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string JOBPEPKBADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x650A250", Offset = "0x6508A50", VA = "0x18650A250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GHOHJDFGENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x650A2F0", Offset = "0x6508AF0", VA = "0x18650A2F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool AKBOIJDHGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x650A2D0", Offset = "0x6508AD0", VA = "0x18650A2D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	public NNCFGOGCHHM(Behaviour NAKKDFCMEME)
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

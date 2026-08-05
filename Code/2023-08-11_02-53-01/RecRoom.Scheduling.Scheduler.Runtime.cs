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
public class FJHOBEDEPPG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority CCDAOOBDANJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E75B60", Offset = "0x4E74360", VA = "0x184E75B60")]
	public FJHOBEDEPPG(ThreadPriority PIOOFHLMBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E75B50", Offset = "0x4E74350", VA = "0x184E75B50", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> OLCMOGDDGEB(List<PlayerLoopSystem> HMNAFOKFDKP, int MGHGGLJJMAF);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct PHBFBOOECIH
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct EBNBEHANOPI
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static NJDLJLDNKHA PHEPFKJEPNL;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x4E71E00", Offset = "0x4E70600", VA = "0x184E71E00")]
				public static PlayerLoopSystem OPFFLKIJGOB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct GILMAICPDKB
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static NJDLJLDNKHA LFAHJFOPAGB;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x4E76AA0", Offset = "0x4E752A0", VA = "0x184E76AA0")]
				public static PlayerLoopSystem OPFFLKIJGOB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct OLONMEELAHC
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static NJDLJLDNKHA EEEENHMHHFK;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4E7F3B0", Offset = "0x4E7DBB0", VA = "0x184E7F3B0")]
				public static PlayerLoopSystem OPFFLKIJGOB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct HHCJALCMHLI
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static NJDLJLDNKHA CEOOOINDCOH;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static NJDLJLDNKHA PBGIEJCMDPD;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static NJDLJLDNKHA BJIHJIJOGBA;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static NJDLJLDNKHA ONLOJJNOALD;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x4E79170", Offset = "0x4E77970", VA = "0x184E79170")]
				public static PlayerLoopSystem OPFFLKIJGOB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct GMKHABLKGGA
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static NJDLJLDNKHA MCNMNBMELMG;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x4E77840", Offset = "0x4E76040", VA = "0x184E77840")]
				public static PlayerLoopSystem OPFFLKIJGOB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct FPPMKANBIFF
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static NJDLJLDNKHA CEOOOINDCOH;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static NJDLJLDNKHA PBGIEJCMDPD;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static NJDLJLDNKHA BJIHJIJOGBA;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static NJDLJLDNKHA ONLOJJNOALD;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x4E75BA0", Offset = "0x4E743A0", VA = "0x184E75BA0")]
				public static PlayerLoopSystem OPFFLKIJGOB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct AMLBBHCOKDF
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static NJDLJLDNKHA AMLPOICHPIH;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x4E6B300", Offset = "0x4E69B00", VA = "0x184E6B300")]
				public static PlayerLoopSystem OPFFLKIJGOB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct MHOLHFNGDGJ
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static NJDLJLDNKHA KJFMICKECJP;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x4E7DA50", Offset = "0x4E7C250", VA = "0x184E7DA50")]
				public static PlayerLoopSystem OPFFLKIJGOB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct GPAOICLKEFA
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static NJDLJLDNKHA BGLLMPDODFN;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x4E77A50", Offset = "0x4E76250", VA = "0x184E77A50")]
				public static PlayerLoopSystem OPFFLKIJGOB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct AAIJGFFJPNO
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static NJDLJLDNKHA LCBDHKJHKJO;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x4E6AAF0", Offset = "0x4E692F0", VA = "0x184E6AAF0")]
				public static PlayerLoopSystem OPFFLKIJGOB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct INENCKIBOCB
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static NJDLJLDNKHA IJKFEOHLNKP;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x4E7ADB0", Offset = "0x4E795B0", VA = "0x184E7ADB0")]
				public static PlayerLoopSystem OPFFLKIJGOB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct DJEFKNELNNC
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static NJDLJLDNKHA JMNPHOBMJGH;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x4E71B40", Offset = "0x4E70340", VA = "0x184E71B40")]
				public static PlayerLoopSystem OPFFLKIJGOB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum MLNKJAABKLC : byte
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
			public struct ABOIKHENJND
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class PAOKDEGJCMB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public MLNKJAABKLC updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
					public PAOKDEGJCMB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x4E7FF70", Offset = "0x4E7E770", VA = "0x184E7FF70")]
					internal void DOCEEFBAPDD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static BPPINFIIDCE<MLNKJAABKLC> KACHBCCIHPO;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x4E6AD00", Offset = "0x4E69500", VA = "0x184E6AD00")]
				public static PlayerLoopSystem OPFFLKIJGOB(MLNKJAABKLC JLBAMKAJKKA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct ODMFJDGGCBI
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class KADPGGDKPLH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public GAEHFNNOFPJ.JBMLOPMJJCN key;

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
					public KADPGGDKPLH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x4E7B7E0", Offset = "0x4E79FE0", VA = "0x184E7B7E0")]
					internal void PFDAAHDNPJP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable LFPMKBJDOFH;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x4E7F180", Offset = "0x4E7D980", VA = "0x184E7F180")]
				public static PlayerLoopSystem CPPEAJKFLIM(GAEHFNNOFPJ.JBMLOPMJJCN EECINICJCLK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct KHOBPGNBHEM
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class PDDGLCFMILN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public GAEHFNNOFPJ.JBMLOPMJJCN key;

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
					public PDDGLCFMILN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x4E80000", Offset = "0x4E7E800", VA = "0x184E80000")]
					internal void PFDAAHDNPJP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x4E7BA50", Offset = "0x4E7A250", VA = "0x184E7BA50")]
				public static PlayerLoopSystem CPPEAJKFLIM(GAEHFNNOFPJ.JBMLOPMJJCN EECINICJCLK)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class KNCJCFJBDEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public KNCJCFJBDEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4E7C330", Offset = "0x4E7AB30", VA = "0x184E7C330")]
			internal List<PlayerLoopSystem> CKONEICINOC(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool GJKFIIANGJB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool LEPNOFHEAGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x4E6FC10", Offset = "0x4E6E410", VA = "0x184E6FC10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x4E6C9B0", Offset = "0x4E6B1B0", VA = "0x184E6C9B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C9F0", Offset = "0x4E6B1F0", VA = "0x184E6C9F0")]
		private static void CKNAEPBHPLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E6F340", Offset = "0x4E6DB40", VA = "0x184E6F340")]
		private static void DJFDKJCHPNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E6FC50", Offset = "0x4E6E450", VA = "0x184E6FC50")]
		private static void FNDFAGFIIFA(string NDNIMBJDLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C780", Offset = "0x4E6AF80", VA = "0x184E6C780")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C5B0", Offset = "0x4E6ADB0", VA = "0x184E6C5B0")]
		private static void AMHEGEANFIF(GAEHFNNOFPJ.JBMLOPMJJCN EECINICJCLK, ref PlayerLoopSystem KOPGEHDHPKO, Type FNDOIFPBLNH, Type ABKEBIPNJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4E700B0", Offset = "0x4E6E8B0", VA = "0x184E700B0")]
		private static void JOOHHOILOKG(ref PlayerLoopSystem KOPGEHDHPKO, Type FNDOIFPBLNH, Type ABKEBIPNJKC, OLCMOGDDGEB HLNBONLDNFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E6FF80", Offset = "0x4E6E780", VA = "0x184E6FF80")]
		private static void GDGPNIMJGMO(ref PlayerLoopSystem KOPGEHDHPKO, Type FNDOIFPBLNH, Type ABKEBIPNJKC, PlayerLoopSystem? DPDNHBHLLJL, PlayerLoopSystem? DHIPOMBOJMB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GAEHFNNOFPJ
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum JBMLOPMJJCN
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
	public class LMMDCONKBHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly JBMLOPMJJCN EBPDHFDJAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly FDADGIFKHPD FLKGBONDNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long CBMCKBIFJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long INOKDDCLIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long KBJDJDEOOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int HCEDBCMPKNN;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4E7C8A0", Offset = "0x4E7B0A0", VA = "0x184E7C8A0")]
		public LMMDCONKBHP(JBMLOPMJJCN DJJGIANJCON, int GMHMNEPCPOC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4E7C830", Offset = "0x4E7B030", VA = "0x184E7C830")]
		public void KHPMEALENPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4E7C7D0", Offset = "0x4E7AFD0", VA = "0x184E7C7D0")]
		public void EMOHLICAGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4E7C5D0", Offset = "0x4E7ADD0", VA = "0x184E7C5D0")]
		public void DKBMIMENNGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static JBMLOPMJJCN[] IJAIIIIFIEI;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static LMMDCONKBHP[] AFNGJHDAEHA;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4E75EF0", Offset = "0x4E746F0", VA = "0x184E75EF0")]
	public static LMMDCONKBHP EGKJHANAIBH(JBMLOPMJJCN EECINICJCLK, int GMHMNEPCPOC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4E75E60", Offset = "0x4E74660", VA = "0x184E75E60")]
	public static LMMDCONKBHP BKGMBHBFIOA(JBMLOPMJJCN EECINICJCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4E760D0", Offset = "0x4E748D0", VA = "0x184E760D0")]
	public static void NIGEOAPDKJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EKEHLIGOPHB
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private interface DCPOEOJJGEM
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool OLKNLLNGLMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HEIMLJKPJJI();
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private abstract class EGMEJLBOIDH<TPromise, TMainThreadPromise> : DCPOEOJJGEM where TPromise : GHJKEMFHLHG where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly TPromise CJCMFLKINCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected readonly TMainThreadPromise CGODGKDHPMF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TPromise ELDOMGIGJLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x24723B0", Offset = "0x2470BB0", VA = "0x1824723B0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool OLKNLLNGLMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2472440", Offset = "0x2470C40", VA = "0x182472440", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1EFAB10", Offset = "0x1EF9310", VA = "0x181EFAB10")]
		protected EGMEJLBOIDH(TPromise CJCMFLKINCI, TMainThreadPromise HAEGMJNPBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2472410", Offset = "0x2470C10", VA = "0x182472410", Slot = "5")]
		public void HEIMLJKPJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void LCFGACKEJNB(TPromise CJCMFLKINCI);
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class FKHKCLBEAFB<T> : EGMEJLBOIDH<JJMNNLLBAJO<T>, NBKOKFNHPDK<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2036310", Offset = "0x2034B10", VA = "0x182036310")]
		public FKHKCLBEAFB(JJMNNLLBAJO<T> CJCMFLKINCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2036130", Offset = "0x2034930", VA = "0x182036130", Slot = "6")]
		protected override void LCFGACKEJNB(JJMNNLLBAJO<T> CJCMFLKINCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x20362E0", Offset = "0x2034AE0", VA = "0x1820362E0")]
		[CompilerGenerated]
		private void LPFHAKKBGKN(T LACIMGIMLFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xC34590", Offset = "0xC32D90", VA = "0x180C34590")]
		[CompilerGenerated]
		private void BGFPMCHAPME(string OABOGFOJNOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class PCIEMGIHNGH : DCPOEOJJGEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Action COPPLLLOGLG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool OLKNLLNGLMF
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
		public PCIEMGIHNGH(Action COPPLLLOGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A80", Offset = "0xAB1280", VA = "0x180AB2A80", Slot = "5")]
		public void HEIMLJKPJJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<DCPOEOJJGEM> OJFANNDMCBG;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2AFEF60", Offset = "0x2AFD760", VA = "0x182AFEF60")]
	public static JJMNNLLBAJO<T> JFAAAFOPNEA<T>(this JJMNNLLBAJO<T> CJCMFLKINCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4E75360", Offset = "0x4E73B60", VA = "0x184E75360")]
	public static void JFAAAFOPNEA(Action COPPLLLOGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2AFEFD0", Offset = "0x2AFD7D0", VA = "0x182AFEFD0")]
	private static JJMNNLLBAJO<T> KCBPEPMGOMG<T>(JJMNNLLBAJO<T> CJCMFLKINCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4E75090", Offset = "0x4E73890", VA = "0x184E75090")]
	private static void IIBEINAMHGJ(DCPOEOJJGEM MHHNDIFJEOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4E74D90", Offset = "0x4E73590", VA = "0x184E74D90")]
	private static void FLLICDHJDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4E74C90", Offset = "0x4E73490", VA = "0x184E74C90")]
	private static void FBBJGIKHPND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4E75290", Offset = "0x4E73A90", VA = "0x184E75290")]
	private static void JBLFNNPLMPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class PFONIOHMMGK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private struct GPOLKOABDGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<Scene> BGMIALJCBAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly string EOFLALLFEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly LoadSceneMode EAIHECKIMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly bool EMBCONAHFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4E77C60", Offset = "0x4E76460", VA = "0x184E77C60")]
		public GPOLKOABDGO(TaskCompletionSource<Scene> GMKLILNJJNF, string EOFLALLFEDN, LoadSceneMode EAIHECKIMPO, bool EMBCONAHFKN, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class PHHLBOIHFHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CINMLNOINGA<string> <toDispose>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private BDOLGIFCNLA <stackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private GPOLKOABDGO <queuedSceneLoad>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PHHLBOIHFHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4E83920", Offset = "0x4E82120", VA = "0x184E83920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class OAIKJNPOKJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OAIKJNPOKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EE40", Offset = "0x4E7D640", VA = "0x184E7EE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class HBGADBLHJLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private GPOLKOABDGO <dequeued>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Scene <scene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Scene <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HBGADBLHJLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4E77CC0", Offset = "0x4E764C0", VA = "0x184E77CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class LKAGHILGGAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NBKOKFNHPDK<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LKAGHILGGAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4E7C450", Offset = "0x4E7AC50", VA = "0x184E7C450")]
		internal void NINLELIPBLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class NJMKNOKBPKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <loadSceneTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private LKAGHILGGAO <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool <shouldLoadEmptyScene>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Scene <emptyScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Scene <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NJMKNOKBPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4E7DC90", Offset = "0x4E7C490", VA = "0x184E7DC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class NNKOCFOCNBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private SceneInstance <instance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NNKOCFOCNBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4E7E680", Offset = "0x4E7CE80", VA = "0x184E7E680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class OPHPHOHOBME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Scene <emptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <emptySceneRoutineTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <emptySceneTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OPHPHOHOBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4E7F5C0", Offset = "0x4E7DDC0", VA = "0x184E7F5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MPKADBBDEEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MPKADBBDEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4E7DC60", Offset = "0x4E7C460", VA = "0x184E7DC60")]
		internal bool EFIOEEBGLMA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class APBEIBLCGIP : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public ACOJIJEEGAO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <sample>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private MPKADBBDEEL <>8__3;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public APBEIBLCGIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4E6B920", Offset = "0x4E6A120", VA = "0x184E6B920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4E6B510", Offset = "0x4E69D10", VA = "0x184E6B510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4E6B890", Offset = "0x4E6A090", VA = "0x184E6B890")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4E6B8E0", Offset = "0x4E6A0E0", VA = "0x184E6B8E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class PHGBOPJNGEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public NBKOKFNHPDK<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PHGBOPJNGEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4E838A0", Offset = "0x4E820A0", VA = "0x184E838A0")]
		internal bool JCHFCHLICCP(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4E83630", Offset = "0x4E81E30", VA = "0x184E83630")]
		internal void EHOOPGDOOFF(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PEKGEKNIKIN : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public NBKOKFNHPDK<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private PHGBOPJNGEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public PEKGEKNIKIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4E80E60", Offset = "0x4E7F660", VA = "0x184E80E60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4E81690", Offset = "0x4E7FE90", VA = "0x184E81690", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly ICollection<string> DGMMIDECBMI;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static GHJKEMFHLHG BPMEPLKDABN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AsyncOperation BIKFMBMPMHG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static GHJKEMFHLHG CPOCFNLMBPC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static string HDALEGCIJKL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static ThreadPriority MECODABKHBN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task PHHPKPLJDLA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static List<SceneInstance> DKHMCGAGGHC;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Queue<GPOLKOABDGO> OOIGICINHCA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Task JHEDFKPFLMC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool CIGLKCHAELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4E82770", Offset = "0x4E80F70", VA = "0x184E82770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool PPPNCKJLDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4E81F80", Offset = "0x4E80780", VA = "0x184E81F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private static bool LHCJDIHCJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4E824C0", Offset = "0x4E80CC0", VA = "0x184E824C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static bool EFBDLLCKPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4E81A70", Offset = "0x4E80270", VA = "0x184E81A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> MOAGHMEBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4E816D0", Offset = "0x4E7FED0", VA = "0x184E816D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4E821A0", Offset = "0x4E809A0", VA = "0x184E821A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4E822A0", Offset = "0x4E80AA0", VA = "0x184E822A0")]
	[MJIBHDEGBGP(LPNMEKMJEJD.EnteredEditModeNextFrame, 0)]
	private static void IMEPENPLHFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4E82DF0", Offset = "0x4E815F0", VA = "0x184E82DF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PHHLBOIHFHL))]
	public static Task<Scene> PHMDGEHGMAN(string EOFLALLFEDN, LoadSceneMode EAIHECKIMPO = LoadSceneMode.Single, bool EMBCONAHFKN = false, [Optional] CINMLNOINGA<string>.BIMPMJLMAHG EEOMDEAGLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4E81B20", Offset = "0x4E80320", VA = "0x184E81B20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OAIKJNPOKJE))]
	private static Task EMPKLOLLPIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4E82CF0", Offset = "0x4E814F0", VA = "0x184E82CF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HBGADBLHJLH))]
	private static Task NLFJDADPIHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4E818C0", Offset = "0x4E800C0", VA = "0x184E818C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NJMKNOKBPKN))]
	private static Task<Scene> CMLCNCKPKIE(string EOFLALLFEDN, LoadSceneMode EAIHECKIMPO, bool EMBCONAHFKN, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4E817D0", Offset = "0x4E7FFD0", VA = "0x184E817D0")]
	private static void BOAMBGOCLAH(SceneInstance KLLABPMEFNM, LoadSceneMode EAIHECKIMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4E82C50", Offset = "0x4E81450", VA = "0x184E82C50")]
	private static void NFNKJHEEMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4E82040", Offset = "0x4E80840", VA = "0x184E82040")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NNKOCFOCNBP))]
	private static Task<Scene> GPOPODIDIMC(string EOFLALLFEDN, LoadSceneMode EAIHECKIMPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4E82B60", Offset = "0x4E81360", VA = "0x184E82B60")]
	private static bool NABMIFFMKLB(string EOFLALLFEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4E82370", Offset = "0x4E80B70", VA = "0x184E82370")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OPHPHOHOBME))]
	private static Task<Scene> JKBJEGHPCOK(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4E82580", Offset = "0x4E80D80", VA = "0x184E82580")]
	public static JJMNNLLBAJO<Scene> LKFDFHMGAMA(string EOFLALLFEDN, LoadSceneMode EAIHECKIMPO = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4E81CB0", Offset = "0x4E804B0", VA = "0x184E81CB0")]
	public static GHJKEMFHLHG GGBCOFDDFIH(string EOFLALLFEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4E81C20", Offset = "0x4E80420", VA = "0x184E81C20")]
	[IteratorStateMachine(typeof(APBEIBLCGIP))]
	private static IEnumerator<EPHOKNIGMNK> FDOAIONLCHL(string EOFLALLFEDN, ACOJIJEEGAO EDPKIHKMBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4E82FA0", Offset = "0x4E817A0", VA = "0x184E82FA0")]
	[IteratorStateMachine(typeof(PEKGEKNIKIN))]
	private static IEnumerator<EPHOKNIGMNK> PNNHLKBMJBE(string EOFLALLFEDN, LoadSceneMode EAIHECKIMPO, NBKOKFNHPDK<Scene> EDPKIHKMBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4E829F0", Offset = "0x4E811F0", VA = "0x184E829F0")]
	public static bool MJJDKEHBKPP(out string IMJIMKJPCNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FDADGIFKHPD : FCOFKKIHDHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int FHPAEMHANNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Queue<double> BLHOJNNECLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private double FFKEMABDPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private double JJHKIIGGPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private double NADBFLLFKGI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public double JCEDPJLDHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E757B0", Offset = "0x4E73FB0", VA = "0x184E757B0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double JBLCPIEEGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xCAEAE0", Offset = "0xCAD2E0", VA = "0x180CAEAE0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double HKGNGAOFDJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3E66E50", Offset = "0x3E65650", VA = "0x183E66E50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4E759C0", Offset = "0x4E741C0", VA = "0x184E759C0")]
	public FDADGIFKHPD(int ONJFFBBNHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4E75890", Offset = "0x4E74090", VA = "0x184E75890", Slot = "7")]
	public void PEKJOHOLKIG(double BNMGNDJJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4E75820", Offset = "0x4E74020", VA = "0x184E75820", Slot = "8")]
	public void OGPDBFFONOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NNMGAADCEJJ : FCOFKKIHDHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private long JMKNAPEFDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private double DEILOCAEJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private double HBDCKOGCONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private double IJJLCBFLHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private double EAEFOJADINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private double FFKEMABDPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private double JJHKIIGGPCB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x979150", Offset = "0x977950", VA = "0x180979150")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double JBLCPIEEGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EB80", Offset = "0x4E7D380", VA = "0x184E7EB80", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double HKGNGAOFDJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EB70", Offset = "0x4E7D370", VA = "0x184E7EB70", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double IIMKKLJIKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EBD0", Offset = "0x4E7D3D0", VA = "0x184E7EBD0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double JCEDPJLDHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4BF9410", Offset = "0x4BF7C10", VA = "0x184BF9410", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4E7EBE0", Offset = "0x4E7D3E0", VA = "0x184E7EBE0", Slot = "7")]
	public virtual void PEKJOHOLKIG(double BNMGNDJJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E7EB90", Offset = "0x4E7D390", VA = "0x184E7EB90", Slot = "8")]
	public virtual void OGPDBFFONOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4E76460", Offset = "0x4E74C60", VA = "0x184E76460")]
	public NNMGAADCEJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class GAJDNGMBIMH : NNMGAADCEJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public double BAKEJKFEDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3E67330", Offset = "0x3E65B30", VA = "0x183E67330")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3E672D0", Offset = "0x3E65AD0", VA = "0x183E672D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4E76320", Offset = "0x4E74B20", VA = "0x184E76320", Slot = "7")]
	public override void PEKJOHOLKIG(double BNMGNDJJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4E762E0", Offset = "0x4E74AE0", VA = "0x184E762E0", Slot = "8")]
	public override void OGPDBFFONOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4E76460", Offset = "0x4E74C60", VA = "0x184E76460")]
	public GAJDNGMBIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FCOFKKIHDHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	double JCEDPJLDHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double JBLCPIEEGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	double HKGNGAOFDJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class DNIJHCEAGPE : JOEMJKMPMJC
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public float KHEDBLOCGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4E71DF0", Offset = "0x4E705F0", VA = "0x184E71DF0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public float BFGNOMIDLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4E71DE0", Offset = "0x4E705E0", VA = "0x184E71DE0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public double CPILMPBCNNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4E71DC0", Offset = "0x4E705C0", VA = "0x184E71DC0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4E71D50", Offset = "0x4E70550", VA = "0x184E71D50")]
	[NFOBBCLLFPP(BGPNPCEMJLD.None)]
	private static void EBMOAACPAFK(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	[Preserve]
	internal DNIJHCEAGPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class DCNJJHBDKCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class MDAELEBPEPO : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public DCNJJHBDKCE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public MDAELEBPEPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4E7D940", Offset = "0x4E7C140", VA = "0x184E7D940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4E7D9E0", Offset = "0x4E7C1E0", VA = "0x184E7D9E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IIFKIJJEKEP KIHKCHEKHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private MonoBehaviour OIMMFDPCJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Action DELKFNCDMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Action<float> CKDHJLJOBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float CCHFFJODCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool KNAPJLDLOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly MBGNMJJGJPO HONOIPDBDEI;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4E716B0", Offset = "0x4E6FEB0", VA = "0x184E716B0")]
	public DCNJJHBDKCE(MonoBehaviour OIMMFDPCJIJ, Action DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, [Optional] MBGNMJJGJPO HONOIPDBDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4E71470", Offset = "0x4E6FC70", VA = "0x184E71470")]
	public DCNJJHBDKCE(MonoBehaviour OIMMFDPCJIJ, Action<float> DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, [Optional] MBGNMJJGJPO HONOIPDBDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4E71220", Offset = "0x4E6FA20", VA = "0x184E71220")]
	public DCNJJHBDKCE(MonoBehaviour OIMMFDPCJIJ, float JKJOGOGCCCP, Action<float> DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, bool KNAPJLDLOAG = true, [Optional] MBGNMJJGJPO HONOIPDBDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DAD5B0", Offset = "0x3DABDB0", VA = "0x183DAD5B0")]
	private DCNJJHBDKCE(MBGNMJJGJPO HONOIPDBDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4E70A00", Offset = "0x4E6F200", VA = "0x184E70A00")]
	internal static DCNJJHBDKCE FHCIJIOFIBA(MonoBehaviour OIMMFDPCJIJ, float JKJOGOGCCCP, Action<float> DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, bool KNAPJLDLOAG = true, [Optional] MBGNMJJGJPO HONOIPDBDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4E70830", Offset = "0x4E6F030", VA = "0x184E70830")]
	private void CNJEFIALCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E71070", Offset = "0x4E6F870", VA = "0x184E71070")]
	private void PHKNBBNNJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4E70680", Offset = "0x4E6EE80", VA = "0x184E70680")]
	private void CIMGMJLNMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E70B20", Offset = "0x4E6F320", VA = "0x184E70B20")]
	private void HIBLAPGMBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E70F30", Offset = "0x4E6F730", VA = "0x184E70F30")]
	private void NEBCBPNLOAC(string OABOGFOJNOI, Action LLGNBHBPBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E70E10", Offset = "0x4E6F610", VA = "0x184E70E10")]
	[IteratorStateMachine(typeof(MDAELEBPEPO))]
	private IEnumerator<EPHOKNIGMNK> LHNBJPOFKHH(Action LLGNBHBPBLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4E709A0", Offset = "0x4E6F1A0", VA = "0x184E709A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4E70D80", Offset = "0x4E6F580", VA = "0x184E70D80")]
	[CompilerGenerated]
	private void KJFPMHBMGCE(string BMGPOKGJALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4E70EA0", Offset = "0x4E6F6A0", VA = "0x184E70EA0")]
	[CompilerGenerated]
	private void NBEFMOKFECK(string BMGPOKGJALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4E70CF0", Offset = "0x4E6F4F0", VA = "0x184E70CF0")]
	[CompilerGenerated]
	private void KEGCAEFGOAH(string BMGPOKGJALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4E705F0", Offset = "0x4E6EDF0", VA = "0x184E705F0")]
	[CompilerGenerated]
	private void BKIOFDOMLDA(string BMGPOKGJALB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct LNMHOGFAGKG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[ReadOnly]
	public float FIAOEFDLJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	public int MMCPHOMJDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<int> FDMEBILIHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<int> AELIJBJKEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeArray<int> DAFJFMBIJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	public NativeArray<INNPLDMIIEM> LPBGNLGFMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	public NativeArray<float> JLGCMNMNOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[WriteOnly]
	public NativeArray<int> FJBNIJGAJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[WriteOnly]
	public NativeArray<int> KJBAIFCJOEE;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CDD0", Offset = "0x4E7B5D0", VA = "0x184E7CDD0")]
	public static LNMHOGFAGKG OIAKNFDBOOD(int FBCNIOHCNBA, float MCONJIBCLCD, NativeArray<INNPLDMIIEM> KFPNNMEFJDJ, NativeArray<float> NHBDIHDNJAG, NativeArray<int> AMKIIGJBIDB, NativeArray<int> DFCECCCAKGC, NativeArray<int> FBAFMLFBICB, NativeArray<int> AELIJBJKEOL, NativeArray<int> DAFJFMBIJBK)
	{
		return default(LNMHOGFAGKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4E7C9A0", Offset = "0x4E7B1A0", VA = "0x184E7C9A0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CB80", Offset = "0x4E7B380", VA = "0x184E7CB80")]
	private bool MNJGKBNOIEB(int AMOEKOMGDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CA80", Offset = "0x4E7B280", VA = "0x184E7CA80")]
	private void JMJOFPFBFJD(NativeArray<int> OBBJKPAEGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CE80", Offset = "0x4E7B680", VA = "0x184E7CE80")]
	private int PJFACKJOKGO(int NDDMEBNPANG, int OELPHAPNGPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CAB0", Offset = "0x4E7B2B0", VA = "0x184E7CAB0")]
	private void MACCKKNFFJC(NativeArray<int> OBBJKPAEGAL, int KNJJOCDPBKG, int LIOFIIHFDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CBC0", Offset = "0x4E7B3C0", VA = "0x184E7CBC0")]
	private void NAOEBCBAJHM(NativeArray<int> OBBJKPAEGAL, int AENLFAMBHDG, int GEMDGFEGOLF, int JKFMAAECKFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class PGDOMKHPDIF : HGACDMPIEOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly float NPHJOOBJFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly int CMDKABJLJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float IONMIIOBFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly float[] DKFBCCOJANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private int PJNLDJFDCMA;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4E83480", Offset = "0x4E81C80", VA = "0x184E83480")]
	public PGDOMKHPDIF(Behaviour HNBDDLBIIOF, float PPDFNIDNCJO, int CMDKABJLJCM, [Optional] Action KFNNNKADNLP, float IONMIIOBFBH = 0f, [Optional] MBGNMJJGJPO HONOIPDBDEI, [Optional] JOEMJKMPMJC FJNGFNPAGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8A3C30", Offset = "0x8A2430", VA = "0x1808A3C30", Slot = "9")]
	protected override bool JAKAEDIDHHG(Action COPPLLLOGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4E83250", Offset = "0x4E81A50", VA = "0x184E83250", Slot = "10")]
	protected override bool PBNAOIIPPDJ(Action COPPLLLOGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4E831C0", Offset = "0x4E819C0", VA = "0x184E831C0")]
	private void HLAGELJAKJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public abstract class HPFADLEOHIA : MBGNMJJGJPO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly JLELFANOIJD PFPLJNBNPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected readonly JOEMJKMPMJC FJNGFNPAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly GGLCNINCIPN PGIDCNANCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private PKOGBDDHLLI[] OIMCBKIDFHB;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static MBGNMJJGJPO OEFAOPMNMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4E7A010", Offset = "0x4E78810", VA = "0x184E7A010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool CENAPLLCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public JFMPFLAGBEN.EOFNJJHKHLI FBHOCAPAAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7DF240", Offset = "0x7DDA40", VA = "0x1807DF240", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JFMPFLAGBEN.EOFNJJHKHLI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xBE1D20", Offset = "0xBE0520", VA = "0x180BE1D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public JOEMJKMPMJC CDOFHNCOGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A100", Offset = "0x4E78900", VA = "0x184E7A100")]
	public static IIFKIJJEKEP HHHHPPGHHIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4E7AA00", Offset = "0x4E79200", VA = "0x184E7AA00")]
	[Preserve]
	protected HPFADLEOHIA([JHPEMCNOMHI(null)] JLELFANOIJD PFPLJNBNPBN, [JHPEMCNOMHI(null)] JOEMJKMPMJC FJNGFNPAGKL, [JHPEMCNOMHI(null)] GGLCNINCIPN PGIDCNANCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A3C0", Offset = "0x4E78BC0", VA = "0x184E7A3C0", Slot = "6")]
	public IIFKIJJEKEP JELDACCCIFL(IEnumerator<EPHOKNIGMNK> BCIPNLJHLNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A190", Offset = "0x4E78990", VA = "0x184E7A190", Slot = "7")]
	public IIFKIJJEKEP JELDACCCIFL(Behaviour HNBDDLBIIOF, IEnumerator<EPHOKNIGMNK> BCIPNLJHLNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract IIFKIJJEKEP BNGPEHEGOJF(IOKCCJLHHJC HNBDDLBIIOF, IEnumerator<EPHOKNIGMNK> BCIPNLJHLNE);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A410", Offset = "0x4E78C10", VA = "0x184E7A410", Slot = "13")]
	public virtual void OGPDBFFONOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A0A0", Offset = "0x4E788A0", VA = "0x184E7A0A0", Slot = "9")]
	public void HHECGJNLADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1C58CE0", Offset = "0x1C574E0", VA = "0x181C58CE0", Slot = "14")]
	protected virtual void DNNKNEBJAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A3F0", Offset = "0x4E78BF0", VA = "0x184E7A3F0")]
	private void LFAHJFOPAGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4E79FD0", Offset = "0x4E787D0", VA = "0x184E79FD0")]
	private void EEEENHMHHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4E79FF0", Offset = "0x4E787F0", VA = "0x184E79FF0")]
	private void EOBJHGDDJNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4E79C30", Offset = "0x4E78430", VA = "0x184E79C30")]
	private void DKCCEOOONFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4E79BF0", Offset = "0x4E783F0", VA = "0x184E79BF0")]
	private void AMLPOICHPIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A3D0", Offset = "0x4E78BD0", VA = "0x184E7A3D0")]
	private void KJFMICKECJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4E79C10", Offset = "0x4E78410", VA = "0x184E79C10")]
	private void ANLOPHOIBAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A7C0", Offset = "0x4E78FC0", VA = "0x184E7A7C0", Slot = "15")]
	public virtual void PKHNAOMKLPF(JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A5F0", Offset = "0x4E78DF0", VA = "0x184E7A5F0")]
	private void PIOJJALANGK(PKOGBDDHLLI BABHHJELBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A060", Offset = "0x4E78860", VA = "0x184E7A060")]
	private PKOGBDDHLLI HDHINGFDFIL(JFMPFLAGBEN.EOFNJJHKHLI EIOLDDJPDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract KINDENFDCLB HBPFEMNJNFM(IEnumerator<EPHOKNIGMNK> BCIPNLJHLNE, Behaviour OIMMFDPCJIJ, CDPFNOJJCKO HHJHFIKJDIO);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract PKOGBDDHLLI ENEGMCHFGMF(JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4E79C50", Offset = "0x4E78450", VA = "0x184E79C50", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class PDGLEHAGCDE : HPFADLEOHIA, MBGNMJJGJPO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private EDBHKEJBCOF[] OGFALCBCDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private IEKDNBNGOBP HILALFMOAHD;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4E80690", Offset = "0x4E7EE90", VA = "0x184E80690")]
	[NFOBBCLLFPP(BGPNPCEMJLD.None)]
	private static void EBMOAACPAFK(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4E80D90", Offset = "0x4E7F590", VA = "0x184E80D90")]
	[Preserve]
	public PDGLEHAGCDE([JHPEMCNOMHI(null)] JLELFANOIJD PFPLJNBNPBN, [JHPEMCNOMHI(null)] JOEMJKMPMJC FJNGFNPAGKL, [JHPEMCNOMHI(null)] GGLCNINCIPN PGIDCNANCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4E802D0", Offset = "0x4E7EAD0", VA = "0x184E802D0", Slot = "12")]
	public override IIFKIJJEKEP BNGPEHEGOJF(IOKCCJLHHJC HNBDDLBIIOF, IEnumerator<EPHOKNIGMNK> BCIPNLJHLNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4E808E0", Offset = "0x4E7F0E0", VA = "0x184E808E0", Slot = "13")]
	public override void OGPDBFFONOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4E80BC0", Offset = "0x4E7F3C0", VA = "0x184E80BC0", Slot = "15")]
	public override void PKHNAOMKLPF(JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4E80540", Offset = "0x4E7ED40", VA = "0x184E80540", Slot = "14")]
	protected override void DNNKNEBJAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4E80290", Offset = "0x4E7EA90", VA = "0x184E80290")]
	private EDBHKEJBCOF BFMKCKJMEAH(JFMPFLAGBEN.EOFNJJHKHLI EIOLDDJPDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4E80770", Offset = "0x4E7EF70", VA = "0x184E80770", Slot = "16")]
	internal override KINDENFDCLB HBPFEMNJNFM(IEnumerator<EPHOKNIGMNK> BCIPNLJHLNE, Behaviour HNBDDLBIIOF, CDPFNOJJCKO IAHNODEPOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4E80700", Offset = "0x4E7EF00", VA = "0x184E80700", Slot = "17")]
	internal override PKOGBDDHLLI ENEGMCHFGMF(JFMPFLAGBEN.EOFNJJHKHLI JBKCICGKJOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4E80420", Offset = "0x4E7EC20", VA = "0x184E80420")]
	private void DKHNCDLICNB(EDBHKEJBCOF BABHHJELBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4E80620", Offset = "0x4E7EE20", VA = "0x184E80620", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class GLJEKNGNJCI
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class HFJHKPDKDCE : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public JFMPFLAGBEN.EOFNJJHKHLI queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public HFJHKPDKDCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4E78090", Offset = "0x4E76890", VA = "0x184E78090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4E78140", Offset = "0x4E76940", VA = "0x184E78140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4E777C0", Offset = "0x4E75FC0", VA = "0x184E777C0")]
	[IteratorStateMachine(typeof(HFJHKPDKDCE))]
	private static IEnumerator<EPHOKNIGMNK> PNPGJIGICGC(JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, Func<bool> KINAKFGHJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4E776B0", Offset = "0x4E75EB0", VA = "0x184E776B0")]
	public static IIFKIJJEKEP FEGCPNFONBA(this MonoBehaviour OIMMFDPCJIJ, Func<bool> KINAKFGHJFA, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB = JFMPFLAGBEN.EOFNJJHKHLI.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class KINDENFDCLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly CDPFNOJJCKO IAHNODEPOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly NMBBLAJANCL HNBDDLBIIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly bool FGCANHPKHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private string MDOAADHDBMA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IEnumerator<EPHOKNIGMNK> KHPIKAOHEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EPHOKNIGMNK MHPDKPLPHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8E7480", Offset = "0x8E5C80", VA = "0x1808E7480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FMAEPNKBINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4E7BC30", Offset = "0x4E7A430", VA = "0x184E7BC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GDKNLGNGAEF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xEC6A10", Offset = "0xEC5210", VA = "0x180EC6A10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8E7450", Offset = "0x8E5C50", VA = "0x1808E7450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4E7BFC0", Offset = "0x4E7A7C0", VA = "0x184E7BFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float PMNDFDCJJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9780", Offset = "0x8A7F80", VA = "0x1808A9780")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x10F71C0", Offset = "0x10F59C0", VA = "0x1810F71C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4E7C220", Offset = "0x4E7AA20", VA = "0x184E7C220")]
	public KINDENFDCLB(IEnumerator<EPHOKNIGMNK> NGLFNBCIGHL, NMBBLAJANCL HNBDDLBIIOF, CDPFNOJJCKO IAHNODEPOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4E7BD30", Offset = "0x4E7A530", VA = "0x184E7BD30")]
	public EPHOKNIGMNK GCKIKDHDEPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4E7BBB0", Offset = "0x4E7A3B0", VA = "0x184E7BBB0")]
	public bool AGOKJOHAJGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4E7BCB0", Offset = "0x4E7A4B0", VA = "0x184E7BCB0")]
	public void CCPAFFLIAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4E7C140", Offset = "0x4E7A940", VA = "0x184E7C140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xE0E520", Offset = "0xE0CD20", VA = "0x180E0E520")]
	[CompilerGenerated]
	private void PHFHBIBFNAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class GEMGEBGEGEO
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class EHOPCNGDEGO : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public ODDGFCAPACG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public JFMPFLAGBEN.EOFNJJHKHLI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public EHOPCNGDEGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4E74BB0", Offset = "0x4E733B0", VA = "0x184E74BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4E74C50", Offset = "0x4E73450", VA = "0x184E74C50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4E76670", Offset = "0x4E74E70", VA = "0x184E76670")]
	public static IIFKIJJEKEP CNJEFIALCLG(float JKJOGOGCCCP, Action<float> DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, bool KNAPJLDLOAG = true, [Optional] MBGNMJJGJPO HONOIPDBDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4E76770", Offset = "0x4E74F70", VA = "0x184E76770")]
	public static IIFKIJJEKEP CNJEFIALCLG(MonoBehaviour OIMMFDPCJIJ, float JKJOGOGCCCP, Action<float> DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, bool KNAPJLDLOAG = true, [Optional] MBGNMJJGJPO HONOIPDBDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4E764A0", Offset = "0x4E74CA0", VA = "0x184E764A0")]
	public static IIFKIJJEKEP ANCFMPHEDNF(MonoBehaviour OIMMFDPCJIJ, float JKJOGOGCCCP, Action<float> DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, bool KNAPJLDLOAG = true, [Optional] MBGNMJJGJPO HONOIPDBDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4E76880", Offset = "0x4E75080", VA = "0x184E76880")]
	public static IIFKIJJEKEP HOIELIBLCKG(IOKCCJLHHJC HNBDDLBIIOF, float JKJOGOGCCCP, Action<float> DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, bool KNAPJLDLOAG = true, [Optional] MBGNMJJGJPO HONOIPDBDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4E769F0", Offset = "0x4E751F0", VA = "0x184E769F0")]
	private static IEnumerator<EPHOKNIGMNK> KGCAHLFABHL(JOEMJKMPMJC FJNGFNPAGKL, float JKJOGOGCCCP, JFMPFLAGBEN.EOFNJJHKHLI JBKCICGKJOH, Action<float> DELKFNCDMKF, bool KNAPJLDLOAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4E76990", Offset = "0x4E75190", VA = "0x184E76990")]
	private static IEnumerator<EPHOKNIGMNK> JDCEIPHJDJH(JOEMJKMPMJC FJNGFNPAGKL, float JKJOGOGCCCP, JFMPFLAGBEN.EOFNJJHKHLI JBKCICGKJOH, Action<float> DELKFNCDMKF, bool KNAPJLDLOAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4E765C0", Offset = "0x4E74DC0", VA = "0x184E765C0")]
	[IteratorStateMachine(typeof(EHOPCNGDEGO))]
	private static IEnumerator<EPHOKNIGMNK> BLOBFOAALEH(ODDGFCAPACG HDPCAPIHHKD, float JKJOGOGCCCP, JFMPFLAGBEN.EOFNJJHKHLI JBKCICGKJOH, Action<float> DELKFNCDMKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface MMIPIIELILE
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool PLLOMKFNFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LANPGFBBFMF;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OFPDKKAJGOM(bool BJDJJEPMPIM = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OFPDKKAJGOM(Action COPPLLLOGLG, bool BJDJJEPMPIM = false);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class DBMADCAFCGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static readonly DBMADCAFCGO GMPFDGPOJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Action EBGCECAFLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool DGDBOBKJJDN;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1950EC0", Offset = "0x194F6C0", VA = "0x181950EC0")]
	public DBMADCAFCGO(Action EBGCECAFLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x4E704D0", Offset = "0x4E6ECD0", VA = "0x184E704D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface GBLLLIAHGHE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T PGHJLABHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable JLFPDJEOHDF(UnityEngine.Object HNBDDLBIIOF, Action<T> FAKIOJBFKHK);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface IEPLHMAHODD<T> : GBLLLIAHGHE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T PGHJLABHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class EANOKMAOJDD<T> : IEPLHMAHODD<T>, GBLLLIAHGHE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class OLGAJGIJDGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public EANOKMAOJDD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public CEFFMLKIGGJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public OLGAJGIJDGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2E9E3F0", Offset = "0x2E9CBF0", VA = "0x182E9E3F0")]
		internal void DFBIACNBNEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static GameObject MPJOOJAPMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly List<CEFFMLKIGGJ<UnityEngine.Object, Action<T>>> CJCBFAHFBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private T NHNAILPNBFO;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T PGHJLABHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xE17760", Offset = "0xE15F60", VA = "0x180E17760", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2D934A0", Offset = "0x2D91CA0", VA = "0x182D934A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2D935D0", Offset = "0x2D91DD0", VA = "0x182D935D0")]
	private static bool PCLCDILPILH(T MBLAPCMEEGI, T NBEGIGNBOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2D93640", Offset = "0x2D91E40", VA = "0x182D93640")]
	public EANOKMAOJDD(T AOGBGNPINEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2D931C0", Offset = "0x2D919C0", VA = "0x182D931C0", Slot = "6")]
	public IDisposable JLFPDJEOHDF(UnityEngine.Object HNBDDLBIIOF, Action<T> FAKIOJBFKHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2D92AE0", Offset = "0x2D912E0", VA = "0x182D92AE0")]
	private void GHKNANGDMPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface IEKDNBNGOBP
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNJNCBAKNBE(string MDOAADHDBMA);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAFDLGHAJPN();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class HPIPKDBJEAN : IEKDNBNGOBP
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "4")]
	public void PNJNCBAKNBE(string MDOAADHDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
	public void HAFDLGHAJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public HPIPKDBJEAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class AMJCHOMOMCO : HGACDMPIEOB
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class MHNGHEFBHJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public AMJCHOMOMCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MHNGHEFBHJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4E7DA20", Offset = "0x4E7C220", VA = "0x184E7DA20")]
		internal void CNPPEOMFGHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class PDCOJNLIJCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AMJCHOMOMCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PDCOJNLIJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4E7DA20", Offset = "0x4E7C220", VA = "0x184E7DA20")]
		internal void NEJGNILOOML()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly float LFMIHLGEJCG;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B1F0", Offset = "0x4E699F0", VA = "0x184E6B1F0")]
	public AMJCHOMOMCO(Behaviour HNBDDLBIIOF, float LFMIHLGEJCG, [Optional] Action KFNNNKADNLP, [Optional] MBGNMJJGJPO HONOIPDBDEI, [Optional] JOEMJKMPMJC FJNGFNPAGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4E6AFF0", Offset = "0x4E697F0", VA = "0x184E6AFF0", Slot = "9")]
	protected override bool JAKAEDIDHHG(Action COPPLLLOGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B0F0", Offset = "0x4E698F0", VA = "0x184E6B0F0", Slot = "10")]
	protected override bool PBNAOIIPPDJ(Action COPPLLLOGLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class HILFPNFBIOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class FJGKKIBHJHC : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public HILFPNFBIOG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public FJGKKIBHJHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4E75A70", Offset = "0x4E74270", VA = "0x184E75A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4E75B10", Offset = "0x4E74310", VA = "0x184E75B10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private IIFKIJJEKEP KIHKCHEKHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private IOKCCJLHHJC HNBDDLBIIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private Action<float> CKDHJLJOBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private float CCHFFJODCKL;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4E79A10", Offset = "0x4E78210", VA = "0x184E79A10")]
	public HILFPNFBIOG(IOKCCJLHHJC HNBDDLBIIOF, float JKJOGOGCCCP, Action<float> DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4E79430", Offset = "0x4E77C30", VA = "0x184E79430")]
	private void CIMGMJLNMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4E796D0", Offset = "0x4E77ED0", VA = "0x184E796D0")]
	private void NEBCBPNLOAC(string OABOGFOJNOI, Action LLGNBHBPBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4E79640", Offset = "0x4E77E40", VA = "0x184E79640")]
	[IteratorStateMachine(typeof(FJGKKIBHJHC))]
	private IEnumerator<EPHOKNIGMNK> LHNBJPOFKHH(Action LLGNBHBPBLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4E795E0", Offset = "0x4E77DE0", VA = "0x184E795E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4E79850", Offset = "0x4E78050", VA = "0x184E79850")]
	[CompilerGenerated]
	private void PONHDFGJMNO(string BMGPOKGJALB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class EDBHKEJBCOF
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct KCMNFGNHIPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public BACKLENFGKM KFPFNOFPNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public IOKCCJLHHJC EMNMIGHKENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CDPFNOJJCKO JKKHPKEDPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<EPHOKNIGMNK> KHPIKAOHEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public EPHOKNIGMNK MHPDKPLPHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public INNPLDMIIEM NAICBIOKEDP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct GMBPKALJODA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public JFMPFLAGBEN.EOFNJJHKHLI CKABOPPCBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<KCMNFGNHIPE> OMJBKHOJELM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class JEBLNLBKIDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CDPFNOJJCKO promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public EDBHKEJBCOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IOKCCJLHHJC context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public BACKLENFGKM routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public INNPLDMIIEM coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public EPHOKNIGMNK currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<EPHOKNIGMNK> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JEBLNLBKIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4E7B000", Offset = "0x4E79800", VA = "0x184E7B000")]
		internal void BDLIOOPLKBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class JDKHILKGBON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public BACKLENFGKM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public EDBHKEJBCOF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JDKHILKGBON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4E7AFC0", Offset = "0x4E797C0", VA = "0x184E7AFC0")]
		internal void OKAIAHFKMOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class CHGLPCLBHBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public BACKLENFGKM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public EDBHKEJBCOF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CHGLPCLBHBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C570", Offset = "0x4E6AD70", VA = "0x184E6C570")]
		internal void GMJAGEFAGHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class OFOJLCIHNNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public BACKLENFGKM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public EDBHKEJBCOF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OFOJLCIHNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4E7F2E0", Offset = "0x4E7DAE0", VA = "0x184E7F2E0")]
		internal void JPBGHJAMKCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const INNPLDMIIEM KKDBPMMGDOJ = INNPLDMIIEM.Cancelled | INNPLDMIIEM.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] AOHEOMBAGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<INNPLDMIIEM> CHHLDBMPICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> ICBGEHMELGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> KJBAIFCJOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> BCJGIHDNFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> FJBNIJGAJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> PLGFGKMCLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> CACPFNEIGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private BACKLENFGKM[] JBOAPNBCLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private CDPFNOJJCKO[] IKLCPHOHPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IOKCCJLHHJC[] NDMDIGEHKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<EPHOKNIGMNK>[] LJIOKANKDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private EPHOKNIGMNK[] NGFMGMPGIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int LPHAHFJLJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int LNKEFEELODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int FAPFCDOGDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float PBDKOKLBNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private LNMHOGFAGKG PGPEEOINMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle CIJOLBIAAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<BACKLENFGKM> DACEHKEKCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool HFFKKKENFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> KFEAMCLIECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> FDALBKLAENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool LECDFBOAOCH;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public GMBPKALJODA[] EIHKANEEFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xD0B970", Offset = "0xD0A170", VA = "0x180D0B970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4E72FF0", Offset = "0x4E717F0", VA = "0x184E72FF0")]
	private static int COEIJIJKMLA(JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4E743B0", Offset = "0x4E72BB0", VA = "0x184E743B0")]
	public EDBHKEJBCOF(JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4E72E00", Offset = "0x4E71600", VA = "0x184E72E00")]
	private void CMIIGJAHION(ref int ABMIOPIBJLL, int MDFJKFEGKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4E722E0", Offset = "0x4E70AE0", VA = "0x184E722E0")]
	public void BLHFMHCENJJ(IOKCCJLHHJC HNBDDLBIIOF, EPHOKNIGMNK EEKFNDHOLFG, IEnumerator<EPHOKNIGMNK> NGLFNBCIGHL, CDPFNOJJCKO IAHNODEPOMP, [Optional] BACKLENFGKM LJMPKCFIKHE, INNPLDMIIEM MGIPLCIDNND = INNPLDMIIEM.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4E741D0", Offset = "0x4E729D0", VA = "0x184E741D0")]
	public void PAHBEPKNIKA(IEnumerable<KCMNFGNHIPE> IDNKDICHFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4E73C70", Offset = "0x4E72470", VA = "0x184E73C70")]
	private KCMNFGNHIPE OCGBMIEGILP(int ELPLHIGJGJA)
	{
		return default(KCMNFGNHIPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4E738C0", Offset = "0x4E720C0", VA = "0x184E738C0")]
	private void MFGBEJKJFPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2AFC320", Offset = "0x2AFAB20", VA = "0x182AFC320")]
	private static void JDJCFPGGNCI<T>(int ELPLHIGJGJA, T[] OLOLCPBLHPH, int JIAHBEIKEJF, [Optional] T AKEFLPNGPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2AFC300", Offset = "0x2AFAB00", VA = "0x182AFC300")]
	private static void JDJCFPGGNCI<T>(int ELPLHIGJGJA, NativeArray<T> OLOLCPBLHPH, int JIAHBEIKEJF, [Optional] T AKEFLPNGPCF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4E72010", Offset = "0x4E70810", VA = "0x184E72010")]
	private void AACLDNKAEHL(IEnumerable<KCMNFGNHIPE> IDNKDICHFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4E737F0", Offset = "0x4E71FF0", VA = "0x184E737F0")]
	private void LFIDNKJENDL(KCMNFGNHIPE EADDOLPGHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4E73400", Offset = "0x4E71C00", VA = "0x184E73400")]
	private DCGCFOGMOKN IDBCDLFJHDJ(int PENBPPCNJGG)
	{
		return default(DCGCFOGMOKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4E731A0", Offset = "0x4E719A0", VA = "0x184E731A0")]
	public void HKAHLPOABLO(float MCONJIBCLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4E73120", Offset = "0x4E71920", VA = "0x184E73120")]
	private void GBOFCJHFNKI(Action MBLAPCMEEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4E73380", Offset = "0x4E71B80", VA = "0x184E73380")]
	private void HNMOKMCPEDH(Action MBLAPCMEEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4E72460", Offset = "0x4E70C60", VA = "0x184E72460")]
	public void BMBGOEMKOPK(float MCONJIBCLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4E73020", Offset = "0x4E71820", VA = "0x184E73020")]
	public void FEIFDLJJPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4E72BA0", Offset = "0x4E713A0", VA = "0x184E72BA0")]
	public void CCPAFFLIAHM(BACKLENFGKM HDPCAPIHHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x4E72CD0", Offset = "0x4E714D0", VA = "0x184E72CD0")]
	public void CGGDECCFHEN(BACKLENFGKM HDPCAPIHHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x4E736C0", Offset = "0x4E71EC0", VA = "0x184E736C0")]
	public void JOLBJAGKMKE(BACKLENFGKM HDPCAPIHHKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class HFPJLKAEJPA : MMIPIIELILE, IEnumerable<MMIPIIELILE>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly List<MMIPIIELILE> FPDDBDPEHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool BEACADKJIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Action KFNNNKADNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private bool CBMLDCBEDNF;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool PLLOMKFNFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4E78520", Offset = "0x4E76D20", VA = "0x184E78520", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LANPGFBBFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4E78180", Offset = "0x4E76980", VA = "0x184E78180", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4E78960", Offset = "0x4E77160", VA = "0x184E78960", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4E78A80", Offset = "0x4E77280", VA = "0x184E78A80")]
	public HFPJLKAEJPA([Optional] Action KFNNNKADNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4E78220", Offset = "0x4E76A20", VA = "0x184E78220")]
	public void GLILACFFLBJ(MMIPIIELILE IBOLLPMBLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4E783C0", Offset = "0x4E76BC0", VA = "0x184E783C0")]
	private void HGOBKOKJION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4E78660", Offset = "0x4E76E60", VA = "0x184E78660", Slot = "7")]
	public bool OFPDKKAJGOM(bool BJDJJEPMPIM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4E78680", Offset = "0x4E76E80", VA = "0x184E78680", Slot = "8")]
	public bool OFPDKKAJGOM(Action COPPLLLOGLG, bool BJDJJEPMPIM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4E78340", Offset = "0x4E76B40", VA = "0x184E78340", Slot = "9")]
	public IEnumerator<MMIPIIELILE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4E78A00", Offset = "0x4E77200", VA = "0x184E78A00", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class HGACDMPIEOB : MMIPIIELILE
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class EMHBLOAOCBA : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public HGACDMPIEOB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public EMHBLOAOCBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4E75470", Offset = "0x4E73C70", VA = "0x184E75470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4E75540", Offset = "0x4E73D40", VA = "0x184E75540", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly Behaviour HNBDDLBIIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly Action KFNNNKADNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private KIPKMCKINOD JPEMKJKEMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly MBGNMJJGJPO HONOIPDBDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	protected readonly JOEMJKMPMJC FJNGFNPAGKL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool PLLOMKFNFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x123C710", Offset = "0x123AF10", VA = "0x18123C710", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LANPGFBBFMF
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4E78BA0", Offset = "0x4E773A0", VA = "0x184E78BA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4E78FD0", Offset = "0x4E777D0", VA = "0x184E78FD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4E79070", Offset = "0x4E77870", VA = "0x184E79070")]
	protected HGACDMPIEOB(Behaviour HNBDDLBIIOF, [Optional] Action KFNNNKADNLP, [Optional] MBGNMJJGJPO HONOIPDBDEI, [Optional] JOEMJKMPMJC FJNGFNPAGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4E78F20", Offset = "0x4E77720", VA = "0x184E78F20", Slot = "7")]
	public bool OFPDKKAJGOM(bool BJDJJEPMPIM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4E78F80", Offset = "0x4E77780", VA = "0x184E78F80", Slot = "8")]
	public bool OFPDKKAJGOM(Action COPPLLLOGLG, bool BJDJJEPMPIM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool JAKAEDIDHHG(Action COPPLLLOGLG);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool PBNAOIIPPDJ(Action COPPLLLOGLG);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4E78F00", Offset = "0x4E77700", VA = "0x184E78F00")]
	protected void MCLMMDEDNKB(Action COPPLLLOGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4E78CC0", Offset = "0x4E774C0", VA = "0x184E78CC0")]
	protected GHJKEMFHLHG FOEPOIALLEB(float DBCGMGMJHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4E78C40", Offset = "0x4E77440", VA = "0x184E78C40")]
	private void EMKMPOGNGKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x4E78B20", Offset = "0x4E77320", VA = "0x184E78B20")]
	[IteratorStateMachine(typeof(EMHBLOAOCBA))]
	private IEnumerator<EPHOKNIGMNK> BOLCJJPOLCJ(float DBCGMGMJHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x4E78EC0", Offset = "0x4E776C0", VA = "0x184E78EC0")]
	[CompilerGenerated]
	private void HKMFGFKANIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Flags]
internal enum INNPLDMIIEM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class BACKLENFGKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public EDBHKEJBCOF IBPNCFMHOPO;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JNDMMPHMODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7DF240", Offset = "0x7DDA40", VA = "0x1807DF240", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xBE1D20", Offset = "0xBE0520", VA = "0x180BE1D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BD40", Offset = "0x4E6A540", VA = "0x184E6BD40")]
	public static EPHOKNIGMNK GCKIKDHDEPM(IEnumerator<EPHOKNIGMNK> NGLFNBCIGHL, CDPFNOJJCKO IAHNODEPOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BC60", Offset = "0x4E6A460", VA = "0x184E6BC60")]
	public EPHOKNIGMNK GCKIKDHDEPM(CDPFNOJJCKO[] IKLCPHOHPGO, IEnumerator<EPHOKNIGMNK>[] EPKINCFCPEB, EPHOKNIGMNK[] PBMLGHBEPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BAF0", Offset = "0x4E6A2F0", VA = "0x184E6BAF0")]
	public void DKADCDFOHMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B9B0", Offset = "0x4E6A1B0", VA = "0x184E6B9B0")]
	public void BJOKLLNGEEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BB20", Offset = "0x4E6A320", VA = "0x184E6BB20")]
	public void DFBJLEJBGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BAF0", Offset = "0x4E6A2F0", VA = "0x184E6BAF0")]
	public void CCPAFFLIAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public BACKLENFGKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class EHNDGMHDPLJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class LMKMNFCHFHB : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public EHNDGMHDPLJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public LMKMNFCHFHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4E7C4B0", Offset = "0x4E7ACB0", VA = "0x184E7C4B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4E7C590", Offset = "0x4E7AD90", VA = "0x184E7C590", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Action MLMPJNFGILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private bool IJFJKCICDAJ;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool FJOACOHAPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA976F0", VA = "0x180A98EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4E74AB0", Offset = "0x4E732B0", VA = "0x184E74AB0")]
	public EHNDGMHDPLJ(JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4E749C0", Offset = "0x4E731C0", VA = "0x184E749C0")]
	[IteratorStateMachine(typeof(LMKMNFCHFHB))]
	private IEnumerator<EPHOKNIGMNK> OHDKEFOMBCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4E74A30", Offset = "0x4E73230", VA = "0x184E74A30", Slot = "4")]
	public void OnCompleted(Action ANOBKCKGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public void HMHPPOOGFGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class NOBLAEJHBAI
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4E7ED10", Offset = "0x4E7D510", VA = "0x184E7ED10")]
	public static EHNDGMHDPLJ CAGNJFBILCM(this JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal class AHDFCGLHEON : PCKPOPMIKKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly MBGNMJJGJPO HONOIPDBDEI;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4E6AF80", Offset = "0x4E69780", VA = "0x184E6AF80")]
	[NFOBBCLLFPP(BGPNPCEMJLD.None)]
	private static void EBMOAACPAFK(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	[Preserve]
	internal AHDFCGLHEON([JHPEMCNOMHI(null)] MBGNMJJGJPO HONOIPDBDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E6AEE0", Offset = "0x4E696E0", VA = "0x184E6AEE0", Slot = "4")]
	public IDisposable DMLPJOFHALH(float JKJOGOGCCCP, Action<float> JJFOLBCEJBD, bool KNAPJLDLOAG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal enum DCGCFOGMOKN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class PKOGBDDHLLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum EKKKHMBFKKI
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct NGDBEJCNHOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public JFMPFLAGBEN.EOFNJJHKHLI CKABOPPCBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public EKKKHMBFKKI INEHBDJJIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public List<KINDENFDCLB> LIJLDMNPIPM;
	}

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static readonly EKKKHMBFKKI[] OOIGEEAHLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private bool KGDJODFOIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly KINDENFDCLB[] CCDLBFNOJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly List<KINDENFDCLB> GBNKHENNGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Stack<int> KANBDMCPAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly List<KINDENFDCLB> IPKAFEHFNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Stack<int> MEMLGBODIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly IEKDNBNGOBP FIPFLHHNBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private bool LECDFBOAOCH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NGDBEJCNHOO[,] GFILHHFMOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCD0", Offset = "0x7DE4D0", VA = "0x1807DFCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4E855A0", Offset = "0x4E83DA0", VA = "0x184E855A0")]
	public PKOGBDDHLLI(JFMPFLAGBEN.EOFNJJHKHLI JBKCICGKJOH, IEKDNBNGOBP FIPFLHHNBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4E85210", Offset = "0x4E83A10", VA = "0x184E85210")]
	public void PDHPKNDFBIF(KINDENFDCLB NGLFNBCIGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4E84590", Offset = "0x4E82D90", VA = "0x184E84590")]
	public void EIIDPEJKPHA(IList<KINDENFDCLB> EPKINCFCPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4E84F40", Offset = "0x4E83740", VA = "0x184E84F40")]
	public void KIIFGCNPFML(IList<KINDENFDCLB> EPKINCFCPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4E84490", Offset = "0x4E82C90", VA = "0x184E84490")]
	private void EGIPFLPLFCH(KINDENFDCLB NGLFNBCIGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4E84A70", Offset = "0x4E83270", VA = "0x184E84A70")]
	private void IEOLPCHKGOL(IList<KINDENFDCLB> EPKINCFCPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4E85330", Offset = "0x4E83B30", VA = "0x184E85330")]
	private DCGCFOGMOKN PMNCCMDDFHB(KINDENFDCLB NGLFNBCIGHL)
	{
		return default(DCGCFOGMOKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4E84200", Offset = "0x4E82A00", VA = "0x184E84200")]
	public void DNNKNEBJAJP(float MCONJIBCLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4E84860", Offset = "0x4E83060", VA = "0x184E84860")]
	public void HHECGJNLADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4E84C00", Offset = "0x4E83400", VA = "0x184E84C00")]
	private void IIMNANODDKO(List<KINDENFDCLB> EPKINCFCPEB, Stack<int> MBGKAKKAHEB, bool EOLLABFPMJA, float HCOFMGGLFKA = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4E84350", Offset = "0x4E82B50", VA = "0x184E84350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4E840D0", Offset = "0x4E828D0", VA = "0x184E840D0")]
	private void CGMFNNEJLPF(List<KINDENFDCLB> EPKINCFCPEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class BGNKHGABFNA : NMBBLAJANCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Behaviour OIMMFDPCJIJ;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4E6BF70", Offset = "0x4E6A770", VA = "0x184E6BF70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool HADBIDIDPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4E6BEF0", Offset = "0x4E6A6F0", VA = "0x184E6BEF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool PAGJGEBEBAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4E6BF50", Offset = "0x4E6A750", VA = "0x184E6BF50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	public BGNKHGABFNA(Behaviour OIMMFDPCJIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class BPDMBPAJBME : HGACDMPIEOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly float LFMIHLGEJCG;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B1F0", Offset = "0x4E699F0", VA = "0x184E6B1F0")]
	public BPDMBPAJBME(Behaviour HNBDDLBIIOF, float LFMIHLGEJCG, [Optional] Action KFNNNKADNLP, [Optional] MBGNMJJGJPO HONOIPDBDEI, [Optional] JOEMJKMPMJC FJNGFNPAGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x8A3C30", Offset = "0x8A2430", VA = "0x1808A3C30", Slot = "9")]
	protected override bool JAKAEDIDHHG(Action COPPLLLOGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C000", Offset = "0x4E6A800", VA = "0x184E6C000", Slot = "10")]
	protected override bool PBNAOIIPPDJ(Action COPPLLLOGLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class DHKMGMHGPKN
{
	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4E71AC0", Offset = "0x4E702C0", VA = "0x184E71AC0")]
	public static IDisposable KCNGJNPAANF(this IOKCCJLHHJC HNBDDLBIIOF, float JKJOGOGCCCP, Action<float> DELKFNCDMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E719C0", Offset = "0x4E701C0", VA = "0x184E719C0")]
	public static IDisposable AJONKFKMHIB(this IOKCCJLHHJC HNBDDLBIIOF, Action<float> DELKFNCDMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E71A40", Offset = "0x4E70240", VA = "0x184E71A40")]
	public static IDisposable GBDOGEGGKIF(this IOKCCJLHHJC HNBDDLBIIOF, Action<float> DELKFNCDMKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class CGBJEABHCIM
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class DDODIJIPDDL : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public JFMPFLAGBEN.EOFNJJHKHLI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private OBKOODOFOJN <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public DDODIJIPDDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4E718B0", Offset = "0x4E700B0", VA = "0x184E718B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4E71980", Offset = "0x4E70180", VA = "0x184E71980", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class FACLOMMGHGP : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public JFMPFLAGBEN.EOFNJJHKHLI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private OBKOODOFOJN <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public FACLOMMGHGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4E75580", Offset = "0x4E73D80", VA = "0x184E75580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4E75670", Offset = "0x4E73E70", VA = "0x184E75670", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C3C0", Offset = "0x4E6ABC0", VA = "0x184E6C3C0")]
	public static IIFKIJJEKEP CNJEFIALCLG(Action DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C1F0", Offset = "0x4E6A9F0", VA = "0x184E6C1F0")]
	public static IIFKIJJEKEP CNJEFIALCLG(Behaviour HNBDDLBIIOF, Action DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C2B0", Offset = "0x4E6AAB0", VA = "0x184E6C2B0")]
	public static IIFKIJJEKEP CNJEFIALCLG(Behaviour HNBDDLBIIOF, Action<float> DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C4F0", Offset = "0x4E6ACF0", VA = "0x184E6C4F0")]
	[IteratorStateMachine(typeof(DDODIJIPDDL))]
	private static IEnumerator<EPHOKNIGMNK> KGCAHLFABHL(JFMPFLAGBEN.EOFNJJHKHLI JBKCICGKJOH, Action DELKFNCDMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C470", Offset = "0x4E6AC70", VA = "0x184E6C470")]
	[IteratorStateMachine(typeof(FACLOMMGHGP))]
	private static IEnumerator<EPHOKNIGMNK> KGCAHLFABHL(JFMPFLAGBEN.EOFNJJHKHLI JBKCICGKJOH, Action<float> DELKFNCDMKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class LOKBDJCOIOC
{
	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D190", Offset = "0x4E7B990", VA = "0x184E7D190")]
	public static IDisposable CNJEFIALCLG(this MonoBehaviour OIMMFDPCJIJ, Action DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D110", Offset = "0x4E7B910", VA = "0x184E7D110")]
	public static IDisposable CNJEFIALCLG(this MonoBehaviour OIMMFDPCJIJ, Action<float> DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D3D0", Offset = "0x4E7BBD0", VA = "0x184E7D3D0")]
	public static IDisposable DNNKNEBJAJP(this MonoBehaviour OIMMFDPCJIJ, Action DELKFNCDMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D440", Offset = "0x4E7BC40", VA = "0x184E7D440")]
	public static IDisposable EOBJHGDDJNN(this MonoBehaviour OIMMFDPCJIJ, Action DELKFNCDMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D2B0", Offset = "0x4E7BAB0", VA = "0x184E7D2B0")]
	public static IDisposable DKCCEOOONFA(this MonoBehaviour OIMMFDPCJIJ, Action DELKFNCDMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D830", Offset = "0x4E7C030", VA = "0x184E7D830")]
	public static IDisposable OMOBLILHCIE(this MonoBehaviour OIMMFDPCJIJ, Action DELKFNCDMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D090", Offset = "0x4E7B890", VA = "0x184E7D090")]
	public static IDisposable AOGCCNEMOMH(this MonoBehaviour OIMMFDPCJIJ, Action DELKFNCDMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D4C0", Offset = "0x4E7BCC0", VA = "0x184E7D4C0")]
	public static IDisposable FOINANPCKPE(this MonoBehaviour OIMMFDPCJIJ, float JKJOGOGCCCP, Action<float> DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, bool KNAPJLDLOAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CF70", Offset = "0x4E7B770", VA = "0x184E7CF70")]
	public static IDisposable AFAHAMGCLIG(this MonoBehaviour OIMMFDPCJIJ, float JKJOGOGCCCP, Action<float> DELKFNCDMKF, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, bool KNAPJLDLOAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D330", Offset = "0x4E7BB30", VA = "0x184E7D330")]
	public static IDisposable DMLPJOFHALH(this MonoBehaviour OIMMFDPCJIJ, float JKJOGOGCCCP, Action<float> DELKFNCDMKF, bool KNAPJLDLOAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D8B0", Offset = "0x4E7C0B0", VA = "0x184E7D8B0")]
	public static IDisposable PKJJHINMOJE(this MonoBehaviour OIMMFDPCJIJ, Action<float> DELKFNCDMKF, bool KNAPJLDLOAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D560", Offset = "0x4E7BD60", VA = "0x184E7D560")]
	public static IDisposable GLGLBDGFPPH(this MonoBehaviour OIMMFDPCJIJ, Action<float> DELKFNCDMKF, bool KNAPJLDLOAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CEE0", Offset = "0x4E7B6E0", VA = "0x184E7CEE0")]
	public static IDisposable ADCMKNHKOOP(this MonoBehaviour OIMMFDPCJIJ, Action<float> DELKFNCDMKF, bool KNAPJLDLOAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D7A0", Offset = "0x4E7BFA0", VA = "0x184E7D7A0")]
	public static IDisposable MJHGAMKDJFD(this MonoBehaviour OIMMFDPCJIJ, Action<float> DELKFNCDMKF, bool KNAPJLDLOAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D710", Offset = "0x4E7BF10", VA = "0x184E7D710")]
	public static IDisposable LKJHMGEBBLP(this MonoBehaviour OIMMFDPCJIJ, Action<float> DELKFNCDMKF, bool KNAPJLDLOAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D680", Offset = "0x4E7BE80", VA = "0x184E7D680")]
	public static IDisposable ILIHHMNEJAG(this MonoBehaviour OIMMFDPCJIJ, Action<float> DELKFNCDMKF, bool KNAPJLDLOAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D5F0", Offset = "0x4E7BDF0", VA = "0x184E7D5F0")]
	public static IDisposable ILEPBFMJIAP(this MonoBehaviour OIMMFDPCJIJ, Action<float> DELKFNCDMKF, bool KNAPJLDLOAG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D210", Offset = "0x4E7BA10", VA = "0x184E7D210")]
	public static IDisposable DHKOGHABNEG(this MonoBehaviour OIMMFDPCJIJ, float JKJOGOGCCCP, Action<float> DELKFNCDMKF, bool KNAPJLDLOAG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class CDPFNOJJCKO : JPFMDMMMPOO, IIFKIJJEKEP, KIPKMCKINOD, GHJKEMFHLHG, IEnumerator, EPHOKNIGMNK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private JFMPFLAGBEN.EOFNJJHKHLI GHGCONIBNIJ;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private JFMPFLAGBEN.EOFNJJHKHLI MCGOAPEECEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x351AB20", Offset = "0x3519320", VA = "0x18351AB20", Slot = "23")]
		get
		{
			return default(JFMPFLAGBEN.EOFNJJHKHLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public JFMPFLAGBEN.EOFNJJHKHLI IBPNCFMHOPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA74D40", Offset = "0xA73540", VA = "0x180A74D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private float PNJNGMHDJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xEDAC80", Offset = "0xED9480", VA = "0x180EDAC80", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool GHEBCNGDHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C050", Offset = "0x4E6A850", VA = "0x184E6C050", Slot = "24")]
	private bool IMHOODPFNMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C040", Offset = "0x4E6A840", VA = "0x184E6C040", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C070", Offset = "0x4E6A870", VA = "0x184E6C070")]
	public CDPFNOJJCKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal interface NMBBLAJANCL
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool HADBIDIDPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool PAGJGEBEBAG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class GJJCGFIJLEG
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class FCJECDBGBCF : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public JFMPFLAGBEN.EOFNJJHKHLI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public FCJECDBGBCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4E756B0", Offset = "0x4E73EB0", VA = "0x184E756B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4E75770", Offset = "0x4E73F70", VA = "0x184E75770", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class CFBBKJGMPBP : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public JFMPFLAGBEN.EOFNJJHKHLI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private EPHOKNIGMNK <wait>5__1;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public CFBBKJGMPBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C0D0", Offset = "0x4E6A8D0", VA = "0x184E6C0D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C1B0", Offset = "0x4E6A9B0", VA = "0x184E6C1B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4E77600", Offset = "0x4E75E00", VA = "0x184E77600")]
	[IteratorStateMachine(typeof(FCJECDBGBCF))]
	private static IEnumerator<EPHOKNIGMNK> OHDKEFOMBCG(float MDHEGNJEGJG, JFMPFLAGBEN.EOFNJJHKHLI JBKCICGKJOH, Action FJNHKBBJCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4E77370", Offset = "0x4E75B70", VA = "0x184E77370")]
	[IteratorStateMachine(typeof(CFBBKJGMPBP))]
	private static IEnumerator<EPHOKNIGMNK> LFGOCBJPDAB(float MDHEGNJEGJG, JFMPFLAGBEN.EOFNJJHKHLI JBKCICGKJOH, Action FJNHKBBJCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4E76D80", Offset = "0x4E75580", VA = "0x184E76D80")]
	public static IDisposable CLPBDEHGFOA(this MonoBehaviour OIMMFDPCJIJ, float MDHEGNJEGJG, Action FJNHKBBJCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4E77510", Offset = "0x4E75D10", VA = "0x184E77510")]
	public static IIFKIJJEKEP MLIGFCCJAMH(this MonoBehaviour OIMMFDPCJIJ, float MDHEGNJEGJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4E76EA0", Offset = "0x4E756A0", VA = "0x184E76EA0")]
	public static IIFKIJJEKEP CLPBDEHGFOA(this MonoBehaviour OIMMFDPCJIJ, float MDHEGNJEGJG, JFMPFLAGBEN.EOFNJJHKHLI JBKCICGKJOH, Action FJNHKBBJCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4E77690", Offset = "0x4E75E90", VA = "0x184E77690")]
	public static IIFKIJJEKEP ONBOAIIFJED(this MonoBehaviour OIMMFDPCJIJ, Action FJNHKBBJCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4E77400", Offset = "0x4E75C00", VA = "0x184E77400")]
	public static IIFKIJJEKEP LHHGCLONPIM(this MonoBehaviour OIMMFDPCJIJ, Action FJNHKBBJCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4E77430", Offset = "0x4E75C30", VA = "0x184E77430")]
	public static IIFKIJJEKEP MKMEHDNAFHJ(this MonoBehaviour OIMMFDPCJIJ, Action FJNHKBBJCJI, [Optional] MBGNMJJGJPO HONOIPDBDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4E775D0", Offset = "0x4E75DD0", VA = "0x184E775D0")]
	public static IIFKIJJEKEP NLHCOHEPFPE(this MonoBehaviour OIMMFDPCJIJ, Action FJNHKBBJCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4E770A0", Offset = "0x4E758A0", VA = "0x184E770A0")]
	public static IIFKIJJEKEP DMJJBFJCBKO(this MonoBehaviour OIMMFDPCJIJ, Action FJNHKBBJCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4E770D0", Offset = "0x4E758D0", VA = "0x184E770D0")]
	public static IIFKIJJEKEP DMNAOPKJGCH(this MonoBehaviour OIMMFDPCJIJ, Action FJNHKBBJCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4E771D0", Offset = "0x4E759D0", VA = "0x184E771D0")]
	private static IIFKIJJEKEP HBIFIPOGIPH(MonoBehaviour OIMMFDPCJIJ, JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, Action FJNHKBBJCJI, [Optional] MBGNMJJGJPO HONOIPDBDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4E772A0", Offset = "0x4E75AA0", VA = "0x184E772A0")]
	public static IIFKIJJEKEP IIPDNAKJGEI(this MonoBehaviour OIMMFDPCJIJ, float BENBCFENHNM, Action FJNHKBBJCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4E76CB0", Offset = "0x4E754B0", VA = "0x184E76CB0")]
	public static IIFKIJJEKEP BFEIGEFELNK(this MonoBehaviour OIMMFDPCJIJ, float BENBCFENHNM, Action FJNHKBBJCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4E77100", Offset = "0x4E75900", VA = "0x184E77100")]
	public static IIFKIJJEKEP ENBIPDFHCNL(this MonoBehaviour OIMMFDPCJIJ, float BENBCFENHNM, Action FJNHKBBJCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4E76FD0", Offset = "0x4E757D0", VA = "0x184E76FD0")]
	public static IIFKIJJEKEP DGFLPBMOKPC(this MonoBehaviour OIMMFDPCJIJ, float BENBCFENHNM, Action FJNHKBBJCJI)
	{
		return null;
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

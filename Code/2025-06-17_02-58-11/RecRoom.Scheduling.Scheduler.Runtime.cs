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
		[Cpp2IlInjected.Address(RVA = "0x88685D0", Offset = "0x8866FD0", VA = "0x1888685D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
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
		private delegate List<PlayerLoopSystem> BLNHNEPIAHI(List<PlayerLoopSystem> JDHPIJPMLGI, int BDHBLOEOIAK);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct KJPLOBLGOAO
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct ELHBFJCFLCB
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static CNBOOGKDGFE KJCGEJHAGJA;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x885C060", Offset = "0x885AA60", VA = "0x18885C060")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct LHEKIEIMGFD
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static CNBOOGKDGFE AGALKBFIBIF;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x88621B0", Offset = "0x8860BB0", VA = "0x1888621B0")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct BMEHICMBFMA
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static CNBOOGKDGFE GCFGJFEEIPO;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x8853450", Offset = "0x8851E50", VA = "0x188853450")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct LAHGEGDKGBF
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static CNBOOGKDGFE GAPENHHOEPC;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static CNBOOGKDGFE HFMIFLFCMIN;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static CNBOOGKDGFE OPCHFDGBJNN;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static CNBOOGKDGFE HIJEACENKAM;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x8861CC0", Offset = "0x88606C0", VA = "0x188861CC0")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct GCEECKOAFJM
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static CNBOOGKDGFE INMJOPAPJDO;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x885D6B0", Offset = "0x885C0B0", VA = "0x18885D6B0")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct PFCKOPFPOCC
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static CNBOOGKDGFE GAPENHHOEPC;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static CNBOOGKDGFE HFMIFLFCMIN;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static CNBOOGKDGFE OPCHFDGBJNN;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static CNBOOGKDGFE HIJEACENKAM;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x88670C0", Offset = "0x8865AC0", VA = "0x1888670C0")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct AIPMEPHBDFH
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static CNBOOGKDGFE KFJOOAIMGKF;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x8851ED0", Offset = "0x88508D0", VA = "0x188851ED0")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct NKLLEBHCDJL
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static CNBOOGKDGFE PDHOKAPBENB;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x8866770", Offset = "0x8865170", VA = "0x188866770")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct DHMIEKJPDEO
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static CNBOOGKDGFE DNDCAGCNOJI;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x8858020", Offset = "0x8856A20", VA = "0x188858020")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct DFFAMEBOAMI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static CNBOOGKDGFE IPCAFAMKPNE;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x8857D20", Offset = "0x8856720", VA = "0x188857D20")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct JFIIKNJCKLP
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static CNBOOGKDGFE HJKGDPPHLEO;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x8860CB0", Offset = "0x885F6B0", VA = "0x188860CB0")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct KEBJGPDCMIB
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static CNBOOGKDGFE LDAGLKCBOIA;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x88617C0", Offset = "0x88601C0", VA = "0x1888617C0")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct KOMEDIDILPM
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static CNBOOGKDGFE AGCMOALMEGI;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x8861AE0", Offset = "0x88604E0", VA = "0x188861AE0")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct LEJKFCOBNJN
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static CNBOOGKDGFE ALMEOBELOFL;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x8861FD0", Offset = "0x88609D0", VA = "0x188861FD0")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public struct AIBGNIOFBEN
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static CNBOOGKDGFE JBEEFIMNDJH;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x8851CF0", Offset = "0x88506F0", VA = "0x188851CF0")]
				public static PlayerLoopSystem LGBAEDKFPCL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public enum KJDDCKDBMMA : byte
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
			public struct MHFECEFANPF
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class CHHFPFBLNLL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public KJDDCKDBMMA updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
					public CHHFPFBLNLL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0x88536E0", Offset = "0x88520E0", VA = "0x1888536E0")]
					internal void MNEAFNEOFIA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static NBHKBEPCJOC<KJDDCKDBMMA> MGFNDIBCDIP;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x8863770", Offset = "0x8862170", VA = "0x188863770")]
				public static PlayerLoopSystem LGBAEDKFPCL(KJDDCKDBMMA ABJCJOIECLJ)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000027")]
			internal struct PHOPIEGHLMD
			{
				[Cpp2IlInjected.Token(Token = "0x2000028")]
				[CompilerGenerated]
				private sealed class AMIPELJNPIE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public OJAMGIOLLPA.DJCLOMGPBPD key;

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
					public AMIPELJNPIE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005E")]
					[Cpp2IlInjected.Address(RVA = "0x88527A0", Offset = "0x88511A0", VA = "0x1888527A0")]
					internal void BPDFIDMOOED()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable HFCEGLEJDGA;

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x8867390", Offset = "0x8865D90", VA = "0x188867390")]
				public static PlayerLoopSystem MHPPLAOIKGK(OJAMGIOLLPA.DJCLOMGPBPD KJNEHANBOBO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002A")]
			internal struct OHCMLFMDDNP
			{
				[Cpp2IlInjected.Token(Token = "0x200002B")]
				[CompilerGenerated]
				private sealed class NGKILKDLPGK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public OJAMGIOLLPA.DJCLOMGPBPD key;

					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
					public NGKILKDLPGK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x8864AA0", Offset = "0x88634A0", VA = "0x188864AA0")]
					internal void BPDFIDMOOED()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x8866950", Offset = "0x8865350", VA = "0x188866950")]
				public static PlayerLoopSystem MHPPLAOIKGK(OJAMGIOLLPA.DJCLOMGPBPD KJNEHANBOBO)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class PEPNBPGHKLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public PEPNBPGHKLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8866FA0", Offset = "0x88659A0", VA = "0x188866FA0")]
			internal List<PlayerLoopSystem> KJONBFLMMCF(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool DDPJBLOPMKO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool MBIKAPKLDBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8856AC0", Offset = "0x88554C0", VA = "0x188856AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8853AB0", Offset = "0x88524B0", VA = "0x188853AB0")]
		private static void DBOKKLONOMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8856EE0", Offset = "0x88558E0", VA = "0x188856EE0")]
		private static void ILPCPKHCIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8853A70", Offset = "0x8852470", VA = "0x188853A70")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8857920", Offset = "0x8856320", VA = "0x188857920")]
		private static void NIPGLDICPAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8857B60", Offset = "0x8856560", VA = "0x188857B60")]
		private static void NNEMIOCKMDN(OJAMGIOLLPA.DJCLOMGPBPD KJNEHANBOBO, PlayerLoopSystem MPMKCEAEKIN, Type PIFHCCMFMHD, Type HIPDJEHGOKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8856B00", Offset = "0x8855500", VA = "0x188856B00")]
		private static void HJLGNGJLLAN(PlayerLoopSystem MPMKCEAEKIN, Type PIFHCCMFMHD, Type HIPDJEHGOKH, BLNHNEPIAHI DOHMHLPMMIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88577F0", Offset = "0x88561F0", VA = "0x1888577F0")]
		private static void MMMFHMOCKBK(PlayerLoopSystem MPMKCEAEKIN, Type PIFHCCMFMHD, Type HIPDJEHGOKH, PlayerLoopSystem? GFKGBLILCLI, PlayerLoopSystem? BIKNADICMMH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class OJAMGIOLLPA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum DJCLOMGPBPD
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
	public class HIJLJJJKLIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly DJCLOMGPBPD OKCFDGJMLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly EOCHJOHDAGO HBOCAALLENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long DPEEHHDLCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long GHHLFKLKBOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long GNFABFJKMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int HKLDHBEBOFI;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x885FC70", Offset = "0x885E670", VA = "0x18885FC70")]
		public HIJLJJJKLIN(DJCLOMGPBPD JMABGPABECJ, int GACPLDHCANA = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x885FB20", Offset = "0x885E520", VA = "0x18885FB20")]
		public void GCEKJGCHDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x885FC20", Offset = "0x885E620", VA = "0x18885FC20")]
		public void JBJHNDCADMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x885FB40", Offset = "0x885E540", VA = "0x18885FB40")]
		public void ILONFGCCEAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static DJCLOMGPBPD[] MHBIEGJOOAB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static HIJLJJJKLIN[] NCAOLGCIKMC;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8866B90", Offset = "0x8865590", VA = "0x188866B90")]
	public static HIJLJJJKLIN KHFJNDGPACP(DJCLOMGPBPD KJNEHANBOBO, int GACPLDHCANA = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8866B20", Offset = "0x8865520", VA = "0x188866B20")]
	public static HIJLJJJKLIN JJEFNIFGLAK(DJCLOMGPBPD KJNEHANBOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8866A80", Offset = "0x8865480", VA = "0x188866A80")]
	public static void EBKKKMGEBKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class BBMABDAKNLP
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface HHGFBFKAOOK
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool CPLKLNMJIAE
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OJMNFFHOAPC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class FOMHKNHEPPC : HHGFBFKAOOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action KPGBPPBMJJK;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CPLKLNMJIAE
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
		public FOMHKNHEPPC(Action KPGBPPBMJJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x11DF5F0", Offset = "0x11DDFF0", VA = "0x1811DF5F0", Slot = "5")]
		public void OJMNFFHOAPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<HHGFBFKAOOK> OKOAMDEPJBO;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8853220", Offset = "0x8851C20", VA = "0x188853220")]
	public static void NMICENFNCGD(Action KPGBPPBMJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8852CC0", Offset = "0x88516C0", VA = "0x188852CC0")]
	private static void FHMMMKDNEAF(HHGFBFKAOOK NNGFIJCIBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8852F40", Offset = "0x8851940", VA = "0x188852F40")]
	private static void MLNPENDHCMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x88532C0", Offset = "0x8851CC0", VA = "0x1888532C0")]
	private static void PKJEAMBLHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8852BF0", Offset = "0x88515F0", VA = "0x188852BF0")]
	private static void ACGNHAEKAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class HIMHMBGHGJE
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x885FD00", Offset = "0x885E700", VA = "0x18885FD00")]
	public static IDisposable CEEKBKMOCDL(this DJGCAAKJKKI GJIMIGJJJKI, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x885FE10", Offset = "0x885E810", VA = "0x18885FE10")]
	public static IDisposable GHCDCEKCEOK(this DJGCAAKJKKI GJIMIGJJJKI, Action<float> OKMGMCHIGBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x885FD90", Offset = "0x885E790", VA = "0x18885FD90")]
	public static IDisposable DOIJDKGNCJL(this DJGCAAKJKKI GJIMIGJJJKI, Action<float> OKMGMCHIGBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DODBGFLLKKP
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x38D6730", Offset = "0x38D5130", VA = "0x1838D6730")]
	[OJCMDMODADC]
	public static IDisposable ILNBAEBONFH<T>(this T EPOEHDLAHPC, Action OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x38D68E0", Offset = "0x38D52E0", VA = "0x1838D68E0")]
	[OJCMDMODADC]
	public static IDisposable ILNBAEBONFH<T>(this T EPOEHDLAHPC, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x38D6640", Offset = "0x38D5040", VA = "0x1838D6640")]
	[OJCMDMODADC]
	public static IDisposable FPILOHDMIEH<T>(this T EPOEHDLAHPC, Action OKMGMCHIGBN, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x38D6DB0", Offset = "0x38D57B0", VA = "0x1838D6DB0")]
	[OJCMDMODADC]
	public static IDisposable OCMOLIOAACN<T>(this T EPOEHDLAHPC, Action OKMGMCHIGBN, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x38D6DB0", Offset = "0x38D57B0", VA = "0x1838D6DB0")]
	[OJCMDMODADC]
	public static IDisposable OCMOLIOAACN<T>(this T EPOEHDLAHPC, Action<float> OKMGMCHIGBN, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x38D6DE0", Offset = "0x38D57E0", VA = "0x1838D6DE0")]
	[OJCMDMODADC]
	public static IDisposable OCPAHICMOJJ<T>(this T EPOEHDLAHPC, Action OKMGMCHIGBN, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38D6E50", Offset = "0x38D5850", VA = "0x1838D6E50")]
	[OJCMDMODADC]
	public static IDisposable PPGOJCHEKDN<T>(this T EPOEHDLAHPC, Action OKMGMCHIGBN, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x38D6590", Offset = "0x38D4F90", VA = "0x1838D6590")]
	[OJCMDMODADC]
	public static IDisposable ACNKIBPNJML<T>(this T EPOEHDLAHPC, Action OKMGMCHIGBN, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x38D6E10", Offset = "0x38D5810", VA = "0x1838D6E10")]
	[OJCMDMODADC]
	public static IDisposable PGKFENGABFG<T>(this T EPOEHDLAHPC, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8858560", Offset = "0x8856F60", VA = "0x188858560")]
	[OJCMDMODADC]
	public static IDisposable PGKFENGABFG(this MonoBehaviour EPOEHDLAHPC, INBJDGLCFFF GJIMIGJJJKI, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x38D6A90", Offset = "0x38D5490", VA = "0x1838D6A90")]
	[OJCMDMODADC]
	public static IDisposable JBGLAAAEIIP<T>(this T EPOEHDLAHPC, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x38D6D30", Offset = "0x38D5730", VA = "0x1838D6D30")]
	[OJCMDMODADC]
	public static IDisposable MCDPBHGINAP<T>(this T EPOEHDLAHPC, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x38D6CB0", Offset = "0x38D56B0", VA = "0x1838D6CB0")]
	[OJCMDMODADC]
	public static IDisposable LEFPFADLJNL<T>(this T EPOEHDLAHPC, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x38D6C30", Offset = "0x38D5630", VA = "0x1838D6C30")]
	[OJCMDMODADC]
	public static IDisposable JDABPKNKOJK<T>(this T EPOEHDLAHPC, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x38D66F0", Offset = "0x38D50F0", VA = "0x1838D66F0")]
	[OJCMDMODADC]
	public static IDisposable IHPEGPKOODH<T>(this T EPOEHDLAHPC, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38D6600", Offset = "0x38D5000", VA = "0x1838D6600")]
	[OJCMDMODADC]
	public static IDisposable DNIOKNBJPCJ<T>(this T EPOEHDLAHPC, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x38D65C0", Offset = "0x38D4FC0", VA = "0x1838D65C0")]
	[OJCMDMODADC]
	public static IDisposable ANDEILHILKP<T>(this T EPOEHDLAHPC, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x38D6C70", Offset = "0x38D5670", VA = "0x1838D6C70")]
	[OJCMDMODADC]
	public static IDisposable JKEGPDOHKFE<T>(this T EPOEHDLAHPC, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x38D6D70", Offset = "0x38D5770", VA = "0x1838D6D70")]
	[OJCMDMODADC]
	public static IDisposable MKEPHNLJFDJ<T>(this T EPOEHDLAHPC, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x38D66B0", Offset = "0x38D50B0", VA = "0x1838D66B0")]
	[OJCMDMODADC]
	public static IDisposable IEMFELDLMFN<T>(this T EPOEHDLAHPC, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x38D6CF0", Offset = "0x38D56F0", VA = "0x1838D6CF0")]
	[OJCMDMODADC]
	public static IDisposable LGMDMNEDODE<T>(this T EPOEHDLAHPC, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x38D6670", Offset = "0x38D5070", VA = "0x1838D6670")]
	[OJCMDMODADC]
	public static IDisposable HDBJJGFBMFC<T>(this T EPOEHDLAHPC, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true) where T : MonoBehaviour, INBJDGLCFFF
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class CIFFBNLBDOM
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class OJGMBNOAGGC : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public DGLKCECAJOP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private PNHMCPOGNBF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public OJGMBNOAGGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8866E70", Offset = "0x8865870", VA = "0x188866E70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8866F50", Offset = "0x8865950", VA = "0x188866F50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class KKHJLCLNBKO : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public DGLKCECAJOP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private PNHMCPOGNBF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public KKHJLCLNBKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x88619A0", Offset = "0x88603A0", VA = "0x1888619A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8861A90", Offset = "0x8860490", VA = "0x188861A90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x88538D0", Offset = "0x88522D0", VA = "0x1888538D0")]
	public static IDJIHHOMEIC ILNBAEBONFH(Action OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8853840", Offset = "0x8852240", VA = "0x188853840")]
	public static IDJIHHOMEIC ILNBAEBONFH(Behaviour GJIMIGJJJKI, Action OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8853760", Offset = "0x8852160", VA = "0x188853760")]
	public static IDJIHHOMEIC ILNBAEBONFH(Behaviour GJIMIGJJJKI, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x88539E0", Offset = "0x88523E0", VA = "0x1888539E0")]
	[IteratorStateMachine(typeof(OJGMBNOAGGC))]
	private static IEnumerator<HGOIDBIKHMF> LKENIFOBEAB(DGLKCECAJOP IHEHIKLMINL, Action OKMGMCHIGBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8853950", Offset = "0x8852350", VA = "0x188853950")]
	[IteratorStateMachine(typeof(KKHJLCLNBKO))]
	private static IEnumerator<HGOIDBIKHMF> LKENIFOBEAB(DGLKCECAJOP IHEHIKLMINL, Action<float> OKMGMCHIGBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class DIBMCDMABFO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class HNKDDIABJFD : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public DIBMCDMABFO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public HNKDDIABJFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8860530", Offset = "0x885EF30", VA = "0x188860530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x88605C0", Offset = "0x885EFC0", VA = "0x1888605C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly DGLKCECAJOP IDHNKODCLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Action IPPNMBLNJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool CKKDNCKCDJO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CMMJBHMPAEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA10D70", Offset = "0xA0F770", VA = "0x180A10D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8858320", Offset = "0x8856D20", VA = "0x188858320")]
	public DIBMCDMABFO(DGLKCECAJOP IDHNKODCLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x88582A0", Offset = "0x8856CA0", VA = "0x1888582A0")]
	[IteratorStateMachine(typeof(HNKDDIABJFD))]
	private IEnumerator<HGOIDBIKHMF> PBJNLLIJPKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8858200", Offset = "0x8856C00", VA = "0x188858200", Slot = "4")]
	public void OnCompleted(Action KHHCHOOINCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	public void JMNIGMOFGEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BBEOKNOAHJJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8852AE0", Offset = "0x88514E0", VA = "0x188852AE0")]
	public static DIBMCDMABFO KGCPCIIMFBP(this DGLKCECAJOP IDHNKODCLDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GEODEPALNMD
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class IECHNDEGOLM : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CFIIJDBFODL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public IECHNDEGOLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8860610", Offset = "0x885F010", VA = "0x188860610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8860690", Offset = "0x885F090", VA = "0x188860690", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x885DC70", Offset = "0x885C670", VA = "0x18885DC70")]
	public static IDJIHHOMEIC ILNBAEBONFH(float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, bool HHHDJHHANOA = true, [Optional] CJCKCFOBOPF DBBKPFGHGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x885DD40", Offset = "0x885C740", VA = "0x18885DD40")]
	public static IDJIHHOMEIC ILNBAEBONFH(MonoBehaviour EPOEHDLAHPC, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, bool HHHDJHHANOA = true, [Optional] CJCKCFOBOPF DBBKPFGHGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x885E030", Offset = "0x885CA30", VA = "0x18885E030")]
	public static IDJIHHOMEIC PKNPLPMNFFI(MonoBehaviour EPOEHDLAHPC, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, bool HHHDJHHANOA = true, [Optional] CJCKCFOBOPF DBBKPFGHGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x885DF60", Offset = "0x885C960", VA = "0x18885DF60")]
	public static IDJIHHOMEIC MFBLHLJJHEI(DJGCAAKJKKI GJIMIGJJJKI, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, bool HHHDJHHANOA = true, [Optional] CJCKCFOBOPF DBBKPFGHGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x885DEA0", Offset = "0x885C8A0", VA = "0x18885DEA0")]
	private static IEnumerator<HGOIDBIKHMF> LKENIFOBEAB(BGIAJOAAIGN KMOEPMLKBNF, float AJIPHAIIOLB, DGLKCECAJOP IHEHIKLMINL, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x885DC10", Offset = "0x885C610", VA = "0x18885DC10")]
	private static IEnumerator<HGOIDBIKHMF> CKFDHKHGPEN(BGIAJOAAIGN KMOEPMLKBNF, float AJIPHAIIOLB, DGLKCECAJOP IHEHIKLMINL, Action<float> OKMGMCHIGBN, bool HHHDJHHANOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x885DE10", Offset = "0x885C810", VA = "0x18885DE10")]
	[IteratorStateMachine(typeof(IECHNDEGOLM))]
	private static IEnumerator<HGOIDBIKHMF> KCDMFOGAGAI(CFIIJDBFODL NFACOKOOAHK, float AJIPHAIIOLB, DGLKCECAJOP IHEHIKLMINL, Action<float> OKMGMCHIGBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DMJPENFHHGF
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class INNOBKMLCNG : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DGLKCECAJOP queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public INNOBKMLCNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8860B60", Offset = "0x885F560", VA = "0x188860B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8860C20", Offset = "0x885F620", VA = "0x188860C20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x88584D0", Offset = "0x8856ED0", VA = "0x1888584D0")]
	[IteratorStateMachine(typeof(INNOBKMLCNG))]
	private static IEnumerator<HGOIDBIKHMF> PMGOAEFIFOO(DGLKCECAJOP IDHNKODCLDE, Func<bool> APOGDCILJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x88583F0", Offset = "0x8856DF0", VA = "0x1888583F0")]
	public static IDJIHHOMEIC EHMMOBEJACK(this MonoBehaviour EPOEHDLAHPC, Func<bool> APOGDCILJPL, DGLKCECAJOP IDHNKODCLDE = DGLKCECAJOP.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class DOOPLJPMHMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BBEFOJIKPDK : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public DGLKCECAJOP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public BBEFOJIKPDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8852A20", Offset = "0x8851420", VA = "0x188852A20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8852A90", Offset = "0x8851490", VA = "0x188852A90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class KFNCENMOGGD<T> : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public DGLKCECAJOP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public KFNCENMOGGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x51BD6D0", Offset = "0x51BC0D0", VA = "0x1851BD6D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x51BD750", Offset = "0x51BC150", VA = "0x1851BD750", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class DGMOGPKNJOG : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public DGLKCECAJOP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private HGOIDBIKHMF <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public DGMOGPKNJOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8857F00", Offset = "0x8856900", VA = "0x188857F00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8857F90", Offset = "0x8856990", VA = "0x188857F90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8858FD0", Offset = "0x88579D0", VA = "0x188858FD0")]
	[IteratorStateMachine(typeof(BBEFOJIKPDK))]
	private static IEnumerator<HGOIDBIKHMF> PBJNLLIJPKF(float CAJJAMECEFA, DGLKCECAJOP IHEHIKLMINL, Action IDNDDAFIIDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x38D7030", Offset = "0x38D5A30", VA = "0x1838D7030")]
	[IteratorStateMachine(typeof(KFNCENMOGGD<>))]
	private static IEnumerator<HGOIDBIKHMF> PBJNLLIJPKF<T>(float CAJJAMECEFA, DGLKCECAJOP IHEHIKLMINL, Action<T> IDNDDAFIIDI, T EFPDHJCEEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8859070", Offset = "0x8857A70", VA = "0x188859070")]
	[IteratorStateMachine(typeof(DGMOGPKNJOG))]
	private static IEnumerator<HGOIDBIKHMF> PDMEOLFFLIL(float CAJJAMECEFA, DGLKCECAJOP IHEHIKLMINL, Action IDNDDAFIIDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8858BE0", Offset = "0x88575E0", VA = "0x188858BE0")]
	public static IDisposable GHCCMDOGJOB(this MonoBehaviour EPOEHDLAHPC, float CAJJAMECEFA, Action IDNDDAFIIDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8858E00", Offset = "0x8857800", VA = "0x188858E00")]
	public static IDJIHHOMEIC MBCFOLGHBEM(this MonoBehaviour EPOEHDLAHPC, float CAJJAMECEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8858AF0", Offset = "0x88574F0", VA = "0x188858AF0")]
	public static IDJIHHOMEIC GHCCMDOGJOB(this MonoBehaviour EPOEHDLAHPC, float CAJJAMECEFA, DGLKCECAJOP IHEHIKLMINL, Action IDNDDAFIIDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8858910", Offset = "0x8857310", VA = "0x188858910")]
	public static IDJIHHOMEIC EOONCKNCAIB(this MonoBehaviour EPOEHDLAHPC, Action IDNDDAFIIDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x38D6EE0", Offset = "0x38D58E0", VA = "0x1838D6EE0")]
	public static IDJIHHOMEIC EOONCKNCAIB<T>(this MonoBehaviour EPOEHDLAHPC, Action<T> IDNDDAFIIDI, T EFPDHJCEEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8858A50", Offset = "0x8857450", VA = "0x188858A50")]
	public static IDJIHHOMEIC FHLKIMHDICI(this MonoBehaviour EPOEHDLAHPC, Action IDNDDAFIIDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8858E90", Offset = "0x8857890", VA = "0x188858E90")]
	public static IDJIHHOMEIC MMHCICNPCHP(this MonoBehaviour EPOEHDLAHPC, Action IDNDDAFIIDI, [Optional] CJCKCFOBOPF DBBKPFGHGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8858870", Offset = "0x8857270", VA = "0x188858870")]
	public static IDJIHHOMEIC EINJEIEJKOO(this MonoBehaviour EPOEHDLAHPC, Action IDNDDAFIIDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x88589B0", Offset = "0x88573B0", VA = "0x1888589B0")]
	public static IDJIHHOMEIC FFIIJFGBDDM(this MonoBehaviour EPOEHDLAHPC, Action IDNDDAFIIDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8858F30", Offset = "0x8857930", VA = "0x188858F30")]
	public static IDJIHHOMEIC MOBOPCCDFIN(MonoBehaviour EPOEHDLAHPC, DGLKCECAJOP IDHNKODCLDE, Action IDNDDAFIIDI, [Optional] CJCKCFOBOPF DBBKPFGHGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x38D6F10", Offset = "0x38D5910", VA = "0x1838D6F10")]
	public static IDJIHHOMEIC MOBOPCCDFIN<T>(MonoBehaviour EPOEHDLAHPC, DGLKCECAJOP IDHNKODCLDE, Action<T> IDNDDAFIIDI, T EFPDHJCEEGP, [Optional] CJCKCFOBOPF DBBKPFGHGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8858740", Offset = "0x8857140", VA = "0x188858740")]
	public static IDJIHHOMEIC BILDNHAJBED(this MonoBehaviour EPOEHDLAHPC, float DFMAFIKPLEF, Action IDNDDAFIIDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8858CC0", Offset = "0x88576C0", VA = "0x188858CC0")]
	public static IDJIHHOMEIC HAJEFCKEPBH(this MonoBehaviour EPOEHDLAHPC, float DFMAFIKPLEF, Action IDNDDAFIIDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8858D60", Offset = "0x8857760", VA = "0x188858D60")]
	public static IDJIHHOMEIC JGEEHBPMEFF(this MonoBehaviour EPOEHDLAHPC, float DFMAFIKPLEF, Action IDNDDAFIIDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x88587D0", Offset = "0x88571D0", VA = "0x1888587D0")]
	public static IDJIHHOMEIC BNJIIDGPBDJ(this MonoBehaviour EPOEHDLAHPC, float DFMAFIKPLEF, Action IDNDDAFIIDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class GHMNHAHGNJL : CKMOJMBJJND, IEnumerable<CKMOJMBJJND>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<CKMOJMBJJND> MCCBBDDGHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool LDMPIIBHHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Action CIEIMHHMEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool IAIMGOJMGJB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MLONFAFGDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x885E120", Offset = "0x885CB20", VA = "0x18885E120", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action GFNHBIJAEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x885E960", Offset = "0x885D360", VA = "0x18885E960", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x885E730", Offset = "0x885D130", VA = "0x18885E730", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x885EA00", Offset = "0x885D400", VA = "0x18885EA00")]
	public GHMNHAHGNJL([Optional] Action CIEIMHHMEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x885E7D0", Offset = "0x885D1D0", VA = "0x18885E7D0")]
	public void PBDMKLNODMP(CKMOJMBJJND GIGMNPKOIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x885E250", Offset = "0x885CC50", VA = "0x18885E250")]
	private void FCBHKCIMMMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x885E720", Offset = "0x885D120", VA = "0x18885E720", Slot = "7")]
	public bool JLNKGAIBAFP(bool BOOINJJDCOC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x885E420", Offset = "0x885CE20", VA = "0x18885E420", Slot = "8")]
	public bool JLNKGAIBAFP(Action KPGBPPBMJJK, bool BOOINJJDCOC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x885E3A0", Offset = "0x885CDA0", VA = "0x18885E3A0", Slot = "9")]
	public IEnumerator<CKMOJMBJJND> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x885E3A0", Offset = "0x885CDA0", VA = "0x18885E3A0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class EOEPOMDJBHD : AJMNFCJLKFP
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class IHKIIGAOPLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EOEPOMDJBHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public IHKIIGAOPLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8860B30", Offset = "0x885F530", VA = "0x188860B30")]
		internal void KCIJKJBEKAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class PICBCBCAAGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public EOEPOMDJBHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public PICBCBCAAGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8860B30", Offset = "0x885F530", VA = "0x188860B30")]
		internal void NFHFLDFJBPI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly float JLOLLAAELDL;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x885C460", Offset = "0x885AE60", VA = "0x18885C460")]
	public EOEPOMDJBHD(Behaviour GJIMIGJJJKI, float JLOLLAAELDL, [Optional] Action CIEIMHHMEPN, [Optional] CJCKCFOBOPF DBBKPFGHGAF, [Optional] BGIAJOAAIGN KMOEPMLKBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x885C240", Offset = "0x885AC40", VA = "0x18885C240", Slot = "9")]
	protected override bool FDCHAKCJKEH(Action KPGBPPBMJJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x885C350", Offset = "0x885AD50", VA = "0x18885C350", Slot = "10")]
	protected override bool JLDMMEMCAPI(Action KPGBPPBMJJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface CKMOJMBJJND
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MLONFAFGDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GFNHBIJAEEJ;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JLNKGAIBAFP(bool BOOINJJDCOC = false);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JLNKGAIBAFP(Action KPGBPPBMJJK, bool BOOINJJDCOC = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class AJMNFCJLKFP : CKMOJMBJJND
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class FBKPIJGBABM : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AJMNFCJLKFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public FBKPIJGBABM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x885CB30", Offset = "0x885B530", VA = "0x18885CB30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x885CC00", Offset = "0x885B600", VA = "0x18885CC00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Behaviour GJIMIGJJJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action CIEIMHHMEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private LIJLGGILNGM KKGGEJOCAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly CJCKCFOBOPF DBBKPFGHGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	protected readonly BGIAJOAAIGN KMOEPMLKBNF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MLONFAFGDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1B9BF40", Offset = "0x1B9A940", VA = "0x181B9BF40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GFNHBIJAEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x88525D0", Offset = "0x8850FD0", VA = "0x1888525D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x88524D0", Offset = "0x8850ED0", VA = "0x1888524D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8852670", Offset = "0x8851070", VA = "0x188852670")]
	protected AJMNFCJLKFP(Behaviour GJIMIGJJJKI, [Optional] Action CIEIMHHMEPN, [Optional] CJCKCFOBOPF DBBKPFGHGAF, [Optional] BGIAJOAAIGN KMOEPMLKBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8852470", Offset = "0x8850E70", VA = "0x188852470", Slot = "7")]
	public bool JLNKGAIBAFP(bool BOOINJJDCOC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8852410", Offset = "0x8850E10", VA = "0x188852410", Slot = "8")]
	public bool JLNKGAIBAFP(Action KPGBPPBMJJK, bool BOOINJJDCOC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool FDCHAKCJKEH(Action KPGBPPBMJJK);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool JLDMMEMCAPI(Action KPGBPPBMJJK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x88525B0", Offset = "0x8850FB0", VA = "0x1888525B0")]
	protected void OJMIHONCMNM(Action KPGBPPBMJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x88520B0", Offset = "0x8850AB0", VA = "0x1888520B0")]
	protected FDBBAHKKNBB AGHKDMJHLKI(float IDDLOIFGNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8852390", Offset = "0x8850D90", VA = "0x188852390")]
	private void FKIHCMKFENH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8852300", Offset = "0x8850D00", VA = "0x188852300")]
	[IteratorStateMachine(typeof(FBKPIJGBABM))]
	private IEnumerator<HGOIDBIKHMF> DGHNGJJOLBI(float IDDLOIFGNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8852570", Offset = "0x8850F70", VA = "0x188852570")]
	[CompilerGenerated]
	private void OHBCBEOHFPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class IFHKEBDDAOE : AJMNFCJLKFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly float EFAFEGGJOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly int PEBLHIOBPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly float EKJDMHALMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly float[] NKIHFHIIAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int JOFPHJAHHCN;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8860960", Offset = "0x885F360", VA = "0x188860960")]
	public IFHKEBDDAOE(Behaviour GJIMIGJJJKI, float PDIOLJNFJAM, int PEBLHIOBPBC, [Optional] Action CIEIMHHMEPN, float EKJDMHALMJI = 0f, [Optional] CJCKCFOBOPF DBBKPFGHGAF, [Optional] BGIAJOAAIGN KMOEPMLKBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "9")]
	protected override bool FDCHAKCJKEH(Action KPGBPPBMJJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x88606E0", Offset = "0x885F0E0", VA = "0x1888606E0", Slot = "10")]
	protected override bool JLDMMEMCAPI(Action KPGBPPBMJJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x88608E0", Offset = "0x885F2E0", VA = "0x1888608E0")]
	private void ODDDEOMKLAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class JBDCBILLPID : AJMNFCJLKFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly float JLOLLAAELDL;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x885C460", Offset = "0x885AE60", VA = "0x18885C460")]
	public JBDCBILLPID(Behaviour GJIMIGJJJKI, float JLOLLAAELDL, [Optional] Action CIEIMHHMEPN, [Optional] CJCKCFOBOPF DBBKPFGHGAF, [Optional] BGIAJOAAIGN KMOEPMLKBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "9")]
	protected override bool FDCHAKCJKEH(Action KPGBPPBMJJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8860C70", Offset = "0x885F670", VA = "0x188860C70", Slot = "10")]
	protected override bool JLDMMEMCAPI(Action KPGBPPBMJJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class HKBGAEMCDCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class FAHLABLDEOK : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public FAHLABLDEOK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x885C5A0", Offset = "0x885AFA0", VA = "0x18885C5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x885C610", Offset = "0x885B010", VA = "0x18885C610", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private IDJIHHOMEIC JIPMPONPAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private DJGCAAKJKKI GJIMIGJJJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Action<float> JHNLAOAONJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private DGLKCECAJOP IDHNKODCLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private float GMNLINCDAGF;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8860390", Offset = "0x885ED90", VA = "0x188860390")]
	public HKBGAEMCDCH(DJGCAAKJKKI GJIMIGJJJKI, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8860220", Offset = "0x885EC20", VA = "0x188860220")]
	private void IPGNGGNDOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8860090", Offset = "0x885EA90", VA = "0x188860090")]
	private void BEEBDLILBEM(string OLIGKIPGKGK, Action HPLHAFMHDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8860010", Offset = "0x885EA10", VA = "0x188860010")]
	[IteratorStateMachine(typeof(FAHLABLDEOK))]
	private IEnumerator<HGOIDBIKHMF> APNOGNOKKFN(Action HPLHAFMHDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x88601C0", Offset = "0x885EBC0", VA = "0x1888601C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x885FE90", Offset = "0x885E890", VA = "0x18885FE90")]
	[CompilerGenerated]
	private void ADIJBNLDMJC(string AJLHKIHCGAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class MPCCLJBLPLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class FJKGIJEKCMO : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public FJKGIJEKCMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x885C5A0", Offset = "0x885AFA0", VA = "0x18885C5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x885D660", Offset = "0x885C060", VA = "0x18885D660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private IDJIHHOMEIC JIPMPONPAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private MonoBehaviour EPOEHDLAHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Action OKMGMCHIGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Action<float> JHNLAOAONJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private DGLKCECAJOP IDHNKODCLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float GMNLINCDAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool HHHDJHHANOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly CJCKCFOBOPF DBBKPFGHGAF;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8864560", Offset = "0x8862F60", VA = "0x188864560")]
	public MPCCLJBLPLI(MonoBehaviour EPOEHDLAHPC, Action OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, [Optional] CJCKCFOBOPF DBBKPFGHGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x88648D0", Offset = "0x88632D0", VA = "0x1888648D0")]
	public MPCCLJBLPLI(MonoBehaviour EPOEHDLAHPC, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, [Optional] CJCKCFOBOPF DBBKPFGHGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x88646F0", Offset = "0x88630F0", VA = "0x1888646F0")]
	public MPCCLJBLPLI(MonoBehaviour EPOEHDLAHPC, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, bool HHHDJHHANOA = true, [Optional] CJCKCFOBOPF DBBKPFGHGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4D3F050", Offset = "0x4D3DA50", VA = "0x184D3F050")]
	private MPCCLJBLPLI(CJCKCFOBOPF DBBKPFGHGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x8864090", Offset = "0x8862A90", VA = "0x188864090")]
	internal static MPCCLJBLPLI LIAIHPFJBJG(MonoBehaviour EPOEHDLAHPC, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, DGLKCECAJOP IDHNKODCLDE, bool HHHDJHHANOA = true, [Optional] CJCKCFOBOPF DBBKPFGHGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x8863DF0", Offset = "0x88627F0", VA = "0x188863DF0")]
	private void ILNBAEBONFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x8864350", Offset = "0x8862D50", VA = "0x188864350")]
	private void PAFLBBHFBDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x8863F20", Offset = "0x8862920", VA = "0x188863F20")]
	private void IPGNGGNDOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8863B40", Offset = "0x8862540", VA = "0x188863B40")]
	private void EBEGHJDFOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x88639B0", Offset = "0x88623B0", VA = "0x1888639B0")]
	private void BEEBDLILBEM(string OLIGKIPGKGK, Action HPLHAFMHDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8863930", Offset = "0x8862330", VA = "0x188863930")]
	[IteratorStateMachine(typeof(FJKGIJEKCMO))]
	private IEnumerator<HGOIDBIKHMF> APNOGNOKKFN(Action HPLHAFMHDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8863AE0", Offset = "0x88624E0", VA = "0x188863AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x88642C0", Offset = "0x8862CC0", VA = "0x1888642C0")]
	[CompilerGenerated]
	private void MMCHMCBFCMO(string AJLHKIHCGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8863CD0", Offset = "0x88626D0", VA = "0x188863CD0")]
	[CompilerGenerated]
	private void GHFBJHICECL(string AJLHKIHCGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x88644D0", Offset = "0x8862ED0", VA = "0x1888644D0")]
	[CompilerGenerated]
	private void POMDDAMDODK(string AJLHKIHCGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8863D60", Offset = "0x8862760", VA = "0x188863D60")]
	[CompilerGenerated]
	private void GPANJOMGJCI(string AJLHKIHCGAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum FIKJLGCGLJG : byte
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
internal sealed class BPKIJCBAPHG : BGIAJOAAIGN
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float MPFAODOCFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x88536D0", Offset = "0x88520D0", VA = "0x1888536D0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float HFGJAPCEAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x88536C0", Offset = "0x88520C0", VA = "0x1888536C0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public double BMINAKCPCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8853630", Offset = "0x8852030", VA = "0x188853630", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8853650", Offset = "0x8852050", VA = "0x188853650")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	internal static void FEDJMCICCOK(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	[UnityEngine.Scripting.Preserve]
	internal BPKIJCBAPHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface KGOCNDKJHKH
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEFLCJEEGFN(string GBCFHNGPBLM);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJLBEOJCALP();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface DEPOGGDPGAD
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string HMKINKIIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool GPPPGPEDKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool ADHBCGMAABM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class FALKPPCCAKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public EHBAMNNNBOI KMGBOCDANAK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int FOIACCDFCND
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA155F0", Offset = "0xA13FF0", VA = "0x180A155F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x885C750", Offset = "0x885B150", VA = "0x18885C750")]
	public static HGOIDBIKHMF IEEMGEAFJJB(IEnumerator<HGOIDBIKHMF> HNOPKGKMPEC, JGHOHOMLENF GNNONNJKBFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x885C690", Offset = "0x885B090", VA = "0x18885C690")]
	public HGOIDBIKHMF IEEMGEAFJJB(JGHOHOMLENF[] IMHIGELHBIL, IEnumerator<HGOIDBIKHMF>[] OFGODKHGPMI, HGOIDBIKHMF[] OOIONEIIBLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x885C660", Offset = "0x885B060", VA = "0x18885C660")]
	public void IBFFDJGINKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x885C9F0", Offset = "0x885B3F0", VA = "0x18885C9F0")]
	public void LELOJHPKFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x885C8B0", Offset = "0x885B2B0", VA = "0x18885C8B0")]
	public void JDJIAFALAJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x885C660", Offset = "0x885B060", VA = "0x18885C660")]
	public void JCMHGMGGFCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public FALKPPCCAKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class EHBAMNNNBOI
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct KHNALIPDGDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public FALKPPCCAKE BHLKJLPOEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public DJGCAAKJKKI FFHCJDNPLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public JGHOHOMLENF GKJBNMKJGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public IEnumerator<HGOIDBIKHMF> KPLOGIHMEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public HGOIDBIKHMF NDPBNHBCGIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public FIKJLGCGLJG NBBONEPKIOH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct HICAANACDKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public DGLKCECAJOP DFDBOBINFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public List<KHNALIPDGDL> JOANBECBDFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class FGKOBLNICAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public JGHOHOMLENF promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public EHBAMNNNBOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public DJGCAAKJKKI context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public FALKPPCCAKE routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public FIKJLGCGLJG coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public HGOIDBIKHMF currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public IEnumerator<HGOIDBIKHMF> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FGKOBLNICAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x885CD50", Offset = "0x885B750", VA = "0x18885CD50")]
		internal void OKECNBIABKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class DHBGGDIADCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public FALKPPCCAKE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public EHBAMNNNBOI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public DHBGGDIADCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8857FE0", Offset = "0x88569E0", VA = "0x188857FE0")]
		internal void FDMNLPBPBAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class FIPOLIBMOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public FALKPPCCAKE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public EHBAMNNNBOI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FIPOLIBMOBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x885D530", Offset = "0x885BF30", VA = "0x18885D530")]
		internal void CLCKFOBAPNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class LBDFENJCIBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public FALKPPCCAKE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public EHBAMNNNBOI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public LBDFENJCIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8861F90", Offset = "0x8860990", VA = "0x188861F90")]
		internal void PBIOCPNIANB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private const FIKJLGCGLJG LEHKFDJIIMP = FIKJLGCGLJG.Cancelled | FIKJLGCGLJG.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly DGLKCECAJOP IDHNKODCLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool[] JAKBBIKKJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private NativeArray<FIKJLGCGLJG> EHDFEALLNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NativeArray<float> DLNKEGKNHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private NativeArray<int> GFONHCALMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private NativeArray<int> DAPPIBNDHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private NativeArray<int> DIIICKJFIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NativeArray<int> JFODBDBJPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private NativeArray<int> NOHDINMMMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private FALKPPCCAKE[] AEOMAKGGHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private JGHOHOMLENF[] IMHIGELHBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private DJGCAAKJKKI[] FFPELFJHJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private IEnumerator<HGOIDBIKHMF>[] GFPCABDJIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private HGOIDBIKHMF[] HKLHBOGDOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int JOLEJJHDDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int OOPBDBFKCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly int MJKAOEIBCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private float GKANMOKCMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private EGFLJDGMIHG HGNIFGLPLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private JobHandle IMACEFDMOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private List<FALKPPCCAKE> MNMGGEFJLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool DDBLFGNPDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private List<Action> BOAIOLKHNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> INBGNJKACDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool MBBJKNNMILI;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public HICAANACDKG[] BKIHLDODLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xB32630", Offset = "0xB31030", VA = "0x180B32630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x885ABA0", Offset = "0x88595A0", VA = "0x18885ABA0")]
	private static int JDOBJAHCKLN(DGLKCECAJOP IDHNKODCLDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x885BA00", Offset = "0x885A400", VA = "0x18885BA00")]
	public EHBAMNNNBOI(DGLKCECAJOP IDHNKODCLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8859D10", Offset = "0x8858710", VA = "0x188859D10")]
	private void DKBGELEABEF(int GPLBNIMGAJI, int IJGMOIHJEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x885ABD0", Offset = "0x88595D0", VA = "0x18885ABD0")]
	public void LAFBBJCLBHP(DJGCAAKJKKI GJIMIGJJJKI, HGOIDBIKHMF OJODKEBDKHB, IEnumerator<HGOIDBIKHMF> HNOPKGKMPEC, JGHOHOMLENF GNNONNJKBFK, [Optional] FALKPPCCAKE AKIJOPGCODN, FIKJLGCGLJG NKOJBFJBPPO = FIKJLGCGLJG.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x885AD50", Offset = "0x8859750", VA = "0x18885AD50")]
	public void NLEEAEJAGIN(IEnumerable<KHNALIPDGDL> OJOIDDICHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x885B330", Offset = "0x8859D30", VA = "0x18885B330")]
	private KHNALIPDGDL PLOAMFKILLO(int DHDGKJKIAGM)
	{
		return default(KHNALIPDGDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x88599A0", Offset = "0x88583A0", VA = "0x1888599A0")]
	private void BKHNPBGENMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x38F8510", Offset = "0x38F6F10", VA = "0x1838F8510")]
	private static void KJCKDLIAPPN<T>(int DHDGKJKIAGM, T[] DPEBCEIHBPK, int OPKPFANIILK, [Optional] T FLFFNEFAOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x38F8560", Offset = "0x38F6F60", VA = "0x1838F8560")]
	private static void KJCKDLIAPPN<T>(int DHDGKJKIAGM, NativeArray<T> DPEBCEIHBPK, int OPKPFANIILK, [Optional] T FLFFNEFAOEE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x885AF90", Offset = "0x8859990", VA = "0x18885AF90")]
	private void OCGEKMHGOFF(IEnumerable<KHNALIPDGDL> OJOIDDICHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x88597A0", Offset = "0x88581A0", VA = "0x1888597A0")]
	private void AMMDBFGJCIB(KHNALIPDGDL GADHACDFNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x885A690", Offset = "0x8859090", VA = "0x18885A690")]
	private OBAAMHFNNHN FHLBFPGEDED(int IJLDOBDMGDI)
	{
		return default(OBAAMHFNNHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x885B800", Offset = "0x885A200", VA = "0x18885B800")]
	public void PPHPLFNAPAO(float HAGDKDAABGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x885A8F0", Offset = "0x88592F0", VA = "0x18885A8F0")]
	private void HAMKONFHFAB(Action MJGADEGDMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8859EF0", Offset = "0x88588F0", VA = "0x188859EF0")]
	private void EAKJJCIKGLJ(Action MJGADEGDMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8859F70", Offset = "0x8858970", VA = "0x188859F70")]
	public void FCMKANDMNFK(float HAGDKDAABGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x885A970", Offset = "0x8859370", VA = "0x18885A970")]
	public void IIPIKJHBJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x885AA70", Offset = "0x8859470", VA = "0x18885AA70")]
	public void JCMHGMGGFCA(FALKPPCCAKE NFACOKOOAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8859870", Offset = "0x8858270", VA = "0x188859870")]
	public void BAHJOODPIJB(FALKPPCCAKE NFACOKOOAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8859670", Offset = "0x8858070", VA = "0x188859670")]
	public void AKDBPIAJGEF(FALKPPCCAKE NFACOKOOAHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class FEAKBLAPJNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly FEAKBLAPJNJ BOAAIAHJNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly Action KJODHAENABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private bool CDPHAALIFLC;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public FEAKBLAPJNJ(Action KJODHAENABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE690", Offset = "0x7EAD090", VA = "0x187EAE690", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface LAIDEMCMKGN<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable GGMHECDHMDB(UnityEngine.Object GJIMIGJJJKI, Action<T> OPDHOJMPKOG);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface EEDKAEIINMP<T> : LAIDEMCMKGN<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	new T AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class IKNEELJFDNF<T> : EEDKAEIINMP<T>, LAIDEMCMKGN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class NGMMFJMCBIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public IKNEELJFDNF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public PCDLKLMNBFN<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NGMMFJMCBIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x55044B0", Offset = "0x5502EB0", VA = "0x1855044B0")]
		internal void CCIMDBNOIAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static GameObject EPKEIIJMIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly List<PCDLKLMNBFN<UnityEngine.Object, Action<T>>> KMOFAEKENGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private T MPMCEIDDGOF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA62AE0", Offset = "0xA614E0", VA = "0x180A62AE0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4E611F0", Offset = "0x4E5FBF0", VA = "0x184E611F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4E61130", Offset = "0x4E5FB30", VA = "0x184E61130")]
	private static bool LFPKBBIAEDJ(T MJGADEGDMOP, T LJDEEJKPAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4E612E0", Offset = "0x4E5FCE0", VA = "0x184E612E0")]
	public IKNEELJFDNF(T DLCCFGMOGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4E60F80", Offset = "0x4E5F980", VA = "0x184E60F80", Slot = "6")]
	public IDisposable GGMHECDHMDB(UnityEngine.Object GJIMIGJJJKI, Action<T> OPDHOJMPKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4E60820", Offset = "0x4E5F220", VA = "0x184E60820")]
	private void FGMLAINJBLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class GMPPOBNHAGP : PPHNMLPMELJ
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private class HHGAMMAIPLL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		private class ACJBFIGPPAH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private int KHNIMGKFPOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private HHGAMMAIPLL IHEHIKLMINL;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xF4B4D0", Offset = "0xF49ED0", VA = "0x180F4B4D0")]
			public ACJBFIGPPAH(int KHNIMGKFPOO, HHGAMMAIPLL IHEHIKLMINL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8850870", Offset = "0x884F270", VA = "0x188850870", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class DGAOBEDJDME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public DGAOBEDJDME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA9A640", Offset = "0xA99040", VA = "0x180A9A640")]
			internal bool MJNPDAEAFOP(MGIIIFNAEDD e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class GDJLPBCDHGG : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private HGOIDBIKHMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public HHGAMMAIPLL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public BGIAJOAAIGN timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			private PNHMCPOGNBF <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private List<MGIIIFNAEDD> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public GDJLPBCDHGG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x885D890", Offset = "0x885C290", VA = "0x18885D890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x885DBC0", Offset = "0x885C5C0", VA = "0x18885DBC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly DGLKCECAJOP IDHNKODCLDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private IDJIHHOMEIC GNNONNJKBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly List<MGIIIFNAEDD> MIGOHJBNJHF;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x885FA80", Offset = "0x885E480", VA = "0x18885FA80")]
		public HHGAMMAIPLL(DGLKCECAJOP IDHNKODCLDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x885F810", Offset = "0x885E210", VA = "0x18885F810")]
		public IDisposable LEBKCLMMDBG(MGIIIFNAEDD MFDKBJDPNGG, CJCKCFOBOPF DBBKPFGHGAF, BGIAJOAAIGN JNHNJKFGOJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x885F630", Offset = "0x885E030", VA = "0x18885F630")]
		private void DBCIJBCCKMN(int KHNIMGKFPOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x885F9F0", Offset = "0x885E3F0", VA = "0x18885F9F0")]
		[IteratorStateMachine(typeof(GDJLPBCDHGG))]
		private IEnumerator<HGOIDBIKHMF> LKENIFOBEAB(BGIAJOAAIGN JNHNJKFGOJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x885F7C0", Offset = "0x885E1C0", VA = "0x18885F7C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class MGIIIFNAEDD
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public enum PJEGAGKDMJB : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static int CFFDCAOLDNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly int KIJDDDGOGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly INBJDGLCFFF FFHCJDNPLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly MonoBehaviour LJCNMNGEIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly Action FPILOHDMIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly Action<float> DGJBCPGOMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly float BLBHHFIMKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public float DLNKEGKNHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public readonly string HMKINKIIOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public readonly bool ACKOANGPEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly PJEGAGKDMJB CDFDNHEPPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool NBBIMLEOPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public bool FLNNFCEEBJL;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x88635F0", Offset = "0x8861FF0", VA = "0x1888635F0")]
		public MGIIIFNAEDD(INBJDGLCFFF GJIMIGJJJKI, Action OKMGMCHIGBN, bool JCMPMOMOPLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8863290", Offset = "0x8861C90", VA = "0x188863290")]
		public MGIIIFNAEDD(INBJDGLCFFF GJIMIGJJJKI, Action<float> OKMGMCHIGBN, bool JCMPMOMOPLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8863410", Offset = "0x8861E10", VA = "0x188863410")]
		public MGIIIFNAEDD(INBJDGLCFFF GJIMIGJJJKI, float AJIPHAIIOLB, Action<float> OKMGMCHIGBN, BGIAJOAAIGN JNHNJKFGOJB, PJEGAGKDMJB IDNBOPJOBKK, bool HHHDJHHANOA, bool JCMPMOMOPLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x88630C0", Offset = "0x8861AC0", VA = "0x1888630C0")]
		public bool PCIDMDEOAMG(float FDFNAMJJMBO, float HAFMFFEGLKI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly CJCKCFOBOPF DBBKPFGHGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly BGIAJOAAIGN KMOEPMLKBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly Dictionary<DGLKCECAJOP, HHGAMMAIPLL> DDMLLCLKLPN;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x885F500", Offset = "0x885DF00", VA = "0x18885F500")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	internal static void PJCNFCNBGAE(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x885F570", Offset = "0x885DF70", VA = "0x18885F570")]
	[UnityEngine.Scripting.Preserve]
	internal GMPPOBNHAGP([CNHMBDDCGKB(null)] CJCKCFOBOPF DBBKPFGHGAF, [CNHMBDDCGKB(null)] BGIAJOAAIGN KMOEPMLKBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x885EDA0", Offset = "0x885D7A0", VA = "0x18885EDA0", Slot = "4")]
	public IDisposable FPILOHDMIEH(INBJDGLCFFF GJIMIGJJJKI, Action DMDJELFGCKJ, DGLKCECAJOP IDHNKODCLDE, bool JCMPMOMOPLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x885EF90", Offset = "0x885D990", VA = "0x18885EF90", Slot = "5")]
	public IDisposable FPILOHDMIEH(INBJDGLCFFF GJIMIGJJJKI, Action<float> DMDJELFGCKJ, DGLKCECAJOP IDHNKODCLDE, bool JCMPMOMOPLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x885F400", Offset = "0x885DE00", VA = "0x18885F400", Slot = "7")]
	public IDisposable MCDPBHGINAP(INBJDGLCFFF GJIMIGJJJKI, float AJIPHAIIOLB, Action<float> DMDJELFGCKJ, DGLKCECAJOP IDHNKODCLDE, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x885F180", Offset = "0x885DB80", VA = "0x18885F180", Slot = "8")]
	public IDisposable ILLCIFFOFCL(INBJDGLCFFF GJIMIGJJJKI, float AJIPHAIIOLB, Action<float> DMDJELFGCKJ, DGLKCECAJOP IDHNKODCLDE, bool HHHDJHHANOA = true, bool JCMPMOMOPLB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x885F280", Offset = "0x885DC80", VA = "0x18885F280", Slot = "6")]
	public IDisposable MCDPBHGINAP(float AJIPHAIIOLB, Action<float> DMDJELFGCKJ, bool HHHDJHHANOA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x885EAA0", Offset = "0x885D4A0", VA = "0x18885EAA0", Slot = "9")]
	public void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x885EC60", Offset = "0x885D660", VA = "0x18885EC60")]
	private HHGAMMAIPLL ALIOLMFMJAB(DGLKCECAJOP IDHNKODCLDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class MDEOHAOIDJA : AHBCOPHIGBC, CJCKCFOBOPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private EHBAMNNNBOI[] AIEAHGLPGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private KGOCNDKJHKH PNJNKIEABJO;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8862B00", Offset = "0x8861500", VA = "0x188862B00")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	internal static void FEDJMCICCOK(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8863000", Offset = "0x8861A00", VA = "0x188863000")]
	[UnityEngine.Scripting.Preserve]
	public MDEOHAOIDJA([CNHMBDDCGKB(null)] LBFAAAPHKKM DDCDEAJMCMG, [CNHMBDDCGKB(null)] BGIAJOAAIGN KMOEPMLKBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8862970", Offset = "0x8861370", VA = "0x188862970", Slot = "19")]
	public override IDJIHHOMEIC CPIBKHAALCP(DJGCAAKJKKI GJIMIGJJJKI, IEnumerator<HGOIDBIKHMF> CCGONJAINMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8862390", Offset = "0x8860D90", VA = "0x188862390", Slot = "20")]
	public override void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8862620", Offset = "0x8861020", VA = "0x188862620", Slot = "22")]
	public override void BKDBKFEBAON(DGLKCECAJOP IDHNKODCLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8862B70", Offset = "0x8861570", VA = "0x188862B70", Slot = "21")]
	protected override void FPILOHDMIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x8862CE0", Offset = "0x88616E0", VA = "0x188862CE0")]
	private EHBAMNNNBOI GFPLMMOHEKL(DGLKCECAJOP HHCAOFMCNLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x8862D10", Offset = "0x8861710", VA = "0x188862D10", Slot = "23")]
	internal override JNBDOCJLNHG KKBMKHNODFH(IEnumerator<HGOIDBIKHMF> CCGONJAINMB, Behaviour GJIMIGJJJKI, JGHOHOMLENF GNNONNJKBFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x8862F40", Offset = "0x8861940", VA = "0x188862F40", Slot = "24")]
	internal override NGKKMDGNMDH MODDHICIBDA(DGLKCECAJOP IHEHIKLMINL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8862850", Offset = "0x8861250", VA = "0x188862850")]
	private void CFEPHPBNDNP(EHBAMNNNBOI FIKLCGBAMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8862AA0", Offset = "0x88614A0", VA = "0x188862AA0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[BurstCompile]
internal struct EGFLJDGMIHG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	[ReadOnly]
	public float IDCAPHLAMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	[ReadOnly]
	public int MKBOFLJHNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private NativeArray<int> PINFICIJBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private NativeArray<int> GDAMJMEBFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private NativeArray<int> BLAHBCDJFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	[ReadOnly]
	public NativeArray<FIKJLGCGLJG> PMOHDOMGFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[ReadOnly]
	public NativeArray<float> LDDAAMGJLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	[WriteOnly]
	public NativeArray<int> DIIICKJFIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	[WriteOnly]
	public NativeArray<int> GFONHCALMMA;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8859460", Offset = "0x8857E60", VA = "0x188859460")]
	public static EGFLJDGMIHG JEBOFNEMEAN(int MCJOANOPLFM, float HAGDKDAABGH, NativeArray<FIKJLGCGLJG> BMEODFKELGF, NativeArray<float> OONBLJILLFD, NativeArray<int> HONFFAKDODG, NativeArray<int> HLAFCHNNJID, NativeArray<int> ADLIJADDKHB, NativeArray<int> GDAMJMEBFIH, NativeArray<int> BLAHBCDJFFO)
	{
		return default(EGFLJDGMIHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x8859350", Offset = "0x8857D50", VA = "0x188859350", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x8859630", Offset = "0x8858030", VA = "0x188859630")]
	private bool OFKJFFLNCID(int MNFHMLCLFEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x8859430", Offset = "0x8857E30", VA = "0x188859430")]
	private void IAPFCKNKKCH(NativeArray<int> ABLCJNGADLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x88594C0", Offset = "0x8857EC0", VA = "0x1888594C0")]
	private int KPEGKALCDJB(int EDLLJPFGCPA, int IPIPHAEBGNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8859560", Offset = "0x8857F60", VA = "0x188859560")]
	private void NIFDPBPLHHN(NativeArray<int> ABLCJNGADLL, int FIHNDKJHMIO, int FGEFHKAEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8859110", Offset = "0x8857B10", VA = "0x188859110")]
	private void BPNHKDJHKOC(NativeArray<int> ABLCJNGADLL, int HIENNACEBAL, int LDLLIEJPHNP, int DNGCLNCEMOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class AHBCOPHIGBC : CJCKCFOBOPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly LBFAAAPHKKM DDCDEAJMCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	protected readonly BGIAJOAAIGN KMOEPMLKBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NGKKMDGNMDH[] EBPCOLOKNIN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static CJCKCFOBOPF FDCAMNOGINK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8851380", Offset = "0x884FD80", VA = "0x188851380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool ANNFNILDKLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DGLKCECAJOP POIMHAKHFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(DGLKCECAJOP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA155F0", Offset = "0xA13FF0", VA = "0x180A155F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public BGIAJOAAIGN ODDPBLLPJFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HGOIDBIKHMF MKJMAFADDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public HGOIDBIKHMF CILBJBBLLAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public HGOIDBIKHMF AEKJCBDCEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HGOIDBIKHMF GHEEAHNLIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8851620", Offset = "0x8850020", VA = "0x188851620")]
	public static IDJIHHOMEIC LGMJPPDGEOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8851800", Offset = "0x8850200", VA = "0x188851800")]
	[UnityEngine.Scripting.Preserve]
	protected AHBCOPHIGBC([CNHMBDDCGKB(null)] LBFAAAPHKKM DDCDEAJMCMG, [CNHMBDDCGKB(null)] BGIAJOAAIGN KMOEPMLKBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x88513F0", Offset = "0x884FDF0", VA = "0x1888513F0", Slot = "6")]
	public IDJIHHOMEIC IJLCGHNANIM(IEnumerator<HGOIDBIKHMF> CCGONJAINMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8851400", Offset = "0x884FE00", VA = "0x188851400", Slot = "7")]
	public IDJIHHOMEIC IJLCGHNANIM(Behaviour GJIMIGJJJKI, IEnumerator<HGOIDBIKHMF> CCGONJAINMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract IDJIHHOMEIC CPIBKHAALCP(DJGCAAKJKKI GJIMIGJJJKI, IEnumerator<HGOIDBIKHMF> CCGONJAINMB);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8850940", Offset = "0x884F340", VA = "0x188850940", Slot = "20")]
	public virtual void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8850B70", Offset = "0x884F570", VA = "0x188850B70", Slot = "9")]
	public void CFABKKPIEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8851340", Offset = "0x884FD40", VA = "0x188851340", Slot = "21")]
	protected virtual void FPILOHDMIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8850920", Offset = "0x884F320", VA = "0x188850920")]
	private void AGALKBFIBIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x8851360", Offset = "0x884FD60", VA = "0x188851360")]
	private void GCFGJFEEIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x88517A0", Offset = "0x88501A0", VA = "0x1888517A0")]
	private void OCMOLIOAACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x88517C0", Offset = "0x88501C0", VA = "0x1888517C0")]
	private void OCPAHICMOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8851600", Offset = "0x8850000", VA = "0x188851600")]
	private void KFJOOAIMGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x88517E0", Offset = "0x88501E0", VA = "0x1888517E0")]
	private void PDHOKAPBENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8850900", Offset = "0x884F300", VA = "0x188850900")]
	private void AFMPNHKGJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8850AE0", Offset = "0x884F4E0", VA = "0x188850AE0", Slot = "22")]
	public virtual void BKDBKFEBAON(DGLKCECAJOP IDHNKODCLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8850DB0", Offset = "0x884F7B0", VA = "0x188850DB0")]
	private void CINKHPHOJOD(NGKKMDGNMDH FIKLCGBAMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x27BE2A0", Offset = "0x27BCCA0", VA = "0x1827BE2A0")]
	private NGKKMDGNMDH ICBNHDAPMGF(DGLKCECAJOP HHCAOFMCNLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract JNBDOCJLNHG KKBMKHNODFH(IEnumerator<HGOIDBIKHMF> CCGONJAINMB, Behaviour EPOEHDLAHPC, JGHOHOMLENF LKGDHOIMMIH);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract NGKKMDGNMDH MODDHICIBDA(DGLKCECAJOP IDHNKODCLDE);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x8850F80", Offset = "0x884F980", VA = "0x188850F80", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x88508A0", Offset = "0x884F2A0", VA = "0x1888508A0", Slot = "15")]
	public HGOIDBIKHMF AFDDAJDDKIC(DGLKCECAJOP IHEHIKLMINL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x88516B0", Offset = "0x88500B0", VA = "0x1888516B0", Slot = "16")]
	public HGOIDBIKHMF LLNLCPJPFGJ(float CAJJAMECEFA, DGLKCECAJOP IHEHIKLMINL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x8851740", Offset = "0x8850140", VA = "0x188851740", Slot = "17")]
	public HGOIDBIKHMF NDHHPCEMHBM(Func<bool> APOGDCILJPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class JNBDOCJLNHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly JGHOHOMLENF GNNONNJKBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly DEPOGGDPGAD GJIMIGJJJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly bool OPEDHBDFFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private string GBCFHNGPBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private StackTrace ALJABDBDKEF;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerator<HGOIDBIKHMF> KPLOGIHMEPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public HGOIDBIKHMF NDPBNHBCGIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool GNNLGLIOKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8860F10", Offset = "0x885F910", VA = "0x188860F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool MBGKGHEBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xCA7110", Offset = "0xCA5B10", VA = "0x180CA7110")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xCDBBB0", Offset = "0xCDA5B0", VA = "0x180CDBBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string HMKINKIIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8860F90", Offset = "0x885F990", VA = "0x188860F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float OHDGPFBMOEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xE13B00", Offset = "0xE12500", VA = "0x180E13B00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xE13B10", Offset = "0xE12510", VA = "0x180E13B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8861600", Offset = "0x8860000", VA = "0x188861600")]
	public JNBDOCJLNHG(IEnumerator<HGOIDBIKHMF> HNOPKGKMPEC, DEPOGGDPGAD GJIMIGJJJKI, JGHOHOMLENF GNNONNJKBFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x88611B0", Offset = "0x885FBB0", VA = "0x1888611B0")]
	public HGOIDBIKHMF IEEMGEAFJJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8861140", Offset = "0x885FB40", VA = "0x188861140")]
	public bool DIJOMLOONKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x88614D0", Offset = "0x885FED0", VA = "0x1888614D0")]
	public void JCMHGMGGFCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8861520", Offset = "0x885FF20", VA = "0x188861520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0xD25CD0", Offset = "0xD246D0", VA = "0x180D25CD0")]
	[CompilerGenerated]
	private void NNFKLFAFBDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class JGHOHOMLENF : LKDGEJDIBFP, IDJIHHOMEIC, LIJLGGILNGM, FDBBAHKKNBB, IEnumerator, HGOIDBIKHMF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private DGLKCECAJOP ICFAAMBIGKP;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private DGLKCECAJOP IOMDDDNIBDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA86FE0", Offset = "0xA859E0", VA = "0x180A86FE0", Slot = "23")]
		get
		{
			return default(DGLKCECAJOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DGLKCECAJOP KMGBOCDANAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xF9ED50", Offset = "0xF9D750", VA = "0x180F9ED50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private float KMMCBDCGBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA5AD90", Offset = "0xA59790", VA = "0x180A5AD90", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool OHPLHHFMIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8860EA0", Offset = "0x885F8A0", VA = "0x188860EA0", Slot = "24")]
	private bool IFGHDLOMKGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8860E90", Offset = "0x885F890", VA = "0x188860E90", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8860EC0", Offset = "0x885F8C0", VA = "0x188860EC0")]
	public JGHOHOMLENF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal enum OBAAMHFNNHN : byte
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
internal sealed class NGKKMDGNMDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum PCGMNBKAGHA
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public struct OPGFPIBEMKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public DGLKCECAJOP DFDBOBINFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public PCGMNBKAGHA MDHLNBKEFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public List<JNBDOCJLNHG> CICGMLAGBIP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly PCGMNBKAGHA[] PHMBIOOLAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly DGLKCECAJOP IDHNKODCLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private bool ECMAIHAPPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly JNBDOCJLNHG[] MHAFLJGJLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<JNBDOCJLNHG> GPHOFBIMCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly Stack<int> CELCCOCBCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly List<JNBDOCJLNHG> ILGPLBNIMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly Stack<int> BCHKNHICPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly KGOCNDKJHKH ILPKOCLGIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private bool MBBJKNNMILI;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public OPGFPIBEMKH[,] JFAHMNJBLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x88662E0", Offset = "0x8864CE0", VA = "0x1888662E0")]
	public NGKKMDGNMDH(DGLKCECAJOP IHEHIKLMINL, KGOCNDKJHKH ILPKOCLGIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8865DD0", Offset = "0x88647D0", VA = "0x188865DD0")]
	public void OOCLNAJOPJH(JNBDOCJLNHG HNOPKGKMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8865310", Offset = "0x8863D10", VA = "0x188865310")]
	public void GDLEKDKPPDE(IList<JNBDOCJLNHG> OFGODKHGPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8865600", Offset = "0x8864000", VA = "0x188865600")]
	public void KJOCNKHOKJK(IList<JNBDOCJLNHG> OFGODKHGPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8865EE0", Offset = "0x88648E0", VA = "0x188865EE0")]
	private void PAHAIPGFHFL(JNBDOCJLNHG HNOPKGKMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x88658F0", Offset = "0x88642F0", VA = "0x1888658F0")]
	private void LGBNBMPIIAE(IList<JNBDOCJLNHG> OFGODKHGPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8866030", Offset = "0x8864A30", VA = "0x188866030")]
	private OBAAMHFNNHN PIAGGEBLIBA(JNBDOCJLNHG HNOPKGKMPEC)
	{
		return default(OBAAMHFNNHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x88651A0", Offset = "0x8863BA0", VA = "0x1888651A0")]
	public void FPILOHDMIEH(float HAGDKDAABGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8864D50", Offset = "0x8863750", VA = "0x188864D50")]
	public void CFABKKPIEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8865A70", Offset = "0x8864470", VA = "0x188865A70")]
	private void NFLLLODOOGO(List<JNBDOCJLNHG> OFGODKHGPMI, Stack<int> GEABKHNCMMP, bool EILBOBLIMKC, float PMEKMCKBDPN = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8865080", Offset = "0x8863A80", VA = "0x188865080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8864F40", Offset = "0x8863940", VA = "0x188864F40")]
	private void CKCLCLKEKPC(List<JNBDOCJLNHG> OFGODKHGPMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal class LMJNKCGEPJL : KGOCNDKJHKH
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	public void PEFLCJEEGFN(string GBCFHNGPBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
	public void PJLBEOJCALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public LMJNKCGEPJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal class FJJHMKLDGJP : DEPOGGDPGAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly Behaviour EPOEHDLAHPC;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string HMKINKIIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x885D570", Offset = "0x885BF70", VA = "0x18885D570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool GPPPGPEDKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x885D610", Offset = "0x885C010", VA = "0x18885D610", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ADHBCGMAABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x885D5F0", Offset = "0x885BFF0", VA = "0x18885D5F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public FJJHMKLDGJP(Behaviour EPOEHDLAHPC)
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

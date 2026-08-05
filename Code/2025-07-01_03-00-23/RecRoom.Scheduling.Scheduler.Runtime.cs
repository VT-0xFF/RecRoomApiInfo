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
		[Cpp2IlInjected.Address(RVA = "0x8AE26C0", Offset = "0x8AE0CC0", VA = "0x188AE26C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
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
		private delegate List<PlayerLoopSystem> PFCEDNBLHEI(List<PlayerLoopSystem> HCJIIIHMCPG, int HPCDPNBPICB);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct BDIFEFLINCM
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct NEAJGDPGDHJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static LGEBFGGIOJB OHAHCFGDLKL;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x8ADEC30", Offset = "0x8ADD230", VA = "0x188ADEC30")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct JJNENFNDBBH
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static LGEBFGGIOJB FONIHAKGKCO;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8ADC920", Offset = "0x8ADAF20", VA = "0x188ADC920")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct IHCIKINACBC
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static LGEBFGGIOJB LKLBPKIIKJF;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x8ADAA70", Offset = "0x8AD9070", VA = "0x188ADAA70")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct PGPJEPAGHCJ
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static LGEBFGGIOJB ECNIOAEFDBH;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static LGEBFGGIOJB CMLPCOOFDKE;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static LGEBFGGIOJB BEAEAILFJKK;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static LGEBFGGIOJB ACEOMMBHHNH;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x8AE0EE0", Offset = "0x8ADF4E0", VA = "0x188AE0EE0")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct CBMDELEGGEP
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static LGEBFGGIOJB OIHKICKBMCJ;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x8ACDD00", Offset = "0x8ACC300", VA = "0x188ACDD00")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct PFNGLIFMKAO
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static LGEBFGGIOJB ECNIOAEFDBH;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static LGEBFGGIOJB CMLPCOOFDKE;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static LGEBFGGIOJB BEAEAILFJKK;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static LGEBFGGIOJB ACEOMMBHHNH;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x8ADFE50", Offset = "0x8ADE450", VA = "0x188ADFE50")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct HPDIBFAILCI
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static LGEBFGGIOJB KNLDHNGHPIM;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x8ADA830", Offset = "0x8AD8E30", VA = "0x188ADA830")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct KICCEOBJDJM
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static LGEBFGGIOJB PCDMOMDNAPP;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x8ADD7F0", Offset = "0x8ADBDF0", VA = "0x188ADD7F0")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct LDHMLNEFKAL
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static LGEBFGGIOJB KFHDMFMKHAK;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x8ADDB00", Offset = "0x8ADC100", VA = "0x188ADDB00")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct OIADHHFFHNJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static LGEBFGGIOJB KECLDMGAAAO;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x8ADF070", Offset = "0x8ADD670", VA = "0x188ADF070")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct EAKIAFHHEEH
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static LGEBFGGIOJB KNDEDFJNLGH;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x8AD4060", Offset = "0x8AD2660", VA = "0x188AD4060")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct GEFDNKEBLOO
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static LGEBFGGIOJB OGGPNDONJHL;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x8AD8920", Offset = "0x8AD6F20", VA = "0x188AD8920")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct PEOIIDHHGIJ
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static LGEBFGGIOJB NODHKMPJFKB;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x8ADFC50", Offset = "0x8ADE250", VA = "0x188ADFC50")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct GEAKMBGEGHJ
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static LGEBFGGIOJB NCEOOAKILLG;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x8AD8720", Offset = "0x8AD6D20", VA = "0x188AD8720")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public struct NIPPEPMELLA
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static LGEBFGGIOJB IGKPMFKKBNG;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x8ADEE30", Offset = "0x8ADD430", VA = "0x188ADEE30")]
				public static PlayerLoopSystem MAFDOLBCBNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public enum DNBCLBPBIFD : byte
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
			public struct AOELAMJEMPB
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class PMAPLKAHGNC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public DNBCLBPBIFD updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
					public PMAPLKAHGNC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0x8AE11D0", Offset = "0x8ADF7D0", VA = "0x188AE11D0")]
					internal void CPPAKPOPMBG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static IAJLDMLJHLB<DNBCLBPBIFD> BJOIDGPCGCL;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x8ACD390", Offset = "0x8ACB990", VA = "0x188ACD390")]
				public static PlayerLoopSystem MAFDOLBCBNA(DNBCLBPBIFD CCGAKABAJJL)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000027")]
			internal struct PCEPPPGEIPG
			{
				[Cpp2IlInjected.Token(Token = "0x2000028")]
				[CompilerGenerated]
				private sealed class ABMBGNDCGGE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public PBGKCJNCGDF.AFBDLMOEECF key;

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
					public ABMBGNDCGGE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005E")]
					[Cpp2IlInjected.Address(RVA = "0x8ACA760", Offset = "0x8AC8D60", VA = "0x188ACA760")]
					internal void NKOEIFMCGBL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable FNOOLCECIKI;

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x8ADFB20", Offset = "0x8ADE120", VA = "0x188ADFB20")]
				public static PlayerLoopSystem OEMCKFHJMPI(PBGKCJNCGDF.AFBDLMOEECF BLIBAMJKLIA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002A")]
			internal struct GNPALKOBLOC
			{
				[Cpp2IlInjected.Token(Token = "0x200002B")]
				[CompilerGenerated]
				private sealed class CFAPHNDEIFE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public PBGKCJNCGDF.AFBDLMOEECF key;

					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
					public CFAPHNDEIFE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x8ACE7B0", Offset = "0x8ACCDB0", VA = "0x188ACE7B0")]
					internal void NKOEIFMCGBL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x8AD8EF0", Offset = "0x8AD74F0", VA = "0x188AD8EF0")]
				public static PlayerLoopSystem OEMCKFHJMPI(PBGKCJNCGDF.AFBDLMOEECF BLIBAMJKLIA)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class HANOPLOCCOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public HANOPLOCCOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9020", Offset = "0x8AD7620", VA = "0x188AD9020")]
			internal List<PlayerLoopSystem> NMNOHIODNAO(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool OLKDKFGHJOB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool OEOMJCOEMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8AD2E00", Offset = "0x8AD1400", VA = "0x188AD2E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8ACFD40", Offset = "0x8ACE340", VA = "0x188ACFD40")]
		private static void EDNJMNKHBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2E40", Offset = "0x8AD1440", VA = "0x188AD2E40")]
		private static void GHJGBABJLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8ACFBD0", Offset = "0x8ACE1D0", VA = "0x188ACFBD0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3910", Offset = "0x8AD1F10", VA = "0x188AD3910")]
		private static void MEJAIPANIML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3750", Offset = "0x8AD1D50", VA = "0x188AD3750")]
		private static void IAHNNBFBBBF(PBGKCJNCGDF.AFBDLMOEECF BLIBAMJKLIA, PlayerLoopSystem LKCBBMAEELI, Type PHCEOKLOHEB, Type BMCBBFMCDMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3B60", Offset = "0x8AD2160", VA = "0x188AD3B60")]
		private static void PBGLGMHHDMP(PlayerLoopSystem LKCBBMAEELI, Type PHCEOKLOHEB, Type BMCBBFMCDMD, PFCEDNBLHEI MLDJCCDFEHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACFC10", Offset = "0x8ACE210", VA = "0x188ACFC10")]
		private static void BLCLNCHNEPM(PlayerLoopSystem LKCBBMAEELI, Type PHCEOKLOHEB, Type BMCBBFMCDMD, PlayerLoopSystem? JGDEMMIPJMF, PlayerLoopSystem? FJHMAIDOPGF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class PBGKCJNCGDF
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum AFBDLMOEECF
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
	public class BPPJPHDJBLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly AFBDLMOEECF OIHIPDIKKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly LLOEPPCADCN GACPPCOOMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long ABNFBMBDNFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long APGAJECMKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long LBGPIKFNGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int NAEOIABLNEF;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDBB0", Offset = "0x8ACC1B0", VA = "0x188ACDBB0")]
		public BPPJPHDJBLA(AFBDLMOEECF NJHHEIOHOGH, int OGJNIBDHDHN = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDAB0", Offset = "0x8ACC0B0", VA = "0x188ACDAB0")]
		public void JMDMJHNNKIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDA60", Offset = "0x8ACC060", VA = "0x188ACDA60")]
		public void ACKMPAFJGPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDAD0", Offset = "0x8ACC0D0", VA = "0x188ACDAD0")]
		public void OCNGOOCEKOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static AFBDLMOEECF[] MPINJFBIFGN;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static BPPJPHDJBLA[] LAGOJLAMBEC;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8ADF830", Offset = "0x8ADDE30", VA = "0x188ADF830")]
	public static BPPJPHDJBLA PKFNJOLJCGA(AFBDLMOEECF BLIBAMJKLIA, int OGJNIBDHDHN = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8ADF7C0", Offset = "0x8ADDDC0", VA = "0x188ADF7C0")]
	public static BPPJPHDJBLA LGAAFOKGHGD(AFBDLMOEECF BLIBAMJKLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8ADF710", Offset = "0x8ADDD10", VA = "0x188ADF710")]
	public static void JALIIDMHDMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FBJAFMLHLHE
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface PGFMCBMADCP
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool LGJKLDJCOPD
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EMDPKKLLFMH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class PNGFAPCICCG : PGFMCBMADCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action CJDOILFHDJI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool LGJKLDJCOPD
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
		public PNGFAPCICCG(Action CJDOILFHDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1209A10", Offset = "0x1208010", VA = "0x181209A10", Slot = "5")]
		public void EMDPKKLLFMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<PGFMCBMADCP> ACFNBDPELNJ;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7750", Offset = "0x8AD5D50", VA = "0x188AD7750")]
	public static void MDBBAELJJDN(Action CJDOILFHDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8AD77F0", Offset = "0x8AD5DF0", VA = "0x188AD77F0")]
	private static void NGDNEFKFFAJ(PGFMCBMADCP GECLDOIKKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7270", Offset = "0x8AD5870", VA = "0x188AD7270")]
	private static void ACJPNBFKBPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7650", Offset = "0x8AD5C50", VA = "0x188AD7650")]
	private static void GGHKIMJMHKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7570", Offset = "0x8AD5B70", VA = "0x188AD7570")]
	private static void ANNEJDJIBBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class HOAMNEIMFCH
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA6A0", Offset = "0x8AD8CA0", VA = "0x188ADA6A0")]
	public static IDisposable MFBECDOJEGB(this LMKECBAEOAN HILCMKALFIH, float BAOAKABBCIN, Action<float> LIDCEJNLILH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA730", Offset = "0x8AD8D30", VA = "0x188ADA730")]
	public static IDisposable NOHNIOKFBNM(this LMKECBAEOAN HILCMKALFIH, Action<float> LIDCEJNLILH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA7B0", Offset = "0x8AD8DB0", VA = "0x188ADA7B0")]
	public static IDisposable OEAEEJLKHCN(this LMKECBAEOAN HILCMKALFIH, Action<float> LIDCEJNLILH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class IMPGCCEEPGD
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3B83A30", Offset = "0x3B82030", VA = "0x183B83A30")]
	[KKKHBGDHDKB]
	public static IDisposable MBPDPGJGNEC<T>(this T NCBHPDBBCIG, Action LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B83BD0", Offset = "0x3B821D0", VA = "0x183B83BD0")]
	[KKKHBGDHDKB]
	public static IDisposable MBPDPGJGNEC<T>(this T NCBHPDBBCIG, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3B83900", Offset = "0x3B81F00", VA = "0x183B83900")]
	[KKKHBGDHDKB]
	public static IDisposable IEMAIHNOLMJ<T>(this T NCBHPDBBCIG, Action LIDCEJNLILH, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3B835F0", Offset = "0x3B81BF0", VA = "0x183B835F0")]
	[KKKHBGDHDKB]
	public static IDisposable EFBLPCPGKLL<T>(this T NCBHPDBBCIG, Action LIDCEJNLILH, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B835F0", Offset = "0x3B81BF0", VA = "0x183B835F0")]
	[KKKHBGDHDKB]
	public static IDisposable EFBLPCPGKLL<T>(this T NCBHPDBBCIG, Action<float> LIDCEJNLILH, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B83540", Offset = "0x3B81B40", VA = "0x183B83540")]
	[KKKHBGDHDKB]
	public static IDisposable CNKCKOCHENP<T>(this T NCBHPDBBCIG, Action LIDCEJNLILH, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3B83510", Offset = "0x3B81B10", VA = "0x183B83510")]
	[KKKHBGDHDKB]
	public static IDisposable ANCMPFJHACE<T>(this T NCBHPDBBCIG, Action LIDCEJNLILH, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B83660", Offset = "0x3B81C60", VA = "0x183B83660")]
	[KKKHBGDHDKB]
	public static IDisposable FMIOJNPKFMF<T>(this T NCBHPDBBCIG, Action LIDCEJNLILH, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B83880", Offset = "0x3B81E80", VA = "0x183B83880")]
	[KKKHBGDHDKB]
	public static IDisposable GNHEDLCGKDP<T>(this T NCBHPDBBCIG, float BAOAKABBCIN, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8ADAC70", Offset = "0x8AD9270", VA = "0x188ADAC70")]
	[KKKHBGDHDKB]
	public static IDisposable GNHEDLCGKDP(this MonoBehaviour NCBHPDBBCIG, ODGGGLKDEEB HILCMKALFIH, float BAOAKABBCIN, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3B836D0", Offset = "0x3B81CD0", VA = "0x183B836D0")]
	[KKKHBGDHDKB]
	public static IDisposable GMMGLJMHNHI<T>(this T NCBHPDBBCIG, float BAOAKABBCIN, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3B83DC0", Offset = "0x3B823C0", VA = "0x183B83DC0")]
	[KKKHBGDHDKB]
	public static IDisposable OBOAKNLKDAH<T>(this T NCBHPDBBCIG, float BAOAKABBCIN, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3B83930", Offset = "0x3B81F30", VA = "0x183B83930")]
	[KKKHBGDHDKB]
	public static IDisposable IIOPPJPHMGK<T>(this T NCBHPDBBCIG, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3B838C0", Offset = "0x3B81EC0", VA = "0x183B838C0")]
	[KKKHBGDHDKB]
	public static IDisposable HBKGPGMFGLL<T>(this T NCBHPDBBCIG, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3B839B0", Offset = "0x3B81FB0", VA = "0x183B839B0")]
	[KKKHBGDHDKB]
	public static IDisposable LDGCHDNIBFL<T>(this T NCBHPDBBCIG, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3B83620", Offset = "0x3B81C20", VA = "0x183B83620")]
	[KKKHBGDHDKB]
	public static IDisposable FLJKKOMNCAD<T>(this T NCBHPDBBCIG, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3B835B0", Offset = "0x3B81BB0", VA = "0x183B835B0")]
	[KKKHBGDHDKB]
	public static IDisposable ECPKBJLNCLK<T>(this T NCBHPDBBCIG, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3B83690", Offset = "0x3B81C90", VA = "0x183B83690")]
	[KKKHBGDHDKB]
	public static IDisposable GCNLGBFCHOE<T>(this T NCBHPDBBCIG, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3B83D80", Offset = "0x3B82380", VA = "0x183B83D80")]
	[KKKHBGDHDKB]
	public static IDisposable MLKBJIFBIBL<T>(this T NCBHPDBBCIG, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B83570", Offset = "0x3B81B70", VA = "0x183B83570")]
	[KKKHBGDHDKB]
	public static IDisposable DEGANBNDPMO<T>(this T NCBHPDBBCIG, float BAOAKABBCIN, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3B83970", Offset = "0x3B81F70", VA = "0x183B83970")]
	[KKKHBGDHDKB]
	public static IDisposable KBIMFNNINGI<T>(this T NCBHPDBBCIG, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3B839F0", Offset = "0x3B81FF0", VA = "0x183B839F0")]
	[KKKHBGDHDKB]
	public static IDisposable LONPAOBLEGN<T>(this T NCBHPDBBCIG, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true) where T : MonoBehaviour, ODGGGLKDEEB
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class CHKHAFDCLLE
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JOLHHHPBLCC : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public DMJPLAHANAN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private MBHKNGKKHLI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public JOLHHHPBLCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD6C0", Offset = "0x8ADBCC0", VA = "0x188ADD6C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD7A0", Offset = "0x8ADBDA0", VA = "0x188ADD7A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class PNLGDIIAILP : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public DMJPLAHANAN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private MBHKNGKKHLI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public PNLGDIIAILP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1250", Offset = "0x8ADF850", VA = "0x188AE1250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1340", Offset = "0x8ADF940", VA = "0x188AE1340", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF620", Offset = "0x8ACDC20", VA = "0x188ACF620")]
	public static LLKKGNCPLNM MBPDPGJGNEC(Action LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF590", Offset = "0x8ACDB90", VA = "0x188ACF590")]
	public static LLKKGNCPLNM MBPDPGJGNEC(Behaviour HILCMKALFIH, Action LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF6A0", Offset = "0x8ACDCA0", VA = "0x188ACF6A0")]
	public static LLKKGNCPLNM MBPDPGJGNEC(Behaviour HILCMKALFIH, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF470", Offset = "0x8ACDA70", VA = "0x188ACF470")]
	[IteratorStateMachine(typeof(JOLHHHPBLCC))]
	private static IEnumerator<HPILNDONOCO> DAPGBIHAAMF(DMJPLAHANAN CDDEFPCECLM, Action LIDCEJNLILH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF500", Offset = "0x8ACDB00", VA = "0x188ACF500")]
	[IteratorStateMachine(typeof(PNLGDIIAILP))]
	private static IEnumerator<HPILNDONOCO> DAPGBIHAAMF(DMJPLAHANAN CDDEFPCECLM, Action<float> LIDCEJNLILH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class EGNGBMOEFFO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class DLPEBLKDKAC : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public EGNGBMOEFFO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public DLPEBLKDKAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3F40", Offset = "0x8AD2540", VA = "0x188AD3F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3FD0", Offset = "0x8AD25D0", VA = "0x188AD3FD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly DMJPLAHANAN KOJHBKBCLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Action JFIIPLACBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool FAKFPELCDDK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LKLEAPMLHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA50EA0", Offset = "0xA4F4A0", VA = "0x180A50EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8AD44F0", Offset = "0x8AD2AF0", VA = "0x188AD44F0")]
	public EGNGBMOEFFO(DMJPLAHANAN KOJHBKBCLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8AD43D0", Offset = "0x8AD29D0", VA = "0x188AD43D0")]
	[IteratorStateMachine(typeof(DLPEBLKDKAC))]
	private IEnumerator<HPILNDONOCO> GHAFEPPJJFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4450", Offset = "0x8AD2A50", VA = "0x188AD4450", Slot = "4")]
	public void OnCompleted(Action BFNBNGOBMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	public void OFJAMJHMIHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KIOPFILIGIK
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8ADD9F0", Offset = "0x8ADBFF0", VA = "0x188ADD9F0")]
	public static EGNGBMOEFFO MJAODGLODJM(this DMJPLAHANAN KOJHBKBCLJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class FPBPMOJPGKP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class FGINCKOFHDG : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CDANGLLCNED schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public FGINCKOFHDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8140", Offset = "0x8AD6740", VA = "0x188AD8140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8AD81C0", Offset = "0x8AD67C0", VA = "0x188AD81C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8650", Offset = "0x8AD6C50", VA = "0x188AD8650")]
	public static LLKKGNCPLNM MBPDPGJGNEC(float BAOAKABBCIN, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, bool NJDMNMGJAJK = true, [Optional] PDDCOMLIBAI IEECLMDHIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8580", Offset = "0x8AD6B80", VA = "0x188AD8580")]
	public static LLKKGNCPLNM MBPDPGJGNEC(MonoBehaviour NCBHPDBBCIG, float BAOAKABBCIN, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, bool NJDMNMGJAJK = true, [Optional] PDDCOMLIBAI IEECLMDHIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8490", Offset = "0x8AD6A90", VA = "0x188AD8490")]
	public static LLKKGNCPLNM LPBNEJOBFLP(MonoBehaviour NCBHPDBBCIG, float BAOAKABBCIN, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, bool NJDMNMGJAJK = true, [Optional] PDDCOMLIBAI IEECLMDHIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8330", Offset = "0x8AD6930", VA = "0x188AD8330")]
	public static LLKKGNCPLNM JKIELFPDBJM(LMKECBAEOAN HILCMKALFIH, float BAOAKABBCIN, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, bool NJDMNMGJAJK = true, [Optional] PDDCOMLIBAI IEECLMDHIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8210", Offset = "0x8AD6810", VA = "0x188AD8210")]
	private static IEnumerator<HPILNDONOCO> DAPGBIHAAMF(JCBBKHHODBE BPOEHGMMOJJ, float BAOAKABBCIN, DMJPLAHANAN CDDEFPCECLM, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8AD82D0", Offset = "0x8AD68D0", VA = "0x188AD82D0")]
	private static IEnumerator<HPILNDONOCO> JJFFOKIABFG(JCBBKHHODBE BPOEHGMMOJJ, float BAOAKABBCIN, DMJPLAHANAN CDDEFPCECLM, Action<float> LIDCEJNLILH, bool NJDMNMGJAJK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8400", Offset = "0x8AD6A00", VA = "0x188AD8400")]
	[IteratorStateMachine(typeof(FGINCKOFHDG))]
	private static IEnumerator<HPILNDONOCO> LJNMDEBGHDB(CDANGLLCNED OHJOIDNHJLP, float BAOAKABBCIN, DMJPLAHANAN CDDEFPCECLM, Action<float> LIDCEJNLILH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class FAPAAMEABOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class PGFKLPBBBCN : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DMJPLAHANAN queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public PGFKLPBBBCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0140", Offset = "0x8ADE740", VA = "0x188AE0140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0200", Offset = "0x8ADE800", VA = "0x188AE0200", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8AD71E0", Offset = "0x8AD57E0", VA = "0x188AD71E0")]
	[IteratorStateMachine(typeof(PGFKLPBBBCN))]
	private static IEnumerator<HPILNDONOCO> PKHHJLDPJGO(DMJPLAHANAN KOJHBKBCLJD, Func<bool> KCEOCGICBLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7100", Offset = "0x8AD5700", VA = "0x188AD7100")]
	public static LLKKGNCPLNM FKJCCKCGBPG(this MonoBehaviour NCBHPDBBCIG, Func<bool> KCEOCGICBLB, DMJPLAHANAN KOJHBKBCLJD = DMJPLAHANAN.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HDINFFMKGBO
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class CAHOPDDNIEF : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public DMJPLAHANAN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public CAHOPDDNIEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDC40", Offset = "0x8ACC240", VA = "0x188ACDC40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDCB0", Offset = "0x8ACC2B0", VA = "0x188ACDCB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class OIOAPHOGJAH<T> : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public DMJPLAHANAN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public OIOAPHOGJAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x57D6310", Offset = "0x57D4910", VA = "0x1857D6310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x57D6390", Offset = "0x57D4990", VA = "0x1857D6390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class PPKKAGFMMJE : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public DMJPLAHANAN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private HPILNDONOCO <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public PPKKAGFMMJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1390", Offset = "0x8ADF990", VA = "0x188AE1390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1420", Offset = "0x8ADFA20", VA = "0x188AE1420", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9FD0", Offset = "0x8AD85D0", VA = "0x188AD9FD0")]
	[IteratorStateMachine(typeof(CAHOPDDNIEF))]
	private static IEnumerator<HPILNDONOCO> GHAFEPPJJFB(float BKONJIDKCPP, DMJPLAHANAN CDDEFPCECLM, Action OEPFDIIJHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3B5DDC0", Offset = "0x3B5C3C0", VA = "0x183B5DDC0")]
	[IteratorStateMachine(typeof(OIOAPHOGJAH<>))]
	private static IEnumerator<HPILNDONOCO> GHAFEPPJJFB<T>(float BKONJIDKCPP, DMJPLAHANAN CDDEFPCECLM, Action<T> OEPFDIIJHGI, T DFPJDDAMCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9E90", Offset = "0x8AD8490", VA = "0x188AD9E90")]
	[IteratorStateMachine(typeof(PPKKAGFMMJE))]
	private static IEnumerator<HPILNDONOCO> EGHHAPOKLJP(float BKONJIDKCPP, DMJPLAHANAN CDDEFPCECLM, Action OEPFDIIJHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA1B0", Offset = "0x8AD87B0", VA = "0x188ADA1B0")]
	public static IDisposable HLJPANJCEJE(this MonoBehaviour NCBHPDBBCIG, float BKONJIDKCPP, Action OEPFDIIJHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9D60", Offset = "0x8AD8360", VA = "0x188AD9D60")]
	public static LLKKGNCPLNM DMPAIHBLFKO(this MonoBehaviour NCBHPDBBCIG, float BKONJIDKCPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA290", Offset = "0x8AD8890", VA = "0x188ADA290")]
	public static LLKKGNCPLNM HLJPANJCEJE(this MonoBehaviour NCBHPDBBCIG, float BKONJIDKCPP, DMJPLAHANAN CDDEFPCECLM, Action OEPFDIIJHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA600", Offset = "0x8AD8C00", VA = "0x188ADA600")]
	public static LLKKGNCPLNM NHCCHLKKADK(this MonoBehaviour NCBHPDBBCIG, Action OEPFDIIJHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3B5DFA0", Offset = "0x3B5C5A0", VA = "0x183B5DFA0")]
	public static LLKKGNCPLNM NHCCHLKKADK<T>(this MonoBehaviour NCBHPDBBCIG, Action<T> OEPFDIIJHGI, T DFPJDDAMCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA110", Offset = "0x8AD8710", VA = "0x188ADA110")]
	public static LLKKGNCPLNM HJENIFLJEMD(this MonoBehaviour NCBHPDBBCIG, Action OEPFDIIJHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA380", Offset = "0x8AD8980", VA = "0x188ADA380")]
	public static LLKKGNCPLNM IKCIGANJMBP(this MonoBehaviour NCBHPDBBCIG, Action OEPFDIIJHGI, [Optional] PDDCOMLIBAI IEECLMDHIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA420", Offset = "0x8AD8A20", VA = "0x188ADA420")]
	public static LLKKGNCPLNM ILODOGIMCDL(this MonoBehaviour NCBHPDBBCIG, Action OEPFDIIJHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9DF0", Offset = "0x8AD83F0", VA = "0x188AD9DF0")]
	public static LLKKGNCPLNM EDOFKOLGALN(this MonoBehaviour NCBHPDBBCIG, Action OEPFDIIJHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA4C0", Offset = "0x8AD8AC0", VA = "0x188ADA4C0")]
	public static LLKKGNCPLNM KPGPKLGOLOO(MonoBehaviour NCBHPDBBCIG, DMJPLAHANAN KOJHBKBCLJD, Action OEPFDIIJHGI, [Optional] PDDCOMLIBAI IEECLMDHIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B5DE80", Offset = "0x3B5C480", VA = "0x183B5DE80")]
	public static LLKKGNCPLNM KPGPKLGOLOO<T>(MonoBehaviour NCBHPDBBCIG, DMJPLAHANAN KOJHBKBCLJD, Action<T> OEPFDIIJHGI, T DFPJDDAMCPC, [Optional] PDDCOMLIBAI IEECLMDHIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9CD0", Offset = "0x8AD82D0", VA = "0x188AD9CD0")]
	public static LLKKGNCPLNM AKPFOGJCDMI(this MonoBehaviour NCBHPDBBCIG, float DPJHOFILONF, Action OEPFDIIJHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9F30", Offset = "0x8AD8530", VA = "0x188AD9F30")]
	public static LLKKGNCPLNM FFPJCNADJHJ(this MonoBehaviour NCBHPDBBCIG, float DPJHOFILONF, Action OEPFDIIJHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA070", Offset = "0x8AD8670", VA = "0x188ADA070")]
	public static LLKKGNCPLNM GKMJGOADCMG(this MonoBehaviour NCBHPDBBCIG, float DPJHOFILONF, Action OEPFDIIJHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA560", Offset = "0x8AD8B60", VA = "0x188ADA560")]
	public static LLKKGNCPLNM LDBILPEJCOC(this MonoBehaviour NCBHPDBBCIG, float DPJHOFILONF, Action OEPFDIIJHGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class CHAPEAPOKBD : MBOPCPOPDEN, IEnumerable<MBOPCPOPDEN>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<MBOPCPOPDEN> POAEJKCDFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool BPGIPGEAAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Action IOEPHKMNIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool ALEILKKLDIJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool FJCFEMKFJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8ACEE40", Offset = "0x8ACD440", VA = "0x188ACEE40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action PNAAIKBNICM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF330", Offset = "0x8ACD930", VA = "0x188ACF330", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8ACEF80", Offset = "0x8ACD580", VA = "0x188ACEF80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF3D0", Offset = "0x8ACD9D0", VA = "0x188ACF3D0")]
	public CHAPEAPOKBD([Optional] Action IOEPHKMNIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF0A0", Offset = "0x8ACD6A0", VA = "0x188ACF0A0")]
	public void JDPCENHCAFL(MBOPCPOPDEN IIBAGOMDFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF1D0", Offset = "0x8ACD7D0", VA = "0x188ACF1D0")]
	private void NDAONJNFBHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8ACEE30", Offset = "0x8ACD430", VA = "0x188ACEE30", Slot = "7")]
	public bool AODOIDJKNHK(bool KKBNDFNEENM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8ACEB20", Offset = "0x8ACD120", VA = "0x188ACEB20", Slot = "8")]
	public bool AODOIDJKNHK(Action CJDOILFHDJI, bool KKBNDFNEENM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF020", Offset = "0x8ACD620", VA = "0x188ACF020", Slot = "9")]
	public IEnumerator<MBOPCPOPDEN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF020", Offset = "0x8ACD620", VA = "0x188ACF020", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class GLPIAFJCAHC : LLDNCJOCKDO
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class PHBFKGAPKDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public GLPIAFJCAHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PHBFKGAPKDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDA30", Offset = "0x8ACC030", VA = "0x188ACDA30")]
		internal void INCPGMDJLHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class BMBOHJEKOBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public GLPIAFJCAHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BMBOHJEKOBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDA30", Offset = "0x8ACC030", VA = "0x188ACDA30")]
		internal void KKCCDFGEAFI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly float DMJNCFDEGDE;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8B90", Offset = "0x8AD7190", VA = "0x188AD8B90")]
	public GLPIAFJCAHC(Behaviour HILCMKALFIH, float DMJNCFDEGDE, [Optional] Action IOEPHKMNIKD, [Optional] PDDCOMLIBAI IEECLMDHIGH, [Optional] JCBBKHHODBE BPOEHGMMOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8DE0", Offset = "0x8AD73E0", VA = "0x188AD8DE0", Slot = "9")]
	protected override bool JDPFDKIJJDI(Action CJDOILFHDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8CD0", Offset = "0x8AD72D0", VA = "0x188AD8CD0", Slot = "10")]
	protected override bool FPMGGGAFCAA(Action CJDOILFHDJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface MBOPCPOPDEN
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool FJCFEMKFJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PNAAIKBNICM;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AODOIDJKNHK(bool KKBNDFNEENM = false);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AODOIDJKNHK(Action CJDOILFHDJI, bool KKBNDFNEENM = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class LLDNCJOCKDO : MBOPCPOPDEN
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JDBOEPNFAFI : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public LLDNCJOCKDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public JDBOEPNFAFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB3B0", Offset = "0x8AD99B0", VA = "0x188ADB3B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB480", Offset = "0x8AD9A80", VA = "0x188ADB480", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Behaviour HILCMKALFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action IOEPHKMNIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private BKFKILCGELM HEINEKOIIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly PDDCOMLIBAI IEECLMDHIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	protected readonly JCBBKHHODBE BPOEHGMMOJJ;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FJCFEMKFJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1BFAD70", Offset = "0x1BF9370", VA = "0x181BFAD70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PNAAIKBNICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE220", Offset = "0x8ADC820", VA = "0x188ADE220", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE010", Offset = "0x8ADC610", VA = "0x188ADE010", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE2C0", Offset = "0x8ADC8C0", VA = "0x188ADE2C0")]
	protected LLDNCJOCKDO(Behaviour HILCMKALFIH, [Optional] Action IOEPHKMNIKD, [Optional] PDDCOMLIBAI IEECLMDHIGH, [Optional] JCBBKHHODBE BPOEHGMMOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8ADDD60", Offset = "0x8ADC360", VA = "0x188ADDD60", Slot = "7")]
	public bool AODOIDJKNHK(bool KKBNDFNEENM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8ADDD00", Offset = "0x8ADC300", VA = "0x188ADDD00", Slot = "8")]
	public bool AODOIDJKNHK(Action CJDOILFHDJI, bool KKBNDFNEENM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool JDPFDKIJJDI(Action CJDOILFHDJI);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool FPMGGGAFCAA(Action CJDOILFHDJI);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE1C0", Offset = "0x8ADC7C0", VA = "0x188ADE1C0")]
	protected void HDFEEMHFJDJ(Action CJDOILFHDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8ADDDC0", Offset = "0x8ADC3C0", VA = "0x188ADDDC0")]
	protected NCBJFOCOMOJ BHNKLOLNOMO(float EMDIBPDBFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE0B0", Offset = "0x8ADC6B0", VA = "0x188ADE0B0")]
	private void EBEEFPDIHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE130", Offset = "0x8ADC730", VA = "0x188ADE130")]
	[IteratorStateMachine(typeof(JDBOEPNFAFI))]
	private IEnumerator<HPILNDONOCO> FGCPKGHAIIC(float EMDIBPDBFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE1E0", Offset = "0x8ADC7E0", VA = "0x188ADE1E0")]
	[CompilerGenerated]
	private void NCCMFACCGOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class CJOAGGMPDJK : LLDNCJOCKDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly float ALPHBGBNEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly int MCNKMAEMNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly float JBEPFPCOBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly float[] GLHHAHCIOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int JPILMEPEDLF;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACFA00", Offset = "0x8ACE000", VA = "0x188ACFA00")]
	public CJOAGGMPDJK(Behaviour HILCMKALFIH, float PHJPLMGENKC, int MCNKMAEMNFD, [Optional] Action IOEPHKMNIKD, float JBEPFPCOBLF = 0f, [Optional] PDDCOMLIBAI IEECLMDHIGH, [Optional] JCBBKHHODBE BPOEHGMMOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "9")]
	protected override bool JDPFDKIJJDI(Action CJDOILFHDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF780", Offset = "0x8ACDD80", VA = "0x188ACF780", Slot = "10")]
	protected override bool FPMGGGAFCAA(Action CJDOILFHDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF980", Offset = "0x8ACDF80", VA = "0x188ACF980")]
	private void JFBBAHDLNPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class GKNJOEMDBKM : LLDNCJOCKDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly float DMJNCFDEGDE;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8B90", Offset = "0x8AD7190", VA = "0x188AD8B90")]
	public GKNJOEMDBKM(Behaviour HILCMKALFIH, float DMJNCFDEGDE, [Optional] Action IOEPHKMNIKD, [Optional] PDDCOMLIBAI IEECLMDHIGH, [Optional] JCBBKHHODBE BPOEHGMMOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "9")]
	protected override bool JDPFDKIJJDI(Action CJDOILFHDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8B50", Offset = "0x8AD7150", VA = "0x188AD8B50", Slot = "10")]
	protected override bool FPMGGGAFCAA(Action CJDOILFHDJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class FFDODPNMLDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class EDCAAJBKNDA : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public EDCAAJBKNDA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4310", Offset = "0x8AD2910", VA = "0x188AD4310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4380", Offset = "0x8AD2980", VA = "0x188AD4380", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private LLKKGNCPLNM MDAJFKKCLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private LMKECBAEOAN HILCMKALFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Action<float> HNHEBIJJBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private DMJPLAHANAN KOJHBKBCLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private float EIDMPDEOMGK;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7FA0", Offset = "0x8AD65A0", VA = "0x188AD7FA0")]
	public FFDODPNMLDN(LMKECBAEOAN HILCMKALFIH, float BAOAKABBCIN, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7CB0", Offset = "0x8AD62B0", VA = "0x188AD7CB0")]
	private void IJLBGKFLKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7B80", Offset = "0x8AD6180", VA = "0x188AD7B80")]
	private void HCOAJLCOEJF(string NNDNCFBMBFL, Action CLEPEMFKBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7AA0", Offset = "0x8AD60A0", VA = "0x188AD7AA0")]
	[IteratorStateMachine(typeof(EDCAAJBKNDA))]
	private IEnumerator<HPILNDONOCO> BLIMCKNHNPC(Action CLEPEMFKBJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7B20", Offset = "0x8AD6120", VA = "0x188AD7B20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7E20", Offset = "0x8AD6420", VA = "0x188AD7E20")]
	[CompilerGenerated]
	private void PIIIAEFGHEL(string DHMKLCNLGMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class EPKDHBAANFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class JLJGLKPCLPJ : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public JLJGLKPCLPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4310", Offset = "0x8AD2910", VA = "0x188AD4310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCEA0", Offset = "0x8ADB4A0", VA = "0x188ADCEA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private LLKKGNCPLNM MDAJFKKCLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private MonoBehaviour NCBHPDBBCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Action LIDCEJNLILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Action<float> HNHEBIJJBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private DMJPLAHANAN KOJHBKBCLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float EIDMPDEOMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool NJDMNMGJAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly PDDCOMLIBAI IEECLMDHIGH;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6F70", Offset = "0x8AD5570", VA = "0x188AD6F70")]
	public EPKDHBAANFJ(MonoBehaviour NCBHPDBBCIG, Action LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, [Optional] PDDCOMLIBAI IEECLMDHIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6BC0", Offset = "0x8AD51C0", VA = "0x188AD6BC0")]
	public EPKDHBAANFJ(MonoBehaviour NCBHPDBBCIG, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, [Optional] PDDCOMLIBAI IEECLMDHIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6D90", Offset = "0x8AD5390", VA = "0x188AD6D90")]
	public EPKDHBAANFJ(MonoBehaviour NCBHPDBBCIG, float BAOAKABBCIN, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, bool NJDMNMGJAJK = true, [Optional] PDDCOMLIBAI IEECLMDHIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4ED4790", Offset = "0x4ED2D90", VA = "0x184ED4790")]
	private EPKDHBAANFJ(PDDCOMLIBAI IEECLMDHIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5F90", Offset = "0x8AD4590", VA = "0x188AD5F90")]
	internal static EPKDHBAANFJ BHGHKHPAIOK(MonoBehaviour NCBHPDBBCIG, float BAOAKABBCIN, Action<float> LIDCEJNLILH, DMJPLAHANAN KOJHBKBCLJD, bool NJDMNMGJAJK = true, [Optional] PDDCOMLIBAI IEECLMDHIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6A00", Offset = "0x8AD5000", VA = "0x188AD6A00")]
	private void MBPDPGJGNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6880", Offset = "0x8AD4E80", VA = "0x188AD6880")]
	private void LDJAKKIHIIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6680", Offset = "0x8AD4C80", VA = "0x188AD6680")]
	private void IJLBGKFLKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8AD62D0", Offset = "0x8AD48D0", VA = "0x188AD62D0")]
	private void CHECNBGBDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6550", Offset = "0x8AD4B50", VA = "0x188AD6550")]
	private void HCOAJLCOEJF(string NNDNCFBMBFL, Action CLEPEMFKBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6250", Offset = "0x8AD4850", VA = "0x188AD6250")]
	[IteratorStateMachine(typeof(JLJGLKPCLPJ))]
	private IEnumerator<HPILNDONOCO> BLIMCKNHNPC(Action CLEPEMFKBJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8AD64F0", Offset = "0x8AD4AF0", VA = "0x188AD64F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8AD67F0", Offset = "0x8AD4DF0", VA = "0x188AD67F0")]
	[CompilerGenerated]
	private void JFDHDDHAJAP(string DHMKLCNLGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8AD61C0", Offset = "0x8AD47C0", VA = "0x188AD61C0")]
	[CompilerGenerated]
	private void BHGNEPLBKOE(string DHMKLCNLGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6B30", Offset = "0x8AD5130", VA = "0x188AD6B30")]
	[CompilerGenerated]
	private void OBOHKMEIOGM(string DHMKLCNLGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6460", Offset = "0x8AD4A60", VA = "0x188AD6460")]
	[CompilerGenerated]
	private void COFGKJPAMOH(string DHMKLCNLGMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum BCOBMOKPOOC : byte
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
internal sealed class EALJECBHFCH : JCBBKHHODBE
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float EDNAKNOMGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4280", Offset = "0x8AD2880", VA = "0x188AD4280", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float NKHDOIEODPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4290", Offset = "0x8AD2890", VA = "0x188AD4290", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public double LFHKKJEKKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4260", Offset = "0x8AD2860", VA = "0x188AD4260", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8AD42A0", Offset = "0x8AD28A0", VA = "0x188AD42A0")]
	[BNHIEDNKDNA.MLFEBCDGLFC]
	internal static void PCDILHPDLBD(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	[UnityEngine.Scripting.Preserve]
	internal EALJECBHFCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface NMHICHLCCEG
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADJLGFILFBL(string IEDAJGLJHNI);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLEJHPEALDA();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface EEGGMOAHHGK
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool JNHKEEAMOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool JJGHHKELEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class APONODDPMKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public ALNHFLMFHJB MGLEBPOBFCL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int BPENJJIEFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD790", Offset = "0x8ACBD90", VA = "0x188ACD790")]
	public static HPILNDONOCO MPLJGNCBMKE(IEnumerator<HPILNDONOCO> NGHBCLFPMFA, MBMGENCKCMF ENPLACLNBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD6D0", Offset = "0x8ACBCD0", VA = "0x188ACD6D0")]
	public HPILNDONOCO MPLJGNCBMKE(MBMGENCKCMF[] ECCDEOFIEDH, IEnumerator<HPILNDONOCO>[] HLLLOBCHJIB, HPILNDONOCO[] GKGCIKNIINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD560", Offset = "0x8ACBB60", VA = "0x188ACD560")]
	public void MHAOIGDJAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD590", Offset = "0x8ACBB90", VA = "0x188ACD590")]
	public void KDOCCEIAECF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD8F0", Offset = "0x8ACBEF0", VA = "0x188ACD8F0")]
	public void NPHPFMEPHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD560", Offset = "0x8ACBB60", VA = "0x188ACD560")]
	public void FJGIFBPLLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public APONODDPMKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class ALNHFLMFHJB
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct PJMOODLJHLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public APONODDPMKM PIIJJJCBLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public LMKECBAEOAN FCCIBPJCEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public MBMGENCKCMF GFPMJLAJEOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public IEnumerator<HPILNDONOCO> DPLECMEGEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public HPILNDONOCO LKJCFJENIDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public BCOBMOKPOOC NBJPDMLHBAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct GGJAGAPFHJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public DMJPLAHANAN MFHCLGBOJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public List<PJMOODLJHLE> HJJIKACHCOK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class JLLPJBLNLHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public MBMGENCKCMF promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public ALNHFLMFHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public LMKECBAEOAN context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public APONODDPMKM routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public BCOBMOKPOOC coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public HPILNDONOCO currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public IEnumerator<HPILNDONOCO> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JLLPJBLNLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCEF0", Offset = "0x8ADB4F0", VA = "0x188ADCEF0")]
		internal void PCJLHBIFFCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class DMEJPAMIJNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public APONODDPMKM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public ALNHFLMFHJB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DMEJPAMIJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4020", Offset = "0x8AD2620", VA = "0x188AD4020")]
		internal void PLPLNHNJEKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class IGLOEDPCEBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public APONODDPMKM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public ALNHFLMFHJB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public IGLOEDPCEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8ADAA30", Offset = "0x8AD9030", VA = "0x188ADAA30")]
		internal void KJMAAALFGHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class NKIGBMODABB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public APONODDPMKM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public ALNHFLMFHJB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NKIGBMODABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF030", Offset = "0x8ADD630", VA = "0x188ADF030")]
		internal void BOANFKGHHHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private const BCOBMOKPOOC EMMMJEFKNNE = BCOBMOKPOOC.Cancelled | BCOBMOKPOOC.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly DMJPLAHANAN KOJHBKBCLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool[] MMBECCFKGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private NativeArray<BCOBMOKPOOC> CCIINNFPKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NativeArray<float> HJKKPPPKCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private NativeArray<int> GIGGIEAJMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private NativeArray<int> FJBDHLBMHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private NativeArray<int> CHLIOEENGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NativeArray<int> EGEKOPNJEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private NativeArray<int> DGNLPGIOCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private APONODDPMKM[] MIIAGAFAGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private MBMGENCKCMF[] ECCDEOFIEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private LMKECBAEOAN[] PGHIFDCLAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private IEnumerator<HPILNDONOCO>[] KKNOAFKMIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private HPILNDONOCO[] KNDOKBODLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int FDCJCPMDPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int BJPLKLLFDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly int AHOJNIBNPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private float JBFNAPBOOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private INPHLIAGCOC LFMMLPDNLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private JobHandle GKHBGGABLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private List<APONODDPMKM> PEIEHFIDAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool AKJJEGNOKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private List<Action> JNFMGLHHAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> OAKGHEBAOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool DLGDKMKGABI;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GGJAGAPFHJF[] NHMIEILEGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xB5F020", Offset = "0xB5D620", VA = "0x180B5F020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8ACC220", Offset = "0x8ACA820", VA = "0x188ACC220")]
	private static int EIHOEHCLDGO(DMJPLAHANAN KOJHBKBCLJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8ACCD30", Offset = "0x8ACB330", VA = "0x188ACCD30")]
	public ALNHFLMFHJB(DMJPLAHANAN KOJHBKBCLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8ACC040", Offset = "0x8ACA640", VA = "0x188ACC040")]
	private void EBACGKODKJE(int GFBCBMEGFIP, int LIKMMIKJMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACC250", Offset = "0x8ACA850", VA = "0x188ACC250")]
	public void FAHMIJPMBPK(LMKECBAEOAN HILCMKALFIH, HPILNDONOCO DAPKHALPFOE, IEnumerator<HPILNDONOCO> NGHBCLFPMFA, MBMGENCKCMF ENPLACLNBKG, [Optional] APONODDPMKM MDANDKLNHPI, BCOBMOKPOOC LAFKDMAMMGM = BCOBMOKPOOC.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8ACBD00", Offset = "0x8ACA300", VA = "0x188ACBD00")]
	public void DHNNHIIHAMD(IEnumerable<PJMOODLJHLE> NFBGDFHNDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA9A0", Offset = "0x8AC8FA0", VA = "0x188ACA9A0")]
	private PJMOODLJHLE ABBPEHILDDK(int BFCHEFFENMA)
	{
		return default(PJMOODLJHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8ACB790", Offset = "0x8AC9D90", VA = "0x188ACB790")]
	private void DCAADNKBKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x30BC100", Offset = "0x30BA700", VA = "0x1830BC100")]
	private static void AKLAMNCMBMA<T>(int BFCHEFFENMA, T[] KLPFNDAPDEO, int GPNBMIDFKMK, [Optional] T OJONBNFDGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x30BC150", Offset = "0x30BA750", VA = "0x1830BC150")]
	private static void AKLAMNCMBMA<T>(int BFCHEFFENMA, NativeArray<T> KLPFNDAPDEO, int GPNBMIDFKMK, [Optional] T OJONBNFDGDG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8ACC6B0", Offset = "0x8ACACB0", VA = "0x188ACC6B0")]
	private void MPAFGOGEOIL(IEnumerable<PJMOODLJHLE> NFBGDFHNDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8ACB590", Offset = "0x8AC9B90", VA = "0x188ACB590")]
	private void BPCAJAIOEMF(PJMOODLJHLE KHDLLILFONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8ACCAD0", Offset = "0x8ACB0D0", VA = "0x188ACCAD0")]
	private ALPDAMOFGCE PENPDMDHEOM(int JNKLPHJHGIN)
	{
		return default(ALPDAMOFGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8ACBB00", Offset = "0x8ACA100", VA = "0x188ACBB00")]
	public void DELHICDNIAL(float IFOFMMNOBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8ACCA50", Offset = "0x8ACB050", VA = "0x188ACCA50")]
	private void PCMOLOKAPEJ(Action DLGEPLKGJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8ACC500", Offset = "0x8ACAB00", VA = "0x188ACC500")]
	private void GPJAAMALPBC(Action DLGEPLKGJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8ACAE70", Offset = "0x8AC9470", VA = "0x188ACAE70")]
	public void ALOFPMILFLI(float IFOFMMNOBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8ACBF40", Offset = "0x8ACA540", VA = "0x188ACBF40")]
	public void DIGOPEEDGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8ACC3D0", Offset = "0x8ACA9D0", VA = "0x188ACC3D0")]
	public void FJGIFBPLLNO(APONODDPMKM OHJOIDNHJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8ACB660", Offset = "0x8AC9C60", VA = "0x188ACB660")]
	public void CFLDODKGCNL(APONODDPMKM OHJOIDNHJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACC580", Offset = "0x8ACAB80", VA = "0x188ACC580")]
	public void LJAAIEMGHEJ(APONODDPMKM OHJOIDNHJLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class MLFLPKCNMKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly MLFLPKCNMKG PBMJKPJDLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly Action LJIEFCNIMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private bool IPJFEJDAGIO;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public MLFLPKCNMKG(Action LJIEFCNIMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8111570", Offset = "0x810FB70", VA = "0x188111570", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface LDOJAOKHKFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable EEDGINCGPNC(UnityEngine.Object HILCMKALFIH, Action<T> JDEFAHBCIEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface FPDBLECEJNG<T> : LDOJAOKHKFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	new T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class BFAKOCJFMBJ<T> : FPDBLECEJNG<T>, LDOJAOKHKFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class CJINLMKNEEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public BFAKOCJFMBJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public HCBJPMIGAKP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CJINLMKNEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6877060", Offset = "0x6875660", VA = "0x186877060")]
		internal void JLKEFCGDIPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static GameObject NOIMOBINNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly List<HCBJPMIGAKP<UnityEngine.Object, Action<T>>> BIGEIIIEALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private T PNGCMLBPNFM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D80", Offset = "0xAA4380", VA = "0x180AA5D80", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x614FA20", Offset = "0x614E020", VA = "0x18614FA20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x614F600", Offset = "0x614DC00", VA = "0x18614F600")]
	private static bool CAJFAMBFAAG(T DLGEPLKGJOC, T OKKFDNDPGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6150230", Offset = "0x614E830", VA = "0x186150230")]
	public BFAKOCJFMBJ(T ALPLAIPHAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x614F700", Offset = "0x614DD00", VA = "0x18614F700", Slot = "6")]
	public IDisposable EEDGINCGPNC(UnityEngine.Object HILCMKALFIH, Action<T> JDEFAHBCIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x614FB20", Offset = "0x614E120", VA = "0x18614FB20")]
	private void OABDAHEDPJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class HBCOFIAMDEO : MEIHBANPFAL
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private class OODAKMAMLJJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		private class GFIDBJFJHGH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private int HLIPPIOIAJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private OODAKMAMLJJ CDDEFPCECLM;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xF84950", Offset = "0xF82F50", VA = "0x180F84950")]
			public GFIDBJFJHGH(int HLIPPIOIAJK, OODAKMAMLJJ CDDEFPCECLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8B20", Offset = "0x8AD7120", VA = "0x188AD8B20", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class FHMKFNLHNAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public FHMKFNLHNAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xABB800", Offset = "0xAB9E00", VA = "0x180ABB800")]
			internal bool KPECCMGHEOO(MBGNDHHMHEI e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class JLHEOBINLIM : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private HPILNDONOCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public OODAKMAMLJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public JCBBKHHODBE timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			private MBHKNGKKHLI <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private List<MBGNDHHMHEI> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
			[DebuggerHidden]
			public JLHEOBINLIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x8ADCB20", Offset = "0x8ADB120", VA = "0x188ADCB20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8ADCE50", Offset = "0x8ADB450", VA = "0x188ADCE50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly DMJPLAHANAN KOJHBKBCLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private LLKKGNCPLNM ENPLACLNBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly List<MBGNDHHMHEI> GBIHKBDEEEC;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF670", Offset = "0x8ADDC70", VA = "0x188ADF670")]
		public OODAKMAMLJJ(DMJPLAHANAN KOJHBKBCLJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF4E0", Offset = "0x8ADDAE0", VA = "0x188ADF4E0")]
		public IDisposable MEIGKFIGEHK(MBGNDHHMHEI PDJCJIFGPBJ, PDDCOMLIBAI IEECLMDHIGH, JCBBKHHODBE GPIJGKLDGAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF270", Offset = "0x8ADD870", VA = "0x188ADF270")]
		private void AAAEMIHEFNN(int HLIPPIOIAJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF400", Offset = "0x8ADDA00", VA = "0x188ADF400")]
		[IteratorStateMachine(typeof(JLHEOBINLIM))]
		private IEnumerator<HPILNDONOCO> DAPGBIHAAMF(JCBBKHHODBE GPIJGKLDGAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF490", Offset = "0x8ADDA90", VA = "0x188ADF490", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class MBGNDHHMHEI
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public enum EKEIAJPACIP : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static int CCGAGHAKHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly int NJJOPPIMCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly ODGGGLKDEEB FCCIBPJCEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly MonoBehaviour LLNKGDNDANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly Action IEMAIHNOLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly Action<float> KKDJMDBJPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly float FJCAEJKKOCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public float HJKKPPPKCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public readonly string GKIMNFGPLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public readonly bool CALHNNDAJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly EKEIAJPACIP PHELHGMJBOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool ICEAEEAKFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public bool OFHBFLJMFJP;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE5C0", Offset = "0x8ADCBC0", VA = "0x188ADE5C0")]
		public MBGNDHHMHEI(ODGGGLKDEEB HILCMKALFIH, Action LIDCEJNLILH, bool GNDLMODHBAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE920", Offset = "0x8ADCF20", VA = "0x188ADE920")]
		public MBGNDHHMHEI(ODGGGLKDEEB HILCMKALFIH, Action<float> LIDCEJNLILH, bool GNDLMODHBAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE740", Offset = "0x8ADCD40", VA = "0x188ADE740")]
		public MBGNDHHMHEI(ODGGGLKDEEB HILCMKALFIH, float BAOAKABBCIN, Action<float> LIDCEJNLILH, JCBBKHHODBE GPIJGKLDGAC, EKEIAJPACIP GBMAGHFHPDE, bool NJDMNMGJAJK, bool GNDLMODHBAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE3F0", Offset = "0x8ADC9F0", VA = "0x188ADE3F0")]
		public bool KFKCONMGDFB(float PHDJLKIIBIL, float MMEJKCJEAIB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly PDDCOMLIBAI IEECLMDHIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly JCBBKHHODBE BPOEHGMMOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly Dictionary<DMJPLAHANAN, OODAKMAMLJJ> CILOOHOEBBF;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9620", Offset = "0x8AD7C20", VA = "0x188AD9620")]
	[BNHIEDNKDNA.MLFEBCDGLFC]
	internal static void LHELJBBANLP(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9C10", Offset = "0x8AD8210", VA = "0x188AD9C10")]
	[UnityEngine.Scripting.Preserve]
	internal HBCOFIAMDEO([GGNLMCAPMLP(null)] PDDCOMLIBAI IEECLMDHIGH, [GGNLMCAPMLP(null)] JCBBKHHODBE BPOEHGMMOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9430", Offset = "0x8AD7A30", VA = "0x188AD9430", Slot = "4")]
	public IDisposable IEMAIHNOLMJ(ODGGGLKDEEB HILCMKALFIH, Action BNOBGIHHJGL, DMJPLAHANAN KOJHBKBCLJD, bool GNDLMODHBAN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9240", Offset = "0x8AD7840", VA = "0x188AD9240", Slot = "5")]
	public IDisposable IEMAIHNOLMJ(ODGGGLKDEEB HILCMKALFIH, Action<float> BNOBGIHHJGL, DMJPLAHANAN KOJHBKBCLJD, bool GNDLMODHBAN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x8AD99D0", Offset = "0x8AD7FD0", VA = "0x188AD99D0", Slot = "7")]
	public IDisposable OBOAKNLKDAH(ODGGGLKDEEB HILCMKALFIH, float BAOAKABBCIN, Action<float> BNOBGIHHJGL, DMJPLAHANAN KOJHBKBCLJD, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9140", Offset = "0x8AD7740", VA = "0x188AD9140", Slot = "8")]
	public IDisposable EKIIBIOFAEL(ODGGGLKDEEB HILCMKALFIH, float BAOAKABBCIN, Action<float> BNOBGIHHJGL, DMJPLAHANAN KOJHBKBCLJD, bool NJDMNMGJAJK = true, bool GNDLMODHBAN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9850", Offset = "0x8AD7E50", VA = "0x188AD9850", Slot = "6")]
	public IDisposable OBOAKNLKDAH(float BAOAKABBCIN, Action<float> BNOBGIHHJGL, bool NJDMNMGJAJK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9690", Offset = "0x8AD7C90", VA = "0x188AD9690", Slot = "9")]
	public void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9AD0", Offset = "0x8AD80D0", VA = "0x188AD9AD0")]
	private OODAKMAMLJJ POHJKGJBIMC(DMJPLAHANAN KOJHBKBCLJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PGOHBFGDPOP : JDNBDBDBCJK, PDDCOMLIBAI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private ALNHFLMFHJB[] OKHFBAIBFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NMHICHLCCEG OEEGDPLFBJG;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0DB0", Offset = "0x8ADF3B0", VA = "0x188AE0DB0")]
	[BNHIEDNKDNA.MLFEBCDGLFC]
	internal static void PCDILHPDLBD(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0E20", Offset = "0x8ADF420", VA = "0x188AE0E20")]
	[UnityEngine.Scripting.Preserve]
	public PGOHBFGDPOP([GGNLMCAPMLP(null)] MHOEFBKOPDF JGPJINKPDAG, [GGNLMCAPMLP(null)] JCBBKHHODBE BPOEHGMMOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8AE02E0", Offset = "0x8ADE8E0", VA = "0x188AE02E0", Slot = "19")]
	public override LLKKGNCPLNM ECKNDIHKIAB(LMKECBAEOAN HILCMKALFIH, IEnumerator<HPILNDONOCO> CDJNIODFBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8AE08F0", Offset = "0x8ADEEF0", VA = "0x188AE08F0", Slot = "20")]
	public override void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0B80", Offset = "0x8ADF180", VA = "0x188AE0B80", Slot = "22")]
	public override void OEHKEKEAJFG(DMJPLAHANAN KOJHBKBCLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8AE04D0", Offset = "0x8ADEAD0", VA = "0x188AE04D0", Slot = "21")]
	protected override void IEMAIHNOLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0250", Offset = "0x8ADE850", VA = "0x188AE0250")]
	private ALNHFLMFHJB BBNFCDJDJKF(DMJPLAHANAN JLPANLJHHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x8AE05A0", Offset = "0x8ADEBA0", VA = "0x188AE05A0", Slot = "23")]
	internal override CDENGJCCAKF IHLHKHLJJKG(IEnumerator<HPILNDONOCO> CDJNIODFBGI, Behaviour HILCMKALFIH, MBMGENCKCMF ENPLACLNBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0410", Offset = "0x8ADEA10", VA = "0x188AE0410", Slot = "24")]
	internal override EIEPBFIPACB FEHICPLAGMH(DMJPLAHANAN CDDEFPCECLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8AE07D0", Offset = "0x8ADEDD0", VA = "0x188AE07D0")]
	private void LELJAODIPCB(ALNHFLMFHJB OBFEIBJEKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0280", Offset = "0x8ADE880", VA = "0x188AE0280", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[BurstCompile]
internal struct INPHLIAGCOC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	[ReadOnly]
	public float KGEKLFKBGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	[ReadOnly]
	public int MOHJDABNBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private NativeArray<int> GDBIONGPMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private NativeArray<int> LGBEBKHCOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private NativeArray<int> DLCFCICCPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	[ReadOnly]
	public NativeArray<BCOBMOKPOOC> OFFMGACELHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[ReadOnly]
	public NativeArray<float> IKNABJLHJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	[WriteOnly]
	public NativeArray<int> CHLIOEENGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	[WriteOnly]
	public NativeArray<int> GIGGIEAJMBH;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB2B0", Offset = "0x8AD98B0", VA = "0x188ADB2B0")]
	public static INPHLIAGCOC MMBKOMPANAO(int JELLOLDHDBM, float IFOFMMNOBPH, NativeArray<BCOBMOKPOOC> FELBFHFLJGE, NativeArray<float> DGHFGEPDHON, NativeArray<int> DCPGBFLANPK, NativeArray<int> PCGOBPPGNGM, NativeArray<int> AJKHBJGMMJE, NativeArray<int> LGBEBKHCOMF, NativeArray<int> DLCFCICCPJK)
	{
		return default(INPHLIAGCOC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB090", Offset = "0x8AD9690", VA = "0x188ADB090", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB270", Offset = "0x8AD9870", VA = "0x188ADB270")]
	private bool LLCLBBEANJO(int KHMHPNKMLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB240", Offset = "0x8AD9840", VA = "0x188ADB240")]
	private void KBHPFLEGFEO(NativeArray<int> BNCKDHIBPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB310", Offset = "0x8AD9910", VA = "0x188ADB310")]
	private int OFIEHPCKGJL(int DKLPAIPBKGC, int KPLPIBOJLGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB170", Offset = "0x8AD9770", VA = "0x188ADB170")]
	private void FMKOIEJAJBP(NativeArray<int> BNCKDHIBPEL, int IJHPAEKGGEJ, int GBHEJJJMLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8ADAE50", Offset = "0x8AD9450", VA = "0x188ADAE50")]
	private void AEOOAPCCDLJ(NativeArray<int> BNCKDHIBPEL, int JCFGIIIMJCP, int HJNJPEPJOFG, int KCNCKOCAOLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class JDNBDBDBCJK : PDDCOMLIBAI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly MHOEFBKOPDF JGPJINKPDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	protected readonly JCBBKHHODBE BPOEHGMMOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private EIEPBFIPACB[] KFDGPADCCNO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static PDDCOMLIBAI FNIBPMLJKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC220", Offset = "0x8ADA820", VA = "0x188ADC220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool ICKKICKDNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DMJPLAHANAN IMDDHCDKMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(DMJPLAHANAN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JCBBKHHODBE OIEOPLNPNME
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HPILNDONOCO LHMEMPNGJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public HPILNDONOCO ICAOCNDKHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public HPILNDONOCO ODCDPEOFMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HPILNDONOCO EKCJKMMMGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC380", Offset = "0x8ADA980", VA = "0x188ADC380")]
	public static LLKKGNCPLNM OHKBBGAABHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC430", Offset = "0x8ADAA30", VA = "0x188ADC430")]
	[UnityEngine.Scripting.Preserve]
	protected JDNBDBDBCJK([GGNLMCAPMLP(null)] MHOEFBKOPDF JGPJINKPDAG, [GGNLMCAPMLP(null)] JCBBKHHODBE BPOEHGMMOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8ADBA20", Offset = "0x8ADA020", VA = "0x188ADBA20", Slot = "6")]
	public LLKKGNCPLNM JNJJALJCEOA(IEnumerator<HPILNDONOCO> CDJNIODFBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8ADBA30", Offset = "0x8ADA030", VA = "0x188ADBA30", Slot = "7")]
	public LLKKGNCPLNM JNJJALJCEOA(Behaviour HILCMKALFIH, IEnumerator<HPILNDONOCO> CDJNIODFBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract LLKKGNCPLNM ECKNDIHKIAB(LMKECBAEOAN HILCMKALFIH, IEnumerator<HPILNDONOCO> CDJNIODFBGI);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8ADBEB0", Offset = "0x8ADA4B0", VA = "0x188ADBEB0", Slot = "20")]
	public virtual void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8ADBC50", Offset = "0x8ADA250", VA = "0x188ADBC50", Slot = "9")]
	public void KOLOPMPGDIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB970", Offset = "0x8AD9F70", VA = "0x188ADB970", Slot = "21")]
	protected virtual void IEMAIHNOLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB950", Offset = "0x8AD9F50", VA = "0x188ADB950")]
	private void FONIHAKGKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x8ADBE90", Offset = "0x8ADA490", VA = "0x188ADBE90")]
	private void LKLBPKIIKJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB930", Offset = "0x8AD9F30", VA = "0x188ADB930")]
	private void EFBLPCPGKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB550", Offset = "0x8AD9B50", VA = "0x188ADB550")]
	private void CNKCKOCHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8ADBC30", Offset = "0x8ADA230", VA = "0x188ADBC30")]
	private void KNLDHNGHPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC410", Offset = "0x8ADAA10", VA = "0x188ADC410")]
	private void PCDMOMDNAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB4D0", Offset = "0x8AD9AD0", VA = "0x188ADB4D0")]
	private void CHMGLEGBFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC2F0", Offset = "0x8ADA8F0", VA = "0x188ADC2F0", Slot = "22")]
	public virtual void OEHKEKEAJFG(DMJPLAHANAN KOJHBKBCLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC050", Offset = "0x8ADA650", VA = "0x188ADC050")]
	private void MLLABFNKJCF(EIEPBFIPACB OBFEIBJEKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2854970", Offset = "0x2852F70", VA = "0x182854970")]
	private EIEPBFIPACB KEJGFKDMICK(DMJPLAHANAN JLPANLJHHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract CDENGJCCAKF IHLHKHLJJKG(IEnumerator<HPILNDONOCO> CDJNIODFBGI, Behaviour NCBHPDBBCIG, MBMGENCKCMF NOKMEONDPNA);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract EIEPBFIPACB FEHICPLAGMH(DMJPLAHANAN KOJHBKBCLJD);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB570", Offset = "0x8AD9B70", VA = "0x188ADB570", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC290", Offset = "0x8ADA890", VA = "0x188ADC290", Slot = "15")]
	public HPILNDONOCO NFPIOBAKKOK(DMJPLAHANAN CDDEFPCECLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB990", Offset = "0x8AD9F90", VA = "0x188ADB990", Slot = "16")]
	public HPILNDONOCO JCMJONIMLNO(float BKONJIDKCPP, DMJPLAHANAN CDDEFPCECLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB4F0", Offset = "0x8AD9AF0", VA = "0x188ADB4F0", Slot = "17")]
	public HPILNDONOCO CIJAHPKACLP(Func<bool> KCEOCGICBLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class CDENGJCCAKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly MBMGENCKCMF ENPLACLNBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly EEGGMOAHHGK HILCMKALFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly bool ALMGHOMDHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private string IEDAJGLJHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private StackTrace DBMHNEIHPEF;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerator<HPILNDONOCO> DPLECMEGEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public HPILNDONOCO LKJCFJENIDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool EDJALNGMGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDF00", Offset = "0x8ACC500", VA = "0x188ACDF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool BIPGODAHCDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xCCADB0", Offset = "0xCC93B0", VA = "0x180CCADB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xCFFB40", Offset = "0xCFE140", VA = "0x180CFFB40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8ACDF80", Offset = "0x8ACC580", VA = "0x188ACDF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float EAAOJMJCENG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xE40EB0", Offset = "0xE3F4B0", VA = "0x180E40EB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xE40EC0", Offset = "0xE3F4C0", VA = "0x180E40EC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8ACE5F0", Offset = "0x8ACCBF0", VA = "0x188ACE5F0")]
	public CDENGJCCAKF(IEnumerator<HPILNDONOCO> NGHBCLFPMFA, EEGGMOAHHGK HILCMKALFIH, MBMGENCKCMF ENPLACLNBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8ACE1F0", Offset = "0x8ACC7F0", VA = "0x188ACE1F0")]
	public HPILNDONOCO MPLJGNCBMKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8ACE130", Offset = "0x8ACC730", VA = "0x188ACE130")]
	public bool DHLLIBPMLNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8ACE1A0", Offset = "0x8ACC7A0", VA = "0x188ACE1A0")]
	public void FJGIFBPLLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8ACE510", Offset = "0x8ACCB10", VA = "0x188ACE510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0xD43C80", Offset = "0xD42280", VA = "0x180D43C80")]
	[CompilerGenerated]
	private void PFNJIBCALFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class MBMGENCKCMF : NILILCPOKMK, LLKKGNCPLNM, BKFKILCGELM, NCBJFOCOMOJ, IEnumerator, HPILNDONOCO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private DMJPLAHANAN NFJGKBKNKLB;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private DMJPLAHANAN IFJFNOAAAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xE2A530", Offset = "0xE28B30", VA = "0x180E2A530", Slot = "23")]
		get
		{
			return default(DMJPLAHANAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DMJPLAHANAN MGLEBPOBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xFCF620", Offset = "0xFCDC20", VA = "0x180FCF620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private float HCKEFMAHHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA9F120", Offset = "0xA9D720", VA = "0x180A9F120", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool MOIHMLGPNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8ADEAB0", Offset = "0x8ADD0B0", VA = "0x188ADEAB0", Slot = "24")]
	private bool LPHLLEOLJEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8ADEAA0", Offset = "0x8ADD0A0", VA = "0x188ADEAA0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8ADEAD0", Offset = "0x8ADD0D0", VA = "0x188ADEAD0")]
	public MBMGENCKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal enum ALPDAMOFGCE : byte
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
internal sealed class EIEPBFIPACB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum MBALLGOAKOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public struct LGJLPOBJLKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public DMJPLAHANAN MFHCLGBOJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public MBALLGOAKOG LPPKCIKBOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public List<CDENGJCCAKF> MCCPBIJGKCK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly MBALLGOAKOG[] FBDAHGHAOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly DMJPLAHANAN KOJHBKBCLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private bool LIOMCIHMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly CDENGJCCAKF[] GOLNLIGBAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<CDENGJCCAKF> OFPDGFPKGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly Stack<int> KMKKDICINGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly List<CDENGJCCAKF> BDMAENHGGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly Stack<int> CBKLLONGEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly NMHICHLCCEG CHLJKIFNHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private bool DLGDKMKGABI;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public LGJLPOBJLKD[,] JFDHHMNBCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5AF0", Offset = "0x8AD40F0", VA = "0x188AD5AF0")]
	public EIEPBFIPACB(DMJPLAHANAN CDDEFPCECLM, NMHICHLCCEG CHLJKIFNHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8AD58B0", Offset = "0x8AD3EB0", VA = "0x188AD58B0")]
	public void POJNEOODKPD(CDENGJCCAKF NGHBCLFPMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4AA0", Offset = "0x8AD30A0", VA = "0x188AD4AA0")]
	public void DMLKPPLIHGN(IList<CDENGJCCAKF> HLLLOBCHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4EB0", Offset = "0x8AD34B0", VA = "0x188AD4EB0")]
	public void EKHBJPOBJCH(IList<CDENGJCCAKF> HLLLOBCHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8AD51A0", Offset = "0x8AD37A0", VA = "0x188AD51A0")]
	private void EKLJGAHMOIF(CDENGJCCAKF NGHBCLFPMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8AD45C0", Offset = "0x8AD2BC0", VA = "0x188AD45C0")]
	private void AOLMIJIAIKN(IList<CDENGJCCAKF> HLLLOBCHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8AD55F0", Offset = "0x8AD3BF0", VA = "0x188AD55F0")]
	private ALPDAMOFGCE LLCFEMNCNGO(CDENGJCCAKF NGHBCLFPMFA)
	{
		return default(ALPDAMOFGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5290", Offset = "0x8AD3890", VA = "0x188AD5290")]
	public void IEMAIHNOLMJ(float IFOFMMNOBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5400", Offset = "0x8AD3A00", VA = "0x188AD5400")]
	public void KOLOPMPGDIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4740", Offset = "0x8AD2D40", VA = "0x188AD4740")]
	private void BAONMGPFOKM(List<CDENGJCCAKF> HLLLOBCHJIB, Stack<int> FDMKKAKNOPP, bool CCDIJOMJNOO, float LAEJKIPOMPN = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4D90", Offset = "0x8AD3390", VA = "0x188AD4D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5770", Offset = "0x8AD3D70", VA = "0x188AD5770")]
	private void NAKNKOJDFIH(List<CDENGJCCAKF> HLLLOBCHJIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal class LNFCBNDJGPG : NMHICHLCCEG
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void ADJLGFILFBL(string IEDAJGLJHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
	public void BLEJHPEALDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public LNFCBNDJGPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal class CGGLAGFDBPM : EEGGMOAHHGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly Behaviour NCBHPDBBCIG;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8ACEA30", Offset = "0x8ACD030", VA = "0x188ACEA30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JNHKEEAMOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8ACEAB0", Offset = "0x8ACD0B0", VA = "0x188ACEAB0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JJGHHKELEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8ACEB00", Offset = "0x8ACD100", VA = "0x188ACEB00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public CGGLAGFDBPM(Behaviour NCBHPDBBCIG)
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

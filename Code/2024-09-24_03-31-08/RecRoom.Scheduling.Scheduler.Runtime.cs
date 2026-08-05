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
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74F7350", Offset = "0x74F5D50", VA = "0x1874F7350", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
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
		private delegate List<PlayerLoopSystem> DCEKOMCGMFC(List<PlayerLoopSystem> JGKGABKKGOI, int JAMKPDBHHPO);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct DKKILCFFADD
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct MHPILHNODED
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static BPJHNJKJMPB KMFIAJOLDCL;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x74F1980", Offset = "0x74F0380", VA = "0x1874F1980")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct FABNFMNALMI
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static BPJHNJKJMPB GNAAKFGIIIH;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x74E7470", Offset = "0x74E5E70", VA = "0x1874E7470")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct DLJHJGAMKED
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static BPJHNJKJMPB OFPBNKACAIN;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x74E3FE0", Offset = "0x74E29E0", VA = "0x1874E3FE0")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct BJAONDEFAJO
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static BPJHNJKJMPB BHPGNEMCNKI;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static BPJHNJKJMPB CGOFDHPLOOI;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static BPJHNJKJMPB PFGLOAPKAIA;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static BPJHNJKJMPB OGHEPJDLNHI;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x74DE380", Offset = "0x74DCD80", VA = "0x1874DE380")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct AMGHEAFDEDA
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static BPJHNJKJMPB GIKAHIDFNFH;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x74DCA40", Offset = "0x74DB440", VA = "0x1874DCA40")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct PAOBPIEADPG
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static BPJHNJKJMPB BHPGNEMCNKI;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static BPJHNJKJMPB CGOFDHPLOOI;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static BPJHNJKJMPB PFGLOAPKAIA;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static BPJHNJKJMPB OGHEPJDLNHI;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x74F5FA0", Offset = "0x74F49A0", VA = "0x1874F5FA0")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct CCJGLIBFLGI
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static BPJHNJKJMPB IGHGMJLIDOE;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x74DE6D0", Offset = "0x74DD0D0", VA = "0x1874DE6D0")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct FAHGJPMKODI
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static BPJHNJKJMPB NNPAHIHBLHI;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x74E7650", Offset = "0x74E6050", VA = "0x1874E7650")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct MLNOGLGOOBG
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static BPJHNJKJMPB CIDDPHKDIHN;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x74F1C90", Offset = "0x74F0690", VA = "0x1874F1C90")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct GKDKGAHKLNA
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static BPJHNJKJMPB HIAODCOHFOA;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x74E8AB0", Offset = "0x74E74B0", VA = "0x1874E8AB0")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct DJIGFCCFLLB
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static BPJHNJKJMPB DJIIMAHDCGJ;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x74E3C90", Offset = "0x74E2690", VA = "0x1874E3C90")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct HFKKEBFIGPI
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static BPJHNJKJMPB FLHIAFDJOMK;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x74E9010", Offset = "0x74E7A10", VA = "0x1874E9010")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct FGDKIPPAANM
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static BPJHNJKJMPB AHHICDDHJON;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x74E7FE0", Offset = "0x74E69E0", VA = "0x1874E7FE0")]
				public static PlayerLoopSystem MPCPEKOIJEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum KDGCNAJDPPP : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct BIGABLDANHB
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class ILKJGPMDHFF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public KDGCNAJDPPP updateStage;

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
					public ILKJGPMDHFF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x74E9ED0", Offset = "0x74E88D0", VA = "0x1874E9ED0")]
					internal void LNGJDJHMFKE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static ANPPHEALLCN<KDGCNAJDPPP> HCKDADJMKGD;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x74DE090", Offset = "0x74DCA90", VA = "0x1874DE090")]
				public static PlayerLoopSystem MPCPEKOIJEH(KDGCNAJDPPP OCPIGKOEMHG)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct MIEIDIBNLHO
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class GNIGCENHLFC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public LILCAMNFALB.JNHCGONAMMJ key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
					public GNIGCENHLFC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x74E8C90", Offset = "0x74E7690", VA = "0x1874E8C90")]
					internal void GODBPHOIPFF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable ACAAMGBJCPB;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x74F1B60", Offset = "0x74F0560", VA = "0x1874F1B60")]
				public static PlayerLoopSystem DBILOGOLCFM(LILCAMNFALB.JNHCGONAMMJ COMNIKKFEEB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct MNOMEIOCCKP
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class CILLMLFJDAK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public LILCAMNFALB.JNHCGONAMMJ key;

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
					public CILLMLFJDAK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x74DF100", Offset = "0x74DDB00", VA = "0x1874DF100")]
					internal void GODBPHOIPFF()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x74F1E70", Offset = "0x74F0870", VA = "0x1874F1E70")]
				public static PlayerLoopSystem DBILOGOLCFM(LILCAMNFALB.JNHCGONAMMJ COMNIKKFEEB)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class MHPBNPCCCHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public MHPBNPCCCHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x74F1860", Offset = "0x74F0260", VA = "0x1874F1860")]
			internal List<PlayerLoopSystem> BOKJBLOBNFA(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool LDBFGGKPDJN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool PPAKJAFPFGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x74E2450", Offset = "0x74E0E50", VA = "0x1874E2450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74DF520", Offset = "0x74DDF20", VA = "0x1874DF520")]
		private static void BJHOGODKICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74E26D0", Offset = "0x74E10D0", VA = "0x1874E26D0")]
		private static void LIKKCOHNMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74DF4E0", Offset = "0x74DDEE0", VA = "0x1874DF4E0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74E2490", Offset = "0x74E0E90", VA = "0x1874E2490")]
		private static void JEELAHFBPEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74E2FE0", Offset = "0x74E19E0", VA = "0x1874E2FE0")]
		private static void NGLFJICFMMK(LILCAMNFALB.JNHCGONAMMJ COMNIKKFEEB, PlayerLoopSystem AJAEFKGEKFJ, Type JKMNKHGIOFB, Type CMNPBBOKGAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x74E2070", Offset = "0x74E0A70", VA = "0x1874E2070")]
		private static void FPJDBAGJLFG(PlayerLoopSystem AJAEFKGEKFJ, Type JKMNKHGIOFB, Type CMNPBBOKGAH, DCEKOMCGMFC BOEHEDPNEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x74DF3B0", Offset = "0x74DDDB0", VA = "0x1874DF3B0")]
		private static void ACCEAJEAJNM(PlayerLoopSystem AJAEFKGEKFJ, Type JKMNKHGIOFB, Type CMNPBBOKGAH, PlayerLoopSystem? IPJAJLAHJHM, PlayerLoopSystem? GPGCEGLCJOC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class LILCAMNFALB
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum JNHCGONAMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		OMPrePhysicsFixedUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KIBMJFFNNHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly JNHCGONAMMJ EPDFEALNBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly JDMHKLGDJEE NAOHPOCNKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long ENKCLFPPKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long PDHEODKJCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long EMBGBPJEKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int PFAPGBHAPOM;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x74F0750", Offset = "0x74EF150", VA = "0x1874F0750")]
		public KIBMJFFNNHC(JNHCGONAMMJ HFMLPMKIAME, int JIFJBBFNFDK = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x74F04B0", Offset = "0x74EEEB0", VA = "0x1874F04B0")]
		public void ECJDPPGJMDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x74F0520", Offset = "0x74EEF20", VA = "0x1874F0520")]
		public void FLCCAMNKLFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x74F0570", Offset = "0x74EEF70", VA = "0x1874F0570")]
		public void KHJGNHGHANG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static JNHCGONAMMJ[] ABAGCHEHLPH;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static KIBMJFFNNHC[] OBDMODBHDIL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74F0CE0", Offset = "0x74EF6E0", VA = "0x1874F0CE0")]
	public static KIBMJFFNNHC MBNLOLEOJLN(JNHCGONAMMJ COMNIKKFEEB, int JIFJBBFNFDK = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x74F0BD0", Offset = "0x74EF5D0", VA = "0x1874F0BD0")]
	public static KIBMJFFNNHC DBLGEJDOIEE(JNHCGONAMMJ COMNIKKFEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74F0C40", Offset = "0x74EF640", VA = "0x1874F0C40")]
	public static void EEBMJOJJJNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JDMHKLGDJEE : GALLAFJFDIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int PLHAKGFFOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> EOOEAEAPLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double INMICDHDKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double LACIJCNPAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double HKHEMMJDJLD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double MEPEEIBMFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x74EA070", Offset = "0x74E8A70", VA = "0x1874EA070", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double GGENALPNDJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1DECE30", Offset = "0x1DEB830", VA = "0x181DECE30", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double NDDGJGMPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x20DE8A0", Offset = "0x20DD2A0", VA = "0x1820DE8A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x74EA140", Offset = "0x74E8B40", VA = "0x1874EA140")]
	public JDMHKLGDJEE(int DOHLFOJHOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74E9F50", Offset = "0x74E8950", VA = "0x1874E9F50", Slot = "7")]
	public void CFPNMPNDOBA(double POCLHBJGKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74EA0D0", Offset = "0x74E8AD0", VA = "0x1874EA0D0", Slot = "8")]
	public void NJEMNKBBDAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ANIJOCAKCOG : GALLAFJFDIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long CMNDBGDABDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double ADCGHONCCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double AMEHPLDIAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double NKIHBPMFAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double NCALHIFNENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double INMICDHDKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double LACIJCNPAEP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double GGENALPNDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6115DE0", Offset = "0x61147E0", VA = "0x186115DE0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double NDDGJGMPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6115E30", Offset = "0x6114830", VA = "0x186115E30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double OJDMJJOIANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6115E10", Offset = "0x6114810", VA = "0x186115E10")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MEPEEIBMFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x26EBB10", Offset = "0x26EA510", VA = "0x1826EBB10", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x74DCCE0", Offset = "0x74DB6E0", VA = "0x1874DCCE0", Slot = "7")]
	public virtual void CFPNMPNDOBA(double POCLHBJGKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74DCE00", Offset = "0x74DB800", VA = "0x1874DCE00", Slot = "8")]
	public virtual void NJEMNKBBDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x74DCE40", Offset = "0x74DB840", VA = "0x1874DCE40")]
	public ANIJOCAKCOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DLHJFLKKKAO : ANIJOCAKCOG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double IHAOACPIFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6115E60", Offset = "0x6114860", VA = "0x186115E60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6115E70", Offset = "0x6114870", VA = "0x186115E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74E3E70", Offset = "0x74E2870", VA = "0x1874E3E70", Slot = "7")]
	public override void CFPNMPNDOBA(double POCLHBJGKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x74E3FA0", Offset = "0x74E29A0", VA = "0x1874E3FA0", Slot = "8")]
	public override void NJEMNKBBDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x74DCE40", Offset = "0x74DB840", VA = "0x1874DCE40")]
	public DLHJFLKKKAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GALLAFJFDIM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double MEPEEIBMFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double GGENALPNDJN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double NDDGJGMPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class CIBMDBHAPFL
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface KIINMBBDKDG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool BNHCHHIDHKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EKAOOMEJNOB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class NGFOIGGNKOM : KIINMBBDKDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Action GGEEGOKOMKJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BNHCHHIDHKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
		public NGFOIGGNKOM(Action GGEEGOKOMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xB59500", Offset = "0xB57F00", VA = "0x180B59500", Slot = "5")]
		public void EKAOOMEJNOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<KIINMBBDKDG> NGDFJMEOFED;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x74DE910", Offset = "0x74DD310", VA = "0x1874DE910")]
	public static void BLIIFDPGHJG(Action GGEEGOKOMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x74DEA80", Offset = "0x74DD480", VA = "0x1874DEA80")]
	private static void LDBCKDHAAJI(KIINMBBDKDG BHHIKONIBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x74DED90", Offset = "0x74DD790", VA = "0x1874DED90")]
	private static void OLPLNOHMPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x74DEC90", Offset = "0x74DD690", VA = "0x1874DEC90")]
	private static void ODNNNBADPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x74DE9B0", Offset = "0x74DD3B0", VA = "0x1874DE9B0")]
	private static void DGNLOKKNBLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class OFJHEOBIJFA
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct CCPIABDPDGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TaskCompletionSource<Scene> GOCBIFHHEAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly string MIHEAIGNLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly LoadSceneMode FNOIDEFDCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly bool KMBCBEELMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x74DE8B0", Offset = "0x74DD2B0", VA = "0x1874DE8B0")]
		public CCPIABDPDGC(TaskCompletionSource<Scene> GGJEANCABJK, string MIHEAIGNLHB, LoadSceneMode FNOIDEFDCEG, bool KMBCBEELMDE, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct JNKGJIMOMBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private GOLFJDFFGLD<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x74EB220", Offset = "0x74E9C20", VA = "0x1874EB220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x74EBAC0", Offset = "0x74EA4C0", VA = "0x1874EBAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct KKHFIFNIDHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x74F0860", Offset = "0x74EF260", VA = "0x1874F0860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x74F0B70", Offset = "0x74EF570", VA = "0x1874F0B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct JHGIIJJCGGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private CCPIABDPDGC <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x74EA8B0", Offset = "0x74E92B0", VA = "0x1874EA8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x74EAC70", Offset = "0x74E9670", VA = "0x1874EAC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JGPCHFPECDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public NGCENHNNOLH<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public JGPCHFPECDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x74EA850", Offset = "0x74E9250", VA = "0x1874EA850")]
		internal void IEDFEBDNPBO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct JPLLKFOINFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private JGPCHFPECDI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x74EC220", Offset = "0x74EAC20", VA = "0x1874EC220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x74ECD80", Offset = "0x74EB780", VA = "0x1874ECD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct OCPADBHDOCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x74F3F30", Offset = "0x74F2930", VA = "0x1874F3F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x74F4400", Offset = "0x74F2E00", VA = "0x1874F4400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct EEECGOFKBJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x74E5610", Offset = "0x74E4010", VA = "0x1874E5610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x74E6130", Offset = "0x74E4B30", VA = "0x1874E6130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class PKGIAMHHKFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PKGIAMHHKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x74F63B0", Offset = "0x74F4DB0", VA = "0x1874F63B0")]
		internal bool PMFLAAJFCIG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JHMKIHDNGKI : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public BAEJNDBEMHP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public JHMKIHDNGKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x74EB0B0", Offset = "0x74E9AB0", VA = "0x1874EB0B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x74EAD20", Offset = "0x74E9720", VA = "0x1874EAD20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x74EACD0", Offset = "0x74E96D0", VA = "0x1874EACD0")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x74EB060", Offset = "0x74E9A60", VA = "0x1874EB060", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NJBOMGMGDJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public NGCENHNNOLH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public NJBOMGMGDJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x74F2420", Offset = "0x74F0E20", VA = "0x1874F2420")]
		internal bool ONCEMHOMNIB(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x74F21C0", Offset = "0x74F0BC0", VA = "0x1874F21C0")]
		internal void KHFGOEKEDNP(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class BEKEMBLDNKH : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public NGCENHNNOLH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private NJBOMGMGDJA <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public BEKEMBLDNKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x74DD870", Offset = "0x74DC270", VA = "0x1874DD870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x74DDED0", Offset = "0x74DC8D0", VA = "0x1874DDED0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly ICollection<string> KCIDMGMBBLA;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static KGIOENCPIOK PGCELAKGJKG;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static AsyncOperation MLNMIFAABDP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static KGIOENCPIOK LICFJJBOCFG;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static string AAIHMLEOCPC;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static ThreadPriority BIGNBGJGGHC;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static Task KEIJHINDELL;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static List<SceneInstance> NHMLILPAPIM;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly Queue<CCPIABDPDGC> EJEOPLMPLPA;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task JCGHINKAPHB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool HNFEJGIBOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x74F5160", Offset = "0x74F3B60", VA = "0x1874F5160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private static bool GJNIKLJMPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x74F5BA0", Offset = "0x74F45A0", VA = "0x1874F5BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private static bool DCHEFBCDCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x74F56C0", Offset = "0x74F40C0", VA = "0x1874F56C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool FCCOGNGEFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x74F5B10", Offset = "0x74F4510", VA = "0x1874F5B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> GKOFGDKPDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x74F4F80", Offset = "0x74F3980", VA = "0x1874F4F80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x74F4720", Offset = "0x74F3120", VA = "0x1874F4720")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x74F5760", Offset = "0x74F4160", VA = "0x1874F5760")]
	[IPMEGJEKNFO(DBODMODMHMH.EnteredEditModeNextFrame, 0)]
	private static void NKMBOPGKEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x74F4B80", Offset = "0x74F3580", VA = "0x1874F4B80")]
	[AsyncStateMachine(typeof(JNKGJIMOMBA))]
	public static Task<Scene> EDAHGKGLMOC(string MIHEAIGNLHB, LoadSceneMode FNOIDEFDCEG = LoadSceneMode.Single, bool KMBCBEELMDE = false, [Optional] GOLFJDFFGLD<string>.EFMHMOBJFGI AHNHIFNGDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x74F4DE0", Offset = "0x74F37E0", VA = "0x1874F4DE0")]
	[AsyncStateMachine(typeof(KKHFIFNIDHM))]
	private static Task FADFLKIDGLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x74F5090", Offset = "0x74F3A90", VA = "0x1874F5090")]
	[AsyncStateMachine(typeof(JHGIIJJCGGK))]
	private static Task GEBKCPAEEBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x74F4A30", Offset = "0x74F3430", VA = "0x1874F4A30")]
	[AsyncStateMachine(typeof(JPLLKFOINFH))]
	private static Task<Scene> EAEDPABFAMM(string MIHEAIGNLHB, LoadSceneMode FNOIDEFDCEG, bool KMBCBEELMDE, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x74F4590", Offset = "0x74F2F90", VA = "0x1874F4590")]
	private static void ACDEMGBIIEK(SceneInstance MHOPBKMJKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x74F4830", Offset = "0x74F3230", VA = "0x1874F4830")]
	private static void COGDPGFCMIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x74F4470", Offset = "0x74F2E70", VA = "0x1874F4470")]
	[AsyncStateMachine(typeof(OCPADBHDOCG))]
	private static Task<Scene> ABGBJGMJFLH(string MIHEAIGNLHB, LoadSceneMode FNOIDEFDCEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x74F4E90", Offset = "0x74F3890", VA = "0x1874F4E90")]
	private static bool FCDANIBDECA(string MIHEAIGNLHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x74F4CD0", Offset = "0x74F36D0", VA = "0x1874F4CD0")]
	[AsyncStateMachine(typeof(EEECGOFKBJK))]
	private static Task<Scene> EPJMGLGJNEH(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x74F5540", Offset = "0x74F3F40", VA = "0x1874F5540")]
	public static HABLMKCEIGL<Scene> MOMECKPEGNJ(string MIHEAIGNLHB, LoadSceneMode FNOIDEFDCEG = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x74F5850", Offset = "0x74F4250", VA = "0x1874F5850")]
	public static KGIOENCPIOK OHDDHJBCEJN(string MIHEAIGNLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x74F4690", Offset = "0x74F3090", VA = "0x1874F4690")]
	[IteratorStateMachine(typeof(JHMKIHDNGKI))]
	private static IEnumerator<DKMFPOPNNKA> BDJJEELJPHC(string MIHEAIGNLHB, BAEJNDBEMHP IAAHPMECHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x74F54A0", Offset = "0x74F3EA0", VA = "0x1874F54A0")]
	[IteratorStateMachine(typeof(BEKEMBLDNKH))]
	private static IEnumerator<DKMFPOPNNKA> MELOMBKNENF(string MIHEAIGNLHB, LoadSceneMode FNOIDEFDCEG, NGCENHNNOLH<Scene> IAAHPMECHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x74F5370", Offset = "0x74F3D70", VA = "0x1874F5370")]
	public static bool LNFJFALFHMC([Out] string KCGMJAHJAGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class OGDKFOFODNE
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x74F5E10", Offset = "0x74F4810", VA = "0x1874F5E10")]
	public static IDisposable FFKNPLEAPGI(this FHBBCAHMAHF MPOBGCPIOEI, float GMHCFEPBDPG, Action<float> BIOIGMHPOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x74F5EA0", Offset = "0x74F48A0", VA = "0x1874F5EA0")]
	public static IDisposable JELNKEONCDK(this FHBBCAHMAHF MPOBGCPIOEI, Action<float> BIOIGMHPOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x74F5F20", Offset = "0x74F4920", VA = "0x1874F5F20")]
	public static IDisposable ONJGINLMODC(this FHBBCAHMAHF MPOBGCPIOEI, Action<float> BIOIGMHPOCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DHABMJGPJPB
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x74E31E0", Offset = "0x74E1BE0", VA = "0x1874E31E0")]
	public static IDisposable AHIDLBPOAEO(this MonoBehaviour DHMHMCMKLBP, Action BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x74E3270", Offset = "0x74E1C70", VA = "0x1874E3270")]
	public static IDisposable AHIDLBPOAEO(this MonoBehaviour DHMHMCMKLBP, Action<float> BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x74E36C0", Offset = "0x74E20C0", VA = "0x1874E36C0")]
	public static IDisposable EOBPLEKHDDD(this MonoBehaviour DHMHMCMKLBP, Action BIOIGMHPOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x74E37E0", Offset = "0x74E21E0", VA = "0x1874E37E0")]
	public static IDisposable FHCPNFEMDOG(this MonoBehaviour DHMHMCMKLBP, Action BIOIGMHPOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x74E3860", Offset = "0x74E2260", VA = "0x1874E3860")]
	public static IDisposable FHCPNFEMDOG(this MonoBehaviour DHMHMCMKLBP, Action<float> BIOIGMHPOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x74E38E0", Offset = "0x74E22E0", VA = "0x1874E38E0")]
	public static IDisposable HPPFIOLLLOH(this MonoBehaviour DHMHMCMKLBP, Action BIOIGMHPOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x74E33A0", Offset = "0x74E1DA0", VA = "0x1874E33A0")]
	public static IDisposable BGCHGEOEOOL(this MonoBehaviour DHMHMCMKLBP, Action BIOIGMHPOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x74E3A00", Offset = "0x74E2400", VA = "0x1874E3A00")]
	public static IDisposable LGGLHFNGDLK(this MonoBehaviour DHMHMCMKLBP, Action BIOIGMHPOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x74E3420", Offset = "0x74E1E20", VA = "0x1874E3420")]
	public static IDisposable CJNAGDIMEKD(this MonoBehaviour DHMHMCMKLBP, float GMHCFEPBDPG, Action<float> BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD, bool JIDBCBPMFNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x74E3BC0", Offset = "0x74E25C0", VA = "0x1874E3BC0")]
	public static IDisposable MECDDBPPOGN(this MonoBehaviour DHMHMCMKLBP, float GMHCFEPBDPG, Action<float> BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD, bool JIDBCBPMFNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x74E3960", Offset = "0x74E2360", VA = "0x1874E3960")]
	public static IDisposable IGGGIFPALIC(this MonoBehaviour DHMHMCMKLBP, float GMHCFEPBDPG, Action<float> BIOIGMHPOCN, bool JIDBCBPMFNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x74E34D0", Offset = "0x74E1ED0", VA = "0x1874E34D0")]
	public static IDisposable COPGLJKHODA(this MonoBehaviour DHMHMCMKLBP, Action<float> BIOIGMHPOCN, bool JIDBCBPMFNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x74E3BF0", Offset = "0x74E25F0", VA = "0x1874E3BF0")]
	public static IDisposable PGJDDLBFKMJ(this MonoBehaviour DHMHMCMKLBP, Action<float> BIOIGMHPOCN, bool JIDBCBPMFNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x74E3B20", Offset = "0x74E2520", VA = "0x1874E3B20")]
	public static IDisposable LPBCGKFIHDP(this MonoBehaviour DHMHMCMKLBP, Action<float> BIOIGMHPOCN, bool JIDBCBPMFNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x74E3A80", Offset = "0x74E2480", VA = "0x1874E3A80")]
	public static IDisposable LOJFINEIOPF(this MonoBehaviour DHMHMCMKLBP, Action<float> BIOIGMHPOCN, bool JIDBCBPMFNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x74E3300", Offset = "0x74E1D00", VA = "0x1874E3300")]
	public static IDisposable BDJIEJDDHKF(this MonoBehaviour DHMHMCMKLBP, Action<float> BIOIGMHPOCN, bool JIDBCBPMFNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x74E3570", Offset = "0x74E1F70", VA = "0x1874E3570")]
	public static IDisposable EJGOKJNFLLK(this MonoBehaviour DHMHMCMKLBP, Action<float> BIOIGMHPOCN, bool JIDBCBPMFNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x74E3740", Offset = "0x74E2140", VA = "0x1874E3740")]
	public static IDisposable FCOEJMOPONA(this MonoBehaviour DHMHMCMKLBP, Action<float> BIOIGMHPOCN, bool JIDBCBPMFNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x74E3610", Offset = "0x74E2010", VA = "0x1874E3610")]
	public static IDisposable EKOHLMOKCOP(this MonoBehaviour DHMHMCMKLBP, float GMHCFEPBDPG, Action<float> BIOIGMHPOCN, bool JIDBCBPMFNM = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class AEPOMHDGLMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class BIHJFPKHFEP : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public ABPIBPAABDI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private BACNIKKJLBE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public BIHJFPKHFEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x74DE250", Offset = "0x74DCC50", VA = "0x1874DE250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x74DE330", Offset = "0x74DCD30", VA = "0x1874DE330", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class PKADGFAAHKF : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public ABPIBPAABDI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private BACNIKKJLBE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public PKADGFAAHKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x74F6270", Offset = "0x74F4C70", VA = "0x1874F6270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x74F6360", Offset = "0x74F4D60", VA = "0x1874F6360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x74DB7E0", Offset = "0x74DA1E0", VA = "0x1874DB7E0")]
	public static CHBCKIOGPHP AHIDLBPOAEO(Action BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x74DB750", Offset = "0x74DA150", VA = "0x1874DB750")]
	public static CHBCKIOGPHP AHIDLBPOAEO(Behaviour MPOBGCPIOEI, Action BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x74DB860", Offset = "0x74DA260", VA = "0x1874DB860")]
	public static CHBCKIOGPHP AHIDLBPOAEO(Behaviour MPOBGCPIOEI, Action<float> BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x74DB9D0", Offset = "0x74DA3D0", VA = "0x1874DB9D0")]
	[IteratorStateMachine(typeof(BIHJFPKHFEP))]
	private static IEnumerator<DKMFPOPNNKA> LEFNIOOFNKK(ABPIBPAABDI OOIKBFCDNLL, Action BIOIGMHPOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x74DB940", Offset = "0x74DA340", VA = "0x1874DB940")]
	[IteratorStateMachine(typeof(PKADGFAAHKF))]
	private static IEnumerator<DKMFPOPNNKA> LEFNIOOFNKK(ABPIBPAABDI OOIKBFCDNLL, Action<float> BIOIGMHPOCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class AAPPFMLBPJM : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class JLOAFDKBEAA : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AAPPFMLBPJM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public JLOAFDKBEAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x74EB140", Offset = "0x74E9B40", VA = "0x1874EB140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x74EB1D0", Offset = "0x74E9BD0", VA = "0x1874EB1D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly ABPIBPAABDI PEBMNNJNJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Action MJJLFIDAEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private bool OKPFGFIPLJD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool JNBOLGGGPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x88B230", Offset = "0x889C30", VA = "0x18088B230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x74DB680", Offset = "0x74DA080", VA = "0x1874DB680")]
	public AAPPFMLBPJM(ABPIBPAABDI PEBMNNJNJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x74DB600", Offset = "0x74DA000", VA = "0x1874DB600")]
	[IteratorStateMachine(typeof(JLOAFDKBEAA))]
	private IEnumerator<DKMFPOPNNKA> PIPHEACIHNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x74DB560", Offset = "0x74D9F60", VA = "0x1874DB560", Slot = "4")]
	public void OnCompleted(Action LHLGPOKEGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public void PBCJEGKBFPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class LKKPGAJNJEN
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x74F1050", Offset = "0x74EFA50", VA = "0x1874F1050")]
	public static AAPPFMLBPJM CCPNIIDMBMI(this ABPIBPAABDI PEBMNNJNJJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class AMDPDBHMMAG
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class HCHEIEJMBDL : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public NJCDOMJBHOB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public HCHEIEJMBDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x74E8F40", Offset = "0x74E7940", VA = "0x1874E8F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x74E8FC0", Offset = "0x74E79C0", VA = "0x1874E8FC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x74DC530", Offset = "0x74DAF30", VA = "0x1874DC530")]
	public static CHBCKIOGPHP AHIDLBPOAEO(float GMHCFEPBDPG, Action<float> BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD, bool JIDBCBPMFNM = true, [Optional] PNEIPMIIOFI FFMJCGBLNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x74DC600", Offset = "0x74DB000", VA = "0x1874DC600")]
	public static CHBCKIOGPHP AHIDLBPOAEO(MonoBehaviour DHMHMCMKLBP, float GMHCFEPBDPG, Action<float> BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD, bool JIDBCBPMFNM = true, [Optional] PNEIPMIIOFI FFMJCGBLNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x74DC7A0", Offset = "0x74DB1A0", VA = "0x1874DC7A0")]
	public static CHBCKIOGPHP DFIAACHFCKI(MonoBehaviour DHMHMCMKLBP, float GMHCFEPBDPG, Action<float> BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD, bool JIDBCBPMFNM = true, [Optional] PNEIPMIIOFI FFMJCGBLNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x74DC6D0", Offset = "0x74DB0D0", VA = "0x1874DC6D0")]
	public static CHBCKIOGPHP BCBBJMIHINL(FHBBCAHMAHF MPOBGCPIOEI, float GMHCFEPBDPG, Action<float> BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD, bool JIDBCBPMFNM = true, [Optional] PNEIPMIIOFI FFMJCGBLNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x74DC980", Offset = "0x74DB380", VA = "0x1874DC980")]
	private static IEnumerator<DKMFPOPNNKA> LEFNIOOFNKK(INLGBIPECHM IEMIGFKJGFO, float GMHCFEPBDPG, ABPIBPAABDI OOIKBFCDNLL, Action<float> BIOIGMHPOCN, bool JIDBCBPMFNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x74DC920", Offset = "0x74DB320", VA = "0x1874DC920")]
	private static IEnumerator<DKMFPOPNNKA> KPJLDOIAOEF(INLGBIPECHM IEMIGFKJGFO, float GMHCFEPBDPG, ABPIBPAABDI OOIKBFCDNLL, Action<float> BIOIGMHPOCN, bool JIDBCBPMFNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x74DC890", Offset = "0x74DB290", VA = "0x1874DC890")]
	[IteratorStateMachine(typeof(HCHEIEJMBDL))]
	private static IEnumerator<DKMFPOPNNKA> IPBCGFJLMBK(NJCDOMJBHOB LDDDOBBODNO, float GMHCFEPBDPG, ABPIBPAABDI OOIKBFCDNLL, Action<float> BIOIGMHPOCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class BELOLJAEEOL
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class GGJBAIIEFHD : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public ABPIBPAABDI queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public GGJBAIIEFHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x74E8950", Offset = "0x74E7350", VA = "0x1874E8950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x74E8A10", Offset = "0x74E7410", VA = "0x1874E8A10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x74DDF20", Offset = "0x74DC920", VA = "0x1874DDF20")]
	[IteratorStateMachine(typeof(GGJBAIIEFHD))]
	private static IEnumerator<DKMFPOPNNKA> ACJKMJPKEGG(ABPIBPAABDI PEBMNNJNJJD, Func<bool> FLLLJDPKPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x74DDFB0", Offset = "0x74DC9B0", VA = "0x1874DDFB0")]
	public static CHBCKIOGPHP BOGFFCPABBH(this MonoBehaviour DHMHMCMKLBP, Func<bool> FLLLJDPKPMB, ABPIBPAABDI PEBMNNJNJJD = ABPIBPAABDI.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class AIPFIINEBKL
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class ANDNEEHOMNN : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public ABPIBPAABDI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public ANDNEEHOMNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x74DCC20", Offset = "0x74DB620", VA = "0x1874DCC20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x74DCC90", Offset = "0x74DB690", VA = "0x1874DCC90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class ANMKKFMCDHF : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public ABPIBPAABDI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private DKMFPOPNNKA <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public ANMKKFMCDHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x74DCE70", Offset = "0x74DB870", VA = "0x1874DCE70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x74DCF00", Offset = "0x74DB900", VA = "0x1874DCF00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x74DC3F0", Offset = "0x74DADF0", VA = "0x1874DC3F0")]
	[IteratorStateMachine(typeof(ANDNEEHOMNN))]
	private static IEnumerator<DKMFPOPNNKA> PIPHEACIHNK(float PEDHHHMMIGP, ABPIBPAABDI OOIKBFCDNLL, Action EDFBCBDPOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x74DBFB0", Offset = "0x74DA9B0", VA = "0x1874DBFB0")]
	[IteratorStateMachine(typeof(ANMKKFMCDHF))]
	private static IEnumerator<DKMFPOPNNKA> JHEGGMBFLFL(float PEDHHHMMIGP, ABPIBPAABDI OOIKBFCDNLL, Action EDFBCBDPOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x74DBB60", Offset = "0x74DA560", VA = "0x1874DBB60")]
	public static IDisposable CLPPCEJMMHL(this MonoBehaviour DHMHMCMKLBP, float PEDHHHMMIGP, Action EDFBCBDPOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x74DC190", Offset = "0x74DAB90", VA = "0x1874DC190")]
	public static CHBCKIOGPHP NINNNNBAOML(this MonoBehaviour DHMHMCMKLBP, float PEDHHHMMIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x74DBC40", Offset = "0x74DA640", VA = "0x1874DBC40")]
	public static CHBCKIOGPHP CLPPCEJMMHL(this MonoBehaviour DHMHMCMKLBP, float PEDHHHMMIGP, ABPIBPAABDI OOIKBFCDNLL, Action EDFBCBDPOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x74DBF10", Offset = "0x74DA910", VA = "0x1874DBF10")]
	public static CHBCKIOGPHP IKNENCCIBAP(this MonoBehaviour DHMHMCMKLBP, Action EDFBCBDPOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x74DBE70", Offset = "0x74DA870", VA = "0x1874DBE70")]
	public static CHBCKIOGPHP FLJIGAIDFKG(this MonoBehaviour DHMHMCMKLBP, Action EDFBCBDPOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x74DC050", Offset = "0x74DAA50", VA = "0x1874DC050")]
	public static CHBCKIOGPHP KIJEADHHLPL(this MonoBehaviour DHMHMCMKLBP, Action EDFBCBDPOLM, [Optional] PNEIPMIIOFI FFMJCGBLNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x74DBD30", Offset = "0x74DA730", VA = "0x1874DBD30")]
	public static CHBCKIOGPHP DGDEDDGABLN(this MonoBehaviour DHMHMCMKLBP, Action EDFBCBDPOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x74DC220", Offset = "0x74DAC20", VA = "0x1874DC220")]
	public static CHBCKIOGPHP ODOJHEIICHM(this MonoBehaviour DHMHMCMKLBP, Action EDFBCBDPOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x74DC0F0", Offset = "0x74DAAF0", VA = "0x1874DC0F0")]
	private static CHBCKIOGPHP LOMKDEIDNGB(MonoBehaviour DHMHMCMKLBP, ABPIBPAABDI PEBMNNJNJJD, Action EDFBCBDPOLM, [Optional] PNEIPMIIOFI FFMJCGBLNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x74DC360", Offset = "0x74DAD60", VA = "0x1874DC360")]
	public static CHBCKIOGPHP PHFFLLGJICK(this MonoBehaviour DHMHMCMKLBP, float BJKEOACABLM, Action EDFBCBDPOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x74DBDD0", Offset = "0x74DA7D0", VA = "0x1874DBDD0")]
	public static CHBCKIOGPHP EALNPLGJGMD(this MonoBehaviour DHMHMCMKLBP, float BJKEOACABLM, Action EDFBCBDPOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x74DC490", Offset = "0x74DAE90", VA = "0x1874DC490")]
	public static CHBCKIOGPHP PLNIDACEEGP(this MonoBehaviour DHMHMCMKLBP, float BJKEOACABLM, Action EDFBCBDPOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x74DC2C0", Offset = "0x74DACC0", VA = "0x1874DC2C0")]
	public static CHBCKIOGPHP OINPEGIHBNN(this MonoBehaviour DHMHMCMKLBP, float BJKEOACABLM, Action EDFBCBDPOLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class AOAGLLKBKIC : BJEOLIMHBMI, IEnumerable<BJEOLIMHBMI>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<BJEOLIMHBMI> LKGKLEMCJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool LFMBAJGBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Action IEJGFFELDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool GGNKOLLOPLG;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool JDCLJLCHPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x74DD6A0", Offset = "0x74DC0A0", VA = "0x1874DD6A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CGBHFPGLEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x74DD410", Offset = "0x74DBE10", VA = "0x1874DD410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x74DD4B0", Offset = "0x74DBEB0", VA = "0x1874DD4B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x74DD7D0", Offset = "0x74DC1D0", VA = "0x1874DD7D0")]
	public AOAGLLKBKIC([Optional] Action IEJGFFELDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x74DD2E0", Offset = "0x74DBCE0", VA = "0x1874DD2E0")]
	public void KDCHLCHLBCK(BJEOLIMHBMI EFLGGIMDIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x74DD550", Offset = "0x74DBF50", VA = "0x1874DD550")]
	private void OLAHDLGOJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x74DD250", Offset = "0x74DBC50", VA = "0x1874DD250", Slot = "7")]
	public bool GDOOHMEMGPD(bool LCIPAAAOEPD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x74DCF50", Offset = "0x74DB950", VA = "0x1874DCF50", Slot = "8")]
	public bool GDOOHMEMGPD(Action GGEEGOKOMKJ, bool LCIPAAAOEPD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x74DD260", Offset = "0x74DBC60", VA = "0x1874DD260", Slot = "9")]
	public IEnumerator<BJEOLIMHBMI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x74DD260", Offset = "0x74DBC60", VA = "0x1874DD260", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NCAPEDJIIJH : JPACKKIHALG
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MAMBNPLECLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public NCAPEDJIIJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MAMBNPLECLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x74E8F10", Offset = "0x74E7910", VA = "0x1874E8F10")]
		internal void HKFBMDHBMAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class GOGKLCBIDBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public NCAPEDJIIJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public GOGKLCBIDBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x74E8F10", Offset = "0x74E7910", VA = "0x1874E8F10")]
		internal void PPGKGILCGLH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly float KGOMDLFOOBD;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x74F1670", Offset = "0x74F0070", VA = "0x1874F1670")]
	public NCAPEDJIIJH(Behaviour MPOBGCPIOEI, float KGOMDLFOOBD, [Optional] Action IEJGFFELDDI, [Optional] PNEIPMIIOFI FFMJCGBLNHF, [Optional] INLGBIPECHM IEMIGFKJGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x74F1FA0", Offset = "0x74F09A0", VA = "0x1874F1FA0", Slot = "9")]
	protected override bool DMDBEOANFOE(Action GGEEGOKOMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x74F20B0", Offset = "0x74F0AB0", VA = "0x1874F20B0", Slot = "10")]
	protected override bool NIAIDDEPMKE(Action GGEEGOKOMKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface BJEOLIMHBMI
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool JDCLJLCHPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CGBHFPGLEGA;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GDOOHMEMGPD(bool LCIPAAAOEPD = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GDOOHMEMGPD(Action GGEEGOKOMKJ, bool LCIPAAAOEPD = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class JPACKKIHALG : BJEOLIMHBMI
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class EIFNJHDIABM : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public JPACKKIHALG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public EIFNJHDIABM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x74E61A0", Offset = "0x74E4BA0", VA = "0x1874E61A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x74E6270", Offset = "0x74E4C70", VA = "0x1874E6270", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Behaviour MPOBGCPIOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action IEJGFFELDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CJIKIHCHPEJ FIHCGHFBOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly PNEIPMIIOFI FFMJCGBLNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly INLGBIPECHM IEMIGFKJGFO;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JDCLJLCHPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x10DB420", Offset = "0x10D9E20", VA = "0x1810DB420", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action CGBHFPGLEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x74EBD60", Offset = "0x74EA760", VA = "0x1874EBD60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x74EC050", Offset = "0x74EAA50", VA = "0x1874EC050", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x74EC0F0", Offset = "0x74EAAF0", VA = "0x1874EC0F0")]
	protected JPACKKIHALG(Behaviour MPOBGCPIOEI, [Optional] Action IEJGFFELDDI, [Optional] PNEIPMIIOFI FFMJCGBLNHF, [Optional] INLGBIPECHM IEMIGFKJGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x74EBCE0", Offset = "0x74EA6E0", VA = "0x1874EBCE0", Slot = "7")]
	public bool GDOOHMEMGPD(bool LCIPAAAOEPD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x74EBC80", Offset = "0x74EA680", VA = "0x1874EBC80", Slot = "8")]
	public bool GDOOHMEMGPD(Action GGEEGOKOMKJ, bool LCIPAAAOEPD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool DMDBEOANFOE(Action GGEEGOKOMKJ);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NIAIDDEPMKE(Action GGEEGOKOMKJ);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x74EBD40", Offset = "0x74EA740", VA = "0x1874EBD40")]
	protected void LAEDDNGIMDE(Action GGEEGOKOMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x74EBE00", Offset = "0x74EA800", VA = "0x1874EBE00")]
	protected KGIOENCPIOK MMLHJDEHAEH(float GLIHGPEPPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x74EBB30", Offset = "0x74EA530", VA = "0x1874EBB30")]
	private void FPBJLNKCGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x74EBBB0", Offset = "0x74EA5B0", VA = "0x1874EBBB0")]
	[IteratorStateMachine(typeof(EIFNJHDIABM))]
	private IEnumerator<DKMFPOPNNKA> GCDKHEADMNK(float GLIHGPEPPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x74EBC40", Offset = "0x74EA640", VA = "0x1874EBC40")]
	[CompilerGenerated]
	private void GCFHIPBOBKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class KEKLILKKHCF : JPACKKIHALG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float MKODOMPAOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int AMLJJJHHMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float IGNIDCEJLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float[] OOLJHCLMOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int MHGLOCNGGGF;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x74EFA30", Offset = "0x74EE430", VA = "0x1874EFA30")]
	public KEKLILKKHCF(Behaviour MPOBGCPIOEI, float ALEFDNBENFE, int AMLJJJHHMJC, [Optional] Action IEJGFFELDDI, float IGNIDCEJLHK = 0f, [Optional] PNEIPMIIOFI FFMJCGBLNHF, [Optional] INLGBIPECHM IEMIGFKJGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "9")]
	protected override bool DMDBEOANFOE(Action GGEEGOKOMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x74EF830", Offset = "0x74EE230", VA = "0x1874EF830", Slot = "10")]
	protected override bool NIAIDDEPMKE(Action GGEEGOKOMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x74EF7B0", Offset = "0x74EE1B0", VA = "0x1874EF7B0")]
	private void KNCLOMCMIKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MAGJGCNHEOL : JPACKKIHALG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float KGOMDLFOOBD;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x74F1670", Offset = "0x74F0070", VA = "0x1874F1670")]
	public MAGJGCNHEOL(Behaviour MPOBGCPIOEI, float KGOMDLFOOBD, [Optional] Action IEJGFFELDDI, [Optional] PNEIPMIIOFI FFMJCGBLNHF, [Optional] INLGBIPECHM IEMIGFKJGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "9")]
	protected override bool DMDBEOANFOE(Action GGEEGOKOMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x74F1630", Offset = "0x74F0030", VA = "0x1874F1630", Slot = "10")]
	protected override bool NIAIDDEPMKE(Action GGEEGOKOMKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class FNAHKDAPDMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class AGMGKIDGBNO : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public AGMGKIDGBNO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x74DBAA0", Offset = "0x74DA4A0", VA = "0x1874DBAA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x74DBB10", Offset = "0x74DA510", VA = "0x1874DBB10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private CHBCKIOGPHP MMMCKEJOCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private FHBBCAHMAHF MPOBGCPIOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Action<float> BEBMALIHLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private ABPIBPAABDI PEBMNNJNJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float MEFJMGBNECC;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x74E86C0", Offset = "0x74E70C0", VA = "0x1874E86C0")]
	public FNAHKDAPDMM(FHBBCAHMAHF MPOBGCPIOEI, float GMHCFEPBDPG, Action<float> BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x74E8550", Offset = "0x74E6F50", VA = "0x1874E8550")]
	private void KNCGHEPDPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x74E81C0", Offset = "0x74E6BC0", VA = "0x1874E81C0")]
	private void DHELKAMAAIG(string EJIIMGEBDBD, Action MJMDGGMFKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x74E84D0", Offset = "0x74E6ED0", VA = "0x1874E84D0")]
	[IteratorStateMachine(typeof(AGMGKIDGBNO))]
	private IEnumerator<DKMFPOPNNKA> HLFHPFJIFFH(Action MJMDGGMFKNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x74E82F0", Offset = "0x74E6CF0", VA = "0x1874E82F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x74E8350", Offset = "0x74E6D50", VA = "0x1874E8350")]
	[CompilerGenerated]
	private void FAOHILMJPOJ(string OANLHKKGJFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class EJKJNNFDAIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GJJJODELBDM : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public GJJJODELBDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x74DBAA0", Offset = "0x74DA4A0", VA = "0x1874DBAA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x74E8A60", Offset = "0x74E7460", VA = "0x1874E8A60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private CHBCKIOGPHP MMMCKEJOCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private MonoBehaviour DHMHMCMKLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action BIOIGMHPOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Action<float> BEBMALIHLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private ABPIBPAABDI PEBMNNJNJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float MEFJMGBNECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private bool JIDBCBPMFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly PNEIPMIIOFI FFMJCGBLNHF;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x74E6EF0", Offset = "0x74E58F0", VA = "0x1874E6EF0")]
	public EJKJNNFDAIP(MonoBehaviour DHMHMCMKLBP, Action BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD, [Optional] PNEIPMIIOFI FFMJCGBLNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x74E7080", Offset = "0x74E5A80", VA = "0x1874E7080")]
	public EJKJNNFDAIP(MonoBehaviour DHMHMCMKLBP, Action<float> BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD, [Optional] PNEIPMIIOFI FFMJCGBLNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x74E7250", Offset = "0x74E5C50", VA = "0x1874E7250")]
	public EJKJNNFDAIP(MonoBehaviour DHMHMCMKLBP, float GMHCFEPBDPG, Action<float> BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD, bool JIDBCBPMFNM = true, [Optional] PNEIPMIIOFI FFMJCGBLNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4007140", Offset = "0x4005B40", VA = "0x184007140")]
	private EJKJNNFDAIP(PNEIPMIIOFI FFMJCGBLNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x74E6B10", Offset = "0x74E5510", VA = "0x1874E6B10")]
	internal static EJKJNNFDAIP MDLACBOMFEG(MonoBehaviour DHMHMCMKLBP, float GMHCFEPBDPG, Action<float> BIOIGMHPOCN, ABPIBPAABDI PEBMNNJNJJD, bool JIDBCBPMFNM = true, [Optional] PNEIPMIIOFI FFMJCGBLNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x74E62C0", Offset = "0x74E4CC0", VA = "0x1874E62C0")]
	private void AHIDLBPOAEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x74E6820", Offset = "0x74E5220", VA = "0x1874E6820")]
	private void JHJKPGEPGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x74E69A0", Offset = "0x74E53A0", VA = "0x1874E69A0")]
	private void KNCGHEPDPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x74E6580", Offset = "0x74E4F80", VA = "0x1874E6580")]
	private void EGFJDJKAEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x74E63F0", Offset = "0x74E4DF0", VA = "0x1874E63F0")]
	private void DHELKAMAAIG(string EJIIMGEBDBD, Action MJMDGGMFKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x74E67A0", Offset = "0x74E51A0", VA = "0x1874E67A0")]
	[IteratorStateMachine(typeof(GJJJODELBDM))]
	private IEnumerator<DKMFPOPNNKA> HLFHPFJIFFH(Action MJMDGGMFKNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x74E6520", Offset = "0x74E4F20", VA = "0x1874E6520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x74E6E60", Offset = "0x74E5860", VA = "0x1874E6E60")]
	[CompilerGenerated]
	private void POPCKAMDAKE(string OANLHKKGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x74E6710", Offset = "0x74E5110", VA = "0x1874E6710")]
	[CompilerGenerated]
	private void GPOGBLICKII(string OANLHKKGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x74E6D40", Offset = "0x74E5740", VA = "0x1874E6D40")]
	[CompilerGenerated]
	private void NHBIKKMIEFA(string OANLHKKGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x74E6DD0", Offset = "0x74E57D0", VA = "0x1874E6DD0")]
	[CompilerGenerated]
	private void OJJCHAAEDCJ(string OANLHKKGJFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum GJLJEGPBEAJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal sealed class MDJDCNLAEOK : INLGBIPECHM
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float NDFAGPFICFD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x74F17B0", Offset = "0x74F01B0", VA = "0x1874F17B0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float ENNFMIEAMNM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x74F1830", Offset = "0x74F0230", VA = "0x1874F1830", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public double BLEHAIFOLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x74F1840", Offset = "0x74F0240", VA = "0x1874F1840", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x74F17C0", Offset = "0x74F01C0", VA = "0x1874F17C0")]
	[MDINNNLEANF.FIHKBCJDGBK]
	internal static void CNFNMOPOGFM(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	[UnityEngine.Scripting.Preserve]
	internal MDJDCNLAEOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface PDHNDFGAPAG
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHCKFEKJNAP(string DDDMPLCOGIM);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIDBENGECEE();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface IJDJALELDID
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool IIKOPGKOKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool KCFILBEIAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class LMHMKJDGPPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public KBGAGCEGLEI BBPMAEBEIIG;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int BDIPFIAMOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x889F40", Offset = "0x888940", VA = "0x180889F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x74F1410", Offset = "0x74EFE10", VA = "0x1874F1410")]
	public static DKMFPOPNNKA ODCBMDBFCPM(IEnumerator<DKMFPOPNNKA> GKCIBJAKHNO, BNHLPDIEEMC GFIAALDPPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x74F1570", Offset = "0x74EFF70", VA = "0x1874F1570")]
	public DKMFPOPNNKA ODCBMDBFCPM(BNHLPDIEEMC[] GJOGBKKHOBE, IEnumerator<DKMFPOPNNKA>[] LJHCHLLFJMO, DKMFPOPNNKA[] MGJGAHBBMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x74F13E0", Offset = "0x74EFDE0", VA = "0x1874F13E0")]
	public void JAANPNOOLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x74F1160", Offset = "0x74EFB60", VA = "0x1874F1160")]
	public void BONINCHAGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x74F12A0", Offset = "0x74EFCA0", VA = "0x1874F12A0")]
	public void HMPFLIDCPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x74F13E0", Offset = "0x74EFDE0", VA = "0x1874F13E0")]
	public void MLLJDEONDHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public LMHMKJDGPPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class KBGAGCEGLEI
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct HJOCBJDLCBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public LMHMKJDGPPL POEALFBOCLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public FHBBCAHMAHF FHCCMGMAEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public BNHLPDIEEMC IJKDKIJHGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public IEnumerator<DKMFPOPNNKA> LHEKNEGALEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public DKMFPOPNNKA OEKLOIKDGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public GJLJEGPBEAJ LJKGLAFOMDG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct AAECONDIFDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public ABPIBPAABDI BEBHLHIHAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public List<HJOCBJDLCBE> KEDEKBKLJDB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class FCGNJOAPAKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public BNHLPDIEEMC promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public KBGAGCEGLEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public FHBBCAHMAHF context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public LMHMKJDGPPL routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public GJLJEGPBEAJ coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public DKMFPOPNNKA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IEnumerator<DKMFPOPNNKA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FCGNJOAPAKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x74E7830", Offset = "0x74E6230", VA = "0x1874E7830")]
		internal void JFPNELNFCCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class AFKNCLHCPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public LMHMKJDGPPL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public KBGAGCEGLEI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AFKNCLHCPEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x74DBA60", Offset = "0x74DA460", VA = "0x1874DBA60")]
		internal void FJJFGLFFNDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class ENMOBOOJCGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public LMHMKJDGPPL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public KBGAGCEGLEI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public ENMOBOOJCGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x74E7430", Offset = "0x74E5E30", VA = "0x1874E7430")]
		internal void NBODBHLJDIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DGLPIGFLLNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public LMHMKJDGPPL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public KBGAGCEGLEI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public DGLPIGFLLNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x74E31A0", Offset = "0x74E1BA0", VA = "0x1874E31A0")]
		internal void IFIDBPCLHDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private const GJLJEGPBEAJ IHGBOLGLFIA = GJLJEGPBEAJ.Cancelled | GJLJEGPBEAJ.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly ABPIBPAABDI PEBMNNJNJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool[] ABKEJLFGOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<GJLJEGPBEAJ> EADAAJDAECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<float> NMGDKNDNFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> BCJBCGHLPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> OPEOBDIOELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> FJOPNGMGLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> NENLEPCHHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> KCLCPPMHFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private LMHMKJDGPPL[] CMNAKDDHJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private BNHLPDIEEMC[] GJOGBKKHOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private FHBBCAHMAHF[] LJHMFKBNIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IEnumerator<DKMFPOPNNKA>[] MFAPKHMNDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private DKMFPOPNNKA[] BKCKJOOLFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int GCJEBMOAFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int PAODLCPDLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly int BAMIDGGKEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float NHNLJODAFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JFPDHDLCMPO JOIHDNCPHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private JobHandle KADKCPNLFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<LMHMKJDGPPL> DGKHDDPKCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool MNNAALJFMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> BHJLPPODHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<Action> HEDLAAJMNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool HNLMNJFDEOA;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public AAECONDIFDE[] HIMHBBDLHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA92FD0", Offset = "0xA919D0", VA = "0x180A92FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x74EE5F0", Offset = "0x74ECFF0", VA = "0x1874EE5F0")]
	private static int IPPDGHCKAFL(ABPIBPAABDI PEBMNNJNJJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x74EF160", Offset = "0x74EDB60", VA = "0x1874EF160")]
	public KBGAGCEGLEI(ABPIBPAABDI PEBMNNJNJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x74EE190", Offset = "0x74ECB90", VA = "0x1874EE190")]
	private void FPDCKACHLMG(int NFFOENCFLLN, int IPMPEGBNGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x74ED2C0", Offset = "0x74EBCC0", VA = "0x1874ED2C0")]
	public void AJBKPFKADCE(FHBBCAHMAHF MPOBGCPIOEI, DKMFPOPNNKA IENINDLFKAD, IEnumerator<DKMFPOPNNKA> GKCIBJAKHNO, BNHLPDIEEMC GFIAALDPPDM, [Optional] LMHMKJDGPPL ACDNHCMFACG, GJLJEGPBEAJ BMGHCNLFMBA = GJLJEGPBEAJ.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x74EE820", Offset = "0x74ED220", VA = "0x1874EE820")]
	public void MHGAKADDEOO(IEnumerable<HJOCBJDLCBE> IBAGHEIEBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x74ECDF0", Offset = "0x74EB7F0", VA = "0x1874ECDF0")]
	private HJOCBJDLCBE AANPLFPGFBJ(int KPNMDDAAFMK)
	{
		return default(HJOCBJDLCBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x74ED440", Offset = "0x74EBE40", VA = "0x1874ED440")]
	private void APCHDNLBMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF8B0", Offset = "0x2DFE2B0", VA = "0x182DFF8B0")]
	private static void ECBKEHFKFNB<T>(int KPNMDDAAFMK, T[] DILFCMNMEHE, int ECFPAOHDFEB, [Optional] T BFLPPBBOJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF900", Offset = "0x2DFE300", VA = "0x182DFF900")]
	private static void ECBKEHFKFNB<T>(int KPNMDDAAFMK, NativeArray<T> DILFCMNMEHE, int ECFPAOHDFEB, [Optional] T BFLPPBBOJNM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x74EEB90", Offset = "0x74ED590", VA = "0x1874EEB90")]
	private void MMIPPMCGEEK(IEnumerable<HJOCBJDLCBE> IBAGHEIEBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x74EE520", Offset = "0x74ECF20", VA = "0x1874EE520")]
	private void IJBLJGEKKGO(HJOCBJDLCBE ABMEOJHHJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x74ED7B0", Offset = "0x74EC1B0", VA = "0x1874ED7B0")]
	private LNHBGCBGDPP BOALICFDFIE(int AEJLNCOHOMJ)
	{
		return default(LNHBGCBGDPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x74EE620", Offset = "0x74ED020", VA = "0x1874EE620")]
	public void LNMMJELKMLI(float MJJJIHPNGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x74EE370", Offset = "0x74ECD70", VA = "0x1874EE370")]
	private void GCDHGAMDCDF(Action KPNKONMDFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x74EDA10", Offset = "0x74EC410", VA = "0x1874EDA10")]
	private void CENKLKNKHDN(Action KPNKONMDFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x74EDA90", Offset = "0x74EC490", VA = "0x1874EDA90")]
	public void EODNOBDOBPK(float MJJJIHPNGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x74EEF30", Offset = "0x74ED930", VA = "0x1874EEF30")]
	public void NEECMKACHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x74EEA60", Offset = "0x74ED460", VA = "0x1874EEA60")]
	public void MLLJDEONDHD(LMHMKJDGPPL LDDDOBBODNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x74EE3F0", Offset = "0x74ECDF0", VA = "0x1874EE3F0")]
	public void HJGDEOKBILN(LMHMKJDGPPL LDDDOBBODNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x74EF030", Offset = "0x74EDA30", VA = "0x1874EF030")]
	public void PBEFDHDMHLI(LMHMKJDGPPL LDDDOBBODNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JGLHPCPJLIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly JGLHPCPJLIA CKLKOBNMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly Action PPNPMEBLOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool PJFKAIJIJGP;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public JGLHPCPJLIA(Action PPNPMEBLOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C699E0", Offset = "0x6C683E0", VA = "0x186C699E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface JMELPMHEHKH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T ADJCIFCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PDIOKCPEIFK(UnityEngine.Object MPOBGCPIOEI, Action<T> MNIJEFBEBJE);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface PCCMIEDJPFL<T> : JMELPMHEHKH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	new T ADJCIFCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class EKFPAICOIKD<T> : PCCMIEDJPFL<T>, JMELPMHEHKH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class FMNPJNEOKOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public EKFPAICOIKD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public JMENLDKBDDJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FMNPJNEOKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E05D60", Offset = "0x3E04760", VA = "0x183E05D60")]
		internal void IJCMJBCPMAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static GameObject AIFHJLENHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly List<JMENLDKBDDJ<UnityEngine.Object, Action<T>>> JPGOPIJJBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private T LLAOLPIPCFI;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public T ADJCIFCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAC0B0", Offset = "0xAAAAB0", VA = "0x180AAC0B0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3A2AF70", Offset = "0x3A29970", VA = "0x183A2AF70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A2ADD0", Offset = "0x3A297D0", VA = "0x183A2ADD0")]
	private static bool HMJKCAOOJPI(T KPNKONMDFPM, T NGNLLOFPDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A2BA90", Offset = "0x3A2A490", VA = "0x183A2BA90")]
	public EKFPAICOIKD(T AEOBKOMGHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A2B820", Offset = "0x3A2A220", VA = "0x183A2B820", Slot = "6")]
	public IDisposable PDIOKCPEIFK(UnityEngine.Object MPOBGCPIOEI, Action<T> MNIJEFBEBJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A2B340", Offset = "0x3A29D40", VA = "0x183A2B340")]
	private void KIKGPFDHMCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class NODIIKNAANM : NHCFNKCLJCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly PNEIPMIIOFI FFMJCGBLNHF;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x74F2550", Offset = "0x74F0F50", VA = "0x1874F2550")]
	[MDINNNLEANF.FIHKBCJDGBK]
	internal static void LKLMCLBCEDB(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	[UnityEngine.Scripting.Preserve]
	internal NODIIKNAANM([LKKACOOMNBP(null)] PNEIPMIIOFI FFMJCGBLNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x74F24A0", Offset = "0x74F0EA0", VA = "0x1874F24A0", Slot = "4")]
	public IDisposable IGGGIFPALIC(float GMHCFEPBDPG, Action<float> AGMLFHLAIFJ, bool JIDBCBPMFNM = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class IDOJILLDPKE : DMGFKNKEDGB, PNEIPMIIOFI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private KBGAGCEGLEI[] KPJLPEMBCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private PDHNDFGAPAG BGOACCEECJI;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x74E9310", Offset = "0x74E7D10", VA = "0x1874E9310")]
	[MDINNNLEANF.FIHKBCJDGBK]
	internal static void CNFNMOPOGFM(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x74E9E10", Offset = "0x74E8810", VA = "0x1874E9E10")]
	[UnityEngine.Scripting.Preserve]
	public IDOJILLDPKE([LKKACOOMNBP(null)] PHAOOEOCAJF EDBBMPOEEGM, [LKKACOOMNBP(null)] INLGBIPECHM IEMIGFKJGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x74E9A50", Offset = "0x74E8450", VA = "0x1874E9A50", Slot = "18")]
	public override CHBCKIOGPHP JGEAJBOHDLA(FHBBCAHMAHF MPOBGCPIOEI, IEnumerator<DKMFPOPNNKA> OLOBEINDAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x74E9B80", Offset = "0x74E8580", VA = "0x1874E9B80", Slot = "19")]
	public override void NJEMNKBBDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x74E93E0", Offset = "0x74E7DE0", VA = "0x1874E93E0", Slot = "21")]
	public override void EKOEDOJMBDK(ABPIBPAABDI PEBMNNJNJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x74E9610", Offset = "0x74E8010", VA = "0x1874E9610", Slot = "20")]
	protected override void EOBPLEKHDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x74E9A20", Offset = "0x74E8420", VA = "0x1874E9A20")]
	private KBGAGCEGLEI JCHNMPHOKAB(ABPIBPAABDI AOGCIMANLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x74E9780", Offset = "0x74E8180", VA = "0x1874E9780", Slot = "22")]
	internal override KHAGKHDFPNO EPPHLDMKJDI(IEnumerator<DKMFPOPNNKA> OLOBEINDAKC, Behaviour MPOBGCPIOEI, BNHLPDIEEMC GFIAALDPPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x74E99A0", Offset = "0x74E83A0", VA = "0x1874E99A0", Slot = "23")]
	internal override OAIMCGKHAFA GMEFNAJJNOB(ABPIBPAABDI OOIKBFCDNLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x74E91F0", Offset = "0x74E7BF0", VA = "0x1874E91F0")]
	private void CFKNCMBDHCB(KBGAGCEGLEI OHEMAFFCGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x74E9380", Offset = "0x74E7D80", VA = "0x1874E9380", Slot = "24")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct JFPDHDLCMPO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public float IIDDHHGMJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	public int ILNPHCFLKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> PCHEEJGAOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> ILGPAMOLJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> KLGGBCLCBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<GJLJEGPBEAJ> CBMBDHEHJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	public NativeArray<float> CACJCDKLNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> FJOPNGMGLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[WriteOnly]
	public NativeArray<int> BCJBCGHLPOO;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x74EA510", Offset = "0x74E8F10", VA = "0x1874EA510")]
	public static JFPDHDLCMPO EMJKOLAJLFI(int ADAIKEDNKPE, float MJJJIHPNGKM, NativeArray<GJLJEGPBEAJ> ONDBMOMNAMN, NativeArray<float> PJIDIOGBBKG, NativeArray<int> EJFLKAGMJAN, NativeArray<int> CIEPNBLKPPE, NativeArray<int> OEHAEPLIGLH, NativeArray<int> ILGPAMOLJIO, NativeArray<int> KLGGBCLCBON)
	{
		return default(JFPDHDLCMPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x74EA570", Offset = "0x74E8F70", VA = "0x1874EA570", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x74EA1F0", Offset = "0x74E8BF0", VA = "0x1874EA1F0")]
	private bool AKCBPCKLBFA(int ENMILGHAHOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x74EA650", Offset = "0x74E9050", VA = "0x1874EA650")]
	private void HONDIJEGDFG(NativeArray<int> IPJMHDEBKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x74EA470", Offset = "0x74E8E70", VA = "0x1874EA470")]
	private int EDHEFGICAGL(int CEODMJAMMKE, int DOMJNOBPKKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x74EA680", Offset = "0x74E9080", VA = "0x1874EA680")]
	private void JNBAKKNMHFC(NativeArray<int> IPJMHDEBKGD, int KHBGOMEACJF, int CLCPGILFJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x74EA230", Offset = "0x74E8C30", VA = "0x1874EA230")]
	private void ECMACICFJHH(NativeArray<int> IPJMHDEBKGD, int IMPDHNKDPNM, int EPHFGAKJOLO, int OGFKMHENBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class DMGFKNKEDGB : PNEIPMIIOFI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly PHAOOEOCAJF EDBBMPOEEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected readonly INLGBIPECHM IEMIGFKJGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private OAIMCGKHAFA[] NOJDKDHJAPM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static PNEIPMIIOFI GHBFIIGNNDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x74E4A60", Offset = "0x74E3460", VA = "0x1874E4A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static bool HACHFHFHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public ABPIBPAABDI CEPDKKIJLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(ABPIBPAABDI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x889F40", Offset = "0x888940", VA = "0x180889F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public INLGBIPECHM HOLEGDODMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DKMFPOPNNKA PDMANIPGPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DKMFPOPNNKA FGJAHKDODPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x889090", Offset = "0x887A90", VA = "0x180889090", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public DKMFPOPNNKA EOKMPPJDGEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x883D50", Offset = "0x882750", VA = "0x180883D50", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x74E4CE0", Offset = "0x74E36E0", VA = "0x1874E4CE0")]
	public static CHBCKIOGPHP KIICKJCIOHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x74E5120", Offset = "0x74E3B20", VA = "0x1874E5120")]
	[UnityEngine.Scripting.Preserve]
	protected DMGFKNKEDGB([LKKACOOMNBP(null)] PHAOOEOCAJF EDBBMPOEEGM, [LKKACOOMNBP(null)] INLGBIPECHM IEMIGFKJGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x74E4AD0", Offset = "0x74E34D0", VA = "0x1874E4AD0", Slot = "6")]
	public CHBCKIOGPHP KELODGGKPBN(IEnumerator<DKMFPOPNNKA> OLOBEINDAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x74E4AE0", Offset = "0x74E34E0", VA = "0x1874E4AE0", Slot = "7")]
	public CHBCKIOGPHP KELODGGKPBN(Behaviour MPOBGCPIOEI, IEnumerator<DKMFPOPNNKA> OLOBEINDAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract CHBCKIOGPHP JGEAJBOHDLA(FHBBCAHMAHF MPOBGCPIOEI, IEnumerator<DKMFPOPNNKA> OLOBEINDAKC);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x74E4F40", Offset = "0x74E3940", VA = "0x1874E4F40", Slot = "19")]
	public virtual void NJEMNKBBDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x74E41C0", Offset = "0x74E2BC0", VA = "0x1874E41C0", Slot = "9")]
	public void BBJBPJJEJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x74E4960", Offset = "0x74E3360", VA = "0x1874E4960", Slot = "20")]
	protected virtual void EOBPLEKHDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x74E4A00", Offset = "0x74E3400", VA = "0x1874E4A00")]
	private void GNAAKFGIIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x74E5100", Offset = "0x74E3B00", VA = "0x1874E5100")]
	private void OFPBNKACAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x74E4980", Offset = "0x74E3380", VA = "0x1874E4980")]
	private void FHCPNFEMDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x74E4A20", Offset = "0x74E3420", VA = "0x1874E4A20")]
	private void HPPFIOLLLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x74E4A40", Offset = "0x74E3440", VA = "0x1874E4A40")]
	private void IGHGMJLIDOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x74E50E0", Offset = "0x74E3AE0", VA = "0x1874E50E0")]
	private void NNPAHIHBLHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x74E4490", Offset = "0x74E2E90", VA = "0x1874E4490")]
	private void COLMENONPGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x74E48D0", Offset = "0x74E32D0", VA = "0x1874E48D0", Slot = "21")]
	public virtual void EKOEDOJMBDK(ABPIBPAABDI PEBMNNJNJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x74E4D70", Offset = "0x74E3770", VA = "0x1874E4D70")]
	private void NHKMECJKMJL(OAIMCGKHAFA OHEMAFFCGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x203E990", Offset = "0x203D390", VA = "0x18203E990")]
	private OAIMCGKHAFA CJCJPAHCBGI(ABPIBPAABDI AOGCIMANLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract KHAGKHDFPNO EPPHLDMKJDI(IEnumerator<DKMFPOPNNKA> OLOBEINDAKC, Behaviour DHMHMCMKLBP, BNHLPDIEEMC FDGEBJMMMCM);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract OAIMCGKHAFA GMEFNAJJNOB(ABPIBPAABDI PEBMNNJNJJD);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x74E4510", Offset = "0x74E2F10", VA = "0x1874E4510", Slot = "24")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x74E44B0", Offset = "0x74E2EB0", VA = "0x1874E44B0", Slot = "14")]
	public DKMFPOPNNKA DAHIMNPAGOF(ABPIBPAABDI OOIKBFCDNLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x74E4400", Offset = "0x74E2E00", VA = "0x1874E4400", Slot = "15")]
	public DKMFPOPNNKA CBIJFLNJHLO(float PEDHHHMMIGP, ABPIBPAABDI OOIKBFCDNLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x74E49A0", Offset = "0x74E33A0", VA = "0x1874E49A0", Slot = "16")]
	public DKMFPOPNNKA FNIOIBDLIOK(Func<bool> FLLLJDPKPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class KHAGKHDFPNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly BNHLPDIEEMC GFIAALDPPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly IJDJALELDID MPOBGCPIOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool FNFKLPECBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private string DDDMPLCOGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private StackTrace IOIOACBCDFH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<DKMFPOPNNKA> LHEKNEGALEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public DKMFPOPNNKA OEKLOIKDGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool ADOCOPJIBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x74F0190", Offset = "0x74EEB90", VA = "0x1874F0190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool CCJJMHHJJLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAC060", Offset = "0xAAAA60", VA = "0x180AAC060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xC55C90", Offset = "0xC54690", VA = "0x180C55C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x74EFC00", Offset = "0x74EE600", VA = "0x1874EFC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float PKJHJBFLFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAAC020", Offset = "0xAAAA20", VA = "0x180AAC020")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6115540", Offset = "0x6113F40", VA = "0x186115540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x74F02F0", Offset = "0x74EECF0", VA = "0x1874F02F0")]
	public KHAGKHDFPNO(IEnumerator<DKMFPOPNNKA> GKCIBJAKHNO, IJDJALELDID MPOBGCPIOEI, BNHLPDIEEMC GFIAALDPPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x74EFE70", Offset = "0x74EE870", VA = "0x1874EFE70")]
	public DKMFPOPNNKA ODCBMDBFCPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x74EFE00", Offset = "0x74EE800", VA = "0x1874EFE00")]
	public bool NJGDMMKEPKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x74EFDB0", Offset = "0x74EE7B0", VA = "0x1874EFDB0")]
	public void MLLJDEONDHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x74F0210", Offset = "0x74EEC10", VA = "0x1874F0210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xCC6DF0", Offset = "0xCC57F0", VA = "0x180CC6DF0")]
	[CompilerGenerated]
	private void OEOHMLJDMEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class BNHLPDIEEMC : PDFBMGCFHMO, CHBCKIOGPHP, CJIKIHCHPEJ, KGIOENCPIOK, IEnumerator, DKMFPOPNNKA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private ABPIBPAABDI CFKCPAMFGOI;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private ABPIBPAABDI BHLFHCPPFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8C0", Offset = "0x9BC2C0", VA = "0x1809BD8C0", Slot = "23")]
		get
		{
			return default(ABPIBPAABDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public ABPIBPAABDI BBPMAEBEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8B0", Offset = "0x9BC2B0", VA = "0x1809BD8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float CKKDHPACKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x95E210", Offset = "0x95CC10", VA = "0x18095E210", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool GJDMHKIJCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x74DE660", Offset = "0x74DD060", VA = "0x1874DE660", Slot = "24")]
	private bool PDOBIIAGEMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x74DE650", Offset = "0x74DD050", VA = "0x1874DE650", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x74DE680", Offset = "0x74DD080", VA = "0x1874DE680")]
	public BNHLPDIEEMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum LNHBGCBGDPP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class OAIMCGKHAFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum NGLJJIKDDKM
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct DBALHHMDILK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public ABPIBPAABDI BEBHLHIHAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public NGLJJIKDDKM ADLMIIEHDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public List<KHAGKHDFPNO> MPDAEDICFBF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly NGLJJIKDDKM[] PNBBECMFDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly ABPIBPAABDI PEBMNNJNJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool KPGDBEABBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly KHAGKHDFPNO[] DJCADNOBCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<KHAGKHDFPNO> DNKNEOAOLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<int> FMLADPHCGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<KHAGKHDFPNO> GDLDJBABEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> FHFCHMCNJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly PDHNDFGAPAG OOJGIADNCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private bool HNLMNJFDEOA;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public DBALHHMDILK[,] LFLBHDBJGHB
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x883D50", Offset = "0x882750", VA = "0x180883D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x74F3AB0", Offset = "0x74F24B0", VA = "0x1874F3AB0")]
	public OAIMCGKHAFA(ABPIBPAABDI OOIKBFCDNLL, PDHNDFGAPAG OOJGIADNCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x74F2D10", Offset = "0x74F1710", VA = "0x1874F2D10")]
	public void EGPPMDJHBEA(KHAGKHDFPNO GKCIBJAKHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x74F3590", Offset = "0x74F1F90", VA = "0x1874F3590")]
	public void OOKNCBMDDAG(IList<KHAGKHDFPNO> LJHCHLLFJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x74F28F0", Offset = "0x74F12F0", VA = "0x1874F28F0")]
	public void CJMAOJKAALG(IList<KHAGKHDFPNO> LJHCHLLFJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x74F3890", Offset = "0x74F2290", VA = "0x1874F3890")]
	private void PLIHPKLAGCB(KHAGKHDFPNO GKCIBJAKHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x74F3280", Offset = "0x74F1C80", VA = "0x1874F3280")]
	private void IBAMKLKBNJJ(IList<KHAGKHDFPNO> LJHCHLLFJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x74F3410", Offset = "0x74F1E10", VA = "0x1874F3410")]
	private LNHBGCBGDPP MLKGDANFDPB(KHAGKHDFPNO GKCIBJAKHNO)
	{
		return default(LNHBGCBGDPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x74F2E10", Offset = "0x74F1810", VA = "0x1874F2E10")]
	public void EOBPLEKHDDD(float MJJJIHPNGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x74F25C0", Offset = "0x74F0FC0", VA = "0x1874F25C0")]
	public void BBJBPJJEJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x74F2F80", Offset = "0x74F1980", VA = "0x1874F2F80")]
	private void GKNIMCIJFNG(List<KHAGKHDFPNO> LJHCHLLFJMO, Stack<int> DFDKOJJMCJN, bool DDANIDHGEMM, float OJHCNFONMNM = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x74F2BF0", Offset = "0x74F15F0", VA = "0x1874F2BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x74F27B0", Offset = "0x74F11B0", VA = "0x1874F27B0")]
	private void CFPOJCBDBJD(List<KHAGKHDFPNO> LJHCHLLFJMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class HPOHIPLEPMC : PDHNDFGAPAG
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public void AHCKFEKJNAP(string DDDMPLCOGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
	public void BIDBENGECEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public HPOHIPLEPMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class GAAGGLBHJCO : IJDJALELDID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly Behaviour DHMHMCMKLBP;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x74E8860", Offset = "0x74E7260", VA = "0x1874E8860", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool IIKOPGKOKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x74E88E0", Offset = "0x74E72E0", VA = "0x1874E88E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool KCFILBEIAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x74E8930", Offset = "0x74E7330", VA = "0x1874E8930", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public GAAGGLBHJCO(Behaviour DHMHMCMKLBP)
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

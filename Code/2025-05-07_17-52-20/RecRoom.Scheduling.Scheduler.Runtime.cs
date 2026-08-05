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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86F5A40", Offset = "0x86F4A40", VA = "0x1886F5A40", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FDE20", Offset = "0x86FCE20", VA = "0x1886FDE20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
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
		private delegate List<PlayerLoopSystem> BBLGDJJDOGB(List<PlayerLoopSystem> GBFFCKINGHI, int AOOJOMOPMDN);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct AJEJKNDMLJC
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct HKKNOGCLAJD
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static GCADBNOOJOM PMACAPOABNL;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x86EE340", Offset = "0x86ED340", VA = "0x1886EE340")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct CJEJOBNFLOG
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static GCADBNOOJOM OMLCMBHOPAG;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x86E33C0", Offset = "0x86E23C0", VA = "0x1886E33C0")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct LPLFLFHPFEL
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static GCADBNOOJOM KFBOHBEKNBL;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x86F5840", Offset = "0x86F4840", VA = "0x1886F5840")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct ODGPPHAJGOO
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static GCADBNOOJOM GEODCGAHENK;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static GCADBNOOJOM POINHKNCAEM;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static GCADBNOOJOM ALBAMFAFLGE;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static GCADBNOOJOM CEFFGFDFBON;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x86FA3F0", Offset = "0x86F93F0", VA = "0x1886FA3F0")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct LDPHPNEEGGJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static GCADBNOOJOM JGJDBGEPOLE;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x86F29F0", Offset = "0x86F19F0", VA = "0x1886F29F0")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct DFBMAAOICPP
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static GCADBNOOJOM GEODCGAHENK;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static GCADBNOOJOM POINHKNCAEM;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static GCADBNOOJOM ALBAMFAFLGE;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static GCADBNOOJOM CEFFGFDFBON;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x86E8B70", Offset = "0x86E7B70", VA = "0x1886E8B70")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct JHILEBPLKIG
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static GCADBNOOJOM GACKGMPFEJP;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x86F0B00", Offset = "0x86EFB00", VA = "0x1886F0B00")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct CFLLHFEAEME
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static GCADBNOOJOM HBDHJFKOJEF;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x86E31C0", Offset = "0x86E21C0", VA = "0x1886E31C0")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct LKHDONMNEDL
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static GCADBNOOJOM PEGMFKBBENO;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x86F2C50", Offset = "0x86F1C50", VA = "0x1886F2C50")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct FCPNNCJBALM
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static GCADBNOOJOM OIPGGPHAEAH;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x86ECB70", Offset = "0x86EBB70", VA = "0x1886ECB70")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct DMOIFDOJBFM
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static GCADBNOOJOM OLFCIMPPKME;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x86E9330", Offset = "0x86E8330", VA = "0x1886E9330")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct KBIGPNEBAJH
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static GCADBNOOJOM DPFJCMGNJNC;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x86F0FC0", Offset = "0x86EFFC0", VA = "0x1886F0FC0")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct GGCDBFKIOIP
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static GCADBNOOJOM CFBCICELKLO;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x86ED280", Offset = "0x86EC280", VA = "0x1886ED280")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct GAKLPLPPNNC
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static GCADBNOOJOM CBPNPHAEGFI;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x86ED080", Offset = "0x86EC080", VA = "0x1886ED080")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct KNBLNAOEBIN
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static GCADBNOOJOM HGFACBLMPCK;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x86F19E0", Offset = "0x86F09E0", VA = "0x1886F19E0")]
				public static PlayerLoopSystem LBBJDNLDBIG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum CLBMOHIOJNE : byte
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
			public struct OENFDDIGIGE
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class PMLOHCFJNED
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public CLBMOHIOJNE updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
					public PMLOHCFJNED()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x86FCB50", Offset = "0x86FBB50", VA = "0x1886FCB50")]
					internal void KPAKLKNHGDB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static NPNKPOOAOFG<CLBMOHIOJNE> DFHPHCDPEKO;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x86FA6E0", Offset = "0x86F96E0", VA = "0x1886FA6E0")]
				public static PlayerLoopSystem LBBJDNLDBIG(CLBMOHIOJNE HDPJDCEFCCP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct CPJLNHDNABJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class KBDGFKFBJMM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public EHHIACBBKDI.KFJBEHEFKKP key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
					public KBDGFKFBJMM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x86F0D80", Offset = "0x86EFD80", VA = "0x1886F0D80")]
					internal void DFBMJDEHAPB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable FJANCENKJOO;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x86E3680", Offset = "0x86E2680", VA = "0x1886E3680")]
				public static PlayerLoopSystem GJNAEIHPMAA(EHHIACBBKDI.KFJBEHEFKKP OEHHKNIGGMI)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct BJLDNAKBOEK
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class LBJJGIKLJCE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public EHHIACBBKDI.KFJBEHEFKKP key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
					public LBJJGIKLJCE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x86F1BE0", Offset = "0x86F0BE0", VA = "0x1886F1BE0")]
					internal void DFBMJDEHAPB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x86E1580", Offset = "0x86E0580", VA = "0x1886E1580")]
				public static PlayerLoopSystem GJNAEIHPMAA(EHHIACBBKDI.KFJBEHEFKKP OEHHKNIGGMI)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class MMPEDBHEMDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public MMPEDBHEMDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x86F85E0", Offset = "0x86F75E0", VA = "0x1886F85E0")]
			internal List<PlayerLoopSystem> MMLOCFOABHA(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool GLKLGFBNGPG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool LEKPPPLNIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x86E71C0", Offset = "0x86E61C0", VA = "0x1886E71C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86E4100", Offset = "0x86E3100", VA = "0x1886E4100")]
		private static void DHEKKOOOLMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86E37B0", Offset = "0x86E27B0", VA = "0x1886E37B0")]
		private static void AHHHPBIIAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86E40C0", Offset = "0x86E30C0", VA = "0x1886E40C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86E78D0", Offset = "0x86E68D0", VA = "0x1886E78D0")]
		private static void OCNJGMEEIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86E7200", Offset = "0x86E6200", VA = "0x1886E7200")]
		private static void GOMLMDOHJBI(EHHIACBBKDI.KFJBEHEFKKP OEHHKNIGGMI, PlayerLoopSystem OHECFPEJIHA, Type MNCPGGCDFNE, Type FDGGDDCMGML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86E74F0", Offset = "0x86E64F0", VA = "0x1886E74F0")]
		private static void MLKHMHOEANA(PlayerLoopSystem OHECFPEJIHA, Type MNCPGGCDFNE, Type FDGGDDCMGML, BBLGDJJDOGB KEAIFFGFAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86E73C0", Offset = "0x86E63C0", VA = "0x1886E73C0")]
		private static void IBOPBLIIFCC(PlayerLoopSystem OHECFPEJIHA, Type MNCPGGCDFNE, Type FDGGDDCMGML, PlayerLoopSystem? KHAPDHGPHDE, PlayerLoopSystem? BJGPIFNNGLL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class EHHIACBBKDI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum KFJBEHEFKKP
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
	public class BNOJHILLAIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly KFJBEHEFKKP AIOMDBDAKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly JDIBNENMGGC BALKFEOIDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long FAJHKGBHFNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long ACJGMFMAPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long NLICNFLLBNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int CFINAIILOIO;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x86E1B80", Offset = "0x86E0B80", VA = "0x1886E1B80")]
		public BNOJHILLAIJ(KFJBEHEFKKP BADKPDKBJKO, int EDGAKHBBNHK = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86E1B60", Offset = "0x86E0B60", VA = "0x1886E1B60")]
		public void JKDNJINFDPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x86E1A30", Offset = "0x86E0A30", VA = "0x1886E1A30")]
		public void EBKPIDLMIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x86E1A80", Offset = "0x86E0A80", VA = "0x1886E1A80")]
		public void FBDIACIMIMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static KFJBEHEFKKP[] CPOIIICFGHE;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static BNOJHILLAIJ[] MKMOKABDMHD;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x86E9C10", Offset = "0x86E8C10", VA = "0x1886E9C10")]
	public static BNOJHILLAIJ NHFGFOADMBA(KFJBEHEFKKP OEHHKNIGGMI, int EDGAKHBBNHK = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x86E9BA0", Offset = "0x86E8BA0", VA = "0x1886E9BA0")]
	public static BNOJHILLAIJ KKKMFCOPEON(KFJBEHEFKKP OEHHKNIGGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x86E9AF0", Offset = "0x86E8AF0", VA = "0x1886E9AF0")]
	public static void DDJLDAIAGGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IJBMCBHJHCH
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface LIICJENAEJA
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool CCECGMBPCHD
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MCMIEJOHGAC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class OAJBFNFEAKD : LIICJENAEJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action BDCLNIJAFBF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CCECGMBPCHD
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
		public OAJBFNFEAKD(Action BDCLNIJAFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1129CA0", Offset = "0x1128CA0", VA = "0x181129CA0", Slot = "5")]
		public void MCMIEJOHGAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<LIICJENAEJA> PFBHJLDCJFO;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x86F03B0", Offset = "0x86EF3B0", VA = "0x1886F03B0")]
	public static void ECEBIPAAPLC(Action BDCLNIJAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x86F0850", Offset = "0x86EF850", VA = "0x1886F0850")]
	private static void NKELCGKCOKB(LIICJENAEJA HEJJIONAJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86F0450", Offset = "0x86EF450", VA = "0x1886F0450")]
	private static void KDONHDGHLKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x86F0750", Offset = "0x86EF750", VA = "0x1886F0750")]
	private static void LKIBHEFCNAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x86F02D0", Offset = "0x86EF2D0", VA = "0x1886F02D0")]
	private static void BEHOHOKEBND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class PKCJDHLEBFE
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct BHCMEAOEANC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> IBHLCEONLMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string NHHGKEDIJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode AADCMIGJAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool BEGAHOKPHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x86E1520", Offset = "0x86E0520", VA = "0x1886E1520")]
		public BHCMEAOEANC(TaskCompletionSource<Scene> NDDCKHOMMDA, string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ, bool BEGAHOKPHIA, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct BBAIKDAKDFF : IAsyncStateMachine
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
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private LDCGKGNFMMI<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x86E0C10", Offset = "0x86DFC10", VA = "0x1886E0C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x86E14B0", Offset = "0x86E04B0", VA = "0x1886E14B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct DBEGNEIHLCD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x86E7B20", Offset = "0x86E6B20", VA = "0x1886E7B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x86E7E40", Offset = "0x86E6E40", VA = "0x1886E7E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct NNBAMFAKDOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private BHCMEAOEANC <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x86F9330", Offset = "0x86F8330", VA = "0x1886F9330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x86F96F0", Offset = "0x86F86F0", VA = "0x1886F96F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class LIFCPBLCJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AIKFLNNDLCF<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public LIFCPBLCJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x86F2BF0", Offset = "0x86F1BF0", VA = "0x1886F2BF0")]
		internal void JGHAIKFIINJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct DDJPAFAJNGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

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
		private LIFCPBLCJEJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86E7EA0", Offset = "0x86E6EA0", VA = "0x1886E7EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86E8A50", Offset = "0x86E7A50", VA = "0x1886E8A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct MBHMGBJDBGL : IAsyncStateMachine
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
		private JHEDBCMAENC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x86F5AD0", Offset = "0x86F4AD0", VA = "0x1886F5AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x86F6190", Offset = "0x86F5190", VA = "0x1886F6190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct LBKFIONDKBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x86F1E60", Offset = "0x86F0E60", VA = "0x1886F1E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x86F2980", Offset = "0x86F1980", VA = "0x1886F2980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EGEFJOCMHIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AIKFLNNDLCF<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EGEFJOCMHIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x86E9A70", Offset = "0x86E8A70", VA = "0x1886E9A70")]
		internal bool JCMAHIHNHKC(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x86E97F0", Offset = "0x86E87F0", VA = "0x1886E97F0")]
		internal void CPIPGCNPACD(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ELPBMCAJONM : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AIKFLNNDLCF<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private EGEFJOCMHIF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private JHEDBCMAENC <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public ELPBMCAJONM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x86EC240", Offset = "0x86EB240", VA = "0x1886EC240", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x86EB950", Offset = "0x86EA950", VA = "0x1886EB950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x86EB930", Offset = "0x86EA930", VA = "0x1886EB930")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x86EC1F0", Offset = "0x86EB1F0", VA = "0x1886EC1F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> FJILACEFHAM;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static HPIGCMLNLFB HFAEKPOEPGF;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation GEIOMEGECKB;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static HPIGCMLNLFB KLFBDIKPNLL;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string FAADKLGEFJP;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string CCBDMAGBLLA;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority DJDGKMDLBOF;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task AMOIDGPPCGD;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> GEOEOECPMGJ;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<BHCMEAOEANC> JMEEJIMOCEL;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task MHONNIGNHAH;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> DIMMPAOHPBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x86FBCE0", Offset = "0x86FACE0", VA = "0x1886FBCE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x86FC4B0", Offset = "0x86FB4B0", VA = "0x1886FC4B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x86FBBE0", Offset = "0x86FABE0", VA = "0x1886FBBE0")]
	[FELFDMPPKKE(MGEKOJDDIFB.EnteredEditModeNextFrame, 0)]
	private static void KCCCACMJPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x86FBFC0", Offset = "0x86FAFC0", VA = "0x1886FBFC0")]
	[AsyncStateMachine(typeof(BBAIKDAKDFF))]
	public static Task<Scene> MDAGPEBKPOI(string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ = LoadSceneMode.Single, bool BEGAHOKPHIA = false, [Optional] LDCGKGNFMMI<string>.CKHHEKIPJDF PFIFCCELJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x86FB970", Offset = "0x86FA970", VA = "0x1886FB970")]
	[AsyncStateMachine(typeof(DBEGNEIHLCD))]
	private static Task HKMBEBFEMNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x86FBB10", Offset = "0x86FAB10", VA = "0x1886FBB10")]
	[AsyncStateMachine(typeof(NNBAMFAKDOL))]
	private static Task JPEEIOHBEPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x86FC360", Offset = "0x86FB360", VA = "0x1886FC360")]
	[AsyncStateMachine(typeof(DDJPAFAJNGJ))]
	private static Task<Scene> OAONLEBLBIC(string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ, bool BEGAHOKPHIA, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x86FB5A0", Offset = "0x86FA5A0", VA = "0x1886FB5A0")]
	private static void DLABGBMAELK(SceneInstance ELJDCHFNJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x86FB6B0", Offset = "0x86FA6B0", VA = "0x1886FB6B0")]
	private static void FINDLAKCMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x86FC1D0", Offset = "0x86FB1D0", VA = "0x1886FC1D0")]
	[AsyncStateMachine(typeof(MBHMGBJDBGL))]
	private static Task<Scene> MPKHGNKNMIH(string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x86FBA20", Offset = "0x86FAA20", VA = "0x1886FBA20")]
	private static bool JEOAFOOPBKE(string NHHGKEDIJJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x86FB490", Offset = "0x86FA490", VA = "0x1886FB490")]
	[AsyncStateMachine(typeof(LBKFIONDKBE))]
	private static Task<Scene> BJJOOCPFFMI(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x86FC5C0", Offset = "0x86FB5C0", VA = "0x1886FC5C0")]
	public static KGAPFDAFEHM<Scene> PKDMJPFPGBP(string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x86FBDF0", Offset = "0x86FADF0", VA = "0x1886FBDF0")]
	[IteratorStateMachine(typeof(ELPBMCAJONM))]
	private static IEnumerator<NFNODNEANBN> LKCHIFLDECJ(string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ, AIKFLNNDLCF<Scene> FJFPKGKGKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x86FC300", Offset = "0x86FB300", VA = "0x1886FC300")]
	public static void NOOOOGFKDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x86FC110", Offset = "0x86FB110", VA = "0x1886FC110")]
	private static void MDDLNNBJMHG(string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x86FBE90", Offset = "0x86FAE90", VA = "0x1886FBE90")]
	public static bool LKKIBLGKEKF([Out] string JJEOCLBFJKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class IFHEPDGEEMH
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x86F00E0", Offset = "0x86EF0E0", VA = "0x1886F00E0")]
	public static IDisposable CFGBHCBIICN(this JBOJNOKAFDL INLEBAAACKH, float BHGDBFOAFAM, Action<float> BDLNDMICBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x86F0170", Offset = "0x86EF170", VA = "0x1886F0170")]
	public static IDisposable CMEACFMFHBD(this JBOJNOKAFDL INLEBAAACKH, Action<float> BDLNDMICBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x86F0060", Offset = "0x86EF060", VA = "0x1886F0060")]
	public static IDisposable AELAAONDBPF(this JBOJNOKAFDL INLEBAAACKH, Action<float> BDLNDMICBAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class PKOIPMIKNPL
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x39F5340", Offset = "0x39F4340", VA = "0x1839F5340")]
	[IPFMAEIIMGH]
	public static IDisposable JALCPPFBBBJ<T>(this T CAJPFDMILMO, Action BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x39F5190", Offset = "0x39F4190", VA = "0x1839F5190")]
	[IPFMAEIIMGH]
	public static IDisposable JALCPPFBBBJ<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x39F50F0", Offset = "0x39F40F0", VA = "0x1839F50F0")]
	[IPFMAEIIMGH]
	public static IDisposable IEKHBJGOAKB<T>(this T CAJPFDMILMO, Action BDLNDMICBAA, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x39F54F0", Offset = "0x39F44F0", VA = "0x1839F54F0")]
	[IPFMAEIIMGH]
	public static IDisposable JDNAJILJLLM<T>(this T CAJPFDMILMO, Action BDLNDMICBAA, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x39F54F0", Offset = "0x39F44F0", VA = "0x1839F54F0")]
	[IPFMAEIIMGH]
	public static IDisposable JDNAJILJLLM<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x39F4EF0", Offset = "0x39F3EF0", VA = "0x1839F4EF0")]
	[IPFMAEIIMGH]
	public static IDisposable FJHKGKPOOOM<T>(this T CAJPFDMILMO, Action BDLNDMICBAA, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x39F4D80", Offset = "0x39F3D80", VA = "0x1839F4D80")]
	[IPFMAEIIMGH]
	public static IDisposable CKDAHECHOJJ<T>(this T CAJPFDMILMO, Action BDLNDMICBAA, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x39F5580", Offset = "0x39F4580", VA = "0x1839F5580")]
	[IPFMAEIIMGH]
	public static IDisposable KEAODKPBJEO<T>(this T CAJPFDMILMO, Action BDLNDMICBAA, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x39F5540", Offset = "0x39F4540", VA = "0x1839F5540")]
	[IPFMAEIIMGH]
	public static IDisposable JPLCFDPAAMG<T>(this T CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x86FC970", Offset = "0x86FB970", VA = "0x1886FC970")]
	[IPFMAEIIMGH]
	public static IDisposable JPLCFDPAAMG(this MonoBehaviour CAJPFDMILMO, FHBMACKKPGL INLEBAAACKH, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x39F4F40", Offset = "0x39F3F40", VA = "0x1839F4F40")]
	[IPFMAEIIMGH]
	public static IDisposable GONLKNNHHBI<T>(this T CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x39F4D30", Offset = "0x39F3D30", VA = "0x1839F4D30")]
	[IPFMAEIIMGH]
	public static IDisposable BHAJIFFIHFJ<T>(this T CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x39F4E30", Offset = "0x39F3E30", VA = "0x1839F4E30")]
	[IPFMAEIIMGH]
	public static IDisposable DGEGDCFKIOI<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x39F5630", Offset = "0x39F4630", VA = "0x1839F5630")]
	[IPFMAEIIMGH]
	public static IDisposable OEOFKLAKAKB<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x39F56F0", Offset = "0x39F46F0", VA = "0x1839F56F0")]
	[IPFMAEIIMGH]
	public static IDisposable OMOLKILAPLN<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x39F5130", Offset = "0x39F4130", VA = "0x1839F5130")]
	[IPFMAEIIMGH]
	public static IDisposable IJABMGJCMOL<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x39F5690", Offset = "0x39F4690", VA = "0x1839F5690")]
	[IPFMAEIIMGH]
	public static IDisposable OHPMEKEPBEM<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x39F55D0", Offset = "0x39F45D0", VA = "0x1839F55D0")]
	[IPFMAEIIMGH]
	public static IDisposable MKBHLPENHIK<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x39F57A0", Offset = "0x39F47A0", VA = "0x1839F57A0")]
	[IPFMAEIIMGH]
	public static IDisposable PLNHEOKNALG<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x39F5750", Offset = "0x39F4750", VA = "0x1839F5750")]
	[IPFMAEIIMGH]
	public static IDisposable PILOJBPNBPE<T>(this T CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x39F4DD0", Offset = "0x39F3DD0", VA = "0x1839F4DD0")]
	[IPFMAEIIMGH]
	public static IDisposable DCHAONAODGP<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x39F4E90", Offset = "0x39F3E90", VA = "0x1839F4E90")]
	[IPFMAEIIMGH]
	public static IDisposable FCNEOFOFOIG<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GAEDKCAMADF
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class MCFJHDHKMEK : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public GFDMGEIMGAF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private DLFDLGIBKAH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public MCFJHDHKMEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x86F6200", Offset = "0x86F5200", VA = "0x1886F6200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x86F62E0", Offset = "0x86F52E0", VA = "0x1886F62E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class KCLICCNDKHG : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public GFDMGEIMGAF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private DLFDLGIBKAH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public KCLICCNDKHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x86F11C0", Offset = "0x86F01C0", VA = "0x1886F11C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x86F12B0", Offset = "0x86F02B0", VA = "0x1886F12B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x86ECD70", Offset = "0x86EBD70", VA = "0x1886ECD70")]
	public static OLILOOIADED JALCPPFBBBJ(Action BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x86ECED0", Offset = "0x86EBED0", VA = "0x1886ECED0")]
	public static OLILOOIADED JALCPPFBBBJ(Behaviour INLEBAAACKH, Action BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x86ECDF0", Offset = "0x86EBDF0", VA = "0x1886ECDF0")]
	public static OLILOOIADED JALCPPFBBBJ(Behaviour INLEBAAACKH, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x86ECF60", Offset = "0x86EBF60", VA = "0x1886ECF60")]
	[IteratorStateMachine(typeof(MCFJHDHKMEK))]
	private static IEnumerator<NFNODNEANBN> OPDDPABBDPC(GFDMGEIMGAF GNDKFGDDNMM, Action BDLNDMICBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x86ECFF0", Offset = "0x86EBFF0", VA = "0x1886ECFF0")]
	[IteratorStateMachine(typeof(KCLICCNDKHG))]
	private static IEnumerator<NFNODNEANBN> OPDDPABBDPC(GFDMGEIMGAF GNDKFGDDNMM, Action<float> BDLNDMICBAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class MNFFEGFBFLL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class IHGPHMBCGMM : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public MNFFEGFBFLL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public IHGPHMBCGMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x86F01F0", Offset = "0x86EF1F0", VA = "0x1886F01F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x86F0280", Offset = "0x86EF280", VA = "0x1886F0280", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly GFDMGEIMGAF DEOJBEPOEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action GBHKDPMEJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool OFMPMHOBAGN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool MFDNMEOBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F1560", Offset = "0x9F0560", VA = "0x1809F1560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x86F8820", Offset = "0x86F7820", VA = "0x1886F8820")]
	public MNFFEGFBFLL(GFDMGEIMGAF DEOJBEPOEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x86F8700", Offset = "0x86F7700", VA = "0x1886F8700")]
	[IteratorStateMachine(typeof(IHGPHMBCGMM))]
	private IEnumerator<NFNODNEANBN> AIJPGKDNIGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x86F8780", Offset = "0x86F7780", VA = "0x1886F8780", Slot = "4")]
	public void OnCompleted(Action ADGINAHIKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	public void NINCFNJEAPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class PHIDHLNKLID
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x86FB380", Offset = "0x86FA380", VA = "0x1886FB380")]
	public static MNFFEGFBFLL NCACCMDALIC(this GFDMGEIMGAF DEOJBEPOEPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class MHNKJBOOFFN
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class EOMDMOPBOHP : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public PHCKHDLKOLG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public EOMDMOPBOHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x86EC2D0", Offset = "0x86EB2D0", VA = "0x1886EC2D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x86EC350", Offset = "0x86EB350", VA = "0x1886EC350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x86F7A30", Offset = "0x86F6A30", VA = "0x1886F7A30")]
	public static OLILOOIADED JALCPPFBBBJ(float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x86F7B00", Offset = "0x86F6B00", VA = "0x1886F7B00")]
	public static OLILOOIADED JALCPPFBBBJ(MonoBehaviour CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x86F7780", Offset = "0x86F6780", VA = "0x1886F7780")]
	public static OLILOOIADED AFBPDBPNIOG(MonoBehaviour CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x86F7960", Offset = "0x86F6960", VA = "0x1886F7960")]
	public static OLILOOIADED FJKJHGMEAPE(JBOJNOKAFDL INLEBAAACKH, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x86F7BD0", Offset = "0x86F6BD0", VA = "0x1886F7BD0")]
	private static IEnumerator<NFNODNEANBN> OPDDPABBDPC(FIDMLJAOMDI FLDAHOCEDKN, float BHGDBFOAFAM, GFDMGEIMGAF GNDKFGDDNMM, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x86F7900", Offset = "0x86F6900", VA = "0x1886F7900")]
	private static IEnumerator<NFNODNEANBN> DBPCCONKDNN(FIDMLJAOMDI FLDAHOCEDKN, float BHGDBFOAFAM, GFDMGEIMGAF GNDKFGDDNMM, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x86F7870", Offset = "0x86F6870", VA = "0x1886F7870")]
	[IteratorStateMachine(typeof(EOMDMOPBOHP))]
	private static IEnumerator<NFNODNEANBN> DBOGKCFHFAN(PHCKHDLKOLG CJMAPIDFJAD, float BHGDBFOAFAM, GFDMGEIMGAF GNDKFGDDNMM, Action<float> BDLNDMICBAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class NEIPLIAMIFC
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class CCOAGNPIPGB : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public GFDMGEIMGAF queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public CCOAGNPIPGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86E29C0", Offset = "0x86E19C0", VA = "0x1886E29C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x86E2A80", Offset = "0x86E1A80", VA = "0x1886E2A80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x86F88F0", Offset = "0x86F78F0", VA = "0x1886F88F0")]
	[IteratorStateMachine(typeof(CCOAGNPIPGB))]
	private static IEnumerator<NFNODNEANBN> HDFJKBCLLIN(GFDMGEIMGAF DEOJBEPOEPP, Func<bool> BELPALHENKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x86F8980", Offset = "0x86F7980", VA = "0x1886F8980")]
	public static OLILOOIADED IAPPIIMLILA(this MonoBehaviour CAJPFDMILMO, Func<bool> BELPALHENKI, GFDMGEIMGAF DEOJBEPOEPP = GFDMGEIMGAF.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GJMBNINDGIE
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class ECEDJEIOEGD : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public GFDMGEIMGAF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public ECEDJEIOEGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x86E96B0", Offset = "0x86E86B0", VA = "0x1886E96B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x86E9720", Offset = "0x86E8720", VA = "0x1886E9720", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class KGDDKIAKIIE<T> : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public GFDMGEIMGAF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public KGDDKIAKIIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4FD45A0", Offset = "0x4FD35A0", VA = "0x184FD45A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4FD4640", Offset = "0x4FD3640", VA = "0x184FD4640", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class CAPCGMKLEAP : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public GFDMGEIMGAF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private NFNODNEANBN <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public CAPCGMKLEAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x86E1C10", Offset = "0x86E0C10", VA = "0x1886E1C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x86E1CA0", Offset = "0x86E0CA0", VA = "0x1886E1CA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x86ED480", Offset = "0x86EC480", VA = "0x1886ED480")]
	[IteratorStateMachine(typeof(ECEDJEIOEGD))]
	private static IEnumerator<NFNODNEANBN> AIJPGKDNIGC(float EPOJNFBFHFP, GFDMGEIMGAF GNDKFGDDNMM, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x385EA70", Offset = "0x385DA70", VA = "0x18385EA70")]
	[IteratorStateMachine(typeof(KGDDKIAKIIE<>))]
	private static IEnumerator<NFNODNEANBN> AIJPGKDNIGC<T>(float EPOJNFBFHFP, GFDMGEIMGAF GNDKFGDDNMM, Action<T> NPLDOOBBCLG, T GIOLPIPFPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x86EDD10", Offset = "0x86ECD10", VA = "0x1886EDD10")]
	[IteratorStateMachine(typeof(CAPCGMKLEAP))]
	private static IEnumerator<NFNODNEANBN> MCPMHELJMKH(float EPOJNFBFHFP, GFDMGEIMGAF GNDKFGDDNMM, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x86ED970", Offset = "0x86EC970", VA = "0x1886ED970")]
	public static IDisposable FJDPGDIIGBB(this MonoBehaviour CAJPFDMILMO, float EPOJNFBFHFP, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x86EDB40", Offset = "0x86ECB40", VA = "0x1886EDB40")]
	public static OLILOOIADED HDGGMONGDDM(this MonoBehaviour CAJPFDMILMO, float EPOJNFBFHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x86EDA50", Offset = "0x86ECA50", VA = "0x1886EDA50")]
	public static OLILOOIADED FJDPGDIIGBB(this MonoBehaviour CAJPFDMILMO, float EPOJNFBFHFP, GFDMGEIMGAF GNDKFGDDNMM, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x86EDBD0", Offset = "0x86ECBD0", VA = "0x1886EDBD0")]
	public static OLILOOIADED HEHCKMMJBEC(this MonoBehaviour CAJPFDMILMO, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x385EB50", Offset = "0x385DB50", VA = "0x18385EB50")]
	public static OLILOOIADED HEHCKMMJBEC<T>(this MonoBehaviour CAJPFDMILMO, Action<T> NPLDOOBBCLG, T GIOLPIPFPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x86ED830", Offset = "0x86EC830", VA = "0x1886ED830")]
	public static OLILOOIADED ECANCCJGMHF(this MonoBehaviour CAJPFDMILMO, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x86ED520", Offset = "0x86EC520", VA = "0x1886ED520")]
	public static OLILOOIADED BBCJIOLLCJK(this MonoBehaviour CAJPFDMILMO, Action NPLDOOBBCLG, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x86ED8D0", Offset = "0x86EC8D0", VA = "0x1886ED8D0")]
	public static OLILOOIADED ELOOFECPPPJ(this MonoBehaviour CAJPFDMILMO, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x86ED790", Offset = "0x86EC790", VA = "0x1886ED790")]
	public static OLILOOIADED DNJNGAGPKBE(this MonoBehaviour CAJPFDMILMO, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x86EDDB0", Offset = "0x86ECDB0", VA = "0x1886EDDB0")]
	public static OLILOOIADED OBGPINLMHNN(MonoBehaviour CAJPFDMILMO, GFDMGEIMGAF DEOJBEPOEPP, Action NPLDOOBBCLG, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x385EBA0", Offset = "0x385DBA0", VA = "0x18385EBA0")]
	public static OLILOOIADED OBGPINLMHNN<T>(MonoBehaviour CAJPFDMILMO, GFDMGEIMGAF DEOJBEPOEPP, Action<T> NPLDOOBBCLG, T GIOLPIPFPPJ, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x86ED660", Offset = "0x86EC660", VA = "0x1886ED660")]
	public static OLILOOIADED CMFFIBLAAGO(this MonoBehaviour CAJPFDMILMO, float EOOKPLCLOKM, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x86EDC70", Offset = "0x86ECC70", VA = "0x1886EDC70")]
	public static OLILOOIADED JNMFJIJJMFO(this MonoBehaviour CAJPFDMILMO, float EOOKPLCLOKM, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x86ED5C0", Offset = "0x86EC5C0", VA = "0x1886ED5C0")]
	public static OLILOOIADED BFEFADFLEEG(this MonoBehaviour CAJPFDMILMO, float EOOKPLCLOKM, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x86ED6F0", Offset = "0x86EC6F0", VA = "0x1886ED6F0")]
	public static OLILOOIADED DLLJEOOGEBP(this MonoBehaviour CAJPFDMILMO, float EOOKPLCLOKM, Action NPLDOOBBCLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class MMOEGODPPKG : DNNHALOGKMB, IEnumerable<DNNHALOGKMB>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<DNNHALOGKMB> LMGGPNFFOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool BCCJAIMGNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action OIBPNINGGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool AEHNGGEPKKI;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EMOBFKODIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x86F7FB0", Offset = "0x86F6FB0", VA = "0x1886F7FB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EAGGDHPHDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x86F84A0", Offset = "0x86F74A0", VA = "0x1886F84A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x86F80F0", Offset = "0x86F70F0", VA = "0x1886F80F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x86F8540", Offset = "0x86F7540", VA = "0x1886F8540")]
	public MMOEGODPPKG([Optional] Action OIBPNINGGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x86F8370", Offset = "0x86F7370", VA = "0x1886F8370")]
	public void IIGLPCDPOEE(DNNHALOGKMB FNCPIBGPFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x86F8190", Offset = "0x86F7190", VA = "0x1886F8190")]
	private void GANCMHBHNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x86F7FA0", Offset = "0x86F6FA0", VA = "0x1886F7FA0", Slot = "7")]
	public bool ANPLHDIONFM(bool ECOALLGHBMI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x86F7C90", Offset = "0x86F6C90", VA = "0x1886F7C90", Slot = "8")]
	public bool ANPLHDIONFM(Action BDCLNIJAFBF, bool ECOALLGHBMI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x86F82F0", Offset = "0x86F72F0", VA = "0x1886F82F0", Slot = "9")]
	public IEnumerator<DNNHALOGKMB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x86F82F0", Offset = "0x86F72F0", VA = "0x1886F82F0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PHANICMLGIK : CDMPHNKCCOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CCEIFBOAMCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public PHANICMLGIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CCEIFBOAMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x86E2990", Offset = "0x86E1990", VA = "0x1886E2990")]
		internal void EDOBLNJGEBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CCAOHDPEODL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public PHANICMLGIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CCAOHDPEODL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x86E2990", Offset = "0x86E1990", VA = "0x1886E2990")]
		internal void CFNMNAMLNGP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float NKKMDMMHIJN;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x86E9570", Offset = "0x86E8570", VA = "0x1886E9570")]
	public PHANICMLGIK(Behaviour INLEBAAACKH, float NKKMDMMHIJN, [Optional] Action OIBPNINGGFC, [Optional] GJPCEPMOONC PCPLHHLNPGI, [Optional] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x86FB160", Offset = "0x86FA160", VA = "0x1886FB160", Slot = "9")]
	protected override bool GEEOJBFOFBH(Action BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x86FB270", Offset = "0x86FA270", VA = "0x1886FB270", Slot = "10")]
	protected override bool LMIEOELFMOB(Action BDCLNIJAFBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface DNNHALOGKMB
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EMOBFKODIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action EAGGDHPHDIL;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ANPLHDIONFM(bool ECOALLGHBMI = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ANPLHDIONFM(Action BDCLNIJAFBF, bool ECOALLGHBMI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class CDMPHNKCCOJ : DNNHALOGKMB
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class FALCDGIJDEK : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CDMPHNKCCOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public FALCDGIJDEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x86EC3A0", Offset = "0x86EB3A0", VA = "0x1886EC3A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x86EC470", Offset = "0x86EB470", VA = "0x1886EC470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour INLEBAAACKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action OIBPNINGGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private ALBMIKCECHI JBELOEHMMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly GJPCEPMOONC PCPLHHLNPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly FIDMLJAOMDI FLDAHOCEDKN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool EMOBFKODIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1A10830", Offset = "0x1A0F830", VA = "0x181A10830", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action EAGGDHPHDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x86E2FD0", Offset = "0x86E1FD0", VA = "0x1886E2FD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x86E2E60", Offset = "0x86E1E60", VA = "0x1886E2E60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x86E3090", Offset = "0x86E2090", VA = "0x1886E3090")]
	protected CDMPHNKCCOJ(Behaviour INLEBAAACKH, [Optional] Action OIBPNINGGFC, [Optional] GJPCEPMOONC PCPLHHLNPGI, [Optional] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x86E2B30", Offset = "0x86E1B30", VA = "0x1886E2B30", Slot = "7")]
	public bool ANPLHDIONFM(bool ECOALLGHBMI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x86E2AD0", Offset = "0x86E1AD0", VA = "0x1886E2AD0", Slot = "8")]
	public bool ANPLHDIONFM(Action BDCLNIJAFBF, bool ECOALLGHBMI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GEEOJBFOFBH(Action BDCLNIJAFBF);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LMIEOELFMOB(Action BDCLNIJAFBF);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x86E3070", Offset = "0x86E2070", VA = "0x1886E3070")]
	protected void PDANBBNCPLG(Action BDCLNIJAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x86E2C10", Offset = "0x86E1C10", VA = "0x1886E2C10")]
	protected HPIGCMLNLFB EKCDKLECKGP(float JHNMLGDIFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x86E2B90", Offset = "0x86E1B90", VA = "0x1886E2B90")]
	private void EFBNNMLGHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x86E2F00", Offset = "0x86E1F00", VA = "0x1886E2F00")]
	[IteratorStateMachine(typeof(FALCDGIJDEK))]
	private IEnumerator<NFNODNEANBN> GLPJGPHMIHI(float JHNMLGDIFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x86E2F90", Offset = "0x86E1F90", VA = "0x1886E2F90")]
	[CompilerGenerated]
	private void IKBEPLKELBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class IBGJBDLPPNL : CDMPHNKCCOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float PJOFPDNBEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int MDNKCDGICAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float EKKJKLIDDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] MJICBIFPLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int IPKDKBBJFBC;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x86EF930", Offset = "0x86EE930", VA = "0x1886EF930")]
	public IBGJBDLPPNL(Behaviour INLEBAAACKH, float BHNGCEKAGGA, int MDNKCDGICAJ, [Optional] Action OIBPNINGGFC, float EKKJKLIDDIK = 0f, [Optional] GJPCEPMOONC PCPLHHLNPGI, [Optional] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "9")]
	protected override bool GEEOJBFOFBH(Action BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x86EF730", Offset = "0x86EE730", VA = "0x1886EF730", Slot = "10")]
	protected override bool LMIEOELFMOB(Action BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x86EF6B0", Offset = "0x86EE6B0", VA = "0x1886EF6B0")]
	private void CJFCIIHJIJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DPILABBBIPM : CDMPHNKCCOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float NKKMDMMHIJN;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x86E9570", Offset = "0x86E8570", VA = "0x1886E9570")]
	public DPILABBBIPM(Behaviour INLEBAAACKH, float NKKMDMMHIJN, [Optional] Action OIBPNINGGFC, [Optional] GJPCEPMOONC PCPLHHLNPGI, [Optional] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "9")]
	protected override bool GEEOJBFOFBH(Action BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x86E9530", Offset = "0x86E8530", VA = "0x1886E9530", Slot = "10")]
	protected override bool LMIEOELFMOB(Action BDCLNIJAFBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class KIBFIABOGNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class HJOMNEJJCGJ : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public HJOMNEJJCGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x86E35C0", Offset = "0x86E25C0", VA = "0x1886E35C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x86EE2F0", Offset = "0x86ED2F0", VA = "0x1886EE2F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private OLILOOIADED KOLJFMHJHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private JBOJNOKAFDL INLEBAAACKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> PCMPPNHPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private GFDMGEIMGAF DEOJBEPOEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float JIDAKKOAEJP;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x86F1840", Offset = "0x86F0840", VA = "0x1886F1840")]
	public KIBFIABOGNI(JBOJNOKAFDL INLEBAAACKH, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x86F15A0", Offset = "0x86F05A0", VA = "0x1886F15A0")]
	private void IFGGOHKPKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x86F1710", Offset = "0x86F0710", VA = "0x1886F1710")]
	private void PMGLPNEGPEB(string JHEMEKBLBHP, Action HHIPLAGKMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x86F1520", Offset = "0x86F0520", VA = "0x1886F1520")]
	[IteratorStateMachine(typeof(HJOMNEJJCGJ))]
	private IEnumerator<NFNODNEANBN> HCKMHEBMILO(Action HHIPLAGKMDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x86F14C0", Offset = "0x86F04C0", VA = "0x1886F14C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x86F1340", Offset = "0x86F0340", VA = "0x1886F1340")]
	[CompilerGenerated]
	private void DKKGFBCNNIC(string GGOAKKKDCJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class HMOLJNKMOCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class CPGBPDGPCOF : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public CPGBPDGPCOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x86E35C0", Offset = "0x86E25C0", VA = "0x1886E35C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x86E3630", Offset = "0x86E2630", VA = "0x1886E3630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private OLILOOIADED KOLJFMHJHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour CAJPFDMILMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action BDLNDMICBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> PCMPPNHPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private GFDMGEIMGAF DEOJBEPOEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float JIDAKKOAEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool HGEKCMOPJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly GJPCEPMOONC PCPLHHLNPGI;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x86EF170", Offset = "0x86EE170", VA = "0x1886EF170")]
	public HMOLJNKMOCL(MonoBehaviour CAJPFDMILMO, Action BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x86EF4E0", Offset = "0x86EE4E0", VA = "0x1886EF4E0")]
	public HMOLJNKMOCL(MonoBehaviour CAJPFDMILMO, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x86EF300", Offset = "0x86EE300", VA = "0x1886EF300")]
	public HMOLJNKMOCL(MonoBehaviour CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4B504C0", Offset = "0x4B4F4C0", VA = "0x184B504C0")]
	private HMOLJNKMOCL(GJPCEPMOONC PCPLHHLNPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x86EEF40", Offset = "0x86EDF40", VA = "0x1886EEF40")]
	internal static HMOLJNKMOCL POOGHIMKFMH(MonoBehaviour CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x86EEAD0", Offset = "0x86EDAD0", VA = "0x1886EEAD0")]
	private void JALCPPFBBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x86EEC90", Offset = "0x86EDC90", VA = "0x1886EEC90")]
	private void NOAAFMLIAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x86EE960", Offset = "0x86ED960", VA = "0x1886EE960")]
	private void IFGGOHKPKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x86EE6C0", Offset = "0x86ED6C0", VA = "0x1886EE6C0")]
	private void EDAGOBEFOLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x86EEE10", Offset = "0x86EDE10", VA = "0x1886EEE10")]
	private void PMGLPNEGPEB(string JHEMEKBLBHP, Action HHIPLAGKMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x86EE8E0", Offset = "0x86ED8E0", VA = "0x1886EE8E0")]
	[IteratorStateMachine(typeof(CPGBPDGPCOF))]
	private IEnumerator<NFNODNEANBN> HCKMHEBMILO(Action HHIPLAGKMDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x86EE660", Offset = "0x86ED660", VA = "0x1886EE660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x86EEC00", Offset = "0x86EDC00", VA = "0x1886EEC00")]
	[CompilerGenerated]
	private void KBLCBHBGLJJ(string GGOAKKKDCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x86EE540", Offset = "0x86ED540", VA = "0x1886EE540")]
	[CompilerGenerated]
	private void BBGEDDJOOAP(string GGOAKKKDCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x86EE5D0", Offset = "0x86ED5D0", VA = "0x1886EE5D0")]
	[CompilerGenerated]
	private void CCHOLFKEBEJ(string GGOAKKKDCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x86EE850", Offset = "0x86ED850", VA = "0x1886EE850")]
	[CompilerGenerated]
	private void EOBNHEHCBPE(string GGOAKKKDCJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum GOMLIAEFFPN : byte
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
internal sealed class DDKPNLMJDOA : FIDMLJAOMDI
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float MDGNLFFDOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x86E8B40", Offset = "0x86E7B40", VA = "0x1886E8B40", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float KNJNKHNADLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x86E8B30", Offset = "0x86E7B30", VA = "0x1886E8B30", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double OJMJBBKEHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x86E8B50", Offset = "0x86E7B50", VA = "0x1886E8B50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x86E8AC0", Offset = "0x86E7AC0", VA = "0x1886E8AC0")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void JPEDEHNINOC(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	[UnityEngine.Scripting.Preserve]
	internal DDKPNLMJDOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface BGNCEBKJOKG
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHADDOKHEFP(string NFHOBPDKIPM);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDLIKACFBGG();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface JPMAGBMLEDD
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool DJLLMFIFBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool KBKGBFICNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class DIALIABFGFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public LOCOOBAJJGD OKGEEIKJFJG;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int CEBFMOBHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x86E9090", Offset = "0x86E8090", VA = "0x1886E9090")]
	public static NFNODNEANBN IPLLHHFHOOC(IEnumerator<NFNODNEANBN> GNLGPPNCEJJ, KAFMFFJBHFN BKPHILMDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x86E8FD0", Offset = "0x86E7FD0", VA = "0x1886E8FD0")]
	public NFNODNEANBN IPLLHHFHOOC(KAFMFFJBHFN[] DHJEOPJCODM, IEnumerator<NFNODNEANBN>[] JLPCPIPHMEI, NFNODNEANBN[] CPAABEDEKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x86E8E60", Offset = "0x86E7E60", VA = "0x1886E8E60")]
	public void NPMAMJJIGME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x86E8E90", Offset = "0x86E7E90", VA = "0x1886E8E90")]
	public void BMHEDJKPMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x86E91F0", Offset = "0x86E81F0", VA = "0x1886E91F0")]
	public void NJICABBIMAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x86E8E60", Offset = "0x86E7E60", VA = "0x1886E8E60")]
	public void AKBKNLLCFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public DIALIABFGFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class LOCOOBAJJGD
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct HCLMAOBOJOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public DIALIABFGFG NGEKJFBEICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public JBOJNOKAFDL JGEDCNIFGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public KAFMFFJBHFN INGAPPEHBPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<NFNODNEANBN> NKLADAHDIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public NFNODNEANBN DJCJBGMNEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public GOMLIAEFFPN FKHFCMMACJB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct LMLGPHDLOIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public GFDMGEIMGAF OOEIDJMMHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<HCLMAOBOJOA> AJMHPFDDMMG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class NLLPFPCCCPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public KAFMFFJBHFN promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public LOCOOBAJJGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public JBOJNOKAFDL context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public DIALIABFGFG routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public GOMLIAEFFPN coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public NFNODNEANBN currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<NFNODNEANBN> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NLLPFPCCCPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x86F8B50", Offset = "0x86F7B50", VA = "0x1886F8B50")]
		internal void FGLOIIJPIHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class EFJAJJJICKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public DIALIABFGFG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public LOCOOBAJJGD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EFJAJJJICKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x86E9770", Offset = "0x86E8770", VA = "0x1886E9770")]
		internal void IFBIHEPLLFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class EFLKABKAFAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public DIALIABFGFG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public LOCOOBAJJGD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EFLKABKAFAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x86E97B0", Offset = "0x86E87B0", VA = "0x1886E97B0")]
		internal void OKHJOABIABI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class KELGOGFCAEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public DIALIABFGFG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public LOCOOBAJJGD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KELGOGFCAEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x86F1300", Offset = "0x86F0300", VA = "0x1886F1300")]
		internal void PMIOBFLLCOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const GOMLIAEFFPN FFNLOEMFOFG = GOMLIAEFFPN.Cancelled | GOMLIAEFFPN.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly GFDMGEIMGAF DEOJBEPOEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] GBNALBKIGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<GOMLIAEFFPN> INPFAJFMNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> NLGKMCCAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> ALDOMIFLCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> LLGIAAMOODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> NDMKGFODOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> BLMONIJLILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> BDNBICIKJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private DIALIABFGFG[] OMNFMONBLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private KAFMFFJBHFN[] DHJEOPJCODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private JBOJNOKAFDL[] MJPIOKABGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<NFNODNEANBN>[] POMCCHHHJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NFNODNEANBN[] FIJAJJEGIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int PPFAPLPHLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int GDBMBEIFFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int HNDEALABJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float MIHGNNIOOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private ICNFIOGAGFC HGKMIMOFFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle FNMBDNKJGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<DIALIABFGFG> BOJMGGCOGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool LLPHJJFJMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> OKFJLNGCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> LNHEDJPIMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool EFFCLIFCPEK;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public LMLGPHDLOIK[] LMKFLGGDIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA9B5B0", Offset = "0xA9A5B0", VA = "0x180A9B5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x86F3620", Offset = "0x86F2620", VA = "0x1886F3620")]
	private static int CHMHFCLKFCF(GFDMGEIMGAF DEOJBEPOEPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x86F51E0", Offset = "0x86F41E0", VA = "0x1886F51E0")]
	public LOCOOBAJJGD(GFDMGEIMGAF DEOJBEPOEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x86F3FC0", Offset = "0x86F2FC0", VA = "0x1886F3FC0")]
	private void GKAHKJMEDDN(int AJEKANBGFPA, int DPJEJNADMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x86F3650", Offset = "0x86F2650", VA = "0x1886F3650")]
	public void CNLHPLNKHLN(JBOJNOKAFDL INLEBAAACKH, NFNODNEANBN PKHEJKMIMNN, IEnumerator<NFNODNEANBN> GNLGPPNCEJJ, KAFMFFJBHFN BKPHILMDNNH, [Optional] DIALIABFGFG JBPNOMDJAMN, GOMLIAEFFPN PODPFFDGFCN = GOMLIAEFFPN.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x86F4FA0", Offset = "0x86F3FA0", VA = "0x1886F4FA0")]
	public void PAPPCCJNIHC(IEnumerable<HCLMAOBOJOA> EMEJJHDKLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x86F4350", Offset = "0x86F3350", VA = "0x1886F4350")]
	private HCLMAOBOJOA KKMCJGBGHPJ(int FMAEFMFEIND)
	{
		return default(HCLMAOBOJOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x86F2E50", Offset = "0x86F1E50", VA = "0x1886F2E50")]
	private void AEFDIDCGBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x38FD420", Offset = "0x38FC420", VA = "0x1838FD420")]
	private static void BJMCEJLEOAH<T>(int FMAEFMFEIND, T[] OGGPCCJAFEB, int CFNMLMNHCMF, [Optional] T PHELKGBOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x38FD470", Offset = "0x38FC470", VA = "0x1838FD470")]
	private static void BJMCEJLEOAH<T>(int FMAEFMFEIND, NativeArray<T> OGGPCCJAFEB, int CFNMLMNHCMF, [Optional] T PHELKGBOELE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x86F4820", Offset = "0x86F3820", VA = "0x1886F4820")]
	private void KLEJFFDOGIC(IEnumerable<HCLMAOBOJOA> EMEJJHDKLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x86F37D0", Offset = "0x86F27D0", VA = "0x1886F37D0")]
	private void EMBOOECAAOP(HCLMAOBOJOA IOMKLCPCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x86F4BC0", Offset = "0x86F3BC0", VA = "0x1886F4BC0")]
	private OPNEOPAIPOG MBPLJJDEGFM(int JFPHNEEFGLE)
	{
		return default(OPNEOPAIPOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x86F3420", Offset = "0x86F2420", VA = "0x1886F3420")]
	public void ANJOKGEPFDI(float DBEFOCGFFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x86F41A0", Offset = "0x86F31A0", VA = "0x1886F41A0")]
	private void GKHHFDOIJJB(Action FDJHCIBLFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x86F4E20", Offset = "0x86F3E20", VA = "0x1886F4E20")]
	private void MONLOAEMJAC(Action FDJHCIBLFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x86F38A0", Offset = "0x86F28A0", VA = "0x1886F38A0")]
	public void GBJHJABLBHA(float DBEFOCGFFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x86F4EA0", Offset = "0x86F3EA0", VA = "0x1886F4EA0")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x86F32F0", Offset = "0x86F22F0", VA = "0x1886F32F0")]
	public void AKBKNLLCFBD(DIALIABFGFG CJMAPIDFJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x86F31C0", Offset = "0x86F21C0", VA = "0x1886F31C0")]
	public void AFDGONJKHDP(DIALIABFGFG CJMAPIDFJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x86F4220", Offset = "0x86F3220", VA = "0x1886F4220")]
	public void JCGJPJMJOIK(DIALIABFGFG CJMAPIDFJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class NOJIGDKLIDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly NOJIGDKLIDC KKKNNENCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action AAMIKNLELJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool CIAFEFCBLPC;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public NOJIGDKLIDC(Action AAMIKNLELJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D87190", Offset = "0x7D86190", VA = "0x187D87190", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface GIPHGDHABGH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable OCKNEDAJIFC(UnityEngine.Object INLEBAAACKH, Action<T> AFONHCFPODA);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface KDPKEHHLDMA<T> : GIPHGDHABGH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class DELPJMBIHJM<T> : KDPKEHHLDMA<T>, GIPHGDHABGH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class PJGJKGMOGNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public DELPJMBIHJM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public HMGCNMGOPPM<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public PJGJKGMOGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5610320", Offset = "0x560F320", VA = "0x185610320")]
		internal void DLCMGMJAMDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject PJNILJBLIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<HMGCNMGOPPM<UnityEngine.Object, Action<T>>> AEIKKBOGNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T CDMFIODGJCE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xAA5F80", Offset = "0xAA4F80", VA = "0x180AA5F80", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A56F70", Offset = "0x6A55F70", VA = "0x186A56F70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A56DF0", Offset = "0x6A55DF0", VA = "0x186A56DF0")]
	private static bool DJKPNGENBIE(T FDJHCIBLFFB, T CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A57460", Offset = "0x6A56460", VA = "0x186A57460")]
	public DELPJMBIHJM(T FFPHGFOFACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A571E0", Offset = "0x6A561E0", VA = "0x186A571E0", Slot = "6")]
	public IDisposable OCKNEDAJIFC(UnityEngine.Object INLEBAAACKH, Action<T> AFONHCFPODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A56A70", Offset = "0x6A55A70", VA = "0x186A56A70")]
	private void BEKPGAFDMCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class NPNFJCOJDHJ : CNKBCNLGABK
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class HCCBADJAPEC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class ENDMOFGEMAJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int HJPLNJNIFLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private HCCBADJAPEC GNDKFGDDNMM;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xEAD600", Offset = "0xEAC600", VA = "0x180EAD600")]
			public ENDMOFGEMAJ(int HJPLNJNIFLL, HCCBADJAPEC GNDKFGDDNMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x86EC2A0", Offset = "0x86EB2A0", VA = "0x1886EC2A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class ECEONPEFNNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public ECEONPEFNNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xDA0930", Offset = "0xD9F930", VA = "0x180DA0930")]
			internal bool HGAIEBIGDEI(FCJPLLBIOCL e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class BMAOMJDMBOC : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private NFNODNEANBN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public HCCBADJAPEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public FIDMLJAOMDI timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private DLFDLGIBKAH <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<FCJPLLBIOCL> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
			[DebuggerHidden]
			public BMAOMJDMBOC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x86E16B0", Offset = "0x86E06B0", VA = "0x1886E16B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x86E19E0", Offset = "0x86E09E0", VA = "0x1886E19E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly GFDMGEIMGAF DEOJBEPOEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private OLILOOIADED BKPHILMDNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<FCJPLLBIOCL> PPBIAJGFOEK;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x86EE250", Offset = "0x86ED250", VA = "0x1886EE250")]
		public HCCBADJAPEC(GFDMGEIMGAF DEOJBEPOEPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x86EE030", Offset = "0x86ED030", VA = "0x1886EE030")]
		public IDisposable NBKPOICJOBJ(FCJPLLBIOCL PILHKLCKECK, GJPCEPMOONC PCPLHHLNPGI, FIDMLJAOMDI DCCJGOAMNIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x86EDEA0", Offset = "0x86ECEA0", VA = "0x1886EDEA0")]
		private void IDFMEFBADJJ(int HJPLNJNIFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x86EE1C0", Offset = "0x86ED1C0", VA = "0x1886EE1C0")]
		[IteratorStateMachine(typeof(BMAOMJDMBOC))]
		private IEnumerator<NFNODNEANBN> OPDDPABBDPC(FIDMLJAOMDI DCCJGOAMNIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x86EDE50", Offset = "0x86ECE50", VA = "0x1886EDE50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class FCJPLLBIOCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum MFOPJGAPDCO : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int LMAMKHLEFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int OJLJBFKDCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly FHBMACKKPGL JGEDCNIFGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour FJOANIEJHIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action IEKHBJGOAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> LMNFNHBLHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float PGAGOKGIEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float NLGKMCCAGFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string IJKBIMCGCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool JLDABFHKKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly MFOPJGAPDCO ENCNOCIFLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool OHFCKKNIKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool NNAGDOAAGMI;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x86EC870", Offset = "0x86EB870", VA = "0x1886EC870")]
		public FCJPLLBIOCL(FHBMACKKPGL INLEBAAACKH, Action BDLNDMICBAA, bool FECBKDFCJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x86EC9F0", Offset = "0x86EB9F0", VA = "0x1886EC9F0")]
		public FCJPLLBIOCL(FHBMACKKPGL INLEBAAACKH, Action<float> BDLNDMICBAA, bool FECBKDFCJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x86EC690", Offset = "0x86EB690", VA = "0x1886EC690")]
		public FCJPLLBIOCL(FHBMACKKPGL INLEBAAACKH, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, FIDMLJAOMDI DCCJGOAMNIL, MFOPJGAPDCO HIEEGJOADLN, bool HGEKCMOPJEG, bool FECBKDFCJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x86EC4C0", Offset = "0x86EB4C0", VA = "0x1886EC4C0")]
		public bool DMNJADNLCPF(float EPGNCELGAFP, float ECBHLBONMEC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly GJPCEPMOONC PCPLHHLNPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly FIDMLJAOMDI FLDAHOCEDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<GFDMGEIMGAF, HCCBADJAPEC> EIJKMMGAFPB;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x86F9FC0", Offset = "0x86F8FC0", VA = "0x1886F9FC0")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void IFDFJOEJDEI(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x86FA330", Offset = "0x86F9330", VA = "0x1886FA330")]
	[UnityEngine.Scripting.Preserve]
	internal NPNFJCOJDHJ([DJIFKCCBBND(null)] GJPCEPMOONC PCPLHHLNPGI, [DJIFKCCBBND(null)] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x86F9DD0", Offset = "0x86F8DD0", VA = "0x1886F9DD0", Slot = "4")]
	public IDisposable IEKHBJGOAKB(FHBMACKKPGL INLEBAAACKH, Action COLEJLDPDCO, GFDMGEIMGAF DEOJBEPOEPP, bool FECBKDFCJKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x86F9BE0", Offset = "0x86F8BE0", VA = "0x1886F9BE0", Slot = "5")]
	public IDisposable IEKHBJGOAKB(FHBMACKKPGL INLEBAAACKH, Action<float> COLEJLDPDCO, GFDMGEIMGAF DEOJBEPOEPP, bool FECBKDFCJKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x86F9860", Offset = "0x86F8860", VA = "0x1886F9860", Slot = "7")]
	public IDisposable BHAJIFFIHFJ(FHBMACKKPGL INLEBAAACKH, float BHGDBFOAFAM, Action<float> COLEJLDPDCO, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x86F9AE0", Offset = "0x86F8AE0", VA = "0x1886F9AE0", Slot = "8")]
	public IDisposable CLOCAAOLFJI(FHBMACKKPGL INLEBAAACKH, float BHGDBFOAFAM, Action<float> COLEJLDPDCO, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x86F9960", Offset = "0x86F8960", VA = "0x1886F9960", Slot = "6")]
	public IDisposable BHAJIFFIHFJ(float BHGDBFOAFAM, Action<float> COLEJLDPDCO, bool HGEKCMOPJEG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x86FA170", Offset = "0x86F9170", VA = "0x1886FA170", Slot = "9")]
	public void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x86FA030", Offset = "0x86F9030", VA = "0x1886FA030")]
	private HCCBADJAPEC JMLCGOHAIAP(GFDMGEIMGAF DEOJBEPOEPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class CAPDDJBOHGK : MFLOAHPLBFM, GJPCEPMOONC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private LOCOOBAJJGD[] NEJGIOAJNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private BGNCEBKJOKG LMKADFOMHBF;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x86E2470", Offset = "0x86E1470", VA = "0x1886E2470")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void JPEDEHNINOC(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x86E28D0", Offset = "0x86E18D0", VA = "0x1886E28D0")]
	[UnityEngine.Scripting.Preserve]
	public CAPDDJBOHGK([DJIFKCCBBND(null)] MJMOCHGMCPG EHJINILELBM, [DJIFKCCBBND(null)] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x86E2040", Offset = "0x86E1040", VA = "0x1886E2040", Slot = "19")]
	public override OLILOOIADED FLGDMILKHPN(JBOJNOKAFDL INLEBAAACKH, IEnumerator<NFNODNEANBN> GPEBENOKHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x86E24E0", Offset = "0x86E14E0", VA = "0x1886E24E0", Slot = "20")]
	public override void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x86E2170", Offset = "0x86E1170", VA = "0x1886E2170", Slot = "22")]
	public override void GNOBEHDLJOO(GFDMGEIMGAF DEOJBEPOEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x86E23A0", Offset = "0x86E13A0", VA = "0x1886E23A0", Slot = "21")]
	protected override void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x86E2780", Offset = "0x86E1780", VA = "0x1886E2780")]
	private LOCOOBAJJGD MEGLBEBEIJC(GFDMGEIMGAF MLCOGCMJLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x86E1CF0", Offset = "0x86E0CF0", VA = "0x1886E1CF0", Slot = "23")]
	internal override OLHELBELJFF AKAAGIMENIP(IEnumerator<NFNODNEANBN> GPEBENOKHFI, Behaviour INLEBAAACKH, KAFMFFJBHFN BKPHILMDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x86E1F80", Offset = "0x86E0F80", VA = "0x1886E1F80", Slot = "24")]
	internal override EHKFPACOPFD EFGGLFGLFDI(GFDMGEIMGAF GNDKFGDDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x86E27B0", Offset = "0x86E17B0", VA = "0x1886E27B0")]
	private void OCJNPEOHNNM(LOCOOBAJJGD ODFKNKFFGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x86E1F20", Offset = "0x86E0F20", VA = "0x1886E1F20", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct ICNFIOGAGFC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float NPFDHBBPODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int DDOEJGHLLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> JHJMFPLBLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> CEEDOGGAOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> ECDEDHJPPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<GOMLIAEFFPN> GAPJCIMHEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> JAFFNJIPAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> NDMKGFODOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> ALDOMIFLCFN;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x86EFBE0", Offset = "0x86EEBE0", VA = "0x1886EFBE0")]
	public static ICNFIOGAGFC FLLMCNLHKNL(int ENKAJOBEFHI, float DBEFOCGFFJA, NativeArray<GOMLIAEFFPN> GBGEPEALFIO, NativeArray<float> LCLHFONDAGJ, NativeArray<int> NPJKJMFJKLI, NativeArray<int> NFNEEOGGBDM, NativeArray<int> LFENBNNDKIM, NativeArray<int> CEEDOGGAOOD, NativeArray<int> ECDEDHJPPFJ)
	{
		return default(ICNFIOGAGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x86EFB00", Offset = "0x86EEB00", VA = "0x1886EFB00", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x86EFDE0", Offset = "0x86EEDE0", VA = "0x1886EFDE0")]
	private bool KGHPMLLJLHH(int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x86EFC40", Offset = "0x86EEC40", VA = "0x1886EFC40")]
	private void GFFELNAINBE(NativeArray<int> OGAMHOMMEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x86EFC70", Offset = "0x86EEC70", VA = "0x1886EFC70")]
	private int HADIKFKPDCB(int LOHCKAAJAJO, int FAJGDEPPNFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x86EFD10", Offset = "0x86EED10", VA = "0x1886EFD10")]
	private void IJGFJEDLJEI(NativeArray<int> OGAMHOMMEAC, int GMFIGOEDGCM, int NFFBJCCKPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x86EFE20", Offset = "0x86EEE20", VA = "0x1886EFE20")]
	private void LOEPFCKANJI(NativeArray<int> OGAMHOMMEAC, int FODJNPNNNLC, int KAHIEGAILBA, int DDAADBNBHMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class MFLOAHPLBFM : GJPCEPMOONC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly MJMOCHGMCPG EHJINILELBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly FIDMLJAOMDI FLDAHOCEDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private EHKFPACOPFD[] FKAMAIKOGII;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static GJPCEPMOONC MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x86F69B0", Offset = "0x86F59B0", VA = "0x1886F69B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public GFDMGEIMGAF MOIAPBNLBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GFDMGEIMGAF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public FIDMLJAOMDI DPJPGOLCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public NFNODNEANBN PGLDJNGGOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NFNODNEANBN IPFMCFPJANL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public NFNODNEANBN EGLCNIAPMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NFNODNEANBN AIANBPEEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x86F6D00", Offset = "0x86F5D00", VA = "0x1886F6D00")]
	public static OLILOOIADED HJHONNMKAAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x86F7290", Offset = "0x86F6290", VA = "0x1886F7290")]
	[UnityEngine.Scripting.Preserve]
	protected MFLOAHPLBFM([DJIFKCCBBND(null)] MJMOCHGMCPG EHJINILELBM, [DJIFKCCBBND(null)] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x86F6C40", Offset = "0x86F5C40", VA = "0x1886F6C40", Slot = "6")]
	public OLILOOIADED GDMALPFODEM(IEnumerator<NFNODNEANBN> GPEBENOKHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x86F6A40", Offset = "0x86F5A40", VA = "0x1886F6A40", Slot = "7")]
	public OLILOOIADED GDMALPFODEM(Behaviour INLEBAAACKH, IEnumerator<NFNODNEANBN> GPEBENOKHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract OLILOOIADED FLGDMILKHPN(JBOJNOKAFDL INLEBAAACKH, IEnumerator<NFNODNEANBN> GPEBENOKHFI);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x86F6FE0", Offset = "0x86F5FE0", VA = "0x1886F6FE0", Slot = "20")]
	public virtual void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x86F6330", Offset = "0x86F5330", VA = "0x1886F6330", Slot = "9")]
	public void AKLOKBMEPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x86F6D90", Offset = "0x86F5D90", VA = "0x1886F6D90", Slot = "21")]
	protected virtual void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x86F71E0", Offset = "0x86F61E0", VA = "0x1886F71E0")]
	private void OMLCMBHOPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x86F6FC0", Offset = "0x86F5FC0", VA = "0x1886F6FC0")]
	private void KFBOHBEKNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x86F6F80", Offset = "0x86F5F80", VA = "0x1886F6F80")]
	private void JDNAJILJLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x86F6990", Offset = "0x86F5990", VA = "0x1886F6990")]
	private void FJHKGKPOOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x86F6A20", Offset = "0x86F5A20", VA = "0x1886F6A20")]
	private void GACKGMPFEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x86F6CE0", Offset = "0x86F5CE0", VA = "0x1886F6CE0")]
	private void HBDHJFKOJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x86F6FA0", Offset = "0x86F5FA0", VA = "0x1886F6FA0")]
	private void JJLCLDJEFKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x86F6C50", Offset = "0x86F5C50", VA = "0x1886F6C50", Slot = "22")]
	public virtual void GNOBEHDLJOO(GFDMGEIMGAF DEOJBEPOEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x86F6DB0", Offset = "0x86F5DB0", VA = "0x1886F6DB0")]
	private void ILIGGPNJHGL(EHKFPACOPFD ODFKNKFFGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x266AF80", Offset = "0x2669F80", VA = "0x18266AF80")]
	private EHKFPACOPFD IOFDPAEDCJF(GFDMGEIMGAF MLCOGCMJLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract OLHELBELJFF AKAAGIMENIP(IEnumerator<NFNODNEANBN> GPEBENOKHFI, Behaviour CAJPFDMILMO, KAFMFFJBHFN JBEMIHCLCHN);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract EHKFPACOPFD EFGGLFGLFDI(GFDMGEIMGAF DEOJBEPOEPP);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x86F6570", Offset = "0x86F5570", VA = "0x1886F6570", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x86F7180", Offset = "0x86F6180", VA = "0x1886F7180", Slot = "15")]
	public NFNODNEANBN NIFNJJMKMGK(GFDMGEIMGAF GNDKFGDDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x86F7200", Offset = "0x86F6200", VA = "0x1886F7200", Slot = "16")]
	public NFNODNEANBN ONJFDJNFEMF(float EPOJNFBFHFP, GFDMGEIMGAF GNDKFGDDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x86F6930", Offset = "0x86F5930", VA = "0x1886F6930", Slot = "17")]
	public NFNODNEANBN EPLMPKODCAD(Func<bool> BELPALHENKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class OLHELBELJFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly KAFMFFJBHFN BKPHILMDNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly JPMAGBMLEDD INLEBAAACKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool KOOBIOPJIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string NFHOBPDKIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace KEBFMIBJDMG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<NFNODNEANBN> NKLADAHDIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NFNODNEANBN DJCJBGMNEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool BMHKHIBDACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x86FAC90", Offset = "0x86F9C90", VA = "0x1886FAC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool HBCJGPDCNPL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xC118F0", Offset = "0xC108F0", VA = "0x180C118F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xC17A10", Offset = "0xC16A10", VA = "0x180C17A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x86FAD10", Offset = "0x86F9D10", VA = "0x1886FAD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float EILLPENJBDN
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x10630A0", Offset = "0x10620A0", VA = "0x1810630A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x702F7C0", Offset = "0x702E7C0", VA = "0x18702F7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x86FAFA0", Offset = "0x86F9FA0", VA = "0x1886FAFA0")]
	public OLHELBELJFF(IEnumerator<NFNODNEANBN> GNLGPPNCEJJ, JPMAGBMLEDD INLEBAAACKH, KAFMFFJBHFN BKPHILMDNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x86FA970", Offset = "0x86F9970", VA = "0x1886FA970")]
	public NFNODNEANBN IPLLHHFHOOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x86FA900", Offset = "0x86F9900", VA = "0x1886FA900")]
	public bool INFGKNOCLHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x86FA8B0", Offset = "0x86F98B0", VA = "0x1886FA8B0")]
	public void AKBKNLLCFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x86FAEC0", Offset = "0x86F9EC0", VA = "0x1886FAEC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xC6E610", Offset = "0xC6D610", VA = "0x180C6E610")]
	[CompilerGenerated]
	private void IGONCHDHIHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class KAFMFFJBHFN : ILCPGOOBIBP, OLILOOIADED, ALBMIKCECHI, HPIGCMLNLFB, IEnumerator, NFNODNEANBN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private GFDMGEIMGAF AINNMNDHOCM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private GFDMGEIMGAF DDAFOIICKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD5A130", Offset = "0xD59130", VA = "0x180D5A130", Slot = "23")]
		get
		{
			return default(GFDMGEIMGAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GFDMGEIMGAF OKGEEIKJFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xF356D0", Offset = "0xF346D0", VA = "0x180F356D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float FCLIHMDHNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xBA6BC0", Offset = "0xBA5BC0", VA = "0x180BA6BC0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BDOOEIEHABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x86F0D10", Offset = "0x86EFD10", VA = "0x1886F0D10", Slot = "24")]
	private bool HKEKHDAOGBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x86F0D00", Offset = "0x86EFD00", VA = "0x1886F0D00", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x86F0D30", Offset = "0x86EFD30", VA = "0x1886F0D30")]
	public KAFMFFJBHFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum OPNEOPAIPOG : byte
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
internal sealed class EHKFPACOPFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum OLCJDGCOOFC
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct FGOOCMHCPIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public GFDMGEIMGAF OOEIDJMMHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public OLCJDGCOOFC ELBJMNBOCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<OLHELBELJFF> AFBFCGLFLPM;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly OLCJDGCOOFC[] EKELGHBFCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly GFDMGEIMGAF DEOJBEPOEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool AMKDLLOMBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly OLHELBELJFF[] JFDEJACJAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<OLHELBELJFF> NLAPEOFMEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> OHBHPIFPOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<OLHELBELJFF> OGEBCOIHHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> PIPKDEJNPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly BGNCEBKJOKG EBONLCHEFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool EFFCLIFCPEK;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public FGOOCMHCPIF[,] HGLCPKHKGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x86EB480", Offset = "0x86EA480", VA = "0x1886EB480")]
	public EHKFPACOPFD(GFDMGEIMGAF GNDKFGDDNMM, BGNCEBKJOKG EBONLCHEFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x86EB230", Offset = "0x86EA230", VA = "0x1886EB230")]
	public void PKAKJENIKAE(OLHELBELJFF GNLGPPNCEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x86EA710", Offset = "0x86E9710", VA = "0x1886EA710")]
	public void HHFLOBJHEBE(IList<OLHELBELJFF> JLPCPIPHMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x86EAF30", Offset = "0x86E9F30", VA = "0x1886EAF30")]
	public void PHCICAOKOHH(IList<OLHELBELJFF> JLPCPIPHMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x86EAB80", Offset = "0x86E9B80", VA = "0x1886EAB80")]
	private void JNEGJGEFEGI(OLHELBELJFF GNLGPPNCEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x86EA580", Offset = "0x86E9580", VA = "0x1886EA580")]
	private void FJMFLOHEJOH(IList<OLHELBELJFF> JLPCPIPHMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x86EAC70", Offset = "0x86E9C70", VA = "0x1886EAC70")]
	private OPNEOPAIPOG KIDECJPNCMJ(OLHELBELJFF GNLGPPNCEJJ)
	{
		return default(OPNEOPAIPOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x86EAA10", Offset = "0x86E9A10", VA = "0x1886EAA10")]
	public void IEKHBJGOAKB(float DBEFOCGFFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x86E9F10", Offset = "0x86E8F10", VA = "0x1886E9F10")]
	public void AKLOKBMEPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x86EA220", Offset = "0x86E9220", VA = "0x1886EA220")]
	private void EDKDFGHOGGE(List<OLHELBELJFF> JLPCPIPHMEI, Stack<int> NKJAFBJLGCL, bool LNNHGFIEPFA, float CAPGLLMJJCL = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x86EA100", Offset = "0x86E9100", VA = "0x1886EA100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x86EADF0", Offset = "0x86E9DF0", VA = "0x1886EADF0")]
	private void MBDINFPBBMH(List<OLHELBELJFF> JLPCPIPHMEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class DOPPCPJDJLJ : BGNCEBKJOKG
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void GHADDOKHEFP(string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
	public void NDLIKACFBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public DOPPCPJDJLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class NFJJGMJDHMG : JPMAGBMLEDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour CAJPFDMILMO;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x86F8A60", Offset = "0x86F7A60", VA = "0x1886F8A60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DJLLMFIFBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x86F8AE0", Offset = "0x86F7AE0", VA = "0x1886F8AE0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool KBKGBFICNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x86F8B30", Offset = "0x86F7B30", VA = "0x1886F8B30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public NFJJGMJDHMG(Behaviour CAJPFDMILMO)
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

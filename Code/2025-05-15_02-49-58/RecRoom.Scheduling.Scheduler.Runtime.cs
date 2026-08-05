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
		[Cpp2IlInjected.Address(RVA = "0x86DC9D0", Offset = "0x86DAFD0", VA = "0x1886DC9D0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E4BA0", Offset = "0x86E31A0", VA = "0x1886E4BA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x86D5390", Offset = "0x86D3990", VA = "0x1886D5390")]
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
				[Cpp2IlInjected.Address(RVA = "0x86CA670", Offset = "0x86C8C70", VA = "0x1886CA670")]
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
				[Cpp2IlInjected.Address(RVA = "0x86DC7F0", Offset = "0x86DADF0", VA = "0x1886DC7F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x86E1330", Offset = "0x86DF930", VA = "0x1886E1330")]
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
				[Cpp2IlInjected.Address(RVA = "0x86D99F0", Offset = "0x86D7FF0", VA = "0x1886D99F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x86CFD20", Offset = "0x86CE320", VA = "0x1886CFD20")]
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
				[Cpp2IlInjected.Address(RVA = "0x86D7AF0", Offset = "0x86D60F0", VA = "0x1886D7AF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x86CA490", Offset = "0x86C8A90", VA = "0x1886CA490")]
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
				[Cpp2IlInjected.Address(RVA = "0x86D9C30", Offset = "0x86D8230", VA = "0x1886D9C30")]
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
				[Cpp2IlInjected.Address(RVA = "0x86D3C20", Offset = "0x86D2220", VA = "0x1886D3C20")]
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
				[Cpp2IlInjected.Address(RVA = "0x86D04C0", Offset = "0x86CEAC0", VA = "0x1886D04C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x86D7FD0", Offset = "0x86D65D0", VA = "0x1886D7FD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x86D42F0", Offset = "0x86D28F0", VA = "0x1886D42F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x86D4110", Offset = "0x86D2710", VA = "0x1886D4110")]
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
				[Cpp2IlInjected.Address(RVA = "0x86D89D0", Offset = "0x86D6FD0", VA = "0x1886D89D0")]
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
					[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
					public PMLOHCFJNED()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x86E3A10", Offset = "0x86E2010", VA = "0x1886E3A10")]
					internal void KPAKLKNHGDB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static NPNKPOOAOFG<CLBMOHIOJNE> DFHPHCDPEKO;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x86E1600", Offset = "0x86DFC00", VA = "0x1886E1600")]
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
					[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
					public KBDGFKFBJMM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x86D7D50", Offset = "0x86D6350", VA = "0x1886D7D50")]
					internal void DFBMJDEHAPB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable FJANCENKJOO;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x86CA910", Offset = "0x86C8F10", VA = "0x1886CA910")]
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
					[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
					public LBJJGIKLJCE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x86D8BB0", Offset = "0x86D71B0", VA = "0x1886D8BB0")]
					internal void DFBMJDEHAPB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x86C87C0", Offset = "0x86C6DC0", VA = "0x1886C87C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public MMPEDBHEMDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x86DF540", Offset = "0x86DDB40", VA = "0x1886DF540")]
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
			[Cpp2IlInjected.Address(RVA = "0x86CE3A0", Offset = "0x86CC9A0", VA = "0x1886CE3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86CB390", Offset = "0x86C9990", VA = "0x1886CB390")]
		private static void DHEKKOOOLMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86CAA40", Offset = "0x86C9040", VA = "0x1886CAA40")]
		private static void AHHHPBIIAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86CB350", Offset = "0x86C9950", VA = "0x1886CB350")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86CEAB0", Offset = "0x86CD0B0", VA = "0x1886CEAB0")]
		private static void OCNJGMEEIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86CE3E0", Offset = "0x86CC9E0", VA = "0x1886CE3E0")]
		private static void GOMLMDOHJBI(EHHIACBBKDI.KFJBEHEFKKP OEHHKNIGGMI, PlayerLoopSystem OHECFPEJIHA, Type MNCPGGCDFNE, Type FDGGDDCMGML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86CE6D0", Offset = "0x86CCCD0", VA = "0x1886CE6D0")]
		private static void MLKHMHOEANA(PlayerLoopSystem OHECFPEJIHA, Type MNCPGGCDFNE, Type FDGGDDCMGML, BBLGDJJDOGB KEAIFFGFAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86CE5A0", Offset = "0x86CCBA0", VA = "0x1886CE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86C8DC0", Offset = "0x86C73C0", VA = "0x1886C8DC0")]
		public BNOJHILLAIJ(KFJBEHEFKKP BADKPDKBJKO, int EDGAKHBBNHK = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86C8DA0", Offset = "0x86C73A0", VA = "0x1886C8DA0")]
		public void JKDNJINFDPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x86C8C70", Offset = "0x86C7270", VA = "0x1886C8C70")]
		public void EBKPIDLMIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x86C8CC0", Offset = "0x86C72C0", VA = "0x1886C8CC0")]
		public void FBDIACIMIMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static KFJBEHEFKKP[] CPOIIICFGHE;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static BNOJHILLAIJ[] MKMOKABDMHD;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x86D0D50", Offset = "0x86CF350", VA = "0x1886D0D50")]
	public static BNOJHILLAIJ NHFGFOADMBA(KFJBEHEFKKP OEHHKNIGGMI, int EDGAKHBBNHK = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x86D0CE0", Offset = "0x86CF2E0", VA = "0x1886D0CE0")]
	public static BNOJHILLAIJ KKKMFCOPEON(KFJBEHEFKKP OEHHKNIGGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x86D0C40", Offset = "0x86CF240", VA = "0x1886D0C40")]
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
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
		public OAJBFNFEAKD(Action BDCLNIJAFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x113DFD0", Offset = "0x113C5D0", VA = "0x18113DFD0", Slot = "5")]
		public void MCMIEJOHGAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<LIICJENAEJA> PFBHJLDCJFO;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x86D73D0", Offset = "0x86D59D0", VA = "0x1886D73D0")]
	public static void ECEBIPAAPLC(Action BDCLNIJAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x86D7850", Offset = "0x86D5E50", VA = "0x1886D7850")]
	private static void NKELCGKCOKB(LIICJENAEJA HEJJIONAJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86D7470", Offset = "0x86D5A70", VA = "0x1886D7470")]
	private static void KDONHDGHLKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x86D7750", Offset = "0x86D5D50", VA = "0x1886D7750")]
	private static void LKIBHEFCNAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x86D7300", Offset = "0x86D5900", VA = "0x1886D7300")]
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
		[Cpp2IlInjected.Address(RVA = "0x86C8760", Offset = "0x86C6D60", VA = "0x1886C8760")]
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
		[Cpp2IlInjected.Address(RVA = "0x86C7E50", Offset = "0x86C6450", VA = "0x1886C7E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x86C86F0", Offset = "0x86C6CF0", VA = "0x1886C86F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86CECF0", Offset = "0x86CD2F0", VA = "0x1886CECF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x86CF000", Offset = "0x86CD600", VA = "0x1886CF000", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E0280", Offset = "0x86DE880", VA = "0x1886E0280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x86E0640", Offset = "0x86DEC40", VA = "0x1886E0640", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public LIFCPBLCJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x86D9BD0", Offset = "0x86D81D0", VA = "0x1886D9BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86CF060", Offset = "0x86CD660", VA = "0x1886CF060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86CFC00", Offset = "0x86CE200", VA = "0x1886CFC00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86DCA60", Offset = "0x86DB060", VA = "0x1886DCA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x86DD120", Offset = "0x86DB720", VA = "0x1886DD120", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D8E60", Offset = "0x86D7460", VA = "0x1886D8E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x86D9980", Offset = "0x86D7F80", VA = "0x1886D9980", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EGEFJOCMHIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x86D0BC0", Offset = "0x86CF1C0", VA = "0x1886D0BC0")]
		internal bool JCMAHIHNHKC(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x86D0960", Offset = "0x86CEF60", VA = "0x1886D0960")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public ELPBMCAJONM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x86D32F0", Offset = "0x86D18F0", VA = "0x1886D32F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x86D2A20", Offset = "0x86D1020", VA = "0x1886D2A20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x86D2A00", Offset = "0x86D1000", VA = "0x1886D2A00")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x86D32A0", Offset = "0x86D18A0", VA = "0x1886D32A0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E2BC0", Offset = "0x86E11C0", VA = "0x1886E2BC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x86E3390", Offset = "0x86E1990", VA = "0x1886E3390")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x86E2AD0", Offset = "0x86E10D0", VA = "0x1886E2AD0")]
	[FELFDMPPKKE(MGEKOJDDIFB.EnteredEditModeNextFrame, 0)]
	private static void KCCCACMJPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x86E2EA0", Offset = "0x86E14A0", VA = "0x1886E2EA0")]
	[AsyncStateMachine(typeof(BBAIKDAKDFF))]
	public static Task<Scene> MDAGPEBKPOI(string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ = LoadSceneMode.Single, bool BEGAHOKPHIA = false, [Optional] LDCGKGNFMMI<string>.CKHHEKIPJDF PFIFCCELJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x86E2860", Offset = "0x86E0E60", VA = "0x1886E2860")]
	[AsyncStateMachine(typeof(DBEGNEIHLCD))]
	private static Task HKMBEBFEMNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x86E2A00", Offset = "0x86E1000", VA = "0x1886E2A00")]
	[AsyncStateMachine(typeof(NNBAMFAKDOL))]
	private static Task JPEEIOHBEPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x86E3240", Offset = "0x86E1840", VA = "0x1886E3240")]
	[AsyncStateMachine(typeof(DDJPAFAJNGJ))]
	private static Task<Scene> OAONLEBLBIC(string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ, bool BEGAHOKPHIA, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x86E24B0", Offset = "0x86E0AB0", VA = "0x1886E24B0")]
	private static void DLABGBMAELK(SceneInstance ELJDCHFNJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x86E25B0", Offset = "0x86E0BB0", VA = "0x1886E25B0")]
	private static void FINDLAKCMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x86E30B0", Offset = "0x86E16B0", VA = "0x1886E30B0")]
	[AsyncStateMachine(typeof(MBHMGBJDBGL))]
	private static Task<Scene> MPKHGNKNMIH(string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x86E2910", Offset = "0x86E0F10", VA = "0x1886E2910")]
	private static bool JEOAFOOPBKE(string NHHGKEDIJJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x86E23A0", Offset = "0x86E09A0", VA = "0x1886E23A0")]
	[AsyncStateMachine(typeof(LBKFIONDKBE))]
	private static Task<Scene> BJJOOCPFFMI(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x86E34A0", Offset = "0x86E1AA0", VA = "0x1886E34A0")]
	public static KGAPFDAFEHM<Scene> PKDMJPFPGBP(string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x86E2CD0", Offset = "0x86E12D0", VA = "0x1886E2CD0")]
	[IteratorStateMachine(typeof(ELPBMCAJONM))]
	private static IEnumerator<NFNODNEANBN> LKCHIFLDECJ(string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ, AIKFLNNDLCF<Scene> FJFPKGKGKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x86E31E0", Offset = "0x86E17E0", VA = "0x1886E31E0")]
	public static void NOOOOGFKDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x86E2FF0", Offset = "0x86E15F0", VA = "0x1886E2FF0")]
	private static void MDDLNNBJMHG(string NHHGKEDIJJG, LoadSceneMode AADCMIGJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x86E2D70", Offset = "0x86E1370", VA = "0x1886E2D70")]
	public static bool LKKIBLGKEKF([Out] string JJEOCLBFJKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class IFHEPDGEEMH
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x86D7110", Offset = "0x86D5710", VA = "0x1886D7110")]
	public static IDisposable CFGBHCBIICN(this JBOJNOKAFDL INLEBAAACKH, float BHGDBFOAFAM, Action<float> BDLNDMICBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x86D71A0", Offset = "0x86D57A0", VA = "0x1886D71A0")]
	public static IDisposable CMEACFMFHBD(this JBOJNOKAFDL INLEBAAACKH, Action<float> BDLNDMICBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x86D7090", Offset = "0x86D5690", VA = "0x1886D7090")]
	public static IDisposable AELAAONDBPF(this JBOJNOKAFDL INLEBAAACKH, Action<float> BDLNDMICBAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class PKOIPMIKNPL
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A11E00", Offset = "0x3A10400", VA = "0x183A11E00")]
	[IPFMAEIIMGH]
	public static IDisposable JALCPPFBBBJ<T>(this T CAJPFDMILMO, Action BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3A11C50", Offset = "0x3A10250", VA = "0x183A11C50")]
	[IPFMAEIIMGH]
	public static IDisposable JALCPPFBBBJ<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3A11BB0", Offset = "0x3A101B0", VA = "0x183A11BB0")]
	[IPFMAEIIMGH]
	public static IDisposable IEKHBJGOAKB<T>(this T CAJPFDMILMO, Action BDLNDMICBAA, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3A11FB0", Offset = "0x3A105B0", VA = "0x183A11FB0")]
	[IPFMAEIIMGH]
	public static IDisposable JDNAJILJLLM<T>(this T CAJPFDMILMO, Action BDLNDMICBAA, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3A11FB0", Offset = "0x3A105B0", VA = "0x183A11FB0")]
	[IPFMAEIIMGH]
	public static IDisposable JDNAJILJLLM<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A119B0", Offset = "0x3A0FFB0", VA = "0x183A119B0")]
	[IPFMAEIIMGH]
	public static IDisposable FJHKGKPOOOM<T>(this T CAJPFDMILMO, Action BDLNDMICBAA, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A11840", Offset = "0x3A0FE40", VA = "0x183A11840")]
	[IPFMAEIIMGH]
	public static IDisposable CKDAHECHOJJ<T>(this T CAJPFDMILMO, Action BDLNDMICBAA, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A12040", Offset = "0x3A10640", VA = "0x183A12040")]
	[IPFMAEIIMGH]
	public static IDisposable KEAODKPBJEO<T>(this T CAJPFDMILMO, Action BDLNDMICBAA, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A12000", Offset = "0x3A10600", VA = "0x183A12000")]
	[IPFMAEIIMGH]
	public static IDisposable JPLCFDPAAMG<T>(this T CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x86E3830", Offset = "0x86E1E30", VA = "0x1886E3830")]
	[IPFMAEIIMGH]
	public static IDisposable JPLCFDPAAMG(this MonoBehaviour CAJPFDMILMO, FHBMACKKPGL INLEBAAACKH, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A11A00", Offset = "0x3A10000", VA = "0x183A11A00")]
	[IPFMAEIIMGH]
	public static IDisposable GONLKNNHHBI<T>(this T CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A117F0", Offset = "0x3A0FDF0", VA = "0x183A117F0")]
	[IPFMAEIIMGH]
	public static IDisposable BHAJIFFIHFJ<T>(this T CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A118F0", Offset = "0x3A0FEF0", VA = "0x183A118F0")]
	[IPFMAEIIMGH]
	public static IDisposable DGEGDCFKIOI<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A120F0", Offset = "0x3A106F0", VA = "0x183A120F0")]
	[IPFMAEIIMGH]
	public static IDisposable OEOFKLAKAKB<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A121B0", Offset = "0x3A107B0", VA = "0x183A121B0")]
	[IPFMAEIIMGH]
	public static IDisposable OMOLKILAPLN<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A11BF0", Offset = "0x3A101F0", VA = "0x183A11BF0")]
	[IPFMAEIIMGH]
	public static IDisposable IJABMGJCMOL<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A12150", Offset = "0x3A10750", VA = "0x183A12150")]
	[IPFMAEIIMGH]
	public static IDisposable OHPMEKEPBEM<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3A12090", Offset = "0x3A10690", VA = "0x183A12090")]
	[IPFMAEIIMGH]
	public static IDisposable MKBHLPENHIK<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3A12260", Offset = "0x3A10860", VA = "0x183A12260")]
	[IPFMAEIIMGH]
	public static IDisposable PLNHEOKNALG<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3A12210", Offset = "0x3A10810", VA = "0x183A12210")]
	[IPFMAEIIMGH]
	public static IDisposable PILOJBPNBPE<T>(this T CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A11890", Offset = "0x3A0FE90", VA = "0x183A11890")]
	[IPFMAEIIMGH]
	public static IDisposable DCHAONAODGP<T>(this T CAJPFDMILMO, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true) where T : MonoBehaviour, FHBMACKKPGL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3A11950", Offset = "0x3A0FF50", VA = "0x183A11950")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public MCFJHDHKMEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x86DD190", Offset = "0x86DB790", VA = "0x1886DD190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x86DD270", Offset = "0x86DB870", VA = "0x1886DD270", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public KCLICCNDKHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x86D81B0", Offset = "0x86D67B0", VA = "0x1886D81B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x86D82A0", Offset = "0x86D68A0", VA = "0x1886D82A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x86D3E00", Offset = "0x86D2400", VA = "0x1886D3E00")]
	public static OLILOOIADED JALCPPFBBBJ(Action BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x86D3F60", Offset = "0x86D2560", VA = "0x1886D3F60")]
	public static OLILOOIADED JALCPPFBBBJ(Behaviour INLEBAAACKH, Action BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x86D3E80", Offset = "0x86D2480", VA = "0x1886D3E80")]
	public static OLILOOIADED JALCPPFBBBJ(Behaviour INLEBAAACKH, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x86D3FF0", Offset = "0x86D25F0", VA = "0x1886D3FF0")]
	[IteratorStateMachine(typeof(MCFJHDHKMEK))]
	private static IEnumerator<NFNODNEANBN> OPDDPABBDPC(GFDMGEIMGAF GNDKFGDDNMM, Action BDLNDMICBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x86D4080", Offset = "0x86D2680", VA = "0x1886D4080")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public IHGPHMBCGMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x86D7220", Offset = "0x86D5820", VA = "0x1886D7220", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x86D72B0", Offset = "0x86D58B0", VA = "0x1886D72B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x86DF780", Offset = "0x86DDD80", VA = "0x1886DF780")]
	public MNFFEGFBFLL(GFDMGEIMGAF DEOJBEPOEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x86DF660", Offset = "0x86DDC60", VA = "0x1886DF660")]
	[IteratorStateMachine(typeof(IHGPHMBCGMM))]
	private IEnumerator<NFNODNEANBN> AIJPGKDNIGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x86DF6E0", Offset = "0x86DDCE0", VA = "0x1886DF6E0", Slot = "4")]
	public void OnCompleted(Action ADGINAHIKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	public void NINCFNJEAPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class PHIDHLNKLID
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x86E2290", Offset = "0x86E0890", VA = "0x1886E2290")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public EOMDMOPBOHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x86D3380", Offset = "0x86D1980", VA = "0x1886D3380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x86D3400", Offset = "0x86D1A00", VA = "0x1886D3400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x86DE9C0", Offset = "0x86DCFC0", VA = "0x1886DE9C0")]
	public static OLILOOIADED JALCPPFBBBJ(float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x86DEA90", Offset = "0x86DD090", VA = "0x1886DEA90")]
	public static OLILOOIADED JALCPPFBBBJ(MonoBehaviour CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x86DE710", Offset = "0x86DCD10", VA = "0x1886DE710")]
	public static OLILOOIADED AFBPDBPNIOG(MonoBehaviour CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x86DE8F0", Offset = "0x86DCEF0", VA = "0x1886DE8F0")]
	public static OLILOOIADED FJKJHGMEAPE(JBOJNOKAFDL INLEBAAACKH, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x86DEB60", Offset = "0x86DD160", VA = "0x1886DEB60")]
	private static IEnumerator<NFNODNEANBN> OPDDPABBDPC(FIDMLJAOMDI FLDAHOCEDKN, float BHGDBFOAFAM, GFDMGEIMGAF GNDKFGDDNMM, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x86DE890", Offset = "0x86DCE90", VA = "0x1886DE890")]
	private static IEnumerator<NFNODNEANBN> DBPCCONKDNN(FIDMLJAOMDI FLDAHOCEDKN, float BHGDBFOAFAM, GFDMGEIMGAF GNDKFGDDNMM, Action<float> BDLNDMICBAA, bool HGEKCMOPJEG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x86DE800", Offset = "0x86DCE00", VA = "0x1886DE800")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public CCOAGNPIPGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86C9C90", Offset = "0x86C8290", VA = "0x1886C9C90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x86C9D50", Offset = "0x86C8350", VA = "0x1886C9D50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x86DF850", Offset = "0x86DDE50", VA = "0x1886DF850")]
	[IteratorStateMachine(typeof(CCOAGNPIPGB))]
	private static IEnumerator<NFNODNEANBN> HDFJKBCLLIN(GFDMGEIMGAF DEOJBEPOEPP, Func<bool> BELPALHENKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x86DF8E0", Offset = "0x86DDEE0", VA = "0x1886DF8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public ECEDJEIOEGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x86D0820", Offset = "0x86CEE20", VA = "0x1886D0820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x86D0890", Offset = "0x86CEE90", VA = "0x1886D0890", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public KGDDKIAKIIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5003880", Offset = "0x5001E80", VA = "0x185003880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5003920", Offset = "0x5001F20", VA = "0x185003920", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public CAPCGMKLEAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x86C8E50", Offset = "0x86C7450", VA = "0x1886C8E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x86C8EE0", Offset = "0x86C74E0", VA = "0x1886C8EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x86D44D0", Offset = "0x86D2AD0", VA = "0x1886D44D0")]
	[IteratorStateMachine(typeof(ECEDJEIOEGD))]
	private static IEnumerator<NFNODNEANBN> AIJPGKDNIGC(float EPOJNFBFHFP, GFDMGEIMGAF GNDKFGDDNMM, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x387CE80", Offset = "0x387B480", VA = "0x18387CE80")]
	[IteratorStateMachine(typeof(KGDDKIAKIIE<>))]
	private static IEnumerator<NFNODNEANBN> AIJPGKDNIGC<T>(float EPOJNFBFHFP, GFDMGEIMGAF GNDKFGDDNMM, Action<T> NPLDOOBBCLG, T GIOLPIPFPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x86D4D60", Offset = "0x86D3360", VA = "0x1886D4D60")]
	[IteratorStateMachine(typeof(CAPCGMKLEAP))]
	private static IEnumerator<NFNODNEANBN> MCPMHELJMKH(float EPOJNFBFHFP, GFDMGEIMGAF GNDKFGDDNMM, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x86D49C0", Offset = "0x86D2FC0", VA = "0x1886D49C0")]
	public static IDisposable FJDPGDIIGBB(this MonoBehaviour CAJPFDMILMO, float EPOJNFBFHFP, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x86D4B90", Offset = "0x86D3190", VA = "0x1886D4B90")]
	public static OLILOOIADED HDGGMONGDDM(this MonoBehaviour CAJPFDMILMO, float EPOJNFBFHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x86D4AA0", Offset = "0x86D30A0", VA = "0x1886D4AA0")]
	public static OLILOOIADED FJDPGDIIGBB(this MonoBehaviour CAJPFDMILMO, float EPOJNFBFHFP, GFDMGEIMGAF GNDKFGDDNMM, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x86D4C20", Offset = "0x86D3220", VA = "0x1886D4C20")]
	public static OLILOOIADED HEHCKMMJBEC(this MonoBehaviour CAJPFDMILMO, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x387CF60", Offset = "0x387B560", VA = "0x18387CF60")]
	public static OLILOOIADED HEHCKMMJBEC<T>(this MonoBehaviour CAJPFDMILMO, Action<T> NPLDOOBBCLG, T GIOLPIPFPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x86D4880", Offset = "0x86D2E80", VA = "0x1886D4880")]
	public static OLILOOIADED ECANCCJGMHF(this MonoBehaviour CAJPFDMILMO, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x86D4570", Offset = "0x86D2B70", VA = "0x1886D4570")]
	public static OLILOOIADED BBCJIOLLCJK(this MonoBehaviour CAJPFDMILMO, Action NPLDOOBBCLG, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x86D4920", Offset = "0x86D2F20", VA = "0x1886D4920")]
	public static OLILOOIADED ELOOFECPPPJ(this MonoBehaviour CAJPFDMILMO, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x86D47E0", Offset = "0x86D2DE0", VA = "0x1886D47E0")]
	public static OLILOOIADED DNJNGAGPKBE(this MonoBehaviour CAJPFDMILMO, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x86D4E00", Offset = "0x86D3400", VA = "0x1886D4E00")]
	public static OLILOOIADED OBGPINLMHNN(MonoBehaviour CAJPFDMILMO, GFDMGEIMGAF DEOJBEPOEPP, Action NPLDOOBBCLG, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x387CFB0", Offset = "0x387B5B0", VA = "0x18387CFB0")]
	public static OLILOOIADED OBGPINLMHNN<T>(MonoBehaviour CAJPFDMILMO, GFDMGEIMGAF DEOJBEPOEPP, Action<T> NPLDOOBBCLG, T GIOLPIPFPPJ, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x86D46B0", Offset = "0x86D2CB0", VA = "0x1886D46B0")]
	public static OLILOOIADED CMFFIBLAAGO(this MonoBehaviour CAJPFDMILMO, float EOOKPLCLOKM, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x86D4CC0", Offset = "0x86D32C0", VA = "0x1886D4CC0")]
	public static OLILOOIADED JNMFJIJJMFO(this MonoBehaviour CAJPFDMILMO, float EOOKPLCLOKM, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x86D4610", Offset = "0x86D2C10", VA = "0x1886D4610")]
	public static OLILOOIADED BFEFADFLEEG(this MonoBehaviour CAJPFDMILMO, float EOOKPLCLOKM, Action NPLDOOBBCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x86D4740", Offset = "0x86D2D40", VA = "0x1886D4740")]
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
		[Cpp2IlInjected.Address(RVA = "0x86DEF30", Offset = "0x86DD530", VA = "0x1886DEF30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EAGGDHPHDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x86DF400", Offset = "0x86DDA00", VA = "0x1886DF400", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x86DF060", Offset = "0x86DD660", VA = "0x1886DF060", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x86DF4A0", Offset = "0x86DDAA0", VA = "0x1886DF4A0")]
	public MMOEGODPPKG([Optional] Action OIBPNINGGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x86DF2D0", Offset = "0x86DD8D0", VA = "0x1886DF2D0")]
	public void IIGLPCDPOEE(DNNHALOGKMB FNCPIBGPFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x86DF100", Offset = "0x86DD700", VA = "0x1886DF100")]
	private void GANCMHBHNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x86DEF20", Offset = "0x86DD520", VA = "0x1886DEF20", Slot = "7")]
	public bool ANPLHDIONFM(bool ECOALLGHBMI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x86DEC20", Offset = "0x86DD220", VA = "0x1886DEC20", Slot = "8")]
	public bool ANPLHDIONFM(Action BDCLNIJAFBF, bool ECOALLGHBMI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x86DF250", Offset = "0x86DD850", VA = "0x1886DF250", Slot = "9")]
	public IEnumerator<DNNHALOGKMB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x86DF250", Offset = "0x86DD850", VA = "0x1886DF250", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CCEIFBOAMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x86C9C60", Offset = "0x86C8260", VA = "0x1886C9C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CCAOHDPEODL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x86C9C60", Offset = "0x86C8260", VA = "0x1886C9C60")]
		internal void CFNMNAMLNGP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float NKKMDMMHIJN;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x86D06E0", Offset = "0x86CECE0", VA = "0x1886D06E0")]
	public PHANICMLGIK(Behaviour INLEBAAACKH, float NKKMDMMHIJN, [Optional] Action OIBPNINGGFC, [Optional] GJPCEPMOONC PCPLHHLNPGI, [Optional] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x86E2070", Offset = "0x86E0670", VA = "0x1886E2070", Slot = "9")]
	protected override bool GEEOJBFOFBH(Action BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x86E2180", Offset = "0x86E0780", VA = "0x1886E2180", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public FALCDGIJDEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x86D3450", Offset = "0x86D1A50", VA = "0x1886D3450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x86D3520", Offset = "0x86D1B20", VA = "0x1886D3520", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x1A297F0", Offset = "0x1A27DF0", VA = "0x181A297F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action EAGGDHPHDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x86CA2A0", Offset = "0x86C88A0", VA = "0x1886CA2A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x86CA130", Offset = "0x86C8730", VA = "0x1886CA130", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x86CA360", Offset = "0x86C8960", VA = "0x1886CA360")]
	protected CDMPHNKCCOJ(Behaviour INLEBAAACKH, [Optional] Action OIBPNINGGFC, [Optional] GJPCEPMOONC PCPLHHLNPGI, [Optional] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x86C9E00", Offset = "0x86C8400", VA = "0x1886C9E00", Slot = "7")]
	public bool ANPLHDIONFM(bool ECOALLGHBMI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x86C9DA0", Offset = "0x86C83A0", VA = "0x1886C9DA0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x86CA340", Offset = "0x86C8940", VA = "0x1886CA340")]
	protected void PDANBBNCPLG(Action BDCLNIJAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x86C9EE0", Offset = "0x86C84E0", VA = "0x1886C9EE0")]
	protected HPIGCMLNLFB EKCDKLECKGP(float JHNMLGDIFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x86C9E60", Offset = "0x86C8460", VA = "0x1886C9E60")]
	private void EFBNNMLGHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x86CA1D0", Offset = "0x86C87D0", VA = "0x1886CA1D0")]
	[IteratorStateMachine(typeof(FALCDGIJDEK))]
	private IEnumerator<NFNODNEANBN> GLPJGPHMIHI(float JHNMLGDIFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x86CA260", Offset = "0x86C8860", VA = "0x1886CA260")]
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
	[Cpp2IlInjected.Address(RVA = "0x86D6960", Offset = "0x86D4F60", VA = "0x1886D6960")]
	public IBGJBDLPPNL(Behaviour INLEBAAACKH, float BHNGCEKAGGA, int MDNKCDGICAJ, [Optional] Action OIBPNINGGFC, float EKKJKLIDDIK = 0f, [Optional] GJPCEPMOONC PCPLHHLNPGI, [Optional] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "9")]
	protected override bool GEEOJBFOFBH(Action BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x86D6760", Offset = "0x86D4D60", VA = "0x1886D6760", Slot = "10")]
	protected override bool LMIEOELFMOB(Action BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x86D66E0", Offset = "0x86D4CE0", VA = "0x1886D66E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x86D06E0", Offset = "0x86CECE0", VA = "0x1886D06E0")]
	public DPILABBBIPM(Behaviour INLEBAAACKH, float NKKMDMMHIJN, [Optional] Action OIBPNINGGFC, [Optional] GJPCEPMOONC PCPLHHLNPGI, [Optional] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "9")]
	protected override bool GEEOJBFOFBH(Action BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x86D06A0", Offset = "0x86CECA0", VA = "0x1886D06A0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public HJOMNEJJCGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x86CA850", Offset = "0x86C8E50", VA = "0x1886CA850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x86D5340", Offset = "0x86D3940", VA = "0x1886D5340", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x86D8830", Offset = "0x86D6E30", VA = "0x1886D8830")]
	public KIBFIABOGNI(JBOJNOKAFDL INLEBAAACKH, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x86D8590", Offset = "0x86D6B90", VA = "0x1886D8590")]
	private void IFGGOHKPKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x86D8700", Offset = "0x86D6D00", VA = "0x1886D8700")]
	private void PMGLPNEGPEB(string JHEMEKBLBHP, Action HHIPLAGKMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x86D8510", Offset = "0x86D6B10", VA = "0x1886D8510")]
	[IteratorStateMachine(typeof(HJOMNEJJCGJ))]
	private IEnumerator<NFNODNEANBN> HCKMHEBMILO(Action HHIPLAGKMDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x86D84B0", Offset = "0x86D6AB0", VA = "0x1886D84B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x86D8330", Offset = "0x86D6930", VA = "0x1886D8330")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public CPGBPDGPCOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x86CA850", Offset = "0x86C8E50", VA = "0x1886CA850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x86CA8C0", Offset = "0x86C8EC0", VA = "0x1886CA8C0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x86D61A0", Offset = "0x86D47A0", VA = "0x1886D61A0")]
	public HMOLJNKMOCL(MonoBehaviour CAJPFDMILMO, Action BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x86D6510", Offset = "0x86D4B10", VA = "0x1886D6510")]
	public HMOLJNKMOCL(MonoBehaviour CAJPFDMILMO, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x86D6330", Offset = "0x86D4930", VA = "0x1886D6330")]
	public HMOLJNKMOCL(MonoBehaviour CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4B9FF30", Offset = "0x4B9E530", VA = "0x184B9FF30")]
	private HMOLJNKMOCL(GJPCEPMOONC PCPLHHLNPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x86D5F70", Offset = "0x86D4570", VA = "0x1886D5F70")]
	internal static HMOLJNKMOCL POOGHIMKFMH(MonoBehaviour CAJPFDMILMO, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, [Optional] GJPCEPMOONC PCPLHHLNPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x86D5B00", Offset = "0x86D4100", VA = "0x1886D5B00")]
	private void JALCPPFBBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x86D5CC0", Offset = "0x86D42C0", VA = "0x1886D5CC0")]
	private void NOAAFMLIAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x86D5990", Offset = "0x86D3F90", VA = "0x1886D5990")]
	private void IFGGOHKPKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x86D56F0", Offset = "0x86D3CF0", VA = "0x1886D56F0")]
	private void EDAGOBEFOLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x86D5E40", Offset = "0x86D4440", VA = "0x1886D5E40")]
	private void PMGLPNEGPEB(string JHEMEKBLBHP, Action HHIPLAGKMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x86D5910", Offset = "0x86D3F10", VA = "0x1886D5910")]
	[IteratorStateMachine(typeof(CPGBPDGPCOF))]
	private IEnumerator<NFNODNEANBN> HCKMHEBMILO(Action HHIPLAGKMDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x86D5690", Offset = "0x86D3C90", VA = "0x1886D5690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x86D5C30", Offset = "0x86D4230", VA = "0x1886D5C30")]
	[CompilerGenerated]
	private void KBLCBHBGLJJ(string GGOAKKKDCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x86D5570", Offset = "0x86D3B70", VA = "0x1886D5570")]
	[CompilerGenerated]
	private void BBGEDDJOOAP(string GGOAKKKDCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x86D5600", Offset = "0x86D3C00", VA = "0x1886D5600")]
	[CompilerGenerated]
	private void CCHOLFKEBEJ(string GGOAKKKDCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x86D5880", Offset = "0x86D3E80", VA = "0x1886D5880")]
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
		[Cpp2IlInjected.Address(RVA = "0x86CFCF0", Offset = "0x86CE2F0", VA = "0x1886CFCF0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float KNJNKHNADLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x86CFCE0", Offset = "0x86CE2E0", VA = "0x1886CFCE0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double OJMJBBKEHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x86CFD00", Offset = "0x86CE300", VA = "0x1886CFD00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x86CFC70", Offset = "0x86CE270", VA = "0x1886CFC70")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void JPEDEHNINOC(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x86D0220", Offset = "0x86CE820", VA = "0x1886D0220")]
	public static NFNODNEANBN IPLLHHFHOOC(IEnumerator<NFNODNEANBN> GNLGPPNCEJJ, KAFMFFJBHFN BKPHILMDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x86D0160", Offset = "0x86CE760", VA = "0x1886D0160")]
	public NFNODNEANBN IPLLHHFHOOC(KAFMFFJBHFN[] DHJEOPJCODM, IEnumerator<NFNODNEANBN>[] JLPCPIPHMEI, NFNODNEANBN[] CPAABEDEKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x86CFFF0", Offset = "0x86CE5F0", VA = "0x1886CFFF0")]
	public void NPMAMJJIGME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x86D0020", Offset = "0x86CE620", VA = "0x1886D0020")]
	public void BMHEDJKPMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x86D0380", Offset = "0x86CE980", VA = "0x1886D0380")]
	public void NJICABBIMAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x86CFFF0", Offset = "0x86CE5F0", VA = "0x1886CFFF0")]
	public void AKBKNLLCFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NLLPFPCCCPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x86DFAB0", Offset = "0x86DE0B0", VA = "0x1886DFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EFJAJJJICKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x86D08E0", Offset = "0x86CEEE0", VA = "0x1886D08E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EFLKABKAFAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x86D0920", Offset = "0x86CEF20", VA = "0x1886D0920")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KELGOGFCAEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x86D82F0", Offset = "0x86D68F0", VA = "0x1886D82F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAC5D0", Offset = "0xAAABD0", VA = "0x180AAC5D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x86DA5E0", Offset = "0x86D8BE0", VA = "0x1886DA5E0")]
	private static int CHMHFCLKFCF(GFDMGEIMGAF DEOJBEPOEPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x86DC1A0", Offset = "0x86DA7A0", VA = "0x1886DC1A0")]
	public LOCOOBAJJGD(GFDMGEIMGAF DEOJBEPOEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x86DAF80", Offset = "0x86D9580", VA = "0x1886DAF80")]
	private void GKAHKJMEDDN(int AJEKANBGFPA, int DPJEJNADMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x86DA610", Offset = "0x86D8C10", VA = "0x1886DA610")]
	public void CNLHPLNKHLN(JBOJNOKAFDL INLEBAAACKH, NFNODNEANBN PKHEJKMIMNN, IEnumerator<NFNODNEANBN> GNLGPPNCEJJ, KAFMFFJBHFN BKPHILMDNNH, [Optional] DIALIABFGFG JBPNOMDJAMN, GOMLIAEFFPN PODPFFDGFCN = GOMLIAEFFPN.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x86DBF60", Offset = "0x86DA560", VA = "0x1886DBF60")]
	public void PAPPCCJNIHC(IEnumerable<HCLMAOBOJOA> EMEJJHDKLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x86DB310", Offset = "0x86D9910", VA = "0x1886DB310")]
	private HCLMAOBOJOA KKMCJGBGHPJ(int FMAEFMFEIND)
	{
		return default(HCLMAOBOJOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x86D9E10", Offset = "0x86D8410", VA = "0x1886D9E10")]
	private void AEFDIDCGBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x391B2C0", Offset = "0x39198C0", VA = "0x18391B2C0")]
	private static void BJMCEJLEOAH<T>(int FMAEFMFEIND, T[] OGGPCCJAFEB, int CFNMLMNHCMF, [Optional] T PHELKGBOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x391B310", Offset = "0x3919910", VA = "0x18391B310")]
	private static void BJMCEJLEOAH<T>(int FMAEFMFEIND, NativeArray<T> OGGPCCJAFEB, int CFNMLMNHCMF, [Optional] T PHELKGBOELE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x86DB7E0", Offset = "0x86D9DE0", VA = "0x1886DB7E0")]
	private void KLEJFFDOGIC(IEnumerable<HCLMAOBOJOA> EMEJJHDKLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x86DA790", Offset = "0x86D8D90", VA = "0x1886DA790")]
	private void EMBOOECAAOP(HCLMAOBOJOA IOMKLCPCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x86DBB80", Offset = "0x86DA180", VA = "0x1886DBB80")]
	private OPNEOPAIPOG MBPLJJDEGFM(int JFPHNEEFGLE)
	{
		return default(OPNEOPAIPOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x86DA3E0", Offset = "0x86D89E0", VA = "0x1886DA3E0")]
	public void ANJOKGEPFDI(float DBEFOCGFFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x86DB160", Offset = "0x86D9760", VA = "0x1886DB160")]
	private void GKHHFDOIJJB(Action FDJHCIBLFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x86DBDE0", Offset = "0x86DA3E0", VA = "0x1886DBDE0")]
	private void MONLOAEMJAC(Action FDJHCIBLFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x86DA860", Offset = "0x86D8E60", VA = "0x1886DA860")]
	public void GBJHJABLBHA(float DBEFOCGFFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x86DBE60", Offset = "0x86DA460", VA = "0x1886DBE60")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x86DA2B0", Offset = "0x86D88B0", VA = "0x1886DA2B0")]
	public void AKBKNLLCFBD(DIALIABFGFG CJMAPIDFJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x86DA180", Offset = "0x86D8780", VA = "0x1886DA180")]
	public void AFDGONJKHDP(DIALIABFGFG CJMAPIDFJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x86DB1E0", Offset = "0x86D97E0", VA = "0x1886DB1E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public NOJIGDKLIDC(Action AAMIKNLELJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D789B0", Offset = "0x7D76FB0", VA = "0x187D789B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PJGJKGMOGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x561DF40", Offset = "0x561C540", VA = "0x18561DF40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB6E90", Offset = "0xAB5490", VA = "0x180AB6E90", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A390A0", Offset = "0x6A376A0", VA = "0x186A390A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A38F30", Offset = "0x6A37530", VA = "0x186A38F30")]
	private static bool DJKPNGENBIE(T FDJHCIBLFFB, T CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A39560", Offset = "0x6A37B60", VA = "0x186A39560")]
	public DELPJMBIHJM(T FFPHGFOFACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A392F0", Offset = "0x6A378F0", VA = "0x186A392F0", Slot = "6")]
	public IDisposable OCKNEDAJIFC(UnityEngine.Object INLEBAAACKH, Action<T> AFONHCFPODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A38BD0", Offset = "0x6A371D0", VA = "0x186A38BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEBEA90", Offset = "0xEBD090", VA = "0x180EBEA90")]
			public ENDMOFGEMAJ(int HJPLNJNIFLL, HCCBADJAPEC GNDKFGDDNMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x86D3350", Offset = "0x86D1950", VA = "0x1886D3350", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public ECEONPEFNNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
			[DebuggerHidden]
			public BMAOMJDMBOC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x86C88F0", Offset = "0x86C6EF0", VA = "0x1886C88F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x86C8C20", Offset = "0x86C7220", VA = "0x1886C8C20", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D52A0", Offset = "0x86D38A0", VA = "0x1886D52A0")]
		public HCCBADJAPEC(GFDMGEIMGAF DEOJBEPOEPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x86D5080", Offset = "0x86D3680", VA = "0x1886D5080")]
		public IDisposable NBKPOICJOBJ(FCJPLLBIOCL PILHKLCKECK, GJPCEPMOONC PCPLHHLNPGI, FIDMLJAOMDI DCCJGOAMNIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x86D4EF0", Offset = "0x86D34F0", VA = "0x1886D4EF0")]
		private void IDFMEFBADJJ(int HJPLNJNIFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x86D5210", Offset = "0x86D3810", VA = "0x1886D5210")]
		[IteratorStateMachine(typeof(BMAOMJDMBOC))]
		private IEnumerator<NFNODNEANBN> OPDDPABBDPC(FIDMLJAOMDI DCCJGOAMNIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x86D4EA0", Offset = "0x86D34A0", VA = "0x1886D4EA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D3920", Offset = "0x86D1F20", VA = "0x1886D3920")]
		public FCJPLLBIOCL(FHBMACKKPGL INLEBAAACKH, Action BDLNDMICBAA, bool FECBKDFCJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x86D3AA0", Offset = "0x86D20A0", VA = "0x1886D3AA0")]
		public FCJPLLBIOCL(FHBMACKKPGL INLEBAAACKH, Action<float> BDLNDMICBAA, bool FECBKDFCJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x86D3740", Offset = "0x86D1D40", VA = "0x1886D3740")]
		public FCJPLLBIOCL(FHBMACKKPGL INLEBAAACKH, float BHGDBFOAFAM, Action<float> BDLNDMICBAA, FIDMLJAOMDI DCCJGOAMNIL, MFOPJGAPDCO HIEEGJOADLN, bool HGEKCMOPJEG, bool FECBKDFCJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x86D3570", Offset = "0x86D1B70", VA = "0x1886D3570")]
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
	[Cpp2IlInjected.Address(RVA = "0x86E0F00", Offset = "0x86DF500", VA = "0x1886E0F00")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void IFDFJOEJDEI(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x86E1270", Offset = "0x86DF870", VA = "0x1886E1270")]
	[UnityEngine.Scripting.Preserve]
	internal NPNFJCOJDHJ([DJIFKCCBBND(null)] GJPCEPMOONC PCPLHHLNPGI, [DJIFKCCBBND(null)] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x86E0D10", Offset = "0x86DF310", VA = "0x1886E0D10", Slot = "4")]
	public IDisposable IEKHBJGOAKB(FHBMACKKPGL INLEBAAACKH, Action COLEJLDPDCO, GFDMGEIMGAF DEOJBEPOEPP, bool FECBKDFCJKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x86E0B20", Offset = "0x86DF120", VA = "0x1886E0B20", Slot = "5")]
	public IDisposable IEKHBJGOAKB(FHBMACKKPGL INLEBAAACKH, Action<float> COLEJLDPDCO, GFDMGEIMGAF DEOJBEPOEPP, bool FECBKDFCJKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x86E07A0", Offset = "0x86DEDA0", VA = "0x1886E07A0", Slot = "7")]
	public IDisposable BHAJIFFIHFJ(FHBMACKKPGL INLEBAAACKH, float BHGDBFOAFAM, Action<float> COLEJLDPDCO, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x86E0A20", Offset = "0x86DF020", VA = "0x1886E0A20", Slot = "8")]
	public IDisposable CLOCAAOLFJI(FHBMACKKPGL INLEBAAACKH, float BHGDBFOAFAM, Action<float> COLEJLDPDCO, GFDMGEIMGAF DEOJBEPOEPP, bool HGEKCMOPJEG = true, bool FECBKDFCJKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x86E08A0", Offset = "0x86DEEA0", VA = "0x1886E08A0", Slot = "6")]
	public IDisposable BHAJIFFIHFJ(float BHGDBFOAFAM, Action<float> COLEJLDPDCO, bool HGEKCMOPJEG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x86E10B0", Offset = "0x86DF6B0", VA = "0x1886E10B0", Slot = "9")]
	public void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x86E0F70", Offset = "0x86DF570", VA = "0x1886E0F70")]
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
	[Cpp2IlInjected.Address(RVA = "0x86C9750", Offset = "0x86C7D50", VA = "0x1886C9750")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void JPEDEHNINOC(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x86C9BA0", Offset = "0x86C81A0", VA = "0x1886C9BA0")]
	[UnityEngine.Scripting.Preserve]
	public CAPDDJBOHGK([DJIFKCCBBND(null)] MJMOCHGMCPG EHJINILELBM, [DJIFKCCBBND(null)] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x86C9280", Offset = "0x86C7880", VA = "0x1886C9280", Slot = "19")]
	public override OLILOOIADED FLGDMILKHPN(JBOJNOKAFDL INLEBAAACKH, IEnumerator<NFNODNEANBN> GPEBENOKHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x86C97C0", Offset = "0x86C7DC0", VA = "0x1886C97C0", Slot = "20")]
	public override void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x86C93B0", Offset = "0x86C79B0", VA = "0x1886C93B0", Slot = "22")]
	public override void GNOBEHDLJOO(GFDMGEIMGAF DEOJBEPOEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x86C95E0", Offset = "0x86C7BE0", VA = "0x1886C95E0", Slot = "21")]
	protected override void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x86C9A50", Offset = "0x86C8050", VA = "0x1886C9A50")]
	private LOCOOBAJJGD MEGLBEBEIJC(GFDMGEIMGAF MLCOGCMJLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x86C8F30", Offset = "0x86C7530", VA = "0x1886C8F30", Slot = "23")]
	internal override OLHELBELJFF AKAAGIMENIP(IEnumerator<NFNODNEANBN> GPEBENOKHFI, Behaviour INLEBAAACKH, KAFMFFJBHFN BKPHILMDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x86C91C0", Offset = "0x86C77C0", VA = "0x1886C91C0", Slot = "24")]
	internal override EHKFPACOPFD EFGGLFGLFDI(GFDMGEIMGAF GNDKFGDDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x86C9A80", Offset = "0x86C8080", VA = "0x1886C9A80")]
	private void OCJNPEOHNNM(LOCOOBAJJGD ODFKNKFFGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x86C9160", Offset = "0x86C7760", VA = "0x1886C9160", Slot = "25")]
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
	[Cpp2IlInjected.Address(RVA = "0x86D6C10", Offset = "0x86D5210", VA = "0x1886D6C10")]
	public static ICNFIOGAGFC FLLMCNLHKNL(int ENKAJOBEFHI, float DBEFOCGFFJA, NativeArray<GOMLIAEFFPN> GBGEPEALFIO, NativeArray<float> LCLHFONDAGJ, NativeArray<int> NPJKJMFJKLI, NativeArray<int> NFNEEOGGBDM, NativeArray<int> LFENBNNDKIM, NativeArray<int> CEEDOGGAOOD, NativeArray<int> ECDEDHJPPFJ)
	{
		return default(ICNFIOGAGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x86D6B30", Offset = "0x86D5130", VA = "0x1886D6B30", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x86D6E10", Offset = "0x86D5410", VA = "0x1886D6E10")]
	private bool KGHPMLLJLHH(int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x86D6C70", Offset = "0x86D5270", VA = "0x1886D6C70")]
	private void GFFELNAINBE(NativeArray<int> OGAMHOMMEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x86D6CA0", Offset = "0x86D52A0", VA = "0x1886D6CA0")]
	private int HADIKFKPDCB(int LOHCKAAJAJO, int FAJGDEPPNFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x86D6D40", Offset = "0x86D5340", VA = "0x1886D6D40")]
	private void IJGFJEDLJEI(NativeArray<int> OGAMHOMMEAC, int GMFIGOEDGCM, int NFFBJCCKPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x86D6E50", Offset = "0x86D5450", VA = "0x1886D6E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x86DD940", Offset = "0x86DBF40", VA = "0x1886DD940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public GFDMGEIMGAF MOIAPBNLBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GFDMGEIMGAF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public FIDMLJAOMDI DPJPGOLCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public NFNODNEANBN PGLDJNGGOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x86DDC90", Offset = "0x86DC290", VA = "0x1886DDC90")]
	public static OLILOOIADED HJHONNMKAAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x86DE220", Offset = "0x86DC820", VA = "0x1886DE220")]
	[UnityEngine.Scripting.Preserve]
	protected MFLOAHPLBFM([DJIFKCCBBND(null)] MJMOCHGMCPG EHJINILELBM, [DJIFKCCBBND(null)] FIDMLJAOMDI FLDAHOCEDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x86DDBD0", Offset = "0x86DC1D0", VA = "0x1886DDBD0", Slot = "6")]
	public OLILOOIADED GDMALPFODEM(IEnumerator<NFNODNEANBN> GPEBENOKHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x86DD9D0", Offset = "0x86DBFD0", VA = "0x1886DD9D0", Slot = "7")]
	public OLILOOIADED GDMALPFODEM(Behaviour INLEBAAACKH, IEnumerator<NFNODNEANBN> GPEBENOKHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract OLILOOIADED FLGDMILKHPN(JBOJNOKAFDL INLEBAAACKH, IEnumerator<NFNODNEANBN> GPEBENOKHFI);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x86DDF70", Offset = "0x86DC570", VA = "0x1886DDF70", Slot = "20")]
	public virtual void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x86DD2C0", Offset = "0x86DB8C0", VA = "0x1886DD2C0", Slot = "9")]
	public void AKLOKBMEPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x86DDD20", Offset = "0x86DC320", VA = "0x1886DDD20", Slot = "21")]
	protected virtual void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x86DE170", Offset = "0x86DC770", VA = "0x1886DE170")]
	private void OMLCMBHOPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x86DDF50", Offset = "0x86DC550", VA = "0x1886DDF50")]
	private void KFBOHBEKNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x86DDF10", Offset = "0x86DC510", VA = "0x1886DDF10")]
	private void JDNAJILJLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x86DD920", Offset = "0x86DBF20", VA = "0x1886DD920")]
	private void FJHKGKPOOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x86DD9B0", Offset = "0x86DBFB0", VA = "0x1886DD9B0")]
	private void GACKGMPFEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x86DDC70", Offset = "0x86DC270", VA = "0x1886DDC70")]
	private void HBDHJFKOJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x86DDF30", Offset = "0x86DC530", VA = "0x1886DDF30")]
	private void JJLCLDJEFKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x86DDBE0", Offset = "0x86DC1E0", VA = "0x1886DDBE0", Slot = "22")]
	public virtual void GNOBEHDLJOO(GFDMGEIMGAF DEOJBEPOEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x86DDD40", Offset = "0x86DC340", VA = "0x1886DDD40")]
	private void ILIGGPNJHGL(EHKFPACOPFD ODFKNKFFGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x266D3D0", Offset = "0x266B9D0", VA = "0x18266D3D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x86DD500", Offset = "0x86DBB00", VA = "0x1886DD500", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x86DE110", Offset = "0x86DC710", VA = "0x1886DE110", Slot = "15")]
	public NFNODNEANBN NIFNJJMKMGK(GFDMGEIMGAF GNDKFGDDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x86DE190", Offset = "0x86DC790", VA = "0x1886DE190", Slot = "16")]
	public NFNODNEANBN ONJFDJNFEMF(float EPOJNFBFHFP, GFDMGEIMGAF GNDKFGDDNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x86DD8C0", Offset = "0x86DBEC0", VA = "0x1886DD8C0", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NFNODNEANBN DJCJBGMNEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool BMHKHIBDACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x86E1BA0", Offset = "0x86E01A0", VA = "0x1886E1BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool HBCJGPDCNPL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xC177F0", Offset = "0xC15DF0", VA = "0x180C177F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xC4C130", Offset = "0xC4A730", VA = "0x180C4C130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x86E1C20", Offset = "0x86E0220", VA = "0x1886E1C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float EILLPENJBDN
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1076300", Offset = "0x1074900", VA = "0x181076300")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7005CD0", Offset = "0x70042D0", VA = "0x187005CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x86E1EB0", Offset = "0x86E04B0", VA = "0x1886E1EB0")]
	public OLHELBELJFF(IEnumerator<NFNODNEANBN> GNLGPPNCEJJ, JPMAGBMLEDD INLEBAAACKH, KAFMFFJBHFN BKPHILMDNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x86E1880", Offset = "0x86DFE80", VA = "0x1886E1880")]
	public NFNODNEANBN IPLLHHFHOOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x86E1810", Offset = "0x86DFE10", VA = "0x1886E1810")]
	public bool INFGKNOCLHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x86E17C0", Offset = "0x86DFDC0", VA = "0x1886E17C0")]
	public void AKBKNLLCFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x86E1DD0", Offset = "0x86E03D0", VA = "0x1886E1DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xC93AC0", Offset = "0xC920C0", VA = "0x180C93AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD6CE60", Offset = "0xD6B460", VA = "0x180D6CE60", Slot = "23")]
		get
		{
			return default(GFDMGEIMGAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GFDMGEIMGAF OKGEEIKJFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xF46C80", Offset = "0xF45280", VA = "0x180F46C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float FCLIHMDHNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xBF0E20", Offset = "0xBEF420", VA = "0x180BF0E20", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BDOOEIEHABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x86D7CE0", Offset = "0x86D62E0", VA = "0x1886D7CE0", Slot = "24")]
	private bool HKEKHDAOGBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x86D7CD0", Offset = "0x86D62D0", VA = "0x1886D7CD0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x86D7D00", Offset = "0x86D6300", VA = "0x1886D7D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x86D2580", Offset = "0x86D0B80", VA = "0x1886D2580")]
	public EHKFPACOPFD(GFDMGEIMGAF GNDKFGDDNMM, BGNCEBKJOKG EBONLCHEFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x86D2350", Offset = "0x86D0950", VA = "0x1886D2350")]
	public void PKAKJENIKAE(OLHELBELJFF GNLGPPNCEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x86D1830", Offset = "0x86CFE30", VA = "0x1886D1830")]
	public void HHFLOBJHEBE(IList<OLHELBELJFF> JLPCPIPHMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x86D2050", Offset = "0x86D0650", VA = "0x1886D2050")]
	public void PHCICAOKOHH(IList<OLHELBELJFF> JLPCPIPHMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x86D1CA0", Offset = "0x86D02A0", VA = "0x1886D1CA0")]
	private void JNEGJGEFEGI(OLHELBELJFF GNLGPPNCEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x86D16A0", Offset = "0x86CFCA0", VA = "0x1886D16A0")]
	private void FJMFLOHEJOH(IList<OLHELBELJFF> JLPCPIPHMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x86D1D90", Offset = "0x86D0390", VA = "0x1886D1D90")]
	private OPNEOPAIPOG KIDECJPNCMJ(OLHELBELJFF GNLGPPNCEJJ)
	{
		return default(OPNEOPAIPOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x86D1B30", Offset = "0x86D0130", VA = "0x1886D1B30")]
	public void IEKHBJGOAKB(float DBEFOCGFFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x86D1030", Offset = "0x86CF630", VA = "0x1886D1030")]
	public void AKLOKBMEPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x86D1340", Offset = "0x86CF940", VA = "0x1886D1340")]
	private void EDKDFGHOGGE(List<OLHELBELJFF> JLPCPIPHMEI, Stack<int> NKJAFBJLGCL, bool LNNHGFIEPFA, float CAPGLLMJJCL = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x86D1220", Offset = "0x86CF820", VA = "0x1886D1220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x86D1F10", Offset = "0x86D0510", VA = "0x1886D1F10")]
	private void MBDINFPBBMH(List<OLHELBELJFF> JLPCPIPHMEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class DOPPCPJDJLJ : BGNCEBKJOKG
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void GHADDOKHEFP(string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
	public void NDLIKACFBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x86DF9C0", Offset = "0x86DDFC0", VA = "0x1886DF9C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DJLLMFIFBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x86DFA40", Offset = "0x86DE040", VA = "0x1886DFA40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool KBKGBFICNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x86DFA90", Offset = "0x86DE090", VA = "0x1886DFA90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
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

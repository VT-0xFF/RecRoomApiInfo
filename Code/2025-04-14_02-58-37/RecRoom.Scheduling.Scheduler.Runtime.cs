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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8376340", Offset = "0x8374D40", VA = "0x188376340", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8380750", Offset = "0x837F150", VA = "0x188380750", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
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
		private delegate List<PlayerLoopSystem> FLIMCOFPOFK(List<PlayerLoopSystem> AADFPNKNCAL, int FPNDECMKEAI);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct JLKHCLEKDLJ
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct DKJIFIHGIKL
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static COOFKGJALFM NBNDEPKPGHH;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x836D720", Offset = "0x836C120", VA = "0x18836D720")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct NGIFOAJFPCJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static COOFKGJALFM IMANLMNNBJJ;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x8379AC0", Offset = "0x83784C0", VA = "0x188379AC0")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct IKPDELLNPAG
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static COOFKGJALFM JPKDJBPIFEF;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x83734E0", Offset = "0x8371EE0", VA = "0x1883734E0")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct NDBKHAPAHLE
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static COOFKGJALFM LAIILGDKENP;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static COOFKGJALFM OHAADAPDPPA;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static COOFKGJALFM FKKILMNNKCH;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static COOFKGJALFM KKKGLFOKPNC;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x8379180", Offset = "0x8377B80", VA = "0x188379180")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct CJFKCCJKNHG
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static COOFKGJALFM LNKICEALKNG;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x8365900", Offset = "0x8364300", VA = "0x188365900")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct HILKGDIHEEC
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static COOFKGJALFM LAIILGDKENP;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static COOFKGJALFM OHAADAPDPPA;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static COOFKGJALFM FKKILMNNKCH;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static COOFKGJALFM KKKGLFOKPNC;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x8371AD0", Offset = "0x83704D0", VA = "0x188371AD0")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct PHHCHLCOFLC
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static COOFKGJALFM LFMCCFLLECM;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x837E980", Offset = "0x837D380", VA = "0x18837E980")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct EDKAFILIHEH
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static COOFKGJALFM AAIIEIJDHJM;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x836E410", Offset = "0x836CE10", VA = "0x18836E410")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct NCMOPPNLCBI
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static COOFKGJALFM HFEOPCPFNKK;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x8378650", Offset = "0x8377050", VA = "0x188378650")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct JNNKMIEHEJO
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static COOFKGJALFM GOENLILALKE;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x8374850", Offset = "0x8373250", VA = "0x188374850")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct PELHDEDNNEA
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static COOFKGJALFM EDKFODBONBI;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x837E5C0", Offset = "0x837CFC0", VA = "0x18837E5C0")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct CGAJCBCLBCI
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static COOFKGJALFM MICOJFNNANI;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x8365560", Offset = "0x8363F60", VA = "0x188365560")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct PKFLBPOFOGN
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static COOFKGJALFM LFCKEOMGCOF;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x837EB60", Offset = "0x837D560", VA = "0x18837EB60")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct PGAMDMJJOLJ
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static COOFKGJALFM BMMMOPJGBKN;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x837E7A0", Offset = "0x837D1A0", VA = "0x18837E7A0")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct DAOJNFJLHIN
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static COOFKGJALFM CIKBJDFCMKE;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x836BA80", Offset = "0x836A480", VA = "0x18836BA80")]
				public static PlayerLoopSystem JJPPKPFBFDH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum LNNDAFLABHF : byte
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
			public struct CIONGIJEPJN
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class HGNJCEDNGIM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public LNNDAFLABHF updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
					public HGNJCEDNGIM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x8371A50", Offset = "0x8370450", VA = "0x188371A50")]
					internal void CNHGOFDLBIL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static JEBDGPAIPLL<LNNDAFLABHF> FLCBNGHFFEJ;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x8365740", Offset = "0x8364140", VA = "0x188365740")]
				public static PlayerLoopSystem JJPPKPFBFDH(LNNDAFLABHF KBGOBEBFNNA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct POJMPLCAPKN
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class JLKKAIJMMAF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public EGIIHPPCNKI.CPEEFIDFDMO key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
					public JLKKAIJMMAF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x83744A0", Offset = "0x8372EA0", VA = "0x1883744A0")]
					internal void CKOHFKFABOM()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable MLNPFDEBOIO;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x837F510", Offset = "0x837DF10", VA = "0x18837F510")]
				public static PlayerLoopSystem OJCBPFNMFEL(EGIIHPPCNKI.CPEEFIDFDMO NJBPFCDJFGD)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct MJNOLOEBHEM
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class NFPDCFPPBCE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public EGIIHPPCNKI.CPEEFIDFDMO key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
					public NFPDCFPPBCE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x83797D0", Offset = "0x83781D0", VA = "0x1883797D0")]
					internal void CKOHFKFABOM()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x8377860", Offset = "0x8376260", VA = "0x188377860")]
				public static PlayerLoopSystem OJCBPFNMFEL(EGIIHPPCNKI.CPEEFIDFDMO NJBPFCDJFGD)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class DBNMPIHBACC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public DBNMPIHBACC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x836BC60", Offset = "0x836A660", VA = "0x18836BC60")]
			internal List<PlayerLoopSystem> ODPMPLIMHIN(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool GGNALMABPJF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool OHGOOCHFDJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x83677D0", Offset = "0x83661D0", VA = "0x1883677D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8368A70", Offset = "0x8367470", VA = "0x188368A70")]
		private static void LELIEHJBDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8367810", Offset = "0x8366210", VA = "0x188367810")]
		private static void AONCGIOOCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8368120", Offset = "0x8366B20", VA = "0x188368120")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8368320", Offset = "0x8366D20", VA = "0x188368320")]
		private static void IJHDKENPGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8368160", Offset = "0x8366B60", VA = "0x188368160")]
		private static void DPJDLOOHIAO(EGIIHPPCNKI.CPEEFIDFDMO NJBPFCDJFGD, PlayerLoopSystem HJCDFNKFEKP, Type OCOBPGBBMPA, Type PEMJLLEBFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8368560", Offset = "0x8366F60", VA = "0x188368560")]
		private static void KHPBLOAEMCB(PlayerLoopSystem HJCDFNKFEKP, Type OCOBPGBBMPA, Type PEMJLLEBFNN, FLIMCOFPOFK LCPGHBGDBCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8368940", Offset = "0x8367340", VA = "0x188368940")]
		private static void KNGJLJOKAOF(PlayerLoopSystem HJCDFNKFEKP, Type OCOBPGBBMPA, Type PEMJLLEBFNN, PlayerLoopSystem? DBHCNGAGKPM, PlayerLoopSystem? MLKFFIDEDPB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class EGIIHPPCNKI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum CPEEFIDFDMO
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
	public class NJCGLIOAIOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly CPEEFIDFDMO OGJBMHCPPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly LKKGGMCABKE EADIMCEFIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long BCNHOIOCFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long KBAOIFMMMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long OPNONNKJBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int CNJHDAOPKEB;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x837C7D0", Offset = "0x837B1D0", VA = "0x18837C7D0")]
		public NJCGLIOAIOK(CPEEFIDFDMO CNHIDPBOBPK, int NJDIGLGOFDE = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x837C6D0", Offset = "0x837B0D0", VA = "0x18837C6D0")]
		public void DEPGEDJLDKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x837C680", Offset = "0x837B080", VA = "0x18837C680")]
		public void CLMHMPJOBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x837C6F0", Offset = "0x837B0F0", VA = "0x18837C6F0")]
		public void IODMOCFOOKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static CPEEFIDFDMO[] GBOKHBPCPFN;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static NJCGLIOAIOK[] NBNFLGHCMNG;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x836E5F0", Offset = "0x836CFF0", VA = "0x18836E5F0")]
	public static NJCGLIOAIOK FFPKLPGOHKF(CPEEFIDFDMO NJBPFCDJFGD, int NJDIGLGOFDE = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x836E740", Offset = "0x836D140", VA = "0x18836E740")]
	public static NJCGLIOAIOK IAIKCIHEDMM(CPEEFIDFDMO NJBPFCDJFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x836E7B0", Offset = "0x836D1B0", VA = "0x18836E7B0")]
	public static void PJCNINFJIHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DPFJDJEBJMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface DJFBDNPIIKE
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool CIDGFBHJAKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CALODJBLNBL();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class LLAOCHBMCIJ : DJFBDNPIIKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action HNDDBOOOBBE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CIDGFBHJAKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
		public LLAOCHBMCIJ(Action HNDDBOOOBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x106EB20", Offset = "0x106D520", VA = "0x18106EB20", Slot = "5")]
		public void CALODJBLNBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<DJFBDNPIIKE> BIGJEKDMEIO;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x836DEC0", Offset = "0x836C8C0", VA = "0x18836DEC0")]
	public static void MLKBMBDLFOL(Action HNDDBOOOBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x836D900", Offset = "0x836C300", VA = "0x18836D900")]
	private static void JMKBIADEMDO(DJFBDNPIIKE JIADFAFCEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x836DB10", Offset = "0x836C510", VA = "0x18836DB10")]
	private static void LCJCEOBIODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x836DF60", Offset = "0x836C960", VA = "0x18836DF60")]
	private static void OJDOLIILCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x836DDF0", Offset = "0x836C7F0", VA = "0x18836DDF0")]
	private static void MKNMBKPJEOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class MEECBGMMBJB
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct NCCCECNMNKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> OMHHGKOJIIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string PABGPJFICHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode NEFCIDJBPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool DLGJGHOGGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x83785F0", Offset = "0x8376FF0", VA = "0x1883785F0")]
		public NCCCECNMNKB(TaskCompletionSource<Scene> OPKHIMLOHCF, string PABGPJFICHJ, LoadSceneMode NEFCIDJBPGF, bool DLGJGHOGGKG, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct LIOPEGMCINM : IAsyncStateMachine
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
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private NCPOPMIDADO<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x8375A30", Offset = "0x8374430", VA = "0x188375A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x83762D0", Offset = "0x8374CD0", VA = "0x1883762D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct CBCGCNDPAEG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x83651F0", Offset = "0x8363BF0", VA = "0x1883651F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8365500", Offset = "0x8363F00", VA = "0x188365500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct IPHGLBGIMHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private NCCCECNMNKB <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83736C0", Offset = "0x83720C0", VA = "0x1883736C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8373A80", Offset = "0x8372480", VA = "0x188373A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class GCMCCPFHGFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CLNIIAIDBKJ<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public GCMCCPFHGFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x836F920", Offset = "0x836E320", VA = "0x18836F920")]
		internal void IBFKEJCEILJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct BFEEDDFDOJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

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
		private GCMCCPFHGFC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8364560", Offset = "0x8362F60", VA = "0x188364560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8365100", Offset = "0x8363B00", VA = "0x188365100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct HKNPMBJHGGE : IAsyncStateMachine
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
		private MBDDIOMLGLG <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8371E80", Offset = "0x8370880", VA = "0x188371E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8372540", Offset = "0x8370F40", VA = "0x188372540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct MJPGODDLDNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8377990", Offset = "0x8376390", VA = "0x188377990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x83784B0", Offset = "0x8376EB0", VA = "0x1883784B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EAJMGABOPHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CLNIIAIDBKJ<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EAJMGABOPHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x836E350", Offset = "0x836CD50", VA = "0x18836E350")]
		internal bool FFGNOOFLGBP(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x836E0F0", Offset = "0x836CAF0", VA = "0x18836E0F0")]
		internal void EKHGPNBIPHH(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NCOKMGKONNK : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CLNIIAIDBKJ<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private EAJMGABOPHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private MBDDIOMLGLG <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public NCOKMGKONNK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8379120", Offset = "0x8377B20", VA = "0x188379120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8378850", Offset = "0x8377250", VA = "0x188378850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8378830", Offset = "0x8377230", VA = "0x188378830")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83790D0", Offset = "0x8377AD0", VA = "0x1883790D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> GEONEGBDMMN;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static JCIOFMEGJFK LJOCFCOHLEL;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation ONFIHEMMKEC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static JCIOFMEGJFK HFHFPBCHNPF;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string IHBEECHMNFN;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string LPHDPKLLOFP;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority OOJLNCCGDMK;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task CDDGEKNMAMA;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> DGIMIJMLBGD;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<NCCCECNMNKB> IMBAIFNJGPL;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task HOCMEKHCEOA;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> NKDPIIPBIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8376DA0", Offset = "0x83757A0", VA = "0x188376DA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83764A0", Offset = "0x8374EA0", VA = "0x1883764A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8377230", Offset = "0x8375C30", VA = "0x188377230")]
	[OOFAMMFPHGN(HHCEAPAGKJO.EnteredEditModeNextFrame, 0)]
	private static void MJLADMHGCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8377030", Offset = "0x8375A30", VA = "0x188377030")]
	[AsyncStateMachine(typeof(LIOPEGMCINM))]
	public static Task<Scene> MBBJCNIJJME(string PABGPJFICHJ, LoadSceneMode NEFCIDJBPGF = LoadSceneMode.Single, bool DLGJGHOGGKG = false, [Optional] NCPOPMIDADO<string>.CFILPBLEJMI MPFGPGDGGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8377180", Offset = "0x8375B80", VA = "0x188377180")]
	[AsyncStateMachine(typeof(CBCGCNDPAEG))]
	private static Task MIPAEMLJAFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x83763D0", Offset = "0x8374DD0", VA = "0x1883763D0")]
	[AsyncStateMachine(typeof(IPHGLBGIMHD))]
	private static Task AGAANHOBFKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x83765B0", Offset = "0x8374FB0", VA = "0x1883765B0")]
	[AsyncStateMachine(typeof(BFEEDDFDOJP))]
	private static Task<Scene> BLBKGNCPFDN(string PABGPJFICHJ, LoadSceneMode NEFCIDJBPGF, bool DLGJGHOGGKG, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8376CA0", Offset = "0x83756A0", VA = "0x188376CA0")]
	private static void FNEGGEADKNO(SceneInstance FPJBBOHNMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x83767A0", Offset = "0x83751A0", VA = "0x1883767A0")]
	private static void FCLCMKAMPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8377430", Offset = "0x8375E30", VA = "0x188377430")]
	[AsyncStateMachine(typeof(HKNPMBJHGGE))]
	private static Task<Scene> OEPBGBDGDBA(string PABGPJFICHJ, LoadSceneMode NEFCIDJBPGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8377560", Offset = "0x8375F60", VA = "0x188377560")]
	private static bool OLJLDMPLEMG(string PABGPJFICHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8377320", Offset = "0x8375D20", VA = "0x188377320")]
	[AsyncStateMachine(typeof(MJPGODDLDNH))]
	private static Task<Scene> MNAAGADBDMP(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8376EB0", Offset = "0x83758B0", VA = "0x188376EB0")]
	public static ECHAPNAJEJF<Scene> ILMJLMFMDON(string PABGPJFICHJ, LoadSceneMode NEFCIDJBPGF = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8376700", Offset = "0x8375100", VA = "0x188376700")]
	[IteratorStateMachine(typeof(NCOKMGKONNK))]
	private static IEnumerator<HKMFJDMPEMN> BOCFIGONCMI(string PABGPJFICHJ, LoadSceneMode NEFCIDJBPGF, CLNIIAIDBKJ<Scene> CCOOBCLCLNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8376B10", Offset = "0x8375510", VA = "0x188376B10")]
	public static void FIPLJEGDGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8376A50", Offset = "0x8375450", VA = "0x188376A50")]
	private static void FEEKOFBLLPC(string PABGPJFICHJ, LoadSceneMode NEFCIDJBPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8376B70", Offset = "0x8375570", VA = "0x188376B70")]
	public static bool FMEMAFGEIKE([Out] string BMGBJEBELII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HEEICNOKCPO
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8371940", Offset = "0x8370340", VA = "0x188371940")]
	public static IDisposable IJHDHOPHAPL(this PPNLLFDFCCO OJFCDDMGKNP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x83719D0", Offset = "0x83703D0", VA = "0x1883719D0")]
	public static IDisposable LELPINOCAOM(this PPNLLFDFCCO OJFCDDMGKNP, Action<float> BDALOJMNHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x83718C0", Offset = "0x83702C0", VA = "0x1883718C0")]
	public static IDisposable HMLGCFFNHPF(this PPNLLFDFCCO OJFCDDMGKNP, Action<float> BDALOJMNHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class EKAJLIHFKCF
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x34C2490", Offset = "0x34C0E90", VA = "0x1834C2490")]
	[PCEAOLEFKHH]
	public static IDisposable MPCGJLOFMNN<T>(this T GCAIDLEJDBP, Action BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x34C2640", Offset = "0x34C1040", VA = "0x1834C2640")]
	[PCEAOLEFKHH]
	public static IDisposable MPCGJLOFMNN<T>(this T GCAIDLEJDBP, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x34C2340", Offset = "0x34C0D40", VA = "0x1834C2340")]
	[PCEAOLEFKHH]
	public static IDisposable IPDLKHCHONO<T>(this T GCAIDLEJDBP, Action BDALOJMNHKK, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x34C2190", Offset = "0x34C0B90", VA = "0x1834C2190")]
	[PCEAOLEFKHH]
	public static IDisposable DLDMAPJAPDA<T>(this T GCAIDLEJDBP, Action BDALOJMNHKK, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x34C2190", Offset = "0x34C0B90", VA = "0x1834C2190")]
	[PCEAOLEFKHH]
	public static IDisposable DLDMAPJAPDA<T>(this T GCAIDLEJDBP, Action<float> BDALOJMNHKK, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x34C23E0", Offset = "0x34C0DE0", VA = "0x1834C23E0")]
	[PCEAOLEFKHH]
	public static IDisposable LEPKCJFFKPO<T>(this T GCAIDLEJDBP, Action BDALOJMNHKK, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x34C22A0", Offset = "0x34C0CA0", VA = "0x1834C22A0")]
	[PCEAOLEFKHH]
	public static IDisposable GIEEPEKBDPM<T>(this T GCAIDLEJDBP, Action BDALOJMNHKK, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x34C22F0", Offset = "0x34C0CF0", VA = "0x1834C22F0")]
	[PCEAOLEFKHH]
	public static IDisposable GNJEGCKIIML<T>(this T GCAIDLEJDBP, Action BDALOJMNHKK, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x34C2150", Offset = "0x34C0B50", VA = "0x1834C2150")]
	[PCEAOLEFKHH]
	public static IDisposable CDBGHIEMIKE<T>(this T GCAIDLEJDBP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x836E9E0", Offset = "0x836D3E0", VA = "0x18836E9E0")]
	[PCEAOLEFKHH]
	public static IDisposable CDBGHIEMIKE(this MonoBehaviour GCAIDLEJDBP, BEPIEELIFLK OJFCDDMGKNP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x34C28B0", Offset = "0x34C12B0", VA = "0x1834C28B0")]
	[PCEAOLEFKHH]
	public static IDisposable NEMMKPLDEPA<T>(this T GCAIDLEJDBP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x34C2100", Offset = "0x34C0B00", VA = "0x1834C2100")]
	[PCEAOLEFKHH]
	public static IDisposable CBOELOKEHBF<T>(this T GCAIDLEJDBP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x34C27F0", Offset = "0x34C11F0", VA = "0x1834C27F0")]
	[PCEAOLEFKHH]
	public static IDisposable NBIGOKAMLDA<T>(this T GCAIDLEJDBP, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x34C2AA0", Offset = "0x34C14A0", VA = "0x1834C2AA0")]
	[PCEAOLEFKHH]
	public static IDisposable PJOHCLIAMII<T>(this T GCAIDLEJDBP, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x34C2B60", Offset = "0x34C1560", VA = "0x1834C2B60")]
	[PCEAOLEFKHH]
	public static IDisposable POIJKICCKCG<T>(this T GCAIDLEJDBP, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x34C2850", Offset = "0x34C1250", VA = "0x1834C2850")]
	[PCEAOLEFKHH]
	public static IDisposable NDPHHEPEJEC<T>(this T GCAIDLEJDBP, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x34C2B00", Offset = "0x34C1500", VA = "0x1834C2B00")]
	[PCEAOLEFKHH]
	public static IDisposable PNHJHKGNOOF<T>(this T GCAIDLEJDBP, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x34C2240", Offset = "0x34C0C40", VA = "0x1834C2240")]
	[PCEAOLEFKHH]
	public static IDisposable GCPGHAJICMJ<T>(this T GCAIDLEJDBP, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x34C2430", Offset = "0x34C0E30", VA = "0x1834C2430")]
	[PCEAOLEFKHH]
	public static IDisposable MHGJNBLMLNJ<T>(this T GCAIDLEJDBP, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x34C2A50", Offset = "0x34C1450", VA = "0x1834C2A50")]
	[PCEAOLEFKHH]
	public static IDisposable PJNKFFEPDKD<T>(this T GCAIDLEJDBP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x34C21E0", Offset = "0x34C0BE0", VA = "0x1834C21E0")]
	[PCEAOLEFKHH]
	public static IDisposable FOGCAKALEBC<T>(this T GCAIDLEJDBP, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x34C2380", Offset = "0x34C0D80", VA = "0x1834C2380")]
	[PCEAOLEFKHH]
	public static IDisposable LAMPPKFIHJO<T>(this T GCAIDLEJDBP, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true) where T : MonoBehaviour, BEPIEELIFLK
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class LAFIBBCCBNB
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class ABPCCINFDFK : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public PDAPCALENKF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private LAIKNCNKMDG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public ABPCCINFDFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8363A40", Offset = "0x8362440", VA = "0x188363A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8363B20", Offset = "0x8362520", VA = "0x188363B20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class BEBLHEAJDGM : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public PDAPCALENKF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private LAIKNCNKMDG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public BEBLHEAJDGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8364420", Offset = "0x8362E20", VA = "0x188364420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8364510", Offset = "0x8362F10", VA = "0x188364510", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x83752F0", Offset = "0x8373CF0", VA = "0x1883752F0")]
	public static NBLJJLKPDOF MPCGJLOFMNN(Action BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8375370", Offset = "0x8373D70", VA = "0x188375370")]
	public static NBLJJLKPDOF MPCGJLOFMNN(Behaviour OJFCDDMGKNP, Action BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8375210", Offset = "0x8373C10", VA = "0x188375210")]
	public static NBLJJLKPDOF MPCGJLOFMNN(Behaviour OJFCDDMGKNP, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8375490", Offset = "0x8373E90", VA = "0x188375490")]
	[IteratorStateMachine(typeof(ABPCCINFDFK))]
	private static IEnumerator<HKMFJDMPEMN> OOMOACIJJPO(PDAPCALENKF PLJAPGLDFIC, Action BDALOJMNHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8375400", Offset = "0x8373E00", VA = "0x188375400")]
	[IteratorStateMachine(typeof(BEBLHEAJDGM))]
	private static IEnumerator<HKMFJDMPEMN> OOMOACIJJPO(PDAPCALENKF PLJAPGLDFIC, Action<float> BDALOJMNHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class JEEHNJKGCIP : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class HIOLDKLJJBN : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public JEEHNJKGCIP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public HIOLDKLJJBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8371DA0", Offset = "0x83707A0", VA = "0x188371DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8371E30", Offset = "0x8370830", VA = "0x188371E30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly PDAPCALENKF LCBFLFDPPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action GKGLDAKGBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool DMJKABLLNGO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PENNPAPDBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9AED90", Offset = "0x9AD790", VA = "0x1809AED90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8373D20", Offset = "0x8372720", VA = "0x188373D20")]
	public JEEHNJKGCIP(PDAPCALENKF LCBFLFDPPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8373C00", Offset = "0x8372600", VA = "0x188373C00")]
	[IteratorStateMachine(typeof(HIOLDKLJJBN))]
	private IEnumerator<HKMFJDMPEMN> NCDBOPMGMDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8373C80", Offset = "0x8372680", VA = "0x188373C80", Slot = "4")]
	public void OnCompleted(Action FBBDJNOOBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	public void DJNBDOLAHJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class IEBANHJJFDM
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8372660", Offset = "0x8371060", VA = "0x188372660")]
	public static JEEHNJKGCIP FJPAAICMOHL(this PDAPCALENKF LCBFLFDPPON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class LDBMOKJALKD
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class MLJHDHFECLH : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public NHKKECPCEBE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public MLJHDHFECLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8378520", Offset = "0x8376F20", VA = "0x188378520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x83785A0", Offset = "0x8376FA0", VA = "0x1883785A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x83757B0", Offset = "0x83741B0", VA = "0x1883757B0")]
	public static NBLJJLKPDOF MPCGJLOFMNN(float BKPJMMHCGEE, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, bool HKGIIIPAGKG = true, [Optional] GOHHNGJKPGH OBCJAOHMKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x83756E0", Offset = "0x83740E0", VA = "0x1883756E0")]
	public static NBLJJLKPDOF MPCGJLOFMNN(MonoBehaviour GCAIDLEJDBP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, bool HKGIIIPAGKG = true, [Optional] GOHHNGJKPGH OBCJAOHMKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8375940", Offset = "0x8374340", VA = "0x188375940")]
	public static NBLJJLKPDOF PGPMGGKBNND(MonoBehaviour GCAIDLEJDBP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, bool HKGIIIPAGKG = true, [Optional] GOHHNGJKPGH OBCJAOHMKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8375580", Offset = "0x8373F80", VA = "0x188375580")]
	public static NBLJJLKPDOF KLBDKIPNGDJ(PPNLLFDFCCO OJFCDDMGKNP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, bool HKGIIIPAGKG = true, [Optional] GOHHNGJKPGH OBCJAOHMKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8375880", Offset = "0x8374280", VA = "0x188375880")]
	private static IEnumerator<HKMFJDMPEMN> OOMOACIJJPO(AIGGEIIJPCB DLPBPIIEOLF, float BKPJMMHCGEE, PDAPCALENKF PLJAPGLDFIC, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8375520", Offset = "0x8373F20", VA = "0x188375520")]
	private static IEnumerator<HKMFJDMPEMN> ADLOIKGPMMH(AIGGEIIJPCB DLPBPIIEOLF, float BKPJMMHCGEE, PDAPCALENKF PLJAPGLDFIC, Action<float> BDALOJMNHKK, bool HKGIIIPAGKG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8375650", Offset = "0x8374050", VA = "0x188375650")]
	[IteratorStateMachine(typeof(MLJHDHFECLH))]
	private static IEnumerator<HKMFJDMPEMN> MOJGCOJFLBA(NHKKECPCEBE MIECCFEONCB, float BKPJMMHCGEE, PDAPCALENKF PLJAPGLDFIC, Action<float> BDALOJMNHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class JOGPKKLGBCL
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class KEGDEJMHDGF : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public PDAPCALENKF queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public KEGDEJMHDGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8375100", Offset = "0x8373B00", VA = "0x188375100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x83751C0", Offset = "0x8373BC0", VA = "0x1883751C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8374B10", Offset = "0x8373510", VA = "0x188374B10")]
	[IteratorStateMachine(typeof(KEGDEJMHDGF))]
	private static IEnumerator<HKMFJDMPEMN> LDJKJDNFPFM(PDAPCALENKF LCBFLFDPPON, Func<bool> GFLFPOCDIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8374A30", Offset = "0x8373430", VA = "0x188374A30")]
	public static NBLJJLKPDOF FFGNALGFDLE(this MonoBehaviour GCAIDLEJDBP, Func<bool> GFLFPOCDIEJ, PDAPCALENKF LCBFLFDPPON = PDAPCALENKF.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class PEEDOAEOAAG
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class NKFMBIGPOCC : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public PDAPCALENKF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public NKFMBIGPOCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x837C860", Offset = "0x837B260", VA = "0x18837C860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x837C8D0", Offset = "0x837B2D0", VA = "0x18837C8D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class DFPDOEOHIME<T> : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public PDAPCALENKF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public DFPDOEOHIME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3F0DBA0", Offset = "0x3F0C5A0", VA = "0x183F0DBA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3F0DC40", Offset = "0x3F0C640", VA = "0x183F0DC40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class GMLOPFOMGNA : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public PDAPCALENKF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private HKMFJDMPEMN <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public GMLOPFOMGNA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8371720", Offset = "0x8370120", VA = "0x188371720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83717B0", Offset = "0x83701B0", VA = "0x1883717B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x837E480", Offset = "0x837CE80", VA = "0x18837E480")]
	[IteratorStateMachine(typeof(NKFMBIGPOCC))]
	private static IEnumerator<HKMFJDMPEMN> NCDBOPMGMDL(float KFGHOINKLDG, PDAPCALENKF PLJAPGLDFIC, Action KEEHKILKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x383A170", Offset = "0x3838B70", VA = "0x18383A170")]
	[IteratorStateMachine(typeof(DFPDOEOHIME<>))]
	private static IEnumerator<HKMFJDMPEMN> NCDBOPMGMDL<T>(float KFGHOINKLDG, PDAPCALENKF PLJAPGLDFIC, Action<T> KEEHKILKFBL, T JDKFBOCIIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x837DD30", Offset = "0x837C730", VA = "0x18837DD30")]
	[IteratorStateMachine(typeof(GMLOPFOMGNA))]
	private static IEnumerator<HKMFJDMPEMN> COKANFJHAEH(float KFGHOINKLDG, PDAPCALENKF PLJAPGLDFIC, Action KEEHKILKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x837E130", Offset = "0x837CB30", VA = "0x18837E130")]
	public static IDisposable HJGDOCONBCH(this MonoBehaviour GCAIDLEJDBP, float KFGHOINKLDG, Action KEEHKILKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x837DF10", Offset = "0x837C910", VA = "0x18837DF10")]
	public static NBLJJLKPDOF GEHJAOHHKEI(this MonoBehaviour GCAIDLEJDBP, float KFGHOINKLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x837E040", Offset = "0x837CA40", VA = "0x18837E040")]
	public static NBLJJLKPDOF HJGDOCONBCH(this MonoBehaviour GCAIDLEJDBP, float KFGHOINKLDG, PDAPCALENKF PLJAPGLDFIC, Action KEEHKILKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x837E2A0", Offset = "0x837CCA0", VA = "0x18837E2A0")]
	public static NBLJJLKPDOF IJAONFKLAON(this MonoBehaviour GCAIDLEJDBP, Action KEEHKILKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3839FE0", Offset = "0x38389E0", VA = "0x183839FE0")]
	public static NBLJJLKPDOF IJAONFKLAON<T>(this MonoBehaviour GCAIDLEJDBP, Action<T> KEEHKILKFBL, T JDKFBOCIIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x837E3E0", Offset = "0x837CDE0", VA = "0x18837E3E0")]
	public static NBLJJLKPDOF LJLDMFFCGDL(this MonoBehaviour GCAIDLEJDBP, Action KEEHKILKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x837DE70", Offset = "0x837C870", VA = "0x18837DE70")]
	public static NBLJJLKPDOF DONIJOHNGLO(this MonoBehaviour GCAIDLEJDBP, Action KEEHKILKFBL, [Optional] GOHHNGJKPGH OBCJAOHMKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x837DDD0", Offset = "0x837C7D0", VA = "0x18837DDD0")]
	public static NBLJJLKPDOF DGONKNMMIBB(this MonoBehaviour GCAIDLEJDBP, Action KEEHKILKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x837DC90", Offset = "0x837C690", VA = "0x18837DC90")]
	public static NBLJJLKPDOF BBHLOLHONIL(this MonoBehaviour GCAIDLEJDBP, Action KEEHKILKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x837E340", Offset = "0x837CD40", VA = "0x18837E340")]
	public static NBLJJLKPDOF JIEHBKCHEDF(MonoBehaviour GCAIDLEJDBP, PDAPCALENKF LCBFLFDPPON, Action KEEHKILKFBL, [Optional] GOHHNGJKPGH OBCJAOHMKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x383A030", Offset = "0x3838A30", VA = "0x18383A030")]
	public static NBLJJLKPDOF JIEHBKCHEDF<T>(MonoBehaviour GCAIDLEJDBP, PDAPCALENKF LCBFLFDPPON, Action<T> KEEHKILKFBL, T JDKFBOCIIAB, [Optional] GOHHNGJKPGH OBCJAOHMKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x837E210", Offset = "0x837CC10", VA = "0x18837E210")]
	public static NBLJJLKPDOF IFPOADGOEAE(this MonoBehaviour GCAIDLEJDBP, float KPCEDMDNIPB, Action KEEHKILKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x837DFA0", Offset = "0x837C9A0", VA = "0x18837DFA0")]
	public static NBLJJLKPDOF GHNAJJHDGLD(this MonoBehaviour GCAIDLEJDBP, float KPCEDMDNIPB, Action KEEHKILKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x837DBF0", Offset = "0x837C5F0", VA = "0x18837DBF0")]
	public static NBLJJLKPDOF BBAJONPCHKJ(this MonoBehaviour GCAIDLEJDBP, float KPCEDMDNIPB, Action KEEHKILKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x837E520", Offset = "0x837CF20", VA = "0x18837E520")]
	public static NBLJJLKPDOF PBDLADPGDFA(this MonoBehaviour GCAIDLEJDBP, float KPCEDMDNIPB, Action KEEHKILKFBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class IGDJHMODOPJ : ABDKHFBDLNJ, IEnumerable<ABDKHFBDLNJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<ABDKHFBDLNJ> NJHIFMONOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool DNNJCPDHDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action MOBHKAEBNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool FAJOLKPBBCG;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JFPKMPPKFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8372D80", Offset = "0x8371780", VA = "0x188372D80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DDGONHAHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8372EB0", Offset = "0x83718B0", VA = "0x188372EB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8372F50", Offset = "0x8371950", VA = "0x188372F50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8372FF0", Offset = "0x83719F0", VA = "0x188372FF0")]
	public IGDJHMODOPJ([Optional] Action MOBHKAEBNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8372940", Offset = "0x8371340", VA = "0x188372940")]
	public void HEHCILJMFIP(ABDKHFBDLNJ HNDBPMGKDHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8372770", Offset = "0x8371170", VA = "0x188372770")]
	private void EKNFCEGCEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8372D70", Offset = "0x8371770", VA = "0x188372D70", Slot = "7")]
	public bool HHAAOBMIMJL(bool JDEIJIAFEMH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8372A70", Offset = "0x8371470", VA = "0x188372A70", Slot = "8")]
	public bool HHAAOBMIMJL(Action HNDDBOOOBBE, bool JDEIJIAFEMH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x83728C0", Offset = "0x83712C0", VA = "0x1883728C0", Slot = "9")]
	public IEnumerator<ABDKHFBDLNJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x83728C0", Offset = "0x83712C0", VA = "0x1883728C0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NLEPKGHFPKN : CMNGKBICHOI
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MFDHOGGJPKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public NLEPKGHFPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MFDHOGGJPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8365AE0", Offset = "0x83644E0", VA = "0x188365AE0")]
		internal void PLNOBBOJMIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CLIMJMDBBNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public NLEPKGHFPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CLIMJMDBBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8365AE0", Offset = "0x83644E0", VA = "0x188365AE0")]
		internal void PGIAJKIENCN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float CJKNPFOAPCJ;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x8367690", Offset = "0x8366090", VA = "0x188367690")]
	public NLEPKGHFPKN(Behaviour OJFCDDMGKNP, float CJKNPFOAPCJ, [Optional] Action MOBHKAEBNBN, [Optional] GOHHNGJKPGH OBCJAOHMKMM, [Optional] AIGGEIIJPCB DLPBPIIEOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x837C920", Offset = "0x837B320", VA = "0x18837C920", Slot = "9")]
	protected override bool ACAAJFJPCIP(Action HNDDBOOOBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x837CA30", Offset = "0x837B430", VA = "0x18837CA30", Slot = "10")]
	protected override bool MPLEKCLHLPL(Action HNDDBOOOBBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface ABDKHFBDLNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JFPKMPPKFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DDGONHAHEIJ;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HHAAOBMIMJL(bool JDEIJIAFEMH = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HHAAOBMIMJL(Action HNDDBOOOBBE, bool JDEIJIAFEMH = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class CMNGKBICHOI : ABDKHFBDLNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class JBOLFECCCMC : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CMNGKBICHOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public JBOLFECCCMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8373AE0", Offset = "0x83724E0", VA = "0x188373AE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8373BB0", Offset = "0x83725B0", VA = "0x188373BB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour OJFCDDMGKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action MOBHKAEBNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private FDJPMDOFNPO AOCHDEJOMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly GOHHNGJKPGH OBCJAOHMKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly AIGGEIIJPCB DLPBPIIEOLF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JFPKMPPKFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x19459C0", Offset = "0x19443C0", VA = "0x1819459C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DDGONHAHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8365ED0", Offset = "0x83648D0", VA = "0x188365ED0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8365FB0", Offset = "0x83649B0", VA = "0x188365FB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x83660D0", Offset = "0x8364AD0", VA = "0x1883660D0")]
	protected CMNGKBICHOI(Behaviour OJFCDDMGKNP, [Optional] Action MOBHKAEBNBN, [Optional] GOHHNGJKPGH OBCJAOHMKMM, [Optional] AIGGEIIJPCB DLPBPIIEOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8365DC0", Offset = "0x83647C0", VA = "0x188365DC0", Slot = "7")]
	public bool HHAAOBMIMJL(bool JDEIJIAFEMH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8365D60", Offset = "0x8364760", VA = "0x188365D60", Slot = "8")]
	public bool HHAAOBMIMJL(Action HNDDBOOOBBE, bool JDEIJIAFEMH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool ACAAJFJPCIP(Action HNDDBOOOBBE);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool MPLEKCLHLPL(Action HNDDBOOOBBE);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8365EB0", Offset = "0x83648B0", VA = "0x188365EB0")]
	protected void LIFHGHBIIBC(Action HNDDBOOOBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8365B10", Offset = "0x8364510", VA = "0x188365B10")]
	protected JCIOFMEGJFK DIAHJCCPDLH(float JHEFBFGKIFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8366050", Offset = "0x8364A50", VA = "0x188366050")]
	private void PDFNKBBDKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8365E20", Offset = "0x8364820", VA = "0x188365E20")]
	[IteratorStateMachine(typeof(JBOLFECCCMC))]
	private IEnumerator<HKMFJDMPEMN> HPNIMGILJIB(float JHEFBFGKIFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8365F70", Offset = "0x8364970", VA = "0x188365F70")]
	[CompilerGenerated]
	private void OBKNGJBNPCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class IIKKKNECEFF : CMNGKBICHOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float LFODNOFGHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int ONBJIMKEBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float OJKIPDPDNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] LJOPAGOMHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int AMKMOOBIKFD;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8373310", Offset = "0x8371D10", VA = "0x188373310")]
	public IIKKKNECEFF(Behaviour OJFCDDMGKNP, float PALFMFOEMCP, int ONBJIMKEBDP, [Optional] Action MOBHKAEBNBN, float OJKIPDPDNNP = 0f, [Optional] GOHHNGJKPGH OBCJAOHMKMM, [Optional] AIGGEIIJPCB DLPBPIIEOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "9")]
	protected override bool ACAAJFJPCIP(Action HNDDBOOOBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8373110", Offset = "0x8371B10", VA = "0x188373110", Slot = "10")]
	protected override bool MPLEKCLHLPL(Action HNDDBOOOBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8373090", Offset = "0x8371A90", VA = "0x188373090")]
	private void BFADCJOLNNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class CPECIGJNONN : CMNGKBICHOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float CJKNPFOAPCJ;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8367690", Offset = "0x8366090", VA = "0x188367690")]
	public CPECIGJNONN(Behaviour OJFCDDMGKNP, float CJKNPFOAPCJ, [Optional] Action MOBHKAEBNBN, [Optional] GOHHNGJKPGH OBCJAOHMKMM, [Optional] AIGGEIIJPCB DLPBPIIEOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "9")]
	protected override bool ACAAJFJPCIP(Action HNDDBOOOBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8367650", Offset = "0x8366050", VA = "0x188367650", Slot = "10")]
	protected override bool MPLEKCLHLPL(Action HNDDBOOOBBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class GGACJLPONDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GPEJMLMPEGP : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public GPEJMLMPEGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8371800", Offset = "0x8370200", VA = "0x188371800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8371870", Offset = "0x8370270", VA = "0x188371870", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NBLJJLKPDOF IDIPGFDDFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private PPNLLFDFCCO OJFCDDMGKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> BEKHGCHKAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private PDAPCALENKF LCBFLFDPPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float NEAFACOMFFK;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8370FF0", Offset = "0x836F9F0", VA = "0x188370FF0")]
	public GGACJLPONDC(PPNLLFDFCCO OJFCDDMGKNP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8370C80", Offset = "0x836F680", VA = "0x188370C80")]
	private void MHLEOEHILPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8370B50", Offset = "0x836F550", VA = "0x188370B50")]
	private void JIMJHPAJHKE(string LPNLOGECJBM, Action FJBANFFBJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8370F70", Offset = "0x836F970", VA = "0x188370F70")]
	[IteratorStateMachine(typeof(GPEJMLMPEGP))]
	private IEnumerator<HKMFJDMPEMN> NKHPMHOPJFI(Action FJBANFFBJEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8370AF0", Offset = "0x836F4F0", VA = "0x188370AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8370DF0", Offset = "0x836F7F0", VA = "0x188370DF0")]
	[CompilerGenerated]
	private void NDJAJGJMLLF(string CHDFBHPMACH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class GEJLDKDOKNL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class OODPHKAJLJM : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public OODPHKAJLJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8371800", Offset = "0x8370200", VA = "0x188371800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x837DBA0", Offset = "0x837C5A0", VA = "0x18837DBA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NBLJJLKPDOF IDIPGFDDFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour GCAIDLEJDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action BDALOJMNHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> BEKHGCHKAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private PDAPCALENKF LCBFLFDPPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float NEAFACOMFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool HKGIIIPAGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly GOHHNGJKPGH OBCJAOHMKMM;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8370960", Offset = "0x836F360", VA = "0x188370960")]
	public GEJLDKDOKNL(MonoBehaviour GCAIDLEJDBP, Action BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, [Optional] GOHHNGJKPGH OBCJAOHMKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x83705B0", Offset = "0x836EFB0", VA = "0x1883705B0")]
	public GEJLDKDOKNL(MonoBehaviour GCAIDLEJDBP, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, [Optional] GOHHNGJKPGH OBCJAOHMKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8370780", Offset = "0x836F180", VA = "0x188370780")]
	public GEJLDKDOKNL(MonoBehaviour GCAIDLEJDBP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, bool HKGIIIPAGKG = true, [Optional] GOHHNGJKPGH OBCJAOHMKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x49A79E0", Offset = "0x49A63E0", VA = "0x1849A79E0")]
	private GEJLDKDOKNL(GOHHNGJKPGH OBCJAOHMKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8370380", Offset = "0x836ED80", VA = "0x188370380")]
	internal static GEJLDKDOKNL ODFDHNBODFA(MonoBehaviour GCAIDLEJDBP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK, PDAPCALENKF LCBFLFDPPON, bool HKGIIIPAGKG = true, [Optional] GOHHNGJKPGH OBCJAOHMKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x83701D0", Offset = "0x836EBD0", VA = "0x1883701D0")]
	private void MPCGJLOFMNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x836FEE0", Offset = "0x836E8E0", VA = "0x18836FEE0")]
	private void LAONGAANPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8370060", Offset = "0x836EA60", VA = "0x188370060")]
	private void MHLEOEHILPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x836FAA0", Offset = "0x836E4A0", VA = "0x18836FAA0")]
	private void CCPIFGADCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x836FDB0", Offset = "0x836E7B0", VA = "0x18836FDB0")]
	private void JIMJHPAJHKE(string LPNLOGECJBM, Action FJBANFFBJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8370300", Offset = "0x836ED00", VA = "0x188370300")]
	[IteratorStateMachine(typeof(OODPHKAJLJM))]
	private IEnumerator<HKMFJDMPEMN> NKHPMHOPJFI(Action FJBANFFBJEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x836FC30", Offset = "0x836E630", VA = "0x18836FC30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x836F980", Offset = "0x836E380", VA = "0x18836F980")]
	[CompilerGenerated]
	private void BBFJCCFFBFA(string CHDFBHPMACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x836FC90", Offset = "0x836E690", VA = "0x18836FC90")]
	[CompilerGenerated]
	private void GPPBDELFHMP(string CHDFBHPMACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x836FD20", Offset = "0x836E720", VA = "0x18836FD20")]
	[CompilerGenerated]
	private void JIIJCBPLKCA(string CHDFBHPMACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x836FA10", Offset = "0x836E410", VA = "0x18836FA10")]
	[CompilerGenerated]
	private void BPJNGLCGBGN(string CHDFBHPMACH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum MILAABNFIPG : byte
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
internal sealed class HPNKBEMBMIC : AIGGEIIJPCB
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float DOBIOAAAFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8372650", Offset = "0x8371050", VA = "0x188372650", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float JNIHHMKDDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8372640", Offset = "0x8371040", VA = "0x188372640", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double HMFDIECFBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8372620", Offset = "0x8371020", VA = "0x188372620", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x83725B0", Offset = "0x8370FB0", VA = "0x1883725B0")]
	[EFEOGKEOEKD.IHENNBHNBPA]
	internal static void DKLGFMPPBPK(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	[UnityEngine.Scripting.Preserve]
	internal HPNKBEMBMIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface AIAKKMIHENH
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHAMCOKDAMM(string EMLAIMJKHOE);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJNDBFANDGB();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface KJAAEGBGDMD
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string HFKDIDMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LNAJNJCEACL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool JBINHBCMJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class OGKHLLGOIPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public NICJCNGPGKG HNELONMIPFC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int LIGNGKONFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9B9180", Offset = "0x9B7B80", VA = "0x1809B9180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x837CB40", Offset = "0x837B540", VA = "0x18837CB40")]
	public static HKMFJDMPEMN BIDFGCIGOFH(IEnumerator<HKMFJDMPEMN> DMCGKGLELJB, BFPDHEFBKGH NEMOMCDJPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x837CCA0", Offset = "0x837B6A0", VA = "0x18837CCA0")]
	public HKMFJDMPEMN BIDFGCIGOFH(BFPDHEFBKGH[] NGGALMLFBLG, IEnumerator<HKMFJDMPEMN>[] LJLLDLJDBAP, HKMFJDMPEMN[] PKCDJFGLPHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x837CEA0", Offset = "0x837B8A0", VA = "0x18837CEA0")]
	public void PFMGIMFANDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x837CED0", Offset = "0x837B8D0", VA = "0x18837CED0")]
	public void LAGHCEFLAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x837CD60", Offset = "0x837B760", VA = "0x18837CD60")]
	public void CNDCFPCODPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x837CEA0", Offset = "0x837B8A0", VA = "0x18837CEA0")]
	public void DDDFCMLAOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public OGKHLLGOIPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class NICJCNGPGKG
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct ANIMEANCLCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public OGKHLLGOIPF FNAKJPECDHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public PPNLLFDFCCO GPNDPHJOAKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public BFPDHEFBKGH KCBHNJKKDIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<HKMFJDMPEMN> MEBNLDGMCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HKMFJDMPEMN BKHAPKNHABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public MILAABNFIPG GOACDJJMFPK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct NCAMGIFIPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public PDAPCALENKF CIODPDPDDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<ANIMEANCLCH> FBEKNNKGJCG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class PMOMLKMACLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public BFPDHEFBKGH promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public NICJCNGPGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public PPNLLFDFCCO context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public OGKHLLGOIPF routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public MILAABNFIPG coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public HKMFJDMPEMN currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<HKMFJDMPEMN> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public PMOMLKMACLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x837ED40", Offset = "0x837D740", VA = "0x18837ED40")]
		internal void DINCAECMPHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class EAMCPIDMMJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public OGKHLLGOIPF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public NICJCNGPGKG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EAMCPIDMMJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x836E3D0", Offset = "0x836CDD0", VA = "0x18836E3D0")]
		internal void DHPPAILBJGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class NGBBJEIDOPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public OGKHLLGOIPF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public NICJCNGPGKG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NGBBJEIDOPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8379A80", Offset = "0x8378480", VA = "0x188379A80")]
		internal void AGCHIEJJIOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class FBBCDKNFGIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public OGKHLLGOIPF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public NICJCNGPGKG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public FBBCDKNFGIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x836EBC0", Offset = "0x836D5C0", VA = "0x18836EBC0")]
		internal void BCIKFAPEBMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const MILAABNFIPG KCPEGMBPAEJ = MILAABNFIPG.Cancelled | MILAABNFIPG.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly PDAPCALENKF LCBFLFDPPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] NINEJPCNJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<MILAABNFIPG> FCFOGHJBKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> NPAPNOKMACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> GDGBFMNBCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> LMGKMDDDHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> AIJIKOAEOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> GFIAELMCBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> BLCCDALPKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private OGKHLLGOIPF[] HPIKCBCEKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private BFPDHEFBKGH[] NGGALMLFBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private PPNLLFDFCCO[] KKFJMFHHABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<HKMFJDMPEMN>[] NFDBMOELFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private HKMFJDMPEMN[] OPPAOKECOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int CGLBJEJNCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int CIIHPLFOGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int AOMFOMGHHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float HMFFGMCECOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private KAKEBPIGCHC CLFDJBKKPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle DIDIKKKKLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<OGKHLLGOIPF> KDOHJPOHLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool POFLHFOKINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> KDBLGHNNGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> MFJEDAFCEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool CAEEKBHLKNN;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public NCAMGIFIPPN[] EMIBLHOLBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA425F0", Offset = "0xA40FF0", VA = "0x180A425F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x837B2A0", Offset = "0x8379CA0", VA = "0x18837B2A0")]
	private static int GPKJBGHIOBM(PDAPCALENKF LCBFLFDPPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x837C030", Offset = "0x837AA30", VA = "0x18837C030")]
	public NICJCNGPGKG(PDAPCALENKF LCBFLFDPPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x837BC50", Offset = "0x837A650", VA = "0x18837BC50")]
	private void OJJCINIOPKN(int CGPFDGPHKNP, int ICEDJPMOMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x837A040", Offset = "0x8378A40", VA = "0x18837A040")]
	public void APLFLEOCGPG(PPNLLFDFCCO OJFCDDMGKNP, HKMFJDMPEMN CCGFCJDGOLO, IEnumerator<HKMFJDMPEMN> DMCGKGLELJB, BFPDHEFBKGH NEMOMCDJPID, [Optional] OGKHLLGOIPF DGIIEAPGCAP, MILAABNFIPG DNDGGMOCDDL = MILAABNFIPG.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x837B060", Offset = "0x8379A60", VA = "0x18837B060")]
	public void EECGMKNAFDF(IEnumerable<ANIMEANCLCH> DBGNILCIIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x837A8E0", Offset = "0x83792E0", VA = "0x18837A8E0")]
	private ANIMEANCLCH CCNKDCPGDON(int BONCKHCAFCN)
	{
		return default(ANIMEANCLCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x837B5B0", Offset = "0x8379FB0", VA = "0x18837B5B0")]
	private void MKPALJKKIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x37EC5C0", Offset = "0x37EAFC0", VA = "0x1837EC5C0")]
	private static void MOJIDMMEDGH<T>(int BONCKHCAFCN, T[] MDBLNBLDMBD, int PICLDLMFMMM, [Optional] T KBGEGLEDIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x37EC610", Offset = "0x37EB010", VA = "0x1837EC610")]
	private static void MOJIDMMEDGH<T>(int BONCKHCAFCN, NativeArray<T> MDBLNBLDMBD, int PICLDLMFMMM, [Optional] T KBGEGLEDIBA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8379CA0", Offset = "0x83786A0", VA = "0x188379CA0")]
	private void ABHOCHLPDJD(IEnumerable<ANIMEANCLCH> DBGNILCIIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x837B920", Offset = "0x837A320", VA = "0x18837B920")]
	private void NNNDLDFEFHH(ANIMEANCLCH JIMKAGMDMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x837B9F0", Offset = "0x837A3F0", VA = "0x18837B9F0")]
	private ACFCKGMDEFB OGCFJHLIBJH(int CKACPKGBIKC)
	{
		return default(ACFCKGMDEFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x837BE30", Offset = "0x837A830", VA = "0x18837BE30")]
	public void PELPDMAHBPN(float KOCGPIEMEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x837ADB0", Offset = "0x83797B0", VA = "0x18837ADB0")]
	private void CHEEBMGJJCB(Action KEEADJCBJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x837B2D0", Offset = "0x8379CD0", VA = "0x18837B2D0")]
	private void HJDPFFOBCBG(Action KEEADJCBJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x837A1C0", Offset = "0x8378BC0", VA = "0x18837A1C0")]
	public void BJEBJCKPJMJ(float KOCGPIEMEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x837AE30", Offset = "0x8379830", VA = "0x18837AE30")]
	public void CHMHFDMILHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x837AF30", Offset = "0x8379930", VA = "0x18837AF30")]
	public void DDDFCMLAOKM(OGKHLLGOIPF MIECCFEONCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x837B350", Offset = "0x8379D50", VA = "0x18837B350")]
	public void JOICCKEIOOC(OGKHLLGOIPF MIECCFEONCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x837B480", Offset = "0x8379E80", VA = "0x18837B480")]
	public void MHOBBFMDFEG(OGKHLLGOIPF MIECCFEONCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JNAJACMOCBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly JNAJACMOCBK KPJGFDDMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action APIACJCBFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool AGGPBOPKIOC;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	public JNAJACMOCBK(Action APIACJCBFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7A29890", Offset = "0x7A28290", VA = "0x187A29890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface ALKELEGHDJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable ALLKKNLHJPI(UnityEngine.Object OJFCDDMGKNP, Action<T> BGCJBBNAHIC);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface GBDHHAGFCBO<T> : ALKELEGHDJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class JMIOLPFOEKN<T> : GBDHHAGFCBO<T>, ALKELEGHDJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class IEKIBLELFDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public JMIOLPFOEKN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public BJBKJJKBKMJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public IEKIBLELFDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4A78F60", Offset = "0x4A77960", VA = "0x184A78F60")]
		internal void CNOLFGAJNLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject AMJLCACHIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<BJBKJJKBKMJ<UnityEngine.Object, Action<T>>> LDNPEPEJFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T LBPOFNAAOJN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA45A60", Offset = "0xA44460", VA = "0x180A45A60", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4D10AC0", Offset = "0x4D0F4C0", VA = "0x184D10AC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4D112A0", Offset = "0x4D0FCA0", VA = "0x184D112A0")]
	private static bool PFKFAEOOHJF(T KEEADJCBJCP, T LKKBJAKGIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4D11360", Offset = "0x4D0FD60", VA = "0x184D11360")]
	public JMIOLPFOEKN(T BAEFNCBCDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D10910", Offset = "0x4D0F310", VA = "0x184D10910", Slot = "6")]
	public IDisposable ALLKKNLHJPI(UnityEngine.Object OJFCDDMGKNP, Action<T> BGCJBBNAHIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D10C10", Offset = "0x4D0F610", VA = "0x184D10C10")]
	private void FEOBKMMCMCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class OMODIHGMDHA : MKAENCPCGCF
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class GKNFCIPGPKE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class JNDEOCNFKMH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int ICHIIHCEGJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private GKNFCIPGPKE PLJAPGLDFIC;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xE516B0", Offset = "0xE500B0", VA = "0x180E516B0")]
			public JNDEOCNFKMH(int ICHIIHCEGJD, GKNFCIPGPKE PLJAPGLDFIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x8374820", Offset = "0x8373220", VA = "0x188374820", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class PIJDFCANABP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public PIJDFCANABP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xD3D820", Offset = "0xD3C220", VA = "0x180D3D820")]
			internal bool BOJFCNEBHJJ(JFHOKEECELJ e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class NEBJCEGMFEH : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private HKMFJDMPEMN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public GKNFCIPGPKE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public AIGGEIIJPCB timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private LAIKNCNKMDG <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<JFHOKEECELJ> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
			[DebuggerHidden]
			public NEBJCEGMFEH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8379450", Offset = "0x8377E50", VA = "0x188379450", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8379780", Offset = "0x8378180", VA = "0x188379780", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly PDAPCALENKF LCBFLFDPPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private NBLJJLKPDOF NEMOMCDJPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<JFHOKEECELJ> GNCABPMOJEL;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8371680", Offset = "0x8370080", VA = "0x188371680")]
		public GKNFCIPGPKE(PDAPCALENKF LCBFLFDPPON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8371410", Offset = "0x836FE10", VA = "0x188371410")]
		public IDisposable CCJPBINFLDL(JFHOKEECELJ LJOJPGLFDLN, GOHHNGJKPGH OBCJAOHMKMM, AIGGEIIJPCB NDBGCDOMBIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8371280", Offset = "0x836FC80", VA = "0x188371280")]
		private void ABGHFOBKAHB(int ICHIIHCEGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x83715F0", Offset = "0x836FFF0", VA = "0x1883715F0")]
		[IteratorStateMachine(typeof(NEBJCEGMFEH))]
		private IEnumerator<HKMFJDMPEMN> OOMOACIJJPO(AIGGEIIJPCB NDBGCDOMBIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x83715A0", Offset = "0x836FFA0", VA = "0x1883715A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class JFHOKEECELJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum LFLLFIKPOBD : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int EIAHEDPJPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int FIGDAIADJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly BEPIEELIFLK GPNDPHJOAKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour LBGJPEIFNJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action IPDLKHCHONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> BOGFKHLMDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float NBIAMJPPLOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float NPAPNOKMACB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string HFKDIDMKBGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool MOGNCKAOOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly LFLLFIKPOBD GPMFFHNJCGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool JBECALMLOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool FLOMBBAALPI;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8373FC0", Offset = "0x83729C0", VA = "0x188373FC0")]
		public JFHOKEECELJ(BEPIEELIFLK OJFCDDMGKNP, Action BDALOJMNHKK, bool DHBKFFOOOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8374320", Offset = "0x8372D20", VA = "0x188374320")]
		public JFHOKEECELJ(BEPIEELIFLK OJFCDDMGKNP, Action<float> BDALOJMNHKK, bool DHBKFFOOOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8374140", Offset = "0x8372B40", VA = "0x188374140")]
		public JFHOKEECELJ(BEPIEELIFLK OJFCDDMGKNP, float BKPJMMHCGEE, Action<float> BDALOJMNHKK, AIGGEIIJPCB NDBGCDOMBIN, LFLLFIKPOBD EGDPOJEBACL, bool HKGIIIPAGKG, bool DHBKFFOOOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8373DF0", Offset = "0x83727F0", VA = "0x188373DF0")]
		public bool GBJEKFPNLJG(float KDFJLNMBGOO, float IMBJMPJOKHE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly GOHHNGJKPGH OBCJAOHMKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly AIGGEIIJPCB DLPBPIIEOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<PDAPCALENKF, GKNFCIPGPKE> HLKJCGODLJK;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x837D010", Offset = "0x837BA10", VA = "0x18837D010")]
	[EFEOGKEOEKD.IHENNBHNBPA]
	internal static void APPILLGBPFF(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x837DAE0", Offset = "0x837C4E0", VA = "0x18837DAE0")]
	[UnityEngine.Scripting.Preserve]
	internal OMODIHGMDHA([GJJKIKPKKBJ(null)] GOHHNGJKPGH OBCJAOHMKMM, [GJJKIKPKKBJ(null)] AIGGEIIJPCB DLPBPIIEOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x837D400", Offset = "0x837BE00", VA = "0x18837D400", Slot = "4")]
	public IDisposable IPDLKHCHONO(BEPIEELIFLK OJFCDDMGKNP, Action PCKPGHHEKOC, PDAPCALENKF LCBFLFDPPON, bool DHBKFFOOOGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x837D5F0", Offset = "0x837BFF0", VA = "0x18837D5F0", Slot = "5")]
	public IDisposable IPDLKHCHONO(BEPIEELIFLK OJFCDDMGKNP, Action<float> PCKPGHHEKOC, PDAPCALENKF LCBFLFDPPON, bool DHBKFFOOOGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x837D200", Offset = "0x837BC00", VA = "0x18837D200", Slot = "7")]
	public IDisposable CBOELOKEHBF(BEPIEELIFLK OJFCDDMGKNP, float BKPJMMHCGEE, Action<float> PCKPGHHEKOC, PDAPCALENKF LCBFLFDPPON, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x837D300", Offset = "0x837BD00", VA = "0x18837D300", Slot = "8")]
	public IDisposable CJPHIIDIIPJ(BEPIEELIFLK OJFCDDMGKNP, float BKPJMMHCGEE, Action<float> PCKPGHHEKOC, PDAPCALENKF LCBFLFDPPON, bool HKGIIIPAGKG = true, bool DHBKFFOOOGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x837D080", Offset = "0x837BA80", VA = "0x18837D080", Slot = "6")]
	public IDisposable CBOELOKEHBF(float BKPJMMHCGEE, Action<float> PCKPGHHEKOC, bool HKGIIIPAGKG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x837D920", Offset = "0x837C320", VA = "0x18837D920", Slot = "9")]
	public void OPIOKFDHGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x837D7E0", Offset = "0x837C1E0", VA = "0x18837D7E0")]
	private GKNFCIPGPKE OODDAHONMBN(PDAPCALENKF LCBFLFDPPON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class FNEPNLEFDKI : CPAIKIFGHID, GOHHNGJKPGH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NICJCNGPGKG[] FEIHCBCBPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private AIAKKMIHENH LDJKEBAMKEO;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x836EF60", Offset = "0x836D960", VA = "0x18836EF60")]
	[EFEOGKEOEKD.IHENNBHNBPA]
	internal static void DKLGFMPPBPK(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x836F860", Offset = "0x836E260", VA = "0x18836F860")]
	[UnityEngine.Scripting.Preserve]
	public FNEPNLEFDKI([GJJKIKPKKBJ(null)] NMPLNECABPA DOAFOJDHDFK, [GJJKIKPKKBJ(null)] AIGGEIIJPCB DLPBPIIEOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x836EE30", Offset = "0x836D830", VA = "0x18836EE30", Slot = "19")]
	public override NBLJJLKPDOF BLNFMFLNLBB(PPNLLFDFCCO OJFCDDMGKNP, IEnumerator<HKMFJDMPEMN> NCAGIIMOHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x836F5D0", Offset = "0x836DFD0", VA = "0x18836F5D0", Slot = "20")]
	public override void OPIOKFDHGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x836EC00", Offset = "0x836D600", VA = "0x18836EC00", Slot = "22")]
	public override void AGOCNIBPHNO(PDAPCALENKF LCBFLFDPPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x836F310", Offset = "0x836DD10", VA = "0x18836F310", Slot = "21")]
	protected override void IPDLKHCHONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x836F5A0", Offset = "0x836DFA0", VA = "0x18836F5A0")]
	private NICJCNGPGKG LJKHKJCNHCK(PDAPCALENKF OHCGINPDMEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x836F030", Offset = "0x836DA30", VA = "0x18836F030", Slot = "23")]
	internal override BAIDCCIMIMH HAPEDLJIHBB(IEnumerator<HKMFJDMPEMN> NCAGIIMOHEI, Behaviour OJFCDDMGKNP, BFPDHEFBKGH NEMOMCDJPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x836F250", Offset = "0x836DC50", VA = "0x18836F250", Slot = "24")]
	internal override DFICEDFIPCB ICHGCOGEINJ(PDAPCALENKF PLJAPGLDFIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x836F480", Offset = "0x836DE80", VA = "0x18836F480")]
	private void LHFDDJOGEEB(NICJCNGPGKG GGLPPECBMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x836EFD0", Offset = "0x836D9D0", VA = "0x18836EFD0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct KAKEBPIGCHC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float AOHMKGLINBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int DGBPKCCLFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> IFOPLKBAEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> LOPLCLDJNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> MOLKOCOBGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<MILAABNFIPG> GFIHDMBJNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> KDOCCMKPHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> AIJIKOAEOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> GDGBFMNBCOB;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8374F00", Offset = "0x8373900", VA = "0x188374F00")]
	public static KAKEBPIGCHC IDEDHGEBOCJ(int AINLGPGFEFM, float KOCGPIEMEIF, NativeArray<MILAABNFIPG> CFNGMEAPBAN, NativeArray<float> LNJKJIDOOKF, NativeArray<int> LBJJPADHKJK, NativeArray<int> DLBIGCIPBEM, NativeArray<int> INNMCNGNIMM, NativeArray<int> LOPLCLDJNMD, NativeArray<int> MOLKOCOBGGH)
	{
		return default(KAKEBPIGCHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8374DE0", Offset = "0x83737E0", VA = "0x188374DE0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8374EC0", Offset = "0x83738C0", VA = "0x188374EC0")]
	private bool FKMICGEIPLI(int DOAKEFBOPIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x83750D0", Offset = "0x8373AD0", VA = "0x1883750D0")]
	private void PCGAIEACBMP(NativeArray<int> FFMGEAMPHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8374F60", Offset = "0x8373960", VA = "0x188374F60")]
	private int IIFPEKNIOHA(int FHEOODOIHKC, int HACMHDGEKNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8375000", Offset = "0x8373A00", VA = "0x188375000")]
	private void NAABHHCOMCB(NativeArray<int> FFMGEAMPHBP, int LMGBJLCCMHP, int LIFAHFCIJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8374BA0", Offset = "0x83735A0", VA = "0x188374BA0")]
	private void ABGOJFBMIFA(NativeArray<int> FFMGEAMPHBP, int IGLNPKHBOPG, int CICHHDMFEIJ, int CDBMMBADDDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class CPAIKIFGHID : GOHHNGJKPGH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly NMPLNECABPA DOAFOJDHDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly AIGGEIIJPCB DLPBPIIEOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private DFICEDFIPCB[] PEMGHPBIBEL;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static GOHHNGJKPGH LALLOKGAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8366B60", Offset = "0x8365560", VA = "0x188366B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool BHLAOEGENBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public PDAPCALENKF EECNGEGAAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(PDAPCALENKF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B9180", Offset = "0x9B7B80", VA = "0x1809B9180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public AIGGEIIJPCB MPKJFKIOBMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public HKMFJDMPEMN KMMNBAGAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HKMFJDMPEMN GBGEGNOLDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9B22C0", Offset = "0x9B0CC0", VA = "0x1809B22C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public HKMFJDMPEMN JBHMGAHNAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFF0", Offset = "0x9AD9F0", VA = "0x1809AEFF0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public HKMFJDMPEMN NBGKDINHKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4F0", Offset = "0x9AAEF0", VA = "0x1809AC4F0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8366CC0", Offset = "0x83656C0", VA = "0x188366CC0")]
	public static NBLJJLKPDOF MJOHPCKJMAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8367160", Offset = "0x8365B60", VA = "0x188367160")]
	[UnityEngine.Scripting.Preserve]
	protected CPAIKIFGHID([GJJKIKPKKBJ(null)] NMPLNECABPA DOAFOJDHDFK, [GJJKIKPKKBJ(null)] AIGGEIIJPCB DLPBPIIEOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8366FB0", Offset = "0x83659B0", VA = "0x188366FB0", Slot = "6")]
	public NBLJJLKPDOF OBEHDDJHDFO(IEnumerator<HKMFJDMPEMN> NCAGIIMOHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8366DB0", Offset = "0x83657B0", VA = "0x188366DB0", Slot = "7")]
	public NBLJJLKPDOF OBEHDDJHDFO(Behaviour OJFCDDMGKNP, IEnumerator<HKMFJDMPEMN> NCAGIIMOHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract NBLJJLKPDOF BLNFMFLNLBB(PPNLLFDFCCO OJFCDDMGKNP, IEnumerator<HKMFJDMPEMN> NCAGIIMOHEI);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8366FC0", Offset = "0x83659C0", VA = "0x188366FC0", Slot = "20")]
	public virtual void OPIOKFDHGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x8366710", Offset = "0x8365110", VA = "0x188366710", Slot = "9")]
	public void HOGEJFHJFFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x8366B40", Offset = "0x8365540", VA = "0x188366B40", Slot = "21")]
	protected virtual void IPDLKHCHONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8366B20", Offset = "0x8365520", VA = "0x188366B20")]
	private void IMANLMNNBJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8366BD0", Offset = "0x83655D0", VA = "0x188366BD0")]
	private void JPKDJBPIFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8366330", Offset = "0x8364D30", VA = "0x188366330")]
	private void DLDMAPJAPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8366C80", Offset = "0x8365680", VA = "0x188366C80")]
	private void LEPKCJFFKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8366CA0", Offset = "0x83656A0", VA = "0x188366CA0")]
	private void LFMCCFLLECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8366200", Offset = "0x8364C00", VA = "0x188366200")]
	private void AAIIEIJDHJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8366310", Offset = "0x8364D10", VA = "0x188366310")]
	private void DILDGAPBPOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8366220", Offset = "0x8364C20", VA = "0x188366220", Slot = "22")]
	public virtual void AGOCNIBPHNO(PDAPCALENKF LCBFLFDPPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8366950", Offset = "0x8365350", VA = "0x188366950")]
	private void IDKAGFHNECA(DFICEDFIPCB GGLPPECBMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2598BA0", Offset = "0x25975A0", VA = "0x182598BA0")]
	private DFICEDFIPCB GFHOLAKNMOL(PDAPCALENKF OHCGINPDMEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract BAIDCCIMIMH HAPEDLJIHBB(IEnumerator<HKMFJDMPEMN> NCAGIIMOHEI, Behaviour GCAIDLEJDBP, BFPDHEFBKGH OLLACBGCLKH);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract DFICEDFIPCB ICHGCOGEINJ(PDAPCALENKF LCBFLFDPPON);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8366350", Offset = "0x8364D50", VA = "0x188366350", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x83662B0", Offset = "0x8364CB0", VA = "0x1883662B0", Slot = "15")]
	public HKMFJDMPEMN BFLKFLNMMMI(PDAPCALENKF PLJAPGLDFIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8366BF0", Offset = "0x83655F0", VA = "0x188366BF0", Slot = "16")]
	public HKMFJDMPEMN KJOJHINGGHE(float KFGHOINKLDG, PDAPCALENKF PLJAPGLDFIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8366D50", Offset = "0x8365750", VA = "0x188366D50", Slot = "17")]
	public HKMFJDMPEMN NKGANJBHPEE(Func<bool> GFLFPOCDIEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class BAIDCCIMIMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly BFPDHEFBKGH NEMOMCDJPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly KJAAEGBGDMD OJFCDDMGKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool GKDAAJFGDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string EMLAIMJKHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace MANDIAFANLF;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<HKMFJDMPEMN> MEBNLDGMCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HKMFJDMPEMN BKHAPKNHABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool ACEKALPLFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8363B70", Offset = "0x8362570", VA = "0x188363B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool ELHCEPHGJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xBAD050", Offset = "0xBABA50", VA = "0x180BAD050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xBB3370", Offset = "0xBB1D70", VA = "0x180BB3370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string HFKDIDMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8363F10", Offset = "0x8362910", VA = "0x188363F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float AEGFOLNBOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xF8EF00", Offset = "0xF8D900", VA = "0x180F8EF00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6D21090", Offset = "0x6D1FA90", VA = "0x186D21090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x8364260", Offset = "0x8362C60", VA = "0x188364260")]
	public BAIDCCIMIMH(IEnumerator<HKMFJDMPEMN> DMCGKGLELJB, KJAAEGBGDMD OJFCDDMGKNP, BFPDHEFBKGH NEMOMCDJPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8363BF0", Offset = "0x83625F0", VA = "0x188363BF0")]
	public HKMFJDMPEMN BIDFGCIGOFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8364110", Offset = "0x8362B10", VA = "0x188364110")]
	public bool NKFGAELHOIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x83640C0", Offset = "0x8362AC0", VA = "0x1883640C0")]
	public void DDDFCMLAOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x8364180", Offset = "0x8362B80", VA = "0x188364180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xC0A3E0", Offset = "0xC08DE0", VA = "0x180C0A3E0")]
	[CompilerGenerated]
	private void PLCBPEBCEMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class BFPDHEFBKGH : NBKNOOMPOOB, NBLJJLKPDOF, FDJPMDOFNPO, JCIOFMEGJFK, IEnumerator, HKMFJDMPEMN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private PDAPCALENKF BIPIEGEDNLI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private PDAPCALENKF IGAOBMEAPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xCF56E0", Offset = "0xCF40E0", VA = "0x180CF56E0", Slot = "23")]
		get
		{
			return default(PDAPCALENKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public PDAPCALENKF HNELONMIPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xE8BFF0", Offset = "0xE8A9F0", VA = "0x180E8BFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float JJALBMBGBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xB3AF50", Offset = "0xB39950", VA = "0x180B3AF50", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PNCJNCEMBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8365180", Offset = "0x8363B80", VA = "0x188365180", Slot = "24")]
	private bool GJAINCBJKGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8365170", Offset = "0x8363B70", VA = "0x188365170", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x83651A0", Offset = "0x8363BA0", VA = "0x1883651A0")]
	public BFPDHEFBKGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum ACFCKGMDEFB : byte
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
internal sealed class DFICEDFIPCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum EJCBMDOCKGC
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct MGOOLEBAKEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public PDAPCALENKF CIODPDPDDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public EJCBMDOCKGC BEPFEGNEDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<BAIDCCIMIMH> BFIFGOPOJIG;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly EJCBMDOCKGC[] JNNGOPJJNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly PDAPCALENKF LCBFLFDPPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool KLLBIHHGJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly BAIDCCIMIMH[] CEKFLMDBJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<BAIDCCIMIMH> ONNDOCIJILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> LIJCOMEHMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<BAIDCCIMIMH> NGKAPFCMFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> OFNFHHGILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly AIAKKMIHENH BFKHEIGGPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool CAEEKBHLKNN;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MGOOLEBAKEF[,] HOIPJNFNIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFF0", Offset = "0x9AD9F0", VA = "0x1809AEFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x836D2A0", Offset = "0x836BCA0", VA = "0x18836D2A0")]
	public DFICEDFIPCB(PDAPCALENKF PLJAPGLDFIC, AIAKKMIHENH BFKHEIGGPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x836D070", Offset = "0x836BA70", VA = "0x18836D070")]
	public void PLKICDJKBGJ(BAIDCCIMIMH DMCGKGLELJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x836CA20", Offset = "0x836B420", VA = "0x18836CA20")]
	public void KODGFBHCABN(IList<BAIDCCIMIMH> LJLLDLJDBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x836C2E0", Offset = "0x836ACE0", VA = "0x18836C2E0")]
	public void FLOGAMHDOOF(IList<BAIDCCIMIMH> LJLLDLJDBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x836C7C0", Offset = "0x836B1C0", VA = "0x18836C7C0")]
	private void ICNIDMFHKBM(BAIDCCIMIMH DMCGKGLELJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x836BEC0", Offset = "0x836A8C0", VA = "0x18836BEC0")]
	private void DBPJDBEPOHN(IList<BAIDCCIMIMH> LJLLDLJDBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x836C160", Offset = "0x836AB60", VA = "0x18836C160")]
	private ACFCKGMDEFB FLJIDHDONKN(BAIDCCIMIMH DMCGKGLELJB)
	{
		return default(ACFCKGMDEFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x836C8B0", Offset = "0x836B2B0", VA = "0x18836C8B0")]
	public void IPDLKHCHONO(float KOCGPIEMEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x836C5D0", Offset = "0x836AFD0", VA = "0x18836C5D0")]
	public void HOGEJFHJFFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x836CD10", Offset = "0x836B710", VA = "0x18836CD10")]
	private void PKLMDBJKLEC(List<BAIDCCIMIMH> LJLLDLJDBAP, Stack<int> ICMIHNLOCDE, bool BFFJIEAHJMG, float AOLLKGKOJKM = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x836C040", Offset = "0x836AA40", VA = "0x18836C040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x836BD80", Offset = "0x836A780", VA = "0x18836BD80")]
	private void AHJEPABNFNC(List<BAIDCCIMIMH> LJLLDLJDBAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class JKFNDALIFOI : AIAKKMIHENH
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
	public void EHAMCOKDAMM(string EMLAIMJKHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
	public void DJNDBFANDGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public JKFNDALIFOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class GGKEPLGNODK : KJAAEGBGDMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour GCAIDLEJDBP;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string HFKDIDMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8371190", Offset = "0x836FB90", VA = "0x188371190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LNAJNJCEACL
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8371210", Offset = "0x836FC10", VA = "0x188371210", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool JBINHBCMJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8371260", Offset = "0x836FC60", VA = "0x188371260", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	public GGKEPLGNODK(Behaviour GCAIDLEJDBP)
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

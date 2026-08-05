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
public class IDFCDAGDOLL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority EOPFNCDKPCF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71F2BC0", Offset = "0x71F17C0", VA = "0x1871F2BC0")]
	public IDFCDAGDOLL(ThreadPriority DCIKJEJODHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71F2BB0", Offset = "0x71F17B0", VA = "0x1871F2BB0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> GLPHNMBBHPF(List<PlayerLoopSystem> DNMGEADFGHA, int IHLHEMBHOOL);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct ONMJPCPAOJM
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct DMKNCMCLLPK
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static DEHOLECDIJP BEHGOIBEOOL;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x71EE940", Offset = "0x71ED540", VA = "0x1871EE940")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct PIOPPCNIDMG
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static DEHOLECDIJP GGCMBBLLMEI;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x71FDE10", Offset = "0x71FCA10", VA = "0x1871FDE10")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct ENGFBIGCPAG
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static DEHOLECDIJP LMLAHFLLBIC;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x71EEEA0", Offset = "0x71EDAA0", VA = "0x1871EEEA0")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct KCNILDNPBMB
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static DEHOLECDIJP IFCNCKGBAGP;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static DEHOLECDIJP KHOIAGIJOPF;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static DEHOLECDIJP EKDKCHFHMKB;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static DEHOLECDIJP GDBDOKLJMFN;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x71F4A20", Offset = "0x71F3620", VA = "0x1871F4A20")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct HJEGLGBPACC
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static DEHOLECDIJP IPELDCBMNDC;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x71F23B0", Offset = "0x71F0FB0", VA = "0x1871F23B0")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct COMOKDLNBGC
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static DEHOLECDIJP IFCNCKGBAGP;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static DEHOLECDIJP KHOIAGIJOPF;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static DEHOLECDIJP EKDKCHFHMKB;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static DEHOLECDIJP GDBDOKLJMFN;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x71E8910", Offset = "0x71E7510", VA = "0x1871E8910")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct OABIALKCDIJ
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static DEHOLECDIJP KDJODMBHEFN;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x71FC630", Offset = "0x71FB230", VA = "0x1871FC630")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct HNMKCDLDIEP
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static DEHOLECDIJP GBCCBKKKLMO;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x71F29B0", Offset = "0x71F15B0", VA = "0x1871F29B0")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct PNAKGONPOHM
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static DEHOLECDIJP BOAOOOCDGGI;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x7200210", Offset = "0x71FEE10", VA = "0x187200210")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct HLFHADAINOM
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static DEHOLECDIJP FAOEGBLHLJH;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x71F27B0", Offset = "0x71F13B0", VA = "0x1871F27B0")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct CBNPCCDJDNH
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static DEHOLECDIJP AAMEKEBMLJP;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x71E7AE0", Offset = "0x71E66E0", VA = "0x1871E7AE0")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct POIBNLGKMIB
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static DEHOLECDIJP JCHJNLKGMFC;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x72004C0", Offset = "0x71FF0C0", VA = "0x1872004C0")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct GAPPJDLIDAM
			{
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public static DEHOLECDIJP EDPPGBFEMFF;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x71F1400", Offset = "0x71F0000", VA = "0x1871F1400")]
				public static PlayerLoopSystem GCJGDJCJKEF()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum JALHOFLNHBA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct AHIPLCLHPKG
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class HAODAAJIMJF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public JALHOFLNHBA updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
					public HAODAAJIMJF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x71F1600", Offset = "0x71F0200", VA = "0x1871F1600")]
					internal void LMDGNBMIAJB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public static JFCBGCCGGGE<JALHOFLNHBA> KDOHFOIPCGI;

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x71E50D0", Offset = "0x71E3CD0", VA = "0x1871E50D0")]
				public static PlayerLoopSystem GCJGDJCJKEF(JALHOFLNHBA HNOMBNBKCMO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct ANFFAJBDCNA
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class EAEEONOPCOP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public JEMIFIBAKNO.AFFANPCHMMN key;

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
					public EAEEONOPCOP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x71EEB40", Offset = "0x71ED740", VA = "0x1871EEB40")]
					internal void FBLENDKDBDA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public static IDisposable GDNNNPEEJCI;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x71E52D0", Offset = "0x71E3ED0", VA = "0x1871E52D0")]
				public static PlayerLoopSystem DIPMAPPPAPC(JEMIFIBAKNO.AFFANPCHMMN DPHIOKCFMFC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct PBILNCDNDDK
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class MJOALACFDKJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public JEMIFIBAKNO.AFFANPCHMMN key;

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
					public MJOALACFDKJ()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x71FB070", Offset = "0x71F9C70", VA = "0x1871FB070")]
					internal void FBLENDKDBDA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x71FD730", Offset = "0x71FC330", VA = "0x1871FD730")]
				public static PlayerLoopSystem DIPMAPPPAPC(JEMIFIBAKNO.AFFANPCHMMN DPHIOKCFMFC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class PGDNLPOJPOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public PGDNLPOJPOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x71FDBE0", Offset = "0x71FC7E0", VA = "0x1871FDBE0")]
			internal List<PlayerLoopSystem> KLEPOOBNLAB(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool IIFLGPCAMLA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool NOMGJKKNLCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x71E9150", Offset = "0x71E7D50", VA = "0x1871E9150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71E9190", Offset = "0x71E7D90", VA = "0x1871E9190")]
		private static void ICKHDPFKJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71EC080", Offset = "0x71EAC80", VA = "0x1871EC080")]
		private static void KECNPMLOBGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71E8F20", Offset = "0x71E7B20", VA = "0x1871E8F20")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71EBEC0", Offset = "0x71EAAC0", VA = "0x1871EBEC0")]
		private static void KCNOHMHPCOF(JEMIFIBAKNO.AFFANPCHMMN DPHIOKCFMFC, PlayerLoopSystem OJOEGICIMOA, Type ACPOIMLDGJN, Type PLHENKBOFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71EC990", Offset = "0x71EB590", VA = "0x1871EC990")]
		private static void MMNJOENHKPN(PlayerLoopSystem OJOEGICIMOA, Type ACPOIMLDGJN, Type PLHENKBOFNF, GLPHNMBBHPF NHKKOPGKNHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71EBD90", Offset = "0x71EA990", VA = "0x1871EBD90")]
		private static void JKOECEPBMBC(PlayerLoopSystem OJOEGICIMOA, Type ACPOIMLDGJN, Type PLHENKBOFNF, PlayerLoopSystem? EKMLGDICJKN, PlayerLoopSystem? HPMPHCFNIFA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class JEMIFIBAKNO
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum AFFANPCHMMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		OMPrePhysicsFixedUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KBBOFPHPHON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly AFFANPCHMMN LOOFNLAGHBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly CGIBLDGONFH MELEHFMNDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long NNAHABIKBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private long PJGCGBDHDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long DPMHABLPBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int IKIAICKLCHH;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x71F4830", Offset = "0x71F3430", VA = "0x1871F4830")]
		public KBBOFPHPHON(AFFANPCHMMN GEMAJCCLBMA, int GDCHJKFMPOE = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x71F4590", Offset = "0x71F3190", VA = "0x1871F4590")]
		public void AKOGDNAPMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x71F4600", Offset = "0x71F3200", VA = "0x1871F4600")]
		public void GELMBFCPHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x71F4650", Offset = "0x71F3250", VA = "0x1871F4650")]
		public void NBBEGPOOKFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static AFFANPCHMMN[] JMOFOKAAOMP;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static KBBOFPHPHON[] MPFDDJAOLOE;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x71F3A90", Offset = "0x71F2690", VA = "0x1871F3A90")]
	public static KBBOFPHPHON MIONABIKIPP(AFFANPCHMMN DPHIOKCFMFC, int GDCHJKFMPOE = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x71F3C70", Offset = "0x71F2870", VA = "0x1871F3C70")]
	public static KBBOFPHPHON MJDNIMKJNKI(AFFANPCHMMN DPHIOKCFMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x71F39F0", Offset = "0x71F25F0", VA = "0x1871F39F0")]
	public static void DCIBMBOBNLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CGIBLDGONFH : CACKJPOLNEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public int HIGELFIOLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Queue<double> NONFNADJHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double KFFFFOIIONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double EJBCANAPLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double DHJEAOHPDLE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double JKBGCHKOFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x71E7D50", Offset = "0x71E6950", VA = "0x1871E7D50", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double LMENCECHMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1A3DF40", Offset = "0x1A3CB40", VA = "0x181A3DF40", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double NJLJEAOCGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1F312D0", Offset = "0x1F2FED0", VA = "0x181F312D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x71E7ED0", Offset = "0x71E6AD0", VA = "0x1871E7ED0")]
	public CGIBLDGONFH(int DIFGFAKBBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x71E7DB0", Offset = "0x71E69B0", VA = "0x1871E7DB0", Slot = "7")]
	public void IPIKKKHBEIJ(double CLJFFIBMODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x71E7CE0", Offset = "0x71E68E0", VA = "0x1871E7CE0", Slot = "8")]
	public void CJMFGDFICPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class LJFLFDIPCFB : CACKJPOLNEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private long HDFABDCMCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double HDNDMOHNILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double KIAFCMBCGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double NPLAHAAIBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double HCDAEEMIKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double KFFFFOIIONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private double EJBCANAPLDC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double LMENCECHMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E950", Offset = "0x5E8D550", VA = "0x185E8E950", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double NJLJEAOCGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E8F0", Offset = "0x5E8D4F0", VA = "0x185E8E8F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double EMMCBECGBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E990", Offset = "0x5E8D590", VA = "0x185E8E990")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JKBGCHKOFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x251E480", Offset = "0x251D080", VA = "0x18251E480", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x71F76E0", Offset = "0x71F62E0", VA = "0x1871F76E0", Slot = "7")]
	public virtual void IPIKKKHBEIJ(double CLJFFIBMODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x71F76A0", Offset = "0x71F62A0", VA = "0x1871F76A0", Slot = "8")]
	public virtual void CJMFGDFICPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x71F7800", Offset = "0x71F6400", VA = "0x1871F7800")]
	public LJFLFDIPCFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PFPLPIOLOPF : LJFLFDIPCFB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double HNGFLLBFMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E970", Offset = "0x5E8D570", VA = "0x185E8E970")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E9A0", Offset = "0x5E8D5A0", VA = "0x185E8E9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x71FDAB0", Offset = "0x71FC6B0", VA = "0x1871FDAB0", Slot = "7")]
	public override void IPIKKKHBEIJ(double CLJFFIBMODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x71FDA70", Offset = "0x71FC670", VA = "0x1871FDA70", Slot = "8")]
	public override void CJMFGDFICPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x71F7800", Offset = "0x71F6400", VA = "0x1871F7800")]
	public PFPLPIOLOPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface CACKJPOLNEF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double JKBGCHKOFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double LMENCECHMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double NJLJEAOCGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PKLGLMILLCI
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface CMEMMHNGDME
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool OPONDNCOPBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IKNIENNEJLD();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private abstract class JPDKBCKNINC<TPromise, TMainThreadPromise> : CMEMMHNGDME where TPromise : CEIMLGOLMNM where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly TPromise OOADHFPGGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly TMainThreadPromise OBHCDAGGDGP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise DHBMEJIMJHL
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x4078D30", Offset = "0x4077930", VA = "0x184078D30")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OPONDNCOPBM
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x4078D90", Offset = "0x4077990", VA = "0x184078D90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8503D0", Offset = "0x84EFD0", VA = "0x1808503D0")]
		protected JPDKBCKNINC(TPromise OOADHFPGGJI, TMainThreadPromise BPKMNDCIENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4078DE0", Offset = "0x40779E0", VA = "0x184078DE0", Slot = "5")]
		public void IKNIENNEJLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void FBAOFHMBJLH(TPromise OOADHFPGGJI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class MLFAAGKFIPH<T> : JPDKBCKNINC<NDHCMKMDIDG<T>, OJPAJLKHODG<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4411460", Offset = "0x4410060", VA = "0x184411460")]
		public MLFAAGKFIPH(NDHCMKMDIDG<T> OOADHFPGGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4411240", Offset = "0x440FE40", VA = "0x184411240", Slot = "6")]
		protected override void FBAOFHMBJLH(NDHCMKMDIDG<T> OOADHFPGGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x37E3CE0", Offset = "0x37E28E0", VA = "0x1837E3CE0")]
		[CompilerGenerated]
		private void LPEOMHCHPOG(T JFBAIGMLPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x44111F0", Offset = "0x440FDF0", VA = "0x1844111F0")]
		[CompilerGenerated]
		private void BPHLDIAIDJD(string MCOFJPDPPAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class FAFCABJNHGM : CMEMMHNGDME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Action FIPNCHEIGMJ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OPONDNCOPBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
		public FAFCABJNHGM(Action FIPNCHEIGMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9168D0", Offset = "0x9154D0", VA = "0x1809168D0", Slot = "5")]
		public void IKNIENNEJLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly List<CMEMMHNGDME> EHNDCJOAEEN;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE620", Offset = "0x2CED220", VA = "0x182CEE620")]
	public static NDHCMKMDIDG<T> GOOGGHOMFCB<T>(this NDHCMKMDIDG<T> OOADHFPGGJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x71FFE00", Offset = "0x71FEA00", VA = "0x1871FFE00")]
	public static void GOOGGHOMFCB(Action FIPNCHEIGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE6A0", Offset = "0x2CED2A0", VA = "0x182CEE6A0")]
	private static NDHCMKMDIDG<T> LJBOCABJDJD<T>(NDHCMKMDIDG<T> OOADHFPGGJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x71FFA10", Offset = "0x71FE610", VA = "0x1871FFA10")]
	private static void AOLGEJMPDKP(CMEMMHNGDME LGDAJNKKCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x71FFEA0", Offset = "0x71FEAA0", VA = "0x1871FFEA0")]
	private static void IBJMENJLIGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x71FFD00", Offset = "0x71FE900", VA = "0x1871FFD00")]
	private static void GJDPGAJIEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x71FFC20", Offset = "0x71FE820", VA = "0x1871FFC20")]
	private static void FBKHPMBAFJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class PJKIJBPMAIB
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct OLAJLBKLCKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TaskCompletionSource<Scene> ANEDJODEHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly string MFFICODDPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly LoadSceneMode CLKCOKFKGMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool OOEMFHLLBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x71FD0D0", Offset = "0x71FBCD0", VA = "0x1871FD0D0")]
		public OLAJLBKLCKK(TaskCompletionSource<Scene> LDHFNFOBHGO, string MFFICODDPIK, LoadSceneMode CLKCOKFKGMJ, bool OOEMFHLLBED, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct CILLKNBJCEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private GDCBCFBEPNI<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x71E8000", Offset = "0x71E6C00", VA = "0x1871E8000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x71E88A0", Offset = "0x71E74A0", VA = "0x1871E88A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct JLMAOEFFKIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x71F41B0", Offset = "0x71F2DB0", VA = "0x1871F41B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x71F44D0", Offset = "0x71F30D0", VA = "0x1871F44D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FLAMPDGOGGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private OLAJLBKLCKK <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x71F06A0", Offset = "0x71EF2A0", VA = "0x1871F06A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x71F0A50", Offset = "0x71EF650", VA = "0x1871F0A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class JPPJJIDNHIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public OJPAJLKHODG<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JPPJJIDNHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x71F4530", Offset = "0x71F3130", VA = "0x1871F4530")]
		internal void ODDKEIEAABO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct FEHKCDLDEPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private JPPJJIDNHIL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x71EF0A0", Offset = "0x71EDCA0", VA = "0x1871EF0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x71EFC40", Offset = "0x71EE840", VA = "0x1871EFC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct KFFMAGMAOOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x71F5270", Offset = "0x71F3E70", VA = "0x1871F5270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x71F5740", Offset = "0x71F4340", VA = "0x1871F5740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct IKGGFCGEHMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x71F2C00", Offset = "0x71F1800", VA = "0x1871F2C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x71F3750", Offset = "0x71F2350", VA = "0x1871F3750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NEIAENHJDKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NEIAENHJDKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x71FB370", Offset = "0x71F9F70", VA = "0x1871FB370")]
		internal bool LMMAFPFGGPH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class BGKPEEIKOMC : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public POMDOHCOGFA onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public BGKPEEIKOMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x71E7380", Offset = "0x71E5F80", VA = "0x1871E7380", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x71E6FF0", Offset = "0x71E5BF0", VA = "0x1871E6FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x71E6FA0", Offset = "0x71E5BA0", VA = "0x1871E6FA0")]
		private void FMFBFJNMNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x71E7330", Offset = "0x71E5F30", VA = "0x1871E7330", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class MBJMBMCDMLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public OJPAJLKHODG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MBJMBMCDMLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x71F7ED0", Offset = "0x71F6AD0", VA = "0x1871F7ED0")]
		internal bool LICIIGGJAAA(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x71F7C50", Offset = "0x71F6850", VA = "0x1871F7C50")]
		internal void BCEFBBKHGIJ(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class BNPGGCDAIEA : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public OJPAJLKHODG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private MBJMBMCDMLN <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public BNPGGCDAIEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x71E7410", Offset = "0x71E6010", VA = "0x1871E7410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x71E7A90", Offset = "0x71E6690", VA = "0x1871E7A90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly ICollection<string> JHAGPLLINKM;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static CEIMLGOLMNM KLGOALIAECM;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static AsyncOperation DLIDJFEAPLD;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static CEIMLGOLMNM NHIHKJBKEEN;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static string KNKHFDMDCMB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static ThreadPriority ALFLGIGKKPD;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task IBOMNGPGDLL;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static List<SceneInstance> GJHCNDDLLMD;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly Queue<OLAJLBKLCKK> PFADJONLIJB;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static Task JFPGMJOPDMB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool OKJJDMJONAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x71FF510", Offset = "0x71FE110", VA = "0x1871FF510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool GKBGMNJLBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x71FED80", Offset = "0x71FD980", VA = "0x1871FED80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool CPIHPABLLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x71FEB30", Offset = "0x71FD730", VA = "0x1871FEB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool GIGKCMHAMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x71FEA00", Offset = "0x71FD600", VA = "0x1871FEA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> CADPGAEJCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x71FE490", Offset = "0x71FD090", VA = "0x1871FE490")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x71FE5A0", Offset = "0x71FD1A0", VA = "0x1871FE5A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x71FEBD0", Offset = "0x71FD7D0", VA = "0x1871FEBD0")]
	[LOAPKAJPCGD(OBAOEJFCFBL.EnteredEditModeNextFrame, 0)]
	private static void IGICDAGPFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x71FE2B0", Offset = "0x71FCEB0", VA = "0x1871FE2B0")]
	[AsyncStateMachine(typeof(CILLKNBJCEM))]
	public static Task<Scene> DAENLAIKMLG(string MFFICODDPIK, LoadSceneMode CLKCOKFKGMJ = LoadSceneMode.Single, bool OOEMFHLLBED = false, [Optional] GDCBCFBEPNI<string>.LHHFCPKIPMG FLDMEAHKKOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x71FECD0", Offset = "0x71FD8D0", VA = "0x1871FECD0")]
	[AsyncStateMachine(typeof(JLMAOEFFKIB))]
	private static Task IHNAAHBKFIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x71FEE20", Offset = "0x71FDA20", VA = "0x1871FEE20")]
	[AsyncStateMachine(typeof(FLAMPDGOGGJ))]
	private static Task MBIHABJEGGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x71FF0F0", Offset = "0x71FDCF0", VA = "0x1871FF0F0")]
	[AsyncStateMachine(typeof(FEHKCDLDEPC))]
	private static Task<Scene> NKCGLAKJNMK(string MFFICODDPIK, LoadSceneMode CLKCOKFKGMJ, bool OOEMFHLLBED, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x71FE7C0", Offset = "0x71FD3C0", VA = "0x1871FE7C0")]
	private static void FJNELOPPJHA(SceneInstance HFEGKIPECIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x71FEEF0", Offset = "0x71FDAF0", VA = "0x1871FEEF0")]
	private static void NFGAPDEAOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x71FE010", Offset = "0x71FCC10", VA = "0x1871FE010")]
	[AsyncStateMachine(typeof(KFFMAGMAOOK))]
	private static Task<Scene> ANDJDDBHAPO(string MFFICODDPIK, LoadSceneMode CLKCOKFKGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x71FF730", Offset = "0x71FE330", VA = "0x1871FF730")]
	private static bool PLMBONAHBPC(string MFFICODDPIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x71FE6B0", Offset = "0x71FD2B0", VA = "0x1871FE6B0")]
	[AsyncStateMachine(typeof(IKGGFCGEHMF))]
	private static Task<Scene> FFBDKPBHEJM(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x71FE130", Offset = "0x71FCD30", VA = "0x1871FE130")]
	public static NDHCMKMDIDG<Scene> CFFNOHIGKED(string MFFICODDPIK, LoadSceneMode CLKCOKFKGMJ = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x71FF240", Offset = "0x71FDE40", VA = "0x1871FF240")]
	public static CEIMLGOLMNM NOBBIAOINCC(string MFFICODDPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x71FE400", Offset = "0x71FD000", VA = "0x1871FE400")]
	[IteratorStateMachine(typeof(BGKPEEIKOMC))]
	private static IEnumerator<OGKGDFEHPGC> EKAMMJGGCCO(string MFFICODDPIK, POMDOHCOGFA LPMOMEGOPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x71FEA90", Offset = "0x71FD690", VA = "0x1871FEA90")]
	[IteratorStateMachine(typeof(BNPGGCDAIEA))]
	private static IEnumerator<OGKGDFEHPGC> GNHEPHNHCHP(string MFFICODDPIK, LoadSceneMode CLKCOKFKGMJ, OJPAJLKHODG<Scene> LPMOMEGOPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x71FE8D0", Offset = "0x71FD4D0", VA = "0x1871FE8D0")]
	public static bool FMIIKPPHGGA([Out] string HPJNKCKJBBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PDDIDDMLHIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x71FD960", Offset = "0x71FC560", VA = "0x1871FD960")]
	public static IDisposable PMKIJIEHHJB(this OCPFCAEFKCD FBMKGECLCCA, float NFHLEJBCIPG, Action<float> PMDLNGNKGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x71FD8E0", Offset = "0x71FC4E0", VA = "0x1871FD8E0")]
	public static IDisposable KNGJMPNMJFF(this OCPFCAEFKCD FBMKGECLCCA, Action<float> PMDLNGNKGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x71FD860", Offset = "0x71FC460", VA = "0x1871FD860")]
	public static IDisposable AMGJFKIBOLK(this OCPFCAEFKCD FBMKGECLCCA, Action<float> PMDLNGNKGFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class KHDIOMMNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x71F6080", Offset = "0x71F4C80", VA = "0x1871F6080")]
	public static IDisposable KNMMAGGCFLB(this MonoBehaviour BJENICCNMGM, Action PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x71F5FF0", Offset = "0x71F4BF0", VA = "0x1871F5FF0")]
	public static IDisposable KNMMAGGCFLB(this MonoBehaviour BJENICCNMGM, Action<float> PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x71F6420", Offset = "0x71F5020", VA = "0x1871F6420")]
	public static IDisposable NBJEMGDMOCC(this MonoBehaviour BJENICCNMGM, Action PMDLNGNKGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x71F5ED0", Offset = "0x71F4AD0", VA = "0x1871F5ED0")]
	public static IDisposable HHCIDMMBLDI(this MonoBehaviour BJENICCNMGM, Action PMDLNGNKGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x71F5E50", Offset = "0x71F4A50", VA = "0x1871F5E50")]
	public static IDisposable HHCIDMMBLDI(this MonoBehaviour BJENICCNMGM, Action<float> PMDLNGNKGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x71F5B60", Offset = "0x71F4760", VA = "0x1871F5B60")]
	public static IDisposable AABHPGHHMKJ(this MonoBehaviour BJENICCNMGM, Action PMDLNGNKGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x71F6300", Offset = "0x71F4F00", VA = "0x1871F6300")]
	public static IDisposable MIFEHKPIABH(this MonoBehaviour BJENICCNMGM, Action PMDLNGNKGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x71F5C90", Offset = "0x71F4890", VA = "0x1871F5C90")]
	public static IDisposable CAINMFLGLBA(this MonoBehaviour BJENICCNMGM, Action PMDLNGNKGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x71F5BE0", Offset = "0x71F47E0", VA = "0x1871F5BE0")]
	public static IDisposable AFIPPPEDPFC(this MonoBehaviour BJENICCNMGM, float NFHLEJBCIPG, Action<float> PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN, bool JFBKCJIAIFD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x71F65E0", Offset = "0x71F51E0", VA = "0x1871F65E0")]
	public static IDisposable PFJNKFFEGNJ(this MonoBehaviour BJENICCNMGM, float NFHLEJBCIPG, Action<float> PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN, bool JFBKCJIAIFD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x71F6260", Offset = "0x71F4E60", VA = "0x1871F6260")]
	public static IDisposable MECEKEFJCBC(this MonoBehaviour BJENICCNMGM, float NFHLEJBCIPG, Action<float> PMDLNGNKGFD, bool JFBKCJIAIFD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x71F5D10", Offset = "0x71F4910", VA = "0x1871F5D10")]
	public static IDisposable DIEKOHJKMOK(this MonoBehaviour BJENICCNMGM, Action<float> PMDLNGNKGFD, bool JFBKCJIAIFD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x71F5F50", Offset = "0x71F4B50", VA = "0x1871F5F50")]
	public static IDisposable IJFDLDCEJGA(this MonoBehaviour BJENICCNMGM, Action<float> PMDLNGNKGFD, bool JFBKCJIAIFD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x71F64A0", Offset = "0x71F50A0", VA = "0x1871F64A0")]
	public static IDisposable OGHFJJIDNNG(this MonoBehaviour BJENICCNMGM, Action<float> PMDLNGNKGFD, bool JFBKCJIAIFD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x71F6380", Offset = "0x71F4F80", VA = "0x1871F6380")]
	public static IDisposable MMPDBDOONNL(this MonoBehaviour BJENICCNMGM, Action<float> PMDLNGNKGFD, bool JFBKCJIAIFD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x71F61C0", Offset = "0x71F4DC0", VA = "0x1871F61C0")]
	public static IDisposable LHHMJKEJHAP(this MonoBehaviour BJENICCNMGM, Action<float> PMDLNGNKGFD, bool JFBKCJIAIFD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x71F6540", Offset = "0x71F5140", VA = "0x1871F6540")]
	public static IDisposable OJEIHDDAGNL(this MonoBehaviour BJENICCNMGM, Action<float> PMDLNGNKGFD, bool JFBKCJIAIFD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x71F5DB0", Offset = "0x71F49B0", VA = "0x1871F5DB0")]
	public static IDisposable FOAGJPFANCN(this MonoBehaviour BJENICCNMGM, Action<float> PMDLNGNKGFD, bool JFBKCJIAIFD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x71F6110", Offset = "0x71F4D10", VA = "0x1871F6110")]
	public static IDisposable LCPMCLAKANK(this MonoBehaviour BJENICCNMGM, float NFHLEJBCIPG, Action<float> PMDLNGNKGFD, bool JFBKCJIAIFD = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class KGKBHONOEBO
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class OLHKOKAEIMH : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public HEAFJPMMKLL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private CGNAPGEHEAF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public OLHKOKAEIMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x71FD130", Offset = "0x71FBD30", VA = "0x1871FD130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x71FD210", Offset = "0x71FBE10", VA = "0x1871FD210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class JFMDCMADLEH : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public HEAFJPMMKLL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private CGNAPGEHEAF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public JFMDCMADLEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x71F3E80", Offset = "0x71F2A80", VA = "0x1871F3E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x71F3F70", Offset = "0x71F2B70", VA = "0x1871F3F70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x71F58D0", Offset = "0x71F44D0", VA = "0x1871F58D0")]
	public static GNHKJFLENJL KNMMAGGCFLB(Action PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x71F5980", Offset = "0x71F4580", VA = "0x1871F5980")]
	public static GNHKJFLENJL KNMMAGGCFLB(Behaviour FBMKGECLCCA, Action PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x71F57B0", Offset = "0x71F43B0", VA = "0x1871F57B0")]
	public static GNHKJFLENJL KNMMAGGCFLB(Behaviour FBMKGECLCCA, Action<float> PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x71F5A40", Offset = "0x71F4640", VA = "0x1871F5A40")]
	[IteratorStateMachine(typeof(OLHKOKAEIMH))]
	private static IEnumerator<OGKGDFEHPGC> OOGGEPHBCBE(HEAFJPMMKLL IANEMNKPNHN, Action PMDLNGNKGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x71F5AD0", Offset = "0x71F46D0", VA = "0x1871F5AD0")]
	[IteratorStateMachine(typeof(JFMDCMADLEH))]
	private static IEnumerator<OGKGDFEHPGC> OOGGEPHBCBE(HEAFJPMMKLL IANEMNKPNHN, Action<float> PMDLNGNKGFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class ILLHBIGBBKL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class JLKIGMHJOMF : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public ILLHBIGBBKL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public JLKIGMHJOMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x71F40D0", Offset = "0x71F2CD0", VA = "0x1871F40D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x71F4160", Offset = "0x71F2D60", VA = "0x1871F4160", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly HEAFJPMMKLL FHHHOJNINLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Action ECKDNCFLPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool NPHILGIKKKO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BGOANOOCCPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x843300", Offset = "0x841F00", VA = "0x180843300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x71F38E0", Offset = "0x71F24E0", VA = "0x1871F38E0")]
	public ILLHBIGBBKL(HEAFJPMMKLL FHHHOJNINLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x71F37C0", Offset = "0x71F23C0", VA = "0x1871F37C0")]
	[IteratorStateMachine(typeof(JLKIGMHJOMF))]
	private IEnumerator<OGKGDFEHPGC> ENFPMJKBONC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x71F3840", Offset = "0x71F2440", VA = "0x1871F3840", Slot = "4")]
	public void OnCompleted(Action MAMLMCINILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	public void KBBIGJGAGKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class HKLCPGOCGDE
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x71F2670", Offset = "0x71F1270", VA = "0x1871F2670")]
	public static ILLHBIGBBKL EADJJONFAJP(this HEAFJPMMKLL FHHHOJNINLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class KHHPCJBNKFE
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class HBLPNHOGCLN : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FKGIOJKLPEK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public HBLPNHOGCLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x71F22E0", Offset = "0x71F0EE0", VA = "0x1871F22E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x71F2360", Offset = "0x71F0F60", VA = "0x1871F2360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x71F6910", Offset = "0x71F5510", VA = "0x1871F6910")]
	public static GNHKJFLENJL KNMMAGGCFLB(float NFHLEJBCIPG, Action<float> PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN, bool JFBKCJIAIFD = true, [Optional] FCOOAPKDPMG CKOLOLELOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x71F6A10", Offset = "0x71F5610", VA = "0x1871F6A10")]
	public static GNHKJFLENJL KNMMAGGCFLB(MonoBehaviour BJENICCNMGM, float NFHLEJBCIPG, Action<float> PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN, bool JFBKCJIAIFD = true, [Optional] FCOOAPKDPMG CKOLOLELOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x71F67F0", Offset = "0x71F53F0", VA = "0x1871F67F0")]
	public static GNHKJFLENJL KCGDKOBHLCP(MonoBehaviour BJENICCNMGM, float NFHLEJBCIPG, Action<float> PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN, bool JFBKCJIAIFD = true, [Optional] FCOOAPKDPMG CKOLOLELOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x71F6B20", Offset = "0x71F5720", VA = "0x1871F6B20")]
	public static GNHKJFLENJL MMGKGKHEHLG(OCPFCAEFKCD FBMKGECLCCA, float NFHLEJBCIPG, Action<float> PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN, bool JFBKCJIAIFD = true, [Optional] FCOOAPKDPMG CKOLOLELOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x71F6C30", Offset = "0x71F5830", VA = "0x1871F6C30")]
	private static IEnumerator<OGKGDFEHPGC> OOGGEPHBCBE(MAJNKLKGKDE HGINDGMJBMH, float NFHLEJBCIPG, HEAFJPMMKLL IANEMNKPNHN, Action<float> PMDLNGNKGFD, bool JFBKCJIAIFD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x71F6790", Offset = "0x71F5390", VA = "0x1871F6790")]
	private static IEnumerator<OGKGDFEHPGC> HFNLIKPFHFC(MAJNKLKGKDE HGINDGMJBMH, float NFHLEJBCIPG, HEAFJPMMKLL IANEMNKPNHN, Action<float> PMDLNGNKGFD, bool JFBKCJIAIFD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x71F6700", Offset = "0x71F5300", VA = "0x1871F6700")]
	[IteratorStateMachine(typeof(HBLPNHOGCLN))]
	private static IEnumerator<OGKGDFEHPGC> FJMAGOBBAKC(FKGIOJKLPEK LODBMLDAFDI, float NFHLEJBCIPG, HEAFJPMMKLL IANEMNKPNHN, Action<float> PMDLNGNKGFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class KMBGBFCOMOP
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class JKCPDOHDFPG : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public HEAFJPMMKLL queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public JKCPDOHDFPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x71F3FC0", Offset = "0x71F2BC0", VA = "0x1871F3FC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x71F4080", Offset = "0x71F2C80", VA = "0x1871F4080", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x71F6E10", Offset = "0x71F5A10", VA = "0x1871F6E10")]
	[IteratorStateMachine(typeof(JKCPDOHDFPG))]
	private static IEnumerator<OGKGDFEHPGC> LANHDOLMIEI(HEAFJPMMKLL FHHHOJNINLN, Func<bool> OINKDIMBFCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x71F6CF0", Offset = "0x71F58F0", VA = "0x1871F6CF0")]
	public static GNHKJFLENJL AHCHOFHFNOP(this MonoBehaviour BJENICCNMGM, Func<bool> OINKDIMBFCD, HEAFJPMMKLL FHHHOJNINLN = HEAFJPMMKLL.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FIOGLFPGFOB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class HJNGMHKPIOD : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public HEAFJPMMKLL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public HJNGMHKPIOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x71F25B0", Offset = "0x71F11B0", VA = "0x1871F25B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x71F2620", Offset = "0x71F1220", VA = "0x1871F2620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class KCJFLANADOB : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public HEAFJPMMKLL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private OGKGDFEHPGC <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public KCJFLANADOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x71F4940", Offset = "0x71F3540", VA = "0x1871F4940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x71F49D0", Offset = "0x71F35D0", VA = "0x1871F49D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x71F0170", Offset = "0x71EED70", VA = "0x1871F0170")]
	[IteratorStateMachine(typeof(HJNGMHKPIOD))]
	private static IEnumerator<OGKGDFEHPGC> ENFPMJKBONC(float EACMJFLDLDP, HEAFJPMMKLL IANEMNKPNHN, Action DFEAGIPALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x71F0370", Offset = "0x71EEF70", VA = "0x1871F0370")]
	[IteratorStateMachine(typeof(KCJFLANADOB))]
	private static IEnumerator<OGKGDFEHPGC> LKDNELEMHDA(float EACMJFLDLDP, HEAFJPMMKLL IANEMNKPNHN, Action DFEAGIPALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x71EFCB0", Offset = "0x71EE8B0", VA = "0x1871EFCB0")]
	public static IDisposable AAOAHJOBHDN(this MonoBehaviour BJENICCNMGM, float EACMJFLDLDP, Action DFEAGIPALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x71F04E0", Offset = "0x71EF0E0", VA = "0x1871F04E0")]
	public static GNHKJFLENJL NHJMFAOOJKD(this MonoBehaviour BJENICCNMGM, float EACMJFLDLDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x71EFDD0", Offset = "0x71EE9D0", VA = "0x1871EFDD0")]
	public static GNHKJFLENJL AAOAHJOBHDN(this MonoBehaviour BJENICCNMGM, float EACMJFLDLDP, HEAFJPMMKLL IANEMNKPNHN, Action DFEAGIPALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x71F0210", Offset = "0x71EEE10", VA = "0x1871F0210")]
	public static GNHKJFLENJL GCJGCDANJCJ(this MonoBehaviour BJENICCNMGM, Action DFEAGIPALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x71F0340", Offset = "0x71EEF40", VA = "0x1871F0340")]
	public static GNHKJFLENJL IODCMFDLBAD(this MonoBehaviour BJENICCNMGM, Action DFEAGIPALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x71F0230", Offset = "0x71EEE30", VA = "0x1871F0230")]
	public static GNHKJFLENJL HONIAMFGCIN(this MonoBehaviour BJENICCNMGM, Action DFEAGIPALPH, [Optional] FCOOAPKDPMG CKOLOLELOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x71F0310", Offset = "0x71EEF10", VA = "0x1871F0310")]
	public static GNHKJFLENJL ICAADDHPOHD(this MonoBehaviour BJENICCNMGM, Action DFEAGIPALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x71F0670", Offset = "0x71EF270", VA = "0x1871F0670")]
	public static GNHKJFLENJL PIDIIFMOFMA(this MonoBehaviour BJENICCNMGM, Action DFEAGIPALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x71F05A0", Offset = "0x71EF1A0", VA = "0x1871F05A0")]
	private static GNHKJFLENJL OGCJCGFKGNL(MonoBehaviour BJENICCNMGM, HEAFJPMMKLL FHHHOJNINLN, Action DFEAGIPALPH, [Optional] FCOOAPKDPMG CKOLOLELOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x71EFFD0", Offset = "0x71EEBD0", VA = "0x1871EFFD0")]
	public static GNHKJFLENJL CLFOLMJFIFH(this MonoBehaviour BJENICCNMGM, float PLKKFMMIDIL, Action DFEAGIPALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x71F00A0", Offset = "0x71EECA0", VA = "0x1871F00A0")]
	public static GNHKJFLENJL DNMIBKIJFJH(this MonoBehaviour BJENICCNMGM, float PLKKFMMIDIL, Action DFEAGIPALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x71F0410", Offset = "0x71EF010", VA = "0x1871F0410")]
	public static GNHKJFLENJL NFBGLJMEAPM(this MonoBehaviour BJENICCNMGM, float PLKKFMMIDIL, Action DFEAGIPALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x71EFF00", Offset = "0x71EEB00", VA = "0x1871EFF00")]
	public static GNHKJFLENJL CJIJNPGFIGC(this MonoBehaviour BJENICCNMGM, float PLKKFMMIDIL, Action DFEAGIPALPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FLGKBMJHGAG : FNBOCDDJGML, IEnumerable<FNBOCDDJGML>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly List<FNBOCDDJGML> PIPGDOFEDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool MOKAIGLPKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Action GMGAKLMHABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool JCEBJFHIGKD;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LOLIGEIPHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x71F0B50", Offset = "0x71EF750", VA = "0x1871F0B50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PDFFFOLLGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x71F0FA0", Offset = "0x71EFBA0", VA = "0x1871F0FA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x71F0AB0", Offset = "0x71EF6B0", VA = "0x1871F0AB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x71F1360", Offset = "0x71EFF60", VA = "0x1871F1360")]
	public FLGKBMJHGAG([Optional] Action GMGAKLMHABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x71F0E70", Offset = "0x71EFA70", VA = "0x1871F0E70")]
	public void MPFJKDGCCNN(FNBOCDDJGML JKPCOAAOEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x71F0D10", Offset = "0x71EF910", VA = "0x1871F0D10")]
	private void JJMLGABOHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x71F1350", Offset = "0x71EFF50", VA = "0x1871F1350", Slot = "7")]
	public bool PDLNNOGPGGL(bool NDHMLIPBMEM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x71F1040", Offset = "0x71EFC40", VA = "0x1871F1040", Slot = "8")]
	public bool PDLNNOGPGGL(Action FIPNCHEIGMJ, bool NDHMLIPBMEM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x71F0C90", Offset = "0x71EF890", VA = "0x1871F0C90", Slot = "9")]
	public IEnumerator<FNBOCDDJGML> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x71F0C90", Offset = "0x71EF890", VA = "0x1871F0C90", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class CPNHNIPNINL : DJCAOEJNMPI
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class AIJAMFOPOMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CPNHNIPNINL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public AIJAMFOPOMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x71E52A0", Offset = "0x71E3EA0", VA = "0x1871E52A0")]
		internal void INJJNCMEMFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class EIABBKLMCCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public CPNHNIPNINL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EIABBKLMCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x71E52A0", Offset = "0x71E3EA0", VA = "0x1871E52A0")]
		internal void MKNOPGAGOFK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly float FFIBDCJIJFN;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x71E8E20", Offset = "0x71E7A20", VA = "0x1871E8E20")]
	public CPNHNIPNINL(Behaviour FBMKGECLCCA, float FFIBDCJIJFN, [Optional] Action GMGAKLMHABH, [Optional] FCOOAPKDPMG CKOLOLELOJG, [Optional] MAJNKLKGKDE HGINDGMJBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x71E8C00", Offset = "0x71E7800", VA = "0x1871E8C00", Slot = "9")]
	protected override bool CHCOHDPDDFG(Action FIPNCHEIGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x71E8D10", Offset = "0x71E7910", VA = "0x1871E8D10", Slot = "10")]
	protected override bool CMOFJEDIAOK(Action FIPNCHEIGMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface FNBOCDDJGML
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool LOLIGEIPHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PDFFFOLLGMN;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PDLNNOGPGGL(bool NDHMLIPBMEM = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PDLNNOGPGGL(Action FIPNCHEIGMJ, bool NDHMLIPBMEM = false);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class DJCAOEJNMPI : FNBOCDDJGML
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class ELAKHJHGOKC : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public DJCAOEJNMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public ELAKHJHGOKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x71EED80", Offset = "0x71ED980", VA = "0x1871EED80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x71EEE50", Offset = "0x71EDA50", VA = "0x1871EEE50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Behaviour FBMKGECLCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action GMGAKLMHABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private LKPPGGKMHON HILDINJFDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly FCOOAPKDPMG CKOLOLELOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	protected readonly MAJNKLKGKDE HGINDGMJBMH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LOLIGEIPHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1107430", Offset = "0x1106030", VA = "0x181107430", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action PDFFFOLLGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x71EE6E0", Offset = "0x71ED2E0", VA = "0x1871EE6E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x71EE290", Offset = "0x71ECE90", VA = "0x1871EE290", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x71EE840", Offset = "0x71ED440", VA = "0x1871EE840")]
	protected DJCAOEJNMPI(Behaviour FBMKGECLCCA, [Optional] Action GMGAKLMHABH, [Optional] FCOOAPKDPMG CKOLOLELOJG, [Optional] MAJNKLKGKDE HGINDGMJBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x71EE7E0", Offset = "0x71ED3E0", VA = "0x1871EE7E0", Slot = "7")]
	public bool PDLNNOGPGGL(bool NDHMLIPBMEM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x71EE780", Offset = "0x71ED380", VA = "0x1871EE780", Slot = "8")]
	public bool PDLNNOGPGGL(Action FIPNCHEIGMJ, bool NDHMLIPBMEM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool CHCOHDPDDFG(Action FIPNCHEIGMJ);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool CMOFJEDIAOK(Action FIPNCHEIGMJ);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x71EE5F0", Offset = "0x71ED1F0", VA = "0x1871EE5F0")]
	protected void JOFHIIOEABE(Action FIPNCHEIGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x71EE330", Offset = "0x71ECF30", VA = "0x1871EE330")]
	protected CEIMLGOLMNM GCJGIIBAFCM(float HOHIHOOEIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x71EE570", Offset = "0x71ED170", VA = "0x1871EE570")]
	private void GLLOPOBKLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x71EE610", Offset = "0x71ED210", VA = "0x1871EE610")]
	[IteratorStateMachine(typeof(ELAKHJHGOKC))]
	private IEnumerator<OGKGDFEHPGC> MKNKGBGHCED(float HOHIHOOEIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x71EE6A0", Offset = "0x71ED2A0", VA = "0x1871EE6A0")]
	[CompilerGenerated]
	private void MOLEENCOKCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class LJODACHNGLL : DJCAOEJNMPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float OANEDNJGENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly int ENKIABPOOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float LNGPONJIDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly float[] BKNDHBJPCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int OHMLOGJKBCE;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x71F7AB0", Offset = "0x71F66B0", VA = "0x1871F7AB0")]
	public LJODACHNGLL(Behaviour FBMKGECLCCA, float PGGFFONHHGB, int ENKIABPOOPF, [Optional] Action GMGAKLMHABH, float LNGPONJIDFI = 0f, [Optional] FCOOAPKDPMG CKOLOLELOJG, [Optional] MAJNKLKGKDE HGINDGMJBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "9")]
	protected override bool CHCOHDPDDFG(Action FIPNCHEIGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x71F7830", Offset = "0x71F6430", VA = "0x1871F7830", Slot = "10")]
	protected override bool CMOFJEDIAOK(Action FIPNCHEIGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x71F7A30", Offset = "0x71F6630", VA = "0x1871F7A30")]
	private void PNJAAMKEGHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class LIAKBELAOHB : DJCAOEJNMPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly float FFIBDCJIJFN;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x71E8E20", Offset = "0x71E7A20", VA = "0x1871E8E20")]
	public LIAKBELAOHB(Behaviour FBMKGECLCCA, float FFIBDCJIJFN, [Optional] Action GMGAKLMHABH, [Optional] FCOOAPKDPMG CKOLOLELOJG, [Optional] MAJNKLKGKDE HGINDGMJBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "9")]
	protected override bool CHCOHDPDDFG(Action FIPNCHEIGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x71F6EA0", Offset = "0x71F5AA0", VA = "0x1871F6EA0", Slot = "10")]
	protected override bool CMOFJEDIAOK(Action FIPNCHEIGMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class MGGLBJAAMKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class MPHMHCDGJBB : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public MPHMHCDGJBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x71E6EE0", Offset = "0x71E5AE0", VA = "0x1871E6EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x71FB320", Offset = "0x71F9F20", VA = "0x1871FB320", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private GNHKJFLENJL GNIEFEAJNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private OCPFCAEFKCD FBMKGECLCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Action<float> LBEKAKJGCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private HEAFJPMMKLL FHHHOJNINLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float OLALPHFFNKP;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x71FAE90", Offset = "0x71F9A90", VA = "0x1871FAE90")]
	public MGGLBJAAMKL(OCPFCAEFKCD FBMKGECLCCA, float NFHLEJBCIPG, Action<float> PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x71FACF0", Offset = "0x71F98F0", VA = "0x1871FACF0")]
	private void PGAEBHPLEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x71FA900", Offset = "0x71F9500", VA = "0x1871FA900")]
	private void AHFKLEDNBBG(string MCOFJPDPPAJ, Action BHIBGAAPACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x71FAC10", Offset = "0x71F9810", VA = "0x1871FAC10")]
	[IteratorStateMachine(typeof(MPHMHCDGJBB))]
	private IEnumerator<OGKGDFEHPGC> CMBHCLNOKNL(Action BHIBGAAPACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x71FAC90", Offset = "0x71F9890", VA = "0x1871FAC90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x71FAA60", Offset = "0x71F9660", VA = "0x1871FAA60")]
	[CompilerGenerated]
	private void CGCPDBMLLKN(string INCJNHFIGKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class NJGIJHOEICP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class BFFLEBHELEL : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public BFFLEBHELEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x71E6EE0", Offset = "0x71E5AE0", VA = "0x1871E6EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x71E6F50", Offset = "0x71E5B50", VA = "0x1871E6F50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private GNHKJFLENJL GNIEFEAJNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private MonoBehaviour BJENICCNMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action PMDLNGNKGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Action<float> LBEKAKJGCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private HEAFJPMMKLL FHHHOJNINLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float OLALPHFFNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool JFBKCJIAIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly FCOOAPKDPMG CKOLOLELOJG;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x71FC440", Offset = "0x71FB040", VA = "0x1871FC440")]
	public NJGIJHOEICP(MonoBehaviour BJENICCNMGM, Action PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN, [Optional] FCOOAPKDPMG CKOLOLELOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x71FC200", Offset = "0x71FAE00", VA = "0x1871FC200")]
	public NJGIJHOEICP(MonoBehaviour BJENICCNMGM, Action<float> PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN, [Optional] FCOOAPKDPMG CKOLOLELOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x71FBFB0", Offset = "0x71FABB0", VA = "0x1871FBFB0")]
	public NJGIJHOEICP(MonoBehaviour BJENICCNMGM, float NFHLEJBCIPG, Action<float> PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN, bool JFBKCJIAIFD = true, [Optional] FCOOAPKDPMG CKOLOLELOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1BCAB90", Offset = "0x1BC9790", VA = "0x181BCAB90")]
	private NJGIJHOEICP(FCOOAPKDPMG CKOLOLELOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x71FB690", Offset = "0x71FA290", VA = "0x1871FB690")]
	internal static NJGIJHOEICP CKAAHJOGBEK(MonoBehaviour BJENICCNMGM, float NFHLEJBCIPG, Action<float> PMDLNGNKGFD, HEAFJPMMKLL FHHHOJNINLN, bool JFBKCJIAIFD = true, [Optional] FCOOAPKDPMG CKOLOLELOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x71FB9C0", Offset = "0x71FA5C0", VA = "0x1871FB9C0")]
	private void KNMMAGGCFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x71FBBC0", Offset = "0x71FA7C0", VA = "0x1871FBBC0")]
	private void LPFOHCDPAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x71FBE00", Offset = "0x71FAA00", VA = "0x1871FBE00")]
	private void PGAEBHPLEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x71FB4D0", Offset = "0x71FA0D0", VA = "0x1871FB4D0")]
	private void CHGBHDKDKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x71FB3A0", Offset = "0x71F9FA0", VA = "0x1871FB3A0")]
	private void AHFKLEDNBBG(string MCOFJPDPPAJ, Action BHIBGAAPACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x71FB7C0", Offset = "0x71FA3C0", VA = "0x1871FB7C0")]
	[IteratorStateMachine(typeof(BFFLEBHELEL))]
	private IEnumerator<OGKGDFEHPGC> CMBHCLNOKNL(Action BHIBGAAPACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x71FB840", Offset = "0x71FA440", VA = "0x1871FB840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x71FB8A0", Offset = "0x71FA4A0", VA = "0x1871FB8A0")]
	[CompilerGenerated]
	private void EGEDLFJCIDP(string INCJNHFIGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x71FB930", Offset = "0x71FA530", VA = "0x1871FB930")]
	[CompilerGenerated]
	private void FPHFBGNJEFP(string INCJNHFIGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x71FBD70", Offset = "0x71FA970", VA = "0x1871FBD70")]
	[CompilerGenerated]
	private void PFMPGAHJJGO(string INCJNHFIGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x71FBB30", Offset = "0x71FA730", VA = "0x1871FBB30")]
	[CompilerGenerated]
	private void LEENEAGDGKP(string INCJNHFIGKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Flags]
internal enum POLBKOHGFOM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal sealed class POEOIGLLELO : MAJNKLKGKDE
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float LEEBANNKJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7200420", Offset = "0x71FF020", VA = "0x187200420", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float DKHFCDOCFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7200410", Offset = "0x71FF010", VA = "0x187200410", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double GFAPMOHAOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x72004A0", Offset = "0x71FF0A0", VA = "0x1872004A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7200430", Offset = "0x71FF030", VA = "0x187200430")]
	[FJJFAIMPJIC(JBEKPLNNIEC.None)]
	private static void LLDKNAFABLI(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	[Preserve]
	internal POEOIGLLELO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface HONOPCACMDH
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFJEFGHJONG(string GFLNGGKHEOH);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKILHDGICBM();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal interface OGLIKMOLAEF
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool KLEOOCIKEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool MNJLDCGPKIC
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class ONMJMOFGPLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public MFBGABHOLID HOEKACJNFHM;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int HDEPOMLIBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8431A0", Offset = "0x841DA0", VA = "0x1808431A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8444C0", Offset = "0x8430C0", VA = "0x1808444C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x71FD320", Offset = "0x71FBF20", VA = "0x1871FD320")]
	public static OGKGDFEHPGC APKFGLLANEI(IEnumerator<OGKGDFEHPGC> MJHPMKMOHIF, CGLLHOAGPGP PIPFPJFIAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x71FD260", Offset = "0x71FBE60", VA = "0x1871FD260")]
	public OGKGDFEHPGC APKFGLLANEI(CGLLHOAGPGP[] FGJLLEIMIGB, IEnumerator<OGKGDFEHPGC>[] NCAEHHAKLGE, OGKGDFEHPGC[] JJOAIFOHONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x71FD480", Offset = "0x71FC080", VA = "0x1871FD480")]
	public void ILCBFPDJBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x71FD5F0", Offset = "0x71FC1F0", VA = "0x1871FD5F0")]
	public void NDBHPFMDOJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x71FD4B0", Offset = "0x71FC0B0", VA = "0x1871FD4B0")]
	public void KAKHLBKHPEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x71FD480", Offset = "0x71FC080", VA = "0x1871FD480")]
	public void NNGDDAGLGOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public ONMJMOFGPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class MFBGABHOLID
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct OJLHLLKBBCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public ONMJMOFGPLN IPDKPNOBKOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public OCPFCAEFKCD HGBHIFLMBDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CGLLHOAGPGP PGNNKKHNJGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<OGKGDFEHPGC> PKDPMGOLJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public OGKGDFEHPGC LGOLDGPJJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public POLBKOHGFOM EIDCFNLLBOK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct EAOGNCIPCPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public HEAFJPMMKLL HEKMPOBGDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<OJLHLLKBBCK> MEFMMJLEDHG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class LJFCOJPBLKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CGLLHOAGPGP promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public MFBGABHOLID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public OCPFCAEFKCD context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public ONMJMOFGPLN routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public POLBKOHGFOM coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public OGKGDFEHPGC currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<OGKGDFEHPGC> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LJFCOJPBLKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x71F6EE0", Offset = "0x71F5AE0", VA = "0x1871F6EE0")]
		internal void OHNMFBDCFIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class PFAFAHGLNEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public ONMJMOFGPLN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public MFBGABHOLID <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public PFAFAHGLNEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x71FDA30", Offset = "0x71FC630", VA = "0x1871FDA30")]
		internal void EKBMOMBBPLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class PDPAAAJFOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ONMJMOFGPLN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public MFBGABHOLID <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public PDPAAAJFOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x71FD9F0", Offset = "0x71FC5F0", VA = "0x1871FD9F0")]
		internal void PBOHBDFCKBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class MMACILACICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public ONMJMOFGPLN schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public MFBGABHOLID <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MMACILACICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x71FB2E0", Offset = "0x71F9EE0", VA = "0x1871FB2E0")]
		internal void LHBNMNBPPLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const POLBKOHGFOM FHAMHKMGDJE = POLBKOHGFOM.Cancelled | POLBKOHGFOM.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly HEAFJPMMKLL FHHHOJNINLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] DOAIAKOHGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<POLBKOHGFOM> CNMBEAGHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> IGDNOAFHEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> DDCACGINFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> AIPOJKIIIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> BHDOPMGOKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> DFOFBJOMIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> KONDLHALNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private ONMJMOFGPLN[] OGDIJPHIMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private CGLLHOAGPGP[] FGJLLEIMIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private OCPFCAEFKCD[] IIJMDDAHIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<OGKGDFEHPGC>[] CMPCOIAPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private OGKGDFEHPGC[] KMMNDFBFAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int AGJLPNDBODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int ECCOECALPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int PGIFPPFBGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float IDFBCBLMFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private KELIEOEIJDD EFPOLGJCMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle FOJHANNEKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<ONMJMOFGPLN> ABJAEKHJEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool ENOOMIEBGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> LMPPFCJEMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> HHHNOJCJELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool GLAMNLHLNDN;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public EAOGNCIPCPJ[] DGAENCBIEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8B36F0", Offset = "0x8B22F0", VA = "0x1808B36F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x71F8D00", Offset = "0x71F7900", VA = "0x1871F8D00")]
	private static int FOJIFCKCLMP(HEAFJPMMKLL FHHHOJNINLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x71FA2B0", Offset = "0x71F8EB0", VA = "0x1871FA2B0")]
	public MFBGABHOLID(HEAFJPMMKLL FHHHOJNINLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x71F8AA0", Offset = "0x71F76A0", VA = "0x1871F8AA0")]
	private void FKALGFMNIDL(int LLGDBFEIPCA, int IEDLAOHNECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x71F8DF0", Offset = "0x71F79F0", VA = "0x1871F8DF0")]
	public void GEGMCPFCKLB(OCPFCAEFKCD FBMKGECLCCA, OGKGDFEHPGC CLGLBMHBHIF, IEnumerator<OGKGDFEHPGC> MJHPMKMOHIF, CGLLHOAGPGP PIPFPJFIAEF, [Optional] ONMJMOFGPLN JBLAFCCNAIO, POLBKOHGFOM MMGCLCBCFEL = POLBKOHGFOM.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x71FA070", Offset = "0x71F8C70", VA = "0x1871FA070")]
	public void POPNBBOIFCJ(IEnumerable<OJLHLLKBBCK> OJIHIJJPHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x71F7F50", Offset = "0x71F6B50", VA = "0x1871F7F50")]
	private OJLHLLKBBCK BAKPECKGACI(int GCOAENCJOFO)
	{
		return default(OJLHLLKBBCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x71F8F70", Offset = "0x71F7B70", VA = "0x1871F8F70")]
	private void HDOGMOCBPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C32F60", Offset = "0x2C31B60", VA = "0x182C32F60")]
	private static void DDFAOEICELL<T>(int GCOAENCJOFO, T[] FEPLKPEJLEL, int AEOJMEBJNPD, [Optional] T ANKAAOCNMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C32FB0", Offset = "0x2C31BB0", VA = "0x182C32FB0")]
	private static void DDFAOEICELL<T>(int GCOAENCJOFO, NativeArray<T> FEPLKPEJLEL, int AEOJMEBJNPD, [Optional] T ANKAAOCNMHJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x71F85D0", Offset = "0x71F71D0", VA = "0x1871F85D0")]
	private void DPELIHHPBDI(IEnumerable<OJLHLLKBBCK> OJIHIJJPHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x71F8D30", Offset = "0x71F7930", VA = "0x1871F8D30")]
	private void GCPFNIEDPKB(OJLHLLKBBCK JKGIEFLGCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x71F9E10", Offset = "0x71F8A10", VA = "0x1871F9E10")]
	private PNDOECJHFOM OGJJMAPKGDE(int PMIIHKMLIDF)
	{
		return default(PNDOECJHFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x71F99E0", Offset = "0x71F85E0", VA = "0x1871F99E0")]
	public void LDFJOCINOJP(float BILFJIAHIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x71F8C80", Offset = "0x71F7880", VA = "0x1871F8C80")]
	private void FOBPHJIBIEM(Action NABHBOMGBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x71F8420", Offset = "0x71F7020", VA = "0x1871F8420")]
	private void DGHFJDDMLIB(Action NABHBOMGBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x71F92E0", Offset = "0x71F7EE0", VA = "0x1871F92E0")]
	public void KBLCLPOENMJ(float BILFJIAHIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x71F9BE0", Offset = "0x71F87E0", VA = "0x1871F9BE0")]
	public void LNHLHNCBJPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x71F9CE0", Offset = "0x71F88E0", VA = "0x1871F9CE0")]
	public void NNGDDAGLGOB(ONMJMOFGPLN LODBMLDAFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x71F84A0", Offset = "0x71F70A0", VA = "0x1871F84A0")]
	public void DKBPLNAOHCH(ONMJMOFGPLN LODBMLDAFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x71F8970", Offset = "0x71F7570", VA = "0x1871F8970")]
	public void EJNCKNDMPPO(ONMJMOFGPLN LODBMLDAFDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PHBLJDMLPID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly PHBLJDMLPID BBCAMDNMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Action OJBPIBKEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private bool JAMLMCMFMMA;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public PHBLJDMLPID(Action OJBPIBKEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x69A46D0", Offset = "0x69A32D0", VA = "0x1869A46D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface CNILGCABADE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T EPAONLOANJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PKOEOFGCEIG(UnityEngine.Object FBMKGECLCCA, Action<T> ALKJIJGPJDH);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface OGJNIALAEMD<T> : CNILGCABADE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T EPAONLOANJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class LBDLOCNNEGA<T> : OGJNIALAEMD<T>, CNILGCABADE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class JCOEHKLLGPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public LBDLOCNNEGA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public LENOMOJALKL<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JCOEHKLLGPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4015520", Offset = "0x4014120", VA = "0x184015520")]
		internal void AAJMDEKFCNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static GameObject GDLELOFCDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<LENOMOJALKL<UnityEngine.Object, Action<T>>> LOCLKEOBHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T PJIBMMPIMID;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T EPAONLOANJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x90BF40", Offset = "0x90AB40", VA = "0x18090BF40", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x41E8740", Offset = "0x41E7340", VA = "0x1841E8740", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x41E7F70", Offset = "0x41E6B70", VA = "0x1841E7F70")]
	private static bool IIDHDACLGEB(T NABHBOMGBNH, T EIKHFLMLKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x41E8C00", Offset = "0x41E7800", VA = "0x1841E8C00")]
	public LBDLOCNNEGA(T BIAPDNKEMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x41E87E0", Offset = "0x41E73E0", VA = "0x1841E87E0", Slot = "6")]
	public IDisposable PKOEOFGCEIG(UnityEngine.Object FBMKGECLCCA, Action<T> ALKJIJGPJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x41E8360", Offset = "0x41E6F60", VA = "0x1841E8360")]
	private void JCBBNFNEIAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal class BBFNFCNGGKH : NLFDNNPALAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly FCOOAPKDPMG CKOLOLELOJG;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x71E6DC0", Offset = "0x71E59C0", VA = "0x1871E6DC0")]
	[FJJFAIMPJIC(JBEKPLNNIEC.None)]
	private static void LLDKNAFABLI(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	[Preserve]
	internal BBFNFCNGGKH([GOICEJLKLIB(null)] FCOOAPKDPMG CKOLOLELOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x71E6E30", Offset = "0x71E5A30", VA = "0x1871E6E30", Slot = "4")]
	public IDisposable MECEKEFJCBC(float NFHLEJBCIPG, Action<float> LHMNAJJOJLL, bool JFBKCJIAIFD = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class HBLJGINEBFO : DALOHEDPLAE, FCOOAPKDPMG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private MFBGABHOLID[] HFPHCCPGJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private HONOPCACMDH GIPOECDEKNE;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x71F1E80", Offset = "0x71F0A80", VA = "0x1871F1E80")]
	[FJJFAIMPJIC(JBEKPLNNIEC.None)]
	private static void LLDKNAFABLI(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x71F2220", Offset = "0x71F0E20", VA = "0x1871F2220")]
	[Preserve]
	public HBLJGINEBFO([GOICEJLKLIB(null)] OHNNOPNKKLN PJHIHEKLMDL, [GOICEJLKLIB(null)] MAJNKLKGKDE HGINDGMJBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x71F1B20", Offset = "0x71F0720", VA = "0x1871F1B20", Slot = "16")]
	public override GNHKJFLENJL ENLNPJGLJOD(OCPFCAEFKCD FBMKGECLCCA, IEnumerator<OGKGDFEHPGC> PHGBICNNPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x71F1680", Offset = "0x71F0280", VA = "0x1871F1680", Slot = "17")]
	public override void CJMFGDFICPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x71F1C50", Offset = "0x71F0850", VA = "0x1871F1C50", Slot = "19")]
	public override void GNBFEFKIONP(HEAFJPMMKLL FHHHOJNINLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x71F1EF0", Offset = "0x71F0AF0", VA = "0x1871F1EF0", Slot = "18")]
	protected override void NBJEMGDMOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x71F21F0", Offset = "0x71F0DF0", VA = "0x1871F21F0")]
	private MFBGABHOLID OJDBOOJLFAD(HEAFJPMMKLL NCNNODEFPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x71F1FC0", Offset = "0x71F0BC0", VA = "0x1871F1FC0", Slot = "20")]
	internal override OEKNLLJGOLL OBICKBNEKBN(IEnumerator<OGKGDFEHPGC> PHGBICNNPAN, Behaviour FBMKGECLCCA, CGLLHOAGPGP PIPFPJFIAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x71F1920", Offset = "0x71F0520", VA = "0x1871F1920", Slot = "21")]
	internal override BAOKEIPEDDM DCICCNGIEPB(HEAFJPMMKLL IANEMNKPNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x71F1A00", Offset = "0x71F0600", VA = "0x1871F1A00")]
	private void ECCLLFNEOEJ(MFBGABHOLID AODEKDFLFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x71F19A0", Offset = "0x71F05A0", VA = "0x1871F19A0", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[BurstCompile]
internal struct KELIEOEIJDD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public float DMIFOFPCDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public int GOEBAJGOKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> OCHIBIHMFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> FKFMEKIIGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NativeArray<int> DBLEMIPEALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<POLBKOHGFOM> EGBFPBOOJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[ReadOnly]
	public NativeArray<float> GLALCHJPFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> BHDOPMGOKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[WriteOnly]
	public NativeArray<int> DDCACGINFHF;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x71F4E20", Offset = "0x71F3A20", VA = "0x1871F4E20")]
	public static KELIEOEIJDD GADNMLFOLLL(int FINHDEIBLNK, float BILFJIAHIIH, NativeArray<POLBKOHGFOM> LDMIDGLIEIL, NativeArray<float> NFAMPIOIDIA, NativeArray<int> GNNNIPDPDJM, NativeArray<int> JMDEJEMMEPD, NativeArray<int> HGGDAMMBLII, NativeArray<int> FKFMEKIIGKG, NativeArray<int> DBLEMIPEALC)
	{
		return default(KELIEOEIJDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x71F4D40", Offset = "0x71F3940", VA = "0x1871F4D40", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x71F5230", Offset = "0x71F3E30", VA = "0x1871F5230")]
	private bool PDAEMCGPHJC(int OPDMGNJCACB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x71F4D10", Offset = "0x71F3910", VA = "0x1871F4D10")]
	private void BMABHDFCAPB(NativeArray<int> IPLMOLBCGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x71F4F50", Offset = "0x71F3B50", VA = "0x1871F4F50")]
	private int MAHAKLOFGHJ(int INHKOAPDFBO, int ILIGAJGJDHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x71F4E80", Offset = "0x71F3A80", VA = "0x1871F4E80")]
	private void KBBFMLKDLLA(NativeArray<int> IPLMOLBCGME, int KCIHBECGHCJ, int AAELGECAEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x71F4FF0", Offset = "0x71F3BF0", VA = "0x1871F4FF0")]
	private void MDECHPHHNIF(NativeArray<int> IPLMOLBCGME, int ICDDLAFNKDP, int AHBCLBEJDMJ, int PGEMFADENJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public abstract class DALOHEDPLAE : FCOOAPKDPMG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly OHNNOPNKKLN PJHIHEKLMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected readonly MAJNKLKGKDE HGINDGMJBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private BAOKEIPEDDM[] AANLEIEIGFP;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static FCOOAPKDPMG GGKBGANLBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x71ECFF0", Offset = "0x71EBBF0", VA = "0x1871ECFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool OKAHPDGICCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HEAFJPMMKLL IELMMANDIIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8431A0", Offset = "0x841DA0", VA = "0x1808431A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(HEAFJPMMKLL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8444C0", Offset = "0x8430C0", VA = "0x1808444C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MAJNKLKGKDE PGDFEAKGMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public OGKGDFEHPGC HMELOEEJCMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x71EDC00", Offset = "0x71EC800", VA = "0x1871EDC00")]
	public static GNHKJFLENJL MNOHHEOJEOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x71EDCB0", Offset = "0x71EC8B0", VA = "0x1871EDCB0")]
	[Preserve]
	protected DALOHEDPLAE([GOICEJLKLIB(null)] OHNNOPNKKLN PJHIHEKLMDL, [GOICEJLKLIB(null)] MAJNKLKGKDE HGINDGMJBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x71EDB50", Offset = "0x71EC750", VA = "0x1871EDB50", Slot = "6")]
	public GNHKJFLENJL JHMLCEABGGF(IEnumerator<OGKGDFEHPGC> PHGBICNNPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x71ED950", Offset = "0x71EC550", VA = "0x1871ED950", Slot = "7")]
	public GNHKJFLENJL JHMLCEABGGF(Behaviour FBMKGECLCCA, IEnumerator<OGKGDFEHPGC> PHGBICNNPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract GNHKJFLENJL ENLNPJGLJOD(OCPFCAEFKCD FBMKGECLCCA, IEnumerator<OGKGDFEHPGC> PHGBICNNPAN);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x71ED040", Offset = "0x71EBC40", VA = "0x1871ED040", Slot = "17")]
	public virtual void CJMFGDFICPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x71ECDB0", Offset = "0x71EB9B0", VA = "0x1871ECDB0", Slot = "9")]
	public void BOOIPOJEDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x71EDC90", Offset = "0x71EC890", VA = "0x1871EDC90", Slot = "18")]
	protected virtual void NBJEMGDMOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x71ED790", Offset = "0x71EC390", VA = "0x1871ED790")]
	private void GGCMBBLLMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x71EDB80", Offset = "0x71EC780", VA = "0x1871EDB80")]
	private void LMLAHFLLBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x71ED8A0", Offset = "0x71EC4A0", VA = "0x1871ED8A0")]
	private void HHCIDMMBLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x71ECD70", Offset = "0x71EB970", VA = "0x1871ECD70")]
	private void AABHPGHHMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x71EDB60", Offset = "0x71EC760", VA = "0x1871EDB60")]
	private void KDJODMBHEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x71ED770", Offset = "0x71EC370", VA = "0x1871ED770")]
	private void GBCCBKKKLMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x71ECD90", Offset = "0x71EB990", VA = "0x1871ECD90")]
	private void BJHKEENOMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x71ED7B0", Offset = "0x71EC3B0", VA = "0x1871ED7B0", Slot = "19")]
	public virtual void GNBFEFKIONP(HEAFJPMMKLL FHHHOJNINLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x71ED1E0", Offset = "0x71EBDE0", VA = "0x1871ED1E0")]
	private void CPHANEFGDIJ(BAOKEIPEDDM AODEKDFLFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E90520", Offset = "0x1E8F120", VA = "0x181E90520")]
	private BAOKEIPEDDM BMMCFIMCIJN(HEAFJPMMKLL NCNNODEFPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract OEKNLLJGOLL OBICKBNEKBN(IEnumerator<OGKGDFEHPGC> PHGBICNNPAN, Behaviour BJENICCNMGM, CGLLHOAGPGP BGACCOHHEDJ);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract BAOKEIPEDDM DCICCNGIEPB(HEAFJPMMKLL FHHHOJNINLN);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x71ED3B0", Offset = "0x71EBFB0", VA = "0x1871ED3B0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x71EDBA0", Offset = "0x71EC7A0", VA = "0x1871EDBA0", Slot = "12")]
	public OGKGDFEHPGC MLHHGCCFFMF(HEAFJPMMKLL IANEMNKPNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x71ED8C0", Offset = "0x71EC4C0", VA = "0x1871ED8C0", Slot = "13")]
	public OGKGDFEHPGC HPCJJNHGGFL(float EACMJFLDLDP, HEAFJPMMKLL IANEMNKPNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x71ED840", Offset = "0x71EC440", VA = "0x1871ED840", Slot = "14")]
	public OGKGDFEHPGC HFNPKOJINDK(Func<bool> OINKDIMBFCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class OEKNLLJGOLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly CGLLHOAGPGP PIPFPJFIAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly OGLIKMOLAEF FBMKGECLCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly bool FFHAMPOKJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private string GFLNGGKHEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private StackTrace CEJAICKLEMG;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<OGKGDFEHPGC> PKDPMGOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public OGKGDFEHPGC LGOLDGPJJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool BIFBJGOCMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x71FCB40", Offset = "0x71FB740", VA = "0x1871FCB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool FIIIEIIMEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9B01D0", Offset = "0x9AEDD0", VA = "0x1809B01D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9B02F0", Offset = "0x9AEEF0", VA = "0x1809B02F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x71FCBC0", Offset = "0x71FB7C0", VA = "0x1871FCBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float NMEOHMBHJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8B39B0", Offset = "0x8B25B0", VA = "0x1808B39B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5E8FE10", Offset = "0x5E8EA10", VA = "0x185E8FE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x71FCF10", Offset = "0x71FBB10", VA = "0x1871FCF10")]
	public OEKNLLJGOLL(IEnumerator<OGKGDFEHPGC> MJHPMKMOHIF, OGLIKMOLAEF FBMKGECLCCA, CGLLHOAGPGP PIPFPJFIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x71FC830", Offset = "0x71FB430", VA = "0x1871FC830")]
	public OGKGDFEHPGC APKFGLLANEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x71FCDC0", Offset = "0x71FB9C0", VA = "0x1871FCDC0")]
	public bool OAGOANALKFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x71FCD70", Offset = "0x71FB970", VA = "0x1871FCD70")]
	public void NNGDDAGLGOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x71FCE30", Offset = "0x71FBA30", VA = "0x1871FCE30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5EFF0", VA = "0x180A603F0")]
	[CompilerGenerated]
	private void FAHKFPNCNPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class CGLLHOAGPGP : DHGFLENDOMM, GNHKJFLENJL, LKPPGGKMHON, CEIMLGOLMNM, IEnumerator, OGKGDFEHPGC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private HEAFJPMMKLL PPIDPFNKCBB;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private HEAFJPMMKLL ICIFODGLHHI
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1003370", Offset = "0x1001F70", VA = "0x181003370", Slot = "23")]
		get
		{
			return default(HEAFJPMMKLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public HEAFJPMMKLL HOEKACJNFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1538270", Offset = "0x1536E70", VA = "0x181538270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float FBKCJDOJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x9FD420", Offset = "0x9FC020", VA = "0x1809FD420", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool EAKHLFFKCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x71E7F90", Offset = "0x71E6B90", VA = "0x1871E7F90", Slot = "24")]
	private bool LPDMLHKHABF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x71E7F80", Offset = "0x71E6B80", VA = "0x1871E7F80", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x71E7FB0", Offset = "0x71E6BB0", VA = "0x1871E7FB0")]
	public CGLLHOAGPGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal enum PNDOECJHFOM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class BAOKEIPEDDM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum DDKJNCFEMFF
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public struct LJIMOOKMJKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public HEAFJPMMKLL HEKMPOBGDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public DDKJNCFEMFF MCNEHOIJFOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public List<OEKNLLJGOLL> BNIFALOLMNM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly DDKJNCFEMFF[] GHMNJIOIADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly HEAFJPMMKLL FHHHOJNINLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool AFOMEPMBJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly OEKNLLJGOLL[] MJDCFIBAMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<OEKNLLJGOLL> AMGLIPFEHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Stack<int> CKGEGNAIMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly List<OEKNLLJGOLL> MPEFMFIGHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Stack<int> OIJLIDGIIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly HONOPCACMDH DJKDFFLLNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private bool GLAMNLHLNDN;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public LJIMOOKMJKA[,] LOIOFHEGHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x71E6910", Offset = "0x71E5510", VA = "0x1871E6910")]
	public BAOKEIPEDDM(HEAFJPMMKLL IANEMNKPNHN, HONOPCACMDH DJKDFFLLNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x71E62E0", Offset = "0x71E4EE0", VA = "0x1871E62E0")]
	public void IOMKAEOPAPO(OEKNLLJGOLL MJHPMKMOHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x71E5B50", Offset = "0x71E4750", VA = "0x1871E5B50")]
	public void GIKKMKJDMIA(IList<OEKNLLJGOLL> NCAEHHAKLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x71E5E50", Offset = "0x71E4A50", VA = "0x1871E5E50")]
	public void HEJCCCPLNLP(IList<OEKNLLJGOLL> NCAEHHAKLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x71E63F0", Offset = "0x71E4FF0", VA = "0x1871E63F0")]
	private void IOPLGPPEMCJ(OEKNLLJGOLL MJHPMKMOHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x71E6150", Offset = "0x71E4D50", VA = "0x1871E6150")]
	private void INEHCPIACBL(IList<OEKNLLJGOLL> NCAEHHAKLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x71E6650", Offset = "0x71E5250", VA = "0x1871E6650")]
	private PNDOECJHFOM NGFIHDPGBFC(OEKNLLJGOLL MJHPMKMOHIF)
	{
		return default(PNDOECJHFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x71E64E0", Offset = "0x71E50E0", VA = "0x1871E64E0")]
	public void NBJEMGDMOCC(float BILFJIAHIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x71E5400", Offset = "0x71E4000", VA = "0x1871E5400")]
	public void BOOIPOJEDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x71E5730", Offset = "0x71E4330", VA = "0x1871E5730")]
	private void DDGOBLHINBN(List<OEKNLLJGOLL> NCAEHHAKLGE, Stack<int> POCMJJLEBAD, bool HPBBBBCOPGO, float ODPPHCBDJAA = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x71E5A30", Offset = "0x71E4630", VA = "0x1871E5A30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x71E55F0", Offset = "0x71E41F0", VA = "0x1871E55F0")]
	private void CAPEIHCFOLF(List<OEKNLLJGOLL> NCAEHHAKLGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class DMEMANHAMNJ : HONOPCACMDH
{
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
	public void JFJEFGHJONG(string GFLNGGKHEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
	public void HKILHDGICBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public DMEMANHAMNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal class DCNGDKLFILI : OGLIKMOLAEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly Behaviour BJENICCNMGM;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x71EE210", Offset = "0x71ECE10", VA = "0x1871EE210", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool KLEOOCIKEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x71EE1C0", Offset = "0x71ECDC0", VA = "0x1871EE1C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool MNJLDCGPKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x71EE1A0", Offset = "0x71ECDA0", VA = "0x1871EE1A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public DCNGDKLFILI(Behaviour BJENICCNMGM)
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

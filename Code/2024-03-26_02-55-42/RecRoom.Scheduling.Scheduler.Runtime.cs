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
public class BAJMMNDJEJK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority LJAIABPGFDI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A28570", Offset = "0x6A27970", VA = "0x186A28570")]
	public BAJMMNDJEJK(ThreadPriority AGJJMLCBJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A28560", Offset = "0x6A27960", VA = "0x186A28560", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> JAOEMBMCAPK(List<PlayerLoopSystem> DMIHEGPOACN, int AMFNNAPIEHG);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct NIEBENCHCPN
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct APINEIDIBPA
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static DGHHAMKHKGM LPAPBKHNPNN;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x6A28240", Offset = "0x6A27640", VA = "0x186A28240")]
				public static PlayerLoopSystem MNFFLJODIAA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct CGMDKAFAPPF
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static DGHHAMKHKGM IONGCAPFNIN;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x6A29B40", Offset = "0x6A28F40", VA = "0x186A29B40")]
				public static PlayerLoopSystem MNFFLJODIAA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct IIHHMKJJCGN
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static DGHHAMKHKGM KFLNLOANHNB;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6A36780", Offset = "0x6A35B80", VA = "0x186A36780")]
				public static PlayerLoopSystem MNFFLJODIAA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct FDIODADAENC
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static DGHHAMKHKGM OOPHDAGMAAJ;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static DGHHAMKHKGM BBODFJCALEO;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static DGHHAMKHKGM CBCHJBMCNCK;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static DGHHAMKHKGM FNJGIPJEGFF;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x6A334F0", Offset = "0x6A328F0", VA = "0x186A334F0")]
				public static PlayerLoopSystem MNFFLJODIAA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct LEPKIJLBNGP
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static DGHHAMKHKGM OHOAKMIIALC;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x6A3A130", Offset = "0x6A39530", VA = "0x186A3A130")]
				public static PlayerLoopSystem MNFFLJODIAA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct CGIMNJLDHOI
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static DGHHAMKHKGM OOPHDAGMAAJ;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static DGHHAMKHKGM BBODFJCALEO;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static DGHHAMKHKGM CBCHJBMCNCK;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static DGHHAMKHKGM FNJGIPJEGFF;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x6A29850", Offset = "0x6A28C50", VA = "0x186A29850")]
				public static PlayerLoopSystem MNFFLJODIAA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct IEOKGIMCOCA
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static DGHHAMKHKGM ALPFIAFLKCJ;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x6A35EB0", Offset = "0x6A352B0", VA = "0x186A35EB0")]
				public static PlayerLoopSystem MNFFLJODIAA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct KFFJLOMIHGG
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static DGHHAMKHKGM FLKGNLIJGKG;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6A37BB0", Offset = "0x6A36FB0", VA = "0x186A37BB0")]
				public static PlayerLoopSystem MNFFLJODIAA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct DGADOFJLGNB
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static DGHHAMKHKGM PFIECPFPLOB;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6A2E760", Offset = "0x6A2DB60", VA = "0x186A2E760")]
				public static PlayerLoopSystem MNFFLJODIAA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct EKHLEHKFMBP
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static DGHHAMKHKGM ABLLFNJLIHE;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6A30020", Offset = "0x6A2F420", VA = "0x186A30020")]
				public static PlayerLoopSystem MNFFLJODIAA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct ECBKPHEGCFL
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static DGHHAMKHKGM ABNIPEJDHPH;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6A2F550", Offset = "0x6A2E950", VA = "0x186A2F550")]
				public static PlayerLoopSystem MNFFLJODIAA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct OLJNEGCFEDL
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static DGHHAMKHKGM GJCGNFIHEBO;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x6A3FE40", Offset = "0x6A3F240", VA = "0x186A3FE40")]
				public static PlayerLoopSystem MNFFLJODIAA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum HIAKDGKPAAD : byte
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
			public struct OBKBFMOBNCL
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class OLOGJGKKBEA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public HIAKDGKPAAD updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
					public OLOGJGKKBEA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x6A40040", Offset = "0x6A3F440", VA = "0x186A40040")]
					internal void AFAIMKPODFD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static JGNHMIKEILN<HIAKDGKPAAD> PJGIAKPHDDB;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6A3FAF0", Offset = "0x6A3EEF0", VA = "0x186A3FAF0")]
				public static PlayerLoopSystem MNFFLJODIAA(HIAKDGKPAAD DMBOCLCHENP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct KBNPGNPLNDC
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class KGMNBKJAOMH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public OOEPDBKJMBL.CDPOGIKLOAN key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
					public KGMNBKJAOMH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6A37DB0", Offset = "0x6A371B0", VA = "0x186A37DB0")]
					internal void HNACMFFAMBA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable KDEPGIJAEKN;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x6A37320", Offset = "0x6A36720", VA = "0x186A37320")]
				public static PlayerLoopSystem KDHMDINEFBM(OOEPDBKJMBL.CDPOGIKLOAN NIOPCMHKLMB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct GPCFLFGOMFH
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class LDGNOAPEDCC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public OOEPDBKJMBL.CDPOGIKLOAN key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
					public LDGNOAPEDCC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x6A396C0", Offset = "0x6A38AC0", VA = "0x186A396C0")]
					internal void HNACMFFAMBA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x6A351C0", Offset = "0x6A345C0", VA = "0x186A351C0")]
				public static PlayerLoopSystem KDHMDINEFBM(OOEPDBKJMBL.CDPOGIKLOAN NIOPCMHKLMB)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class PMPIODBNBKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public PMPIODBNBKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6A41090", Offset = "0x6A40490", VA = "0x186A41090")]
			internal List<PlayerLoopSystem> DECDGBNLJHP(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool LOAGKLCEGAJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool HBIPJGLGPEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6A2AC60", Offset = "0x6A2A060", VA = "0x186A2AC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A2BA80", Offset = "0x6A2AE80", VA = "0x186A2BA80")]
		private static void JFDGKIAHIDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A2B1B0", Offset = "0x6A2A5B0", VA = "0x186A2B1B0")]
		private static void JBENKNHLGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6A2AA30", Offset = "0x6A29E30", VA = "0x186A2AA30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A870", Offset = "0x6A29C70", VA = "0x186A2A870")]
		private static void AFGEIPNIDMB(OOEPDBKJMBL.CDPOGIKLOAN NIOPCMHKLMB, PlayerLoopSystem FCDDLIFBMIO, Type MNHNPCGMACP, Type GHNCKNDKNGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6A2ADD0", Offset = "0x6A2A1D0", VA = "0x186A2ADD0")]
		private static void IEJBHAKIEGC(PlayerLoopSystem FCDDLIFBMIO, Type MNHNPCGMACP, Type GHNCKNDKNGC, JAOEMBMCAPK NANFMOGGHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6A2ACA0", Offset = "0x6A2A0A0", VA = "0x186A2ACA0")]
		private static void GNDNGMLHJCM(PlayerLoopSystem FCDDLIFBMIO, Type MNHNPCGMACP, Type GHNCKNDKNGC, PlayerLoopSystem? DFHOHGNNEAD, PlayerLoopSystem? LJGNCNOOENJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class OOEPDBKJMBL
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum CDPOGIKLOAN
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
	public class MICPCHLGAGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly CDPOGIKLOAN IEBOJNPELAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly KPHHDPBHAGO DMLBHDAFOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long ECCONLDFHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long GICDLFAAEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long HJMCKFECDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int ANIPIGNKLHB;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A5D0", Offset = "0x6A399D0", VA = "0x186A3A5D0")]
		public MICPCHLGAGD(CDPOGIKLOAN CHBNDGOPHMA, int DNLKJNONIIG = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A330", Offset = "0x6A39730", VA = "0x186A3A330")]
		public void AMPNDDFMGGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A3A0", Offset = "0x6A397A0", VA = "0x186A3A3A0")]
		public void DLGDCDDBHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A3F0", Offset = "0x6A397F0", VA = "0x186A3A3F0")]
		public void POCNKLIGGMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static CDPOGIKLOAN[] EOLHBMKONBK;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static MICPCHLGAGD[] MOKNPHCFLIK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A400C0", Offset = "0x6A3F4C0", VA = "0x186A400C0")]
	public static MICPCHLGAGD ALCPJIKOGFN(CDPOGIKLOAN NIOPCMHKLMB, int DNLKJNONIIG = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A402A0", Offset = "0x6A3F6A0", VA = "0x186A402A0")]
	public static MICPCHLGAGD CGMNAIANMEH(CDPOGIKLOAN NIOPCMHKLMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A40310", Offset = "0x6A3F710", VA = "0x186A40310")]
	public static void ICFKFGKMCPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class KPHHDPBHAGO : JGBGPHCNPNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int AABFDCAIHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> FNPEBPFBODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double AFOBKBGPGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double MAOIAODMCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double KNDEAJEDLDC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double IGOIJAFANCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A39420", Offset = "0x6A38820", VA = "0x186A39420", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double NDFAGIPNPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x184AC00", Offset = "0x184A000", VA = "0x18184AC00", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double GPPBADLHANI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D9AA20", Offset = "0x1D99E20", VA = "0x181D9AA20", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A39610", Offset = "0x6A38A10", VA = "0x186A39610")]
	public KPHHDPBHAGO(int KHKFBNANOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A394F0", Offset = "0x6A388F0", VA = "0x186A394F0", Slot = "7")]
	public void KFGKJEOEAGO(double FNMPHGMIIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A39480", Offset = "0x6A38880", VA = "0x186A39480", Slot = "8")]
	public void HIHHBKCGMJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NFLIOBFPAKF : JGBGPHCNPNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long JDBLGKLFJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double FHLPKNMOOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double NPDDKCAIKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double LNJGACAKBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double CGEILNCINOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double AFOBKBGPGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double MAOIAODMCPM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double NDFAGIPNPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x57B2620", Offset = "0x57B1A20", VA = "0x1857B2620", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double GPPBADLHANI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x57B2630", Offset = "0x57B1A30", VA = "0x1857B2630", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double OIDIAADAJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x57B25E0", Offset = "0x57B19E0", VA = "0x1857B25E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double IGOIJAFANCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2291830", Offset = "0x2290C30", VA = "0x182291830", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CC20", Offset = "0x6A3C020", VA = "0x186A3CC20", Slot = "7")]
	public virtual void KFGKJEOEAGO(double FNMPHGMIIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CBE0", Offset = "0x6A3BFE0", VA = "0x186A3CBE0", Slot = "8")]
	public virtual void HIHHBKCGMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A850", Offset = "0x6A39C50", VA = "0x186A3A850")]
	public NFLIOBFPAKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class MIGBOCAKDJM : NFLIOBFPAKF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double OMDCPFAHPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x57B25B0", Offset = "0x57B19B0", VA = "0x1857B25B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x57B2610", Offset = "0x57B1A10", VA = "0x1857B2610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A720", Offset = "0x6A39B20", VA = "0x186A3A720", Slot = "7")]
	public override void KFGKJEOEAGO(double FNMPHGMIIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A6E0", Offset = "0x6A39AE0", VA = "0x186A3A6E0", Slot = "8")]
	public override void HIHHBKCGMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A850", Offset = "0x6A39C50", VA = "0x186A3A850")]
	public MIGBOCAKDJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JGBGPHCNPNL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double IGOIJAFANCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double NDFAGIPNPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double GPPBADLHANI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LELFDCJCBIO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface ACJCLKBBOFG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool HOOCNMLECCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BHPLCNHAPGJ();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class BILFPOAHAPO<TPromise, TMainThreadPromise> : ACJCLKBBOFG where TPromise : PEMLHLMJEJH where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise CEMNPEDCOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise OKPOEFFFPKA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise JILDFJAFMAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x480F150", Offset = "0x480E550", VA = "0x18480F150")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HOOCNMLECCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x480F1B0", Offset = "0x480E5B0", VA = "0x18480F1B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C10", Offset = "0x7C3010", VA = "0x1807C3C10")]
		protected BILFPOAHAPO(TPromise CEMNPEDCOGG, TMainThreadPromise AJBCACMGBFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x480F130", Offset = "0x480E530", VA = "0x18480F130", Slot = "5")]
		public void BHPLCNHAPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void OJAHOCEGGLG(TPromise CEMNPEDCOGG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class HEAECBBGKGK<T> : BILFPOAHAPO<JNFFOANFOAP<T>, JPPAJGENKOG<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3848690", Offset = "0x3847A90", VA = "0x183848690")]
		public HEAECBBGKGK(JNFFOANFOAP<T> CEMNPEDCOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3848480", Offset = "0x3847880", VA = "0x183848480", Slot = "6")]
		protected override void OJAHOCEGGLG(JNFFOANFOAP<T> CEMNPEDCOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3848420", Offset = "0x3847820", VA = "0x183848420")]
		[CompilerGenerated]
		private void DOAGCGDJLCI(T FEADNEEPDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3848450", Offset = "0x3847850", VA = "0x183848450")]
		[CompilerGenerated]
		private void FPBHLBLGLKI(string NBDBHDLNPOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class MJOAEIMMBCK : ACJCLKBBOFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action PNAPELFIIEJ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HOOCNMLECCF
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
		public MJOAEIMMBCK(Action PNAPELFIIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xC34350", Offset = "0xC33750", VA = "0x180C34350", Slot = "5")]
		public void BHPLCNHAPGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<ACJCLKBBOFG> FOMFIBOMLJJ;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2886A90", Offset = "0x2885E90", VA = "0x182886A90")]
	public static JNFFOANFOAP<T> NAHLCKMMPMD<T>(this JNFFOANFOAP<T> CEMNPEDCOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6A39D20", Offset = "0x6A39120", VA = "0x186A39D20")]
	public static void NAHLCKMMPMD(Action PNAPELFIIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x28869D0", Offset = "0x2885DD0", VA = "0x1828869D0")]
	private static JNFFOANFOAP<T> EEGCNJLDIKL<T>(JNFFOANFOAP<T> CEMNPEDCOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6A39930", Offset = "0x6A38D30", VA = "0x186A39930")]
	private static void AEAABJCHGIA(ACJCLKBBOFG HGGECFLPCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6A39DC0", Offset = "0x6A391C0", VA = "0x186A39DC0")]
	private static void OBGLIBANMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A39C20", Offset = "0x6A39020", VA = "0x186A39C20")]
	private static void FENBEGGDJOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A39B40", Offset = "0x6A38F40", VA = "0x186A39B40")]
	private static void BJHHOPEGIFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class FAOOIJALDKE
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct OHOMLGCEFHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> DILKAEOHNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string DDFEOCNDAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode LLCGLOPHPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool CPBOEODCEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FDE0", Offset = "0x6A3F1E0", VA = "0x186A3FDE0")]
		public OHOMLGCEFHO(TaskCompletionSource<Scene> IMAIIHOELNA, string DDFEOCNDAEA, LoadSceneMode LLCGLOPHPNN, bool CPBOEODCEGK, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct CPMIAOMBEJA : IAsyncStateMachine
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
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private OHKLINEMLLN<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x6A29F60", Offset = "0x6A29360", VA = "0x186A29F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A800", Offset = "0x6A29C00", VA = "0x186A2A800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct CDPMKMMOIFC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A294D0", Offset = "0x6A288D0", VA = "0x186A294D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A297F0", Offset = "0x6A28BF0", VA = "0x186A297F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GNPLJPDDAHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private OHOMLGCEFHO <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A34DB0", Offset = "0x6A341B0", VA = "0x186A34DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6A35160", Offset = "0x6A34560", VA = "0x186A35160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class OABOOLBIAKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JPPAJGENKOG<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public OABOOLBIAKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FA90", Offset = "0x6A3EE90", VA = "0x186A3FA90")]
		internal void IKPPAFKFOKJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct GLONDNNMMEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

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
		private OABOOLBIAKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private OHKLINEMLLN<string>.IECBLACBOCC <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A34160", Offset = "0x6A33560", VA = "0x186A34160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A34D00", Offset = "0x6A34100", VA = "0x186A34D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct AJJGPFGENPH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A27760", Offset = "0x6A26B60", VA = "0x186A27760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6A27C70", Offset = "0x6A27070", VA = "0x186A27C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct HIBPLJKIDHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private OHKLINEMLLN<string>.IECBLACBOCC <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private OHKLINEMLLN<string>.IECBLACBOCC <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6A352F0", Offset = "0x6A346F0", VA = "0x186A352F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6A35E40", Offset = "0x6A35240", VA = "0x186A35E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class EHNMAMAALCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public EHNMAMAALCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A2FFF0", Offset = "0x6A2F3F0", VA = "0x186A2FFF0")]
		internal bool NGKENEECLAA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class MLFGGDGCBDC : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public IBOPGHHDJFG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public MLFGGDGCBDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CA80", Offset = "0x6A3BE80", VA = "0x186A3CA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C6F0", Offset = "0x6A3BAF0", VA = "0x186A3C6F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C6A0", Offset = "0x6A3BAA0", VA = "0x186A3C6A0")]
		private void CLBCIEJIKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CA30", Offset = "0x6A3BE30", VA = "0x186A3CA30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class IGPLMLDIIPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public JPPAJGENKOG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public IGPLMLDIIPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A36650", Offset = "0x6A35A50", VA = "0x186A36650")]
		internal bool CINDBEBMCEA(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A363D0", Offset = "0x6A357D0", VA = "0x186A363D0")]
		internal void AHCCAKLLNLL(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class KCEPAAGBCJE : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public JPPAJGENKOG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private IGPLMLDIIPP <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public KCEPAAGBCJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A37450", Offset = "0x6A36850", VA = "0x186A37450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A37B60", Offset = "0x6A36F60", VA = "0x186A37B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> HGIFAAMODDO;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static PEMLHLMJEJH FHGDJPPHCCL;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation LDJOKIFEAPG;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static PEMLHLMJEJH ABCHMAMKDED;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string FACMAJOKACN;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority IFNLKDKFFEI;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task GPNGLMEGHHF;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> EPDPKNLGHGA;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<OHOMLGCEFHO> ILMAILMLMEB;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task GGFMHHGCBAI;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool OEIIPDHEHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A31570", Offset = "0x6A30970", VA = "0x186A31570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool GKNFMEHGPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A31790", Offset = "0x6A30B90", VA = "0x186A31790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool CJFFBCHPAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A311A0", Offset = "0x6A305A0", VA = "0x186A311A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool PDMNOGHOBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A30960", Offset = "0x6A2FD60", VA = "0x186A30960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> OEEMLNOCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6A31830", Offset = "0x6A30C30", VA = "0x186A31830")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A30850", Offset = "0x6A2FC50", VA = "0x186A30850")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A30B00", Offset = "0x6A2FF00", VA = "0x186A30B00")]
	[HFOGDBDLAPM(NKDKJBDOANI.EnteredEditModeNextFrame, 0)]
	private static void FKNIDBGODDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6A30C00", Offset = "0x6A30000", VA = "0x186A30C00")]
	[AsyncStateMachine(typeof(CPMIAOMBEJA))]
	public static Task<Scene> GAIAMNNKLEN(string DDFEOCNDAEA, LoadSceneMode LLCGLOPHPNN = LoadSceneMode.Single, bool CPBOEODCEGK = false, [Optional] OHKLINEMLLN<string>.IECBLACBOCC ECNCPDOMKAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6A307A0", Offset = "0x6A2FBA0", VA = "0x186A307A0")]
	[AsyncStateMachine(typeof(CDPMKMMOIFC))]
	private static Task DCBHABMFELJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A30D50", Offset = "0x6A30150", VA = "0x186A30D50")]
	[AsyncStateMachine(typeof(GNPLJPDDAHO))]
	private static Task GNODPODOIOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A30380", Offset = "0x6A2F780", VA = "0x186A30380")]
	[AsyncStateMachine(typeof(GLONDNNMMEI))]
	private static Task<Scene> CLDPLIHDGIK(string DDFEOCNDAEA, LoadSceneMode LLCGLOPHPNN, bool CPBOEODCEGK, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A30220", Offset = "0x6A2F620", VA = "0x186A30220")]
	private static void CCGMOHGEEKM(SceneInstance DLKEBALDMPC, LoadSceneMode LLCGLOPHPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A30E20", Offset = "0x6A30220", VA = "0x186A30E20")]
	private static void IBMAIAOAIIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A31450", Offset = "0x6A30850", VA = "0x186A31450")]
	[AsyncStateMachine(typeof(AJJGPFGENPH))]
	private static Task<Scene> NDJFFIBLLLB(string DDFEOCNDAEA, LoadSceneMode LLCGLOPHPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A30EE0", Offset = "0x6A302E0", VA = "0x186A30EE0")]
	private static bool IBMFABIOFPB(string DDFEOCNDAEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A309F0", Offset = "0x6A2FDF0", VA = "0x186A309F0")]
	[AsyncStateMachine(typeof(HIBPLJKIDHG))]
	private static Task<Scene> EPFBJHBPHND(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A312D0", Offset = "0x6A306D0", VA = "0x186A312D0")]
	public static JNFFOANFOAP<Scene> MCLEPFOAEIJ(string DDFEOCNDAEA, LoadSceneMode LLCGLOPHPNN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A304D0", Offset = "0x6A2F8D0", VA = "0x186A304D0")]
	public static PEMLHLMJEJH CNIADIDNJBN(string DDFEOCNDAEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A31240", Offset = "0x6A30640", VA = "0x186A31240")]
	[IteratorStateMachine(typeof(MLFGGDGCBDC))]
	private static IEnumerator<KIBBKCLDIIA> LBMBMOJHODD(string DDFEOCNDAEA, IBOPGHHDJFG FFKDDMJILDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A31100", Offset = "0x6A30500", VA = "0x186A31100")]
	[IteratorStateMachine(typeof(KCEPAAGBCJE))]
	private static IEnumerator<KIBBKCLDIIA> JFHNPCJJGIN(string DDFEOCNDAEA, LoadSceneMode LLCGLOPHPNN, JPPAJGENKOG<Scene> FFKDDMJILDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A30FD0", Offset = "0x6A303D0", VA = "0x186A30FD0")]
	public static bool ILPMBIPJOIG([Out] string COPFDHFJHOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class FPKJNBPALHC
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A33860", Offset = "0x6A32C60", VA = "0x186A33860")]
	public static IDisposable FCBHJMGOCIO(this CFDFEHDBCMN APOKKKDAFKO, float LJBCAOAHIAN, Action<float> MLLOCGHENMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A337E0", Offset = "0x6A32BE0", VA = "0x186A337E0")]
	public static IDisposable DHAGBNHBFHN(this CFDFEHDBCMN APOKKKDAFKO, Action<float> MLLOCGHENMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A338F0", Offset = "0x6A32CF0", VA = "0x186A338F0")]
	public static IDisposable LEJFCGAKENF(this CFDFEHDBCMN APOKKKDAFKO, Action<float> MLLOCGHENMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DGPJBAKKBMI
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F250", Offset = "0x6A2E650", VA = "0x186A2F250")]
	public static IDisposable NMNAIPIDHBF(this MonoBehaviour MCMEMLEPIDO, Action MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F1C0", Offset = "0x6A2E5C0", VA = "0x186A2F1C0")]
	public static IDisposable NMNAIPIDHBF(this MonoBehaviour MCMEMLEPIDO, Action<float> MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EF60", Offset = "0x6A2E360", VA = "0x186A2EF60")]
	public static IDisposable LLBOFPOPBEE(this MonoBehaviour MCMEMLEPIDO, Action MLLOCGHENMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F2E0", Offset = "0x6A2E6E0", VA = "0x186A2F2E0")]
	public static IDisposable NOGINBHHBMM(this MonoBehaviour MCMEMLEPIDO, Action MLLOCGHENMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F360", Offset = "0x6A2E760", VA = "0x186A2F360")]
	public static IDisposable NOGINBHHBMM(this MonoBehaviour MCMEMLEPIDO, Action<float> MLLOCGHENMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EE30", Offset = "0x6A2E230", VA = "0x186A2EE30")]
	public static IDisposable GDLLJNLHKJF(this MonoBehaviour MCMEMLEPIDO, Action MLLOCGHENMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F480", Offset = "0x6A2E880", VA = "0x186A2F480")]
	public static IDisposable PPNFKPMNBGH(this MonoBehaviour MCMEMLEPIDO, Action MLLOCGHENMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EC60", Offset = "0x6A2E060", VA = "0x186A2EC60")]
	public static IDisposable EKIHEDJCNPJ(this MonoBehaviour MCMEMLEPIDO, Action MLLOCGHENMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EEB0", Offset = "0x6A2E2B0", VA = "0x186A2EEB0")]
	public static IDisposable LIEKKFLDCJG(this MonoBehaviour MCMEMLEPIDO, float LJBCAOAHIAN, Action<float> MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID, bool ILALNGIBKJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E960", Offset = "0x6A2DD60", VA = "0x186A2E960")]
	public static IDisposable CGMBFLEMBKI(this MonoBehaviour MCMEMLEPIDO, float LJBCAOAHIAN, Action<float> MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID, bool ILALNGIBKJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EBC0", Offset = "0x6A2DFC0", VA = "0x186A2EBC0")]
	public static IDisposable DLNLFGALDMN(this MonoBehaviour MCMEMLEPIDO, float LJBCAOAHIAN, Action<float> MLLOCGHENMB, bool ILALNGIBKJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EFE0", Offset = "0x6A2E3E0", VA = "0x186A2EFE0")]
	public static IDisposable MEEHMFDPINI(this MonoBehaviour MCMEMLEPIDO, Action<float> MLLOCGHENMB, bool ILALNGIBKJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F3E0", Offset = "0x6A2E7E0", VA = "0x186A2F3E0")]
	public static IDisposable PICEKNKHDLB(this MonoBehaviour MCMEMLEPIDO, Action<float> MLLOCGHENMB, bool ILALNGIBKJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F080", Offset = "0x6A2E480", VA = "0x186A2F080")]
	public static IDisposable MMONJBAFFMD(this MonoBehaviour MCMEMLEPIDO, Action<float> MLLOCGHENMB, bool ILALNGIBKJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A2ECE0", Offset = "0x6A2E0E0", VA = "0x186A2ECE0")]
	public static IDisposable FGJPLHDMBBI(this MonoBehaviour MCMEMLEPIDO, Action<float> MLLOCGHENMB, bool ILALNGIBKJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F120", Offset = "0x6A2E520", VA = "0x186A2F120")]
	public static IDisposable NAPLELKHECI(this MonoBehaviour MCMEMLEPIDO, Action<float> MLLOCGHENMB, bool ILALNGIBKJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EB20", Offset = "0x6A2DF20", VA = "0x186A2EB20")]
	public static IDisposable DAJNBMKANLC(this MonoBehaviour MCMEMLEPIDO, Action<float> MLLOCGHENMB, bool ILALNGIBKJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EA80", Offset = "0x6A2DE80", VA = "0x186A2EA80")]
	public static IDisposable CJPFONPFPJJ(this MonoBehaviour MCMEMLEPIDO, Action<float> MLLOCGHENMB, bool ILALNGIBKJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A2ED80", Offset = "0x6A2E180", VA = "0x186A2ED80")]
	public static IDisposable FIKBMJOFPAE(this MonoBehaviour MCMEMLEPIDO, float LJBCAOAHIAN, Action<float> MLLOCGHENMB, bool ILALNGIBKJP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DDMEKHHEPCK
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class BOEAGLOHOMA : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public IMBICBGFIPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private COLAFJBLEIO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public BOEAGLOHOMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6A293A0", Offset = "0x6A287A0", VA = "0x186A293A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6A29480", Offset = "0x6A28880", VA = "0x186A29480", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class GLCEJIKPJBN : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IMBICBGFIPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private COLAFJBLEIO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public GLCEJIKPJBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6A34020", Offset = "0x6A33420", VA = "0x186A34020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6A34110", Offset = "0x6A33510", VA = "0x186A34110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E6B0", Offset = "0x6A2DAB0", VA = "0x186A2E6B0")]
	public static ELCBICMGPAO NMNAIPIDHBF(Action MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E4D0", Offset = "0x6A2D8D0", VA = "0x186A2E4D0")]
	public static ELCBICMGPAO NMNAIPIDHBF(Behaviour APOKKKDAFKO, Action MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E590", Offset = "0x6A2D990", VA = "0x186A2E590")]
	public static ELCBICMGPAO NMNAIPIDHBF(Behaviour APOKKKDAFKO, Action<float> MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E440", Offset = "0x6A2D840", VA = "0x186A2E440")]
	[IteratorStateMachine(typeof(BOEAGLOHOMA))]
	private static IEnumerator<KIBBKCLDIIA> AOFIGAPKNIC(IMBICBGFIPB PJPBDHLAPEK, Action MLLOCGHENMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E3B0", Offset = "0x6A2D7B0", VA = "0x186A2E3B0")]
	[IteratorStateMachine(typeof(GLCEJIKPJBN))]
	private static IEnumerator<KIBBKCLDIIA> AOFIGAPKNIC(IMBICBGFIPB PJPBDHLAPEK, Action<float> MLLOCGHENMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class POKJCEKEGCH : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class JMKHIKPEHJJ : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public POKJCEKEGCH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public JMKHIKPEHJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A36A90", Offset = "0x6A35E90", VA = "0x186A36A90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A36B20", Offset = "0x6A35F20", VA = "0x186A36B20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly IMBICBGFIPB PIOLGBHJEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action DIHFPNFADGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool HJINLAAAMEJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PKCCHHIOOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C4670", Offset = "0x7C3A70", VA = "0x1807C4670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A41310", Offset = "0x6A40710", VA = "0x186A41310")]
	public POKJCEKEGCH(IMBICBGFIPB PIOLGBHJEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A411F0", Offset = "0x6A405F0", VA = "0x186A411F0")]
	[IteratorStateMachine(typeof(JMKHIKPEHJJ))]
	private IEnumerator<KIBBKCLDIIA> MGCFJBPNGEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6A41270", Offset = "0x6A40670", VA = "0x186A41270", Slot = "4")]
	public void OnCompleted(Action KHFCJAPPBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
	public void OKMCBKNKNCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class ACCOMFJJEIM
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A26CD0", Offset = "0x6A260D0", VA = "0x186A26CD0")]
	public static POKJCEKEGCH IFJFKNHNFJJ(this IMBICBGFIPB PIOLGBHJEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class PJPOCGDDIGE
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class NBHPBJAFMBD : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public MPDKHCMDCKC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public NBHPBJAFMBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CB10", Offset = "0x6A3BF10", VA = "0x186A3CB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CB90", Offset = "0x6A3BF90", VA = "0x186A3CB90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A40E70", Offset = "0x6A40270", VA = "0x186A40E70")]
	public static ELCBICMGPAO NMNAIPIDHBF(float LJBCAOAHIAN, Action<float> MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID, bool ILALNGIBKJP = true, [Optional] GPBJMGNPMAI MKIKJPCBHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A40D60", Offset = "0x6A40160", VA = "0x186A40D60")]
	public static ELCBICMGPAO NMNAIPIDHBF(MonoBehaviour MCMEMLEPIDO, float LJBCAOAHIAN, Action<float> MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID, bool ILALNGIBKJP = true, [Optional] GPBJMGNPMAI MKIKJPCBHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A40F70", Offset = "0x6A40370", VA = "0x186A40F70")]
	public static ELCBICMGPAO PNMIFEJFDOI(MonoBehaviour MCMEMLEPIDO, float LJBCAOAHIAN, Action<float> MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID, bool ILALNGIBKJP = true, [Optional] GPBJMGNPMAI MKIKJPCBHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A40C50", Offset = "0x6A40050", VA = "0x186A40C50")]
	public static ELCBICMGPAO LDBEDLIBJLM(CFDFEHDBCMN APOKKKDAFKO, float LJBCAOAHIAN, Action<float> MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID, bool ILALNGIBKJP = true, [Optional] GPBJMGNPMAI MKIKJPCBHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A40AA0", Offset = "0x6A3FEA0", VA = "0x186A40AA0")]
	private static IEnumerator<KIBBKCLDIIA> AOFIGAPKNIC(FPNGAGEKNPH HDLFHAGLFKK, float LJBCAOAHIAN, IMBICBGFIPB PJPBDHLAPEK, Action<float> MLLOCGHENMB, bool ILALNGIBKJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6A40B60", Offset = "0x6A3FF60", VA = "0x186A40B60")]
	private static IEnumerator<KIBBKCLDIIA> FBKNBPFCLIC(FPNGAGEKNPH HDLFHAGLFKK, float LJBCAOAHIAN, IMBICBGFIPB PJPBDHLAPEK, Action<float> MLLOCGHENMB, bool ILALNGIBKJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A40BC0", Offset = "0x6A3FFC0", VA = "0x186A40BC0")]
	[IteratorStateMachine(typeof(NBHPBJAFMBD))]
	private static IEnumerator<KIBBKCLDIIA> IKEPPOOMDBO(MPDKHCMDCKC EHBMCDBJPOO, float LJBCAOAHIAN, IMBICBGFIPB PJPBDHLAPEK, Action<float> MLLOCGHENMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class NHKCMEKMKGI
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class CIMDJCLNJIF : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public IMBICBGFIPB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public CIMDJCLNJIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6A29E50", Offset = "0x6A29250", VA = "0x186A29E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A29F10", Offset = "0x6A29310", VA = "0x186A29F10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CE60", Offset = "0x6A3C260", VA = "0x186A3CE60")]
	[IteratorStateMachine(typeof(CIMDJCLNJIF))]
	private static IEnumerator<KIBBKCLDIIA> NEFINPCGKAD(IMBICBGFIPB PIOLGBHJEID, Func<bool> MLIHHKGMCFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CD40", Offset = "0x6A3C140", VA = "0x186A3CD40")]
	public static ELCBICMGPAO FOFLPOGDEPF(this MonoBehaviour MCMEMLEPIDO, Func<bool> MLIHHKGMCFH, IMBICBGFIPB PIOLGBHJEID = IMBICBGFIPB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class PPBEPDNGAKA
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class NKNBOAMFBNF : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public IMBICBGFIPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public NKNBOAMFBNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CFE0", Offset = "0x6A3C3E0", VA = "0x186A3CFE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D050", Offset = "0x6A3C450", VA = "0x186A3D050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class IMOELHMCDOM : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public IMBICBGFIPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private KIBBKCLDIIA <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public IMOELHMCDOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6A369B0", Offset = "0x6A35DB0", VA = "0x186A369B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6A36A40", Offset = "0x6A35E40", VA = "0x186A36A40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6A41BB0", Offset = "0x6A40FB0", VA = "0x186A41BB0")]
	[IteratorStateMachine(typeof(NKNBOAMFBNF))]
	private static IEnumerator<KIBBKCLDIIA> MGCFJBPNGEF(float ABEDOEMHLPN, IMBICBGFIPB PJPBDHLAPEK, Action KNFHKDLGIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6A41B10", Offset = "0x6A40F10", VA = "0x186A41B10")]
	[IteratorStateMachine(typeof(IMOELHMCDOM))]
	private static IEnumerator<KIBBKCLDIIA> MCPJOAAHIEI(float ABEDOEMHLPN, IMBICBGFIPB PJPBDHLAPEK, Action KNFHKDLGIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6A41920", Offset = "0x6A40D20", VA = "0x186A41920")]
	public static IDisposable LPBHHDDMPPM(this MonoBehaviour MCMEMLEPIDO, float ABEDOEMHLPN, Action KNFHKDLGIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6A41730", Offset = "0x6A40B30", VA = "0x186A41730")]
	public static ELCBICMGPAO LGGJMFGNHAK(this MonoBehaviour MCMEMLEPIDO, float ABEDOEMHLPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6A417F0", Offset = "0x6A40BF0", VA = "0x186A417F0")]
	public static ELCBICMGPAO LPBHHDDMPPM(this MonoBehaviour MCMEMLEPIDO, float ABEDOEMHLPN, IMBICBGFIPB PJPBDHLAPEK, Action KNFHKDLGIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6A41D20", Offset = "0x6A41120", VA = "0x186A41D20")]
	public static ELCBICMGPAO MMJIGGHCOHG(this MonoBehaviour MCMEMLEPIDO, Action KNFHKDLGIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A41700", Offset = "0x6A40B00", VA = "0x186A41700")]
	public static ELCBICMGPAO LEBLLCPFHBH(this MonoBehaviour MCMEMLEPIDO, Action KNFHKDLGIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A41520", Offset = "0x6A40920", VA = "0x186A41520")]
	public static ELCBICMGPAO EMCJDBGJIIL(this MonoBehaviour MCMEMLEPIDO, Action KNFHKDLGIMJ, [Optional] GPBJMGNPMAI MKIKJPCBHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6A414F0", Offset = "0x6A408F0", VA = "0x186A414F0")]
	public static ELCBICMGPAO CFGBIGIFNOJ(this MonoBehaviour MCMEMLEPIDO, Action KNFHKDLGIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A41600", Offset = "0x6A40A00", VA = "0x186A41600")]
	public static ELCBICMGPAO EOEBPDMKEGP(this MonoBehaviour MCMEMLEPIDO, Action KNFHKDLGIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6A41A40", Offset = "0x6A40E40", VA = "0x186A41A40")]
	private static ELCBICMGPAO MCLLIGHJBGH(MonoBehaviour MCMEMLEPIDO, IMBICBGFIPB PIOLGBHJEID, Action KNFHKDLGIMJ, [Optional] GPBJMGNPMAI MKIKJPCBHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A41D40", Offset = "0x6A41140", VA = "0x186A41D40")]
	public static ELCBICMGPAO PNCALOPFIAE(this MonoBehaviour MCMEMLEPIDO, float NHGNOEOIDJJ, Action KNFHKDLGIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6A41C50", Offset = "0x6A41050", VA = "0x186A41C50")]
	public static ELCBICMGPAO MGFMCOPADIE(this MonoBehaviour MCMEMLEPIDO, float NHGNOEOIDJJ, Action KNFHKDLGIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6A41630", Offset = "0x6A40A30", VA = "0x186A41630")]
	public static ELCBICMGPAO FPAFHHHNIPG(this MonoBehaviour MCMEMLEPIDO, float NHGNOEOIDJJ, Action KNFHKDLGIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6A41420", Offset = "0x6A40820", VA = "0x186A41420")]
	public static ELCBICMGPAO BCBFCMAHHBD(this MonoBehaviour MCMEMLEPIDO, float NHGNOEOIDJJ, Action KNFHKDLGIMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class AFNAHGHOBCG : COCCLJLDAIP, IEnumerable<COCCLJLDAIP>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<COCCLJLDAIP> AAAOBMLMOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool IBKFLNDJHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action HIINMGHNCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool GEGAIKCBBFD;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IOHCCPEBFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6A27100", Offset = "0x6A26500", VA = "0x186A27100", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PEGMCFAJGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6A27060", Offset = "0x6A26460", VA = "0x186A27060", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6A26E10", Offset = "0x6A26210", VA = "0x186A26E10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6A276C0", Offset = "0x6A26AC0", VA = "0x186A276C0")]
	public AFNAHGHOBCG([Optional] Action HIINMGHNCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6A26EB0", Offset = "0x6A262B0", VA = "0x186A26EB0")]
	public void FFIECPFJEFG(COCCLJLDAIP MBCJMKPAHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6A27560", Offset = "0x6A26960", VA = "0x186A27560")]
	private void ONPMKKCBMCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6A27240", Offset = "0x6A26640", VA = "0x186A27240", Slot = "7")]
	public bool OJGEDKLCMEL(bool DOPMCGBECME = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6A27250", Offset = "0x6A26650", VA = "0x186A27250", Slot = "8")]
	public bool OJGEDKLCMEL(Action PNAPELFIIEJ, bool DOPMCGBECME = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6A26FE0", Offset = "0x6A263E0", VA = "0x186A26FE0", Slot = "9")]
	public IEnumerator<COCCLJLDAIP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6A26FE0", Offset = "0x6A263E0", VA = "0x186A26FE0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class IGGAFFMMDCG : GBOANHFIMAK
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class IMNLALMJMLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public IGGAFFMMDCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public IMNLALMJMLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6A36980", Offset = "0x6A35D80", VA = "0x186A36980")]
		internal void BEKHOCEINJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class JCIOPLKOLBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public IGGAFFMMDCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public JCIOPLKOLBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6A36980", Offset = "0x6A35D80", VA = "0x186A36980")]
		internal void LAEJHPCBLNO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float POIPOAIPLDF;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6A362D0", Offset = "0x6A356D0", VA = "0x186A362D0")]
	public IGGAFFMMDCG(Behaviour APOKKKDAFKO, float POIPOAIPLDF, [Optional] Action HIINMGHNCOE, [Optional] GPBJMGNPMAI MKIKJPCBHIN, [Optional] FPNGAGEKNPH HDLFHAGLFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6A361C0", Offset = "0x6A355C0", VA = "0x186A361C0", Slot = "9")]
	protected override bool CLDIEIAIGAJ(Action PNAPELFIIEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6A360B0", Offset = "0x6A354B0", VA = "0x186A360B0", Slot = "10")]
	protected override bool AAHONBABIOJ(Action PNAPELFIIEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface COCCLJLDAIP
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IOHCCPEBFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PEGMCFAJGEF;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OJGEDKLCMEL(bool DOPMCGBECME = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OJGEDKLCMEL(Action PNAPELFIIEJ, bool DOPMCGBECME = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class GBOANHFIMAK : COCCLJLDAIP
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class OCIIPDGOGAE : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public GBOANHFIMAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public OCIIPDGOGAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FCC0", Offset = "0x6A3F0C0", VA = "0x186A3FCC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FD90", Offset = "0x6A3F190", VA = "0x186A3FD90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour APOKKKDAFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action HIINMGHNCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private PNIFBLNEOAP CHENJIHABNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly GPBJMGNPMAI MKIKJPCBHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly FPNGAGEKNPH HDLFHAGLFKK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool IOHCCPEBFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xF99250", Offset = "0xF98650", VA = "0x180F99250", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action PEGMCFAJGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6A33D30", Offset = "0x6A33130", VA = "0x186A33D30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6A33970", Offset = "0x6A32D70", VA = "0x186A33970", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6A33F20", Offset = "0x6A33320", VA = "0x186A33F20")]
	protected GBOANHFIMAK(Behaviour APOKKKDAFKO, [Optional] Action HIINMGHNCOE, [Optional] GPBJMGNPMAI MKIKJPCBHIN, [Optional] FPNGAGEKNPH HDLFHAGLFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6A33EC0", Offset = "0x6A332C0", VA = "0x186A33EC0", Slot = "7")]
	public bool OJGEDKLCMEL(bool DOPMCGBECME = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6A33E60", Offset = "0x6A33260", VA = "0x186A33E60", Slot = "8")]
	public bool OJGEDKLCMEL(Action PNAPELFIIEJ, bool DOPMCGBECME = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool CLDIEIAIGAJ(Action PNAPELFIIEJ);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool AAHONBABIOJ(Action PNAPELFIIEJ);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6A33D10", Offset = "0x6A33110", VA = "0x186A33D10")]
	protected void MHAPBGNFPOO(Action PNAPELFIIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6A33AD0", Offset = "0x6A32ED0", VA = "0x186A33AD0")]
	protected PEMLHLMJEJH KLPIIJJCIFB(float NBODOCDJMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6A33A50", Offset = "0x6A32E50", VA = "0x186A33A50")]
	private void KFJIINIIPKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6A33DD0", Offset = "0x6A331D0", VA = "0x186A33DD0")]
	[IteratorStateMachine(typeof(OCIIPDGOGAE))]
	private IEnumerator<KIBBKCLDIIA> OEECFDJEDNP(float NBODOCDJMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6A33A10", Offset = "0x6A32E10", VA = "0x186A33A10")]
	[CompilerGenerated]
	private void HOOLCANFFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class MLBEIEMHOCP : GBOANHFIMAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float DAMLDLBOIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int BBMHIJGIDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float GFCKBCLIKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] ACKLFGKNCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int OOEIONPECEI;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C500", Offset = "0x6A3B900", VA = "0x186A3C500")]
	public MLBEIEMHOCP(Behaviour APOKKKDAFKO, float POBLCDNGHBN, int BBMHIJGIDFJ, [Optional] Action HIINMGHNCOE, float GFCKBCLIKCK = 0f, [Optional] GPBJMGNPMAI MKIKJPCBHIN, [Optional] FPNGAGEKNPH HDLFHAGLFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "9")]
	protected override bool CLDIEIAIGAJ(Action PNAPELFIIEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C280", Offset = "0x6A3B680", VA = "0x186A3C280", Slot = "10")]
	protected override bool AAHONBABIOJ(Action PNAPELFIIEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C480", Offset = "0x6A3B880", VA = "0x186A3C480")]
	private void GDNPFKGECBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class PNFALHCMAGI : GBOANHFIMAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float POIPOAIPLDF;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6A362D0", Offset = "0x6A356D0", VA = "0x186A362D0")]
	public PNFALHCMAGI(Behaviour APOKKKDAFKO, float POIPOAIPLDF, [Optional] Action HIINMGHNCOE, [Optional] GPBJMGNPMAI MKIKJPCBHIN, [Optional] FPNGAGEKNPH HDLFHAGLFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "9")]
	protected override bool CLDIEIAIGAJ(Action PNAPELFIIEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6A411B0", Offset = "0x6A405B0", VA = "0x186A411B0", Slot = "10")]
	protected override bool AAHONBABIOJ(Action PNAPELFIIEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class MKLCKPLFGCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class DLFCFBBBBHJ : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public DLFCFBBBBHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6A285F0", Offset = "0x6A279F0", VA = "0x186A285F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6A2F500", Offset = "0x6A2E900", VA = "0x186A2F500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private ELCBICMGPAO DLOKBFKMGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private CFDFEHDBCMN APOKKKDAFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> MGJNFGLHPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private IMBICBGFIPB PIOLGBHJEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float FHDFJALFECB;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C0A0", Offset = "0x6A3B4A0", VA = "0x186A3C0A0")]
	public MKLCKPLFGCB(CFDFEHDBCMN APOKKKDAFKO, float LJBCAOAHIAN, Action<float> MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BB10", Offset = "0x6A3AF10", VA = "0x186A3BB10")]
	private void DIMJNMPGFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BD90", Offset = "0x6A3B190", VA = "0x186A3BD90")]
	private void KCAPJIFMNFD(string NBDBHDLNPOA, Action PBCAADCCADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BD10", Offset = "0x6A3B110", VA = "0x186A3BD10")]
	[IteratorStateMachine(typeof(DLFCFBBBBHJ))]
	private IEnumerator<KIBBKCLDIIA> JEJOOIINOLE(Action PBCAADCCADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BCB0", Offset = "0x6A3B0B0", VA = "0x186A3BCB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BEF0", Offset = "0x6A3B2F0", VA = "0x186A3BEF0")]
	[CompilerGenerated]
	private void NJLGKHKPFBF(string KDFDGCCFNMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class MIMGEKKAIDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BCOODIAEMDE : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public BCOODIAEMDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6A285F0", Offset = "0x6A279F0", VA = "0x186A285F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6A28660", Offset = "0x6A27A60", VA = "0x186A28660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private ELCBICMGPAO DLOKBFKMGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour MCMEMLEPIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action MLLOCGHENMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> MGJNFGLHPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private IMBICBGFIPB PIOLGBHJEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float FHDFJALFECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool ILALNGIBKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly GPBJMGNPMAI MKIKJPCBHIN;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B6D0", Offset = "0x6A3AAD0", VA = "0x186A3B6D0")]
	public MIMGEKKAIDN(MonoBehaviour MCMEMLEPIDO, Action MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID, [Optional] GPBJMGNPMAI MKIKJPCBHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B490", Offset = "0x6A3A890", VA = "0x186A3B490")]
	public MIMGEKKAIDN(MonoBehaviour MCMEMLEPIDO, Action<float> MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID, [Optional] GPBJMGNPMAI MKIKJPCBHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B8C0", Offset = "0x6A3ACC0", VA = "0x186A3B8C0")]
	public MIMGEKKAIDN(MonoBehaviour MCMEMLEPIDO, float LJBCAOAHIAN, Action<float> MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID, bool ILALNGIBKJP = true, [Optional] GPBJMGNPMAI MKIKJPCBHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x19F8930", Offset = "0x19F7D30", VA = "0x1819F8930")]
	private MIMGEKKAIDN(GPBJMGNPMAI MKIKJPCBHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AD70", Offset = "0x6A3A170", VA = "0x186A3AD70")]
	internal static MIMGEKKAIDN GJEDGPNMNND(MonoBehaviour MCMEMLEPIDO, float LJBCAOAHIAN, Action<float> MLLOCGHENMB, IMBICBGFIPB PIOLGBHJEID, bool ILALNGIBKJP = true, [Optional] GPBJMGNPMAI MKIKJPCBHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B320", Offset = "0x6A3A720", VA = "0x186A3B320")]
	private void NMNAIPIDHBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B170", Offset = "0x6A3A570", VA = "0x186A3B170")]
	private void NHEPJANDBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AAD0", Offset = "0x6A39ED0", VA = "0x186A3AAD0")]
	private void DIMJNMPGFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A880", Offset = "0x6A39C80", VA = "0x186A3A880")]
	private void BILHMJIFIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AF20", Offset = "0x6A3A320", VA = "0x186A3AF20")]
	private void KCAPJIFMNFD(string NBDBHDLNPOA, Action PBCAADCCADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AEA0", Offset = "0x6A3A2A0", VA = "0x186A3AEA0")]
	[IteratorStateMachine(typeof(BCOODIAEMDE))]
	private IEnumerator<KIBBKCLDIIA> JEJOOIINOLE(Action PBCAADCCADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AC80", Offset = "0x6A3A080", VA = "0x186A3AC80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B050", Offset = "0x6A3A450", VA = "0x186A3B050")]
	[CompilerGenerated]
	private void LKLIKKGFHPN(string KDFDGCCFNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AA40", Offset = "0x6A39E40", VA = "0x186A3AA40")]
	[CompilerGenerated]
	private void CMDHAAEGKPG(string KDFDGCCFNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ACE0", Offset = "0x6A3A0E0", VA = "0x186A3ACE0")]
	[CompilerGenerated]
	private void EHHOBBPKLHK(string KDFDGCCFNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B0E0", Offset = "0x6A3A4E0", VA = "0x186A3B0E0")]
	[CompilerGenerated]
	private void MHFCINJNKIK(string KDFDGCCFNMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum LKCAALHEIPA : byte
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
internal sealed class IIGAHPNGNGG : FPNGAGEKNPH
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float KMBPNPEHFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6A36760", Offset = "0x6A35B60", VA = "0x186A36760", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float GOPPJEEMOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6A36770", Offset = "0x6A35B70", VA = "0x186A36770", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double PAFOEHCLHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6A366D0", Offset = "0x6A35AD0", VA = "0x186A366D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6A366F0", Offset = "0x6A35AF0", VA = "0x186A366F0")]
	[AMCIKKJLCIB(HENHDGEOMOC.None)]
	private static void ICLFDKDIFAJ(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	[Preserve]
	internal IIGAHPNGNGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface IPAGNOHGCPK
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOIPNNNBGFI(string CCNKHEJHFKM);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFNEDJDOKPK();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface LDDFCJNMMEE
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool GFOFEGAGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool KBPOOLOPDAN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class PANBGFCFOCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public NMPNDDEBEOL FJCECEKLDND;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int LCMFLKBKPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC180", Offset = "0x7BB580", VA = "0x1807BC180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5B90", VA = "0x1807C6790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6A40880", Offset = "0x6A3FC80", VA = "0x186A40880")]
	public static KIBBKCLDIIA KLFAGNCNAID(IEnumerator<KIBBKCLDIIA> GBCKPJGHFDG, OPFCCIILPBM DEBIBDMFCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6A409E0", Offset = "0x6A3FDE0", VA = "0x186A409E0")]
	public KIBBKCLDIIA KLFAGNCNAID(OPFCCIILPBM[] NGPAJCAJFLH, IEnumerator<KIBBKCLDIIA>[] ALIEKFHFPFD, KIBBKCLDIIA[] EMPIMHABMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6A405D0", Offset = "0x6A3F9D0", VA = "0x186A405D0")]
	public void JMGMJDFGEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6A40600", Offset = "0x6A3FA00", VA = "0x186A40600")]
	public void DLJEDPBKJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6A40740", Offset = "0x6A3FB40", VA = "0x186A40740")]
	public void FHKMGADMKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6A405D0", Offset = "0x6A3F9D0", VA = "0x186A405D0")]
	public void BFKHLHMCMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public PANBGFCFOCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class NMPNDDEBEOL
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct HKPLIFNAOCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public PANBGFCFOCJ DDHDBAKHDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public CFDFEHDBCMN NOIIGDPCIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public OPFCCIILPBM KNOEPLNBAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<KIBBKCLDIIA> GIFEMKCPFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public KIBBKCLDIIA OBJGHPPFHGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public LKCAALHEIPA HEGEECLDLNL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct HKCOOALACMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IMBICBGFIPB FAEPBALHOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<HKPLIFNAOCJ> AKGNLCMMGNB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JODDFMDDHEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public OPFCCIILPBM promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public NMPNDDEBEOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public CFDFEHDBCMN context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public PANBGFCFOCJ routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public LKCAALHEIPA coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public KIBBKCLDIIA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<KIBBKCLDIIA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public JODDFMDDHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A36B70", Offset = "0x6A35F70", VA = "0x186A36B70")]
		internal void NKDABJFJBDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class NPEFBFMOIKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public PANBGFCFOCJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public NMPNDDEBEOL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public NPEFBFMOIKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FA50", Offset = "0x6A3EE50", VA = "0x186A3FA50")]
		internal void GACDJBIMAEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class BBCBCNAIDAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public PANBGFCFOCJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public NMPNDDEBEOL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public BBCBCNAIDAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A285B0", Offset = "0x6A279B0", VA = "0x186A285B0")]
		internal void PCHFBNBBIDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class GNJNOCGFJGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public PANBGFCFOCJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public NMPNDDEBEOL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public GNJNOCGFJGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A34D70", Offset = "0x6A34170", VA = "0x186A34D70")]
		internal void JOAPCDBGMDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const LKCAALHEIPA MKJOEMLBECO = LKCAALHEIPA.Cancelled | LKCAALHEIPA.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly IMBICBGFIPB PIOLGBHJEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] EEJCEJOHOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<LKCAALHEIPA> IEAHNBPHLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> ACOCGBJKEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> CLCAKMDNJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> CGDIPDONICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> PCOPJFBAAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> KGFNEBMJPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> FLJAGJPDCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private PANBGFCFOCJ[] DGOEMDPNOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private OPFCCIILPBM[] NGPAJCAJFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private CFDFEHDBCMN[] NCBMIKPDGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<KIBBKCLDIIA>[] EELEAHLENIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private KIBBKCLDIIA[] POCCBILAOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int MEBMHBHMEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int MIFMOLKOCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int FNLKBKJHEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float NPKPHKIBGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private AJLMFMBCENG HPOJIALPAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle FCOOFLEIDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<PANBGFCFOCJ> PADAKHOIMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool LIJIPBIAGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> EHOEOGBDDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> FBBNMMPPGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool NJCCKMPDCLF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public HKCOOALACMB[] GOKJAIONLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9B1560", Offset = "0x9B0960", VA = "0x1809B1560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D570", Offset = "0x6A3C970", VA = "0x186A3D570")]
	private static int GJHGGAMICFN(IMBICBGFIPB PIOLGBHJEID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F400", Offset = "0x6A3E800", VA = "0x186A3F400")]
	public NMPNDDEBEOL(IMBICBGFIPB PIOLGBHJEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D2D0", Offset = "0x6A3C6D0", VA = "0x186A3D2D0")]
	private void CKHHPKMLINJ(int GKGJPLPIKIP, int IGBBHDGBGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F050", Offset = "0x6A3E450", VA = "0x186A3F050")]
	public void MNJOGCOBGON(CFDFEHDBCMN APOKKKDAFKO, KIBBKCLDIIA MGGPHGBCGLH, IEnumerator<KIBBKCLDIIA> GBCKPJGHFDG, OPFCCIILPBM DEBIBDMFCGM, [Optional] PANBGFCFOCJ EPBAECFMHHH, LKCAALHEIPA NPLIMEHAPHE = LKCAALHEIPA.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EA70", Offset = "0x6A3DE70", VA = "0x186A3EA70")]
	public void LALIDEJFDOI(IEnumerable<HKPLIFNAOCJ> CPJGPCGCJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D5A0", Offset = "0x6A3C9A0", VA = "0x186A3D5A0")]
	private HKPLIFNAOCJ GLPGDFNIPJA(int LLKDIEFMHAM)
	{
		return default(HKPLIFNAOCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E000", Offset = "0x6A3D400", VA = "0x186A3E000")]
	private void KCLOJDBDMNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2924370", Offset = "0x2923770", VA = "0x182924370")]
	private static void ODPAPJEGHJD<T>(int LLKDIEFMHAM, T[] JEGPJPNANON, int HIAJHKACHMC, [Optional] T NOAFHKPFPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x29243C0", Offset = "0x29237C0", VA = "0x1829243C0")]
	private static void ODPAPJEGHJD<T>(int LLKDIEFMHAM, NativeArray<T> JEGPJPNANON, int HIAJHKACHMC, [Optional] T NOAFHKPFPOB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ECB0", Offset = "0x6A3E0B0", VA = "0x186A3ECB0")]
	private void LANIIBCKKHK(IEnumerable<HKPLIFNAOCJ> CPJGPCGCJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D4B0", Offset = "0x6A3C8B0", VA = "0x186A3D4B0")]
	private void DJKILBOIHIE(HKPLIFNAOCJ JJMGENMCFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DA70", Offset = "0x6A3CE70", VA = "0x186A3DA70")]
	private NGKGAGOOJKO JCPMIEPIABE(int PHIIDLDNPHO)
	{
		return default(NGKGAGOOJKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DE00", Offset = "0x6A3D200", VA = "0x186A3DE00")]
	public void KBEJALHNBCP(float OLNGMPNNPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F250", Offset = "0x6A3E650", VA = "0x186A3F250")]
	private void NMFDCIBLMFL(Action HKHMJOHPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F1D0", Offset = "0x6A3E5D0", VA = "0x186A3F1D0")]
	private void NBOGLLCAOBN(Action HKHMJOHPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E370", Offset = "0x6A3D770", VA = "0x186A3E370")]
	public void KKOIELIBPEC(float OLNGMPNNPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D0A0", Offset = "0x6A3C4A0", VA = "0x186A3D0A0")]
	public void ALKBFJGPGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D1A0", Offset = "0x6A3C5A0", VA = "0x186A3D1A0")]
	public void BFKHLHMCMML(PANBGFCFOCJ EHBMCDBJPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F2D0", Offset = "0x6A3E6D0", VA = "0x186A3F2D0")]
	public void OFEOBCCIFHA(PANBGFCFOCJ EHBMCDBJPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DCD0", Offset = "0x6A3D0D0", VA = "0x186A3DCD0")]
	public void JJLDKJDMPNC(PANBGFCFOCJ EHBMCDBJPOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class CIEOFMGGJJI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly CIEOFMGGJJI CCDCOKAGGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action JDBCMGBJBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool KFEECCNBOJI;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public CIEOFMGGJJI(Action JDBCMGBJBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x62626B0", Offset = "0x6261AB0", VA = "0x1862626B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface BAGLKANPOBN<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T EIHNEEOMIED
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable EFPCJENKJDI(UnityEngine.Object APOKKKDAFKO, Action<T> PPJPGDIALAJ);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface LNKEHJFDICF<T> : BAGLKANPOBN<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T EIHNEEOMIED
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class HCBILEHONNI<T> : LNKEHJFDICF<T>, BAGLKANPOBN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class BCLKDJDIKOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public HCBILEHONNI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public BLMCJPAANMI<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public BCLKDJDIKOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x47FDD80", Offset = "0x47FD180", VA = "0x1847FDD80")]
		internal void FPEIIOOHOAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject AFFBLDOACJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<BLMCJPAANMI<UnityEngine.Object, Action<T>>> MIAFJLGLEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T CGBDFJPNKEH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T EIHNEEOMIED
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x827D00", Offset = "0x827100", VA = "0x180827D00", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3841500", Offset = "0x3840900", VA = "0x183841500", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3841430", Offset = "0x3840830", VA = "0x183841430")]
	private static bool JBHECIELPAK(T HKHMJOHPMKP, T GJKNLEMINPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3841600", Offset = "0x3840A00", VA = "0x183841600")]
	public HCBILEHONNI(T IGKALEOAIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3841270", Offset = "0x3840670", VA = "0x183841270", Slot = "6")]
	public IDisposable EFPCJENKJDI(UnityEngine.Object APOKKKDAFKO, Action<T> PPJPGDIALAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3840DB0", Offset = "0x38401B0", VA = "0x183840DB0")]
	private void AHCNPBDKHOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class APJKJEKKMNI : HLMCPHKOMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly GPBJMGNPMAI MKIKJPCBHIN;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A284F0", Offset = "0x6A278F0", VA = "0x186A284F0")]
	[AMCIKKJLCIB(HENHDGEOMOC.None)]
	private static void ICLFDKDIFAJ(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	[Preserve]
	internal APJKJEKKMNI([AKGMOFMFNCG(null)] GPBJMGNPMAI MKIKJPCBHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A28440", Offset = "0x6A27840", VA = "0x186A28440", Slot = "4")]
	public IDisposable DLNLFGALDMN(float LJBCAOAHIAN, Action<float> KCNCNEMPBGA, bool ILALNGIBKJP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class BIDBMBOPADA : KMBLFOKEEIO, GPBJMGNPMAI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NMPNDDEBEOL[] CCCECAGLJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private IPAGNOHGCPK FBOJLFOKKDA;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A29050", Offset = "0x6A28450", VA = "0x186A29050")]
	[AMCIKKJLCIB(HENHDGEOMOC.None)]
	private static void ICLFDKDIFAJ(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A292E0", Offset = "0x6A286E0", VA = "0x186A292E0")]
	[Preserve]
	public BIDBMBOPADA([AKGMOFMFNCG(null)] ACBLFGIBDCK INNAGHOKEGJ, [AKGMOFMFNCG(null)] FPNGAGEKNPH HDLFHAGLFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A288E0", Offset = "0x6A27CE0", VA = "0x186A288E0", Slot = "16")]
	public override ELCBICMGPAO BJOACBPCPDP(CFDFEHDBCMN APOKKKDAFKO, IEnumerator<KIBBKCLDIIA> MKMBDFFMAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A28DC0", Offset = "0x6A281C0", VA = "0x186A28DC0", Slot = "17")]
	public override void HIHHBKCGMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A28A10", Offset = "0x6A27E10", VA = "0x186A28A10", Slot = "19")]
	public override void CPPNENNLAHM(IMBICBGFIPB PIOLGBHJEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A29140", Offset = "0x6A28540", VA = "0x186A29140", Slot = "18")]
	protected override void LLBOFPOPBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A292B0", Offset = "0x6A286B0", VA = "0x186A292B0")]
	private NMPNDDEBEOL ODNBMCOJGNH(IMBICBGFIPB NBMJAHOKHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A286B0", Offset = "0x6A27AB0", VA = "0x186A286B0", Slot = "20")]
	internal override EEMENPBPPIK AMFLLOAIBEN(IEnumerator<KIBBKCLDIIA> MKMBDFFMAAI, Behaviour APOKKKDAFKO, OPFCCIILPBM DEBIBDMFCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A290C0", Offset = "0x6A284C0", VA = "0x186A290C0", Slot = "21")]
	internal override FBNACFAOGDD KIMLNMIPPDD(IMBICBGFIPB PJPBDHLAPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A28CA0", Offset = "0x6A280A0", VA = "0x186A28CA0")]
	private void FAFLEGLCBCN(NMPNDDEBEOL DCBNALDJPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A28C40", Offset = "0x6A28040", VA = "0x186A28C40", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct AJLMFMBCENG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float HDANMMNDKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int OBABBGEFCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> AILABFKLJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> FJLEIAEHPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> FFCOLHHNGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<LKCAALHEIPA> MLPFLBNDNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> FBBJOJNECIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> PCOPJFBAAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> CLCAKMDNJNG;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A281B0", Offset = "0x6A275B0", VA = "0x186A281B0")]
	public static AJLMFMBCENG HEJOOLMEDMH(int AECKCMALEGP, float OLNGMPNNPCA, NativeArray<LKCAALHEIPA> MBNOGHOONAA, NativeArray<float> MBLIPDAKHDC, NativeArray<int> MGLPKMNMHGK, NativeArray<int> JDFEKFBMJFF, NativeArray<int> KHANOCNIIBM, NativeArray<int> FJLEIAEHPKF, NativeArray<int> FFCOLHHNGND)
	{
		return default(AJLMFMBCENG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A280D0", Offset = "0x6A274D0", VA = "0x186A280D0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A27CE0", Offset = "0x6A270E0", VA = "0x186A27CE0")]
	private bool BBJPDKLIJIA(int PMLKPJNGBAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A28210", Offset = "0x6A27610", VA = "0x186A28210")]
	private void OGDKCJFHOLK(NativeArray<int> NCFKHLBNIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A27F60", Offset = "0x6A27360", VA = "0x186A27F60")]
	private int CMOJNDAFGGE(int GDEAOHOEHAB, int ELECFOEKECF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A28000", Offset = "0x6A27400", VA = "0x186A28000")]
	private void DNIMJFENDIO(NativeArray<int> NCFKHLBNIHO, int ODHKDLALJNC, int ODIMBMMGNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A27D20", Offset = "0x6A27120", VA = "0x186A27D20")]
	private void BHJDDNJOADC(NativeArray<int> NCFKHLBNIHO, int GPHEHCHKLDH, int DCBNGKHGNDH, int OBIECPJKFGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class KMBLFOKEEIO : GPBJMGNPMAI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly ACBLFGIBDCK INNAGHOKEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly FPNGAGEKNPH HDLFHAGLFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private FBNACFAOGDD[] PMGANBHIAFN;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static GPBJMGNPMAI GDCHCCJBKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A38460", Offset = "0x6A37860", VA = "0x186A38460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool PEJFPPKJLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IMBICBGFIPB HOMCJLKPEOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7BC180", Offset = "0x7BB580", VA = "0x1807BC180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(IMBICBGFIPB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5B90", VA = "0x1807C6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public FPNGAGEKNPH NGBMDCFLHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public KIBBKCLDIIA PKFKFJOKNBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A38B90", Offset = "0x6A37F90", VA = "0x186A38B90")]
	public static ELCBICMGPAO LCLNFIBGLPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A38F30", Offset = "0x6A38330", VA = "0x186A38F30")]
	[Preserve]
	protected KMBLFOKEEIO([AKGMOFMFNCG(null)] ACBLFGIBDCK INNAGHOKEGJ, [AKGMOFMFNCG(null)] FPNGAGEKNPH HDLFHAGLFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A38960", Offset = "0x6A37D60", VA = "0x186A38960", Slot = "6")]
	public ELCBICMGPAO KFNIOKHILDK(IEnumerator<KIBBKCLDIIA> MKMBDFFMAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A38970", Offset = "0x6A37D70", VA = "0x186A38970", Slot = "7")]
	public ELCBICMGPAO KFNIOKHILDK(Behaviour APOKKKDAFKO, IEnumerator<KIBBKCLDIIA> MKMBDFFMAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract ELCBICMGPAO BJOACBPCPDP(CFDFEHDBCMN APOKKKDAFKO, IEnumerator<KIBBKCLDIIA> MKMBDFFMAAI);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A386C0", Offset = "0x6A37AC0", VA = "0x186A386C0", Slot = "17")]
	public virtual void HIHHBKCGMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A38C20", Offset = "0x6A38020", VA = "0x186A38C20", Slot = "9")]
	public void LKKIFMEPLJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A38E60", Offset = "0x6A38260", VA = "0x186A38E60", Slot = "18")]
	protected virtual void LLBOFPOPBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A388C0", Offset = "0x6A37CC0", VA = "0x186A388C0")]
	private void IONGCAPFNIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A388E0", Offset = "0x6A37CE0", VA = "0x186A388E0")]
	private void KFLNLOANHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A38E80", Offset = "0x6A38280", VA = "0x186A38E80")]
	private void NOGINBHHBMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6A386A0", Offset = "0x6A37AA0", VA = "0x186A386A0")]
	private void GDLLJNLHKJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A37FF0", Offset = "0x6A373F0", VA = "0x186A37FF0")]
	private void ALPFIAFLKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A38680", Offset = "0x6A37A80", VA = "0x186A38680")]
	private void FLKGNLIJGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A38B70", Offset = "0x6A37F70", VA = "0x186A38B70")]
	private void KIAAHKMECGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A38010", Offset = "0x6A37410", VA = "0x186A38010", Slot = "19")]
	public virtual void CPPNENNLAHM(IMBICBGFIPB PIOLGBHJEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A384B0", Offset = "0x6A378B0", VA = "0x186A384B0")]
	private void EOLFKIAEGOP(FBNACFAOGDD DCBNALDJPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9D20", Offset = "0x1CF9120", VA = "0x181CF9D20")]
	private FBNACFAOGDD LIPIECMHOHC(IMBICBGFIPB NBMJAHOKHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract EEMENPBPPIK AMFLLOAIBEN(IEnumerator<KIBBKCLDIIA> MKMBDFFMAAI, Behaviour MCMEMLEPIDO, OPFCCIILPBM PGMIIMCPDKH);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract FBNACFAOGDD KIMLNMIPPDD(IMBICBGFIPB PIOLGBHJEID);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A380A0", Offset = "0x6A374A0", VA = "0x186A380A0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A38860", Offset = "0x6A37C60", VA = "0x186A38860", Slot = "12")]
	public KIBBKCLDIIA ILDBEBHCHHM(IMBICBGFIPB PJPBDHLAPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A38EA0", Offset = "0x6A382A0", VA = "0x186A38EA0", Slot = "13")]
	public KIBBKCLDIIA OHMGJEJKEMM(float ABEDOEMHLPN, IMBICBGFIPB PJPBDHLAPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A38900", Offset = "0x6A37D00", VA = "0x186A38900", Slot = "14")]
	public KIBBKCLDIIA KFNFMHJEOLK(Func<bool> MLIHHKGMCFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class EEMENPBPPIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly OPFCCIILPBM DEBIBDMFCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly LDDFCJNMMEE APOKKKDAFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool GAOFGNJFAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string CCNKHEJHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace IFPEGOBJKGO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<KIBBKCLDIIA> GIFEMKCPFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public KIBBKCLDIIA OBJGHPPFHGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool FDIDDKODNLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6A2FCD0", Offset = "0x6A2F0D0", VA = "0x186A2FCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool HGEOEJLJHGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8835C0", VA = "0x1808841C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8842E0", Offset = "0x8836E0", VA = "0x1808842E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A2F7A0", Offset = "0x6A2EBA0", VA = "0x186A2F7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float GAHBJJFFEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x111C820", Offset = "0x111BC20", VA = "0x18111C820")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x57B1F20", Offset = "0x57B1320", VA = "0x1857B1F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FE30", Offset = "0x6A2F230", VA = "0x186A2FE30")]
	public EEMENPBPPIK(IEnumerator<KIBBKCLDIIA> GBCKPJGHFDG, LDDFCJNMMEE APOKKKDAFKO, OPFCCIILPBM DEBIBDMFCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F950", Offset = "0x6A2ED50", VA = "0x186A2F950")]
	public KIBBKCLDIIA KLFAGNCNAID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FC60", Offset = "0x6A2F060", VA = "0x186A2FC60")]
	public bool NBLIMEGIFDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F750", Offset = "0x6A2EB50", VA = "0x186A2F750")]
	public void BFKHLHMCMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FD50", Offset = "0x6A2F150", VA = "0x186A2FD50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x9133F0", Offset = "0x9127F0", VA = "0x1809133F0")]
	[CompilerGenerated]
	private void MCCBDBEPKMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class OPFCCIILPBM : OOCMEECPDFJ, ELCBICMGPAO, PNIFBLNEOAP, PEMLHLMJEJH, IEnumerator, KIBBKCLDIIA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private IMBICBGFIPB BHCFONMCJLH;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private IMBICBGFIPB NPGCHGFNPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xEB4470", Offset = "0xEB3870", VA = "0x180EB4470", Slot = "23")]
		get
		{
			return default(IMBICBGFIPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IMBICBGFIPB FJCECEKLDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x13A4DA0", Offset = "0x13A41A0", VA = "0x1813A4DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float ALKHHHBGCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBB0", Offset = "0x8CDFB0", VA = "0x1808CEBB0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool BFLMMBJNLPI
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6A40560", Offset = "0x6A3F960", VA = "0x186A40560", Slot = "24")]
	private bool HPADPMFDOCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6A40550", Offset = "0x6A3F950", VA = "0x186A40550", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6A40580", Offset = "0x6A3F980", VA = "0x186A40580")]
	public OPFCCIILPBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum NGKGAGOOJKO : byte
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
internal sealed class FBNACFAOGDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum CBOGMMMOJNG
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct ICFNJCEDBKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public IMBICBGFIPB FAEPBALHOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CBOGMMMOJNG GMPMJDLONHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<EEMENPBPPIK> FKIHMMIJDGJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly CBOGMMMOJNG[] DHDLEJILOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly IMBICBGFIPB PIOLGBHJEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool DNFFGCLEHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly EEMENPBPPIK[] DMBCIJBEGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<EEMENPBPPIK> LHMIEEAOABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> MKDJIBAHKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<EEMENPBPPIK> BLHNNOJEAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> JIFKLJEEPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly IPAGNOHGCPK EELDCFFHCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool NJCCKMPDCLF;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public ICFNJCEDBKB[,] DDDFBNFBDHC
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6A33050", Offset = "0x6A32450", VA = "0x186A33050")]
	public FBNACFAOGDD(IMBICBGFIPB PJPBDHLAPEK, IPAGNOHGCPK EELDCFFHCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6A31DE0", Offset = "0x6A311E0", VA = "0x186A31DE0")]
	public void EOGMNDNFEPO(EEMENPBPPIK GBCKPJGHFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6A32330", Offset = "0x6A31730", VA = "0x186A32330")]
	public void GIEMHBOIBME(IList<EEMENPBPPIK> ALIEKFHFPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6A32020", Offset = "0x6A31420", VA = "0x186A32020")]
	public void FIIIJIOAEII(IList<EEMENPBPPIK> ALIEKFHFPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6A32B20", Offset = "0x6A31F20", VA = "0x186A32B20")]
	private void NFKDFFBJCJA(EEMENPBPPIK GBCKPJGHFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6A31B30", Offset = "0x6A30F30", VA = "0x186A31B30")]
	private void DKLFMLMIOBC(IList<EEMENPBPPIK> ALIEKFHFPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6A329A0", Offset = "0x6A31DA0", VA = "0x186A329A0")]
	private NGKGAGOOJKO LLFEFOPGCMB(EEMENPBPPIK GBCKPJGHFDG)
	{
		return default(NGKGAGOOJKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6A32830", Offset = "0x6A31C30", VA = "0x186A32830")]
	public void LLBOFPOPBEE(float OLNGMPNNPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6A32640", Offset = "0x6A31A40", VA = "0x186A32640")]
	public void LKKIFMEPLJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6A32C10", Offset = "0x6A32010", VA = "0x186A32C10")]
	private void PKDGPOPKDIM(List<EEMENPBPPIK> ALIEKFHFPFD, Stack<int> CNBDJCKCNEP, bool BJLHIMPCIFL, float DFPPJHLJFEI = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6A31CC0", Offset = "0x6A310C0", VA = "0x186A31CC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6A31EE0", Offset = "0x6A312E0", VA = "0x186A31EE0")]
	private void FBKDCILBPHK(List<EEMENPBPPIK> ALIEKFHFPFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class KMPDGOBIOKP : IPAGNOHGCPK
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
	public void AOIPNNNBGFI(string CCNKHEJHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
	public void LFNEDJDOKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public KMPDGOBIOKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class NIKMLPKLDLM : LDDFCJNMMEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour MCMEMLEPIDO;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CF60", Offset = "0x6A3C360", VA = "0x186A3CF60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GFOFEGAGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CEF0", Offset = "0x6A3C2F0", VA = "0x186A3CEF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool KBPOOLOPDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CF40", Offset = "0x6A3C340", VA = "0x186A3CF40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public NIKMLPKLDLM(Behaviour MCMEMLEPIDO)
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

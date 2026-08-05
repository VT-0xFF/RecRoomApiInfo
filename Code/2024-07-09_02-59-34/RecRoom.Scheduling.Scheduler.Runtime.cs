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
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private delegate List<PlayerLoopSystem> EMKKIGDMMNI(List<PlayerLoopSystem> EDDFMDNAIHP, int LCDGAHOEGLD);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct OHACEEAFAGI
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct DMMDLBBGCOD
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static MMAIJBDFGNK IMCOPBILOKM;

				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x72F3210", Offset = "0x72F1E10", VA = "0x1872F3210")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct JLCMDBJAHEH
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static MMAIJBDFGNK GNINFHADBDF;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x72FBF80", Offset = "0x72FAB80", VA = "0x1872FBF80")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct BENKCDOICDG
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static MMAIJBDFGNK KNFLAMHGCND;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x72ED7A0", Offset = "0x72EC3A0", VA = "0x1872ED7A0")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct HNBIDDDJDDL
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static MMAIJBDFGNK MHFEFOEOGDE;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static MMAIJBDFGNK NEOFKGKFNAL;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static MMAIJBDFGNK IFJGGGBCDCK;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static MMAIJBDFGNK IBLEHBCLMPN;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x72F95A0", Offset = "0x72F81A0", VA = "0x1872F95A0")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct KONDCKBIOMP
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static MMAIJBDFGNK DINGMCOINGM;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x72FFBA0", Offset = "0x72FE7A0", VA = "0x1872FFBA0")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct AONAHCMPFBA
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static MMAIJBDFGNK MHFEFOEOGDE;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static MMAIJBDFGNK NEOFKGKFNAL;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static MMAIJBDFGNK IFJGGGBCDCK;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static MMAIJBDFGNK IBLEHBCLMPN;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x72ECA70", Offset = "0x72EB670", VA = "0x1872ECA70")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct NHEDJIGKIKC
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static MMAIJBDFGNK OFKJPNCHDFL;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x7304410", Offset = "0x7303010", VA = "0x187304410")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct GGLAOCIMLIE
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static MMAIJBDFGNK ALGENDAAHLB;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x72F7CB0", Offset = "0x72F68B0", VA = "0x1872F7CB0")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct NEOGLDMLFOA
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static MMAIJBDFGNK MEIJDHCPHHN;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7302F80", Offset = "0x7301B80", VA = "0x187302F80")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct LCBHBLHLAFD
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static MMAIJBDFGNK EINHPPMAEHO;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x72FFDA0", Offset = "0x72FE9A0", VA = "0x1872FFDA0")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct NCGPHBADCDN
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static MMAIJBDFGNK CEDLHDKMIJI;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x7302D80", Offset = "0x7301980", VA = "0x187302D80")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct NAOJNEGPJMA
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static MMAIJBDFGNK PFEGFMECNJA;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x7302B80", Offset = "0x7301780", VA = "0x187302B80")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct GKOPOGHFDDA
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static MMAIJBDFGNK BJBDJBKPDPG;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x72F86A0", Offset = "0x72F72A0", VA = "0x1872F86A0")]
				public static PlayerLoopSystem AAECKMHLDGI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public enum DEBHDOLBBFO : byte
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
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct ABBJAPPCNDJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000021")]
				[CompilerGenerated]
				private sealed class AHBFNHBMKEG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public DEBHDOLBBFO updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
					public AHBFNHBMKEG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x72EC8C0", Offset = "0x72EB4C0", VA = "0x1872EC8C0")]
					internal void CEBKLHPOCFL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static BCFOECKJENL<DEBHDOLBBFO> LJHNONMJENL;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x72EC6B0", Offset = "0x72EB2B0", VA = "0x1872EC6B0")]
				public static PlayerLoopSystem AAECKMHLDGI(DEBHDOLBBFO JBKJJGMCJCA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			internal struct AIBCBAHMOBP
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				[CompilerGenerated]
				private sealed class BDBOOHKDIAF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public BMENGPDIPMP.DDJPBABGLAD key;

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
					public BDBOOHKDIAF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x72ED560", Offset = "0x72EC160", VA = "0x1872ED560")]
					internal void OCAPNKCMCLB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable CPFFJAEMGPD;

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x72EC940", Offset = "0x72EB540", VA = "0x1872EC940")]
				public static PlayerLoopSystem PHMDFAPKCAL(BMENGPDIPMP.DDJPBABGLAD NCMHANGAILD)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000025")]
			internal struct OOGMCMJNHFC
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class KHNLFBBAFJA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public BMENGPDIPMP.DDJPBABGLAD key;

					[Cpp2IlInjected.Token(Token = "0x6000056")]
					[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
					public KHNLFBBAFJA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x72FEF40", Offset = "0x72FDB40", VA = "0x1872FEF40")]
					internal void OCAPNKCMCLB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x7304E30", Offset = "0x7303A30", VA = "0x187304E30")]
				public static PlayerLoopSystem PHMDFAPKCAL(BMENGPDIPMP.DDJPBABGLAD NCMHANGAILD)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class GIFDGMPCHDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public GIFDGMPCHDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x72F8580", Offset = "0x72F7180", VA = "0x1872F8580")]
			internal List<PlayerLoopSystem> HDCENFIPJAG(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool BGCNKDOADHA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool PPGFKGONNIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x72F1B10", Offset = "0x72F0710", VA = "0x1872F1B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72EE970", Offset = "0x72ED570", VA = "0x1872EE970")]
		private static void BMLMOJGAOHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72F1B50", Offset = "0x72F0750", VA = "0x1872F1B50")]
		private static void NEJAFDMAFNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72EE740", Offset = "0x72ED340", VA = "0x1872EE740")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72F1950", Offset = "0x72F0550", VA = "0x1872F1950")]
		private static void DNBJHGHEIGH(BMENGPDIPMP.DDJPBABGLAD NCMHANGAILD, PlayerLoopSystem PHNBMLBJEJG, Type BIMEKGKAHIC, Type OHPDEPLAPED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72F1570", Offset = "0x72F0170", VA = "0x1872F1570")]
		private static void CJFFIBNGLEH(PlayerLoopSystem PHNBMLBJEJG, Type BIMEKGKAHIC, Type OHPDEPLAPED, EMKKIGDMMNI LFLADPIGAPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72F2460", Offset = "0x72F1060", VA = "0x1872F2460")]
		private static void OMBPGGENLII(PlayerLoopSystem PHNBMLBJEJG, Type BIMEKGKAHIC, Type OHPDEPLAPED, PlayerLoopSystem? LBEPDDHFCMI, PlayerLoopSystem? FOLIPCGKCPH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class BMENGPDIPMP
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum DDJPBABGLAD
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

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class GEANNIECOAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly DDJPBABGLAD NFFPKJAKNLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly HLBBNICGOEI OMILGJAFAIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long LONFDNCEAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long IAHCOLPDMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long DIKKCDMCBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int IOJHAJPLFEE;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x72F7B60", Offset = "0x72F6760", VA = "0x1872F7B60")]
		public GEANNIECOAD(DDJPBABGLAD DEGBILIKFNM, int PLJNOJMGNFI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x72F78C0", Offset = "0x72F64C0", VA = "0x1872F78C0")]
		public void AGIDLNNAALA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x72F7B10", Offset = "0x72F6710", VA = "0x1872F7B10")]
		public void PGEIBIIPNKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72F7930", Offset = "0x72F6530", VA = "0x1872F7930")]
		public void GLNOAAKFCOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static DDJPBABGLAD[] IOOABLLFGPI;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static GEANNIECOAD[] CODFJLKJMKH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x72EDCE0", Offset = "0x72EC8E0", VA = "0x1872EDCE0")]
	public static GEANNIECOAD ILMHHDEPGBK(DDJPBABGLAD NCMHANGAILD, int PLJNOJMGNFI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x72EDBD0", Offset = "0x72EC7D0", VA = "0x1872EDBD0")]
	public static GEANNIECOAD FBHBGGABILC(DDJPBABGLAD NCMHANGAILD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72EDC40", Offset = "0x72EC840", VA = "0x1872EDC40")]
	public static void IBLMFBJENKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HLBBNICGOEI : KAOPJAJOKCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int OHMNCLBFAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> OJODEALJNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double GMOAOGFMENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double BHHOPHAOKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double FIAIBODMGKL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double PHEMJHGACCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72F9490", Offset = "0x72F8090", VA = "0x1872F9490", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double KKADIIANILD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1A8E310", Offset = "0x1A8CF10", VA = "0x181A8E310", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OPCFACMJPIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1F73650", Offset = "0x1F72250", VA = "0x181F73650", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x72F94F0", Offset = "0x72F80F0", VA = "0x1872F94F0")]
	public HLBBNICGOEI(int PHDPIPMAAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72F9370", Offset = "0x72F7F70", VA = "0x1872F9370", Slot = "7")]
	public void MLIICJCLLGD(double BMEHNBDMOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72F9300", Offset = "0x72F7F00", VA = "0x1872F9300", Slot = "8")]
	public void LEJCELDJPNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class PMOBDNMMPFH : KAOPJAJOKCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long LLHINFJPPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double IAPMLPMBNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double KNAMFHPAPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double OLDOMBKGHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double LEAJBFODDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double GMOAOGFMENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double BHHOPHAOKKI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double KKADIIANILD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5F5A200", Offset = "0x5F58E00", VA = "0x185F5A200", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OPCFACMJPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5F59D60", Offset = "0x5F58960", VA = "0x185F59D60", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double LCOIKPBEBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5F59D80", Offset = "0x5F58980", VA = "0x185F59D80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double PHEMJHGACCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x25739E0", Offset = "0x25725E0", VA = "0x1825739E0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7307A10", Offset = "0x7306610", VA = "0x187307A10", Slot = "7")]
	public virtual void MLIICJCLLGD(double BMEHNBDMOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x73079D0", Offset = "0x73065D0", VA = "0x1873079D0", Slot = "8")]
	public virtual void LEJCELDJPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x72F7850", Offset = "0x72F6450", VA = "0x1872F7850")]
	public PMOBDNMMPFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class FPIOCOFIIDJ : PMOBDNMMPFH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double OGFJFNIKMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5F59D50", Offset = "0x5F58950", VA = "0x185F59D50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5F59D70", Offset = "0x5F58970", VA = "0x185F59D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72F7720", Offset = "0x72F6320", VA = "0x1872F7720", Slot = "7")]
	public override void MLIICJCLLGD(double BMEHNBDMOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72F76E0", Offset = "0x72F62E0", VA = "0x1872F76E0", Slot = "8")]
	public override void LEJCELDJPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72F7850", Offset = "0x72F6450", VA = "0x1872F7850")]
	public FPIOCOFIIDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KAOPJAJOKCG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double PHEMJHGACCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double KKADIIANILD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double OPCFACMJPIG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class APADEOGOAIK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private interface JDCMMBPOOEE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool OJLCIFNELDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FCEAEPLEAMP();
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private abstract class DDBBFKLAPPE<TPromise, TMainThreadPromise> : JDCMMBPOOEE where TPromise : HNHMCBNIKDD where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly TPromise EKMHCNNEAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected readonly TMainThreadPromise CJJGGOOCNPB;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise INPBPGEDKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5880690", Offset = "0x587F290", VA = "0x185880690")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OJLCIFNELDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x58806F0", Offset = "0x587F2F0", VA = "0x1858806F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x872290", Offset = "0x870E90", VA = "0x180872290")]
		protected DDBBFKLAPPE(TPromise EKMHCNNEAJN, TMainThreadPromise GFFGELBHCFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5880670", Offset = "0x587F270", VA = "0x185880670", Slot = "5")]
		public void FCEAEPLEAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void GNLDJKKPDNP(TPromise EKMHCNNEAJN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class MNHLNNICPED<T> : DDBBFKLAPPE<AMIFHJEHCND<T>, CCBLGHEBJNN<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4492E50", Offset = "0x4491A50", VA = "0x184492E50")]
		public MNHLNNICPED(AMIFHJEHCND<T> EKMHCNNEAJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4492C90", Offset = "0x4491890", VA = "0x184492C90", Slot = "6")]
		protected override void GNLDJKKPDNP(AMIFHJEHCND<T> EKMHCNNEAJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3C3AC80", Offset = "0x3C39880", VA = "0x183C3AC80")]
		[CompilerGenerated]
		private void OBOLFCGJKPA(T KKIOBLFFGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4492DF0", Offset = "0x44919F0", VA = "0x184492DF0")]
		[CompilerGenerated]
		private void JMMHMPFEFPG(string JMMBJIBOIFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class NLOAAEGIAMA : JDCMMBPOOEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Action OBNFAOABLKL;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OJLCIFNELDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
		public NLOAAEGIAMA(Action OBNFAOABLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x94E8F0", Offset = "0x94D4F0", VA = "0x18094E8F0", Slot = "5")]
		public void FCEAEPLEAMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<JDCMMBPOOEE> FMAOMBJLEBI;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3202A30", Offset = "0x3201630", VA = "0x183202A30")]
	public static AMIFHJEHCND<T> MJOPIBKIDGC<T>(this AMIFHJEHCND<T> EKMHCNNEAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x72ED150", Offset = "0x72EBD50", VA = "0x1872ED150")]
	public static void MJOPIBKIDGC(Action OBNFAOABLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3202940", Offset = "0x3201540", VA = "0x183202940")]
	private static AMIFHJEHCND<T> HAPMDDFFMOO<T>(AMIFHJEHCND<T> EKMHCNNEAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x72ECF40", Offset = "0x72EBB40", VA = "0x1872ECF40")]
	private static void FJAHPPOHOKI(JDCMMBPOOEE HBJBELFNEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72ED1F0", Offset = "0x72EBDF0", VA = "0x1872ED1F0")]
	private static void OFPKMAKGBAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72ECD60", Offset = "0x72EB960", VA = "0x1872ECD60")]
	private static void CFKCBJLKPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE60", Offset = "0x72EBA60", VA = "0x1872ECE60")]
	private static void CPGGNEJIOPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class PGOAJMBIANJ
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct MIFLPOGODLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public TaskCompletionSource<Scene> DBLJHNGKECG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly string NBBJMMGJPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly LoadSceneMode EPNCPIJJKLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly bool FDDFPCHCEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7301C60", Offset = "0x7300860", VA = "0x187301C60")]
		public MIFLPOGODLO(TaskCompletionSource<Scene> PCLIDHDNAND, string NBBJMMGJPJE, LoadSceneMode EPNCPIJJKLN, bool FDDFPCHCEPO, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct INPFBAGKIEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private BILFBGGHINK<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72F9FC0", Offset = "0x72F8BC0", VA = "0x1872F9FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x72FA860", Offset = "0x72F9460", VA = "0x1872FA860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct DNMJKNIINHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x72F3410", Offset = "0x72F2010", VA = "0x1872F3410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x72F3730", Offset = "0x72F2330", VA = "0x1872F3730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct JMJJBDDKKEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private MIFLPOGODLO <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72FC180", Offset = "0x72FAD80", VA = "0x1872FC180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x72FC530", Offset = "0x72FB130", VA = "0x1872FC530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class KKCKJLFLMDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public CCBLGHEBJNN<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public KKCKJLFLMDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x72FF2A0", Offset = "0x72FDEA0", VA = "0x1872FF2A0")]
		internal void MLNOCOBJLPN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MPJOKLHCGAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private KKCKJLFLMDB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private BILFBGGHINK<string>.OADHIEPGLKH <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7301F70", Offset = "0x7300B70", VA = "0x187301F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7302B10", Offset = "0x7301710", VA = "0x187302B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct IEOGGHMOOKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x72F9A70", Offset = "0x72F8670", VA = "0x1872F9A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x72F9F50", Offset = "0x72F8B50", VA = "0x1872F9F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct DALDIDPDIKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private BILFBGGHINK<string>.OADHIEPGLKH <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private BILFBGGHINK<string>.OADHIEPGLKH <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72F2590", Offset = "0x72F1190", VA = "0x1872F2590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72F30E0", Offset = "0x72F1CE0", VA = "0x1872F30E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class LDPKILKLDBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public LDPKILKLDBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72FFFA0", Offset = "0x72FEBA0", VA = "0x1872FFFA0")]
		internal bool GIALKAPDIFI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class DOCMFGHEFJM : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public KLIFOCPDGIA onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public DOCMFGHEFJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x72F3E90", Offset = "0x72F2A90", VA = "0x1872F3E90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72F3AB0", Offset = "0x72F26B0", VA = "0x1872F3AB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x72F3DF0", Offset = "0x72F29F0", VA = "0x1872F3DF0")]
		private void OPGOEIKMBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x72F3E40", Offset = "0x72F2A40", VA = "0x1872F3E40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class FLFEKFEEGGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CCBLGHEBJNN<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public FLFEKFEEGGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x72F7660", Offset = "0x72F6260", VA = "0x1872F7660")]
		internal bool PKGKALMEACF(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x72F73E0", Offset = "0x72F5FE0", VA = "0x1872F73E0")]
		internal void JHCHEIKGPFH(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class GHKOLFHAKLJ : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CCBLGHEBJNN<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private FLFEKFEEGGJ <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public GHKOLFHAKLJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x72F7EB0", Offset = "0x72F6AB0", VA = "0x1872F7EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x72F8530", Offset = "0x72F7130", VA = "0x1872F8530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly ICollection<string> IEJAJNCGIBP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static HNHMCBNIKDD LPHMHLFICBL;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static AsyncOperation BGMIMKKHOCA;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static HNHMCBNIKDD OEKMGIABJLI;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static string PGDNMJBDOOL;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static ThreadPriority DILLMBNKHGB;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task EKADOEJIFEI;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static List<SceneInstance> EDLKFFDEPOD;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Queue<MIFLPOGODLO> CBDPNFNHGOO;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Task HBGBKCDDLOD;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool CHODMNNAEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7306970", Offset = "0x7305570", VA = "0x187306970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool IAPJPMEKJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7305E90", Offset = "0x7304A90", VA = "0x187305E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool DCCGLCFNAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7305740", Offset = "0x7304340", VA = "0x187305740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool LCGLHJGDPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7305FE0", Offset = "0x7304BE0", VA = "0x187305FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> EOKONIGFCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x73057E0", Offset = "0x73043E0", VA = "0x1873057E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x73063A0", Offset = "0x7304FA0", VA = "0x1873063A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7306870", Offset = "0x7305470", VA = "0x187306870")]
	[OJHKBBIOGFE(EBHKLEGGCCF.EnteredEditModeNextFrame, 0)]
	private static void OEJONFHDJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x73064B0", Offset = "0x73050B0", VA = "0x1873064B0")]
	[AsyncStateMachine(typeof(INPFBAGKIEE))]
	public static Task<Scene> NIIDJPHNBDN(string NBBJMMGJPJE, LoadSceneMode EPNCPIJJKLN = LoadSceneMode.Single, bool FDDFPCHCEPO = false, [Optional] BILFBGGHINK<string>.OADHIEPGLKH HMGJGGBHDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7305F30", Offset = "0x7304B30", VA = "0x187305F30")]
	[AsyncStateMachine(typeof(DNMJKNIINHB))]
	private static Task LGJDJJMIHHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7305AF0", Offset = "0x73046F0", VA = "0x187305AF0")]
	[AsyncStateMachine(typeof(JMJJBDDKKEH))]
	private static Task FJMOLFHMPKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7306600", Offset = "0x7305200", VA = "0x187306600")]
	[AsyncStateMachine(typeof(MPJOKLHCGAO))]
	private static Task<Scene> NMOKOPLOCHE(string NBBJMMGJPJE, LoadSceneMode EPNCPIJJKLN, bool FDDFPCHCEPO, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7305BC0", Offset = "0x73047C0", VA = "0x187305BC0")]
	private static void FPIDDNLCCPG(SceneInstance AGABHBIFGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x73058F0", Offset = "0x73044F0", VA = "0x1873058F0")]
	private static void FHKHMNGODCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7306750", Offset = "0x7305350", VA = "0x187306750")]
	[AsyncStateMachine(typeof(IEOGGHMOOKB))]
	private static Task<Scene> NNJLCMIOAJN(string NBBJMMGJPJE, LoadSceneMode EPNCPIJJKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7305650", Offset = "0x7304250", VA = "0x187305650")]
	private static bool BGNJPMBPILP(string NBBJMMGJPJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7306290", Offset = "0x7304E90", VA = "0x187306290")]
	[AsyncStateMachine(typeof(DALDIDPDIKE))]
	private static Task<Scene> MHOGJINCEMI(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7306110", Offset = "0x7304D10", VA = "0x187306110")]
	public static AMIFHJEHCND<Scene> MEANOFIABMG(string NBBJMMGJPJE, LoadSceneMode EPNCPIJJKLN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7305380", Offset = "0x7303F80", VA = "0x187305380")]
	public static HNHMCBNIKDD AMCHOMPCLOM(string NBBJMMGJPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7305CD0", Offset = "0x73048D0", VA = "0x187305CD0")]
	[IteratorStateMachine(typeof(DOCMFGHEFJM))]
	private static IEnumerator<ELFHCGFNHNJ> HICBOEJBGBH(string NBBJMMGJPJE, KLIFOCPDGIA EFHMIFDGBFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7306070", Offset = "0x7304C70", VA = "0x187306070")]
	[IteratorStateMachine(typeof(GHKOLFHAKLJ))]
	private static IEnumerator<ELFHCGFNHNJ> MEANCKDONCM(string NBBJMMGJPJE, LoadSceneMode EPNCPIJJKLN, CCBLGHEBJNN<Scene> EFHMIFDGBFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7305D60", Offset = "0x7304960", VA = "0x187305D60")]
	public static bool IEEDHJCDLBL([Out] string ICECBPFMBLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MNGPBMIHBEA
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7301DC0", Offset = "0x73009C0", VA = "0x187301DC0")]
	public static IDisposable PDMKPADDCKP(this OLOCNFFOAIH NGDLPEOFMHL, float HKAKHDAKBJP, Action<float> ALAANEDIJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7301CC0", Offset = "0x73008C0", VA = "0x187301CC0")]
	public static IDisposable KJEEFFOLBCM(this OLOCNFFOAIH NGDLPEOFMHL, Action<float> ALAANEDIJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7301D40", Offset = "0x7300940", VA = "0x187301D40")]
	public static IDisposable OLMLPCHJEAL(this OLOCNFFOAIH NGDLPEOFMHL, Action<float> ALAANEDIJIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class JHABLCIMDFK
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x72FB800", Offset = "0x72FA400", VA = "0x1872FB800")]
	public static IDisposable IGOJFJKMKKD(this MonoBehaviour GNLCCILBHCO, Action ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x72FB770", Offset = "0x72FA370", VA = "0x1872FB770")]
	public static IDisposable IGOJFJKMKKD(this MonoBehaviour GNLCCILBHCO, Action<float> ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x72FBAF0", Offset = "0x72FA6F0", VA = "0x1872FBAF0")]
	public static IDisposable LMJHDDPLKGM(this MonoBehaviour GNLCCILBHCO, Action ALAANEDIJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x72FBDE0", Offset = "0x72FA9E0", VA = "0x1872FBDE0")]
	public static IDisposable ODKIHACCDAD(this MonoBehaviour GNLCCILBHCO, Action ALAANEDIJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x72FBE60", Offset = "0x72FAA60", VA = "0x1872FBE60")]
	public static IDisposable ODKIHACCDAD(this MonoBehaviour GNLCCILBHCO, Action<float> ALAANEDIJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x72FBB70", Offset = "0x72FA770", VA = "0x1872FBB70")]
	public static IDisposable LPBJNGIPPCB(this MonoBehaviour GNLCCILBHCO, Action ALAANEDIJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x72FB890", Offset = "0x72FA490", VA = "0x1872FB890")]
	public static IDisposable IIBCFLHHLGA(this MonoBehaviour GNLCCILBHCO, Action ALAANEDIJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x72FB3E0", Offset = "0x72F9FE0", VA = "0x1872FB3E0")]
	public static IDisposable AAPOELOOOGJ(this MonoBehaviour GNLCCILBHCO, Action ALAANEDIJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x72FBBF0", Offset = "0x72FA7F0", VA = "0x1872FBBF0")]
	public static IDisposable MGCGNAEKMGB(this MonoBehaviour GNLCCILBHCO, float HKAKHDAKBJP, Action<float> ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP, bool PDKPDEIHMPB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x72FB650", Offset = "0x72FA250", VA = "0x1872FB650")]
	public static IDisposable GOMNCNAJJKC(this MonoBehaviour GNLCCILBHCO, float HKAKHDAKBJP, Action<float> ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP, bool PDKPDEIHMPB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x72FBD40", Offset = "0x72FA940", VA = "0x1872FBD40")]
	public static IDisposable OBNGGAFGEPI(this MonoBehaviour GNLCCILBHCO, float HKAKHDAKBJP, Action<float> ALAANEDIJIC, bool PDKPDEIHMPB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x72FB460", Offset = "0x72FA060", VA = "0x1872FB460")]
	public static IDisposable BHMJNBGJLKO(this MonoBehaviour GNLCCILBHCO, Action<float> ALAANEDIJIC, bool PDKPDEIHMPB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x72FB500", Offset = "0x72FA100", VA = "0x1872FB500")]
	public static IDisposable DBFLOPHEBKC(this MonoBehaviour GNLCCILBHCO, Action<float> ALAANEDIJIC, bool PDKPDEIHMPB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x72FBA50", Offset = "0x72FA650", VA = "0x1872FBA50")]
	public static IDisposable KJBMBHFAOOG(this MonoBehaviour GNLCCILBHCO, Action<float> ALAANEDIJIC, bool PDKPDEIHMPB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x72FB9B0", Offset = "0x72FA5B0", VA = "0x1872FB9B0")]
	public static IDisposable JIHONBGJPNL(this MonoBehaviour GNLCCILBHCO, Action<float> ALAANEDIJIC, bool PDKPDEIHMPB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72FBEE0", Offset = "0x72FAAE0", VA = "0x1872FBEE0")]
	public static IDisposable POBAHIHPLNG(this MonoBehaviour GNLCCILBHCO, Action<float> ALAANEDIJIC, bool PDKPDEIHMPB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72FB910", Offset = "0x72FA510", VA = "0x1872FB910")]
	public static IDisposable JAOMOOMFHCK(this MonoBehaviour GNLCCILBHCO, Action<float> ALAANEDIJIC, bool PDKPDEIHMPB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72FBCA0", Offset = "0x72FA8A0", VA = "0x1872FBCA0")]
	public static IDisposable NGIFFOGOJIK(this MonoBehaviour GNLCCILBHCO, Action<float> ALAANEDIJIC, bool PDKPDEIHMPB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x72FB5A0", Offset = "0x72FA1A0", VA = "0x1872FB5A0")]
	public static IDisposable FJMDAKMNKAM(this MonoBehaviour GNLCCILBHCO, float HKAKHDAKBJP, Action<float> ALAANEDIJIC, bool PDKPDEIHMPB = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class GNPFGLPPIBE
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class ICKCMGIIGJD : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FOIAJFPEJEL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private NJNLBGBEEEJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public ICKCMGIIGJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x72F9890", Offset = "0x72F8490", VA = "0x1872F9890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x72F9970", Offset = "0x72F8570", VA = "0x1872F9970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class CCLDMKDJFFK : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public FOIAJFPEJEL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private NJNLBGBEEEJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public CCLDMKDJFFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x72EE060", Offset = "0x72ECC60", VA = "0x1872EE060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x72EE150", Offset = "0x72ECD50", VA = "0x1872EE150", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72F9070", Offset = "0x72F7C70", VA = "0x1872F9070")]
	public static NHMNIEJFONC IGOJFJKMKKD(Action ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x72F9120", Offset = "0x72F7D20", VA = "0x1872F9120")]
	public static NHMNIEJFONC IGOJFJKMKKD(Behaviour NGDLPEOFMHL, Action ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x72F91E0", Offset = "0x72F7DE0", VA = "0x1872F91E0")]
	public static NHMNIEJFONC IGOJFJKMKKD(Behaviour NGDLPEOFMHL, Action<float> ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x72F8F50", Offset = "0x72F7B50", VA = "0x1872F8F50")]
	[IteratorStateMachine(typeof(ICKCMGIIGJD))]
	private static IEnumerator<ELFHCGFNHNJ> ELNBKPFADMA(FOIAJFPEJEL LAHIJHGJIIE, Action ALAANEDIJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x72F8FE0", Offset = "0x72F7BE0", VA = "0x1872F8FE0")]
	[IteratorStateMachine(typeof(CCLDMKDJFFK))]
	private static IEnumerator<ELFHCGFNHNJ> ELNBKPFADMA(FOIAJFPEJEL LAHIJHGJIIE, Action<float> ALAANEDIJIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class BHFMLOJOOHO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class JFJGFJHLPBP : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public BHFMLOJOOHO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public JFJGFJHLPBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x72FB300", Offset = "0x72F9F00", VA = "0x1872FB300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x72FB390", Offset = "0x72F9F90", VA = "0x1872FB390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly FOIAJFPEJEL PDEMIPPDIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Action JMIJKCJNOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool HPGMONDGJNE;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DLJHKCAJIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86C790", Offset = "0x86B390", VA = "0x18086C790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x72EDAC0", Offset = "0x72EC6C0", VA = "0x1872EDAC0")]
	public BHFMLOJOOHO(FOIAJFPEJEL PDEMIPPDIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x72ED9A0", Offset = "0x72EC5A0", VA = "0x1872ED9A0")]
	[IteratorStateMachine(typeof(JFJGFJHLPBP))]
	private IEnumerator<ELFHCGFNHNJ> NPGCPEFKEEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x72EDA20", Offset = "0x72EC620", VA = "0x1872EDA20", Slot = "4")]
	public void OnCompleted(Action BKLNENHCFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	public void HEACIAHFIKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LFNOEJHNIBN
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7300020", Offset = "0x72FEC20", VA = "0x187300020")]
	public static BHFMLOJOOHO GBDFPBKCPFK(this FOIAJFPEJEL PDEMIPPDIGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class NNFDJCNOFFD
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class AAPBLCLGJAF : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CKBPPCGCOMM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public AAPBLCLGJAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x72EC5E0", Offset = "0x72EB1E0", VA = "0x1872EC5E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x72EC660", Offset = "0x72EB260", VA = "0x1872EC660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7304990", Offset = "0x7303590", VA = "0x187304990")]
	public static NHMNIEJFONC IGOJFJKMKKD(float HKAKHDAKBJP, Action<float> ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP, bool PDKPDEIHMPB = true, [Optional] BJNEKIMFDFF FKOADFMJKFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7304A90", Offset = "0x7303690", VA = "0x187304A90")]
	public static NHMNIEJFONC IGOJFJKMKKD(MonoBehaviour GNLCCILBHCO, float HKAKHDAKBJP, Action<float> ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP, bool PDKPDEIHMPB = true, [Optional] BJNEKIMFDFF FKOADFMJKFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7304BA0", Offset = "0x73037A0", VA = "0x187304BA0")]
	public static NHMNIEJFONC OOPOGFOGLIM(MonoBehaviour GNLCCILBHCO, float HKAKHDAKBJP, Action<float> ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP, bool PDKPDEIHMPB = true, [Optional] BJNEKIMFDFF FKOADFMJKFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x73047C0", Offset = "0x73033C0", VA = "0x1873047C0")]
	public static NHMNIEJFONC ADBPFHODMFP(OLOCNFFOAIH NGDLPEOFMHL, float HKAKHDAKBJP, Action<float> ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP, bool PDKPDEIHMPB = true, [Optional] BJNEKIMFDFF FKOADFMJKFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x73048D0", Offset = "0x73034D0", VA = "0x1873048D0")]
	private static IEnumerator<ELFHCGFNHNJ> ELNBKPFADMA(HDCHBMEICCP KKOFCHGOIBJ, float HKAKHDAKBJP, FOIAJFPEJEL LAHIJHGJIIE, Action<float> ALAANEDIJIC, bool PDKPDEIHMPB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7304CC0", Offset = "0x73038C0", VA = "0x187304CC0")]
	private static IEnumerator<ELFHCGFNHNJ> PJFEOANPLDM(HDCHBMEICCP KKOFCHGOIBJ, float HKAKHDAKBJP, FOIAJFPEJEL LAHIJHGJIIE, Action<float> ALAANEDIJIC, bool PDKPDEIHMPB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7304730", Offset = "0x7303330", VA = "0x187304730")]
	[IteratorStateMachine(typeof(AAPBLCLGJAF))]
	private static IEnumerator<ELFHCGFNHNJ> ACIFCNPFNFP(CKBPPCGCOMM ONOPPEELAMF, float HKAKHDAKBJP, FOIAJFPEJEL LAHIJHGJIIE, Action<float> ALAANEDIJIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class JCNGHONAHLN
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class JDMMMAOHHLO : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public FOIAJFPEJEL queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public JDMMMAOHHLO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x72FB1F0", Offset = "0x72F9DF0", VA = "0x1872FB1F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x72FB2B0", Offset = "0x72F9EB0", VA = "0x1872FB2B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x72FA9F0", Offset = "0x72F95F0", VA = "0x1872FA9F0")]
	[IteratorStateMachine(typeof(JDMMMAOHHLO))]
	private static IEnumerator<ELFHCGFNHNJ> ILPJLNIMOME(FOIAJFPEJEL PDEMIPPDIGP, Func<bool> FFGGIJJLJGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x72FA8D0", Offset = "0x72F94D0", VA = "0x1872FA8D0")]
	public static NHMNIEJFONC AKFLLFGMNGF(this MonoBehaviour GNLCCILBHCO, Func<bool> FFGGIJJLJGP, FOIAJFPEJEL PDEMIPPDIGP = FOIAJFPEJEL.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DPCALFFEDCD
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class DPIIMLNKLOC : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public FOIAJFPEJEL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public DPIIMLNKLOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x72F4910", Offset = "0x72F3510", VA = "0x1872F4910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x72F4980", Offset = "0x72F3580", VA = "0x1872F4980", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class OOBOKIMIOKH : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public FOIAJFPEJEL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private ELFHCGFNHNJ <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public OOBOKIMIOKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7304D50", Offset = "0x7303950", VA = "0x187304D50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7304DE0", Offset = "0x73039E0", VA = "0x187304DE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x72F4540", Offset = "0x72F3140", VA = "0x1872F4540")]
	[IteratorStateMachine(typeof(DPIIMLNKLOC))]
	private static IEnumerator<ELFHCGFNHNJ> NPGCPEFKEEM(float JACNKEDDJOJ, FOIAJFPEJEL LAHIJHGJIIE, Action FKJLAAGOMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x72F4420", Offset = "0x72F3020", VA = "0x1872F4420")]
	[IteratorStateMachine(typeof(OOBOKIMIOKH))]
	private static IEnumerator<ELFHCGFNHNJ> INLKFOEPOJL(float JACNKEDDJOJ, FOIAJFPEJEL LAHIJHGJIIE, Action FKJLAAGOMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x72F4710", Offset = "0x72F3310", VA = "0x1872F4710")]
	public static IDisposable OKDHILIPOME(this MonoBehaviour GNLCCILBHCO, float JACNKEDDJOJ, Action FKJLAAGOMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x72F4330", Offset = "0x72F2F30", VA = "0x1872F4330")]
	public static NHMNIEJFONC DPBBMJPLKIG(this MonoBehaviour GNLCCILBHCO, float JACNKEDDJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x72F45E0", Offset = "0x72F31E0", VA = "0x1872F45E0")]
	public static NHMNIEJFONC OKDHILIPOME(this MonoBehaviour GNLCCILBHCO, float JACNKEDDJOJ, FOIAJFPEJEL LAHIJHGJIIE, Action FKJLAAGOMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x72F44C0", Offset = "0x72F30C0", VA = "0x1872F44C0")]
	public static NHMNIEJFONC KOIMLDMNGIC(this MonoBehaviour GNLCCILBHCO, Action FKJLAAGOMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x72F4510", Offset = "0x72F3110", VA = "0x1872F4510")]
	public static NHMNIEJFONC LJGKNBPOGHJ(this MonoBehaviour GNLCCILBHCO, Action FKJLAAGOMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x72F4830", Offset = "0x72F3430", VA = "0x1872F4830")]
	public static NHMNIEJFONC PFJEFDHONMA(this MonoBehaviour GNLCCILBHCO, Action FKJLAAGOMNG, [Optional] BJNEKIMFDFF FKOADFMJKFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72F44E0", Offset = "0x72F30E0", VA = "0x1872F44E0")]
	public static NHMNIEJFONC LDICDDACIJM(this MonoBehaviour GNLCCILBHCO, Action FKJLAAGOMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72F43F0", Offset = "0x72F2FF0", VA = "0x1872F43F0")]
	public static NHMNIEJFONC HLPCLKJFAJO(this MonoBehaviour GNLCCILBHCO, Action FKJLAAGOMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x72F4260", Offset = "0x72F2E60", VA = "0x1872F4260")]
	private static NHMNIEJFONC CJIMOMGOCPJ(MonoBehaviour GNLCCILBHCO, FOIAJFPEJEL PDEMIPPDIGP, Action FKJLAAGOMNG, [Optional] BJNEKIMFDFF FKOADFMJKFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x72F3F20", Offset = "0x72F2B20", VA = "0x1872F3F20")]
	public static NHMNIEJFONC BFFODGAIGCH(this MonoBehaviour GNLCCILBHCO, float AEDOFKDGEAI, Action FKJLAAGOMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x72F40C0", Offset = "0x72F2CC0", VA = "0x1872F40C0")]
	public static NHMNIEJFONC CCPDNMELJFA(this MonoBehaviour GNLCCILBHCO, float AEDOFKDGEAI, Action FKJLAAGOMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x72F3FF0", Offset = "0x72F2BF0", VA = "0x1872F3FF0")]
	public static NHMNIEJFONC BJLANPDELKE(this MonoBehaviour GNLCCILBHCO, float AEDOFKDGEAI, Action FKJLAAGOMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x72F4190", Offset = "0x72F2D90", VA = "0x1872F4190")]
	public static NHMNIEJFONC CEGDODCOCDO(this MonoBehaviour GNLCCILBHCO, float AEDOFKDGEAI, Action FKJLAAGOMNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class EOOPJGEIMIN : APEBAPEBIBJ, IEnumerable<APEBAPEBIBJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly List<APEBAPEBIBJ> GIMNHLACMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool KKJJFLLNOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Action PBBONCNLBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool NEENBLIFNMF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HHBCIDBIHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x72F6490", Offset = "0x72F5090", VA = "0x1872F6490", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DBAGJHBCBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x72F62D0", Offset = "0x72F4ED0", VA = "0x1872F62D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x72F6370", Offset = "0x72F4F70", VA = "0x1872F6370", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x72F6B80", Offset = "0x72F5780", VA = "0x1872F6B80")]
	public EOOPJGEIMIN([Optional] Action PBBONCNLBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x72F65D0", Offset = "0x72F51D0", VA = "0x1872F65D0")]
	public void LKPJOLMECIF(APEBAPEBIBJ NNFGPEGCGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x72F6700", Offset = "0x72F5300", VA = "0x1872F6700")]
	private void LLILNALPGMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x72F6860", Offset = "0x72F5460", VA = "0x1872F6860", Slot = "7")]
	public bool MEGNHICBCBC(bool FPPHGAIAECP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x72F6870", Offset = "0x72F5470", VA = "0x1872F6870", Slot = "8")]
	public bool MEGNHICBCBC(Action OBNFAOABLKL, bool FPPHGAIAECP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x72F6410", Offset = "0x72F5010", VA = "0x1872F6410", Slot = "9")]
	public IEnumerator<APEBAPEBIBJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x72F6410", Offset = "0x72F5010", VA = "0x1872F6410", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DNODBFDIBPD : GLEIOHGMPIK
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class NNKFOJLJEIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public DNODBFDIBPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public NNKFOJLJEIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7304D20", Offset = "0x7303920", VA = "0x187304D20")]
		internal void IGEFFDIIKCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class PJEGEPPHLMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public DNODBFDIBPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public PJEGEPPHLMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7304D20", Offset = "0x7303920", VA = "0x187304D20")]
		internal void NCCHGCFMAIG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float KBHGGNMFMLB;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x72F39B0", Offset = "0x72F25B0", VA = "0x1872F39B0")]
	public DNODBFDIBPD(Behaviour NGDLPEOFMHL, float KBHGGNMFMLB, [Optional] Action PBBONCNLBCA, [Optional] BJNEKIMFDFF FKOADFMJKFD, [Optional] HDCHBMEICCP KKOFCHGOIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x72F3790", Offset = "0x72F2390", VA = "0x1872F3790", Slot = "9")]
	protected override bool IPBFJFAABMI(Action OBNFAOABLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x72F38A0", Offset = "0x72F24A0", VA = "0x1872F38A0", Slot = "10")]
	protected override bool NJEIEODNHHP(Action OBNFAOABLKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface APEBAPEBIBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool HHBCIDBIHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DBAGJHBCBKC;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MEGNHICBCBC(bool FPPHGAIAECP = false);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MEGNHICBCBC(Action OBNFAOABLKL, bool FPPHGAIAECP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public abstract class GLEIOHGMPIK : APEBAPEBIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class NMCIEBACMOM : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public GLEIOHGMPIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public NMCIEBACMOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7304610", Offset = "0x7303210", VA = "0x187304610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x73046E0", Offset = "0x73032E0", VA = "0x1873046E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Behaviour NGDLPEOFMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action PBBONCNLBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private OECOIGMFBKH NCCMGIELLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly BJNEKIMFDFF FKOADFMJKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly HDCHBMEICCP KKOFCHGOIBJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool HHBCIDBIHID
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xEA3880", Offset = "0xEA2480", VA = "0x180EA3880", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DBAGJHBCBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x72F8B70", Offset = "0x72F7770", VA = "0x1872F8B70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x72F8C50", Offset = "0x72F7850", VA = "0x1872F8C50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x72F8E50", Offset = "0x72F7A50", VA = "0x1872F8E50")]
	protected GLEIOHGMPIK(Behaviour NGDLPEOFMHL, [Optional] Action PBBONCNLBCA, [Optional] BJNEKIMFDFF FKOADFMJKFD, [Optional] HDCHBMEICCP KKOFCHGOIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x72F8DD0", Offset = "0x72F79D0", VA = "0x1872F8DD0", Slot = "7")]
	public bool MEGNHICBCBC(bool FPPHGAIAECP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x72F8D70", Offset = "0x72F7970", VA = "0x1872F8D70", Slot = "8")]
	public bool MEGNHICBCBC(Action OBNFAOABLKL, bool FPPHGAIAECP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool IPBFJFAABMI(Action OBNFAOABLKL);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NJEIEODNHHP(Action OBNFAOABLKL);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x72F8E30", Offset = "0x72F7A30", VA = "0x1872F8E30")]
	protected void NNLAFOJNCIP(Action OBNFAOABLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x72F8930", Offset = "0x72F7530", VA = "0x1872F8930")]
	protected HNHMCBNIKDD EDJCDBNAHGK(float CNHHDPPEEFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x72F8CF0", Offset = "0x72F78F0", VA = "0x1872F8CF0")]
	private void KGPLGCMKPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x72F88A0", Offset = "0x72F74A0", VA = "0x1872F88A0")]
	[IteratorStateMachine(typeof(NMCIEBACMOM))]
	private IEnumerator<ELFHCGFNHNJ> CJAFBNHNMAE(float CNHHDPPEEFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x72F8C10", Offset = "0x72F7810", VA = "0x1872F8C10")]
	[CompilerGenerated]
	private void GDGDMMJHBMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class PCFLOCBDDHE : GLEIOHGMPIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float PAIOJLPHGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly int NHFMGAIJKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float MHFHIHBPOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float[] KBOIFHPPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private int JIAHDFOANON;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x73051E0", Offset = "0x7303DE0", VA = "0x1873051E0")]
	public PCFLOCBDDHE(Behaviour NGDLPEOFMHL, float IFGBNKGNIKA, int NHFMGAIJKML, [Optional] Action PBBONCNLBCA, float MHFHIHBPOBG = 0f, [Optional] BJNEKIMFDFF FKOADFMJKFD, [Optional] HDCHBMEICCP KKOFCHGOIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "9")]
	protected override bool IPBFJFAABMI(Action OBNFAOABLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7304FE0", Offset = "0x7303BE0", VA = "0x187304FE0", Slot = "10")]
	protected override bool NJEIEODNHHP(Action OBNFAOABLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7304F60", Offset = "0x7303B60", VA = "0x187304F60")]
	private void DGHONEENLHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class GGDBJMAGOFL : GLEIOHGMPIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly float KBHGGNMFMLB;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x72F39B0", Offset = "0x72F25B0", VA = "0x1872F39B0")]
	public GGDBJMAGOFL(Behaviour NGDLPEOFMHL, float KBHGGNMFMLB, [Optional] Action PBBONCNLBCA, [Optional] BJNEKIMFDFF FKOADFMJKFD, [Optional] HDCHBMEICCP KKOFCHGOIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "9")]
	protected override bool IPBFJFAABMI(Action OBNFAOABLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x72F7C70", Offset = "0x72F6870", VA = "0x1872F7C70", Slot = "10")]
	protected override bool NJEIEODNHHP(Action OBNFAOABLKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public sealed class JDLCHDJPJNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class DFIDMIGPGNI : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public DFIDMIGPGNI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x72F3150", Offset = "0x72F1D50", VA = "0x1872F3150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x72F31C0", Offset = "0x72F1DC0", VA = "0x1872F31C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NHMNIEJFONC AHKBABDFKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private OLOCNFFOAIH NGDLPEOFMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Action<float> OHMNBBECBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private FOIAJFPEJEL PDEMIPPDIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private float BFINIPJJCFK;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x72FB010", Offset = "0x72F9C10", VA = "0x1872FB010")]
	public JDLCHDJPJNJ(OLOCNFFOAIH NGDLPEOFMHL, float HKAKHDAKBJP, Action<float> ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x72FAE70", Offset = "0x72F9A70", VA = "0x1872FAE70")]
	private void LNGJIAOKGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x72FAC90", Offset = "0x72F9890", VA = "0x1872FAC90")]
	private void GBIEKPFDGEB(string JMMBJIBOIFP, Action DOCBAFPNLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x72FADF0", Offset = "0x72F99F0", VA = "0x1872FADF0")]
	[IteratorStateMachine(typeof(DFIDMIGPGNI))]
	private IEnumerator<ELFHCGFNHNJ> LGDBIIJCBHP(Action DOCBAFPNLNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72FAC30", Offset = "0x72F9830", VA = "0x1872FAC30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x72FAA80", Offset = "0x72F9680", VA = "0x1872FAA80")]
	[CompilerGenerated]
	private void DDCGKPNPNEN(string HEBIFBBBAHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class NHCIFKGFKKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class LEBLAIPIOMJ : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public LEBLAIPIOMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x72F3150", Offset = "0x72F1D50", VA = "0x1872F3150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x72FFFD0", Offset = "0x72FEBD0", VA = "0x1872FFFD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private NHMNIEJFONC AHKBABDFKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private MonoBehaviour GNLCCILBHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Action ALAANEDIJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action<float> OHMNBBECBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private FOIAJFPEJEL PDEMIPPDIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private float BFINIPJJCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool PDKPDEIHMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly BJNEKIMFDFF FKOADFMJKFD;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7304220", Offset = "0x7302E20", VA = "0x187304220")]
	public NHCIFKGFKKG(MonoBehaviour GNLCCILBHCO, Action ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP, [Optional] BJNEKIMFDFF FKOADFMJKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7303FE0", Offset = "0x7302BE0", VA = "0x187303FE0")]
	public NHCIFKGFKKG(MonoBehaviour GNLCCILBHCO, Action<float> ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP, [Optional] BJNEKIMFDFF FKOADFMJKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7303D90", Offset = "0x7302990", VA = "0x187303D90")]
	public NHCIFKGFKKG(MonoBehaviour GNLCCILBHCO, float HKAKHDAKBJP, Action<float> ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP, bool PDKPDEIHMPB = true, [Optional] BJNEKIMFDFF FKOADFMJKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1C0F3C0", Offset = "0x1C0DFC0", VA = "0x181C0F3C0")]
	private NHCIFKGFKKG(BJNEKIMFDFF FKOADFMJKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7303C60", Offset = "0x7302860", VA = "0x187303C60")]
	internal static NHCIFKGFKKG NGJNANIOPDI(MonoBehaviour GNLCCILBHCO, float HKAKHDAKBJP, Action<float> ALAANEDIJIC, FOIAJFPEJEL PDEMIPPDIGP, bool PDKPDEIHMPB = true, [Optional] BJNEKIMFDFF FKOADFMJKFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7303710", Offset = "0x7302310", VA = "0x187303710")]
	private void IGOJFJKMKKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7303AB0", Offset = "0x73026B0", VA = "0x187303AB0")]
	private void MAIFCIGLLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7303900", Offset = "0x7302500", VA = "0x187303900")]
	private void LNGJIAOKGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7303390", Offset = "0x7301F90", VA = "0x187303390")]
	private void EGLEPMBDJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7303550", Offset = "0x7302150", VA = "0x187303550")]
	private void GBIEKPFDGEB(string JMMBJIBOIFP, Action DOCBAFPNLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7303880", Offset = "0x7302480", VA = "0x187303880")]
	[IteratorStateMachine(typeof(LEBLAIPIOMJ))]
	private IEnumerator<ELFHCGFNHNJ> LGDBIIJCBHP(Action DOCBAFPNLNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x73032A0", Offset = "0x7301EA0", VA = "0x1873032A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7303680", Offset = "0x7302280", VA = "0x187303680")]
	[CompilerGenerated]
	private void HPAEPCLMPEO(string HEBIFBBBAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7303300", Offset = "0x7301F00", VA = "0x187303300")]
	[CompilerGenerated]
	private void EBAGMPBKBNC(string HEBIFBBBAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7303180", Offset = "0x7301D80", VA = "0x187303180")]
	[CompilerGenerated]
	private void CCIJMNMKJIN(string HEBIFBBBAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7303210", Offset = "0x7301E10", VA = "0x187303210")]
	[CompilerGenerated]
	private void CLOLNKAHMEA(string HEBIFBBBAHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[Flags]
internal enum PHLJPPJIAJL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class IEANGNLLMMJ : HDCHBMEICCP
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float NGGCJHKHKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x72F99F0", Offset = "0x72F85F0", VA = "0x1872F99F0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float NLHGAOLBGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x72F99E0", Offset = "0x72F85E0", VA = "0x1872F99E0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double OKKBIDNJEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x72F99C0", Offset = "0x72F85C0", VA = "0x1872F99C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x72F9A00", Offset = "0x72F8600", VA = "0x1872F9A00")]
	[DHOHFCLMOGD(IDHBAGABJJA.None)]
	private static void MHPOAGMJOPB(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	[Preserve]
	internal IEANGNLLMMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface CDBOAGDAKDC
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCPFDICAFMF(string LONKACOOPGJ);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAHPDHMLHKF();
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface KDEGKOGKBMF
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool DJLGOGBINMG
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JNDHGMBJHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal class EKIHODPNLPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public JPMBEDPFGJM GKPNFLPCJJL;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int ICIBDGPPAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x863DA0", VA = "0x1808651A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x868D10", Offset = "0x867910", VA = "0x180868D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x72F5F70", Offset = "0x72F4B70", VA = "0x1872F5F70")]
	public static ELFHCGFNHNJ LKEBPPHDKOC(IEnumerator<ELFHCGFNHNJ> PDNPGMLFMHH, MGKNLBKJAHJ DHNJBCEHKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x72F60D0", Offset = "0x72F4CD0", VA = "0x1872F60D0")]
	public ELFHCGFNHNJ LKEBPPHDKOC(MGKNLBKJAHJ[] GILNGJMGNMC, IEnumerator<ELFHCGFNHNJ>[] DJBMAKJGOIJ, ELFHCGFNHNJ[] HMMJMLIMLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x72F5F40", Offset = "0x72F4B40", VA = "0x1872F5F40")]
	public void LAAAJNAHDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x72F6190", Offset = "0x72F4D90", VA = "0x1872F6190")]
	public void NOPNIFEMOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x72F5E00", Offset = "0x72F4A00", VA = "0x1872F5E00")]
	public void KIEAJMGMBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x72F5F40", Offset = "0x72F4B40", VA = "0x1872F5F40")]
	public void OCHLBECONCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public EKIHODPNLPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class JPMBEDPFGJM
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct HPHEOLFFIJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public EKIHODPNLPP LDINLNDBONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public OLOCNFFOAIH GFHGBPHGHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public MGKNLBKJAHJ PEPLALJCMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IEnumerator<ELFHCGFNHNJ> PMPFKNHDJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public ELFHCGFNHNJ ALEHLCIDEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public PHLJPPJIAJL ICPFBJMNJLL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct DNINNMLGCLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public FOIAJFPEJEL PMBDMAGCLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public List<HPHEOLFFIJH> AIFOGACOHFO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class FCAFJEPMHIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public MGKNLBKJAHJ promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public JPMBEDPFGJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public OLOCNFFOAIH context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public EKIHODPNLPP routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public PHLJPPJIAJL coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public ELFHCGFNHNJ currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IEnumerator<ELFHCGFNHNJ> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public FCAFJEPMHIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x72F6C20", Offset = "0x72F5820", VA = "0x1872F6C20")]
		internal void IIDMPIOJABA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class CMPMFHNHPHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public EKIHODPNLPP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public JPMBEDPFGJM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public CMPMFHNHPHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x72EE1A0", Offset = "0x72ECDA0", VA = "0x1872EE1A0")]
		internal void GBIGMADPAKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class ABIPJLMADOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public EKIHODPNLPP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public JPMBEDPFGJM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public ABIPJLMADOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x72EC880", Offset = "0x72EB480", VA = "0x1872EC880")]
		internal void PBPGAHKFGBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class GAMPNNEONHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public EKIHODPNLPP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public JPMBEDPFGJM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public GAMPNNEONHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x72F7880", Offset = "0x72F6480", VA = "0x1872F7880")]
		internal void COFJHLMPHDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const PHLJPPJIAJL FOILGBCOILJ = PHLJPPJIAJL.Cancelled | PHLJPPJIAJL.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly FOIAJFPEJEL PDEMIPPDIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool[] NNODLMGAFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<PHLJPPJIAJL> PCIEMNGJPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<float> HFBAAFAMGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> LHHMKBHAPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> MGICEPDFFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> ILPAHAGEJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> ADJMIGJGKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> NAICIJJLEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private EKIHODPNLPP[] CFABJKFGMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private MGKNLBKJAHJ[] GILNGJMGNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private OLOCNFFOAIH[] CPJENKNCIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IEnumerator<ELFHCGFNHNJ>[] NINEMJLNBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private ELFHCGFNHNJ[] AOKCICAOFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int PKNKBPCLEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int DFJDDCJIBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly int FJFIKCNOKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float OLGOOJKHDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private CPNMJKIIEKP MHFGMHCFNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private JobHandle BHKDABKFMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<EKIHODPNLPP> FGPAPDOBBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool BPEMOFCDFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private List<Action> CLMNOMEHCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> HOMNGJMDEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private bool CJACEAJHJAH;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DNINNMLGCLO[] EIDNDBCJNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8D1A90", Offset = "0x8D0690", VA = "0x1808D1A90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x72FE8C0", Offset = "0x72FD4C0", VA = "0x1872FE8C0")]
	private static int OMHDAIMJHPK(FOIAJFPEJEL PDEMIPPDIGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x72FE8F0", Offset = "0x72FD4F0", VA = "0x1872FE8F0")]
	public JPMBEDPFGJM(FOIAJFPEJEL PDEMIPPDIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x72FC900", Offset = "0x72FB500", VA = "0x1872FC900")]
	private void CILEOFBCLIB(int INMLGAMHGEJ, int LGAHCGILBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x72FE170", Offset = "0x72FCD70", VA = "0x1872FE170")]
	public void NDCCIEOHKFE(OLOCNFFOAIH NGDLPEOFMHL, ELFHCGFNHNJ HIGHKNBEHFG, IEnumerator<ELFHCGFNHNJ> PDNPGMLFMHH, MGKNLBKJAHJ DHNJBCEHKAL, [Optional] EKIHODPNLPP OPKKJFODLBC, PHLJPPJIAJL CIBOMEHKNBN = PHLJPPJIAJL.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x72FE680", Offset = "0x72FD280", VA = "0x1872FE680")]
	public void OIJHPPOGALI(IEnumerable<HPHEOLFFIJH> LEBHLIICIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x72FCAE0", Offset = "0x72FB6E0", VA = "0x1872FCAE0")]
	private HPHEOLFFIJH CLACHDLOJGD(int GBDBEHMLPLF)
	{
		return default(HPHEOLFFIJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x72FC590", Offset = "0x72FB190", VA = "0x1872FC590")]
	private void CBLMILOHKDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA22F0", Offset = "0x2BA0EF0", VA = "0x182BA22F0")]
	private static void JKHHHBCBGJA<T>(int GBDBEHMLPLF, T[] GPNICIOAKLH, int INGCLKPLIOP, [Optional] T FMKMJFPEFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2340", Offset = "0x2BA0F40", VA = "0x182BA2340")]
	private static void JKHHHBCBGJA<T>(int GBDBEHMLPLF, NativeArray<T> GPNICIOAKLH, int INGCLKPLIOP, [Optional] T FMKMJFPEFMA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x72FD1B0", Offset = "0x72FBDB0", VA = "0x1872FD1B0")]
	private void EIAGPOGIDHM(IEnumerable<HPHEOLFFIJH> LEBHLIICIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x72FDFB0", Offset = "0x72FCBB0", VA = "0x1872FDFB0")]
	private void IEFMBKDOJKL(HPHEOLFFIJH PJHPJJJFNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x72FE2F0", Offset = "0x72FCEF0", VA = "0x1872FE2F0")]
	private JBOEOFCJHBN NMPOGPFNLNJ(int LBFDIIFJGLD)
	{
		return default(JBOEOFCJHBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x72FCFB0", Offset = "0x72FBBB0", VA = "0x1872FCFB0")]
	public void CPDHEFIKKLC(float EEKPCPEPHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x72FDE00", Offset = "0x72FCA00", VA = "0x1872FDE00")]
	private void HKKKKIMGJDO(Action PFJBMEMCGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x72FD550", Offset = "0x72FC150", VA = "0x1872FD550")]
	private void EJMNNEBGJPJ(Action PFJBMEMCGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x72FD5D0", Offset = "0x72FC1D0", VA = "0x1872FD5D0")]
	public void ENEBGPAFFKA(float EEKPCPEPHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x72FE070", Offset = "0x72FCC70", VA = "0x1872FE070")]
	public void JPLCCCCJMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x72FE550", Offset = "0x72FD150", VA = "0x1872FE550")]
	public void OCHLBECONCM(EKIHODPNLPP ONOPPEELAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x72FDCD0", Offset = "0x72FC8D0", VA = "0x1872FDCD0")]
	public void FABDCMLDAHP(EKIHODPNLPP ONOPPEELAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x72FDE80", Offset = "0x72FCA80", VA = "0x1872FDE80")]
	public void ICICNFCOLAJ(EKIHODPNLPP ONOPPEELAMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class LLMNFFBINBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static readonly LLMNFFBINBK ECELLENMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Action LCEGNFFKCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool KFHJMPBIANF;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	public LLMNFFBINBK(Action LCEGNFFKCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6C40", Offset = "0x6AA5840", VA = "0x186AA6C40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface POBEPFCFMAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T JCMGPEFMEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable LNIPNAJCJOM(UnityEngine.Object NGDLPEOFMHL, Action<T> AJFHEAEFBMC);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface EKGPKGAAHCK<T> : POBEPFCFMAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T JCMGPEFMEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class PBFLICANKKL<T> : EKGPKGAAHCK<T>, POBEPFCFMAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class OFGPIDIKGKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public PBFLICANKKL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public EKIHDDBHECE<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public OFGPIDIKGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4654AC0", Offset = "0x46536C0", VA = "0x184654AC0")]
		internal void ABKCHFIDNAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static GameObject NJIHFAEPFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<EKIHDDBHECE<UnityEngine.Object, Action<T>>> LGGDJGPDCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private T LCJJJCBDDGO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T JCMGPEFMEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x933850", Offset = "0x932450", VA = "0x180933850", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x47579B0", Offset = "0x47565B0", VA = "0x1847579B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4757240", Offset = "0x4755E40", VA = "0x184757240")]
	private static bool AFKHOBELGKD(T PFJBMEMCGDE, T GCHHKKAJBGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4757EA0", Offset = "0x4756AA0", VA = "0x184757EA0")]
	public PBFLICANKKL(T LOCLPBENLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4757B20", Offset = "0x4756720", VA = "0x184757B20", Slot = "6")]
	public IDisposable LNIPNAJCJOM(UnityEngine.Object NGDLPEOFMHL, Action<T> AJFHEAEFBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4757310", Offset = "0x4755F10", VA = "0x184757310")]
	private void CKGMJEOBBJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class MOOIDIABOFJ : KCHLGIEIAKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly BJNEKIMFDFF FKOADFMJKFD;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7301E50", Offset = "0x7300A50", VA = "0x187301E50")]
	[DHOHFCLMOGD(IDHBAGABJJA.None)]
	private static void MHPOAGMJOPB(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	[Preserve]
	internal MOOIDIABOFJ([POJODGKFIMO(null)] BJNEKIMFDFF FKOADFMJKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7301EC0", Offset = "0x7300AC0", VA = "0x187301EC0", Slot = "4")]
	public IDisposable OBNGGAFGEPI(float HKAKHDAKBJP, Action<float> LABOKGHKKOB, bool PDKPDEIHMPB = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class PJFDBJNLGJE : EAABIJBJFJH, BJNEKIMFDFF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private JPMBEDPFGJM[] BDHIDAIIBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private CDBOAGDAKDC BCFCJPIALLD;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7307670", Offset = "0x7306270", VA = "0x187307670")]
	[DHOHFCLMOGD(IDHBAGABJJA.None)]
	private static void MHPOAGMJOPB(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7307910", Offset = "0x7306510", VA = "0x187307910")]
	[Preserve]
	public PJFDBJNLGJE([POJODGKFIMO(null)] MLOMOJCGHGM COHIFHALIDP, [POJODGKFIMO(null)] HDCHBMEICCP KKOFCHGOIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7306E00", Offset = "0x7305A00", VA = "0x187306E00", Slot = "17")]
	public override NHMNIEJFONC BJOPECJFGAN(OLOCNFFOAIH NGDLPEOFMHL, IEnumerator<ELFHCGFNHNJ> KAMECJOPDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x73070E0", Offset = "0x7305CE0", VA = "0x1873070E0", Slot = "18")]
	public override void LEJCELDJPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x73076E0", Offset = "0x73062E0", VA = "0x1873076E0", Slot = "20")]
	public override void OGKAFHLNOLN(FOIAJFPEJEL PDEMIPPDIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7307370", Offset = "0x7305F70", VA = "0x187307370", Slot = "19")]
	protected override void LMJHDDPLKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x73070B0", Offset = "0x7305CB0", VA = "0x1873070B0")]
	private JPMBEDPFGJM HFMMJKEKNAA(FOIAJFPEJEL HGPIKDLKBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7307440", Offset = "0x7306040", VA = "0x187307440", Slot = "21")]
	internal override KOFPINAMJHD MCKGIKJMHKG(IEnumerator<ELFHCGFNHNJ> KAMECJOPDLA, Behaviour NGDLPEOFMHL, MGKNLBKJAHJ DHNJBCEHKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7306D80", Offset = "0x7305980", VA = "0x187306D80", Slot = "22")]
	internal override MEDLAIMCOJN ANEAKCNCMKG(FOIAJFPEJEL LAHIJHGJIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7306F30", Offset = "0x7305B30", VA = "0x187306F30")]
	private void DNKPFONHEAG(JPMBEDPFGJM PFPDEKMJOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7307050", Offset = "0x7305C50", VA = "0x187307050", Slot = "23")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[BurstCompile]
internal struct CPNMJKIIEKP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	public float KBNLNKENEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public int DAHEEFDHMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> HOEMNGHEIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> NCAHJIBGLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> GBDEFHDHGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	public NativeArray<PHLJPPJIAJL> OLIOKJIICEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<float> HKKKACEHMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[WriteOnly]
	public NativeArray<int> ILPAHAGEJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> LHHMKBHAPAJ;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x72EE4A0", Offset = "0x72ED0A0", VA = "0x1872EE4A0")]
	public static CPNMJKIIEKP NCPDNLLGMJA(int DNKGDPHJOPK, float EEKPCPEPHMO, NativeArray<PHLJPPJIAJL> DBMMKEMCCNH, NativeArray<float> HLNPDEBPFCA, NativeArray<int> DOKMMKFNFCL, NativeArray<int> PIACENAGNIN, NativeArray<int> NDLPGAIAHKM, NativeArray<int> NCAHJIBGLOC, NativeArray<int> GBDEFHDHGLM)
	{
		return default(CPNMJKIIEKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x72EE2B0", Offset = "0x72ECEB0", VA = "0x1872EE2B0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x72EE460", Offset = "0x72ED060", VA = "0x1872EE460")]
	private bool MDCBBKHHKJL(int BAEBMIBABAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x72EE390", Offset = "0x72ECF90", VA = "0x1872EE390")]
	private void KDOGAHLNPBB(NativeArray<int> EEOPKPJBOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x72EE3C0", Offset = "0x72ECFC0", VA = "0x1872EE3C0")]
	private int LMAMCGDPOBL(int JHPFCACDNFF, int HGIGOLLAJKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x72EE1E0", Offset = "0x72ECDE0", VA = "0x1872EE1E0")]
	private void DDGLIKKINMH(NativeArray<int> EEOPKPJBOEH, int DACBOANPJIL, int GKPLDDEPNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x72EE500", Offset = "0x72ED100", VA = "0x1872EE500")]
	private void PEJALFDMNDP(NativeArray<int> EEOPKPJBOEH, int LJNOAEDIMMD, int DPHOFEHGMPL, int MMPPMLMKFDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class EAABIJBJFJH : BJNEKIMFDFF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly MLOMOJCGHGM COHIFHALIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected readonly HDCHBMEICCP KKOFCHGOIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private MEDLAIMCOJN[] FCNMEBOKMKF;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static BJNEKIMFDFF NKKNEDDGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x72F5860", Offset = "0x72F4460", VA = "0x1872F5860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool FIIEBMHFBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public FOIAJFPEJEL KLJILNHPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x863DA0", VA = "0x1808651A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FOIAJFPEJEL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x868D10", Offset = "0x867910", VA = "0x180868D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public HDCHBMEICCP BLEJPGHMDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public ELFHCGFNHNJ KFNELGJJKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public ELFHCGFNHNJ GKDOBOMGMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x86A490", Offset = "0x869090", VA = "0x18086A490", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x72F54B0", Offset = "0x72F40B0", VA = "0x1872F54B0")]
	public static NHMNIEJFONC LINDAHAIEFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x72F5910", Offset = "0x72F4510", VA = "0x1872F5910")]
	[Preserve]
	protected EAABIJBJFJH([POJODGKFIMO(null)] MLOMOJCGHGM COHIFHALIDP, [POJODGKFIMO(null)] HDCHBMEICCP KKOFCHGOIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x72F5580", Offset = "0x72F4180", VA = "0x1872F5580", Slot = "6")]
	public NHMNIEJFONC MGFNPLKOLEC(IEnumerator<ELFHCGFNHNJ> KAMECJOPDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x72F5590", Offset = "0x72F4190", VA = "0x1872F5590", Slot = "7")]
	public NHMNIEJFONC MGFNPLKOLEC(Behaviour NGDLPEOFMHL, IEnumerator<ELFHCGFNHNJ> KAMECJOPDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract NHMNIEJFONC BJOPECJFGAN(OLOCNFFOAIH NGDLPEOFMHL, IEnumerator<ELFHCGFNHNJ> KAMECJOPDLA);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x72F5310", Offset = "0x72F3F10", VA = "0x1872F5310", Slot = "18")]
	public virtual void LEJCELDJPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x72F49F0", Offset = "0x72F35F0", VA = "0x1872F49F0", Slot = "9")]
	public void CJDMKFIJHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x72F5540", Offset = "0x72F4140", VA = "0x1872F5540", Slot = "19")]
	protected virtual void LMJHDDPLKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x72F5050", Offset = "0x72F3C50", VA = "0x1872F5050")]
	private void GNINFHADBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x72F52F0", Offset = "0x72F3EF0", VA = "0x1872F52F0")]
	private void KNFLAMHGCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x72F5790", Offset = "0x72F4390", VA = "0x1872F5790")]
	private void ODKIHACCDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x72F5560", Offset = "0x72F4160", VA = "0x1872F5560")]
	private void LPBJNGIPPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x72F57B0", Offset = "0x72F43B0", VA = "0x1872F57B0")]
	private void OFKJPNCHDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x72F49D0", Offset = "0x72F35D0", VA = "0x1872F49D0")]
	private void ALGENDAAHLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x72F5100", Offset = "0x72F3D00", VA = "0x1872F5100")]
	private void JNABNPCECHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x72F57D0", Offset = "0x72F43D0", VA = "0x1872F57D0", Slot = "20")]
	public virtual void OGKAFHLNOLN(FOIAJFPEJEL PDEMIPPDIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x72F5120", Offset = "0x72F3D20", VA = "0x1872F5120")]
	private void JOIKFFFOHIL(MEDLAIMCOJN PFPDEKMJOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1ED2340", Offset = "0x1ED0F40", VA = "0x181ED2340")]
	private MEDLAIMCOJN NJCEEGHAGLP(FOIAJFPEJEL HGPIKDLKBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract KOFPINAMJHD MCKGIKJMHKG(IEnumerator<ELFHCGFNHNJ> KAMECJOPDLA, Behaviour GNLCCILBHCO, MGKNLBKJAHJ CGENDMBBPAB);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract MEDLAIMCOJN ANEAKCNCMKG(FOIAJFPEJEL PDEMIPPDIGP);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x72F4C30", Offset = "0x72F3830", VA = "0x1872F4C30", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x72F58B0", Offset = "0x72F44B0", VA = "0x1872F58B0", Slot = "13")]
	public ELFHCGFNHNJ PLMEKNEMFIF(FOIAJFPEJEL LAHIJHGJIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x72F5070", Offset = "0x72F3C70", VA = "0x1872F5070", Slot = "14")]
	public ELFHCGFNHNJ IMBCJIMGLOI(float JACNKEDDJOJ, FOIAJFPEJEL LAHIJHGJIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x72F4FF0", Offset = "0x72F3BF0", VA = "0x1872F4FF0", Slot = "15")]
	public ELFHCGFNHNJ EFAMNPIMHNC(Func<bool> FFGGIJJLJGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class KOFPINAMJHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly MGKNLBKJAHJ DHNJBCEHKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly KDEGKOGKBMF NGDLPEOFMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly bool CINLGCGPBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private string LONKACOOPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private StackTrace CKDBAIEDEIF;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerator<ELFHCGFNHNJ> PMPFKNHDJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public ELFHCGFNHNJ ALEHLCIDEAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x868D60", Offset = "0x867960", VA = "0x180868D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool NMGELHCPDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x72FF370", Offset = "0x72FDF70", VA = "0x1872FF370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool CBCBMPNHIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A40", Offset = "0x9F8640", VA = "0x1809F9A40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B60", Offset = "0x9F8760", VA = "0x1809F9B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x72FF700", Offset = "0x72FE300", VA = "0x1872FF700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float JPCPFKABEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D40", Offset = "0x8D0940", VA = "0x1808D1D40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5F57D40", Offset = "0x5F56940", VA = "0x185F57D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x72FF9E0", Offset = "0x72FE5E0", VA = "0x1872FF9E0")]
	public KOFPINAMJHD(IEnumerator<ELFHCGFNHNJ> PDNPGMLFMHH, KDEGKOGKBMF NGDLPEOFMHL, MGKNLBKJAHJ DHNJBCEHKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x72FF3F0", Offset = "0x72FDFF0", VA = "0x1872FF3F0")]
	public ELFHCGFNHNJ LKEBPPHDKOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x72FF300", Offset = "0x72FDF00", VA = "0x1872FF300")]
	public bool CMDAJJDBBIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x72FF8B0", Offset = "0x72FE4B0", VA = "0x1872FF8B0")]
	public void OCHLBECONCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x72FF900", Offset = "0x72FE500", VA = "0x1872FF900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA93360", Offset = "0xA91F60", VA = "0x180A93360")]
	[CompilerGenerated]
	private void KFCBPEECNIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class MGKNLBKJAHJ : PNPDNAMOFGM, NHMNIEJFONC, OECOIGMFBKH, HNHMCBNIKDD, IEnumerator, ELFHCGFNHNJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private FOIAJFPEJEL CMCOADENOLN;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private FOIAJFPEJEL MHNAPDDNPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x1030750", Offset = "0x102F350", VA = "0x181030750", Slot = "23")]
		get
		{
			return default(FOIAJFPEJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public FOIAJFPEJEL GKPNFLPCJJL
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1565080", Offset = "0x1563C80", VA = "0x181565080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private float GFELJEBNENG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA256D0", Offset = "0xA242D0", VA = "0x180A256D0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool HGLBEHDDEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7301BE0", Offset = "0x73007E0", VA = "0x187301BE0", Slot = "24")]
	private bool DLIKIOJBIGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7301C00", Offset = "0x7300800", VA = "0x187301C00", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7301C10", Offset = "0x7300810", VA = "0x187301C10")]
	public MGKNLBKJAHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal enum JBOEOFCJHBN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal sealed class MEDLAIMCOJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum JHDKDNNMOBG
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct BHEFDNJFDON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public FOIAJFPEJEL PMBDMAGCLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public JHDKDNNMOBG AKJDAIIDJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<KOFPINAMJHD> IAKGNAKDJNP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly JHDKDNNMOBG[] EEDLCMKAPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly FOIAJFPEJEL PDEMIPPDIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private bool MLODPHMBHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly KOFPINAMJHD[] LNDNHJDILBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<KOFPINAMJHD> FAOEFDJCDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> HIBJABDKMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly List<KOFPINAMJHD> JOPBFAGPAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Stack<int> PDGIBBEKDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly CDBOAGDAKDC OIMEEDFNFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private bool CJACEAJHJAH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public BHEFDNJFDON[,] PLFCHPCLCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x86C7D0", Offset = "0x86B3D0", VA = "0x18086C7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7301730", Offset = "0x7300330", VA = "0x187301730")]
	public MEDLAIMCOJN(FOIAJFPEJEL LAHIJHGJIIE, CDBOAGDAKDC OIMEEDFNFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7300860", Offset = "0x72FF460", VA = "0x187300860")]
	public void EPFGNJAPEOC(KOFPINAMJHD PDNPGMLFMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7300580", Offset = "0x72FF180", VA = "0x187300580")]
	public void EIOJEEHMEAP(IList<KOFPINAMJHD> DJBMAKJGOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7300BA0", Offset = "0x72FF7A0", VA = "0x187300BA0")]
	public void IMPKGGLFOBE(IList<KOFPINAMJHD> DJBMAKJGOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7300970", Offset = "0x72FF570", VA = "0x187300970")]
	private void ICJHLJOGLBB(KOFPINAMJHD PDNPGMLFMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7300E80", Offset = "0x72FFA80", VA = "0x187300E80")]
	private void JGPNHIPFGNO(IList<KOFPINAMJHD> DJBMAKJGOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7301470", Offset = "0x7300070", VA = "0x187301470")]
	private JBOEOFCJHBN MHNKEOANBLL(KOFPINAMJHD PDNPGMLFMHH)
	{
		return default(JBOEOFCJHBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7301300", Offset = "0x72FFF00", VA = "0x187301300")]
	public void LMJHDDPLKGM(float EEKPCPEPHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7300270", Offset = "0x72FEE70", VA = "0x187300270")]
	public void CJDMKFIJHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7301000", Offset = "0x72FFC00", VA = "0x187301000")]
	private void KGMDOLNNPFA(List<KOFPINAMJHD> DJBMAKJGOIJ, Stack<int> OIBPLPDOBMH, bool DPGCKAFNCAH, float OHKIMHEBJAD = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7300460", Offset = "0x72FF060", VA = "0x187300460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7300A60", Offset = "0x72FF660", VA = "0x187300A60")]
	private void IMLBLGMHKFA(List<KOFPINAMJHD> DJBMAKJGOIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class PMOLOECJACM : CDBOAGDAKDC
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "4")]
	public void OCPFDICAFMF(string LONKACOOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
	public void GAHPDHMLHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public PMOLOECJACM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class KJJIJOCICKM : KDEGKOGKBMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly Behaviour GNLCCILBHCO;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x72FF220", Offset = "0x72FDE20", VA = "0x1872FF220", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool DJLGOGBINMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x72FF1D0", Offset = "0x72FDDD0", VA = "0x1872FF1D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool JNDHGMBJHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x72FF1B0", Offset = "0x72FDDB0", VA = "0x1872FF1B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	public KJJIJOCICKM(Behaviour GNLCCILBHCO)
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

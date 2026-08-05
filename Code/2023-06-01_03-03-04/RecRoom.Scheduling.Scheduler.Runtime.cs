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
public class NFEMKDMIHPG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority BCEOLJLILBC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x544BD30", Offset = "0x544A930", VA = "0x18544BD30")]
	public NFEMKDMIHPG(ThreadPriority JHKIBDAHBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x544BD20", Offset = "0x544A920", VA = "0x18544BD20", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> HGEKJFGCFGL(List<PlayerLoopSystem> KHIAODMJMEB, int FCMMMFGOBAF);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct LMDKGMAICCC
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct IABGMPCOGLC
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static KBJOPGEOOCH EDCPMBCOLKG;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x5441C90", Offset = "0x5440890", VA = "0x185441C90")]
				public static PlayerLoopSystem AJHKLGALMBI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct GFCKKBFFMGF
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static KBJOPGEOOCH KPMGDJFMKKL;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x543ED00", Offset = "0x543D900", VA = "0x18543ED00")]
				public static PlayerLoopSystem AJHKLGALMBI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct PAJCOALHDNL
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static KBJOPGEOOCH OCJGBDGIEKJ;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x544CAA0", Offset = "0x544B6A0", VA = "0x18544CAA0")]
				public static PlayerLoopSystem AJHKLGALMBI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct PKOAFAIIGDL
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static KBJOPGEOOCH GNPJCKKLOHO;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static KBJOPGEOOCH COPGOLLEPLA;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static KBJOPGEOOCH OMFKFJFOFJG;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static KBJOPGEOOCH NJNKJGCBKPK;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x544CE80", Offset = "0x544BA80", VA = "0x18544CE80")]
				public static PlayerLoopSystem AJHKLGALMBI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct NIJPIMHIIEF
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static KBJOPGEOOCH ADEGKELHBPD;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x544BD70", Offset = "0x544A970", VA = "0x18544BD70")]
				public static PlayerLoopSystem AJHKLGALMBI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct EBCALCNOJED
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static KBJOPGEOOCH GNPJCKKLOHO;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static KBJOPGEOOCH COPGOLLEPLA;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static KBJOPGEOOCH OMFKFJFOFJG;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static KBJOPGEOOCH NJNKJGCBKPK;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x543CC90", Offset = "0x543B890", VA = "0x18543CC90")]
				public static PlayerLoopSystem AJHKLGALMBI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct OKGMIJAGHHM
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static KBJOPGEOOCH MDKKIKDHKJO;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x544C890", Offset = "0x544B490", VA = "0x18544C890")]
				public static PlayerLoopSystem AJHKLGALMBI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct NIOIJIBDEOF
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static KBJOPGEOOCH AALBICKFCLI;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x544BF80", Offset = "0x544AB80", VA = "0x18544BF80")]
				public static PlayerLoopSystem AJHKLGALMBI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct MDONNACACKG
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static KBJOPGEOOCH NFCAAOENLGH;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x5447BB0", Offset = "0x54467B0", VA = "0x185447BB0")]
				public static PlayerLoopSystem AJHKLGALMBI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct ENIGDPMKJOO
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static KBJOPGEOOCH HIBDKNPFJFP;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x543E2A0", Offset = "0x543CEA0", VA = "0x18543E2A0")]
				public static PlayerLoopSystem AJHKLGALMBI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct BLLBHFOALPA
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static KBJOPGEOOCH BMPOFCDMIDH;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x54370C0", Offset = "0x5435CC0", VA = "0x1854370C0")]
				public static PlayerLoopSystem AJHKLGALMBI()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public enum ICMMDNMKDLK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct NNKBMCMHLPP
			{
				[Cpp2IlInjected.Token(Token = "0x200001E")]
				[CompilerGenerated]
				private sealed class CHHGPDOIOLE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					public ICMMDNMKDLK updateStage;

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
					public CHHGPDOIOLE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x5437B00", Offset = "0x5436700", VA = "0x185437B00")]
					internal void PBPHJGEBDNH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static NAOGJOJMPFD<ICMMDNMKDLK> CKEENCHNAJJ;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x544C190", Offset = "0x544AD90", VA = "0x18544C190")]
				public static PlayerLoopSystem AJHKLGALMBI(ICMMDNMKDLK OOPLOBFMMMP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct JPCACLFANEN
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class DLNAHODIBEL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public ILGLNBGPBBN.AJAFGBBLMDL key;

					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
					public DLNAHODIBEL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x543C7F0", Offset = "0x543B3F0", VA = "0x18543C7F0")]
					internal void EBCNFKMDGLC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000035")]
				public static IDisposable MEJBAFBLFAK;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x5443F90", Offset = "0x5442B90", VA = "0x185443F90")]
				public static PlayerLoopSystem NNNONAMEHFA(ILGLNBGPBBN.AJAFGBBLMDL BDFCACLHAFA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			internal struct JCJIJONCNID
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				[CompilerGenerated]
				private sealed class FAOGAOFECFB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public ILGLNBGPBBN.AJAFGBBLMDL key;

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
					public FAOGAOFECFB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x543E690", Offset = "0x543D290", VA = "0x18543E690")]
					internal void EBCNFKMDGLC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x5442730", Offset = "0x5441330", VA = "0x185442730")]
				public static PlayerLoopSystem NNNONAMEHFA(ILGLNBGPBBN.AJAFGBBLMDL BDFCACLHAFA)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class FGEECPLIIHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public FGEECPLIIHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x543E920", Offset = "0x543D520", VA = "0x18543E920")]
			internal List<PlayerLoopSystem> PKAHBAKHJGF(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool GKAMIJGCCFC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool NGPHNLGEOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x543AC20", Offset = "0x5439820", VA = "0x18543AC20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x543BF70", Offset = "0x543AB70", VA = "0x18543BF70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5438370", Offset = "0x5436F70", VA = "0x185438370")]
		private static void AIDMHJNNILC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x543B280", Offset = "0x5439E80", VA = "0x18543B280")]
		private static void KNIAFOACMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x543AC60", Offset = "0x5439860", VA = "0x18543AC60")]
		private static void DJJJMECMMOH(string GBCIBIFAJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x543A9F0", Offset = "0x54395F0", VA = "0x18543A9F0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x543AF90", Offset = "0x5439B90", VA = "0x18543AF90")]
		private static void HKDHEJOEJMG(ILGLNBGPBBN.AJAFGBBLMDL BDFCACLHAFA, ref PlayerLoopSystem JJJNLMNGKIP, Type EEBPJPAJJMI, Type LMHJCBIOFAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x543BB50", Offset = "0x543A750", VA = "0x18543BB50")]
		private static void MNLEDNHKHAJ(ref PlayerLoopSystem JJJNLMNGKIP, Type EEBPJPAJJMI, Type LMHJCBIOFAJ, HGEKJFGCFGL GMKMBAGOCJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x543B150", Offset = "0x5439D50", VA = "0x18543B150")]
		private static void KJBHAMGHEGB(ref PlayerLoopSystem JJJNLMNGKIP, Type EEBPJPAJJMI, Type LMHJCBIOFAJ, PlayerLoopSystem? NOOIONLLDCD, PlayerLoopSystem? DGDBOHMJIGJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class ILGLNBGPBBN
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public enum AJAFGBBLMDL
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class KGCDJDDEHPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly AJAFGBBLMDL HJCEDOOJJLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly OGCKCENOJFH OPGJDMBDKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private long BAHOEHOOJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private long NHIEONFMGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long KNADIBLEPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int AHAEEDCMHOG;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5444AF0", Offset = "0x54436F0", VA = "0x185444AF0")]
		public KGCDJDDEHPF(AJAFGBBLMDL CHDMLABPAFA, int LGIEKLJJONB = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5444880", Offset = "0x5443480", VA = "0x185444880")]
		public void OEHNABKAGHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5444820", Offset = "0x5443420", VA = "0x185444820")]
		public void NKDGDBAMEGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x54448F0", Offset = "0x54434F0", VA = "0x1854448F0")]
		public void PPJKFJAINJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static AJAFGBBLMDL[] IEAPDCAIAIC;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static KGCDJDDEHPF[] OICJKMMAOFD;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5442210", Offset = "0x5440E10", VA = "0x185442210")]
	public static KGCDJDDEHPF EEOKGOKGCKI(AJAFGBBLMDL BDFCACLHAFA, int LGIEKLJJONB = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5442180", Offset = "0x5440D80", VA = "0x185442180")]
	public static KGCDJDDEHPF CGMKPHLNMGA(AJAFGBBLMDL BDFCACLHAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x54423F0", Offset = "0x5440FF0", VA = "0x1854423F0")]
	public static void HNGGDKEFJMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class CHPCANDAKKN
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private interface HMNPAGLFLOM
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool JMBNEAPFBDN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KOGMCNBOFCI();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private abstract class LKKKKLGIBCL<TPromise, TMainThreadPromise> : HMNPAGLFLOM where TPromise : EILHPPDHBHH where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly TPromise NNEKKHKOFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		protected readonly TMainThreadPromise MHOKOAADDEF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TPromise GAAOFDBLIMM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x34C3480", Offset = "0x34C2080", VA = "0x1834C3480")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JMBNEAPFBDN
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x34C34E0", Offset = "0x34C20E0", VA = "0x1834C34E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2970F20", Offset = "0x296FB20", VA = "0x182970F20")]
		protected LKKKKLGIBCL(TPromise NNEKKHKOFNA, TMainThreadPromise MBJEECHAGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x34C3530", Offset = "0x34C2130", VA = "0x1834C3530", Slot = "5")]
		public void KOGMCNBOFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void LECFIMLDKKH(TPromise NNEKKHKOFNA);
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class NKHIPOIKNEE<T> : LKKKKLGIBCL<NBFPPJGKGOH<T>, GBNOCCBNCBC<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x38B9680", Offset = "0x38B8280", VA = "0x1838B9680")]
		public NKHIPOIKNEE(NBFPPJGKGOH<T> NNEKKHKOFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x38B9440", Offset = "0x38B8040", VA = "0x1838B9440", Slot = "6")]
		protected override void LECFIMLDKKH(NBFPPJGKGOH<T> NNEKKHKOFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x38B9650", Offset = "0x38B8250", VA = "0x1838B9650")]
		[CompilerGenerated]
		private void LLKFMHKOPPI(T IIMBBHEIGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1B13E10", Offset = "0x1B12A10", VA = "0x181B13E10")]
		[CompilerGenerated]
		private void EFLOKAFGBFE(string FKPBDLDGFCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class DGAJMLPBMBN : HMNPAGLFLOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly Action FOGMDOMFJBB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JMBNEAPFBDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7F5D00", Offset = "0x7F4900", VA = "0x1807F5D00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
		public DGAJMLPBMBN(Action FOGMDOMFJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1588C40", Offset = "0x1587840", VA = "0x181588C40", Slot = "5")]
		public void KOGMCNBOFCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<HMNPAGLFLOM> FBOHEDCPAMF;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F970", Offset = "0x2C6E570", VA = "0x182C6F970")]
	public static NBFPPJGKGOH<T> ICJNHIKMAKJ<T>(this NBFPPJGKGOH<T> NNEKKHKOFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5437C90", Offset = "0x5436890", VA = "0x185437C90")]
	public static void ICJNHIKMAKJ(Action FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F9E0", Offset = "0x2C6E5E0", VA = "0x182C6F9E0")]
	private static NBFPPJGKGOH<T> LLPDBGLFLHI<T>(NBFPPJGKGOH<T> NNEKKHKOFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5437D20", Offset = "0x5436920", VA = "0x185437D20")]
	private static void MJFCPJAKNBB(HMNPAGLFLOM FJIPEECKEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5437F20", Offset = "0x5436B20", VA = "0x185437F20")]
	private static void NOKMFOKCMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5437B90", Offset = "0x5436790", VA = "0x185437B90")]
	private static void FPNCEHMMCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5438220", Offset = "0x5436E20", VA = "0x185438220")]
	private static void OAHOGBKNPMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class HNMHNHLBAJO
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private struct LBJANCAFBGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<Scene> JFODFKPAFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly string KPMIPNBJALP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly LoadSceneMode GGEPKHEIMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly bool DJJMALJEJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5447B50", Offset = "0x5446750", VA = "0x185447B50")]
		public LBJANCAFBGL(TaskCompletionSource<Scene> BFLDPIIJLEC, string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON, bool DJJMALJEJII, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AIHJCFJLPON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private JAPPGKMKBNF<string> <toDispose>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private BDPOMAKGMDN <stackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private LBJANCAFBGL <queuedSceneLoad>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public AIHJCFJLPON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5435BC0", Offset = "0x54347C0", VA = "0x185435BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class HCFIBNDNMJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HCFIBNDNMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x543FB50", Offset = "0x543E750", VA = "0x18543FB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class AODDGPDCLCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private LBJANCAFBGL <dequeued>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Scene <scene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Scene <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public AODDGPDCLCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x54362F0", Offset = "0x5434EF0", VA = "0x1854362F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class CGOABEKACFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public GBNOCCBNCBC<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CGOABEKACFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5437AA0", Offset = "0x54366A0", VA = "0x185437AA0")]
		internal void FCNKJKJPPGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class BIEKGPFMICL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <loadSceneTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private CGOABEKACFF <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool <shouldLoadEmptyScene>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Scene <emptyScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Scene <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BIEKGPFMICL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x54366C0", Offset = "0x54352C0", VA = "0x1854366C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class PNGONIHGEKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private AsyncOperationHandle<SceneInstance> <handle>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private SceneInstance <instance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public PNGONIHGEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x544D4C0", Offset = "0x544C0C0", VA = "0x18544D4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class NCDNPPBANJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Scene <emptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <emptySceneRoutineTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <emptySceneTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NCDNPPBANJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5449B50", Offset = "0x5448750", VA = "0x185449B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JBNBAOEMGCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JBNBAOEMGCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5442700", Offset = "0x5441300", VA = "0x185442700")]
		internal bool AKKGOEEKCEO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class EGPMEELCOOB : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public GIELIJKIODJ onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private IDisposable <sample>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private JBNBAOEMGCD <>8__3;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x96C5D0", Offset = "0x96B1D0", VA = "0x18096C5D0")]
		[DebuggerHidden]
		public EGPMEELCOOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x543DCD0", Offset = "0x543C8D0", VA = "0x18543DCD0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x543D910", Offset = "0x543C510", VA = "0x18543D910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x543D8C0", Offset = "0x543C4C0", VA = "0x18543D8C0")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x543DC90", Offset = "0x543C890", VA = "0x18543DC90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class HAIEMPEJPNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public GBNOCCBNCBC<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HAIEMPEJPNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x543FAD0", Offset = "0x543E6D0", VA = "0x18543FAD0")]
		internal bool OPGMNJDFPKH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x543F860", Offset = "0x543E460", VA = "0x18543F860")]
		internal void BMNLLEMCMFL(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class DDLHKFGCKLC : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public GBNOCCBNCBC<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private HAIEMPEJPNE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x96C5D0", Offset = "0x96B1D0", VA = "0x18096C5D0")]
		[DebuggerHidden]
		public DDLHKFGCKLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x543BFB0", Offset = "0x543ABB0", VA = "0x18543BFB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x543C7B0", Offset = "0x543B3B0", VA = "0x18543C7B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly ICollection<string> GINGCBGKKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static EILHPPDHBHH JJINHNGOKIH;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AsyncOperation OJPKBGKEFAA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static EILHPPDHBHH NLOBILAHAAA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static string GKPONFOALDF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ThreadPriority PMODGLGMCLG;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Task KHKIJKDINFM;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static List<SceneInstance> HNLALHEMFPG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly Queue<LBJANCAFBGL> NEDJFCCBDDD;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task ANPLHLOOPLN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool MNENNOAHDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5441430", Offset = "0x5440030", VA = "0x185441430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool KOHLOAGPOKL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x54406B0", Offset = "0x543F2B0", VA = "0x1854406B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private static bool MCNDKCCKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5440EA0", Offset = "0x543FAA0", VA = "0x185440EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static bool DFKHFGLGHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5440870", Offset = "0x543F470", VA = "0x185440870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> DCHHILCILAD
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5440770", Offset = "0x543F370", VA = "0x185440770")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x54400F0", Offset = "0x543ECF0", VA = "0x1854400F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5441270", Offset = "0x543FE70", VA = "0x185441270")]
	[AGOCEKPENPF(ANODGEDDMCH.EnteredEditModeNextFrame, 0)]
	private static void MOACIJIIPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x54416B0", Offset = "0x54402B0", VA = "0x1854416B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AIHJCFJLPON))]
	public static Task<Scene> PNEPKELPBPK(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON = LoadSceneMode.Single, bool DJJMALJEJII = false, [Optional] JAPPGKMKBNF<string>.KLCBHAGBNOA BKBDOJIIGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5440DA0", Offset = "0x543F9A0", VA = "0x185440DA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HCFIBNDNMJI))]
	private static Task JKFGDLCDIML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x543FFF0", Offset = "0x543EBF0", VA = "0x18543FFF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AODDGPDCLCP))]
	private static Task EFIIFDOEBHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5440F60", Offset = "0x543FB60", VA = "0x185440F60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BIEKGPFMICL))]
	private static Task<Scene> MCDIDPMNHDD(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON, bool DJJMALJEJII, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5441340", Offset = "0x543FF40", VA = "0x185441340")]
	private static void NCADNLHCHOB(SceneInstance PKIKEDNMDGD, LoadSceneMode GGEPKHEIMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5440920", Offset = "0x543F520", VA = "0x185440920")]
	private static void IPPFNLLBICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5441110", Offset = "0x543FD10", VA = "0x185441110")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PNGONIHGEKG))]
	private static Task<Scene> MKNCFGMCDGI(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x543FF00", Offset = "0x543EB00", VA = "0x18543FF00")]
	private static bool CHELJKHIFGH(string KPMIPNBJALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x54409C0", Offset = "0x543F5C0", VA = "0x1854409C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NCDNPPBANJO))]
	private static Task<Scene> JAGJNBNMDNL(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5440B10", Offset = "0x543F710", VA = "0x185440B10")]
	public static NBFPPJGKGOH<Scene> JAKPCMBCPGG(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x54401F0", Offset = "0x543EDF0", VA = "0x1854401F0")]
	public static EILHPPDHBHH FDCPICCCPGC(string KPMIPNBJALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x54404C0", Offset = "0x543F0C0", VA = "0x1854404C0")]
	[IteratorStateMachine(typeof(EGPMEELCOOB))]
	private static IEnumerator<EDDHBDCNFKM> FLANFLDHAJJ(string KPMIPNBJALP, GIELIJKIODJ NGEHEMCMAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5440D00", Offset = "0x543F900", VA = "0x185440D00")]
	[IteratorStateMachine(typeof(DDLHKFGCKLC))]
	private static IEnumerator<EDDHBDCNFKM> JFPMKCCCMHB(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON, GBNOCCBNCBC<Scene> NGEHEMCMAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5440550", Offset = "0x543F150", VA = "0x185440550")]
	public static bool GIIBECOIMOJ(out string MIGFHMAKLHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class OGCKCENOJFH : HDGDCBPPIJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public int DPCADFJMPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Queue<double> KCJCIBBDFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private double FAFCDNENBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private double LDBGNHOKNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private double DPMBEPJPPPN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public double JNDLJOLGNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x544C5D0", Offset = "0x544B1D0", VA = "0x18544C5D0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double DDJGPMKEACG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x18F81B0", Offset = "0x18F6DB0", VA = "0x1818F81B0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double GIBLADJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4222930", Offset = "0x4221530", VA = "0x184222930", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x544C7E0", Offset = "0x544B3E0", VA = "0x18544C7E0")]
	public OGCKCENOJFH(int JJAMFICFNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x544C640", Offset = "0x544B240", VA = "0x18544C640", Slot = "7")]
	public void NAAMMCMMHJJ(double FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x544C770", Offset = "0x544B370", VA = "0x18544C770", Slot = "8")]
	public void NHGHFKAFNCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class GDCCMHHEMHC : HDGDCBPPIJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private long FGHOJPFDCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private double AAMLBLEHNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private double LAEMCDCGMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private double OOPBAGDOICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private double JADGPLGNHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private double FAFCDNENBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private double LDBGNHOKNMO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9897D0", Offset = "0x9883D0", VA = "0x1809897D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double DDJGPMKEACG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x543EB80", Offset = "0x543D780", VA = "0x18543EB80", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double GIBLADJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x543EB50", Offset = "0x543D750", VA = "0x18543EB50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double MMGBDCHIPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x543EB60", Offset = "0x543D760", VA = "0x18543EB60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double JNDLJOLGNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x543EB70", Offset = "0x543D770", VA = "0x18543EB70", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x543EB90", Offset = "0x543D790", VA = "0x18543EB90", Slot = "7")]
	public virtual void NAAMMCMMHJJ(double FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x543ECC0", Offset = "0x543D8C0", VA = "0x18543ECC0", Slot = "8")]
	public virtual void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x543E650", Offset = "0x543D250", VA = "0x18543E650")]
	public GDCCMHHEMHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class EPHDGBEJPMM : GDCCMHHEMHC
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public double GHONKFPHFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x543E4B0", Offset = "0x543D0B0", VA = "0x18543E4B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x543E4C0", Offset = "0x543D0C0", VA = "0x18543E4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x543E4D0", Offset = "0x543D0D0", VA = "0x18543E4D0", Slot = "7")]
	public override void NAAMMCMMHJJ(double FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x543E610", Offset = "0x543D210", VA = "0x18543E610", Slot = "8")]
	public override void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x543E650", Offset = "0x543D250", VA = "0x18543E650")]
	public EPHDGBEJPMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HDGDCBPPIJF
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	double JNDLJOLGNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double DDJGPMKEACG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	double GIBLADJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class GOOHKFNHCIL : JNCDEOLLBDP
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public float CIBIGMPFEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x543F770", Offset = "0x543E370", VA = "0x18543F770", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public float DPLBEPDJHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x543F6D0", Offset = "0x543E2D0", VA = "0x18543F6D0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public double LGNCOMMFFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x543F6E0", Offset = "0x543E2E0", VA = "0x18543F6E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x543F700", Offset = "0x543E300", VA = "0x18543F700")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	[Preserve]
	internal GOOHKFNHCIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class KMBMENJLJIN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class KAPGDHCKMCE : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public KMBMENJLJIN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x96C5D0", Offset = "0x96B1D0", VA = "0x18096C5D0")]
		[DebuggerHidden]
		public KAPGDHCKMCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x54440F0", Offset = "0x5442CF0", VA = "0x1854440F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5444190", Offset = "0x5442D90", VA = "0x185444190", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private CMHJCDCDCHH BFOGFHHJELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private MonoBehaviour CBPNGHBBIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Action KGIKOGHKBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Action<float> PGMHJLODCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float DLKFCBPMCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private bool AMKCALCHEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly MIGOFOLIJGE AHHBOMNOGMN;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5446F80", Offset = "0x5445B80", VA = "0x185446F80")]
	public KMBMENJLJIN(MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x54473D0", Offset = "0x5445FD0", VA = "0x1854473D0")]
	public KMBMENJLJIN(MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5447180", Offset = "0x5445D80", VA = "0x185447180")]
	public KMBMENJLJIN(MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5D50", Offset = "0x3FF4950", VA = "0x183FF5D50")]
	private KMBMENJLJIN(MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5446960", Offset = "0x5445560", VA = "0x185446960")]
	internal static KMBMENJLJIN JIOGLFAEKIA(MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x54463A0", Offset = "0x5444FA0", VA = "0x1854463A0")]
	private void CMKMJFNEGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5446690", Offset = "0x5445290", VA = "0x185446690")]
	private void FKBGDGHABFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5446C00", Offset = "0x5445800", VA = "0x185446C00")]
	private void KMIPOHMMBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5446DB0", Offset = "0x54459B0", VA = "0x185446DB0")]
	private void MOMJBFKPPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x54461D0", Offset = "0x5444DD0", VA = "0x1854461D0")]
	private void BJFNGAIIHFP(string FKPBDLDGFCC, Action FBPLMAHNFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x54468D0", Offset = "0x54454D0", VA = "0x1854468D0")]
	[IteratorStateMachine(typeof(KAPGDHCKMCE))]
	private IEnumerator<EDDHBDCNFKM> IBNDJFLHAGP(Action FBPLMAHNFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5446630", Offset = "0x5445230", VA = "0x185446630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5446840", Offset = "0x5445440", VA = "0x185446840")]
	[CompilerGenerated]
	private void GECEGDDOCFF(string KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5446510", Offset = "0x5445110", VA = "0x185446510")]
	[CompilerGenerated]
	private void DCBKGKHNJOH(string KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5446310", Offset = "0x5444F10", VA = "0x185446310")]
	[CompilerGenerated]
	private void CKCPBJEKDAD(string KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x54465A0", Offset = "0x54451A0", VA = "0x1854465A0")]
	[CompilerGenerated]
	private void DIGIKOHNLNI(string KIEMAGPGLGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[BurstCompile]
internal struct KOPDEKEAKGO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ReadOnly]
	public float DMNOPEMNDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[ReadOnly]
	public int GHONNIONFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeArray<int> MHKGCECPODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> IEJMMBFIOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> HOMJNINMJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ReadOnly]
	public NativeArray<ELMBAIJANLF> MPKNCKBBDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ReadOnly]
	public NativeArray<float> GOJBMIHIALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[WriteOnly]
	public NativeArray<int> IIFLNLBOPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[WriteOnly]
	public NativeArray<int> EPDBKEOMNFJ;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x54479E0", Offset = "0x54465E0", VA = "0x1854479E0")]
	public static KOPDEKEAKGO JLAKJAPJOGA(int OGLAFAPFBOH, float MLJIAJKDCFE, NativeArray<ELMBAIJANLF> AHPBELANDJJ, NativeArray<float> NEFMLNAKONK, NativeArray<int> KALAPHPLMMI, NativeArray<int> IGKGNEIMHMJ, NativeArray<int> HMIKNJPCGFN, NativeArray<int> IEJMMBFIOFJ, NativeArray<int> HOMJNINMJNP)
	{
		return default(KOPDEKEAKGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5447800", Offset = "0x5446400", VA = "0x185447800", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5447B10", Offset = "0x5446710", VA = "0x185447B10")]
	private bool NGAKJBEGOMM(int NHHNPPKPBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x54478E0", Offset = "0x54464E0", VA = "0x1854478E0")]
	private void FOOBNDDLECA(NativeArray<int> JKEPHCKPPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5447AB0", Offset = "0x54466B0", VA = "0x185447AB0")]
	private int NFNBDECIPNO(int MDEEEEEKCNL, int HJGNBNDIBBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5447910", Offset = "0x5446510", VA = "0x185447910")]
	private void IKOMAADDNEP(NativeArray<int> JKEPHCKPPCN, int EMIHEDBEOEE, int EFBLLBPFDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5447610", Offset = "0x5446210", VA = "0x185447610")]
	private void CCOMOJAIDOD(NativeArray<int> JKEPHCKPPCN, int PFENHABCJHB, int HABNNCBHCHP, int HKKOENCAMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class JENHBJAJBGG : KCLDKBLIHJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly float AFJEOLCNDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly int OAAPKFDMBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly float MDNLGAALJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly float[] FHMENKKJHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private int GAEJNMMHACA;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5442B50", Offset = "0x5441750", VA = "0x185442B50")]
	public JENHBJAJBGG(Behaviour JFDMKPDIBDL, float BOLPILLKBJN, int OAAPKFDMBIO, [Optional] Action BKAJEJMKLNN, float MDNLGAALJEO = 0f, [Optional] MIGOFOLIJGE AHHBOMNOGMN, [Optional] JNCDEOLLBDP HKCAELOIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F3460", Offset = "0x7F2060", VA = "0x1807F3460", Slot = "9")]
	protected override bool BNJNOGOKADI(Action FOGMDOMFJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5442920", Offset = "0x5441520", VA = "0x185442920", Slot = "10")]
	protected override bool LGGCKOFADIL(Action FOGMDOMFJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5442890", Offset = "0x5441490", VA = "0x185442890")]
	private void FHJIABNKHLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public abstract class JHGFKAJELKB : MIGOFOLIJGE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly EDGHCOGIIEI OEDOFDBDLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	protected readonly JNCDEOLLBDP HKCAELOIPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly DKJCBBDIGHA BHMNGDKDIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private NCJLMAILLHH[] HLNCBEFPKAM;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static MIGOFOLIJGE EABDDJEADPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x54436F0", Offset = "0x54422F0", VA = "0x1854436F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool GLGGKOPKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D00", Offset = "0x7F4900", VA = "0x1807F5D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public FAJLDPIGHEC.OCHFIJDOJPB ALFKLMICPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FAJLDPIGHEC.OCHFIJDOJPB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7F33D0", Offset = "0x7F1FD0", VA = "0x1807F33D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public JNCDEOLLBDP KCGIIBMNCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5443B50", Offset = "0x5442750", VA = "0x185443B50")]
	public static CMHJCDCDCHH PIDCALFGNFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5443BE0", Offset = "0x54427E0", VA = "0x185443BE0")]
	[Preserve]
	protected JHGFKAJELKB([ACEKLAKDMBL(null)] EDGHCOGIIEI OEDOFDBDLNG, [ACEKLAKDMBL(null)] JNCDEOLLBDP HKCAELOIPGM, [ACEKLAKDMBL(null)] DKJCBBDIGHA BHMNGDKDIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x54431F0", Offset = "0x5441DF0", VA = "0x1854431F0", Slot = "6")]
	public CMHJCDCDCHH EBDHDHCPNAJ(IEnumerator<EDDHBDCNFKM> HFKDOGILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5443200", Offset = "0x5441E00", VA = "0x185443200", Slot = "7")]
	public CMHJCDCDCHH EBDHDHCPNAJ(Behaviour JFDMKPDIBDL, IEnumerator<EDDHBDCNFKM> HFKDOGILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract CMHJCDCDCHH HHKGFKCLLJC(CAMANOLKPPF JFDMKPDIBDL, IEnumerator<EDDHBDCNFKM> HFKDOGILHAO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5443950", Offset = "0x5442550", VA = "0x185443950", Slot = "13")]
	public virtual void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5443690", Offset = "0x5442290", VA = "0x185443690", Slot = "9")]
	public void HGEFHLKMOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x218EB60", Offset = "0x218D760", VA = "0x18218EB60", Slot = "14")]
	protected virtual void CCMEEJNHHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5443740", Offset = "0x5442340", VA = "0x185443740")]
	private void KPMGDJFMKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5443B30", Offset = "0x5442730", VA = "0x185443B30")]
	private void OCJGBDGIEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5442E30", Offset = "0x5441A30", VA = "0x185442E30")]
	private void AHMPHJEIING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5442E50", Offset = "0x5441A50", VA = "0x185442E50")]
	private void CDDOLMJNADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5443760", Offset = "0x5442360", VA = "0x185443760")]
	private void MDKKIKDHKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5442E10", Offset = "0x5441A10", VA = "0x185442E10")]
	private void AALBICKFCLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5443430", Offset = "0x5442030", VA = "0x185443430")]
	private void EKIHKPHFBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5443450", Offset = "0x5442050", VA = "0x185443450", Slot = "15")]
	public virtual void GPFLMOACIOG(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5443780", Offset = "0x5442380", VA = "0x185443780")]
	private void MEFPPNKONHF(NCJLMAILLHH CBNOLLAEAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xDD84A0", Offset = "0xDD70A0", VA = "0x180DD84A0")]
	private NCJLMAILLHH HBOHAIDCKED(FAJLDPIGHEC.OCHFIJDOJPB FIJCKHKKDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract BMAPIIJHNNA LPFFKDNEANB(IEnumerator<EDDHBDCNFKM> HFKDOGILHAO, Behaviour CBPNGHBBIDH, MMAHMIICAAG AGOEJMLENBP);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract NCJLMAILLHH FJGKFECNKBE(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5442E70", Offset = "0x5441A70", VA = "0x185442E70", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class KGJJBLKGEBP : JHGFKAJELKB, MIGOFOLIJGE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private POCDKMEKJDH[] MLGLOCONFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private FBOMFECIPEF LAHJBHMHCCN;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5445250", Offset = "0x5443E50", VA = "0x185445250")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5445700", Offset = "0x5444300", VA = "0x185445700")]
	[Preserve]
	public KGJJBLKGEBP([ACEKLAKDMBL(null)] EDGHCOGIIEI OEDOFDBDLNG, [ACEKLAKDMBL(null)] JNCDEOLLBDP HKCAELOIPGM, [ACEKLAKDMBL(null)] DKJCBBDIGHA BHMNGDKDIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5445100", Offset = "0x5443D00", VA = "0x185445100", Slot = "12")]
	public override CMHJCDCDCHH HHKGFKCLLJC(CAMANOLKPPF JFDMKPDIBDL, IEnumerator<EDDHBDCNFKM> HFKDOGILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5445420", Offset = "0x5444020", VA = "0x185445420", Slot = "13")]
	public override void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5444F20", Offset = "0x5443B20", VA = "0x185444F20", Slot = "15")]
	public override void GPFLMOACIOG(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5444BF0", Offset = "0x54437F0", VA = "0x185444BF0", Slot = "14")]
	protected override void CCMEEJNHHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5444DB0", Offset = "0x54439B0", VA = "0x185444DB0")]
	private POCDKMEKJDH FNCFBPFOKGA(FAJLDPIGHEC.OCHFIJDOJPB FIJCKHKKDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x54452C0", Offset = "0x5443EC0", VA = "0x1854452C0", Slot = "16")]
	internal override BMAPIIJHNNA LPFFKDNEANB(IEnumerator<EDDHBDCNFKM> HFKDOGILHAO, Behaviour JFDMKPDIBDL, MMAHMIICAAG INGDMDMAGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5444D40", Offset = "0x5443940", VA = "0x185444D40", Slot = "17")]
	internal override NCJLMAILLHH FJGKFECNKBE(FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5444DF0", Offset = "0x54439F0", VA = "0x185444DF0")]
	private void GMFKCNKNLNM(POCDKMEKJDH CBNOLLAEAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5444CD0", Offset = "0x54438D0", VA = "0x185444CD0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class PIPFCJBPDCC
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class IKPHCFIOIFM : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public FAJLDPIGHEC.OCHFIJDOJPB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x96C5D0", Offset = "0x96B1D0", VA = "0x18096C5D0")]
		[DebuggerHidden]
		public IKPHCFIOIFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5442090", Offset = "0x5440C90", VA = "0x185442090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5442140", Offset = "0x5440D40", VA = "0x185442140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x544CCF0", Offset = "0x544B8F0", VA = "0x18544CCF0")]
	[IteratorStateMachine(typeof(IKPHCFIOIFM))]
	private static IEnumerator<EDDHBDCNFKM> LCPPGAMHGKJ(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, Func<bool> PEAFIALKKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x544CD70", Offset = "0x544B970", VA = "0x18544CD70")]
	public static CMHJCDCDCHH ONCCLGBMIGB(this MonoBehaviour CBPNGHBBIDH, Func<bool> PEAFIALKKOC, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN = FAJLDPIGHEC.OCHFIJDOJPB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class BMAPIIJHNNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly MMAHMIICAAG INGDMDMAGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly EDODCEDBKOE JFDMKPDIBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly bool IAFDBEMNHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private string BPOKAAOBIOI;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IEnumerator<EDDHBDCNFKM> DBJKCAFNFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x842A50", Offset = "0x841650", VA = "0x180842A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EDDHBDCNFKM PJCEDJDGIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7F6030", Offset = "0x7F4C30", VA = "0x1807F6030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LEFGJADGCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5437840", Offset = "0x5436440", VA = "0x185437840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CHMBLFHDPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8F62D0", Offset = "0x8F4ED0", VA = "0x1808F62D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8F62E0", Offset = "0x8F4EE0", VA = "0x1808F62E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x54372D0", Offset = "0x5435ED0", VA = "0x1854372D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float CHKEMKLOILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA1E580", Offset = "0xA1D180", VA = "0x180A1E580")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA1E770", Offset = "0xA1D370", VA = "0x180A1E770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x54379A0", Offset = "0x54365A0", VA = "0x1854379A0")]
	public BMAPIIJHNNA(IEnumerator<EDDHBDCNFKM> ACGKLCBEHNI, EDODCEDBKOE JFDMKPDIBDL, MMAHMIICAAG INGDMDMAGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5437460", Offset = "0x5436060", VA = "0x185437460")]
	public EDDHBDCNFKM BOECNPICAGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x54377D0", Offset = "0x54363D0", VA = "0x1854377D0")]
	public bool LJKAKOHNDOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5437750", Offset = "0x5436350", VA = "0x185437750")]
	public void IHLPPHPEFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x54378C0", Offset = "0x54364C0", VA = "0x1854378C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x13812B0", Offset = "0x137FEB0", VA = "0x1813812B0")]
	[CompilerGenerated]
	private void DCHKOPKHKBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class MMKCNLCAFMI
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class GPCGAMKOHDG : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public BNPMHDAAFIO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public FAJLDPIGHEC.OCHFIJDOJPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x96C5D0", Offset = "0x96B1D0", VA = "0x18096C5D0")]
		[DebuggerHidden]
		public GPCGAMKOHDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x543F780", Offset = "0x543E380", VA = "0x18543F780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x543F820", Offset = "0x543E420", VA = "0x18543F820", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5448D60", Offset = "0x5447960", VA = "0x185448D60")]
	public static CMHJCDCDCHH CMKMJFNEGHN(float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5448C50", Offset = "0x5447850", VA = "0x185448C50")]
	public static CMHJCDCDCHH CMKMJFNEGHN(MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5449020", Offset = "0x5447C20", VA = "0x185449020")]
	public static CMHJCDCDCHH MLLAKFIKBHL(MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5448E60", Offset = "0x5447A60", VA = "0x185448E60")]
	public static CMHJCDCDCHH GECBBKGFAJK(CAMANOLKPPF JFDMKPDIBDL, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5448F70", Offset = "0x5447B70", VA = "0x185448F70")]
	private static IEnumerator<EDDHBDCNFKM> LOGHFDLNPCD(JNCDEOLLBDP HKCAELOIPGM, float JCGEOAKLAPK, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5449140", Offset = "0x5447D40", VA = "0x185449140")]
	private static IEnumerator<EDDHBDCNFKM> NBCJNOOCLJC(JNCDEOLLBDP HKCAELOIPGM, float JCGEOAKLAPK, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5448BA0", Offset = "0x54477A0", VA = "0x185448BA0")]
	[IteratorStateMachine(typeof(GPCGAMKOHDG))]
	private static IEnumerator<EDDHBDCNFKM> AFCJAONEPKP(BNPMHDAAFIO JALAIHEAFCF, float JCGEOAKLAPK, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action<float> KGIKOGHKBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface ABKJDKGEDHK
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool KLEIMNBCGLC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AGKGHIPOIFJ;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GAJEEJKLEBN(bool HCKNDFMIDDI = false);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GAJEEJKLEBN(Action FOGMDOMFJBB, bool HCKNDFMIDDI = false);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class MIOIIKDLNDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static readonly MIOIIKDLNDK DGAPNEIIHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly Action BBNKBLGKOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private bool GHKACLCDPMJ;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x26EB220", Offset = "0x26E9E20", VA = "0x1826EB220")]
	public MIOIIKDLNDK(Action BBNKBLGKOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x54485C0", Offset = "0x54471C0", VA = "0x1854485C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface MKMGJNJCCOL<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable DHNHICEFBDG(UnityEngine.Object JFDMKPDIBDL, Action<T> AOGDPENLCEA);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface DDJBMPNMAOC<T> : MKMGJNJCCOL<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class OOEKDBJKCNA<T> : DDJBMPNMAOC<T>, MKMGJNJCCOL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class CKHMGGAKHBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public OOEKDBJKCNA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public DKKIFMJJILM<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public CKHMGGAKHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x29A8070", Offset = "0x29A6C70", VA = "0x1829A8070")]
		internal void CECNKMADHHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static GameObject GACONAIPLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly List<DKKIFMJJILM<UnityEngine.Object, Action<T>>> FDKOKMCLDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T GECPNMPHDOE;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1146440", Offset = "0x1145040", VA = "0x181146440", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x489B690", Offset = "0x489A290", VA = "0x18489B690", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x489BDB0", Offset = "0x489A9B0", VA = "0x18489BDB0")]
	private static bool MMNJIDLNEBN(T NBLDAOBEAEA, T PAJLLFKCBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x489BF10", Offset = "0x489AB10", VA = "0x18489BF10")]
	public OOEKDBJKCNA(T OPCIBHMHHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x489B4A0", Offset = "0x489A0A0", VA = "0x18489B4A0", Slot = "6")]
	public IDisposable DHNHICEFBDG(UnityEngine.Object JFDMKPDIBDL, Action<T> AOGDPENLCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x489B6F0", Offset = "0x489A2F0", VA = "0x18489B6F0")]
	private void LDJLBBJPNNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal interface FBOMFECIPEF
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MABPDHNBGCN(string BPOKAAOBIOI);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEFGGGJLFOG();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class MOJHPMCEAOH : FBOMFECIPEF
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "4")]
	public void MABPDHNBGCN(string BPOKAAOBIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
	public void JEFGGGJLFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public MOJHPMCEAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class MMDLICHJHOG : KCLDKBLIHJB
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class BLPMBJHPACH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public MMDLICHJHOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BLPMBJHPACH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5435B90", Offset = "0x5434790", VA = "0x185435B90")]
		internal void PPDEJMIPAMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class AIABPJIJGIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public MMDLICHJHOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public AIABPJIJGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5435B90", Offset = "0x5434790", VA = "0x185435B90")]
		internal void KCFOPBIJABC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly float ENAEKFKILBL;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5441B50", Offset = "0x5440750", VA = "0x185441B50")]
	public MMDLICHJHOG(Behaviour JFDMKPDIBDL, float ENAEKFKILBL, [Optional] Action BKAJEJMKLNN, [Optional] MIGOFOLIJGE AHHBOMNOGMN, [Optional] JNCDEOLLBDP HKCAELOIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x54489A0", Offset = "0x54475A0", VA = "0x1854489A0", Slot = "9")]
	protected override bool BNJNOGOKADI(Action FOGMDOMFJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5448AA0", Offset = "0x54476A0", VA = "0x185448AA0", Slot = "10")]
	protected override bool LGGCKOFADIL(Action FOGMDOMFJBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class GMIPMMPEJOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class OEAHAIBDHGM : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public GMIPMMPEJOD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x96C5D0", Offset = "0x96B1D0", VA = "0x18096C5D0")]
		[DebuggerHidden]
		public OEAHAIBDHGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x544C4F0", Offset = "0x544B0F0", VA = "0x18544C4F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x544C590", Offset = "0x544B190", VA = "0x18544C590", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private CMHJCDCDCHH BFOGFHHJELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private CAMANOLKPPF JFDMKPDIBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private Action<float> PGMHJLODCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private float DLKFCBPMCFM;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x543F4F0", Offset = "0x543E0F0", VA = "0x18543F4F0")]
	public GMIPMMPEJOD(CAMANOLKPPF JFDMKPDIBDL, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x543F340", Offset = "0x543DF40", VA = "0x18543F340")]
	private void KMIPOHMMBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x543EF10", Offset = "0x543DB10", VA = "0x18543EF10")]
	private void BJFNGAIIHFP(string FKPBDLDGFCC, Action FBPLMAHNFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x543F2B0", Offset = "0x543DEB0", VA = "0x18543F2B0")]
	[IteratorStateMachine(typeof(OEAHAIBDHGM))]
	private IEnumerator<EDDHBDCNFKM> IBNDJFLHAGP(Action FBPLMAHNFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x543F090", Offset = "0x543DC90", VA = "0x18543F090", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x543F0F0", Offset = "0x543DCF0", VA = "0x18543F0F0")]
	[CompilerGenerated]
	private void FAJNCABJDGO(string KIEMAGPGLGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class POCDKMEKJDH
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct PHINEGNEONL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public EIJMEBMOMDG CDPCJFBLKBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public CAMANOLKPPF DGIIIIEGDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public MMAHMIICAAG AICEHFEIDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public IEnumerator<EDDHBDCNFKM> DBJKCAFNFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public EDDHBDCNFKM PJCEDJDGIKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public ELMBAIJANLF KFEHDDEPCBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct CMFOLJIPPHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public FAJLDPIGHEC.OCHFIJDOJPB BELCOKABEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public List<PHINEGNEONL> OIACIJCCMIP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class MIEJEHNBAAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public MMAHMIICAAG promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public POCDKMEKJDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public CAMANOLKPPF context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public EIJMEBMOMDG routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public ELMBAIJANLF coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public EDDHBDCNFKM currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IEnumerator<EDDHBDCNFKM> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MIEJEHNBAAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5447DC0", Offset = "0x54469C0", VA = "0x185447DC0")]
		internal void JOFCHBKMEBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class BLBBECLJNJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public EIJMEBMOMDG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public POCDKMEKJDH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BLBBECLJNJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5437080", Offset = "0x5435C80", VA = "0x185437080")]
		internal void BLBCHAJHGFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class IAALFOKPFID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public EIJMEBMOMDG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public POCDKMEKJDH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IAALFOKPFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5441C50", Offset = "0x5440850", VA = "0x185441C50")]
		internal void MCGDIBBOLJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class PHEBGLLAEAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public EIJMEBMOMDG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public POCDKMEKJDH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public PHEBGLLAEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x544CCB0", Offset = "0x544B8B0", VA = "0x18544CCB0")]
		internal void BBEBMLAENBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private const ELMBAIJANLF CFJFAMHMFOE = ELMBAIJANLF.Cancelled | ELMBAIJANLF.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool[] DGALMKJPMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<ELMBAIJANLF> JBHNFNABNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<float> IMJAHGGCHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> EPDBKEOMNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> CFONAGLPGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> IIFLNLBOPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> ALPCPBIKGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> HBMLIFKIPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private EIJMEBMOMDG[] NNHIKBOLIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private MMAHMIICAAG[] ICMGGNEFIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private CAMANOLKPPF[] HNGPELHBPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IEnumerator<EDDHBDCNFKM>[] FCKGKKGAILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private EDDHBDCNFKM[] JEMHAEKLKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int JPKBKHDMCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int CABFJBCMJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly int MOFHMKEEEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float EKDKJMOFPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private KOPDEKEAKGO HFFBJLPLOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private JobHandle KJOHCFNHPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<EIJMEBMOMDG> HCEHBHAGKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool IMPFDDGOPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> MODEEJKCMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<Action> OBHHNDKIKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool KBEGBIDHPNN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public CMFOLJIPPHK[] ECAIHOOADMO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x135FBD0", Offset = "0x135E7D0", VA = "0x18135FBD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x544DC20", Offset = "0x544C820", VA = "0x18544DC20")]
	private static int FBDOFLANMJG(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x544FD10", Offset = "0x544E910", VA = "0x18544FD10")]
	public POCDKMEKJDH(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x544FB20", Offset = "0x544E720", VA = "0x18544FB20")]
	private void OLGMMCPBEBN(ref int EANLLOJLAIO, int CDHMDBKOOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x544DAA0", Offset = "0x544C6A0", VA = "0x18544DAA0")]
	public void ELPONEBJFIL(CAMANOLKPPF JFDMKPDIBDL, EDDHBDCNFKM AEEGDHAILFA, IEnumerator<EDDHBDCNFKM> ACGKLCBEHNI, MMAHMIICAAG INGDMDMAGEN, [Optional] EIJMEBMOMDG KCEAPOPEMCA, ELMBAIJANLF HGJCGJFAIAA = ELMBAIJANLF.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x544F320", Offset = "0x544DF20", VA = "0x18544F320")]
	public void MMNMFEDDBCK(IEnumerable<PHINEGNEONL> GLDKCLFFBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x544DD20", Offset = "0x544C920", VA = "0x18544DD20")]
	private PHINEGNEONL HMFCJIEHPNJ(int DPCADPCKAIE)
	{
		return default(PHINEGNEONL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x544F640", Offset = "0x544E240", VA = "0x18544F640")]
	private void OCBALCGKAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1F79EB0", Offset = "0x1F78AB0", VA = "0x181F79EB0")]
	private static void BLNCHDJDAOD<T>(int DPCADPCKAIE, T[] NINHBCLOIKF, int GEFPLPIBMGI, [Optional] T KCKBMNPLEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1F79E90", Offset = "0x1F78A90", VA = "0x181F79E90")]
	private static void BLNCHDJDAOD<T>(int DPCADPCKAIE, NativeArray<T> NINHBCLOIKF, int GEFPLPIBMGI, [Optional] T KCKBMNPLEND) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x544E280", Offset = "0x544CE80", VA = "0x18544E280")]
	private void IGGIJNMCEJK(IEnumerable<PHINEGNEONL> GLDKCLFFBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x544DC50", Offset = "0x544C850", VA = "0x18544DC50")]
	private void GCDEGNOJJFK(PHINEGNEONL HIKHABDCNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x544ED80", Offset = "0x544D980", VA = "0x18544ED80")]
	private GDNMAAKJBBE JDECEFHGOJP(int COPDPNGMEHL)
	{
		return default(GDNMAAKJBBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x544F040", Offset = "0x544DC40", VA = "0x18544F040")]
	public void KHEFPDNDCBO(float MLJIAJKDCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x544D9A0", Offset = "0x544C5A0", VA = "0x18544D9A0")]
	private void BDDHMKMGLBM(Action NBLDAOBEAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x544DA20", Offset = "0x544C620", VA = "0x18544DA20")]
	private void BDHODHLHFGI(Action NBLDAOBEAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x544E530", Offset = "0x544D130", VA = "0x18544E530")]
	public void IHDAFOJLHID(float MLJIAJKDCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x544F220", Offset = "0x544DE20", VA = "0x18544F220")]
	public void LIEFKNGBAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x544EC50", Offset = "0x544D850", VA = "0x18544EC50")]
	public void IHLPPHPEFDP(EIJMEBMOMDG JALAIHEAFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x544F510", Offset = "0x544E110", VA = "0x18544F510")]
	public void NEDAAMABCNE(EIJMEBMOMDG JALAIHEAFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x544F9F0", Offset = "0x544E5F0", VA = "0x18544F9F0")]
	public void OILDCGHIFPD(EIJMEBMOMDG JALAIHEAFCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class MNAAPCAPGEA : ABKJDKGEDHK, IEnumerable<ABKJDKGEDHK>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly List<ABKJDKGEDHK> GJODGKNLLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool JFHFBNHBNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Action BKAJEJMKLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool AACANJBKFEO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool KLEIMNBCGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5449370", Offset = "0x5447F70", VA = "0x185449370", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action AGKGHIPOIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5449830", Offset = "0x5448430", VA = "0x185449830", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x54491A0", Offset = "0x5447DA0", VA = "0x1854491A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5449AB0", Offset = "0x54486B0", VA = "0x185449AB0")]
	public MNAAPCAPGEA([Optional] Action BKAJEJMKLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5449240", Offset = "0x5447E40", VA = "0x185449240")]
	public void CAILCKFFJIK(ABKJDKGEDHK FAOJOGEGLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x54498D0", Offset = "0x54484D0", VA = "0x1854498D0")]
	private void PBKAHGNIKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x54494B0", Offset = "0x54480B0", VA = "0x1854494B0", Slot = "7")]
	public bool GAJEEJKLEBN(bool HCKNDFMIDDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x54494D0", Offset = "0x54480D0", VA = "0x1854494D0", Slot = "8")]
	public bool GAJEEJKLEBN(Action FOGMDOMFJBB, bool HCKNDFMIDDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x54497B0", Offset = "0x54483B0", VA = "0x1854497B0", Slot = "9")]
	public IEnumerator<ABKJDKGEDHK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5449A30", Offset = "0x5448630", VA = "0x185449A30", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class KCLDKBLIHJB : ABKJDKGEDHK
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class POMADEOGJPC : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public KCLDKBLIHJB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x96C5D0", Offset = "0x96B1D0", VA = "0x18096C5D0")]
		[DebuggerHidden]
		public POMADEOGJPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5450320", Offset = "0x544EF20", VA = "0x185450320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x54503F0", Offset = "0x544EFF0", VA = "0x1854503F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly Behaviour JFDMKPDIBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Action BKAJEJMKLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private OHBOPDKGAGN OBBGFLCMBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly MIGOFOLIJGE AHHBOMNOGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	protected readonly JNCDEOLLBDP HKCAELOIPGM;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool KLEIMNBCGLC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x873FE0", Offset = "0x872BE0", VA = "0x180873FE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AGKGHIPOIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5444680", Offset = "0x5443280", VA = "0x185444680", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x54441D0", Offset = "0x5442DD0", VA = "0x1854441D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5444720", Offset = "0x5443320", VA = "0x185444720")]
	protected KCLDKBLIHJB(Behaviour JFDMKPDIBDL, [Optional] Action BKAJEJMKLNN, [Optional] MIGOFOLIJGE AHHBOMNOGMN, [Optional] JNCDEOLLBDP HKCAELOIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5444340", Offset = "0x5442F40", VA = "0x185444340", Slot = "7")]
	public bool GAJEEJKLEBN(bool HCKNDFMIDDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x54442F0", Offset = "0x5442EF0", VA = "0x1854442F0", Slot = "8")]
	public bool GAJEEJKLEBN(Action FOGMDOMFJBB, bool HCKNDFMIDDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool BNJNOGOKADI(Action FOGMDOMFJBB);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LGGCKOFADIL(Action FOGMDOMFJBB);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5444460", Offset = "0x5443060", VA = "0x185444460")]
	protected void JOOGACAGIBI(Action FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5444480", Offset = "0x5443080", VA = "0x185444480")]
	protected EILHPPDHBHH LAEBHLEDGAN(float NCOPMNKMGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5444270", Offset = "0x5442E70", VA = "0x185444270")]
	private void FOOJFLGPHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x54443E0", Offset = "0x5442FE0", VA = "0x1854443E0")]
	[IteratorStateMachine(typeof(POMADEOGJPC))]
	private IEnumerator<EDDHBDCNFKM> IAAJPINNLNM(float NCOPMNKMGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x54443A0", Offset = "0x5442FA0", VA = "0x1854443A0")]
	[CompilerGenerated]
	private void GOJNPFKPKAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Flags]
internal enum ELMBAIJANLF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal class EIJMEBMOMDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public POCDKMEKJDH KACNFGMOBCM;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int OJOINFOLDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F33D0", Offset = "0x7F1FD0", VA = "0x1807F33D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x543DE70", Offset = "0x543CA70", VA = "0x18543DE70")]
	public static EDDHBDCNFKM BOECNPICAGA(IEnumerator<EDDHBDCNFKM> ACGKLCBEHNI, MMAHMIICAAG INGDMDMAGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x543DD90", Offset = "0x543C990", VA = "0x18543DD90")]
	public EDDHBDCNFKM BOECNPICAGA(MMAHMIICAAG[] ICMGGNEFIDI, IEnumerator<EDDHBDCNFKM>[] NAGBLHNKPPI, EDDHBDCNFKM[] ODJLMFCLOHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x543DD60", Offset = "0x543C960", VA = "0x18543DD60")]
	public void BCOICPKFPFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x543E020", Offset = "0x543CC20", VA = "0x18543E020")]
	public void KBMHHPDMDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x543E160", Offset = "0x543CD60", VA = "0x18543E160")]
	public void KMBGLODHFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x543DD60", Offset = "0x543C960", VA = "0x18543DD60")]
	public void IHLPPHPEFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public EIJMEBMOMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class IIPLFBCCFGI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class MLIAODIDIAE : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IIPLFBCCFGI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x96C5D0", Offset = "0x96B1D0", VA = "0x18096C5D0")]
		[DebuggerHidden]
		public MLIAODIDIAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x54487F0", Offset = "0x54473F0", VA = "0x1854487F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x54488D0", Offset = "0x54474D0", VA = "0x1854488D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Action CLMGFAPBIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private bool DGJLKLLEJKB;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool BCIDLILPMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x83DCF0", Offset = "0x83C8F0", VA = "0x18083DCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5441F90", Offset = "0x5440B90", VA = "0x185441F90")]
	public IIPLFBCCFGI(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5441F20", Offset = "0x5440B20", VA = "0x185441F20")]
	[IteratorStateMachine(typeof(MLIAODIDIAE))]
	private IEnumerator<EDDHBDCNFKM> PKOGBDHJAEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5441EA0", Offset = "0x5440AA0", VA = "0x185441EA0", Slot = "4")]
	public void OnCompleted(Action HDKINLLDJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public void GKEBEGBOMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class DNPINCALCNB
{
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x543CA60", Offset = "0x543B660", VA = "0x18543CA60")]
	public static IIPLFBCCFGI CIAALDMCOFJ(this FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class MKFIOJMMBDJ : HHJOLBIOKOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly MIGOFOLIJGE AHHBOMNOGMN;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x54486E0", Offset = "0x54472E0", VA = "0x1854486E0")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
	[Preserve]
	internal MKFIOJMMBDJ([ACEKLAKDMBL(null)] MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5448750", Offset = "0x5447350", VA = "0x185448750", Slot = "4")]
	public IDisposable NKLPHIBJJOP(float JCGEOAKLAPK, Action<float> IACLOIAOHJF, bool AMKCALCHEML = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal enum GDNMAAKJBBE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class NCJLMAILLHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum MFJAPECIKPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct GPHOMOGPGEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public FAJLDPIGHEC.OCHFIJDOJPB BELCOKABEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public MFJAPECIKPI BFJLDHKDALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public List<BMAPIIJHNNA> PPIBLMFNLEP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static readonly MFJAPECIKPI[] MOIPIDBFOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private bool EMMMPODCBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly BMAPIIJHNNA[] MGFMCMMFHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly List<BMAPIIJHNNA> BJNGFEHHMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly Stack<int> ELGDHBKJCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly List<BMAPIIJHNNA> BFDDDDJKKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly Stack<int> LKEJPHCLAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly FBOMFECIPEF EFBPEFJDEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private bool KBEGBIDHPNN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GPHOMOGPGEB[,] BOIEGBHAEFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8390B0", Offset = "0x837CB0", VA = "0x1808390B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x544B850", Offset = "0x544A450", VA = "0x18544B850")]
	public NCJLMAILLHH(FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, FBOMFECIPEF EFBPEFJDEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x544A690", Offset = "0x5449290", VA = "0x18544A690")]
	public void DHIPFOPICGA(BMAPIIJHNNA ACGKLCBEHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x544B0E0", Offset = "0x5449CE0", VA = "0x18544B0E0")]
	public void JELHPIIPFFL(IList<BMAPIIJHNNA> NAGBLHNKPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x544AE10", Offset = "0x5449A10", VA = "0x18544AE10")]
	public void HPIBDMBNHAI(IList<BMAPIIJHNNA> NAGBLHNKPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x544B4E0", Offset = "0x544A0E0", VA = "0x18544B4E0")]
	private void MIKILKODAEJ(BMAPIIJHNNA ACGKLCBEHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x544A510", Offset = "0x5449110", VA = "0x18544A510")]
	private void CGCFHPMFGDN(IList<BMAPIIJHNNA> NAGBLHNKPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x544B5E0", Offset = "0x544A1E0", VA = "0x18544B5E0")]
	private GDNMAAKJBBE PODHEKDCAEM(BMAPIIJHNNA ACGKLCBEHNI)
	{
		return default(GDNMAAKJBBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x544A3D0", Offset = "0x5448FD0", VA = "0x18544A3D0")]
	public void CCMEEJNHHBN(float MLJIAJKDCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x544AC00", Offset = "0x5449800", VA = "0x18544AC00")]
	public void HGEFHLKMOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x544A8F0", Offset = "0x54494F0", VA = "0x18544A8F0")]
	private void ENMMGDBJGHM(List<BMAPIIJHNNA> NAGBLHNKPPI, Stack<int> BMOLFOMHNMP, bool CNBPFBLHMGM, float MNENFANELGM = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x544A7B0", Offset = "0x54493B0", VA = "0x18544A7B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x544B3B0", Offset = "0x5449FB0", VA = "0x18544B3B0")]
	private void KPGLKHDBKIG(List<BMAPIIJHNNA> NAGBLHNKPPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class JFIGFAPFADL : EDODCEDBKOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Behaviour CBPNGHBBIDH;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5442D20", Offset = "0x5441920", VA = "0x185442D20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EBBFILBJDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5442DB0", Offset = "0x54419B0", VA = "0x185442DB0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool BDFENNMIFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5442D00", Offset = "0x5441900", VA = "0x185442D00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
	public JFIGFAPFADL(Behaviour CBPNGHBBIDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HOIPPFHPFHD : KCLDKBLIHJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly float ENAEKFKILBL;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5441B50", Offset = "0x5440750", VA = "0x185441B50")]
	public HOIPPFHPFHD(Behaviour JFDMKPDIBDL, float ENAEKFKILBL, [Optional] Action BKAJEJMKLNN, [Optional] MIGOFOLIJGE AHHBOMNOGMN, [Optional] JNCDEOLLBDP HKCAELOIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F3460", Offset = "0x7F2060", VA = "0x1807F3460", Slot = "9")]
	protected override bool BNJNOGOKADI(Action FOGMDOMFJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5441B10", Offset = "0x5440710", VA = "0x185441B10", Slot = "10")]
	protected override bool LGGCKOFADIL(Action FOGMDOMFJBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class ODGGAAOKKGP
{
	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x544C3F0", Offset = "0x544AFF0", VA = "0x18544C3F0")]
	public static IDisposable IIBGFLKBLMC(this CAMANOLKPPF JFDMKPDIBDL, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x544C470", Offset = "0x544B070", VA = "0x18544C470")]
	public static IDisposable LIILFFPPBDE(this CAMANOLKPPF JFDMKPDIBDL, Action<float> KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x544C370", Offset = "0x544AF70", VA = "0x18544C370")]
	public static IDisposable CEKNAAPJIBD(this CAMANOLKPPF JFDMKPDIBDL, Action<float> KGIKOGHKBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class PLMJJEKNEPD
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class DPEOPLPJPLB : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public FAJLDPIGHEC.OCHFIJDOJPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private BBMHDNKCCNH <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x96C5D0", Offset = "0x96B1D0", VA = "0x18096C5D0")]
		[DebuggerHidden]
		public DPEOPLPJPLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x543CB90", Offset = "0x543B790", VA = "0x18543CB90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x543CC50", Offset = "0x543B850", VA = "0x18543CC50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class HNPBNFNJIBD : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public FAJLDPIGHEC.OCHFIJDOJPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private BBMHDNKCCNH <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x96C5D0", Offset = "0x96B1D0", VA = "0x18096C5D0")]
		[DebuggerHidden]
		public HNPBNFNJIBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x54419E0", Offset = "0x54405E0", VA = "0x1854419E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5441AD0", Offset = "0x54406D0", VA = "0x185441AD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x544D140", Offset = "0x544BD40", VA = "0x18544D140")]
	public static CMHJCDCDCHH CMKMJFNEGHN(Action KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x544D1F0", Offset = "0x544BDF0", VA = "0x18544D1F0")]
	public static CMHJCDCDCHH CMKMJFNEGHN(Behaviour JFDMKPDIBDL, Action KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x544D2B0", Offset = "0x544BEB0", VA = "0x18544D2B0")]
	public static CMHJCDCDCHH CMKMJFNEGHN(Behaviour JFDMKPDIBDL, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x544D3C0", Offset = "0x544BFC0", VA = "0x18544D3C0")]
	[IteratorStateMachine(typeof(DPEOPLPJPLB))]
	private static IEnumerator<EDDHBDCNFKM> LOGHFDLNPCD(FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x544D440", Offset = "0x544C040", VA = "0x18544D440")]
	[IteratorStateMachine(typeof(HNPBNFNJIBD))]
	private static IEnumerator<EDDHBDCNFKM> LOGHFDLNPCD(FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action<float> KGIKOGHKBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class EEGFJCBKLDL
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x543D260", Offset = "0x543BE60", VA = "0x18543D260")]
	public static IDisposable CMKMJFNEGHN(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x543D1E0", Offset = "0x543BDE0", VA = "0x18543D1E0")]
	public static IDisposable CMKMJFNEGHN(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x543D050", Offset = "0x543BC50", VA = "0x18543D050")]
	public static IDisposable CCMEEJNHHBN(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x543CF50", Offset = "0x543BB50", VA = "0x18543CF50")]
	public static IDisposable AHMPHJEIING(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x543D160", Offset = "0x543BD60", VA = "0x18543D160")]
	public static IDisposable CDDOLMJNADI(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x543CFD0", Offset = "0x543BBD0", VA = "0x18543CFD0")]
	public static IDisposable AIHEDPEKEFP(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x543D780", Offset = "0x543C380", VA = "0x18543D780")]
	public static IDisposable NLGPPFHEBBL(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x543D0C0", Offset = "0x543BCC0", VA = "0x18543D0C0")]
	public static IDisposable CCMGGAKIGEB(this MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x543D800", Offset = "0x543C400", VA = "0x18543D800")]
	public static IDisposable NNLPPHAGFCG(this MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x543D6E0", Offset = "0x543C2E0", VA = "0x18543D6E0")]
	public static IDisposable NKLPHIBJJOP(this MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x543D400", Offset = "0x543C000", VA = "0x18543D400")]
	public static IDisposable GABCHMFLIPN(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x543D490", Offset = "0x543C090", VA = "0x18543D490")]
	public static IDisposable GKMNBDMAOGE(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x543D370", Offset = "0x543BF70", VA = "0x18543D370")]
	public static IDisposable FPJEAJKGECO(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x543D5C0", Offset = "0x543C1C0", VA = "0x18543D5C0")]
	public static IDisposable LPMLLICCKEH(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x543D2E0", Offset = "0x543BEE0", VA = "0x18543D2E0")]
	public static IDisposable DMKKHKOJBDL(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x543D830", Offset = "0x543C430", VA = "0x18543D830")]
	public static IDisposable PLHFNCIGLLF(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x543D650", Offset = "0x543C250", VA = "0x18543D650")]
	public static IDisposable NCJNKKEJIEB(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x543D520", Offset = "0x543C120", VA = "0x18543D520")]
	public static IDisposable KBCJIANAJHN(this MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class MMAHMIICAAG : GFKMEEOAGJI, CMHJCDCDCHH, OHBOPDKGAGN, EILHPPDHBHH, IEnumerator, EDDHBDCNFKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private FAJLDPIGHEC.OCHFIJDOJPB IJLMKPAHGEO;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private FAJLDPIGHEC.OCHFIJDOJPB JKACAALJHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2395A30", Offset = "0x2394630", VA = "0x182395A30", Slot = "23")]
		get
		{
			return default(FAJLDPIGHEC.OCHFIJDOJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public FAJLDPIGHEC.OCHFIJDOJPB KACNFGMOBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x87E1F0", Offset = "0x87CDF0", VA = "0x18087E1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private float NNDJOPJJCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xC0B210", Offset = "0xC09E10", VA = "0x180C0B210", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool GJEDFCMFDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CA0", Offset = "0x7F48A0", VA = "0x1807F5CA0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5448920", Offset = "0x5447520", VA = "0x185448920", Slot = "24")]
	private bool ECBPNKDPJDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5448910", Offset = "0x5447510", VA = "0x185448910", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5448940", Offset = "0x5447540", VA = "0x185448940")]
	public MMAHMIICAAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal interface EDODCEDBKOE
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool EBBFILBJDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool BDFENNMIFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class KKMIOEIJEJF
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class INEKPAONJEM : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public FAJLDPIGHEC.OCHFIJDOJPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x96C5D0", Offset = "0x96B1D0", VA = "0x18096C5D0")]
		[DebuggerHidden]
		public INEKPAONJEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x5442600", Offset = "0x5441200", VA = "0x185442600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x54426C0", Offset = "0x54412C0", VA = "0x1854426C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class FNMFPLBGOPK : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public FAJLDPIGHEC.OCHFIJDOJPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private EDDHBDCNFKM <wait>5__1;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x96C5D0", Offset = "0x96B1D0", VA = "0x18096C5D0")]
		[DebuggerHidden]
		public FNMFPLBGOPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x543EA40", Offset = "0x543D640", VA = "0x18543EA40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x543EB10", Offset = "0x543D710", VA = "0x18543EB10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5446140", Offset = "0x5444D40", VA = "0x185446140")]
	[IteratorStateMachine(typeof(INEKPAONJEM))]
	private static IEnumerator<EDDHBDCNFKM> PKOGBDHJAEG(float JJEEOOEDFIC, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5445980", Offset = "0x5444580", VA = "0x185445980")]
	[IteratorStateMachine(typeof(FNMFPLBGOPK))]
	private static IEnumerator<EDDHBDCNFKM> CJBIBAPPMPH(float JJEEOOEDFIC, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5445CF0", Offset = "0x54448F0", VA = "0x185445CF0")]
	public static IDisposable MADFBPINOBF(this MonoBehaviour CBPNGHBBIDH, float JJEEOOEDFIC, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5445C00", Offset = "0x5444800", VA = "0x185445C00")]
	public static CMHJCDCDCHH KOBMNJKNNJO(this MonoBehaviour CBPNGHBBIDH, float JJEEOOEDFIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5445E10", Offset = "0x5444A10", VA = "0x185445E10")]
	public static CMHJCDCDCHH MADFBPINOBF(this MonoBehaviour CBPNGHBBIDH, float JJEEOOEDFIC, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5445BE0", Offset = "0x54447E0", VA = "0x185445BE0")]
	public static CMHJCDCDCHH KNDCNODHFPK(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5446110", Offset = "0x5444D10", VA = "0x185446110")]
	public static CMHJCDCDCHH OAHHIGBGNDH(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x54458A0", Offset = "0x54444A0", VA = "0x1854458A0")]
	public static CMHJCDCDCHH CDAEBIODGKC(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5446010", Offset = "0x5444C10", VA = "0x185446010")]
	public static CMHJCDCDCHH NBEDIKFOOBB(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5445CC0", Offset = "0x54448C0", VA = "0x185445CC0")]
	public static CMHJCDCDCHH LONPFELMGBC(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5445A10", Offset = "0x5444610", VA = "0x185445A10")]
	public static CMHJCDCDCHH GCJHDJBDFDP(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5445F40", Offset = "0x5444B40", VA = "0x185445F40")]
	private static CMHJCDCDCHH MEKMLNEGBMK(MonoBehaviour CBPNGHBBIDH, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, Action ELKBEDCOHFJ, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5445B10", Offset = "0x5444710", VA = "0x185445B10")]
	public static CMHJCDCDCHH JKMNKBLGFCK(this MonoBehaviour CBPNGHBBIDH, float FHCKNGCEODO, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5445A40", Offset = "0x5444640", VA = "0x185445A40")]
	public static CMHJCDCDCHH JDHHJNEFMOP(this MonoBehaviour CBPNGHBBIDH, float FHCKNGCEODO, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5446040", Offset = "0x5444C40", VA = "0x185446040")]
	public static CMHJCDCDCHH NKFNKKHIIOA(this MonoBehaviour CBPNGHBBIDH, float FHCKNGCEODO, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x54457D0", Offset = "0x54443D0", VA = "0x1854457D0")]
	public static CMHJCDCDCHH ANDMDKAJNHE(this MonoBehaviour CBPNGHBBIDH, float FHCKNGCEODO, Action ELKBEDCOHFJ)
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

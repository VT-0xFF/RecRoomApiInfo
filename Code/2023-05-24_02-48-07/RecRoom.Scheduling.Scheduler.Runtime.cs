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
	[Cpp2IlInjected.Address(RVA = "0x55B8480", Offset = "0x55B7080", VA = "0x1855B8480")]
	public NFEMKDMIHPG(ThreadPriority JHKIBDAHBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x55B8470", Offset = "0x55B7070", VA = "0x1855B8470", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x55AE3E0", Offset = "0x55ACFE0", VA = "0x1855AE3E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x55AB450", Offset = "0x55AA050", VA = "0x1855AB450")]
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
				[Cpp2IlInjected.Address(RVA = "0x55B91F0", Offset = "0x55B7DF0", VA = "0x1855B91F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x55B95D0", Offset = "0x55B81D0", VA = "0x1855B95D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x55B84C0", Offset = "0x55B70C0", VA = "0x1855B84C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x55A93F0", Offset = "0x55A7FF0", VA = "0x1855A93F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x55B8FE0", Offset = "0x55B7BE0", VA = "0x1855B8FE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x55B86D0", Offset = "0x55B72D0", VA = "0x1855B86D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x55B4300", Offset = "0x55B2F00", VA = "0x1855B4300")]
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
				[Cpp2IlInjected.Address(RVA = "0x55AAA00", Offset = "0x55A9600", VA = "0x1855AAA00")]
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
				[Cpp2IlInjected.Address(RVA = "0x55A3820", Offset = "0x55A2420", VA = "0x1855A3820")]
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
					[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
					public CHHGPDOIOLE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x55A4260", Offset = "0x55A2E60", VA = "0x1855A4260")]
					internal void PBPHJGEBDNH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static global::NAOGJOJMPFD<ICMMDNMKDLK> CKEENCHNAJJ;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x55B88E0", Offset = "0x55B74E0", VA = "0x1855B88E0")]
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
					[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
					public DLNAHODIBEL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x55A8F50", Offset = "0x55A7B50", VA = "0x1855A8F50")]
					internal void EBCNFKMDGLC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000035")]
				public static IDisposable MEJBAFBLFAK;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x55B06E0", Offset = "0x55AF2E0", VA = "0x1855B06E0")]
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
					[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
					public FAOGAOFECFB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x55AADF0", Offset = "0x55A99F0", VA = "0x1855AADF0")]
					internal void EBCNFKMDGLC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x55AEE80", Offset = "0x55ADA80", VA = "0x1855AEE80")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public FGEECPLIIHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x55AB080", Offset = "0x55A9C80", VA = "0x1855AB080")]
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
			[Cpp2IlInjected.Address(RVA = "0x55A7380", Offset = "0x55A5F80", VA = "0x1855A7380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x55A86D0", Offset = "0x55A72D0", VA = "0x1855A86D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x55A4AD0", Offset = "0x55A36D0", VA = "0x1855A4AD0")]
		private static void AIDMHJNNILC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x55A79E0", Offset = "0x55A65E0", VA = "0x1855A79E0")]
		private static void KNIAFOACMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x55A73C0", Offset = "0x55A5FC0", VA = "0x1855A73C0")]
		private static void DJJJMECMMOH(string GBCIBIFAJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x55A7150", Offset = "0x55A5D50", VA = "0x1855A7150")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x55A76F0", Offset = "0x55A62F0", VA = "0x1855A76F0")]
		private static void HKDHEJOEJMG(ILGLNBGPBBN.AJAFGBBLMDL BDFCACLHAFA, ref PlayerLoopSystem JJJNLMNGKIP, Type EEBPJPAJJMI, Type LMHJCBIOFAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x55A82B0", Offset = "0x55A6EB0", VA = "0x1855A82B0")]
		private static void MNLEDNHKHAJ(ref PlayerLoopSystem JJJNLMNGKIP, Type EEBPJPAJJMI, Type LMHJCBIOFAJ, HGEKJFGCFGL GMKMBAGOCJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x55A78B0", Offset = "0x55A64B0", VA = "0x1855A78B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x55B1240", Offset = "0x55AFE40", VA = "0x1855B1240")]
		public KGCDJDDEHPF(AJAFGBBLMDL CHDMLABPAFA, int LGIEKLJJONB = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x55B0FD0", Offset = "0x55AFBD0", VA = "0x1855B0FD0")]
		public void OEHNABKAGHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x55B0F70", Offset = "0x55AFB70", VA = "0x1855B0F70")]
		public void NKDGDBAMEGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x55B1040", Offset = "0x55AFC40", VA = "0x1855B1040")]
		public void PPJKFJAINJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static AJAFGBBLMDL[] IEAPDCAIAIC;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static KGCDJDDEHPF[] OICJKMMAOFD;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x55AE960", Offset = "0x55AD560", VA = "0x1855AE960")]
	public static KGCDJDDEHPF EEOKGOKGCKI(AJAFGBBLMDL BDFCACLHAFA, int LGIEKLJJONB = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x55AE8D0", Offset = "0x55AD4D0", VA = "0x1855AE8D0")]
	public static KGCDJDDEHPF CGMKPHLNMGA(AJAFGBBLMDL BDFCACLHAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x55AEB40", Offset = "0x55AD740", VA = "0x1855AEB40")]
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
			[Cpp2IlInjected.Address(RVA = "0x424B9C0", Offset = "0x424A5C0", VA = "0x18424B9C0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JMBNEAPFBDN
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x424BA20", Offset = "0x424A620", VA = "0x18424BA20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x29B2B60", Offset = "0x29B1760", VA = "0x1829B2B60")]
		protected LKKKKLGIBCL(TPromise NNEKKHKOFNA, TMainThreadPromise MBJEECHAGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x424BA70", Offset = "0x424A670", VA = "0x18424BA70", Slot = "5")]
		public void KOGMCNBOFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void LECFIMLDKKH(TPromise NNEKKHKOFNA);
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class NKHIPOIKNEE<T> : LKKKKLGIBCL<global::NBFPPJGKGOH<T>, global::GBNOCCBNCBC<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3900EA0", Offset = "0x38FFAA0", VA = "0x183900EA0")]
		public NKHIPOIKNEE(global::NBFPPJGKGOH<T> NNEKKHKOFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3900CB0", Offset = "0x38FF8B0", VA = "0x183900CB0", Slot = "6")]
		protected override void LECFIMLDKKH(global::NBFPPJGKGOH<T> NNEKKHKOFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3900E70", Offset = "0x38FFA70", VA = "0x183900E70")]
		[CompilerGenerated]
		private void LLKFMHKOPPI(T IIMBBHEIGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x14B9B70", Offset = "0x14B8770", VA = "0x1814B9B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2D00", Offset = "0x7F1900", VA = "0x1807F2D00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x836EE0", Offset = "0x835AE0", VA = "0x180836EE0")]
		public DGAJMLPBMBN(Action FOGMDOMFJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1821C80", Offset = "0x1820880", VA = "0x181821C80", Slot = "5")]
		public void KOGMCNBOFCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<HMNPAGLFLOM> FBOHEDCPAMF;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B710", Offset = "0x2E5A310", VA = "0x182E5B710")]
	public static global::NBFPPJGKGOH<T> ICJNHIKMAKJ<T>(this global::NBFPPJGKGOH<T> NNEKKHKOFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x55A43F0", Offset = "0x55A2FF0", VA = "0x1855A43F0")]
	public static void ICJNHIKMAKJ(Action FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B780", Offset = "0x2E5A380", VA = "0x182E5B780")]
	private static global::NBFPPJGKGOH<T> LLPDBGLFLHI<T>(global::NBFPPJGKGOH<T> NNEKKHKOFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x55A4480", Offset = "0x55A3080", VA = "0x1855A4480")]
	private static void MJFCPJAKNBB(HMNPAGLFLOM FJIPEECKEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x55A4680", Offset = "0x55A3280", VA = "0x1855A4680")]
	private static void NOKMFOKCMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x55A42F0", Offset = "0x55A2EF0", VA = "0x1855A42F0")]
	private static void FPNCEHMMCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x55A4980", Offset = "0x55A3580", VA = "0x1855A4980")]
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
		public readonly AALOEEPNEOP LEBCJIHOHHE;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x55B42A0", Offset = "0x55B2EA0", VA = "0x1855B42A0")]
		public LBJANCAFBGL(TaskCompletionSource<Scene> BFLDPIIJLEC, string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON, bool DJJMALJEJII, AALOEEPNEOP LEBCJIHOHHE)
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
		public AALOEEPNEOP stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private global::JAPPGKMKBNF<string> <toDispose>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public AIHJCFJLPON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x55A2320", Offset = "0x55A0F20", VA = "0x1855A2320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HCFIBNDNMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x55AC2A0", Offset = "0x55AAEA0", VA = "0x1855AC2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public AODDGPDCLCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x55A2A50", Offset = "0x55A1650", VA = "0x1855A2A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		public global::GBNOCCBNCBC<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CGOABEKACFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x55A4200", Offset = "0x55A2E00", VA = "0x1855A4200")]
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
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private AALOEEPNEOP <loadSceneTimer>5__1;

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
		private AALOEEPNEOP <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Scene <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BIEKGPFMICL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x55A2E20", Offset = "0x55A1A20", VA = "0x1855A2E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public PNGONIHGEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x55B9C10", Offset = "0x55B8810", VA = "0x1855B9C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Scene <emptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private AALOEEPNEOP <emptySceneRoutineTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private AALOEEPNEOP <emptySceneTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private AALOEEPNEOP <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private AALOEEPNEOP <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NCDNPPBANJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x55B62A0", Offset = "0x55B4EA0", VA = "0x1855B62A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JBNBAOEMGCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x55AEE50", Offset = "0x55ADA50", VA = "0x1855AEE50")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public EGPMEELCOOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x55AA430", Offset = "0x55A9030", VA = "0x1855AA430", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x55AA070", Offset = "0x55A8C70", VA = "0x1855AA070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x55AA020", Offset = "0x55A8C20", VA = "0x1855AA020")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x55AA3F0", Offset = "0x55A8FF0", VA = "0x1855AA3F0", Slot = "8")]
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
		public global::GBNOCCBNCBC<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HAIEMPEJPNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x55AC220", Offset = "0x55AAE20", VA = "0x1855AC220")]
		internal bool OPGMNJDFPKH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x55ABFB0", Offset = "0x55AABB0", VA = "0x1855ABFB0")]
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
		public global::GBNOCCBNCBC<Scene> onCompletePromise;

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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public DDLHKFGCKLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x55A8710", Offset = "0x55A7310", VA = "0x1855A8710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x55A8F10", Offset = "0x55A7B10", VA = "0x1855A8F10", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x55ADB80", Offset = "0x55AC780", VA = "0x1855ADB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool KOHLOAGPOKL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x55ACE00", Offset = "0x55ABA00", VA = "0x1855ACE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private static bool MCNDKCCKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x55AD5F0", Offset = "0x55AC1F0", VA = "0x1855AD5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static bool DFKHFGLGHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x55ACFC0", Offset = "0x55ABBC0", VA = "0x1855ACFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> DCHHILCILAD
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x55ACEC0", Offset = "0x55ABAC0", VA = "0x1855ACEC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x55AC840", Offset = "0x55AB440", VA = "0x1855AC840")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x55AD9C0", Offset = "0x55AC5C0", VA = "0x1855AD9C0")]
	[AGOCEKPENPF(ANODGEDDMCH.EnteredEditModeNextFrame, 0)]
	private static void MOACIJIIPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x55ADE00", Offset = "0x55ACA00", VA = "0x1855ADE00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AIHJCFJLPON))]
	public static Task<Scene> PNEPKELPBPK(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON = LoadSceneMode.Single, bool DJJMALJEJII = false, [Optional] AALOEEPNEOP BKBDOJIIGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x55AD4F0", Offset = "0x55AC0F0", VA = "0x1855AD4F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HCFIBNDNMJI))]
	private static Task JKFGDLCDIML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x55AC740", Offset = "0x55AB340", VA = "0x1855AC740")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AODDGPDCLCP))]
	private static Task EFIIFDOEBHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x55AD6B0", Offset = "0x55AC2B0", VA = "0x1855AD6B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BIEKGPFMICL))]
	private static Task<Scene> MCDIDPMNHDD(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON, bool DJJMALJEJII, AALOEEPNEOP LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x55ADA90", Offset = "0x55AC690", VA = "0x1855ADA90")]
	private static void NCADNLHCHOB(SceneInstance PKIKEDNMDGD, LoadSceneMode GGEPKHEIMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x55AD070", Offset = "0x55ABC70", VA = "0x1855AD070")]
	private static void IPPFNLLBICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x55AD860", Offset = "0x55AC460", VA = "0x1855AD860")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PNGONIHGEKG))]
	private static Task<Scene> MKNCFGMCDGI(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x55AC650", Offset = "0x55AB250", VA = "0x1855AC650")]
	private static bool CHELJKHIFGH(string KPMIPNBJALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x55AD110", Offset = "0x55ABD10", VA = "0x1855AD110")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NCDNPPBANJO))]
	private static Task<Scene> JAGJNBNMDNL(AALOEEPNEOP LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x55AD260", Offset = "0x55ABE60", VA = "0x1855AD260")]
	public static global::NBFPPJGKGOH<Scene> JAKPCMBCPGG(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x55AC940", Offset = "0x55AB540", VA = "0x1855AC940")]
	public static EILHPPDHBHH FDCPICCCPGC(string KPMIPNBJALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x55ACC10", Offset = "0x55AB810", VA = "0x1855ACC10")]
	[IteratorStateMachine(typeof(EGPMEELCOOB))]
	private static IEnumerator<EDDHBDCNFKM> FLANFLDHAJJ(string KPMIPNBJALP, GIELIJKIODJ NGEHEMCMAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x55AD450", Offset = "0x55AC050", VA = "0x1855AD450")]
	[IteratorStateMachine(typeof(DDLHKFGCKLC))]
	private static IEnumerator<EDDHBDCNFKM> JFPMKCCCMHB(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON, global::GBNOCCBNCBC<Scene> NGEHEMCMAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x55ACCA0", Offset = "0x55AB8A0", VA = "0x1855ACCA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x55B8D20", Offset = "0x55B7920", VA = "0x1855B8D20", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double DDJGPMKEACG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1140", Offset = "0x1DCFD40", VA = "0x181DD1140", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double GIBLADJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4485360", Offset = "0x4483F60", VA = "0x184485360", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x55B8F30", Offset = "0x55B7B30", VA = "0x1855B8F30")]
	public OGCKCENOJFH(int JJAMFICFNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x55B8D90", Offset = "0x55B7990", VA = "0x1855B8D90", Slot = "7")]
	public void NAAMMCMMHJJ(double FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x55B8EC0", Offset = "0x55B7AC0", VA = "0x1855B8EC0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x954D50", Offset = "0x953950", VA = "0x180954D50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double DDJGPMKEACG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x55AB2D0", Offset = "0x55A9ED0", VA = "0x1855AB2D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double GIBLADJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x10FD0D0", Offset = "0x10FBCD0", VA = "0x1810FD0D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double MMGBDCHIPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x55AB2B0", Offset = "0x55A9EB0", VA = "0x1855AB2B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double JNDLJOLGNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x55AB2C0", Offset = "0x55A9EC0", VA = "0x1855AB2C0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x55AB2E0", Offset = "0x55A9EE0", VA = "0x1855AB2E0", Slot = "7")]
	public virtual void NAAMMCMMHJJ(double FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x55AB410", Offset = "0x55AA010", VA = "0x1855AB410", Slot = "8")]
	public virtual void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x55AADB0", Offset = "0x55A99B0", VA = "0x1855AADB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x55AAC10", Offset = "0x55A9810", VA = "0x1855AAC10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x55AAC20", Offset = "0x55A9820", VA = "0x1855AAC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x55AAC30", Offset = "0x55A9830", VA = "0x1855AAC30", Slot = "7")]
	public override void NAAMMCMMHJJ(double FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x55AAD70", Offset = "0x55A9970", VA = "0x1855AAD70", Slot = "8")]
	public override void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55AADB0", Offset = "0x55A99B0", VA = "0x1855AADB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x55ABEC0", Offset = "0x55AAAC0", VA = "0x1855ABEC0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public float DPLBEPDJHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x55ABE20", Offset = "0x55AAA20", VA = "0x1855ABE20", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public double LGNCOMMFFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x55ABE30", Offset = "0x55AAA30", VA = "0x1855ABE30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x55ABE50", Offset = "0x55AAA50", VA = "0x1855ABE50")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public KAPGDHCKMCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x55B0840", Offset = "0x55AF440", VA = "0x1855B0840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x55B08E0", Offset = "0x55AF4E0", VA = "0x1855B08E0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x55B36D0", Offset = "0x55B22D0", VA = "0x1855B36D0")]
	public KMBMENJLJIN(MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x55B3B20", Offset = "0x55B2720", VA = "0x1855B3B20")]
	public KMBMENJLJIN(MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x55B38D0", Offset = "0x55B24D0", VA = "0x1855B38D0")]
	public KMBMENJLJIN(MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4231F30", Offset = "0x4230B30", VA = "0x184231F30")]
	private KMBMENJLJIN(MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x55B30B0", Offset = "0x55B1CB0", VA = "0x1855B30B0")]
	internal static KMBMENJLJIN JIOGLFAEKIA(MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x55B2AF0", Offset = "0x55B16F0", VA = "0x1855B2AF0")]
	private void CMKMJFNEGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x55B2DE0", Offset = "0x55B19E0", VA = "0x1855B2DE0")]
	private void FKBGDGHABFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x55B3350", Offset = "0x55B1F50", VA = "0x1855B3350")]
	private void KMIPOHMMBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x55B3500", Offset = "0x55B2100", VA = "0x1855B3500")]
	private void MOMJBFKPPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x55B2920", Offset = "0x55B1520", VA = "0x1855B2920")]
	private void BJFNGAIIHFP(string FKPBDLDGFCC, Action FBPLMAHNFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x55B3020", Offset = "0x55B1C20", VA = "0x1855B3020")]
	[IteratorStateMachine(typeof(KAPGDHCKMCE))]
	private IEnumerator<EDDHBDCNFKM> IBNDJFLHAGP(Action FBPLMAHNFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x55B2D80", Offset = "0x55B1980", VA = "0x1855B2D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x55B2F90", Offset = "0x55B1B90", VA = "0x1855B2F90")]
	[CompilerGenerated]
	private void GECEGDDOCFF(string KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x55B2C60", Offset = "0x55B1860", VA = "0x1855B2C60")]
	[CompilerGenerated]
	private void DCBKGKHNJOH(string KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x55B2A60", Offset = "0x55B1660", VA = "0x1855B2A60")]
	[CompilerGenerated]
	private void CKCPBJEKDAD(string KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x55B2CF0", Offset = "0x55B18F0", VA = "0x1855B2CF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x55B4130", Offset = "0x55B2D30", VA = "0x1855B4130")]
	public static KOPDEKEAKGO JLAKJAPJOGA(int OGLAFAPFBOH, float MLJIAJKDCFE, NativeArray<ELMBAIJANLF> AHPBELANDJJ, NativeArray<float> NEFMLNAKONK, NativeArray<int> KALAPHPLMMI, NativeArray<int> IGKGNEIMHMJ, NativeArray<int> HMIKNJPCGFN, NativeArray<int> IEJMMBFIOFJ, NativeArray<int> HOMJNINMJNP)
	{
		return default(KOPDEKEAKGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x55B3F50", Offset = "0x55B2B50", VA = "0x1855B3F50", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x55B4260", Offset = "0x55B2E60", VA = "0x1855B4260")]
	private bool NGAKJBEGOMM(int NHHNPPKPBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x55B4030", Offset = "0x55B2C30", VA = "0x1855B4030")]
	private void FOOBNDDLECA(NativeArray<int> JKEPHCKPPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x55B4200", Offset = "0x55B2E00", VA = "0x1855B4200")]
	private int NFNBDECIPNO(int MDEEEEEKCNL, int HJGNBNDIBBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x55B4060", Offset = "0x55B2C60", VA = "0x1855B4060")]
	private void IKOMAADDNEP(NativeArray<int> JKEPHCKPPCN, int EMIHEDBEOEE, int EFBLLBPFDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x55B3D60", Offset = "0x55B2960", VA = "0x1855B3D60")]
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
	[Cpp2IlInjected.Address(RVA = "0x55AF2A0", Offset = "0x55ADEA0", VA = "0x1855AF2A0")]
	public JENHBJAJBGG(Behaviour JFDMKPDIBDL, float BOLPILLKBJN, int OAAPKFDMBIO, [Optional] Action BKAJEJMKLNN, float MDNLGAALJEO = 0f, [Optional] MIGOFOLIJGE AHHBOMNOGMN, [Optional] JNCDEOLLBDP HKCAELOIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F0460", Offset = "0x7EF060", VA = "0x1807F0460", Slot = "9")]
	protected override bool BNJNOGOKADI(Action FOGMDOMFJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x55AF070", Offset = "0x55ADC70", VA = "0x1855AF070", Slot = "10")]
	protected override bool LGGCKOFADIL(Action FOGMDOMFJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x55AEFE0", Offset = "0x55ADBE0", VA = "0x1855AEFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x55AFE40", Offset = "0x55AEA40", VA = "0x1855AFE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool GLGGKOPKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D00", Offset = "0x7F1900", VA = "0x1807F2D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public FAJLDPIGHEC.OCHFIJDOJPB ALFKLMICPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F0000", Offset = "0x7EEC00", VA = "0x1807F0000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FAJLDPIGHEC.OCHFIJDOJPB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7F03D0", Offset = "0x7EEFD0", VA = "0x1807F03D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public JNCDEOLLBDP KCGIIBMNCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x55B02A0", Offset = "0x55AEEA0", VA = "0x1855B02A0")]
	public static CMHJCDCDCHH PIDCALFGNFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x55B0330", Offset = "0x55AEF30", VA = "0x1855B0330")]
	[Preserve]
	protected JHGFKAJELKB([ACEKLAKDMBL(null)] EDGHCOGIIEI OEDOFDBDLNG, [ACEKLAKDMBL(null)] JNCDEOLLBDP HKCAELOIPGM, [ACEKLAKDMBL(null)] DKJCBBDIGHA BHMNGDKDIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x55AF940", Offset = "0x55AE540", VA = "0x1855AF940", Slot = "6")]
	public CMHJCDCDCHH EBDHDHCPNAJ(IEnumerator<EDDHBDCNFKM> HFKDOGILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x55AF950", Offset = "0x55AE550", VA = "0x1855AF950", Slot = "7")]
	public CMHJCDCDCHH EBDHDHCPNAJ(Behaviour JFDMKPDIBDL, IEnumerator<EDDHBDCNFKM> HFKDOGILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract CMHJCDCDCHH HHKGFKCLLJC(CAMANOLKPPF JFDMKPDIBDL, IEnumerator<EDDHBDCNFKM> HFKDOGILHAO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x55B00A0", Offset = "0x55AECA0", VA = "0x1855B00A0", Slot = "13")]
	public virtual void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x55AFDE0", Offset = "0x55AE9E0", VA = "0x1855AFDE0", Slot = "9")]
	public void HGEFHLKMOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x24042F0", Offset = "0x2402EF0", VA = "0x1824042F0", Slot = "14")]
	protected virtual void CCMEEJNHHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x55AFE90", Offset = "0x55AEA90", VA = "0x1855AFE90")]
	private void KPMGDJFMKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x55B0280", Offset = "0x55AEE80", VA = "0x1855B0280")]
	private void OCJGBDGIEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x55AF580", Offset = "0x55AE180", VA = "0x1855AF580")]
	private void AHMPHJEIING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x55AF5A0", Offset = "0x55AE1A0", VA = "0x1855AF5A0")]
	private void CDDOLMJNADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x55AFEB0", Offset = "0x55AEAB0", VA = "0x1855AFEB0")]
	private void MDKKIKDHKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x55AF560", Offset = "0x55AE160", VA = "0x1855AF560")]
	private void AALBICKFCLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x55AFB80", Offset = "0x55AE780", VA = "0x1855AFB80")]
	private void EKIHKPHFBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x55AFBA0", Offset = "0x55AE7A0", VA = "0x1855AFBA0", Slot = "15")]
	public virtual void GPFLMOACIOG(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x55AFED0", Offset = "0x55AEAD0", VA = "0x1855AFED0")]
	private void MEFPPNKONHF(NCJLMAILLHH CBNOLLAEAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xEA8FD0", Offset = "0xEA7BD0", VA = "0x180EA8FD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x55AF5C0", Offset = "0x55AE1C0", VA = "0x1855AF5C0", Slot = "18")]
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
	[Cpp2IlInjected.Address(RVA = "0x55B19A0", Offset = "0x55B05A0", VA = "0x1855B19A0")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x55B1E50", Offset = "0x55B0A50", VA = "0x1855B1E50")]
	[Preserve]
	public KGJJBLKGEBP([ACEKLAKDMBL(null)] EDGHCOGIIEI OEDOFDBDLNG, [ACEKLAKDMBL(null)] JNCDEOLLBDP HKCAELOIPGM, [ACEKLAKDMBL(null)] DKJCBBDIGHA BHMNGDKDIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x55B1850", Offset = "0x55B0450", VA = "0x1855B1850", Slot = "12")]
	public override CMHJCDCDCHH HHKGFKCLLJC(CAMANOLKPPF JFDMKPDIBDL, IEnumerator<EDDHBDCNFKM> HFKDOGILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x55B1B70", Offset = "0x55B0770", VA = "0x1855B1B70", Slot = "13")]
	public override void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x55B1670", Offset = "0x55B0270", VA = "0x1855B1670", Slot = "15")]
	public override void GPFLMOACIOG(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x55B1340", Offset = "0x55AFF40", VA = "0x1855B1340", Slot = "14")]
	protected override void CCMEEJNHHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x55B1500", Offset = "0x55B0100", VA = "0x1855B1500")]
	private POCDKMEKJDH FNCFBPFOKGA(FAJLDPIGHEC.OCHFIJDOJPB FIJCKHKKDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x55B1A10", Offset = "0x55B0610", VA = "0x1855B1A10", Slot = "16")]
	internal override BMAPIIJHNNA LPFFKDNEANB(IEnumerator<EDDHBDCNFKM> HFKDOGILHAO, Behaviour JFDMKPDIBDL, MMAHMIICAAG INGDMDMAGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x55B1490", Offset = "0x55B0090", VA = "0x1855B1490", Slot = "17")]
	internal override NCJLMAILLHH FJGKFECNKBE(FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x55B1540", Offset = "0x55B0140", VA = "0x1855B1540")]
	private void GMFKCNKNLNM(POCDKMEKJDH CBNOLLAEAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x55B1420", Offset = "0x55B0020", VA = "0x1855B1420", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public IKPHCFIOIFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x55AE7E0", Offset = "0x55AD3E0", VA = "0x1855AE7E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x55AE890", Offset = "0x55AD490", VA = "0x1855AE890", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x55B9440", Offset = "0x55B8040", VA = "0x1855B9440")]
	[IteratorStateMachine(typeof(IKPHCFIOIFM))]
	private static IEnumerator<EDDHBDCNFKM> LCPPGAMHGKJ(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, Func<bool> PEAFIALKKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x55B94C0", Offset = "0x55B80C0", VA = "0x1855B94C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x857190", Offset = "0x855D90", VA = "0x180857190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EDDHBDCNFKM PJCEDJDGIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7F3030", Offset = "0x7F1C30", VA = "0x1807F3030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LEFGJADGCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x55A3FA0", Offset = "0x55A2BA0", VA = "0x1855A3FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CHMBLFHDPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x921DD0", Offset = "0x9209D0", VA = "0x180921DD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x921DE0", Offset = "0x9209E0", VA = "0x180921DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x55A3A30", Offset = "0x55A2630", VA = "0x1855A3A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float CHKEMKLOILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA6B110", Offset = "0xA69D10", VA = "0x180A6B110")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA6B300", Offset = "0xA69F00", VA = "0x180A6B300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x55A4100", Offset = "0x55A2D00", VA = "0x1855A4100")]
	public BMAPIIJHNNA(IEnumerator<EDDHBDCNFKM> ACGKLCBEHNI, EDODCEDBKOE JFDMKPDIBDL, MMAHMIICAAG INGDMDMAGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x55A3BC0", Offset = "0x55A27C0", VA = "0x1855A3BC0")]
	public EDDHBDCNFKM BOECNPICAGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x55A3F30", Offset = "0x55A2B30", VA = "0x1855A3F30")]
	public bool LJKAKOHNDOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x55A3EB0", Offset = "0x55A2AB0", VA = "0x1855A3EB0")]
	public void IHLPPHPEFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x55A4020", Offset = "0x55A2C20", VA = "0x1855A4020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x15FFCF0", Offset = "0x15FE8F0", VA = "0x1815FFCF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public GPCGAMKOHDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x55ABED0", Offset = "0x55AAAD0", VA = "0x1855ABED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x55ABF70", Offset = "0x55AAB70", VA = "0x1855ABF70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x55B54B0", Offset = "0x55B40B0", VA = "0x1855B54B0")]
	public static CMHJCDCDCHH CMKMJFNEGHN(float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x55B53A0", Offset = "0x55B3FA0", VA = "0x1855B53A0")]
	public static CMHJCDCDCHH CMKMJFNEGHN(MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x55B5770", Offset = "0x55B4370", VA = "0x1855B5770")]
	public static CMHJCDCDCHH MLLAKFIKBHL(MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x55B55B0", Offset = "0x55B41B0", VA = "0x1855B55B0")]
	public static CMHJCDCDCHH GECBBKGFAJK(CAMANOLKPPF JFDMKPDIBDL, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x55B56C0", Offset = "0x55B42C0", VA = "0x1855B56C0")]
	private static IEnumerator<EDDHBDCNFKM> LOGHFDLNPCD(JNCDEOLLBDP HKCAELOIPGM, float JCGEOAKLAPK, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x55B5890", Offset = "0x55B4490", VA = "0x1855B5890")]
	private static IEnumerator<EDDHBDCNFKM> NBCJNOOCLJC(JNCDEOLLBDP HKCAELOIPGM, float JCGEOAKLAPK, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x55B52F0", Offset = "0x55B3EF0", VA = "0x1855B52F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x21E4B90", Offset = "0x21E3790", VA = "0x1821E4B90")]
	public MIOIIKDLNDK(Action BBNKBLGKOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x55B4D10", Offset = "0x55B3910", VA = "0x1855B4D10", Slot = "4")]
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
public interface DDJBMPNMAOC<T> : global::MKMGJNJCCOL<T>
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
public class OOEKDBJKCNA<T> : global::DDJBMPNMAOC<T>, global::MKMGJNJCCOL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class JENFAEIGLGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public global::OOEKDBJKCNA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public global::DKKIFMJJILM<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public JENFAEIGLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x30CEEA0", Offset = "0x30CDAA0", VA = "0x1830CEEA0")]
		internal void CECNKMADHHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static GameObject GACONAIPLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly List<global::DKKIFMJJILM<UnityEngine.Object, Action<T>>> FDKOKMCLDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T GECPNMPHDOE;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xC1B140", Offset = "0xC19D40", VA = "0x180C1B140", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x31C9540", Offset = "0x31C8140", VA = "0x1831C9540", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x31C9C60", Offset = "0x31C8860", VA = "0x1831C9C60")]
	private static bool MMNJIDLNEBN(T NBLDAOBEAEA, T PAJLLFKCBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x31C9D20", Offset = "0x31C8920", VA = "0x1831C9D20")]
	public OOEKDBJKCNA(T OPCIBHMHHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x31C9350", Offset = "0x31C7F50", VA = "0x1831C9350", Slot = "6")]
	public IDisposable DHNHICEFBDG(UnityEngine.Object JFDMKPDIBDL, Action<T> AOGDPENLCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x31C9900", Offset = "0x31C8500", VA = "0x1831C9900")]
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
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "4")]
	public void MABPDHNBGCN(string BPOKAAOBIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
	public void JEFGGGJLFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BLPMBJHPACH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x55A22F0", Offset = "0x55A0EF0", VA = "0x1855A22F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public AIABPJIJGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x55A22F0", Offset = "0x55A0EF0", VA = "0x1855A22F0")]
		internal void KCFOPBIJABC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly float ENAEKFKILBL;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x55AE2A0", Offset = "0x55ACEA0", VA = "0x1855AE2A0")]
	public MMDLICHJHOG(Behaviour JFDMKPDIBDL, float ENAEKFKILBL, [Optional] Action BKAJEJMKLNN, [Optional] MIGOFOLIJGE AHHBOMNOGMN, [Optional] JNCDEOLLBDP HKCAELOIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x55B50F0", Offset = "0x55B3CF0", VA = "0x1855B50F0", Slot = "9")]
	protected override bool BNJNOGOKADI(Action FOGMDOMFJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x55B51F0", Offset = "0x55B3DF0", VA = "0x1855B51F0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public OEAHAIBDHGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x55B8C40", Offset = "0x55B7840", VA = "0x1855B8C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x55B8CE0", Offset = "0x55B78E0", VA = "0x1855B8CE0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x55ABC40", Offset = "0x55AA840", VA = "0x1855ABC40")]
	public GMIPMMPEJOD(CAMANOLKPPF JFDMKPDIBDL, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x55ABA90", Offset = "0x55AA690", VA = "0x1855ABA90")]
	private void KMIPOHMMBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x55AB660", Offset = "0x55AA260", VA = "0x1855AB660")]
	private void BJFNGAIIHFP(string FKPBDLDGFCC, Action FBPLMAHNFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x55ABA00", Offset = "0x55AA600", VA = "0x1855ABA00")]
	[IteratorStateMachine(typeof(OEAHAIBDHGM))]
	private IEnumerator<EDDHBDCNFKM> IBNDJFLHAGP(Action FBPLMAHNFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x55AB7E0", Offset = "0x55AA3E0", VA = "0x1855AB7E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x55AB840", Offset = "0x55AA440", VA = "0x1855AB840")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MIEJEHNBAAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x55B4510", Offset = "0x55B3110", VA = "0x1855B4510")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BLBBECLJNJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x55A37E0", Offset = "0x55A23E0", VA = "0x1855A37E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IAALFOKPFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x55AE3A0", Offset = "0x55ACFA0", VA = "0x1855AE3A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public PHEBGLLAEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x55B9400", Offset = "0x55B8000", VA = "0x1855B9400")]
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
		[Cpp2IlInjected.Address(RVA = "0x1AC7750", Offset = "0x1AC6350", VA = "0x181AC7750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x55BA370", Offset = "0x55B8F70", VA = "0x1855BA370")]
	private static int FBDOFLANMJG(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x55BC460", Offset = "0x55BB060", VA = "0x1855BC460")]
	public POCDKMEKJDH(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x55BC270", Offset = "0x55BAE70", VA = "0x1855BC270")]
	private void OLGMMCPBEBN(ref int EANLLOJLAIO, int CDHMDBKOOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x55BA1F0", Offset = "0x55B8DF0", VA = "0x1855BA1F0")]
	public void ELPONEBJFIL(CAMANOLKPPF JFDMKPDIBDL, EDDHBDCNFKM AEEGDHAILFA, IEnumerator<EDDHBDCNFKM> ACGKLCBEHNI, MMAHMIICAAG INGDMDMAGEN, [Optional] EIJMEBMOMDG KCEAPOPEMCA, ELMBAIJANLF HGJCGJFAIAA = ELMBAIJANLF.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x55BBA70", Offset = "0x55BA670", VA = "0x1855BBA70")]
	public void MMNMFEDDBCK(IEnumerable<PHINEGNEONL> GLDKCLFFBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x55BA470", Offset = "0x55B9070", VA = "0x1855BA470")]
	private PHINEGNEONL HMFCJIEHPNJ(int DPCADPCKAIE)
	{
		return default(PHINEGNEONL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x55BBD90", Offset = "0x55BA990", VA = "0x1855BBD90")]
	private void OCBALCGKAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x210DEC0", Offset = "0x210CAC0", VA = "0x18210DEC0")]
	private static void BLNCHDJDAOD<T>(int DPCADPCKAIE, T[] NINHBCLOIKF, int GEFPLPIBMGI, [Optional] T KCKBMNPLEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x210DEA0", Offset = "0x210CAA0", VA = "0x18210DEA0")]
	private static void BLNCHDJDAOD<T>(int DPCADPCKAIE, NativeArray<T> NINHBCLOIKF, int GEFPLPIBMGI, [Optional] T KCKBMNPLEND) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x55BA9D0", Offset = "0x55B95D0", VA = "0x1855BA9D0")]
	private void IGGIJNMCEJK(IEnumerable<PHINEGNEONL> GLDKCLFFBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x55BA3A0", Offset = "0x55B8FA0", VA = "0x1855BA3A0")]
	private void GCDEGNOJJFK(PHINEGNEONL HIKHABDCNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x55BB4D0", Offset = "0x55BA0D0", VA = "0x1855BB4D0")]
	private GDNMAAKJBBE JDECEFHGOJP(int COPDPNGMEHL)
	{
		return default(GDNMAAKJBBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x55BB790", Offset = "0x55BA390", VA = "0x1855BB790")]
	public void KHEFPDNDCBO(float MLJIAJKDCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x55BA0F0", Offset = "0x55B8CF0", VA = "0x1855BA0F0")]
	private void BDDHMKMGLBM(Action NBLDAOBEAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x55BA170", Offset = "0x55B8D70", VA = "0x1855BA170")]
	private void BDHODHLHFGI(Action NBLDAOBEAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x55BAC80", Offset = "0x55B9880", VA = "0x1855BAC80")]
	public void IHDAFOJLHID(float MLJIAJKDCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x55BB970", Offset = "0x55BA570", VA = "0x1855BB970")]
	public void LIEFKNGBAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x55BB3A0", Offset = "0x55B9FA0", VA = "0x1855BB3A0")]
	public void IHLPPHPEFDP(EIJMEBMOMDG JALAIHEAFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x55BBC60", Offset = "0x55BA860", VA = "0x1855BBC60")]
	public void NEDAAMABCNE(EIJMEBMOMDG JALAIHEAFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x55BC140", Offset = "0x55BAD40", VA = "0x1855BC140")]
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
		[Cpp2IlInjected.Address(RVA = "0x55B5AC0", Offset = "0x55B46C0", VA = "0x1855B5AC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action AGKGHIPOIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x55B5F80", Offset = "0x55B4B80", VA = "0x1855B5F80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x55B58F0", Offset = "0x55B44F0", VA = "0x1855B58F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x55B6200", Offset = "0x55B4E00", VA = "0x1855B6200")]
	public MNAAPCAPGEA([Optional] Action BKAJEJMKLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x55B5990", Offset = "0x55B4590", VA = "0x1855B5990")]
	public void CAILCKFFJIK(ABKJDKGEDHK FAOJOGEGLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x55B6020", Offset = "0x55B4C20", VA = "0x1855B6020")]
	private void PBKAHGNIKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x55B5C00", Offset = "0x55B4800", VA = "0x1855B5C00", Slot = "7")]
	public bool GAJEEJKLEBN(bool HCKNDFMIDDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x55B5C20", Offset = "0x55B4820", VA = "0x1855B5C20", Slot = "8")]
	public bool GAJEEJKLEBN(Action FOGMDOMFJBB, bool HCKNDFMIDDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x55B5F00", Offset = "0x55B4B00", VA = "0x1855B5F00", Slot = "9")]
	public IEnumerator<ABKJDKGEDHK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x55B6180", Offset = "0x55B4D80", VA = "0x1855B6180", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public POMADEOGJPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x55BCA70", Offset = "0x55BB670", VA = "0x1855BCA70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x55BCB40", Offset = "0x55BB740", VA = "0x1855BCB40", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x888620", Offset = "0x887220", VA = "0x180888620", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AGKGHIPOIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x55B0DD0", Offset = "0x55AF9D0", VA = "0x1855B0DD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x55B0920", Offset = "0x55AF520", VA = "0x1855B0920", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x55B0E70", Offset = "0x55AFA70", VA = "0x1855B0E70")]
	protected KCLDKBLIHJB(Behaviour JFDMKPDIBDL, [Optional] Action BKAJEJMKLNN, [Optional] MIGOFOLIJGE AHHBOMNOGMN, [Optional] JNCDEOLLBDP HKCAELOIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x55B0A90", Offset = "0x55AF690", VA = "0x1855B0A90", Slot = "7")]
	public bool GAJEEJKLEBN(bool HCKNDFMIDDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x55B0A40", Offset = "0x55AF640", VA = "0x1855B0A40", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x55B0BB0", Offset = "0x55AF7B0", VA = "0x1855B0BB0")]
	protected void JOOGACAGIBI(Action FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x55B0BD0", Offset = "0x55AF7D0", VA = "0x1855B0BD0")]
	protected EILHPPDHBHH LAEBHLEDGAN(float NCOPMNKMGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x55B09C0", Offset = "0x55AF5C0", VA = "0x1855B09C0")]
	private void FOOJFLGPHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x55B0B30", Offset = "0x55AF730", VA = "0x1855B0B30")]
	[IteratorStateMachine(typeof(POMADEOGJPC))]
	private IEnumerator<EDDHBDCNFKM> IAAJPINNLNM(float NCOPMNKMGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x55B0AF0", Offset = "0x55AF6F0", VA = "0x1855B0AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F0000", Offset = "0x7EEC00", VA = "0x1807F0000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F03D0", Offset = "0x7EEFD0", VA = "0x1807F03D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x55AA5D0", Offset = "0x55A91D0", VA = "0x1855AA5D0")]
	public static EDDHBDCNFKM BOECNPICAGA(IEnumerator<EDDHBDCNFKM> ACGKLCBEHNI, MMAHMIICAAG INGDMDMAGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x55AA4F0", Offset = "0x55A90F0", VA = "0x1855AA4F0")]
	public EDDHBDCNFKM BOECNPICAGA(MMAHMIICAAG[] ICMGGNEFIDI, IEnumerator<EDDHBDCNFKM>[] NAGBLHNKPPI, EDDHBDCNFKM[] ODJLMFCLOHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x55AA4C0", Offset = "0x55A90C0", VA = "0x1855AA4C0")]
	public void BCOICPKFPFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x55AA780", Offset = "0x55A9380", VA = "0x1855AA780")]
	public void KBMHHPDMDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x55AA8C0", Offset = "0x55A94C0", VA = "0x1855AA8C0")]
	public void KMBGLODHFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x55AA4C0", Offset = "0x55A90C0", VA = "0x1855AA4C0")]
	public void IHLPPHPEFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public MLIAODIDIAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x55B4F40", Offset = "0x55B3B40", VA = "0x1855B4F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x55B5020", Offset = "0x55B3C20", VA = "0x1855B5020", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x852430", Offset = "0x851030", VA = "0x180852430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x55AE6E0", Offset = "0x55AD2E0", VA = "0x1855AE6E0")]
	public IIPLFBCCFGI(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x55AE670", Offset = "0x55AD270", VA = "0x1855AE670")]
	[IteratorStateMachine(typeof(MLIAODIDIAE))]
	private IEnumerator<EDDHBDCNFKM> PKOGBDHJAEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x55AE5F0", Offset = "0x55AD1F0", VA = "0x1855AE5F0", Slot = "4")]
	public void OnCompleted(Action HDKINLLDJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public void GKEBEGBOMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class DNPINCALCNB
{
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x55A91C0", Offset = "0x55A7DC0", VA = "0x1855A91C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x55B4E30", Offset = "0x55B3A30", VA = "0x1855B4E30")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x836EE0", Offset = "0x835AE0", VA = "0x180836EE0")]
	[Preserve]
	internal MKFIOJMMBDJ([ACEKLAKDMBL(null)] MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x55B4EA0", Offset = "0x55B3AA0", VA = "0x1855B4EA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x836090", Offset = "0x834C90", VA = "0x180836090")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x55B7FA0", Offset = "0x55B6BA0", VA = "0x1855B7FA0")]
	public NCJLMAILLHH(FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, FBOMFECIPEF EFBPEFJDEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x55B6DE0", Offset = "0x55B59E0", VA = "0x1855B6DE0")]
	public void DHIPFOPICGA(BMAPIIJHNNA ACGKLCBEHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x55B7830", Offset = "0x55B6430", VA = "0x1855B7830")]
	public void JELHPIIPFFL(IList<BMAPIIJHNNA> NAGBLHNKPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x55B7560", Offset = "0x55B6160", VA = "0x1855B7560")]
	public void HPIBDMBNHAI(IList<BMAPIIJHNNA> NAGBLHNKPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x55B7C30", Offset = "0x55B6830", VA = "0x1855B7C30")]
	private void MIKILKODAEJ(BMAPIIJHNNA ACGKLCBEHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x55B6C60", Offset = "0x55B5860", VA = "0x1855B6C60")]
	private void CGCFHPMFGDN(IList<BMAPIIJHNNA> NAGBLHNKPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x55B7D30", Offset = "0x55B6930", VA = "0x1855B7D30")]
	private GDNMAAKJBBE PODHEKDCAEM(BMAPIIJHNNA ACGKLCBEHNI)
	{
		return default(GDNMAAKJBBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x55B6B20", Offset = "0x55B5720", VA = "0x1855B6B20")]
	public void CCMEEJNHHBN(float MLJIAJKDCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x55B7350", Offset = "0x55B5F50", VA = "0x1855B7350")]
	public void HGEFHLKMOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x55B7040", Offset = "0x55B5C40", VA = "0x1855B7040")]
	private void ENMMGDBJGHM(List<BMAPIIJHNNA> NAGBLHNKPPI, Stack<int> BMOLFOMHNMP, bool CNBPFBLHMGM, float MNENFANELGM = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x55B6F00", Offset = "0x55B5B00", VA = "0x1855B6F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x55B7B00", Offset = "0x55B6700", VA = "0x1855B7B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x55AF470", Offset = "0x55AE070", VA = "0x1855AF470", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EBBFILBJDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x55AF500", Offset = "0x55AE100", VA = "0x1855AF500", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool BDFENNMIFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x55AF450", Offset = "0x55AE050", VA = "0x1855AF450", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x836EE0", Offset = "0x835AE0", VA = "0x180836EE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x55AE2A0", Offset = "0x55ACEA0", VA = "0x1855AE2A0")]
	public HOIPPFHPFHD(Behaviour JFDMKPDIBDL, float ENAEKFKILBL, [Optional] Action BKAJEJMKLNN, [Optional] MIGOFOLIJGE AHHBOMNOGMN, [Optional] JNCDEOLLBDP HKCAELOIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F0460", Offset = "0x7EF060", VA = "0x1807F0460", Slot = "9")]
	protected override bool BNJNOGOKADI(Action FOGMDOMFJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x55AE260", Offset = "0x55ACE60", VA = "0x1855AE260", Slot = "10")]
	protected override bool LGGCKOFADIL(Action FOGMDOMFJBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class ODGGAAOKKGP
{
	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x55B8B40", Offset = "0x55B7740", VA = "0x1855B8B40")]
	public static IDisposable IIBGFLKBLMC(this CAMANOLKPPF JFDMKPDIBDL, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x55B8BC0", Offset = "0x55B77C0", VA = "0x1855B8BC0")]
	public static IDisposable LIILFFPPBDE(this CAMANOLKPPF JFDMKPDIBDL, Action<float> KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x55B8AC0", Offset = "0x55B76C0", VA = "0x1855B8AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public DPEOPLPJPLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x55A92F0", Offset = "0x55A7EF0", VA = "0x1855A92F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x55A93B0", Offset = "0x55A7FB0", VA = "0x1855A93B0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public HNPBNFNJIBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x55AE130", Offset = "0x55ACD30", VA = "0x1855AE130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x55AE220", Offset = "0x55ACE20", VA = "0x1855AE220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x55B9890", Offset = "0x55B8490", VA = "0x1855B9890")]
	public static CMHJCDCDCHH CMKMJFNEGHN(Action KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x55B9940", Offset = "0x55B8540", VA = "0x1855B9940")]
	public static CMHJCDCDCHH CMKMJFNEGHN(Behaviour JFDMKPDIBDL, Action KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x55B9A00", Offset = "0x55B8600", VA = "0x1855B9A00")]
	public static CMHJCDCDCHH CMKMJFNEGHN(Behaviour JFDMKPDIBDL, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x55B9B10", Offset = "0x55B8710", VA = "0x1855B9B10")]
	[IteratorStateMachine(typeof(DPEOPLPJPLB))]
	private static IEnumerator<EDDHBDCNFKM> LOGHFDLNPCD(FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x55B9B90", Offset = "0x55B8790", VA = "0x1855B9B90")]
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
	[Cpp2IlInjected.Address(RVA = "0x55A99C0", Offset = "0x55A85C0", VA = "0x1855A99C0")]
	public static IDisposable CMKMJFNEGHN(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x55A9940", Offset = "0x55A8540", VA = "0x1855A9940")]
	public static IDisposable CMKMJFNEGHN(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x55A97B0", Offset = "0x55A83B0", VA = "0x1855A97B0")]
	public static IDisposable CCMEEJNHHBN(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x55A96B0", Offset = "0x55A82B0", VA = "0x1855A96B0")]
	public static IDisposable AHMPHJEIING(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x55A98C0", Offset = "0x55A84C0", VA = "0x1855A98C0")]
	public static IDisposable CDDOLMJNADI(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x55A9730", Offset = "0x55A8330", VA = "0x1855A9730")]
	public static IDisposable AIHEDPEKEFP(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x55A9EE0", Offset = "0x55A8AE0", VA = "0x1855A9EE0")]
	public static IDisposable NLGPPFHEBBL(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x55A9820", Offset = "0x55A8420", VA = "0x1855A9820")]
	public static IDisposable CCMGGAKIGEB(this MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x55A9F60", Offset = "0x55A8B60", VA = "0x1855A9F60")]
	public static IDisposable NNLPPHAGFCG(this MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x55A9E40", Offset = "0x55A8A40", VA = "0x1855A9E40")]
	public static IDisposable NKLPHIBJJOP(this MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x55A9B60", Offset = "0x55A8760", VA = "0x1855A9B60")]
	public static IDisposable GABCHMFLIPN(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x55A9BF0", Offset = "0x55A87F0", VA = "0x1855A9BF0")]
	public static IDisposable GKMNBDMAOGE(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x55A9AD0", Offset = "0x55A86D0", VA = "0x1855A9AD0")]
	public static IDisposable FPJEAJKGECO(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x55A9D20", Offset = "0x55A8920", VA = "0x1855A9D20")]
	public static IDisposable LPMLLICCKEH(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x55A9A40", Offset = "0x55A8640", VA = "0x1855A9A40")]
	public static IDisposable DMKKHKOJBDL(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x55A9F90", Offset = "0x55A8B90", VA = "0x1855A9F90")]
	public static IDisposable PLHFNCIGLLF(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x55A9DB0", Offset = "0x55A89B0", VA = "0x1855A9DB0")]
	public static IDisposable NCJNKKEJIEB(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x55A9C80", Offset = "0x55A8880", VA = "0x1855A9C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FC720", Offset = "0x10FB320", VA = "0x1810FC720", Slot = "23")]
		get
		{
			return default(FAJLDPIGHEC.OCHFIJDOJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public FAJLDPIGHEC.OCHFIJDOJPB KACNFGMOBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x892820", Offset = "0x891420", VA = "0x180892820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private float NNDJOPJJCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xC95DA0", Offset = "0xC949A0", VA = "0x180C95DA0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool GJEDFCMFDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x55B5070", Offset = "0x55B3C70", VA = "0x1855B5070", Slot = "24")]
	private bool ECBPNKDPJDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x55B5060", Offset = "0x55B3C60", VA = "0x1855B5060", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x55B5090", Offset = "0x55B3C90", VA = "0x1855B5090")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public INEKPAONJEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x55AED50", Offset = "0x55AD950", VA = "0x1855AED50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x55AEE10", Offset = "0x55ADA10", VA = "0x1855AEE10", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public FNMFPLBGOPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x55AB1A0", Offset = "0x55A9DA0", VA = "0x1855AB1A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x55AB270", Offset = "0x55A9E70", VA = "0x1855AB270", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x55B2890", Offset = "0x55B1490", VA = "0x1855B2890")]
	[IteratorStateMachine(typeof(INEKPAONJEM))]
	private static IEnumerator<EDDHBDCNFKM> PKOGBDHJAEG(float JJEEOOEDFIC, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x55B20D0", Offset = "0x55B0CD0", VA = "0x1855B20D0")]
	[IteratorStateMachine(typeof(FNMFPLBGOPK))]
	private static IEnumerator<EDDHBDCNFKM> CJBIBAPPMPH(float JJEEOOEDFIC, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x55B2440", Offset = "0x55B1040", VA = "0x1855B2440")]
	public static IDisposable MADFBPINOBF(this MonoBehaviour CBPNGHBBIDH, float JJEEOOEDFIC, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x55B2350", Offset = "0x55B0F50", VA = "0x1855B2350")]
	public static CMHJCDCDCHH KOBMNJKNNJO(this MonoBehaviour CBPNGHBBIDH, float JJEEOOEDFIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x55B2560", Offset = "0x55B1160", VA = "0x1855B2560")]
	public static CMHJCDCDCHH MADFBPINOBF(this MonoBehaviour CBPNGHBBIDH, float JJEEOOEDFIC, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x55B2330", Offset = "0x55B0F30", VA = "0x1855B2330")]
	public static CMHJCDCDCHH KNDCNODHFPK(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x55B2860", Offset = "0x55B1460", VA = "0x1855B2860")]
	public static CMHJCDCDCHH OAHHIGBGNDH(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x55B1FF0", Offset = "0x55B0BF0", VA = "0x1855B1FF0")]
	public static CMHJCDCDCHH CDAEBIODGKC(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x55B2760", Offset = "0x55B1360", VA = "0x1855B2760")]
	public static CMHJCDCDCHH NBEDIKFOOBB(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x55B2410", Offset = "0x55B1010", VA = "0x1855B2410")]
	public static CMHJCDCDCHH LONPFELMGBC(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x55B2160", Offset = "0x55B0D60", VA = "0x1855B2160")]
	public static CMHJCDCDCHH GCJHDJBDFDP(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x55B2690", Offset = "0x55B1290", VA = "0x1855B2690")]
	private static CMHJCDCDCHH MEKMLNEGBMK(MonoBehaviour CBPNGHBBIDH, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, Action ELKBEDCOHFJ, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x55B2260", Offset = "0x55B0E60", VA = "0x1855B2260")]
	public static CMHJCDCDCHH JKMNKBLGFCK(this MonoBehaviour CBPNGHBBIDH, float FHCKNGCEODO, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x55B2190", Offset = "0x55B0D90", VA = "0x1855B2190")]
	public static CMHJCDCDCHH JDHHJNEFMOP(this MonoBehaviour CBPNGHBBIDH, float FHCKNGCEODO, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x55B2790", Offset = "0x55B1390", VA = "0x1855B2790")]
	public static CMHJCDCDCHH NKFNKKHIIOA(this MonoBehaviour CBPNGHBBIDH, float FHCKNGCEODO, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x55B1F20", Offset = "0x55B0B20", VA = "0x1855B1F20")]
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

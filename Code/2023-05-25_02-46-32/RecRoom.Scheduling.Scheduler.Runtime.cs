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
	[Cpp2IlInjected.Address(RVA = "0x57A19E0", Offset = "0x57A01E0", VA = "0x1857A19E0")]
	public NFEMKDMIHPG(ThreadPriority JHKIBDAHBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x57A19D0", Offset = "0x57A01D0", VA = "0x1857A19D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5797940", Offset = "0x5796140", VA = "0x185797940")]
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
				[Cpp2IlInjected.Address(RVA = "0x57949B0", Offset = "0x57931B0", VA = "0x1857949B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x57A2750", Offset = "0x57A0F50", VA = "0x1857A2750")]
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
				[Cpp2IlInjected.Address(RVA = "0x57A2B30", Offset = "0x57A1330", VA = "0x1857A2B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x57A1A20", Offset = "0x57A0220", VA = "0x1857A1A20")]
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
				[Cpp2IlInjected.Address(RVA = "0x5792970", Offset = "0x5791170", VA = "0x185792970")]
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
				[Cpp2IlInjected.Address(RVA = "0x57A2540", Offset = "0x57A0D40", VA = "0x1857A2540")]
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
				[Cpp2IlInjected.Address(RVA = "0x57A1C30", Offset = "0x57A0430", VA = "0x1857A1C30")]
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
				[Cpp2IlInjected.Address(RVA = "0x579D860", Offset = "0x579C060", VA = "0x18579D860")]
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
				[Cpp2IlInjected.Address(RVA = "0x5793F80", Offset = "0x5792780", VA = "0x185793F80")]
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
				[Cpp2IlInjected.Address(RVA = "0x578CDA0", Offset = "0x578B5A0", VA = "0x18578CDA0")]
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
					[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
					public CHHGPDOIOLE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x578D7E0", Offset = "0x578BFE0", VA = "0x18578D7E0")]
					internal void PBPHJGEBDNH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static global::NAOGJOJMPFD<ICMMDNMKDLK> CKEENCHNAJJ;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x57A1E40", Offset = "0x57A0640", VA = "0x1857A1E40")]
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
					[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
					public DLNAHODIBEL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x57924D0", Offset = "0x5790CD0", VA = "0x1857924D0")]
					internal void EBCNFKMDGLC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000035")]
				public static IDisposable MEJBAFBLFAK;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x5799C40", Offset = "0x5798440", VA = "0x185799C40")]
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
					[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
					public FAOGAOFECFB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x5794350", Offset = "0x5792B50", VA = "0x185794350")]
					internal void EBCNFKMDGLC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x57983E0", Offset = "0x5796BE0", VA = "0x1857983E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public FGEECPLIIHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x57945E0", Offset = "0x5792DE0", VA = "0x1857945E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5790900", Offset = "0x578F100", VA = "0x185790900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5791C50", Offset = "0x5790450", VA = "0x185791C50")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x578E050", Offset = "0x578C850", VA = "0x18578E050")]
		private static void AIDMHJNNILC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5790F60", Offset = "0x578F760", VA = "0x185790F60")]
		private static void KNIAFOACMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5790940", Offset = "0x578F140", VA = "0x185790940")]
		private static void DJJJMECMMOH(string GBCIBIFAJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x57906D0", Offset = "0x578EED0", VA = "0x1857906D0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5790C70", Offset = "0x578F470", VA = "0x185790C70")]
		private static void HKDHEJOEJMG(ILGLNBGPBBN.AJAFGBBLMDL BDFCACLHAFA, ref PlayerLoopSystem JJJNLMNGKIP, Type EEBPJPAJJMI, Type LMHJCBIOFAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5791830", Offset = "0x5790030", VA = "0x185791830")]
		private static void MNLEDNHKHAJ(ref PlayerLoopSystem JJJNLMNGKIP, Type EEBPJPAJJMI, Type LMHJCBIOFAJ, HGEKJFGCFGL GMKMBAGOCJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5790E30", Offset = "0x578F630", VA = "0x185790E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x579A7A0", Offset = "0x5798FA0", VA = "0x18579A7A0")]
		public KGCDJDDEHPF(AJAFGBBLMDL CHDMLABPAFA, int LGIEKLJJONB = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x579A530", Offset = "0x5798D30", VA = "0x18579A530")]
		public void OEHNABKAGHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x579A4D0", Offset = "0x5798CD0", VA = "0x18579A4D0")]
		public void NKDGDBAMEGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x579A5A0", Offset = "0x5798DA0", VA = "0x18579A5A0")]
		public void PPJKFJAINJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static AJAFGBBLMDL[] IEAPDCAIAIC;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static KGCDJDDEHPF[] OICJKMMAOFD;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5797EC0", Offset = "0x57966C0", VA = "0x185797EC0")]
	public static KGCDJDDEHPF EEOKGOKGCKI(AJAFGBBLMDL BDFCACLHAFA, int LGIEKLJJONB = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5797E30", Offset = "0x5796630", VA = "0x185797E30")]
	public static KGCDJDDEHPF CGMKPHLNMGA(AJAFGBBLMDL BDFCACLHAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x57980A0", Offset = "0x57968A0", VA = "0x1857980A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x49C91B0", Offset = "0x49C79B0", VA = "0x1849C91B0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JMBNEAPFBDN
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x49C9210", Offset = "0x49C7A10", VA = "0x1849C9210", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2C70130", Offset = "0x2C6E930", VA = "0x182C70130")]
		protected LKKKKLGIBCL(TPromise NNEKKHKOFNA, TMainThreadPromise MBJEECHAGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x49C9260", Offset = "0x49C7A60", VA = "0x1849C9260", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x39DF220", Offset = "0x39DDA20", VA = "0x1839DF220")]
		public NKHIPOIKNEE(global::NBFPPJGKGOH<T> NNEKKHKOFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x39DF030", Offset = "0x39DD830", VA = "0x1839DF030", Slot = "6")]
		protected override void LECFIMLDKKH(global::NBFPPJGKGOH<T> NNEKKHKOFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x39DF1F0", Offset = "0x39DD9F0", VA = "0x1839DF1F0")]
		[CompilerGenerated]
		private void LLKFMHKOPPI(T IIMBBHEIGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1862910", Offset = "0x1861110", VA = "0x181862910")]
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
			[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD20", Offset = "0x8AB520", VA = "0x1808ACD20")]
		public DGAJMLPBMBN(Action FOGMDOMFJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1AFE1F0", Offset = "0x1AFC9F0", VA = "0x181AFE1F0", Slot = "5")]
		public void KOGMCNBOFCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<HMNPAGLFLOM> FBOHEDCPAMF;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x315AA60", Offset = "0x3159260", VA = "0x18315AA60")]
	public static global::NBFPPJGKGOH<T> ICJNHIKMAKJ<T>(this global::NBFPPJGKGOH<T> NNEKKHKOFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x578D970", Offset = "0x578C170", VA = "0x18578D970")]
	public static void ICJNHIKMAKJ(Action FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x315AAD0", Offset = "0x31592D0", VA = "0x18315AAD0")]
	private static global::NBFPPJGKGOH<T> LLPDBGLFLHI<T>(global::NBFPPJGKGOH<T> NNEKKHKOFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x578DA00", Offset = "0x578C200", VA = "0x18578DA00")]
	private static void MJFCPJAKNBB(HMNPAGLFLOM FJIPEECKEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x578DC00", Offset = "0x578C400", VA = "0x18578DC00")]
	private static void NOKMFOKCMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x578D870", Offset = "0x578C070", VA = "0x18578D870")]
	private static void FPNCEHMMCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x578DF00", Offset = "0x578C700", VA = "0x18578DF00")]
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
		[Cpp2IlInjected.Address(RVA = "0x579D800", Offset = "0x579C000", VA = "0x18579D800")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AIHJCFJLPON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x578B8A0", Offset = "0x578A0A0", VA = "0x18578B8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HCFIBNDNMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5795800", Offset = "0x5794000", VA = "0x185795800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AODDGPDCLCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x578BFD0", Offset = "0x578A7D0", VA = "0x18578BFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CGOABEKACFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x578D780", Offset = "0x578BF80", VA = "0x18578D780")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BIEKGPFMICL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x578C3A0", Offset = "0x578ABA0", VA = "0x18578C3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public PNGONIHGEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x57A3170", Offset = "0x57A1970", VA = "0x1857A3170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NCDNPPBANJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x579F800", Offset = "0x579E000", VA = "0x18579F800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JBNBAOEMGCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x57983B0", Offset = "0x5796BB0", VA = "0x1857983B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public EGPMEELCOOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x57939B0", Offset = "0x57921B0", VA = "0x1857939B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x57935F0", Offset = "0x5791DF0", VA = "0x1857935F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x57935A0", Offset = "0x5791DA0", VA = "0x1857935A0")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5793970", Offset = "0x5792170", VA = "0x185793970", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HAIEMPEJPNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5795780", Offset = "0x5793F80", VA = "0x185795780")]
		internal bool OPGMNJDFPKH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5795510", Offset = "0x5793D10", VA = "0x185795510")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public DDLHKFGCKLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5791C90", Offset = "0x5790490", VA = "0x185791C90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5792490", Offset = "0x5790C90", VA = "0x185792490", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x57970E0", Offset = "0x57958E0", VA = "0x1857970E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool KOHLOAGPOKL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5796360", Offset = "0x5794B60", VA = "0x185796360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private static bool MCNDKCCKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5796B50", Offset = "0x5795350", VA = "0x185796B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static bool DFKHFGLGHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5796520", Offset = "0x5794D20", VA = "0x185796520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> DCHHILCILAD
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5796420", Offset = "0x5794C20", VA = "0x185796420")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5795DA0", Offset = "0x57945A0", VA = "0x185795DA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5796F20", Offset = "0x5795720", VA = "0x185796F20")]
	[AGOCEKPENPF(ANODGEDDMCH.EnteredEditModeNextFrame, 0)]
	private static void MOACIJIIPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5797360", Offset = "0x5795B60", VA = "0x185797360")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AIHJCFJLPON))]
	public static Task<Scene> PNEPKELPBPK(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON = LoadSceneMode.Single, bool DJJMALJEJII = false, [Optional] AALOEEPNEOP BKBDOJIIGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5796A50", Offset = "0x5795250", VA = "0x185796A50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HCFIBNDNMJI))]
	private static Task JKFGDLCDIML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5795CA0", Offset = "0x57944A0", VA = "0x185795CA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AODDGPDCLCP))]
	private static Task EFIIFDOEBHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5796C10", Offset = "0x5795410", VA = "0x185796C10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BIEKGPFMICL))]
	private static Task<Scene> MCDIDPMNHDD(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON, bool DJJMALJEJII, AALOEEPNEOP LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5796FF0", Offset = "0x57957F0", VA = "0x185796FF0")]
	private static void NCADNLHCHOB(SceneInstance PKIKEDNMDGD, LoadSceneMode GGEPKHEIMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x57965D0", Offset = "0x5794DD0", VA = "0x1857965D0")]
	private static void IPPFNLLBICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5796DC0", Offset = "0x57955C0", VA = "0x185796DC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PNGONIHGEKG))]
	private static Task<Scene> MKNCFGMCDGI(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5795BB0", Offset = "0x57943B0", VA = "0x185795BB0")]
	private static bool CHELJKHIFGH(string KPMIPNBJALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5796670", Offset = "0x5794E70", VA = "0x185796670")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NCDNPPBANJO))]
	private static Task<Scene> JAGJNBNMDNL(AALOEEPNEOP LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x57967C0", Offset = "0x5794FC0", VA = "0x1857967C0")]
	public static global::NBFPPJGKGOH<Scene> JAKPCMBCPGG(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5795EA0", Offset = "0x57946A0", VA = "0x185795EA0")]
	public static EILHPPDHBHH FDCPICCCPGC(string KPMIPNBJALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5796170", Offset = "0x5794970", VA = "0x185796170")]
	[IteratorStateMachine(typeof(EGPMEELCOOB))]
	private static IEnumerator<EDDHBDCNFKM> FLANFLDHAJJ(string KPMIPNBJALP, GIELIJKIODJ NGEHEMCMAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x57969B0", Offset = "0x57951B0", VA = "0x1857969B0")]
	[IteratorStateMachine(typeof(DDLHKFGCKLC))]
	private static IEnumerator<EDDHBDCNFKM> JFPMKCCCMHB(string KPMIPNBJALP, LoadSceneMode GGEPKHEIMON, global::GBNOCCBNCBC<Scene> NGEHEMCMAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5796200", Offset = "0x5794A00", VA = "0x185796200")]
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
		[Cpp2IlInjected.Address(RVA = "0x57A2280", Offset = "0x57A0A80", VA = "0x1857A2280", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double DDJGPMKEACG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x126DA20", Offset = "0x126C220", VA = "0x18126DA20", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double GIBLADJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x126DA00", Offset = "0x126C200", VA = "0x18126DA00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x57A2490", Offset = "0x57A0C90", VA = "0x1857A2490")]
	public OGCKCENOJFH(int JJAMFICFNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x57A22F0", Offset = "0x57A0AF0", VA = "0x1857A22F0", Slot = "7")]
	public void NAAMMCMMHJJ(double FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x57A2420", Offset = "0x57A0C20", VA = "0x1857A2420", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x841940", Offset = "0x840140", VA = "0x180841940")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double DDJGPMKEACG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5794830", Offset = "0x5793030", VA = "0x185794830", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double GIBLADJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x131C900", Offset = "0x131B100", VA = "0x18131C900", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double MMGBDCHIPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5794810", Offset = "0x5793010", VA = "0x185794810")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double JNDLJOLGNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5794820", Offset = "0x5793020", VA = "0x185794820", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5794840", Offset = "0x5793040", VA = "0x185794840", Slot = "7")]
	public virtual void NAAMMCMMHJJ(double FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5794970", Offset = "0x5793170", VA = "0x185794970", Slot = "8")]
	public virtual void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5794310", Offset = "0x5792B10", VA = "0x185794310")]
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
		[Cpp2IlInjected.Address(RVA = "0x126DA10", Offset = "0x126C210", VA = "0x18126DA10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x126DA70", Offset = "0x126C270", VA = "0x18126DA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5794190", Offset = "0x5792990", VA = "0x185794190", Slot = "7")]
	public override void NAAMMCMMHJJ(double FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x57942D0", Offset = "0x5792AD0", VA = "0x1857942D0", Slot = "8")]
	public override void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5794310", Offset = "0x5792B10", VA = "0x185794310")]
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
		[Cpp2IlInjected.Address(RVA = "0x5795420", Offset = "0x5793C20", VA = "0x185795420", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public float DPLBEPDJHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5795380", Offset = "0x5793B80", VA = "0x185795380", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public double LGNCOMMFFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5795390", Offset = "0x5793B90", VA = "0x185795390", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x57953B0", Offset = "0x5793BB0", VA = "0x1857953B0")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public KAPGDHCKMCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5799DA0", Offset = "0x57985A0", VA = "0x185799DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5799E40", Offset = "0x5798640", VA = "0x185799E40", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x579CC30", Offset = "0x579B430", VA = "0x18579CC30")]
	public KMBMENJLJIN(MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x579D080", Offset = "0x579B880", VA = "0x18579D080")]
	public KMBMENJLJIN(MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x579CE30", Offset = "0x579B630", VA = "0x18579CE30")]
	public KMBMENJLJIN(MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x446B930", Offset = "0x446A130", VA = "0x18446B930")]
	private KMBMENJLJIN(MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x579C610", Offset = "0x579AE10", VA = "0x18579C610")]
	internal static KMBMENJLJIN JIOGLFAEKIA(MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x579C050", Offset = "0x579A850", VA = "0x18579C050")]
	private void CMKMJFNEGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x579C340", Offset = "0x579AB40", VA = "0x18579C340")]
	private void FKBGDGHABFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x579C8B0", Offset = "0x579B0B0", VA = "0x18579C8B0")]
	private void KMIPOHMMBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x579CA60", Offset = "0x579B260", VA = "0x18579CA60")]
	private void MOMJBFKPPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x579BE80", Offset = "0x579A680", VA = "0x18579BE80")]
	private void BJFNGAIIHFP(string FKPBDLDGFCC, Action FBPLMAHNFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x579C580", Offset = "0x579AD80", VA = "0x18579C580")]
	[IteratorStateMachine(typeof(KAPGDHCKMCE))]
	private IEnumerator<EDDHBDCNFKM> IBNDJFLHAGP(Action FBPLMAHNFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x579C2E0", Offset = "0x579AAE0", VA = "0x18579C2E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x579C4F0", Offset = "0x579ACF0", VA = "0x18579C4F0")]
	[CompilerGenerated]
	private void GECEGDDOCFF(string KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x579C1C0", Offset = "0x579A9C0", VA = "0x18579C1C0")]
	[CompilerGenerated]
	private void DCBKGKHNJOH(string KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x579BFC0", Offset = "0x579A7C0", VA = "0x18579BFC0")]
	[CompilerGenerated]
	private void CKCPBJEKDAD(string KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x579C250", Offset = "0x579AA50", VA = "0x18579C250")]
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
	[Cpp2IlInjected.Address(RVA = "0x579D690", Offset = "0x579BE90", VA = "0x18579D690")]
	public static KOPDEKEAKGO JLAKJAPJOGA(int OGLAFAPFBOH, float MLJIAJKDCFE, NativeArray<ELMBAIJANLF> AHPBELANDJJ, NativeArray<float> NEFMLNAKONK, NativeArray<int> KALAPHPLMMI, NativeArray<int> IGKGNEIMHMJ, NativeArray<int> HMIKNJPCGFN, NativeArray<int> IEJMMBFIOFJ, NativeArray<int> HOMJNINMJNP)
	{
		return default(KOPDEKEAKGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x579D4B0", Offset = "0x579BCB0", VA = "0x18579D4B0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x579D7C0", Offset = "0x579BFC0", VA = "0x18579D7C0")]
	private bool NGAKJBEGOMM(int NHHNPPKPBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x579D590", Offset = "0x579BD90", VA = "0x18579D590")]
	private void FOOBNDDLECA(NativeArray<int> JKEPHCKPPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x579D760", Offset = "0x579BF60", VA = "0x18579D760")]
	private int NFNBDECIPNO(int MDEEEEEKCNL, int HJGNBNDIBBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x579D5C0", Offset = "0x579BDC0", VA = "0x18579D5C0")]
	private void IKOMAADDNEP(NativeArray<int> JKEPHCKPPCN, int EMIHEDBEOEE, int EFBLLBPFDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x579D2C0", Offset = "0x579BAC0", VA = "0x18579D2C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5798800", Offset = "0x5797000", VA = "0x185798800")]
	public JENHBJAJBGG(Behaviour JFDMKPDIBDL, float BOLPILLKBJN, int OAAPKFDMBIO, [Optional] Action BKAJEJMKLNN, float MDNLGAALJEO = 0f, [Optional] MIGOFOLIJGE AHHBOMNOGMN, [Optional] JNCDEOLLBDP HKCAELOIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0", Slot = "9")]
	protected override bool BNJNOGOKADI(Action FOGMDOMFJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x57985D0", Offset = "0x5796DD0", VA = "0x1857985D0", Slot = "10")]
	protected override bool LGGCKOFADIL(Action FOGMDOMFJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5798540", Offset = "0x5796D40", VA = "0x185798540")]
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
		[Cpp2IlInjected.Address(RVA = "0x57993A0", Offset = "0x5797BA0", VA = "0x1857993A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool GLGGKOPKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public FAJLDPIGHEC.OCHFIJDOJPB ALFKLMICPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FAJLDPIGHEC.OCHFIJDOJPB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x80EE30", Offset = "0x80D630", VA = "0x18080EE30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public JNCDEOLLBDP KCGIIBMNCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5799800", Offset = "0x5798000", VA = "0x185799800")]
	public static CMHJCDCDCHH PIDCALFGNFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5799890", Offset = "0x5798090", VA = "0x185799890")]
	[Preserve]
	protected JHGFKAJELKB([ACEKLAKDMBL(null)] EDGHCOGIIEI OEDOFDBDLNG, [ACEKLAKDMBL(null)] JNCDEOLLBDP HKCAELOIPGM, [ACEKLAKDMBL(null)] DKJCBBDIGHA BHMNGDKDIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5798EA0", Offset = "0x57976A0", VA = "0x185798EA0", Slot = "6")]
	public CMHJCDCDCHH EBDHDHCPNAJ(IEnumerator<EDDHBDCNFKM> HFKDOGILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5798EB0", Offset = "0x57976B0", VA = "0x185798EB0", Slot = "7")]
	public CMHJCDCDCHH EBDHDHCPNAJ(Behaviour JFDMKPDIBDL, IEnumerator<EDDHBDCNFKM> HFKDOGILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract CMHJCDCDCHH HHKGFKCLLJC(CAMANOLKPPF JFDMKPDIBDL, IEnumerator<EDDHBDCNFKM> HFKDOGILHAO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5799600", Offset = "0x5797E00", VA = "0x185799600", Slot = "13")]
	public virtual void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5799340", Offset = "0x5797B40", VA = "0x185799340", Slot = "9")]
	public void HGEFHLKMOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x273B6C0", Offset = "0x2739EC0", VA = "0x18273B6C0", Slot = "14")]
	protected virtual void CCMEEJNHHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x57993F0", Offset = "0x5797BF0", VA = "0x1857993F0")]
	private void KPMGDJFMKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x57997E0", Offset = "0x5797FE0", VA = "0x1857997E0")]
	private void OCJGBDGIEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5798AE0", Offset = "0x57972E0", VA = "0x185798AE0")]
	private void AHMPHJEIING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5798B00", Offset = "0x5797300", VA = "0x185798B00")]
	private void CDDOLMJNADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5799410", Offset = "0x5797C10", VA = "0x185799410")]
	private void MDKKIKDHKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5798AC0", Offset = "0x57972C0", VA = "0x185798AC0")]
	private void AALBICKFCLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x57990E0", Offset = "0x57978E0", VA = "0x1857990E0")]
	private void EKIHKPHFBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5799100", Offset = "0x5797900", VA = "0x185799100", Slot = "15")]
	public virtual void GPFLMOACIOG(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5799430", Offset = "0x5797C30", VA = "0x185799430")]
	private void MEFPPNKONHF(NCJLMAILLHH CBNOLLAEAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xFD92E0", Offset = "0xFD7AE0", VA = "0x180FD92E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5798B20", Offset = "0x5797320", VA = "0x185798B20", Slot = "18")]
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
	[Cpp2IlInjected.Address(RVA = "0x579AF00", Offset = "0x5799700", VA = "0x18579AF00")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x579B3B0", Offset = "0x5799BB0", VA = "0x18579B3B0")]
	[Preserve]
	public KGJJBLKGEBP([ACEKLAKDMBL(null)] EDGHCOGIIEI OEDOFDBDLNG, [ACEKLAKDMBL(null)] JNCDEOLLBDP HKCAELOIPGM, [ACEKLAKDMBL(null)] DKJCBBDIGHA BHMNGDKDIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x579ADB0", Offset = "0x57995B0", VA = "0x18579ADB0", Slot = "12")]
	public override CMHJCDCDCHH HHKGFKCLLJC(CAMANOLKPPF JFDMKPDIBDL, IEnumerator<EDDHBDCNFKM> HFKDOGILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x579B0D0", Offset = "0x57998D0", VA = "0x18579B0D0", Slot = "13")]
	public override void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x579ABD0", Offset = "0x57993D0", VA = "0x18579ABD0", Slot = "15")]
	public override void GPFLMOACIOG(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x579A8A0", Offset = "0x57990A0", VA = "0x18579A8A0", Slot = "14")]
	protected override void CCMEEJNHHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x579AA60", Offset = "0x5799260", VA = "0x18579AA60")]
	private POCDKMEKJDH FNCFBPFOKGA(FAJLDPIGHEC.OCHFIJDOJPB FIJCKHKKDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x579AF70", Offset = "0x5799770", VA = "0x18579AF70", Slot = "16")]
	internal override BMAPIIJHNNA LPFFKDNEANB(IEnumerator<EDDHBDCNFKM> HFKDOGILHAO, Behaviour JFDMKPDIBDL, MMAHMIICAAG INGDMDMAGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x579A9F0", Offset = "0x57991F0", VA = "0x18579A9F0", Slot = "17")]
	internal override NCJLMAILLHH FJGKFECNKBE(FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x579AAA0", Offset = "0x57992A0", VA = "0x18579AAA0")]
	private void GMFKCNKNLNM(POCDKMEKJDH CBNOLLAEAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x579A980", Offset = "0x5799180", VA = "0x18579A980", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public IKPHCFIOIFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5797D40", Offset = "0x5796540", VA = "0x185797D40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5797DF0", Offset = "0x57965F0", VA = "0x185797DF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x57A29A0", Offset = "0x57A11A0", VA = "0x1857A29A0")]
	[IteratorStateMachine(typeof(IKPHCFIOIFM))]
	private static IEnumerator<EDDHBDCNFKM> LCPPGAMHGKJ(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, Func<bool> PEAFIALKKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x57A2A20", Offset = "0x57A1220", VA = "0x1857A2A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF80", Offset = "0x8CB780", VA = "0x1808CCF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EDDHBDCNFKM PJCEDJDGIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x811A70", Offset = "0x810270", VA = "0x180811A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LEFGJADGCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x578D520", Offset = "0x578BD20", VA = "0x18578D520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CHMBLFHDPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x997940", Offset = "0x996140", VA = "0x180997940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x997950", Offset = "0x996150", VA = "0x180997950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x578CFB0", Offset = "0x578B7B0", VA = "0x18578CFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float CHKEMKLOILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xB091F0", Offset = "0xB079F0", VA = "0x180B091F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xB093E0", Offset = "0xB07BE0", VA = "0x180B093E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x578D680", Offset = "0x578BE80", VA = "0x18578D680")]
	public BMAPIIJHNNA(IEnumerator<EDDHBDCNFKM> ACGKLCBEHNI, EDODCEDBKOE JFDMKPDIBDL, MMAHMIICAAG INGDMDMAGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x578D140", Offset = "0x578B940", VA = "0x18578D140")]
	public EDDHBDCNFKM BOECNPICAGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x578D4B0", Offset = "0x578BCB0", VA = "0x18578D4B0")]
	public bool LJKAKOHNDOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x578D430", Offset = "0x578BC30", VA = "0x18578D430")]
	public void IHLPPHPEFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x578D5A0", Offset = "0x578BDA0", VA = "0x18578D5A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x18DC5B0", Offset = "0x18DADB0", VA = "0x1818DC5B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public GPCGAMKOHDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5795430", Offset = "0x5793C30", VA = "0x185795430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x57954D0", Offset = "0x5793CD0", VA = "0x1857954D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x579EA10", Offset = "0x579D210", VA = "0x18579EA10")]
	public static CMHJCDCDCHH CMKMJFNEGHN(float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x579E900", Offset = "0x579D100", VA = "0x18579E900")]
	public static CMHJCDCDCHH CMKMJFNEGHN(MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x579ECD0", Offset = "0x579D4D0", VA = "0x18579ECD0")]
	public static CMHJCDCDCHH MLLAKFIKBHL(MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x579EB10", Offset = "0x579D310", VA = "0x18579EB10")]
	public static CMHJCDCDCHH GECBBKGFAJK(CAMANOLKPPF JFDMKPDIBDL, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x579EC20", Offset = "0x579D420", VA = "0x18579EC20")]
	private static IEnumerator<EDDHBDCNFKM> LOGHFDLNPCD(JNCDEOLLBDP HKCAELOIPGM, float JCGEOAKLAPK, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x579EDF0", Offset = "0x579D5F0", VA = "0x18579EDF0")]
	private static IEnumerator<EDDHBDCNFKM> NBCJNOOCLJC(JNCDEOLLBDP HKCAELOIPGM, float JCGEOAKLAPK, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x579E850", Offset = "0x579D050", VA = "0x18579E850")]
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
	[Cpp2IlInjected.Address(RVA = "0x24ECC90", Offset = "0x24EB490", VA = "0x1824ECC90")]
	public MIOIIKDLNDK(Action BBNKBLGKOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x579E270", Offset = "0x579CA70", VA = "0x18579E270", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public JENFAEIGLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x32EE980", Offset = "0x32ED180", VA = "0x1832EE980")]
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
		[Cpp2IlInjected.Address(RVA = "0xC6F0D0", Offset = "0xC6D8D0", VA = "0x180C6F0D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3FEE1C0", Offset = "0x3FEC9C0", VA = "0x183FEE1C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE8E0", Offset = "0x3FED0E0", VA = "0x183FEE8E0")]
	private static bool MMNJIDLNEBN(T NBLDAOBEAEA, T PAJLLFKCBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE9A0", Offset = "0x3FED1A0", VA = "0x183FEE9A0")]
	public OOEKDBJKCNA(T OPCIBHMHHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3FEDFD0", Offset = "0x3FEC7D0", VA = "0x183FEDFD0", Slot = "6")]
	public IDisposable DHNHICEFBDG(UnityEngine.Object JFDMKPDIBDL, Action<T> AOGDPENLCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE580", Offset = "0x3FECD80", VA = "0x183FEE580")]
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
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "4")]
	public void MABPDHNBGCN(string BPOKAAOBIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
	public void JEFGGGJLFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BLPMBJHPACH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x578B870", Offset = "0x578A070", VA = "0x18578B870")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AIABPJIJGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x578B870", Offset = "0x578A070", VA = "0x18578B870")]
		internal void KCFOPBIJABC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly float ENAEKFKILBL;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5797800", Offset = "0x5796000", VA = "0x185797800")]
	public MMDLICHJHOG(Behaviour JFDMKPDIBDL, float ENAEKFKILBL, [Optional] Action BKAJEJMKLNN, [Optional] MIGOFOLIJGE AHHBOMNOGMN, [Optional] JNCDEOLLBDP HKCAELOIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x579E650", Offset = "0x579CE50", VA = "0x18579E650", Slot = "9")]
	protected override bool BNJNOGOKADI(Action FOGMDOMFJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x579E750", Offset = "0x579CF50", VA = "0x18579E750", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public OEAHAIBDHGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x57A21A0", Offset = "0x57A09A0", VA = "0x1857A21A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x57A2240", Offset = "0x57A0A40", VA = "0x1857A2240", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x57951A0", Offset = "0x57939A0", VA = "0x1857951A0")]
	public GMIPMMPEJOD(CAMANOLKPPF JFDMKPDIBDL, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5794FF0", Offset = "0x57937F0", VA = "0x185794FF0")]
	private void KMIPOHMMBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5794BC0", Offset = "0x57933C0", VA = "0x185794BC0")]
	private void BJFNGAIIHFP(string FKPBDLDGFCC, Action FBPLMAHNFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5794F60", Offset = "0x5793760", VA = "0x185794F60")]
	[IteratorStateMachine(typeof(OEAHAIBDHGM))]
	private IEnumerator<EDDHBDCNFKM> IBNDJFLHAGP(Action FBPLMAHNFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5794D40", Offset = "0x5793540", VA = "0x185794D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5794DA0", Offset = "0x57935A0", VA = "0x185794DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MIEJEHNBAAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x579DA70", Offset = "0x579C270", VA = "0x18579DA70")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BLBBECLJNJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x578CD60", Offset = "0x578B560", VA = "0x18578CD60")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IAALFOKPFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5797900", Offset = "0x5796100", VA = "0x185797900")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public PHEBGLLAEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x57A2960", Offset = "0x57A1160", VA = "0x1857A2960")]
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
		[Cpp2IlInjected.Address(RVA = "0x159F040", Offset = "0x159D840", VA = "0x18159F040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x57A38D0", Offset = "0x57A20D0", VA = "0x1857A38D0")]
	private static int FBDOFLANMJG(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x57A59C0", Offset = "0x57A41C0", VA = "0x1857A59C0")]
	public POCDKMEKJDH(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x57A57D0", Offset = "0x57A3FD0", VA = "0x1857A57D0")]
	private void OLGMMCPBEBN(ref int EANLLOJLAIO, int CDHMDBKOOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x57A3750", Offset = "0x57A1F50", VA = "0x1857A3750")]
	public void ELPONEBJFIL(CAMANOLKPPF JFDMKPDIBDL, EDDHBDCNFKM AEEGDHAILFA, IEnumerator<EDDHBDCNFKM> ACGKLCBEHNI, MMAHMIICAAG INGDMDMAGEN, [Optional] EIJMEBMOMDG KCEAPOPEMCA, ELMBAIJANLF HGJCGJFAIAA = ELMBAIJANLF.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x57A4FD0", Offset = "0x57A37D0", VA = "0x1857A4FD0")]
	public void MMNMFEDDBCK(IEnumerable<PHINEGNEONL> GLDKCLFFBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x57A39D0", Offset = "0x57A21D0", VA = "0x1857A39D0")]
	private PHINEGNEONL HMFCJIEHPNJ(int DPCADPCKAIE)
	{
		return default(PHINEGNEONL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x57A52F0", Offset = "0x57A3AF0", VA = "0x1857A52F0")]
	private void OCBALCGKAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x23DAEF0", Offset = "0x23D96F0", VA = "0x1823DAEF0")]
	private static void BLNCHDJDAOD<T>(int DPCADPCKAIE, T[] NINHBCLOIKF, int GEFPLPIBMGI, [Optional] T KCKBMNPLEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x23DAED0", Offset = "0x23D96D0", VA = "0x1823DAED0")]
	private static void BLNCHDJDAOD<T>(int DPCADPCKAIE, NativeArray<T> NINHBCLOIKF, int GEFPLPIBMGI, [Optional] T KCKBMNPLEND) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x57A3F30", Offset = "0x57A2730", VA = "0x1857A3F30")]
	private void IGGIJNMCEJK(IEnumerable<PHINEGNEONL> GLDKCLFFBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x57A3900", Offset = "0x57A2100", VA = "0x1857A3900")]
	private void GCDEGNOJJFK(PHINEGNEONL HIKHABDCNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x57A4A30", Offset = "0x57A3230", VA = "0x1857A4A30")]
	private GDNMAAKJBBE JDECEFHGOJP(int COPDPNGMEHL)
	{
		return default(GDNMAAKJBBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x57A4CF0", Offset = "0x57A34F0", VA = "0x1857A4CF0")]
	public void KHEFPDNDCBO(float MLJIAJKDCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x57A3650", Offset = "0x57A1E50", VA = "0x1857A3650")]
	private void BDDHMKMGLBM(Action NBLDAOBEAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x57A36D0", Offset = "0x57A1ED0", VA = "0x1857A36D0")]
	private void BDHODHLHFGI(Action NBLDAOBEAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x57A41E0", Offset = "0x57A29E0", VA = "0x1857A41E0")]
	public void IHDAFOJLHID(float MLJIAJKDCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x57A4ED0", Offset = "0x57A36D0", VA = "0x1857A4ED0")]
	public void LIEFKNGBAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x57A4900", Offset = "0x57A3100", VA = "0x1857A4900")]
	public void IHLPPHPEFDP(EIJMEBMOMDG JALAIHEAFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x57A51C0", Offset = "0x57A39C0", VA = "0x1857A51C0")]
	public void NEDAAMABCNE(EIJMEBMOMDG JALAIHEAFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x57A56A0", Offset = "0x57A3EA0", VA = "0x1857A56A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x579F020", Offset = "0x579D820", VA = "0x18579F020", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action AGKGHIPOIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x579F4E0", Offset = "0x579DCE0", VA = "0x18579F4E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x579EE50", Offset = "0x579D650", VA = "0x18579EE50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x579F760", Offset = "0x579DF60", VA = "0x18579F760")]
	public MNAAPCAPGEA([Optional] Action BKAJEJMKLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x579EEF0", Offset = "0x579D6F0", VA = "0x18579EEF0")]
	public void CAILCKFFJIK(ABKJDKGEDHK FAOJOGEGLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x579F580", Offset = "0x579DD80", VA = "0x18579F580")]
	private void PBKAHGNIKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x579F160", Offset = "0x579D960", VA = "0x18579F160", Slot = "7")]
	public bool GAJEEJKLEBN(bool HCKNDFMIDDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x579F180", Offset = "0x579D980", VA = "0x18579F180", Slot = "8")]
	public bool GAJEEJKLEBN(Action FOGMDOMFJBB, bool HCKNDFMIDDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x579F460", Offset = "0x579DC60", VA = "0x18579F460", Slot = "9")]
	public IEnumerator<ABKJDKGEDHK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x579F6E0", Offset = "0x579DEE0", VA = "0x18579F6E0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public POMADEOGJPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x57A5FD0", Offset = "0x57A47D0", VA = "0x1857A5FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x57A60A0", Offset = "0x57A48A0", VA = "0x1857A60A0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8FE190", Offset = "0x8FC990", VA = "0x1808FE190", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AGKGHIPOIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x579A330", Offset = "0x5798B30", VA = "0x18579A330", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5799E80", Offset = "0x5798680", VA = "0x185799E80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x579A3D0", Offset = "0x5798BD0", VA = "0x18579A3D0")]
	protected KCLDKBLIHJB(Behaviour JFDMKPDIBDL, [Optional] Action BKAJEJMKLNN, [Optional] MIGOFOLIJGE AHHBOMNOGMN, [Optional] JNCDEOLLBDP HKCAELOIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5799FF0", Offset = "0x57987F0", VA = "0x185799FF0", Slot = "7")]
	public bool GAJEEJKLEBN(bool HCKNDFMIDDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5799FA0", Offset = "0x57987A0", VA = "0x185799FA0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x579A110", Offset = "0x5798910", VA = "0x18579A110")]
	protected void JOOGACAGIBI(Action FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x579A130", Offset = "0x5798930", VA = "0x18579A130")]
	protected EILHPPDHBHH LAEBHLEDGAN(float NCOPMNKMGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5799F20", Offset = "0x5798720", VA = "0x185799F20")]
	private void FOOJFLGPHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x579A090", Offset = "0x5798890", VA = "0x18579A090")]
	[IteratorStateMachine(typeof(POMADEOGJPC))]
	private IEnumerator<EDDHBDCNFKM> IAAJPINNLNM(float NCOPMNKMGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x579A050", Offset = "0x5798850", VA = "0x18579A050")]
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
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x80EE30", Offset = "0x80D630", VA = "0x18080EE30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5793B50", Offset = "0x5792350", VA = "0x185793B50")]
	public static EDDHBDCNFKM BOECNPICAGA(IEnumerator<EDDHBDCNFKM> ACGKLCBEHNI, MMAHMIICAAG INGDMDMAGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5793A70", Offset = "0x5792270", VA = "0x185793A70")]
	public EDDHBDCNFKM BOECNPICAGA(MMAHMIICAAG[] ICMGGNEFIDI, IEnumerator<EDDHBDCNFKM>[] NAGBLHNKPPI, EDDHBDCNFKM[] ODJLMFCLOHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5793A40", Offset = "0x5792240", VA = "0x185793A40")]
	public void BCOICPKFPFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5793D00", Offset = "0x5792500", VA = "0x185793D00")]
	public void KBMHHPDMDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5793E40", Offset = "0x5792640", VA = "0x185793E40")]
	public void KMBGLODHFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5793A40", Offset = "0x5792240", VA = "0x185793A40")]
	public void IHLPPHPEFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public MLIAODIDIAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x579E4A0", Offset = "0x579CCA0", VA = "0x18579E4A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x579E580", Offset = "0x579CD80", VA = "0x18579E580", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C8220", Offset = "0x8C6A20", VA = "0x1808C8220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5797C40", Offset = "0x5796440", VA = "0x185797C40")]
	public IIPLFBCCFGI(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5797BD0", Offset = "0x57963D0", VA = "0x185797BD0")]
	[IteratorStateMachine(typeof(MLIAODIDIAE))]
	private IEnumerator<EDDHBDCNFKM> PKOGBDHJAEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5797B50", Offset = "0x5796350", VA = "0x185797B50", Slot = "4")]
	public void OnCompleted(Action HDKINLLDJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public void GKEBEGBOMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class DNPINCALCNB
{
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5792740", Offset = "0x5790F40", VA = "0x185792740")]
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
	[Cpp2IlInjected.Address(RVA = "0x579E390", Offset = "0x579CB90", VA = "0x18579E390")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD20", Offset = "0x8AB520", VA = "0x1808ACD20")]
	[Preserve]
	internal MKFIOJMMBDJ([ACEKLAKDMBL(null)] MIGOFOLIJGE AHHBOMNOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x579E400", Offset = "0x579CC00", VA = "0x18579E400", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x80DE70", Offset = "0x80C670", VA = "0x18080DE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x57A1500", Offset = "0x579FD00", VA = "0x1857A1500")]
	public NCJLMAILLHH(FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, FBOMFECIPEF EFBPEFJDEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x57A0340", Offset = "0x579EB40", VA = "0x1857A0340")]
	public void DHIPFOPICGA(BMAPIIJHNNA ACGKLCBEHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x57A0D90", Offset = "0x579F590", VA = "0x1857A0D90")]
	public void JELHPIIPFFL(IList<BMAPIIJHNNA> NAGBLHNKPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x57A0AC0", Offset = "0x579F2C0", VA = "0x1857A0AC0")]
	public void HPIBDMBNHAI(IList<BMAPIIJHNNA> NAGBLHNKPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x57A1190", Offset = "0x579F990", VA = "0x1857A1190")]
	private void MIKILKODAEJ(BMAPIIJHNNA ACGKLCBEHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x57A01C0", Offset = "0x579E9C0", VA = "0x1857A01C0")]
	private void CGCFHPMFGDN(IList<BMAPIIJHNNA> NAGBLHNKPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x57A1290", Offset = "0x579FA90", VA = "0x1857A1290")]
	private GDNMAAKJBBE PODHEKDCAEM(BMAPIIJHNNA ACGKLCBEHNI)
	{
		return default(GDNMAAKJBBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x57A0080", Offset = "0x579E880", VA = "0x1857A0080")]
	public void CCMEEJNHHBN(float MLJIAJKDCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x57A08B0", Offset = "0x579F0B0", VA = "0x1857A08B0")]
	public void HGEFHLKMOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x57A05A0", Offset = "0x579EDA0", VA = "0x1857A05A0")]
	private void ENMMGDBJGHM(List<BMAPIIJHNNA> NAGBLHNKPPI, Stack<int> BMOLFOMHNMP, bool CNBPFBLHMGM, float MNENFANELGM = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x57A0460", Offset = "0x579EC60", VA = "0x1857A0460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x57A1060", Offset = "0x579F860", VA = "0x1857A1060")]
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
		[Cpp2IlInjected.Address(RVA = "0x57989D0", Offset = "0x57971D0", VA = "0x1857989D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EBBFILBJDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5798A60", Offset = "0x5797260", VA = "0x185798A60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool BDFENNMIFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x57989B0", Offset = "0x57971B0", VA = "0x1857989B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD20", Offset = "0x8AB520", VA = "0x1808ACD20")]
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
	[Cpp2IlInjected.Address(RVA = "0x5797800", Offset = "0x5796000", VA = "0x185797800")]
	public HOIPPFHPFHD(Behaviour JFDMKPDIBDL, float ENAEKFKILBL, [Optional] Action BKAJEJMKLNN, [Optional] MIGOFOLIJGE AHHBOMNOGMN, [Optional] JNCDEOLLBDP HKCAELOIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0", Slot = "9")]
	protected override bool BNJNOGOKADI(Action FOGMDOMFJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x57977C0", Offset = "0x5795FC0", VA = "0x1857977C0", Slot = "10")]
	protected override bool LGGCKOFADIL(Action FOGMDOMFJBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class ODGGAAOKKGP
{
	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x57A20A0", Offset = "0x57A08A0", VA = "0x1857A20A0")]
	public static IDisposable IIBGFLKBLMC(this CAMANOLKPPF JFDMKPDIBDL, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x57A2120", Offset = "0x57A0920", VA = "0x1857A2120")]
	public static IDisposable LIILFFPPBDE(this CAMANOLKPPF JFDMKPDIBDL, Action<float> KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x57A2020", Offset = "0x57A0820", VA = "0x1857A2020")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public DPEOPLPJPLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5792870", Offset = "0x5791070", VA = "0x185792870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5792930", Offset = "0x5791130", VA = "0x185792930", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public HNPBNFNJIBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5797690", Offset = "0x5795E90", VA = "0x185797690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5797780", Offset = "0x5795F80", VA = "0x185797780", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x57A2DF0", Offset = "0x57A15F0", VA = "0x1857A2DF0")]
	public static CMHJCDCDCHH CMKMJFNEGHN(Action KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x57A2EA0", Offset = "0x57A16A0", VA = "0x1857A2EA0")]
	public static CMHJCDCDCHH CMKMJFNEGHN(Behaviour JFDMKPDIBDL, Action KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x57A2F60", Offset = "0x57A1760", VA = "0x1857A2F60")]
	public static CMHJCDCDCHH CMKMJFNEGHN(Behaviour JFDMKPDIBDL, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x57A3070", Offset = "0x57A1870", VA = "0x1857A3070")]
	[IteratorStateMachine(typeof(DPEOPLPJPLB))]
	private static IEnumerator<EDDHBDCNFKM> LOGHFDLNPCD(FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x57A30F0", Offset = "0x57A18F0", VA = "0x1857A30F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5792F40", Offset = "0x5791740", VA = "0x185792F40")]
	public static IDisposable CMKMJFNEGHN(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5792EC0", Offset = "0x57916C0", VA = "0x185792EC0")]
	public static IDisposable CMKMJFNEGHN(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5792D30", Offset = "0x5791530", VA = "0x185792D30")]
	public static IDisposable CCMEEJNHHBN(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5792C30", Offset = "0x5791430", VA = "0x185792C30")]
	public static IDisposable AHMPHJEIING(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5792E40", Offset = "0x5791640", VA = "0x185792E40")]
	public static IDisposable CDDOLMJNADI(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5792CB0", Offset = "0x57914B0", VA = "0x185792CB0")]
	public static IDisposable AIHEDPEKEFP(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5793460", Offset = "0x5791C60", VA = "0x185793460")]
	public static IDisposable NLGPPFHEBBL(this MonoBehaviour CBPNGHBBIDH, Action KGIKOGHKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5792DA0", Offset = "0x57915A0", VA = "0x185792DA0")]
	public static IDisposable CCMGGAKIGEB(this MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x57934E0", Offset = "0x5791CE0", VA = "0x1857934E0")]
	public static IDisposable NNLPPHAGFCG(this MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x57933C0", Offset = "0x5791BC0", VA = "0x1857933C0")]
	public static IDisposable NKLPHIBJJOP(this MonoBehaviour CBPNGHBBIDH, float JCGEOAKLAPK, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x57930E0", Offset = "0x57918E0", VA = "0x1857930E0")]
	public static IDisposable GABCHMFLIPN(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5793170", Offset = "0x5791970", VA = "0x185793170")]
	public static IDisposable GKMNBDMAOGE(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5793050", Offset = "0x5791850", VA = "0x185793050")]
	public static IDisposable FPJEAJKGECO(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x57932A0", Offset = "0x5791AA0", VA = "0x1857932A0")]
	public static IDisposable LPMLLICCKEH(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5792FC0", Offset = "0x57917C0", VA = "0x185792FC0")]
	public static IDisposable DMKKHKOJBDL(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5793510", Offset = "0x5791D10", VA = "0x185793510")]
	public static IDisposable PLHFNCIGLLF(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5793330", Offset = "0x5791B30", VA = "0x185793330")]
	public static IDisposable NCJNKKEJIEB(this MonoBehaviour CBPNGHBBIDH, Action<float> KGIKOGHKBLP, bool AMKCALCHEML = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5793200", Offset = "0x5791A00", VA = "0x185793200")]
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
		[Cpp2IlInjected.Address(RVA = "0xC64430", Offset = "0xC62C30", VA = "0x180C64430", Slot = "23")]
		get
		{
			return default(FAJLDPIGHEC.OCHFIJDOJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public FAJLDPIGHEC.OCHFIJDOJPB KACNFGMOBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x908390", Offset = "0x906B90", VA = "0x180908390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private float NNDJOPJJCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xD8DDF0", Offset = "0xD8C5F0", VA = "0x180D8DDF0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool GJEDFCMFDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x579E5D0", Offset = "0x579CDD0", VA = "0x18579E5D0", Slot = "24")]
	private bool ECBPNKDPJDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x579E5C0", Offset = "0x579CDC0", VA = "0x18579E5C0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x579E5F0", Offset = "0x579CDF0", VA = "0x18579E5F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public INEKPAONJEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x57982B0", Offset = "0x5796AB0", VA = "0x1857982B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5798370", Offset = "0x5796B70", VA = "0x185798370", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public FNMFPLBGOPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5794700", Offset = "0x5792F00", VA = "0x185794700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x57947D0", Offset = "0x5792FD0", VA = "0x1857947D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x579BDF0", Offset = "0x579A5F0", VA = "0x18579BDF0")]
	[IteratorStateMachine(typeof(INEKPAONJEM))]
	private static IEnumerator<EDDHBDCNFKM> PKOGBDHJAEG(float JJEEOOEDFIC, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x579B630", Offset = "0x5799E30", VA = "0x18579B630")]
	[IteratorStateMachine(typeof(FNMFPLBGOPK))]
	private static IEnumerator<EDDHBDCNFKM> CJBIBAPPMPH(float JJEEOOEDFIC, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x579B9A0", Offset = "0x579A1A0", VA = "0x18579B9A0")]
	public static IDisposable MADFBPINOBF(this MonoBehaviour CBPNGHBBIDH, float JJEEOOEDFIC, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x579B8B0", Offset = "0x579A0B0", VA = "0x18579B8B0")]
	public static CMHJCDCDCHH KOBMNJKNNJO(this MonoBehaviour CBPNGHBBIDH, float JJEEOOEDFIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x579BAC0", Offset = "0x579A2C0", VA = "0x18579BAC0")]
	public static CMHJCDCDCHH MADFBPINOBF(this MonoBehaviour CBPNGHBBIDH, float JJEEOOEDFIC, FAJLDPIGHEC.OCHFIJDOJPB MCCOEGJFPHG, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x579B890", Offset = "0x579A090", VA = "0x18579B890")]
	public static CMHJCDCDCHH KNDCNODHFPK(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x579BDC0", Offset = "0x579A5C0", VA = "0x18579BDC0")]
	public static CMHJCDCDCHH OAHHIGBGNDH(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x579B550", Offset = "0x5799D50", VA = "0x18579B550")]
	public static CMHJCDCDCHH CDAEBIODGKC(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x579BCC0", Offset = "0x579A4C0", VA = "0x18579BCC0")]
	public static CMHJCDCDCHH NBEDIKFOOBB(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x579B970", Offset = "0x579A170", VA = "0x18579B970")]
	public static CMHJCDCDCHH LONPFELMGBC(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x579B6C0", Offset = "0x5799EC0", VA = "0x18579B6C0")]
	public static CMHJCDCDCHH GCJHDJBDFDP(this MonoBehaviour CBPNGHBBIDH, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x579BBF0", Offset = "0x579A3F0", VA = "0x18579BBF0")]
	private static CMHJCDCDCHH MEKMLNEGBMK(MonoBehaviour CBPNGHBBIDH, FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, Action ELKBEDCOHFJ, [Optional] MIGOFOLIJGE AHHBOMNOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x579B7C0", Offset = "0x5799FC0", VA = "0x18579B7C0")]
	public static CMHJCDCDCHH JKMNKBLGFCK(this MonoBehaviour CBPNGHBBIDH, float FHCKNGCEODO, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x579B6F0", Offset = "0x5799EF0", VA = "0x18579B6F0")]
	public static CMHJCDCDCHH JDHHJNEFMOP(this MonoBehaviour CBPNGHBBIDH, float FHCKNGCEODO, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x579BCF0", Offset = "0x579A4F0", VA = "0x18579BCF0")]
	public static CMHJCDCDCHH NKFNKKHIIOA(this MonoBehaviour CBPNGHBBIDH, float FHCKNGCEODO, Action ELKBEDCOHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x579B480", Offset = "0x5799C80", VA = "0x18579B480")]
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

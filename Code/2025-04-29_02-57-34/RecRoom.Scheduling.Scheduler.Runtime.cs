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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85858C0", Offset = "0x8584CC0", VA = "0x1885858C0", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x858DAD0", Offset = "0x858CED0", VA = "0x18858DAD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
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
		private delegate List<PlayerLoopSystem> CEABOOFEDNB(List<PlayerLoopSystem> IBLDOKKBJCP, int ACMIDAELEMD);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct DIMJHNDBLCA
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct MBHCBAJBNCL
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static KFBDEOPEKLE HPCMBLBGBLJ;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x8585A30", Offset = "0x8584E30", VA = "0x188585A30")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct GNOGHMHMDCP
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static KFBDEOPEKLE OFEMBGBOBLA;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x85802C0", Offset = "0x857F6C0", VA = "0x1885802C0")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct BIIMFMKIGAG
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static KFBDEOPEKLE EOLCCAOIDPD;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x8572080", Offset = "0x8571480", VA = "0x188572080")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct PLIICFEGMLP
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static KFBDEOPEKLE DPONOCLOOGN;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static KFBDEOPEKLE AJPCDKMHOGB;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static KFBDEOPEKLE PACLBHGAHDP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static KFBDEOPEKLE NILGMDFONOA;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x858C590", Offset = "0x858B990", VA = "0x18858C590")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct KEOEPIMLAGL
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static KFBDEOPEKLE GFOJBDNNNLB;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x8585010", Offset = "0x8584410", VA = "0x188585010")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct NHADNJBNBAA
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static KFBDEOPEKLE DPONOCLOOGN;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static KFBDEOPEKLE AJPCDKMHOGB;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static KFBDEOPEKLE PACLBHGAHDP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static KFBDEOPEKLE NILGMDFONOA;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x858A6A0", Offset = "0x8589AA0", VA = "0x18858A6A0")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct ACOAHEJDEGM
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static KFBDEOPEKLE HANLOFMLJMN;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x85709D0", Offset = "0x856FDD0", VA = "0x1885709D0")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct EAMIIAIOPEB
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static KFBDEOPEKLE LEKOCBNFPKM;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x857EA50", Offset = "0x857DE50", VA = "0x18857EA50")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct HNIPOLMHFAN
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static KFBDEOPEKLE MDJABEJKFHL;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x8582950", Offset = "0x8581D50", VA = "0x188582950")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct IILBJLAFJMI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static KFBDEOPEKLE LHPNBIAGJGJ;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x8584590", Offset = "0x8583990", VA = "0x188584590")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct LDLHJOICPGK
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static KFBDEOPEKLE HGNJBLANKIH;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x85855B0", Offset = "0x85849B0", VA = "0x1885855B0")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct MFDAEMJBCFN
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static KFBDEOPEKLE NDFOMHJLEIK;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x8586540", Offset = "0x8585940", VA = "0x188586540")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct HJANIHEHJLH
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static KFBDEOPEKLE CDMGDPCGOLD;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x8582330", Offset = "0x8581730", VA = "0x188582330")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct BIMKHNGNCBN
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static KFBDEOPEKLE JBKNKCINEFB;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x8572280", Offset = "0x8571680", VA = "0x188572280")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct KJEALMJHMOP
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static KFBDEOPEKLE JAFLOPMAHIE;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x8585210", Offset = "0x8584610", VA = "0x188585210")]
				public static PlayerLoopSystem FMPNAKIDBAP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum INHAKDIIFKF : byte
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
			public struct AJBLDICDLIB
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class OHKCKMGKEKC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public INHAKDIIFKF updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
					public OHKCKMGKEKC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x858BD30", Offset = "0x858B130", VA = "0x18858BD30")]
					internal void JCEBCAAIOFH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static MAAICPKGELE<INHAKDIIFKF> AKEELCJADEA;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x8571520", Offset = "0x8570920", VA = "0x188571520")]
				public static PlayerLoopSystem FMPNAKIDBAP(INHAKDIIFKF JGEAJFKBBOL)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct GLEPALBCBEK
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class ADPNOJKOFLB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public HJKKKOFIFFC.NKCJFOMKJJE key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
					public ADPNOJKOFLB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x8570BD0", Offset = "0x856FFD0", VA = "0x188570BD0")]
					internal void JNEBNAAGCMI()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable GADOCLHJJLN;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x8580140", Offset = "0x857F540", VA = "0x188580140")]
				public static PlayerLoopSystem LFPGAMFACBE(HJKKKOFIFFC.NKCJFOMKJJE IICGAABOENK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct CLKEOFJIFNH
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class DHPJIGOAPCL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public HJKKKOFIFFC.NKCJFOMKJJE key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
					public DHPJIGOAPCL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x857D720", Offset = "0x857CB20", VA = "0x18857D720")]
					internal void JNEBNAAGCMI()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x85768A0", Offset = "0x8575CA0", VA = "0x1885768A0")]
				public static PlayerLoopSystem LFPGAMFACBE(HJKKKOFIFFC.NKCJFOMKJJE IICGAABOENK)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class KOLOIGOJOPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public KOLOIGOJOPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8585410", Offset = "0x8584810", VA = "0x188585410")]
			internal List<PlayerLoopSystem> NKJPHEKDOPI(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool GODIJBGEMMC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool OHDIPADIPMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8578D50", Offset = "0x8578150", VA = "0x188578D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8578D90", Offset = "0x8578190", VA = "0x188578D90")]
		private static void HEMKNFJMFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x857C3F0", Offset = "0x857B7F0", VA = "0x18857C3F0")]
		private static void KLHGECDIAMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8578D10", Offset = "0x8578110", VA = "0x188578D10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x857CE30", Offset = "0x857C230", VA = "0x18857CE30")]
		private static void OCPPMALGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x857C230", Offset = "0x857B630", VA = "0x18857C230")]
		private static void KJILFOMEGBN(HJKKKOFIFFC.NKCJFOMKJJE IICGAABOENK, PlayerLoopSystem DKMKOODJJFJ, Type CELAKGHCPFN, Type NAGEOILKBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x857BE50", Offset = "0x857B250", VA = "0x18857BE50")]
		private static void JJNAMLECNMN(PlayerLoopSystem DKMKOODJJFJ, Type CELAKGHCPFN, Type NAGEOILKBOJ, CEABOOFEDNB MLHEDJECMOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x857CD00", Offset = "0x857C100", VA = "0x18857CD00")]
		private static void LADBNKNCJJJ(PlayerLoopSystem DKMKOODJJFJ, Type CELAKGHCPFN, Type NAGEOILKBOJ, PlayerLoopSystem? NPKPGFOHBMJ, PlayerLoopSystem? HPGKOLMMMJB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HJKKKOFIFFC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum NKCJFOMKJJE
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
	public class JOHCMBCICBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly NKCJFOMKJJE NMLFJONJGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly DKHAFMJPPMO LPDDLLFBAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long LECGCKNPNIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long EGKLMDHEFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long NAFPLJKNCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int HDLGLHANEJC;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8584F80", Offset = "0x8584380", VA = "0x188584F80")]
		public JOHCMBCICBG(NKCJFOMKJJE MNKCDGMAOKP, int AMDOIFGFBII = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8584F60", Offset = "0x8584360", VA = "0x188584F60")]
		public void PMLMIFDHCFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8584E30", Offset = "0x8584230", VA = "0x188584E30")]
		public void KFMAACICDPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8584E80", Offset = "0x8584280", VA = "0x188584E80")]
		public void MCKDFNDNMJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static NKCJFOMKJJE[] MFDKFCFPGIO;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static JOHCMBCICBG[] HGPPANCKPIE;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x85825E0", Offset = "0x85819E0", VA = "0x1885825E0")]
	public static JOHCMBCICBG OLODCDEKNOO(NKCJFOMKJJE IICGAABOENK, int AMDOIFGFBII = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8582740", Offset = "0x8581B40", VA = "0x188582740")]
	public static JOHCMBCICBG OPLKFMGFPBB(NKCJFOMKJJE IICGAABOENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8582530", Offset = "0x8581930", VA = "0x188582530")]
	public static void KHLLKAGGKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class GOMKKDALDPI
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface LFMPFCHDPGD
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool GLEFABGHDAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HCGDJHNEKJN();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class JJDHBOKOIDN : LFMPFCHDPGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action PDHMHKIHKPF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool GLEFABGHDAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
		public JJDHBOKOIDN(Action PDHMHKIHKPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x10BAFA0", Offset = "0x10BA3A0", VA = "0x1810BAFA0", Slot = "5")]
		public void HCGDJHNEKJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<LFMPFCHDPGD> GHMACINKBAB;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8581580", Offset = "0x8580980", VA = "0x188581580")]
	public static void MPAJPDGENCE(Action PDHMHKIHKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8581280", Offset = "0x8580680", VA = "0x188581280")]
	private static void HNIDGCCJFIF(LFMPFCHDPGD OIAKHGJMPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8580F80", Offset = "0x8580380", VA = "0x188580F80")]
	private static void FNFAAGKKPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8580E80", Offset = "0x8580280", VA = "0x188580E80")]
	private static void CHCKCPOGNPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x85814A0", Offset = "0x85808A0", VA = "0x1885814A0")]
	private static void KOIBOCALFMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class COKJOOFDFNG
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct HAOFEDJNPBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> GLKIHGHLBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string OGBJCLBNMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode PPHBIEDOJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool MAONBEFDDAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x85816B0", Offset = "0x8580AB0", VA = "0x1885816B0")]
		public HAOFEDJNPBK(TaskCompletionSource<Scene> BGBOPFLGEHK, string OGBJCLBNMBK, LoadSceneMode PPHBIEDOJPC, bool MAONBEFDDAD, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct MDLDLLKBGDE : IAsyncStateMachine
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
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private BNJJFADPKOK<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x8585C30", Offset = "0x8585030", VA = "0x188585C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x85864D0", Offset = "0x85858D0", VA = "0x1885864D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct MIDFIDFCLBC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8588720", Offset = "0x8587B20", VA = "0x188588720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8588A40", Offset = "0x8587E40", VA = "0x188588A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct JFJOOAOHEIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private HAOFEDJNPBK <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8584900", Offset = "0x8583D00", VA = "0x188584900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8584CC0", Offset = "0x85840C0", VA = "0x188584CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class FHCNCBAFLHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public DJMJGHEAECO<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public FHCNCBAFLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8580070", Offset = "0x857F470", VA = "0x188580070")]
		internal void BCOCMHNGNDE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct HEEJLHCHKPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

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
		private FHCNCBAFLHJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8581710", Offset = "0x8580B10", VA = "0x188581710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85822C0", Offset = "0x85816C0", VA = "0x1885822C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct CKNMPLCCCAC : IAsyncStateMachine
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
		private FNIAOHCFFHK <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8576170", Offset = "0x8575570", VA = "0x188576170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8576830", Offset = "0x8575C30", VA = "0x188576830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct ENGHPEKFPFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x857EE40", Offset = "0x857E240", VA = "0x18857EE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x857F960", Offset = "0x857ED60", VA = "0x18857F960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class BLPIAAGKNGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public DJMJGHEAECO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BLPIAAGKNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8572480", Offset = "0x8571880", VA = "0x188572480")]
		internal bool BAFKAKGIANF(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8572500", Offset = "0x8571900", VA = "0x188572500")]
		internal void HHKIPPBGDEE(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class CIFPIELAOMA : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public DJMJGHEAECO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private BLPIAAGKNGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private FNIAOHCFFHK <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public CIFPIELAOMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8576110", Offset = "0x8575510", VA = "0x188576110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8575820", Offset = "0x8574C20", VA = "0x188575820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8575800", Offset = "0x8574C00", VA = "0x188575800")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85760C0", Offset = "0x85754C0", VA = "0x1885760C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> EMGFPOMFCLJ;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static DKABIBJEBOC CICMAMIHFKP;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation NADMEMGLGLC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static DKABIBJEBOC EJOJMMNPMHP;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string PEDANCFMCOL;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string OOJGLFBNJGL;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority JKFAHFHKKLC;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task EOCOLJELGBO;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> PFOFCKAFGOK;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<HAOFEDJNPBK> NIDMNIEJNJB;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task BMBDGDMEPME;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> PAAEBEFPAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8578140", Offset = "0x8577540", VA = "0x188578140")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8578530", Offset = "0x8577930", VA = "0x188578530")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8577A00", Offset = "0x8576E00", VA = "0x188577A00")]
	[ACNGIGGALON(NCEMIMPHJMG.EnteredEditModeNextFrame, 0)]
	private static void FNAAEHPMIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8577B00", Offset = "0x8576F00", VA = "0x188577B00")]
	[AsyncStateMachine(typeof(MDLDLLKBGDE))]
	public static Task<Scene> GHDFIHHDIDL(string OGBJCLBNMBK, LoadSceneMode PPHBIEDOJPC = LoadSceneMode.Single, bool MAONBEFDDAD = false, [Optional] BNJJFADPKOK<string>.EFJIBBJEOLP LGPBKOFNJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8577DD0", Offset = "0x85771D0", VA = "0x188577DD0")]
	[AsyncStateMachine(typeof(MIDFIDFCLBC))]
	private static Task GPHDEHHEPLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x85774A0", Offset = "0x85768A0", VA = "0x1885774A0")]
	[AsyncStateMachine(typeof(JFJOOAOHEIM))]
	private static Task AIAFCFDIBEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x85783E0", Offset = "0x85777E0", VA = "0x1885783E0")]
	[AsyncStateMachine(typeof(HEEJLHCHKPP))]
	private static Task<Scene> NIMMKLNHAFO(string OGBJCLBNMBK, LoadSceneMode PPHBIEDOJPC, bool MAONBEFDDAD, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8577390", Offset = "0x8576790", VA = "0x188577390")]
	private static void AGAHGHGJFEK(SceneInstance KBMKBMHFKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8577E80", Offset = "0x8577280", VA = "0x188577E80")]
	private static void LCEGPKAIIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8577870", Offset = "0x8576C70", VA = "0x188577870")]
	[AsyncStateMachine(typeof(CKNMPLCCCAC))]
	private static Task<Scene> EPCPMDOCPOO(string OGBJCLBNMBK, LoadSceneMode PPHBIEDOJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8578250", Offset = "0x8577650", VA = "0x188578250")]
	private static bool NFFLGNMOCHN(string OGBJCLBNMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8577570", Offset = "0x8576970", VA = "0x188577570")]
	[AsyncStateMachine(typeof(ENGHPEKFPFO))]
	private static Task<Scene> CIMNIOCCCBL(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8577C50", Offset = "0x8577050", VA = "0x188577C50")]
	public static NDJGFNKMCGL<Scene> GMADMEPMGAG(string OGBJCLBNMBK, LoadSceneMode PPHBIEDOJPC = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8578340", Offset = "0x8577740", VA = "0x188578340")]
	[IteratorStateMachine(typeof(CIFPIELAOMA))]
	private static IEnumerator<LCENDOCODMB> NGONDHCBHBD(string OGBJCLBNMBK, LoadSceneMode PPHBIEDOJPC, DJMJGHEAECO<Scene> IKFFGLAMILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x85779A0", Offset = "0x8576DA0", VA = "0x1885779A0")]
	public static void FJBAJLFNIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8577680", Offset = "0x8576A80", VA = "0x188577680")]
	private static void CKDJPNJIKDE(string OGBJCLBNMBK, LoadSceneMode PPHBIEDOJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8577740", Offset = "0x8576B40", VA = "0x188577740")]
	public static bool EBOLLMLNDGK([Out] string LEKMCMCONLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class AIFMEPHJDGO
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8571360", Offset = "0x8570760", VA = "0x188571360")]
	public static IDisposable FPFCKNLEMOK(this OIIOMECAMMK FAJBNOJIOHK, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x85713F0", Offset = "0x85707F0", VA = "0x1885713F0")]
	public static IDisposable PADJKKGMILG(this OIIOMECAMMK FAJBNOJIOHK, Action<float> BNPJNECAHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x85712E0", Offset = "0x85706E0", VA = "0x1885712E0")]
	public static IDisposable DICAIGPLOFG(this OIIOMECAMMK FAJBNOJIOHK, Action<float> BNPJNECAHOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class NAMMOKIDNPP
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x38548D0", Offset = "0x3853CD0", VA = "0x1838548D0")]
	[CEMIHDOEIAC]
	public static IDisposable BGFCLKFBGAM<T>(this T MIBGLNBAKNB, Action BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3854720", Offset = "0x3853B20", VA = "0x183854720")]
	[CEMIHDOEIAC]
	public static IDisposable BGFCLKFBGAM<T>(this T MIBGLNBAKNB, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3854C90", Offset = "0x3854090", VA = "0x183854C90")]
	[CEMIHDOEIAC]
	public static IDisposable LFKOACHICEI<T>(this T MIBGLNBAKNB, Action BNPJNECAHOM, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3854520", Offset = "0x3853920", VA = "0x183854520")]
	[CEMIHDOEIAC]
	public static IDisposable AJHEEEGKJLP<T>(this T MIBGLNBAKNB, Action BNPJNECAHOM, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3854520", Offset = "0x3853920", VA = "0x183854520")]
	[CEMIHDOEIAC]
	public static IDisposable AJHEEEGKJLP<T>(this T MIBGLNBAKNB, Action<float> BNPJNECAHOM, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3854B40", Offset = "0x3853F40", VA = "0x183854B40")]
	[CEMIHDOEIAC]
	public static IDisposable ICAGEBGFFHD<T>(this T MIBGLNBAKNB, Action BNPJNECAHOM, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3854E80", Offset = "0x3854280", VA = "0x183854E80")]
	[CEMIHDOEIAC]
	public static IDisposable ONELGAKALED<T>(this T MIBGLNBAKNB, Action BNPJNECAHOM, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3854B90", Offset = "0x3853F90", VA = "0x183854B90")]
	[CEMIHDOEIAC]
	public static IDisposable IFJJIDENPIE<T>(this T MIBGLNBAKNB, Action BNPJNECAHOM, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3854D80", Offset = "0x3854180", VA = "0x183854D80")]
	[CEMIHDOEIAC]
	public static IDisposable NNGGJBHFFGG<T>(this T MIBGLNBAKNB, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x858A4C0", Offset = "0x85898C0", VA = "0x18858A4C0")]
	[CEMIHDOEIAC]
	public static IDisposable NNGGJBHFFGG(this MonoBehaviour MIBGLNBAKNB, AHODEOBLEAO FAJBNOJIOHK, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3854570", Offset = "0x3853970", VA = "0x183854570")]
	[CEMIHDOEIAC]
	public static IDisposable BDHEJMJAALP<T>(this T MIBGLNBAKNB, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3854C40", Offset = "0x3854040", VA = "0x183854C40")]
	[CEMIHDOEIAC]
	public static IDisposable LAELLDNGFCE<T>(this T MIBGLNBAKNB, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3854BE0", Offset = "0x3853FE0", VA = "0x183854BE0")]
	[CEMIHDOEIAC]
	public static IDisposable KLKCFEOHOPI<T>(this T MIBGLNBAKNB, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3854E20", Offset = "0x3854220", VA = "0x183854E20")]
	[CEMIHDOEIAC]
	public static IDisposable OKIIFOGLOKJ<T>(this T MIBGLNBAKNB, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x38544C0", Offset = "0x38538C0", VA = "0x1838544C0")]
	[CEMIHDOEIAC]
	public static IDisposable AGNAPKNCMGA<T>(this T MIBGLNBAKNB, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3854AE0", Offset = "0x3853EE0", VA = "0x183854AE0")]
	[CEMIHDOEIAC]
	public static IDisposable FHFHPBFIDJC<T>(this T MIBGLNBAKNB, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3854ED0", Offset = "0x38542D0", VA = "0x183854ED0")]
	[CEMIHDOEIAC]
	public static IDisposable PKHANFGJDKN<T>(this T MIBGLNBAKNB, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3854DC0", Offset = "0x38541C0", VA = "0x183854DC0")]
	[CEMIHDOEIAC]
	public static IDisposable ODLJINPJGBA<T>(this T MIBGLNBAKNB, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3854F30", Offset = "0x3854330", VA = "0x183854F30")]
	[CEMIHDOEIAC]
	public static IDisposable PPHFJCHKPEF<T>(this T MIBGLNBAKNB, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3854D30", Offset = "0x3854130", VA = "0x183854D30")]
	[CEMIHDOEIAC]
	public static IDisposable NJFABPJPHAP<T>(this T MIBGLNBAKNB, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3854A80", Offset = "0x3853E80", VA = "0x183854A80")]
	[CEMIHDOEIAC]
	public static IDisposable EGJNBIODFCL<T>(this T MIBGLNBAKNB, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3854CD0", Offset = "0x38540D0", VA = "0x183854CD0")]
	[CEMIHDOEIAC]
	public static IDisposable LJPNAHHBJPH<T>(this T MIBGLNBAKNB, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true) where T : MonoBehaviour, AHODEOBLEAO
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GOHHPHKBGIH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class CCGALFNGLLF : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public BOENLDMMBCG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private DPAJGEDJIOJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public CCGALFNGLLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8575180", Offset = "0x8574580", VA = "0x188575180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8575260", Offset = "0x8574660", VA = "0x188575260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class ABOJIAOBMLL : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public BOENLDMMBCG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private DPAJGEDJIOJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public ABOJIAOBMLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8570890", Offset = "0x856FC90", VA = "0x188570890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8570980", Offset = "0x856FD80", VA = "0x188570980", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8580C50", Offset = "0x8580050", VA = "0x188580C50")]
	public static DGHHBAELICH BGFCLKFBGAM(Action BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8580CD0", Offset = "0x85800D0", VA = "0x188580CD0")]
	public static DGHHBAELICH BGFCLKFBGAM(Behaviour FAJBNOJIOHK, Action BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8580B70", Offset = "0x857FF70", VA = "0x188580B70")]
	public static DGHHBAELICH BGFCLKFBGAM(Behaviour FAJBNOJIOHK, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8580DF0", Offset = "0x85801F0", VA = "0x188580DF0")]
	[IteratorStateMachine(typeof(CCGALFNGLLF))]
	private static IEnumerator<LCENDOCODMB> MGHDLGBICGM(BOENLDMMBCG LGKOBMEJHMC, Action BNPJNECAHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8580D60", Offset = "0x8580160", VA = "0x188580D60")]
	[IteratorStateMachine(typeof(ABOJIAOBMLL))]
	private static IEnumerator<LCENDOCODMB> MGHDLGBICGM(BOENLDMMBCG LGKOBMEJHMC, Action<float> BNPJNECAHOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class EGOFKMOCFHI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class LKNKKFLHLPB : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public EGOFKMOCFHI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public LKNKKFLHLPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x85857E0", Offset = "0x8584BE0", VA = "0x1885857E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8585870", Offset = "0x8584C70", VA = "0x188585870", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly BOENLDMMBCG KPOOLAHIIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action JPJHDDNCIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool IEGFDNNPEBH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LMGILDLJIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9C91C0", Offset = "0x9C85C0", VA = "0x1809C91C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x857ED70", Offset = "0x857E170", VA = "0x18857ED70")]
	public EGOFKMOCFHI(BOENLDMMBCG KPOOLAHIIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x857EC50", Offset = "0x857E050", VA = "0x18857EC50")]
	[IteratorStateMachine(typeof(LKNKKFLHLPB))]
	private IEnumerator<LCENDOCODMB> DMLOGNLDPAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x857ECD0", Offset = "0x857E0D0", VA = "0x18857ECD0", Slot = "4")]
	public void OnCompleted(Action JMEDLEBNABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	public void JNLIAAFNHJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class JMLFHOBDGED
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8584D20", Offset = "0x8584120", VA = "0x188584D20")]
	public static EGOFKMOCFHI OIMEOLNNAHI(this BOENLDMMBCG KPOOLAHIIAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class EPEHJMIEJAC
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class EOBFKCNMBMC : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public DHFLNMODDIE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public EOBFKCNMBMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x857F9D0", Offset = "0x857EDD0", VA = "0x18857F9D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x857FA50", Offset = "0x857EE50", VA = "0x18857FA50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x857FAA0", Offset = "0x857EEA0", VA = "0x18857FAA0")]
	public static DGHHBAELICH BGFCLKFBGAM(float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, bool EAEHGHLBPII = true, [Optional] CKDLLADNMDG AHLCPEBAKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x857FB70", Offset = "0x857EF70", VA = "0x18857FB70")]
	public static DGHHBAELICH BGFCLKFBGAM(MonoBehaviour MIBGLNBAKNB, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, bool EAEHGHLBPII = true, [Optional] CKDLLADNMDG AHLCPEBAKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x857FEC0", Offset = "0x857F2C0", VA = "0x18857FEC0")]
	public static DGHHBAELICH PHIGCFPJGMG(MonoBehaviour MIBGLNBAKNB, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, bool EAEHGHLBPII = true, [Optional] CKDLLADNMDG AHLCPEBAKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x857FCD0", Offset = "0x857F0D0", VA = "0x18857FCD0")]
	public static DGHHBAELICH MCMBBFBDJKI(OIIOMECAMMK FAJBNOJIOHK, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, bool EAEHGHLBPII = true, [Optional] CKDLLADNMDG AHLCPEBAKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x857FDA0", Offset = "0x857F1A0", VA = "0x18857FDA0")]
	private static IEnumerator<LCENDOCODMB> MGHDLGBICGM(JPFDNMDPECD EBJGKJEJAPJ, float PJPOBDJJJIJ, BOENLDMMBCG LGKOBMEJHMC, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x857FE60", Offset = "0x857F260", VA = "0x18857FE60")]
	private static IEnumerator<LCENDOCODMB> NCACCPBNBDA(JPFDNMDPECD EBJGKJEJAPJ, float PJPOBDJJJIJ, BOENLDMMBCG LGKOBMEJHMC, Action<float> BNPJNECAHOM, bool EAEHGHLBPII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x857FC40", Offset = "0x857F040", VA = "0x18857FC40")]
	[IteratorStateMachine(typeof(EOBFKCNMBMC))]
	private static IEnumerator<LCENDOCODMB> HPLHNFBCHDI(DHFLNMODDIE FMMDIIADDNJ, float PJPOBDJJJIJ, BOENLDMMBCG LGKOBMEJHMC, Action<float> BNPJNECAHOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class IJIFNHPEFAL
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class CLOGBJJAPBB : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public BOENLDMMBCG queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public CLOGBJJAPBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85769D0", Offset = "0x8575DD0", VA = "0x1885769D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8576A90", Offset = "0x8575E90", VA = "0x188576A90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8584870", Offset = "0x8583C70", VA = "0x188584870")]
	[IteratorStateMachine(typeof(CLOGBJJAPBB))]
	private static IEnumerator<LCENDOCODMB> BKGDJPOKMFD(BOENLDMMBCG KPOOLAHIIAO, Func<bool> PJIKMBJAEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8584790", Offset = "0x8583B90", VA = "0x188584790")]
	public static DGHHBAELICH AKKJJIJAPED(this MonoBehaviour MIBGLNBAKNB, Func<bool> PJIKMBJAEFO, BOENLDMMBCG KPOOLAHIIAO = BOENLDMMBCG.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class DNBLHIPFGCJ
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class CHJKDONMEFE : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public BOENLDMMBCG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public CHJKDONMEFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8575700", Offset = "0x8574B00", VA = "0x188575700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8575770", Offset = "0x8574B70", VA = "0x188575770", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class DAEHIAMOGFO<T> : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public BOENLDMMBCG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public DAEHIAMOGFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x684BDA0", Offset = "0x684B1A0", VA = "0x18684BDA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x684BE40", Offset = "0x684B240", VA = "0x18684BE40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class MBCCMPCHPKK : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public BOENLDMMBCG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private LCENDOCODMB <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public MBCCMPCHPKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8585950", Offset = "0x8584D50", VA = "0x188585950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x85859E0", Offset = "0x8584DE0", VA = "0x1885859E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x857E260", Offset = "0x857D660", VA = "0x18857E260")]
	[IteratorStateMachine(typeof(CHJKDONMEFE))]
	private static IEnumerator<LCENDOCODMB> DMLOGNLDPAC(float FGNAOOMAGFL, BOENLDMMBCG LGKOBMEJHMC, Action JMBBGOMJFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x350B780", Offset = "0x350AB80", VA = "0x18350B780")]
	[IteratorStateMachine(typeof(DAEHIAMOGFO<>))]
	private static IEnumerator<LCENDOCODMB> DMLOGNLDPAC<T>(float FGNAOOMAGFL, BOENLDMMBCG LGKOBMEJHMC, Action<T> JMBBGOMJFAG, T LICDMCPJILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x857E4E0", Offset = "0x857D8E0", VA = "0x18857E4E0")]
	[IteratorStateMachine(typeof(MBCCMPCHPKK))]
	private static IEnumerator<LCENDOCODMB> HFHHFOFIHEC(float FGNAOOMAGFL, BOENLDMMBCG LGKOBMEJHMC, Action JMBBGOMJFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x857E610", Offset = "0x857DA10", VA = "0x18857E610")]
	public static IDisposable HPNKNKMIJNI(this MonoBehaviour MIBGLNBAKNB, float FGNAOOMAGFL, Action JMBBGOMJFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x857E920", Offset = "0x857DD20", VA = "0x18857E920")]
	public static DGHHBAELICH LMMKLDGEBBF(this MonoBehaviour MIBGLNBAKNB, float FGNAOOMAGFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x857E6F0", Offset = "0x857DAF0", VA = "0x18857E6F0")]
	public static DGHHBAELICH HPNKNKMIJNI(this MonoBehaviour MIBGLNBAKNB, float FGNAOOMAGFL, BOENLDMMBCG LGKOBMEJHMC, Action JMBBGOMJFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x857E440", Offset = "0x857D840", VA = "0x18857E440")]
	public static DGHHBAELICH GCNICCIDBCA(this MonoBehaviour MIBGLNBAKNB, Action JMBBGOMJFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x350B860", Offset = "0x350AC60", VA = "0x18350B860")]
	public static DGHHBAELICH GCNICCIDBCA<T>(this MonoBehaviour MIBGLNBAKNB, Action<T> JMBBGOMJFAG, T LICDMCPJILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x857E080", Offset = "0x857D480", VA = "0x18857E080")]
	public static DGHHBAELICH BBJHKCPOJOL(this MonoBehaviour MIBGLNBAKNB, Action JMBBGOMJFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x857E3A0", Offset = "0x857D7A0", VA = "0x18857E3A0")]
	public static DGHHBAELICH EOJIJKHNFBH(this MonoBehaviour MIBGLNBAKNB, Action JMBBGOMJFAG, [Optional] CKDLLADNMDG AHLCPEBAKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x857E120", Offset = "0x857D520", VA = "0x18857E120")]
	public static DGHHBAELICH BHEDELAKEJH(this MonoBehaviour MIBGLNBAKNB, Action JMBBGOMJFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x857E880", Offset = "0x857DC80", VA = "0x18857E880")]
	public static DGHHBAELICH KPFPNKCFHKO(this MonoBehaviour MIBGLNBAKNB, Action JMBBGOMJFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x857E1C0", Offset = "0x857D5C0", VA = "0x18857E1C0")]
	public static DGHHBAELICH DAHLLIHEHNB(MonoBehaviour MIBGLNBAKNB, BOENLDMMBCG KPOOLAHIIAO, Action JMBBGOMJFAG, [Optional] CKDLLADNMDG AHLCPEBAKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x350B640", Offset = "0x350AA40", VA = "0x18350B640")]
	public static DGHHBAELICH DAHLLIHEHNB<T>(MonoBehaviour MIBGLNBAKNB, BOENLDMMBCG KPOOLAHIIAO, Action<T> JMBBGOMJFAG, T LICDMCPJILC, [Optional] CKDLLADNMDG AHLCPEBAKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x857E580", Offset = "0x857D980", VA = "0x18857E580")]
	public static DGHHBAELICH HLADCEHJAEK(this MonoBehaviour MIBGLNBAKNB, float LADFIPIENMC, Action JMBBGOMJFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x857E7E0", Offset = "0x857DBE0", VA = "0x18857E7E0")]
	public static DGHHBAELICH JFCCLDJILJJ(this MonoBehaviour MIBGLNBAKNB, float LADFIPIENMC, Action JMBBGOMJFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x857E300", Offset = "0x857D700", VA = "0x18857E300")]
	public static DGHHBAELICH DNHCHANFFPK(this MonoBehaviour MIBGLNBAKNB, float LADFIPIENMC, Action JMBBGOMJFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x857E9B0", Offset = "0x857DDB0", VA = "0x18857E9B0")]
	public static DGHHBAELICH PJBBOLHEFPN(this MonoBehaviour MIBGLNBAKNB, float LADFIPIENMC, Action JMBBGOMJFAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class APONCFPABFM : NKJJPPKIFKO, IEnumerable<NKJJPPKIFKO>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<NKJJPPKIFKO> FLEKFOOPHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool LNGKGHNMDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action AEBGCIGABMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool HNKCPBEDFDD;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OOBIEBENIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8571C60", Offset = "0x8571060", VA = "0x188571C60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AFFKAAHKLNH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8571DA0", Offset = "0x85711A0", VA = "0x188571DA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x85716F0", Offset = "0x8570AF0", VA = "0x1885716F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8571FA0", Offset = "0x85713A0", VA = "0x188571FA0")]
	public APONCFPABFM([Optional] Action AEBGCIGABMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8571AB0", Offset = "0x8570EB0", VA = "0x188571AB0")]
	public void FGAAHPGCDNG(NKJJPPKIFKO EDHDGKPCPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8571E40", Offset = "0x8571240", VA = "0x188571E40")]
	private void NFKLJKJHNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8571AA0", Offset = "0x8570EA0", VA = "0x188571AA0", Slot = "7")]
	public bool EMJCOIBINAP(bool IMJBLFBLNHJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8571790", Offset = "0x8570B90", VA = "0x188571790", Slot = "8")]
	public bool EMJCOIBINAP(Action PDHMHKIHKPF, bool IMJBLFBLNHJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8571BE0", Offset = "0x8570FE0", VA = "0x188571BE0", Slot = "9")]
	public IEnumerator<NKJJPPKIFKO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8571BE0", Offset = "0x8570FE0", VA = "0x188571BE0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class DMDEIHDNIPI : MIJCACDAIGL
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class LEGHFPFHGOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public DMDEIHDNIPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public LEGHFPFHGOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x85857B0", Offset = "0x8584BB0", VA = "0x1885857B0")]
		internal void IHMDDPKKEFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class PFLMMIOPNBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public DMDEIHDNIPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PFLMMIOPNBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x85857B0", Offset = "0x8584BB0", VA = "0x1885857B0")]
		internal void OEGKKHGOGOD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float EAPJFBAKMDM;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x857DF40", Offset = "0x857D340", VA = "0x18857DF40")]
	public DMDEIHDNIPI(Behaviour FAJBNOJIOHK, float EAPJFBAKMDM, [Optional] Action AEBGCIGABMF, [Optional] CKDLLADNMDG AHLCPEBAKID, [Optional] JPFDNMDPECD EBJGKJEJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x857DD20", Offset = "0x857D120", VA = "0x18857DD20", Slot = "9")]
	protected override bool BACBHKJLHCL(Action PDHMHKIHKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x857DE30", Offset = "0x857D230", VA = "0x18857DE30", Slot = "10")]
	protected override bool OAKLFGMOFCA(Action PDHMHKIHKPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface NKJJPPKIFKO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OOBIEBENIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action AFFKAAHKLNH;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EMJCOIBINAP(bool IMJBLFBLNHJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EMJCOIBINAP(Action PDHMHKIHKPF, bool IMJBLFBLNHJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class MIJCACDAIGL : NKJJPPKIFKO
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class OAEOLKMHEKE : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public MIJCACDAIGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public OAEOLKMHEKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x858BC10", Offset = "0x858B010", VA = "0x18858BC10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x858BCE0", Offset = "0x858B0E0", VA = "0x18858BCE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour FAJBNOJIOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action AEBGCIGABMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private ALPDPKEGNFF IMJJKLFGIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly CKDLLADNMDG AHLCPEBAKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly JPFDNMDPECD EBJGKJEJAPJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool OOBIEBENIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x198F140", Offset = "0x198E540", VA = "0x18198F140", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AFFKAAHKLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8588F30", Offset = "0x8588330", VA = "0x188588F30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8588AA0", Offset = "0x8587EA0", VA = "0x188588AA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8589060", Offset = "0x8588460", VA = "0x188589060")]
	protected MIJCACDAIGL(Behaviour FAJBNOJIOHK, [Optional] Action AEBGCIGABMF, [Optional] CKDLLADNMDG AHLCPEBAKID, [Optional] JPFDNMDPECD EBJGKJEJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8588DD0", Offset = "0x85881D0", VA = "0x188588DD0", Slot = "7")]
	public bool EMJCOIBINAP(bool IMJBLFBLNHJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8588E30", Offset = "0x8588230", VA = "0x188588E30", Slot = "8")]
	public bool EMJCOIBINAP(Action PDHMHKIHKPF, bool IMJBLFBLNHJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool BACBHKJLHCL(Action PDHMHKIHKPF);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool OAKLFGMOFCA(Action PDHMHKIHKPF);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8588E90", Offset = "0x8588290", VA = "0x188588E90")]
	protected void IPFLPNMNIGG(Action PDHMHKIHKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8588B80", Offset = "0x8587F80", VA = "0x188588B80")]
	protected DKABIBJEBOC EKIGNJDKJLO(float JGFPKIBNFLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8588EB0", Offset = "0x85882B0", VA = "0x188588EB0")]
	private void KKJNEDLHLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8588FD0", Offset = "0x85883D0", VA = "0x188588FD0")]
	[IteratorStateMachine(typeof(OAEOLKMHEKE))]
	private IEnumerator<LCENDOCODMB> PHCJNDCDAAM(float JGFPKIBNFLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8588B40", Offset = "0x8587F40", VA = "0x188588B40")]
	[CompilerGenerated]
	private void AONCFIGELPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class CHHAADKGOIF : MIJCACDAIGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float BMDOGBPNJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int POIFJCPMHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float BHBPLFOGDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] NFPFPLIAAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int EPIEFKMEAFH;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8575530", Offset = "0x8574930", VA = "0x188575530")]
	public CHHAADKGOIF(Behaviour FAJBNOJIOHK, float PGFOMGMHHJH, int POIFJCPMHHP, [Optional] Action AEBGCIGABMF, float BHBPLFOGDJL = 0f, [Optional] CKDLLADNMDG AHLCPEBAKID, [Optional] JPFDNMDPECD EBJGKJEJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "9")]
	protected override bool BACBHKJLHCL(Action PDHMHKIHKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8575330", Offset = "0x8574730", VA = "0x188575330", Slot = "10")]
	protected override bool OAKLFGMOFCA(Action PDHMHKIHKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x85752B0", Offset = "0x85746B0", VA = "0x1885752B0")]
	private void KELNOLLJJAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GJENJPFPJLJ : MIJCACDAIGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float EAPJFBAKMDM;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x857DF40", Offset = "0x857D340", VA = "0x18857DF40")]
	public GJENJPFPJLJ(Behaviour FAJBNOJIOHK, float EAPJFBAKMDM, [Optional] Action AEBGCIGABMF, [Optional] CKDLLADNMDG AHLCPEBAKID, [Optional] JPFDNMDPECD EBJGKJEJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "9")]
	protected override bool BACBHKJLHCL(Action PDHMHKIHKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8580100", Offset = "0x857F500", VA = "0x188580100", Slot = "10")]
	protected override bool OAKLFGMOFCA(Action PDHMHKIHKPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class DEGMDEIMGEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GNENCFIDNML : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public GNENCFIDNML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x857FFB0", Offset = "0x857F3B0", VA = "0x18857FFB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8580270", Offset = "0x857F670", VA = "0x188580270", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private DGHHBAELICH HGOJMHAIDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private OIIOMECAMMK FAJBNOJIOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> MKMDFBOKMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private BOENLDMMBCG KPOOLAHIIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float JJOLJLHDKKJ;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x857D580", Offset = "0x857C980", VA = "0x18857D580")]
	public DEGMDEIMGEF(OIIOMECAMMK FAJBNOJIOHK, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x857D290", Offset = "0x857C690", VA = "0x18857D290")]
	private void LJGIECPEIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x857D160", Offset = "0x857C560", VA = "0x18857D160")]
	private void IFGJBLHNKED(string MHFONFLBJOA, Action GKDEKANBFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x857D080", Offset = "0x857C480", VA = "0x18857D080")]
	[IteratorStateMachine(typeof(GNENCFIDNML))]
	private IEnumerator<LCENDOCODMB> BOCBILLDPCC(Action GKDEKANBFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x857D100", Offset = "0x857C500", VA = "0x18857D100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x857D400", Offset = "0x857C800", VA = "0x18857D400")]
	[CompilerGenerated]
	private void OEAAMFBHFJG(string OHPACGAIPAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class NONMDHHKDBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class FAGDMBBCIFH : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public FAGDMBBCIFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x857FFB0", Offset = "0x857F3B0", VA = "0x18857FFB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8580020", Offset = "0x857F420", VA = "0x188580020", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private DGHHBAELICH HGOJMHAIDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour MIBGLNBAKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action BNPJNECAHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> MKMDFBOKMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private BOENLDMMBCG KPOOLAHIIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float JJOLJLHDKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool EAEHGHLBPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly CKDLLADNMDG AHLCPEBAKID;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x858B8A0", Offset = "0x858ACA0", VA = "0x18858B8A0")]
	public NONMDHHKDBC(MonoBehaviour MIBGLNBAKNB, Action BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, [Optional] CKDLLADNMDG AHLCPEBAKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x858B6D0", Offset = "0x858AAD0", VA = "0x18858B6D0")]
	public NONMDHHKDBC(MonoBehaviour MIBGLNBAKNB, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, [Optional] CKDLLADNMDG AHLCPEBAKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x858BA30", Offset = "0x858AE30", VA = "0x18858BA30")]
	public NONMDHHKDBC(MonoBehaviour MIBGLNBAKNB, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, bool EAEHGHLBPII = true, [Optional] CKDLLADNMDG AHLCPEBAKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x499DFF0", Offset = "0x499D3F0", VA = "0x18499DFF0")]
	private NONMDHHKDBC(CKDLLADNMDG AHLCPEBAKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x858AAA0", Offset = "0x8589EA0", VA = "0x18858AAA0")]
	internal static NONMDHHKDBC ABLBNFNNLNB(MonoBehaviour MIBGLNBAKNB, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, BOENLDMMBCG KPOOLAHIIAO, bool EAEHGHLBPII = true, [Optional] CKDLLADNMDG AHLCPEBAKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x858AD60", Offset = "0x858A160", VA = "0x18858AD60")]
	private void BGFCLKFBGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x858AF70", Offset = "0x858A370", VA = "0x18858AF70")]
	private void GCLICLFDMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x858B2B0", Offset = "0x858A6B0", VA = "0x18858B2B0")]
	private void LJGIECPEIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x858B4B0", Offset = "0x858A8B0", VA = "0x18858B4B0")]
	private void NKNDJEBOAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x858B0F0", Offset = "0x858A4F0", VA = "0x18858B0F0")]
	private void IFGJBLHNKED(string MHFONFLBJOA, Action GKDEKANBFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x858AE90", Offset = "0x858A290", VA = "0x18858AE90")]
	[IteratorStateMachine(typeof(FAGDMBBCIFH))]
	private IEnumerator<LCENDOCODMB> BOCBILLDPCC(Action GKDEKANBFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x858AF10", Offset = "0x858A310", VA = "0x18858AF10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x858B640", Offset = "0x858AA40", VA = "0x18858B640")]
	[CompilerGenerated]
	private void OJEDIHFPBIG(string OHPACGAIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x858B220", Offset = "0x858A620", VA = "0x18858B220")]
	[CompilerGenerated]
	private void KPCAGFONHCE(string OHPACGAIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x858B420", Offset = "0x858A820", VA = "0x18858B420")]
	[CompilerGenerated]
	private void NEHMCFMEBLK(string OHPACGAIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x858ACD0", Offset = "0x858A0D0", VA = "0x18858ACD0")]
	[CompilerGenerated]
	private void APGIKIHHEAN(string OHPACGAIPAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum MHIGLFKPGCK : byte
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
internal sealed class AILCHKBOLDM : JPFDNMDPECD
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float GDMKJMNANGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8571490", Offset = "0x8570890", VA = "0x188571490", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float PHMCKNCDADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8571510", Offset = "0x8570910", VA = "0x188571510", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double NOIMMOHKIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8571470", Offset = "0x8570870", VA = "0x188571470", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x85714A0", Offset = "0x85708A0", VA = "0x1885714A0")]
	[ACPGCKDGGJH.EHOIKNIBKMA]
	internal static void OFPJHOBLCJH(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	[UnityEngine.Scripting.Preserve]
	internal AILCHKBOLDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface APHKKIKMNDE
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCNJEDCBJNF(string KCCMEIDBNGP);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGIPLBBMAPH();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface EOKGHPHFNPF
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool CAKAJLHCMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool LIGHCIEMCEP
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class AEKOCMJHDDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public BPNBPACKNAD MPLCFJFGACN;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int PINFDPDNIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8570F50", Offset = "0x8570350", VA = "0x188570F50")]
	public static LCENDOCODMB FGMPFLILNOO(IEnumerator<LCENDOCODMB> EIAOKHEMDMC, KPFDCCPLOBB HAJMEDKAPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x85710B0", Offset = "0x85704B0", VA = "0x1885710B0")]
	public LCENDOCODMB FGMPFLILNOO(KPFDCCPLOBB[] IIJAENHOIGE, IEnumerator<LCENDOCODMB>[] COPLEHOMKDP, LCENDOCODMB[] JCKENNOJDEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8571170", Offset = "0x8570570", VA = "0x188571170")]
	public void MICBHJFDPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x8570E10", Offset = "0x8570210", VA = "0x188570E10")]
	public void BLFIHDDAHFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x85711A0", Offset = "0x85705A0", VA = "0x1885711A0")]
	public void PKMJLCOADOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8571170", Offset = "0x8570570", VA = "0x188571170")]
	public void KOCPBONGJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public AEKOCMJHDDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class BPNBPACKNAD
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct INKHHDNHPDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public AEKOCMJHDDB LGAMHOMGDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public OIIOMECAMMK KJPFGEODIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public KPFDCCPLOBB PIIEMNHBONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<LCENDOCODMB> CEKINBHPKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public LCENDOCODMB CNAHAHGNGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public MHIGLFKPGCK ONJMAIGKGNF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct ONLPFPCEIMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public BOENLDMMBCG GALCOAOGPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<INKHHDNHPDJ> IOCEILNDPHN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class OJHKIEHFIKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public KPFDCCPLOBB promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public BPNBPACKNAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public OIIOMECAMMK context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AEKOCMJHDDB routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public MHIGLFKPGCK coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public LCENDOCODMB currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<LCENDOCODMB> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OJHKIEHFIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x858BDB0", Offset = "0x858B1B0", VA = "0x18858BDB0")]
		internal void GFDOBFFANFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class BEGFGOECJCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AEKOCMJHDDB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public BPNBPACKNAD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BEGFGOECJCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8572040", Offset = "0x8571440", VA = "0x188572040")]
		internal void GAKOPPFOPHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class MIMOIIFGIJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AEKOCMJHDDB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public BPNBPACKNAD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public MIMOIIFGIJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8589190", Offset = "0x8588590", VA = "0x188589190")]
		internal void FKHCPAJOHAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class CHNAJABIHII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AEKOCMJHDDB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public BPNBPACKNAD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public CHNAJABIHII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x85757C0", Offset = "0x8574BC0", VA = "0x1885757C0")]
		internal void DCDCJKCGNFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const MHIGLFKPGCK AFCDFFNFNBL = MHIGLFKPGCK.Cancelled | MHIGLFKPGCK.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly BOENLDMMBCG KPOOLAHIIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] NOIEELGPHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<MHIGLFKPGCK> LCEDBAAKBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> HJLGJJBKHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> DFJPHBBLBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> GNBJNCOIKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> KFNMNAGHFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> LMDCKPNOCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> IFMBAMNEEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private AEKOCMJHDDB[] GGJGDAPJECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private KPFDCCPLOBB[] IIJAENHOIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private OIIOMECAMMK[] MDGMIHJLJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<LCENDOCODMB>[] EGGBPLHMJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private LCENDOCODMB[] CMNHMOADEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int HHDPIOICIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int NPKCINNDJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int LFOHOAHFJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float HLJINLGCGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private MLIGFELGJKH IKCKDMBAPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle BKDAEDALDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<AEKOCMJHDDB> NMGNIMEBPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool PODJPANBNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> OKABJENMELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> LCGGCHEKALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool DEOBMDFLEOO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ONLPFPCEIMO[] CCDGJIGBBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA744B0", Offset = "0xA738B0", VA = "0x180A744B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8574740", Offset = "0x8573B40", VA = "0x188574740")]
	private static int NLPGMDGCDEF(BOENLDMMBCG KPOOLAHIIAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8574B20", Offset = "0x8573F20", VA = "0x188574B20")]
	public BPNBPACKNAD(BOENLDMMBCG KPOOLAHIIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x85735F0", Offset = "0x85729F0", VA = "0x1885735F0")]
	private void GBKJOBFLFBC(int HMHFOCEEFHF, int JLGCIBOFIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8572E50", Offset = "0x8572250", VA = "0x188572E50")]
	public void CHEDIDICJCG(OIIOMECAMMK FAJBNOJIOHK, LCENDOCODMB AOJBGKJJPAL, IEnumerator<LCENDOCODMB> EIAOKHEMDMC, KPFDCCPLOBB HAJMEDKAPFL, [Optional] AEKOCMJHDDB PCHPOLPJBJH, MHIGLFKPGCK PFPCGJLBMLL = MHIGLFKPGCK.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x85737D0", Offset = "0x8572BD0", VA = "0x1885737D0")]
	public void KCPLFBOIHKG(IEnumerable<INKHHDNHPDJ> MELAOBFLAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8573050", Offset = "0x8572450", VA = "0x188573050")]
	private INKHHDNHPDJ EBPCEMDDBOL(int CFEMFDLFKCM)
	{
		return default(INKHHDNHPDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8572AE0", Offset = "0x8571EE0", VA = "0x188572AE0")]
	private void BNHCEENKLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3463910", Offset = "0x3462D10", VA = "0x183463910")]
	private static void IEPKEPACKDF<T>(int CFEMFDLFKCM, T[] LDNPFDKABMF, int LLBNOFGPNDN, [Optional] T NOPFJNHNJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3463960", Offset = "0x3462D60", VA = "0x183463960")]
	private static void IEPKEPACKDF<T>(int CFEMFDLFKCM, NativeArray<T> LDNPFDKABMF, int LLBNOFGPNDN, [Optional] T NOPFJNHNJOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8573B40", Offset = "0x8572F40", VA = "0x188573B40")]
	private void LBKEACCCPAE(IEnumerable<INKHHDNHPDJ> MELAOBFLAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8573520", Offset = "0x8572920", VA = "0x188573520")]
	private void FNADMBGBDEF(INKHHDNHPDJ KCJNDGFJJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8572880", Offset = "0x8571C80", VA = "0x188572880")]
	private ALDHFKHKBEN BMLKHLEKJID(int GMAJJNFGNBN)
	{
		return default(ALDHFKHKBEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x85747F0", Offset = "0x8573BF0", VA = "0x1885747F0")]
	public void PIHOFCIEKLK(float NFJHHAIAPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8572FD0", Offset = "0x85723D0", VA = "0x188572FD0")]
	private void CMHLDKJFAJA(Action EHIMHGHKFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8574770", Offset = "0x8573B70", VA = "0x188574770")]
	private void OJNKJPOJPOO(Action EHIMHGHKFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8573EF0", Offset = "0x85732F0", VA = "0x188573EF0")]
	public void MFKKBLBMADJ(float NFJHHAIAPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8572780", Offset = "0x8571B80", VA = "0x188572780")]
	public void BKMLDGFOOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8573A10", Offset = "0x8572E10", VA = "0x188573A10")]
	public void KOCPBONGJHC(AEKOCMJHDDB FMMDIIADDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8574610", Offset = "0x8573A10", VA = "0x188574610")]
	public void MNDHCDGCONK(AEKOCMJHDDB FMMDIIADDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x85749F0", Offset = "0x8573DF0", VA = "0x1885749F0")]
	public void POCILIFDJMI(AEKOCMJHDDB FMMDIIADDNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class NJMGCGPHMFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly NJMGCGPHMFP HGNIBOKIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action PNIEGCAPKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool FJEDLGBMFFE;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public NJMGCGPHMFP(Action PNIEGCAPKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FED0", Offset = "0x7C1F2D0", VA = "0x187C1FED0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface PBJOBPJKIGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable DCKPGKKFBCH(UnityEngine.Object FAJBNOJIOHK, Action<T> JBMEEEMGNAP);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface IBBLOKHOHCM<T> : PBJOBPJKIGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class ECAIILHENKF<T> : IBBLOKHOHCM<T>, PBJOBPJKIGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class ECCJNJOBDGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public ECAIILHENKF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public PAEJJKIMEGI<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public ECCJNJOBDGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x43810D0", Offset = "0x43804D0", VA = "0x1843810D0")]
		internal void CGCHPKCMJCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject HEIMPFODFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<PAEJJKIMEGI<UnityEngine.Object, Action<T>>> KCAPLDAPCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T CGKOBDGMCLE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA813E0", Offset = "0xA807E0", VA = "0x180A813E0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4380DD0", Offset = "0x43801D0", VA = "0x184380DD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4380D00", Offset = "0x4380100", VA = "0x184380D00")]
	private static bool IDLMLKHHBAC(T EHIMHGHKFCP, T MDCPFJBHOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4381010", Offset = "0x4380410", VA = "0x184381010")]
	public ECAIILHENKF(T DIMFLCEMKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x43802B0", Offset = "0x437F6B0", VA = "0x1843802B0", Slot = "6")]
	public IDisposable DCKPGKKFBCH(UnityEngine.Object FAJBNOJIOHK, Action<T> JBMEEEMGNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4380630", Offset = "0x437FA30", VA = "0x184380630")]
	private void EGLIECIHNGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class MICGIDFGOKF : PFKFDNGLEGI
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class CPDDAAMBFBK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class GHNFLOPMEDO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int FBLIJIPJKFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private CPDDAAMBFBK LGKOBMEJHMC;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xE8A820", Offset = "0xE89C20", VA = "0x180E8A820")]
			public GHNFLOPMEDO(int FBLIJIPJKFJ, CPDDAAMBFBK LGKOBMEJHMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x85800D0", Offset = "0x857F4D0", VA = "0x1885800D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class BHOJKDCKBEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public BHOJKDCKBEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xD7BDE0", Offset = "0xD7B1E0", VA = "0x180D7BDE0")]
			internal bool LICAGCGJMKM(GNPPOKFPDLF e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class DIJHMIAMNJJ : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private LCENDOCODMB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public CPDDAAMBFBK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public JPFDNMDPECD timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private DPAJGEDJIOJ <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<GNPPOKFPDLF> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
			[DebuggerHidden]
			public DIJHMIAMNJJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x857D9A0", Offset = "0x857CDA0", VA = "0x18857D9A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x857DCD0", Offset = "0x857D0D0", VA = "0x18857DCD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly BOENLDMMBCG KPOOLAHIIAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private DGHHBAELICH HAJMEDKAPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<GNPPOKFPDLF> ILHAEJGFKKK;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8578C70", Offset = "0x8578070", VA = "0x188578C70")]
		public CPDDAAMBFBK(BOENLDMMBCG KPOOLAHIIAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8578870", Offset = "0x8577C70", VA = "0x188578870")]
		public IDisposable CJBFLNEKLIP(GNPPOKFPDLF MOIBKBOPECF, CKDLLADNMDG AHLCPEBAKID, JPFDNMDPECD IHAAMEONBJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8578A50", Offset = "0x8577E50", VA = "0x188578A50")]
		private void IHCNEAOPDIP(int FBLIJIPJKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8578BE0", Offset = "0x8577FE0", VA = "0x188578BE0")]
		[IteratorStateMachine(typeof(DIJHMIAMNJJ))]
		private IEnumerator<LCENDOCODMB> MGHDLGBICGM(JPFDNMDPECD IHAAMEONBJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8578A00", Offset = "0x8577E00", VA = "0x188578A00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class GNPPOKFPDLF
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum GDINLBDCOGP : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int OMBNPBGGKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int NKGPMMKCOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly AHODEOBLEAO KJPFGEODIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour DNNKFEOGCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action LFKOACHICEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> CNAIOGEEHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float AAHNPLCOMDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float HJLGJJBKHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string LIPJOHOCCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool GHMNIBKEMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly GDINLBDCOGP BBFGEADEIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool DPDDAAIBAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool HPDLAFLBHNP;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x85809F0", Offset = "0x857FDF0", VA = "0x1885809F0")]
		public GNPPOKFPDLF(AHODEOBLEAO FAJBNOJIOHK, Action BNPJNECAHOM, bool IMNPAEPICKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8580870", Offset = "0x857FC70", VA = "0x188580870")]
		public GNPPOKFPDLF(AHODEOBLEAO FAJBNOJIOHK, Action<float> BNPJNECAHOM, bool IMNPAEPICKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8580690", Offset = "0x857FA90", VA = "0x188580690")]
		public GNPPOKFPDLF(AHODEOBLEAO FAJBNOJIOHK, float PJPOBDJJJIJ, Action<float> BNPJNECAHOM, JPFDNMDPECD IHAAMEONBJO, GDINLBDCOGP FKIIGJDOGLN, bool EAEHGHLBPII, bool IMNPAEPICKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x85804C0", Offset = "0x857F8C0", VA = "0x1885804C0")]
		public bool CAELGFHJHJC(float ILKAOEMIOFJ, float DPACGNFKBPH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly CKDLLADNMDG AHLCPEBAKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly JPFDNMDPECD EBJGKJEJAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<BOENLDMMBCG, CPDDAAMBFBK> MLBLAEBHCDJ;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8587CD0", Offset = "0x85870D0", VA = "0x188587CD0")]
	[ACPGCKDGGJH.EHOIKNIBKMA]
	internal static void AJGPINPPCKH(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8588660", Offset = "0x8587A60", VA = "0x188588660")]
	[UnityEngine.Scripting.Preserve]
	internal MICGIDFGOKF([MGCCDFKFGBG(null)] CKDLLADNMDG AHLCPEBAKID, [MGCCDFKFGBG(null)] JPFDNMDPECD EBJGKJEJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8588180", Offset = "0x8587580", VA = "0x188588180", Slot = "4")]
	public IDisposable LFKOACHICEI(AHODEOBLEAO FAJBNOJIOHK, Action IBDCICFCEPJ, BOENLDMMBCG KPOOLAHIIAO, bool IMNPAEPICKK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8588370", Offset = "0x8587770", VA = "0x188588370", Slot = "5")]
	public IDisposable LFKOACHICEI(AHODEOBLEAO FAJBNOJIOHK, Action<float> IBDCICFCEPJ, BOENLDMMBCG KPOOLAHIIAO, bool IMNPAEPICKK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x8587F00", Offset = "0x8587300", VA = "0x188587F00", Slot = "7")]
	public IDisposable LAELLDNGFCE(AHODEOBLEAO FAJBNOJIOHK, float PJPOBDJJJIJ, Action<float> IBDCICFCEPJ, BOENLDMMBCG KPOOLAHIIAO, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x8588560", Offset = "0x8587960", VA = "0x188588560", Slot = "8")]
	public IDisposable OPGGEFCCEAJ(AHODEOBLEAO FAJBNOJIOHK, float PJPOBDJJJIJ, Action<float> IBDCICFCEPJ, BOENLDMMBCG KPOOLAHIIAO, bool EAEHGHLBPII = true, bool IMNPAEPICKK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8588000", Offset = "0x8587400", VA = "0x188588000", Slot = "6")]
	public IDisposable LAELLDNGFCE(float PJPOBDJJJIJ, Action<float> IBDCICFCEPJ, bool EAEHGHLBPII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8587D40", Offset = "0x8587140", VA = "0x188587D40", Slot = "9")]
	public void ICMDEPLACPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8587B90", Offset = "0x8586F90", VA = "0x188587B90")]
	private CPDDAAMBFBK AGDNJGCLELN(BOENLDMMBCG KPOOLAHIIAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class MJDJELHBLHN : MFDMNHEGLJE, CKDLLADNMDG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private BPNBPACKNAD[] BJMDHIOAKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private APHKKIKMNDE FMBCBKJOHFC;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8589D40", Offset = "0x8589140", VA = "0x188589D40")]
	[ACPGCKDGGJH.EHOIKNIBKMA]
	internal static void OFPJHOBLCJH(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x8589DB0", Offset = "0x85891B0", VA = "0x188589DB0")]
	[UnityEngine.Scripting.Preserve]
	public MJDJELHBLHN([MGCCDFKFGBG(null)] CAEBGFNOAAC PEAMHBKGDBM, [MGCCDFKFGBG(null)] JPFDNMDPECD EBJGKJEJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x85899F0", Offset = "0x8588DF0", VA = "0x1885899F0", Slot = "19")]
	public override DGHHBAELICH JFNOCJPJOHM(OIIOMECAMMK FAJBNOJIOHK, IEnumerator<LCENDOCODMB> CILAPHNBKNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8589690", Offset = "0x8588A90", VA = "0x188589690", Slot = "20")]
	public override void ICMDEPLACPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x8589460", Offset = "0x8588860", VA = "0x188589460", Slot = "22")]
	public override void FIAEEHGJCAP(BOENLDMMBCG KPOOLAHIIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x8589B50", Offset = "0x8588F50", VA = "0x188589B50", Slot = "21")]
	protected override void LFKOACHICEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x8589B20", Offset = "0x8588F20", VA = "0x188589B20")]
	private BPNBPACKNAD KMMHCKOOBJP(BOENLDMMBCG KHNCICOHHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x85891D0", Offset = "0x85885D0", VA = "0x1885891D0", Slot = "23")]
	internal override CNBADPNKENE BKIBGACLCEC(IEnumerator<LCENDOCODMB> CILAPHNBKNF, Behaviour FAJBNOJIOHK, KPFDCCPLOBB HAJMEDKAPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8589930", Offset = "0x8588D30", VA = "0x188589930", Slot = "24")]
	internal override IEEHBDICNHM ILNCNKJKEJE(BOENLDMMBCG LGKOBMEJHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x8589C20", Offset = "0x8589020", VA = "0x188589C20")]
	private void MOEMFCFOCJN(BPNBPACKNAD EMIAMAHOCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x8589400", Offset = "0x8588800", VA = "0x188589400", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct MLIGFELGJKH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float HHILEINFHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int HFDMENBCNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> HPPJMLBEDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> JEOFIJFHOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> FDOEACNNDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<MHIGLFKPGCK> JBGFNHBMEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> IIGLGLCMLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> KFNMNAGHFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> DFJPHBBLBFO;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x858A030", Offset = "0x8589430", VA = "0x18858A030")]
	public static MLIGFELGJKH BPKMLDCMEGB(int KCDLOEHEOAD, float NFJHHAIAPEL, NativeArray<MHIGLFKPGCK> OIMOLONGLKK, NativeArray<float> JFMKHNBKPNP, NativeArray<int> OMOIIDMIFMI, NativeArray<int> GOMCJLLAPNL, NativeArray<int> HDICOFGBDPI, NativeArray<int> JEOFIJFHOKJ, NativeArray<int> FDOEACNNDEH)
	{
		return default(MLIGFELGJKH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x858A090", Offset = "0x8589490", VA = "0x18858A090", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x858A1A0", Offset = "0x85895A0", VA = "0x18858A1A0")]
	private bool JGOGAMJHINI(int COPLIEINKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x858A170", Offset = "0x8589570", VA = "0x18858A170")]
	private void FNMBMPMFLKB(NativeArray<int> CIFNBCBMCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x858A420", Offset = "0x8589820", VA = "0x18858A420")]
	private int ONPKEKPKLBG(int DFJFBPGKGOB, int AJIMMAKPHOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8589F60", Offset = "0x8589360", VA = "0x188589F60")]
	private void AJFFCBFKKIO(NativeArray<int> CIFNBCBMCKF, int BIMECLLBLMD, int DEBKLEONCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x858A1E0", Offset = "0x85895E0", VA = "0x18858A1E0")]
	private void OIKJEPNBJAJ(NativeArray<int> CIFNBCBMCKF, int DLLBPEOJNMK, int HNEDHPKBOMH, int MNNIOGCAIDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class MFDMNHEGLJE : CKDLLADNMDG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly CAEBGFNOAAC PEAMHBKGDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly JPFDNMDPECD EBJGKJEJAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private IEEHBDICNHM[] NLBIEKFBOFN;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static CKDLLADNMDG IADGMEFIGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x85874E0", Offset = "0x85868E0", VA = "0x1885874E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool PJBCMDOMBND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public BOENLDMMBCG PBBCCKLKBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BOENLDMMBCG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public JPFDNMDPECD KOGMPLEGCMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public LCENDOCODMB EKGIBEOEELG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public LCENDOCODMB IMAAIDPDNAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LCENDOCODMB BDFOCDPDHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9C9450", Offset = "0x9C8850", VA = "0x1809C9450", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LCENDOCODMB GODKPCKNJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9CD800", Offset = "0x9CCC00", VA = "0x1809CD800", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8587550", Offset = "0x8586950", VA = "0x188587550")]
	public static DGHHBAELICH KAKJLANPFFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x85876A0", Offset = "0x8586AA0", VA = "0x1885876A0")]
	[UnityEngine.Scripting.Preserve]
	protected MFDMNHEGLJE([MGCCDFKFGBG(null)] CAEBGFNOAAC PEAMHBKGDBM, [MGCCDFKFGBG(null)] JPFDNMDPECD EBJGKJEJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8587090", Offset = "0x8586490", VA = "0x188587090", Slot = "6")]
	public DGHHBAELICH ILOIMMFJAMD(IEnumerator<LCENDOCODMB> CILAPHNBKNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x85870A0", Offset = "0x85864A0", VA = "0x1885870A0", Slot = "7")]
	public DGHHBAELICH ILOIMMFJAMD(Behaviour FAJBNOJIOHK, IEnumerator<LCENDOCODMB> CILAPHNBKNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract DGHHBAELICH JFNOCJPJOHM(OIIOMECAMMK FAJBNOJIOHK, IEnumerator<LCENDOCODMB> CILAPHNBKNF);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8586D20", Offset = "0x8586120", VA = "0x188586D20", Slot = "20")]
	public virtual void ICMDEPLACPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x85872A0", Offset = "0x85866A0", VA = "0x1885872A0", Slot = "9")]
	public void IMBIKLEEMNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x8587600", Offset = "0x8586A00", VA = "0x188587600", Slot = "21")]
	protected virtual void LFKOACHICEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8587680", Offset = "0x8586A80", VA = "0x188587680")]
	private void OFEMBGBOBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8586BD0", Offset = "0x8585FD0", VA = "0x188586BD0")]
	private void EOLCCAOIDPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8586740", Offset = "0x8585B40", VA = "0x188586740")]
	private void AJHEEEGKJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8586D00", Offset = "0x8586100", VA = "0x188586D00")]
	private void ICAGEBGFFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8586CE0", Offset = "0x85860E0", VA = "0x188586CE0")]
	private void HANLOFMLJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x85875E0", Offset = "0x85869E0", VA = "0x1885875E0")]
	private void LEKOCBNFPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8586BB0", Offset = "0x8585FB0", VA = "0x188586BB0")]
	private void EMALEIMLDFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8586BF0", Offset = "0x8585FF0", VA = "0x188586BF0", Slot = "22")]
	public virtual void FIAEEHGJCAP(BOENLDMMBCG KPOOLAHIIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8586EC0", Offset = "0x85862C0", VA = "0x188586EC0")]
	private void IHENDAHKEOM(IEEHBDICNHM EMIAMAHOCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x25F7C90", Offset = "0x25F7090", VA = "0x1825F7C90")]
	private IEEHBDICNHM GKEMBJOEHFL(BOENLDMMBCG KHNCICOHHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract CNBADPNKENE BKIBGACLCEC(IEnumerator<LCENDOCODMB> CILAPHNBKNF, Behaviour MIBGLNBAKNB, KPFDCCPLOBB JOCOPBGLLJB);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract IEEHBDICNHM ILNCNKJKEJE(BOENLDMMBCG KPOOLAHIIAO);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x85867F0", Offset = "0x8585BF0", VA = "0x1885867F0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8587620", Offset = "0x8586A20", VA = "0x188587620", Slot = "15")]
	public LCENDOCODMB LMKIIAACDKA(BOENLDMMBCG LGKOBMEJHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8586760", Offset = "0x8585B60", VA = "0x188586760", Slot = "16")]
	public LCENDOCODMB BOHAFAMNDCN(float FGNAOOMAGFL, BOENLDMMBCG LGKOBMEJHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8586C80", Offset = "0x8586080", VA = "0x188586C80", Slot = "17")]
	public LCENDOCODMB FNPEKMKLEHA(Func<bool> PJIKMBJAEFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class CNBADPNKENE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly KPFDCCPLOBB HAJMEDKAPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly EOKGHPHFNPF FAJBNOJIOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool IDAEPIFKCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string KCCMEIDBNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace BLPJADFBJLK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<LCENDOCODMB> CEKINBHPKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LCENDOCODMB CNAHAHGNGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool KMEAMJCBCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8577070", Offset = "0x8576470", VA = "0x188577070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool LFKPPLDKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xBEB240", Offset = "0xBEA640", VA = "0x180BEB240")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xBF1640", Offset = "0xBF0A40", VA = "0x180BF1640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8576B50", Offset = "0x8575F50", VA = "0x188576B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float HEMABPKLIAG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xFD8540", Offset = "0xFD7940", VA = "0x180FD8540")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6EDCC60", Offset = "0x6EDC060", VA = "0x186EDCC60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x85771D0", Offset = "0x85765D0", VA = "0x1885771D0")]
	public CNBADPNKENE(IEnumerator<LCENDOCODMB> EIAOKHEMDMC, EOKGHPHFNPF FAJBNOJIOHK, KPFDCCPLOBB HAJMEDKAPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8576D00", Offset = "0x8576100", VA = "0x188576D00")]
	public LCENDOCODMB FGMPFLILNOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8576AE0", Offset = "0x8575EE0", VA = "0x188576AE0")]
	public bool BJCLCPPGCMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8577020", Offset = "0x8576420", VA = "0x188577020")]
	public void KOCPBONGJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x85770F0", Offset = "0x85764F0", VA = "0x1885770F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xC49170", Offset = "0xC48570", VA = "0x180C49170")]
	[CompilerGenerated]
	private void BEEDJDJAAMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class KPFDCCPLOBB : OLGGPKFFNDE, DGHHBAELICH, ALPDPKEGNFF, DKABIBJEBOC, IEnumerator, LCENDOCODMB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private BOENLDMMBCG GFABCPHIGOP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private BOENLDMMBCG AAMNOENAMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD34600", Offset = "0xD33A00", VA = "0x180D34600", Slot = "23")]
		get
		{
			return default(BOENLDMMBCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BOENLDMMBCG MPLCFJFGACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xECF780", Offset = "0xECEB80", VA = "0x180ECF780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float CNBLLHHEOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xB7A840", Offset = "0xB79C40", VA = "0x180B7A840", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PCOMEFAGNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8585540", Offset = "0x8584940", VA = "0x188585540", Slot = "24")]
	private bool NFNMIBKIMAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8585530", Offset = "0x8584930", VA = "0x188585530", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8585560", Offset = "0x8584960", VA = "0x188585560")]
	public KPFDCCPLOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum ALDHFKHKBEN : byte
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
internal sealed class IEEHBDICNHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum POMCAKNLIAG
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct NPGHNDCLLEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public BOENLDMMBCG GALCOAOGPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public POMCAKNLIAG BNOADKEDBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<CNBADPNKENE> OMLPAIIHHON;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly POMCAKNLIAG[] NAIPHDFMNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly BOENLDMMBCG KPOOLAHIIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool HIBENFENGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly CNBADPNKENE[] DNAOHFNOJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<CNBADPNKENE> MNJIONDAFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> NLLNJGDMDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<CNBADPNKENE> ALFIIOPBJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> LNGMPGLCMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly APHKKIKMNDE CILOAKDKLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool DEOBMDFLEOO;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NPGHNDCLLEM[,] HJELMGLDBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9C9450", Offset = "0x9C8850", VA = "0x1809C9450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x85840E0", Offset = "0x85834E0", VA = "0x1885840E0")]
	public IEEHBDICNHM(BOENLDMMBCG LGKOBMEJHMC, APHKKIKMNDE CILOAKDKLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8583870", Offset = "0x8582C70", VA = "0x188583870")]
	public void FBHMBKEPBEG(CNBADPNKENE EIAOKHEMDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8583440", Offset = "0x8582840", VA = "0x188583440")]
	public void DCHHFDKMMPI(IList<CNBADPNKENE> COPLEHOMKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8583130", Offset = "0x8582530", VA = "0x188583130")]
	public void BLLAHHINICD(IList<CNBADPNKENE> COPLEHOMKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8583040", Offset = "0x8582440", VA = "0x188583040")]
	private void BJNOIIHPLMI(CNBADPNKENE EIAOKHEMDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8582B50", Offset = "0x8581F50", VA = "0x188582B50")]
	private void AEAEJIOMHLP(IList<CNBADPNKENE> COPLEHOMKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8583CB0", Offset = "0x85830B0", VA = "0x188583CB0")]
	private ALDHFKHKBEN JCOLDJKJGLH(CNBADPNKENE EIAOKHEMDMC)
	{
		return default(ALDHFKHKBEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8583E30", Offset = "0x8583230", VA = "0x188583E30")]
	public void LFKOACHICEI(float NFJHHAIAPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8583AC0", Offset = "0x8582EC0", VA = "0x188583AC0")]
	public void IMBIKLEEMNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8582CE0", Offset = "0x85820E0", VA = "0x188582CE0")]
	private void AHHPFLBKCHE(List<CNBADPNKENE> COPLEHOMKDP, Stack<int> BLGBAGLNIEC, bool OBLBLBGBOHJ, float GPDIMGLDNCF = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8583750", Offset = "0x8582B50", VA = "0x188583750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8583980", Offset = "0x8582D80", VA = "0x188583980")]
	private void HAIBAAGKOAK(List<CNBADPNKENE> COPLEHOMKDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class DMJNMBAOJLN : APHKKIKMNDE
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
	public void PCNJEDCBJNF(string KCCMEIDBNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
	public void LGIPLBBMAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public DMJNMBAOJLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class MLCFEFEKDDP : EOKGHPHFNPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour MIBGLNBAKNB;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8589E90", Offset = "0x8589290", VA = "0x188589E90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CAKAJLHCMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8589F10", Offset = "0x8589310", VA = "0x188589F10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool LIGHCIEMCEP
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8589E70", Offset = "0x8589270", VA = "0x188589E70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public MLCFEFEKDDP(Behaviour MIBGLNBAKNB)
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

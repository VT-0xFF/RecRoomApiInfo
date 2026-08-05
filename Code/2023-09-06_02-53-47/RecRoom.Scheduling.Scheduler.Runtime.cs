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
public class NJJJFNLBEBD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority KMJCHKPHBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4F01F80", Offset = "0x4F00580", VA = "0x184F01F80")]
	public NJJJFNLBEBD(ThreadPriority OIIMFNFLBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4F01F70", Offset = "0x4F00570", VA = "0x184F01F70", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> LMNGHBJKAOI(List<PlayerLoopSystem> NPKGKGEPBBI, int HEGEEMEHGHF);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct EIHEGBLMIOG
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct JOFNAKJLKKG
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static IOAJAPLOKEP EMBFFDMAJEF;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x4EFD760", Offset = "0x4EFBD60", VA = "0x184EFD760")]
				public static PlayerLoopSystem PNDEMINMHBP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct ILLBIONBGBH
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static IOAJAPLOKEP LFFLFMBDACO;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x4EFC510", Offset = "0x4EFAB10", VA = "0x184EFC510")]
				public static PlayerLoopSystem PNDEMINMHBP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct LDDNGLKIGFA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static IOAJAPLOKEP OALGHKMHKEE;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4EFF930", Offset = "0x4EFDF30", VA = "0x184EFF930")]
				public static PlayerLoopSystem PNDEMINMHBP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct AMKFHDMHIMK
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static IOAJAPLOKEP EIFCPHKHCBF;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static IOAJAPLOKEP HPLLJMBILLP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IOAJAPLOKEP FJJMHCLJIMH;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static IOAJAPLOKEP JHNOOLKKPBO;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x4EEB830", Offset = "0x4EE9E30", VA = "0x184EEB830")]
				public static PlayerLoopSystem PNDEMINMHBP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct INCHDFKDIGC
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static IOAJAPLOKEP FDIKOPNINLD;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x4EFC720", Offset = "0x4EFAD20", VA = "0x184EFC720")]
				public static PlayerLoopSystem PNDEMINMHBP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct GCDDMAONOHE
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static IOAJAPLOKEP EIFCPHKHCBF;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static IOAJAPLOKEP HPLLJMBILLP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static IOAJAPLOKEP FJJMHCLJIMH;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static IOAJAPLOKEP JHNOOLKKPBO;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x4EF72D0", Offset = "0x4EF58D0", VA = "0x184EF72D0")]
				public static PlayerLoopSystem PNDEMINMHBP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct CKMLMJNEEDN
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static IOAJAPLOKEP JBPLAMEPENJ;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x4EEE800", Offset = "0x4EECE00", VA = "0x184EEE800")]
				public static PlayerLoopSystem PNDEMINMHBP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct KKOGBJPCMAG
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static IOAJAPLOKEP OFJNDMEGFFA;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x4EFDFD0", Offset = "0x4EFC5D0", VA = "0x184EFDFD0")]
				public static PlayerLoopSystem PNDEMINMHBP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct FCLDNGAINIJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static IOAJAPLOKEP HBEJEMKJGCL;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x4EF6E90", Offset = "0x4EF5490", VA = "0x184EF6E90")]
				public static PlayerLoopSystem PNDEMINMHBP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct IKLHOLFAKCM
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static IOAJAPLOKEP ADALNHNAOFM;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x4EFC300", Offset = "0x4EFA900", VA = "0x184EFC300")]
				public static PlayerLoopSystem PNDEMINMHBP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct BAIJFGPKBMJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static IOAJAPLOKEP DJEPAJNEIPJ;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x4EEC530", Offset = "0x4EEAB30", VA = "0x184EEC530")]
				public static PlayerLoopSystem PNDEMINMHBP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct DNDIKEAKPJH
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IOAJAPLOKEP HILJKNHEDIH;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x4EF5B30", Offset = "0x4EF4130", VA = "0x184EF5B30")]
				public static PlayerLoopSystem PNDEMINMHBP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum LIFHDCFMBLN : byte
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
			public struct MDKAGBHJHML
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class BJFNALGFHCH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public LIFHDCFMBLN updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
					public BJFNALGFHCH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x6FFD260", Offset = "0x6FFB860", VA = "0x186FFD260")]
					internal void LMGGEKCDIBH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static AFANAFKFEIG<LIFHDCFMBLN> MOODCGAAANE;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x4F004F0", Offset = "0x4EFEAF0", VA = "0x184F004F0")]
				public static PlayerLoopSystem PNDEMINMHBP(LIFHDCFMBLN PJGFFBGMNLD)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct CNDABOPCMBH
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class KLIDICFKGKC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public NMDCINGGFJE.ACMONMPGPHM key;

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
					public KLIDICFKGKC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x4EFE1E0", Offset = "0x4EFC7E0", VA = "0x184EFE1E0")]
					internal void EAKGCHCFGLK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable GOPDHGBFKHG;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x4EEEA10", Offset = "0x4EED010", VA = "0x184EEEA10")]
				public static PlayerLoopSystem DADEAKCGLGP(NMDCINGGFJE.ACMONMPGPHM BOMEFJIOGGM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct BGCMFJFEDOG
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class LKGAJEJAAGF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public NMDCINGGFJE.ACMONMPGPHM key;

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
					public LKGAJEJAAGF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x4EFFD30", Offset = "0x4EFE330", VA = "0x184EFFD30")]
					internal void EAKGCHCFGLK()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x4EED2F0", Offset = "0x4EEB8F0", VA = "0x184EED2F0")]
				public static PlayerLoopSystem DADEAKCGLGP(NMDCINGGFJE.ACMONMPGPHM BOMEFJIOGGM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class NBIKAOFKEPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public NBIKAOFKEPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4F013B0", Offset = "0x4EFF9B0", VA = "0x184F013B0")]
			internal List<PlayerLoopSystem> NMJNJHBKOEK(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KFIELJOHJNH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool KIEELIIIIMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x4EF0740", Offset = "0x4EEED40", VA = "0x184EF0740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x4EF0400", Offset = "0x4EEEA00", VA = "0x184EF0400")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1470", Offset = "0x4EEFA70", VA = "0x184EF1470")]
		private static void PJEFFFKBIPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0780", Offset = "0x4EEED80", VA = "0x184EF0780")]
		private static void MPBBEPGJOMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4EF00D0", Offset = "0x4EEE6D0", VA = "0x184EF00D0")]
		private static void BNAENCCPNKK(string IJMFBFAEANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4EEFEA0", Offset = "0x4EEE4A0", VA = "0x184EEFEA0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0440", Offset = "0x4EEEA40", VA = "0x184EF0440")]
		private static void GFNJJMNJGMA(NMDCINGGFJE.ACMONMPGPHM BOMEFJIOGGM, ref PlayerLoopSystem LIPGANENBEF, Type BHNNFMOGCIE, Type OOADDJBAOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1050", Offset = "0x4EEF650", VA = "0x184EF1050")]
		private static void OBLEJLNBBDK(ref PlayerLoopSystem LIPGANENBEF, Type BHNNFMOGCIE, Type OOADDJBAOAE, LMNGHBJKAOI JGEALOMLLCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0610", Offset = "0x4EEEC10", VA = "0x184EF0610")]
		private static void JMHJCDBIKGL(ref PlayerLoopSystem LIPGANENBEF, Type BHNNFMOGCIE, Type OOADDJBAOAE, PlayerLoopSystem? CIHLEABJHOB, PlayerLoopSystem? KOJDCBILNBD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class NMDCINGGFJE
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum ACMONMPGPHM
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
	public class GJIDOAFPKPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly ACMONMPGPHM GOINMAJDEEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly JMICPPBFDFO LNBDEJFHLKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long IPAJOCLCEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long PAKFCEIPDIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long IPNNCFNEKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int BINEHODIACK;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4EF82E0", Offset = "0x4EF68E0", VA = "0x184EF82E0")]
		public GJIDOAFPKPC(ACMONMPGPHM JCKEINGHEMO, int ONCKDGJEOBL = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4EF8070", Offset = "0x4EF6670", VA = "0x184EF8070")]
		public void MIHFMHFJJNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4EF8010", Offset = "0x4EF6610", VA = "0x184EF8010")]
		public void FKHGDOMCBBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4EF80E0", Offset = "0x4EF66E0", VA = "0x184EF80E0")]
		public void OLEAGIAPMNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static ACMONMPGPHM[] LJLBCCMKDGD;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static GJIDOAFPKPC[] DKIEOKCPGAI;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4F02560", Offset = "0x4F00B60", VA = "0x184F02560")]
	public static GJIDOAFPKPC DLPHFLMJPHH(ACMONMPGPHM BOMEFJIOGGM, int ONCKDGJEOBL = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4F02740", Offset = "0x4F00D40", VA = "0x184F02740")]
	public static GJIDOAFPKPC JPMANLPOLCM(ACMONMPGPHM BOMEFJIOGGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4F024B0", Offset = "0x4F00AB0", VA = "0x184F024B0")]
	public static void DGBJHLPOMEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EOHKAKHPDGF
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private interface NKKNOEGCOLA
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool FNBNNDMHFCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BEJNCICKNOM();
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private abstract class PMCMDMJKLGO<TPromise, TMainThreadPromise> : NKKNOEGCOLA where TPromise : HHGLIBCDIDA where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly TPromise CAFAHLBLBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected readonly TMainThreadPromise IMJHAOOAIJM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TPromise EAJCNAHIDEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x22B7F60", Offset = "0x22B6560", VA = "0x1822B7F60")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool FNBNNDMHFCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x22B7F10", Offset = "0x22B6510", VA = "0x1822B7F10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x22445A0", Offset = "0x2242BA0", VA = "0x1822445A0")]
		protected PMCMDMJKLGO(TPromise CAFAHLBLBMN, TMainThreadPromise DNPCAJLMHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x22B7EE0", Offset = "0x22B64E0", VA = "0x1822B7EE0", Slot = "5")]
		public void BEJNCICKNOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void ABNPDGJHCGA(TPromise CAFAHLBLBMN);
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class FGNPIILBPMF<T> : PMCMDMJKLGO<MFBKDKPGMNP<T>, FIKNOBAKBJH<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x50B5170", Offset = "0x50B3770", VA = "0x1850B5170")]
		public FGNPIILBPMF(MFBKDKPGMNP<T> CAFAHLBLBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x50B4F40", Offset = "0x50B3540", VA = "0x1850B4F40", Slot = "6")]
		protected override void ABNPDGJHCGA(MFBKDKPGMNP<T> CAFAHLBLBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x50B5140", Offset = "0x50B3740", VA = "0x1850B5140")]
		[CompilerGenerated]
		private void OLNLDJAKBMP(T NKONLKNLFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA550", Offset = "0x8F8B50", VA = "0x1808FA550")]
		[CompilerGenerated]
		private void OEDJNAAEELB(string PMBGBHCKNKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class BCGFIPAJPLP : NKKNOEGCOLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Action ILLCNPCAHGD;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FNBNNDMHFCK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
		public BCGFIPAJPLP(Action ILLCNPCAHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA17710", Offset = "0xA15D10", VA = "0x180A17710", Slot = "5")]
		public void BEJNCICKNOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<NKKNOEGCOLA> KIAJHGDDMJE;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3301700", Offset = "0x32FFD00", VA = "0x183301700")]
	public static MFBKDKPGMNP<T> AMHANEILLEG<T>(this MFBKDKPGMNP<T> CAFAHLBLBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4EF66B0", Offset = "0x4EF4CB0", VA = "0x184EF66B0")]
	public static void AMHANEILLEG(Action ILLCNPCAHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3301770", Offset = "0x32FFD70", VA = "0x183301770")]
	private static MFBKDKPGMNP<T> DMDLBLMAKJB<T>(MFBKDKPGMNP<T> CAFAHLBLBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4EF6840", Offset = "0x4EF4E40", VA = "0x184EF6840")]
	private static void HIIFPNHJGCP(NKKNOEGCOLA DOIPBIDHBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4EF6A40", Offset = "0x4EF5040", VA = "0x184EF6A40")]
	private static void HKBKNLNNOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4EF6740", Offset = "0x4EF4D40", VA = "0x184EF6740")]
	private static void GJKCIOANJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4EF6D40", Offset = "0x4EF5340", VA = "0x184EF6D40")]
	private static void NHLDJAADIIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DMKFAPNFJAF
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private struct HBFMLHJCHBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<Scene> DALBDJFNOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly string GBALEBANABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly LoadSceneMode KBMPAEGGHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly bool DBMPCELEGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4EF83E0", Offset = "0x4EF69E0", VA = "0x184EF83E0")]
		public HBFMLHJCHBE(TaskCompletionSource<Scene> BDGEAAHMFOM, string GBALEBANABD, LoadSceneMode KBMPAEGGHBC, bool DBMPCELEGFJ, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class EDEPCFCJLJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private BAOHAJMDGEC<string> <toDispose>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private BPMBBNCDHHK <stackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private HBFMLHJCHBE <queuedSceneLoad>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public EDEPCFCJLJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4EF5D40", Offset = "0x4EF4340", VA = "0x184EF5D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class ICLFNIOPEMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ICLFNIOPEMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBFC0", Offset = "0x4EFA5C0", VA = "0x184EFBFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class BAMICHBHMCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private HBFMLHJCHBE <dequeued>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Scene <scene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Scene <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BAMICHBHMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4EEC740", Offset = "0x4EEAD40", VA = "0x184EEC740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KBJKMMKMHIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FIKNOBAKBJH<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KBJKMMKMHIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4EFD970", Offset = "0x4EFBF70", VA = "0x184EFD970")]
		internal void LODBKMCGCOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class BHFCBBDAGPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <loadSceneTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private KBJKMMKMHIM <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool <shouldLoadEmptyScene>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Scene <emptyScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Scene <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BHFCBBDAGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4EED450", Offset = "0x4EEBA50", VA = "0x184EED450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class NLJONJIDBEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private SceneInstance <instance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NLJONJIDBEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4F01FC0", Offset = "0x4F005C0", VA = "0x184F01FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class JFHEJNFCONA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Scene <emptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <emptySceneRoutineTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <emptySceneTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JFHEJNFCONA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4EFCAB0", Offset = "0x4EFB0B0", VA = "0x184EFCAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MNPMHHIPEFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MNPMHHIPEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4F01380", Offset = "0x4EFF980", VA = "0x184F01380")]
		internal bool NCKAAOHIDKL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class MCGDEJNLNCP : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public NOKBHGDKGNF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <sample>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private MNPMHHIPEFP <>8__3;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public MCGDEJNLNCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4F00460", Offset = "0x4EFEA60", VA = "0x184F00460", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4F000E0", Offset = "0x4EFE6E0", VA = "0x184F000E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4F00090", Offset = "0x4EFE690", VA = "0x184F00090")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4F00420", Offset = "0x4EFEA20", VA = "0x184F00420", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class ADBEAJPKFJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public FIKNOBAKBJH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ADBEAJPKFJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4EEABF0", Offset = "0x4EE91F0", VA = "0x184EEABF0")]
		internal bool CFANEDODPHJ(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4EEAC70", Offset = "0x4EE9270", VA = "0x184EEAC70")]
		internal void KDNBHAFNKKP(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class AFAGHJKJJLN : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public FIKNOBAKBJH<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private ADBEAJPKFJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public AFAGHJKJJLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4EEAEE0", Offset = "0x4EE94E0", VA = "0x184EEAEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB6E0", Offset = "0x4EE9CE0", VA = "0x184EEB6E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly ICollection<string> IPHADOBBGKD;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static HHGLIBCDIDA LILAJGAOFAD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AsyncOperation JHHIABOOMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static HHGLIBCDIDA FBEPNFHKPLP;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static string HJJEANELEEF;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static ThreadPriority DBBBJIPLDIA;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task NOMNHKGHJPH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static List<SceneInstance> JANNIKKPFDC;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Queue<HBFMLHJCHBE> OGNBMFGLNBH;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Task KGFHAHDHKPN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool FCAKFGFFODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4EF47D0", Offset = "0x4EF2DD0", VA = "0x184EF47D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool JJKJCMJGLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4EF55D0", Offset = "0x4EF3BD0", VA = "0x184EF55D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private static bool ANHEDJPBDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4EF5070", Offset = "0x4EF3670", VA = "0x184EF5070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static bool CPLNCIPLNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4EF5520", Offset = "0x4EF3B20", VA = "0x184EF5520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> IHLOKOEAFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4EF52D0", Offset = "0x4EF38D0", VA = "0x184EF52D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4EF4130", Offset = "0x4EF2730", VA = "0x184EF4130")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4EF4C00", Offset = "0x4EF3200", VA = "0x184EF4C00")]
	[MIGBJBEEOCN(HEBOPNAGEEP.EnteredEditModeNextFrame, 0)]
	private static void FLMPEJAIKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4EF4A50", Offset = "0x4EF3050", VA = "0x184EF4A50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDEPCFCJLJD))]
	public static Task<Scene> FHKKEPNGINM(string GBALEBANABD, LoadSceneMode KBMPAEGGHBC = LoadSceneMode.Single, bool DBMPCELEGFJ = false, [Optional] BAOHAJMDGEC<string>.AEJDDJEKDHH OIIMLAFBPIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4EF5130", Offset = "0x4EF3730", VA = "0x184EF5130")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ICLFNIOPEMC))]
	private static Task INAMAKDKPIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4EF4F70", Offset = "0x4EF3570", VA = "0x184EF4F70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BAMICHBHMCJ))]
	private static Task IFDBGMOGKIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4EF4DC0", Offset = "0x4EF33C0", VA = "0x184EF4DC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BHFCBBDAGPE))]
	private static Task<Scene> HCMOJOLFPDN(string GBALEBANABD, LoadSceneMode KBMPAEGGHBC, bool DBMPCELEGFJ, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4EF4040", Offset = "0x4EF2640", VA = "0x184EF4040")]
	private static void AGPDKLEMFJP(SceneInstance DFKGLOBLDNJ, LoadSceneMode KBMPAEGGHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4EF5880", Offset = "0x4EF3E80", VA = "0x184EF5880")]
	private static void MKNNOOLFKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4EF43A0", Offset = "0x4EF29A0", VA = "0x184EF43A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NLJONJIDBEK))]
	private static Task<Scene> DMDGBKOGCIG(string GBALEBANABD, LoadSceneMode KBMPAEGGHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4EF4CD0", Offset = "0x4EF32D0", VA = "0x184EF4CD0")]
	private static bool HCJEBPBEIDG(string GBALEBANABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4EF53D0", Offset = "0x4EF39D0", VA = "0x184EF53D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JFHEJNFCONA))]
	private static Task<Scene> LDGKMBJIJOF(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4EF5690", Offset = "0x4EF3C90", VA = "0x184EF5690")]
	public static MFBKDKPGMNP<Scene> MJJHIANKDOD(string GBALEBANABD, LoadSceneMode KBMPAEGGHBC = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4EF4500", Offset = "0x4EF2B00", VA = "0x184EF4500")]
	public static HHGLIBCDIDA ELKDDKNPEFN(string GBALEBANABD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4EF5920", Offset = "0x4EF3F20", VA = "0x184EF5920")]
	[IteratorStateMachine(typeof(MCGDEJNLNCP))]
	private static IEnumerator<FOLOHDFBANO> MOCHDIBGKMI(string GBALEBANABD, NOKBHGDKGNF LKOFGHNEIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4EF5230", Offset = "0x4EF3830", VA = "0x184EF5230")]
	[IteratorStateMachine(typeof(AFAGHJKJJLN))]
	private static IEnumerator<FOLOHDFBANO> JKMNJIJIJNN(string GBALEBANABD, LoadSceneMode KBMPAEGGHBC, FIKNOBAKBJH<Scene> LKOFGHNEIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4EF4230", Offset = "0x4EF2830", VA = "0x184EF4230")]
	public static bool CBEPDJMFMBB(out string FMCGAPAAKII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class JMICPPBFDFO : ELMNHACHOCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int CIDBABJJKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Queue<double> NPEPJEFJPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private double JKJLIBLKLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private double OEJABJDKHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private double NKCHICMJEEH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public double DPDMGLBELBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4EFD5D0", Offset = "0x4EFBBD0", VA = "0x184EFD5D0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double NNEADEAGLPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x953120", Offset = "0x951720", VA = "0x180953120", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double EGLMDJIPICE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3E494D0", Offset = "0x3E47AD0", VA = "0x183E494D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD6B0", Offset = "0x4EFBCB0", VA = "0x184EFD6B0")]
	public JMICPPBFDFO(int FLPMDDJIPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD4A0", Offset = "0x4EFBAA0", VA = "0x184EFD4A0", Slot = "7")]
	public void HKFNMEEKBJN(double PMMAPONKBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD640", Offset = "0x4EFBC40", VA = "0x184EFD640", Slot = "8")]
	public void KINBCCGCMFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class MNBJMMGJDHD : ELMNHACHOCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private long FJLPCOJGEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private double FGDDHPCMBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private double EPDDOAAJHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private double GIDEJKBANEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private double EIFIIOGJDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private double JKJLIBLKLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private double OEJABJDKHOO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xE93CC0", Offset = "0xE922C0", VA = "0x180E93CC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double NNEADEAGLPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4F011C0", Offset = "0x4EFF7C0", VA = "0x184F011C0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double EGLMDJIPICE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4F01210", Offset = "0x4EFF810", VA = "0x184F01210", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double HOHEBNEKIBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4F01070", Offset = "0x4EFF670", VA = "0x184F01070")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double DPDMGLBELBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4F011B0", Offset = "0x4EFF7B0", VA = "0x184F011B0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F01080", Offset = "0x4EFF680", VA = "0x184F01080", Slot = "7")]
	public virtual void HKFNMEEKBJN(double PMMAPONKBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F011D0", Offset = "0x4EFF7D0", VA = "0x184F011D0", Slot = "8")]
	public virtual void KINBCCGCMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F01220", Offset = "0x4EFF820", VA = "0x184F01220")]
	public MNBJMMGJDHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class OHGICGOFAEN : MNBJMMGJDHD
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public double IBGEJFEGBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3E49450", Offset = "0x3E47A50", VA = "0x183E49450")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3E49420", Offset = "0x3E47A20", VA = "0x183E49420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4F03BF0", Offset = "0x4F021F0", VA = "0x184F03BF0", Slot = "7")]
	public override void HKFNMEEKBJN(double PMMAPONKBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4F03D30", Offset = "0x4F02330", VA = "0x184F03D30", Slot = "8")]
	public override void KINBCCGCMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4F01220", Offset = "0x4EFF820", VA = "0x184F01220")]
	public OHGICGOFAEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface ELMNHACHOCC
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	double DPDMGLBELBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double NNEADEAGLPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	double EGLMDJIPICE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class HHIEMONOBJC : HAMBOJBIPBK
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public float IHFAEGLCKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4EF8440", Offset = "0x4EF6A40", VA = "0x184EF8440", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public float PPLBGDOFCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4EF8450", Offset = "0x4EF6A50", VA = "0x184EF8450", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public double LCDAEPPKMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4EF84D0", Offset = "0x4EF6AD0", VA = "0x184EF84D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8460", Offset = "0x4EF6A60", VA = "0x184EF8460")]
	[HFALCAKMDCP(BFPOMPMIJIJ.None)]
	private static void KDCCKDGHAKL(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	[Preserve]
	internal HHIEMONOBJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class OGCNDIJNLEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class FNECHLEKCHO : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public OGCNDIJNLEB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public FNECHLEKCHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4EF7110", Offset = "0x4EF5710", VA = "0x184EF7110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4EF7180", Offset = "0x4EF5780", VA = "0x184EF7180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private BDPNFFCBKDC CCMIIJEIBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private MonoBehaviour CPDPMINGACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Action GBAHNMCMAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Action<float> AJEPHPEHHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private EEJKPJOEJFO MJFHIMIBLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float CKMJAANGDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool CLLBGJCHLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly CDNNNIJHPJN EBLGJABNHNN;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F037B0", Offset = "0x4F01DB0", VA = "0x184F037B0")]
	public OGCNDIJNLEB(MonoBehaviour CPDPMINGACC, Action GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ, [Optional] CDNNNIJHPJN EBLGJABNHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F039B0", Offset = "0x4F01FB0", VA = "0x184F039B0")]
	public OGCNDIJNLEB(MonoBehaviour CPDPMINGACC, Action<float> GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ, [Optional] CDNNNIJHPJN EBLGJABNHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4F03560", Offset = "0x4F01B60", VA = "0x184F03560")]
	public OGCNDIJNLEB(MonoBehaviour CPDPMINGACC, float FPFLCIJEDLJ, Action<float> GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ, bool CLLBGJCHLCH = true, [Optional] CDNNNIJHPJN EBLGJABNHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD700", Offset = "0x3DDBD00", VA = "0x183DDD700")]
	private OGCNDIJNLEB(CDNNNIJHPJN EBLGJABNHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4F02AE0", Offset = "0x4F010E0", VA = "0x184F02AE0")]
	internal static OGCNDIJNLEB DHPNLAHBDCN(MonoBehaviour CPDPMINGACC, float FPFLCIJEDLJ, Action<float> GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ, bool CLLBGJCHLCH = true, [Optional] CDNNNIJHPJN EBLGJABNHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4F02C60", Offset = "0x4F01260", VA = "0x184F02C60")]
	private void GOLAFFBMBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4F03010", Offset = "0x4F01610", VA = "0x184F03010")]
	private void IGGGFNKCKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4F02E60", Offset = "0x4F01460", VA = "0x184F02E60")]
	private void HOPKBHLDFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4F03300", Offset = "0x4F01900", VA = "0x184F03300")]
	private void MJCECFPAIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F031C0", Offset = "0x4F017C0", VA = "0x184F031C0")]
	private void LPDJEFCGKEG(string PMBGBHCKNKB, Action IOIJJCHOCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4F02DD0", Offset = "0x4F013D0", VA = "0x184F02DD0")]
	[IteratorStateMachine(typeof(FNECHLEKCHO))]
	private IEnumerator<FOLOHDFBANO> HHMCGNLNEEL(Action IOIJJCHOCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F02C00", Offset = "0x4F01200", VA = "0x184F02C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4F029C0", Offset = "0x4F00FC0", VA = "0x184F029C0")]
	[CompilerGenerated]
	private void CFPHMICOOKJ(string IAPFIFFPKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4F034D0", Offset = "0x4F01AD0", VA = "0x184F034D0")]
	[CompilerGenerated]
	private void MMGDEHPFMOL(string IAPFIFFPKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4F02930", Offset = "0x4F00F30", VA = "0x184F02930")]
	[CompilerGenerated]
	private void BPJEHCHDDDD(string IAPFIFFPKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4F02A50", Offset = "0x4F01050", VA = "0x184F02A50")]
	[CompilerGenerated]
	private void DEKHPLCPNHM(string IAPFIFFPKCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct GDBIGNOGFII : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[ReadOnly]
	public float ILAMPIMPDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	public int CIHIOAAILHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<int> FHOPBGLFBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<int> MHNLAMJNCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeArray<int> AFHABBLCJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	public NativeArray<DOCAMAKLPOD> DNFABIBPBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	public NativeArray<float> GLICDFIOPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[WriteOnly]
	public NativeArray<int> KAGFMBEOHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[WriteOnly]
	public NativeArray<int> GMHCHHEJJHO;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7710", Offset = "0x4EF5D10", VA = "0x184EF7710")]
	public static GDBIGNOGFII HKLENFAPHAP(int LKABDNOEMIH, float EPCCIIJAODB, NativeArray<DOCAMAKLPOD> FHINIAHBNHM, NativeArray<float> IFFPKBFBCOE, NativeArray<int> PAGJEIOIKOF, NativeArray<int> GGLBLHPMHBJ, NativeArray<int> MLIPJPHMODH, NativeArray<int> MHNLAMJNCAN, NativeArray<int> AFHABBLCJCM)
	{
		return default(GDBIGNOGFII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4EF75F0", Offset = "0x4EF5BF0", VA = "0x184EF75F0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4EF76D0", Offset = "0x4EF5CD0", VA = "0x184EF76D0")]
	private bool FIBJOBMDCPK(int OLGOBCPPPBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4EF79D0", Offset = "0x4EF5FD0", VA = "0x184EF79D0")]
	private void LMIPLEOKMCK(NativeArray<int> BCKPNGILJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7590", Offset = "0x4EF5B90", VA = "0x184EF7590")]
	private int BGBILNAAEBJ(int OAMCJJDBMLF, int KDPECAECGIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7A00", Offset = "0x4EF6000", VA = "0x184EF7A00")]
	private void OHGNBPDDJBD(NativeArray<int> BCKPNGILJGK, int PGOIIPJMPEJ, int EMOGFKKIBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4EF77C0", Offset = "0x4EF5DC0", VA = "0x184EF77C0")]
	private void KNJOCLPLKKA(NativeArray<int> BCKPNGILJGK, int BHAACAFIKMO, int AMMDEAACLII, int KCHANBDDOKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class GFEHDFGFDHA : HOFHCHACPKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly float DAJCBNACKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly int OLOHFHJMIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float FGOLAKFEMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly float[] GKGAKPAEFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private int GKLOEFKODLL;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7D90", Offset = "0x4EF6390", VA = "0x184EF7D90")]
	public GFEHDFGFDHA(Behaviour MFPELEJLJLD, float JHCILLIKPCH, int OLOHFHJMIHL, [Optional] Action AFJMNPFPPLP, float FGOLAKFEMLK = 0f, [Optional] CDNNNIJHPJN EBLGJABNHNN, [Optional] HAMBOJBIPBK EAGIJCLINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x928C00", Offset = "0x927200", VA = "0x180928C00", Slot = "9")]
	protected override bool IOBEOCEGJHJ(Action ILLCNPCAHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7AD0", Offset = "0x4EF60D0", VA = "0x184EF7AD0", Slot = "10")]
	protected override bool BGBDPGJNFBL(Action ILLCNPCAHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7D00", Offset = "0x4EF6300", VA = "0x184EF7D00")]
	private void JLPEKNBGEKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public abstract class KOONENHINCK : CDNNNIJHPJN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly EGAMGCEGNED PGKMBMNPIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected readonly HAMBOJBIPBK EAGIJCLINCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private PGMIJLMGAJB[] BMBBLGDPHHN;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static CDNNNIJHPJN HAMPJMKDJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4EFED30", Offset = "0x4EFD330", VA = "0x184EFED30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public EEJKPJOEJFO LOCCPNIIJMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1A0", Offset = "0x7E87A0", VA = "0x1807EA1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(EEJKPJOEJFO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E30", Offset = "0x9B5430", VA = "0x1809B6E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public HAMBOJBIPBK FFBFFAAMAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public FOLOHDFBANO PPJCMLGAHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEFD0", Offset = "0x4EFD5D0", VA = "0x184EFEFD0")]
	public static BDPNFFCBKDC MIGIJAJFBGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF380", Offset = "0x4EFD980", VA = "0x184EFF380")]
	[Preserve]
	protected KOONENHINCK([BBBJPGKHPHG(null)] EGAMGCEGNED PGKMBMNPIGA, [BBBJPGKHPHG(null)] HAMBOJBIPBK EAGIJCLINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEAC0", Offset = "0x4EFD0C0", VA = "0x184EFEAC0", Slot = "6")]
	public BDPNFFCBKDC IHAIHLFLKNG(IEnumerator<FOLOHDFBANO> BKBIMPBIJDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE890", Offset = "0x4EFCE90", VA = "0x184EFE890", Slot = "7")]
	public BDPNFFCBKDC IHAIHLFLKNG(Behaviour MFPELEJLJLD, IEnumerator<FOLOHDFBANO> BKBIMPBIJDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract BDPNFFCBKDC MIGLFPCJODG(AAMOEBEEMHP MFPELEJLJLD, IEnumerator<FOLOHDFBANO> BKBIMPBIJDG);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEB50", Offset = "0x4EFD150", VA = "0x184EFEB50", Slot = "17")]
	public virtual void KINBCCGCMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEDA0", Offset = "0x4EFD3A0", VA = "0x184EFEDA0", Slot = "9")]
	public void LJBKMHFBEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE810", Offset = "0x4EFCE10", VA = "0x184EFE810", Slot = "18")]
	protected virtual void GFCEDFCLACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4EFED80", Offset = "0x4EFD380", VA = "0x184EFED80")]
	private void LFFLFMBDACO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF060", Offset = "0x4EFD660", VA = "0x184EFF060")]
	private void OALGHKMHKEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF360", Offset = "0x4EFD960", VA = "0x184EFF360")]
	private void POMPHFNABOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE470", Offset = "0x4EFCA70", VA = "0x184EFE470")]
	private void DOAPFPPDFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEAD0", Offset = "0x4EFD0D0", VA = "0x184EFEAD0")]
	private void JBPLAMEPENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF080", Offset = "0x4EFD680", VA = "0x184EFF080")]
	private void OFJNDMEGFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE450", Offset = "0x4EFCA50", VA = "0x184EFE450")]
	private void AJHHHMMNFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF0A0", Offset = "0x4EFD6A0", VA = "0x184EFF0A0", Slot = "19")]
	public virtual void PHFGDFPDBCP(EEJKPJOEJFO MJFHIMIBLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEE00", Offset = "0x4EFD400", VA = "0x184EFEE00")]
	private void LPLHAMIOECK(PGMIJLMGAJB HGAPJPJBIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2A81350", Offset = "0x2A7F950", VA = "0x182A81350")]
	private PGMIJLMGAJB NDNFNOIKLDB(EEJKPJOEJFO KLGGKKGCLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract CPKJPDJNKGN EKFBGBGIGLA(IEnumerator<FOLOHDFBANO> BKBIMPBIJDG, Behaviour CPDPMINGACC, BKJDMHKMDDM EJMLMJJAEBB);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract PGMIJLMGAJB FAGOLEEGLPB(EEJKPJOEJFO MJFHIMIBLCJ);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE490", Offset = "0x4EFCA90", VA = "0x184EFE490", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEAF0", Offset = "0x4EFD0F0", VA = "0x184EFEAF0", Slot = "12")]
	public FOLOHDFBANO KIGEHJKMCOF(EEJKPJOEJFO OBJFKAPAMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF2E0", Offset = "0x4EFD8E0", VA = "0x184EFF2E0", Slot = "13")]
	public FOLOHDFBANO PMLLBIJAGHK(float MIKGPKAPCMA, EEJKPJOEJFO OBJFKAPAMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE830", Offset = "0x4EFCE30", VA = "0x184EFE830", Slot = "14")]
	public FOLOHDFBANO HPAIPLMHHDE(Func<bool> HCKMADLOLAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class COCJCKKAKBK : KOONENHINCK, CDNNNIJHPJN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private ICDMLJGKDGA[] NFDAGBFGMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private FOGDKGBKGAH LDAFBEAKLNG;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4EEEFC0", Offset = "0x4EED5C0", VA = "0x184EEEFC0")]
	[HFALCAKMDCP(BFPOMPMIJIJ.None)]
	private static void KDCCKDGHAKL(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF660", Offset = "0x4EEDC60", VA = "0x184EEF660")]
	[Preserve]
	public COCJCKKAKBK([BBBJPGKHPHG(null)] EGAMGCEGNED PGKMBMNPIGA, [BBBJPGKHPHG(null)] HAMBOJBIPBK EAGIJCLINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF300", Offset = "0x4EED900", VA = "0x184EEF300", Slot = "16")]
	public override BDPNFFCBKDC MIGLFPCJODG(AAMOEBEEMHP MFPELEJLJLD, IEnumerator<FOLOHDFBANO> BKBIMPBIJDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF030", Offset = "0x4EED630", VA = "0x184EEF030", Slot = "17")]
	public override void KINBCCGCMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF450", Offset = "0x4EEDA50", VA = "0x184EEF450", Slot = "19")]
	public override void PHFGDFPDBCP(EEJKPJOEJFO MJFHIMIBLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4EEEDC0", Offset = "0x4EED3C0", VA = "0x184EEEDC0", Slot = "18")]
	protected override void GFCEDFCLACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF620", Offset = "0x4EEDC20", VA = "0x184EEF620")]
	private ICDMLJGKDGA PNKGAEMAODL(EEJKPJOEJFO KLGGKKGCLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4EEEBE0", Offset = "0x4EED1E0", VA = "0x184EEEBE0", Slot = "20")]
	internal override CPKJPDJNKGN EKFBGBGIGLA(IEnumerator<FOLOHDFBANO> BKBIMPBIJDG, Behaviour MFPELEJLJLD, BKJDMHKMDDM MOLFCCHMICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEED50", Offset = "0x4EED350", VA = "0x184EEED50", Slot = "21")]
	internal override PGMIJLMGAJB FAGOLEEGLPB(EEJKPJOEJFO OBJFKAPAMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4EEEEA0", Offset = "0x4EED4A0", VA = "0x184EEEEA0")]
	private void HCBBMJIINCJ(ICDMLJGKDGA HGAPJPJBIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4EEEB70", Offset = "0x4EED170", VA = "0x184EEEB70", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class DIEFKMMLGKD
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class DEELBKHIIHB : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public EEJKPJOEJFO queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public DEELBKHIIHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4EF3DC0", Offset = "0x4EF23C0", VA = "0x184EF3DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4EF3E70", Offset = "0x4EF2470", VA = "0x184EF3E70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4EF3FC0", Offset = "0x4EF25C0", VA = "0x184EF3FC0")]
	[IteratorStateMachine(typeof(DEELBKHIIHB))]
	private static IEnumerator<FOLOHDFBANO> JIDJMHPPLED(EEJKPJOEJFO MJFHIMIBLCJ, Func<bool> HCKMADLOLAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4EF3EB0", Offset = "0x4EF24B0", VA = "0x184EF3EB0")]
	public static BDPNFFCBKDC IIFINDMAFMG(this MonoBehaviour CPDPMINGACC, Func<bool> HCKMADLOLAI, EEJKPJOEJFO MJFHIMIBLCJ = EEJKPJOEJFO.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class CPKJPDJNKGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly BKJDMHKMDDM MOLFCCHMICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly FHBNELNKPHG MFPELEJLJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly bool FGLKMJCEJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private string ECMAPGHKHFB;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IEnumerator<FOLOHDFBANO> NDACJNCLFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public FOLOHDFBANO DLDPJEEHCAN
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool BHDMCCFCGND
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4EEFC30", Offset = "0x4EEE230", VA = "0x184EEFC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool FFAEIFIJLDE
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x97FB60", Offset = "0x97E160", VA = "0x18097FB60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xDF8F90", Offset = "0xDF7590", VA = "0x180DF8F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4EEFA30", Offset = "0x4EEE030", VA = "0x184EEFA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float OIMJLCGPEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xEDBE80", Offset = "0xEDA480", VA = "0x180EDBE80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x16277C0", Offset = "0x1625DC0", VA = "0x1816277C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4EEFD90", Offset = "0x4EEE390", VA = "0x184EEFD90")]
	public CPKJPDJNKGN(IEnumerator<FOLOHDFBANO> LODNPFDCPHG, FHBNELNKPHG MFPELEJLJLD, BKJDMHKMDDM MOLFCCHMICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF7A0", Offset = "0x4EEDDA0", VA = "0x184EEF7A0")]
	public FOLOHDFBANO IGHDEFFNEAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4EEFBB0", Offset = "0x4EEE1B0", VA = "0x184EEFBB0")]
	public bool LCIGADNOEEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4EEF720", Offset = "0x4EEDD20", VA = "0x184EEF720")]
	public void HGKDEANLLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4EEFCB0", Offset = "0x4EEE2B0", VA = "0x184EEFCB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xE413B0", Offset = "0xE3F9B0", VA = "0x180E413B0")]
	[CompilerGenerated]
	private void BLIMAFCBPPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class KBMJHFJFKMP
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class CDCDHHIFHNE : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public OBELAALMMLA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public EEJKPJOEJFO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public CDCDHHIFHNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4EEE650", Offset = "0x4EECC50", VA = "0x184EEE650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4EEE6F0", Offset = "0x4EECCF0", VA = "0x184EEE6F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4EFDB90", Offset = "0x4EFC190", VA = "0x184EFDB90")]
	public static BDPNFFCBKDC GOLAFFBMBON(float FPFLCIJEDLJ, Action<float> GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ, bool CLLBGJCHLCH = true, [Optional] CDNNNIJHPJN EBLGJABNHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4EFDA80", Offset = "0x4EFC080", VA = "0x184EFDA80")]
	public static BDPNFFCBKDC GOLAFFBMBON(MonoBehaviour CPDPMINGACC, float FPFLCIJEDLJ, Action<float> GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ, bool CLLBGJCHLCH = true, [Optional] CDNNNIJHPJN EBLGJABNHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4EFDC90", Offset = "0x4EFC290", VA = "0x184EFDC90")]
	public static BDPNFFCBKDC JKDEDGHCBAH(MonoBehaviour CPDPMINGACC, float FPFLCIJEDLJ, Action<float> GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ, bool CLLBGJCHLCH = true, [Optional] CDNNNIJHPJN EBLGJABNHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4EFDDB0", Offset = "0x4EFC3B0", VA = "0x184EFDDB0")]
	public static BDPNFFCBKDC JPJACEJKHGH(AAMOEBEEMHP MFPELEJLJLD, float FPFLCIJEDLJ, Action<float> GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ, bool CLLBGJCHLCH = true, [Optional] CDNNNIJHPJN EBLGJABNHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD9D0", Offset = "0x4EFBFD0", VA = "0x184EFD9D0")]
	private static IEnumerator<FOLOHDFBANO> ECHMMNHNHCG(HAMBOJBIPBK EAGIJCLINCN, float FPFLCIJEDLJ, EEJKPJOEJFO OBJFKAPAMCI, Action<float> GBAHNMCMAEE, bool CLLBGJCHLCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4EFDEC0", Offset = "0x4EFC4C0", VA = "0x184EFDEC0")]
	private static IEnumerator<FOLOHDFBANO> MAFNGDIKLLA(HAMBOJBIPBK EAGIJCLINCN, float FPFLCIJEDLJ, EEJKPJOEJFO OBJFKAPAMCI, Action<float> GBAHNMCMAEE, bool CLLBGJCHLCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4EFDF20", Offset = "0x4EFC520", VA = "0x184EFDF20")]
	[IteratorStateMachine(typeof(CDCDHHIFHNE))]
	private static IEnumerator<FOLOHDFBANO> NLDHKOJMPAJ(OBELAALMMLA IAHDICGADGF, float FPFLCIJEDLJ, EEJKPJOEJFO OBJFKAPAMCI, Action<float> GBAHNMCMAEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface PCMFGKMGMHE
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool NFODMIKHPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LENDDNNNIOE;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DBGKGFLGOLO(bool ODPLBAPFKKP = false);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DBGKGFLGOLO(Action ILLCNPCAHGD, bool ODPLBAPFKKP = false);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class MNCHPPPNDBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly MNCHPPPNDBF OPDGLPPADOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly Action OCFJHDGLKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private bool IPAONFGPPJE;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x15DF070", Offset = "0x15DD670", VA = "0x1815DF070")]
	public MNCHPPPNDBF(Action OCFJHDGLKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4F01260", Offset = "0x4EFF860", VA = "0x184F01260", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface DFAHJCHDOOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	T INKIKMDHKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MHOLGGJHACF(UnityEngine.Object MFPELEJLJLD, Action<T> DLPCAEHGGAL);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface AMAEBOIGOMC<T> : DFAHJCHDOOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	new T INKIKMDHKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OFBHHMLJKDF<T> : AMAEBOIGOMC<T>, DFAHJCHDOOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class LFFJJJOHLOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public OFBHHMLJKDF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public FOMNGLJCNMI<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public LFFJJJOHLOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2634EA0", Offset = "0x26334A0", VA = "0x182634EA0")]
		internal void JAAJMEDHBOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static GameObject FFHJIHMMNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly List<FOMNGLJCNMI<UnityEngine.Object, Action<T>>> BADLINMGPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private T JMNKIFFDIKJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public T INKIKMDHKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xDE6DC0", Offset = "0xDE53C0", VA = "0x180DE6DC0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2F2AB40", Offset = "0x2F29140", VA = "0x182F2AB40", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2F2A7F0", Offset = "0x2F28DF0", VA = "0x182F2A7F0")]
	private static bool LPNLLFMLIIO(T GNJGFBLEGKK, T HEPECHBEGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2F2AC20", Offset = "0x2F29220", VA = "0x182F2AC20")]
	public OFBHHMLJKDF(T KFIPKKMMGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2F2A860", Offset = "0x2F28E60", VA = "0x182F2A860", Slot = "6")]
	public IDisposable MHOLGGJHACF(UnityEngine.Object MFPELEJLJLD, Action<T> DLPCAEHGGAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2F2A430", Offset = "0x2F28A30", VA = "0x182F2A430")]
	private void ADCHLMHOPGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface FOGDKGBKGAH
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIDJEOIJACP(string ECMAPGHKHFB);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JANKIFLDHJM();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class GLIILIHJMGF : FOGDKGBKGAH
{
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
	public void GIDJEOIJACP(string ECMAPGHKHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
	public void JANKIFLDHJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public GLIILIHJMGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class HPDHBIGDGHJ : HOFHCHACPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class FMNBNDOKNBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public HPDHBIGDGHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FMNBNDOKNBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4EF70A0", Offset = "0x4EF56A0", VA = "0x184EF70A0")]
		internal void BGPNKGIAICA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class NJFFFIMEDBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public HPDHBIGDGHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NJFFFIMEDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4EF70A0", Offset = "0x4EF56A0", VA = "0x184EF70A0")]
		internal void BMANNECNLCH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly float IGDKKHKABHH;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8D40", Offset = "0x4EF7340", VA = "0x184EF8D40")]
	public HPDHBIGDGHJ(Behaviour MFPELEJLJLD, float IGDKKHKABHH, [Optional] Action AFJMNPFPPLP, [Optional] CDNNNIJHPJN EBLGJABNHNN, [Optional] HAMBOJBIPBK EAGIJCLINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8C40", Offset = "0x4EF7240", VA = "0x184EF8C40", Slot = "9")]
	protected override bool IOBEOCEGJHJ(Action ILLCNPCAHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8B40", Offset = "0x4EF7140", VA = "0x184EF8B40", Slot = "10")]
	protected override bool BGBDPGJNFBL(Action ILLCNPCAHGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class IAJMMNGHIPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class LKMIKIJOFHA : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public IAJMMNGHIPO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public LKMIKIJOFHA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4EF7110", Offset = "0x4EF5710", VA = "0x184EF7110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4EFFFC0", Offset = "0x4EFE5C0", VA = "0x184EFFFC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private BDPNFFCBKDC CCMIIJEIBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private AAMOEBEEMHP MFPELEJLJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private Action<float> AJEPHPEHHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private EEJKPJOEJFO MJFHIMIBLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private float CKMJAANGDHA;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4EF9430", Offset = "0x4EF7A30", VA = "0x184EF9430")]
	public IAJMMNGHIPO(AAMOEBEEMHP MFPELEJLJLD, float FPFLCIJEDLJ, Action<float> GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8F40", Offset = "0x4EF7540", VA = "0x184EF8F40")]
	private void HOPKBHLDFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x4EF90F0", Offset = "0x4EF76F0", VA = "0x184EF90F0")]
	private void LPDJEFCGKEG(string PMBGBHCKNKB, Action IOIJJCHOCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8EB0", Offset = "0x4EF74B0", VA = "0x184EF8EB0")]
	[IteratorStateMachine(typeof(LKMIKIJOFHA))]
	private IEnumerator<FOLOHDFBANO> HHMCGNLNEEL(Action IOIJJCHOCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8E50", Offset = "0x4EF7450", VA = "0x184EF8E50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4EF9270", Offset = "0x4EF7870", VA = "0x184EF9270")]
	[CompilerGenerated]
	private void PNJHCJENCFL(string IAPFIFFPKCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class ICDMLJGKDGA
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct OJMLGBJIDNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public BNHKDBJDOCC GDJIKLHFDJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AAMOEBEEMHP NDDINENAOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public BKJDMHKMDDM MNBOPLENPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public IEnumerator<FOLOHDFBANO> NDACJNCLFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public FOLOHDFBANO DLDPJEEHCAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public DOCAMAKLPOD BCEODOHDFME;
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct AHELPIMELBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public EEJKPJOEJFO IDDHLAEFLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public List<OJMLGBJIDNJ> APADABNLIFC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class BDIGGGLALGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public BKJDMHKMDDM promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public ICDMLJGKDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public AAMOEBEEMHP context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public BNHKDBJDOCC routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public DOCAMAKLPOD coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public FOLOHDFBANO currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public IEnumerator<FOLOHDFBANO> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BDIGGGLALGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4EECB10", Offset = "0x4EEB110", VA = "0x184EECB10")]
		internal void ECCBBCDILEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class JIEMADNPEJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public BNHKDBJDOCC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public ICDMLJGKDGA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JIEMADNPEJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4EFD460", Offset = "0x4EFBA60", VA = "0x184EFD460")]
		internal void MIFKJOJPHDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class FMOBPOGODAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public BNHKDBJDOCC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public ICDMLJGKDGA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FMOBPOGODAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4EF70D0", Offset = "0x4EF56D0", VA = "0x184EF70D0")]
		internal void EEHKFGOHONJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class AMKJFBFOKOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public BNHKDBJDOCC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public ICDMLJGKDGA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AMKJFBFOKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4EEBAF0", Offset = "0x4EEA0F0", VA = "0x184EEBAF0")]
		internal void POJKOGAOGGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private const DOCAMAKLPOD IIGOIMOEDJO = DOCAMAKLPOD.Cancelled | DOCAMAKLPOD.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly EEJKPJOEJFO MJFHIMIBLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private bool[] PINLPBFHKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<DOCAMAKLPOD> FNHNAFDADOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<float> IKINPFLPOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> GMHCHHEJJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private NativeArray<int> HGAPCPLILBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private NativeArray<int> KAGFMBEOHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<int> KHFBILMGBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<int> PGAFMKGABGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private BNHKDBJDOCC[] HPLFJJDKLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private BKJDMHKMDDM[] OGLMBAFPCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private AAMOEBEEMHP[] DDOAGGBGBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private IEnumerator<FOLOHDFBANO>[] JIJNPJHGBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private FOLOHDFBANO[] CLECHGBHDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int JPCLLKDGLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int LEFNHMBHKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly int PHFNONJDNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float NDNMACCMOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private GDBIGNOGFII JNGEDAOOIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private JobHandle IJOKLFNDAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private List<BNHKDBJDOCC> AKNNALNCOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private bool ELGGDKMFGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private List<Action> GEMDBECFFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private List<Action> CDIFNAAMKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private bool GEPKLDAMACH;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public AHELPIMELBH[] EHBMJDBFKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xC94C10", Offset = "0xC93210", VA = "0x180C94C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4EFAF70", Offset = "0x4EF9570", VA = "0x184EFAF70")]
	private static int GPANGEMLLFD(EEJKPJOEJFO MJFHIMIBLCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB9B0", Offset = "0x4EF9FB0", VA = "0x184EFB9B0")]
	public ICDMLJGKDGA(EEJKPJOEJFO MJFHIMIBLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB410", Offset = "0x4EF9A10", VA = "0x184EFB410")]
	private void MMFDIAFNJPP(ref int MCMIDDNENEG, int FLKKHJKGEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x4EF99C0", Offset = "0x4EF7FC0", VA = "0x184EF99C0")]
	public void DLKJLEPFDOI(AAMOEBEEMHP MFPELEJLJLD, FOLOHDFBANO FAPKDOKCDKE, IEnumerator<FOLOHDFBANO> LODNPFDCPHG, BKJDMHKMDDM MOLFCCHMICC, [Optional] BNHKDBJDOCC ABHJCFKMEPF, DOCAMAKLPOD FBBMCADDGCH = DOCAMAKLPOD.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA4E0", Offset = "0x4EF8AE0", VA = "0x184EFA4E0")]
	public void EOEKDCMIPPI(IEnumerable<OJMLGBJIDNJ> DECJIGMIJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA740", Offset = "0x4EF8D40", VA = "0x184EFA740")]
	private OJMLGBJIDNJ FGENOBFEKOC(int KFLPDPGHEHP)
	{
		return default(OJMLGBJIDNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB600", Offset = "0x4EF9C00", VA = "0x184EFB600")]
	private void PJJJCGELBIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x11D43D0", Offset = "0x11D29D0", VA = "0x1811D43D0")]
	private static void PFJHDBLMEED<T>(int KFLPDPGHEHP, T[] CMEPFKLIPFA, int OCMPILAHMAJ, [Optional] T FADHLMDGELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x11D43B0", Offset = "0x11D29B0", VA = "0x1811D43B0")]
	private static void PFJHDBLMEED<T>(int KFLPDPGHEHP, NativeArray<T> CMEPFKLIPFA, int OCMPILAHMAJ, [Optional] T FADHLMDGELD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4EFACA0", Offset = "0x4EF92A0", VA = "0x184EFACA0")]
	private void GKGPCBLALGN(IEnumerable<OJMLGBJIDNJ> DECJIGMIJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4EF9710", Offset = "0x4EF7D10", VA = "0x184EF9710")]
	private void DBEACBEDANI(OJMLGBJIDNJ IJCHCLNFGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB0D0", Offset = "0x4EF96D0", VA = "0x184EFB0D0")]
	private MFOJFNAPGDL JCLENLCLHGG(int MHLIEGLDMGC)
	{
		return default(MFOJFNAPGDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4EF97E0", Offset = "0x4EF7DE0", VA = "0x184EF97E0")]
	public void DCBGAEKNIPL(float EPCCIIJAODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA6C0", Offset = "0x4EF8CC0", VA = "0x184EFA6C0")]
	private void FBJJAJCIJJG(Action GNJGFBLEGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB390", Offset = "0x4EF9990", VA = "0x184EFB390")]
	private void LLFLEEEDKLO(Action GNJGFBLEGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x4EF9DA0", Offset = "0x4EF83A0", VA = "0x184EF9DA0")]
	public void EMIBMJIBIFA(float EPCCIIJAODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x4EF9610", Offset = "0x4EF7C10", VA = "0x184EF9610")]
	public void CDAHFAFMGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x4EFAFA0", Offset = "0x4EF95A0", VA = "0x184EFAFA0")]
	public void HGKDEANLLDM(BNHKDBJDOCC IAHDICGADGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x4EF9C70", Offset = "0x4EF8270", VA = "0x184EF9C70")]
	public void EDGKEDMPPOG(BNHKDBJDOCC IAHDICGADGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4EF9B40", Offset = "0x4EF8140", VA = "0x184EF9B40")]
	public void DLMCJNEGLIA(BNHKDBJDOCC IAHDICGADGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class MHBKJOIOEFH : PCMFGKMGMHE, IEnumerable<PCMFGKMGMHE>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<PCMFGKMGMHE> EEMHIDHJHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private bool FMLLPICPDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private Action AFJMNPFPPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private bool EKDKNPLOMBK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool NFODMIKHPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4F00CF0", Offset = "0x4EFF2F0", VA = "0x184F00CF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LENDDNNNIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4F00A70", Offset = "0x4EFF070", VA = "0x184F00A70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4F006D0", Offset = "0x4EFECD0", VA = "0x184F006D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4F00FD0", Offset = "0x4EFF5D0", VA = "0x184F00FD0")]
	public MHBKJOIOEFH([Optional] Action AFJMNPFPPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4F00E30", Offset = "0x4EFF430", VA = "0x184F00E30")]
	public void PDDBDHJNBOH(PCMFGKMGMHE OONEENHAPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4F00B90", Offset = "0x4EFF190", VA = "0x184F00B90")]
	private void HGLJACNCHLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4F00770", Offset = "0x4EFED70", VA = "0x184F00770", Slot = "7")]
	public bool DBGKGFLGOLO(bool ODPLBAPFKKP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4F00790", Offset = "0x4EFED90", VA = "0x184F00790", Slot = "8")]
	public bool DBGKGFLGOLO(Action ILLCNPCAHGD, bool ODPLBAPFKKP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4F00B10", Offset = "0x4EFF110", VA = "0x184F00B10", Slot = "9")]
	public IEnumerator<PCMFGKMGMHE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4F00F50", Offset = "0x4EFF550", VA = "0x184F00F50", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class HOFHCHACPKK : PCMFGKMGMHE
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class EDIADNDCIEC : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public HOFHCHACPKK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public EDIADNDCIEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4EF64F0", Offset = "0x4EF4AF0", VA = "0x184EF64F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4EF65C0", Offset = "0x4EF4BC0", VA = "0x184EF65C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly Behaviour MFPELEJLJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Action AFJMNPFPPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private HLPKALPBBAA AGIOOGMPDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly CDNNNIJHPJN EBLGJABNHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	protected readonly HAMBOJBIPBK EAGIJCLINCN;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool NFODMIKHPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1B5CD90", Offset = "0x1B5B390", VA = "0x181B5CD90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LENDDNNNIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4EF8640", Offset = "0x4EF6C40", VA = "0x184EF8640", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4EF84F0", Offset = "0x4EF6AF0", VA = "0x184EF84F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8A40", Offset = "0x4EF7040", VA = "0x184EF8A40")]
	protected HOFHCHACPKK(Behaviour MFPELEJLJLD, [Optional] Action AFJMNPFPPLP, [Optional] CDNNNIJHPJN EBLGJABNHNN, [Optional] HAMBOJBIPBK EAGIJCLINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8590", Offset = "0x4EF6B90", VA = "0x184EF8590", Slot = "7")]
	public bool DBGKGFLGOLO(bool ODPLBAPFKKP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4EF85F0", Offset = "0x4EF6BF0", VA = "0x184EF85F0", Slot = "8")]
	public bool DBGKGFLGOLO(Action ILLCNPCAHGD, bool ODPLBAPFKKP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool IOBEOCEGJHJ(Action ILLCNPCAHGD);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool BGBDPGJNFBL(Action ILLCNPCAHGD);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8920", Offset = "0x4EF6F20", VA = "0x184EF8920")]
	protected void GBJHEBHDCFD(Action ILLCNPCAHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4EF86E0", Offset = "0x4EF6CE0", VA = "0x184EF86E0")]
	protected HHGLIBCDIDA FJDCDPHOCLJ(float NJGFFBPLEDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4EF89C0", Offset = "0x4EF6FC0", VA = "0x184EF89C0")]
	private void HFLGFPPGJGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8940", Offset = "0x4EF6F40", VA = "0x184EF8940")]
	[IteratorStateMachine(typeof(EDIADNDCIEC))]
	private IEnumerator<FOLOHDFBANO> GPAONFKGCKK(float NJGFFBPLEDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x4EF88E0", Offset = "0x4EF6EE0", VA = "0x184EF88E0")]
	[CompilerGenerated]
	private void GAAPNJNNAJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Flags]
internal enum DOCAMAKLPOD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class BNHKDBJDOCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public ICDMLJGKDGA PDIOMAHPAJH;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int FIFIFGFPIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1A0", Offset = "0x7E87A0", VA = "0x1807EA1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E30", Offset = "0x9B5430", VA = "0x1809B6E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE170", Offset = "0x4EEC770", VA = "0x184EEE170")]
	public static FOLOHDFBANO IGHDEFFNEAA(IEnumerator<FOLOHDFBANO> LODNPFDCPHG, BKJDMHKMDDM MOLFCCHMICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE320", Offset = "0x4EEC920", VA = "0x184EEE320")]
	public FOLOHDFBANO IGHDEFFNEAA(BKJDMHKMDDM[] OGLMBAFPCHB, IEnumerator<FOLOHDFBANO>[] NJDGCEMGLCG, FOLOHDFBANO[] CFMONOAGGHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE000", Offset = "0x4EEC600", VA = "0x184EEE000")]
	public void BMBNGMNEPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE030", Offset = "0x4EEC630", VA = "0x184EEE030")]
	public void CDFGGIOKDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE400", Offset = "0x4EECA00", VA = "0x184EEE400")]
	public void LAICGDBPOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE000", Offset = "0x4EEC600", VA = "0x184EEE000")]
	public void HGKDEANLLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public BNHKDBJDOCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class LHHHNEGAPGI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class GHIHDOCNAFL : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public LHHHNEGAPGI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public GHIHDOCNAFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4EF7F40", Offset = "0x4EF6540", VA = "0x184EF7F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4EF7FD0", Offset = "0x4EF65D0", VA = "0x184EF7FD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly EEJKPJOEJFO MJFHIMIBLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private Action BFLBNJCLDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private bool HIMFHHIKDDO;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool PDNJDHBDFON
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9B4500", Offset = "0x9B2B00", VA = "0x1809B4500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4EFFC30", Offset = "0x4EFE230", VA = "0x184EFFC30")]
	public LHHHNEGAPGI(EEJKPJOEJFO MJFHIMIBLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4EFFB40", Offset = "0x4EFE140", VA = "0x184EFFB40")]
	[IteratorStateMachine(typeof(GHIHDOCNAFL))]
	private IEnumerator<FOLOHDFBANO> HPEJMHEKIOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4EFFBB0", Offset = "0x4EFE1B0", VA = "0x184EFFBB0", Slot = "4")]
	public void OnCompleted(Action NMLNBLBFOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public void ILLGNLEGDMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class KPBPIFFPPON
{
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF800", Offset = "0x4EFDE00", VA = "0x184EFF800")]
	public static LHHHNEGAPGI FCNMHLHACAM(this EEJKPJOEJFO MJFHIMIBLCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal class FNGPPNBNMFD : OPJGCLOLEJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly CDNNNIJHPJN EBLGJABNHNN;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4EF71C0", Offset = "0x4EF57C0", VA = "0x184EF71C0")]
	[HFALCAKMDCP(BFPOMPMIJIJ.None)]
	private static void KDCCKDGHAKL(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	[Preserve]
	internal FNGPPNBNMFD([BBBJPGKHPHG(null)] CDNNNIJHPJN EBLGJABNHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7230", Offset = "0x4EF5830", VA = "0x184EF7230", Slot = "4")]
	public IDisposable KEGBDBDPKCK(float FPFLCIJEDLJ, Action<float> AJNAMFOHMMI, bool CLLBGJCHLCH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal enum MFOJFNAPGDL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class PGMIJLMGAJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum IPKLDKENLFK
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct HDPGBHNBELF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public EEJKPJOEJFO IDDHLAEFLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public IPKLDKENLFK EAEHDMPNFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public List<CPKJPDJNKGN> DHDHBOGKBBF;
	}

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static readonly IPKLDKENLFK[] ABDCENFPLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly EEJKPJOEJFO MJFHIMIBLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private bool EAKEEBJFDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly CPKJPDJNKGN[] BBOOGIIFOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly List<CPKJPDJNKGN> ENHBKGDILGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly Stack<int> DDANMEPOACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<CPKJPDJNKGN> KNJEDFMPAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> BGMBJOKOOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly FOGDKGBKGAH ELHNBPGPKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private bool GEPKLDAMACH;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public HDPGBHNBELF[,] PMNIJHBMDED
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4F05240", Offset = "0x4F03840", VA = "0x184F05240")]
	public PGMIJLMGAJB(EEJKPJOEJFO OBJFKAPAMCI, FOGDKGBKGAH ELHNBPGPKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4F04140", Offset = "0x4F02740", VA = "0x184F04140")]
	public void FECMDOJMIFD(CPKJPDJNKGN LODNPFDCPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4F043B0", Offset = "0x4F029B0", VA = "0x184F043B0")]
	public void IPNMMPIEPEH(IList<CPKJPDJNKGN> NJDGCEMGLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4F04680", Offset = "0x4F02C80", VA = "0x184F04680")]
	public void JANLIKNJINE(IList<CPKJPDJNKGN> NJDGCEMGLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4F04CF0", Offset = "0x4F032F0", VA = "0x184F04CF0")]
	private void NAOPLHFFDIP(CPKJPDJNKGN LODNPFDCPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4F04950", Offset = "0x4F02F50", VA = "0x184F04950")]
	private void KCDAPJANAIE(IList<CPKJPDJNKGN> NJDGCEMGLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4F03D70", Offset = "0x4F02370", VA = "0x184F03D70")]
	private MFOJFNAPGDL CGHFEMOFGNK(CPKJPDJNKGN LODNPFDCPHG)
	{
		return default(MFOJFNAPGDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4F04260", Offset = "0x4F02860", VA = "0x184F04260")]
	public void GFCEDFCLACE(float EPCCIIJAODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F04AE0", Offset = "0x4F030E0", VA = "0x184F04AE0")]
	public void LJBKMHFBEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F04DF0", Offset = "0x4F033F0", VA = "0x184F04DF0")]
	private void POEDFIKHKAI(List<CPKJPDJNKGN> NJDGCEMGLCG, Stack<int> DGNAPIIKGNE, bool OOALMBLLKNP, float CHAHIMBMHBJ = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F04000", Offset = "0x4F02600", VA = "0x184F04000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4F03ED0", Offset = "0x4F024D0", VA = "0x184F03ED0")]
	private void CKBIMJPMKID(List<CPKJPDJNKGN> NJDGCEMGLCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class AJCHDFNPHJI : FHBNELNKPHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly Behaviour CPDPMINGACC;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB780", Offset = "0x4EE9D80", VA = "0x184EEB780", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool GPMIMPNPLNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB720", Offset = "0x4EE9D20", VA = "0x184EEB720", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MBNKNEENGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB810", Offset = "0x4EE9E10", VA = "0x184EEB810", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	public AJCHDFNPHJI(Behaviour CPDPMINGACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class NFNPNGLDMPI : HOFHCHACPKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly float IGDKKHKABHH;

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8D40", Offset = "0x4EF7340", VA = "0x184EF8D40")]
	public NFNPNGLDMPI(Behaviour MFPELEJLJLD, float IGDKKHKABHH, [Optional] Action AFJMNPFPPLP, [Optional] CDNNNIJHPJN EBLGJABNHNN, [Optional] HAMBOJBIPBK EAGIJCLINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x928C00", Offset = "0x927200", VA = "0x180928C00", Slot = "9")]
	protected override bool IOBEOCEGJHJ(Action ILLCNPCAHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4F01F30", Offset = "0x4F00530", VA = "0x184F01F30", Slot = "10")]
	protected override bool BGBDPGJNFBL(Action ILLCNPCAHGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class JBMAODHJAPA
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4EFC930", Offset = "0x4EFAF30", VA = "0x184EFC930")]
	public static IDisposable CAJCPALFPLE(this AAMOEBEEMHP MFPELEJLJLD, float FPFLCIJEDLJ, Action<float> GBAHNMCMAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4EFC9B0", Offset = "0x4EFAFB0", VA = "0x184EFC9B0")]
	public static IDisposable FGNEOMFGEEP(this AAMOEBEEMHP MFPELEJLJLD, Action<float> GBAHNMCMAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4EFCA30", Offset = "0x4EFB030", VA = "0x184EFCA30")]
	public static IDisposable IAAIIAIDMCN(this AAMOEBEEMHP MFPELEJLJLD, Action<float> GBAHNMCMAEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class PMACBOBNGFP
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class CBPBCIMDIMC : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public EEJKPJOEJFO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private JPDNCNLBOAJ <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public CBPBCIMDIMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4EEE540", Offset = "0x4EECB40", VA = "0x184EEE540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4EEE610", Offset = "0x4EECC10", VA = "0x184EEE610", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class BNFLPHIFBOJ : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public EEJKPJOEJFO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private JPDNCNLBOAJ <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public BNFLPHIFBOJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4EEDED0", Offset = "0x4EEC4D0", VA = "0x184EEDED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4EEDFC0", Offset = "0x4EEC5C0", VA = "0x184EEDFC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4F058D0", Offset = "0x4F03ED0", VA = "0x184F058D0")]
	public static BDPNFFCBKDC GOLAFFBMBON(Action GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4F05810", Offset = "0x4F03E10", VA = "0x184F05810")]
	public static BDPNFFCBKDC GOLAFFBMBON(Behaviour MFPELEJLJLD, Action GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4F05980", Offset = "0x4F03F80", VA = "0x184F05980")]
	public static BDPNFFCBKDC GOLAFFBMBON(Behaviour MFPELEJLJLD, Action<float> GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4F05790", Offset = "0x4F03D90", VA = "0x184F05790")]
	[IteratorStateMachine(typeof(CBPBCIMDIMC))]
	private static IEnumerator<FOLOHDFBANO> ECHMMNHNHCG(EEJKPJOEJFO OBJFKAPAMCI, Action GBAHNMCMAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4F05710", Offset = "0x4F03D10", VA = "0x184F05710")]
	[IteratorStateMachine(typeof(BNFLPHIFBOJ))]
	private static IEnumerator<FOLOHDFBANO> ECHMMNHNHCG(EEJKPJOEJFO OBJFKAPAMCI, Action<float> GBAHNMCMAEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class NFAOGMIGDKM
{
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4F01770", Offset = "0x4EFFD70", VA = "0x184F01770")]
	public static IDisposable GOLAFFBMBON(this MonoBehaviour CPDPMINGACC, Action GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4F017F0", Offset = "0x4EFFDF0", VA = "0x184F017F0")]
	public static IDisposable GOLAFFBMBON(this MonoBehaviour CPDPMINGACC, Action<float> GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4F01680", Offset = "0x4EFFC80", VA = "0x184F01680")]
	public static IDisposable GFCEDFCLACE(this MonoBehaviour CPDPMINGACC, Action GBAHNMCMAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4F01EB0", Offset = "0x4F004B0", VA = "0x184F01EB0")]
	public static IDisposable POMPHFNABOH(this MonoBehaviour CPDPMINGACC, Action GBAHNMCMAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4F01600", Offset = "0x4EFFC00", VA = "0x184F01600")]
	public static IDisposable DOAPFPPDFEJ(this MonoBehaviour CPDPMINGACC, Action GBAHNMCMAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x4F016F0", Offset = "0x4EFFCF0", VA = "0x184F016F0")]
	public static IDisposable GKJDMAOFINF(this MonoBehaviour CPDPMINGACC, Action GBAHNMCMAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4F01B60", Offset = "0x4F00160", VA = "0x184F01B60")]
	public static IDisposable LBLOPNAABGG(this MonoBehaviour CPDPMINGACC, Action GBAHNMCMAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4F01AC0", Offset = "0x4F000C0", VA = "0x184F01AC0")]
	public static IDisposable KJCMMFFILAE(this MonoBehaviour CPDPMINGACC, float FPFLCIJEDLJ, Action<float> GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ, bool CLLBGJCHLCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4F01BE0", Offset = "0x4F001E0", VA = "0x184F01BE0")]
	public static IDisposable NHHJNBJAADF(this MonoBehaviour CPDPMINGACC, float FPFLCIJEDLJ, Action<float> GBAHNMCMAEE, EEJKPJOEJFO MJFHIMIBLCJ, bool CLLBGJCHLCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4F01A20", Offset = "0x4F00020", VA = "0x184F01A20")]
	public static IDisposable KEGBDBDPKCK(this MonoBehaviour CPDPMINGACC, float FPFLCIJEDLJ, Action<float> GBAHNMCMAEE, bool CLLBGJCHLCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4F01900", Offset = "0x4EFFF00", VA = "0x184F01900")]
	public static IDisposable INHGPIBMBJB(this MonoBehaviour CPDPMINGACC, Action<float> GBAHNMCMAEE, bool CLLBGJCHLCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4F01990", Offset = "0x4EFFF90", VA = "0x184F01990")]
	public static IDisposable JOPHFINCEKA(this MonoBehaviour CPDPMINGACC, Action<float> GBAHNMCMAEE, bool CLLBGJCHLCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4F01870", Offset = "0x4EFFE70", VA = "0x184F01870")]
	public static IDisposable HGIMCFAIGBG(this MonoBehaviour CPDPMINGACC, Action<float> GBAHNMCMAEE, bool CLLBGJCHLCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4F01D00", Offset = "0x4F00300", VA = "0x184F01D00")]
	public static IDisposable NJPCNNNGEFL(this MonoBehaviour CPDPMINGACC, Action<float> GBAHNMCMAEE, bool CLLBGJCHLCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4F01E20", Offset = "0x4F00420", VA = "0x184F01E20")]
	public static IDisposable PEAPLAPBJDN(this MonoBehaviour CPDPMINGACC, Action<float> GBAHNMCMAEE, bool CLLBGJCHLCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4F01D90", Offset = "0x4F00390", VA = "0x184F01D90")]
	public static IDisposable NLNPPFDFHLP(this MonoBehaviour CPDPMINGACC, Action<float> GBAHNMCMAEE, bool CLLBGJCHLCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4F01570", Offset = "0x4EFFB70", VA = "0x184F01570")]
	public static IDisposable DAJPGFJOJIJ(this MonoBehaviour CPDPMINGACC, Action<float> GBAHNMCMAEE, bool CLLBGJCHLCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4F014D0", Offset = "0x4EFFAD0", VA = "0x184F014D0")]
	public static IDisposable AOMBGIOGHKL(this MonoBehaviour CPDPMINGACC, float FPFLCIJEDLJ, Action<float> GBAHNMCMAEE, bool CLLBGJCHLCH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class BKJDMHKMDDM : LLDACAIIDPN, BDPNFFCBKDC, HLPKALPBBAA, HHGLIBCDIDA, IEnumerator, FOLOHDFBANO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private EEJKPJOEJFO IMMCEDLONOG;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private EEJKPJOEJFO PMNFIIPGKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xE95670", Offset = "0xE93C70", VA = "0x180E95670", Slot = "23")]
		get
		{
			return default(EEJKPJOEJFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public EEJKPJOEJFO PDIOMAHPAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xBBB300", Offset = "0xBB9900", VA = "0x180BBB300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private float FJOPLCKIADD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xE0E2D0", Offset = "0xE0C8D0", VA = "0x180E0E2D0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool AJDGINIEIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDE50", Offset = "0x4EEC450", VA = "0x184EEDE50", Slot = "24")]
	private bool MCLGMEHACAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDE40", Offset = "0x4EEC440", VA = "0x184EEDE40", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDE70", Offset = "0x4EEC470", VA = "0x184EEDE70")]
	public BKJDMHKMDDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal interface FHBNELNKPHG
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool GPMIMPNPLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool MBNKNEENGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class ANNCGEEMKMO
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class EGDOPECKKBH : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public EEJKPJOEJFO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public EGDOPECKKBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4EF6600", Offset = "0x4EF4C00", VA = "0x184EF6600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4EF6670", Offset = "0x4EF4C70", VA = "0x184EF6670", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class CHKAJJIIFJL : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public EEJKPJOEJFO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private FOLOHDFBANO <wait>5__1;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public CHKAJJIIFJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4EEE730", Offset = "0x4EECD30", VA = "0x184EEE730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4EEE7C0", Offset = "0x4EECDC0", VA = "0x184EEE7C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC090", Offset = "0x4EEA690", VA = "0x184EEC090")]
	[IteratorStateMachine(typeof(EGDOPECKKBH))]
	private static IEnumerator<FOLOHDFBANO> HPEJMHEKIOP(float MIKGPKAPCMA, EEJKPJOEJFO OBJFKAPAMCI, Action JHHCIKOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC120", Offset = "0x4EEA720", VA = "0x184EEC120")]
	[IteratorStateMachine(typeof(CHKAJJIIFJL))]
	private static IEnumerator<FOLOHDFBANO> IBIDJDDDJHN(float MIKGPKAPCMA, EEJKPJOEJFO OBJFKAPAMCI, Action JHHCIKOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBE70", Offset = "0x4EEA470", VA = "0x184EEBE70")]
	public static IDisposable FMJPDBOGIBM(this MonoBehaviour CPDPMINGACC, float MIKGPKAPCMA, Action JHHCIKOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC1B0", Offset = "0x4EEA7B0", VA = "0x184EEC1B0")]
	public static BDPNFFCBKDC IEIGAPCAOGO(this MonoBehaviour CPDPMINGACC, float MIKGPKAPCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBD40", Offset = "0x4EEA340", VA = "0x184EEBD40")]
	public static BDPNFFCBKDC FMJPDBOGIBM(this MonoBehaviour CPDPMINGACC, float MIKGPKAPCMA, EEJKPJOEJFO OBJFKAPAMCI, Action JHHCIKOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC270", Offset = "0x4EEA870", VA = "0x184EEC270")]
	public static BDPNFFCBKDC IINIAJBMGAN(this MonoBehaviour CPDPMINGACC, Action JHHCIKOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC360", Offset = "0x4EEA960", VA = "0x184EEC360")]
	public static BDPNFFCBKDC KJLMPEFGBAA(this MonoBehaviour CPDPMINGACC, Action JHHCIKOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBB60", Offset = "0x4EEA160", VA = "0x184EEBB60")]
	public static BDPNFFCBKDC CGOAHNCJDOP(this MonoBehaviour CPDPMINGACC, Action JHHCIKOIKGO, [Optional] CDNNNIJHPJN EBLGJABNHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBD10", Offset = "0x4EEA310", VA = "0x184EEBD10")]
	public static BDPNFFCBKDC DJNJLGOBIAL(this MonoBehaviour CPDPMINGACC, Action JHHCIKOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBF90", Offset = "0x4EEA590", VA = "0x184EEBF90")]
	public static BDPNFFCBKDC GKAMBBEOCKC(this MonoBehaviour CPDPMINGACC, Action JHHCIKOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBB30", Offset = "0x4EEA130", VA = "0x184EEBB30")]
	public static BDPNFFCBKDC BFFLKBFLBJC(this MonoBehaviour CPDPMINGACC, Action JHHCIKOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC290", Offset = "0x4EEA890", VA = "0x184EEC290")]
	private static BDPNFFCBKDC JMEIABDDMII(MonoBehaviour CPDPMINGACC, EEJKPJOEJFO MJFHIMIBLCJ, Action JHHCIKOIKGO, [Optional] CDNNNIJHPJN EBLGJABNHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC460", Offset = "0x4EEAA60", VA = "0x184EEC460")]
	public static BDPNFFCBKDC OHGLMFIONPE(this MonoBehaviour CPDPMINGACC, float MGKDAICOOMC, Action JHHCIKOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBFC0", Offset = "0x4EEA5C0", VA = "0x184EEBFC0")]
	public static BDPNFFCBKDC HKADKPGOMLM(this MonoBehaviour CPDPMINGACC, float MGKDAICOOMC, Action JHHCIKOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBC40", Offset = "0x4EEA240", VA = "0x184EEBC40")]
	public static BDPNFFCBKDC DGCJOFNIEHO(this MonoBehaviour CPDPMINGACC, float MGKDAICOOMC, Action JHHCIKOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC390", Offset = "0x4EEA990", VA = "0x184EEC390")]
	public static BDPNFFCBKDC KPKMCAIIIBH(this MonoBehaviour CPDPMINGACC, float MGKDAICOOMC, Action JHHCIKOIKGO)
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

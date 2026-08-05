using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AA86C0", Offset = "0x8AA6EC0", VA = "0x188AA86C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private delegate List<PlayerLoopSystem> AAOEBJEODHL(List<PlayerLoopSystem> FGMKJGMCFIE, int AAGKECMIEMO);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct OAGPOJDDANO
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct LIEIABLDGBA
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static KECNPIDOCPH HNHPKILAPDO;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x8AA1C40", Offset = "0x8AA0440", VA = "0x188AA1C40")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct HFELOMDFPOI
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static KECNPIDOCPH KHGNLILEMBI;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8A9E820", Offset = "0x8A9D020", VA = "0x188A9E820")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct FFJACAJELKB
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static KECNPIDOCPH OOFHGDKJBMJ;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x8A9B610", Offset = "0x8A99E10", VA = "0x188A9B610")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct MKCCOJLLHNP
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static KECNPIDOCPH OHKAAPBBKJA;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static KECNPIDOCPH EDNKGBEAKDI;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static KECNPIDOCPH AHEJAHFLGKA;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static KECNPIDOCPH OEMGHGODJIO;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x8AA2A80", Offset = "0x8AA1280", VA = "0x188AA2A80")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct ELMMBOKDKOH
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static KECNPIDOCPH PPLHKANFNJO;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x8A9AFE0", Offset = "0x8A997E0", VA = "0x188A9AFE0")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct FMLOMLNAHED
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static KECNPIDOCPH OHKAAPBBKJA;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static KECNPIDOCPH EDNKGBEAKDI;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static KECNPIDOCPH AHEJAHFLGKA;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static KECNPIDOCPH OEMGHGODJIO;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x8A9B7F0", Offset = "0x8A99FF0", VA = "0x188A9B7F0")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct IEPBJALGDCH
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static KECNPIDOCPH FIDLLKBDPPG;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x8A9EE20", Offset = "0x8A9D620", VA = "0x188A9EE20")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct LGFMMIPIDMM
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static KECNPIDOCPH EIPANADEOPJ;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x8AA1A60", Offset = "0x8AA0260", VA = "0x188AA1A60")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct JLFOJOPCLKC
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static KECNPIDOCPH OBJKFNKELCA;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x8A9FA40", Offset = "0x8A9E240", VA = "0x188A9FA40")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct MMMPKOAGJJN
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static KECNPIDOCPH IMMEHDIDLDP;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x8AA4250", Offset = "0x8AA2A50", VA = "0x188AA4250")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct IDEGFFKMJJF
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static KECNPIDOCPH LJCNAPIDNJE;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x8A9EA80", Offset = "0x8A9D280", VA = "0x188A9EA80")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct HCDGLILILCI
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static KECNPIDOCPH OBHGPHCEICM;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x8A9E3D0", Offset = "0x8A9CBD0", VA = "0x188A9E3D0")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct DHBHJBINPCF
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static KECNPIDOCPH BHOAJOBHPMD;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x8A99790", Offset = "0x8A97F90", VA = "0x188A99790")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct OHGCGPGDHIL
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static KECNPIDOCPH OEDEHLHMOLF;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x8AA63C0", Offset = "0x8AA4BC0", VA = "0x188AA63C0")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public struct PFCDLGNLBDH
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static KECNPIDOCPH ADOHOIDJDKF;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x8AA6730", Offset = "0x8AA4F30", VA = "0x188AA6730")]
				public static PlayerLoopSystem HKOLLKMBELM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public enum FGNPILCLFBP : byte
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
			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public struct IEDMIMLNEMK
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class HFHCGHDPBJE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public FGNPILCLFBP updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
					public HFHCGHDPBJE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0x8A9EA00", Offset = "0x8A9D200", VA = "0x188A9EA00")]
					internal void KOGFHOGELPH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static LBOAOFAOKMM<FGNPILCLFBP> PPMLGFOKIPH;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x8A9EC60", Offset = "0x8A9D460", VA = "0x188A9EC60")]
				public static PlayerLoopSystem HKOLLKMBELM(FGNPILCLFBP HFGLNAGBPLP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000027")]
			internal struct DNHPELIFKKM
			{
				[Cpp2IlInjected.Token(Token = "0x2000028")]
				[CompilerGenerated]
				private sealed class JELJGNLBMCB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public IFKAENCOIEP.CCJFLJEGOAF key;

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
					public JELJGNLBMCB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005E")]
					[Cpp2IlInjected.Address(RVA = "0x8A9F640", Offset = "0x8A9DE40", VA = "0x188A9F640")]
					internal void DKPLGNJNFDH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable NIBEFAAMLIO;

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x8A99CC0", Offset = "0x8A984C0", VA = "0x188A99CC0")]
				public static PlayerLoopSystem MJFCJEHCBCB(IFKAENCOIEP.CCJFLJEGOAF MNMCNOJCKAF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002A")]
			internal struct IJEMILGEEHJ
			{
				[Cpp2IlInjected.Token(Token = "0x200002B")]
				[CompilerGenerated]
				private sealed class KDIEGGMAGCB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public IFKAENCOIEP.CCJFLJEGOAF key;

					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
					public KDIEGGMAGCB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x8A9FE30", Offset = "0x8A9E630", VA = "0x188A9FE30")]
					internal void DKPLGNJNFDH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x8A9F3F0", Offset = "0x8A9DBF0", VA = "0x188A9F3F0")]
				public static PlayerLoopSystem MJFCJEHCBCB(IFKAENCOIEP.CCJFLJEGOAF MNMCNOJCKAF)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class IPCCMCGEHFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public IPCCMCGEHFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F520", Offset = "0x8A9DD20", VA = "0x188A9F520")]
			internal List<PlayerLoopSystem> BAPCDCDMJKG(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool CMBGAOFOBDI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool PAFOPNDMBFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8A98620", Offset = "0x8A96E20", VA = "0x188A98620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A94990", Offset = "0x8A93190", VA = "0x188A94990")]
		private static void BONMJKILJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A97AD0", Offset = "0x8A962D0", VA = "0x188A97AD0")]
		private static void DMDMBLECHKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A94950", Offset = "0x8A93150", VA = "0x188A94950")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A983E0", Offset = "0x8A96BE0", VA = "0x188A983E0")]
		private static void DONALJPDPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A98A40", Offset = "0x8A97240", VA = "0x188A98A40")]
		private static void LODKJJNEMLJ(IFKAENCOIEP.CCJFLJEGOAF MNMCNOJCKAF, PlayerLoopSystem IBLOKAMOHAI, Type AAJJFDBPKCI, Type LGMFKDPOCOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8A98660", Offset = "0x8A96E60", VA = "0x188A98660")]
		private static void FKKLCHBBNAE(PlayerLoopSystem IBLOKAMOHAI, Type AAJJFDBPKCI, Type LGMFKDPOCOH, AAOEBJEODHL CIJPHNCLNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A979A0", Offset = "0x8A961A0", VA = "0x188A979A0")]
		private static void DACFMOGPICH(PlayerLoopSystem IBLOKAMOHAI, Type AAJJFDBPKCI, Type LGMFKDPOCOH, PlayerLoopSystem? PJJCONMFOMA, PlayerLoopSystem? IIGFEGKPHIC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class IFKAENCOIEP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum CCJFLJEGOAF
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

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class ELLAHANGOLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly CCJFLJEGOAF LOHDNDKJNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly EECJLJDLJNI JIJOGEOLBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long MPMGKJIPPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long LKCOJPPKPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long GKJMNHBFFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int NCJNICDPIAI;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A9AF50", Offset = "0x8A99750", VA = "0x188A9AF50")]
		public ELLAHANGOLK(CCJFLJEGOAF LLFKBFEBHMB, int KMDOFHCNPBA = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8A9AE00", Offset = "0x8A99600", VA = "0x188A9AE00")]
		public void DLHIHOADJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A9AF00", Offset = "0x8A99700", VA = "0x188A9AF00")]
		public void LAOIFANDFHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A9AE20", Offset = "0x8A99620", VA = "0x188A9AE20")]
		public void IJMKBHIPMOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static CCJFLJEGOAF[] PAKFKICIHFD;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static ELLAHANGOLK[] JKLNBLFFMIO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8A9F070", Offset = "0x8A9D870", VA = "0x188A9F070")]
	public static ELLAHANGOLK KJBIKLODOEJ(CCJFLJEGOAF MNMCNOJCKAF, int KMDOFHCNPBA = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8A9F000", Offset = "0x8A9D800", VA = "0x188A9F000")]
	public static ELLAHANGOLK HCIMFFPNIAF(CCJFLJEGOAF MNMCNOJCKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8A9F1C0", Offset = "0x8A9D9C0", VA = "0x188A9F1C0")]
	public static void LGAIFNCLICA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GCJCBKHKHOL
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface PMFHEJFIIAC
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool BOKNEKEAPFB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BFIAMMMMINP();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class MDKCPOOJDDH : PMFHEJFIIAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action AMNCPNDDCLP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool BOKNEKEAPFB
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
		public MDKCPOOJDDH(Action AMNCPNDDCLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x119A3C0", Offset = "0x1198BC0", VA = "0x18119A3C0", Slot = "5")]
		public void BFIAMMMMINP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<PMFHEJFIIAC> DKHPFAAJIBD;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8A9BFB0", Offset = "0x8A9A7B0", VA = "0x188A9BFB0")]
	public static void LEGPNMCMIGC(Action AMNCPNDDCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8A9BCA0", Offset = "0x8A9A4A0", VA = "0x188A9BCA0")]
	private static void HNDFBDEFIOB(PMFHEJFIIAC PBBHEIMHBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C120", Offset = "0x8A9A920", VA = "0x188A9C120")]
	private static void NMNKFEIFFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8A9BEB0", Offset = "0x8A9A6B0", VA = "0x188A9BEB0")]
	private static void JPCPGCIPHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C050", Offset = "0x8A9A850", VA = "0x188A9C050")]
	private static void LPBLAHHNDDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class ONLHJFKFEAB
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8AA65A0", Offset = "0x8AA4DA0", VA = "0x188AA65A0")]
	public static IDisposable HACLOKPKBLD(this NJIBLDPNMNG MJAGIMDGJBK, float JMJDPMIONDE, Action<float> EJIFHEKNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8AA6630", Offset = "0x8AA4E30", VA = "0x188AA6630")]
	public static IDisposable LIOECDOIFGM(this NJIBLDPNMNG MJAGIMDGJBK, Action<float> EJIFHEKNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8AA66B0", Offset = "0x8AA4EB0", VA = "0x188AA66B0")]
	public static IDisposable OMLLKGDEGAL(this NJIBLDPNMNG MJAGIMDGJBK, Action<float> EJIFHEKNDCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class GCBAEKAAOKC
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x39E2410", Offset = "0x39E0C10", VA = "0x1839E2410")]
	[IHLPLPGOHPJ]
	public static IDisposable LFCDJPIKPJG<T>(this T GIJIHCLGELM, Action EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x39E25C0", Offset = "0x39E0DC0", VA = "0x1839E25C0")]
	[IHLPLPGOHPJ]
	public static IDisposable LFCDJPIKPJG<T>(this T GIJIHCLGELM, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x39E23D0", Offset = "0x39E0BD0", VA = "0x1839E23D0")]
	[IHLPLPGOHPJ]
	public static IDisposable JNHFKCNMNLI<T>(this T GIJIHCLGELM, Action EJIFHEKNDCL, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x39E2060", Offset = "0x39E0860", VA = "0x1839E2060")]
	[IHLPLPGOHPJ]
	public static IDisposable CFMNFMICCDL<T>(this T GIJIHCLGELM, Action EJIFHEKNDCL, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x39E2060", Offset = "0x39E0860", VA = "0x1839E2060")]
	[IHLPLPGOHPJ]
	public static IDisposable CFMNFMICCDL<T>(this T GIJIHCLGELM, Action<float> EJIFHEKNDCL, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x39E2200", Offset = "0x39E0A00", VA = "0x1839E2200")]
	[IHLPLPGOHPJ]
	public static IDisposable GPKIGBAJFGB<T>(this T GIJIHCLGELM, Action EJIFHEKNDCL, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x39E2A20", Offset = "0x39E1220", VA = "0x1839E2A20")]
	[IHLPLPGOHPJ]
	public static IDisposable PEJJKIIIIIG<T>(this T GIJIHCLGELM, Action EJIFHEKNDCL, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x39E29D0", Offset = "0x39E11D0", VA = "0x1839E29D0")]
	[IHLPLPGOHPJ]
	public static IDisposable OCEBPCNCGIE<T>(this T GIJIHCLGELM, Action EJIFHEKNDCL, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x39E21C0", Offset = "0x39E09C0", VA = "0x1839E21C0")]
	[IHLPLPGOHPJ]
	public static IDisposable GCAKNIEBOIM<T>(this T GIJIHCLGELM, float JMJDPMIONDE, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8A9BAC0", Offset = "0x8A9A2C0", VA = "0x188A9BAC0")]
	[IHLPLPGOHPJ]
	public static IDisposable GCAKNIEBOIM(this MonoBehaviour GIJIHCLGELM, GKEGMHGFIBN MJAGIMDGJBK, float JMJDPMIONDE, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x39E2770", Offset = "0x39E0F70", VA = "0x1839E2770")]
	[IHLPLPGOHPJ]
	public static IDisposable MOMKHOJPIEE<T>(this T GIJIHCLGELM, float JMJDPMIONDE, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x39E20B0", Offset = "0x39E08B0", VA = "0x1839E20B0")]
	[IHLPLPGOHPJ]
	public static IDisposable EAENHDGKAFL<T>(this T GIJIHCLGELM, float JMJDPMIONDE, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x39E2160", Offset = "0x39E0960", VA = "0x1839E2160")]
	[IHLPLPGOHPJ]
	public static IDisposable FKDCOPOHFLM<T>(this T GIJIHCLGELM, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x39E2100", Offset = "0x39E0900", VA = "0x1839E2100")]
	[IHLPLPGOHPJ]
	public static IDisposable EOPAKCJABON<T>(this T GIJIHCLGELM, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x39E2310", Offset = "0x39E0B10", VA = "0x1839E2310")]
	[IHLPLPGOHPJ]
	public static IDisposable IEAHMGNGJFA<T>(this T GIJIHCLGELM, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x39E2910", Offset = "0x39E1110", VA = "0x1839E2910")]
	[IHLPLPGOHPJ]
	public static IDisposable NCJPFOCFLMB<T>(this T GIJIHCLGELM, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x39E2250", Offset = "0x39E0A50", VA = "0x1839E2250")]
	[IHLPLPGOHPJ]
	public static IDisposable HENMMDBDFCN<T>(this T GIJIHCLGELM, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x39E1FB0", Offset = "0x39E07B0", VA = "0x1839E1FB0")]
	[IHLPLPGOHPJ]
	public static IDisposable AJCFIDHNEBI<T>(this T GIJIHCLGELM, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x39E2970", Offset = "0x39E1170", VA = "0x1839E2970")]
	[IHLPLPGOHPJ]
	public static IDisposable OAEAPMGMECK<T>(this T GIJIHCLGELM, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x39E2010", Offset = "0x39E0810", VA = "0x1839E2010")]
	[IHLPLPGOHPJ]
	public static IDisposable BENDDJKBKEN<T>(this T GIJIHCLGELM, float JMJDPMIONDE, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x39E22B0", Offset = "0x39E0AB0", VA = "0x1839E22B0")]
	[IHLPLPGOHPJ]
	public static IDisposable HJBCEGIOMCP<T>(this T GIJIHCLGELM, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x39E2370", Offset = "0x39E0B70", VA = "0x1839E2370")]
	[IHLPLPGOHPJ]
	public static IDisposable IGBCANGJACP<T>(this T GIJIHCLGELM, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true) where T : MonoBehaviour, GKEGMHGFIBN
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class CNBBHBNAOKK
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class DNDMHBGGABO : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NCCNCPLKFOD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private HGJGDCIPGJF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public DNDMHBGGABO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A99B90", Offset = "0x8A98390", VA = "0x188A99B90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A99C70", Offset = "0x8A98470", VA = "0x188A99C70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class KCAANPMIONO : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NCCNCPLKFOD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private HGJGDCIPGJF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public KCAANPMIONO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A9FCF0", Offset = "0x8A9E4F0", VA = "0x188A9FCF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8A9FDE0", Offset = "0x8A9E5E0", VA = "0x188A9FDE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8A94640", Offset = "0x8A92E40", VA = "0x188A94640")]
	public static NGLIALCAJHK LFCDJPIKPJG(Action EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8A946C0", Offset = "0x8A92EC0", VA = "0x188A946C0")]
	public static NGLIALCAJHK LFCDJPIKPJG(Behaviour MJAGIMDGJBK, Action EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8A94750", Offset = "0x8A92F50", VA = "0x188A94750")]
	public static NGLIALCAJHK LFCDJPIKPJG(Behaviour MJAGIMDGJBK, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8A948C0", Offset = "0x8A930C0", VA = "0x188A948C0")]
	[IteratorStateMachine(typeof(DNDMHBGGABO))]
	private static IEnumerator<ENGFNCJEKHI> LLDJLHHKPLM(NCCNCPLKFOD JPJPDMBLMLB, Action EJIFHEKNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8A94830", Offset = "0x8A93030", VA = "0x188A94830")]
	[IteratorStateMachine(typeof(KCAANPMIONO))]
	private static IEnumerator<ENGFNCJEKHI> LLDJLHHKPLM(NCCNCPLKFOD JPJPDMBLMLB, Action<float> EJIFHEKNDCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class OBJPMLOPIHA : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class LPDMCDJCLPF : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public OBJPMLOPIHA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public LPDMCDJCLPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2740", Offset = "0x8AA0F40", VA = "0x188AA2740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8AA27D0", Offset = "0x8AA0FD0", VA = "0x188AA27D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NCCNCPLKFOD KAANEGCHJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Action PGCMKLJKAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool NCPBBBJJJDD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KLEBMFMNBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5D20", Offset = "0x8AA4520", VA = "0x188AA5D20")]
	public OBJPMLOPIHA(NCCNCPLKFOD KAANEGCHJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5CA0", Offset = "0x8AA44A0", VA = "0x188AA5CA0")]
	[IteratorStateMachine(typeof(LPDMCDJCLPF))]
	private IEnumerator<ENGFNCJEKHI> PBIJGEEEPHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5C00", Offset = "0x8AA4400", VA = "0x188AA5C00", Slot = "4")]
	public void OnCompleted(Action NPPFMKINMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	public void AKEMJFANLPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class DJKDBMJJFNO
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8A99970", Offset = "0x8A98170", VA = "0x188A99970")]
	public static OBJPMLOPIHA GAFCKONHBEH(this NCCNCPLKFOD KAANEGCHJMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EBHAPDEFKFF
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class JMKFKDFMFPG : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public MILNFBADNOP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public JMKFKDFMFPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8A9FC20", Offset = "0x8A9E420", VA = "0x188A9FC20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8A9FCA0", Offset = "0x8A9E4A0", VA = "0x188A9FCA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A8B0", Offset = "0x8A990B0", VA = "0x188A9A8B0")]
	public static NGLIALCAJHK LFCDJPIKPJG(float JMJDPMIONDE, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, bool ILBFBFFOBNG = true, [Optional] OGAAENKMMFA ACKPLKCAIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A980", Offset = "0x8A99180", VA = "0x188A9A980")]
	public static NGLIALCAJHK LFCDJPIKPJG(MonoBehaviour GIJIHCLGELM, float JMJDPMIONDE, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, bool ILBFBFFOBNG = true, [Optional] OGAAENKMMFA ACKPLKCAIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8A9AB10", Offset = "0x8A99310", VA = "0x188A9AB10")]
	public static NGLIALCAJHK MHONNLOCEBF(MonoBehaviour GIJIHCLGELM, float JMJDPMIONDE, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, bool ILBFBFFOBNG = true, [Optional] OGAAENKMMFA ACKPLKCAIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8A9AC00", Offset = "0x8A99400", VA = "0x188A9AC00")]
	public static NGLIALCAJHK PNHMAHOKKNO(NJIBLDPNMNG MJAGIMDGJBK, float JMJDPMIONDE, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, bool ILBFBFFOBNG = true, [Optional] OGAAENKMMFA ACKPLKCAIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8A9AA50", Offset = "0x8A99250", VA = "0x188A9AA50")]
	private static IEnumerator<ENGFNCJEKHI> LLDJLHHKPLM(HHECMJCEIMI DKKABHJOBNP, float JMJDPMIONDE, NCCNCPLKFOD JPJPDMBLMLB, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A850", Offset = "0x8A99050", VA = "0x188A9A850")]
	private static IEnumerator<ENGFNCJEKHI> JKHNHNOMFIB(HHECMJCEIMI DKKABHJOBNP, float JMJDPMIONDE, NCCNCPLKFOD JPJPDMBLMLB, Action<float> EJIFHEKNDCL, bool ILBFBFFOBNG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A7C0", Offset = "0x8A98FC0", VA = "0x188A9A7C0")]
	[IteratorStateMachine(typeof(JMKFKDFMFPG))]
	private static IEnumerator<ENGFNCJEKHI> AIPALDHIBCN(MILNFBADNOP PMDLNNGODKJ, float JMJDPMIONDE, NCCNCPLKFOD JPJPDMBLMLB, Action<float> EJIFHEKNDCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class HEGJOPGGBEB
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class DLGBCCNMJKD : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public NCCNCPLKFOD queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public DLGBCCNMJKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8A99A80", Offset = "0x8A98280", VA = "0x188A99A80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8A99B40", Offset = "0x8A98340", VA = "0x188A99B40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8A9E5B0", Offset = "0x8A9CDB0", VA = "0x188A9E5B0")]
	[IteratorStateMachine(typeof(DLGBCCNMJKD))]
	private static IEnumerator<ENGFNCJEKHI> CMIPKBAFMEK(NCCNCPLKFOD KAANEGCHJMA, Func<bool> FLPNFIDBDHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8A9E640", Offset = "0x8A9CE40", VA = "0x188A9E640")]
	public static NGLIALCAJHK EGHANIJAMNM(this MonoBehaviour GIJIHCLGELM, Func<bool> FLPNFIDBDHL, NCCNCPLKFOD KAANEGCHJMA = NCCNCPLKFOD.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class DOADBBGGEOO
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class CCGPAHJNBKP : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public NCCNCPLKFOD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public CCGPAHJNBKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A94490", Offset = "0x8A92C90", VA = "0x188A94490", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A94500", Offset = "0x8A92D00", VA = "0x188A94500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class FFHGFIKMFNH<T> : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NCCNCPLKFOD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public FFHGFIKMFNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4BA9CA0", Offset = "0x4BA84A0", VA = "0x184BA9CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4BA9D40", Offset = "0x4BA8540", VA = "0x184BA9D40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class EJLOLHJCMBE : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public NCCNCPLKFOD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private ENGFNCJEKHI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public EJLOLHJCMBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8A9AD20", Offset = "0x8A99520", VA = "0x188A9AD20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A9ADB0", Offset = "0x8A995B0", VA = "0x188A9ADB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A680", Offset = "0x8A98E80", VA = "0x188A9A680")]
	[IteratorStateMachine(typeof(CCGPAHJNBKP))]
	private static IEnumerator<ENGFNCJEKHI> PBIJGEEEPHK(float AFBFHAPCPPE, NCCNCPLKFOD JPJPDMBLMLB, Action OHENIKPHLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x38231C0", Offset = "0x38219C0", VA = "0x1838231C0")]
	[IteratorStateMachine(typeof(FFHGFIKMFNH<>))]
	private static IEnumerator<ENGFNCJEKHI> PBIJGEEEPHK<T>(float AFBFHAPCPPE, NCCNCPLKFOD JPJPDMBLMLB, Action<T> OHENIKPHLCF, T OPAHMKOAAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A5E0", Offset = "0x8A98DE0", VA = "0x188A9A5E0")]
	[IteratorStateMachine(typeof(EJLOLHJCMBE))]
	private static IEnumerator<ENGFNCJEKHI> OBEJMFKLDLO(float AFBFHAPCPPE, NCCNCPLKFOD JPJPDMBLMLB, Action OHENIKPHLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8A99FC0", Offset = "0x8A987C0", VA = "0x188A99FC0")]
	public static IDisposable GAAGDNJJKMB(this MonoBehaviour GIJIHCLGELM, float AFBFHAPCPPE, Action OHENIKPHLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8A99F30", Offset = "0x8A98730", VA = "0x188A99F30")]
	public static NGLIALCAJHK EKNOALMECBE(this MonoBehaviour GIJIHCLGELM, float AFBFHAPCPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A0A0", Offset = "0x8A988A0", VA = "0x188A9A0A0")]
	public static NGLIALCAJHK GAAGDNJJKMB(this MonoBehaviour GIJIHCLGELM, float AFBFHAPCPPE, NCCNCPLKFOD JPJPDMBLMLB, Action OHENIKPHLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A190", Offset = "0x8A98990", VA = "0x188A9A190")]
	public static NGLIALCAJHK GDKFLPFDOJN(this MonoBehaviour GIJIHCLGELM, Action OHENIKPHLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3823030", Offset = "0x3821830", VA = "0x183823030")]
	public static NGLIALCAJHK GDKFLPFDOJN<T>(this MonoBehaviour GIJIHCLGELM, Action<T> OHENIKPHLCF, T OPAHMKOAAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8A99E90", Offset = "0x8A98690", VA = "0x188A99E90")]
	public static NGLIALCAJHK CELHCGGHKMJ(this MonoBehaviour GIJIHCLGELM, Action OHENIKPHLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A370", Offset = "0x8A98B70", VA = "0x188A9A370")]
	public static NGLIALCAJHK IGDBFJBBGOI(this MonoBehaviour GIJIHCLGELM, Action OHENIKPHLCF, [Optional] OGAAENKMMFA ACKPLKCAIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A4B0", Offset = "0x8A98CB0", VA = "0x188A9A4B0")]
	public static NGLIALCAJHK NLNKFEHNEME(this MonoBehaviour GIJIHCLGELM, Action OHENIKPHLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8A99DF0", Offset = "0x8A985F0", VA = "0x188A99DF0")]
	public static NGLIALCAJHK CDBIJGKMABF(this MonoBehaviour GIJIHCLGELM, Action OHENIKPHLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A410", Offset = "0x8A98C10", VA = "0x188A9A410")]
	public static NGLIALCAJHK LGACABMIEEA(MonoBehaviour GIJIHCLGELM, NCCNCPLKFOD KAANEGCHJMA, Action OHENIKPHLCF, [Optional] OGAAENKMMFA ACKPLKCAIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3823080", Offset = "0x3821880", VA = "0x183823080")]
	public static NGLIALCAJHK LGACABMIEEA<T>(MonoBehaviour GIJIHCLGELM, NCCNCPLKFOD KAANEGCHJMA, Action<T> OHENIKPHLCF, T OPAHMKOAAKD, [Optional] OGAAENKMMFA ACKPLKCAIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A550", Offset = "0x8A98D50", VA = "0x188A9A550")]
	public static NGLIALCAJHK OADBJDEBOPJ(this MonoBehaviour GIJIHCLGELM, float GGOPBNODBCM, Action OHENIKPHLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A230", Offset = "0x8A98A30", VA = "0x188A9A230")]
	public static NGLIALCAJHK GMNGPMNIMGC(this MonoBehaviour GIJIHCLGELM, float GGOPBNODBCM, Action OHENIKPHLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A720", Offset = "0x8A98F20", VA = "0x188A9A720")]
	public static NGLIALCAJHK PDLLCDOGKEK(this MonoBehaviour GIJIHCLGELM, float GGOPBNODBCM, Action OHENIKPHLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A2D0", Offset = "0x8A98AD0", VA = "0x188A9A2D0")]
	public static NGLIALCAJHK HDLGIABHGCL(this MonoBehaviour GIJIHCLGELM, float GGOPBNODBCM, Action OHENIKPHLCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class LLHBMMDMDDD : KEPFCCDBCHI, IEnumerable<KEPFCCDBCHI>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<KEPFCCDBCHI> LGCELCODDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool EDFLFJJDELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Action NNNPFCEAADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool HEPAOKFAHGC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KDDGIDIEMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2570", Offset = "0x8AA0D70", VA = "0x188AA2570", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action PEHJAEPCKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8AA1FD0", Offset = "0x8AA07D0", VA = "0x188AA1FD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8AA24D0", Offset = "0x8AA0CD0", VA = "0x188AA24D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8AA26A0", Offset = "0x8AA0EA0", VA = "0x188AA26A0")]
	public LLHBMMDMDDD([Optional] Action NNNPFCEAADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8AA1E20", Offset = "0x8AA0620", VA = "0x188AA1E20")]
	public void GGGBGBDKNKJ(KEPFCCDBCHI FADNNDGGKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8AA2380", Offset = "0x8AA0B80", VA = "0x188AA2380")]
	private void MGOFOOOLDGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8AA2070", Offset = "0x8AA0870", VA = "0x188AA2070", Slot = "7")]
	public bool MFANLCAEMEB(bool IBCIAMDAPFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8AA2080", Offset = "0x8AA0880", VA = "0x188AA2080", Slot = "8")]
	public bool MFANLCAEMEB(Action AMNCPNDDCLP, bool IBCIAMDAPFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8AA1F50", Offset = "0x8AA0750", VA = "0x188AA1F50", Slot = "9")]
	public IEnumerator<KEPFCCDBCHI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8AA1F50", Offset = "0x8AA0750", VA = "0x188AA1F50", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MBJNGBDFAPN : BNLMGGKDGCD
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class BOLHPAOJAFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public MBJNGBDFAPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BOLHPAOJAFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8A93D80", Offset = "0x8A92580", VA = "0x188A93D80")]
		internal void BPBPAEFOPID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class LELCCIBLKFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public MBJNGBDFAPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LELCCIBLKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8A93D80", Offset = "0x8A92580", VA = "0x188A93D80")]
		internal void GKONPCGOLIL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly float GJOMFGODGCO;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8A9F900", Offset = "0x8A9E100", VA = "0x188A9F900")]
	public MBJNGBDFAPN(Behaviour MJAGIMDGJBK, float GJOMFGODGCO, [Optional] Action NNNPFCEAADM, [Optional] OGAAENKMMFA ACKPLKCAIIL, [Optional] HHECMJCEIMI DKKABHJOBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8AA2930", Offset = "0x8AA1130", VA = "0x188AA2930", Slot = "9")]
	protected override bool KPCFIJFPLAL(Action AMNCPNDDCLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8AA2820", Offset = "0x8AA1020", VA = "0x188AA2820", Slot = "10")]
	protected override bool JNADNHGCHEK(Action AMNCPNDDCLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface KEPFCCDBCHI
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool KDDGIDIEMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PEHJAEPCKGI;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MFANLCAEMEB(bool IBCIAMDAPFE = false);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MFANLCAEMEB(Action AMNCPNDDCLP, bool IBCIAMDAPFE = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class BNLMGGKDGCD : KEPFCCDBCHI
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class PJLPCBMGOIA : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public BNLMGGKDGCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public PJLPCBMGOIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8AA6FC0", Offset = "0x8AA57C0", VA = "0x188AA6FC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8AA7090", Offset = "0x8AA5890", VA = "0x188AA7090", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Behaviour MJAGIMDGJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action NNNPFCEAADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private JLFAJMGNMDK DFEPADAHFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly OGAAENKMMFA ACKPLKCAIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	protected readonly HHECMJCEIMI DKKABHJOBNP;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool KDDGIDIEMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1B5AB90", Offset = "0x1B59390", VA = "0x181B5AB90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PEHJAEPCKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8A93770", Offset = "0x8A91F70", VA = "0x188A93770", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8A93B20", Offset = "0x8A92320", VA = "0x188A93B20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8A93C50", Offset = "0x8A92450", VA = "0x188A93C50")]
	protected BNLMGGKDGCD(Behaviour MJAGIMDGJBK, [Optional] Action NNNPFCEAADM, [Optional] OGAAENKMMFA ACKPLKCAIIL, [Optional] HHECMJCEIMI DKKABHJOBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8A93AC0", Offset = "0x8A922C0", VA = "0x188A93AC0", Slot = "7")]
	public bool MFANLCAEMEB(bool IBCIAMDAPFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8A93A60", Offset = "0x8A92260", VA = "0x188A93A60", Slot = "8")]
	public bool MFANLCAEMEB(Action AMNCPNDDCLP, bool IBCIAMDAPFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool KPCFIJFPLAL(Action AMNCPNDDCLP);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool JNADNHGCHEK(Action AMNCPNDDCLP);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8A93750", Offset = "0x8A91F50", VA = "0x188A93750")]
	protected void GBABGIINIHM(Action AMNCPNDDCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8A93810", Offset = "0x8A92010", VA = "0x188A93810")]
	protected FKGMEHDMFDF KIMFEIADOLB(float EMFFCDLDJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8A93690", Offset = "0x8A91E90", VA = "0x188A93690")]
	private void DFOAGKACBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8A93BC0", Offset = "0x8A923C0", VA = "0x188A93BC0")]
	[IteratorStateMachine(typeof(PJLPCBMGOIA))]
	private IEnumerator<ENGFNCJEKHI> OLDIFAKJIMN(float EMFFCDLDJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8A93710", Offset = "0x8A91F10", VA = "0x188A93710")]
	[CompilerGenerated]
	private void FDJCPNCNBOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class EMGNJIKAKAE : BNLMGGKDGCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly float FLHGAOMEMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly int NBLFBOOOOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly float DGHNMDEBELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly float[] JNDEKLDFPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int HOONLOBCKOH;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8A9B440", Offset = "0x8A99C40", VA = "0x188A9B440")]
	public EMGNJIKAKAE(Behaviour MJAGIMDGJBK, float EJFFFHPFEPC, int NBLFBOOOOMF, [Optional] Action NNNPFCEAADM, float DGHNMDEBELG = 0f, [Optional] OGAAENKMMFA ACKPLKCAIIL, [Optional] HHECMJCEIMI DKKABHJOBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "9")]
	protected override bool KPCFIJFPLAL(Action AMNCPNDDCLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8A9B1C0", Offset = "0x8A999C0", VA = "0x188A9B1C0", Slot = "10")]
	protected override bool JNADNHGCHEK(Action AMNCPNDDCLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8A9B3C0", Offset = "0x8A99BC0", VA = "0x188A9B3C0")]
	private void KGDFPAJJOJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class JIDBBNFAPKL : BNLMGGKDGCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly float GJOMFGODGCO;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8A9F900", Offset = "0x8A9E100", VA = "0x188A9F900")]
	public JIDBBNFAPKL(Behaviour MJAGIMDGJBK, float GJOMFGODGCO, [Optional] Action NNNPFCEAADM, [Optional] OGAAENKMMFA ACKPLKCAIIL, [Optional] HHECMJCEIMI DKKABHJOBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "9")]
	protected override bool KPCFIJFPLAL(Action AMNCPNDDCLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8A9F8C0", Offset = "0x8A9E0C0", VA = "0x188A9F8C0", Slot = "10")]
	protected override bool JNADNHGCHEK(Action AMNCPNDDCLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class CAFKOCIOKPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class EHPJMKGPMNJ : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public EHPJMKGPMNJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8A90B40", Offset = "0x8A8F340", VA = "0x188A90B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9ACD0", Offset = "0x8A994D0", VA = "0x188A9ACD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private NGLIALCAJHK ALBICNAACLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private NJIBLDPNMNG MJAGIMDGJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Action<float> IMALENFMEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private NCCNCPLKFOD KAANEGCHJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private float PHCDICFPBNK;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8A942F0", Offset = "0x8A92AF0", VA = "0x188A942F0")]
	public CAFKOCIOKPJ(NJIBLDPNMNG MJAGIMDGJBK, float JMJDPMIONDE, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8A93FD0", Offset = "0x8A927D0", VA = "0x188A93FD0")]
	private void IIJBMNAACHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8A941C0", Offset = "0x8A929C0", VA = "0x188A941C0")]
	private void PEGNOJEMPEF(string MEBFHJECJFA, Action HMKBEGFHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8A94140", Offset = "0x8A92940", VA = "0x188A94140")]
	[IteratorStateMachine(typeof(EHPJMKGPMNJ))]
	private IEnumerator<ENGFNCJEKHI> JPNJPBLLAMH(Action HMKBEGFHHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x8A93F70", Offset = "0x8A92770", VA = "0x188A93F70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x8A93DF0", Offset = "0x8A925F0", VA = "0x188A93DF0")]
	[CompilerGenerated]
	private void BFEMFNKJCAF(string PAPMAHJECNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class GOGKBELMNIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class ABJOLHKKJEF : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public ABJOLHKKJEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8A90B40", Offset = "0x8A8F340", VA = "0x188A90B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8A90BB0", Offset = "0x8A8F3B0", VA = "0x188A90BB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private NGLIALCAJHK ALBICNAACLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private MonoBehaviour GIJIHCLGELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Action EJIFHEKNDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Action<float> IMALENFMEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private NCCNCPLKFOD KAANEGCHJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float PHCDICFPBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool ILBFBFFOBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly OGAAENKMMFA ACKPLKCAIIL;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8A9D990", Offset = "0x8A9C190", VA = "0x188A9D990")]
	public GOGKBELMNIJ(MonoBehaviour GIJIHCLGELM, Action EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, [Optional] OGAAENKMMFA ACKPLKCAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x8A9D7C0", Offset = "0x8A9BFC0", VA = "0x188A9D7C0")]
	public GOGKBELMNIJ(MonoBehaviour GIJIHCLGELM, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, [Optional] OGAAENKMMFA ACKPLKCAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x8A9D5E0", Offset = "0x8A9BDE0", VA = "0x188A9D5E0")]
	public GOGKBELMNIJ(MonoBehaviour GIJIHCLGELM, float JMJDPMIONDE, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, bool ILBFBFFOBNG = true, [Optional] OGAAENKMMFA ACKPLKCAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4D61840", Offset = "0x4D60040", VA = "0x184D61840")]
	private GOGKBELMNIJ(OGAAENKMMFA ACKPLKCAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x8A9D160", Offset = "0x8A9B960", VA = "0x188A9D160")]
	internal static GOGKBELMNIJ LNPGGHIMAMC(MonoBehaviour GIJIHCLGELM, float JMJDPMIONDE, Action<float> EJIFHEKNDCL, NCCNCPLKFOD KAANEGCHJMA, bool ILBFBFFOBNG = true, [Optional] OGAAENKMMFA ACKPLKCAIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x8A9D030", Offset = "0x8A9B830", VA = "0x188A9D030")]
	private void LFCDJPIKPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CA40", Offset = "0x8A9B240", VA = "0x188A9CA40")]
	private void CONHIPJJKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CC20", Offset = "0x8A9B420", VA = "0x188A9CC20")]
	private void IIJBMNAACHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CD90", Offset = "0x8A9B590", VA = "0x188A9CD90")]
	private void JPLKFCDBPMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8A9D4B0", Offset = "0x8A9BCB0", VA = "0x188A9D4B0")]
	private void PEGNOJEMPEF(string MEBFHJECJFA, Action HMKBEGFHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CF20", Offset = "0x8A9B720", VA = "0x188A9CF20")]
	[IteratorStateMachine(typeof(ABJOLHKKJEF))]
	private IEnumerator<ENGFNCJEKHI> JPNJPBLLAMH(Action HMKBEGFHHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CBC0", Offset = "0x8A9B3C0", VA = "0x188A9CBC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8A9D420", Offset = "0x8A9BC20", VA = "0x188A9D420")]
	[CompilerGenerated]
	private void OADADGOOONL(string PAPMAHJECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CFA0", Offset = "0x8A9B7A0", VA = "0x188A9CFA0")]
	[CompilerGenerated]
	private void KBBHGBCKNII(string PAPMAHJECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8A9D390", Offset = "0x8A9BB90", VA = "0x188A9D390")]
	[CompilerGenerated]
	private void NIIANEMHABB(string PAPMAHJECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C9B0", Offset = "0x8A9B1B0", VA = "0x188A9C9B0")]
	[CompilerGenerated]
	private void BABLGIFFHAA(string PAPMAHJECNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum GNNIFKODDJI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class BFIAEGNLLNO : HHECMJCEIMI
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float KFGDBBGOMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8A935E0", Offset = "0x8A91DE0", VA = "0x188A935E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float BLIJLHHJGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8A935F0", Offset = "0x8A91DF0", VA = "0x188A935F0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public double GGCAPGOHMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8A93670", Offset = "0x8A91E70", VA = "0x188A93670", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8A93600", Offset = "0x8A91E00", VA = "0x188A93600")]
	[NOOFMBJKOEL.LBENCLOPAFN]
	internal static void MNKNDOLBIJB(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	[UnityEngine.Scripting.Preserve]
	internal BFIAEGNLLNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface DFLPFEOCIAP
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABOLJOPAGOK(string HPANEBBHGAC);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANFKJAMPACF();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface AHLPPHJBNBK
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool ALIOKCOAJKO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool LKKJKOFPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class PMJEJNOEJOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public AFIDJCEMDBN CMHFFFMOPFM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int PJLMPJGAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8AA7110", Offset = "0x8AA5910", VA = "0x188AA7110")]
	public static ENGFNCJEKHI HFNGJIFHBHD(IEnumerator<ENGFNCJEKHI> KMJPONBGMIA, GMBBLKJLMIE BHNDIAAKONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8AA7270", Offset = "0x8AA5A70", VA = "0x188AA7270")]
	public ENGFNCJEKHI HFNGJIFHBHD(GMBBLKJLMIE[] ABFPGJMPBNK, IEnumerator<ENGFNCJEKHI>[] CLKIEBOHMNL, ENGFNCJEKHI[] GMPPNANCCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8AA70E0", Offset = "0x8AA58E0", VA = "0x188AA70E0")]
	public void PNLEFHJPDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8AA7470", Offset = "0x8AA5C70", VA = "0x188AA7470")]
	public void NDGBCHBJJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8AA7330", Offset = "0x8AA5B30", VA = "0x188AA7330")]
	public void LPJFHOAEPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8AA70E0", Offset = "0x8AA58E0", VA = "0x188AA70E0")]
	public void FBONGFMPKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public PMJEJNOEJOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class AFIDJCEMDBN
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct FLEGFCJMBCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public PMJEJNOEJOB IAJNDNMPOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public NJIBLDPNMNG FLFIEAHMHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public GMBBLKJLMIE JDJNKKPPELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public IEnumerator<ENGFNCJEKHI> GCFGNGGHBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public ENGFNCJEKHI JELBHNLLBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public GNNIFKODDJI AGLOMKNADCH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct HMOAFBEGLAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public NCCNCPLKFOD OKMIIABFPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public List<FLEGFCJMBCC> BKEEDPINNEM;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class MLECAOMGIAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public GMBBLKJLMIE promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AFIDJCEMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public NJIBLDPNMNG context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public PMJEJNOEJOB routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public GNNIFKODDJI coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public ENGFNCJEKHI currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public IEnumerator<ENGFNCJEKHI> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MLECAOMGIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA3A80", Offset = "0x8AA2280", VA = "0x188AA3A80")]
		internal void PJJFIFNFPPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class OEEAEACMCMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public PMJEJNOEJOB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AFIDJCEMDBN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public OEEAEACMCMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8AA5E20", Offset = "0x8AA4620", VA = "0x188AA5E20")]
		internal void LKIENKHNNCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class MILPAEACFDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public PMJEJNOEJOB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AFIDJCEMDBN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MILPAEACFDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2A40", Offset = "0x8AA1240", VA = "0x188AA2A40")]
		internal void MMBBEFDIHPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BOPEBOADENA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public PMJEJNOEJOB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AFIDJCEMDBN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BOPEBOADENA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8A93DB0", Offset = "0x8A925B0", VA = "0x188A93DB0")]
		internal void MDOGBMKOKBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private const GNNIFKODDJI BLJEPOENGCC = GNNIFKODDJI.Cancelled | GNNIFKODDJI.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly NCCNCPLKFOD KAANEGCHJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool[] MNILMKPGCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private NativeArray<GNNIFKODDJI> BFBCAMNACBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NativeArray<float> JFGJLIKGNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private NativeArray<int> CFJOEEBLLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private NativeArray<int> IIADCEOBOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private NativeArray<int> NOKAAHELIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NativeArray<int> CKJHHGKGOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private NativeArray<int> IICJIHJICCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private PMJEJNOEJOB[] DEAADGMOJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private GMBBLKJLMIE[] ABFPGJMPBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NJIBLDPNMNG[] NBPOHCOFAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private IEnumerator<ENGFNCJEKHI>[] AFOILKFOPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private ENGFNCJEKHI[] INKBIGJOGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int LGFDPPOKCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int BEMGFNOEFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly int DOKKPGJAENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private float IEEMNGOCCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private OGANFFIBMIH GBCDMBNIPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private JobHandle ABNHDCJNKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private List<PMJEJNOEJOB> HONBONHBBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool MOIFDOCHEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private List<Action> LAHBOJMCLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> MKNKHAPGKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool HFCHLFGENLL;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public HMOAFBEGLAE[] BONGNKKGPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xB2D1E0", Offset = "0xB2B9E0", VA = "0x180B2D1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8A90E00", Offset = "0x8A8F600", VA = "0x188A90E00")]
	private static int CECMAKIKBEA(NCCNCPLKFOD KAANEGCHJMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8A92F90", Offset = "0x8A91790", VA = "0x188A92F90")]
	public AFIDJCEMDBN(NCCNCPLKFOD KAANEGCHJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8A91F40", Offset = "0x8A90740", VA = "0x188A91F40")]
	private void IIDFACNPBCA(int MPNECHCMHML, int GJNLFMAEJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8A92350", Offset = "0x8A90B50", VA = "0x188A92350")]
	public void KCBNCFBMKGF(NJIBLDPNMNG MJAGIMDGJBK, ENGFNCJEKHI JMNGKFKOHEM, IEnumerator<ENGFNCJEKHI> KMJPONBGMIA, GMBBLKJLMIE BHNDIAAKONA, [Optional] PMJEJNOEJOB NPGANJFOOBO, GNNIFKODDJI IIFDGCEHIBE = GNNIFKODDJI.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8A915D0", Offset = "0x8A8FDD0", VA = "0x188A915D0")]
	public void DBIMNIOCAGM(IEnumerable<FLEGFCJMBCC> MCPNKLEFHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8A92AC0", Offset = "0x8A912C0", VA = "0x188A92AC0")]
	private FLEGFCJMBCC PKIHIHDMILO(int FLIMHBNLELF)
	{
		return default(FLEGFCJMBCC);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8A92680", Offset = "0x8A90E80", VA = "0x188A92680")]
	private void MIMJFFBNLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x41E8500", Offset = "0x41E6D00", VA = "0x1841E8500")]
	private static void HPIIFGLPJAI<T>(int FLIMHBNLELF, T[] IKGJPABLKDK, int GGIJOHIPOOO, [Optional] T HEBKHAELPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x41E8550", Offset = "0x41E6D50", VA = "0x1841E8550")]
	private static void HPIIFGLPJAI<T>(int FLIMHBNLELF, NativeArray<T> IKGJPABLKDK, int GGIJOHIPOOO, [Optional] T HEBKHAELPEK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8A91BA0", Offset = "0x8A903A0", VA = "0x188A91BA0")]
	private void GLAGCPMCJOP(IEnumerable<FLEGFCJMBCC> MCPNKLEFHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8A929F0", Offset = "0x8A911F0", VA = "0x188A929F0")]
	private void PIIFKBEMJHP(FLEGFCJMBCC JIFELGNACOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8A91940", Offset = "0x8A90140", VA = "0x188A91940")]
	private CCDDDDDAOFI FGIBGOLALHF(int JMFOAHCFLFO)
	{
		return default(CCDDDDDAOFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8A90C00", Offset = "0x8A8F400", VA = "0x188A90C00")]
	public void ALGAJKEOFLL(float HADMPNPAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8A92600", Offset = "0x8A90E00", VA = "0x188A92600")]
	private void MECFFALBHGA(Action HBMOFOICGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8A91550", Offset = "0x8A8FD50", VA = "0x188A91550")]
	private void CLJOBCCJKGK(Action HBMOFOICGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8A90E30", Offset = "0x8A8F630", VA = "0x188A90E30")]
	public void CHDNPLCFBAC(float HADMPNPAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8A92250", Offset = "0x8A90A50", VA = "0x188A92250")]
	public void JGAHMDKPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8A91810", Offset = "0x8A90010", VA = "0x188A91810")]
	public void FBONGFMPKDI(PMJEJNOEJOB PMDLNNGODKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8A92120", Offset = "0x8A90920", VA = "0x188A92120")]
	public void IOLNOEONKMG(PMJEJNOEJOB PMDLNNGODKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8A924D0", Offset = "0x8A90CD0", VA = "0x188A924D0")]
	public void LDDPNOFFEFI(PMJEJNOEJOB PMDLNNGODKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class HFCGIGCDAIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly HFCGIGCDAIP EBKBGKJDDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly Action FGPNMBDMFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private bool DMJNBPLABAL;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public HFCGIGCDAIP(Action FGPNMBDMFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8107520", Offset = "0x8105D20", VA = "0x188107520", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface KFAKMPIFEAE<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable DJICAECGIMN(UnityEngine.Object MJAGIMDGJBK, Action<T> EAOIEEEKPAB);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface ELOFEKECJDN<T> : KFAKMPIFEAE<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	new T HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EJHDCMDKOEG<T> : ELOFEKECJDN<T>, KFAKMPIFEAE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class CDIKAFGCMIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public EJHDCMDKOEG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public KGIPDLMHNNM<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CDIKAFGCMIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6691FE0", Offset = "0x66907E0", VA = "0x186691FE0")]
		internal void OHCBKPLHLFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static GameObject KBGIKDCLAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly List<KGIPDLMHNNM<UnityEngine.Object, Action<T>>> FBEGEANAKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private T JBCHBMKKBMN;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA76470", Offset = "0xA74C70", VA = "0x180A76470", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x46F5110", Offset = "0x46F3910", VA = "0x1846F5110", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x46F4C90", Offset = "0x46F3490", VA = "0x1846F4C90")]
	private static bool CLAAJOOEPCL(T HBMOFOICGEH, T LDEEDNGKJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x46F59F0", Offset = "0x46F41F0", VA = "0x1846F59F0")]
	public EJHDCMDKOEG(T OFHDNMKDJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x46F4F50", Offset = "0x46F3750", VA = "0x1846F4F50", Slot = "6")]
	public IDisposable DJICAECGIMN(UnityEngine.Object MJAGIMDGJBK, Action<T> EAOIEEEKPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x46F55D0", Offset = "0x46F3DD0", VA = "0x1846F55D0")]
	private void LJJHPNOKDPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class DEPAJKLOJJG : ANFEINDHBIN
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private class GLCFIGPHNCC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		private class OCOJHGCJCEH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private int EBHOIBHGECB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private GLCFIGPHNCC JPJPDMBLMLB;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xF4EE80", Offset = "0xF4D680", VA = "0x180F4EE80")]
			public OCOJHGCJCEH(int EBHOIBHGECB, GLCFIGPHNCC JPJPDMBLMLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5DF0", Offset = "0x8AA45F0", VA = "0x188AA5DF0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class HHJBBJFACDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public HHJBBJFACDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA93CE0", Offset = "0xA924E0", VA = "0x180A93CE0")]
			internal bool FPDHHIBOMNB(PFMBEGGBLHH e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class NOOLPKGLDID : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private ENGFNCJEKHI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public GLCFIGPHNCC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public HHECMJCEIMI timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			private HGJGDCIPGJF <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private List<PFMBEGGBLHH> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public NOOLPKGLDID(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5880", Offset = "0x8AA4080", VA = "0x188AA5880", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5BB0", Offset = "0x8AA43B0", VA = "0x188AA5BB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly NCCNCPLKFOD KAANEGCHJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private NGLIALCAJHK BHNDIAAKONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly List<PFMBEGGBLHH> GDNAPNPEGFC;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8A9C890", Offset = "0x8A9B090", VA = "0x188A9C890")]
		public GLCFIGPHNCC(NCCNCPLKFOD KAANEGCHJMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8A9C670", Offset = "0x8A9AE70", VA = "0x188A9C670")]
		public IDisposable JBNJMFDGKED(PFMBEGGBLHH FFEFCPJCACL, OGAAENKMMFA ACKPLKCAIIL, HHECMJCEIMI PFLKFIDCFJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8A9C490", Offset = "0x8A9AC90", VA = "0x188A9C490")]
		private void BNPDCCHHFOM(int EBHOIBHGECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8A9C800", Offset = "0x8A9B000", VA = "0x188A9C800")]
		[IteratorStateMachine(typeof(NOOLPKGLDID))]
		private IEnumerator<ENGFNCJEKHI> LLDJLHHKPLM(HHECMJCEIMI PFLKFIDCFJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8A9C620", Offset = "0x8A9AE20", VA = "0x188A9C620", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class PFMBEGGBLHH
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public enum DMCALBAJNIL : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static int IPHMCNJGPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly int FIOOAILODJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly GKEGMHGFIBN FLFIEAHMHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly MonoBehaviour IMNHHPNHBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly Action JNHFKCNMNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly Action<float> NAJBGBICOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly float EOPNJHAJCNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public float JFGJLIKGNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public readonly string NCBGIDALPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public readonly bool BLEHAILKOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly DMCALBAJNIL FLOKPKLGNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool HJCNMHNOMDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public bool DGNHDBJNGGJ;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8AA6C60", Offset = "0x8AA5460", VA = "0x188AA6C60")]
		public PFMBEGGBLHH(GKEGMHGFIBN MJAGIMDGJBK, Action EJIFHEKNDCL, bool KHPGJMGFINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8AA6AE0", Offset = "0x8AA52E0", VA = "0x188AA6AE0")]
		public PFMBEGGBLHH(GKEGMHGFIBN MJAGIMDGJBK, Action<float> EJIFHEKNDCL, bool KHPGJMGFINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8AA6DE0", Offset = "0x8AA55E0", VA = "0x188AA6DE0")]
		public PFMBEGGBLHH(GKEGMHGFIBN MJAGIMDGJBK, float JMJDPMIONDE, Action<float> EJIFHEKNDCL, HHECMJCEIMI PFLKFIDCFJL, DMCALBAJNIL FAGKONKBLDM, bool ILBFBFFOBNG, bool KHPGJMGFINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8AA6910", Offset = "0x8AA5110", VA = "0x188AA6910")]
		public bool PDNJEJKBAIL(float BPMPOGGBGJO, float GBGEOECKKBL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly OGAAENKMMFA ACKPLKCAIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly HHECMJCEIMI DKKABHJOBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly Dictionary<NCCNCPLKFOD, GLCFIGPHNCC> JIKAMCELKGH;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8A99660", Offset = "0x8A97E60", VA = "0x188A99660")]
	[NOOFMBJKOEL.LBENCLOPAFN]
	internal static void PHADFKHFEMH(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8A996D0", Offset = "0x8A97ED0", VA = "0x188A996D0")]
	[UnityEngine.Scripting.Preserve]
	internal DEPAJKLOJJG([FAPODKMFODF(null)] OGAAENKMMFA ACKPLKCAIIL, [FAPODKMFODF(null)] HHECMJCEIMI DKKABHJOBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8A990C0", Offset = "0x8A978C0", VA = "0x188A990C0", Slot = "4")]
	public IDisposable JNHFKCNMNLI(GKEGMHGFIBN MJAGIMDGJBK, Action LKHIOLGKDDF, NCCNCPLKFOD KAANEGCHJMA, bool KHPGJMGFINJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8A992B0", Offset = "0x8A97AB0", VA = "0x188A992B0", Slot = "5")]
	public IDisposable JNHFKCNMNLI(GKEGMHGFIBN MJAGIMDGJBK, Action<float> LKHIOLGKDDF, NCCNCPLKFOD KAANEGCHJMA, bool KHPGJMGFINJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x8A98D80", Offset = "0x8A97580", VA = "0x188A98D80", Slot = "7")]
	public IDisposable EAENHDGKAFL(GKEGMHGFIBN MJAGIMDGJBK, float JMJDPMIONDE, Action<float> LKHIOLGKDDF, NCCNCPLKFOD KAANEGCHJMA, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8A98FC0", Offset = "0x8A977C0", VA = "0x188A98FC0", Slot = "8")]
	public IDisposable GOLFFILNLEP(GKEGMHGFIBN MJAGIMDGJBK, float JMJDPMIONDE, Action<float> LKHIOLGKDDF, NCCNCPLKFOD KAANEGCHJMA, bool ILBFBFFOBNG = true, bool KHPGJMGFINJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8A98C00", Offset = "0x8A97400", VA = "0x188A98C00", Slot = "6")]
	public IDisposable EAENHDGKAFL(float JMJDPMIONDE, Action<float> LKHIOLGKDDF, bool ILBFBFFOBNG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8A994A0", Offset = "0x8A97CA0", VA = "0x188A994A0", Slot = "9")]
	public void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8A98E80", Offset = "0x8A97680", VA = "0x188A98E80")]
	private GLCFIGPHNCC EBOMAELDNOC(NCCNCPLKFOD KAANEGCHJMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class MKPNBPGGHKO : MPLBOJCKGOJ, OGAAENKMMFA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private AFIDJCEMDBN[] OKLOLMJAOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private DFLPFEOCIAP BAEOAKAHPGE;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8AA3950", Offset = "0x8AA2150", VA = "0x188AA3950")]
	[NOOFMBJKOEL.LBENCLOPAFN]
	internal static void MNKNDOLBIJB(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8AA39C0", Offset = "0x8AA21C0", VA = "0x188AA39C0")]
	[UnityEngine.Scripting.Preserve]
	public MKPNBPGGHKO([FAPODKMFODF(null)] MHLODIPHOIP FOHABHJCBLP, [FAPODKMFODF(null)] HHECMJCEIMI DKKABHJOBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8AA3590", Offset = "0x8AA1D90", VA = "0x188AA3590", Slot = "19")]
	public override NGLIALCAJHK MKBCPPDLECB(NJIBLDPNMNG MJAGIMDGJBK, IEnumerator<ENGFNCJEKHI> JIEHLKBJFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8AA36C0", Offset = "0x8AA1EC0", VA = "0x188AA36C0", Slot = "20")]
	public override void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8AA2F00", Offset = "0x8AA1700", VA = "0x188AA2F00", Slot = "22")]
	public override void FDCMDEGEAGF(NCCNCPLKFOD KAANEGCHJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8AA3420", Offset = "0x8AA1C20", VA = "0x188AA3420", Slot = "21")]
	protected override void JNHFKCNMNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x8AA2E70", Offset = "0x8AA1670", VA = "0x188AA2E70")]
	private AFIDJCEMDBN CEJFCMPABEC(NCCNCPLKFOD CEPGAJKBPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x8AA31F0", Offset = "0x8AA19F0", VA = "0x188AA31F0", Slot = "23")]
	internal override GPBDHIPNJDG IIPKHOLOAOI(IEnumerator<ENGFNCJEKHI> JIEHLKBJFJK, Behaviour MJAGIMDGJBK, GMBBLKJLMIE BHNDIAAKONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x8AA3130", Offset = "0x8AA1930", VA = "0x188AA3130", Slot = "24")]
	internal override KMGAAHONCIO GBHBIEIKIOO(NCCNCPLKFOD JPJPDMBLMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8AA2D50", Offset = "0x8AA1550", VA = "0x188AA2D50")]
	private void BJGDIGFHAHA(AFIDJCEMDBN NHCHJBHMHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8AA2EA0", Offset = "0x8AA16A0", VA = "0x188AA2EA0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[BurstCompile]
internal struct OGANFFIBMIH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	[ReadOnly]
	public float CEAPMEMIGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	[ReadOnly]
	public int ONBGNIPLGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private NativeArray<int> AMAJJFAGHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private NativeArray<int> DNJBJEEHNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private NativeArray<int> NDPLKGACGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	[ReadOnly]
	public NativeArray<GNNIFKODDJI> DCJFPAKMBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[ReadOnly]
	public NativeArray<float> MDDOPEKHKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	[WriteOnly]
	public NativeArray<int> NOKAAHELIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	[WriteOnly]
	public NativeArray<int> CFJOEEBLLFO;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8AA61F0", Offset = "0x8AA49F0", VA = "0x188AA61F0")]
	public static OGANFFIBMIH INHDMBAMCNE(int KEBIKADGHAP, float HADMPNPAJDI, NativeArray<GNNIFKODDJI> GDPOBPIFMJI, NativeArray<float> EFHADHGEKMH, NativeArray<int> DPJGCNFGHFE, NativeArray<int> ONHLHFBOEID, NativeArray<int> EKNCHNLFLNA, NativeArray<int> DNJBJEEHNLK, NativeArray<int> NDPLKGACGNO)
	{
		return default(OGANFFIBMIH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5E90", Offset = "0x8AA4690", VA = "0x188AA5E90", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5F70", Offset = "0x8AA4770", VA = "0x188AA5F70")]
	private bool HGFEEONJIPD(int PNJCJGEIDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5E60", Offset = "0x8AA4660", VA = "0x188AA5E60")]
	private void ALFCMBFCAGA(NativeArray<int> ICDCMPCFFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x8AA6320", Offset = "0x8AA4B20", VA = "0x188AA6320")]
	private int NHJCLBAOMLL(int FNMNHKJKJIJ, int BHGFMOOCKOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8AA6250", Offset = "0x8AA4A50", VA = "0x188AA6250")]
	private void MMIKIPGMHCK(NativeArray<int> ICDCMPCFFIM, int GFPEIEGEOFE, int NLCEHLDPLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5FB0", Offset = "0x8AA47B0", VA = "0x188AA5FB0")]
	private void IFFKEEJKCFH(NativeArray<int> ICDCMPCFFIM, int JBPNDJAAFGO, int IJIEOMLKLOF, int GOEDCKEDPDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class MPLBOJCKGOJ : OGAAENKMMFA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly MHLODIPHOIP FOHABHJCBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	protected readonly HHECMJCEIMI DKKABHJOBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private KMGAAHONCIO[] PLMOBOELCDP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static OGAAENKMMFA HPECEAELCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8AA4430", Offset = "0x8AA2C30", VA = "0x188AA4430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool HFNFNBOGCLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public NCCNCPLKFOD AHEGCBONEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NCCNCPLKFOD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HHECMJCEIMI CGNNIMABNJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ENGFNCJEKHI PMFMINOPKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ENGFNCJEKHI GAACOHFLCKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public ENGFNCJEKHI MLELEJEPOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ENGFNCJEKHI KMNDKMJKPPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8AA51D0", Offset = "0x8AA39D0", VA = "0x188AA51D0")]
	public static NGLIALCAJHK NGDIGFKPKPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5390", Offset = "0x8AA3B90", VA = "0x188AA5390")]
	[UnityEngine.Scripting.Preserve]
	protected MPLBOJCKGOJ([FAPODKMFODF(null)] MHLODIPHOIP FOHABHJCBLP, [FAPODKMFODF(null)] HHECMJCEIMI DKKABHJOBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8AA4FE0", Offset = "0x8AA37E0", VA = "0x188AA4FE0", Slot = "6")]
	public NGLIALCAJHK IHHPLANMBKM(IEnumerator<ENGFNCJEKHI> JIEHLKBJFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8AA4DE0", Offset = "0x8AA35E0", VA = "0x188AA4DE0", Slot = "7")]
	public NGLIALCAJHK IHHPLANMBKM(Behaviour MJAGIMDGJBK, IEnumerator<ENGFNCJEKHI> JIEHLKBJFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract NGLIALCAJHK MKBCPPDLECB(NJIBLDPNMNG MJAGIMDGJBK, IEnumerator<ENGFNCJEKHI> JIEHLKBJFJK);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5030", Offset = "0x8AA3830", VA = "0x188AA5030", Slot = "20")]
	public virtual void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8AA4BA0", Offset = "0x8AA33A0", VA = "0x188AA4BA0", Slot = "9")]
	public void HDOOBFNGDNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8AA4FF0", Offset = "0x8AA37F0", VA = "0x188AA4FF0", Slot = "21")]
	protected virtual void JNHFKCNMNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5010", Offset = "0x8AA3810", VA = "0x188AA5010")]
	private void KHGNLILEMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5260", Offset = "0x8AA3A60", VA = "0x188AA5260")]
	private void OOFHGDKJBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8AA44A0", Offset = "0x8AA2CA0", VA = "0x188AA44A0")]
	private void CFMNFMICCDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8AA4B80", Offset = "0x8AA3380", VA = "0x188AA4B80")]
	private void GPKIGBAJFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8AA4B60", Offset = "0x8AA3360", VA = "0x188AA4B60")]
	private void FIDLLKBDPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8AA4AB0", Offset = "0x8AA32B0", VA = "0x188AA4AB0")]
	private void EIPANADEOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5370", Offset = "0x8AA3B70", VA = "0x188AA5370")]
	private void POAIANCLAIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8AA4AD0", Offset = "0x8AA32D0", VA = "0x188AA4AD0", Slot = "22")]
	public virtual void FDCMDEGEAGF(NCCNCPLKFOD KAANEGCHJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8AA44C0", Offset = "0x8AA2CC0", VA = "0x188AA44C0")]
	private void CPEKABIJIKD(KMGAAHONCIO NHCHJBHMHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2758B70", Offset = "0x2757370", VA = "0x182758B70")]
	private KMGAAHONCIO FNPEAHEKABB(NCCNCPLKFOD CEPGAJKBPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract GPBDHIPNJDG IIPKHOLOAOI(IEnumerator<ENGFNCJEKHI> JIEHLKBJFJK, Behaviour GIJIHCLGELM, GMBBLKJLMIE AHEMKAMCILI);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract KMGAAHONCIO GBHBIEIKIOO(NCCNCPLKFOD KAANEGCHJMA);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x8AA46F0", Offset = "0x8AA2EF0", VA = "0x188AA46F0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8AA4690", Offset = "0x8AA2E90", VA = "0x188AA4690", Slot = "15")]
	public ENGFNCJEKHI DFBDLJJCHOM(NCCNCPLKFOD JPJPDMBLMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5280", Offset = "0x8AA3A80", VA = "0x188AA5280", Slot = "16")]
	public ENGFNCJEKHI PBENFPMAPDD(float AFBFHAPCPPE, NCCNCPLKFOD JPJPDMBLMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x8AA5310", Offset = "0x8AA3B10", VA = "0x188AA5310", Slot = "17")]
	public ENGFNCJEKHI PNNECMGCLGE(Func<bool> FLPNFIDBDHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class GPBDHIPNJDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly GMBBLKJLMIE BHNDIAAKONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly AHLPPHJBNBK MJAGIMDGJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly bool IBKGEIKBCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private string HPANEBBHGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private StackTrace CMIHEECOJLK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerator<ENGFNCJEKHI> GCFGNGGHBPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ENGFNCJEKHI JELBHNLLBGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool DGMBEJFAHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8A9E0B0", Offset = "0x8A9C8B0", VA = "0x188A9E0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool ILLOMLNNDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xC9B980", Offset = "0xC9A180", VA = "0x180C9B980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xCCFEA0", Offset = "0xCCE6A0", VA = "0x180CCFEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DBE0", Offset = "0x8A9C3E0", VA = "0x188A9DBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float MDJOFELKAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xE0CD50", Offset = "0xE0B550", VA = "0x180E0CD50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xE0CD60", Offset = "0xE0B560", VA = "0x180E0CD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8A9E210", Offset = "0x8A9CA10", VA = "0x188A9E210")]
	public GPBDHIPNJDG(IEnumerator<ENGFNCJEKHI> KMJPONBGMIA, AHLPPHJBNBK MJAGIMDGJBK, GMBBLKJLMIE BHNDIAAKONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8A9DD90", Offset = "0x8A9C590", VA = "0x188A9DD90")]
	public ENGFNCJEKHI HFNGJIFHBHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8A9DB20", Offset = "0x8A9C320", VA = "0x188A9DB20")]
	public bool BGPOIMILJGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8A9DB90", Offset = "0x8A9C390", VA = "0x188A9DB90")]
	public void FBONGFMPKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8A9E130", Offset = "0x8A9C930", VA = "0x188A9E130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0xD198B0", Offset = "0xD180B0", VA = "0x180D198B0")]
	[CompilerGenerated]
	private void IDOFNBJGIJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class GMBBLKJLMIE : FIHBAFMCLPL, NGLIALCAJHK, JLFAJMGNMDK, FKGMEHDMFDF, IEnumerator, ENGFNCJEKHI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private NCCNCPLKFOD KAEHGGFHJJA;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private NCCNCPLKFOD ELBHFPDLDML
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xDFA150", Offset = "0xDF8950", VA = "0x180DFA150", Slot = "23")]
		get
		{
			return default(NCCNCPLKFOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NCCNCPLKFOD CMHFFFMOPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xF77E50", Offset = "0xF76650", VA = "0x180F77E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private float FLHGPNPFKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xC64010", Offset = "0xC62810", VA = "0x180C64010", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool CCGDKMKLCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C940", Offset = "0x8A9B140", VA = "0x188A9C940", Slot = "24")]
	private bool NGALFNNDNOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C930", Offset = "0x8A9B130", VA = "0x188A9C930", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C960", Offset = "0x8A9B160", VA = "0x188A9C960")]
	public GMBBLKJLMIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal enum CCDDDDDAOFI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class KMGAAHONCIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum KFGMPGCJGMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public struct GHDMJCJADGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public NCCNCPLKFOD OKMIIABFPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public KFGMPGCJGMN BOGGFENGPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public List<GPBDHIPNJDG> BPJMANCOHGM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly KFGMPGCJGMN[] GKMIFLNPKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly NCCNCPLKFOD KAANEGCHJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private bool OOJKLKIAKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly GPBDHIPNJDG[] FAFGBKJDOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<GPBDHIPNJDG> JEIIIPNKHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly Stack<int> NPNBBMKGHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly List<GPBDHIPNJDG> NGLMEBMAOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly Stack<int> NDEMBALBCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly DFLPFEOCIAP AGDCDBINEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private bool HFCHLFGENLL;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public GHDMJCJADGG[,] KHILEFAKKOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x8AA15E0", Offset = "0x8A9FDE0", VA = "0x188AA15E0")]
	public KMGAAHONCIO(NCCNCPLKFOD JPJPDMBLMLB, DFLPFEOCIAP AGDCDBINEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8AA0A10", Offset = "0x8A9F210", VA = "0x188AA0A10")]
	public void EPICNKHDINO(GPBDHIPNJDG KMJPONBGMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8AA0260", Offset = "0x8A9EA60", VA = "0x188AA0260")]
	public void BJEHPLLGAJP(IList<GPBDHIPNJDG> CLKIEBOHMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8AA11D0", Offset = "0x8A9F9D0", VA = "0x188AA11D0")]
	public void MOJDIFAEJPH(IList<GPBDHIPNJDG> CLKIEBOHMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8AA06C0", Offset = "0x8A9EEC0", VA = "0x188AA06C0")]
	private void DKHNCAGLMHD(GPBDHIPNJDG KMJPONBGMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8AA00E0", Offset = "0x8A9E8E0", VA = "0x188AA00E0")]
	private void AAOKPGNJEKK(IList<GPBDHIPNJDG> CLKIEBOHMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8AA0540", Offset = "0x8A9ED40", VA = "0x188AA0540")]
	private CCDDDDDAOFI DHLJDGOHDAO(GPBDHIPNJDG KMJPONBGMIA)
	{
		return default(CCDDDDDAOFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8AA1060", Offset = "0x8A9F860", VA = "0x188AA1060")]
	public void JNHFKCNMNLI(float HADMPNPAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8AA0E70", Offset = "0x8A9F670", VA = "0x188AA0E70")]
	public void HDOOBFNGDNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8AA0B10", Offset = "0x8A9F310", VA = "0x188AA0B10")]
	private void FDOGCKIHEEH(List<GPBDHIPNJDG> CLKIEBOHMNL, Stack<int> PAKBHNIJFNH, bool JODEHOAEACM, float HMBMOHBCFNI = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8AA08F0", Offset = "0x8A9F0F0", VA = "0x188AA08F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8AA07B0", Offset = "0x8A9EFB0", VA = "0x188AA07B0")]
	private void DMPNIGMFDKF(List<GPBDHIPNJDG> CLKIEBOHMNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal class IPIFIGFFADP : DFLPFEOCIAP
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void ABOLJOPAGOK(string HPANEBBHGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
	public void ANFKJAMPACF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IPIFIGFFADP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal class CEGANCFNINA : AHLPPHJBNBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly Behaviour GIJIHCLGELM;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8A94570", Offset = "0x8A92D70", VA = "0x188A94570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool ALIOKCOAJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8A945F0", Offset = "0x8A92DF0", VA = "0x188A945F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LKKJKOFPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8A94550", Offset = "0x8A92D50", VA = "0x188A94550", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public CEGANCFNINA(Behaviour GIJIHCLGELM)
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

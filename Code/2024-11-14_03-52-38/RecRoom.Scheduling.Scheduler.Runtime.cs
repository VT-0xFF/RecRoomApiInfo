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
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x76DBF70", Offset = "0x76DB370", VA = "0x1876DBF70", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
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
		private delegate List<PlayerLoopSystem> IIBNICNCPJG(List<PlayerLoopSystem> FANOHCPPODJ, int FBAKMPLIAHK);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct HCGAPKMDHIM
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct APIOEBMHDMP
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static BDDIJCFMLKF JFBKGJNDIAI;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x76BFE90", Offset = "0x76BF290", VA = "0x1876BFE90")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct LCPJMFOCADO
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static BDDIJCFMLKF DKGLLDMOEII;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x76D3B20", Offset = "0x76D2F20", VA = "0x1876D3B20")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct BENMABLKOON
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static BDDIJCFMLKF NKEDOMDKKDJ;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x76C1090", Offset = "0x76C0490", VA = "0x1876C1090")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct AFDJOEBBAFE
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static BDDIJCFMLKF OAKBOKAHOJJ;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static BDDIJCFMLKF GDEJMCKGHIC;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static BDDIJCFMLKF GEGHJPFOIPE;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static BDDIJCFMLKF KOIAIDIBLFL;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x76BF290", Offset = "0x76BE690", VA = "0x1876BF290")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct JAENPFDKPIN
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static BDDIJCFMLKF EDEPPGJOFJC;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x76CED30", Offset = "0x76CE130", VA = "0x1876CED30")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct BIAFEPNGMHN
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static BDDIJCFMLKF OAKBOKAHOJJ;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static BDDIJCFMLKF GDEJMCKGHIC;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static BDDIJCFMLKF GEGHJPFOIPE;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static BDDIJCFMLKF KOIAIDIBLFL;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x76C1930", Offset = "0x76C0D30", VA = "0x1876C1930")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct MEEPADNAKDA
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static BDDIJCFMLKF LNMCHNMDJEO;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x76D82F0", Offset = "0x76D76F0", VA = "0x1876D82F0")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct INKJMFDGBCH
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static BDDIJCFMLKF NIIEFDJFBLD;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x76CE220", Offset = "0x76CD620", VA = "0x1876CE220")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct CIGNNAEBEPD
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static BDDIJCFMLKF KKMLPDDCHLM;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x76C3780", Offset = "0x76C2B80", VA = "0x1876C3780")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct PCFKJOMELBL
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static BDDIJCFMLKF LMIJMHLKCCL;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x76DAA70", Offset = "0x76D9E70", VA = "0x1876DAA70")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct JCBEOCMEFNH
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static BDDIJCFMLKF CIFKCGJLAHG;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x76CEF70", Offset = "0x76CE370", VA = "0x1876CEF70")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct JLHGAHMJAAJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static BDDIJCFMLKF DFJKEBCNHPG;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x76CF580", Offset = "0x76CE980", VA = "0x1876CF580")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct JCIHLCFDLJL
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static BDDIJCFMLKF OMEAJGDGGEC;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x76CF170", Offset = "0x76CE570", VA = "0x1876CF170")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct HELKDPBACON
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static BDDIJCFMLKF CMEOOIHNDPG;

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x76CC020", Offset = "0x76CB420", VA = "0x1876CC020")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public struct BOMNMGPKMEG
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static BDDIJCFMLKF KOHONJMDGEH;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x76C2280", Offset = "0x76C1680", VA = "0x1876C2280")]
				public static PlayerLoopSystem JFLCBJBFGEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public enum GEOAJNHAHFB : byte
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
			public struct CHGJPOCIEHM
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class NKPBDDLANCD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public GEOAJNHAHFB updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
					public NKPBDDLANCD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0x76DA690", Offset = "0x76D9A90", VA = "0x1876DA690")]
					internal void PBBDJLEJHDB()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static EJELNBCCPAC<GEOAJNHAHFB> HPHNJALOGII;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x76C35B0", Offset = "0x76C29B0", VA = "0x1876C35B0")]
				public static PlayerLoopSystem JFLCBJBFGEH(GEOAJNHAHFB AAKFJOKBJMB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000027")]
			internal struct JKPJKJPALGL
			{
				[Cpp2IlInjected.Token(Token = "0x2000028")]
				[CompilerGenerated]
				private sealed class CBHJBGAGOJO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public LPGJCKIHDLP.JNILFOJKIIM key;

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
					public CBHJBGAGOJO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005E")]
					[Cpp2IlInjected.Address(RVA = "0x76C2F30", Offset = "0x76C2330", VA = "0x1876C2F30")]
					internal void BNMPNNEGPNA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable AMAINOPEBPH;

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x76CF450", Offset = "0x76CE850", VA = "0x1876CF450")]
				public static PlayerLoopSystem DPPJHJPOHEE(LPGJCKIHDLP.JNILFOJKIIM PBFBBOFLBNL)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002A")]
			internal struct CDKANAAEBGA
			{
				[Cpp2IlInjected.Token(Token = "0x200002B")]
				[CompilerGenerated]
				private sealed class KNMCABNCEOK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public LPGJCKIHDLP.JNILFOJKIIM key;

					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
					public KNMCABNCEOK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x76D37C0", Offset = "0x76D2BC0", VA = "0x1876D37C0")]
					internal void BNMPNNEGPNA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x76C3480", Offset = "0x76C2880", VA = "0x1876C3480")]
				public static PlayerLoopSystem DPPJHJPOHEE(LPGJCKIHDLP.JNILFOJKIIM PBFBBOFLBNL)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class BKELENOMINC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public BKELENOMINC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x76C1C20", Offset = "0x76C1020", VA = "0x1876C1C20")]
			internal List<PlayerLoopSystem> BNLIOHGDKGB(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool DMFDEEMINBG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool NPNEHFLOBOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x76C4E20", Offset = "0x76C4220", VA = "0x1876C4E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76C4E60", Offset = "0x76C4260", VA = "0x1876C4E60")]
		private static void OGELPPHJLIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x76C4350", Offset = "0x76C3750", VA = "0x1876C4350")]
		private static void LBHCKLGDPDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76C3BB0", Offset = "0x76C2FB0", VA = "0x1876C3BB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76C3BF0", Offset = "0x76C2FF0", VA = "0x1876C3BF0")]
		private static void COCNJIPMIBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76C4C60", Offset = "0x76C4060", VA = "0x1876C4C60")]
		private static void MBDGADCIKJD(LPGJCKIHDLP.JNILFOJKIIM PBFBBOFLBNL, PlayerLoopSystem DNCNIDDHGOG, Type FODIJMOFIKE, Type DIDNBIIHPAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x76C3E40", Offset = "0x76C3240", VA = "0x1876C3E40")]
		private static void ELFAKKMLOMI(PlayerLoopSystem DNCNIDDHGOG, Type FODIJMOFIKE, Type DIDNBIIHPAO, IIBNICNCPJG NKLLNOHFBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76C4220", Offset = "0x76C3620", VA = "0x1876C4220")]
		private static void JMOHNCCOFJP(PlayerLoopSystem DNCNIDDHGOG, Type FODIJMOFIKE, Type DIDNBIIHPAO, PlayerLoopSystem? BMHMBBACGKC, PlayerLoopSystem? EEAMBNDKLPF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class LPGJCKIHDLP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum JNILFOJKIIM
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
	public class ANECNCDIJGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly JNILFOJKIIM JLLAGMJJHBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly NNGILCNNMAP AKOGCEFNNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long EKIKKJJDOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long HGAOEHNNMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long GFIPHDPPAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int CDCFBOLIAEG;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x76BFD80", Offset = "0x76BF180", VA = "0x1876BFD80")]
		public ANECNCDIJGM(JNILFOJKIIM FDOFMKMDJFN, int JICOCIKIGIA = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x76BFB30", Offset = "0x76BEF30", VA = "0x1876BFB30")]
		public void GPHEDGILEOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x76BFAE0", Offset = "0x76BEEE0", VA = "0x1876BFAE0")]
		public void ELFHABBAIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x76BFBA0", Offset = "0x76BEFA0", VA = "0x1876BFBA0")]
		public void IJIIFCMOGHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static JNILFOJKIIM[] NHOEHHEDAEC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static ANECNCDIJGM[] CODPPGNIIFB;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x76D5420", Offset = "0x76D4820", VA = "0x1876D5420")]
	public static ANECNCDIJGM OHOBCJNGBGE(JNILFOJKIIM PBFBBOFLBNL, int JICOCIKIGIA = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x76D5310", Offset = "0x76D4710", VA = "0x1876D5310")]
	public static ANECNCDIJGM ENAMIPDOKLB(JNILFOJKIIM PBFBBOFLBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x76D5380", Offset = "0x76D4780", VA = "0x1876D5380")]
	public static void JHBPOCBPEOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class NNGILCNNMAP : IKOMMEDDNIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int GAMADOCIEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Queue<double> ODABIKAFMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double AOFEGKJKMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double FBENJJMLPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double BGJFPMIINBN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double CLGOHHJLKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x76DA7D0", Offset = "0x76D9BD0", VA = "0x1876DA7D0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double CKIPFHPIGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5724E00", Offset = "0x5724200", VA = "0x185724E00", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double LMDIGHBKKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2214060", Offset = "0x2213460", VA = "0x182214060", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x76DA9C0", Offset = "0x76D9DC0", VA = "0x1876DA9C0")]
	public NNGILCNNMAP(int ALMJDBKCNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x76DA830", Offset = "0x76D9C30", VA = "0x1876DA830", Slot = "7")]
	public void CKFCBFEBJNL(double KCIHDEINMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x76DA950", Offset = "0x76D9D50", VA = "0x1876DA950", Slot = "8")]
	public void PGGELGPJGKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class LPOJALJDIEL : IKOMMEDDNIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private long GMOPHNCDIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private double GCCHDGGFBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private double CIDKLFIAPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private double DHCGMCLABGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private double IDOBELMIMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private double AOFEGKJKMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private double FBENJJMLPKG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double CKIPFHPIGDC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62A5580", Offset = "0x62A4980", VA = "0x1862A5580", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double LMDIGHBKKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x935890", Offset = "0x934C90", VA = "0x180935890", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double APCOPCJGANC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x62A5100", Offset = "0x62A4500", VA = "0x1862A5100")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double CLGOHHJLKGO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2841790", Offset = "0x2840B90", VA = "0x182841790", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x76D57A0", Offset = "0x76D4BA0", VA = "0x1876D57A0", Slot = "7")]
	public virtual void CKFCBFEBJNL(double KCIHDEINMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x76D58C0", Offset = "0x76D4CC0", VA = "0x1876D58C0", Slot = "8")]
	public virtual void PGGELGPJGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x76D52E0", Offset = "0x76D46E0", VA = "0x1876D52E0")]
	public LPOJALJDIEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LLOBGCKHDDI : LPOJALJDIEL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double CHKKIABDFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x62A50B0", Offset = "0x62A44B0", VA = "0x1862A50B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62A5130", Offset = "0x62A4530", VA = "0x1862A5130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x76D5170", Offset = "0x76D4570", VA = "0x1876D5170", Slot = "7")]
	public override void CKFCBFEBJNL(double KCIHDEINMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x76D52A0", Offset = "0x76D46A0", VA = "0x1876D52A0", Slot = "8")]
	public override void PGGELGPJGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x76D52E0", Offset = "0x76D46E0", VA = "0x1876D52E0")]
	public LLOBGCKHDDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface IKOMMEDDNIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double CLGOHHJLKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double CKIPFHPIGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double LMDIGHBKKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class IHEDPDFDCMB
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private interface HJGEHBOPGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool JPLFLMBDFEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KFLFGPBPNBL();
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private class FFLMBICDJPI : HJGEHBOPGPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly Action LLIKOHELCCA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool JPLFLMBDFEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
		public FFLMBICDJPI(Action LLIKOHELCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xC6F730", Offset = "0xC6EB30", VA = "0x180C6F730", Slot = "5")]
		public void KFLFGPBPNBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly List<HJGEHBOPGPJ> KJLMDJDMNOF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x76CD950", Offset = "0x76CCD50", VA = "0x1876CD950")]
	public static void NHCJAHJGDKO(Action LLIKOHELCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x76CD330", Offset = "0x76CC730", VA = "0x1876CD330")]
	private static void IHELGBLPOFN(HJGEHBOPGPJ BCDEKFLBENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x76CD650", Offset = "0x76CCA50", VA = "0x1876CD650")]
	private static void MPELHOHMLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x76CD550", Offset = "0x76CC950", VA = "0x1876CD550")]
	private static void LCGDDHAOAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x76CD250", Offset = "0x76CC650", VA = "0x1876CD250")]
	private static void BKHKDFGBNCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class KHBFKNOANOI
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct EBHMLCKOMMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public TaskCompletionSource<Scene> KIHDJPEPJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly string HAINAAJKJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly LoadSceneMode DOILDKPHIEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly bool NPELDPBPIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly ELNHPHNENME<string>.KGEBNKHIPGG CEEPOICAIPG;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x76C8B30", Offset = "0x76C7F30", VA = "0x1876C8B30")]
		public EBHMLCKOMMK(TaskCompletionSource<Scene> PKEIDCHDBJM, string HAINAAJKJPM, LoadSceneMode DOILDKPHIEP, bool NPELDPBPIFD, ELNHPHNENME<string>.KGEBNKHIPGG CEEPOICAIPG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct IOPIIGNDMPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public ELNHPHNENME<string>.KGEBNKHIPGG stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ELNHPHNENME<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x76CE420", Offset = "0x76CD820", VA = "0x1876CE420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x76CECC0", Offset = "0x76CE0C0", VA = "0x1876CECC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct KENGDJJMCIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x76D10F0", Offset = "0x76D04F0", VA = "0x1876D10F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x76D1410", Offset = "0x76D0810", VA = "0x1876D1410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct IIODNLHBMAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private EBHMLCKOMMK <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x76CDA80", Offset = "0x76CCE80", VA = "0x1876CDA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x76CDE40", Offset = "0x76CD240", VA = "0x1876CDE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class POOKIDGOCOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public JGFPMDAOPIA<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public POOKIDGOCOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x76DACC0", Offset = "0x76DA0C0", VA = "0x1876DACC0")]
		internal void BHEPOOPMENC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct DHJDNEFNNMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public ELNHPHNENME<string>.KGEBNKHIPGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private POOKIDGOCOA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private ELNHPHNENME<string>.KGEBNKHIPGG <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ELNHPHNENME<string>.KGEBNKHIPGG <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x76C7F50", Offset = "0x76C7350", VA = "0x1876C7F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x76C8AC0", Offset = "0x76C7EC0", VA = "0x1876C8AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BOMKLBKKFOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x76C1D40", Offset = "0x76C1140", VA = "0x1876C1D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x76C2210", Offset = "0x76C1610", VA = "0x1876C2210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct BBDMKGDNJEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public ELNHPHNENME<string>.KGEBNKHIPGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private ELNHPHNENME<string>.KGEBNKHIPGG <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private ELNHPHNENME<string>.KGEBNKHIPGG <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x76C0090", Offset = "0x76BF490", VA = "0x1876C0090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x76C0BB0", Offset = "0x76BFFB0", VA = "0x1876C0BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class DDBNCLJHELE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public DDBNCLJHELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x76C7F20", Offset = "0x76C7320", VA = "0x1876C7F20")]
		internal bool PBNMEAHFDCG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class BCOMHCGCHKO : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public ONPFBNMJAGM onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public BCOMHCGCHKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x76C1000", Offset = "0x76C0400", VA = "0x1876C1000", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x76C0C70", Offset = "0x76C0070", VA = "0x1876C0C70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x76C0C20", Offset = "0x76C0020", VA = "0x1876C0C20")]
		private void KAONCANHJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x76C0FB0", Offset = "0x76C03B0", VA = "0x1876C0FB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class FGGILIEEDAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public JGFPMDAOPIA<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public FGGILIEEDAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x76CA6E0", Offset = "0x76C9AE0", VA = "0x1876CA6E0")]
		internal bool PJHFENBKPNP(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x76CA460", Offset = "0x76C9860", VA = "0x1876CA460")]
		internal void NKFIFNCPHKF(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class IBCMGMMLKHF : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public JGFPMDAOPIA<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private FGGILIEEDAJ <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public IBCMGMMLKHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x76CCB80", Offset = "0x76CBF80", VA = "0x1876CCB80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x76CD200", Offset = "0x76CC600", VA = "0x1876CD200", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly ICollection<string> CFNEHJCIHFO;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static NNKCIMLKELB AHCMDCHPIME;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static AsyncOperation BDOKJIABBBK;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static NNKCIMLKELB PBMIONJOLOM;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static string IGAKAEMHPOB;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static ThreadPriority GBMLJOOIKNG;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static Task PNNPKDBMBBA;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static List<SceneInstance> AIMKOAANFHL;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly Queue<EBHMLCKOMMK> OIKLALKENPK;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static Task KCKNOKBHAIK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool DFGNCEIBDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x76D23D0", Offset = "0x76D17D0", VA = "0x1876D23D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private static bool MBDBIDNAMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x76D16A0", Offset = "0x76D0AA0", VA = "0x1876D16A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private static bool LFGCDNKCGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x76D2B60", Offset = "0x76D1F60", VA = "0x1876D2B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool ENBKEAMONAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x76D2CA0", Offset = "0x76D20A0", VA = "0x1876D2CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> FKEGGKPNFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x76D1C00", Offset = "0x76D1000", VA = "0x1876D1C00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x76D1740", Offset = "0x76D0B40", VA = "0x1876D1740")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x76D2220", Offset = "0x76D1620", VA = "0x1876D2220")]
	[DOKEIHGOPGG(AFDHANBPPBK.EnteredEditModeNextFrame, 0)]
	private static void FOIMBLEIIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x76D1AB0", Offset = "0x76D0EB0", VA = "0x1876D1AB0")]
	[AsyncStateMachine(typeof(IOPIIGNDMPK))]
	public static Task<Scene> BAJBILMCDGM(string HAINAAJKJPM, LoadSceneMode DOILDKPHIEP = LoadSceneMode.Single, bool NPELDPBPIFD = false, [Optional] ELNHPHNENME<string>.KGEBNKHIPGG OMLHLPLIMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x76D2320", Offset = "0x76D1720", VA = "0x1876D2320")]
	[AsyncStateMachine(typeof(KENGDJJMCIN))]
	private static Task HDJFGLIEJIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x76D25F0", Offset = "0x76D19F0", VA = "0x1876D25F0")]
	[AsyncStateMachine(typeof(IIODNLHBMAP))]
	private static Task JNMHIOIJDOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x76D1960", Offset = "0x76D0D60", VA = "0x1876D1960")]
	[AsyncStateMachine(typeof(DHJDNEFNNMG))]
	private static Task<Scene> ANDDANICKKA(string HAINAAJKJPM, LoadSceneMode DOILDKPHIEP, bool NPELDPBPIFD, ELNHPHNENME<string>.KGEBNKHIPGG CEEPOICAIPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x76D1E40", Offset = "0x76D1240", VA = "0x1876D1E40")]
	private static void DECLIGCCOGP(SceneInstance NAEMIMNOMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x76D27E0", Offset = "0x76D1BE0", VA = "0x1876D27E0")]
	private static void NAHDFEGLKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x76D26C0", Offset = "0x76D1AC0", VA = "0x1876D26C0")]
	[AsyncStateMachine(typeof(BOMKLBKKFOE))]
	private static Task<Scene> MCGFAEKCCJB(string HAINAAJKJPM, LoadSceneMode DOILDKPHIEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x76D15B0", Offset = "0x76D09B0", VA = "0x1876D15B0")]
	private static bool AHLCJODLNLP(string HAINAAJKJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x76D1850", Offset = "0x76D0C50", VA = "0x1876D1850")]
	[AsyncStateMachine(typeof(BBDMKGDNJEH))]
	private static Task<Scene> ALLHJFJLFCH(ELNHPHNENME<string>.KGEBNKHIPGG CEEPOICAIPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x76D29E0", Offset = "0x76D1DE0", VA = "0x1876D29E0")]
	public static ELLFHPNCMJG<Scene> NGGNHIIODCO(string HAINAAJKJPM, LoadSceneMode DOILDKPHIEP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x76D1F50", Offset = "0x76D1350", VA = "0x1876D1F50")]
	public static NNKCIMLKELB EEGPGJMDJBL(string HAINAAJKJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x76D2D30", Offset = "0x76D2130", VA = "0x1876D2D30")]
	[IteratorStateMachine(typeof(BCOMHCGCHKO))]
	private static IEnumerator<MLEAAPMIINP> PKGIIDJLIMI(string HAINAAJKJPM, ONPFBNMJAGM POHPOOGDLFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x76D2C00", Offset = "0x76D2000", VA = "0x1876D2C00")]
	[IteratorStateMachine(typeof(IBCMGMMLKHF))]
	private static IEnumerator<MLEAAPMIINP> OHOJCAMDFCE(string HAINAAJKJPM, LoadSceneMode DOILDKPHIEP, JGFPMDAOPIA<Scene> POHPOOGDLFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x76D1D10", Offset = "0x76D1110", VA = "0x1876D1D10")]
	public static bool BIMGHJGALEH([Out] string JMKBOAOOFPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class INALDDOPEGO
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x76CE190", Offset = "0x76CD590", VA = "0x1876CE190")]
	public static IDisposable OMFDBPINJCA(this PDFFNCFJIFE EPLPPJHJIIM, float KMDECEKCPHN, Action<float> PGHJNJLEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x76CE090", Offset = "0x76CD490", VA = "0x1876CE090")]
	public static IDisposable CEKGDOMIIFC(this PDFFNCFJIFE EPLPPJHJIIM, Action<float> PGHJNJLEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x76CE110", Offset = "0x76CD510", VA = "0x1876CE110")]
	public static IDisposable CLPPDHIKCIJ(this PDFFNCFJIFE EPLPPJHJIIM, Action<float> PGHJNJLEBOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class BPHONPLIHEM
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x76C2630", Offset = "0x76C1A30", VA = "0x1876C2630")]
	public static IDisposable CHIEDPFKPGI(this MonoBehaviour LDNLNKHKMPL, Action PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x76C25A0", Offset = "0x76C19A0", VA = "0x1876C25A0")]
	public static IDisposable CHIEDPFKPGI(this MonoBehaviour LDNLNKHKMPL, Action<float> PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x76C2810", Offset = "0x76C1C10", VA = "0x1876C2810")]
	public static IDisposable DPCLJOJLMCI(this MonoBehaviour LDNLNKHKMPL, Action PGHJNJLEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x76C2E80", Offset = "0x76C2280", VA = "0x1876C2E80")]
	public static IDisposable OPGFDLMFGNK(this MonoBehaviour LDNLNKHKMPL, Action PGHJNJLEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x76C2E00", Offset = "0x76C2200", VA = "0x1876C2E00")]
	public static IDisposable OPGFDLMFGNK(this MonoBehaviour LDNLNKHKMPL, Action<float> PGHJNJLEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x76C2520", Offset = "0x76C1920", VA = "0x1876C2520")]
	public static IDisposable BMPFBNMGFGG(this MonoBehaviour LDNLNKHKMPL, Action PGHJNJLEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x76C2CE0", Offset = "0x76C20E0", VA = "0x1876C2CE0")]
	public static IDisposable OLEHKHMBLIE(this MonoBehaviour LDNLNKHKMPL, Action PGHJNJLEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x76C2BC0", Offset = "0x76C1FC0", VA = "0x1876C2BC0")]
	public static IDisposable LDKALPBPDFF(this MonoBehaviour LDNLNKHKMPL, Action PGHJNJLEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x76C2760", Offset = "0x76C1B60", VA = "0x1876C2760")]
	public static IDisposable CLAKCFIAHGF(this MonoBehaviour LDNLNKHKMPL, float KMDECEKCPHN, Action<float> PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO, bool NOPLLEPGPGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x76C2F00", Offset = "0x76C2300", VA = "0x1876C2F00")]
	public static IDisposable PMPDFIKMOBC(this MonoBehaviour LDNLNKHKMPL, float KMDECEKCPHN, Action<float> PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO, bool NOPLLEPGPGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x76C2D60", Offset = "0x76C2160", VA = "0x1876C2D60")]
	public static IDisposable OPBJDDNEHPC(this MonoBehaviour LDNLNKHKMPL, float KMDECEKCPHN, Action<float> PGHJNJLEBOJ, bool NOPLLEPGPGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x76C2A80", Offset = "0x76C1E80", VA = "0x1876C2A80")]
	public static IDisposable HOEEGICDEMF(this MonoBehaviour LDNLNKHKMPL, Action<float> PGHJNJLEBOJ, bool NOPLLEPGPGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x76C2B20", Offset = "0x76C1F20", VA = "0x1876C2B20")]
	public static IDisposable JDMPAJBGOLH(this MonoBehaviour LDNLNKHKMPL, Action<float> PGHJNJLEBOJ, bool NOPLLEPGPGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x76C26C0", Offset = "0x76C1AC0", VA = "0x1876C26C0")]
	public static IDisposable CKDFJDFMADP(this MonoBehaviour LDNLNKHKMPL, Action<float> PGHJNJLEBOJ, bool NOPLLEPGPGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x76C2C40", Offset = "0x76C2040", VA = "0x1876C2C40")]
	public static IDisposable NKEMJCHNFDG(this MonoBehaviour LDNLNKHKMPL, Action<float> PGHJNJLEBOJ, bool NOPLLEPGPGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x76C2930", Offset = "0x76C1D30", VA = "0x1876C2930")]
	public static IDisposable GADMAHMHAAJ(this MonoBehaviour LDNLNKHKMPL, Action<float> PGHJNJLEBOJ, bool NOPLLEPGPGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x76C2890", Offset = "0x76C1C90", VA = "0x1876C2890")]
	public static IDisposable EABHHOKOCDP(this MonoBehaviour LDNLNKHKMPL, Action<float> PGHJNJLEBOJ, bool NOPLLEPGPGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x76C2480", Offset = "0x76C1880", VA = "0x1876C2480")]
	public static IDisposable ALBIPFMINDK(this MonoBehaviour LDNLNKHKMPL, Action<float> PGHJNJLEBOJ, bool NOPLLEPGPGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x76C29D0", Offset = "0x76C1DD0", VA = "0x1876C29D0")]
	public static IDisposable HKMCIHEFPNN(this MonoBehaviour LDNLNKHKMPL, float KMDECEKCPHN, Action<float> PGHJNJLEBOJ, bool NOPLLEPGPGI = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class CBPHGOCKABL
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class ILIKGECHOPN : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public KDFAHLPCJJK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private IKDPACLCBHM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public ILIKGECHOPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x76CDEA0", Offset = "0x76CD2A0", VA = "0x1876CDEA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x76CDF80", Offset = "0x76CD380", VA = "0x1876CDF80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class KGIKFFPJCDP : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public KDFAHLPCJJK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private IKDPACLCBHM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public KGIKFFPJCDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x76D1470", Offset = "0x76D0870", VA = "0x1876D1470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x76D1560", Offset = "0x76D0960", VA = "0x1876D1560", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x76C32E0", Offset = "0x76C26E0", VA = "0x1876C32E0")]
	public static IDFKLKAPHIN CHIEDPFKPGI(Action PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x76C3170", Offset = "0x76C2570", VA = "0x1876C3170")]
	public static IDFKLKAPHIN CHIEDPFKPGI(Behaviour EPLPPJHJIIM, Action PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x76C3200", Offset = "0x76C2600", VA = "0x1876C3200")]
	public static IDFKLKAPHIN CHIEDPFKPGI(Behaviour EPLPPJHJIIM, Action<float> PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x76C3360", Offset = "0x76C2760", VA = "0x1876C3360")]
	[IteratorStateMachine(typeof(ILIKGECHOPN))]
	private static IEnumerator<MLEAAPMIINP> PFBCAGFGFLH(KDFAHLPCJJK LBIOCHJBOOC, Action PGHJNJLEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x76C33F0", Offset = "0x76C27F0", VA = "0x1876C33F0")]
	[IteratorStateMachine(typeof(KGIKFFPJCDP))]
	private static IEnumerator<MLEAAPMIINP> PFBCAGFGFLH(KDFAHLPCJJK LBIOCHJBOOC, Action<float> PGHJNJLEBOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class MIJODKGGEDL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JFIACDOBHPO : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public MIJODKGGEDL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public JFIACDOBHPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x76CF370", Offset = "0x76CE770", VA = "0x1876CF370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x76CF400", Offset = "0x76CE800", VA = "0x1876CF400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly KDFAHLPCJJK JAOHIJACMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Action JHMOBGDKBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool JAJJMLDOPIP;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool EBKHGCJIJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A1FC0", Offset = "0x8A13C0", VA = "0x1808A1FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x76D9350", Offset = "0x76D8750", VA = "0x1876D9350")]
	public MIJODKGGEDL(KDFAHLPCJJK JAOHIJACMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x76D9230", Offset = "0x76D8630", VA = "0x1876D9230")]
	[IteratorStateMachine(typeof(JFIACDOBHPO))]
	private IEnumerator<MLEAAPMIINP> FIACNNBKKCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x76D92B0", Offset = "0x76D86B0", VA = "0x1876D92B0", Slot = "4")]
	public void OnCompleted(Action BFKGOPJEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	public void NIBBLPNLAHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class CIICMICNKBF
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x76C3980", Offset = "0x76C2D80", VA = "0x1876C3980")]
	public static MIJODKGGEDL IGCCDNCCHKD(this KDFAHLPCJJK JAOHIJACMHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class HFCFDFDAIAO
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class FOFEKDMIILO : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public CODMHNCIGLF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public FOFEKDMIILO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x76CA760", Offset = "0x76C9B60", VA = "0x1876CA760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x76CA7E0", Offset = "0x76C9BE0", VA = "0x1876CA7E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x76CC4B0", Offset = "0x76CB8B0", VA = "0x1876CC4B0")]
	public static IDFKLKAPHIN CHIEDPFKPGI(float KMDECEKCPHN, Action<float> PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO, bool NOPLLEPGPGI = true, [Optional] KBBANPCOGCH FLDNENGOFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x76CC3E0", Offset = "0x76CB7E0", VA = "0x1876CC3E0")]
	public static IDFKLKAPHIN CHIEDPFKPGI(MonoBehaviour LDNLNKHKMPL, float KMDECEKCPHN, Action<float> PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO, bool NOPLLEPGPGI = true, [Optional] KBBANPCOGCH FLDNENGOFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x76CC220", Offset = "0x76CB620", VA = "0x1876CC220")]
	public static IDFKLKAPHIN ANLDCEMCPHJ(MonoBehaviour LDNLNKHKMPL, float KMDECEKCPHN, Action<float> PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO, bool NOPLLEPGPGI = true, [Optional] KBBANPCOGCH FLDNENGOFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x76CC310", Offset = "0x76CB710", VA = "0x1876CC310")]
	public static IDFKLKAPHIN AOHKPDPANJB(PDFFNCFJIFE EPLPPJHJIIM, float KMDECEKCPHN, Action<float> PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO, bool NOPLLEPGPGI = true, [Optional] KBBANPCOGCH FLDNENGOFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x76CC670", Offset = "0x76CBA70", VA = "0x1876CC670")]
	private static IEnumerator<MLEAAPMIINP> PFBCAGFGFLH(GKDCIPMCBOP DKGPCNANDJJ, float KMDECEKCPHN, KDFAHLPCJJK LBIOCHJBOOC, Action<float> PGHJNJLEBOJ, bool NOPLLEPGPGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x76CC580", Offset = "0x76CB980", VA = "0x1876CC580")]
	private static IEnumerator<MLEAAPMIINP> LKOGIFHNFCJ(GKDCIPMCBOP DKGPCNANDJJ, float KMDECEKCPHN, KDFAHLPCJJK LBIOCHJBOOC, Action<float> PGHJNJLEBOJ, bool NOPLLEPGPGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x76CC5E0", Offset = "0x76CB9E0", VA = "0x1876CC5E0")]
	[IteratorStateMachine(typeof(FOFEKDMIILO))]
	private static IEnumerator<MLEAAPMIINP> NGILKNBIMGP(CODMHNCIGLF AAEIKGBOGPG, float KMDECEKCPHN, KDFAHLPCJJK LBIOCHJBOOC, Action<float> PGHJNJLEBOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class HAGKOFDPILJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class GLCMAMNACOL : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public KDFAHLPCJJK queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public GLCMAMNACOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x76CB3E0", Offset = "0x76CA7E0", VA = "0x1876CB3E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x76CB4A0", Offset = "0x76CA8A0", VA = "0x1876CB4A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x76CB6E0", Offset = "0x76CAAE0", VA = "0x1876CB6E0")]
	[IteratorStateMachine(typeof(GLCMAMNACOL))]
	private static IEnumerator<MLEAAPMIINP> KNFLHPMBNDB(KDFAHLPCJJK JAOHIJACMHO, Func<bool> NAFCJPGDPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x76CB600", Offset = "0x76CAA00", VA = "0x1876CB600")]
	public static IDFKLKAPHIN DOKKGHFMPFG(this MonoBehaviour LDNLNKHKMPL, Func<bool> NAFCJPGDPLL, KDFAHLPCJJK JAOHIJACMHO = KDFAHLPCJJK.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class FPJIMDOEOGN
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class NMDHDNNGMEP : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public KDFAHLPCJJK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public NMDHDNNGMEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x76DA710", Offset = "0x76D9B10", VA = "0x1876DA710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x76DA780", Offset = "0x76D9B80", VA = "0x1876DA780", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class KOLFJICBLPJ : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public KDFAHLPCJJK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private MLEAAPMIINP <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public KOLFJICBLPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x76D3A40", Offset = "0x76D2E40", VA = "0x1876D3A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x76D3AD0", Offset = "0x76D2ED0", VA = "0x1876D3AD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x76CAB40", Offset = "0x76C9F40", VA = "0x1876CAB40")]
	[IteratorStateMachine(typeof(NMDHDNNGMEP))]
	private static IEnumerator<MLEAAPMIINP> FIACNNBKKCA(float FOPCLCJOGBF, KDFAHLPCJJK LBIOCHJBOOC, Action FDHGHLDCDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x76CAAA0", Offset = "0x76C9EA0", VA = "0x1876CAAA0")]
	[IteratorStateMachine(typeof(KOLFJICBLPJ))]
	private static IEnumerator<MLEAAPMIINP> FDIPKCPJKEK(float FOPCLCJOGBF, KDFAHLPCJJK LBIOCHJBOOC, Action FDHGHLDCDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x76CAE50", Offset = "0x76CA250", VA = "0x1876CAE50")]
	public static IDisposable LLJAGKMAMAL(this MonoBehaviour LDNLNKHKMPL, float FOPCLCJOGBF, Action FDHGHLDCDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x76CAA10", Offset = "0x76C9E10", VA = "0x1876CAA10")]
	public static IDFKLKAPHIN DKBCGJJJIBA(this MonoBehaviour LDNLNKHKMPL, float FOPCLCJOGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x76CAF30", Offset = "0x76CA330", VA = "0x1876CAF30")]
	public static IDFKLKAPHIN LLJAGKMAMAL(this MonoBehaviour LDNLNKHKMPL, float FOPCLCJOGBF, KDFAHLPCJJK LBIOCHJBOOC, Action FDHGHLDCDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x76CB0C0", Offset = "0x76CA4C0", VA = "0x1876CB0C0")]
	public static IDFKLKAPHIN MIMALKMOAPG(this MonoBehaviour LDNLNKHKMPL, Action FDHGHLDCDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x76CB160", Offset = "0x76CA560", VA = "0x1876CB160")]
	public static IDFKLKAPHIN ODDOIOMFICK(this MonoBehaviour LDNLNKHKMPL, Action FDHGHLDCDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x76CB020", Offset = "0x76CA420", VA = "0x1876CB020")]
	public static IDFKLKAPHIN LNGJDPEFEED(this MonoBehaviour LDNLNKHKMPL, Action FDHGHLDCDAN, [Optional] KBBANPCOGCH FLDNENGOFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x76CADB0", Offset = "0x76CA1B0", VA = "0x1876CADB0")]
	public static IDFKLKAPHIN LHJJOGIOBKM(this MonoBehaviour LDNLNKHKMPL, Action FDHGHLDCDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x76CAC80", Offset = "0x76CA080", VA = "0x1876CAC80")]
	public static IDFKLKAPHIN HFLIFHCDFBH(this MonoBehaviour LDNLNKHKMPL, Action FDHGHLDCDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x76CA970", Offset = "0x76C9D70", VA = "0x1876CA970")]
	private static IDFKLKAPHIN DHADJLIGPJG(MonoBehaviour LDNLNKHKMPL, KDFAHLPCJJK JAOHIJACMHO, Action FDHGHLDCDAN, [Optional] KBBANPCOGCH FLDNENGOFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x76CAD20", Offset = "0x76CA120", VA = "0x1876CAD20")]
	public static IDFKLKAPHIN JPHNEHCCNEL(this MonoBehaviour LDNLNKHKMPL, float AGLADCKACHC, Action FDHGHLDCDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x76CA8D0", Offset = "0x76C9CD0", VA = "0x1876CA8D0")]
	public static IDFKLKAPHIN DBDMKIBLCDB(this MonoBehaviour LDNLNKHKMPL, float AGLADCKACHC, Action FDHGHLDCDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x76CA830", Offset = "0x76C9C30", VA = "0x1876CA830")]
	public static IDFKLKAPHIN CANKIDELCND(this MonoBehaviour LDNLNKHKMPL, float AGLADCKACHC, Action FDHGHLDCDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x76CABE0", Offset = "0x76C9FE0", VA = "0x1876CABE0")]
	public static IDFKLKAPHIN GDDNBDFBDOJ(this MonoBehaviour LDNLNKHKMPL, float AGLADCKACHC, Action FDHGHLDCDAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class NHLBDEHLOBP : MMIPPAMOBEK, IEnumerable<MMIPPAMOBEK>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly List<MMIPPAMOBEK> LEIEOHCEKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool HPAPOCEHIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Action FKALEMLKDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool FDAHBGLNALN;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FAPKDKJOAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x76D9910", Offset = "0x76D8D10", VA = "0x1876D9910", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GJNEDJGLGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x76D9870", Offset = "0x76D8C70", VA = "0x1876D9870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x76D9F20", Offset = "0x76D9320", VA = "0x1876D9F20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x76DA120", Offset = "0x76D9520", VA = "0x1876DA120")]
	public NHLBDEHLOBP([Optional] Action FKALEMLKDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x76D9D70", Offset = "0x76D9170", VA = "0x1876D9D70")]
	public void FNBCENOGBNB(MMIPPAMOBEK BLDPGADOKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x76D9FC0", Offset = "0x76D93C0", VA = "0x1876D9FC0")]
	private void PGPHPHDCNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x76D9A50", Offset = "0x76D8E50", VA = "0x1876D9A50", Slot = "7")]
	public bool FALMPPCGNEC(bool DLFLBGAHCIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x76D9A60", Offset = "0x76D8E60", VA = "0x1876D9A60", Slot = "8")]
	public bool FALMPPCGNEC(Action LLIKOHELCCA, bool DLFLBGAHCIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x76D9EA0", Offset = "0x76D92A0", VA = "0x1876D9EA0", Slot = "9")]
	public IEnumerator<MMIPPAMOBEK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x76D9EA0", Offset = "0x76D92A0", VA = "0x1876D9EA0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class HLPCPBCCBCF : EKOCAIPEGCM
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class FCEADFPNILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public HLPCPBCCBCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public FCEADFPNILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x76C92C0", Offset = "0x76C86C0", VA = "0x1876C92C0")]
		internal void LLEAAJCLHGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class FIAECMEDOIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public HLPCPBCCBCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public FIAECMEDOIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x76C92C0", Offset = "0x76C86C0", VA = "0x1876C92C0")]
		internal void PKNBIBPLGIG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float IGFJHLHDKMM;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x76CCA40", Offset = "0x76CBE40", VA = "0x1876CCA40")]
	public HLPCPBCCBCF(Behaviour EPLPPJHJIIM, float IGFJHLHDKMM, [Optional] Action FKALEMLKDMM, [Optional] KBBANPCOGCH FLDNENGOFCA, [Optional] GKDCIPMCBOP DKGPCNANDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x76CC930", Offset = "0x76CBD30", VA = "0x1876CC930", Slot = "9")]
	protected override bool NBPPBHAKJLH(Action LLIKOHELCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x76CC820", Offset = "0x76CBC20", VA = "0x1876CC820", Slot = "10")]
	protected override bool GHGPJBNFIMI(Action LLIKOHELCCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface MMIPPAMOBEK
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FAPKDKJOAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GJNEDJGLGHK;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FALMPPCGNEC(bool DLFLBGAHCIJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FALMPPCGNEC(Action LLIKOHELCCA, bool DLFLBGAHCIJ = false);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public abstract class EKOCAIPEGCM : MMIPPAMOBEK
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class COAGKFGNAMG : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public EKOCAIPEGCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public COAGKFGNAMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x76C3A90", Offset = "0x76C2E90", VA = "0x1876C3A90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x76C3B60", Offset = "0x76C2F60", VA = "0x1876C3B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Behaviour EPLPPJHJIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly Action FKALEMLKDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private HBMBDNJPECN GNEBLCMOJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly KBBANPCOGCH FLDNENGOFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	protected readonly GKDCIPMCBOP DKGPCNANDJJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool FAPKDKJOAKD
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x11F2820", Offset = "0x11F1C20", VA = "0x1811F2820", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GJNEDJGLGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x76C8C60", Offset = "0x76C8060", VA = "0x1876C8C60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x76C90F0", Offset = "0x76C84F0", VA = "0x1876C90F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x76C9190", Offset = "0x76C8590", VA = "0x1876C9190")]
	protected EKOCAIPEGCM(Behaviour EPLPPJHJIIM, [Optional] Action FKALEMLKDMM, [Optional] KBBANPCOGCH FLDNENGOFCA, [Optional] GKDCIPMCBOP DKGPCNANDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x76C8D00", Offset = "0x76C8100", VA = "0x1876C8D00", Slot = "7")]
	public bool FALMPPCGNEC(bool DLFLBGAHCIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x76C8D60", Offset = "0x76C8160", VA = "0x1876C8D60", Slot = "8")]
	public bool FALMPPCGNEC(Action LLIKOHELCCA, bool DLFLBGAHCIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool NBPPBHAKJLH(Action LLIKOHELCCA);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool GHGPJBNFIMI(Action LLIKOHELCCA);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x76C8DC0", Offset = "0x76C81C0", VA = "0x1876C8DC0")]
	protected void GAODPMPJKFJ(Action LLIKOHELCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x76C8EA0", Offset = "0x76C82A0", VA = "0x1876C8EA0")]
	protected NNKCIMLKELB JIFGMFOHPNN(float IKJGJGIMFPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x76C8DE0", Offset = "0x76C81E0", VA = "0x1876C8DE0")]
	private void HPMFCJKJIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x76C8BD0", Offset = "0x76C7FD0", VA = "0x1876C8BD0")]
	[IteratorStateMachine(typeof(COAGKFGNAMG))]
	private IEnumerator<MLEAAPMIINP> ABNGEBHLBMF(float IKJGJGIMFPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x76C8E60", Offset = "0x76C8260", VA = "0x1876C8E60")]
	[CompilerGenerated]
	private void IDDLHAKNNCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class MLKHFKMAMAA : EKOCAIPEGCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly float HLOHPNBHMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int LPJNMJEGCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly float OPAGAGKLENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly float[] BOGJEFFMJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private int GLMFPPFFNEO;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x76D96A0", Offset = "0x76D8AA0", VA = "0x1876D96A0")]
	public MLKHFKMAMAA(Behaviour EPLPPJHJIIM, float FABDKOPALGJ, int LPJNMJEGCOD, [Optional] Action FKALEMLKDMM, float OPAGAGKLENH = 0f, [Optional] KBBANPCOGCH FLDNENGOFCA, [Optional] GKDCIPMCBOP DKGPCNANDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "9")]
	protected override bool NBPPBHAKJLH(Action LLIKOHELCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x76D94A0", Offset = "0x76D88A0", VA = "0x1876D94A0", Slot = "10")]
	protected override bool GHGPJBNFIMI(Action LLIKOHELCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x76D9420", Offset = "0x76D8820", VA = "0x1876D9420")]
	private void ACAIHAEFAIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JAFECJHFPFO : EKOCAIPEGCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly float IGFJHLHDKMM;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x76CCA40", Offset = "0x76CBE40", VA = "0x1876CCA40")]
	public JAFECJHFPFO(Behaviour EPLPPJHJIIM, float IGFJHLHDKMM, [Optional] Action FKALEMLKDMM, [Optional] KBBANPCOGCH FLDNENGOFCA, [Optional] GKDCIPMCBOP DKGPCNANDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "9")]
	protected override bool NBPPBHAKJLH(Action LLIKOHELCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x76CEF30", Offset = "0x76CE330", VA = "0x1876CEF30", Slot = "10")]
	protected override bool GHGPJBNFIMI(Action LLIKOHELCCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class BGHMMFIKCHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class PENKCKEMGBC : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public PENKCKEMGBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x76CDFD0", Offset = "0x76CD3D0", VA = "0x1876CDFD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x76DAC70", Offset = "0x76DA070", VA = "0x1876DAC70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private IDFKLKAPHIN LDKEFAHBBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private PDFFNCFJIFE EPLPPJHJIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> GBNCFJCHGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private KDFAHLPCJJK JAOHIJACMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float EHLGGLNCLAK;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x76C1790", Offset = "0x76C0B90", VA = "0x1876C1790")]
	public BGHMMFIKCHF(PDFFNCFJIFE EPLPPJHJIIM, float KMDECEKCPHN, Action<float> PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x76C1370", Offset = "0x76C0770", VA = "0x1876C1370")]
	private void HHEOMIACAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x76C14E0", Offset = "0x76C08E0", VA = "0x1876C14E0")]
	private void NMFNHNLOFMC(string IBDGAGPHJHE, Action LOLAFLPCFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x76C12F0", Offset = "0x76C06F0", VA = "0x1876C12F0")]
	[IteratorStateMachine(typeof(PENKCKEMGBC))]
	private IEnumerator<MLEAAPMIINP> GMGPOILNLAE(Action LOLAFLPCFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x76C1290", Offset = "0x76C0690", VA = "0x1876C1290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x76C1610", Offset = "0x76C0A10", VA = "0x1876C1610")]
	[CompilerGenerated]
	private void PBJLKJAOAKJ(string DACOLACFJMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class FCFLEAPILBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class ILJPBFLBCNB : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public ILJPBFLBCNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x76CDFD0", Offset = "0x76CD3D0", VA = "0x1876CDFD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x76CE040", Offset = "0x76CD440", VA = "0x1876CE040", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private IDFKLKAPHIN LDKEFAHBBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private MonoBehaviour LDNLNKHKMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private Action PGHJNJLEBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private Action<float> GBNCFJCHGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private KDFAHLPCJJK JAOHIJACMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private float EHLGGLNCLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private bool NOPLLEPGPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly KBBANPCOGCH FLDNENGOFCA;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x76CA2D0", Offset = "0x76C96D0", VA = "0x1876CA2D0")]
	public FCFLEAPILBG(MonoBehaviour LDNLNKHKMPL, Action PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO, [Optional] KBBANPCOGCH FLDNENGOFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x76C9F20", Offset = "0x76C9320", VA = "0x1876C9F20")]
	public FCFLEAPILBG(MonoBehaviour LDNLNKHKMPL, Action<float> PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO, [Optional] KBBANPCOGCH FLDNENGOFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x76CA0F0", Offset = "0x76C94F0", VA = "0x1876CA0F0")]
	public FCFLEAPILBG(MonoBehaviour LDNLNKHKMPL, float KMDECEKCPHN, Action<float> PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO, bool NOPLLEPGPGI = true, [Optional] KBBANPCOGCH FLDNENGOFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x923890", Offset = "0x922C90", VA = "0x180923890")]
	private FCFLEAPILBG(KBBANPCOGCH FLDNENGOFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x76C9CF0", Offset = "0x76C90F0", VA = "0x1876C9CF0")]
	internal static FCFLEAPILBG PLEPAEMBOLH(MonoBehaviour LDNLNKHKMPL, float KMDECEKCPHN, Action<float> PGHJNJLEBOJ, KDFAHLPCJJK JAOHIJACMHO, bool NOPLLEPGPGI = true, [Optional] KBBANPCOGCH FLDNENGOFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x76C92F0", Offset = "0x76C86F0", VA = "0x1876C92F0")]
	private void CHIEDPFKPGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x76C9510", Offset = "0x76C8910", VA = "0x1876C9510")]
	private void GLHHEKNMLBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x76C9710", Offset = "0x76C8B10", VA = "0x1876C9710")]
	private void HHEOMIACAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x76C99A0", Offset = "0x76C8DA0", VA = "0x1876C99A0")]
	private void JBLOKHKBABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x76C9BC0", Offset = "0x76C8FC0", VA = "0x1876C9BC0")]
	private void NMFNHNLOFMC(string IBDGAGPHJHE, Action LOLAFLPCFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x76C9690", Offset = "0x76C8A90", VA = "0x1876C9690")]
	[IteratorStateMachine(typeof(ILJPBFLBCNB))]
	private IEnumerator<MLEAAPMIINP> GMGPOILNLAE(Action LOLAFLPCFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x76C9420", Offset = "0x76C8820", VA = "0x1876C9420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x76C9480", Offset = "0x76C8880", VA = "0x1876C9480")]
	[CompilerGenerated]
	private void FFBCNNGBGJM(string DACOLACFJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x76C9B30", Offset = "0x76C8F30", VA = "0x1876C9B30")]
	[CompilerGenerated]
	private void NKOFIAFHAHJ(string DACOLACFJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x76C9880", Offset = "0x76C8C80", VA = "0x1876C9880")]
	[CompilerGenerated]
	private void IJDNCEIOFPK(string DACOLACFJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x76C9910", Offset = "0x76C8D10", VA = "0x1876C9910")]
	[CompilerGenerated]
	private void JBGAKHFDFEG(string DACOLACFJMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[Flags]
internal enum LCGGKJDABMA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class MFJOHLKLOAN : GKDCIPMCBOP
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float LPNMJEDJOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x76D84F0", Offset = "0x76D78F0", VA = "0x1876D84F0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float CDKGAIMBKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x76D8520", Offset = "0x76D7920", VA = "0x1876D8520", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public double HLDKDGHPMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x76D8500", Offset = "0x76D7900", VA = "0x1876D8500", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x76D8530", Offset = "0x76D7930", VA = "0x1876D8530")]
	[GOEIKLHOLGG.KCHBNNLNADK]
	internal static void LHFLNIJFEKK(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	[UnityEngine.Scripting.Preserve]
	internal MFJOHLKLOAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface BDBFILODBMH
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCMDEMAFKCJ(string ACDGEPBIBHJ);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEIADMPPPOL();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal interface APMBHEMGODO
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool PFAKIKACPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool NILKMNDFNCE
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal class NINNGHCALKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public MDGPJKEIIMH AOPBOHKGIKJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int DIJEOHGLGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8995A0", VA = "0x18089A1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8A6060", Offset = "0x8A5460", VA = "0x1808A6060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x76DA530", Offset = "0x76D9930", VA = "0x1876DA530")]
	public static MLEAAPMIINP OKMKDJPIIHG(IEnumerator<MLEAAPMIINP> DOGNLNKGOBN, GIJLBGCPONI CCDGLNLOPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x76DA470", Offset = "0x76D9870", VA = "0x1876DA470")]
	public MLEAAPMIINP OKMKDJPIIHG(GIJLBGCPONI[] COAEGBKACJK, IEnumerator<MLEAAPMIINP>[] LCINIMHKMIJ, MLEAAPMIINP[] LHHNIHPBPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x76DA1C0", Offset = "0x76D95C0", VA = "0x1876DA1C0")]
	public void EPPCNILALOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x76DA1F0", Offset = "0x76D95F0", VA = "0x1876DA1F0")]
	public void EEPNLJFOBLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x76DA330", Offset = "0x76D9730", VA = "0x1876DA330")]
	public void GLFLDPBILMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x76DA1C0", Offset = "0x76D95C0", VA = "0x1876DA1C0")]
	public void DDNFCFBCMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public NINNGHCALKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal sealed class MDGPJKEIIMH
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct JABAPBDPJAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public NINNGHCALKL PNHHHJCHPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public PDFFNCFJIFE MCKMPGDIGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public GIJLBGCPONI NHKEOGAEEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public IEnumerator<MLEAAPMIINP> OLPKFIMFPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public MLEAAPMIINP OGKJHHKCCEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public LCGGKJDABMA LMEFJMICCEL;
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public struct NHJEPJKIADA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public KDFAHLPCJJK BCOODCOANBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public List<JABAPBDPJAO> FEGJCIIPABC;
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class KJLFHIMAGFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public GIJLBGCPONI promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public MDGPJKEIIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public PDFFNCFJIFE context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public NINNGHCALKL routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public LCGGKJDABMA coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public MLEAAPMIINP currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public IEnumerator<MLEAAPMIINP> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public KJLFHIMAGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x76D2FB0", Offset = "0x76D23B0", VA = "0x1876D2FB0")]
		internal void PNEEDOPLHGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class KMIGKKDBMBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public NINNGHCALKL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public MDGPJKEIIMH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public KMIGKKDBMBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x76D3780", Offset = "0x76D2B80", VA = "0x1876D3780")]
		internal void MBGEPCKMICK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class EIGNONMKBEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public NINNGHCALKL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public MDGPJKEIIMH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public EIGNONMKBEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x76C8B90", Offset = "0x76C7F90", VA = "0x1876C8B90")]
		internal void HJNGLGGEDHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class GFCIJNABHOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public NINNGHCALKL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public MDGPJKEIIMH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public GFCIJNABHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x76CB200", Offset = "0x76CA600", VA = "0x1876CB200")]
		internal void DDILCPEHOIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private const LCGGKJDABMA AMPPEKPGNNK = LCGGKJDABMA.Cancelled | LCGGKJDABMA.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly KDFAHLPCJJK JAOHIJACMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private bool[] COAFOMCIFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<LCGGKJDABMA> KLNPEOMFEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<float> AKKBGIOLHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> JBICHCIKIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> BHJLFPLJAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private NativeArray<int> IDDIOIAEJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private NativeArray<int> EKFABOICIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<int> MOEBBFLFCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NINNGHCALKL[] EOPMIJMAOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private GIJLBGCPONI[] COAEGBKACJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private PDFFNCFJIFE[] EBHKABJCGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private IEnumerator<MLEAAPMIINP>[] AHBGPPNIHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private MLEAAPMIINP[] OJKKCBHKHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private int CDOJCCEAMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int PCJIPONCEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly int FFMIFKEEDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float FAKNAIIKAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private AINJAIBOGOM DMGLKEPFPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private JobHandle OEOPDFIMECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<NINNGHCALKL> AAGACFABOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool EJDKCJFGIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private List<Action> HPAFHJBMIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private List<Action> ANMGOLMOGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private bool ONLLBMEGDLD;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public NHJEPJKIADA[] ILKKFPPGOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xBD2DB0", Offset = "0xBD21B0", VA = "0x180BD2DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x76D7610", Offset = "0x76D6A10", VA = "0x1876D7610")]
	private static int MKAPDGDKCBA(KDFAHLPCJJK JAOHIJACMHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x76D7C90", Offset = "0x76D7090", VA = "0x1876D7C90")]
	public MDGPJKEIIMH(KDFAHLPCJJK JAOHIJACMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x76D7AB0", Offset = "0x76D6EB0", VA = "0x1876D7AB0")]
	private void PNEIKEMFJLE(int JFGNAECDION, int KOAMIEHPLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x76D65C0", Offset = "0x76D59C0", VA = "0x1876D65C0")]
	public void EJAPAKKKJCI(PDFFNCFJIFE EPLPPJHJIIM, MLEAAPMIINP GNMODMDLFCE, IEnumerator<MLEAAPMIINP> DOGNLNKGOBN, GIJLBGCPONI CCDGLNLOPLO, [Optional] NINNGHCALKL OKGBPOJFGFE, LCGGKJDABMA IFIMLLFMJCK = LCGGKJDABMA.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x76D6380", Offset = "0x76D5780", VA = "0x1876D6380")]
	public void EHCBJGNIBMP(IEnumerable<JABAPBDPJAO> CDPBEFLHPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x76D5900", Offset = "0x76D4D00", VA = "0x1876D5900")]
	private JABAPBDPJAO AMINMEEEAOH(int EMDCBOOBKGD)
	{
		return default(JABAPBDPJAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x76D7640", Offset = "0x76D6A40", VA = "0x1876D7640")]
	private void MPDEJPCFLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD440", Offset = "0x2FBC840", VA = "0x182FBD440")]
	private static void EGBFMOANHGH<T>(int EMDCBOOBKGD, T[] JLJIEAECPCK, int JKIIGJDNBMO, [Optional] T POCNPJBLGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD490", Offset = "0x2FBC890", VA = "0x182FBD490")]
	private static void EGBFMOANHGH<T>(int EMDCBOOBKGD, NativeArray<T> JLJIEAECPCK, int JKIIGJDNBMO, [Optional] T POCNPJBLGMF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x76D67C0", Offset = "0x76D5BC0", VA = "0x1876D67C0")]
	private void FMEMIHKLIEK(IEnumerable<JABAPBDPJAO> CDPBEFLHPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x76D5FD0", Offset = "0x76D53D0", VA = "0x1876D5FD0")]
	private void BJKINNKNGNA(JABAPBDPJAO ADPAFBACBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x76D6B60", Offset = "0x76D5F60", VA = "0x1876D6B60")]
	private LMABCMJHGIA FMOMKJCDOBD(int OCFOBEIJFII)
	{
		return default(LMABCMJHGIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x76D5DD0", Offset = "0x76D51D0", VA = "0x1876D5DD0")]
	public void BECBJMJFJCA(float DMIHFIICGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x76D6300", Offset = "0x76D5700", VA = "0x1876D6300")]
	private void ECHHGMEPNIH(Action FIGPMCHHKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x76D6740", Offset = "0x76D5B40", VA = "0x1876D6740")]
	private void FEMDNJDLJOG(Action FIGPMCHHKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x76D6DC0", Offset = "0x76D61C0", VA = "0x1876D6DC0")]
	public void HJOAIJCNKEC(float DMIHFIICGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x76D79B0", Offset = "0x76D6DB0", VA = "0x1876D79B0")]
	public void PBEAHLLBJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x76D60A0", Offset = "0x76D54A0", VA = "0x1876D60A0")]
	public void DDNFCFBCMPB(NINNGHCALKL AAEIKGBOGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x76D74E0", Offset = "0x76D68E0", VA = "0x1876D74E0")]
	public void KMENLNKKOAF(NINNGHCALKL AAEIKGBOGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x76D61D0", Offset = "0x76D55D0", VA = "0x1876D61D0")]
	public void DKBNBACLJAH(NINNGHCALKL AAEIKGBOGPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class GOAGGHGJKGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static readonly GOAGGHGJKGF HABKGKOFNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly Action EIGMGLNDPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private bool MPIODIOKEMH;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public GOAGGHGJKGF(Action EIGMGLNDPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E9A0", Offset = "0x6E2DDA0", VA = "0x186E2E9A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface PPCCEKCJOGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T FDJCHKNOIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HEGCKIDKAAE(UnityEngine.Object EPLPPJHJIIM, Action<T> PEJJNDAIPCC);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface BKLPFJDOCOI<T> : PPCCEKCJOGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	new T FDJCHKNOIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class MBKMBHCJDGN<T> : BKLPFJDOCOI<T>, PPCCEKCJOGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class AOIHNGIDHOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public MBKMBHCJDGN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public BBOCCICBKPL<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public AOIHNGIDHOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x421AEF0", Offset = "0x421A2F0", VA = "0x18421AEF0")]
		internal void AAJFNJMKPJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static GameObject IFIIJFPHBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly List<BBOCCICBKPL<UnityEngine.Object, Action<T>>> MMLOGPBEKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T EMPHBAIPABE;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public T FDJCHKNOIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xB92390", Offset = "0xB91790", VA = "0x180B92390", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4851B00", Offset = "0x4850F00", VA = "0x184851B00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4851990", Offset = "0x4850D90", VA = "0x184851990")]
	private static bool DGKMLLKBBMI(T FIGPMCHHKJO, T LLNOONNFEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4851FC0", Offset = "0x48513C0", VA = "0x184851FC0")]
	public MBKMBHCJDGN(T EALLIAGBMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4851D50", Offset = "0x4851150", VA = "0x184851D50", Slot = "6")]
	public IDisposable HEGCKIDKAAE(UnityEngine.Object EPLPPJHJIIM, Action<T> PEJJNDAIPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4851620", Offset = "0x4850A20", VA = "0x184851620")]
	private void ABKPMPIMGMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal class GKFBKGLNHLJ : NKIKAMFFEAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly KBBANPCOGCH FLDNENGOFCA;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x76CB2C0", Offset = "0x76CA6C0", VA = "0x1876CB2C0")]
	[GOEIKLHOLGG.KCHBNNLNADK]
	internal static void ACJCPMICBAP(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	[UnityEngine.Scripting.Preserve]
	internal GKFBKGLNHLJ([NDMEANGLJKD(null)] KBBANPCOGCH FLDNENGOFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x76CB330", Offset = "0x76CA730", VA = "0x1876CB330", Slot = "4")]
	public IDisposable OPBJDDNEHPC(float KMDECEKCPHN, Action<float> NEDFJOJDIHF, bool NOPLLEPGPGI = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class MGPNEIJFNJI : LLEECHBDKJC, KBBANPCOGCH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private MDGPJKEIIMH[] OHKFCOGCDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private BDBFILODBMH IAJABPFMBJC;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x76D8D40", Offset = "0x76D8140", VA = "0x1876D8D40")]
	[GOEIKLHOLGG.KCHBNNLNADK]
	internal static void LHFLNIJFEKK(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x76D9170", Offset = "0x76D8570", VA = "0x1876D9170")]
	[UnityEngine.Scripting.Preserve]
	public MGPNEIJFNJI([NDMEANGLJKD(null)] DIALKCOHHNI LDPDDFJEDMD, [NDMEANGLJKD(null)] GKDCIPMCBOP DKGPCNANDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x76D8DB0", Offset = "0x76D81B0", VA = "0x1876D8DB0", Slot = "19")]
	public override IDFKLKAPHIN OHJNCCFKJLD(PDFFNCFJIFE EPLPPJHJIIM, IEnumerator<MLEAAPMIINP> AGCAKBAJKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x76D8EE0", Offset = "0x76D82E0", VA = "0x1876D8EE0", Slot = "20")]
	public override void PGGELGPJGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x76D8790", Offset = "0x76D7B90", VA = "0x1876D8790", Slot = "22")]
	public override void EPBJOIEGCLP(KDFAHLPCJJK JAOHIJACMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x76D8660", Offset = "0x76D7A60", VA = "0x1876D8660", Slot = "21")]
	protected override void DPCLJOJLMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x76D8D10", Offset = "0x76D8110", VA = "0x1876D8D10")]
	private MDGPJKEIIMH GDGDHEGKIBJ(KDFAHLPCJJK EKNPHEPNHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x76D89C0", Offset = "0x76D7DC0", VA = "0x1876D89C0", Slot = "23")]
	internal override HELFKOIKFHN FAGOMGFGENK(IEnumerator<MLEAAPMIINP> AGCAKBAJKBE, Behaviour EPLPPJHJIIM, GIJLBGCPONI CCDGLNLOPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x76D85A0", Offset = "0x76D79A0", VA = "0x1876D85A0", Slot = "24")]
	internal override KEHHDKDHLGA CNFNNNFGHBG(KDFAHLPCJJK LBIOCHJBOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x76D8BF0", Offset = "0x76D7FF0", VA = "0x1876D8BF0")]
	private void GCDCMFAJPHH(MDGPJKEIIMH BFDMMJPDGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x76D8730", Offset = "0x76D7B30", VA = "0x1876D8730", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal struct AINJAIBOGOM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	public float OLGDLPBDNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	public int LDLINJHGNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private NativeArray<int> CHCKHCIJNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private NativeArray<int> EGLDLKCPEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private NativeArray<int> FLIJEGOEBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[ReadOnly]
	public NativeArray<LCGGKJDABMA> MEGBNEMJEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[ReadOnly]
	public NativeArray<float> IDEMBLCDKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[WriteOnly]
	public NativeArray<int> IDDIOIAEJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[WriteOnly]
	public NativeArray<int> JBICHCIKIKK;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x76BF580", Offset = "0x76BE980", VA = "0x1876BF580")]
	public static AINJAIBOGOM ANJEPJLHJHG(int LHJCOHFHECH, float DMIHFIICGGA, NativeArray<LCGGKJDABMA> HFBAMINALNI, NativeArray<float> MEEKHEPGFOE, NativeArray<int> KCEONPPIPLD, NativeArray<int> ALHNBCMINDC, NativeArray<int> GKGNLHGJJEC, NativeArray<int> EGLDLKCPEFJ, NativeArray<int> FLIJEGOEBPG)
	{
		return default(AINJAIBOGOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x76BF820", Offset = "0x76BEC20", VA = "0x1876BF820", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x76BF900", Offset = "0x76BED00", VA = "0x1876BF900")]
	private bool KFPCJNGELIB(int OBFJPFHENMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x76BF940", Offset = "0x76BED40", VA = "0x1876BF940")]
	private void KLIMJNNFKJI(NativeArray<int> MHJLEEFCHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x76BFA40", Offset = "0x76BEE40", VA = "0x1876BFA40")]
	private int OKGGPPHKPAL(int LALEFJIOPON, int GOOOMELPDAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x76BF970", Offset = "0x76BED70", VA = "0x1876BF970")]
	private void NMFMHDPJEKA(NativeArray<int> MHJLEEFCHPP, int NILIGIMFACP, int AKMABNIDADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x76BF5E0", Offset = "0x76BE9E0", VA = "0x1876BF5E0")]
	private void BLGFPKCCPJD(NativeArray<int> MHJLEEFCHPP, int BFHLEPNLBEI, int NFGMNEGJHIK, int ABJOHAMGBGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class LLEECHBDKJC : KBBANPCOGCH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly DIALKCOHHNI LDPDDFJEDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected readonly GKDCIPMCBOP DKGPCNANDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private KEHHDKDHLGA[] JBBEIMIBNEN;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static KBBANPCOGCH GHDNHBBFDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x76D45C0", Offset = "0x76D39C0", VA = "0x1876D45C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static bool PEHHLBMDPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public KDFAHLPCJJK MIFOGJPEJFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8995A0", VA = "0x18089A1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(KDFAHLPCJJK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A6060", Offset = "0x8A5460", VA = "0x1808A6060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GKDCIPMCBOP MLBPIJAAMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MLEAAPMIINP OOEPBPOLDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MLEAAPMIINP FEBOPHAJBNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F80", Offset = "0x8A0380", VA = "0x1808A0F80", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MLEAAPMIINP LMOJPPAOPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x89FDB0", Offset = "0x89F1B0", VA = "0x18089FDB0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MLEAAPMIINP ADGOMIIPEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x89D950", Offset = "0x89CD50", VA = "0x18089D950", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x76D42C0", Offset = "0x76D36C0", VA = "0x1876D42C0")]
	public static IDFKLKAPHIN FLOFJNAKFHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x76D4C80", Offset = "0x76D4080", VA = "0x1876D4C80")]
	[UnityEngine.Scripting.Preserve]
	protected LLEECHBDKJC([NDMEANGLJKD(null)] DIALKCOHHNI LDPDDFJEDMD, [NDMEANGLJKD(null)] GKDCIPMCBOP DKGPCNANDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x76D4C70", Offset = "0x76D4070", VA = "0x1876D4C70", Slot = "6")]
	public IDFKLKAPHIN PMHBOLLLGAG(IEnumerator<MLEAAPMIINP> AGCAKBAJKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x76D4A70", Offset = "0x76D3E70", VA = "0x1876D4A70", Slot = "7")]
	public IDFKLKAPHIN PMHBOLLLGAG(Behaviour EPLPPJHJIIM, IEnumerator<MLEAAPMIINP> AGCAKBAJKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract IDFKLKAPHIN OHJNCCFKJLD(PDFFNCFJIFE EPLPPJHJIIM, IEnumerator<MLEAAPMIINP> AGCAKBAJKBE);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x76D48D0", Offset = "0x76D3CD0", VA = "0x1876D48D0", Slot = "20")]
	public virtual void PGGELGPJGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x76D4670", Offset = "0x76D3A70", VA = "0x1876D4670", Slot = "9")]
	public void NKEPMGEFMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x76D3E50", Offset = "0x76D3250", VA = "0x1876D3E50", Slot = "21")]
	protected virtual void DPCLJOJLMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x76D3DA0", Offset = "0x76D31A0", VA = "0x1876D3DA0")]
	private void DKGLLDMOEII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x76D4650", Offset = "0x76D3A50", VA = "0x1876D4650")]
	private void NKEDOMDKKDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x76D48B0", Offset = "0x76D3CB0", VA = "0x1876D48B0")]
	private void OPGFDLMFGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x76D3D20", Offset = "0x76D3120", VA = "0x1876D3D20")]
	private void BMPFBNMGFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x76D45A0", Offset = "0x76D39A0", VA = "0x1876D45A0")]
	private void LNMCHNMDJEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x76D4630", Offset = "0x76D3A30", VA = "0x1876D4630")]
	private void NIIEFDJFBLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x76D4350", Offset = "0x76D3750", VA = "0x1876D4350")]
	private void GGDGJMEFHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x76D4230", Offset = "0x76D3630", VA = "0x1876D4230", Slot = "22")]
	public virtual void EPBJOIEGCLP(KDFAHLPCJJK JAOHIJACMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x76D43D0", Offset = "0x76D37D0", VA = "0x1876D43D0")]
	private void LILGLNGCMOC(KEHHDKDHLGA BFDMMJPDGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2173890", Offset = "0x2172C90", VA = "0x182173890")]
	private KEHHDKDHLGA HFELOHHKHIK(KDFAHLPCJJK EKNPHEPNHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract HELFKOIKFHN FAGOMGFGENK(IEnumerator<MLEAAPMIINP> AGCAKBAJKBE, Behaviour LDNLNKHKMPL, GIJLBGCPONI AODJDKMINCB);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract KEHHDKDHLGA CNFNNNFGHBG(KDFAHLPCJJK JAOHIJACMHO);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x76D3E70", Offset = "0x76D3270", VA = "0x1876D3E70", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x76D4370", Offset = "0x76D3770", VA = "0x1876D4370", Slot = "15")]
	public MLEAAPMIINP IEMPNGHCHKN(KDFAHLPCJJK LBIOCHJBOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x76D3DC0", Offset = "0x76D31C0", VA = "0x1876D3DC0", Slot = "16")]
	public MLEAAPMIINP DLGHJEOIGLL(float FOPCLCJOGBF, KDFAHLPCJJK LBIOCHJBOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x76D3D40", Offset = "0x76D3140", VA = "0x1876D3D40", Slot = "17")]
	public MLEAAPMIINP CNGOIOEDEON(Func<bool> NAFCJPGDPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal sealed class HELFKOIKFHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly GIJLBGCPONI CCDGLNLOPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly APMBHEMGODO EPLPPJHJIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly bool PEAKKFOKDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private string ACDGEPBIBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private StackTrace IPNNJGMJNOM;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerator<MLEAAPMIINP> OLPKFIMFPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public MLEAAPMIINP OGKJHHKCCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool JMKDCNLCGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x76CB970", Offset = "0x76CAD70", VA = "0x1876CB970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool HLMFBBAACOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x929720", Offset = "0x928B20", VA = "0x180929720")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x92B9F0", Offset = "0x92ADF0", VA = "0x18092B9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x76CB7C0", Offset = "0x76CABC0", VA = "0x1876CB7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float BLBOJJBHLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xB92310", Offset = "0xB91710", VA = "0x180B92310")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xDEC730", Offset = "0xDEBB30", VA = "0x180DEC730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x76CBE60", Offset = "0x76CB260", VA = "0x1876CBE60")]
	public HELFKOIKFHN(IEnumerator<MLEAAPMIINP> DOGNLNKGOBN, APMBHEMGODO EPLPPJHJIIM, GIJLBGCPONI CCDGLNLOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x76CBA60", Offset = "0x76CAE60", VA = "0x1876CBA60")]
	public MLEAAPMIINP OKMKDJPIIHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x76CB9F0", Offset = "0x76CADF0", VA = "0x1876CB9F0")]
	public bool MHDLDNFALDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x76CB770", Offset = "0x76CAB70", VA = "0x1876CB770")]
	public void DDNFCFBCMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x76CBD80", Offset = "0x76CB180", VA = "0x1876CBD80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x92BCB0", Offset = "0x92B0B0", VA = "0x18092BCB0")]
	[CompilerGenerated]
	private void ILFPHIAEPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class GIJLBGCPONI : GNCKKKLDHED, IDFKLKAPHIN, HBMBDNJPECN, NNKCIMLKELB, IEnumerator, MLEAAPMIINP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private KDFAHLPCJJK FDOIGNEICJA;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private KDFAHLPCJJK GAMLFKNNCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x929050", Offset = "0x928450", VA = "0x180929050", Slot = "23")]
		get
		{
			return default(KDFAHLPCJJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public KDFAHLPCJJK AOPBOHKGIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xAA1A00", Offset = "0xAA0E00", VA = "0x180AA1A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private float FFFFPPNJNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA1F250", Offset = "0xA1E650", VA = "0x180A1F250", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool EICJBFNNCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x76CB250", Offset = "0x76CA650", VA = "0x1876CB250", Slot = "24")]
	private bool OCFKAPOFFEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x76CB240", Offset = "0x76CA640", VA = "0x1876CB240", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x76CB270", Offset = "0x76CA670", VA = "0x1876CB270")]
	public GIJLBGCPONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal enum LMABCMJHGIA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class KEHHDKDHLGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public enum ELABKNMDMOK
	{
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public struct APLHDBNGAIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public KDFAHLPCJJK BCOODCOANBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public ELABKNMDMOK KNKGOOPEEJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public List<HELFKOIKFHN> JIEGMCLGEAM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static readonly ELABKNMDMOK[] FJKFNCBHOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly KDFAHLPCJJK JAOHIJACMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private bool CNCKALIPOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly HELFKOIKFHN[] KBBLIJMFPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly List<HELFKOIKFHN> FBIPKKBGDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly Stack<int> PHJBLLBJJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly List<HELFKOIKFHN> JJHKONNCCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly Stack<int> KIAIJEDIKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly BDBFILODBMH CLKEEJMFKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private bool ONLLBMEGDLD;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public APLHDBNGAIK[,] KMKAAEMJCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x89FDB0", Offset = "0x89F1B0", VA = "0x18089FDB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x76D0C50", Offset = "0x76D0050", VA = "0x1876D0C50")]
	public KEHHDKDHLGA(KDFAHLPCJJK LBIOCHJBOOC, BDBFILODBMH CLKEEJMFKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x76D0710", Offset = "0x76CFB10", VA = "0x1876D0710")]
	public void OJMCOLIOMKF(HELFKOIKFHN DOGNLNKGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x76CFFC0", Offset = "0x76CF3C0", VA = "0x1876CFFC0")]
	public void MBAIOMHPDNA(IList<HELFKOIKFHN> LCINIMHKMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x76CFB50", Offset = "0x76CEF50", VA = "0x1876CFB50")]
	public void IDEADCFOHIL(IList<HELFKOIKFHN> LCINIMHKMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x76D0620", Offset = "0x76CFA20", VA = "0x1876D0620")]
	private void ODGFKPPBLBJ(HELFKOIKFHN DOGNLNKGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x76D02B0", Offset = "0x76CF6B0", VA = "0x1876D02B0")]
	private void NAKJFACFGEH(IList<HELFKOIKFHN> LCINIMHKMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x76CFE40", Offset = "0x76CF240", VA = "0x1876CFE40")]
	private LMABCMJHGIA KPHFJGNBIND(HELFKOIKFHN DOGNLNKGOBN)
	{
		return default(LMABCMJHGIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x76CF780", Offset = "0x76CEB80", VA = "0x1876CF780")]
	public void DPCLJOJLMCI(float DMIHFIICGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x76D0430", Offset = "0x76CF830", VA = "0x1876D0430")]
	public void NKEPMGEFMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x76D0810", Offset = "0x76CFC10", VA = "0x1876D0810")]
	private void OPNCEIACFDI(List<HELFKOIKFHN> LCINIMHKMIJ, Stack<int> MHKBMCBKNHG, bool BKBNEFAPGMK, float OCMFPBMDING = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x76CF8F0", Offset = "0x76CECF0", VA = "0x1876CF8F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x76CFA10", Offset = "0x76CEE10", VA = "0x1876CFA10")]
	private void GGNBIDCBANC(List<HELFKOIKFHN> LCINIMHKMIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal class LGJGKNLNKIF : BDBFILODBMH
{
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "4")]
	public void HCMDEMAFKCJ(string ACDGEPBIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
	public void JEIADMPPPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public LGJGKNLNKIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal class HIANKNNMNOI : APMBHEMGODO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly Behaviour LDNLNKHKMPL;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x76CC750", Offset = "0x76CBB50", VA = "0x1876CC750", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool PFAKIKACPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x76CC7D0", Offset = "0x76CBBD0", VA = "0x1876CC7D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool NILKMNDFNCE
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x76CC730", Offset = "0x76CBB30", VA = "0x1876CC730", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public HIANKNNMNOI(Behaviour LDNLNKHKMPL)
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

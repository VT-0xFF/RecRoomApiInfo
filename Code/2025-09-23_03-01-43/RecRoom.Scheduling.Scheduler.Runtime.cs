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
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9067A70", Offset = "0x9066070", VA = "0x189067A70", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x906F700", Offset = "0x906DD00", VA = "0x18906F700", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
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
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct IHAEJLFPFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			[CompilerGenerated]
			private sealed class NMLOLJNCPBJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public DGGOBJGIFPC.NKBCNMBEJHI key;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
				public NMLOLJNCPBJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x9068A20", Offset = "0x9067020", VA = "0x189068A20")]
				internal void OGCMBJHFGNL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000002")]
			public static IDisposable DDDPNFCBHDL;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9064670", Offset = "0x9062C70", VA = "0x189064670")]
			public static PlayerLoopSystem FMINGPFKACO(DGGOBJGIFPC.NKBCNMBEJHI HAELBKGFDIJ)
			{
				return default(PlayerLoopSystem);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct MBABKCNGHHN
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class HEADCFHIMPO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public DGGOBJGIFPC.NKBCNMBEJHI key;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
				public HEADCFHIMPO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x90643F0", Offset = "0x90629F0", VA = "0x1890643F0")]
				internal void OGCMBJHFGNL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9067B00", Offset = "0x9066100", VA = "0x189067B00")]
			public static PlayerLoopSystem FMINGPFKACO(DGGOBJGIFPC.NKBCNMBEJHI HAELBKGFDIJ)
			{
				return default(PlayerLoopSystem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly IPHNFELODMJ AMCHCCAPJNG;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x905ED80", Offset = "0x905D380", VA = "0x18905ED80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x905FFE0", Offset = "0x905E5E0", VA = "0x18905FFE0")]
		private static void PLBAJJFLJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x905EBB0", Offset = "0x905D1B0", VA = "0x18905EBB0")]
		private static void AGJANHHBNMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x905FB80", Offset = "0x905E180", VA = "0x18905FB80")]
		private static void ONAINCLMOPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x905EF60", Offset = "0x905D560", VA = "0x18905EF60")]
		private static void LEAMJIGEBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B2B0", Offset = "0x3C198B0", VA = "0x183C1B2B0")]
		private static (PlayerLoopSystem, JEMOOLPHHOA.EICABHNMPAA) NDGGEIICLJP<T>()
		{
			return default((PlayerLoopSystem, JEMOOLPHHOA.EICABHNMPAA));
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x905FAE0", Offset = "0x905E0E0", VA = "0x18905FAE0")]
		private static (PlayerLoopSystem, JEMOOLPHHOA.EICABHNMPAA) NDGGEIICLJP(PlayerLoopSystem NDPOFPDHJMG)
		{
			return default((PlayerLoopSystem, JEMOOLPHHOA.EICABHNMPAA));
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3C196B0", Offset = "0x3C17CB0", VA = "0x183C196B0")]
		private static (PlayerLoopSystem, JEMOOLPHHOA.EICABHNMPAA) CBELOMAGFLH<T>()
		{
			return default((PlayerLoopSystem, JEMOOLPHHOA.EICABHNMPAA));
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3C19830", Offset = "0x3C17E30", VA = "0x183C19830")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) HANBIKMKKKC<TParent, TSub>(DGGOBJGIFPC.NKBCNMBEJHI HAELBKGFDIJ)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x905EE00", Offset = "0x905D400", VA = "0x18905EE00")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) HANBIKMKKKC(DGGOBJGIFPC.NKBCNMBEJHI HAELBKGFDIJ, Type BEBONNCPGLF, Type OCFFGFCHGPF)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DGGOBJGIFPC
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum NKBCNMBEJHI
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		NetworkReceive,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		NetworkSend,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		OMPreGameplayUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		OMPrePhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		OMPostPhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		OMPostGameplayUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		OMPreNetworkReceive,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		OMNetworkReceive,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		OMPostNetworkReceive,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		OMNetworkSend,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		OMPostLateUpdate
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PIGALOPHBJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly NKBCNMBEJHI EJNMBAAMMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly CGOBCGNDMDA MJLAEDKKJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long KIKENMDNAPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long EKNAIIMCJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long BFIJPJMAFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int JEJDOEJMBJO;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x906E280", Offset = "0x906C880", VA = "0x18906E280")]
		public PIGALOPHBJO(NKBCNMBEJHI MHMCOLNBGCD, int EEEHJIFCOKL = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x906E210", Offset = "0x906C810", VA = "0x18906E210")]
		public void CBLFDLAOPGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x906E230", Offset = "0x906C830", VA = "0x18906E230")]
		public void LHELCLDKHAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x906E130", Offset = "0x906C730", VA = "0x18906E130")]
		public void BHMFEADMIEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static NKBCNMBEJHI[] KFINHCPOCGD;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static PIGALOPHBJO[] JADMHFFOCEC;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9060580", Offset = "0x905EB80", VA = "0x189060580")]
	public static PIGALOPHBJO JOHAAPOMDCK(NKBCNMBEJHI HAELBKGFDIJ, int EEEHJIFCOKL = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x9060510", Offset = "0x905EB10", VA = "0x189060510")]
	public static PIGALOPHBJO FGDICBHGOCI(NKBCNMBEJHI HAELBKGFDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x90606D0", Offset = "0x905ECD0", VA = "0x1890606D0")]
	public static void NKOLOGMALIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PJJAIDKHCEC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface HGNNBFDBDKO
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool PHBIFHNEKGG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PNGLJDLMHCP();
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class HJLKHNJOGAE : HGNNBFDBDKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Action PMBBLAOPHON;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool PHBIFHNEKGG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
		public HJLKHNJOGAE(Action PMBBLAOPHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x134F7B0", Offset = "0x134DDB0", VA = "0x18134F7B0", Slot = "5")]
		public void PNGLJDLMHCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<HGNNBFDBDKO> LONBOCEDBBP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool FFCNCFEIINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x906E610", Offset = "0x906CC10", VA = "0x18906E610")]
	public static void IECCIBBABIA(Action PMBBLAOPHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x906E920", Offset = "0x906CF20", VA = "0x18906E920")]
	private static void LEMIEFLLNKN(HGNNBFDBDKO PLALHGOFOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x906E310", Offset = "0x906C910", VA = "0x18906E310")]
	private static void DHADPBBJAMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x906E7D0", Offset = "0x906CDD0", VA = "0x18906E7D0")]
	private static void KHBIDAELFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x906E6B0", Offset = "0x906CCB0", VA = "0x18906E6B0")]
	private static void IHJLFBLDJMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ACIOFCOEFKO
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x905D700", Offset = "0x905BD00", VA = "0x18905D700")]
	public static IDisposable IICCADCENBE(this HDFLEBKKIDM JIFPJFGEAIK, float HFDNHIOELFO, Action<float> GEMFDOMGNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x905D680", Offset = "0x905BC80", VA = "0x18905D680")]
	public static IDisposable AIODNONDKGE(this HDFLEBKKIDM JIFPJFGEAIK, Action<float> GEMFDOMGNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x905D790", Offset = "0x905BD90", VA = "0x18905D790")]
	public static IDisposable LLMBKMGEPML(this HDFLEBKKIDM JIFPJFGEAIK, Action<float> GEMFDOMGNDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PGMCEIAOHAB
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3F90AD0", Offset = "0x3F8F0D0", VA = "0x183F90AD0")]
	[FDOEGCJLBJJ]
	public static IDisposable LGHLGDBGKKM<T>(this T DDCCCNLJKEF, Action GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3F90C80", Offset = "0x3F8F280", VA = "0x183F90C80")]
	[FDOEGCJLBJJ]
	public static IDisposable LGHLGDBGKKM<T>(this T DDCCCNLJKEF, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3F90990", Offset = "0x3F8EF90", VA = "0x183F90990")]
	[FDOEGCJLBJJ]
	public static IDisposable FPGILMIKMIA<T>(this T DDCCCNLJKEF, Action GEMFDOMGNDH, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3F909F0", Offset = "0x3F8EFF0", VA = "0x183F909F0")]
	[FDOEGCJLBJJ]
	public static IDisposable IJICEPGJMJE<T>(this T DDCCCNLJKEF, Action GEMFDOMGNDH, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3F909F0", Offset = "0x3F8EFF0", VA = "0x183F909F0")]
	[FDOEGCJLBJJ]
	public static IDisposable IJICEPGJMJE<T>(this T DDCCCNLJKEF, Action<float> GEMFDOMGNDH, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F90E70", Offset = "0x3F8F470", VA = "0x183F90E70")]
	[FDOEGCJLBJJ]
	public static IDisposable NCILFDNBJLK<T>(this T DDCCCNLJKEF, Action GEMFDOMGNDH, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3F909C0", Offset = "0x3F8EFC0", VA = "0x183F909C0")]
	[FDOEGCJLBJJ]
	public static IDisposable HPDEFGBEGAC<T>(this T DDCCCNLJKEF, Action GEMFDOMGNDH, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3F90AA0", Offset = "0x3F8F0A0", VA = "0x183F90AA0")]
	[FDOEGCJLBJJ]
	public static IDisposable LDHMNGFFHIF<T>(this T DDCCCNLJKEF, Action GEMFDOMGNDH, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3F90910", Offset = "0x3F8EF10", VA = "0x183F90910")]
	[FDOEGCJLBJJ]
	public static IDisposable DLKCJIHPOME<T>(this T DDCCCNLJKEF, float HFDNHIOELFO, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x906DF50", Offset = "0x906C550", VA = "0x18906DF50")]
	[FDOEGCJLBJJ]
	public static IDisposable DLKCJIHPOME(this MonoBehaviour DDCCCNLJKEF, AKDIJPFDGAK JIFPJFGEAIK, float HFDNHIOELFO, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3F90EE0", Offset = "0x3F8F4E0", VA = "0x183F90EE0")]
	[FDOEGCJLBJJ]
	public static IDisposable ODOLKLHBKDK<T>(this T DDCCCNLJKEF, float HFDNHIOELFO, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3F91090", Offset = "0x3F8F690", VA = "0x183F91090")]
	[FDOEGCJLBJJ]
	public static IDisposable OKKFONOBIAJ<T>(this T DDCCCNLJKEF, float HFDNHIOELFO, Action<float> GEMFDOMGNDH, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3F90890", Offset = "0x3F8EE90", VA = "0x183F90890")]
	[FDOEGCJLBJJ]
	public static IDisposable BEOCMDIGOAB<T>(this T DDCCCNLJKEF, Action<float> GEMFDOMGNDH, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3F90A20", Offset = "0x3F8F020", VA = "0x183F90A20")]
	[FDOEGCJLBJJ]
	public static IDisposable JNJLDMNHJAO<T>(this T DDCCCNLJKEF, Action<float> GEMFDOMGNDH, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3F90E30", Offset = "0x3F8F430", VA = "0x183F90E30")]
	[FDOEGCJLBJJ]
	public static IDisposable MEDLLCKLIFG<T>(this T DDCCCNLJKEF, Action<float> GEMFDOMGNDH, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3F90950", Offset = "0x3F8EF50", VA = "0x183F90950")]
	[FDOEGCJLBJJ]
	public static IDisposable DMNNJOKMEOK<T>(this T DDCCCNLJKEF, Action<float> GEMFDOMGNDH, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3F90850", Offset = "0x3F8EE50", VA = "0x183F90850")]
	[FDOEGCJLBJJ]
	public static IDisposable AGKMCCJJOEL<T>(this T DDCCCNLJKEF, Action<float> GEMFDOMGNDH, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3F90EA0", Offset = "0x3F8F4A0", VA = "0x183F90EA0")]
	[FDOEGCJLBJJ]
	public static IDisposable NNAIGFLHCAO<T>(this T DDCCCNLJKEF, Action<float> GEMFDOMGNDH, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3F908D0", Offset = "0x3F8EED0", VA = "0x183F908D0")]
	[FDOEGCJLBJJ]
	public static IDisposable CKKBEDMHIJE<T>(this T DDCCCNLJKEF, Action<float> GEMFDOMGNDH, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3F90A60", Offset = "0x3F8F060", VA = "0x183F90A60")]
	[FDOEGCJLBJJ]
	public static IDisposable KNJHCLPAHBB<T>(this T DDCCCNLJKEF, float HFDNHIOELFO, Action<float> GEMFDOMGNDH, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3F910D0", Offset = "0x3F8F6D0", VA = "0x183F910D0")]
	[FDOEGCJLBJJ]
	public static IDisposable PHHJDBKMHPK<T>(this T DDCCCNLJKEF, Action<float> GEMFDOMGNDH, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true) where T : MonoBehaviour, AKDIJPFDGAK
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NMPPCEDCBBK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FLJIKDHIBCH : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public MFJFPNHANBJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private LNCHOABCCLM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public FLJIKDHIBCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x90617F0", Offset = "0x905FDF0", VA = "0x1890617F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x90618D0", Offset = "0x905FED0", VA = "0x1890618D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class DKPIHEKBNJK : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public MFJFPNHANBJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private LNCHOABCCLM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public DKPIHEKBNJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9060DF0", Offset = "0x905F3F0", VA = "0x189060DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9060EE0", Offset = "0x905F4E0", VA = "0x189060EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x9068D40", Offset = "0x9067340", VA = "0x189068D40")]
	public static FAKIPBKLGEB LGHLGDBGKKM(Action GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9068DC0", Offset = "0x90673C0", VA = "0x189068DC0")]
	public static FAKIPBKLGEB LGHLGDBGKKM(Behaviour JIFPJFGEAIK, Action GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9068C60", Offset = "0x9067260", VA = "0x189068C60")]
	public static FAKIPBKLGEB LGHLGDBGKKM(Behaviour JIFPJFGEAIK, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9068E50", Offset = "0x9067450", VA = "0x189068E50")]
	[IteratorStateMachine(typeof(FLJIKDHIBCH))]
	private static IEnumerator<KAIBAKBEOHB> LNCFAMKKKGM(MFJFPNHANBJ HIOHIPLNPFI, Action GEMFDOMGNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9068EE0", Offset = "0x90674E0", VA = "0x189068EE0")]
	[IteratorStateMachine(typeof(DKPIHEKBNJK))]
	private static IEnumerator<KAIBAKBEOHB> LNCFAMKKKGM(MFJFPNHANBJ HIOHIPLNPFI, Action<float> GEMFDOMGNDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PFGPOAJAELJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class JKOBKFECGHE : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public PFGPOAJAELJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public JKOBKFECGHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x90663A0", Offset = "0x90649A0", VA = "0x1890663A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9066430", Offset = "0x9064A30", VA = "0x189066430", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MFJFPNHANBJ GIPLNPNDFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Action IGLGGCIICFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool JPAAOPGIDAM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool INFFINLHJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5700", Offset = "0xAA3D00", VA = "0x180AA5700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x906DE80", Offset = "0x906C480", VA = "0x18906DE80")]
	public PFGPOAJAELJ(MFJFPNHANBJ GIPLNPNDFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x906DD60", Offset = "0x906C360", VA = "0x18906DD60")]
	[IteratorStateMachine(typeof(JKOBKFECGHE))]
	private IEnumerator<KAIBAKBEOHB> LIPFOIPJOAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x906DDE0", Offset = "0x906C3E0", VA = "0x18906DDE0", Slot = "4")]
	public void OnCompleted(Action PJCIELKLJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	public void BHIEPMNDMBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class GMIJKDINNHH
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9062D30", Offset = "0x9061330", VA = "0x189062D30")]
	public static PFGPOAJAELJ FEOGLHAOOCG(this MFJFPNHANBJ GIPLNPNDFAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class OFAIKFFNPBM
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class NAPIBBHBLIA : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public BGCEGMKLBGO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public NAPIBBHBLIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9068870", Offset = "0x9066E70", VA = "0x189068870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x90688F0", Offset = "0x9066EF0", VA = "0x1890688F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x906A480", Offset = "0x9068A80", VA = "0x18906A480")]
	public static FAKIPBKLGEB LGHLGDBGKKM(float HFDNHIOELFO, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, bool BMFNIBKJPBL = true, [Optional] DJEIDPKGCPH PEACDDCMCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x906A3B0", Offset = "0x90689B0", VA = "0x18906A3B0")]
	public static FAKIPBKLGEB LGHLGDBGKKM(MonoBehaviour DDCCCNLJKEF, float HFDNHIOELFO, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, bool BMFNIBKJPBL = true, [Optional] DJEIDPKGCPH PEACDDCMCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x906A230", Offset = "0x9068830", VA = "0x18906A230")]
	public static FAKIPBKLGEB FPGBGNDFKCN(MonoBehaviour DDCCCNLJKEF, float HFDNHIOELFO, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, bool BMFNIBKJPBL = true, [Optional] DJEIDPKGCPH PEACDDCMCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x906A610", Offset = "0x9068C10", VA = "0x18906A610")]
	public static FAKIPBKLGEB PAIDLKBHJON(HDFLEBKKIDM JIFPJFGEAIK, float HFDNHIOELFO, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, bool BMFNIBKJPBL = true, [Optional] DJEIDPKGCPH PEACDDCMCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x906A550", Offset = "0x9068B50", VA = "0x18906A550")]
	private static IEnumerator<KAIBAKBEOHB> LNCFAMKKKGM(GMMDEDGBMGC PKACMIALFNF, float HFDNHIOELFO, MFJFPNHANBJ HIOHIPLNPFI, Action<float> GEMFDOMGNDH, bool BMFNIBKJPBL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x906A1D0", Offset = "0x90687D0", VA = "0x18906A1D0")]
	private static IEnumerator<KAIBAKBEOHB> BBECJHOJOMI(GMMDEDGBMGC PKACMIALFNF, float HFDNHIOELFO, MFJFPNHANBJ HIOHIPLNPFI, Action<float> GEMFDOMGNDH, bool BMFNIBKJPBL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x906A320", Offset = "0x9068920", VA = "0x18906A320")]
	[IteratorStateMachine(typeof(NAPIBBHBLIA))]
	private static IEnumerator<KAIBAKBEOHB> LDFNLKDNFLO(BGCEGMKLBGO FLBIKDMLAKK, float HFDNHIOELFO, MFJFPNHANBJ HIOHIPLNPFI, Action<float> GEMFDOMGNDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JHEDCPDAIFA
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class KLILHLEDCID : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public MFJFPNHANBJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public KLILHLEDCID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9066A70", Offset = "0x9065070", VA = "0x189066A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9066B30", Offset = "0x9065130", VA = "0x189066B30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9066230", Offset = "0x9064830", VA = "0x189066230")]
	[IteratorStateMachine(typeof(KLILHLEDCID))]
	private static IEnumerator<KAIBAKBEOHB> CLIFNNKHAKK(MFJFPNHANBJ GIPLNPNDFAP, Func<bool> MAMPOCOOMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x90662C0", Offset = "0x90648C0", VA = "0x1890662C0")]
	public static FAKIPBKLGEB GFCPAOBIMHA(this MonoBehaviour DDCCCNLJKEF, Func<bool> MAMPOCOOMDJ, MFJFPNHANBJ GIPLNPNDFAP = MFJFPNHANBJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class GEJFEDILKIL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FPLEJALGDEB : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public MFJFPNHANBJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public FPLEJALGDEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9061920", Offset = "0x905FF20", VA = "0x189061920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9061990", Offset = "0x905FF90", VA = "0x189061990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CCBDDAEDDPP<T> : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public MFJFPNHANBJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public CCBDDAEDDPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8C60", Offset = "0x6EA7260", VA = "0x186EA8C60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8CE0", Offset = "0x6EA72E0", VA = "0x186EA8CE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NDMOBCMKEJD : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public MFJFPNHANBJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private KAIBAKBEOHB <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public NDMOBCMKEJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9068940", Offset = "0x9066F40", VA = "0x189068940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x90689D0", Offset = "0x9066FD0", VA = "0x1890689D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9062A80", Offset = "0x9061080", VA = "0x189062A80")]
	[IteratorStateMachine(typeof(FPLEJALGDEB))]
	private static IEnumerator<KAIBAKBEOHB> LIPFOIPJOAA(float OEDPOHDPEIB, MFJFPNHANBJ HIOHIPLNPFI, Action OFMFDPOLEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9820", Offset = "0x3DD7E20", VA = "0x183DD9820")]
	[IteratorStateMachine(typeof(CCBDDAEDDPP<>))]
	private static IEnumerator<KAIBAKBEOHB> LIPFOIPJOAA<T>(float OEDPOHDPEIB, MFJFPNHANBJ HIOHIPLNPFI, Action<T> OFMFDPOLEGO, T CGNPMBIJPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9062640", Offset = "0x9060C40", VA = "0x189062640")]
	[IteratorStateMachine(typeof(NDMOBCMKEJD))]
	private static IEnumerator<KAIBAKBEOHB> HGALBFDPBLL(float OEDPOHDPEIB, MFJFPNHANBJ HIOHIPLNPFI, Action OFMFDPOLEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9062470", Offset = "0x9060A70", VA = "0x189062470")]
	public static IDisposable FIIANGEAJPA(this MonoBehaviour DDCCCNLJKEF, float OEDPOHDPEIB, Action OFMFDPOLEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9062780", Offset = "0x9060D80", VA = "0x189062780")]
	public static FAKIPBKLGEB IOJNNACBEKL(this MonoBehaviour DDCCCNLJKEF, float OEDPOHDPEIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9062550", Offset = "0x9060B50", VA = "0x189062550")]
	public static FAKIPBKLGEB FIIANGEAJPA(this MonoBehaviour DDCCCNLJKEF, float OEDPOHDPEIB, MFJFPNHANBJ HIOHIPLNPFI, Action OFMFDPOLEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x9062330", Offset = "0x9060930", VA = "0x189062330")]
	public static FAKIPBKLGEB AHAIOGFIMCD(this MonoBehaviour DDCCCNLJKEF, Action OFMFDPOLEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3DD97F0", Offset = "0x3DD7DF0", VA = "0x183DD97F0")]
	public static FAKIPBKLGEB AHAIOGFIMCD<T>(this MonoBehaviour DDCCCNLJKEF, Action<T> OFMFDPOLEGO, T CGNPMBIJPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x90629E0", Offset = "0x9060FE0", VA = "0x1890629E0")]
	public static FAKIPBKLGEB JOCPOIPJJNO(this MonoBehaviour DDCCCNLJKEF, Action OFMFDPOLEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9062BC0", Offset = "0x90611C0", VA = "0x189062BC0")]
	public static FAKIPBKLGEB NEIOEBDHEBP(this MonoBehaviour DDCCCNLJKEF, Action OFMFDPOLEGO, [Optional] DJEIDPKGCPH PEACDDCMCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x90628B0", Offset = "0x9060EB0", VA = "0x1890628B0")]
	public static FAKIPBKLGEB JHCJNJCBEMF(this MonoBehaviour DDCCCNLJKEF, Action OFMFDPOLEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9062B20", Offset = "0x9061120", VA = "0x189062B20")]
	public static FAKIPBKLGEB NDPLDJOECDP(this MonoBehaviour DDCCCNLJKEF, Action OFMFDPOLEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9062C60", Offset = "0x9061260", VA = "0x189062C60")]
	public static FAKIPBKLGEB NJOAFAGMNIK(MonoBehaviour DDCCCNLJKEF, MFJFPNHANBJ GIPLNPNDFAP, Action OFMFDPOLEGO, [Optional] DJEIDPKGCPH PEACDDCMCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3DD98E0", Offset = "0x3DD7EE0", VA = "0x183DD98E0")]
	public static FAKIPBKLGEB NJOAFAGMNIK<T>(MonoBehaviour DDCCCNLJKEF, MFJFPNHANBJ GIPLNPNDFAP, Action<T> OFMFDPOLEGO, T CGNPMBIJPEO, [Optional] DJEIDPKGCPH PEACDDCMCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9062950", Offset = "0x9060F50", VA = "0x189062950")]
	public static FAKIPBKLGEB JMJJFPODMOD(this MonoBehaviour DDCCCNLJKEF, float DOMLKNDDACF, Action OFMFDPOLEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x90626E0", Offset = "0x9060CE0", VA = "0x1890626E0")]
	public static FAKIPBKLGEB HMNNPFGNHLK(this MonoBehaviour DDCCCNLJKEF, float DOMLKNDDACF, Action OFMFDPOLEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x90623D0", Offset = "0x90609D0", VA = "0x1890623D0")]
	public static FAKIPBKLGEB FIDKGBOAPAE(this MonoBehaviour DDCCCNLJKEF, float DOMLKNDDACF, Action OFMFDPOLEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9062810", Offset = "0x9060E10", VA = "0x189062810")]
	public static FAKIPBKLGEB JBALMCEALNM(this MonoBehaviour DDCCCNLJKEF, float DOMLKNDDACF, Action OFMFDPOLEGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GBLNAGNFBEH : HPKDALEFJIK, IEnumerable<HPKDALEFJIK>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly List<HPKDALEFJIK> NMJNMENILLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool POKHPOFDIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Action OHDMMONOACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool NHKEKMGBPMP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool CHKKKFDLJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9061F80", Offset = "0x9060580", VA = "0x189061F80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action COOCDBGIFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x90620C0", Offset = "0x90606C0", VA = "0x1890620C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x90619E0", Offset = "0x905FFE0", VA = "0x1890619E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9062290", Offset = "0x9060890", VA = "0x189062290")]
	public GBLNAGNFBEH([Optional] Action OHDMMONOACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9062160", Offset = "0x9060760", VA = "0x189062160")]
	public void MEFAAGOGBHI(HPKDALEFJIK FMFMFOBOOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9061A80", Offset = "0x9060080", VA = "0x189061A80")]
	private void BJHEIBIOLIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x9061C60", Offset = "0x9060260", VA = "0x189061C60", Slot = "7")]
	public bool HJAADKJMBCP(bool AKKFOJDOENB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x9061C70", Offset = "0x9060270", VA = "0x189061C70", Slot = "8")]
	public bool HJAADKJMBCP(Action PMBBLAOPHON, bool AKKFOJDOENB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x9061BE0", Offset = "0x90601E0", VA = "0x189061BE0", Slot = "9")]
	public IEnumerator<HPKDALEFJIK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x9061BE0", Offset = "0x90601E0", VA = "0x189061BE0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ELCAABDMGHG : KNNMCGLNAMC
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LPHLONGCBLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public ELCAABDMGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LPHLONGCBLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9062D00", Offset = "0x9061300", VA = "0x189062D00")]
		internal void HLPHAEJAKEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class GGGADBOFIBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public ELCAABDMGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GGGADBOFIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9062D00", Offset = "0x9061300", VA = "0x189062D00")]
		internal void MLDOBLNBJAK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly float NCHHIBJFPBJ;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x9061150", Offset = "0x905F750", VA = "0x189061150")]
	public ELCAABDMGHG(Behaviour JIFPJFGEAIK, float NCHHIBJFPBJ, [Optional] Action OHDMMONOACM, [Optional] DJEIDPKGCPH PEACDDCMCEL, [Optional] GMMDEDGBMGC PKACMIALFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x9061040", Offset = "0x905F640", VA = "0x189061040", Slot = "9")]
	protected override bool OPKIGDDBOFD(Action PMBBLAOPHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x9060F30", Offset = "0x905F530", VA = "0x189060F30", Slot = "10")]
	protected override bool JADMCEHEAHN(Action PMBBLAOPHON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HPKDALEFJIK
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CHKKKFDLJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action COOCDBGIFBI;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HJAADKJMBCP(bool AKKFOJDOENB = false);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HJAADKJMBCP(Action PMBBLAOPHON, bool AKKFOJDOENB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class KNNMCGLNAMC : HPKDALEFJIK
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class HBOKCFAGFEA : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public KNNMCGLNAMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public HBOKCFAGFEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x90642D0", Offset = "0x90628D0", VA = "0x1890642D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x90643A0", Offset = "0x90629A0", VA = "0x1890643A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Behaviour JIFPJFGEAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Action OHDMMONOACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private PKCNIKPNNOM MCNLIJGLFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly DJEIDPKGCPH PEACDDCMCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly GMMDEDGBMGC PKACMIALFNF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CHKKKFDLJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xE3C6C0", Offset = "0xE3ACC0", VA = "0x180E3C6C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action COOCDBGIFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x90670A0", Offset = "0x90656A0", VA = "0x1890670A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9066B80", Offset = "0x9065180", VA = "0x189066B80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x9067140", Offset = "0x9065740", VA = "0x189067140")]
	protected KNNMCGLNAMC(Behaviour JIFPJFGEAIK, [Optional] Action OHDMMONOACM, [Optional] DJEIDPKGCPH PEACDDCMCEL, [Optional] GMMDEDGBMGC PKACMIALFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x9067000", Offset = "0x9065600", VA = "0x189067000", Slot = "7")]
	public bool HJAADKJMBCP(bool AKKFOJDOENB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x9066FA0", Offset = "0x90655A0", VA = "0x189066FA0", Slot = "8")]
	public bool HJAADKJMBCP(Action PMBBLAOPHON, bool AKKFOJDOENB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OPKIGDDBOFD(Action PMBBLAOPHON);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool JADMCEHEAHN(Action PMBBLAOPHON);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x9066CB0", Offset = "0x90652B0", VA = "0x189066CB0")]
	protected void CIMFJJANFNA(Action PMBBLAOPHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x9066CD0", Offset = "0x90652D0", VA = "0x189066CD0")]
	protected FBCJGBABFLH FJLHDLIEAHJ(float KFCMKNFBLHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x9066F20", Offset = "0x9065520", VA = "0x189066F20")]
	private void GMBEILPFOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x9066C20", Offset = "0x9065220", VA = "0x189066C20")]
	[IteratorStateMachine(typeof(HBOKCFAGFEA))]
	private IEnumerator<KAIBAKBEOHB> CEIFMGJCNOI(float KFCMKNFBLHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x9067060", Offset = "0x9065660", VA = "0x189067060")]
	[CompilerGenerated]
	private void ICGFCCJKOCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DFNHDAJNBGM : KNNMCGLNAMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly float BLIDBAGCGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int EIPKEKNLPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly float GGMMCJIBNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly float[] MHBIEHEMDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int EBDKLBIDDJD;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x9060340", Offset = "0x905E940", VA = "0x189060340")]
	public DFNHDAJNBGM(Behaviour JIFPJFGEAIK, float KJNHJDFNCDB, int EIPKEKNLPEB, [Optional] Action OHDMMONOACM, float GGMMCJIBNEP = 0f, [Optional] DJEIDPKGCPH PEACDDCMCEL, [Optional] GMMDEDGBMGC PKACMIALFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "9")]
	protected override bool OPKIGDDBOFD(Action PMBBLAOPHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x90600C0", Offset = "0x905E6C0", VA = "0x1890600C0", Slot = "10")]
	protected override bool JADMCEHEAHN(Action PMBBLAOPHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x90602C0", Offset = "0x905E8C0", VA = "0x1890602C0")]
	private void OLBIPMAMDME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class JLGEJGJCLAF : KNNMCGLNAMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float NCHHIBJFPBJ;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x9061150", Offset = "0x905F750", VA = "0x189061150")]
	public JLGEJGJCLAF(Behaviour JIFPJFGEAIK, float NCHHIBJFPBJ, [Optional] Action OHDMMONOACM, [Optional] DJEIDPKGCPH PEACDDCMCEL, [Optional] GMMDEDGBMGC PKACMIALFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "9")]
	protected override bool OPKIGDDBOFD(Action PMBBLAOPHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x9066480", Offset = "0x9064A80", VA = "0x189066480", Slot = "10")]
	protected override bool JADMCEHEAHN(Action PMBBLAOPHON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class CGELKIBGIMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class LAGLLJMFFDN : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public LAGLLJMFFDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x905DB60", Offset = "0x905C160", VA = "0x18905DB60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x90679A0", Offset = "0x9065FA0", VA = "0x1890679A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private FAKIPBKLGEB OKCDMPPCGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private HDFLEBKKIDM JIFPJFGEAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Action<float> PKGPKIFDHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private MFJFPNHANBJ GIPLNPNDFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private float KNPNDKHMJLG;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x905E160", Offset = "0x905C760", VA = "0x18905E160")]
	public CGELKIBGIMF(HDFLEBKKIDM JIFPJFGEAIK, float HFDNHIOELFO, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x905DC60", Offset = "0x905C260", VA = "0x18905DC60")]
	private void ADFKDDAMGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x905DDD0", Offset = "0x905C3D0", VA = "0x18905DDD0")]
	private void AJGNLDFODFD(string DAANGKEHOHD, Action PFLJKDIEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x905E0E0", Offset = "0x905C6E0", VA = "0x18905E0E0")]
	[IteratorStateMachine(typeof(LAGLLJMFFDN))]
	private IEnumerator<KAIBAKBEOHB> PBEEEDPOPCM(Action PFLJKDIEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x905DF00", Offset = "0x905C500", VA = "0x18905DF00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x905DF60", Offset = "0x905C560", VA = "0x18905DF60")]
	[CompilerGenerated]
	private void FOOGOPIOHBF(string MFJLILBLNGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class OAAKKJDKJDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BBOMNEDIJOL : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public BBOMNEDIJOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x905DB60", Offset = "0x905C160", VA = "0x18905DB60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x905DBD0", Offset = "0x905C1D0", VA = "0x18905DBD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private FAKIPBKLGEB OKCDMPPCGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private MonoBehaviour DDCCCNLJKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Action GEMFDOMGNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Action<float> PKGPKIFDHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private MFJFPNHANBJ GIPLNPNDFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private float KNPNDKHMJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private bool BMFNIBKJPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly DJEIDPKGCPH PEACDDCMCEL;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x9069D80", Offset = "0x9068380", VA = "0x189069D80")]
	public OAAKKJDKJDH(MonoBehaviour DDCCCNLJKEF, Action GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, [Optional] DJEIDPKGCPH PEACDDCMCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x9069F10", Offset = "0x9068510", VA = "0x189069F10")]
	public OAAKKJDKJDH(MonoBehaviour DDCCCNLJKEF, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, [Optional] DJEIDPKGCPH PEACDDCMCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x9069BA0", Offset = "0x90681A0", VA = "0x189069BA0")]
	public OAAKKJDKJDH(MonoBehaviour DDCCCNLJKEF, float HFDNHIOELFO, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, bool BMFNIBKJPBL = true, [Optional] DJEIDPKGCPH PEACDDCMCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0xF3B920", Offset = "0xF39F20", VA = "0x180F3B920")]
	private OAAKKJDKJDH(DJEIDPKGCPH PEACDDCMCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x9069860", Offset = "0x9067E60", VA = "0x189069860")]
	internal static OAAKKJDKJDH MLJBAMIBECC(MonoBehaviour DDCCCNLJKEF, float HFDNHIOELFO, Action<float> GEMFDOMGNDH, MFJFPNHANBJ GIPLNPNDFAP, bool BMFNIBKJPBL = true, [Optional] DJEIDPKGCPH PEACDDCMCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x9069730", Offset = "0x9067D30", VA = "0x189069730")]
	private void LGHLGDBGKKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x9069420", Offset = "0x9067A20", VA = "0x189069420")]
	private void HIKDLEDLHIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x9068F70", Offset = "0x9067570", VA = "0x189068F70")]
	private void ADFKDDAMGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x90695A0", Offset = "0x9067BA0", VA = "0x1890695A0")]
	private void KIAPOLPADGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x90690E0", Offset = "0x90676E0", VA = "0x1890690E0")]
	private void AJGNLDFODFD(string DAANGKEHOHD, Action PFLJKDIEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x9069A90", Offset = "0x9068090", VA = "0x189069A90")]
	[IteratorStateMachine(typeof(BBOMNEDIJOL))]
	private IEnumerator<KAIBAKBEOHB> PBEEEDPOPCM(Action PFLJKDIEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x9069330", Offset = "0x9067930", VA = "0x189069330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x90692A0", Offset = "0x90678A0", VA = "0x1890692A0")]
	[CompilerGenerated]
	private void BHBGKBAOJGL(string MFJLILBLNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x9069210", Offset = "0x9067810", VA = "0x189069210")]
	[CompilerGenerated]
	private void BAIOHOEGHJI(string MFJLILBLNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x9069B10", Offset = "0x9068110", VA = "0x189069B10")]
	[CompilerGenerated]
	private void PMNBBDELGHG(string MFJLILBLNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x9069390", Offset = "0x9067990", VA = "0x189069390")]
	[CompilerGenerated]
	private void FLPIIOMKAMI(string MFJLILBLNGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
internal enum OOCIANHPHLO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MBMIKKAKHIA : GMMDEDGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float COHKBGGHDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9067C30", Offset = "0x9066230", VA = "0x189067C30", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float KALKFPLIHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9067C40", Offset = "0x9066240", VA = "0x189067C40", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public double HCOENAFHAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9067CC0", Offset = "0x90662C0", VA = "0x189067CC0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x9067C50", Offset = "0x9066250", VA = "0x189067C50")]
	[EGNICHGEFDG.KHJDAJHJKCM]
	internal static void GOLDGDOKEIF(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	[UnityEngine.Scripting.Preserve]
	internal MBMIKKAKHIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface HJDHLKOHMMD
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODPIFLLOOJM(string NDIENANOGEK);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFOOLPMOHKK();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface ANLPCCDFMNL
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DIBGFNJPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool FCHLNIMHOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal class DJKBJNHKCIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public OLIBILLCIAF PLDJLKLONPG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int GKFLGCDAIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x9060A90", Offset = "0x905F090", VA = "0x189060A90")]
	public static KAIBAKBEOHB CONEBIIJOIN(IEnumerator<KAIBAKBEOHB> IBIGPDCGHHK, LCAALIHDLNP NBMEIJICGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x9060BF0", Offset = "0x905F1F0", VA = "0x189060BF0")]
	public KAIBAKBEOHB CONEBIIJOIN(LCAALIHDLNP[] FONBBDNDAOL, IEnumerator<KAIBAKBEOHB>[] COBLPKCBOHO, KAIBAKBEOHB[] DABBKLOEAGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x9060920", Offset = "0x905EF20", VA = "0x189060920")]
	public void CHLJGKBKEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x9060CB0", Offset = "0x905F2B0", VA = "0x189060CB0")]
	public void GMGIKKFCHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x9060950", Offset = "0x905EF50", VA = "0x189060950")]
	public void CINNGPMJBPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x9060920", Offset = "0x905EF20", VA = "0x189060920")]
	public void ICBGPFPDLLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public DJKBJNHKCIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class OLIBILLCIAF
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct HOJHLPNIJIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public DJKBJNHKCIO KLDLIKMNCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public HDFLEBKKIDM OALJMBCNDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public LCAALIHDLNP JADFCDAJODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IEnumerator<KAIBAKBEOHB> DOMEALMFNOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public KAIBAKBEOHB PLHJIEEDNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public OOCIANHPHLO BBGOLOOAODM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct IFHEJBJMNIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public MFJFPNHANBJ CFOILCELPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public List<HOJHLPNIJIC> HPKMEKAAJBO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class PKLGLMNEFAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public LCAALIHDLNP promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public OLIBILLCIAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public HDFLEBKKIDM context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public DJKBJNHKCIO routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public OOCIANHPHLO coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public KAIBAKBEOHB currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public IEnumerator<KAIBAKBEOHB> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PKLGLMNEFAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x906EC20", Offset = "0x906D220", VA = "0x18906EC20")]
		internal void GJICKMLHPBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class GNEDJHKECDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public DJKBJNHKCIO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public OLIBILLCIAF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GNEDJHKECDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9062E40", Offset = "0x9061440", VA = "0x189062E40")]
		internal void MEDPINADGED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class JDBPJEGOJLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public DJKBJNHKCIO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public OLIBILLCIAF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JDBPJEGOJLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x90661C0", Offset = "0x90647C0", VA = "0x1890661C0")]
		internal void KLHHIMGJPLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class BELKALPABEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public DJKBJNHKCIO schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public OLIBILLCIAF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BELKALPABEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x905DC20", Offset = "0x905C220", VA = "0x18905DC20")]
		internal void EOALNNFAELH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const OOCIANHPHLO JPDKHIGJAFP = OOCIANHPHLO.Cancelled | OOCIANHPHLO.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MFJFPNHANBJ GIPLNPNDFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool[] HBOHDJCLCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private NativeArray<OOCIANHPHLO> BLIHEIKMFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private NativeArray<float> PMKAJJPHCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private NativeArray<int> HJMNPMGGKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeArray<int> MGFBKFGGMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<int> CALDGCHLMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<int> ENAPBBCIFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<int> AMILBEGBJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private DJKBJNHKCIO[] EMKAHPHAMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private LCAALIHDLNP[] FONBBDNDAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private HDFLEBKKIDM[] AMKMCFHPNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private IEnumerator<KAIBAKBEOHB>[] BKJJPJODEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private KAIBAKBEOHB[] FPGMMLFBJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int BGFEDFLBAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int AHIAOIDMGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly int PFDNBMJFENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private float FMOFLPBGBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private EOCDIIIIFCF CMIDAILDMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private JobHandle AIKGLFDFOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private List<DJKBJNHKCIO> GBBKGGIAEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool OKHBMNIABBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private List<Action> KKMKGFGEHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private List<Action> IOMMEPBDGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool BEFLPMBHHOC;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IFHEJBJMNIP[] MABNDNLBJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xC1F3B0", Offset = "0xC1D9B0", VA = "0x180C1F3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x906BE30", Offset = "0x906A430", VA = "0x18906BE30")]
	private static int KJFJLKNFKFL(MFJFPNHANBJ GIPLNPNDFAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x906CA70", Offset = "0x906B070", VA = "0x18906CA70")]
	public OLIBILLCIAF(MFJFPNHANBJ GIPLNPNDFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x906BA20", Offset = "0x906A020", VA = "0x18906BA20")]
	private void EKEPOAKKKEI(int JMEALDICENN, int AILCJIPBLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x906AFD0", Offset = "0x90695D0", VA = "0x18906AFD0")]
	public void DECAPIOLMPB(HDFLEBKKIDM JIFPJFGEAIK, KAIBAKBEOHB IKMNGAPMFBI, IEnumerator<KAIBAKBEOHB> IBIGPDCGHHK, LCAALIHDLNP NBMEIJICGAP, [Optional] DJKBJNHKCIO AKCMCMAINJC, OOCIANHPHLO JPMDJEEBGJP = OOCIANHPHLO.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x906C830", Offset = "0x906AE30", VA = "0x18906C830")]
	public void NDGGEIICLJP(IEnumerable<HOJHLPNIJIC> PNHGAJGLKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x906AB00", Offset = "0x9069100", VA = "0x18906AB00")]
	private HOJHLPNIJIC BPDDDEBLKAI(int PKKDMJEBOEM)
	{
		return default(HOJHLPNIJIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x906C260", Offset = "0x906A860", VA = "0x18906C260")]
	private void MECOOLLPBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3F84460", Offset = "0x3F82A60", VA = "0x183F84460")]
	private static void CBEIFOLBHKJ<T>(int PKKDMJEBOEM, T[] JLJAAIKNOGC, int KCJLCGFEBMJ, [Optional] T PGOGCEPIPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3F844B0", Offset = "0x3F82AB0", VA = "0x183F844B0")]
	private static void CBEIFOLBHKJ<T>(int PKKDMJEBOEM, NativeArray<T> JLJAAIKNOGC, int KCJLCGFEBMJ, [Optional] T PGOGCEPIPIB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x906A6E0", Offset = "0x9068CE0", VA = "0x18906A6E0")]
	private void BBCIDMOIPIM(IEnumerable<HOJHLPNIJIC> PNHGAJGLKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x906C060", Offset = "0x906A660", VA = "0x18906C060")]
	private void LHKJLAPLFFH(HOJHLPNIJIC FJGFBJAKNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x906C5D0", Offset = "0x906ABD0", VA = "0x18906C5D0")]
	private GHLHKDHJBBC MKAKIDKDNFM(int DEHCHDLJHBP)
	{
		return default(GHLHKDHJBBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x906BE60", Offset = "0x906A460", VA = "0x18906BE60")]
	public void KOAGDFIMJFP(float NFOFONOBILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x906B870", Offset = "0x9069E70", VA = "0x18906B870")]
	private void DNPLJGMEPFI(Action JGPEJMANNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x906AA80", Offset = "0x9069080", VA = "0x18906AA80")]
	private void BCCHPECGMDC(Action JGPEJMANNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x906B150", Offset = "0x9069750", VA = "0x18906B150")]
	public void DLEKBKBONIO(float NFOFONOBILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x906BC00", Offset = "0x906A200", VA = "0x18906BC00")]
	public void ELCJDKMDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x906BD00", Offset = "0x906A300", VA = "0x18906BD00")]
	public void ICBGPFPDLLB(DJKBJNHKCIO FLBIKDMLAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x906B8F0", Offset = "0x9069EF0", VA = "0x18906B8F0")]
	public void EEEOMJDOMAD(DJKBJNHKCIO FLBIKDMLAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x906C130", Offset = "0x906A730", VA = "0x18906C130")]
	public void LMPBHFCOMHP(DJKBJNHKCIO FLBIKDMLAKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class KAHFOLJBHCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public static readonly KAHFOLJBHCC HPOBBIFAPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Action JAIKONNCDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool AHFHMNIBLBI;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public KAHFOLJBHCC(Action JAIKONNCDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x866E2A0", Offset = "0x866C8A0", VA = "0x18866E2A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface JENEFCKIJMG<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable EHLPFLNNINK(UnityEngine.Object JIFPJFGEAIK, Action<T> HAMPKPMFIOD);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface OBFNMFFJIFD<T> : JENEFCKIJMG<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	new T CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class FPFONELMALK<T> : OBFNMFFJIFD<T>, JENEFCKIJMG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class COGNFOJEIOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public FPFONELMALK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public KHIFPLIFILG<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public COGNFOJEIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7033640", Offset = "0x7031C40", VA = "0x187033640")]
		internal void HCABOPEBCMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static GameObject ODEHDHMDPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<KHIFPLIFILG<UnityEngine.Object, Action<T>>> APMCGEEFNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private T GDCBDAPGCLH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xB268D0", Offset = "0xB24ED0", VA = "0x180B268D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x502FB00", Offset = "0x502E100", VA = "0x18502FB00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5030210", Offset = "0x502E810", VA = "0x185030210")]
	private static bool OGDLICHDBGH(T JGPEJMANNEB, T PDHHCOODKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x50302E0", Offset = "0x502E8E0", VA = "0x1850302E0")]
	public FPFONELMALK(T NOIAIINNPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x502F8F0", Offset = "0x502DEF0", VA = "0x18502F8F0", Slot = "6")]
	public IDisposable EHLPFLNNINK(UnityEngine.Object JIFPJFGEAIK, Action<T> HAMPKPMFIOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x502FB80", Offset = "0x502E180", VA = "0x18502FB80")]
	private void MONCFFPHFFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class MMKPNFHOOFP : JGEIJOKHDPN
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class KALCINOEKKO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class JFILDFPGLBL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int NMILEMOAODL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private KALCINOEKKO HIOHIPLNPFI;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x109CF20", Offset = "0x109B520", VA = "0x18109CF20")]
			public JFILDFPGLBL(int NMILEMOAODL, KALCINOEKKO HIOHIPLNPFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x9066200", Offset = "0x9064800", VA = "0x189066200", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class JOBGNPGPHMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public JOBGNPGPHMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool EMPAECEGBIN(KNOEPLBFLBA e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class AIAOCAMFHPG : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private KAIBAKBEOHB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public KALCINOEKKO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public GMMDEDGBMGC timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private LNCHOABCCLM <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private List<KNOEPLBFLBA> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public AIAOCAMFHPG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x905D810", Offset = "0x905BE10", VA = "0x18905D810", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x905DB10", Offset = "0x905C110", VA = "0x18905DB10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly MFJFPNHANBJ GIPLNPNDFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private FAKIPBKLGEB NBMEIJICGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly List<KNOEPLBFLBA> GFNBOLMANDI;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x90669D0", Offset = "0x9064FD0", VA = "0x1890669D0")]
		public KALCINOEKKO(MFJFPNHANBJ GIPLNPNDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9066620", Offset = "0x9064C20", VA = "0x189066620")]
		public IDisposable IAONPHKIJFA(KNOEPLBFLBA GBKFIMCBIKC, DJEIDPKGCPH PEACDDCMCEL, GMMDEDGBMGC PGBOBMDDLFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x90667B0", Offset = "0x9064DB0", VA = "0x1890667B0")]
		private void JCGANODKKOA(int NMILEMOAODL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9066940", Offset = "0x9064F40", VA = "0x189066940")]
		[IteratorStateMachine(typeof(AIAOCAMFHPG))]
		private IEnumerator<KAIBAKBEOHB> LNCFAMKKKGM(GMMDEDGBMGC PGBOBMDDLFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x90665D0", Offset = "0x9064BD0", VA = "0x1890665D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class KNOEPLBFLBA
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public enum IIPHPCBEMNN : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static int IGCHLJLIDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int HMNNHOPLICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly AKDIJPFDGAK OALJMBCNDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly MonoBehaviour BHAKNIAJJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly Action FPGILMIKMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly Action<float> PEKEAMMBFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly float FGOEEICAEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public float PMKAJJPHCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly string EEABAFMMHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly bool MOLKLLHLOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly IIPHPCBEMNN LAGDDDNCFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool ICKDLNECGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public bool BNFMFDIOMCM;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x90676A0", Offset = "0x9065CA0", VA = "0x1890676A0")]
		public KNOEPLBFLBA(AKDIJPFDGAK JIFPJFGEAIK, Action GEMFDOMGNDH, bool NIKLFBENDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9067820", Offset = "0x9065E20", VA = "0x189067820")]
		public KNOEPLBFLBA(AKDIJPFDGAK JIFPJFGEAIK, Action<float> GEMFDOMGNDH, bool NIKLFBENDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x90674C0", Offset = "0x9065AC0", VA = "0x1890674C0")]
		public KNOEPLBFLBA(AKDIJPFDGAK JIFPJFGEAIK, float HFDNHIOELFO, Action<float> GEMFDOMGNDH, GMMDEDGBMGC PGBOBMDDLFM, IIPHPCBEMNN GGCBGGOEEIN, bool BMFNIBKJPBL, bool NIKLFBENDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9067270", Offset = "0x9065870", VA = "0x189067270")]
		public bool BPEJLHLALKI(float HBAPMMDKJDM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly DJEIDPKGCPH PEACDDCMCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly GMMDEDGBMGC PKACMIALFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<MFJFPNHANBJ, KALCINOEKKO> IGKFIICFIBF;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x90684C0", Offset = "0x9066AC0", VA = "0x1890684C0")]
	[EGNICHGEFDG.KHJDAJHJKCM]
	internal static void OBEILDPCOFA(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x90687B0", Offset = "0x9066DB0", VA = "0x1890687B0")]
	[UnityEngine.Scripting.Preserve]
	internal MMKPNFHOOFP([EDHLHMEHMKO(null)] DJEIDPKGCPH PEACDDCMCEL, [EDHLHMEHMKO(null)] GMMDEDGBMGC PKACMIALFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x9067ED0", Offset = "0x90664D0", VA = "0x189067ED0", Slot = "4")]
	public IDisposable FPGILMIKMIA(AKDIJPFDGAK JIFPJFGEAIK, Action LAOAAOBGDLL, MFJFPNHANBJ GIPLNPNDFAP, bool NIKLFBENDPH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x9067CE0", Offset = "0x90662E0", VA = "0x189067CE0", Slot = "5")]
	public IDisposable FPGILMIKMIA(AKDIJPFDGAK JIFPJFGEAIK, Action<float> LAOAAOBGDLL, MFJFPNHANBJ GIPLNPNDFAP, bool NIKLFBENDPH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9068530", Offset = "0x9066B30", VA = "0x189068530", Slot = "7")]
	public IDisposable OKKFONOBIAJ(AKDIJPFDGAK JIFPJFGEAIK, float HFDNHIOELFO, Action<float> LAOAAOBGDLL, MFJFPNHANBJ GIPLNPNDFAP, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x9068200", Offset = "0x9066800", VA = "0x189068200", Slot = "8")]
	public IDisposable IBGKCDGNLKL(AKDIJPFDGAK JIFPJFGEAIK, float HFDNHIOELFO, Action<float> LAOAAOBGDLL, MFJFPNHANBJ GIPLNPNDFAP, bool BMFNIBKJPBL = true, bool NIKLFBENDPH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x9068630", Offset = "0x9066C30", VA = "0x189068630", Slot = "6")]
	public IDisposable OKKFONOBIAJ(float HFDNHIOELFO, Action<float> LAOAAOBGDLL, bool BMFNIBKJPBL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9068300", Offset = "0x9066900", VA = "0x189068300", Slot = "9")]
	public void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x90680C0", Offset = "0x90666C0", VA = "0x1890680C0")]
	private KALCINOEKKO GNKIBOLOCCD(MFJFPNHANBJ GIPLNPNDFAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class PADNGANMCPO : GPFCCGALIIL, DJEIDPKGCPH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private OLIBILLCIAF[] HGGAJGHKIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private HJDHLKOHMMD OMOEKFCANJH;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x906D870", Offset = "0x906BE70", VA = "0x18906D870")]
	[EGNICHGEFDG.KHJDAJHJKCM]
	internal static void GOLDGDOKEIF(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x906DCA0", Offset = "0x906C2A0", VA = "0x18906DCA0")]
	[UnityEngine.Scripting.Preserve]
	public PADNGANMCPO([EDHLHMEHMKO(null)] JCAIKBFIABE BAEOFNAPMEM, [EDHLHMEHMKO(null)] GMMDEDGBMGC PKACMIALFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x906DB70", Offset = "0x906C170", VA = "0x18906DB70", Slot = "19")]
	public override FAKIPBKLGEB NLCIFOFFDFM(HDFLEBKKIDM JIFPJFGEAIK, IEnumerator<KAIBAKBEOHB> DMLHNKFOGEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x906D8E0", Offset = "0x906BEE0", VA = "0x18906D8E0", Slot = "20")]
	public override void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x906D420", Offset = "0x906BA20", VA = "0x18906D420", Slot = "22")]
	public override void DJMDHHIPMNN(MFJFPNHANBJ GIPLNPNDFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x906D7A0", Offset = "0x906BDA0", VA = "0x18906D7A0", Slot = "21")]
	protected override void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x906D710", Offset = "0x906BD10", VA = "0x18906D710")]
	private OLIBILLCIAF DNHDAMGAMNH(MFJFPNHANBJ GPEIAHGICNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x906D0D0", Offset = "0x906B6D0", VA = "0x18906D0D0", Slot = "23")]
	internal override CIOCEJMCLHK CNLFBKJDEJJ(IEnumerator<KAIBAKBEOHB> DMLHNKFOGEO, Behaviour JIFPJFGEAIK, LCAALIHDLNP NBMEIJICGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x906D650", Offset = "0x906BC50", VA = "0x18906D650", Slot = "24")]
	internal override IOJAEHHPLJD DLOEPAAHDMC(MFJFPNHANBJ HIOHIPLNPFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x906D300", Offset = "0x906B900", VA = "0x18906D300")]
	private void DDCOBPALAJD(OLIBILLCIAF HBCAHICNOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x906D740", Offset = "0x906BD40", VA = "0x18906D740", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[BurstCompile]
internal struct EOCDIIIIFCF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[ReadOnly]
	public float MPKPCHKMFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[ReadOnly]
	public int KEMEOMCDNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> PJOANHLJOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeArray<int> KBPHJOMKKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<int> KONALAMPADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	public NativeArray<OOCIANHPHLO> FJNLHBADODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	public NativeArray<float> JPNOKKKIPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[WriteOnly]
	public NativeArray<int> CALDGCHLMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[WriteOnly]
	public NativeArray<int> HJMNPMGGKFH;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x90612D0", Offset = "0x905F8D0", VA = "0x1890612D0")]
	public static EOCDIIIIFCF CEAHGFMKGJD(int CEJNFLOJFAE, float NFOFONOBILD, NativeArray<OOCIANHPHLO> IOBOMNBKIBB, NativeArray<float> GMHGPINODDM, NativeArray<int> LJKIDDFLGGA, NativeArray<int> HLOBMBPAMAJ, NativeArray<int> DLELDPJDHNJ, NativeArray<int> KBPHJOMKKOP, NativeArray<int> KONALAMPADM)
	{
		return default(EOCDIIIIFCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x9061570", Offset = "0x905FB70", VA = "0x189061570", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x9061290", Offset = "0x905F890", VA = "0x189061290")]
	private bool AHMPIDGFMLO(int PMIGBJGNLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x9061720", Offset = "0x905FD20", VA = "0x189061720")]
	private void LFNHKKHKICP(NativeArray<int> MDIMFHGEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x9061750", Offset = "0x905FD50", VA = "0x189061750")]
	private int OJNIHEMMDKF(int AJPJCNFENLO, int AFANLGFLNMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x9061650", Offset = "0x905FC50", VA = "0x189061650")]
	private void KOBNDMDKCFJ(NativeArray<int> MDIMFHGEOCP, int GLILBBNCCCI, int OCNJDNNPAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x9061330", Offset = "0x905F930", VA = "0x189061330")]
	private void EOONLGIIMDF(NativeArray<int> MDIMFHGEOCP, int GAENINCNCFO, int EBKAMAKIMND, int ILFNNDGBDIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class GPFCCGALIIL : DJEIDPKGCPH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly JCAIKBFIABE BAEOFNAPMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	protected readonly GMMDEDGBMGC PKACMIALFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private IOJAEHHPLJD[] BJMAMPIDBBF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static DJEIDPKGCPH EHBCEBDHHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x90636A0", Offset = "0x9061CA0", VA = "0x1890636A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool NMKMFLCMAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public MFJFPNHANBJ KKAOFHPMPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MFJFPNHANBJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public GMMDEDGBMGC ICOJPNGAKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KAIBAKBEOHB DDFAHHGMDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public KAIBAKBEOHB NNCFMBCDEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public KAIBAKBEOHB JENACGNNNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KAIBAKBEOHB LMJNAOHBHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x9062EE0", Offset = "0x90614E0", VA = "0x189062EE0")]
	public static FAKIPBKLGEB CHLFNACDEDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x9063DE0", Offset = "0x90623E0", VA = "0x189063DE0")]
	[UnityEngine.Scripting.Preserve]
	protected GPFCCGALIIL([EDHLHMEHMKO(null)] JCAIKBFIABE BAEOFNAPMEM, [EDHLHMEHMKO(null)] GMMDEDGBMGC PKACMIALFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x9062F70", Offset = "0x9061570", VA = "0x189062F70", Slot = "6")]
	public FAKIPBKLGEB CKKIIFJHCHE(IEnumerator<KAIBAKBEOHB> DMLHNKFOGEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x9062F80", Offset = "0x9061580", VA = "0x189062F80", Slot = "7")]
	public FAKIPBKLGEB CKKIIFJHCHE(Behaviour JIFPJFGEAIK, IEnumerator<KAIBAKBEOHB> DMLHNKFOGEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract FAKIPBKLGEB NLCIFOFFDFM(HDFLEBKKIDM JIFPJFGEAIK, IEnumerator<KAIBAKBEOHB> DMLHNKFOGEO);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x90637B0", Offset = "0x9061DB0", VA = "0x1890637B0", Slot = "20")]
	public virtual void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x90639B0", Offset = "0x9061FB0", VA = "0x1890639B0", Slot = "9")]
	public void LONLEOKACNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x9063680", Offset = "0x9061C80", VA = "0x189063680", Slot = "21")]
	protected virtual void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x9063990", Offset = "0x9061F90", VA = "0x189063990")]
	private void KKMMCFBAKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x90635D0", Offset = "0x9061BD0", VA = "0x1890635D0")]
	private void EEPMGJHMMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x9063790", Offset = "0x9061D90", VA = "0x189063790")]
	private void IJICEPGJMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9063BF0", Offset = "0x90621F0", VA = "0x189063BF0")]
	private void NCILFDNBJLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x9063970", Offset = "0x9061F70", VA = "0x189063970")]
	private void KBFPEJNNGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x9063710", Offset = "0x9061D10", VA = "0x189063710")]
	private void HJKKGJCMJIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x9063950", Offset = "0x9061F50", VA = "0x189063950")]
	private void JMMKIHBGIIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x9063180", Offset = "0x9061780", VA = "0x189063180", Slot = "22")]
	public virtual void DJMDHHIPMNN(MFJFPNHANBJ GIPLNPNDFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x9063C10", Offset = "0x9062210", VA = "0x189063C10")]
	private void OAJNIMABCJE(IOJAEHHPLJD HBCAHICNOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x29F2900", Offset = "0x29F0F00", VA = "0x1829F2900")]
	private IOJAEHHPLJD GKNBEKOIOED(MFJFPNHANBJ GPEIAHGICNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract CIOCEJMCLHK CNLFBKJDEJJ(IEnumerator<KAIBAKBEOHB> DMLHNKFOGEO, Behaviour DDCCCNLJKEF, LCAALIHDLNP EEAAOGFDGLA);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract IOJAEHHPLJD DLOEPAAHDMC(MFJFPNHANBJ GIPLNPNDFAP);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x9063210", Offset = "0x9061810", VA = "0x189063210", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9063730", Offset = "0x9061D30", VA = "0x189063730", Slot = "15")]
	public KAIBAKBEOHB IDONPFCGHLL(MFJFPNHANBJ HIOHIPLNPFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x90635F0", Offset = "0x9061BF0", VA = "0x1890635F0", Slot = "16")]
	public KAIBAKBEOHB FMCMOHEAOPP(float OEDPOHDPEIB, MFJFPNHANBJ HIOHIPLNPFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x9062E80", Offset = "0x9061480", VA = "0x189062E80", Slot = "17")]
	public KAIBAKBEOHB ANNOKFMEEIH(Func<bool> MAMPOCOOMDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class CIOCEJMCLHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly LCAALIHDLNP NBMEIJICGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly ANLPCCDFMNL JIFPJFGEAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly bool MHANFBCOFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private string NDIENANOGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private StackTrace CJNCGPAKPCG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerator<KAIBAKBEOHB> DOMEALMFNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public KAIBAKBEOHB PLHJIEEDNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool DMILFLOOLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x905E820", Offset = "0x905CE20", VA = "0x18905E820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool BIMBFJJHEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xDB20C0", Offset = "0xDB06C0", VA = "0x180DB20C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xDCD310", Offset = "0xDCB910", VA = "0x180DCD310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x905E620", Offset = "0x905CC20", VA = "0x18905E620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float ILOHHPEIGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xF50410", Offset = "0xF4EA10", VA = "0x180F50410")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xF50420", Offset = "0xF4EA20", VA = "0x180F50420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x905E9F0", Offset = "0x905CFF0", VA = "0x18905E9F0")]
	public CIOCEJMCLHK(IEnumerator<KAIBAKBEOHB> IBIGPDCGHHK, ANLPCCDFMNL JIFPJFGEAIK, LCAALIHDLNP NBMEIJICGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x905E300", Offset = "0x905C900", VA = "0x18905E300")]
	public KAIBAKBEOHB CONEBIIJOIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x905E8A0", Offset = "0x905CEA0", VA = "0x18905E8A0")]
	public bool OEKDEDOELKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x905E7D0", Offset = "0x905CDD0", VA = "0x18905E7D0")]
	public void ICBGPFPDLLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x905E910", Offset = "0x905CF10", VA = "0x18905E910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0xE25820", Offset = "0xE23E20", VA = "0x180E25820")]
	[CompilerGenerated]
	private void CNPJGMLCCDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class LCAALIHDLNP : KDGIFMHIDMP, FAKIPBKLGEB, PKCNIKPNNOM, FBCJGBABFLH, IEnumerator, KAIBAKBEOHB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private MFJFPNHANBJ NFEMKNIEFLD;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private MFJFPNHANBJ DLIAAKMHLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB78DB0", Offset = "0xB773B0", VA = "0x180B78DB0", Slot = "23")]
		get
		{
			return default(MFJFPNHANBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public MFJFPNHANBJ PLDJLKLONPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x10E2C60", Offset = "0x10E1260", VA = "0x1810E2C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private float KPOPLBCBOLP
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAF6BA0", Offset = "0xAF51A0", VA = "0x180AF6BA0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool ABOCDPGPPOC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x90679F0", Offset = "0x9065FF0", VA = "0x1890679F0", Slot = "24")]
	private bool AOOGPOOFNNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x9067A10", Offset = "0x9066010", VA = "0x189067A10", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x9067A20", Offset = "0x9066020", VA = "0x189067A20")]
	public LCAALIHDLNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal enum GHLHKDHJBBC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class IOJAEHHPLJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum EHJCIAHGPEA
	{
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct GFLBMJCGHJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public MFJFPNHANBJ CFOILCELPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public EHJCIAHGPEA FNPMKFKBIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public List<CIOCEJMCLHK> CGJIILJABFD;
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly EHJCIAHGPEA[] DOPANCPODAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly MFJFPNHANBJ GIPLNPNDFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool BPDILGIKNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly CIOCEJMCLHK[] GFGLNLGMEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly List<CIOCEJMCLHK> DGPELINMHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Stack<int> ONGMILACOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly List<CIOCEJMCLHK> DKKJBALBFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly Stack<int> IOOOBLGDOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly HJDHLKOHMMD GEDEFBEADPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool BEFLPMBHHOC;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public GFLBMJCGHJI[,] MEKABOJGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x9065D20", Offset = "0x9064320", VA = "0x189065D20")]
	public IOJAEHHPLJD(MFJFPNHANBJ HIOHIPLNPFI, HJDHLKOHMMD GEDEFBEADPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x90651D0", Offset = "0x90637D0", VA = "0x1890651D0")]
	public void IADPIIELBPJ(CIOCEJMCLHK IBIGPDCGHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x90647A0", Offset = "0x9062DA0", VA = "0x1890647A0")]
	public void DCCOBIEOFNL(IList<CIOCEJMCLHK> COBLPKCBOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x9064EC0", Offset = "0x90634C0", VA = "0x189064EC0")]
	public void HOPHEGFGOGO(IList<CIOCEJMCLHK> COBLPKCBOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x9065AF0", Offset = "0x90640F0", VA = "0x189065AF0")]
	private void MHPGHMCOLDM(CIOCEJMCLHK IBIGPDCGHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x9065410", Offset = "0x9063A10", VA = "0x189065410")]
	private void JHDCMCNLGCI(IList<CIOCEJMCLHK> COBLPKCBOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x9064D40", Offset = "0x9063340", VA = "0x189064D40")]
	private GHLHKDHJBBC HGIAIAFBMII(CIOCEJMCLHK IBIGPDCGHHK)
	{
		return default(GHLHKDHJBBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x9064BD0", Offset = "0x90631D0", VA = "0x189064BD0")]
	public void FPGILMIKMIA(float NFOFONOBILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x9065900", Offset = "0x9063F00", VA = "0x189065900")]
	public void LONLEOKACNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x90655A0", Offset = "0x9063BA0", VA = "0x1890655A0")]
	private void KOIMJDEACBJ(List<CIOCEJMCLHK> COBLPKCBOHO, Stack<int> BLGBKJILLNI, bool IIBOCOKBNKA, float BEMCINFCOFO = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x9064AB0", Offset = "0x90630B0", VA = "0x189064AB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x90652D0", Offset = "0x90638D0", VA = "0x1890652D0")]
	private void IFHDOKICPBO(List<CIOCEJMCLHK> COBLPKCBOHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class EBIFHODKPCK : HJDHLKOHMMD
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	public void ODPIFLLOOJM(string NDIENANOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
	public void IFOOLPMOHKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public EBIFHODKPCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal class OCHHOGKOBAO : ANLPCCDFMNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Behaviour DDCCCNLJKEF;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x906A130", Offset = "0x9068730", VA = "0x18906A130", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool DIBGFNJPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x906A0E0", Offset = "0x90686E0", VA = "0x18906A0E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FCHLNIMHOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x906A1B0", Offset = "0x90687B0", VA = "0x18906A1B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public OCHHOGKOBAO(Behaviour DDCCCNLJKEF)
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

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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D570", Offset = "0x8C4C170", VA = "0x188C4D570", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C51DD0", Offset = "0x8C509D0", VA = "0x188C51DD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
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
		private struct KNHEBADHOLP
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			[CompilerGenerated]
			private sealed class JHJAEONNAHK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public FFEEILBEAAN.GGOPLCAPALD key;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
				public JHJAEONNAHK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x8C4B900", Offset = "0x8C4A500", VA = "0x188C4B900")]
				internal void EEMONCIGFLO()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000002")]
			public static IDisposable IGKNMKBMFPB;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8C4BD10", Offset = "0x8C4A910", VA = "0x188C4BD10")]
			public static PlayerLoopSystem DAAANLIAJNM(FFEEILBEAAN.GGOPLCAPALD DHCHBFGMFFD)
			{
				return default(PlayerLoopSystem);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct FFIAPCCJCBF
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class LIEBMJNKCLH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public FFEEILBEAAN.GGOPLCAPALD key;

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
				public LIEBMJNKCLH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x8C4C8F0", Offset = "0x8C4B4F0", VA = "0x188C4C8F0")]
				internal void EEMONCIGFLO()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8C46390", Offset = "0x8C44F90", VA = "0x188C46390")]
			public static PlayerLoopSystem DAAANLIAJNM(FFEEILBEAAN.GGOPLCAPALD DHCHBFGMFFD)
			{
				return default(PlayerLoopSystem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly PEOHNMCPNIJ GDLIBGFAMED;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C41070", Offset = "0x8C3FC70", VA = "0x188C41070")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C42260", Offset = "0x8C40E60", VA = "0x188C42260")]
		private static void GMADBPFDBIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C40EA0", Offset = "0x8C3FAA0", VA = "0x188C40EA0")]
		private static void AEGEMBAAGIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C41E00", Offset = "0x8C40A00", VA = "0x188C41E00")]
		private static void FNNJGBGHJKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C410F0", Offset = "0x8C3FCF0", VA = "0x188C410F0")]
		private static void DKMIAJHDIIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3A7A780", Offset = "0x3A79380", VA = "0x183A7A780")]
		private static (PlayerLoopSystem, ACBHBIOJKFE.OBEEOIEHDLH) DLMHFMOANAD<T>()
		{
			return default((PlayerLoopSystem, ACBHBIOJKFE.OBEEOIEHDLH));
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8C41D60", Offset = "0x8C40960", VA = "0x188C41D60")]
		private static (PlayerLoopSystem, ACBHBIOJKFE.OBEEOIEHDLH) DLMHFMOANAD(PlayerLoopSystem OPGBPMPEMIK)
		{
			return default((PlayerLoopSystem, ACBHBIOJKFE.OBEEOIEHDLH));
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A7A880", Offset = "0x3A79480", VA = "0x183A7A880")]
		private static (PlayerLoopSystem, ACBHBIOJKFE.OBEEOIEHDLH) ENKPLOICKCM<T>()
		{
			return default((PlayerLoopSystem, ACBHBIOJKFE.OBEEOIEHDLH));
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3A7BFF0", Offset = "0x3A7ABF0", VA = "0x183A7BFF0")]
		internal static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) IJBKNEDKCNG<TSub>(FFEEILBEAAN.GGOPLCAPALD DHCHBFGMFFD)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3A7A900", Offset = "0x3A79500", VA = "0x183A7A900")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) IJBKNEDKCNG<TParent, TSub>(FFEEILBEAAN.GGOPLCAPALD DHCHBFGMFFD)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C422B0", Offset = "0x8C40EB0", VA = "0x188C422B0")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) IJBKNEDKCNG(FFEEILBEAAN.GGOPLCAPALD DHCHBFGMFFD, Type IEPNOLIPIDE, Type LMLMNKOCOGC)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FFEEILBEAAN
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum GGOPLCAPALD
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
	public class BDIMNACAOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly GGOPLCAPALD GFHHIKCKHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly DOCBNHKAIGD PIGMDNJGMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long HGPMCPAPLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long HOMOOJBBBGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long GJPDCMAFKDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int IKIAILJMKMP;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8C3FE30", Offset = "0x8C3EA30", VA = "0x188C3FE30")]
		public BDIMNACAOFF(GGOPLCAPALD CFMMDPCNPBK, int BMOCCOKCPNB = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8C3FDC0", Offset = "0x8C3E9C0", VA = "0x188C3FDC0")]
		public void NMMLCFBOAGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8C3FDE0", Offset = "0x8C3E9E0", VA = "0x188C3FDE0")]
		public void PEOPAKFJDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8C3FCE0", Offset = "0x8C3E8E0", VA = "0x188C3FCE0")]
		public void NKOFIJJCAIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static GGOPLCAPALD[] EFLLDLHCMAC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static BDIMNACAOFF[] BMKOFHEAFHK;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8C45F70", Offset = "0x8C44B70", VA = "0x188C45F70")]
	public static BDIMNACAOFF EHPGNMKPOOP(GGOPLCAPALD DHCHBFGMFFD, int BMOCCOKCPNB = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8C460D0", Offset = "0x8C44CD0", VA = "0x188C460D0")]
	public static BDIMNACAOFF LKBJKBKPMCC(GGOPLCAPALD DHCHBFGMFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8C46140", Offset = "0x8C44D40", VA = "0x188C46140")]
	public static void NJPCCKFOAMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CNMECLDKOPN
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface NDNBGLNIFOI
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool KCLNIEEJALM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ABBFFCPOGNP();
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class IDICPJAEBAB : NDNBGLNIFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Action KLIEOOEGDML;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KCLNIEEJALM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
		public IDICPJAEBAB(Action KLIEOOEGDML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1289A70", Offset = "0x1288670", VA = "0x181289A70", Slot = "5")]
		public void ABBFFCPOGNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<NDNBGLNIFOI> HIIONIPLHFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool IOHCGBGCLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8C40790", Offset = "0x8C3F390", VA = "0x188C40790")]
	public static void LHJLDCAEACD(Action KLIEOOEGDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8C40B30", Offset = "0x8C3F730", VA = "0x188C40B30")]
	private static void OEIKNIEPMNK(NDNBGLNIFOI MKOPIJEHELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8C40830", Offset = "0x8C3F430", VA = "0x188C40830")]
	private static void MONIHHBHLAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8C40640", Offset = "0x8C3F240", VA = "0x188C40640")]
	private static void FMEGMGIEOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8C40520", Offset = "0x8C3F120", VA = "0x188C40520")]
	private static void ECLFPAEDOKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JPJCECAMPID
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8C4BBC0", Offset = "0x8C4A7C0", VA = "0x188C4BBC0")]
	public static IDisposable DDJMHBOPCOD(this PAHIIACJDAI PBHLPKLGFAP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8C4BC50", Offset = "0x8C4A850", VA = "0x188C4BC50")]
	public static IDisposable PNIFCJBDNED(this PAHIIACJDAI PBHLPKLGFAP, Action<float> BMOMBCIONJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8C4BB40", Offset = "0x8C4A740", VA = "0x188C4BB40")]
	public static IDisposable AOLGLHCIPIN(this PAHIIACJDAI PBHLPKLGFAP, Action<float> BMOMBCIONJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GHJCEOJMNLD
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3C485C0", Offset = "0x3C471C0", VA = "0x183C485C0")]
	[FHDJJLGGPOE]
	public static IDisposable HCCABBDLLBE<T>(this T EHAANMPGLOP, Action BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3C48410", Offset = "0x3C47010", VA = "0x183C48410")]
	[FHDJJLGGPOE]
	public static IDisposable HCCABBDLLBE<T>(this T EHAANMPGLOP, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3C48AC0", Offset = "0x3C476C0", VA = "0x183C48AC0")]
	[FHDJJLGGPOE]
	public static IDisposable MONBEGLCAAD<T>(this T EHAANMPGLOP, Action BMOMBCIONJF, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3C483E0", Offset = "0x3C46FE0", VA = "0x183C483E0")]
	[FHDJJLGGPOE]
	public static IDisposable GMFICEIIMIK<T>(this T EHAANMPGLOP, Action BMOMBCIONJF, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3C483E0", Offset = "0x3C46FE0", VA = "0x183C483E0")]
	[FHDJJLGGPOE]
	public static IDisposable GMFICEIIMIK<T>(this T EHAANMPGLOP, Action<float> BMOMBCIONJF, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3C487F0", Offset = "0x3C473F0", VA = "0x183C487F0")]
	[FHDJJLGGPOE]
	public static IDisposable JADAKHFPIIB<T>(this T EHAANMPGLOP, Action BMOMBCIONJF, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3C48AF0", Offset = "0x3C476F0", VA = "0x183C48AF0")]
	[FHDJJLGGPOE]
	public static IDisposable NBODMBEODDK<T>(this T EHAANMPGLOP, Action BMOMBCIONJF, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3C48820", Offset = "0x3C47420", VA = "0x183C48820")]
	[FHDJJLGGPOE]
	public static IDisposable JIGIJBEFCMD<T>(this T EHAANMPGLOP, Action BMOMBCIONJF, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3C487B0", Offset = "0x3C473B0", VA = "0x183C487B0")]
	[FHDJJLGGPOE]
	public static IDisposable IBBDJPFODBA<T>(this T EHAANMPGLOP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8C465E0", Offset = "0x8C451E0", VA = "0x188C465E0")]
	[FHDJJLGGPOE]
	public static IDisposable IBBDJPFODBA(this MonoBehaviour EHAANMPGLOP, HKJBNPOGLFP PBHLPKLGFAP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3C48890", Offset = "0x3C47490", VA = "0x183C48890")]
	[FHDJJLGGPOE]
	public static IDisposable KLIDNLGGMEN<T>(this T EHAANMPGLOP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3C483A0", Offset = "0x3C46FA0", VA = "0x183C483A0")]
	[FHDJJLGGPOE]
	public static IDisposable FLBFHGPMMHP<T>(this T EHAANMPGLOP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3C48320", Offset = "0x3C46F20", VA = "0x183C48320")]
	[FHDJJLGGPOE]
	public static IDisposable EKGDKENIOEI<T>(this T EHAANMPGLOP, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3C482A0", Offset = "0x3C46EA0", VA = "0x183C482A0")]
	[FHDJJLGGPOE]
	public static IDisposable CCJPKJFDCJB<T>(this T EHAANMPGLOP, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3C48A80", Offset = "0x3C47680", VA = "0x183C48A80")]
	[FHDJJLGGPOE]
	public static IDisposable LPPHHCPIDOE<T>(this T EHAANMPGLOP, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3C48B20", Offset = "0x3C47720", VA = "0x183C48B20")]
	[FHDJJLGGPOE]
	public static IDisposable NLCBHDNODMK<T>(this T EHAANMPGLOP, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3C48A40", Offset = "0x3C47640", VA = "0x183C48A40")]
	[FHDJJLGGPOE]
	public static IDisposable LIFJGKMFPBG<T>(this T EHAANMPGLOP, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3C48850", Offset = "0x3C47450", VA = "0x183C48850")]
	[FHDJJLGGPOE]
	public static IDisposable KIHJHFKGBAH<T>(this T EHAANMPGLOP, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3C48260", Offset = "0x3C46E60", VA = "0x183C48260")]
	[FHDJJLGGPOE]
	public static IDisposable BHKCJNHMKCA<T>(this T EHAANMPGLOP, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C48770", Offset = "0x3C47370", VA = "0x183C48770")]
	[FHDJJLGGPOE]
	public static IDisposable HMHNCIFGNIE<T>(this T EHAANMPGLOP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C482E0", Offset = "0x3C46EE0", VA = "0x183C482E0")]
	[FHDJJLGGPOE]
	public static IDisposable CLBCHBPNHEE<T>(this T EHAANMPGLOP, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C48360", Offset = "0x3C46F60", VA = "0x183C48360")]
	[FHDJJLGGPOE]
	public static IDisposable FIGIPPMAKDB<T>(this T EHAANMPGLOP, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true) where T : MonoBehaviour, HKJBNPOGLFP
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OANLBCAEMMF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DHANKAEMLKB : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public LDOBNDFEMDB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private ALNJOFCJPDF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public DHANKAEMLKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8C451D0", Offset = "0x8C43DD0", VA = "0x188C451D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8C452B0", Offset = "0x8C43EB0", VA = "0x188C452B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IOMANHCKDPJ : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public LDOBNDFEMDB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private ALNJOFCJPDF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public IOMANHCKDPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B2F0", Offset = "0x8C49EF0", VA = "0x188C4B2F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B3E0", Offset = "0x8C49FE0", VA = "0x188C4B3E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4F860", Offset = "0x8C4E460", VA = "0x188C4F860")]
	public static CCGDPHBOCPE HCCABBDLLBE(Action BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4F7D0", Offset = "0x8C4E3D0", VA = "0x188C4F7D0")]
	public static CCGDPHBOCPE HCCABBDLLBE(Behaviour PBHLPKLGFAP, Action BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4F6F0", Offset = "0x8C4E2F0", VA = "0x188C4F6F0")]
	public static CCGDPHBOCPE HCCABBDLLBE(Behaviour PBHLPKLGFAP, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4F660", Offset = "0x8C4E260", VA = "0x188C4F660")]
	[IteratorStateMachine(typeof(DHANKAEMLKB))]
	private static IEnumerator<LIPOFPKAEIK> BMDKELKODBO(LDOBNDFEMDB OCCBFNHIGDM, Action BMOMBCIONJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4F5D0", Offset = "0x8C4E1D0", VA = "0x188C4F5D0")]
	[IteratorStateMachine(typeof(IOMANHCKDPJ))]
	private static IEnumerator<LIPOFPKAEIK> BMDKELKODBO(LDOBNDFEMDB OCCBFNHIGDM, Action<float> BMOMBCIONJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AJKMADIFOEG : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class ENCINODEHOO : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AJKMADIFOEG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public ENCINODEHOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8C45E90", Offset = "0x8C44A90", VA = "0x188C45E90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8C45F20", Offset = "0x8C44B20", VA = "0x188C45F20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LDOBNDFEMDB KBHHAOPJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Action LNLKDGBKHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool LHKKIPCDGKG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MKBJJIJHHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A350", VA = "0x180A5B750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8C3FC10", Offset = "0x8C3E810", VA = "0x188C3FC10")]
	public AJKMADIFOEG(LDOBNDFEMDB KBHHAOPJAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8C3FAF0", Offset = "0x8C3E6F0", VA = "0x188C3FAF0")]
	[IteratorStateMachine(typeof(ENCINODEHOO))]
	private IEnumerator<LIPOFPKAEIK> NNNBALBMCFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8C3FB70", Offset = "0x8C3E770", VA = "0x188C3FB70", Slot = "4")]
	public void OnCompleted(Action MLPAOOBHNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	public void IMIONNJCNDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class LODIOLHOMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8C4D460", Offset = "0x8C4C060", VA = "0x188C4D460")]
	public static AJKMADIFOEG PFNJCNDHBFE(this LDOBNDFEMDB KBHHAOPJAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HKHIFEAKBKE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class DLENDKMBCNO : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public PPNANDGMBOD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public DLENDKMBCNO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8C45300", Offset = "0x8C43F00", VA = "0x188C45300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8C45380", Offset = "0x8C43F80", VA = "0x188C45380", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8C47760", Offset = "0x8C46360", VA = "0x188C47760")]
	public static CCGDPHBOCPE HCCABBDLLBE(float GBBKLOIIKLG, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, bool BKOLCHNEJMI = true, [Optional] IELPNMNGABM MCBAOPMMIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8C47690", Offset = "0x8C46290", VA = "0x188C47690")]
	public static CCGDPHBOCPE HCCABBDLLBE(MonoBehaviour EHAANMPGLOP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, bool BKOLCHNEJMI = true, [Optional] IELPNMNGABM MCBAOPMMIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8C47900", Offset = "0x8C46500", VA = "0x188C47900")]
	public static CCGDPHBOCPE IJILCCCDEGO(MonoBehaviour EHAANMPGLOP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, bool BKOLCHNEJMI = true, [Optional] IELPNMNGABM MCBAOPMMIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8C47830", Offset = "0x8C46430", VA = "0x188C47830")]
	public static CCGDPHBOCPE HCHIMKCKKND(PAHIIACJDAI PBHLPKLGFAP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, bool BKOLCHNEJMI = true, [Optional] IELPNMNGABM MCBAOPMMIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8C47540", Offset = "0x8C46140", VA = "0x188C47540")]
	private static IEnumerator<LIPOFPKAEIK> BMDKELKODBO(BIBACFPIHOE NABBPKPKDLM, float GBBKLOIIKLG, LDOBNDFEMDB OCCBFNHIGDM, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8C474E0", Offset = "0x8C460E0", VA = "0x188C474E0")]
	private static IEnumerator<LIPOFPKAEIK> ACILJDLJPBD(BIBACFPIHOE NABBPKPKDLM, float GBBKLOIIKLG, LDOBNDFEMDB OCCBFNHIGDM, Action<float> BMOMBCIONJF, bool BKOLCHNEJMI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8C47600", Offset = "0x8C46200", VA = "0x188C47600")]
	[IteratorStateMachine(typeof(DLENDKMBCNO))]
	private static IEnumerator<LIPOFPKAEIK> DOGDKOOHKLE(PPNANDGMBOD KPKFLDBFHBF, float GBBKLOIIKLG, LDOBNDFEMDB OCCBFNHIGDM, Action<float> BMOMBCIONJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JDJFDGHFHPC
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class MPAIFHCLDCK : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public LDOBNDFEMDB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public MPAIFHCLDCK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F3B0", Offset = "0x8C4DFB0", VA = "0x188C4F3B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F470", Offset = "0x8C4E070", VA = "0x188C4F470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8C4B790", Offset = "0x8C4A390", VA = "0x188C4B790")]
	[IteratorStateMachine(typeof(MPAIFHCLDCK))]
	private static IEnumerator<LIPOFPKAEIK> BJBAHKCKOPH(LDOBNDFEMDB KBHHAOPJAPO, Func<bool> MBDNDPHCDDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8C4B820", Offset = "0x8C4A420", VA = "0x188C4B820")]
	public static CCGDPHBOCPE KHDBDBNICLJ(this MonoBehaviour EHAANMPGLOP, Func<bool> MBDNDPHCDDE, LDOBNDFEMDB KBHHAOPJAPO = LDOBNDFEMDB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class LGPJLKFCFBC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BENOHONOKFL : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public LDOBNDFEMDB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public BENOHONOKFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8C3FEC0", Offset = "0x8C3EAC0", VA = "0x188C3FEC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8C3FF30", Offset = "0x8C3EB30", VA = "0x188C3FF30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class AMMBBCNLFAD<T> : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public LDOBNDFEMDB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public AMMBBCNLFAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x518B220", Offset = "0x5189E20", VA = "0x18518B220", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x518B2A0", Offset = "0x5189EA0", VA = "0x18518B2A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KNLEDCOPDIH : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LDOBNDFEMDB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private LIPOFPKAEIK <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public KNLEDCOPDIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4BE40", Offset = "0x8C4AA40", VA = "0x188C4BE40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4BED0", Offset = "0x8C4AAD0", VA = "0x188C4BED0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C670", Offset = "0x8C4B270", VA = "0x188C4C670")]
	[IteratorStateMachine(typeof(BENOHONOKFL))]
	private static IEnumerator<LIPOFPKAEIK> NNNBALBMCFP(float DJMONOPAJCJ, LDOBNDFEMDB OCCBFNHIGDM, Action LOCAHCLFLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3D25CD0", Offset = "0x3D248D0", VA = "0x183D25CD0")]
	[IteratorStateMachine(typeof(AMMBBCNLFAD<>))]
	private static IEnumerator<LIPOFPKAEIK> NNNBALBMCFP<T>(float DJMONOPAJCJ, LDOBNDFEMDB OCCBFNHIGDM, Action<T> LOCAHCLFLKF, T AHGPJFFLNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C100", Offset = "0x8C4AD00", VA = "0x188C4C100")]
	[IteratorStateMachine(typeof(KNLEDCOPDIH))]
	private static IEnumerator<LIPOFPKAEIK> HLLDAHMPAFE(float DJMONOPAJCJ, LDOBNDFEMDB OCCBFNHIGDM, Action LOCAHCLFLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C500", Offset = "0x8C4B100", VA = "0x188C4C500")]
	public static IDisposable MEIDELNJMDO(this MonoBehaviour EHAANMPGLOP, float DJMONOPAJCJ, Action LOCAHCLFLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C240", Offset = "0x8C4AE40", VA = "0x188C4C240")]
	public static CCGDPHBOCPE JAFFBDKNOKK(this MonoBehaviour EHAANMPGLOP, float DJMONOPAJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C410", Offset = "0x8C4B010", VA = "0x188C4C410")]
	public static CCGDPHBOCPE MEIDELNJMDO(this MonoBehaviour EHAANMPGLOP, float DJMONOPAJCJ, LDOBNDFEMDB OCCBFNHIGDM, Action LOCAHCLFLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8C4BFC0", Offset = "0x8C4ABC0", VA = "0x188C4BFC0")]
	public static CCGDPHBOCPE HFKAIECGCOF(this MonoBehaviour EHAANMPGLOP, Action LOCAHCLFLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3D25B70", Offset = "0x3D24770", VA = "0x183D25B70")]
	public static CCGDPHBOCPE HFKAIECGCOF<T>(this MonoBehaviour EHAANMPGLOP, Action<T> LOCAHCLFLKF, T AHGPJFFLNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C7B0", Offset = "0x8C4B3B0", VA = "0x188C4C7B0")]
	public static CCGDPHBOCPE OEEMAPHEJCI(this MonoBehaviour EHAANMPGLOP, Action LOCAHCLFLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C060", Offset = "0x8C4AC60", VA = "0x188C4C060")]
	public static CCGDPHBOCPE HIAEJLOHAJC(this MonoBehaviour EHAANMPGLOP, Action LOCAHCLFLKF, [Optional] IELPNMNGABM MCBAOPMMIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C710", Offset = "0x8C4B310", VA = "0x188C4C710")]
	public static CCGDPHBOCPE OEBAJCHOMFJ(this MonoBehaviour EHAANMPGLOP, Action LOCAHCLFLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8C4BF20", Offset = "0x8C4AB20", VA = "0x188C4BF20")]
	public static CCGDPHBOCPE EKJNNPDMCOE(this MonoBehaviour EHAANMPGLOP, Action LOCAHCLFLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C1A0", Offset = "0x8C4ADA0", VA = "0x188C4C1A0")]
	public static CCGDPHBOCPE IPJNDCFBLPK(MonoBehaviour EHAANMPGLOP, LDOBNDFEMDB KBHHAOPJAPO, Action LOCAHCLFLKF, [Optional] IELPNMNGABM MCBAOPMMIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3D25BA0", Offset = "0x3D247A0", VA = "0x183D25BA0")]
	public static CCGDPHBOCPE IPJNDCFBLPK<T>(MonoBehaviour EHAANMPGLOP, LDOBNDFEMDB KBHHAOPJAPO, Action<T> LOCAHCLFLKF, T AHGPJFFLNPG, [Optional] IELPNMNGABM MCBAOPMMIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C5E0", Offset = "0x8C4B1E0", VA = "0x188C4C5E0")]
	public static CCGDPHBOCPE NJAGJEFPHFP(this MonoBehaviour EHAANMPGLOP, float CIBDGEPOPBC, Action LOCAHCLFLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C2D0", Offset = "0x8C4AED0", VA = "0x188C4C2D0")]
	public static CCGDPHBOCPE LBAJFGMNBFN(this MonoBehaviour EHAANMPGLOP, float CIBDGEPOPBC, Action LOCAHCLFLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C370", Offset = "0x8C4AF70", VA = "0x188C4C370")]
	public static CCGDPHBOCPE MEDEFOLOLFM(this MonoBehaviour EHAANMPGLOP, float CIBDGEPOPBC, Action LOCAHCLFLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C850", Offset = "0x8C4B450", VA = "0x188C4C850")]
	public static CCGDPHBOCPE ONBONIPCADF(this MonoBehaviour EHAANMPGLOP, float CIBDGEPOPBC, Action LOCAHCLFLKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DMFDNGBHECH : OEFEAFJLNPF, IEnumerable<OEFEAFJLNPF>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly List<OEFEAFJLNPF> NHJPFGNMEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool NBNJDNEFFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Action JCAMPGICKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool HFBJFNIKBIH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GDJMLMOKBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C45BA0", Offset = "0x8C447A0", VA = "0x188C45BA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action LBHEBCKJPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8C453D0", Offset = "0x8C43FD0", VA = "0x188C453D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C455D0", Offset = "0x8C441D0", VA = "0x188C455D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8C45CE0", Offset = "0x8C448E0", VA = "0x188C45CE0")]
	public DMFDNGBHECH([Optional] Action JCAMPGICKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8C45A10", Offset = "0x8C44610", VA = "0x188C45A10")]
	public void NDGLNAHKHEG(OEFEAFJLNPF JKFCNEIPIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8C45470", Offset = "0x8C44070", VA = "0x188C45470")]
	private void FFELENKLBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8C456F0", Offset = "0x8C442F0", VA = "0x188C456F0", Slot = "7")]
	public bool JJAMICDCHIE(bool GPAPPOJDLEG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8C45700", Offset = "0x8C44300", VA = "0x188C45700", Slot = "8")]
	public bool JJAMICDCHIE(Action KLIEOOEGDML, bool GPAPPOJDLEG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8C45670", Offset = "0x8C44270", VA = "0x188C45670", Slot = "9")]
	public IEnumerator<OEFEAFJLNPF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8C45670", Offset = "0x8C44270", VA = "0x188C45670", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IPGGLLDLNNN : MAGMKNIPMGH
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OHMCBFEHBLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IPGGLLDLNNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public OHMCBFEHBLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F8E0", Offset = "0x8C4E4E0", VA = "0x188C4F8E0")]
		internal void JGPKKNAIDKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ONOAPJOHGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public IPGGLLDLNNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public ONOAPJOHGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F8E0", Offset = "0x8C4E4E0", VA = "0x188C4F8E0")]
		internal void IGBGGBLKLFJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly float AIGMNFCHLFJ;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8C4B650", Offset = "0x8C4A250", VA = "0x188C4B650")]
	public IPGGLLDLNNN(Behaviour PBHLPKLGFAP, float AIGMNFCHLFJ, [Optional] Action JCAMPGICKIO, [Optional] IELPNMNGABM MCBAOPMMIDB, [Optional] BIBACFPIHOE NABBPKPKDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8C4B430", Offset = "0x8C4A030", VA = "0x188C4B430", Slot = "9")]
	protected override bool HFDMPKFCIME(Action KLIEOOEGDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8C4B540", Offset = "0x8C4A140", VA = "0x188C4B540", Slot = "10")]
	protected override bool IPFCIMBIFLK(Action KLIEOOEGDML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OEFEAFJLNPF
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool GDJMLMOKBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LBHEBCKJPGB;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JJAMICDCHIE(bool GPAPPOJDLEG = false);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JJAMICDCHIE(Action KLIEOOEGDML, bool GPAPPOJDLEG = false);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class MAGMKNIPMGH : OEFEAFJLNPF
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class GDHILMPPEBG : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public MAGMKNIPMGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public GDHILMPPEBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C464C0", Offset = "0x8C450C0", VA = "0x188C464C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8C46590", Offset = "0x8C45190", VA = "0x188C46590", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Behaviour PBHLPKLGFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Action JCAMPGICKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private BNKNLGMMDLE PFOGDOKKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IELPNMNGABM MCBAOPMMIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly BIBACFPIHOE NABBPKPKDLM;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GDJMLMOKBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1C6D720", Offset = "0x1C6C320", VA = "0x181C6D720", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LBHEBCKJPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D600", Offset = "0x8C4C200", VA = "0x188C4D600", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D6A0", Offset = "0x8C4C2A0", VA = "0x188C4D6A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DBC0", Offset = "0x8C4C7C0", VA = "0x188C4DBC0")]
	protected MAGMKNIPMGH(Behaviour PBHLPKLGFAP, [Optional] Action JCAMPGICKIO, [Optional] IELPNMNGABM MCBAOPMMIDB, [Optional] BIBACFPIHOE NABBPKPKDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8C4D7E0", Offset = "0x8C4C3E0", VA = "0x188C4D7E0", Slot = "7")]
	public bool JJAMICDCHIE(bool GPAPPOJDLEG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8C4D780", Offset = "0x8C4C380", VA = "0x188C4D780", Slot = "8")]
	public bool JJAMICDCHIE(Action KLIEOOEGDML, bool GPAPPOJDLEG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool HFDMPKFCIME(Action KLIEOOEGDML);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool IPFCIMBIFLK(Action KLIEOOEGDML);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DB10", Offset = "0x8C4C710", VA = "0x188C4DB10")]
	protected void MHPNIIFKHPN(Action KLIEOOEGDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8C4D840", Offset = "0x8C4C440", VA = "0x188C4D840")]
	protected IPNMFPLCPOG KGDMIPCINOG(float AADMIAHAPGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DA90", Offset = "0x8C4C690", VA = "0x188C4DA90")]
	private void LPIIEBJPAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DB30", Offset = "0x8C4C730", VA = "0x188C4DB30")]
	[IteratorStateMachine(typeof(GDHILMPPEBG))]
	private IEnumerator<LIPOFPKAEIK> NBKLMNMBJMD(float AADMIAHAPGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8C4D740", Offset = "0x8C4C340", VA = "0x188C4D740")]
	[CompilerGenerated]
	private void IMNIPMHDPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MBFPJKEMLCJ : MAGMKNIPMGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly float BILKLFKFODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int EIFLIHMDEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly float BHFMHIOIEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly float[] GPBBMPCIFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int OKHDHBNPCIC;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DF70", Offset = "0x8C4CB70", VA = "0x188C4DF70")]
	public MBFPJKEMLCJ(Behaviour PBHLPKLGFAP, float MELHKILIABE, int EIFLIHMDEBN, [Optional] Action JCAMPGICKIO, float BHFMHIOIEID = 0f, [Optional] IELPNMNGABM MCBAOPMMIDB, [Optional] BIBACFPIHOE NABBPKPKDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "9")]
	protected override bool HFDMPKFCIME(Action KLIEOOEGDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DCF0", Offset = "0x8C4C8F0", VA = "0x188C4DCF0", Slot = "10")]
	protected override bool IPFCIMBIFLK(Action KLIEOOEGDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DEF0", Offset = "0x8C4CAF0", VA = "0x188C4DEF0")]
	private void NHAOFFEDDOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LJEBNKPJAFA : MAGMKNIPMGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float AIGMNFCHLFJ;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8C4B650", Offset = "0x8C4A250", VA = "0x188C4B650")]
	public LJEBNKPJAFA(Behaviour PBHLPKLGFAP, float AIGMNFCHLFJ, [Optional] Action JCAMPGICKIO, [Optional] IELPNMNGABM MCBAOPMMIDB, [Optional] BIBACFPIHOE NABBPKPKDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "9")]
	protected override bool HFDMPKFCIME(Action KLIEOOEGDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8C4CB70", Offset = "0x8C4B770", VA = "0x188C4CB70", Slot = "10")]
	protected override bool IPFCIMBIFLK(Action KLIEOOEGDML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class MGIFKIIONBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class NKJDACGOGIN : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public NKJDACGOGIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F4C0", Offset = "0x8C4E0C0", VA = "0x188C4F4C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F530", Offset = "0x8C4E130", VA = "0x188C4F530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private CCGDPHBOCPE CEDCELKMLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private PAHIIACJDAI PBHLPKLGFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Action<float> GOBHAAPNJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private LDOBNDFEMDB KBHHAOPJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private float OJHNOAFCMNO;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8C4F1D0", Offset = "0x8C4DDD0", VA = "0x188C4F1D0")]
	public MGIFKIIONBL(PAHIIACJDAI PBHLPKLGFAP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8C4ECD0", Offset = "0x8C4D8D0", VA = "0x188C4ECD0")]
	private void AGONGJMIAFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8C4EE40", Offset = "0x8C4DA40", VA = "0x188C4EE40")]
	private void CMJLDOGFMHF(string PDIIGKEPNLO, Action HACOKFPPHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8C4EFD0", Offset = "0x8C4DBD0", VA = "0x188C4EFD0")]
	[IteratorStateMachine(typeof(NKJDACGOGIN))]
	private IEnumerator<LIPOFPKAEIK> IPNDPNEKCCG(Action HACOKFPPHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8C4EF70", Offset = "0x8C4DB70", VA = "0x188C4EF70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8C4F050", Offset = "0x8C4DC50", VA = "0x188C4F050")]
	[CompilerGenerated]
	private void NDALNHLGINI(string OOPJJOBMHKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class PONPNNKAOJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NPKNAFHMCFM : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public NPKNAFHMCFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F4C0", Offset = "0x8C4E0C0", VA = "0x188C4F4C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F580", Offset = "0x8C4E180", VA = "0x188C4F580", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private CCGDPHBOCPE CEDCELKMLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private MonoBehaviour EHAANMPGLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Action BMOMBCIONJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Action<float> GOBHAAPNJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private LDOBNDFEMDB KBHHAOPJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private float OJHNOAFCMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private bool BKOLCHNEJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly IELPNMNGABM MCBAOPMMIDB;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8C51750", Offset = "0x8C50350", VA = "0x188C51750")]
	public PONPNNKAOJM(MonoBehaviour EHAANMPGLOP, Action BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, [Optional] IELPNMNGABM MCBAOPMMIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8C51580", Offset = "0x8C50180", VA = "0x188C51580")]
	public PONPNNKAOJM(MonoBehaviour EHAANMPGLOP, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, [Optional] IELPNMNGABM MCBAOPMMIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8C518E0", Offset = "0x8C504E0", VA = "0x188C518E0")]
	public PONPNNKAOJM(MonoBehaviour EHAANMPGLOP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, bool BKOLCHNEJMI = true, [Optional] IELPNMNGABM MCBAOPMMIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xEA4880", Offset = "0xEA3480", VA = "0x180EA4880")]
	private PONPNNKAOJM(IELPNMNGABM MCBAOPMMIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8C51010", Offset = "0x8C4FC10", VA = "0x188C51010")]
	internal static PONPNNKAOJM JDMMAGNFKCM(MonoBehaviour EHAANMPGLOP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF, LDOBNDFEMDB KBHHAOPJAPO, bool BKOLCHNEJMI = true, [Optional] IELPNMNGABM MCBAOPMMIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8C50E60", Offset = "0x8C4FA60", VA = "0x188C50E60")]
	private void HCCABBDLLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8C50CE0", Offset = "0x8C4F8E0", VA = "0x188C50CE0")]
	private void GFGECLEOIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8C50950", Offset = "0x8C4F550", VA = "0x188C50950")]
	private void AGONGJMIAFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8C513F0", Offset = "0x8C4FFF0", VA = "0x188C513F0")]
	private void OLOIOIPEOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8C50B50", Offset = "0x8C4F750", VA = "0x188C50B50")]
	private void CMJLDOGFMHF(string PDIIGKEPNLO, Action HACOKFPPHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8C50F90", Offset = "0x8C4FB90", VA = "0x188C50F90")]
	[IteratorStateMachine(typeof(NPKNAFHMCFM))]
	private IEnumerator<LIPOFPKAEIK> IPNDPNEKCCG(Action HACOKFPPHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8C50C80", Offset = "0x8C4F880", VA = "0x188C50C80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8C512D0", Offset = "0x8C4FED0", VA = "0x188C512D0")]
	[CompilerGenerated]
	private void ODFKKANNFDL(string OOPJJOBMHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8C51360", Offset = "0x8C4FF60", VA = "0x188C51360")]
	[CompilerGenerated]
	private void OEODIGEECPM(string OOPJJOBMHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8C51240", Offset = "0x8C4FE40", VA = "0x188C51240")]
	[CompilerGenerated]
	private void LFPOMFOEALF(string OOPJJOBMHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8C50AC0", Offset = "0x8C4F6C0", VA = "0x188C50AC0")]
	[CompilerGenerated]
	private void AMHDNOICDFD(string OOPJJOBMHKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
internal enum GFCCKMEFKCI : byte
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
internal sealed class BHJKBCDJMKM : BIBACFPIHOE
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float FCMDJLAJAGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C3FF80", Offset = "0x8C3EB80", VA = "0x188C3FF80", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float PMLKOEGEJKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C40000", Offset = "0x8C3EC00", VA = "0x188C40000", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public double IFAOADEICNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8C40010", Offset = "0x8C3EC10", VA = "0x188C40010", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8C3FF90", Offset = "0x8C3EB90", VA = "0x188C3FF90")]
	[HHMPGEJNNFC.JKDCLEHGFFF]
	internal static void GDCJIDLIJAN(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	[UnityEngine.Scripting.Preserve]
	internal BHJKBCDJMKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface HKJIOMFNCFO
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGFDMENLFFD(string BKILENEPEEB);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHABBOBGNKE();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface EEFIDNKFGFK
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string FEGHCLOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool GCFADFNMKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool JLLIEGGNPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal class HPHMAPKCHCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public DDCEMABBBNI GAGKLOGELMA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int CLIFKJOPCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA5B110", Offset = "0xA59D10", VA = "0x180A5B110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7B0", Offset = "0xA5B3B0", VA = "0x180A5C7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8C495E0", Offset = "0x8C481E0", VA = "0x188C495E0")]
	public static LIPOFPKAEIK KPHOMJEJLPP(IEnumerator<LIPOFPKAEIK> ENKOFPIAJNF, GHPNJGOFEEI AJALPBGHLCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8C49740", Offset = "0x8C48340", VA = "0x188C49740")]
	public LIPOFPKAEIK KPHOMJEJLPP(GHPNJGOFEEI[] KAEMFHAOMNE, IEnumerator<LIPOFPKAEIK>[] KHADKEPCJPG, LIPOFPKAEIK[] HIHDMALDJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8C49470", Offset = "0x8C48070", VA = "0x188C49470")]
	public void DPBOHNMDGDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8C494A0", Offset = "0x8C480A0", VA = "0x188C494A0")]
	public void IAGPHOKPMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8C49800", Offset = "0x8C48400", VA = "0x188C49800")]
	public void LAHDALNNGPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8C49470", Offset = "0x8C48070", VA = "0x188C49470")]
	public void JGECLGLABGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public HPHMAPKCHCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DDCEMABBBNI
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct IELCMBAOKIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public HPHMAPKCHCH DDJIKFHEAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public PAHIIACJDAI NFMCACNMIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public GHPNJGOFEEI EGFHCCJEEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IEnumerator<LIPOFPKAEIK> OEILEDAHDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LIPOFPKAEIK EGNPKNGFAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public GFCCKMEFKCI PMMKCAHDFIN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct JLEFOKNMGKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public LDOBNDFEMDB PMMCEGDDBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public List<IELCMBAOKIG> EFMGMEPHFKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class PEPGBLJJLBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public GHPNJGOFEEI promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public DDCEMABBBNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public PAHIIACJDAI context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public HPHMAPKCHCH routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public GFCCKMEFKCI coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LIPOFPKAEIK currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public IEnumerator<LIPOFPKAEIK> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public PEPGBLJJLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8C50130", Offset = "0x8C4ED30", VA = "0x188C50130")]
		internal void JLDJIDBHPCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class KBMBEJDNKDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public HPHMAPKCHCH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public DDCEMABBBNI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public KBMBEJDNKDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8C4BCD0", Offset = "0x8C4A8D0", VA = "0x188C4BCD0")]
		internal void KGPLBCGMABH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class PHGGGOPIIMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public HPHMAPKCHCH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public DDCEMABBBNI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public PHGGGOPIIMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8C50910", Offset = "0x8C4F510", VA = "0x188C50910")]
		internal void FHDKFEGKJMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MNMCFHIDDNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public HPHMAPKCHCH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public DDCEMABBBNI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public MNMCFHIDDNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F370", Offset = "0x8C4DF70", VA = "0x188C4F370")]
		internal void DAKKEIAABLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const GFCCKMEFKCI PJEIAMLNEHD = GFCCKMEFKCI.Cancelled | GFCCKMEFKCI.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LDOBNDFEMDB KBHHAOPJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool[] KBDCIPPJGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private NativeArray<GFCCKMEFKCI> MAELDIAONJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private NativeArray<float> MDEGEIEDMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private NativeArray<int> CJHAHKADMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeArray<int> DPGPACLPAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<int> JJLGCGEKPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<int> MBDIEBGMFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<int> EIGIINGEOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private HPHMAPKCHCH[] CFAIKEPAGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private GHPNJGOFEEI[] KAEMFHAOMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private PAHIIACJDAI[] COOMPPJCOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private IEnumerator<LIPOFPKAEIK>[] FCLMONBGECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private LIPOFPKAEIK[] JDIHFIPLCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int ONIIMAHHEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int FJNGONEOHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly int FIDAAGJHPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private float DELHGEDOIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private ILPHGEMPFGB JOFIDKOMOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private JobHandle CLBLFAEMEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private List<HPHMAPKCHCH> PFGPEOLCDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool MMEBLHNHFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private List<Action> MJKGLIMBHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private List<Action> BDODCCHCDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool GKIEPENAMNB;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public JLEFOKNMGKL[] HBKCAPIBKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xBB0880", Offset = "0xBAF480", VA = "0x180BB0880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8C42BC0", Offset = "0x8C417C0", VA = "0x188C42BC0")]
	private static int CKIFJIDBKIJ(LDOBNDFEMDB KBHHAOPJAPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8C44820", Offset = "0x8C43420", VA = "0x188C44820")]
	public DDCEMABBBNI(LDOBNDFEMDB KBHHAOPJAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8C44390", Offset = "0x8C42F90", VA = "0x188C44390")]
	private void OAEDCKGPCEJ(int LIIPMHIDDDK, int HMEOHLIMBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8C446A0", Offset = "0x8C432A0", VA = "0x188C446A0")]
	public void OMCBCIGPKID(PAHIIACJDAI PBHLPKLGFAP, LIPOFPKAEIK IMMIBMMFNNH, IEnumerator<LIPOFPKAEIK> ENKOFPIAJNF, GHPNJGOFEEI AJALPBGHLCP, [Optional] HPHMAPKCHCH KFPCMCJJNNN, GFCCKMEFKCI NOGPJEHDKLE = GFCCKMEFKCI.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8C42F80", Offset = "0x8C41B80", VA = "0x188C42F80")]
	public void DLMHFMOANAD(IEnumerable<IELCMBAOKIG> HMGKNEJELFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8C438B0", Offset = "0x8C424B0", VA = "0x188C438B0")]
	private IELCMBAOKIG GIPFLKICPEK(int JOCABBJLCGI)
	{
		return default(IELCMBAOKIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8C43540", Offset = "0x8C42140", VA = "0x188C43540")]
	private void GFAKIPDFNJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3A88C40", Offset = "0x3A87840", VA = "0x183A88C40")]
	private static void LEIJMPHIBBE<T>(int JOCABBJLCGI, T[] HJOPHPMADPD, int PFHGPMHBODB, [Optional] T NCPECNNOKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3A88C90", Offset = "0x3A87890", VA = "0x183A88C90")]
	private static void LEIJMPHIBBE<T>(int JOCABBJLCGI, NativeArray<T> HJOPHPMADPD, int PFHGPMHBODB, [Optional] T NCPECNNOKGG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8C42BF0", Offset = "0x8C417F0", VA = "0x188C42BF0")]
	private void DDCGCHHDGBL(IEnumerable<IELCMBAOKIG> HMGKNEJELFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8C442C0", Offset = "0x8C42EC0", VA = "0x188C442C0")]
	private void MGGABFJPPIA(IELCMBAOKIG FMCAMHBIPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8C44060", Offset = "0x8C42C60", VA = "0x188C44060")]
	private MMKCCECJEEC KMEIOOOLJOD(int CBLGNLHDGPL)
	{
		return default(MMKCCECJEEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8C431C0", Offset = "0x8C41DC0", VA = "0x188C431C0")]
	public void EBOMOMHKINE(float KBAPJIBEOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8C43FE0", Offset = "0x8C42BE0", VA = "0x188C43FE0")]
	private void JIKPOELKBGO(Action JPILOOHOBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8C434C0", Offset = "0x8C420C0", VA = "0x188C434C0")]
	private void GAOOPJBPDNK(Action JPILOOHOBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8C424A0", Offset = "0x8C410A0", VA = "0x188C424A0")]
	public void ACHGGPDLEJC(float KBAPJIBEOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8C433C0", Offset = "0x8C41FC0", VA = "0x188C433C0")]
	public void EDJAHJBIEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8C43EB0", Offset = "0x8C42AB0", VA = "0x188C43EB0")]
	public void JGECLGLABGG(HPHMAPKCHCH KPKFLDBFHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8C43D80", Offset = "0x8C42980", VA = "0x188C43D80")]
	public void JCFIDBBIPMM(HPHMAPKCHCH KPKFLDBFHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8C44570", Offset = "0x8C43170", VA = "0x188C44570")]
	public void OGMCPGKPIIL(HPHMAPKCHCH KPKFLDBFHBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DOLOAFEBJCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public static readonly DOLOAFEBJCA LNCBONNLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Action HGEHGHPLMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool KBLIMDOOPKN;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public DOLOAFEBJCA(Action HGEHGHPLMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x8268350", Offset = "0x8266F50", VA = "0x188268350", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface BNFGAAAHPHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HOIONIFFPMJ(UnityEngine.Object PBHLPKLGFAP, Action<T> POHJDOFECEK);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface KDPKPDODBIO<T> : BNFGAAAHPHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	new T AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KDKAECDKNND<T> : KDPKPDODBIO<T>, BNFGAAAHPHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ACJPGBIJMHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public KDKAECDKNND<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public OIJCPJFMFHD<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public ACJPGBIJMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x508F950", Offset = "0x508E550", VA = "0x18508F950")]
		internal void KIBMAEADAIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static GameObject AFCKLKGBIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<OIJCPJFMFHD<UnityEngine.Object, Action<T>>> IGILAOODKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private T OJLNBKLGDDK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAB4C80", Offset = "0xAB3880", VA = "0x180AB4C80", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x53AD710", Offset = "0x53AC310", VA = "0x1853AD710", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x53ACCA0", Offset = "0x53AB8A0", VA = "0x1853ACCA0")]
	private static bool BEEKMABAPGC(T JPILOOHOBDJ, T MAKDDCFIOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x53AD830", Offset = "0x53AC430", VA = "0x1853AD830")]
	public KDKAECDKNND(T KNEHBEIIHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x53AD390", Offset = "0x53ABF90", VA = "0x1853AD390", Slot = "6")]
	public IDisposable HOIONIFFPMJ(UnityEngine.Object PBHLPKLGFAP, Action<T> POHJDOFECEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x53ACD90", Offset = "0x53AB990", VA = "0x1853ACD90")]
	private void DHEEDLADHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class MDBMJHOLNJO : PACCLKJAGAG
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class CFPADFJBFGB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class AEGLKMCMGGP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int OIBGADINDDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private CFPADFJBFGB OCCBFNHIGDM;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xFFD970", Offset = "0xFFC570", VA = "0x180FFD970")]
			public AEGLKMCMGGP(int OIBGADINDDP, CFPADFJBFGB OCCBFNHIGDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x8C3FAC0", Offset = "0x8C3E6C0", VA = "0x188C3FAC0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class PPHJNLGKICB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public PPHJNLGKICB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xB313E0", Offset = "0xB2FFE0", VA = "0x180B313E0")]
			internal bool NCLHFLMAHLM(ONJHKCHDMHM e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class DGALDLMGFGI : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private LIPOFPKAEIK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public CFPADFJBFGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public BIBACFPIHOE timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private ALNJOFCJPDF <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private List<ONJHKCHDMHM> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public DGALDLMGFGI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x8C44E80", Offset = "0x8C43A80", VA = "0x188C44E80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8C45180", Offset = "0x8C43D80", VA = "0x188C45180", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly LDOBNDFEMDB KBHHAOPJAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private CCGDPHBOCPE AJALPBGHLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly List<ONJHKCHDMHM> JMHKPAOIEHE;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8C40480", Offset = "0x8C3F080", VA = "0x188C40480")]
		public CFPADFJBFGB(LDOBNDFEMDB KBHHAOPJAPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8C400C0", Offset = "0x8C3ECC0", VA = "0x188C400C0")]
		public IDisposable DMBPILDFFAJ(ONJHKCHDMHM KMCOOGGBIFL, IELPNMNGABM MCBAOPMMIDB, BIBACFPIHOE LFPPCCOIMLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8C402F0", Offset = "0x8C3EEF0", VA = "0x188C402F0")]
		private void FLDMKCJMOPP(int OIBGADINDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8C40030", Offset = "0x8C3EC30", VA = "0x188C40030")]
		[IteratorStateMachine(typeof(DGALDLMGFGI))]
		private IEnumerator<LIPOFPKAEIK> BMDKELKODBO(BIBACFPIHOE LFPPCCOIMLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8C402A0", Offset = "0x8C3EEA0", VA = "0x188C402A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class ONJHKCHDMHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public enum LEHPOIBBGLG : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static int LFJFLMBLCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int CKHNJNJFACM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly HKJBNPOGLFP NFMCACNMIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly MonoBehaviour HAMHALDCKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly Action MONBEGLCAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly Action<float> EIMJCHAHNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly float BOLIBGAIHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public float MDEGEIEDMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly string FEGHCLOCPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly bool PBBDGFHPPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly LEHPOIBBGLG DJELNBKAGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool BCDIBIEFHFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public bool DCONJPCMMDD;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FFB0", Offset = "0x8C4EBB0", VA = "0x188C4FFB0")]
		public ONJHKCHDMHM(HKJBNPOGLFP PBHLPKLGFAP, Action BMOMBCIONJF, bool FNDHNCJEOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FC50", Offset = "0x8C4E850", VA = "0x188C4FC50")]
		public ONJHKCHDMHM(HKJBNPOGLFP PBHLPKLGFAP, Action<float> BMOMBCIONJF, bool FNDHNCJEOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FDD0", Offset = "0x8C4E9D0", VA = "0x188C4FDD0")]
		public ONJHKCHDMHM(HKJBNPOGLFP PBHLPKLGFAP, float GBBKLOIIKLG, Action<float> BMOMBCIONJF, BIBACFPIHOE LFPPCCOIMLK, LEHPOIBBGLG ICAACCOFKOM, bool BKOLCHNEJMI, bool FNDHNCJEOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FA00", Offset = "0x8C4E600", VA = "0x188C4FA00")]
		public bool NJLKKELMFFK(float HCMFNJGJPMC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly IELPNMNGABM MCBAOPMMIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly BIBACFPIHOE NABBPKPKDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<LDOBNDFEMDB, CFPADFJBFGB> EGOGMAMBLPL;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E4C0", Offset = "0x8C4D0C0", VA = "0x188C4E4C0")]
	[HHMPGEJNNFC.JKDCLEHGFFF]
	internal static void HAMAANGPMHH(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4EC10", Offset = "0x8C4D810", VA = "0x188C4EC10")]
	[UnityEngine.Scripting.Preserve]
	internal MDBMJHOLNJO([HAKCNCGPHPD(null)] IELPNMNGABM MCBAOPMMIDB, [HAKCNCGPHPD(null)] BIBACFPIHOE NABBPKPKDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4EA20", Offset = "0x8C4D620", VA = "0x188C4EA20", Slot = "4")]
	public IDisposable MONBEGLCAAD(HKJBNPOGLFP PBHLPKLGFAP, Action HFBNHPDLHHL, LDOBNDFEMDB KBHHAOPJAPO, bool FNDHNCJEOCC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E830", Offset = "0x8C4D430", VA = "0x188C4E830", Slot = "5")]
	public IDisposable MONBEGLCAAD(HKJBNPOGLFP PBHLPKLGFAP, Action<float> HFBNHPDLHHL, LDOBNDFEMDB KBHHAOPJAPO, bool FNDHNCJEOCC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E240", Offset = "0x8C4CE40", VA = "0x188C4E240", Slot = "7")]
	public IDisposable FLBFHGPMMHP(HKJBNPOGLFP PBHLPKLGFAP, float GBBKLOIIKLG, Action<float> HFBNHPDLHHL, LDOBNDFEMDB KBHHAOPJAPO, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E140", Offset = "0x8C4CD40", VA = "0x188C4E140", Slot = "8")]
	public IDisposable BPIDJIKNENN(HKJBNPOGLFP PBHLPKLGFAP, float GBBKLOIIKLG, Action<float> HFBNHPDLHHL, LDOBNDFEMDB KBHHAOPJAPO, bool BKOLCHNEJMI = true, bool FNDHNCJEOCC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E340", Offset = "0x8C4CF40", VA = "0x188C4E340", Slot = "6")]
	public IDisposable FLBFHGPMMHP(float GBBKLOIIKLG, Action<float> HFBNHPDLHHL, bool BKOLCHNEJMI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E530", Offset = "0x8C4D130", VA = "0x188C4E530", Slot = "9")]
	public void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E6F0", Offset = "0x8C4D2F0", VA = "0x188C4E6F0")]
	private CFPADFJBFGB IIDJGDLJAAH(LDOBNDFEMDB KBHHAOPJAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GKPIKJFEANN : IOLIOGKCOMP, IELPNMNGABM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private DDCEMABBBNI[] EBIODOADLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private HKJIOMFNCFO ONOMIKFBDIN;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8C46F20", Offset = "0x8C45B20", VA = "0x188C46F20")]
	[HHMPGEJNNFC.JKDCLEHGFFF]
	internal static void GDCJIDLIJAN(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8C47420", Offset = "0x8C46020", VA = "0x188C47420")]
	[UnityEngine.Scripting.Preserve]
	public GKPIKJFEANN([HAKCNCGPHPD(null)] INAGHGGJIIP EPOBHLEDPCP, [HAKCNCGPHPD(null)] BIBACFPIHOE NABBPKPKDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8C46D00", Offset = "0x8C45900", VA = "0x188C46D00", Slot = "19")]
	public override CCGDPHBOCPE ECCDIIOAHGO(PAHIIACJDAI PBHLPKLGFAP, IEnumerator<LIPOFPKAEIK> CGJMFNDKFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8C46F90", Offset = "0x8C45B90", VA = "0x188C46F90", Slot = "20")]
	public override void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8C46840", Offset = "0x8C45440", VA = "0x188C46840", Slot = "22")]
	public override void AODECPFHFJH(LDOBNDFEMDB KBHHAOPJAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8C47350", Offset = "0x8C45F50", VA = "0x188C47350", Slot = "21")]
	protected override void MONBEGLCAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8C46E30", Offset = "0x8C45A30", VA = "0x188C46E30")]
	private DDCEMABBBNI EJPIPOEGNEC(LDOBNDFEMDB MDCDODCGNEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8C46A70", Offset = "0x8C45670", VA = "0x188C46A70", Slot = "23")]
	internal override LMFBFBBDHAA CLHMFOPFALC(IEnumerator<LIPOFPKAEIK> CGJMFNDKFPB, Behaviour PBHLPKLGFAP, GHPNJGOFEEI AJALPBGHLCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8C46E60", Offset = "0x8C45A60", VA = "0x188C46E60", Slot = "24")]
	internal override HPBENNFEGMA GAIJCPIPHMB(LDOBNDFEMDB OCCBFNHIGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8C47230", Offset = "0x8C45E30", VA = "0x188C47230")]
	private void KFIKJPNCKKG(DDCEMABBBNI CLALEMGHDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8C46CA0", Offset = "0x8C458A0", VA = "0x188C46CA0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[BurstCompile]
internal struct ILPHGEMPFGB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[ReadOnly]
	public float KALEBDJCKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[ReadOnly]
	public int OIDLKKGOJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> IEIOHFKEMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeArray<int> MBMCHKJHLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<int> CJDDDNOFCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	public NativeArray<GFCCKMEFKCI> KKPICCFENIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	public NativeArray<float> HGEAAJNBJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[WriteOnly]
	public NativeArray<int> JJLGCGEKPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[WriteOnly]
	public NativeArray<int> CJHAHKADMJG;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8C49B90", Offset = "0x8C48790", VA = "0x188C49B90")]
	public static ILPHGEMPFGB FOGKIHKKOLG(int CPJADBHKIOO, float KBAPJIBEOOI, NativeArray<GFCCKMEFKCI> MPCNCLAOIEC, NativeArray<float> HBMPJPBLDEK, NativeArray<int> KMBJJCFMGHC, NativeArray<int> MOEDIGNIMNA, NativeArray<int> NHGDHHKEGGG, NativeArray<int> MBMCHKJHLGG, NativeArray<int> CJDDDNOFCEP)
	{
		return default(ILPHGEMPFGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8C49AB0", Offset = "0x8C486B0", VA = "0x188C49AB0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8C49BF0", Offset = "0x8C487F0", VA = "0x188C49BF0")]
	private bool IBHALHOEHOF(int LCCBBMBENOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8C49E70", Offset = "0x8C48A70", VA = "0x188C49E70")]
	private void OMPAAKFCDPO(NativeArray<int> JPLCDDPKPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8C49940", Offset = "0x8C48540", VA = "0x188C49940")]
	private int DJKCCBJBMNN(int GLNEMNAEDGJ, int LCELGOLLNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8C499E0", Offset = "0x8C485E0", VA = "0x188C499E0")]
	private void DMEFLOCBLGP(NativeArray<int> JPLCDDPKPCC, int DMFPDJGCMEK, int KFNDMAAELJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8C49C30", Offset = "0x8C48830", VA = "0x188C49C30")]
	private void MAGANHLMCOC(NativeArray<int> JPLCDDPKPCC, int HHGBPGBCCKL, int BBMKLKEDJME, int EKPBIOKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class IOLIOGKCOMP : IELPNMNGABM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly INAGHGGJIIP EPOBHLEDPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	protected readonly BIBACFPIHOE NABBPKPKDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private HPBENNFEGMA[] FNMMDEFBPNE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static IELPNMNGABM MFAGMJBMEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8C4AA00", Offset = "0x8C49600", VA = "0x188C4AA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool MIILNIMFKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public LDOBNDFEMDB HLGIFCBENPL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B110", Offset = "0xA59D10", VA = "0x180A5B110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LDOBNDFEMDB);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7B0", Offset = "0xA5B3B0", VA = "0x180A5C7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public BIBACFPIHOE EPLIBMDEOFK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LIPOFPKAEIK BOCGCELGDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LIPOFPKAEIK BEDAHHOFLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public LIPOFPKAEIK MDCKBPCGJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public LIPOFPKAEIK EEKLOLOGMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA5B670", Offset = "0xA5A270", VA = "0x180A5B670", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4A970", Offset = "0x8C49570", VA = "0x188C4A970")]
	public static CCGDPHBOCPE IFNJCHACPPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4AE00", Offset = "0x8C49A00", VA = "0x188C4AE00")]
	[UnityEngine.Scripting.Preserve]
	protected IOLIOGKCOMP([HAKCNCGPHPD(null)] INAGHGGJIIP EPOBHLEDPCP, [HAKCNCGPHPD(null)] BIBACFPIHOE NABBPKPKDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4A140", Offset = "0x8C48D40", VA = "0x188C4A140", Slot = "6")]
	public CCGDPHBOCPE BHLCFPFLIIK(IEnumerator<LIPOFPKAEIK> CGJMFNDKFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8C4A150", Offset = "0x8C48D50", VA = "0x188C4A150", Slot = "7")]
	public CCGDPHBOCPE BHLCFPFLIIK(Behaviour PBHLPKLGFAP, IEnumerator<LIPOFPKAEIK> CGJMFNDKFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract CCGDPHBOCPE ECCDIIOAHGO(PAHIIACJDAI PBHLPKLGFAP, IEnumerator<LIPOFPKAEIK> CGJMFNDKFPB);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8C4A7D0", Offset = "0x8C493D0", VA = "0x188C4A7D0", Slot = "20")]
	public virtual void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8C4ABC0", Offset = "0x8C497C0", VA = "0x188C4ABC0", Slot = "9")]
	public void PLAGBKHNEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8C4AB80", Offset = "0x8C49780", VA = "0x188C4AB80", Slot = "21")]
	protected virtual void MONBEGLCAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8C4A350", Offset = "0x8C48F50", VA = "0x188C4A350")]
	private void BMCEAAFKEEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8C4A750", Offset = "0x8C49350", VA = "0x188C4A750")]
	private void GOHNPFMMIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8C4A730", Offset = "0x8C49330", VA = "0x188C4A730")]
	private void GMFICEIIMIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8C4AA70", Offset = "0x8C49670", VA = "0x188C4AA70")]
	private void JADAKHFPIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8C4ABA0", Offset = "0x8C497A0", VA = "0x188C4ABA0")]
	private void PDMOHGCDPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4A120", Offset = "0x8C48D20", VA = "0x188C4A120")]
	private void BCDFMLPOKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8C49EA0", Offset = "0x8C48AA0", VA = "0x188C49EA0")]
	private void AHCHIFDLCFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x8C49EC0", Offset = "0x8C48AC0", VA = "0x188C49EC0", Slot = "22")]
	public virtual void AODECPFHFJH(LDOBNDFEMDB KBHHAOPJAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8C49F50", Offset = "0x8C48B50", VA = "0x188C49F50")]
	private void APNCHPLMFHP(HPBENNFEGMA CLALEMGHDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x28DB1D0", Offset = "0x28D9DD0", VA = "0x1828DB1D0")]
	private HPBENNFEGMA OKMHEGDLPJB(LDOBNDFEMDB MDCDODCGNEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract LMFBFBBDHAA CLHMFOPFALC(IEnumerator<LIPOFPKAEIK> CGJMFNDKFPB, Behaviour EHAANMPGLOP, GHPNJGOFEEI MHIHOHDIDPO);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract HPBENNFEGMA GAIJCPIPHMB(LDOBNDFEMDB KBHHAOPJAPO);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x8C4A370", Offset = "0x8C48F70", VA = "0x188C4A370", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8C4AB20", Offset = "0x8C49720", VA = "0x188C4AB20", Slot = "15")]
	public LIPOFPKAEIK JLPBMOFKALC(LDOBNDFEMDB OCCBFNHIGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8C4AA90", Offset = "0x8C49690", VA = "0x188C4AA90", Slot = "16")]
	public LIPOFPKAEIK JKDFAFCDMBM(float DJMONOPAJCJ, LDOBNDFEMDB OCCBFNHIGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8C4A770", Offset = "0x8C49370", VA = "0x188C4A770", Slot = "17")]
	public LIPOFPKAEIK HLBOGLMNJBK(Func<bool> MBDNDPHCDDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class LMFBFBBDHAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly GHPNJGOFEEI AJALPBGHLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly EEFIDNKFGFK PBHLPKLGFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly bool HJCLCNJFGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private string BKILENEPEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private StackTrace ACMDAHGAHLA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerator<LIPOFPKAEIK> OEILEDAHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LIPOFPKAEIK EGNPKNGFAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MDLFLMKPJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CBB0", Offset = "0x8C4B7B0", VA = "0x188C4CBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool JODPPPIIEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xD297D0", Offset = "0xD283D0", VA = "0x180D297D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xD5E830", Offset = "0xD5D430", VA = "0x180D5E830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string FEGHCLOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D010", Offset = "0x8C4BC10", VA = "0x188C4D010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float JBCIILHHCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xEB4910", Offset = "0xEB3510", VA = "0x180EB4910")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xEB4920", Offset = "0xEB3520", VA = "0x180EB4920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8C4D2A0", Offset = "0x8C4BEA0", VA = "0x188C4D2A0")]
	public LMFBFBBDHAA(IEnumerator<LIPOFPKAEIK> ENKOFPIAJNF, EEFIDNKFGFK PBHLPKLGFAP, GHPNJGOFEEI AJALPBGHLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8C4CC80", Offset = "0x8C4B880", VA = "0x188C4CC80")]
	public LIPOFPKAEIK KPHOMJEJLPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8C4CFA0", Offset = "0x8C4BBA0", VA = "0x188C4CFA0")]
	public bool NCGLCBCIIDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8C4CC30", Offset = "0x8C4B830", VA = "0x188C4CC30")]
	public void JGECLGLABGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8C4D1C0", Offset = "0x8C4BDC0", VA = "0x188C4D1C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0xDBCE40", Offset = "0xDBBA40", VA = "0x180DBCE40")]
	[CompilerGenerated]
	private void FJHIHFCGMJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class GHPNJGOFEEI : EICDEAMHLEB, CCGDPHBOCPE, BNKNLGMMDLE, IPNMFPLCPOG, IEnumerator, LIPOFPKAEIK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private LDOBNDFEMDB OGKBPFKDKGM;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private LDOBNDFEMDB KAIJBCMCEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xB0C800", Offset = "0xB0B400", VA = "0x180B0C800", Slot = "23")]
		get
		{
			return default(LDOBNDFEMDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public LDOBNDFEMDB GAGKLOGELMA
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1024D50", Offset = "0x1023950", VA = "0x181024D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private float MOILNOFPOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xAADAE0", Offset = "0xAAC6E0", VA = "0x180AADAE0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool JPFFGBLMAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8C467D0", Offset = "0x8C453D0", VA = "0x188C467D0", Slot = "24")]
	private bool HICBFLPIGNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8C467C0", Offset = "0x8C453C0", VA = "0x188C467C0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8C467F0", Offset = "0x8C453F0", VA = "0x188C467F0")]
	public GHPNJGOFEEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal enum MMKCCECJEEC : byte
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
internal sealed class HPBENNFEGMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum ABJMDKJMOGE
	{
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct DJJEGDBEALJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public LDOBNDFEMDB PMMCEGDDBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public ABJMDKJMOGE EHAAHAGFOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public List<LMFBFBBDHAA> PCAKOACBDIN;
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly ABJMDKJMOGE[] AALKKMGDCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly LDOBNDFEMDB KBHHAOPJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool EPOLHHDELIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly LMFBFBBDHAA[] AKMHFJBONEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly List<LMFBFBBDHAA> IJLDEMNCKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Stack<int> NEKHANCODMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly List<LMFBFBBDHAA> NCIHAOFJLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly Stack<int> KIHKDLEIKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly HKJIOMFNCFO HKGHPBOLLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool GKIEPENAMNB;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DJJEGDBEALJ[,] AEILKDKCCOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8C48FC0", Offset = "0x8C47BC0", VA = "0x188C48FC0")]
	public HPBENNFEGMA(LDOBNDFEMDB OCCBFNHIGDM, HKJIOMFNCFO HKGHPBOLLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8C47FA0", Offset = "0x8C46BA0", VA = "0x188C47FA0")]
	public void EFEBFLLKEBF(LMFBFBBDHAA ENKOFPIAJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8C47B80", Offset = "0x8C46780", VA = "0x188C47B80")]
	public void CBAOMIEAAKP(IList<LMFBFBBDHAA> KHADKEPCJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8C48990", Offset = "0x8C47590", VA = "0x188C48990")]
	public void PJNNIGJLGGI(IList<LMFBFBBDHAA> KHADKEPCJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8C48840", Offset = "0x8C47440", VA = "0x188C48840")]
	private void PBJNMFFANAE(LMFBFBBDHAA ENKOFPIAJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8C479F0", Offset = "0x8C465F0", VA = "0x188C479F0")]
	private void BNOAAOGBKJB(IList<LMFBFBBDHAA> KHADKEPCJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8C486C0", Offset = "0x8C472C0", VA = "0x188C486C0")]
	private MMKCCECJEEC ODGMHCLAJAJ(LMFBFBBDHAA ENKOFPIAJNF)
	{
		return default(MMKCCECJEEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8C48550", Offset = "0x8C47150", VA = "0x188C48550")]
	public void MONBEGLCAAD(float KBAPJIBEOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8C48C90", Offset = "0x8C47890", VA = "0x188C48C90")]
	public void PLAGBKHNEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8C480B0", Offset = "0x8C46CB0", VA = "0x188C480B0")]
	private void GAAMAINDOIB(List<LMFBFBBDHAA> KHADKEPCJPG, Stack<int> IBHCPDBHICN, bool MIJNINPGIIB, float CFEEOHKCNOO = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x8C47E80", Offset = "0x8C46A80", VA = "0x188C47E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x8C48410", Offset = "0x8C47010", VA = "0x188C48410")]
	private void HFAGEOHNCMP(List<LMFBFBBDHAA> KHADKEPCJPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class MPPJDAIDFNH : HKJIOMFNCFO
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public void EGFDMENLFFD(string BKILENEPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
	public void BHABBOBGNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MPPJDAIDFNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal class ONCJLBDKMEJ : EEFIDNKFGFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Behaviour EHAANMPGLOP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string FEGHCLOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F980", Offset = "0x8C4E580", VA = "0x188C4F980", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool GCFADFNMKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F930", Offset = "0x8C4E530", VA = "0x188C4F930", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JLLIEGGNPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F910", Offset = "0x8C4E510", VA = "0x188C4F910", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public ONCJLBDKMEJ(Behaviour EHAANMPGLOP)
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

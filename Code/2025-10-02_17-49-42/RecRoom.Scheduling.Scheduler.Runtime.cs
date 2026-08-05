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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9063D30", Offset = "0x9062730", VA = "0x189063D30", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9068D20", Offset = "0x9067720", VA = "0x189068D20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
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
		private struct FFDJBALCIDE
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			[CompilerGenerated]
			private sealed class KOHCOJCGBKD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public DPOHPEFHNIN.LGBJKEKKAGJ key;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
				public KOHCOJCGBKD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x90609B0", Offset = "0x905F3B0", VA = "0x1890609B0")]
				internal void AAGPIPOCJHP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000002")]
			public static IDisposable JPDHPHCOINE;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x905D1F0", Offset = "0x905BBF0", VA = "0x18905D1F0")]
			public static PlayerLoopSystem EEEDALOHJIF(DPOHPEFHNIN.LGBJKEKKAGJ HPFHOBCPNEF)
			{
				return default(PlayerLoopSystem);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct MCAMPFMHFKF
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class NGDGKBOFPAC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public DPOHPEFHNIN.LGBJKEKKAGJ key;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
				public NGDGKBOFPAC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x90682C0", Offset = "0x9066CC0", VA = "0x1890682C0")]
				internal void AAGPIPOCJHP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9064380", Offset = "0x9062D80", VA = "0x189064380")]
			public static PlayerLoopSystem EEEDALOHJIF(DPOHPEFHNIN.LGBJKEKKAGJ HPFHOBCPNEF)
			{
				return default(PlayerLoopSystem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly OLFEOKKCIEG JHGFKLHHPJD;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9059240", Offset = "0x9057C40", VA = "0x189059240")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9059720", Offset = "0x9058120", VA = "0x189059720")]
		private static void IBFOJICNLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x90598D0", Offset = "0x90582D0", VA = "0x1890598D0")]
		private static void KMELHOMPDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x90592C0", Offset = "0x9057CC0", VA = "0x1890592C0")]
		private static void BFLJCFMDLKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9059AA0", Offset = "0x90584A0", VA = "0x189059AA0")]
		private static void OBAKJDCEHNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3BCABE0", Offset = "0x3BC95E0", VA = "0x183BCABE0")]
		private static (PlayerLoopSystem, GDDLCGKLDMF.HBDBNKELIGE) OGBKPOJEFBN<T>()
		{
			return default((PlayerLoopSystem, GDDLCGKLDMF.HBDBNKELIGE));
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x905A620", Offset = "0x9059020", VA = "0x18905A620")]
		private static (PlayerLoopSystem, GDDLCGKLDMF.HBDBNKELIGE) OGBKPOJEFBN(PlayerLoopSystem ALPKFACCKIH)
		{
			return default((PlayerLoopSystem, GDDLCGKLDMF.HBDBNKELIGE));
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3BCA8E0", Offset = "0x3BC92E0", VA = "0x183BCA8E0")]
		private static (PlayerLoopSystem, GDDLCGKLDMF.HBDBNKELIGE) MCKODPOBNPM<T>()
		{
			return default((PlayerLoopSystem, GDDLCGKLDMF.HBDBNKELIGE));
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3BC9060", Offset = "0x3BC7A60", VA = "0x183BC9060")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) JKEBKFPDDCP<TParent, TSub>(DPOHPEFHNIN.LGBJKEKKAGJ HPFHOBCPNEF)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9059770", Offset = "0x9058170", VA = "0x189059770")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) JKEBKFPDDCP(DPOHPEFHNIN.LGBJKEKKAGJ HPFHOBCPNEF, Type AEMEEJKFKNN, Type GDLKOJJJMAL)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DPOHPEFHNIN
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum LGBJKEKKAGJ
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
	public class EEBCPDNDICM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly LGBJKEKKAGJ LEFHGLNABFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly CLAMFLBPKCJ HGNAMGJBFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long CHDJDIDFAJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long IHAMPKJOLIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long MJJDKPAMNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int NBGLDLOODHO;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x905B820", Offset = "0x905A220", VA = "0x18905B820")]
		public EEBCPDNDICM(LGBJKEKKAGJ EAJJCEMGKDK, int KEDDEALNKLA = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x905B800", Offset = "0x905A200", VA = "0x18905B800")]
		public void GICMGFPONKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x905B7B0", Offset = "0x905A1B0", VA = "0x18905B7B0")]
		public void CFNBDICDGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x905B6D0", Offset = "0x905A0D0", VA = "0x18905B6D0")]
		public void ADGGOCJBOAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static LGBJKEKKAGJ[] IPAPLAFFLPD;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static EEBCPDNDICM[] FLEAJPHHIBO;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x905A870", Offset = "0x9059270", VA = "0x18905A870")]
	public static EEBCPDNDICM NIKOBOEEBID(LGBJKEKKAGJ HPFHOBCPNEF, int KEDDEALNKLA = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x905A750", Offset = "0x9059150", VA = "0x18905A750")]
	public static EEBCPDNDICM DLNEGNNOPPO(LGBJKEKKAGJ HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x905A7C0", Offset = "0x90591C0", VA = "0x18905A7C0")]
	public static void GDHILHCALHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FCDICIECDBP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface LKGPAJEDLIA
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool NLIKCFJMIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IBGIFICHJPC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class CLFFJAIFFEM : LKGPAJEDLIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Action FCCCPABHDPG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool NLIKCFJMIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
		public CLFFJAIFFEM(Action FCCCPABHDPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1366E70", Offset = "0x1365870", VA = "0x181366E70", Slot = "5")]
		public void IBGIFICHJPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<LKGPAJEDLIA> CKLDOEHELNH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool PFDMKOJACHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x905D0C0", Offset = "0x905BAC0", VA = "0x18905D0C0")]
	public static void PJAJLKPHNDE(Action FCCCPABHDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x905C8E0", Offset = "0x905B2E0", VA = "0x18905C8E0")]
	private static void GMCHHDPLIHN(LKGPAJEDLIA AOENOLNCHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x905CDC0", Offset = "0x905B7C0", VA = "0x18905CDC0")]
	private static void KEHFKNEJENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x905CB50", Offset = "0x905B550", VA = "0x18905CB50")]
	private static void IOGNGMDEOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x905CCA0", Offset = "0x905B6A0", VA = "0x18905CCA0")]
	private static void JEHLJGFKCKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OOJHICHHGFB
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x9068580", Offset = "0x9066F80", VA = "0x189068580")]
	public static IDisposable HODIAPABDPN(this MPNBHGLOEOL IJNPIDPIBFP, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9068610", Offset = "0x9067010", VA = "0x189068610")]
	public static IDisposable JMBLMKNJKFG(this MPNBHGLOEOL IJNPIDPIBFP, Action<float> GPNMHAKDLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9068690", Offset = "0x9067090", VA = "0x189068690")]
	public static IDisposable MEPOADJIMGN(this MPNBHGLOEOL IJNPIDPIBFP, Action<float> GPNMHAKDLKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MHJPNAIEDHC
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D910", Offset = "0x3E9C310", VA = "0x183E9D910")]
	[DGNAIFJHMLA]
	public static IDisposable ICLBDIALJKI<T>(this T JMEDJALIAEG, Action GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DAB0", Offset = "0x3E9C4B0", VA = "0x183E9DAB0")]
	[DGNAIFJHMLA]
	public static IDisposable ICLBDIALJKI<T>(this T JMEDJALIAEG, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D7A0", Offset = "0x3E9C1A0", VA = "0x183E9D7A0")]
	[DGNAIFJHMLA]
	public static IDisposable DBIPLKHEHMB<T>(this T JMEDJALIAEG, Action GPNMHAKDLKK, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DF60", Offset = "0x3E9C960", VA = "0x183E9DF60")]
	[DGNAIFJHMLA]
	public static IDisposable LMEMHNNCCMB<T>(this T JMEDJALIAEG, Action GPNMHAKDLKK, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DF60", Offset = "0x3E9C960", VA = "0x183E9DF60")]
	[DGNAIFJHMLA]
	public static IDisposable LMEMHNNCCMB<T>(this T JMEDJALIAEG, Action<float> GPNMHAKDLKK, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DD10", Offset = "0x3E9C710", VA = "0x183E9DD10")]
	[DGNAIFJHMLA]
	public static IDisposable LHFLAJOPPNJ<T>(this T JMEDJALIAEG, Action GPNMHAKDLKK, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DCE0", Offset = "0x3E9C6E0", VA = "0x183E9DCE0")]
	[DGNAIFJHMLA]
	public static IDisposable LEGFEJBNFNH<T>(this T JMEDJALIAEG, Action GPNMHAKDLKK, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DD80", Offset = "0x3E9C780", VA = "0x183E9DD80")]
	[DGNAIFJHMLA]
	public static IDisposable LJKKHONFIGN<T>(this T JMEDJALIAEG, Action GPNMHAKDLKK, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DD40", Offset = "0x3E9C740", VA = "0x183E9DD40")]
	[DGNAIFJHMLA]
	public static IDisposable LJEPACBAPCJ<T>(this T JMEDJALIAEG, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9064700", Offset = "0x9063100", VA = "0x189064700")]
	[DGNAIFJHMLA]
	public static IDisposable LJEPACBAPCJ(this MonoBehaviour JMEDJALIAEG, GBAIPNMDKIG IJNPIDPIBFP, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DDB0", Offset = "0x3E9C7B0", VA = "0x183E9DDB0")]
	[DGNAIFJHMLA]
	public static IDisposable LKPGAHNIJFE<T>(this T JMEDJALIAEG, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D890", Offset = "0x3E9C290", VA = "0x183E9D890")]
	[DGNAIFJHMLA]
	public static IDisposable GAONPEEHMED<T>(this T JMEDJALIAEG, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D8D0", Offset = "0x3E9C2D0", VA = "0x183E9D8D0")]
	[DGNAIFJHMLA]
	public static IDisposable HCBAIBPCEOL<T>(this T JMEDJALIAEG, Action<float> GPNMHAKDLKK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DCA0", Offset = "0x3E9C6A0", VA = "0x183E9DCA0")]
	[DGNAIFJHMLA]
	public static IDisposable KDIKEDNEFGI<T>(this T JMEDJALIAEG, Action<float> GPNMHAKDLKK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D760", Offset = "0x3E9C160", VA = "0x183E9D760")]
	[DGNAIFJHMLA]
	public static IDisposable CLFDMMNAHNM<T>(this T JMEDJALIAEG, Action<float> GPNMHAKDLKK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D7D0", Offset = "0x3E9C1D0", VA = "0x183E9D7D0")]
	[DGNAIFJHMLA]
	public static IDisposable DLGCIKIEEHN<T>(this T JMEDJALIAEG, Action<float> GPNMHAKDLKK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DFD0", Offset = "0x3E9C9D0", VA = "0x183E9DFD0")]
	[DGNAIFJHMLA]
	public static IDisposable PCPKMACMIEF<T>(this T JMEDJALIAEG, Action<float> GPNMHAKDLKK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DC60", Offset = "0x3E9C660", VA = "0x183E9DC60")]
	[DGNAIFJHMLA]
	public static IDisposable IIDBKIGBCKD<T>(this T JMEDJALIAEG, Action<float> GPNMHAKDLKK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DF90", Offset = "0x3E9C990", VA = "0x183E9DF90")]
	[DGNAIFJHMLA]
	public static IDisposable LOLEFPLCPEM<T>(this T JMEDJALIAEG, Action<float> GPNMHAKDLKK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D810", Offset = "0x3E9C210", VA = "0x183E9D810")]
	[DGNAIFJHMLA]
	public static IDisposable EIAHJIIFPCL<T>(this T JMEDJALIAEG, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D850", Offset = "0x3E9C250", VA = "0x183E9D850")]
	[DGNAIFJHMLA]
	public static IDisposable ENJFNBEEFCF<T>(this T JMEDJALIAEG, Action<float> GPNMHAKDLKK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true) where T : MonoBehaviour, GBAIPNMDKIG
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class CHLPBKBAHGM
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class EPFNLFDANCF : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public JHJLCHFAIBB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private HLGAIBDEEPE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public EPFNLFDANCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x905C080", Offset = "0x905AA80", VA = "0x18905C080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x905C160", Offset = "0x905AB60", VA = "0x18905C160", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GICNBBPCNGN : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public JHJLCHFAIBB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private HLGAIBDEEPE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public GICNBBPCNGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x905E0F0", Offset = "0x905CAF0", VA = "0x18905E0F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x905E1E0", Offset = "0x905CBE0", VA = "0x18905E1E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x9058F30", Offset = "0x9057930", VA = "0x189058F30")]
	public static LCOHCCBKPLJ ICLBDIALJKI(Action GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9059090", Offset = "0x9057A90", VA = "0x189059090")]
	public static LCOHCCBKPLJ ICLBDIALJKI(Behaviour IJNPIDPIBFP, Action GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9058FB0", Offset = "0x90579B0", VA = "0x189058FB0")]
	public static LCOHCCBKPLJ ICLBDIALJKI(Behaviour IJNPIDPIBFP, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x90591B0", Offset = "0x9057BB0", VA = "0x1890591B0")]
	[IteratorStateMachine(typeof(EPFNLFDANCF))]
	private static IEnumerator<JFFMJDIOLAN> POAAJLIFLGL(JHJLCHFAIBB LBPHLNLFCPC, Action GPNMHAKDLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9059120", Offset = "0x9057B20", VA = "0x189059120")]
	[IteratorStateMachine(typeof(GICNBBPCNGN))]
	private static IEnumerator<JFFMJDIOLAN> POAAJLIFLGL(JHJLCHFAIBB LBPHLNLFCPC, Action<float> GPNMHAKDLKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GPOJGNEDNIL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class LCHKHGENJPF : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GPOJGNEDNIL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public LCHKHGENJPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9060D00", Offset = "0x905F700", VA = "0x189060D00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9060D90", Offset = "0x905F790", VA = "0x189060D90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly JHJLCHFAIBB PFJPKKCCFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Action PHODFPNAMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool GBJBHCFCDLG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FICMBNIAFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x905E460", Offset = "0x905CE60", VA = "0x18905E460")]
	public GPOJGNEDNIL(JHJLCHFAIBB PFJPKKCCFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x905E340", Offset = "0x905CD40", VA = "0x18905E340")]
	[IteratorStateMachine(typeof(LCHKHGENJPF))]
	private IEnumerator<JFFMJDIOLAN> BHHLDKBFAFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x905E3C0", Offset = "0x905CDC0", VA = "0x18905E3C0", Slot = "4")]
	public void OnCompleted(Action BKCGBGOCCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	public void AHCLDIMMOIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class POHBHLAOPKO
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9068900", Offset = "0x9067300", VA = "0x189068900")]
	public static GPOJGNEDNIL CHDCJGNKGCK(this JHJLCHFAIBB PFJPKKCCFAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class MBFJPPMKOKD
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IGCDJJBKNMJ : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public EGBLIMKNBJE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public IGCDJJBKNMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x905E570", Offset = "0x905CF70", VA = "0x18905E570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x905E5F0", Offset = "0x905CFF0", VA = "0x18905E5F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9063F60", Offset = "0x9062960", VA = "0x189063F60")]
	public static LCOHCCBKPLJ ICLBDIALJKI(float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, bool AFHOKGLGFKE = true, [Optional] BCONDBBGDGF JEHAFCLHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x9064030", Offset = "0x9062A30", VA = "0x189064030")]
	public static LCOHCCBKPLJ ICLBDIALJKI(MonoBehaviour JMEDJALIAEG, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, bool AFHOKGLGFKE = true, [Optional] BCONDBBGDGF JEHAFCLHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9064100", Offset = "0x9062B00", VA = "0x189064100")]
	public static LCOHCCBKPLJ JGOIIOOHCBF(MonoBehaviour JMEDJALIAEG, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, bool AFHOKGLGFKE = true, [Optional] BCONDBBGDGF JEHAFCLHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x90641F0", Offset = "0x9062BF0", VA = "0x1890641F0")]
	public static LCOHCCBKPLJ MJPOGNGEPJG(MPNBHGLOEOL IJNPIDPIBFP, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, bool AFHOKGLGFKE = true, [Optional] BCONDBBGDGF JEHAFCLHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x90642C0", Offset = "0x9062CC0", VA = "0x1890642C0")]
	private static IEnumerator<JFFMJDIOLAN> POAAJLIFLGL(AILPKKOGDLK OFFCJGHAKJO, float DMIFOCPKGGI, JHJLCHFAIBB LBPHLNLFCPC, Action<float> GPNMHAKDLKK, bool AFHOKGLGFKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9063E70", Offset = "0x9062870", VA = "0x189063E70")]
	private static IEnumerator<JFFMJDIOLAN> ADHBEPPKIDF(AILPKKOGDLK OFFCJGHAKJO, float DMIFOCPKGGI, JHJLCHFAIBB LBPHLNLFCPC, Action<float> GPNMHAKDLKK, bool AFHOKGLGFKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9063ED0", Offset = "0x90628D0", VA = "0x189063ED0")]
	[IteratorStateMachine(typeof(IGCDJJBKNMJ))]
	private static IEnumerator<JFFMJDIOLAN> EFOMFKECPDL(EGBLIMKNBJE HHHEOPNOCJO, float DMIFOCPKGGI, JHJLCHFAIBB LBPHLNLFCPC, Action<float> GPNMHAKDLKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MCHHINKPHGP
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LAJIIODFLMO : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public JHJLCHFAIBB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public LAJIIODFLMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9060BF0", Offset = "0x905F5F0", VA = "0x189060BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9060CB0", Offset = "0x905F6B0", VA = "0x189060CB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x90644B0", Offset = "0x9062EB0", VA = "0x1890644B0")]
	[IteratorStateMachine(typeof(LAJIIODFLMO))]
	private static IEnumerator<JFFMJDIOLAN> JCIHJJLDICO(JHJLCHFAIBB PFJPKKCCFAK, Func<bool> HPFDJAAAMGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9064540", Offset = "0x9062F40", VA = "0x189064540")]
	public static LCOHCCBKPLJ LDLMHBJCBKB(this MonoBehaviour JMEDJALIAEG, Func<bool> HPFDJAAAMGI, JHJLCHFAIBB PFJPKKCCFAK = JHJLCHFAIBB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class BMCDHEKGCFH
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BCNPJAOIFCH : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public JHJLCHFAIBB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public BCNPJAOIFCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x90575A0", Offset = "0x9055FA0", VA = "0x1890575A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9057610", Offset = "0x9056010", VA = "0x189057610", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CNACPGDFACF<T> : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public JHJLCHFAIBB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public CNACPGDFACF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8ED0", Offset = "0x6EB78D0", VA = "0x186EB8ED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8F50", Offset = "0x6EB7950", VA = "0x186EB8F50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MFHGOAKDNKO : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public JHJLCHFAIBB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private JFFMJDIOLAN <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public MFHGOAKDNKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9064620", Offset = "0x9063020", VA = "0x189064620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x90646B0", Offset = "0x90630B0", VA = "0x1890646B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9057830", Offset = "0x9056230", VA = "0x189057830")]
	[IteratorStateMachine(typeof(BCNPJAOIFCH))]
	private static IEnumerator<JFFMJDIOLAN> BHHLDKBFAFP(float JHMKMDEDCJN, JHJLCHFAIBB LBPHLNLFCPC, Action DHFPPCMKNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B2E6D0", Offset = "0x3B2D0D0", VA = "0x183B2E6D0")]
	[IteratorStateMachine(typeof(CNACPGDFACF<>))]
	private static IEnumerator<JFFMJDIOLAN> BHHLDKBFAFP<T>(float JHMKMDEDCJN, JHJLCHFAIBB LBPHLNLFCPC, Action<T> DHFPPCMKNFO, T MFHBGCBJCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9057700", Offset = "0x9056100", VA = "0x189057700")]
	[IteratorStateMachine(typeof(MFHGOAKDNKO))]
	private static IEnumerator<JFFMJDIOLAN> AMMOJEJFFDB(float JHMKMDEDCJN, JHJLCHFAIBB LBPHLNLFCPC, Action DHFPPCMKNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9057B90", Offset = "0x9056590", VA = "0x189057B90")]
	public static IDisposable JCMOECCFLHG(this MonoBehaviour JMEDJALIAEG, float JHMKMDEDCJN, Action DHFPPCMKNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x90577A0", Offset = "0x90561A0", VA = "0x1890577A0")]
	public static LCOHCCBKPLJ BHCEMBBMKGL(this MonoBehaviour JMEDJALIAEG, float JHMKMDEDCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9057AA0", Offset = "0x90564A0", VA = "0x189057AA0")]
	public static LCOHCCBKPLJ JCMOECCFLHG(this MonoBehaviour JMEDJALIAEG, float JHMKMDEDCJN, JHJLCHFAIBB LBPHLNLFCPC, Action DHFPPCMKNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x9057C70", Offset = "0x9056670", VA = "0x189057C70")]
	public static LCOHCCBKPLJ KEIEHNKMNLH(this MonoBehaviour JMEDJALIAEG, Action DHFPPCMKNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3B2E790", Offset = "0x3B2D190", VA = "0x183B2E790")]
	public static LCOHCCBKPLJ KEIEHNKMNLH<T>(this MonoBehaviour JMEDJALIAEG, Action<T> DHFPPCMKNFO, T MFHBGCBJCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9057D10", Offset = "0x9056710", VA = "0x189057D10")]
	public static LCOHCCBKPLJ MCCMJLBJNBD(this MonoBehaviour JMEDJALIAEG, Action DHFPPCMKNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9057E50", Offset = "0x9056850", VA = "0x189057E50")]
	public static LCOHCCBKPLJ NALEDPHJIIF(this MonoBehaviour JMEDJALIAEG, Action DHFPPCMKNFO, [Optional] BCONDBBGDGF JEHAFCLHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x90578D0", Offset = "0x90562D0", VA = "0x1890578D0")]
	public static LCOHCCBKPLJ BNBAEBFMEIH(this MonoBehaviour JMEDJALIAEG, Action DHFPPCMKNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9057EF0", Offset = "0x90568F0", VA = "0x189057EF0")]
	public static LCOHCCBKPLJ NKKCBKDJLFN(this MonoBehaviour JMEDJALIAEG, Action DHFPPCMKNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9057DB0", Offset = "0x90567B0", VA = "0x189057DB0")]
	public static LCOHCCBKPLJ MLOPMOECCIE(MonoBehaviour JMEDJALIAEG, JHJLCHFAIBB PFJPKKCCFAK, Action DHFPPCMKNFO, [Optional] BCONDBBGDGF JEHAFCLHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B2E7C0", Offset = "0x3B2D1C0", VA = "0x183B2E7C0")]
	public static LCOHCCBKPLJ MLOPMOECCIE<T>(MonoBehaviour JMEDJALIAEG, JHJLCHFAIBB PFJPKKCCFAK, Action<T> DHFPPCMKNFO, T MFHBGCBJCJO, [Optional] BCONDBBGDGF JEHAFCLHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9057A10", Offset = "0x9056410", VA = "0x189057A10")]
	public static LCOHCCBKPLJ EJOOGLBHJFH(this MonoBehaviour JMEDJALIAEG, float FNFBINMHKAB, Action DHFPPCMKNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9057660", Offset = "0x9056060", VA = "0x189057660")]
	public static LCOHCCBKPLJ AHCHPKMIPGK(this MonoBehaviour JMEDJALIAEG, float FNFBINMHKAB, Action DHFPPCMKNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9057F90", Offset = "0x9056990", VA = "0x189057F90")]
	public static LCOHCCBKPLJ PPJEBBBGAEI(this MonoBehaviour JMEDJALIAEG, float FNFBINMHKAB, Action DHFPPCMKNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9057970", Offset = "0x9056370", VA = "0x189057970")]
	public static LCOHCCBKPLJ BPCMKBHFNEK(this MonoBehaviour JMEDJALIAEG, float FNFBINMHKAB, Action DHFPPCMKNFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KLNFCDJIDDE : IKBKCKIHPFM, IEnumerable<IKBKCKIHPFM>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly List<IKBKCKIHPFM> BHBLBOKHCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool PEOAPMDFJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Action GFLBIOONNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool LHGEDAOJHEE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool ENDIILOGACO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9060350", Offset = "0x905ED50", VA = "0x189060350", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action FMMAEHLLONH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9060060", Offset = "0x905EA60", VA = "0x189060060", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x90602B0", Offset = "0x905ECB0", VA = "0x1890602B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9060910", Offset = "0x905F310", VA = "0x189060910")]
	public KLNFCDJIDDE([Optional] Action GFLBIOONNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9060180", Offset = "0x905EB80", VA = "0x189060180")]
	public void HMDNMGBNKIA(IKBKCKIHPFM IFJJEEPNADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x90607B0", Offset = "0x905F1B0", VA = "0x1890607B0")]
	private void PLFMAFADCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x90607A0", Offset = "0x905F1A0", VA = "0x1890607A0", Slot = "7")]
	public bool OEEFIFDEBLJ(bool KEJIJALNLAM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x9060490", Offset = "0x905EE90", VA = "0x189060490", Slot = "8")]
	public bool OEEFIFDEBLJ(Action FCCCPABHDPG, bool KEJIJALNLAM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x9060100", Offset = "0x905EB00", VA = "0x189060100", Slot = "9")]
	public IEnumerator<IKBKCKIHPFM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x9060100", Offset = "0x905EB00", VA = "0x189060100", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GEDAOMBNKHN : GDFDINGMGFI
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GCMJBPNPFLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public GEDAOMBNKHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GCMJBPNPFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x905D770", Offset = "0x905C170", VA = "0x18905D770")]
		internal void IEHNKDDGLCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JKJEINCFHGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public GEDAOMBNKHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public JKJEINCFHGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x905D770", Offset = "0x905C170", VA = "0x18905D770")]
		internal void JLCBLKJCEKE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly float EPMOOHCLMGM;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x9058DF0", Offset = "0x90577F0", VA = "0x189058DF0")]
	public GEDAOMBNKHN(Behaviour IJNPIDPIBFP, float EPMOOHCLMGM, [Optional] Action GFLBIOONNNJ, [Optional] BCONDBBGDGF JEHAFCLHOLP, [Optional] AILPKKOGDLK OFFCJGHAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x905DFA0", Offset = "0x905C9A0", VA = "0x18905DFA0", Slot = "9")]
	protected override bool PODMHLOKMPC(Action FCCCPABHDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x905DE90", Offset = "0x905C890", VA = "0x18905DE90", Slot = "10")]
	protected override bool MHBLPPAHGAM(Action FCCCPABHDPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface IKBKCKIHPFM
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ENDIILOGACO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action FMMAEHLLONH;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OEEFIFDEBLJ(bool KEJIJALNLAM = false);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OEEFIFDEBLJ(Action FCCCPABHDPG, bool KEJIJALNLAM = false);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class GDFDINGMGFI : IKBKCKIHPFM
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class OPNMJAMMPBN : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public GDFDINGMGFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public OPNMJAMMPBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9068710", Offset = "0x9067110", VA = "0x189068710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x90687E0", Offset = "0x90671E0", VA = "0x1890687E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Behaviour IJNPIDPIBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Action GFLBIOONNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private PKHGEDPOIHB KMPHLJEGMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly BCONDBBGDGF JEHAFCLHOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly AILPKKOGDLK OFFCJGHAKJO;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ENDIILOGACO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xE40D60", Offset = "0xE3F760", VA = "0x180E40D60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action FMMAEHLLONH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x905D7A0", Offset = "0x905C1A0", VA = "0x18905D7A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x905D910", Offset = "0x905C310", VA = "0x18905D910", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x905DD60", Offset = "0x905C760", VA = "0x18905DD60")]
	protected GDFDINGMGFI(Behaviour IJNPIDPIBFP, [Optional] Action GFLBIOONNNJ, [Optional] BCONDBBGDGF JEHAFCLHOLP, [Optional] AILPKKOGDLK OFFCJGHAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x905DC00", Offset = "0x905C600", VA = "0x18905DC00", Slot = "7")]
	public bool OEEFIFDEBLJ(bool KEJIJALNLAM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x905DC60", Offset = "0x905C660", VA = "0x18905DC60", Slot = "8")]
	public bool OEEFIFDEBLJ(Action FCCCPABHDPG, bool KEJIJALNLAM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool PODMHLOKMPC(Action FCCCPABHDPG);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool MHBLPPAHGAM(Action FCCCPABHDPG);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x905DCC0", Offset = "0x905C6C0", VA = "0x18905DCC0")]
	protected void OELNIFBJLDJ(Action FCCCPABHDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x905D9B0", Offset = "0x905C3B0", VA = "0x18905D9B0")]
	protected CNBBKAECPOB JLOKMDAADJM(float NDKGEJPCLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x905DCE0", Offset = "0x905C6E0", VA = "0x18905DCE0")]
	private void PMLKDOELHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x905D880", Offset = "0x905C280", VA = "0x18905D880")]
	[IteratorStateMachine(typeof(OPNMJAMMPBN))]
	private IEnumerator<JFFMJDIOLAN> IJKGLCPMING(float NDKGEJPCLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x905D840", Offset = "0x905C240", VA = "0x18905D840")]
	[CompilerGenerated]
	private void HCNEOPKCOJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GBHLOLODEIK : GDFDINGMGFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly float FJIHLMGFCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int HPLKEBIIGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly float KEGHBOONKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly float[] OLKHOPFAIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int JLMJNMCEJCF;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x905D5A0", Offset = "0x905BFA0", VA = "0x18905D5A0")]
	public GBHLOLODEIK(Behaviour IJNPIDPIBFP, float IEBLEDHBJPG, int HPLKEBIIGNA, [Optional] Action GFLBIOONNNJ, float KEGHBOONKJP = 0f, [Optional] BCONDBBGDGF JEHAFCLHOLP, [Optional] AILPKKOGDLK OFFCJGHAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "9")]
	protected override bool PODMHLOKMPC(Action FCCCPABHDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x905D3A0", Offset = "0x905BDA0", VA = "0x18905D3A0", Slot = "10")]
	protected override bool MHBLPPAHGAM(Action FCCCPABHDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x905D320", Offset = "0x905BD20", VA = "0x18905D320")]
	private void DFLEILGOHBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class CHICJGJPOLI : GDFDINGMGFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float EPMOOHCLMGM;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x9058DF0", Offset = "0x90577F0", VA = "0x189058DF0")]
	public CHICJGJPOLI(Behaviour IJNPIDPIBFP, float EPMOOHCLMGM, [Optional] Action GFLBIOONNNJ, [Optional] BCONDBBGDGF JEHAFCLHOLP, [Optional] AILPKKOGDLK OFFCJGHAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "9")]
	protected override bool PODMHLOKMPC(Action FCCCPABHDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x9058DB0", Offset = "0x90577B0", VA = "0x189058DB0", Slot = "10")]
	protected override bool MHBLPPAHGAM(Action FCCCPABHDPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class ECNIKOLDKJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class LOHAJNADGCE : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public LOHAJNADGCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9063C70", Offset = "0x9062670", VA = "0x189063C70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9063CE0", Offset = "0x90626E0", VA = "0x189063CE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private LCOHCCBKPLJ FFAGKPBLMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private MPNBHGLOEOL IJNPIDPIBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Action<float> NDDFJNAIEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private JHJLCHFAIBB PFJPKKCCFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private float PBDBLGFHJOH;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x905B530", Offset = "0x9059F30", VA = "0x18905B530")]
	public ECNIKOLDKJP(MPNBHGLOEOL IJNPIDPIBFP, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x905B340", Offset = "0x9059D40", VA = "0x18905B340")]
	private void MKJPFCLCOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x905B1B0", Offset = "0x9059BB0", VA = "0x18905B1B0")]
	private void DMCJILBMOFF(string IHPAEKNOMOJ, Action BLPHFLHAPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x905B4B0", Offset = "0x9059EB0", VA = "0x18905B4B0")]
	[IteratorStateMachine(typeof(LOHAJNADGCE))]
	private IEnumerator<JFFMJDIOLAN> OHILPBNFEAO(Action BLPHFLHAPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x905B2E0", Offset = "0x9059CE0", VA = "0x18905B2E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x905B030", Offset = "0x9059A30", VA = "0x18905B030")]
	[CompilerGenerated]
	private void AIOBHPLMKDN(string ILHCGNGICHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class JANKONDMIOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PCJDHOBFPKI : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public PCJDHOBFPKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9063C70", Offset = "0x9062670", VA = "0x189063C70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x90688B0", Offset = "0x90672B0", VA = "0x1890688B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private LCOHCCBKPLJ FFAGKPBLMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private MonoBehaviour JMEDJALIAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Action GPNMHAKDLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Action<float> NDDFJNAIEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private JHJLCHFAIBB PFJPKKCCFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private float PBDBLGFHJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private bool AFHOKGLGFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly BCONDBBGDGF JEHAFCLHOLP;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x905F270", Offset = "0x905DC70", VA = "0x18905F270")]
	public JANKONDMIOM(MonoBehaviour JMEDJALIAEG, Action GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, [Optional] BCONDBBGDGF JEHAFCLHOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x905F5E0", Offset = "0x905DFE0", VA = "0x18905F5E0")]
	public JANKONDMIOM(MonoBehaviour JMEDJALIAEG, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, [Optional] BCONDBBGDGF JEHAFCLHOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x905F400", Offset = "0x905DE00", VA = "0x18905F400")]
	public JANKONDMIOM(MonoBehaviour JMEDJALIAEG, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, bool AFHOKGLGFKE = true, [Optional] BCONDBBGDGF JEHAFCLHOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0xF45660", Offset = "0xF44060", VA = "0x180F45660")]
	private JANKONDMIOM(BCONDBBGDGF JEHAFCLHOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x905E8F0", Offset = "0x905D2F0", VA = "0x18905E8F0")]
	internal static JANKONDMIOM FFHFGGAHINN(MonoBehaviour JMEDJALIAEG, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, JHJLCHFAIBB PFJPKKCCFAK, bool AFHOKGLGFKE = true, [Optional] BCONDBBGDGF JEHAFCLHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x905ECA0", Offset = "0x905D6A0", VA = "0x18905ECA0")]
	private void ICLBDIALJKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x905EB20", Offset = "0x905D520", VA = "0x18905EB20")]
	private void HOCFCDMJHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x905EE60", Offset = "0x905D860", VA = "0x18905EE60")]
	private void MKJPFCLCOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x905F0E0", Offset = "0x905DAE0", VA = "0x18905F0E0")]
	private void POANEIOKJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x905E760", Offset = "0x905D160", VA = "0x18905E760")]
	private void DMCJILBMOFF(string IHPAEKNOMOJ, Action BLPHFLHAPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x905EFD0", Offset = "0x905D9D0", VA = "0x18905EFD0")]
	[IteratorStateMachine(typeof(PCJDHOBFPKI))]
	private IEnumerator<JFFMJDIOLAN> OHILPBNFEAO(Action BLPHFLHAPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x905E890", Offset = "0x905D290", VA = "0x18905E890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x905EDD0", Offset = "0x905D7D0", VA = "0x18905EDD0")]
	[CompilerGenerated]
	private void KCFLCEAEDJD(string ILHCGNGICHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x905E6D0", Offset = "0x905D0D0", VA = "0x18905E6D0")]
	[CompilerGenerated]
	private void DIDOMIGCOHH(string ILHCGNGICHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x905E640", Offset = "0x905D040", VA = "0x18905E640")]
	[CompilerGenerated]
	private void CGMKPNJFFIL(string ILHCGNGICHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x905F050", Offset = "0x905DA50", VA = "0x18905F050")]
	[CompilerGenerated]
	private void PGODGCJPBOD(string ILHCGNGICHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
internal enum BBOGNMDNGPA : byte
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
internal sealed class MABBBHNKKPO : AILPKKOGDLK
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float IBJIMPNBLHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9063E50", Offset = "0x9062850", VA = "0x189063E50", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float AHEFKBOGKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9063E60", Offset = "0x9062860", VA = "0x189063E60", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public double CJMAJLKJKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9063DC0", Offset = "0x90627C0", VA = "0x189063DC0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x9063DE0", Offset = "0x90627E0", VA = "0x189063DE0")]
	[DMKNBLIJJON.EGFDFBOLNDK]
	internal static void CCKCOACOBKL(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	[UnityEngine.Scripting.Preserve]
	internal MABBBHNKKPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface AEAEJGECFPI
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BACMEAGBFEE(string IELIBBNCJAC);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHDLAMHFGBC();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface POLOICIPLGK
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HEAIIMNKJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool DCFOKHDKMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal class DPPNJDGAAJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public LFMHLMPCJON HMBPONPIGNF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int CIDCBGPMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x905ACA0", Offset = "0x90596A0", VA = "0x18905ACA0")]
	public static JFFMJDIOLAN ENPPILIONMJ(IEnumerator<JFFMJDIOLAN> ODNFOPMEPEI, PABKDENKBJP FBJNLPOFDFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x905AE00", Offset = "0x9059800", VA = "0x18905AE00")]
	public JFFMJDIOLAN ENPPILIONMJ(PABKDENKBJP[] JOOMGFAOFPE, IEnumerator<JFFMJDIOLAN>[] PJBEFJCJAPG, JFFMJDIOLAN[] LJOCPHPHFEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x905AEC0", Offset = "0x90598C0", VA = "0x18905AEC0")]
	public void KNAEOBCOPLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x905AB60", Offset = "0x9059560", VA = "0x18905AB60")]
	public void AEPAPAOACGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x905AEF0", Offset = "0x90598F0", VA = "0x18905AEF0")]
	public void LBKMIIKGAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x905AEC0", Offset = "0x90598C0", VA = "0x18905AEC0")]
	public void LFPMCBHAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public DPPNJDGAAJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class LFMHLMPCJON
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct PBFPLNEBNNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public DPPNJDGAAJK MHAHGAIKHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public MPNBHGLOEOL NGIJKNBMGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public PABKDENKBJP FFDEPACNPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IEnumerator<JFFMJDIOLAN> FNILELMICFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public JFFMJDIOLAN AOKLLGEIFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public BBOGNMDNGPA CEIBCMPPNIP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct PHJKPDEPNJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public JHJLCHFAIBB AMBOJLNNGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public List<PBFPLNEBNNN> ONFANBLFBHM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class EEFOHOAKKLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public PABKDENKBJP promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public LFMHLMPCJON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public MPNBHGLOEOL context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public DPPNJDGAAJK routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public BBOGNMDNGPA coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public JFFMJDIOLAN currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public IEnumerator<JFFMJDIOLAN> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EEFOHOAKKLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x905B8B0", Offset = "0x905A2B0", VA = "0x18905B8B0")]
		internal void JPJEMENGMKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class GEKOCOIEBJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public DPPNJDGAAJK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public LFMHLMPCJON <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GEKOCOIEBJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x905E0B0", Offset = "0x905CAB0", VA = "0x18905E0B0")]
		internal void HOAAOPJEOGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class OBCJHFDICDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public DPPNJDGAAJK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public LFMHLMPCJON <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OBCJHFDICDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9068540", Offset = "0x9066F40", VA = "0x189068540")]
		internal void IJPDIJCCEDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class HLNLIKEPFGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public DPPNJDGAAJK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public LFMHLMPCJON <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HLNLIKEPFGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x905E530", Offset = "0x905CF30", VA = "0x18905E530")]
		internal void HEKGMLLOMAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const BBOGNMDNGPA NFANPDJCJHD = BBOGNMDNGPA.Cancelled | BBOGNMDNGPA.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly JHJLCHFAIBB PFJPKKCCFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool[] OIJHMFBMMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private NativeArray<BBOGNMDNGPA> IMEGFDBBMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private NativeArray<float> LCHMIDEIABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private NativeArray<int> BMHILFDIOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeArray<int> IIGPCHEOKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<int> DKIJDLEBKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<int> PEIHCIFEFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<int> MEFKFNHDGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private DPPNJDGAAJK[] AAMLOKHLPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private PABKDENKBJP[] JOOMGFAOFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private MPNBHGLOEOL[] EPGCFKNOMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private IEnumerator<JFFMJDIOLAN>[] HBGKOFJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private JFFMJDIOLAN[] NHCEABGOCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int CNEIAGICBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int JHAGJEMJCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly int AHBOODEOAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private float NNMEHAFKECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private KADBGILKMKG OIAILGKGNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private JobHandle AHFCGAFPCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private List<DPPNJDGAAJK> GBGCFILMFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool BAJJMBCHAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private List<Action> LJGMIPOFNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private List<Action> IKJBCLJFLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool PHCLLKDBNLF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public PHJKPDEPNJE[] GIOFMPCILFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xC25680", Offset = "0xC24080", VA = "0x180C25680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x9061430", Offset = "0x905FE30", VA = "0x189061430")]
	private static int DACIIFFFPEJ(JHJLCHFAIBB PFJPKKCCFAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x9063170", Offset = "0x9061B70", VA = "0x189063170")]
	public LFMHLMPCJON(JHJLCHFAIBB PFJPKKCCFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x90616C0", Offset = "0x90600C0", VA = "0x1890616C0")]
	private void GCHJMPMBFDE(int PBKBPHADPNE, int EILKOCKAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x90612B0", Offset = "0x905FCB0", VA = "0x1890612B0")]
	public void CHLLPLKKDEL(MPNBHGLOEOL IJNPIDPIBFP, JFFMJDIOLAN HHOMNDICAJF, IEnumerator<JFFMJDIOLAN> ODNFOPMEPEI, PABKDENKBJP FBJNLPOFDFG, [Optional] DPPNJDGAAJK JKNCPPOPLHI, BBOGNMDNGPA EDICMNBJOPC = BBOGNMDNGPA.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x90628E0", Offset = "0x90612E0", VA = "0x1890628E0")]
	public void OGBKPOJEFBN(IEnumerable<PBFPLNEBNNN> IGNJFJJFFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x9062CA0", Offset = "0x90616A0", VA = "0x189062CA0")]
	private PBFPLNEBNNN PMBAPGILBPH(int MPCIEJPHNKE)
	{
		return default(PBFPLNEBNNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x90618A0", Offset = "0x90602A0", VA = "0x1890618A0")]
	private void HGBIGGOBMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3E6DB80", Offset = "0x3E6C580", VA = "0x183E6DB80")]
	private static void IOAPFGBKGGN<T>(int MPCIEJPHNKE, T[] GJLKLENJIOJ, int BCAJFCGHDKI, [Optional] T AAKNMOFBBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3E6DBD0", Offset = "0x3E6C5D0", VA = "0x183E6DBD0")]
	private static void IOAPFGBKGGN<T>(int MPCIEJPHNKE, NativeArray<T> GJLKLENJIOJ, int BCAJFCGHDKI, [Optional] T AAKNMOFBBKM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x9060F10", Offset = "0x905F910", VA = "0x189060F10")]
	private void CCLCDMDNKAF(IEnumerable<PBFPLNEBNNN> IGNJFJJFFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x9062590", Offset = "0x9060F90", VA = "0x189062590")]
	private void NBOOOLBLFHL(PBFPLNEBNNN GHOAJGBADOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x9061460", Offset = "0x905FE60", VA = "0x189061460")]
	private HAOPECCIMMA DLBPKDKKDFF(int EAMAJGCOGID)
	{
		return default(HAOPECCIMMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x9062660", Offset = "0x9061060", VA = "0x189062660")]
	public void NCMHPECJHIC(float JODOCMCKKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x9062C20", Offset = "0x9061620", VA = "0x189062C20")]
	private void PHFLGFBKIKO(Action EICJFDNFOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x9062860", Offset = "0x9061260", VA = "0x189062860")]
	private void NNOEHDADJKL(Action EICJFDNFOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x9061E70", Offset = "0x9060870", VA = "0x189061E70")]
	public void LJCOMKIILKK(float JODOCMCKKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9062B20", Offset = "0x9061520", VA = "0x189062B20")]
	public void OKCDDGFOJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x9061D40", Offset = "0x9060740", VA = "0x189061D40")]
	public void LFPMCBHAIJL(DPPNJDGAAJK HHHEOPNOCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9061C10", Offset = "0x9060610", VA = "0x189061C10")]
	public void KBBEAMBLPCO(DPPNJDGAAJK HHHEOPNOCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x9060DE0", Offset = "0x905F7E0", VA = "0x189060DE0")]
	public void AFJICPONINP(DPPNJDGAAJK HHHEOPNOCJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class GJMOPJCINDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public static readonly GJMOPJCINDH BENGIKOEPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Action CHDFLAOCICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool ICPNMNBNLKA;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public GJMOPJCINDH(Action CHDFLAOCICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8664580", Offset = "0x8662F80", VA = "0x188664580", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface APICHLCKDFA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable IKHLFCPOJDM(UnityEngine.Object IJNPIDPIBFP, Action<T> HHDKBGKFNDB);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CEKNCNGMOOC<T> : APICHLCKDFA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	new T AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class DHBMFHOFBLA<T> : CEKNCNGMOOC<T>, APICHLCKDFA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class GPOGHCKDOMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public DHBMFHOFBLA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CPMDBLLCOLH<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GPOGHCKDOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x515BDE0", Offset = "0x515A7E0", VA = "0x18515BDE0")]
		internal void KMDPMBPENOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static GameObject BNFBEACDLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<CPMDBLLCOLH<UnityEngine.Object, Action<T>>> KHFGHKHMGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private T GEKPMNGINKN;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xB36DB0", Offset = "0xB357B0", VA = "0x180B36DB0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x45F69D0", Offset = "0x45F53D0", VA = "0x1845F69D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x45F68D0", Offset = "0x45F52D0", VA = "0x1845F68D0")]
	private static bool PHACBCEEHOD(T EICJFDNFOCB, T MIBIEOGGIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x45F6AC0", Offset = "0x45F54C0", VA = "0x1845F6AC0")]
	public DHBMFHOFBLA(T LOOGMANDIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x45F6750", Offset = "0x45F5150", VA = "0x1845F6750", Slot = "6")]
	public IDisposable IKHLFCPOJDM(UnityEngine.Object IJNPIDPIBFP, Action<T> HHDKBGKFNDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x45F5F90", Offset = "0x45F4990", VA = "0x1845F5F90")]
	private void CMOFNDBCMMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class NANHGAIGIDJ : GOEFANHLKKC
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class LJACJODODAC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class NCHFGMJMMAB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int NMAIBBDGPCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private LJACJODODAC LBPHLNLFCPC;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x109EE20", Offset = "0x109D820", VA = "0x18109EE20")]
			public NCHFGMJMMAB(int NMAIBBDGPCD, LJACJODODAC LBPHLNLFCPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x9068290", Offset = "0x9066C90", VA = "0x189068290", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class INKICKFECJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public INKICKFECJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB92EF0", Offset = "0xB918F0", VA = "0x180B92EF0")]
			internal bool EFDEAALHLHO(EPNNLNKAMDP e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class JOOLMCNJCKB : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private JFFMJDIOLAN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public LJACJODODAC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public AILPKKOGDLK timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private HLGAIBDEEPE <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private List<EPNNLNKAMDP> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public JOOLMCNJCKB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x905F7B0", Offset = "0x905E1B0", VA = "0x18905F7B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x905FAB0", Offset = "0x905E4B0", VA = "0x18905FAB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly JHJLCHFAIBB PFJPKKCCFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private LCOHCCBKPLJ FBJNLPOFDFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly List<EPNNLNKAMDP> AIBKAFMFLDI;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9063BD0", Offset = "0x90625D0", VA = "0x189063BD0")]
		public LJACJODODAC(JHJLCHFAIBB PFJPKKCCFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9063820", Offset = "0x9062220", VA = "0x189063820")]
		public IDisposable EJDHGNEKEFB(EPNNLNKAMDP MMANHJNCHIN, BCONDBBGDGF JEHAFCLHOLP, AILPKKOGDLK KIGHMIAOFFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x90639B0", Offset = "0x90623B0", VA = "0x1890639B0")]
		private void LJHIKNCOPCL(int NMAIBBDGPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9063B40", Offset = "0x9062540", VA = "0x189063B40")]
		[IteratorStateMachine(typeof(JOOLMCNJCKB))]
		private IEnumerator<JFFMJDIOLAN> POAAJLIFLGL(AILPKKOGDLK KIGHMIAOFFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x90637D0", Offset = "0x90621D0", VA = "0x1890637D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class EPNNLNKAMDP
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public enum NJFKILHEFNK : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static int JFFLPFHAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int BKICOPKGOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly GBAIPNMDKIG NGIJKNBMGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly MonoBehaviour EIJINLHDDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly Action DBIPLKHEHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly Action<float> HEMIPAOPBNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly float KGDIBGBCPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public float LCHMIDEIABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly string DDPJMHMICBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly bool HAKEDPGPIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly NJFKILHEFNK HDPCHDNOFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool DHCICLMFEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public bool HFOFNANIBHM;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x905C760", Offset = "0x905B160", VA = "0x18905C760")]
		public EPNNLNKAMDP(GBAIPNMDKIG IJNPIDPIBFP, Action GPNMHAKDLKK, bool NONNJEIHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x905C400", Offset = "0x905AE00", VA = "0x18905C400")]
		public EPNNLNKAMDP(GBAIPNMDKIG IJNPIDPIBFP, Action<float> GPNMHAKDLKK, bool NONNJEIHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x905C580", Offset = "0x905AF80", VA = "0x18905C580")]
		public EPNNLNKAMDP(GBAIPNMDKIG IJNPIDPIBFP, float DMIFOCPKGGI, Action<float> GPNMHAKDLKK, AILPKKOGDLK KIGHMIAOFFO, NJFKILHEFNK BNJEIJLBEAL, bool AFHOKGLGFKE, bool NONNJEIHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x905C1B0", Offset = "0x905ABB0", VA = "0x18905C1B0")]
		public bool LMGGEIHMHHJ(float LKKNOPLOOPB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly BCONDBBGDGF JEHAFCLHOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly AILPKKOGDLK OFFCJGHAKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<JHJLCHFAIBB, LJACJODODAC> JEEEHFFLGIA;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x9068160", Offset = "0x9066B60", VA = "0x189068160")]
	[DMKNBLIJJON.EGFDFBOLNDK]
	internal static void PFKHJMPNCLK(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x90681D0", Offset = "0x9066BD0", VA = "0x1890681D0")]
	[UnityEngine.Scripting.Preserve]
	internal NANHGAIGIDJ([BMCONCJPCIA(null)] BCONDBBGDGF JEHAFCLHOLP, [BMCONCJPCIA(null)] AILPKKOGDLK OFFCJGHAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x90679F0", Offset = "0x90663F0", VA = "0x1890679F0", Slot = "4")]
	public IDisposable DBIPLKHEHMB(GBAIPNMDKIG IJNPIDPIBFP, Action AEPCPKCINPI, JHJLCHFAIBB PFJPKKCCFAK, bool NONNJEIHKKP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x9067800", Offset = "0x9066200", VA = "0x189067800", Slot = "5")]
	public IDisposable DBIPLKHEHMB(GBAIPNMDKIG IJNPIDPIBFP, Action<float> AEPCPKCINPI, JHJLCHFAIBB PFJPKKCCFAK, bool NONNJEIHKKP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9067BE0", Offset = "0x90665E0", VA = "0x189067BE0", Slot = "7")]
	public IDisposable GAONPEEHMED(GBAIPNMDKIG IJNPIDPIBFP, float DMIFOCPKGGI, Action<float> AEPCPKCINPI, JHJLCHFAIBB PFJPKKCCFAK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x9067700", Offset = "0x9066100", VA = "0x189067700", Slot = "8")]
	public IDisposable AOBGODMKPCE(GBAIPNMDKIG IJNPIDPIBFP, float DMIFOCPKGGI, Action<float> AEPCPKCINPI, JHJLCHFAIBB PFJPKKCCFAK, bool AFHOKGLGFKE = true, bool NONNJEIHKKP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x9067CE0", Offset = "0x90666E0", VA = "0x189067CE0", Slot = "6")]
	public IDisposable GAONPEEHMED(float DMIFOCPKGGI, Action<float> AEPCPKCINPI, bool AFHOKGLGFKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9067FA0", Offset = "0x90669A0", VA = "0x189067FA0", Slot = "9")]
	public void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x9067E60", Offset = "0x9066860", VA = "0x189067E60")]
	private LJACJODODAC KHBFIFNKHDA(JHJLCHFAIBB PFJPKKCCFAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class CENNABPMIGI : MOLHDGHNIHO, BCONDBBGDGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private LFMHLMPCJON[] JKIPCFHOGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private AEAEJGECFPI IDPKJDLCBCM;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x9058030", Offset = "0x9056A30", VA = "0x189058030")]
	[DMKNBLIJJON.EGFDFBOLNDK]
	internal static void CCKCOACOBKL(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x9058C00", Offset = "0x9057600", VA = "0x189058C00")]
	[UnityEngine.Scripting.Preserve]
	public CENNABPMIGI([BMCONCJPCIA(null)] PHKMFNMNKJJ LKFGGFPPOFD, [BMCONCJPCIA(null)] AILPKKOGDLK OFFCJGHAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9058780", Offset = "0x9057180", VA = "0x189058780", Slot = "19")]
	public override LCOHCCBKPLJ MLJFNBKIIEJ(MPNBHGLOEOL IJNPIDPIBFP, IEnumerator<JFFMJDIOLAN> JHBPMHGMOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x9058970", Offset = "0x9057370", VA = "0x189058970", Slot = "20")]
	public override void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x9058550", Offset = "0x9056F50", VA = "0x189058550", Slot = "22")]
	public override void LGBHCBGKAOK(JHJLCHFAIBB PFJPKKCCFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x90580A0", Offset = "0x9056AA0", VA = "0x1890580A0", Slot = "21")]
	protected override void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9058400", Offset = "0x9056E00", VA = "0x189058400")]
	private LFMHLMPCJON HNLOPFMEFCL(JHJLCHFAIBB DGNODDPLLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x90581D0", Offset = "0x9056BD0", VA = "0x1890581D0", Slot = "23")]
	internal override ALAGOBMGNCE HGBAIPHJABD(IEnumerator<JFFMJDIOLAN> JHBPMHGMOII, Behaviour IJNPIDPIBFP, PABKDENKBJP FBJNLPOFDFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x90588B0", Offset = "0x90572B0", VA = "0x1890588B0", Slot = "24")]
	internal override MPBNEHOHPKO NCFCOGNNCLJ(JHJLCHFAIBB LBPHLNLFCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x9058430", Offset = "0x9056E30", VA = "0x189058430")]
	private void JNDKCECKCKH(LFMHLMPCJON BLBKLKKEDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x9058170", Offset = "0x9056B70", VA = "0x189058170", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[BurstCompile]
internal struct KADBGILKMKG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[ReadOnly]
	public float AAJLOGHECAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[ReadOnly]
	public int CFEHCLBKJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> JCLKFHPHCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeArray<int> JANCDHGCDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<int> NPAAFPLDHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	public NativeArray<BBOGNMDNGPA> CCKGOLGHJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	public NativeArray<float> JBGKKFMBKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[WriteOnly]
	public NativeArray<int> DKIJDLEBKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[WriteOnly]
	public NativeArray<int> BMHILFDIOJA;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x9060000", Offset = "0x905EA00", VA = "0x189060000")]
	public static KADBGILKMKG MLAHKGEEKLJ(int KKOKEFIFJME, float JODOCMCKKFN, NativeArray<BBOGNMDNGPA> PPIODEPEJNF, NativeArray<float> EFAANHNODJM, NativeArray<int> GOAEPKCKNGL, NativeArray<int> DKAKFGNOEMK, NativeArray<int> JKEGNDIJFBK, NativeArray<int> JANCDHGCDMK, NativeArray<int> NPAAFPLDHCB)
	{
		return default(KADBGILKMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x905FBA0", Offset = "0x905E5A0", VA = "0x18905FBA0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x905FC80", Offset = "0x905E680", VA = "0x18905FC80")]
	private bool IALDMIINHIO(int KABGMIEBEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x905FCC0", Offset = "0x905E6C0", VA = "0x18905FCC0")]
	private void ICMKANBPPCI(NativeArray<int> IIHNJOKLOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x905FB00", Offset = "0x905E500", VA = "0x18905FB00")]
	private int AMDLLIIOBLP(int BLAADEDFMDM, int IJBNEOEHKPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x905FCF0", Offset = "0x905E6F0", VA = "0x18905FCF0")]
	private void JAJIMIHINNG(NativeArray<int> IIHNJOKLOOP, int AMCILHGIKGB, int OLMEHKPIJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x905FDC0", Offset = "0x905E7C0", VA = "0x18905FDC0")]
	private void MCCOAPIAEGF(NativeArray<int> IIHNJOKLOOP, int CBACIDJONIA, int FJJCMIOMDFC, int BIGFBGPMPBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class MOLHDGHNIHO : BCONDBBGDGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly PHKMFNMNKJJ LKFGGFPPOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	protected readonly AILPKKOGDLK OFFCJGHAKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private MPBNEHOHPKO[] BFKIMOINCAA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static BCONDBBGDGF FLGHCDNLMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x90655F0", Offset = "0x9063FF0", VA = "0x1890655F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool FHLCJJBHDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public JHJLCHFAIBB BPCLAMOCHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JHJLCHFAIBB);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public AILPKKOGDLK DGGOPNPHICB
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public JFFMJDIOLAN LFFJKCBEGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public JFFMJDIOLAN LPNKHACHLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public JFFMJDIOLAN PNDNPMHNIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JFFMJDIOLAN IKJPFEHHFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x90654C0", Offset = "0x9063EC0", VA = "0x1890654C0")]
	public static LCOHCCBKPLJ LGDIFLIDJBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x9065840", Offset = "0x9064240", VA = "0x189065840")]
	[UnityEngine.Scripting.Preserve]
	protected MOLHDGHNIHO([BMCONCJPCIA(null)] PHKMFNMNKJJ LKFGGFPPOFD, [BMCONCJPCIA(null)] AILPKKOGDLK OFFCJGHAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x9064AE0", Offset = "0x90634E0", VA = "0x189064AE0", Slot = "6")]
	public LCOHCCBKPLJ AEOBHGFBIDI(IEnumerator<JFFMJDIOLAN> JHBPMHGMOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x90648E0", Offset = "0x90632E0", VA = "0x1890648E0", Slot = "7")]
	public LCOHCCBKPLJ AEOBHGFBIDI(Behaviour IJNPIDPIBFP, IEnumerator<JFFMJDIOLAN> JHBPMHGMOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract LCOHCCBKPLJ MLJFNBKIIEJ(MPNBHGLOEOL IJNPIDPIBFP, IEnumerator<JFFMJDIOLAN> JHBPMHGMOII);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x9065680", Offset = "0x9064080", VA = "0x189065680", Slot = "20")]
	public virtual void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x9064FC0", Offset = "0x90639C0", VA = "0x189064FC0", Slot = "9")]
	public void GBKFCHJHGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x9064AF0", Offset = "0x90634F0", VA = "0x189064AF0", Slot = "21")]
	protected virtual void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x9065820", Offset = "0x9064220", VA = "0x189065820")]
	private void ODIKGMFDICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x90653D0", Offset = "0x9063DD0", VA = "0x1890653D0")]
	private void HLLLDHENLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x90655D0", Offset = "0x9063FD0", VA = "0x1890655D0")]
	private void LMEMHNNCCMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9065550", Offset = "0x9063F50", VA = "0x189065550")]
	private void LHFLAJOPPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x90653F0", Offset = "0x9063DF0", VA = "0x1890653F0")]
	private void JLGJGDILLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x9065410", Offset = "0x9063E10", VA = "0x189065410")]
	private void KHLBCDFOPJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x9065660", Offset = "0x9064060", VA = "0x189065660")]
	private void NPLOKKADGBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x9065430", Offset = "0x9063E30", VA = "0x189065430", Slot = "22")]
	public virtual void LGBHCBGKAOK(JHJLCHFAIBB PFJPKKCCFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x9065200", Offset = "0x9063C00", VA = "0x189065200")]
	private void GCGOOGCJFIN(MPBNEHOHPKO BLBKLKKEDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x29F56D0", Offset = "0x29F40D0", VA = "0x1829F56D0")]
	private MPBNEHOHPKO JFAJOHAJJHH(JHJLCHFAIBB DGNODDPLLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract ALAGOBMGNCE HGBAIPHJABD(IEnumerator<JFFMJDIOLAN> JHBPMHGMOII, Behaviour JMEDJALIAEG, PABKDENKBJP DOBKLBODHIO);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract MPBNEHOHPKO NCFCOGNNCLJ(JHJLCHFAIBB PFJPKKCCFAK);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x9064B10", Offset = "0x9063510", VA = "0x189064B10", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9065570", Offset = "0x9063F70", VA = "0x189065570", Slot = "15")]
	public JFFMJDIOLAN LKJINOHIAMI(JHJLCHFAIBB LBPHLNLFCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x9064ED0", Offset = "0x90638D0", VA = "0x189064ED0", Slot = "16")]
	public JFFMJDIOLAN EBHDPEGNPKD(float JHMKMDEDCJN, JHJLCHFAIBB LBPHLNLFCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x9064F60", Offset = "0x9063960", VA = "0x189064F60", Slot = "17")]
	public JFFMJDIOLAN FBAAPCJFPGO(Func<bool> HPFDJAAAMGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class ALAGOBMGNCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly PABKDENKBJP FBJNLPOFDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly POLOICIPLGK IJNPIDPIBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly bool PHGANFFAELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private string IELIBBNCJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private StackTrace HAMIIHKKDLO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerator<JFFMJDIOLAN> FNILELMICFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public JFFMJDIOLAN AOKLLGEIFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool GCNFACPFBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9057280", Offset = "0x9055C80", VA = "0x189057280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DJMGKEENDBC
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xDB85A0", Offset = "0xDB6FA0", VA = "0x180DB85A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xDD31C0", Offset = "0xDD1BC0", VA = "0x180DD31C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9057080", Offset = "0x9055A80", VA = "0x189057080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float IDPMOKLEJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xF562B0", Offset = "0xF54CB0", VA = "0x180F562B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xF562C0", Offset = "0xF54CC0", VA = "0x180F562C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x90573E0", Offset = "0x9055DE0", VA = "0x1890573E0")]
	public ALAGOBMGNCE(IEnumerator<JFFMJDIOLAN> ODNFOPMEPEI, POLOICIPLGK IJNPIDPIBFP, PABKDENKBJP FBJNLPOFDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x9056D60", Offset = "0x9055760", VA = "0x189056D60")]
	public JFFMJDIOLAN ENPPILIONMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x9056CF0", Offset = "0x90556F0", VA = "0x189056CF0")]
	public bool DLJCEILMBIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x9057230", Offset = "0x9055C30", VA = "0x189057230")]
	public void LFPMCBHAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x9057300", Offset = "0x9055D00", VA = "0x189057300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0xE2BB10", Offset = "0xE2A510", VA = "0x180E2BB10")]
	[CompilerGenerated]
	private void ANCPOPMCIDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class PABKDENKBJP : GFJMCEJGNHF, LCOHCCBKPLJ, PKHGEDPOIHB, CNBBKAECPOB, IEnumerator, JFFMJDIOLAN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private JHJLCHFAIBB JPDEOFHGEGG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private JHJLCHFAIBB OBECEFDEIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB79590", Offset = "0xB77F90", VA = "0x180B79590", Slot = "23")]
		get
		{
			return default(JHJLCHFAIBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public JHJLCHFAIBB HMBPONPIGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x10E6E90", Offset = "0x10E5890", VA = "0x1810E6E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private float MICONEICMGB
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAFDE10", Offset = "0xAFC810", VA = "0x180AFDE10", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GALBFPBDALM
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x9068840", Offset = "0x9067240", VA = "0x189068840", Slot = "24")]
	private bool FKDIAFAMBDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x9068830", Offset = "0x9067230", VA = "0x189068830", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x9068860", Offset = "0x9067260", VA = "0x189068860")]
	public PABKDENKBJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal enum HAOPECCIMMA : byte
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
internal sealed class MPBNEHOHPKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum AOOBKMPEJKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct OMLBDMIFGGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public JHJLCHFAIBB AMBOJLNNGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AOOBKMPEJKB BHKGHLKOPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public List<ALAGOBMGNCE> LOAAJOHPAMB;
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly AOOBKMPEJKB[] LMOENCKBBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly JHJLCHFAIBB PFJPKKCCFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool CONJPNGFEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly ALAGOBMGNCE[] OFFLKMAHPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly List<ALAGOBMGNCE> DKOFHPHCKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Stack<int> PGHKIBECINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly List<ALAGOBMGNCE> PBGIFDMEJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly Stack<int> CIHGLFGAPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly AEAEJGECFPI DOCDAGMGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool PHCLLKDBNLF;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public OMLBDMIFGGM[,] FHKCDFFHDDD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x9067260", Offset = "0x9065C60", VA = "0x189067260")]
	public MPBNEHOHPKO(JHJLCHFAIBB LBPHLNLFCPC, AEAEJGECFPI DOCDAGMGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x9066900", Offset = "0x9065300", VA = "0x189066900")]
	public void MMDFLFEHKAC(ALAGOBMGNCE ODNFOPMEPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x9066A00", Offset = "0x9065400", VA = "0x189066A00")]
	public void NGCIHBMLNIM(IList<ALAGOBMGNCE> PJBEFJCJAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x9066CF0", Offset = "0x90656F0", VA = "0x189066CF0")]
	public void PBKGJLMDOFK(IList<ALAGOBMGNCE> PJBEFJCJAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x9065D30", Offset = "0x9064730", VA = "0x189065D30")]
	private void AEAHCLCGDFD(ALAGOBMGNCE ODNFOPMEPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x9065FA0", Offset = "0x90649A0", VA = "0x189065FA0")]
	private void CINAPPLMDEK(IList<ALAGOBMGNCE> PJBEFJCJAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x9065E20", Offset = "0x9064820", VA = "0x189065E20")]
	private HAOPECCIMMA BMGJFGMJJIL(ALAGOBMGNCE ODNFOPMEPEI)
	{
		return default(HAOPECCIMMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x9066120", Offset = "0x9064B20", VA = "0x189066120")]
	public void DBIPLKHEHMB(float JODOCMCKKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x9066710", Offset = "0x9065110", VA = "0x189066710")]
	public void GBKFCHJHGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x90663B0", Offset = "0x9064DB0", VA = "0x1890663B0")]
	private void EKDHJDPACLE(List<ALAGOBMGNCE> PJBEFJCJAPG, Stack<int> NLCFAIEFPPF, bool BKOLABOGOKD, float OJPHLFFDBKG = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x9066290", Offset = "0x9064C90", VA = "0x189066290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x9066FE0", Offset = "0x90659E0", VA = "0x189066FE0")]
	private void PBNFMNIKKLJ(List<ALAGOBMGNCE> PJBEFJCJAPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class NDFCGJFEJOI : AEAEJGECFPI
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void BACMEAGBFEE(string IELIBBNCJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
	public void KHDLAMHFGBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NDFCGJFEJOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal class CGPLAPFDNLG : POLOICIPLGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Behaviour JMEDJALIAEG;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9058CC0", Offset = "0x90576C0", VA = "0x189058CC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool HEAIIMNKJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x9058D60", Offset = "0x9057760", VA = "0x189058D60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DCFOKHDKMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9058D40", Offset = "0x9057740", VA = "0x189058D40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public CGPLAPFDNLG(Behaviour JMEDJALIAEG)
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

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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8E0ABD0", Offset = "0x8E09FD0", VA = "0x188E0ABD0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E12810", Offset = "0x8E11C10", VA = "0x188E12810", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
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
		private struct HABKAKGGHLH
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			[CompilerGenerated]
			private sealed class NLMDFAGHLOE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public GHMLOKDHHNN.FNDJNHGOOGG key;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
				public NLMDFAGHLOE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8E0DA20", Offset = "0x8E0CE20", VA = "0x188E0DA20")]
				internal void NFOCFCPMLDA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000002")]
			public static IDisposable CKBMGINBNAL;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8E06550", Offset = "0x8E05950", VA = "0x188E06550")]
			public static PlayerLoopSystem HIBJKENNAKH(GHMLOKDHHNN.FNDJNHGOOGG PEENICAIFOP)
			{
				return default(PlayerLoopSystem);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct IOJANIKJNHK
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class EFKPHIHBOGO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public GHMLOKDHHNN.FNDJNHGOOGG key;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
				public EFKPHIHBOGO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x8E047E0", Offset = "0x8E03BE0", VA = "0x188E047E0")]
				internal void NFOCFCPMLDA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8E07040", Offset = "0x8E06440", VA = "0x188E07040")]
			public static PlayerLoopSystem HIBJKENNAKH(GHMLOKDHHNN.FNDJNHGOOGG PEENICAIFOP)
			{
				return default(PlayerLoopSystem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly AKNCNLDICPO CCLJCJDJCOE;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8E016B0", Offset = "0x8E00AB0", VA = "0x188E016B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E02AE0", Offset = "0x8E01EE0", VA = "0x188E02AE0")]
		private static void LEONFLPOEOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8E01930", Offset = "0x8E00D30", VA = "0x188E01930")]
		private static void IGJKEAFEFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8E02680", Offset = "0x8E01A80", VA = "0x188E02680")]
		private static void KKGJHNCBPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8E01B00", Offset = "0x8E00F00", VA = "0x188E01B00")]
		private static void JGBDEFIOFGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3AE67D0", Offset = "0x3AE5BD0", VA = "0x183AE67D0")]
		private static (PlayerLoopSystem, ONAKCCJBKJI.PMKOGGEJJKO) CJCNKGGGBMJ<T>()
		{
			return default((PlayerLoopSystem, ONAKCCJBKJI.PMKOGGEJJKO));
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8E01730", Offset = "0x8E00B30", VA = "0x188E01730")]
		private static (PlayerLoopSystem, ONAKCCJBKJI.PMKOGGEJJKO) CJCNKGGGBMJ(PlayerLoopSystem PCLGMFPHHOK)
		{
			return default((PlayerLoopSystem, ONAKCCJBKJI.PMKOGGEJJKO));
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3AE64D0", Offset = "0x3AE58D0", VA = "0x183AE64D0")]
		private static (PlayerLoopSystem, ONAKCCJBKJI.PMKOGGEJJKO) CBDHBFLGDII<T>()
		{
			return default((PlayerLoopSystem, ONAKCCJBKJI.PMKOGGEJJKO));
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6950", Offset = "0x3AE5D50", VA = "0x183AE6950")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) IBDACBBJJDC<TParent, TSub>(GHMLOKDHHNN.FNDJNHGOOGG PEENICAIFOP)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8E017D0", Offset = "0x8E00BD0", VA = "0x188E017D0")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) IBDACBBJJDC(GHMLOKDHHNN.FNDJNHGOOGG PEENICAIFOP, Type JIECBJMGMAC, Type ECECLFIDICN)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GHMLOKDHHNN
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum FNDJNHGOOGG
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
	public class JBNKCIAICFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly FNDJNHGOOGG BACDLCEOLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly HPPELJIPDNO HHKJGAOMPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long BDFJEAGHKNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long NMGIOGFFONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long NFKAPHGAOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int CMDAGOLMFPA;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8E072C0", Offset = "0x8E066C0", VA = "0x188E072C0")]
		public JBNKCIAICFA(FNDJNHGOOGG BEOMJKFCDMO, int OHGBOHCKDPG = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8E072A0", Offset = "0x8E066A0", VA = "0x188E072A0")]
		public void LMOJNJDIFDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8E07170", Offset = "0x8E06570", VA = "0x188E07170")]
		public void ALHHODLEENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8E071C0", Offset = "0x8E065C0", VA = "0x188E071C0")]
		public void DNJLHABAIBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static FNDJNHGOOGG[] PDGGAEGGPBL;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static JBNKCIAICFA[] BDBGCOHABKK;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8E06100", Offset = "0x8E05500", VA = "0x188E06100")]
	public static JBNKCIAICFA MKALOJDKIBE(FNDJNHGOOGG PEENICAIFOP, int OHGBOHCKDPG = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8E06260", Offset = "0x8E05660", VA = "0x188E06260")]
	public static JBNKCIAICFA NGNFLCFGMCB(FNDJNHGOOGG PEENICAIFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8E06050", Offset = "0x8E05450", VA = "0x188E06050")]
	public static void ADEMKIAGIJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GGNGJEFKNEC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface BAPKENNEEDE
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool DFEOMMLJAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CEOCICHNPFK();
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class KJHNLMFOPBG : BAPKENNEEDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Action ENDEKEOKCCM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DFEOMMLJAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
		public KJHNLMFOPBG(Action ENDEKEOKCCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x12CE230", Offset = "0x12CD630", VA = "0x1812CE230", Slot = "5")]
		public void CEOCICHNPFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<BAPKENNEEDE> JJLINCHIHIE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool IMOLPPGMOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8E05DD0", Offset = "0x8E051D0", VA = "0x188E05DD0")]
	public static void OJMJABDGOCK(Action ENDEKEOKCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8E05AF0", Offset = "0x8E04EF0", VA = "0x188E05AF0")]
	private static void MMPPJPACPLK(BAPKENNEEDE GNJKIDIFNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8E056D0", Offset = "0x8E04AD0", VA = "0x188E056D0")]
	private static void ELFPEGAPIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8E05E70", Offset = "0x8E05270", VA = "0x188E05E70")]
	private static void OPBMOBBLMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8E059D0", Offset = "0x8E04DD0", VA = "0x188E059D0")]
	private static void GPGCOJGILAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ENHNNOEHAHO
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8E04AE0", Offset = "0x8E03EE0", VA = "0x188E04AE0")]
	public static IDisposable EFJOJGJOHJF(this DDJGNJLPCOM HFJHENFIDEF, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8E04B70", Offset = "0x8E03F70", VA = "0x188E04B70")]
	public static IDisposable EPAFENJOEJA(this DDJGNJLPCOM HFJHENFIDEF, Action<float> CNLOBIPGHEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8E04A60", Offset = "0x8E03E60", VA = "0x188E04A60")]
	public static IDisposable BIAFGOIBPME(this DDJGNJLPCOM HFJHENFIDEF, Action<float> CNLOBIPGHEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NGCDMKHDKBD
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3E5CE00", Offset = "0x3E5C200", VA = "0x183E5CE00")]
	[HKCHEMHNCJH]
	public static IDisposable DILHMGEANNL<T>(this T IAGOCCCICAO, Action CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3E5CC50", Offset = "0x3E5C050", VA = "0x183E5CC50")]
	[HKCHEMHNCJH]
	public static IDisposable DILHMGEANNL<T>(this T IAGOCCCICAO, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D3A0", Offset = "0x3E5C7A0", VA = "0x183E5D3A0")]
	[HKCHEMHNCJH]
	public static IDisposable OGELNPLKAMN<T>(this T IAGOCCCICAO, Action CNLOBIPGHEG, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E5CFA0", Offset = "0x3E5C3A0", VA = "0x183E5CFA0")]
	[HKCHEMHNCJH]
	public static IDisposable EBLNPAOEHDF<T>(this T IAGOCCCICAO, Action CNLOBIPGHEG, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E5CFA0", Offset = "0x3E5C3A0", VA = "0x183E5CFA0")]
	[HKCHEMHNCJH]
	public static IDisposable EBLNPAOEHDF<T>(this T IAGOCCCICAO, Action<float> CNLOBIPGHEG, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E5CB60", Offset = "0x3E5BF60", VA = "0x183E5CB60")]
	[HKCHEMHNCJH]
	public static IDisposable CLLFPJFJJOA<T>(this T IAGOCCCICAO, Action CNLOBIPGHEG, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D0C0", Offset = "0x3E5C4C0", VA = "0x183E5D0C0")]
	[HKCHEMHNCJH]
	public static IDisposable JAJFIAJFCFK<T>(this T IAGOCCCICAO, Action CNLOBIPGHEG, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D090", Offset = "0x3E5C490", VA = "0x183E5D090")]
	[HKCHEMHNCJH]
	public static IDisposable GCLFLNBFGCM<T>(this T IAGOCCCICAO, Action CNLOBIPGHEG, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E5CB90", Offset = "0x3E5BF90", VA = "0x183E5CB90")]
	[HKCHEMHNCJH]
	public static IDisposable DFFNNCMMKAC<T>(this T IAGOCCCICAO, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8E0D840", Offset = "0x8E0CC40", VA = "0x188E0D840")]
	[HKCHEMHNCJH]
	public static IDisposable DFFNNCMMKAC(this MonoBehaviour IAGOCCCICAO, FBNDMBMKCOM HFJHENFIDEF, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D170", Offset = "0x3E5C570", VA = "0x183E5D170")]
	[HKCHEMHNCJH]
	public static IDisposable NDKCIIFGHOI<T>(this T IAGOCCCICAO, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D3D0", Offset = "0x3E5C7D0", VA = "0x183E5D3D0")]
	[HKCHEMHNCJH]
	public static IDisposable PANGKMNCLMG<T>(this T IAGOCCCICAO, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D0F0", Offset = "0x3E5C4F0", VA = "0x183E5D0F0")]
	[HKCHEMHNCJH]
	public static IDisposable JJLMHJKDLNE<T>(this T IAGOCCCICAO, Action<float> CNLOBIPGHEG, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E5CC10", Offset = "0x3E5C010", VA = "0x183E5CC10")]
	[HKCHEMHNCJH]
	public static IDisposable DIGCOBPGJOB<T>(this T IAGOCCCICAO, Action<float> CNLOBIPGHEG, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E5CFD0", Offset = "0x3E5C3D0", VA = "0x183E5CFD0")]
	[HKCHEMHNCJH]
	public static IDisposable EJCDICOEAFE<T>(this T IAGOCCCICAO, Action<float> CNLOBIPGHEG, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3E5CBD0", Offset = "0x3E5BFD0", VA = "0x183E5CBD0")]
	[HKCHEMHNCJH]
	public static IDisposable DIBEMHLKEBG<T>(this T IAGOCCCICAO, Action<float> CNLOBIPGHEG, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D010", Offset = "0x3E5C410", VA = "0x183E5D010")]
	[HKCHEMHNCJH]
	public static IDisposable ENPMEKOOMPO<T>(this T IAGOCCCICAO, Action<float> CNLOBIPGHEG, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D130", Offset = "0x3E5C530", VA = "0x183E5D130")]
	[HKCHEMHNCJH]
	public static IDisposable LNEJGHGCFPC<T>(this T IAGOCCCICAO, Action<float> CNLOBIPGHEG, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D050", Offset = "0x3E5C450", VA = "0x183E5D050")]
	[HKCHEMHNCJH]
	public static IDisposable EOBLEMKMBGB<T>(this T IAGOCCCICAO, Action<float> CNLOBIPGHEG, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D320", Offset = "0x3E5C720", VA = "0x183E5D320")]
	[HKCHEMHNCJH]
	public static IDisposable NHIFDPHLHHG<T>(this T IAGOCCCICAO, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D360", Offset = "0x3E5C760", VA = "0x183E5D360")]
	[HKCHEMHNCJH]
	public static IDisposable NJOIBOHGHMN<T>(this T IAGOCCCICAO, Action<float> CNLOBIPGHEG, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true) where T : MonoBehaviour, FBNDMBMKCOM
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BILMLEAKOKO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class ONDOGIOAKAE : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public CANBKGNJDLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private GLFGADMKNBI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public ONDOGIOAKAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8E10E30", Offset = "0x8E10230", VA = "0x188E10E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8E10F10", Offset = "0x8E10310", VA = "0x188E10F10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class PIELICBOBKP : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CANBKGNJDLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private GLFGADMKNBI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public PIELICBOBKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8E11F70", Offset = "0x8E11370", VA = "0x188E11F70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8E12060", Offset = "0x8E11460", VA = "0x188E12060", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8E00EB0", Offset = "0x8E002B0", VA = "0x188E00EB0")]
	public static LDBPABGAEKE DILHMGEANNL(Action CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8E00D40", Offset = "0x8E00140", VA = "0x188E00D40")]
	public static LDBPABGAEKE DILHMGEANNL(Behaviour HFJHENFIDEF, Action CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8E00DD0", Offset = "0x8E001D0", VA = "0x188E00DD0")]
	public static LDBPABGAEKE DILHMGEANNL(Behaviour HFJHENFIDEF, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8E00FC0", Offset = "0x8E003C0", VA = "0x188E00FC0")]
	[IteratorStateMachine(typeof(ONDOGIOAKAE))]
	private static IEnumerator<KHJLACPAINM> KDFPNGEKGGG(CANBKGNJDLB CFNBPDBGKJF, Action CNLOBIPGHEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8E00F30", Offset = "0x8E00330", VA = "0x188E00F30")]
	[IteratorStateMachine(typeof(PIELICBOBKP))]
	private static IEnumerator<KHJLACPAINM> KDFPNGEKGGG(CANBKGNJDLB CFNBPDBGKJF, Action<float> CNLOBIPGHEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KKBJGPFFMGP : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class CBGJKKIGDKO : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public KKBJGPFFMGP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public CBGJKKIGDKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8E01100", Offset = "0x8E00500", VA = "0x188E01100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8E01190", Offset = "0x8E00590", VA = "0x188E01190", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CANBKGNJDLB EHFANNMJKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Action NLCCGNHHMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool CPMGNPFLDJC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HBLLBEFBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8E095F0", Offset = "0x8E089F0", VA = "0x188E095F0")]
	public KKBJGPFFMGP(CANBKGNJDLB EHFANNMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8E094D0", Offset = "0x8E088D0", VA = "0x188E094D0")]
	[IteratorStateMachine(typeof(CBGJKKIGDKO))]
	private IEnumerator<KHJLACPAINM> LDMEMDGJKFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8E09550", Offset = "0x8E08950", VA = "0x188E09550", Slot = "4")]
	public void OnCompleted(Action EPKFEJDGNAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	public void MLIPGIOCGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MPIIDJHNMPB
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8E0CBA0", Offset = "0x8E0BFA0", VA = "0x188E0CBA0")]
	public static KKBJGPFFMGP JNHNNPMDNOI(this CANBKGNJDLB EHFANNMJKPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class MOOBENAFBLP
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KCJOMBCCEAA : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public PNFBFIBHCKF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public KCJOMBCCEAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8E08890", Offset = "0x8E07C90", VA = "0x188E08890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8E08910", Offset = "0x8E07D10", VA = "0x188E08910", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8E0C850", Offset = "0x8E0BC50", VA = "0x188E0C850")]
	public static LDBPABGAEKE DILHMGEANNL(float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, bool HCIEDACFFLE = true, [Optional] DDDKADAKOFN AHMIDPICBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8E0C780", Offset = "0x8E0BB80", VA = "0x188E0C780")]
	public static LDBPABGAEKE DILHMGEANNL(MonoBehaviour IAGOCCCICAO, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, bool HCIEDACFFLE = true, [Optional] DDDKADAKOFN AHMIDPICBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8E0C690", Offset = "0x8E0BA90", VA = "0x188E0C690")]
	public static LDBPABGAEKE BGEAHGCEENG(MonoBehaviour IAGOCCCICAO, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, bool HCIEDACFFLE = true, [Optional] DDDKADAKOFN AHMIDPICBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8E0C920", Offset = "0x8E0BD20", VA = "0x188E0C920")]
	public static LDBPABGAEKE JMFFMMILALL(DDJGNJLPCOM HFJHENFIDEF, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, bool HCIEDACFFLE = true, [Optional] DDDKADAKOFN AHMIDPICBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8E0C9F0", Offset = "0x8E0BDF0", VA = "0x188E0C9F0")]
	private static IEnumerator<KHJLACPAINM> KDFPNGEKGGG(MPAGDHLDBDP EHBKDJIAKMM, float HCAPEIFCNHK, CANBKGNJDLB CFNBPDBGKJF, Action<float> CNLOBIPGHEG, bool HCIEDACFFLE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8E0CB40", Offset = "0x8E0BF40", VA = "0x188E0CB40")]
	private static IEnumerator<KHJLACPAINM> OFDKKEONLAD(MPAGDHLDBDP EHBKDJIAKMM, float HCAPEIFCNHK, CANBKGNJDLB CFNBPDBGKJF, Action<float> CNLOBIPGHEG, bool HCIEDACFFLE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8E0CAB0", Offset = "0x8E0BEB0", VA = "0x188E0CAB0")]
	[IteratorStateMachine(typeof(KCJOMBCCEAA))]
	private static IEnumerator<KHJLACPAINM> NOOMEGAJECB(PNFBFIBHCKF CCKMLNAFBIC, float HCAPEIFCNHK, CANBKGNJDLB CFNBPDBGKJF, Action<float> CNLOBIPGHEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class IOGMCIKDDJO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class FKDJKJOHLMK : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CANBKGNJDLB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public FKDJKJOHLMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8E055C0", Offset = "0x8E049C0", VA = "0x188E055C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8E05680", Offset = "0x8E04A80", VA = "0x188E05680", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8E06FB0", Offset = "0x8E063B0", VA = "0x188E06FB0")]
	[IteratorStateMachine(typeof(FKDJKJOHLMK))]
	private static IEnumerator<KHJLACPAINM> LFCNGKOAFAF(CANBKGNJDLB EHFANNMJKPH, Func<bool> BMOACCMKDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8E06ED0", Offset = "0x8E062D0", VA = "0x188E06ED0")]
	public static LDBPABGAEKE KFBEPGMEKJD(this MonoBehaviour IAGOCCCICAO, Func<bool> BMOACCMKDNJ, CANBKGNJDLB EHFANNMJKPH = CANBKGNJDLB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FFNIEDPBBMC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PBJOOMDEJEA : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CANBKGNJDLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public PBJOOMDEJEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8E10F60", Offset = "0x8E10360", VA = "0x188E10F60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8E10FD0", Offset = "0x8E103D0", VA = "0x188E10FD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JNANDOPEFMF<T> : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CANBKGNJDLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public JNANDOPEFMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x53791E0", Offset = "0x53785E0", VA = "0x1853791E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5379260", Offset = "0x5378660", VA = "0x185379260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GKBAJEFHNAK : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CANBKGNJDLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private KHJLACPAINM <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public GKBAJEFHNAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8E06470", Offset = "0x8E05870", VA = "0x188E06470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8E06500", Offset = "0x8E05900", VA = "0x188E06500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8E05170", Offset = "0x8E04570", VA = "0x188E05170")]
	[IteratorStateMachine(typeof(PBJOOMDEJEA))]
	private static IEnumerator<KHJLACPAINM> LDMEMDGJKFF(float OLCPEFOMCCM, CANBKGNJDLB CFNBPDBGKJF, Action PEHELHMLLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3C9CB20", Offset = "0x3C9BF20", VA = "0x183C9CB20")]
	[IteratorStateMachine(typeof(JNANDOPEFMF<>))]
	private static IEnumerator<KHJLACPAINM> LDMEMDGJKFF<T>(float OLCPEFOMCCM, CANBKGNJDLB CFNBPDBGKJF, Action<T> PEHELHMLLIK, T ALOONCIOJJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8E053E0", Offset = "0x8E047E0", VA = "0x188E053E0")]
	[IteratorStateMachine(typeof(GKBAJEFHNAK))]
	private static IEnumerator<KHJLACPAINM> MJNAFGAOHAL(float OLCPEFOMCCM, CANBKGNJDLB CFNBPDBGKJF, Action PEHELHMLLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8E04D30", Offset = "0x8E04130", VA = "0x188E04D30")]
	public static IDisposable EDNBCDELAFC(this MonoBehaviour IAGOCCCICAO, float OLCPEFOMCCM, Action PEHELHMLLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8E04FA0", Offset = "0x8E043A0", VA = "0x188E04FA0")]
	public static LDBPABGAEKE IOGJPOLEGIA(this MonoBehaviour IAGOCCCICAO, float OLCPEFOMCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8E04E10", Offset = "0x8E04210", VA = "0x188E04E10")]
	public static LDBPABGAEKE EDNBCDELAFC(this MonoBehaviour IAGOCCCICAO, float OLCPEFOMCCM, CANBKGNJDLB CFNBPDBGKJF, Action PEHELHMLLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8E050D0", Offset = "0x8E044D0", VA = "0x188E050D0")]
	public static LDBPABGAEKE KIBMHHDAKOD(this MonoBehaviour IAGOCCCICAO, Action PEHELHMLLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3C9CAF0", Offset = "0x3C9BEF0", VA = "0x183C9CAF0")]
	public static LDBPABGAEKE KIBMHHDAKOD<T>(this MonoBehaviour IAGOCCCICAO, Action<T> PEHELHMLLIK, T ALOONCIOJJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8E05520", Offset = "0x8E04920", VA = "0x188E05520")]
	public static LDBPABGAEKE PGMBGDOGGCK(this MonoBehaviour IAGOCCCICAO, Action PEHELHMLLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8E05030", Offset = "0x8E04430", VA = "0x188E05030")]
	public static LDBPABGAEKE KGOLGJHMALD(this MonoBehaviour IAGOCCCICAO, Action PEHELHMLLIK, [Optional] DDDKADAKOFN AHMIDPICBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8E04F00", Offset = "0x8E04300", VA = "0x188E04F00")]
	public static LDBPABGAEKE FCBCDNLDAAF(this MonoBehaviour IAGOCCCICAO, Action PEHELHMLLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8E05340", Offset = "0x8E04740", VA = "0x188E05340")]
	public static LDBPABGAEKE MHPEMOFGAKA(this MonoBehaviour IAGOCCCICAO, Action PEHELHMLLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8E04C90", Offset = "0x8E04090", VA = "0x188E04C90")]
	public static LDBPABGAEKE DCHJDDFFLNG(MonoBehaviour IAGOCCCICAO, CANBKGNJDLB EHFANNMJKPH, Action PEHELHMLLIK, [Optional] DDDKADAKOFN AHMIDPICBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C9D0", Offset = "0x3C9BDD0", VA = "0x183C9C9D0")]
	public static LDBPABGAEKE DCHJDDFFLNG<T>(MonoBehaviour IAGOCCCICAO, CANBKGNJDLB EHFANNMJKPH, Action<T> PEHELHMLLIK, T ALOONCIOJJM, [Optional] DDDKADAKOFN AHMIDPICBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8E052B0", Offset = "0x8E046B0", VA = "0x188E052B0")]
	public static LDBPABGAEKE LIHBOBBJGKB(this MonoBehaviour IAGOCCCICAO, float CBAGMNKFMBA, Action PEHELHMLLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8E04BF0", Offset = "0x8E03FF0", VA = "0x188E04BF0")]
	public static LDBPABGAEKE BJPKFKLCLJD(this MonoBehaviour IAGOCCCICAO, float CBAGMNKFMBA, Action PEHELHMLLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8E05480", Offset = "0x8E04880", VA = "0x188E05480")]
	public static LDBPABGAEKE OFGOEHMGPCE(this MonoBehaviour IAGOCCCICAO, float CBAGMNKFMBA, Action PEHELHMLLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8E05210", Offset = "0x8E04610", VA = "0x188E05210")]
	public static LDBPABGAEKE LHIHBPEEBOE(this MonoBehaviour IAGOCCCICAO, float CBAGMNKFMBA, Action PEHELHMLLIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PHHNKJHABBK : HECEKCJILHI, IEnumerable<HECEKCJILHI>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly List<HECEKCJILHI> ENMKJDPLGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool JBKBNJOHEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Action JOOPIDILEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool LJLIAGMNHJI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BGJOFCJIOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8E117A0", Offset = "0x8E10BA0", VA = "0x188E117A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action JCDNCOJILEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8E11E30", Offset = "0x8E11230", VA = "0x188E11E30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8E118E0", Offset = "0x8E10CE0", VA = "0x188E118E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8E11ED0", Offset = "0x8E112D0", VA = "0x188E11ED0")]
	public PHHNKJHABBK([Optional] Action JOOPIDILEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8E11980", Offset = "0x8E10D80", VA = "0x188E11980")]
	public void KOBMLIBBKBO(HECEKCJILHI DOLGKDINOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8E115C0", Offset = "0x8E109C0", VA = "0x188E115C0")]
	private void DOCCGAKKDJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8E11B10", Offset = "0x8E10F10", VA = "0x188E11B10", Slot = "7")]
	public bool NIHMNNIFFPP(bool KBIBIFOFAKG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8E11B20", Offset = "0x8E10F20", VA = "0x188E11B20", Slot = "8")]
	public bool NIHMNNIFFPP(Action ENDEKEOKCCM, bool KBIBIFOFAKG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8E11720", Offset = "0x8E10B20", VA = "0x188E11720", Slot = "9")]
	public IEnumerator<HECEKCJILHI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8E11720", Offset = "0x8E10B20", VA = "0x188E11720", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IDKOGHOMNFP : ACDCICDOCBD
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DAGPABCCBNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IDKOGHOMNFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DAGPABCCBNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8E02BC0", Offset = "0x8E01FC0", VA = "0x188E02BC0")]
		internal void JMKKOPELCCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LLKIAMIMAHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public IDKOGHOMNFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LLKIAMIMAHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8E02BC0", Offset = "0x8E01FC0", VA = "0x188E02BC0")]
		internal void MLFPHLOIBPN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly float KPECMPKNMCF;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8E06D90", Offset = "0x8E06190", VA = "0x188E06D90")]
	public IDKOGHOMNFP(Behaviour HFJHENFIDEF, float KPECMPKNMCF, [Optional] Action JOOPIDILEPJ, [Optional] DDDKADAKOFN AHMIDPICBPI, [Optional] MPAGDHLDBDP EHBKDJIAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8E06B70", Offset = "0x8E05F70", VA = "0x188E06B70", Slot = "9")]
	protected override bool CKDLOOOLANI(Action ENDEKEOKCCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8E06C80", Offset = "0x8E06080", VA = "0x188E06C80", Slot = "10")]
	protected override bool EIJEKFNHDKC(Action ENDEKEOKCCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HECEKCJILHI
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool BGJOFCJIOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JCDNCOJILEJ;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NIHMNNIFFPP(bool KBIBIFOFAKG = false);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NIHMNNIFFPP(Action ENDEKEOKCCM, bool KBIBIFOFAKG = false);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class ACDCICDOCBD : HECEKCJILHI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class EBDPBJACKPL : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ACDCICDOCBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public EBDPBJACKPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8E02EB0", Offset = "0x8E022B0", VA = "0x188E02EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8E02F80", Offset = "0x8E02380", VA = "0x188E02F80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Behaviour HFJHENFIDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Action JOOPIDILEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private BENMIFMGNEN GONLGEPAHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly DDDKADAKOFN AHMIDPICBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly MPAGDHLDBDP EHBKDJIAKMM;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BGJOFCJIOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1CC66C0", Offset = "0x1CC5AC0", VA = "0x181CC66C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JCDNCOJILEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8E00B70", Offset = "0x8DFFF70", VA = "0x188E00B70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8E006D0", Offset = "0x8DFFAD0", VA = "0x188E006D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8E00C10", Offset = "0x8E00010", VA = "0x188E00C10")]
	protected ACDCICDOCBD(Behaviour HFJHENFIDEF, [Optional] Action JOOPIDILEPJ, [Optional] DDDKADAKOFN AHMIDPICBPI, [Optional] MPAGDHLDBDP EHBKDJIAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8E00B10", Offset = "0x8DFFF10", VA = "0x188E00B10", Slot = "7")]
	public bool NIHMNNIFFPP(bool KBIBIFOFAKG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8E00AB0", Offset = "0x8DFFEB0", VA = "0x188E00AB0", Slot = "8")]
	public bool NIHMNNIFFPP(Action ENDEKEOKCCM, bool KBIBIFOFAKG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool CKDLOOOLANI(Action ENDEKEOKCCM);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool EIJEKFNHDKC(Action ENDEKEOKCCM);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8E00A90", Offset = "0x8DFFE90", VA = "0x188E00A90")]
	protected void LFBMDLDMOMP(Action ENDEKEOKCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8E007B0", Offset = "0x8DFFBB0", VA = "0x188E007B0")]
	protected IHCAHILICGC JKGKEOMHKDB(float DLCLIHPGOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8E00650", Offset = "0x8DFFA50", VA = "0x188E00650")]
	private void HBPLOGPJFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8E00A00", Offset = "0x8DFFE00", VA = "0x188E00A00")]
	[IteratorStateMachine(typeof(EBDPBJACKPL))]
	private IEnumerator<KHJLACPAINM> JPLBMMAHDLJ(float DLCLIHPGOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8E00770", Offset = "0x8DFFB70", VA = "0x188E00770")]
	[CompilerGenerated]
	private void ILPJDGGJHPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PMIDIPKAOML : ACDCICDOCBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly float GDPLEOAEGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int CFMFJNPAOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly float DOAMLLDJGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly float[] MLFJOPKNAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int NEFAFKHJMEN;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8E12330", Offset = "0x8E11730", VA = "0x188E12330")]
	public PMIDIPKAOML(Behaviour HFJHENFIDEF, float KMDNODBJMFM, int CFMFJNPAOLE, [Optional] Action JOOPIDILEPJ, float DOAMLLDJGDM = 0f, [Optional] DDDKADAKOFN AHMIDPICBPI, [Optional] MPAGDHLDBDP EHBKDJIAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "9")]
	protected override bool CKDLOOOLANI(Action ENDEKEOKCCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8E120B0", Offset = "0x8E114B0", VA = "0x188E120B0", Slot = "10")]
	protected override bool EIJEKFNHDKC(Action ENDEKEOKCCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8E122B0", Offset = "0x8E116B0", VA = "0x188E122B0")]
	private void LOBGMCJLEHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KGHPGNGPNLL : ACDCICDOCBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float KPECMPKNMCF;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8E06D90", Offset = "0x8E06190", VA = "0x188E06D90")]
	public KGHPGNGPNLL(Behaviour HFJHENFIDEF, float KPECMPKNMCF, [Optional] Action JOOPIDILEPJ, [Optional] DDDKADAKOFN AHMIDPICBPI, [Optional] MPAGDHLDBDP EHBKDJIAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "9")]
	protected override bool CKDLOOOLANI(Action ENDEKEOKCCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8E08960", Offset = "0x8E07D60", VA = "0x188E08960", Slot = "10")]
	protected override bool EIJEKFNHDKC(Action ENDEKEOKCCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class ECNBJFAFIDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class DHOGIMJGGOG : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public DHOGIMJGGOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8E02DF0", Offset = "0x8E021F0", VA = "0x188E02DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8E02E60", Offset = "0x8E02260", VA = "0x188E02E60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private LDBPABGAEKE IDGEKFPAEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private DDJGNJLPCOM HFJHENFIDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Action<float> IGJMCAOMIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private CANBKGNJDLB EHFANNMJKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private float NFFAHGOPJFI;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8E034D0", Offset = "0x8E028D0", VA = "0x188E034D0")]
	public ECNBJFAFIDL(DDJGNJLPCOM HFJHENFIDEF, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8E030B0", Offset = "0x8E024B0", VA = "0x188E030B0")]
	private void HKDDKJCJILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8E03220", Offset = "0x8E02620", VA = "0x188E03220")]
	private void KPLIPFNMENJ(string FKPCAPOIAIK, Action KIMGLEADDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8E02FD0", Offset = "0x8E023D0", VA = "0x188E02FD0")]
	[IteratorStateMachine(typeof(DHOGIMJGGOG))]
	private IEnumerator<KHJLACPAINM> BFMELACCIOO(Action KIMGLEADDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8E03050", Offset = "0x8E02450", VA = "0x188E03050", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8E03350", Offset = "0x8E02750", VA = "0x188E03350")]
	[CompilerGenerated]
	private void NPMHFGGNDMH(string CGMANOFIFCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class EDIMJCAKIKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LELBILHFOIE : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public LELBILHFOIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8E02DF0", Offset = "0x8E021F0", VA = "0x188E02DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8E096F0", Offset = "0x8E08AF0", VA = "0x188E096F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private LDBPABGAEKE IDGEKFPAEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private MonoBehaviour IAGOCCCICAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Action CNLOBIPGHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Action<float> IGJMCAOMIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private CANBKGNJDLB EHFANNMJKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private float NFFAHGOPJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private bool HCIEDACFFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly DDDKADAKOFN AHMIDPICBPI;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8E042A0", Offset = "0x8E036A0", VA = "0x188E042A0")]
	public EDIMJCAKIKB(MonoBehaviour IAGOCCCICAO, Action CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, [Optional] DDDKADAKOFN AHMIDPICBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8E04610", Offset = "0x8E03A10", VA = "0x188E04610")]
	public EDIMJCAKIKB(MonoBehaviour IAGOCCCICAO, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, [Optional] DDDKADAKOFN AHMIDPICBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8E04430", Offset = "0x8E03830", VA = "0x188E04430")]
	public EDIMJCAKIKB(MonoBehaviour IAGOCCCICAO, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, bool HCIEDACFFLE = true, [Optional] DDDKADAKOFN AHMIDPICBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0xED2470", Offset = "0xED1870", VA = "0x180ED2470")]
	private EDIMJCAKIKB(DDDKADAKOFN AHMIDPICBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8E03910", Offset = "0x8E02D10", VA = "0x188E03910")]
	internal static EDIMJCAKIKB CDDAFMAKCOH(MonoBehaviour IAGOCCCICAO, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, CANBKGNJDLB EHFANNMJKPH, bool HCIEDACFFLE = true, [Optional] DDDKADAKOFN AHMIDPICBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8E03C60", Offset = "0x8E03060", VA = "0x188E03C60")]
	private void DILHMGEANNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8E03F60", Offset = "0x8E03360", VA = "0x188E03F60")]
	private void JIOKOHLGFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8E03DF0", Offset = "0x8E031F0", VA = "0x188E03DF0")]
	private void HKDDKJCJILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8E03700", Offset = "0x8E02B00", VA = "0x188E03700")]
	private void AIICHDJABHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8E04170", Offset = "0x8E03570", VA = "0x188E04170")]
	private void KPLIPFNMENJ(string FKPCAPOIAIK, Action KIMGLEADDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8E03890", Offset = "0x8E02C90", VA = "0x188E03890")]
	[IteratorStateMachine(typeof(LELBILHFOIE))]
	private IEnumerator<KHJLACPAINM> BFMELACCIOO(Action KIMGLEADDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8E03D90", Offset = "0x8E03190", VA = "0x188E03D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8E03B40", Offset = "0x8E02F40", VA = "0x188E03B40")]
	[CompilerGenerated]
	private void CHEIEPJOJNA(string CGMANOFIFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8E03670", Offset = "0x8E02A70", VA = "0x188E03670")]
	[CompilerGenerated]
	private void AFJFLDDHOLM(string CGMANOFIFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8E040E0", Offset = "0x8E034E0", VA = "0x188E040E0")]
	[CompilerGenerated]
	private void KAELIGCEDFN(string CGMANOFIFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8E03BD0", Offset = "0x8E02FD0", VA = "0x188E03BD0")]
	[CompilerGenerated]
	private void CKECFKCFMGI(string CGMANOFIFCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
internal enum NMOLPKBNHAP : byte
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
internal sealed class BNEHLLEJNNA : MPAGDHLDBDP
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float LHIIPNAHAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8E010F0", Offset = "0x8E004F0", VA = "0x188E010F0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float JCCBNHDNCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8E01050", Offset = "0x8E00450", VA = "0x188E01050", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public double MMFDLCIIKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8E010D0", Offset = "0x8E004D0", VA = "0x188E010D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8E01060", Offset = "0x8E00460", VA = "0x188E01060")]
	[MKODAOGKIAA.PMDGGDAFIAI]
	internal static void IBCLJHGLFJL(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	[UnityEngine.Scripting.Preserve]
	internal BNEHLLEJNNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface EJCABDIPPLF
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHDNEEKGPLH(string HDNPPEBJPAE);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OAJINIIBKFA();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface FNHJFGINANO
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IABJMOAGIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool PNFLMOLENDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal class CMNAFKPMLCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public OIPGMHDLMLB IFBNJLEMCEJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int JHGBNCFKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8E01490", Offset = "0x8E00890", VA = "0x188E01490")]
	public static KHJLACPAINM NHOHAKMJODJ(IEnumerator<KHJLACPAINM> AMJFGLKJCEM, OAKMGDFLEAP KDLILNGLKGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8E015F0", Offset = "0x8E009F0", VA = "0x188E015F0")]
	public KHJLACPAINM NHOHAKMJODJ(OAKMGDFLEAP[] KHJGAHCJADK, IEnumerator<KHJLACPAINM>[] GEBDHCLHFAP, KHJLACPAINM[] OLLIFKAFELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8E01460", Offset = "0x8E00860", VA = "0x188E01460")]
	public void FHGDEHHNCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8E011E0", Offset = "0x8E005E0", VA = "0x188E011E0")]
	public void ABCKPJCMIPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8E01320", Offset = "0x8E00720", VA = "0x188E01320")]
	public void FGEJOIKJGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8E01460", Offset = "0x8E00860", VA = "0x188E01460")]
	public void IMAIIMDHCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CMNAFKPMLCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class OIPGMHDLMLB
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct LLDPGGBEGGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CMNAFKPMLCG IKIJIKICMNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public DDJGNJLPCOM DDEDGOAKMIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public OAKMGDFLEAP HAOGIGMBPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IEnumerator<KHJLACPAINM> CPBKPFPEJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public KHJLACPAINM GFIICJJIBKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public NMOLPKBNHAP CCKDJGALCPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct IHAOLHPLFCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public CANBKGNJDLB BHHEPKPLIDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public List<LLDPGGBEGGN> OMLJMEJBCNH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class KIPPIMBMNKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public OAKMGDFLEAP promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public OIPGMHDLMLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public DDJGNJLPCOM context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CMNAFKPMLCG routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public NMOLPKBNHAP coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public KHJLACPAINM currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public IEnumerator<KHJLACPAINM> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KIPPIMBMNKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8E08CF0", Offset = "0x8E080F0", VA = "0x188E08CF0")]
		internal void AGGCIHACGFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class LOJOOPJAOMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CMNAFKPMLCG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public OIPGMHDLMLB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LOJOOPJAOMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8E0AB90", Offset = "0x8E09F90", VA = "0x188E0AB90")]
		internal void HIJINBEKBCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class PDGMIBGALAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CMNAFKPMLCG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public OIPGMHDLMLB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PDGMIBGALAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8E11020", Offset = "0x8E10420", VA = "0x188E11020")]
		internal void MLMGAGAJHOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class OAEEBGEKFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CMNAFKPMLCG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public OIPGMHDLMLB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OAEEBGEKFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DC60", Offset = "0x8E0D060", VA = "0x188E0DC60")]
		internal void JEKAEJHPFCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const NMOLPKBNHAP CHJNJBNGPGD = NMOLPKBNHAP.Cancelled | NMOLPKBNHAP.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CANBKGNJDLB EHFANNMJKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool[] PGMLBBGCAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private NativeArray<NMOLPKBNHAP> HFBGCOCJPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private NativeArray<float> AJJPKBJACNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private NativeArray<int> MOMENGCJKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeArray<int> EFCJBJENNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<int> NCCKLKNGENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<int> LFPOODIEBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<int> JFINMDHEMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private CMNAFKPMLCG[] PGOENNELNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private OAKMGDFLEAP[] KHJGAHCJADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private DDJGNJLPCOM[] BFNPHFAOBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private IEnumerator<KHJLACPAINM>[] CBFMINCAOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private KHJLACPAINM[] LFJEEIHCBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int JLGGAAEKOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int HLNAOJHAMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly int CGIAPJBPOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private float NBGIIBNCOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private PGBNHEKGMPK PIKOCLDJCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private JobHandle IKBAICCCINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private List<CMNAFKPMLCG> EGFDIHIBKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool IKHOHGPAKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private List<Action> EKFBGAPDFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private List<Action> HLOAOIDKIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool FPGDKPPKHDF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IHAOLHPLFCP[] PPDOPLFNBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xBCDFF0", Offset = "0xBCD3F0", VA = "0x180BCDFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8E0F9C0", Offset = "0x8E0EDC0", VA = "0x188E0F9C0")]
	private static int JFDPFFEBFAH(CANBKGNJDLB EHFANNMJKPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8E107D0", Offset = "0x8E0FBD0", VA = "0x188E107D0")]
	public OIPGMHDLMLB(CANBKGNJDLB EHFANNMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8E0F0F0", Offset = "0x8E0E4F0", VA = "0x188E0F0F0")]
	private void GIIFPEFIDBM(int LBBGIBNKMCN, int PKLJCGFDBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8E0F9F0", Offset = "0x8E0EDF0", VA = "0x188E0F9F0")]
	public void JFMACNKKOPG(DDJGNJLPCOM HFJHENFIDEF, KHJLACPAINM JDNKNOJHDPG, IEnumerator<KHJLACPAINM> AMJFGLKJCEM, OAKMGDFLEAP KDLILNGLKGF, [Optional] CMNAFKPMLCG IIPPEBIHKPD, NMOLPKBNHAP OJJIJCDCJBB = NMOLPKBNHAP.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E920", Offset = "0x8E0DD20", VA = "0x188E0E920")]
	public void CJCNKGGGBMJ(IEnumerable<LLDPGGBEGGN> CBOHHMKFMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E450", Offset = "0x8E0D850", VA = "0x188E0E450")]
	private LLDPGGBEGGN AAPFIIKOELF(int FNAOLDCOKJL)
	{
		return default(LLDPGGBEGGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8E0F2D0", Offset = "0x8E0E6D0", VA = "0x188E0F2D0")]
	private void GIPBLCINGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB73C0", Offset = "0x3EB67C0", VA = "0x183EB73C0")]
	private static void EJEKJHLCNKD<T>(int FNAOLDCOKJL, T[] IHEKHNJLGBH, int MPDDFCCPIOM, [Optional] T IFDMPFFHGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7410", Offset = "0x3EB6810", VA = "0x183EB7410")]
	private static void EJEKJHLCNKD<T>(int FNAOLDCOKJL, NativeArray<T> IHEKHNJLGBH, int MPDDFCCPIOM, [Optional] T IFDMPFFHGAD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8E10440", Offset = "0x8E0F840", VA = "0x188E10440")]
	private void PKAGNEDNDJJ(IEnumerable<LLDPGGBEGGN> CBOHHMKFMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8E0F8F0", Offset = "0x8E0ECF0", VA = "0x188E0F8F0")]
	private void IOHDFGOKIKP(LLDPGGBEGGN BHMFAPOILPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8E0EB60", Offset = "0x8E0DF60", VA = "0x188E0EB60")]
	private EKLLFDDBAJP EMMCBHIJMMI(int KHEFHIDLAEI)
	{
		return default(EKLLFDDBAJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8E0EDC0", Offset = "0x8E0E1C0", VA = "0x188E0EDC0")]
	public void FGBHHFKNOLC(float DDNEMGEJNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8E0F740", Offset = "0x8E0EB40", VA = "0x188E0F740")]
	private void IFJPDAGJANI(Action HCFCOMCPJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8E0FCA0", Offset = "0x8E0F0A0", VA = "0x188E0FCA0")]
	private void KCIHDCIJABK(Action HCFCOMCPJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8E0FD20", Offset = "0x8E0F120", VA = "0x188E0FD20")]
	public void LELMDBPNEEC(float DDNEMGEJNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8E0F640", Offset = "0x8E0EA40", VA = "0x188E0F640")]
	public void HNJLALOFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8E0F7C0", Offset = "0x8E0EBC0", VA = "0x188E0F7C0")]
	public void IMAIIMDHCFG(CMNAFKPMLCG CCKMLNAFBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8E0EFC0", Offset = "0x8E0E3C0", VA = "0x188E0EFC0")]
	public void GEPJKPKHGPB(CMNAFKPMLCG CCKMLNAFBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8E0FB70", Offset = "0x8E0EF70", VA = "0x188E0FB70")]
	public void JGHLAOIBBMO(CMNAFKPMLCG CCKMLNAFBIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DANNEHFFOPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public static readonly DANNEHFFOPE BOBPMJBGCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Action GHBJIOBBNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool EGNOAKFAPLF;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public DANNEHFFOPE(Action GHBJIOBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8415860", Offset = "0x8414C60", VA = "0x188415860", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface AKPBPJFMJIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PBHECPMDCEG(UnityEngine.Object HFJHENFIDEF, Action<T> IDOPPHKOCBN);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MPFLAPMDIEN<T> : AKPBPJFMJIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	new T JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class JCLPBDCCGKA<T> : MPFLAPMDIEN<T>, AKPBPJFMJIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class PMLLLHOLKHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public JCLPBDCCGKA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public PMEIOLAILNO<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PMLLLHOLKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5B1EAB0", Offset = "0x5B1DEB0", VA = "0x185B1EAB0")]
		internal void MGDEKJNBOMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static GameObject NIPHLNCJILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<PMEIOLAILNO<UnityEngine.Object, Action<T>>> MKDEIKGJMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private T AGIHJLJLCCM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5304F10", Offset = "0x5304310", VA = "0x185304F10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5304820", Offset = "0x5303C20", VA = "0x185304820")]
	private static bool FFLBFAMEAKG(T HCFCOMCPJPA, T JOCIBENNGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5305300", Offset = "0x5304700", VA = "0x185305300")]
	public JCLPBDCCGKA(T BMFNABDHOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5305000", Offset = "0x5304400", VA = "0x185305000", Slot = "6")]
	public IDisposable PBHECPMDCEG(UnityEngine.Object HFJHENFIDEF, Action<T> IDOPPHKOCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5304910", Offset = "0x5303D10", VA = "0x185304910")]
	private void KOBIFDCDNIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class NAFHNBHDOFA : DFCJBOBNCKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class HPFHKCBCKAD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class LEAOIKILJGB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int CLNGGGMIBPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private HPFHKCBCKAD CFNBPDBGKJF;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x102F000", Offset = "0x102E400", VA = "0x18102F000")]
			public LEAOIKILJGB(int CLNGGGMIBPI, HPFHKCBCKAD CFNBPDBGKJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8E096C0", Offset = "0x8E08AC0", VA = "0x188E096C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class BONDLFMCINO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public BONDLFMCINO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool JFMKEEOJIEF(OFIAGJPBHBO e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class KHLACHHGCHF : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private KHJLACPAINM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public HPFHKCBCKAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public MPAGDHLDBDP timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private GLFGADMKNBI <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private List<OFIAGJPBHBO> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
			[DebuggerHidden]
			public KHLACHHGCHF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x8E089A0", Offset = "0x8E07DA0", VA = "0x188E089A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x8E08CA0", Offset = "0x8E080A0", VA = "0x188E08CA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly CANBKGNJDLB EHFANNMJKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private LDBPABGAEKE KDLILNGLKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly List<OFIAGJPBHBO> NMFJIONMIMH;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8E06AD0", Offset = "0x8E05ED0", VA = "0x188E06AD0")]
		public HPFHKCBCKAD(CANBKGNJDLB EHFANNMJKPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8E068F0", Offset = "0x8E05CF0", VA = "0x188E068F0")]
		public IDisposable LLIINHIJLKJ(OFIAGJPBHBO NJINJFNEMJI, DDDKADAKOFN AHMIDPICBPI, MPAGDHLDBDP LLOEFCNKADN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8E06680", Offset = "0x8E05A80", VA = "0x188E06680")]
		private void AOPIKPCPJPF(int CLNGGGMIBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8E06860", Offset = "0x8E05C60", VA = "0x188E06860")]
		[IteratorStateMachine(typeof(KHLACHHGCHF))]
		private IEnumerator<KHJLACPAINM> KDFPNGEKGGG(MPAGDHLDBDP LLOEFCNKADN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8E06810", Offset = "0x8E05C10", VA = "0x188E06810", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class OFIAGJPBHBO
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public enum BNLMCJDOELL : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static int NHFJFLLBGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int NGBODNHEHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly FBNDMBMKCOM DDEDGOAKMIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly MonoBehaviour JNEKLBGFHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly Action OGELNPLKAMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly Action<float> FOPPCIGCMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly float HEFEOLMIFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public float AJJPKBJACNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly string GODGCHFEMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly bool OJDKABJCKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly BNLMCJDOELL OIGHOODGLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool CLKKKDPCKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public bool LPBIJBGJFMP;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E0F0", Offset = "0x8E0D4F0", VA = "0x188E0E0F0")]
		public OFIAGJPBHBO(FBNDMBMKCOM HFJHENFIDEF, Action CNLOBIPGHEG, bool BHLFLBGBDII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DF70", Offset = "0x8E0D370", VA = "0x188E0DF70")]
		public OFIAGJPBHBO(FBNDMBMKCOM HFJHENFIDEF, Action<float> CNLOBIPGHEG, bool BHLFLBGBDII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E270", Offset = "0x8E0D670", VA = "0x188E0E270")]
		public OFIAGJPBHBO(FBNDMBMKCOM HFJHENFIDEF, float HCAPEIFCNHK, Action<float> CNLOBIPGHEG, MPAGDHLDBDP LLOEFCNKADN, BNLMCJDOELL LONOFNKGNLP, bool HCIEDACFFLE, bool BHLFLBGBDII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DD20", Offset = "0x8E0D120", VA = "0x188E0DD20")]
		public bool MBKPJEAMFPA(float GIKDKPMHFDA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly DDDKADAKOFN AHMIDPICBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly MPAGDHLDBDP EHBKDJIAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<CANBKGNJDLB, HPFHKCBCKAD> MCBIANDLIAL;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8E0CE70", Offset = "0x8E0C270", VA = "0x188E0CE70")]
	[MKODAOGKIAA.PMDGGDAFIAI]
	internal static void GPEOGODLDIH(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8E0D780", Offset = "0x8E0CB80", VA = "0x188E0D780")]
	[UnityEngine.Scripting.Preserve]
	internal NAFHNBHDOFA([PKIHAALFADL(null)] DDDKADAKOFN AHMIDPICBPI, [PKIHAALFADL(null)] MPAGDHLDBDP EHBKDJIAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8E0D020", Offset = "0x8E0C420", VA = "0x188E0D020", Slot = "4")]
	public IDisposable OGELNPLKAMN(FBNDMBMKCOM HFJHENFIDEF, Action BFDLNHAHOHH, CANBKGNJDLB EHFANNMJKPH, bool BHLFLBGBDII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8E0D210", Offset = "0x8E0C610", VA = "0x188E0D210", Slot = "5")]
	public IDisposable OGELNPLKAMN(FBNDMBMKCOM HFJHENFIDEF, Action<float> BFDLNHAHOHH, CANBKGNJDLB EHFANNMJKPH, bool BHLFLBGBDII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8E0D400", Offset = "0x8E0C800", VA = "0x188E0D400", Slot = "7")]
	public IDisposable PANGKMNCLMG(FBNDMBMKCOM HFJHENFIDEF, float HCAPEIFCNHK, Action<float> BFDLNHAHOHH, CANBKGNJDLB EHFANNMJKPH, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8E0D680", Offset = "0x8E0CA80", VA = "0x188E0D680", Slot = "8")]
	public IDisposable POKFOLGAELF(FBNDMBMKCOM HFJHENFIDEF, float HCAPEIFCNHK, Action<float> BFDLNHAHOHH, CANBKGNJDLB EHFANNMJKPH, bool HCIEDACFFLE = true, bool BHLFLBGBDII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8E0D500", Offset = "0x8E0C900", VA = "0x188E0D500", Slot = "6")]
	public IDisposable PANGKMNCLMG(float HCAPEIFCNHK, Action<float> BFDLNHAHOHH, bool HCIEDACFFLE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8E0CCB0", Offset = "0x8E0C0B0", VA = "0x188E0CCB0", Slot = "9")]
	public void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8E0CEE0", Offset = "0x8E0C2E0", VA = "0x188E0CEE0")]
	private HPFHKCBCKAD ILJMJKODBIK(CANBKGNJDLB EHFANNMJKPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class JJFMAJDMOPF : LLAAENOPFHE, DDDKADAKOFN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private OIPGMHDLMLB[] KFHFDBNMNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private EJCABDIPPLF JNMOGNHJIBM;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8E07A60", Offset = "0x8E06E60", VA = "0x188E07A60")]
	[MKODAOGKIAA.PMDGGDAFIAI]
	internal static void IBCLJHGLFJL(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8E07F20", Offset = "0x8E07320", VA = "0x188E07F20")]
	[UnityEngine.Scripting.Preserve]
	public JJFMAJDMOPF([PKIHAALFADL(null)] LEIHEGCHIKI DGBCJOGEAHI, [PKIHAALFADL(null)] MPAGDHLDBDP EHBKDJIAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8E07350", Offset = "0x8E06750", VA = "0x188E07350", Slot = "19")]
	public override LDBPABGAEKE BEBFFNKHKGO(DDJGNJLPCOM HFJHENFIDEF, IEnumerator<KHJLACPAINM> OOMNJJJENPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8E076B0", Offset = "0x8E06AB0", VA = "0x188E076B0", Slot = "20")]
	public override void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8E07480", Offset = "0x8E06880", VA = "0x188E07480", Slot = "22")]
	public override void CAPODMHIMGB(CANBKGNJDLB EHFANNMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8E07E50", Offset = "0x8E07250", VA = "0x188E07E50", Slot = "21")]
	protected override void OGELNPLKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8E07E20", Offset = "0x8E07220", VA = "0x188E07E20")]
	private OIPGMHDLMLB KHGDNFCANED(CANBKGNJDLB IIHAKBEOLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8E07BF0", Offset = "0x8E06FF0", VA = "0x188E07BF0", Slot = "23")]
	internal override JKBMMMODHDC JKNDKKIMLND(IEnumerator<KHJLACPAINM> OOMNJJJENPN, Behaviour HFJHENFIDEF, OAKMGDFLEAP KDLILNGLKGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8E07940", Offset = "0x8E06D40", VA = "0x188E07940", Slot = "24")]
	internal override MCCAFDFNKPG DHOHCMOFODP(CANBKGNJDLB CFNBPDBGKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8E07AD0", Offset = "0x8E06ED0", VA = "0x188E07AD0")]
	private void IMMMGALOAAK(OIPGMHDLMLB FIOPKLFHHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8E07A00", Offset = "0x8E06E00", VA = "0x188E07A00", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[BurstCompile]
internal struct PGBNHEKGMPK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[ReadOnly]
	public float GCNEBINEPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[ReadOnly]
	public int FBFHGNPFEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> DBPEDIFKMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeArray<int> LJIPMLJDCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<int> JEMHAJAGMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	public NativeArray<NMOLPKBNHAP> ONEHCBLILBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	public NativeArray<float> NEIFABGDCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[WriteOnly]
	public NativeArray<int> NCCKLKNGENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[WriteOnly]
	public NativeArray<int> MOMENGCJKEM;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8E11060", Offset = "0x8E10460", VA = "0x188E11060")]
	public static PGBNHEKGMPK CEOONNIFPHP(int EHDKIFHHKEB, float DDNEMGEJNEH, NativeArray<NMOLPKBNHAP> EJCBOOIMCHE, NativeArray<float> ALLACOAKGFH, NativeArray<int> DOMAJNIOLCI, NativeArray<int> HJBDCHJKJCK, NativeArray<int> IMNJAJCCAGL, NativeArray<int> LJIPMLJDCGF, NativeArray<int> JEMHAJAGMEP)
	{
		return default(PGBNHEKGMPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8E110C0", Offset = "0x8E104C0", VA = "0x188E110C0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8E11410", Offset = "0x8E10810", VA = "0x188E11410")]
	private bool LDFCGKLKMLK(int NOEININIMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8E113E0", Offset = "0x8E107E0", VA = "0x188E113E0")]
	private void JMHMEOJPHOH(NativeArray<int> OLEJLIDKEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8E11450", Offset = "0x8E10850", VA = "0x188E11450")]
	private int MDAKIEILNBF(int KLIIPFJJGGE, int GBIMMKJPIOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8E114F0", Offset = "0x8E108F0", VA = "0x188E114F0")]
	private void OGGOPOMGKAK(NativeArray<int> OLEJLIDKEEL, int NOPJEEFIKJG, int GDOMDKGJNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8E111A0", Offset = "0x8E105A0", VA = "0x188E111A0")]
	private void IOFNEJKDPOD(NativeArray<int> OLEJLIDKEEL, int OMFMAHPCMMC, int FKCOFDIMFIB, int IPCGJOIBDEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class LLAAENOPFHE : DDDKADAKOFN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly LEIHEGCHIKI DGBCJOGEAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	protected readonly MPAGDHLDBDP EHBKDJIAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private MCCAFDFNKPG[] ADMNBONHENI;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static DDDKADAKOFN NKAKNKMIPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8E09C40", Offset = "0x8E09040", VA = "0x188E09C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool OEKNIBMILKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public CANBKGNJDLB BLDHNBJMNJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(CANBKGNJDLB);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public MPAGDHLDBDP NHLBHBENHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KHJLACPAINM LAMHDKKHJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public KHJLACPAINM PGNOOGHMFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public KHJLACPAINM DMNJAJNOPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KHJLACPAINM GOPCDABOOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8E09CB0", Offset = "0x8E090B0", VA = "0x188E09CB0")]
	public static LDBPABGAEKE DCPKIFAJMJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A6A0", Offset = "0x8E09AA0", VA = "0x188E0A6A0")]
	[UnityEngine.Scripting.Preserve]
	protected LLAAENOPFHE([PKIHAALFADL(null)] LEIHEGCHIKI DGBCJOGEAHI, [PKIHAALFADL(null)] MPAGDHLDBDP EHBKDJIAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8E09C30", Offset = "0x8E09030", VA = "0x188E09C30", Slot = "6")]
	public LDBPABGAEKE COBMPGJIBLC(IEnumerator<KHJLACPAINM> OOMNJJJENPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8E09A30", Offset = "0x8E08E30", VA = "0x188E09A30", Slot = "7")]
	public LDBPABGAEKE COBMPGJIBLC(Behaviour HFJHENFIDEF, IEnumerator<KHJLACPAINM> OOMNJJJENPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract LDBPABGAEKE BEBFFNKHKGO(DDJGNJLPCOM HFJHENFIDEF, IEnumerator<KHJLACPAINM> OOMNJJJENPN);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8E09890", Offset = "0x8E08C90", VA = "0x188E09890", Slot = "20")]
	public virtual void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A1F0", Offset = "0x8E095F0", VA = "0x188E0A1F0", Slot = "9")]
	public void KBDJLJJEMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A620", Offset = "0x8E09A20", VA = "0x188E0A620", Slot = "21")]
	protected virtual void OGELNPLKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A600", Offset = "0x8E09A00", VA = "0x188E0A600")]
	private void OFGEJKILABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A1B0", Offset = "0x8E095B0", VA = "0x188E0A1B0")]
	private void HEABKJMDEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A100", Offset = "0x8E09500", VA = "0x188E0A100")]
	private void EBLNPAOEHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8E09870", Offset = "0x8E08C70", VA = "0x188E09870")]
	private void CLLFPJFJJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A1D0", Offset = "0x8E095D0", VA = "0x188E0A1D0")]
	private void HJLAKPHFLFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8E097C0", Offset = "0x8E08BC0", VA = "0x188E097C0")]
	private void BNNKHNIGPEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8E09740", Offset = "0x8E08B40", VA = "0x188E09740")]
	private void BEBEDAOJALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8E097E0", Offset = "0x8E08BE0", VA = "0x188E097E0", Slot = "22")]
	public virtual void CAPODMHIMGB(CANBKGNJDLB EHFANNMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A430", Offset = "0x8E09830", VA = "0x188E0A430")]
	private void KKGIMKDEDNN(MCCAFDFNKPG FIOPKLFHHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2947810", Offset = "0x2946C10", VA = "0x182947810")]
	private MCCAFDFNKPG FBFHEHLLICJ(CANBKGNJDLB IIHAKBEOLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract JKBMMMODHDC JKNDKKIMLND(IEnumerator<KHJLACPAINM> OOMNJJJENPN, Behaviour IAGOCCCICAO, OAKMGDFLEAP GPMICLEIFAN);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract MCCAFDFNKPG DHOHCMOFODP(CANBKGNJDLB EHFANNMJKPH);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8E09D40", Offset = "0x8E09140", VA = "0x188E09D40", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8E09760", Offset = "0x8E08B60", VA = "0x188E09760", Slot = "15")]
	public KHJLACPAINM BLFEFEHFMPM(CANBKGNJDLB CFNBPDBGKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A120", Offset = "0x8E09520", VA = "0x188E0A120", Slot = "16")]
	public KHJLACPAINM FKHPBEBIAFK(float OLCPEFOMCCM, CANBKGNJDLB CFNBPDBGKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A640", Offset = "0x8E09A40", VA = "0x188E0A640", Slot = "17")]
	public KHJLACPAINM PJPPBANEKOM(Func<bool> BMOACCMKDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class JKBMMMODHDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly OAKMGDFLEAP KDLILNGLKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly FNHJFGINANO HFJHENFIDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly bool MOJPLDPLNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private string HDNPPEBJPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private StackTrace BLJKLJBOGEP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerator<KHJLACPAINM> CPBKPFPEJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public KHJLACPAINM GFIICJJIBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool GIOLNIGJPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8E07FE0", Offset = "0x8E073E0", VA = "0x188E07FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool EMILJEKKBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xD315F0", Offset = "0xD309F0", VA = "0x180D315F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xD58890", Offset = "0xD57C90", VA = "0x180D58890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8E08440", Offset = "0x8E07840", VA = "0x188E08440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float KKEFGBMGHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xEEE240", Offset = "0xEED640", VA = "0x180EEE240")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xEEE250", Offset = "0xEED650", VA = "0x180EEE250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8E086D0", Offset = "0x8E07AD0", VA = "0x188E086D0")]
	public JKBMMMODHDC(IEnumerator<KHJLACPAINM> AMJFGLKJCEM, FNHJFGINANO HFJHENFIDEF, OAKMGDFLEAP KDLILNGLKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8E08120", Offset = "0x8E07520", VA = "0x188E08120")]
	public KHJLACPAINM NHOHAKMJODJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8E080B0", Offset = "0x8E074B0", VA = "0x188E080B0")]
	public bool NGJNJGBJBOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8E08060", Offset = "0x8E07460", VA = "0x188E08060")]
	public void IMAIIMDHCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8E085F0", Offset = "0x8E079F0", VA = "0x188E085F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0xDC6260", Offset = "0xDC5660", VA = "0x180DC6260")]
	[CompilerGenerated]
	private void NAMHPOCBNFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class OAKMGDFLEAP : PGICHMGLAEF, LDBPABGAEKE, BENMIFMGNEN, IHCAHILICGC, IEnumerator, KHJLACPAINM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private CANBKGNJDLB MPHOIHGPPIL;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private CANBKGNJDLB BJINJEIKCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB1EC90", Offset = "0xB1E090", VA = "0x180B1EC90", Slot = "23")]
		get
		{
			return default(CANBKGNJDLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public CANBKGNJDLB IFBNJLEMCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1073DD0", Offset = "0x10731D0", VA = "0x181073DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private float IHAKOEPEGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAC00C0", Offset = "0xABF4C0", VA = "0x180AC00C0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool CHJKBKBFODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8E0DCB0", Offset = "0x8E0D0B0", VA = "0x188E0DCB0", Slot = "24")]
	private bool OADCCHHHMIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8E0DCA0", Offset = "0x8E0D0A0", VA = "0x188E0DCA0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8E0DCD0", Offset = "0x8E0D0D0", VA = "0x188E0DCD0")]
	public OAKMGDFLEAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal enum EKLLFDDBAJP : byte
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
internal sealed class MCCAFDFNKPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum BBMEEDFEIEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct DMMABMEJODP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public CANBKGNJDLB BHHEPKPLIDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public BBMEEDFEIEO ILNOPEBDPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public List<JKBMMMODHDC> ANHIGMJEFHC;
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly BBMEEDFEIEO[] MMKIFJJFJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly CANBKGNJDLB EHFANNMJKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool LGKFMKOJBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly JKBMMMODHDC[] JGPGCBPAJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly List<JKBMMMODHDC> MBHEOOJEMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Stack<int> JBAAEPJCAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly List<JKBMMMODHDC> FJFCFGGBGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly Stack<int> FAMBCLDFKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly EJCABDIPPLF PEPMJLKFDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool FPGDKPPKHDF;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DMMABMEJODP[,] KPPNJCLALME
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8E0C1E0", Offset = "0x8E0B5E0", VA = "0x188E0C1E0")]
	public MCCAFDFNKPG(CANBKGNJDLB CFNBPDBGKJF, EJCABDIPPLF PEPMJLKFDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8E0AF00", Offset = "0x8E0A300", VA = "0x188E0AF00")]
	public void FIBKFMLALIA(JKBMMMODHDC AMJFGLKJCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8E0BDC0", Offset = "0x8E0B1C0", VA = "0x188E0BDC0")]
	public void OLCJJIOIGLA(IList<JKBMMMODHDC> GEBDHCLHFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B010", Offset = "0x8E0A410", VA = "0x188E0B010")]
	public void GMIPKBBJEOA(IList<JKBMMMODHDC> GEBDHCLHFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8E0BC70", Offset = "0x8E0B070", VA = "0x188E0BC70")]
	private void OJEELNGCIHC(JKBMMMODHDC AMJFGLKJCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B2F0", Offset = "0x8E0A6F0", VA = "0x188E0B2F0")]
	private void JAJDIJFOOAK(IList<JKBMMMODHDC> GEBDHCLHFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8E0AC60", Offset = "0x8E0A060", VA = "0x188E0AC60")]
	private EKLLFDDBAJP DMCEBFLEBIC(JKBMMMODHDC AMJFGLKJCEM)
	{
		return default(EKLLFDDBAJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8E0BB00", Offset = "0x8E0AF00", VA = "0x188E0BB00")]
	public void OGELNPLKAMN(float DDNEMGEJNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B470", Offset = "0x8E0A870", VA = "0x188E0B470")]
	public void KBDJLJJEMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B660", Offset = "0x8E0AA60", VA = "0x188E0B660")]
	private void KNEJFKPFNLB(List<JKBMMMODHDC> GEBDHCLHFAP, Stack<int> GJNGDEAMFON, bool OOONIGPMDPJ, float CCBAGGMJHAE = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8E0ADE0", Offset = "0x8E0A1E0", VA = "0x188E0ADE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B9C0", Offset = "0x8E0ADC0", VA = "0x188E0B9C0")]
	private void MPCDMFEDFGF(List<JKBMMMODHDC> GEBDHCLHFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class OPHMIDKNNLB : EJCABDIPPLF
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void DHDNEEKGPLH(string HDNPPEBJPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
	public void OAJINIIBKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OPHMIDKNNLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal class DEPMLIMKNKA : FNHJFGINANO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Behaviour IAGOCCCICAO;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8E02D70", Offset = "0x8E02170", VA = "0x188E02D70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool IABJMOAGIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8E02D20", Offset = "0x8E02120", VA = "0x188E02D20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PNFLMOLENDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8E02D00", Offset = "0x8E02100", VA = "0x188E02D00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public DEPMLIMKNKA(Behaviour IAGOCCCICAO)
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

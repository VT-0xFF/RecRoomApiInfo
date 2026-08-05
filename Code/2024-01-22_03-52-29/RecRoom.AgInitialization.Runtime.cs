using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class DJDDNOAEDPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public DJDDNOAEDPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5ED34E0", Offset = "0x5ED28E0", VA = "0x185ED34E0")]
			internal IEnumerable<MethodInfo> ELJNIMLJCGP(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5ED35A0", Offset = "0x5ED29A0", VA = "0x185ED35A0")]
			internal bool JKPCHGDEFJA(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class GFCHKMFPDFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public GFCHKMFPDFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5ED3650", Offset = "0x5ED2A50", VA = "0x185ED3650")]
			internal bool NPDCHJGIHLG(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class ECALFJJBEMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public ECALFJJBEMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5ED3600", Offset = "0x5ED2A00", VA = "0x185ED3600")]
			internal bool GICPPGBJHIO(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<HCKINNNGEKD, IGrouping<HCKINNNGEKD, MethodInfo>> IDEDEOBHKEG;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type HBLBAEEILIK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4190", Offset = "0x5ED3590", VA = "0x185ED4190")]
		private static void JALCMKEJGLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4F30", Offset = "0x5ED4330", VA = "0x185ED4F30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5ED36B0", Offset = "0x5ED2AB0", VA = "0x185ED36B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5ED37A0", Offset = "0x5ED2BA0", VA = "0x185ED37A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3750", Offset = "0x5ED2B50", VA = "0x185ED3750")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3700", Offset = "0x5ED2B00", VA = "0x185ED3700")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3A90", Offset = "0x5ED2E90", VA = "0x185ED3A90")]
		private static void FJMHHGLPPBK(HCKINNNGEKD FGIJNMFLOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3890", Offset = "0x5ED2C90", VA = "0x185ED3890")]
		private static IEnumerable<MethodInfo> CJHNBGFDGED(Type AGCECHKGCHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4E10", Offset = "0x5ED4210", VA = "0x185ED4E10")]
		private static bool PDOHBDEDPJF(string CJPNODEEJDD, [Out] Dictionary<string, List<string>> OFNOKOJPOIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4700", Offset = "0x5ED3B00", VA = "0x185ED4700")]
		private static IEnumerable<Type> NJNCEEOPGPK(Dictionary<string, List<string>> OFNOKOJPOIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3920", Offset = "0x5ED2D20", VA = "0x185ED3920")]
		private static IEnumerable<MethodInfo> CNDLFFJFNGP(IEnumerable<Type> IKKOEHIEGHA, Type AGCECHKGCHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3A00", Offset = "0x5ED2E00", VA = "0x185ED3A00")]
		internal static IEnumerable<MethodInfo> EGPDCKALBNK(HCKINNNGEKD FGIJNMFLOEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3C70", Offset = "0x5ED3070", VA = "0x185ED3C70")]
		internal static void IPPGDCMFIOI(IEnumerable<MethodInfo> JIAIIEPCEED, Type IFKHNHOJIBC, [Optional] object[] LALAKJLPIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED37F0", Offset = "0x5ED2BF0", VA = "0x185ED37F0")]
		private static Dictionary<HCKINNNGEKD, IGrouping<HCKINNNGEKD, MethodInfo>> CDFIKBLFLDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3B50", Offset = "0x5ED2F50", VA = "0x185ED3B50")]
		private static bool HIELBILOLHN(MethodInfo FIKMMFBFNBO, Type JOFCFBPKPMC, bool FGKLCLOOPPJ)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CPNLGHONBOK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> JBPNHELCHPC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> EBGKPPEBPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1F20", Offset = "0x5ED1320", VA = "0x185ED1F20")]
		get
		{
			return null;
		}
	}
}
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5090", Offset = "0x5ED4490", VA = "0x185ED5090")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DIDOAFGHKGG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct NOJMENHJABD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo HLMBELEIINM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public BMBIBJGPNHE NJCHDBBJIGC;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<DFKMKBBAPPA, List<NOJMENHJABD>> DGPNBIKGHMD;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static DFNLNAANFCD DMGBBFCAHDG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DFNLNAANFCD LOHGPHCNDJP;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static DFNLNAANFCD OIEDGNFNNID;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static DFNLNAANFCD KCJODJNNHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3410", Offset = "0x5ED2810", VA = "0x185ED3410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DFNLNAANFCD LLBOBEBBNNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5ED33D0", Offset = "0x5ED27D0", VA = "0x185ED33D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static DFNLNAANFCD GELPOJNFFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3390", Offset = "0x5ED2790", VA = "0x185ED3390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2210", Offset = "0x5ED1610", VA = "0x185ED2210")]
	[LECNCLCOEPH]
	private static void EPFEKBEKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5ED22C0", Offset = "0x5ED16C0", VA = "0x185ED22C0")]
	[PFGHMHCOGDP(HCKINNNGEKD.Unity_AfterAssembliesLoaded)]
	private static void GNNDNEJGGCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2680", Offset = "0x5ED1A80", VA = "0x185ED2680")]
	public static DFNLNAANFCD KDILJKIOAGC(DFKMKBBAPPA EAGMHPCBPBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2CB0", Offset = "0x5ED20B0", VA = "0x185ED2CB0")]
	private static void KDILJKIOAGC(DFKMKBBAPPA EAGMHPCBPBI, DFNLNAANFCD OLCELFOCNFE, DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5ED28C0", Offset = "0x5ED1CC0", VA = "0x185ED28C0")]
	private static void KDILJKIOAGC(DFKMKBBAPPA EAGMHPCBPBI, DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2560", Offset = "0x5ED1960", VA = "0x185ED2560")]
	public static void IEBIDPEPPFG(DFKMKBBAPPA EAGMHPCBPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x217EDA0", Offset = "0x217E1A0", VA = "0x18217EDA0")]
	private static bool AJNBOANBIKM(BMBIBJGPNHE LKOJNHCIKFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5ED20A0", Offset = "0x5ED14A0", VA = "0x185ED20A0")]
	private static DFNLNAANFCD CLBEPMGIGCH(string BKMOHJHGGJB, [Optional] DFNLNAANFCD OLCELFOCNFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2390", Offset = "0x5ED1790", VA = "0x185ED2390")]
	private static void IEBIDPEPPFG(DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2210", Offset = "0x5ED1610", VA = "0x185ED2210")]
	private static void FDKFDABFOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2DF0", Offset = "0x5ED21F0", VA = "0x185ED2DF0")]
	private static IEnumerable<NOJMENHJABD> KFGPFBGDOHB(DFKMKBBAPPA EAGMHPCBPBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1FE0", Offset = "0x5ED13E0", VA = "0x185ED1FE0")]
	private static DFNLNAANFCD BMBHBKDCACE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KCAPBPIPOGH<T> : IDisposable where T : KCAPBPIPOGH<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T JDMDDMDPEKF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T OKALMGBNAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3B2AE50", Offset = "0x3B2A250", VA = "0x183B2AE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	protected KCAPBPIPOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3B2B110", Offset = "0x3B2A510", VA = "0x183B2B110", Slot = "5")]
	public virtual void Dispose()
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

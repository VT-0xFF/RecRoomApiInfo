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
		private sealed class AJOLEEPCFEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public AJOLEEPCFEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5FC60B0", Offset = "0x5FC4CB0", VA = "0x185FC60B0")]
			internal IEnumerable<MethodInfo> DDDJIDOKBIO(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6170", Offset = "0x5FC4D70", VA = "0x185FC6170")]
			internal bool JJDPLMAHIIM(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class GCJLNCEIABC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public GCJLNCEIABC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5FC7790", Offset = "0x5FC6390", VA = "0x185FC7790")]
			internal bool MCPJNFCMFGI(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class OGJCNALCPII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public OGJCNALCPII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5FC77F0", Offset = "0x5FC63F0", VA = "0x185FC77F0")]
			internal bool GPIEJCBDEIO(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<DPDOCNKHIKA, IGrouping<DPDOCNKHIKA, MethodInfo>> EBJJLKLEIFH;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type DKKODBDFNGD;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7BF0", Offset = "0x5FC67F0", VA = "0x185FC7BF0")]
		private static void HBLNLOPEMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5FC90C0", Offset = "0x5FC7CC0", VA = "0x185FC90C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7960", Offset = "0x5FC6560", VA = "0x185FC7960")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7B10", Offset = "0x5FC6710", VA = "0x185FC7B10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7AC0", Offset = "0x5FC66C0", VA = "0x185FC7AC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5FC79B0", Offset = "0x5FC65B0", VA = "0x185FC79B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7A00", Offset = "0x5FC6600", VA = "0x185FC7A00")]
		private static void BLMEJGNBDLK(DPDOCNKHIKA CGNCJHKOLIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8160", Offset = "0x5FC6D60", VA = "0x185FC8160")]
		private static IEnumerable<MethodInfo> IDPFHFDOLJJ(Type MJPOGDJDFJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FC82D0", Offset = "0x5FC6ED0", VA = "0x185FC82D0")]
		private static bool LDBOKABBGEI(string IGPMOPJKCFF, [Out] Dictionary<string, List<string>> HNAMDLNPPJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC89B0", Offset = "0x5FC75B0", VA = "0x185FC89B0")]
		private static IEnumerable<Type> PMGPMDHKJMD(Dictionary<string, List<string>> HNAMDLNPPJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC81F0", Offset = "0x5FC6DF0", VA = "0x185FC81F0")]
		private static IEnumerable<MethodInfo> JOBEMIJOKDK(IEnumerable<Type> LMFEGAKILJJ, Type MJPOGDJDFJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7B60", Offset = "0x5FC6760", VA = "0x185FC7B60")]
		internal static IEnumerable<MethodInfo> GECLMDAFBEA(DPDOCNKHIKA CGNCJHKOLIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC83F0", Offset = "0x5FC6FF0", VA = "0x185FC83F0")]
		internal static void NPJOCFIFEEC(IEnumerable<MethodInfo> JJKDJCNFDBP, Type OLHDIFKCGCN, [Optional] object[] ADOFCKCMGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8910", Offset = "0x5FC7510", VA = "0x185FC8910")]
		private static Dictionary<DPDOCNKHIKA, IGrouping<DPDOCNKHIKA, MethodInfo>> PEEJJBGOIBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7840", Offset = "0x5FC6440", VA = "0x185FC7840")]
		private static bool AANPHGNDDME(MethodInfo GJBHNELJODG, Type PBIMCMCMNGI, bool IEGBHDHAENE)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DDLAJBMEMNF
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> PJEGNFKLEDI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> CLPMLFBFMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC61D0", Offset = "0x5FC4DD0", VA = "0x185FC61D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FC9220", Offset = "0x5FC7E20", VA = "0x185FC9220")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FCHBBBIJLNA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct GLJGIDHIMOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo HLJBPHNCIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public COFBNFOEGIB LFNDFDONBCO;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<EEILJHHLCPL, List<GLJGIDHIMOC>> JNPICCFECAO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static OJEGDOKHPNO EHLKKGIELGG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static OJEGDOKHPNO IOKMDBAIIII;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static OJEGDOKHPNO AGDEHDCBIPL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static OJEGDOKHPNO IPIIEHOLADF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC76C0", Offset = "0x5FC62C0", VA = "0x185FC76C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OJEGDOKHPNO HFAGJLHKABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6580", Offset = "0x5FC5180", VA = "0x185FC6580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static OJEGDOKHPNO HHJJDGABOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5FC70E0", Offset = "0x5FC5CE0", VA = "0x185FC70E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FC64D0", Offset = "0x5FC50D0", VA = "0x185FC64D0")]
	[LDEFPDJBILL]
	private static void ECHJHOPJJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FC6400", Offset = "0x5FC5000", VA = "0x185FC6400")]
	[KCMJOFEIICM(DPDOCNKHIKA.Unity_AfterAssembliesLoaded)]
	private static void DFBJIKPMNDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FC68B0", Offset = "0x5FC54B0", VA = "0x185FC68B0")]
	public static OJEGDOKHPNO JEBFPMAAOAF(EEILJHHLCPL IPHBCKJJNJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FC6EE0", Offset = "0x5FC5AE0", VA = "0x185FC6EE0")]
	private static void JEBFPMAAOAF(EEILJHHLCPL IPHBCKJJNJM, OJEGDOKHPNO GHINPDOJACO, OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FC6AF0", Offset = "0x5FC56F0", VA = "0x185FC6AF0")]
	private static void JEBFPMAAOAF(EEILJHHLCPL IPHBCKJJNJM, OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FC65C0", Offset = "0x5FC51C0", VA = "0x185FC65C0")]
	public static void GKFOJCIMADB(EEILJHHLCPL IPHBCKJJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x22DE690", Offset = "0x22DD290", VA = "0x1822DE690")]
	private static bool JMKECNCEONE(COFBNFOEGIB LNBKCGJEFFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FC6290", Offset = "0x5FC4E90", VA = "0x185FC6290")]
	private static OJEGDOKHPNO CLIHFICIEFJ(string GBBEBGFAIKA, [Optional] OJEGDOKHPNO GHINPDOJACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC66E0", Offset = "0x5FC52E0", VA = "0x185FC66E0")]
	private static void GKFOJCIMADB(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FC64D0", Offset = "0x5FC50D0", VA = "0x185FC64D0")]
	private static void EPJKBDDHAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FC7120", Offset = "0x5FC5D20", VA = "0x185FC7120")]
	private static IEnumerable<GLJGIDHIMOC> MOLKHEOJPBP(EEILJHHLCPL IPHBCKJJNJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FC7020", Offset = "0x5FC5C20", VA = "0x185FC7020")]
	private static OJEGDOKHPNO JGFPNBPNPHG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NDKJMCANLOO<T> : IDisposable where T : NDKJMCANLOO<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T MCFGKAKKIKD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T EJGFFMEDDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB040", Offset = "0x3EE9C40", VA = "0x183EEB040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	protected NDKJMCANLOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB000", Offset = "0x3EE9C00", VA = "0x183EEB000", Slot = "5")]
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

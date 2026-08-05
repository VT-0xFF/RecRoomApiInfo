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
		private sealed class EBFIBLLPEGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public EBFIBLLPEGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x683D720", Offset = "0x683C320", VA = "0x18683D720")]
			internal IEnumerable<MethodInfo> CGOFPPCFKFD(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x683D7E0", Offset = "0x683C3E0", VA = "0x18683D7E0")]
			internal bool NOIFLGNCPFG(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class JPPFBMJJFGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public JPPFBMJJFGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x683D890", Offset = "0x683C490", VA = "0x18683D890")]
			internal bool GEJKPCHPIJI(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class FHEDNIOHFFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public FHEDNIOHFFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x683D840", Offset = "0x683C440", VA = "0x18683D840")]
			internal bool NEPEDCOIOHI(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<JPJJCBLCFNP, IGrouping<JPJJCBLCFNP, MethodInfo>> JBAPGGFIKAC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type HIHJLMFNJIH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x683EB10", Offset = "0x683D710", VA = "0x18683EB10")]
		private static void OLGCHACEDFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x683F1A0", Offset = "0x683DDA0", VA = "0x18683F1A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x683D8F0", Offset = "0x683C4F0", VA = "0x18683D8F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x683DB00", Offset = "0x683C700", VA = "0x18683DB00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x683DAB0", Offset = "0x683C6B0", VA = "0x18683DAB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x683D940", Offset = "0x683C540", VA = "0x18683D940")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x683E3E0", Offset = "0x683CFE0", VA = "0x18683E3E0")]
		private static void JLFKDIEKKGM(JPJJCBLCFNP BCKNKNHIDMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x683DB50", Offset = "0x683C750", VA = "0x18683DB50")]
		private static IEnumerable<MethodInfo> DHOCCBMBFCG(Type JMIGPGIAMBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x683F080", Offset = "0x683DC80", VA = "0x18683F080")]
		private static bool PNAOKDGOLBK(string EEIMJAMNKPE, [Out] Dictionary<string, List<string>> ECFOFMCBPNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x683DBE0", Offset = "0x683C7E0", VA = "0x18683DBE0")]
		private static IEnumerable<Type> EAMNOBIEHJB(Dictionary<string, List<string>> ECFOFMCBPNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x683E300", Offset = "0x683CF00", VA = "0x18683E300")]
		private static IEnumerable<MethodInfo> HMHDEEIPELC(IEnumerable<Type> LGOHKICJGNF, Type JMIGPGIAMBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x683E9E0", Offset = "0x683D5E0", VA = "0x18683E9E0")]
		internal static IEnumerable<MethodInfo> NEPKAFPBBNC(JPJJCBLCFNP BCKNKNHIDMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x683E4A0", Offset = "0x683D0A0", VA = "0x18683E4A0")]
		internal static void MJGNHCPPAGL(IEnumerable<MethodInfo> OEHNCCKMPHE, Type CFNMKDNIAEB, [Optional] object[] AINJPEDDNEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x683EA70", Offset = "0x683D670", VA = "0x18683EA70")]
		private static Dictionary<JPJJCBLCFNP, IGrouping<JPJJCBLCFNP, MethodInfo>> OJHAINEMDCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x683D990", Offset = "0x683C590", VA = "0x18683D990")]
		private static bool BCGNHLEIIOD(MethodInfo FMMLJDHOFFP, Type GGIEKGMIKMG, bool AIJILLKFFLE)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DBNGDMFIABG
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> MMFOKGEENDE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> DBFBPEKMKLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x683D660", Offset = "0x683C260", VA = "0x18683D660")]
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
		[Cpp2IlInjected.Address(RVA = "0x683F300", Offset = "0x683DF00", VA = "0x18683F300")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CNAEKIBHEFB
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct LIBEMJMBKKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo MLBJFABBJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public IDHBAGABJJA GCOHGEHAPJI;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<OBGPNJNCONH, List<LIBEMJMBKKB>> NHCPOMCJEMD;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static IMEOEBHKJNP PKOJEDDJGJB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static IMEOEBHKJNP CEJFJIJDDNL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static IMEOEBHKJNP NHLDBOKBEKF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IMEOEBHKJNP LIOIAHEPIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x683CD30", Offset = "0x683B930", VA = "0x18683CD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static IMEOEBHKJNP DAPFGKBNIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x683D620", Offset = "0x683C220", VA = "0x18683D620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static IMEOEBHKJNP HOGCKBHALJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x683C890", Offset = "0x683B490", VA = "0x18683C890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool MFCDGCAKDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x683CE00", Offset = "0x683BA00", VA = "0x18683CE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x683CE40", Offset = "0x683BA40", VA = "0x18683CE40")]
	[GEBLBDHAMIN]
	private static void HNMHMOJPOEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x683D550", Offset = "0x683C150", VA = "0x18683D550")]
	[ECODOIAJHDJ(JPJJCBLCFNP.Unity_AfterAssembliesLoaded)]
	private static void MPKHEJGMONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x683C120", Offset = "0x683AD20", VA = "0x18683C120")]
	public static IMEOEBHKJNP BDOHPHNNJPO(OBGPNJNCONH DIKLFBNMGDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x683C750", Offset = "0x683B350", VA = "0x18683C750")]
	private static void BDOHPHNNJPO(OBGPNJNCONH DIKLFBNMGDC, IMEOEBHKJNP OKGJNNFLBCE, IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x683C360", Offset = "0x683AF60", VA = "0x18683C360")]
	private static void BDOHPHNNJPO(OBGPNJNCONH DIKLFBNMGDC, IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x683CC10", Offset = "0x683B810", VA = "0x18683CC10")]
	public static void GAPDJBJGKPB(OBGPNJNCONH DIKLFBNMGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2590600", Offset = "0x258F200", VA = "0x182590600")]
	private static bool NIDIHBNNNMC(IDHBAGABJJA LHLJNKOIIKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x683C8D0", Offset = "0x683B4D0", VA = "0x18683C8D0")]
	private static IMEOEBHKJNP ECHBFCLBGHF(string BKAHJAHIIHD, [Optional] IMEOEBHKJNP OKGJNNFLBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x683CA40", Offset = "0x683B640", VA = "0x18683CA40")]
	private static void GAPDJBJGKPB(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x683CE40", Offset = "0x683BA40", VA = "0x18683CE40")]
	private static void NAFHEFFELHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x683CEF0", Offset = "0x683BAF0", VA = "0x18683CEF0")]
	private static IEnumerable<LIBEMJMBKKB> KJKOECDHKOE(OBGPNJNCONH DIKLFBNMGDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x683D490", Offset = "0x683C090", VA = "0x18683D490")]
	private static IMEOEBHKJNP MIBIAFJAPGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PCIBNMJLKPO<T> : IDisposable where T : PCIBNMJLKPO<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T AGABHBIFGBH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T NKKNEDDGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x475AF70", Offset = "0x4759B70", VA = "0x18475AF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	protected PCIBNMJLKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x475AF30", Offset = "0x4759B30", VA = "0x18475AF30", Slot = "5")]
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

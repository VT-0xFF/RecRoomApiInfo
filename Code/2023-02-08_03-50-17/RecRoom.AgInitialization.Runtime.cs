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
		private sealed class CAPMCHHCCBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public CAPMCHHCCBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x213BEC0", Offset = "0x213ACC0", VA = "0x18213BEC0")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x213BF90", Offset = "0x213AD90", VA = "0x18213BF90")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class AIBGCCCDGPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public AIBGCCCDGPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x213BE50", Offset = "0x213AC50", VA = "0x18213BE50")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class DDLBPHANFLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public DDLBPHANFLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x213DA00", Offset = "0x213C800", VA = "0x18213DA00")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string FPFHPDIGIKI = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string GNEDEPPKGKC = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<HBBPKJPMKNI, IGrouping<HBBPKJPMKNI, MethodInfo>> LMMODDHAGHF;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type GANCABFGKAL;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x213E520", Offset = "0x213D320", VA = "0x18213E520")]
		private static void IGAFIBAJGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x213F4B0", Offset = "0x213E2B0", VA = "0x18213F4B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x213DB30", Offset = "0x213C930", VA = "0x18213DB30")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x213DCE0", Offset = "0x213CAE0", VA = "0x18213DCE0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x213DC90", Offset = "0x213CA90", VA = "0x18213DC90")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x213DB80", Offset = "0x213C980", VA = "0x18213DB80")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x213EB10", Offset = "0x213D910", VA = "0x18213EB10")]
		private static void KDPHLLCFGKB(HBBPKJPMKNI PMGFGCEIGBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x213EBE0", Offset = "0x213D9E0", VA = "0x18213EBE0")]
		private static IEnumerable<MethodInfo> KOGDFCLCLPM(Type OPENNNIHLMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x213E360", Offset = "0x213D160", VA = "0x18213E360")]
		private static bool EMPPPFPNBCO(string GFOOPBAPGFB, out Dictionary<string, List<string>> AGJNDHINOKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x213ED30", Offset = "0x213DB30", VA = "0x18213ED30")]
		private static IEnumerable<Type> PFBCDBPAPEH(Dictionary<string, List<string>> AGJNDHINOKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x213DA50", Offset = "0x213C850", VA = "0x18213DA50")]
		private static IEnumerable<MethodInfo> APJJPIDIKFN(IEnumerable<Type> CBKHHLNLKPG, Type OPENNNIHLMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x213ECA0", Offset = "0x213DAA0", VA = "0x18213ECA0")]
		internal static IEnumerable<MethodInfo> LKGHPGMPDHC(HBBPKJPMKNI PMGFGCEIGBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x213DE50", Offset = "0x213CC50", VA = "0x18213DE50")]
		internal static void EHKEKNHFLMG(IEnumerable<MethodInfo> IFHJOIKNEHG, Type OMIGIAPDKPL, [Optional] object[] LNCKHCKJOFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x213DBD0", Offset = "0x213C9D0", VA = "0x18213DBD0")]
		private static Dictionary<HBBPKJPMKNI, IGrouping<HBBPKJPMKNI, MethodInfo>> BPMHCIHLLDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x213DD30", Offset = "0x213CB30", VA = "0x18213DD30")]
		private static bool ECDMLLAAJAM(MethodInfo NELDELHIAEJ, Type BKIHOFNBHNC, bool GBAIKOJMCCG)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x213F620", Offset = "0x213E420", VA = "0x18213F620")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CLJCDCONOFK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct GNNFELPALBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo KPGHDFNJAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BFFNGLOENLB KMHGKPLPBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool PMKDAMDNNOE;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<ONDHMKMHMIA, List<GNNFELPALBM>> KJNKCDDHFIL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static AMNHNFNHFNB BHJIDGJOCOG;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static AMNHNFNHFNB DGMPHBFIPID;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static AMNHNFNHFNB DMMLBEHFJCD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AMNHNFNHFNB FPNNOFOGMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x213C830", Offset = "0x213B630", VA = "0x18213C830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static AMNHNFNHFNB DMCNIEGBFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x213C7F0", Offset = "0x213B5F0", VA = "0x18213C7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static AMNHNFNHFNB EDKLNGAGBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x213C7B0", Offset = "0x213B5B0", VA = "0x18213C7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x213C920", Offset = "0x213B720", VA = "0x18213C920")]
	[LNBJFGLCGCN]
	private static void LIJIMPDDADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x213C5D0", Offset = "0x213B3D0", VA = "0x18213C5D0")]
	[FFDJMNHKGHP(HBBPKJPMKNI.Unity_AfterAssembliesLoaded)]
	private static void FOMAAOFHCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x213D0D0", Offset = "0x213BED0", VA = "0x18213D0D0")]
	public static AMNHNFNHFNB OPDBEGDPADM(ONDHMKMHMIA LFAIPDKLHLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x213CF40", Offset = "0x213BD40", VA = "0x18213CF40")]
	private static void OPDBEGDPADM(ONDHMKMHMIA LFAIPDKLHLN, AMNHNFNHFNB BMBJOODDPFO, ref AMNHNFNHFNB JANAFEEBPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x213D310", Offset = "0x213C110", VA = "0x18213D310")]
	private static void OPDBEGDPADM(ONDHMKMHMIA LFAIPDKLHLN, AMNHNFNHFNB JANAFEEBPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x213CD50", Offset = "0x213BB50", VA = "0x18213CD50")]
	public static void MOKEKDHOMDA(ONDHMKMHMIA LFAIPDKLHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x213CE60", Offset = "0x213BC60", VA = "0x18213CE60")]
	private static bool NIJLMHEAMCK(BFFNGLOENLB FHAHHJHPOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x213C9D0", Offset = "0x213B7D0", VA = "0x18213C9D0")]
	private static AMNHNFNHFNB MMBIBOHEECG(string ACHJDFLGNCG, [Optional] AMNHNFNHFNB BMBJOODDPFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x213CB50", Offset = "0x213B950", VA = "0x18213CB50")]
	private static void MOKEKDHOMDA(ref AMNHNFNHFNB JANAFEEBPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x213C920", Offset = "0x213B720", VA = "0x18213C920")]
	private static void NIAONOILILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x213C000", Offset = "0x213AE00", VA = "0x18213C000")]
	private static IEnumerable<GNNFELPALBM> CACEFDBFCOK(ONDHMKMHMIA LFAIPDKLHLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x213C6C0", Offset = "0x213B4C0", VA = "0x18213C6C0")]
	private static AMNHNFNHFNB GAFOOKLPLME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KGBFELFHEDJ<T> : IDisposable where T : global::KGBFELFHEDJ<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static T BINMOAHIPCO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T GEHLGJGIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x39BCB80", Offset = "0x39BB980", VA = "0x1839BCB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
	protected KGBFELFHEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x39BCE10", Offset = "0x39BBC10", VA = "0x1839BCE10", Slot = "5")]
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

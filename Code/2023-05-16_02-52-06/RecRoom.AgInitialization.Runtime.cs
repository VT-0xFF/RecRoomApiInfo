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
		private sealed class HOCANHKDEPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public HOCANHKDEPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6AAB010", Offset = "0x6AA9E10", VA = "0x186AAB010")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6AAB0E0", Offset = "0x6AA9EE0", VA = "0x186AAB0E0")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class AMCHGOHNCJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public AMCHGOHNCJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6AA9830", Offset = "0x6AA8630", VA = "0x186AA9830")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class COIKOOPOMOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public COIKOOPOMOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6AA98A0", Offset = "0x6AA86A0", VA = "0x186AA98A0")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string FLHOPOJAKNO = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string IAAFJAFNODC = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<NGGIKFHAPNK, IGrouping<NGGIKFHAPNK, MethodInfo>> HLFNLPHABOI;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type ADBOOHFHDKA;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6AAB1F0", Offset = "0x6AA9FF0", VA = "0x186AAB1F0")]
		private static void BBHLKGPPHLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6AACBB0", Offset = "0x6AAB9B0", VA = "0x186AACBB0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6AAB150", Offset = "0x6AA9F50", VA = "0x186AAB150")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AAB830", Offset = "0x6AAA630", VA = "0x186AAB830")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6AAB7E0", Offset = "0x6AAA5E0", VA = "0x186AAB7E0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6AAB1A0", Offset = "0x6AA9FA0", VA = "0x186AAB1A0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AABF70", Offset = "0x6AAAD70", VA = "0x186AABF70")]
		private static void IBPFJGKPCKB(NGGIKFHAPNK DEDJOAHMHPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6AAB880", Offset = "0x6AAA680", VA = "0x186AAB880")]
		private static IEnumerable<MethodInfo> DHMMCJDDGCJ(Type EDEJBKKJKDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6AAC040", Offset = "0x6AAAE40", VA = "0x186AAC040")]
		private static bool KKOEKGDGJDD(string EEIPHILNKEE, out Dictionary<string, List<string>> JEKMEBMAEDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6AAC200", Offset = "0x6AAB000", VA = "0x186AAC200")]
		private static IEnumerable<Type> KMLKFPGKGNC(Dictionary<string, List<string>> JEKMEBMAEDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6AAC980", Offset = "0x6AAB780", VA = "0x186AAC980")]
		private static IEnumerable<MethodInfo> MEBBDAAMGAA(IEnumerable<Type> LFNDHOPEOFJ, Type EDEJBKKJKDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6AACA60", Offset = "0x6AAB860", VA = "0x186AACA60")]
		internal static IEnumerable<MethodInfo> MNAMPIBDKAB(NGGIKFHAPNK DEDJOAHMHPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AAB940", Offset = "0x6AAA740", VA = "0x186AAB940")]
		internal static void EOJOBFFCLFC(IEnumerable<MethodInfo> DNMDCPIKFDF, Type IEFHFJHIGFP, [Optional] object[] DNHNNDBCPLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6AACAF0", Offset = "0x6AAB8F0", VA = "0x186AACAF0")]
		private static Dictionary<NGGIKFHAPNK, IGrouping<NGGIKFHAPNK, MethodInfo>> NOOMODIFHOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6AABE50", Offset = "0x6AAAC50", VA = "0x186AABE50")]
		private static bool EPOJKAFMKMG(MethodInfo APKLEGEBOGF, Type IABPJNMOEDC, bool JPJMMKJINMJ)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AACD20", Offset = "0x6AABB20", VA = "0x186AACD20")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EEDJOKLDJLF
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct JLLOBPFLKND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo LBAAACPELNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public ANAFFCEINAM HOBDBHJJMOH;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<LLLAACKFLBA, List<JLLOBPFLKND>> PCNHDLDGCOC;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static GMLHNNIDAIC BHEFIDHCNPP;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static GMLHNNIDAIC DNJOHLJEDIB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static GMLHNNIDAIC HAFJDFHHPHK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GMLHNNIDAIC GLGKEOALGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AA9B00", Offset = "0x6AA8900", VA = "0x186AA9B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GMLHNNIDAIC LFONAJKFHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6AA98F0", Offset = "0x6AA86F0", VA = "0x186AA98F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static GMLHNNIDAIC KOHBFGNKLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6AA9E60", Offset = "0x6AA8C60", VA = "0x186AA9E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AAAF60", Offset = "0x6AA9D60", VA = "0x186AAAF60")]
	[NJGOBELLFPL]
	private static void OPDEPGHAJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9A10", Offset = "0x6AA8810", VA = "0x186AA9A10")]
	[ALDBEIMIKEO(NGGIKFHAPNK.Unity_AfterAssembliesLoaded)]
	private static void CEGHBDKICEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6AAAB90", Offset = "0x6AA9990", VA = "0x186AAAB90")]
	public static GMLHNNIDAIC MAJFLAHMFKM(LLLAACKFLBA KEOLAABFHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6AAADD0", Offset = "0x6AA9BD0", VA = "0x186AAADD0")]
	private static void MAJFLAHMFKM(LLLAACKFLBA KEOLAABFHAI, GMLHNNIDAIC DMCCIOFLMBE, ref GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA750", Offset = "0x6AA9550", VA = "0x186AAA750")]
	private static void MAJFLAHMFKM(LLLAACKFLBA KEOLAABFHAI, GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA430", Offset = "0x6AA9230", VA = "0x186AAA430")]
	public static void KMCOOIDLBNB(LLLAACKFLBA KEOLAABFHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9930", Offset = "0x6AA8730", VA = "0x186AA9930")]
	private static bool CBOAJPGNBBJ(ANAFFCEINAM AEPNNINBOGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9CE0", Offset = "0x6AA8AE0", VA = "0x186AA9CE0")]
	private static GMLHNNIDAIC EJKDBBANIDE(string HAMKMLEAGED, [Optional] GMLHNNIDAIC DMCCIOFLMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA540", Offset = "0x6AA9340", VA = "0x186AAA540")]
	private static void KMCOOIDLBNB(ref GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6AAAF60", Offset = "0x6AA9D60", VA = "0x186AAAF60")]
	private static void NFNCCLFOMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9EA0", Offset = "0x6AA8CA0", VA = "0x186AA9EA0")]
	private static IEnumerable<JLLOBPFLKND> EOKLGADIGAD(LLLAACKFLBA KEOLAABFHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9BF0", Offset = "0x6AA89F0", VA = "0x186AA9BF0")]
	private static GMLHNNIDAIC DMBGIGAGHNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AOBLFEIBIID<T> : IDisposable where T : global::AOBLFEIBIID<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T DMDACHFLMCK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T NHLDGJJELOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x34D67B0", Offset = "0x34D55B0", VA = "0x1834D67B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
	protected AOBLFEIBIID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x34D6770", Offset = "0x34D5570", VA = "0x1834D6770", Slot = "5")]
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

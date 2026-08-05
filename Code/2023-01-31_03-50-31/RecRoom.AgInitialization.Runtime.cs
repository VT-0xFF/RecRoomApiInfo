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
		private sealed class ONGCAMCJGCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public ONGCAMCJGCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x21DE170", Offset = "0x21DCF70", VA = "0x1821DE170")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x21DE240", Offset = "0x21DD040", VA = "0x1821DE240")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class BCPFBCFJJKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public BCPFBCFJJKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x21DC6B0", Offset = "0x21DB4B0", VA = "0x1821DC6B0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class DLEFHINCJHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public DLEFHINCJHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x21DC720", Offset = "0x21DB520", VA = "0x1821DC720")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string MCGDGMMBBFI = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string OEAPGIDHDLL = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<MLJIKHLLPGF, IGrouping<MLJIKHLLPGF, MethodInfo>> BJHKEIDAFIL;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type CMBELMHDMBF;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x21DE350", Offset = "0x21DD150", VA = "0x1821DE350")]
		private static void BCNKNJKIEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x21DFD10", Offset = "0x21DEB10", VA = "0x1821DFD10")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x21DE2B0", Offset = "0x21DD0B0", VA = "0x1821DE2B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x21DEAF0", Offset = "0x21DD8F0", VA = "0x1821DEAF0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21DEAA0", Offset = "0x21DD8A0", VA = "0x1821DEAA0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21DE300", Offset = "0x21DD100", VA = "0x1821DE300")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21DE940", Offset = "0x21DD740", VA = "0x1821DE940")]
		private static void BFGIIKPMFAJ(MLJIKHLLPGF GOKGCKCBEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21DEB40", Offset = "0x21DD940", VA = "0x1821DEB40")]
		private static IEnumerable<MethodInfo> ELNFLAFDJDL(Type GDMDGCMEKJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21DFA70", Offset = "0x21DE870", VA = "0x1821DFA70")]
		private static bool NELOIJDHLLJ(string LMAMBCJAPIA, out Dictionary<string, List<string>> DIPGBCFJMBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x21DEC00", Offset = "0x21DDA00", VA = "0x1821DEC00")]
		private static IEnumerable<Type> GBOOGCFPMPB(Dictionary<string, List<string>> DIPGBCFJMBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x21DFC30", Offset = "0x21DEA30", VA = "0x1821DFC30")]
		private static IEnumerable<MethodInfo> OJIBAFPGKOC(IEnumerable<Type> ELKKGBGGKPO, Type GDMDGCMEKJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x21DEA10", Offset = "0x21DD810", VA = "0x1821DEA10")]
		internal static IEnumerable<MethodInfo> BINFOLCCEKG(MLJIKHLLPGF GOKGCKCBEHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x21DF440", Offset = "0x21DE240", VA = "0x1821DF440")]
		internal static void LFACEINJDGP(IEnumerable<MethodInfo> MOEGEGMOKKB, Type FHMLLOKGAGH, [Optional] object[] FHLNMMPFILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x21DF380", Offset = "0x21DE180", VA = "0x1821DF380")]
		private static Dictionary<MLJIKHLLPGF, IGrouping<MLJIKHLLPGF, MethodInfo>> IMDPMLAODNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x21DF950", Offset = "0x21DE750", VA = "0x1821DF950")]
		private static bool LHGCDLOFGKP(MethodInfo FHLIGJBMGCI, Type OCMBAPDKBPO, bool CPMMMGMEDOF)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x21DFE80", Offset = "0x21DEC80", VA = "0x1821DFE80")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GHPPONPGGBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct OPIKHNNCELG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo IAPLOPJNAKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CIKEJIGJNLD INBIEBHCPHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool DEONDOECCNN;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<CJFFFKHKLCM, List<OPIKHNNCELG>> KKLBHJPNNCP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static GBDCKFPNAEP LLGFGIBJJKM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static GBDCKFPNAEP CPJIGFKCPIN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static GBDCKFPNAEP GMHIFMIHFAP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GBDCKFPNAEP GHOIKAHCODP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x21DC860", Offset = "0x21DB660", VA = "0x1821DC860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GBDCKFPNAEP EDIPEHEEOGK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x21DC950", Offset = "0x21DB750", VA = "0x1821DC950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static GBDCKFPNAEP EFBACJMHDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x21DDA70", Offset = "0x21DC870", VA = "0x1821DDA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x21DCB10", Offset = "0x21DB910", VA = "0x1821DCB10")]
	[EKHHFGMPNLA]
	private static void GJEANOPMGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x21DDAB0", Offset = "0x21DC8B0", VA = "0x1821DDAB0")]
	[NMAEGPBBEAO(MLJIKHLLPGF.Unity_AfterAssembliesLoaded)]
	private static void NLNGLMKBLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x21DCCA0", Offset = "0x21DBAA0", VA = "0x1821DCCA0")]
	public static GBDCKFPNAEP LHJJNCLAFHM(CJFFFKHKLCM DOAGMBMKODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x21DD5D0", Offset = "0x21DC3D0", VA = "0x1821DD5D0")]
	private static void LHJJNCLAFHM(CJFFFKHKLCM DOAGMBMKODG, GBDCKFPNAEP FLFONOKDLGH, ref GBDCKFPNAEP FOIOPKEONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x21DCEE0", Offset = "0x21DBCE0", VA = "0x1821DCEE0")]
	private static void LHJJNCLAFHM(CJFFFKHKLCM DOAGMBMKODG, GBDCKFPNAEP FOIOPKEONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x21DD960", Offset = "0x21DC760", VA = "0x1821DD960")]
	public static void MCHCEIDCHGI(CJFFFKHKLCM DOAGMBMKODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x21DCBC0", Offset = "0x21DB9C0", VA = "0x1821DCBC0")]
	private static bool ILEIMFGLGPC(CIKEJIGJNLD BKHAMFHMEGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x21DC990", Offset = "0x21DB790", VA = "0x1821DC990")]
	private static GBDCKFPNAEP EPCCFBBJKBB(string DKMLJBLDLBF, [Optional] GBDCKFPNAEP FLFONOKDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x21DD760", Offset = "0x21DC560", VA = "0x1821DD760")]
	private static void MCHCEIDCHGI(ref GBDCKFPNAEP FOIOPKEONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x21DCB10", Offset = "0x21DB910", VA = "0x1821DCB10")]
	private static void HAMICACDICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x21DDBA0", Offset = "0x21DC9A0", VA = "0x1821DDBA0")]
	private static IEnumerable<OPIKHNNCELG> PPLEADOMLGN(CJFFFKHKLCM DOAGMBMKODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x21DC770", Offset = "0x21DB570", VA = "0x1821DC770")]
	private static GBDCKFPNAEP BDJHEELJJCF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BFBOBJAJDFH<T> : IDisposable where T : global::BFBOBJAJDFH<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static T OMPFLELLCCN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T JKCIDAEDHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x45F8670", Offset = "0x45F7470", VA = "0x1845F8670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	protected BFBOBJAJDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x45F8900", Offset = "0x45F7700", VA = "0x1845F8900", Slot = "5")]
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

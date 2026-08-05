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
		private sealed class BDLBAMLIDMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public BDLBAMLIDMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x67E4230", Offset = "0x67E3230", VA = "0x1867E4230")]
			internal IEnumerable<MethodInfo> DHKBKOCEGEN(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x67E42F0", Offset = "0x67E32F0", VA = "0x1867E42F0")]
			internal bool IMEENAGJMML(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class EGGFCFNLHCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public EGGFCFNLHCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x67E43A0", Offset = "0x67E33A0", VA = "0x1867E43A0")]
			internal bool APJKODIJDEL(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class CEALFJHDDBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public CEALFJHDDBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67E4350", Offset = "0x67E3350", VA = "0x1867E4350")]
			internal bool GIAEDCACBHB(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<JOFJHDAEEPM, IGrouping<JOFJHDAEEPM, MethodInfo>> APACHEBLNPB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type PNFNCFFHHOG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67E5E40", Offset = "0x67E4E40", VA = "0x1867E5E40")]
		private static void GAOGAFCGLFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67E72B0", Offset = "0x67E62B0", VA = "0x1867E72B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x67E5A00", Offset = "0x67E4A00", VA = "0x1867E5A00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67E5B80", Offset = "0x67E4B80", VA = "0x1867E5B80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67E5B30", Offset = "0x67E4B30", VA = "0x1867E5B30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67E5A50", Offset = "0x67E4A50", VA = "0x1867E5A50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67E5BD0", Offset = "0x67E4BD0", VA = "0x1867E5BD0")]
		private static void ELKOOBNNLLL(JOFJHDAEEPM DPJGNJPLPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67E5DB0", Offset = "0x67E4DB0", VA = "0x1867E5DB0")]
		private static IEnumerable<MethodInfo> EOPDBLIIFCG(Type LNCEHGBKKCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67E5C90", Offset = "0x67E4C90", VA = "0x1867E5C90")]
		private static bool EOJDPIKBLDE(string DKKNGADBEKE, [Out] Dictionary<string, List<string>> IGHPMPHHGOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x67E69D0", Offset = "0x67E59D0", VA = "0x1867E69D0")]
		private static IEnumerable<Type> INFDKBFFABM(Dictionary<string, List<string>> IGHPMPHHGOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67E63B0", Offset = "0x67E53B0", VA = "0x1867E63B0")]
		private static IEnumerable<MethodInfo> HENCJFCHHHK(IEnumerable<Type> KLLPAOPGPHG, Type LNCEHGBKKCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67E5AA0", Offset = "0x67E4AA0", VA = "0x1867E5AA0")]
		internal static IEnumerable<MethodInfo> BAFOFNLAFCF(JOFJHDAEEPM DPJGNJPLPPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67E6490", Offset = "0x67E5490", VA = "0x1867E6490")]
		internal static void HIEDADCKLEP(IEnumerable<MethodInfo> NNHIMKPCOLE, Type FBBJHECEOME, [Optional] object[] OEFIADEKGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67E70F0", Offset = "0x67E60F0", VA = "0x1867E70F0")]
		private static Dictionary<JOFJHDAEEPM, IGrouping<JOFJHDAEEPM, MethodInfo>> KMJGFMGPBAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x67E7190", Offset = "0x67E6190", VA = "0x1867E7190")]
		private static bool KOFHAFHGPLH(MethodInfo DEFKKADHDCH, Type NECONHHIDML, bool IJNCBKPKGIH)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HGIJNIIBNAJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> EHPGDKMFAFH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> ONKFJEBFAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67E5940", Offset = "0x67E4940", VA = "0x1867E5940")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E7410", Offset = "0x67E6410", VA = "0x1867E7410")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GINOPFFIBND
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct FNEHMNKKKNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo OBIDPCEMPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public IKAJKCKEGIH CBCNJGHMMKD;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<NOFONODCPKJ, List<FNEHMNKKKNB>> GFMLKMPCLIA;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static NDJGECDCBMH KEIOCMBMJEN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static NDJGECDCBMH JEBJLOFGLBJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static NDJGECDCBMH JGJFPCADIID;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static NDJGECDCBMH KILMHGFMJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67E4400", Offset = "0x67E3400", VA = "0x1867E4400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static NDJGECDCBMH DFAEHMOGMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67E5900", Offset = "0x67E4900", VA = "0x1867E5900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static NDJGECDCBMH AIAOBEFDCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67E5040", Offset = "0x67E4040", VA = "0x1867E5040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool PFKLDOLBOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67E5150", Offset = "0x67E4150", VA = "0x1867E5150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67E49F0", Offset = "0x67E39F0", VA = "0x1867E49F0")]
	[FGIADCLCHGD]
	private static void LOBLBCIDOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67E5080", Offset = "0x67E4080", VA = "0x1867E5080")]
	[JHNEDNDFJPF(JOFJHDAEEPM.Unity_AfterAssembliesLoaded)]
	private static void MAPFLLDKADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67E5190", Offset = "0x67E4190", VA = "0x1867E5190")]
	public static NDJGECDCBMH MKLNKHILENF(NOFONODCPKJ JOMCJKBGNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67E53D0", Offset = "0x67E43D0", VA = "0x1867E53D0")]
	private static void MKLNKHILENF(NOFONODCPKJ JOMCJKBGNHN, NDJGECDCBMH IMNFKMKKLKD, NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67E5510", Offset = "0x67E4510", VA = "0x1867E5510")]
	private static void MKLNKHILENF(NOFONODCPKJ JOMCJKBGNHN, NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x67E4640", Offset = "0x67E3640", VA = "0x1867E4640")]
	public static void DGIAJFBCMKA(NOFONODCPKJ JOMCJKBGNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x25D13F0", Offset = "0x25D03F0", VA = "0x1825D13F0")]
	private static bool NKJONIAJGAO(IKAJKCKEGIH ICHBIIKDGBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67E44D0", Offset = "0x67E34D0", VA = "0x1867E44D0")]
	private static NDJGECDCBMH DGFNIEMKGCJ(string NCLEBCLIDGC, [Optional] NDJGECDCBMH IMNFKMKKLKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67E4760", Offset = "0x67E3760", VA = "0x1867E4760")]
	private static void DGIAJFBCMKA(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67E49F0", Offset = "0x67E39F0", VA = "0x1867E49F0")]
	private static void GAIMDCGCCBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67E4AA0", Offset = "0x67E3AA0", VA = "0x1867E4AA0")]
	private static IEnumerable<FNEHMNKKKNB> ILKIIIEOOBH(NOFONODCPKJ JOMCJKBGNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67E4930", Offset = "0x67E3930", VA = "0x1867E4930")]
	private static NDJGECDCBMH FLPHPPLLKHM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NIICCCDNNNE<T> : IDisposable where T : NIICCCDNNNE<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T KCAPGDAGEBJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T PNNELGGLBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x45EAE60", Offset = "0x45E9E60", VA = "0x1845EAE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	protected NIICCCDNNNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x45EB130", Offset = "0x45EA130", VA = "0x1845EB130", Slot = "5")]
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

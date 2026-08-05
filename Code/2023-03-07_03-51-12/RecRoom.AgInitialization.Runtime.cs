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
		private sealed class MMMEHOBILHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public MMMEHOBILHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x64CA1B0", Offset = "0x64C95B0", VA = "0x1864CA1B0")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x64CA280", Offset = "0x64C9680", VA = "0x1864CA280")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class DNMJHOJGOCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public DNMJHOJGOCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x64C86F0", Offset = "0x64C7AF0", VA = "0x1864C86F0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class KGOMLMFDBGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public KGOMLMFDBGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x64C8760", Offset = "0x64C7B60", VA = "0x1864C8760")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string MLHEPMOOLFO = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string JBAOBMDKGEI = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<AIACHMLABFB, IGrouping<AIACHMLABFB, MethodInfo>> GALKHIEPHLF;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type DGKCOLLKPOB;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x64CB4E0", Offset = "0x64CA8E0", VA = "0x1864CB4E0")]
		private static void MGJGILIFKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64CBD50", Offset = "0x64CB150", VA = "0x1864CBD50")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x64CA410", Offset = "0x64C9810", VA = "0x1864CA410")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64CAC80", Offset = "0x64CA080", VA = "0x1864CAC80")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64CAC30", Offset = "0x64CA030", VA = "0x1864CAC30")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64CA460", Offset = "0x64C9860", VA = "0x1864CA460")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64CB410", Offset = "0x64CA810", VA = "0x1864CB410")]
		private static void KIKFLCNODAA(AIACHMLABFB GGFJMCBCIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64CBAD0", Offset = "0x64CAED0", VA = "0x1864CBAD0")]
		private static IEnumerable<MethodInfo> NOOJLNLJNIK(Type FHHLPOPIKID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64CBB90", Offset = "0x64CAF90", VA = "0x1864CBB90")]
		private static bool OEEIPNFHDAF(string LDLMJFKPJPK, out Dictionary<string, List<string>> CBNJDHILJBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x64CA4B0", Offset = "0x64C98B0", VA = "0x1864CA4B0")]
		private static IEnumerable<Type> BBIMEJLKKEC(Dictionary<string, List<string>> CBNJDHILJBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64CB270", Offset = "0x64CA670", VA = "0x1864CB270")]
		private static IEnumerable<MethodInfo> HJCDKCGLAEM(IEnumerable<Type> AOALHLGMLAI, Type FHHLPOPIKID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64CACD0", Offset = "0x64CA0D0", VA = "0x1864CACD0")]
		internal static IEnumerable<MethodInfo> CIEAFEIOMJP(AIACHMLABFB GGFJMCBCIBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x64CAD60", Offset = "0x64CA160", VA = "0x1864CAD60")]
		internal static void GCBODNNLFBI(IEnumerable<MethodInfo> MKAFFHDPBGG, Type MNLEEAIIEIH, [Optional] object[] PEEIAPNNFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x64CB350", Offset = "0x64CA750", VA = "0x1864CB350")]
		private static Dictionary<AIACHMLABFB, IGrouping<AIACHMLABFB, MethodInfo>> ICGKLIMEICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64CA2F0", Offset = "0x64C96F0", VA = "0x1864CA2F0")]
		private static bool ADGKLDHGACI(MethodInfo MOJEAALGNON, Type AKPLJEGKHNN, bool IELKKLAIIMA)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x64CBEC0", Offset = "0x64CB2C0", VA = "0x1864CBEC0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KMHLGEMLKMO
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct MCNJKFFCFDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo JPKMKBENHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public OEKFJILJDLM FILKCFNCPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool FAJBBJCLHPF;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<JAIGHIDJKOL, List<MCNJKFFCFDA>> LGBKMDKKEBJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static BHKHBEKDAPI HFBOHFGEADI;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static BHKHBEKDAPI IFLGBCABFPO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static BHKHBEKDAPI CNKLPGHEALG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static BHKHBEKDAPI COIMCDBNODG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x64C8F50", Offset = "0x64C8350", VA = "0x1864C8F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static BHKHBEKDAPI ECABLJJECJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x64C8E20", Offset = "0x64C8220", VA = "0x1864C8E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BHKHBEKDAPI JCKGPDENNJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x64C89E0", Offset = "0x64C7DE0", VA = "0x1864C89E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x64C8930", Offset = "0x64C7D30", VA = "0x1864C8930")]
	[KIPOKKEDHJA]
	private static void OLEDPHPLKAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x64C8E60", Offset = "0x64C8260", VA = "0x1864C8E60")]
	[IHGFJIOHIHA(AIACHMLABFB.Unity_AfterAssembliesLoaded)]
	private static void HIDBNBGBADP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x64C96F0", Offset = "0x64C8AF0", VA = "0x1864C96F0")]
	public static BHKHBEKDAPI PKMPMLGBAME(JAIGHIDJKOL IEAFCCNGOAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x64C9930", Offset = "0x64C8D30", VA = "0x1864C9930")]
	private static void PKMPMLGBAME(JAIGHIDJKOL IEAFCCNGOAF, BHKHBEKDAPI DPFIAKKFGJG, ref BHKHBEKDAPI CBOODPBIPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x64C9AC0", Offset = "0x64C8EC0", VA = "0x1864C9AC0")]
	private static void PKMPMLGBAME(JAIGHIDJKOL IEAFCCNGOAF, BHKHBEKDAPI CBOODPBIPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x64C8B10", Offset = "0x64C7F10", VA = "0x1864C8B10")]
	public static void GFANJDNDIFG(JAIGHIDJKOL IEAFCCNGOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x64C9040", Offset = "0x64C8440", VA = "0x1864C9040")]
	private static bool MNAMKMAJJCB(OEKFJILJDLM LAPACHAFDBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x64C87B0", Offset = "0x64C7BB0", VA = "0x1864C87B0")]
	private static BHKHBEKDAPI BNHDELMCAAP(string PPFLBHGFEGN, [Optional] BHKHBEKDAPI DPFIAKKFGJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x64C8C20", Offset = "0x64C8020", VA = "0x1864C8C20")]
	private static void GFANJDNDIFG(ref BHKHBEKDAPI CBOODPBIPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x64C8930", Offset = "0x64C7D30", VA = "0x1864C8930")]
	private static void ECMFAAECAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x64C9120", Offset = "0x64C8520", VA = "0x1864C9120")]
	private static IEnumerable<MCNJKFFCFDA> OBDJLDDKDBO(JAIGHIDJKOL IEAFCCNGOAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x64C8A20", Offset = "0x64C7E20", VA = "0x1864C8A20")]
	private static BHKHBEKDAPI ELFKKJMNCEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EMNPCFGGDNI<T> : IDisposable where T : global::EMNPCFGGDNI<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static T GLONDIMDLCD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T KGGJIHLJBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2525EF0", Offset = "0x25252F0", VA = "0x182525EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
	protected EMNPCFGGDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2525EB0", Offset = "0x25252B0", VA = "0x182525EB0", Slot = "5")]
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

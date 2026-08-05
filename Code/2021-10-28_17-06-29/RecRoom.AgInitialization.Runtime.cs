using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Method)]
public class CNCOEENPANM : FOHMMJLHEAC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x409F5D0", Offset = "0x409E7D0", VA = "0x18409F5D0")]
	public CNCOEENPANM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class BCLPAKFCHME : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly LIIAEFEMFCA DHPCLNHBJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly int BIEBADAOLPD;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x409F590", Offset = "0x409E790", VA = "0x18409F590")]
	public BCLPAKFCHME(LIIAEFEMFCA GDGHMBJPEBI = LIIAEFEMFCA.ExitingPlayMode, int DEHBNGCHCHD = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LIIAEFEMFCA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ExitingPlayMode,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	EnteredEditMode,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	EnteredEditModeNextFrame
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class FOHMMJLHEAC : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly KNBJFOBIPBM GMFCNFJICBO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x409F770", Offset = "0x409E970", VA = "0x18409F770")]
	public FOHMMJLHEAC(KNBJFOBIPBM FICNCJNHCEN = KNBJFOBIPBM.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KNBJFOBIPBM
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Unity_AfterSceneLoad,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Unity_BeforeSceneLoad,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Unity_AfterAssembliesLoaded,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Unity_BeforeSplashScreen,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Unity_SubsystemRegistration
}
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class EHLDAFPDCFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
			public EHLDAFPDCFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x409F660", Offset = "0x409E860", VA = "0x18409F660")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x409F700", Offset = "0x409E900", VA = "0x18409F700")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DLJHDLDKNMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
			public DLJHDLDKNMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x409F5F0", Offset = "0x409E7F0", VA = "0x18409F5F0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class PBNFHNHNIAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
			public PBNFHNHNIAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x409F860", Offset = "0x409EA60", VA = "0x18409F860")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public const string DMFOEJLBKCE = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const string NFGOFJPMPMC = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Dictionary<KNBJFOBIPBM, IGrouping<KNBJFOBIPBM, MethodInfo>> PEEKHMDCNDG;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Type OKMMDAFPKHA;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x40A0630", Offset = "0x409F830", VA = "0x1840A0630")]
		private static void JKDLEBNNILL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x40A0C70", Offset = "0x409FE70", VA = "0x1840A0C70")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x409FC50", Offset = "0x409EE50", VA = "0x18409FC50")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x409FE20", Offset = "0x409F020", VA = "0x18409FE20")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x409FDD0", Offset = "0x409EFD0", VA = "0x18409FDD0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x409FCA0", Offset = "0x409EEA0", VA = "0x18409FCA0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x40A0AF0", Offset = "0x409FCF0", VA = "0x1840A0AF0")]
		private static void LGIHLCBPGFP(KNBJFOBIPBM FICNCJNHCEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x409FE70", Offset = "0x409F070", VA = "0x18409FE70")]
		private static IEnumerable<MethodInfo> FEPGGGICJOM(Type GJMFIHGFKOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x40A04B0", Offset = "0x409F6B0", VA = "0x1840A04B0")]
		private static bool IHDNKEOCPEL(string DDFFHAMOEKK, out Dictionary<string, List<string>> CCNKCACOMBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x409FF30", Offset = "0x409F130", VA = "0x18409FF30")]
		private static IEnumerable<Type> HMNKJGPLAPK(Dictionary<string, List<string>> CCNKCACOMBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x40A0BC0", Offset = "0x409FDC0", VA = "0x1840A0BC0")]
		private static IEnumerable<MethodInfo> NJMOMECCKEL(IEnumerable<Type> FDGMEJFHHBL, Type GJMFIHGFKOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x409F8B0", Offset = "0x409EAB0", VA = "0x18409F8B0")]
		private static void AAPNMAAFCEC(IEnumerable<MethodInfo> CPNDHPEMBBF, Type FIEODHEAKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x409FCF0", Offset = "0x409EEF0", VA = "0x18409FCF0")]
		private static bool BAIMKELMEHF(MethodInfo OKPHDDIPHIG, Type IFJGHBFGNJF)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x40A0D50", Offset = "0x409FF50", VA = "0x1840A0D50")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LAKBLEIOBCP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JJIFHKOJANA BDEIDGDAJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x409F7A0", Offset = "0x409E9A0", VA = "0x18409F7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
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

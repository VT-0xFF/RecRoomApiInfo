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
public class HPNPMDPOGDC : HKAMMIPHMDN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x405A9D0", Offset = "0x4059DD0", VA = "0x18405A9D0")]
	public HPNPMDPOGDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class GAMFADILNIH : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly HCPGEDFMOCM IMHBEGHJLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly int HAFGKNJLBLL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x405A850", Offset = "0x4059C50", VA = "0x18405A850")]
	public GAMFADILNIH(HCPGEDFMOCM NGMNEBLMPDP = HCPGEDFMOCM.ExitingPlayMode, int JJFKODFJFCF = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HCPGEDFMOCM
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
public class HKAMMIPHMDN : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly CCPANLEJHAB FPBBCDHENAE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x405A9A0", Offset = "0x4059DA0", VA = "0x18405A9A0")]
	public HKAMMIPHMDN(CCPANLEJHAB GKNIBMJBAIK = CCPANLEJHAB.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CCPANLEJHAB
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
		private sealed class GMEKNIMLBLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
			public GMEKNIMLBLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x405A890", Offset = "0x4059C90", VA = "0x18405A890")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x405A930", Offset = "0x4059D30", VA = "0x18405A930")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class AGMOMGIAMLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
			public AGMOMGIAMLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x405A7E0", Offset = "0x4059BE0", VA = "0x18405A7E0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class LFHFFMHLGLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
			public LFHFFMHLGLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x405A9F0", Offset = "0x4059DF0", VA = "0x18405A9F0")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public const string GNHKNLHNLFK = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const string GKMGEGFHDAH = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Dictionary<CCPANLEJHAB, IGrouping<CCPANLEJHAB, MethodInfo>> NACNFHOOGPB;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Type BLKHOIDIBKG;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x405BA00", Offset = "0x405AE00", VA = "0x18405BA00")]
		private static void MGLNMGIOPMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x405BEC0", Offset = "0x405B2C0", VA = "0x18405BEC0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x405AB00", Offset = "0x4059F00", VA = "0x18405AB00")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x405B170", Offset = "0x405A570", VA = "0x18405B170")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x405B120", Offset = "0x405A520", VA = "0x18405B120")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x405AB50", Offset = "0x4059F50", VA = "0x18405AB50")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x405B880", Offset = "0x405AC80", VA = "0x18405B880")]
		private static void GOMGDMMGFFK(CCPANLEJHAB GKNIBMJBAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x405B2A0", Offset = "0x405A6A0", VA = "0x18405B2A0")]
		private static IEnumerable<MethodInfo> CFEPPIKDMIE(Type NKDHELANAMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x405B360", Offset = "0x405A760", VA = "0x18405B360")]
		private static bool FCJDKHBIEMD(string FFJHHPICNJD, out Dictionary<string, List<string>> MLLAFLEFIOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x405ABA0", Offset = "0x4059FA0", VA = "0x18405ABA0")]
		private static IEnumerable<Type> BABHNEBACGE(Dictionary<string, List<string>> MLLAFLEFIOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x405B950", Offset = "0x405AD50", VA = "0x18405B950")]
		private static IEnumerable<MethodInfo> JFLECLMENIE(IEnumerable<Type> DJMMGPJEEMH, Type NKDHELANAMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x405B4E0", Offset = "0x405A8E0", VA = "0x18405B4E0")]
		private static void FOIJFBOLNNB(IEnumerable<MethodInfo> GPNNGLIEFGD, Type HNEJBLOABBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x405B1C0", Offset = "0x405A5C0", VA = "0x18405B1C0")]
		private static bool CEMIJIHLAOB(MethodInfo CIJOGACNNKL, Type JNFGEKMOPAI)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x405BFA0", Offset = "0x405B3A0", VA = "0x18405BFA0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OOOLHNMNGPC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static HEAAECOMEDJ JICCMNECLFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x405AA40", Offset = "0x4059E40", VA = "0x18405AA40")]
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

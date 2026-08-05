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
public class LPDKEEGEILI : PFKLLAIKJFA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x51DA3B0", Offset = "0x51D93B0", VA = "0x1851DA3B0")]
	public LPDKEEGEILI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class LEDBAOJCIJA : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly NOJCFKMJDIB MNMECAJDINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly int MBGHLGLIGKI;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x51DA300", Offset = "0x51D9300", VA = "0x1851DA300")]
	public LEDBAOJCIJA(NOJCFKMJDIB FEDHINEOKKJ = NOJCFKMJDIB.ExitingPlayMode, int CADNKICEOGM = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NOJCFKMJDIB
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
public class JEBLFEFHMIE : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F13E0", Offset = "0x6F03E0", VA = "0x1806F13E0")]
	public JEBLFEFHMIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class PFKLLAIKJFA : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly AOOAHLGEHHB FGBHIMCNOIC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x51DA3D0", Offset = "0x51D93D0", VA = "0x1851DA3D0")]
	public PFKLLAIKJFA(AOOAHLGEHHB LKEHBMKPEKJ = AOOAHLGEHHB.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum AOOAHLGEHHB
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
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class IDBLIMNGEJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public IDBLIMNGEJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x51DA190", Offset = "0x51D9190", VA = "0x1851DA190")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x51DA240", Offset = "0x51D9240", VA = "0x1851DA240")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class LEHCDAGFLPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public LEHCDAGFLPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x51DA340", Offset = "0x51D9340", VA = "0x1851DA340")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class KHNPJMBJFPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public KHNPJMBJFPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x51DA2B0", Offset = "0x51D92B0", VA = "0x1851DA2B0")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public const string EENJEDIMHOI = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const string EIFHDIFBMCH = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Dictionary<AOOAHLGEHHB, IGrouping<AOOAHLGEHHB, MethodInfo>> JLKGKLEMCEN;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Type GNKHNJBPLKM;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x51DAD60", Offset = "0x51D9D60", VA = "0x1851DAD60")]
		private static void HMCIONHLGLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x51DB9D0", Offset = "0x51DA9D0", VA = "0x1851DB9D0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x51DA5C0", Offset = "0x51D95C0", VA = "0x1851DA5C0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x51DAC60", Offset = "0x51D9C60", VA = "0x1851DAC60")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x51DAC10", Offset = "0x51D9C10", VA = "0x1851DAC10")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x51DA610", Offset = "0x51D9610", VA = "0x1851DA610")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x51DB320", Offset = "0x51DA320", VA = "0x1851DB320")]
		private static void LBCACBECGGI(AOOAHLGEHHB LKEHBMKPEKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x51DB260", Offset = "0x51DA260", VA = "0x1851DB260")]
		private static IEnumerable<MethodInfo> IAFPEHOAMID(Type APHKKDOBNNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x51DA400", Offset = "0x51D9400", VA = "0x1851DA400")]
		private static bool AHMFAPGFLAA(string FMABOBKMPLA, out Dictionary<string, List<string>> FJMKFJOHOGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x51DA660", Offset = "0x51D9660", VA = "0x1851DA660")]
		private static IEnumerable<Type> BBKLKNMBKPH(Dictionary<string, List<string>> FJMKFJOHOGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x51DACB0", Offset = "0x51D9CB0", VA = "0x1851DACB0")]
		private static IEnumerable<MethodInfo> FMKBNHAOALF(IEnumerable<Type> MAGLJCOJOLH, Type APHKKDOBNNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x51DB4E0", Offset = "0x51DA4E0", VA = "0x1851DB4E0")]
		private static void ONBPFABGCOL(IEnumerable<MethodInfo> MPNNKIODLGF, Type JFKMIENGFDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x51DB3F0", Offset = "0x51DA3F0", VA = "0x1851DB3F0")]
		private static bool MMIJILAGFGE(MethodInfo JEKKIGJGFAB, Type EBEGCJJBHEL)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x51DBAE0", Offset = "0x51DAAE0", VA = "0x1851DBAE0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CAOPOGNLCID
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static GHLPAKBGJBB NOJMBOMFLFL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GHLPAKBGJBB MKFILNBFINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x51D9F90", Offset = "0x51D8F90", VA = "0x1851D9F90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x51D9FF0", Offset = "0x51D8FF0", VA = "0x1851D9FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GHLPAKBGJBB EFDCOHOBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x51DA0C0", Offset = "0x51D90C0", VA = "0x1851DA0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LAADBHBMJLJ<T> : IDisposable where T : global::LAADBHBMJLJ<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static T FHBJCKJIPHI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static T AOMOPIPEMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x36FCC80", Offset = "0x36FBC80", VA = "0x1836FCC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
	protected LAADBHBMJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x36FCC40", Offset = "0x36FBC40", VA = "0x1836FCC40", Slot = "5")]
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

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
public class BNLCPBPGLHK : CBEAKPMNJOL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1316290", Offset = "0x1315090", VA = "0x181316290")]
	public BNLCPBPGLHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class CALLMFDLAPD : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly IFJNJDOONNL GLIHELCMDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly int LNEDNNJCPMG;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x13162B0", Offset = "0x13150B0", VA = "0x1813162B0")]
	public CALLMFDLAPD(IFJNJDOONNL EGHJKFJLBLH = IFJNJDOONNL.ExitingPlayMode, int JMHKMOACHDG = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IFJNJDOONNL
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
public class CBEAKPMNJOL : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly LGFJHLDANJN FEIDGIMOJCK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x13162F0", Offset = "0x13150F0", VA = "0x1813162F0")]
	public CBEAKPMNJOL(LGFJHLDANJN ENKNDKHNOAJ = LGFJHLDANJN.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LGFJHLDANJN
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
		private sealed class OKFFOJNPIAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3F20C0", Offset = "0x3F0EC0", VA = "0x1803F20C0")]
			public OKFFOJNPIAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1316430", Offset = "0x1315230", VA = "0x181316430")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x13164D0", Offset = "0x13152D0", VA = "0x1813164D0")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class PLJOEJHECHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3F20C0", Offset = "0x3F0EC0", VA = "0x1803F20C0")]
			public PLJOEJHECHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1316540", Offset = "0x1315340", VA = "0x181316540")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class EPEPPEKACHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3F20C0", Offset = "0x3F0EC0", VA = "0x1803F20C0")]
			public EPEPPEKACHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1316320", Offset = "0x1315120", VA = "0x181316320")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public const string OFOLDGFJPMO = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const string JLEIICKEOOG = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Dictionary<LGFJHLDANJN, IGrouping<LGFJHLDANJN, MethodInfo>> JIKCMKKNOPM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Type NJAPDKBHMBH;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x13166F0", Offset = "0x13154F0", VA = "0x1813166F0")]
		private static void CIAGDMEAAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1317970", Offset = "0x1316770", VA = "0x181317970")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x13165B0", Offset = "0x13153B0", VA = "0x1813165B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x13166A0", Offset = "0x13154A0", VA = "0x1813166A0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1316650", Offset = "0x1315450", VA = "0x181316650")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1316600", Offset = "0x1315400", VA = "0x181316600")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x13171F0", Offset = "0x1315FF0", VA = "0x1813171F0")]
		private static void GFCLHDJABIP(LGFJHLDANJN ENKNDKHNOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1317130", Offset = "0x1315F30", VA = "0x181317130")]
		private static IEnumerable<MethodInfo> FIPFGKGHMHN(Type NDJDGECDNNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x13172C0", Offset = "0x13160C0", VA = "0x1813172C0")]
		private static bool GLPLFDKEDIB(string DAKLDBEPNLC, out Dictionary<string, List<string>> COKAEFPBBKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1316BB0", Offset = "0x13159B0", VA = "0x181316BB0")]
		private static IEnumerable<Type> COKMLAGHMFJ(Dictionary<string, List<string>> COKAEFPBBKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1317520", Offset = "0x1316320", VA = "0x181317520")]
		private static IEnumerable<MethodInfo> JJMPAEOFMGK(IEnumerable<Type> BOEIMDMDGBF, Type NDJDGECDNNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x13175D0", Offset = "0x13163D0", VA = "0x1813175D0")]
		private static void LFOHBJJBAIG(IEnumerable<MethodInfo> PJIFOOKEJJB, Type AFAOEAIEPKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1317440", Offset = "0x1316240", VA = "0x181317440")]
		private static bool JDABLCGDGEB(MethodInfo FHDBBCPKAKB, Type GIIKFJEEFKO)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1317A50", Offset = "0x1316850", VA = "0x181317A50")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FFGJGGNEDMD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GGDNBDJKEGG FFDEELPIEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1316370", Offset = "0x1315170", VA = "0x181316370")]
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

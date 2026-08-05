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
	[Cpp2IlInjected.Address(RVA = "0x35D9630", Offset = "0x35D8A30", VA = "0x1835D9630")]
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
	[Cpp2IlInjected.Address(RVA = "0x35D9650", Offset = "0x35D8A50", VA = "0x1835D9650")]
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
	[Cpp2IlInjected.Address(RVA = "0x35D9690", Offset = "0x35D8A90", VA = "0x1835D9690")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DB280", Offset = "0x3DA680", VA = "0x1803DB280")]
			public OKFFOJNPIAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x35D97D0", Offset = "0x35D8BD0", VA = "0x1835D97D0")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x35D9870", Offset = "0x35D8C70", VA = "0x1835D9870")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DB280", Offset = "0x3DA680", VA = "0x1803DB280")]
			public PLJOEJHECHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x35D98E0", Offset = "0x35D8CE0", VA = "0x1835D98E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DB280", Offset = "0x3DA680", VA = "0x1803DB280")]
			public EPEPPEKACHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x35D96C0", Offset = "0x35D8AC0", VA = "0x1835D96C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x35D9A90", Offset = "0x35D8E90", VA = "0x1835D9A90")]
		private static void CIAGDMEAAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x35DAD10", Offset = "0x35DA110", VA = "0x1835DAD10")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x35D9950", Offset = "0x35D8D50", VA = "0x1835D9950")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x35D9A40", Offset = "0x35D8E40", VA = "0x1835D9A40")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x35D99F0", Offset = "0x35D8DF0", VA = "0x1835D99F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x35D99A0", Offset = "0x35D8DA0", VA = "0x1835D99A0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x35DA590", Offset = "0x35D9990", VA = "0x1835DA590")]
		private static void GFCLHDJABIP(LGFJHLDANJN ENKNDKHNOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x35DA4D0", Offset = "0x35D98D0", VA = "0x1835DA4D0")]
		private static IEnumerable<MethodInfo> FIPFGKGHMHN(Type NDJDGECDNNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x35DA660", Offset = "0x35D9A60", VA = "0x1835DA660")]
		private static bool GLPLFDKEDIB(string DAKLDBEPNLC, out Dictionary<string, List<string>> COKAEFPBBKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x35D9F50", Offset = "0x35D9350", VA = "0x1835D9F50")]
		private static IEnumerable<Type> COKMLAGHMFJ(Dictionary<string, List<string>> COKAEFPBBKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x35DA8C0", Offset = "0x35D9CC0", VA = "0x1835DA8C0")]
		private static IEnumerable<MethodInfo> JJMPAEOFMGK(IEnumerable<Type> BOEIMDMDGBF, Type NDJDGECDNNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x35DA970", Offset = "0x35D9D70", VA = "0x1835DA970")]
		private static void LFOHBJJBAIG(IEnumerable<MethodInfo> PJIFOOKEJJB, Type AFAOEAIEPKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x35DA7E0", Offset = "0x35D9BE0", VA = "0x1835DA7E0")]
		private static bool JDABLCGDGEB(MethodInfo FHDBBCPKAKB, Type GIIKFJEEFKO)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FFGJGGNEDMD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GGDNBDJKEGG FFDEELPIEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x35D9710", Offset = "0x35D8B10", VA = "0x1835D9710")]
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

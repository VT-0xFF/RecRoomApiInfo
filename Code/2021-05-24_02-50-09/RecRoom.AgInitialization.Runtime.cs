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
public class CALLMFDLAPD : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly IFJNJDOONNL GLIHELCMDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly int LNEDNNJCPMG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x35DE0B0", Offset = "0x35DD2B0", VA = "0x1835DE0B0")]
	public CALLMFDLAPD(IFJNJDOONNL teardownPhase = IFJNJDOONNL.ExitingPlayMode, int priority = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum IFJNJDOONNL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ExitingPlayMode,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	EnteredEditMode,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	EnteredEditModeNextFrame
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class CBEAKPMNJOL : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly LGFJHLDANJN FEIDGIMOJCK;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x35DE0F0", Offset = "0x35DD2F0", VA = "0x1835DE0F0")]
	public CBEAKPMNJOL(LGFJHLDANJN loadType = LGFJHLDANJN.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
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
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OKFFOJNPIAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3E0B10", Offset = "0x3DFD10", VA = "0x1803E0B10")]
			public OKFFOJNPIAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x35DE280", Offset = "0x35DD480", VA = "0x1835DE280")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x35DE320", Offset = "0x35DD520", VA = "0x1835DE320")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class PLJOEJHECHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3E0B10", Offset = "0x3DFD10", VA = "0x1803E0B10")]
			public PLJOEJHECHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x35DE390", Offset = "0x35DD590", VA = "0x1835DE390")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class EPEPPEKACHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3E0B10", Offset = "0x3DFD10", VA = "0x1803E0B10")]
			public EPEPPEKACHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x35DE120", Offset = "0x35DD320", VA = "0x1835DE120")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static Dictionary<LGFJHLDANJN, IGrouping<LGFJHLDANJN, MethodInfo>> JIKCMKKNOPM;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly Type NJAPDKBHMBH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static string OFOLDGFJPMO;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static string JLEIICKEOOG;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x35DE540", Offset = "0x35DD740", VA = "0x1835DE540")]
		private static void CIAGDMEAAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x35DF7C0", Offset = "0x35DE9C0", VA = "0x1835DF7C0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x35DE400", Offset = "0x35DD600", VA = "0x1835DE400")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x35DE4F0", Offset = "0x35DD6F0", VA = "0x1835DE4F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x35DE4A0", Offset = "0x35DD6A0", VA = "0x1835DE4A0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x35DE450", Offset = "0x35DD650", VA = "0x1835DE450")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x35DEF80", Offset = "0x35DE180", VA = "0x1835DEF80")]
		private static void EODOIDKGFBN(LGFJHLDANJN ENKNDKHNOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x35DF050", Offset = "0x35DE250", VA = "0x1835DF050")]
		private static IEnumerable<MethodInfo> FIPFGKGHMHN(Type NDJDGECDNNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x35DF110", Offset = "0x35DE310", VA = "0x1835DF110")]
		private static bool GLPLFDKEDIB(string DAKLDBEPNLC, out Dictionary<string, List<string>> COKAEFPBBKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x35DEA00", Offset = "0x35DDC00", VA = "0x1835DEA00")]
		private static IEnumerable<Type> COKMLAGHMFJ(Dictionary<string, List<string>> COKAEFPBBKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x35DF370", Offset = "0x35DE570", VA = "0x1835DF370")]
		private static IEnumerable<MethodInfo> JJMPAEOFMGK(IEnumerable<Type> BOEIMDMDGBF, Type NDJDGECDNNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x35DF420", Offset = "0x35DE620", VA = "0x1835DF420")]
		private static void LFOHBJJBAIG(IEnumerable<MethodInfo> PJIFOOKEJJB, Type AFAOEAIEPKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x35DF290", Offset = "0x35DE490", VA = "0x1835DF290")]
		private static bool JDABLCGDGEB(MethodInfo FHDBBCPKAKB, Type GIIKFJEEFKO)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FFGJGGNEDMD
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static string OCNMKKMHLFC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GGDNBDJKEGG FFDEELPIEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x35DE1A0", Offset = "0x35DD3A0", VA = "0x1835DE1A0")]
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

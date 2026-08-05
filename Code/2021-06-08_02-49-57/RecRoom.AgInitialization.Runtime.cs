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
	[Cpp2IlInjected.Address(RVA = "0x364D170", Offset = "0x364BF70", VA = "0x18364D170")]
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
	[Cpp2IlInjected.Address(RVA = "0x364D190", Offset = "0x364BF90", VA = "0x18364D190")]
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
	[Cpp2IlInjected.Address(RVA = "0x364D1D0", Offset = "0x364BFD0", VA = "0x18364D1D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7C80", Offset = "0x3E6A80", VA = "0x1803E7C80")]
			public OKFFOJNPIAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x364D310", Offset = "0x364C110", VA = "0x18364D310")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x364D3B0", Offset = "0x364C1B0", VA = "0x18364D3B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7C80", Offset = "0x3E6A80", VA = "0x1803E7C80")]
			public PLJOEJHECHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x364D420", Offset = "0x364C220", VA = "0x18364D420")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7C80", Offset = "0x3E6A80", VA = "0x1803E7C80")]
			public EPEPPEKACHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x364D200", Offset = "0x364C000", VA = "0x18364D200")]
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
		[Cpp2IlInjected.Address(RVA = "0x364D5D0", Offset = "0x364C3D0", VA = "0x18364D5D0")]
		private static void CIAGDMEAAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x364E850", Offset = "0x364D650", VA = "0x18364E850")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x364D490", Offset = "0x364C290", VA = "0x18364D490")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x364D580", Offset = "0x364C380", VA = "0x18364D580")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x364D530", Offset = "0x364C330", VA = "0x18364D530")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x364D4E0", Offset = "0x364C2E0", VA = "0x18364D4E0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x364E0D0", Offset = "0x364CED0", VA = "0x18364E0D0")]
		private static void GFCLHDJABIP(LGFJHLDANJN ENKNDKHNOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x364E010", Offset = "0x364CE10", VA = "0x18364E010")]
		private static IEnumerable<MethodInfo> FIPFGKGHMHN(Type NDJDGECDNNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x364E1A0", Offset = "0x364CFA0", VA = "0x18364E1A0")]
		private static bool GLPLFDKEDIB(string DAKLDBEPNLC, out Dictionary<string, List<string>> COKAEFPBBKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x364DA90", Offset = "0x364C890", VA = "0x18364DA90")]
		private static IEnumerable<Type> COKMLAGHMFJ(Dictionary<string, List<string>> COKAEFPBBKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x364E400", Offset = "0x364D200", VA = "0x18364E400")]
		private static IEnumerable<MethodInfo> JJMPAEOFMGK(IEnumerable<Type> BOEIMDMDGBF, Type NDJDGECDNNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x364E4B0", Offset = "0x364D2B0", VA = "0x18364E4B0")]
		private static void LFOHBJJBAIG(IEnumerable<MethodInfo> PJIFOOKEJJB, Type AFAOEAIEPKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x364E320", Offset = "0x364D120", VA = "0x18364E320")]
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
		[Cpp2IlInjected.Address(RVA = "0x364D250", Offset = "0x364C050", VA = "0x18364D250")]
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

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
public class IABMDIJNELF : PNOCAMMDJAE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x31FAD10", Offset = "0x31F9310", VA = "0x1831FAD10")]
	public IABMDIJNELF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class NNMDMIMABNG : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly GBGLFHCKFBK DOGGMBFIHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly int AEEKLJFHFLL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x31FAE40", Offset = "0x31F9440", VA = "0x1831FAE40")]
	public NNMDMIMABNG(GBGLFHCKFBK FALPCPCPNEA = GBGLFHCKFBK.ExitingPlayMode, int LMHEDNCJECN = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GBGLFHCKFBK
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
public class PNOCAMMDJAE : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly DMLDNLFOIDK DGPEBBCPHEA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x31FAE80", Offset = "0x31F9480", VA = "0x1831FAE80")]
	public PNOCAMMDJAE(DMLDNLFOIDK EPFOGIKMOEL = DMLDNLFOIDK.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DMLDNLFOIDK
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
		private sealed class ECGAMBMJKML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
			public ECGAMBMJKML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x31FABF0", Offset = "0x31F91F0", VA = "0x1831FABF0")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x31FACA0", Offset = "0x31F92A0", VA = "0x1831FACA0")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class BKGIKFGAHHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
			public BKGIKFGAHHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x31FAB80", Offset = "0x31F9180", VA = "0x1831FAB80")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class LCMABJKCOCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
			public LCMABJKCOCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x31FADF0", Offset = "0x31F93F0", VA = "0x1831FADF0")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public const string LFJGNCAHOPL = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const string GCHPHIPMFLN = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Dictionary<DMLDNLFOIDK, IGrouping<DMLDNLFOIDK, MethodInfo>> DAEJCFNIABB;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Type DHOPKEJMMLH;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x31FB350", Offset = "0x31F9950", VA = "0x1831FB350")]
		private static void LEGFOKOLNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x31FC430", Offset = "0x31FAA30", VA = "0x1831FC430")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x31FAFA0", Offset = "0x31F95A0", VA = "0x1831FAFA0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x31FB090", Offset = "0x31F9690", VA = "0x1831FB090")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x31FB040", Offset = "0x31F9640", VA = "0x1831FB040")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x31FAFF0", Offset = "0x31F95F0", VA = "0x1831FAFF0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x31FBCF0", Offset = "0x31FA2F0", VA = "0x1831FBCF0")]
		private static void LNBKEFIHFJN(DMLDNLFOIDK EPFOGIKMOEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x31FBDC0", Offset = "0x31FA3C0", VA = "0x1831FBDC0")]
		private static IEnumerable<MethodInfo> NAFJEEGDOPH(Type CLDFNFHFILH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x31FB0E0", Offset = "0x31F96E0", VA = "0x1831FB0E0")]
		private static bool EFKENCMNGON(string PJLLEKMPFNF, out Dictionary<string, List<string>> OLICFDDKOIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x31FBE80", Offset = "0x31FA480", VA = "0x1831FBE80")]
		private static IEnumerable<Type> PKOALEIMJEK(Dictionary<string, List<string>> OLICFDDKOIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x31FB2A0", Offset = "0x31F98A0", VA = "0x1831FB2A0")]
		private static IEnumerable<MethodInfo> FOFEMMMMFHP(IEnumerable<Type> OMDOOIJPNIN, Type CLDFNFHFILH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x31FB850", Offset = "0x31F9E50", VA = "0x1831FB850")]
		private static void LJOFPLABNED(IEnumerable<MethodInfo> OLPBCNFGKNP, Type KGEKLAHNELC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x31FAEB0", Offset = "0x31F94B0", VA = "0x1831FAEB0")]
		private static bool AMHONBAHNGH(MethodInfo ALFFOMEHBAF, Type NMHPIHJFONC)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x31FC540", Offset = "0x31FAB40", VA = "0x1831FC540")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JFJMIIHLNHE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DLGBCEDOHMO JEAEKLPDKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x31FAD30", Offset = "0x31F9330", VA = "0x1831FAD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EMJIBBLCBJK<T> : IDisposable where T : global::EMJIBBLCBJK<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static T IFCFNOCHCHA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T EJBAJGKCNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1E52E00", Offset = "0x1E51400", VA = "0x181E52E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
	protected EMJIBBLCBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1E52DC0", Offset = "0x1E513C0", VA = "0x181E52DC0", Slot = "5")]
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

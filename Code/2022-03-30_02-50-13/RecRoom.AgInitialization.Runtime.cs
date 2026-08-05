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
public class FFEDPJMKNFO : MCFFJIPBJIN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4B13C00", Offset = "0x4B12200", VA = "0x184B13C00")]
	public FFEDPJMKNFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class BFFCGBPBDIO : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly MHIIHFJKCKA INFHMFHFMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly int AAIKKFEEOBN;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B13B00", Offset = "0x4B12100", VA = "0x184B13B00")]
	public BFFCGBPBDIO(MHIIHFJKCKA HOFJGJILKDM = MHIIHFJKCKA.ExitingPlayMode, int BEFFNCBJGPL = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MHIIHFJKCKA
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
public class MCFFJIPBJIN : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly BIILMEDIMOB DBEJDDKKILH;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B13C70", Offset = "0x4B12270", VA = "0x184B13C70")]
	public MCFFJIPBJIN(BIILMEDIMOB FLIFMMABAMO = BIILMEDIMOB.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BIILMEDIMOB
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
		private sealed class OGAFFEOAEPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
			public OGAFFEOAEPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4B13D10", Offset = "0x4B12310", VA = "0x184B13D10")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4B13DC0", Offset = "0x4B123C0", VA = "0x184B13DC0")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class NPNDEGILBHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
			public NPNDEGILBHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x4B13CA0", Offset = "0x4B122A0", VA = "0x184B13CA0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class KOICFFCOKOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
			public KOICFFCOKOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x4B13C20", Offset = "0x4B12220", VA = "0x184B13C20")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public const string DCHPFOKCJLH = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const string LHKNOMKGJLF = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Dictionary<BIILMEDIMOB, IGrouping<BIILMEDIMOB, MethodInfo>> LKAJKAHDJLE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Type AHGJGANBAEO;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4B14690", Offset = "0x4B12C90", VA = "0x184B14690")]
		private static void CLHFBJIFGBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4B153B0", Offset = "0x4B139B0", VA = "0x184B153B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4B13EE0", Offset = "0x4B124E0", VA = "0x184B13EE0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4B13FD0", Offset = "0x4B125D0", VA = "0x184B13FD0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4B13F80", Offset = "0x4B12580", VA = "0x184B13F80")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4B13F30", Offset = "0x4B12530", VA = "0x184B13F30")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4B152E0", Offset = "0x4B138E0", VA = "0x184B152E0")]
		private static void KLMCMCPGOOJ(BIILMEDIMOB FLIFMMABAMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4B145D0", Offset = "0x4B12BD0", VA = "0x184B145D0")]
		private static IEnumerable<MethodInfo> CHNJOPGPFPJ(Type CGCEOODFMLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4B14B90", Offset = "0x4B13190", VA = "0x184B14B90")]
		private static bool HCHCAOENBAM(string OHBJGKIPBLO, out Dictionary<string, List<string>> PHKNMHDLNLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4B14020", Offset = "0x4B12620", VA = "0x184B14020")]
		private static IEnumerable<Type> CAOJGCELJBA(Dictionary<string, List<string>> PHKNMHDLNLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4B13E30", Offset = "0x4B12430", VA = "0x184B13E30")]
		private static IEnumerable<MethodInfo> ACHBJNOIDAI(IEnumerable<Type> NJDLJALJJHC, Type CGCEOODFMLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4B14E40", Offset = "0x4B13440", VA = "0x184B14E40")]
		private static void KKKKFIIONDB(IEnumerable<MethodInfo> FBBBCKABGFJ, Type INNIEDLCLKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4B14D50", Offset = "0x4B13350", VA = "0x184B14D50")]
		private static bool HEBFADGDGAI(MethodInfo HLDCLHEICJG, Type CCBLKMGMKBF)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4B154C0", Offset = "0x4B13AC0", VA = "0x184B154C0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BLKCLPNFHJH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static KLGPHPCNJIB JLJGCJNJJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4B13B40", Offset = "0x4B12140", VA = "0x184B13B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HKNNLJLIONL<T> : IDisposable where T : global::HKNNLJLIONL<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static T LEGAKGDGMIM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T KPCEMOHFCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x29BC3D0", Offset = "0x29BA9D0", VA = "0x1829BC3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
	protected HKNNLJLIONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29BC390", Offset = "0x29BA990", VA = "0x1829BC390", Slot = "5")]
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

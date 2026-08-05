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
public class PDLJDMPPJFF : FHLGJPGAKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1B80A20", Offset = "0x1B7F220", VA = "0x181B80A20")]
	public PDLJDMPPJFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class IHAEEOOOIEN : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly HNJFJNMDEKM KHEJPJAHANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly int FFCGMNODNGP;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1B80970", Offset = "0x1B7F170", VA = "0x181B80970")]
	public IHAEEOOOIEN(HNJFJNMDEKM EHHLPIGLAMN = HNJFJNMDEKM.ExitingPlayMode, int FCBGEDDMHBG = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HNJFJNMDEKM
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
public class FHLGJPGAKJP : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly LJAFIMJAFBL IICMBKNCHGE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1B80760", Offset = "0x1B7EF60", VA = "0x181B80760")]
	public FHLGJPGAKJP(LJAFIMJAFBL IFPEOJKAEMF = LJAFIMJAFBL.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LJAFIMJAFBL
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
		private sealed class HGGECCKCCCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
			public HGGECCKCCCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1B80850", Offset = "0x1B7F050", VA = "0x181B80850")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1B80900", Offset = "0x1B7F100", VA = "0x181B80900")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class OBIHPOHIJFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
			public OBIHPOHIJFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1B809B0", Offset = "0x1B7F1B0", VA = "0x181B809B0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class CELLMBCNBLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
			public CELLMBCNBLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1B80710", Offset = "0x1B7EF10", VA = "0x181B80710")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public const string OHKBKAHCEEL = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const string MJMPEHEBBDE = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Dictionary<LJAFIMJAFBL, IGrouping<LJAFIMJAFBL, MethodInfo>> LNMJJEDMDLI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Type OOFEECJPDBN;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1B81450", Offset = "0x1B7FC50", VA = "0x181B81450")]
		private static void IHJOGFOBIMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1B81FC0", Offset = "0x1B807C0", VA = "0x181B81FC0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1B80AF0", Offset = "0x1B7F2F0", VA = "0x181B80AF0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1B80BE0", Offset = "0x1B7F3E0", VA = "0x181B80BE0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1B80B90", Offset = "0x1B7F390", VA = "0x181B80B90")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1B80B40", Offset = "0x1B7F340", VA = "0x181B80B40")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1B80C30", Offset = "0x1B7F430", VA = "0x181B80C30")]
		private static void CDOJGHPCKGP(LJAFIMJAFBL IFPEOJKAEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1B81F00", Offset = "0x1B80700", VA = "0x181B81F00")]
		private static IEnumerable<MethodInfo> NHKIOHPICBC(Type PCGGOAMJCDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1B81290", Offset = "0x1B7FA90", VA = "0x181B81290")]
		private static bool HNNLIELIHDF(string JDFNFLNIOFJ, out Dictionary<string, List<string>> OCGIHLGGMFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1B81950", Offset = "0x1B80150", VA = "0x181B81950")]
		private static IEnumerable<Type> IHPONJBIDNL(Dictionary<string, List<string>> OCGIHLGGMFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1B80A40", Offset = "0x1B7F240", VA = "0x181B80A40")]
		private static IEnumerable<MethodInfo> ACCEBKHFGPM(IEnumerable<Type> BHJDLMLJAKI, Type PCGGOAMJCDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1B80DF0", Offset = "0x1B7F5F0", VA = "0x181B80DF0")]
		private static void HMKJCPHKBLL(IEnumerable<MethodInfo> PGGBNMGLHAI, Type MEKCGFPFBHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1B80D00", Offset = "0x1B7F500", VA = "0x181B80D00")]
		private static bool GADNGBJELAH(MethodInfo LBCKFNFNGOK, Type NADNKHMKKNN)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1B820D0", Offset = "0x1B808D0", VA = "0x181B820D0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FJHGKACELCK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static KBJKDMPFBEM JLLLOONDCPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1B80790", Offset = "0x1B7EF90", VA = "0x181B80790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OFAIDJKLBPE<T> : IDisposable where T : global::OFAIDJKLBPE<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static T PKNDEONBAMM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T OONGLDHDBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x43A0EF0", Offset = "0x439F6F0", VA = "0x1843A0EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
	protected OFAIDJKLBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x43A0EB0", Offset = "0x439F6B0", VA = "0x1843A0EB0", Slot = "5")]
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[AttributeUsage(AttributeTargets.Method)]
	public class RREditorTeardownMethodAttribute : PreserveAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly RREditorTeardownPhase TeardownPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly int Priority;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3541980", Offset = "0x3540B80", VA = "0x183541980")]
		public RREditorTeardownMethodAttribute(RREditorTeardownPhase teardownPhase = RREditorTeardownPhase.ExitingPlayMode, int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum RREditorTeardownPhase
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
	public class RRInitializeOnLoadMethodAttribute : PreserveAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly RuntimeInitializeLoadType LoadType;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x35419C0", Offset = "0x3540BC0", VA = "0x1835419C0")]
		public RRInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType = RuntimeInitializeLoadType.Unity_AfterSceneLoad)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum RuntimeInitializeLoadType
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
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public const string StreamingAssetsFolderName = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const string RuntimeInitializedMethodsFilename = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Dictionary<RuntimeInitializeLoadType, IGrouping<RuntimeInitializeLoadType, MethodInfo>> loadTypeMethods;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Type runtimeInitializeAttributeType;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3541B30", Offset = "0x3540D30", VA = "0x183541B30")]
		private static void CacheRuntimeInitializationMethods()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3542C30", Offset = "0x3541E30", VA = "0x183542C30")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x35419F0", Offset = "0x3540BF0", VA = "0x1835419F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3541AE0", Offset = "0x3540CE0", VA = "0x183541AE0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3541A90", Offset = "0x3540C90", VA = "0x183541A90")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3541A40", Offset = "0x3540C40", VA = "0x183541A40")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3542620", Offset = "0x3541820", VA = "0x183542620")]
		private static void InvokeInitializeOnLoadMethods(RuntimeInitializeLoadType loadType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3542B70", Offset = "0x3541D70", VA = "0x183542B70")]
		private static IEnumerable<MethodInfo> RetrieveMethodsFromEditorTypeCache(Type requiredAttribute)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3542C90", Offset = "0x3541E90", VA = "0x183542C90")]
		private static bool TryLoadTypesFromMappingFile(string fileName, out Dictionary<string, List<string>> typeNames)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x35420A0", Offset = "0x35412A0", VA = "0x1835420A0")]
		private static IEnumerable<Type> GetTypesFromTypeNames(Dictionary<string, List<string>> typeNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3541FF0", Offset = "0x35411F0", VA = "0x183541FF0")]
		private static IEnumerable<MethodInfo> GetMethodsUsingReflection(IEnumerable<Type> types, Type requiredAttribute)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x35426F0", Offset = "0x35418F0", VA = "0x1835426F0")]
		private static void InvokeStaticMethodsWithAttribute(IEnumerable<MethodInfo> sourceMethods, Type attributeType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3542A90", Offset = "0x3541C90", VA = "0x183542A90")]
		private static bool IsValidStaticMethod(MethodInfo methodInfo, Type requiredAttributeType)
		{
			return default(bool);
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

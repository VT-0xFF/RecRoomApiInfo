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
		[Cpp2IlInjected.Address(RVA = "0x3541400", Offset = "0x3540200", VA = "0x183541400")]
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
		[Cpp2IlInjected.Address(RVA = "0x3541440", Offset = "0x3540240", VA = "0x183541440")]
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
		[Cpp2IlInjected.Address(RVA = "0x35415B0", Offset = "0x35403B0", VA = "0x1835415B0")]
		private static void CacheRuntimeInitializationMethods()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x35426B0", Offset = "0x35414B0", VA = "0x1835426B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3541470", Offset = "0x3540270", VA = "0x183541470")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3541560", Offset = "0x3540360", VA = "0x183541560")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3541510", Offset = "0x3540310", VA = "0x183541510")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x35414C0", Offset = "0x35402C0", VA = "0x1835414C0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x35420A0", Offset = "0x3540EA0", VA = "0x1835420A0")]
		private static void InvokeInitializeOnLoadMethods(RuntimeInitializeLoadType loadType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x35425F0", Offset = "0x35413F0", VA = "0x1835425F0")]
		private static IEnumerable<MethodInfo> RetrieveMethodsFromEditorTypeCache(Type requiredAttribute)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3542710", Offset = "0x3541510", VA = "0x183542710")]
		private static bool TryLoadTypesFromMappingFile(string fileName, out Dictionary<string, List<string>> typeNames)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3541B20", Offset = "0x3540920", VA = "0x183541B20")]
		private static IEnumerable<Type> GetTypesFromTypeNames(Dictionary<string, List<string>> typeNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3541A70", Offset = "0x3540870", VA = "0x183541A70")]
		private static IEnumerable<MethodInfo> GetMethodsUsingReflection(IEnumerable<Type> types, Type requiredAttribute)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3542170", Offset = "0x3540F70", VA = "0x183542170")]
		private static void InvokeStaticMethodsWithAttribute(IEnumerable<MethodInfo> sourceMethods, Type attributeType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3542510", Offset = "0x3541310", VA = "0x183542510")]
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x3381DF0", Offset = "0x33811F0", VA = "0x183381DF0")]
		public RREditorTeardownMethodAttribute(RREditorTeardownPhase teardownPhase = RREditorTeardownPhase.ExitingPlayMode, int priority = 0)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
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
		[Cpp2IlInjected.Address(RVA = "0x3381E30", Offset = "0x3381230", VA = "0x183381E30")]
		public RRInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType = RuntimeInitializeLoadType.Unity_AfterSceneLoad)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
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
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class <GetTypesFromTypeNames>d__13 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private Type <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private Dictionary<string, List<string>> typeNames;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Dictionary<string, List<string>> <>3__typeNames;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Dictionary<string, List<string>>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Assembly <assembly>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private List<string>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			Type IEnumerator<Type>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x3E6240", Offset = "0x3E5640", VA = "0x1803E6240", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x3E6240", Offset = "0x3E5640", VA = "0x1803E6240", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x601BB0", Offset = "0x600FB0", VA = "0x180601BB0")]
			[DebuggerHidden]
			public <GetTypesFromTypeNames>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x33832B0", Offset = "0x33826B0", VA = "0x1833832B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3382E80", Offset = "0x3382280", VA = "0x183382E80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x33833B0", Offset = "0x33827B0", VA = "0x1833833B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x33833F0", Offset = "0x33827F0", VA = "0x1833833F0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3383260", Offset = "0x3382660", VA = "0x183383260", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x33831C0", Offset = "0x33825C0", VA = "0x1833831C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x33831C0", Offset = "0x33825C0", VA = "0x1833831C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public const string StreamingAssetsFolderName = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const string RuntimeInitializedMethodsFilename = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Dictionary<RuntimeInitializeLoadType, IGrouping<RuntimeInitializeLoadType, MethodInfo>> loadTypeMethods;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Type runtimeInitializeAttributeType;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3381FA0", Offset = "0x33813A0", VA = "0x183381FA0")]
		private static void CacheRuntimeInitializationMethods()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3382C00", Offset = "0x3382000", VA = "0x183382C00")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3381E60", Offset = "0x3381260", VA = "0x183381E60")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3381F50", Offset = "0x3381350", VA = "0x183381F50")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3381F00", Offset = "0x3381300", VA = "0x183381F00")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3381EB0", Offset = "0x33812B0", VA = "0x183381EB0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x33825C0", Offset = "0x33819C0", VA = "0x1833825C0")]
		private static void InvokeInitializeOnLoadMethods(RuntimeInitializeLoadType loadType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3382B40", Offset = "0x3381F40", VA = "0x183382B40")]
		private static IEnumerable<MethodInfo> RetrieveMethodsFromEditorTypeCache(Type requiredAttribute)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3382C60", Offset = "0x3382060", VA = "0x183382C60")]
		private static bool TryLoadTypesFromMappingFile(string fileName, out Dictionary<string, List<string>> typeNames)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3382550", Offset = "0x3381950", VA = "0x183382550")]
		[IteratorStateMachine(typeof(<GetTypesFromTypeNames>d__13))]
		private static IEnumerable<Type> GetTypesFromTypeNames(Dictionary<string, List<string>> typeNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x33824A0", Offset = "0x33818A0", VA = "0x1833824A0")]
		private static IEnumerable<MethodInfo> GetMethodsUsingReflection(IEnumerable<Type> types, Type requiredAttribute)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3382690", Offset = "0x3381A90", VA = "0x183382690")]
		private static void InvokeStaticMethodsWithAttribute(IEnumerable<MethodInfo> sourceMethods, Type attributeType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3382A60", Offset = "0x3381E60", VA = "0x183382A60")]
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

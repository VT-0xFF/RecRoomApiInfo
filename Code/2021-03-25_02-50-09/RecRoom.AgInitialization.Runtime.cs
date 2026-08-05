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
	public class RRInitializeOnLoadMethodAttribute : PreserveAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly RuntimeInitializeLoadType LoadType;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3309810", Offset = "0x3308010", VA = "0x183309810")]
		public RRInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType = RuntimeInitializeLoadType.Unity_AfterSceneLoad)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Method)]
	public class RRTeardownOnUnloadMethodAttribute : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x454A80", Offset = "0x453280", VA = "0x180454A80")]
		public RRTeardownOnUnloadMethodAttribute()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum RuntimeInitializeLoadType
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Unity_AfterSceneLoad,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Unity_BeforeSceneLoad,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Unity_AfterAssembliesLoaded,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Unity_BeforeSplashScreen,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Unity_SubsystemRegistration
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class <GetTypesFromTypeNames>d__13 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private Type <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private Dictionary<string, List<string>> typeNames;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<string, List<string>> <>3__typeNames;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Dictionary<string, List<string>>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private Assembly <assembly>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private List<string>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			Type IEnumerator<Type>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x3CA670", Offset = "0x3C8E70", VA = "0x1803CA670", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3CA670", Offset = "0x3C8E70", VA = "0x1803CA670", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4C9CD0", Offset = "0x4C84D0", VA = "0x1804C9CD0")]
			[DebuggerHidden]
			public <GetTypesFromTypeNames>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x330AC90", Offset = "0x3309490", VA = "0x18330AC90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x330A860", Offset = "0x3309060", VA = "0x18330A860", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x330AD90", Offset = "0x3309590", VA = "0x18330AD90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x330ADD0", Offset = "0x33095D0", VA = "0x18330ADD0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x330AC40", Offset = "0x3309440", VA = "0x18330AC40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x330ABA0", Offset = "0x33093A0", VA = "0x18330ABA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x330ABA0", Offset = "0x33093A0", VA = "0x18330ABA0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string StreamingAssetsFolderName = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public const string RuntimeInitializedMethodsFilename = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static Dictionary<RuntimeInitializeLoadType, IGrouping<RuntimeInitializeLoadType, MethodInfo>> loadTypeMethods;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly Type runtimeInitializeAttributeType;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3309980", Offset = "0x3308180", VA = "0x183309980")]
		private static void CacheRuntimeInitializationMethods()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x330A5E0", Offset = "0x3308DE0", VA = "0x18330A5E0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3309840", Offset = "0x3308040", VA = "0x183309840")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3309930", Offset = "0x3308130", VA = "0x183309930")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x33098E0", Offset = "0x33080E0", VA = "0x1833098E0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3309890", Offset = "0x3308090", VA = "0x183309890")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3309FA0", Offset = "0x33087A0", VA = "0x183309FA0")]
		private static void InvokeInitializeOnLoadMethods(RuntimeInitializeLoadType loadType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x330A520", Offset = "0x3308D20", VA = "0x18330A520")]
		private static IEnumerable<MethodInfo> RetrieveMethodsFromEditorTypeCache(Type requiredAttribute)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x330A640", Offset = "0x3308E40", VA = "0x18330A640")]
		private static bool TryLoadTypesFromMappingFile(string fileName, out Dictionary<string, List<string>> typeNames)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3309F30", Offset = "0x3308730", VA = "0x183309F30")]
		[IteratorStateMachine(typeof(<GetTypesFromTypeNames>d__13))]
		private static IEnumerable<Type> GetTypesFromTypeNames(Dictionary<string, List<string>> typeNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3309E80", Offset = "0x3308680", VA = "0x183309E80")]
		private static IEnumerable<MethodInfo> GetMethodsUsingReflection(IEnumerable<Type> types, Type requiredAttribute)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x330A070", Offset = "0x3308870", VA = "0x18330A070")]
		private static void InvokeStaticMethodsWithAttribute(IEnumerable<MethodInfo> sourceMethods, Type attributeType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x330A440", Offset = "0x3308C40", VA = "0x18330A440")]
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

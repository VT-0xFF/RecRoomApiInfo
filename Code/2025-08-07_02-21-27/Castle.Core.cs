using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Castle.Core.Internal;
using Castle.Core.Logging;
using Castle.DynamicProxy.Contributors;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Cpp2IlInjected;

[assembly: AssemblyVersion("5.0.0.0")]
namespace Castle.DynamicProxy
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public abstract class AbstractInvocation : IInvocation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly IInterceptor[] interceptors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int currentInterceptorIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private Type[] genericMethodArguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly MethodInfo proxiedMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected readonly object proxyObject;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public object Proxy
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MethodInfo Method
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public object ReturnValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB13160", Offset = "0xB11D60", VA = "0x180B13160", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B400", Offset = "0x2D0A000", VA = "0x182D0B400")]
		protected AbstractInvocation(object proxy, IInterceptor[] interceptors, MethodInfo proxiedMethod, object[] arguments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
		public void SetGenericMethodArguments(Type[] arguments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B180", Offset = "0x2D09D80", VA = "0x182D0B180", Slot = "10")]
		public void SetArgumentValue(int index, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B000", Offset = "0x2D09C00", VA = "0x182D0B000", Slot = "11")]
		public object GetArgumentValue(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B030", Offset = "0x2D09C30", VA = "0x182D0B030", Slot = "9")]
		public void Proceed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void InvokeMethodOnTarget();

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B210", Offset = "0x2D09E10", VA = "0x182D0B210")]
		protected void ThrowOnNoTarget()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AllMethodsHook : IProxyGenerationHook
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected static readonly ICollection<Type> SkippedTypes;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D7F0", Offset = "0x2D0C3F0", VA = "0x182D0D7F0", Slot = "7")]
		public virtual bool ShouldInterceptMethod(Type type, MethodInfo methodInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
		public virtual void NonProxyableMemberNotification(Type type, MemberInfo memberInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "9")]
		public virtual void MethodsInspected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D740", Offset = "0x2D0C340", VA = "0x182D0D740", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D7B0", Offset = "0x2D0C3B0", VA = "0x182D0D7B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public AllMethodsHook()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CustomAttributeInfo : IEquatable<CustomAttributeInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class AttributeArgumentValueEqualityComparer : IEqualityComparer<object>
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2D0E090", Offset = "0x2D0CC90", VA = "0x182D0E090", Slot = "4")]
			bool IEqualityComparer<object>.Equals(object x, object y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2D0E1C0", Offset = "0x2D0CDC0", VA = "0x182D0E1C0", Slot = "5")]
			int IEqualityComparer<object>.GetHashCode(object obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2D0DF80", Offset = "0x2D0CB80", VA = "0x182D0DF80")]
			private static IEnumerable<object> AsObjectEnumerable(object array)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public AttributeArgumentValueEqualityComparer()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly PropertyInfo[] EmptyProperties;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly FieldInfo[] EmptyFields;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly object[] EmptyValues;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly IEqualityComparer<object> ValueComparer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly CustomAttributeBuilder builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly ConstructorInfo constructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly object[] constructorArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly IDictionary<string, object> properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IDictionary<string, object> fields;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal CustomAttributeBuilder Builder
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2D18850", Offset = "0x2D17450", VA = "0x182D18850")]
		public CustomAttributeInfo(ConstructorInfo constructor, object[] constructorArgs, PropertyInfo[] namedProperties, object[] propertyValues, FieldInfo[] namedFields, object[] fieldValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2D187A0", Offset = "0x2D173A0", VA = "0x182D187A0")]
		public CustomAttributeInfo(ConstructorInfo constructor, object[] constructorArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2D18430", Offset = "0x2D17030", VA = "0x182D18430", Slot = "4")]
		public bool Equals(CustomAttributeInfo other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2D18240", Offset = "0x2D16E40", VA = "0x182D18240", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2D18580", Offset = "0x2D17180", VA = "0x182D18580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2D17920", Offset = "0x2D16520", VA = "0x182D17920")]
		private static bool AreMembersEquivalent(IDictionary<string, object> x, IDictionary<string, object> y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2D17CB0", Offset = "0x2D168B0", VA = "0x182D17CB0")]
		private static int CombineHashCodes(IEnumerable<object> values)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2D17F50", Offset = "0x2D16B50", VA = "0x182D17F50")]
		private static int CombineMemberHashCodes(IDictionary<string, object> dict)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3A860C0", Offset = "0x3A84CC0", VA = "0x183A860C0")]
		private IDictionary<string, object> MakeNameValueDictionary<T>(T[] members, object[] values) where T : MemberInfo
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DefaultProxyBuilder : IProxyBuilder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly ModuleScope scope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private ILogger logger;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2D191B0", Offset = "0x2D17DB0", VA = "0x182D191B0")]
		public DefaultProxyBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2D19270", Offset = "0x2D17E70", VA = "0x182D19270")]
		public DefaultProxyBuilder(ModuleScope scope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2D18F30", Offset = "0x2D17B30", VA = "0x182D18F30", Slot = "5")]
		public Type CreateClassProxyType(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2D19050", Offset = "0x2D17C50", VA = "0x182D19050", Slot = "6")]
		public Type CreateInterfaceProxyTypeWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2D18A10", Offset = "0x2D17610", VA = "0x182D18A10")]
		private void AssertValidMixins(ProxyGenerationOptions options, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2D18D50", Offset = "0x2D17950", VA = "0x182D18D50")]
		private void AssertValidType(Type target, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2D18AE0", Offset = "0x2D176E0", VA = "0x182D18AE0")]
		private void AssertValidTypeForTarget(Type type, Type target, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2D18D70", Offset = "0x2D17970", VA = "0x182D18D70")]
		private void AssertValidTypes(IEnumerable<Type> targetTypes, string paramName)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class DynamicProxyException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2D19E00", Offset = "0x2D18A00", VA = "0x182D19E00")]
		internal DynamicProxyException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2D19D90", Offset = "0x2D18990", VA = "0x182D19D90")]
		internal DynamicProxyException(string message, Exception innerException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2D19E60", Offset = "0x2D18A60", VA = "0x182D19E60")]
		internal DynamicProxyException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class ExceptionMessageBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A3C0", Offset = "0x2D18FC0", VA = "0x182D1A3C0")]
		internal static string CreateInstructionsToMakeVisible(Assembly targetAssembly)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A610", Offset = "0x2D19210", VA = "0x182D1A610")]
		public static string CreateMessageForInaccessibleType(Type inaccessibleType, Type typeToProxy)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface IChangeProxyTarget
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface IInterceptor
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Intercept(IInvocation invocation);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface IInterceptorSelector
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IInvocation
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		MethodInfo Method
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object Proxy
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object ReturnValue
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Proceed();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface IProxyBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Type CreateClassProxyType(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Type CreateInterfaceProxyTypeWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IProxyGenerationHook
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MethodsInspected();

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NonProxyableMemberNotification(Type type, MemberInfo memberInfo);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ShouldInterceptMethod(Type type, MethodInfo methodInfo);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface IProxyTargetAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DynProxySetTarget(object target);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class MixinData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly Dictionary<Type, int> mixinPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly List<object> mixinsImpl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int delegateMixinCount;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<Type> MixinInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2D26220", Offset = "0x2D24E20", VA = "0x182D26220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IEnumerable<object> Mixins
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2D25700", Offset = "0x2D24300", VA = "0x182D25700")]
		public MixinData(IEnumerable<object> mixinInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2D25000", Offset = "0x2D23C00", VA = "0x182D25000")]
		public bool ContainsMixin(Type mixinInterfaceType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2D25060", Offset = "0x2D23C60", VA = "0x182D25060", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2D25490", Offset = "0x2D24090", VA = "0x182D25490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2D25670", Offset = "0x2D24270", VA = "0x182D25670")]
		public object GetMixinInstance(Type mixinInterfaceType)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ModuleScope
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly string DEFAULT_FILE_NAME;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly string DEFAULT_ASSEMBLY_NAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private ModuleBuilder moduleBuilderWithStrongName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private ModuleBuilder moduleBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly string strongAssemblyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly string weakAssemblyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly string strongModulePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly string weakModulePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly SynchronizedDictionary<CacheKey, Type> typeCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly object moduleLocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly bool savePhysicalAssembly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly bool disableSignedModule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly INamingScope namingScope;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		internal INamingScope NamingScope
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		internal SynchronizedDictionary<CacheKey, Type> TypeCache
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string StrongNamedModuleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2D27220", Offset = "0x2D25E20", VA = "0x182D27220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string StrongNamedModuleDirectory
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2D271B0", Offset = "0x2D25DB0", VA = "0x182D271B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string WeakNamedModuleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x2D272F0", Offset = "0x2D25EF0", VA = "0x182D272F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string WeakNamedModuleDirectory
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2D27270", Offset = "0x2D25E70", VA = "0x182D27270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2D26F90", Offset = "0x2D25B90", VA = "0x182D26F90")]
		public ModuleScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2D26FA0", Offset = "0x2D25BA0", VA = "0x182D26FA0")]
		public ModuleScope(bool savePhysicalAssembly, bool disableSignedModule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2D26DD0", Offset = "0x2D259D0", VA = "0x182D26DD0")]
		public ModuleScope(bool savePhysicalAssembly, bool disableSignedModule, string strongAssemblyName, string strongModulePath, string weakAssemblyName, string weakModulePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2D26C90", Offset = "0x2D25890", VA = "0x182D26C90")]
		internal ModuleScope(bool savePhysicalAssembly, bool disableSignedModule, INamingScope namingScope, string strongAssemblyName, string strongModulePath, string weakAssemblyName, string weakModulePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2D26760", Offset = "0x2D25360", VA = "0x182D26760")]
		public static byte[] GetKeyPair()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2D26BC0", Offset = "0x2D257C0", VA = "0x182D26BC0")]
		internal ModuleBuilder ObtainDynamicModule(bool isStrongNamed)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2D26950", Offset = "0x2D25550", VA = "0x182D26950")]
		internal ModuleBuilder ObtainDynamicModuleWithStrongName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2D26AB0", Offset = "0x2D256B0", VA = "0x182D26AB0")]
		internal ModuleBuilder ObtainDynamicModuleWithWeakName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2D26270", Offset = "0x2D24E70", VA = "0x182D26270")]
		private ModuleBuilder CreateModule(bool signStrongName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2D26670", Offset = "0x2D25270", VA = "0x182D26670")]
		private AssemblyName GetAssemblyName(bool signStrongName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2D26610", Offset = "0x2D25210", VA = "0x182D26610")]
		internal TypeBuilder DefineType(bool inSignedModulePreferably, string name, TypeAttributes flags)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ProxyGenerationOptions : ISerializable
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly ProxyGenerationOptions Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private List<object> mixins;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly IList<CustomAttributeInfo> additionalAttributes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private MixinData mixinData;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IProxyGenerationHook Hook
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IInterceptorSelector Selector
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Type BaseTypeForInterfaceProxy
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IList<CustomAttributeInfo> AdditionalAttributes
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MixinData MixinData
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2D29150", Offset = "0x2D27D50", VA = "0x182D29150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool HasMixins
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2D29100", Offset = "0x2D27D00", VA = "0x182D29100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2D28F30", Offset = "0x2D27B30", VA = "0x182D28F30")]
		public ProxyGenerationOptions(IProxyGenerationHook hook)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2D29000", Offset = "0x2D27C00", VA = "0x182D29000")]
		public ProxyGenerationOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2D28C20", Offset = "0x2D27820", VA = "0x182D28C20")]
		private ProxyGenerationOptions(SerializationInfo info, StreamingContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2D289F0", Offset = "0x2D275F0", VA = "0x182D289F0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2D28780", Offset = "0x2D27380", VA = "0x182D28780", Slot = "4")]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2D27E00", Offset = "0x2D26A00", VA = "0x182D27E00")]
		public void AddDelegateTypeMixin(Type delegateType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2D28070", Offset = "0x2D26C70", VA = "0x182D28070")]
		private void AddMixinImpl(object instanceOrType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2D28180", Offset = "0x2D26D80", VA = "0x182D28180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2D28620", Offset = "0x2D27220", VA = "0x182D28620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2D28440", Offset = "0x2D27040", VA = "0x182D28440")]
		private int GetAdditionalAttributesHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2D28860", Offset = "0x2D27460", VA = "0x182D28860")]
		private bool HasEquivalentAdditionalAttributes(ProxyGenerationOptions other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CLSCompliant(true)]
	public class ProxyGenerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly IProxyBuilder proxyBuilder;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2D2A430", Offset = "0x2D29030", VA = "0x182D2A430", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public IProxyBuilder ProxyBuilder
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A310", Offset = "0x2D28F10", VA = "0x182D2A310")]
		public ProxyGenerator(IProxyBuilder builder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A120", Offset = "0x2D28D20", VA = "0x182D2A120")]
		public ProxyGenerator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2D29EF0", Offset = "0x2D28AF0", VA = "0x182D29EF0")]
		protected List<object> GetConstructorArguments(object target, IInterceptor[] interceptors, ProxyGenerationOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2D29C80", Offset = "0x2D28880", VA = "0x182D29C80", Slot = "6")]
		public virtual object CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options, params IInterceptor[] interceptors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2D29930", Offset = "0x2D28530", VA = "0x182D29930", Slot = "7")]
		public object CreateClassProxy(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options, params IInterceptor[] interceptors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2D29970", Offset = "0x2D28570", VA = "0x182D29970", Slot = "8")]
		public virtual object CreateClassProxy(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options, object[] constructorArguments, params IInterceptor[] interceptors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2D29620", Offset = "0x2D28220", VA = "0x182D29620")]
		protected object CreateClassProxyInstance(Type proxyType, List<object> proxyArguments, Type classToProxy, object[] constructorArguments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2D29380", Offset = "0x2D27F80", VA = "0x182D29380")]
		protected void CheckNotGenericTypeDefinition(Type type, string argumentName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2D29470", Offset = "0x2D28070", VA = "0x182D29470")]
		protected void CheckNotGenericTypeDefinitions(IEnumerable<Type> types, string argumentName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2D291C0", Offset = "0x2D27DC0", VA = "0x182D291C0")]
		protected List<object> BuildArgumentListForClassProxy(ProxyGenerationOptions options, IInterceptor[] interceptors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2D298B0", Offset = "0x2D284B0", VA = "0x182D298B0")]
		protected Type CreateClassProxyType(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2D29C00", Offset = "0x2D28800", VA = "0x182D29C00")]
		protected Type CreateInterfaceProxyTypeWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class ProxyUtil
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly SynchronizedDictionary<Assembly, bool> internalsVisibleToDynamicProxy;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C380", Offset = "0x2D2AF80", VA = "0x182D2C380")]
		public static bool IsAccessible(MethodBase method)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C1D0", Offset = "0x2D2ADD0", VA = "0x182D2C1D0")]
		public static bool IsAccessible(MethodBase method, [Out] string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C180", Offset = "0x2D2AD80", VA = "0x182D2C180")]
		public static bool IsAccessible(Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BDB0", Offset = "0x2D2A9B0", VA = "0x182D2BDB0")]
		internal static bool AreInternalsVisibleToDynamicProxy(Assembly asm)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C070", Offset = "0x2D2AC70", VA = "0x182D2C070")]
		internal static bool IsAccessibleType(Type target)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BF80", Offset = "0x2D2AB80", VA = "0x182D2BF80")]
		internal static bool IsAccessibleMethod(MethodBase method)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C420", Offset = "0x2D2B020", VA = "0x182D2C420")]
		internal static bool IsInternal(MethodBase method)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BED0", Offset = "0x2D2AAD0", VA = "0x182D2BED0")]
		private static string CreateMessageForInaccessibleMethod(MethodBase inaccessibleMethod)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class StandardInterceptor : IInterceptor
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2D2CAC0", Offset = "0x2D2B6C0", VA = "0x182D2CAC0", Slot = "4")]
		public void Intercept(IInvocation invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2D2CB20", Offset = "0x2D2B720", VA = "0x182D2CB20", Slot = "5")]
		protected virtual void PerformProceed(IInvocation invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "6")]
		protected virtual void PreProceed(IInvocation invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
		protected virtual void PostProceed(IInvocation invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public StandardInterceptor()
		{
		}
	}
}
namespace Castle.DynamicProxy.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class DelegateMethods
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly MethodInfo CreateDelegate;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal static class FormatterServicesMethods
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly MethodInfo GetObjectData;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly MethodInfo GetSerializableMembers;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class InterceptorSelectorMethods
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly MethodInfo SelectInterceptors;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal static class InvocationMethods
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly ConstructorInfo CompositionInvocationConstructor;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly MethodInfo CompositionInvocationEnsureValidTarget;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly MethodInfo GetArgumentValue;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly MethodInfo GetArguments;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly MethodInfo GetReturnValue;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly ConstructorInfo InheritanceInvocationConstructor;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly ConstructorInfo InheritanceInvocationConstructorWithSelector;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly MethodInfo Proceed;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly FieldInfo ProxyObject;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly MethodInfo SetArgumentValue;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly MethodInfo SetGenericMethodArguments;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly MethodInfo SetReturnValue;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly FieldInfo CompositionInvocationTarget;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly MethodInfo ThrowOnNoTarget;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly MethodInfo EnsureValidTarget;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly FieldInfo Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class MethodBaseMethods
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly MethodInfo GetMethodFromHandle;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class SerializationInfoMethods
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly MethodInfo AddValue_Bool;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly MethodInfo AddValue_Int32;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly MethodInfo AddValue_Object;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly MethodInfo GetValue;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly MethodInfo SetType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class TypeMethods
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly MethodInfo GetTypeFromHandle;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly MethodInfo StaticGetType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class TypeUtilMethods
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly MethodInfo Sort;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly MethodInfo GetTypeOrNull;
	}
}
namespace Castle.DynamicProxy.Serialization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ProxyObjectReference : IObjectReference, ISerializable, IDeserializationCallback
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static ModuleScope scope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly SerializationInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly StreamingContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly Type baseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly Type[] interfaces;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly object proxy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ProxyGenerationOptions proxyGenerationOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private bool isInterfaceProxy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool delegateToBase;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B8C0", Offset = "0x2D2A4C0", VA = "0x182D2B8C0")]
		protected ProxyObjectReference(SerializationInfo info, StreamingContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AAB0", Offset = "0x2D296B0", VA = "0x182D2AAB0")]
		private Type DeserializeTypeFromString(string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B410", Offset = "0x2D2A010", VA = "0x182D2B410", Slot = "7")]
		protected virtual object RecreateProxy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AF60", Offset = "0x2D29B60", VA = "0x182D2AF60")]
		private object RecreateClassProxyWithTarget()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B140", Offset = "0x2D29D40", VA = "0x182D2B140")]
		public object RecreateInterfaceProxy(string generatorType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B050", Offset = "0x2D29C50", VA = "0x182D2B050")]
		public object RecreateClassProxy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AB50", Offset = "0x2D29750", VA = "0x182D2AB50")]
		private object InstantiateClassProxy(Type proxy_type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AD00", Offset = "0x2D29900", VA = "0x182D2AD00")]
		protected void InvokeCallback(object target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "4")]
		public object GetRealObject(StreamingContext context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AD90", Offset = "0x2D29990", VA = "0x182D2AD90", Slot = "6")]
		public void OnDeserialization(object sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A4A0", Offset = "0x2D290A0", VA = "0x182D2A4A0")]
		private void DeserializeProxyMembers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A7B0", Offset = "0x2D293B0", VA = "0x182D2A7B0")]
		private void DeserializeProxyState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B740", Offset = "0x2D2A340", VA = "0x182D2B740")]
		private void SetTarget(object target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B640", Offset = "0x2D2A240", VA = "0x182D2B640")]
		private void SetInterceptors(IInterceptor[] interceptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F08D40", Offset = "0x3F07940", VA = "0x183F08D40")]
		private T GetValue<T>(string name)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class ProxyTypeConstants
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly string Class;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly string ClassWithTarget;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly string InterfaceWithTarget;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly string InterfaceWithTargetInterface;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly string InterfaceWithoutTarget;
	}
}
namespace Castle.DynamicProxy.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class AttributeUtil
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class <GetNonInheritableAttributes>d__5 : IEnumerable<CustomAttributeInfo>, IEnumerable, IEnumerator<CustomAttributeInfo>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private CustomAttributeInfo <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private MemberInfo member;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public MemberInfo <>3__member;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<CustomAttributeData> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			CustomAttributeInfo IEnumerator<CustomAttributeInfo>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C1")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public <GetNonInheritableAttributes>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x2D2E5F0", Offset = "0x2D2D1F0", VA = "0x182D2E5F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2D2E040", Offset = "0x2D2CC40", VA = "0x182D2E040", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2D2E680", Offset = "0x2D2D280", VA = "0x182D2E680")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x2D2E5B0", Offset = "0x2D2D1B0", VA = "0x182D2E5B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x2D2E510", Offset = "0x2D2D110", VA = "0x182D2E510", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<CustomAttributeInfo> IEnumerable<CustomAttributeInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x2D2E510", Offset = "0x2D2D110", VA = "0x182D2E510", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class <GetNonInheritableAttributes>d__6 : IEnumerable<CustomAttributeInfo>, IEnumerable, IEnumerator<CustomAttributeInfo>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private CustomAttributeInfo <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private ParameterInfo parameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ParameterInfo <>3__parameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private bool <ignoreInheritance>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private IEnumerator<CustomAttributeData> <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			CustomAttributeInfo IEnumerator<CustomAttributeInfo>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public <GetNonInheritableAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x2D2EA80", Offset = "0x2D2D680", VA = "0x182D2EA80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x2D2E6D0", Offset = "0x2D2D2D0", VA = "0x182D2E6D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2D2EB10", Offset = "0x2D2D710", VA = "0x182D2EB10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2D2EA40", Offset = "0x2D2D640", VA = "0x182D2EA40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2D2E9A0", Offset = "0x2D2D5A0", VA = "0x182D2E9A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<CustomAttributeInfo> IEnumerable<CustomAttributeInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x2D2E9A0", Offset = "0x2D2D5A0", VA = "0x182D2E9A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D0E440", Offset = "0x2D0D040", VA = "0x182D0E440")]
		public static CustomAttributeInfo CreateInfo(CustomAttributeData attribute)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D0E950", Offset = "0x2D0D550", VA = "0x182D0E950")]
		private static void GetArguments(IList<CustomAttributeTypedArgument> constructorArguments, [Out] Type[] constructorArgTypes, [Out] object[] constructorArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D0E730", Offset = "0x2D0D330", VA = "0x182D0E730")]
		private static object[] GetArguments(IList<CustomAttributeTypedArgument> constructorArguments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F430", Offset = "0x2D0E030", VA = "0x182D0F430")]
		private static object ReadAttributeValue(CustomAttributeTypedArgument argument)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D0EE80", Offset = "0x2D0DA80", VA = "0x182D0EE80")]
		private static void GetSettersAndFields(Type attributeType, IEnumerable<CustomAttributeNamedArgument> namedArguments, [Out] PropertyInfo[] properties, [Out] object[] propertyValues, [Out] FieldInfo[] fields, [Out] object[] fieldValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D0ED80", Offset = "0x2D0D980", VA = "0x182D0ED80")]
		[IteratorStateMachine(typeof(<GetNonInheritableAttributes>d__5))]
		public static IEnumerable<CustomAttributeInfo> GetNonInheritableAttributes(this MemberInfo member)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D0EE00", Offset = "0x2D0DA00", VA = "0x182D0EE00")]
		[IteratorStateMachine(typeof(<GetNonInheritableAttributes>d__6))]
		public static IEnumerable<CustomAttributeInfo> GetNonInheritableAttributes(this ParameterInfo parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F500", Offset = "0x2D0E100", VA = "0x182D0F500")]
		private static bool ShouldSkipAttributeReplication(Type attribute, bool ignoreInheritance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x38C6980", Offset = "0x38C5580", VA = "0x1838C6980")]
		public static CustomAttributeInfo CreateInfo<TAttribute>() where TAttribute : Attribute, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D0E260", Offset = "0x2D0CE60", VA = "0x182D0E260")]
		public static CustomAttributeInfo CreateInfo(Type attribute, object[] constructorArguments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F340", Offset = "0x2D0DF40", VA = "0x182D0F340")]
		private static Type[] GetTypes(object[] objects)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class CompositionInvocation : AbstractInvocation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected object target;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2D174A0", Offset = "0x2D160A0", VA = "0x182D174A0")]
		protected CompositionInvocation(object target, object proxy, IInterceptor[] interceptors, MethodInfo proxiedMethod, object[] arguments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2D17420", Offset = "0x2D16020", VA = "0x182D17420")]
		protected void EnsureValidTarget()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class InheritanceInvocation : AbstractInvocation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Type targetType;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2D174A0", Offset = "0x2D160A0", VA = "0x182D174A0")]
		protected InheritanceInvocation(Type targetType, object proxy, IInterceptor[] interceptors, MethodInfo proxiedMethod, object[] arguments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract override void InvokeMethodOnTarget();
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class InterfaceMethodWithoutTargetInvocation : AbstractInvocation
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C7C0", Offset = "0x2D1B3C0", VA = "0x182D1C7C0", Slot = "12")]
		protected override void InvokeMethodOnTarget()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class TypeUtil
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class TypeNameComparer : IComparer<Type>
		{
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly TypeNameComparer Instance;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2D2CDE0", Offset = "0x2D2B9E0", VA = "0x182D2CDE0", Slot = "4")]
			public int Compare(Type x, Type y)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TypeNameComparer()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D2DA60", Offset = "0x2D2C660", VA = "0x182D2DA60")]
		internal static bool IsNullableType(this Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D150", Offset = "0x2D2BD50", VA = "0x182D2D150")]
		internal static FieldInfo[] GetAllFields(this Type type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D430", Offset = "0x2D2C030", VA = "0x182D2D430")]
		internal static Type[] GetAllInterfaces(params Type[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D380", Offset = "0x2D2BF80", VA = "0x182D2D380")]
		public static Type[] GetAllInterfaces(this Type type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D720", Offset = "0x2D2C320", VA = "0x182D2D720")]
		public static Type GetTypeOrNull(object target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D070", Offset = "0x2D2BC70", VA = "0x182D2D070")]
		internal static Type[] AsTypeArray(this GenericTypeParameterBuilder[] typeInfos)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D7C0", Offset = "0x2D2C3C0", VA = "0x182D2D7C0")]
		internal static bool IsFinalizer(this MethodInfo methodInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D8A0", Offset = "0x2D2C4A0", VA = "0x182D2D8A0")]
		internal static bool IsGetType(this MethodInfo methodInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D980", Offset = "0x2D2C580", VA = "0x182D2D980")]
		internal static bool IsMemberwiseClone(this MethodInfo methodInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2D2DB10", Offset = "0x2D2C710", VA = "0x182D2DB10")]
		internal static void SetStaticField(this Type type, string fieldName, BindingFlags additionalFlags, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2D2DEE0", Offset = "0x2D2CAE0", VA = "0x182D2DEE0")]
		public static MemberInfo[] Sort(MemberInfo[] members)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D730", Offset = "0x2D2C330", VA = "0x182D2D730")]
		internal static bool IsDelegateType(this Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2D2DDA0", Offset = "0x2D2C9A0", VA = "0x182D2DDA0")]
		private static Type[] Sort(ICollection<Type> types)
		{
			return null;
		}
	}
}
namespace Castle.DynamicProxy.Generators
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class AttributesToAvoidReplicating
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static readonly object lockObject;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static IList<Type> attributes;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F840", Offset = "0x2D0E440", VA = "0x182D0F840")]
		static AttributesToAvoidReplicating()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F730", Offset = "0x2D0E330", VA = "0x182D0F730")]
		internal static bool ShouldAvoid(Type attribute)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal abstract class BaseClassProxyGenerator : BaseProxyGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected abstract FieldReference TargetField
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2D11100", Offset = "0x2D0FD00", VA = "0x182D11100")]
		protected BaseClassProxyGenerator(ModuleScope scope, Type targetType, Type[] interfaces, ProxyGenerationOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract SerializableContributor GetSerializableContributor();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract CompositeTypeContributor GetProxyTargetContributor(INamingScope namingScope);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract ProxyTargetAccessorContributor GetProxyTargetAccessorContributor();

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FC60", Offset = "0x2D0E860", VA = "0x182D0FC60", Slot = "5")]
		protected sealed override Type GenerateType(string name, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D105D0", Offset = "0x2D0F1D0", VA = "0x182D105D0")]
		private IEnumerable<Type> GetTypeImplementerMapping([Out] IEnumerable<ITypeContributor> contributors, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FB40", Offset = "0x2D0E740", VA = "0x182D0FB40")]
		private void EnsureDoesNotImplementIProxyTargetAccessor(Type type, string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal abstract class BaseInterfaceProxyGenerator : BaseProxyGenerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		protected readonly Type proxyTargetType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected FieldReference targetField;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected abstract bool AllowChangeTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected abstract string GeneratorType
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2D12FD0", Offset = "0x2D11BD0", VA = "0x182D12FD0")]
		protected BaseInterfaceProxyGenerator(ModuleScope scope, Type targetType, Type[] interfaces, Type proxyTargetType, ProxyGenerationOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract CompositeTypeContributor GetProxyTargetContributor(Type proxyTargetType, INamingScope namingScope);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract ProxyTargetAccessorContributor GetProxyTargetAccessorContributor();

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "13")]
		protected abstract void AddMappingForAdditionalInterfaces(CompositeTypeContributor contributor, Type[] proxiedInterfaces, IDictionary<Type, ITypeContributor> typeImplementerMapping, ICollection<Type> targetInterfaces);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2D11270", Offset = "0x2D0FE70", VA = "0x182D11270", Slot = "14")]
		protected virtual ITypeContributor AddMappingForTargetType(IDictionary<Type, ITypeContributor> typeImplementerMapping, Type proxyTargetType, ICollection<Type> targetInterfaces, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2D114C0", Offset = "0x2D100C0", VA = "0x182D114C0", Slot = "8")]
		protected override void CreateTypeAttributes(ClassEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2D121D0", Offset = "0x2D10DD0", VA = "0x182D121D0", Slot = "4")]
		protected override CacheKey GetCacheKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2D117B0", Offset = "0x2D103B0", VA = "0x182D117B0", Slot = "5")]
		protected override Type GenerateType(string typeName, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2D122C0", Offset = "0x2D10EC0", VA = "0x182D122C0", Slot = "15")]
		protected virtual InterfaceProxyWithoutTargetContributor GetContributorForAdditionalInterfaces(INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2D12410", Offset = "0x2D11010", VA = "0x182D12410", Slot = "16")]
		protected virtual IEnumerable<Type> GetTypeImplementerMapping(Type proxyTargetType, [Out] IEnumerable<ITypeContributor> contributors, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2D12DF0", Offset = "0x2D119F0", VA = "0x182D12DF0", Slot = "17")]
		protected virtual Type Init(string typeName, [Out] ClassEmitter emitter, Type proxyTargetType, [Out] FieldReference interceptorsField, IEnumerable<Type> allInterfaces)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2D11410", Offset = "0x2D10010", VA = "0x182D11410")]
		private void CreateFields(ClassEmitter emitter, Type proxyTargetType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2D115E0", Offset = "0x2D101E0", VA = "0x182D115E0")]
		private void EnsureValidBaseType(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2D12F60", Offset = "0x2D11B60", VA = "0x182D12F60")]
		private void ThrowInvalidBaseType(Type type, string doesNotHaveAccessibleParameterlessConstructor)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal abstract class BaseProxyGenerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		protected readonly Type targetType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		protected readonly Type[] interfaces;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly ModuleScope scope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private ProxyGenerationOptions proxyGenerationOptions;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected ProxyGenerationOptions ProxyGenerationOptions
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected ModuleScope Scope
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2D153F0", Offset = "0x2D13FF0", VA = "0x182D153F0")]
		protected BaseProxyGenerator(ModuleScope scope, Type targetType, Type[] interfaces, ProxyGenerationOptions proxyGenerationOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2D14B30", Offset = "0x2D13730", VA = "0x182D14B30")]
		public Type GetProxyType()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract CacheKey GetCacheKey();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract Type GenerateType(string name, INamingScope namingScope);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2D13240", Offset = "0x2D11E40", VA = "0x182D13240")]
		protected void AddMapping(Type @interface, ITypeContributor implementer, IDictionary<Type, ITypeContributor> mapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2D13090", Offset = "0x2D11C90", VA = "0x182D13090")]
		protected void AddMappingForISerializable(IDictionary<Type, ITypeContributor> typeImplementerMapping, ITypeContributor instance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2D13170", Offset = "0x2D11D70", VA = "0x182D13170")]
		protected void AddMappingNoCheck(Type @interface, ITypeContributor implementer, IDictionary<Type, ITypeContributor> mapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2D132E0", Offset = "0x2D11EE0", VA = "0x182D132E0", Slot = "6")]
		protected virtual ClassEmitter BuildClassEmitter(string typeName, Type parentType, IEnumerable<Type> interfaces)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2D133D0", Offset = "0x2D11FD0", VA = "0x182D133D0")]
		protected void CheckNotGenericTypeDefinition(Type type, string argumentName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2D134C0", Offset = "0x2D120C0", VA = "0x182D134C0")]
		protected void CheckNotGenericTypeDefinitions(IEnumerable<Type> types, string argumentName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2D13670", Offset = "0x2D12270", VA = "0x182D13670")]
		protected void CompleteInitCacheMethod(CodeBuilder constCodeBuilder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2D136E0", Offset = "0x2D122E0", VA = "0x182D136E0", Slot = "7")]
		protected virtual void CreateFields(ClassEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2D138A0", Offset = "0x2D124A0", VA = "0x182D138A0")]
		protected void CreateInterceptorsField(ClassEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2D13950", Offset = "0x2D12550", VA = "0x182D13950")]
		protected FieldReference CreateOptionsField(ClassEmitter emitter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2D139F0", Offset = "0x2D125F0", VA = "0x182D139F0")]
		protected void CreateSelectorField(ClassEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2D13AA0", Offset = "0x2D126A0", VA = "0x182D13AA0", Slot = "8")]
		protected virtual void CreateTypeAttributes(ClassEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2D13B90", Offset = "0x2D12790", VA = "0x182D13B90")]
		protected void EnsureOptionsOverrideEqualsAndGetHashCode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2D13D20", Offset = "0x2D12920", VA = "0x182D13D20")]
		protected void GenerateConstructor(ClassEmitter emitter, ConstructorInfo baseConstructor, params FieldReference[] fields)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2D145B0", Offset = "0x2D131B0", VA = "0x182D145B0")]
		protected void GenerateConstructors(ClassEmitter emitter, Type baseType, params FieldReference[] fields)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2D146B0", Offset = "0x2D132B0", VA = "0x182D146B0")]
		protected void GenerateParameterlessConstructor(ClassEmitter emitter, Type baseClass, FieldReference interceptorField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2D14A40", Offset = "0x2D13640", VA = "0x182D14A40")]
		protected ConstructorEmitter GenerateStaticConstructor(ClassEmitter emitter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2D14DA0", Offset = "0x2D139A0", VA = "0x182D14DA0")]
		protected void HandleExplicitlyPassedProxyTargetAccessor(ICollection<Type> targetInterfaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2D151E0", Offset = "0x2D13DE0", VA = "0x182D151E0")]
		protected void InitializeStaticFields(Type builtType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2D15240", Offset = "0x2D13E40", VA = "0x182D15240")]
		private bool OverridesEqualsAndGetHashCode(Type type)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal class CacheKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly MemberInfo target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly Type[] interfaces;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly ProxyGenerationOptions options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly Type type;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2D157E0", Offset = "0x2D143E0", VA = "0x182D157E0")]
		public CacheKey(MemberInfo target, Type type, Type[] interfaces, ProxyGenerationOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2D15890", Offset = "0x2D14490", VA = "0x182D15890")]
		public CacheKey(Type target, Type[] interfaces, ProxyGenerationOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2D156C0", Offset = "0x2D142C0", VA = "0x182D156C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2D15530", Offset = "0x2D14130", VA = "0x182D15530", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class ClassProxyGenerator : BaseClassProxyGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override FieldReference TargetField
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2D16410", Offset = "0x2D15010", VA = "0x182D16410")]
		public ClassProxyGenerator(ModuleScope scope, Type targetType, Type[] interfaces, ProxyGenerationOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2D160A0", Offset = "0x2D14CA0", VA = "0x182D160A0", Slot = "4")]
		protected override CacheKey GetCacheKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2D16350", Offset = "0x2D14F50", VA = "0x182D16350", Slot = "10")]
		protected override SerializableContributor GetSerializableContributor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2D162C0", Offset = "0x2D14EC0", VA = "0x182D162C0", Slot = "11")]
		protected override CompositeTypeContributor GetProxyTargetContributor(INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2D16190", Offset = "0x2D14D90", VA = "0x182D16190", Slot = "12")]
		protected override ProxyTargetAccessorContributor GetProxyTargetAccessorContributor()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class ClassProxyWithTargetGenerator : BaseClassProxyGenerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private FieldReference targetField;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected override FieldReference TargetField
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2D16410", Offset = "0x2D15010", VA = "0x182D16410")]
		public ClassProxyWithTargetGenerator(ModuleScope scope, Type targetType, Type[] interfaces, ProxyGenerationOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2D16560", Offset = "0x2D15160", VA = "0x182D16560", Slot = "4")]
		protected override CacheKey GetCacheKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2D16420", Offset = "0x2D15020", VA = "0x182D16420", Slot = "7")]
		protected override void CreateFields(ClassEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2D16790", Offset = "0x2D15390", VA = "0x182D16790", Slot = "10")]
		protected override SerializableContributor GetSerializableContributor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2D16700", Offset = "0x2D15300", VA = "0x182D16700", Slot = "11")]
		protected override CompositeTypeContributor GetProxyTargetContributor(INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2D16650", Offset = "0x2D15250", VA = "0x182D16650", Slot = "12")]
		protected override ProxyTargetAccessorContributor GetProxyTargetAccessorContributor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2D164C0", Offset = "0x2D150C0", VA = "0x182D164C0")]
		private void CreateTargetField(ClassEmitter emitter)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal class CompositionInvocationTypeGenerator : InvocationTypeGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly Type BaseType;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2D17390", Offset = "0x2D15F90", VA = "0x182D17390")]
		public CompositionInvocationTypeGenerator(Type target, MetaMethod method, MethodInfo callback, bool canChangeTarget, IInvocationCreationContributor contributor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2D16D90", Offset = "0x2D15990", VA = "0x182D16D90", Slot = "4")]
		protected override ArgumentReference[] GetBaseCtorArguments(Type targetFieldType, [Out] ConstructorInfo baseConstructor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2D170D0", Offset = "0x2D15CD0", VA = "0x182D170D0", Slot = "5")]
		protected override Type GetBaseType()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2D17120", Offset = "0x2D15D20", VA = "0x182D17120", Slot = "6")]
		protected override FieldReference GetTargetReference()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2D171B0", Offset = "0x2D15DB0", VA = "0x182D171B0", Slot = "9")]
		protected override void ImplementInvokeMethodOnTarget(AbstractTypeEmitter invocation, ParameterInfo[] parameters, MethodEmitter invokeMethodOnTarget, Reference targetField)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal class DelegateTypeGenerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly MetaMethod method;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Type targetType;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public DelegateTypeGenerator(MetaMethod method, Type targetType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2D197B0", Offset = "0x2D183B0", VA = "0x182D197B0", Slot = "4")]
		public AbstractTypeEmitter Generate(ClassEmitter @class, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2D19520", Offset = "0x2D18120", VA = "0x182D19520")]
		private void BuildConstructor(AbstractTypeEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2D196D0", Offset = "0x2D182D0", VA = "0x182D196D0")]
		private void BuildInvokeMethod(AbstractTypeEmitter @delegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2D198A0", Offset = "0x2D184A0", VA = "0x182D198A0")]
		private AbstractTypeEmitter GetEmitter(ClassEmitter @class, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2D19B00", Offset = "0x2D18700", VA = "0x182D19B00")]
		private Type[] GetParamTypes(AbstractTypeEmitter @delegate)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	internal class ForwardingMethodGenerator : MethodGenerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly GetTargetReferenceDelegate getTargetReference;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xE3EF80", Offset = "0xE3DB80", VA = "0x180E3EF80")]
		public ForwardingMethodGenerator(MetaMethod method, OverrideMethodDelegate overrideMethod, GetTargetReferenceDelegate getTargetReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2D1AB00", Offset = "0x2D19700", VA = "0x182D1AB00", Slot = "4")]
		protected override MethodEmitter BuildProxiedMethodBody(MethodEmitter emitter, ClassEmitter @class, INamingScope namingScope)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class GeneratorUtil
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2D1AE60", Offset = "0x2D19A60", VA = "0x182D1AE60")]
		public static void CopyOutAndRefParameters(TypeReference[] dereferencedArguments, LocalReference invocation, MethodInfo method, MethodEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2D1AC60", Offset = "0x2D19860", VA = "0x182D1AC60")]
		private static ConvertExpression Argument(int i, LocalReference invocationArgs, TypeReference[] arguments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2D1AD30", Offset = "0x2D19930", VA = "0x182D1AD30")]
		private static AssignStatement AssignArgument(TypeReference[] dereferencedArguments, int i, LocalReference invocationArgs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2D1AF90", Offset = "0x2D19B90", VA = "0x182D1AF90")]
		private static AssignStatement GetArguments(LocalReference invocationArgs, LocalReference invocation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B090", Offset = "0x2D19C90", VA = "0x182D1B090")]
		private static LocalReference StoreInvocationArgumentsInLocal(MethodEmitter emitter, LocalReference invocation)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal interface INamingScope
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		INamingScope ParentScope
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string GetUniqueName(string suggestedName);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		INamingScope SafeSubScope();
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class InheritanceInvocationTypeGenerator : InvocationTypeGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly Type BaseType;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C680", Offset = "0x2D1B280", VA = "0x182D1C680")]
		public InheritanceInvocationTypeGenerator(Type targetType, MetaMethod method, MethodInfo callback, IInvocationCreationContributor contributor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C1D0", Offset = "0x2D1ADD0", VA = "0x182D1C1D0", Slot = "4")]
		protected override ArgumentReference[] GetBaseCtorArguments(Type targetFieldType, [Out] ConstructorInfo baseConstructor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C520", Offset = "0x2D1B120", VA = "0x182D1C520", Slot = "5")]
		protected override Type GetBaseType()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C570", Offset = "0x2D1B170", VA = "0x182D1C570", Slot = "6")]
		protected override FieldReference GetTargetReference()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal sealed class InterfaceProxyWithoutTargetGenerator : BaseInterfaceProxyGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool AllowChangeTarget
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected override string GeneratorType
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x2D1D0E0", Offset = "0x2D1BCE0", VA = "0x182D1D0E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CAD0", Offset = "0x2D1B6D0", VA = "0x182D1CAD0")]
		public InterfaceProxyWithoutTargetGenerator(ModuleScope scope, Type targetType, Type[] interfaces, Type proxyTargetType, ProxyGenerationOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CF70", Offset = "0x2D1BB70", VA = "0x182D1CF70", Slot = "11")]
		protected override CompositeTypeContributor GetProxyTargetContributor(Type proxyTargetType, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CEC0", Offset = "0x2D1BAC0", VA = "0x182D1CEC0", Slot = "12")]
		protected override ProxyTargetAccessorContributor GetProxyTargetAccessorContributor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "13")]
		protected override void AddMappingForAdditionalInterfaces(CompositeTypeContributor contributor, Type[] proxiedInterfaces, IDictionary<Type, ITypeContributor> typeImplementerMapping, ICollection<Type> targetInterfaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2D1D0C0", Offset = "0x2D1BCC0", VA = "0x182D1D0C0", Slot = "16")]
		protected override IEnumerable<Type> GetTypeImplementerMapping(Type _, [Out] IEnumerable<ITypeContributor> contributors, INamingScope namingScope)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class InterfaceProxyWithTargetGenerator : BaseInterfaceProxyGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected override bool AllowChangeTarget
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected override string GeneratorType
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x2D1CAE0", Offset = "0x2D1B6E0", VA = "0x182D1CAE0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CAD0", Offset = "0x2D1B6D0", VA = "0x182D1CAD0")]
		public InterfaceProxyWithTargetGenerator(ModuleScope scope, Type targetType, Type[] interfaces, Type proxyTargetType, ProxyGenerationOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C9B0", Offset = "0x2D1B5B0", VA = "0x182D1C9B0", Slot = "11")]
		protected override CompositeTypeContributor GetProxyTargetContributor(Type proxyTargetType, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C900", Offset = "0x2D1B500", VA = "0x182D1C900", Slot = "12")]
		protected override ProxyTargetAccessorContributor GetProxyTargetAccessorContributor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C7D0", Offset = "0x2D1B3D0", VA = "0x182D1C7D0", Slot = "13")]
		protected override void AddMappingForAdditionalInterfaces(CompositeTypeContributor contributor, Type[] proxiedInterfaces, IDictionary<Type, ITypeContributor> typeImplementerMapping, ICollection<Type> targetInterfaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CA70", Offset = "0x2D1B670", VA = "0x182D1CA70")]
		private bool ImplementedByTarget(ICollection<Type> targetInterfaces, Type @interface)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	internal sealed class InterfaceProxyWithTargetInterfaceGenerator : BaseInterfaceProxyGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool AllowChangeTarget
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected override string GeneratorType
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x2D1CE70", Offset = "0x2D1BA70", VA = "0x182D1CE70", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CAD0", Offset = "0x2D1B6D0", VA = "0x182D1CAD0")]
		public InterfaceProxyWithTargetInterfaceGenerator(ModuleScope scope, Type targetType, Type[] interfaces, Type proxyTargetType, ProxyGenerationOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CD00", Offset = "0x2D1B900", VA = "0x182D1CD00", Slot = "11")]
		protected override CompositeTypeContributor GetProxyTargetContributor(Type proxyTargetType, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CC50", Offset = "0x2D1B850", VA = "0x182D1CC50", Slot = "12")]
		protected override ProxyTargetAccessorContributor GetProxyTargetAccessorContributor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "13")]
		protected override void AddMappingForAdditionalInterfaces(CompositeTypeContributor contributor, Type[] proxiedInterfaces, IDictionary<Type, ITypeContributor> typeImplementerMapping, ICollection<Type> targetInterfaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CB30", Offset = "0x2D1B730", VA = "0x182D1CB30", Slot = "15")]
		protected override InterfaceProxyWithoutTargetContributor GetContributorForAdditionalInterfaces(INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CDC0", Offset = "0x2D1B9C0", VA = "0x182D1CDC0")]
		private Reference GetTarget(ClassEmitter @class, MethodInfo method)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CDC0", Offset = "0x2D1B9C0", VA = "0x182D1CDC0")]
		private IExpression GetTargetExpression(ClassEmitter @class, MethodInfo method)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal abstract class InvocationTypeGenerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		protected readonly MetaMethod method;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		protected readonly Type targetType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MethodInfo callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly bool canChangeTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly IInvocationCreationContributor contributor;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2D17390", Offset = "0x2D15F90", VA = "0x182D17390")]
		protected InvocationTypeGenerator(Type targetType, MetaMethod method, MethodInfo callback, bool canChangeTarget, IInvocationCreationContributor contributor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract ArgumentReference[] GetBaseCtorArguments(Type targetFieldType, [Out] ConstructorInfo baseConstructor);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract Type GetBaseType();

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract FieldReference GetTargetReference();

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E720", Offset = "0x2D1D320", VA = "0x182D1E720", Slot = "7")]
		public AbstractTypeEmitter Generate(ClassEmitter @class, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E9C0", Offset = "0x2D1D5C0", VA = "0x182D1E9C0", Slot = "8")]
		protected virtual MethodInvocationExpression GetCallbackMethodInvocation(AbstractTypeEmitter invocation, IExpression[] args, MethodInfo callbackMethod, Reference targetField, MethodEmitter invokeMethodOnTarget)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F5D0", Offset = "0x2D1E1D0", VA = "0x182D1F5D0", Slot = "9")]
		protected virtual void ImplementInvokeMethodOnTarget(AbstractTypeEmitter invocation, ParameterInfo[] parameters, MethodEmitter invokeMethodOnTarget, Reference targetField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2D1DF00", Offset = "0x2D1CB00", VA = "0x182D1DF00")]
		private void AssignBackByRefArguments(MethodEmitter invokeMethodOnTarget, Dictionary<int, LocalReference> byRefArguments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E450", Offset = "0x2D1D050", VA = "0x182D1E450")]
		private void CreateConstructor(AbstractTypeEmitter invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E360", Offset = "0x2D1CF60", VA = "0x182D1E360")]
		private ConstructorEmitter CreateConstructor(AbstractTypeEmitter invocation, ArgumentReference[] baseCtorArguments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E600", Offset = "0x2D1D200", VA = "0x182D1E600")]
		private void EmitCallThrowOnNoTarget(MethodEmitter invokeMethodOnTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2D1EB60", Offset = "0x2D1D760", VA = "0x182D1EB60")]
		private MethodInfo GetCallbackMethod(AbstractTypeEmitter invocation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2D1ECA0", Offset = "0x2D1D8A0", VA = "0x182D1ECA0")]
		private AbstractTypeEmitter GetEmitter(ClassEmitter @class, Type[] interfaces, INamingScope namingScope, MethodInfo methodInfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2D1EEA0", Offset = "0x2D1DAA0", VA = "0x182D1EEA0")]
		private void ImplemementInvokeMethodOnTarget(AbstractTypeEmitter invocation, ParameterInfo[] parameters, FieldReference targetField, MethodInfo callbackMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2D1EFA0", Offset = "0x2D1DBA0", VA = "0x182D1EFA0")]
		private void ImplementChangeInvocationTarget(AbstractTypeEmitter invocation, FieldReference targetField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F210", Offset = "0x2D1DE10", VA = "0x182D1F210")]
		private void ImplementChangeProxyTarget(AbstractTypeEmitter invocation, ClassEmitter @class)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F1C0", Offset = "0x2D1DDC0", VA = "0x182D1F1C0")]
		private void ImplementChangeProxyTargetInterface(ClassEmitter @class, AbstractTypeEmitter invocation, FieldReference targetField)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class MetaEvent : MetaTypeElement, IEquatable<MetaEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly MetaMethod adder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly MetaMethod remover;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private EventEmitter emitter;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MetaMethod Adder
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public EventAttributes Attributes
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xB447A0", Offset = "0xB433A0", VA = "0x180B447A0")]
			[CompilerGenerated]
			get
			{
				return default(EventAttributes);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xE76570", Offset = "0xE75170", VA = "0x180E76570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public EventEmitter Emitter
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x2D20740", Offset = "0x2D1F340", VA = "0x182D20740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public MetaMethod Remover
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private Type Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2D207B0", Offset = "0x2D1F3B0", VA = "0x182D207B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2D205F0", Offset = "0x2D1F1F0", VA = "0x182D205F0")]
		public MetaEvent(EventInfo @event, MetaMethod adder, MetaMethod remover, EventAttributes attributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2D20140", Offset = "0x2D1ED40", VA = "0x182D20140")]
		public void BuildEventEmitter(ClassEmitter classEmitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2D202F0", Offset = "0x2D1EEF0", VA = "0x182D202F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2D204B0", Offset = "0x2D1F0B0", VA = "0x182D204B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2D20200", Offset = "0x2D1EE00", VA = "0x182D20200", Slot = "5")]
		public bool Equals(MetaEvent other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2D205A0", Offset = "0x2D1F1A0", VA = "0x182D205A0", Slot = "4")]
		public override void SwitchToExplicitImplementation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[DebuggerDisplay("{Method}")]
	internal class MetaMethod : MetaTypeElement, IEquatable<MetaMethod>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public MethodAttributes Attributes
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
			[CompilerGenerated]
			get
			{
				return default(MethodAttributes);
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xB6A400", Offset = "0xB69000", VA = "0x180B6A400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool HasTarget
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xF1F280", Offset = "0xF1DE80", VA = "0x180F1F280")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xF1F440", Offset = "0xF1E040", VA = "0x180F1F440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public MethodInfo Method
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public MethodInfo MethodOnTarget
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool Ignore
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB41D60", Offset = "0xB40960", VA = "0x180B41D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xB41AF0", Offset = "0xB406F0", VA = "0x180B41AF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool Proxyable
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1E3C7A0", Offset = "0x1E3B3A0", VA = "0x181E3C7A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1E3CA60", Offset = "0x1E3B660", VA = "0x181E3CA60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool Standalone
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xB693B0", Offset = "0xB67FB0", VA = "0x180B693B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2D20CA0", Offset = "0x2D1F8A0", VA = "0x182D20CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2D20BE0", Offset = "0x2D1F7E0", VA = "0x182D20BE0")]
		public MetaMethod(MethodInfo method, MethodInfo methodOnTarget, bool standalone, bool proxyable, bool hasTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D20840", Offset = "0x2D1F440", VA = "0x182D20840", Slot = "5")]
		public bool Equals(MetaMethod other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D20BC0", Offset = "0x2D1F7C0", VA = "0x182D20BC0", Slot = "4")]
		public override void SwitchToExplicitImplementation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2D209F0", Offset = "0x2D1F5F0", VA = "0x182D209F0")]
		private MethodAttributes ObtainAttributes()
		{
			return default(MethodAttributes);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	internal class MetaProperty : MetaTypeElement, IEquatable<MetaProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly Type[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly PropertyAttributes attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly IEnumerable<CustomAttributeBuilder> customAttributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly MetaMethod getter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly MetaMethod setter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private PropertyEmitter emitter;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Type[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1DCA0F0", Offset = "0x1DC8CF0", VA = "0x181DCA0F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1155310", Offset = "0x1153F10", VA = "0x181155310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public PropertyEmitter Emitter
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x2D215A0", Offset = "0x2D201A0", VA = "0x182D215A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public MethodInfo GetMethod
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x2D21610", Offset = "0x2D20210", VA = "0x182D21610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MetaMethod Getter
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public MethodInfo SetMethod
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x2D21670", Offset = "0x2D20270", VA = "0x182D21670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public MetaMethod Setter
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private Type Type
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x2D216D0", Offset = "0x2D202D0", VA = "0x182D216D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D214A0", Offset = "0x2D200A0", VA = "0x182D214A0")]
		public MetaProperty(PropertyInfo property, MetaMethod getter, MetaMethod setter, IEnumerable<CustomAttributeBuilder> customAttributes, Type[] arguments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D20CB0", Offset = "0x2D1F8B0", VA = "0x182D20CB0")]
		public void BuildPropertyEmitter(ClassEmitter classEmitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D20FE0", Offset = "0x2D1FBE0", VA = "0x182D20FE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D21280", Offset = "0x2D1FE80", VA = "0x182D21280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D210F0", Offset = "0x2D1FCF0", VA = "0x182D210F0", Slot = "5")]
		public bool Equals(MetaProperty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D21440", Offset = "0x2D20040", VA = "0x182D21440", Slot = "4")]
		public override void SwitchToExplicitImplementation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal class MetaType
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly MetaTypeElementCollection<MetaEvent> events;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly MetaTypeElementCollection<MetaMethod> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly Dictionary<MethodInfo, MetaMethod> methodsIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly MetaTypeElementCollection<MetaProperty> properties;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D21BD0", Offset = "0x2D207D0", VA = "0x182D21BD0")]
		public void AddEvent(MetaEvent @event)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D21C30", Offset = "0x2D20830", VA = "0x182D21C30")]
		public void AddMethod(MetaMethod method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D21CC0", Offset = "0x2D208C0", VA = "0x182D21CC0")]
		public void AddProperty(MetaProperty property)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D21D20", Offset = "0x2D20920", VA = "0x182D21D20")]
		public MetaMethod FindMethod(MethodInfo method)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2D21DA0", Offset = "0x2D209A0", VA = "0x182D21DA0")]
		public MetaType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	internal abstract class MetaTypeElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly MemberInfo member;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string name;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool CanBeImplementedExplicitly
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x2D21B90", Offset = "0x2D20790", VA = "0x182D21B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected MemberInfo Member
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2D21B20", Offset = "0x2D20720", VA = "0x182D21B20")]
		protected MetaTypeElement(MemberInfo member)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void SwitchToExplicitImplementation();

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2D21760", Offset = "0x2D20360", VA = "0x182D21760")]
		protected void SwitchToExplicitImplementationName()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal class MetaTypeElementCollection<TElement> : IEnumerable<TElement>, IEnumerable where TElement : MetaTypeElement, IEquatable<TElement>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly ICollection<TElement> items;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5F361E0", Offset = "0x5F34DE0", VA = "0x185F361E0")]
		public void Add(TElement item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5F36310", Offset = "0x5F34F10", VA = "0x185F36310")]
		public bool Contains(TElement item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5F36530", Offset = "0x5F35130", VA = "0x185F36530", Slot = "4")]
		public IEnumerator<TElement> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5F36580", Offset = "0x5F35180", VA = "0x185F36580", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5F365D0", Offset = "0x5F351D0", VA = "0x185F365D0")]
		public MetaTypeElementCollection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class MethodFinder
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static readonly Dictionary<Type, MethodInfo[]> cachedMethodInfosByType;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly object lockObject;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2D220B0", Offset = "0x2D20CB0", VA = "0x182D220B0")]
		public static MethodInfo[] GetAllInstanceMethods(Type type, BindingFlags flags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2D224A0", Offset = "0x2D210A0", VA = "0x182D224A0")]
		private static MethodInfo[] MakeFilteredCopy(MethodInfo[] methodsInCache, BindingFlags visibilityFlags)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal abstract class MethodGenerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly MetaMethod method;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly OverrideMethodDelegate overrideMethod;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected MethodInfo MethodToOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xC149E0", Offset = "0xC135E0", VA = "0x180C149E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		protected MethodGenerator(MetaMethod method, OverrideMethodDelegate overrideMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract MethodEmitter BuildProxiedMethodBody(MethodEmitter emitter, ClassEmitter @class, INamingScope namingScope);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2D22720", Offset = "0x2D21320", VA = "0x182D22720", Slot = "5")]
		public MethodEmitter Generate(ClassEmitter @class, INamingScope namingScope)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class MethodSignatureComparer : IEqualityComparer<MethodInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodSignatureComparer Instance;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2D22820", Offset = "0x2D21420", VA = "0x182D22820")]
		public bool EqualGenericParameters(MethodInfo x, MethodInfo y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D22A70", Offset = "0x2D21670", VA = "0x182D22A70")]
		public bool EqualParameters(MethodInfo x, MethodInfo y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2D22BA0", Offset = "0x2D217A0", VA = "0x182D22BA0")]
		public bool EqualSignatureTypes(Type x, Type y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D22DE0", Offset = "0x2D219E0", VA = "0x182D22DE0", Slot = "4")]
		public bool Equals(MethodInfo x, MethodInfo y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D22F50", Offset = "0x2D21B50", VA = "0x182D22F50", Slot = "5")]
		public int GetHashCode(MethodInfo obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D22A00", Offset = "0x2D21600", VA = "0x182D22A00")]
		private bool EqualNames(MethodInfo x, MethodInfo y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public MethodSignatureComparer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal class MethodWithInvocationGenerator : MethodGenerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly IInvocationCreationContributor contributor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly GetTargetExpressionDelegate getTargetExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly GetTargetExpressionDelegate getTargetTypeExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly IExpression interceptors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly Type invocation;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2D24A50", Offset = "0x2D23650", VA = "0x182D24A50")]
		public MethodWithInvocationGenerator(MetaMethod method, IExpression interceptors, Type invocation, GetTargetExpressionDelegate getTargetExpression, OverrideMethodDelegate createMethod, IInvocationCreationContributor contributor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D24B10", Offset = "0x2D23710", VA = "0x182D24B10")]
		public MethodWithInvocationGenerator(MetaMethod method, IExpression interceptors, Type invocation, GetTargetExpressionDelegate getTargetExpression, GetTargetExpressionDelegate getTargetTypeExpression, OverrideMethodDelegate createMethod, IInvocationCreationContributor contributor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2D23040", Offset = "0x2D21C40", VA = "0x182D23040")]
		protected FieldReference BuildMethodInterceptorsField(ClassEmitter @class, MethodInfo method, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2D23170", Offset = "0x2D21D70", VA = "0x182D23170", Slot = "4")]
		protected override MethodEmitter BuildProxiedMethodBody(MethodEmitter emitter, ClassEmitter @class, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2D244E0", Offset = "0x2D230E0", VA = "0x182D244E0")]
		private IExpression SetMethodInterceptors(ClassEmitter @class, INamingScope namingScope, MethodEmitter emitter, IExpression proxiedMethodTokenExpression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2D23D10", Offset = "0x2D22910", VA = "0x182D23D10")]
		private void EmitLoadGenricMethodArguments(MethodEmitter methodEmitter, MethodInfo method, Reference invocationLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2D24100", Offset = "0x2D22D00", VA = "0x182D24100")]
		private IExpression[] GetCtorArguments(ClassEmitter @class, IExpression proxiedMethodTokenExpression, TypeReference[] dereferencedArguments, IExpression methodInterceptors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2D24400", Offset = "0x2D23000", VA = "0x182D24400")]
		private IExpression[] ModifyArguments(ClassEmitter @class, IExpression[] arguments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2D24390", Offset = "0x2D22F90", VA = "0x182D24390")]
		private bool HasByRefArguments(ArgumentReference[] arguments)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal class MinimialisticMethodGenerator : MethodGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public MinimialisticMethodGenerator(MetaMethod method, OverrideMethodDelegate overrideMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2D24BD0", Offset = "0x2D237D0", VA = "0x182D24BD0", Slot = "4")]
		protected override MethodEmitter BuildProxiedMethodBody(MethodEmitter emitter, ClassEmitter @class, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D24E80", Offset = "0x2D23A80", VA = "0x182D24E80")]
		private void InitOutParameters(MethodEmitter emitter, ParameterInfo[] parameters)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class NamingScope : INamingScope
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly IDictionary<string, int> names;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly INamingScope parentScope;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public INamingScope ParentScope
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D27580", Offset = "0x2D26180", VA = "0x182D27580")]
		public NamingScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2D27600", Offset = "0x2D26200", VA = "0x182D27600")]
		private NamingScope(INamingScope parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x2D27340", Offset = "0x2D25F40", VA = "0x182D27340", Slot = "5")]
		public string GetUniqueName(string suggestedName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2D274C0", Offset = "0x2D260C0", VA = "0x182D274C0", Slot = "6")]
		public INamingScope SafeSubScope()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal class OptionallyForwardingMethodGenerator : MethodGenerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly GetTargetReferenceDelegate getTargetReference;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xE3EF80", Offset = "0xE3DB80", VA = "0x180E3EF80")]
		public OptionallyForwardingMethodGenerator(MetaMethod method, OverrideMethodDelegate overrideMethod, GetTargetReferenceDelegate getTargetReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D276A0", Offset = "0x2D262A0", VA = "0x182D276A0", Slot = "4")]
		protected override MethodEmitter BuildProxiedMethodBody(MethodEmitter emitter, ClassEmitter @class, INamingScope namingScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D278B0", Offset = "0x2D264B0", VA = "0x182D278B0")]
		private IStatement IfNotNull(Reference targetReference)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D279F0", Offset = "0x2D265F0", VA = "0x182D279F0")]
		private IStatement IfNull(Type returnType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D27C90", Offset = "0x2D26890", VA = "0x182D27C90")]
		private void InitOutParameters(BlockStatement statements, ParameterInfo[] parameters)
		{
		}
	}
}
namespace Castle.DynamicProxy.Generators.Emitters
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	internal abstract class AbstractTypeEmitter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly List<ConstructorEmitter> constructors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly List<EventEmitter> events;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly IDictionary<string, FieldReference> fields;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly List<MethodEmitter> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly List<NestedClassEmitter> nested;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly List<PropertyEmitter> properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly TypeBuilder typebuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private GenericTypeParameterBuilder[] genericTypeParams;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Type BaseType
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x2D0D6B0", Offset = "0x2D0C2B0", VA = "0x182D0D6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public TypeConstructorEmitter ClassConstructor
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public GenericTypeParameterBuilder[] GenericTypeParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TypeBuilder TypeBuilder
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D440", Offset = "0x2D0C040", VA = "0x182D0D440")]
		protected AbstractTypeEmitter(TypeBuilder typeBuilder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B490", Offset = "0x2D0A090", VA = "0x182D0B490")]
		public void AddCustomAttributes(IEnumerable<CustomAttributeInfo> additionalAttributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B660", Offset = "0x2D0A260", VA = "0x182D0B660", Slot = "4")]
		public virtual Type BuildType()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B7C0", Offset = "0x2D0A3C0", VA = "0x182D0B7C0")]
		public void CopyGenericParametersFromMethod(MethodInfo methodToCopyGenericsFrom)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B940", Offset = "0x2D0A540", VA = "0x182D0B940")]
		public ConstructorEmitter CreateConstructor(params ArgumentReference[] arguments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BAA0", Offset = "0x2D0A6A0", VA = "0x182D0BAA0")]
		public void CreateDefaultConstructor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BC00", Offset = "0x2D0A800", VA = "0x182D0BC00")]
		public EventEmitter CreateEvent(string name, EventAttributes atts, Type type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BE40", Offset = "0x2D0AA40", VA = "0x182D0BE40")]
		public FieldReference CreateField(string name, Type fieldType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BE20", Offset = "0x2D0AA20", VA = "0x182D0BE20")]
		public FieldReference CreateField(string name, Type fieldType, bool serializable)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BE60", Offset = "0x2D0AA60", VA = "0x182D0BE60")]
		public FieldReference CreateField(string name, Type fieldType, FieldAttributes atts)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C0E0", Offset = "0x2D0ACE0", VA = "0x182D0C0E0")]
		public MethodEmitter CreateMethod(string name, MethodAttributes attrs, Type returnType, params Type[] argumentTypes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C0B0", Offset = "0x2D0ACB0", VA = "0x182D0C0B0")]
		public MethodEmitter CreateMethod(string name, Type returnType, params Type[] parameterTypes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C220", Offset = "0x2D0AE20", VA = "0x182D0C220")]
		public MethodEmitter CreateMethod(string name, MethodInfo methodToUseAsATemplate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BFA0", Offset = "0x2D0ABA0", VA = "0x182D0BFA0")]
		public MethodEmitter CreateMethod(string name, MethodAttributes attributes, MethodInfo methodToUseAsATemplate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C320", Offset = "0x2D0AF20", VA = "0x182D0C320")]
		public PropertyEmitter CreateProperty(string name, PropertyAttributes attributes, Type propertyType, Type[] arguments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C430", Offset = "0x2D0B030", VA = "0x182D0C430")]
		public FieldReference CreateStaticField(string name, Type fieldType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C450", Offset = "0x2D0B050", VA = "0x182D0C450")]
		public FieldReference CreateStaticField(string name, Type fieldType, FieldAttributes atts)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C470", Offset = "0x2D0B070", VA = "0x182D0C470")]
		public ConstructorEmitter CreateTypeConstructor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C570", Offset = "0x2D0B170", VA = "0x182D0C570")]
		public void DefineCustomAttribute(CustomAttributeBuilder attribute)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x355FC90", Offset = "0x355E890", VA = "0x18355FC90")]
		public void DefineCustomAttribute<TAttribute>(object[] constructorArguments) where TAttribute : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x355FC30", Offset = "0x355E830", VA = "0x18355FC30")]
		public void DefineCustomAttribute<TAttribute>() where TAttribute : Attribute, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x355FB60", Offset = "0x355E760", VA = "0x18355FB60")]
		public void DefineCustomAttributeFor<TAttribute>(FieldReference field) where TAttribute : Attribute, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x2D0CEE0", Offset = "0x2D0BAE0", VA = "0x182D0CEE0")]
		public IEnumerable<FieldReference> GetAllFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D1F0", Offset = "0x2D0BDF0", VA = "0x182D0D1F0")]
		public FieldReference GetField(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2D0CF30", Offset = "0x2D0BB30", VA = "0x182D0CF30")]
		public Type GetClosedParameterType(Type parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D2F0", Offset = "0x2D0BEF0", VA = "0x182D0D2F0")]
		public Type GetGenericArgument(int position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
		public Type[] GetGenericArgumentsFor(MethodInfo genericMethod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xB13190", Offset = "0xB11D90", VA = "0x180B13190")]
		public void SetGenericTypeParameters(GenericTypeParameterBuilder[] genericTypeParameterBuilders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C550", Offset = "0x2D0B150", VA = "0x182D0C550")]
		protected Type CreateType(TypeBuilder type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C590", Offset = "0x2D0B190", VA = "0x182D0C590", Slot = "5")]
		protected virtual void EnsureBuildersAreInAValidState()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal abstract class ArgumentsUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DBB0", Offset = "0x2D0C7B0", VA = "0x182D0DBB0")]
		public static ArgumentReference[] ConvertToArgumentReference(Type[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DA70", Offset = "0x2D0C670", VA = "0x182D0DA70")]
		public static IExpression[] ConvertToArgumentReferenceExpression(ParameterInfo[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DCD0", Offset = "0x2D0C8D0", VA = "0x182D0DCD0")]
		public static void EmitLoadOwnerAndReference(Reference reference, ILGenerator il)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DD20", Offset = "0x2D0C920", VA = "0x182D0DD20")]
		public static Type[] GetTypes(ParameterInfo[] parameters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DE20", Offset = "0x2D0CA20", VA = "0x182D0DE20")]
		public static Type[] InitializeAndConvert(ArgumentReference[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DF30", Offset = "0x2D0CB30", VA = "0x182D0DF30")]
		public static void InitializeArgumentsByPosition(ArgumentReference[] args, bool isStatic)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	internal class ClassEmitter : AbstractTypeEmitter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly ModuleScope moduleScope;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public ModuleScope ModuleScope
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		internal bool InStrongNamedModule
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x2D16030", Offset = "0x2D14C30", VA = "0x182D16030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2D16000", Offset = "0x2D14C00", VA = "0x182D16000")]
		public ClassEmitter(ModuleScope modulescope, string name, Type baseType, IEnumerable<Type> interfaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2D15CE0", Offset = "0x2D148E0", VA = "0x182D15CE0")]
		public ClassEmitter(ModuleScope modulescope, string name, Type baseType, IEnumerable<Type> interfaces, TypeAttributes flags, bool forceUnsigned)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2D15CD0", Offset = "0x2D148D0", VA = "0x182D15CD0")]
		public ClassEmitter(TypeBuilder typeBuilder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2D15A10", Offset = "0x2D14610", VA = "0x182D15A10", Slot = "6")]
		protected virtual IEnumerable<Type> InitializeGenericArgumentsFromBases(Type baseType, IEnumerable<Type> interfaces)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2D15940", Offset = "0x2D14540", VA = "0x182D15940")]
		private static TypeBuilder CreateTypeBuilder(ModuleScope modulescope, string name, Type baseType, IEnumerable<Type> interfaces, TypeAttributes flags, bool forceUnsigned)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class CodeBuilder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly List<LocalReference> locals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly List<IStatement> statements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private bool isEmpty;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		internal bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xB13220", Offset = "0xB11E20", VA = "0x180B13220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2D16CC0", Offset = "0x2D158C0", VA = "0x182D16CC0")]
		public CodeBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x2D16850", Offset = "0x2D15450", VA = "0x182D16850")]
		public CodeBuilder AddStatement(IStatement statement)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2D16910", Offset = "0x2D15510", VA = "0x182D16910")]
		public LocalReference DeclareLocal(Type type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2D16A00", Offset = "0x2D15600", VA = "0x182D16A00")]
		internal void Generate(ILGenerator il)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class ConstructorEmitter : IMemberEmitter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly ConstructorBuilder builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly CodeBuilder codeBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly AbstractTypeEmitter maintype;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public CodeBuilder CodeBuilder
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public ConstructorBuilder ConstructorBuilder
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		private bool ImplementedByRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x2D178F0", Offset = "0x2D164F0", VA = "0x182D178F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2D17680", Offset = "0x2D16280", VA = "0x182D17680")]
		protected internal ConstructorEmitter(AbstractTypeEmitter maintype, ConstructorBuilder builder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2D17720", Offset = "0x2D16320", VA = "0x182D17720")]
		internal ConstructorEmitter(AbstractTypeEmitter maintype, params ArgumentReference[] arguments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2D17500", Offset = "0x2D16100", VA = "0x182D17500", Slot = "6")]
		public virtual void EnsureValidCodeBlock()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2D17610", Offset = "0x2D16210", VA = "0x182D17610", Slot = "7")]
		public virtual void Generate()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal class EventEmitter : IMemberEmitter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly EventBuilder eventBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly AbstractTypeEmitter typeEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private MethodEmitter addMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private MethodEmitter removeMethod;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A240", Offset = "0x2D18E40", VA = "0x182D1A240")]
		public EventEmitter(AbstractTypeEmitter typeEmitter, string name, EventAttributes attributes, Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2D19EE0", Offset = "0x2D18AE0", VA = "0x182D19EE0")]
		public MethodEmitter CreateAddMethod(string addMethodName, MethodAttributes attributes, MethodInfo methodToOverride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2D19FD0", Offset = "0x2D18BD0", VA = "0x182D19FD0")]
		public MethodEmitter CreateRemoveMethod(string removeMethodName, MethodAttributes attributes, MethodInfo methodToOverride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A0C0", Offset = "0x2D18CC0", VA = "0x182D1A0C0", Slot = "4")]
		public void EnsureValidCodeBlock()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A110", Offset = "0x2D18D10", VA = "0x182D1A110", Slot = "5")]
		public void Generate()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	internal delegate GenericTypeParameterBuilder[] ApplyGenArgs(string[] argumentNames);
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class GenericUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2D1BCB0", Offset = "0x2D1A8B0", VA = "0x182D1BCB0")]
		public static GenericTypeParameterBuilder[] CopyGenericArguments(MethodInfo methodToCopyGenericsFrom, TypeBuilder builder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2D1BDD0", Offset = "0x2D1A9D0", VA = "0x182D1BDD0")]
		public static GenericTypeParameterBuilder[] CopyGenericArguments(MethodInfo methodToCopyGenericsFrom, MethodBuilder builder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B4E0", Offset = "0x2D1A0E0", VA = "0x182D1B4E0")]
		private static Type AdjustConstraintToNewGenericParameters(Type constraint, MethodInfo methodToCopyGenericsFrom, Type[] originalGenericParameters, GenericTypeParameterBuilder[] newGenericParameters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B8D0", Offset = "0x2D1A4D0", VA = "0x182D1B8D0")]
		private static Type[] AdjustGenericConstraints(MethodInfo methodToCopyGenericsFrom, GenericTypeParameterBuilder[] newGenericParameters, Type[] originalGenericArguments, Type[] constraints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B9F0", Offset = "0x2D1A5F0", VA = "0x182D1B9F0")]
		private static GenericTypeParameterBuilder[] CopyGenericArguments(MethodInfo methodToCopyGenericsFrom, ApplyGenArgs genericParameterGenerator)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2D1BEF0", Offset = "0x2D1AAF0", VA = "0x182D1BEF0")]
		private static void CopyNonInheritableAttributes(GenericTypeParameterBuilder newGenericParameter, Type originalGenericArgument)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C110", Offset = "0x2D1AD10", VA = "0x182D1C110")]
		private static string[] GetArgumentNames(Type[] originalGenericArguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal interface IMemberEmitter
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EnsureValidCodeBlock();

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Generate();
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal sealed class LdcOpCodesDictionary : Dictionary<Type, OpCode>
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly LdcOpCodesDictionary dict;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly OpCode emptyOpCode;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public new OpCode this[Type type]
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A160", Offset = "0x2D38D60", VA = "0x182D3A160")]
			get
			{
				return default(OpCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static OpCode EmptyOpCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A0C0", Offset = "0x2D38CC0", VA = "0x182D3A0C0")]
			get
			{
				return default(OpCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static LdcOpCodesDictionary Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A110", Offset = "0x2D38D10", VA = "0x182D3A110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2D39D80", Offset = "0x2D38980", VA = "0x182D39D80")]
		private LdcOpCodesDictionary()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	internal sealed class LdindOpCodesDictionary : Dictionary<Type, OpCode>
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly LdindOpCodesDictionary dict;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly OpCode emptyOpCode;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public new OpCode this[Type type]
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A690", Offset = "0x2D39290", VA = "0x182D3A690")]
			get
			{
				return default(OpCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public static OpCode EmptyOpCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A5F0", Offset = "0x2D391F0", VA = "0x182D3A5F0")]
			get
			{
				return default(OpCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static LdindOpCodesDictionary Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A640", Offset = "0x2D39240", VA = "0x182D3A640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2D3A2B0", Offset = "0x2D38EB0", VA = "0x182D3A2B0")]
		private LdindOpCodesDictionary()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[DebuggerDisplay("{builder.Name}")]
	internal class MethodEmitter : IMemberEmitter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly MethodBuilder builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly CodeBuilder codeBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GenericTypeParameterBuilder[] genericTypeParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private ArgumentReference[] arguments;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public ArgumentReference[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public CodeBuilder CodeBuilder
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public GenericTypeParameterBuilder[] GenericTypeParams
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public MethodBuilder MethodBuilder
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public Type ReturnType
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x2D3D900", Offset = "0x2D3C500", VA = "0x182D3D900", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private bool ImplementedByRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x2D178F0", Offset = "0x2D164F0", VA = "0x182D178F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D760", Offset = "0x2D3C360", VA = "0x182D3D760")]
		protected internal MethodEmitter(MethodBuilder builder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D4C0", Offset = "0x2D3C0C0", VA = "0x182D3D4C0")]
		internal MethodEmitter(AbstractTypeEmitter owner, string name, MethodAttributes attributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D7E0", Offset = "0x2D3C3E0", VA = "0x182D3D7E0")]
		internal MethodEmitter(AbstractTypeEmitter owner, string name, MethodAttributes attributes, Type returnType, params Type[] argumentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D570", Offset = "0x2D3C170", VA = "0x182D3D570")]
		internal MethodEmitter(AbstractTypeEmitter owner, string name, MethodAttributes attributes, MethodInfo methodToUseAsATemplate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2D3CC90", Offset = "0x2D3B890", VA = "0x182D3CC90")]
		public void DefineCustomAttribute(CustomAttributeBuilder attribute)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D180", Offset = "0x2D3BD80", VA = "0x182D3D180")]
		public void SetParameters(Type[] paramTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2D3CF70", Offset = "0x2D3BB70", VA = "0x182D3CF70", Slot = "7")]
		public virtual void EnsureValidCodeBlock()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D110", Offset = "0x2D3BD10", VA = "0x182D3D110", Slot = "8")]
		public virtual void Generate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2D3CCB0", Offset = "0x2D3B8B0", VA = "0x182D3CCB0")]
		private void DefineParameters(ParameterInfo[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2D3C810", Offset = "0x2D3B410", VA = "0x182D3C810")]
		private void CopyDefaultValueConstant(ParameterInfo from, ParameterBuilder to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D1F0", Offset = "0x2D3BDF0", VA = "0x182D3D1F0")]
		private void SetReturnType(Type returnType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D210", Offset = "0x2D3BE10", VA = "0x182D3D210")]
		private void SetSignature(Type returnType, ParameterInfo returnParameter, Type[] parameters, ParameterInfo[] baseMethodParameters)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class NestedClassEmitter : AbstractTypeEmitter
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal abstract class OpCodeUtil
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2D3FA30", Offset = "0x2D3E630", VA = "0x182D3FA30")]
		public static void EmitLoadIndirectOpCodeForType(ILGenerator gen, Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2D3FD50", Offset = "0x2D3E950", VA = "0x182D3FD50")]
		public static void EmitLoadOpCodeForDefaultValueOfType(ILGenerator gen, Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2D400D0", Offset = "0x2D3ECD0", VA = "0x182D400D0")]
		public static void EmitStoreIndirectOpCodeForType(ILGenerator gen, Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2D40540", Offset = "0x2D3F140", VA = "0x182D40540")]
		private static Type GetUnderlyingTypeOfEnum(Type enumType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2D40740", Offset = "0x2D3F340", VA = "0x182D40740")]
		private static bool Is64BitTypeLoadedAsInt32(Type type)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	internal class PropertyEmitter : IMemberEmitter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly PropertyBuilder builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly AbstractTypeEmitter parentTypeEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private MethodEmitter getMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private MethodEmitter setMethod;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2D40DA0", Offset = "0x2D3F9A0", VA = "0x182D40DA0")]
		public PropertyEmitter(AbstractTypeEmitter parentTypeEmitter, string name, PropertyAttributes attributes, Type propertyType, Type[] arguments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2D408A0", Offset = "0x2D3F4A0", VA = "0x182D408A0")]
		public MethodEmitter CreateGetMethod(string name, MethodAttributes attrs, MethodInfo methodToOverride, params Type[] parameters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2D40990", Offset = "0x2D3F590", VA = "0x182D40990")]
		public MethodEmitter CreateGetMethod(string name, MethodAttributes attributes, MethodInfo methodToOverride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2D40BB0", Offset = "0x2D3F7B0", VA = "0x182D40BB0")]
		public MethodEmitter CreateSetMethod(string name, MethodAttributes attrs, MethodInfo methodToOverride, params Type[] parameters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2D40AA0", Offset = "0x2D3F6A0", VA = "0x182D40AA0")]
		public MethodEmitter CreateSetMethod(string name, MethodAttributes attributes, MethodInfo methodToOverride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2D40CA0", Offset = "0x2D3F8A0", VA = "0x182D40CA0")]
		public void DefineCustomAttribute(CustomAttributeBuilder attribute)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2D40CC0", Offset = "0x2D3F8C0", VA = "0x182D40CC0", Slot = "4")]
		public void EnsureValidCodeBlock()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2D40D10", Offset = "0x2D3F910", VA = "0x182D40D10", Slot = "5")]
		public void Generate()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal sealed class StindOpCodesDictionary : Dictionary<Type, OpCode>
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly StindOpCodesDictionary dict;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly OpCode emptyOpCode;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public new OpCode this[Type type]
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x2D432D0", Offset = "0x2D41ED0", VA = "0x182D432D0")]
			get
			{
				return default(OpCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public static OpCode EmptyOpCode
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x2D43230", Offset = "0x2D41E30", VA = "0x182D43230")]
			get
			{
				return default(OpCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public static StindOpCodesDictionary Instance
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x2D43280", Offset = "0x2D41E80", VA = "0x182D43280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2D42EF0", Offset = "0x2D41AF0", VA = "0x182D42EF0")]
		private StindOpCodesDictionary()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal static class StrongNameUtil
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly IDictionary<Assembly, bool> signedAssemblyCache;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static readonly object lockObject;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2D43700", Offset = "0x2D42300", VA = "0x182D43700")]
		public static bool IsAssemblySigned(this Assembly assembly)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2D433A0", Offset = "0x2D41FA0", VA = "0x182D433A0")]
		private static bool ContainsPublicKey(this Assembly assembly)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x2D43430", Offset = "0x2D42030", VA = "0x182D43430")]
		public static bool IsAnyTypeFromUnsignedAssembly(IEnumerable<Type> types)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2D43540", Offset = "0x2D42140", VA = "0x182D43540")]
		public static bool IsAnyTypeFromUnsignedAssembly(Type baseType, IEnumerable<Type> interfaces)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal class TypeConstructorEmitter : ConstructorEmitter
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2D44D80", Offset = "0x2D43980", VA = "0x182D44D80")]
		internal TypeConstructorEmitter(AbstractTypeEmitter maintype)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2D44D00", Offset = "0x2D43900", VA = "0x182D44D00", Slot = "6")]
		public override void EnsureValidCodeBlock()
		{
		}
	}
}
namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[DebuggerDisplay("argument {Type}")]
	internal class ArgumentReference : TypeReference
	{
		[Cpp2IlInjected.Token(Token = "0x17000062")]
		internal int Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xB6A400", Offset = "0xB69000", VA = "0x180B6A400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FF70", Offset = "0x2D2EB70", VA = "0x182D2FF70")]
		public ArgumentReference(Type argumentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FFB0", Offset = "0x2D2EBB0", VA = "0x182D2FFB0")]
		public ArgumentReference(Type argumentType, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FC60", Offset = "0x2D2E860", VA = "0x182D2FC60", Slot = "5")]
		public override void LoadAddressOfReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FCA0", Offset = "0x2D2E8A0", VA = "0x182D2FCA0", Slot = "6")]
		public override void LoadReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FE90", Offset = "0x2D2EA90", VA = "0x182D2FE90", Slot = "7")]
		public override void StoreReference(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal class AssignArgumentStatement : IStatement, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly ArgumentReference argument;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly IExpression expression;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public AssignArgumentStatement(ArgumentReference argument, IExpression expression)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2D30290", Offset = "0x2D2EE90", VA = "0x182D30290", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class AssignArrayStatement : IStatement, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly Reference targetArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly int targetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly IExpression value;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2D303F0", Offset = "0x2D2EFF0", VA = "0x182D303F0")]
		public AssignArrayStatement(Reference targetArray, int targetPosition, IExpression value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2D30300", Offset = "0x2D2EF00", VA = "0x182D30300", Slot = "4")]
		public void Emit(ILGenerator il)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal class AssignStatement : IStatement, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly IExpression expression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly Reference target;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2D304E0", Offset = "0x2D2F0E0", VA = "0x182D304E0")]
		public AssignStatement(Reference target, IExpression expression)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2D30450", Offset = "0x2D2F050", VA = "0x182D30450", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[DebuggerDisplay("{reference} as {type}")]
	internal class AsTypeReference : Reference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly Reference reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly Type type;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2D30110", Offset = "0x2D2ED10", VA = "0x182D30110")]
		public AsTypeReference(Reference reference, Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2D30000", Offset = "0x2D2EC00", VA = "0x182D30000", Slot = "5")]
		public override void LoadAddressOfReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2D30030", Offset = "0x2D2EC30", VA = "0x182D30030", Slot = "6")]
		public override void LoadReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2D300E0", Offset = "0x2D2ECE0", VA = "0x182D300E0", Slot = "7")]
		public override void StoreReference(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class BlockStatement : IStatement, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly List<IStatement> statements;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2D30530", Offset = "0x2D2F130", VA = "0x182D30530")]
		public void AddStatement(IStatement statement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2D305E0", Offset = "0x2D2F1E0", VA = "0x182D305E0", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2D30780", Offset = "0x2D2F380", VA = "0x182D30780")]
		public BlockStatement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[DebuggerDisplay("&{localReference}")]
	internal class ByRefReference : TypeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly LocalReference localReference;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2D30840", Offset = "0x2D2F440", VA = "0x182D30840")]
		public ByRefReference(LocalReference localReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x19C0E50", Offset = "0x19BFA50", VA = "0x1819C0E50", Slot = "5")]
		public override void LoadAddressOfReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x19C0E50", Offset = "0x19BFA50", VA = "0x1819C0E50", Slot = "6")]
		public override void LoadReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2D30800", Offset = "0x2D2F400", VA = "0x182D30800", Slot = "7")]
		public override void StoreReference(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	internal class ConstructorInvocationStatement : IStatement, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly IExpression[] args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly ConstructorInfo cmethod;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2D35810", Offset = "0x2D34410", VA = "0x182D35810")]
		public ConstructorInvocationStatement(Type baseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2D356E0", Offset = "0x2D342E0", VA = "0x182D356E0")]
		public ConstructorInvocationStatement(ConstructorInfo method, params IExpression[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2D35490", Offset = "0x2D34090", VA = "0x182D35490", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2D35640", Offset = "0x2D34240", VA = "0x182D35640")]
		private static ConstructorInfo GetDefaultConstructor(Type baseType)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal class ConvertExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly IExpression right;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private Type fromType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private Type target;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2D35EC0", Offset = "0x2D34AC0", VA = "0x182D35EC0")]
		public ConvertExpression(Type targetType, IExpression right)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2D35E50", Offset = "0x2D34A50", VA = "0x182D35E50")]
		public ConvertExpression(Type targetType, Type fromType, IExpression right)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2D35AC0", Offset = "0x2D346C0", VA = "0x182D35AC0", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2D358F0", Offset = "0x2D344F0", VA = "0x182D358F0")]
		private static void EmitCastIfNeeded(Type from, Type target, ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal class DefaultValueExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly Type type;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public DefaultValueExpression(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2D36100", Offset = "0x2D34D00", VA = "0x182D36100", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2D35F60", Offset = "0x2D34B60", VA = "0x182D35F60")]
		private void EmitByRef(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2D364B0", Offset = "0x2D350B0", VA = "0x182D364B0")]
		private bool IsPrimitiveOrClass(Type type)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal class EndExceptionBlockStatement : IStatement, IExpressionOrStatement
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2D366C0", Offset = "0x2D352C0", VA = "0x182D366C0", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public EndExceptionBlockStatement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[DebuggerDisplay("{fieldbuilder.Name} ({fieldbuilder.FieldType})")]
	internal class FieldReference : Reference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly FieldInfo field;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly FieldBuilder fieldbuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly bool isStatic;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public FieldBuilder Fieldbuilder
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public FieldInfo Reference
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2D36BA0", Offset = "0x2D357A0", VA = "0x182D36BA0")]
		public FieldReference(FieldInfo field)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2D36AC0", Offset = "0x2D356C0", VA = "0x182D36AC0")]
		public FieldReference(FieldBuilder fieldbuilder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2D36850", Offset = "0x2D35450", VA = "0x182D36850", Slot = "5")]
		public override void LoadAddressOfReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2D36920", Offset = "0x2D35520", VA = "0x182D36920", Slot = "6")]
		public override void LoadReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D369F0", Offset = "0x2D355F0", VA = "0x182D369F0", Slot = "7")]
		public override void StoreReference(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal class FinallyStatement : IStatement, IExpressionOrStatement
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D36C70", Offset = "0x2D35870", VA = "0x182D36C70", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public FinallyStatement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal interface IExpression : IExpressionOrStatement
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal interface IExpressionOrStatement
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Emit(ILGenerator gen);
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal class IfNullExpression : IExpression, IExpressionOrStatement, IStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly IExpressionOrStatement ifNotNull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly IExpressionOrStatement ifNull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly Reference reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly IExpression expression;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D36DE0", Offset = "0x2D359E0", VA = "0x182D36DE0")]
		public IfNullExpression(Reference reference, IExpressionOrStatement ifNull, [Optional] IExpressionOrStatement ifNotNull)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D36CA0", Offset = "0x2D358A0", VA = "0x182D36CA0", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[DebuggerDisplay("&{OwnerReference}")]
	internal class IndirectReference : TypeReference
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2D37240", Offset = "0x2D35E40", VA = "0x182D37240")]
		public IndirectReference(TypeReference byRefReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public override void LoadAddressOfReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D36EB0", Offset = "0x2D35AB0", VA = "0x182D36EB0", Slot = "6")]
		public override void LoadReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D36ED0", Offset = "0x2D35AD0", VA = "0x182D36ED0", Slot = "7")]
		public override void StoreReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D36EF0", Offset = "0x2D35AF0", VA = "0x182D36EF0")]
		public static TypeReference WrapIfByRef(TypeReference reference)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D37030", Offset = "0x2D35C30", VA = "0x182D37030")]
		public static TypeReference[] WrapIfByRef(TypeReference[] references)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	internal interface IStatement : IExpressionOrStatement
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal class LiteralBoolExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly bool value;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xDC26B0", Offset = "0xDC12B0", VA = "0x180DC26B0")]
		public LiteralBoolExpression(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D3AB00", Offset = "0x2D39700", VA = "0x182D3AB00", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	internal class LiteralIntExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly int value;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
		public LiteralIntExpression(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D3ABB0", Offset = "0x2D397B0", VA = "0x182D3ABB0", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal class LiteralStringExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly string value;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public LiteralStringExpression(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D3AF40", Offset = "0x2D39B40", VA = "0x182D3AF40", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal class LoadRefArrayElementExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly Reference arrayReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly LiteralIntExpression index;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B080", Offset = "0x2D39C80", VA = "0x182D3B080")]
		public LoadRefArrayElementExpression(int index, Reference arrayReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D3AFD0", Offset = "0x2D39BD0", VA = "0x182D3AFD0", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[DebuggerDisplay("local {Type}")]
	internal class LocalReference : TypeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private LocalBuilder localbuilder;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B320", Offset = "0x2D39F20", VA = "0x182D3B320")]
		public LocalReference(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B120", Offset = "0x2D39D20", VA = "0x182D3B120", Slot = "8")]
		public override void Generate(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B170", Offset = "0x2D39D70", VA = "0x182D3B170", Slot = "5")]
		public override void LoadAddressOfReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B200", Offset = "0x2D39E00", VA = "0x182D3B200", Slot = "6")]
		public override void LoadReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B290", Offset = "0x2D39E90", VA = "0x182D3B290", Slot = "7")]
		public override void StoreReference(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	internal class MethodInvocationExpression : IExpression, IExpressionOrStatement, IStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		protected readonly IExpression[] args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		protected readonly MethodInfo method;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		protected readonly Reference owner;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool VirtualCall
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xDD0FC0", Offset = "0xDCFBC0", VA = "0x180DD0FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xC901B0", Offset = "0xC8EDB0", VA = "0x180C901B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D3DAE0", Offset = "0x2D3C6E0", VA = "0x182D3DAE0")]
		public MethodInvocationExpression(MethodInfo method, params IExpression[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x2D35E50", Offset = "0x2D34A50", VA = "0x182D35E50")]
		public MethodInvocationExpression(Reference owner, MethodInfo method, params IExpression[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D930", Offset = "0x2D3C530", VA = "0x182D3D930", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	internal class MethodTokenExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly MethodInfo method;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public MethodTokenExpression(MethodInfo method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2D3DB90", Offset = "0x2D3C790", VA = "0x182D3DB90", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	internal class NewArrayExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly Type arrayType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly int size;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6490", Offset = "0x1FD5090", VA = "0x181FD6490")]
		public NewArrayExpression(int size, Type arrayType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F0D0", Offset = "0x2D3DCD0", VA = "0x182D3F0D0", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	internal class NewInstanceExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly IExpression[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private ConstructorInfo constructor;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F3F0", Offset = "0x2D3DFF0", VA = "0x182D3F3F0")]
		public NewInstanceExpression(ConstructorInfo constructor, params IExpression[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F310", Offset = "0x2D3DF10", VA = "0x182D3F310")]
		public NewInstanceExpression(Type target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F190", Offset = "0x2D3DD90", VA = "0x182D3F190", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	internal class NullCoalescingOperatorExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly IExpression @default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly IExpression expression;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F7E0", Offset = "0x2D3E3E0", VA = "0x182D3F7E0")]
		public NullCoalescingOperatorExpression(IExpression expression, IExpression @default)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F680", Offset = "0x2D3E280", VA = "0x182D3F680", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	internal class NullExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly NullExpression Instance;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected NullExpression()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F8D0", Offset = "0x2D3E4D0", VA = "0x182D3F8D0", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	internal abstract class Reference : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		protected Reference owner;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Reference OwnerReference
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x2D413B0", Offset = "0x2D3FFB0", VA = "0x182D413B0")]
		protected Reference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x2D41420", Offset = "0x2D40020", VA = "0x182D41420")]
		protected Reference(Reference owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void LoadAddressOfReference(ILGenerator gen);

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void LoadReference(ILGenerator gen);

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void StoreReference(ILGenerator gen);

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
		public virtual void Generate(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D413A0", Offset = "0x2D3FFA0", VA = "0x182D413A0", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	internal class ReferencesToObjectArrayExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly TypeReference[] args;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public ReferencesToObjectArrayExpression(params TypeReference[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D414B0", Offset = "0x2D400B0", VA = "0x182D414B0", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	internal class ReturnStatement : IStatement, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly IExpression expression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly Reference reference;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ReturnStatement()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xF09A40", Offset = "0xF08640", VA = "0x180F09A40")]
		public ReturnStatement(Reference reference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public ReturnStatement(IExpression expression)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x2D41860", Offset = "0x2D40460", VA = "0x182D41860", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[DebuggerDisplay("this")]
	internal class SelfReference : Reference
	{
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static readonly SelfReference Self;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x2D41AE0", Offset = "0x2D406E0", VA = "0x182D41AE0")]
		protected SelfReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x2D41930", Offset = "0x2D40530", VA = "0x182D41930", Slot = "5")]
		public override void LoadAddressOfReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x2D41970", Offset = "0x2D40570", VA = "0x182D41970", Slot = "6")]
		public override void LoadReference(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2D419F0", Offset = "0x2D405F0", VA = "0x182D419F0", Slot = "7")]
		public override void StoreReference(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	internal class ThrowStatement : IStatement, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly Type exceptionType;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2D304E0", Offset = "0x2D2F0E0", VA = "0x182D304E0")]
		public ThrowStatement(Type exceptionType, string errorMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2D43B10", Offset = "0x2D42710", VA = "0x182D43B10", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	internal class TryStatement : IStatement, IExpressionOrStatement
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2D44CD0", Offset = "0x2D438D0", VA = "0x182D44CD0", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public TryStatement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	internal abstract class TypeReference : Reference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly Type type;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Type Type
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B320", Offset = "0x2D39F20", VA = "0x182D3B320")]
		protected TypeReference(Type argumentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2D44E20", Offset = "0x2D43A20", VA = "0x182D44E20")]
		protected TypeReference(Reference owner, Type type)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	internal class TypeTokenExpression : IExpression, IExpressionOrStatement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly Type type;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public TypeTokenExpression(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2D44E60", Offset = "0x2D43A60", VA = "0x182D44E60", Slot = "4")]
		public void Emit(ILGenerator gen)
		{
		}
	}
}
namespace Castle.DynamicProxy.Contributors
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	internal class ClassMembersCollector : MembersCollector
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2D30A00", Offset = "0x2D2F600", VA = "0x182D30A00")]
		public ClassMembersCollector(Type targetType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2D308A0", Offset = "0x2D2F4A0", VA = "0x182D308A0", Slot = "5")]
		protected override MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal class ClassProxySerializableContributor : SerializableContributor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private bool delegateToBaseGetObjectData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private ConstructorInfo serializationConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly IList<FieldReference> serializedFields;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2D32550", Offset = "0x2D31150", VA = "0x182D32550")]
		public ClassProxySerializableContributor(Type targetType, Type[] interfaces, string typeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x2D30B10", Offset = "0x2D2F710", VA = "0x182D30B10", Slot = "9")]
		public override void CollectElementsToProxy(IProxyGenerationHook hook, MetaType model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D32100", Offset = "0x2D30D00", VA = "0x182D32100", Slot = "6")]
		public override void Generate(ClassEmitter @class)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D30A10", Offset = "0x2D2F610", VA = "0x182D30A10", Slot = "7")]
		protected override void AddAddValueInvocation(ArgumentReference serializationInfo, MethodEmitter getObjectData, FieldReference field)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D30D30", Offset = "0x2D2F930", VA = "0x182D30D30", Slot = "8")]
		protected override void CustomizeGetObjectData(CodeBuilder codebuilder, ArgumentReference serializationInfo, ArgumentReference streamingContext, ClassEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D31290", Offset = "0x2D2FE90", VA = "0x182D31290")]
		private void EmitCustomGetObjectData(CodeBuilder codebuilder, ArgumentReference serializationInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2D30F80", Offset = "0x2D2FB80", VA = "0x182D30F80")]
		private void EmitCallToBaseGetObjectData(CodeBuilder codebuilder, ArgumentReference serializationInfo, ArgumentReference streamingContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x2D30D20", Offset = "0x2D2F920", VA = "0x182D30D20")]
		private void Constructor(ClassEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D31930", Offset = "0x2D30530", VA = "0x182D31930")]
		private void GenerateSerializationConstructor(ClassEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x2D32140", Offset = "0x2D30D40", VA = "0x182D32140")]
		private bool VerifyIfBaseImplementsGetObjectData(Type baseType, MetaType model, [Out] MetaMethod getObjectData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class ClassProxyTargetContributor : CompositeTypeContributor
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class <GetCollectors>d__2 : IEnumerable<MembersCollector>, IEnumerable, IEnumerator<MembersCollector>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private MembersCollector <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public ClassProxyTargetContributor <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private IEnumerator<Type> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			MembersCollector IEnumerator<MembersCollector>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public <GetCollectors>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x2D45830", Offset = "0x2D44430", VA = "0x182D45830", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x2D44F50", Offset = "0x2D43B50", VA = "0x182D44F50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x2D45950", Offset = "0x2D44550", VA = "0x182D45950")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x2D457F0", Offset = "0x2D443F0", VA = "0x182D457F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x2D45670", Offset = "0x2D44270", VA = "0x182D45670", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MembersCollector> IEnumerable<MembersCollector>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x2D45670", Offset = "0x2D44270", VA = "0x182D45670", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Type targetType;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2D33670", Offset = "0x2D32270", VA = "0x182D33670")]
		public ClassProxyTargetContributor(Type targetType, INamingScope namingScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x2D32CD0", Offset = "0x2D318D0", VA = "0x182D32CD0", Slot = "6")]
		[IteratorStateMachine(typeof(<GetCollectors>d__2))]
		protected override IEnumerable<MembersCollector> GetCollectors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x2D332E0", Offset = "0x2D31EE0", VA = "0x182D332E0", Slot = "8")]
		protected override MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, OverrideMethodDelegate overrideMethod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2D32650", Offset = "0x2D31250", VA = "0x182D32650")]
		private Type BuildInvocationType(MetaMethod method, ClassEmitter @class)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2D327A0", Offset = "0x2D313A0", VA = "0x182D327A0")]
		private MethodBuilder CreateCallbackMethod(ClassEmitter emitter, MethodInfo methodInfo, MethodInfo methodOnTarget)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2D32CA0", Offset = "0x2D318A0", VA = "0x182D32CA0")]
		private bool ExplicitlyImplementedInterfaceMethod(MetaMethod method)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2D329C0", Offset = "0x2D315C0", VA = "0x182D329C0")]
		private MethodGenerator ExplicitlyImplementedInterfaceMethodGenerator(MetaMethod method, ClassEmitter @class, OverrideMethodDelegate overrideMethod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2D32D50", Offset = "0x2D31950", VA = "0x182D32D50")]
		private IInvocationCreationContributor GetContributor(Type @delegate, MetaMethod method)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2D32ED0", Offset = "0x2D31AD0", VA = "0x182D32ED0")]
		private Type GetDelegateType(MetaMethod method, ClassEmitter @class)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2D33190", Offset = "0x2D31D90", VA = "0x182D33190")]
		private Type GetInvocationType(MetaMethod method, ClassEmitter @class)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	internal class ClassProxyWithTargetTargetContributor : CompositeTypeContributor
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class <GetCollectors>d__2 : IEnumerable<MembersCollector>, IEnumerable, IEnumerator<MembersCollector>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private MembersCollector <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public ClassProxyWithTargetTargetContributor <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private IEnumerator<Type> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			MembersCollector IEnumerator<MembersCollector>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public <GetCollectors>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x2D458C0", Offset = "0x2D444C0", VA = "0x182D458C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2D452E0", Offset = "0x2D43EE0", VA = "0x182D452E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x2D459A0", Offset = "0x2D445A0", VA = "0x182D459A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x2D457B0", Offset = "0x2D443B0", VA = "0x182D457B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x2D45710", Offset = "0x2D44310", VA = "0x182D45710", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MembersCollector> IEnumerable<MembersCollector>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x2D45710", Offset = "0x2D44310", VA = "0x182D45710", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly Type targetType;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x2D33670", Offset = "0x2D32270", VA = "0x182D33670")]
		public ClassProxyWithTargetTargetContributor(Type targetType, INamingScope namingScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x2D337F0", Offset = "0x2D323F0", VA = "0x182D337F0", Slot = "6")]
		[IteratorStateMachine(typeof(<GetCollectors>d__2))]
		protected override IEnumerable<MembersCollector> GetCollectors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x2D33F10", Offset = "0x2D32B10", VA = "0x182D33F10", Slot = "8")]
		protected override MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, OverrideMethodDelegate overrideMethod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x2D336B0", Offset = "0x2D322B0", VA = "0x182D336B0")]
		private Type BuildInvocationType(MetaMethod method, ClassEmitter @class)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x2D33870", Offset = "0x2D32470", VA = "0x182D33870")]
		private IInvocationCreationContributor GetContributor(Type @delegate, MetaMethod method)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x2D339F0", Offset = "0x2D325F0", VA = "0x182D339F0")]
		private Type GetDelegateType(MetaMethod method, ClassEmitter @class)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x2D33CB0", Offset = "0x2D328B0", VA = "0x182D33CB0")]
		private Type GetInvocationType(MetaMethod method, ClassEmitter @class)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2D34210", Offset = "0x2D32E10", VA = "0x182D34210")]
		private MethodGenerator IndirectlyCalledMethodGenerator(MetaMethod method, ClassEmitter proxy, OverrideMethodDelegate overrideMethod, bool skipInterceptors = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x2D345B0", Offset = "0x2D331B0", VA = "0x182D345B0")]
		private bool IsDirectlyAccessible(MetaMethod method)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal abstract class CompositeTypeContributor : ITypeContributor
	{
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		private sealed class MembersCollectorSink : IMembersCollectorSink
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly MetaType model;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly CompositeTypeContributor contributor;

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
			public MembersCollectorSink(MetaType model, CompositeTypeContributor contributor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x2D3B360", Offset = "0x2D39F60", VA = "0x182D3B360", Slot = "4")]
			public void Add(MetaEvent @event)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x2D3B500", Offset = "0x2D3A100", VA = "0x182D3B500", Slot = "5")]
			public void Add(MetaMethod method)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x2D3B430", Offset = "0x2D3A030", VA = "0x182D3B430", Slot = "6")]
			public void Add(MetaProperty property)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		protected readonly INamingScope namingScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		protected readonly ICollection<Type> interfaces;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly List<MetaProperty> properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly List<MetaEvent> events;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private readonly List<MetaMethod> methods;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2D352E0", Offset = "0x2D33EE0", VA = "0x182D352E0")]
		protected CompositeTypeContributor(INamingScope namingScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2D34640", Offset = "0x2D33240", VA = "0x182D34640", Slot = "4")]
		public void CollectElementsToProxy(IProxyGenerationHook hook, MetaType model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract IEnumerable<MembersCollector> GetCollectors();

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2D34870", Offset = "0x2D33470", VA = "0x182D34870", Slot = "7")]
		public virtual void Generate(ClassEmitter @class)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2D345E0", Offset = "0x2D331E0", VA = "0x182D345E0")]
		public void AddInterfaceToProxy(Type @interface)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2D34D00", Offset = "0x2D33900", VA = "0x182D34D00")]
		private void ImplementEvent(ClassEmitter emitter, MetaEvent @event)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x2D35190", Offset = "0x2D33D90", VA = "0x182D35190")]
		private void ImplementProperty(ClassEmitter emitter, MetaProperty property)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, OverrideMethodDelegate overrideMethod);

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2D34F50", Offset = "0x2D33B50", VA = "0x182D34F50")]
		private void ImplementMethod(MetaMethod method, ClassEmitter @class, OverrideMethodDelegate overrideMethod)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	internal delegate MethodEmitter OverrideMethodDelegate(string name, MethodAttributes attributes, MethodInfo methodToOverride);
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	internal delegate IExpression GetTargetExpressionDelegate(ClassEmitter @class, MethodInfo method);
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	internal delegate Reference GetTargetReferenceDelegate(ClassEmitter @class, MethodInfo method);
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	internal sealed class DelegateTypeMembersCollector : MembersCollector
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2D30A00", Offset = "0x2D2F600", VA = "0x182D30A00")]
		public DelegateTypeMembersCollector(Type delegateType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2D365C0", Offset = "0x2D351C0", VA = "0x182D365C0", Slot = "5")]
		protected override MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal class FieldReferenceComparer : IComparer<Type>
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x2D366F0", Offset = "0x2D352F0", VA = "0x182D366F0", Slot = "4")]
		public int Compare(Type x, Type y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public FieldReferenceComparer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	internal interface IInvocationCreationContributor
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ConstructorEmitter CreateConstructor(ArgumentReference[] baseCtorArguments, AbstractTypeEmitter invocation);

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MethodInfo GetCallbackMethod();

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MethodInvocationExpression GetCallbackMethodInvocation(AbstractTypeEmitter invocation, IExpression[] args, Reference targetField, MethodEmitter invokeMethodOnTarget);

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IExpression[] GetConstructorInvocationArguments(IExpression[] arguments, ClassEmitter proxy);
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	internal interface IMembersCollectorSink
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(MetaEvent @event);

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Add(MetaMethod method);

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Add(MetaProperty property);
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	internal class InterfaceMembersCollector : MembersCollector
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2D30A00", Offset = "0x2D2F600", VA = "0x182D30A00")]
		public InterfaceMembersCollector(Type @interface)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x2D37330", Offset = "0x2D35F30", VA = "0x182D37330", Slot = "5")]
		protected override MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	internal class InterfaceMembersOnClassCollector : MembersCollector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private readonly InterfaceMapping map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly bool onlyProxyVirtual;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2D376E0", Offset = "0x2D362E0", VA = "0x182D376E0")]
		public InterfaceMembersOnClassCollector(Type type, bool onlyProxyVirtual, InterfaceMapping map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x2D374E0", Offset = "0x2D360E0", VA = "0x182D374E0", Slot = "5")]
		protected override MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2D37460", Offset = "0x2D36060", VA = "0x182D37460")]
		private MethodInfo GetMethodOnTarget(MethodInfo method)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2D37690", Offset = "0x2D36290", VA = "0x182D37690")]
		private bool IsVirtuallyImplementedInterfaceMethod(MethodInfo method)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	internal class InterfaceProxySerializableContributor : SerializableContributor
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2D37B70", Offset = "0x2D36770", VA = "0x182D37B70")]
		public InterfaceProxySerializableContributor(Type targetType, string proxyGeneratorId, Type[] interfaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2D37730", Offset = "0x2D36330", VA = "0x182D37730", Slot = "8")]
		protected override void CustomizeGetObjectData(CodeBuilder codebuilder, ArgumentReference serializationInfo, ArgumentReference streamingContext, ClassEmitter emitter)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	internal class InterfaceProxyTargetContributor : CompositeTypeContributor
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class <GetCollectors>d__3 : IEnumerable<MembersCollector>, IEnumerable, IEnumerator<MembersCollector>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private MembersCollector <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public InterfaceProxyTargetContributor <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private IEnumerator<Type> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			MembersCollector IEnumerator<MembersCollector>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public <GetCollectors>d__3(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x2D45FF0", Offset = "0x2D44BF0", VA = "0x182D45FF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x2D45C00", Offset = "0x2D44800", VA = "0x182D45C00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2D46110", Offset = "0x2D44D10", VA = "0x182D46110")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x2D45F70", Offset = "0x2D44B70", VA = "0x182D45F70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x2D45E30", Offset = "0x2D44A30", VA = "0x182D45E30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MembersCollector> IEnumerable<MembersCollector>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x2D45E30", Offset = "0x2D44A30", VA = "0x182D45E30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly bool canChangeTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly Type proxyTargetType;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2D38340", Offset = "0x2D36F40", VA = "0x182D38340")]
		public InterfaceProxyTargetContributor(Type proxyTargetType, bool canChangeTarget, INamingScope namingScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2D37CD0", Offset = "0x2D368D0", VA = "0x182D37CD0", Slot = "6")]
		[IteratorStateMachine(typeof(<GetCollectors>d__3))]
		protected override IEnumerable<MembersCollector> GetCollectors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x2D37C10", Offset = "0x2D36810", VA = "0x182D37C10", Slot = "9")]
		protected virtual MembersCollector GetCollectorForInterface(Type @interface)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x2D380A0", Offset = "0x2D36CA0", VA = "0x182D380A0", Slot = "8")]
		protected override MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, OverrideMethodDelegate overrideMethod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x2D37D50", Offset = "0x2D36950", VA = "0x182D37D50")]
		private Type GetInvocationType(MetaMethod method, ClassEmitter @class)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	internal class InterfaceProxyWithOptionalTargetContributor : InterfaceProxyWithoutTargetContributor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly GetTargetReferenceDelegate getTargetReference;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2D38500", Offset = "0x2D37100", VA = "0x182D38500")]
		public InterfaceProxyWithOptionalTargetContributor(INamingScope namingScope, GetTargetExpressionDelegate getTarget, GetTargetReferenceDelegate getTargetReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2D38390", Offset = "0x2D36F90", VA = "0x182D38390", Slot = "8")]
		protected override MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, OverrideMethodDelegate overrideMethod)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	internal class InterfaceProxyWithoutTargetContributor : CompositeTypeContributor
	{
		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class <GetCollectors>d__3 : IEnumerable<MembersCollector>, IEnumerable, IEnumerator<MembersCollector>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private MembersCollector <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public InterfaceProxyWithoutTargetContributor <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private IEnumerator<Type> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			MembersCollector IEnumerator<MembersCollector>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000370")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000372")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public <GetCollectors>d__3(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x2D46080", Offset = "0x2D44C80", VA = "0x182D46080", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x2D459F0", Offset = "0x2D445F0", VA = "0x182D459F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x2D46160", Offset = "0x2D44D60", VA = "0x182D46160")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x2D45FB0", Offset = "0x2D44BB0", VA = "0x182D45FB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x2D45ED0", Offset = "0x2D44AD0", VA = "0x182D45ED0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MembersCollector> IEnumerable<MembersCollector>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2D45ED0", Offset = "0x2D44AD0", VA = "0x182D45ED0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private readonly GetTargetExpressionDelegate getTargetExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		protected bool canChangeTarget;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2D38B10", Offset = "0x2D37710", VA = "0x182D38B10")]
		public InterfaceProxyWithoutTargetContributor(INamingScope namingScope, GetTargetExpressionDelegate getTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x2D385C0", Offset = "0x2D371C0", VA = "0x182D385C0", Slot = "6")]
		[IteratorStateMachine(typeof(<GetCollectors>d__3))]
		protected override IEnumerable<MembersCollector> GetCollectors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2D389F0", Offset = "0x2D375F0", VA = "0x182D389F0", Slot = "8")]
		protected override MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, OverrideMethodDelegate overrideMethod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2D38640", Offset = "0x2D37240", VA = "0x182D38640")]
		private Type GetInvocationType(MetaMethod method, ClassEmitter emitter)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	internal class InterfaceProxyWithTargetInterfaceTargetContributor : InterfaceProxyTargetContributor
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x2D38340", Offset = "0x2D36F40", VA = "0x182D38340")]
		public InterfaceProxyWithTargetInterfaceTargetContributor(Type proxyTargetType, bool allowChangeTarget, INamingScope namingScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x2D38560", Offset = "0x2D37160", VA = "0x182D38560", Slot = "9")]
		protected override MembersCollector GetCollectorForInterface(Type @interface)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal class InvocationWithDelegateContributor : IInvocationCreationContributor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private readonly Type delegateType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MetaMethod method;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly INamingScope namingScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly Type targetType;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x2D39670", Offset = "0x2D38270", VA = "0x182D39670")]
		public InvocationWithDelegateContributor(Type delegateType, Type targetType, MetaMethod method, INamingScope namingScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2D38F20", Offset = "0x2D37B20", VA = "0x182D38F20", Slot = "4")]
		public ConstructorEmitter CreateConstructor(ArgumentReference[] baseCtorArguments, AbstractTypeEmitter invocation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x2D39520", Offset = "0x2D38120", VA = "0x182D39520", Slot = "5")]
		public MethodInfo GetCallbackMethod()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x2D39330", Offset = "0x2D37F30", VA = "0x182D39330", Slot = "6")]
		public MethodInvocationExpression GetCallbackMethodInvocation(AbstractTypeEmitter invocation, IExpression[] args, Reference targetField, MethodEmitter invokeMethodOnTarget)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x2D39570", Offset = "0x2D38170", VA = "0x182D39570", Slot = "7")]
		public IExpression[] GetConstructorInvocationArguments(IExpression[] arguments, ClassEmitter proxy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x2D38B50", Offset = "0x2D37750", VA = "0x182D38B50")]
		private FieldReference BuildDelegateToken(ClassEmitter proxy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x2D39110", Offset = "0x2D37D10", VA = "0x182D39110")]
		private IExpression[] GetAllArgs(IExpression[] args, Reference targetField)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x2D39220", Offset = "0x2D37E20", VA = "0x182D39220")]
		private ArgumentReference[] GetArguments(ArgumentReference[] baseCtorArguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	internal class InvocationWithGenericDelegateContributor : IInvocationCreationContributor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private readonly Type delegateType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly MetaMethod method;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private readonly Reference targetReference;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xE3EF80", Offset = "0xE3DB80", VA = "0x180E3EF80")]
		public InvocationWithGenericDelegateContributor(Type delegateType, MetaMethod method, Reference targetReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x2D396F0", Offset = "0x2D382F0", VA = "0x182D396F0", Slot = "4")]
		public ConstructorEmitter CreateConstructor(ArgumentReference[] baseCtorArguments, AbstractTypeEmitter invocation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2D398E0", Offset = "0x2D384E0", VA = "0x182D398E0", Slot = "5")]
		public MethodInfo GetCallbackMethod()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x2D39720", Offset = "0x2D38320", VA = "0x182D39720", Slot = "6")]
		public MethodInvocationExpression GetCallbackMethodInvocation(AbstractTypeEmitter invocation, IExpression[] args, Reference targetField, MethodEmitter invokeMethodOnTarget)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xB7C8B0", Offset = "0xB7B4B0", VA = "0x180B7C8B0", Slot = "7")]
		public IExpression[] GetConstructorInvocationArguments(IExpression[] arguments, ClassEmitter proxy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x2D39930", Offset = "0x2D38530", VA = "0x182D39930")]
		private Reference GetDelegate(AbstractTypeEmitter invocation, MethodEmitter invokeMethodOnTarget)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x2D39A40", Offset = "0x2D38640", VA = "0x182D39A40")]
		private AssignStatement SetDelegate(LocalReference localDelegate, Reference localTarget, Type closedDelegateType, MethodInfo closedMethodOnTarget)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	internal interface ITypeContributor
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CollectElementsToProxy(IProxyGenerationHook hook, MetaType model);

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Generate(ClassEmitter @class);
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	internal abstract class MembersCollector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		protected readonly Type type;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2D3C780", Offset = "0x2D3B380", VA = "0x182D3C780")]
		protected MembersCollector(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2D3BBC0", Offset = "0x2D3A7C0", VA = "0x182D3BBC0", Slot = "4")]
		public virtual void CollectMembersToProxy(IProxyGenerationHook hook, IMembersCollectorSink sink)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone);

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2D3BB20", Offset = "0x2D3A720", VA = "0x182D3BB20")]
		protected bool AcceptMethod(MethodInfo method, bool onlyVirtuals, IProxyGenerationHook hook)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B5D0", Offset = "0x2D3A1D0", VA = "0x182D3B5D0")]
		protected bool AcceptMethodPreScreen(MethodInfo method, bool onlyVirtuals, IProxyGenerationHook hook)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2D3BDE0", Offset = "0x2D3A9E0", VA = "0x182D3BDE0")]
		private static bool IsInternalAndNotVisibleToDynamicProxy(MethodInfo method)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	internal class MixinContributor : CompositeTypeContributor
	{
		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class <GetCollectors>d__9 : IEnumerable<MembersCollector>, IEnumerable, IEnumerator<MembersCollector>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			private MembersCollector <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public MixinContributor <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			private IEnumerator<Type> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			MembersCollector IEnumerator<MembersCollector>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003AC")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003AE")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public <GetCollectors>d__9(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x2D464F0", Offset = "0x2D450F0", VA = "0x182D464F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x2D461B0", Offset = "0x2D44DB0", VA = "0x182D461B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x2D46580", Offset = "0x2D45180", VA = "0x182D46580")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x2D464B0", Offset = "0x2D450B0", VA = "0x182D464B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x2D46410", Offset = "0x2D45010", VA = "0x182D46410", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MembersCollector> IEnumerable<MembersCollector>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x2D46410", Offset = "0x2D45010", VA = "0x182D46410", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly bool canChangeTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly IList<Type> empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly IDictionary<Type, FieldReference> fields;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetTargetExpressionDelegate getTargetExpression;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public IEnumerable<FieldReference> Fields
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x2D3F080", Offset = "0x2D3DC80", VA = "0x182D3F080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2D3EEF0", Offset = "0x2D3DAF0", VA = "0x182D3EEF0")]
		public MixinContributor(INamingScope namingScope, bool canChangeTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2D3DD40", Offset = "0x2D3C940", VA = "0x182D3DD40")]
		public void AddEmptyInterface(Type @interface)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x2D3DF20", Offset = "0x2D3CB20", VA = "0x182D3DF20", Slot = "7")]
		public override void Generate(ClassEmitter @class)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2D3E5D0", Offset = "0x2D3D1D0", VA = "0x182D3E5D0", Slot = "6")]
		[IteratorStateMachine(typeof(<GetCollectors>d__9))]
		protected override IEnumerable<MembersCollector> GetCollectors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2D3E9A0", Offset = "0x2D3D5A0", VA = "0x182D3E9A0", Slot = "8")]
		protected override MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, OverrideMethodDelegate overrideMethod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D3DDA0", Offset = "0x2D3C9A0", VA = "0x182D3DDA0")]
		private GetTargetExpressionDelegate BuildGetTargetExpression()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2D3DE30", Offset = "0x2D3CA30", VA = "0x182D3DE30")]
		private FieldReference BuildTargetField(ClassEmitter @class, Type type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x2D3E650", Offset = "0x2D3D250", VA = "0x182D3E650")]
		private Type GetInvocationType(MetaMethod method, ClassEmitter emitter)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	internal sealed class NonInheritableAttributesContributor : ITypeContributor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly Type targetType;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public NonInheritableAttributesContributor(Type targetType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F4A0", Offset = "0x2D3E0A0", VA = "0x182D3F4A0", Slot = "5")]
		public void Generate(ClassEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
		public void CollectElementsToProxy(IProxyGenerationHook hook, MetaType model)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	internal sealed class ProxyTargetAccessorContributor : ITypeContributor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private readonly Func<Reference> getTargetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private readonly Type targetType;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public ProxyTargetAccessorContributor(Func<Reference> getTargetReference, Type targetType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
		public void CollectElementsToProxy(IProxyGenerationHook hook, MetaType model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D40E60", Offset = "0x2D3FA60", VA = "0x182D40E60", Slot = "5")]
		public void Generate(ClassEmitter emitter)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	internal abstract class SerializableContributor : ITypeContributor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected readonly Type targetType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly string proxyTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly Type[] interfaces;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D42DD0", Offset = "0x2D419D0", VA = "0x182D42DD0")]
		protected SerializableContributor(Type targetType, Type[] interfaces, string proxyTypeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D41D10", Offset = "0x2D40910", VA = "0x182D41D10", Slot = "6")]
		public virtual void Generate(ClassEmitter @class)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D41D20", Offset = "0x2D40920", VA = "0x182D41D20")]
		protected void ImplementGetObjectData(ClassEmitter emitter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D41AF0", Offset = "0x2D406F0", VA = "0x182D41AF0", Slot = "7")]
		protected virtual void AddAddValueInvocation(ArgumentReference serializationInfo, MethodEmitter getObjectData, FieldReference field)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void CustomizeGetObjectData(CodeBuilder builder, ArgumentReference serializationInfo, ArgumentReference streamingContext, ClassEmitter emitter);

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "9")]
		public virtual void CollectElementsToProxy(IProxyGenerationHook hook, MetaType model)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	internal class WrappedClassMembersCollector : ClassMembersCollector
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2D30A00", Offset = "0x2D2F600", VA = "0x182D30A00")]
		public WrappedClassMembersCollector(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2D470E0", Offset = "0x2D45CE0", VA = "0x182D470E0", Slot = "4")]
		public override void CollectMembersToProxy(IProxyGenerationHook hook, IMembersCollectorSink sink)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x2D471C0", Offset = "0x2D45DC0", VA = "0x182D471C0", Slot = "5")]
		protected override MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2D472D0", Offset = "0x2D45ED0", VA = "0x182D472D0")]
		protected bool IsGeneratedByTheCompiler(FieldInfo field)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x2D472D0", Offset = "0x2D45ED0", VA = "0x182D472D0", Slot = "6")]
		protected virtual bool IsOKToBeOnProxy(FieldInfo field)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2D47000", Offset = "0x2D45C00", VA = "0x182D47000")]
		private void CollectFields(IProxyGenerationHook hook)
		{
		}
	}
}
namespace Castle.Core.Logging
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public interface ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		bool IsWarnEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DebugFormat(string format, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WarnFormat(string format, params object[] args);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public abstract class LevelFilteredLogger : ILogger
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private LoggerLevel level;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private string name;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public LoggerLevel Level
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			get
			{
				return default(LoggerLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool IsDebugEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x2D3AAE0", Offset = "0x2D396E0", VA = "0x182D3AAE0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public bool IsWarnEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x2D3AAF0", Offset = "0x2D396F0", VA = "0x182D3AAF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x2D3A9C0", Offset = "0x2D395C0", VA = "0x182D3A9C0")]
		protected LevelFilteredLogger()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2D3A960", Offset = "0x2D39560", VA = "0x182D3A960")]
		protected LevelFilteredLogger(LoggerLevel loggerLevel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2D3AA10", Offset = "0x2D39610", VA = "0x182D3AA10")]
		protected LevelFilteredLogger(string loggerName, LoggerLevel loggerLevel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x2D3A7D0", Offset = "0x2D393D0", VA = "0x182D3A7D0", Slot = "5")]
		public void DebugFormat(string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2D3A8B0", Offset = "0x2D394B0", VA = "0x182D3A8B0", Slot = "6")]
		public void WarnFormat(string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void Log(LoggerLevel loggerLevel, string loggerName, string message, Exception exception);

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x2D3A760", Offset = "0x2D39360", VA = "0x182D3A760")]
		protected void ChangeName(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D3A880", Offset = "0x2D39480", VA = "0x182D3A880")]
		private void Log(LoggerLevel loggerLevel, string message, Exception exception)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public enum LoggerLevel
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Fatal,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Warn,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		Debug,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		Trace
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public class NullLogger : ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public static readonly NullLogger Instance;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool IsWarnEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public void DebugFormat(string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "6")]
		public void WarnFormat(string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public NullLogger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class TraceLogger : LevelFilteredLogger
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly Dictionary<string, TraceSource> cache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private TraceSource traceSource;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D44AD0", Offset = "0x2D436D0", VA = "0x182D44AD0")]
		public TraceLogger(string name, LoggerLevel level)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2D44680", Offset = "0x2D43280", VA = "0x182D44680", Slot = "8")]
		protected override void Log(LoggerLevel loggerLevel, string loggerName, string message, Exception exception)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D43EE0", Offset = "0x2D42AE0", VA = "0x182D43EE0")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2D449F0", Offset = "0x2D435F0", VA = "0x182D449F0")]
		private static string ShortenName(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x2D44560", Offset = "0x2D43160", VA = "0x182D44560")]
		private static bool IsSourceConfigured(TraceSource source)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2D448D0", Offset = "0x2D434D0", VA = "0x182D448D0")]
		private static LoggerLevel MapLoggerLevel(SourceLevels level)
		{
			return default(LoggerLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2D44930", Offset = "0x2D43530", VA = "0x182D44930")]
		private static SourceLevels MapSourceLevels(LoggerLevel level)
		{
			return default(SourceLevels);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2D44990", Offset = "0x2D43590", VA = "0x182D44990")]
		private static TraceEventType MapTraceEventType(LoggerLevel level)
		{
			return default(TraceEventType);
		}
	}
}
namespace Castle.Core.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	internal sealed class SynchronizedDictionary<TKey, TValue> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Dictionary<TKey, TValue> items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private ReaderWriterLockSlim itemsLock;

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x65DBA90", Offset = "0x65DA690", VA = "0x1865DBA90")]
		public SynchronizedDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x65DA770", Offset = "0x65D9370", VA = "0x1865DA770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x65DAF70", Offset = "0x65D9B70", VA = "0x1865DAF70")]
		public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
		{
			return (TValue)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x65DA840", Offset = "0x65D9440", VA = "0x1865DA840")]
		public TValue GetOrAddWithoutTakingLock(TKey key, Func<TKey, TValue> valueFactory)
		{
			return (TValue)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal static class TypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2D44DD0", Offset = "0x2D439D0", VA = "0x182D44DD0")]
		public static string GetBestName(this Type type)
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
